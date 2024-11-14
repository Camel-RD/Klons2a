using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_Professions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Professions));
            dgvProf = new MyDataGridView();
            iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dESCRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            uSEDDataGridViewTextBoxColumn = new MyDgvCheckBoxColumn();
            bsProf = new KlonsLIB.Data.MyBindingSource(components);
            bnavProf = new MyBindingNavigator();
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
            cbCat = new MyMcFlatComboBox();
            bsProfCat = new KlonsLIB.Data.MyBindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavProf).BeginInit();
            bnavProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsProfCat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProf
            // 
            dgvProf.AutoGenerateColumns = false;
            dgvProf.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { iDDataGridViewTextBoxColumn, dESCRDataGridViewTextBoxColumn, uSEDDataGridViewTextBoxColumn });
            dgvProf.DataSource = bsProf;
            dgvProf.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProf.Location = new System.Drawing.Point(0, 28);
            dgvProf.Name = "dgvProf";
            dgvProf.Size = new System.Drawing.Size(662, 289);
            dgvProf.TabIndex = 3;
            dgvProf.MyCheckForChanges += dgvProf_MyCheckForChanges;
            dgvProf.CellDoubleClick += dgvProf_CellDoubleClick;
            dgvProf.UserDeletingRow += dgvProf_UserDeletingRow;
            dgvProf.KeyDown += dgvProf_KeyDown;
            dgvProf.KeyPress += dgvProf_KeyPress;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "Kods";
            iDDataGridViewTextBoxColumn.MinimumWidth = 4;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 64;
            // 
            // dESCRDataGridViewTextBoxColumn
            // 
            dESCRDataGridViewTextBoxColumn.DataPropertyName = "DESCR";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dESCRDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            dESCRDataGridViewTextBoxColumn.HeaderText = "Apraksts";
            dESCRDataGridViewTextBoxColumn.MinimumWidth = 4;
            dESCRDataGridViewTextBoxColumn.Name = "dESCRDataGridViewTextBoxColumn";
            dESCRDataGridViewTextBoxColumn.Width = 480;
            // 
            // uSEDDataGridViewTextBoxColumn
            // 
            uSEDDataGridViewTextBoxColumn.DataPropertyName = "USED";
            uSEDDataGridViewTextBoxColumn.FalseValue = "0";
            uSEDDataGridViewTextBoxColumn.HeaderText = "Atzīmēt";
            uSEDDataGridViewTextBoxColumn.MinimumWidth = 4;
            uSEDDataGridViewTextBoxColumn.Name = "uSEDDataGridViewTextBoxColumn";
            uSEDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            uSEDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            uSEDDataGridViewTextBoxColumn.TrueValue = "1";
            uSEDDataGridViewTextBoxColumn.Width = 56;
            // 
            // bsProf
            // 
            bsProf.AutoSaveOnDelete = true;
            bsProf.DataMember = "PROFESSIONS";
            bsProf.MyDataSource = "KlonsAData";
            bsProf.UseDataGridView = dgvProf;
            bsProf.ListChanged += bsProf_ListChanged;
            // 
            // bnavProf
            // 
            bnavProf.AddNewItem = bindingNavigatorAddNewItem;
            bnavProf.BindingSource = bsProf;
            bnavProf.CountItem = bindingNavigatorCountItem;
            bnavProf.CountItemFormat = " no {0}";
            bnavProf.DataGrid = dgvProf;
            bnavProf.DeleteItem = bindingNavigatorDeleteItem;
            bnavProf.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavProf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavProf.Location = new System.Drawing.Point(0, 317);
            bnavProf.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavProf.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavProf.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavProf.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavProf.Name = "bnavProf";
            bnavProf.PositionItem = bindingNavigatorPositionItem;
            bnavProf.SaveItem = null;
            bnavProf.Size = new System.Drawing.Size(662, 30);
            bnavProf.TabIndex = 4;
            bnavProf.Text = "myBindingNavigator1";
            bnavProf.ItemDeleting += bnavProf_ItemDeleting;
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
            label1.Location = new System.Drawing.Point(90, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 17);
            label1.TabIndex = 1;
            label1.Text = "Meklēt:";
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(145, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(119, 23);
            tbSearch.TabIndex = 2;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // cbCat
            // 
            cbCat.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbCat.ColumnNames = new string[]
    {
    "id",
    "descr"
    };
            cbCat.ColumnWidths = "80;450";
            cbCat.DataSource = bsProfCat;
            cbCat.DisplayMember = "ID";
            cbCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbCat.DropDownHeight = 270;
            cbCat.DropDownWidth = 549;
            cbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbCat.FormattingEnabled = true;
            cbCat.GridLineColor = System.Drawing.Color.LightGray;
            cbCat.GridLineHorizontal = false;
            cbCat.GridLineVertical = false;
            cbCat.IntegralHeight = false;
            cbCat.Location = new System.Drawing.Point(4, 3);
            cbCat.Margin = new System.Windows.Forms.Padding(2);
            cbCat.MaxDropDownItems = 15;
            cbCat.Name = "cbCat";
            cbCat.Size = new System.Drawing.Size(79, 24);
            cbCat.TabIndex = 0;
            cbCat.ValueMember = "ID";
            cbCat.SelectedIndexChanged += cbCat_SelectedIndexChanged;
            // 
            // bsProfCat
            // 
            bsProfCat.AutoSaveOnDelete = true;
            bsProfCat.DataMember = "PROFESSIONS";
            bsProfCat.Filter = "Cat=1";
            bsProfCat.MyDataSource = "KlonsAData";
            bsProfCat.UseDataGridView = dgvProf;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbSearch);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(662, 28);
            panel1.TabIndex = 5;
            // 
            // FormA_Professions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(662, 347);
            Controls.Add(dgvProf);
            Controls.Add(panel1);
            Controls.Add(bnavProf);
            Name = "FormA_Professions";
            Text = "Teritoriju kodi";
            Load += Form_Professions_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProf).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsProf).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavProf).EndInit();
            bnavProf.ResumeLayout(false);
            bnavProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsProfCat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyDataGridView dgvProf;
        private MyBindingNavigator bnavProf;
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
        private KlonsLIB.Data.MyBindingSource bsProf;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private MyMcFlatComboBox cbCat;
        private KlonsLIB.Data.MyBindingSource bsProfCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRDataGridViewTextBoxColumn;
        private MyDgvCheckBoxColumn uSEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}