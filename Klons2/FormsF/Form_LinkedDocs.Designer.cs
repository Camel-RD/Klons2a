using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    partial class Form_LinkedDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LinkedDocs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            bsDocs = new MyBindingSource(components);
            bsOPS = new MyBindingSource2(components);
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            tbSumm = new System.Windows.Forms.ToolStripTextBox();
            tbPVN = new System.Windows.Forms.ToolStripTextBox();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            cmOK = new System.Windows.Forms.ToolStripButton();
            cmCancel = new System.Windows.Forms.ToolStripButton();
            toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            cikGadusAtpakaļSkatītiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tbSetYears = new System.Windows.Forms.ToolStripComboBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            dgvOPSd = new MyDataGridView();
            dgcDocsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDocTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDocSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocsPVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvOPS = new MyDataGridView();
            dgcOPSAC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSAC25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSSummC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSCur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOPSDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            docIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aC25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            summCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            curDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            qVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            zDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOPS).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOPSd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOPS).BeginInit();
            SuspendLayout();
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "TRepOPSd";
            bsDocs.MyDataSource = "KlonsRep";
            bsDocs.Name2 = "bsOPS";
            // 
            // bsOPS
            // 
            bsOPS.DataMember = "TRepOPSd_TRepOPS";
            bsOPS.DataSource = bsDocs;
            bsOPS.Name2 = "bsOPS";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, tbSumm, tbPVN, toolStripLabel2, cmOK, cmCancel, toolStripButton1 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(760, 26);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(68, 23);
            toolStripLabel1.Text = "Summas: ";
            // 
            // tbSumm
            // 
            tbSumm.Name = "tbSumm";
            tbSumm.Size = new System.Drawing.Size(81, 26);
            tbSumm.Text = "0.00";
            tbSumm.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPVN
            // 
            tbPVN.Name = "tbPVN";
            tbPVN.Size = new System.Drawing.Size(81, 26);
            tbPVN.Text = "0.00";
            tbPVN.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(33, 23);
            toolStripLabel2.Text = "      ";
            // 
            // cmOK
            // 
            cmOK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            cmOK.Image = (System.Drawing.Image)resources.GetObject("cmOK.Image");
            cmOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmOK.Name = "cmOK";
            cmOK.Size = new System.Drawing.Size(123, 23);
            cmOK.Text = "Izm&antot summas";
            cmOK.Click += cmOK_Click;
            // 
            // cmCancel
            // 
            cmCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            cmCancel.Image = (System.Drawing.Image)resources.GetObject("cmCancel.Image");
            cmCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(48, 23);
            cmCancel.Text = "Atcelt";
            cmCancel.Click += cmCancel_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cikGadusAtpakaļSkatītiesToolStripMenuItem, tbSetYears });
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(38, 23);
            toolStripButton1.Text = "*!*";
            // 
            // cikGadusAtpakaļSkatītiesToolStripMenuItem
            // 
            cikGadusAtpakaļSkatītiesToolStripMenuItem.Name = "cikGadusAtpakaļSkatītiesToolStripMenuItem";
            cikGadusAtpakaļSkatītiesToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            cikGadusAtpakaļSkatītiesToolStripMenuItem.Text = "Cik gadus atpakaļ skatīties:";
            // 
            // tbSetYears
            // 
            tbSetYears.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            tbSetYears.Name = "tbSetYears";
            tbSetYears.Size = new System.Drawing.Size(121, 27);
            tbSetYears.TextChanged += tbSetYears_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 26);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvOPSd);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvOPS);
            splitContainer1.Size = new System.Drawing.Size(760, 255);
            splitContainer1.SplitterDistance = 141;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 4;
            // 
            // dgvOPSd
            // 
            dgvOPSd.AllowUserToAddRows = false;
            dgvOPSd.AllowUserToDeleteRows = false;
            dgvOPSd.AllowUserToResizeRows = false;
            dgvOPSd.AutoGenerateColumns = false;
            dgvOPSd.AutoSave = false;
            dgvOPSd.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvOPSd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOPSd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDocsDate, dgcDocsDocTyp, dgcDocsDocSt, dgcDocsDocNr, dgcDescr, dgcDocsSumm, dgcDocsPVN });
            dgvOPSd.DataSource = bsDocs;
            dgvOPSd.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOPSd.Location = new System.Drawing.Point(0, 0);
            dgvOPSd.Margin = new System.Windows.Forms.Padding(2);
            dgvOPSd.Name = "dgvOPSd";
            dgvOPSd.ReadOnly = true;
            dgvOPSd.RowHeadersVisible = false;
            dgvOPSd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOPSd.Size = new System.Drawing.Size(760, 141);
            dgvOPSd.TabIndex = 2;
            dgvOPSd.SelectionChanged += dgvOPSd_SelectionChanged;
            // 
            // dgcDocsDate
            // 
            dgcDocsDate.DataPropertyName = "Dete";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDocsDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDocsDate.HeaderText = "datums";
            dgcDocsDate.Name = "dgcDocsDate";
            dgcDocsDate.ReadOnly = true;
            dgcDocsDate.Width = 85;
            // 
            // dgcDocsDocTyp
            // 
            dgcDocsDocTyp.DataPropertyName = "DocTyp";
            dgcDocsDocTyp.HeaderText = "veids";
            dgcDocsDocTyp.Name = "dgcDocsDocTyp";
            dgcDocsDocTyp.ReadOnly = true;
            dgcDocsDocTyp.ToolTipText = "dokumenta veids";
            dgcDocsDocTyp.Width = 64;
            // 
            // dgcDocsDocSt
            // 
            dgcDocsDocSt.DataPropertyName = "DocSt";
            dgcDocsDocSt.HeaderText = "sērija";
            dgcDocsDocSt.Name = "dgcDocsDocSt";
            dgcDocsDocSt.ReadOnly = true;
            dgcDocsDocSt.Width = 48;
            // 
            // dgcDocsDocNr
            // 
            dgcDocsDocNr.DataPropertyName = "DocNr";
            dgcDocsDocNr.HeaderText = "numurs";
            dgcDocsDocNr.Name = "dgcDocsDocNr";
            dgcDocsDocNr.ReadOnly = true;
            dgcDocsDocNr.Width = 110;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "Descr";
            dgcDescr.HeaderText = "apraksts";
            dgcDescr.Name = "dgcDescr";
            dgcDescr.ReadOnly = true;
            dgcDescr.Width = 200;
            // 
            // dgcDocsSumm
            // 
            dgcDocsSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dgcDocsSumm.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDocsSumm.HeaderText = "summa";
            dgcDocsSumm.Name = "dgcDocsSumm";
            dgcDocsSumm.ReadOnly = true;
            dgcDocsSumm.Width = 90;
            // 
            // dgcDocsPVN
            // 
            dgcDocsPVN.DataPropertyName = "PVN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dgcDocsPVN.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDocsPVN.HeaderText = "PVN";
            dgcDocsPVN.Name = "dgcDocsPVN";
            dgcDocsPVN.ReadOnly = true;
            dgcDocsPVN.Width = 90;
            // 
            // dgvOPS
            // 
            dgvOPS.AllowUserToAddRows = false;
            dgvOPS.AllowUserToDeleteRows = false;
            dgvOPS.AutoGenerateColumns = false;
            dgvOPS.AutoSave = false;
            dgvOPS.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvOPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcOPSAC11, dgcOPSAC12, dgcOPSAC13, dgcOPSAC14, dgcOPSAC15, dgcOPSAC21, dgcOPSAC22, dgcOPSAC23, dgcOPSAC24, dgcOPSAC25, dgcOPSSummC, dgcOPSCur, dgcOPSSumm, dgcOPSDescr, idDataGridViewTextBoxColumn, docIdDataGridViewTextBoxColumn, descrDataGridViewTextBoxColumn, aC11DataGridViewTextBoxColumn, aC12DataGridViewTextBoxColumn, aC13DataGridViewTextBoxColumn, aC14DataGridViewTextBoxColumn, aC15DataGridViewTextBoxColumn, aC21DataGridViewTextBoxColumn, aC22DataGridViewTextBoxColumn, aC23DataGridViewTextBoxColumn, aC24DataGridViewTextBoxColumn, aC25DataGridViewTextBoxColumn, summCDataGridViewTextBoxColumn, curDataGridViewTextBoxColumn, summDataGridViewTextBoxColumn, qVDataGridViewTextBoxColumn, nLDataGridViewTextBoxColumn, zDtDataGridViewTextBoxColumn });
            dgvOPS.DataSource = bsOPS;
            dgvOPS.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOPS.Location = new System.Drawing.Point(0, 0);
            dgvOPS.Margin = new System.Windows.Forms.Padding(2);
            dgvOPS.Name = "dgvOPS";
            dgvOPS.ReadOnly = true;
            dgvOPS.RowHeadersVisible = false;
            dgvOPS.Size = new System.Drawing.Size(760, 111);
            dgvOPS.TabIndex = 3;
            // 
            // dgcOPSAC11
            // 
            dgcOPSAC11.DataPropertyName = "AC11";
            dgcOPSAC11.HeaderText = "debets";
            dgcOPSAC11.Name = "dgcOPSAC11";
            dgcOPSAC11.ReadOnly = true;
            dgcOPSAC11.Width = 64;
            // 
            // dgcOPSAC12
            // 
            dgcOPSAC12.DataPropertyName = "AC12";
            dgcOPSAC12.HeaderText = "n.p.";
            dgcOPSAC12.Name = "dgcOPSAC12";
            dgcOPSAC12.ReadOnly = true;
            dgcOPSAC12.ToolTipText = "Debets: naudas plūsmas konts";
            dgcOPSAC12.Width = 64;
            // 
            // dgcOPSAC13
            // 
            dgcOPSAC13.DataPropertyName = "AC13";
            dgcOPSAC13.HeaderText = "IIN";
            dgcOPSAC13.Name = "dgcOPSAC13";
            dgcOPSAC13.ReadOnly = true;
            dgcOPSAC13.ToolTipText = "Debets: IIN darijuma kods";
            dgcOPSAC13.Width = 40;
            // 
            // dgcOPSAC14
            // 
            dgcOPSAC14.DataPropertyName = "AC14";
            dgcOPSAC14.HeaderText = "nozare";
            dgcOPSAC14.Name = "dgcOPSAC14";
            dgcOPSAC14.ReadOnly = true;
            dgcOPSAC14.ToolTipText = "Debets: nozare / produkts";
            dgcOPSAC14.Width = 64;
            // 
            // dgcOPSAC15
            // 
            dgcOPSAC15.DataPropertyName = "AC15";
            dgcOPSAC15.HeaderText = "PVN";
            dgcOPSAC15.Name = "dgcOPSAC15";
            dgcOPSAC15.ReadOnly = true;
            dgcOPSAC15.ToolTipText = "Debets: PVN";
            dgcOPSAC15.Width = 48;
            // 
            // dgcOPSAC21
            // 
            dgcOPSAC21.DataPropertyName = "AC21";
            dgcOPSAC21.HeaderText = "kredīts";
            dgcOPSAC21.Name = "dgcOPSAC21";
            dgcOPSAC21.ReadOnly = true;
            dgcOPSAC21.Width = 64;
            // 
            // dgcOPSAC22
            // 
            dgcOPSAC22.DataPropertyName = "AC22";
            dgcOPSAC22.HeaderText = "n.p.";
            dgcOPSAC22.Name = "dgcOPSAC22";
            dgcOPSAC22.ReadOnly = true;
            dgcOPSAC22.ToolTipText = "Kredīts: naudas plūsmas konts";
            dgcOPSAC22.Width = 64;
            // 
            // dgcOPSAC23
            // 
            dgcOPSAC23.DataPropertyName = "AC23";
            dgcOPSAC23.HeaderText = "IIN";
            dgcOPSAC23.Name = "dgcOPSAC23";
            dgcOPSAC23.ReadOnly = true;
            dgcOPSAC23.ToolTipText = "Kredīts: IIN darijuma kods";
            dgcOPSAC23.Width = 40;
            // 
            // dgcOPSAC24
            // 
            dgcOPSAC24.DataPropertyName = "AC24";
            dgcOPSAC24.HeaderText = "nozare";
            dgcOPSAC24.Name = "dgcOPSAC24";
            dgcOPSAC24.ReadOnly = true;
            dgcOPSAC24.ToolTipText = "Kredīts: nozare / produkts";
            dgcOPSAC24.Width = 64;
            // 
            // dgcOPSAC25
            // 
            dgcOPSAC25.DataPropertyName = "AC25";
            dgcOPSAC25.HeaderText = "PVN";
            dgcOPSAC25.Name = "dgcOPSAC25";
            dgcOPSAC25.ReadOnly = true;
            dgcOPSAC25.ToolTipText = "Kredīts: PVN";
            dgcOPSAC25.Width = 48;
            // 
            // dgcOPSSummC
            // 
            dgcOPSSummC.DataPropertyName = "SummC";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dgcOPSSummC.DefaultCellStyle = dataGridViewCellStyle4;
            dgcOPSSummC.HeaderText = "summa";
            dgcOPSSummC.Name = "dgcOPSSummC";
            dgcOPSSummC.ReadOnly = true;
            dgcOPSSummC.ToolTipText = "Summa norādītajā valūtā";
            dgcOPSSummC.Width = 90;
            // 
            // dgcOPSCur
            // 
            dgcOPSCur.DataPropertyName = "Cur";
            dgcOPSCur.HeaderText = "valūta";
            dgcOPSCur.Name = "dgcOPSCur";
            dgcOPSCur.ReadOnly = true;
            dgcOPSCur.ToolTipText = "valūtas kods";
            dgcOPSCur.Width = 56;
            // 
            // dgcOPSSumm
            // 
            dgcOPSSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dgcOPSSumm.DefaultCellStyle = dataGridViewCellStyle5;
            dgcOPSSumm.HeaderText = "summa";
            dgcOPSSumm.Name = "dgcOPSSumm";
            dgcOPSSumm.ReadOnly = true;
            dgcOPSSumm.ToolTipText = "Summa EUR";
            dgcOPSSumm.Width = 90;
            // 
            // dgcOPSDescr
            // 
            dgcOPSDescr.DataPropertyName = "Descr";
            dgcOPSDescr.HeaderText = "apraksts";
            dgcOPSDescr.Name = "dgcOPSDescr";
            dgcOPSDescr.ReadOnly = true;
            dgcOPSDescr.Width = 80;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docIdDataGridViewTextBoxColumn
            // 
            docIdDataGridViewTextBoxColumn.DataPropertyName = "DocId";
            docIdDataGridViewTextBoxColumn.HeaderText = "DocId";
            docIdDataGridViewTextBoxColumn.Name = "docIdDataGridViewTextBoxColumn";
            docIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            descrDataGridViewTextBoxColumn.HeaderText = "Descr";
            descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            descrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC11DataGridViewTextBoxColumn
            // 
            aC11DataGridViewTextBoxColumn.DataPropertyName = "AC11";
            aC11DataGridViewTextBoxColumn.HeaderText = "AC11";
            aC11DataGridViewTextBoxColumn.Name = "aC11DataGridViewTextBoxColumn";
            aC11DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC12DataGridViewTextBoxColumn
            // 
            aC12DataGridViewTextBoxColumn.DataPropertyName = "AC12";
            aC12DataGridViewTextBoxColumn.HeaderText = "AC12";
            aC12DataGridViewTextBoxColumn.Name = "aC12DataGridViewTextBoxColumn";
            aC12DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC13DataGridViewTextBoxColumn
            // 
            aC13DataGridViewTextBoxColumn.DataPropertyName = "AC13";
            aC13DataGridViewTextBoxColumn.HeaderText = "AC13";
            aC13DataGridViewTextBoxColumn.Name = "aC13DataGridViewTextBoxColumn";
            aC13DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC14DataGridViewTextBoxColumn
            // 
            aC14DataGridViewTextBoxColumn.DataPropertyName = "AC14";
            aC14DataGridViewTextBoxColumn.HeaderText = "AC14";
            aC14DataGridViewTextBoxColumn.Name = "aC14DataGridViewTextBoxColumn";
            aC14DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC15DataGridViewTextBoxColumn
            // 
            aC15DataGridViewTextBoxColumn.DataPropertyName = "AC15";
            aC15DataGridViewTextBoxColumn.HeaderText = "AC15";
            aC15DataGridViewTextBoxColumn.Name = "aC15DataGridViewTextBoxColumn";
            aC15DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC21DataGridViewTextBoxColumn
            // 
            aC21DataGridViewTextBoxColumn.DataPropertyName = "AC21";
            aC21DataGridViewTextBoxColumn.HeaderText = "AC21";
            aC21DataGridViewTextBoxColumn.Name = "aC21DataGridViewTextBoxColumn";
            aC21DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC22DataGridViewTextBoxColumn
            // 
            aC22DataGridViewTextBoxColumn.DataPropertyName = "AC22";
            aC22DataGridViewTextBoxColumn.HeaderText = "AC22";
            aC22DataGridViewTextBoxColumn.Name = "aC22DataGridViewTextBoxColumn";
            aC22DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC23DataGridViewTextBoxColumn
            // 
            aC23DataGridViewTextBoxColumn.DataPropertyName = "AC23";
            aC23DataGridViewTextBoxColumn.HeaderText = "AC23";
            aC23DataGridViewTextBoxColumn.Name = "aC23DataGridViewTextBoxColumn";
            aC23DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC24DataGridViewTextBoxColumn
            // 
            aC24DataGridViewTextBoxColumn.DataPropertyName = "AC24";
            aC24DataGridViewTextBoxColumn.HeaderText = "AC24";
            aC24DataGridViewTextBoxColumn.Name = "aC24DataGridViewTextBoxColumn";
            aC24DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aC25DataGridViewTextBoxColumn
            // 
            aC25DataGridViewTextBoxColumn.DataPropertyName = "AC25";
            aC25DataGridViewTextBoxColumn.HeaderText = "AC25";
            aC25DataGridViewTextBoxColumn.Name = "aC25DataGridViewTextBoxColumn";
            aC25DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summCDataGridViewTextBoxColumn
            // 
            summCDataGridViewTextBoxColumn.DataPropertyName = "SummC";
            summCDataGridViewTextBoxColumn.HeaderText = "SummC";
            summCDataGridViewTextBoxColumn.Name = "summCDataGridViewTextBoxColumn";
            summCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // curDataGridViewTextBoxColumn
            // 
            curDataGridViewTextBoxColumn.DataPropertyName = "Cur";
            curDataGridViewTextBoxColumn.HeaderText = "Cur";
            curDataGridViewTextBoxColumn.Name = "curDataGridViewTextBoxColumn";
            curDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summDataGridViewTextBoxColumn
            // 
            summDataGridViewTextBoxColumn.DataPropertyName = "Summ";
            summDataGridViewTextBoxColumn.HeaderText = "Summ";
            summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            summDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qVDataGridViewTextBoxColumn
            // 
            qVDataGridViewTextBoxColumn.DataPropertyName = "QV";
            qVDataGridViewTextBoxColumn.HeaderText = "QV";
            qVDataGridViewTextBoxColumn.Name = "qVDataGridViewTextBoxColumn";
            qVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nLDataGridViewTextBoxColumn
            // 
            nLDataGridViewTextBoxColumn.DataPropertyName = "NL";
            nLDataGridViewTextBoxColumn.HeaderText = "NL";
            nLDataGridViewTextBoxColumn.Name = "nLDataGridViewTextBoxColumn";
            nLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zDtDataGridViewTextBoxColumn
            // 
            zDtDataGridViewTextBoxColumn.DataPropertyName = "ZDt";
            zDtDataGridViewTextBoxColumn.HeaderText = "ZDt";
            zDtDataGridViewTextBoxColumn.Name = "zDtDataGridViewTextBoxColumn";
            zDtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_LinkedDocs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 281);
            CloseOnEscape = true;
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "Form_LinkedDocs";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Saistītie dokumenti";
            FormClosing += Form_LinkedDocs_FormClosing;
            Load += Form_LinkedDocs_Load;
            PreviewKeyDown += Form_LinkedDocs_PreviewKeyDown;
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOPS).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOPSd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOPS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource2 bsOPS;
        private MyBindingSource bsDocs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbSumm;
        private System.Windows.Forms.ToolStripTextBox tbPVN;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton cmOK;
        private System.Windows.Forms.ToolStripButton cmCancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyDataGridView dgvOPSd;
        private MyDataGridView dgvOPS;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem cikGadusAtpakaļSkatītiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tbSetYears;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDocTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDocSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocsPVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSAC25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSSummC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSCur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOPSDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC21DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC22DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC23DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC24DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aC25DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zDtDataGridViewTextBoxColumn;
    }
}