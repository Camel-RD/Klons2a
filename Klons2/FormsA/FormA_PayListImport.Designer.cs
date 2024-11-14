
namespace KlonsA.Forms
{
    partial class FormA_PayListImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_PayListImport));
            bsRows = new System.Windows.Forms.BindingSource(components);
            bnavRows = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            dgcIDAM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            bsAmati = new KlonsLIB.Data.MyBindingSource(components);
            dgcAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tbReadText = new System.Windows.Forms.ToolStripButton();
            tbMakeLists = new System.Windows.Forms.ToolStripButton();
            mySplitContainer1 = new KlonsLIB.Components.MySplitContainer();
            tbText = new KlonsLIB.Components.MyTextBox();
            bsAmatiF = new KlonsLIB.Data.MyBindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavRows).BeginInit();
            bnavRows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).BeginInit();
            mySplitContainer1.Panel1.SuspendLayout();
            mySplitContainer1.Panel2.SuspendLayout();
            mySplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsAmatiF).BeginInit();
            SuspendLayout();
            // 
            // bnavRows
            // 
            bnavRows.AddNewItem = null;
            bnavRows.BindingSource = bsRows;
            bnavRows.CountItem = bindingNavigatorCountItem;
            bnavRows.CountItemFormat = " no {0}";
            bnavRows.DataGrid = dgvRows;
            bnavRows.DeleteItem = bindingNavigatorDeleteItem;
            bnavRows.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorDeleteItem, tbReadText, tbMakeLists });
            bnavRows.Location = new System.Drawing.Point(0, 380);
            bnavRows.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavRows.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavRows.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavRows.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavRows.Name = "bnavRows";
            bnavRows.PositionItem = bindingNavigatorPositionItem;
            bnavRows.SaveItem = null;
            bnavRows.Size = new System.Drawing.Size(806, 37);
            bnavRows.TabIndex = 0;
            bnavRows.Text = "myBindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 34);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDate, dgcIDP, dgcIDAM, dgcAmount });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(10, 5);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(786, 206);
            dgvRows.TabIndex = 0;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.CellEndEdit += dgvRows_CellEndEdit;
            dgvRows.CellParsing += dgvRows_CellParsing;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDate.HeaderText = "datums";
            dgcDate.MinimumWidth = 8;
            dgcDate.Name = "dgcDate";
            dgcDate.Width = 85;
            // 
            // dgcIDP
            // 
            dgcIDP.DataPropertyName = "IDP";
            dgcIDP.DataSource = bsPersons;
            dgcIDP.DisplayMember = "YNAME";
            dgcIDP.DisplayStyleForCurrentCellOnly = true;
            dgcIDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIDP.HeaderText = "darbinieks";
            dgcIDP.MaxDropDownItems = 12;
            dgcIDP.MinimumWidth = 8;
            dgcIDP.Name = "dgcIDP";
            dgcIDP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIDP.ValueMember = "ID";
            dgcIDP.Width = 180;
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "PERSONS";
            bsPersons.MyDataSource = "KlonsAData";
            bsPersons.Sort = "ZNAME";
            // 
            // dgcIDAM
            // 
            dgcIDAM.DataPropertyName = "IDAM";
            dgcIDAM.DataSource = bsAmati;
            dgcIDAM.DisplayMember = "TITLE";
            dgcIDAM.DisplayStyleForCurrentCellOnly = true;
            dgcIDAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIDAM.HeaderText = "amats";
            dgcIDAM.MinimumWidth = 8;
            dgcIDAM.Name = "dgcIDAM";
            dgcIDAM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDAM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIDAM.ValueMember = "ID";
            dgcIDAM.Width = 180;
            // 
            // bsAmati
            // 
            bsAmati.DataMember = "POSITIONS";
            bsAmati.MyDataSource = "KlonsAData";
            // 
            // dgcAmount
            // 
            dgcAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcAmount.DefaultCellStyle = dataGridViewCellStyle2;
            dgcAmount.HeaderText = "summa";
            dgcAmount.MinimumWidth = 8;
            dgcAmount.Name = "dgcAmount";
            dgcAmount.Width = 150;
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 34);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 37);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tbReadText
            // 
            tbReadText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tbReadText.Image = (System.Drawing.Image)resources.GetObject("tbReadText.Image");
            tbReadText.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbReadText.Name = "tbReadText";
            tbReadText.Size = new System.Drawing.Size(116, 34);
            tbReadText.Text = "Nolasīt no teksta";
            tbReadText.Click += tbReadText_Click;
            // 
            // tbMakeLists
            // 
            tbMakeLists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tbMakeLists.Image = (System.Drawing.Image)resources.GetObject("tbMakeLists.Image");
            tbMakeLists.ImageTransparentColor = System.Drawing.Color.Magenta;
            tbMakeLists.Name = "tbMakeLists";
            tbMakeLists.Size = new System.Drawing.Size(122, 34);
            tbMakeLists.Text = "Izveidot sarakstus";
            tbMakeLists.Click += tbMakeLists_Click;
            // 
            // mySplitContainer1
            // 
            mySplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            mySplitContainer1.Location = new System.Drawing.Point(0, 0);
            mySplitContainer1.Name = "mySplitContainer1";
            mySplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mySplitContainer1.Panel1
            // 
            mySplitContainer1.Panel1.Controls.Add(tbText);
            mySplitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            // 
            // mySplitContainer1.Panel2
            // 
            mySplitContainer1.Panel2.Controls.Add(dgvRows);
            mySplitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            mySplitContainer1.Size = new System.Drawing.Size(806, 380);
            mySplitContainer1.SplitterDistance = 155;
            mySplitContainer1.TabIndex = 1;
            // 
            // tbText
            // 
            tbText.BorderColor = System.Drawing.SystemColors.ControlText;
            tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            tbText.Location = new System.Drawing.Point(10, 10);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            tbText.Size = new System.Drawing.Size(786, 140);
            tbText.TabIndex = 0;
            tbText.WordWrap = false;
            // 
            // bsAmatiF
            // 
            bsAmatiF.DataMember = "POSITIONS";
            bsAmatiF.MyDataSource = "KlonsAData";
            // 
            // FormA_PayListImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(806, 417);
            Controls.Add(mySplitContainer1);
            Controls.Add(bnavRows);
            Name = "FormA_PayListImport";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Maksājumu sarakstu imports";
            Load += Form_PayListImport_Load;
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavRows).EndInit();
            bnavRows.ResumeLayout(false);
            bnavRows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).EndInit();
            mySplitContainer1.Panel1.ResumeLayout(false);
            mySplitContainer1.Panel1.PerformLayout();
            mySplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).EndInit();
            mySplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsAmatiF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource bsRows;
        private KlonsLIB.Components.MyBindingNavigator bnavRows;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbMakeLists;
        private KlonsLIB.Components.MySplitContainer mySplitContainer1;
        private KlonsLIB.Components.MyTextBox tbText;
        private KlonsLIB.Data.MyBindingSource bsPersons;
        private KlonsLIB.Data.MyBindingSource bsAmati;
        private KlonsLIB.Data.MyBindingSource bsAmatiF;
        private System.Windows.Forms.ToolStripButton tbReadText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIDP;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIDAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAmount;
    }
}