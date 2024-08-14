using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsP.Classes
{
    public static class DataTasks
    {
        public static KlonsData MyData => KlonsData.St;

        public static string GetCat1Name(int id)
        {
            var dr = MyData.DataSetKlonsP.CAT1.FindByID(id);
            if (dr == null) return null;
            return dr.DESCR;
        }

        public static string GetCatDName(int id)
        {
            var dr = MyData.DataSetKlonsP.CATD.FindByID(id);
            if (dr == null) return null;
            return dr.DESCR;
        }

        public static string GetCatTName(int id)
        {
            var dr = MyData.DataSetKlonsP.CATT.FindByID(id);
            if (dr == null) return null;
            return dr.DESCR;
        }

        public static string GetDepName(int id)
        {
            var dr = MyData.DataSetKlonsP.DEPARTMENTS.FindByID(id);
            if (dr == null) return null;
            return dr.DESCR;
        }

        public static string GetPlaceName(int id)
        {
            var dr = MyData.DataSetKlonsP.PLACES.FindByID(id);
            if (dr == null) return null;
            return dr.DESCR;
        }
        public static decimal Round(decimal d, int k)
        {
            return Math.Round(d, k, MidpointRounding.AwayFromZero);
        }

        public static int CountItemsWithErrors()
        {
            return MyData.DataSetKlonsP.ITEMS.WhereX(d => d.XState == EState.Error).Count();
        }

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
                Func<KlonsPDataSet, DataTable> func_gettable,
                Func<KlonsF.DataSets.KlonsPDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc,
                string idcolumnname = "ID")
            {
                var new_item = new SetNewIds_ListItemP()
                {
                    Name = name,
                    func_gettable = func_gettable,
                    func_getidfunc = func_getidfunc,
                    idcolumnname = idcolumnname
                };
                SetNewIds_List.Add(new_item);
            }

            Add_SetNewIDsItem("CAT1", x => x.CAT1, x => x.SP_P_GEN_CAT1_ID);
            Add_SetNewIDsItem("CATD", x => x.CATD, x => x.SP_P_GEN_CATD_ID);
            Add_SetNewIDsItem("CATT", x => x.CATT, x => x.SP_P_GEN_CATT_ID);
            Add_SetNewIDsItem("PLACES", x => x.PLACES, x => x.SP_P_GEN_PLACES_ID);
            Add_SetNewIDsItem("DEPARTMENTS", x => x.DEPARTMENTS, x => x.SP_P_GEN_DEPARTMENTS_ID);
            Add_SetNewIDsItem("ITEMS", x => x.ITEMS, x => x.SP_P_GEN_ITEMS_ID);
            Add_SetNewIDsItem("ITEMS_EVENTS", x => x.ITEMS_EVENTS, x => x.SP_P_GEN_ITEMS_EVENTS_ID);
            Add_SetNewIDsItem("TAXDEPRECYEAR", x => x.TAXDEPRECYEAR, x => x.SP_P_GEN_TAXDEPRECYEAR_ID);
        }

        class SetNewIds_ListItemP
        {
            public string Name;
            public Func<KlonsPDataSet, DataTable> func_gettable;
            public Func<KlonsF.DataSets.KlonsPDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc;
            public string idcolumnname = "ID";
        }

        static List<SetNewIds_ListItemP> SetNewIds_List = new List<SetNewIds_ListItemP>();


        private static void SetNewIDs(
            Func<KlonsPDataSet, DataTable> func_gettable,
            Func<KlonsF.DataSets.KlonsPDataSetTableAdapters.QueriesTableAdapter, Func<object>> func_getidfunc,
            string idcolumnname = "ID")
        {
            var table = func_gettable(MyData.DataSetKlonsP);
            var drs = DataSetHelper.GetNewRows(table);
            var adapter = func_getidfunc(MyData.KlonsPQueriesTableAdapter);
            foreach (var dr in drs)
            {
                if ((int)dr[idcolumnname] >= 0) continue;
                int new_id = (int)adapter();
                dr[idcolumnname] = new_id;
            }
        }
    }

    public class ErrorInfo
    {
        public string Source { get; set; } = null;
        public string Message { get; set; } = null;
    }

    public class ErrorList : List<ErrorInfo>
    {
        public bool HasErrors { get { return Count > 0; } }

        public ErrorList()
        {
        }

        public ErrorList(string source, string msg)
        {
            AddError(source, msg);
        }

        public void AddError(string source, string msg)
        {
            var ei = new ErrorInfo()
            {
                Source = source,
                Message = msg
            };
            Add(ei);
        }

        public void AddPersonError(int idp, string msg)
        {
            var ei = new ErrorInfo();
            /*
            var table_persons = KlonsData.St.DataSetKlonsP.PERSONS;
            if (table_persons != null)
            {
                var dr = table_persons.FindByID(idp);
                if (dr != null)
                    ei.Source = string.Format("{0}", dr.ZNAME);
            }
            */
            ei.Message = msg;
            Add(ei);
        }

        public void SetErrorList(ErrorList newlist)
        {
            Clear();
            AddRange(newlist);
        }

        public static ErrorList operator +(ErrorList e1, ErrorList e2)
        {
            if (e1 == null || e2 == null) return e1;
            e1.AddRange(e2);
            return e1;
        }

    }
}
