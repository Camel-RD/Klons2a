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

namespace KlonsM.FormsEI
{
    public partial class Form_SetEmailPassword : MyFormBaseF
    {
        public Form_SetEmailPassword()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        public string RealPassword;
        public string WeakPassword;

        private void FormSetEmailPassword_Load(object sender, EventArgs e)
        {
        }

        private void cmOk_Click(object sender, EventArgs e)
        {
            var psw_real = tbRealPassword.Text;
            var psw_weak = tbWeakPassword.Text;
            if (psw_real.IsNOE() || psw_weak.IsNOE())
            {
                MyMessageBox.Show("Paroles nav norādītas.", icon: MessageBoxIcon.Warning);
                return;
            }
            RealPassword = psw_real;
            WeakPassword = psw_weak;
            DialogResult = DialogResult.OK;
        }
    }
}
