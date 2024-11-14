using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_BilancesFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BilancesFormula));
            MyMcComboBox.MyItem myItem1 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem2 = new MyMcComboBox.MyItem();
            bsBalA1 = new MyBindingSource(components);
            bsBalA2 = new MyBindingSource2(components);
            bsBalA3 = new MyBindingSource2(components);
            bnavBalsA1 = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tslbActiveTable = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            kopētAtskaitesFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mainītAtskaitesKoduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pārbaudītFormulasBilanceiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pārbaudītFormulasPZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dgvBalA1 = new MyDataGridView();
            dgcBalA1balid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA1TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA1TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvBalA2 = new MyDataGridView();
            dgcBalA2id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2balid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2tp = new MyDgvMcCBColumn();
            dgcBalA2Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2nr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2nr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2S1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA2S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvBalA3 = new MyDataGridView();
            dgcBalA3tp = new MyDgvMcCBColumn();
            dgcBalA3ac = new MyDgvMcCBColumn();
            bsAC = new MyBindingSource(components);
            dgcBalA3id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBalA3id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            myAdapterManager1 = new MyAdapterManager();
            cbReportPart = new MyMcFlatComboBox();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbRowTo = new MyTextBox();
            tbRowFrom = new MyTextBox();
            panel2 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            tbKNr = new MyTextBox();
            ((System.ComponentModel.ISupportInitialize)bsBalA1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBalA2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBalA3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavBalsA1).BeginInit();
            bnavBalsA1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalA1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bsBalA1
            // 
            bsBalA1.DataMember = "BalA1";
            bsBalA1.MyDataSource = "KlonsData";
            bsBalA1.Name2 = "bsBalA1";
            bsBalA1.Sort = "balid";
            bsBalA1.MyItemRemoved += bsBalA1_MyItemRemoved;
            bsBalA1.CurrentChanged += bsBalA1_CurrentChanged;
            bsBalA1.ListChanged += bsBalA1_ListChanged;
            // 
            // bsBalA2
            // 
            bsBalA2.DataMember = "FK_BALA2_BALID_BALA1_BALID";
            bsBalA2.DataSource = bsBalA1;
            bsBalA2.Name2 = "bsBalA2";
            bsBalA2.Sort = "nr";
            bsBalA2.MyBeforeRowInsert += bsBalA2_MyBeforeRowInsert;
            bsBalA2.CurrentChanged += bsBalA2_CurrentChanged;
            bsBalA2.CurrentItemChanged += bsBalA2_CurrentItemChanged;
            bsBalA2.ListChanged += bsBalA2_ListChanged;
            // 
            // bsBalA3
            // 
            bsBalA3.DataMember = "FK_BALA3_ID2_BALA2_ID";
            bsBalA3.DataSource = bsBalA2;
            bsBalA3.Name2 = "bsBalA3";
            bsBalA3.Sort = "ac";
            bsBalA3.MyBeforeRowInsert += bsBalA3_MyBeforeRowInsert;
            bsBalA3.ListChanged += bsBalA3_ListChanged;
            // 
            // bnavBalsA1
            // 
            bnavBalsA1.AddNewItem = bindingNavigatorAddNewItem;
            bnavBalsA1.BindingSource = bsBalA1;
            bnavBalsA1.CountItem = bindingNavigatorCountItem;
            bnavBalsA1.CountItemFormat = " no {0}";
            bnavBalsA1.DeleteItem = null;
            bnavBalsA1.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavBalsA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavBalsA1.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnavBalsA1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslbActiveTable, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave, toolStripButton1, toolStripDropDownButton1 });
            bnavBalsA1.Location = new System.Drawing.Point(0, 372);
            bnavBalsA1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavBalsA1.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavBalsA1.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavBalsA1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavBalsA1.Name = "bnavBalsA1";
            bnavBalsA1.PositionItem = bindingNavigatorPositionItem;
            bnavBalsA1.SaveItem = null;
            bnavBalsA1.Size = new System.Drawing.Size(606, 28);
            bnavBalsA1.TabIndex = 11;
            bnavBalsA1.Text = "bindingNavigator1";
            bnavBalsA1.ItemDeleting += bnavBalsA1_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 25);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Pievienot ierakstu";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 25);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tslbActiveTable
            // 
            tslbActiveTable.Name = "tslbActiveTable";
            tslbActiveTable.Size = new System.Drawing.Size(69, 25);
            tslbActiveTable.Text = "Atskaites:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
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
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 23);
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
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 25);
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.information1;
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(25, 25);
            toolStripButton1.Text = "Info";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { kopētAtskaitesFormuToolStripMenuItem, mainītAtskaitesKoduToolStripMenuItem, pārbaudītFormulasBilanceiToolStripMenuItem, pārbaudītFormulasPZAToolStripMenuItem });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(73, 25);
            toolStripDropDownButton1.Text = "Ko darīt!";
            // 
            // kopētAtskaitesFormuToolStripMenuItem
            // 
            kopētAtskaitesFormuToolStripMenuItem.Name = "kopētAtskaitesFormuToolStripMenuItem";
            kopētAtskaitesFormuToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            kopētAtskaitesFormuToolStripMenuItem.Text = "Kopēt atskaites formu";
            kopētAtskaitesFormuToolStripMenuItem.Click += kopētAtskaitesFormuToolStripMenuItem_Click;
            // 
            // mainītAtskaitesKoduToolStripMenuItem
            // 
            mainītAtskaitesKoduToolStripMenuItem.Name = "mainītAtskaitesKoduToolStripMenuItem";
            mainītAtskaitesKoduToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            mainītAtskaitesKoduToolStripMenuItem.Text = "Mainīt atskaites kodu";
            mainītAtskaitesKoduToolStripMenuItem.Click += mainītAtskaitesKoduToolStripMenuItem_Click;
            // 
            // pārbaudītFormulasBilanceiToolStripMenuItem
            // 
            pārbaudītFormulasBilanceiToolStripMenuItem.Name = "pārbaudītFormulasBilanceiToolStripMenuItem";
            pārbaudītFormulasBilanceiToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            pārbaudītFormulasBilanceiToolStripMenuItem.Text = "Pārbaudīt formulas bilancei";
            pārbaudītFormulasBilanceiToolStripMenuItem.Click += pārbaudītFormulasBilanceiToolStripMenuItem_Click;
            // 
            // pārbaudītFormulasPZAToolStripMenuItem
            // 
            pārbaudītFormulasPZAToolStripMenuItem.Name = "pārbaudītFormulasPZAToolStripMenuItem";
            pārbaudītFormulasPZAToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            pārbaudītFormulasPZAToolStripMenuItem.Text = "Pārbaudīt formulas PZA";
            pārbaudītFormulasPZAToolStripMenuItem.Click += pārbaudītFormulasPZAToolStripMenuItem_Click;
            // 
            // dgvBalA1
            // 
            dgvBalA1.AutoGenerateColumns = false;
            dgvBalA1.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvBalA1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalA1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcBalA1balid, dataGridViewTextBoxColumn2, dgcBalA1TA, dgcBalA1TP });
            dgvBalA1.DataSource = bsBalA1;
            dgvBalA1.Location = new System.Drawing.Point(0, 0);
            dgvBalA1.Margin = new System.Windows.Forms.Padding(2);
            dgvBalA1.Name = "dgvBalA1";
            dgvBalA1.Size = new System.Drawing.Size(601, 140);
            dgvBalA1.TabIndex = 0;
            dgvBalA1.MyKeyDown += dgvBalA1_MyKeyDown;
            dgvBalA1.CurrentCellChanged += dgvBalA1_CurrentCellChanged;
            dgvBalA1.UserDeletingRow += dgvBalA1_UserDeletingRow;
            dgvBalA1.Enter += dgvBalA1_Enter;
            dgvBalA1.Leave += dgvBalA1_Leave;
            // 
            // dgcBalA1balid
            // 
            dgcBalA1balid.DataPropertyName = "balid";
            dgcBalA1balid.HeaderText = "kods";
            dgcBalA1balid.Name = "dgcBalA1balid";
            dgcBalA1balid.ToolTipText = "Atskaites kods (B1, PZA1, utml.)";
            dgcBalA1balid.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Descr";
            dataGridViewTextBoxColumn2.HeaderText = "apraksts";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ToolTipText = "Apraksts";
            dataGridViewTextBoxColumn2.Width = 240;
            // 
            // dgcBalA1TA
            // 
            dgcBalA1TA.DataPropertyName = "TA";
            dgcBalA1TA.HeaderText = "nosaukums1";
            dgcBalA1TA.Name = "dgcBalA1TA";
            dgcBalA1TA.ToolTipText = "Nosaukums atskaites aktīva pusei";
            dgcBalA1TA.Width = 112;
            // 
            // dgcBalA1TP
            // 
            dgcBalA1TP.DataPropertyName = "TP";
            dgcBalA1TP.HeaderText = "nosaukums2";
            dgcBalA1TP.Name = "dgcBalA1TP";
            dgcBalA1TP.ToolTipText = "Nosaukums atskaites pasīva pusei";
            dgcBalA1TP.Width = 112;
            // 
            // dgvBalA2
            // 
            dgvBalA2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvBalA2.AutoGenerateColumns = false;
            dgvBalA2.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvBalA2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalA2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcBalA2id, dgcBalA2nr, dgcBalA2balid, dgcBalA2dc, dgcBalA2tp, dgcBalA2Descr, dgcBalA2nr1, dgcBalA2nr2, dgcBalA2S1, dgcBalA2S2 });
            dgvBalA2.DataSource = bsBalA2;
            dgvBalA2.Location = new System.Drawing.Point(0, 170);
            dgvBalA2.Margin = new System.Windows.Forms.Padding(2);
            dgvBalA2.Name = "dgvBalA2";
            dgvBalA2.Size = new System.Drawing.Size(420, 203);
            dgvBalA2.TabIndex = 1;
            dgvBalA2.MyKeyDown += dgvBalA1_MyKeyDown;
            dgvBalA2.CurrentCellChanged += dgvBalA2_CurrentCellChanged;
            dgvBalA2.DefaultValuesNeeded += dgvBalA2_DefaultValuesNeeded;
            dgvBalA2.UserDeletingRow += dgvBalA1_UserDeletingRow;
            dgvBalA2.Enter += dgvBalA2_Enter;
            dgvBalA2.Leave += dgvBalA2_Leave;
            // 
            // dgcBalA2id
            // 
            dgcBalA2id.DataPropertyName = "id";
            dgcBalA2id.HeaderText = "id";
            dgcBalA2id.Name = "dgcBalA2id";
            dgcBalA2id.ReadOnly = true;
            dgcBalA2id.Visible = false;
            dgcBalA2id.Width = 40;
            // 
            // dgcBalA2nr
            // 
            dgcBalA2nr.DataPropertyName = "nr";
            dgcBalA2nr.HeaderText = "nr.";
            dgcBalA2nr.Name = "dgcBalA2nr";
            dgcBalA2nr.ToolTipText = "Rindas numurs";
            dgcBalA2nr.Width = 48;
            // 
            // dgcBalA2balid
            // 
            dgcBalA2balid.DataPropertyName = "balid";
            dgcBalA2balid.HeaderText = "balid";
            dgcBalA2balid.Name = "dgcBalA2balid";
            dgcBalA2balid.Visible = false;
            dgcBalA2balid.Width = 64;
            // 
            // dgcBalA2dc
            // 
            dgcBalA2dc.DataPropertyName = "dc";
            dgcBalA2dc.HeaderText = "dc";
            dgcBalA2dc.Name = "dgcBalA2dc";
            dgcBalA2dc.Visible = false;
            dgcBalA2dc.Width = 64;
            // 
            // dgcBalA2tp
            // 
            dgcBalA2tp.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcBalA2tp.ColumnWidths = "50;100";
            dgcBalA2tp.DataPropertyName = "tp";
            dgcBalA2tp.DisplayMember = "col1";
            dgcBalA2tp.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            dgcBalA2tp.HeaderText = "veids";
            dgcBalA2tp.ItemStrings = new string[]
    {
    "V;Virsraksts",
    "S;Kontu summējums",
    "K;Rindu summa"
    };
            dgcBalA2tp.MaxDropDownItems = 15;
            dgcBalA2tp.Name = "dgcBalA2tp";
            dgcBalA2tp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcBalA2tp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcBalA2tp.ToolTipText = "Rindas veids";
            dgcBalA2tp.ValueMember = "col1";
            dgcBalA2tp.Width = 48;
            // 
            // dgcBalA2Descr
            // 
            dgcBalA2Descr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dgcBalA2Descr.DataPropertyName = "Descr";
            dgcBalA2Descr.HeaderText = "apraksts";
            dgcBalA2Descr.Name = "dgcBalA2Descr";
            dgcBalA2Descr.Width = 87;
            // 
            // dgcBalA2nr1
            // 
            dgcBalA2nr1.DataPropertyName = "nr1";
            dgcBalA2nr1.HeaderText = "nr1";
            dgcBalA2nr1.Name = "dgcBalA2nr1";
            dgcBalA2nr1.Visible = false;
            dgcBalA2nr1.Width = 40;
            // 
            // dgcBalA2nr2
            // 
            dgcBalA2nr2.DataPropertyName = "nr2";
            dgcBalA2nr2.HeaderText = "nr2";
            dgcBalA2nr2.Name = "dgcBalA2nr2";
            dgcBalA2nr2.Visible = false;
            dgcBalA2nr2.Width = 40;
            // 
            // dgcBalA2S1
            // 
            dgcBalA2S1.DataPropertyName = "S1";
            dgcBalA2S1.HeaderText = "S1";
            dgcBalA2S1.Name = "dgcBalA2S1";
            dgcBalA2S1.Visible = false;
            dgcBalA2S1.Width = 80;
            // 
            // dgcBalA2S2
            // 
            dgcBalA2S2.DataPropertyName = "S2";
            dgcBalA2S2.HeaderText = "S2";
            dgcBalA2S2.Name = "dgcBalA2S2";
            dgcBalA2S2.Visible = false;
            dgcBalA2S2.Width = 80;
            // 
            // dgvBalA3
            // 
            dgvBalA3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            dgvBalA3.AutoGenerateColumns = false;
            dgvBalA3.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvBalA3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalA3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcBalA3tp, dgcBalA3ac, dgcBalA3id, dgcBalA3id2 });
            dgvBalA3.DataSource = bsBalA3;
            dgvBalA3.Location = new System.Drawing.Point(425, 170);
            dgvBalA3.Margin = new System.Windows.Forms.Padding(2);
            dgvBalA3.Name = "dgvBalA3";
            dgvBalA3.Size = new System.Drawing.Size(176, 202);
            dgvBalA3.TabIndex = 2;
            dgvBalA3.MyKeyDown += dgvBalA1_MyKeyDown;
            dgvBalA3.DefaultValuesNeeded += dgvBalA3_DefaultValuesNeeded;
            dgvBalA3.UserDeletingRow += dgvBalA1_UserDeletingRow;
            dgvBalA3.Enter += dgvBalA3_Enter;
            // 
            // dgcBalA3tp
            // 
            dgcBalA3tp.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcBalA3tp.ColumnWidths = "50;100";
            dgcBalA3tp.DataPropertyName = "tp";
            dgcBalA3tp.DisplayMember = "col1";
            dgcBalA3tp.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            dgcBalA3tp.HeaderText = "veids";
            dgcBalA3tp.ItemStrings = new string[]
    {
    "Db;Debetā",
    "Kr;Kredītā"
    };
            dgcBalA3tp.MaxDropDownItems = 15;
            dgcBalA3tp.Name = "dgcBalA3tp";
            dgcBalA3tp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcBalA3tp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcBalA3tp.ValueMember = "col1";
            dgcBalA3tp.Width = 48;
            // 
            // dgcBalA3ac
            // 
            dgcBalA3ac.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            dgcBalA3ac.ColumnWidths = "80;200";
            dgcBalA3ac.DataPropertyName = "ac";
            dgcBalA3ac.DataSource = bsAC;
            dgcBalA3ac.DisplayMember = "AC";
            dgcBalA3ac.HeaderText = "konts";
            dgcBalA3ac.LimitToList = false;
            dgcBalA3ac.MaxDropDownItems = 15;
            dgcBalA3ac.Name = "dgcBalA3ac";
            dgcBalA3ac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcBalA3ac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcBalA3ac.ValueMember = "AC";
            dgcBalA3ac.Width = 64;
            // 
            // bsAC
            // 
            bsAC.DataMember = "AcP21";
            bsAC.MyDataSource = "KlonsData";
            bsAC.Sort = "AC";
            // 
            // dgcBalA3id
            // 
            dgcBalA3id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgcBalA3id.DataPropertyName = "id";
            dgcBalA3id.HeaderText = "id";
            dgcBalA3id.Name = "dgcBalA3id";
            dgcBalA3id.ReadOnly = true;
            dgcBalA3id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgcBalA3id.Visible = false;
            dgcBalA3id.Width = 40;
            // 
            // dgcBalA3id2
            // 
            dgcBalA3id2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dgcBalA3id2.DataPropertyName = "id2";
            dgcBalA3id2.HeaderText = "id2";
            dgcBalA3id2.Name = "dgcBalA3id2";
            dgcBalA3id2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            dgcBalA3id2.Visible = false;
            dgcBalA3id2.Width = 40;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsData";
            myAdapterManager1.TableNames = new string[]
    {
    "BalA1",
    "BalA2",
    "BalA3",
    null
    };
            // 
            // cbReportPart
            // 
            cbReportPart.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbReportPart.ColumnNames = new string[]
    {
    "col1"
    };
            cbReportPart.ColumnWidths = "102";
            cbReportPart.DisplayMember = "col1";
            cbReportPart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbReportPart.DropDownHeight = 144;
            cbReportPart.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbReportPart.DropDownWidth = 121;
            cbReportPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbReportPart.FormattingEnabled = true;
            cbReportPart.GridLineColor = System.Drawing.Color.LightGray;
            cbReportPart.GridLineHorizontal = false;
            cbReportPart.GridLineVertical = false;
            cbReportPart.IntegralHeight = false;
            myItem1.Col1 = "Aktīvs";
            myItem2.Col1 = "Pasīvs";
            cbReportPart.Items.AddRange(new object[] { myItem1, myItem2 });
            cbReportPart.ItemStrings = new string[]
    {
    "Aktīvs",
    "Pasīvs"
    };
            cbReportPart.Location = new System.Drawing.Point(118, 145);
            cbReportPart.Margin = new System.Windows.Forms.Padding(2);
            cbReportPart.Name = "cbReportPart";
            cbReportPart.Size = new System.Drawing.Size(121, 24);
            cbReportPart.TabIndex = 7;
            cbReportPart.ValueMember = "col1";
            cbReportPart.SelectedIndexChanged += cbReportPart_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-3, 147);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 17);
            label2.TabIndex = 9;
            label2.Text = "Atskaites sadaļa:";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbRowTo);
            panel1.Controls.Add(tbRowFrom);
            panel1.Location = new System.Drawing.Point(433, 198);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(121, 82);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 58);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(33, 17);
            label6.TabIndex = 2;
            label6.Text = "līdz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 29);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(28, 17);
            label5.TabIndex = 1;
            label5.Text = "no:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 7);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 17);
            label3.TabIndex = 0;
            label3.Text = "Summēt rindas:";
            // 
            // tbRowTo
            // 
            tbRowTo.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRowTo.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsBalA2, "nr2", true));
            tbRowTo.Location = new System.Drawing.Point(44, 56);
            tbRowTo.Margin = new System.Windows.Forms.Padding(2);
            tbRowTo.Name = "tbRowTo";
            tbRowTo.Size = new System.Drawing.Size(67, 23);
            tbRowTo.TabIndex = 4;
            // 
            // tbRowFrom
            // 
            tbRowFrom.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbRowFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsBalA2, "nr1", true));
            tbRowFrom.Location = new System.Drawing.Point(44, 27);
            tbRowFrom.Margin = new System.Windows.Forms.Padding(2);
            tbRowFrom.Name = "tbRowFrom";
            tbRowFrom.Size = new System.Drawing.Size(67, 23);
            tbRowFrom.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tbKNr);
            panel2.Location = new System.Drawing.Point(425, 58);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(154, 94);
            panel2.TabIndex = 11;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(6, 7);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(139, 54);
            label7.TabIndex = 0;
            label7.Text = "Kopsummas rinda, kas saistīta ar virsrakstu:";
            // 
            // tbKNr
            // 
            tbKNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbKNr.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsBalA2, "nr1", true));
            tbKNr.Location = new System.Drawing.Point(78, 64);
            tbKNr.Margin = new System.Windows.Forms.Padding(2);
            tbKNr.Name = "tbKNr";
            tbKNr.Size = new System.Drawing.Size(67, 23);
            tbKNr.TabIndex = 4;
            // 
            // Form_BilancesFormula
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(606, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cbReportPart);
            Controls.Add(dgvBalA3);
            Controls.Add(dgvBalA2);
            Controls.Add(label2);
            Controls.Add(dgvBalA1);
            Controls.Add(bnavBalsA1);
            MinimumSize = new System.Drawing.Size(8, 416);
            Name = "Form_BilancesFormula";
            Text = "Bilances atskaišu formulas";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += Form_Bilance_Load;
            ((System.ComponentModel.ISupportInitialize)bsBalA1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBalA2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBalA3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavBalsA1).EndInit();
            bnavBalsA1.ResumeLayout(false);
            bnavBalsA1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBalA1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalA3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsBalA1;
        private MyBindingNavigator bnavBalsA1;
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
        private MyDataGridView dgvBalA1;
        private MyDataGridView dgvBalA2;
        private MyBindingSource2 bsBalA2;
        private MyBindingSource2 bsBalA3;
        private MyDataGridView dgvBalA3;
        private MyAdapterManager myAdapterManager1;
        private MyMcFlatComboBox cbReportPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel tslbActiveTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private MyTextBox tbRowTo;
        private MyTextBox tbRowFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1balid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA1TP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MyBindingSource bsAC;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mainītAtskaitesKoduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pārbaudītFormulasPZAToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private MyTextBox tbKNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2balid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2dc;
        private MyDgvMcCBColumn dgcBalA2tp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2nr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2nr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2S1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA2S2;
        private System.Windows.Forms.ToolStripMenuItem kopētAtskaitesFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pārbaudītFormulasBilanceiToolStripMenuItem;
        private MyDgvMcCBColumn dgcBalA3tp;
        private MyDgvMcCBColumn dgcBalA3ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA3id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBalA3id2;
    }
}