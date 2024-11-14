namespace KlonsP.Forms
{
    partial class FormP_CatT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP_CatT));
            bsCatT = new KlonsLIB.Data.MyBindingSource(components);
            dgvCatT = new KlonsLIB.Components.MyDataGridView();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcKind = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcValue0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bnCatT = new KlonsLIB.Components.MyBindingNavigator();
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
            ((System.ComponentModel.ISupportInitialize)bsCatT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnCatT).BeginInit();
            bnCatT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bsCatT
            // 
            bsCatT.DataMember = "CATT";
            bsCatT.MyDataSource = "KlonsPData";
            bsCatT.Sort = "CODE";
            bsCatT.UseDataGridView = dgvCatT;
            bsCatT.ListChanged += bsCatT_ListChanged;
            // 
            // dgvCatT
            // 
            dgvCatT.AutoGenerateColumns = false;
            dgvCatT.AutoSave = false;
            dgvCatT.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvCatT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCatT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCode, dgcDescr, dgcRate, dgcKind, dgcValue0, dgcID });
            dgvCatT.DataSource = bsCatT;
            dgvCatT.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCatT.Location = new System.Drawing.Point(0, 0);
            dgvCatT.Name = "dgvCatT";
            dgvCatT.Size = new System.Drawing.Size(798, 298);
            dgvCatT.TabIndex = 0;
            dgvCatT.MyKeyDown += dgvCatT_MyKeyDown;
            dgvCatT.MyCheckForChanges += dgvCatT_MyCheckForChanges;
            dgvCatT.CellBeginEdit += dgvCatT_CellBeginEdit;
            dgvCatT.CellDoubleClick += dgvCatT_CellDoubleClick;
            dgvCatT.UserDeletingRow += dgvCatT_UserDeletingRow;
            dgvCatT.KeyPress += dgvCatT_KeyPress;
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
            // dgcKind
            // 
            dgcKind.DataPropertyName = "KIND";
            dgcKind.FalseValue = "0";
            dgcKind.HeaderText = "katram pl";
            dgcKind.Name = "dgcKind";
            dgcKind.ToolTipText = "Nolietojumu rēķina katram PL (nevis visai kategorijai)";
            dgcKind.TrueValue = "1";
            dgcKind.Width = 80;
            // 
            // dgcValue0
            // 
            dgcValue0.DataPropertyName = "VALUE0";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcValue0.DefaultCellStyle = dataGridViewCellStyle3;
            dgcValue0.HeaderText = "sāk.atl.";
            dgcValue0.Name = "dgcValue0";
            dgcValue0.ToolTipText = "Atlikums uz uzskaites sākumu";
            dgcValue0.Width = 80;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            // 
            // bnCatT
            // 
            bnCatT.AddNewItem = bindingNavigatorAddNewItem;
            bnCatT.BindingSource = bsCatT;
            bnCatT.CountItem = bindingNavigatorCountItem;
            bnCatT.CountItemFormat = " no {0}";
            bnCatT.DataGrid = dgvCatT;
            bnCatT.DeleteItem = bindingNavigatorDeleteItem;
            bnCatT.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnCatT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, bindingNavigatorSaveItem });
            bnCatT.Location = new System.Drawing.Point(0, 298);
            bnCatT.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnCatT.MoveLastItem = bindingNavigatorMoveLastItem;
            bnCatT.MoveNextItem = bindingNavigatorMoveNextItem;
            bnCatT.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnCatT.Name = "bnCatT";
            bnCatT.PositionItem = bindingNavigatorPositionItem;
            bnCatT.SaveItem = bindingNavigatorSaveItem;
            bnCatT.Size = new System.Drawing.Size(798, 30);
            bnCatT.TabIndex = 1;
            bnCatT.Text = "myBindingNavigator1";
            bnCatT.ItemDeleting += bnCatT_ItemDeleting;
            bnCatT.SaveClicked += bnCatT_SaveClicked;
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
    "CATT",
    null
    };
            // 
            // FormP_CatT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 328);
            Controls.Add(dgvCatT);
            Controls.Add(bnCatT);
            Name = "FormP_CatT";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Nolietojuma kategorijas nodokļu vajadzībām";
            Load += Form_CatT_Load;
            ((System.ComponentModel.ISupportInitialize)bsCatT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatT).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnCatT).EndInit();
            bnCatT.ResumeLayout(false);
            bnCatT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsCatT;
        private KlonsLIB.Components.MyDataGridView dgvCatT;
        private KlonsLIB.Components.MyBindingNavigator bnCatT;
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
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcValue0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}