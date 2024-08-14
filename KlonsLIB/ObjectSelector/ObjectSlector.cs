using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.ObjectSelector
{
    [TypeConverter(typeof(ObjectSelectorTypeConverter))]
    public class ObjectSelector : IStringSelectorValueProvider
    {
        public ObjectSelector() { }

        public ObjectSelector(string pdatasource, string pdatamember)
        {
            dataSource = pdatasource;
            dataMember = pdatamember;
            CheckSelector();
        }

        private StringValueSelector dataSource = new StringValueSelector(null);
        private StringValueSelector dataMember = new StringValueSelector(null);

        [RefreshProperties(RefreshProperties.All)]
        public StringValueSelector DataSource { get => dataSource; }
        public StringValueSelector DataMember { get => dataMember; }

        protected void CheckSelector()
        {
            if (dataSource?.Value == null)
            {
                dataMember = null;
                return;
            }
            var datasources = GetDataSources();
            if (datasources == null || !datasources.Contains(dataSource))
            {
                dataSource = null;
                dataMember = null;
                return;
            }
            if (dataMember?.Value != null)
            {
                var datamembers = GetDatamembers(dataSource);
                if (datamembers == null || !datamembers.Contains(dataMember))
                {
                    dataMember = null;
                }
            }
        }

        public override string ToString()
        {
            var ds = DataSource?.Value ?? "";
            var tb = DataMember?.Value ?? "";
            return $"{tb}({ds})";
        }

        public List<string> GetStandartdValues(string propname)
        {
            if (propname == null) return null;
            if (propname == nameof(DataSource))
                return GetDataSources();
            if (propname == nameof(DataMember))
                return GetDatamembers(DataSource?.Value);
            return null;
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            if(!(obj is ObjectSelector cobj)) return false;
            return cobj.DataMember?.Value == this.DataMember?.Value &&
                cobj.dataSource?.Value == this.dataSource?.Value;
        }

        public virtual List<string> GetDataSources()
        {
            return null;
        }

        public virtual List<string> GetDatamembers(string dataset)
        {
            return null;
        }

    }

}
