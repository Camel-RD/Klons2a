using KlonsLIB.Components;
using KlonsLIB.Data;
using KlonsF.Classes;

namespace KlonsF.Forms
{
    partial class Form_OpsFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OpsFilter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            myToolStrip = new System.Windows.Forms.ToolStrip();
            tsbFilter = new System.Windows.Forms.ToolStripButton();
            tsbFilterDocs = new System.Windows.Forms.ToolStripButton();
            tsbFindInDocs = new System.Windows.Forms.ToolStripButton();
            toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            dokumentuSarakstsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ierakstuIzrakstsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsbDocs = new System.Windows.Forms.ToolStripButton();
            cmAndOr = new System.Windows.Forms.Button();
            dgvOPS = new MyDataGridView();
            dgcZNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocSt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcClid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPVNRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sgcSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAC25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcQV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bs_vwOPS = new MyBindingSource(components);
            cbAC25 = new MyMcFlatComboBox();
            cbAC24 = new MyMcFlatComboBox();
            cbAC23 = new MyMcFlatComboBox();
            cbAC22 = new MyMcFlatComboBox();
            cbAC21 = new MyMcFlatComboBox();
            cbAC15 = new MyMcFlatComboBox();
            cbAC14 = new MyMcFlatComboBox();
            cbAC13 = new MyMcFlatComboBox();
            cbAC12 = new MyMcFlatComboBox();
            cbAC11 = new MyMcFlatComboBox();
            tbText = new MyTextBox();
            cbClid = new MyMcFlatComboBox();
            tbDate2 = new MyTextBox();
            tbDate1 = new MyTextBox();
            tbSum = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            cbDocGr = new MyMcFlatComboBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            ierakstuŽurnālsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rādītPilnuPersonasNosaukumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rādītPersonasReģistrācijasNumuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            tbAmount = new MyTextBox();
            myToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bs_vwOPS).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(89, 7);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 17);
            label1.TabIndex = 19;
            label1.Text = "-";
            // 
            // myToolStrip
            // 
            myToolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            myToolStrip.ImageScalingSize = new System.Drawing.Size(19, 19);
            myToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbFilter, tsbFilterDocs, tsbFindInDocs, toolStripButton1, tsbDocs });
            myToolStrip.Location = new System.Drawing.Point(0, 0);
            myToolStrip.Name = "myToolStrip";
            myToolStrip.Size = new System.Drawing.Size(825, 37);
            myToolStrip.TabIndex = 17;
            myToolStrip.Text = "toolStrip1";
            myToolStrip.Visible = false;
            // 
            // tsbFilter
            // 
            tsbFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbFilter.Image = (System.Drawing.Image)resources.GetObject("tsbFilter.Image");
            tsbFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbFilter.Name = "tsbFilter";
            tsbFilter.Size = new System.Drawing.Size(47, 34);
            tsbFilter.Text = "&Filtrēt";
            tsbFilter.Click += tsbFilter_Click;
            // 
            // tsbFilterDocs
            // 
            tsbFilterDocs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbFilterDocs.Image = (System.Drawing.Image)resources.GetObject("tsbFilterDocs.Image");
            tsbFilterDocs.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbFilterDocs.Name = "tsbFilterDocs";
            tsbFilterDocs.Size = new System.Drawing.Size(131, 34);
            tsbFilterDocs.Text = "&Atlasīt dokumentus";
            tsbFilterDocs.Click += tsbFilterDocs_Click;
            // 
            // tsbFindInDocs
            // 
            tsbFindInDocs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbFindInDocs.Image = (System.Drawing.Image)resources.GetObject("tsbFindInDocs.Image");
            tsbFindInDocs.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbFindInDocs.Name = "tsbFindInDocs";
            tsbFindInDocs.Size = new System.Drawing.Size(130, 34);
            tsbFindInDocs.Text = "Atrast dokumentos";
            tsbFindInDocs.Click += tsbFindInDocs_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dokumentuSarakstsToolStripMenuItem, ierakstuIzrakstsToolStripMenuItem });
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(70, 34);
            toolStripButton1.Text = "Izdrukai";
            // 
            // dokumentuSarakstsToolStripMenuItem
            // 
            dokumentuSarakstsToolStripMenuItem.Name = "dokumentuSarakstsToolStripMenuItem";
            dokumentuSarakstsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            dokumentuSarakstsToolStripMenuItem.Text = "Dokumentu saraksts";
            dokumentuSarakstsToolStripMenuItem.Click += dokumentuSarakstsToolStripMenuItem_Click;
            // 
            // ierakstuIzrakstsToolStripMenuItem
            // 
            ierakstuIzrakstsToolStripMenuItem.Name = "ierakstuIzrakstsToolStripMenuItem";
            ierakstuIzrakstsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            ierakstuIzrakstsToolStripMenuItem.Text = "Ierakstu izraksts";
            ierakstuIzrakstsToolStripMenuItem.Click += ierakstuIzrakstsToolStripMenuItem_Click;
            // 
            // tsbDocs
            // 
            tsbDocs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbDocs.Image = (System.Drawing.Image)resources.GetObject("tsbDocs.Image");
            tsbDocs.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDocs.Name = "tsbDocs";
            tsbDocs.Size = new System.Drawing.Size(79, 34);
            tsbDocs.Text = "&Dokumenti";
            tsbDocs.Click += tsbDocs_Click;
            // 
            // cmAndOr
            // 
            cmAndOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmAndOr.Location = new System.Drawing.Point(6, 37);
            cmAndOr.Margin = new System.Windows.Forms.Padding(2);
            cmAndOr.Name = "cmAndOr";
            cmAndOr.Size = new System.Drawing.Size(41, 29);
            cmAndOr.TabIndex = 10;
            cmAndOr.Text = "vai";
            cmAndOr.UseVisualStyleBackColor = true;
            cmAndOr.Click += cmAndOr_Click;
            // 
            // dgvOPS
            // 
            dgvOPS.AllowUserToAddRows = false;
            dgvOPS.AllowUserToDeleteRows = false;
            dgvOPS.AllowUserToResizeRows = false;
            dgvOPS.AutoGenerateColumns = false;
            dgvOPS.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvOPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOPS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcZNR, dgcDate, dgcDocTyp, dgcDocSt, dgcDocNr, dgcClid, dgcRegNr, dgcPVNRegNr, dgcDescr, dgcAC11, dgcAC21, sgcSumm, dgcAC12, dgcAC13, dgcAC14, dgcAC15, dgcAC22, dgcAC23, dgcAC24, dgcAC25, dgcQV, dgcDescr2 });
            dgvOPS.DataSource = bs_vwOPS;
            dgvOPS.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOPS.Location = new System.Drawing.Point(0, 80);
            dgvOPS.Margin = new System.Windows.Forms.Padding(2);
            dgvOPS.Name = "dgvOPS";
            dgvOPS.ReadOnly = true;
            dgvOPS.RowHeadersWidth = 62;
            dgvOPS.Size = new System.Drawing.Size(825, 364);
            dgvOPS.TabIndex = 18;
            dgvOPS.CellFormatting += dgvOPS_CellFormatting;
            dgvOPS.CellToolTipTextNeeded += dgvOPS_CellToolTipTextNeeded;
            // 
            // dgcZNR
            // 
            dgcZNR.DataPropertyName = "ZNR";
            dgcZNR.HeaderText = "N.p.k.";
            dgcZNR.MinimumWidth = 7;
            dgcZNR.Name = "dgcZNR";
            dgcZNR.ReadOnly = true;
            dgcZNR.Width = 55;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Dete";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcDate.DefaultCellStyle = dataGridViewCellStyle1;
            dgcDate.HeaderText = "Datums";
            dgcDate.MinimumWidth = 7;
            dgcDate.Name = "dgcDate";
            dgcDate.ReadOnly = true;
            dgcDate.Width = 85;
            // 
            // dgcDocTyp
            // 
            dgcDocTyp.DataPropertyName = "DocTyp";
            dgcDocTyp.HeaderText = "Dok.veids";
            dgcDocTyp.MinimumWidth = 7;
            dgcDocTyp.Name = "dgcDocTyp";
            dgcDocTyp.ReadOnly = true;
            dgcDocTyp.Width = 63;
            // 
            // dgcDocSt
            // 
            dgcDocSt.DataPropertyName = "DocSt";
            dgcDocSt.HeaderText = "Sērija";
            dgcDocSt.MinimumWidth = 7;
            dgcDocSt.Name = "dgcDocSt";
            dgcDocSt.ReadOnly = true;
            dgcDocSt.Width = 39;
            // 
            // dgcDocNr
            // 
            dgcDocNr.DataPropertyName = "DocNr";
            dgcDocNr.HeaderText = "Dok.nr.";
            dgcDocNr.MinimumWidth = 7;
            dgcDocNr.Name = "dgcDocNr";
            dgcDocNr.ReadOnly = true;
            dgcDocNr.Width = 78;
            // 
            // dgcClid
            // 
            dgcClid.DataPropertyName = "ClId";
            dgcClid.HeaderText = "Persona";
            dgcClid.MinimumWidth = 7;
            dgcClid.Name = "dgcClid";
            dgcClid.ReadOnly = true;
            dgcClid.Width = 140;
            // 
            // dgcRegNr
            // 
            dgcRegNr.DataPropertyName = "RegNr";
            dgcRegNr.HeaderText = "Reģ.nr.";
            dgcRegNr.MinimumWidth = 7;
            dgcRegNr.Name = "dgcRegNr";
            dgcRegNr.ReadOnly = true;
            dgcRegNr.ToolTipText = "Personas reģistrācijas numurs";
            dgcRegNr.Width = 105;
            // 
            // dgcPVNRegNr
            // 
            dgcPVNRegNr.DataPropertyName = "PVNRegNr";
            dgcPVNRegNr.HeaderText = "PVN Reģ.nr.";
            dgcPVNRegNr.MinimumWidth = 7;
            dgcPVNRegNr.Name = "dgcPVNRegNr";
            dgcPVNRegNr.ReadOnly = true;
            dgcPVNRegNr.Width = 113;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "Descr";
            dgcDescr.HeaderText = "Apraksts";
            dgcDescr.MinimumWidth = 7;
            dgcDescr.Name = "dgcDescr";
            dgcDescr.ReadOnly = true;
            dgcDescr.Width = 126;
            // 
            // dgcAC11
            // 
            dgcAC11.DataPropertyName = "AC11";
            dgcAC11.HeaderText = "Debets";
            dgcAC11.MinimumWidth = 7;
            dgcAC11.Name = "dgcAC11";
            dgcAC11.ReadOnly = true;
            dgcAC11.Width = 63;
            // 
            // dgcAC21
            // 
            dgcAC21.DataPropertyName = "AC21";
            dgcAC21.HeaderText = "Kredīts";
            dgcAC21.MinimumWidth = 7;
            dgcAC21.Name = "dgcAC21";
            dgcAC21.ReadOnly = true;
            dgcAC21.Width = 63;
            // 
            // sgcSumm
            // 
            sgcSumm.DataPropertyName = "Summ";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            sgcSumm.DefaultCellStyle = dataGridViewCellStyle2;
            sgcSumm.HeaderText = "Summa";
            sgcSumm.MinimumWidth = 7;
            sgcSumm.Name = "sgcSumm";
            sgcSumm.ReadOnly = true;
            sgcSumm.Width = 78;
            // 
            // dgcAC12
            // 
            dgcAC12.DataPropertyName = "AC12";
            dgcAC12.HeaderText = "D2";
            dgcAC12.MinimumWidth = 7;
            dgcAC12.Name = "dgcAC12";
            dgcAC12.ReadOnly = true;
            dgcAC12.Width = 63;
            // 
            // dgcAC13
            // 
            dgcAC13.DataPropertyName = "AC13";
            dgcAC13.HeaderText = "D3";
            dgcAC13.MinimumWidth = 7;
            dgcAC13.Name = "dgcAC13";
            dgcAC13.ReadOnly = true;
            dgcAC13.Width = 39;
            // 
            // dgcAC14
            // 
            dgcAC14.DataPropertyName = "AC14";
            dgcAC14.HeaderText = "D4";
            dgcAC14.MinimumWidth = 7;
            dgcAC14.Name = "dgcAC14";
            dgcAC14.ReadOnly = true;
            dgcAC14.Width = 63;
            // 
            // dgcAC15
            // 
            dgcAC15.DataPropertyName = "AC15";
            dgcAC15.HeaderText = "D5";
            dgcAC15.MinimumWidth = 7;
            dgcAC15.Name = "dgcAC15";
            dgcAC15.ReadOnly = true;
            dgcAC15.Width = 47;
            // 
            // dgcAC22
            // 
            dgcAC22.DataPropertyName = "AC22";
            dgcAC22.HeaderText = "K2";
            dgcAC22.MinimumWidth = 7;
            dgcAC22.Name = "dgcAC22";
            dgcAC22.ReadOnly = true;
            dgcAC22.Width = 63;
            // 
            // dgcAC23
            // 
            dgcAC23.DataPropertyName = "AC23";
            dgcAC23.HeaderText = "K3";
            dgcAC23.MinimumWidth = 7;
            dgcAC23.Name = "dgcAC23";
            dgcAC23.ReadOnly = true;
            dgcAC23.Width = 39;
            // 
            // dgcAC24
            // 
            dgcAC24.DataPropertyName = "AC24";
            dgcAC24.HeaderText = "K4";
            dgcAC24.MinimumWidth = 7;
            dgcAC24.Name = "dgcAC24";
            dgcAC24.ReadOnly = true;
            dgcAC24.Width = 63;
            // 
            // dgcAC25
            // 
            dgcAC25.DataPropertyName = "AC25";
            dgcAC25.HeaderText = "K5";
            dgcAC25.MinimumWidth = 7;
            dgcAC25.Name = "dgcAC25";
            dgcAC25.ReadOnly = true;
            dgcAC25.Width = 47;
            // 
            // dgcQV
            // 
            dgcQV.DataPropertyName = "QV";
            dgcQV.HeaderText = "Daudzums";
            dgcQV.MinimumWidth = 7;
            dgcQV.Name = "dgcQV";
            dgcQV.ReadOnly = true;
            dgcQV.Width = 78;
            // 
            // dgcDescr2
            // 
            dgcDescr2.DataPropertyName = "Descr2";
            dgcDescr2.HeaderText = "Apraksts";
            dgcDescr2.MinimumWidth = 7;
            dgcDescr2.Name = "dgcDescr2";
            dgcDescr2.ReadOnly = true;
            dgcDescr2.Width = 126;
            // 
            // bs_vwOPS
            // 
            bs_vwOPS.AllowNew = false;
            bs_vwOPS.DataMember = "vw_OPS";
            bs_vwOPS.MyDataSource = "KlonsData";
            bs_vwOPS.Name2 = "vwOPS";
            // 
            // cbAC25
            // 
            cbAC25.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC25.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC25.ColumnWidths = "100;400";
            cbAC25.DisplayMember = "idx";
            cbAC25.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC25.DropDownHeight = 270;
            cbAC25.DropDownWidth = 519;
            cbAC25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC25.FormattingEnabled = true;
            cbAC25.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC25.GridLineHorizontal = false;
            cbAC25.GridLineVertical = true;
            cbAC25.IntegralHeight = false;
            cbAC25.Location = new System.Drawing.Point(351, 53);
            cbAC25.Margin = new System.Windows.Forms.Padding(2);
            cbAC25.MaxDropDownItems = 15;
            cbAC25.Name = "cbAC25";
            cbAC25.Size = new System.Drawing.Size(70, 24);
            cbAC25.TabIndex = 15;
            cbAC25.ValueMember = "idx";
            cbAC25.KeyDown += control_KeyDown;
            cbAC25.MouseDoubleClick += cbACp5_MouseDoubleClick;
            // 
            // cbAC24
            // 
            cbAC24.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC24.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC24.ColumnWidths = "100;400";
            cbAC24.DisplayMember = "idx";
            cbAC24.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC24.DropDownHeight = 270;
            cbAC24.DropDownWidth = 519;
            cbAC24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC24.FormattingEnabled = true;
            cbAC24.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC24.GridLineHorizontal = false;
            cbAC24.GridLineVertical = true;
            cbAC24.IntegralHeight = false;
            cbAC24.Location = new System.Drawing.Point(277, 53);
            cbAC24.Margin = new System.Windows.Forms.Padding(2);
            cbAC24.MaxDropDownItems = 15;
            cbAC24.Name = "cbAC24";
            cbAC24.Size = new System.Drawing.Size(70, 24);
            cbAC24.TabIndex = 14;
            cbAC24.ValueMember = "idx";
            cbAC24.KeyDown += control_KeyDown;
            cbAC24.MouseDoubleClick += cbACp4_MouseDoubleClick;
            // 
            // cbAC23
            // 
            cbAC23.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC23.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC23.ColumnWidths = "100;400";
            cbAC23.DisplayMember = "idx";
            cbAC23.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC23.DropDownHeight = 270;
            cbAC23.DropDownWidth = 519;
            cbAC23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC23.FormattingEnabled = true;
            cbAC23.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC23.GridLineHorizontal = false;
            cbAC23.GridLineVertical = true;
            cbAC23.IntegralHeight = false;
            cbAC23.Location = new System.Drawing.Point(203, 53);
            cbAC23.Margin = new System.Windows.Forms.Padding(2);
            cbAC23.MaxDropDownItems = 15;
            cbAC23.Name = "cbAC23";
            cbAC23.Size = new System.Drawing.Size(70, 24);
            cbAC23.TabIndex = 13;
            cbAC23.ValueMember = "idx";
            cbAC23.KeyDown += control_KeyDown;
            cbAC23.MouseDoubleClick += cbACp3_MouseDoubleClick;
            // 
            // cbAC22
            // 
            cbAC22.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC22.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC22.ColumnWidths = "100;400";
            cbAC22.DisplayMember = "AC";
            cbAC22.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC22.DropDownHeight = 270;
            cbAC22.DropDownWidth = 519;
            cbAC22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC22.FormattingEnabled = true;
            cbAC22.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC22.GridLineHorizontal = false;
            cbAC22.GridLineVertical = true;
            cbAC22.IntegralHeight = false;
            cbAC22.Location = new System.Drawing.Point(129, 53);
            cbAC22.Margin = new System.Windows.Forms.Padding(2);
            cbAC22.MaxDropDownItems = 15;
            cbAC22.Name = "cbAC22";
            cbAC22.Size = new System.Drawing.Size(70, 24);
            cbAC22.TabIndex = 12;
            cbAC22.KeyDown += control_KeyDown;
            cbAC22.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // cbAC21
            // 
            cbAC21.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC21.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC21.ColumnWidths = "100;400";
            cbAC21.DisplayMember = "AC";
            cbAC21.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC21.DropDownHeight = 270;
            cbAC21.DropDownWidth = 519;
            cbAC21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC21.FormattingEnabled = true;
            cbAC21.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC21.GridLineHorizontal = false;
            cbAC21.GridLineVertical = true;
            cbAC21.IntegralHeight = false;
            cbAC21.Location = new System.Drawing.Point(54, 53);
            cbAC21.Margin = new System.Windows.Forms.Padding(2);
            cbAC21.MaxDropDownItems = 15;
            cbAC21.Name = "cbAC21";
            cbAC21.Size = new System.Drawing.Size(70, 24);
            cbAC21.TabIndex = 11;
            cbAC21.KeyDown += control_KeyDown;
            cbAC21.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // cbAC15
            // 
            cbAC15.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC15.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC15.ColumnWidths = "100;400";
            cbAC15.DisplayMember = "idx";
            cbAC15.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC15.DropDownHeight = 270;
            cbAC15.DropDownWidth = 519;
            cbAC15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC15.FormattingEnabled = true;
            cbAC15.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC15.GridLineHorizontal = false;
            cbAC15.GridLineVertical = true;
            cbAC15.IntegralHeight = false;
            cbAC15.Location = new System.Drawing.Point(351, 28);
            cbAC15.Margin = new System.Windows.Forms.Padding(2);
            cbAC15.MaxDropDownItems = 15;
            cbAC15.Name = "cbAC15";
            cbAC15.Size = new System.Drawing.Size(70, 24);
            cbAC15.TabIndex = 9;
            cbAC15.ValueMember = "idx";
            cbAC15.KeyDown += control_KeyDown;
            cbAC15.MouseDoubleClick += cbACp5_MouseDoubleClick;
            // 
            // cbAC14
            // 
            cbAC14.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC14.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC14.ColumnWidths = "100;400";
            cbAC14.DisplayMember = "idx";
            cbAC14.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC14.DropDownHeight = 270;
            cbAC14.DropDownWidth = 519;
            cbAC14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC14.FormattingEnabled = true;
            cbAC14.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC14.GridLineHorizontal = false;
            cbAC14.GridLineVertical = true;
            cbAC14.IntegralHeight = false;
            cbAC14.Location = new System.Drawing.Point(277, 28);
            cbAC14.Margin = new System.Windows.Forms.Padding(2);
            cbAC14.MaxDropDownItems = 15;
            cbAC14.Name = "cbAC14";
            cbAC14.Size = new System.Drawing.Size(70, 24);
            cbAC14.TabIndex = 8;
            cbAC14.ValueMember = "idx";
            cbAC14.KeyDown += control_KeyDown;
            cbAC14.MouseDoubleClick += cbACp4_MouseDoubleClick;
            // 
            // cbAC13
            // 
            cbAC13.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC13.ColumnNames = new string[]
    {
    "idx",
    "name"
    };
            cbAC13.ColumnWidths = "100;400";
            cbAC13.DisplayMember = "idx";
            cbAC13.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC13.DropDownHeight = 270;
            cbAC13.DropDownWidth = 519;
            cbAC13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC13.FormattingEnabled = true;
            cbAC13.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC13.GridLineHorizontal = false;
            cbAC13.GridLineVertical = true;
            cbAC13.IntegralHeight = false;
            cbAC13.Location = new System.Drawing.Point(203, 28);
            cbAC13.Margin = new System.Windows.Forms.Padding(2);
            cbAC13.MaxDropDownItems = 15;
            cbAC13.Name = "cbAC13";
            cbAC13.Size = new System.Drawing.Size(70, 24);
            cbAC13.TabIndex = 7;
            cbAC13.ValueMember = "idx";
            cbAC13.KeyDown += control_KeyDown;
            cbAC13.MouseDoubleClick += cbACp3_MouseDoubleClick;
            // 
            // cbAC12
            // 
            cbAC12.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC12.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC12.ColumnWidths = "100;400";
            cbAC12.DisplayMember = "AC";
            cbAC12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC12.DropDownHeight = 270;
            cbAC12.DropDownWidth = 519;
            cbAC12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC12.FormattingEnabled = true;
            cbAC12.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC12.GridLineHorizontal = false;
            cbAC12.GridLineVertical = true;
            cbAC12.IntegralHeight = false;
            cbAC12.Location = new System.Drawing.Point(129, 28);
            cbAC12.Margin = new System.Windows.Forms.Padding(2);
            cbAC12.MaxDropDownItems = 15;
            cbAC12.Name = "cbAC12";
            cbAC12.Size = new System.Drawing.Size(70, 24);
            cbAC12.TabIndex = 6;
            cbAC12.KeyDown += control_KeyDown;
            cbAC12.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // cbAC11
            // 
            cbAC11.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAC11.ColumnNames = new string[]
    {
    "ac",
    "name"
    };
            cbAC11.ColumnWidths = "100;400";
            cbAC11.DisplayMember = "AC";
            cbAC11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAC11.DropDownHeight = 270;
            cbAC11.DropDownWidth = 519;
            cbAC11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAC11.FormattingEnabled = true;
            cbAC11.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbAC11.GridLineHorizontal = false;
            cbAC11.GridLineVertical = true;
            cbAC11.IntegralHeight = false;
            cbAC11.Location = new System.Drawing.Point(54, 28);
            cbAC11.Margin = new System.Windows.Forms.Padding(2);
            cbAC11.MaxDropDownItems = 15;
            cbAC11.Name = "cbAC11";
            cbAC11.Size = new System.Drawing.Size(70, 24);
            cbAC11.TabIndex = 5;
            cbAC11.KeyDown += control_KeyDown;
            cbAC11.MouseDoubleClick += cbAC_MouseDoubleClick;
            // 
            // tbText
            // 
            tbText.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbText.Location = new System.Drawing.Point(310, 3);
            tbText.Margin = new System.Windows.Forms.Padding(2);
            tbText.Name = "tbText";
            tbText.Size = new System.Drawing.Size(82, 23);
            tbText.TabIndex = 3;
            tbText.KeyDown += control_KeyDown;
            // 
            // cbClid
            // 
            cbClid.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbClid.ColumnNames = new string[]
    {
    "clid",
    "name"
    };
            cbClid.ColumnWidths = "120;400";
            cbClid.DisplayMember = "clid";
            cbClid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbClid.DropDownHeight = 270;
            cbClid.DropDownWidth = 539;
            cbClid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbClid.FormattingEnabled = true;
            cbClid.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbClid.GridLineHorizontal = false;
            cbClid.GridLineVertical = true;
            cbClid.IntegralHeight = false;
            cbClid.Location = new System.Drawing.Point(206, 3);
            cbClid.Margin = new System.Windows.Forms.Padding(2);
            cbClid.MaxDropDownItems = 15;
            cbClid.Name = "cbClid";
            cbClid.Size = new System.Drawing.Size(101, 24);
            cbClid.TabIndex = 2;
            cbClid.ValueMember = "clid";
            cbClid.KeyDown += control_KeyDown;
            cbClid.MouseDoubleClick += cbClid_MouseDoubleClick;
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.Location = new System.Drawing.Point(105, 3);
            tbDate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(79, 23);
            tbDate2.TabIndex = 1;
            tbDate2.Text = "01.01.2014";
            tbDate2.KeyDown += control_KeyDown;
            tbDate2.Leave += tbDate1_Leave;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.Location = new System.Drawing.Point(6, 3);
            tbDate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(79, 23);
            tbDate1.TabIndex = 0;
            tbDate1.Text = "01.01.2014";
            tbDate1.KeyDown += control_KeyDown;
            tbDate1.Leave += tbDate1_Leave;
            // 
            // tbSum
            // 
            tbSum.BackColor = System.Drawing.SystemColors.Control;
            tbSum.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSum.Location = new System.Drawing.Point(425, 54);
            tbSum.Margin = new System.Windows.Forms.Padding(2);
            tbSum.Name = "tbSum";
            tbSum.ReadOnly = true;
            tbSum.Size = new System.Drawing.Size(94, 23);
            tbSum.TabIndex = 17;
            tbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(425, 35);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 17);
            label2.TabIndex = 16;
            label2.Text = "Summa:";
            // 
            // cbDocGr
            // 
            cbDocGr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbDocGr.ColumnNames = new string[]
    {
    "id",
    "name"
    };
            cbDocGr.ColumnWidths = "100;400";
            cbDocGr.DisplayMember = "id";
            cbDocGr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbDocGr.DropDownHeight = 270;
            cbDocGr.DropDownWidth = 519;
            cbDocGr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbDocGr.FormattingEnabled = true;
            cbDocGr.GridLineColor = System.Drawing.SystemColors.WindowText;
            cbDocGr.GridLineHorizontal = false;
            cbDocGr.GridLineVertical = true;
            cbDocGr.IntegralHeight = false;
            cbDocGr.Location = new System.Drawing.Point(396, 3);
            cbDocGr.Margin = new System.Windows.Forms.Padding(2);
            cbDocGr.MaxDropDownItems = 15;
            cbDocGr.Name = "cbDocGr";
            cbDocGr.Size = new System.Drawing.Size(108, 24);
            cbDocGr.TabIndex = 4;
            cbDocGr.ValueMember = "id";
            cbDocGr.KeyDown += control_KeyDown;
            cbDocGr.MouseDoubleClick += cbACp5_MouseDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ierakstuŽurnālsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 409);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(825, 36);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // ierakstuŽurnālsToolStripMenuItem
            // 
            ierakstuŽurnālsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { rādītPilnuPersonasNosaukumuToolStripMenuItem, rādītPersonasReģistrācijasNumuruToolStripMenuItem, rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem });
            ierakstuŽurnālsToolStripMenuItem.Name = "ierakstuŽurnālsToolStripMenuItem";
            ierakstuŽurnālsToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            ierakstuŽurnālsToolStripMenuItem.Text = "Ierakstu žurnāls";
            // 
            // rādītPilnuPersonasNosaukumuToolStripMenuItem
            // 
            rādītPilnuPersonasNosaukumuToolStripMenuItem.Name = "rādītPilnuPersonasNosaukumuToolStripMenuItem";
            rādītPilnuPersonasNosaukumuToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            rādītPilnuPersonasNosaukumuToolStripMenuItem.Text = "Rādīt pilnu personas nosaukumu";
            rādītPilnuPersonasNosaukumuToolStripMenuItem.Click += rādītPilnuPersonasNosaukumuToolStripMenuItem_Click;
            // 
            // rādītPersonasReģistrācijasNumuruToolStripMenuItem
            // 
            rādītPersonasReģistrācijasNumuruToolStripMenuItem.Name = "rādītPersonasReģistrācijasNumuruToolStripMenuItem";
            rādītPersonasReģistrācijasNumuruToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            rādītPersonasReģistrācijasNumuruToolStripMenuItem.Text = "Rādīt personas reģistrācijas numuru";
            rādītPersonasReģistrācijasNumuruToolStripMenuItem.Click += rādītPersonasReģistrācijasNumuruToolStripMenuItem_Click;
            // 
            // rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem
            // 
            rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem.Name = "rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem";
            rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem.Text = "Rādīt personas PVN reģistrācijas numuru";
            rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem.Click += rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbAC21);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmAndOr);
            panel1.Controls.Add(cbClid);
            panel1.Controls.Add(cbAC25);
            panel1.Controls.Add(tbText);
            panel1.Controls.Add(cbAC24);
            panel1.Controls.Add(tbAmount);
            panel1.Controls.Add(tbSum);
            panel1.Controls.Add(cbAC23);
            panel1.Controls.Add(cbAC11);
            panel1.Controls.Add(cbAC22);
            panel1.Controls.Add(cbAC12);
            panel1.Controls.Add(cbAC13);
            panel1.Controls.Add(cbDocGr);
            panel1.Controls.Add(cbAC14);
            panel1.Controls.Add(cbAC15);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(825, 80);
            panel1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(522, 36);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 17);
            label3.TabIndex = 16;
            label3.Text = "Daudzums";
            // 
            // tbAmount
            // 
            tbAmount.BackColor = System.Drawing.SystemColors.Control;
            tbAmount.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbAmount.Location = new System.Drawing.Point(523, 55);
            tbAmount.Margin = new System.Windows.Forms.Padding(2);
            tbAmount.Name = "tbAmount";
            tbAmount.ReadOnly = true;
            tbAmount.Size = new System.Drawing.Size(94, 23);
            tbAmount.TabIndex = 17;
            tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_OpsFilter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(825, 444);
            Controls.Add(dgvOPS);
            Controls.Add(panel1);
            Controls.Add(myToolStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MyToolStrip = myToolStrip;
            Name = "Form_OpsFilter";
            Text = "Ierakstu žurnāls";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Form_OpsFilter_FormClosing;
            FormClosed += FormOpsFilter_FormClosed;
            Load += FormOpsFilter_Load;
            myToolStrip.ResumeLayout(false);
            myToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)bs_vwOPS).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyTextBox tbDate1;
        private MyTextBox tbDate2;
        private System.Windows.Forms.Label label1;
        private MyMcFlatComboBox cbClid;
        private MyTextBox tbText;
        private MyMcFlatComboBox cbAC11;
        private MyMcFlatComboBox cbAC21;
        private MyMcFlatComboBox cbAC12;
        private MyMcFlatComboBox cbAC22;
        private MyMcFlatComboBox cbAC13;
        private MyMcFlatComboBox cbAC23;
        private MyMcFlatComboBox cbAC14;
        private MyMcFlatComboBox cbAC24;
        private MyMcFlatComboBox cbAC15;
        private MyMcFlatComboBox cbAC25;
        private MyDataGridView dgvOPS;
        private MyBindingSource bs_vwOPS;
        private System.Windows.Forms.ToolStripButton tsbFilter;
        private System.Windows.Forms.ToolStripButton tsbFilterDocs;
        private System.Windows.Forms.Button cmAndOr;
        public System.Windows.Forms.ToolStrip myToolStrip;
        private MyTextBox tbSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbDocs;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem dokumentuSarakstsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbFindInDocs;
        private System.Windows.Forms.ToolStripMenuItem ierakstuIzrakstsToolStripMenuItem;
        private MyMcFlatComboBox cbDocGr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ierakstuŽurnālsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rādītPilnuPersonasNosaukumuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem rādītPersonasReģistrācijasNumuruToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcZNR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocSt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcClid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPVNRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC21;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgcSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAC25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcQV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr2;
        private System.Windows.Forms.ToolStripMenuItem rādītPersonasPVNReģistrācijasNumuruToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private MyTextBox tbAmount;
    }
}