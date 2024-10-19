namespace KlonsA.Forms
{
    partial class FormA_UntaxedMinimum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_UntaxedMinimum));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            cmFilter = new System.Windows.Forms.Button();
            cbPerson = new KlonsLIB.Components.MyMcFlatComboBox();
            bsFilterPerson = new KlonsLIB.Data.MyBindingSource(components);
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bsRows = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            bsPerson = new KlonsLIB.Data.MyBindingSource(components);
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bniAdd = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bniDelete = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bniSave = new System.Windows.Forms.ToolStripButton();
            bniXMLImport = new System.Windows.Forms.ToolStripButton();
            dgcOnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDP = new KlonsLIB.Components.MyDgvMcComboBoxColumn();
            dgcUntaxedMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIINRateType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsFilterPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmFilter);
            panel1.Controls.Add(cbPerson);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(824, 39);
            panel1.TabIndex = 0;
            // 
            // cmFilter
            // 
            cmFilter.Location = new System.Drawing.Point(607, 3);
            cmFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmFilter.Name = "cmFilter";
            cmFilter.Size = new System.Drawing.Size(84, 29);
            cmFilter.TabIndex = 5;
            cmFilter.Text = "Filtrēt";
            cmFilter.UseVisualStyleBackColor = true;
            cmFilter.Click += cmFilter_Click;
            // 
            // cbPerson
            // 
            cbPerson.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPerson.ColumnNames = new string[]
    {
    "FNAME",
    "LNAME",
    "PK"
    };
            cbPerson.ColumnWidths = "100;100;100";
            cbPerson.DataSource = bsFilterPerson;
            cbPerson.DisplayMember = "YNAME";
            cbPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPerson.DropDownHeight = 270;
            cbPerson.DropDownWidth = 319;
            cbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPerson.FormattingEnabled = true;
            cbPerson.GridLineColor = System.Drawing.Color.LightGray;
            cbPerson.GridLineHorizontal = false;
            cbPerson.GridLineVertical = false;
            cbPerson.IntegralHeight = false;
            cbPerson.Location = new System.Drawing.Point(347, 6);
            cbPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbPerson.MaxDropDownItems = 15;
            cbPerson.Name = "cbPerson";
            cbPerson.Size = new System.Drawing.Size(240, 24);
            cbPerson.TabIndex = 4;
            cbPerson.ValueMember = "ID";
            // 
            // bsFilterPerson
            // 
            bsFilterPerson.DataMember = "PERSONS";
            bsFilterPerson.MyDataSource = "KlonsAData";
            bsFilterPerson.Sort = "YNAME";
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(167, 6);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(91, 23);
            tbDate2.TabIndex = 2;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(69, 6);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(91, 23);
            tbDate1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(264, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 17);
            label2.TabIndex = 3;
            label2.Text = "darbinieks:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Datums:";
            // 
            // bsRows
            // 
            bsRows.AutoSaveOnDelete = true;
            bsRows.DataMember = "UNTAXED_MIN";
            bsRows.Filter = "";
            bsRows.MyDataSource = "KlonsAData";
            bsRows.Sort = "ONDATE";
            bsRows.UseDataGridView = dgvRows;
            bsRows.MyBeforeRowInsert += bsRows_MyBeforeRowInsert;
            bsRows.ListChanged += bsRows_ListChanged;
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = true;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcOnDate, dgcIDP, dgcUntaxedMin, dgcIINRateType, dgcID });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 39);
            dgvRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 53;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(824, 402);
            dgvRows.TabIndex = 1;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellParsing += dgvRows_CellParsing;
            dgvRows.DefaultValuesNeeded += dgvRows_DefaultValuesNeeded;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            dgvRows.KeyDown += dgvRows_KeyDown;
            // 
            // bsPerson
            // 
            bsPerson.DataMember = "PERSONS";
            bsPerson.Filter = "";
            bsPerson.MyDataSource = "KlonsAData";
            bsPerson.Sort = "YNAME";
            // 
            // bNav
            // 
            bNav.AddNewItem = bniAdd;
            bNav.BindingSource = bsRows;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvRows;
            bNav.DeleteItem = bniDelete;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(23, 26);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bniAdd, bniDelete, bniSave, bniXMLImport });
            bNav.Location = new System.Drawing.Point(0, 441);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bniSave;
            bNav.Size = new System.Drawing.Size(824, 34);
            bNav.TabIndex = 2;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bniAdd
            // 
            bniAdd.Image = (System.Drawing.Image)resources.GetObject("bniAdd.Image");
            bniAdd.Name = "bniAdd";
            bniAdd.RightToLeftAutoMirrorImage = true;
            bniAdd.Size = new System.Drawing.Size(73, 31);
            bniAdd.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 31);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bniDelete
            // 
            bniDelete.Image = (System.Drawing.Image)resources.GetObject("bniDelete.Image");
            bniDelete.Name = "bniDelete";
            bniDelete.RightToLeftAutoMirrorImage = true;
            bniDelete.Size = new System.Drawing.Size(71, 31);
            bniDelete.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(27, 31);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(27, 31);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
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
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(27, 31);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(27, 31);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // bniSave
            // 
            bniSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bniSave.Image = (System.Drawing.Image)resources.GetObject("bniSave.Image");
            bniSave.Margin = new System.Windows.Forms.Padding(0, 1, 5, 3);
            bniSave.Name = "bniSave";
            bniSave.Size = new System.Drawing.Size(27, 30);
            bniSave.Text = "Saglabāt";
            bniSave.Click += bniSave_Click;
            // 
            // bniXMLImport
            // 
            bniXMLImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            bniXMLImport.Image = (System.Drawing.Image)resources.GetObject("bniXMLImport.Image");
            bniXMLImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            bniXMLImport.Name = "bniXMLImport";
            bniXMLImport.Size = new System.Drawing.Size(114, 31);
            bniXMLImport.Text = "EDS datu imorts";
            bniXMLImport.Click += bniXMLImport_Click;
            // 
            // dgcOnDate
            // 
            dgcOnDate.DataPropertyName = "ONDATE";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcOnDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcOnDate.HeaderText = "datums";
            dgcOnDate.MinimumWidth = 7;
            dgcOnDate.Name = "dgcOnDate";
            dgcOnDate.Width = 85;
            // 
            // dgcIDP
            // 
            dgcIDP.ColumnNames = new string[]
    {
    "FNAME",
    "LNAME",
    "PK"
    };
            dgcIDP.ColumnWidths = "100;100;100";
            dgcIDP.DataPropertyName = "IDP";
            dgcIDP.DataSource = bsPerson;
            dgcIDP.DisplayMember = "YNAME";
            dgcIDP.DisplayStyleForCurrentCellOnly = true;
            dgcIDP.HeaderText = "darbinieks";
            dgcIDP.MaxDropDownItems = 15;
            dgcIDP.MinimumWidth = 7;
            dgcIDP.Name = "dgcIDP";
            dgcIDP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIDP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcIDP.ValueMember = "ID";
            dgcIDP.Width = 250;
            // 
            // dgcUntaxedMin
            // 
            dgcUntaxedMin.DataPropertyName = "UNTAXED_MIN";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcUntaxedMin.DefaultCellStyle = dataGridViewCellStyle2;
            dgcUntaxedMin.HeaderText = "summa";
            dgcUntaxedMin.MinimumWidth = 7;
            dgcUntaxedMin.Name = "dgcUntaxedMin";
            dgcUntaxedMin.Width = 110;
            // 
            // dgcIINRateType
            // 
            dgcIINRateType.DataPropertyName = "IIN_RATE_TYPE";
            dgcIINRateType.DisplayStyleForCurrentCellOnly = true;
            dgcIINRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcIINRateType.HeaderText = "likme";
            dgcIINRateType.MinimumWidth = 7;
            dgcIINRateType.Name = "dgcIINRateType";
            dgcIINRateType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcIINRateType.Width = 70;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.MinimumWidth = 7;
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            dgcID.Width = 56;
            // 
            // FormA_UntaxedMinimum
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 475);
            Controls.Add(dgvRows);
            Controls.Add(bNav);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormA_UntaxedMinimum";
            Text = "Neapliekmais minimums";
            Load += Form_UntaxedMinimum_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsFilterPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Data.MyBindingSource bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsPerson;
        private KlonsLIB.Data.MyBindingSource bsFilterPerson;
        private System.Windows.Forms.Button cmFilter;
        private KlonsLIB.Components.MyMcFlatComboBox cbPerson;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bniAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bniDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bniSave;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private System.Windows.Forms.ToolStripButton bniXMLImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOnDate;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcIDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUntaxedMin;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcIINRateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}