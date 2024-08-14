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
using KlonsLIB.Components;

namespace KlonsM.FormsM
{
    public partial class FormM_DocSplitPVN : MyFormBaseF
    {
        public FormM_DocSplitPVN()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            cbDecimals.SelectedIndex = 0;
        }

        private void FormM_DocSplitPVN_Load(object sender, EventArgs e)
        {

        }

        public static void ShowRep(KlonsMDataSet.M_DOCSRow dr_doc)
        {
            var fm = new FormM_DocCosts();
            fm.GetData(dr_doc);
            fm.ShowDialog(fm.MyMainForm);
        }

        public BindingList<RowPVNSplit> RowsPVNSplit = new BindingList<RowPVNSplit>();
        public KlonsMDataSet.M_DOCSRow DrDoc = null;
        public int DecimalPlacesRounded = 2;

        public void GetData(KlonsMDataSet.M_DOCSRow dr_doc)
        {
            DrDoc = dr_doc;
            RowsPVNSplit.Clear();
            var drs_rows = dr_doc.GetM_ROWSRows()
                .Where(x => 
                    x.M_PVNRATESRow.ISREVERSE == 1 &&
                    x.M_PVNRATESRow.RATE > 0M)
                .ToList();
            if (drs_rows.Count == 0) return;

            var gdrs = drs_rows
                .GroupBy(x => x.M_PVNRATESRow.RATE);

            foreach (var gdr in gdrs)
            {
                var pvn_rate = gdr.Key;
                var rep_row = new RowPVNSplit();
                rep_row.TagPVNRate = pvn_rate.ToString();
                rep_row.PVNRate = pvn_rate;
                rep_row.PVNBase = gdr.Sum(x => x.TPRICE);
                rep_row.Rows = gdr.ToList();
                rep_row.PVNCalc = gdr.Sum(x => Math.Round(Math.Round(x.PRICE * pvn_rate / 100M, DecimalPlacesRounded) * x.AMOUNT, 2));
                rep_row.PVNInDoc = Math.Round(rep_row.PVNBase * pvn_rate / 100M, 2);
                rep_row.CalcError = rep_row.PVNInDoc - rep_row.PVNCalc;

                rep_row.PropertyChanged += Rep_row_PropertyChanged;

                RowsPVNSplit.Add(rep_row);
            }
            var rep_totalrow = new RowPVNSplit();
            rep_totalrow.TagPVNRate = "Kopā";
            rep_totalrow.PVNBase = RowsPVNSplit.Sum(x => x.PVNBase);
            rep_totalrow.PVNCalc = RowsPVNSplit.Sum(x => x.PVNCalc);
            rep_totalrow.PVNInDoc = RowsPVNSplit.Sum(x => x.PVNInDoc);
            rep_totalrow.CalcError = RowsPVNSplit.Sum(x => x.CalcError);

            RowsPVNSplit.Add(rep_totalrow);

            dgvRows.DataSource = RowsPVNSplit;
            dgvRows.Refresh();
        }

        public void RecalcData()
        {
            if (RowsPVNSplit.Count == 0) return;
            var rows_rep = RowsPVNSplit.Take(RowsPVNSplit.Count - 1).ToList();
            foreach (var row_rep in rows_rep)
            {
                var pvn_rate = row_rep.PVNRate;
                row_rep.PVNCalc = row_rep.Rows.Sum(x => Math.Round(Math.Round(x.PRICE * pvn_rate / 100M, DecimalPlacesRounded) * x.AMOUNT, 2));
                row_rep.CalcError = row_rep.PVNInDoc - row_rep.PVNCalc;
            }
            var totalrow = RowsPVNSplit[RowsPVNSplit.Count - 1];
            totalrow.PVNCalc = rows_rep.Sum(x => x.PVNCalc);
            totalrow.PVNInDoc = rows_rep.Sum(x => x.PVNInDoc);
            totalrow.CalcError = rows_rep.Sum(x => x.CalcError);

            dgvRows.Refresh();
        }

        private void Rep_row_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(RowPVNSplit.PVNInDoc))
            {
                var row = sender as RowPVNSplit;
                row.CalcError = row.PVNInDoc - row.PVNCalc;
                var row_total = RowsPVNSplit[RowsPVNSplit.Count - 1];
                row_total.PVNInDoc = RowsPVNSplit
                    .Take(RowsPVNSplit.Count - 1)
                    .Sum(x => x.PVNInDoc);
                row_total.CalcError = RowsPVNSplit
                    .Take(RowsPVNSplit.Count - 1)
                    .Sum(x => x.CalcError);
            }
        }

        public string DoIt()
        {
            if (RowsPVNSplit.Count == 0)
                return "Nav ko pārrēķināt.";
            if (tbCode.SelectedValue == null)
                return "Nav norādīts artikuls noapaļošanas kļūdas uzskaitei.";

            var row_total = RowsPVNSplit[RowsPVNSplit.Count - 1];
            var rep_rows = RowsPVNSplit.Take(RowsPVNSplit.Count - 1).ToList();

            foreach (var rep_row in rep_rows)
            {
                var pvn_rate = rep_row.PVNRate;
                foreach (var dr_row in rep_row.Rows)
                {
                    dr_row.PRICE0 = Math.Round(dr_row.PRICE0 * pvn_rate / 100M, DecimalPlacesRounded);
                    dr_row.PRICE = dr_row.PRICE0;
                    dr_row.TPRICE = Math.Round(dr_row.PRICE0 * dr_row.AMOUNT, 2);
                }
            }

            int iditem = (int)tbCode.SelectedValue;
            var dr_item = MyData.DataSetKlonsM.M_ITEMS.FindByID(iditem);

            if (!dr_item.XIsServices)
                return "Noapaļošanas kļūdas uzskaitei jāizmanto pakalpojuma artikuls.";

            var dr_err = DrDoc.GetM_ROWSRows()
                .Where(x => x.IDITEM == iditem)
                .FirstOrDefault();
            var table_rows = MyData.DataSetKlonsM.M_ROWS;

            if (dr_err == null)
            {
                dr_err = table_rows.NewM_ROWSRow();
                dr_err.IDDOC = DrDoc.ID;
                dr_err.M_DOCSRow = DrDoc;
                dr_err.IDITEM = iditem;
                dr_err.UNITS = dr_item.UNITS;
                dr_err.ACC6 = dr_item.M_ITEMS_CATRow.ACC6;
                dr_err.ACC7 = dr_item.M_ITEMS_CATRow.ACC7;
                table_rows.AddM_ROWSRow(dr_err);
            }

            dr_err.PRICE0 = row_total.CalcError;
            dr_err.PRICE = row_total.CalcError;
            dr_err.AMOUNT = 1M;
            dr_err.TPRICE = row_total.CalcError;

            return "OK";
        }

        private void dgvRows_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(e.RowIndex == RowsPVNSplit.Count - 1)
            {
                e.Cancel = true;
            }
        }

        private void btDoIt_Click(object sender, EventArgs e)
        {
            var rt = DoIt();
            if (rt != "OK")
            {
                MyMainForm.ShowWarning(rt, owner: this);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void cbDecimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsLoading) return;
            DecimalPlacesRounded = int.Parse(cbDecimals.Text);
            RecalcData();
        }


        public class RowPVNSplit : INotifyPropertyChanged
        {
            private decimal _PVNInDoc = 0M;
            private decimal _CalcError = 0M;
            public string TagPVNRate { get; set; }
            public decimal PVNRate { get; set; }
            public decimal PVNBase { get; set; }
            public decimal PVNCalc { get; set; }
            public decimal PVNInDoc 
            { 
                get => _PVNInDoc; 
                set
                {
                    _PVNInDoc = value;
                    OnPropertyChanged(nameof(PVNInDoc));
                }
            }
            public decimal CalcError 
            {
                get => _CalcError;
                set
                {
                    _CalcError = value;
                    OnPropertyChanged(nameof(_CalcError));
                }
            }

            public List<KlonsMDataSet.M_ROWSRow> Rows;

            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string propname)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
            }
        }

    }
}
