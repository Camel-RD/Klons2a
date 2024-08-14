namespace KlonsA.Forms
{
    partial class FormA_DataLoad
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
            cbYr1 = new KlonsLIB.Components.MyMcFlatComboBox();
            cbMt1 = new KlonsLIB.Components.MyMcFlatComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cbYr2 = new KlonsLIB.Components.MyMcFlatComboBox();
            cbMt2 = new KlonsLIB.Components.MyMcFlatComboBox();
            label3 = new System.Windows.Forms.Label();
            cmOK = new System.Windows.Forms.Button();
            cmCancel = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lbSalaryPeriod = new System.Windows.Forms.Label();
            lbTimeTablePeriod = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbYr1
            // 
            cbYr1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYr1.ColumnWidths = "45";
            cbYr1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYr1.DropDownHeight = 144;
            cbYr1.DropDownWidth = 64;
            cbYr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYr1.FormattingEnabled = true;
            cbYr1.GridLineColor = System.Drawing.Color.LightGray;
            cbYr1.GridLineHorizontal = false;
            cbYr1.GridLineVertical = false;
            cbYr1.IntegralHeight = false;
            cbYr1.Items.AddRange(new object[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            cbYr1.Location = new System.Drawing.Point(75, 31);
            cbYr1.Name = "cbYr1";
            cbYr1.Size = new System.Drawing.Size(69, 24);
            cbYr1.TabIndex = 0;
            cbYr1.SelectedIndexChanged += cbYr1_SelectedIndexChanged;
            // 
            // cbMt1
            // 
            cbMt1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbMt1.ColumnWidths = "35";
            cbMt1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbMt1.DropDownHeight = 234;
            cbMt1.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbMt1.DropDownWidth = 54;
            cbMt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbMt1.FormattingEnabled = true;
            cbMt1.GridLineColor = System.Drawing.Color.LightGray;
            cbMt1.GridLineHorizontal = false;
            cbMt1.GridLineVertical = false;
            cbMt1.IntegralHeight = false;
            cbMt1.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbMt1.Location = new System.Drawing.Point(150, 31);
            cbMt1.MaxDropDownItems = 13;
            cbMt1.Name = "cbMt1";
            cbMt1.Size = new System.Drawing.Size(57, 24);
            cbMt1.TabIndex = 1;
            cbMt1.SelectedIndexChanged += cbMt1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 17);
            label1.TabIndex = 7;
            label1.Text = "No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 17);
            label2.TabIndex = 8;
            label2.Text = "Līdz:";
            // 
            // cbYr2
            // 
            cbYr2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYr2.ColumnWidths = "45";
            cbYr2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYr2.DropDownHeight = 144;
            cbYr2.DropDownWidth = 64;
            cbYr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYr2.FormattingEnabled = true;
            cbYr2.GridLineColor = System.Drawing.Color.LightGray;
            cbYr2.GridLineHorizontal = false;
            cbYr2.GridLineVertical = false;
            cbYr2.IntegralHeight = false;
            cbYr2.Items.AddRange(new object[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            cbYr2.Location = new System.Drawing.Point(75, 61);
            cbYr2.Name = "cbYr2";
            cbYr2.Size = new System.Drawing.Size(69, 24);
            cbYr2.TabIndex = 2;
            // 
            // cbMt2
            // 
            cbMt2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbMt2.ColumnWidths = "35";
            cbMt2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbMt2.DropDownHeight = 234;
            cbMt2.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbMt2.DropDownWidth = 54;
            cbMt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbMt2.FormattingEnabled = true;
            cbMt2.GridLineColor = System.Drawing.Color.LightGray;
            cbMt2.GridLineHorizontal = false;
            cbMt2.GridLineVertical = false;
            cbMt2.IntegralHeight = false;
            cbMt2.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbMt2.Location = new System.Drawing.Point(150, 61);
            cbMt2.MaxDropDownItems = 13;
            cbMt2.Name = "cbMt2";
            cbMt2.Size = new System.Drawing.Size(57, 24);
            cbMt2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            label3.Location = new System.Drawing.Point(12, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(394, 17);
            label3.TabIndex = 6;
            label3.Text = "Atlasīt datus rediģēšanai norādītajam laika periodam:";
            // 
            // cmOK
            // 
            cmOK.Location = new System.Drawing.Point(205, 191);
            cmOK.Name = "cmOK";
            cmOK.Size = new System.Drawing.Size(112, 44);
            cmOK.TabIndex = 4;
            cmOK.Text = "Atlasīt";
            cmOK.UseVisualStyleBackColor = true;
            cmOK.Click += cmOK_Click;
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(336, 191);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(112, 44);
            cmCancel.TabIndex = 5;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            label4.Location = new System.Drawing.Point(12, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(203, 17);
            label4.TabIndex = 9;
            label4.Text = "Datu bāze satur datus par:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(35, 128);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 17);
            label5.TabIndex = 9;
            label5.Text = "algu lapas: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(35, 155);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(124, 17);
            label6.TabIndex = 9;
            label6.Text = "darba laika lapas: ";
            // 
            // lbSalaryPeriod
            // 
            lbSalaryPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lbSalaryPeriod.Location = new System.Drawing.Point(159, 128);
            lbSalaryPeriod.Name = "lbSalaryPeriod";
            lbSalaryPeriod.Size = new System.Drawing.Size(289, 16);
            lbSalaryPeriod.TabIndex = 9;
            lbSalaryPeriod.Text = "nav";
            // 
            // lbTimeTablePeriod
            // 
            lbTimeTablePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lbTimeTablePeriod.Location = new System.Drawing.Point(159, 155);
            lbTimeTablePeriod.Name = "lbTimeTablePeriod";
            lbTimeTablePeriod.Size = new System.Drawing.Size(289, 16);
            lbTimeTablePeriod.TabIndex = 9;
            lbTimeTablePeriod.Text = "nav";
            // 
            // FormA_DataLoad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cmCancel;
            ClientSize = new System.Drawing.Size(462, 249);
            Controls.Add(label6);
            Controls.Add(lbTimeTablePeriod);
            Controls.Add(lbSalaryPeriod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmCancel);
            Controls.Add(cmOK);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbMt2);
            Controls.Add(cbMt1);
            Controls.Add(cbYr2);
            Controls.Add(cbYr1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormA_DataLoad";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Datu atlase";
            Load += Form_DataLoad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyMcFlatComboBox cbYr1;
        private KlonsLIB.Components.MyMcFlatComboBox cbMt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyMcFlatComboBox cbYr2;
        private KlonsLIB.Components.MyMcFlatComboBox cbMt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmOK;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSalaryPeriod;
        private System.Windows.Forms.Label lbTimeTablePeriod;
    }
}