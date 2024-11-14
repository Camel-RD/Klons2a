namespace KlonsA.Forms
{
    partial class FormA_UntaxedMinimumImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_UntaxedMinimumImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            bsRows = new System.Windows.Forms.BindingSource(components);
            panel1 = new System.Windows.Forms.Panel();
            cmUpdateDB = new System.Windows.Forms.Button();
            cmLoadFromFile = new System.Windows.Forms.Button();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUntMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIINRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmUpdateDB);
            panel1.Controls.Add(cmLoadFromFile);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(690, 31);
            panel1.TabIndex = 0;
            // 
            // cmUpdateDB
            // 
            cmUpdateDB.Location = new System.Drawing.Point(448, 1);
            cmUpdateDB.Name = "cmUpdateDB";
            cmUpdateDB.Size = new System.Drawing.Size(113, 26);
            cmUpdateDB.TabIndex = 4;
            cmUpdateDB.Text = "Iegrāmatot";
            cmUpdateDB.UseVisualStyleBackColor = true;
            cmUpdateDB.Click += cmUpdateDB_Click;
            // 
            // cmLoadFromFile
            // 
            cmLoadFromFile.Location = new System.Drawing.Point(297, 2);
            cmLoadFromFile.Name = "cmLoadFromFile";
            cmLoadFromFile.Size = new System.Drawing.Size(129, 26);
            cmLoadFromFile.TabIndex = 3;
            cmLoadFromFile.Text = "Ielādēt no faila";
            cmLoadFromFile.UseVisualStyleBackColor = true;
            cmLoadFromFile.Click += cmLoadFromFile_Click;
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(169, 5);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(90, 23);
            tbDate2.TabIndex = 2;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(73, 5);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(90, 23);
            tbDate1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Periods:";
            // 
            // bNav
            // 
            bNav.AddNewItem = null;
            bNav.BindingSource = bsRows;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DeleteItem = null;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(16, 16);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2 });
            bNav.Location = new System.Drawing.Point(0, 422);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = null;
            bNav.Size = new System.Drawing.Size(690, 28);
            bNav.TabIndex = 2;
            bNav.Text = "myBindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcName, dgcCode, dgcDate, dgcUntMin, dgcIINRate });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 31);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 53;
            dgvRows.Size = new System.Drawing.Size(690, 391);
            dgvRows.TabIndex = 1;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "darbinieks";
            dgcName.MinimumWidth = 7;
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 180;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "PersonsCode";
            dgcCode.HeaderText = "pers. kods";
            dgcCode.MinimumWidth = 7;
            dgcCode.Name = "dgcCode";
            dgcCode.ReadOnly = true;
            dgcCode.ToolTipText = "Personas kods";
            dgcCode.Width = 130;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Dt";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dataGridViewCellStyle1.NullValue = null;
            dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDate.HeaderText = "datums";
            dgcDate.MinimumWidth = 7;
            dgcDate.Name = "dgcDate";
            dgcDate.ReadOnly = true;
            dgcDate.Width = 85;
            // 
            // dgcUntMin
            // 
            dgcUntMin.DataPropertyName = "UntMin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dgcUntMin.DefaultCellStyle = dataGridViewCellStyle2;
            dgcUntMin.HeaderText = "neapl. min.";
            dgcUntMin.MinimumWidth = 7;
            dgcUntMin.Name = "dgcUntMin";
            dgcUntMin.ReadOnly = true;
            dgcUntMin.ToolTipText = "Neapliekamais minimums";
            dgcUntMin.Width = 110;
            // 
            // dgcIINRate
            // 
            dgcIINRate.DataPropertyName = "IINRateType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcIINRate.DefaultCellStyle = dataGridViewCellStyle3;
            dgcIINRate.HeaderText = "IIN lime";
            dgcIINRate.MinimumWidth = 7;
            dgcIINRate.Name = "dgcIINRate";
            dgcIINRate.ReadOnly = true;
            dgcIINRate.Width = 70;
            // 
            // FormA_UntaxedMinimumImport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(690, 450);
            Controls.Add(dgvRows);
            Controls.Add(bNav);
            Controls.Add(panel1);
            Name = "FormA_UntaxedMinimumImport";
            Text = "Datu imports";
            Load += Form_UntaxedMinimumImport_Load;
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.Button cmLoadFromFile;
        private System.Windows.Forms.Button cmUpdateDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUntMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIINRate;
    }
}