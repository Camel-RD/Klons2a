
namespace KlonsM.FormsM
{
    partial class FormM_ItemsCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_ItemsCat));
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsItemsCat = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIsGroup = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcIsService = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dhcIsProduced = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcAcc6 = new KlonsLIB.Components.MyDgvMcCBColumn();
            bsAcc6 = new KlonsLIB.Data.MyBindingSource(components);
            dgcAcc7 = new KlonsLIB.Components.MyDgvMcCBColumn();
            bsAcc7 = new KlonsLIB.Data.MyBindingSource(components);
            dgcMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tbFilter = new KlonsLIB.Components.MyTextBox();
            tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAcc6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAcc7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bNav
            // 
            bNav.AddNewItem = bindingNavigatorAddNewItem;
            bNav.BindingSource = bsItemsCat;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvRows;
            bNav.DeleteItem = bindingNavigatorDeleteItem;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem, tsbFindPrev, tsbFind, tsbFindNext });
            bNav.Location = new System.Drawing.Point(0, 419);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bindingNavigatorSaveItem;
            bNav.Size = new System.Drawing.Size(1052, 31);
            bNav.TabIndex = 1;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 28);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bsItemsCat
            // 
            bsItemsCat.DataMember = "M_ITEMS_CAT";
            bsItemsCat.MyDataSource = "KlonsMData";
            bsItemsCat.Sort = "CODE";
            bsItemsCat.UseDataGridView = dgvRows;
            bsItemsCat.ListChanged += bsItemsCat_ListChanged;
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = true;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcName, dgcIsGroup, dgcIsService, dhcIsProduced, dgcAcc6, dgcAcc7, dgcMethod, dgcID });
            dgvRows.DataSource = bsItemsCat;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 30);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1052, 389);
            dgvRows.TabIndex = 3;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyPress += dgvRows_KeyPress;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "CODE";
            dgcCode.HeaderText = "kods";
            dgcCode.MinimumWidth = 8;
            dgcCode.Name = "dgcCode";
            dgcCode.Width = 200;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "NAME";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.Width = 300;
            // 
            // dgcIsGroup
            // 
            dgcIsGroup.DataPropertyName = "ISGROUP";
            dgcIsGroup.FalseValue = "0";
            dgcIsGroup.HeaderText = "virsgrupa";
            dgcIsGroup.MinimumWidth = 8;
            dgcIsGroup.Name = "dgcIsGroup";
            dgcIsGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIsGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIsGroup.TrueValue = "1";
            dgcIsGroup.Width = 90;
            // 
            // dgcIsService
            // 
            dgcIsService.DataPropertyName = "ISSERVICES";
            dgcIsService.FalseValue = "0";
            dgcIsService.HeaderText = "pakalp.";
            dgcIsService.MinimumWidth = 8;
            dgcIsService.Name = "dgcIsService";
            dgcIsService.TrueValue = "1";
            dgcIsService.Width = 60;
            // 
            // dhcIsProduced
            // 
            dhcIsProduced.DataPropertyName = "ISPRODUCED";
            dhcIsProduced.FalseValue = "0";
            dhcIsProduced.HeaderText = "ražots";
            dhcIsProduced.MinimumWidth = 8;
            dhcIsProduced.Name = "dhcIsProduced";
            dhcIsProduced.TrueValue = "1";
            dhcIsProduced.Width = 60;
            // 
            // dgcAcc6
            // 
            dgcAcc6.ColumnNames = new string[]
    {
    "ID",
    "NAME"
    };
            dgcAcc6.ColumnWidths = "80;200";
            dgcAcc6.DataPropertyName = "ACC6";
            dgcAcc6.DataSource = bsAcc6;
            dgcAcc6.DisplayMember = "ID";
            dgcAcc6.HeaderText = "konts 6";
            dgcAcc6.MaxDropDownItems = 15;
            dgcAcc6.MinimumWidth = 8;
            dgcAcc6.Name = "dgcAcc6";
            dgcAcc6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcAcc6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcAcc6.ValueMember = "ID";
            dgcAcc6.Width = 110;
            // 
            // bsAcc6
            // 
            bsAcc6.DataMember = "M_ACCOUNTS";
            bsAcc6.Filter = "TP=4 OR TP=1";
            bsAcc6.MyDataSource = "KlonsMData";
            bsAcc6.Sort = "ID";
            // 
            // dgcAcc7
            // 
            dgcAcc7.ColumnNames = new string[]
    {
    "ID",
    "NAME"
    };
            dgcAcc7.ColumnWidths = "80;200";
            dgcAcc7.DataPropertyName = "ACC7";
            dgcAcc7.DataSource = bsAcc7;
            dgcAcc7.DisplayMember = "ID";
            dgcAcc7.HeaderText = "konts 7";
            dgcAcc7.MaxDropDownItems = 15;
            dgcAcc7.MinimumWidth = 8;
            dgcAcc7.Name = "dgcAcc7";
            dgcAcc7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcAcc7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcAcc7.ValueMember = "ID";
            dgcAcc7.Width = 110;
            // 
            // bsAcc7
            // 
            bsAcc7.DataMember = "M_ACCOUNTS";
            bsAcc7.Filter = "TP=3 OR TP=1";
            bsAcc7.MyDataSource = "KlonsMData";
            bsAcc7.Sort = "ID";
            // 
            // dgcMethod
            // 
            dgcMethod.DataPropertyName = "METHOD";
            dgcMethod.DisplayStyleForCurrentCellOnly = true;
            dgcMethod.HeaderText = "metode";
            dgcMethod.MinimumWidth = 8;
            dgcMethod.Name = "dgcMethod";
            dgcMethod.ReadOnly = true;
            dgcMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcMethod.Visible = false;
            dgcMethod.Width = 90;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.MinimumWidth = 8;
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            dgcID.Width = 60;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 28);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(72, 28);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSaveItem
            // 
            bindingNavigatorSaveItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorSaveItem.Image");
            bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            bindingNavigatorSaveItem.Size = new System.Drawing.Size(92, 28);
            bindingNavigatorSaveItem.Text = "Saglabāt";
            bindingNavigatorSaveItem.Click += bindingNavigatorSaveItem_Click;
            // 
            // tsbFindPrev
            // 
            tsbFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFindPrev.Image = (System.Drawing.Image)resources.GetObject("tsbFindPrev.Image");
            tsbFindPrev.Name = "tsbFindPrev";
            tsbFindPrev.RightToLeftAutoMirrorImage = true;
            tsbFindPrev.Size = new System.Drawing.Size(28, 28);
            tsbFindPrev.Text = "Iet uz iepriekšējo";
            tsbFindPrev.Click += tsbFindPrev_Click;
            // 
            // tsbFind
            // 
            tsbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbFind.Name = "tsbFind";
            tsbFind.Size = new System.Drawing.Size(100, 31);
            tsbFind.ToolTipText = "meklēt tekstu kolonnā";
            tsbFind.Enter += tsbFind_Enter;
            tsbFind.KeyPress += tsbFind_KeyPress;
            // 
            // tsbFindNext
            // 
            tsbFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFindNext.Image = (System.Drawing.Image)resources.GetObject("tsbFindNext.Image");
            tsbFindNext.Name = "tsbFindNext";
            tsbFindNext.RightToLeftAutoMirrorImage = true;
            tsbFindNext.Size = new System.Drawing.Size(28, 28);
            tsbFindNext.Text = "Iet uz nākošo";
            tsbFindNext.Click += tsbFindNext_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbFilter);
            panel1.Controls.Add(tbCode);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1052, 30);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(168, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 4;
            label1.Text = "atlasīt:";
            // 
            // tbFilter
            // 
            tbFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbFilter.Location = new System.Drawing.Point(223, 3);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new System.Drawing.Size(185, 23);
            tbFilter.TabIndex = 3;
            tbFilter.KeyDown += tbFilter_KeyDown;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // tbCode
            // 
            tbCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbCode.DataMember = null;
            tbCode.DataSource = bsItemsCat;
            tbCode.DisplayMember = "CODE";
            tbCode.Location = new System.Drawing.Point(3, 3);
            tbCode.Name = "tbCode";
            tbCode.SelectedIndex = -1;
            tbCode.Size = new System.Drawing.Size(146, 23);
            tbCode.TabIndex = 1;
            tbCode.ValueMember = "ID";
            tbCode.RowSelectedEvent += tbCode_RowSelectedEvent;
            tbCode.Enter += tbCode_Enter;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_ACCOUNTS",
    "M_ITEMS",
    "M_ITEMS_CAT",
    null
    };
            // 
            // FormM_ItemsCat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1052, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Controls.Add(bNav);
            Name = "FormM_ItemsCat";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Produktu kategorijas";
            Load += FormM_ItemsCat_Load;
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAcc6).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAcc7).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bNav;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private KlonsLIB.Components.MyTextBox tbFilter;
        private KlonsLIB.Data.MyBindingSource bsItemsCat;
        private KlonsLIB.Data.MyBindingSource bsAcc7;
        private KlonsLIB.Data.MyBindingSource bsAcc6;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsGroup;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsService;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dhcIsProduced;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcAcc6;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcAcc7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}