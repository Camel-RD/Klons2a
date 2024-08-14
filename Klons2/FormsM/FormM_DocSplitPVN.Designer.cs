
namespace KlonsM.FormsM
{
    partial class FormM_DocSplitPVN
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem1 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem2 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem3 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcTagPVNRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPVNBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPVNCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPVNInDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCalcError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItems = new KlonsLIB.Data.MyBindingSource(this.components);
            this.tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.btDoIt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDecimals = new KlonsLIB.Components.MyMcFlatComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRows
            // 
            this.dgvRows.AllowUserToAddRows = false;
            this.dgvRows.AllowUserToDeleteRows = false;
            this.dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcTagPVNRate,
            this.dgcPVNBase,
            this.dgcPVNCalc,
            this.dgcPVNInDoc,
            this.dgcCalcError});
            this.dgvRows.Location = new System.Drawing.Point(5, 3);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.RowHeadersVisible = false;
            this.dgvRows.RowHeadersWidth = 62;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(660, 181);
            this.dgvRows.TabIndex = 0;
            this.dgvRows.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvRows_CellBeginEdit);
            // 
            // dgcTagPVNRate
            // 
            this.dgcTagPVNRate.DataPropertyName = "TagPVNRate";
            this.dgcTagPVNRate.HeaderText = "PVN likme";
            this.dgcTagPVNRate.MinimumWidth = 8;
            this.dgcTagPVNRate.Name = "dgcTagPVNRate";
            this.dgcTagPVNRate.ReadOnly = true;
            this.dgcTagPVNRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcTagPVNRate.Width = 120;
            // 
            // dgcPVNBase
            // 
            this.dgcPVNBase.DataPropertyName = "PVNBase";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.dgcPVNBase.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcPVNBase.HeaderText = "bez PVN";
            this.dgcPVNBase.MinimumWidth = 8;
            this.dgcPVNBase.Name = "dgcPVNBase";
            this.dgcPVNBase.ReadOnly = true;
            this.dgcPVNBase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcPVNBase.Width = 120;
            // 
            // dgcPVNCalc
            // 
            this.dgcPVNCalc.DataPropertyName = "PVNCalc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dgcPVNCalc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcPVNCalc.HeaderText = "aprēķināts";
            this.dgcPVNCalc.MinimumWidth = 8;
            this.dgcPVNCalc.Name = "dgcPVNCalc";
            this.dgcPVNCalc.ReadOnly = true;
            this.dgcPVNCalc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcPVNCalc.Width = 120;
            // 
            // dgcPVNInDoc
            // 
            this.dgcPVNInDoc.DataPropertyName = "PVNInDoc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgcPVNInDoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcPVNInDoc.HeaderText = "PVN no rēķ.";
            this.dgcPVNInDoc.MinimumWidth = 8;
            this.dgcPVNInDoc.Name = "dgcPVNInDoc";
            this.dgcPVNInDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcPVNInDoc.Width = 120;
            // 
            // dgcCalcError
            // 
            this.dgcCalcError.DataPropertyName = "CalcError";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgcCalcError.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcCalcError.HeaderText = "kļūda";
            this.dgcCalcError.MinimumWidth = 8;
            this.dgcCalcError.Name = "dgcCalcError";
            this.dgcCalcError.ReadOnly = true;
            this.dgcCalcError.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcCalcError.Width = 120;
            // 
            // bsItems
            // 
            this.bsItems.DataMember = "M_ITEMS";
            this.bsItems.MyDataSource = "KlonsMData";
            this.bsItems.Sort = "BARCODE";
            // 
            // tbCode
            // 
            this.tbCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbCode.DataMember = null;
            this.tbCode.DataSource = this.bsItems;
            this.tbCode.DisplayMember = "BARCODE";
            this.tbCode.Location = new System.Drawing.Point(208, 203);
            this.tbCode.Name = "tbCode";
            this.tbCode.SelectedIndex = -1;
            this.tbCode.ShowButton = true;
            this.tbCode.Size = new System.Drawing.Size(158, 26);
            this.tbCode.SyncPosition = false;
            this.tbCode.TabIndex = 6;
            this.tbCode.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "artikuls kļūdas uzskaitei:";
            // 
            // btDoIt
            // 
            this.btDoIt.Location = new System.Drawing.Point(384, 197);
            this.btDoIt.Name = "btDoIt";
            this.btDoIt.Size = new System.Drawing.Size(169, 37);
            this.btDoIt.TabIndex = 8;
            this.btDoIt.Text = "Saglabāt izmaiņas";
            this.btDoIt.UseVisualStyleBackColor = true;
            this.btDoIt.Click += new System.EventHandler(this.btDoIt_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(568, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atcelt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbDecimals
            // 
            this.cbDecimals.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbDecimals.ColumnNames = new string[] {
        "Col1"};
            this.cbDecimals.ColumnWidths = "42";
            this.cbDecimals.DisplayMember = "Col1";
            this.cbDecimals.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDecimals.DropDownHeight = 168;
            this.cbDecimals.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            this.cbDecimals.DropDownWidth = 70;
            this.cbDecimals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDecimals.FormattingEnabled = true;
            this.cbDecimals.GridLineColor = System.Drawing.Color.LightGray;
            this.cbDecimals.GridLineHorizontal = false;
            this.cbDecimals.GridLineVertical = false;
            this.cbDecimals.IntegralHeight = false;
            myItem1.Col1 = "2";
            myItem2.Col1 = "3";
            myItem3.Col1 = "4";
            this.cbDecimals.Items.AddRange(new object[] {
            myItem1,
            myItem2,
            myItem3});
            this.cbDecimals.ItemStrings = new string[] {
        "2",
        "3",
        "4"};
            this.cbDecimals.Location = new System.Drawing.Point(208, 241);
            this.cbDecimals.Name = "cbDecimals";
            this.cbDecimals.Size = new System.Drawing.Size(70, 27);
            this.cbDecimals.TabIndex = 9;
            this.cbDecimals.ValueMember = "Col1";
            this.cbDecimals.SelectedIndexChanged += new System.EventHandler(this.cbDecimals_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ciparu skaits aiz komata:";
            // 
            // FormM_DocSplitPVN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDecimals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDoIt);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormM_DocSplitPVN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PVN sadale pa rindām";
            this.Load += new System.EventHandler(this.FormM_DocSplitPVN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTagPVNRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVNBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVNCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVNInDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcError;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDoIt;
        private System.Windows.Forms.Button button1;
        private KlonsLIB.Components.MyMcFlatComboBox cbDecimals;
        private System.Windows.Forms.Label label1;
    }
}