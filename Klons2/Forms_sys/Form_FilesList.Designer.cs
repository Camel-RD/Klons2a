using KlonsLIB.Components;

namespace KlonsF.Forms
{
    partial class Form_FilesList
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
            dgvFiles = new MyDataGridView();
            bsFiles = new System.Windows.Forms.BindingSource(components);
            dgcFilesDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilesConnStr = new MyDgvMcCBColumn();
            dgcFilesFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFiles).BeginInit();
            SuspendLayout();
            // 
            // dgvFiles
            // 
            dgvFiles.AutoGenerateColumns = false;
            dgvFiles.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFilesDescr, dgcFilesName, dgcFilesConnStr, dgcFilesFileName, dgcFilePath });
            dgvFiles.DataSource = bsFiles;
            dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFiles.Location = new System.Drawing.Point(0, 0);
            dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            dgvFiles.Name = "dgvFiles";
            dgvFiles.RowHeadersWidth = 30;
            dgvFiles.ShowCellToolTips = false;
            dgvFiles.Size = new System.Drawing.Size(854, 276);
            dgvFiles.TabIndex = 0;
            dgvFiles.MyCheckForChanges += dgvFiles_MyCheckForChanges;
            dgvFiles.RowValidating += dgvFiles_RowValidating;
            // 
            // bsFiles
            // 
            bsFiles.Sort = "name";
            // 
            // dgcFilesDescr
            // 
            dgcFilesDescr.DataPropertyName = "name";
            dgcFilesDescr.HeaderText = "kods";
            dgcFilesDescr.MinimumWidth = 9;
            dgcFilesDescr.Name = "dgcFilesDescr";
            dgcFilesDescr.ToolTipText = "datubāzes  kods";
            dgcFilesDescr.Width = 120;
            // 
            // dgcFilesName
            // 
            dgcFilesName.DataPropertyName = "descr";
            dgcFilesName.HeaderText = "apraksts";
            dgcFilesName.MinimumWidth = 9;
            dgcFilesName.Name = "dgcFilesName";
            dgcFilesName.ToolTipText = "datubāzes apraksts";
            dgcFilesName.Width = 220;
            // 
            // dgcFilesConnStr
            // 
            dgcFilesConnStr.ColumnNames = new string[]
    {
    "col1"
    };
            dgcFilesConnStr.ColumnWidths = "140";
            dgcFilesConnStr.DataPropertyName = "ConnStr";
            dgcFilesConnStr.DisplayMember = "col1";
            dgcFilesConnStr.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            dgcFilesConnStr.HeaderText = "pieslēgums";
            dgcFilesConnStr.ItemStrings = new string[]
    {
    "FBEmbeded",
    "FBServer"
    };
            dgcFilesConnStr.MaxDropDownItems = 15;
            dgcFilesConnStr.MinimumWidth = 9;
            dgcFilesConnStr.Name = "dgcFilesConnStr";
            dgcFilesConnStr.ValueMember = "col1";
            dgcFilesConnStr.Width = 140;
            // 
            // dgcFilesFileName
            // 
            dgcFilesFileName.DataPropertyName = "FileName";
            dgcFilesFileName.HeaderText = "fails";
            dgcFilesFileName.MinimumWidth = 9;
            dgcFilesFileName.Name = "dgcFilesFileName";
            dgcFilesFileName.Width = 135;
            // 
            // dgcFilePath
            // 
            dgcFilePath.DataPropertyName = "Path";
            dgcFilePath.HeaderText = "mape";
            dgcFilePath.MinimumWidth = 9;
            dgcFilePath.Name = "dgcFilePath";
            dgcFilePath.Width = 180;
            // 
            // Form_FilesList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(854, 276);
            Controls.Add(dgvFiles);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_FilesList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Saraksts ar datu bāzēm";
            FormClosed += FormFiles2_FormClosed;
            Load += FormFiles2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MyDataGridView dgvFiles;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilesDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilesName;
        private MyDgvMcCBColumn dgcFilesConnStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilesFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilePath;
    }
}