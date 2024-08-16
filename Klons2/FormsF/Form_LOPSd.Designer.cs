using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_LOPSd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LOPSd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            bsLOPSd = new MyBindingSource(components);
            bnavLOPSd = new MyBindingNavigator();
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
            dgvLOPSd = new MyDataGridView();
            dgcLOPSDidl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDZDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDdtld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDusl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDZU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDtpl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDZNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDDocTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDDocSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDClid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDDerscr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDNrX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLOPSDClid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsLOPSd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnavLOPSd).BeginInit();
            bnavLOPSd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLOPSd).BeginInit();
            SuspendLayout();
            // 
            // bsLOPSd
            // 
            bsLOPSd.DataMember = "LOPSD";
            bsLOPSd.MyDataSource = "KlonsData";
            bsLOPSd.Name2 = "bsLOPSd";
            // 
            // bnavLOPSd
            // 
            bnavLOPSd.AddNewItem = null;
            bnavLOPSd.BindingSource = bsLOPSd;
            bnavLOPSd.CountItem = bindingNavigatorCountItem;
            bnavLOPSd.CountItemFormat = " no {0}";
            bnavLOPSd.DeleteItem = null;
            bnavLOPSd.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavLOPSd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavLOPSd.ImageScalingSize = new System.Drawing.Size(23, 26);
            bnavLOPSd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, tsbSearchPrev, tsbSearch, tsbSearchNext, tsbDocLog });
            bnavLOPSd.Location = new System.Drawing.Point(0, 398);
            bnavLOPSd.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavLOPSd.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavLOPSd.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavLOPSd.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavLOPSd.Name = "bnavLOPSd";
            bnavLOPSd.PositionItem = bindingNavigatorPositionItem;
            bnavLOPSd.SaveItem = null;
            bnavLOPSd.Size = new System.Drawing.Size(1023, 33);
            bnavLOPSd.TabIndex = 0;
            bnavLOPSd.Text = "bindingNavigator1";
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
            tsbSearchPrev.Click += tsbSearchPrev_Click;
            // 
            // tsbSearch
            // 
            tsbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbSearch.Name = "tsbSearch";
            tsbSearch.Size = new System.Drawing.Size(91, 33);
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
            // dgvLOPSd
            // 
            dgvLOPSd.AutoGenerateColumns = false;
            dgvLOPSd.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvLOPSd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLOPSd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcLOPSDidl, dgcLOPSDid, dgcLOPSDZDt, dgcLOPSDdtld, dgcLOPSDODT, dgcLOPSDusl, dgcLOPSDZU, dgcLOPSDtpl, dgcLOPSDZNR, dgcLOPSDDate, dgcLOPSDDocTyp, dgcLOPSDDocSt, dgcLOPSDDocNr, dgcLOPSDClid, dgcLOPSDDerscr, dgcLOPSDSumm, dgcLOPSDPVN, dgcLOPSDNrX, dgcLOPSDClid2 });
            dgvLOPSd.DataSource = bsLOPSd;
            dgvLOPSd.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLOPSd.Location = new System.Drawing.Point(0, 0);
            dgvLOPSd.Margin = new System.Windows.Forms.Padding(2);
            dgvLOPSd.Name = "dgvLOPSd";
            dgvLOPSd.ReadOnly = true;
            dgvLOPSd.RowHeadersWidth = 30;
            dgvLOPSd.ShowCellToolTips = false;
            dgvLOPSd.Size = new System.Drawing.Size(1023, 398);
            dgvLOPSd.TabIndex = 1;
            dgvLOPSd.KeyDown += dgvLOPSd_KeyDown;
            // 
            // dgcLOPSDidl
            // 
            dgcLOPSDidl.DataPropertyName = "idl";
            dgcLOPSDidl.HeaderText = "idl";
            dgcLOPSDidl.MinimumWidth = 9;
            dgcLOPSDidl.Name = "dgcLOPSDidl";
            dgcLOPSDidl.ReadOnly = true;
            dgcLOPSDidl.Visible = false;
            dgcLOPSDidl.Width = 90;
            // 
            // dgcLOPSDid
            // 
            dgcLOPSDid.DataPropertyName = "id";
            dgcLOPSDid.HeaderText = "id";
            dgcLOPSDid.MinimumWidth = 9;
            dgcLOPSDid.Name = "dgcLOPSDid";
            dgcLOPSDid.ReadOnly = true;
            dgcLOPSDid.ToolTipText = "labojuma id";
            dgcLOPSDid.Width = 60;
            // 
            // dgcLOPSDZDt
            // 
            dgcLOPSDZDt.DataPropertyName = "ZDt";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm";
            dgcLOPSDZDt.DefaultCellStyle = dataGridViewCellStyle1;
            dgcLOPSDZDt.HeaderText = "labots.dat.";
            dgcLOPSDZDt.MinimumWidth = 9;
            dgcLOPSDZDt.Name = "dgcLOPSDZDt";
            dgcLOPSDZDt.ReadOnly = true;
            dgcLOPSDZDt.ToolTipText = "labojuma datums";
            dgcLOPSDZDt.Width = 130;
            // 
            // dgcLOPSDdtld
            // 
            dgcLOPSDdtld.DataPropertyName = "dtld";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm";
            dgcLOPSDdtld.DefaultCellStyle = dataGridViewCellStyle2;
            dgcLOPSDdtld.HeaderText = "dzēsts dat.";
            dgcLOPSDdtld.MinimumWidth = 9;
            dgcLOPSDdtld.Name = "dgcLOPSDdtld";
            dgcLOPSDdtld.ReadOnly = true;
            dgcLOPSDdtld.ToolTipText = "dzēšanas datums";
            dgcLOPSDdtld.Width = 130;
            // 
            // dgcLOPSDODT
            // 
            dgcLOPSDODT.DataPropertyName = "ODT";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm";
            dgcLOPSDODT.DefaultCellStyle = dataGridViewCellStyle3;
            dgcLOPSDODT.HeaderText = "datums no";
            dgcLOPSDODT.MinimumWidth = 8;
            dgcLOPSDODT.Name = "dgcLOPSDODT";
            dgcLOPSDODT.ReadOnly = true;
            dgcLOPSDODT.ToolTipText = "dokumenta izveides vai iepriekšējā labojuma datums";
            dgcLOPSDODT.Width = 130;
            // 
            // dgcLOPSDusl
            // 
            dgcLOPSDusl.DataPropertyName = "usl";
            dgcLOPSDusl.HeaderText = "lietotājs";
            dgcLOPSDusl.MinimumWidth = 9;
            dgcLOPSDusl.Name = "dgcLOPSDusl";
            dgcLOPSDusl.ReadOnly = true;
            dgcLOPSDusl.Visible = false;
            dgcLOPSDusl.Width = 99;
            // 
            // dgcLOPSDZU
            // 
            dgcLOPSDZU.DataPropertyName = "ZU";
            dgcLOPSDZU.HeaderText = "lietotājs";
            dgcLOPSDZU.MinimumWidth = 9;
            dgcLOPSDZU.Name = "dgcLOPSDZU";
            dgcLOPSDZU.ReadOnly = true;
            dgcLOPSDZU.Width = 90;
            // 
            // dgcLOPSDtpl
            // 
            dgcLOPSDtpl.DataPropertyName = "tpl";
            dgcLOPSDtpl.HeaderText = "tpl";
            dgcLOPSDtpl.MinimumWidth = 9;
            dgcLOPSDtpl.Name = "dgcLOPSDtpl";
            dgcLOPSDtpl.ReadOnly = true;
            dgcLOPSDtpl.Visible = false;
            dgcLOPSDtpl.Width = 90;
            // 
            // dgcLOPSDZNR
            // 
            dgcLOPSDZNR.DataPropertyName = "ZNR";
            dgcLOPSDZNR.HeaderText = "nr.p.k.";
            dgcLOPSDZNR.MinimumWidth = 9;
            dgcLOPSDZNR.Name = "dgcLOPSDZNR";
            dgcLOPSDZNR.ReadOnly = true;
            dgcLOPSDZNR.Width = 72;
            // 
            // dgcLOPSDDate
            // 
            dgcLOPSDDate.DataPropertyName = "Dete";
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dgcLOPSDDate.DefaultCellStyle = dataGridViewCellStyle4;
            dgcLOPSDDate.HeaderText = "datums";
            dgcLOPSDDate.MinimumWidth = 9;
            dgcLOPSDDate.Name = "dgcLOPSDDate";
            dgcLOPSDDate.ReadOnly = true;
            dgcLOPSDDate.Width = 85;
            // 
            // dgcLOPSDDocTyp
            // 
            dgcLOPSDDocTyp.DataPropertyName = "DocTyp";
            dgcLOPSDDocTyp.HeaderText = "dok.veids";
            dgcLOPSDDocTyp.MinimumWidth = 9;
            dgcLOPSDDocTyp.Name = "dgcLOPSDDocTyp";
            dgcLOPSDDocTyp.ReadOnly = true;
            dgcLOPSDDocTyp.Width = 90;
            // 
            // dgcLOPSDDocSt
            // 
            dgcLOPSDDocSt.DataPropertyName = "DocSt";
            dgcLOPSDDocSt.HeaderText = "sērija";
            dgcLOPSDDocSt.MinimumWidth = 9;
            dgcLOPSDDocSt.Name = "dgcLOPSDDocSt";
            dgcLOPSDDocSt.ReadOnly = true;
            dgcLOPSDDocSt.Width = 54;
            // 
            // dgcLOPSDDocNr
            // 
            dgcLOPSDDocNr.DataPropertyName = "DocNr";
            dgcLOPSDDocNr.HeaderText = "dok.nr.";
            dgcLOPSDDocNr.MinimumWidth = 9;
            dgcLOPSDDocNr.Name = "dgcLOPSDDocNr";
            dgcLOPSDDocNr.ReadOnly = true;
            dgcLOPSDDocNr.Width = 110;
            // 
            // dgcLOPSDClid
            // 
            dgcLOPSDClid.DataPropertyName = "ClId";
            dgcLOPSDClid.HeaderText = "persona";
            dgcLOPSDClid.MinimumWidth = 9;
            dgcLOPSDClid.Name = "dgcLOPSDClid";
            dgcLOPSDClid.ReadOnly = true;
            dgcLOPSDClid.Width = 140;
            // 
            // dgcLOPSDDerscr
            // 
            dgcLOPSDDerscr.DataPropertyName = "Descr";
            dgcLOPSDDerscr.HeaderText = "apraksts";
            dgcLOPSDDerscr.MinimumWidth = 9;
            dgcLOPSDDerscr.Name = "dgcLOPSDDerscr";
            dgcLOPSDDerscr.ReadOnly = true;
            dgcLOPSDDerscr.Width = 180;
            // 
            // dgcLOPSDSumm
            // 
            dgcLOPSDSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "# ##0.00;-# ##0.00";
            dgcLOPSDSumm.DefaultCellStyle = dataGridViewCellStyle5;
            dgcLOPSDSumm.HeaderText = "summa";
            dgcLOPSDSumm.MinimumWidth = 9;
            dgcLOPSDSumm.Name = "dgcLOPSDSumm";
            dgcLOPSDSumm.ReadOnly = true;
            dgcLOPSDSumm.Width = 90;
            // 
            // dgcLOPSDPVN
            // 
            dgcLOPSDPVN.DataPropertyName = "PVN";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "# ##0.00;-# ##0.00";
            dgcLOPSDPVN.DefaultCellStyle = dataGridViewCellStyle6;
            dgcLOPSDPVN.HeaderText = "PVN";
            dgcLOPSDPVN.MinimumWidth = 9;
            dgcLOPSDPVN.Name = "dgcLOPSDPVN";
            dgcLOPSDPVN.ReadOnly = true;
            dgcLOPSDPVN.Width = 90;
            // 
            // dgcLOPSDNrX
            // 
            dgcLOPSDNrX.DataPropertyName = "NrX";
            dgcLOPSDNrX.HeaderText = "nr.2";
            dgcLOPSDNrX.MinimumWidth = 9;
            dgcLOPSDNrX.Name = "dgcLOPSDNrX";
            dgcLOPSDNrX.ReadOnly = true;
            dgcLOPSDNrX.Width = 72;
            // 
            // dgcLOPSDClid2
            // 
            dgcLOPSDClid2.DataPropertyName = "ClId2";
            dgcLOPSDClid2.HeaderText = "persona2";
            dgcLOPSDClid2.MinimumWidth = 9;
            dgcLOPSDClid2.Name = "dgcLOPSDClid2";
            dgcLOPSDClid2.ReadOnly = true;
            dgcLOPSDClid2.Width = 140;
            // 
            // Form_LOPSd
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1023, 431);
            CloseOnEscape = true;
            Controls.Add(dgvLOPSd);
            Controls.Add(bnavLOPSd);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form_LOPSd";
            Text = "Dokumentu datu izmaiņu reģistrs";
            Load += FormLOPSd_Load;
            ((System.ComponentModel.ISupportInitialize)bsLOPSd).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnavLOPSd).EndInit();
            bnavLOPSd.ResumeLayout(false);
            bnavLOPSd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLOPSd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsLOPSd;
        private MyBindingNavigator bnavLOPSd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MyDataGridView dgvLOPSd;
        private System.Windows.Forms.ToolStripButton tsbSearchPrev;
        private System.Windows.Forms.ToolStripTextBox tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbSearchNext;
        private System.Windows.Forms.ToolStripButton tsbDocLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDidl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDZDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDdtld;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDusl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDZU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDtpl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDZNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDDocTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDDocSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDClid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDDerscr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDPVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDNrX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLOPSDClid2;
    }
}