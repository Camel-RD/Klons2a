namespace KlonsA.Forms
{
    partial class FormARep_ActivePersons
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
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            cmTable = new System.Windows.Forms.Button();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            bsRows = new System.Windows.Forms.BindingSource(components);
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHiredDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcVacDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDaysA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDaysB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcVacDaysOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDaysInVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmTable);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1213, 39);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(229, 11);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 17);
            label2.TabIndex = 4;
            label2.Text = "-";
            // 
            // cmTable
            // 
            cmTable.Location = new System.Drawing.Point(341, 3);
            cmTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmTable.Name = "cmTable";
            cmTable.Size = new System.Drawing.Size(75, 30);
            cmTable.TabIndex = 2;
            cmTable.Text = "Atlasīt";
            cmTable.UseVisualStyleBackColor = true;
            cmTable.Click += cmTable_Click;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(136, 7);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(90, 23);
            tbDate1.TabIndex = 0;
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(245, 7);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(90, 23);
            tbDate2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 17);
            label1.TabIndex = 3;
            label1.Text = "Datums, no - līdz:";
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersFontScale = 0.8F;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcName, dgcHired, dgcFired, dgcHiredDays, dgcVacDays, dgcSickDaysA, dgcSickDaysB, dgcVacDaysOther, dgcSickDaysInVac });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 39);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 30;
            dgvRows.Size = new System.Drawing.Size(1213, 481);
            dgvRows.TabIndex = 1;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.Frozen = true;
            dgcName.HeaderText = "darbinieks";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 250;
            // 
            // dgcHired
            // 
            dgcHired.DataPropertyName = "Hired";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcHired.DefaultCellStyle = dataGridViewCellStyle2;
            dgcHired.HeaderText = "pieņemts";
            dgcHired.MinimumWidth = 8;
            dgcHired.Name = "dgcHired";
            dgcHired.ReadOnly = true;
            dgcHired.Width = 85;
            // 
            // dgcFired
            // 
            dgcFired.DataPropertyName = "FIred";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            dgcFired.DefaultCellStyle = dataGridViewCellStyle3;
            dgcFired.HeaderText = "atlaists";
            dgcFired.MinimumWidth = 8;
            dgcFired.Name = "dgcFired";
            dgcFired.ReadOnly = true;
            dgcFired.Width = 85;
            // 
            // dgcHiredDays
            // 
            dgcHiredDays.DataPropertyName = "HiredDays";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "0;-0;\"\"";
            dgcHiredDays.DefaultCellStyle = dataGridViewCellStyle4;
            dgcHiredDays.HeaderText = "līguma dienas";
            dgcHiredDays.MinimumWidth = 8;
            dgcHiredDays.Name = "dgcHiredDays";
            dgcHiredDays.ReadOnly = true;
            dgcHiredDays.Width = 90;
            // 
            // dgcVacDays
            // 
            dgcVacDays.DataPropertyName = "VacDays";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "0;-0;\"\"";
            dgcVacDays.DefaultCellStyle = dataGridViewCellStyle5;
            dgcVacDays.HeaderText = "ikgadējais atvaļinājums - slimības";
            dgcVacDays.MinimumWidth = 8;
            dgcVacDays.Name = "dgcVacDays";
            dgcVacDays.ReadOnly = true;
            dgcVacDays.Width = 120;
            // 
            // dgcSickDaysA
            // 
            dgcSickDaysA.DataPropertyName = "SickDaysA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "0;-0;\"\"";
            dgcSickDaysA.DefaultCellStyle = dataGridViewCellStyle6;
            dgcSickDaysA.HeaderText = "slimības lapa A";
            dgcSickDaysA.MinimumWidth = 8;
            dgcSickDaysA.Name = "dgcSickDaysA";
            dgcSickDaysA.ReadOnly = true;
            dgcSickDaysA.Width = 120;
            // 
            // dgcSickDaysB
            // 
            dgcSickDaysB.DataPropertyName = "SickDaysB";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "0;-0;\"\"";
            dgcSickDaysB.DefaultCellStyle = dataGridViewCellStyle7;
            dgcSickDaysB.HeaderText = "slimības lapa B";
            dgcSickDaysB.MinimumWidth = 8;
            dgcSickDaysB.Name = "dgcSickDaysB";
            dgcSickDaysB.ReadOnly = true;
            dgcSickDaysB.Width = 120;
            // 
            // dgcVacDaysOther
            // 
            dgcVacDaysOther.DataPropertyName = "OtherVacDays";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "0;-0;\"\"";
            dgcVacDaysOther.DefaultCellStyle = dataGridViewCellStyle8;
            dgcVacDaysOther.HeaderText = "citi atvaļinājumi";
            dgcVacDaysOther.MinimumWidth = 8;
            dgcVacDaysOther.Name = "dgcVacDaysOther";
            dgcVacDaysOther.ReadOnly = true;
            dgcVacDaysOther.Width = 120;
            // 
            // dgcSickDaysInVac
            // 
            dgcSickDaysInVac.DataPropertyName = "SickDaysInVac";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "0;-0;\"\"";
            dgcSickDaysInVac.DefaultCellStyle = dataGridViewCellStyle9;
            dgcSickDaysInVac.HeaderText = "slimo atvaļinājumā";
            dgcSickDaysInVac.MinimumWidth = 8;
            dgcSickDaysInVac.Name = "dgcSickDaysInVac";
            dgcSickDaysInVac.ReadOnly = true;
            dgcSickDaysInVac.Width = 120;
            // 
            // FormARep_ActivePersons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1213, 520);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormARep_ActivePersons";
            Text = "Strādājošo pārskats";
            Load += FormARep_ActivePersons_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmTable;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFired;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHiredDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVacDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVacDaysOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDaysInVac;
    }
}