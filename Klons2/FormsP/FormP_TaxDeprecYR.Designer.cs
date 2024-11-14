namespace KlonsP.Forms
{
    partial class FormP_TaxDeprecYR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_TaxDeprecYR));
            bsRows = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCatTCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            XCATT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            cbYear = new KlonsLIB.Components.MyMcFlatComboBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbFirst = new System.Windows.Forms.ToolStripButton();
            tsbPrev = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbNext = new System.Windows.Forms.ToolStripButton();
            tsbLast = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            tsbNew = new System.Windows.Forms.ToolStripButton();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            tsbRecalc = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            tsbReport = new System.Windows.Forms.ToolStripButton();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
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
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcYR, dgcCatTCode, XCATT_NAME, dgcRate, dgcKind, dgcCount, dgcValue0, dgcValueNew, dgcValueAdd, dgcValueRem, dgcValueExcl, Column1, dgcValueD, dgcDeprec, dgcValue1, dgcID });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.Size = new System.Drawing.Size(926, 341);
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
            // dgcCatTCode
            // 
            dgcCatTCode.DataPropertyName = "XCATT_CODE";
            dgcCatTCode.HeaderText = "kat.kods";
            dgcCatTCode.Name = "dgcCatTCode";
            dgcCatTCode.ReadOnly = true;
            dgcCatTCode.ToolTipText = "Kategorijas kods";
            // 
            // XCATT_NAME
            // 
            XCATT_NAME.DataPropertyName = "XCATT_NAME";
            XCATT_NAME.HeaderText = "kat.nosaukums";
            XCATT_NAME.Name = "XCATT_NAME";
            XCATT_NAME.ReadOnly = true;
            XCATT_NAME.ToolTipText = "Kategorijas nosaukums";
            XCATT_NAME.Width = 200;
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
            dgcValueD.DataPropertyName = "VALUED";
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
            // cbYear
            // 
            cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYear.ColumnWidths = "41";
            cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYear.DropDownHeight = 216;
            cbYear.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbYear.DropDownWidth = 60;
            cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYear.FormattingEnabled = true;
            cbYear.GridLineColor = System.Drawing.Color.LightGray;
            cbYear.GridLineHorizontal = false;
            cbYear.GridLineVertical = false;
            cbYear.IntegralHeight = false;
            cbYear.Location = new System.Drawing.Point(695, 328);
            cbYear.MaxDropDownItems = 12;
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(65, 24);
            cbYear.TabIndex = 2;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbFirst, tsbPrev, toolStripSeparator1, toolStripSeparator2, tsbNext, tsbLast, toolStripSeparator3, tsbNew, tsbDelete, tsbRecalc, tsbSave, tsbReport });
            toolStrip1.Location = new System.Drawing.Point(0, 341);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(926, 26);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbFirst
            // 
            tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFirst.Image = (System.Drawing.Image)resources.GetObject("tsbFirst.Image");
            tsbFirst.Name = "tsbFirst";
            tsbFirst.RightToLeftAutoMirrorImage = true;
            tsbFirst.Size = new System.Drawing.Size(23, 23);
            tsbFirst.Text = "Iet uz pirmo";
            tsbFirst.Click += tsbFirst_Click;
            // 
            // tsbPrev
            // 
            tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbPrev.Image = (System.Drawing.Image)resources.GetObject("tsbPrev.Image");
            tsbPrev.Name = "tsbPrev";
            tsbPrev.RightToLeftAutoMirrorImage = true;
            tsbPrev.Size = new System.Drawing.Size(23, 23);
            tsbPrev.Text = "Iet uz iepriekšējo";
            tsbPrev.Click += tsbPrev_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbNext
            // 
            tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbNext.Image = (System.Drawing.Image)resources.GetObject("tsbNext.Image");
            tsbNext.Name = "tsbNext";
            tsbNext.RightToLeftAutoMirrorImage = true;
            tsbNext.Size = new System.Drawing.Size(23, 23);
            tsbNext.Text = "Iet uz nākošo";
            tsbNext.Click += tsbNext_Click;
            // 
            // tsbLast
            // 
            tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbLast.Image = (System.Drawing.Image)resources.GetObject("tsbLast.Image");
            tsbLast.Name = "tsbLast";
            tsbLast.RightToLeftAutoMirrorImage = true;
            tsbLast.Size = new System.Drawing.Size(23, 23);
            tsbLast.Text = "Iet uz pēdējo";
            tsbLast.Click += tsbLast_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbNew
            // 
            tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
            tsbNew.Name = "tsbNew";
            tsbNew.RightToLeftAutoMirrorImage = true;
            tsbNew.Size = new System.Drawing.Size(120, 23);
            tsbNew.Text = "Pievienot gadu";
            tsbNew.Click += tsbNew_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.Name = "tsbDelete";
            tsbDelete.RightToLeftAutoMirrorImage = true;
            tsbDelete.Size = new System.Drawing.Size(98, 23);
            tsbDelete.Text = "Dzēst gadu";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsbRecalc
            // 
            tsbRecalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbRecalc.Image = (System.Drawing.Image)resources.GetObject("tsbRecalc.Image");
            tsbRecalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRecalc.Name = "tsbRecalc";
            tsbRecalc.Size = new System.Drawing.Size(75, 23);
            tsbRecalc.Text = "Pārrēķināt";
            tsbRecalc.Click += tsbRecalc_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 23);
            tsbSave.Text = "Saglabāt";
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
            // FormP_TaxDeprecYR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(926, 367);
            Controls.Add(cbYear);
            Controls.Add(dgvRows);
            Controls.Add(toolStrip1);
            Name = "FormP_TaxDeprecYR";
            Text = "Nolietojums nodokļa vajadzībām";
            Load += Form_TaxDeprecYR_Load;
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Components.MyMcFlatComboBox cbYear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbPrev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbRecalc;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripButton tsbReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCatTCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn XCATT_NAME;
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
    }
}