using EInvoiceLib;
using java.time;
using KlonsA.Forms;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsF.Forms;
using KlonsLIB.Components;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using KlonsM.FormsM;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using UblSharp.CommonAggregateComponents;

namespace KlonsF.FormsF_pmt
{
    public partial class Form_PmtDoc : MyFormBaseF, IMyDgvTextboxEditingControlEvents2
    {
        public Form_PmtDoc()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        public bool FindDoc(int iddoc)
        {
            if (bsDocs.Count == 0) return false;
            for (int i = 0; i < bsDocs.Count; i++)
            {
                var dr = (bsDocs[i] as DataRowView).Row as klonsDataSet.F_PMT_MSGRow;
                if (dr.ID != iddoc) continue;
                bsDocs.Position = i;
                ActiveDocId = iddoc;
                return true;
            }
            return false;
        }

        public bool SelectDoc(int iddoc)
        {
            bsDocs.Filter = $"ID = {iddoc}";
            return bsDocs.Count > 0;
        }

        public static bool ShowDocMyDialog(int iddoc)
        {
            var form = KlonsData.St.MyMainForm.ShowFormDialog(typeof(Form_PmtDoc)) as Form_PmtDoc;
            bool rt = form.SelectDoc(iddoc);
            if (!rt)
            {
                form.Close();
                KlonsData.St.MyMainForm.ShowError("Neizdevās atvērt dokumentu.");
                return false;
            }
            return true;
        }

        public int? ActiveDocId = null;

        private void Form_PmtDoc_Load(object sender, EventArgs e)
        {
            MyData.DataSetKlonsF.F_PMT_MSG.ColumnChanged += F_PMT_MSG_ColumnChanged;
            MyData.DataSetKlonsF.F_PMT_TRFTRX.F_PMT_TRFTRXRowChanged += F_PMT_TRFTRX_F_PMT_TRFTRXRowChanged;
            MyData.DataSetKlonsF.F_PMT_TRFTRX.F_PMT_TRFTRXRowDeleting += F_PMT_TRFTRX_F_PMT_TRFTRXRowDeleting;
            CheckSave();
        }

        private void Form_PmtDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyData.DataSetKlonsF.F_PMT_MSG.ColumnChanged -= F_PMT_MSG_ColumnChanged;
            MyData.DataSetKlonsF.F_PMT_TRFTRX.F_PMT_TRFTRXRowChanged -= F_PMT_TRFTRX_F_PMT_TRFTRXRowChanged;
            MyData.DataSetKlonsF.F_PMT_TRFTRX.F_PMT_TRFTRXRowDeleting -= F_PMT_TRFTRX_F_PMT_TRFTRXRowDeleting;
        }

        private klonsDataSet.F_PMT_MSGRow last_list_RowDeleting_parent = null;

        private void F_PMT_TRFTRX_F_PMT_TRFTRXRowChanged(object sender, klonsDataSet.F_PMT_TRFTRXRowChangeEvent e)
        {
            if (e.Action == DataRowAction.Commit) return;

            klonsDataSet.F_PMT_MSGRow dr = null;

            if (e.Row.RowState == DataRowState.Deleted ||
                e.Row.RowState == DataRowState.Detached)
            {
                if (e.Row.HasVersion(DataRowVersion.Original))
                {
                    int listid = (int)e.Row["IDMSG", DataRowVersion.Original];
                    dr = MyData.DataSetKlonsF.F_PMT_MSG.FindByID(listid);
                }
                else
                {
                    if (e.Action == DataRowAction.Delete)
                        dr = last_list_RowDeleting_parent;
                }
            }
            else
            {
                dr = e.Row.F_PMT_MSGRow;
            }
            if (dr == null) return;
            CheckListTotal(dr);
        }

        private void F_PMT_TRFTRX_F_PMT_TRFTRXRowDeleting(object sender, klonsDataSet.F_PMT_TRFTRXRowChangeEvent e)
        {
            last_list_RowDeleting_parent = e.Row.F_PMT_MSGRow;
        }

        private void F_PMT_MSG_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName == "MSGID")
            {
                var dr = e.Row as klonsDataSet.F_PMT_MSGRow;
                try
                {
                    dr.MSGIDSTR = dr.MSGID.ToString(MyData.Params.PmtMsgIdFmt);
                }
                catch (Exception)
                {
                    dr.MSGIDSTR = dr.MSGID.ToString();
                }
            }
        }

        private void CheckListTotal(klonsDataSet.F_PMT_MSGRow listrow)
        {
            if (listrow == null || listrow.RowState == DataRowState.Deleted ||
                listrow.RowState == DataRowState.Detached) return;
            var (total, ct) = SumTotal(listrow);
            if (listrow.AMOUNT != total) listrow.AMOUNT = total;
            if (listrow.CT != ct) listrow.CT = ct;
        }

        private (decimal, int) SumTotal(klonsDataSet.F_PMT_MSGRow listrow)
        {
            if (listrow == null || listrow.RowState == DataRowState.Deleted ||
                listrow.RowState == DataRowState.Detached) return (0.0M, 0);
            decimal ret = 0.0M;
            var rows = listrow.GetF_PMT_TRFTRXRows();
            foreach (var row in rows)
            {
                ret += row.AMOUNT;
            }
            return (ret, rows.Length);
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

        private void CheckSave()
        {
            SetSaveButton(bsRows.HasChanges() || bsDocs.HasChanges());
        }

        private void SetSaveButton(bool red)
        {
            bnavDocs.SetSaveButtonRed(red);
        }

        public void DeleteCurrent()
        {
            bnavDocs.DeleteCurrent();
            SaveData();
        }

        private void SetCurrentDocEditorValue(string value)
        {
            if (ActiveControl == null) return;
            try
            {
                dgvRows.BeginEdit(false);
                if (dgvRows.EditingControl is MyMcComboBox cb1)
                {
                    cb1.SelectedValue = value;
                }
                else if (dgvRows.EditingControl is MyPickRowTextBox2 cb2)
                {
                    cb2.SelectedValue = value;
                }
                dgvRows.EndEdit();
            }
            catch (Exception) { }
        }

        public string GetClId(string clid)
        {
            return Form_Persons.GetClId(clid);
        }

        public void GetClId()
        {
            var clid = dgvRows.IsCurrentCellInEditMode ?
                dgvRows.EditingControl.Text :
                dgvRows.CurrentCell.FormattedValue as string;
            var rt = GetClId(clid);
            if (rt == null) return;
            SetCurrentDocEditorValue(rt);
        }

        void IMyDgvTextboxEditingControlEvents2.OnButtonClicked(MyDgvTextboxEditingControl2 control)
        {
            if (control.DataSource == bsPersons)
            {
                GetClId();
                return;
            }
        }

        private void dgvRowsGetCellValue(object sender, int colind)
        {
            Action<string> act =
                value =>
                {
                    try
                    {
                        if (value != null && dgvRows.CurrentCell != null)
                        {
                            dgvRows.BeginEdit(false);
                            dgvRows.EditingControl.Text = value;
                            dgvRows.EndEdit();

                        }
                        dgvRows.Select();
                        if (dgvRows.EditingControl != null)
                            ActiveControl = dgvRows.EditingControl;
                    }
                    finally
                    {
                        dgvRows.GoingToDialog = false;
                    }
                };
            if (colind == dgcRowsCLID.Index)
            {
                dgvRows.GoingToDialog = true;
                MyMainForm.ShowFormPersonsDialog(act);
                return;
            }
        }

        private void DgvRows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRowsGetCellValue(sender, e.ColumnIndex);
        }

        private void dgvRows_MyKeyDown(object sender, KeyEventArgs e)
        {
            if (dgvRows.CurrentCell == null) return;
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
            if (e.KeyCode == Keys.F4)
            {
                if (dgvRows.CurrentCell.ColumnIndex == dgcRowsCLID.Index)
                {
                    GetClId();
                }
                e.Handled = true;
                return;
            }

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dgvRows_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void DgvDoc_MyCheckForChanges(object sender, System.EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void bsRows_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void BsDocs_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void dgvRows_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = e.Row.IsNewRow || !AskCanDelete();
        }

        private void bnavDocs_ItemDeleting(object sender, CancelEventArgs e)
        {
            e.Cancel = !AskCanDelete();
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

        private void DgvRows_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int id_nr = bsRows.Count;
            int id_trx = GetLastTrxId() + 1;
            e.Row.Cells[dgcRowsID1.Index].Value = id_nr;
            e.Row.Cells[dgcRowsID1STR.Index].Value = id_nr.ToString("TRX000");
            e.Row.Cells[dgcRowsID2.Index].Value = id_trx;
            string id_trx_s = "";
            try
            {
                id_trx_s = id_trx.ToString(MyData.Params.PmtTrxIdFmt);
            }
            catch (Exception)
            {
                MyMainForm.ShowWarning("Nekorekts transakcijas npk. formāts");
                id_trx_s = id_trx.ToString();
            }
            e.Row.Cells[dgcRowsID2STR.Index].Value = id_trx_s;
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value) return;
            var clid = e.Value as string;
            if (clid == null) return;
            var dr_person = MyData.DataSetKlonsF.Persons.FindByClId(clid);
            if (dr_person == null) return;
            if (e.ColumnIndex == dgcRowsCLIDFull.Index)
            {
                e.Value = dr_person?.Name ?? "";
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == dgcRowsCLIDRegNr.Index)
            {
                e.Value = dr_person?.RegNr ?? "";
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == dgcRowsCLIDAccount.Index)
            {
                e.Value = dr_person?.BankAcc ?? "";
                e.FormattingApplied = true;
            }
        }

        private void dgvRows_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgcRowsCLID.Index)
            {
                dgvRows.RefreshCurrent();
            }
        }

        public string ExportPMT(bool includeregnr)
        {
            if (!SaveData()) return "Neizdevās saglabāt datus";
            var dr_doc = bsDocs.CurrentDataRow as klonsDataSet.F_PMT_MSGRow;
            if (dr_doc == null) return "Maksājuma uzdevums nav atrasts.";
            var drs = dr_doc.GetF_PMT_TRFTRXRows()
                .OrderBy(x => x.ID1)
                .ThenBy(x => x.ID)
                .ToArray();
            if (drs.Length == 0)
            {
                return "Maksājuma uzdevums ir tukšs.";
            }
            for (int i = 0; i < drs.Length; i++)
            {
                drs[i].ID1 = i + 1;
                drs[i].ID1STR = (i + 1).ToString("TRX000");
            }
            dr_doc.DT = DateTime.Now;
            dr_doc.CT = drs.Length;
            dr_doc.AMOUNT = drs.Sum(x => x.AMOUNT);
            if (!SaveData()) return "Neizdevās saglabāt datus";
            var err = CheckData(dr_doc, includeregnr);
            if (err.HasErrors)
            {
                Form_ErrorList.ShowErrorList(MyMainForm, err);
                return "Failure";
            }

            var xdoc = MakeXML(dr_doc, false);
            if (xdoc == null) return "Failure";
            var fnm = KlonsLIB.Misc.Utils.DateToString(dr_doc.DT) + " " + dr_doc.MSGIDSTR;
            fnm = xdoc.SaveWithBrowse("PMTEXPORTFOLDER", fnm);
            if (fnm == null) return "Failure";

            if (MyData.Params.PmtLastMsgId < dr_doc.MSGID)
                MyData.Params.PmtLastMsgId = dr_doc.MSGID;
            if (MyData.Params.PmtLastTrxId < drs.Last().ID2)
                MyData.Params.PmtLastTrxId = drs.Last().ID2;
            MyData.Params.Save();

            return "Ok";
        }

        public ErrorList CheckData(klonsDataSet.F_PMT_MSGRow dr_doc, bool includeregnr)
        {
            var ret = new ErrorList();
            var drs = dr_doc.GetF_PMT_TRFTRXRows();
            if (drs.Length == 0)
            {
                ret.AddError("", "Maksājuma uzdevums ir tukšs.");
                return ret;
            }
            var table_persons = MyData.DataSetKlonsF.Persons;
            var plist = drs
                .Select(x => table_persons.FindByClId(x.CLID))
                .ToArray();
            for (int i = 0; i < drs.Length; i++)
            {
                var dr_trx = drs[i];
                var dr_person = plist[i];
                if (dr_person == null)
                {
                    ret.AddError(drs[i].CLID, "Persona nav atrasta.");
                    continue;
                }
                if (dr_trx.AMOUNT <= 0.0M)
                {
                    ret.AddError(dr_person.Name, "Nekorekta pārskaitjuma summa.");
                }
                if (dr_person.Name.IsNOE())
                {
                    ret.AddError(dr_person.ClId, "Personai nav norādīts nosaukums / vārts, uzvārds.");
                }
                if (dr_person.BankId.IsNOE())
                {
                    ret.AddError(dr_person.Name, "Personai nav norādīts bankas kods.");
                }
                if (dr_person.BankAcc.IsNOE())
                {
                    ret.AddError(dr_person.Name, "Personai nav norādīts bankas konts.");
                }
                if (includeregnr && dr_person.RegNr.IsNOE())
                {
                    ret.AddError(dr_person.Name, "Personai nav norādīts reģistrācjas numurs.");
                }
            }
            return ret;
        }

        public MyXmlDoc MakeXML(klonsDataSet.F_PMT_MSGRow dr_doc, bool includeregnr)
        {
            var xdoc = new MyXmlDoc();
            XmlElement Document = xdoc.CreateElement("Document");
            Document.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            Document.SetAttribute("xmlns", "urn:iso:std:iso:20022:tech:xsd:pain.001.001.09");
            xdoc.AppendChild(Document);
            var CstmrCdtTrfInitn = xdoc.XE(Document, "CstmrCdtTrfInitn");

            var GrpHdr = xdoc.XE(CstmrCdtTrfInitn, "GrpHdr");
            xdoc.XE(GrpHdr, "MsgId", dr_doc.MSGIDSTR);
            xdoc.XE(GrpHdr, "CreDtTm", dr_doc.DT, true);
            xdoc.XE(GrpHdr, "NbOfTxs", dr_doc.CT);
            xdoc.XE(GrpHdr, "CtrlSum", dr_doc.AMOUNT);
            var InitgPty = xdoc.XE(GrpHdr, "InitgPty");
            xdoc.XE(InitgPty, "Nm", MyData.Params.CompName);

            var PmtInf = xdoc.XE(CstmrCdtTrfInitn, "PmtInf");
            var pmtid = dr_doc.MSGID.ToString("PMT0000");
            xdoc.XE(PmtInf, "PmtInfId", pmtid);
            xdoc.XE(PmtInf, "PmtMtd", "TRF");
            xdoc.XE(PmtInf, "NbOfTxs", dr_doc.CT);
            xdoc.XE(PmtInf, "CtrlSum", dr_doc.AMOUNT);
            var PmtTpInf = xdoc.XE(PmtInf, "PmtTpInf");
            var SvcLvl = xdoc.XE(PmtTpInf, "SvcLvl");
            xdoc.XE(SvcLvl, "Cd", "SEPA");

            if (dr_doc.TP == 1)
            {
                var CtgyPurp = xdoc.XE(PmtTpInf, "CtgyPurp");
                xdoc.XE(CtgyPurp, "Cd", "SALA");
            }

            var ReqdExctnDt = xdoc.XE(PmtInf, "ReqdExctnDt");
            xdoc.XE(ReqdExctnDt, "Dt", dr_doc.DT, false);
            var Dbtr = xdoc.XE(PmtInf, "Dbtr");
            xdoc.XE(Dbtr, "Nm", MyData.Params.CompName);
            var DbtrAcct = xdoc.XE(PmtInf, "DbtrAcct");
            var Id = xdoc.XE(DbtrAcct, "Id");
            var dr_acc = MyData.DataSetKlonsF.F_PMT_ACCOUNTS.FindByID(dr_doc.ACCOUNT);
            var acc = dr_acc?.ACCOUNT;
            xdoc.XE(Id, "IBAN", acc);
            var DbtrAgt = xdoc.XE(PmtInf, "DbtrAgt");
            var FinInstnId = xdoc.XE(DbtrAgt, "FinInstnId");
            xdoc.XE(FinInstnId, "BICFI", dr_acc.BANK);

            var CdtTrfTxInf = xdoc.XE(CstmrCdtTrfInitn, "CdtTrfTxInf");
            var drs_trx = dr_doc.GetF_PMT_TRFTRXRows().OrderBy(x => x.ID1).ToArray();
            foreach(var dr_trx in drs_trx)
            {
                var PmtId = xdoc.XE(CdtTrfTxInf, "PmtId");
                xdoc.XE(PmtId, "InstrId", dr_trx.ID1STR);
                xdoc.XE(PmtId, "EndToEndId", dr_trx.ID2STR);
                var Amt = xdoc.XE(CdtTrfTxInf, "Amt");
                var InstdAmt = xdoc.XE(Amt, "InstdAmt", dr_trx.AMOUNT);
                var Ccy = xdoc.CreateAttribute("Ccy");
                Ccy.AppendChild(xdoc.CreateTextNode("EUR"));
                InstdAmt.Attributes.Append(Ccy);

                var Cdtr = xdoc.XE(CdtTrfTxInf, "Cdtr");
                var dr_person = MyData.DataSetKlonsF.Persons.FindByClId(dr_trx.CLID);
                xdoc.XE(Cdtr, "Nm", dr_person.Name);

                if (includeregnr)
                {
                    var Cdtr_Id = xdoc.XE(Cdtr, "Id");
                    var Cdtr_Id_OrgId = xdoc.XE(Cdtr_Id, "OrgId");
                    var Cdtr_Id_OrgId_Othr = xdoc.XE(Cdtr_Id_OrgId, "Othr");
                    xdoc.XE(Cdtr_Id_OrgId_Othr, "Id", dr_person.RegNr);
                    var Cdtr_Id_OrgId_Othr_SchmeNm = xdoc.XE(Cdtr_Id_OrgId_Othr, "SchmeNm");
                    var schmeNm = dr_person.TP2 == "JP" ? "COID" : "NIDN";
                    xdoc.XE(Cdtr_Id_OrgId_Othr_SchmeNm, "Cd", schmeNm);
                }

                var CdtrAcct = xdoc.XE(CdtTrfTxInf, "CdtrAcct");
                var CdtrAcctId = xdoc.XE(CdtrAcct, "Id");
                xdoc.XE(CdtrAcctId, "IBAN", dr_person.BankAcc);
                var RmtInf = xdoc.XE(CdtTrfTxInf, "RmtInf");
                xdoc.XENZ(RmtInf, "Ustrd", dr_trx.DETAILS);
            }

            return xdoc;
        }


        private void tsbExport_Click(object sender, EventArgs e)
        {
            var rt = ExportPMT(false);
            if (rt != "Ok" && rt != "Failure")
            {
                MyMainForm.ShowWarning(rt);
            }
        }

    }
}
