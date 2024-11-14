namespace KlonsP.Forms
{
    partial class FormP_RepMT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValue0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeprec0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeprecCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeprecC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSellValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMtUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRateD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRateDMt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxValLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxValC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxDeprecCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxDeprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsRows = new KlonsLIB.Data.MyBindingSource2(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1001, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1001, 43);
            label1.TabIndex = 0;
            label1.Text = "label1";
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
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcYear, dgcMonth, dgcValue0, dgcDeprec0, dgcDeprecCalc, dgcValueC, dgcDeprecC, dgcSellValue, dgcMtTotal, dgcMtUsed, dgcRateD, dgcRateDMt, dgcTaxValLeft, dgcTaxValC, dgcTaxDeprecCalc, dgcTaxVal, dgcTaxDeprec, dgcTaxRate });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 43);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.ShowCellErrors = false;
            dgvRows.ShowEditingIcon = false;
            dgvRows.ShowRowErrors = false;
            dgvRows.Size = new System.Drawing.Size(1001, 318);
            dgvRows.TabIndex = 1;
            // 
            // dgcYear
            // 
            dgcYear.DataPropertyName = "Year";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcYear.DefaultCellStyle = dataGridViewCellStyle2;
            dgcYear.Frozen = true;
            dgcYear.HeaderText = "Gads";
            dgcYear.Name = "dgcYear";
            dgcYear.ReadOnly = true;
            dgcYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcYear.Width = 40;
            // 
            // dgcMonth
            // 
            dgcMonth.DataPropertyName = "Month";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcMonth.DefaultCellStyle = dataGridViewCellStyle3;
            dgcMonth.Frozen = true;
            dgcMonth.HeaderText = "Mēn.";
            dgcMonth.Name = "dgcMonth";
            dgcMonth.ReadOnly = true;
            dgcMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcMonth.ToolTipText = "Mēnesis";
            dgcMonth.Width = 40;
            // 
            // dgcValue0
            // 
            dgcValue0.DataPropertyName = "Value0";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcValue0.DefaultCellStyle = dataGridViewCellStyle4;
            dgcValue0.HeaderText = "Ieg.v.";
            dgcValue0.Name = "dgcValue0";
            dgcValue0.ReadOnly = true;
            dgcValue0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcValue0.ToolTipText = "Iegādes vērtība uz mēneša sākumu";
            dgcValue0.Width = 80;
            // 
            // dgcDeprec0
            // 
            dgcDeprec0.DataPropertyName = "Deprec0";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcDeprec0.DefaultCellStyle = dataGridViewCellStyle5;
            dgcDeprec0.HeaderText = "Uzrkr. noliet.";
            dgcDeprec0.Name = "dgcDeprec0";
            dgcDeprec0.ReadOnly = true;
            dgcDeprec0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDeprec0.ToolTipText = "Uzkrātais nolietojums";
            dgcDeprec0.Width = 80;
            // 
            // dgcDeprecCalc
            // 
            dgcDeprecCalc.DataPropertyName = "DeprecCalc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcDeprecCalc.DefaultCellStyle = dataGridViewCellStyle6;
            dgcDeprecCalc.HeaderText = "Apr.nol.";
            dgcDeprecCalc.Name = "dgcDeprecCalc";
            dgcDeprecCalc.ReadOnly = true;
            dgcDeprecCalc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDeprecCalc.Width = 80;
            // 
            // dgcValueC
            // 
            dgcValueC.DataPropertyName = "ValueC";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcValueC.DefaultCellStyle = dataGridViewCellStyle7;
            dgcValueC.HeaderText = "ieg.v. +/-";
            dgcValueC.Name = "dgcValueC";
            dgcValueC.ReadOnly = true;
            dgcValueC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcValueC.Width = 80;
            // 
            // dgcDeprecC
            // 
            dgcDeprecC.DataPropertyName = "DeprecC";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcDeprecC.DefaultCellStyle = dataGridViewCellStyle8;
            dgcDeprecC.HeaderText = "Uzkr.nol. +/-";
            dgcDeprecC.Name = "dgcDeprecC";
            dgcDeprecC.ReadOnly = true;
            dgcDeprecC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDeprecC.Width = 80;
            // 
            // dgcSellValue
            // 
            dgcSellValue.DataPropertyName = "SellValue";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcSellValue.DefaultCellStyle = dataGridViewCellStyle9;
            dgcSellValue.HeaderText = "Pārd.v.";
            dgcSellValue.Name = "dgcSellValue";
            dgcSellValue.ReadOnly = true;
            dgcSellValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcSellValue.ToolTipText = "Pārdošanas vērtība";
            dgcSellValue.Width = 80;
            // 
            // dgcMtTotal
            // 
            dgcMtTotal.DataPropertyName = "MtTotal";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcMtTotal.DefaultCellStyle = dataGridViewCellStyle10;
            dgcMtTotal.HeaderText = "Mēn.";
            dgcMtTotal.Name = "dgcMtTotal";
            dgcMtTotal.ReadOnly = true;
            dgcMtTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcMtTotal.ToolTipText = "Nolietojuma periods mēnešos";
            dgcMtTotal.Width = 40;
            // 
            // dgcMtUsed
            // 
            dgcMtUsed.DataPropertyName = "MtUsed";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcMtUsed.DefaultCellStyle = dataGridViewCellStyle11;
            dgcMtUsed.HeaderText = "Mēn. izm.";
            dgcMtUsed.Name = "dgcMtUsed";
            dgcMtUsed.ReadOnly = true;
            dgcMtUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcMtUsed.ToolTipText = "Izmantotais nolietojuma periods mēnešos";
            dgcMtUsed.Width = 40;
            // 
            // dgcRateD
            // 
            dgcRateD.DataPropertyName = "RateD";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRateD.DefaultCellStyle = dataGridViewCellStyle12;
            dgcRateD.HeaderText = "Nol. likme";
            dgcRateD.Name = "dgcRateD";
            dgcRateD.ReadOnly = true;
            dgcRateD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcRateD.ToolTipText = "Nolietojuma likme";
            dgcRateD.Width = 40;
            // 
            // dgcRateDMt
            // 
            dgcRateDMt.DataPropertyName = "RateDMt";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dgcRateDMt.DefaultCellStyle = dataGridViewCellStyle13;
            dgcRateDMt.HeaderText = "Nol.likme mēnesī";
            dgcRateDMt.Name = "dgcRateDMt";
            dgcRateDMt.ReadOnly = true;
            dgcRateDMt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcRateDMt.ToolTipText = "Nolietojama likme mēnesī";
            dgcRateDMt.Width = 80;
            // 
            // dgcTaxValLeft
            // 
            dgcTaxValLeft.DataPropertyName = "TaxValLeft0";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dgcTaxValLeft.DefaultCellStyle = dataGridViewCellStyle14;
            dgcTaxValLeft.HeaderText = "Nod.nol. atl.v.";
            dgcTaxValLeft.Name = "dgcTaxValLeft";
            dgcTaxValLeft.ReadOnly = true;
            dgcTaxValLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcTaxValLeft.ToolTipText = "Atlikusī nolietojuma vērtība nodokļa vajadzībām";
            dgcTaxValLeft.Width = 80;
            // 
            // dgcTaxValC
            // 
            dgcTaxValC.DataPropertyName = "TaxValC";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcTaxValC.DefaultCellStyle = dataGridViewCellStyle15;
            dgcTaxValC.HeaderText = "Nod.nol. +/-";
            dgcTaxValC.Name = "dgcTaxValC";
            dgcTaxValC.ReadOnly = true;
            dgcTaxValC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcTaxValC.ToolTipText = "Nolietojuma vērtības izmaiņas nodokļa vajadzībām";
            dgcTaxValC.Width = 80;
            // 
            // dgcTaxDeprecCalc
            // 
            dgcTaxDeprecCalc.DataPropertyName = "TaxDeprecCalc";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcTaxDeprecCalc.DefaultCellStyle = dataGridViewCellStyle16;
            dgcTaxDeprecCalc.HeaderText = "Nod.nol. apr.";
            dgcTaxDeprecCalc.Name = "dgcTaxDeprecCalc";
            dgcTaxDeprecCalc.ReadOnly = true;
            dgcTaxDeprecCalc.ToolTipText = "Aprēķinātais nolietojums nodokļu vajadzībām";
            dgcTaxDeprecCalc.Width = 80;
            // 
            // dgcTaxVal
            // 
            dgcTaxVal.DataPropertyName = "TaxVal";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dgcTaxVal.DefaultCellStyle = dataGridViewCellStyle17;
            dgcTaxVal.HeaderText = "Nod.nol. v.";
            dgcTaxVal.Name = "dgcTaxVal";
            dgcTaxVal.ReadOnly = true;
            dgcTaxVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcTaxVal.ToolTipText = "Nolietojuma vērtība nodokļa vajadzībām";
            dgcTaxVal.Width = 80;
            // 
            // dgcTaxDeprec
            // 
            dgcTaxDeprec.DataPropertyName = "TaxDeprec";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dgcTaxDeprec.DefaultCellStyle = dataGridViewCellStyle18;
            dgcTaxDeprec.HeaderText = "Nod.nol. uzkr.";
            dgcTaxDeprec.Name = "dgcTaxDeprec";
            dgcTaxDeprec.ReadOnly = true;
            dgcTaxDeprec.ToolTipText = "Norakstītais nolietojums nodokļu vajadzībām";
            // 
            // dgcTaxRate
            // 
            dgcTaxRate.DataPropertyName = "TaxRate";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcTaxRate.DefaultCellStyle = dataGridViewCellStyle19;
            dgcTaxRate.HeaderText = "Nod.nol. likme";
            dgcTaxRate.Name = "dgcTaxRate";
            dgcTaxRate.ReadOnly = true;
            dgcTaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcTaxRate.ToolTipText = "Nolietojuma likme nodokļu vajadzībām";
            dgcTaxRate.Width = 60;
            // 
            // FormP_RepMT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1001, 361);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormP_RepMT";
            Text = "Aprēķina izklāsts pa mēnešiem";
            Load += Form_RepMT_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource2 bsRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValue0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeprec0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeprecCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeprecC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSellValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMtUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRateD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRateDMt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxValLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxValC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxDeprecCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxDeprec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxRate;
    }
}