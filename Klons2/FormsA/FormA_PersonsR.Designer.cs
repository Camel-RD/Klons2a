using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_PersonsR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_PersonsR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            MyMcComboBox.MyItem myItem1 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem2 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem3 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem4 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem5 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem6 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem7 = new MyMcComboBox.MyItem();
            MyMcComboBox.MyItem myItem8 = new MyMcComboBox.MyItem();
            bnavNav = new MyBindingNavigator();
            bsPersonsR = new KlonsLIB.Data.MyBindingSource2(components);
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            bnavNavCountItem = new System.Windows.Forms.ToolStripLabel();
            tslLabel = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bnavNavPosItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            bsAmati = new KlonsLIB.Data.MyBindingSource2(components);
            PersonsRData1 = new DataObjectsA.PersonsRData();
            rwPamatdati = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwFName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwLName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwNameDative = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rvNameAccusative = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwGender = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwPersonCode = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwBirthDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTAddress = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAddress = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwCity = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwState = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwCountry = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPostalCode = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTerCode = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTContact = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwPhone = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwEMail = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTBank = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwBankAcc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTPassp = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwPasspNo = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPasspIssuer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPasspDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTaxDoc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwTaxDocSerial = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTaxDocNo = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTaxDocIssuer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTTaxPayer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwTaxRegNo = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTStatus = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwInvalid = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwPensioner = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwPrisoner = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwRepres = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwPret = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwApgadSk = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTitleCom = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            shedPersonsText = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            AmatsRData1 = new DataObjectsA.AmatsData();
            rwAmatiT2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAmatiTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            bsAmatiR = new KlonsLIB.Data.MyBindingSource2(components);
            rwTitleDat = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiTitleAcc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiDep = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB();
            bsDep = new KlonsLIB.Data.MyBindingSource(components);
            rwAmatiDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiT3 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAmatiSalarytype = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwAmatiRate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiRateNight = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiRateOvertime = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiAdvance = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            shrwAmariDecimal = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            shrwAmatiRateType = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            cbPersons = new MyMcFlatComboBox();
            cbAmati = new MyMcFlatComboBox();
            MyAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            rwAmatiSixDayWeek = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwAmatiNormalDayHours = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiNormalWeekHours = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwComments2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowMultiLineTextBox();
            bsAmatiPS = new KlonsLIB.Data.MyBindingSource2(components);
            bsPapildSummasVeids = new KlonsLIB.Data.MyBindingSource(components);
            bsPapildSummaNo = new KlonsLIB.Data.MyBindingSource(components);
            bsPapildSummas = new KlonsLIB.Data.MyBindingSource2(components);
            dgvPapildSummas = new MyDataGridView();
            dgcPSIDA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcPSDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPSDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPSDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPSIDSV2 = new MyDgvMcComboBoxColumn();
            dgcPSRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPSRateType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcPSIDNO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcPSIsPaid = new MyDgvCheckBoxColumn();
            dgcPSIsInAvpay = new MyDgvCheckBoxColumn();
            dgcPSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsNotikumuVeidi = new KlonsLIB.Data.MyBindingSource(components);
            bsAmati2 = new KlonsLIB.Data.MyBindingSource2(components);
            bsNotikumi = new KlonsLIB.Data.MyBindingSource2(components);
            dgvNotikumi = new MyDataGridView();
            dgcNotIDN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            dgcNotIDN2 = new MyDgvMcComboBoxColumn();
            bsNotikumuVeidi2 = new KlonsLIB.Data.MyBindingSource(components);
            dgcNotIDA = new MyDgvMcComboBoxColumn();
            dgcNotDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDT3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotDays2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotOcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNotIDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            lbArrow1 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            cbDates = new MyMcFlatComboBox();
            cbSelectTab = new MyMcFlatComboBox();
            mySplitContainer1 = new MySplitContainer();
            dgvPersons = new MyDataGridView();
            dgcPersonsYName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            tbFindPerson = new MyTextBox();
            btNextPerson = new MyButton();
            btPrevPerson = new MyButton();
            tabControl1 = new TabControlWithoutHeader();
            tabPage1 = new System.Windows.Forms.TabPage();
            sgrAmati = new KlonsLIB.MySourceGrid.MyGrid();
            rwAmatiSaldoTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAmatiSaldoPay0 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiSaldoIIN0 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwSaldoAdvance = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiRateTitle1 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAmatiRateTitle2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAmatiRateH = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiRateHN = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAmatiRateHO = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            sgrPersR = new KlonsLIB.MySourceGrid.MyGrid();
            rwPensionerSp = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwNotOSA = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwBankId2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB();
            bsBanks = new KlonsLIB.Data.MyBindingSource(components);
            rwTitleBefore = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwVacationDays = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            sharedPersonsNoYes = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            sharedPersonsDecimal = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            shedPersonsTextAllowNull = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            darbiniekuDatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rādītPaslēptDarbiniekuSarakstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            miShowOnlyUsed = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            miAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            miAddPosition = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            pārbaudītNotikumusDarbiniekamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            darbiniekaKartīteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            neizmantotāsAtvaļinājumaDienasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bnavNav).BeginInit();
            bnavNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersonsR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyAdapterManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummasVeids).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummaNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPapildSummas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumuVeidi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotikumi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumuVeidi2).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).BeginInit();
            mySplitContainer1.Panel1.SuspendLayout();
            mySplitContainer1.Panel2.SuspendLayout();
            mySplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsBanks).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bnavNav
            // 
            bnavNav.AddNewItem = null;
            bnavNav.BindingSource = bsPersonsR;
            bnavNav.CountItem = bnavNavCountItem;
            bnavNav.CountItemFormat = " no {0}";
            bnavNav.DeleteItem = null;
            bnavNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavNav.ImageScalingSize = new System.Drawing.Size(23, 26);
            bnavNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tslLabel, bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bnavNavPosItem, bnavNavCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavNav.Location = new System.Drawing.Point(0, 568);
            bnavNav.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavNav.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavNav.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavNav.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavNav.Name = "bnavNav";
            bnavNav.PositionItem = bnavNavPosItem;
            bnavNav.SaveItem = null;
            bnavNav.Size = new System.Drawing.Size(1185, 33);
            bnavNav.TabIndex = 0;
            bnavNav.Text = "myBindingNavigator1";
            // 
            // bsPersonsR
            // 
            bsPersonsR.DataMember = "FK_PERSONS_R_IDP";
            bsPersonsR.DataSource = bsPersons;
            bsPersonsR.Name2 = "bsPersonsR";
            bsPersonsR.Sort = "EDIT_DATE desc";
            bsPersonsR.ListChanged += bsPersonsR_ListChanged;
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "PERSONS";
            bsPersons.Filter = "USED =1";
            bsPersons.MyDataSource = "KlonsAData";
            bsPersons.Name2 = "bsPersons";
            bsPersons.Sort = "ZNAME";
            bsPersons.CurrentChanged += bsPersons_CurrentChanged;
            // 
            // bnavNavCountItem
            // 
            bnavNavCountItem.Name = "bnavNavCountItem";
            bnavNavCountItem.Size = new System.Drawing.Size(50, 30);
            bnavNavCountItem.Text = " no {0}";
            bnavNavCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // tslLabel
            // 
            tslLabel.Name = "tslLabel";
            tslLabel.Size = new System.Drawing.Size(79, 30);
            tslLabel.Text = "Darbinieks:";
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
            // bnavNavPosItem
            // 
            bnavNavPosItem.AutoSize = false;
            bnavNavPosItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavNavPosItem.Name = "bnavNavPosItem";
            bnavNavPosItem.Size = new System.Drawing.Size(56, 23);
            bnavNavPosItem.Text = "0";
            bnavNavPosItem.ToolTipText = "Pašreizējā pozīcija";
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
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 30);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.ToolTipText = "Jauns labojums";
            bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 30);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.ToolTipText = "Dzēst labojumu";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = KlonsF.Properties.Resources.Save1;
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(27, 30);
            tsbSave.Text = "toolStripButton1";
            tsbSave.ToolTipText = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // bsAmati
            // 
            bsAmati.DataMember = "FK_POSITIONS_IDP";
            bsAmati.DataSource = bsPersons;
            bsAmati.Filter = "USED = 1";
            bsAmati.Name2 = "bsAmati";
            bsAmati.Sort = "ID";
            bsAmati.CurrentChanged += bsAmati_CurrentChanged;
            // 
            // PersonsRData1
            // 
            PersonsRData1._ADDRESS = null;
            PersonsRData1._ADVANCE = new decimal(new int[] { 0, 0, 0, 65536 });
            PersonsRData1._APGAD_SK = 0;
            PersonsRData1._BANK_ACC = null;
            PersonsRData1._BANK_ID = null;
            PersonsRData1._BIRTH_DATE = new System.DateTime(0L);
            PersonsRData1._CITY = null;
            PersonsRData1._COMMENTS = null;
            PersonsRData1._COUNTRY = null;
            PersonsRData1._EDIT_DATE = new System.DateTime(0L);
            PersonsRData1._EMAIL = null;
            PersonsRData1._FNAME = null;
            PersonsRData1._GENDER = 0;
            PersonsRData1._ID = 0;
            PersonsRData1._IDP = 0;
            PersonsRData1._IIN0 = new decimal(new int[] { 0, 0, 0, 65536 });
            PersonsRData1._INVALID = 0;
            PersonsRData1._LNAME = null;
            PersonsRData1._NAME_ACCUSATIVE = null;
            PersonsRData1._NAME_DATIVE = null;
            PersonsRData1._NOT_OSA = 0;
            PersonsRData1._PASSPORT_DATE = null;
            PersonsRData1._PASSPORT_ISSUER = null;
            PersonsRData1._PASSPORT_NO = null;
            PersonsRData1._PAY0 = new decimal(new int[] { 0, 0, 0, 65536 });
            PersonsRData1._PENSIONER = 0;
            PersonsRData1._PERSON_CODE = null;
            PersonsRData1._PHONE = null;
            PersonsRData1._POSTAL_CODE = null;
            PersonsRData1._PRET = 0;
            PersonsRData1._PRISONER = 0;
            PersonsRData1._PRISONER_SP = 0;
            PersonsRData1._REPRES = 0;
            PersonsRData1._STATE = null;
            PersonsRData1._TAXDOC_ISSUER = null;
            PersonsRData1._TAXDOC_NO = null;
            PersonsRData1._TAXDOC_SERIAL = null;
            PersonsRData1._TAXREG_NO = null;
            PersonsRData1._TERRITORIAL_CODE = null;
            PersonsRData1._VACATION_DAYS = 0F;
            // 
            // rwPamatdati
            // 
            rwPamatdati.Name = "rwPamatdati";
            rwPamatdati.RowTitle = "Pamatdati";
            rwPamatdati.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwDate
            // 
            rwDate.DataMember = "EDIT_DATE";
            rwDate.DataSource = bsPersonsR;
            rwDate.FormatString = "dd.MM.yyyy";
            rwDate.GridPropertyName = "_EDIT_DATE";
            rwDate.Name = "rwDate";
            rwDate.RowTitle = "Labojuma datums";
            rwDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Date;
            // 
            // rwFName
            // 
            rwFName.DataMember = "FNAME";
            rwFName.DataSource = bsPersonsR;
            rwFName.EditorTemplateName = "shedPersonsText";
            rwFName.GridPropertyName = "_FNAME";
            rwFName.Name = "rwFName";
            rwFName.RowTitle = "Vārds";
            rwFName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwLName
            // 
            rwLName.DataMember = "LNAME";
            rwLName.DataSource = bsPersonsR;
            rwLName.EditorTemplateName = "shedPersonsText";
            rwLName.GridPropertyName = "_LNAME";
            rwLName.Name = "rwLName";
            rwLName.RowTitle = "Uzvārds";
            rwLName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwNameDative
            // 
            rwNameDative.AllowNull = true;
            rwNameDative.DataMember = "NAME_DATIVE";
            rwNameDative.DataSource = bsPersons;
            rwNameDative.EditorTemplateName = "shedPersonsTextAllowNull";
            rwNameDative.GridPropertyName = "_NAME_DATIVE";
            rwNameDative.Name = "rwNameDative";
            rwNameDative.RowTitle = "Vārds datīvā";
            rwNameDative.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rvNameAccusative
            // 
            rvNameAccusative.AllowNull = true;
            rvNameAccusative.DataMember = "NAME_ACCUSATIVE";
            rvNameAccusative.DataSource = bsPersons;
            rvNameAccusative.EditorTemplateName = "shedPersonsTextAllowNull";
            rvNameAccusative.GridPropertyName = "_NAME_ACCUSATIVE";
            rvNameAccusative.Name = "rvNameAccusative";
            rvNameAccusative.RowTitle = "Vārds akuzatīvā";
            rvNameAccusative.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwGender
            // 
            rwGender.DataMember = "GENDER";
            rwGender.DataSource = bsPersons;
            rwGender.GridPropertyName = "_GENDER";
            rwGender.ListStrings = new string[]
    {
    "0;vīrietis",
    "1;sieviete"
    };
            rwGender.Name = "rwGender";
            rwGender.RowTitle = "Dzimums";
            rwGender.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwPersonCode
            // 
            rwPersonCode.AllowNull = true;
            rwPersonCode.DataMember = "PERSON_CODE";
            rwPersonCode.DataSource = bsPersonsR;
            rwPersonCode.EditorTemplateName = "shedPersonsTextAllowNull";
            rwPersonCode.GridPropertyName = "_PERSON_CODE";
            rwPersonCode.Name = "rwPersonCode";
            rwPersonCode.RowTitle = "Personas kods";
            rwPersonCode.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwBirthDate
            // 
            rwBirthDate.DataMember = "BIRTH_DATE";
            rwBirthDate.DataSource = bsPersons;
            rwBirthDate.GridPropertyName = "_BIRTH_DATE";
            rwBirthDate.Name = "rwBirthDate";
            rwBirthDate.RowTitle = "Dzimšanas datums";
            rwBirthDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Date;
            // 
            // rwTAddress
            // 
            rwTAddress.Name = "rwTAddress";
            rwTAddress.RowTitle = "Adrese";
            rwTAddress.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwAddress
            // 
            rwAddress.AllowNull = true;
            rwAddress.DataMember = "ADDRESS";
            rwAddress.DataSource = bsPersons;
            rwAddress.EditorTemplateName = "shedPersonsTextAllowNull";
            rwAddress.FormatString = "";
            rwAddress.GridPropertyName = "_ADDRESS";
            rwAddress.Name = "rwAddress";
            rwAddress.RowTitle = "Adrese";
            rwAddress.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwCity
            // 
            rwCity.AllowNull = true;
            rwCity.DataMember = "CITY";
            rwCity.DataSource = bsPersons;
            rwCity.EditorTemplateName = "shedPersonsTextAllowNull";
            rwCity.FormatString = "";
            rwCity.GridPropertyName = "_CITY";
            rwCity.Name = "rwCity";
            rwCity.RowTitle = "Pilsēta / pagasts";
            rwCity.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwState
            // 
            rwState.AllowNull = true;
            rwState.DataMember = "STATE";
            rwState.DataSource = bsPersons;
            rwState.EditorTemplateName = "shedPersonsTextAllowNull";
            rwState.GridPropertyName = "_STATE";
            rwState.Name = "rwState";
            rwState.RowTitle = "Novads";
            rwState.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwCountry
            // 
            rwCountry.AllowNull = true;
            rwCountry.DataMember = "COUNTRY";
            rwCountry.DataSource = bsPersons;
            rwCountry.EditorTemplateName = "shedPersonsTextAllowNull";
            rwCountry.GridPropertyName = "_COUNTRY";
            rwCountry.Name = "rwCountry";
            rwCountry.RowTitle = "Valsts";
            rwCountry.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPostalCode
            // 
            rwPostalCode.AllowNull = true;
            rwPostalCode.DataMember = "POSTAL_CODE";
            rwPostalCode.DataSource = bsPersons;
            rwPostalCode.EditorTemplateName = "shedPersonsTextAllowNull";
            rwPostalCode.GridPropertyName = "_POSTAL_CODE";
            rwPostalCode.Name = "rwPostalCode";
            rwPostalCode.RowTitle = "Pasta indeks";
            rwPostalCode.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTerCode
            // 
            rwTerCode.AllowNull = true;
            rwTerCode.DataMember = "TERRITORIAL_CODE";
            rwTerCode.DataSource = bsPersonsR;
            rwTerCode.EditorTemplateName = "shedPersonsTextAllowNull";
            rwTerCode.GridPropertyName = "_TERRITORIAL_CODE";
            rwTerCode.Name = "rwTerCode";
            rwTerCode.RowTitle = "Teritorijas kods";
            rwTerCode.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTContact
            // 
            rwTContact.Name = "rwTContact";
            rwTContact.RowTitle = "Kontaktinformācija";
            rwTContact.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwPhone
            // 
            rwPhone.AllowNull = true;
            rwPhone.DataMember = "PHONE";
            rwPhone.DataSource = bsPersons;
            rwPhone.EditorTemplateName = "shedPersonsTextAllowNull";
            rwPhone.GridPropertyName = "_PHONE";
            rwPhone.Name = "rwPhone";
            rwPhone.RowTitle = "Telefona nr.";
            rwPhone.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwEMail
            // 
            rwEMail.AllowNull = true;
            rwEMail.DataMember = "EMAIL";
            rwEMail.DataSource = bsPersons;
            rwEMail.EditorTemplateName = "shedPersonsTextAllowNull";
            rwEMail.GridPropertyName = "_EMAIL";
            rwEMail.Name = "rwEMail";
            rwEMail.RowTitle = "E-pasts";
            rwEMail.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTBank
            // 
            rwTBank.Name = "rwTBank";
            rwTBank.RowTitle = "Bankas konts";
            rwTBank.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwBankAcc
            // 
            rwBankAcc.AllowNull = true;
            rwBankAcc.DataMember = "BANK_ACC";
            rwBankAcc.DataSource = bsPersons;
            rwBankAcc.EditorTemplateName = "shedPersonsTextAllowNull";
            rwBankAcc.GridPropertyName = "_BANK_ACC";
            rwBankAcc.Name = "rwBankAcc";
            rwBankAcc.RowTitle = "Bankas konts";
            rwBankAcc.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTPassp
            // 
            rwTPassp.Name = "rwTPassp";
            rwTPassp.RowTitle = "Pase";
            rwTPassp.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwPasspNo
            // 
            rwPasspNo.AllowNull = true;
            rwPasspNo.DataMember = "PASSPORT_NO";
            rwPasspNo.DataSource = bsPersons;
            rwPasspNo.EditorTemplateName = "shedPersonsTextAllowNull";
            rwPasspNo.GridPropertyName = "_PASSPORT_NO";
            rwPasspNo.Name = "rwPasspNo";
            rwPasspNo.RowTitle = "Pases numurs";
            rwPasspNo.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPasspIssuer
            // 
            rwPasspIssuer.AllowNull = true;
            rwPasspIssuer.DataMember = "PASSPORT_ISSUER";
            rwPasspIssuer.DataSource = bsPersons;
            rwPasspIssuer.EditorTemplateName = "shedPersonsTextAllowNull";
            rwPasspIssuer.GridPropertyName = "_PASSPORT_ISSUER";
            rwPasspIssuer.Name = "rwPasspIssuer";
            rwPasspIssuer.RowTitle = "Pases izdevējs";
            rwPasspIssuer.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPasspDate
            // 
            rwPasspDate.AllowNull = true;
            rwPasspDate.DataMember = "PASSPORT_DATE";
            rwPasspDate.DataSource = bsPersons;
            rwPasspDate.GridPropertyName = "_PASSPORT_DATE";
            rwPasspDate.Name = "rwPasspDate";
            rwPasspDate.RowTitle = "Izdošanas datums";
            rwPasspDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // rwTaxDoc
            // 
            rwTaxDoc.Name = "rwTaxDoc";
            rwTaxDoc.RowTitle = "Nodokļu maksātāja grāmatiņa";
            rwTaxDoc.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwTaxDocSerial
            // 
            rwTaxDocSerial.AllowNull = true;
            rwTaxDocSerial.DataMember = "TAXDOC_SERIAL";
            rwTaxDocSerial.DataSource = bsPersonsR;
            rwTaxDocSerial.EditorTemplateName = "shedPersonsTextAllowNull";
            rwTaxDocSerial.GridPropertyName = "_TAXDOC_SERIAL";
            rwTaxDocSerial.Name = "rwTaxDocSerial";
            rwTaxDocSerial.RowTitle = "Sērija";
            rwTaxDocSerial.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTaxDocNo
            // 
            rwTaxDocNo.AllowNull = true;
            rwTaxDocNo.DataMember = "TAXDOC_NO";
            rwTaxDocNo.DataSource = bsPersonsR;
            rwTaxDocNo.EditorTemplateName = "shedPersonsTextAllowNull";
            rwTaxDocNo.GridPropertyName = "_TAXDOC_NO";
            rwTaxDocNo.Name = "rwTaxDocNo";
            rwTaxDocNo.RowTitle = "Numurs";
            rwTaxDocNo.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTaxDocIssuer
            // 
            rwTaxDocIssuer.AllowNull = true;
            rwTaxDocIssuer.DataMember = "TAXDOC_ISSUER";
            rwTaxDocIssuer.DataSource = bsPersonsR;
            rwTaxDocIssuer.EditorTemplateName = "shedPersonsTextAllowNull";
            rwTaxDocIssuer.GridPropertyName = "_TAXDOC_ISSUER";
            rwTaxDocIssuer.Name = "rwTaxDocIssuer";
            rwTaxDocIssuer.RowTitle = "Izdevējs";
            rwTaxDocIssuer.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTTaxPayer
            // 
            rwTTaxPayer.Name = "rwTTaxPayer";
            rwTTaxPayer.RowTitle = "Nodokļu maksātājs";
            rwTTaxPayer.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwTaxRegNo
            // 
            rwTaxRegNo.AllowNull = true;
            rwTaxRegNo.DataMember = "TAXREG_NO";
            rwTaxRegNo.DataSource = bsPersonsR;
            rwTaxRegNo.EditorTemplateName = "shedPersonsTextAllowNull";
            rwTaxRegNo.GridPropertyName = "_TAXREG_NO";
            rwTaxRegNo.Name = "rwTaxRegNo";
            rwTaxRegNo.RowTitle = "Nodokļu maks.reģ.nr.";
            rwTaxRegNo.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTStatus
            // 
            rwTStatus.Name = "rwTStatus";
            rwTStatus.RowTitle = "Status";
            rwTStatus.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwInvalid
            // 
            rwInvalid.DataMember = "INVALID";
            rwInvalid.DataSource = bsPersonsR;
            rwInvalid.GridPropertyName = "_INVALID";
            rwInvalid.ListStrings = new string[]
    {
    "0;nav",
    "1;1. grupa",
    "2;2. grupa",
    "3;3. grupa"
    };
            rwInvalid.Name = "rwInvalid";
            rwInvalid.RowTitle = "Invalīds";
            rwInvalid.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwPensioner
            // 
            rwPensioner.DataMember = "PENSIONER";
            rwPensioner.DataSource = bsPersonsR;
            rwPensioner.EditorTemplateName = "sharedPersonsNoYes";
            rwPensioner.GridPropertyName = "_PENSIONER";
            rwPensioner.ListStrings = new string[]
    {
    "0;nav",
    "1;ir"
    };
            rwPensioner.Name = "rwPensioner";
            rwPensioner.RowTitle = "Pensionārs";
            rwPensioner.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwPrisoner
            // 
            rwPrisoner.DataMember = "PRISONER";
            rwPrisoner.DataSource = bsPersonsR;
            rwPrisoner.EditorTemplateName = "sharedPersonsNoYes";
            rwPrisoner.GridPropertyName = "_PRISONER";
            rwPrisoner.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            rwPrisoner.Name = "rwPrisoner";
            rwPrisoner.RowTitle = "Cietumnieks";
            rwPrisoner.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwRepres
            // 
            rwRepres.DataMember = "REPRES";
            rwRepres.DataSource = bsPersonsR;
            rwRepres.EditorTemplateName = "sharedPersonsNoYes";
            rwRepres.GridPropertyName = "_REPRES";
            rwRepres.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            rwRepres.Name = "rwRepres";
            rwRepres.RowTitle = "Represētais";
            rwRepres.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwPret
            // 
            rwPret.DataMember = "PRET";
            rwPret.DataSource = bsPersonsR;
            rwPret.EditorTemplateName = "sharedPersonsNoYes";
            rwPret.GridPropertyName = "_PRET";
            rwPret.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            rwPret.Name = "rwPret";
            rwPret.RowTitle = "Pretošanās kust.dalībn.";
            rwPret.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwApgadSk
            // 
            rwApgadSk.DataMember = "APGAD_SK";
            rwApgadSk.DataSource = bsPersonsR;
            rwApgadSk.GridPropertyName = "_APGAD_SK";
            rwApgadSk.Name = "rwApgadSk";
            rwApgadSk.RowTitle = "Apgādājamo sk.";
            rwApgadSk.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            rwApgadSk.TextAllign = KlonsLIB.MySourceGrid.GridRows.ECellTextAllign.Left;
            // 
            // rwTitleCom
            // 
            rwTitleCom.Name = "rwTitleCom";
            rwTitleCom.RowTitle = "Piezīmes";
            rwTitleCom.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // shedPersonsText
            // 
            shedPersonsText.Name = "shedPersonsText";
            shedPersonsText.RowTitle = null;
            shedPersonsText.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // AmatsRData1
            // 
            AmatsRData1._ADVAMCE = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._ADVANCE = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._EDIT_DATE = new System.DateTime(0L);
            AmatsRData1._ID = 0;
            AmatsRData1._IDDEP = null;
            AmatsRData1._IDP = 0;
            AmatsRData1._IIN0 = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._NORMAL_DAY_HOURS = 0;
            AmatsRData1._NORMAL_WEEK_HOURS = 0;
            AmatsRData1._OCCUPATION_CODE = null;
            AmatsRData1._PAY0 = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_HOLIDAY = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_HOLIDAY_NIGHT = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_HOLIDAY_NIGHT_TYPE = 0;
            AmatsRData1._RATE_HOLIDAY_OVERTIME = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_HOLIDAY_OVERTIME_TYPE = 0;
            AmatsRData1._RATE_HOLIDAY_TYPE = 0;
            AmatsRData1._RATE_NIGHT = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_NIGHT_TYPE = 0;
            AmatsRData1._RATE_OVERTIME = new decimal(new int[] { 0, 0, 0, 65536 });
            AmatsRData1._RATE_OVERTIME_TYPE = 0;
            AmatsRData1._SALARY_TYPE = 0;
            AmatsRData1._SIXDAYWEEK = 0;
            AmatsRData1._TITLE = null;
            AmatsRData1._TITLE_ACCUSATIVE = null;
            AmatsRData1._TITLE_DATIVE = null;
            AmatsRData1._USED = 1;
            // 
            // rwAmatiT2
            // 
            rwAmatiT2.Name = "rwAmatiT2";
            rwAmatiT2.RowTitle = "Amata apraksts";
            // 
            // rwAmatiTitle
            // 
            rwAmatiTitle.DataMember = "TITLE";
            rwAmatiTitle.DataSource = bsAmatiR;
            rwAmatiTitle.GridPropertyName = "_TITLE";
            rwAmatiTitle.Name = "rwAmatiTitle";
            rwAmatiTitle.RowTitle = "Nosaukums";
            rwAmatiTitle.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // bsAmatiR
            // 
            bsAmatiR.DataMember = "FK_POSITIONS_R_IDA";
            bsAmatiR.DataSource = bsAmati;
            bsAmatiR.Name2 = "bsAmatiR";
            bsAmatiR.Sort = "EDIT_DATE DESC";
            bsAmatiR.CurrentChanged += bsAmatiR_CurrentChanged;
            bsAmatiR.ListChanged += bsAmatiR_ListChanged;
            // 
            // rwTitleDat
            // 
            rwTitleDat.AllowNull = true;
            rwTitleDat.DataMember = "TITLE_DATIVE";
            rwTitleDat.DataSource = bsAmatiR;
            rwTitleDat.GridPropertyName = "_TITLE_DATIVE";
            rwTitleDat.Name = "rwTitleDat";
            rwTitleDat.RowTitle = "Nosaukums datīvā";
            rwTitleDat.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwAmatiTitleAcc
            // 
            rwAmatiTitleAcc.AllowNull = true;
            rwAmatiTitleAcc.DataMember = "TITLE_ACCUSATIVE";
            rwAmatiTitleAcc.DataSource = bsAmatiR;
            rwAmatiTitleAcc.GridPropertyName = "_TITLE_ACCUSATIVE";
            rwAmatiTitleAcc.Name = "rwAmatiTitleAcc";
            rwAmatiTitleAcc.RowTitle = "Nosaukums akuzatīvā";
            rwAmatiTitleAcc.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwAmatiDep
            // 
            rwAmatiDep.AllowNull = true;
            rwAmatiDep.ColumnNames = new string[]
    {
    "ID",
    "DESCR"
    };
            rwAmatiDep.ColumnWidths = "120;250";
            rwAmatiDep.DataMember = "IDDEP";
            rwAmatiDep.DataSource = bsAmatiR;
            rwAmatiDep.FormatString = "";
            rwAmatiDep.GridPropertyName = "_IDDEP";
            rwAmatiDep.ListDisplayMember = "ID";
            rwAmatiDep.ListSource = bsDep;
            rwAmatiDep.ListValueMember = "ID";
            rwAmatiDep.Name = "rwAmatiDep";
            rwAmatiDep.RowTitle = "Struktūrvienība";
            rwAmatiDep.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // bsDep
            // 
            bsDep.DataMember = "DEPARTMENTS";
            bsDep.MyDataSource = "KlonsAData";
            bsDep.Name2 = "bsDep";
            // 
            // rwAmatiDate
            // 
            rwAmatiDate.DataMember = "EDIT_DATE";
            rwAmatiDate.DataSource = bsAmatiR;
            rwAmatiDate.GridPropertyName = "_EDIT_DATE";
            rwAmatiDate.Name = "rwAmatiDate";
            rwAmatiDate.RowTitle = "Labojuma datums";
            rwAmatiDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Date;
            // 
            // rwAmatiT3
            // 
            rwAmatiT3.Name = "rwAmatiT3";
            rwAmatiT3.RowTitle = "Likmes";
            // 
            // rwAmatiSalarytype
            // 
            rwAmatiSalarytype.DataMember = "SALARY_TYPE";
            rwAmatiSalarytype.DataSource = bsAmatiR;
            rwAmatiSalarytype.GridPropertyName = "_SALARY_TYPE";
            rwAmatiSalarytype.ListStrings = new string[]
    {
    "0;mēneša",
    "1;dienas",
    "2;stundas",
    "3;summētais",
    "4;gabaldarbs"
    };
            rwAmatiSalarytype.Name = "rwAmatiSalarytype";
            rwAmatiSalarytype.RowTitle = "Aprēķina veids";
            rwAmatiSalarytype.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwAmatiRate
            // 
            rwAmatiRate.DataMember = "RATE";
            rwAmatiRate.DataSource = bsAmatiR;
            rwAmatiRate.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRate.GridPropertyName = "_RATE";
            rwAmatiRate.Name = "rwAmatiRate";
            rwAmatiRate.RowTitle = "Pamatlikme";
            rwAmatiRate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiRateNight
            // 
            rwAmatiRateNight.DataMember = "RATE_NIGHT";
            rwAmatiRateNight.DataSource = bsAmatiR;
            rwAmatiRateNight.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRateNight.GridPropertyName = "_RATE_NIGHT";
            rwAmatiRateNight.Name = "rwAmatiRateNight";
            rwAmatiRateNight.RowTitle = "Par darbu naktī";
            rwAmatiRateNight.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiRateOvertime
            // 
            rwAmatiRateOvertime.DataMember = "RATE_OVERTIME";
            rwAmatiRateOvertime.DataSource = bsAmatiR;
            rwAmatiRateOvertime.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRateOvertime.GridPropertyName = "_RATE_OVERTIME";
            rwAmatiRateOvertime.Name = "rwAmatiRateOvertime";
            rwAmatiRateOvertime.RowTitle = "Par virsstundām";
            rwAmatiRateOvertime.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiAdvance
            // 
            rwAmatiAdvance.DataMember = "ADVAMCE";
            rwAmatiAdvance.DataSource = bsAmatiR;
            rwAmatiAdvance.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiAdvance.GridPropertyName = "_ADVAMCE";
            rwAmatiAdvance.Name = "rwAmatiAdvance";
            rwAmatiAdvance.RowTitle = "Avanss";
            rwAmatiAdvance.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // shrwAmariDecimal
            // 
            shrwAmariDecimal.DataMember = null;
            shrwAmariDecimal.Name = "shrwAmariDecimal";
            shrwAmariDecimal.RowTitle = null;
            shrwAmariDecimal.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // shrwAmatiRateType
            // 
            shrwAmatiRateType.DataMember = null;
            shrwAmatiRateType.ListStrings = new string[]
    {
    "0;%",
    "1;€"
    };
            shrwAmatiRateType.Name = "shrwAmatiRateType";
            shrwAmatiRateType.RowTitle = null;
            shrwAmatiRateType.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // cbPersons
            // 
            cbPersons._AllowSelection = true;
            cbPersons.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPersons.ColumnNames = new string[]
    {
    "ZNAME"
    };
            cbPersons.ColumnWidths = "300";
            cbPersons.DataSource = bsPersons;
            cbPersons.DisplayMember = "ZNAME";
            cbPersons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPersons.DropDownHeight = 270;
            cbPersons.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbPersons.DropDownWidth = 319;
            cbPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPersons.FormattingEnabled = true;
            cbPersons.GridLineColor = System.Drawing.Color.LightGray;
            cbPersons.GridLineHorizontal = false;
            cbPersons.GridLineVertical = false;
            cbPersons.IntegralHeight = false;
            cbPersons.Location = new System.Drawing.Point(133, 0);
            cbPersons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbPersons.MaxDropDownItems = 15;
            cbPersons.Name = "cbPersons";
            cbPersons.Size = new System.Drawing.Size(337, 24);
            cbPersons.TabIndex = 4;
            cbPersons.ValueMember = "YNAME";
            // 
            // cbAmati
            // 
            cbAmati._AllowSelection = true;
            cbAmati.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbAmati.ColumnNames = new string[]
    {
    "TITLE"
    };
            cbAmati.ColumnWidths = "121";
            cbAmati.DataSource = bsAmati;
            cbAmati.DisplayMember = "TITLE";
            cbAmati.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbAmati.DropDownHeight = 144;
            cbAmati.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbAmati.DropDownWidth = 140;
            cbAmati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbAmati.FormattingEnabled = true;
            cbAmati.GridLineColor = System.Drawing.Color.LightGray;
            cbAmati.GridLineHorizontal = false;
            cbAmati.GridLineVertical = false;
            cbAmati.IntegralHeight = false;
            cbAmati.Location = new System.Drawing.Point(487, 0);
            cbAmati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbAmati.Name = "cbAmati";
            cbAmati.Size = new System.Drawing.Size(253, 24);
            cbAmati.TabIndex = 5;
            cbAmati.ValueMember = "TITLE";
            // 
            // MyAdapterManager1
            // 
            MyAdapterManager1.MyDataSource = "KlonsAData";
            MyAdapterManager1.TableNames = new string[]
    {
    "PERSONS",
    "PERSONS_R",
    "POSITIONS",
    "POSITIONS_R",
    "POSITIONS_PLUSMINUS",
    "EVENTS",
    null
    };
            // 
            // rwAmatiSixDayWeek
            // 
            rwAmatiSixDayWeek.DataMember = "SIXDAYWEEK";
            rwAmatiSixDayWeek.DataSource = bsAmatiR;
            rwAmatiSixDayWeek.GridPropertyName = "_SIXDAYWEEK";
            rwAmatiSixDayWeek.ListStrings = new string[]
    {
    "0;5 dienu nedēļa",
    "1;6 dienu nedēļa"
    };
            rwAmatiSixDayWeek.Name = "rwAmatiSixDayWeek";
            rwAmatiSixDayWeek.RowTitle = "Darba nedēļa";
            rwAmatiSixDayWeek.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwAmatiNormalDayHours
            // 
            rwAmatiNormalDayHours.DataMember = "NORMAL_DAY_HOURS";
            rwAmatiNormalDayHours.DataSource = bsAmatiR;
            rwAmatiNormalDayHours.GridPropertyName = "_NORMAL_DAY_HOURS";
            rwAmatiNormalDayHours.Name = "rwAmatiNormalDayHours";
            rwAmatiNormalDayHours.RowTitle = "Stundas darba dienā";
            rwAmatiNormalDayHours.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // rwAmatiNormalWeekHours
            // 
            rwAmatiNormalWeekHours.DataMember = "NORMAL_WEEK_HOURS";
            rwAmatiNormalWeekHours.DataSource = bsAmatiR;
            rwAmatiNormalWeekHours.GridPropertyName = "_NORMAL_WEEK_HOURS";
            rwAmatiNormalWeekHours.Name = "rwAmatiNormalWeekHours";
            rwAmatiNormalWeekHours.RowTitle = "Stundas darba nedēļā";
            rwAmatiNormalWeekHours.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Integer;
            // 
            // rwComments2
            // 
            rwComments2.AllowNull = true;
            rwComments2.DataMember = "COMMENTS";
            rwComments2.DataSource = bsPersons;
            rwComments2.GridPropertyName = "_COMMENTS";
            rwComments2.Name = "rwComments2";
            rwComments2.RowSpan = 8;
            rwComments2.RowTitle = "komentāri";
            // 
            // bsAmatiPS
            // 
            bsAmatiPS.DataMember = "FK_POSITIONS_IDP";
            bsAmatiPS.DataSource = bsPersons;
            bsAmatiPS.Name2 = "bsAmati2";
            bsAmatiPS.Sort = "ID";
            // 
            // bsPapildSummasVeids
            // 
            bsPapildSummasVeids.DataMember = "PLUSMINUS_TYPES";
            bsPapildSummasVeids.Filter = "TP3 = 1";
            bsPapildSummasVeids.MyDataSource = "KlonsAData";
            bsPapildSummasVeids.Sort = "SN";
            // 
            // bsPapildSummaNo
            // 
            bsPapildSummaNo.DataMember = "PLUSMINUS_FROM";
            bsPapildSummaNo.MyDataSource = "KlonsAData";
            // 
            // bsPapildSummas
            // 
            bsPapildSummas.DataMember = "FK_POSITIONS_PLUSMINUS_IDP";
            bsPapildSummas.DataSource = bsPersons;
            bsPapildSummas.Sort = "DATE1";
            bsPapildSummas.UseDataGridView = dgvPapildSummas;
            bsPapildSummas.ListChanged += bsPapildSummas_ListChanged;
            // 
            // dgvPapildSummas
            // 
            dgvPapildSummas.AutoGenerateColumns = false;
            dgvPapildSummas.AutoSave = false;
            dgvPapildSummas.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPapildSummas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPapildSummas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPapildSummas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcPSIDA, dgcPSDate1, dgcPSDate2, dgcPSDescr, dgcPSIDSV2, dgcPSRate, dgcPSRateType, dgcPSIDNO, dgcPSIsPaid, dgcPSIsInAvpay, dgcPSID });
            dgvPapildSummas.DataSource = bsPapildSummas;
            dgvPapildSummas.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPapildSummas.Location = new System.Drawing.Point(3, 4);
            dgvPapildSummas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPapildSummas.Name = "dgvPapildSummas";
            dgvPapildSummas.RowHeadersWidth = 53;
            dgvPapildSummas.ShowCellToolTips = false;
            dgvPapildSummas.Size = new System.Drawing.Size(964, 506);
            dgvPapildSummas.TabIndex = 0;
            dgvPapildSummas.CellBeginEdit += dgvPapildSummas_CellBeginEdit;
            dgvPapildSummas.CellEndEdit += dgvPapildSummas_CellEndEdit;
            dgvPapildSummas.CellParsing += dgvPapildSummas_CellParsing;
            dgvPapildSummas.DefaultValuesNeeded += dgvPapildSummas_DefaultValuesNeeded;
            dgvPapildSummas.UserDeletingRow += dgvPapildSummas_UserDeletingRow;
            dgvPapildSummas.Enter += dgvPapildSummas_Enter;
            dgvPapildSummas.KeyDown += dgvPapildSummas_KeyDown;
            // 
            // dgcPSIDA
            // 
            dgcPSIDA.DataPropertyName = "IDA";
            dgcPSIDA.DataSource = bsAmatiPS;
            dgcPSIDA.DisplayMember = "TITLE";
            dgcPSIDA.DisplayStyleForCurrentCellOnly = true;
            dgcPSIDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcPSIDA.HeaderText = "amats";
            dgcPSIDA.MinimumWidth = 7;
            dgcPSIDA.Name = "dgcPSIDA";
            dgcPSIDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPSIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPSIDA.ValueMember = "ID";
            dgcPSIDA.Width = 168;
            // 
            // dgcPSDate1
            // 
            dgcPSDate1.DataPropertyName = "DATE1";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcPSDate1.DefaultCellStyle = dataGridViewCellStyle2;
            dgcPSDate1.HeaderText = "dat. no";
            dgcPSDate1.MinimumWidth = 7;
            dgcPSDate1.Name = "dgcPSDate1";
            dgcPSDate1.Width = 85;
            // 
            // dgcPSDate2
            // 
            dgcPSDate2.DataPropertyName = "DATE2";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            dgcPSDate2.DefaultCellStyle = dataGridViewCellStyle3;
            dgcPSDate2.HeaderText = "dat. līdz";
            dgcPSDate2.MinimumWidth = 7;
            dgcPSDate2.Name = "dgcPSDate2";
            dgcPSDate2.Width = 85;
            // 
            // dgcPSDescr
            // 
            dgcPSDescr.DataPropertyName = "DESCR";
            dgcPSDescr.HeaderText = "apraksts";
            dgcPSDescr.MinimumWidth = 7;
            dgcPSDescr.Name = "dgcPSDescr";
            dgcPSDescr.Width = 225;
            // 
            // dgcPSIDSV2
            // 
            dgcPSIDSV2.ColumnNames = new string[]
    {
    "DESCR2",
    "DESCR"
    };
            dgcPSIDSV2.ColumnWidths = "100;270";
            dgcPSIDSV2.DataPropertyName = "IDSV";
            dgcPSIDSV2.DataSource = bsPapildSummasVeids;
            dgcPSIDSV2.DisplayMember = "DESCR2";
            dgcPSIDSV2.DisplayStyleForCurrentCellOnly = true;
            dgcPSIDSV2.DropDownStyle = MyDgvMcComboBox.CustomDropDownStyle.DropDownListSimple;
            dgcPSIDSV2.HeaderText = "piem. veids";
            dgcPSIDSV2.MaxDropDownItems = 15;
            dgcPSIDSV2.MinimumWidth = 7;
            dgcPSIDSV2.Name = "dgcPSIDSV2";
            dgcPSIDSV2.ToolTipText = "piemaksas veids";
            dgcPSIDSV2.ValueMember = "ID";
            dgcPSIDSV2.Width = 135;
            // 
            // dgcPSRate
            // 
            dgcPSRate.DataPropertyName = "RATE";
            dgcPSRate.HeaderText = "likme";
            dgcPSRate.MinimumWidth = 7;
            dgcPSRate.Name = "dgcPSRate";
            dgcPSRate.Width = 146;
            // 
            // dgcPSRateType
            // 
            dgcPSRateType.DataPropertyName = "RATE_TYPE";
            dgcPSRateType.DisplayStyleForCurrentCellOnly = true;
            dgcPSRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcPSRateType.HeaderText = "%/€";
            dgcPSRateType.MinimumWidth = 7;
            dgcPSRateType.Name = "dgcPSRateType";
            dgcPSRateType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPSRateType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPSRateType.Width = 67;
            // 
            // dgcPSIDNO
            // 
            dgcPSIDNO.DataPropertyName = "IDNO";
            dgcPSIDNO.DataSource = bsPapildSummaNo;
            dgcPSIDNO.DisplayMember = "DESCR";
            dgcPSIDNO.DisplayStyleForCurrentCellOnly = true;
            dgcPSIDNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcPSIDNO.HeaderText = "aprēķina no";
            dgcPSIDNO.MinimumWidth = 7;
            dgcPSIDNO.Name = "dgcPSIDNO";
            dgcPSIDNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPSIDNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPSIDNO.ValueMember = "ID";
            dgcPSIDNO.Width = 225;
            // 
            // dgcPSIsPaid
            // 
            dgcPSIsPaid.DataPropertyName = "IS_PAID";
            dgcPSIsPaid.FalseValue = "0";
            dgcPSIsPaid.HeaderText = "izm.";
            dgcPSIsPaid.MinimumWidth = 7;
            dgcPSIsPaid.Name = "dgcPSIsPaid";
            dgcPSIsPaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcPSIsPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcPSIsPaid.ToolTipText = "Izmaksājama piemaksa";
            dgcPSIsPaid.TrueValue = "1";
            dgcPSIsPaid.Width = 45;
            // 
            // dgcPSIsInAvpay
            // 
            dgcPSIsInAvpay.DataPropertyName = "IS_INAVPAY";
            dgcPSIsInAvpay.FalseValue = "0";
            dgcPSIsInAvpay.HeaderText = "ir VI";
            dgcPSIsInAvpay.MinimumWidth = 7;
            dgcPSIsInAvpay.Name = "dgcPSIsInAvpay";
            dgcPSIsInAvpay.ToolTipText = "Iekļaut vidējās izpeļņas aprēķinā";
            dgcPSIsInAvpay.TrueValue = "1";
            dgcPSIsInAvpay.Width = 45;
            // 
            // dgcPSID
            // 
            dgcPSID.DataPropertyName = "ID";
            dgcPSID.HeaderText = "ID";
            dgcPSID.MinimumWidth = 7;
            dgcPSID.Name = "dgcPSID";
            dgcPSID.Visible = false;
            dgcPSID.Width = 146;
            // 
            // bsNotikumuVeidi
            // 
            bsNotikumuVeidi.DataMember = "EVENT_TYPES";
            bsNotikumuVeidi.MyDataSource = "KlonsAData";
            bsNotikumuVeidi.Sort = "SN";
            // 
            // bsAmati2
            // 
            bsAmati2.DataMember = "FK_POSITIONS_IDP";
            bsAmati2.DataSource = bsPersons;
            bsAmati2.Name2 = "bsAmati2";
            bsAmati2.Sort = "ID";
            // 
            // bsNotikumi
            // 
            bsNotikumi.DataMember = "FK_EVENTS_IDP";
            bsNotikumi.DataSource = bsPersons;
            bsNotikumi.Sort = "DATE1";
            bsNotikumi.UseDataGridView = dgvNotikumi;
            bsNotikumi.CurrentChanged += bsNotikumi_CurrentChanged;
            bsNotikumi.ListChanged += bsNotikumi_ListChanged;
            // 
            // dgvNotikumi
            // 
            dgvNotikumi.AutoGenerateColumns = false;
            dgvNotikumi.AutoSave = false;
            dgvNotikumi.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvNotikumi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvNotikumi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotikumi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcNotIDN, dgcNotIDN2, dgcNotIDA, dgcNotDate1, dgcNotDate2, dgcNotDT3, dgcNotDescr, dgcNotDocNr, dgcNotDays, dgcNotDays2, dgcNotSCode, dgcNotOcc, dgcNotID, dgcNotIDP });
            dgvNotikumi.DataSource = bsNotikumi;
            dgvNotikumi.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvNotikumi.Location = new System.Drawing.Point(3, 4);
            dgvNotikumi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvNotikumi.Name = "dgvNotikumi";
            dgvNotikumi.RowHeadersWidth = 53;
            dgvNotikumi.ShowCellToolTips = false;
            dgvNotikumi.Size = new System.Drawing.Size(964, 506);
            dgvNotikumi.TabIndex = 0;
            dgvNotikumi.CellEndEdit += dgvNotikumi_CellEndEdit;
            dgvNotikumi.CellParsing += dgvNotikumi_CellParsing;
            dgvNotikumi.DefaultValuesNeeded += dgvNotikumi_DefaultValuesNeeded;
            dgvNotikumi.RowValidating += dgvNotikumi_RowValidating;
            dgvNotikumi.UserDeletingRow += dgvNotikumi_UserDeletingRow;
            dgvNotikumi.Enter += dgvNotikumi_Enter;
            dgvNotikumi.KeyDown += dgvNotikumi_KeyDown;
            // 
            // dgcNotIDN
            // 
            dgcNotIDN.DataPropertyName = "IDN";
            dgcNotIDN.DataSource = bsNotikumuVeidi;
            dgcNotIDN.DisplayMember = "DESCR";
            dgcNotIDN.DisplayStyleForCurrentCellOnly = true;
            dgcNotIDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            dgcNotIDN.HeaderText = "notikums";
            dgcNotIDN.MaxDropDownItems = 15;
            dgcNotIDN.MinimumWidth = 7;
            dgcNotIDN.Name = "dgcNotIDN";
            dgcNotIDN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcNotIDN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcNotIDN.ValueMember = "ID";
            dgcNotIDN.Width = 168;
            // 
            // dgcNotIDN2
            // 
            dgcNotIDN2.ColumnNames = new string[]
    {
    "TAG",
    "DESCR"
    };
            dgcNotIDN2.ColumnWidths = "100;200";
            dgcNotIDN2.DataPropertyName = "IDN2";
            dgcNotIDN2.DataSource = bsNotikumuVeidi2;
            dgcNotIDN2.DisplayMember = "DESCR";
            dgcNotIDN2.DisplayStyleForCurrentCellOnly = true;
            dgcNotIDN2.DropDownWidth = 300;
            dgcNotIDN2.HeaderText = "cits notikums";
            dgcNotIDN2.MaxDropDownItems = 15;
            dgcNotIDN2.MinimumWidth = 7;
            dgcNotIDN2.Name = "dgcNotIDN2";
            dgcNotIDN2.NullToDBNull = true;
            dgcNotIDN2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcNotIDN2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcNotIDN2.ValueMember = "ID";
            dgcNotIDN2.Width = 168;
            // 
            // bsNotikumuVeidi2
            // 
            bsNotikumuVeidi2.DataMember = "EVENT_TYPES2";
            bsNotikumuVeidi2.MyDataSource = "KlonsAData";
            bsNotikumuVeidi2.Sort = "TAG";
            // 
            // dgcNotIDA
            // 
            dgcNotIDA.ColumnNames = new string[]
    {
    "TITLE"
    };
            dgcNotIDA.ColumnWidths = "150";
            dgcNotIDA.DataPropertyName = "IDA";
            dgcNotIDA.DataSource = bsAmati2;
            dgcNotIDA.DisplayMember = "TITLE";
            dgcNotIDA.DisplayStyleForCurrentCellOnly = true;
            dgcNotIDA.DropDownStyle = MyDgvMcComboBox.CustomDropDownStyle.DropDownList;
            dgcNotIDA.HeaderText = "amats";
            dgcNotIDA.MinimumWidth = 7;
            dgcNotIDA.Name = "dgcNotIDA";
            dgcNotIDA.NullToDBNull = true;
            dgcNotIDA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcNotIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcNotIDA.ValueMember = "ID";
            dgcNotIDA.Width = 225;
            // 
            // dgcNotDate1
            // 
            dgcNotDate1.DataPropertyName = "DATE1";
            dataGridViewCellStyle5.Format = "dd.MM.yyyy";
            dgcNotDate1.DefaultCellStyle = dataGridViewCellStyle5;
            dgcNotDate1.HeaderText = "dat.no";
            dgcNotDate1.MinimumWidth = 7;
            dgcNotDate1.Name = "dgcNotDate1";
            dgcNotDate1.Width = 85;
            // 
            // dgcNotDate2
            // 
            dgcNotDate2.DataPropertyName = "DATE2";
            dataGridViewCellStyle6.Format = "dd.MM.yyyy";
            dgcNotDate2.DefaultCellStyle = dataGridViewCellStyle6;
            dgcNotDate2.HeaderText = "dat.līdz";
            dgcNotDate2.MinimumWidth = 7;
            dgcNotDate2.Name = "dgcNotDate2";
            dgcNotDate2.Width = 85;
            // 
            // dgcNotDT3
            // 
            dgcNotDT3.DataPropertyName = "DATE3";
            dataGridViewCellStyle7.Format = "dd.MM.yyyy";
            dgcNotDT3.DefaultCellStyle = dataGridViewCellStyle7;
            dgcNotDT3.HeaderText = "izm.dat.";
            dgcNotDT3.MinimumWidth = 7;
            dgcNotDT3.Name = "dgcNotDT3";
            dgcNotDT3.ToolTipText = "izmaksas datums";
            dgcNotDT3.Width = 85;
            // 
            // dgcNotDescr
            // 
            dgcNotDescr.DataPropertyName = "DESCR";
            dgcNotDescr.HeaderText = "apraksts";
            dgcNotDescr.MinimumWidth = 7;
            dgcNotDescr.Name = "dgcNotDescr";
            dgcNotDescr.Width = 225;
            // 
            // dgcNotDocNr
            // 
            dgcNotDocNr.DataPropertyName = "DOCNR";
            dgcNotDocNr.HeaderText = "dok.nr.";
            dgcNotDocNr.MinimumWidth = 7;
            dgcNotDocNr.Name = "dgcNotDocNr";
            dgcNotDocNr.Width = 146;
            // 
            // dgcNotDays
            // 
            dgcNotDays.DataPropertyName = "DAYS";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "0.###;-0.###;\"\"";
            dgcNotDays.DefaultCellStyle = dataGridViewCellStyle8;
            dgcNotDays.HeaderText = "atv.d.";
            dgcNotDays.MinimumWidth = 7;
            dgcNotDays.Name = "dgcNotDays";
            dgcNotDays.ToolTipText = "Atvaļinājuma dienu skaits";
            dgcNotDays.Width = 56;
            // 
            // dgcNotDays2
            // 
            dgcNotDays2.DataPropertyName = "DAYS2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "0.###;-0.###;\"\"";
            dgcNotDays2.DefaultCellStyle = dataGridViewCellStyle9;
            dgcNotDays2.HeaderText = "apm.atv.d.";
            dgcNotDays2.MinimumWidth = 7;
            dgcNotDays2.Name = "dgcNotDays2";
            dgcNotDays2.ToolTipText = "Apmaksājāmās atvaļinājuma dienas";
            dgcNotDays2.Width = 90;
            // 
            // dgcNotSCode
            // 
            dgcNotSCode.DataPropertyName = "SCODE";
            dgcNotSCode.HeaderText = "kods";
            dgcNotSCode.MinimumWidth = 7;
            dgcNotSCode.Name = "dgcNotSCode";
            dgcNotSCode.ToolTipText = "ziņu kods";
            dgcNotSCode.Width = 56;
            // 
            // dgcNotOcc
            // 
            dgcNotOcc.DataPropertyName = "OCCUPATION_CODE";
            dgcNotOcc.HeaderText = "prof.kods";
            dgcNotOcc.MinimumWidth = 7;
            dgcNotOcc.Name = "dgcNotOcc";
            dgcNotOcc.ToolTipText = "Profesijas kods";
            dgcNotOcc.Width = 90;
            // 
            // dgcNotID
            // 
            dgcNotID.DataPropertyName = "ID";
            dgcNotID.HeaderText = "ID";
            dgcNotID.MinimumWidth = 7;
            dgcNotID.Name = "dgcNotID";
            dgcNotID.Visible = false;
            dgcNotID.Width = 56;
            // 
            // dgcNotIDP
            // 
            dgcNotIDP.DataPropertyName = "IDP";
            dgcNotIDP.HeaderText = "IDP";
            dgcNotIDP.MinimumWidth = 7;
            dgcNotIDP.Name = "dgcNotIDP";
            dgcNotIDP.Visible = false;
            dgcNotIDP.Width = 146;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbArrow1, toolStripLabel2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1185, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // lbArrow1
            // 
            lbArrow1.Name = "lbArrow1";
            lbArrow1.Size = new System.Drawing.Size(22, 22);
            lbArrow1.Text = "→";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.RightToLeftAutoMirrorImage = true;
            toolStripLabel2.Size = new System.Drawing.Size(22, 22);
            toolStripLabel2.Text = "→";
            // 
            // cbDates
            // 
            cbDates._AllowSelection = true;
            cbDates.BorderColor = System.Drawing.SystemColors.Control;
            cbDates.ColumnNames = new string[]
    {
    "EDIT_DATE"
    };
            cbDates.ColumnWidths = "100";
            cbDates.DataSource = bsPersonsR;
            cbDates.DisplayMember = "EDIT_DATE";
            cbDates.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbDates.DropDownHeight = 144;
            cbDates.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbDates.DropDownWidth = 119;
            cbDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbDates.FormattingEnabled = true;
            cbDates.GridLineColor = System.Drawing.Color.LightGray;
            cbDates.GridLineHorizontal = false;
            cbDates.GridLineVertical = false;
            cbDates.IntegralHeight = false;
            cbDates.Location = new System.Drawing.Point(693, 565);
            cbDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbDates.Name = "cbDates";
            cbDates.Size = new System.Drawing.Size(112, 24);
            cbDates.TabIndex = 12;
            cbDates.ValueMember = "EDIT_DATE";
            cbDates.Format += cbDates_Format;
            // 
            // cbSelectTab
            // 
            cbSelectTab.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbSelectTab.ColumnNames = new string[]
    {
    "col1"
    };
            cbSelectTab.ColumnWidths = "121";
            cbSelectTab.DisplayMember = "col1";
            cbSelectTab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbSelectTab.DropDownHeight = 270;
            cbSelectTab.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbSelectTab.DropDownWidth = 140;
            cbSelectTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbSelectTab.FormattingEnabled = true;
            cbSelectTab.GridLineColor = System.Drawing.Color.LightGray;
            cbSelectTab.GridLineHorizontal = false;
            cbSelectTab.GridLineVertical = false;
            cbSelectTab.IntegralHeight = false;
            myItem1.Col1 = "pamatdati";
            myItem2.Col1 = "piemaksas";
            myItem3.Col1 = "atvilkumi";
            myItem4.Col1 = "pieņemts/atlaists";
            myItem5.Col1 = "atvaļinājumi";
            myItem6.Col1 = "slimības";
            myItem7.Col1 = "citi notikumi";
            myItem8.Col1 = "visi notikumi";
            cbSelectTab.Items.AddRange(new object[] { myItem1, myItem2, myItem3, myItem4, myItem5, myItem6, myItem7, myItem8 });
            cbSelectTab.ItemStrings = new string[]
    {
    "pamatdati",
    "piemaksas",
    "atvilkumi",
    "pieņemts/atlaists",
    "atvaļinājumi",
    "slimības",
    "citi notikumi",
    "visi notikumi"
    };
            cbSelectTab.Location = new System.Drawing.Point(760, 0);
            cbSelectTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            cbSelectTab.MaxDropDownItems = 15;
            cbSelectTab.Name = "cbSelectTab";
            cbSelectTab.Size = new System.Drawing.Size(147, 24);
            cbSelectTab.TabIndex = 13;
            cbSelectTab.ValueMember = "col1";
            cbSelectTab.SelectedIndexChanged += cbSelectTab_SelectedIndexChanged;
            // 
            // mySplitContainer1
            // 
            mySplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            mySplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            mySplitContainer1.Location = new System.Drawing.Point(0, 25);
            mySplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            mySplitContainer1.Name = "mySplitContainer1";
            // 
            // mySplitContainer1.Panel1
            // 
            mySplitContainer1.Panel1.Controls.Add(dgvPersons);
            mySplitContainer1.Panel1.Controls.Add(panel1);
            mySplitContainer1.Panel1MinSize = 28;
            // 
            // mySplitContainer1.Panel2
            // 
            mySplitContainer1.Panel2.Controls.Add(tabControl1);
            mySplitContainer1.Panel2MinSize = 28;
            mySplitContainer1.Size = new System.Drawing.Size(1185, 543);
            mySplitContainer1.SplitterDistance = 200;
            mySplitContainer1.SplitterWidth = 7;
            mySplitContainer1.TabIndex = 14;
            // 
            // dgvPersons
            // 
            dgvPersons.AllowUserToAddRows = false;
            dgvPersons.AllowUserToDeleteRows = false;
            dgvPersons.AllowUserToResizeRows = false;
            dgvPersons.AutoGenerateColumns = false;
            dgvPersons.AutoSave = false;
            dgvPersons.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcPersonsYName });
            dgvPersons.DataSource = bsPersons;
            dgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPersons.Location = new System.Drawing.Point(0, 29);
            dgvPersons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.ReadOnly = true;
            dgvPersons.RowHeadersVisible = false;
            dgvPersons.RowHeadersWidth = 53;
            dgvPersons.ShowCellToolTips = false;
            dgvPersons.Size = new System.Drawing.Size(200, 514);
            dgvPersons.TabIndex = 0;
            // 
            // dgcPersonsYName
            // 
            dgcPersonsYName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgcPersonsYName.DataPropertyName = "YNAME";
            dgcPersonsYName.HeaderText = "darbinieks";
            dgcPersonsYName.MinimumWidth = 7;
            dgcPersonsYName.Name = "dgcPersonsYName";
            dgcPersonsYName.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbFindPerson);
            panel1.Controls.Add(btNextPerson);
            panel1.Controls.Add(btPrevPerson);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(3);
            panel1.Size = new System.Drawing.Size(200, 29);
            panel1.TabIndex = 2;
            // 
            // tbFindPerson
            // 
            tbFindPerson.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbFindPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            tbFindPerson.Location = new System.Drawing.Point(28, 3);
            tbFindPerson.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            tbFindPerson.Name = "tbFindPerson";
            tbFindPerson.Size = new System.Drawing.Size(144, 23);
            tbFindPerson.TabIndex = 5;
            tbFindPerson.KeyDown += tstbFindPerson_KeyDown;
            // 
            // btNextPerson
            // 
            btNextPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btNextPerson.Dock = System.Windows.Forms.DockStyle.Right;
            btNextPerson.FlatAppearance.BorderSize = 0;
            btNextPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btNextPerson.Location = new System.Drawing.Point(172, 3);
            btNextPerson.Name = "btNextPerson";
            btNextPerson.Size = new System.Drawing.Size(25, 23);
            btNextPerson.TabIndex = 4;
            btNextPerson.Text = ">";
            btNextPerson.UseVisualStyleBackColor = true;
            btNextPerson.Click += tsbNextPerson_Click;
            // 
            // btPrevPerson
            // 
            btPrevPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btPrevPerson.Dock = System.Windows.Forms.DockStyle.Left;
            btPrevPerson.FlatAppearance.BorderSize = 0;
            btPrevPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btPrevPerson.Location = new System.Drawing.Point(3, 3);
            btPrevPerson.Margin = new System.Windows.Forms.Padding(0);
            btPrevPerson.Name = "btPrevPerson";
            btPrevPerson.Size = new System.Drawing.Size(25, 23);
            btPrevPerson.TabIndex = 3;
            btPrevPerson.Text = "<";
            btPrevPerson.UseVisualStyleBackColor = true;
            btPrevPerson.Click += tsbPrevPerson_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(978, 543);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(sgrAmati);
            tabPage1.Controls.Add(sgrPersR);
            tabPage1.Location = new System.Drawing.Point(4, 25);
            tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage1.Size = new System.Drawing.Size(970, 514);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "pamatdati";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // sgrAmati
            // 
            sgrAmati.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            sgrAmati.BackColor2 = System.Drawing.SystemColors.Window;
            sgrAmati.ColumnWidth1 = 20;
            sgrAmati.ColumnWidth2 = 170;
            sgrAmati.ColumnWidth3 = 160;
            sgrAmati.EnableSort = true;
            sgrAmati.Location = new System.Drawing.Point(412, 1);
            sgrAmati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sgrAmati.MyDataBC = AmatsRData1;
            sgrAmati.Name = "sgrAmati";
            sgrAmati.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            sgrAmati.RowList.Add(rwAmatiT2);
            sgrAmati.RowList.Add(rwAmatiTitle);
            sgrAmati.RowList.Add(rwTitleDat);
            sgrAmati.RowList.Add(rwAmatiTitleAcc);
            sgrAmati.RowList.Add(rwAmatiDep);
            sgrAmati.RowList.Add(rwAmatiDate);
            sgrAmati.RowList.Add(rwAmatiSaldoTitle);
            sgrAmati.RowList.Add(rwAmatiSaldoPay0);
            sgrAmati.RowList.Add(rwAmatiSaldoIIN0);
            sgrAmati.RowList.Add(rwSaldoAdvance);
            sgrAmati.RowList.Add(rwAmatiT3);
            sgrAmati.RowList.Add(rwAmatiSixDayWeek);
            sgrAmati.RowList.Add(rwAmatiNormalDayHours);
            sgrAmati.RowList.Add(rwAmatiNormalWeekHours);
            sgrAmati.RowList.Add(rwAmatiSalarytype);
            sgrAmati.RowList.Add(rwAmatiRate);
            sgrAmati.RowList.Add(rwAmatiAdvance);
            sgrAmati.RowList.Add(rwAmatiRateTitle1);
            sgrAmati.RowList.Add(rwAmatiRateNight);
            sgrAmati.RowList.Add(rwAmatiRateOvertime);
            sgrAmati.RowList.Add(rwAmatiRateTitle2);
            sgrAmati.RowList.Add(rwAmatiRateH);
            sgrAmati.RowList.Add(rwAmatiRateHN);
            sgrAmati.RowList.Add(rwAmatiRateHO);
            sgrAmati.RowTemplateList.Add(shrwAmariDecimal);
            sgrAmati.RowTemplateList.Add(shrwAmatiRateType);
            sgrAmati.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            sgrAmati.Size = new System.Drawing.Size(380, 503);
            sgrAmati.TabIndex = 9;
            sgrAmati.TabStop = true;
            sgrAmati.ToolTipText = "";
            sgrAmati.EditEnded += sgrAmati_EditEnded;
            sgrAmati.Enter += sgrAmati_Enter;
            sgrAmati.MouseDoubleClick += sgrAmati_MouseDoubleClick;
            sgrAmati.PreviewKeyDown += sgrAmati_PreviewKeyDown;
            // 
            // rwAmatiSaldoTitle
            // 
            rwAmatiSaldoTitle.Name = "rwAmatiSaldoTitle";
            rwAmatiSaldoTitle.RowTitle = "Atlikumi uz sākumu";
            // 
            // rwAmatiSaldoPay0
            // 
            rwAmatiSaldoPay0.DataMember = "PAY0";
            rwAmatiSaldoPay0.DataSource = bsAmati;
            rwAmatiSaldoPay0.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiSaldoPay0.GridPropertyName = "_PAY0";
            rwAmatiSaldoPay0.Name = "rwAmatiSaldoPay0";
            rwAmatiSaldoPay0.RowTitle = "Nav samaksāts";
            rwAmatiSaldoPay0.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiSaldoIIN0
            // 
            rwAmatiSaldoIIN0.DataMember = "IIN0";
            rwAmatiSaldoIIN0.DataSource = bsAmati;
            rwAmatiSaldoIIN0.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiSaldoIIN0.GridPropertyName = "_IIN0";
            rwAmatiSaldoIIN0.Name = "rwAmatiSaldoIIN0";
            rwAmatiSaldoIIN0.RowTitle = "Neieturēts IIN";
            rwAmatiSaldoIIN0.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwSaldoAdvance
            // 
            rwSaldoAdvance.DataMember = "ADVANCE";
            rwSaldoAdvance.DataSource = bsAmati;
            rwSaldoAdvance.EditorTemplateName = "shrwAmariDecimal";
            rwSaldoAdvance.GridPropertyName = "_ADVANCE";
            rwSaldoAdvance.Name = "rwSaldoAdvance";
            rwSaldoAdvance.RowTitle = "Avanss";
            rwSaldoAdvance.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiRateTitle1
            // 
            rwAmatiRateTitle1.Name = "rwAmatiRateTitle1";
            rwAmatiRateTitle1.RowTitle = "Piemaksas %";
            rwAmatiRateTitle1.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.SubTitle;
            // 
            // rwAmatiRateTitle2
            // 
            rwAmatiRateTitle2.Name = "rwAmatiRateTitle2";
            rwAmatiRateTitle2.RowTitle = "Piemaksas par darbu svētku dienās %";
            rwAmatiRateTitle2.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.SubTitle;
            // 
            // rwAmatiRateH
            // 
            rwAmatiRateH.DataMember = "RATE_HOLIDAY";
            rwAmatiRateH.DataSource = bsAmatiR;
            rwAmatiRateH.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRateH.GridPropertyName = "_RATE_HOLIDAY";
            rwAmatiRateH.Name = "rwAmatiRateH";
            rwAmatiRateH.RowTitle = "Piemaksa";
            rwAmatiRateH.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiRateHN
            // 
            rwAmatiRateHN.DataMember = "RATE_HOLIDAY_NIGHT";
            rwAmatiRateHN.DataSource = bsAmatiR;
            rwAmatiRateHN.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRateHN.GridPropertyName = "_RATE_HOLIDAY_NIGHT";
            rwAmatiRateHN.Name = "rwAmatiRateHN";
            rwAmatiRateHN.RowTitle = "Par darbu naktī";
            rwAmatiRateHN.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwAmatiRateHO
            // 
            rwAmatiRateHO.DataMember = "RATE_HOLIDAY_OVERTIME";
            rwAmatiRateHO.DataSource = bsAmatiR;
            rwAmatiRateHO.EditorTemplateName = "shrwAmariDecimal";
            rwAmatiRateHO.GridPropertyName = "_RATE_HOLIDAY_OVERTIME";
            rwAmatiRateHO.Name = "rwAmatiRateHO";
            rwAmatiRateHO.RowTitle = "Par virsstundām";
            rwAmatiRateHO.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // sgrPersR
            // 
            sgrPersR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            sgrPersR.BackColor2 = System.Drawing.SystemColors.Window;
            sgrPersR.ColumnWidth1 = 20;
            sgrPersR.ColumnWidth2 = 190;
            sgrPersR.ColumnWidth3 = 150;
            sgrPersR.EnableSort = true;
            sgrPersR.Location = new System.Drawing.Point(1, 1);
            sgrPersR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            sgrPersR.MyDataBC = PersonsRData1;
            sgrPersR.Name = "sgrPersR";
            sgrPersR.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            sgrPersR.RowList.Add(rwPamatdati);
            sgrPersR.RowList.Add(rwDate);
            sgrPersR.RowList.Add(rwFName);
            sgrPersR.RowList.Add(rwLName);
            sgrPersR.RowList.Add(rwNameDative);
            sgrPersR.RowList.Add(rvNameAccusative);
            sgrPersR.RowList.Add(rwGender);
            sgrPersR.RowList.Add(rwPersonCode);
            sgrPersR.RowList.Add(rwBirthDate);
            sgrPersR.RowList.Add(rwTStatus);
            sgrPersR.RowList.Add(rwApgadSk);
            sgrPersR.RowList.Add(rwPensioner);
            sgrPersR.RowList.Add(rwInvalid);
            sgrPersR.RowList.Add(rwRepres);
            sgrPersR.RowList.Add(rwPret);
            sgrPersR.RowList.Add(rwPrisoner);
            sgrPersR.RowList.Add(rwPensionerSp);
            sgrPersR.RowList.Add(rwNotOSA);
            sgrPersR.RowList.Add(rwTAddress);
            sgrPersR.RowList.Add(rwAddress);
            sgrPersR.RowList.Add(rwCity);
            sgrPersR.RowList.Add(rwState);
            sgrPersR.RowList.Add(rwCountry);
            sgrPersR.RowList.Add(rwPostalCode);
            sgrPersR.RowList.Add(rwTerCode);
            sgrPersR.RowList.Add(rwTContact);
            sgrPersR.RowList.Add(rwPhone);
            sgrPersR.RowList.Add(rwEMail);
            sgrPersR.RowList.Add(rwTBank);
            sgrPersR.RowList.Add(rwBankId2);
            sgrPersR.RowList.Add(rwBankAcc);
            sgrPersR.RowList.Add(rwTPassp);
            sgrPersR.RowList.Add(rwPasspNo);
            sgrPersR.RowList.Add(rwPasspIssuer);
            sgrPersR.RowList.Add(rwPasspDate);
            sgrPersR.RowList.Add(rwTaxDoc);
            sgrPersR.RowList.Add(rwTaxDocSerial);
            sgrPersR.RowList.Add(rwTaxDocNo);
            sgrPersR.RowList.Add(rwTaxDocIssuer);
            sgrPersR.RowList.Add(rwTTaxPayer);
            sgrPersR.RowList.Add(rwTaxRegNo);
            sgrPersR.RowList.Add(rwTitleBefore);
            sgrPersR.RowList.Add(rwVacationDays);
            sgrPersR.RowList.Add(rwTitleCom);
            sgrPersR.RowList.Add(rwComments2);
            sgrPersR.RowTemplateList.Add(shedPersonsText);
            sgrPersR.RowTemplateList.Add(sharedPersonsNoYes);
            sgrPersR.RowTemplateList.Add(sharedPersonsDecimal);
            sgrPersR.RowTemplateList.Add(shedPersonsTextAllowNull);
            sgrPersR.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            sgrPersR.Size = new System.Drawing.Size(390, 503);
            sgrPersR.TabIndex = 8;
            sgrPersR.TabStop = true;
            sgrPersR.ToolTipText = "";
            sgrPersR.EditEnded += sgrPersR_EditEnded;
            sgrPersR.Enter += sgrPersR_Enter;
            sgrPersR.MouseDoubleClick += sgrPersR_MouseDoubleClick;
            sgrPersR.PreviewKeyDown += sgrPersR_PreviewKeyDown;
            // 
            // rwPensionerSp
            // 
            rwPensionerSp.DataMember = "PENSIONER_SP";
            rwPensionerSp.DataSource = bsPersonsR;
            rwPensionerSp.EditorTemplateName = "sharedPersonsNoYes";
            rwPensionerSp.GridPropertyName = "_PRISONER_SP";
            rwPensionerSp.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            rwPensionerSp.Name = "rwPensionerSp";
            rwPensionerSp.RowSpan = 2;
            rwPensionerSp.RowTitle = "Izdienas vai spec. pens. saņēmējs";
            rwPensionerSp.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwNotOSA
            // 
            rwNotOSA.DataMember = "NOT_OSA";
            rwNotOSA.DataSource = bsPersonsR;
            rwNotOSA.EditorTemplateName = "sharedPersonsNoYes";
            rwNotOSA.GridPropertyName = "_NOT_OSA";
            rwNotOSA.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            rwNotOSA.Name = "rwNotOSA";
            rwNotOSA.RowSpan = 2;
            rwNotOSA.RowTitle = "Nav obligāti sociāli apdrošināms";
            rwNotOSA.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // rwBankId2
            // 
            rwBankId2.AllowNull = true;
            rwBankId2.ColumnNames = new string[]
    {
    "NAME"
    };
            rwBankId2.ColumnWidths = "200";
            rwBankId2.DataMember = "BANK_ID";
            rwBankId2.DataSource = bsPersons;
            rwBankId2.GridPropertyName = "_BANK_ID";
            rwBankId2.ListDisplayMember = "NAME";
            rwBankId2.ListSource = bsBanks;
            rwBankId2.ListValueMember = "ID";
            rwBankId2.Name = "rwBankId2";
            rwBankId2.RowTitle = "Banka";
            rwBankId2.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsBanks
            // 
            bsBanks.DataMember = "BANKS";
            bsBanks.MyDataSource = "KlonsAData";
            bsBanks.Sort = "NAME";
            // 
            // rwTitleBefore
            // 
            rwTitleBefore.Name = "rwTitleBefore";
            rwTitleBefore.RowTitle = "Sākuma atlikumi";
            rwTitleBefore.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwVacationDays
            // 
            rwVacationDays.AllowNull = true;
            rwVacationDays.DataMember = "VACATION_DAYS";
            rwVacationDays.DataSource = bsPersons;
            rwVacationDays.GridPropertyName = "_VACATION_DAYS";
            rwVacationDays.Name = "rwVacationDays";
            rwVacationDays.RowTitle = "Neizmants atvaļin.";
            rwVacationDays.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Single;
            // 
            // sharedPersonsNoYes
            // 
            sharedPersonsNoYes.ListStrings = new string[]
    {
    "0;nē",
    "1;jā"
    };
            sharedPersonsNoYes.Name = "sharedPersonsNoYes";
            sharedPersonsNoYes.RowTitle = null;
            sharedPersonsNoYes.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.ShortInt;
            // 
            // sharedPersonsDecimal
            // 
            sharedPersonsDecimal.Name = "sharedPersonsDecimal";
            sharedPersonsDecimal.RowTitle = null;
            sharedPersonsDecimal.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // shedPersonsTextAllowNull
            // 
            shedPersonsTextAllowNull.AllowNull = true;
            shedPersonsTextAllowNull.DataMember = null;
            shedPersonsTextAllowNull.Name = "shedPersonsTextAllowNull";
            shedPersonsTextAllowNull.RowTitle = null;
            shedPersonsTextAllowNull.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPapildSummas);
            tabPage2.Location = new System.Drawing.Point(4, 25);
            tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage2.Size = new System.Drawing.Size(970, 514);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "piemaksas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvNotikumi);
            tabPage3.Location = new System.Drawing.Point(4, 25);
            tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tabPage3.Size = new System.Drawing.Size(970, 514);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "notikumi";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { darbiniekuDatiToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1185, 41);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // darbiniekuDatiToolStripMenuItem
            // 
            darbiniekuDatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { rādītPaslēptDarbiniekuSarakstuToolStripMenuItem, miShowOnlyUsed, toolStripSeparator1, miAddPerson, miAddPosition, toolStripSeparator3, pārbaudītNotikumusDarbiniekamToolStripMenuItem, pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem, toolStripSeparator2, darbiniekaKartīteToolStripMenuItem, neizmantotāsAtvaļinājumaDienasToolStripMenuItem });
            darbiniekuDatiToolStripMenuItem.Name = "darbiniekuDatiToolStripMenuItem";
            darbiniekuDatiToolStripMenuItem.Size = new System.Drawing.Size(115, 37);
            darbiniekuDatiToolStripMenuItem.Text = "Darbinieku dati";
            // 
            // rādītPaslēptDarbiniekuSarakstuToolStripMenuItem
            // 
            rādītPaslēptDarbiniekuSarakstuToolStripMenuItem.Name = "rādītPaslēptDarbiniekuSarakstuToolStripMenuItem";
            rādītPaslēptDarbiniekuSarakstuToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            rādītPaslēptDarbiniekuSarakstuToolStripMenuItem.Text = "Rādīt darbinieku sarakstu";
            rādītPaslēptDarbiniekuSarakstuToolStripMenuItem.Click += rādītDarbiniekuSarakstuToolStripMenuItem_Click;
            // 
            // miShowOnlyUsed
            // 
            miShowOnlyUsed.Name = "miShowOnlyUsed";
            miShowOnlyUsed.Size = new System.Drawing.Size(332, 22);
            miShowOnlyUsed.Text = "Rādīt tikai aktīvos darbiniekus / amatus";
            miShowOnlyUsed.Click += miShowOnlyUsed_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(329, 6);
            // 
            // miAddPerson
            // 
            miAddPerson.Name = "miAddPerson";
            miAddPerson.Size = new System.Drawing.Size(332, 22);
            miAddPerson.Text = "Pievienot jaunu darbinieku";
            miAddPerson.Click += miAddPerson_Click;
            // 
            // miAddPosition
            // 
            miAddPosition.Name = "miAddPosition";
            miAddPosition.Size = new System.Drawing.Size(332, 22);
            miAddPosition.Text = "Pievienot amatu";
            miAddPosition.Click += miAddPosition_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(329, 6);
            // 
            // pārbaudītNotikumusDarbiniekamToolStripMenuItem
            // 
            pārbaudītNotikumusDarbiniekamToolStripMenuItem.Name = "pārbaudītNotikumusDarbiniekamToolStripMenuItem";
            pārbaudītNotikumusDarbiniekamToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            pārbaudītNotikumusDarbiniekamToolStripMenuItem.Text = "Pārbaudīt notikumus darbiniekam";
            pārbaudītNotikumusDarbiniekamToolStripMenuItem.Click += pārbaudītNotikumusDarbiniekamToolStripMenuItem_Click;
            // 
            // pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem
            // 
            pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem.Name = "pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem";
            pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem.Text = "Pārbaudīt notikumus visiem darbiniekiem";
            pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem.Click += pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(329, 6);
            // 
            // darbiniekaKartīteToolStripMenuItem
            // 
            darbiniekaKartīteToolStripMenuItem.Name = "darbiniekaKartīteToolStripMenuItem";
            darbiniekaKartīteToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            darbiniekaKartīteToolStripMenuItem.Text = "Darbinieka kartīte";
            darbiniekaKartīteToolStripMenuItem.Click += darbiniekaKartīteToolStripMenuItem_Click;
            // 
            // neizmantotāsAtvaļinājumaDienasToolStripMenuItem
            // 
            neizmantotāsAtvaļinājumaDienasToolStripMenuItem.Name = "neizmantotāsAtvaļinājumaDienasToolStripMenuItem";
            neizmantotāsAtvaļinājumaDienasToolStripMenuItem.Size = new System.Drawing.Size(332, 22);
            neizmantotāsAtvaļinājumaDienasToolStripMenuItem.Text = "Neizmantotās atvaļinājuma dienas";
            neizmantotāsAtvaļinājumaDienasToolStripMenuItem.Click += neizmantotāsAtvaļinājumaDienasToolStripMenuItem_Click;
            // 
            // FormA_PersonsR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1185, 601);
            Controls.Add(cbAmati);
            Controls.Add(cbSelectTab);
            Controls.Add(cbPersons);
            Controls.Add(mySplitContainer1);
            Controls.Add(cbDates);
            Controls.Add(bnavNav);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormA_PersonsR";
            Text = "Darbinieku dati";
            FormClosing += Form_PersonsR_FormClosing;
            FormClosed += Form_PersonsR_FormClosed;
            Load += Form_PersonsR_Load;
            ((System.ComponentModel.ISupportInitialize)bnavNav).EndInit();
            bnavNav.ResumeLayout(false);
            bnavNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersonsR).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiR).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDep).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyAdapterManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmatiPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummasVeids).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummaNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPapildSummas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPapildSummas).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumuVeidi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAmati2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotikumi).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNotikumuVeidi2).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            mySplitContainer1.Panel1.ResumeLayout(false);
            mySplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).EndInit();
            mySplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsBanks).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bnavNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bnavNavCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnavNavPosItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DataObjectsA.PersonsRData PersonsRData1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwPamatdati;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwFName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwLName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwNameDative;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rvNameAccusative;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwGender;
        private KlonsLIB.Data.MyBindingSource bsPersons;
        private KlonsLIB.Data.MyBindingSource2 bsPersonsR;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPersonCode;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwBirthDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwCity;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwState;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwCountry;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPostalCode;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTerCode;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTContact;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPhone;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwEMail;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTBank;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwBankAcc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTPassp;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPasspNo;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPasspIssuer;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPasspDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTaxDoc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTaxDocSerial;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTaxDocNo;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTaxDocIssuer;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTTaxPayer;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTaxRegNo;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTStatus;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwInvalid;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwPensioner;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwPrisoner;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwRepres;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwPret;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwApgadSk;
        private KlonsLIB.Data.MyBindingSource2 bsAmati;
        private DataObjectsA.AmatsData AmatsRData1;
        private KlonsLIB.Data.MyBindingSource bsDep;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB rwAmatiDep;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTitleDat;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiTitleAcc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAmatiT2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAmatiT3;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwAmatiSalarytype;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA shedPersonsText;
        private KlonsLIB.Data.MyBindingSource2 bsAmatiR;
        private KlonsLIB.Components.MyMcFlatComboBox cbPersons;
        private KlonsLIB.Components.MyMcFlatComboBox cbAmati;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.Data.MyAdapterManager MyAdapterManager1;
        private System.Windows.Forms.ToolStripLabel tslLabel;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRateNight;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA shrwAmariDecimal;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA shrwAmatiRateType;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRateOvertime;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiAdvance;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTitleCom;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbArrow1;
        private KlonsLIB.Components.MyMcFlatComboBox cbDates;
        private KlonsLIB.Data.MyBindingSource bsPapildSummasVeids;
        private KlonsLIB.Data.MyBindingSource bsPapildSummaNo;
        private KlonsLIB.Data.MyBindingSource2 bsPapildSummas;
        private KlonsLIB.Data.MyBindingSource bsNotikumuVeidi;
        private KlonsLIB.Data.MyBindingSource2 bsNotikumi;
        private KlonsLIB.Components.MyMcFlatComboBox cbSelectTab;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowMultiLineTextBox rwComments2;
        private KlonsLIB.Data.MyBindingSource2 bsAmati2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwAmatiSixDayWeek;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiNormalDayHours;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiNormalWeekHours;
        private KlonsLIB.Data.MyBindingSource2 bsAmatiPS;
        private KlonsLIB.Components.MySplitContainer mySplitContainer1;
        private KlonsLIB.Components.MyDataGridView dgvPersons;
        private KlonsLIB.Components.TabControlWithoutHeader tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private KlonsLIB.MySourceGrid.MyGrid sgrAmati;
        private KlonsLIB.MySourceGrid.MyGrid sgrPersR;
        private System.Windows.Forms.TabPage tabPage2;
        private KlonsLIB.Components.MyDataGridView dgvPapildSummas;
        private System.Windows.Forms.TabPage tabPage3;
        private KlonsLIB.Components.MyDataGridView dgvNotikumi;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTitleBefore;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwVacationDays;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem darbiniekuDatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rādītPaslēptDarbiniekuSarakstuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pārbaudītNotikumusDarbiniekamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pārbaudītNotikumusVisiemDarbiniekiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAmatiRateTitle1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAmatiRateTitle2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRateH;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRateHN;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiRateHO;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAmatiSaldoTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiSaldoPay0;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAmatiSaldoIIN0;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwSaldoAdvance;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwPensionerSp;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwNotOSA;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA sharedPersonsNoYes;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA sharedPersonsDecimal;
        private System.Windows.Forms.ToolStripMenuItem miAddPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miAddPosition;
        private System.Windows.Forms.ToolStripMenuItem darbiniekaKartīteToolStripMenuItem;
        private KlonsLIB.Data.MyBindingSource bsBanks;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB rwBankId2;
        private KlonsLIB.Data.MyBindingSource bsNotikumuVeidi2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA shedPersonsTextAllowNull;
        private System.Windows.Forms.ToolStripMenuItem miShowOnlyUsed;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcPSIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPSDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPSDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPSDescr;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcPSIDSV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPSRate;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcPSRateType;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcPSIDNO;
        private MyDgvCheckBoxColumn dgcPSIsPaid;
        private MyDgvCheckBoxColumn dgcPSIsInAvpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPSID;
        private System.Windows.Forms.ToolStripMenuItem neizmantotāsAtvaļinājumaDienasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgcNotIDN;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcNotIDN2;
        private KlonsLIB.Components.MyDgvMcComboBoxColumn dgcNotIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDT3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotDays2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotOcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNotIDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPersonsYName;
        private MyButton btNextPerson;
        private MyButton btPrevPerson;
        private System.Windows.Forms.Panel panel1;
        private MyTextBox tbFindPerson;
    }
}