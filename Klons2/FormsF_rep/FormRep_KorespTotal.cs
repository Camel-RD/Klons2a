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
using KlonsF.FormsReportParams;

namespace KlonsF.FormsF_rep
{
    public partial class FormRep_KorespTotal : MyFormBaseF
    {
        public FormRep_KorespTotal()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BoldCellFont = new Font(dgvRows.Font, FontStyle.Bold);
        }

        Font BoldCellFont;

        private void FormRep_KorespTotal_Load(object sender, EventArgs e)
        {

        }

        public void SetRowSource(List<RepRowKorespTotals> reprows)
        {
            dgvRows.DataSource = reprows;
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRowKorespTotals;
            if (reprow.Kind == 1)
            {
                e.CellStyle.Font = BoldCellFont;
            }
            if (reprow.Kind == 2)
            {
                e.CellStyle.Font = BoldCellFont;
            }
        }
    }

    public class RepRowKorespTotals
    {
        public string Acc { get; set; }
        public string Descr { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int Kind { get; set; }
    }
}
