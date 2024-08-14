using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KlonsA.Classes;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using NPOI.SS.Formula.Functions;

namespace KlonsA.Forms
{
    public partial class FormARep_ActivePersons : MyFormBaseF
    {
        public FormARep_ActivePersons()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            tbDate1.Text = Utils.DateToString(DateTime.Today);
            tbDate2.Text = tbDate1.Text;
            dgvRows.AutoGenerateColumns = false;
        }

        private void FormARep_ActivePersons_Load(object sender, EventArgs e)
        {

        }

        DateTime Date1 = DateTime.Today;
        DateTime Date2 = DateTime.Today;

        public List<RepRowActivePerons> RepRows = new List<RepRowActivePerons>();

        string CheckParams()
        {
            if (string.IsNullOrEmpty(tbDate1.Text) || string.IsNullOrEmpty(tbDate2.Text))
                return "Nav norādīti datumi.";
            if (!Utils.StringToDate(tbDate1.Text, out Date1) || !Utils.StringToDate(tbDate2.Text, out Date2) ||
                Date1 > Date2)
                return "Ievadīti nekorekti datumi.";

            return "Ok";
        }

        private void cmTable_Click(object sender, EventArgs e)
        {
            var rt = CheckParams();
            if (rt != "Ok")
            {
                MyMainForm.ShowWarning(rt);
                return;
            }
            var rep = new Report_ActivePersons();
            var er = rep.MakeReport(Date1, Date2);
            RepRows = rep.RepRows
                .OrderBy(x => x.Name)
                .ToList();
            bsRows.DataSource = RepRows;
        }

    }
}
