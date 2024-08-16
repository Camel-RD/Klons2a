using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_KasesGr
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
            cbAC = new MyMcFlatComboBox();
            bsAC = new MyBindingSource(components);
            tbSD = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbED = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            lbACName = new System.Windows.Forms.Label();
            cmDoIt = new System.Windows.Forms.Button();
            bsClid = new MyBindingSource(components);
            lbCm = new System.Windows.Forms.ListBox();
            tbNr = new MyTextBox();
            label4 = new System.Windows.Forms.Label();
            cmNrKIEO = new System.Windows.Forms.Button();
            cmNrKIZO = new System.Windows.Forms.Button();
            tbNr2 = new MyTextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).BeginInit();
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
            cbAC.Location = new System.Drawing.Point(143, 53);
            cbAC.Margin = new System.Windows.Forms.Padding(2);
            cbAC.MaxDropDownItems = 15;
            cbAC.Name = "cbAC";
            cbAC.Size = new System.Drawing.Size(104, 24);
            cbAC.TabIndex = 2;
            cbAC.ValueMember = "AC";
            cbAC.SelectedIndexChanged += cbAC_SelectedIndexChanged;
            cbAC.TextChanged += cbAC_TextChanged;
            cbAC.KeyDown += Control_KeyDown;
            cbAC.MouseDoubleClick += cbAC_MouseDoubleClick;
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
            tbSD.Location = new System.Drawing.Point(143, 19);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(80, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 19);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 9;
            label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(228, 19);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(80, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 55);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 10;
            label2.Text = "Konts:";
            // 
            // lbACName
            // 
            lbACName.Location = new System.Drawing.Point(251, 55);
            lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbACName.Name = "lbACName";
            lbACName.Size = new System.Drawing.Size(334, 18);
            lbACName.TabIndex = 11;
            lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(305, 146);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(133, 63);
            cmDoIt.TabIndex = 4;
            cmDoIt.Text = "Taisīt atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // bsClid
            // 
            bsClid.DataMember = "Persons";
            bsClid.MyDataSource = "KlonsData";
            bsClid.Name2 = "bsClid";
            // 
            // lbCm
            // 
            lbCm.BackColor = System.Drawing.SystemColors.Control;
            lbCm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbCm.FormattingEnabled = true;
            lbCm.ItemHeight = 16;
            lbCm.Items.AddRange(new object[] { "Kases grāmata", "Kases grāmata, visas dienas kopā", "Ieņēmumu orderi", "Izdevumu orderi" });
            lbCm.Location = new System.Drawing.Point(13, 128);
            lbCm.Margin = new System.Windows.Forms.Padding(2);
            lbCm.Name = "lbCm";
            lbCm.Size = new System.Drawing.Size(257, 82);
            lbCm.TabIndex = 3;
            lbCm.MouseDoubleClick += lbCm_MouseDoubleClick;
            // 
            // tbNr
            // 
            tbNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbNr.Location = new System.Drawing.Point(266, 91);
            tbNr.Margin = new System.Windows.Forms.Padding(2);
            tbNr.Name = "tbNr";
            tbNr.Size = new System.Drawing.Size(72, 23);
            tbNr.TabIndex = 5;
            tbNr.Text = "1";
            tbNr.KeyDown += Control_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 93);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(249, 17);
            label4.TabIndex = 12;
            label4.Text = "Kases grāmatas pirmās lapas numurs:";
            // 
            // cmNrKIEO
            // 
            cmNrKIEO.Location = new System.Drawing.Point(13, 255);
            cmNrKIEO.Margin = new System.Windows.Forms.Padding(2);
            cmNrKIEO.Name = "cmNrKIEO";
            cmNrKIEO.Size = new System.Drawing.Size(133, 63);
            cmNrKIEO.TabIndex = 7;
            cmNrKIEO.Text = "Pārnumuret kases ieņēmumu orderus";
            cmNrKIEO.UseVisualStyleBackColor = true;
            cmNrKIEO.Click += cmNrKIEO_Click;
            cmNrKIEO.KeyDown += Control_KeyDown;
            // 
            // cmNrKIZO
            // 
            cmNrKIZO.Location = new System.Drawing.Point(158, 255);
            cmNrKIZO.Margin = new System.Windows.Forms.Padding(2);
            cmNrKIZO.Name = "cmNrKIZO";
            cmNrKIZO.Size = new System.Drawing.Size(133, 63);
            cmNrKIZO.TabIndex = 8;
            cmNrKIZO.Text = "Pārnumurēt kases izdevumu orderus";
            cmNrKIZO.UseVisualStyleBackColor = true;
            cmNrKIZO.Click += cmNrKIZO_Click;
            cmNrKIZO.KeyDown += Control_KeyDown;
            // 
            // tbNr2
            // 
            tbNr2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbNr2.Location = new System.Drawing.Point(150, 225);
            tbNr2.Margin = new System.Windows.Forms.Padding(2);
            tbNr2.Name = "tbNr2";
            tbNr2.Size = new System.Drawing.Size(72, 23);
            tbNr2.TabIndex = 6;
            tbNr2.Text = "1";
            tbNr2.KeyDown += Control_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 226);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 17);
            label3.TabIndex = 13;
            label3.Text = "Numerāciju sākt ar:";
            // 
            // FormRep_KasesGr
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(595, 330);
            CloseOnEscape = true;
            Controls.Add(lbCm);
            Controls.Add(cmNrKIZO);
            Controls.Add(cmNrKIEO);
            Controls.Add(cmDoIt);
            Controls.Add(lbACName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbNr2);
            Controls.Add(tbNr);
            Controls.Add(tbSD);
            Controls.Add(cbAC);
            Name = "FormRep_KasesGr";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Kases grāmata";
            Load += FormRepKoresp1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).EndInit();
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
        private MyBindingSource bsClid;
        private System.Windows.Forms.ListBox lbCm;
        private MyTextBox tbNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmNrKIEO;
        private System.Windows.Forms.Button cmNrKIZO;
        private MyTextBox tbNr2;
        private System.Windows.Forms.Label label3;
    }
}