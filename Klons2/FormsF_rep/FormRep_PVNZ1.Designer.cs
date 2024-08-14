using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_PVNZ1
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
            MyMcComboBox.MyItem myItem1 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem2 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem3 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem4 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem5 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem6 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem7 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem8 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem9 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem10 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem11 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem12 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem13 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem14 = new MyMcComboBox.MyItem();
            bsAC = new MyBindingSource(components);
            label1 = new System.Windows.Forms.Label();
            cmDoIt = new System.Windows.Forms.Button();
            cbYear = new MyMcFlatComboBox();
            label2 = new System.Windows.Forms.Label();
            cbMonth = new MyMcFlatComboBox();
            tbPageNr = new MyTextBox();
            tbRowNr = new MyTextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
            SuspendLayout();
            // 
            // bsAC
            // 
            bsAC.DataMember = "AcP21";
            bsAC.MyDataSource = "KlonsData";
            bsAC.Name2 = "bsAC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 38);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 17);
            label1.TabIndex = 5;
            label1.Text = "Gads:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(277, 125);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(133, 63);
            cmDoIt.TabIndex = 4;
            cmDoIt.Text = "Taisīt atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // cbYear
            // 
            cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYear.ColumnNames = new string[]
    {
    "col1"
    };
            cbYear.ColumnWidths = "52";
            cbYear.DisplayMember = "col1";
            cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYear.DropDownHeight = 144;
            cbYear.DropDownWidth = 71;
            cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYear.FormattingEnabled = true;
            cbYear.GridLineColor = System.Drawing.Color.LightGray;
            cbYear.GridLineHorizontal = false;
            cbYear.GridLineVertical = false;
            cbYear.IntegralHeight = false;
            myItem1.Col1 = "2014";
            myItem2.Col1 = "2015";
            cbYear.Items.AddRange(new object[] { myItem1, myItem2 });
            cbYear.ItemStrings = new string[]
    {
    "2014",
    "2015"
    };
            cbYear.Location = new System.Drawing.Point(70, 36);
            cbYear.Margin = new System.Windows.Forms.Padding(2);
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(71, 24);
            cbYear.TabIndex = 0;
            cbYear.ValueMember = "col1";
            cbYear.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(151, 38);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 17);
            label2.TabIndex = 6;
            label2.Text = "mēnesis:";
            // 
            // cbMonth
            // 
            cbMonth.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbMonth.ColumnNames = new string[]
    {
    "col1"
    };
            cbMonth.ColumnWidths = "33";
            cbMonth.DisplayMember = "col1";
            cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbMonth.DropDownHeight = 216;
            cbMonth.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbMonth.DropDownWidth = 52;
            cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbMonth.FormattingEnabled = true;
            cbMonth.GridLineColor = System.Drawing.Color.LightGray;
            cbMonth.GridLineHorizontal = false;
            cbMonth.GridLineVertical = false;
            cbMonth.IntegralHeight = false;
            myItem3.Col1 = "01";
            myItem4.Col1 = "02";
            myItem5.Col1 = "03";
            myItem6.Col1 = "04";
            myItem7.Col1 = "05";
            myItem8.Col1 = "06";
            myItem9.Col1 = "07";
            myItem10.Col1 = "08";
            myItem11.Col1 = "09";
            myItem12.Col1 = "10";
            myItem13.Col1 = "11";
            myItem14.Col1 = "12";
            cbMonth.Items.AddRange(new object[] { myItem3, myItem4, myItem5, myItem6, myItem7, myItem8, myItem9, myItem10, myItem11, myItem12, myItem13, myItem14 });
            cbMonth.ItemStrings = new string[]
    {
    "01",
    "02",
    "03",
    "04",
    "05",
    "06",
    "07",
    "08",
    "09",
    "10",
    "11",
    "12"
    };
            cbMonth.Location = new System.Drawing.Point(217, 36);
            cbMonth.Margin = new System.Windows.Forms.Padding(2);
            cbMonth.MaxDropDownItems = 12;
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new System.Drawing.Size(52, 24);
            cbMonth.TabIndex = 1;
            cbMonth.ValueMember = "col1";
            cbMonth.KeyDown += Control_KeyDown;
            // 
            // tbPageNr
            // 
            tbPageNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPageNr.Location = new System.Drawing.Point(151, 81);
            tbPageNr.Margin = new System.Windows.Forms.Padding(2);
            tbPageNr.Name = "tbPageNr";
            tbPageNr.Size = new System.Drawing.Size(60, 23);
            tbPageNr.TabIndex = 2;
            tbPageNr.Text = "1";
            tbPageNr.KeyDown += Control_KeyDown;
            // 
            // tbRowNr
            // 
            tbRowNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRowNr.Location = new System.Drawing.Point(151, 117);
            tbRowNr.Margin = new System.Windows.Forms.Padding(2);
            tbRowNr.Name = "tbRowNr";
            tbRowNr.Size = new System.Drawing.Size(60, 23);
            tbRowNr.TabIndex = 3;
            tbRowNr.Text = "1";
            tbRowNr.KeyDown += Control_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 82);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 17);
            label3.TabIndex = 7;
            label3.Text = "Pirmās lapas nr.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 118);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 17);
            label4.TabIndex = 8;
            label4.Text = "Pirmā ieraksta nr.:";
            // 
            // FormRep_PVNZ1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(426, 214);
            CloseOnEscape = true;
            Controls.Add(tbRowNr);
            Controls.Add(tbPageNr);
            Controls.Add(cbMonth);
            Controls.Add(cbYear);
            Controls.Add(cmDoIt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRep_PVNZ1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PVN žurnāls";
            Load += FormRepApgr1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmDoIt;
        private MyMcFlatComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private MyMcFlatComboBox cbMonth;
        private MyTextBox tbPageNr;
        private MyTextBox tbRowNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}