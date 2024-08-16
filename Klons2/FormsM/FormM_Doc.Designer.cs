
namespace KlonsM.FormsM
{
    partial class FormM_Doc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_Doc));
            mySplitContainer1 = new KlonsLIB.Components.MySplitContainer();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dokumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            kopētDokumentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            miTools = new System.Windows.Forms.ToolStripMenuItem();
            miPricesAndDiscounts = new System.Windows.Forms.ToolStripMenuItem();
            izmaksuKopsavilkumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            miSplitPVN = new System.Windows.Forms.ToolStripMenuItem();
            miImportRows = new System.Windows.Forms.ToolStripMenuItem();
            dzēstDokumentuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            iegrāmatotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atvērtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            izveidotKredītrēķinuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            prečuAtgriešanaCenasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            kontējumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            izdrukaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pavadzīmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sgrDocA = new KlonsLIB.MySourceGrid.MyGrid();
            docData1 = new DataObjectsFM.DocData();
            grDocTitleDokuments = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grDocDT = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            bsDocs = new KlonsLIB.Data.MyBindingSource(components);
            grDocSR = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocNR = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocTP = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsDocType = new KlonsLIB.Data.MyBindingSource(components);
            grDocTransType = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsTransType = new KlonsLIB.Data.MyBindingSource(components);
            grDocState = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocTitleKrajumi = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grDocStoreOut = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsStoreOut = new KlonsLIB.Data.MyBindingSource(components);
            grDocStoreIn = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsStoreIn = new KlonsLIB.Data.MyBindingSource(components);
            grDocCMCol2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand();
            grDocTitleCredDoc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            gdDocCdDT = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocCdSr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocCdNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocTitleTransoirt = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grDocAddressOut = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsAddress = new KlonsLIB.Data.MyBindingSource(components);
            grDocAddressIn = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            grDocCarrier = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsCarrier = new KlonsLIB.Data.MyBindingSource(components);
            grDocDriver = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsDriver = new KlonsLIB.Data.MyBindingSource(components);
            grDocVehicle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsVehicle = new KlonsLIB.Data.MyBindingSource(components);
            grDocCMCol3 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand();
            grDocTitlePay = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grDocPayType = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB();
            bsPayType = new KlonsLIB.Data.MyBindingSource(components);
            grDocDueDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocTitleFinances = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grDocSum = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grDocPVNType = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsPVNType = new KlonsLIB.Data.MyBindingSource(components);
            grDocAccIn = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            bsAccounts = new KlonsLIB.Data.MyBindingSource(components);
            grDocAccOut = new KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox();
            grDocManualFinOps = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox();
            grDocIncludeInCostCalc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox();
            grDocWeVATPayer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox();
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcRowsIdItem = new KlonsLIB.Components.MyDgvTextboxColumn2();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            dgcRowsItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsPrice0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsTPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsIdPVNRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowTBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsAcc6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsAcc7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsIdDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcRowsIdSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsRows = new KlonsLIB.Data.MyBindingSource2(components);
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            bsUnits = new KlonsLIB.Data.MyBindingSource(components);
            myConfigA1 = new MyConfigA();
            bNav = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bniNew = new System.Windows.Forms.ToolStripButton();
            bniDelete = new System.Windows.Forms.ToolStripButton();
            bniSave = new System.Windows.Forms.ToolStripButton();
            tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            tsbFind = new System.Windows.Forms.ToolStripTextBox();
            tsbFindNext = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).BeginInit();
            mySplitContainer1.Panel1.SuspendLayout();
            mySplitContainer1.Panel2.SuspendLayout();
            mySplitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDocType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTransType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCarrier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDriver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsVehicle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPayType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bNav).BeginInit();
            bNav.SuspendLayout();
            SuspendLayout();
            // 
            // mySplitContainer1
            // 
            mySplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            mySplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            mySplitContainer1.Location = new System.Drawing.Point(0, 0);
            mySplitContainer1.Name = "mySplitContainer1";
            mySplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mySplitContainer1.Panel1
            // 
            mySplitContainer1.Panel1.Controls.Add(menuStrip1);
            mySplitContainer1.Panel1.Controls.Add(sgrDocA);
            // 
            // mySplitContainer1.Panel2
            // 
            mySplitContainer1.Panel2.Controls.Add(dgvRows);
            mySplitContainer1.Size = new System.Drawing.Size(1078, 483);
            mySplitContainer1.SplitterDistance = 289;
            mySplitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dokumentsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(9, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(99, 25);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // dokumentsToolStripMenuItem
            // 
            dokumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { kopētDokumentuToolStripMenuItem, miTools, dzēstDokumentuToolStripMenuItem, toolStripSeparator1, iegrāmatotToolStripMenuItem, atvērtToolStripMenuItem, toolStripSeparator2, iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem, atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem, toolStripSeparator3, izveidotKredītrēķinuToolStripMenuItem, prečuAtgriešanaCenasToolStripMenuItem, prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem, toolStripSeparator4, kontējumsToolStripMenuItem, toolStripSeparator5, izdrukaiToolStripMenuItem });
            dokumentsToolStripMenuItem.Name = "dokumentsToolStripMenuItem";
            dokumentsToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            dokumentsToolStripMenuItem.Text = "Dokuments";
            // 
            // kopētDokumentuToolStripMenuItem
            // 
            kopētDokumentuToolStripMenuItem.Name = "kopētDokumentuToolStripMenuItem";
            kopētDokumentuToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            kopētDokumentuToolStripMenuItem.Text = "Kopēt dokumentu";
            kopētDokumentuToolStripMenuItem.Click += kopētDokumentuToolStripMenuItem_Click;
            // 
            // miTools
            // 
            miTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { miPricesAndDiscounts, izmaksuKopsavilkumsToolStripMenuItem, miSplitPVN, miImportRows });
            miTools.Name = "miTools";
            miTools.Size = new System.Drawing.Size(330, 22);
            miTools.Text = "Rīki";
            // 
            // miPricesAndDiscounts
            // 
            miPricesAndDiscounts.Name = "miPricesAndDiscounts";
            miPricesAndDiscounts.Size = new System.Drawing.Size(244, 22);
            miPricesAndDiscounts.Text = "Cenas un atlaides";
            miPricesAndDiscounts.Click += miPricesAndDiscounts_Click;
            // 
            // izmaksuKopsavilkumsToolStripMenuItem
            // 
            izmaksuKopsavilkumsToolStripMenuItem.Name = "izmaksuKopsavilkumsToolStripMenuItem";
            izmaksuKopsavilkumsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            izmaksuKopsavilkumsToolStripMenuItem.Text = "Izmaksu kopsavilkums";
            izmaksuKopsavilkumsToolStripMenuItem.Click += miIzmaksuKopsavilkums_Click;
            // 
            // miSplitPVN
            // 
            miSplitPVN.Name = "miSplitPVN";
            miSplitPVN.Size = new System.Drawing.Size(244, 22);
            miSplitPVN.Text = "Pierēķināt PVN pie cenas";
            miSplitPVN.Click += miSplitPVN_Click;
            // 
            // miImportRows
            // 
            miImportRows.Name = "miImportRows";
            miImportRows.Size = new System.Drawing.Size(244, 22);
            miImportRows.Text = "Importēt dokumenta rindas";
            miImportRows.Click += miImportRows_Click;
            // 
            // dzēstDokumentuToolStripMenuItem
            // 
            dzēstDokumentuToolStripMenuItem.Name = "dzēstDokumentuToolStripMenuItem";
            dzēstDokumentuToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            dzēstDokumentuToolStripMenuItem.Text = "Dzēst dokumentu";
            dzēstDokumentuToolStripMenuItem.Click += dzēstDokumentuToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(327, 6);
            // 
            // iegrāmatotToolStripMenuItem
            // 
            iegrāmatotToolStripMenuItem.Name = "iegrāmatotToolStripMenuItem";
            iegrāmatotToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            iegrāmatotToolStripMenuItem.Text = "Iegrāmatot";
            iegrāmatotToolStripMenuItem.Click += iegrāmatotToolStripMenuItem_Click;
            // 
            // atvērtToolStripMenuItem
            // 
            atvērtToolStripMenuItem.Name = "atvērtToolStripMenuItem";
            atvērtToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            atvērtToolStripMenuItem.Text = "Atvērt rediģēšanai";
            atvērtToolStripMenuItem.Click += atvērtToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(327, 6);
            // 
            // iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem
            // 
            iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem.Name = "iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem";
            iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem.Text = "Iegrāmatot veicot pilnu pārrēķinu";
            iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem.Click += iegrāmatotVeicotPilnuPārrēķinuToolStripMenuItem_Click;
            // 
            // atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem
            // 
            atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem.Name = "atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem";
            atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem.Text = "Atvērt rediģēšanai veicot pilnu pārrēķinu";
            atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem.Click += atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(327, 6);
            // 
            // izveidotKredītrēķinuToolStripMenuItem
            // 
            izveidotKredītrēķinuToolStripMenuItem.Name = "izveidotKredītrēķinuToolStripMenuItem";
            izveidotKredītrēķinuToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            izveidotKredītrēķinuToolStripMenuItem.Text = "Izveidot kredītrēķinu";
            izveidotKredītrēķinuToolStripMenuItem.Click += izveidotKredītrēķinuToolStripMenuItem_Click;
            // 
            // prečuAtgriešanaCenasToolStripMenuItem
            // 
            prečuAtgriešanaCenasToolStripMenuItem.Name = "prečuAtgriešanaCenasToolStripMenuItem";
            prečuAtgriešanaCenasToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            prečuAtgriešanaCenasToolStripMenuItem.Text = "Preču atgriešana - cenas aprēķins";
            prečuAtgriešanaCenasToolStripMenuItem.Click += prečuAtgriešanaCenasAprēķinsToolStripMenuItem_Click;
            // 
            // prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem
            // 
            prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem.Name = "prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem";
            prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem.Text = "Preču atgriešana - izveidot kredītrēķinus";
            prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem.Click += prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(327, 6);
            // 
            // kontējumsToolStripMenuItem
            // 
            kontējumsToolStripMenuItem.Name = "kontējumsToolStripMenuItem";
            kontējumsToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            kontējumsToolStripMenuItem.Text = "Kontējums";
            kontējumsToolStripMenuItem.Click += kontējumsToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(327, 6);
            // 
            // izdrukaiToolStripMenuItem
            // 
            izdrukaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pavadzīmeToolStripMenuItem });
            izdrukaiToolStripMenuItem.Name = "izdrukaiToolStripMenuItem";
            izdrukaiToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            izdrukaiToolStripMenuItem.Text = "Izdrukai";
            // 
            // pavadzīmeToolStripMenuItem
            // 
            pavadzīmeToolStripMenuItem.Name = "pavadzīmeToolStripMenuItem";
            pavadzīmeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            pavadzīmeToolStripMenuItem.Text = "Pavadzīme";
            pavadzīmeToolStripMenuItem.Click += pavadzīmeToolStripMenuItem_Click;
            // 
            // sgrDocA
            // 
            sgrDocA.BackColor2 = System.Drawing.SystemColors.Window;
            sgrDocA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            sgrDocA.ColumnWidth1 = 5;
            sgrDocA.ColumnWidth2 = 120;
            sgrDocA.ColumnWidth3 = 180;
            sgrDocA.DefaultHeight = 22;
            sgrDocA.Dock = System.Windows.Forms.DockStyle.Fill;
            sgrDocA.EnableSort = false;
            sgrDocA.Location = new System.Drawing.Point(0, 0);
            sgrDocA.MyDataBC = docData1;
            sgrDocA.Name = "sgrDocA";
            sgrDocA.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            sgrDocA.RowList.Add(grDocTitleDokuments);
            sgrDocA.RowList.Add(grDocDT);
            sgrDocA.RowList.Add(grDocSR);
            sgrDocA.RowList.Add(grDocNR);
            sgrDocA.RowList.Add(grDocTP);
            sgrDocA.RowList.Add(grDocTransType);
            sgrDocA.RowList.Add(grDocState);
            sgrDocA.RowList.Add(grDocTitleKrajumi);
            sgrDocA.RowList.Add(grDocStoreOut);
            sgrDocA.RowList.Add(grDocStoreIn);
            sgrDocA.RowList.Add(grDocCMCol2);
            sgrDocA.RowList.Add(grDocTitleCredDoc);
            sgrDocA.RowList.Add(gdDocCdDT);
            sgrDocA.RowList.Add(grDocCdSr);
            sgrDocA.RowList.Add(grDocCdNr);
            sgrDocA.RowList.Add(grDocTitleTransoirt);
            sgrDocA.RowList.Add(grDocAddressOut);
            sgrDocA.RowList.Add(grDocAddressIn);
            sgrDocA.RowList.Add(grDocCarrier);
            sgrDocA.RowList.Add(grDocDriver);
            sgrDocA.RowList.Add(grDocVehicle);
            sgrDocA.RowList.Add(grDocCMCol3);
            sgrDocA.RowList.Add(grDocTitlePay);
            sgrDocA.RowList.Add(grDocPayType);
            sgrDocA.RowList.Add(grDocDueDate);
            sgrDocA.RowList.Add(grDocTitleFinances);
            sgrDocA.RowList.Add(grDocSum);
            sgrDocA.RowList.Add(grDocPVNType);
            sgrDocA.RowList.Add(grDocAccIn);
            sgrDocA.RowList.Add(grDocAccOut);
            sgrDocA.RowList.Add(grDocManualFinOps);
            sgrDocA.RowList.Add(grDocIncludeInCostCalc);
            sgrDocA.RowList.Add(grDocWeVATPayer);
            sgrDocA.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            sgrDocA.Size = new System.Drawing.Size(1078, 289);
            sgrDocA.TabIndex = 0;
            sgrDocA.TabStop = true;
            sgrDocA.ToolTipText = "";
            sgrDocA.EditStarting += sgrDocA_EditStarting;
            sgrDocA.ConvertingValueToDisplayString += sgrDocA_ConvertingValueToDisplayString;
            // 
            // docData1
            // 
            docData1._ACCIN = null;
            docData1._ACCOUNTINGTP = 0;
            docData1._ACCOUT = null;
            docData1._ACCTP1 = 0;
            docData1._ACCTP2 = 0;
            docData1._CREDDOCDT = null;
            docData1._CREDDOCNR = null;
            docData1._CREDDOCSR = null;
            docData1._DT = new System.DateTime(0L);
            docData1._DUEDATE = null;
            docData1._ID = 0;
            docData1._IDADDRESSIN = 0;
            docData1._IDADDRESSOUT = 0;
            docData1._IDCARRIER = 0;
            docData1._IDCREDDOC = null;
            docData1._IDDRIVER = 0;
            docData1._IDPAYMENTTYPE = 0;
            docData1._IDSTOREIN = 0;
            docData1._IDSTOREOUT = 0;
            docData1._IDTRANSACTIONTYPE = 0;
            docData1._IDVEHICLE = 0;
            docData1._NR = null;
            docData1._PVNTYPE = 0;
            docData1._SR = null;
            docData1._STATE = 0;
            docData1._SUMM = new decimal(new int[] { 0, 0, 0, 0 });
            docData1._TP = 0;
            docData1._WEVATPAYER = 0;
            // 
            // grDocTitleDokuments
            // 
            grDocTitleDokuments.Name = "grDocTitleDokuments";
            grDocTitleDokuments.RowTitle = "Dokuments";
            grDocTitleDokuments.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // grDocDT
            // 
            grDocDT.DataMember = "DT";
            grDocDT.DataSource = bsDocs;
            grDocDT.GridPropertyName = "_DT";
            grDocDT.Name = "grDocDT";
            grDocDT.RowTitle = "Datums";
            grDocDT.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Date;
            // 
            // bsDocs
            // 
            bsDocs.DataMember = "M_DOCS";
            bsDocs.MyDataSource = "KlonsMData";
            bsDocs.Sort = "";
            bsDocs.CurrentChanged += bsDocs_CurrentChanged;
            bsDocs.ListChanged += bsDocs_ListChanged;
            // 
            // grDocSR
            // 
            grDocSR.AllowNull = true;
            grDocSR.DataMember = "SR";
            grDocSR.DataSource = bsDocs;
            grDocSR.GridPropertyName = "_SR";
            grDocSR.Name = "grDocSR";
            grDocSR.RowTitle = "Sērija";
            grDocSR.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grDocNR
            // 
            grDocNR.AllowNull = true;
            grDocNR.DataMember = "NR";
            grDocNR.DataSource = bsDocs;
            grDocNR.GridPropertyName = "_NR";
            grDocNR.Name = "grDocNR";
            grDocNR.RowTitle = "Numurs";
            grDocNR.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grDocTP
            // 
            grDocTP.DataMember = "TP";
            grDocTP.DataSource = bsDocs;
            grDocTP.GridPropertyName = "_TP";
            grDocTP.ListDisplayMember = "CODE";
            grDocTP.ListSource = bsDocType;
            grDocTP.ListValueMember = "ID";
            grDocTP.Name = "grDocTP";
            grDocTP.RowTitle = "Veids";
            grDocTP.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // bsDocType
            // 
            bsDocType.DataMember = "M_DOCTYPES";
            bsDocType.MyDataSource = "KlonsMData";
            bsDocType.Sort = "ID";
            // 
            // grDocTransType
            // 
            grDocTransType.DataMember = "IDTRANSACTIONTYPE";
            grDocTransType.DataSource = bsDocs;
            grDocTransType.GridPropertyName = "_IDTRANSACTIONTYPE";
            grDocTransType.ListDisplayMember = "NAME";
            grDocTransType.ListSource = bsTransType;
            grDocTransType.ListValueMember = "ID";
            grDocTransType.Name = "grDocTransType";
            grDocTransType.RowTitle = "Darijuma veids";
            grDocTransType.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // bsTransType
            // 
            bsTransType.DataMember = "M_TRANSACTIONTYPE";
            bsTransType.MyDataSource = "KlonsMData";
            bsTransType.Sort = "ID";
            // 
            // grDocState
            // 
            grDocState.CustomConversions = true;
            grDocState.DataMember = "STATE";
            grDocState.DataSource = bsDocs;
            grDocState.GridPropertyName = "_STATE";
            grDocState.Name = "grDocState";
            grDocState.ReadOnly = true;
            grDocState.RowTitle = "Status";
            grDocState.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            grDocState.TextAllign = KlonsLIB.MySourceGrid.GridRows.ECellTextAllign.Left;
            // 
            // grDocTitleKrajumi
            // 
            grDocTitleKrajumi.Name = "grDocTitleKrajumi";
            grDocTitleKrajumi.RowTitle = "Krājumu kustība";
            grDocTitleKrajumi.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // grDocStoreOut
            // 
            grDocStoreOut.CustomConversions = true;
            grDocStoreOut.DataMember = "IDSTOREOUT";
            grDocStoreOut.DataSource = bsDocs;
            grDocStoreOut.GridPropertyName = "_IDSTOREOUT";
            grDocStoreOut.ListDisplayMember = "CODE";
            grDocStoreOut.ListSource = bsStoreOut;
            grDocStoreOut.ListValueMember = "ID";
            grDocStoreOut.Name = "grDocStoreOut";
            grDocStoreOut.RowTitle = "Izsniedzējs";
            grDocStoreOut.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // bsStoreOut
            // 
            bsStoreOut.DataMember = "M_STORES";
            bsStoreOut.MyDataSource = "KlonsMData";
            bsStoreOut.Sort = "CODE";
            // 
            // grDocStoreIn
            // 
            grDocStoreIn.CustomConversions = true;
            grDocStoreIn.DataMember = "IDSTOREIN";
            grDocStoreIn.DataSource = bsDocs;
            grDocStoreIn.GridPropertyName = "_IDSTOREIN";
            grDocStoreIn.ListDisplayMember = "CODE";
            grDocStoreIn.ListSource = bsStoreIn;
            grDocStoreIn.ListValueMember = "ID";
            grDocStoreIn.Name = "grDocStoreIn";
            grDocStoreIn.RowTitle = "Saņēmējs";
            grDocStoreIn.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // bsStoreIn
            // 
            bsStoreIn.DataMember = "M_STORES";
            bsStoreIn.MyDataSource = "KlonsMData";
            bsStoreIn.Sort = "CODE";
            // 
            // grDocCMCol2
            // 
            grDocCMCol2.CaptionColumnWidth = 130;
            grDocCMCol2.Command = KlonsLIB.MySourceGrid.GridRows.EMyGridRowCommands.StartNewColumn;
            grDocCMCol2.Name = "grDocCMCol2";
            grDocCMCol2.RowTitle = null;
            grDocCMCol2.SetColumnWidth = true;
            // 
            // grDocTitleCredDoc
            // 
            grDocTitleCredDoc.Name = "grDocTitleCredDoc";
            grDocTitleCredDoc.RowTitle = "Kredītrēķins";
            grDocTitleCredDoc.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // gdDocCdDT
            // 
            gdDocCdDT.AllowNull = true;
            gdDocCdDT.DataMember = "CREDDOCDT";
            gdDocCdDT.DataSource = bsDocs;
            gdDocCdDT.GridPropertyName = "_CREDDOCDT";
            gdDocCdDT.Name = "gdDocCdDT";
            gdDocCdDT.ReadOnly = true;
            gdDocCdDT.RowTitle = "Datums";
            gdDocCdDT.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // grDocCdSr
            // 
            grDocCdSr.AllowNull = true;
            grDocCdSr.DataMember = "CREDDOCSR";
            grDocCdSr.DataSource = bsDocs;
            grDocCdSr.GridPropertyName = "_CREDDOCSR";
            grDocCdSr.Name = "grDocCdSr";
            grDocCdSr.ReadOnly = true;
            grDocCdSr.RowTitle = "Sērija";
            grDocCdSr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grDocCdNr
            // 
            grDocCdNr.AllowNull = true;
            grDocCdNr.DataMember = "CREDDOCNR";
            grDocCdNr.DataSource = bsDocs;
            grDocCdNr.GridPropertyName = "_CREDDOCNR";
            grDocCdNr.Name = "grDocCdNr";
            grDocCdNr.ReadOnly = true;
            grDocCdNr.RowTitle = "Numurs";
            grDocCdNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grDocTitleTransoirt
            // 
            grDocTitleTransoirt.Name = "grDocTitleTransoirt";
            grDocTitleTransoirt.RowTitle = "Transports";
            grDocTitleTransoirt.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // grDocAddressOut
            // 
            grDocAddressOut.AllowNull = true;
            grDocAddressOut.DataMember = "IDADDRESSOUT";
            grDocAddressOut.DataSource = bsDocs;
            grDocAddressOut.GridPropertyName = "_IDADDRESSOUT";
            grDocAddressOut.ListDisplayMember = "ADDRESS";
            grDocAddressOut.ListSource = bsAddress;
            grDocAddressOut.ListValueMember = "ID";
            grDocAddressOut.Name = "grDocAddressOut";
            grDocAddressOut.ReadOnlyEx = true;
            grDocAddressOut.RowTitle = "Izsniegšanas adr.";
            grDocAddressOut.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsAddress
            // 
            bsAddress.DataMember = "M_ADDRESSSES";
            bsAddress.MyDataSource = "KlonsMData";
            // 
            // grDocAddressIn
            // 
            grDocAddressIn.AllowNull = true;
            grDocAddressIn.DataMember = "IDADDRESSIN";
            grDocAddressIn.DataSource = bsDocs;
            grDocAddressIn.GridPropertyName = "_IDADDRESSIN";
            grDocAddressIn.ListDisplayMember = "ADDRESS";
            grDocAddressIn.ListSource = bsAddress;
            grDocAddressIn.ListValueMember = "ID";
            grDocAddressIn.Name = "grDocAddressIn";
            grDocAddressIn.ReadOnlyEx = true;
            grDocAddressIn.RowTitle = "Saņemšanas adr.";
            grDocAddressIn.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // grDocCarrier
            // 
            grDocCarrier.AllowNull = true;
            grDocCarrier.DataMember = "IDCARRIER";
            grDocCarrier.DataSource = bsDocs;
            grDocCarrier.GridPropertyName = "_IDCARRIER";
            grDocCarrier.ListDisplayMember = "CODE";
            grDocCarrier.ListSource = bsCarrier;
            grDocCarrier.ListValueMember = "ID";
            grDocCarrier.Name = "grDocCarrier";
            grDocCarrier.RowTitle = "Pārvadātājs";
            grDocCarrier.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsCarrier
            // 
            bsCarrier.DataMember = "M_STORES";
            bsCarrier.MyDataSource = "KlonsMData";
            bsCarrier.Sort = "CODE";
            // 
            // grDocDriver
            // 
            grDocDriver.AllowNull = true;
            grDocDriver.DataMember = "IDDRIVER";
            grDocDriver.DataSource = bsDocs;
            grDocDriver.GridPropertyName = "_IDDRIVER";
            grDocDriver.ListDisplayMember = "NAME";
            grDocDriver.ListSource = bsDriver;
            grDocDriver.ListValueMember = "ID";
            grDocDriver.Name = "grDocDriver";
            grDocDriver.ReadOnlyEx = true;
            grDocDriver.RowTitle = "Vadītājs";
            grDocDriver.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsDriver
            // 
            bsDriver.DataMember = "M_CONTACTS";
            bsDriver.MyDataSource = "KlonsMData";
            bsDriver.Sort = "NAME";
            // 
            // grDocVehicle
            // 
            grDocVehicle.AllowNull = true;
            grDocVehicle.DataMember = "IDVEHICLE";
            grDocVehicle.DataSource = bsDocs;
            grDocVehicle.GridPropertyName = "_IDVEHICLE";
            grDocVehicle.ListDisplayMember = "NAME";
            grDocVehicle.ListSource = bsVehicle;
            grDocVehicle.ListValueMember = "ID";
            grDocVehicle.Name = "grDocVehicle";
            grDocVehicle.ReadOnlyEx = true;
            grDocVehicle.RowTitle = "TL reģ.nr.";
            grDocVehicle.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsVehicle
            // 
            bsVehicle.DataMember = "M_VEHICLES";
            bsVehicle.MyDataSource = "KlonsMData";
            // 
            // grDocCMCol3
            // 
            grDocCMCol3.CaptionColumnWidth = 160;
            grDocCMCol3.Command = KlonsLIB.MySourceGrid.GridRows.EMyGridRowCommands.StartNewColumn;
            grDocCMCol3.DataColumnWidth = 220;
            grDocCMCol3.Name = "grDocCMCol3";
            grDocCMCol3.RowTitle = null;
            grDocCMCol3.SetColumnWidth = true;
            // 
            // grDocTitlePay
            // 
            grDocTitlePay.Name = "grDocTitlePay";
            grDocTitlePay.RowTitle = "Norēķini";
            grDocTitlePay.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // grDocPayType
            // 
            grDocPayType.AllowNull = true;
            grDocPayType.ColumnNames = new string[]
    {
    "NAME"
    };
            grDocPayType.ColumnWidths = "200";
            grDocPayType.DataMember = "IDPAYMENTTYPE";
            grDocPayType.DataSource = bsDocs;
            grDocPayType.GridPropertyName = "_IDPAYMENTTYPE";
            grDocPayType.ListDisplayMember = "NAME";
            grDocPayType.ListSource = bsPayType;
            grDocPayType.ListValueMember = "ID";
            grDocPayType.Name = "grDocPayType";
            grDocPayType.RowTitle = "Veids";
            grDocPayType.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsPayType
            // 
            bsPayType.DataMember = "M_PAYMENTTYPE";
            bsPayType.MyDataSource = "KlonsMData";
            bsPayType.Sort = "ID";
            // 
            // grDocDueDate
            // 
            grDocDueDate.AllowNull = true;
            grDocDueDate.DataMember = "DUEDATE";
            grDocDueDate.DataSource = bsDocs;
            grDocDueDate.GridPropertyName = "_DUEDATE";
            grDocDueDate.Name = "grDocDueDate";
            grDocDueDate.RowTitle = "Apmaksāt līdz";
            grDocDueDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // grDocTitleFinances
            // 
            grDocTitleFinances.Name = "grDocTitleFinances";
            grDocTitleFinances.RowTitle = "Kontēšana";
            grDocTitleFinances.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // grDocSum
            // 
            grDocSum.DataMember = "SUMM";
            grDocSum.DataSource = bsDocs;
            grDocSum.GridPropertyName = "_SUMM";
            grDocSum.Name = "grDocSum";
            grDocSum.RowTitle = "Summa";
            grDocSum.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // grDocPVNType
            // 
            grDocPVNType.DataMember = "PVNTYPE";
            grDocPVNType.DataSource = bsDocs;
            grDocPVNType.GridPropertyName = "_PVNTYPE";
            grDocPVNType.ListDisplayMember = "NAME";
            grDocPVNType.ListSource = bsPVNType;
            grDocPVNType.ListValueMember = "ID";
            grDocPVNType.Name = "grDocPVNType";
            grDocPVNType.RowTitle = "PVN režīms";
            grDocPVNType.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // bsPVNType
            // 
            bsPVNType.DataMember = "M_PVNTYPE";
            bsPVNType.MyDataSource = "KlonsMData";
            bsPVNType.Sort = "ID";
            // 
            // grDocAccIn
            // 
            grDocAccIn.DataMember = "ACCIN";
            grDocAccIn.DataSource = bsDocs;
            grDocAccIn.GridPropertyName = "_ACCIN";
            grDocAccIn.ListDisplayMember = "ID";
            grDocAccIn.ListSource = bsAccounts;
            grDocAccIn.ListValueMember = "ID";
            grDocAccIn.Name = "grDocAccIn";
            grDocAccIn.ReadOnly = true;
            grDocAccIn.RowTitle = "debets";
            grDocAccIn.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // bsAccounts
            // 
            bsAccounts.DataMember = "M_ACCOUNTS";
            bsAccounts.MyDataSource = "KlonsMData";
            bsAccounts.Sort = "ID";
            // 
            // grDocAccOut
            // 
            grDocAccOut.DataMember = "ACCOUT";
            grDocAccOut.DataSource = bsDocs;
            grDocAccOut.GridPropertyName = "_ACCOUT";
            grDocAccOut.ListDisplayMember = "ID";
            grDocAccOut.ListSource = bsAccounts;
            grDocAccOut.ListValueMember = "ID";
            grDocAccOut.Name = "grDocAccOut";
            grDocAccOut.ReadOnly = true;
            grDocAccOut.RowTitle = "kredīts";
            grDocAccOut.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grDocManualFinOps
            // 
            grDocManualFinOps.DataMember = "ACCTP1";
            grDocManualFinOps.DataSource = bsDocs;
            grDocManualFinOps.FalseValue = "1";
            grDocManualFinOps.GridPropertyName = "_ACCTP1";
            grDocManualFinOps.Name = "grDocManualFinOps";
            grDocManualFinOps.ReadOnly = true;
            grDocManualFinOps.RowTitle = "Manuāls kontējums";
            grDocManualFinOps.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            grDocManualFinOps.TrueValue = "0";
            // 
            // grDocIncludeInCostCalc
            // 
            grDocIncludeInCostCalc.DataMember = "ACCTP2";
            grDocIncludeInCostCalc.DataSource = bsDocs;
            grDocIncludeInCostCalc.FalseValue = "0";
            grDocIncludeInCostCalc.GridPropertyName = "_ACCTP2";
            grDocIncludeInCostCalc.Name = "grDocIncludeInCostCalc";
            grDocIncludeInCostCalc.RowTitle = "Ir izmaksu aprēķinā";
            grDocIncludeInCostCalc.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            grDocIncludeInCostCalc.TrueValue = "1";
            // 
            // grDocWeVATPayer
            // 
            grDocWeVATPayer.DataMember = "WEVATPAYER";
            grDocWeVATPayer.DataSource = bsDocs;
            grDocWeVATPayer.FalseValue = "0";
            grDocWeVATPayer.GridPropertyName = "_WEVATPAYER";
            grDocWeVATPayer.Name = "grDocWeVATPayer";
            grDocWeVATPayer.RowTitle = "Esam PVN maksātājs";
            grDocWeVATPayer.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            grDocWeVATPayer.TrueValue = "1";
            // 
            // dgvRows
            // 
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcRowsIdItem, dgcRowsItemName, dgcRowsUnits, dgcRowsAmount, dgcRowsPrice0, dgcRowsDiscount, dgcRowsPrice, dgcRowsTPrice, dgcRowsIdPVNRate, dgcRowsBuyPrice, dgcRowTBuyPrice, dgcRowsAcc6, dgcRowsAcc7, dgcRowsId, dgcRowsIdDoc, dgcRowsIdSeq });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 0);
            dgvRows.Name = "dgvRows";
            dgvRows.RowHeadersWidth = 30;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1078, 190);
            dgvRows.TabIndex = 0;
            dgvRows.MyKeyDown += dgvRows_MyKeyDown;
            dgvRows.MyCheckForChanges += dgvRows_MyCheckForChanges;
            dgvRows.CellBeginEdit += dgvRows_CellBeginEdit;
            dgvRows.CellDoubleClick += dgvRows_CellDoubleClick;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            dgvRows.CellParsing += dgvRows_CellParsing;
            dgvRows.DefaultValuesNeeded += dgvRows_DefaultValuesNeeded;
            dgvRows.UserDeletingRow += dgvRows_UserDeletingRow;
            // 
            // dgcRowsIdItem
            // 
            dgcRowsIdItem.DataPropertyName = "IDITEM";
            dgcRowsIdItem.DataSource = bsItems;
            dgcRowsIdItem.DisplayMember = "BARCODE";
            dgcRowsIdItem.Frozen = true;
            dgcRowsIdItem.HeaderText = "artikuls";
            dgcRowsIdItem.MinimumWidth = 8;
            dgcRowsIdItem.Name = "dgcRowsIdItem";
            dgcRowsIdItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcRowsIdItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcRowsIdItem.ValueMember = "ID";
            dgcRowsIdItem.Width = 150;
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // dgcRowsItemName
            // 
            dgcRowsItemName.DataPropertyName = "IDITEM";
            dgcRowsItemName.HeaderText = "nosaukums";
            dgcRowsItemName.MinimumWidth = 8;
            dgcRowsItemName.Name = "dgcRowsItemName";
            dgcRowsItemName.ReadOnly = true;
            dgcRowsItemName.Width = 200;
            // 
            // dgcRowsUnits
            // 
            dgcRowsUnits.DataPropertyName = "UNITS";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowsUnits.DefaultCellStyle = dataGridViewCellStyle1;
            dgcRowsUnits.HeaderText = "mērv.";
            dgcRowsUnits.MinimumWidth = 8;
            dgcRowsUnits.Name = "dgcRowsUnits";
            dgcRowsUnits.ReadOnly = true;
            dgcRowsUnits.Width = 60;
            // 
            // dgcRowsAmount
            // 
            dgcRowsAmount.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowsAmount.DefaultCellStyle = dataGridViewCellStyle2;
            dgcRowsAmount.HeaderText = "skaits";
            dgcRowsAmount.MinimumWidth = 8;
            dgcRowsAmount.Name = "dgcRowsAmount";
            dgcRowsAmount.Width = 60;
            // 
            // dgcRowsPrice0
            // 
            dgcRowsPrice0.DataPropertyName = "PRICE0";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N4";
            dgcRowsPrice0.DefaultCellStyle = dataGridViewCellStyle3;
            dgcRowsPrice0.HeaderText = "cena";
            dgcRowsPrice0.MinimumWidth = 8;
            dgcRowsPrice0.Name = "dgcRowsPrice0";
            dgcRowsPrice0.Width = 90;
            // 
            // dgcRowsDiscount
            // 
            dgcRowsDiscount.DataPropertyName = "DISCOUNT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcRowsDiscount.DefaultCellStyle = dataGridViewCellStyle4;
            dgcRowsDiscount.HeaderText = "atlaide";
            dgcRowsDiscount.MinimumWidth = 8;
            dgcRowsDiscount.Name = "dgcRowsDiscount";
            dgcRowsDiscount.Width = 60;
            // 
            // dgcRowsPrice
            // 
            dgcRowsPrice.DataPropertyName = "PRICE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N4";
            dgcRowsPrice.DefaultCellStyle = dataGridViewCellStyle5;
            dgcRowsPrice.HeaderText = "cena ar atl.";
            dgcRowsPrice.MinimumWidth = 8;
            dgcRowsPrice.Name = "dgcRowsPrice";
            dgcRowsPrice.ReadOnly = true;
            dgcRowsPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcRowsPrice.Width = 95;
            // 
            // dgcRowsTPrice
            // 
            dgcRowsTPrice.DataPropertyName = "TPRICE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dgcRowsTPrice.DefaultCellStyle = dataGridViewCellStyle6;
            dgcRowsTPrice.HeaderText = "summa";
            dgcRowsTPrice.MinimumWidth = 8;
            dgcRowsTPrice.Name = "dgcRowsTPrice";
            dgcRowsTPrice.ReadOnly = true;
            dgcRowsTPrice.Width = 90;
            // 
            // dgcRowsIdPVNRate
            // 
            dgcRowsIdPVNRate.DataPropertyName = "IDPVNRATE";
            dgcRowsIdPVNRate.HeaderText = "PVN likne";
            dgcRowsIdPVNRate.MinimumWidth = 8;
            dgcRowsIdPVNRate.Name = "dgcRowsIdPVNRate";
            dgcRowsIdPVNRate.ReadOnly = true;
            dgcRowsIdPVNRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcRowsIdPVNRate.Width = 90;
            // 
            // dgcRowsBuyPrice
            // 
            dgcRowsBuyPrice.DataPropertyName = "BUYPRICE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N4";
            dgcRowsBuyPrice.DefaultCellStyle = dataGridViewCellStyle7;
            dgcRowsBuyPrice.HeaderText = "izmaksas";
            dgcRowsBuyPrice.MinimumWidth = 8;
            dgcRowsBuyPrice.Name = "dgcRowsBuyPrice";
            dgcRowsBuyPrice.ReadOnly = true;
            dgcRowsBuyPrice.Width = 110;
            // 
            // dgcRowTBuyPrice
            // 
            dgcRowTBuyPrice.DataPropertyName = "TBUYPRICE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dgcRowTBuyPrice.DefaultCellStyle = dataGridViewCellStyle8;
            dgcRowTBuyPrice.HeaderText = "summa";
            dgcRowTBuyPrice.MinimumWidth = 8;
            dgcRowTBuyPrice.Name = "dgcRowTBuyPrice";
            dgcRowTBuyPrice.ReadOnly = true;
            dgcRowTBuyPrice.Width = 90;
            // 
            // dgcRowsAcc6
            // 
            dgcRowsAcc6.DataPropertyName = "ACC6";
            dgcRowsAcc6.HeaderText = "konts 6";
            dgcRowsAcc6.MinimumWidth = 8;
            dgcRowsAcc6.Name = "dgcRowsAcc6";
            dgcRowsAcc6.ReadOnly = true;
            dgcRowsAcc6.Width = 80;
            // 
            // dgcRowsAcc7
            // 
            dgcRowsAcc7.DataPropertyName = "ACC7";
            dgcRowsAcc7.HeaderText = "konts 7";
            dgcRowsAcc7.MinimumWidth = 8;
            dgcRowsAcc7.Name = "dgcRowsAcc7";
            dgcRowsAcc7.ReadOnly = true;
            dgcRowsAcc7.Width = 80;
            // 
            // dgcRowsId
            // 
            dgcRowsId.DataPropertyName = "ID";
            dgcRowsId.HeaderText = "ID";
            dgcRowsId.MinimumWidth = 8;
            dgcRowsId.Name = "dgcRowsId";
            dgcRowsId.ReadOnly = true;
            dgcRowsId.Visible = false;
            dgcRowsId.Width = 60;
            // 
            // dgcRowsIdDoc
            // 
            dgcRowsIdDoc.DataPropertyName = "IDDOC";
            dgcRowsIdDoc.HeaderText = "IDDOC";
            dgcRowsIdDoc.MinimumWidth = 8;
            dgcRowsIdDoc.Name = "dgcRowsIdDoc";
            dgcRowsIdDoc.ReadOnly = true;
            dgcRowsIdDoc.Visible = false;
            dgcRowsIdDoc.Width = 60;
            // 
            // dgcRowsIdSeq
            // 
            dgcRowsIdSeq.DataPropertyName = "IDSEQ";
            dgcRowsIdSeq.HeaderText = "IDSEQ";
            dgcRowsIdSeq.MinimumWidth = 8;
            dgcRowsIdSeq.Name = "dgcRowsIdSeq";
            dgcRowsIdSeq.ReadOnly = true;
            dgcRowsIdSeq.Visible = false;
            dgcRowsIdSeq.Width = 80;
            // 
            // bsRows
            // 
            bsRows.DataMember = "FK_M_ROWS_IDDOC";
            bsRows.DataSource = bsDocs;
            bsRows.Sort = "IDSEQ";
            bsRows.UseDataGridView = dgvRows;
            bsRows.ListChanged += bsRows_ListChanged;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsMData";
            myAdapterManager1.TableNames = new string[]
    {
    "M_DOCS",
    "M_ROWS",
    "M_ITEMS",
    "M_ITEMS_CAT",
    "M_STORES",
    "M_ITEMS_PER_STORE",
    null
    };
            // 
            // bsUnits
            // 
            bsUnits.DataMember = "M_UNITS";
            bsUnits.MyDataSource = "KlonsMData";
            bsUnits.Sort = "CODE";
            // 
            // myConfigA1
            // 
            myConfigA1.DocStatusColor1 = System.Drawing.Color.LightYellow;
            myConfigA1.DocStatusColor2 = System.Drawing.Color.LightBlue;
            myConfigA1.DocStatusColor3 = System.Drawing.Color.LightGreen;
            // 
            // bNav
            // 
            bNav.AddNewItem = null;
            bNav.BindingSource = bsRows;
            bNav.CountItem = bindingNavigatorCountItem;
            bNav.CountItemFormat = " no {0}";
            bNav.DataGrid = dgvRows;
            bNav.DeleteItem = null;
            bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bniNew, bniDelete, bniSave, tsbFindPrev, tsbFind, tsbFindNext });
            bNav.Location = new System.Drawing.Point(0, 483);
            bNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bNav.Name = "bNav";
            bNav.PositionItem = bindingNavigatorPositionItem;
            bNav.SaveItem = bniSave;
            bNav.Size = new System.Drawing.Size(1078, 31);
            bNav.TabIndex = 3;
            bNav.Text = "myBindingNavigator1";
            bNav.ItemDeleting += bNav_ItemDeleting;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 28);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bniNew
            // 
            bniNew.Image = (System.Drawing.Image)resources.GetObject("bniNew.Image");
            bniNew.Name = "bniNew";
            bniNew.RightToLeftAutoMirrorImage = true;
            bniNew.Size = new System.Drawing.Size(74, 28);
            bniNew.Text = "Jauns";
            bniNew.Click += bniNew_Click;
            // 
            // bniDelete
            // 
            bniDelete.Image = (System.Drawing.Image)resources.GetObject("bniDelete.Image");
            bniDelete.Name = "bniDelete";
            bniDelete.RightToLeftAutoMirrorImage = true;
            bniDelete.Size = new System.Drawing.Size(72, 28);
            bniDelete.Text = "Dzēst";
            bniDelete.Click += bniDelete_Click;
            // 
            // bniSave
            // 
            bniSave.Image = (System.Drawing.Image)resources.GetObject("bniSave.Image");
            bniSave.Name = "bniSave";
            bniSave.Size = new System.Drawing.Size(92, 28);
            bniSave.Text = "Saglabāt";
            bniSave.Click += bniSave_Click;
            // 
            // tsbFindPrev
            // 
            tsbFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFindPrev.Image = (System.Drawing.Image)resources.GetObject("tsbFindPrev.Image");
            tsbFindPrev.Name = "tsbFindPrev";
            tsbFindPrev.RightToLeftAutoMirrorImage = true;
            tsbFindPrev.Size = new System.Drawing.Size(28, 28);
            tsbFindPrev.Text = "Iet uz iepriekšējo";
            tsbFindPrev.Click += tsbFindPrev_Click;
            // 
            // tsbFind
            // 
            tsbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            tsbFind.Name = "tsbFind";
            tsbFind.Size = new System.Drawing.Size(100, 31);
            tsbFind.ToolTipText = "meklēt tekstu kolonnā";
            tsbFind.Enter += tsbFind_Enter;
            tsbFind.KeyPress += tsbFind_KeyPress;
            // 
            // tsbFindNext
            // 
            tsbFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbFindNext.Image = (System.Drawing.Image)resources.GetObject("tsbFindNext.Image");
            tsbFindNext.Name = "tsbFindNext";
            tsbFindNext.RightToLeftAutoMirrorImage = true;
            tsbFindNext.Size = new System.Drawing.Size(28, 28);
            tsbFindNext.Text = "Iet uz nākošo";
            tsbFindNext.Click += tsbFindNext_Click;
            // 
            // FormM_Doc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1078, 514);
            Controls.Add(mySplitContainer1);
            Controls.Add(bNav);
            MainMenuStrip = menuStrip1;
            Name = "FormM_Doc";
            Text = "Dokuments";
            FormClosed += FormM_Doc_FormClosed;
            Load += FormM_Doc_Load;
            mySplitContainer1.Panel1.ResumeLayout(false);
            mySplitContainer1.Panel1.PerformLayout();
            mySplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).EndInit();
            mySplitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsDocs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDocType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTransType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStoreIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCarrier).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDriver).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsVehicle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPayType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPVNType).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bNav).EndInit();
            bNav.ResumeLayout(false);
            bNav.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KlonsLIB.Components.MySplitContainer mySplitContainer1;
        private KlonsLIB.Data.MyBindingSource bsDocs;
        private KlonsLIB.Data.MyBindingSource2 bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsDocType;
        private KlonsLIB.Data.MyBindingSource bsPVNType;
        private KlonsLIB.Data.MyBindingSource bsStoreOut;
        private KlonsLIB.Data.MyBindingSource bsStoreIn;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Data.MyBindingSource bsUnits;
        private MyConfigA myConfigA1;
        private KlonsLIB.MySourceGrid.MyGrid sgrDocA;
        private DataObjectsFM.DocData docData1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocDT;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocSR;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocNR;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocStoreOut;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocStoreIn;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocState;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitleDokuments;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitleKrajumi;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand grDocCMCol2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitleCredDoc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA gdDocCdDT;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocCdSr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocCdNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitleTransoirt;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocAddressOut;
        private KlonsLIB.Data.MyBindingSource bsCarrier;
        private KlonsLIB.Data.MyBindingSource bsAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocAddressIn;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocCarrier;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocDriver;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocVehicle;
        private KlonsLIB.Data.MyBindingSource bsTransType;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand grDocCMCol3;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB grDocPayType;
        private KlonsLIB.Data.MyBindingSource bsPayType;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitlePay;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocDueDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grDocTitleFinances;
        private KlonsLIB.Data.MyBindingSource bsAccounts;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocPVNType;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocAccIn;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocAccOut;
        private KlonsLIB.Data.MyBindingSource bsDriver;
        private KlonsLIB.Data.MyBindingSource bsVehicle;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bniNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bniDelete;
        private System.Windows.Forms.ToolStripButton bniSave;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grDocSum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dokumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzēstDokumentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem iegrāmatotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atvērtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iegrāmatotVeidotPilnuPārrēķinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveidotKredītrēķinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prečuAtgriešanaCenasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prečuAtgriešanaIzveidotKredītrēķinusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontējumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdrukaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pavadzīmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem atvērtRediģēšanaiVeicotPilnuPārrēķinuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocTP;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox grDocManualFinOps;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox grDocIncludeInCostCalc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowPickRowTextBox grDocTransType;
        private System.Windows.Forms.ToolStripMenuItem kopētDokumentuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCheckBox grDocWeVATPayer;
        private System.Windows.Forms.ToolStripMenuItem miTools;
        private System.Windows.Forms.ToolStripMenuItem izmaksuKopsavilkumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSplitPVN;
        private System.Windows.Forms.ToolStripMenuItem miPricesAndDiscounts;
        private System.Windows.Forms.ToolStripMenuItem miImportRows;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRowsIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsPrice0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsTPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsIdPVNRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowTBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsAcc6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsAcc7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsIdDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRowsIdSeq;
    }
}