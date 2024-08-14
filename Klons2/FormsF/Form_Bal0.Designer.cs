using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_Bal0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bal0));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            bsBal0 = new MyBindingSource(components);
            bnavB0 = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvBal0 = new MyDataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBal0AC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBal0AC24 = new MyDgvMcCBColumn();
            bsAc24 = new MyBindingSource(components);
            dgcBal0Clid = new MyDgvMcCBColumn();
            bsClisd = new MyBindingSource(components);
            dgcSummDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSummCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCurRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSummD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSummC = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            tbAcc = new MyPickRowTextBox();
            bsAc21 = new MyBindingSource(components);
            lbSumDeb = new MyLabel();
            lbSumKred = new MyLabel();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bsBal0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavB0).BeginInit();
            bnavB0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBal0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAc24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClisd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAc21).BeginInit();
            SuspendLayout();
            // 
            // bsBal0
            // 
            bsBal0.AutoSaveOnDelete = true;
            bsBal0.DataMember = "Bal0";
            bsBal0.MyDataSource = "KlonsData";
            bsBal0.Name2 = "Bal0";
            bsBal0.Sort = "AC11";
            bsBal0.MyBeforeRowInsert += bsBal0_MyBeforeRowInsert;
            bsBal0.ListChanged += bsBal0_ListChanged;
            // 
            // bnavB0
            // 
            bnavB0.AddNewItem = bindingNavigatorAddNewItem;
            bnavB0.BindingSource = bsBal0;
            bnavB0.CountItem = bindingNavigatorCountItem;
            bnavB0.CountItemFormat = " no {0}";
            bnavB0.DataGrid = dgvBal0;
            bnavB0.DeleteItem = bindingNavigatorDeleteItem;
            bnavB0.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavB0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavB0.ImageScalingSize = new System.Drawing.Size(23, 26);
            bnavB0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavB0.Location = new System.Drawing.Point(0, 465);
            bnavB0.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavB0.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavB0.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavB0.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavB0.Name = "bnavB0";
            bnavB0.PositionItem = bindingNavigatorPositionItem;
            bnavB0.SaveItem = null;
            bnavB0.Size = new System.Drawing.Size(907, 33);
            bnavB0.TabIndex = 6;
            bnavB0.Text = "bindingNavigator1";
            bnavB0.ItemDeleting += bnavB0_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // dgvBal0
            // 
            dgvBal0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvBal0.AutoGenerateColumns = false;
            dgvBal0.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvBal0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBal0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dgcBal0AC11, dgcBal0AC24, dgcBal0Clid, dgcSummDC, dgcSummCC, dgcCur, dgcCurRate, dgcSummD, dgcSummC });
            dgvBal0.DataSource = bsBal0;
            dgvBal0.Location = new System.Drawing.Point(0, 40);
            dgvBal0.Margin = new System.Windows.Forms.Padding(2);
            dgvBal0.Name = "dgvBal0";
            dgvBal0.RowHeadersWidth = 62;
            dgvBal0.Size = new System.Drawing.Size(907, 415);
            dgvBal0.TabIndex = 1;
            dgvBal0.MyKeyDown += dgvBal0_MyKeyDown;
            dgvBal0.MyCheckForChanges += dgvBal0_MyCheckForChanges;
            dgvBal0.CellDoubleClick += dgvBal0_CellDoubleClick;
            dgvBal0.CellEndEdit += dgvBal0_CellEndEdit;
            dgvBal0.CellToolTipTextNeeded += dgvBal0_CellToolTipTextNeeded;
            dgvBal0.UserDeletingRow += dgvBal0_UserDeletingRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dgcBal0AC11
            // 
            dgcBal0AC11.DataPropertyName = "AC11";
            dgcBal0AC11.HeaderText = "konts";
            dgcBal0AC11.MinimumWidth = 9;
            dgcBal0AC11.Name = "dgcBal0AC11";
            dgcBal0AC11.ToolTipText = "Bilances konts";
            dgcBal0AC11.Width = 72;
            // 
            // dgcBal0AC24
            // 
            dgcBal0AC24.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            dgcBal0AC24.ColumnWidths = "100;300";
            dgcBal0AC24.DataPropertyName = "AC24";
            dgcBal0AC24.DataSource = bsAc24;
            dgcBal0AC24.DisplayMember = "idx";
            dgcBal0AC24.HeaderText = "paz.4";
            dgcBal0AC24.MaxDropDownItems = 15;
            dgcBal0AC24.MinimumWidth = 9;
            dgcBal0AC24.Name = "dgcBal0AC24";
            dgcBal0AC24.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcBal0AC24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcBal0AC24.ToolTipText = "Kontējuma 4. pazīme";
            dgcBal0AC24.ValueMember = "idx";
            dgcBal0AC24.Width = 72;
            // 
            // bsAc24
            // 
            bsAc24.DataMember = "AcP24";
            bsAc24.MyDataSource = "KlonsData";
            bsAc24.Name2 = "bsAc24";
            // 
            // dgcBal0Clid
            // 
            dgcBal0Clid.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            dgcBal0Clid.ColumnWidths = "150;400";
            dgcBal0Clid.DataPropertyName = "ClId";
            dgcBal0Clid.DataSource = bsClisd;
            dgcBal0Clid.DisplayMember = "clid";
            dgcBal0Clid.HeaderText = "perosna";
            dgcBal0Clid.MaxDropDownItems = 15;
            dgcBal0Clid.MinimumWidth = 9;
            dgcBal0Clid.Name = "dgcBal0Clid";
            dgcBal0Clid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcBal0Clid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcBal0Clid.ValueMember = "clid";
            dgcBal0Clid.Width = 117;
            // 
            // bsClisd
            // 
            bsClisd.DataMember = "Persons";
            bsClisd.MyDataSource = "KlonsData";
            bsClisd.Name2 = "bsClisd";
            // 
            // dgcSummDC
            // 
            dgcSummDC.DataPropertyName = "SummDC";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dgcSummDC.DefaultCellStyle = dataGridViewCellStyle1;
            dgcSummDC.HeaderText = "debetā";
            dgcSummDC.MinimumWidth = 9;
            dgcSummDC.Name = "dgcSummDC";
            dgcSummDC.ToolTipText = "summa debetā, norādītajā valūtā";
            dgcSummDC.Width = 108;
            // 
            // dgcSummCC
            // 
            dgcSummCC.DataPropertyName = "SummCC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcSummCC.DefaultCellStyle = dataGridViewCellStyle2;
            dgcSummCC.HeaderText = "kredītā";
            dgcSummCC.MinimumWidth = 9;
            dgcSummCC.Name = "dgcSummCC";
            dgcSummCC.ToolTipText = "summa kredītā, norādītajā valūtā";
            dgcSummCC.Width = 108;
            // 
            // dgcCur
            // 
            dgcCur.DataPropertyName = "Cur";
            dgcCur.HeaderText = "valūta";
            dgcCur.MaxInputLength = 3;
            dgcCur.MinimumWidth = 9;
            dgcCur.Name = "dgcCur";
            dgcCur.ToolTipText = "valūta (EUR, USD, RUR, ...)";
            dgcCur.Width = 54;
            // 
            // dgcCurRate
            // 
            dgcCurRate.DataPropertyName = "CurRate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dgcCurRate.DefaultCellStyle = dataGridViewCellStyle3;
            dgcCurRate.HeaderText = "kurss";
            dgcCurRate.MinimumWidth = 9;
            dgcCurRate.Name = "dgcCurRate";
            dgcCurRate.ToolTipText = "valūtas kurss";
            dgcCurRate.Width = 72;
            // 
            // dgcSummD
            // 
            dgcSummD.DataPropertyName = "SummD";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcSummD.DefaultCellStyle = dataGridViewCellStyle4;
            dgcSummD.HeaderText = "debetā";
            dgcSummD.MinimumWidth = 9;
            dgcSummD.Name = "dgcSummD";
            dgcSummD.ReadOnly = true;
            dgcSummD.ToolTipText = "summa debetā EUR";
            dgcSummD.Width = 108;
            // 
            // dgcSummC
            // 
            dgcSummC.DataPropertyName = "SummC";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dgcSummC.DefaultCellStyle = dataGridViewCellStyle5;
            dgcSummC.HeaderText = "kredītā";
            dgcSummC.MinimumWidth = 9;
            dgcSummC.Name = "dgcSummC";
            dgcSummC.ReadOnly = true;
            dgcSummC.ToolTipText = "summa kredītā EUR";
            dgcSummC.Width = 108;
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 30);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(46, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(27, 30);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(27, 30);
            tsbSave.Text = "Saglabāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 2;
            label1.Text = "Kods:";
            // 
            // tbAcc
            // 
            tbAcc.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbAcc.ColumnNr = 1;
            tbAcc.DataMember = null;
            tbAcc.DataSource = bsAc21;
            tbAcc.Location = new System.Drawing.Point(62, 8);
            tbAcc.Margin = new System.Windows.Forms.Padding(2);
            tbAcc.Name = "tbAcc";
            tbAcc.SelectedIndex = -1;
            tbAcc.Size = new System.Drawing.Size(92, 23);
            tbAcc.TabIndex = 0;
            // 
            // bsAc21
            // 
            bsAc21.DataMember = "AcP21";
            bsAc21.MyDataSource = "KlonsData";
            bsAc21.Name2 = "bsAc21";
            // 
            // lbSumDeb
            // 
            lbSumDeb.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            lbSumDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbSumDeb.Location = new System.Drawing.Point(267, 8);
            lbSumDeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbSumDeb.Name = "lbSumDeb";
            lbSumDeb.Padding = new System.Windows.Forms.Padding(2);
            lbSumDeb.Size = new System.Drawing.Size(119, 26);
            lbSumDeb.TabIndex = 4;
            lbSumDeb.Text = "0.00";
            lbSumDeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSumKred
            // 
            lbSumKred.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            lbSumKred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbSumKred.Location = new System.Drawing.Point(390, 8);
            lbSumKred.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbSumKred.Name = "lbSumKred";
            lbSumKred.Padding = new System.Windows.Forms.Padding(2);
            lbSumKred.Size = new System.Drawing.Size(119, 26);
            lbSumKred.TabIndex = 5;
            lbSumKred.Text = "0.00";
            lbSumKred.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(160, 9);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 17);
            label2.TabIndex = 3;
            label2.Text = "Kopsummas:";
            // 
            // Form_Bal0
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            ClientSize = new System.Drawing.Size(907, 498);
            Controls.Add(label2);
            Controls.Add(lbSumKred);
            Controls.Add(lbSumDeb);
            Controls.Add(label1);
            Controls.Add(tbAcc);
            Controls.Add(dgvBal0);
            Controls.Add(bnavB0);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_Bal0";
            Text = "Sākuma atlikumi";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormBal0_Load;
            ((System.ComponentModel.ISupportInitialize)bsBal0).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavB0).EndInit();
            bnavB0.ResumeLayout(false);
            bnavB0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBal0).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAc24).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClisd).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAc21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsBal0;
        private MyBindingNavigator bnavB0;
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
        private MyDataGridView dgvBal0;
        private System.Windows.Forms.Label label1;
        private MyPickRowTextBox tbAcc;
        private MyBindingSource bsAc21;
        private MyBindingSource bsAc24;
        private MyBindingSource bsClisd;
        private MyLabel lbSumDeb;
        private MyLabel lbSumKred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBal0AC11;
        private MyDgvMcCBColumn dgcBal0AC24;
        private MyDgvMcCBColumn dgcBal0Clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSummDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSummCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCurRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSummD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSummC;
    }
}