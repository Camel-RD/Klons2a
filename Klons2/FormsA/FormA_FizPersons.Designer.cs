using KlonsLIB.Components;

namespace KlonsA.Forms
{
    partial class FormA_FizPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_FizPersons));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            bnavPersons = new MyBindingNavigator();
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            dgvPersons = new MyDataGridView();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            sgrPersons = new KlonsLIB.MySourceGrid.MyGrid();
            personsRData1 = new DataObjectsA.PersonsRData();
            rwPamatdatiTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwFName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwLName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwNameDative = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwNameAccusative = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwGender = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA();
            rwPK = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwBirthDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTaxesTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwTaxRegNo = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwAddressTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwAddress = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwCity = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwState = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwCountry = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPostalCode = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwTerritorialCode = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwContactInfoTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwPhone = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwEMail = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPassportTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwPassportNo = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPassportIssuer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwPassportDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwBankTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwBankId = new KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB();
            bsBanks = new KlonsLIB.Data.MyBindingSource(components);
            rwBankAcc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwCommentsTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            rwComments = new KlonsLIB.MySourceGrid.GridRows.MyGridRowMultiLineTextBox();
            rwtDecimal = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            rwtString = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            cbActive = new MyMcFlatComboBox();
            dgcFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcTaxRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUsed = new MyDgvCheckBoxColumn();
            dgcUsedDt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcUsedDt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bnavPersons).BeginInit();
            bnavPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsBanks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).BeginInit();
            SuspendLayout();
            // 
            // bnavPersons
            // 
            bnavPersons.AddNewItem = null;
            bnavPersons.BindingSource = bsPersons;
            bnavPersons.CountItem = bindingNavigatorCountItem;
            bnavPersons.CountItemFormat = " no {0}";
            bnavPersons.DataGrid = dgvPersons;
            bnavPersons.DeleteItem = null;
            bnavPersons.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnavPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnavPersons.ImageScalingSize = new System.Drawing.Size(21, 21);
            bnavPersons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem, tsbSave });
            bnavPersons.Location = new System.Drawing.Point(0, 343);
            bnavPersons.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnavPersons.MoveLastItem = bindingNavigatorMoveLastItem;
            bnavPersons.MoveNextItem = bindingNavigatorMoveNextItem;
            bnavPersons.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnavPersons.Name = "bnavPersons";
            bnavPersons.PositionItem = bindingNavigatorPositionItem;
            bnavPersons.SaveItem = null;
            bnavPersons.Size = new System.Drawing.Size(851, 32);
            bnavPersons.TabIndex = 0;
            bnavPersons.Text = "myBindingNavigator1";
            bnavPersons.ItemDeleting += bnavPersons_ItemDeleting;
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "PERSONS_FIZ";
            bsPersons.MyDataSource = "KlonsAData";
            bsPersons.Sort = "ZNAME";
            bsPersons.CurrentChanged += bsPersons_CurrentChanged;
            bsPersons.ListChanged += bsPersons_ListChanged;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 29);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // dgvPersons
            // 
            dgvPersons.AllowUserToAddRows = false;
            dgvPersons.AutoGenerateColumns = false;
            dgvPersons.AutoSave = true;
            dgvPersons.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcFname, dgcLName, dgcPK, dgcTaxRegNo, dgcUsed, dgcUsedDt1, dgcUsedDt2, dgcID });
            dgvPersons.DataSource = bsPersons;
            dgvPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPersons.Location = new System.Drawing.Point(0, 0);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new System.Drawing.Size(516, 343);
            dgvPersons.TabIndex = 1;
            dgvPersons.MyCheckForChanges += dgvPersons_MyCheckForChanges;
            dgvPersons.CellDoubleClick += dgvPersons_CellDoubleClick;
            dgvPersons.CellParsing += dgvPersons_CellParsing;
            dgvPersons.CurrentCellChanged += dgvPersons_CurrentCellChanged;
            dgvPersons.UserDeletingRow += dgvPersons_UserDeletingRow;
            dgvPersons.KeyDown += dgvPersons_KeyDown;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 29);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 29);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
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
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 29);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 29);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 29);
            bindingNavigatorAddNewItem.Text = "Jauns";
            bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(0, 3, 0, 4);
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 25);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = KlonsF.Properties.Resources.Save1;
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(25, 29);
            tsbSave.Text = "Saglabāt";
            tsbSave.Click += tsbSave_Click;
            // 
            // sgrPersons
            // 
            sgrPersons.BackColor2 = System.Drawing.SystemColors.Window;
            sgrPersons.ColumnWidth1 = 15;
            sgrPersons.ColumnWidth2 = 150;
            sgrPersons.ColumnWidth3 = 150;
            sgrPersons.Dock = System.Windows.Forms.DockStyle.Right;
            sgrPersons.EnableSort = true;
            sgrPersons.Location = new System.Drawing.Point(516, 0);
            sgrPersons.MyDataBC = personsRData1;
            sgrPersons.Name = "sgrPersons";
            sgrPersons.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            sgrPersons.RowList.Add(rwPamatdatiTitle);
            sgrPersons.RowList.Add(rwFName);
            sgrPersons.RowList.Add(rwLName);
            sgrPersons.RowList.Add(rwNameDative);
            sgrPersons.RowList.Add(rwNameAccusative);
            sgrPersons.RowList.Add(rwGender);
            sgrPersons.RowList.Add(rwPK);
            sgrPersons.RowList.Add(rwBirthDate);
            sgrPersons.RowList.Add(rwTaxesTitle);
            sgrPersons.RowList.Add(rwTaxRegNo);
            sgrPersons.RowList.Add(rwAddressTitle);
            sgrPersons.RowList.Add(rwAddress);
            sgrPersons.RowList.Add(rwCity);
            sgrPersons.RowList.Add(rwState);
            sgrPersons.RowList.Add(rwCountry);
            sgrPersons.RowList.Add(rwPostalCode);
            sgrPersons.RowList.Add(rwTerritorialCode);
            sgrPersons.RowList.Add(rwContactInfoTitle);
            sgrPersons.RowList.Add(rwPhone);
            sgrPersons.RowList.Add(rwEMail);
            sgrPersons.RowList.Add(rwPassportTitle);
            sgrPersons.RowList.Add(rwPassportNo);
            sgrPersons.RowList.Add(rwPassportIssuer);
            sgrPersons.RowList.Add(rwPassportDate);
            sgrPersons.RowList.Add(rwBankTitle);
            sgrPersons.RowList.Add(rwBankId);
            sgrPersons.RowList.Add(rwBankAcc);
            sgrPersons.RowList.Add(rwCommentsTitle);
            sgrPersons.RowList.Add(rwComments);
            sgrPersons.RowTemplateList.Add(rwtDecimal);
            sgrPersons.RowTemplateList.Add(rwtString);
            sgrPersons.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            sgrPersons.Size = new System.Drawing.Size(335, 343);
            sgrPersons.TabIndex = 2;
            sgrPersons.TabStop = true;
            sgrPersons.ToolTipText = "";
            // 
            // personsRData1
            // 
            personsRData1._ADDRESS = null;
            personsRData1._ADVANCE = new decimal(new int[] { 0, 0, 0, 65536 });
            personsRData1._APGAD_SK = 0;
            personsRData1._BANK_ACC = null;
            personsRData1._BANK_ID = null;
            personsRData1._BIRTH_DATE = new System.DateTime(0L);
            personsRData1._CITY = null;
            personsRData1._COMMENTS = null;
            personsRData1._COUNTRY = null;
            personsRData1._EDIT_DATE = new System.DateTime(0L);
            personsRData1._EMAIL = null;
            personsRData1._FNAME = null;
            personsRData1._GENDER = 0;
            personsRData1._ID = 0;
            personsRData1._IDP = 0;
            personsRData1._IIN0 = new decimal(new int[] { 0, 0, 0, 65536 });
            personsRData1._INVALID = 0;
            personsRData1._LNAME = null;
            personsRData1._NAME_ACCUSATIVE = null;
            personsRData1._NAME_DATIVE = null;
            personsRData1._NOT_OSA = 0;
            personsRData1._PASSPORT_DATE = null;
            personsRData1._PASSPORT_ISSUER = null;
            personsRData1._PASSPORT_NO = null;
            personsRData1._PAY0 = new decimal(new int[] { 0, 0, 0, 65536 });
            personsRData1._PENSIONER = 0;
            personsRData1._PERSON_CODE = null;
            personsRData1._PHONE = null;
            personsRData1._POSTAL_CODE = null;
            personsRData1._PRET = 0;
            personsRData1._PRISONER = 0;
            personsRData1._PRISONER_SP = 0;
            personsRData1._REPRES = 0;
            personsRData1._STATE = null;
            personsRData1._TAXDOC_ISSUER = null;
            personsRData1._TAXDOC_NO = null;
            personsRData1._TAXDOC_SERIAL = null;
            personsRData1._TAXREG_NO = null;
            personsRData1._TERRITORIAL_CODE = null;
            personsRData1._VACATION_DAYS = 0F;
            // 
            // rwPamatdatiTitle
            // 
            rwPamatdatiTitle.Name = "rwPamatdatiTitle";
            rwPamatdatiTitle.RowTitle = "Pamatdati";
            rwPamatdatiTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwFName
            // 
            rwFName.DataMember = "FNAME";
            rwFName.DataSource = bsPersons;
            rwFName.EditorTemplateName = "rwtString";
            rwFName.GridPropertyName = "_FNAME";
            rwFName.Name = "rwFName";
            rwFName.RowTitle = "Vārds";
            rwFName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwLName
            // 
            rwLName.DataMember = "LNAME";
            rwLName.DataSource = bsPersons;
            rwLName.EditorTemplateName = "rwtString";
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
            rwNameDative.EditorTemplateName = "rwtString";
            rwNameDative.GridPropertyName = "_NAME_DATIVE";
            rwNameDative.Name = "rwNameDative";
            rwNameDative.RowTitle = "Vārds datīvā";
            rwNameDative.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwNameAccusative
            // 
            rwNameAccusative.AllowNull = true;
            rwNameAccusative.DataMember = "NAME_ACCUSATIVE";
            rwNameAccusative.DataSource = bsPersons;
            rwNameAccusative.EditorTemplateName = "rwtString";
            rwNameAccusative.GridPropertyName = "_NAME_ACCUSATIVE";
            rwNameAccusative.Name = "rwNameAccusative";
            rwNameAccusative.RowTitle = "Vārds akuzatīvā";
            rwNameAccusative.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
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
            // rwPK
            // 
            rwPK.AllowNull = true;
            rwPK.DataMember = "PK";
            rwPK.DataSource = bsPersons;
            rwPK.EditorTemplateName = "rwtString";
            rwPK.GridPropertyName = "_PERSON_CODE";
            rwPK.Name = "rwPK";
            rwPK.RowTitle = "Personas kods";
            rwPK.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
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
            // rwTaxesTitle
            // 
            rwTaxesTitle.Name = "rwTaxesTitle";
            rwTaxesTitle.RowTitle = "Nodokļi";
            rwTaxesTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwTaxRegNo
            // 
            rwTaxRegNo.AllowNull = true;
            rwTaxRegNo.DataMember = "TAXREG_NO";
            rwTaxRegNo.DataSource = bsPersons;
            rwTaxRegNo.EditorTemplateName = "rwtString";
            rwTaxRegNo.GridPropertyName = "_TAXREG_NO";
            rwTaxRegNo.Name = "rwTaxRegNo";
            rwTaxRegNo.RowTitle = "Nod. maks. reģ. nr.";
            rwTaxRegNo.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwAddressTitle
            // 
            rwAddressTitle.Name = "rwAddressTitle";
            rwAddressTitle.RowTitle = "Adrese";
            rwAddressTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwAddress
            // 
            rwAddress.AllowNull = true;
            rwAddress.DataMember = "ADDRESS";
            rwAddress.DataSource = bsPersons;
            rwAddress.EditorTemplateName = "rwtString";
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
            rwCity.EditorTemplateName = "rwtString";
            rwCity.GridPropertyName = "_CITY";
            rwCity.Name = "rwCity";
            rwCity.RowTitle = "Pilsēta";
            rwCity.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwState
            // 
            rwState.AllowNull = true;
            rwState.DataMember = "STATE";
            rwState.DataSource = bsPersons;
            rwState.EditorTemplateName = "rwtString";
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
            rwCountry.EditorTemplateName = "rwtString";
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
            rwPostalCode.EditorTemplateName = "rwtString";
            rwPostalCode.GridPropertyName = "_POSTAL_CODE";
            rwPostalCode.Name = "rwPostalCode";
            rwPostalCode.RowTitle = "Pasta indekss";
            rwPostalCode.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwTerritorialCode
            // 
            rwTerritorialCode.AllowNull = true;
            rwTerritorialCode.DataMember = "TERRITORIAL_CODE";
            rwTerritorialCode.DataSource = bsPersons;
            rwTerritorialCode.EditorTemplateName = "rwtString";
            rwTerritorialCode.GridPropertyName = "_TERRITORIAL_CODE";
            rwTerritorialCode.Name = "rwTerritorialCode";
            rwTerritorialCode.RowTitle = "Teritoriālais kods";
            rwTerritorialCode.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwContactInfoTitle
            // 
            rwContactInfoTitle.Name = "rwContactInfoTitle";
            rwContactInfoTitle.RowTitle = "Kontaktinformācija";
            rwContactInfoTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwPhone
            // 
            rwPhone.AllowNull = true;
            rwPhone.DataMember = "PHONE";
            rwPhone.DataSource = bsPersons;
            rwPhone.EditorTemplateName = "rwtString";
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
            rwEMail.EditorTemplateName = "rwtString";
            rwEMail.GridPropertyName = "_EMAIL";
            rwEMail.Name = "rwEMail";
            rwEMail.RowTitle = "E-pasts";
            rwEMail.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPassportTitle
            // 
            rwPassportTitle.Name = "rwPassportTitle";
            rwPassportTitle.RowTitle = "Pases dati";
            rwPassportTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwPassportNo
            // 
            rwPassportNo.AllowNull = true;
            rwPassportNo.DataMember = "PASSPORT_NO";
            rwPassportNo.DataSource = bsPersons;
            rwPassportNo.EditorTemplateName = "rwtString";
            rwPassportNo.GridPropertyName = "_PASSPORT_NO";
            rwPassportNo.Name = "rwPassportNo";
            rwPassportNo.RowTitle = "Numurs";
            rwPassportNo.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPassportIssuer
            // 
            rwPassportIssuer.AllowNull = true;
            rwPassportIssuer.DataMember = "PASSPORT_ISSUER";
            rwPassportIssuer.DataSource = bsPersons;
            rwPassportIssuer.EditorTemplateName = "rwtString";
            rwPassportIssuer.GridPropertyName = "_PASSPORT_ISSUER";
            rwPassportIssuer.Name = "rwPassportIssuer";
            rwPassportIssuer.RowTitle = "Izdevējiestāde";
            rwPassportIssuer.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwPassportDate
            // 
            rwPassportDate.AllowNull = true;
            rwPassportDate.DataMember = "PASSPORT_DATE";
            rwPassportDate.DataSource = bsPersons;
            rwPassportDate.GridPropertyName = "_PASSPORT_DATE";
            rwPassportDate.Name = "rwPassportDate";
            rwPassportDate.RowTitle = "Izdošanas datums";
            rwPassportDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // rwBankTitle
            // 
            rwBankTitle.Name = "rwBankTitle";
            rwBankTitle.RowTitle = "Bankas konts";
            rwBankTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwBankId
            // 
            rwBankId.AllowNull = true;
            rwBankId.ColumnNames = new string[]
    {
    "NAME"
    };
            rwBankId.ColumnWidths = "300";
            rwBankId.DataMember = "BANK_ID";
            rwBankId.DataSource = bsPersons;
            rwBankId.GridPropertyName = "_BANK_ID";
            rwBankId.ListDisplayMember = "NAME";
            rwBankId.ListSource = bsBanks;
            rwBankId.ListValueMember = "ID";
            rwBankId.Name = "rwBankId";
            rwBankId.RowTitle = "Banka";
            rwBankId.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // bsBanks
            // 
            bsBanks.DataMember = "BANKS";
            bsBanks.MyDataSource = "KlonsAData";
            bsBanks.Sort = "NAME";
            // 
            // rwBankAcc
            // 
            rwBankAcc.AllowNull = true;
            rwBankAcc.DataMember = "BANK_ACC";
            rwBankAcc.DataSource = bsPersons;
            rwBankAcc.EditorTemplateName = "rwtString";
            rwBankAcc.GridPropertyName = "_BANK_ACC";
            rwBankAcc.Name = "rwBankAcc";
            rwBankAcc.RowTitle = "Konts";
            rwBankAcc.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // rwCommentsTitle
            // 
            rwCommentsTitle.Name = "rwCommentsTitle";
            rwCommentsTitle.RowTitle = "Piezimes";
            rwCommentsTitle.TitleRowType = KlonsLIB.MySourceGrid.GridRows.ETitleRowType.Static;
            // 
            // rwComments
            // 
            rwComments.AllowNull = true;
            rwComments.DataMember = "COMMENTS";
            rwComments.DataSource = bsPersons;
            rwComments.GridPropertyName = "_COMMENTS";
            rwComments.Name = "rwComments";
            rwComments.RowSpan = 8;
            rwComments.RowTitle = null;
            // 
            // rwtDecimal
            // 
            rwtDecimal.Name = "rwtDecimal";
            rwtDecimal.RowTitle = null;
            rwtDecimal.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.Decimal;
            // 
            // rwtString
            // 
            rwtString.DataMember = null;
            rwtString.Name = "rwtString";
            rwtString.RowTitle = null;
            rwtString.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // myAdapterManager1
            // 
            myAdapterManager1.MyDataSource = "KlonsAData";
            myAdapterManager1.TableNames = new string[]
    {
    "PERSONS_FIZ",
    null
    };
            // 
            // cbActive
            // 
            cbActive.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbActive.ColumnWidths = "66";
            cbActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbActive.DropDownHeight = 144;
            cbActive.DropDownStyle = MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbActive.DropDownWidth = 85;
            cbActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbActive.FormattingEnabled = true;
            cbActive.GridLineColor = System.Drawing.Color.LightGray;
            cbActive.GridLineHorizontal = false;
            cbActive.GridLineVertical = false;
            cbActive.IntegralHeight = false;
            cbActive.Items.AddRange(new object[] { "Aktīvie", "Visi" });
            cbActive.Location = new System.Drawing.Point(497, 339);
            cbActive.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            cbActive.Name = "cbActive";
            cbActive.Size = new System.Drawing.Size(90, 24);
            cbActive.TabIndex = 7;
            cbActive.SelectedIndexChanged += cbActive_SelectedIndexChanged;
            // 
            // dgcFname
            // 
            dgcFname.DataPropertyName = "FNAME";
            dgcFname.HeaderText = "vārds";
            dgcFname.Name = "dgcFname";
            dgcFname.Width = 110;
            // 
            // dgcLName
            // 
            dgcLName.DataPropertyName = "LNAME";
            dgcLName.HeaderText = "uzvārds";
            dgcLName.Name = "dgcLName";
            dgcLName.Width = 110;
            // 
            // dgcPK
            // 
            dgcPK.DataPropertyName = "PK";
            dgcPK.HeaderText = "pers. kods";
            dgcPK.Name = "dgcPK";
            dgcPK.ToolTipText = "personas kods";
            dgcPK.Width = 120;
            // 
            // dgcTaxRegNo
            // 
            dgcTaxRegNo.DataPropertyName = "TAXREG_NO";
            dgcTaxRegNo.HeaderText = "reģ. nr.";
            dgcTaxRegNo.Name = "dgcTaxRegNo";
            dgcTaxRegNo.ToolTipText = "nodokļu maksātāja reģistrācijas numurs";
            dgcTaxRegNo.Width = 120;
            // 
            // dgcUsed
            // 
            dgcUsed.DataPropertyName = "USED";
            dgcUsed.FalseValue = "0";
            dgcUsed.HeaderText = "aktīvs";
            dgcUsed.Name = "dgcUsed";
            dgcUsed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            dgcUsed.TrueValue = "1";
            dgcUsed.Width = 50;
            // 
            // dgcUsedDt1
            // 
            dgcUsedDt1.DataPropertyName = "USED_DT1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcUsedDt1.DefaultCellStyle = dataGridViewCellStyle2;
            dgcUsedDt1.HeaderText = "aktīvs no";
            dgcUsedDt1.Name = "dgcUsedDt1";
            dgcUsedDt1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcUsedDt1.Width = 85;
            // 
            // dgcUsedDt2
            // 
            dgcUsedDt2.DataPropertyName = "USED_DT2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            dgcUsedDt2.DefaultCellStyle = dataGridViewCellStyle3;
            dgcUsedDt2.HeaderText = "aktīvs līdz";
            dgcUsedDt2.Name = "dgcUsedDt2";
            dgcUsedDt2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            dgcUsedDt2.Width = 85;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.Name = "dgcID";
            dgcID.Visible = false;
            // 
            // FormA_FizPersons
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(851, 375);
            Controls.Add(cbActive);
            Controls.Add(dgvPersons);
            Controls.Add(sgrPersons);
            Controls.Add(bnavPersons);
            Name = "FormA_FizPersons";
            Text = "Fiziskas personas";
            Load += Form_FizPersons_Load;
            ((System.ComponentModel.ISupportInitialize)bnavPersons).EndInit();
            bnavPersons.ResumeLayout(false);
            bnavPersons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsBanks).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAdapterManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyBindingNavigator bnavPersons;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private KlonsLIB.Data.MyBindingSource bsPersons;
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
        private KlonsLIB.Components.MyDataGridView dgvPersons;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private KlonsLIB.MySourceGrid.MyGrid sgrPersons;
        private DataObjectsA.PersonsRData personsRData1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwtDecimal;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwPamatdatiTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwFName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwtString;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwLName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwNameDative;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwNameAccusative;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPK;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwBirthDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwTaxesTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTaxRegNo;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwAddressTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwCity;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwState;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwCountry;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPostalCode;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwTerritorialCode;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwContactInfoTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPhone;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwEMail;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwPassportTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPassportNo;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPassportIssuer;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwPassportDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwBankTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxB rwBankId;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA rwBankAcc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle rwCommentsTitle;
        private KlonsLIB.Data.MyBindingSource bsBanks;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowComboBoxA rwGender;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowMultiLineTextBox rwComments;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private KlonsLIB.Components.MyMcFlatComboBox cbActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcTaxRegNo;
        private MyDgvCheckBoxColumn dgcUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsedDt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUsedDt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
    }
}