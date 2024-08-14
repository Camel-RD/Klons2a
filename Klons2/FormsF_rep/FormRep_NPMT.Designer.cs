using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_NPMT
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
            lbCM = new System.Windows.Forms.ListBox();
            myLabel1 = new MyLabel();
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
            cmDoIt.Location = new System.Drawing.Point(335, 48);
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
            cbYear.ColumnWidths = "60";
            cbYear.DisplayMember = "col1";
            cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYear.DropDownHeight = 144;
            cbYear.DropDownWidth = 79;
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
            cbYear.Size = new System.Drawing.Size(79, 24);
            cbYear.TabIndex = 6;
            cbYear.ValueMember = "col1";
            cbYear.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(170, 38);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 17);
            label2.TabIndex = 5;
            label2.Text = "mēneši:";
            // 
            // cbMonth
            // 
            cbMonth.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbMonth.ColumnNames = new string[]
    {
    "col1"
    };
            cbMonth.ColumnWidths = "44";
            cbMonth.DisplayMember = "col1";
            cbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbMonth.DropDownHeight = 216;
            cbMonth.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbMonth.DropDownWidth = 63;
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
            cbMonth.Location = new System.Drawing.Point(236, 36);
            cbMonth.Margin = new System.Windows.Forms.Padding(2);
            cbMonth.MaxDropDownItems = 12;
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new System.Drawing.Size(63, 24);
            cbMonth.TabIndex = 6;
            cbMonth.ValueMember = "col1";
            cbMonth.KeyDown += Control_KeyDown;
            // 
            // lbCM
            // 
            lbCM.BackColor = System.Drawing.SystemColors.Control;
            lbCM.FormattingEnabled = true;
            lbCM.ItemHeight = 16;
            lbCM.Items.AddRange(new object[] { "Naudas plūsma", "Naudas plūsma pa nozarēm / produktiem", "Naudas plūsma pēc 3. kontējuma pazīmes", "Ieņēmumi, izdevumu kopsavilkums" });
            lbCM.Location = new System.Drawing.Point(18, 86);
            lbCM.Margin = new System.Windows.Forms.Padding(2);
            lbCM.Name = "lbCM";
            lbCM.Size = new System.Drawing.Size(293, 84);
            lbCM.TabIndex = 7;
            lbCM.MouseDoubleClick += lbCM_MouseDoubleClick;
            // 
            // myLabel1
            // 
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(18, 184);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(2);
            myLabel1.Size = new System.Drawing.Size(382, 67);
            myLabel1.TabIndex = 8;
            myLabel1.Text = "Atskaitē tiks izmantota kontējuma otrā un trešā pazīme.\r\nKontu plānā jābūt atzīmētiem naudas kontiem (kase, banka, avansa norēķini)";
            // 
            // FormRep_NPMT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(486, 275);
            CloseOnEscape = true;
            Controls.Add(myLabel1);
            Controls.Add(lbCM);
            Controls.Add(cbMonth);
            Controls.Add(cbYear);
            Controls.Add(cmDoIt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRep_NPMT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Naudas plūsma";
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
        private MyLabel myLabel1;
    }
}