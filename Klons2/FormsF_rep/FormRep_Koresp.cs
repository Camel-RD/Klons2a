﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsF.Forms;
using KlonsF.DataSets.klonsRepDataSetTableAdapters;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using Microsoft.Reporting.WinForms;

namespace KlonsF.FormsReportParams
{
    public partial class FormRep_Koresp : MyFormBaseF
    {
        public FormRep_Koresp()
        {
            InitializeComponent();
            toolStrip1.Renderer = MyMainForm.MainMenuStrip.Renderer;
            CheckMyFontAndColors();
        }

        private DateTime startDate = DateTime.MinValue;
        private DateTime endDate = DateTime.MinValue;
        private string ac = "";
        private string clid = "";
        private string startDateStr = "";
        private string endDateStr = "";

        private void FormRepKoresp1_Load(object sender, EventArgs e)
        {
            lbACName.Text = "";
            lbClName.Text = "";
            lbCm.SelectedIndex = 0;
            LoadParams();
            SetControlsUpDownOrder(new Control[][]
            {
                new Control[] {tbSD, tbED},
                new Control[] {cbAC, cbAC},
                new Control[] {cbClid, cbClid},
                new Control[] {cmDoIt, cmDoIt}
            });
        }

        private void CheckAcName()
        {
            string s = cbAC.Text;
            if (s == "")
            {
                lbACName.Text = "";
                return;
            }
            lbACName.Text = DataTasksF.GetAcName(s);
        }
        private void CheckClName()
        {
            string s = cbClid.Text;
            if (s == "")
            {
                lbClName.Text = "";
                return;
            }
            lbClName.Text = DataTasksF.GetClName(s);
        }

        private void cbAC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbAC_TextChanged(object sender, EventArgs e)
        {
            CheckAcName();
        }
        private void cbClid_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbClid_TextChanged(object sender, EventArgs e)
        {
            CheckClName();
        }
        private bool DoOnF5(ComboBox sender)
        {
            Action<string> act =
                value =>
                {
                    if (value != null)
                        sender.Text = value;
                };
            if (sender == cbAC)
            {
                MyMainForm.ShowFormAcplanDialog(act);
                return true;
            }

            if (sender == cbClid)
            {
                MyMainForm.ShowFormPersonsDialog(act);
                return true;
            }
            return false;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            OnNaviKey(sender, e);
            switch (e.KeyCode)
            {
                case Keys.F5:
                    if (sender is ComboBox)
                        if (DoOnF5(sender as ComboBox))
                        {
                            e.Handled = true;
                        }
                    break;
            }
        }

        private void cbClid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoOnF5(sender as ComboBox);
        }
        private void lbCm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyData.ReportHelperF.CheckForErrors(() =>
            {
                DoIt();

            });
        }

        private void LoadParams()
        {
            tbSD.Text = MyData.Params.RSD;
            tbED.Text = MyData.Params.RED;
            cbAC.Text = MyData.Params.RAC;
            cbClid.Text = MyData.Params.RPER;
            CheckAcName();
            CheckClName();
        }

        public override void SaveParams()
        {
            MyData.Params.RSD = startDateStr;
            MyData.Params.RED = endDateStr;
            MyData.Params.RAC = cbAC.Text;
            MyData.Params.RACNM = lbACName.Text;
            MyData.Params.RPER = cbClid.Text;
        }

        private string Check()
        {
            if (tbSD.Text == "" || tbED.Text == "")
                return "Jāievada datums.";

            if (!Utils.StringToDate(tbSD.Text, out startDate) ||
                !Utils.StringToDate(tbED.Text, out endDate) ||
                startDate > endDate)
                return "Nekorekts datums.";

            startDateStr = Utils.DateToString(startDate);
            endDateStr = Utils.DateToString(endDate);

            ac = cbAC.Text;
            if (ac == "") ac = "%";
            ac = ac.Replace('*', '%');

            clid = cbClid.Text;

            return "OK";
        }

        private void cmDoIt_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperF.CheckForErrors(() =>
            {
                DoIt();

            });
        }

        private void DoIt()
        {
            string rt = Check();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            SaveParams();

            int repid = lbCm.SelectedIndex;
            if (cbClid.Text == "*") cbClid.Text = "";
            if (cbClid.Text != "") repid += 7;

            ROps1aTableAdapter ad1a = MyData.GetKlonsFRepAdapter("ROps1a") as ROps1aTableAdapter;
            ROps2aTableAdapter ad2a = MyData.GetKlonsFRepAdapter("ROps2a") as ROps2aTableAdapter;
            ROps3aTableAdapter ad3a = MyData.GetKlonsFRepAdapter("ROps3a") as ROps3aTableAdapter;

            ReportViewerData rd = new ReportViewerData();
            if(repid != 6)
                rd.Sources["DataSet1"] = MyData.DataSetKlonsFRep.ROps1a;
            rd.Sources["DataSet_2a"] = MyData.DataSetKlonsFRep.ROps2a;
            rd.Sources["DataSet_3a"] = MyData.DataSetKlonsFRep.ROps3a;

            ReportViewerData rdsub = null;


            switch (repid)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    ad1a.FillBy_koresp_11(MyData.DataSetKlonsFRep.ROps1a, startDate, endDate, ac);
                    ad2a.FillBy_apgr_01(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac);
                    ad3a.FillBy_koresp_01(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac);
                    break;
                case 4:
                    ad1a.FillBy_koresp_11(MyData.DataSetKlonsFRep.ROps1a, startDate, endDate, ac);
                    ad2a.FillBy_apgr_02(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac);
                    ad3a.FillBy_koresp_02(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac);
                    break;
                case 6:
                    ad2a.FillBy_apgr_01(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac);
                    ad3a.FillBy_koresp_01(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac);
                    break;
                case 7:
                case 8:
                case 9:
                    ad1a.FillBy_koresp_11_clid(MyData.DataSetKlonsFRep.ROps1a, startDate, endDate, ac, clid);
                    ad2a.FillBy_apgr_01_clid(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac, clid);
                    ad3a.FillBy_koresp_01_clid(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac, clid);
                    break;
                case 10:
                    ad1a.FillBy_koresp_11_clid(MyData.DataSetKlonsFRep.ROps1a, startDate, endDate, ac, clid);
                    ad2a.FillBy_apgr_02_clid(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac, clid);
                    ad3a.FillBy_koresp_02_clid(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac, clid);
                    break;
                case 5:
                case 11:
                    ad1a.FillBy_koresp_11(MyData.DataSetKlonsFRep.ROps1a, startDate, endDate, ac);
                    ad2a.FillBy_apgr_02_clid(MyData.DataSetKlonsFRep.ROps2a, startDate, endDate, ac, null);
                    ad3a.FillBy_koresp_02_clid(MyData.DataSetKlonsFRep.ROps3a, startDate, endDate, ac, null);
                    break;
            }


            MyData.ReportHelperF.PrepareRops1a();
            MyData.ReportHelperF.PrepareRops2a();
            MyData.ReportHelperF.PrepareRops2aRAC();

            rd.AddReportParameters(
                new string[]
                {
                    "RSD", startDateStr,
                    "RED", endDateStr,
                    "RAC", cbAC.Text,
                    "RACNM", lbACName.Text,
                    "CompanyName", MyData.Params.CompNameX,
                    "RPER", MyData.Params.RPER,
                    "RPERNM", lbClName.Text,
                    "PAC", null,
                    "PCLID", null,
                    "RCURRENCY", ""
                });


            switch (lbCm.SelectedIndex)
            {
                case 0:
                    rd.FileName = "Report_Koresp_1";
                    break;
                case 1:
                    rd.FileName = "Report_Koresp_1_a";
                    break;
                case 2:
                    rd.FileName = "Report_Koresp_2";
                    break;
                case 3:
                    rd.FileName = "Report_Koresp_1_full";
                    break;
                case 6:
                    rd.FileName = "Report_Koresp_3";
                    break;
                case 4:
                    rdsub = rd;
                    rdsub.FileName = "Report_Koresp_1";
                    rdsub.AddSubreportLink("DataSet1", "PAC", "Ac1");
                    rdsub.AddSubreportLink("DataSet_2a", "PAC", "AC");
                    rdsub.AddSubreportLink("DataSet_3a", "PAC", "Ac1");

                    rd = new ReportViewerData();
                    rd.Sources["DataSet_2a"] = MyData.DataSetKlonsFRep.ROps2a;
                    rd.FileName = "Report_Koresp_1_byac";
                    rd.SubReports[rdsub.FileName] = rdsub;
                    rd.AddReportParameters(
                        new string[]
                        {
                            "RSD", startDateStr,
                            "RED", endDateStr,
                            "RAC", cbAC.Text,
                            "RACNM", lbACName.Text,
                            "CompanyName", MyData.Params.CompNameX,
                            "RPER", MyData.Params.RPER,
                            "RPERNM", lbClName.Text,
                            "RCURRENCY", ""
                        });
                    break;
                case 5:
                    rdsub = rd;
                    rdsub.FileName = "Report_Koresp_1";
                    rdsub.AddSubreportLink("DataSet1", "PAC", "Ac1", "PCLID", "Clid");
                    rdsub.AddSubreportLink("DataSet_2a", "PAC", "AC", "PCLID", "Clid");
                    rdsub.AddSubreportLink("DataSet_3a", "PAC", "Ac1", "PCLID", "Clid");

                    rd = new ReportViewerData();
                    rd.Sources["DataSet_2a"] = MyData.DataSetKlonsFRep.ROps2a;
                    rd.FileName = "Report_Koresp_1_byacnadcl";
                    rd.SubReports[rdsub.FileName] = rdsub;
                    rd.AddReportParameters(
                        new string[]
                        {
                            "RSD", startDateStr,
                            "RED", endDateStr,
                            "RAC", cbAC.Text,
                            "RACNM", lbACName.Text,
                            "CompanyName", MyData.Params.CompNameX,
                            "RPER", "",
                            "RPERNM", "",
                            "RCURRENCY", ""
                        });
                    break;
            }

            MyMainForm.ShowReport(rd);
        }

        private void tsbPrevMonth_Click(object sender, EventArgs e)
        {
            if (Check() != "OK") return;
            var dt2 = startDate.FirstDayOfMonth().AddDays(-1);
            var dt1 = dt2.FirstDayOfMonth();
            tbSD.Text = Utils.DateToString(dt1);
            tbED.Text = Utils.DateToString(dt2);
        }

        private void tsbNextMonth_Click(object sender, EventArgs e)
        {
            if (Check() != "OK") return;
            var dt1 = startDate.LastDayOfMonth().AddDays(1);
            var dt2 = dt1.LastDayOfMonth();
            tbSD.Text = Utils.DateToString(dt1);
            tbED.Text = Utils.DateToString(dt2);
        }

    }
}
