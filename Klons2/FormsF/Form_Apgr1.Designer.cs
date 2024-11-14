namespace KlonsF.Forms
{
    partial class Form_Apgr1
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
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tslParams = new System.Windows.Forms.ToolStripLabel();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            bsRows = new KlonsLIB.Data.MyBindingSource(components);
            acDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aDbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aCrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tDbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tCrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bDbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bCrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslParams });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(939, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslParams
            // 
            tslParams.Name = "tslParams";
            tslParams.Size = new System.Drawing.Size(101, 22);
            tslParams.Text = "toolStripLabel1";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { acDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, aDbDataGridViewTextBoxColumn, aCrDataGridViewTextBoxColumn, tDbDataGridViewTextBoxColumn, tCrDataGridViewTextBoxColumn, bDbDataGridViewTextBoxColumn, bCrDataGridViewTextBoxColumn });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 25);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.Size = new System.Drawing.Size(939, 369);
            dgvRows.TabIndex = 1;
            // 
            // bsRows
            // 
            bsRows.DataMember = "ROps2a";
            bsRows.MyDataSource = "KlonsRep";
            // 
            // acDataGridViewTextBoxColumn
            // 
            acDataGridViewTextBoxColumn.DataPropertyName = "Ac";
            acDataGridViewTextBoxColumn.Frozen = true;
            acDataGridViewTextBoxColumn.HeaderText = "Konts";
            acDataGridViewTextBoxColumn.Name = "acDataGridViewTextBoxColumn";
            acDataGridViewTextBoxColumn.ReadOnly = true;
            acDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nosaukums";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // aDbDataGridViewTextBoxColumn
            // 
            aDbDataGridViewTextBoxColumn.DataPropertyName = "ADb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            aDbDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            aDbDataGridViewTextBoxColumn.HeaderText = "Debets sākumā";
            aDbDataGridViewTextBoxColumn.Name = "aDbDataGridViewTextBoxColumn";
            aDbDataGridViewTextBoxColumn.ReadOnly = true;
            aDbDataGridViewTextBoxColumn.ToolTipText = "Debeta atlikums perioda sākumā";
            aDbDataGridViewTextBoxColumn.Width = 95;
            // 
            // aCrDataGridViewTextBoxColumn
            // 
            aCrDataGridViewTextBoxColumn.DataPropertyName = "ACr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            aCrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            aCrDataGridViewTextBoxColumn.HeaderText = "kredīts sākumā";
            aCrDataGridViewTextBoxColumn.Name = "aCrDataGridViewTextBoxColumn";
            aCrDataGridViewTextBoxColumn.ReadOnly = true;
            aCrDataGridViewTextBoxColumn.ToolTipText = "Kredīta atlikums perioda sākumā";
            aCrDataGridViewTextBoxColumn.Width = 95;
            // 
            // tDbDataGridViewTextBoxColumn
            // 
            tDbDataGridViewTextBoxColumn.DataPropertyName = "TDb";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            tDbDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            tDbDataGridViewTextBoxColumn.HeaderText = "Debets +";
            tDbDataGridViewTextBoxColumn.Name = "tDbDataGridViewTextBoxColumn";
            tDbDataGridViewTextBoxColumn.ReadOnly = true;
            tDbDataGridViewTextBoxColumn.Width = 95;
            // 
            // tCrDataGridViewTextBoxColumn
            // 
            tCrDataGridViewTextBoxColumn.DataPropertyName = "TCr";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            tCrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            tCrDataGridViewTextBoxColumn.HeaderText = "Kredīts +";
            tCrDataGridViewTextBoxColumn.Name = "tCrDataGridViewTextBoxColumn";
            tCrDataGridViewTextBoxColumn.ReadOnly = true;
            tCrDataGridViewTextBoxColumn.Width = 95;
            // 
            // bDbDataGridViewTextBoxColumn
            // 
            bDbDataGridViewTextBoxColumn.DataPropertyName = "BDb";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            bDbDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            bDbDataGridViewTextBoxColumn.HeaderText = "Debets beigās";
            bDbDataGridViewTextBoxColumn.Name = "bDbDataGridViewTextBoxColumn";
            bDbDataGridViewTextBoxColumn.ReadOnly = true;
            bDbDataGridViewTextBoxColumn.ToolTipText = "Debeta atlikums perioda beigās";
            bDbDataGridViewTextBoxColumn.Width = 95;
            // 
            // bCrDataGridViewTextBoxColumn
            // 
            bCrDataGridViewTextBoxColumn.DataPropertyName = "BCr";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            bCrDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            bCrDataGridViewTextBoxColumn.HeaderText = "Kredīts beigās";
            bCrDataGridViewTextBoxColumn.Name = "bCrDataGridViewTextBoxColumn";
            bCrDataGridViewTextBoxColumn.ReadOnly = true;
            bCrDataGridViewTextBoxColumn.ToolTipText = "Kredīta atlikums perioda beigās";
            bCrDataGridViewTextBoxColumn.Width = 95;
            // 
            // Form_Apgr1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(939, 394);
            CloseOnEscape = true;
            Controls.Add(dgvRows);
            Controls.Add(toolStrip1);
            Name = "Form_Apgr1";
            Text = "Apgrozijuma pārskats";
            Load += Form_Apgr1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslParams;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn acDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCrDataGridViewTextBoxColumn;
    }
}