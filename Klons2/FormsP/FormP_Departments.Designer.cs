namespace KlonsP.Forms
{
    partial class FormP_Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_Departments));
            bsDepartments = new KlonsLIB.Data.MyBindingSource(components);
            dgvDepartments = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcGroup = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnDepartments = new KlonsLIB.Components.MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnDepartments).BeginInit();
            bnDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsDepartments
            // 
            bsDepartments.DataMember = "DEPARTMENTS";
            bsDepartments.MyDataSource = "KlonsPData";
            bsDepartments.Sort = "CODE";
            bsDepartments.UseDataGridView = dgvDepartments;
            bsDepartments.ListChanged += bsDepartments_ListChanged;
            // 
            // dgvDepartments
            // 
            dgvDepartments.AutoGenerateColumns = false;
            dgvDepartments.AutoSave = false;
            dgvDepartments.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcDescr, dgcGroup, dgcID });
            dgvDepartments.DataSource = bsDepartments;
            dgvDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDepartments.Location = new System.Drawing.Point(0, 0);
            dgvDepartments.Name = "dgvDepartments";
            dgvDepartments.Size = new System.Drawing.Size(675, 298);
            dgvDepartments.TabIndex = 0;
            dgvDepartments.MyKeyDown += dgvDepartments_MyKeyDown;
            dgvDepartments.MyCheckForChanges += dgvDepartments_MyCheckForChanges;
            dgvDepartments.CellBeginEdit += dgvDepartments_CellBeginEdit;
            dgvDepartments.CellDoubleClick += dgvDepartments_CellDoubleClick;
            dgvDepartments.UserDeletingRow += dgvDepartments_UserDeletingRow;
            dgvDepartments.KeyPress += dgvDepartments_KeyPress;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "CODE";
            dgcCode.HeaderText = "kods";
            dgcCode.Name = "dgcCode";
            dgcCode.ToolTipText = "apakšstruktūrvienību summēšanai";
            dgcCode.Width = 150;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "nosaukums";
            dgcDescr.Name = "dgcDescr";
            dgcDescr.Width = 400;
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
            // bnDepartments
            // 
            bnDepartments.AddNewItem = bindingNavigatorAddNewItem;
            bnDepartments.BindingSource = bsDepartments;
            bnDepartments.CountItem = bindingNavigatorCountItem;
            bnDepartments.CountItemFormat = " no {0}";
            bnDepartments.DataGrid = dgvDepartments;
            bnDepartments.DeleteItem = bindingNavigatorDeleteItem;
            bnDepartments.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnDepartments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bnDepartments.Location = new System.Drawing.Point(0, 298);
            bnDepartments.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnDepartments.MoveLastItem = bindingNavigatorMoveLastItem;
            bnDepartments.MoveNextItem = bindingNavigatorMoveNextItem;
            bnDepartments.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnDepartments.Name = "bnDepartments";
            bnDepartments.PositionItem = bindingNavigatorPositionItem;
            bnDepartments.SaveItem = bindingNavigatorSaveItem;
            bnDepartments.Size = new System.Drawing.Size(675, 30);
            bnDepartments.TabIndex = 1;
            bnDepartments.Text = "myBindingNavigator1";
            bnDepartments.ItemDeleting += bnDepartments_ItemDeleting;
            bnDepartments.SaveClicked += bnDepartments_SaveClicked;
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
    "DEPARTMENTS",
    null
    };
            // 
            // FormP_Departments
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(675, 328);
            Controls.Add(dgvDepartments);
            Controls.Add(bnDepartments);
            Name = "FormP_Departments";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Struktūrvienības";
            Load += Form_Departments_Load;
            ((System.ComponentModel.ISupportInitialize)bsDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartments).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnDepartments).EndInit();
            bnDepartments.ResumeLayout(false);
            bnDepartments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsDepartments;
        private KlonsLIB.Components.MyDataGridView dgvDepartments;
        private KlonsLIB.Components.MyBindingNavigator bnDepartments;
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
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}