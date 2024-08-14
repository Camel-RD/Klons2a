using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Equin.ApplicationFramework;
using KGySoft.ComponentModel;
using KlonsLIB.Misc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyLib7.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():this(new DbContextOptions<DbContext>()) 
        {
        }
        public MyDbContext(DbContextOptions options) : base(options) 
        {
            InitDbSetList();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr = KlonsDataModuleEF.St.CurrentConnectionString;
            optionsBuilder.UseFirebird(constr);
        }

        public Dictionary<string, IBindingList> DbSetLists { get; private set; } = new Dictionary<string, IBindingList>();

        public List<string> GetDbSetNames()
        {
            return GetDbSetProperties().Select(x => x.Name).ToList();
        }

        public object GetDbSetByName(string name)
        {
            if (name == null) return null;
            var prop = GetDbSetProperties().FirstOrDefault(x => x.Name == name);
            return prop?.GetValue(this);
        }

        public static bool IsDbSet(object o)
        {
            return o != null && o.GetType().Name == "InternalDbSet`1";
        }

        public static IBindingList GetBindingListFromDbSet(object dbset)
        {
            if (!IsDbSet(dbset)) return null;
            var prop_local = dbset.GetType().GetProperty("Local");
            var obj_local = prop_local.GetValue(dbset);
            var meth_tobl = obj_local.GetType().GetMethod("ToBindingList");
            var obj_bl = meth_tobl.Invoke(obj_local, null);
            return obj_bl as IBindingList;
        }


        public void InitDbSetList()
        {
            DbSetLists = GetDbSetProperties()
                .ToDictionary(x => x.Name, x => GetBindingListFromDbSet(x.GetValue(this)));
        }

        public IBindingList GetBindingListByName(string tablename)
        {
            if(tablename == null) return null;
            if (!DbSetLists.TryGetValue(tablename, out var ret)) return null;
            return ret;
        }

        public List<object> GetDbSets()
        {
            var ret = GetDbSetProperties()
                .Select(x => x.GetValue(this))
                .ToList();
            return ret;
        }

        public List<PropertyInfo> GetDbSetProperties()
        {
            return GetDbSetProperties(GetType());
        }
        public static DbSetList GetFakeList(Type ctx_type)
        {
            if (ctx_type == null) return null;
            var ret = new DbSetList();
            var props = GetDbSetProperties(ctx_type);
            var tp_blv = typeof(BindingList<>);
            foreach (var prop in props)
            {
                var item = new DbSetListItem();
                item.Name = prop.Name;
                item.ItemType = prop.PropertyType.GenericTypeArguments[0];
                object new_bl = null;
                bool rt = Reflector.TryCreateInstanceByType(
                    tp_blv,
                    prop.PropertyType.GenericTypeArguments,
                    ReflectionWays.Auto,
                    false,
                    out new_bl);
                if (!rt) return null;
                item.BindingList = new_bl as IBindingList;
                ret.Add(prop.Name, item);
            }
            return ret;
        }

        public static List<PropertyInfo> GetDbSetProperties(Type ctx_type)
        {
            return ctx_type.GetProperties()
                .Where(x => x.PropertyType.IsGenericType &&
                    typeof(DbSet<>).IsAssignableFrom(x.PropertyType.GetGenericTypeDefinition()))
                .ToList();
        }

        public class DbSetList : Dictionary<string, DbSetListItem> { }

        public class DbSetListItem
        {
            public string Name;
            public Type ItemType;
            public IBindingList BindingList;
        }

    }
}
