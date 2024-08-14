using KlonsLIB.Components;

namespace KlonsF.Forms
{
    partial class Form_Files
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
            cmSelect = new System.Windows.Forms.Button();
            cmEditList = new System.Windows.Forms.Button();
            cmCancel = new System.Windows.Forms.Button();
            dgvFiles = new MyDataGridView();
            bsFiles = new System.Windows.Forms.BindingSource(components);
            cmNew = new System.Windows.Forms.Button();
            cmDelete = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            dgcFilesDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFiles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmSelect
            // 
            cmSelect.Location = new System.Drawing.Point(11, 12);
            cmSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmSelect.Name = "cmSelect";
            cmSelect.Size = new System.Drawing.Size(93, 37);
            cmSelect.TabIndex = 1;
            cmSelect.Text = "Pieslēgties";
            cmSelect.UseVisualStyleBackColor = true;
            cmSelect.Click += cmSelect_Click;
            // 
            // cmEditList
            // 
            cmEditList.Location = new System.Drawing.Point(11, 156);
            cmEditList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmEditList.Name = "cmEditList";
            cmEditList.Size = new System.Drawing.Size(93, 55);
            cmEditList.TabIndex = 4;
            cmEditList.Text = "Rediģēt sarakstu";
            cmEditList.UseVisualStyleBackColor = true;
            cmEditList.Click += cmEditList_Click;
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(11, 231);
            cmCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(93, 37);
            cmCancel.TabIndex = 5;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            // 
            // dgvFiles
            // 
            dgvFiles.AllowUserToAddRows = false;
            dgvFiles.AllowUserToDeleteRows = false;
            dgvFiles.AllowUserToResizeRows = false;
            dgvFiles.AutoGenerateColumns = false;
            dgvFiles.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFilesDescr, dgcFilesName });
            dgvFiles.DataSource = bsFiles;
            dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFiles.Location = new System.Drawing.Point(0, 0);
            dgvFiles.Margin = new System.Windows.Forms.Padding(2);
            dgvFiles.MultiSelect = false;
            dgvFiles.Name = "dgvFiles";
            dgvFiles.ReadOnly = true;
            dgvFiles.RowHeadersVisible = false;
            dgvFiles.RowHeadersWidth = 62;
            dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFiles.ShowCellToolTips = false;
            dgvFiles.Size = new System.Drawing.Size(582, 279);
            dgvFiles.TabIndex = 0;
            dgvFiles.CellDoubleClick += dgvFiles_CellDoubleClick;
            // 
            // bsFiles
            // 
            bsFiles.AllowNew = false;
            bsFiles.Sort = "Name";
            // 
            // cmNew
            // 
            cmNew.Location = new System.Drawing.Point(11, 55);
            cmNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmNew.Name = "cmNew";
            cmNew.Size = new System.Drawing.Size(93, 55);
            cmNew.TabIndex = 2;
            cmNew.Text = "Izveidot jaunu";
            cmNew.UseVisualStyleBackColor = true;
            cmNew.Click += cmNew_Click;
            // 
            // cmDelete
            // 
            cmDelete.Location = new System.Drawing.Point(11, 117);
            cmDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmDelete.Name = "cmDelete";
            cmDelete.Size = new System.Drawing.Size(93, 32);
            cmDelete.TabIndex = 3;
            cmDelete.Text = "Dzēst";
            cmDelete.UseVisualStyleBackColor = true;
            cmDelete.Click += cmDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmSelect);
            panel1.Controls.Add(cmCancel);
            panel1.Controls.Add(cmDelete);
            panel1.Controls.Add(cmEditList);
            panel1.Controls.Add(cmNew);
            panel1.Dock = System.Windows.Forms.DockStyle.Right;
            panel1.Location = new System.Drawing.Point(582, 0);
            panel1.MinimumSize = new System.Drawing.Size(114, 281);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(114, 281);
            panel1.TabIndex = 6;
            // 
            // dgcFilesDescr
            // 
            dgcFilesDescr.DataPropertyName = "name";
            dgcFilesDescr.HeaderText = "kods";
            dgcFilesDescr.MinimumWidth = 9;
            dgcFilesDescr.Name = "dgcFilesDescr";
            dgcFilesDescr.ReadOnly = true;
            dgcFilesDescr.ToolTipText = "datubāzes  kods";
            dgcFilesDescr.Width = 200;
            // 
            // dgcFilesName
            // 
            dgcFilesName.DataPropertyName = "descr";
            dgcFilesName.HeaderText = "apraksts";
            dgcFilesName.MinimumWidth = 9;
            dgcFilesName.Name = "dgcFilesName";
            dgcFilesName.ReadOnly = true;
            dgcFilesName.ToolTipText = "datubāzes apraksts";
            dgcFilesName.Width = 340;
            // 
            // Form_Files
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(696, 279);
            CloseOnEscape = true;
            Controls.Add(dgvFiles);
            Controls.Add(panel1);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Files";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Nomainīt datubāzi";
            Load += FormFiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFiles).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button cmSelect;
        private System.Windows.Forms.Button cmEditList;
        private System.Windows.Forms.Button cmCancel;
        private MyDataGridView dgvFiles;
        private System.Windows.Forms.BindingSource bsFiles;
        private System.Windows.Forms.Button cmNew;
        private System.Windows.Forms.Button cmDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilesDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilesName;
    }
}