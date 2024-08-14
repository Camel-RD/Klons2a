using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using KlonsLIB.Misc;
using KlonsLIB.Data;

namespace KlonsLIB
{
    public static class MyData
    {
        public static IKlonsSettings Settings { get; set; } = null;

        public static bool DesignMode
        {
            get
            {
                var dttags = new[] { "debug", "release" };
                var di = new DirectoryInfo(Utils.GetMyFolder());
                string dir1 = di.Name.ToLower();
                string dir2 = di.Parent?.Name.Nz().ToLower();
                return dttags.Contains(dir1) || dttags.Contains(dir2);
            }
        }

        public static bool InWine = false;

        public static string GetBasePath()
        {
            return Utils.GetMyFolderX();
        }
    }
}
