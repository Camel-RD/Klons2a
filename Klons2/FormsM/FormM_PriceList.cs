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
using KlonsLIB.Components;

namespace KlonsM.FormsM
{
    public partial class FormM_PriceList : MyFormBaseF, IMyDgvTextboxEditingControlEvents2
    {
        public FormM_PriceList()
        {
            InitializeComponent();
            CheckMyFontAndColors();

            DecimalsInPrices = MyData.Params.DECIMALSINPRICES;
            string price_format = "N" + DecimalsInPrices;
            dgcRPrice.DefaultCellStyle.Format = price_format;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            panel1.Height = tbLists.Bottom + tbLists.Top + 1;
        }


        private int DecimalsInPrices = 2;

        private void CheckEnableRows()
        {
            SetControlEnabled(dgvRowsR, bsLists.Count > 0 && bsLists.Current != null);
            SetControlEnabled(dgvRowsP, bsLists.Count > 0 && bsLists.Current != null);
        }

        public override bool SaveData()
        {
            if (!dgvRowsR.EndEditX()) return false;
            if (!dgvRowsP.EndEditX()) return false;
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

        private bool HasChanges()
        {
            return myAdapterManager1.HasChanges();
        }

        private void CheckSave()
        {
            SetSaveButton(HasChanges());
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

        public int? GetPriceListId()
        {
            return FormM_PriceLists.GetListId();
        }

        public int? GetStoreId(string code, EStoreType storefilter = EStoreType.Partneris)
        {
            return FormM_Stores.GetStoreId(code, storefilter);
        }

        public int? GetStoreCatId(string code)
        {
            return FormM_StoresCat.GetStoresCatId();
        }

        public int? GetItemId(string code)
        {
            return FormM_Items.GetItemId(code);
        }

        public int? GetItemsCatId(string code)
        {
            return FormM_ItemsCat.GetItemsCatId(code);
        }

        private void SetCurrentCellValue(DataGridView dgv, int value)
        {
            if (dgv.CurrentCell == null) return;
            try
            {
                dgv.BeginEdit(false);
                var c = dgv.EditingControl as KlonsLIB.Components.MyMcComboBox;
                if (c != null) c.SelectedValue = value;
                var c2 = dgv.EditingControl as KlonsLIB.Components.MyPickRowTextBox2;
                if (c2 != null) c2.SelectedValue = value;
                dgv.EndEdit();
            }
            catch (Exception) { }
        }

        public void GetItemId()
        {
            var cv = dgvRowsR.CurrentCell.FormattedValue as string;
            var rt = GetItemId(cv);
            if (rt == null) return;
            SetCurrentCellValue(dgvRowsR, rt.Value);
        }

        public void GetItemsCatId()
        {
            var dv = dgvRowsR.CurrentCell.FormattedValue as string;
            var rt = GetItemsCatId(dv);
            if (rt == null) return;
            SetCurrentCellValue(dgvRowsR, rt.Value);
        }

        public void GetStoreCatId()
        {
            var dv = dgvRowsP.CurrentCell.FormattedValue as string;
            var rt = GetStoreCatId(dv);
            if (rt == null) return;
            SetCurrentCellValue(dgvRowsP, rt.Value);
        }

        public void GetStoreId()
        {
            var dv = dgvRowsP.CurrentCell.FormattedValue as string;
            var rt = GetStoreId(dv);
            if (rt == null) return;
            SetCurrentCellValue(dgvRowsP, rt.Value);
        }

        private void dgvRowsR_Enter(object sender, EventArgs e)
        {
            bNav.BindingSource = bsRowsR;
            bNav.DataGrid = dgvRowsR;
            tslActiveTable.Text = "Artikuli";
        }

        private void dgvRowsP_Enter(object sender, EventArgs e)
        {
            bNav.BindingSource = bsRowsP;
            bNav.DataGrid = dgvRowsP;
            tslActiveTable.Text = "Personas";
        }

        private int SearchRowTextR(string text, int colindex,
            int startindex = 0, bool forward = true)
        {
            string propname = dgvRowsR.Columns[colindex].DataPropertyName;
            if (bsRowsR.Count == 0) return -1;
            if (startindex < 0 || startindex >= bsRowsR.Count) return -1;
            if (string.IsNullOrEmpty(text)) return -1;
            if (startindex == 0 && !forward) return -1;
            if (startindex == bsRowsR.Count - 1 && forward) return -1;
            var rv = bsRowsR[startindex] as DataRowView;
            if (rv == null) return -1;
            int colnr = rv.Row.Table.Columns.IndexOf(propname);
            if (colnr == -1) return -1;
            string columnname = rv.Row.Table.Columns[colnr].ColumnName;
            int di = forward ? 1 : -1;
            string val;
            text = text.ToLower();
            for (int i = startindex; i >= 0 && i < bsRowsR.Count; i += di)
            {
                var dr = (bsRowsR[i] as DataRowView).Row as KlonsMDataSet.M_PRICE_LISTS_RRow;
                if (dr == null) continue;
                val = null;
                if (colindex == dgcRItemName.Index)
                    val = MyData.DataSetKlonsM.M_ITEMS.FindByID(dr.IDITEM).NAME;
                else if (colindex == dgcRIdItem.Index)
                    val = MyData.DataSetKlonsM.M_ITEMS.FindByID(dr.IDITEM).BARCODE;
                if (val == null) continue;
                if (val.ToLower().Contains(text))
                {
                    return i;
                }
            }
            return -1;
        }

        private void SearchRowTextR(bool fromfirst = true, bool forward = true)
        {
            if (dgvRowsR.CurrentRow == null || dgvRowsR.CurrentRow.IsNewRow) return;
            if (!dgvRowsR.EndEditX()) return;

            int startindex = dgvRowsR.CurrentRow.Index;
            startindex = fromfirst ? 0 : (forward ? startindex + 1 : startindex - 1);
            string text = tsbFind.Text;
            if (text == "") return;
            int newindex = SearchRowTextR(text, dgvRowsR.CurrentCell.ColumnIndex, startindex, forward);
            if (newindex == -1)
            {
                MyMainForm.ShowInfo("Tekts [" + text + "] netika atrasts.");
                return;
            }
            dgvRowsR.CurrentCell = dgvRowsR[dgvRowsR.CurrentCell.ColumnIndex, newindex];
        }

        private int SearchRowTextP(string text, int colindex,
            int startindex = 0, bool forward = true)
        {
            string propname = dgvRowsP.Columns[colindex].DataPropertyName;
            if (bsRowsP.Count == 0) return -1;
            if (startindex < 0 || startindex >= bsRowsP.Count) return -1;
            if (string.IsNullOrEmpty(text)) return -1;
            if (startindex == 0 && !forward) return -1;
            if (startindex == bsRowsP.Count - 1 && forward) return -1;
            var rv = bsRowsP[startindex] as DataRowView;
            if (rv == null) return -1;
            int colnr = rv.Row.Table.Columns.IndexOf(propname);
            if (colnr == -1) return -1;
            string columnname = rv.Row.Table.Columns[colnr].ColumnName;
            int di = forward ? 1 : -1;
            string val;
            text = text.ToLower();
            for (int i = startindex; i >= 0 && i < bsRowsP.Count; i += di)
            {
                var dr = (bsRowsP[i] as DataRowView).Row as KlonsMDataSet.M_PRICE_LISTS_PRow;
                if (dr == null) continue;
                val = null;
                if (colindex == dgcPIdStore.Index)
                    val = MyData.DataSetKlonsM.M_STORES.FindByID(dr.IDSTORE).CODE;
                else if (colindex == dgcPIdStoreCat.Index)
                    val = MyData.DataSetKlonsM.M_STORES_CAT.FindByID(dr.IDSTORESCAT).CODE;
                if (val == null) continue;
                if (val.ToLower().Contains(text))
                {
                    return i;
                }
            }
            return -1;
        }

        private void SearchRowTextP(bool fromfirst = true, bool forward = true)
        {
            if (dgvRowsP.CurrentRow == null || dgvRowsP.CurrentRow.IsNewRow) return;
            if (!dgvRowsP.EndEditX()) return;

            int startindex = dgvRowsP.CurrentRow.Index;
            startindex = fromfirst ? 0 : (forward ? startindex + 1 : startindex - 1);
            string text = tsbFind.Text;
            if (text == "") return;
            int newindex = SearchRowTextP(text, dgvRowsP.CurrentCell.ColumnIndex, startindex, forward);
            if (newindex == -1)
            {
                MyMainForm.ShowInfo("Tekts [" + text + "] netika atrasts.");
                return;
            }
            dgvRowsP.CurrentCell = dgvRowsP[dgvRowsP.CurrentCell.ColumnIndex, newindex];
        }

        private void dgvRowsR_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value) return;

            if (e.ColumnIndex == dgcRItemName.Index)
            {
                int id = (int)e.Value;
                var table_items = MyData.DataSetKlonsM.M_ITEMS;
                var dr = table_items.FindByID(id);
                if (dr == null) return;
                e.Value = dr.NAME;
                e.FormattingApplied = true;
            }
        }

        private void bniSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bniDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrent();
        }

        private void bniNew_Click(object sender, EventArgs e)
        {
            bNav.DataGrid.MoveToNewRow();
        }

        private void bNav_ItemDeleting(object sender, CancelEventArgs e)
        {
            e.Cancel = !AskCanDelete();
        }

        private void dgvRowsR_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.IsNewRow || !AskCanDelete()) e.Cancel = true;
        }

        private void dgvRowsP_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.IsNewRow || !AskCanDelete()) e.Cancel = true;
        }

        private void dgvRowsR_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvRowsR.CurrentCell == null) return;
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                DeleteCurrent();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Insert && e.Shift)
            {
                if (!dgvRowsR.EndEdit()) return;
                dgvRowsR.MoveToNewRow();
                e.Handled = true;
                return;
            }

            if (dgvRowsR.CurrentRow == null ||
                //dgvRows.CurrentRow.IsNewRow ||
                dgvRowsR.CurrentCell == null) return;
            int colnr = dgvRowsR.CurrentCell.ColumnIndex;

            if (e.KeyCode == Keys.F4)
            {
                if (colnr == dgcRIdItem.Index)
                {
                    GetItemId();
                    e.Handled = true;
                    return;
                }
            }
        }

        private void dgvRowsP_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvRowsP.CurrentCell == null) return;
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                DeleteCurrent();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Insert && e.Shift)
            {
                if (!dgvRowsP.EndEdit()) return;
                dgvRowsP.MoveToNewRow();
                e.Handled = true;
                return;
            }

            if (dgvRowsP.CurrentRow == null ||
                //dgvRowsP.CurrentRow.IsNewRow ||
                dgvRowsP.CurrentCell == null) return;
            int colnr = dgvRowsP.CurrentCell.ColumnIndex;

            if (e.KeyCode == Keys.F4)
            {
                if (colnr == dgcPIdStore.Index)
                {
                    GetStoreId();
                    e.Handled = true;
                    return;
                }
                if (colnr == dgcPIdStoreCat.Index)
                {
                    GetStoreCatId();
                    e.Handled = true;
                    return;
                }
            }
        }

        private void dgvRowsR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRowsR.CurrentRow == null ||
                //dgvRowsR.CurrentRow.IsNewRow ||
                dgvRowsR.CurrentCell == null) return;
            int colnr = dgvRowsR.CurrentCell.ColumnIndex;

            if (colnr == dgcRIdItem.Index)
            {
                GetItemId();
                return;
            }
        }



        private void dgvRowsP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRowsP.CurrentRow == null ||
                //dgvRowsP.CurrentRow.IsNewRow ||
                dgvRowsP.CurrentCell == null) return;
            int colnr = dgvRowsP.CurrentCell.ColumnIndex;

            if (colnr == dgcPIdStore.Index)
            {
                GetStoreId();
                return;
            }
            if (colnr == dgcPIdStoreCat.Index)
            {
                GetStoreCatId();
                return;
            }
        }

        private void dgvRowsR_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void dgvRowsP_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void bsRowsR_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            if (e.ListChangedType == ListChangedType.Reset) return;
            CheckSave();
        }

        private void bsRowsP_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            if (e.ListChangedType == ListChangedType.Reset) return;
            CheckSave();
        }

        private void bsLists_ListChanged(object sender, ListChangedEventArgs e)
        {
            CheckEnableRows();
        }

        private void bsLists_CurrentChanged(object sender, EventArgs e)
        {
            CheckEnableRows();
        }

        void IMyDgvTextboxEditingControlEvents2.OnButtonClicked(MyDgvTextboxEditingControl2 control)
        {
            if (control.DataSource == bsStores)
            {
                GetStoreId();
                return;
            }
            if (control.DataSource == bsStoresCat)
            {
                GetStoreCatId();
                return;
            }
            if (control.DataSource == bsItems)
            {
                GetItemId();
                return;
            }
        }

        public void DoImportData()
        {
            if (bsLists.Count == 0 || bsLists.Current == null) return;
            var dr_list = bsLists.CurrentDataRow as KlonsMDataSet.M_PRICE_LISTSRow;
            if (dr_list == null) return;

            var fm = new FormM_ImportPrices();
            var rt = fm.ShowDialog();
            if (rt != DialogResult.OK || fm.Result.Count == 0) return;

            var table_pricelist_r = MyData.DataSetKlonsM.M_PRICE_LISTS_R;
            var drs_rows = dr_list.GetM_PRICE_LISTS_RRows();
            var dic_rowsbyid = drs_rows.ToDictionary(x => x.ID, x => x);

            foreach(var row_price in fm.Result)
            {
                int iditem = row_price.IdItem.Value;
                if (dic_rowsbyid.TryGetValue(iditem, out var dr_row))
                {
                    dr_row.PRICE = row_price.Price;
                }
                else
                {
                    var dr_new = table_pricelist_r.NewM_PRICE_LISTS_RRow();
                    dr_new.IDL = dr_list.ID;
                    dr_new.M_PRICE_LISTSRow = dr_list;
                    dr_new.IDITEM = iditem;
                    dr_new.PRICE = row_price.Price;
                    table_pricelist_r.AddM_PRICE_LISTS_RRow(dr_new);
                }
            }
            CheckSave();
            MyMainForm.ShowInfo("Datu imports pabeigts.", "", this);
        }

        private void tbLists_ButtonClicked(object sender, EventArgs e)
        {
            int? rt = GetPriceListId();
            if (!rt.HasValue) return;
            tbLists.SelectedValue = rt.Value;
        }

        private void tsbFindPrev_Click(object sender, EventArgs e)
        {
            if (bNav.BindingSource == bsRowsR)
            {
                SearchRowTextR(false, false);
                dgvRowsR.Focus();
            }
            else
            {
                SearchRowTextP(false, false);
                dgvRowsP.Focus();
            }
        }

        private void tsbFindNext_Click(object sender, EventArgs e)
        {
            if (bNav.BindingSource == bsRowsR)
            {
                SearchRowTextR(false, true);
                dgvRowsR.Focus();
            }
            else
            {
                SearchRowTextP(false, true);
                dgvRowsP.Focus();
            }
        }

        private void tsbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (bNav.BindingSource == bsRowsR)
                {
                    SearchRowTextR();
                    dgvRowsR.Focus();
                }
                else
                {
                    SearchRowTextP();
                    dgvRowsP.Focus();
                }
                e.Handled = true;
                return;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                bNav.DataGrid.Focus();
                e.Handled = true;
                return;
            }
        }

        private void tsbFind_Enter(object sender, EventArgs e)
        {
            tsbFind.Text = "";
        }

        private void miImportPriceList_Click(object sender, EventArgs e)
        {
            DoImportData();
        }
    }
}
