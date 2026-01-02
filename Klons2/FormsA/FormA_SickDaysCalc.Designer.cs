namespace KlonsA.Forms
{
    partial class FormA_SickDaysCalc
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
            dgvSar = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHours75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHours80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDayPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDayPay75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSickDayPay80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            cmReport = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tbRateDay = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            tbRateHour = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            tbPay80 = new KlonsLIB.Components.MyTextBox();
            label5 = new System.Windows.Forms.Label();
            tbPay75 = new KlonsLIB.Components.MyTextBox();
            label4 = new System.Windows.Forms.Label();
            tbPay = new KlonsLIB.Components.MyTextBox();
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
            dgvSar.AllowUserToResizeRows = false;
            dgvSar.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcDays, dgcDays0, dgcDays75, dgcDays80, dgcHours75, dgcHours80, dgcRate, dgcSickDayPay, dgcSickDayPay75, dgcSickDayPay80 });
            dgvSar.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSar.Location = new System.Drawing.Point(0, 0);
            dgvSar.Name = "dgvSar";
            dgvSar.ReadOnly = true;
            dgvSar.RowHeadersVisible = false;
            dgvSar.Size = new System.Drawing.Size(859, 233);
            dgvSar.TabIndex = 0;
            dgvSar.CellPainting += dgvSar_CellPainting;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "Caption";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCaption.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCaption.HeaderText = "";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            dgcCaption.Width = 180;
            // 
            // dgcDays
            // 
            dgcDays.DataPropertyName = "DaysCount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "0;-0;\"\"";
            dgcDays.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDays.HeaderText = "dienas";
            dgcDays.Name = "dgcDays";
            dgcDays.ReadOnly = true;
            dgcDays.Width = 50;
            // 
            // dgcDays0
            // 
            dgcDays0.DataPropertyName = "DaysCount0";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "0;-0;\"\"";
            dgcDays0.DefaultCellStyle = dataGridViewCellStyle4;
            dgcDays0.HeaderText = "dienas 0%";
            dgcDays0.Name = "dgcDays0";
            dgcDays0.ReadOnly = true;
            dgcDays0.Width = 50;
            // 
            // dgcDays75
            // 
            dgcDays75.DataPropertyName = "DaysCount75";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "0;-0;\"\"";
            dgcDays75.DefaultCellStyle = dataGridViewCellStyle5;
            dgcDays75.HeaderText = "dienas 75%";
            dgcDays75.Name = "dgcDays75";
            dgcDays75.ReadOnly = true;
            dgcDays75.Width = 50;
            // 
            // dgcDays80
            // 
            dgcDays80.DataPropertyName = "DaysCount80";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "0;-0;\"\"";
            dgcDays80.DefaultCellStyle = dataGridViewCellStyle6;
            dgcDays80.HeaderText = "dienas 80%";
            dgcDays80.Name = "dgcDays80";
            dgcDays80.ReadOnly = true;
            dgcDays80.Width = 50;
            // 
            // dgcHours75
            // 
            dgcHours75.DataPropertyName = "HoursCount75";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "0.###;-0.###;\"\"";
            dgcHours75.DefaultCellStyle = dataGridViewCellStyle7;
            dgcHours75.HeaderText = "stundas 75%";
            dgcHours75.Name = "dgcHours75";
            dgcHours75.ReadOnly = true;
            dgcHours75.Width = 65;
            // 
            // dgcHours80
            // 
            dgcHours80.DataPropertyName = "HoursCount80";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "0.###;-0.###;\"\"";
            dgcHours80.DefaultCellStyle = dataGridViewCellStyle8;
            dgcHours80.HeaderText = "stundas 80%";
            dgcHours80.Name = "dgcHours80";
            dgcHours80.ReadOnly = true;
            dgcHours80.Width = 65;
            // 
            // dgcRate
            // 
            dgcRate.DataPropertyName = "AvPayRate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.0000;-0.0000;\"\"";
            dgcRate.DefaultCellStyle = dataGridViewCellStyle9;
            dgcRate.HeaderText = "likme";
            dgcRate.Name = "dgcRate";
            dgcRate.ReadOnly = true;
            dgcRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcRate.Width = 80;
            // 
            // dgcSickDayPay
            // 
            dgcSickDayPay.DataPropertyName = "SickDayPay";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "0.00;-0.00;\"\"";
            dgcSickDayPay.DefaultCellStyle = dataGridViewCellStyle10;
            dgcSickDayPay.HeaderText = "apmaksa";
            dgcSickDayPay.Name = "dgcSickDayPay";
            dgcSickDayPay.ReadOnly = true;
            dgcSickDayPay.Width = 80;
            // 
            // dgcSickDayPay75
            // 
            dgcSickDayPay75.DataPropertyName = "SickDayPay75";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "0.00;-0.00;\"\"";
            dgcSickDayPay75.DefaultCellStyle = dataGridViewCellStyle11;
            dgcSickDayPay75.HeaderText = "apmaksa ar 75%";
            dgcSickDayPay75.Name = "dgcSickDayPay75";
            dgcSickDayPay75.ReadOnly = true;
            dgcSickDayPay75.Width = 80;
            // 
            // dgcSickDayPay80
            // 
            dgcSickDayPay80.DataPropertyName = "SickDayPay80";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "0.00;-0.00;\"\"";
            dgcSickDayPay80.DefaultCellStyle = dataGridViewCellStyle12;
            dgcSickDayPay80.HeaderText = "apmaksa ar 80%";
            dgcSickDayPay80.Name = "dgcSickDayPay80";
            dgcSickDayPay80.ReadOnly = true;
            dgcSickDayPay80.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbRateDay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbRateHour);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbPay80);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbPay75);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbPay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbRem);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(859, 146);
            panel1.TabIndex = 1;
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(525, 35);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(120, 44);
            cmReport.TabIndex = 5;
            cmReport.Text = "Izdrukai";
            cmReport.UseVisualStyleBackColor = true;
            cmReport.Click += cmReport_Click;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(525, 85);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 6;
            button1.Text = "Aizvērt";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbRateDay
            // 
            tbRateDay.BackColor = System.Drawing.SystemColors.Control;
            tbRateDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateDay.Location = new System.Drawing.Point(199, 57);
            tbRateDay.Name = "tbRateDay";
            tbRateDay.ReadOnly = true;
            tbRateDay.Size = new System.Drawing.Size(86, 23);
            tbRateDay.TabIndex = 1;
            tbRateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 17);
            label3.TabIndex = 9;
            label3.Text = "Vidējā dienas likme:";
            // 
            // tbRateHour
            // 
            tbRateHour.BackColor = System.Drawing.SystemColors.Control;
            tbRateHour.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateHour.Location = new System.Drawing.Point(199, 29);
            tbRateHour.Name = "tbRateHour";
            tbRateHour.ReadOnly = true;
            tbRateHour.Size = new System.Drawing.Size(86, 23);
            tbRateHour.TabIndex = 0;
            tbRateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 17);
            label2.TabIndex = 8;
            label2.Text = "Vidējā stundas likme:";
            // 
            // tbPay80
            // 
            tbPay80.BackColor = System.Drawing.SystemColors.Control;
            tbPay80.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPay80.Location = new System.Drawing.Point(357, 57);
            tbPay80.Name = "tbPay80";
            tbPay80.ReadOnly = true;
            tbPay80.Size = new System.Drawing.Size(86, 23);
            tbPay80.TabIndex = 4;
            tbPay80.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(303, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 17);
            label5.TabIndex = 13;
            label5.Text = "80%";
            // 
            // tbPay75
            // 
            tbPay75.BackColor = System.Drawing.SystemColors.Control;
            tbPay75.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPay75.Location = new System.Drawing.Point(357, 29);
            tbPay75.Name = "tbPay75";
            tbPay75.ReadOnly = true;
            tbPay75.Size = new System.Drawing.Size(86, 23);
            tbPay75.TabIndex = 3;
            tbPay75.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(303, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 17);
            label4.TabIndex = 12;
            label4.Text = "75%";
            // 
            // tbPay
            // 
            tbPay.BackColor = System.Drawing.SystemColors.Control;
            tbPay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPay.Location = new System.Drawing.Point(199, 85);
            tbPay.Name = "tbPay";
            tbPay.ReadOnly = true;
            tbPay.Size = new System.Drawing.Size(86, 23);
            tbPay.TabIndex = 2;
            tbPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 17);
            label1.TabIndex = 10;
            label1.Text = "Aprēķinātā slimības nauda:";
            // 
            // lbRem
            // 
            lbRem.AutoSize = true;
            lbRem.Location = new System.Drawing.Point(8, 116);
            lbRem.Name = "lbRem";
            lbRem.Size = new System.Drawing.Size(16, 17);
            lbRem.TabIndex = 11;
            lbRem.Text = "  ";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 186);
            lbTitle.Location = new System.Drawing.Point(3, 3);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(41, 13);
            lbTitle.TabIndex = 7;
            lbTitle.Text = "label1";
            // 
            // FormA_SickDaysCalc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(859, 379);
            Controls.Add(dgvSar);
            Controls.Add(panel1);
            Name = "FormA_SickDaysCalc";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Slimības naudas aprēķins";
            Load += Form_SickDaysCalc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvSar;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRem;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmReport;
        private KlonsLIB.Components.MyTextBox tbRateDay;
        private System.Windows.Forms.Label label3;
        private KlonsLIB.Components.MyTextBox tbRateHour;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyTextBox tbPay80;
        private System.Windows.Forms.Label label5;
        private KlonsLIB.Components.MyTextBox tbPay75;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHours75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHours80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDayPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDayPay75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSickDayPay80;
    }
}