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
    public partial class FormRep_Bilance2 : MyFormBaseF
    {
        public FormRep_Bilance2()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BoldCellFont = new Font(dgvRows.Font, FontStyle.Bold);
        }

        Font BoldCellFont;

        private void FormRep_Bilance2_Load(object sender, EventArgs e)
        {

        }

        public void SetRowSource(List<RepRow_BalMT> reprows)
        {
            dgvRows.DataSource = reprows;
            dgvRows.AutoResizeRows();
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRow_BalMT;
            if ((reprow.Tp == "X" || reprow.Tp == "V") && e.ColumnIndex >= dgcS1.Index)
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
            if (reprow.Tp == "X" || reprow.Tp == "V" || reprow.Tp == "K")
            {
                e.CellStyle.Font = BoldCellFont;
            }
        }
    }
}
