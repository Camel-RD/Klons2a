using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KlonsF.DataSets;
using KlonsLIB.Misc;
using KlonsP.Classes;

namespace KlonsP.Classes
{
    public class ItemRepInfo : ItemInfo
    {
        public string SCat1 { get; set; } = null;
        public string SCatD { get; set; } = null;
        public string SCatT { get; set; } = null;
        public string SDepartment { get; set; } = null;
        public string SPlace { get; set; } = null;

        public string SDateLiq
        {
            get
            {
                if (DateLiq == DateTime.MaxValue) return "";
                return Utils.DateToString(DateLiq);
            }
        }

        public void SetSFields()
        {
            var drcat1 = MyData.DataSetKlonsP.CAT1.FindByID(Cat1);
            SCat1 = drcat1.CODE + ": " + drcat1.DESCR.Nz();

            var drcatd = MyData.DataSetKlonsP.CATD.FindByID(CatD);
            SCatD = drcatd.CODE + ": " + drcatd.DESCR.Nz();

            var drcatt = MyData.DataSetKlonsP.CATT.FindByID(CatT);
            SCatT = drcatt.CODE + ": " + drcatt.DESCR.Nz();

            var drdep = MyData.DataSetKlonsP.DEPARTMENTS.FindByID(Department);
            SDepartment = drdep.CODE + ": " + drdep.DESCR.Nz();

            var drplace = MyData.DataSetKlonsP.PLACES.FindByID(Place);
            SPlace = drplace.CODE + ": " + drplace.DESCR.Nz();
        }

        public void FormatDescr()
        {
            foreach(var ev in Events2)
            {
                Descr = Descr.Nz();
            }
        }
    }
}
