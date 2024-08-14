using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlonsLIB.Components
{
    public static class NM
    {
        public const int WM_ERASEBKGND = 0x14;
        public const int WM_PAINT = 0xF;
        public const int WM_NCPAINT = 0x85;
        public const int WM_NCCALCSIZE = 0x0083;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_NCHITTEST = 0x0084;
        public const int WM_PRINTCLIENT = 0x318;
        public const int WM_USER = 0x0400;
        public const int WM_NOTIFY = 0x004E;



        public const int SCF_SELECTION = 1;
        public const int PFM_LINESPACING = 256;
        public const int PFM_SPACEBEFORE = 0x00000040;
        public const int PFM_SPACEAFTER = 0x00000080;
        public const int EM_SETPARAFORMAT = 1095;

        public const int AW_VER_POSITIVE = 0x00000004;
        public const int AW_VER_NEGATIVE = 0x00000008;
        public const int AW_SLIDE = 0x00040000;
        public const int AW_HIDE = 0x00010000;

        public const int SC_CONTEXTHELP = 0xf180;

        public const int GWL_WNDPROC = -4;
        public const int GWL_HINSTANCE = -6;
        public const int GWL_HWNDPARENT = -8;
        public const int GWL_STYLE = -16;
        public const int GWL_EXSTYLE = -20;
        public const int GWL_USERDATA = -21;
        public const int GWL_ID = -12;

        public const int TCM_ADJUSTRECT = 0x1328;

        public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hRgn, int flags);

        [DllImport("user32")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                this.Left = left;
                this.Top = top;
                this.Right = right;
                this.Bottom = bottom;
            }

            public RECT(Rectangle r)
            {
                Left = r.Left;
                Top = r.Top;
                Right = r.Right;
                Bottom = r.Bottom;
            }

            public static implicit operator Rectangle(RECT r)
                => Rectangle.FromLTRB(r.Left, r.Top, r.Right, r.Bottom);

            public static implicit operator RECT(Rectangle r) => new RECT(r);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NCCALCSIZE_PARAMS
        {
            public RECT rcNewWindow;
            public RECT rcOldWindow;
            public RECT rcClient;
            IntPtr lppos;
        }

        public static int HIWORD(IntPtr n) => HIWORD(unchecked((int)(long)n));
        public static int HIWORD(int n) => (n >> 16) & 0xffff;
        public static int LOWORD(int n) => n & 0xffff;
        public static int LOWORD(IntPtr n) => LOWORD(unchecked((int)(long)n));
        public static int SignedHIWORD(IntPtr n) => SignedHIWORD(unchecked((int)(long)n));
        public static int SignedLOWORD(IntPtr n) => SignedLOWORD(unchecked((int)(long)n));
        public static int SignedHIWORD(int n) => (int)(short)((n >> 16) & 0xffff);
        public static int SignedLOWORD(int n) => (int)(short)(n & 0xFFFF);


        public static partial class ComCtl32
        {
            public enum TCM : uint
            {
                FIRST = 0x1300,
                GETITEMRECT = FIRST + 10
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr HWND;
            public uint idFrom;
            public int code;

            public override string ToString() => $"Hwnd: {HWND}, ControlID: {idFrom}, Code: {code}";
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                X = x;
                Y = y;
            }

            public static implicit operator Point(POINT point) => new(point.X, point.Y);

            public static implicit operator POINT(Point point) => new((int)point.X, (int)point.Y);
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public Int16 wNumbering;
            public Int16 wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public Int16 wAlignment;
            public Int16 cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public Int16 sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public Int16 wShadingWeight;
            public Int16 wShadingStyle;
            public Int16 wNumberingStart;
            public Int16 wNumberingStyle;
            public Int16 wNumberingTab;
            public Int16 wBorderSpace;
            public Int16 wBorderWidth;
            public Int16 wBorders;
        }
    }
}
