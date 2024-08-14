using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsA.Classes
{

    public enum ESalaryType
    {
        Month,
        Day,
        Hour,
        Aggregated,
        Piece
    }

    public enum EBonusRateType
    {
        Money = 0,
        Percent = 1
    }

    public enum EBonusFrom
    {
        None = 0,
        FromMonthSalary = 1,
        FromPay = 2,
        FromPayAndVacSick = 3,
        FromPayBeforeSAI = 4,
        FromPayAfterSAI = 5,
        FromPayBeforeIIN = 6,
        FromPayAfterIIN = 7
    }

    public enum EBonusType
    {
        None = 0,
        Taxed = 1,
        NoSAI = 2,
        AuthorsFees = 3,
        NotTaxed = 4,
        MinusBeforeIIN = 5,
        MinusAfterIIN = 6,
        ReverseCalc = 51,
        PfNotTaxed = 101,
        PfTaxed = 102,
        LiNotTaxed = 201,
        LiTaxed = 202,
        HiNotTaxed = 203,
        HiTaxed = 204
    }

    public enum EPlanType : short
    {
        Fixed = 0,
        Individual = 1
    }
    public enum ESalarySheetRowType : short
    {
        OnlyOne = 0,
        OneOfMany = 1,
        Total = 2
    }
    public enum ESalarySheetKind : short
    {
        Normal = 0,
        Total = 1
    }

    public enum EIINExempt2Kind : short
    {
        None = 0,
        Invalid = 1,
        RetaliatedPensioner = 2,
        Retaliated = 3,
        NationalMovementPensioner = 4,
        NationalMovement = 5
    }

    public enum EKind1 : short
    {
        PlanGroupDay = 0,
        PlanGroupaNight = 1,
        PlanIndividualDay = 2,
        PlanIndividualNight = 3,
        Fact = 4,
        FactOvertime = 5,
        FactNight = 6
    }

    public enum EEventId : int
    {
        None = 0,
        Pieņemts = 1,
        Atlaists = 2,
        Piešķirts_amats = 3,
        Atbrīvots_no_amata = 4,
        Noslēgts_uzņēmuma_līgums = 5,
        Izbeigts_uzņēmuma_līgums = 6,
        Atvaļinājums = 101,
        Bezalgas_atvaļinājums = 102,
        Apmaksāts_mācību_atvaļinājums = 103,
        Bezalgas_mācību_atvaļinājums = 104,
        Grūtniecības_un_dzemdību_atvaļinājums = 105,
        Bērna_kopšanas_atvaļinājums = 106,
        Paternitātes_atvaļinājums = 107,
        Slimības_lapa_A = 201,
        Slimības_lapa_B = 202,
        Negadījums_darba_vietā = 203,
        Neattaisnots_kavējums = 301,
        Komandējums = 302,
        Vidējās_izpeļņas_dienas = 303,
        Profesijas_maiņa = 304,
        Cits = 305
    }

    public enum EPeriodId : int
    {
        None = 100,
        Nav_pieņets = 101,
        Ir_pieņemts = 102,
        Atvaļinājums = 200,
        Slimo = 300,
        Vidējās_izpeļņas_dienas = 400,
        Komandējums = 401
    }

    public enum EDayPlanId : short
    {
        None = -1,
        DD = 0,
        BD = 1,
        SD = 2,
        DDSD = 3,
        SDDD = 4,
        Error = 99
    }

    public enum EDayFactId : short
    {
        None = -1,
        X = 0,  //nav darba attiecībās / amatā
        D = 1,  //darba diena
        B = 2,  //brīvdiena
        K = 3,  //komandējums
        S = 4,  //svētku diena ar vid.izp.
        V = 5,  //vid.izp. diena - nestrādā ar attaisnojošo iemeslu
        N = 6,  //kavējums
        DP = 7, //saīsināta pirmssvētku diena
        DS = 8, //darba diena svētku dienā ar piemaksu
        KS = 9,  //komandējums svētku dienā ar piemaksu

        SA = 20,  //slimības lapa A
        SB = 21,  //slimības lapa B
        SN = 22,  //negadijums darba vietā
        A = 23,   //atvaļinājums
        AM = 24, //apmaksāts mācību atvaļinājums
        AC = 25, //neapmaksāts mācību atvaļinājums
        AN = 26, //neapmaksāts atvaļinājums
        AD = 27, //dzemdību atvaļinājums
        AP = 28, //paternitātes atvaļinājums
        AB = 29, //bērnu kopšanas atvaļinājums

        Error = 99
    }

}
