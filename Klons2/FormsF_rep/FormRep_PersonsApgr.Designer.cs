
namespace KlonsF.FormsReportParams
{
    partial class FormRep_PersonsApgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeb0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCred0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDebChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCredChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDeb1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCred1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcName, dgcDeb0, dgcCred0, dgcDebChange, dgcCredChange, dgcDeb1, dgcCred1 });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.DefaultCellStyle = dataGridViewCellStyle7;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(5, 39);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 30;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(985, 406);
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
            dgcCode.Width = 110;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 240;
            // 
            // dgcDeb0
            // 
            dgcDeb0.DataPropertyName = "Deb0";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dgcDeb0.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDeb0.HeaderText = "debets sākumā";
            dgcDeb0.MinimumWidth = 8;
            dgcDeb0.Name = "dgcDeb0";
            dgcDeb0.ReadOnly = true;
            dgcDeb0.Width = 95;
            // 
            // dgcCred0
            // 
            dgcCred0.DataPropertyName = "Cred0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcCred0.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCred0.HeaderText = "kredīts sākumā";
            dgcCred0.MinimumWidth = 8;
            dgcCred0.Name = "dgcCred0";
            dgcCred0.ReadOnly = true;
            dgcCred0.Width = 95;
            // 
            // dgcDebChange
            // 
            dgcDebChange.DataPropertyName = "DebCh";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcDebChange.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDebChange.HeaderText = "debets +/-";
            dgcDebChange.MinimumWidth = 8;
            dgcDebChange.Name = "dgcDebChange";
            dgcDebChange.ReadOnly = true;
            dgcDebChange.Width = 95;
            // 
            // dgcCredChange
            // 
            dgcCredChange.DataPropertyName = "CredCh";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcCredChange.DefaultCellStyle = dataGridViewCellStyle4;
            dgcCredChange.HeaderText = "kredīts +/-";
            dgcCredChange.MinimumWidth = 8;
            dgcCredChange.Name = "dgcCredChange";
            dgcCredChange.ReadOnly = true;
            dgcCredChange.Width = 95;
            // 
            // dgcDeb1
            // 
            dgcDeb1.DataPropertyName = "Deb1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcDeb1.DefaultCellStyle = dataGridViewCellStyle5;
            dgcDeb1.HeaderText = "debets beigās";
            dgcDeb1.MinimumWidth = 8;
            dgcDeb1.Name = "dgcDeb1";
            dgcDeb1.ReadOnly = true;
            dgcDeb1.Width = 95;
            // 
            // dgcCred1
            // 
            dgcCred1.DataPropertyName = "Cred1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcCred1.DefaultCellStyle = dataGridViewCellStyle6;
            dgcCred1.HeaderText = "kredīts beigās";
            dgcCred1.MinimumWidth = 8;
            dgcCred1.Name = "dgcCred1";
            dgcCred1.ReadOnly = true;
            dgcCred1.Width = 95;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lbTitle.Location = new System.Drawing.Point(5, 5);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(39, 34);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "hgfd\r\nfdsaf";
            // 
            // FormRep_PersonsApgr
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(995, 450);
            Controls.Add(dgvRows);
            Controls.Add(lbTitle);
            Name = "FormRep_PersonsApgr";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Personu apgrozijuma pārskatys";
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDebChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCredChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDeb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCred1;
    }
}