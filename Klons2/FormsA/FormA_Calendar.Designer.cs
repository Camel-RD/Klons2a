namespace KlonsA.Forms
{
    partial class FormA_Calendar
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
            panel1 = new System.Windows.Forms.Panel();
            btYR3 = new System.Windows.Forms.Button();
            btYR2 = new System.Windows.Forms.Button();
            btYR1 = new System.Windows.Forms.Button();
            lbDates = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbYR = new KlonsLIB.Components.MyMcFlatComboBox();
            grid = new KlonsF.Classes.SourceGridA();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btYR3);
            panel1.Controls.Add(btYR2);
            panel1.Controls.Add(btYR1);
            panel1.Controls.Add(lbDates);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbYR);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(900, 34);
            panel1.TabIndex = 0;
            // 
            // btYR3
            // 
            btYR3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btYR3.Location = new System.Drawing.Point(190, 3);
            btYR3.Margin = new System.Windows.Forms.Padding(0);
            btYR3.Name = "btYR3";
            btYR3.Size = new System.Drawing.Size(55, 27);
            btYR3.TabIndex = 4;
            btYR3.Text = "2024";
            btYR3.UseVisualStyleBackColor = true;
            btYR3.Click += btYR3_Click;
            // 
            // btYR2
            // 
            btYR2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btYR2.Location = new System.Drawing.Point(133, 3);
            btYR2.Margin = new System.Windows.Forms.Padding(0);
            btYR2.Name = "btYR2";
            btYR2.Size = new System.Drawing.Size(55, 27);
            btYR2.TabIndex = 4;
            btYR2.Text = "2023";
            btYR2.UseVisualStyleBackColor = true;
            btYR2.Click += btYR2_Click;
            // 
            // btYR1
            // 
            btYR1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btYR1.Location = new System.Drawing.Point(76, 3);
            btYR1.Margin = new System.Windows.Forms.Padding(0);
            btYR1.Name = "btYR1";
            btYR1.Size = new System.Drawing.Size(55, 27);
            btYR1.TabIndex = 4;
            btYR1.Text = "2022";
            btYR1.UseVisualStyleBackColor = true;
            btYR1.Click += btYR1_Click;
            // 
            // lbDates
            // 
            lbDates.AutoSize = true;
            lbDates.Location = new System.Drawing.Point(362, 8);
            lbDates.Name = "lbDates";
            lbDates.Size = new System.Drawing.Size(138, 17);
            lbDates.TabIndex = 3;
            lbDates.Text = "[ peles kreisais klik. ]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 17);
            label1.TabIndex = 2;
            label1.Text = "Gads:";
            // 
            // cbYR
            // 
            cbYR.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbYR.ColumnNames = new string[]
    {
    "Key",
    "Val"
    };
            cbYR.ColumnWidths = "0;62";
            cbYR.DisplayMember = "Val";
            cbYR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbYR.DropDownHeight = 180;
            cbYR.DropDownWidth = 81;
            cbYR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbYR.FormattingEnabled = true;
            cbYR.GridLineColor = System.Drawing.Color.LightGray;
            cbYR.GridLineHorizontal = false;
            cbYR.GridLineVertical = false;
            cbYR.IntegralHeight = false;
            cbYR.Location = new System.Drawing.Point(257, 5);
            cbYR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbYR.MaxDropDownItems = 10;
            cbYR.Name = "cbYR";
            cbYR.Size = new System.Drawing.Size(90, 24);
            cbYR.TabIndex = 1;
            cbYR.ValueMember = "Key";
            cbYR.SelectedIndexChanged += cbYR_SelectedIndexChanged;
            cbYR.KeyDown += cbYR_KeyDown;
            // 
            // grid
            // 
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            grid.EnableSort = true;
            grid.Location = new System.Drawing.Point(0, 34);
            grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grid.Name = "grid";
            grid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            grid.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            grid.Size = new System.Drawing.Size(900, 528);
            grid.TabIndex = 1;
            grid.TabStop = true;
            grid.ToolTipText = "";
            // 
            // FormA_Calendar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 562);
            Controls.Add(grid);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormA_Calendar";
            Text = "Kalendārs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyMcFlatComboBox cbYR;
        private KlonsF.Classes.SourceGridA grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDates;
        private System.Windows.Forms.Button btYR3;
        private System.Windows.Forms.Button btYR2;
        private System.Windows.Forms.Button btYR1;
    }
}