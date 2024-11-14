namespace KlonsP.Forms
{
    partial class FormPRep_TaxDeprec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            cmReport = new System.Windows.Forms.Button();
            cmGetData = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            cbYear = new KlonsLIB.Components.FlatComboBox();
            bsRows = new KlonsLIB.Data.MyBindingSource2(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCatT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxValLeft0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxValChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxDeprecCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxValLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(cmGetData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbYear);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(803, 36);
            panel1.TabIndex = 0;
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(306, 3);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(86, 29);
            cmReport.TabIndex = 9;
            cmReport.Text = "Atskaite";
            cmReport.UseVisualStyleBackColor = true;
            cmReport.Click += cmReport_Click;
            // 
            // cmGetData
            // 
            cmGetData.Location = new System.Drawing.Point(214, 3);
            cmGetData.Name = "cmGetData";
            cmGetData.Size = new System.Drawing.Size(86, 29);
            cmGetData.TabIndex = 2;
            cmGetData.Text = "Atlasīt";
            cmGetData.UseVisualStyleBackColor = true;
            cmGetData.Click += cmGetData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 17);
            label1.TabIndex = 1;
            label1.Text = "Pārksata gads:";
            // 
            // cbYear
            // 
            cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            cbYear.Location = new System.Drawing.Point(108, 6);
            cbYear.MaxDropDownItems = 15;
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(75, 24);
            cbYear.TabIndex = 0;
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCatT, dgcName, dgcTaxValLeft0, dgcTaxValChange, dgcTaxDeprecCalc, dgcTaxValLeft });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 36);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.Size = new System.Drawing.Size(803, 319);
            dgvRows.TabIndex = 1;
            // 
            // dgcCatT
            // 
            dgcCatT.DataPropertyName = "SCatT";
            dgcCatT.HeaderText = "Kat.";
            dgcCatT.Name = "dgcCatT";
            dgcCatT.ReadOnly = true;
            dgcCatT.ToolTipText = "Nolietojumu kategorija";
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "Nosaukums";
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 200;
            // 
            // dgcTaxValLeft0
            // 
            dgcTaxValLeft0.DataPropertyName = "TaxValLeft0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcTaxValLeft0.DefaultCellStyle = dataGridViewCellStyle2;
            dgcTaxValLeft0.HeaderText = "Atl.v. sākumā";
            dgcTaxValLeft0.Name = "dgcTaxValLeft0";
            dgcTaxValLeft0.ReadOnly = true;
            dgcTaxValLeft0.ToolTipText = "Atlikusī vērtība perioda sākumā";
            dgcTaxValLeft0.Width = 80;
            // 
            // dgcTaxValChange
            // 
            dgcTaxValChange.DataPropertyName = "TaxValChange";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcTaxValChange.DefaultCellStyle = dataGridViewCellStyle3;
            dgcTaxValChange.HeaderText = "Izmaiņas +/-";
            dgcTaxValChange.Name = "dgcTaxValChange";
            dgcTaxValChange.ReadOnly = true;
            dgcTaxValChange.Width = 80;
            // 
            // dgcTaxDeprecCalc
            // 
            dgcTaxDeprecCalc.DataPropertyName = "TaxDeprecCalc";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcTaxDeprecCalc.DefaultCellStyle = dataGridViewCellStyle4;
            dgcTaxDeprecCalc.HeaderText = "Apr. nol.";
            dgcTaxDeprecCalc.Name = "dgcTaxDeprecCalc";
            dgcTaxDeprecCalc.ReadOnly = true;
            dgcTaxDeprecCalc.ToolTipText = "Aprēķinātais nolietojums nodokļu vajadzībām";
            dgcTaxDeprecCalc.Width = 80;
            // 
            // dgcTaxValLeft
            // 
            dgcTaxValLeft.DataPropertyName = "TaxValLeft1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcTaxValLeft.DefaultCellStyle = dataGridViewCellStyle5;
            dgcTaxValLeft.HeaderText = "Atl.v. beigās";
            dgcTaxValLeft.Name = "dgcTaxValLeft";
            dgcTaxValLeft.ReadOnly = true;
            dgcTaxValLeft.ToolTipText = "Atlikusī vērtība perioda beigās";
            dgcTaxValLeft.Width = 80;
            // 
            // FormPRep_TaxDeprec
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(803, 355);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormPRep_TaxDeprec";
            Text = "Nolietojums nodokļa vajadzībām";
            Load += FormRep_TaxDeprec_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Data.MyBindingSource2 bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.Button cmGetData;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.FlatComboBox cbYear;
        private System.Windows.Forms.Button cmReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCatT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxValLeft0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxValChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxDeprecCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxValLeft;
    }
}