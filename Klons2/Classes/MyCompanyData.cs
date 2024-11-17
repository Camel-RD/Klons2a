using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsF.Classes
{
    public static class MyCompanyData
    {
        public static string CompName => KlonsData.St.Params.CompName;
        public static string CompRegNr => KlonsData.St.Params.CompRegNr;
        public static string CompRegNrPVN => KlonsData.St.Params.CompRegNrPVN;
        public static string CompVID => KlonsData.St.Params.CompVID;
        public static string CompAddr => KlonsData.St.Params.CompAddr;
        public static string CompAddrInd => KlonsData.St.Params.CompAddrInd;
        public static string CompAddrStreet => KlonsData.St.Params.CompAddr1;
        public static string CompAddrCity => KlonsData.St.Params.CompAddr2;
        public static string CompAddrState => KlonsData.St.Params.CompAddr3;
        public static string CompAddrParish => KlonsData.St.Params.CompAddr4;
        public static string CompAddrG => KlonsData.St.Params.CompAddrG;
        public static string CompEMail => KlonsData.St.Params.CompEMail;
        public static string CompMName => KlonsData.St.Params.CompMName;
        public static string CompMpk => KlonsData.St.Params.CompMpk;
        public static string CompPhone => KlonsData.St.Params.CompPhone;
        public static string CompAccName => KlonsData.St.Params.CompAccName;
        public static string CompAccPh => KlonsData.St.Params.CompAccPh;
        public static string BankId => KlonsData.St.Params.BankId;
        public static string BankName => KlonsData.St.Params.BankName;
        public static string BankAcc => KlonsData.St.Params.BankAcc;
    }
}
