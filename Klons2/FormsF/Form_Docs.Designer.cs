using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_Docs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Docs));
            splitContainer1 = new MySplitContainer();
            dgvDocs = new MyDataGridView();
            dgcDocsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsZNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDocTyp = new MyDgvMcCBColumn();
            bsDocTyp = new MyBindingSource(components);
            dgcDocsDocSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsClid = new MyDgvMcCBColumn();
            bsClid = new MyBindingSource(components);
            dgcDocsDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsClid2 = new MyDgvMcCBColumn();
            bsClid2 = new MyBindingSource(components);
            dgcDocsNrx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsZU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsZDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsOPSd = new MyBindingSource(components);
            dgvOps = new MyDataGridView();
            dgcOpsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsDocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsAC25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsSummC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsCur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsQV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOpsNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsOPS = new MyBindingSource2(components);
            bnavNav = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            oPSdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            tsbSearchPrev = new System.Windows.Forms.ToolStripButton();
            tsbSearch = new System.Windows.Forms.ToolStripTextBox();
            tsbSearchNext = new System.Windows.Forms.ToolStripButton();
            tsbSum = new System.Windows.Forms.ToolStripTextBox();
            toolStrip1 = new System.Windows.Forms.MenuStrip();
            tbsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            toolStripButton1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripMenuItem();
            kaseiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kasesIeņēmumuOrderisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            kasesIzdevumuOrderisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            kasesIeņēmumuOrderaKvītsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kasesIzdevumuOrderaKvītsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rēķiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vienkārssRēķinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rēkins2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rēķinsArDaudzumiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            pavadzīmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsbIeraksti = new System.Windows.Forms.ToolStripMenuItem();
            myAdapterManager1 = new MyAdapterManager();
            imageList1 = new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOPSd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavNav).BeginInit();
            bnavNav.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDocs);
            splitContainer1.Panel1MinSize = 125;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOps);
            splitContainer1.Panel2MinSize = 125;
            splitContainer1.Size = new System.Drawing.Size(1284, 414);
            splitContainer1.SplitterDistance = 190;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 3;
            // 
            // dgvDocs
            // 
            dgvDocs.AutoGenerateColumns = false;
            dgvDocs.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocsId, dgcDocsZNR, dgcDocsDate, dgcDocsDocTyp, dgcDocsDocSt, dgcDocsDocNr, dgcDocsClid, dgcDocsDescr, dgcDocsSumm, dgcDocsPVN, dgcDocsClid2, dgcDocsNrx, dgcDocsDT2, dgcDocsZU, dgcDocsZDt, dgcDocsNL });
            dgvDocs.DataSource = bsOPSd;
            dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocs.Location = new System.Drawing.Point(0, 0);
            dgvDocs.Margin = new System.Windows.Forms.Padding(2);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.RowHeadersWidth = 62;
            dgvDocs.Size = new System.Drawing.Size(1284, 190);
            dgvDocs.TabIndex = 2;
            dgvDocs.MyKeyDown += dgvDocs_MyKeyDown;
            dgvDocs.MyCheckForChanges += dgvDocs_MyCheckForChanges;
            dgvDocs.CellDoubleClick += dgvDocs_CellDoubleClick;
            dgvDocs.CellEndEdit += dgvDocs_CellEndEdit;
            dgvDocs.CellParsing += dgvDocs_CellParsing;
            dgvDocs.CellToolTipTextNeeded += dgvDocs_CellToolTipTextNeeded;
            dgvDocs.CurrentCellChanged += dgvDocs_CurrentCellChanged;
            dgvDocs.DataError += dgvDocs_DataError;
            dgvDocs.DefaultValuesNeeded += dgvDocs_DefaultValuesNeeded;
            dgvDocs.RowValidated += dgvDocs_RowValidated;
            dgvDocs.SelectionChanged += dgvDocs_SelectionChanged;
            dgvDocs.UserDeletingRow += dgvDocs_UserDeletingRow;
            dgvDocs.Enter += dgvDocs_Enter;
            dgvDocs.KeyDown += dgvDocs_KeyDown;
            dgvDocs.Leave += dgvDocs_Leave;
            // 
            // dgcDocsId
            // 
            dgcDocsId.DataPropertyName = "id";
            dgcDocsId.HeaderText = "id";
            dgcDocsId.MinimumWidth = 9;
            dgcDocsId.Name = "dgcDocsId";
            dgcDocsId.ReadOnly = true;
            dgcDocsId.Visible = false;
            dgcDocsId.Width = 63;
            // 
            // dgcDocsZNR
            // 
            dgcDocsZNR.DataPropertyName = "ZNR";
            dgcDocsZNR.HeaderText = "Nr.";
            dgcDocsZNR.MinimumWidth = 9;
            dgcDocsZNR.Name = "dgcDocsZNR";
            dgcDocsZNR.ReadOnly = true;
            dgcDocsZNR.Width = 50;
            // 
            // dgcDocsDate
            // 
            dgcDocsDate.DataPropertyName = "Dete";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDocsDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDocsDate.HeaderText = "Datums";
            dgcDocsDate.MinimumWidth = 9;
            dgcDocsDate.Name = "dgcDocsDate";
            dgcDocsDate.Width = 85;
            // 
            // dgcDocsDocTyp
            // 
            dgcDocsDocTyp.ColumnNames = new string[]
    {
    "id",
    "name"
    };
            dgcDocsDocTyp.ColumnWidths = "100;200";
            dgcDocsDocTyp.DataPropertyName = "DocTyp";
            dgcDocsDocTyp.DataSource = bsDocTyp;
            dgcDocsDocTyp.DisplayMember = "id";
            dgcDocsDocTyp.HeaderText = "Dok.veids";
            dgcDocsDocTyp.MaxDropDownItems = 15;
            dgcDocsDocTyp.MinimumWidth = 9;
            dgcDocsDocTyp.Name = "dgcDocsDocTyp";
            dgcDocsDocTyp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsDocTyp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsDocTyp.ValueMember = "id";
            dgcDocsDocTyp.Width = 72;
            // 
            // bsDocTyp
            // 
            bsDocTyp.DataMember = "DocTyp";
            bsDocTyp.MyDataSource = "KlonsData";
            bsDocTyp.Sort = "id";
            // 
            // dgcDocsDocSt
            // 
            dgcDocsDocSt.DataPropertyName = "DocSt";
            dgcDocsDocSt.HeaderText = "Sērija";
            dgcDocsDocSt.MinimumWidth = 9;
            dgcDocsDocSt.Name = "dgcDocsDocSt";
            dgcDocsDocSt.Width = 54;
            // 
            // dgcDocsDocNr
            // 
            dgcDocsDocNr.DataPropertyName = "DocNr";
            dgcDocsDocNr.HeaderText = "Dok.nr.";
            dgcDocsDocNr.MinimumWidth = 9;
            dgcDocsDocNr.Name = "dgcDocsDocNr";
            dgcDocsDocNr.Width = 99;
            // 
            // dgcDocsClid
            // 
            dgcDocsClid.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            dgcDocsClid.ColumnWidths = "120;400";
            dgcDocsClid.DataPropertyName = "ClId";
            dgcDocsClid.DataSource = bsClid;
            dgcDocsClid.DisplayMember = "ClId";
            dgcDocsClid.HeaderText = "Persona";
            dgcDocsClid.MaxDropDownItems = 15;
            dgcDocsClid.MinimumWidth = 9;
            dgcDocsClid.Name = "dgcDocsClid";
            dgcDocsClid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsClid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsClid.ValueMember = "ClId";
            dgcDocsClid.Width = 120;
            // 
            // bsClid
            // 
            bsClid.DataMember = "Persons";
            bsClid.MyDataSource = "KlonsData";
            bsClid.Sort = "clid";
            // 
            // dgcDocsDescr
            // 
            dgcDocsDescr.DataPropertyName = "Descr";
            dgcDocsDescr.HeaderText = "Apraksts";
            dgcDocsDescr.MinimumWidth = 9;
            dgcDocsDescr.Name = "dgcDocsDescr";
            dgcDocsDescr.Width = 250;
            // 
            // dgcDocsSumm
            // 
            dgcDocsSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcDocsSumm.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDocsSumm.HeaderText = "Summa";
            dgcDocsSumm.MinimumWidth = 9;
            dgcDocsSumm.Name = "dgcDocsSumm";
            dgcDocsSumm.Width = 90;
            // 
            // dgcDocsPVN
            // 
            dgcDocsPVN.DataPropertyName = "PVN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcDocsPVN.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDocsPVN.HeaderText = "PVN";
            dgcDocsPVN.MinimumWidth = 9;
            dgcDocsPVN.Name = "dgcDocsPVN";
            dgcDocsPVN.Width = 90;
            // 
            // dgcDocsClid2
            // 
            dgcDocsClid2.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            dgcDocsClid2.ColumnWidths = "120;400";
            dgcDocsClid2.DataPropertyName = "ClId2";
            dgcDocsClid2.DataSource = bsClid2;
            dgcDocsClid2.DisplayMember = "ClId";
            dgcDocsClid2.HeaderText = "Nor.pers.";
            dgcDocsClid2.MaxDropDownItems = 15;
            dgcDocsClid2.MinimumWidth = 9;
            dgcDocsClid2.Name = "dgcDocsClid2";
            dgcDocsClid2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocsClid2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocsClid2.ToolTipText = "Norēķinu persona (av.nor., kases orderi)";
            dgcDocsClid2.ValueMember = "ClId";
            dgcDocsClid2.Width = 108;
            // 
            // bsClid2
            // 
            bsClid2.DataMember = "Persons";
            bsClid2.MyDataSource = "KlonsData";
            bsClid2.Sort = "clid";
            // 
            // dgcDocsNrx
            // 
            dgcDocsNrx.DataPropertyName = "NrX";
            dgcDocsNrx.HeaderText = "Nr.2";
            dgcDocsNrx.MinimumWidth = 9;
            dgcDocsNrx.Name = "dgcDocsNrx";
            dgcDocsNrx.Width = 45;
            // 
            // dgcDocsDT2
            // 
            dgcDocsDT2.DataPropertyName = "DT2";
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dgcDocsDT2.DefaultCellStyle = dataGridViewCellStyle4;
            dgcDocsDT2.HeaderText = "Datums2";
            dgcDocsDT2.MinimumWidth = 9;
            dgcDocsDT2.Name = "dgcDocsDT2";
            dgcDocsDT2.Width = 85;
            // 
            // dgcDocsZU
            // 
            dgcDocsZU.DataPropertyName = "ZU";
            dgcDocsZU.HeaderText = "Lietotajs";
            dgcDocsZU.MinimumWidth = 9;
            dgcDocsZU.Name = "dgcDocsZU";
            dgcDocsZU.ReadOnly = true;
            dgcDocsZU.Width = 90;
            // 
            // dgcDocsZDt
            // 
            dgcDocsZDt.DataPropertyName = "ZDt";
            dgcDocsZDt.HeaderText = "Labojuma laiks";
            dgcDocsZDt.MinimumWidth = 9;
            dgcDocsZDt.Name = "dgcDocsZDt";
            dgcDocsZDt.ReadOnly = true;
            dgcDocsZDt.Width = 144;
            // 
            // dgcDocsNL
            // 
            dgcDocsNL.DataPropertyName = "NL";
            dgcDocsNL.HeaderText = "NL";
            dgcDocsNL.MinimumWidth = 9;
            dgcDocsNL.Name = "dgcDocsNL";
            dgcDocsNL.Visible = false;
            dgcDocsNL.Width = 67;
            // 
            // bsOPSd
            // 
            bsOPSd.DataMember = "OPSd";
            bsOPSd.MyDataSource = "KlonsData";
            bsOPSd.Name2 = "Docs";
            bsOPSd.UseDataGridView = dgvDocs;
            bsOPSd.AddingNew += bsOPSd_AddingNew;
            bsOPSd.ListChanged += bsOPSd_ListChanged;
            // 
            // dgvOps
            // 
            dgvOps.AutoGenerateColumns = false;
            dgvOps.AutoSave = false;
            dgvOps.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcOpsId, dgcOpsDocId, dgcOpsAC11, dgcOpsAC12, dgcOpsAC13, dgcOpsAC14, dgcOpsAC15, dgcOpsAC21, dgcOpsAC22, dgcOpsAC23, dgcOpsAC24, dgcOpsAC25, dgcOpsSummC, dgcOpsCur, dgcOpsSumm, dgcOpsQV, dgcOpsDescr, dgcOpsNL });
            dgvOps.DataSource = bsOPS;
            dgvOps.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOps.Location = new System.Drawing.Point(0, 0);
            dgvOps.Margin = new System.Windows.Forms.Padding(2);
            dgvOps.Name = "dgvOps";
            dgvOps.RowHeadersWidth = 62;
            dgvOps.Size = new System.Drawing.Size(1284, 216);
            dgvOps.TabIndex = 3;
            dgvOps.MyKeyDown += dgvOps_MyKeyDown;
            dgvOps.MyCheckForChanges += dgvOps_MyCheckForChanges;
            dgvOps.CellDoubleClick += dgvOps_CellDoubleClick;
            dgvOps.CellEndEdit += dgvOps_CellEndEdit;
            dgvOps.CellToolTipTextNeeded += dgvOps_CellToolTipTextNeeded;
            dgvOps.CellValueChanged += dgvOps_CellValueChanged;
            dgvOps.DataError += dgvOps_DataError;
            dgvOps.RowValidated += dgvOps_RowValidated;
            dgvOps.RowValidating += dgvOps_RowValidating;
            dgvOps.UserDeletingRow += dgvOps_UserDeletingRow;
            dgvOps.Enter += dgvOps_Enter;
            // 
            // dgcOpsId
            // 
            dgcOpsId.DataPropertyName = "id";
            dgcOpsId.HeaderText = "id";
            dgcOpsId.MinimumWidth = 9;
            dgcOpsId.Name = "dgcOpsId";
            dgcOpsId.ReadOnly = true;
            dgcOpsId.Visible = false;
            dgcOpsId.Width = 45;
            // 
            // dgcOpsDocId
            // 
            dgcOpsDocId.DataPropertyName = "DocId";
            dgcOpsDocId.HeaderText = "DocId";
            dgcOpsDocId.MinimumWidth = 9;
            dgcOpsDocId.Name = "dgcOpsDocId";
            dgcOpsDocId.Visible = false;
            dgcOpsDocId.Width = 54;
            // 
            // dgcOpsAC11
            // 
            dgcOpsAC11.DataPropertyName = "AC11";
            dgcOpsAC11.HeaderText = "Debets";
            dgcOpsAC11.MinimumWidth = 9;
            dgcOpsAC11.Name = "dgcOpsAC11";
            dgcOpsAC11.Width = 72;
            // 
            // dgcOpsAC12
            // 
            dgcOpsAC12.DataPropertyName = "AC12";
            dgcOpsAC12.HeaderText = "D.n.p.";
            dgcOpsAC12.MinimumWidth = 9;
            dgcOpsAC12.Name = "dgcOpsAC12";
            dgcOpsAC12.ToolTipText = "debets: naudas plūsma";
            dgcOpsAC12.Width = 72;
            // 
            // dgcOpsAC13
            // 
            dgcOpsAC13.DataPropertyName = "AC13";
            dgcOpsAC13.HeaderText = "D.iin";
            dgcOpsAC13.MinimumWidth = 9;
            dgcOpsAC13.Name = "dgcOpsAC13";
            dgcOpsAC13.ToolTipText = "debets: darijumu žurnāls IIN";
            dgcOpsAC13.Width = 45;
            // 
            // dgcOpsAC14
            // 
            dgcOpsAC14.DataPropertyName = "AC14";
            dgcOpsAC14.HeaderText = "D.kat.";
            dgcOpsAC14.MinimumWidth = 9;
            dgcOpsAC14.Name = "dgcOpsAC14";
            dgcOpsAC14.ToolTipText = "debets: kategorija";
            dgcOpsAC14.Width = 72;
            // 
            // dgcOpsAC15
            // 
            dgcOpsAC15.DataPropertyName = "AC15";
            dgcOpsAC15.HeaderText = "D.pvn";
            dgcOpsAC15.MinimumWidth = 9;
            dgcOpsAC15.Name = "dgcOpsAC15";
            dgcOpsAC15.ToolTipText = "debets: PVN";
            dgcOpsAC15.Width = 54;
            // 
            // dgcOpsAC21
            // 
            dgcOpsAC21.DataPropertyName = "AC21";
            dgcOpsAC21.HeaderText = "Kredīts";
            dgcOpsAC21.MinimumWidth = 9;
            dgcOpsAC21.Name = "dgcOpsAC21";
            dgcOpsAC21.Width = 72;
            // 
            // dgcOpsAC22
            // 
            dgcOpsAC22.DataPropertyName = "AC22";
            dgcOpsAC22.HeaderText = "K.n.p.";
            dgcOpsAC22.MinimumWidth = 9;
            dgcOpsAC22.Name = "dgcOpsAC22";
            dgcOpsAC22.ToolTipText = "kredīts: naudas plūsma";
            dgcOpsAC22.Width = 72;
            // 
            // dgcOpsAC23
            // 
            dgcOpsAC23.DataPropertyName = "AC23";
            dgcOpsAC23.HeaderText = "K.iin";
            dgcOpsAC23.MinimumWidth = 9;
            dgcOpsAC23.Name = "dgcOpsAC23";
            dgcOpsAC23.ToolTipText = "kredīts: darijumu žurnāls IIN";
            dgcOpsAC23.Width = 45;
            // 
            // dgcOpsAC24
            // 
            dgcOpsAC24.DataPropertyName = "AC24";
            dgcOpsAC24.HeaderText = "K.kat.";
            dgcOpsAC24.MinimumWidth = 9;
            dgcOpsAC24.Name = "dgcOpsAC24";
            dgcOpsAC24.ToolTipText = "kredīts: kategorija";
            dgcOpsAC24.Width = 72;
            // 
            // dgcOpsAC25
            // 
            dgcOpsAC25.DataPropertyName = "AC25";
            dgcOpsAC25.HeaderText = "K.pvn";
            dgcOpsAC25.MinimumWidth = 9;
            dgcOpsAC25.Name = "dgcOpsAC25";
            dgcOpsAC25.ToolTipText = "kredīts: PVN";
            dgcOpsAC25.Width = 54;
            // 
            // dgcOpsSummC
            // 
            dgcOpsSummC.DataPropertyName = "SummC";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcOpsSummC.DefaultCellStyle = dataGridViewCellStyle5;
            dgcOpsSummC.HeaderText = "summa";
            dgcOpsSummC.MinimumWidth = 9;
            dgcOpsSummC.Name = "dgcOpsSummC";
            dgcOpsSummC.ToolTipText = "Summa";
            dgcOpsSummC.Width = 90;
            // 
            // dgcOpsCur
            // 
            dgcOpsCur.DataPropertyName = "Cur";
            dgcOpsCur.HeaderText = "valūta";
            dgcOpsCur.MaxInputLength = 3;
            dgcOpsCur.MinimumWidth = 9;
            dgcOpsCur.Name = "dgcOpsCur";
            dgcOpsCur.Width = 72;
            // 
            // dgcOpsSumm
            // 
            dgcOpsSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcOpsSumm.DefaultCellStyle = dataGridViewCellStyle6;
            dgcOpsSumm.HeaderText = "EUR";
            dgcOpsSumm.MinimumWidth = 9;
            dgcOpsSumm.Name = "dgcOpsSumm";
            dgcOpsSumm.ReadOnly = true;
            dgcOpsSumm.ToolTipText = "summa pārrēķināta uz eiro";
            dgcOpsSumm.Width = 90;
            // 
            // dgcOpsQV
            // 
            dgcOpsQV.DataPropertyName = "QV";
            dgcOpsQV.HeaderText = "Daudzums";
            dgcOpsQV.MinimumWidth = 9;
            dgcOpsQV.Name = "dgcOpsQV";
            dgcOpsQV.Width = 90;
            // 
            // dgcOpsDescr
            // 
            dgcOpsDescr.DataPropertyName = "Descr";
            dgcOpsDescr.HeaderText = "Apraksts";
            dgcOpsDescr.MinimumWidth = 9;
            dgcOpsDescr.Name = "dgcOpsDescr";
            dgcOpsDescr.Width = 108;
            // 
            // dgcOpsNL
            // 
            dgcOpsNL.DataPropertyName = "NL";
            dgcOpsNL.HeaderText = "NL";
            dgcOpsNL.MinimumWidth = 9;
            dgcOpsNL.Name = "dgcOpsNL";
            dgcOpsNL.Visible = false;
            dgcOpsNL.Width = 67;
            // 
            // bsOPS
            // 
            bsOPS.AllowNew = true;
            bsOPS.UseDataGridView = dgvOps;
            bsOPS.DataMember = "FK_OPS_DOCID_OPSD_ID";
            bsOPS.DataSource = bsOPSd;
            bsOPS.Name2 = "Ops";
            bsOPS.Sort = "";
            bsOPS.ListChanged += bsOPS_ListChanged;
            // 
            // bnavNav
            // 
            bnavNav.AddNewItem = bindingNavigatorAddNewItem;
            bnavNav.BindingSource = bsOPSd;
            bnavNav.CountItem = bindingNavigatorCountItem;
            bnavNav.CountItemFormat = " no {0}";
            bnavNav.DeleteItem = null;
            bnavNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavNav.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, ToolStripButtonCopy, bindingNavigatorDeleteItem, toolStripButtonInfo, oPSdBindingNavigatorSaveItem, tsbSearchPrev, tsbSearch, tsbSearchNext, tsbSum });
            bnavNav.Location = new System.Drawing.Point(0, 414);
            bnavNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavNav.Name = "bnavNav";
            bnavNav.PositionItem = bindingNavigatorPositionItem;
            bnavNav.SaveItem = null;
            bnavNav.Size = new System.Drawing.Size(1284, 28);
            bnavNav.TabIndex = 0;
            bnavNav.Text = "bindingNavigator1";
            bnavNav.ItemDeleting += bnavNav_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 25);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns (Shift+Insert)";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 25);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.ToolTipText = "Dzēst (Ctrl+Delete)";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(79, 25);
            toolStripLabel1.Text = "Dokumenti:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            bindingNavigatorMoveFirstItem.ToolTipText = "Iet uz sākumu";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            bindingNavigatorMovePreviousItem.ToolTipText = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
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
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveNextItem.Text = "Move next";
            bindingNavigatorMoveNextItem.ToolTipText = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveLastItem.Text = "Move last";
            bindingNavigatorMoveLastItem.ToolTipText = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // ToolStripButtonCopy
            // 
            ToolStripButtonCopy.Image = (System.Drawing.Image)resources.GetObject("ToolStripButtonCopy.Image");
            ToolStripButtonCopy.Name = "ToolStripButtonCopy";
            ToolStripButtonCopy.Size = new System.Drawing.Size(70, 25);
            ToolStripButtonCopy.Text = "Kopēt";
            ToolStripButtonCopy.ToolTipText = "Kopēt (Ctrl+Insert)";
            ToolStripButtonCopy.Click += ToolStripButtonCopy_Click;
            // 
            // toolStripButtonInfo
            // 
            toolStripButtonInfo.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonInfo.Image");
            toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonInfo.Name = "toolStripButtonInfo";
            toolStripButtonInfo.Size = new System.Drawing.Size(56, 25);
            toolStripButtonInfo.Text = "Info";
            toolStripButtonInfo.Click += toolStripButtonInfo_Click;
            // 
            // oPSdBindingNavigatorSaveItem
            // 
            oPSdBindingNavigatorSaveItem.Name = "oPSdBindingNavigatorSaveItem";
            oPSdBindingNavigatorSaveItem.Size = new System.Drawing.Size(68, 25);
            oPSdBindingNavigatorSaveItem.Text = "Saglabāt";
            oPSdBindingNavigatorSaveItem.ToolTipText = "Saglabāt datus (Ctrl + S)";
            oPSdBindingNavigatorSaveItem.Click += oPSdBindingNavigatorSaveItem_Click;
            // 
            // tsbSearchPrev
            // 
            tsbSearchPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSearchPrev.Image = (System.Drawing.Image)resources.GetObject("tsbSearchPrev.Image");
            tsbSearchPrev.Name = "tsbSearchPrev";
            tsbSearchPrev.RightToLeftAutoMirrorImage = true;
            tsbSearchPrev.Size = new System.Drawing.Size(25, 25);
            tsbSearchPrev.Text = "Move previous";
            tsbSearchPrev.ToolTipText = "Iet uz iepriekšējo";
            tsbSearchPrev.Click += tsbSearchPrev_Click;
            // 
            // tsbSearch
            // 
            tsbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new System.Drawing.Size(65, 28);
            tsbSearch.ToolTipText = "Meklēt tekstu";
            tsbSearch.Enter += tsbSearch_Enter;
            tsbSearch.KeyPress += tsbSearch_KeyPress;
            // 
            // tsbSearchNext
            // 
            tsbSearchNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSearchNext.Image = (System.Drawing.Image)resources.GetObject("tsbSearchNext.Image");
            tsbSearchNext.Name = "tsbSearchNext";
            tsbSearchNext.RightToLeftAutoMirrorImage = true;
            tsbSearchNext.Size = new System.Drawing.Size(25, 25);
            tsbSearchNext.Text = "Move next";
            tsbSearchNext.ToolTipText = "Iet uz nākošo";
            tsbSearchNext.Click += tsbSearchNext_Click;
            // 
            // tsbSum
            // 
            tsbSum.AutoSize = false;
            tsbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbSum.Name = "tsbSum";
            tsbSum.Size = new System.Drawing.Size(100, 23);
            tsbSum.Text = "0.00";
            tsbSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            tsbSum.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tbsRefresh, toolStripButton1, toolStripDropDownButton1, tsbIeraksti });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1284, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.Visible = false;
            // 
            // tbsRefresh
            // 
            tbsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tbsRefresh.Image = (System.Drawing.Image)resources.GetObject("tbsRefresh.Image");
            tbsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbsRefresh.Name = "tbsRefresh";
            tbsRefresh.Size = new System.Drawing.Size(67, 21);
            tbsRefresh.Text = "Pārlasīt";
            tbsRefresh.Click += tbsRefresh_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(138, 21);
            toolStripButton1.Text = "S&aistītie dokumenti";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { kaseiToolStripMenuItem, rēķiniToolStripMenuItem });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(69, 21);
            toolStripDropDownButton1.Text = "Izdrukai";
            // 
            // kaseiToolStripMenuItem
            // 
            kaseiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { kasesIeņēmumuOrderisToolStripMenuItem1, kasesIzdevumuOrderisToolStripMenuItem, toolStripSeparator1, kasesIeņēmumuOrderaKvītsToolStripMenuItem, kasesIzdevumuOrderaKvītsToolStripMenuItem });
            kaseiToolStripMenuItem.Name = "kaseiToolStripMenuItem";
            kaseiToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            kaseiToolStripMenuItem.Text = "Kase";
            // 
            // kasesIeņēmumuOrderisToolStripMenuItem1
            // 
            kasesIeņēmumuOrderisToolStripMenuItem1.Name = "kasesIeņēmumuOrderisToolStripMenuItem1";
            kasesIeņēmumuOrderisToolStripMenuItem1.Size = new System.Drawing.Size(262, 22);
            kasesIeņēmumuOrderisToolStripMenuItem1.Text = "Kases ieņēmumu orderis";
            kasesIeņēmumuOrderisToolStripMenuItem1.Click += kasesIeņēmumuOrderisToolStripMenuItem1_Click;
            // 
            // kasesIzdevumuOrderisToolStripMenuItem
            // 
            kasesIzdevumuOrderisToolStripMenuItem.Name = "kasesIzdevumuOrderisToolStripMenuItem";
            kasesIzdevumuOrderisToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            kasesIzdevumuOrderisToolStripMenuItem.Text = "Kases izdevumu orderis";
            kasesIzdevumuOrderisToolStripMenuItem.Click += kasesIzdevumuOrderisToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // kasesIeņēmumuOrderaKvītsToolStripMenuItem
            // 
            kasesIeņēmumuOrderaKvītsToolStripMenuItem.Name = "kasesIeņēmumuOrderaKvītsToolStripMenuItem";
            kasesIeņēmumuOrderaKvītsToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            kasesIeņēmumuOrderaKvītsToolStripMenuItem.Text = "Kases ieņēmumu ordera kvīts";
            kasesIeņēmumuOrderaKvītsToolStripMenuItem.Click += kasesIeņēmumuOrderaKvītsToolStripMenuItem_Click;
            // 
            // kasesIzdevumuOrderaKvītsToolStripMenuItem
            // 
            kasesIzdevumuOrderaKvītsToolStripMenuItem.Name = "kasesIzdevumuOrderaKvītsToolStripMenuItem";
            kasesIzdevumuOrderaKvītsToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            kasesIzdevumuOrderaKvītsToolStripMenuItem.Text = "Kases izdevumu ordera kvīts";
            kasesIzdevumuOrderaKvītsToolStripMenuItem.Click += kasesIzdevumuOrderaKvītsToolStripMenuItem_Click;
            // 
            // rēķiniToolStripMenuItem
            // 
            rēķiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { vienkārssRēķinsToolStripMenuItem, rēkins2ToolStripMenuItem, rēķinsArDaudzumiemToolStripMenuItem, toolStripSeparator2, pavadzīmeToolStripMenuItem });
            rēķiniToolStripMenuItem.Name = "rēķiniToolStripMenuItem";
            rēķiniToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            rēķiniToolStripMenuItem.Text = "Rēķini";
            // 
            // vienkārssRēķinsToolStripMenuItem
            // 
            vienkārssRēķinsToolStripMenuItem.Name = "vienkārssRēķinsToolStripMenuItem";
            vienkārssRēķinsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            vienkārssRēķinsToolStripMenuItem.Text = "vienkāršs rēķins";
            vienkārssRēķinsToolStripMenuItem.Click += vienkārssRēķinsToolStripMenuItem_Click;
            // 
            // rēkins2ToolStripMenuItem
            // 
            rēkins2ToolStripMenuItem.Name = "rēkins2ToolStripMenuItem";
            rēkins2ToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            rēkins2ToolStripMenuItem.Text = "rēkins bez daudzumiem";
            rēkins2ToolStripMenuItem.Click += rēkins2ToolStripMenuItem_Click;
            // 
            // rēķinsArDaudzumiemToolStripMenuItem
            // 
            rēķinsArDaudzumiemToolStripMenuItem.Name = "rēķinsArDaudzumiemToolStripMenuItem";
            rēķinsArDaudzumiemToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            rēķinsArDaudzumiemToolStripMenuItem.Text = "rēķins ar daudzumiem";
            rēķinsArDaudzumiemToolStripMenuItem.Click += rēķinsArDaudzumiemToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // pavadzīmeToolStripMenuItem
            // 
            pavadzīmeToolStripMenuItem.Name = "pavadzīmeToolStripMenuItem";
            pavadzīmeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            pavadzīmeToolStripMenuItem.Text = "pavadzīme";
            pavadzīmeToolStripMenuItem.Click += pavadzīmeToolStripMenuItem_Click;
            // 
            // tsbIeraksti
            // 
            tsbIeraksti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbIeraksti.Image = (System.Drawing.Image)resources.GetObject("tsbIeraksti.Image");
            tsbIeraksti.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbIeraksti.Name = "tsbIeraksti";
            tsbIeraksti.Size = new System.Drawing.Size(120, 21);
            tsbIeraksti.Text = "Ierakstu žurnāls";
            tsbIeraksti.Click += tsbIeraksti_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsData";
            myAdapterManager1.TableNames = new string[]
    {
    "OPSd",
    "OPS",
    "AcP21",
    "Persons",
    null
    };
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Save1.png");
            imageList1.Images.SetKeyName(1, "Save2.png");
            // 
            // Form_Docs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            CausesValidation = false;
            ClientSize = new System.Drawing.Size(1284, 442);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(bnavNav);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MyToolStrip = toolStrip1;
            Name = "Form_Docs";
            Text = "Dokumentu reģistrs";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FormDocs_FormClosing;
            FormClosed += FormDocs_FormClosed;
            Load += FormDocs_Load;
            Shown += Form_Docs_Shown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOPSd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOps).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavNav).EndInit();
            bnavNav.ResumeLayout(false);
            bnavNav.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsOPSd;
        private MyBindingNavigator bnavNav;
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
        private System.Windows.Forms.ToolStripButton oPSdBindingNavigatorSaveItem;
        private MyBindingSource2 bsOPS;
        private KlonsLIB.Components.MySplitContainer splitContainer1;
        private MyDataGridView dgvDocs;
        private MyDataGridView dgvOps;
        private MyBindingSource bsClid;
        private MyBindingSource bsClid2;
        private MyBindingSource bsDocTyp;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton ToolStripButtonCopy;
        private System.Windows.Forms.MenuStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbIeraksti;
        private System.Windows.Forms.ToolStripMenuItem tbsRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem kaseiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasesIeņēmumuOrderisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kasesIzdevumuOrderisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kasesIeņēmumuOrderaKvītsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasesIzdevumuOrderaKvītsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem rēķiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vienkārssRēķinsToolStripMenuItem;
        private MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripButton tsbSearchPrev;
        private System.Windows.Forms.ToolStripTextBox tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchNext;
        private System.Windows.Forms.ToolStripMenuItem rēkins2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rēķinsArDaudzumiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pavadzīmeToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsAC25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsSummC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsCur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsQV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOpsNL;
        private System.Windows.Forms.ToolStripTextBox tsbSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsZNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDate;
        private MyDgvMcCBColumn dgcDocsDocTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDocSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDocNr;
        private MyDgvMcCBColumn dgcDocsClid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsPVN;
        private MyDgvMcCBColumn dgcDocsClid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsNrx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsZU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsZDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsNL;
    }
}