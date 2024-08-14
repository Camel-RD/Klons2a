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
using KlonsF.Forms;

namespace KlonsF.Forms
{
    public partial class Form_CompanyData : MyFormBaseF
    {
        public Form_CompanyData()
        {
            InitializeComponent();
            CheckMyFontAndColors();

            companyData1.LoadData();

            myGrid1.MakeGrid();
            myGrid1.LinkGrid();

        }

        private void FormCompanyData_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void FormCompanyData_FormClosing(object sender, FormClosingEventArgs e)
        {
            companyData1.SaveData();
            MyData.UpdateTable(MyData.DataSetKlonsF.Params);
        }
    }
}
