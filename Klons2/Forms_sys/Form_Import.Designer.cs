namespace KlonsF.Forms
{
    partial class Form_Import
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
            bsCount = new System.Windows.Forms.BindingSource(components);
            dgvCount = new KlonsLIB.Components.MyDataGridView();
            dgcCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCountNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCountExisting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCountChanging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCountBad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTask = new System.Windows.Forms.DataGridViewComboBoxColumn();
            cmImport = new System.Windows.Forms.Button();
            chSkipDocs = new System.Windows.Forms.CheckBox();
            tbFileName = new KlonsLIB.Components.MyTextBox();
            btGetFile = new System.Windows.Forms.Button();
            cmShowErrors = new System.Windows.Forms.Button();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // dgvCount
            // 
            dgvCount.AllowUserToAddRows = false;
            dgvCount.AllowUserToDeleteRows = false;
            dgvCount.AllowUserToResizeRows = false;
            dgvCount.AutoGenerateColumns = false;
            dgvCount.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCaption, dgcCount, dgcCountNew, dgcCountExisting, dgcCountChanging, dgcCountBad, dgcTask });
            dgvCount.DataSource = bsCount;
            dgvCount.Location = new System.Drawing.Point(1, 31);
            dgvCount.Name = "dgvCount";
            dgvCount.RowHeadersVisible = false;
            dgvCount.Size = new System.Drawing.Size(620, 251);
            dgvCount.TabIndex = 0;
            dgvCount.CellBeginEdit += dgvCount_CellBeginEdit;
            // 
            // dgcCaption
            // 
            dgcCaption.DataPropertyName = "SheetName";
            dgcCaption.HeaderText = "Ieraksta veids";
            dgcCaption.Name = "dgcCaption";
            dgcCaption.ReadOnly = true;
            dgcCaption.Width = 200;
            // 
            // dgcCount
            // 
            dgcCount.DataPropertyName = "RowCount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCount.DefaultCellStyle = dataGridViewCellStyle1;
            dgcCount.HeaderText = "Skaits";
            dgcCount.Name = "dgcCount";
            dgcCount.ReadOnly = true;
            dgcCount.Width = 50;
            // 
            // dgcCountNew
            // 
            dgcCountNew.DataPropertyName = "RowCountNew";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCountNew.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCountNew.HeaderText = "Jauni";
            dgcCountNew.Name = "dgcCountNew";
            dgcCountNew.ReadOnly = true;
            dgcCountNew.Width = 50;
            // 
            // dgcCountExisting
            // 
            dgcCountExisting.DataPropertyName = "RowCountExisting";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCountExisting.DefaultCellStyle = dataGridViewCellStyle3;
            dgcCountExisting.HeaderText = "Esoši";
            dgcCountExisting.Name = "dgcCountExisting";
            dgcCountExisting.ReadOnly = true;
            dgcCountExisting.Width = 50;
            // 
            // dgcCountChanging
            // 
            dgcCountChanging.DataPropertyName = "RowCountChanging";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCountChanging.DefaultCellStyle = dataGridViewCellStyle4;
            dgcCountChanging.HeaderText = "Maināmi";
            dgcCountChanging.Name = "dgcCountChanging";
            dgcCountChanging.ReadOnly = true;
            dgcCountChanging.Width = 70;
            // 
            // dgcCountBad
            // 
            dgcCountBad.DataPropertyName = "RowCountBad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCountBad.DefaultCellStyle = dataGridViewCellStyle5;
            dgcCountBad.HeaderText = "Kļūdaini";
            dgcCountBad.Name = "dgcCountBad";
            dgcCountBad.ReadOnly = true;
            dgcCountBad.Width = 70;
            // 
            // dgcTask
            // 
            dgcTask.DataPropertyName = "Task";
            dgcTask.DisplayStyleForCurrentCellOnly = true;
            dgcTask.HeaderText = "Importēt";
            dgcTask.Name = "dgcTask";
            dgcTask.Width = 80;
            // 
            // cmImport
            // 
            cmImport.Location = new System.Drawing.Point(505, 288);
            cmImport.Name = "cmImport";
            cmImport.Size = new System.Drawing.Size(116, 35);
            cmImport.TabIndex = 1;
            cmImport.Text = "Importēt";
            cmImport.UseVisualStyleBackColor = true;
            cmImport.Click += cmImport_Click;
            // 
            // chSkipDocs
            // 
            chSkipDocs.AutoSize = true;
            chSkipDocs.Location = new System.Drawing.Point(5, 296);
            chSkipDocs.Name = "chSkipDocs";
            chSkipDocs.Size = new System.Drawing.Size(177, 21);
            chSkipDocs.TabIndex = 3;
            chSkipDocs.Text = "Neimportēt dokumentus";
            chSkipDocs.UseVisualStyleBackColor = true;
            chSkipDocs.CheckedChanged += chSkipDocs_CheckedChanged;
            // 
            // tbFileName
            // 
            tbFileName.BackColor = System.Drawing.SystemColors.Control;
            tbFileName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbFileName.Location = new System.Drawing.Point(1, 3);
            tbFileName.Name = "tbFileName";
            tbFileName.ReadOnly = true;
            tbFileName.Size = new System.Drawing.Size(518, 23);
            tbFileName.TabIndex = 4;
            // 
            // btGetFile
            // 
            btGetFile.Location = new System.Drawing.Point(525, 0);
            btGetFile.Name = "btGetFile";
            btGetFile.Size = new System.Drawing.Size(96, 27);
            btGetFile.TabIndex = 5;
            btGetFile.Text = "Norādīt failu";
            btGetFile.UseVisualStyleBackColor = true;
            btGetFile.Click += btGetFile_Click;
            // 
            // cmShowErrors
            // 
            cmShowErrors.Location = new System.Drawing.Point(366, 288);
            cmShowErrors.Name = "cmShowErrors";
            cmShowErrors.Size = new System.Drawing.Size(116, 35);
            cmShowErrors.TabIndex = 1;
            cmShowErrors.Text = "Rādīt kļūdas";
            cmShowErrors.UseVisualStyleBackColor = true;
            cmShowErrors.Click += cmShowErrors_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsData";
            myAdapterManager1.TableNames = new string[]
    {
    "AcP21",
    "Acp23",
    "AcP24",
    "Acp25",
    "Currency",
    "DocTyp",
    "OPS",
    "OPSd",
    "Persons",
    null
    };
            // 
            // Form_Import
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 327);
            Controls.Add(btGetFile);
            Controls.Add(tbFileName);
            Controls.Add(chSkipDocs);
            Controls.Add(cmShowErrors);
            Controls.Add(cmImport);
            Controls.Add(dgvCount);
            Name = "Form_Import";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Datu imports";
            FormClosed += Form_Import_FormClosed;
            Load += Form_Import_Load;
            ((System.ComponentModel.ISupportInitialize)bsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCount;
        private KlonsLIB.Components.MyDataGridView dgvCount;
        private System.Windows.Forms.Button cmImport;
        private System.Windows.Forms.CheckBox chSkipDocs;
        private KlonsLIB.Components.MyTextBox tbFileName;
        private System.Windows.Forms.Button btGetFile;
        private System.Windows.Forms.Button cmShowErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCountNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCountExisting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCountChanging;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCountBad;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcTask;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
    }
}