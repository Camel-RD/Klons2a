using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KlonsLIB.Misc;

namespace KlonsLIB.Components
{

    /// <summary>
    /// RichTextBox with 1px border line when borderstyle is None
    /// and with working doublebuffered
    /// </summary>
    [ToolboxBitmap(typeof(System.Windows.Forms.RichTextBox))]
    public class FlatRichTextBox : RichTextBox
    {
        private Color m_BorderColor = SystemColors.ControlDarkDark;

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return m_BorderColor; }
            set
            {
                m_BorderColor = value;
                Invalidate();
            }
        }

        public FlatRichTextBox()
        {
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void AdjustClientRect(ref NM.RECT rcClient)
        {
            rcClient.Left += 1;
            rcClient.Top += 1;
            rcClient.Right -= 1;
            rcClient.Bottom -= 1;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case NM.WM_NCPAINT:
                    base.WndProc(ref m);
                    if (BorderStyle == BorderStyle.None)
                    {
                        PaintFlatControlBorder2();
                        /*
                        using (var gdc = Graphics.FromHwnd(Handle))
                        {
                            PaintFlatControlBorder(gdc);
                        }
                        */
                    }
                    break;
                
                case NM.WM_PAINT:
                    base.WndProc(ref m);
                    if (BorderStyle == BorderStyle.None)
                    {
                        PaintFlatControlBorder2();
                    }
                    break;

                case NM.WM_NCCALCSIZE:
                    base.WndProc(ref m);
                    if (m.WParam != IntPtr.Zero)
                    {
                        NM.NCCALCSIZE_PARAMS rcsize = (NM.NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NM.NCCALCSIZE_PARAMS));
                        AdjustClientRect(ref rcsize.rcNewWindow);
                        Marshal.StructureToPtr(rcsize, m.LParam, false);
                    }
                    else
                    {
                        NM.RECT rcsize = (NM.RECT)Marshal.PtrToStructure(m.LParam, typeof(NM.RECT));
                        AdjustClientRect(ref rcsize);
                        Marshal.StructureToPtr(rcsize, m.LParam, false);
                    }
                    m.Result = new IntPtr(0x0300);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        public static Color Dark(Color baseColor)
        {
            return ControlPaint.Dark(baseColor, 0.5f);
        }

        private void PaintFlatControlBorder(Graphics g)
        {
            Rectangle rect = new Rectangle(-1, -1, Width + 1, Height + 1);
            if (Enabled)
                ControlPaint.DrawBorder(g, rect, m_BorderColor, ButtonBorderStyle.Solid);
            else
                ControlPaint.DrawBorder(g, rect, Dark(m_BorderColor), ButtonBorderStyle.Solid);
        }

        private void PaintFlatControlBorder2()
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            IntPtr hWnd = this.Handle;
            IntPtr hRgn = IntPtr.Zero;
            IntPtr hdc = NM.GetDCEx(hWnd, hRgn, 1027);
            using (var gdc = Graphics.FromHdc(hdc))
            {
                if (Enabled)
                    ControlPaint.DrawBorder(gdc, rect, m_BorderColor, ButtonBorderStyle.Solid);
                else
                    ControlPaint.DrawBorder(gdc, rect, Dark(m_BorderColor), ButtonBorderStyle.Solid);
            }

        }

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessageFmt(IntPtr hWnd, Int32 msg,
            Int32 wParam, ref NM.PARAFORMAT2 lParam);

        // 1pt = 20twips
        public void SetSelectionLineSpacing(byte bLineSpacingRule, int dyLineSpacing)
        {
            NM.PARAFORMAT2 format = new NM.PARAFORMAT2();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = NM.PFM_LINESPACING;
            format.dyLineSpacing = dyLineSpacing;
            format.bLineSpacingRule = bLineSpacingRule;
            SendMessageFmt(this.Handle, NM.EM_SETPARAFORMAT, NM.SCF_SELECTION, ref format);
        }

        public void SetSelectionSpaceBefore(int dySpaceBefore)
        {
            NM.PARAFORMAT2 format = new NM.PARAFORMAT2();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = NM.PFM_SPACEBEFORE;
            format.dySpaceBefore = dySpaceBefore;
            SendMessageFmt(this.Handle, NM.EM_SETPARAFORMAT, NM.SCF_SELECTION, ref format);
        }

        public void SetSelectionSpaceAfter(int dySpaceAfter)
        {
            NM.PARAFORMAT2 format = new NM.PARAFORMAT2();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = NM.PFM_SPACEAFTER;
            format.dySpaceAfter = dySpaceAfter;
            SendMessageFmt(this.Handle, NM.EM_SETPARAFORMAT, NM.SCF_SELECTION, ref format);
        }
    }
}
