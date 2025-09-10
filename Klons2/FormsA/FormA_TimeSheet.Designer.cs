using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_TimeSheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_TimeSheet));
            dgvLapa = new MyDataGridView();
            dgcIDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSNRX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcKind1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcV31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcKind2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsLapa2 = new KlonsLIB.Data.MyBindingSource2(components);
            dlJoinView1 = new Classes.DLJoinView(components);
            bsLapa = new KlonsLIB.Data.MyBindingSource(components);
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tslPeriod = new System.Windows.Forms.ToolStripLabel();
            bsLapuSar = new KlonsLIB.Data.MyBindingSource(components);
            cbLapuSar = new MyMcFlatComboBox();
            toolStrip2 = new System.Windows.Forms.ToolStrip();
            tsbNew = new System.Windows.Forms.ToolStripButton();
            tsbEdit = new System.Windows.Forms.ToolStripButton();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            myStyleDefs1 = new Classes.MyStyleDefs();
            cmsMenuMarkDayFact = new System.Windows.Forms.ContextMenuStrip(components);
            miFactD = new System.Windows.Forms.ToolStripMenuItem();
            miFactB = new System.Windows.Forms.ToolStripMenuItem();
            miFactK = new System.Windows.Forms.ToolStripMenuItem();
            miFactSVVI = new System.Windows.Forms.ToolStripMenuItem();
            miFactVI = new System.Windows.Forms.ToolStripMenuItem();
            miFactN = new System.Windows.Forms.ToolStripMenuItem();
            miFactDS = new System.Windows.Forms.ToolStripMenuItem();
            miFactKS = new System.Windows.Forms.ToolStripMenuItem();
            cmsMenuMarkDayPlan = new System.Windows.Forms.ContextMenuStrip(components);
            miPlanDD = new System.Windows.Forms.ToolStripMenuItem();
            miPlanBD = new System.Windows.Forms.ToolStripMenuItem();
            miPlanSD = new System.Windows.Forms.ToolStripMenuItem();
            miPlanSDDD = new System.Windows.Forms.ToolStripMenuItem();
            miPlanDDSD = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            darbaLaikaUzskaitesLapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            sarakstsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSheetCheckEvents = new System.Windows.Forms.ToolStripMenuItem();
            tsmiSheetFillFact = new System.Windows.Forms.ToolStripMenuItem();
            darbinieksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPersonCheckEvents = new System.Windows.Forms.ToolStripMenuItem();
            tsmiPersonFillFact = new System.Windows.Forms.ToolStripMenuItem();
            izdrukaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            darbaLaikaLapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            darbaLaikaLapaArKrāsāmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            darbaLaikaKopsummasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            myStyleDefsForReport = new Classes.MyStyleDefs();
            ((System.ComponentModel.ISupportInitialize)dgvLapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLapa2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsLapa).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsLapuSar).BeginInit();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            cmsMenuMarkDayFact.SuspendLayout();
            cmsMenuMarkDayPlan.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLapa
            // 
            dgvLapa.AllowUserToAddRows = false;
            dgvLapa.AllowUserToDeleteRows = false;
            dgvLapa.AllowUserToResizeRows = false;
            dgvLapa.AutoGenerateColumns = false;
            dgvLapa.AutoSave = false;
            dgvLapa.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvLapa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLapa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcIDX, dgcID, dgcSNRX, dgcTitle, dgcPosition, dgcKind1, dgcK1, dgcV1, dgcV2, dgcV3, dgcV4, dgcV5, dgcV6, dgcV7, dgcV8, dgcV9, dgcV10, dgcV11, dgcV12, dgcV13, dgcV14, dgcV15, dgcV16, dgcV17, dgcV18, dgcV19, dgcV20, dgcV21, dgcV22, dgcV23, dgcV24, dgcV25, dgcV26, dgcV27, dgcV28, dgcV29, dgcV30, dgcV31, dgcIDL, dgcKind2 });
            dgvLapa.DataSource = bsLapa2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvLapa.DefaultCellStyle = dataGridViewCellStyle4;
            dgvLapa.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLapa.Location = new System.Drawing.Point(0, 25);
            dgvLapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvLapa.Name = "dgvLapa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 186);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvLapa.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvLapa.RowHeadersWidth = 62;
            dgvLapa.ShowCellToolTips = false;
            dgvLapa.Size = new System.Drawing.Size(766, 386);
            dgvLapa.TabIndex = 0;
            dgvLapa.UseMyContextmenu = false;
            dgvLapa.MyCheckForChanges += dgvLapa_MyCheckForChanges;
            dgvLapa.CellBeginEdit += dgvLapa_CellBeginEdit;
            dgvLapa.CellContextMenuStripNeeded += dgvLapa_CellContextMenuStripNeeded;
            dgvLapa.CellEndEdit += dgvLapa_CellEndEdit;
            dgvLapa.CellFormatting += dgvLapa_CellFormatting;
            dgvLapa.CellPainting += dataGridView_CellPainting;
            dgvLapa.CellParsing += dgvLapa_CellParsing;
            dgvLapa.EditingControlShowing += dgvLapa_EditingControlShowing;
            dgvLapa.KeyDown += dgvLapa_KeyDown;
            // 
            // dgcIDX
            // 
            dgcIDX.DataPropertyName = "IDX";
            dgcIDX.Frozen = true;
            dgcIDX.HeaderText = "IDX";
            dgcIDX.MinimumWidth = 7;
            dgcIDX.Name = "dgcIDX";
            dgcIDX.ReadOnly = true;
            dgcIDX.Visible = false;
            dgcIDX.Width = 56;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.Frozen = true;
            dgcID.HeaderText = "ID";
            dgcID.MinimumWidth = 7;
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            dgcID.Width = 45;
            // 
            // dgcSNRX
            // 
            dgcSNRX.DataPropertyName = "SNRX";
            dgcSNRX.Frozen = true;
            dgcSNRX.HeaderText = "npk";
            dgcSNRX.MinimumWidth = 7;
            dgcSNRX.Name = "dgcSNRX";
            dgcSNRX.ReadOnly = true;
            dgcSNRX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcSNRX.Width = 36;
            // 
            // dgcTitle
            // 
            dgcTitle.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgcTitle.DefaultCellStyle = dataGridViewCellStyle2;
            dgcTitle.Frozen = true;
            dgcTitle.HeaderText = "darbinieks";
            dgcTitle.MinimumWidth = 7;
            dgcTitle.Name = "dgcTitle";
            dgcTitle.ReadOnly = true;
            dgcTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcTitle.Width = 202;
            // 
            // dgcPosition
            // 
            dgcPosition.DataPropertyName = "Position";
            dgcPosition.Frozen = true;
            dgcPosition.HeaderText = "Amats";
            dgcPosition.MinimumWidth = 7;
            dgcPosition.Name = "dgcPosition";
            dgcPosition.ReadOnly = true;
            dgcPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcPosition.Visible = false;
            dgcPosition.Width = 146;
            // 
            // dgcKind1
            // 
            dgcKind1.DataPropertyName = "KIND1";
            dgcKind1.Frozen = true;
            dgcKind1.HeaderText = "tips";
            dgcKind1.MinimumWidth = 7;
            dgcKind1.Name = "dgcKind1";
            dgcKind1.ReadOnly = true;
            dgcKind1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcKind1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcKind1.Width = 67;
            // 
            // dgcK1
            // 
            dgcK1.DataPropertyName = "K1";
            dgcK1.Frozen = true;
            dgcK1.HeaderText = "Σ";
            dgcK1.MinimumWidth = 7;
            dgcK1.Name = "dgcK1";
            dgcK1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcK1.Width = 36;
            // 
            // dgcV1
            // 
            dgcV1.DataPropertyName = "V1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcV1.DefaultCellStyle = dataGridViewCellStyle3;
            dgcV1.HeaderText = "1";
            dgcV1.MinimumWidth = 7;
            dgcV1.Name = "dgcV1";
            dgcV1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV1.Width = 31;
            // 
            // dgcV2
            // 
            dgcV2.DataPropertyName = "V2";
            dgcV2.HeaderText = "2";
            dgcV2.MinimumWidth = 7;
            dgcV2.Name = "dgcV2";
            dgcV2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV2.Width = 31;
            // 
            // dgcV3
            // 
            dgcV3.DataPropertyName = "V3";
            dgcV3.HeaderText = "3";
            dgcV3.MinimumWidth = 7;
            dgcV3.Name = "dgcV3";
            dgcV3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV3.Width = 31;
            // 
            // dgcV4
            // 
            dgcV4.DataPropertyName = "V4";
            dgcV4.HeaderText = "4";
            dgcV4.MinimumWidth = 7;
            dgcV4.Name = "dgcV4";
            dgcV4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV4.Width = 31;
            // 
            // dgcV5
            // 
            dgcV5.DataPropertyName = "V5";
            dgcV5.HeaderText = "5";
            dgcV5.MinimumWidth = 7;
            dgcV5.Name = "dgcV5";
            dgcV5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV5.Width = 31;
            // 
            // dgcV6
            // 
            dgcV6.DataPropertyName = "V6";
            dgcV6.HeaderText = "6";
            dgcV6.MinimumWidth = 7;
            dgcV6.Name = "dgcV6";
            dgcV6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV6.Width = 31;
            // 
            // dgcV7
            // 
            dgcV7.DataPropertyName = "V7";
            dgcV7.HeaderText = "7";
            dgcV7.MinimumWidth = 7;
            dgcV7.Name = "dgcV7";
            dgcV7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV7.Width = 31;
            // 
            // dgcV8
            // 
            dgcV8.DataPropertyName = "V8";
            dgcV8.HeaderText = "8";
            dgcV8.MinimumWidth = 7;
            dgcV8.Name = "dgcV8";
            dgcV8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV8.Width = 31;
            // 
            // dgcV9
            // 
            dgcV9.DataPropertyName = "V9";
            dgcV9.HeaderText = "9";
            dgcV9.MinimumWidth = 7;
            dgcV9.Name = "dgcV9";
            dgcV9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV9.Width = 31;
            // 
            // dgcV10
            // 
            dgcV10.DataPropertyName = "V10";
            dgcV10.HeaderText = "10";
            dgcV10.MinimumWidth = 7;
            dgcV10.Name = "dgcV10";
            dgcV10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV10.Width = 31;
            // 
            // dgcV11
            // 
            dgcV11.DataPropertyName = "V11";
            dgcV11.HeaderText = "11";
            dgcV11.MinimumWidth = 7;
            dgcV11.Name = "dgcV11";
            dgcV11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV11.Width = 31;
            // 
            // dgcV12
            // 
            dgcV12.DataPropertyName = "V12";
            dgcV12.HeaderText = "12";
            dgcV12.MinimumWidth = 7;
            dgcV12.Name = "dgcV12";
            dgcV12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV12.Width = 31;
            // 
            // dgcV13
            // 
            dgcV13.DataPropertyName = "V13";
            dgcV13.HeaderText = "13";
            dgcV13.MinimumWidth = 7;
            dgcV13.Name = "dgcV13";
            dgcV13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV13.Width = 31;
            // 
            // dgcV14
            // 
            dgcV14.DataPropertyName = "V14";
            dgcV14.HeaderText = "14";
            dgcV14.MinimumWidth = 7;
            dgcV14.Name = "dgcV14";
            dgcV14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV14.Width = 31;
            // 
            // dgcV15
            // 
            dgcV15.DataPropertyName = "V15";
            dgcV15.HeaderText = "15";
            dgcV15.MinimumWidth = 7;
            dgcV15.Name = "dgcV15";
            dgcV15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV15.Width = 31;
            // 
            // dgcV16
            // 
            dgcV16.DataPropertyName = "V16";
            dgcV16.HeaderText = "16";
            dgcV16.MinimumWidth = 7;
            dgcV16.Name = "dgcV16";
            dgcV16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV16.Width = 31;
            // 
            // dgcV17
            // 
            dgcV17.DataPropertyName = "V17";
            dgcV17.HeaderText = "17";
            dgcV17.MinimumWidth = 7;
            dgcV17.Name = "dgcV17";
            dgcV17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV17.Width = 31;
            // 
            // dgcV18
            // 
            dgcV18.DataPropertyName = "V18";
            dgcV18.HeaderText = "18";
            dgcV18.MinimumWidth = 7;
            dgcV18.Name = "dgcV18";
            dgcV18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV18.Width = 31;
            // 
            // dgcV19
            // 
            dgcV19.DataPropertyName = "V19";
            dgcV19.HeaderText = "19";
            dgcV19.MinimumWidth = 7;
            dgcV19.Name = "dgcV19";
            dgcV19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV19.Width = 31;
            // 
            // dgcV20
            // 
            dgcV20.DataPropertyName = "V20";
            dgcV20.HeaderText = "20";
            dgcV20.MinimumWidth = 7;
            dgcV20.Name = "dgcV20";
            dgcV20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV20.Width = 31;
            // 
            // dgcV21
            // 
            dgcV21.DataPropertyName = "V21";
            dgcV21.HeaderText = "21";
            dgcV21.MinimumWidth = 7;
            dgcV21.Name = "dgcV21";
            dgcV21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV21.Width = 31;
            // 
            // dgcV22
            // 
            dgcV22.DataPropertyName = "V22";
            dgcV22.HeaderText = "22";
            dgcV22.MinimumWidth = 7;
            dgcV22.Name = "dgcV22";
            dgcV22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV22.Width = 31;
            // 
            // dgcV23
            // 
            dgcV23.DataPropertyName = "V23";
            dgcV23.HeaderText = "23";
            dgcV23.MinimumWidth = 7;
            dgcV23.Name = "dgcV23";
            dgcV23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV23.Width = 31;
            // 
            // dgcV24
            // 
            dgcV24.DataPropertyName = "V24";
            dgcV24.HeaderText = "24";
            dgcV24.MinimumWidth = 7;
            dgcV24.Name = "dgcV24";
            dgcV24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV24.Width = 31;
            // 
            // dgcV25
            // 
            dgcV25.DataPropertyName = "V25";
            dgcV25.HeaderText = "25";
            dgcV25.MinimumWidth = 7;
            dgcV25.Name = "dgcV25";
            dgcV25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV25.Width = 31;
            // 
            // dgcV26
            // 
            dgcV26.DataPropertyName = "V26";
            dgcV26.HeaderText = "26";
            dgcV26.MinimumWidth = 7;
            dgcV26.Name = "dgcV26";
            dgcV26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV26.Width = 31;
            // 
            // dgcV27
            // 
            dgcV27.DataPropertyName = "V27";
            dgcV27.HeaderText = "27";
            dgcV27.MinimumWidth = 7;
            dgcV27.Name = "dgcV27";
            dgcV27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV27.Width = 31;
            // 
            // dgcV28
            // 
            dgcV28.DataPropertyName = "V28";
            dgcV28.HeaderText = "28";
            dgcV28.MinimumWidth = 7;
            dgcV28.Name = "dgcV28";
            dgcV28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV28.Width = 31;
            // 
            // dgcV29
            // 
            dgcV29.DataPropertyName = "V29";
            dgcV29.HeaderText = "29";
            dgcV29.MinimumWidth = 7;
            dgcV29.Name = "dgcV29";
            dgcV29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV29.Width = 31;
            // 
            // dgcV30
            // 
            dgcV30.DataPropertyName = "V30";
            dgcV30.HeaderText = "30";
            dgcV30.MinimumWidth = 7;
            dgcV30.Name = "dgcV30";
            dgcV30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV30.Width = 31;
            // 
            // dgcV31
            // 
            dgcV31.DataPropertyName = "V31";
            dgcV31.HeaderText = "31";
            dgcV31.MinimumWidth = 7;
            dgcV31.Name = "dgcV31";
            dgcV31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcV31.Width = 31;
            // 
            // dgcIDL
            // 
            dgcIDL.DataPropertyName = "IDL";
            dgcIDL.HeaderText = "IDL";
            dgcIDL.MinimumWidth = 7;
            dgcIDL.Name = "dgcIDL";
            dgcIDL.Visible = false;
            dgcIDL.Width = 45;
            // 
            // dgcKind2
            // 
            dgcKind2.DataPropertyName = "KIND2";
            dgcKind2.HeaderText = "KIND2";
            dgcKind2.MinimumWidth = 7;
            dgcKind2.Name = "dgcKind2";
            dgcKind2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcKind2.Visible = false;
            dgcKind2.Width = 45;
            // 
            // bsLapa2
            // 
            bsLapa2.DataSource = dlJoinView1;
            // 
            // dlJoinView1
            // 
            dlJoinView1.AllowDelete = true;
            dlJoinView1.AllowEdit = true;
            dlJoinView1.AllowNew = false;
            dlJoinView1.AllowSort = true;
            dlJoinView1.FieldList = "!.*,*";
            dlJoinView1.Name = "dlJoinView1";
            dlJoinView1.Sort = "SNRX,IDX,KIND1";
            // 
            // bsLapa
            // 
            bsLapa.AutoSaveOnDelete = true;
            bsLapa.DataMember = "TIMESHEET";
            bsLapa.MyDataSource = "KlonsAData";
            bsLapa.UseDataGridView = dgvLapa;
            bsLapa.ListChanged += bsLapa_ListChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslPeriod });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(766, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslPeriod
            // 
            tslPeriod.Name = "tslPeriod";
            tslPeriod.Size = new System.Drawing.Size(60, 22);
            tslPeriod.Text = "Periods:";
            // 
            // bsLapuSar
            // 
            bsLapuSar.DataMember = "TIMESHEET_LISTS";
            bsLapuSar.Filter = "ISFIRSTMT = FALSE";
            bsLapuSar.MyDataSource = "KlonsAData";
            bsLapuSar.Sort = "yr desc, mt desc,snr desc";
            bsLapuSar.CurrentChanged += bsLapuSar_CurrentChanged;
            // 
            // cbLapuSar
            // 
            cbLapuSar._AllowSelection = true;
            cbLapuSar.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbLapuSar.ColumnNames = new string[]
    {
    "ID"
    };
            cbLapuSar.ColumnWidths = "280";
            cbLapuSar.DataSource = bsLapuSar;
            cbLapuSar.DisplayMember = "ID";
            cbLapuSar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbLapuSar.DropDownHeight = 270;
            cbLapuSar.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbLapuSar.DropDownWidth = 299;
            cbLapuSar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbLapuSar.FormattingEnabled = true;
            cbLapuSar.GridLineColor = System.Drawing.Color.LightGray;
            cbLapuSar.GridLineHorizontal = false;
            cbLapuSar.GridLineVertical = false;
            cbLapuSar.IntegralHeight = false;
            cbLapuSar.Location = new System.Drawing.Point(254, 3);
            cbLapuSar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbLapuSar.MaxDropDownItems = 15;
            cbLapuSar.Name = "cbLapuSar";
            cbLapuSar.Size = new System.Drawing.Size(314, 24);
            cbLapuSar.TabIndex = 7;
            cbLapuSar.ValueMember = "ID";
            cbLapuSar.Format += cbLapuSar_Format;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip2.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbNew, tsbEdit, tsbDelete, tsbSave });
            toolStrip2.Location = new System.Drawing.Point(0, 411);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new System.Drawing.Size(766, 33);
            toolStrip2.TabIndex = 8;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbNew
            // 
            tsbNew.Image = (System.Drawing.Image)resources.GetObject("tsbNew.Image");
            tsbNew.Name = "tsbNew";
            tsbNew.RightToLeftAutoMirrorImage = true;
            tsbNew.Size = new System.Drawing.Size(73, 30);
            tsbNew.Text = "Jauns";
            tsbNew.Click += tsbNew_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (System.Drawing.Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new System.Drawing.Size(72, 30);
            tsbEdit.Text = "Mainīt";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (System.Drawing.Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.Name = "tsbDelete";
            tsbDelete.RightToLeftAutoMirrorImage = true;
            tsbDelete.Size = new System.Drawing.Size(71, 30);
            tsbDelete.Text = "Dzēst";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(27, 30);
            tsbSave.Text = "toolStripButton1";
            tsbSave.Click += tsbSave_Click;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "TIMESHEET",
    "TIMESHEET_LISTS",
    "TIMESHEET_LISTS_R",
    null
    };
            // 
            // myStyleDefs1
            // 
            myStyleDefs1.FreeDayBack = System.Drawing.Color.FromArgb(56, 116, 197);
            myStyleDefs1.FreeDayFore = System.Drawing.Color.White;
            myStyleDefs1.HeaderHolyDayBack = System.Drawing.Color.FromArgb(181, 113, 0);
            myStyleDefs1.HeaderHolyDayFore = System.Drawing.Color.White;
            myStyleDefs1.HeaderWeekEndBack = System.Drawing.Color.FromArgb(2, 62, 106);
            myStyleDefs1.HeaderWeekEndFore = System.Drawing.Color.White;
            myStyleDefs1.HolyDayBack = System.Drawing.Color.FromArgb(220, 140, 0);
            myStyleDefs1.HolyDayFore = System.Drawing.Color.White;
            myStyleDefs1.SickDayBack = System.Drawing.Color.IndianRed;
            myStyleDefs1.SickDayFore = System.Drawing.Color.White;
            myStyleDefs1.VacationBack = System.Drawing.Color.YellowGreen;
            myStyleDefs1.VacationFore = System.Drawing.Color.White;
            // 
            // cmsMenuMarkDayFact
            // 
            cmsMenuMarkDayFact.ImageScalingSize = new System.Drawing.Size(16, 16);
            cmsMenuMarkDayFact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miFactD, miFactB, miFactK, miFactSVVI, miFactVI, miFactN, miFactDS, miFactKS });
            cmsMenuMarkDayFact.Name = "cmsMenuMarkDay";
            cmsMenuMarkDayFact.Size = new System.Drawing.Size(354, 196);
            cmsMenuMarkDayFact.ItemClicked += cmsMenuMarkDayFact_ItemClicked;
            // 
            // miFactD
            // 
            miFactD.Name = "miFactD";
            miFactD.Size = new System.Drawing.Size(353, 24);
            miFactD.Text = "Darba diena";
            // 
            // miFactB
            // 
            miFactB.Name = "miFactB";
            miFactB.Size = new System.Drawing.Size(353, 24);
            miFactB.Text = "B - Brīvdiena";
            // 
            // miFactK
            // 
            miFactK.Name = "miFactK";
            miFactK.Size = new System.Drawing.Size(353, 24);
            miFactK.Text = "K - Komandējums";
            // 
            // miFactSVVI
            // 
            miFactSVVI.Name = "miFactSVVI";
            miFactSVVI.Size = new System.Drawing.Size(353, 24);
            miFactSVVI.Text = "S - Svētku diena ar vidējo izpeļņu";
            // 
            // miFactVI
            // 
            miFactVI.Name = "miFactVI";
            miFactVI.Size = new System.Drawing.Size(353, 24);
            miFactVI.Text = "V - Vidējās izpeļņas diena";
            // 
            // miFactN
            // 
            miFactN.Name = "miFactN";
            miFactN.Size = new System.Drawing.Size(353, 24);
            miFactN.Text = "N - Neattaisnots kavējums";
            // 
            // miFactDS
            // 
            miFactDS.Name = "miFactDS";
            miFactDS.Size = new System.Drawing.Size(353, 24);
            miFactDS.Text = "DS - Darba diena svētku dienā ar piemaksu";
            // 
            // miFactKS
            // 
            miFactKS.Name = "miFactKS";
            miFactKS.Size = new System.Drawing.Size(353, 24);
            miFactKS.Text = "KS - Komandējums svētku dienā ar piemaksu";
            // 
            // cmsMenuMarkDayPlan
            // 
            cmsMenuMarkDayPlan.ImageScalingSize = new System.Drawing.Size(16, 16);
            cmsMenuMarkDayPlan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { miPlanDD, miPlanBD, miPlanSD, miPlanSDDD, miPlanDDSD });
            cmsMenuMarkDayPlan.Name = "cmsMenuMarkDayPlan";
            cmsMenuMarkDayPlan.Size = new System.Drawing.Size(265, 124);
            cmsMenuMarkDayPlan.ItemClicked += cmsMenuMarkDayPlan_ItemClicked;
            // 
            // miPlanDD
            // 
            miPlanDD.Name = "miPlanDD";
            miPlanDD.Size = new System.Drawing.Size(264, 24);
            miPlanDD.Text = "Darba diena";
            // 
            // miPlanBD
            // 
            miPlanBD.Name = "miPlanBD";
            miPlanBD.Size = new System.Drawing.Size(264, 24);
            miPlanBD.Text = "B - Brīvdiena";
            // 
            // miPlanSD
            // 
            miPlanSD.Name = "miPlanSD";
            miPlanSD.Size = new System.Drawing.Size(264, 24);
            miPlanSD.Text = "S - Svētku diena";
            // 
            // miPlanSDDD
            // 
            miPlanSDDD.Name = "miPlanSDDD";
            miPlanSDDD.Size = new System.Drawing.Size(264, 24);
            miPlanSDDD.Text = "SD - Svētku diena darba dienā";
            // 
            // miPlanDDSD
            // 
            miPlanDDSD.Name = "miPlanDDSD";
            miPlanDDSD.Size = new System.Drawing.Size(264, 24);
            miPlanDDSD.Text = "DS - Darba diena svētku dienā";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { darbaLaikaUzskaitesLapaToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(766, 38);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // darbaLaikaUzskaitesLapaToolStripMenuItem
            // 
            darbaLaikaUzskaitesLapaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator1, sarakstsToolStripMenuItem, darbinieksToolStripMenuItem, izdrukaiToolStripMenuItem });
            darbaLaikaUzskaitesLapaToolStripMenuItem.MergeIndex = 2;
            darbaLaikaUzskaitesLapaToolStripMenuItem.Name = "darbaLaikaUzskaitesLapaToolStripMenuItem";
            darbaLaikaUzskaitesLapaToolStripMenuItem.Size = new System.Drawing.Size(186, 34);
            darbaLaikaUzskaitesLapaToolStripMenuItem.Text = "Darba laika uzskaites lapa";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // sarakstsToolStripMenuItem
            // 
            sarakstsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiSheetCheckEvents, tsmiSheetFillFact });
            sarakstsToolStripMenuItem.Name = "sarakstsToolStripMenuItem";
            sarakstsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            sarakstsToolStripMenuItem.Text = "Saraksts";
            // 
            // tsmiSheetCheckEvents
            // 
            tsmiSheetCheckEvents.Name = "tsmiSheetCheckEvents";
            tsmiSheetCheckEvents.Size = new System.Drawing.Size(316, 22);
            tsmiSheetCheckEvents.Text = "Pārbaudīt notikumus";
            tsmiSheetCheckEvents.Click += tsmiSheetCheckEvents_Click;
            // 
            // tsmiSheetFillFact
            // 
            tsmiSheetFillFact.Name = "tsmiSheetFillFact";
            tsmiSheetFillFact.Size = new System.Drawing.Size(316, 22);
            tsmiSheetFillFact.Text = "Aizpildīt nostrādātās stundas no plāna";
            tsmiSheetFillFact.Click += tsmiSheetFillFact_Click;
            // 
            // darbinieksToolStripMenuItem
            // 
            darbinieksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmiPersonCheckEvents, tsmiPersonFillFact });
            darbinieksToolStripMenuItem.Name = "darbinieksToolStripMenuItem";
            darbinieksToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            darbinieksToolStripMenuItem.Text = "Darbinieks";
            // 
            // tsmiPersonCheckEvents
            // 
            tsmiPersonCheckEvents.Name = "tsmiPersonCheckEvents";
            tsmiPersonCheckEvents.Size = new System.Drawing.Size(257, 22);
            tsmiPersonCheckEvents.Text = "Pārbaudīt notikumus";
            tsmiPersonCheckEvents.Click += tsmiPersonCheckEvents_Click;
            // 
            // tsmiPersonFillFact
            // 
            tsmiPersonFillFact.Name = "tsmiPersonFillFact";
            tsmiPersonFillFact.Size = new System.Drawing.Size(257, 22);
            tsmiPersonFillFact.Text = "Aizpildīt nostrādātās stundas";
            tsmiPersonFillFact.Click += tsmiPersonFillFact_Click;
            // 
            // izdrukaiToolStripMenuItem
            // 
            izdrukaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { darbaLaikaLapaToolStripMenuItem, darbaLaikaLapaArKrāsāmToolStripMenuItem, darbaLaikaKopsummasToolStripMenuItem });
            izdrukaiToolStripMenuItem.Name = "izdrukaiToolStripMenuItem";
            izdrukaiToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            izdrukaiToolStripMenuItem.Text = "Izdrukai";
            // 
            // darbaLaikaLapaToolStripMenuItem
            // 
            darbaLaikaLapaToolStripMenuItem.Name = "darbaLaikaLapaToolStripMenuItem";
            darbaLaikaLapaToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            darbaLaikaLapaToolStripMenuItem.Text = "Darba laika lapa";
            darbaLaikaLapaToolStripMenuItem.Click += darbaLaikaLapaToolStripMenuItem_Click;
            // 
            // darbaLaikaLapaArKrāsāmToolStripMenuItem
            // 
            darbaLaikaLapaArKrāsāmToolStripMenuItem.Name = "darbaLaikaLapaArKrāsāmToolStripMenuItem";
            darbaLaikaLapaArKrāsāmToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            darbaLaikaLapaArKrāsāmToolStripMenuItem.Text = "Darba laika lapa - ar krāsām";
            darbaLaikaLapaArKrāsāmToolStripMenuItem.Click += DarbaLaikaLapaArKrāsāmToolStripMenuItem_Click;
            // 
            // darbaLaikaKopsummasToolStripMenuItem
            // 
            darbaLaikaKopsummasToolStripMenuItem.Name = "darbaLaikaKopsummasToolStripMenuItem";
            darbaLaikaKopsummasToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            darbaLaikaKopsummasToolStripMenuItem.Text = "Darba laika kopsummas";
            darbaLaikaKopsummasToolStripMenuItem.Click += darbaLaikaKopsummasToolStripMenuItem_Click;
            // 
            // myStyleDefsForReport
            // 
            myStyleDefsForReport.FreeDayBack = System.Drawing.Color.FromArgb(225, 239, 255);
            myStyleDefsForReport.FreeDayFore = System.Drawing.Color.White;
            myStyleDefsForReport.HeaderHolyDayBack = System.Drawing.Color.FromArgb(255, 234, 208);
            myStyleDefsForReport.HeaderHolyDayFore = System.Drawing.Color.White;
            myStyleDefsForReport.HeaderWeekEndBack = System.Drawing.Color.FromArgb(210, 232, 255);
            myStyleDefsForReport.HeaderWeekEndFore = System.Drawing.Color.White;
            myStyleDefsForReport.HolyDayBack = System.Drawing.Color.FromArgb(255, 242, 227);
            myStyleDefsForReport.HolyDayFore = System.Drawing.Color.White;
            myStyleDefsForReport.SickDayBack = System.Drawing.Color.FromArgb(255, 236, 236);
            myStyleDefsForReport.SickDayFore = System.Drawing.Color.White;
            myStyleDefsForReport.VacationBack = System.Drawing.Color.FromArgb(221, 248, 220);
            myStyleDefsForReport.VacationFore = System.Drawing.Color.White;
            // 
            // FormA_TimeSheet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(766, 444);
            Controls.Add(cbLapuSar);
            Controls.Add(dgvLapa);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MyToolStrip = toolStrip1;
            Name = "FormA_TimeSheet";
            Text = "Darba laika uzskaites lapa";
            FormClosed += Form_TimeSheet_FormClosed;
            Load += Form_TimeSheet_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLapa2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsLapa).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsLapuSar).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            cmsMenuMarkDayFact.ResumeLayout(false);
            cmsMenuMarkDayPlan.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyDataGridView dgvLapa;
        private KlonsLIB.Data.MyBindingSource bsLapa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private KlonsA.Classes.DLJoinView dlJoinView1;
        private KlonsLIB.Data.MyBindingSource2 bsLapa2;
        private System.Windows.Forms.ToolStripLabel tslPeriod;
        private KlonsLIB.Data.MyBindingSource bsLapuSar;
        private MyMcFlatComboBox cbLapuSar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsA.Classes.MyStyleDefs myStyleDefs1;
        private System.Windows.Forms.ContextMenuStrip cmsMenuMarkDayFact;
        private System.Windows.Forms.ToolStripMenuItem miFactD;
        private System.Windows.Forms.ToolStripMenuItem miFactK;
        private System.Windows.Forms.ToolStripMenuItem miFactB;
        private System.Windows.Forms.ToolStripMenuItem miFactSVVI;
        private System.Windows.Forms.ContextMenuStrip cmsMenuMarkDayPlan;
        private System.Windows.Forms.ToolStripMenuItem miPlanDD;
        private System.Windows.Forms.ToolStripMenuItem miPlanBD;
        private System.Windows.Forms.ToolStripMenuItem miPlanSD;
        private System.Windows.Forms.ToolStripMenuItem miPlanSDDD;
        private System.Windows.Forms.ToolStripMenuItem miPlanDDSD;
        private System.Windows.Forms.ToolStripMenuItem miFactVI;
        private System.Windows.Forms.ToolStripMenuItem miFactN;
        private System.Windows.Forms.ToolStripMenuItem miFactDS;
        private System.Windows.Forms.ToolStripMenuItem miFactKS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem darbaLaikaUzskaitesLapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izdrukaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarakstsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSheetCheckEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmiSheetFillFact;
        private System.Windows.Forms.ToolStripMenuItem darbinieksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonCheckEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonFillFact;
        private System.Windows.Forms.ToolStripMenuItem darbaLaikaLapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darbaLaikaKopsummasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSNRX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcKind1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcV31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcKind2;
        private System.Windows.Forms.ToolStripMenuItem darbaLaikaLapaArKrāsāmToolStripMenuItem;
        private Classes.MyStyleDefs myStyleDefsForReport;
    }
}