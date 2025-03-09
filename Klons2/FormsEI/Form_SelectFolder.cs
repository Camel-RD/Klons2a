using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Misc;

namespace KlonsM.FormsEI
{
    public partial class Form_SelectFolder : MyFormBaseF
    {
        public Form_SelectFolder()
        {
            SetupMenuRenderer();
            InitializeComponent();
            CheckMyFontAndColors();
        }

        public string SelectedFolder = null;
        public string CurrentFolder = null;

        private void Form_SelectFolder_Load(object sender, EventArgs e)
        {

        }

        public static string SelectFolder(string currentfolder, string[] foldernames, int count_selectedfiles)
        {
            var frm = new Form_SelectFolder();
            frm.CurrentFolder = currentfolder;
            frm.cbInvoiceFolder.Items.AddRange(foldernames);
            frm.label2.Text = $"Norādi mapi uz kuru pārvietot {count_selectedfiles} failus no mapes [{currentfolder}]";
            var rt = frm.ShowDialog();
            if (rt != DialogResult.OK) return null;
            return frm.SelectedFolder;
        }

        private void cmOk_Click(object sender, EventArgs e)
        {
            if (cbInvoiceFolder.SelectedIndex == -1)
            {
                MyData.MyMainForm.ShowWarning("Nav norādīta mape.",owner: this);
                return;
            }
            if (cbInvoiceFolder.Text == CurrentFolder)
            {
                MyData.MyMainForm.ShowWarning("Jāizvēlas mapi, kas atšķiras no pašreizējās.", owner: this);
                return;
            }
            SelectedFolder = cbInvoiceFolder.Text;
            DialogResult = DialogResult.OK;
        }

        private void cmCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
