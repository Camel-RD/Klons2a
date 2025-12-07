namespace KlonsChatAdmin
{
    partial class Form_Admin
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            clinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            miStart = new System.Windows.Forms.ToolStripMenuItem();
            miStop = new System.Windows.Forms.ToolStripMenuItem();
            tbSignals = new System.Windows.Forms.RichTextBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpSignals = new System.Windows.Forms.TabPage();
            tpChats = new System.Windows.Forms.TabPage();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tbOut = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            cbChats = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbSupportId = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbUserId = new System.Windows.Forms.TextBox();
            tbIn = new System.Windows.Forms.RichTextBox();
            menuStrip2 = new System.Windows.Forms.MenuStrip();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            miAdd = new System.Windows.Forms.ToolStripMenuItem();
            miGet = new System.Windows.Forms.ToolStripMenuItem();
            miClear = new System.Windows.Forms.ToolStripMenuItem();
            miGetUpdatedChats = new System.Windows.Forms.ToolStripMenuItem();
            miMarkChat = new System.Windows.Forms.ToolStripMenuItem();
            tpTestUser = new System.Windows.Forms.TabPage();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            tbOut2 = new System.Windows.Forms.RichTextBox();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            tbUserId2 = new System.Windows.Forms.TextBox();
            tbIn2 = new System.Windows.Forms.RichTextBox();
            menuStrip3 = new System.Windows.Forms.MenuStrip();
            miAdd2 = new System.Windows.Forms.ToolStripMenuItem();
            miGet2 = new System.Windows.Forms.ToolStripMenuItem();
            miClear2 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpSignals.SuspendLayout();
            tpChats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip2.SuspendLayout();
            tpTestUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { clinetToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(560, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clinetToolStripMenuItem
            // 
            clinetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miStart, miStop });
            clinetToolStripMenuItem.Name = "clinetToolStripMenuItem";
            clinetToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            clinetToolStripMenuItem.Text = "Client";
            // 
            // miStart
            // 
            miStart.Name = "miStart";
            miStart.Size = new System.Drawing.Size(107, 24);
            miStart.Text = "Start";
            miStart.Click += miStart_Click;
            // 
            // miStop
            // 
            miStop.Name = "miStop";
            miStop.Size = new System.Drawing.Size(107, 24);
            miStop.Text = "Stop";
            miStop.Click += miStop_Click;
            // 
            // tbSignals
            // 
            tbSignals.Dock = System.Windows.Forms.DockStyle.Fill;
            tbSignals.Location = new System.Drawing.Point(0, 27);
            tbSignals.Name = "tbSignals";
            tbSignals.Size = new System.Drawing.Size(560, 332);
            tbSignals.TabIndex = 1;
            tbSignals.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpSignals);
            tabControl1.Controls.Add(tpChats);
            tabControl1.Controls.Add(tpTestUser);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(568, 391);
            tabControl1.TabIndex = 2;
            // 
            // tpSignals
            // 
            tpSignals.Controls.Add(tbSignals);
            tpSignals.Controls.Add(menuStrip1);
            tpSignals.Location = new System.Drawing.Point(4, 28);
            tpSignals.Name = "tpSignals";
            tpSignals.Size = new System.Drawing.Size(560, 359);
            tpSignals.TabIndex = 0;
            tpSignals.Text = "Signals";
            // 
            // tpChats
            // 
            tpChats.Controls.Add(splitContainer1);
            tpChats.Controls.Add(menuStrip2);
            tpChats.Location = new System.Drawing.Point(4, 28);
            tpChats.Name = "tpChats";
            tpChats.Size = new System.Drawing.Size(560, 359);
            tpChats.TabIndex = 1;
            tpChats.Text = "Chats";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer1.Location = new System.Drawing.Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tbOut);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tbIn);
            splitContainer1.Size = new System.Drawing.Size(560, 332);
            splitContainer1.SplitterDistance = 240;
            splitContainer1.TabIndex = 3;
            // 
            // tbOut
            // 
            tbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            tbOut.Location = new System.Drawing.Point(0, 96);
            tbOut.Name = "tbOut";
            tbOut.Size = new System.Drawing.Size(560, 144);
            tbOut.TabIndex = 0;
            tbOut.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbChats);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbSupportId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbUserId);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(560, 96);
            panel1.TabIndex = 1;
            // 
            // cbChats
            // 
            cbChats.FormattingEnabled = true;
            cbChats.Location = new System.Drawing.Point(112, 63);
            cbChats.Name = "cbChats";
            cbChats.Size = new System.Drawing.Size(305, 27);
            cbChats.TabIndex = 4;
            cbChats.SelectedIndexChanged += cbChats_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 66);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 19);
            label4.TabIndex = 3;
            label4.Text = "Updated chats:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 19);
            label2.TabIndex = 3;
            label2.Text = "Support id:";
            // 
            // tbSupportId
            // 
            tbSupportId.Location = new System.Drawing.Point(112, 33);
            tbSupportId.Name = "tbSupportId";
            tbSupportId.Size = new System.Drawing.Size(306, 26);
            tbSupportId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 19);
            label1.TabIndex = 1;
            label1.Text = "User id:";
            // 
            // tbUserId
            // 
            tbUserId.Location = new System.Drawing.Point(112, 3);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new System.Drawing.Size(306, 26);
            tbUserId.TabIndex = 0;
            // 
            // tbIn
            // 
            tbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            tbIn.Location = new System.Drawing.Point(0, 0);
            tbIn.Name = "tbIn";
            tbIn.Size = new System.Drawing.Size(560, 88);
            tbIn.TabIndex = 0;
            tbIn.Text = "";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolsToolStripMenuItem, miAdd, miGet, miClear, miGetUpdatedChats, miMarkChat });
            menuStrip2.Location = new System.Drawing.Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new System.Drawing.Size(560, 27);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // miAdd
            // 
            miAdd.Name = "miAdd";
            miAdd.Size = new System.Drawing.Size(46, 23);
            miAdd.Text = "Add";
            miAdd.Click += miAdd_Click;
            // 
            // miGet
            // 
            miGet.Name = "miGet";
            miGet.Size = new System.Drawing.Size(43, 23);
            miGet.Text = "Get";
            miGet.Click += miGet_Click;
            // 
            // miClear
            // 
            miClear.Name = "miClear";
            miClear.Size = new System.Drawing.Size(52, 23);
            miClear.Text = "Clear";
            miClear.Click += miClear_Click;
            // 
            // miGetUpdatedChats
            // 
            miGetUpdatedChats.Name = "miGetUpdatedChats";
            miGetUpdatedChats.Size = new System.Drawing.Size(139, 23);
            miGetUpdatedChats.Text = "Get Updated Chats";
            miGetUpdatedChats.Click += miGetUpdatedChats_Click;
            // 
            // miMarkChat
            // 
            miMarkChat.Name = "miMarkChat";
            miMarkChat.Size = new System.Drawing.Size(150, 23);
            miMarkChat.Text = "Mark Chat Answered";
            miMarkChat.Click += miMarkChat_Click;
            // 
            // tpTestUser
            // 
            tpTestUser.Controls.Add(splitContainer2);
            tpTestUser.Controls.Add(menuStrip3);
            tpTestUser.Location = new System.Drawing.Point(4, 28);
            tpTestUser.Name = "tpTestUser";
            tpTestUser.Size = new System.Drawing.Size(560, 359);
            tpTestUser.TabIndex = 2;
            tpTestUser.Text = "Test User";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer2.Location = new System.Drawing.Point(0, 27);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tbOut2);
            splitContainer2.Panel1.Controls.Add(panel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tbIn2);
            splitContainer2.Size = new System.Drawing.Size(560, 332);
            splitContainer2.SplitterDistance = 240;
            splitContainer2.TabIndex = 3;
            // 
            // tbOut2
            // 
            tbOut2.Dock = System.Windows.Forms.DockStyle.Fill;
            tbOut2.Location = new System.Drawing.Point(0, 33);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new System.Drawing.Size(560, 207);
            tbOut2.TabIndex = 0;
            tbOut2.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbUserId2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(560, 33);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 19);
            label3.TabIndex = 1;
            label3.Text = "User id:";
            // 
            // tbUserId2
            // 
            tbUserId2.Location = new System.Drawing.Point(68, 3);
            tbUserId2.Name = "tbUserId2";
            tbUserId2.Size = new System.Drawing.Size(306, 26);
            tbUserId2.TabIndex = 0;
            // 
            // tbIn2
            // 
            tbIn2.Dock = System.Windows.Forms.DockStyle.Fill;
            tbIn2.Location = new System.Drawing.Point(0, 0);
            tbIn2.Name = "tbIn2";
            tbIn2.Size = new System.Drawing.Size(560, 88);
            tbIn2.TabIndex = 0;
            tbIn2.Text = "";
            // 
            // menuStrip3
            // 
            menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miAdd2, miGet2, miClear2 });
            menuStrip3.Location = new System.Drawing.Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new System.Drawing.Size(560, 27);
            menuStrip3.TabIndex = 2;
            menuStrip3.Text = "menuStrip1";
            // 
            // miAdd2
            // 
            miAdd2.Name = "miAdd2";
            miAdd2.Size = new System.Drawing.Size(46, 23);
            miAdd2.Text = "Add";
            miAdd2.Click += miAdd2_Click;
            // 
            // miGet2
            // 
            miGet2.Name = "miGet2";
            miGet2.Size = new System.Drawing.Size(43, 23);
            miGet2.Text = "Get";
            miGet2.Click += miGet2_Click;
            // 
            // miClear2
            // 
            miClear2.Name = "miClear2";
            miClear2.Size = new System.Drawing.Size(52, 23);
            miClear2.Text = "Clear";
            miClear2.Click += miClear2_Click;
            // 
            // Form_Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(568, 391);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Admin";
            Text = "Klons Chat Admin";
            FormClosing += Form_Admin_FormClosing;
            Load += Form_Admin_Load;
            Shown += Form_Admin_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpSignals.ResumeLayout(false);
            tpSignals.PerformLayout();
            tpChats.ResumeLayout(false);
            tpChats.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tpTestUser.ResumeLayout(false);
            tpTestUser.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miStart;
        private System.Windows.Forms.ToolStripMenuItem miStop;
        private System.Windows.Forms.RichTextBox tbSignals;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSignals;
        private System.Windows.Forms.TabPage tpChats;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miGet;
        private System.Windows.Forms.ToolStripMenuItem miClear;
        private System.Windows.Forms.ToolStripMenuItem miGetUpdatedChats;
        private System.Windows.Forms.ToolStripMenuItem miMarkChat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox tbOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSupportId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.RichTextBox tbIn;
        private System.Windows.Forms.TabPage tpTestUser;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox tbOut2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserId2;
        private System.Windows.Forms.RichTextBox tbIn2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem miAdd2;
        private System.Windows.Forms.ToolStripMenuItem miGet2;
        private System.Windows.Forms.ToolStripMenuItem miClear2;
        private System.Windows.Forms.Label label4;
    }
}