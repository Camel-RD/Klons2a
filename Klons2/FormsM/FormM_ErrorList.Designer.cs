
namespace KlonsM.FormsM
{
    partial class FormM_ErrorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_ErrorList));
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsRows = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            SuspendLayout();
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcSource, dgcMessage });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersVisible = false;
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(837, 255);
            dgvRows.TabIndex = 0;
            // 
            // dgcSource
            // 
            dgcSource.DataPropertyName = "Source";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgcSource.DefaultCellStyle = dataGridViewCellStyle1;
            dgcSource.HeaderText = "kļūdas avots";
            dgcSource.MinimumWidth = 8;
            dgcSource.Name = "dgcSource";
            dgcSource.ReadOnly = true;
            dgcSource.Width = 300;
            // 
            // dgcMessage
            // 
            dgcMessage.DataPropertyName = "Message";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgcMessage.DefaultCellStyle = dataGridViewCellStyle2;
            dgcMessage.HeaderText = "paziņojums";
            dgcMessage.MinimumWidth = 8;
            dgcMessage.Name = "dgcMessage";
            dgcMessage.ReadOnly = true;
            dgcMessage.Width = 500;
            // 
            // FormM_ErrorList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(837, 255);
            Controls.Add(dgvRows);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormM_ErrorList";
            ShowIcon = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kļūdas paziņojumi";
            Load += FormM_ErrorList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMessage;
    }
}