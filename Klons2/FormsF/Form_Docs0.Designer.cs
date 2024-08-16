namespace KlonsF.Forms
{
    partial class Form_Docs0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Docs0));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDocs0 = new KlonsLIB.Components.MyDataGridView();
            bsClid = new KlonsLIB.Data.MyBindingSource(components);
            bsDocTyp = new KlonsLIB.Data.MyBindingSource(components);
            bsDocs0 = new KlonsLIB.Data.MyBindingSource(components);
            bnavDocs0 = new KlonsLIB.Components.MyBindingNavigator();
            tsbNew = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tspRefresh = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            tsbSearchPrev = new System.Windows.Forms.ToolStripButton();
            tsbSearch = new System.Windows.Forms.ToolStripTextBox();
            tsbSearchNext = new System.Windows.Forms.ToolStripButton();
            dgcAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcClid = new KlonsLIB.Components.MyDgvMcCBColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTp = new KlonsLIB.Components.MyDgvMcCBColumn();
            dgcDocSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDocs0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs0).BeginInit();
            bnavDocs0.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocs0
            // 
            dgvDocs0.AutoGenerateColumns = false;
            dgvDocs0.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocs0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcAC, dgcClid, dgcDate, dgcDocTp, dgcDocSt, dgcDocNr, dgcSum, dgcPVN, dgcDescr, iDDataGridViewTextBoxColumn });
            dgvDocs0.DataSource = bsDocs0;
            dgvDocs0.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocs0.Location = new System.Drawing.Point(0, 0);
            dgvDocs0.Name = "dgvDocs0";
            dgvDocs0.Size = new System.Drawing.Size(754, 310);
            dgvDocs0.TabIndex = 0;
            dgvDocs0.MyKeyDown += dgvDocs0_MyKeyDown;
            dgvDocs0.MyCheckForChanges += dgvDocs0_MyCheckForChanges;
            dgvDocs0.CellDoubleClick += dgvDocs0_CellDoubleClick;
            dgvDocs0.CellParsing += dgvDocs0_CellParsing;
            dgvDocs0.CellToolTipTextNeeded += dgvDocs0_CellToolTipTextNeeded;
            dgvDocs0.UserDeletingRow += dgvDocs0_UserDeletingRow;
            dgvDocs0.KeyDown += dgvDocs0_KeyDown;
            // 
            // bsClid
            // 
            bsClid.DataMember = "Persons";
            bsClid.MyDataSource = "KlonsData";
            bsClid.Sort = "clid";
            // 
            // bsDocTyp
            // 
            bsDocTyp.DataMember = "DocTyp";
            bsDocTyp.MyDataSource = "KlonsData";
            bsDocTyp.Sort = "id";
            // 
            // bsDocs0
            // 
            bsDocs0.AutoSaveOnDelete = true;
            bsDocs0.DataMember = "DOCS0";
            bsDocs0.MyDataSource = "KlonsData";
            bsDocs0.UseDataGridView = dgvDocs0;
            bsDocs0.MyBeforeRowInsert += bsDocs0_MyBeforeRowInsert;
            bsDocs0.ListChanged += bsDocs0_ListChanged;
            // 
            // bnavDocs0
            // 
            bnavDocs0.AddNewItem = tsbNew;
            bnavDocs0.BindingSource = bsDocs0;
            bnavDocs0.CountItem = bindingNavigatorCountItem;
            bnavDocs0.CountItemFormat = " no {0}";
            bnavDocs0.DataGrid = dgvDocs0;
            bnavDocs0.DeleteItem = tsbDelete;
            bnavDocs0.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavDocs0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavDocs0.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavDocs0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tspRefresh, tsbNew, tsbDelete, tsbSave, tsbSearchPrev, tsbSearch, tsbSearchNext });
            bnavDocs0.Location = new System.Drawing.Point(0, 310);
            bnavDocs0.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavDocs0.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavDocs0.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavDocs0.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavDocs0.Name = "bnavDocs0";
            bnavDocs0.PositionItem = bindingNavigatorPositionItem;
            bnavDocs0.SaveItem = null;
            bnavDocs0.Size = new System.Drawing.Size(754, 28);
            bnavDocs0.TabIndex = 1;
            bnavDocs0.Text = "myBindingNavigator1";
            bnavDocs0.ItemDeleting += bnavDocs0_ItemDeleting;
            // 
            // tsbNew
            // 
            tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
            tsbNew.Name = "tsbNew";
            tsbNew.RightToLeftAutoMirrorImage = true;
            tsbNew.Size = new System.Drawing.Size(71, 25);
            tsbNew.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.Name = "tsbDelete";
            tsbDelete.RightToLeftAutoMirrorImage = true;
            tsbDelete.Size = new System.Drawing.Size(69, 25);
            tsbDelete.Text = "Dzēst";
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
            // tspRefresh
            // 
            tspRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tspRefresh.Image = (System.Drawing.Image)resources.GetObject("tspRefresh.Image");
            tspRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tspRefresh.Name = "tspRefresh";
            tspRefresh.Size = new System.Drawing.Size(59, 25);
            tspRefresh.Text = "Pārlasīt";
            tspRefresh.Click += tspRefresh_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = Properties.Resources.Save1;
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 25);
            tsbSave.Text = "toolStripButton1";
            tsbSave.ToolTipText = "Saglabāt izmaiņas";
            tsbSave.Click += tsbSave_Click;
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
            // dgcAC
            // 
            dgcAC.DataPropertyName = "AC";
            dgcAC.HeaderText = "Konts";
            dgcAC.Name = "dgcAC";
            dgcAC.Width = 64;
            // 
            // dgcClid
            // 
            dgcClid.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            dgcClid.ColumnWidths = "120;400";
            dgcClid.DataPropertyName = "CLID";
            dgcClid.DataSource = bsClid;
            dgcClid.DisplayMember = "ClId";
            dgcClid.HeaderText = "Persona";
            dgcClid.MaxDropDownItems = 15;
            dgcClid.Name = "dgcClid";
            dgcClid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcClid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcClid.ValueMember = "ClId";
            dgcClid.Width = 140;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "DETE";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDate.HeaderText = "Datums";
            dgcDate.Name = "dgcDate";
            dgcDate.Width = 85;
            // 
            // dgcDocTp
            // 
            dgcDocTp.ColumnNames = new string[]
    {
    "id",
    "name"
    };
            dgcDocTp.ColumnWidths = "100;200";
            dgcDocTp.DataPropertyName = "DOCTYP";
            dgcDocTp.DataSource = bsDocTyp;
            dgcDocTp.DisplayMember = "id";
            dgcDocTp.HeaderText = "Dok.veids";
            dgcDocTp.MaxDropDownItems = 15;
            dgcDocTp.Name = "dgcDocTp";
            dgcDocTp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocTp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocTp.ToolTipText = "dokumeta veids";
            dgcDocTp.ValueMember = "id";
            dgcDocTp.Width = 64;
            // 
            // dgcDocSt
            // 
            dgcDocSt.DataPropertyName = "DOCST";
            dgcDocSt.HeaderText = "sērija";
            dgcDocSt.Name = "dgcDocSt";
            dgcDocSt.Width = 48;
            // 
            // dgcDocNr
            // 
            dgcDocNr.DataPropertyName = "DOCNR";
            dgcDocNr.HeaderText = "numurs";
            dgcDocNr.Name = "dgcDocNr";
            dgcDocNr.Width = 88;
            // 
            // dgcSum
            // 
            dgcSum.DataPropertyName = "SUMM";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcSum.DefaultCellStyle = dataGridViewCellStyle2;
            dgcSum.HeaderText = "Summa";
            dgcSum.Name = "dgcSum";
            dgcSum.Width = 80;
            // 
            // dgcPVN
            // 
            dgcPVN.DataPropertyName = "PVN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcPVN.DefaultCellStyle = dataGridViewCellStyle3;
            dgcPVN.HeaderText = "PVN";
            dgcPVN.Name = "dgcPVN";
            dgcPVN.Width = 80;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "Apraksts";
            dgcDescr.Name = "dgcDescr";
            dgcDescr.Width = 130;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form_Docs0
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            ClientSize = new System.Drawing.Size(754, 338);
            Controls.Add(dgvDocs0);
            Controls.Add(bnavDocs0);
            Name = "Form_Docs0";
            Text = "Neapmaksātie rēķini";
            Load += Form_Docs0_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocs0).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs0).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs0).EndInit();
            bnavDocs0.ResumeLayout(false);
            bnavDocs0.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvDocs0;
        private KlonsLIB.Components.MyBindingNavigator bnavDocs0;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private KlonsLIB.Data.MyBindingSource bsDocs0;
        private KlonsLIB.Data.MyBindingSource bsClid;
        private KlonsLIB.Data.MyBindingSource bsDocTyp;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tspRefresh;
        private System.Windows.Forms.ToolStripButton tsbSearchNext;
        private System.Windows.Forms.ToolStripTextBox tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcClid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private KlonsLIB.Components.MyDgvMcCBColumn dgcDocTp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}