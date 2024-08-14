
namespace KlonsF.Forms
{
    partial class FormRep_Bilance1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRows
            // 
            this.dgvRows.AllowUserToAddRows = false;
            this.dgvRows.AllowUserToDeleteRows = false;
            this.dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcDescr,
            this.dgcNr,
            this.dgcS1,
            this.dgcS2,
            this.dgcS3});
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(0, 0);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 25;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(949, 450);
            this.dgvRows.TabIndex = 0;
            this.dgvRows.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRows_CellFormatting);
            // 
            // dgcDescr
            // 
            this.dgcDescr.DataPropertyName = "Descr";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcDescr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcDescr.HeaderText = "";
            this.dgcDescr.MinimumWidth = 8;
            this.dgcDescr.Name = "dgcDescr";
            this.dgcDescr.ReadOnly = true;
            this.dgcDescr.Width = 500;
            // 
            // dgcNr
            // 
            this.dgcNr.DataPropertyName = "Nr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgcNr.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcNr.HeaderText = "nr.";
            this.dgcNr.MinimumWidth = 8;
            this.dgcNr.Name = "dgcNr";
            this.dgcNr.ReadOnly = true;
            this.dgcNr.Width = 60;
            // 
            // dgcS1
            // 
            this.dgcS1.DataPropertyName = "S1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgcS1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcS1.HeaderText = "sākumā";
            this.dgcS1.MinimumWidth = 8;
            this.dgcS1.Name = "dgcS1";
            this.dgcS1.ReadOnly = true;
            this.dgcS1.Width = 110;
            // 
            // dgcS2
            // 
            this.dgcS2.DataPropertyName = "S2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgcS2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcS2.HeaderText = "+/-";
            this.dgcS2.MinimumWidth = 8;
            this.dgcS2.Name = "dgcS2";
            this.dgcS2.ReadOnly = true;
            this.dgcS2.Width = 110;
            // 
            // dgcS3
            // 
            this.dgcS3.DataPropertyName = "S3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dgcS3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcS3.HeaderText = "beigās";
            this.dgcS3.MinimumWidth = 8;
            this.dgcS3.Name = "dgcS3";
            this.dgcS3.ReadOnly = true;
            this.dgcS3.Width = 110;
            // 
            // FormRep_Bilance1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.dgvRows);
            this.Name = "FormRep_Bilance1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilance / PZA";
            this.Load += new System.EventHandler(this.FormRep_Bilance1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS3;
    }
}