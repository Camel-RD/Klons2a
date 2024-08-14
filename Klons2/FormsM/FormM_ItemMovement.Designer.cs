
namespace KlonsM.FormsM
{
    partial class FormM_ItemMovement
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
            panel1 = new System.Windows.Forms.Panel();
            cmGetData = new System.Windows.Forms.Button();
            tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbDT2 = new KlonsLIB.Components.MyTextBox();
            tbDT1 = new KlonsLIB.Components.MyTextBox();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcSGtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCodeStoreOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCodeStoreIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSaldo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSaldo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmGetData);
            panel1.Controls.Add(tbCode);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbDT2);
            panel1.Controls.Add(tbDT1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(985, 34);
            panel1.TabIndex = 0;
            // 
            // cmGetData
            // 
            cmGetData.Location = new System.Drawing.Point(589, 2);
            cmGetData.Name = "cmGetData";
            cmGetData.Size = new System.Drawing.Size(108, 30);
            cmGetData.TabIndex = 3;
            cmGetData.Text = "Atlasīt";
            cmGetData.UseVisualStyleBackColor = true;
            cmGetData.Click += cmGetData_Click;
            // 
            // tbCode
            // 
            tbCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbCode.DataMember = null;
            tbCode.DataSource = bsItems;
            tbCode.DisplayMember = "BARCODE";
            tbCode.Location = new System.Drawing.Point(416, 5);
            tbCode.Name = "tbCode";
            tbCode.SelectedIndex = -1;
            tbCode.ShowButton = true;
            tbCode.Size = new System.Drawing.Size(158, 23);
            tbCode.SyncPosition = false;
            tbCode.TabIndex = 2;
            tbCode.ValueMember = "ID";
            tbCode.ButtonClicked += tbCode_ButtonClicked;
            tbCode.KeyDown += tbCode_KeyDown;
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(347, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 17);
            label2.TabIndex = 5;
            label2.Text = "artikuls:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(2, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 17);
            label1.TabIndex = 4;
            label1.Text = "Datums no - līdz:";
            // 
            // tbDT2
            // 
            tbDT2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT2.IsDate = true;
            tbDT2.Location = new System.Drawing.Point(235, 5);
            tbDT2.Name = "tbDT2";
            tbDT2.Size = new System.Drawing.Size(90, 23);
            tbDT2.TabIndex = 1;
            // 
            // tbDT1
            // 
            tbDT1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT1.IsDate = true;
            tbDT1.Location = new System.Drawing.Point(135, 5);
            tbDT1.Name = "tbDT1";
            tbDT1.Size = new System.Drawing.Size(90, 23);
            tbDT1.TabIndex = 0;
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcSGtp, dgcDt, dgcSr, dgcNr, dgcCodeStoreOut, dgcCodeStoreIn, dgcAmount, dgcSaldo1, dgcSaldo2 });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 34);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 30;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(985, 416);
            dgvRows.TabIndex = 1;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcSGtp
            // 
            dgcSGtp.DataPropertyName = "SGtp";
            dgcSGtp.HeaderText = "veids";
            dgcSGtp.MinimumWidth = 8;
            dgcSGtp.Name = "dgcSGtp";
            dgcSGtp.ReadOnly = true;
            dgcSGtp.Width = 140;
            // 
            // dgcDt
            // 
            dgcDt.DataPropertyName = "Dt";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDt.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDt.HeaderText = "datums";
            dgcDt.MinimumWidth = 8;
            dgcDt.Name = "dgcDt";
            dgcDt.ReadOnly = true;
            dgcDt.Width = 85;
            // 
            // dgcSr
            // 
            dgcSr.DataPropertyName = "Sr";
            dgcSr.HeaderText = "sr.";
            dgcSr.MinimumWidth = 8;
            dgcSr.Name = "dgcSr";
            dgcSr.ReadOnly = true;
            dgcSr.Width = 50;
            // 
            // dgcNr
            // 
            dgcNr.DataPropertyName = "Nr";
            dgcNr.HeaderText = "numurs";
            dgcNr.MinimumWidth = 8;
            dgcNr.Name = "dgcNr";
            dgcNr.ReadOnly = true;
            dgcNr.Width = 95;
            // 
            // dgcCodeStoreOut
            // 
            dgcCodeStoreOut.DataPropertyName = "CodeStoreOut";
            dgcCodeStoreOut.HeaderText = "izsniedzējs";
            dgcCodeStoreOut.MinimumWidth = 8;
            dgcCodeStoreOut.Name = "dgcCodeStoreOut";
            dgcCodeStoreOut.ReadOnly = true;
            dgcCodeStoreOut.Width = 160;
            // 
            // dgcCodeStoreIn
            // 
            dgcCodeStoreIn.DataPropertyName = "CodeStoreIn";
            dgcCodeStoreIn.HeaderText = "saņēmējs";
            dgcCodeStoreIn.MinimumWidth = 8;
            dgcCodeStoreIn.Name = "dgcCodeStoreIn";
            dgcCodeStoreIn.ReadOnly = true;
            dgcCodeStoreIn.Width = 160;
            // 
            // dgcAmount
            // 
            dgcAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcAmount.DefaultCellStyle = dataGridViewCellStyle2;
            dgcAmount.HeaderText = "daudzums";
            dgcAmount.MinimumWidth = 8;
            dgcAmount.Name = "dgcAmount";
            dgcAmount.ReadOnly = true;
            dgcAmount.Width = 90;
            // 
            // dgcSaldo1
            // 
            dgcSaldo1.DataPropertyName = "Saldo1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcSaldo1.DefaultCellStyle = dataGridViewCellStyle3;
            dgcSaldo1.HeaderText = "izsniedzēja atlikums";
            dgcSaldo1.MinimumWidth = 8;
            dgcSaldo1.Name = "dgcSaldo1";
            dgcSaldo1.ReadOnly = true;
            dgcSaldo1.Width = 90;
            // 
            // dgcSaldo2
            // 
            dgcSaldo2.DataPropertyName = "Saldo2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcSaldo2.DefaultCellStyle = dataGridViewCellStyle4;
            dgcSaldo2.HeaderText = "saņēmēja atlikums";
            dgcSaldo2.MinimumWidth = 8;
            dgcSaldo2.Name = "dgcSaldo2";
            dgcSaldo2.ReadOnly = true;
            dgcSaldo2.Width = 90;
            // 
            // FormM_ItemMovement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(985, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormM_ItemMovement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Artikula kustības pārskats";
            Load += FormM_ItemMovement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbDT2;
        private KlonsLIB.Components.MyTextBox tbDT1;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private System.Windows.Forms.Button cmGetData;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSGtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCodeStoreOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCodeStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSaldo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSaldo2;
    }
}