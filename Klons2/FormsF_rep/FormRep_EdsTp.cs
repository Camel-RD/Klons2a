using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using KlonsF.Classes;
using KlonsF.ClassesF;
using KlonsLIB.Misc;

namespace KlonsF.FormsReportParams
{
    public partial class FormRep_EdsTp : MyFormBaseF
    {
        public FormRep_EdsTp()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            dgcTitleShort.MaxInputLength = (int)(300 * ScaleFactor.Width);
            int yr = DateTime.Today.Year;
            cbYear.Items.Add($"{yr - 2}");
            cbYear.Items.Add($"{yr - 1}");
            cbYear.Items.Add($"{yr}");
            cbYear.SelectedIndex = 2;
            cbReport.SelectedIndex = 0;
        }

        private void FormRep_EdsTp_Load(object sender, EventArgs e)
        {
        }

        public EdsTp EdsTp = null;
        public int Year;
        public DateTime StartDate;
        public DateTime EndDate;

        List<RepRowEdsTp> RepRowsDeklarēts = null;
        List<RepRowEdsTp> RepRowsNokavējumaNauda = null;
        List<RepRowEdsTp> RepRowsIemaksa = null;
        List<RepRowEdsTp> RepRowsAtmaksa = null;
        List<RepRowEdsTp> RepRowsIeskaits = null;
        List<RepRowEdsTp> RepRowsCits = null;

        private static T DeserializeA<T>(string serializedResults)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stringReader = new StringReader(serializedResults))
                return (T)serializer.Deserialize(stringReader);
        }

        public static EdsTp Deserialize(string xmltext)
        {
            try
            {
                return DeserializeA<EdsTp>(xmltext);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool GetYear()
        {
            if (string.IsNullOrEmpty(cbYear.Text)) return false;
            if (!int.TryParse(cbYear.Text, out int yr)) return false;
            if (yr < 2000 || yr > 2200) return false;
            Year = yr;
            StartDate = new DateTime(yr, 1, 1);
            EndDate = new DateTime(yr, 12, 31);
            return true;
        }

        public void DoRead()
        {
            if (!GetYear())
            {
                MyMainForm.ShowWarning("Norādīts nekorekts gads.");
                return;
            }
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML faili (*.xml)|*.xml";
            //ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Title = "Norādi EDS pārskata xml failu";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog(MyMainForm) != DialogResult.OK) return;
            var fnm = ofd.FileName;

            string xml = File.ReadAllText(fnm);
            EdsTp = Deserialize(xml);
            if (EdsTp == null)
            {
                MyMainForm.ShowWarning("Datu imports neizdevās.");
                return;
            }
            if (EdsTp.Transakcijas == null || EdsTp.Transakcijas.Length == 0)
            {
                MyMainForm.ShowWarning("Transakciju pārskats ir tukšs.");
                return;
            }
            foreach (var tr in EdsTp.Transakcijas)
            {
                tr.Datums = tr.Datums.Date;
            }
            var trs = EdsTp.Transakcijas
                .Where(x => x.Datums >= StartDate && x.Datums <= EndDate ||
                    x.PeriodsLidz >= StartDate && x.PeriodsLidz <= EndDate);
            if (!trs.Any())
            {
                MyMainForm.ShowWarning("Transakciju pārskats nav datu par norādīto gadu.");
                return;
            }

            RepRowsDeklarēts = GetDeklarēts();
            RepRowsNokavējumaNauda = GetNokavējumaNauda();
            RepRowsIemaksa = GetIemaksa();
            RepRowsAtmaksa = GetAtmaksa();
            RepRowsIeskaits = GetIeskaits();
            RepRowsCits = GetCits();
        }

        string[] titlemap1 = new[] {
                "Iedzīvotāju ienākuma nodoklis", "IIN",
                "Iekšzemē iekasētais pievienotās vērtības nodoklis", "PVN",
                "Uzņēmējdarbības riska valsts nodeva", "URVN",
                "Uzņēmumu ienākuma nodoklis", "UIN",
                "Valsts sociālās apdrošināšanas obligātās iemaksas", "VSAOI"
            };
        string[] titlemap2 = new[] {
                "Iedzīvotāju ienākuma nodoklis - Darba devēja ziņojums", "IIN - DDZ",
                "Iedzīvotāju ienākuma nodoklis - Paziņojums par fiziskajai personai izmaksātajām summām", "IIN - FP",
                "Iekšzemē iekasētais pievienotās vērtības nodoklis - PVN mēneša deklarācija", "PVN",
                "Iekšzemē iekasētais pievienotās vērtības nodoklis - PVN taksācijas perioda deklarācija", "PVN",
                "Uzņēmējdarbības riska valsts nodeva - Darba devēja ziņojums", "URVN",
                "Uzņēmumu ienākuma nodoklis - Uzņēmuma ienākuma nodokļa deklarācija", "UIN",
                "Valsts sociālās apdrošināšanas obligātās iemaksas - Darba devēja ziņojums", "VSAOI - DDZ",
                "Valsts sociālās apdrošināšanas obligātās iemaksas - Minimālās VSAOI - Aprēķins", "VSAOI - Min",
                "Valsts sociālās apdrošināšanas obligātās iemaksas - Minimālās VSAOI - Pārrēķins", "VSAOI - Min - pārrēķins"
            };
        
        public string GetTitleShort1(string titlefull)
        {
            for (int i = 0; i < titlemap1.Length; i += 2)
            {
                if (titlemap1[i] == titlefull) return titlemap1[i + 1];
            }
            return titlefull;
        }

        public string GetTitleShort2(string titlefull)
        {
            for(int i = 0; i < titlemap2.Length; i += 2)
            {
                if (titlemap2[i] == titlefull) return titlemap2[i + 1];
            }
            return titlefull;
        }

        public List<RepRowEdsTp> GetDeklarēts()
        {
            var trs = EdsTp.Transakcijas
                .Where(x => x.PeriodsLidz >= StartDate && x.PeriodsLidz <= EndDate ||
                        x.Datums >= StartDate && x.Datums <= EndDate)
                .Where(x => x.Aprekins == "Aprēķins" && x.Info == "Deklarēts")
                .ToList();
            var grs_tr = trs.GroupBy(x => (x.IenemumuVeids, x.SaistibasVeids));
            var ret = new List<RepRowEdsTp>();
            foreach (var gr_tr in grs_tr)
            {
                var reprow = new RepRowEdsTp();
                reprow.Title1 = gr_tr.Key.IenemumuVeids;
                reprow.Title2 = gr_tr.Key.SaistibasVeids;
                reprow.TitleFull = gr_tr.Key.IenemumuVeids + " - " + gr_tr.Key.SaistibasVeids;
                reprow.TitleShort = GetTitleShort2(reprow.TitleFull);
                ret.Add(reprow);
                gr_tr.ForEach(x => reprow.AddVal(x.PeriodsLidz, Year, -x.Summa));
            }
            ret = ret
                .OrderBy(x => x.TitleShort)
                .ToList();
            return ret;
        }

        public List<RepRowEdsTp> GetNokavējumaNauda()
        {
            var trs = EdsTp.Transakcijas
                .Where(x => x.Datums >= StartDate && x.Datums <= EndDate)
                .Where(x => x.Aprekins == "Aprēķins" && x.Info == "Nokavējuma naudas aprēķins")
                .ToList();
            var grs_tr = trs.GroupBy(x => x.IenemumuVeids);
            var ret = new List<RepRowEdsTp>();
            foreach (var gr_tr in grs_tr)
            {
                var reprow = new RepRowEdsTp();
                reprow.Title1 = gr_tr.Key;
                reprow.TitleFull = gr_tr.Key;
                reprow.TitleShort = GetTitleShort1(reprow.TitleFull);
                ret.Add(reprow);
                gr_tr.ForEach(x => reprow.AddVal(x.Datums, Year, -x.Summa));
            }
            ret = ret
                .OrderBy(x => x.TitleShort)
                .ToList();
            return ret;
        }

        public List<RepRowEdsTp> GetCits()
        {
            var trs = EdsTp.Transakcijas
                .Where(x => x.Datums >= StartDate && x.Datums <= EndDate)
                .Where(x => x.Aprekins == "Aprēķins" && 
                    x.Info != "Nokavējuma naudas aprēķins" &&
                    x.Info != "Deklarēts" &&
                    x.Info != "FIFO savstarpējā segšana" &&
                    x.Info != "PVN apstiprināts samazinājums")
                .ToList();
            var grs_tr = trs.GroupBy(x => (x.IenemumuVeids, x.Info));
            var ret = new List<RepRowEdsTp>();
            foreach (var gr_tr in grs_tr)
            {
                var reprow = new RepRowEdsTp();
                reprow.Title1 = gr_tr.Key.IenemumuVeids;
                reprow.TitleFull = gr_tr.Key.IenemumuVeids;
                reprow.TitleShort = GetTitleShort1(reprow.TitleFull) + " - " + gr_tr.Key.Info;
                ret.Add(reprow);
                gr_tr.ForEach(x => reprow.AddVal(x.Datums, Year, -x.Summa));
            }
            ret = ret
                .OrderBy(x => x.TitleShort)
                .ToList();
            return ret;
        }

        public List<RepRowEdsTp> GetIemaksa()
        {
            return GetIemaksaAtmaksaIeskaits((x) => x.Aprekins == "Iemaksa");
        }

        public List<RepRowEdsTp> GetAtmaksa()
        {
            return GetIemaksaAtmaksaIeskaits((x) => x.Aprekins == "Atmaksa");
        }

        public List<RepRowEdsTp> GetIeskaits()
        {
            return GetIemaksaAtmaksaIeskaits((x) => x.Aprekins == "Aprēķins" && x.Info == "FIFO savstarpējā segšana");
        }

        public List<RepRowEdsTp> GetIemaksaAtmaksaIeskaits(Func<TPTransakcija, bool> func_filter)
        {
            var trs = EdsTp.Transakcijas
                .Where(x => x.Datums >= StartDate && x.Datums <= EndDate)
                .Where(x => func_filter(x))
                .ToList();
            var grs_tr = trs.GroupBy(x => (x.IenemumuVeids, x.SummasVeids));
            var grs_tr2 = trs.GroupBy(x => (x.IenemumuVeids));
            var ret_ps = new List<RepRowEdsTp>();
            var ret_kn = new List<RepRowEdsTp>();
            var ret_t = new List<RepRowEdsTp>();
            var ret = new List<RepRowEdsTp>();
            foreach (var gr_tr in grs_tr)
            {
                var reprow = new RepRowEdsTp();
                reprow.Title1 = gr_tr.Key.IenemumuVeids;
                reprow.TitleFull = gr_tr.Key.IenemumuVeids;
                reprow.TitleShort = GetTitleShort1(reprow.TitleFull);
                gr_tr.ForEach(x => reprow.AddVal(x.Datums, Year, -x.Summa));
                if (gr_tr.Key.SummasVeids == "Pamatsumma")
                    ret_ps.Add(reprow);
                else
                    ret_kn.Add(reprow);
            }
            foreach (var gr_tr in grs_tr2)
            {
                var reprow = new RepRowEdsTp();
                reprow.Title1 = gr_tr.Key;
                reprow.TitleFull = gr_tr.Key;
                reprow.TitleShort = GetTitleShort1(reprow.TitleFull);
                gr_tr.ForEach(x => reprow.AddVal(x.Datums, Year, -x.Summa));
                ret_t.Add(reprow);
            }
            ret_ps = ret_ps.OrderBy(x => x.TitleShort).ToList();
            ret_kn = ret_kn.OrderBy(x => x.TitleShort).ToList();
            ret_t = ret_t.OrderBy(x => x.TitleShort).ToList();
            if(ret_ps.Count > 0)
            {
                var reprow = new RepRowEdsTp();
                reprow.TitleShort = "--PAMATSUMMA--";
                ret.Add(reprow);
                ret.AddRange(ret_ps);
            }
            if (ret_kn.Count > 0)
            {
                var reprow = new RepRowEdsTp();
                reprow.TitleShort = "--KAVĒJUMA NAUDA--";
                ret.Add(reprow);
                ret.AddRange(ret_kn);
            }
            if (ret_t.Count > 0)
            {
                var reprow = new RepRowEdsTp();
                reprow.TitleShort = "--KOPĀ--";
                ret.Add(reprow);
                ret.AddRange(ret_t);
            }
            return ret;
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            DoRead();
            ShowReport(0);
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRowEdsTp;
            if (e.ColumnIndex >= dgcMp.Index)
            {
                decimal val = (decimal)e.Value;
                if (val == 0)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        public void ShowReport(int repid)
        {
            if(cbReport.SelectedIndex != repid)
            {
                cbReport.SelectedIndex = repid;
                return;
            }
            if (repid == 0) dgvRows.DataSource = RepRowsDeklarēts;
            else if (repid == 1) dgvRows.DataSource = RepRowsNokavējumaNauda;
            else if (repid == 2) dgvRows.DataSource = RepRowsIemaksa;
            else if (repid == 3) dgvRows.DataSource = RepRowsAtmaksa;
            else if (repid == 4) dgvRows.DataSource = RepRowsIeskaits;
            else if (repid == 5) dgvRows.DataSource = RepRowsCits;
            dgcMp.Visible = repid == 0;
            dgvRows.AutoResizeColumn(dgcTitleShort.Index);

        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading || cbReport.SelectedIndex == -1) return;
            ShowReport(cbReport.SelectedIndex);
        }
    }

    public class RepRowEdsTp
    {
        public string TitleFull { get; set; } = "";
        public string TitleShort { get; set; } = "";
        public string Title1 { get; set; } = "";
        public string Title2 { get; set; } = "";

        public void AddVal(DateTime dt, int yr, decimal val)
        {
            if (dt.Year > yr) return;
            if (dt.Year < yr) Mp += val;
            else MX[dt.Month - 1] += val;
        }

        public decimal[] MX = new decimal[12];
        public decimal Mp { get; set; } = 0.0M;
        public decimal M1 { get => MX[0]; set => MX[0] = value; }
        public decimal M2 { get => MX[1]; set => MX[1] = value; }
        public decimal M3 { get => MX[2]; set => MX[2] = value; }
        public decimal M4 { get => MX[3]; set => MX[3] = value; }
        public decimal M5 { get => MX[4]; set => MX[4] = value; }
        public decimal M6 { get => MX[5]; set => MX[5] = value; }
        public decimal M7 { get => MX[6]; set => MX[6] = value; }
        public decimal M8 { get => MX[7]; set => MX[7] = value; }
        public decimal M9 { get => MX[8]; set => MX[8] = value; }
        public decimal M10 { get => MX[9]; set => MX[9] = value; }
        public decimal M11 { get => MX[10]; set => MX[10] = value; }
        public decimal M12 { get => MX[11]; set => MX[11] = value; }
    }
}
