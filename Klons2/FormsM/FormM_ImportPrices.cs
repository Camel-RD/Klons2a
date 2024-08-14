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
using KlonsLIB.Misc;
using KlonsF.Classes;

namespace KlonsM.FormsM
{
    public partial class FormM_ImportPrices : MyFormBaseF
    {
        public enum EImportMode { Prices, DocRows}
        
        public FormM_ImportPrices(EImportMode mode = EImportMode.Prices)
        {
            InitializeComponent();
            CheckMyFontAndColors();

            miImport1.Visible = mode == EImportMode.Prices;
            miImportCheckNames.Visible = mode == EImportMode.Prices;
            miImport21.Visible = mode == EImportMode.DocRows;
            miImport22.Visible = mode == EImportMode.DocRows;
        }

        private void FormM_ImportPrices_Load(object sender, EventArgs e)
        {

        }

        public ErrorList ErrorList = new ErrorList();
        public List<ImportPricesRow> Result = null;

        public List<ImportPricesRow> DoImportA(string data, bool hasnames)
        {
            var ret = new List<ImportPricesRow>();
            ErrorList.Clear();

            int col_count = hasnames ? 3 : 2;
            var ss = data.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var ss2 = ss.Select(x => x.Split('\t').Select(y => y.Trim()).ToArray()).ToList();

            var ss_badcount = ss2.Where(x => x.Length != col_count).ToList();

            if (ss_badcount.Count > 0)
            {
                foreach (var s_bad in ss_badcount)
                {
                    var msg = "Nekorekta datu rinda: " + string.Join(" ", s_bad);
                    ErrorList.AddError("", msg);
                }
            }

            ss2 = ss2.Where(x => x.Length == col_count).ToList();
            var ss_badprice = ss2.Where(x => !decimal.TryParse(x[col_count - 1], out _)).ToList();

            if (ss_badprice.Count > 0)
            {
                foreach (var s_bad in ss_badprice)
                {
                    var msg = "Nekorekta cenas formāts: " + string.Join(" ", s_bad);
                    ErrorList.AddError("", msg);
                }
            }

            if (ss2.Count - ss_badprice.Count == 0) return ret;

            var rows = new ImportPricesRow();

            var dic_itemsbycode = MyData.DataSetKlonsM.M_ITEMS.ToDictionary(x => x.BARCODE, x => x);

            foreach (var s_row in ss2)
            {
                if (!decimal.TryParse(s_row[col_count - 1], out decimal price)) continue;
                var row = new ImportPricesRow()
                {
                    Code = s_row[0],
                    Price = price
                };

                row.ItemFound = dic_itemsbycode.TryGetValue(row.Code, out var dr_item);

                if (row.ItemFound)
                {
                    row.IdItem = dr_item.ID;
                    if (col_count == 3)
                    {
                        row.Name = s_row[1];
                        row.ItemNameMatch = row.Name == dr_item.NAME;
                        if (!row.ItemNameMatch)
                        {
                            var msg = "Artikula nosaukums atšķiras no uzskaitē esošā: " + string.Join(" ", s_row);
                            ErrorList.AddError("", msg);
                        }
                    }
                }
                else
                {
                    var msg = "Artikuls nav atrasts: " + string.Join(" ", s_row);
                    ErrorList.AddError("", msg);
                }
            }

            return ret;
        }

        public List<ImportPricesRow> DoImportB(string data, bool hasprices)
        {
            var ret = new List<ImportPricesRow>();
            ErrorList.Clear();

            int col_count = hasprices ? 3 : 2;
            var ss = data.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var ss2 = ss.Select(x => x.Split('\t').Select(y => y.Trim()).ToArray()).ToList();

            var ss_badcount = ss2.Where(x => x.Length != col_count).ToList();

            if (ss_badcount.Count > 0)
            {
                foreach (var s_bad in ss_badcount)
                {
                    var msg = "Nekorekta datu rinda: " + string.Join(" ", s_bad);
                    ErrorList.AddError("", msg);
                }
            }

            ss2 = ss2.Where(x => x.Length == col_count).ToList();
            var ss_badamount = ss2.Where(x => !decimal.TryParse(x[1], out _)).ToList();
            var ss_badprice = ss_badamount;
            if (hasprices)
            {
                ss_badprice = ss2.Where(x => !decimal.TryParse(x[2], out _)).ToList();
            }

            if (ss_badamount.Count > 0)
            {
                foreach (var s_bad in ss_badamount)
                {
                    var msg = "Nekorekts daudzuma formāts: " + string.Join(" ", s_bad);
                    ErrorList.AddError("", msg);
                }
            }

            if (hasprices && ss_badprice.Count > 0)
            {
                foreach (var s_bad in ss_badprice)
                {
                    var msg = "Nekorekts cenas formāts: " + string.Join(" ", s_bad);
                    ErrorList.AddError("", msg);
                }
            }

            if (ss2.Count - ss_badamount.Count - ss_badprice.Count == 0) return ret;

            var rows = new ImportPricesRow();

            var dic_itemsbycode = MyData.DataSetKlonsM.M_ITEMS.ToDictionary(x => x.BARCODE, x => x);

            foreach (var s_row in ss2)
            {
                if (!decimal.TryParse(s_row[1], out decimal amount)) continue;
                decimal price = 0.0M;
                if (hasprices && !decimal.TryParse(s_row[2], out price)) continue;
                
                var row = new ImportPricesRow()
                {
                    Code = s_row[0],
                    Amount = amount,
                    Price = price
                };

                row.ItemFound = dic_itemsbycode.TryGetValue(row.Code, out var dr_item);

                if (row.ItemFound)
                {
                    row.IdItem = dr_item.ID;
                    row.Name = dr_item.NAME;
                    row.ItemNameMatch = true;
                }
                else
                {
                    var msg = "Artikuls nav atrasts: " + string.Join(" ", s_row);
                    ErrorList.AddError("", msg);
                }
            }

            return ret;
        }

        public class ImportPricesRow
        {
            public int? IdItem = null;
            public string Code = null;
            public string Name = null;
            public decimal Amount = 0.0M;
            public decimal Price = 0.0M;
            public bool ItemFound = false;
            public bool ItemNameMatch = false;
        }


        private bool DoChecks()
        {
            if (tbData.Text.IsNOE())
            {
                MyMainForm.ShowWarning("Vispirms datu laukā ir jāiekopē tabulas dati.", owner: this);
                return false;
            }
            return true;
        }

        public bool DoImportA(bool hasnames)
        {
            if (!DoChecks()) return false;
            Result = DoImportA(tbData.Text, hasnames);
            if (ErrorList.HasErrors)
            {
                FormM_ErrorList.ShowErrorList(this, ErrorList);
                return false;
            }
            return true;
        }

        public bool DoImportB(bool hasprices)
        {
            if (!DoChecks()) return false;
            Result = DoImportB(tbData.Text, hasprices);
            if (ErrorList.HasErrors)
            {
                FormM_ErrorList.ShowErrorList(this, ErrorList);
                return false;
            }
            return true;
        }

        private void iekopētTekstuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = Clipboard.GetText();
            if (s.IsNOE()) return;
            tbData.Text = s;
        }

        private void miImport1_Click(object sender, EventArgs e)
        {
            if (!DoImportA(false)) return;
            DialogResult = DialogResult.OK;
        }

        private void miImportCheckNames_Click(object sender, EventArgs e)
        {
            if (!DoImportA(true)) return;
            DialogResult = DialogResult.OK;
        }

        private void miImport21_Click(object sender, EventArgs e)
        {
            if (!DoImportB(false)) return;
            DialogResult = DialogResult.OK;
        }

        private void miImport22_Click(object sender, EventArgs e)
        {
            if (!DoImportB(true)) return;
            DialogResult = DialogResult.OK;
        }

        private void miCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V ||
                e.Shift && e.KeyCode == Keys.Insert)
            {
                ((RichTextBox)sender).Paste(DataFormats.GetFormat("Text"));
                e.Handled = true;
            }
        }


    }
}
