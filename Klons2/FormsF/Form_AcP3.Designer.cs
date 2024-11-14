using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_AcP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AcP3));
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbSearch = new MyTextBox();
            tbIdx = new MyPickRowTextBox();
            dgvAcP3 = new MyDataGridView();
            dgcIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsAcP3 = new MyBindingSource(components);
            bnavAcp3 = new MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAcP3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAcP3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp3).BeginInit();
            bnavAcp3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(138, 4);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 17);
            label2.TabIndex = 5;
            label2.Text = "meklēt:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 4);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "Kods:";
            // 
            // tbSearch
            // 
            tbSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSearch.Location = new System.Drawing.Point(197, 3);
            tbSearch.Margin = new System.Windows.Forms.Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(88, 23);
            tbSearch.TabIndex = 1;
            tbSearch.Enter += tbSearch_Enter;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // tbIdx
            // 
            tbIdx.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbIdx.DataMember = null;
            tbIdx.Location = new System.Drawing.Point(53, 3);
            tbIdx.Margin = new System.Windows.Forms.Padding(2);
            tbIdx.Name = "tbIdx";
            tbIdx.SelectedIndex = -1;
            tbIdx.Size = new System.Drawing.Size(80, 23);
            tbIdx.TabIndex = 0;
            tbIdx.RowSelectedEvent += tbIdx_RowSelectedEvent;
            tbIdx.Enter += tbIdx_Enter;
            // 
            // dgvAcP3
            // 
            dgvAcP3.AllowUserToAddRows = false;
            dgvAcP3.AutoGenerateColumns = false;
            dgvAcP3.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvAcP3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAcP3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcIdx, dgcName });
            dgvAcP3.DataSource = bsAcP3;
            dgvAcP3.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAcP3.Location = new System.Drawing.Point(0, 27);
            dgvAcP3.Margin = new System.Windows.Forms.Padding(2);
            dgvAcP3.Name = "dgvAcP3";
            dgvAcP3.ReadOnly = true;
            dgvAcP3.Size = new System.Drawing.Size(462, 285);
            dgvAcP3.TabIndex = 2;
            dgvAcP3.MyKeyDown += dgvAcP3_MyKeyDown;
            dgvAcP3.MyCheckForChanges += dgvAcP3_MyCheckForChanges;
            dgvAcP3.CellDoubleClick += dgvAcP3_CellDoubleClick;
            dgvAcP3.KeyDown += dgvAcP3_KeyDown;
            dgvAcP3.KeyPress += dgvAcP3_KeyPress;
            // 
            // dgcIdx
            // 
            dgcIdx.DataPropertyName = "idx";
            dgcIdx.HeaderText = "kods";
            dgcIdx.Name = "dgcIdx";
            dgcIdx.ReadOnly = true;
            dgcIdx.Width = 64;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "nosaukums";
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            dgcName.Width = 320;
            // 
            // bsAcP3
            // 
            bsAcP3.AutoSaveOnDelete = true;
            bsAcP3.DataMember = "Acp23";
            bsAcP3.Filter = "";
            bsAcP3.MyDataSource = "KlonsData";
            bsAcP3.Name2 = "bsAcP3";
            bsAcP3.Sort = "idx";
            bsAcP3.ListChanged += bsAcP3_ListChanged;
            // 
            // bnavAcp3
            // 
            bnavAcp3.AddNewItem = null;
            bnavAcp3.BindingSource = bsAcP3;
            bnavAcp3.CountItem = bindingNavigatorCountItem;
            bnavAcp3.CountItemFormat = " no {0}";
            bnavAcp3.DataGrid = dgvAcP3;
            bnavAcp3.DeleteItem = null;
            bnavAcp3.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavAcp3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tsbSave });
            bnavAcp3.Location = new System.Drawing.Point(0, 312);
            bnavAcp3.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavAcp3.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavAcp3.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavAcp3.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavAcp3.Name = "bnavAcp3";
            bnavAcp3.PositionItem = bindingNavigatorPositionItem;
            bnavAcp3.SaveItem = null;
            bnavAcp3.Size = new System.Drawing.Size(462, 30);
            bnavAcp3.TabIndex = 3;
            bnavAcp3.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 27);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            bindingNavigatorMoveFirstItem.ToolTipText = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 27);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            bindingNavigatorMovePreviousItem.ToolTipText = "Iet uz iepriekšējo";
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
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 30);
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
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(23, 27);
            tsbSave.Text = "toolStripButton1";
            tsbSave.Click += tsbSave_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbIdx);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(462, 27);
            panel1.TabIndex = 6;
            // 
            // Form_AcP3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(462, 342);
            Controls.Add(dgvAcP3);
            Controls.Add(panel1);
            Controls.Add(bnavAcp3);
            Name = "Form_AcP3";
            Text = "Pazīme IIN darijuma žurnālam";
            Load += FormAcP3_Load;
            KeyPress += FormAcP3_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvAcP3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAcP3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavAcp3).EndInit();
            bnavAcp3.ResumeLayout(false);
            bnavAcp3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingNavigator bnavAcp3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MyDataGridView dgvAcP3;
        private MyBindingSource bsAcP3;
        private MyPickRowTextBox tbIdx;
        private MyTextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Panel panel1;
    }
}