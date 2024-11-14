namespace KlonsP.Forms
{
    partial class FormP_Places
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_Places));
            bsPlaces = new KlonsLIB.Data.MyBindingSource(components);
            dgvPlaces = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcGroup = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnPlaces = new KlonsLIB.Components.MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsPlaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaces).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnPlaces).BeginInit();
            bnPlaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsPlaces
            // 
            bsPlaces.DataMember = "PLACES";
            bsPlaces.MyDataSource = "KlonsPData";
            bsPlaces.Sort = "CODE";
            bsPlaces.UseDataGridView = dgvPlaces;
            bsPlaces.ListChanged += bsPlaces_ListChanged;
            // 
            // dgvPlaces
            // 
            dgvPlaces.AutoGenerateColumns = false;
            dgvPlaces.AutoSave = false;
            dgvPlaces.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPlaces.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcDescr, dgcAddr, dgcGroup, dgcID });
            dgvPlaces.DataSource = bsPlaces;
            dgvPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPlaces.Location = new System.Drawing.Point(0, 0);
            dgvPlaces.Name = "dgvPlaces";
            dgvPlaces.Size = new System.Drawing.Size(929, 298);
            dgvPlaces.TabIndex = 0;
            dgvPlaces.MyKeyDown += dgvPlaces_MyKeyDown;
            dgvPlaces.MyCheckForChanges += dgvPlaces_MyCheckForChanges;
            dgvPlaces.CellBeginEdit += dgvPlaces_CellBeginEdit;
            dgvPlaces.CellDoubleClick += dgvPlaces_CellDoubleClick;
            dgvPlaces.UserDeletingRow += dgvPlaces_UserDeletingRow;
            dgvPlaces.KeyPress += dgvPlaces_KeyPress;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "CODE";
            dgcCode.HeaderText = "kods";
            dgcCode.Name = "dgcCode";
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "nosaukums";
            dgcDescr.Name = "dgcDescr";
            dgcDescr.Width = 400;
            // 
            // dgcAddr
            // 
            dgcAddr.DataPropertyName = "ADDR";
            dgcAddr.HeaderText = "adrese";
            dgcAddr.Name = "dgcAddr";
            dgcAddr.Width = 300;
            // 
            // dgcGroup
            // 
            dgcGroup.DataPropertyName = "GROUP";
            dgcGroup.FalseValue = "0";
            dgcGroup.HeaderText = "kopā";
            dgcGroup.Name = "dgcGroup";
            dgcGroup.TrueValue = "1";
            dgcGroup.Width = 50;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            // 
            // bnPlaces
            // 
            bnPlaces.AddNewItem = bindingNavigatorAddNewItem;
            bnPlaces.BindingSource = bsPlaces;
            bnPlaces.CountItem = bindingNavigatorCountItem;
            bnPlaces.CountItemFormat = " no {0}";
            bnPlaces.DataGrid = dgvPlaces;
            bnPlaces.DeleteItem = bindingNavigatorDeleteItem;
            bnPlaces.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnPlaces.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bnPlaces.Location = new System.Drawing.Point(0, 298);
            bnPlaces.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnPlaces.MoveLastItem = bindingNavigatorMoveLastItem;
            bnPlaces.MoveNextItem = bindingNavigatorMoveNextItem;
            bnPlaces.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnPlaces.Name = "bnPlaces";
            bnPlaces.PositionItem = bindingNavigatorPositionItem;
            bnPlaces.SaveItem = bindingNavigatorSaveItem;
            bnPlaces.Size = new System.Drawing.Size(929, 30);
            bnPlaces.TabIndex = 1;
            bnPlaces.Text = "myBindingNavigator1";
            bnPlaces.ItemDeleting += bnPlaces_ItemDeleting;
            bnPlaces.SaveClicked += bnPlaces_SaveClicked;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(63, 27);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 27);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 27);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorSaveItem
            // 
            bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorSaveItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorSaveItem.Image");
            bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorSaveItem.Text = "Saglabāt";
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsPData";
            myAdapterManager1.TableNames = new string[]
    {
    "PLACES",
    null
    };
            // 
            // FormP_Places
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(929, 328);
            Controls.Add(dgvPlaces);
            Controls.Add(bnPlaces);
            Name = "FormP_Places";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Atrašanās vietas";
            Load += Form_Places_Load;
            ((System.ComponentModel.ISupportInitialize)bsPlaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlaces).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnPlaces).EndInit();
            bnPlaces.ResumeLayout(false);
            bnPlaces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsPlaces;
        private KlonsLIB.Components.MyDataGridView dgvPlaces;
        private KlonsLIB.Components.MyBindingNavigator bnPlaces;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAddr;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}