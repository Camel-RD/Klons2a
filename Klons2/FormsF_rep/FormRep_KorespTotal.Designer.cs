namespace KlonsF.FormsF_rep
{
    partial class FormRep_KorespTotal
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
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDesct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcAcc, dgcDesct, dgcDebit, dgcCredit });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersVisible = false;
            dgvRows.Size = new System.Drawing.Size(601, 328);
            dgvRows.TabIndex = 0;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcAcc
            // 
            dgcAcc.DataPropertyName = "Acc";
            dgcAcc.HeaderText = "konts";
            dgcAcc.Name = "dgcAcc";
            dgcAcc.Width = 60;
            // 
            // dgcDesct
            // 
            dgcDesct.DataPropertyName = "Descr";
            dgcDesct.HeaderText = "nosaukums";
            dgcDesct.Name = "dgcDesct";
            dgcDesct.Width = 400;
            // 
            // dgcDebit
            // 
            dgcDebit.DataPropertyName = "Debit";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dgcDebit.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDebit.HeaderText = "debetā";
            dgcDebit.Name = "dgcDebit";
            dgcDebit.Width = 110;
            // 
            // dgcCredit
            // 
            dgcCredit.DataPropertyName = "Credit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcCredit.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCredit.HeaderText = "kredītā";
            dgcCredit.Name = "dgcCredit";
            dgcCredit.Width = 110;
            // 
            // FormRep_KorespTotal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(601, 328);
            Controls.Add(dgvRows);
            Name = "FormRep_KorespTotal";
            Text = "Konta korespondences pārskats - kopsummas";
            Load += FormRep_KorespTotal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDesct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCredit;
    }
}