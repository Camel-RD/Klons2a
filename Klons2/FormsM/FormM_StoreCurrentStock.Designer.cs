
namespace KlonsM.FormsM
{
    partial class FormM_StoreCurrentStock
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
            label2 = new System.Windows.Forms.Label();
            tbItemsCatFilter = new KlonsLIB.Components.MyPickRowTextBox2();
            bsItemsCatFilter = new KlonsLIB.Data.MyBindingSource(components);
            tbFilter = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcItemKat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            lbStoreName = new System.Windows.Forms.ToolStripLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCatFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbItemsCatFilter);
            panel1.Controls.Add(tbFilter);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(921, 30);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 17);
            label2.TabIndex = 6;
            label2.Text = "kategorija:";
            // 
            // tbItemsCatFilter
            // 
            tbItemsCatFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbItemsCatFilter.DataMember = null;
            tbItemsCatFilter.DataSource = bsItemsCatFilter;
            tbItemsCatFilter.DisplayMember = "CODE";
            tbItemsCatFilter.Location = new System.Drawing.Point(86, 3);
            tbItemsCatFilter.Name = "tbItemsCatFilter";
            tbItemsCatFilter.SelectedIndex = -1;
            tbItemsCatFilter.ShowButton = true;
            tbItemsCatFilter.Size = new System.Drawing.Size(191, 23);
            tbItemsCatFilter.SyncPosition = false;
            tbItemsCatFilter.TabIndex = 5;
            tbItemsCatFilter.ValueMember = "ID";
            tbItemsCatFilter.SelectedIndexChanged += tbItemsCatFilter_SelectedIndexChanged;
            tbItemsCatFilter.ButtonClicked += tbItemsCatFilter_ButtonClicked;
            tbItemsCatFilter.KeyDown += tbItemsCatFilter_KeyDown;
            // 
            // bsItemsCatFilter
            // 
            bsItemsCatFilter.DataMember = "M_ITEMS_CAT";
            bsItemsCatFilter.MyDataSource = "KlonsMData";
            bsItemsCatFilter.Sort = "CODE";
            // 
            // tbFilter
            // 
            tbFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbFilter.Location = new System.Drawing.Point(366, 3);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new System.Drawing.Size(140, 23);
            tbFilter.TabIndex = 2;
            tbFilter.KeyDown += tbFilter_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(311, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 1;
            label1.Text = "atlasīt:";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcItemCode, dgcItemName, dgcItemKat, dgcAmount });
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 30);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersVisible = false;
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(921, 395);
            dgvRows.TabIndex = 1;
            // 
            // dgcItemCode
            // 
            dgcItemCode.DataPropertyName = "ItemCode";
            dgcItemCode.HeaderText = "kods";
            dgcItemCode.MinimumWidth = 8;
            dgcItemCode.Name = "dgcItemCode";
            dgcItemCode.ReadOnly = true;
            dgcItemCode.Width = 160;
            // 
            // dgcItemName
            // 
            dgcItemName.DataPropertyName = "ItemName";
            dgcItemName.HeaderText = "nosaukums";
            dgcItemName.MinimumWidth = 8;
            dgcItemName.Name = "dgcItemName";
            dgcItemName.ReadOnly = true;
            dgcItemName.Width = 300;
            // 
            // dgcItemKat
            // 
            dgcItemKat.DataPropertyName = "ItemCategory";
            dgcItemKat.HeaderText = "kategorija";
            dgcItemKat.MinimumWidth = 8;
            dgcItemKat.Name = "dgcItemKat";
            dgcItemKat.ReadOnly = true;
            dgcItemKat.Width = 140;
            // 
            // dgcAmount
            // 
            dgcAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcAmount.DefaultCellStyle = dataGridViewCellStyle1;
            dgcAmount.HeaderText = "daudzums";
            dgcAmount.MinimumWidth = 8;
            dgcAmount.Name = "dgcAmount";
            dgcAmount.ReadOnly = true;
            dgcAmount.Width = 90;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbStoreName });
            toolStrip1.Location = new System.Drawing.Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(921, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // lbStoreName
            // 
            lbStoreName.Name = "lbStoreName";
            lbStoreName.Size = new System.Drawing.Size(20, 22);
            lbStoreName.Text = "...";
            // 
            // FormM_StoreCurrentStock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(921, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FormM_StoreCurrentStock";
            Text = "Aktuālais noliktavas atlikums";
            Load += FormM_StoreCurrentStock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCatFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Components.MyTextBox tbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcItemKat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAmount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbStoreName;
        private KlonsLIB.Data.MyBindingSource bsItemsCatFilter;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyPickRowTextBox2 tbItemsCatFilter;
    }
}