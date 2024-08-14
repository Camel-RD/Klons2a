
namespace KlonsM.FormsM
{
    partial class FormM_Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_Stores));
            bsStores = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTP = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStoreType = new KlonsLIB.Data.MyBindingSource(components);
            dgcIdCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStoresCat = new KlonsLIB.Data.MyBindingSource(components);
            dgcRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPVNRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPVNTp = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsPVNType = new KlonsLIB.Data.MyBindingSource(components);
            dgcAcc21 = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsAccounts21 = new KlonsLIB.Data.MyBindingSource(components);
            dgcAcc23 = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsAccounts23 = new KlonsLIB.Data.MyBindingSource(components);
            dgcAcc53 = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsAccounts53 = new KlonsLIB.Data.MyBindingSource(components);
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
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
            bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            cbType = new KlonsLIB.Components.MyPickRowTextBox2();
            bsStoreTypeFilter = new KlonsLIB.Data.MyBindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbFilter = new KlonsLIB.Components.MyTextBox();
            tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btAtlikumi = new System.Windows.Forms.ToolStripButton();
            btAddresses = new System.Windows.Forms.ToolStripButton();
            btContacts = new System.Windows.Forms.ToolStripButton();
            btBankAccounts = new System.Windows.Forms.ToolStripButton();
            btVehicles = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bsStores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoresCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts53).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsStoreTypeFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bsStores
            // 
            bsStores.DataMember = "M_STORES";
            bsStores.MyDataSource = "KlonsMData";
            bsStores.Sort = "CODE";
            bsStores.UseDataGridView = dgvRows;
            bsStores.ListChanged += bsStores_ListChanged;
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcName, dgcTP, dgcIdCat, dgcRegNr, dgcPVNRegNr, dgcAddr, dgcPVNTp, dgcAcc21, dgcAcc23, dgcAcc53, dgcID });
            dgvRows.DataSource = bsStores;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 30);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1149, 364);
            dgvRows.TabIndex = 1;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.DefaultValuesNeeded += dgvRows_DefaultValuesNeeded;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyPress += dgvRows_KeyPress;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "CODE";
            dgcCode.Frozen = true;
            dgcCode.HeaderText = "kods";
            dgcCode.MinimumWidth = 8;
            dgcCode.Name = "dgcCode";
            dgcCode.Width = 140;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "NAME";
            dgcName.Frozen = true;
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.Width = 250;
            // 
            // dgcTP
            // 
            dgcTP.DataPropertyName = "TP";
            dgcTP.DataSource = bsStoreType;
            dgcTP.DisplayMember = "NAME";
            dgcTP.HeaderText = "veids";
            dgcTP.MinimumWidth = 8;
            dgcTP.Name = "dgcTP";
            dgcTP.ValueMember = "ID";
            dgcTP.Width = 140;
            // 
            // bsStoreType
            // 
            bsStoreType.DataMember = "M_STORETYPE";
            bsStoreType.MyDataSource = "KlonsMData";
            // 
            // dgcIdCat
            // 
            dgcIdCat.DataPropertyName = "IDCAT";
            dgcIdCat.DataSource = bsStoresCat;
            dgcIdCat.DisplayMember = "CODE";
            dgcIdCat.HeaderText = "kategorija";
            dgcIdCat.MinimumWidth = 8;
            dgcIdCat.Name = "dgcIdCat";
            dgcIdCat.ValueMember = "ID";
            dgcIdCat.Width = 160;
            // 
            // bsStoresCat
            // 
            bsStoresCat.DataMember = "M_STORES_CAT";
            bsStoresCat.MyDataSource = "KlonsMData";
            bsStoresCat.Sort = "CODE";
            // 
            // dgcRegNr
            // 
            dgcRegNr.DataPropertyName = "REGNR";
            dgcRegNr.HeaderText = "reģ.nr.";
            dgcRegNr.MinimumWidth = 8;
            dgcRegNr.Name = "dgcRegNr";
            dgcRegNr.Width = 130;
            // 
            // dgcPVNRegNr
            // 
            dgcPVNRegNr.DataPropertyName = "PVNREGNR";
            dgcPVNRegNr.HeaderText = "PVN reģ.nr.";
            dgcPVNRegNr.MinimumWidth = 8;
            dgcPVNRegNr.Name = "dgcPVNRegNr";
            dgcPVNRegNr.Width = 130;
            // 
            // dgcAddr
            // 
            dgcAddr.DataPropertyName = "ADDR";
            dgcAddr.HeaderText = "adrese";
            dgcAddr.MinimumWidth = 8;
            dgcAddr.Name = "dgcAddr";
            dgcAddr.Width = 180;
            // 
            // dgcPVNTp
            // 
            dgcPVNTp.DataPropertyName = "PVNTP";
            dgcPVNTp.DataSource = bsPVNType;
            dgcPVNTp.DisplayMember = "CODE";
            dgcPVNTp.HeaderText = "PVN veids";
            dgcPVNTp.MinimumWidth = 8;
            dgcPVNTp.Name = "dgcPVNTp";
            dgcPVNTp.ValueMember = "ID";
            dgcPVNTp.Width = 120;
            // 
            // bsPVNType
            // 
            bsPVNType.DataMember = "M_PVNTYPE";
            bsPVNType.MyDataSource = "KlonsMData";
            bsPVNType.Sort = "ID";
            // 
            // dgcAcc21
            // 
            dgcAcc21.DataPropertyName = "ACC21";
            dgcAcc21.DataSource = bsAccounts21;
            dgcAcc21.DisplayMember = "ID";
            dgcAcc21.HeaderText = "konts 21";
            dgcAcc21.MinimumWidth = 8;
            dgcAcc21.Name = "dgcAcc21";
            dgcAcc21.ValueMember = "ID";
            dgcAcc21.Width = 80;
            // 
            // bsAccounts21
            // 
            bsAccounts21.DataMember = "M_ACCOUNTS";
            bsAccounts21.Filter = "TP=2 OR TP=1";
            bsAccounts21.MyDataSource = "KlonsMData";
            bsAccounts21.Sort = "ID";
            // 
            // dgcAcc23
            // 
            dgcAcc23.DataPropertyName = "ACC23";
            dgcAcc23.DataSource = bsAccounts23;
            dgcAcc23.DisplayMember = "ID";
            dgcAcc23.HeaderText = "konts 23";
            dgcAcc23.MinimumWidth = 8;
            dgcAcc23.Name = "dgcAcc23";
            dgcAcc23.ValueMember = "ID";
            dgcAcc23.Width = 80;
            // 
            // bsAccounts23
            // 
            bsAccounts23.DataMember = "M_ACCOUNTS";
            bsAccounts23.Filter = "TP=5 OR TP=1";
            bsAccounts23.MyDataSource = "KlonsMData";
            bsAccounts23.Sort = "ID";
            // 
            // dgcAcc53
            // 
            dgcAcc53.DataPropertyName = "ACC53";
            dgcAcc53.DataSource = bsAccounts53;
            dgcAcc53.DisplayMember = "ID";
            dgcAcc53.HeaderText = "konts 53";
            dgcAcc53.MinimumWidth = 8;
            dgcAcc53.Name = "dgcAcc53";
            dgcAcc53.ValueMember = "ID";
            dgcAcc53.Width = 80;
            // 
            // bsAccounts53
            // 
            bsAccounts53.DataMember = "M_ACCOUNTS";
            bsAccounts53.Filter = "TP=6 OR TP=1";
            bsAccounts53.MyDataSource = "KlonsMData";
            bsAccounts53.Sort = "ID";
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
            // bNav
            // 
            bNav.AddNewItem = bindingNavigatorAddNewItem;
            bNav.BindingSource = bsStores;
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
            bNav.Size = new System.Drawing.Size(1149, 31);
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
            panel1.Controls.Add(cbType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbFilter);
            panel1.Controls.Add(tbCode);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1149, 30);
            panel1.TabIndex = 0;
            // 
            // cbType
            // 
            cbType.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbType.DataMember = null;
            cbType.DataSource = bsStoreTypeFilter;
            cbType.DisplayMember = "NAME";
            cbType.Location = new System.Drawing.Point(227, 3);
            cbType.Name = "cbType";
            cbType.SelectedIndex = -1;
            cbType.ShowButton = true;
            cbType.Size = new System.Drawing.Size(198, 23);
            cbType.TabIndex = 5;
            cbType.ValueMember = "ID";
            cbType.ButtonClicked += cbType_ButtonClicked;
            cbType.KeyDown += cbType_KeyDown;
            // 
            // bsStoreTypeFilter
            // 
            bsStoreTypeFilter.DataMember = "M_STORETYPE";
            bsStoreTypeFilter.MyDataSource = "KlonsMData";
            bsStoreTypeFilter.Sort = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(456, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 17);
            label2.TabIndex = 4;
            label2.Text = "atlasīt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(176, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 17);
            label1.TabIndex = 3;
            label1.Text = "veids:";
            // 
            // tbFilter
            // 
            tbFilter.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbFilter.Location = new System.Drawing.Point(511, 3);
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
            tbCode.DataSource = bsStores;
            tbCode.DisplayMember = "CODE";
            tbCode.Location = new System.Drawing.Point(3, 3);
            tbCode.Name = "tbCode";
            tbCode.SelectedIndex = -1;
            tbCode.Size = new System.Drawing.Size(146, 23);
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
    "M_STORES",
    "M_ROWS",
    "M_DOCS",
    "M_ITEMS",
    null
    };
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btAtlikumi, btAddresses, btContacts, btBankAccounts, btVehicles });
            toolStrip1.Location = new System.Drawing.Point(0, 394);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1149, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // btAtlikumi
            // 
            btAtlikumi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btAtlikumi.Image = (System.Drawing.Image)resources.GetObject("btAtlikumi.Image");
            btAtlikumi.ImageTransparentColor = System.Drawing.Color.Magenta;
            btAtlikumi.Name = "btAtlikumi";
            btAtlikumi.Size = new System.Drawing.Size(113, 22);
            btAtlikumi.Text = "Aktuālie atlikumi";
            btAtlikumi.Click += btAtlikumi_Click;
            // 
            // btAddresses
            // 
            btAddresses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btAddresses.Image = (System.Drawing.Image)resources.GetObject("btAddresses.Image");
            btAddresses.ImageTransparentColor = System.Drawing.Color.Magenta;
            btAddresses.Name = "btAddresses";
            btAddresses.Size = new System.Drawing.Size(79, 22);
            btAddresses.Text = "❏ Adreses";
            btAddresses.Click += btAddresses_Click;
            // 
            // btContacts
            // 
            btContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btContacts.Image = (System.Drawing.Image)resources.GetObject("btContacts.Image");
            btContacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            btContacts.Name = "btContacts";
            btContacts.Size = new System.Drawing.Size(78, 22);
            btContacts.Text = "❏ Kontakti";
            btContacts.Click += btContacts_Click;
            // 
            // btBankAccounts
            // 
            btBankAccounts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btBankAccounts.Image = (System.Drawing.Image)resources.GetObject("btBankAccounts.Image");
            btBankAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            btBankAccounts.Name = "btBankAccounts";
            btBankAccounts.Size = new System.Drawing.Size(59, 22);
            btBankAccounts.Text = "❏ Konti";
            btBankAccounts.Click += btBankAccounts_Click;
            // 
            // btVehicles
            // 
            btVehicles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btVehicles.Image = (System.Drawing.Image)resources.GetObject("btVehicles.Image");
            btVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            btVehicles.Name = "btVehicles";
            btVehicles.Size = new System.Drawing.Size(96, 22);
            btVehicles.Text = "❏ Transports";
            btVehicles.Click += btVehicles_Click;
            // 
            // FormM_Stores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1149, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(bNav);
            Name = "FormM_Stores";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Noliktavas un partneri";
            Load += FormM_Stores_Load;
            ((System.ComponentModel.ISupportInitialize)bsStores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoresCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts21).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts23).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts53).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsStoreTypeFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsStores;
        private KlonsLIB.Data.MyBindingSource bsStoreType;
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
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsStoreTypeFilter;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Data.MyBindingSource bsAccounts21;
        private KlonsLIB.Components.MyTextBox tbFilter;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private KlonsLIB.Data.MyBindingSource bsPVNType;
        private KlonsLIB.Data.MyBindingSource bsAccounts23;
        private KlonsLIB.Data.MyBindingSource bsAccounts53;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btAtlikumi;
        private System.Windows.Forms.ToolStripButton btAddresses;
        private System.Windows.Forms.ToolStripButton btContacts;
        private System.Windows.Forms.ToolStripButton btBankAccounts;
        private System.Windows.Forms.ToolStripButton btVehicles;
        private KlonsLIB.Components.MyPickRowTextBox2 cbType;
        private KlonsLIB.Data.MyBindingSource bsStoresCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcTP;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcIdCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVNRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAddr;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPVNTp;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcAcc21;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcAcc23;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcAcc53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}