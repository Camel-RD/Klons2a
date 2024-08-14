using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Equin.ApplicationFramework
{
    public class ObjectBackup
    {
        Hashtable propstable = new Hashtable();
        public ObjectBackup(object o) 
        {
            if (o == null) throw new ArgumentNullException("Object is null");
            //PropertyInfo[] properties = (o.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var properties = TypeDescriptor.GetProperties(o);
            for (int i = 0; i < properties.Count; i++)
            {
                var prop = properties[i];
                if (prop.IsReadOnly) continue;
                try
                {
                    object value = prop.GetValue(o);
                    propstable.Add(prop.Name, value);
                }
                catch (Exception) { }
            }
        }

        public void Restore(object o)
        {
            if (o == null) throw new ArgumentNullException("Object is null");
            //PropertyInfo[] properties = (o.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var properties = TypeDescriptor.GetProperties(o);
            for (int i = 0; i < properties.Count; i++)
            {
                var prop = properties[i];
                if (prop.IsReadOnly) continue;
                object value = propstable[prop.Name];
                if (value == null) continue;
                try
                {
                    prop.SetValue(o, value);
                }
                catch (Exception) { }
            }
        }

        public bool HasChanges(object o)
        {
            if (o == null) throw new ArgumentNullException("Object is null");
            //PropertyInfo[] properties = (o.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var properties = TypeDescriptor.GetProperties(o);
            for (int i = 0; i < properties.Count; i++)
            {
                var prop = properties[i];
                if (prop.IsReadOnly) continue;
                object old_value = propstable[prop.Name];
                try
                {
                    var current_value = prop.GetValue(o);
                    if(!object.Equals(old_value, current_value))
                        return true;
                }
                catch (Exception) { }
            }
            return false;
        }

        public void Clear() => propstable.Clear();
    }

    public class ObjectBackupTable
    {
        Dictionary<object, ObjectBackup> keyValuePairs = new Dictionary<object, ObjectBackup>();
        public ObjectBackupTable() { }
        public void Backup(object o)
        {
            if (keyValuePairs.ContainsKey(o)) return;
            keyValuePairs[o] = new ObjectBackup(o);
        }

        public void Restore(object o)
        {
            if (!keyValuePairs.TryGetValue(o, out var obackup)) return;
            obackup.Restore(o);
            keyValuePairs.Remove(o);
        }

        public void Remove(object o)
        {
            keyValuePairs.Remove(o);
        }


    }
}
