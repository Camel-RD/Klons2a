namespace KlonsA.Forms
{
    partial class FormA_AvPayCalc
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
            dgvSar = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBruto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMonthWorkDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMonthWorkHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDaysPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHoursPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDaysFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHoursFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            tbRateCalDay = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            cmReport = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tbRateDay = new KlonsLIB.Components.MyTextBox();
            tbRateHour = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lbRem = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvSar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSar
            // 
            dgvSar.AllowUserToAddRows = false;
            dgvSar.AllowUserToDeleteRows = false;
            dgvSar.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcSalary, dgcBruto2, dgcPay, dgcCalDays, dgcMonthWorkDays, dgcMonthWorkHours, dgcDaysPlan, dgcHoursPlan, dgcDaysFact, dgcHoursFact });
            dgvSar.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSar.Location = new System.Drawing.Point(0, 0);
            dgvSar.Name = "dgvSar";
            dgvSar.ReadOnly = true;
            dgvSar.RowHeadersWidth = 25;
            dgvSar.Size = new System.Drawing.Size(902, 234);
            dgvSar.TabIndex = 0;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "Caption";
            dgcCaption.HeaderText = "mēnesis";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            // 
            // dgcSalary
            // 
            dgcSalary.DataPropertyName = "Salary";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcSalary.DefaultCellStyle = dataGridViewCellStyle2;
            dgcSalary.HeaderText = "darba samaksa";
            dgcSalary.Name = "dgcSalary";
            dgcSalary.ReadOnly = true;
            dgcSalary.Width = 80;
            // 
            // dgcBruto2
            // 
            dgcBruto2.DataPropertyName = "Salary2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcBruto2.DefaultCellStyle = dataGridViewCellStyle3;
            dgcBruto2.HeaderText = "bruto";
            dgcBruto2.Name = "dgcBruto2";
            dgcBruto2.ReadOnly = true;
            dgcBruto2.Width = 80;
            // 
            // dgcPay
            // 
            dgcPay.DataPropertyName = "Pay";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcPay.DefaultCellStyle = dataGridViewCellStyle4;
            dgcPay.HeaderText = "izmaksāts";
            dgcPay.Name = "dgcPay";
            dgcPay.ReadOnly = true;
            dgcPay.Width = 80;
            // 
            // dgcCalDays
            // 
            dgcCalDays.DataPropertyName = "CalendarDays";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCalDays.DefaultCellStyle = dataGridViewCellStyle5;
            dgcCalDays.HeaderText = "kalend. dienas";
            dgcCalDays.Name = "dgcCalDays";
            dgcCalDays.ReadOnly = true;
            dgcCalDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCalDays.ToolTipText = "kalendāra dienas";
            dgcCalDays.Width = 70;
            // 
            // dgcMonthWorkDays
            // 
            dgcMonthWorkDays.DataPropertyName = "DaysPlan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcMonthWorkDays.DefaultCellStyle = dataGridViewCellStyle6;
            dgcMonthWorkDays.HeaderText = "kalend. darba d.";
            dgcMonthWorkDays.Name = "dgcMonthWorkDays";
            dgcMonthWorkDays.ReadOnly = true;
            dgcMonthWorkDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcMonthWorkDays.Width = 70;
            // 
            // dgcMonthWorkHours
            // 
            dgcMonthWorkHours.DataPropertyName = "HoursPlan";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcMonthWorkHours.DefaultCellStyle = dataGridViewCellStyle7;
            dgcMonthWorkHours.HeaderText = "kalend. darba st.";
            dgcMonthWorkHours.Name = "dgcMonthWorkHours";
            dgcMonthWorkHours.ReadOnly = true;
            dgcMonthWorkHours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcMonthWorkHours.Width = 70;
            // 
            // dgcDaysPlan
            // 
            dgcDaysPlan.DataPropertyName = "WorkDaysPlan";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcDaysPlan.DefaultCellStyle = dataGridViewCellStyle8;
            dgcDaysPlan.HeaderText = "dienas plāns";
            dgcDaysPlan.Name = "dgcDaysPlan";
            dgcDaysPlan.ReadOnly = true;
            dgcDaysPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDaysPlan.Width = 70;
            // 
            // dgcHoursPlan
            // 
            dgcHoursPlan.DataPropertyName = "WorkHoursPlan";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcHoursPlan.DefaultCellStyle = dataGridViewCellStyle9;
            dgcHoursPlan.HeaderText = "stundas plāns";
            dgcHoursPlan.Name = "dgcHoursPlan";
            dgcHoursPlan.ReadOnly = true;
            dgcHoursPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcHoursPlan.Width = 70;
            // 
            // dgcDaysFact
            // 
            dgcDaysFact.DataPropertyName = "DaysFact";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcDaysFact.DefaultCellStyle = dataGridViewCellStyle10;
            dgcDaysFact.HeaderText = "dienas fakts";
            dgcDaysFact.Name = "dgcDaysFact";
            dgcDaysFact.ReadOnly = true;
            dgcDaysFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDaysFact.Width = 70;
            // 
            // dgcHoursFact
            // 
            dgcHoursFact.DataPropertyName = "HoursFact";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcHoursFact.DefaultCellStyle = dataGridViewCellStyle11;
            dgcHoursFact.HeaderText = "stundas fakts";
            dgcHoursFact.Name = "dgcHoursFact";
            dgcHoursFact.ReadOnly = true;
            dgcHoursFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcHoursFact.Width = 70;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbRateCalDay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbRateDay);
            panel1.Controls.Add(tbRateHour);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbRem);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 234);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(902, 138);
            panel1.TabIndex = 1;
            // 
            // tbRateCalDay
            // 
            tbRateCalDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateCalDay.Location = new System.Drawing.Point(232, 83);
            tbRateCalDay.Name = "tbRateCalDay";
            tbRateCalDay.ReadOnly = true;
            tbRateCalDay.Size = new System.Drawing.Size(111, 23);
            tbRateCalDay.TabIndex = 9;
            tbRateCalDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(188, 34);
            label3.TabIndex = 10;
            label3.Text = "Aprēķinātā vidējā kalendāra \r\ndienas likme:";
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(385, 38);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(116, 44);
            cmReport.TabIndex = 8;
            cmReport.Text = "Izdrukai";
            cmReport.UseVisualStyleBackColor = true;
            cmReport.Click += cmReport_Click;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(522, 40);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 3;
            button1.Text = "Aizvērt";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbRateDay
            // 
            tbRateDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateDay.Location = new System.Drawing.Point(232, 55);
            tbRateDay.Name = "tbRateDay";
            tbRateDay.ReadOnly = true;
            tbRateDay.Size = new System.Drawing.Size(111, 23);
            tbRateDay.TabIndex = 1;
            tbRateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRateHour
            // 
            tbRateHour.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateHour.Location = new System.Drawing.Point(232, 28);
            tbRateHour.Name = "tbRateHour";
            tbRateHour.ReadOnly = true;
            tbRateHour.Size = new System.Drawing.Size(111, 23);
            tbRateHour.TabIndex = 0;
            tbRateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 57);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(203, 17);
            label2.TabIndex = 5;
            label2.Text = "Aprēķinātā vidējā dienas likme:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 17);
            label1.TabIndex = 4;
            label1.Text = "Aprēķinātā vidējā stundas likme:";
            // 
            // lbRem
            // 
            lbRem.AutoSize = true;
            lbRem.Location = new System.Drawing.Point(229, 113);
            lbRem.Name = "lbRem";
            lbRem.Size = new System.Drawing.Size(16, 17);
            lbRem.TabIndex = 7;
            lbRem.Text = "  ";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            lbTitle.Location = new System.Drawing.Point(3, 3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(52, 17);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "label1";
            // 
            // FormA_AvPayCalc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(902, 372);
            Controls.Add(dgvSar);
            Controls.Add(panel1);
            Name = "FormA_AvPayCalc";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Vidējās izpeļņas aprēķins";
            Load += Form_AvPayCalc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvSar;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbRateDay;
        private KlonsLIB.Components.MyTextBox tbRateHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRem;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmReport;
        private KlonsLIB.Components.MyTextBox tbRateCalDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBruto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMonthWorkDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMonthWorkHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDaysPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHoursPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDaysFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHoursFact;
    }
}