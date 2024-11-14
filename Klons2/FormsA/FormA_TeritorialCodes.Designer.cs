using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_TeritorialCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_TeritorialCodes));
            dgvTerKodi = new MyDataGridView();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsTerKodi = new KlonsLIB.Data.MyBindingSource(components);
            bnavTerKodi = new MyBindingNavigator();
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
            tsbSave = new System.Windows.Forms.ToolStripButton();
            label1 = new System.Windows.Forms.Label();
            tbSearch = new MyTextBox();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTerKodi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTerKodi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavTerKodi).BeginInit();
            bnavTerKodi.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTerKodi
            // 
            dgvTerKodi.AutoGenerateColumns = false;
            dgvTerKodi.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvTerKodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTerKodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcID, dgcDescr });
            dgvTerKodi.DataSource = bsTerKodi;
            dgvTerKodi.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTerKodi.Location = new System.Drawing.Point(0, 29);
            dgvTerKodi.Name = "dgvTerKodi";
            dgvTerKodi.Size = new System.Drawing.Size(510, 359);
            dgvTerKodi.TabIndex = 0;
            dgvTerKodi.MyKeyDown += dgvTerKodi_MyKeyDown;
            dgvTerKodi.MyCheckForChanges += dgvTerKodi_MyCheckForChanges;
            dgvTerKodi.CellDoubleClick += dgvTerKodi_CellDoubleClick;
            dgvTerKodi.UserDeletingRow += dgvTerKodi_UserDeletingRow;
            dgvTerKodi.KeyPress += dgvTerKodi_KeyPress;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "Kods";
            dgcID.MinimumWidth = 4;
            dgcID.Name = "dgcID";
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "Nosaukums";
            dgcDescr.MinimumWidth = 4;
            dgcDescr.Name = "dgcDescr";
            dgcDescr.Width = 300;
            // 
            // bsTerKodi
            // 
            bsTerKodi.AutoSaveOnDelete = true;
            bsTerKodi.DataMember = "TERITORIAL_CODES";
            bsTerKodi.MyDataSource = "KlonsAData";
            bsTerKodi.Sort = "ID";
            bsTerKodi.UseDataGridView = dgvTerKodi;
            bsTerKodi.ListChanged += bsTerKodi_ListChanged;
            // 
            // bnavTerKodi
            // 
            bnavTerKodi.AddNewItem = bindingNavigatorAddNewItem;
            bnavTerKodi.BindingSource = bsTerKodi;
            bnavTerKodi.CountItem = bindingNavigatorCountItem;
            bnavTerKodi.CountItemFormat = " no {0}";
            bnavTerKodi.DataGrid = dgvTerKodi;
            bnavTerKodi.DeleteItem = bindingNavigatorDeleteItem;
            bnavTerKodi.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavTerKodi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavTerKodi.Location = new System.Drawing.Point(0, 388);
            bnavTerKodi.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavTerKodi.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavTerKodi.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavTerKodi.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavTerKodi.Name = "bnavTerKodi";
            bnavTerKodi.PositionItem = bindingNavigatorPositionItem;
            bnavTerKodi.SaveItem = null;
            bnavTerKodi.Size = new System.Drawing.Size(510, 30);
            bnavTerKodi.TabIndex = 1;
            bnavTerKodi.Text = "myBindingNavigator1";
            bnavTerKodi.ItemDeleting += bnavTerKodi_ItemDeleting;
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
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 27);
            tsbSave.Text = "toolStripButton1";
            tsbSave.Click += tsbSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 17);
            label1.TabIndex = 2;
            label1.Text = "Meklēt:";
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(58, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(119, 23);
            tbSearch.TabIndex = 3;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(510, 29);
            panel1.TabIndex = 4;
            // 
            // FormA_TeritorialCodes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(510, 418);
            Controls.Add(dgvTerKodi);
            Controls.Add(panel1);
            Controls.Add(bnavTerKodi);
            Name = "FormA_TeritorialCodes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Teritoriju kodi";
            Load += Form_TeritorialCodes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTerKodi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTerKodi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavTerKodi).EndInit();
            bnavTerKodi.ResumeLayout(false);
            bnavTerKodi.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyDataGridView dgvTerKodi;
        private MyBindingNavigator bnavTerKodi;
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
        private KlonsLIB.Data.MyBindingSource bsTerKodi;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.Panel panel1;
    }
}