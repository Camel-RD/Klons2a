
namespace KlonsM.FormsM
{
    partial class FormM_DocList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_DocList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bsDocs = new KlonsLIB.Data.MyBindingSource(components);
            dgvDocs = new KlonsLIB.Components.MyDataGridView();
            dgcDocsDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsPVNType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsState = new KlonsLIB.Components.DataGridViewColorMarkColumn();
            dgcDocsIdStoreOut = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStoreOut = new KlonsLIB.Data.MyBindingSource(components);
            dgcDocsIdStoreIn = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsStoreIn = new KlonsLIB.Data.MyBindingSource(components);
            dgcDocsSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsCredDocDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsCredDocSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsCredDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsIdSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbOpenDoc = new System.Windows.Forms.ToolStripButton();
            bniNew = new System.Windows.Forms.ToolStripButton();
            bniSave = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            bsDocType = new KlonsLIB.Data.MyBindingSource(components);
            bsPVNType = new KlonsLIB.Data.MyBindingSource(components);
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            bsUnits = new KlonsLIB.Data.MyBindingSource(components);
            myConfigA1 = new MyConfigA();
            panel1 = new System.Windows.Forms.Panel();
            dgvFilter = new KlonsLIB.Components.MyDataGridView();
            dgcFilterDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilterDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFilterDocType = new KlonsLIB.Components.MyDgvMcCBColumn();
            dgcFilterDocState = new KlonsLIB.Components.MyDgvMcCBColumn();
            dgcFilterIdStoreOut = new KlonsLIB.Components.MyDgvTextboxColumn2();
            dgcFilterIdStoreIn = new KlonsLIB.Components.MyDgvTextboxColumn2();
            dgcFilterIdStoreOutOrIn = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsDocFilter = new KlonsLIB.Data.MyBindingSourceToObj(components);
            docFilterData1 = new DataObjectsFM.DocFilterData();
            btFilter = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocFilter).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tsbOpenDoc, bniNew, bniSave, tsbFindPrev, tsbFind, tsbFindNext });
            bNav.Location = new System.Drawing.Point(0, 309);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bniSave;
            bNav.Size = new System.Drawing.Size(1038, 31);
            bNav.TabIndex = 2;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "M_DOCS";
            bsDocs.MyDataSource = "KlonsMData";
            bsDocs.Sort = "DT,IDSEQ";
            bsDocs.UseDataGridView = dgvDocs;
            bsDocs.ListChanged += bsDocs_ListChanged;
            // 
            // dgvDocs
            // 
            dgvDocs.AllowUserToAddRows = false;
            dgvDocs.AllowUserToDeleteRows = false;
            dgvDocs.AutoGenerateColumns = false;
            dgvDocs.AutoSave = false;
            dgvDocs.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocsDT, dgcDocsSR, dgcDocsNr, dgcDocsTP, dgcDocsPVNType, dgcDocsState, dgcDocsIdStoreOut, dgcDocsIdStoreIn, dgcDocsSumm, dgcDocsCredDocDt, dgcDocsCredDocSr, dgcDocsCredDocNr, dgcDocsId, dgcDocsIdSeq });
            dgvDocs.DataSource = bsDocs;
            dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocs.Location = new System.Drawing.Point(0, 63);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.ReadOnly = true;
            dgvDocs.RowHeadersWidth = 30;
            dgvDocs.ShowCellToolTips = false;
            dgvDocs.Size = new System.Drawing.Size(1038, 246);
            dgvDocs.TabIndex = 4;
            dgvDocs.MyCheckForChanges += dgvDocs_MyCheckForChanges;
            dgvDocs.CellDoubleClick += dgvDocs_CellDoubleClick;
            dgvDocs.CellFormatting += dgvDocs_CellFormatting;
            dgvDocs.UserDeletingRow += dgvDocs_UserDeletingRow;
            // 
            // dgcDocsDT
            // 
            dgcDocsDT.DataPropertyName = "DT";
            dataGridViewCellStyle6.Format = "dd.MM.yyyy";
            dgcDocsDT.DefaultCellStyle = dataGridViewCellStyle6;
            dgcDocsDT.HeaderText = "datums";
            dgcDocsDT.MinimumWidth = 8;
            dgcDocsDT.Name = "dgcDocsDT";
            dgcDocsDT.ReadOnly = true;
            dgcDocsDT.Width = 85;
            // 
            // dgcDocsSR
            // 
            dgcDocsSR.DataPropertyName = "SR";
            dgcDocsSR.HeaderText = "sr.";
            dgcDocsSR.MinimumWidth = 8;
            dgcDocsSR.Name = "dgcDocsSR";
            dgcDocsSR.ReadOnly = true;
            dgcDocsSR.Width = 55;
            // 
            // dgcDocsNr
            // 
            dgcDocsNr.DataPropertyName = "NR";
            dgcDocsNr.HeaderText = "numurs";
            dgcDocsNr.MinimumWidth = 8;
            dgcDocsNr.Name = "dgcDocsNr";
            dgcDocsNr.ReadOnly = true;
            dgcDocsNr.Width = 90;
            // 
            // dgcDocsTP
            // 
            dgcDocsTP.DataPropertyName = "TP";
            dgcDocsTP.HeaderText = "veids";
            dgcDocsTP.MinimumWidth = 8;
            dgcDocsTP.Name = "dgcDocsTP";
            dgcDocsTP.ReadOnly = true;
            dgcDocsTP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsTP.Width = 160;
            // 
            // dgcDocsPVNType
            // 
            dgcDocsPVNType.DataPropertyName = "PVNTYPE";
            dgcDocsPVNType.HeaderText = "PVN id";
            dgcDocsPVNType.MinimumWidth = 8;
            dgcDocsPVNType.Name = "dgcDocsPVNType";
            dgcDocsPVNType.ReadOnly = true;
            dgcDocsPVNType.Width = 95;
            // 
            // dgcDocsState
            // 
            dgcDocsState.DataPropertyName = "STATE";
            dgcDocsState.HeaderText = "statuss";
            dgcDocsState.MinimumWidth = 8;
            dgcDocsState.Name = "dgcDocsState";
            dgcDocsState.ReadOnly = true;
            dgcDocsState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsState.Width = 110;
            // 
            // dgcDocsIdStoreOut
            // 
            dgcDocsIdStoreOut.DataPropertyName = "IDSTOREOUT";
            dgcDocsIdStoreOut.DataSource = bsStoreOut;
            dgcDocsIdStoreOut.DisplayMember = "CODE";
            dgcDocsIdStoreOut.HeaderText = "izsniedzējs";
            dgcDocsIdStoreOut.MinimumWidth = 8;
            dgcDocsIdStoreOut.Name = "dgcDocsIdStoreOut";
            dgcDocsIdStoreOut.ReadOnly = true;
            dgcDocsIdStoreOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsIdStoreOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsIdStoreOut.ValueMember = "ID";
            dgcDocsIdStoreOut.Width = 160;
            // 
            // bsStoreOut
            // 
            bsStoreOut.DataMember = "M_STORES";
            bsStoreOut.MyDataSource = "KlonsMData";
            bsStoreOut.Sort = "CODE";
            // 
            // dgcDocsIdStoreIn
            // 
            dgcDocsIdStoreIn.DataPropertyName = "IDSTOREIN";
            dgcDocsIdStoreIn.DataSource = bsStoreIn;
            dgcDocsIdStoreIn.DisplayMember = "CODE";
            dgcDocsIdStoreIn.HeaderText = "saņēmējs";
            dgcDocsIdStoreIn.MinimumWidth = 8;
            dgcDocsIdStoreIn.Name = "dgcDocsIdStoreIn";
            dgcDocsIdStoreIn.ReadOnly = true;
            dgcDocsIdStoreIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsIdStoreIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsIdStoreIn.ValueMember = "ID";
            dgcDocsIdStoreIn.Width = 160;
            // 
            // bsStoreIn
            // 
            bsStoreIn.DataMember = "M_STORES";
            bsStoreIn.MyDataSource = "KlonsMData";
            bsStoreIn.Sort = "CODE";
            // 
            // dgcDocsSumm
            // 
            dgcDocsSumm.DataPropertyName = "SUMM";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dgcDocsSumm.DefaultCellStyle = dataGridViewCellStyle7;
            dgcDocsSumm.HeaderText = "summa";
            dgcDocsSumm.MinimumWidth = 8;
            dgcDocsSumm.Name = "dgcDocsSumm";
            dgcDocsSumm.ReadOnly = true;
            dgcDocsSumm.Width = 90;
            // 
            // dgcDocsCredDocDt
            // 
            dgcDocsCredDocDt.DataPropertyName = "CREDDOCDT";
            dataGridViewCellStyle8.Format = "dd.MM.yyyy";
            dgcDocsCredDocDt.DefaultCellStyle = dataGridViewCellStyle8;
            dgcDocsCredDocDt.HeaderText = "kd. dat.";
            dgcDocsCredDocDt.MinimumWidth = 8;
            dgcDocsCredDocDt.Name = "dgcDocsCredDocDt";
            dgcDocsCredDocDt.ReadOnly = true;
            dgcDocsCredDocDt.Width = 85;
            // 
            // dgcDocsCredDocSr
            // 
            dgcDocsCredDocSr.DataPropertyName = "CREDDOCSR";
            dgcDocsCredDocSr.HeaderText = "kd.sr.";
            dgcDocsCredDocSr.MinimumWidth = 8;
            dgcDocsCredDocSr.Name = "dgcDocsCredDocSr";
            dgcDocsCredDocSr.ReadOnly = true;
            dgcDocsCredDocSr.Width = 55;
            // 
            // dgcDocsCredDocNr
            // 
            dgcDocsCredDocNr.DataPropertyName = "CREDDOCNR";
            dgcDocsCredDocNr.HeaderText = "kd. nr.";
            dgcDocsCredDocNr.MinimumWidth = 8;
            dgcDocsCredDocNr.Name = "dgcDocsCredDocNr";
            dgcDocsCredDocNr.ReadOnly = true;
            dgcDocsCredDocNr.Width = 90;
            // 
            // dgcDocsId
            // 
            dgcDocsId.DataPropertyName = "ID";
            dgcDocsId.HeaderText = "ID";
            dgcDocsId.MinimumWidth = 8;
            dgcDocsId.Name = "dgcDocsId";
            dgcDocsId.ReadOnly = true;
            dgcDocsId.Visible = false;
            dgcDocsId.Width = 50;
            // 
            // dgcDocsIdSeq
            // 
            dgcDocsIdSeq.DataPropertyName = "IDSEQ";
            dgcDocsIdSeq.HeaderText = "IDSEQ";
            dgcDocsIdSeq.MinimumWidth = 8;
            dgcDocsIdSeq.Name = "dgcDocsIdSeq";
            dgcDocsIdSeq.ReadOnly = true;
            dgcDocsIdSeq.Visible = false;
            dgcDocsIdSeq.Width = 80;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 28);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            // tsbOpenDoc
            // 
            tsbOpenDoc.Image = (System.Drawing.Image)resources.GetObject("tsbOpenDoc.Image");
            tsbOpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOpenDoc.Name = "tsbOpenDoc";
            tsbOpenDoc.Size = new System.Drawing.Size(73, 28);
            tsbOpenDoc.Text = "Atvērt";
            tsbOpenDoc.Click += tsbOpenDoc_Click;
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
            tsbFind.KeyPress += tsbFind_KeyPress_1;
            tsbFind.Click += tsbFind_Enter;
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
            // bsDocType
            // 
            bsDocType.DataMember = "M_DOCTYPES";
            bsDocType.MyDataSource = "KlonsMData";
            bsDocType.Sort = "ID";
            // 
            // bsPVNType
            // 
            bsPVNType.DataMember = "M_PVNTYPE";
            bsPVNType.MyDataSource = "KlonsMData";
            bsPVNType.Sort = "ID";
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_DOCS",
    "M_ROWS",
    "M_ITEMS",
    "M_ITEMS_CAT",
    "M_STORES",
    "M_ADDRESSSES",
    "M_CONTACTS",
    "M_BANKACCOUNTS",
    null
    };
            // 
            // bsUnits
            // 
            bsUnits.DataMember = "M_UNITS";
            bsUnits.MyDataSource = "KlonsMData";
            bsUnits.Sort = "CODE";
            // 
            // myConfigA1
            // 
            myConfigA1.DocStatusColor1 = System.Drawing.Color.LightYellow;
            myConfigA1.DocStatusColor2 = System.Drawing.Color.LightBlue;
            myConfigA1.DocStatusColor3 = System.Drawing.Color.LightGreen;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvFilter);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1038, 63);
            panel1.TabIndex = 3;
            // 
            // dgvFilter
            // 
            dgvFilter.AllowUserToAddRows = false;
            dgvFilter.AllowUserToDeleteRows = false;
            dgvFilter.AllowUserToResizeRows = false;
            dgvFilter.AutoGenerateColumns = false;
            dgvFilter.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFilterDt1, dgcFilterDt2, dgcFilterDocType, dgcFilterDocState, dgcFilterIdStoreOut, dgcFilterIdStoreIn, dgcFilterIdStoreOutOrIn });
            dgvFilter.DataSource = bsDocFilter;
            dgvFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFilter.Location = new System.Drawing.Point(0, 0);
            dgvFilter.Name = "dgvFilter";
            dgvFilter.RowHeadersVisible = false;
            dgvFilter.RowHeadersWidth = 62;
            dgvFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            dgvFilter.ShowCellToolTips = false;
            dgvFilter.Size = new System.Drawing.Size(969, 63);
            dgvFilter.TabIndex = 0;
            dgvFilter.CellFormatting += dgvFilter_CellFormatting;
            dgvFilter.CellParsing += dgvFilter_CellParsing;
            // 
            // dgcFilterDt1
            // 
            dgcFilterDt1.DataPropertyName = "Dt1";
            dataGridViewCellStyle9.Format = "dd.MM.yyyy";
            dgcFilterDt1.DefaultCellStyle = dataGridViewCellStyle9;
            dgcFilterDt1.HeaderText = "datums no";
            dgcFilterDt1.MinimumWidth = 8;
            dgcFilterDt1.Name = "dgcFilterDt1";
            dgcFilterDt1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcFilterDt1.Width = 85;
            // 
            // dgcFilterDt2
            // 
            dgcFilterDt2.DataPropertyName = "Dt2";
            dataGridViewCellStyle10.Format = "dd.MM.yyyy";
            dgcFilterDt2.DefaultCellStyle = dataGridViewCellStyle10;
            dgcFilterDt2.HeaderText = "datums līdz";
            dgcFilterDt2.MinimumWidth = 8;
            dgcFilterDt2.Name = "dgcFilterDt2";
            dgcFilterDt2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcFilterDt2.Width = 85;
            // 
            // dgcFilterDocType
            // 
            dgcFilterDocType.ColumnNames = new string[]
    {
    "NAME"
    };
            dgcFilterDocType.ColumnWidths = "150";
            dgcFilterDocType.DataPropertyName = "DocType";
            dgcFilterDocType.DataSource = bsDocType;
            dgcFilterDocType.DisplayMember = "CODE";
            dgcFilterDocType.HeaderText = "veids";
            dgcFilterDocType.MaxDropDownItems = 15;
            dgcFilterDocType.MinimumWidth = 8;
            dgcFilterDocType.Name = "dgcFilterDocType";
            dgcFilterDocType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterDocType.ValueMember = "ID";
            dgcFilterDocType.Width = 140;
            // 
            // dgcFilterDocState
            // 
            dgcFilterDocState.DataPropertyName = "DocState";
            dgcFilterDocState.DisplayMember = null;
            dgcFilterDocState.HeaderText = "status";
            dgcFilterDocState.MaxDropDownItems = 15;
            dgcFilterDocState.MinimumWidth = 8;
            dgcFilterDocState.Name = "dgcFilterDocState";
            dgcFilterDocState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterDocState.ValueMember = null;
            dgcFilterDocState.Width = 140;
            // 
            // dgcFilterIdStoreOut
            // 
            dgcFilterIdStoreOut.DataPropertyName = "IdStoreOut";
            dgcFilterIdStoreOut.DataSource = bsStoreOut;
            dgcFilterIdStoreOut.DisplayMember = "CODE";
            dgcFilterIdStoreOut.HeaderText = "izsniedzējs";
            dgcFilterIdStoreOut.MinimumWidth = 8;
            dgcFilterIdStoreOut.Name = "dgcFilterIdStoreOut";
            dgcFilterIdStoreOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterIdStoreOut.ValueMember = "ID";
            dgcFilterIdStoreOut.Width = 200;
            // 
            // dgcFilterIdStoreIn
            // 
            dgcFilterIdStoreIn.DataPropertyName = "IdStoreIn";
            dgcFilterIdStoreIn.DataSource = bsStoreIn;
            dgcFilterIdStoreIn.DisplayMember = "CODE";
            dgcFilterIdStoreIn.HeaderText = "saņēmējs";
            dgcFilterIdStoreIn.MinimumWidth = 8;
            dgcFilterIdStoreIn.Name = "dgcFilterIdStoreIn";
            dgcFilterIdStoreIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcFilterIdStoreIn.ValueMember = "ID";
            dgcFilterIdStoreIn.Width = 200;
            // 
            // dgcFilterIdStoreOutOrIn
            // 
            dgcFilterIdStoreOutOrIn.DataPropertyName = "IdStoreOutOrIn";
            dgcFilterIdStoreOutOrIn.DataSource = bsStoreIn;
            dgcFilterIdStoreOutOrIn.DisplayMember = "CODE";
            dgcFilterIdStoreOutOrIn.HeaderText = "izsniedzējs / saņēmējs";
            dgcFilterIdStoreOutOrIn.MinimumWidth = 8;
            dgcFilterIdStoreOutOrIn.Name = "dgcFilterIdStoreOutOrIn";
            dgcFilterIdStoreOutOrIn.ValueMember = "ID";
            dgcFilterIdStoreOutOrIn.Width = 200;
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
            btFilter.Size = new System.Drawing.Size(63, 57);
            btFilter.TabIndex = 1;
            btFilter.Text = "Atlasīt";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btFilter);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(969, 0);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(3);
            panel2.Size = new System.Drawing.Size(69, 63);
            panel2.TabIndex = 2;
            // 
            // FormM_DocList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1038, 340);
            Controls.Add(dgvDocs);
            Controls.Add(panel1);
            Controls.Add(bNav);
            Name = "FormM_DocList";
            Text = "Dokumenti";
            Load += FormM_DocList_Load;
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocFilter).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bniNew;
        private System.Windows.Forms.ToolStripButton bniSave;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private KlonsLIB.Data.MyBindingSource bsDocs;
        private KlonsLIB.Data.MyBindingSource bsDocType;
        private KlonsLIB.Data.MyBindingSource bsPVNType;
        private KlonsLIB.Data.MyBindingSource bsStoreOut;
        private KlonsLIB.Data.MyBindingSource bsStoreIn;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Data.MyBindingSource bsUnits;
        private MyConfigA myConfigA1;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvDocs;
        private KlonsLIB.Components.MyDataGridView dgvFilter;
        private KlonsLIB.Data.MyBindingSourceToObj bsDocFilter;
        private DataObjectsFM.DocFilterData docFilterData1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.ToolStripButton tsbOpenDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsPVNType;
        private KlonsLIB.Components.DataGridViewColorMarkColumn dgcDocsState;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcDocsIdStoreOut;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcDocsIdStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsCredDocDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsCredDocSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsCredDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsIdSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilterDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFilterDt2;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcFilterDocType;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcFilterDocState;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcFilterIdStoreOut;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcFilterIdStoreIn;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcFilterIdStoreOutOrIn;
        private System.Windows.Forms.Panel panel2;
    }
}