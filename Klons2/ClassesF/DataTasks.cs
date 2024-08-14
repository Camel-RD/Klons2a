using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsF.ClassesF
{
    public static class DataTasks
    {
        public static KlonsData MyData => KlonsData.St;


        public static void SetNewIDs(MyAdapterManager adaptermanager)
        {
            if (adaptermanager.TableNames == null) return;
            SetNewIDs(adaptermanager.TableNames);
        }

        public static void SetNewIDs(params string[] tablenames)
        {
            if (SetNewIds_List == null || SetNewIds_List.Count == 0) Make_SetNewIDs_List();
            foreach (var tablename in tablenames)
            {
                if (tablename == null) continue;
                var list_item = SetNewIds_List.Find(x => x.Name == tablename);
                if (list_item == null) continue;
                SetNewIDs(list_item.func_gettable, list_item.func_getidfunc, list_item.idcolumnname);
            }
        }

        public static void Make_SetNewIDs_List()
        {
            void Add_SetNewIDsItem(
                string name,
                Func<klonsDataSet, DataTable> func_gettable,
                Func<KlonsF.DataSets.klonsDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc,
                string idcolumnname = "ID")
            {
                var new_item = new SetNewIds_ListItemF()
                {
                    Name = name,
                    func_gettable = func_gettable,
                    func_getidfunc = func_getidfunc,
                    idcolumnname = idcolumnname
                };
                SetNewIds_List.Add(new_item);
            }

            Add_SetNewIDsItem("OPSd", x => x.OPSd, x => x.SP_OPSD_ID);
            Add_SetNewIDsItem("OPS", x => x.OPS, x => x.SP_OPS_ID);
            Add_SetNewIDsItem("Bal0", x => x.Bal0, x => x.SP_BAL0_ID);
            Add_SetNewIDsItem("BalA2", x => x.BalA2, x => x.SP_BALA2_ID);
            Add_SetNewIDsItem("BalA3", x => x.BalA3, x => x.SP_BALA3_ID);
            Add_SetNewIDsItem("DOCS0", x => x.DOCS0, x => x.SP_BALA3_ID);
            Add_SetNewIDsItem("DOCS0", x => x.DOCS0, x => x.SP_BALA3_ID);
        }

        class SetNewIds_ListItemF
        {
            public string Name;
            public Func<klonsDataSet, DataTable> func_gettable;
            public Func<KlonsF.DataSets.klonsDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc;
            public string idcolumnname = "ID";
        }

        static List<SetNewIds_ListItemF> SetNewIds_List = new List<SetNewIds_ListItemF>();


        private static void SetNewIDs(
            Func<klonsDataSet, DataTable> func_gettable,
            Func<KlonsF.DataSets.klonsDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc,
            string idcolumnname = "ID")
        {
            var table = func_gettable(MyData.DataSetKlonsF);
            var drs = DataSetHelper.GetNewRows(table);
            var adapter = func_getidfunc(MyData.KlonsFQueriesTableAdapter);
            foreach (var dr in drs)
            {
                if ((int)dr[idcolumnname] >= 0) continue;
                int new_id = (int)adapter();
                dr[idcolumnname] = new_id;
            }
        }
    }
}
