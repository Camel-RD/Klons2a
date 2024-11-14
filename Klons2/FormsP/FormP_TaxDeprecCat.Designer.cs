namespace KlonsP.Forms
{
    partial class FormP_TaxDeprecCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_TaxDeprecCat));
            bsRows = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcKind = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValue0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueRem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueExcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValueD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            tsbReport = new System.Windows.Forms.ToolStripButton();
            cbCat = new KlonsLIB.Components.MyMcFlatComboBox();
            bsCatT = new KlonsLIB.Data.MyBindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCatT).BeginInit();
            SuspendLayout();
            // 
            // bsRows
            // 
            bsRows.DataMember = "TAXDEPRECYEAR";
            bsRows.MyDataSource = "KlonsPData";
            bsRows.Sort = "YR,XCATT_CODE";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcYR, dgcRate, dgcKind, dgcCount, dgcValue0, dgcValueNew, dgcValueAdd, dgcValueRem, dgcValueExcl, Column1, dgcValueD, dgcDeprec, dgcValue1, dgcID });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 26);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.Size = new System.Drawing.Size(894, 328);
            dgvRows.TabIndex = 1;
            // 
            // dgcYR
            // 
            dgcYR.DataPropertyName = "YR";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcYR.DefaultCellStyle = dataGridViewCellStyle2;
            dgcYR.HeaderText = "gads";
            dgcYR.Name = "dgcYR";
            dgcYR.ReadOnly = true;
            dgcYR.Width = 50;
            // 
            // dgcRate
            // 
            dgcRate.DataPropertyName = "RATE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRate.DefaultCellStyle = dataGridViewCellStyle3;
            dgcRate.HeaderText = "likme";
            dgcRate.Name = "dgcRate";
            dgcRate.ReadOnly = true;
            dgcRate.ToolTipText = "Nolietojuma likme";
            dgcRate.Width = 50;
            // 
            // dgcKind
            // 
            dgcKind.DataPropertyName = "KIND";
            dgcKind.FalseValue = "0";
            dgcKind.HeaderText = "katram";
            dgcKind.Name = "dgcKind";
            dgcKind.ReadOnly = true;
            dgcKind.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcKind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcKind.ToolTipText = "Nolietojumu rēķina katram pamatlīdzeklim atsevišķi";
            dgcKind.TrueValue = "1";
            dgcKind.Width = 50;
            // 
            // dgcCount
            // 
            dgcCount.DataPropertyName = "COUNT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCount.DefaultCellStyle = dataGridViewCellStyle4;
            dgcCount.HeaderText = "skaits";
            dgcCount.Name = "dgcCount";
            dgcCount.ReadOnly = true;
            dgcCount.Width = 50;
            // 
            // dgcValue0
            // 
            dgcValue0.DataPropertyName = "VALUE0";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcValue0.DefaultCellStyle = dataGridViewCellStyle5;
            dgcValue0.HeaderText = "sākuma atlikums";
            dgcValue0.Name = "dgcValue0";
            dgcValue0.ReadOnly = true;
            dgcValue0.ToolTipText = "Kategorijas atlikums uz gada sākumu";
            // 
            // dgcValueNew
            // 
            dgcValueNew.DataPropertyName = "VALUE_NEW";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcValueNew.DefaultCellStyle = dataGridViewCellStyle6;
            dgcValueNew.HeaderText = "sāk.vērt.";
            dgcValueNew.Name = "dgcValueNew";
            dgcValueNew.ReadOnly = true;
            dgcValueNew.ToolTipText = "Kategorijas sākotnējā vērtība";
            // 
            // dgcValueAdd
            // 
            dgcValueAdd.DataPropertyName = "VALUE_ADD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcValueAdd.DefaultCellStyle = dataGridViewCellStyle7;
            dgcValueAdd.HeaderText = "palielin.";
            dgcValueAdd.Name = "dgcValueAdd";
            dgcValueAdd.ReadOnly = true;
            dgcValueAdd.ToolTipText = "Vērtības palielinājums";
            // 
            // dgcValueRem
            // 
            dgcValueRem.DataPropertyName = "VALUE_REM";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcValueRem.DefaultCellStyle = dataGridViewCellStyle8;
            dgcValueRem.HeaderText = "samazin.";
            dgcValueRem.Name = "dgcValueRem";
            dgcValueRem.ReadOnly = true;
            dgcValueRem.ToolTipText = "Vērtības samazinājums";
            // 
            // dgcValueExcl
            // 
            dgcValueExcl.DataPropertyName = "VALUE_EXCL";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "# ##0.00;-# ##0.00;\"\"";
            dgcValueExcl.DefaultCellStyle = dataGridViewCellStyle9;
            dgcValueExcl.HeaderText = "izslēgts";
            dgcValueExcl.Name = "dgcValueExcl";
            dgcValueExcl.ReadOnly = true;
            dgcValueExcl.ToolTipText = "Izslēgtā vērtība";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "VALUE_COR";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            Column1.DefaultCellStyle = dataGridViewCellStyle10;
            Column1.HeaderText = "koriģ. vērtība";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.ToolTipText = "Koriģētā vērtība";
            // 
            // dgcValueD
            // 
            dgcValueD.DataPropertyName = "VALUE_COR";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dgcValueD.DefaultCellStyle = dataGridViewCellStyle11;
            dgcValueD.HeaderText = "noliet. bāze";
            dgcValueD.Name = "dgcValueD";
            dgcValueD.ReadOnly = true;
            dgcValueD.ToolTipText = "Vērtība, no kuras aprēķina taksācijas perioda nolietojumu";
            // 
            // dgcDeprec
            // 
            dgcDeprec.DataPropertyName = "DEPREC";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dgcDeprec.DefaultCellStyle = dataGridViewCellStyle12;
            dgcDeprec.HeaderText = "nolietojums";
            dgcDeprec.Name = "dgcDeprec";
            dgcDeprec.ReadOnly = true;
            dgcDeprec.ToolTipText = "Taksācijas pereioda nolietojums";
            // 
            // dgcValue1
            // 
            dgcValue1.DataPropertyName = "VALUE1";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dgcValue1.DefaultCellStyle = dataGridViewCellStyle13;
            dgcValue1.HeaderText = "beigu atlikums";
            dgcValue1.Name = "dgcValue1";
            dgcValue1.ReadOnly = true;
            dgcValue1.ToolTipText = "Atlikusī bategorijas vērtība";
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.ReadOnly = true;
            dgcID.Visible = false;
            dgcID.Width = 50;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsPData";
            myAdapterManager1.TableNames = new string[]
    {
    "CATT",
    "TAXDEPRECYEAR",
    null
    };
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, tsbReport });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(894, 26);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(73, 23);
            toolStripLabel1.Text = "Kategorija:";
            // 
            // tsbReport
            // 
            tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbReport.Image = (System.Drawing.Image)resources.GetObject("tsbReport.Image");
            tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbReport.Name = "tsbReport";
            tsbReport.Size = new System.Drawing.Size(61, 23);
            tsbReport.Text = "Izdrukai";
            tsbReport.Click += tsbReport_Click;
            // 
            // cbCat
            // 
            cbCat._AllowSelection = true;
            cbCat.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbCat.ColumnNames = new string[]
    {
    "CODE",
    "DESCR"
    };
            cbCat.ColumnWidths = "120;300";
            cbCat.DataSource = bsCatT;
            cbCat.DisplayMember = "CODE";
            cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbCat.DropDownHeight = 270;
            cbCat.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbCat.DropDownWidth = 439;
            cbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbCat.FormattingEnabled = true;
            cbCat.GridLineColor = System.Drawing.Color.LightGray;
            cbCat.GridLineHorizontal = false;
            cbCat.GridLineVertical = false;
            cbCat.IntegralHeight = false;
            cbCat.Location = new System.Drawing.Point(212, 1);
            cbCat.MaxDropDownItems = 15;
            cbCat.Name = "cbCat";
            cbCat.Size = new System.Drawing.Size(120, 24);
            cbCat.TabIndex = 3;
            cbCat.ValueMember = "ID";
            // 
            // bsCatT
            // 
            bsCatT.DataMember = "CATT";
            bsCatT.Filter = "ID<>0";
            bsCatT.MyDataSource = "KlonsPData";
            bsCatT.Sort = "CODE";
            bsCatT.CurrentChanged += bsCatT_CurrentChanged;
            // 
            // FormP_TaxDeprecCat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(894, 354);
            Controls.Add(cbCat);
            Controls.Add(dgvRows);
            Controls.Add(toolStrip1);
            Name = "FormP_TaxDeprecCat";
            Text = "Nolietojums nodokļa vajadzībām kategorijai";
            Load += Form_TaxDeprecCat_Load;
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCatT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private KlonsLIB.Components.MyMcFlatComboBox cbCat;
        private KlonsLIB.Data.MyBindingSource bsCatT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRate;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValue0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueRem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueExcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValueD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeprec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private System.Windows.Forms.ToolStripButton tsbReport;
    }
}