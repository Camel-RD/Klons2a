using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Misc;


namespace KlonsF.Forms
{
    public partial class FormRep_Bilance1 : MyFormBaseF
    {
        public FormRep_Bilance1()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BoldCellFont = new Font(dgvRows.Font, FontStyle.Bold);
        }

        Font BoldCellFont;

        private void FormRep_Bilance1_Load(object sender, EventArgs e)
        {

        }

        public void SetRowSource(List<RepRowBilance1> reprows, string colname1, string colname2)
        {
            dgcS1.HeaderText = colname1;
            dgcS3.HeaderText = colname2;
            dgvRows.DataSource = reprows;
            dgvRows.AutoResizeRows();
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRowBilance1;
            if ((reprow.Kind == 1 || reprow.Tp == "V") && e.ColumnIndex >= dgcS1.Index)
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
            if (reprow.Kind == 1 || reprow.Tp == "V" || reprow.Tp == "K")
            {
                e.CellStyle.Font = BoldCellFont;
            }
        }
    }

    public class RepRowBilance1
    {
        public int Kind { get; set; } = 0;
        public string Dc { get; set; }
        public string Tp { get; set; }
        public string Descr { get; set; }
        public string Nr { get; set; }
        public decimal S1 { get; set; } = 0.0M;
        public decimal S2 { get; set; } = 0.0M;
        public decimal S3 { get; set; } = 0.0M;

        public static RepRowBilance1 MakeFrom(DataSets.klonsDataSet.BalA22Row row, int kind)
        {
            var ret = new RepRowBilance1()
            {
                Kind = kind,
                Dc = row.dc,
                Tp = row.tp,
                Descr = row.Descr,
                Nr = row.nr,
                S1 = row.S1,
                S2 = row.S2,
                S3 = row.S1 + row.S2
            };
            return ret;
        }
    }
}
