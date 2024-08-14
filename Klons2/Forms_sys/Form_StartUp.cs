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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static KlonsF.Forms.Form_FbUsers;

namespace KlonsF.Forms
{
    public partial class Form_StartUp : MyFormBaseF
    {
        public Form_StartUp()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }

        private void FormStartUp_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            lbNane.Text = MyData.Settings.MasterEntry.Name;
            lbDescr.Text = MyData.Settings.MasterEntry.Descr;
            lbFile.Text = MyData.Settings.MasterEntry.FileName;
            tbUser.Text = MyData.Settings.LastUserName;
        }

        private void cmExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
        private bool CheckUserInput()
        {
            if (MyData.Settings.MasterEntry.Name == "")
            {
                MyMainForm.ShowWarning("Jāizvēlas pieslēdzamā datubāze!", "");
                return false;
            }
            if (tbUser.Text == "")
            {
                MyMainForm.ShowWarning("Jāievada lietotāja vārds!", "");
                return false;
            }
            return true;
        }

        private bool IsBackupDone = false;
        private bool CheckUserAndConnect()
        {
            IsBackupDone = false;
            if (MyData.CurrentDBTag == null || 
                !MyData.CurrentDBTag.Equals(MyData.Settings.MasterEntry))
            {
                string usertp = null, dbver = null;
                if (CheckUser2(out usertp, out dbver))
                {
                    if (!usertp.IsNOE() && !dbver.IsNOE())
                    {
                        if (UpgradeExpected(dbver))
                        {
                            var dbfilename = MyData.GetFileName(MyData.Settings.MasterEntry);
                            IsBackupDone = DoBackUpIfNeeded(dbfilename, true);
                        }
                    }
                }
                else
                {
                    if (usertp == "X") return false;
                }
                
                GC.Collect();

                if (!ConnectTo(MyData.Settings.MasterEntry, tbUser.Text, tbPSW.Text))
                {
                    return false;
                }
                MyData.SetUpTableManagerForUsersTable();
            }

            if (!MyData.TestUserPassword(tbUser.Text, tbPSW.Text))
            {
                MyMainForm.ShowWarning("Nepareizs lietotāja vārds vai parole", "");
                return false;
            }
            return true;
        }

        private bool CheckUser2(out string usertp, out string dbver)
        {
            usertp = null;
            dbver = null;
            try
            {
                MyData.GectSomeDbSysData(MyData.Settings.MasterEntry, tbUser.Text, tbPSW.Text,
                    out usertp, out dbver);
            }
            catch(Exception ex) 
            { 
                return false; 
            }

            if (usertp == "X")
            {
                MyMainForm.ShowWarning("Nepareizs lietotāja vārds vai parole", "");
                return false;
            }
            return true;
        }

        private bool ConnectTo(MasterEntry me, string username, string userpsw, bool secondtry = false)
        {
            var dbfilename = MyData.GetFileName(me);
            if (!IsBackupDone)
                IsBackupDone = DoBackUpIfNeeded(dbfilename, false);
            return MyData.ConnectTo(me, username, userpsw);
        }

        private bool DoBackUpIfNeeded(string dbfilename, bool beforeupgrade)
        {
            if (dbfilename.IsNOE()) return false;
            var bp = MyData.Settings.BackUpPlanX;
            if (bp == EBackUpPlan.Never) return false;
            var dt = BackupHelper.GetLastBackupDate(dbfilename, MyData.GetBackUpFolder());
            if (!beforeupgrade && 
                dt.HasValue && (DateTime.Now >= dt.Value) &&
                (DateTime.Now - dt.Value).TotalSeconds < 30d)
                return false;
            if (!beforeupgrade &&
                bp == EBackUpPlan.Daily &&
                dt.HasValue &&
                dt.Value.Date == DateTime.Today)
                return false;
            if (bp == EBackUpPlan.WhenUpgrading && !beforeupgrade)
                return false;
            return BackupHelper.BackupDbFile(dbfilename, MyData.GetBackUpFolder());
        }

        private bool UpgradeExpected(string dbver)
        {
            if (!UpgradeHelper.CanUseVeriom(dbver, MyData.Version)) return false;
            return UpgradeHelper.HasUpgrade(dbver, MyData.Version);
        }

        private bool CheckForUpgrades(string dbver, bool skipbackup)
        {
            if (!UpgradeHelper.CanUseVeriom(dbver, MyData.Version))
            {
                MyMainForm.ShowError("Programmas versija nav savietojama ar datu bāzes versiju.");
                return false;
            }

            if (!UpgradeHelper.HasUpgrade(dbver, MyData.Version)) return true;

            var ret = MyMessageBox.Show(
                "Nepieciešams veikt datu bāzes versijas aktualizāciju.\n" +
                "Pirms to darīt, ieteicams aizvērt programmu un\n" +
                "izveidot datu rezerves kopiju.\n\n" +
                "Vai sākt datu bāzes aktualizāciju?"
                , "Jauna versija!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MyMainForm);

            if (ret != DialogResult.Yes) return false;

            var dbfilename = MyData.GetFileName(MyData.CurrentDBTag);
            if (!skipbackup)
                DoBackUpIfNeeded(dbfilename, true);

            if (!UpgradeHelper.UpgradeThis(dbver, MyData.Version))
            {
                return false;
                //DialogResult = DialogResult.Abort;
            }
            
            return true;
        }

        private void DoConnect()
        {
            try
            {
                if (!CheckUserInput()) return;
                if (!CheckUserAndConnect()) return;
                MyData.SetCurrentUserName(tbUser.Text);
                MyData.SetUpTableManager();
                MyData.FillParamsForUser(tbUser.Text);
                var dbver = MyData.Params.Version;
                if (!CheckForUpgrades(dbver, IsBackupDone)) return;
                MyData.FillBaseTables();
                MyData.Settings.LastUserName = tbUser.Text;
                MyMainForm.Text = "Klons2: " + MyData.Settings.MasterEntry.Descr.Nz();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MyException e1 = new MyException("Neizdevās pieslēgt datubāzi.", ex);
                Form_Error.ShowException(this, e1);
                DialogResult = DialogResult.Abort;
            }
        }

        public void DoEditUsers()
        {
            try
            {
                if (!CheckUserAndConnect()) return;
                string tp = MyData.GetUserGroup(tbUser.Text);
                if (string.IsNullOrEmpty(tp)) return;
                if (tp == "A")
                {
                    MyMainForm.ShowFormUsersDialog();
                }
                else if (tp == "B")
                {
                    Form_UserPSW f1 = new Form_UserPSW();
                    f1.SelectedValue = tbPSW.Text;
                    if (f1.ShowDialog(this) == DialogResult.OK)
                    {
                        MyData.ChangeUserPassword(tbUser.Text, f1.SelectedValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MyException e1 = new MyException("Neizdevās pieslēgt datubāzi.", ex);
                Form_Error.ShowException(this, e1);
                return;
            }
        }

        private void cmConnect_Click(object sender, EventArgs e)
        {
            DoConnect();
        }

        private void cmChange_Click(object sender, EventArgs e)
        {
            Form_Files ff = new Form_Files();
            if (ff.ShowDialog() != DialogResult.OK) return;
            ShowData();
        }

        private void cmUsers_Click(object sender, EventArgs e)
        {
            DoEditUsers();
        }

        private void cmFbAdmin_Click(object sender, EventArgs e)
        {
            var fm = new Form_FbUsers();
            fm.ShowDialog(this);
        }
    }
}
