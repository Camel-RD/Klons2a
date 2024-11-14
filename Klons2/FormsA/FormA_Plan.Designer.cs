using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_Plan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Plan));
            bsPlanuSar = new KlonsLIB.Data.MyBindingSource(components);
            bsPlans = new KlonsLIB.Data.MyBindingSource(components);
            dgvPlans = new MyDataGridView();
            dgcNPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcKind1 = new MyDgvMcCBColumn();
            dgcV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcYR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsK1 = new System.Windows.Forms.BindingSource(components);
            bnavPlans = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tslPeriod = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            cbYR = new System.Windows.Forms.ToolStripComboBox();
            cbMT = new System.Windows.Forms.ToolStripComboBox();
            myStyleDefs1 = new Classes.MyStyleDefs();
            cmsMenuMarkDay = new System.Windows.Forms.ContextMenuStrip(components);
            miDD = new System.Windows.Forms.ToolStripMenuItem();
            miBD = new System.Windows.Forms.ToolStripMenuItem();
            miSD = new System.Windows.Forms.ToolStripMenuItem();
            miDDSD = new System.Windows.Forms.ToolStripMenuItem();
            miSDDD = new System.Windows.Forms.ToolStripMenuItem();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            darbaLaikaKopplānsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            izveidotPlānaIerakstusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miFillRow = new System.Windows.Forms.ToolStripMenuItem();
            miFillList = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bsPlanuSar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPlans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsK1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavPlans).BeginInit();
            bnavPlans.SuspendLayout();
            toolStrip1.SuspendLayout();
            cmsMenuMarkDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bsPlanuSar
            // 
            bsPlanuSar.DataMember = "TIMEPLAN_LIST";
            bsPlanuSar.MyDataSource = "KlonsAData";
            // 
            // bsPlans
            // 
            bsPlans.DataMember = "TIMESHEET";
            bsPlans.Filter = "kind1=0 or kind1=1";
            bsPlans.MyDataSource = "KlonsAData";
            bsPlans.UseDataGridView = dgvPlans;
            bsPlans.ListChanged += bsPlans_ListChanged;
            // 
            // dgvPlans
            // 
            dgvPlans.AllowUserToDeleteRows = false;
            dgvPlans.AutoGenerateColumns = false;
            dgvPlans.AutoSave = false;
            dgvPlans.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcNPK, dgcIDP, dgcKind1, dgcV1, dgcV2, dgcV3, dgcV4, dgcV5, dgcV6, dgcV7, dgcV8, dgcV9, dgcV10, dgcV11, dgcV12, dgcV13, dgcV14, dgcV15, dgcV16, dgcV17, dgcV18, dgcV19, dgcV20, dgcV21, dgcV22, dgcV23, dgcV24, dgcV25, dgcV26, dgcV27, dgcV28, dgcV29, dgcV30, dgcV31, dgcK1, dgcID, dgcYR, dgcMT });
            dgvPlans.DataSource = bsPlans;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvPlans.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPlans.Location = new System.Drawing.Point(0, 30);
            dgvPlans.Name = "dgvPlans";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPlans.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPlans.Size = new System.Drawing.Size(816, 308);
            dgvPlans.TabIndex = 7;
            dgvPlans.UseMyContextmenu = false;
            dgvPlans.MyKeyDown += dgvPlans_MyKeyDown;
            dgvPlans.MyCheckForChanges += dgvPlans_MyCheckForChanges;
            dgvPlans.CellBeginEdit += dgvPlans_CellBeginEdit;
            dgvPlans.CellContextMenuStripNeeded += dgvPlans_CellContextMenuStripNeeded;
            dgvPlans.CellDoubleClick += dgvPlans_CellDoubleClick;
            dgvPlans.CellEndEdit += dgvPlans_CellEndEdit;
            dgvPlans.CellFormatting += dgvPlans_CellFormatting;
            dgvPlans.CellParsing += dgvPlans_CellParsing;
            dgvPlans.DefaultValuesNeeded += dgvPlans_DefaultValuesNeeded;
            dgvPlans.EditingControlShowing += dgvPlans_EditingControlShowing;
            dgvPlans.UserDeletingRow += dgvPlans_UserDeletingRow;
            // 
            // dgcNPK
            // 
            dgcNPK.DataPropertyName = "SNR";
            dgcNPK.Frozen = true;
            dgcNPK.HeaderText = "npk.";
            dgcNPK.Name = "dgcNPK";
            dgcNPK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            dgcNPK.Width = 40;
            // 
            // dgcIDP
            // 
            dgcIDP.DataPropertyName = "IDP";
            dgcIDP.DataSource = bsPlanuSar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgcIDP.DefaultCellStyle = dataGridViewCellStyle2;
            dgcIDP.DisplayMember = "DESCR";
            dgcIDP.DisplayStyleForCurrentCellOnly = true;
            dgcIDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIDP.Frozen = true;
            dgcIDP.HeaderText = "plāns";
            dgcIDP.Name = "dgcIDP";
            dgcIDP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            dgcIDP.ValueMember = "ID";
            dgcIDP.Width = 140;
            // 
            // dgcKind1
            // 
            dgcKind1.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcKind1.ColumnWidths = "0;80";
            dgcKind1.DataPropertyName = "KIND1";
            dgcKind1.DisplayMember = "col2";
            dgcKind1.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            dgcKind1.Frozen = true;
            dgcKind1.HeaderText = "veids";
            dgcKind1.ItemStrings = new string[]
    {
    "0;diena",
    "1;nakts"
    };
            dgcKind1.MaxDropDownItems = 15;
            dgcKind1.Name = "dgcKind1";
            dgcKind1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcKind1.ValueMember = "col1";
            dgcKind1.Width = 80;
            // 
            // dgcV1
            // 
            dgcV1.DataPropertyName = "V1";
            dgcV1.HeaderText = "1";
            dgcV1.Name = "dgcV1";
            dgcV1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV1.Width = 40;
            // 
            // dgcV2
            // 
            dgcV2.DataPropertyName = "V2";
            dgcV2.HeaderText = "2";
            dgcV2.Name = "dgcV2";
            dgcV2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV2.Width = 40;
            // 
            // dgcV3
            // 
            dgcV3.DataPropertyName = "V3";
            dgcV3.HeaderText = "3";
            dgcV3.Name = "dgcV3";
            dgcV3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV3.Width = 40;
            // 
            // dgcV4
            // 
            dgcV4.DataPropertyName = "V4";
            dgcV4.HeaderText = "4";
            dgcV4.Name = "dgcV4";
            dgcV4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV4.Width = 40;
            // 
            // dgcV5
            // 
            dgcV5.DataPropertyName = "V5";
            dgcV5.HeaderText = "5";
            dgcV5.Name = "dgcV5";
            dgcV5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV5.Width = 40;
            // 
            // dgcV6
            // 
            dgcV6.DataPropertyName = "V6";
            dgcV6.HeaderText = "6";
            dgcV6.Name = "dgcV6";
            dgcV6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV6.Width = 40;
            // 
            // dgcV7
            // 
            dgcV7.DataPropertyName = "V7";
            dgcV7.HeaderText = "7";
            dgcV7.Name = "dgcV7";
            dgcV7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV7.Width = 40;
            // 
            // dgcV8
            // 
            dgcV8.DataPropertyName = "V8";
            dgcV8.HeaderText = "8";
            dgcV8.Name = "dgcV8";
            dgcV8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV8.Width = 40;
            // 
            // dgcV9
            // 
            dgcV9.DataPropertyName = "V9";
            dgcV9.HeaderText = "9";
            dgcV9.Name = "dgcV9";
            dgcV9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV9.Width = 40;
            // 
            // dgcV10
            // 
            dgcV10.DataPropertyName = "V10";
            dgcV10.HeaderText = "10";
            dgcV10.Name = "dgcV10";
            dgcV10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV10.Width = 40;
            // 
            // dgcV11
            // 
            dgcV11.DataPropertyName = "V11";
            dgcV11.HeaderText = "11";
            dgcV11.Name = "dgcV11";
            dgcV11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV11.Width = 40;
            // 
            // dgcV12
            // 
            dgcV12.DataPropertyName = "V12";
            dgcV12.HeaderText = "12";
            dgcV12.Name = "dgcV12";
            dgcV12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV12.Width = 40;
            // 
            // dgcV13
            // 
            dgcV13.DataPropertyName = "V13";
            dgcV13.HeaderText = "13";
            dgcV13.Name = "dgcV13";
            dgcV13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV13.Width = 40;
            // 
            // dgcV14
            // 
            dgcV14.DataPropertyName = "V14";
            dgcV14.HeaderText = "14";
            dgcV14.Name = "dgcV14";
            dgcV14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV14.Width = 40;
            // 
            // dgcV15
            // 
            dgcV15.DataPropertyName = "V15";
            dgcV15.HeaderText = "15";
            dgcV15.Name = "dgcV15";
            dgcV15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV15.Width = 40;
            // 
            // dgcV16
            // 
            dgcV16.DataPropertyName = "V16";
            dgcV16.HeaderText = "16";
            dgcV16.Name = "dgcV16";
            dgcV16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV16.Width = 40;
            // 
            // dgcV17
            // 
            dgcV17.DataPropertyName = "V17";
            dgcV17.HeaderText = "17";
            dgcV17.Name = "dgcV17";
            dgcV17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV17.Width = 40;
            // 
            // dgcV18
            // 
            dgcV18.DataPropertyName = "V18";
            dgcV18.HeaderText = "18";
            dgcV18.Name = "dgcV18";
            dgcV18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV18.Width = 40;
            // 
            // dgcV19
            // 
            dgcV19.DataPropertyName = "V19";
            dgcV19.HeaderText = "19";
            dgcV19.Name = "dgcV19";
            dgcV19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV19.Width = 40;
            // 
            // dgcV20
            // 
            dgcV20.DataPropertyName = "V20";
            dgcV20.HeaderText = "20";
            dgcV20.Name = "dgcV20";
            dgcV20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV20.Width = 40;
            // 
            // dgcV21
            // 
            dgcV21.DataPropertyName = "V21";
            dgcV21.HeaderText = "21";
            dgcV21.Name = "dgcV21";
            dgcV21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV21.Width = 40;
            // 
            // dgcV22
            // 
            dgcV22.DataPropertyName = "V22";
            dgcV22.HeaderText = "22";
            dgcV22.Name = "dgcV22";
            dgcV22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV22.Width = 40;
            // 
            // dgcV23
            // 
            dgcV23.DataPropertyName = "V23";
            dgcV23.HeaderText = "23";
            dgcV23.Name = "dgcV23";
            dgcV23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV23.Width = 40;
            // 
            // dgcV24
            // 
            dgcV24.DataPropertyName = "V24";
            dgcV24.HeaderText = "24";
            dgcV24.Name = "dgcV24";
            dgcV24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV24.Width = 40;
            // 
            // dgcV25
            // 
            dgcV25.DataPropertyName = "V25";
            dgcV25.HeaderText = "25";
            dgcV25.Name = "dgcV25";
            dgcV25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV25.Width = 40;
            // 
            // dgcV26
            // 
            dgcV26.DataPropertyName = "V26";
            dgcV26.HeaderText = "26";
            dgcV26.Name = "dgcV26";
            dgcV26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV26.Width = 40;
            // 
            // dgcV27
            // 
            dgcV27.DataPropertyName = "V27";
            dgcV27.HeaderText = "27";
            dgcV27.Name = "dgcV27";
            dgcV27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV27.Width = 40;
            // 
            // dgcV28
            // 
            dgcV28.DataPropertyName = "V28";
            dgcV28.HeaderText = "28";
            dgcV28.Name = "dgcV28";
            dgcV28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV28.Width = 40;
            // 
            // dgcV29
            // 
            dgcV29.DataPropertyName = "V29";
            dgcV29.HeaderText = "29";
            dgcV29.Name = "dgcV29";
            dgcV29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV29.Width = 40;
            // 
            // dgcV30
            // 
            dgcV30.DataPropertyName = "V30";
            dgcV30.HeaderText = "30";
            dgcV30.Name = "dgcV30";
            dgcV30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV30.Width = 40;
            // 
            // dgcV31
            // 
            dgcV31.DataPropertyName = "V31";
            dgcV31.HeaderText = "31";
            dgcV31.Name = "dgcV31";
            dgcV31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV31.Width = 40;
            // 
            // dgcK1
            // 
            dgcK1.DataPropertyName = "K1";
            dgcK1.HeaderText = "Σ";
            dgcK1.Name = "dgcK1";
            dgcK1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcK1.Width = 60;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            dgcID.Width = 40;
            // 
            // dgcYR
            // 
            dgcYR.DataPropertyName = "YR";
            dgcYR.HeaderText = "YR";
            dgcYR.Name = "dgcYR";
            dgcYR.Visible = false;
            dgcYR.Width = 50;
            // 
            // dgcMT
            // 
            dgcMT.DataPropertyName = "MT";
            dgcMT.HeaderText = "MT";
            dgcMT.Name = "dgcMT";
            dgcMT.Visible = false;
            dgcMT.Width = 40;
            // 
            // bnavPlans
            // 
            bnavPlans.AddNewItem = bindingNavigatorAddNewItem;
            bnavPlans.BindingSource = bsPlans;
            bnavPlans.CountItem = bindingNavigatorCountItem;
            bnavPlans.CountItemFormat = " no {0}";
            bnavPlans.DataGrid = dgvPlans;
            bnavPlans.DeleteItem = null;
            bnavPlans.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavPlans.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnavPlans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavPlans.Location = new System.Drawing.Point(0, 338);
            bnavPlans.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavPlans.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavPlans.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavPlans.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavPlans.Name = "bnavPlans";
            bnavPlans.PositionItem = bindingNavigatorPositionItem;
            bnavPlans.SaveItem = null;
            bnavPlans.Size = new System.Drawing.Size(816, 28);
            bnavPlans.TabIndex = 1;
            bnavPlans.Text = "myBindingNavigator1";
            bnavPlans.ItemDeleting += bnavPlans_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 25);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 25);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 25);
            tsbSave.Text = "toolStripButton1";
            tsbSave.Click += tsbSave_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslPeriod, toolStripLabel1, toolStripLabel2, cbYR, cbMT });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new System.Drawing.Size(816, 30);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslPeriod
            // 
            tslPeriod.Name = "tslPeriod";
            tslPeriod.Size = new System.Drawing.Size(60, 27);
            tslPeriod.Text = "Periods:";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(16, 27);
            toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(105, 27);
            toolStripLabel2.Text = "  atvērt mēnesi:";
            // 
            // cbYR
            // 
            cbYR.AutoSize = false;
            cbYR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbYR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cbYR.Items.AddRange(new object[] { "2014", "2015", "2016", "2017", "2018", "2019", "2020" });
            cbYR.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            cbYR.MaxLength = 4;
            cbYR.Name = "cbYR";
            cbYR.Size = new System.Drawing.Size(60, 24);
            cbYR.ToolTipText = "gads";
            cbYR.SelectedIndexChanged += cbYRMT_SelectedIndexChanged;
            // 
            // cbMT
            // 
            cbMT.AutoSize = false;
            cbMT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cbMT.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cbMT.MaxDropDownItems = 12;
            cbMT.Name = "cbMT";
            cbMT.Size = new System.Drawing.Size(50, 24);
            cbMT.ToolTipText = "mēnesis";
            cbMT.SelectedIndexChanged += cbYRMT_SelectedIndexChanged;
            // 
            // myStyleDefs1
            // 
            myStyleDefs1.FreeDayBack = System.Drawing.Color.LightBlue;
            myStyleDefs1.FreeDayFore = System.Drawing.Color.White;
            myStyleDefs1.HeaderHolyDayBack = System.Drawing.Color.FromArgb(181, 113, 0);
            myStyleDefs1.HeaderHolyDayFore = System.Drawing.Color.White;
            myStyleDefs1.HeaderWeekEndBack = System.Drawing.Color.FromArgb(2, 62, 106);
            myStyleDefs1.HeaderWeekEndFore = System.Drawing.Color.White;
            myStyleDefs1.HolyDayBack = System.Drawing.Color.LightBlue;
            myStyleDefs1.HolyDayFore = System.Drawing.Color.White;
            myStyleDefs1.SickDayBack = System.Drawing.Color.IndianRed;
            myStyleDefs1.SickDayFore = System.Drawing.Color.White;
            myStyleDefs1.VacationBack = System.Drawing.Color.YellowGreen;
            myStyleDefs1.VacationFore = System.Drawing.Color.White;
            // 
            // cmsMenuMarkDay
            // 
            cmsMenuMarkDay.ImageScalingSize = new System.Drawing.Size(16, 16);
            cmsMenuMarkDay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miDD, miBD, miSD, miDDSD, miSDDD });
            cmsMenuMarkDay.Name = "cmsDayCodes";
            cmsMenuMarkDay.Size = new System.Drawing.Size(265, 124);
            cmsMenuMarkDay.ItemClicked += cmsMenuMarkDay_ItemClicked;
            // 
            // miDD
            // 
            miDD.Name = "miDD";
            miDD.Size = new System.Drawing.Size(264, 24);
            miDD.Text = "Darba diena";
            // 
            // miBD
            // 
            miBD.Name = "miBD";
            miBD.Size = new System.Drawing.Size(264, 24);
            miBD.Text = "B - Brīvdiena";
            // 
            // miSD
            // 
            miSD.Name = "miSD";
            miSD.Size = new System.Drawing.Size(264, 24);
            miSD.Text = "S - Svētku diena";
            // 
            // miDDSD
            // 
            miDDSD.Name = "miDDSD";
            miDDSD.Size = new System.Drawing.Size(264, 24);
            miDDSD.Text = "DS - Darba diena svētku dienā";
            // 
            // miSDDD
            // 
            miSDDD.Name = "miSDDD";
            miSDDD.Size = new System.Drawing.Size(264, 24);
            miSDDD.Text = "SD - Svētku diena darba dienā";
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "TIMESHEET_LISTS",
    "TIMESHEET_LISTS_R",
    "TIMESHEET",
    null
    };
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { darbaLaikaKopplānsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(816, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // darbaLaikaKopplānsToolStripMenuItem
            // 
            darbaLaikaKopplānsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { izveidotPlānaIerakstusToolStripMenuItem, toolStripSeparator1, miFillRow, miFillList });
            darbaLaikaKopplānsToolStripMenuItem.Name = "darbaLaikaKopplānsToolStripMenuItem";
            darbaLaikaKopplānsToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            darbaLaikaKopplānsToolStripMenuItem.Text = "Darba laika kopplāns";
            // 
            // izveidotPlānaIerakstusToolStripMenuItem
            // 
            izveidotPlānaIerakstusToolStripMenuItem.Name = "izveidotPlānaIerakstusToolStripMenuItem";
            izveidotPlānaIerakstusToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            izveidotPlānaIerakstusToolStripMenuItem.Text = "Izveidot plāna ierakstus";
            izveidotPlānaIerakstusToolStripMenuItem.Click += izveidotPlānaIerakstusToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // miFillRow
            // 
            miFillRow.Name = "miFillRow";
            miFillRow.Size = new System.Drawing.Size(262, 22);
            miFillRow.Text = "Aizpildīt no jauna rindu";
            miFillRow.Click += miFillRow_Click;
            // 
            // miFillList
            // 
            miFillList.Name = "miFillList";
            miFillList.Size = new System.Drawing.Size(262, 22);
            miFillList.Text = "Aizpildīt no jauna visas rindas";
            miFillList.Click += miFillList_Click;
            // 
            // FormA_Plan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(816, 366);
            Controls.Add(dgvPlans);
            Controls.Add(toolStrip1);
            Controls.Add(bnavPlans);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MyToolStrip = toolStrip1;
            Name = "FormA_Plan";
            Text = "Darba laika kopplāns";
            FormClosed += Form_Plans_FormClosed;
            Load += Form_Plan_Load;
            ((System.ComponentModel.ISupportInitialize)bsPlanuSar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPlans).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlans).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsK1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavPlans).EndInit();
            bnavPlans.ResumeLayout(false);
            bnavPlans.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            cmsMenuMarkDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MyBindingNavigator bnavPlans;
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
        private KlonsLIB.Data.MyBindingSource bsPlans;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Data.MyBindingSource bsPlanuSar;
        private System.Windows.Forms.BindingSource bsK1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslPeriod;
        private System.Windows.Forms.ToolStripComboBox cbYR;
        private Classes.MyStyleDefs myStyleDefs1;
        private System.Windows.Forms.ContextMenuStrip cmsMenuMarkDay;
        private System.Windows.Forms.ToolStripMenuItem miDD;
        private System.Windows.Forms.ToolStripMenuItem miBD;
        private System.Windows.Forms.ToolStripMenuItem miSD;
        private System.Windows.Forms.ToolStripMenuItem miDDSD;
        private System.Windows.Forms.ToolStripMenuItem miSDDD;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private MyDataGridView dgvPlans;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripComboBox cbMT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem darbaLaikaKopplānsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveidotPlānaIerakstusToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNPK;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIDP;
        private MyDgvMcCBColumn dgcKind1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcYR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miFillRow;
        private System.Windows.Forms.ToolStripMenuItem miFillList;
    }
}