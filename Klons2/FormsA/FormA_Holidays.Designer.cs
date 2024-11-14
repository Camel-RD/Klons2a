using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_Holidays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Holidays));
            dgvSvetki = new MyDataGridView();
            dgcDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsSvetki = new KlonsLIB.Data.MyBindingSource(components);
            bnavSvetki = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            label1 = new System.Windows.Forms.Label();
            tbSearch = new MyTextBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSvetki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSvetki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavSvetki).BeginInit();
            bnavSvetki.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSvetki
            // 
            dgvSvetki.AutoGenerateColumns = false;
            dgvSvetki.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSvetki.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSvetki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSvetki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDT, tAGDataGridViewTextBoxColumn });
            dgvSvetki.DataSource = bsSvetki;
            dgvSvetki.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSvetki.Location = new System.Drawing.Point(0, 28);
            dgvSvetki.Name = "dgvSvetki";
            dgvSvetki.Size = new System.Drawing.Size(447, 264);
            dgvSvetki.TabIndex = 0;
            dgvSvetki.MyCheckForChanges += dgvSvetki_MyCheckForChanges;
            dgvSvetki.CellParsing += dgvSvetki_CellParsing;
            dgvSvetki.UserDeletingRow += dgvSvetki_UserDeletingRow;
            dgvSvetki.KeyDown += dgvSvetki_KeyDown;
            dgvSvetki.KeyPress += dgvSvetki_KeyPress;
            // 
            // dgcDT
            // 
            dgcDT.DataPropertyName = "DT";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcDT.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDT.HeaderText = "datums";
            dgcDT.MinimumWidth = 4;
            dgcDT.Name = "dgcDT";
            dgcDT.Width = 85;
            // 
            // tAGDataGridViewTextBoxColumn
            // 
            tAGDataGridViewTextBoxColumn.DataPropertyName = "TAG";
            tAGDataGridViewTextBoxColumn.HeaderText = "TAG";
            tAGDataGridViewTextBoxColumn.MinimumWidth = 4;
            tAGDataGridViewTextBoxColumn.Name = "tAGDataGridViewTextBoxColumn";
            tAGDataGridViewTextBoxColumn.Visible = false;
            tAGDataGridViewTextBoxColumn.Width = 80;
            // 
            // bsSvetki
            // 
            bsSvetki.AutoSaveOnDelete = true;
            bsSvetki.DataMember = "HOLIDAYS";
            bsSvetki.MyDataSource = "KlonsAData";
            bsSvetki.Sort = "DT";
            bsSvetki.UseDataGridView = dgvSvetki;
            bsSvetki.ListChanged += bsSvetki_ListChanged;
            // 
            // bnavSvetki
            // 
            bnavSvetki.AddNewItem = bindingNavigatorAddNewItem;
            bnavSvetki.BindingSource = bsSvetki;
            bnavSvetki.CountItem = bindingNavigatorCountItem;
            bnavSvetki.CountItemFormat = " no {0}";
            bnavSvetki.DataGrid = dgvSvetki;
            bnavSvetki.DeleteItem = bindingNavigatorDeleteItem;
            bnavSvetki.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavSvetki.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavSvetki.Location = new System.Drawing.Point(0, 292);
            bnavSvetki.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavSvetki.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavSvetki.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavSvetki.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavSvetki.Name = "bnavSvetki";
            bnavSvetki.PositionItem = bindingNavigatorPositionItem;
            bnavSvetki.SaveItem = null;
            bnavSvetki.Size = new System.Drawing.Size(447, 30);
            bnavSvetki.TabIndex = 1;
            bnavSvetki.Text = "myBindingNavigator1";
            bnavSvetki.ItemDeleting += bnavSvetki_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(63, 27);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 27);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 27);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 27);
            tsbSave.Text = "toolStripButton1";
            tsbSave.Click += tsbSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 17);
            label1.TabIndex = 2;
            label1.Text = "Meklēt pēc gada:";
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(125, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(73, 23);
            tbSearch.TabIndex = 3;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbSearch);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(447, 28);
            panel1.TabIndex = 4;
            // 
            // FormA_Holidays
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(447, 322);
            Controls.Add(dgvSvetki);
            Controls.Add(panel1);
            Controls.Add(bnavSvetki);
            Name = "FormA_Holidays";
            Text = "Teritoriju kodi";
            Load += Form_Holidays_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSvetki).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSvetki).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavSvetki).EndInit();
            bnavSvetki.ResumeLayout(false);
            bnavSvetki.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyDataGridView dgvSvetki;
        private MyBindingNavigator bnavSvetki;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private KlonsLIB.Data.MyBindingSource bsSvetki;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}