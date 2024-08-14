using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.ObjectSelector
{
    public interface IStringSelectorValueProvider
    {
        List<string> GetStandartdValues(string propname);
    }

    internal class StringSelectorValueConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
        {
            if (destinationType == typeof(string)) return true;
            if (destinationType == typeof(InstanceDescriptor)) return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
        {
            if (sourceType == typeof(string)) return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if (value == null || !(value is StringValueSelector || value is string))
                return base.ConvertTo(context, culture, value, destinationType);
            if (destinationType == typeof(string))
            {
                if (value is string) return value;
                if (value is StringValueSelector svs) return svs.Value;
            }
            else if (destinationType == typeof(InstanceDescriptor))
            {
                string sval = value is string s ? s : (value is StringValueSelector sv ? sv.Value : null);
                var member = typeof(StringValueSelector).GetConstructor(new[] { typeof(string) });
                var args = new object[] { sval };
                return new InstanceDescriptor(member, args);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
        {
            if (value == null || value is string)
            {
                return new StringValueSelector((string)value);
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override StandardValuesCollection? GetStandardValues(ITypeDescriptorContext? context)
        {
            var ivalue_provider = context.Instance as IStringSelectorValueProvider;
            if (ivalue_provider == null) return null;
            var value_list = ivalue_provider.GetStandartdValues(context.PropertyDescriptor.Name);
            if (value_list == null) return null;
            var ret = value_list.Select(x => new StringValueSelector(x)).ToList();
            return new StandardValuesCollection(ret);
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext? context)
            => true;


    }


}
