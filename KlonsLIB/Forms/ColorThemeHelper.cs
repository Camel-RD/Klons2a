using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KlonsLIB.Components;
using KlonsLIB.Misc;
using KlonsLIB.MySourceGrid;

namespace KlonsLIB.Forms
{
    public class MyColorTheme
    {
        public Color ControlColor { get; private set; }
        public Color ControlTextColor { get; private set; }
        public Color ControlColorDark { get; private set; }
        public Color ControlColorDarkDark { get; private set; }
        public Color ControlColorLight { get; private set; }
        public Color WindowColor { get; private set; }
        public Color WindowTextColor { get; private set; }
        public Color BorderColor { get; private set; }
        public Color MenuHighlight { get; private set; }

        private Dictionary<Color, Color> SysToMy = new Dictionary<Color, Color>();

        public bool UsingSystemColors { get; private set; } = true;

        public MyColorTheme()
        {
            UseSystemColors();
        }

        private void MakeTables()
        {
            SysToMy[SystemColors.ControlText] = ControlTextColor;
            SysToMy[SystemColors.Control] = ControlColor;
            SysToMy[SystemColors.WindowText] = WindowTextColor;
            SysToMy[SystemColors.Window] = WindowColor;
            SysToMy[SystemColors.ControlLight] = ControlColorLight;
            SysToMy[SystemColors.ControlDark] = ControlColorDark;
            SysToMy[SystemColors.ControlDarkDark] = ControlColorDarkDark;
        }

        public Color TranslateSystemColor(Color color)
        {
            if (!color.IsSystemColor) return Color.Empty;
            switch (color.ToKnownColor())
            {
                case KnownColor.Window: return WindowColor;
                case KnownColor.WindowText: return WindowTextColor;
                case KnownColor.Control: return ControlColor;
                case KnownColor.ControlText: return ControlTextColor;
                case KnownColor.ControlDark: return ControlColorDark;
                case KnownColor.ControlDarkDark: return ControlColorDarkDark;
                case KnownColor.ControlLight: return ControlColorLight;
            }
            return Color.Empty;
        }

        public Color GetColor(Color color, Color defaultvalue)
        {
            if (color.IsEmpty) return defaultvalue;
            Color c1 = TranslateSystemColor(color);
            if (!c1.IsEmpty) return c1;
            //if (SysToMy.Keys.Contains(color))
            //    return SysToMy[color];
            return defaultvalue;
        }

        public Color SetForeColor(Control c, Color defaultvalue)
        {
            return c.ForeColor = GetColor(c.ForeColor, defaultvalue);
        }

        public Color SetBackColor(Control c, Color defaultvalue)
        {
            return c.ForeColor = GetColor(c.ForeColor, defaultvalue);
        }

        public Color GetColor2(Color color, Color defaultvalue)
        {
            if (color.IsEmpty) return defaultvalue;
            Color c1 = TranslateSystemColor(color);
            if (!c1.IsEmpty) return c1;
            return color;
        }

        public void UseSystemColors()
        {
            WindowColor = SystemColors.Window;
            WindowTextColor = SystemColors.WindowText;
            ControlColor = SystemColors.Control;
            ControlTextColor = SystemColors.ControlText;
            ControlColorLight = SystemColors.ControlLight;
            ControlColorDark = SystemColors.ControlDark;
            ControlColorDarkDark = SystemColors.ControlDarkDark;
            //MenuHighlight = SystemColors.MenuHighlight;
            //MenuHighlight = ColorThemeHelper.ColorBetween(WindowColor, WindowTextColor, 0.2f);
            MenuHighlight = ColorThemeHelper.MakeLighter(WindowColor, 0.3f, 0.7f, 2.5f);

            BorderColor = ControlColorDarkDark;
            UsingSystemColors = true;
            MakeTables();
        }

        public void UseDarkTheme1()
        {
            WindowColor = Color.FromArgb(37, 37, 38);
            WindowTextColor = Color.FromArgb(241, 241, 241);
            ControlColor = Color.FromArgb(37, 37, 38);
            ControlTextColor = Color.FromArgb(241, 241, 241);
            ControlColorLight = Color.FromArgb(241, 241, 241);
            ControlColorDark = Color.FromArgb(200, 200, 200);
            ControlColorDarkDark = ControlTextColor;
            MenuHighlight = Color.FromArgb(80, 80, 85);
            BorderColor = ControlColorDarkDark;
            UsingSystemColors = false;
            MakeTables();
        }
        public void UseGreenOnBlack()
        {
            WindowColor = Color.FromArgb(0, 0, 0);
            WindowTextColor = Color.FromArgb(0, 255, 0);
            ControlColor = Color.FromArgb(0, 0, 0);
            ControlTextColor = Color.FromArgb(0, 255, 0);
            ControlColorLight = Color.FromArgb(0, 240, 0);
            ControlColorDark = Color.FromArgb(100, 100, 100);
            ControlColorDarkDark = Color.FromArgb(0, 240, 0);
            MenuHighlight = Color.FromArgb(0, 50, 0);
            BorderColor = ControlColorDarkDark;
            UsingSystemColors = false;
            MakeTables();
        }
        public void UseBlackOnWhite()
        {
            WindowColor = Color.FromArgb(255, 255, 255);
            WindowTextColor = Color.FromArgb(0, 0, 0);
            ControlColor = Color.FromArgb(220, 220, 220);
            ControlTextColor = Color.FromArgb(0, 0, 0);
            ControlColorLight = Color.FromArgb(150, 150, 150);
            ControlColorDark = Color.FromArgb(150, 150, 150);
            ControlColorDarkDark = Color.FromArgb(70, 70, 70);
            MenuHighlight = Color.FromArgb(240, 240, 240);
            BorderColor = ControlColorDarkDark;
            UsingSystemColors = false;
            MakeTables();
        }
    }
    public class ColorThemeHelper
    {

        public static MyToolStripRenderer MyToolStripRenderer { get; private set; } = null;

        public static bool InWine { get; set; } = false;

        static ColorThemeHelper()
        {
            MyToolStripRenderer = new MyToolStripRenderer();
        }

        public static MyColorTheme ColorTheme_System
        {
            get
            {
                MyColorTheme mc = new MyColorTheme();
                mc.UseSystemColors();
                return mc;
            }
        }
        public static MyColorTheme ColorTheme_Dark1
        {
            get
            {
                MyColorTheme mc = new MyColorTheme();
                mc.UseDarkTheme1();
                return mc;
            }
        }
        public static MyColorTheme ColorTheme_Green
        {
            get
            {
                MyColorTheme mc = new MyColorTheme();
                mc.UseGreenOnBlack();
                return mc;
            }
        }
        public static MyColorTheme ColorTheme_BlackOnWhite
        {
            get
            {
                MyColorTheme mc = new MyColorTheme();
                mc.UseBlackOnWhite();
                return mc;
            }
        }

        public static MyColorTheme GetColorThemeById(string id)
        {
            switch (id)
            {
                case "system":
                    return ColorTheme_System;
                case "dark1":
                    return ColorTheme_Dark1;
                case "green":
                    return ColorTheme_Green;
                case "blackonwhite":
                    return ColorTheme_BlackOnWhite;
            }
            return ColorTheme_System;
        }

        public static void ApplyToForm(Form f, MyColorTheme mycolortheme)
        {
            ApplyToControlA(f, mycolortheme);
        }

        public static void ApplyToControlA(object c0, MyColorTheme mycolortheme)
        {
            ApplyToControl(c0, mycolortheme);

            if (c0 is ToolStripDropDownItem tsddi)
            {
                foreach (var c1 in tsddi.DropDownItems)
                {
                    ApplyToControlA(c1, mycolortheme);
                }
                return;
            }

            if (c0 is not Control c) return;

            if (c is ToolStrip tsp)
            {
                foreach (var c1 in tsp.Items)
                {
                    ApplyToControlA(c1, mycolortheme);
                    if (c1 is ToolStripControlHost tsch)
                        ApplyToControlA(tsch.Control, mycolortheme);
                }
                return;
            }

            foreach (Control c1 in c.Controls)
            {
                ApplyToControlA(c1, mycolortheme);
            }

            if (c is Cyotek.Windows.Forms.TabList ctbl)
            {
                foreach (var page in ctbl.TabListPages)
                {
                    ApplyToControlA(page, mycolortheme);
                }
                return;
            }

        }

        public static void ApplyToControl(object c0, MyColorTheme mycolortheme)
        {
            //if (c0 is ToolStripSeparator) return;

            if (c0 is ToolStripItem tmi)
            {
                tmi.ForeColor = mycolortheme.GetColor(tmi.ForeColor, mycolortheme.ControlTextColor);
                tmi.BackColor = mycolortheme.GetColor(tmi.BackColor, mycolortheme.ControlColor);
                if (tmi is ToolStripDropDownItem tdd)
                {
                    tdd.ForeColor = mycolortheme.GetColor(tdd.ForeColor, mycolortheme.ControlTextColor);
                    //tdd.BackColor = mycolortheme.GetColor(tdd.BackColor, mycolortheme.ControlColorDark);
                }
                return;
            }

            if (c0 is not Control c) return;


            if (c is Form)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.ControlColor);
            }
            else if (c is MdiClient)
            {
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.ControlColor);
            }
            else if (c is ToolStrip tsp)
            {
                if (tsp.Renderer != MyToolStripRenderer)
                    tsp.Renderer = MyToolStripRenderer;
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.ControlColor);
                tsp.Refresh();
            }
            else if (c is TabPage)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.ControlColor);
            }
            else if (c is MyLabel cmylabel)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
                cmylabel.BorderColor = mycolortheme.GetColor(cmylabel.BorderColor, mycolortheme.BorderColor);
            }
            else if (c is Label)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
            }
            else if (c is MyTextBox cmytextbox)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                cmytextbox.BorderColor = mycolortheme.GetColor(cmytextbox.BorderColor, mycolortheme.BorderColor);
            }
            else if (c is FlatRichTextBox frb)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                frb.BorderColor = mycolortheme.GetColor2(frb.BorderColor, mycolortheme.BorderColor);
            }
            else if (c is TextBox || c is RichTextBox)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            else if (c is MyMcFlatComboBox cmyfcb)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                cmyfcb.BorderColor = mycolortheme.GetColor(cmyfcb.BorderColor, mycolortheme.BorderColor);
                cmyfcb.GridLineColor = mycolortheme.GetColor(cmyfcb.GridLineColor, mycolortheme.ControlTextColor);
            }
            else if (c is MyMcComboBox cmycb)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                cmycb.GridLineColor = mycolortheme.GetColor(cmycb.GridLineColor, mycolortheme.ControlTextColor);
            }
            else if (c is FlatComboBox cfcb)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                cfcb.BorderColor = mycolortheme.GetColor(cfcb.BorderColor, mycolortheme.BorderColor);
            }
            else if (c is ComboBox)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            else if (c is ListBox)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            else if (c is ListView)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            else if (c is PropertyGrid)
            {
                var prgr = c as PropertyGrid;
                prgr.BackColor = mycolortheme.GetColor(prgr.BackColor, mycolortheme.WindowColor);
                prgr.ViewBackColor = prgr.BackColor;
                prgr.ViewForeColor = mycolortheme.GetColor(prgr.ViewForeColor, mycolortheme.ControlTextColor);
                prgr.LineColor = MakeLighter(prgr.BackColor, 0.3f, 0.7f, 2f);
                prgr.CategoryForeColor = prgr.ViewForeColor;
                prgr.HelpBackColor = prgr.BackColor;
                prgr.HelpForeColor = prgr.ViewForeColor;
                //prgr.CategorySplitterColor = prgr.ViewForeColor;
                //prgr.CategoryForeColor = mycolortheme.GetColor(prgr.CategoryForeColor, mycolortheme.ForeColor);
                //prgr.CategorySplitterColor = mycolortheme.GetColor(prgr.CategorySplitterColor, mycolortheme.ControlColor);
            }
            else if (c is DataGridView dgv)
            {
                dgv.BackColor = mycolortheme.GetColor(dgv.BackColor, mycolortheme.ControlColor);
                dgv.BackgroundColor = mycolortheme.GetColor(dgv.BackColor, mycolortheme.ControlColor);
                //dgv.GridColor = mycolortheme.GetColor(dgv.GridColor, mycolortheme.ControlColorDark);
                dgv.GridColor = ColorBetween(dgv.BackColor, mycolortheme.WindowTextColor, 0.5f);
                dgv.DefaultCellStyle.BackColor =
                    mycolortheme.GetColor(dgv.DefaultCellStyle.BackColor, mycolortheme.WindowColor);
                dgv.DefaultCellStyle.ForeColor =
                    mycolortheme.GetColor(dgv.DefaultCellStyle.ForeColor, mycolortheme.WindowTextColor);
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = 
                    mycolortheme.GetColor(dgv.ColumnHeadersDefaultCellStyle.BackColor, mycolortheme.ControlColor);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                    mycolortheme.GetColor(dgv.ColumnHeadersDefaultCellStyle.ForeColor, mycolortheme.ControlTextColor);
                dgv.RowHeadersDefaultCellStyle.BackColor =
                    mycolortheme.GetColor(dgv.RowHeadersDefaultCellStyle.BackColor, mycolortheme.ControlColor);
                dgv.RowHeadersDefaultCellStyle.ForeColor =
                    mycolortheme.GetColor(dgv.RowHeadersDefaultCellStyle.ForeColor, mycolortheme.ControlTextColor);
            }
            else if (c is MyGrid mygrid)
            {
                mygrid.ApplyColorTheme(mycolortheme);
            }
            else if (c is MyCheckBox)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            else if (c is ExTabControl cextc)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
                cextc.BorderColor = c.ForeColor;
                cextc.HeaderBackColor = c.BackColor;
                cextc.HeaderForeColor = c.ForeColor;
                //cextc.ActiveHeaderBackColor = HslColor.Lighter(c.BackColor, 0.2f);
                cextc.ActiveHeaderBackColor = c.BackColor;
                cextc.ActiveHeaderForeColor = c.ForeColor;
                cextc.HighlightBackColor = MakeLighter(c.BackColor, 0.3f, 0.7f, 2.5f);
                cextc.HighlightForeColor= c.ForeColor;
            }
            else if (c is Cyotek.Windows.Forms.TabList ctbl)
            {
                ctbl.ForeColor = mycolortheme.GetColor(ctbl.ForeColor, mycolortheme.ControlTextColor);
                ctbl.BackColor = mycolortheme.GetColor(ctbl.BackColor, mycolortheme.ControlColor);
                ctbl.HotBackColor = mycolortheme.GetColor(ctbl.HotBackColor, mycolortheme.ControlColorDark);
            }
            else if (c is Button)
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.ControlTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.ControlColor);
            }

            /*
            else
            {
                c.ForeColor = mycolortheme.GetColor(c.ForeColor, mycolortheme.WindowTextColor);
                c.BackColor = mycolortheme.GetColor(c.BackColor, mycolortheme.WindowColor);
            }
            */
        }

        public static Color MakeLighter(Color color, float r, float rfix, float deform)
        {
            color = Color.FromArgb(color.ToArgb());
            r = Math.Min(0.4f, Math.Max(-0.4f, r));
            int deltalum = (int)(240f * r);
            var hc1 = HslColor.FromRgbColor(color);
            int curlum = hc1.Luminosity;
            deltalum = (int)((float)deltalum * (1f - rfix * Math.Pow((float)curlum / 240f, deform)));
            var newlum = curlum + deltalum;
            if (newlum > 240 || newlum < 10) newlum = curlum - deltalum;
            hc1.Luminosity = newlum;
            var ret = hc1.ToRgbColor();
            return ret;
        }

        public static Color ColorBetween(Color color1, Color color2, float factor)
        {
            return Color.FromArgb(
                color1.R + (int)((float)((color2.R - color1.R)) * factor),
                color1.G + (int)((float)((color2.G - color1.G)) * factor),
                color1.B + (int)((float)((color2.B - color1.B)) * factor));
        }
    }
}
