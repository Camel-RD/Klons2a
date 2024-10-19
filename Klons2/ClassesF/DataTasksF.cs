using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsF.Classes
{
    public static class DataTasksF
    {
        public static KlonsData MyData => KlonsData.St;




        public static string GetAcName(string ac)
        {
            var dr = MyData.DataSetKlonsF.AcP21.FindByAC(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetAc3Name(string ac)
        {
            var dr = MyData.DataSetKlonsF.Acp23.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetAc4Name(string ac)
        {
            var dr = MyData.DataSetKlonsF.AcP24.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetAc5Name(string ac)
        {
            var dr = MyData.DataSetKlonsF.Acp25.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetClName(string cl)
        {
            var dr = MyData.DataSetKlonsF.Persons.FindByClId(cl);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetDocTypName(string dt)
        {
            var dr = MyData.DataSetKlonsF.DocTyp.FindByid(dt);
            if (dr == null) return null;
            return dr.Name;
        }
        public static string GetBankName(string bankid)
        {
            var dr = MyData.DataSetKlonsF.Banks.FindById(bankid);
            if (dr == null) return null;
            return dr.Name;
        }

        public static klonsDataSet.AcP24Row GetAcP24Row(string ac4)
        {
            if (string.IsNullOrEmpty(ac4)) return null;
            return MyData.DataSetKlonsF.AcP24.FindByidx(ac4);
        }

        public static string RemoveUnitFromDescr(string descr)
        {
            if (string.IsNullOrEmpty(descr))
                return descr;
            int k = descr.IndexOf('~');
            if (k == -1) return descr;
            if (k == descr.Length - 1) return null;
            return descr.Substring(k + 1);
        }
        public static string SetUnitInDescr(string descr, string unit)
        {
            descr = RemoveUnitFromDescr(descr);
            if (string.IsNullOrEmpty(unit)) return descr;
            if (string.IsNullOrEmpty(descr))
            {
                return unit + "~";
            }
            return unit + "~" + descr;
        }

        #region **************  PVN ****************

        public static klonsDataSet.AcPVNRow GetPVNrow(string ac5)
        {
            if (string.IsNullOrEmpty(ac5)) return null;
            return MyData.DataSetKlonsF.AcPVN.FindByid(ac5);
        }

        public static int AcPVNPz3(string id)
        {
            klonsDataSet.AcPVNRow dr = MyData.DataSetKlonsF.AcPVN.FindByid(id);
            if (dr == null) return -1;
            return dr.pz3;
        }

        public static int GetPVNTyp(string ac5)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return -1;
            if (dr.Ispz5Null()) return 0;
            return dr.pz5;
        }

        public static int GetPVNRate(string ac5)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return -1;
            if (dr.Ispz5Null()) return 0;
            return (int)dr.t;
        }

        public static bool IsPVN(string ac5)
        {
            int k = GetPVNTyp(ac5);
            return k > 0;
        }

        public static bool IsGoodPVN(string ac5)
        {
            int k = GetPVNTyp(ac5);
            return k == 1 || k == 3;
        }

        public static bool IsIenemumiA(int ac5paz3)
        {
            return ac5paz3 == 1 || ac5paz3 == 71 ||
                   ac5paz3 == 72 || ac5paz3 == 8;
        }

        public static bool IsIenemumi(string ac5)
        {
            int k = AcPVNPz3(ac5);
            return IsIenemumiA(k);
        }
        public static int GetPVNRateA(string ac5, DateTime date)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return 0;
            int k = dr.Ispz5Null() ? -1 : dr.pz5;
            if (k < 1) return 0;
            if (k > 3 || k == 1) return dr.IstNull() ? 0 : (int)dr.t;
            if (k == 2 || k == 3)
            {
                if (date < new DateTime(2011, 1, 1))
                {
                    return 21;
                }
                else if (date < new DateTime(2012, 8, 1))
                {
                    return 22;
                }
                else
                {
                    return 21;
                }
            }
            return 0;
        }
        #endregion

        public static bool AddDocsRowToTRepOPSd(int docid)
        {
            var row = MyData.DataSetKlonsF.OPSd.FindByid(docid);
            if (row == null) return false;
            var row2 = MyData.DataSetKlonsFRep.TRepOPSd.NewTRepOPSdRow();
            row2.id = row.id;
            row2.ZNR = row.ZNR;
            row2.NrX = row.NrX;
            row2.Dete = row.Dete;
            row2.DocTyp = row.DocTyp;
            row2.DocSt = row.DocSt;
            row2.DocNr = row.DocNr;
            row2.ClId = row.ClId;
            row2.ClId2 = row.ClId2;
            row2.Descr = row.Descr;
            row2.Summ = row.Summ;
            row2.PVN = row.PVN;
            row2["DT2"] = row["DT2"];
            MyData.DataSetKlonsFRep.TRepOPSd.Rows.Add(row2);
            return true;
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
