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
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using KlonsF.Forms;

namespace KlonsF.Forms
{
    public partial class Form_Settings : MyFormBaseF
    {
        public Form_Settings()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            UpdateTabListColors();
            tabList1.PerformLayout();
        }

        private void Form_Settings2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private string colorThemeId = "";

        private void LoadData()
        {
            chCheckVersion.Checked = MyData.Settings.DoVersionCheck == "YES";

            string CHCOL = MyData.Params.CHCOL;
            if (string.IsNullOrEmpty(CHCOL) || CHCOL.Length != 4)
                CHCOL = "1111";
            chC1.Checked = CHCOL[0] == '1';
            chC2.Checked = CHCOL[1] == '1';
            chC3.Checked = CHCOL[2] == '1';
            chC4.Checked = CHCOL[3] == '1';
            chUseCurrency.Checked = MyData.Params.CHCOLCURR;
            chInWine.Checked = MyData.Settings.InWine == "YES";

            chDontShowBetaWarning.Checked = MyData.Settings.DontShowBetaWarning;

            tbMt.Text = MyData.Params.LoadMonths.ToString();
            chHideTotalSheet.Checked = MyData.Params.HideTotalSheets;
            chIIN.Checked = MyData.Params.IINSimple;

            string s = MyData.Settings.FormFontSize.ToString();
            if (s.Length == 1) s = "0" + s;
            cbFontSize.Text = s;
            cmFont.Text = MyData.Settings.FormFont.Name;
            colorThemeId = MyData.Settings.ColorThemeId;
            int k = colorThemeIds.IndexOf(colorThemeId);
            if (k > -1)
                cbColors.SelectedIndex = k;

            cbBackUpPlan.SelectedIndex = (int)MyData.Settings.BackUpPlanX;
            var backupfolder = MyData.Settings.BackUpFolder.Nz();
            if (backupfolder == "") backupfolder = "DB-backup";
            tbBackUpFolder.Text = backupfolder;
        }

        private bool SaveMyData()
        {
            MyData.Settings.DoVersionCheck = chCheckVersion.Checked ? "YES" : "NO";

            string c1 = chC1.Checked ? "1" : "0";
            string c2 = chC2.Checked ? "1" : "0";
            string c3 = chC3.Checked ? "1" : "0";
            string c4 = chC4.Checked ? "1" : "0";
            string CHCOL = c1 + c2 + c3 + c4;
            MyData.Params.CHCOL = CHCOL;
            MyData.Params.CHCOLCURR = chUseCurrency.Checked;
            MyData.Settings.InWine = chInWine.Checked ? "YES" : "NO";
            KlonsLIB.MyData.InWine = MyData.Settings.InWine == "YES";

            MyData.Settings.DontShowBetaWarning = chDontShowBetaWarning.Checked;

            int mtct;
            if (!string.IsNullOrEmpty(tbMt.Text) &&
                int.TryParse(tbMt.Text, out mtct) &&
                mtct > 0 && mtct < 100)
            {
                MyData.Params.LoadMonths = mtct;
            }
            MyData.Params.HideTotalSheets = chHideTotalSheet.Checked;
            MyData.Params.IINSimple = chIIN.Checked;

            MyData.Settings.FormFont = GetSelectedFont();
            MyData.Settings.ColorThemeId = colorThemeId;
            ColorThemeHelper.MyToolStripRenderer.SetColorTheme(Settings.ColorTheme);

            MyData.Settings.BackUpPlan = cbBackUpPlan.SelectedIndex;
            var backupfolder = tbBackUpFolder.Text.Nz();
            if (backupfolder == "DB-backup") backupfolder = "";
            MyData.Settings.BackUpFolder = backupfolder;
            return true;
        }

        private void ApplyColorTheme(string themeid)
        {
            MyColorTheme th = null;
            colorThemeId = themeid;
            switch (themeid)
            {
                case "system":
                    th = ColorThemeHelper.ColorTheme_System;
                    break;
                case "dark1":
                    th = ColorThemeHelper.ColorTheme_Dark1;
                    break;
                case "green":
                    th = ColorThemeHelper.ColorTheme_Green;
                    break;
                case "blackonwhite":
                    th = ColorThemeHelper.ColorTheme_BlackOnWhite;
                    break;
            }
            this.SetColorTheme(th);
            this.Refresh();
            UpdateTabListColors();
        }

        void UpdateTabListColors()
        {
            tabList1.HotBackColor = ColorThemeHelper.ColorBetween(tabList1.BackColor, tabList1.ForeColor, 0.1f);
        }

        private Font GetSelectedFont()
        {
            FontStyle fs = Font.Style & (FontStyle.Bold | FontStyle.Regular | FontStyle.Italic);
            int sz = int.Parse(cbFontSize.Text);
            var ret = new Font(Font.FontFamily, sz, fs);
            return ret;
        }

        private void ApplyFont(Font font)
        {
            FontStyle fs = font.Style & (FontStyle.Bold | FontStyle.Regular | FontStyle.Italic);
            cmFont.Text = font.Name;
            int sz = (int)Math.Round(font.SizeInPoints * GetFontScaleFactor(), 0);
            if (sz < 6) sz = 6;
            if (sz > 24) sz = 24;
            string s = sz.ToString();
            if (sz < 10) s = "0" + s;
            cbFontSize.Text = s;

            this.Font = new Font(font.FontFamily, sz, fs);
        }

        private void cmFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = this.Font;
            fd.ShowColor = false;
            fd.MinSize = 6;
            fd.MaxSize = 24;
            fd.AllowScriptChange = false;

            if (fd.ShowDialog(this) != DialogResult.OK) return;
            ApplyFont(fd.Font);
        }
        private void cmUseSysFont_Click(object sender, EventArgs e)
        {
            ApplyFont(SystemFonts.DefaultFont);
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sz = int.Parse(cbFontSize.Text);
            sz = (int)Math.Round(sz * GetFontScaleFactor(), 0);
            if (sz != this.Font.SizeInPoints)
                SetFontSize(sz);
        }

        private void cmOK_Click(object sender, EventArgs e)
        {
            SaveMyData();
            MyMainForm.CheckMyFontAndColors1();
            MyMainForm.CheckMyFontAndColors2();
            MyMainForm.CheckMenuColorTheme();
            this.Close();
        }

        private static string[] colorThemeIds =
            new string[] { "system", "dark1", "green", "blackonwhite" };
        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = cbColors.SelectedIndex;
            if (k < 0 || k > 3) return;
            ApplyColorTheme(colorThemeIds[k]);
        }

        private void cmBrowseForBackUpFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog()
            {
                Description = "Norādi mapi rezerves failu kopēšanai:"
            };
            var rt = fbd.ShowDialog(MyMainForm);
            if (rt != DialogResult.OK) return;
            tbBackUpFolder.Text = fbd.SelectedPath;
        }
    }
}

