using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Apgr1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRep_Apgr1));
            cbAC = new MyMcFlatComboBox();
            bsAC = new MyBindingSource(components);
            tbSD = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbED = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            lbACName = new System.Windows.Forms.Label();
            cmDoIt = new System.Windows.Forms.Button();
            cbCharCount = new MyMcFlatComboBox();
            label3 = new System.Windows.Forms.Label();
            myLabel1 = new MyLabel();
            cmTable = new System.Windows.Forms.Button();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbPrevMonth = new System.Windows.Forms.ToolStripButton();
            tsbNextMonth = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
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
            cbAC.Location = new System.Drawing.Point(171, 64);
            cbAC.Margin = new System.Windows.Forms.Padding(2);
            cbAC.MaxDropDownItems = 15;
            cbAC.Name = "cbAC";
            cbAC.Size = new System.Drawing.Size(116, 24);
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
            tbSD.Location = new System.Drawing.Point(171, 23);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(90, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 23);
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
            tbED.Location = new System.Drawing.Point(267, 23);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(90, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 67);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 6;
            label2.Text = "Konts:";
            // 
            // lbACName
            // 
            lbACName.Location = new System.Drawing.Point(171, 90);
            lbACName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbACName.Name = "lbACName";
            lbACName.Size = new System.Drawing.Size(374, 22);
            lbACName.TabIndex = 9;
            lbACName.Text = "Konts:";
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(313, 139);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(113, 47);
            cmDoIt.TabIndex = 4;
            cmDoIt.Text = "Atskaiti";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // cbCharCount
            // 
            cbCharCount.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbCharCount.ColumnNames = new string[]
    {
    "col1"
    };
            cbCharCount.ColumnWidths = "56";
            cbCharCount.DisplayMember = "col1";
            cbCharCount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbCharCount.DropDownHeight = 144;
            cbCharCount.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbCharCount.DropDownWidth = 75;
            cbCharCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbCharCount.FormattingEnabled = true;
            cbCharCount.GridLineColor = System.Drawing.Color.LightGray;
            cbCharCount.GridLineHorizontal = false;
            cbCharCount.GridLineVertical = false;
            cbCharCount.IntegralHeight = false;
            myItem1.Col1 = "*";
            myItem2.Col1 = "1";
            myItem3.Col1 = "2";
            myItem4.Col1 = "3";
            myItem5.Col1 = "4";
            cbCharCount.Items.AddRange(new object[] { myItem1, myItem2, myItem3, myItem4, myItem5 });
            cbCharCount.ItemStrings = new string[]
    {
    "*",
    "1",
    "2",
    "3",
    "4"
    };
            cbCharCount.Location = new System.Drawing.Point(171, 118);
            cbCharCount.Margin = new System.Windows.Forms.Padding(2);
            cbCharCount.Name = "cbCharCount";
            cbCharCount.Size = new System.Drawing.Size(75, 24);
            cbCharCount.TabIndex = 3;
            cbCharCount.ValueMember = "col1";
            cbCharCount.KeyDown += Control_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(21, 121);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 17);
            label3.TabIndex = 7;
            label3.Text = "Konta zīmju skaits:";
            // 
            // myLabel1
            // 
            myLabel1.AutoSize = true;
            myLabel1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            myLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myLabel1.Location = new System.Drawing.Point(21, 179);
            myLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            myLabel1.Name = "myLabel1";
            myLabel1.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            myLabel1.Size = new System.Drawing.Size(213, 54);
            myLabel1.TabIndex = 8;
            myLabel1.Text = "Lai dabūtu atskaiti par visiem \r\nkontiem, lodzinā jāieliek '*'";
            // 
            // cmTable
            // 
            cmTable.Location = new System.Drawing.Point(313, 190);
            cmTable.Margin = new System.Windows.Forms.Padding(2);
            cmTable.Name = "cmTable";
            cmTable.Size = new System.Drawing.Size(113, 47);
            cmTable.TabIndex = 4;
            cmTable.Text = "Tabula";
            cmTable.UseVisualStyleBackColor = true;
            cmTable.Click += cmTable_Click;
            cmTable.KeyDown += Control_KeyDown;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbPrevMonth, tsbNextMonth });
            toolStrip1.Location = new System.Drawing.Point(363, 21);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(61, 29);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrevMonth
            // 
            tsbPrevMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbPrevMonth.Image = (System.Drawing.Image)resources.GetObject("tsbPrevMonth.Image");
            tsbPrevMonth.Margin = new System.Windows.Forms.Padding(0);
            tsbPrevMonth.Name = "tsbPrevMonth";
            tsbPrevMonth.RightToLeftAutoMirrorImage = true;
            tsbPrevMonth.Size = new System.Drawing.Size(29, 29);
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
            tsbNextMonth.Size = new System.Drawing.Size(29, 29);
            tsbNextMonth.Text = "nākošais mēnesis";
            tsbNextMonth.ToolTipText = "Iet uz nākošo";
            tsbNextMonth.Click += tsbNextMonth_Click;
            // 
            // FormRep_Apgr1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(565, 251);
            CloseOnEscape = true;
            Controls.Add(toolStrip1);
            Controls.Add(myLabel1);
            Controls.Add(cbCharCount);
            Controls.Add(cmTable);
            Controls.Add(cmDoIt);
            Controls.Add(lbACName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSD);
            Controls.Add(cbAC);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormRep_Apgr1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Apgrozijumu pārskata parametri";
            Load += FormRepApgr1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
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
        private MyMcFlatComboBox cbCharCount;
        private System.Windows.Forms.Label label3;
        private MyLabel myLabel1;
        private System.Windows.Forms.Button cmTable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrevMonth;
        private System.Windows.Forms.ToolStripButton tsbNextMonth;
    }
}