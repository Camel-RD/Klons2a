using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsF.DataSets.klonsDataSetTableAdapters;
using KlonsF.DataSets.klonsRepDataSetTableAdapters;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;

namespace KlonsF.Forms
{
    public partial class FormRep_Bilance : MyFormBaseF
    {
        public FormRep_Bilance()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }
        
        private DateTime startDate = DateTime.MinValue;
        private DateTime endDate = DateTime.MinValue;
        private string balid = "";
        private string rtitle = "";
        private string raktivs = "";
        private string rpasivs = "";


        private void Form_Bilance_Load(object sender, EventArgs e)
        {
            bsBalA1.Fill();
            lbCM.SelectedIndex = 0;
            LoadParams();
            SetControlsUpDownOrder(new Control[][]
            {
                new Control[] {tbSD, tbED},
                new Control[] {cmReport, cmReport}
            });
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            dgvBalA1.DefaultCellStyle.Font = Font;
        }
        private void LoadParams()
        {
            tbSD.Text = MyData.Params.RSD;
            tbED.Text = MyData.Params.RED;
        }

        public override void SaveParams()
        {
            MyData.Params.RSD = tbSD.Text;
            MyData.Params.RED = tbED.Text;
        }

        private string Check()
        {
            if (tbSD.Text == "" || tbED.Text == "")
                return "Jāievada datums.";

            if (!Utils.StringToDate(tbSD.Text, out startDate) ||
                !Utils.StringToDate(tbED.Text, out endDate))
                return "Nekorekts datums.";

            if(bsBalA1.Count == 0)
                return "Sarakstā nav atskaišu.";

            if(dgvBalA1.CurrentRow == null)
                return "Jāizvēlas atskaite.";

            balid = dgvBalA1.CurrentRow.Cells[dgcBalA1balid.Index].Value.AsString();
            rtitle = dgvBalA1.CurrentRow.Cells[dgcBalA1Descr.Index].Value.AsString().Nz();
            raktivs = dgvBalA1.CurrentRow.Cells[dgcBalA1TA.Index].Value.AsString().Nz();
            rpasivs = dgvBalA1.CurrentRow.Cells[dgcBalA1TP.Index].Value.AsString().Nz();

            return "OK";
        }

        private void DoIt()
        {
            string rt = Check();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            
            int selectedreport = lbCM.SelectedIndex;
            if (selectedreport == -1) return;

            SaveParams();

            if (selectedreport == 4)
            {
                DoIt3();
                return;
            }
            if (selectedreport == 0 || selectedreport == 1)
            {
                DoIt1(selectedreport);
                return;
            }
            if (selectedreport == 2 || selectedreport == 3)
            {
                DoIt2(selectedreport);
                return;
            }
        }

        private void DoItT()
        {
            string rt = Check();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }

            int selectedreport = lbCM.SelectedIndex;
            if (selectedreport == -1) return;

            SaveParams();

            if (selectedreport == 0 || selectedreport == 1)
            {
                DoIt1T(selectedreport);
                return;
            }
            if (selectedreport == 2 || selectedreport == 3)
            {
                DoIt2T(selectedreport);
                return;
            }
        }

        private void DoIt1(int selectedreport)
        {
            var ad = MyData.GetKlonsFAdapter("BalA21") as BalA21TableAdapter;
            var ad2 = MyData.GetKlonsFAdapter("BalA22") as BalA22TableAdapter;
            if (ad == null) return;

            try
            {
                MyData.DataSetKlonsF.BalA21.Clear();
                MyData.DataSetKlonsF.BalA22.Clear();
                ad2.Fill(MyData.DataSetKlonsF.BalA22);
                ad.FillBy_bal_12(MyData.DataSetKlonsF.BalA21, startDate, endDate, balid);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Neizdevās sagatavot atskaiti.");
                return;
            }
            MyData.ReportHelperF.FillBalA2FromBalA21(balid);


            ReportViewerData rd = new ReportViewerData();

            switch (selectedreport)
            {
                case 0:
                    rd.FileName = "Report_Bilance_2";
                    break;
                case 1:
                    rd.FileName = "Report_Bilance_1";
                    break;
            }

            DataView dv = new DataView(
                MyData.DataSetKlonsF.BalA22,
                "balid = '" + balid + "'",
                "dc, nr",
                DataViewRowState.CurrentRows);
            rd.Sources["DataSet1"] = dv;
            rd.AddReportParameters(
                new string[]
                {
                    "RSD", MyData.Params.RSD,
                    "RED", MyData.Params.RED,
                    "CompanyName", MyData.Params.CompNameX,
                    "RTITLE", rtitle,
                    "RAKTIVS", raktivs,
                    "RPASIVS", rpasivs
                });
            MyMainForm.ShowReport(rd);
        }

        private void DoIt1T(int selectedreport)
        {
            var ad = MyData.GetKlonsFAdapter("BalA21") as BalA21TableAdapter;
            var ad2 = MyData.GetKlonsFAdapter("BalA22") as BalA22TableAdapter;
            if (ad == null) return;

            try
            {
                MyData.DataSetKlonsF.BalA21.Clear();
                MyData.DataSetKlonsF.BalA22.Clear();
                ad2.Fill(MyData.DataSetKlonsF.BalA22);
                ad.FillBy_bal_12(MyData.DataSetKlonsF.BalA21, startDate, endDate, balid);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Neizdevās sagatavot atskaiti.");
                return;
            }
            MyData.ReportHelperF.FillBalA2FromBalA21(balid);


            var reprows = MyData.DataSetKlonsF.BalA22
                .WhereX(x => x.balid == balid)
                .OrderBy(x => x.dc)
                .ThenBy(x => x.nr)
                .Select(x => RepRowBilance1.MakeFrom(x, 0))
                .ToList();
            var reprows2 = new List<RepRowBilance1>();
            bool bak = false, bpa = false;
            foreach (var row in reprows)
            {
                if (row.Dc == "AK" && !bak)
                {
                    var reprowak = new RepRowBilance1()
                    {
                        Kind = 1,
                        Descr = raktivs
                    };
                    reprows2.Add(reprowak);
                    bak = true;
                }
                if (row.Dc == "PA" && !bpa)
                {
                    var reprowpa = new RepRowBilance1()
                    {
                        Kind = 1,
                        Descr = rpasivs
                    };
                    reprows2.Add(reprowpa);
                    bpa = true;
                }
                if (!(selectedreport == 0 && row.S1 == 0M && row.S1 == 0M && row.S3 == 0M))
                {
                    reprows2.Add(row);
                }
            }

            var frm = MyMainForm.ShowForm(typeof(FormRep_Bilance1)) as FormRep_Bilance1;
            frm.Text = rtitle;
            frm.SetRowSource(reprows2, MyData.Params.RSD, MyData.Params.RED);
        }

        private void DoIt2(int selectedreport)
        {
            var ad = MyData.GetKlonsFAdapter("BalA2") as BalA2TableAdapter;
            var ad2 = MyData.GetKlonsFRepAdapter("SP_REP_BAL_22") as SP_REP_BAL_22TableAdapter;
            if (ad == null) return;

            try
            {
                MyData.DataSetKlonsF.BalA3.Clear();
                MyData.DataSetKlonsF.BalA2.Clear();
                MyData.DataSetKlonsF.BalA22.Clear();
                MyData.DataSetKlonsFRep.SP_REP_BAL_22.Clear();
                ad.Fill(MyData.DataSetKlonsF.BalA2);
                ad2.Fill(MyData.DataSetKlonsFRep.SP_REP_BAL_22, startDate, endDate, balid);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Neizdevās sagatavot atskaiti.");
                return;
            }

            List<RepRow_BalMT> reprows = null;

            ReportViewerData rd = new ReportViewerData();

            switch (selectedreport)
            {
                case 2:
                    reprows = PrepareReportMt_apgr(balid, MyData.DataSetKlonsFRep.SP_REP_BAL_22);
                    rd.FileName = "Report_Bilance_31";
                    break;
                case 3:
                    reprows = PrepareReportMt_atl(balid, MyData.DataSetKlonsFRep.SP_REP_BAL_22);
                    rd.FileName = "Report_Bilance_41";
                    break;
            }
            reprows = reprows.Where(x => !x.AllZeros).ToList();

            rd.Sources["DataSet1"] = reprows;
            rd.AddReportParameters(
                new string[]
                {
                    "RSD", MyData.Params.RSD,
                    "RED", MyData.Params.RED,
                    "CompanyName", MyData.Params.CompNameX,
                    "RTITLE", rtitle,
                    "RAKTIVS", raktivs,
                    "RPASIVS", rpasivs
                });
            MyMainForm.ShowReport(rd);
        }

        private void DoIt2T(int selectedreport)
        {
            var ad = MyData.GetKlonsFAdapter("BalA2") as BalA2TableAdapter;
            var ad2 = MyData.GetKlonsFRepAdapter("SP_REP_BAL_22") as SP_REP_BAL_22TableAdapter;
            if (ad == null) return;

            try
            {
                MyData.DataSetKlonsF.BalA3.Clear();
                MyData.DataSetKlonsF.BalA2.Clear();
                MyData.DataSetKlonsF.BalA22.Clear();
                MyData.DataSetKlonsFRep.SP_REP_BAL_22.Clear();
                ad.Fill(MyData.DataSetKlonsF.BalA2);
                ad2.Fill(MyData.DataSetKlonsFRep.SP_REP_BAL_22, startDate, endDate, balid);
            }
            catch (Exception ex)
            {
                MyMainForm.ShowWarning("Neizdevās sagatavot atskaiti.");
                return;
            }

            List<RepRow_BalMT> reprows = null;

            switch (selectedreport)
            {
                case 2:
                    reprows = PrepareReportMt_apgr(balid, MyData.DataSetKlonsFRep.SP_REP_BAL_22);
                    break;
                case 3:
                    reprows = PrepareReportMt_atl(balid, MyData.DataSetKlonsFRep.SP_REP_BAL_22);
                    break;
            }
            reprows = reprows.Where(x => !x.AllZeros).ToList();

            int k = reprows.FindIndex(x => x.Dc == "AK");
            if (k > -1)
            {
                var reprowak = new RepRow_BalMT()
                {
                    Tp = "X",
                    Descr = raktivs
                };
                reprows.Insert(k, reprowak);
            }
            k = reprows.FindIndex(x => x.Dc == "PA");
            if (k > -1)
            {
                var reprowak = new RepRow_BalMT()
                {
                    Tp = "X",
                    Descr = rpasivs
                };
                reprows.Insert(k, reprowak);
            }

            var frm = MyMainForm.ShowForm(typeof(FormRep_Bilance2)) as FormRep_Bilance2;
            frm.Text = rtitle;
            frm.SetRowSource(reprows);
        }

        private bool WCompare(string s, string pattern)
        {
            if (s == pattern) return true;
            if (pattern == "*") return true;
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(pattern)) return true;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(pattern)) return false;
            if (pattern.EndsWith("*"))
            {
                pattern = pattern.Substring(0, pattern.Length - 1);
                return s.StartsWith(pattern);
            }
            return false;
        }

        private void DoIt3()
        {
            if(MyData.DataSetKlonsF.BalA3.Count == 0)
            {
                MyData.DataSetKlonsF.BalA3.Clear();
                MyData.DataSetKlonsF.BalA2.Clear();
                MyData.FillTable(MyData.DataSetKlonsF.BalA2);
                MyData.FillTable(MyData.DataSetKlonsF.BalA3);
            }

            var table = MyData.DataSetKlonsFRep.ROps2a1;
            table.Clear();
            var ad = MyData.GetKlonsFRepAdapter("ROps2a1") as ROps2a1TableAdapter;
            ad.FillBy(table, startDate, endDate, "%");
            MyData.ReportHelperF.PrepareRops2a1();

            var b1 = MyData.DataSetKlonsF.BalA1.FindBybalid(balid);
            if (b1 == null) return;
            var bs2 = b1.GetBalA2Rows().ToArray();
            bs2 = bs2.Where(d => d.tp == "S").ToArray();
            foreach (var drb2 in bs2)
            {
                string snr = drb2.nr;
                var bs3 = drb2.GetBalA3Rows();
                foreach(var drb3 in bs3)
                {
                    string ac = drb3.ac;
                    string s;

                    var drs = table.Where(
                        d => WCompare(d.Ac, drb3.ac)
                    ).ToArray();

                    foreach(var dr in drs)
                    {
                        if (drb3.tp == "Db")
                        {
                            s = dr.DStr;
                            if (string.IsNullOrEmpty(s))
                                dr.DStr = snr;
                            else
                                dr.DStr = s + ", " + snr;
                        }
                        else
                        {
                            s = dr.CStr;
                            if (string.IsNullOrEmpty(s))
                                dr.CStr = snr;
                            else
                                dr.CStr = s + ", " + snr;
                        }
                    }
                }
            }

            ReportViewerData rd = new ReportViewerData();
            rd.FileName = "Report_Apgr_BilFormula";
            rd.Sources["DataSet1"] = MyData.DataSetKlonsFRep.ROps2a1;
            rd.AddReportParameters(
                new string[]
                {
                    "RSD", MyData.Params.RSD,
                    "RED", MyData.Params.RED,
                    "CompanyName", MyData.Params.CompNameX,
                    "PForReport", b1.Descr
                });
            MyMainForm.ShowReport(rd);
        }

        public List<RepRow_BalMT> PrepareReportMt_apgr(string balid, KlonsF.DataSets.klonsRepDataSet.SP_REP_BAL_22DataTable table)
        {
            var ret = new List<RepRow_BalMT>();
            foreach(var dr in table)
            {
                var drb = MyData.DataSetKlonsF.BalA2.FindByid(dr.ID);
                if (drb == null) continue;
                var rr = new RepRow_BalMT()
                {
                    id = dr.ID,
                    bid = dr.BID,
                    Dc = drb.dc,
                    Tp = drb.tp,
                    Nr = drb.nr,
                    Descr = drb.Descr,
                    M0 = dr.M0,
                    M1 = dr.M1,
                    M2 = dr.M2,
                    M3 = dr.M3,
                    M4 = dr.M4,
                    M5 = dr.M5,
                    M6 = dr.M6,
                    M7 = dr.M7,
                    M8 = dr.M8,
                    M9 = dr.M9,
                    M10 = dr.M10,
                    M11 = dr.M11,
                    M12 = dr.M12
                };
                rr.M13 = rr.M1 + rr.M2 + rr.M3 + rr.M4 + rr.M5 + rr.M6 + rr.M7 + rr.M8 + rr.M9 + rr.M10 + rr.M11 + rr.M12;
                if (rr.Tp == "V")
                {
                    rr.M0 = 0.0M;
                    rr.M1 = 0.0M;
                    rr.M2 = 0.0M;
                    rr.M3 = 0.0M;
                    rr.M4 = 0.0M;
                    rr.M5 = 0.0M;
                    rr.M6 = 0.0M;
                    rr.M7 = 0.0M;
                    rr.M8 = 0.0M;
                    rr.M9 = 0.0M;
                    rr.M10 = 0.0M;
                    rr.M11 = 0.0M;
                    rr.M12 = 0.0M;
                    rr.M13 = 0.0M;
                }
                ret.Add(rr);
            }
            return ret;
        }

        public List<RepRow_BalMT> PrepareReportMt_atl(string balid, KlonsF.DataSets.klonsRepDataSet.SP_REP_BAL_22DataTable table)
        {
            var ret = new List<RepRow_BalMT>();
            foreach (var dr in table)
            {
                var drb = MyData.DataSetKlonsF.BalA2.FindByid(dr.ID);
                if (drb == null) continue;
                var rr = new RepRow_BalMT()
                {
                    id = dr.ID,
                    bid = dr.BID,
                    Dc = drb.dc,
                    Tp = drb.tp,
                    Nr = drb.nr,
                    Descr = drb.Descr,
                    M0 = dr.M0,
                    M1 = dr.M1,
                    M2 = dr.M2,
                    M3 = dr.M3,
                    M4 = dr.M4,
                    M5 = dr.M5,
                    M6 = dr.M6,
                    M7 = dr.M7,
                    M8 = dr.M8,
                    M9 = dr.M9,
                    M10 = dr.M10,
                    M11 = dr.M11,
                    M12 = dr.M12
                };
                rr.M1 += rr.M0;
                rr.M2 += rr.M1;
                rr.M3 += rr.M2;
                rr.M4 += rr.M3;
                rr.M5 += rr.M4;
                rr.M6 += rr.M5;
                rr.M7 += rr.M6;
                rr.M8 += rr.M7;
                rr.M9 += rr.M8;
                rr.M10 += rr.M9;
                rr.M11 += rr.M10;
                rr.M12 += rr.M11;

                if (rr.Tp == "V")
                {
                    rr.M0 = 0.0M;
                    rr.M1 = 0.0M;
                    rr.M2 = 0.0M;
                    rr.M3 = 0.0M;
                    rr.M4 = 0.0M;
                    rr.M5 = 0.0M;
                    rr.M6 = 0.0M;
                    rr.M7 = 0.0M;
                    rr.M8 = 0.0M;
                    rr.M9 = 0.0M;
                    rr.M10 = 0.0M;
                    rr.M11 = 0.0M;
                    rr.M12 = 0.0M;
                    rr.M13 = 0.0M;
                }

                ret.Add(rr);
            }
            return ret;
        }

        private void cmReport_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperF.CheckForErrors(() =>
            {
                DoIt();
            });
        }

        private void cmTable_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperF.CheckForErrors(() =>
            {
                DoItT();
            });
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            OnNaviKey(sender, e);
        }

        private void lbCM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyData.ReportHelperF.CheckForErrors(() =>
            {
                DoIt();

            });
        }

        private void cmEdit_Click(object sender, EventArgs e)
        {
            MyMainForm.ShowForm(typeof (Form_BilancesFormula));
        }

    }

    public class RepRow_BalMT
    {
        public int id { get; set; } = 0;
        public int bid { get; set; } = 0;
        public string Nr { get; set; } = null;
        public string Dc { get; set; } = null;
        public string Tp { get; set; } = null;
        public string Descr { get; set; } = null;
        public decimal M0 { get; set; } = 0.0M;
        public decimal M1 { get; set; } = 0.0M;
        public decimal M2 { get; set; } = 0.0M;
        public decimal M3 { get; set; } = 0.0M;
        public decimal M4 { get; set; } = 0.0M;
        public decimal M5 { get; set; } = 0.0M;
        public decimal M6 { get; set; } = 0.0M;
        public decimal M7 { get; set; } = 0.0M;
        public decimal M8 { get; set; } = 0.0M;
        public decimal M9 { get; set; } = 0.0M;
        public decimal M10 { get; set; } = 0.0M;
        public decimal M11 { get; set; } = 0.0M;
        public decimal M12 { get; set; } = 0.0M;
        public decimal M13 { get; set; } = 0.0M;

        public bool AllZeros => M1 == 0M && M2 == 0M && M3 == 0M && M4 == 0M && 
            M5 == 0M && M6 == 0M && M7 == 0M && M8 == 0M && M9 == 0M && M10 == 0M && 
            M11 == 0M && M12 == 0M && M13 == 0M;
    }

}
