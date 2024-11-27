using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsM.Classes
{
    public enum EStoreCalcMethod
    {
        FIFO, AveragePrice
    }

    public enum EAccountType
    {
        Nenoteikts = 1,
        Noliktava = 2,
        Izmaksas = 3,
        Ieņēmumi = 4,
        Debitori = 5,
        Kreditori = 6
    }

    public enum EAccountingType
    {
        MakeNone = 0,
        MakeAll = 1,
        MakeForWares = 2,
        MakeForSale = 3
    }

    public enum EStoreType
    {
        Nenoteikts = 1,
        Noliktava = 2,
        Darbinieks = 3,
        Partneris = 4,
        Partneris_turētājs = 5,
        Pakalpojumi = 6,
        Citi = 7,
        Noliktava_ārpus = 8,
        Ražošana = 9

    }

    public enum EPVNType
    {
        Nenoteikts = 1,
        Iekšzemē_apliekama_persona = 2,
        Iekšzemē_neapliekama_persona = 3,
        Eiropas_kopienā_apliekama_persona = 4,
        Eiropas_kopienā_neapliekama_persona = 5,
        Trešās_valstis = 6,
        Nav_PVN = 7
    }

    public enum EDocType
    {
        Nenoteikts = 1,
        Iepirkums = 2,
        Realizācija = 3,
        Atgriezts_piegādātājam = 4,
        Atgriezts_no_pircēja = 5,
        Kredītrēķins_no_piegādātāja = 6,
        Kredītrēķins_pircējam = 7,
        Pārvietots = 8,
        Sākuma_atlikums = 9,
        Norakstīts = 10,
        Pierakstīts = 11,
        Izlietots = 12,
        Saražots = 13,
        Saņemti_pakalpojumi = 14,
        Sniegti_pakalpojumi = 15,
        No_noliktavas = 16,
        Uz_noliktavu = 17,
        Iepirkuma_rēķins = 18,
        Pārdošanas_rēķins = 19
    }

    public enum EDocType2
    {
        Nenoteikts,
        Iekšējs,
        Saņemts_no_partnera,
        Izdots_partnerim
    }

    public enum EDocState
    {
        Melnraksts = 0,
        Apstiprināts = 1,
        Iegrāmatots = 2,
        Iekontēts = 3,
        Atvērts = 4
    }

    public enum EInventoryDocState
    {
        Melnraksts = 0,
        Salīdzināts = 1,
        Apstiprināts = 2,
        Iegrāmatots = 3
    }


    public enum EAccountsForTemplates
    {
        Nav = 0,
        PVN = 1,
        Krājumi = 2,
        Debitori = 3,
        Kreditori = 4,
        Ieņēmumi = 5,
        Izmaksas = 6
    }

}
