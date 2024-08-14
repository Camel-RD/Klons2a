
namespace KlonsF.FormsReportParams
{
    partial class FormRep_EdsTp
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
            panel1 = new System.Windows.Forms.Panel();
            cbReport = new KlonsLIB.Components.FlatComboBox();
            btImport = new System.Windows.Forms.Button();
            cbYear = new KlonsLIB.Components.FlatComboBox();
            label1 = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcTitleShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcM12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbReport);
            panel1.Controls.Add(btImport);
            panel1.Controls.Add(cbYear);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1106, 33);
            panel1.TabIndex = 0;
            // 
            // cbReport
            // 
            cbReport.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbReport.FormattingEnabled = true;
            cbReport.Items.AddRange(new object[] { "Deklarēts", "Nokavējuma naudas aprēķins", "Iemaksāts", "Atmaksāts", "Savstarpējais ieskaits", "Cits" });
            cbReport.Location = new System.Drawing.Point(338, 4);
            cbReport.Name = "cbReport";
            cbReport.Size = new System.Drawing.Size(277, 24);
            cbReport.TabIndex = 3;
            cbReport.SelectedIndexChanged += cbReport_SelectedIndexChanged;
            // 
            // btImport
            // 
            btImport.Location = new System.Drawing.Point(171, 2);
            btImport.Name = "btImport";
            btImport.Size = new System.Drawing.Size(151, 27);
            btImport.TabIndex = 2;
            btImport.Text = "Nolasīt mo XML faila";
            btImport.UseVisualStyleBackColor = true;
            btImport.Click += btImport_Click;
            // 
            // cbYear
            // 
            cbYear.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYear.FormattingEnabled = true;
            cbYear.Location = new System.Drawing.Point(70, 4);
            cbYear.Name = "cbYear";
            cbYear.Size = new System.Drawing.Size(80, 24);
            cbYear.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 17);
            label1.TabIndex = 0;
            label1.Text = "Gads:";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
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
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcTitleShort, dgcMp, dgcM1, dgcM2, dgcM3, dgcM4, dgcM5, dgcM6, dgcM7, dgcM8, dgcM9, dgcM10, dgcM11, dgcM12 });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 33);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 25;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1106, 417);
            dgvRows.TabIndex = 1;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcTitleShort
            // 
            dgcTitleShort.DataPropertyName = "TitleShort";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgcTitleShort.DefaultCellStyle = dataGridViewCellStyle2;
            dgcTitleShort.Frozen = true;
            dgcTitleShort.HeaderText = "nosaukums";
            dgcTitleShort.MinimumWidth = 8;
            dgcTitleShort.Name = "dgcTitleShort";
            dgcTitleShort.ReadOnly = true;
            dgcTitleShort.Width = 120;
            // 
            // dgcMp
            // 
            dgcMp.DataPropertyName = "Mp";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcMp.DefaultCellStyle = dataGridViewCellStyle3;
            dgcMp.HeaderText = "iepriekš.";
            dgcMp.MinimumWidth = 8;
            dgcMp.Name = "dgcMp";
            dgcMp.ReadOnly = true;
            dgcMp.Width = 95;
            // 
            // dgcM1
            // 
            dgcM1.DataPropertyName = "M1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcM1.DefaultCellStyle = dataGridViewCellStyle4;
            dgcM1.HeaderText = "01";
            dgcM1.MinimumWidth = 8;
            dgcM1.Name = "dgcM1";
            dgcM1.ReadOnly = true;
            dgcM1.Width = 95;
            // 
            // dgcM2
            // 
            dgcM2.DataPropertyName = "M2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcM2.DefaultCellStyle = dataGridViewCellStyle5;
            dgcM2.HeaderText = "02";
            dgcM2.MinimumWidth = 8;
            dgcM2.Name = "dgcM2";
            dgcM2.ReadOnly = true;
            dgcM2.Width = 95;
            // 
            // dgcM3
            // 
            dgcM3.DataPropertyName = "M3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcM3.DefaultCellStyle = dataGridViewCellStyle6;
            dgcM3.HeaderText = "03";
            dgcM3.MinimumWidth = 8;
            dgcM3.Name = "dgcM3";
            dgcM3.ReadOnly = true;
            dgcM3.Width = 95;
            // 
            // dgcM4
            // 
            dgcM4.DataPropertyName = "M4";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dgcM4.DefaultCellStyle = dataGridViewCellStyle7;
            dgcM4.HeaderText = "04";
            dgcM4.MinimumWidth = 8;
            dgcM4.Name = "dgcM4";
            dgcM4.ReadOnly = true;
            dgcM4.Width = 95;
            // 
            // dgcM5
            // 
            dgcM5.DataPropertyName = "M5";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dgcM5.DefaultCellStyle = dataGridViewCellStyle8;
            dgcM5.HeaderText = "05";
            dgcM5.MinimumWidth = 8;
            dgcM5.Name = "dgcM5";
            dgcM5.ReadOnly = true;
            dgcM5.Width = 95;
            // 
            // dgcM6
            // 
            dgcM6.DataPropertyName = "M6";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dgcM6.DefaultCellStyle = dataGridViewCellStyle9;
            dgcM6.HeaderText = "06";
            dgcM6.MinimumWidth = 8;
            dgcM6.Name = "dgcM6";
            dgcM6.ReadOnly = true;
            dgcM6.Width = 95;
            // 
            // dgcM7
            // 
            dgcM7.DataPropertyName = "M7";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dgcM7.DefaultCellStyle = dataGridViewCellStyle10;
            dgcM7.HeaderText = "07";
            dgcM7.MinimumWidth = 8;
            dgcM7.Name = "dgcM7";
            dgcM7.ReadOnly = true;
            dgcM7.Width = 95;
            // 
            // dgcM8
            // 
            dgcM8.DataPropertyName = "M8";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dgcM8.DefaultCellStyle = dataGridViewCellStyle11;
            dgcM8.HeaderText = "08";
            dgcM8.MinimumWidth = 8;
            dgcM8.Name = "dgcM8";
            dgcM8.ReadOnly = true;
            dgcM8.Width = 95;
            // 
            // dgcM9
            // 
            dgcM9.DataPropertyName = "M9";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dgcM9.DefaultCellStyle = dataGridViewCellStyle12;
            dgcM9.HeaderText = "09";
            dgcM9.MinimumWidth = 8;
            dgcM9.Name = "dgcM9";
            dgcM9.ReadOnly = true;
            dgcM9.Width = 95;
            // 
            // dgcM10
            // 
            dgcM10.DataPropertyName = "M10";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dgcM10.DefaultCellStyle = dataGridViewCellStyle13;
            dgcM10.HeaderText = "10";
            dgcM10.MinimumWidth = 8;
            dgcM10.Name = "dgcM10";
            dgcM10.ReadOnly = true;
            dgcM10.Width = 95;
            // 
            // dgcM11
            // 
            dgcM11.DataPropertyName = "M11";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dgcM11.DefaultCellStyle = dataGridViewCellStyle14;
            dgcM11.HeaderText = "11";
            dgcM11.MinimumWidth = 8;
            dgcM11.Name = "dgcM11";
            dgcM11.ReadOnly = true;
            dgcM11.Width = 95;
            // 
            // dgcM12
            // 
            dgcM12.DataPropertyName = "M12";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            dgcM12.DefaultCellStyle = dataGridViewCellStyle15;
            dgcM12.HeaderText = "12";
            dgcM12.MinimumWidth = 8;
            dgcM12.Name = "dgcM12";
            dgcM12.ReadOnly = true;
            dgcM12.Width = 95;
            // 
            // FormRep_EdsTp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1106, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormRep_EdsTp";
            Text = "EDS transakciju pārskats";
            Load += FormRep_EdsTp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btImport;
        private KlonsLIB.Components.FlatComboBox cbYear;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Components.FlatComboBox cbReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTitleShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcM12;
    }
}