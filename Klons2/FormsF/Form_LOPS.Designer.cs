using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_LOPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LOPS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            bsLOPS = new MyBindingSource(components);
            bnavLOPS = new MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbSearchPrev = new System.Windows.Forms.ToolStripButton();
            tsbSearch = new System.Windows.Forms.ToolStripTextBox();
            tsbSearchNext = new System.Windows.Forms.ToolStripButton();
            tsbDocLog = new System.Windows.Forms.ToolStripButton();
            dgvLOPS = new MyDataGridView();
            dgcLOPSidl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPStl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPStld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSusl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPStpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSocId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSAC25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSQV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsLOPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavLOPS).BeginInit();
            bnavLOPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLOPS).BeginInit();
            SuspendLayout();
            // 
            // bsLOPS
            // 
            bsLOPS.DataMember = "LOPS";
            bsLOPS.MyDataSource = "KlonsData";
            bsLOPS.Name2 = "bsLOPS";
            // 
            // bnavLOPS
            // 
            bnavLOPS.AddNewItem = null;
            bnavLOPS.BindingSource = bsLOPS;
            bnavLOPS.CountItem = bindingNavigatorCountItem;
            bnavLOPS.CountItemFormat = " no {0}";
            bnavLOPS.DeleteItem = null;
            bnavLOPS.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavLOPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavLOPS.ImageScalingSize = new System.Drawing.Size(23, 26);
            bnavLOPS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tsbSearchPrev, tsbSearch, tsbSearchNext, tsbDocLog });
            bnavLOPS.Location = new System.Drawing.Point(0, 395);
            bnavLOPS.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavLOPS.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavLOPS.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavLOPS.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavLOPS.Name = "bnavLOPS";
            bnavLOPS.PositionItem = bindingNavigatorPositionItem;
            bnavLOPS.SaveItem = null;
            bnavLOPS.Size = new System.Drawing.Size(1032, 33);
            bnavLOPS.TabIndex = 0;
            bnavLOPS.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 30);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Skaits";
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
            bindingNavigatorMoveNextItem.Text = "+";
            bindingNavigatorMoveNextItem.ToolTipText = "Iet uz nākošo";
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
            // tsbSearchPrev
            // 
            tsbSearchPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSearchPrev.Image = (System.Drawing.Image)resources.GetObject("tsbSearchPrev.Image");
            tsbSearchPrev.Name = "tsbSearchPrev";
            tsbSearchPrev.RightToLeftAutoMirrorImage = true;
            tsbSearchPrev.Size = new System.Drawing.Size(27, 30);
            tsbSearchPrev.Text = "Iet uz iepriekšējo";
            tsbSearchPrev.ToolTipText = "Meklēt iepriekšējo";
            tsbSearchPrev.Click += tsbSearchPrev_Click;
            // 
            // tsbSearch
            // 
            tsbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new System.Drawing.Size(91, 33);
            tsbSearch.ToolTipText = "Meklēt";
            tsbSearch.Enter += tsbSearch_Enter;
            tsbSearch.KeyPress += tsbSearch_KeyPress;
            // 
            // tsbSearchNext
            // 
            tsbSearchNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSearchNext.Image = (System.Drawing.Image)resources.GetObject("tsbSearchNext.Image");
            tsbSearchNext.Name = "tsbSearchNext";
            tsbSearchNext.RightToLeftAutoMirrorImage = true;
            tsbSearchNext.Size = new System.Drawing.Size(27, 30);
            tsbSearchNext.Text = "+";
            tsbSearchNext.ToolTipText = "Meklēt nākošo";
            tsbSearchNext.Click += tsbSearchNext_Click;
            // 
            // tsbDocLog
            // 
            tsbDocLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbDocLog.Image = (System.Drawing.Image)resources.GetObject("tsbDocLog.Image");
            tsbDocLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDocLog.Name = "tsbDocLog";
            tsbDocLog.Size = new System.Drawing.Size(135, 30);
            tsbDocLog.Text = "Dokumenta vēsture";
            tsbDocLog.Click += tsbDocLog_Click;
            // 
            // dgvLOPS
            // 
            dgvLOPS.AutoGenerateColumns = false;
            dgvLOPS.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvLOPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLOPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcLOPSidl, dgcLOPSid, dgcLOPStl, dgcLOPStld, dgcLOPSODT, dgcLOPSusl, dgcLOPStpl, dgcLOPSocId, dgcLOPSAC11, dgcLOPSAC12, dgcLOPSAC13, dgcLOPSAC14, dgcLOPSAC15, dgcLOPSAC21, dgcLOPSAC22, dgcLOPSAC23, dgcLOPSAC24, dgcLOPSAC25, dgcLOPSSumm, dgcLOPSQV });
            dgvLOPS.DataSource = bsLOPS;
            dgvLOPS.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLOPS.Location = new System.Drawing.Point(0, 0);
            dgvLOPS.Margin = new System.Windows.Forms.Padding(2);
            dgvLOPS.Name = "dgvLOPS";
            dgvLOPS.ReadOnly = true;
            dgvLOPS.RowHeadersWidth = 30;
            dgvLOPS.ShowCellToolTips = false;
            dgvLOPS.Size = new System.Drawing.Size(1032, 395);
            dgvLOPS.TabIndex = 1;
            dgvLOPS.KeyDown += dgvLOPS_KeyDown;
            // 
            // dgcLOPSidl
            // 
            dgcLOPSidl.DataPropertyName = "idl";
            dgcLOPSidl.HeaderText = "idl";
            dgcLOPSidl.MinimumWidth = 9;
            dgcLOPSidl.Name = "dgcLOPSidl";
            dgcLOPSidl.ReadOnly = true;
            dgcLOPSidl.Visible = false;
            dgcLOPSidl.Width = 72;
            // 
            // dgcLOPSid
            // 
            dgcLOPSid.DataPropertyName = "id";
            dgcLOPSid.HeaderText = "id";
            dgcLOPSid.MinimumWidth = 9;
            dgcLOPSid.Name = "dgcLOPSid";
            dgcLOPSid.ReadOnly = true;
            dgcLOPSid.ToolTipText = "ieraksta numurs";
            dgcLOPSid.Width = 60;
            // 
            // dgcLOPStl
            // 
            dgcLOPStl.DataPropertyName = "dtl";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            dgcLOPStl.DefaultCellStyle = dataGridViewCellStyle1;
            dgcLOPStl.HeaderText = "labots dat.";
            dgcLOPStl.MinimumWidth = 9;
            dgcLOPStl.Name = "dgcLOPStl";
            dgcLOPStl.ReadOnly = true;
            dgcLOPStl.ToolTipText = "lobojuma datums";
            dgcLOPStl.Width = 120;
            // 
            // dgcLOPStld
            // 
            dgcLOPStld.DataPropertyName = "dtld";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            dgcLOPStld.DefaultCellStyle = dataGridViewCellStyle2;
            dgcLOPStld.HeaderText = "dzēsts dat.";
            dgcLOPStld.MinimumWidth = 9;
            dgcLOPStld.Name = "dgcLOPStld";
            dgcLOPStld.ReadOnly = true;
            dgcLOPStld.ToolTipText = "dzēšanas datuma";
            dgcLOPStld.Width = 120;
            // 
            // dgcLOPSODT
            // 
            dgcLOPSODT.DataPropertyName = "ODT";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm";
            dgcLOPSODT.DefaultCellStyle = dataGridViewCellStyle3;
            dgcLOPSODT.HeaderText = "datums no";
            dgcLOPSODT.MinimumWidth = 8;
            dgcLOPSODT.Name = "dgcLOPSODT";
            dgcLOPSODT.ReadOnly = true;
            dgcLOPSODT.ToolTipText = "rindas izveides vai iepriekšēj`labojuma datums";
            dgcLOPSODT.Width = 120;
            // 
            // dgcLOPSusl
            // 
            dgcLOPSusl.DataPropertyName = "usl";
            dgcLOPSusl.HeaderText = "lietotājs";
            dgcLOPSusl.MinimumWidth = 9;
            dgcLOPSusl.Name = "dgcLOPSusl";
            dgcLOPSusl.ReadOnly = true;
            dgcLOPSusl.ToolTipText = "lietotājs, kas veicis izmaiņas";
            dgcLOPSusl.Width = 99;
            // 
            // dgcLOPStpl
            // 
            dgcLOPStpl.DataPropertyName = "tpl";
            dgcLOPStpl.HeaderText = "tpl";
            dgcLOPStpl.MinimumWidth = 9;
            dgcLOPStpl.Name = "dgcLOPStpl";
            dgcLOPStpl.ReadOnly = true;
            dgcLOPStpl.Visible = false;
            dgcLOPStpl.Width = 90;
            // 
            // dgcLOPSocId
            // 
            dgcLOPSocId.DataPropertyName = "DocId";
            dgcLOPSocId.HeaderText = "dok.id.";
            dgcLOPSocId.MinimumWidth = 9;
            dgcLOPSocId.Name = "dgcLOPSocId";
            dgcLOPSocId.ReadOnly = true;
            dgcLOPSocId.ToolTipText = "dokumeta id";
            dgcLOPSocId.Width = 72;
            // 
            // dgcLOPSAC11
            // 
            dgcLOPSAC11.DataPropertyName = "AC11";
            dgcLOPSAC11.HeaderText = "debets";
            dgcLOPSAC11.MinimumWidth = 9;
            dgcLOPSAC11.Name = "dgcLOPSAC11";
            dgcLOPSAC11.ReadOnly = true;
            dgcLOPSAC11.Width = 72;
            // 
            // dgcLOPSAC12
            // 
            dgcLOPSAC12.DataPropertyName = "AC12";
            dgcLOPSAC12.HeaderText = "D2";
            dgcLOPSAC12.MinimumWidth = 9;
            dgcLOPSAC12.Name = "dgcLOPSAC12";
            dgcLOPSAC12.ReadOnly = true;
            dgcLOPSAC12.ToolTipText = "debets: naudas plūsma";
            dgcLOPSAC12.Width = 72;
            // 
            // dgcLOPSAC13
            // 
            dgcLOPSAC13.DataPropertyName = "AC13";
            dgcLOPSAC13.HeaderText = "D3";
            dgcLOPSAC13.MinimumWidth = 9;
            dgcLOPSAC13.Name = "dgcLOPSAC13";
            dgcLOPSAC13.ReadOnly = true;
            dgcLOPSAC13.ToolTipText = "debets: IIN darijuma kods";
            dgcLOPSAC13.Width = 45;
            // 
            // dgcLOPSAC14
            // 
            dgcLOPSAC14.DataPropertyName = "AC14";
            dgcLOPSAC14.HeaderText = "D4";
            dgcLOPSAC14.MinimumWidth = 9;
            dgcLOPSAC14.Name = "dgcLOPSAC14";
            dgcLOPSAC14.ReadOnly = true;
            dgcLOPSAC14.ToolTipText = "debets: kontējuma pzīme";
            dgcLOPSAC14.Width = 72;
            // 
            // dgcLOPSAC15
            // 
            dgcLOPSAC15.DataPropertyName = "AC15";
            dgcLOPSAC15.HeaderText = "D5";
            dgcLOPSAC15.MinimumWidth = 9;
            dgcLOPSAC15.Name = "dgcLOPSAC15";
            dgcLOPSAC15.ReadOnly = true;
            dgcLOPSAC15.ToolTipText = "debets: PVN";
            dgcLOPSAC15.Width = 54;
            // 
            // dgcLOPSAC21
            // 
            dgcLOPSAC21.DataPropertyName = "AC21";
            dgcLOPSAC21.HeaderText = "kredīts";
            dgcLOPSAC21.MinimumWidth = 9;
            dgcLOPSAC21.Name = "dgcLOPSAC21";
            dgcLOPSAC21.ReadOnly = true;
            dgcLOPSAC21.Width = 72;
            // 
            // dgcLOPSAC22
            // 
            dgcLOPSAC22.DataPropertyName = "AC22";
            dgcLOPSAC22.HeaderText = "K2";
            dgcLOPSAC22.MinimumWidth = 9;
            dgcLOPSAC22.Name = "dgcLOPSAC22";
            dgcLOPSAC22.ReadOnly = true;
            dgcLOPSAC22.ToolTipText = "kredīts: naudas plūsma";
            dgcLOPSAC22.Width = 72;
            // 
            // dgcLOPSAC23
            // 
            dgcLOPSAC23.DataPropertyName = "AC23";
            dgcLOPSAC23.HeaderText = "K3";
            dgcLOPSAC23.MinimumWidth = 9;
            dgcLOPSAC23.Name = "dgcLOPSAC23";
            dgcLOPSAC23.ReadOnly = true;
            dgcLOPSAC23.ToolTipText = "kredīts: IIN darijuma kods";
            dgcLOPSAC23.Width = 45;
            // 
            // dgcLOPSAC24
            // 
            dgcLOPSAC24.DataPropertyName = "AC24";
            dgcLOPSAC24.HeaderText = "K4";
            dgcLOPSAC24.MinimumWidth = 9;
            dgcLOPSAC24.Name = "dgcLOPSAC24";
            dgcLOPSAC24.ReadOnly = true;
            dgcLOPSAC24.ToolTipText = "kredīts: kontējuma pazīme";
            dgcLOPSAC24.Width = 72;
            // 
            // dgcLOPSAC25
            // 
            dgcLOPSAC25.DataPropertyName = "AC25";
            dgcLOPSAC25.HeaderText = "K5";
            dgcLOPSAC25.MinimumWidth = 9;
            dgcLOPSAC25.Name = "dgcLOPSAC25";
            dgcLOPSAC25.ReadOnly = true;
            dgcLOPSAC25.ToolTipText = "kredīts: PVN";
            dgcLOPSAC25.Width = 54;
            // 
            // dgcLOPSSumm
            // 
            dgcLOPSSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "# ##0.00;-# ##0.00";
            dgcLOPSSumm.DefaultCellStyle = dataGridViewCellStyle4;
            dgcLOPSSumm.HeaderText = "summa";
            dgcLOPSSumm.MinimumWidth = 9;
            dgcLOPSSumm.Name = "dgcLOPSSumm";
            dgcLOPSSumm.ReadOnly = true;
            dgcLOPSSumm.Width = 90;
            // 
            // dgcLOPSQV
            // 
            dgcLOPSQV.DataPropertyName = "QV";
            dgcLOPSQV.HeaderText = "daudzums";
            dgcLOPSQV.MinimumWidth = 9;
            dgcLOPSQV.Name = "dgcLOPSQV";
            dgcLOPSQV.ReadOnly = true;
            dgcLOPSQV.Width = 90;
            // 
            // Form_LOPS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1032, 428);
            CloseOnEscape = true;
            Controls.Add(dgvLOPS);
            Controls.Add(bnavLOPS);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_LOPS";
            Text = "Kontējuma datu izmaiņu reģistrs";
            Load += FormLOPS_Load;
            ((System.ComponentModel.ISupportInitialize)bsLOPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavLOPS).EndInit();
            bnavLOPS.ResumeLayout(false);
            bnavLOPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLOPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsLOPS;
        private MyBindingNavigator bnavLOPS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MyDataGridView dgvLOPS;
        private System.Windows.Forms.ToolStripButton tsbSearchPrev;
        private System.Windows.Forms.ToolStripTextBox tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchNext;
        private System.Windows.Forms.ToolStripButton tsbDocLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSidl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPStl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPStld;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSusl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPStpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSAC25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSQV;
    }
}