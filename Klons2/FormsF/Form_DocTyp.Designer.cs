using KlonsLIB.Components;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsF.Forms
{
    partial class Form_DocTyp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DocTyp));
            bnavDocTyp = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsDocTyp = new MyBindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbInfo = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            tbSearch = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbId = new MyPickRowTextBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dgvDocTyp = new MyDataGridView();
            dgcDocTypId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTypId2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTypPvnpaz = new MyDgvMcCBColumn();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            dgvDocTypA = new MyDataGridView();
            dgcDocTypAId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTypAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsDocTypA = new MyBindingSource(components);
            bsDocTypB = new MyBindingSource2(components);
            dgvDocTypB = new MyDataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsDocTyp2 = new MyBindingSource(components);
            myAdapterManager1 = new MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bnavDocTyp).BeginInit();
            bnavDocTyp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocTyp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocTypA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTypA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTypB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocTypB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bnavDocTyp
            // 
            bnavDocTyp.AddNewItem = bindingNavigatorAddNewItem;
            bnavDocTyp.BindingSource = bsDocTyp;
            bnavDocTyp.CountItem = bindingNavigatorCountItem;
            bnavDocTyp.CountItemFormat = " no {0}";
            bnavDocTyp.DeleteItem = bindingNavigatorDeleteItem;
            bnavDocTyp.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavDocTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavDocTyp.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavDocTyp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbInfo, tsbSave });
            bnavDocTyp.Location = new System.Drawing.Point(0, 476);
            bnavDocTyp.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavDocTyp.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavDocTyp.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavDocTyp.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavDocTyp.Name = "bnavDocTyp";
            bnavDocTyp.PositionItem = bindingNavigatorPositionItem;
            bnavDocTyp.SaveItem = null;
            bnavDocTyp.Size = new System.Drawing.Size(721, 28);
            bnavDocTyp.TabIndex = 0;
            bnavDocTyp.Text = "bindingNavigator1";
            bnavDocTyp.ItemDeleting += bnavDocTyp_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 25);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns (Shift+Insert)";
            // 
            // bsDocTyp
            // 
            bsDocTyp.AutoSaveOnDelete = true;
            bsDocTyp.DataMember = "DocTyp";
            bsDocTyp.MyDataSource = "KlonsData";
            bsDocTyp.Name2 = "bsDocTyp";
            bsDocTyp.Sort = "";
            bsDocTyp.ListChanged += bsDocTyp_ListChanged;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 25);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.ToolTipText = "Dzēst (Ctrl+Delete)";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(121, 25);
            toolStripLabel1.Text = "Dokumentu veids:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 25);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbInfo
            // 
            tsbInfo.Image = Properties.Resources.information1;
            tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbInfo.Name = "tsbInfo";
            tsbInfo.Size = new System.Drawing.Size(56, 25);
            tsbInfo.Text = "Info";
            tsbInfo.Click += tsbInfo_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 25);
            tsbSave.Text = "Saglabāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(225, 3);
            tbSearch.Margin = new System.Windows.Forms.Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(136, 23);
            tbSearch.TabIndex = 2;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 5);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 17);
            label1.TabIndex = 4;
            label1.Text = "kods:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(168, 5);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 4;
            label2.Text = "meklēt:";
            // 
            // tbId
            // 
            tbId.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbId.DataMember = null;
            tbId.DataSource = bsDocTyp;
            tbId.Location = new System.Drawing.Point(51, 3);
            tbId.Margin = new System.Windows.Forms.Padding(2);
            tbId.Name = "tbId";
            tbId.SelectedIndex = -1;
            tbId.Size = new System.Drawing.Size(102, 23);
            tbId.TabIndex = 0;
            tbId.RowSelectedEvent += tbId_RowSelectedEvent;
            tbId.Enter += tbId_Enter;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(0, 30);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDocTyp);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new System.Drawing.Size(721, 441);
            splitContainer1.SplitterDistance = 270;
            splitContainer1.TabIndex = 8;
            // 
            // dgvDocTyp
            // 
            dgvDocTyp.AutoGenerateColumns = false;
            dgvDocTyp.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocTyp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocTypId, dgcName, dgcDocTypId2, dgcDocTypPvnpaz });
            dgvDocTyp.DataSource = bsDocTyp;
            dgvDocTyp.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocTyp.Location = new System.Drawing.Point(0, 0);
            dgvDocTyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvDocTyp.Name = "dgvDocTyp";
            dgvDocTyp.RowHeadersWidth = 62;
            dgvDocTyp.Size = new System.Drawing.Size(721, 270);
            dgvDocTyp.TabIndex = 4;
            dgvDocTyp.MyKeyDown += dgvDocTyp_MyKeyDown;
            dgvDocTyp.MyCheckForChanges += dgvDocTyp_MyCheckForChanges;
            dgvDocTyp.CellDoubleClick += dgvDocTyp_CellDoubleClick;
            dgvDocTyp.UserDeletingRow += dgvDocTyp_UserDeletingRow;
            dgvDocTyp.Enter += dgvDocTyp_Enter;
            dgvDocTyp.KeyDown += dgvDocTyp_KeyDown;
            dgvDocTyp.KeyPress += dgvDocTyp_KeyPress;
            // 
            // dgcDocTypId
            // 
            dgcDocTypId.DataPropertyName = "id";
            dgcDocTypId.HeaderText = "kods";
            dgcDocTypId.MinimumWidth = 9;
            dgcDocTypId.Name = "dgcDocTypId";
            dgcDocTypId.Width = 90;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.MinimumWidth = 9;
            dgcName.Name = "dgcName";
            dgcName.Width = 320;
            // 
            // dgcDocTypId2
            // 
            dgcDocTypId2.DataPropertyName = "id1";
            dgcDocTypId2.HeaderText = "kods2";
            dgcDocTypId2.MinimumWidth = 9;
            dgcDocTypId2.Name = "dgcDocTypId2";
            dgcDocTypId2.Width = 90;
            // 
            // dgcDocTypPvnpaz
            // 
            dgcDocTypPvnpaz.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcDocTypPvnpaz.ColumnWidths = "20;200";
            dgcDocTypPvnpaz.DataPropertyName = "pvnpaz";
            dgcDocTypPvnpaz.DisplayMember = "col1";
            dgcDocTypPvnpaz.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            dgcDocTypPvnpaz.HeaderText = "pvn.paz.";
            dgcDocTypPvnpaz.ItemStrings = new string[]
    {
    "1;nodokļa rēķins",
    "2;kases čeks vai kvīts",
    "3;bezskaidras naudas maksājuma dokuments",
    "4;kredītrēķins",
    "5;cits",
    "6;muitas deklarācija"
    };
            dgcDocTypPvnpaz.MaxDropDownItems = 15;
            dgcDocTypPvnpaz.MinimumWidth = 9;
            dgcDocTypPvnpaz.Name = "dgcDocTypPvnpaz";
            dgcDocTypPvnpaz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcDocTypPvnpaz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcDocTypPvnpaz.ToolTipText = "PVN dokumenta pazīme";
            dgcDocTypPvnpaz.ValueMember = "col1";
            dgcDocTypPvnpaz.Width = 90;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
            splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvDocTypA);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvDocTypB);
            splitContainer2.Size = new System.Drawing.Size(721, 167);
            splitContainer2.SplitterDistance = 490;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 0;
            // 
            // dgvDocTypA
            // 
            dgvDocTypA.AutoGenerateColumns = false;
            dgvDocTypA.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocTypA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocTypA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocTypAId, dgcDocTypAName });
            dgvDocTypA.DataSource = bsDocTypA;
            dgvDocTypA.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocTypA.Location = new System.Drawing.Point(0, 0);
            dgvDocTypA.Margin = new System.Windows.Forms.Padding(2);
            dgvDocTypA.Name = "dgvDocTypA";
            dgvDocTypA.RowHeadersWidth = 62;
            dgvDocTypA.Size = new System.Drawing.Size(490, 167);
            dgvDocTypA.TabIndex = 7;
            dgvDocTypA.MyKeyDown += dgvDocTypA_MyKeyDown;
            dgvDocTypA.MyCheckForChanges += dgvDocTyp_MyCheckForChanges;
            dgvDocTypA.CurrentCellChanged += dgvDocTypA_CurrentCellChanged;
            dgvDocTypA.RowValidating += dgvDocTypA_RowValidating;
            dgvDocTypA.UserDeletingRow += dgvDocTypA_UserDeletingRow;
            dgvDocTypA.Enter += dgvDocTypA_Enter;
            // 
            // dgcDocTypAId
            // 
            dgcDocTypAId.DataPropertyName = "id";
            dgcDocTypAId.HeaderText = "kods";
            dgcDocTypAId.MinimumWidth = 9;
            dgcDocTypAId.Name = "dgcDocTypAId";
            dgcDocTypAId.ToolTipText = "dokumentu grupas kods";
            dgcDocTypAId.Width = 90;
            // 
            // dgcDocTypAName
            // 
            dgcDocTypAName.DataPropertyName = "Name";
            dgcDocTypAName.HeaderText = "nosaukums";
            dgcDocTypAName.MinimumWidth = 9;
            dgcDocTypAName.Name = "dgcDocTypAName";
            dgcDocTypAName.ToolTipText = "dokumentu grupas nosaukums";
            dgcDocTypAName.Width = 270;
            // 
            // bsDocTypA
            // 
            bsDocTypA.AutoSaveChildrenDelete = true;
            bsDocTypA.AutoSaveOnDelete = true;
            bsDocTypA.ChildBS = bsDocTypB;
            bsDocTypA.DataMember = "DocTypA";
            bsDocTypA.MyDataSource = "KlonsData";
            bsDocTypA.Name2 = "bsDocTypA";
            bsDocTypA.Sort = "id";
            bsDocTypA.ListChanged += bsDocTyp_ListChanged;
            // 
            // bsDocTypB
            // 
            bsDocTypB.AutoSaveOnDelete = true;
            bsDocTypB.DataMember = "FK_DOCTYPB_IDA_DOCTYPA_ID";
            bsDocTypB.DataSource = bsDocTypA;
            bsDocTypB.Name2 = "bsDocTypB";
            bsDocTypB.ListChanged += bsDocTyp_ListChanged;
            // 
            // dgvDocTypB
            // 
            dgvDocTypB.AutoGenerateColumns = false;
            dgvDocTypB.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvDocTypB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocTypB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn });
            dgvDocTypB.DataSource = bsDocTypB;
            dgvDocTypB.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvDocTypB.Location = new System.Drawing.Point(0, 0);
            dgvDocTypB.Margin = new System.Windows.Forms.Padding(2);
            dgvDocTypB.Name = "dgvDocTypB";
            dgvDocTypB.RowHeadersWidth = 62;
            dgvDocTypB.Size = new System.Drawing.Size(228, 167);
            dgvDocTypB.TabIndex = 8;
            dgvDocTypB.MyKeyDown += dgvDocTypB_MyKeyDown;
            dgvDocTypB.MyCheckForChanges += dgvDocTyp_MyCheckForChanges;
            dgvDocTypB.UserDeletingRow += dgvDocTypB_UserDeletingRow;
            dgvDocTypB.Enter += dgvDocTypB_Enter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 9;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 90;
            // 
            // bsDocTyp2
            // 
            bsDocTyp2.AutoSaveOnDelete = true;
            bsDocTyp2.DataMember = "DocTyp";
            bsDocTyp2.MyDataSource = "KlonsData";
            bsDocTyp2.Name2 = "bsDocTyp2";
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsData";
            myAdapterManager1.TableNames = new string[]
    {
    "DocTyp",
    "DocTypA",
    "DocTypB",
    null
    };
            // 
            // Form_DocTyp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(721, 504);
            Controls.Add(splitContainer1);
            Controls.Add(tbId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSearch);
            Controls.Add(bnavDocTyp);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_DocTyp";
            Text = "Dokumentu veidi";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormDocTyp_Load;
            Shown += FormDocTyp_Shown;
            ((System.ComponentModel.ISupportInitialize)bnavDocTyp).EndInit();
            bnavDocTyp.ResumeLayout(false);
            bnavDocTyp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocTyp).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocTypA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTypA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTypB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocTypB).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocTyp2).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingNavigator bnavDocTyp;
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
        private System.Windows.Forms.ToolStripButton tsbSave;
        private MyBindingSource bsDocTyp;
        private MyTextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyPickRowTextBox tbId;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyDataGridView dgvDocTyp;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MyDataGridView dgvDocTypA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocTypAId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocTypAName;
        private MyBindingSource bsDocTypA;
        private MyDataGridView dgvDocTypB;
        private MyBindingSource bsDocTyp2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbInfo;
        private MyAdapterManager myAdapterManager1;
        private MyBindingSource2 bsDocTypB;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocTypId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocTypId2;
        private MyDgvMcCBColumn dgcDocTypPvnpaz;
    }
}