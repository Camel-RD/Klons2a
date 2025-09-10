using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KlonsLIB.Data;
using KlonsLIB.Misc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using KlonsLIB.Components;
using System.Runtime.InteropServices;

namespace KlonsLIB.Forms
{
    public partial class MyFormBase : Form
    {
        private ToolStrip myToolStrip = null;

        public new SizeF AutoScaleDimensions
        {
            get => base.AutoScaleDimensions;
            set => base.AutoScaleDimensions = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool DialogCanceled { get; set; } = false;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string SelectedValue { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedValueInt { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<string> OnSelectedValue;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<int> OnSelectedValueInt;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual IKlonsSettings Settings
        {
            get
            {
                if (MyData.Settings == null)
                    throw new Exception("Setting not set.");
                return MyData.Settings;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static MyMainFormBase MyMainForm { protected set; get; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMyDialog
        {
            get { return isMyDialog; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsFormClosing { get; private set; }

        public MyFormBase()
        {
            IsFormClosing = false;
            CloseOnEscape = false;
        }

        static MyFormBase()
        {
            MyMainForm = null;
        }

        [DefaultValue(8f)]
        public float DesignTimeFontSize { get; set; } = 8f;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //CheckMyFontAndColors2();
        }


        private bool isMyDialog = false;

        private bool OnSelectedValueCalled = false;

        protected void SetSelectedValue(string value, bool cancel = false)
        {
            if (!this.Validate()) return;

            DialogCanceled = cancel;
            SelectedValue = value;
            if (Modal || IsMyDialog)
            {
                if (OnSelectedValue != null) OnSelectedValue(value);
                OnSelectedValueCalled = true;
            }
            if (Modal)
            {
                DialogResult = value == null || cancel ? DialogResult.Cancel : DialogResult.OK;
            }
            else if (IsMyDialog)
            {
                Close();
            }
        }

        protected void SetSelectedValue(int value, bool cancel = false)
        {
            if (!this.Validate()) return;

            DialogCanceled = cancel;
            SelectedValueInt = value;
            SelectedValue = value.ToString();

            if (Modal || IsMyDialog)
            {
                if (OnSelectedValueInt != null) OnSelectedValueInt(SelectedValueInt);
                if (OnSelectedValue != null) OnSelectedValue(SelectedValue);
                OnSelectedValueCalled = true;
            }
            if (Modal)
            {
                DialogResult = cancel ? DialogResult.Cancel : DialogResult.OK;
            }
            else if (IsMyDialog)
            {
                Close();
            }
        }

        public void ShowMyDialog()
        {
            isMyDialog = true;
            this.Show();
        }

        public DialogResult ShowMyDialogModal()
        {
            isMyDialog = true;
            return this.ShowDialog(MyMainForm);
        }

        public virtual void SetupMenuRenderer()
        {
            ColorThemeHelper.MyToolStripRenderer.SetColorTheme(MyColorTheme);
            if (this.MainMenuStrip != null)
            {
                MainMenuStrip.ForeColor = Color.White;
                MainMenuStrip.Renderer = ColorThemeHelper.MyToolStripRenderer;
            }
            if (MyToolStrip != null)
                MyToolStrip.Renderer = ColorThemeHelper.MyToolStripRenderer;
        }

        public virtual void CheckMenuColorTheme()
        {
            ColorThemeHelper.MyToolStripRenderer.SetColorTheme(MyColorTheme);
            if (this.MainMenuStrip != null)
                MainMenuStrip.Refresh();
        }

        [DefaultValue(null)]
        [TypeConverter(typeof(ReferenceConverter))]
        public virtual ToolStrip MyToolStrip
        {
            get { return myToolStrip; }
            set
            {
                if (value == myToolStrip) return;
                myToolStrip = value;
                if (myToolStrip != null)
                {
                    myToolStrip.Renderer = ColorThemeHelper.MyToolStripRenderer;
                }
            }
        }

        public virtual void SaveParams()
        {

        }
        public virtual bool SaveData()
        {
            return true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (IsFormClosing) return;
            IsFormClosing = true;
            try
            {
                SaveParams();
            }
            catch (Exception) { }

            try
            {
                base.OnFormClosing(e);
                if (e.Cancel)
                {
                    IsFormClosing = false;
                    return;
                }
                if (!SaveData())
                {
                    var s = $"Logs [{Text}] tiks aizvērt, bet\niespējams, ka datos bija kļūda.";
                    MyMainForm.ShowWarning(s);
                    IsFormClosing = false;
                    return;
                }

                if (Modal || IsMyDialog)
                {
                    if (OnSelectedValue != null && !OnSelectedValueCalled) OnSelectedValue(null);
                    //if (OnSelectedValueInt != null && !OnSelectedValueCalled) OnSelectedValueInt(null);
                    OnSelectedValueCalled = true;
                }
            }
            finally
            {
                if (e.Cancel == true)
                    IsFormClosing = false;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (this.IsMdiChild && this.MdiParent != null)
            {
                var fm = MdiParent as MyMainFormBase;
                if (fm != null) fm.OnMyCloseForm(this);
            }
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool CloseOnEscape { get; set; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.Tab)) return true;
            if (keyData == (Keys.Control | Keys.Tab)) return true;
            if (keyData == (Keys.Control | Keys.F6)) return true;
            if (keyData == (Keys.Control | Keys.Shift | Keys.F6)) return true;
            if (keyData == Keys.Escape && CloseOnEscape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.Decimal)
            {
                //SendKeys.Send(".");
                //return true;
                msg.WParam = (IntPtr)Keys.OemPeriod;
                return false;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        #region +++++++++ Theming and Scaling +++++++++

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual MyColorTheme MyColorTheme => MyData.Settings.ColorTheme;

        protected void SetColorTheme(MyColorTheme theme)
        {
            ColorThemeHelper.ApplyToForm(this, theme);
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                if (base.Font == value) return;
                float f = value.Size / base.Font.Size;
                ScaleToolStrips(this, new SizeF(f, f));
                base.Font = value;
            }
        }

        protected void SetFontWithoutScaling(Font font)
        {
            var md = Utils.GetMethod(GetType(), "SetScaledFont");
            if (md == null) return;
            md.Invoke(this, [font, false]);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            if (this.StartPosition == FormStartPosition.CenterScreen)
            {
                CenterToScreen();
            }
            else if (this.StartPosition == FormStartPosition.CenterParent)
            {
                CenterToParent();
            }
        }

        public void CheckMyFontAndColors()
        {
            CheckMyFontAndColors1();
            _ = Handle;
            CreateAllHandles();
            CheckMyFontAndColors2();
        }

        public void CheckMyFontAndColors1()
        {
            SetFontSize(DefaultFont.Size + 0.01f);
            //Font = DefaultFont;
            MyColorTheme cth = Settings.ColorTheme;
            ColorThemeHelper.ApplyToForm(this, cth);
            if (MainMenuStrip != null)
                ColorThemeHelper.ApplyToControlA(MainMenuStrip, cth);
            if (MyToolStrip != null)
                ColorThemeHelper.ApplyToControlA(MyToolStrip, cth);
        }

        public float GetFontScaleFactor()
        {
            uint dpi = NM.GetDpiForWindow(Handle);
            float dpi_scaling = dpi / 96.0f;
            if (dpi_scaling > 1.5f) dpi_scaling = 1.5f;
            float ret = 1.5f / dpi_scaling;
            //ret *= 10.0f / DefaultFont.Size;
            return ret;

        }

        public void CheckMyFontAndColors2()
        {
            SuspendLayout();
            float fontscalefactor = GetFontScaleFactor();
            float fsz = Settings.FormFont.Size * fontscalefactor;
            this.Font = new Font(Settings.FormFont.FontFamily, fsz, Settings.FormFont.Style);
            foreach (Control c in GetAllControls(this))
            {
                if (c is ContainerControl)
                {
                    _ = c.Handle;
                }
                if (c is ToolStrip tsp)
                {
                    if (c.Font != this.Font)
                        c.Font = this.Font;
                    foreach (var ti in GetAllToolsStripItems(tsp))
                    {
                        if (ti is ToolStripComboBox tscb)
                            tscb.Font = this.Font;
                    }
                }
                else
                {
                    if (!c.Font.Equals(this.Font))
                    {
                        c.Font = new Font(Font.FontFamily, Font.SizeInPoints, c.Font.Style);
                    }
                    if (c is MyDataGridView dgv)
                    {
                        dgv.UpdateStyleFonts();
                    }
                }
            }
            ResumeLayout(true);
        }

        protected virtual void CheckMyFontSize()
        {
            SetFontSize(Settings.FormFontSize);
        }

        protected void SetFontSize(float sz)
        {
            if (this.Font.Size != sz)
                this.Font = new Font(this.Font.Name, sz, this.Font.Style);
        }

        private SizeF scaleFactor = new SizeF(1.0f, 1.0f);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SizeF ScaleFactor => scaleFactor;
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            scaleFactor = new SizeF(scaleFactor.Width * factor.Width, scaleFactor.Height * factor.Height);
            base.ScaleControl(factor, specified);
            //if (InScaleWithFontChange)
            //    ScaleToolStrips(this, factor);
        }

        protected void ScaleToolStrips(Form form, SizeF factor)
        {
            float fontscalefactor = DefaultFont.Size / 10.0f;
            factor *= fontscalefactor;
            foreach (var c in GetAllControls(form))
            {
                if (c is ToolStrip tsp && !(c is MenuStrip))
                {
                    ScaleToolStrip(tsp, factor);
                }
            }
        }

        protected void ScaleToolStrip(ToolStrip tsp, SizeF factor)
        {
            float f = Math.Max(factor.Width, factor.Height);
            if (f == 1.0f) return;
            var imgsz = tsp.ImageScalingSize;
            imgsz.Width = (int)((float)imgsz.Width * f);
            imgsz.Height = (int)((float)imgsz.Height * f);
            (tsp as ToolStrip).ImageScalingSize = imgsz;
        }
        #endregion

        protected void CreateAllTabPages()
        {
            foreach (Control c in GetAllControls(this))
            {
                if (c is not TabControl tc) continue;
                int k0 = tc.SelectedIndex;
                for (int k1 = 0; k1 < tc.TabCount; k1++)
                {
                    if (k1 == k0) continue;
                    tc.SelectedIndex = k1;
                }
                tc.SelectedIndex = k0;
            }
        }

        protected void CreateAllHandles()
        {
            foreach (Control c in GetAllControls(this))
            {
                _ = c.Handle;
            }
        }

        protected void CreateHandlesForContainers()
        {
            foreach (Control c in GetAllControls(this))
            {
                if (c is not ContainerControl) continue;
                _ = c.Handle;
            }
        }

        protected void CreateAllContainerHandles()
        {
            foreach (Control c in GetAllControls(this))
            {
                if (c is not ContainerControl cc) continue;
                _ = c.Handle;
            }
        }

        public static IEnumerable<Control> GetAllControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                yield return c;
                foreach (Control c1 in GetAllControls(c))
                {
                    yield return c1;
                }
            }
        }

        public static IEnumerable<ToolStripItem> GetAllToolsStripItems(ToolStrip tsp)
        {
            foreach (ToolStripItem tsi in tsp.Items)
            {
                foreach (ToolStripItem tsi2 in GetAllToolsStripItems(tsi))
                {
                    yield return tsi2;
                }
            }
        }

        public static IEnumerable<ToolStripItem> GetAllToolsStripItems(ToolStripItem tsi)
        {
            yield return tsi;
            if (tsi is ToolStripDropDownItem tsdd)
            {
                foreach (ToolStripItem tsi2 in tsdd.DropDownItems)
                {
                    foreach (ToolStripItem tsi3 in GetAllToolsStripItems(tsi2))
                    {
                        yield return tsi3;
                    }
                }
            }
        }

        public void SetControlEnabled(Control control, bool enabled)
        {
            if (!enabled && control.Focused)
                ActiveControl = null;
            control.Enabled = enabled;
        }

        public void SetControlVisible(Control control, bool visible)
        {
            if (!visible && control.Focused)
                ActiveControl = null;
            control.Visible = visible;
        }
    }
}
