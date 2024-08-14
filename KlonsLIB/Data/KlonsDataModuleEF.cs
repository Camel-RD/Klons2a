using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;

namespace MyLib7.Data
{
    public class KlonsDataModuleEF
    {
        protected static KlonsDataModuleEF _KlonsDataModule = null;
        protected readonly Dictionary<string, MyDbContext> DbContexts = new Dictionary<string, MyDbContext>();
        protected readonly Dictionary<string, MyDbContext.DbSetList> FakeDbContexts = new Dictionary<string, MyDbContext.DbSetList>();

        private static bool _IsInDesignModeTested = false;
        private static bool _DesignModeTestResult = false;

        public static bool IsInDesignMode 
        { 
            get
            {
                if (!_IsInDesignModeTested)
                {
                    _DesignModeTestResult = Process.GetCurrentProcess().ProcessName == "DesignToolsServer";
                    _IsInDesignModeTested = true;
                }
                return _DesignModeTestResult;
            }
        }

        private string _CurrentConnectionString = null;
        public string CurrentConnectionString
        {
            get
            {
                return _CurrentConnectionString;
            }
            set
            {
                _CurrentConnectionString = value;
            }
        }

        public KlonsDataModuleEF()
        {
            if (_KlonsDataModule != null && _KlonsDataModule != this)
                throw new InvalidOperationException("KlonsDataModuleEF alreadt created");
            _KlonsDataModule = this;
        }
        public static KlonsDataModuleEF St
        {
            get
            {
                if (_KlonsDataModule == null)
                {
                    //_KlonsDataModule = new KlonsDataModule();
                    Debug.Print("KlonsDataModule not created");
                    throw new Exception("KlonsDataModule not created");
                }
                return _KlonsDataModule;
            }
        }


        public void DisposeDbContexts()
        {
            foreach (var ctx in DbContexts.Values)
            {
                ctx.Dispose();
            }
            DbContexts.Clear();
        }

        public virtual string[] GetDataSetNames()
        {
            if (IsInDesignMode)
                return FakeDbContexts.Keys.ToArray();
            return DbContexts.Keys.ToArray();
        }

        public virtual string[] GetTableNames(string datasetname)
        {
            if (IsInDesignMode)
            {
                var fds = GetFakeDataSet(datasetname);
                if (fds == null) return null;
                return fds.Keys.OrderBy(x => x).ToArray();
            }
            var ds = GetDataSet(datasetname);
            if (ds == null) return null;
            return ds.GetDbSetNames().OrderBy(t => t).ToArray();
        }

        public virtual MyDbContext.DbSetList GetFakeDataSet(string datasetname)
        {
            if (datasetname == null) return null;
            if (!FakeDbContexts.TryGetValue(datasetname, out var fds)) return null;
            return fds;
        }

        public virtual MyDbContext GetDataSet(string name)
        {
            if (name == null) return null;
            if (!DbContexts.TryGetValue(name, out var dbctx)) return null;
            return dbctx;
        }

        public virtual object GetDbSet(string datasetname, string tablename)
        {
            if (datasetname == null || tablename == null) return null;
            if (IsInDesignMode)
            {
                var fds = GetFakeDataSet(datasetname); 
                if (fds == null) return null;
                if(!fds.TryGetValue(tablename, out var table)) return null;
                return table;
            }
            var ctx = GetDataSet(datasetname);
            return ctx?.GetDbSetByName(tablename);
        }

        public virtual IBindingList GetDbSetBindingList(string datasetname, string tablename)
        {
            if (datasetname == null || tablename == null) return null;
            if (IsInDesignMode)
            {
                var fds = GetFakeDataSet(datasetname);
                if (fds == null) return null;
                if (!fds.TryGetValue(tablename, out var table)) return null;
                return table.BindingList;
            }
            var ctx = GetDataSet(datasetname);
            return ctx?.GetBindingListByName(tablename);
        }




    }

}
