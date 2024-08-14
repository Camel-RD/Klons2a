using KlonsLIB.Components;

namespace KlonsF.Forms
{
    partial class Form_OpsRules
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
            cmClose = new System.Windows.Forms.Button();
            myLabel1 = new MyLabel();
            cbPVN5 = new MyMcFlatComboBox();
            cbPVNkred = new MyMcFlatComboBox();
            cbPVNdeb = new MyMcFlatComboBox();
            cbPVNizd = new MyMcFlatComboBox();
            cbPVNien = new MyMcFlatComboBox();
            cbIINien = new MyMcFlatComboBox();
            cbIINizd = new MyMcFlatComboBox();
            chbPVNreqPvn = new MyCheckBox();
            chbPVNreqIen = new MyCheckBox();
            chbPVNizd = new MyCheckBox();
            chbPVNien = new MyCheckBox();
            chbIINien = new MyCheckBox();
            chbIINizd = new MyCheckBox();
            chbPVN5 = new MyCheckBox();
            chbPVNkred = new MyCheckBox();
            chbPVNdeb = new MyCheckBox();
            chbPVN = new MyCheckBox();
            chbIIN = new MyCheckBox();
            chbNP = new MyCheckBox();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmClose
            // 
            cmClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            cmClose.Location = new System.Drawing.Point(388, 276);
            cmClose.Margin = new System.Windows.Forms.Padding(2);
            cmClose.Name = "cmClose";
            cmClose.Size = new System.Drawing.Size(100, 48);
            cmClose.TabIndex = 19;
            cmClose.Text = "Aizvērt";
            cmClose.UseVisualStyleBackColor = true;
            cmClose.Click += cmClose_Click;
            // 
            // myLabel1
            // 
            myLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(10, 277);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(2);
            myLabel1.Size = new System.Drawing.Size(368, 49);
            myLabel1.TabIndex = 20;
            myLabel1.Text = " Šie parametri tiek izmantoti, kontrolējot kontējumu ievadi. Ja kāds no punktiem nav jākontrolē, ķeksīti noņemam.";
            // 
            // cbPVN5
            // 
            cbPVN5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPVN5.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbPVN5.ColumnWidths = "100;400";
            cbPVN5.DisplayMember = "idx";
            cbPVN5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPVN5.DropDownHeight = 144;
            cbPVN5.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbPVN5.DropDownWidth = 519;
            cbPVN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPVN5.FormattingEnabled = true;
            cbPVN5.GridLineColor = System.Drawing.Color.LightGray;
            cbPVN5.GridLineHorizontal = false;
            cbPVN5.GridLineVertical = false;
            cbPVN5.IntegralHeight = false;
            cbPVN5.Location = new System.Drawing.Point(0, 243);
            cbPVN5.Margin = new System.Windows.Forms.Padding(2);
            cbPVN5.Name = "cbPVN5";
            cbPVN5.Size = new System.Drawing.Size(81, 24);
            cbPVN5.TabIndex = 16;
            cbPVN5.ValueMember = "idx";
            cbPVN5.KeyDown += control_KeyDown;
            cbPVN5.MouseDoubleClick += cbPVN_MouseDoubleClick;
            // 
            // cbPVNkred
            // 
            cbPVNkred.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPVNkred.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbPVNkred.ColumnWidths = "100;400";
            cbPVNkred.DisplayMember = "idx";
            cbPVNkred.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPVNkred.DropDownHeight = 144;
            cbPVNkred.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbPVNkred.DropDownWidth = 519;
            cbPVNkred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPVNkred.FormattingEnabled = true;
            cbPVNkred.GridLineColor = System.Drawing.Color.LightGray;
            cbPVNkred.GridLineHorizontal = false;
            cbPVNkred.GridLineVertical = false;
            cbPVNkred.IntegralHeight = false;
            cbPVNkred.Location = new System.Drawing.Point(0, 217);
            cbPVNkred.Margin = new System.Windows.Forms.Padding(2);
            cbPVNkred.Name = "cbPVNkred";
            cbPVNkred.Size = new System.Drawing.Size(81, 24);
            cbPVNkred.TabIndex = 14;
            cbPVNkred.ValueMember = "idx";
            cbPVNkred.KeyDown += control_KeyDown;
            cbPVNkred.MouseDoubleClick += cbPVN_MouseDoubleClick;
            // 
            // cbPVNdeb
            // 
            cbPVNdeb.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPVNdeb.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbPVNdeb.ColumnWidths = "100;400";
            cbPVNdeb.DisplayMember = "idx";
            cbPVNdeb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPVNdeb.DropDownHeight = 144;
            cbPVNdeb.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbPVNdeb.DropDownWidth = 519;
            cbPVNdeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPVNdeb.FormattingEnabled = true;
            cbPVNdeb.GridLineColor = System.Drawing.Color.LightGray;
            cbPVNdeb.GridLineHorizontal = false;
            cbPVNdeb.GridLineVertical = false;
            cbPVNdeb.IntegralHeight = false;
            cbPVNdeb.Location = new System.Drawing.Point(0, 191);
            cbPVNdeb.Margin = new System.Windows.Forms.Padding(2);
            cbPVNdeb.Name = "cbPVNdeb";
            cbPVNdeb.Size = new System.Drawing.Size(81, 24);
            cbPVNdeb.TabIndex = 12;
            cbPVNdeb.ValueMember = "idx";
            cbPVNdeb.KeyDown += control_KeyDown;
            cbPVNdeb.MouseDoubleClick += cbPVN_MouseDoubleClick;
            // 
            // cbPVNizd
            // 
            cbPVNizd.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPVNizd.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbPVNizd.ColumnWidths = "100;400";
            cbPVNizd.DisplayMember = "idx";
            cbPVNizd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPVNizd.DropDownHeight = 144;
            cbPVNizd.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbPVNizd.DropDownWidth = 519;
            cbPVNizd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPVNizd.FormattingEnabled = true;
            cbPVNizd.GridLineColor = System.Drawing.Color.LightGray;
            cbPVNizd.GridLineHorizontal = false;
            cbPVNizd.GridLineVertical = false;
            cbPVNizd.IntegralHeight = false;
            cbPVNizd.Location = new System.Drawing.Point(0, 165);
            cbPVNizd.Margin = new System.Windows.Forms.Padding(2);
            cbPVNizd.Name = "cbPVNizd";
            cbPVNizd.Size = new System.Drawing.Size(81, 24);
            cbPVNizd.TabIndex = 10;
            cbPVNizd.ValueMember = "idx";
            cbPVNizd.KeyDown += control_KeyDown;
            cbPVNizd.MouseDoubleClick += cbPVN_MouseDoubleClick;
            // 
            // cbPVNien
            // 
            cbPVNien.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPVNien.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbPVNien.ColumnWidths = "100;400";
            cbPVNien.DisplayMember = "idx";
            cbPVNien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPVNien.DropDownHeight = 144;
            cbPVNien.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbPVNien.DropDownWidth = 519;
            cbPVNien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPVNien.FormattingEnabled = true;
            cbPVNien.GridLineColor = System.Drawing.Color.LightGray;
            cbPVNien.GridLineHorizontal = false;
            cbPVNien.GridLineVertical = false;
            cbPVNien.IntegralHeight = false;
            cbPVNien.Location = new System.Drawing.Point(0, 139);
            cbPVNien.Margin = new System.Windows.Forms.Padding(2);
            cbPVNien.Name = "cbPVNien";
            cbPVNien.Size = new System.Drawing.Size(81, 24);
            cbPVNien.TabIndex = 8;
            cbPVNien.ValueMember = "idx";
            cbPVNien.KeyDown += control_KeyDown;
            cbPVNien.MouseDoubleClick += cbPVN_MouseDoubleClick;
            // 
            // cbIINien
            // 
            cbIINien.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbIINien.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbIINien.ColumnWidths = "100;400";
            cbIINien.DisplayMember = "idx";
            cbIINien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbIINien.DropDownHeight = 144;
            cbIINien.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbIINien.DropDownWidth = 519;
            cbIINien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbIINien.FormattingEnabled = true;
            cbIINien.GridLineColor = System.Drawing.Color.LightGray;
            cbIINien.GridLineHorizontal = false;
            cbIINien.GridLineVertical = false;
            cbIINien.IntegralHeight = false;
            cbIINien.Location = new System.Drawing.Point(0, 81);
            cbIINien.Margin = new System.Windows.Forms.Padding(2);
            cbIINien.Name = "cbIINien";
            cbIINien.Size = new System.Drawing.Size(81, 24);
            cbIINien.TabIndex = 5;
            cbIINien.ValueMember = "idx";
            cbIINien.KeyDown += control_KeyDown;
            cbIINien.MouseDoubleClick += cbIIN_MouseDoubleClick;
            // 
            // cbIINizd
            // 
            cbIINizd.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbIINizd.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbIINizd.ColumnWidths = "100;400";
            cbIINizd.DisplayMember = "idx";
            cbIINizd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbIINizd.DropDownHeight = 144;
            cbIINizd.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            cbIINizd.DropDownWidth = 519;
            cbIINizd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbIINizd.FormattingEnabled = true;
            cbIINizd.GridLineColor = System.Drawing.Color.LightGray;
            cbIINizd.GridLineHorizontal = false;
            cbIINizd.GridLineVertical = false;
            cbIINizd.IntegralHeight = false;
            cbIINizd.Location = new System.Drawing.Point(0, 53);
            cbIINizd.Margin = new System.Windows.Forms.Padding(2);
            cbIINizd.Name = "cbIINizd";
            cbIINizd.Size = new System.Drawing.Size(81, 24);
            cbIINizd.TabIndex = 3;
            cbIINizd.ValueMember = "idx";
            cbIINizd.KeyDown += control_KeyDown;
            cbIINizd.MouseDoubleClick += cbIIN_MouseDoubleClick;
            // 
            // chbPVNreqPvn
            // 
            chbPVNreqPvn.Location = new System.Drawing.Point(86, 268);
            chbPVNreqPvn.Margin = new System.Windows.Forms.Padding(2);
            chbPVNreqPvn.Name = "chbPVNreqPvn";
            chbPVNreqPvn.Size = new System.Drawing.Size(455, 45);
            chbPVNreqPvn.TabIndex = 17;
            chbPVNreqPvn.Text = "Ja bilances konts ir PVN konts ('5731'), PVN kods (5. pazīme) \r\nnedrīkst norādīt uz ieņēmeumiem";
            chbPVNreqPvn.UseVisualStyleBackColor = true;
            // 
            // chbPVNreqIen
            // 
            chbPVNreqIen.Location = new System.Drawing.Point(85, 317);
            chbPVNreqIen.Margin = new System.Windows.Forms.Padding(2);
            chbPVNreqIen.Name = "chbPVNreqIen";
            chbPVNreqIen.Size = new System.Drawing.Size(456, 43);
            chbPVNreqIen.TabIndex = 18;
            chbPVNreqIen.Text = "Ja bilances kontā ir ieņēmumi ('6*'), PVN kodā \r\njābūt ieņēmumiem (piem: '101')";
            chbPVNreqIen.UseVisualStyleBackColor = true;
            // 
            // chbPVNizd
            // 
            chbPVNizd.AutoSize = true;
            chbPVNizd.Location = new System.Drawing.Point(85, 168);
            chbPVNizd.Margin = new System.Windows.Forms.Padding(2);
            chbPVNizd.Name = "chbPVNizd";
            chbPVNizd.Size = new System.Drawing.Size(367, 18);
            chbPVNizd.TabIndex = 9;
            chbPVNizd.Text = "PVN kods izdevumiem, ja bilances kontā ir izdevumi (7x)";
            chbPVNizd.UseVisualStyleBackColor = true;
            // 
            // chbPVNien
            // 
            chbPVNien.AutoSize = true;
            chbPVNien.Location = new System.Drawing.Point(85, 142);
            chbPVNien.Margin = new System.Windows.Forms.Padding(2);
            chbPVNien.Name = "chbPVNien";
            chbPVNien.Size = new System.Drawing.Size(336, 18);
            chbPVNien.TabIndex = 7;
            chbPVNien.Text = "PVN ieņēmumu kods, ja bilances kontā ir ieņēmumi";
            chbPVNien.UseVisualStyleBackColor = true;
            // 
            // chbIINien
            // 
            chbIINien.AutoSize = true;
            chbIINien.Location = new System.Drawing.Point(86, 84);
            chbIINien.Margin = new System.Windows.Forms.Padding(2);
            chbIINien.Name = "chbIINien";
            chbIINien.Size = new System.Drawing.Size(382, 18);
            chbIINien.TabIndex = 4;
            chbIINien.Text = "IIN darijuma kods ('LIE,'NIE'), ja bilances kontā ir ieņēmumi";
            chbIINien.UseVisualStyleBackColor = true;
            // 
            // chbIINizd
            // 
            chbIINizd.AutoSize = true;
            chbIINizd.Location = new System.Drawing.Point(85, 56);
            chbIINizd.Margin = new System.Windows.Forms.Padding(2);
            chbIINizd.Name = "chbIINizd";
            chbIINizd.Size = new System.Drawing.Size(339, 18);
            chbIINizd.TabIndex = 2;
            chbIINizd.Text = "IIN darijumu izdevumu kods (3. pazīme 'LIZ', 'NIZ',..)";
            chbIINizd.UseVisualStyleBackColor = true;
            // 
            // chbPVN5
            // 
            chbPVN5.AutoSize = true;
            chbPVN5.Location = new System.Drawing.Point(85, 246);
            chbPVN5.Margin = new System.Windows.Forms.Padding(2);
            chbPVN5.Name = "chbPVN5";
            chbPVN5.Size = new System.Drawing.Size(166, 18);
            chbPVN5.TabIndex = 15;
            chbPVN5.Text = "Izmantot PVN kodu 5xx";
            chbPVN5.UseVisualStyleBackColor = true;
            // 
            // chbPVNkred
            // 
            chbPVNkred.AutoSize = true;
            chbPVNkred.Location = new System.Drawing.Point(86, 220);
            chbPVNkred.Margin = new System.Windows.Forms.Padding(2);
            chbPVNkred.Name = "chbPVNkred";
            chbPVNkred.Size = new System.Drawing.Size(416, 18);
            chbPVNkred.TabIndex = 13;
            chbPVNkred.Text = "Kredīta PVN kods ('2xx'), ja bilances kredīta konts ir PVN ('5731')";
            chbPVNkred.UseVisualStyleBackColor = true;
            // 
            // chbPVNdeb
            // 
            chbPVNdeb.AutoSize = true;
            chbPVNdeb.Location = new System.Drawing.Point(86, 194);
            chbPVNdeb.Margin = new System.Windows.Forms.Padding(2);
            chbPVNdeb.Name = "chbPVNdeb";
            chbPVNdeb.Size = new System.Drawing.Size(418, 18);
            chbPVNdeb.TabIndex = 11;
            chbPVNdeb.Text = "Debeta PVN kods ('3xx'), ja bilances debeta konts ir PVN ('5731')";
            chbPVNdeb.UseVisualStyleBackColor = true;
            // 
            // chbPVN
            // 
            chbPVN.AutoSize = true;
            chbPVN.Location = new System.Drawing.Point(66, 115);
            chbPVN.Margin = new System.Windows.Forms.Padding(2);
            chbPVN.Name = "chbPVN";
            chbPVN.Size = new System.Drawing.Size(218, 18);
            chbPVN.TabIndex = 6;
            chbPVN.Text = "Izmantot kontējuma PVN pazīmi";
            chbPVN.UseVisualStyleBackColor = true;
            chbPVN.CheckedChanged += chbPVN_CheckedChanged;
            // 
            // chbIIN
            // 
            chbIIN.AutoSize = true;
            chbIIN.Location = new System.Drawing.Point(66, 29);
            chbIIN.Margin = new System.Windows.Forms.Padding(2);
            chbIIN.Name = "chbIIN";
            chbIIN.Size = new System.Drawing.Size(264, 18);
            chbIIN.TabIndex = 1;
            chbIIN.Text = "Izmantot kontējuma IIN darijuma pazīmi";
            chbIIN.UseVisualStyleBackColor = true;
            chbIIN.CheckedChanged += chbIIN_CheckedChanged;
            // 
            // chbNP
            // 
            chbNP.AutoSize = true;
            chbNP.Location = new System.Drawing.Point(66, 0);
            chbNP.Margin = new System.Windows.Forms.Padding(2);
            chbNP.Name = "chbNP";
            chbNP.Size = new System.Drawing.Size(290, 18);
            chbNP.TabIndex = 0;
            chbNP.Text = "Izmantot kontējuma naudas plūsmas pazīmi";
            chbNP.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(cbPVN5);
            panel1.Controls.Add(cbPVNkred);
            panel1.Controls.Add(cbPVNdeb);
            panel1.Controls.Add(cbPVNizd);
            panel1.Controls.Add(cbPVNien);
            panel1.Controls.Add(cbIINien);
            panel1.Controls.Add(cbIINizd);
            panel1.Controls.Add(chbPVNreqPvn);
            panel1.Controls.Add(chbPVNreqIen);
            panel1.Controls.Add(chbPVNizd);
            panel1.Controls.Add(chbPVNien);
            panel1.Controls.Add(chbIINien);
            panel1.Controls.Add(chbIINizd);
            panel1.Controls.Add(chbPVN5);
            panel1.Controls.Add(chbPVNkred);
            panel1.Controls.Add(chbPVNdeb);
            panel1.Controls.Add(chbPVN);
            panel1.Controls.Add(chbIIN);
            panel1.Controls.Add(chbNP);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.MinimumSize = new System.Drawing.Size(578, 244);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(580, 266);
            panel1.TabIndex = 21;
            // 
            // Form_OpsRules
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(580, 342);
            Controls.Add(panel1);
            Controls.Add(myLabel1);
            Controls.Add(cmClose);
            MinimumSize = new System.Drawing.Size(16, 365);
            Name = "Form_OpsRules";
            Text = "Kontējumu kontrole";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosed += FormOpsRules_FormClosed;
            Load += FormOpsRules_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button cmClose;
        private MyLabel myLabel1;
        private MyMcFlatComboBox cbPVN5;
        private MyMcFlatComboBox cbPVNkred;
        private MyMcFlatComboBox cbPVNdeb;
        private MyMcFlatComboBox cbPVNizd;
        private MyMcFlatComboBox cbPVNien;
        private MyMcFlatComboBox cbIINien;
        private MyMcFlatComboBox cbIINizd;
        private MyCheckBox chbPVNreqPvn;
        private MyCheckBox chbPVNreqIen;
        private MyCheckBox chbPVNizd;
        private MyCheckBox chbPVNien;
        private MyCheckBox chbIINien;
        private MyCheckBox chbIINizd;
        private MyCheckBox chbPVN5;
        private MyCheckBox chbPVNkred;
        private MyCheckBox chbPVNdeb;
        private MyCheckBox chbPVN;
        private MyCheckBox chbIIN;
        private MyCheckBox chbNP;
        private System.Windows.Forms.Panel panel1;
    }
}