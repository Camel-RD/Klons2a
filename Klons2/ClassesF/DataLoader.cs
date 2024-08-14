using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KlonsF.DataSets;
using KlonsLIB.Misc;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsF.DataSets.KlonsADataSetTableAdapters;
using KlonsF.Classes;

namespace KlonsF.ClassesF
{
    public static class DataLoader
    {
        public static KlonsData MyData => KlonsData.St;

        public static void FillBaseTables()
        {
            var helper = MyData.GetDataSetHelper(MyData.DataSetKlonsF);
            helper.FillTables("AcP21", "Acp23", "AcP24",
                "Acp25", "AcPVN", "Banks", "Currency", "DocTyp", "DocTypA",
                "DocTypB", "Persons", "PersonTyp");
        }

        public static void ClearAll()
        {
            var ds = MyData.DataSetKlonsF;
            var dsr = MyData.DataSetKlonsFRep;
            ds.EnforceConstraints = false;
            dsr.EnforceConstraints = false;

            dsr.Clear();

            var tables = new DataTable[]
            {
                ds.AcP21,
                ds.Acp23,
                ds.AcP24,
                ds.Acp25,
                ds.AcP25a,
                ds.AcPVN,
                ds.Bal0,
                ds.BalA1,
                ds.BalA2,
                ds.BalA21,
                ds.BalA3,
                ds.Banks,
                ds.Currency,
                ds.DOCS0,
                ds.DocTyp,
                ds.DocTypA,
                ds.DocTypB,
                ds.LogX,
                ds.LOPS,
                ds.LOPSD,
                ds.LXOP,
                ds.OPS,
                ds.OPSd,
                ds.Persons,
                ds.PersonTyp
            };

            foreach (var t in tables)
                t.Clear();

            ds.EnforceConstraints = true;
            dsr.EnforceConstraints = true;
        }

        public static bool FillAll()
        {
            var ds = MyData.DataSetKlonsF;
            var dsr = MyData.DataSetKlonsFRep;
            ds.EnforceConstraints = false;
            dsr.EnforceConstraints = false;

            var tables = new DataTable[]
            {
                ds.AcP21,
                ds.Acp23,
                ds.AcP24,
                ds.Acp25,
                ds.AcP25a,
                ds.AcPVN,
                ds.Bal0,
                ds.BalA1,
                ds.BalA2,
                ds.BalA21,
                ds.BalA3,
                ds.Banks,
                ds.Currency,
                ds.DOCS0,
                ds.DocTyp,
                ds.DocTypA,
                ds.DocTypB,
                ds.Persons,
                ds.PersonTyp
            };
            foreach (var t in tables)
                MyData.FillTable(t);

            ds.EnforceConstraints = true;
            dsr.EnforceConstraints = true;

            return true;
        }

        public static bool LoadSomeData()
        {
            try
            {
                ClearAll();
                return FillAll();
            }
            catch (Exception e)
            {
                var de = new DetailedConstraintException2(e.Message, MyData.DataSetKlonsP);
                Form_Error.ShowException(de);
                return false;
            }
        }

        public static bool CheckData()
        {
            if (HasData()) return true;
            ClearAll();
            return FillAll();
        }

        public static bool HasData()
        {
            var ds = MyData.DataSetKlonsF;
            return ds.AcPVN.Count > 0;
        }
    }
}
