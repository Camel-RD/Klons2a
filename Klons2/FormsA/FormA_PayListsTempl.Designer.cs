namespace KlonsA.Forms
{
    partial class FormA_PayListsTempl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_PayListsTempl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            bnavSh = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
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
            tsbRenum = new System.Windows.Forms.ToolStripButton();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dgvShL = new KlonsLIB.Components.MyDataGridView();
            dgcShLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShLSnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShLCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDesr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShLDep = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsDep1 = new KlonsLIB.Data.MyBindingSource(components);
            bsShL = new KlonsLIB.Data.MyBindingSource(components);
            dgvShR = new KlonsLIB.Components.MyDataGridView();
            dgcShRId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShRIdS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShRSNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcShRIdP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsPers = new KlonsLIB.Data.MyBindingSource(components);
            dgcShRIdAM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsAmati = new KlonsLIB.Data.MyBindingSource(components);
            bsShR = new KlonsLIB.Data.MyBindingSource2(components);
            bsDep2 = new KlonsLIB.Data.MyBindingSource(components);
            bsAmatiF = new KlonsLIB.Data.MyBindingSource(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bnavSh).BeginInit();
            bnavSh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDep1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsShL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsShR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDep2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bnavSh
            // 
            bnavSh.AddNewItem = bindingNavigatorAddNewItem;
            bnavSh.CountItem = bindingNavigatorCountItem;
            bnavSh.CountItemFormat = " no {0}";
            bnavSh.DeleteItem = null;
            bnavSh.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavSh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavSh.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavSh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave, tsbRenum });
            bnavSh.Location = new System.Drawing.Point(0, 413);
            bnavSh.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavSh.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavSh.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavSh.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavSh.Name = "bnavSh";
            bnavSh.PositionItem = bindingNavigatorPositionItem;
            bnavSh.SaveItem = null;
            bnavSh.Size = new System.Drawing.Size(648, 28);
            bnavSh.TabIndex = 0;
            bnavSh.Text = "myBindingNavigator1";
            bnavSh.ItemDeleting += bnavSh_ItemDeleting;
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
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(16, 25);
            toolStripLabel1.Text = "..";
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
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // tsbRenum
            // 
            tsbRenum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbRenum.Image = (System.Drawing.Image)resources.GetObject("tsbRenum.Image");
            tsbRenum.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRenum.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            tsbRenum.Name = "tsbRenum";
            tsbRenum.Size = new System.Drawing.Size(86, 25);
            tsbRenum.Text = "Pārnumurēt";
            tsbRenum.Click += tsbRenum_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvShL);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvShR);
            splitContainer1.Size = new System.Drawing.Size(648, 413);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 1;
            // 
            // dgvShL
            // 
            dgvShL.AllowUserToDeleteRows = false;
            dgvShL.AutoGenerateColumns = false;
            dgvShL.AutoSave = false;
            dgvShL.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvShL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvShL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcShLId, dgcShLSnr, dgcShLCode, dgcDesr, dgcShLDep });
            dgvShL.DataSource = bsShL;
            dgvShL.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvShL.Location = new System.Drawing.Point(0, 0);
            dgvShL.Name = "dgvShL";
            dgvShL.Size = new System.Drawing.Size(648, 194);
            dgvShL.TabIndex = 0;
            dgvShL.MyKeyDown += dgvShL_MyKeyDown;
            dgvShL.MyCheckForChanges += dgvShL_MyCheckForChanges;
            dgvShL.CellDoubleClick += dgvShL_CellDoubleClick;
            dgvShL.CurrentCellChanged += dgvShL_CurrentCellChanged;
            dgvShL.DefaultValuesNeeded += dgvShL_DefaultValuesNeeded;
            dgvShL.UserDeletingRow += dgvShL_UserDeletingRow;
            dgvShL.Enter += dgvShL_Enter;
            // 
            // dgcShLId
            // 
            dgcShLId.DataPropertyName = "ID";
            dgcShLId.HeaderText = "ID";
            dgcShLId.Name = "dgcShLId";
            dgcShLId.Visible = false;
            dgcShLId.Width = 40;
            // 
            // dgcShLSnr
            // 
            dgcShLSnr.DataPropertyName = "SNR";
            dgcShLSnr.HeaderText = "npk";
            dgcShLSnr.Name = "dgcShLSnr";
            dgcShLSnr.Width = 40;
            // 
            // dgcShLCode
            // 
            dgcShLCode.DataPropertyName = "CODE";
            dgcShLCode.HeaderText = "CODE";
            dgcShLCode.Name = "dgcShLCode";
            dgcShLCode.Visible = false;
            // 
            // dgcDesr
            // 
            dgcDesr.DataPropertyName = "DESCR";
            dgcDesr.HeaderText = "apraksts";
            dgcDesr.Name = "dgcDesr";
            dgcDesr.Width = 200;
            // 
            // dgcShLDep
            // 
            dgcShLDep.DataPropertyName = "DEP";
            dgcShLDep.DataSource = bsDep1;
            dgcShLDep.DisplayMember = "DESCR";
            dgcShLDep.DisplayStyleForCurrentCellOnly = true;
            dgcShLDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcShLDep.HeaderText = "str.v.";
            dgcShLDep.MaxDropDownItems = 15;
            dgcShLDep.Name = "dgcShLDep";
            dgcShLDep.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcShLDep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcShLDep.ValueMember = "ID";
            dgcShLDep.Width = 200;
            // 
            // bsDep1
            // 
            bsDep1.DataMember = "DEPARTMENTS";
            bsDep1.MyDataSource = "KlonsAData";
            bsDep1.Name2 = "bsDep1";
            // 
            // bsShL
            // 
            bsShL.DataMember = "PAYLIST_TEMPL";
            bsShL.MyDataSource = "KlonsAData";
            bsShL.Name2 = "bsShL";
            bsShL.Sort = "SNR";
            bsShL.UseDataGridView = dgvShL;
            bsShL.ListChanged += bsShL_ListChanged;
            // 
            // dgvShR
            // 
            dgvShR.AllowUserToDeleteRows = false;
            dgvShR.AutoGenerateColumns = false;
            dgvShR.AutoSave = false;
            dgvShR.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvShR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvShR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcShRId, dgcShRIdS, dgcShRSNR, dgcShRIdP, dgcShRIdAM });
            dgvShR.DataSource = bsShR;
            dgvShR.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvShR.Location = new System.Drawing.Point(0, 0);
            dgvShR.Name = "dgvShR";
            dgvShR.Size = new System.Drawing.Size(648, 213);
            dgvShR.TabIndex = 0;
            dgvShR.MyKeyDown += dgvShR_MyKeyDown;
            dgvShR.CellBeginEdit += dgvShR_CellBeginEdit;
            dgvShR.CellDoubleClick += dgvShR_CellDoubleClick;
            dgvShR.CellEndEdit += dgvShR_CellEndEdit;
            dgvShR.DefaultValuesNeeded += dgvShR_DefaultValuesNeeded;
            dgvShR.UserDeletingRow += dgvShR_UserDeletingRow;
            dgvShR.Enter += dgvShR_Enter;
            // 
            // dgcShRId
            // 
            dgcShRId.DataPropertyName = "ID";
            dgcShRId.HeaderText = "ID";
            dgcShRId.Name = "dgcShRId";
            dgcShRId.Visible = false;
            dgcShRId.Width = 40;
            // 
            // dgcShRIdS
            // 
            dgcShRIdS.DataPropertyName = "IDS";
            dgcShRIdS.HeaderText = "IDS";
            dgcShRIdS.Name = "dgcShRIdS";
            dgcShRIdS.Visible = false;
            dgcShRIdS.Width = 40;
            // 
            // dgcShRSNR
            // 
            dgcShRSNR.DataPropertyName = "SNR";
            dgcShRSNR.HeaderText = "npk";
            dgcShRSNR.Name = "dgcShRSNR";
            dgcShRSNR.Width = 40;
            // 
            // dgcShRIdP
            // 
            dgcShRIdP.DataPropertyName = "IDP";
            dgcShRIdP.DataSource = bsPers;
            dgcShRIdP.DisplayMember = "ZNAME";
            dgcShRIdP.DisplayStyleForCurrentCellOnly = true;
            dgcShRIdP.DropDownWidth = 300;
            dgcShRIdP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcShRIdP.HeaderText = "darbinieks";
            dgcShRIdP.MaxDropDownItems = 15;
            dgcShRIdP.Name = "dgcShRIdP";
            dgcShRIdP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcShRIdP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcShRIdP.ValueMember = "ID";
            dgcShRIdP.Width = 300;
            // 
            // bsPers
            // 
            bsPers.DataMember = "PERSONS";
            bsPers.MyDataSource = "KlonsAData";
            bsPers.Name2 = "bsPers";
            bsPers.Sort = "ZNAME";
            // 
            // dgcShRIdAM
            // 
            dgcShRIdAM.DataPropertyName = "IDAM";
            dgcShRIdAM.DataSource = bsAmati;
            dgcShRIdAM.DisplayMember = "TITLE";
            dgcShRIdAM.DisplayStyleForCurrentCellOnly = true;
            dgcShRIdAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcShRIdAM.HeaderText = "amats";
            dgcShRIdAM.Name = "dgcShRIdAM";
            dgcShRIdAM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcShRIdAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcShRIdAM.ValueMember = "ID";
            dgcShRIdAM.Width = 200;
            // 
            // bsAmati
            // 
            bsAmati.DataMember = "POSITIONS";
            bsAmati.Filter = "USED=1";
            bsAmati.MyDataSource = "KlonsAData";
            bsAmati.Sort = "ID";
            // 
            // bsShR
            // 
            bsShR.DataMember = "FK_PAYLIST_TEMPL_R_IDS";
            bsShR.DataSource = bsShL;
            bsShR.Name2 = "bsShR";
            bsShR.Sort = "SNR";
            bsShR.UseDataGridView = dgvShR;
            bsShR.ListChanged += bsShR_ListChanged;
            // 
            // bsDep2
            // 
            bsDep2.DataMember = "DEPARTMENTS";
            bsDep2.MyDataSource = "KlonsAData";
            bsDep2.Name2 = "bsDep2";
            // 
            // bsAmatiF
            // 
            bsAmatiF.DataMember = "POSITIONS";
            bsAmatiF.Filter = "USED=1";
            bsAmatiF.MyDataSource = "KlonsAData";
            bsAmatiF.Sort = "ID";
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "PAYLIST_TEMPL",
    "PAYLIST_TEMPL_R",
    null
    };
            // 
            // FormA_PayListsTempl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(648, 441);
            Controls.Add(splitContainer1);
            Controls.Add(bnavSh);
            Name = "FormA_PayListsTempl";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Maksājumu sarakstu sagataves";
            FormClosed += Form_PayListsTempl_FormClosed;
            Load += Form_PayListsTempl_Load;
            ((System.ComponentModel.ISupportInitialize)bnavSh).EndInit();
            bnavSh.ResumeLayout(false);
            bnavSh.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShL).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDep1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsShL).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShR).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsShR).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDep2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiF).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLSnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShLCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDesr;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShLDep;
        private System.Windows.Forms.ToolStripButton tsbRenum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRIdS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcShRSNR;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShRIdP;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcShRIdAM;
    }
}