namespace KlonsF.FormsF_pmt
{
    partial class Form_PmtDocList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PmtDocList));
            dgvDocs = new KlonsLIB.Components.MyDataGridView();
            dgcMSGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcMSGIDSTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcACCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTP = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcDESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsDocs = new KlonsLIB.Data.MyBindingSource(components);
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbAddNew = new System.Windows.Forms.ToolStripButton();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            bnavDocs = new KlonsLIB.Components.MyBindingNavigator();
            tsbOpenDoc = new System.Windows.Forms.ToolStripButton();
            tsbReloadData = new System.Windows.Forms.ToolStripButton();
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            bsAccounts = new KlonsLIB.Data.MyBindingSource(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            tsbCopy = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs).BeginInit();
            bnavDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // dgvDocs
            // 
            dgvDocs.AllowUserToAddRows = false;
            dgvDocs.AllowUserToDeleteRows = false;
            dgvDocs.AutoGenerateColumns = false;
            dgvDocs.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcMSGID, dgcMSGIDSTR, dgcDT, dgcACCOUNT, dgcCT, dgcAMOUNT, dgcTP, dgcDESCR });
            dgvDocs.DataSource = bsDocs;
            dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocs.Location = new System.Drawing.Point(0, 0);
            dgvDocs.Name = "dgvDocs";
            dgvDocs.ReadOnly = true;
            dgvDocs.Size = new System.Drawing.Size(1101, 248);
            dgvDocs.TabIndex = 4;
            dgvDocs.MyKeyDown += dgvDocs_MyKeyDown;
            dgvDocs.MyCheckForChanges += dgvDocs_MyCheckForChanges;
            dgvDocs.CellDoubleClick += dgvDocs_CellDoubleClick;
            dgvDocs.CellFormatting += dgvDocs_CellFormatting;
            // 
            // dgcMSGID
            // 
            dgcMSGID.DataPropertyName = "MSGID";
            dgcMSGID.HeaderText = "npk.";
            dgcMSGID.Name = "dgcMSGID";
            dgcMSGID.ReadOnly = true;
            dgcMSGID.ToolTipText = "Maksājumu uzdevuma numurs pēc kārtas";
            dgcMSGID.Width = 40;
            // 
            // dgcMSGIDSTR
            // 
            dgcMSGIDSTR.DataPropertyName = "MSGIDSTR";
            dgcMSGIDSTR.HeaderText = "identif.";
            dgcMSGIDSTR.Name = "dgcMSGIDSTR";
            dgcMSGIDSTR.ReadOnly = true;
            dgcMSGIDSTR.ToolTipText = "Maksājuma uzdevuma identifikators";
            dgcMSGIDSTR.Width = 80;
            // 
            // dgcDT
            // 
            dgcDT.DataPropertyName = "DT";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            dgcDT.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDT.HeaderText = "datums, laiks";
            dgcDT.Name = "dgcDT";
            dgcDT.ReadOnly = true;
            dgcDT.ToolTipText = "izveidošanas datums, laiks";
            dgcDT.Width = 150;
            // 
            // dgcACCOUNT
            // 
            dgcACCOUNT.DataPropertyName = "ACCOUNT";
            dgcACCOUNT.HeaderText = "konts";
            dgcACCOUNT.Name = "dgcACCOUNT";
            dgcACCOUNT.ReadOnly = true;
            dgcACCOUNT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcACCOUNT.ToolTipText = "Konts no kura jāmaksā";
            dgcACCOUNT.Width = 160;
            // 
            // dgcCT
            // 
            dgcCT.DataPropertyName = "CT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCT.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCT.HeaderText = "skaits";
            dgcCT.Name = "dgcCT";
            dgcCT.ReadOnly = true;
            dgcCT.ToolTipText = "Transakciju skaits maksājuma uzdevumā";
            dgcCT.Width = 60;
            // 
            // dgcAMOUNT
            // 
            dgcAMOUNT.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcAMOUNT.DefaultCellStyle = dataGridViewCellStyle3;
            dgcAMOUNT.HeaderText = "summa";
            dgcAMOUNT.Name = "dgcAMOUNT";
            dgcAMOUNT.ReadOnly = true;
            dgcAMOUNT.ToolTipText = "Maksājumu uzdevuma kopējā summa";
            dgcAMOUNT.Width = 120;
            // 
            // dgcTP
            // 
            dgcTP.DataPropertyName = "TP";
            dgcTP.FalseValue = "0";
            dgcTP.HeaderText = "veids";
            dgcTP.Name = "dgcTP";
            dgcTP.ReadOnly = true;
            dgcTP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcTP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcTP.ToolTipText = "Maksājumu uzdevuma veids (SALA, SEPA)";
            dgcTP.TrueValue = "1";
            dgcTP.Width = 60;
            // 
            // dgcDESCR
            // 
            dgcDESCR.DataPropertyName = "DESCR";
            dgcDESCR.HeaderText = "apraksts";
            dgcDESCR.Name = "dgcDESCR";
            dgcDESCR.ReadOnly = true;
            dgcDESCR.Width = 300;
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "F_PMT_MSG";
            bsDocs.MyDataSource = "KlonsData";
            bsDocs.Sort = "DT, MSGID";
            bsDocs.ListChanged += bsDocs_ListChanged;
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
            // tsbAddNew
            // 
            tsbAddNew.Image = (System.Drawing.Image)resources.GetObject("tsbAddNew.Image");
            tsbAddNew.Name = "tsbAddNew";
            tsbAddNew.RightToLeftAutoMirrorImage = true;
            tsbAddNew.Size = new System.Drawing.Size(66, 22);
            tsbAddNew.Text = "Jauns";
            tsbAddNew.Click += tsbAddNew_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.Name = "tsbDelete";
            tsbDelete.RightToLeftAutoMirrorImage = true;
            tsbDelete.Size = new System.Drawing.Size(64, 22);
            tsbDelete.Text = "Dzēst";
            tsbDelete.Click += tsbDelete_Click;
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
            bnavDocs.AddNewItem = null;
            bnavDocs.BindingSource = bsDocs;
            bnavDocs.CountItem = bindingNavigatorCountItem;
            bnavDocs.CountItemFormat = " no {0}";
            bnavDocs.DeleteItem = null;
            bnavDocs.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, tsbOpenDoc, bindingNavigatorSeparator2, tsbAddNew, tsbCopy, tsbDelete, tsbSave, tsbReloadData });
            bnavDocs.Location = new System.Drawing.Point(0, 248);
            bnavDocs.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavDocs.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavDocs.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavDocs.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavDocs.Name = "bnavDocs";
            bnavDocs.PositionItem = bindingNavigatorPositionItem;
            bnavDocs.SaveItem = null;
            bnavDocs.Size = new System.Drawing.Size(1101, 25);
            bnavDocs.TabIndex = 2;
            bnavDocs.Text = "bindingNavigator1";
            // 
            // tsbOpenDoc
            // 
            tsbOpenDoc.Image = Properties.Resources.open;
            tsbOpenDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOpenDoc.Name = "tsbOpenDoc";
            tsbOpenDoc.Size = new System.Drawing.Size(65, 22);
            tsbOpenDoc.Text = "Atvērt";
            tsbOpenDoc.Click += tsbOpenDoc_Click;
            // 
            // tsbReloadData
            // 
            tsbReloadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbReloadData.Image = (System.Drawing.Image)resources.GetObject("tsbReloadData.Image");
            tsbReloadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbReloadData.Name = "tsbReloadData";
            tsbReloadData.Size = new System.Drawing.Size(98, 22);
            tsbReloadData.Text = "Pārlasīt datus";
            tsbReloadData.ToolTipText = "Ielādēt datus no jauna";
            tsbReloadData.Click += tsbReloadData_Click;
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "Persons";
            bsPersons.MyDataSource = "KlonsData";
            bsPersons.Sort = "clid";
            // 
            // bsAccounts
            // 
            bsAccounts.DataMember = "F_PMT_ACCOUNTS";
            bsAccounts.MyDataSource = "KlonsData";
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
            // tsbCopy
            // 
            tsbCopy.Image = (System.Drawing.Image)resources.GetObject("tsbCopy.Image");
            tsbCopy.Name = "tsbCopy";
            tsbCopy.Size = new System.Drawing.Size(65, 22);
            tsbCopy.Text = "Kopēt";
            tsbCopy.ToolTipText = "Kopēt";
            tsbCopy.Click += tsbCopy_Click;
            // 
            // Form_PmtDocList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1101, 273);
            Controls.Add(dgvDocs);
            Controls.Add(bnavDocs);
            Name = "Form_PmtDocList";
            Text = "Maksājuma uzdevumu saraksts";
            Load += Form_PmtDocList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavDocs).EndInit();
            bnavDocs.ResumeLayout(false);
            bnavDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KlonsLIB.Components.MyDataGridView dgvDocs;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAddNew;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Components.MyBindingNavigator bnavDocs;
        private KlonsLIB.Data.MyBindingSource bsDocs;
        private KlonsLIB.Data.MyBindingSource bsPersons;
        private KlonsLIB.Data.MyBindingSource bsAccounts;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripButton tsbReloadData;
        private System.Windows.Forms.ToolStripButton tsbOpenDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMSGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcMSGIDSTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcACCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAMOUNT;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDESCR;
        private System.Windows.Forms.ToolStripButton tsbCopy;
    }
}