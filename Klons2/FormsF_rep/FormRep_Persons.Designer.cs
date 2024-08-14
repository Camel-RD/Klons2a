using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Persons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRep_Persons));
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
            myLabel1 = new MyLabel();
            cmShowTable = new System.Windows.Forms.Button();
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
            cbAC.Location = new System.Drawing.Point(161, 40);
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
            tbSD.Location = new System.Drawing.Point(161, 9);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(90, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 9);
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
            tbED.Location = new System.Drawing.Point(256, 9);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(90, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 43);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 8;
            label2.Text = "Konts:";
            // 
            // lbACName
            // 
            lbACName.Location = new System.Drawing.Point(282, 43);
            lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbACName.Name = "lbACName";
            lbACName.Size = new System.Drawing.Size(376, 22);
            lbACName.TabIndex = 11;
            lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(417, 109);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(150, 57);
            cmDoIt.TabIndex = 4;
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
            cbClid.Location = new System.Drawing.Point(161, 71);
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
            label3.Location = new System.Drawing.Point(11, 76);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 17);
            label3.TabIndex = 9;
            label3.Text = "Persona:";
            // 
            // lbClName
            // 
            lbClName.Location = new System.Drawing.Point(282, 75);
            lbClName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbClName.Name = "lbClName";
            lbClName.Size = new System.Drawing.Size(376, 22);
            lbClName.TabIndex = 12;
            lbClName.Text = "Konts:";
            // 
            // lbCm
            // 
            lbCm.BackColor = System.Drawing.SystemColors.Control;
            lbCm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbCm.FormattingEnabled = true;
            lbCm.ItemHeight = 16;
            lbCm.Items.AddRange(new object[] { "Debitoru, kreditoru apgrozijumu pārskats", "Debitoru, kreditoru apgrozijumu pārskats pa kontiem", "Rēķinu saraksts", "Rēķinu un maksājumu saraksts", "Neapmaksātie rēķini", "Neapmaksātie rēķini - līdz norādītajam datumam" });
            lbCm.Location = new System.Drawing.Point(11, 109);
            lbCm.Margin = new System.Windows.Forms.Padding(2);
            lbCm.Name = "lbCm";
            lbCm.Size = new System.Drawing.Size(380, 114);
            lbCm.TabIndex = 6;
            lbCm.MouseDoubleClick += lbCm_MouseDoubleClick;
            // 
            // myLabel1
            // 
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(7, 244);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(2);
            myLabel1.Size = new System.Drawing.Size(540, 79);
            myLabel1.TabIndex = 10;
            myLabel1.Text = resources.GetString("myLabel1.Text");
            // 
            // cmShowTable
            // 
            cmShowTable.Location = new System.Drawing.Point(417, 174);
            cmShowTable.Margin = new System.Windows.Forms.Padding(2);
            cmShowTable.Name = "cmShowTable";
            cmShowTable.Size = new System.Drawing.Size(150, 57);
            cmShowTable.TabIndex = 5;
            cmShowTable.Text = "Tabula";
            cmShowTable.UseVisualStyleBackColor = true;
            cmShowTable.Click += cmShowTable_Click;
            cmShowTable.KeyDown += Control_KeyDown;
            // 
            // FormRep_Persons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(667, 332);
            CloseOnEscape = true;
            Controls.Add(myLabel1);
            Controls.Add(lbCm);
            Controls.Add(cmShowTable);
            Controls.Add(cmDoIt);
            Controls.Add(lbClName);
            Controls.Add(lbACName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSD);
            Controls.Add(cbClid);
            Controls.Add(cbAC);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormRep_Persons";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Personu pārskati";
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
        private MyMcFlatComboBox cbClid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbClName;
        private MyBindingSource bsClid;
        private System.Windows.Forms.ListBox lbCm;
        private MyLabel myLabel1;
        private System.Windows.Forms.Button cmShowTable;
    }
}