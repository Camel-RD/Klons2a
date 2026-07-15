using KlonsF.Classes;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KlonsF.FormsF_pmt
{
    public partial class Form_PmtAccounts : MyFormBaseF
    {
        public Form_PmtAccounts()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        private void Form_PmtAccounts_Load(object sender, EventArgs e)
        {
        }

        public override bool SaveData()
        {
            if (!dgvRows.EndEditX()) return false;

            if (!this.Validate()) return false;
            try
            {
                DataTasksF.SetNewIDs(myAdapterManager1);
                bool rt = myAdapterManager1.UpdateAll();
                CheckSave();
                return rt;
            }
            catch (Exception e)
            {
                CheckSave();
                Form_Error.ShowException(e, "Neizdevās saglabāt izmaiņas.");
                return false;
            }
        }

        public void DeleteCurrent()
        {
            bnavAccounts.DeleteCurrent();
            SaveData();
        }

        private void SetSaveButton(bool red)
        {
            bnavAccounts.SetSaveButton(tsbSave, red);
        }

        private void CheckSave()
        {
            SetSaveButton(bsBanks.HasChanges());
        }

        private void bnavAccounts_ItemDeleting(object sender, CancelEventArgs e)
        {
            e.Cancel = !AskCanDelete();
        }

        private void dgvRows_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = e.Row.IsNewRow || !AskCanDelete();
        }

        private void dgvRows_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvRows.CurrentCell == null) return;
            if (e.KeyCode == Keys.Insert && e.Shift)
            {
                if (!dgvRows.EndEdit()) return;
                dgvRows.MoveToNewRow();
                e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                DeleteCurrent();
                e.Handled = true;
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bsAccaounts_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void dgvRows_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            SaveData();
        }
    }
}
