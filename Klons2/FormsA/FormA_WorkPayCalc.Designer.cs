namespace KlonsA.Forms
{
    partial class FormA_WorkPayCalc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvSar = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
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
            dgvSar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcDays, dgcHours, dgcRMT, dgcRateType, dgcRHR, dgcSalary });
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Format = "0.####;-0.####;\"\"";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvSar.DefaultCellStyle = dataGridViewCellStyle9;
            dgvSar.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSar.Location = new System.Drawing.Point(0, 0);
            dgvSar.Name = "dgvSar";
            dgvSar.ReadOnly = true;
            dgvSar.RowHeadersVisible = false;
            dgvSar.Size = new System.Drawing.Size(742, 236);
            dgvSar.TabIndex = 0;
            dgvSar.CellPainting += dgvSar_CellPainting;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "Caption";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgcCaption.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCaption.Frozen = true;
            dgcCaption.HeaderText = "";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            dgcCaption.Width = 180;
            // 
            // dgcDays
            // 
            dgcDays.DataPropertyName = "Days";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "0;-0;\"\"";
            dgcDays.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDays.HeaderText = "dienas";
            dgcDays.Name = "dgcDays";
            dgcDays.ReadOnly = true;
            dgcDays.Width = 60;
            // 
            // dgcHours
            // 
            dgcHours.DataPropertyName = "Hours";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "0.##;-0.##;\"\"";
            dgcHours.DefaultCellStyle = dataGridViewCellStyle4;
            dgcHours.HeaderText = "stundas";
            dgcHours.Name = "dgcHours";
            dgcHours.ReadOnly = true;
            dgcHours.Width = 60;
            // 
            // dgcRMT
            // 
            dgcRMT.DataPropertyName = "RateDef";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "### ##0.####;-### ##0.####;\"\"";
            dgcRMT.DefaultCellStyle = dataGridViewCellStyle5;
            dgcRMT.HeaderText = "likme";
            dgcRMT.Name = "dgcRMT";
            dgcRMT.ReadOnly = true;
            dgcRMT.Width = 80;
            // 
            // dgcRateType
            // 
            dgcRateType.DataPropertyName = "RateType";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRateType.DefaultCellStyle = dataGridViewCellStyle6;
            dgcRateType.HeaderText = "likmes veids";
            dgcRateType.Name = "dgcRateType";
            dgcRateType.ReadOnly = true;
            dgcRateType.Width = 60;
            // 
            // dgcRHR
            // 
            dgcRHR.DataPropertyName = "Rate";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "0.####;-0.####;\"\"";
            dgcRHR.DefaultCellStyle = dataGridViewCellStyle7;
            dgcRHR.HeaderText = "apr. likme";
            dgcRHR.Name = "dgcRHR";
            dgcRHR.ReadOnly = true;
            // 
            // dgcSalary
            // 
            dgcSalary.DataPropertyName = "Salary";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "### ##0.00;-### ##0.00;\"\"";
            dgcSalary.DefaultCellStyle = dataGridViewCellStyle8;
            dgcSalary.HeaderText = "samaksa";
            dgcSalary.Name = "dgcSalary";
            dgcSalary.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbRateDay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbRateHour);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 236);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(742, 129);
            panel1.TabIndex = 1;
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(378, 39);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(120, 44);
            cmReport.TabIndex = 33;
            cmReport.Text = "Izdrukai";
            cmReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(513, 41);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(120, 42);
            button1.TabIndex = 34;
            button1.Text = "Aizvērt";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbRateDay
            // 
            tbRateDay.BackColor = System.Drawing.SystemColors.Control;
            tbRateDay.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateDay.Location = new System.Drawing.Point(202, 61);
            tbRateDay.Name = "tbRateDay";
            tbRateDay.ReadOnly = true;
            tbRateDay.Size = new System.Drawing.Size(86, 23);
            tbRateDay.TabIndex = 32;
            tbRateDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 63);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(133, 17);
            label3.TabIndex = 37;
            label3.Text = "Vidējā dienas likme:";
            // 
            // tbRateHour
            // 
            tbRateHour.BackColor = System.Drawing.SystemColors.Control;
            tbRateHour.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRateHour.Location = new System.Drawing.Point(202, 33);
            tbRateHour.Name = "tbRateHour";
            tbRateHour.ReadOnly = true;
            tbRateHour.Size = new System.Drawing.Size(86, 23);
            tbRateHour.TabIndex = 31;
            tbRateHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 17);
            label2.TabIndex = 36;
            label2.Text = "Vidējā stundas likme:";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.488F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 186);
            lbTitle.Location = new System.Drawing.Point(6, 7);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(41, 13);
            lbTitle.TabIndex = 35;
            lbTitle.Text = "label1";
            // 
            // FormA_WorkPayCalc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(742, 365);
            Controls.Add(dgvSar);
            Controls.Add(panel1);
            Name = "FormA_WorkPayCalc";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Darba samaksas aprēķins";
            Load += Form_WorkPayCalc_Load;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSalary;
    }
}