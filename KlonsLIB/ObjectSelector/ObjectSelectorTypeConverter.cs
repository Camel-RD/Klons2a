using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.ObjectSelector
{
    public  class ObjectSelectorTypeConverter : ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
        {
            if (destinationType == typeof(string)) return true;
            if (destinationType == typeof(InstanceDescriptor)) return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if (value == null) goto skip;
            if (destinationType == typeof(string))
            {
                if (value is string) return value;
                if (value is ObjectSelector dss) return dss.ToString();
            }
            else if (destinationType == typeof(InstanceDescriptor))
            {
                if (value is ObjectSelector dss)
                {
                    var member = value.GetType().GetConstructor(new[] { typeof(string), typeof(string) });
                    var args = new object[] { dss.DataSource?.Value, dss.DataMember?.Value };
                    return new InstanceDescriptor(member, args);
                }
            }
            skip:
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
            if (propertyValues == null)
            {
                throw new ArgumentNullException("propertyValues");
            }

            object ds = propertyValues[nameof(ObjectSelector.DataSource)];
            object tb = propertyValues[nameof(ObjectSelector.DataMember)];
            if (ds is string sds)
                ds = new StringValueSelector(sds);
            if (tb is string stb)
                tb = new StringValueSelector(stb);
            if (ds != null && !(ds is StringValueSelector) || 
                tb != null && !(tb is StringValueSelector))
            {
                throw new ArgumentException("Property Value Invalid");
            }

            var member = context.PropertyDescriptor.PropertyType.GetConstructor(new[] { typeof(string), typeof(string) });
            var args = new object[] { ((StringValueSelector)ds)?.Value, ((StringValueSelector)tb)?.Value };
            var ret = member.Invoke(args);
            return ret;
            //return new ObjectSelector((StringValueSelector)ds, (StringValueSelector)tb);
        }

        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
            return true;
        }

    }
}
