namespace KlonsP.Forms
{
    partial class FormP_CatD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_CatD));
            bsCatD = new KlonsLIB.Data.MyBindingSource(components);
            dgvCatD = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnCatd = new KlonsLIB.Components.MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsCatD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnCatd).BeginInit();
            bnCatd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsCatD
            // 
            bsCatD.DataMember = "CATD";
            bsCatD.MyDataSource = "KlonsPData";
            bsCatD.Sort = "CODE";
            bsCatD.UseDataGridView = dgvCatD;
            bsCatD.ListChanged += bsCatD_ListChanged;
            // 
            // dgvCatD
            // 
            dgvCatD.AutoGenerateColumns = false;
            dgvCatD.AutoSave = false;
            dgvCatD.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCatD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCatD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcDescr, dgcRate, dgcID });
            dgvCatD.DataSource = bsCatD;
            dgvCatD.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCatD.Location = new System.Drawing.Point(0, 0);
            dgvCatD.Name = "dgvCatD";
            dgvCatD.Size = new System.Drawing.Size(633, 298);
            dgvCatD.TabIndex = 0;
            dgvCatD.MyKeyDown += dgvCatD_MyKeyDown;
            dgvCatD.MyCheckForChanges += dgvCatD_MyCheckForChanges;
            dgvCatD.CellBeginEdit += dgvCatD_CellBeginEdit;
            dgvCatD.CellDoubleClick += dgvCatD_CellDoubleClick;
            dgvCatD.UserDeletingRow += dgvCatD_UserDeletingRow;
            dgvCatD.KeyPress += dgvCatD_KeyPress;
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
            // dgcRate
            // 
            dgcRate.DataPropertyName = "RATE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRate.DefaultCellStyle = dataGridViewCellStyle2;
            dgcRate.HeaderText = "likme";
            dgcRate.Name = "dgcRate";
            dgcRate.ToolTipText = "nolietojuma likme, %";
            dgcRate.Width = 60;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            // 
            // bnCatd
            // 
            bnCatd.AddNewItem = bindingNavigatorAddNewItem;
            bnCatd.BindingSource = bsCatD;
            bnCatd.CountItem = bindingNavigatorCountItem;
            bnCatd.CountItemFormat = " no {0}";
            bnCatd.DataGrid = dgvCatD;
            bnCatd.DeleteItem = bindingNavigatorDeleteItem;
            bnCatd.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnCatd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bnCatd.Location = new System.Drawing.Point(0, 298);
            bnCatd.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnCatd.MoveLastItem = bindingNavigatorMoveLastItem;
            bnCatd.MoveNextItem = bindingNavigatorMoveNextItem;
            bnCatd.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnCatd.Name = "bnCatd";
            bnCatd.PositionItem = bindingNavigatorPositionItem;
            bnCatd.SaveItem = bindingNavigatorSaveItem;
            bnCatd.Size = new System.Drawing.Size(633, 30);
            bnCatd.TabIndex = 1;
            bnCatd.Text = "myBindingNavigator1";
            bnCatd.ItemDeleting += bnCatd_ItemDeleting;
            bnCatd.SaveClicked += bnCatd_SaveClicked;
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
    "CATD",
    null
    };
            // 
            // FormP_CatD
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(633, 328);
            Controls.Add(dgvCatD);
            Controls.Add(bnCatd);
            Name = "FormP_CatD";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Nolietojuma kategorijas";
            Load += Form_CatD_Load;
            ((System.ComponentModel.ISupportInitialize)bsCatD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatD).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnCatd).EndInit();
            bnCatd.ResumeLayout(false);
            bnCatd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsCatD;
        private KlonsLIB.Components.MyDataGridView dgvCatD;
        private KlonsLIB.Components.MyBindingNavigator bnCatd;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}