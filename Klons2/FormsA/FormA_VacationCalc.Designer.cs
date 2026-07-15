namespace KlonsA.Forms
{
    partial class FormA_VacationCalc
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
            dgvSar = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIINEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            tbRateCalDay = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            cmReport = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            tbRateDay = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            tbRateHour = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
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
            dgvSar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcDays, dgcHours, dgcRate, dgcPay, dgcDNS, dgcIINEx, dgcIIN, dgcCash });
            dgvSar.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSar.Location = new System.Drawing.Point(0, 0);
            dgvSar.Name = "dgvSar";
            dgvSar.ReadOnly = true;
            dgvSar.RowHeadersVisible = false;
            dgvSar.Size = new System.Drawing.Size(828, 211);
            dgvSar.TabIndex = 0;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "Caption";
            dgcCaption.HeaderText = "datumi";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            dgcCaption.Width = 200;
            // 
            // dgcDays
            // 
            dgcDays.DataPropertyName = "Days";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "0;-0;\"\"";
            dgcDays.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDays.HeaderText = "dienas";
            dgcDays.Name = "dgcDays";
            dgcDays.ReadOnly = true;
            dgcDays.Width = 60;
            // 
            // dgcHours
            // 
            dgcHours.DataPropertyName = "Hours";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "0.##;-0.##;\"\"";
            dataGridViewCellStyle3.NullValue = null;
            dgcHours.DefaultCellStyle = dataGridViewCellStyle3;
            dgcHours.HeaderText = "stundas";
            dgcHours.Name = "dgcHours";
            dgcHours.ReadOnly = true;
            dgcHours.Width = 60;
            // 
            // dgcRate
            // 
            dgcRate.DataPropertyName = "AvPayRate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.0000;-0.0000";
            dgcRate.DefaultCellStyle = dataGridViewCellStyle4;
            dgcRate.HeaderText = "likme";
            dgcRate.Name = "dgcRate";
            dgcRate.ReadOnly = true;
            dgcRate.ToolTipText = "Piemērotā vidējās izpeļņas dienas likme";
            dgcRate.Width = 80;
            // 
            // dgcPay
            // 
            dgcPay.DataPropertyName = "Pay";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.00;-0.00;\"\"";
            dgcPay.DefaultCellStyle = dataGridViewCellStyle5;
            dgcPay.HeaderText = "aprēķināts";
            dgcPay.Name = "dgcPay";
            dgcPay.ReadOnly = true;
            dgcPay.Width = 80;
            // 
            // dgcDNS
            // 
            dgcDNS.DataPropertyName = "DNS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.00;-0.00;\"\"";
            dgcDNS.DefaultCellStyle = dataGridViewCellStyle6;
            dgcDNS.HeaderText = "DŅ SI";
            dgcDNS.Name = "dgcDNS";
            dgcDNS.ReadOnly = true;
            dgcDNS.Width = 80;
            // 
            // dgcIINEx
            // 
            dgcIINEx.DataPropertyName = "IINEX";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "0.00;-0.00;\"\"";
            dgcIINEx.DefaultCellStyle = dataGridViewCellStyle7;
            dgcIINEx.HeaderText = "IIN atv.";
            dgcIINEx.Name = "dgcIINEx";
            dgcIINEx.ReadOnly = true;
            dgcIINEx.Width = 80;
            // 
            // dgcIIN
            // 
            dgcIIN.DataPropertyName = "IIN";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.00;-0.00;\"\"";
            dgcIIN.DefaultCellStyle = dataGridViewCellStyle8;
            dgcIIN.HeaderText = "IIN";
            dgcIIN.Name = "dgcIIN";
            dgcIIN.ReadOnly = true;
            dgcIIN.Width = 80;
            // 
            // dgcCash
            // 
            dgcCash.DataPropertyName = "Cash";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.00;-0.00;\"\"";
            dgcCash.DefaultCellStyle = dataGridViewCellStyle9;
            dgcCash.HeaderText = "pēc nod.";
            dgcCash.Name = "dgcCash";
            dgcCash.ReadOnly = true;
            dgcCash.Width = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbRateCalDay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbRateDay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbRateHour);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 211);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(828, 145);
            panel1.TabIndex = 24;
            // 
            // tbRateCalDay
            // 
            tbRateCalDay.BackColor = System.Drawing.SystemColors.Control;
            tbRateCalDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateCalDay.Location = new System.Drawing.Point(206, 92);
            tbRateCalDay.Name = "tbRateCalDay";
            tbRateCalDay.ReadOnly = true;
            tbRateCalDay.Size = new System.Drawing.Size(86, 23);
            tbRateCalDay.TabIndex = 32;
            tbRateCalDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 34);
            label1.TabIndex = 33;
            label1.Text = "Aprēķinātā vidējā kalendāra \r\ndienas likme:";
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(532, 42);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(120, 44);
            cmReport.TabIndex = 26;
            cmReport.Text = "Izdrukai";
            cmReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(532, 92);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 27;
            button1.Text = "Aizvērt";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbRateDay
            // 
            tbRateDay.BackColor = System.Drawing.SystemColors.Control;
            tbRateDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateDay.Location = new System.Drawing.Point(206, 64);
            tbRateDay.Name = "tbRateDay";
            tbRateDay.ReadOnly = true;
            tbRateDay.Size = new System.Drawing.Size(86, 23);
            tbRateDay.TabIndex = 25;
            tbRateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(16, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 17);
            label3.TabIndex = 30;
            label3.Text = "Vidējā dienas likme:";
            // 
            // tbRateHour
            // 
            tbRateHour.BackColor = System.Drawing.SystemColors.Control;
            tbRateHour.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateHour.Location = new System.Drawing.Point(206, 36);
            tbRateHour.Name = "tbRateHour";
            tbRateHour.ReadOnly = true;
            tbRateHour.Size = new System.Drawing.Size(86, 23);
            tbRateHour.TabIndex = 24;
            tbRateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 17);
            label2.TabIndex = 29;
            label2.Text = "Vidējā stundas likme:";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 186);
            lbTitle.Location = new System.Drawing.Point(10, 10);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(41, 13);
            lbTitle.TabIndex = 28;
            lbTitle.Text = "label1";
            // 
            // FormA_VacationCalc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 356);
            Controls.Add(dgvSar);
            Controls.Add(panel1);
            Name = "FormA_VacationCalc";
            Text = "Atvaļinājuma naudas aprēķins";
            Load += Form_VacationCalc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvSar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmReport;
        private System.Windows.Forms.Button button1;
        private KlonsLIB.Components.MyTextBox tbRateDay;
        private System.Windows.Forms.Label label3;
        private KlonsLIB.Components.MyTextBox tbRateHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private KlonsLIB.Components.MyTextBox tbRateCalDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIINEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCash;
    }
}