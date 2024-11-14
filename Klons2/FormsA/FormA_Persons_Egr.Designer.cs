
namespace KlonsA.Forms
{
    partial class FormA_Persons_Egr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Persons_Egr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bsRows = new System.Windows.Forms.BindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            panel1 = new System.Windows.Forms.Panel();
            cmLoadFromFile = new System.Windows.Forms.Button();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcHasIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcApgSk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPapAtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPensijas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcEDSHasIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcEDSApgSk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcEDSPapAtv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcEDSPensijas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
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
            bNav.Location = new System.Drawing.Point(0, 417);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = null;
            bNav.Size = new System.Drawing.Size(1019, 33);
            bNav.TabIndex = 3;
            bNav.Text = "myBindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
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
            // panel1
            // 
            panel1.Controls.Add(cmLoadFromFile);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1019, 34);
            panel1.TabIndex = 4;
            // 
            // cmLoadFromFile
            // 
            cmLoadFromFile.Location = new System.Drawing.Point(284, 3);
            cmLoadFromFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmLoadFromFile.Name = "cmLoadFromFile";
            cmLoadFromFile.Size = new System.Drawing.Size(110, 28);
            cmLoadFromFile.TabIndex = 3;
            cmLoadFromFile.Text = "Ielādēt no faila";
            cmLoadFromFile.UseVisualStyleBackColor = true;
            cmLoadFromFile.Click += cmLoadFromFile_Click;
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(173, 6);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(91, 23);
            tbDate2.TabIndex = 2;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(73, 6);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(91, 23);
            tbDate1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 17);
            label1.TabIndex = 0;
            label1.Text = "Periods:";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AllowUserToResizeRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcName, dgcPK, dgcDate, dgcHasIt, dgcApgSk, dgcPapAtv, dgcPensijas, dgcEDSHasIt, dgcEDSApgSk, dgcEDSPapAtv, dgcEDSPensijas });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 34);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 62;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1019, 383);
            dgvRows.TabIndex = 5;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "darbinieks";
            dgcName.MinimumWidth = 8;
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcName.Width = 180;
            // 
            // dgcPK
            // 
            dgcPK.DataPropertyName = "PersonsCode";
            dgcPK.HeaderText = "personas kods";
            dgcPK.MinimumWidth = 8;
            dgcPK.Name = "dgcPK";
            dgcPK.ReadOnly = true;
            dgcPK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPK.Width = 120;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Dt";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDate.HeaderText = "datums";
            dgcDate.MinimumWidth = 8;
            dgcDate.Name = "dgcDate";
            dgcDate.ReadOnly = true;
            dgcDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcDate.Width = 85;
            // 
            // dgcHasIt
            // 
            dgcHasIt.DataPropertyName = "DB_HasIt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcHasIt.DefaultCellStyle = dataGridViewCellStyle3;
            dgcHasIt.HeaderText = "Ir gr.";
            dgcHasIt.MinimumWidth = 8;
            dgcHasIt.Name = "dgcHasIt";
            dgcHasIt.ReadOnly = true;
            dgcHasIt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcHasIt.Width = 50;
            // 
            // dgcApgSk
            // 
            dgcApgSk.DataPropertyName = "DB_ApgadajamoSkaits";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcApgSk.DefaultCellStyle = dataGridViewCellStyle4;
            dgcApgSk.HeaderText = "apg. sk.";
            dgcApgSk.MinimumWidth = 8;
            dgcApgSk.Name = "dgcApgSk";
            dgcApgSk.ReadOnly = true;
            dgcApgSk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcApgSk.Width = 50;
            // 
            // dgcPapAtv
            // 
            dgcPapAtv.DataPropertyName = "DB_PapilduAtvieglojumaVeids";
            dgcPapAtv.HeaderText = "papildu atvieglojumi";
            dgcPapAtv.MinimumWidth = 8;
            dgcPapAtv.Name = "dgcPapAtv";
            dgcPapAtv.ReadOnly = true;
            dgcPapAtv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPapAtv.Width = 200;
            // 
            // dgcPensijas
            // 
            dgcPensijas.DataPropertyName = "DB_PensijasVeids";
            dgcPensijas.HeaderText = "pensijas";
            dgcPensijas.MinimumWidth = 8;
            dgcPensijas.Name = "dgcPensijas";
            dgcPensijas.ReadOnly = true;
            dgcPensijas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPensijas.Width = 150;
            // 
            // dgcEDSHasIt
            // 
            dgcEDSHasIt.DataPropertyName = "EDS_HasIt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcEDSHasIt.DefaultCellStyle = dataGridViewCellStyle5;
            dgcEDSHasIt.HeaderText = "EDS ir gr.";
            dgcEDSHasIt.MinimumWidth = 8;
            dgcEDSHasIt.Name = "dgcEDSHasIt";
            dgcEDSHasIt.ReadOnly = true;
            dgcEDSHasIt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcEDSHasIt.Width = 50;
            // 
            // dgcEDSApgSk
            // 
            dgcEDSApgSk.DataPropertyName = "EDS_ApgadajamoSkaits";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcEDSApgSk.DefaultCellStyle = dataGridViewCellStyle6;
            dgcEDSApgSk.HeaderText = "EDS apg. sk.";
            dgcEDSApgSk.MinimumWidth = 8;
            dgcEDSApgSk.Name = "dgcEDSApgSk";
            dgcEDSApgSk.ReadOnly = true;
            dgcEDSApgSk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcEDSApgSk.Width = 70;
            // 
            // dgcEDSPapAtv
            // 
            dgcEDSPapAtv.DataPropertyName = "EDS_PapilduAtvieglojumaVeids";
            dgcEDSPapAtv.HeaderText = "EDS papildu atvieglojumi";
            dgcEDSPapAtv.MinimumWidth = 8;
            dgcEDSPapAtv.Name = "dgcEDSPapAtv";
            dgcEDSPapAtv.ReadOnly = true;
            dgcEDSPapAtv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcEDSPapAtv.Width = 200;
            // 
            // dgcEDSPensijas
            // 
            dgcEDSPensijas.DataPropertyName = "EDS_PensijasVeids";
            dgcEDSPensijas.HeaderText = "EDS pensijas";
            dgcEDSPensijas.MinimumWidth = 8;
            dgcEDSPensijas.Name = "dgcEDSPensijas";
            dgcEDSPensijas.ReadOnly = true;
            dgcEDSPensijas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcEDSPensijas.Width = 150;
            // 
            // FormA_Persons_Egr
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1019, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Controls.Add(bNav);
            Name = "FormA_Persons_Egr";
            Text = "E-grāmatiņu izmaiņas";
            Load += Form_PersonsR_Egr_Load;
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.BindingSource bsRows;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmLoadFromFile;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcHasIt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcApgSk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPapAtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPensijas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEDSHasIt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEDSApgSk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEDSPapAtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcEDSPensijas;
    }
}