namespace KlonsA.Forms
{
    partial class FormA_PaymentsByPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_PaymentsByPerson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            bsRows = new System.Windows.Forms.BindingSource(components);
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            panel1 = new System.Windows.Forms.Panel();
            cmFilter = new System.Windows.Forms.Button();
            cbPerson = new KlonsLIB.Components.MyMcFlatComboBox();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            miMaksājumuPārskats = new System.Windows.Forms.ToolStripMenuItem();
            miAvansaMaksājumaProcentsNoPēdējāsAlgas = new System.Windows.Forms.ToolStripMenuItem();
            miKasesMaksājumuSarēķins = new System.Windows.Forms.ToolStripMenuItem();
            miSaglabātSarēķinātosKasesMaksājumus = new System.Windows.Forms.ToolStripMenuItem();
            sgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcListDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPosTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalcAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalcWithhold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalcT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotPaidAdvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotPaidWithhold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotPaidT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPayT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalcIIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTakeIIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCalcVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sgvRows).BeginInit();
            SuspendLayout();
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "PERSONS";
            bsPersons.Filter = "USED=1";
            bsPersons.MyDataSource = "KlonsAData";
            bsPersons.Sort = "YNAME";
            // 
            // bNav
            // 
            bNav.AddNewItem = null;
            bNav.BindingSource = bsRows;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DeleteItem = null;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(21, 21);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2 });
            bNav.Location = new System.Drawing.Point(0, 534);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = null;
            bNav.Size = new System.Drawing.Size(1271, 28);
            bNav.TabIndex = 0;
            bNav.Text = "myBindingNavigator1";
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
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 23);
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
            // panel1
            // 
            panel1.Controls.Add(cmFilter);
            panel1.Controls.Add(cbPerson);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1271, 33);
            panel1.TabIndex = 1;
            // 
            // cmFilter
            // 
            cmFilter.Location = new System.Drawing.Point(654, 3);
            cmFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmFilter.Name = "cmFilter";
            cmFilter.Size = new System.Drawing.Size(84, 26);
            cmFilter.TabIndex = 5;
            cmFilter.Text = "Atlasīt";
            cmFilter.UseVisualStyleBackColor = true;
            cmFilter.Click += CmFilter_Click;
            // 
            // cbPerson
            // 
            cbPerson.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPerson.ColumnNames = new string[]
    {
    "FNAME",
    "LNAME",
    "PK"
    };
            cbPerson.ColumnWidths = "100;100;100";
            cbPerson.DataSource = bsPersons;
            cbPerson.DisplayMember = "YNAME";
            cbPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPerson.DropDownHeight = 270;
            cbPerson.DropDownWidth = 319;
            cbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPerson.FormattingEnabled = true;
            cbPerson.GridLineColor = System.Drawing.Color.LightGray;
            cbPerson.GridLineHorizontal = false;
            cbPerson.GridLineVertical = false;
            cbPerson.IntegralHeight = false;
            cbPerson.Location = new System.Drawing.Point(354, 3);
            cbPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbPerson.MaxDropDownItems = 15;
            cbPerson.Name = "cbPerson";
            cbPerson.Size = new System.Drawing.Size(289, 24);
            cbPerson.TabIndex = 4;
            cbPerson.ValueMember = "ID";
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(167, 4);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(90, 23);
            tbDate2.TabIndex = 2;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(71, 4);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(90, 23);
            tbDate1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(273, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 17);
            label2.TabIndex = 3;
            label2.Text = "darbinieks:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Datums:";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miMaksājumuPārskats });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1271, 25);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // miMaksājumuPārskats
            // 
            miMaksājumuPārskats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miAvansaMaksājumaProcentsNoPēdējāsAlgas, miKasesMaksājumuSarēķins, miSaglabātSarēķinātosKasesMaksājumus });
            miMaksājumuPārskats.Name = "miMaksājumuPārskats";
            miMaksājumuPārskats.Size = new System.Drawing.Size(149, 21);
            miMaksājumuPārskats.Text = "Maksājumu pārskats";
            miMaksājumuPārskats.DropDownOpening += miMaksājumuPārskats_DropDownOpening;
            // 
            // miAvansaMaksājumaProcentsNoPēdējāsAlgas
            // 
            miAvansaMaksājumaProcentsNoPēdējāsAlgas.Name = "miAvansaMaksājumaProcentsNoPēdējāsAlgas";
            miAvansaMaksājumaProcentsNoPēdējāsAlgas.Size = new System.Drawing.Size(369, 22);
            miAvansaMaksājumaProcentsNoPēdējāsAlgas.Text = "Avansa maksājuma procents no pēdējās algas";
            miAvansaMaksājumaProcentsNoPēdējāsAlgas.Click += miAvansaMaksājumaProcentsNoPēdējāsAlgas_Click;
            // 
            // miKasesMaksājumuSarēķins
            // 
            miKasesMaksājumuSarēķins.Name = "miKasesMaksājumuSarēķins";
            miKasesMaksājumuSarēķins.Size = new System.Drawing.Size(369, 22);
            miKasesMaksājumuSarēķins.Text = "Kases maksājumu sarēķins";
            miKasesMaksājumuSarēķins.Click += miKasesMaksājumuSarēķins_Click;
            // 
            // miSaglabātSarēķinātosKasesMaksājumus
            // 
            miSaglabātSarēķinātosKasesMaksājumus.Name = "miSaglabātSarēķinātosKasesMaksājumus";
            miSaglabātSarēķinātosKasesMaksājumus.Size = new System.Drawing.Size(369, 22);
            miSaglabātSarēķinātosKasesMaksājumus.Text = "Saglabāt sarēķinātos kases maksājumus";
            miSaglabātSarēķinātosKasesMaksājumus.Click += miSaglabātSarēķinātosKasesMaksājumus_Click;
            // 
            // sgvRows
            // 
            sgvRows.AllowUserToAddRows = false;
            sgvRows.AllowUserToDeleteRows = false;
            sgvRows.AllowUserToResizeRows = false;
            sgvRows.AutoGenerateColumns = false;
            sgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            sgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            sgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDate, dgcListDescr, dgcPosTitle, dgcCalc, dgcCalcAdvance, dgcCalcWithhold, dgcCalcT, dgcNotPaid, dgcNotPaidAdvance, dgcNotPaidWithhold, dgcNotPaidT, dgcPayT, dgcDiff, dgcCalcIIN, dgcTakeIIN, dgcCalcVal });
            sgvRows.DataSource = bsRows;
            sgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            sgvRows.Location = new System.Drawing.Point(0, 33);
            sgvRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sgvRows.Name = "sgvRows";
            sgvRows.ReadOnly = true;
            sgvRows.RowHeadersWidth = 30;
            sgvRows.ShowCellToolTips = false;
            sgvRows.Size = new System.Drawing.Size(1271, 501);
            sgvRows.TabIndex = 2;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDate.Frozen = true;
            dgcDate.HeaderText = "datums";
            dgcDate.MinimumWidth = 7;
            dgcDate.Name = "dgcDate";
            dgcDate.ReadOnly = true;
            dgcDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDate.ToolTipText = "Aprēķina vai maksājuma datums";
            dgcDate.Width = 85;
            // 
            // dgcListDescr
            // 
            dgcListDescr.DataPropertyName = "ListDescription";
            dgcListDescr.Frozen = true;
            dgcListDescr.HeaderText = "apraksts";
            dgcListDescr.MinimumWidth = 7;
            dgcListDescr.Name = "dgcListDescr";
            dgcListDescr.ReadOnly = true;
            dgcListDescr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcListDescr.Width = 225;
            // 
            // dgcPosTitle
            // 
            dgcPosTitle.DataPropertyName = "PositionTitle";
            dgcPosTitle.HeaderText = "amats";
            dgcPosTitle.MinimumWidth = 7;
            dgcPosTitle.Name = "dgcPosTitle";
            dgcPosTitle.ReadOnly = true;
            dgcPosTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPosTitle.Width = 225;
            // 
            // dgcCalc
            // 
            dgcCalc.DataPropertyName = "Calc";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "0.00;-0.00;\"\"";
            dgcCalc.DefaultCellStyle = dataGridViewCellStyle3;
            dgcCalc.HeaderText = "aprēķ. alga";
            dgcCalc.MinimumWidth = 7;
            dgcCalc.Name = "dgcCalc";
            dgcCalc.ReadOnly = true;
            dgcCalc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCalc.ToolTipText = "Aprēķinātā alga";
            dgcCalc.Width = 90;
            // 
            // dgcCalcAdvance
            // 
            dgcCalcAdvance.DataPropertyName = "CalcAdvance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "0.00;-0.00;\"\"";
            dgcCalcAdvance.DefaultCellStyle = dataGridViewCellStyle4;
            dgcCalcAdvance.HeaderText = "avanss";
            dgcCalcAdvance.MinimumWidth = 7;
            dgcCalcAdvance.Name = "dgcCalcAdvance";
            dgcCalcAdvance.ReadOnly = true;
            dgcCalcAdvance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCalcAdvance.ToolTipText = "Aprēķināta avansā izmaksājamā summa";
            dgcCalcAdvance.Width = 90;
            // 
            // dgcCalcWithhold
            // 
            dgcCalcWithhold.DataPropertyName = "CalcWithhold";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "0.00;-0.00;\"\"";
            dgcCalcWithhold.DefaultCellStyle = dataGridViewCellStyle5;
            dgcCalcWithhold.HeaderText = "ieturēt";
            dgcCalcWithhold.MinimumWidth = 7;
            dgcCalcWithhold.Name = "dgcCalcWithhold";
            dgcCalcWithhold.ReadOnly = true;
            dgcCalcWithhold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCalcWithhold.ToolTipText = "Aprēķināti ieturējumi";
            dgcCalcWithhold.Width = 90;
            // 
            // dgcCalcT
            // 
            dgcCalcT.DataPropertyName = "CalcT";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "0.00;-0.00;\"\"";
            dgcCalcT.DefaultCellStyle = dataGridViewCellStyle6;
            dgcCalcT.HeaderText = "aprēķ. kopā";
            dgcCalcT.MinimumWidth = 7;
            dgcCalcT.Name = "dgcCalcT";
            dgcCalcT.ReadOnly = true;
            dgcCalcT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcCalcT.ToolTipText = "Aprēķins kopā";
            dgcCalcT.Width = 90;
            // 
            // dgcNotPaid
            // 
            dgcNotPaid.DataPropertyName = "NotPaid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "0.00;-0.00;\"\"";
            dgcNotPaid.DefaultCellStyle = dataGridViewCellStyle7;
            dgcNotPaid.HeaderText = "neizmaks.";
            dgcNotPaid.MinimumWidth = 7;
            dgcNotPaid.Name = "dgcNotPaid";
            dgcNotPaid.ReadOnly = true;
            dgcNotPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotPaid.ToolTipText = "Neizmaksātā alga";
            dgcNotPaid.Width = 90;
            // 
            // dgcNotPaidAdvance
            // 
            dgcNotPaidAdvance.DataPropertyName = "NotPaidAdvance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.00;-0.00;\"\"";
            dgcNotPaidAdvance.DefaultCellStyle = dataGridViewCellStyle8;
            dgcNotPaidAdvance.HeaderText = "avanss";
            dgcNotPaidAdvance.MinimumWidth = 7;
            dgcNotPaidAdvance.Name = "dgcNotPaidAdvance";
            dgcNotPaidAdvance.ReadOnly = true;
            dgcNotPaidAdvance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotPaidAdvance.ToolTipText = "Neizmaksātā vai avansā izmaksātā summa";
            dgcNotPaidAdvance.Width = 90;
            // 
            // dgcNotPaidWithhold
            // 
            dgcNotPaidWithhold.DataPropertyName = "NotPaidWithhold";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.00;-0.00;\"\"";
            dgcNotPaidWithhold.DefaultCellStyle = dataGridViewCellStyle9;
            dgcNotPaidWithhold.HeaderText = "ieturēt";
            dgcNotPaidWithhold.MinimumWidth = 7;
            dgcNotPaidWithhold.Name = "dgcNotPaidWithhold";
            dgcNotPaidWithhold.ReadOnly = true;
            dgcNotPaidWithhold.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotPaidWithhold.ToolTipText = "Ieturējumi";
            dgcNotPaidWithhold.Width = 90;
            // 
            // dgcNotPaidT
            // 
            dgcNotPaidT.DataPropertyName = "NotPaidT";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "0.00;-0.00;\"\"";
            dgcNotPaidT.DefaultCellStyle = dataGridViewCellStyle10;
            dgcNotPaidT.HeaderText = "neizm. kopā";
            dgcNotPaidT.MinimumWidth = 7;
            dgcNotPaidT.Name = "dgcNotPaidT";
            dgcNotPaidT.ReadOnly = true;
            dgcNotPaidT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcNotPaidT.ToolTipText = "Neizmaksātā summa kopā";
            dgcNotPaidT.Width = 90;
            // 
            // dgcPayT
            // 
            dgcPayT.DataPropertyName = "PayT";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "0.00;-0.00;\"\"";
            dgcPayT.DefaultCellStyle = dataGridViewCellStyle11;
            dgcPayT.HeaderText = "maksāts";
            dgcPayT.MinimumWidth = 7;
            dgcPayT.Name = "dgcPayT";
            dgcPayT.ReadOnly = true;
            dgcPayT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPayT.ToolTipText = "Izmaksātā summa";
            dgcPayT.Width = 90;
            // 
            // dgcDiff
            // 
            dgcDiff.DataPropertyName = "Diff";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "0.00;-0.00;\"\"";
            dgcDiff.DefaultCellStyle = dataGridViewCellStyle12;
            dgcDiff.HeaderText = "atlikums";
            dgcDiff.MinimumWidth = 7;
            dgcDiff.Name = "dgcDiff";
            dgcDiff.ReadOnly = true;
            dgcDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDiff.ToolTipText = "Nesamaksāts vai pārmaksāts";
            dgcDiff.Width = 90;
            // 
            // dgcCalcIIN
            // 
            dgcCalcIIN.DataPropertyName = "CalcIIN";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "0.00;-0.00;\"\"";
            dgcCalcIIN.DefaultCellStyle = dataGridViewCellStyle13;
            dgcCalcIIN.HeaderText = "iin apr.";
            dgcCalcIIN.MinimumWidth = 7;
            dgcCalcIIN.Name = "dgcCalcIIN";
            dgcCalcIIN.ReadOnly = true;
            dgcCalcIIN.Width = 90;
            // 
            // dgcTakeIIN
            // 
            dgcTakeIIN.DataPropertyName = "TakeIIN";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "0.00;-0.00;\"\"";
            dgcTakeIIN.DefaultCellStyle = dataGridViewCellStyle14;
            dgcTakeIIN.HeaderText = "iin iet.";
            dgcTakeIIN.MinimumWidth = 7;
            dgcTakeIIN.Name = "dgcTakeIIN";
            dgcTakeIIN.ReadOnly = true;
            dgcTakeIIN.Width = 90;
            // 
            // dgcCalcVal
            // 
            dgcCalcVal.DataPropertyName = "CalcVal";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "0.00;-0.00;\"\"";
            dgcCalcVal.DefaultCellStyle = dataGridViewCellStyle15;
            dgcCalcVal.HeaderText = "sarēķins";
            dgcCalcVal.MinimumWidth = 8;
            dgcCalcVal.Name = "dgcCalcVal";
            dgcCalcVal.ReadOnly = true;
            dgcCalcVal.Width = 90;
            // 
            // FormA_PaymentsByPerson
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1271, 562);
            Controls.Add(sgvRows);
            Controls.Add(panel1);
            Controls.Add(bNav);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormA_PaymentsByPerson";
            Text = "Maksājumu pārskats";
            Load += Form_PaymentsByPerson_Load;
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sgvRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsPersons;
        private System.Windows.Forms.BindingSource bsRows;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmFilter;
        private KlonsLIB.Components.MyMcFlatComboBox cbPerson;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyDataGridView sgvRows;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miMaksājumuPārskats;
        private System.Windows.Forms.ToolStripMenuItem miKasesMaksājumuSarēķins;
        private System.Windows.Forms.ToolStripMenuItem miAvansaMaksājumaProcentsNoPēdējāsAlgas;
        private System.Windows.Forms.ToolStripMenuItem miSaglabātSarēķinātosKasesMaksājumus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcListDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPosTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcWithhold;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotPaidAdvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotPaidWithhold;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotPaidT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPayT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcIIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTakeIIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCalcVal;
    }
}