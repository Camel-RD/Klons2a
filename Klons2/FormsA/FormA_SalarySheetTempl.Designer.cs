﻿using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_SalarySheetTempl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_SalarySheetTempl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnavSh = new KlonsLIB.Components.MyBindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbRenum = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvShL = new KlonsLIB.Components.MyDataGridView();
            this.dgcShLSnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDesr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcShLDep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsDep1 = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcShLUsed = new MyDgvCheckBoxColumn();
            this.dgcShLCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcShLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsShL = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgvShR = new KlonsLIB.Components.MyDataGridView();
            this.dgcShRSNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcShRIdP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsPers = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcShRIdAM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsAmati = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcShRId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcShRIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsShR = new KlonsLIB.Data.MyBindingSource2(this.components);
            this.bsDep2 = new KlonsLIB.Data.MyBindingSource(this.components);
            this.bsAmatiF = new KlonsLIB.Data.MyBindingSource(this.components);
            this.myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bnavSh)).BeginInit();
            this.bnavSh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAmati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAmatiF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdapterManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnavSh
            // 
            this.bnavSh.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnavSh.CountItem = this.bindingNavigatorCountItem;
            this.bnavSh.CountItemFormat = " no {0}";
            this.bnavSh.DeleteItem = null;
            this.bnavSh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnavSh.ImageScalingSize = new System.Drawing.Size(16, 16);
            this.bnavSh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tsbSave,
            this.tsbRenum});
            this.bnavSh.Location = new System.Drawing.Point(0, 512);
            this.bnavSh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnavSh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnavSh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnavSh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnavSh.Name = "bnavSh";
            this.bnavSh.PositionItem = this.bindingNavigatorPositionItem;
            this.bnavSh.SaveItem = null;
            this.bnavSh.Size = new System.Drawing.Size(811, 39);
            this.bnavSh.TabIndex = 0;
            this.bnavSh.Text = "myBindingNavigator1";
            this.bnavSh.ItemDeleting += new System.ComponentModel.CancelEventHandler(this.bnavSh_ItemDeleting);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(92, 34);
            this.bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 34);
            this.bindingNavigatorCountItem.Text = " no {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 34);
            this.toolStripLabel1.Text = "..";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 37);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(93, 34);
            this.bindingNavigatorDeleteItem.Text = "Dzēst";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(34, 34);
            this.tsbSave.Text = "Saglabāt";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbRenum
            // 
            this.tsbRenum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRenum.Image = ((System.Drawing.Image)(resources.GetObject("tsbRenum.Image")));
            this.tsbRenum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenum.Name = "tsbRenum";
            this.tsbRenum.Size = new System.Drawing.Size(129, 34);
            this.tsbRenum.Text = "Pārnumurēt";
            this.tsbRenum.Click += new System.EventHandler(this.tsbRenum_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvShL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShR);
            this.splitContainer1.Size = new System.Drawing.Size(811, 512);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvShL
            // 
            this.dgvShL.AllowUserToDeleteRows = false;
            this.dgvShL.AutoGenerateColumns = false;
            this.dgvShL.AutoSave = true;
            this.dgvShL.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcShLSnr,
            this.dgcDesr,
            this.dgcShLDep,
            this.dgcShLUsed,
            this.dgcShLCode,
            this.dgcShLId});
            this.dgvShL.DataSource = this.bsShL;
            this.dgvShL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShL.Location = new System.Drawing.Point(0, 0);
            this.dgvShL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvShL.Name = "dgvShL";
            this.dgvShL.RowHeadersWidth = 62;
            this.dgvShL.ShowCellToolTips = false;
            this.dgvShL.Size = new System.Drawing.Size(811, 166);
            this.dgvShL.TabIndex = 0;
            this.dgvShL.MyKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvShL_MyKeyDown);
            this.dgvShL.MyCheckForChanges += new System.EventHandler(this.dgvShL_MyCheckForChanges);
            this.dgvShL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShL_CellDoubleClick);
            this.dgvShL.CurrentCellChanged += new System.EventHandler(this.dgvShL_CurrentCellChanged);
            this.dgvShL.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvShL_DefaultValuesNeeded);
            this.dgvShL.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvShL_UserDeletingRow);
            this.dgvShL.Enter += new System.EventHandler(this.dgvShL_Enter);
            // 
            // dgcShLSnr
            // 
            this.dgcShLSnr.DataPropertyName = "SNR";
            this.dgcShLSnr.HeaderText = "npk";
            this.dgcShLSnr.MinimumWidth = 9;
            this.dgcShLSnr.Name = "dgcShLSnr";
            this.dgcShLSnr.Width = 45;
            // 
            // dgcDesr
            // 
            this.dgcDesr.DataPropertyName = "DESCR";
            this.dgcDesr.HeaderText = "apraksts";
            this.dgcDesr.MinimumWidth = 9;
            this.dgcDesr.Name = "dgcDesr";
            this.dgcDesr.Width = 225;
            // 
            // dgcShLDep
            // 
            this.dgcShLDep.DataPropertyName = "DEP";
            this.dgcShLDep.DataSource = this.bsDep1;
            this.dgcShLDep.DisplayMember = "DESCR";
            this.dgcShLDep.DisplayStyleForCurrentCellOnly = true;
            this.dgcShLDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgcShLDep.HeaderText = "str.v.";
            this.dgcShLDep.MaxDropDownItems = 15;
            this.dgcShLDep.MinimumWidth = 9;
            this.dgcShLDep.Name = "dgcShLDep";
            this.dgcShLDep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcShLDep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcShLDep.ValueMember = "ID";
            this.dgcShLDep.Width = 225;
            // 
            // bsDep1
            // 
            this.bsDep1.DataMember = "DEPARTMENTS";
            this.bsDep1.MyDataSource = "KlonsAData";
            this.bsDep1.Name2 = "bsDep1";
            // 
            // dgcShLUsed
            // 
            this.dgcShLUsed.DataPropertyName = "USED";
            this.dgcShLUsed.FalseValue = "0";
            this.dgcShLUsed.HeaderText = "aktīvs";
            this.dgcShLUsed.MinimumWidth = 9;
            this.dgcShLUsed.Name = "dgcShLUsed";
            this.dgcShLUsed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcShLUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcShLUsed.TrueValue = "1";
            this.dgcShLUsed.Visible = false;
            this.dgcShLUsed.Width = 56;
            // 
            // dgcShLCode
            // 
            this.dgcShLCode.DataPropertyName = "CODE";
            this.dgcShLCode.HeaderText = "CODE";
            this.dgcShLCode.MinimumWidth = 9;
            this.dgcShLCode.Name = "dgcShLCode";
            this.dgcShLCode.Visible = false;
            this.dgcShLCode.Width = 168;
            // 
            // dgcShLId
            // 
            this.dgcShLId.DataPropertyName = "ID";
            this.dgcShLId.HeaderText = "ID";
            this.dgcShLId.MinimumWidth = 9;
            this.dgcShLId.Name = "dgcShLId";
            this.dgcShLId.Visible = false;
            this.dgcShLId.Width = 45;
            // 
            // bsShL
            // 
            this.bsShL.DataMember = "SALARY_SHEET_TEMPL";
            this.bsShL.MyDataSource = "KlonsAData";
            this.bsShL.Name2 = "bsShL";
            this.bsShL.Sort = "SNR";
            this.bsShL.UseDataGridView = this.dgvShL;
            this.bsShL.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsShL_ListChanged);
            // 
            // dgvShR
            // 
            this.dgvShR.AllowUserToDeleteRows = false;
            this.dgvShR.AutoGenerateColumns = false;
            this.dgvShR.AutoSave = false;
            this.dgvShR.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcShRSNR,
            this.dgcShRIdP,
            this.dgcShRIdAM,
            this.dgcShRId,
            this.dgcShRIdS});
            this.dgvShR.DataSource = this.bsShR;
            this.dgvShR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShR.Location = new System.Drawing.Point(0, 0);
            this.dgvShR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvShR.Name = "dgvShR";
            this.dgvShR.RowHeadersWidth = 62;
            this.dgvShR.ShowCellToolTips = false;
            this.dgvShR.Size = new System.Drawing.Size(811, 338);
            this.dgvShR.TabIndex = 0;
            this.dgvShR.MyKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvShR_MyKeyDown);
            this.dgvShR.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvShR_CellBeginEdit);
            this.dgvShR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShR_CellDoubleClick);
            this.dgvShR.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShR_CellEndEdit);
            this.dgvShR.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvShR_DefaultValuesNeeded);
            this.dgvShR.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvShR_UserDeletingRow);
            this.dgvShR.Enter += new System.EventHandler(this.dgvShR_Enter);
            // 
            // dgcShRSNR
            // 
            this.dgcShRSNR.DataPropertyName = "SNR";
            this.dgcShRSNR.HeaderText = "npk";
            this.dgcShRSNR.MinimumWidth = 9;
            this.dgcShRSNR.Name = "dgcShRSNR";
            this.dgcShRSNR.Width = 45;
            // 
            // dgcShRIdP
            // 
            this.dgcShRIdP.DataPropertyName = "IDP";
            this.dgcShRIdP.DataSource = this.bsPers;
            this.dgcShRIdP.DisplayMember = "ZNAME";
            this.dgcShRIdP.DisplayStyleForCurrentCellOnly = true;
            this.dgcShRIdP.DropDownWidth = 300;
            this.dgcShRIdP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgcShRIdP.HeaderText = "darbinieks";
            this.dgcShRIdP.MaxDropDownItems = 15;
            this.dgcShRIdP.MinimumWidth = 9;
            this.dgcShRIdP.Name = "dgcShRIdP";
            this.dgcShRIdP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcShRIdP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcShRIdP.ValueMember = "ID";
            this.dgcShRIdP.Width = 337;
            // 
            // bsPers
            // 
            this.bsPers.DataMember = "PERSONS";
            this.bsPers.MyDataSource = "KlonsAData";
            this.bsPers.Name2 = "bsPers";
            this.bsPers.Sort = "ZNAME";
            // 
            // dgcShRIdAM
            // 
            this.dgcShRIdAM.DataPropertyName = "IDAM";
            this.dgcShRIdAM.DataSource = this.bsAmati;
            this.dgcShRIdAM.DisplayMember = "TITLE";
            this.dgcShRIdAM.DisplayStyleForCurrentCellOnly = true;
            this.dgcShRIdAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgcShRIdAM.HeaderText = "amats";
            this.dgcShRIdAM.MinimumWidth = 9;
            this.dgcShRIdAM.Name = "dgcShRIdAM";
            this.dgcShRIdAM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcShRIdAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcShRIdAM.ValueMember = "ID";
            this.dgcShRIdAM.Width = 225;
            // 
            // bsAmati
            // 
            this.bsAmati.DataMember = "POSITIONS";
            this.bsAmati.Filter = "USED=1";
            this.bsAmati.MyDataSource = "KlonsAData";
            this.bsAmati.Sort = "ID";
            // 
            // dgcShRId
            // 
            this.dgcShRId.DataPropertyName = "ID";
            this.dgcShRId.HeaderText = "ID";
            this.dgcShRId.MinimumWidth = 9;
            this.dgcShRId.Name = "dgcShRId";
            this.dgcShRId.Visible = false;
            this.dgcShRId.Width = 45;
            // 
            // dgcShRIdS
            // 
            this.dgcShRIdS.DataPropertyName = "IDS";
            this.dgcShRIdS.HeaderText = "IDS";
            this.dgcShRIdS.MinimumWidth = 9;
            this.dgcShRIdS.Name = "dgcShRIdS";
            this.dgcShRIdS.Visible = false;
            this.dgcShRIdS.Width = 45;
            // 
            // bsShR
            // 
            this.bsShR.DataMember = "FK_SALARY_SHEET_TEMPL_R_IDS";
            this.bsShR.DataSource = this.bsShL;
            this.bsShR.Name2 = "bsShR";
            this.bsShR.Sort = "SNR";
            this.bsShR.UseDataGridView = this.dgvShR;
            this.bsShR.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsShR_ListChanged);
            // 
            // bsDep2
            // 
            this.bsDep2.DataMember = "DEPARTMENTS";
            this.bsDep2.MyDataSource = "KlonsAData";
            this.bsDep2.Name2 = "bsDep2";
            // 
            // bsAmatiF
            // 
            this.bsAmatiF.DataMember = "POSITIONS";
            this.bsAmatiF.Filter = "USED=1";
            this.bsAmatiF.MyDataSource = "KlonsAData";
            this.bsAmatiF.Sort = "ID";
            // 
            // myAdapterManager1
            // 
            this.myAdapterManager1.MyDataSource = "KlonsAData";
            this.myAdapterManager1.TableNames = new string[] {
        "SALARY_SHEET_TEMPL",
        "SALARY_SHEET_TEMPL_R",
        null};
            // 
            // Form_SalarySheetTempl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bnavSh);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_SalarySheetTempl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Algu aprēķina lapu sagataves";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_SalarySheetTempl_FormClosed);
            this.Load += new System.EventHandler(this.Form_SalarySheetTempl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnavSh)).EndInit();
            this.bnavSh.ResumeLayout(false);
            this.bnavSh.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAmati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAmatiF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdapterManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bnavSh;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private KlonsLIB.Components.MyDataGridView dgvShL;
        private KlonsLIB.Components.MyDataGridView dgvShR;
        private KlonsLIB.Data.MyBindingSource bsShL;
        private KlonsLIB.Data.MyBindingSource2 bsShR;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Data.MyBindingSource bsDep1;
        private KlonsLIB.Data.MyBindingSource bsDep2;
        private KlonsLIB.Data.MyBindingSource bsPers;
        private KlonsLIB.Data.MyBindingSource bsAmati;
        private KlonsLIB.Data.MyBindingSource bsAmatiF;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLSnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDesr;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShLDep;
        private MyDgvCheckBoxColumn dgcShLUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLId;
        private System.Windows.Forms.ToolStripButton tsbRenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRSNR;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShRIdP;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShRIdAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRIdS;
    }
}