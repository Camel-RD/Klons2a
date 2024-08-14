
namespace KlonsM.FormsM
{
    partial class FormM_DocPricesAndDiscounts
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
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            DgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIsUsed = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            btApply = new System.Windows.Forms.Button();
            btCheck = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DgcName, dgcIsUsed });
            dgvRows.Location = new System.Drawing.Point(1, 2);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersVisible = false;
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(417, 346);
            dgvRows.TabIndex = 0;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // DgcName
            // 
            DgcName.DataPropertyName = "Name";
            DgcName.HeaderText = "nosaukums";
            DgcName.MinimumWidth = 8;
            DgcName.Name = "DgcName";
            DgcName.ReadOnly = true;
            DgcName.Width = 300;
            // 
            // dgcIsUsed
            // 
            dgcIsUsed.DataPropertyName = "IsUsed";
            dgcIsUsed.FalseValue = "true";
            dgcIsUsed.HeaderText = "piemērot";
            dgcIsUsed.MinimumWidth = 8;
            dgcIsUsed.Name = "dgcIsUsed";
            dgcIsUsed.TrueValue = "false";
            dgcIsUsed.Width = 80;
            // 
            // btApply
            // 
            btApply.Location = new System.Drawing.Point(1, 354);
            btApply.Name = "btApply";
            btApply.Size = new System.Drawing.Size(201, 49);
            btApply.TabIndex = 1;
            btApply.Text = "Piemērot atzīmētās cenu un atlaižu lapas";
            btApply.UseVisualStyleBackColor = true;
            btApply.Click += btApply_Click;
            // 
            // btCheck
            // 
            btCheck.Location = new System.Drawing.Point(208, 354);
            btCheck.Name = "btCheck";
            btCheck.Size = new System.Drawing.Size(93, 49);
            btCheck.TabIndex = 1;
            btCheck.Text = "Pārbaudīt";
            btCheck.UseVisualStyleBackColor = true;
            btCheck.Click += btCheck_Click;
            // 
            // btCancel
            // 
            btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btCancel.Location = new System.Drawing.Point(307, 354);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(93, 49);
            btCancel.TabIndex = 1;
            btCancel.Text = "Atcelt";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // FormM_DocPricesAndDiscounts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 407);
            Controls.Add(btCancel);
            Controls.Add(btCheck);
            Controls.Add(btApply);
            Controls.Add(dgvRows);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormM_DocPricesAndDiscounts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Piemērot cenu un atlaižu lapas";
            Load += FormM_DocPricesAndDiscounts_Load;
            Shown += FormM_DocPricesAndDiscounts_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgcName;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsUsed;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btCancel;
    }
}