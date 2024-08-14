
namespace KlonsF.FormsReportParams
{
    partial class FormRep_PersonsDocs
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
            lbTitle = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lbTitle.Location = new System.Drawing.Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(20, 17);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "...";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcName, dgcDate, dgcDocSr, dgcDocNr, dgcDeb, dgcCred, dgcDiff });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 17);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 20;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1049, 387);
            dgvRows.TabIndex = 1;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "Code";
            dgcCode.HeaderText = "kods";
            dgcCode.MinimumWidth = 8;
            dgcCode.Name = "dgcCode";
            dgcCode.ReadOnly = true;
            dgcCode.Width = 120;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukume";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 300;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Dt";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDate.HeaderText = "datums";
            dgcDate.MinimumWidth = 8;
            dgcDate.Name = "dgcDate";
            dgcDate.ReadOnly = true;
            dgcDate.Width = 85;
            // 
            // dgcDocSr
            // 
            dgcDocSr.DataPropertyName = "DocSr";
            dgcDocSr.HeaderText = "sērija";
            dgcDocSr.MinimumWidth = 8;
            dgcDocSr.Name = "dgcDocSr";
            dgcDocSr.ReadOnly = true;
            dgcDocSr.Width = 60;
            // 
            // dgcDocNr
            // 
            dgcDocNr.DataPropertyName = "DocNr";
            dgcDocNr.HeaderText = "numurs";
            dgcDocNr.MinimumWidth = 8;
            dgcDocNr.Name = "dgcDocNr";
            dgcDocNr.ReadOnly = true;
            dgcDocNr.Width = 120;
            // 
            // dgcDeb
            // 
            dgcDeb.DataPropertyName = "Deb";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcDeb.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDeb.HeaderText = "debetā";
            dgcDeb.MinimumWidth = 8;
            dgcDeb.Name = "dgcDeb";
            dgcDeb.ReadOnly = true;
            dgcDeb.Width = 95;
            // 
            // dgcCred
            // 
            dgcCred.DataPropertyName = "Cred";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcCred.DefaultCellStyle = dataGridViewCellStyle3;
            dgcCred.HeaderText = "kredītā";
            dgcCred.MinimumWidth = 8;
            dgcCred.Name = "dgcCred";
            dgcCred.ReadOnly = true;
            dgcCred.Width = 95;
            // 
            // dgcDiff
            // 
            dgcDiff.DataPropertyName = "Diff";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcDiff.DefaultCellStyle = dataGridViewCellStyle4;
            dgcDiff.HeaderText = "atlikums";
            dgcDiff.MinimumWidth = 8;
            dgcDiff.Name = "dgcDiff";
            dgcDiff.ReadOnly = true;
            dgcDiff.Width = 95;
            // 
            // FormRep_PersonsDocs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1049, 404);
            Controls.Add(dgvRows);
            Controls.Add(lbTitle);
            Name = "FormRep_PersonsDocs";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Rēķinu pārskats";
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDiff;
    }
}