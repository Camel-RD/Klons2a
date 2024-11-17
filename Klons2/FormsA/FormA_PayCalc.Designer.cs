namespace KlonsA.Forms
{
    partial class FormA_PayCalc
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
            panel1 = new System.Windows.Forms.Panel();
            cbColList = new KlonsLIB.Components.MyMcFlatComboBox();
            lbPos = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbDates2 = new System.Windows.Forms.Label();
            lbDates1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bsRows = new System.Windows.Forms.BindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPayTaxed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNoSai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNoTaxed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotpaidTaxed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotpidNoSAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotpaidNotTaxed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUntMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDepend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcEx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPFLIHINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPayReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCashNotPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbColList);
            panel1.Controls.Add(lbPos);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(lbDates2);
            panel1.Controls.Add(lbDates1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(919, 81);
            panel1.TabIndex = 0;
            // 
            // cbColList
            // 
            cbColList.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbColList.ColumnWidths = "121";
            cbColList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbColList.DropDownHeight = 144;
            cbColList.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbColList.DropDownWidth = 140;
            cbColList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbColList.FormattingEnabled = true;
            cbColList.GridLineColor = System.Drawing.Color.LightGray;
            cbColList.GridLineHorizontal = false;
            cbColList.GridLineVertical = false;
            cbColList.IntegralHeight = false;
            cbColList.Items.AddRange(new object[] { "Izvērsta tabula", "Saīsināta tabula" });
            cbColList.Location = new System.Drawing.Point(458, 6);
            cbColList.Name = "cbColList";
            cbColList.Size = new System.Drawing.Size(141, 24);
            cbColList.TabIndex = 3;
            cbColList.SelectedIndexChanged += cbColList_SelectedIndexChanged;
            // 
            // lbPos
            // 
            lbPos.AutoSize = true;
            lbPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lbPos.Location = new System.Drawing.Point(106, 23);
            lbPos.Name = "lbPos";
            lbPos.Size = new System.Drawing.Size(52, 17);
            lbPos.TabIndex = 2;
            lbPos.Text = "label3";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lbName.Location = new System.Drawing.Point(106, 7);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(52, 17);
            lbName.TabIndex = 2;
            lbName.Text = "label3";
            // 
            // lbDates2
            // 
            lbDates2.AutoSize = true;
            lbDates2.Location = new System.Drawing.Point(12, 57);
            lbDates2.Name = "lbDates2";
            lbDates2.Size = new System.Drawing.Size(294, 17);
            lbDates2.TabIndex = 1;
            lbDates2.Text = "Otrā daļēji apmaksātā algu aprēķina datumi:  ";
            // 
            // lbDates1
            // 
            lbDates1.AutoSize = true;
            lbDates1.Location = new System.Drawing.Point(12, 41);
            lbDates1.Name = "lbDates1";
            lbDates1.Size = new System.Drawing.Size(302, 17);
            lbDates1.TabIndex = 1;
            lbDates1.Text = "Pirmā daļēji apmaksātā algu aprēķina datumi:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 17);
            label2.TabIndex = 1;
            label2.Text = "Amats:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Darbinieks:";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcPayTaxed, dgcNoSai, dgcNoTaxed, dgcNotpaidTaxed, dgcNotpidNoSAI, dgcNotpaidNotTaxed, dgcDNS, dgcUntMin, dgcDepend, dgcEx2, dgcPFLIHINT, dgcIIN, dgcPay, dgcPayReq, dgcCashNotPaid });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 81);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 25;
            dgvRows.Size = new System.Drawing.Size(919, 353);
            dgvRows.TabIndex = 1;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "Caption";
            dgcCaption.Frozen = true;
            dgcCaption.HeaderText = "apraksts";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            dgcCaption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCaption.Width = 180;
            // 
            // dgcPayTaxed
            // 
            dgcPayTaxed.DataPropertyName = "PAY_TAXED";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "0.00;-0.00;\"\"";
            dgcPayTaxed.DefaultCellStyle = dataGridViewCellStyle2;
            dgcPayTaxed.HeaderText = "apliek";
            dgcPayTaxed.Name = "dgcPayTaxed";
            dgcPayTaxed.ReadOnly = true;
            dgcPayTaxed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPayTaxed.ToolTipText = "apliekamie ienākumi";
            dgcPayTaxed.Width = 80;
            // 
            // dgcNoSai
            // 
            dgcNoSai.DataPropertyName = "PAY_NOSAI";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0.00;-0.00;\"\"";
            dgcNoSai.DefaultCellStyle = dataGridViewCellStyle3;
            dgcNoSai.HeaderText = "neapl. ar SAI";
            dgcNoSai.Name = "dgcNoSai";
            dgcNoSai.ReadOnly = true;
            dgcNoSai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNoSai.ToolTipText = "ar SAI neapliekaie ienākumi";
            dgcNoSai.Width = 80;
            // 
            // dgcNoTaxed
            // 
            dgcNoTaxed.DataPropertyName = "PAY_NOTTAXED";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.00;-0.00;\"\"";
            dgcNoTaxed.DefaultCellStyle = dataGridViewCellStyle4;
            dgcNoTaxed.HeaderText = "neapliek";
            dgcNoTaxed.Name = "dgcNoTaxed";
            dgcNoTaxed.ReadOnly = true;
            dgcNoTaxed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNoTaxed.ToolTipText = "neapliekamie ienākumi";
            dgcNoTaxed.Width = 80;
            // 
            // dgcNotpaidTaxed
            // 
            dgcNotpaidTaxed.DataPropertyName = "NOTPAID_TAXED";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.00;-0.00;\"\"";
            dgcNotpaidTaxed.DefaultCellStyle = dataGridViewCellStyle5;
            dgcNotpaidTaxed.HeaderText = "neizm. apliek";
            dgcNotpaidTaxed.Name = "dgcNotpaidTaxed";
            dgcNotpaidTaxed.ReadOnly = true;
            dgcNotpaidTaxed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotpaidTaxed.ToolTipText = "neizmaksājami apliekamie ienākumi";
            dgcNotpaidTaxed.Width = 80;
            // 
            // dgcNotpidNoSAI
            // 
            dgcNotpidNoSAI.DataPropertyName = "NOTPAID_NOSAI";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.00;-0.00;\"\"";
            dgcNotpidNoSAI.DefaultCellStyle = dataGridViewCellStyle6;
            dgcNotpidNoSAI.HeaderText = "neizm. nav SAI";
            dgcNotpidNoSAI.Name = "dgcNotpidNoSAI";
            dgcNotpidNoSAI.ReadOnly = true;
            dgcNotpidNoSAI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotpidNoSAI.ToolTipText = "neizmaksājami ar SAI neapliekaie ienākumi";
            dgcNotpidNoSAI.Width = 80;
            // 
            // dgcNotpaidNotTaxed
            // 
            dgcNotpaidNotTaxed.DataPropertyName = "NOTPAID_NOTTAXED";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "0.00;-0.00;\"\"";
            dgcNotpaidNotTaxed.DefaultCellStyle = dataGridViewCellStyle7;
            dgcNotpaidNotTaxed.HeaderText = "neizm. neapliek.";
            dgcNotpaidNotTaxed.Name = "dgcNotpaidNotTaxed";
            dgcNotpaidNotTaxed.ReadOnly = true;
            dgcNotpaidNotTaxed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotpaidNotTaxed.ToolTipText = "neizmaksājami neapliekamie ienākumi";
            dgcNotpaidNotTaxed.Width = 80;
            // 
            // dgcDNS
            // 
            dgcDNS.DataPropertyName = "DNSI";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.00;-0.00;\"\"";
            dgcDNS.DefaultCellStyle = dataGridViewCellStyle8;
            dgcDNS.HeaderText = "d.ņ. SI";
            dgcDNS.Name = "dgcDNS";
            dgcDNS.ReadOnly = true;
            dgcDNS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDNS.ToolTipText = "darba ņēmēja SAI";
            dgcDNS.Width = 80;
            // 
            // dgcUntMin
            // 
            dgcUntMin.DataPropertyName = "UNTAXED_MINIMUM";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.00;-0.00;\"\"";
            dgcUntMin.DefaultCellStyle = dataGridViewCellStyle9;
            dgcUntMin.HeaderText = "neapliek. min.";
            dgcUntMin.Name = "dgcUntMin";
            dgcUntMin.ReadOnly = true;
            dgcUntMin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcUntMin.ToolTipText = "neapliekamais ienākums";
            dgcUntMin.Width = 80;
            // 
            // dgcDepend
            // 
            dgcDepend.DataPropertyName = "IINEX_DEPENDANTS";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "0.00;-0.00;\"\"";
            dgcDepend.DefaultCellStyle = dataGridViewCellStyle10;
            dgcDepend.HeaderText = "par apgād.";
            dgcDepend.Name = "dgcDepend";
            dgcDepend.ReadOnly = true;
            dgcDepend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDepend.ToolTipText = "par apgādājamajiem";
            dgcDepend.Width = 80;
            // 
            // dgcEx2
            // 
            dgcEx2.DataPropertyName = "IINEX2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "0.00;-0.00;\"\"";
            dgcEx2.DefaultCellStyle = dataGridViewCellStyle11;
            dgcEx2.HeaderText = "pap. atv.";
            dgcEx2.Name = "dgcEx2";
            dgcEx2.ReadOnly = true;
            dgcEx2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcEx2.ToolTipText = "papildus atvieglojumi";
            dgcEx2.Width = 80;
            // 
            // dgcPFLIHINT
            // 
            dgcPFLIHINT.DataPropertyName = "PFLIHINT";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "0.00;-0.00;\"\"";
            dgcPFLIHINT.DefaultCellStyle = dataGridViewCellStyle12;
            dgcPFLIHINT.HeaderText = "pens. fondi, ...";
            dgcPFLIHINT.Name = "dgcPFLIHINT";
            dgcPFLIHINT.ReadOnly = true;
            dgcPFLIHINT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPFLIHINT.ToolTipText = "neapliekamās iemakas pensiju fondos, dzīvības un veselības apdrošināšana";
            dgcPFLIHINT.Width = 80;
            // 
            // dgcIIN
            // 
            dgcIIN.DataPropertyName = "IIN";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "0.00;-0.00;\"\"";
            dgcIIN.DefaultCellStyle = dataGridViewCellStyle13;
            dgcIIN.HeaderText = "IIN";
            dgcIIN.Name = "dgcIIN";
            dgcIIN.ReadOnly = true;
            dgcIIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcIIN.Width = 80;
            // 
            // dgcPay
            // 
            dgcPay.DataPropertyName = "CASH";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "0.00;-0.00;\"\"";
            dgcPay.DefaultCellStyle = dataGridViewCellStyle14;
            dgcPay.HeaderText = "izmaksa";
            dgcPay.Name = "dgcPay";
            dgcPay.ReadOnly = true;
            dgcPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPay.Width = 80;
            // 
            // dgcPayReq
            // 
            dgcPayReq.DataPropertyName = "CASH_REQ";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "0.00;-0.00;\"\"";
            dgcPayReq.DefaultCellStyle = dataGridViewCellStyle15;
            dgcPayReq.HeaderText = "pl. izm.";
            dgcPayReq.Name = "dgcPayReq";
            dgcPayReq.ReadOnly = true;
            dgcPayReq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPayReq.ToolTipText = "aprēķina izmaksas mērķis";
            dgcPayReq.Width = 80;
            // 
            // dgcCashNotPaid
            // 
            dgcCashNotPaid.DataPropertyName = "CASH_NOTPAID";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "0.00;-0.00;\"\"";
            dgcCashNotPaid.DefaultCellStyle = dataGridViewCellStyle16;
            dgcCashNotPaid.HeaderText = "neizmaks.";
            dgcCashNotPaid.Name = "dgcCashNotPaid";
            dgcCashNotPaid.ReadOnly = true;
            dgcCashNotPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCashNotPaid.Width = 80;
            // 
            // FormA_PayCalc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(919, 434);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormA_PayCalc";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Daļēji izmaksātie algas aprēķini";
            Load += Form_PayCalc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDates2;
        private System.Windows.Forms.Label lbDates1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyMcFlatComboBox cbColList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPayTaxed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNoSai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNoTaxed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotpaidTaxed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotpidNoSAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotpaidNotTaxed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUntMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDepend;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEx2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPFLIHINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPayReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCashNotPaid;
    }
}