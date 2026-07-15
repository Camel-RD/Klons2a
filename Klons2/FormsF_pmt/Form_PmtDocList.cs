using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsM.Classes;
using KlonsM.FormsM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KlonsF.FormsF_pmt
{
    public partial class Form_PmtDocList : MyFormBaseF
    {
        public Form_PmtDocList()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        private void Form_PmtDocList_Load(object sender, EventArgs e)
        {
            var table_docs = MyData.DataSetKlonsF.F_PMT_MSG;
            if (table_docs.Rows.Count == 0)
            {
                ClassesF.DataLoader.LoadPmtMsgs();
            }
        }

        public override bool SaveData()
        {
            if (!dgvDocs.EndEditX()) return false;

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

        private void CheckSave()
        {
            SetSaveButton(bsDocs.HasChanges());
        }

        private void SetSaveButton(bool red)
        {
            bnavDocs.SetSaveButtonRed(red);
        }

        private void dgvDocs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value) return;
            if (e.ColumnIndex == dgcACCOUNT.Index)
            {
                int id_acc = (int)e.Value;
                var dr_acc = MyData.DataSetKlonsF.F_PMT_ACCOUNTS.FindByID(id_acc);
                if (dr_acc != null)
                {
                    e.Value = dr_acc.NAME;
                    e.FormattingApplied = true;
                }
            }
        }

        private klonsDataSet.F_PMT_MSGRow GetCurrentDocRow()
        {
            if (bsDocs.Count == 0 || bsDocs.Current == null ||
                dgvDocs.CurrentRow.Index == dgvDocs.NewRowIndex) return null;
            var dr_doc = bsDocs.CurrentDataRow as klonsDataSet.F_PMT_MSGRow;
            return dr_doc;
        }

        public void DoDeleteDoc()
        {
            if (!SaveData()) return;
            if (!AskCanDelete()) return;
            var dr = GetCurrentDocRow();
            if (dr == null) return;
            if (dr.GetF_PMT_TRFTRXRows().Length == 0)
            {
                ClassesF.DataLoader.LoadPmtTrxByMsgId(dr.ID, true);
            }
            bsDocs.RemoveCurrent();

            SaveData();
        }

        public void DoOpenDoc()
        {
            if (!SaveData()) return;
            var dr = GetCurrentDocRow();
            if (dr == null) return;
            ClassesF.DataLoader.LoadPmtTrxByMsgId(dr.ID, true);
            Form_PmtDoc.ShowDocMyDialog(dr.ID);
        }


        public int GetLastMsgId()
        {
            int id1 = MyData.Params.PmtLastMsgId;
            var table_docs = MyData.DataSetKlonsF.F_PMT_MSG;
            int id2 = id1;
            if (table_docs.Count > 0)
                id2 = table_docs.Select(x => x.MSGID).Max();
            if (id1 < id2) id1 = id2;
            return id1;
        }

        public int GetLastTrxId()
        {
            int id1 = MyData.Params.PmtLastTrxId;
            var table_trx = MyData.DataSetKlonsF.F_PMT_TRFTRX;
            int id2 = id1;
            int? maxid = MyData.KlonsFQueriesTableAdapter.SP_F_PMT_GETMAXTRXID();
            if (maxid.HasValue) id2 = maxid.Value;
            if (id1 < id2) id1 = id2;
            if (table_trx.Count > 0)
                id2 = table_trx.Max(x => x.ID2);
            if (id1 < id2) id1 = id2;
            return id1;
        }


        public void DoAddNewDoc()
        {
            if (!SaveData()) return;

            var table_accounts = MyData.DataSetKlonsF.F_PMT_ACCOUNTS;
            var table_docs = MyData.DataSetKlonsF.F_PMT_MSG;

            if (table_accounts.Count == 0)
            {
                MyMainForm.ShowWarning("Nav pievienots neviens uzņēmuma bankas konts");
                return;
            }

            int id_acc = table_accounts.First().ID;

            int msgid = GetLastMsgId() + 1;
            string msgidstr = "";
            try
            {
                msgidstr = msgid.ToString(MyData.Params.PmtMsgIdFmt);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Nekorekts maksājuma uzdevuma npk. formāts");
                return;
            }

            var dr = table_docs.NewF_PMT_MSGRow();
            dr.DT = DateTime.Now;
            dr.MSGID = msgid;
            dr.MSGIDSTR = msgidstr;
            dr.ACCOUNT = id_acc;
            table_docs.AddF_PMT_MSGRow(dr);

            if (!SaveData()) return;
            Form_PmtDoc.ShowDocMyDialog(dr.ID);
        }

        public void DoCopyDoc()
        {
            if (!SaveData()) return;
            var dr_doc_cur = GetCurrentDocRow();
            if (dr_doc_cur == null) return;

            var table_docs = MyData.DataSetKlonsF.F_PMT_MSG;
            var table_rows = MyData.DataSetKlonsF.F_PMT_TRFTRX;

            int msgid = GetLastMsgId() + 1;
            int lasttrxid = GetLastTrxId();
            string msgidstr = "";
            try
            {
                msgidstr = msgid.ToString(MyData.Params.PmtMsgIdFmt);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Nekorekts maksājuma uzdevuma npk. formāts");
                return;
            }

            var dr_doc_new = table_docs.NewF_PMT_MSGRow();
            dr_doc_new.DT = DateTime.Now;
            dr_doc_new.MSGID = msgid;
            dr_doc_new.MSGIDSTR = msgidstr;
            dr_doc_new.ACCOUNT = dr_doc_cur.ACCOUNT;
            dr_doc_new.DESCR = dr_doc_cur.DESCR;
            table_docs.AddF_PMT_MSGRow(dr_doc_new);

            ClassesF.DataLoader.LoadPmtTrxByMsgId(dr_doc_cur.ID, true);
            var drs_cur = dr_doc_cur.GetF_PMT_TRFTRXRows().OrderBy(x => x.ID1).ToArray();
            int i = 1;
            foreach (var dr_row_cur in drs_cur)
            {
                var dr_row_new = table_rows.NewF_PMT_TRFTRXRow();
                int id1 = i;
                dr_row_new.ID1 = id1;
                lasttrxid++;
                dr_row_new.ID2 = lasttrxid;
                string id_trx_s = "";
                try
                {
                    id_trx_s = lasttrxid.ToString(MyData.Params.PmtTrxIdFmt);
                }
                catch (Exception)
                {
                    id_trx_s = lasttrxid.ToString();
                }
                dr_row_new.ID1STR = id1.ToString("TRX000");
                dr_row_new.ID2STR = id_trx_s;
                dr_row_new.CLID = dr_row_cur.CLID;
                dr_row_new.AMOUNT = dr_row_cur.AMOUNT;
                dr_row_new.DETAILS = dr_row_cur.DETAILS;
                dr_row_new.IDMSG = dr_doc_new.ID;
                dr_row_new.F_PMT_MSGRow = dr_doc_new;
                table_rows.AddF_PMT_TRFTRXRow(dr_row_new);
                i++;
            }

            dr_doc_new.AMOUNT = dr_doc_cur.AMOUNT;
            dr_doc_new.CT = dr_doc_cur.CT;

            SaveData();
            SelectDocById(dr_doc_new.ID);
        }

        void SelectDocById(int id)
        {
            if (bsDocs.Count == 0) return;
            for (int i = 0; i < bsDocs.Count; i++)
            {
                var dr = (bsDocs[i] as DataRowView).Row as klonsDataSet.F_PMT_MSGRow;
                if (dr.ID == id)
                {
                    bsDocs.Position = i;
                    return;
                }
                    
            }
        }

        private void dgvDocs_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvDocs.CurrentCell == null) return;
            if (e.KeyCode == Keys.Delete && e.Control)
            {
                DoDeleteDoc();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Insert && e.Shift)
            {
                if (!dgvDocs.EndEdit()) return;
                dgvDocs.MoveToNewRow();
                e.Handled = true;
                return;
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        private void dgvDocs_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            SaveData();
        }

        private void bsDocs_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void tsbReloadData_Click(object sender, EventArgs e)
        {
            ClassesF.DataLoader.LoadPmtMsgs();
        }

        private void tsbOpenDoc_Click(object sender, EventArgs e)
        {
            DoOpenDoc();
        }

        private void tsbAddNew_Click(object sender, EventArgs e)
        {
            DoAddNewDoc();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DoDeleteDoc();
        }

        private void dgvDocs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcDT.Index ||
               e.ColumnIndex == dgcMSGID.Index ||
               e.ColumnIndex == dgcMSGIDSTR.Index)
            {
                DoOpenDoc();
            }
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            DoCopyDoc();
        }
    }
}
