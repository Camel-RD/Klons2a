
namespace KlonsF.Forms
{
    partial class Form_FbUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvUserRoles = new KlonsLIB.Components.MyDataGridView();
            dgcUserRolesUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUserRolesRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsUserRoles = new System.Windows.Forms.BindingSource(components);
            tbAdminName = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbAdminPassword = new KlonsLIB.Components.MyTextBox();
            cmConnect = new System.Windows.Forms.Button();
            tbUserName = new KlonsLIB.Components.MyTextBox();
            tbUserPassword = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cbRole = new KlonsLIB.Components.FlatComboBox();
            dgvUsers = new KlonsLIB.Components.MyDataGridView();
            dgcUsersUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUsersAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            bsUsers = new System.Windows.Forms.BindingSource(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            lietotājiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            izveidotJaunuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dzēstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nomainītParoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            piešķirtAdminLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atņemtAdminLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            nolasītLietotājuDatusNoJaunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            parādītDBLietotājuSarakstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            piešķirtLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atņemtLomuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUserRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUsers).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.AllowUserToAddRows = false;
            dgvUserRoles.AllowUserToDeleteRows = false;
            dgvUserRoles.AllowUserToResizeRows = false;
            dgvUserRoles.AutoGenerateColumns = false;
            dgvUserRoles.AutoSave = false;
            dgvUserRoles.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcUserRolesUser, dgcUserRolesRole });
            dgvUserRoles.DataSource = bsUserRoles;
            dgvUserRoles.Location = new System.Drawing.Point(250, 49);
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.ReadOnly = true;
            dgvUserRoles.RowHeadersVisible = false;
            dgvUserRoles.RowHeadersWidth = 62;
            dgvUserRoles.ShowCellToolTips = false;
            dgvUserRoles.Size = new System.Drawing.Size(339, 172);
            dgvUserRoles.TabIndex = 4;
            // 
            // dgcUserRolesUser
            // 
            dgcUserRolesUser.DataPropertyName = "User";
            dgcUserRolesUser.HeaderText = "Lietotājs";
            dgcUserRolesUser.MinimumWidth = 8;
            dgcUserRolesUser.Name = "dgcUserRolesUser";
            dgcUserRolesUser.ReadOnly = true;
            dgcUserRolesUser.Width = 150;
            // 
            // dgcUserRolesRole
            // 
            dgcUserRolesRole.DataPropertyName = "Role";
            dgcUserRolesRole.HeaderText = "Loma";
            dgcUserRolesRole.MinimumWidth = 8;
            dgcUserRolesRole.Name = "dgcUserRolesRole";
            dgcUserRolesRole.ReadOnly = true;
            dgcUserRolesRole.Width = 150;
            // 
            // tbAdminName
            // 
            tbAdminName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbAdminName.Location = new System.Drawing.Point(154, 9);
            tbAdminName.Name = "tbAdminName";
            tbAdminName.Size = new System.Drawing.Size(100, 23);
            tbAdminName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 17);
            label1.TabIndex = 8;
            label1.Text = "Administratora vārds:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(292, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 17);
            label2.TabIndex = 3;
            label2.Text = "parole:";
            // 
            // tbAdminPassword
            // 
            tbAdminPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbAdminPassword.Location = new System.Drawing.Point(350, 9);
            tbAdminPassword.Name = "tbAdminPassword";
            tbAdminPassword.PasswordChar = '*';
            tbAdminPassword.Size = new System.Drawing.Size(100, 23);
            tbAdminPassword.TabIndex = 1;
            // 
            // cmConnect
            // 
            cmConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmConnect.Location = new System.Drawing.Point(475, 4);
            cmConnect.Name = "cmConnect";
            cmConnect.Size = new System.Drawing.Size(99, 31);
            cmConnect.TabIndex = 2;
            cmConnect.Text = "Pieslēgties";
            cmConnect.UseVisualStyleBackColor = true;
            cmConnect.Click += cmConnect_Click;
            // 
            // tbUserName
            // 
            tbUserName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbUserName.Location = new System.Drawing.Point(122, 233);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new System.Drawing.Size(100, 23);
            tbUserName.TabIndex = 5;
            // 
            // tbUserPassword
            // 
            tbUserPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbUserPassword.Location = new System.Drawing.Point(300, 233);
            tbUserPassword.Name = "tbUserPassword";
            tbUserPassword.Size = new System.Drawing.Size(100, 23);
            tbUserPassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 235);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 17);
            label3.TabIndex = 9;
            label3.Text = "Lietotāja vārds:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(237, 235);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 17);
            label4.TabIndex = 10;
            label4.Text = "parole:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 265);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 17);
            label5.TabIndex = 11;
            label5.Text = "Loma";
            // 
            // cbRole
            // 
            cbRole.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "USERS", "ADMINS" });
            cbRole.Location = new System.Drawing.Point(58, 262);
            cbRole.Name = "cbRole";
            cbRole.Size = new System.Drawing.Size(164, 24);
            cbRole.TabIndex = 7;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcUsersUser, dgcUsersAdmin });
            dgvUsers.DataSource = bsUsers;
            dgvUsers.Location = new System.Drawing.Point(0, 49);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.Size = new System.Drawing.Size(244, 172);
            dgvUsers.TabIndex = 3;
            // 
            // dgcUsersUser
            // 
            dgcUsersUser.DataPropertyName = "User";
            dgcUsersUser.HeaderText = "Lietotāja vārds";
            dgcUsersUser.MinimumWidth = 8;
            dgcUsersUser.Name = "dgcUsersUser";
            dgcUsersUser.ReadOnly = true;
            dgcUsersUser.Width = 150;
            // 
            // dgcUsersAdmin
            // 
            dgcUsersAdmin.DataPropertyName = "IsAdmin";
            dgcUsersAdmin.HeaderText = "Admin";
            dgcUsersAdmin.MinimumWidth = 8;
            dgcUsersAdmin.Name = "dgcUsersAdmin";
            dgcUsersAdmin.ReadOnly = true;
            dgcUsersAdmin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcUsersAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcUsersAdmin.Width = 60;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lietotājiToolStripMenuItem, lomasToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(595, 25);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // lietotājiToolStripMenuItem
            // 
            lietotājiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { izveidotJaunuToolStripMenuItem, dzēstToolStripMenuItem, nomainītParoliToolStripMenuItem, toolStripSeparator1, piešķirtAdminLomuToolStripMenuItem, atņemtAdminLomuToolStripMenuItem, toolStripSeparator2, nolasītLietotājuDatusNoJaunaToolStripMenuItem, parādītDBLietotājuSarakstuToolStripMenuItem });
            lietotājiToolStripMenuItem.Name = "lietotājiToolStripMenuItem";
            lietotājiToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            lietotājiToolStripMenuItem.Text = "Lietotāji";
            // 
            // izveidotJaunuToolStripMenuItem
            // 
            izveidotJaunuToolStripMenuItem.Name = "izveidotJaunuToolStripMenuItem";
            izveidotJaunuToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            izveidotJaunuToolStripMenuItem.Text = "Izveidot jaunu";
            izveidotJaunuToolStripMenuItem.Click += izveidotJaunuToolStripMenuItem_Click;
            // 
            // dzēstToolStripMenuItem
            // 
            dzēstToolStripMenuItem.Name = "dzēstToolStripMenuItem";
            dzēstToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            dzēstToolStripMenuItem.Text = "Dzēst";
            dzēstToolStripMenuItem.Click += dzēstToolStripMenuItem_Click;
            // 
            // nomainītParoliToolStripMenuItem
            // 
            nomainītParoliToolStripMenuItem.Name = "nomainītParoliToolStripMenuItem";
            nomainītParoliToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            nomainītParoliToolStripMenuItem.Text = "Nomainīt paroli";
            nomainītParoliToolStripMenuItem.Click += nomainītParoliToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // piešķirtAdminLomuToolStripMenuItem
            // 
            piešķirtAdminLomuToolStripMenuItem.Name = "piešķirtAdminLomuToolStripMenuItem";
            piešķirtAdminLomuToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            piešķirtAdminLomuToolStripMenuItem.Text = "Piešķirt Admin Lomu";
            piešķirtAdminLomuToolStripMenuItem.Click += piešķirtAdminLomuToolStripMenuItem_Click;
            // 
            // atņemtAdminLomuToolStripMenuItem
            // 
            atņemtAdminLomuToolStripMenuItem.Name = "atņemtAdminLomuToolStripMenuItem";
            atņemtAdminLomuToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            atņemtAdminLomuToolStripMenuItem.Text = "Atņemt Admin lomu";
            atņemtAdminLomuToolStripMenuItem.Click += atņemtAdminLomuToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(267, 6);
            // 
            // nolasītLietotājuDatusNoJaunaToolStripMenuItem
            // 
            nolasītLietotājuDatusNoJaunaToolStripMenuItem.Name = "nolasītLietotājuDatusNoJaunaToolStripMenuItem";
            nolasītLietotājuDatusNoJaunaToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            nolasītLietotājuDatusNoJaunaToolStripMenuItem.Text = "Nolasīt lietotāju datus no jauna";
            nolasītLietotājuDatusNoJaunaToolStripMenuItem.Click += nolasītLietotājuDatusNoJaunaToolStripMenuItem_Click;
            // 
            // parādītDBLietotājuSarakstuToolStripMenuItem
            // 
            parādītDBLietotājuSarakstuToolStripMenuItem.Name = "parādītDBLietotājuSarakstuToolStripMenuItem";
            parādītDBLietotājuSarakstuToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            parādītDBLietotājuSarakstuToolStripMenuItem.Text = "Parādīt DB lietotāju sarakstu";
            parādītDBLietotājuSarakstuToolStripMenuItem.Click += parādītDBLietotājuSarakstuToolStripMenuItem_Click;
            // 
            // lomasToolStripMenuItem
            // 
            lomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { piešķirtLomuToolStripMenuItem, atņemtLomuToolStripMenuItem });
            lomasToolStripMenuItem.Name = "lomasToolStripMenuItem";
            lomasToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            lomasToolStripMenuItem.Text = "Lomas";
            // 
            // piešķirtLomuToolStripMenuItem
            // 
            piešķirtLomuToolStripMenuItem.Name = "piešķirtLomuToolStripMenuItem";
            piešķirtLomuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            piešķirtLomuToolStripMenuItem.Text = "Piešķirt lomu";
            piešķirtLomuToolStripMenuItem.Click += piešķirtLomuToolStripMenuItem_Click;
            // 
            // atņemtLomuToolStripMenuItem
            // 
            atņemtLomuToolStripMenuItem.Name = "atņemtLomuToolStripMenuItem";
            atņemtLomuToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            atņemtLomuToolStripMenuItem.Text = "Atņemt lomu";
            atņemtLomuToolStripMenuItem.Click += atņemtLomuToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvUserRoles);
            panel1.Controls.Add(dgvUsers);
            panel1.Controls.Add(tbAdminName);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(tbAdminPassword);
            panel1.Controls.Add(cmConnect);
            panel1.Controls.Add(tbUserName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbUserPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(595, 294);
            panel1.TabIndex = 13;
            // 
            // Form_FbUsers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(595, 319);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form_FbUsers";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "DB lietotāji";
            Load += Form_FbUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUserRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KlonsLIB.Components.MyDataGridView dgvUserRoles;
        private KlonsLIB.Components.MyTextBox tbAdminName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyTextBox tbAdminPassword;
        private System.Windows.Forms.Button cmConnect;
        private KlonsLIB.Components.MyTextBox tbUserName;
        private KlonsLIB.Components.MyTextBox tbUserPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private KlonsLIB.Components.FlatComboBox cbRole;
        private KlonsLIB.Components.MyDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserRolesUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserRolesRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsersUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcUsersAdmin;
        private System.Windows.Forms.BindingSource bsUsers;
        private System.Windows.Forms.BindingSource bsUserRoles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lietotājiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveidotJaunuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzēstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomainītParoliToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem piešķirtAdminLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atņemtAdminLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nolasītLietotājuDatusNoJaunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piešķirtLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atņemtLomuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parādītDBLietotājuSarakstuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}