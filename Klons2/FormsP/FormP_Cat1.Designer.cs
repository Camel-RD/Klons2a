namespace KlonsP.Forms
{
    partial class FormP_Cat1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_Cat1));
            bsCat1 = new KlonsLIB.Data.MyBindingSource(components);
            dgvCat1 = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDCD = new KlonsLIB.Components.MyDgvMcComboBoxColumn();
            bsCatD = new KlonsLIB.Data.MyBindingSource(components);
            dgcIDCT = new KlonsLIB.Components.MyDgvMcComboBoxColumn();
            bsCatT = new KlonsLIB.Data.MyBindingSource(components);
            dgcGroup = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnCat1 = new KlonsLIB.Components.MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsCat1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCat1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCatD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCatT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnCat1).BeginInit();
            bnCat1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsCat1
            // 
            bsCat1.DataMember = "CAT1";
            bsCat1.MyDataSource = "KlonsPData";
            bsCat1.Sort = "CODE";
            bsCat1.UseDataGridView = dgvCat1;
            bsCat1.ListChanged += bsCat1_ListChanged;
            // 
            // dgvCat1
            // 
            dgvCat1.AutoGenerateColumns = false;
            dgvCat1.AutoSave = false;
            dgvCat1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCat1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcDescr, dgcIDCD, dgcIDCT, dgcGroup, dgcID });
            dgvCat1.DataSource = bsCat1;
            dgvCat1.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCat1.Location = new System.Drawing.Point(0, 0);
            dgvCat1.Name = "dgvCat1";
            dgvCat1.Size = new System.Drawing.Size(829, 298);
            dgvCat1.TabIndex = 0;
            dgvCat1.MyKeyDown += dgvCat1_MyKeyDown;
            dgvCat1.MyCheckForChanges += dgvCat1_MyCheckForChanges;
            dgvCat1.CellBeginEdit += dgvCat1_CellBeginEdit;
            dgvCat1.CellDoubleClick += dgvCat1_CellDoubleClick;
            dgvCat1.UserDeletingRow += dgvCat1_UserDeletingRow;
            dgvCat1.KeyPress += dgvCat1_KeyPress;
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
            // dgcIDCD
            // 
            dgcIDCD.ColumnNames = new string[]
    {
    "CODE",
    "DESCR"
    };
            dgcIDCD.ColumnWidths = "60;300";
            dgcIDCD.DataPropertyName = "IDCD";
            dgcIDCD.DataSource = bsCatD;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcIDCD.DefaultCellStyle = dataGridViewCellStyle2;
            dgcIDCD.DisplayMember = "CODE";
            dgcIDCD.DisplayStyleForCurrentCellOnly = true;
            dgcIDCD.HeaderText = "nol.kat.";
            dgcIDCD.MaxDropDownItems = 15;
            dgcIDCD.Name = "dgcIDCD";
            dgcIDCD.ToolTipText = "nolietojuma kategorija";
            dgcIDCD.ValueMember = "ID";
            // 
            // bsCatD
            // 
            bsCatD.DataMember = "CATD";
            bsCatD.MyDataSource = "KlonsPData";
            bsCatD.Sort = "CODE";
            // 
            // dgcIDCT
            // 
            dgcIDCT.ColumnNames = new string[]
    {
    "CODE",
    "DESCR"
    };
            dgcIDCT.ColumnWidths = "60;300";
            dgcIDCT.DataPropertyName = "IDCT";
            dgcIDCT.DataSource = bsCatT;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcIDCT.DefaultCellStyle = dataGridViewCellStyle3;
            dgcIDCT.DisplayMember = "CODE";
            dgcIDCT.DisplayStyleForCurrentCellOnly = true;
            dgcIDCT.HeaderText = "nod.kat.";
            dgcIDCT.MaxDropDownItems = 15;
            dgcIDCT.Name = "dgcIDCT";
            dgcIDCT.ToolTipText = "nolietojuma kategorija nodokļu vajadzībām";
            dgcIDCT.ValueMember = "ID";
            // 
            // bsCatT
            // 
            bsCatT.DataMember = "CATT";
            bsCatT.MyDataSource = "KlonsPData";
            bsCatT.Sort = "CODE";
            // 
            // dgcGroup
            // 
            dgcGroup.DataPropertyName = "GROUP";
            dgcGroup.FalseValue = "0";
            dgcGroup.HeaderText = "kopā";
            dgcGroup.Name = "dgcGroup";
            dgcGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcGroup.ToolTipText = "kategosrija apakškategoriju summēšanai";
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
            // bnCat1
            // 
            bnCat1.AddNewItem = bindingNavigatorAddNewItem;
            bnCat1.BindingSource = bsCat1;
            bnCat1.CountItem = bindingNavigatorCountItem;
            bnCat1.CountItemFormat = " no {0}";
            bnCat1.DataGrid = dgvCat1;
            bnCat1.DeleteItem = bindingNavigatorDeleteItem;
            bnCat1.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnCat1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bnCat1.Location = new System.Drawing.Point(0, 298);
            bnCat1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnCat1.MoveLastItem = bindingNavigatorMoveLastItem;
            bnCat1.MoveNextItem = bindingNavigatorMoveNextItem;
            bnCat1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnCat1.Name = "bnCat1";
            bnCat1.PositionItem = bindingNavigatorPositionItem;
            bnCat1.SaveItem = bindingNavigatorSaveItem;
            bnCat1.Size = new System.Drawing.Size(829, 30);
            bnCat1.TabIndex = 1;
            bnCat1.Text = "myBindingNavigator1";
            bnCat1.ItemDeleting += bnCat1_ItemDeleting;
            bnCat1.SaveClicked += bnCat1_SaveClicked;
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
    "CAT1",
    null
    };
            // 
            // FormP_Cat1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(829, 328);
            Controls.Add(dgvCat1);
            Controls.Add(bnCat1);
            Name = "FormP_Cat1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Pamatlīdzekļu kategorijas";
            Load += Form_Cat1_Load;
            ((System.ComponentModel.ISupportInitialize)bsCat1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCat1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCatD).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCatT).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnCat1).EndInit();
            bnCat1.ResumeLayout(false);
            bnCat1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsCat1;
        private KlonsLIB.Components.MyDataGridView dgvCat1;
        private KlonsLIB.Components.MyBindingNavigator bnCat1;
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
        private KlonsLIB.Data.MyBindingSource bsCatD;
        private KlonsLIB.Data.MyBindingSource bsCatT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcIDCD;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcIDCT;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}