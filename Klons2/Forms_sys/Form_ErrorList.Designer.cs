namespace KlonsA.Forms
{
    partial class Form_ErrorList
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
            bsErr = new System.Windows.Forms.BindingSource(components);
            dgvErrorList = new KlonsLIB.Components.MyDataGridView();
            dgcSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsErr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvErrorList).BeginInit();
            SuspendLayout();
            // 
            // dgvErrorList
            // 
            dgvErrorList.AllowUserToAddRows = false;
            dgvErrorList.AllowUserToDeleteRows = false;
            dgvErrorList.AllowUserToOrderColumns = true;
            dgvErrorList.AutoGenerateColumns = false;
            dgvErrorList.AutoSave = false;
            dgvErrorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvErrorList.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcSource, dgcMessage });
            dgvErrorList.DataSource = bsErr;
            dgvErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvErrorList.Location = new System.Drawing.Point(0, 0);
            dgvErrorList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvErrorList.Name = "dgvErrorList";
            dgvErrorList.ReadOnly = true;
            dgvErrorList.RowHeadersVisible = false;
            dgvErrorList.RowHeadersWidth = 62;
            dgvErrorList.ShowCellToolTips = false;
            dgvErrorList.Size = new System.Drawing.Size(626, 281);
            dgvErrorList.TabIndex = 0;
            // 
            // dgcSource
            // 
            dgcSource.DataPropertyName = "Source";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgcSource.DefaultCellStyle = dataGridViewCellStyle1;
            dgcSource.HeaderText = "kļūdas avots";
            dgcSource.MinimumWidth = 112;
            dgcSource.Name = "dgcSource";
            dgcSource.ReadOnly = true;
            dgcSource.Width = 168;
            // 
            // dgcMessage
            // 
            dgcMessage.DataPropertyName = "Message";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgcMessage.DefaultCellStyle = dataGridViewCellStyle2;
            dgcMessage.HeaderText = "kļūdas paziņojums";
            dgcMessage.MinimumWidth = 225;
            dgcMessage.Name = "dgcMessage";
            dgcMessage.ReadOnly = true;
            dgcMessage.Width = 420;
            // 
            // Form_ErrorList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(626, 281);
            Controls.Add(dgvErrorList);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_ErrorList";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kļūdas paziņojumi";
            ((System.ComponentModel.ISupportInitialize)bsErr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvErrorList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource bsErr;
        private KlonsLIB.Components.MyDataGridView dgvErrorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMessage;
    }
}