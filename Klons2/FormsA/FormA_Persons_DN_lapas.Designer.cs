
namespace KlonsA.Forms
{
    partial class FormA_Persons_DN_lapas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Persons_DN_lapas));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            cmSaveChanges = new System.Windows.Forms.Button();
            cmLoadFromFile = new System.Windows.Forms.Button();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            bsChanges = new System.Windows.Forms.BindingSource(components);
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            tslActiveGrid = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tcPages = new KlonsLIB.Components.ExTabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dgvChanges = new KlonsLIB.Components.MyDataGridView();
            dgcChangesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesDbDT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesDBVeids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesEdsDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesEdsDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesVeids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcChangesAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabPage2 = new System.Windows.Forms.TabPage();
            dgvNoMatch = new KlonsLIB.Components.MyDataGridView();
            dgcBadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadDbDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadDbDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadDbVeids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadEdsDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadEdsDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBadEdsVeids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsNoMatch = new System.Windows.Forms.BindingSource(components);
            tabPage3 = new System.Windows.Forms.TabPage();
            dgvFull = new KlonsLIB.Components.MyDataGridView();
            dgcFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFullPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFullDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFullDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFullVeids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcFullStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsFullList = new System.Windows.Forms.BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsChanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            tcPages.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChanges).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNoMatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNoMatch).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFull).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsFullList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmSaveChanges);
            panel1.Controls.Add(cmLoadFromFile);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1058, 33);
            panel1.TabIndex = 5;
            // 
            // cmSaveChanges
            // 
            cmSaveChanges.Location = new System.Drawing.Point(383, 2);
            cmSaveChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmSaveChanges.Name = "cmSaveChanges";
            cmSaveChanges.Size = new System.Drawing.Size(93, 29);
            cmSaveChanges.TabIndex = 3;
            cmSaveChanges.Text = "Iegrāmatot";
            cmSaveChanges.UseVisualStyleBackColor = true;
            cmSaveChanges.Click += cmSaveChanges_Click;
            // 
            // cmLoadFromFile
            // 
            cmLoadFromFile.Location = new System.Drawing.Point(265, 2);
            cmLoadFromFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmLoadFromFile.Name = "cmLoadFromFile";
            cmLoadFromFile.Size = new System.Drawing.Size(112, 29);
            cmLoadFromFile.TabIndex = 3;
            cmLoadFromFile.Text = "Ielādēt no faila";
            cmLoadFromFile.UseVisualStyleBackColor = true;
            cmLoadFromFile.Click += cmLoadFromFile_Click;
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(169, 6);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(90, 23);
            tbDate2.TabIndex = 2;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(73, 6);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(90, 23);
            tbDate1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Periods:";
            // 
            // bsChanges
            // 
            bsChanges.AllowNew = false;
            // 
            // bNav
            // 
            bNav.AddNewItem = null;
            bNav.BindingSource = bsChanges;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DeleteItem = null;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(23, 26);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslActiveGrid, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorDeleteItem });
            bNav.Location = new System.Drawing.Point(0, 417);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = null;
            bNav.Size = new System.Drawing.Size(1058, 33);
            bNav.TabIndex = 6;
            bNav.Text = "myBindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // tslActiveGrid
            // 
            tslActiveGrid.Name = "tslActiveGrid";
            tslActiveGrid.Size = new System.Drawing.Size(16, 30);
            tslActiveGrid.Text = "..";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 30);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tcPages
            // 
            tcPages.BorderColor = System.Drawing.SystemColors.ControlText;
            tcPages.Controls.Add(tabPage1);
            tcPages.Controls.Add(tabPage2);
            tcPages.Controls.Add(tabPage3);
            tcPages.DefaultStyle = false;
            tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            tcPages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tcPages.HeaderBackColor = System.Drawing.SystemColors.Control;
            tcPages.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            tcPages.HighlightBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tcPages.HighlightForeColor = System.Drawing.SystemColors.ControlText;
            tcPages.Location = new System.Drawing.Point(0, 33);
            tcPages.Name = "tcPages";
            tcPages.SelectedIndex = 0;
            tcPages.Size = new System.Drawing.Size(1058, 384);
            tcPages.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvChanges);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1050, 355);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Izmaiņas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvChanges
            // 
            dgvChanges.AllowUserToAddRows = false;
            dgvChanges.AutoGenerateColumns = false;
            dgvChanges.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcChangesName, dgcChangesPK, dgcChangesDt1, dgcChangesDbDT2, dgcChangesDBVeids, dgcChangesEdsDt1, dgcChangesEdsDt2, dgcChangesVeids, dgcChangesAction });
            dgvChanges.DataSource = bsChanges;
            dgvChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvChanges.Location = new System.Drawing.Point(3, 3);
            dgvChanges.Name = "dgvChanges";
            dgvChanges.RowHeadersWidth = 62;
            dgvChanges.ShowCellToolTips = false;
            dgvChanges.Size = new System.Drawing.Size(1044, 349);
            dgvChanges.TabIndex = 0;
            dgvChanges.CellParsing += dgvChanges_CellParsing;
            dgvChanges.Enter += dgvChanges_Enter;
            // 
            // dgcChangesName
            // 
            dgcChangesName.DataPropertyName = "Name";
            dgcChangesName.HeaderText = "darbinieks";
            dgcChangesName.MinimumWidth = 8;
            dgcChangesName.Name = "dgcChangesName";
            dgcChangesName.Width = 160;
            // 
            // dgcChangesPK
            // 
            dgcChangesPK.DataPropertyName = "PersonsCode";
            dgcChangesPK.HeaderText = "personas kods";
            dgcChangesPK.MinimumWidth = 8;
            dgcChangesPK.Name = "dgcChangesPK";
            dgcChangesPK.Width = 120;
            // 
            // dgcChangesDt1
            // 
            dgcChangesDt1.DataPropertyName = "DB_Dt1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcChangesDt1.DefaultCellStyle = dataGridViewCellStyle2;
            dgcChangesDt1.HeaderText = "datums no";
            dgcChangesDt1.MinimumWidth = 8;
            dgcChangesDt1.Name = "dgcChangesDt1";
            dgcChangesDt1.Width = 85;
            // 
            // dgcChangesDbDT2
            // 
            dgcChangesDbDT2.DataPropertyName = "DB_Dt2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            dgcChangesDbDT2.DefaultCellStyle = dataGridViewCellStyle3;
            dgcChangesDbDT2.HeaderText = "datums līdz";
            dgcChangesDbDT2.MinimumWidth = 8;
            dgcChangesDbDT2.Name = "dgcChangesDbDT2";
            dgcChangesDbDT2.Width = 85;
            // 
            // dgcChangesDBVeids
            // 
            dgcChangesDBVeids.DataPropertyName = "DB_Veids";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcChangesDBVeids.DefaultCellStyle = dataGridViewCellStyle4;
            dgcChangesDBVeids.HeaderText = "veids";
            dgcChangesDBVeids.MinimumWidth = 8;
            dgcChangesDBVeids.Name = "dgcChangesDBVeids";
            dgcChangesDBVeids.Width = 60;
            // 
            // dgcChangesEdsDt1
            // 
            dgcChangesEdsDt1.DataPropertyName = "EDS_Dt1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd.MM.yyyy";
            dgcChangesEdsDt1.DefaultCellStyle = dataGridViewCellStyle5;
            dgcChangesEdsDt1.HeaderText = "EDS datums no";
            dgcChangesEdsDt1.MinimumWidth = 8;
            dgcChangesEdsDt1.Name = "dgcChangesEdsDt1";
            dgcChangesEdsDt1.Width = 85;
            // 
            // dgcChangesEdsDt2
            // 
            dgcChangesEdsDt2.DataPropertyName = "EDS_Dt2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "dd.MM.yyyy";
            dgcChangesEdsDt2.DefaultCellStyle = dataGridViewCellStyle6;
            dgcChangesEdsDt2.HeaderText = "EDS datums līdz";
            dgcChangesEdsDt2.MinimumWidth = 8;
            dgcChangesEdsDt2.Name = "dgcChangesEdsDt2";
            dgcChangesEdsDt2.Width = 85;
            // 
            // dgcChangesVeids
            // 
            dgcChangesVeids.DataPropertyName = "EDS_veids";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcChangesVeids.DefaultCellStyle = dataGridViewCellStyle7;
            dgcChangesVeids.HeaderText = "EDS veids";
            dgcChangesVeids.MinimumWidth = 8;
            dgcChangesVeids.Name = "dgcChangesVeids";
            dgcChangesVeids.Width = 60;
            // 
            // dgcChangesAction
            // 
            dgcChangesAction.DataPropertyName = "DNLapaImportTypeText";
            dgcChangesAction.HeaderText = "darbība";
            dgcChangesAction.MinimumWidth = 8;
            dgcChangesAction.Name = "dgcChangesAction";
            dgcChangesAction.Width = 160;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvNoMatch);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1050, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Nesakritības";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvNoMatch
            // 
            dgvNoMatch.AllowUserToAddRows = false;
            dgvNoMatch.AllowUserToDeleteRows = false;
            dgvNoMatch.AutoGenerateColumns = false;
            dgvNoMatch.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvNoMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvNoMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcBadName, dgcBadPK, dgcBadDbDt1, dgcBadDbDt2, dgcBadDbVeids, dgcBadEdsDt1, dgcBadEdsDt2, dgcBadEdsVeids });
            dgvNoMatch.DataSource = bsNoMatch;
            dgvNoMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNoMatch.Location = new System.Drawing.Point(3, 3);
            dgvNoMatch.Name = "dgvNoMatch";
            dgvNoMatch.ReadOnly = true;
            dgvNoMatch.RowHeadersWidth = 62;
            dgvNoMatch.ShowCellToolTips = false;
            dgvNoMatch.Size = new System.Drawing.Size(1044, 344);
            dgvNoMatch.TabIndex = 0;
            dgvNoMatch.Enter += dgvNoMatch_Enter;
            // 
            // dgcBadName
            // 
            dgcBadName.DataPropertyName = "Name";
            dgcBadName.HeaderText = "darbinieks";
            dgcBadName.MinimumWidth = 8;
            dgcBadName.Name = "dgcBadName";
            dgcBadName.ReadOnly = true;
            dgcBadName.Width = 160;
            // 
            // dgcBadPK
            // 
            dgcBadPK.DataPropertyName = "PersonsCode";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBadPK.DefaultCellStyle = dataGridViewCellStyle9;
            dgcBadPK.HeaderText = "personas kods";
            dgcBadPK.MinimumWidth = 8;
            dgcBadPK.Name = "dgcBadPK";
            dgcBadPK.ReadOnly = true;
            dgcBadPK.Width = 120;
            // 
            // dgcBadDbDt1
            // 
            dgcBadDbDt1.DataPropertyName = "DB_Dt1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "dd.MM.yyyy";
            dgcBadDbDt1.DefaultCellStyle = dataGridViewCellStyle10;
            dgcBadDbDt1.HeaderText = "datums no";
            dgcBadDbDt1.MinimumWidth = 8;
            dgcBadDbDt1.Name = "dgcBadDbDt1";
            dgcBadDbDt1.ReadOnly = true;
            dgcBadDbDt1.Width = 85;
            // 
            // dgcBadDbDt2
            // 
            dgcBadDbDt2.DataPropertyName = "DB_Dt2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "dd.MM.yyyy";
            dgcBadDbDt2.DefaultCellStyle = dataGridViewCellStyle11;
            dgcBadDbDt2.HeaderText = "datums līdz";
            dgcBadDbDt2.MinimumWidth = 8;
            dgcBadDbDt2.Name = "dgcBadDbDt2";
            dgcBadDbDt2.ReadOnly = true;
            dgcBadDbDt2.Width = 85;
            // 
            // dgcBadDbVeids
            // 
            dgcBadDbVeids.DataPropertyName = "DB_Veids";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBadDbVeids.DefaultCellStyle = dataGridViewCellStyle12;
            dgcBadDbVeids.HeaderText = "veids";
            dgcBadDbVeids.MinimumWidth = 8;
            dgcBadDbVeids.Name = "dgcBadDbVeids";
            dgcBadDbVeids.ReadOnly = true;
            dgcBadDbVeids.Width = 60;
            // 
            // dgcBadEdsDt1
            // 
            dgcBadEdsDt1.DataPropertyName = "EDS_Dt1";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "dd.MM.yyyy";
            dgcBadEdsDt1.DefaultCellStyle = dataGridViewCellStyle13;
            dgcBadEdsDt1.HeaderText = "EDS datums līdz";
            dgcBadEdsDt1.MinimumWidth = 8;
            dgcBadEdsDt1.Name = "dgcBadEdsDt1";
            dgcBadEdsDt1.ReadOnly = true;
            dgcBadEdsDt1.Width = 85;
            // 
            // dgcBadEdsDt2
            // 
            dgcBadEdsDt2.DataPropertyName = "EDS_Dt2";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "dd.MM.yyyy";
            dgcBadEdsDt2.DefaultCellStyle = dataGridViewCellStyle14;
            dgcBadEdsDt2.HeaderText = "EDS datums līdz";
            dgcBadEdsDt2.MinimumWidth = 8;
            dgcBadEdsDt2.Name = "dgcBadEdsDt2";
            dgcBadEdsDt2.ReadOnly = true;
            dgcBadEdsDt2.Width = 85;
            // 
            // dgcBadEdsVeids
            // 
            dgcBadEdsVeids.DataPropertyName = "EDS_Veids";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBadEdsVeids.DefaultCellStyle = dataGridViewCellStyle15;
            dgcBadEdsVeids.HeaderText = "EDS veids";
            dgcBadEdsVeids.MinimumWidth = 8;
            dgcBadEdsVeids.Name = "dgcBadEdsVeids";
            dgcBadEdsVeids.ReadOnly = true;
            dgcBadEdsVeids.Width = 60;
            // 
            // bsNoMatch
            // 
            bsNoMatch.AllowNew = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvFull);
            tabPage3.Location = new System.Drawing.Point(4, 25);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(1050, 350);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Lapas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvFull
            // 
            dgvFull.AllowUserToAddRows = false;
            dgvFull.AllowUserToDeleteRows = false;
            dgvFull.AutoGenerateColumns = false;
            dgvFull.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvFull.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFullName, dgcFullPK, dgcFullDt1, dgcFullDt2, dgcFullVeids, dgcFullStatus });
            dgvFull.DataSource = bsFullList;
            dgvFull.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvFull.Location = new System.Drawing.Point(3, 3);
            dgvFull.Name = "dgvFull";
            dgvFull.ReadOnly = true;
            dgvFull.RowHeadersWidth = 62;
            dgvFull.ShowCellToolTips = false;
            dgvFull.Size = new System.Drawing.Size(1044, 344);
            dgvFull.TabIndex = 0;
            dgvFull.Enter += dgvFull_Enter;
            // 
            // dgcFullName
            // 
            dgcFullName.DataPropertyName = "Name";
            dgcFullName.HeaderText = "darbinieks";
            dgcFullName.MinimumWidth = 8;
            dgcFullName.Name = "dgcFullName";
            dgcFullName.ReadOnly = true;
            dgcFullName.Width = 160;
            // 
            // dgcFullPK
            // 
            dgcFullPK.DataPropertyName = "PersonsCode";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcFullPK.DefaultCellStyle = dataGridViewCellStyle17;
            dgcFullPK.HeaderText = "personas kods";
            dgcFullPK.MinimumWidth = 8;
            dgcFullPK.Name = "dgcFullPK";
            dgcFullPK.ReadOnly = true;
            dgcFullPK.Width = 120;
            // 
            // dgcFullDt1
            // 
            dgcFullDt1.DataPropertyName = "EDS_Dt1";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "dd.MM.yyyy";
            dgcFullDt1.DefaultCellStyle = dataGridViewCellStyle18;
            dgcFullDt1.HeaderText = "datums no";
            dgcFullDt1.MinimumWidth = 8;
            dgcFullDt1.Name = "dgcFullDt1";
            dgcFullDt1.ReadOnly = true;
            dgcFullDt1.Width = 85;
            // 
            // dgcFullDt2
            // 
            dgcFullDt2.DataPropertyName = "EDS_Dt2";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "dd.MM.yyyy";
            dgcFullDt2.DefaultCellStyle = dataGridViewCellStyle19;
            dgcFullDt2.HeaderText = "datums līdz";
            dgcFullDt2.MinimumWidth = 8;
            dgcFullDt2.Name = "dgcFullDt2";
            dgcFullDt2.ReadOnly = true;
            dgcFullDt2.Width = 85;
            // 
            // dgcFullVeids
            // 
            dgcFullVeids.DataPropertyName = "EDS_Veids";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcFullVeids.DefaultCellStyle = dataGridViewCellStyle20;
            dgcFullVeids.HeaderText = "veids";
            dgcFullVeids.MinimumWidth = 8;
            dgcFullVeids.Name = "dgcFullVeids";
            dgcFullVeids.ReadOnly = true;
            dgcFullVeids.Width = 60;
            // 
            // dgcFullStatus
            // 
            dgcFullStatus.DataPropertyName = "EDS_Status";
            dgcFullStatus.HeaderText = "status";
            dgcFullStatus.MinimumWidth = 8;
            dgcFullStatus.Name = "dgcFullStatus";
            dgcFullStatus.ReadOnly = true;
            dgcFullStatus.Width = 80;
            // 
            // FormA_Persons_DN_lapas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1058, 450);
            Controls.Add(tcPages);
            Controls.Add(bNav);
            Controls.Add(panel1);
            Name = "FormA_Persons_DN_lapas";
            Text = "Darba nespējas lapas";
            Load += Form_Persons_DN_lapas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsChanges).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            tcPages.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChanges).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNoMatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNoMatch).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFull).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsFullList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmLoadFromFile;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsChanges;
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
        private KlonsLIB.Components.ExTabControl tcPages;
        private System.Windows.Forms.TabPage tabPage1;
        private KlonsLIB.Components.MyDataGridView dgvChanges;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bsNoMatch;
        private KlonsLIB.Components.MyDataGridView dgvNoMatch;
        private System.Windows.Forms.ToolStripLabel tslActiveGrid;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.TabPage tabPage3;
        private KlonsLIB.Components.MyDataGridView dgvFull;
        private System.Windows.Forms.BindingSource bsFullList;
        private System.Windows.Forms.Button cmSaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesDbDT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesDBVeids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesEdsDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesEdsDt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesVeids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcChangesAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadDbDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadDbDt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadDbVeids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadEdsDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadEdsDt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBadEdsVeids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullDt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullVeids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFullStatus;
    }
}