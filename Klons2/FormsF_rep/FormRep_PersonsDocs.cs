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

namespace KlonsF.FormsReportParams
{
    public partial class FormRep_PersonsDocs : MyFormBaseF
    {
        public FormRep_PersonsDocs()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BoldCellFont = new Font(dgvRows.Font, FontStyle.Bold);
        }

        Font BoldCellFont;

        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value;
        }

        public void SetRowSource(List<RepRowPersonsDocs> reprows, bool showdiff)
        {
            dgcDiff.Visible = showdiff;
            dgvRows.DataSource = reprows;
            dgvRows.AutoResizeRows();
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRowPersonsDocs;
            if (reprow.Kind == 1)
            {
                e.CellStyle.Font = BoldCellFont;
            }
            if (reprow.Kind == 2)
            {
                e.CellStyle.Font = BoldCellFont;
            }
            if (reprow.Kind == 2 && e.ColumnIndex >= dgcDate.Index && e.ColumnIndex <= dgcDocNr.Index ||
                reprow.Kind == 3 ||
                reprow.Kind == 0 && !reprow.IsFirstInGroup && e.ColumnIndex <= dgcName.Index)
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
    }

    public class RepRowPersonsDocs
    {
        public int Kind = 0;
        public bool IsFirstInGroup = false;
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Dt { get; set; }
        public string DocType { get; set; }
        public string DocSr { get; set; }
        public string DocNr { get; set; }
        public decimal Deb { get; set; } = 0.0M;
        public decimal Cred { get; set; } = 0.0M;
        public decimal Diff => Deb - Cred;

        public static RepRowPersonsDocs MakeFrom(DataSets.klonsRepDataSet.TRepA1Row dr, int kind)
        {
            var ret = new RepRowPersonsDocs()
            {
                Code = dr.i1,
                Name = dr.nm,
                Dt = dr.dt,
                DocSr = dr.st,
                DocNr = dr.nr,
                Deb = dr.s1,
                Cred = dr.s2
            };
            return ret;
        }
    }
}
