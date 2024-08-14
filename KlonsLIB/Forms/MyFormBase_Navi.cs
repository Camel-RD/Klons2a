using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlonsLIB.Forms
{
    public partial class MyFormBase : Form
    {
        private Control[][] controlsUpDownOrder = null;

        public void SetControlsUpDownOrder(Control[][] cs)
        {
            controlsUpDownOrder = cs;
        }

        protected bool GetPosInMoveSeq(Control control, out int r, out int c)
        {
            r = -1;
            c = -1;

            if (controlsUpDownOrder == null) return false;

            for (int i = 0; i < controlsUpDownOrder.Length; i++)
            {
                for (int j = 0; j < controlsUpDownOrder[i].Length; j++)
                {
                    if (controlsUpDownOrder[i][j] == control)
                    {
                        r = i;
                        c = j;
                        return true;
                    }
                }
            }
            return false;
        }

        protected Control GetControlInRow(int row, int col)
        {
            Control c = controlsUpDownOrder[row][col];
            if (c != null) return c;
            int c1 = col, c2 = col;
            do
            {
                if (c1 < 0 && c2 >= controlsUpDownOrder[row].Length)
                    return null;
                if (c1 >= 0 && controlsUpDownOrder[row][c1] != null)
                    return controlsUpDownOrder[row][c1];
                if (c2 < controlsUpDownOrder[row].Length &&
                    controlsUpDownOrder[row][c2] != null)
                    return controlsUpDownOrder[row][c2];
                c1--;
                c2++;
            } while (true);
        }

        protected Control GetUpControl(Control control)
        {
            int r, c;
            if (!GetPosInMoveSeq(control, out r, out c)) return null;
            if (r == 0) return GetNextControl(control, false);
            return GetControlInRow(r - 1, c);
        }

        protected Control GetDownControl(Control control)
        {
            int r, c;
            if (!GetPosInMoveSeq(control, out r, out c)) return null;
            if (r == controlsUpDownOrder.Length - 1) return GetNextControl(control, true);
            return GetControlInRow(r + 1, c);
        }

        protected bool CanGoRight(Control c)
        {
            if (c == null) return false;
            TextBox tb = c as TextBox;
            if (tb != null)
            {
                return tb.SelectionStart + tb.SelectionLength == tb.TextLength;
            }
            ComboBox cb = c as ComboBox;
            if (cb != null)
            {
                return cb.SelectionStart + cb.SelectionLength == cb.Text.Length;
            }
            return true;
        }
        protected bool CanGoLeft(Control c)
        {
            if (c == null) return false;
            TextBox tb = c as TextBox;
            if (tb != null)
            {
                return tb.SelectionStart + tb.SelectionLength == 0;
            }
            ComboBox cb = c as ComboBox;
            if (cb != null)
            {
                return cb.SelectionStart + cb.SelectionLength == 0;
            }
            return true;
        }
        protected bool CanGoUpOrDown(Control c)
        {
            if (c == null) return false;
            TextBox tb = c as TextBox;
            if (tb != null) return true;
            ComboBox cb = c as ComboBox;
            if (cb != null)
            {
                return !cb.DroppedDown;
            }
            return true;
        }

        protected bool GoLeft(Control control)
        {
            if (control == null) return false;
            if (!CanGoLeft(control)) return false;
            SelectNextControl(control, false, true, true, true);
            return true;
        }

        protected bool GoRight(Control control)
        {
            if (control == null) return false;
            if (!CanGoRight(control)) return false;
            SelectNextControl(control, true, true, true, true);
            return true;
        }
        protected bool GoUp(Control control)
        {
            if (control == null) return false;
            if (!CanGoUpOrDown(control)) return false;
            Control c = GetUpControl(control);
            if (c == null) return false;
            c.Select();
            return true;
        }
        protected bool GoDown(Control control)
        {
            if (control == null) return false;
            if (!CanGoUpOrDown(control)) return false;
            Control c = GetDownControl(control);
            if (c == null) return false;
            c.Select();
            return true;
        }

        protected bool OnNaviKey(object sender, KeyEventArgs e)
        {
            Control control = sender as Control;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    e.Handled = GoLeft(control);
                    break;
                case Keys.Right:
                    e.Handled = GoRight(control);
                    break;
                case Keys.Up:
                    e.Handled = GoUp(control);
                    break;
                case Keys.Down:
                    e.Handled = GoDown(control);
                    break;
            }
            return e.Handled;
        }

    }
}
