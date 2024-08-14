namespace KlonsA.Forms
{
    partial class FormA_EventTypes2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_EventTypes2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            bnavEv = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bsEv = new KlonsLIB.Data.MyBindingSource(components);
            dgvEv = new KlonsLIB.Components.MyDataGridView();
            dgcTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)bnavEv).BeginInit();
            bnavEv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bnavEv
            // 
            bnavEv.AddNewItem = bindingNavigatorAddNewItem;
            bnavEv.BindingSource = bsEv;
            bnavEv.CountItem = bindingNavigatorCountItem;
            bnavEv.CountItemFormat = " no {0}";
            bnavEv.DataGrid = dgvEv;
            bnavEv.DeleteItem = null;
            bnavEv.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavEv.ImageScalingSize = new System.Drawing.Size(23, 26);
            bnavEv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavEv.Location = new System.Drawing.Point(0, 289);
            bnavEv.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavEv.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavEv.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavEv.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavEv.Name = "bnavEv";
            bnavEv.PositionItem = bindingNavigatorPositionItem;
            bnavEv.SaveItem = null;
            bnavEv.Size = new System.Drawing.Size(618, 33);
            bnavEv.TabIndex = 0;
            bnavEv.Text = "myBindingNavigator1";
            bnavEv.ItemDeleting += bnavEv_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bsEv
            // 
            bsEv.DataMember = "EVENT_TYPES2";
            bsEv.MyDataSource = "KlonsAData";
            bsEv.Sort = "TAG";
            bsEv.UseDataGridView = dgvEv;
            bsEv.ListChanged += bsEv_ListChanged;
            // 
            // dgvEv
            // 
            dgvEv.AutoGenerateColumns = false;
            dgvEv.AutoSave = false;
            dgvEv.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcTag, dgcDescr, dgcID });
            dgvEv.DataSource = bsEv;
            dgvEv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEv.Location = new System.Drawing.Point(0, 0);
            dgvEv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvEv.Name = "dgvEv";
            dgvEv.RowHeadersWidth = 62;
            dgvEv.ShowCellToolTips = false;
            dgvEv.Size = new System.Drawing.Size(618, 289);
            dgvEv.TabIndex = 1;
            dgvEv.MyCheckForChanges += dgvEv_MyCheckForChanges;
            dgvEv.UserDeletingRow += dgvEv_UserDeletingRow;
            dgvEv.KeyDown += dgvEv_KeyDown;
            dgvEv.KeyPress += dgvEv_KeyPress;
            // 
            // dgcTag
            // 
            dgcTag.DataPropertyName = "TAG";
            dgcTag.HeaderText = "kods";
            dgcTag.MinimumWidth = 9;
            dgcTag.Name = "dgcTag";
            dgcTag.Width = 168;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "nosaukums";
            dgcDescr.MinimumWidth = 9;
            dgcDescr.Name = "dgcDescr";
            dgcDescr.Width = 337;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.MinimumWidth = 9;
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            dgcID.Width = 168;
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
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 30);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = KlonsF.Properties.Resources.Save1;
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(27, 30);
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "EVENT_TYPES2",
    "EVENTS",
    null
    };
            // 
            // FormA_EventTypes2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(618, 322);
            Controls.Add(dgvEv);
            Controls.Add(bnavEv);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormA_EventTypes2";
            Text = "Papildus notikumi";
            Load += Form_EventTypes2_Load;
            ((System.ComponentModel.ISupportInitialize)bnavEv).EndInit();
            bnavEv.ResumeLayout(false);
            bnavEv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsEv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEv).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bnavEv;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private KlonsLIB.Data.MyBindingSource bsEv;
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
        private KlonsLIB.Components.MyDataGridView dgvEv;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}