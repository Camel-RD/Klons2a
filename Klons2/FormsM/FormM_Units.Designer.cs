
namespace KlonsM.FormsM
{
    partial class FormM_Units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_Units));
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsUnits = new KlonsLIB.Data.MyBindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
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
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bNav
            // 
            bNav.AddNewItem = bindingNavigatorAddNewItem;
            bNav.BindingSource = bsUnits;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvRows;
            bNav.DeleteItem = bindingNavigatorDeleteItem;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bNav.Location = new System.Drawing.Point(0, 294);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bindingNavigatorSaveItem;
            bNav.Size = new System.Drawing.Size(445, 37);
            bNav.TabIndex = 0;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bsUnits
            // 
            bsUnits.DataMember = "M_UNITS";
            bsUnits.MyDataSource = "KlonsMData";
            bsUnits.Sort = "ID";
            bsUnits.ListChanged += bsUnits_ListChanged;
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
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcName, dgcCode2, dgcId });
            dgvRows.DataSource = bsUnits;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersVisible = false;
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(445, 294);
            dgvRows.TabIndex = 1;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyPress += dgvRows_KeyPress;
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 34);
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
            bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorSaveItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorSaveItem.Image");
            bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 34);
            bindingNavigatorSaveItem.Text = "Saglabāt";
            bindingNavigatorSaveItem.Click += bindingNavigatorSaveItem_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_UNITS",
    null
    };
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "CODE";
            dgcCode.HeaderText = "kods";
            dgcCode.MinimumWidth = 8;
            dgcCode.Name = "dgcCode";
            dgcCode.Width = 80;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "NAME";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.Width = 200;
            // 
            // dgcCode2
            // 
            dgcCode2.DataPropertyName = "CODE2";
            dgcCode2.HeaderText = "kods2";
            dgcCode2.Name = "dgcCode2";
            dgcCode2.Width = 80;
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
            // FormM_Units
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(445, 331);
            Controls.Add(dgvRows);
            Controls.Add(bNav);
            Name = "FormM_Units";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mērvienības";
            Load += FormM_Units_Load;
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private KlonsLIB.Data.MyBindingSource bsUnits;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
    }
}