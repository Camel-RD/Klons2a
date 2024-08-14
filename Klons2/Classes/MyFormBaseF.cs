using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsLIB.Components;
using KlonsLIB.Forms;

namespace KlonsF.Classes
{
    public class MyFormBaseF : MyFormBase
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static KlonsData MyData { get { return KlonsData.St; } }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Form_Main MyMainForm { get { return Form_Main.MyInstance as Form_Main; } }

        [Browsable(false)]
        protected bool IsLoading = false;

        static MyFormBaseF()
        {
            var st = KlonsData.St;
        }

        public MyFormBaseF()
        {
            IsLoading = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            Icon = Properties.Resources.Icon1;
            //if (this.DesignMode) KlonsData.ResetInstance();
        }

        void ShowCBS()
        {
            string ss = "";
            foreach (var c in Controls)
            {
                if (c is MyMcComboBox ccb)
                {
                    ss += $"{ccb.Name}: {ccb.DropDownWidth}; ";
                }
            }
            if (ss == "") return;
            MessageBox.Show(ss);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (IsMdiChild)
                WindowState = FormWindowState.Maximized;
            IsLoading = false;

            /* WINE fix
            if (MyData.Settings.InWine == "YES")
            {
                CheckDropDownWidth(this);
            }*/
        }

        public void CheckDropDownWidth(Control c)
        {
            if (c == null) return;
            if (c is MyMcComboBox cb)
            {
                string[] ws = cb.ColumnWidths.Split(";".ToArray());
                int w = ws.Select(x => int.Parse(x)).Sum();
                cb.DropDownWidth = w + SystemInformation.VerticalScrollBarWidth + 1;
                //cb.DropDownWidth = cb.DropDownWidth + 1;
            }
            if (c is Form || c is ContainerControl || c is Panel || c is SplitContainer)
            {
                foreach (var c1 in c.Controls)
                {
                    CheckDropDownWidth(c1 as Control);
                }
            }
            if (c is TabControl tabc)
            {
                foreach (var page in tabc.TabPages)
                {
                    var cpage = page as Control;
                    foreach (var c1 in cpage.Controls)
                    {
                        CheckDropDownWidth(c1 as Control);
                    }
                }
                return;
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveData();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected virtual bool AskCanDelete()
        {
            DialogResult response = MyMessageBox.Show("Vai dzēst ierakstu?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MyMainForm);

            return response == DialogResult.Yes;
        }

        public ToolStripControlHost InsertInToolStrip(ToolStrip ts, Control c, int pos)
        {
            c.MinimumSize = new Size(c.Width, c.MinimumSize.Height);
            var it = new ToolStripControlHost(c);
            it.Margin = c.Margin;
            if (pos < 0 || pos >= ts.Items.Count)
                ts.Items.Add(it);
            else
                ts.Items.Insert(pos, it);
            return it;
        }

        public bool SaveBeforeProceed()
        {
            var ret = SaveData();
            if (!ret)
            {
                MyMainForm.ShowWarning("Pirms turpināt darbu, datiem jābūt saglabātiemn.");
                return false;
            }
            return true;
        }

    }

}
