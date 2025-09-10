
namespace KlonsF.Forms
{
    partial class FormRep_Bilance2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRows = new KlonsLIB.Components.MyDataGridView();
            this.dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcS12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcST = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgcS1,
            this.dgcS2,
            this.dgcS3,
            this.dgcS4,
            this.dgcS5,
            this.dgcS6,
            this.dgcS7,
            this.dgcS8,
            this.dgcS9,
            this.dgcS10,
            this.dgcS11,
            this.dgcS12,
            this.dgcST});
            this.dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRows.Location = new System.Drawing.Point(0, 0);
            this.dgvRows.Name = "dgvRows";
            this.dgvRows.ReadOnly = true;
            this.dgvRows.RowHeadersWidth = 30;
            this.dgvRows.ShowCellToolTips = false;
            this.dgvRows.Size = new System.Drawing.Size(1100, 450);
            this.dgvRows.TabIndex = 0;
            this.dgvRows.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRows_CellFormatting);
            // 
            // dgcDescr
            // 
            this.dgcDescr.DataPropertyName = "Descr";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcDescr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgcDescr.Frozen = true;
            this.dgcDescr.HeaderText = "";
            this.dgcDescr.MinimumWidth = 8;
            this.dgcDescr.Name = "dgcDescr";
            this.dgcDescr.ReadOnly = true;
            this.dgcDescr.Width = 400;
            // 
            // dgcS1
            // 
            this.dgcS1.DataPropertyName = "M1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.dgcS1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgcS1.HeaderText = "jan";
            this.dgcS1.MinimumWidth = 8;
            this.dgcS1.Name = "dgcS1";
            this.dgcS1.ReadOnly = true;
            this.dgcS1.Width = 110;
            // 
            // dgcS2
            // 
            this.dgcS2.DataPropertyName = "M2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dgcS2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgcS2.HeaderText = "feb";
            this.dgcS2.MinimumWidth = 8;
            this.dgcS2.Name = "dgcS2";
            this.dgcS2.ReadOnly = true;
            this.dgcS2.Width = 110;
            // 
            // dgcS3
            // 
            this.dgcS3.DataPropertyName = "M3";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.dgcS3.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgcS3.HeaderText = "mar";
            this.dgcS3.MinimumWidth = 8;
            this.dgcS3.Name = "dgcS3";
            this.dgcS3.ReadOnly = true;
            this.dgcS3.Width = 110;
            // 
            // dgcS4
            // 
            this.dgcS4.DataPropertyName = "M4";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.dgcS4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgcS4.HeaderText = "apr";
            this.dgcS4.MinimumWidth = 8;
            this.dgcS4.Name = "dgcS4";
            this.dgcS4.ReadOnly = true;
            this.dgcS4.Width = 110;
            // 
            // dgcS5
            // 
            this.dgcS5.DataPropertyName = "M5";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dgcS5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgcS5.HeaderText = "mai";
            this.dgcS5.MinimumWidth = 8;
            this.dgcS5.Name = "dgcS5";
            this.dgcS5.ReadOnly = true;
            this.dgcS5.Width = 110;
            // 
            // dgcS6
            // 
            this.dgcS6.DataPropertyName = "M6";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dgcS6.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgcS6.HeaderText = "jūn";
            this.dgcS6.MinimumWidth = 8;
            this.dgcS6.Name = "dgcS6";
            this.dgcS6.ReadOnly = true;
            this.dgcS6.Width = 110;
            // 
            // dgcS7
            // 
            this.dgcS7.DataPropertyName = "M7";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.dgcS7.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgcS7.HeaderText = "jūl";
            this.dgcS7.MinimumWidth = 8;
            this.dgcS7.Name = "dgcS7";
            this.dgcS7.ReadOnly = true;
            this.dgcS7.Width = 110;
            // 
            // dgcS8
            // 
            this.dgcS8.DataPropertyName = "M8";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dgcS8.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgcS8.HeaderText = "aug";
            this.dgcS8.MinimumWidth = 8;
            this.dgcS8.Name = "dgcS8";
            this.dgcS8.ReadOnly = true;
            this.dgcS8.Width = 110;
            // 
            // dgcS9
            // 
            this.dgcS9.DataPropertyName = "M9";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.dgcS9.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgcS9.HeaderText = "sep";
            this.dgcS9.MinimumWidth = 8;
            this.dgcS9.Name = "dgcS9";
            this.dgcS9.ReadOnly = true;
            this.dgcS9.Width = 110;
            // 
            // dgcS10
            // 
            this.dgcS10.DataPropertyName = "M10";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            this.dgcS10.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgcS10.HeaderText = "okt";
            this.dgcS10.MinimumWidth = 8;
            this.dgcS10.Name = "dgcS10";
            this.dgcS10.ReadOnly = true;
            this.dgcS10.Width = 110;
            // 
            // dgcS11
            // 
            this.dgcS11.DataPropertyName = "M11";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            this.dgcS11.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgcS11.HeaderText = "nov";
            this.dgcS11.MinimumWidth = 8;
            this.dgcS11.Name = "dgcS11";
            this.dgcS11.ReadOnly = true;
            this.dgcS11.Width = 110;
            // 
            // dgcS12
            // 
            this.dgcS12.DataPropertyName = "M12";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.dgcS12.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgcS12.HeaderText = "dec";
            this.dgcS12.MinimumWidth = 8;
            this.dgcS12.Name = "dgcS12";
            this.dgcS12.ReadOnly = true;
            this.dgcS12.Width = 110;
            // 
            // dgcST
            // 
            this.dgcST.DataPropertyName = "M13";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            this.dgcST.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgcST.HeaderText = "kopā";
            this.dgcST.MinimumWidth = 8;
            this.dgcST.Name = "dgcST";
            this.dgcST.ReadOnly = true;
            this.dgcST.Width = 110;
            // 
            // FormRep_Bilance2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.dgvRows);
            this.Name = "FormRep_Bilance2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilance / PZA";
            this.Load += new System.EventHandler(this.FormRep_Bilance2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcS12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcST;
    }
}