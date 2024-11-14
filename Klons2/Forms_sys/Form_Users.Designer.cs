using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Users));
            bsUsers = new MyBindingSource(components);
            bnavUsers = new MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvUsers = new MyDataGridView();
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
            dgcUsersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUsersPSW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUsersTp = new MyDgvMcCBColumn();
            ((System.ComponentModel.ISupportInitialize)bsUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavUsers).BeginInit();
            bnavUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // bsUsers
            // 
            bsUsers.AutoSaveOnDelete = true;
            bsUsers.DataMember = "TUsers";
            bsUsers.Filter = "nm <> 'SYSTEM'";
            bsUsers.MyDataSource = "KlonsData";
            bsUsers.Name2 = "bsUsers";
            bsUsers.ListChanged += bsUsers_ListChanged;
            // 
            // bnavUsers
            // 
            bnavUsers.AddNewItem = bindingNavigatorAddNewItem;
            bnavUsers.BindingSource = bsUsers;
            bnavUsers.CountItem = bindingNavigatorCountItem;
            bnavUsers.CountItemFormat = " no {0}";
            bnavUsers.DataGrid = dgvUsers;
            bnavUsers.DeleteItem = bindingNavigatorDeleteItem;
            bnavUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavUsers.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnavUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavUsers.Location = new System.Drawing.Point(0, 211);
            bnavUsers.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavUsers.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavUsers.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavUsers.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavUsers.Name = "bnavUsers";
            bnavUsers.PositionItem = bindingNavigatorPositionItem;
            bnavUsers.SaveItem = null;
            bnavUsers.Size = new System.Drawing.Size(400, 28);
            bnavUsers.TabIndex = 0;
            bnavUsers.Text = "bindingNavigator1";
            bnavUsers.ItemDeleting += bnavUsers_ItemDeleting;
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
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 25);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
            // 
            // dgvUsers
            // 
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcUsersName, dgcUsersPSW, dgcUsersTp });
            dgvUsers.DataSource = bsUsers;
            dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsers.Location = new System.Drawing.Point(0, 0);
            dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new System.Drawing.Size(400, 211);
            dgvUsers.TabIndex = 1;
            dgvUsers.MyKeyDown += dgvUsers_MyKeyDown;
            dgvUsers.MyCheckForChanges += dgvUsers_MyCheckForChanges;
            dgvUsers.RowValidating += dgvUsers_RowValidating;
            dgvUsers.UserDeletingRow += dgvUsers_UserDeletingRow;
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
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 23);
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
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 25);
            tsbSave.Text = "Saglabāt datus";
            tsbSave.Click += tsbSave_Click;
            // 
            // dgcUsersName
            // 
            dgcUsersName.DataPropertyName = "nm";
            dgcUsersName.HeaderText = "vārds";
            dgcUsersName.Name = "dgcUsersName";
            dgcUsersName.ToolTipText = "lietotāja vārds (kods)";
            dgcUsersName.Width = 110;
            // 
            // dgcUsersPSW
            // 
            dgcUsersPSW.DataPropertyName = "psw";
            dgcUsersPSW.HeaderText = "parole";
            dgcUsersPSW.Name = "dgcUsersPSW";
            dgcUsersPSW.ToolTipText = "lietotāja parole vai tukšs";
            dgcUsersPSW.Width = 110;
            // 
            // dgcUsersTp
            // 
            dgcUsersTp.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            dgcUsersTp.ColumnWidths = "20;100";
            dgcUsersTp.DataPropertyName = "tp";
            dgcUsersTp.DisplayMember = "col1";
            dgcUsersTp.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownList;
            dgcUsersTp.HeaderText = "grupa";
            dgcUsersTp.ItemStrings = new string[]
    {
    "A;administrators",
    "B;pārējie"
    };
            dgcUsersTp.MaxDropDownItems = 15;
            dgcUsersTp.Name = "dgcUsersTp";
            dgcUsersTp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcUsersTp.ToolTipText = "Lietotāju grupa (administrators / pārējie)";
            dgcUsersTp.ValueMember = "col1";
            dgcUsersTp.Width = 80;
            // 
            // Form_Users
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 239);
            Controls.Add(dgvUsers);
            Controls.Add(bnavUsers);
            Name = "Form_Users";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Lietotāji";
            Load += FormUsers_Load;
            ((System.ComponentModel.ISupportInitialize)bsUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavUsers).EndInit();
            bnavUsers.ResumeLayout(false);
            bnavUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsUsers;
        private MyBindingNavigator bnavUsers;
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
        private MyDataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsersPSW;
        private MyDgvMcCBColumn dgcUsersTp;
    }
}