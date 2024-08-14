using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_ApgrMT
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
            myLabel1 = new MyLabel();
            lbCM = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
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
            cbAC.ColumnWidths = "100;400";
            cbAC.DataSource = bsAC;
            cbAC.DisplayMember = "AC";
            cbAC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC.DropDownHeight = 270;
            cbAC.DropDownWidth = 519;
            cbAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC.FormattingEnabled = true;
            cbAC.GridLineColor = System.Drawing.Color.LightGray;
            cbAC.GridLineHorizontal = false;
            cbAC.GridLineVertical = false;
            cbAC.IntegralHeight = false;
            cbAC.Location = new System.Drawing.Point(145, 67);
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
            tbSD.Location = new System.Drawing.Point(145, 20);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(80, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 20);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 5;
            label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(230, 20);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(80, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 69);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 6;
            label2.Text = "Konts:";
            // 
            // lbACName
            // 
            lbACName.Location = new System.Drawing.Point(150, 92);
            lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbACName.Name = "lbACName";
            lbACName.Size = new System.Drawing.Size(332, 18);
            lbACName.TabIndex = 9;
            lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(341, 189);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(133, 63);
            cmDoIt.TabIndex = 4;
            cmDoIt.Text = "Taisīt atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // myLabel1
            // 
            myLabel1.AutoSize = true;
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(261, 125);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(8);
            myLabel1.Size = new System.Drawing.Size(211, 50);
            myLabel1.TabIndex = 8;
            myLabel1.Text = "Lai dabūtu atskaiti par visiem \r\nkontiem, lodzinā jāieliek '*'";
            // 
            // lbCM
            // 
            lbCM.BackColor = System.Drawing.SystemColors.Control;
            lbCM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbCM.FormattingEnabled = true;
            lbCM.ItemHeight = 16;
            lbCM.Items.AddRange(new object[] { "Pa mēnešiem", "Pa mēnešiem pa nozarēm 1", "Pa mēnešiem pa nozarēm 2", "Debetam un daudzumi", "Kredītam un daudzumi" });
            lbCM.Location = new System.Drawing.Point(15, 125);
            lbCM.Margin = new System.Windows.Forms.Padding(2);
            lbCM.Name = "lbCM";
            lbCM.Size = new System.Drawing.Size(234, 98);
            lbCM.TabIndex = 10;
            lbCM.MouseDoubleClick += lbCM_MouseDoubleClick;
            // 
            // FormRep_ApgrMT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 267);
            CloseOnEscape = true;
            Controls.Add(lbCM);
            Controls.Add(myLabel1);
            Controls.Add(cmDoIt);
            Controls.Add(lbACName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSD);
            Controls.Add(cbAC);
            Name = "FormRep_ApgrMT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Apgrozijumu pārskata parametri";
            Load += FormRepApgrMT_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
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
        private MyLabel myLabel1;
        private System.Windows.Forms.ListBox lbCM;
    }
}