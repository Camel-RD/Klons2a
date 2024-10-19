
namespace KlonsM.FormsM
{
    partial class FormM_InvDocList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_InvDocList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            bsDocs = new KlonsLIB.Data.MyBindingSource(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvDocs = new KlonsLIB.Components.MyDataGridView();
            dgcDocsDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsIdStore = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStore = new KlonsLIB.Data.MyBindingSource(components);
            dgcDocsState = new KlonsLIB.Components.DataGridViewColorMarkColumn();
            dgcDocsPersons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbOpenDoc = new System.Windows.Forms.ToolStripButton();
            bniAdd = new System.Windows.Forms.ToolStripButton();
            bniDelete = new System.Windows.Forms.ToolStripButton();
            bniSave = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            dgvFilter = new KlonsLIB.Components.MyDataGridView();
            bsDocFilter = new KlonsLIB.Data.MyBindingSourceToObj(components);
            docFilterData1 = new DataObjectsFM.DocFilterData();
            btFilter = new System.Windows.Forms.Button();
            myConfigA1 = new MyConfigA();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            dgcFilterDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilterDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilterState = new KlonsLIB.Components.MyDgvMcCBColumn();
            dgcFilterIdStore = new KlonsLIB.Components.MyDgvTextboxColumn2();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStore).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "M_INV_DOCS";
            bsDocs.MyDataSource = "KlonsMData";
            bsDocs.ListChanged += bsDocs_ListChanged;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_INV_DOCS",
    "M_INV_ROWS",
    null
    };
            // 
            // bNav
            // 
            bNav.AddNewItem = null;
            bNav.BindingSource = bsDocs;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvDocs;
            bNav.DeleteItem = null;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tsbOpenDoc, bniAdd, bniDelete, bniSave, tsbFindPrev, tsbFind, tsbFindNext });
            bNav.Location = new System.Drawing.Point(0, 413);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = null;
            bNav.Size = new System.Drawing.Size(1020, 37);
            bNav.TabIndex = 1;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 34);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // dgvDocs
            // 
            dgvDocs.AllowUserToAddRows = false;
            dgvDocs.AutoGenerateColumns = false;
            dgvDocs.AutoSave = false;
            dgvDocs.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocsDT, dgcDocsNr, dgcDocsIdStore, dgcDocsState, dgcDocsPersons, dgcDocsID });
            dgvDocs.DataSource = bsDocs;
            dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocs.Location = new System.Drawing.Point(0, 61);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.ReadOnly = true;
            dgvDocs.RowHeadersWidth = 62;
            dgvDocs.ShowCellToolTips = false;
            dgvDocs.Size = new System.Drawing.Size(1020, 352);
            dgvDocs.TabIndex = 0;
            dgvDocs.MyCheckForChanges += dgvDocs_MyCheckForChanges;
            dgvDocs.CellDoubleClick += dgvDocs_CellDoubleClick;
            dgvDocs.CellFormatting += dgvDocs_CellFormatting;
            dgvDocs.UserDeletingRow += dgvDocs_UserDeletingRow;
            // 
            // dgcDocsDT
            // 
            dgcDocsDT.DataPropertyName = "DT";
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dgcDocsDT.DefaultCellStyle = dataGridViewCellStyle4;
            dgcDocsDT.HeaderText = "datums";
            dgcDocsDT.MinimumWidth = 8;
            dgcDocsDT.Name = "dgcDocsDT";
            dgcDocsDT.ReadOnly = true;
            dgcDocsDT.Width = 85;
            // 
            // dgcDocsNr
            // 
            dgcDocsNr.DataPropertyName = "NR";
            dgcDocsNr.HeaderText = "mumurs";
            dgcDocsNr.MinimumWidth = 8;
            dgcDocsNr.Name = "dgcDocsNr";
            dgcDocsNr.ReadOnly = true;
            dgcDocsNr.Width = 90;
            // 
            // dgcDocsIdStore
            // 
            dgcDocsIdStore.DataPropertyName = "IDSTORE";
            dgcDocsIdStore.DataSource = bsStore;
            dgcDocsIdStore.DisplayMember = "CODE";
            dgcDocsIdStore.HeaderText = "noliktava";
            dgcDocsIdStore.MinimumWidth = 8;
            dgcDocsIdStore.Name = "dgcDocsIdStore";
            dgcDocsIdStore.ReadOnly = true;
            dgcDocsIdStore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsIdStore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsIdStore.ValueMember = "ID";
            dgcDocsIdStore.Width = 180;
            // 
            // bsStore
            // 
            bsStore.DataMember = "M_STORES";
            bsStore.MyDataSource = "KlonsMData";
            bsStore.Sort = "CODE";
            // 
            // dgcDocsState
            // 
            dgcDocsState.DataPropertyName = "STATE";
            dgcDocsState.HeaderText = "statuss";
            dgcDocsState.MinimumWidth = 8;
            dgcDocsState.Name = "dgcDocsState";
            dgcDocsState.ReadOnly = true;
            dgcDocsState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsState.Width = 160;
            // 
            // dgcDocsPersons
            // 
            dgcDocsPersons.DataPropertyName = "PERSONS";
            dgcDocsPersons.HeaderText = "darbinieki";
            dgcDocsPersons.MinimumWidth = 8;
            dgcDocsPersons.Name = "dgcDocsPersons";
            dgcDocsPersons.ReadOnly = true;
            dgcDocsPersons.Width = 300;
            // 
            // dgcDocsID
            // 
            dgcDocsID.DataPropertyName = "ID";
            dgcDocsID.HeaderText = "ID";
            dgcDocsID.MinimumWidth = 8;
            dgcDocsID.Name = "dgcDocsID";
            dgcDocsID.ReadOnly = true;
            dgcDocsID.Visible = false;
            dgcDocsID.Width = 150;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 34);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 34);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 37);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 34);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 34);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbOpenDoc
            // 
            tsbOpenDoc.Image = (System.Drawing.Image)resources.GetObject("tsbOpenDoc.Image");
            tsbOpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOpenDoc.Name = "tsbOpenDoc";
            tsbOpenDoc.Size = new System.Drawing.Size(75, 34);
            tsbOpenDoc.Text = "Atvērt";
            tsbOpenDoc.Click += tsbOpenDoc_Click;
            // 
            // bniAdd
            // 
            bniAdd.Image = (System.Drawing.Image)resources.GetObject("bniAdd.Image");
            bniAdd.Name = "bniAdd";
            bniAdd.RightToLeftAutoMirrorImage = true;
            bniAdd.Size = new System.Drawing.Size(71, 34);
            bniAdd.Text = "Jauns";
            bniAdd.Click += bniAdd_Click;
            // 
            // bniDelete
            // 
            bniDelete.Image = (System.Drawing.Image)resources.GetObject("bniDelete.Image");
            bniDelete.Name = "bniDelete";
            bniDelete.RightToLeftAutoMirrorImage = true;
            bniDelete.Size = new System.Drawing.Size(71, 34);
            bniDelete.Text = "Dzēst";
            // 
            // bniSave
            // 
            bniSave.Image = (System.Drawing.Image)resources.GetObject("bniSave.Image");
            bniSave.Name = "bniSave";
            bniSave.Size = new System.Drawing.Size(89, 34);
            bniSave.Text = "Saglabāt";
            bniSave.Click += bniSave_Click;
            // 
            // tsbFindPrev
            // 
            tsbFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFindPrev.Image = (System.Drawing.Image)resources.GetObject("tsbFindPrev.Image");
            tsbFindPrev.Name = "tsbFindPrev";
            tsbFindPrev.RightToLeftAutoMirrorImage = true;
            tsbFindPrev.Size = new System.Drawing.Size(28, 34);
            tsbFindPrev.Text = "Iet uz iepriekšējo";
            tsbFindPrev.Click += tsbFindPrev_Click;
            // 
            // tsbFind
            // 
            tsbFind.Name = "tsbFind";
            tsbFind.Size = new System.Drawing.Size(100, 37);
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
            tsbFindNext.Size = new System.Drawing.Size(28, 34);
            tsbFindNext.Text = "Iet uz nākošo";
            tsbFindNext.Click += tsbFindNext_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvFilter);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1020, 61);
            panel1.TabIndex = 4;
            // 
            // dgvFilter
            // 
            dgvFilter.AllowUserToAddRows = false;
            dgvFilter.AllowUserToDeleteRows = false;
            dgvFilter.AllowUserToResizeRows = false;
            dgvFilter.AutoGenerateColumns = false;
            dgvFilter.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFilterDt1, dgcFilterDt2, dgcFilterState, dgcFilterIdStore });
            dgvFilter.DataSource = bsDocFilter;
            dgvFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFilter.Location = new System.Drawing.Point(0, 0);
            dgvFilter.Name = "dgvFilter";
            dgvFilter.RowHeadersVisible = false;
            dgvFilter.RowHeadersWidth = 62;
            dgvFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgvFilter.ShowCellToolTips = false;
            dgvFilter.Size = new System.Drawing.Size(953, 61);
            dgvFilter.TabIndex = 0;
            dgvFilter.CellFormatting += dgvFilter_CellFormatting;
            dgvFilter.CellParsing += dgvFilter_CellParsing;
            // 
            // bsDocFilter
            // 
            bsDocFilter.MyDataSource = docFilterData1;
            bsDocFilter.Position = 0;
            // 
            // docFilterData1
            // 
            docFilterData1.DocState = null;
            docFilterData1.DocType = null;
            docFilterData1.Dt1 = null;
            docFilterData1.Dt2 = null;
            docFilterData1.IdStoreIn = null;
            docFilterData1.IdStoreOut = null;
            docFilterData1.IdStoreOutOrIn = null;
            // 
            // btFilter
            // 
            btFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            btFilter.Location = new System.Drawing.Point(3, 3);
            btFilter.Name = "btFilter";
            btFilter.Size = new System.Drawing.Size(61, 55);
            btFilter.TabIndex = 1;
            btFilter.Text = "Atlasīt";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // myConfigA1
            // 
            myConfigA1.DocStatusColor1 = System.Drawing.Color.LightYellow;
            myConfigA1.DocStatusColor2 = System.Drawing.Color.LightBlue;
            myConfigA1.DocStatusColor3 = System.Drawing.Color.LightGreen;
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // dgcFilterDt1
            // 
            dgcFilterDt1.DataPropertyName = "Dt1";
            dataGridViewCellStyle5.Format = "dd.MM.yyyy";
            dgcFilterDt1.DefaultCellStyle = dataGridViewCellStyle5;
            dgcFilterDt1.HeaderText = "datums no";
            dgcFilterDt1.MinimumWidth = 8;
            dgcFilterDt1.Name = "dgcFilterDt1";
            dgcFilterDt1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcFilterDt1.Width = 85;
            // 
            // dgcFilterDt2
            // 
            dgcFilterDt2.DataPropertyName = "Dt2";
            dataGridViewCellStyle6.Format = "dd.MM.yyyy";
            dgcFilterDt2.DefaultCellStyle = dataGridViewCellStyle6;
            dgcFilterDt2.HeaderText = "datums līdz";
            dgcFilterDt2.MinimumWidth = 8;
            dgcFilterDt2.Name = "dgcFilterDt2";
            dgcFilterDt2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcFilterDt2.Width = 85;
            // 
            // dgcFilterState
            // 
            dgcFilterState.DataPropertyName = "DocState";
            dgcFilterState.DisplayMember = null;
            dgcFilterState.HeaderText = "statuss";
            dgcFilterState.MaxDropDownItems = 15;
            dgcFilterState.MinimumWidth = 8;
            dgcFilterState.Name = "dgcFilterState";
            dgcFilterState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterState.ValueMember = null;
            dgcFilterState.Width = 160;
            // 
            // dgcFilterIdStore
            // 
            dgcFilterIdStore.DataPropertyName = "IdStoreIn";
            dgcFilterIdStore.DataSource = bsStore;
            dgcFilterIdStore.DisplayMember = "CODE";
            dgcFilterIdStore.HeaderText = "noliktava";
            dgcFilterIdStore.MinimumWidth = 8;
            dgcFilterIdStore.Name = "dgcFilterIdStore";
            dgcFilterIdStore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterIdStore.ValueMember = "ID";
            dgcFilterIdStore.Width = 180;
            // 
            // panel2
            // 
            panel2.Controls.Add(btFilter);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(953, 0);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(3);
            panel2.Size = new System.Drawing.Size(67, 61);
            panel2.TabIndex = 2;
            // 
            // FormM_InvDocList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1020, 450);
            Controls.Add(dgvDocs);
            Controls.Add(panel1);
            Controls.Add(bNav);
            Name = "FormM_InvDocList";
            Text = "Invemtarizācijas dokumentu saraksts";
            Load += FormM_InvDocList_Load;
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStore).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsDocs;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bniAdd;
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
        private KlonsLIB.Components.MyDataGridView dgvDocs;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvFilter;
        private System.Windows.Forms.Button btFilter;
        private DataObjectsFM.DocFilterData docFilterData1;
        private MyConfigA myConfigA1;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private KlonsLIB.Data.MyBindingSource bsStore;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private System.Windows.Forms.ToolStripButton tsbOpenDoc;
        private KlonsLIB.Data.MyBindingSourceToObj bsDocFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsNr;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcDocsIdStore;
        private KlonsLIB.Components.DataGridViewColorMarkColumn dgcDocsState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationSettingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilterDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilterDt2;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcFilterState;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcFilterIdStore;
        private System.Windows.Forms.Panel panel2;
    }
}