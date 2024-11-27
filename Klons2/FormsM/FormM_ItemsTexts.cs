using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.DataSets;
using KlonsM.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Data;
using KlonsF.Classes;
using KlonsLIB.Misc;

namespace KlonsM.FormsM
{
    public partial class FormM_ItemsTexts : MyFormBaseF
    {
        public FormM_ItemsTexts()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        private void FormM_ItemsTexts_Load(object sender, EventArgs e)
        {
        }

        private void FormM_ItemsTexts_Shown(object sender, EventArgs e)
        {
            if (IdItem == null)
            {
                Close();
                return;
            }
            var dr_item = MyData.DataSetKlonsM.M_ITEMS.FindByID(IdItem.Value);
            if (dr_item == null)
            {
                Close();
                return;
            }
            var rt = FindItem(IdItem.Value);
            if (!rt)
            {
                Close();
                return;
            }
            tbCurrItem.Text = $"{dr_item.BARCODE}, {dr_item.NAME}";
            if (IdItemText != null)
            {
                FindItemText(IdItemText.Value);
            }
        }


        public int? IdItem = null;
        public int? IdItemText = null;
        public bool SetResultNull = false;

        public static (bool, int?) GetItemTextId(int iditem, int? iditemtext)
        {
            var fm = new FormM_ItemsTexts();
            fm.IdItem = iditem;
            fm.IdItemText = iditemtext;
            var ret = fm.ShowMyDialogModal();
            if (ret != DialogResult.OK) return (false, null);
            return (true, fm.SetResultNull ? null : fm.SelectedValueInt);
        }

        public bool FindItem(int id)
        {
            int k = bsItems.Find("ID", id);
            if (k == -1) return false;
            bsItems.Position = k;
            return true;
        }

        public bool FindItemText(int id)
        {
            int k = bsTexts.Find("ID", id);
            if (k == -1) return false;
            bsTexts.Position = k;
            return true;
        }

        private void cmFind_Click(object sender, EventArgs e)
        {
            var s = tbText.Text;
            if (s.IsNOE()) return;
            int k = bsTexts.Find("TEXT", s);
            if (k == -1)
            {
                MyMainForm.ShowInfo("Meklētais teksts netika atrasts.");
                return;
            }
            bsTexts.Position = k;
        }

        private void cmAdd_Click(object sender, EventArgs e)
        {
            var s = tbText.Text;
            if (s.IsNOE()) return;
            int k = bsTexts.Find("TEXT", s);
            if (k != -1)
            {
                MyMainForm.ShowWarning("Šāds teksts jau ir sarakstā.");
                return;
            }
            var table = MyData.DataSetKlonsM.M_ITEMS_TEXTS;
            var dr_new = table.NewM_ITEMS_TEXTSRow();
            dr_new.IDITEM = IdItem.Value;
            dr_new.TEXT = s;
            table.AddM_ITEMS_TEXTSRow(dr_new);
            FindItemText(dr_new.ID);
        }

        private void SelectCurrent()
        {
            if (dgvRows.CurrentRow == null || dgvRows.CurrentRow.IsNewRow) return;
            var dr = bsTexts.CurrentDataRow as KlonsMDataSet.M_ITEMS_TEXTSRow;
            if (!dgvRows.EndEdit()) return;
            if (!SaveData()) return;
            if (dr.RowState == DataRowState.Detached) return;
            int id = dr.ID;
            SelectedValueInt = dr.ID;
            if (!this.IsMyDialog) return;
            SetSelectedValue(id);
        }

        public override bool SaveData()
        {
            if (!dgvRows.EndEditX()) return false;

            if (!this.Validate()) return false;
            try
            {
                DataTasks.SetNewIDs(myAdapterManager1);
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

        private void CheckSave()
        {
            SetSaveButton(bsTexts.HasChanges());
        }

        private void SetSaveButton(bool red)
        {
            bNav.SetSaveButtonRed(red);
        }

        public void DeleteCurrent()
        {
            bNav.DeleteCurrent();
            SaveData();
        }

        private void dgvRows_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bNav.DeleteCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bsTexts_CurrentChanged(object sender, EventArgs e)
        {
            var dr_text = (KlonsMDataSet.M_ITEMS_TEXTSRow)bsTexts.CurrentDataRow;
            tbText.Text = dr_text?.TEXT;
        }

        private void dgvRows_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvRows.CurrentCell == null) return;

            if (e.Control && e.KeyCode == Keys.Return)
            {
                SelectCurrent();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                DeleteCurrent();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Insert && e.Shift)
            {
                if (!dgvRows.EndEdit()) return;
                dgvRows.MoveToNewRow();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                SetSelectedValue(null, true);
                e.Handled = true;
            }
        }

        private void dgvRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                SetSelectedValue(null, true);
            }
        }

        private void dgvRows_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = e.Row.IsNewRow || !AskCanDelete();
        }

        private void bNav_ItemDeleting(object sender, CancelEventArgs e)
        {
            e.Cancel = !AskCanDelete();
        }

        private void dgvRows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRows.CurrentRow == null || dgvRows.CurrentRow.IsNewRow) return;
            SelectCurrent();
        }

        private void cmSetResultNull_Click(object sender, EventArgs e)
        {
            SetResultNull = true;
            SetSelectedValue(0, false);
        }
    }
}
