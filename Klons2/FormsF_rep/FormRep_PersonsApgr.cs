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
    public partial class FormRep_PersonsApgr : MyFormBaseF
    {
        public FormRep_PersonsApgr()
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

        public void SetRowSource(List<RepRowPersonsApgr> reprows)
        {
            dgvRows.DataSource = reprows;
            dgvRows.AutoResizeRows();
        }

        private void dgvRows_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == -1) return;
            var reprow = dgvRows.Rows[e.RowIndex].DataBoundItem as RepRowPersonsApgr;
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


    public class RepRowPersonsApgr
    {
        public int Kind = 0;
        public string Ac { get; set; }
        public string AcName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Deb0 { get; set; } = 0.0M;
        public decimal Cred0 { get; set; } = 0.0M;
        public decimal DebCh { get; set; } = 0.0M;
        public decimal CredCh { get; set; } = 0.0M;
        public decimal Deb1 { get; set; } = 0.0M;
        public decimal Cred1 { get; set; } = 0.0M;

        public static RepRowPersonsApgr MakeFrom(DataSets.klonsRepDataSet.ROps2aRow dr, int kind)
        {
            var ret = new RepRowPersonsApgr()
            {
                Ac = dr.Ac,
                AcName = dr.Name,
                Code = dr.ClId,
                Name = dr.Name1,
                Deb0 = dr.ADb,
                Cred0 = dr.ACr,
                DebCh = dr.TDb,
                CredCh = dr.TCr,
                Deb1 = dr.BDb,
                Cred1 = dr.BCr
            };
            return ret;
        }
    }

}
