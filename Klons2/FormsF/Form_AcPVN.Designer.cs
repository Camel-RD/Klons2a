using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_AcPVN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcPVN));
            label1 = new System.Windows.Forms.Label();
            tbIdx = new MyPickRowTextBox();
            bsAcP5 = new MyBindingSource(components);
            dgvAcPVN = new MyDataGridView();
            dgcIdx = new MyDgvMcCBColumn();
            bsAcPVN = new MyBindingSource(components);
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnavAcp5 = new MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsAcP5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcPVN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAcPVN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp5).BeginInit();
            bnavAcp5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 6);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "Kods:";
            // 
            // tbIdx
            // 
            tbIdx.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbIdx.DataMember = null;
            tbIdx.DataSource = bsAcP5;
            tbIdx.Location = new System.Drawing.Point(52, 5);
            tbIdx.Margin = new System.Windows.Forms.Padding(2);
            tbIdx.Name = "tbIdx";
            tbIdx.SelectedIndex = -1;
            tbIdx.Size = new System.Drawing.Size(90, 23);
            tbIdx.TabIndex = 0;
            tbIdx.RowSelectedEvent += tbIdx_RowSelectedEvent;
            tbIdx.Enter += tbIdx_Enter;
            // 
            // bsAcP5
            // 
            bsAcP5.AutoSaveOnDelete = true;
            bsAcP5.DataMember = "Acp25";
            bsAcP5.Filter = "";
            bsAcP5.MyDataSource = "KlonsData";
            bsAcP5.Name2 = "bsAcP5";
            bsAcP5.Sort = "idx";
            bsAcP5.ListChanged += bsAcP5_ListChanged;
            // 
            // dgvAcPVN
            // 
            dgvAcPVN.AutoGenerateColumns = false;
            dgvAcPVN.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvAcPVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcPVN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcIdx, dgcName });
            dgvAcPVN.DataSource = bsAcP5;
            dgvAcPVN.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAcPVN.Location = new System.Drawing.Point(0, 29);
            dgvAcPVN.Margin = new System.Windows.Forms.Padding(2);
            dgvAcPVN.Name = "dgvAcPVN";
            dgvAcPVN.RowHeadersWidth = 62;
            dgvAcPVN.Size = new System.Drawing.Size(784, 326);
            dgvAcPVN.TabIndex = 1;
            dgvAcPVN.MyKeyDown += dgvAcPVN_MyKeyDown;
            dgvAcPVN.MyCheckForChanges += dgvAcPVN_MyCheckForChanges;
            dgvAcPVN.CellDoubleClick += dgvAcPVN_CellDoubleClick;
            dgvAcPVN.CellValueChanged += dgvAcPVN_CellValueChanged;
            dgvAcPVN.UserDeletingRow += dgvAcPVN_UserDeletingRow;
            dgvAcPVN.KeyDown += dgvAcPVN_KeyDown;
            // 
            // dgcIdx
            // 
            dgcIdx.ColumnNames = new string[]
    {
    "id",
    "NM"
    };
            dgcIdx.ColumnWidths = "50;600";
            dgcIdx.DataPropertyName = "idx";
            dgcIdx.DataSource = bsAcPVN;
            dgcIdx.DisplayMember = "id";
            dgcIdx.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            dgcIdx.HeaderText = "kods";
            dgcIdx.MaxDropDownItems = 15;
            dgcIdx.MinimumWidth = 9;
            dgcIdx.Name = "dgcIdx";
            dgcIdx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIdx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIdx.ValueMember = "id";
            dgcIdx.Width = 72;
            // 
            // bsAcPVN
            // 
            bsAcPVN.DataMember = "AcPVN";
            bsAcPVN.MyDataSource = "KlonsData";
            bsAcPVN.Name2 = "bsAcPVN";
            bsAcPVN.Sort = "ID";
            // 
            // dgcName
            // 
            dgcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 9;
            dgcName.Name = "dgcName";
            dgcName.Width = 105;
            // 
            // bnavAcp5
            // 
            bnavAcp5.AddNewItem = bindingNavigatorAddNewItem;
            bnavAcp5.BindingSource = bsAcP5;
            bnavAcp5.CountItem = bindingNavigatorCountItem;
            bnavAcp5.CountItemFormat = " no {0}";
            bnavAcp5.DataGrid = dgvAcPVN;
            bnavAcp5.DeleteItem = bindingNavigatorDeleteItem;
            bnavAcp5.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavAcp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavAcp5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavAcp5.Location = new System.Drawing.Point(0, 355);
            bnavAcp5.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavAcp5.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavAcp5.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavAcp5.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavAcp5.Name = "bnavAcp5";
            bnavAcp5.PositionItem = bindingNavigatorPositionItem;
            bnavAcp5.SaveItem = null;
            bnavAcp5.Size = new System.Drawing.Size(784, 25);
            bnavAcp5.TabIndex = 2;
            bnavAcp5.Text = "bindingNavigator1";
            bnavAcp5.ItemDeleting += bnavAcp5_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(66, 22);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns (Shift+Insert)";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 22);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(64, 22);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.ToolTipText = "Dzēst (Ctrl+Delete)";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(46, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 22);
            tsbSave.Text = "Saglabāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbIdx);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(784, 29);
            panel1.TabIndex = 0;
            // 
            // Form_AcPVN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 380);
            Controls.Add(dgvAcPVN);
            Controls.Add(panel1);
            Controls.Add(bnavAcp5);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_AcPVN";
            Text = "Kontējuma PVN pazīmes";
            FormClosed += Form_AcPVN_FormClosed;
            Load += FormAcPVN_Load;
            KeyPress += FormAcPVN_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bsAcP5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcPVN).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAcPVN).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp5).EndInit();
            bnavAcp5.ResumeLayout(false);
            bnavAcp5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingNavigator bnavAcp5;
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
        private MyDataGridView dgvAcPVN;
        private MyBindingSource bsAcP5;
        private MyPickRowTextBox tbIdx;
        private System.Windows.Forms.Label label1;
        private MyBindingSource bsAcPVN;
        private MyDgvMcCBColumn dgcIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.Panel panel1;
    }
}