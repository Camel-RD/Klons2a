using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_ApgrFull
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
            cbAC1 = new MyMcFlatComboBox();
            bsAC1 = new MyBindingSource(components);
            tbSD = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbED = new MyTextBox();
            cmDoIt = new System.Windows.Forms.Button();
            cbAC2 = new MyMcFlatComboBox();
            bsAC2 = new MyBindingSource(components);
            cbAC3 = new MyMcFlatComboBox();
            bsAC3 = new MyBindingSource(components);
            cbAC4 = new MyMcFlatComboBox();
            bsAC4 = new MyBindingSource(components);
            cbAC5 = new MyMcFlatComboBox();
            bsAC5 = new MyBindingSource(components);
            cbClid = new MyMcFlatComboBox();
            bsClid = new MyBindingSource(components);
            myLabel1 = new MyLabel();
            chAC1 = new MyCheckBox();
            chAC2 = new MyCheckBox();
            chAC3 = new MyCheckBox();
            chAC4 = new MyCheckBox();
            chAC5 = new MyCheckBox();
            chCl = new MyCheckBox();
            ((System.ComponentModel.ISupportInitialize)bsAC1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAC2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAC3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAC4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAC5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).BeginInit();
            SuspendLayout();
            // 
            // cbAC1
            // 
            cbAC1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC1.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC1.ColumnWidths = "80;300";
            cbAC1.DataSource = bsAC1;
            cbAC1.DisplayMember = "AC";
            cbAC1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC1.DropDownHeight = 270;
            cbAC1.DropDownWidth = 399;
            cbAC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC1.FormattingEnabled = true;
            cbAC1.GridLineColor = System.Drawing.Color.LightGray;
            cbAC1.GridLineHorizontal = false;
            cbAC1.GridLineVertical = false;
            cbAC1.IntegralHeight = false;
            cbAC1.Location = new System.Drawing.Point(43, 63);
            cbAC1.Margin = new System.Windows.Forms.Padding(2);
            cbAC1.MaxDropDownItems = 15;
            cbAC1.Name = "cbAC1";
            cbAC1.Size = new System.Drawing.Size(104, 24);
            cbAC1.TabIndex = 2;
            cbAC1.ValueMember = "AC";
            cbAC1.KeyDown += Control_KeyDown;
            cbAC1.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsAC1
            // 
            bsAC1.DataMember = "AcP21";
            bsAC1.MyDataSource = "KlonsData";
            bsAC1.Name2 = "bsAC1";
            // 
            // tbSD
            // 
            tbSD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSD.IsDate = true;
            tbSD.Location = new System.Drawing.Point(156, 20);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(80, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 20);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 15;
            label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(242, 20);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(80, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(339, 240);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(133, 63);
            cmDoIt.TabIndex = 14;
            cmDoIt.Text = "Taisīt atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // cbAC2
            // 
            cbAC2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC2.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC2.ColumnWidths = "80;300";
            cbAC2.DataSource = bsAC2;
            cbAC2.DisplayMember = "AC";
            cbAC2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC2.DropDownHeight = 270;
            cbAC2.DropDownWidth = 399;
            cbAC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC2.FormattingEnabled = true;
            cbAC2.GridLineColor = System.Drawing.Color.LightGray;
            cbAC2.GridLineHorizontal = false;
            cbAC2.GridLineVertical = false;
            cbAC2.IntegralHeight = false;
            cbAC2.Location = new System.Drawing.Point(43, 90);
            cbAC2.Margin = new System.Windows.Forms.Padding(2);
            cbAC2.MaxDropDownItems = 15;
            cbAC2.Name = "cbAC2";
            cbAC2.Size = new System.Drawing.Size(104, 24);
            cbAC2.TabIndex = 4;
            cbAC2.ValueMember = "AC";
            cbAC2.KeyDown += Control_KeyDown;
            cbAC2.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsAC2
            // 
            bsAC2.DataMember = "AcP21";
            bsAC2.MyDataSource = "KlonsData";
            bsAC2.Name2 = "bsAC2";
            // 
            // cbAC3
            // 
            cbAC3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC3.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC3.ColumnWidths = "80;300";
            cbAC3.DataSource = bsAC3;
            cbAC3.DisplayMember = "idx";
            cbAC3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC3.DropDownHeight = 270;
            cbAC3.DropDownWidth = 399;
            cbAC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC3.FormattingEnabled = true;
            cbAC3.GridLineColor = System.Drawing.Color.LightGray;
            cbAC3.GridLineHorizontal = false;
            cbAC3.GridLineVertical = false;
            cbAC3.IntegralHeight = false;
            cbAC3.Location = new System.Drawing.Point(43, 118);
            cbAC3.Margin = new System.Windows.Forms.Padding(2);
            cbAC3.MaxDropDownItems = 15;
            cbAC3.Name = "cbAC3";
            cbAC3.Size = new System.Drawing.Size(104, 24);
            cbAC3.TabIndex = 6;
            cbAC3.ValueMember = "idx";
            cbAC3.KeyDown += Control_KeyDown;
            cbAC3.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsAC3
            // 
            bsAC3.DataMember = "Acp23";
            bsAC3.MyDataSource = "KlonsData";
            bsAC3.Name2 = "bsAC3";
            // 
            // cbAC4
            // 
            cbAC4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC4.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC4.ColumnWidths = "80;300";
            cbAC4.DataSource = bsAC4;
            cbAC4.DisplayMember = "idx";
            cbAC4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC4.DropDownHeight = 270;
            cbAC4.DropDownWidth = 399;
            cbAC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC4.FormattingEnabled = true;
            cbAC4.GridLineColor = System.Drawing.Color.LightGray;
            cbAC4.GridLineHorizontal = false;
            cbAC4.GridLineVertical = false;
            cbAC4.IntegralHeight = false;
            cbAC4.Location = new System.Drawing.Point(43, 145);
            cbAC4.Margin = new System.Windows.Forms.Padding(2);
            cbAC4.MaxDropDownItems = 15;
            cbAC4.Name = "cbAC4";
            cbAC4.Size = new System.Drawing.Size(104, 24);
            cbAC4.TabIndex = 8;
            cbAC4.ValueMember = "idx";
            cbAC4.KeyDown += Control_KeyDown;
            cbAC4.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsAC4
            // 
            bsAC4.DataMember = "AcP24";
            bsAC4.MyDataSource = "KlonsData";
            bsAC4.Name2 = "bsAC4";
            // 
            // cbAC5
            // 
            cbAC5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC5.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC5.ColumnWidths = "80;300";
            cbAC5.DataSource = bsAC5;
            cbAC5.DisplayMember = "idx";
            cbAC5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC5.DropDownHeight = 270;
            cbAC5.DropDownWidth = 399;
            cbAC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC5.FormattingEnabled = true;
            cbAC5.GridLineColor = System.Drawing.Color.LightGray;
            cbAC5.GridLineHorizontal = false;
            cbAC5.GridLineVertical = false;
            cbAC5.IntegralHeight = false;
            cbAC5.Location = new System.Drawing.Point(43, 172);
            cbAC5.Margin = new System.Windows.Forms.Padding(2);
            cbAC5.MaxDropDownItems = 15;
            cbAC5.Name = "cbAC5";
            cbAC5.Size = new System.Drawing.Size(104, 24);
            cbAC5.TabIndex = 10;
            cbAC5.ValueMember = "idx";
            cbAC5.KeyDown += Control_KeyDown;
            cbAC5.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsAC5
            // 
            bsAC5.DataMember = "Acp25";
            bsAC5.MyDataSource = "KlonsData";
            bsAC5.Name2 = "bsAC5";
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
            cbClid.DisplayMember = "ClId";
            cbClid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbClid.DropDownHeight = 270;
            cbClid.DropDownWidth = 439;
            cbClid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbClid.FormattingEnabled = true;
            cbClid.GridLineColor = System.Drawing.Color.LightGray;
            cbClid.GridLineHorizontal = false;
            cbClid.GridLineVertical = false;
            cbClid.IntegralHeight = false;
            cbClid.Location = new System.Drawing.Point(43, 199);
            cbClid.Margin = new System.Windows.Forms.Padding(2);
            cbClid.MaxDropDownItems = 15;
            cbClid.Name = "cbClid";
            cbClid.Size = new System.Drawing.Size(104, 24);
            cbClid.TabIndex = 12;
            cbClid.ValueMember = "ClId";
            cbClid.KeyDown += Control_KeyDown;
            cbClid.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // bsClid
            // 
            bsClid.DataMember = "Persons";
            bsClid.MyDataSource = "KlonsData";
            bsClid.Name2 = "bsClid";
            // 
            // myLabel1
            // 
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(9, 240);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(2);
            myLabel1.Size = new System.Drawing.Size(308, 70);
            myLabel1.TabIndex = 16;
            myLabel1.Text = "Kontējuma pazīmju filtrēšanai var izmantot *.\r\nPazīmes ignorēšanai ievades lauku atstājam tukšu.";
            // 
            // chAC1
            // 
            chAC1.AutoSize = true;
            chAC1.Checked = true;
            chAC1.CheckState = System.Windows.Forms.CheckState.Checked;
            chAC1.Location = new System.Drawing.Point(156, 66);
            chAC1.Margin = new System.Windows.Forms.Padding(2);
            chAC1.Name = "chAC1";
            chAC1.Size = new System.Drawing.Size(111, 18);
            chAC1.TabIndex = 3;
            chAC1.Text = "Bilances konts";
            chAC1.UseVisualStyleBackColor = true;
            // 
            // chAC2
            // 
            chAC2.AutoSize = true;
            chAC2.Location = new System.Drawing.Point(156, 93);
            chAC2.Margin = new System.Windows.Forms.Padding(2);
            chAC2.Name = "chAC2";
            chAC2.Size = new System.Drawing.Size(162, 18);
            chAC2.TabIndex = 5;
            chAC2.Text = "Naudas plūsmas konts";
            chAC2.UseVisualStyleBackColor = true;
            // 
            // chAC3
            // 
            chAC3.AutoSize = true;
            chAC3.Location = new System.Drawing.Point(156, 121);
            chAC3.Margin = new System.Windows.Forms.Padding(2);
            chAC3.Name = "chAC3";
            chAC3.Size = new System.Drawing.Size(211, 18);
            chAC3.TabIndex = 7;
            chAC3.Text = "IIN ieņēmumu / izdevumu kods";
            chAC3.UseVisualStyleBackColor = true;
            // 
            // chAC4
            // 
            chAC4.AutoSize = true;
            chAC4.Location = new System.Drawing.Point(156, 148);
            chAC4.Margin = new System.Windows.Forms.Padding(2);
            chAC4.Name = "chAC4";
            chAC4.Size = new System.Drawing.Size(131, 18);
            chAC4.TabIndex = 9;
            chAC4.Text = "Nozare / produkts";
            chAC4.UseVisualStyleBackColor = true;
            // 
            // chAC5
            // 
            chAC5.AutoSize = true;
            chAC5.Checked = true;
            chAC5.CheckState = System.Windows.Forms.CheckState.Checked;
            chAC5.Location = new System.Drawing.Point(156, 175);
            chAC5.Margin = new System.Windows.Forms.Padding(2);
            chAC5.Name = "chAC5";
            chAC5.Size = new System.Drawing.Size(84, 18);
            chAC5.TabIndex = 11;
            chAC5.Text = "PVN kods";
            chAC5.UseVisualStyleBackColor = true;
            // 
            // chCl
            // 
            chCl.AutoSize = true;
            chCl.Location = new System.Drawing.Point(156, 202);
            chCl.Margin = new System.Windows.Forms.Padding(2);
            chCl.Name = "chCl";
            chCl.Size = new System.Drawing.Size(74, 18);
            chCl.TabIndex = 13;
            chCl.Text = "Persona";
            chCl.UseVisualStyleBackColor = true;
            // 
            // FormRep_ApgrFull
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(486, 316);
            CloseOnEscape = true;
            Controls.Add(chCl);
            Controls.Add(chAC5);
            Controls.Add(chAC4);
            Controls.Add(chAC3);
            Controls.Add(chAC2);
            Controls.Add(chAC1);
            Controls.Add(myLabel1);
            Controls.Add(cmDoIt);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSD);
            Controls.Add(cbClid);
            Controls.Add(cbAC5);
            Controls.Add(cbAC4);
            Controls.Add(cbAC3);
            Controls.Add(cbAC2);
            Controls.Add(cbAC1);
            Name = "FormRep_ApgrFull";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Apgrozijumu pārskata parametri";
            Load += FormRepApgr1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAC2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAC3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAC4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAC5).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyMcFlatComboBox cbAC1;
        private MyBindingSource bsAC1;
        private MyTextBox tbSD;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbED;
        private System.Windows.Forms.Button cmDoIt;
        private MyMcFlatComboBox cbAC2;
        private MyMcFlatComboBox cbAC3;
        private MyMcFlatComboBox cbAC4;
        private MyMcFlatComboBox cbAC5;
        private MyMcFlatComboBox cbClid;
        private MyBindingSource bsAC2;
        private MyBindingSource bsAC3;
        private MyBindingSource bsAC4;
        private MyBindingSource bsAC5;
        private MyBindingSource bsClid;
        private MyLabel myLabel1;
        private MyCheckBox chAC1;
        private MyCheckBox chAC2;
        private MyCheckBox chAC3;
        private MyCheckBox chAC4;
        private MyCheckBox chAC5;
        private MyCheckBox chCl;
    }
}