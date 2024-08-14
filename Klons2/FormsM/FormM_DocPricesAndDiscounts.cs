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
    public partial class FormM_DocPricesAndDiscounts : MyFormBaseF
    {
        public FormM_DocPricesAndDiscounts()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;

            HeaderCellStyle = dgvRows.DefaultCellStyle.Clone();
            HeaderCellStyle.Font = new Font(HeaderCellStyle.Font, HeaderCellStyle.Font.Style | FontStyle.Bold);
        }

        private void FormM_DocPricesAndDiscounts_Load(object sender, EventArgs e)
        {
            GetData(DrDoc);
        }

        private void FormM_DocPricesAndDiscounts_Shown(object sender, EventArgs e)
        {
            if (ErrorList.HasErrors)
            {
                FormM_ErrorList.ShowErrorList(this, ErrorList);
                return;
            }
        }

        public static void ApplyPricesAndDiscounts(KlonsMDataSet.M_DOCSRow dr_doc)
        {
            var fm = new FormM_DocPricesAndDiscounts();
            fm.DrDoc = dr_doc;
            fm.ShowDialog();
        }

        public KlonsMDataSet.M_DOCSRow DrDoc = null;

        public BindingList<AppliedListsRow> ListsAll = new BindingList<AppliedListsRow>();
        public List<AppliedListsRow> ListsPrices = new List<AppliedListsRow>();
        public List<AppliedListsRow> ListsDiscounts = new List<AppliedListsRow>();
        public ErrorList ErrorList = new ErrorList();

        public DataGridViewCellStyle HeaderCellStyle = null;

        public void GetData(KlonsMDataSet.M_DOCSRow dr_doc)
        {
            DrDoc = dr_doc;
            ListsAll = new BindingList<AppliedListsRow>();
            ListsPrices = new List<AppliedListsRow>();
            ListsDiscounts = new List<AppliedListsRow>();
            ErrorList = new ErrorList();

            var table_disclists = MyData.DataSetKlonsM.M_DISC_LISTS;
            var table_pricelists = MyData.DataSetKlonsM.M_PRICE_LISTS;
            var table_storescat = MyData.DataSetKlonsM.M_STORES_CAT;
            var table_itemscat = MyData.DataSetKlonsM.M_ITEMS_CAT;
            var drs_rows = DrDoc.GetM_ROWSRows().ToList();
            int id_store = DrDoc.IDSTOREIN;
            string code_storecat = DrDoc.M_STORESRowByFK_M_DOCS_IDSTOREIN1.M_STORES_CATRow.CODE;

            bool StoreCatStartsWith(int id_storecat)
            {
                var code = table_storescat.FindByID(id_storecat)?.CODE;
                if (code.IsNOE()) return false;
                return code_storecat.StartsWith(code, StringComparison.CurrentCulture);
            }

            List<KlonsMDataSet.M_ROWSRow> MatchingDiscountList(KlonsMDataSet.M_DISC_LISTS_RRow dr_disc_r)
            {
                var ret = new List<KlonsMDataSet.M_ROWSRow>();
                string disccatcode = null;
                if (!dr_disc_r.IsIDITEMSCATNull())
                    disccatcode = table_itemscat.FindByID(dr_disc_r.IDITEMSCAT).CODE;
                if (!dr_disc_r.IsIDITEMNull())
                {
                    var drs1 = drs_rows
                        .Where(x => x.IDITEM == dr_disc_r.IDITEM);
                    ret.AddRange(drs1);
                }
                if (!disccatcode.IsNOE())
                {
                    var drs1 = drs_rows
                        .Where(x =>
                        !x.M_ITEMSRow.M_ITEMS_CATRow.CODE.IsNOE() &&
                        x.M_ITEMSRow.M_ITEMS_CATRow.CODE.StartsWith(disccatcode));
                    ret.AddRange(drs1);
                }
                ret = ret.Distinct().ToList();
                return ret;
            }

            var drs_check_discount_lists = table_disclists
                .SelectMany(x => x.GetM_DISC_LISTS_PRows())
                .Where(x =>
                    !x.IsIDSTORENull() && x.IDSTORE == id_store ||
                    !x.IsIDSTORESCATNull() && StoreCatStartsWith(x.IDSTORESCAT))
                .Select(x => x.M_DISC_LISTSRow)
                .Distinct()
                .ToList();

            var drs_check_price_lists = table_pricelists
                .SelectMany(x => x.GetM_PRICE_LISTS_PRows())
                .Where(x =>
                    !x.IsIDSTORENull() && x.IDSTORE == id_store ||
                    !x.IsIDSTORESCATNull() && StoreCatStartsWith(x.IDSTORESCAT))
                .Select(x => x.M_PRICE_LISTSRow)
                .Distinct()
                .ToList();

            var drs_applicable_disccount_rows = drs_check_discount_lists
                .SelectMany(x => x.GetM_DISC_LISTS_RRows())
                .Select(x => (dr_disc_r: x, drs_rows: MatchingDiscountList(x)))
                .Where(x => x.drs_rows.Count > 0)
                .ToList();

            var drs_applicable_price_rows = drs_check_price_lists
                .SelectMany(x => x.GetM_PRICE_LISTS_RRows())
                .Select(x => (dr_price_r: x, drs_rows: drs_rows.Where(y => y.IDITEM == x.IDITEM).ToList()))
                .Where(x => x.drs_rows.Count > 0)
                .ToList();

            var drs_with_multiple_discounts = drs_applicable_disccount_rows
                .SelectMany(x => x.drs_rows.Select(y => (x, y)))
                .GroupBy(x => x.y)
                .Where(x => x.Count() > 1)
                .ToList();

            var drs_with_multiple_prices = drs_applicable_price_rows
                .SelectMany(x => x.drs_rows.Select(y => (x, y)))
                .GroupBy(x => x.y)
                .Where(x => x.Count() > 1)
                .ToList();


            foreach (var dr in drs_applicable_disccount_rows)
            {
                var list_row = new AppliedListsRow()
                {
                    Type = EAppliedListsRowType.DiscountList,
                    ListName = dr.dr_disc_r.M_DISC_LISTSRow.NAME,
                    Rows = dr.drs_rows,
                    IdList = dr.dr_disc_r.IDL,
                    RowDiscount = dr.dr_disc_r
                };
                ListsDiscounts.Add(list_row);
            }

            foreach (var dr in drs_applicable_price_rows)
            {
                var list_row = new AppliedListsRow()
                {
                    Type = EAppliedListsRowType.PriceList,
                    ListName = dr.dr_price_r.M_PRICE_LISTSRow.NAME,
                    Rows = dr.drs_rows,
                    IdList = dr.dr_price_r.IDL,
                    RowPrice = dr.dr_price_r
                };
                ListsPrices.Add(list_row);
            }

            if (ListsPrices.Count > 0)
            {
                var list_row_h = new AppliedListsRow()
                {
                    Type = EAppliedListsRowType.PriceListHeader,
                    ListName = "Cenu lapas"
                };
                ListsAll.Add(list_row_h);
                ListsPrices.ForEach(x => ListsAll.Add(x));
            }

            if (ListsDiscounts.Count > 0)
            {
                var list_row_h = new AppliedListsRow()
                {
                    Type = EAppliedListsRowType.DiscountListHeader,
                    ListName = "Atlaižu lapas"
                };
                ListsAll.Add(list_row_h);
                ListsDiscounts.ForEach(x => ListsAll.Add(x));
            }

            drs_with_multiple_prices
                .Select(x => (x.Key.M_ITEMSRow.BARCODE, string.Join(", ", x)))
                .ForEach(x => ErrorList.AddError(x.BARCODE, "Artikuls ir vairākās cenu lapās: " + x.Item2));

            drs_with_multiple_discounts
                .Select(x => (x.Key.M_ITEMSRow.BARCODE, string.Join(", ", x)))
                .ForEach(x => ErrorList.AddError(x.BARCODE, "Artikuls ir vairākās atlaižu lapās: " + x.Item2));

            dgvRows.DataSource = ListsAll;
        }

        public void OnHeaderClick(AppliedListsRow row)
        {
            var tp = EAppliedListsRowType.None;
            if (row.Type == EAppliedListsRowType.DiscountListHeader)
                tp = EAppliedListsRowType.DiscountList;
            else if (row.Type == EAppliedListsRowType.PriceListHeader)
                tp = EAppliedListsRowType.PriceList;
            if (tp == EAppliedListsRowType.None) return;
            foreach (var list in ListsAll)
            {
                if (list.Type == tp)
                    list.IsUsed = row.IsUsed;
            }
        }

        public void ApplyPriceLists()
        {
            var lists_prices = ListsPrices.Where(x => x.IsUsed).ToList();
            if (lists_prices.Count == 0) return;
            var row_x_price = lists_prices
                .SelectMany(x => x.Rows.Select(y => (x.RowPrice, y)))
                .GroupBy(x => x.y)
                .Select(x => (dr_docrow: x.Key, x.WithMinOrDefault(y => y.RowPrice.PRICE).RowPrice))
                .ToList();
            foreach (var row in row_x_price)
            {
                row.dr_docrow.PRICE0 = row.RowPrice.PRICE;
            }
        }

        public void ApplyDiscountLists()
        {
            var lists_discounts = ListsDiscounts.Where(x => x.IsUsed).ToList();
            if (lists_discounts.Count == 0) return;
            var row_x_discount = lists_discounts
                .SelectMany(x => x.Rows.Select(y => (x.RowDiscount, y)))
                .GroupBy(x => x.y)
                .Select(x => (dr_docrow: x.Key, x.WithMaxOrDefault(y => y.RowDiscount.DISCOUNT).RowDiscount))
                .ToList();
            foreach (var row in row_x_discount)
            {
                row.dr_docrow.DISCOUNT = row.RowDiscount.DISCOUNT;
            }
        }

        public void CheckLists()
        {
            ErrorList.Clear();

            var lists_prices = ListsPrices.Where(x => x.IsUsed).ToList();
            var lists_discounts = ListsDiscounts.Where(x => x.IsUsed).ToList();
            if (lists_prices.Count == 0 && lists_discounts.Count == 0) return;

            var row_x_price = lists_prices
                .SelectMany(x => x.Rows.Select(y => (x.RowPrice, y)))
                .GroupBy(x => x.y);

            var row_x_discount = lists_discounts
                .SelectMany(x => x.Rows.Select(y => (x.RowDiscount, y)))
                .GroupBy(x => x.y);

            foreach (var gr in row_x_price)
            {
                var msg = string.Join(", ", gr.Select(x => x.RowPrice.M_PRICE_LISTSRow.NAME));
                msg = "Artikuls ir vairākās cenu lapās: " + msg;
                var code = gr.Key.M_ITEMSRow.BARCODE;
                ErrorList.AddError(code, msg);
            }

            foreach (var gr in row_x_discount)
            {
                var msg = string.Join(", ", gr.Select(x => x.RowDiscount.M_DISC_LISTSRow.NAME));
                msg = "Artikuls ir vairākās atlaižu lapās: " + msg;
                var code = gr.Key.M_ITEMSRow.BARCODE;
                ErrorList.AddError(code, msg);
            }
        }

        public enum EAppliedListsRowType { None, PriceList, DiscountList, PriceListHeader, DiscountListHeader }
        public class AppliedListsRow : INotifyPropertyChanged
        {
            private bool _IsUsed = true;
            public FormM_DocPricesAndDiscounts Form = null;
            public EAppliedListsRowType Type { get; set; } = EAppliedListsRowType.None;

            public int IdList = 0;
            public KlonsMDataSet.M_PRICE_LISTS_RRow RowPrice = null;
            public KlonsMDataSet.M_DISC_LISTS_RRow RowDiscount = null;
            public string ListName { get; set; }
            public bool IsUsed
            {
                get => _IsUsed;
                set
                {
                    _IsUsed = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsUsed)));
                    if (Type == EAppliedListsRowType.DiscountListHeader ||
                        Type == EAppliedListsRowType.PriceListHeader)
                    {
                        if (Form != null) Form.OnHeaderClick(this);
                    }
                }
            }

            public List<KlonsMDataSet.M_ROWSRow> Rows = null;

            public event PropertyChangedEventHandler PropertyChanged;

        }

        private void btApply_Click(object sender, EventArgs e)
        {
            ApplyPriceLists();
            ApplyDiscountLists();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            CheckLists();
            if (!ErrorList.HasErrors)
            {
                MyMainForm.ShowInfo("Neviens artikuls neatrodas vairākās cenu un atlaižu lapās.", "");
                return;
            }
            FormM_ErrorList.ShowErrorList(this, ErrorList);
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            var row = dgvRows.Rows[e.RowIndex].DataBoundItem as AppliedListsRow;
            if (row.Type == EAppliedListsRowType.DiscountListHeader ||
                row.Type == EAppliedListsRowType.PriceListHeader)
            {
                e.CellStyle = HeaderCellStyle;
                e.FormattingApplied = true;
            }
        }

    }

}
