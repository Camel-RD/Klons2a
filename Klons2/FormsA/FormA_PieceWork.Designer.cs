namespace KlonsA.Forms
{
    partial class FormA_PieceWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_PieceWork));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            cmFilter = new System.Windows.Forms.ToolStripButton();
            bnavSar = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsSar = new KlonsLIB.Data.MyBindingSource(components);
            dgvSar = new KlonsLIB.Components.MyDataGridView();
            bsAmati2 = new KlonsLIB.Data.MyBindingSource(components);
            bsKat = new KlonsLIB.Data.MyBindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            bsAmati = new KlonsLIB.Data.MyBindingSource(components);
            cbAmats = new KlonsLIB.Components.MyMcFlatComboBox();
            tbDT2 = new KlonsLIB.Components.MyTextBox();
            tbDT1 = new KlonsLIB.Components.MyTextBox();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            dgcDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcIDK = new KlonsLIB.Components.MyDgvMcComboBoxColumn();
            dgcIDKa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTimeUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcTimeUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTimeHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bnavSar).BeginInit();
            bnavSar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsSar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsKat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, cmFilter });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            toolStrip1.Size = new System.Drawing.Size(782, 26);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(60, 21);
            toolStripLabel1.Text = "Datums:";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(13, 21);
            toolStripLabel2.Text = "-";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new System.Drawing.Size(12, 21);
            toolStripLabel3.Text = " ";
            // 
            // cmFilter
            // 
            cmFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            cmFilter.Image = (System.Drawing.Image)resources.GetObject("cmFilter.Image");
            cmFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmFilter.Name = "cmFilter";
            cmFilter.Size = new System.Drawing.Size(58, 21);
            cmFilter.Text = " Atlasīt ";
            cmFilter.Click += cmFilter_Click;
            // 
            // bnavSar
            // 
            bnavSar.AddNewItem = bindingNavigatorAddNewItem;
            bnavSar.BindingSource = bsSar;
            bnavSar.CountItem = bindingNavigatorCountItem;
            bnavSar.CountItemFormat = " no {0}";
            bnavSar.DataGrid = dgvSar;
            bnavSar.DeleteItem = null;
            bnavSar.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavSar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavSar.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavSar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, toolStripButton1, bindingNavigatorDeleteItem, tsbSave });
            bnavSar.Location = new System.Drawing.Point(0, 374);
            bnavSar.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavSar.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavSar.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavSar.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavSar.Name = "bnavSar";
            bnavSar.PositionItem = bindingNavigatorPositionItem;
            bnavSar.SaveItem = null;
            bnavSar.Size = new System.Drawing.Size(782, 28);
            bnavSar.TabIndex = 1;
            bnavSar.Text = "myBindingNavigator1";
            bnavSar.ItemDeleting += bnavSar_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 25);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bsSar
            // 
            bsSar.DataMember = "PIECEWORK";
            bsSar.MyDataSource = "KlonsAData";
            bsSar.Sort = "DT,ID";
            bsSar.UseDataGridView = dgvSar;
            bsSar.ListChanged += bsSar_ListChanged;
            // 
            // dgvSar
            // 
            dgvSar.AllowUserToDeleteRows = false;
            dgvSar.AutoGenerateColumns = false;
            dgvSar.AutoSave = true;
            dgvSar.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvSar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDT, dgcIDA, dgcIDK, dgcIDKa, dgcUnit, dgcQuantity, dgcRate, dgcBonus, dgcPay, dgcTimeUnit, dgcTimeUse, dgcTimeHour, dgcID });
            dgvSar.DataSource = bsSar;
            dgvSar.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSar.Location = new System.Drawing.Point(0, 26);
            dgvSar.Name = "dgvSar";
            dgvSar.Size = new System.Drawing.Size(782, 348);
            dgvSar.TabIndex = 2;
            dgvSar.MyKeyDown += dgvSar_MyKeyDown;
            dgvSar.MyCheckForChanges += dgvSar_MyCheckForChanges;
            dgvSar.CellDoubleClick += dgvSar_CellDoubleClick;
            dgvSar.CellEndEdit += dgvSar_CellEndEdit;
            dgvSar.CellParsing += dgvSar_CellParsing;
            dgvSar.DefaultValuesNeeded += dgvSar_DefaultValuesNeeded;
            dgvSar.RowValidating += dgvSar_RowValidating;
            dgvSar.UserDeletingRow += dgvSar_UserDeletingRow;
            // 
            // bsAmati2
            // 
            bsAmati2.DataMember = "POSITIONS";
            bsAmati2.MyDataSource = "KlonsAData";
            bsAmati2.Sort = "YNAME";
            // 
            // bsKat
            // 
            bsKat.DataMember = "PIECEWORK_CATALOG";
            bsKat.MyDataSource = "KlonsAData";
            bsKat.Sort = "KATCODE,ID";
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
            // toolStripButton1
            // 
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(70, 25);
            toolStripButton1.Text = "Kopēt";
            toolStripButton1.Click += toolStripButton1_Click;
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
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // bsAmati
            // 
            bsAmati.DataMember = "POSITIONS";
            bsAmati.Filter = "USED = 1";
            bsAmati.MyDataSource = "KlonsAData";
            bsAmati.Sort = "YNAME";
            // 
            // cbAmats
            // 
            cbAmats.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAmats.ColumnNames = new string[]
    {
    "ID",
    "YNAME"
    };
            cbAmats.ColumnWidths = "0;250";
            cbAmats.DataSource = bsAmati;
            cbAmats.DisplayMember = "YNAME";
            cbAmats.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAmats.DropDownHeight = 180;
            cbAmats.DropDownWidth = 269;
            cbAmats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAmats.FormattingEnabled = true;
            cbAmats.GridLineColor = System.Drawing.Color.LightGray;
            cbAmats.GridLineHorizontal = false;
            cbAmats.GridLineVertical = false;
            cbAmats.IntegralHeight = false;
            cbAmats.Location = new System.Drawing.Point(458, 0);
            cbAmats.MaxDropDownItems = 10;
            cbAmats.Name = "cbAmats";
            cbAmats.Size = new System.Drawing.Size(250, 24);
            cbAmats.TabIndex = 3;
            cbAmats.ValueMember = "ID";
            // 
            // tbDT2
            // 
            tbDT2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT2.IsDate = true;
            tbDT2.Location = new System.Drawing.Point(357, 1);
            tbDT2.Name = "tbDT2";
            tbDT2.Size = new System.Drawing.Size(80, 23);
            tbDT2.TabIndex = 8;
            // 
            // tbDT1
            // 
            tbDT1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT1.IsDate = true;
            tbDT1.Location = new System.Drawing.Point(260, 1);
            tbDT1.Name = "tbDT1";
            tbDT1.Size = new System.Drawing.Size(80, 23);
            tbDT1.TabIndex = 9;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "PIECEWORK",
    "PIECEWORK_CATALOG",
    "PIECEWORK_CATSTRUCT",
    null
    };
            // 
            // dgcDT
            // 
            dgcDT.DataPropertyName = "DT";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcDT.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDT.HeaderText = "datums";
            dgcDT.Name = "dgcDT";
            dgcDT.Width = 85;
            // 
            // dgcIDA
            // 
            dgcIDA.DataPropertyName = "IDA";
            dgcIDA.DataSource = bsAmati2;
            dgcIDA.DisplayMember = "YNAME";
            dgcIDA.DisplayStyleForCurrentCellOnly = true;
            dgcIDA.DropDownWidth = 300;
            dgcIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIDA.HeaderText = "darbinieks, amats";
            dgcIDA.MaxDropDownItems = 10;
            dgcIDA.Name = "dgcIDA";
            dgcIDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIDA.ValueMember = "ID";
            dgcIDA.Width = 200;
            // 
            // dgcIDK
            // 
            dgcIDK.ColumnNames = new string[]
    {
    "CODE",
    "DESCR"
    };
            dgcIDK.ColumnWidths = "80;200";
            dgcIDK.DataPropertyName = "IDK";
            dgcIDK.DataSource = bsKat;
            dgcIDK.DisplayMember = "CODE";
            dgcIDK.DisplayStyleForCurrentCellOnly = true;
            dgcIDK.HeaderText = "kods";
            dgcIDK.MaxDropDownItems = 15;
            dgcIDK.Name = "dgcIDK";
            dgcIDK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIDK.ToolTipText = "kataloga kods";
            dgcIDK.ValueMember = "ID";
            dgcIDK.Width = 80;
            // 
            // dgcIDKa
            // 
            dgcIDKa.DataPropertyName = "IDK";
            dgcIDKa.DataSource = bsKat;
            dgcIDKa.DisplayMember = "DESCR";
            dgcIDKa.DisplayStyleForCurrentCellOnly = true;
            dgcIDKa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIDKa.HeaderText = "nosaukums";
            dgcIDKa.Name = "dgcIDKa";
            dgcIDKa.ReadOnly = true;
            dgcIDKa.ValueMember = "ID";
            dgcIDKa.Width = 200;
            // 
            // dgcUnit
            // 
            dgcUnit.DataPropertyName = "UNIT";
            dgcUnit.HeaderText = "mērv.";
            dgcUnit.Name = "dgcUnit";
            dgcUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcUnit.ToolTipText = "uzskaites mērvienība";
            dgcUnit.Width = 50;
            // 
            // dgcQuantity
            // 
            dgcQuantity.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            dgcQuantity.HeaderText = "skaits";
            dgcQuantity.Name = "dgcQuantity";
            dgcQuantity.Width = 60;
            // 
            // dgcRate
            // 
            dgcRate.DataPropertyName = "RATE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N4";
            dgcRate.DefaultCellStyle = dataGridViewCellStyle4;
            dgcRate.HeaderText = "likme";
            dgcRate.Name = "dgcRate";
            dgcRate.ToolTipText = "samaksa par vienu vienību";
            dgcRate.Width = 80;
            // 
            // dgcBonus
            // 
            dgcBonus.DataPropertyName = "BONUS";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBonus.DefaultCellStyle = dataGridViewCellStyle5;
            dgcBonus.HeaderText = "piem. %";
            dgcBonus.Name = "dgcBonus";
            dgcBonus.ToolTipText = "Pimemaksa % (parvirsstundām, nakts darbu)";
            dgcBonus.Width = 50;
            // 
            // dgcPay
            // 
            dgcPay.DataPropertyName = "PAY";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N4";
            dgcPay.DefaultCellStyle = dataGridViewCellStyle6;
            dgcPay.HeaderText = "samaksa";
            dgcPay.Name = "dgcPay";
            dgcPay.ReadOnly = true;
            dgcPay.ToolTipText = "aprēķinātā samaksa";
            dgcPay.Width = 80;
            // 
            // dgcTimeUnit
            // 
            dgcTimeUnit.DataPropertyName = "TIMEUNIT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcTimeUnit.DefaultCellStyle = dataGridViewCellStyle7;
            dgcTimeUnit.DisplayStyleForCurrentCellOnly = true;
            dgcTimeUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcTimeUnit.HeaderText = "laika vien.";
            dgcTimeUnit.Name = "dgcTimeUnit";
            dgcTimeUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcTimeUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcTimeUnit.Width = 50;
            // 
            // dgcTimeUse
            // 
            dgcTimeUse.DataPropertyName = "TIMEUSE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcTimeUse.DefaultCellStyle = dataGridViewCellStyle8;
            dgcTimeUse.HeaderText = "laiks";
            dgcTimeUse.Name = "dgcTimeUse";
            dgcTimeUse.ToolTipText = "laika patēriņš uz vienību";
            dgcTimeUse.Width = 60;
            // 
            // dgcTimeHour
            // 
            dgcTimeHour.DataPropertyName = "TIMEUSEINHOURS";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dgcTimeHour.DefaultCellStyle = dataGridViewCellStyle9;
            dgcTimeHour.HeaderText = "stundas";
            dgcTimeHour.Name = "dgcTimeHour";
            dgcTimeHour.ReadOnly = true;
            dgcTimeHour.ToolTipText = "kopā laika patēriņš stundās";
            dgcTimeHour.Width = 60;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            // 
            // FormA_PieceWork
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(782, 402);
            Controls.Add(tbDT2);
            Controls.Add(tbDT1);
            Controls.Add(cbAmats);
            Controls.Add(dgvSar);
            Controls.Add(bnavSar);
            Controls.Add(toolStrip1);
            Name = "FormA_PieceWork";
            Text = "Gabaldarba uzskaite";
            FormClosed += Form_PieceWork_FormClosed;
            Load += Form_PieceWork_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bnavSar).EndInit();
            bnavSar.ResumeLayout(false);
            bnavSar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsSar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsKat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private KlonsLIB.Components.MyBindingNavigator bnavSar;
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
        private KlonsLIB.Components.MyDataGridView dgvSar;
        private KlonsLIB.Data.MyBindingSource bsAmati;
        private KlonsLIB.Components.MyMcFlatComboBox cbAmats;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton cmFilter;
        private KlonsLIB.Components.MyTextBox tbDT2;
        private KlonsLIB.Components.MyTextBox tbDT1;
        private KlonsLIB.Data.MyBindingSource bsSar;
        private KlonsLIB.Data.MyBindingSource bsKat;
        private KlonsLIB.Data.MyBindingSource bsAmati2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIDA;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcIDK;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIDKa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPay;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcTimeUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTimeUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTimeHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}