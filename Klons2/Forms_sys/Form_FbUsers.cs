using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.DataSets;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Data;
using KlonsLIB.Misc;
using KlonsLIB.Components;
using FirebirdSql.Data.Services;
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;

namespace KlonsF.Forms
{
    public partial class Form_FbUsers : MyFormBaseF
    {
        public Form_FbUsers()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            dgvUserRoles.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            tbAdminName.Text = "SYSDBA";
            tbAdminPassword.Text = "parole";
            cbRole.SelectedIndex = 0;
        }

        private void Form_FbUsers_Load(object sender, EventArgs e)
        {

        }

        private bool IsConnected = false;
        private string AdminName = null;
        private string AdminPsw = null;
        private FbConnection Connection = null;
        private BindingList<DbUser> FbUsers = new BindingList<DbUser>();
        private BindingList<UserRole> FbUserRoles = new BindingList<UserRole>();
        private BindingList<DbRole> FbRoles = new BindingList<DbRole>();

        public bool Connect()
        {
            if(Connection != null)
            {
                Connection.Close();
                Connection.Dispose();
                Connection = null;
                IsConnected = false;
                FbUserRoles.Clear();
                FbUsers.Clear();
            }
            AdminName = tbAdminName.Text;
            AdminPsw = tbAdminPassword.Text;
            if(AdminName.IsNOE() || AdminPsw.IsNOE())
            {
                MyMainForm.ShowWarning("Jānorāda lietotāja vārds un parole.");
                return false;
            }
            var me = MyData.Settings.MasterEntry;
            string newconnstr = MyData.MasterList.GetTemplateByName(me.ConnStr);
            if (string.IsNullOrEmpty(newconnstr))
            {
                MyMainForm.ShowWarning($"Nav pieslēguma definīcijas [{me.ConnStr}]");
                return false;
            }
            string filename = MyData.GetFileName(me);
            newconnstr = string.Format(newconnstr, filename, AdminName, AdminPsw);
            var csb = new FbConnectionStringBuilder(newconnstr);
            csb.UserID = AdminName;
            csb.Password = AdminPsw;
            csb.Role = "RDB$ADMIN";
            //csb.ServerType = FbServerType.Embedded;
            //csb.Role = "ADMINS";
            newconnstr = csb.ToString();
            var s1 = MyData.CheckConnectionString(newconnstr);
            if (s1 == null)
            {
                MyMainForm.ShowWarning($"Neizdevās izveidot pieslēguma parametrus.\n[{newconnstr}]");
                return false;
            }
            newconnstr = s1;
            try
            {
                Connection = new FbConnection(newconnstr);
                Connection.Open();
            }
            catch(Exception ex)
            {
                Form_Error.ShowException(ex, "Pieslēgums neizdevās.");
                Connection = null;
                return false;
            }
            IsConnected = true;
            return true;
        }

        public bool IsReady()
        {
            if (!IsConnected || Connection == null ||
                Connection.State != ConnectionState.Open)
            {
                MyMainForm.ShowWarning("Nav datubāzes pieslēguma");
                return false;
            }
            return true;
        }

        public void GetUsers()
        {
            if (!IsReady()) return;

            var sql_user_roles =
                "SELECT u.RDB$USER as DBUSER, u.RDB$RELATION_NAME as ROLE, u.RDB$USER_TYPE as USER_TYPE\n" +
                "FROM RDB$USER_PRIVILEGES u\n" +
                "WHERE u.RDB$PRIVILEGE = 'M'\n" +
                "ORDER BY 1, 2;\n";
            
            var sql_users = "SELECT * FROM SEC$USERS ORDER BY 1;";
            var sql_roles = "SELECT RDB$ROLE_NAME FROM RDB$ROLES;";

            var table_users = new DataTable();
            var table_roles = new DataTable();
            var table_user_roles = new DataTable();

            FbUserRoles.Clear();
            FbUsers.Clear();
            FbRoles.Clear();

            try
            {
                var cm_users = new FbCommand(sql_users, Connection);
                table_users.Load(cm_users.ExecuteReader());

                var cm_user_roles = new FbCommand(sql_user_roles, Connection);
                table_user_roles.Load(cm_user_roles.ExecuteReader());

                var cm_roles = new FbCommand(sql_roles, Connection);
                table_roles.Load(cm_roles.ExecuteReader());
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Pieslēgums neizdevās.");
            }

            for (int i = 0; i < table_users.Rows.Count; i++)
            {
                var row = table_users.Rows[i];
                var ur = new DbUser()
                {
                    User = (row["SEC$USER_NAME"] as string).Trim(),
                    IsAdmin = (bool)(row["SEC$ADMIN"])
                };
                FbUsers.Add(ur);
            }

            for (int i = 0; i < table_roles.Rows.Count; i++)
            {
                var row = table_roles.Rows[i];
                var role = new DbRole()
                {
                    Name = (row["RDB$ROLE_NAME"] as string).Trim()
                };
                FbRoles.Add(role);
            }

            for (int i = 0; i < table_user_roles.Rows.Count; i++)
            {
                var row = table_user_roles.Rows[i];
                var ur = new UserRole()
                {
                    User = (row["DBUSER"] as string).Trim(),
                    Role = (row["ROLE"] as string).Trim()
                };
                FbUserRoles.Add(ur);
            }

            bsUsers.DataSource = FbUsers;
            bsUserRoles.DataSource = FbUserRoles;
            cbRole.Items.Clear();
            var sroles = FbRoles
                .Select(x => x.Name)
                .OrderBy(x => x)
                .ToArray();
            cbRole.Items.AddRange(sroles);
            if (sroles.Length > 0)
                cbRole.SelectedIndex = 0;

            /*var securitySvc = new FbSecurity();
            securitySvc.ConnectionString = Connection.ConnectionString;
            var users = securitySvc.DisplayUsers();
            dgvUsers.DataSource = users;*/
        }

        public List<string> GetDbUsers()
        {
            if (!IsReady()) return null;

            var sql_users =
                "SELECT DISTINCT u.RDB$USER as DBUSER\n" +
                "FROM RDB$USER_PRIVILEGES u\n" +
                "WHERE u.RDB$USER_TYPE = 8\n" +
                "ORDER BY 1;\n";

            var table_users = new DataTable();

            var ret = new List<string>();

            try
            {
                var cm_users = new FbCommand(sql_users, Connection);
                table_users.Load(cm_users.ExecuteReader());
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Pieslēgums neizdevās.");
            }

            for (int i = 0; i < table_users.Rows.Count; i++)
            {
                var row = table_users.Rows[i];
                var usernm = (row["DBUSER"] as string).Trim();
                ret.Add(usernm);
            }
            
            return ret;
        }

        public void NewUser()
        {
            if (!IsReady()) return;

            tbUserName.Text = tbUserName.Text.ToUpper();
            var username = tbUserName.Text;
            var userpsw = tbUserPassword.Text;
            if (username.IsNOE() || userpsw.IsNOE())
            {
                MyMainForm.ShowWarning("Jānorāda lietotāja vārds un parole.");
                return;
            }

            var r_urs = FbUsers
                .Where(x => x.User.ToUpper() == username)
                .ToList();

            if (r_urs.Count > 0)
            {
                MyMainForm.ShowWarning($"Lietotājs [{username}] jau ir izveidots");
                return;
            }

            var rt = MyMessageBox.Show($"Tiks izveodots jauns lietotājs [{username}].\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_add_user = $"CREATE USER {username} PASSWORD '@UPSW';";

            var sql_add_user_admin = $"CREATE USER {username} PASSWORD '@UPSW' GRANT ADMIN ROLE;";
            var sql_grant_users = $"GRANT USERS TO @UNM;";

            try
            {
                var cm = new FbCommand(sql_add_user, Connection);
                cm.Parameters.Add("@UNM", DbType.String).Value = username;
                cm.Parameters.Add("@UPSW", DbType.String).Value = userpsw;
                cm.Prepare();
                cm.ExecuteScalar();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Lietotāja izveidošana neizdevās.");
            }
        }

        public void DropUser()
        {
            if (!IsReady()) return;

            if (FbUsers.Count == 0 || bsUsers.Count == 0 || bsUsers.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs.");
                return;
            }

            var user = bsUsers.Current as DbUser;

            var rt = MyMessageBox.Show($"Tiks dzēsts lietotājs [{user.User}].\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_drop_user = $"DROP USER {user.User};";
            var sql_drop_user_2 = $"DROP USER \"{user.User}\";";

            try
            {
                var cm = new FbCommand(sql_drop_user, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                try
                {
                    var cm = new FbCommand(sql_drop_user_2, Connection);
                    cm.ExecuteNonQuery();
                    GetUsers();
                }
                catch (Exception ex2)
                {
                    Form_Error.ShowException(ex2, "Lietotāja izdzēšama meizdevās.");
                }
            }
        }

        public void GrantAdmin()
        {
            if (!IsReady()) return;

            if (FbUsers.Count == 0 || bsUsers.Count == 0 || bsUsers.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs.");
                return;
            }

            var user = bsUsers.Current as DbUser;

            var rt = MyMessageBox.Show($"Lietotājam [{user.User}] tiks piešķirtas Admin tiesības.\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_drop_user = $"ALTER USER {user.User} GRANT ADMIN ROLE;";

            try
            {
                var cm = new FbCommand(sql_drop_user, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās lietotājam piešķirt Admin tiesības.");
            }
        }

        public void RevokeAdmin()
        {
            if (!IsReady()) return;

            if (FbUsers.Count == 0 || bsUsers.Count == 0 || bsUsers.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs.");
                return;
            }

            var user = bsUsers.Current as DbUser;

            var rt = MyMessageBox.Show($"Lietotājam [{user.User}] tiks atņemtas Admin tiesības.\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_drop_user = $"ALTER USER {user.User} REVOKE ADMIN ROLE;";

            try
            {
                var cm = new FbCommand(sql_drop_user, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās lietotājam atņemt Admin tiesības.");
            }
        }

        public void ChangePassword()
        {
            if (!IsReady()) return;

            if (FbUsers.Count == 0 || bsUsers.Count == 0 || bsUsers.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs.");
                return;
            }

            var user = bsUsers.Current as DbUser;

            var psw = tbUserPassword.Text;
            if (psw.IsNOE())
            {
                MyMainForm.ShowWarning("Nav norādīta parole.");
                return;
            }

            var rt = MyMessageBox.Show($"Lietotājam [{user.User}] tiks Nomainīta parole.\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_alter_psw = $"ALTER USER {user.User} SET PASSWORD '{psw}';";

            try
            {
                var cm = new FbCommand(sql_alter_psw, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās lietotājam nomainīt paroli.");
            }
        }

        public void GrantRole()
        {
            if (!IsReady()) return;

            if (FbUsers.Count == 0 || bsUsers.Count == 0 || bsUsers.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs.");
                return;
            }

            var user = bsUsers.Current as DbUser;
            string role = cbRole.Text;

            var rt = MyMessageBox.Show($"Lietotājam [{user.User}] tiks piešķirta [{role}] loma.\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_grant_role = $"GRANT {role} TO {user.User};";

            try
            {
                var cm = new FbCommand(sql_grant_role, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās lietotājam piešķirt lomu.");
            }
        }

        public void RevokeRole()
        {
            if (!IsReady()) return;

            if (FbUserRoles.Count == 0 || bsUserRoles.Count == 0 || bsUserRoles.Current == null)
            {
                MyMainForm.ShowWarning("Nav atzīmēts lietotājs + loma.");
                return;
            }

            var ur = bsUserRoles.Current as UserRole;
            string user = ur.User;
            string role = ur.Role;

            var rt = MyMessageBox.Show($"Lietotājam [{user}] tiks atņemta [{role}] loma.\n\nVai turpināt?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rt != DialogResult.OK) return;

            var sql_revoke_role = $"REVOKE {role} FROM USER {user};";

            try
            {
                var cm = new FbCommand(sql_revoke_role, Connection);
                cm.ExecuteNonQuery();
                GetUsers();
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās lietotājam atņemt lomu.");
            }
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var constr = "character set=UTF8;data source=localhost;ReturnRecordsAffected=True;user id=SYSDBA;password=parole;port number=3051";
            MyData.CheckConnectionString(constr);
            var csb = new FbConnectionStringBuilder(constr);
            constr = csb.ToString();
            var securitySvc = new FbSecurity();
            securitySvc.ConnectionString = constr;
            var users = securitySvc.DisplayUsers();
            dgvUserRoles.DataSource = users;
        }

        public class UserRole
        {
            public string User { get; set; } = null;
            public string Role { get; set; } = null;
        }

        public class DbUser
        {
            public string User { get; set; } = null;
            public bool IsAdmin { get; set; } = false;
        }

        public class DbRole
        {
            public string Name { get; set; } = null;
        }

        private void cmConnect_Click(object sender, EventArgs e)
        {
            Connect();
            GetUsers();
        }

        private void izveidotJaunuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser();
        }

        private void dzēstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropUser();
        }

        private void nomainītParoliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void piešķirtAdminLomuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrantAdmin();
        }

        private void atņemtAdminLomuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevokeAdmin();
        }

        private void nolasītLietotājuDatusNoJaunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void piešķirtLomuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrantRole();
        }

        private void atņemtLomuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevokeRole();
        }

        private void parādītDBLietotājuSarakstuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rt = GetDbUsers();
            if (rt == null) return;
            var s = string.Join("; ", rt);
            MyMainForm.ShowInfo("DB lietotāji:\n\n" + s);
        }
    }
}
