using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib7.Data
{
    public static class DataMemberFieldListProvider
    {
        public static List<string> GetDataSourceContents(object dataSource)
        {
            var ret = new List<string>();
            var bindingContext = new BindingContext();

            if (dataSource is Type)
            {
                try
                {
                    dataSource = new BindingSource
                    {
                        DataSource = dataSource
                    }.List;
                }
                catch (Exception ex)
                {
                    return ret;
                }
            }
            if (!IsBindableDataSource(dataSource))
            {
                return ret;
            }
            var properties = GetItemProperties(dataSource, null, bindingContext);
            if (properties == null)
            {
                return ret;
            }
            for (int i = 0; i < properties.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = properties[i];
                if (IsBindableDataMember(propertyDescriptor))
                {
                    string dataMember = propertyDescriptor.Name;
                    ret.Add(dataMember);
                }
            }
            return ret;
        }

        private static bool IsBindableDataSource(object dataSource)
        {
            if (!(dataSource is IListSource) && !(dataSource is IList) && !(dataSource is Array))
            {
                return false;
            }
            ListBindableAttribute listBindableAttribute = (ListBindableAttribute)TypeDescriptor.GetAttributes(dataSource)[typeof(ListBindableAttribute)];
            return listBindableAttribute == null || listBindableAttribute.ListBindable;
        }

        private static bool IsBindableDataMember(PropertyDescriptor property)
        {
            if (typeof(byte[]).IsAssignableFrom(property.PropertyType))
            {
                return true;
            }
            ListBindableAttribute listBindableAttribute = (ListBindableAttribute)property.Attributes[typeof(ListBindableAttribute)];
            return listBindableAttribute == null || listBindableAttribute.ListBindable;
        }

        private static PropertyDescriptorCollection GetItemProperties(object dataSource, string dataMember, BindingContext bindingContext)
        {
            CurrencyManager currencyManager = (CurrencyManager)bindingContext[dataSource, dataMember];
            if (currencyManager != null)
            {
                return currencyManager.GetItemProperties();
            }
            return null;
        }

    }
}
