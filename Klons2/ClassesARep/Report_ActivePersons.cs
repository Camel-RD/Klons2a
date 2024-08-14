using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KlonsF.DataSets;
using KlonsA.Forms;
using KlonsLIB.Misc;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsF.Classes;

namespace KlonsA.Classes
{
    public class Report_ActivePersons
    {
        private KlonsData MyData => KlonsData.St;

        public List<RepRowActivePerons> RepRows = new List<RepRowActivePerons>();

        public ErrorList MakeReport(DateTime dt1, DateTime dt2)
        {
            var er = new ErrorList();
            var table_persons = MyData.DataSetKlonsA.PERSONS;
            var drs_persons = table_persons.WhereNotDeleted();
            foreach (var dr in drs_persons)
            {
                var rrow = new RepRowActivePerons();
                var er1 = GetPersonsData(dr, dt1, dt2, rrow);
                if (er1 == "Out") continue;
                if (er1 == "OK")
                {
                    RepRows.Add(rrow);
                }
                else
                {
                    er.AddPersonError(dr.ID, er1);
                }
            }
            return er;
        }

        public string GetPersonsData(KlonsADataSet.PERSONSRow dr_person, 
            DateTime dt1, DateTime dt2, RepRowActivePerons rrow)
        {
            if (dr_person == null) throw new ArgumentException();
            int idp = dr_person.ID;

            rrow.IDP = idp;
            rrow.Name = dr_person.ZNAME;

            var drs_events = dr_person.GetEVENTSRows();


            var drsn_hirefire = drs_events
                .Where(d =>
                    (d.IDN == (int)EEventId.Pieņemts ||
                    d.IDN == (int)EEventId.Atlaists) &&
                    d.DATE1 <= dt2)
                .OrderBy(d => d.DATE1).ToArray();

            if (drsn_hirefire.Length == 0)
            {
                rrow.IsActive = false;
                return "Out";
            }

            var pi_hirefire = new PeriodInfo();

            var rt1 = pi_hirefire.ReadStartEndList(drsn_hirefire,
                isStartItem: it => it.IDN == (int)EEventId.Pieņemts,
                getItemDate: it => it.DATE1);

            switch (rt1)
            {
                case PeriodInfo.ERetReadStartEndList.BadDates:
                    return "Pieņemts/atlaists notikumiem ir nekorekti datumi.";
                case PeriodInfo.ERetReadStartEndList.BadStart:
                case PeriodInfo.ERetReadStartEndList.BadEnd:
                    return "Pieņemts/atlaists notikumiem ir nekorekta secība.";
            }

            var pi_last = pi_hirefire.LinkedPeriods[pi_hirefire.LinkedPeriods.Count - 1];

            if (pi_last.DateLast < dt1)
            {
                rrow.IsActive = false;
                rrow.Fired = pi_last.DateLast;
                return "Out";
            }

            rrow.IsActive = true;
            rrow.Hired = pi_last.DateFirst;

            if (pi_last.DateLast <= dt2)
                rrow.Fired = pi_last.DateLast;

            var pi_hirefire_for_date = pi_hirefire.FilterListWithDates(dt1, dt2);
            if (pi_hirefire_for_date.LinkedPeriods.Count > 0)
                rrow.HiredDays = pi_hirefire_for_date.LinkedPeriods
                    .Select(x => (x.DateLast - x.DateFirst).Days + 1)
                    .Sum();


            var drsn_fordates = drs_events
                .Where(x => !x.IsDATE2Null() && x.DATE1 <= dt2 && x.DATE2 >= dt1)
                .OrderBy(x => x.DATE1).ToArray();

            if (drsn_fordates.Length == 0)
                return "OK";

            var pi_fordates = new PeriodInfo();
            pi_fordates.LinkedPeriods = drsn_fordates
                .Select(x => new PeriodInfo()
                {
                    DateFirst = x.DATE1,
                    DateLast = x.DATE2,
                    EEventId = x.EventCode,
                    Item1 = x
                }).ToList();

            pi_fordates = pi_fordates.FilterListWithDates(dt1, dt2);
            pi_fordates.FilterWithList(pi_hirefire);
            if (pi_fordates.LinkedPeriods.Count == 0)
                return "OK";

            foreach(var pi in pi_fordates.LinkedPeriods)
            {
                var dr_event = pi.Item1 as KlonsADataSet.EVENTSRow;
                pi.EEventId = dr_event.EventCode;
            }

            var pi_sickab = pi_fordates.Filter(
                x =>
                x.EEventId == EEventId.Slimības_lapa_A ||
                x.EEventId == EEventId.Slimības_lapa_B);
            
            var pi_vacall = pi_fordates.Filter(
                x => SomeDataDefs.EventIsVacation(x.EEventId));
            
            var pi_vacall_while_sick = pi_vacall.FilterWithList(pi_sickab);

            foreach (var pi in pi_sickab.LinkedPeriods)
            {
                int ct = (pi.DateLast - pi.DateFirst).Days + 1;
                switch (pi.EEventId)
                {
                    case EEventId.Slimības_lapa_A:
                        rrow.SickDaysA += ct;
                        break;
                    case EEventId.Slimības_lapa_B:
                        rrow.SickDaysB += ct;
                        break;
                }
            }

            foreach (var pi in pi_vacall.LinkedPeriods)
            {
                int ct = (pi.DateLast - pi.DateFirst).Days + 1;
                if (pi.EEventId == EEventId.Atvaļinājums)
                    rrow.VacDays += ct;
                else 
                    rrow.OtherVacDays += ct;
            }

            foreach (var pi in pi_vacall_while_sick.LinkedPeriods)
            {
                int ct = (pi.DateLast - pi.DateFirst).Days + 1;
                rrow.SickDaysInVac += ct;
                if (pi.EEventId == EEventId.Atvaļinājums)
                {
                    rrow.VacDays -= ct;
                }
                else
                    rrow.OtherVacDays -= ct;
            }

            return "OK";
        }

    }

    public class RepRowActivePerons
    {
        public int IDP { get; set; } = 0;
        public string Name { get; set; } = null;
        public DateTime? Hired { get; set; }
        public DateTime? Fired { get; set; }
        public bool IsActive { get; set; } = false;
        public int HiredDays { get; set; } = 0;
        public int VacDays { get; set; } = 0;
        public int SickDaysA { get; set; } = 0;
        public int SickDaysB { get; set; } = 0;
        public int OtherVacDays { get; set; } = 0;
        public int SickDaysInVac { get; set; } = 0;

    }
}
