using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsP.Classes
{
    public enum EEvent
    {
        error = -1,
        nenoteikts = 0,
        pienuzsk = 1,
        iegeks = 2,
        ieg = 3,
        izv = 4,
        eks = 5,
        vieta = 10,
        parvert = 20,
        rekat = 21,
        kapit = 22,
        nelieto = 30,
        lieto = 31,
        likvid = 40,
        noliet = 50,
        apr = 100
    }

    public enum EState
    {
        OK = 0,
        Liquidated = 1,
        NotUsed = 2,
        OldDate = 3,
        Error = 4
    }

    public enum EChColInd
    {
        none = 0,
        cat1 = 1,
        catd = 2,
        catt = 1 << 2,
        place = 1 << 3,
        department = 1 << 4,
        value0 = 1 << 5,
        deprec0 = 1 << 6,
        valuec = 1 << 7,
        deprecc = 1 << 8,
        sellvalue = 1 << 9,
        taxvalue = 1 << 10,
        taxvaluec = 1 << 11,
        taxvalueleft = 1 << 12,
        mttotal = 1 << 13,
        mtused = 1 << 14
    }

}

