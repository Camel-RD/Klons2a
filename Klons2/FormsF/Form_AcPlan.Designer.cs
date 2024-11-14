using KlonsLIB.Components;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsF.Forms
{
    partial class Form_AcPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcPlan));
            bnavAcp21 = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsAcPlan = new MyBindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvAcp21 = new MyDataGridView();
            dgcAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcId1 = new MyDgvMcCBColumn();
            dgcId2 = new MyDgvMcCBColumn();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            tbAcc = new MyPickRowTextBox();
            tbSearch = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)bnavAcp21).BeginInit();
            bnavAcp21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsAcPlan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcp21).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bnavAcp21
            // 
            bnavAcp21.AddNewItem = bindingNavigatorAddNewItem;
            bnavAcp21.BindingSource = bsAcPlan;
            bnavAcp21.CountItem = bindingNavigatorCountItem;
            bnavAcp21.CountItemFormat = " no {0}";
            bnavAcp21.DataGrid = dgvAcp21;
            bnavAcp21.DeleteItem = bindingNavigatorDeleteItem;
            bnavAcp21.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavAcp21.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnavAcp21.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, toolStripButtonInfo, tsbSave });
            bnavAcp21.Location = new System.Drawing.Point(0, 334);
            bnavAcp21.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavAcp21.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavAcp21.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavAcp21.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavAcp21.Name = "bnavAcp21";
            bnavAcp21.PositionItem = bindingNavigatorPositionItem;
            bnavAcp21.SaveItem = null;
            bnavAcp21.Size = new System.Drawing.Size(826, 33);
            bnavAcp21.TabIndex = 0;
            bnavAcp21.Text = "bindingNavigator1";
            bnavAcp21.ItemDeleting += acP21BindingNavigator_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns (Ctrl+Insert)";
            // 
            // bsAcPlan
            // 
            bsAcPlan.AutoSaveOnDelete = true;
            bsAcPlan.DataMember = "AcP21";
            bsAcPlan.MyDataSource = "KlonsData";
            bsAcPlan.Name2 = "AcPlan";
            bsAcPlan.Sort = "Ac";
            bsAcPlan.ListChanged += bsAcPlan_ListChanged;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // dgvAcp21
            // 
            dgvAcp21.AutoGenerateColumns = false;
            dgvAcp21.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvAcp21.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcp21.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcAc, dgcName, dgcId1, dgcId2 });
            dgvAcp21.DataSource = bsAcPlan;
            dgvAcp21.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAcp21.Location = new System.Drawing.Point(0, 28);
            dgvAcp21.Margin = new System.Windows.Forms.Padding(2);
            dgvAcp21.Name = "dgvAcp21";
            dgvAcp21.RowHeadersWidth = 53;
            dgvAcp21.RowTemplate.Height = 25;
            dgvAcp21.Size = new System.Drawing.Size(826, 306);
            dgvAcp21.TabIndex = 2;
            dgvAcp21.MyKeyDown += acP21DataGridView_MyKeyDown;
            dgvAcp21.MyCheckForChanges += dgvAcp21_MyCheckForChanges;
            dgvAcp21.CellDoubleClick += acP21DataGridView_CellDoubleClick;
            dgvAcp21.UserDeletingRow += acP21DataGridView_UserDeletingRow;
            dgvAcp21.KeyDown += acP21DataGridView_KeyDown;
            dgvAcp21.KeyPress += acP21DataGridView_KeyPress;
            // 
            // dgcAc
            // 
            dgcAc.DataPropertyName = "AC";
            dgcAc.HeaderText = "kods";
            dgcAc.MinimumWidth = 6;
            dgcAc.Name = "dgcAc";
            dgcAc.Width = 64;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 6;
            dgcName.Name = "dgcName";
            dgcName.Width = 499;
            // 
            // dgcId1
            // 
            dgcId1.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcId1.ColumnWidths = "50;100";
            dgcId1.DataPropertyName = "id1";
            dgcId1.DisplayMember = "col1";
            dgcId1.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            dgcId1.HeaderText = "paz.np.";
            dgcId1.ItemStrings = new string[]
    {
    "BA;banka",
    "CN;cita nauda",
    "KA;kase"
    };
            dgcId1.MaxDropDownItems = 15;
            dgcId1.MinimumWidth = 6;
            dgcId1.Name = "dgcId1";
            dgcId1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcId1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcId1.ToolTipText = "pazīme naudas plūsmai";
            dgcId1.ValueMember = "col1";
            dgcId1.Width = 80;
            // 
            // dgcId2
            // 
            dgcId2.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcId2.ColumnWidths = "50;100";
            dgcId2.DataPropertyName = "id2";
            dgcId2.DisplayMember = "col1";
            dgcId2.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            dgcId2.HeaderText = "paz.2";
            dgcId2.ItemStrings = new string[]
    {
    "DB;debitoriem",
    "KR;kreditoriem"
    };
            dgcId2.MaxDropDownItems = 15;
            dgcId2.MinimumWidth = 6;
            dgcId2.Name = "dgcId2";
            dgcId2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcId2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcId2.ValueMember = "col1";
            dgcId2.Width = 80;
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
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
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
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 27);
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
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(30, 30);
            bindingNavigatorMoveLastItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButtonInfo
            // 
            toolStripButtonInfo.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonInfo.Image");
            toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonInfo.Name = "toolStripButtonInfo";
            toolStripButtonInfo.Size = new System.Drawing.Size(63, 30);
            toolStripButtonInfo.Text = "Info";
            toolStripButtonInfo.Click += toolStripButtonInfo_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(30, 30);
            tsbSave.Text = "Sagalbāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // tbAcc
            // 
            tbAcc.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbAcc.DataMember = null;
            tbAcc.DataSource = bsAcPlan;
            tbAcc.Location = new System.Drawing.Point(54, 4);
            tbAcc.Margin = new System.Windows.Forms.Padding(2);
            tbAcc.Name = "tbAcc";
            tbAcc.SelectedIndex = -1;
            tbAcc.Size = new System.Drawing.Size(82, 23);
            tbAcc.TabIndex = 0;
            tbAcc.RowSelectedEvent += tbAcc_RowSelectedEvent;
            tbAcc.Enter += tbAcc_Enter;
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(203, 4);
            tbSearch.Margin = new System.Windows.Forms.Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(118, 23);
            tbSearch.TabIndex = 1;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 5);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "Kods:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(145, 5);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 5;
            label2.Text = "meklēt:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbAcc);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(826, 28);
            panel1.TabIndex = 6;
            // 
            // Form_AcPlan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(826, 367);
            Controls.Add(dgvAcp21);
            Controls.Add(panel1);
            Controls.Add(bnavAcp21);
            Name = "Form_AcPlan";
            Text = "Kontu plāns";
            Load += FormAcPlan_Load;
            ((System.ComponentModel.ISupportInitialize)bnavAcp21).EndInit();
            bnavAcp21.ResumeLayout(false);
            bnavAcp21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsAcPlan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAcp21).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingNavigator bnavAcp21;
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
        private MyBindingSource bsAcPlan;
        private MyDataGridView dgvAcp21;
        private MyPickRowTextBox tbAcc;
        private MyTextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private MyDgvMcCBColumn dgcId1;
        private MyDgvMcCBColumn dgcId2;
        private System.Windows.Forms.Panel panel1;
    }
}