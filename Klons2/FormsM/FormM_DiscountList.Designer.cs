
namespace KlonsM.FormsM
{
    partial class FormM_DiscountList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_DiscountList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            bsLists = new KlonsLIB.Data.MyBindingSource(components);
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bniNew = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bniDelete = new System.Windows.Forms.ToolStripButton();
            tslActiveTable = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bniSave = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            bsRowsR = new KlonsLIB.Data.MyBindingSource2(components);
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            tbLists = new KlonsLIB.Components.MyPickRowTextBox2();
            dgvRowsR = new KlonsLIB.Components.MyDataGridView();
            dgcRIdItemsCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsItemsCat = new KlonsLIB.Data.MyBindingSource(components);
            dgcRIdcItem = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            dgcRItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tcTabs = new KlonsLIB.Components.ExTabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            dgvRowsP = new KlonsLIB.Components.MyDataGridView();
            dgcPIdStoresCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStoresCat = new KlonsLIB.Data.MyBindingSource(components);
            dgcPIdStore = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStores = new KlonsLIB.Data.MyBindingSource(components);
            bsRowsP = new KlonsLIB.Data.MyBindingSource2(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bsLists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRowsR).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRowsR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            tcTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRowsP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoresCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRowsP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsLists
            // 
            bsLists.DataMember = "M_DISC_LISTS";
            bsLists.MyDataSource = "KlonsMData";
            bsLists.CurrentChanged += bsLists_CurrentChanged;
            bsLists.ListChanged += bsLists_ListChanged;
            // 
            // bNav
            // 
            bNav.AddNewItem = bniNew;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DeleteItem = bniDelete;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(16, 16);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslActiveTable, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bniNew, bniDelete, bniSave, tsbFindPrev, tsbFind, tsbFindNext });
            bNav.Location = new System.Drawing.Point(0, 512);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bniSave;
            bNav.Size = new System.Drawing.Size(903, 31);
            bNav.TabIndex = 3;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bniNew
            // 
            bniNew.Image = (System.Drawing.Image)resources.GetObject("bniNew.Image");
            bniNew.Name = "bniNew";
            bniNew.RightToLeftAutoMirrorImage = true;
            bniNew.Size = new System.Drawing.Size(74, 28);
            bniNew.Text = "Jauns";
            bniNew.Click += bniNew_Click;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 28);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bniDelete
            // 
            bniDelete.Image = (System.Drawing.Image)resources.GetObject("bniDelete.Image");
            bniDelete.Name = "bniDelete";
            bniDelete.RightToLeftAutoMirrorImage = true;
            bniDelete.Size = new System.Drawing.Size(72, 28);
            bniDelete.Text = "Dzēst";
            bniDelete.Click += bniDelete_Click;
            // 
            // tslActiveTable
            // 
            tslActiveTable.Name = "tslActiveTable";
            tslActiveTable.Size = new System.Drawing.Size(20, 28);
            tslActiveTable.Text = "...";
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
            // bniSave
            // 
            bniSave.Image = (System.Drawing.Image)resources.GetObject("bniSave.Image");
            bniSave.Name = "bniSave";
            bniSave.Size = new System.Drawing.Size(92, 28);
            bniSave.Text = "Saglabāt";
            bniSave.Click += bniSave_Click;
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
            // bsRowsR
            // 
            bsRowsR.DataMember = "FK_M_DISC_LISTS_R_IDL";
            bsRowsR.DataSource = bsLists;
            bsRowsR.ListChanged += bsRowsR_ListChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbLists);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(903, 32);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 1;
            label1.Text = "Atlaižu lapas:";
            // 
            // tbLists
            // 
            tbLists.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbLists.DataMember = null;
            tbLists.DataSource = bsLists;
            tbLists.DisplayMember = "NAME";
            tbLists.Location = new System.Drawing.Point(118, 4);
            tbLists.Name = "tbLists";
            tbLists.SelectedIndex = -1;
            tbLists.ShowButton = true;
            tbLists.Size = new System.Drawing.Size(259, 23);
            tbLists.TabIndex = 0;
            tbLists.ValueMember = "ID";
            tbLists.ButtonClicked += tbLists_ButtonClicked;
            // 
            // dgvRowsR
            // 
            dgvRowsR.AutoGenerateColumns = false;
            dgvRowsR.AutoSave = false;
            dgvRowsR.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRowsR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRowsR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcRIdItemsCat, dgcRIdcItem, dgcRItemName, dgcRDiscount });
            dgvRowsR.DataSource = bsRowsR;
            dgvRowsR.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRowsR.Location = new System.Drawing.Point(3, 3);
            dgvRowsR.Name = "dgvRowsR";
            dgvRowsR.RowHeadersWidth = 62;
            dgvRowsR.ShowCellToolTips = false;
            dgvRowsR.Size = new System.Drawing.Size(889, 445);
            dgvRowsR.TabIndex = 5;
            dgvRowsR.MyKeyDown += dgvRowsR_MyKeyDown;
            dgvRowsR.MyCheckForChanges += dgvRowsR_MyCheckForChanges;
            dgvRowsR.CellDoubleClick += dgvRowsR_CellDoubleClick;
            dgvRowsR.CellFormatting += dgvRowsR_CellFormatting;
            dgvRowsR.UserDeletingRow += dgvRowsR_UserDeletingRow;
            dgvRowsR.Enter += dgvRowsR_Enter;
            // 
            // dgcRIdItemsCat
            // 
            dgcRIdItemsCat.DataPropertyName = "IDITEMSCAT";
            dgcRIdItemsCat.DataSource = bsItemsCat;
            dgcRIdItemsCat.DisplayMember = "CODE";
            dgcRIdItemsCat.HeaderText = "artikulu kategorija";
            dgcRIdItemsCat.MinimumWidth = 8;
            dgcRIdItemsCat.Name = "dgcRIdItemsCat";
            dgcRIdItemsCat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcRIdItemsCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcRIdItemsCat.ValueMember = "ID";
            dgcRIdItemsCat.Width = 200;
            // 
            // bsItemsCat
            // 
            bsItemsCat.DataMember = "M_ITEMS_CAT";
            bsItemsCat.MyDataSource = "KlonsMData";
            bsItemsCat.Sort = "CODE";
            // 
            // dgcRIdcItem
            // 
            dgcRIdcItem.DataPropertyName = "IDITEM";
            dgcRIdcItem.DataSource = bsItems;
            dgcRIdcItem.DisplayMember = "BARCODE";
            dgcRIdcItem.HeaderText = "artikuls";
            dgcRIdcItem.MinimumWidth = 8;
            dgcRIdcItem.Name = "dgcRIdcItem";
            dgcRIdcItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcRIdcItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcRIdcItem.ValueMember = "ID";
            dgcRIdcItem.Width = 160;
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // dgcRItemName
            // 
            dgcRItemName.DataPropertyName = "IDITEM";
            dgcRItemName.HeaderText = "nosaukums";
            dgcRItemName.MinimumWidth = 8;
            dgcRItemName.Name = "dgcRItemName";
            dgcRItemName.ReadOnly = true;
            dgcRItemName.Width = 300;
            // 
            // dgcRDiscount
            // 
            dgcRDiscount.DataPropertyName = "DISCOUNT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRDiscount.DefaultCellStyle = dataGridViewCellStyle1;
            dgcRDiscount.HeaderText = "atlaide";
            dgcRDiscount.MinimumWidth = 8;
            dgcRDiscount.Name = "dgcRDiscount";
            dgcRDiscount.Width = 95;
            // 
            // tcTabs
            // 
            tcTabs.Controls.Add(tabPage1);
            tcTabs.Controls.Add(tabPage2);
            tcTabs.DefaultStyle = false;
            tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            tcTabs.Location = new System.Drawing.Point(0, 32);
            tcTabs.Name = "tcTabs";
            tcTabs.SelectedIndex = 0;
            tcTabs.Size = new System.Drawing.Size(903, 480);
            tcTabs.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvRowsR);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(895, 451);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Artikuli";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvRowsP);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(895, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Partneri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRowsP
            // 
            dgvRowsP.AutoGenerateColumns = false;
            dgvRowsP.AutoSave = false;
            dgvRowsP.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRowsP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRowsP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcPIdStoresCat, dgcPIdStore });
            dgvRowsP.DataSource = bsRowsP;
            dgvRowsP.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRowsP.Location = new System.Drawing.Point(3, 3);
            dgvRowsP.Name = "dgvRowsP";
            dgvRowsP.RowHeadersWidth = 62;
            dgvRowsP.ShowCellToolTips = false;
            dgvRowsP.Size = new System.Drawing.Size(889, 431);
            dgvRowsP.TabIndex = 0;
            dgvRowsP.MyKeyDown += dgvRowsP_MyKeyDown;
            dgvRowsP.MyCheckForChanges += dgvRowsP_MyCheckForChanges;
            dgvRowsP.CellDoubleClick += dgvRowsP_CellDoubleClick;
            dgvRowsP.UserDeletingRow += dgvRowsP_UserDeletingRow;
            dgvRowsP.Enter += dgvRowsP_Enter;
            // 
            // dgcPIdStoresCat
            // 
            dgcPIdStoresCat.DataPropertyName = "IDSTORESCAT";
            dgcPIdStoresCat.DataSource = bsStoresCat;
            dgcPIdStoresCat.DisplayMember = "CODE";
            dgcPIdStoresCat.HeaderText = "partneru kategorija";
            dgcPIdStoresCat.MinimumWidth = 8;
            dgcPIdStoresCat.Name = "dgcPIdStoresCat";
            dgcPIdStoresCat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPIdStoresCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPIdStoresCat.ValueMember = "ID";
            dgcPIdStoresCat.Width = 200;
            // 
            // bsStoresCat
            // 
            bsStoresCat.DataMember = "M_STORES_CAT";
            bsStoresCat.MyDataSource = "KlonsMData";
            bsStoresCat.Sort = "CODE";
            // 
            // dgcPIdStore
            // 
            dgcPIdStore.DataPropertyName = "IDSTORE";
            dgcPIdStore.DataSource = bsStores;
            dgcPIdStore.DisplayMember = "CODE";
            dgcPIdStore.HeaderText = "partneris";
            dgcPIdStore.MinimumWidth = 8;
            dgcPIdStore.Name = "dgcPIdStore";
            dgcPIdStore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPIdStore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPIdStore.ValueMember = "ID";
            dgcPIdStore.Width = 200;
            // 
            // bsStores
            // 
            bsStores.DataMember = "M_STORES";
            bsStores.MyDataSource = "KlonsMData";
            bsStores.Sort = "CODE";
            // 
            // bsRowsP
            // 
            bsRowsP.DataMember = "FK_M_DISC_LISTS_P_IDL";
            bsRowsP.DataSource = bsLists;
            bsRowsP.ListChanged += bsRowsP_ListChanged;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_DISC_LISTS",
    "M_DISC_LISTS_P",
    "M_DISC_LISTS_R",
    null
    };
            // 
            // FormM_DiscountList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(903, 543);
            Controls.Add(tcTabs);
            Controls.Add(panel1);
            Controls.Add(bNav);
            Name = "FormM_DiscountList";
            Text = "Atlaižu lapa";
            Load += FormM_DiscountList_Load;
            ((System.ComponentModel.ISupportInitialize)bsLists).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRowsR).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRowsR).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            tcTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRowsP).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoresCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStores).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRowsP).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsLists;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bniNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bniDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bniSave;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private KlonsLIB.Data.MyBindingSource2 bsRowsR;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvRowsR;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyPickRowTextBox2 tbLists;
        private KlonsLIB.Components.ExTabControl tcTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private KlonsLIB.Data.MyBindingSource2 bsRowsP;
        private KlonsLIB.Components.MyDataGridView dgvRowsP;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Data.MyBindingSource bsItemsCat;
        private KlonsLIB.Data.MyBindingSource bsStores;
        private KlonsLIB.Data.MyBindingSource bsStoresCat;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripLabel tslActiveTable;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRIdItemsCat;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRIdcItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRDiscount;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPIdStoresCat;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPIdStore;
    }
}