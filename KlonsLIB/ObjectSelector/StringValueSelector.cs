using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.ObjectSelector
{
    [TypeConverter(typeof(StringSelectorValueConverter))]
    public class StringValueSelector 
    {
        public readonly string Value;
        public StringValueSelector(string value) => Value = value;
        public static implicit operator string(StringValueSelector d) => d?.Value;
        public static implicit operator StringValueSelector(string d) => new StringValueSelector(d);
    }


}
