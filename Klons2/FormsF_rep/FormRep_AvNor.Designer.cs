﻿using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_AvNor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRep_AvNor));
            cbAC = new MyMcFlatComboBox();
            bsAC = new MyBindingSource(components);
            tbSD = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbED = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            lbACName = new System.Windows.Forms.Label();
            cmDoIt = new System.Windows.Forms.Button();
            cbClid = new MyMcFlatComboBox();
            bsClid = new MyBindingSource(components);
            label3 = new System.Windows.Forms.Label();
            lbClName = new System.Windows.Forms.Label();
            lbCm = new System.Windows.Forms.ListBox();
            tbNr = new MyTextBox();
            label4 = new System.Windows.Forms.Label();
            myLabel1 = new MyLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbPrevMonth = new System.Windows.Forms.ToolStripButton();
            tsbNextMonth = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbAC
            // 
            cbAC.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC.ColumnWidths = "80;300";
            cbAC.DataSource = bsAC;
            cbAC.DisplayMember = "AC";
            cbAC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC.DropDownHeight = 270;
            cbAC.DropDownWidth = 399;
            cbAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC.FormattingEnabled = true;
            cbAC.GridLineColor = System.Drawing.Color.LightGray;
            cbAC.GridLineHorizontal = false;
            cbAC.GridLineVertical = false;
            cbAC.IntegralHeight = false;
            cbAC.Location = new System.Drawing.Point(162, 51);
            cbAC.Margin = new System.Windows.Forms.Padding(2);
            cbAC.MaxDropDownItems = 15;
            cbAC.Name = "cbAC";
            cbAC.Size = new System.Drawing.Size(116, 24);
            cbAC.TabIndex = 2;
            cbAC.ValueMember = "AC";
            cbAC.SelectedIndexChanged += cbAC_SelectedIndexChanged;
            cbAC.TextChanged += cbAC_TextChanged;
            cbAC.KeyDown += Control_KeyDown;
            cbAC.MouseDoubleClick += cbClid_MouseDoubleClick;
            // 
            // bsAC
            // 
            bsAC.DataMember = "AcP21";
            bsAC.MyDataSource = "KlonsData";
            bsAC.Name2 = "bsAC";
            // 
            // tbSD
            // 
            tbSD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSD.IsDate = true;
            tbSD.Location = new System.Drawing.Point(162, 18);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(90, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 18);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 7;
            label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(258, 18);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(90, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 53);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 8;
            label2.Text = "Konts:";
            // 
            // lbACName
            // 
            lbACName.Location = new System.Drawing.Point(283, 53);
            lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbACName.Name = "lbACName";
            lbACName.Size = new System.Drawing.Size(376, 22);
            lbACName.TabIndex = 9;
            lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(396, 158);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(115, 63);
            cmDoIt.TabIndex = 5;
            cmDoIt.Text = "Taisīt atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // cbClid
            // 
            cbClid.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbClid.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            cbClid.ColumnWidths = "120;300";
            cbClid.DataSource = bsClid;
            cbClid.DisplayMember = "clid";
            cbClid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbClid.DropDownHeight = 270;
            cbClid.DropDownWidth = 439;
            cbClid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbClid.FormattingEnabled = true;
            cbClid.GridLineColor = System.Drawing.Color.LightGray;
            cbClid.GridLineHorizontal = false;
            cbClid.GridLineVertical = false;
            cbClid.IntegralHeight = false;
            cbClid.Location = new System.Drawing.Point(162, 85);
            cbClid.Margin = new System.Windows.Forms.Padding(2);
            cbClid.MaxDropDownItems = 15;
            cbClid.Name = "cbClid";
            cbClid.Size = new System.Drawing.Size(116, 24);
            cbClid.TabIndex = 3;
            cbClid.ValueMember = "clid";
            cbClid.SelectedIndexChanged += cbClid_SelectedIndexChanged;
            cbClid.TextChanged += cbClid_TextChanged;
            cbClid.KeyDown += Control_KeyDown;
            cbClid.MouseDoubleClick += cbClid_MouseDoubleClick;
            // 
            // bsClid
            // 
            bsClid.DataMember = "Persons";
            bsClid.MyDataSource = "KlonsData";
            bsClid.Name2 = "bsClid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 91);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 17);
            label3.TabIndex = 10;
            label3.Text = "Persona:";
            // 
            // lbClName
            // 
            lbClName.Location = new System.Drawing.Point(283, 89);
            lbClName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbClName.Name = "lbClName";
            lbClName.Size = new System.Drawing.Size(376, 22);
            lbClName.TabIndex = 11;
            lbClName.Text = "Konts:";
            // 
            // lbCm
            // 
            lbCm.BackColor = System.Drawing.SystemColors.Control;
            lbCm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbCm.FormattingEnabled = true;
            lbCm.ItemHeight = 16;
            lbCm.Items.AddRange(new object[] { "Avansa norēķina atskaite 1", "Avansa norēķina atskaite 2" });
            lbCm.Location = new System.Drawing.Point(11, 155);
            lbCm.Margin = new System.Windows.Forms.Padding(2);
            lbCm.Name = "lbCm";
            lbCm.Size = new System.Drawing.Size(364, 50);
            lbCm.TabIndex = 6;
            lbCm.MouseDoubleClick += lbCm_MouseDoubleClick;
            // 
            // tbNr
            // 
            tbNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbNr.Location = new System.Drawing.Point(162, 119);
            tbNr.Margin = new System.Windows.Forms.Padding(2);
            tbNr.Name = "tbNr";
            tbNr.Size = new System.Drawing.Size(81, 23);
            tbNr.TabIndex = 4;
            tbNr.KeyDown += Control_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 119);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 17);
            label4.TabIndex = 12;
            label4.Text = "Numurs:";
            // 
            // myLabel1
            // 
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(11, 218);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(2);
            myLabel1.Size = new System.Drawing.Size(367, 46);
            myLabel1.TabIndex = 13;
            myLabel1.Text = "Dokumentā avansa norēķina persona jāuzrāda laukā Nor.pers.";
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbPrevMonth, tsbNextMonth });
            toolStrip1.Location = new System.Drawing.Point(358, 17);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(59, 28);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrevMonth
            // 
            tsbPrevMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbPrevMonth.Image = (System.Drawing.Image)resources.GetObject("tsbPrevMonth.Image");
            tsbPrevMonth.Margin = new System.Windows.Forms.Padding(0);
            tsbPrevMonth.Name = "tsbPrevMonth";
            tsbPrevMonth.RightToLeftAutoMirrorImage = true;
            tsbPrevMonth.Size = new System.Drawing.Size(28, 28);
            tsbPrevMonth.Text = "iepriekšējais mēnesis";
            tsbPrevMonth.Click += tsbPrevMonth_Click;
            // 
            // tsbNextMonth
            // 
            tsbNextMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbNextMonth.Image = (System.Drawing.Image)resources.GetObject("tsbNextMonth.Image");
            tsbNextMonth.Margin = new System.Windows.Forms.Padding(0);
            tsbNextMonth.Name = "tsbNextMonth";
            tsbNextMonth.RightToLeftAutoMirrorImage = true;
            tsbNextMonth.Size = new System.Drawing.Size(28, 28);
            tsbNextMonth.Text = "nākošais mēnesis";
            tsbNextMonth.ToolTipText = "Iet uz nākošo";
            tsbNextMonth.Click += tsbNextMonth_Click;
            // 
            // FormRep_AvNor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(524, 278);
            CloseOnEscape = true;
            Controls.Add(toolStrip1);
            Controls.Add(myLabel1);
            Controls.Add(lbCm);
            Controls.Add(cmDoIt);
            Controls.Add(lbClName);
            Controls.Add(lbACName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbNr);
            Controls.Add(tbSD);
            Controls.Add(cbClid);
            Controls.Add(cbAC);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormRep_AvNor";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Avansa norēķins";
            Load += FormRepKoresp1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyMcFlatComboBox cbAC;
        private MyBindingSource bsAC;
        private MyTextBox tbSD;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbACName;
        private System.Windows.Forms.Button cmDoIt;
        private MyMcFlatComboBox cbClid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbClName;
        private MyBindingSource bsClid;
        private System.Windows.Forms.ListBox lbCm;
        private MyTextBox tbNr;
        private System.Windows.Forms.Label label4;
        private MyLabel myLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrevMonth;
        private System.Windows.Forms.ToolStripButton tsbNextMonth;
    }
}