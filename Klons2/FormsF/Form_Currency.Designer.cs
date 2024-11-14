using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_Currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Currency));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            bsCurrency = new MyBindingSource(components);
            bnavCurrency = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvCurrency = new MyDataGridView();
            dgcDete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            tbDate = new MyTextBox();
            cmFilter = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)bsCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavCurrency).BeginInit();
            bnavCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrency).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bsCurrency
            // 
            bsCurrency.AutoSaveOnDelete = true;
            bsCurrency.DataMember = "Currency";
            bsCurrency.MyDataSource = "KlonsData";
            bsCurrency.Name2 = "bsCurrency";
            bsCurrency.Sort = "id,dete";
            bsCurrency.ListChanged += bsCurrency_ListChanged;
            // 
            // bnavCurrency
            // 
            bnavCurrency.AddNewItem = bindingNavigatorAddNewItem;
            bnavCurrency.BindingSource = bsCurrency;
            bnavCurrency.CountItem = bindingNavigatorCountItem;
            bnavCurrency.CountItemFormat = " no {0}";
            bnavCurrency.DataGrid = dgvCurrency;
            bnavCurrency.DeleteItem = bindingNavigatorDeleteItem;
            bnavCurrency.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavCurrency.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavCurrency.Location = new System.Drawing.Point(0, 312);
            bnavCurrency.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavCurrency.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavCurrency.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavCurrency.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavCurrency.Name = "bnavCurrency";
            bnavCurrency.PositionItem = bindingNavigatorPositionItem;
            bnavCurrency.SaveItem = null;
            bnavCurrency.Size = new System.Drawing.Size(436, 30);
            bnavCurrency.TabIndex = 0;
            bnavCurrency.Text = "bindingNavigator1";
            bnavCurrency.ItemDeleting += bnavCurrency_ItemDeleting;
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
            // dgvCurrency
            // 
            dgvCurrency.AutoGenerateColumns = false;
            dgvCurrency.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDete, idDataGridViewTextBoxColumn, rateDataGridViewTextBoxColumn });
            dgvCurrency.DataSource = bsCurrency;
            dgvCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCurrency.Location = new System.Drawing.Point(0, 29);
            dgvCurrency.Name = "dgvCurrency";
            dgvCurrency.Size = new System.Drawing.Size(436, 283);
            dgvCurrency.TabIndex = 1;
            dgvCurrency.MyKeyDown += dgvCurrency_MyKeyDown;
            dgvCurrency.MyCheckForChanges += dgvCurrency_MyCheckForChanges;
            dgvCurrency.UserDeletingRow += dgvCurrency_UserDeletingRow;
            // 
            // dgcDete
            // 
            dgcDete.DataPropertyName = "Dete";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dataGridViewCellStyle1.NullValue = null;
            dgcDete.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDete.HeaderText = "Datums";
            dgcDete.Name = "dgcDete";
            dgcDete.Width = 85;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "kods";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ToolTipText = "Valūtas kods (EUR, USD, ...)";
            idDataGridViewTextBoxColumn.Width = 64;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.NullValue = null;
            rateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            rateDataGridViewTextBoxColumn.HeaderText = "kurss";
            rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            rateDataGridViewTextBoxColumn.Width = 80;
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
            bindingNavigatorPositionItem.AccessibleName = "Position";
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
            bindingNavigatorMoveNextItem.Text = "Move next";
            bindingNavigatorMoveNextItem.ToolTipText = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveLastItem.Text = "Move last";
            bindingNavigatorMoveLastItem.ToolTipText = "Iet uz pēdējo";
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
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 27);
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 6);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 17);
            label1.TabIndex = 2;
            label1.Text = "Filtrēt datumu:";
            // 
            // tbDate
            // 
            tbDate.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate.Location = new System.Drawing.Point(117, 4);
            tbDate.Margin = new System.Windows.Forms.Padding(2);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(96, 23);
            tbDate.TabIndex = 3;
            tbDate.KeyPress += tbDate_KeyPress;
            // 
            // cmFilter
            // 
            cmFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmFilter.Location = new System.Drawing.Point(233, 3);
            cmFilter.Margin = new System.Windows.Forms.Padding(2);
            cmFilter.Name = "cmFilter";
            cmFilter.Size = new System.Drawing.Size(66, 24);
            cmFilter.TabIndex = 4;
            cmFilter.Text = "Filtrēt";
            cmFilter.UseVisualStyleBackColor = true;
            cmFilter.Click += cmFilter_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmFilter);
            panel1.Controls.Add(tbDate);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(436, 29);
            panel1.TabIndex = 5;
            // 
            // Form_Currency
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(436, 342);
            Controls.Add(dgvCurrency);
            Controls.Add(panel1);
            Controls.Add(bnavCurrency);
            Name = "Form_Currency";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Valūtu korss";
            Load += Form_Currency_Load;
            ((System.ComponentModel.ISupportInitialize)bsCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavCurrency).EndInit();
            bnavCurrency.ResumeLayout(false);
            bnavCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrency).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsCurrency;
        private MyBindingNavigator bnavCurrency;
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
        private MyDataGridView dgvCurrency;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbDate;
        private System.Windows.Forms.Button cmFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}