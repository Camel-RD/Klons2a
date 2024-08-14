namespace KlonsF.Forms
{
    partial class Form_ImportErrors
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
            dgcSheetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcColNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsRows = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            SuspendLayout();
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcSheetName, dgcRowNr, dgcColNr, dgcError });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersVisible = false;
            dgvRows.Size = new System.Drawing.Size(584, 275);
            dgvRows.TabIndex = 0;
            // 
            // dgcSheetName
            // 
            dgcSheetName.DataPropertyName = "SheetName";
            dgcSheetName.HeaderText = "Lapa";
            dgcSheetName.Name = "dgcSheetName";
            dgcSheetName.ReadOnly = true;
            dgcSheetName.Width = 120;
            // 
            // dgcRowNr
            // 
            dgcRowNr.DataPropertyName = "RowNr";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowNr.DefaultCellStyle = dataGridViewCellStyle1;
            dgcRowNr.HeaderText = "Rinda";
            dgcRowNr.Name = "dgcRowNr";
            dgcRowNr.ReadOnly = true;
            dgcRowNr.Width = 60;
            // 
            // dgcColNr
            // 
            dgcColNr.DataPropertyName = "ColNr";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcColNr.DefaultCellStyle = dataGridViewCellStyle2;
            dgcColNr.HeaderText = "Kolonna";
            dgcColNr.Name = "dgcColNr";
            dgcColNr.ReadOnly = true;
            dgcColNr.Width = 60;
            // 
            // dgcError
            // 
            dgcError.DataPropertyName = "Error";
            dgcError.HeaderText = "Kļūda";
            dgcError.Name = "dgcError";
            dgcError.ReadOnly = true;
            dgcError.Width = 300;
            // 
            // Form_ImportErrors
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 275);
            Controls.Add(dgvRows);
            Name = "Form_ImportErrors";
            Text = "Kļūdas";
            Load += Form_ImportErrors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSheetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcColNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcError;
    }
}