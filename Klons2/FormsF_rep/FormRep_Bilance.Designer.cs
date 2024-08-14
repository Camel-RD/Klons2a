using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class FormRep_Bilance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            bsBalA1 = new MyBindingSource(components);
            dgvBalA1 = new MyDataGridView();
            dgcBalA1balid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA1Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA1TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA1TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbSD = new MyTextBox();
            tbED = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            cmReport = new System.Windows.Forms.Button();
            cmEdit = new System.Windows.Forms.Button();
            lbCM = new System.Windows.Forms.ListBox();
            cmTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsBalA1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA1).BeginInit();
            SuspendLayout();
            // 
            // bsBalA1
            // 
            bsBalA1.DataMember = "BalA1";
            bsBalA1.MyDataSource = "KlonsData";
            bsBalA1.Name2 = "bsBalA1";
            // 
            // dgvBalA1
            // 
            dgvBalA1.AllowUserToAddRows = false;
            dgvBalA1.AllowUserToDeleteRows = false;
            dgvBalA1.AllowUserToResizeRows = false;
            dgvBalA1.AutoGenerateColumns = false;
            dgvBalA1.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvBalA1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalA1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcBalA1balid, dgcBalA1Descr, dgcBalA1TA, dgcBalA1TP });
            dgvBalA1.DataSource = bsBalA1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvBalA1.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBalA1.Location = new System.Drawing.Point(7, 8);
            dgvBalA1.Margin = new System.Windows.Forms.Padding(2);
            dgvBalA1.Name = "dgvBalA1";
            dgvBalA1.ReadOnly = true;
            dgvBalA1.RowHeadersVisible = false;
            dgvBalA1.RowHeadersWidth = 62;
            dgvBalA1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBalA1.ShowCellToolTips = false;
            dgvBalA1.Size = new System.Drawing.Size(510, 151);
            dgvBalA1.TabIndex = 0;
            // 
            // dgcBalA1balid
            // 
            dgcBalA1balid.DataPropertyName = "balid";
            dgcBalA1balid.HeaderText = "Kods";
            dgcBalA1balid.MinimumWidth = 9;
            dgcBalA1balid.Name = "dgcBalA1balid";
            dgcBalA1balid.ReadOnly = true;
            dgcBalA1balid.ToolTipText = "Atskaites kods (B1, PZA1, utml.)";
            dgcBalA1balid.Width = 90;
            // 
            // dgcBalA1Descr
            // 
            dgcBalA1Descr.DataPropertyName = "Descr";
            dgcBalA1Descr.HeaderText = "Apraksts";
            dgcBalA1Descr.MinimumWidth = 9;
            dgcBalA1Descr.Name = "dgcBalA1Descr";
            dgcBalA1Descr.ReadOnly = true;
            dgcBalA1Descr.ToolTipText = "Apraksts";
            dgcBalA1Descr.Width = 393;
            // 
            // dgcBalA1TA
            // 
            dgcBalA1TA.DataPropertyName = "TA";
            dgcBalA1TA.HeaderText = "Nosaukums1";
            dgcBalA1TA.MinimumWidth = 9;
            dgcBalA1TA.Name = "dgcBalA1TA";
            dgcBalA1TA.ReadOnly = true;
            dgcBalA1TA.ToolTipText = "Nosaukums atskaites aktīva pusei";
            dgcBalA1TA.Visible = false;
            dgcBalA1TA.Width = 126;
            // 
            // dgcBalA1TP
            // 
            dgcBalA1TP.DataPropertyName = "TP";
            dgcBalA1TP.HeaderText = "Nosaukums2";
            dgcBalA1TP.MinimumWidth = 9;
            dgcBalA1TP.Name = "dgcBalA1TP";
            dgcBalA1TP.ReadOnly = true;
            dgcBalA1TP.ToolTipText = "Nosaukums atskaites pasīva pusei";
            dgcBalA1TP.Visible = false;
            dgcBalA1TP.Width = 126;
            // 
            // tbSD
            // 
            tbSD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSD.IsDate = true;
            tbSD.Location = new System.Drawing.Point(139, 176);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(90, 23);
            tbSD.TabIndex = 1;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(240, 176);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(90, 23);
            tbED.TabIndex = 2;
            tbED.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 178);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 5;
            label1.Text = "Datums (no - līdz):";
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(375, 171);
            cmReport.Margin = new System.Windows.Forms.Padding(2);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(115, 48);
            cmReport.TabIndex = 3;
            cmReport.Text = "Atskaite";
            cmReport.UseVisualStyleBackColor = true;
            cmReport.Click += cmReport_Click;
            cmReport.KeyDown += Control_KeyDown;
            // 
            // cmEdit
            // 
            cmEdit.Location = new System.Drawing.Point(375, 284);
            cmEdit.Margin = new System.Windows.Forms.Padding(2);
            cmEdit.Name = "cmEdit";
            cmEdit.Size = new System.Drawing.Size(115, 56);
            cmEdit.TabIndex = 4;
            cmEdit.Text = "Rediģēt formulas";
            cmEdit.UseVisualStyleBackColor = true;
            cmEdit.Click += cmEdit_Click;
            // 
            // lbCM
            // 
            lbCM.BackColor = System.Drawing.SystemColors.Control;
            lbCM.FormattingEnabled = true;
            lbCM.ItemHeight = 16;
            lbCM.Items.AddRange(new object[] { "Tikai rindas, kas nav tukšas", "Pilna atskaite", "Pa mēnešiem - apgrozijums", "Pa mēnešiem - atlikums", "Summu izklāsts pa atskaites rindu numuriem" });
            lbCM.Location = new System.Drawing.Point(11, 218);
            lbCM.Margin = new System.Windows.Forms.Padding(2);
            lbCM.Name = "lbCM";
            lbCM.Size = new System.Drawing.Size(345, 100);
            lbCM.TabIndex = 6;
            lbCM.MouseDoubleClick += lbCM_MouseDoubleClick;
            // 
            // cmTable
            // 
            cmTable.Location = new System.Drawing.Point(375, 229);
            cmTable.Margin = new System.Windows.Forms.Padding(2);
            cmTable.Name = "cmTable";
            cmTable.Size = new System.Drawing.Size(115, 48);
            cmTable.TabIndex = 3;
            cmTable.Text = "Atskaite - tabula";
            cmTable.UseVisualStyleBackColor = true;
            cmTable.Click += cmTable_Click;
            cmTable.KeyDown += Control_KeyDown;
            // 
            // FormRep_Bilance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(525, 348);
            CloseOnEscape = true;
            Controls.Add(lbCM);
            Controls.Add(cmEdit);
            Controls.Add(cmTable);
            Controls.Add(cmReport);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSD);
            Controls.Add(dgvBalA1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormRep_Bilance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Bilance";
            Load += Form_Bilance_Load;
            ((System.ComponentModel.ISupportInitialize)bsBalA1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsBalA1;
        private MyDataGridView dgvBalA1;
        private MyTextBox tbSD;
        private MyTextBox tbED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmReport;
        private System.Windows.Forms.Button cmEdit;
        private System.Windows.Forms.ListBox lbCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1balid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1TP;
        private System.Windows.Forms.Button cmTable;
    }
}