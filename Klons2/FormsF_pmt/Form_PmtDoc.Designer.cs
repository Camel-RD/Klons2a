namespace KlonsF.FormsF_pmt
{
    partial class Form_PmtDoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PmtDoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDoc = new KlonsLIB.Components.MyDataGridView();
            dgcDocMSGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocMSGIDSTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocACCOUNT = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsAccounts = new KlonsLIB.Data.MyBindingSource(components);
            dgcDocCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTP = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcDocDESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsDocs = new KlonsLIB.Data.MyBindingSource(components);
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            bnavDocs = new KlonsLIB.Components.MyBindingNavigator();
            bsRows = new KlonsLIB.Data.MyBindingSource2(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcRowsID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsID1STR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsID2STR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsCLID = new KlonsLIB.Components.MyDgvTextboxColumn2();
            dgcRowsAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsDETAILS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsCLIDFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsCLIDRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsCLIDAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            tsbExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvDoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs).BeginInit();
            bnavDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // dgvDoc
            // 
            dgvDoc.AllowUserToAddRows = false;
            dgvDoc.AllowUserToDeleteRows = false;
            dgvDoc.AutoGenerateColumns = false;
            dgvDoc.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocMSGID, dgcDocMSGIDSTR, dgcDocDT, dgcDocACCOUNT, dgcDocCT, dgcDocAMOUNT, dgcDocTP, dgcDocDESCR });
            dgvDoc.DataSource = bsDocs;
            dgvDoc.Dock = System.Windows.Forms.DockStyle.Top;
            dgvDoc.Location = new System.Drawing.Point(0, 0);
            dgvDoc.Name = "dgvDoc";
            dgvDoc.Size = new System.Drawing.Size(1002, 63);
            dgvDoc.TabIndex = 7;
            dgvDoc.MyCheckForChanges += DgvDoc_MyCheckForChanges;
            // 
            // dgcDocMSGID
            // 
            dgcDocMSGID.DataPropertyName = "MSGID";
            dgcDocMSGID.HeaderText = "npk.";
            dgcDocMSGID.Name = "dgcDocMSGID";
            dgcDocMSGID.ToolTipText = "Maksājumu uzdevuma numurs pēc kārtas";
            dgcDocMSGID.Width = 40;
            // 
            // dgcDocMSGIDSTR
            // 
            dgcDocMSGIDSTR.DataPropertyName = "MSGIDSTR";
            dgcDocMSGIDSTR.HeaderText = "identif.";
            dgcDocMSGIDSTR.Name = "dgcDocMSGIDSTR";
            dgcDocMSGIDSTR.ToolTipText = "Maksājuma uzdevuma identifikators";
            dgcDocMSGIDSTR.Width = 80;
            // 
            // dgcDocDT
            // 
            dgcDocDT.DataPropertyName = "DT";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            dgcDocDT.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDocDT.HeaderText = "datums, laiks";
            dgcDocDT.Name = "dgcDocDT";
            dgcDocDT.ToolTipText = "izveidošanas datums, laiks";
            dgcDocDT.Width = 150;
            // 
            // dgcDocACCOUNT
            // 
            dgcDocACCOUNT.DataPropertyName = "ACCOUNT";
            dgcDocACCOUNT.DataSource = bsAccounts;
            dgcDocACCOUNT.DisplayMember = "NAME";
            dgcDocACCOUNT.DisplayStyleForCurrentCellOnly = true;
            dgcDocACCOUNT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcDocACCOUNT.HeaderText = "konts";
            dgcDocACCOUNT.Name = "dgcDocACCOUNT";
            dgcDocACCOUNT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocACCOUNT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocACCOUNT.ToolTipText = "Konts no kura jāmaksā";
            dgcDocACCOUNT.ValueMember = "ID";
            dgcDocACCOUNT.Width = 150;
            // 
            // bsAccounts
            // 
            bsAccounts.DataMember = "F_PMT_ACCOUNTS";
            bsAccounts.MyDataSource = "KlonsData";
            // 
            // dgcDocCT
            // 
            dgcDocCT.DataPropertyName = "CT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcDocCT.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDocCT.HeaderText = "skaits";
            dgcDocCT.Name = "dgcDocCT";
            dgcDocCT.ReadOnly = true;
            dgcDocCT.ToolTipText = "Transakciju skaits maksājuma uzdevumā";
            dgcDocCT.Width = 60;
            // 
            // dgcDocAMOUNT
            // 
            dgcDocAMOUNT.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcDocAMOUNT.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDocAMOUNT.HeaderText = "summa";
            dgcDocAMOUNT.Name = "dgcDocAMOUNT";
            dgcDocAMOUNT.ReadOnly = true;
            dgcDocAMOUNT.ToolTipText = "Maksājumu uzdevuma kopējā summa";
            dgcDocAMOUNT.Width = 90;
            // 
            // dgcDocTP
            // 
            dgcDocTP.DataPropertyName = "TP";
            dgcDocTP.FalseValue = "0";
            dgcDocTP.HeaderText = "algas";
            dgcDocTP.Name = "dgcDocTP";
            dgcDocTP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocTP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocTP.ToolTipText = "Konsolidētais algu maksājumu uzdevums";
            dgcDocTP.TrueValue = "1";
            dgcDocTP.Width = 60;
            // 
            // dgcDocDESCR
            // 
            dgcDocDESCR.DataPropertyName = "DESCR";
            dgcDocDESCR.HeaderText = "apraksts";
            dgcDocDESCR.Name = "dgcDocDESCR";
            dgcDocDESCR.Width = 250;
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "F_PMT_MSG";
            bsDocs.MyDataSource = "KlonsData";
            bsDocs.Sort = "DT, MSGID";
            bsDocs.ListChanged += BsDocs_ListChanged;
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "Persons";
            bsPersons.MyDataSource = "KlonsData";
            bsPersons.Sort = "clid";
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
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 22);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            bindingNavigatorMoveNextItem.Text = "Move next";
            bindingNavigatorMoveNextItem.ToolTipText = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Move last";
            bindingNavigatorMoveLastItem.ToolTipText = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(66, 22);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(64, 22);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 22);
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // bnavDocs
            // 
            bnavDocs.AddNewItem = bindingNavigatorAddNewItem;
            bnavDocs.BindingSource = bsRows;
            bnavDocs.CountItem = bindingNavigatorCountItem;
            bnavDocs.CountItemFormat = " no {0}";
            bnavDocs.DataGrid = dgvRows;
            bnavDocs.DeleteItem = bindingNavigatorDeleteItem;
            bnavDocs.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave, tsbExport });
            bnavDocs.Location = new System.Drawing.Point(0, 316);
            bnavDocs.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavDocs.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavDocs.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavDocs.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavDocs.Name = "bnavDocs";
            bnavDocs.PositionItem = bindingNavigatorPositionItem;
            bnavDocs.SaveItem = null;
            bnavDocs.Size = new System.Drawing.Size(1002, 25);
            bnavDocs.TabIndex = 5;
            bnavDocs.Text = "bindingNavigator1";
            bnavDocs.ItemDeleting += bnavDocs_ItemDeleting;
            // 
            // bsRows
            // 
            bsRows.DataMember = "FK_F_PMT_TRFTRX_IDMSH";
            bsRows.DataSource = bsDocs;
            bsRows.Sort = "ID1";
            bsRows.UseDataGridView = dgvRows;
            bsRows.ListChanged += bsRows_ListChanged;
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcRowsID1, dgcRowsID1STR, dgcRowsID2, dgcRowsID2STR, dgcRowsCLID, dgcRowsAMOUNT, dgcRowsDETAILS, dgcRowsCLIDFull, dgcRowsCLIDRegNr, dgcRowsCLIDAccount });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 63);
            dgvRows.Name = "dgvRows";
            dgvRows.Size = new System.Drawing.Size(1002, 253);
            dgvRows.TabIndex = 8;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellDoubleClick += DgvRows_CellDoubleClick;
            dgvRows.CellEndEdit += dgvRows_CellEndEdit;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            dgvRows.DefaultValuesNeeded += DgvRows_DefaultValuesNeeded;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            // 
            // dgcRowsID1
            // 
            dgcRowsID1.DataPropertyName = "ID1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowsID1.DefaultCellStyle = dataGridViewCellStyle4;
            dgcRowsID1.HeaderText = "npk.";
            dgcRowsID1.Name = "dgcRowsID1";
            dgcRowsID1.ReadOnly = true;
            dgcRowsID1.ToolTipText = "Numurs pēc kārtas šī maksājumu uzdevuma ietvaros";
            dgcRowsID1.Width = 40;
            // 
            // dgcRowsID1STR
            // 
            dgcRowsID1STR.DataPropertyName = "ID1STR";
            dgcRowsID1STR.HeaderText = "...";
            dgcRowsID1STR.Name = "dgcRowsID1STR";
            dgcRowsID1STR.ReadOnly = true;
            dgcRowsID1STR.ToolTipText = "Noformēts numurs pēc kārtas šī maksājumu uzdevuma ietvaros";
            dgcRowsID1STR.Width = 70;
            // 
            // dgcRowsID2
            // 
            dgcRowsID2.DataPropertyName = "ID2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowsID2.DefaultCellStyle = dataGridViewCellStyle5;
            dgcRowsID2.HeaderText = "ident.";
            dgcRowsID2.Name = "dgcRowsID2";
            dgcRowsID2.ReadOnly = true;
            dgcRowsID2.ToolTipText = "Unikāls pārveduma identifikators";
            dgcRowsID2.Width = 50;
            // 
            // dgcRowsID2STR
            // 
            dgcRowsID2STR.DataPropertyName = "ID2STR";
            dgcRowsID2STR.HeaderText = "...";
            dgcRowsID2STR.Name = "dgcRowsID2STR";
            dgcRowsID2STR.ReadOnly = true;
            dgcRowsID2STR.ToolTipText = "Noformēts unikāls pārveduma identifikators";
            dgcRowsID2STR.Width = 70;
            // 
            // dgcRowsCLID
            // 
            dgcRowsCLID.DataPropertyName = "CLID";
            dgcRowsCLID.DataSource = bsPersons;
            dgcRowsCLID.DisplayMember = "ClId";
            dgcRowsCLID.HeaderText = "persona";
            dgcRowsCLID.Name = "dgcRowsCLID";
            dgcRowsCLID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcRowsCLID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcRowsCLID.ToolTipText = "Pārskaitijuma saņēmējs";
            dgcRowsCLID.ValueMember = "ClId";
            dgcRowsCLID.Width = 140;
            // 
            // dgcRowsAMOUNT
            // 
            dgcRowsAMOUNT.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcRowsAMOUNT.DefaultCellStyle = dataGridViewCellStyle6;
            dgcRowsAMOUNT.HeaderText = "summa";
            dgcRowsAMOUNT.Name = "dgcRowsAMOUNT";
            dgcRowsAMOUNT.Width = 90;
            // 
            // dgcRowsDETAILS
            // 
            dgcRowsDETAILS.DataPropertyName = "DETAILS";
            dgcRowsDETAILS.HeaderText = "apraksts";
            dgcRowsDETAILS.Name = "dgcRowsDETAILS";
            dgcRowsDETAILS.Width = 300;
            // 
            // dgcRowsCLIDFull
            // 
            dgcRowsCLIDFull.DataPropertyName = "CLID";
            dgcRowsCLIDFull.HeaderText = "persona";
            dgcRowsCLIDFull.Name = "dgcRowsCLIDFull";
            dgcRowsCLIDFull.ReadOnly = true;
            dgcRowsCLIDFull.Width = 200;
            // 
            // dgcRowsCLIDRegNr
            // 
            dgcRowsCLIDRegNr.DataPropertyName = "CLID";
            dgcRowsCLIDRegNr.HeaderText = "reģ. nr.";
            dgcRowsCLIDRegNr.Name = "dgcRowsCLIDRegNr";
            dgcRowsCLIDRegNr.ReadOnly = true;
            dgcRowsCLIDRegNr.Width = 120;
            // 
            // dgcRowsCLIDAccount
            // 
            dgcRowsCLIDAccount.DataPropertyName = "CLID";
            dgcRowsCLIDAccount.HeaderText = "konts";
            dgcRowsCLIDAccount.Name = "dgcRowsCLIDAccount";
            dgcRowsCLIDAccount.ReadOnly = true;
            dgcRowsCLIDAccount.Width = 200;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsData";
            myAdapterManager1.TableNames = new string[]
    {
    "Banks",
    "F_PMT_ACCOUNTS",
    "F_PMT_MSG",
    "F_PMT_TRFTRX",
    null
    };
            // 
            // tsbExport
            // 
            tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbExport.Image = (System.Drawing.Image)resources.GetObject("tsbExport.Image");
            tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new System.Drawing.Size(72, 22);
            tsbExport.Text = "☆Eksportēt";
            tsbExport.Click += tsbExport_Click;
            // 
            // Form_PmtDoc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1002, 341);
            Controls.Add(dgvRows);
            Controls.Add(dgvDoc);
            Controls.Add(bnavDocs);
            Name = "Form_PmtDoc";
            Text = "Maksājumu uzdevuma pārskaitijumi";
            FormClosed += Form_PmtDoc_FormClosed;
            Load += Form_PmtDoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs).EndInit();
            bnavDocs.ResumeLayout(false);
            bnavDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private KlonsLIB.Components.MyDataGridView dgvDoc;
        private KlonsLIB.Data.MyBindingSource bsDocs;
        private KlonsLIB.Data.MyBindingSource bsAccounts;
        private KlonsLIB.Data.MyBindingSource bsPersons;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Components.MyBindingNavigator bnavDocs;
        private KlonsLIB.Data.MyBindingSource2 bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsID1STR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsID2STR;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRowsCLID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsAMOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsDETAILS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsCLIDFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsCLIDRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsCLIDAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocMSGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocMSGIDSTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcDocACCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocAMOUNT;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcDocTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocDESCR;
        private System.Windows.Forms.ToolStripButton tsbExport;
    }
}