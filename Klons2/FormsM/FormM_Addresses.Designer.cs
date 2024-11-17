
namespace KlonsM.FormsM
{
    partial class FormM_Addresses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_Addresses));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            lbPersonName = new System.Windows.Forms.ToolStripLabel();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            bsCountry = new KlonsLIB.Data.MyBindingSource(components);
            bsRows = new KlonsLIB.Data.MyBindingSource2(components);
            bsStores = new KlonsLIB.Data.MyBindingSource(components);
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIdCountry = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcParish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIdStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbPersonName });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(909, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // lbPersonName
            // 
            lbPersonName.Name = "lbPersonName";
            lbPersonName.Size = new System.Drawing.Size(18, 22);
            lbPersonName.Text = "...";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcName, dgcIdCountry, dgcAddress, dgcStreet, dgcCity, dgcState, dgcParish, dgcPostalCode, dgcComments, dgcId, dgcIdStore });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 25);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 40;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(909, 280);
            dgvRows.TabIndex = 8;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.DefaultValuesNeeded += dgvRows_DefaultValuesNeeded;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyPress += dgvRows_KeyPress;
            // 
            // bsCountry
            // 
            bsCountry.DataMember = "M_COUNTRIES";
            bsCountry.MyDataSource = "KlonsMData";
            bsCountry.Sort = "NAME";
            // 
            // bsRows
            // 
            bsRows.DataMember = "FK_M_ADDRESSSES_IDSTORE";
            bsRows.DataSource = bsStores;
            bsRows.UseDataGridView = dgvRows;
            bsRows.ListChanged += bsRows_ListChanged;
            // 
            // bsStores
            // 
            bsStores.DataMember = "M_STORES";
            bsStores.MyDataSource = "KlonsMData";
            // 
            // bNav
            // 
            bNav.AddNewItem = bindingNavigatorAddNewItem;
            bNav.BindingSource = bsRows;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvRows;
            bNav.DeleteItem = bindingNavigatorDeleteItem;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bNav.Location = new System.Drawing.Point(0, 305);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bindingNavigatorSaveItem;
            bNav.Size = new System.Drawing.Size(909, 37);
            bNav.TabIndex = 6;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(63, 34);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 34);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            // bindingNavigatorSaveItem
            // 
            bindingNavigatorSaveItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorSaveItem.Image");
            bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            bindingNavigatorSaveItem.Size = new System.Drawing.Size(81, 34);
            bindingNavigatorSaveItem.Text = "Saglabāt";
            bindingNavigatorSaveItem.Click += bindingNavigatorSaveItem_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_ADDRESSSES",
    null
    };
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "NAME";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.Width = 200;
            // 
            // dgcIdCountry
            // 
            dgcIdCountry.DataPropertyName = "IDCOUNTRY";
            dgcIdCountry.DataSource = bsCountry;
            dgcIdCountry.DisplayMember = "NAME";
            dgcIdCountry.DisplayStyleForCurrentCellOnly = true;
            dgcIdCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIdCountry.HeaderText = "valsts";
            dgcIdCountry.MaxDropDownItems = 15;
            dgcIdCountry.MinimumWidth = 8;
            dgcIdCountry.Name = "dgcIdCountry";
            dgcIdCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIdCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIdCountry.ValueMember = "ID";
            dgcIdCountry.Width = 125;
            // 
            // dgcAddress
            // 
            dgcAddress.DataPropertyName = "ADDRESS";
            dgcAddress.HeaderText = "adrese";
            dgcAddress.MinimumWidth = 8;
            dgcAddress.Name = "dgcAddress";
            dgcAddress.Width = 400;
            // 
            // dgcStreet
            // 
            dgcStreet.DataPropertyName = "STREET";
            dgcStreet.HeaderText = "iela, nr.";
            dgcStreet.Name = "dgcStreet";
            dgcStreet.Width = 125;
            // 
            // dgcCity
            // 
            dgcCity.DataPropertyName = "CITY";
            dgcCity.HeaderText = "pilsēta";
            dgcCity.Name = "dgcCity";
            dgcCity.Width = 125;
            // 
            // dgcState
            // 
            dgcState.DataPropertyName = "STATE";
            dgcState.HeaderText = "novads";
            dgcState.Name = "dgcState";
            dgcState.Width = 125;
            // 
            // dgcParish
            // 
            dgcParish.DataPropertyName = "PARISH";
            dgcParish.HeaderText = "pagasts";
            dgcParish.Name = "dgcParish";
            dgcParish.Width = 125;
            // 
            // dgcPostalCode
            // 
            dgcPostalCode.DataPropertyName = "POSTALCODE";
            dgcPostalCode.HeaderText = "indeks";
            dgcPostalCode.Name = "dgcPostalCode";
            dgcPostalCode.Width = 90;
            // 
            // dgcComments
            // 
            dgcComments.DataPropertyName = "COMMENTS";
            dgcComments.HeaderText = "komentārs";
            dgcComments.Name = "dgcComments";
            dgcComments.Width = 200;
            // 
            // dgcId
            // 
            dgcId.DataPropertyName = "ID";
            dgcId.HeaderText = "ID";
            dgcId.MinimumWidth = 8;
            dgcId.Name = "dgcId";
            dgcId.Visible = false;
            dgcId.Width = 60;
            // 
            // dgcIdStore
            // 
            dgcIdStore.DataPropertyName = "IDSTORE";
            dgcIdStore.HeaderText = "IDSTORE";
            dgcIdStore.MinimumWidth = 8;
            dgcIdStore.Name = "dgcIdStore";
            dgcIdStore.Visible = false;
            dgcIdStore.Width = 60;
            // 
            // FormM_Addresses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(909, 342);
            Controls.Add(dgvRows);
            Controls.Add(toolStrip1);
            Controls.Add(bNav);
            Name = "FormM_Addresses";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Adreses";
            Load += FormM_Addtrsses_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStores).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbPersonName;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource2 bsRows;
        private KlonsLIB.Data.MyBindingSource bsStores;
        private KlonsLIB.Components.MyBindingNavigator bNav;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Data.MyBindingSource bsCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIdCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcParish;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdStore;
    }
}