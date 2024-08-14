using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Darz1
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
            MyMcComboBox.MyItem myItem15 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem16 = new MyMcComboBox.MyItem();
            bsAC = new MyBindingSource(components);
            label1 = new System.Windows.Forms.Label();
            cmDoIt = new System.Windows.Forms.Button();
            cbYear = new MyMcFlatComboBox();
            label2 = new System.Windows.Forms.Label();
            cbMonth = new MyMcFlatComboBox();
            lbCM = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            cbFilter = new MyMcFlatComboBox();
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
            label1.Location = new System.Drawing.Point(23, 34);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 17);
            label1.TabIndex = 5;
            label1.Text = "Gads:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(309, 124);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(150, 63);
            cmDoIt.TabIndex = 3;
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
            cbYear.ColumnWidths = "58";
            cbYear.DisplayMember = "col1";
            cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYear.DropDownHeight = 270;
            cbYear.DropDownWidth = 77;
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
            cbYear.Location = new System.Drawing.Point(82, 31);
            cbYear.Margin = new System.Windows.Forms.Padding(2);
            cbYear.MaxDropDownItems = 15;
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(80, 24);
            cbYear.TabIndex = 0;
            cbYear.ValueMember = "col1";
            cbYear.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(194, 34);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 17);
            label2.TabIndex = 7;
            label2.Text = "mēnesis:";
            // 
            // cbMonth
            // 
            cbMonth.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbMonth.ColumnNames = new string[]
    {
    "col1"
    };
            cbMonth.ColumnWidths = "58";
            cbMonth.DisplayMember = "col1";
            cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbMonth.DropDownHeight = 270;
            cbMonth.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbMonth.DropDownWidth = 77;
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
            myItem15.Col1 = "Gads";
            cbMonth.Items.AddRange(new object[] { myItem3, myItem4, myItem5, myItem6, myItem7, myItem8, myItem9, myItem10, myItem11, myItem12, myItem13, myItem14, myItem15 });
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
    "12",
    "Gads"
    };
            cbMonth.Location = new System.Drawing.Point(269, 31);
            cbMonth.Margin = new System.Windows.Forms.Padding(2);
            cbMonth.MaxDropDownItems = 15;
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new System.Drawing.Size(80, 24);
            cbMonth.TabIndex = 1;
            cbMonth.ValueMember = "col1";
            cbMonth.KeyDown += Control_KeyDown;
            // 
            // lbCM
            // 
            lbCM.BackColor = System.Drawing.SystemColors.Control;
            lbCM.FormattingEnabled = true;
            lbCM.ItemHeight = 16;
            lbCM.Items.AddRange(new object[] { "IIN maksātājam, no 01.06.2022", "IIN maksātājam, no 01.07.2018", "IIN maksātājam", "MUN maksātājam" });
            lbCM.Location = new System.Drawing.Point(23, 124);
            lbCM.Margin = new System.Windows.Forms.Padding(2);
            lbCM.Name = "lbCM";
            lbCM.Size = new System.Drawing.Size(268, 84);
            lbCM.TabIndex = 4;
            lbCM.MouseDoubleClick += lbCM_MouseDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 75);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 17);
            label3.TabIndex = 6;
            label3.Text = "Filtrs";
            // 
            // cbFilter
            // 
            cbFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbFilter.ColumnNames = new string[]
    {
    "col1"
    };
            cbFilter.ColumnWidths = "62";
            cbFilter.DisplayMember = "col1";
            cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbFilter.DropDownHeight = 270;
            cbFilter.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbFilter.DropDownWidth = 81;
            cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFilter.FormattingEnabled = true;
            cbFilter.GridLineColor = System.Drawing.Color.LightGray;
            cbFilter.GridLineHorizontal = false;
            cbFilter.GridLineVertical = false;
            cbFilter.IntegralHeight = false;
            myItem16.Col1 = "*";
            cbFilter.Items.AddRange(new object[] { myItem16 });
            cbFilter.ItemStrings = new string[]
    {
    "*"
    };
            cbFilter.Location = new System.Drawing.Point(82, 72);
            cbFilter.Margin = new System.Windows.Forms.Padding(2);
            cbFilter.MaxDropDownItems = 15;
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(90, 24);
            cbFilter.TabIndex = 2;
            cbFilter.ValueMember = "col1";
            cbFilter.KeyDown += Control_KeyDown;
            // 
            // FormRep_Darz1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(479, 236);
            CloseOnEscape = true;
            Controls.Add(lbCM);
            Controls.Add(cbMonth);
            Controls.Add(cbFilter);
            Controls.Add(cbYear);
            Controls.Add(cmDoIt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormRep_Darz1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Saimniecisko darijumu uzskaites žurnāls";
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
        private System.Windows.Forms.ListBox lbCM;
        private System.Windows.Forms.Label label3;
        private MyMcFlatComboBox cbFilter;
    }
}