using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Diagnostics;
using System.Collections;

namespace KGySoft.ComponentModel
{
    public static class Extensions
    {
        internal static bool CanBeCreatedWithoutParameters(this Type type)
            => type.IsValueType || type.GetDefaultConstructor() != null;

        internal static ConstructorInfo? GetDefaultConstructor(this Type type)
            => type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);

        internal static Type GetGenericType(this Type genTypeDef, params Type[] typeArgs)
        {
            Debug.Assert(!typeArgs.IsNullOrEmpty());
            return genTypeDef.MakeGenericType(typeArgs);
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T>? source)
        {
            if (source == null)
                return true;

            if (source is ICollection<T> collection)
                return collection.Count == 0;

#if !(NET35 || NET40)
            if (source is IReadOnlyCollection<T> readOnlyCollection)
                return readOnlyCollection.Count == 0;
#endif

            return ((IEnumerable)source).IsNullOrEmpty();
        }

        public static bool IsNullOrEmpty(this IEnumerable? source)
        {
            if (source == null)
                return true;

            if (source is ICollection collection)
                return collection.Count == 0;

            if (source is string str)
                return str.Length == 0;

            IEnumerator enumerator = source.GetEnumerator();
            try
            {
                return !enumerator.MoveNext();
            }
            finally
            {
                (enumerator as IDisposable)?.Dispose();
            }
        }
    }

    public static class DelegateExtensions
    {
        /// <summary>
        /// Combines <paramref name="value"/> with the referenced <paramref name="location"/> in a thread-safe way.
        /// </summary>
        /// <typeparam name="TDelegate">The type of the delegate.</typeparam>
        /// <param name="value">The value to combine with the referenced <paramref name="location"/>.</param>
        /// <param name="location">The reference of the delegate to combine with <paramref name="value"/>.</param>
        public static void AddSafe<TDelegate>(this TDelegate? value, ref TDelegate? location)
            where TDelegate : Delegate
        {
            while (true)
            {
                TDelegate? current = location;
                if (Interlocked.CompareExchange(ref location, (TDelegate?)Delegate.Combine(current, value), current) == current)
                    return;
            }
        }

        /// <summary>
        /// If the referenced <paramref name="location"/> contains the <paramref name="value"/> delegate, then the last occurrence of it will be removed in a thread-safe way.
        /// </summary>
        /// <typeparam name="TDelegate">The type of the delegate.</typeparam>
        /// <param name="value">The value to remove from the referenced <paramref name="location"/>.</param>
        /// <param name="location">The reference of the delegate from which <paramref name="value"/> should be removed.</param>
        public static void RemoveSafe<TDelegate>(this TDelegate? value, ref TDelegate? location)
            where TDelegate : Delegate
        {
            while (true)
            {
                TDelegate? current = location;
                if (Interlocked.CompareExchange(ref location, (TDelegate?)Delegate.Remove(current, value), current) == current)
                    return;
            }
        }
    }


    public static class Throw
    {
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void ObjectDisposedException() => throw CreateObjectDisposedException("Object disposed {0}");
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void InvalidOperationException(string? message = null) => throw CreateInvalidOperationException(message);
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void NotSupportedException(string message) => throw CreateNotSupportedException(message);
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void ArgumentOutOfRangeException(string paramName) => throw CreateArgumentOutOfRangeException(paramName, "Arhument out of range");
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static T NotSupportedException<T>() => throw CreateNotSupportedException("Not supported");
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void ArgumentNullException(string arg) => throw CreateArgumentNullException(arg, "Argument is null");
        [ContractAnnotation("=> halt")][DoesNotReturn] internal static void ArgumentException(string arg, string message) => throw CreateArgumentException(arg, message);
        [ContractAnnotation("=> halt")]
        [DoesNotReturn]
        internal static void EnumArgumentOutOfRange<TEnum>(string arg, TEnum value) where TEnum : struct, Enum
            => throw CreateArgumentOutOfRangeException(arg, "Enum Out Of Range");
        private static Exception CreateArgumentNullException(string arg, string message) => new ArgumentNullException(arg, message);
        private static Exception CreateObjectDisposedException(string message, string? name = null) => new ObjectDisposedException(name, message);
        private static Exception CreateInvalidOperationException(string? message, Exception? inner = null) => new InvalidOperationException(message, inner);
        private static Exception CreateNotSupportedException(string message, Exception? inner = null) => new NotSupportedException(message, inner);
        private static Exception CreateArgumentOutOfRangeException(string paramName, string message) => new ArgumentOutOfRangeException(paramName, message);
        private static Exception CreateArgumentException(string? arg, string message, Exception? inner = null) => arg != null ? new ArgumentException(message, arg, inner) : new ArgumentException(message, inner);


        internal static bool IsCritical(this Exception e) => e is OutOfMemoryException || e is StackOverflowException;
        internal static bool IsCriticalOr(this Exception e, bool condition) => e.IsCritical() || condition;
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal sealed class ContractAnnotationAttribute : Attribute
    {
        public ContractAnnotationAttribute([NotNull] string contract)
          : this(contract, false) { }

        public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
        {
            Contract = contract;
            ForceFullStates = forceFullStates;
        }

        [NotNull] public string Contract { get; private set; }

        public bool ForceFullStates { get; private set; }
    }


    [AttributeUsage(
      AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property |
      AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event |
      AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.GenericParameter)]
    internal sealed class CanBeNullAttribute : Attribute { }


    [AttributeUsage(AttributeTargets.Method)]
    internal sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
    {
        public NotifyPropertyChangedInvocatorAttribute() { }
        public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
        {
            ParameterName = parameterName;
        }

        [CanBeNull] public string? ParameterName { get; private set; }
    }

    public enum ReflectionWays
    {
        /// <summary>
        /// Auto decision. In most cases it uses the <see cref="DynamicDelegate"/> way.
        /// </summary>
        Auto,

        /// <summary>
        /// Dynamic delegate way. This option uses cached <see cref="MemberAccessor"/> instances for reflection.
        /// In this case first access of a member is slower than accessing it via system reflection but further accesses are much more faster.
        /// </summary>
        DynamicDelegate,

        /// <summary>
        /// Uses the standard system reflection way.
        /// </summary>
        SystemReflection,

        /// <summary>
        /// Uses the type descriptor way. If there is no <see cref="ICustomTypeDescriptor"/> implementation for an instance,
        /// then this can be the slowest way as it internally falls back to use system reflection. Not applicable in all cases.
        /// </summary>
        TypeDescriptor
    }

    public static class Reflector
    {
        public static bool TryCreateInstanceByType(Type type, Type[] genericParameters, ReflectionWays way, bool throwError, [MaybeNullWhen(false)] out object result)
        {
            result = null;

            // if the type is generic we need the generic arguments and a constructed type with real types
            if (type.IsGenericTypeDefinition)
            {
                Type[] genArgs = type.GetGenericArguments();
                if (genericParameters.Length != genArgs.Length)
                {
                    if (throwError)
                        Throw.ArgumentException("Generic Parameters", "Reflection TypeArgs Length Mismatch " + genArgs.Length);
                    return false;
                }
                try
                {
                    type = type.GetGenericType(genericParameters);
                }
                catch (Exception e) when (!e.IsCriticalOr(throwError))
                {
                    return false;
                }
            }

            if (!throwError && !type.CanBeCreatedWithoutParameters())
                return false;

            switch (way)
            {
                case ReflectionWays.Auto:
                case ReflectionWays.DynamicDelegate:
                case ReflectionWays.SystemReflection:
                    try
                    {
#if NETFRAMEWORK || NETSTANDARD2_0
                        // In .NET Framework Activator.CreateInstance fails to invoke the parameterless struct constructor if exists, see https://github.com/dotnet/runtime/issues/6536
                        result = type.IsValueType && type.GetDefaultConstructor() is ConstructorInfo ci ? ci.Invoke(null) : Activator.CreateInstance(type, true);
#else
                        result = Activator.CreateInstance(type, true);
#endif
                        return result != null;
                    }
                    catch (TargetInvocationException e)
                    {
                        if (e.InnerException != null)
                            ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                        throw;
                    }

                case ReflectionWays.TypeDescriptor:
                    result = TypeDescriptor.CreateInstance(null, type, null, null)!;
                    return true;
                default:
                    Throw.EnumArgumentOutOfRange("ReflectionWays", way);
                    return false;
            }
        }

        public static object CreateInstance(Type type, Type[]? genericParameters, ReflectionWays way = ReflectionWays.Auto)
        {
            if (type == null!)
                Throw.ArgumentNullException("type");
            TryCreateInstanceByType(type, genericParameters ?? Type.EmptyTypes, way, true, out object? result);
            return result!;
        }

        public static object CreateInstance(Type type, ReflectionWays way = ReflectionWays.Auto)
            => CreateInstance(type, null, way);

    }

}
