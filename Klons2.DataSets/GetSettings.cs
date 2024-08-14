using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace Klons2
{
    public static class GetSettings
    {
        public static PropertyInfo GetProp(this Type type, string propName)
        {
            PropertyInfo prop = null;
            while (type != null)
            {
                prop = type.GetProperty(propName, BindingFlags.Public |
                    BindingFlags.Instance | BindingFlags.Static |
                    BindingFlags.NonPublic);
                if (prop != null) break;

                type = type.BaseType;
            }
            return prop;
        }

        public static ApplicationSettingsBase Settings => KlonsF.Properties.Settings.Default;

    }
}
