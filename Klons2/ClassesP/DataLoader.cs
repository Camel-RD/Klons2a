using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KlonsF.DataSets;
using KlonsLIB.Misc;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsF.DataSets.KlonsPDataSetTableAdapters;
using KlonsF.Classes;

namespace KlonsP.Classes
{
    public static class DataLoader
    {
        public static KlonsData MyData => KlonsData.St;

        public static void ClearAll()
        {
            var ds = MyData.DataSetKlonsP;
            var dsr = MyData.DataSetKlonsPRep;
            ds.EnforceConstraints = false;
            dsr.EnforceConstraints = false;

            var tables = new DataTable[] 
            {
                ds.CAT1,
                ds.CATD,
                ds.CATT,
                ds.DEPARTMENTS,
                ds.PLACES,
                ds.EVENTS,
                ds.ITEMS,
                ds.ITEMS_EVENTS,
                ds.TAXDEPRECYEAR
            };

            foreach (var t in tables)
                t.Clear();

            ds.EnforceConstraints = true;
            dsr.EnforceConstraints = true;
        }

        public static bool FillAll()
        {
            var ds = MyData.DataSetKlonsP;
            var dsr = MyData.DataSetKlonsPRep;
            ds.EnforceConstraints = false;
            dsr.EnforceConstraints = false;

            var tables = new DataTable[]
            {
                ds.CAT1,
                ds.CATD,
                ds.CATT,
                ds.DEPARTMENTS,
                ds.PLACES,
                ds.EVENTS,
                ds.ITEMS,
                ds.ITEMS_EVENTS,
                ds.TAXDEPRECYEAR
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
            var ds = MyData.DataSetKlonsP;
            return ds.CAT1.Count > 0;
        }

    }
}