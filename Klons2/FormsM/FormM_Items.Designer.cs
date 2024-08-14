
namespace KlonsM.FormsM
{
    partial class FormM_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_Items));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsItemsCat = new KlonsLIB.Data.MyBindingSource(components);
            dgcStore1 = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStore = new KlonsLIB.Data.MyBindingSource(components);
            dgcPVNRate = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsPVNRate = new KlonsLIB.Data.MyBindingSource(components);
            dgcIsService = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcIsProduced = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcUints = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsUnits = new KlonsLIB.Data.MyBindingSource(components);
            dgcSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAmountInStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLastBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcProdCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLastSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbItemsCatFilter = new KlonsLIB.Components.MyPickRowTextBox2();
            bsItemsCatFilter = new KlonsLIB.Data.MyBindingSource(components);
            tbFilter = new KlonsLIB.Components.MyTextBox();
            tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            miArtikuliTools = new System.Windows.Forms.ToolStripMenuItem();
            miAktuālieArtikulaAtlikumi = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miImportētCenuLapu = new System.Windows.Forms.ToolStripMenuItem();
            miImportētPašizmaksasDatus = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            miReloadFromDB = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCatFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bNav
            // 
            bNav.AddNewItem = bindingNavigatorAddNewItem;
            bNav.BindingSource = bsItems;
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
            bNav.Size = new System.Drawing.Size(1199, 31);
            bNav.TabIndex = 2;
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
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            bsItems.UseDataGridView = dgvRows;
            bsItems.ListChanged += bsItems_ListChanged;
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcID, dgcCode, dgcName, dgcCat, dgcStore1, dgcPVNRate, dgcIsService, dgcIsProduced, dgcUints, dgcSellPrice, dgcAmountInStore, dgcBBuyPrice, dgcLastBuyPrice, dgcProdCosts, dgcLastSaleDate });
            dgvRows.DataSource = bsItems;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 30);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1199, 389);
            dgvRows.TabIndex = 1;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyPress += dgvRows_KeyPress;
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
            // dgcCode
            // 
            dgcCode.DataPropertyName = "BARCODE";
            dgcCode.HeaderText = "kods";
            dgcCode.MinimumWidth = 8;
            dgcCode.Name = "dgcCode";
            dgcCode.Width = 160;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "NAME";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.Width = 300;
            // 
            // dgcCat
            // 
            dgcCat.DataPropertyName = "CAT";
            dgcCat.DataSource = bsItemsCat;
            dgcCat.DisplayMember = "CODE";
            dgcCat.HeaderText = "kategorija";
            dgcCat.MinimumWidth = 8;
            dgcCat.Name = "dgcCat";
            dgcCat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcCat.ValueMember = "ID";
            dgcCat.Width = 140;
            // 
            // bsItemsCat
            // 
            bsItemsCat.DataMember = "M_ITEMS_CAT";
            bsItemsCat.MyDataSource = "KlonsMData";
            bsItemsCat.Sort = "CODE";
            // 
            // dgcStore1
            // 
            dgcStore1.DataPropertyName = "STORE1";
            dgcStore1.DataSource = bsStore;
            dgcStore1.DisplayMember = "CODE";
            dgcStore1.HeaderText = "noliktava";
            dgcStore1.MinimumWidth = 8;
            dgcStore1.Name = "dgcStore1";
            dgcStore1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcStore1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcStore1.ValueMember = "ID";
            dgcStore1.Width = 160;
            // 
            // bsStore
            // 
            bsStore.DataMember = "M_STORES";
            bsStore.Filter = "TP=2 OR ID=1";
            bsStore.MyDataSource = "KlonsMData";
            bsStore.Sort = "CODE";
            // 
            // dgcPVNRate
            // 
            dgcPVNRate.DataPropertyName = "PVNRATE";
            dgcPVNRate.DataSource = bsPVNRate;
            dgcPVNRate.DisplayMember = "CODE";
            dgcPVNRate.HeaderText = "PVN likme";
            dgcPVNRate.MinimumWidth = 8;
            dgcPVNRate.Name = "dgcPVNRate";
            dgcPVNRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPVNRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPVNRate.ValueMember = "ID";
            dgcPVNRate.Width = 120;
            // 
            // bsPVNRate
            // 
            bsPVNRate.DataMember = "M_PVNRATES";
            bsPVNRate.MyDataSource = "KlonsMData";
            bsPVNRate.Sort = "CODE";
            // 
            // dgcIsService
            // 
            dgcIsService.DataPropertyName = "ISSERVICE";
            dgcIsService.FalseValue = "0";
            dgcIsService.HeaderText = "pakalp.";
            dgcIsService.MinimumWidth = 8;
            dgcIsService.Name = "dgcIsService";
            dgcIsService.ReadOnly = true;
            dgcIsService.TrueValue = "1";
            dgcIsService.Width = 70;
            // 
            // dgcIsProduced
            // 
            dgcIsProduced.DataPropertyName = "ISPRODUCED";
            dgcIsProduced.FalseValue = "0";
            dgcIsProduced.HeaderText = "ražots";
            dgcIsProduced.MinimumWidth = 8;
            dgcIsProduced.Name = "dgcIsProduced";
            dgcIsProduced.ReadOnly = true;
            dgcIsProduced.TrueValue = "1";
            dgcIsProduced.Width = 60;
            // 
            // dgcUints
            // 
            dgcUints.DataPropertyName = "UNITS";
            dgcUints.DataSource = bsUnits;
            dgcUints.DisplayMember = "CODE";
            dgcUints.HeaderText = "mērv.";
            dgcUints.MinimumWidth = 8;
            dgcUints.Name = "dgcUints";
            dgcUints.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcUints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcUints.ValueMember = "ID";
            dgcUints.Width = 80;
            // 
            // bsUnits
            // 
            bsUnits.DataMember = "M_UNITS";
            bsUnits.MyDataSource = "KlonsMData";
            bsUnits.Sort = "ID";
            // 
            // dgcSellPrice
            // 
            dgcSellPrice.DataPropertyName = "SELLPRICE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N4";
            dgcSellPrice.DefaultCellStyle = dataGridViewCellStyle1;
            dgcSellPrice.HeaderText = "cena";
            dgcSellPrice.MinimumWidth = 8;
            dgcSellPrice.Name = "dgcSellPrice";
            dgcSellPrice.Width = 90;
            // 
            // dgcAmountInStore
            // 
            dgcAmountInStore.DataPropertyName = "AMOUNTINSTORE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dgcAmountInStore.DefaultCellStyle = dataGridViewCellStyle2;
            dgcAmountInStore.HeaderText = "daudzums";
            dgcAmountInStore.MinimumWidth = 8;
            dgcAmountInStore.Name = "dgcAmountInStore";
            dgcAmountInStore.Width = 90;
            // 
            // dgcBBuyPrice
            // 
            dgcBBuyPrice.DataPropertyName = "BUYPRICE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N4";
            dgcBBuyPrice.DefaultCellStyle = dataGridViewCellStyle3;
            dgcBBuyPrice.HeaderText = "iep. cena";
            dgcBBuyPrice.MinimumWidth = 8;
            dgcBBuyPrice.Name = "dgcBBuyPrice";
            dgcBBuyPrice.Width = 90;
            // 
            // dgcLastBuyPrice
            // 
            dgcLastBuyPrice.DataPropertyName = "LASTBUYPRICE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N4";
            dgcLastBuyPrice.DefaultCellStyle = dataGridViewCellStyle4;
            dgcLastBuyPrice.HeaderText = "pēdējā iep. cena";
            dgcLastBuyPrice.MinimumWidth = 8;
            dgcLastBuyPrice.Name = "dgcLastBuyPrice";
            dgcLastBuyPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcLastBuyPrice.Width = 90;
            // 
            // dgcProdCosts
            // 
            dgcProdCosts.DataPropertyName = "PRODCOST";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N4";
            dgcProdCosts.DefaultCellStyle = dataGridViewCellStyle5;
            dgcProdCosts.HeaderText = "raž. izm.";
            dgcProdCosts.MinimumWidth = 8;
            dgcProdCosts.Name = "dgcProdCosts";
            dgcProdCosts.Width = 90;
            // 
            // dgcLastSaleDate
            // 
            dgcLastSaleDate.DataPropertyName = "LASTSALEDATE";
            dataGridViewCellStyle6.Format = "dd.MM.yyyy";
            dgcLastSaleDate.DefaultCellStyle = dataGridViewCellStyle6;
            dgcLastSaleDate.HeaderText = "datums2";
            dgcLastSaleDate.MinimumWidth = 8;
            dgcLastSaleDate.Name = "dgcLastSaleDate";
            dgcLastSaleDate.Width = 85;
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
            tsbFind.KeyDown += tsbFind_KeyDown;
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbItemsCatFilter);
            panel1.Controls.Add(tbFilter);
            panel1.Controls.Add(tbCode);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1199, 30);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(478, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 17);
            label2.TabIndex = 4;
            label2.Text = "atlasīt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(183, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 17);
            label1.TabIndex = 3;
            label1.Text = "kategorija:";
            // 
            // tbItemsCatFilter
            // 
            tbItemsCatFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbItemsCatFilter.DataMember = null;
            tbItemsCatFilter.DataSource = bsItemsCatFilter;
            tbItemsCatFilter.DisplayMember = "CODE";
            tbItemsCatFilter.Location = new System.Drawing.Point(263, 3);
            tbItemsCatFilter.Name = "tbItemsCatFilter";
            tbItemsCatFilter.SelectedIndex = -1;
            tbItemsCatFilter.ShowButton = true;
            tbItemsCatFilter.Size = new System.Drawing.Size(191, 23);
            tbItemsCatFilter.SyncPosition = false;
            tbItemsCatFilter.TabIndex = 1;
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
            tbFilter.Location = new System.Drawing.Point(533, 3);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new System.Drawing.Size(185, 23);
            tbFilter.TabIndex = 2;
            tbFilter.KeyDown += tbFilter_KeyDown;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // tbCode
            // 
            tbCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbCode.DataMember = null;
            tbCode.DataSource = bsItems;
            tbCode.DisplayMember = "BARCODE";
            tbCode.Location = new System.Drawing.Point(2, 3);
            tbCode.Name = "tbCode";
            tbCode.SelectedIndex = -1;
            tbCode.Size = new System.Drawing.Size(158, 23);
            tbCode.TabIndex = 0;
            tbCode.ValueMember = "ID";
            tbCode.RowSelectedEvent += tbCode_RowSelectedEvent;
            tbCode.Enter += tbCode_Enter;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_ITEMS",
    "M_ITEMS_CAT",
    null
    };
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miArtikuliTools });
            menuStrip1.Location = new System.Drawing.Point(917, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(70, 25);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // miArtikuliTools
            // 
            miArtikuliTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miAktuālieArtikulaAtlikumi, toolStripSeparator1, miImportētCenuLapu, miImportētPašizmaksasDatus, toolStripSeparator2, miReloadFromDB });
            miArtikuliTools.Name = "miArtikuliTools";
            miArtikuliTools.Size = new System.Drawing.Size(62, 21);
            miArtikuliTools.Text = "Artikuli";
            // 
            // miAktuālieArtikulaAtlikumi
            // 
            miAktuālieArtikulaAtlikumi.Name = "miAktuālieArtikulaAtlikumi";
            miAktuālieArtikulaAtlikumi.Size = new System.Drawing.Size(330, 22);
            miAktuālieArtikulaAtlikumi.Text = "Aktuālie artikula atlikumi";
            miAktuālieArtikulaAtlikumi.Click += miAktuālieArtikulaAtlikumi_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(327, 6);
            // 
            // miImportētCenuLapu
            // 
            miImportētCenuLapu.Name = "miImportētCenuLapu";
            miImportētCenuLapu.Size = new System.Drawing.Size(330, 22);
            miImportētCenuLapu.Text = "Importēt cenu lapu";
            miImportētCenuLapu.Click += miImportētCenuLapu_Click;
            // 
            // miImportētPašizmaksasDatus
            // 
            miImportētPašizmaksasDatus.Name = "miImportētPašizmaksasDatus";
            miImportētPašizmaksasDatus.Size = new System.Drawing.Size(330, 22);
            miImportētPašizmaksasDatus.Text = "Importēt pašizmaksas datus";
            miImportētPašizmaksasDatus.Click += miImportētPašizmaksasDatus_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(327, 6);
            // 
            // miReloadFromDB
            // 
            miReloadFromDB.Name = "miReloadFromDB";
            miReloadFromDB.Size = new System.Drawing.Size(330, 22);
            miReloadFromDB.Text = "Atjaunot artikulu sarakstu no datu bāzes";
            miReloadFromDB.Click += miReloadFromDB_Click;
            // 
            // FormM_Items
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1199, 450);
            Controls.Add(menuStrip1);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Controls.Add(bNav);
            MainMenuStrip = menuStrip1;
            Name = "FormM_Items";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Artikuli";
            FormClosed += FormM_Items_FormClosed;
            Load += FormM_Items_Load;
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItemsCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStore).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItemsCatFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private KlonsLIB.Components.MyTextBox tbFilter;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsItemsCat;
        private KlonsLIB.Data.MyBindingSource bsStore;
        private KlonsLIB.Data.MyBindingSource bsPVNRate;
        private KlonsLIB.Data.MyBindingSource bsItemsCatFilter;
        private KlonsLIB.Components.MyPickRowTextBox2 tbItemsCatFilter;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Data.MyBindingSource bsUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miArtikuliTools;
        private System.Windows.Forms.ToolStripMenuItem miAktuālieArtikulaAtlikumi;
        private System.Windows.Forms.ToolStripMenuItem miImportētCenuLapu;
        private System.Windows.Forms.ToolStripMenuItem miImportētPašizmaksasDatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcCat;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcStore1;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPVNRate;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsService;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcIsProduced;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcUints;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAmountInStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLastBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcProdCosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLastSaleDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miReloadFromDB;
    }
}