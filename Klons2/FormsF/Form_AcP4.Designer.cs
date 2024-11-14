using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_AcP4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcP4));
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbSearch = new MyTextBox();
            tbIdx = new MyPickRowTextBox();
            dgvAcP4 = new MyDataGridView();
            dgcIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsAcP4 = new MyBindingSource(components);
            bnavAcp4 = new MyBindingNavigator();
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
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAcP4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAcP4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp4).BeginInit();
            bnavAcp4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(138, 5);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 5;
            label2.Text = "meklēt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 5);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "Kods:";
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(197, 4);
            tbSearch.Margin = new System.Windows.Forms.Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(88, 23);
            tbSearch.TabIndex = 1;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // tbIdx
            // 
            tbIdx.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbIdx.DataMember = null;
            tbIdx.Location = new System.Drawing.Point(53, 4);
            tbIdx.Margin = new System.Windows.Forms.Padding(2);
            tbIdx.Name = "tbIdx";
            tbIdx.SelectedIndex = -1;
            tbIdx.Size = new System.Drawing.Size(80, 23);
            tbIdx.TabIndex = 0;
            tbIdx.RowSelectedEvent += tbIdx_RowSelectedEvent;
            tbIdx.Enter += tbIdx_Enter;
            // 
            // dgvAcP4
            // 
            dgvAcP4.AutoGenerateColumns = false;
            dgvAcP4.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvAcP4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcP4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcIdx, dgcName, dgcUnit, dgcPrice });
            dgvAcP4.DataSource = bsAcP4;
            dgvAcP4.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAcP4.Location = new System.Drawing.Point(0, 28);
            dgvAcP4.Margin = new System.Windows.Forms.Padding(2);
            dgvAcP4.Name = "dgvAcP4";
            dgvAcP4.Size = new System.Drawing.Size(576, 281);
            dgvAcP4.TabIndex = 2;
            dgvAcP4.MyKeyDown += dgvAcP4_MyKeyDown;
            dgvAcP4.MyCheckForChanges += dgvAcP4_MyCheckForChanges;
            dgvAcP4.CellDoubleClick += dgvAcP4_CellDoubleClick;
            dgvAcP4.UserDeletingRow += dgvAcP4_UserDeletingRow;
            dgvAcP4.KeyDown += dgvAcP4_KeyDown;
            dgvAcP4.KeyPress += dgvAcP4_KeyPress;
            // 
            // dgcIdx
            // 
            dgcIdx.DataPropertyName = "idx";
            dgcIdx.HeaderText = "kods";
            dgcIdx.Name = "dgcIdx";
            dgcIdx.Width = 64;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.Name = "dgcName";
            dgcName.Width = 280;
            // 
            // dgcUnit
            // 
            dgcUnit.DataPropertyName = "UNIT";
            dgcUnit.HeaderText = "Mērv.";
            dgcUnit.Name = "dgcUnit";
            dgcUnit.Width = 80;
            // 
            // dgcPrice
            // 
            dgcPrice.DataPropertyName = "PRICE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "F2";
            dgcPrice.DefaultCellStyle = dataGridViewCellStyle1;
            dgcPrice.HeaderText = "Cena";
            dgcPrice.Name = "dgcPrice";
            dgcPrice.Width = 80;
            // 
            // bsAcP4
            // 
            bsAcP4.AutoSaveOnDelete = true;
            bsAcP4.DataMember = "AcP24";
            bsAcP4.Filter = "";
            bsAcP4.MyDataSource = "KlonsData";
            bsAcP4.Name2 = "bsAcP4";
            bsAcP4.Sort = "idx";
            bsAcP4.ListChanged += bsAcP4_ListChanged;
            // 
            // bnavAcp4
            // 
            bnavAcp4.AddNewItem = bindingNavigatorAddNewItem;
            bnavAcp4.BindingSource = bsAcP4;
            bnavAcp4.CountItem = bindingNavigatorCountItem;
            bnavAcp4.CountItemFormat = " no {0}";
            bnavAcp4.DataGrid = dgvAcP4;
            bnavAcp4.DeleteItem = bindingNavigatorDeleteItem;
            bnavAcp4.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavAcp4.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnavAcp4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavAcp4.Location = new System.Drawing.Point(0, 309);
            bnavAcp4.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavAcp4.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavAcp4.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavAcp4.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavAcp4.Name = "bnavAcp4";
            bnavAcp4.PositionItem = bindingNavigatorPositionItem;
            bnavAcp4.SaveItem = null;
            bnavAcp4.Size = new System.Drawing.Size(576, 33);
            bnavAcp4.TabIndex = 3;
            bnavAcp4.Text = "bindingNavigator1";
            bnavAcp4.ItemDeleting += bnavAcp4_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns (Shift+Insert)";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.ToolTipText = "Dzēst (Ctrl+Delete)";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            bindingNavigatorMoveFirstItem.ToolTipText = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            bindingNavigatorMovePreviousItem.ToolTipText = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 30);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMoveNextItem.Text = "Move next";
            bindingNavigatorMoveNextItem.ToolTipText = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMoveLastItem.Text = "Move last";
            bindingNavigatorMoveLastItem.ToolTipText = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(30, 30);
            tsbSave.Text = "Sagalbāt datus";
            tsbSave.ToolTipText = "Saglabāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbIdx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(576, 28);
            panel1.TabIndex = 6;
            // 
            // Form_AcP4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 342);
            Controls.Add(dgvAcP4);
            Controls.Add(panel1);
            Controls.Add(bnavAcp4);
            Name = "Form_AcP4";
            Text = "Nozares / produkti";
            Load += FormAcP4_Load;
            KeyPress += FormAcP4_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvAcP4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAcP4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp4).EndInit();
            bnavAcp4.ResumeLayout(false);
            bnavAcp4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingNavigator bnavAcp4;
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
        private System.Windows.Forms.ToolStripButton tsbSave;
        private MyDataGridView dgvAcP4;
        private MyBindingSource bsAcP4;
        private MyPickRowTextBox tbIdx;
        private MyTextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPrice;
        private System.Windows.Forms.Panel panel1;
    }
}