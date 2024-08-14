
namespace KlonsM.FormsM
{
    partial class FormM_RepAccCostsPerDoc
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
            panel1 = new System.Windows.Forms.Panel();
            cmGetData = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbDT2 = new KlonsLIB.Components.MyTextBox();
            tbDT1 = new KlonsLIB.Components.MyTextBox();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIdStoreOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIdStoreIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAcc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAcc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmGetData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbDT2);
            panel1.Controls.Add(tbDT1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1047, 35);
            panel1.TabIndex = 3;
            // 
            // cmGetData
            // 
            cmGetData.Location = new System.Drawing.Point(351, 2);
            cmGetData.Name = "cmGetData";
            cmGetData.Size = new System.Drawing.Size(104, 29);
            cmGetData.TabIndex = 3;
            cmGetData.Text = "Atlasīt";
            cmGetData.UseVisualStyleBackColor = true;
            cmGetData.Click += cmGetData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 17);
            label1.TabIndex = 4;
            label1.Text = "Datums no - līdz:";
            // 
            // tbDT2
            // 
            tbDT2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT2.IsDate = true;
            tbDT2.Location = new System.Drawing.Point(236, 6);
            tbDT2.Name = "tbDT2";
            tbDT2.Size = new System.Drawing.Size(90, 23);
            tbDT2.TabIndex = 1;
            // 
            // tbDT1
            // 
            tbDT1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT1.IsDate = true;
            tbDT1.Location = new System.Drawing.Point(136, 6);
            tbDT1.Name = "tbDT1";
            tbDT1.Size = new System.Drawing.Size(90, 23);
            tbDT1.TabIndex = 0;
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDt, dgcSr, dgcNr, dgcTP, dgcIdStoreOut, dgcIdStoreIn, dgcAcc1, dgcAcc2, dgcCost });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 35);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 30;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1047, 415);
            dgvRows.TabIndex = 4;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcDt
            // 
            dgcDt.DataPropertyName = "DT";
            dgcDt.HeaderText = "datums";
            dgcDt.MinimumWidth = 8;
            dgcDt.Name = "dgcDt";
            dgcDt.ReadOnly = true;
            dgcDt.Width = 95;
            // 
            // dgcSr
            // 
            dgcSr.DataPropertyName = "SR";
            dgcSr.HeaderText = "sr.";
            dgcSr.MinimumWidth = 8;
            dgcSr.Name = "dgcSr";
            dgcSr.ReadOnly = true;
            dgcSr.Width = 55;
            // 
            // dgcNr
            // 
            dgcNr.DataPropertyName = "NR";
            dgcNr.HeaderText = "numurs";
            dgcNr.MinimumWidth = 8;
            dgcNr.Name = "dgcNr";
            dgcNr.ReadOnly = true;
            dgcNr.Width = 90;
            // 
            // dgcTP
            // 
            dgcTP.DataPropertyName = "TP";
            dgcTP.HeaderText = "veids";
            dgcTP.MinimumWidth = 8;
            dgcTP.Name = "dgcTP";
            dgcTP.ReadOnly = true;
            dgcTP.Width = 200;
            // 
            // dgcIdStoreOut
            // 
            dgcIdStoreOut.DataPropertyName = "IDSTOREOUT";
            dgcIdStoreOut.HeaderText = "izsniedzējs";
            dgcIdStoreOut.MinimumWidth = 8;
            dgcIdStoreOut.Name = "dgcIdStoreOut";
            dgcIdStoreOut.ReadOnly = true;
            dgcIdStoreOut.Width = 160;
            // 
            // dgcIdStoreIn
            // 
            dgcIdStoreIn.DataPropertyName = "IDSTOREIN";
            dgcIdStoreIn.HeaderText = "saņēmējs";
            dgcIdStoreIn.MinimumWidth = 8;
            dgcIdStoreIn.Name = "dgcIdStoreIn";
            dgcIdStoreIn.ReadOnly = true;
            dgcIdStoreIn.Width = 160;
            // 
            // dgcAcc1
            // 
            dgcAcc1.DataPropertyName = "ACC1";
            dgcAcc1.HeaderText = "debets";
            dgcAcc1.MinimumWidth = 8;
            dgcAcc1.Name = "dgcAcc1";
            dgcAcc1.ReadOnly = true;
            dgcAcc1.Width = 90;
            // 
            // dgcAcc2
            // 
            dgcAcc2.DataPropertyName = "ACC2";
            dgcAcc2.HeaderText = "kredīts";
            dgcAcc2.MinimumWidth = 8;
            dgcAcc2.Name = "dgcAcc2";
            dgcAcc2.ReadOnly = true;
            dgcAcc2.Width = 90;
            // 
            // dgcCost
            // 
            dgcCost.DataPropertyName = "COST";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dgcCost.DefaultCellStyle = dataGridViewCellStyle1;
            dgcCost.HeaderText = "summa";
            dgcCost.MinimumWidth = 8;
            dgcCost.Name = "dgcCost";
            dgcCost.ReadOnly = true;
            dgcCost.Width = 120;
            // 
            // FormM_RepAccCostsPerDoc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1047, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormM_RepAccCostsPerDoc";
            Text = "Realizācijas pašizmaksas kontējumu kopsavilkums pa dokumentiem";
            Load += FormM_RepAccCosts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmGetData;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbDT2;
        private KlonsLIB.Components.MyTextBox tbDT1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdStoreOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAcc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAcc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCost;
    }
}