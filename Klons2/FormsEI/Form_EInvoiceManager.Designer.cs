namespace KlonsM.FormsEI
{
    partial class Form_EInvoiceManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EInvoiceManager));
            tcTabs = new KlonsLIB.Components.ExTabControl();
            tpInvoiceList = new System.Windows.Forms.TabPage();
            dgvInvoiceList = new KlonsLIB.Components.MyDataGridView();
            dgcInvoiceChecked = new KlonsLIB.Components.MyDgvCheckBoxColumn();
            dgcInvoiceFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceDocumentExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceValidationMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInviceIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInveiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInveiceSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsInvoiceList = new System.Windows.Forms.BindingSource(components);
            tspInvoiceList = new System.Windows.Forms.ToolStrip();
            tsbShowInvoice = new System.Windows.Forms.ToolStripButton();
            tsdSelectInveoices = new System.Windows.Forms.ToolStripDropDownButton();
            tsbSelectNoneInvoice = new System.Windows.Forms.ToolStripMenuItem();
            tsbSelectAllInvoices = new System.Windows.Forms.ToolStripMenuItem();
            tsdValidateInveoices = new System.Windows.Forms.ToolStripDropDownButton();
            tsbValidateCurrent = new System.Windows.Forms.ToolStripMenuItem();
            tsbValidateSelected = new System.Windows.Forms.ToolStripMenuItem();
            tsbValidateAll = new System.Windows.Forms.ToolStripMenuItem();
            tsbMoveSelectedInvices = new System.Windows.Forms.ToolStripButton();
            tsbShowRealInvoice = new System.Windows.Forms.ToolStripButton();
            panel1 = new System.Windows.Forms.Panel();
            tbFilterInvoices = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btShowFolder = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            cbInvoiceFolder = new KlonsLIB.Components.FlatComboBox();
            tpInvoice = new System.Windows.Forms.TabPage();
            mySplitContainer1 = new KlonsLIB.Components.MySplitContainer();
            sgrInvoice = new KlonsLIB.MySourceGrid.MyGrid();
            invoiceView1 = new DataObjectsEI.InvoiceView();
            grInvoiceTitleDoc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grInvoiceId = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceDate = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceDateDue = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceTitleTotals = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grInvoiceTotalBeforeTaxes = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceTotalVAT = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceTotalToPay = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceNewColumn1 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand();
            grInvoiceTitleSupplier = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grInvoiceSupplierName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceSupplierRenNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceSupplierPVNRegNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceSupplierAddress = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoicePaeeAccount = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceNewColumn2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand();
            grInvoiceTitleCustomer = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grInvoiceCustomerName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceCustomerRegNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceCustomerVATRegNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grInvoiceCustomerAddress = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            gdInvoicePayerAccount = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grtLineTextBox = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            dgvLines = new KlonsLIB.Components.MyDataGridView();
            dgcLineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineAllowanceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineTotalAmountBeforeTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineVatRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineVatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcLineTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsInvoiceLines = new System.Windows.Forms.BindingSource(components);
            tpErrors = new System.Windows.Forms.TabPage();
            tbErrors = new KlonsLIB.Components.FlatRichTextBox();
            tpSendPerEmail = new System.Windows.Forms.TabPage();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsbNewEmailTemplate = new System.Windows.Forms.ToolStripButton();
            tsbSenderEditTemplateName = new System.Windows.Forms.ToolStripButton();
            tsbDeleteEmailTemplate = new System.Windows.Forms.ToolStripButton();
            lbSendEmailInfo = new System.Windows.Forms.Label();
            cmSendEmail = new System.Windows.Forms.Button();
            tbSenderEmailBody = new KlonsLIB.Components.FlatRichTextBox();
            bsSenderEmailTemplates = new System.Windows.Forms.BindingSource(components);
            tbSenderEmailPassword = new KlonsLIB.Components.MyTextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tbSenderEmailSubject = new KlonsLIB.Components.MyTextBox();
            cbSenderEmailTemplates = new KlonsLIB.Components.FlatComboBox();
            tbSenderEmail = new KlonsLIB.Components.MyTextBox();
            tpSettings = new System.Windows.Forms.TabPage();
            tbSettingsEmailServerPort = new System.Windows.Forms.TextBox();
            tbSettingsEmailServer = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            cmSetEmailPassword = new System.Windows.Forms.Button();
            lbEmailPasswordStatuss = new System.Windows.Forms.Label();
            tbSettingsEmail = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbSettingsFileFolder = new KlonsLIB.Components.TextBoxWithButton();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            tsbTemplateCodeSenderName = new System.Windows.Forms.ToolStripMenuItem();
            tsbTemplateCodeReceiverName = new System.Windows.Forms.ToolStripMenuItem();
            tsbTemplateCodeInvoiceId = new System.Windows.Forms.ToolStripMenuItem();
            tcTabs.SuspendLayout();
            tpInvoiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsInvoiceList).BeginInit();
            tspInvoiceList.SuspendLayout();
            panel1.SuspendLayout();
            tpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).BeginInit();
            mySplitContainer1.Panel1.SuspendLayout();
            mySplitContainer1.Panel2.SuspendLayout();
            mySplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsInvoiceLines).BeginInit();
            tpErrors.SuspendLayout();
            tpSendPerEmail.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsSenderEmailTemplates).BeginInit();
            tpSettings.SuspendLayout();
            SuspendLayout();
            // 
            // tcTabs
            // 
            tcTabs.Controls.Add(tpInvoiceList);
            tcTabs.Controls.Add(tpInvoice);
            tcTabs.Controls.Add(tpErrors);
            tcTabs.Controls.Add(tpSendPerEmail);
            tcTabs.Controls.Add(tpSettings);
            tcTabs.DefaultStyle = false;
            tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tcTabs.HeaderBackColor = System.Drawing.SystemColors.Control;
            tcTabs.HighlightBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tcTabs.Location = new System.Drawing.Point(0, 0);
            tcTabs.Name = "tcTabs";
            tcTabs.SelectedIndex = 0;
            tcTabs.Size = new System.Drawing.Size(796, 328);
            tcTabs.TabIndex = 0;
            // 
            // tpInvoiceList
            // 
            tpInvoiceList.Controls.Add(dgvInvoiceList);
            tpInvoiceList.Controls.Add(tspInvoiceList);
            tpInvoiceList.Controls.Add(panel1);
            tpInvoiceList.Location = new System.Drawing.Point(4, 25);
            tpInvoiceList.Name = "tpInvoiceList";
            tpInvoiceList.Padding = new System.Windows.Forms.Padding(3);
            tpInvoiceList.Size = new System.Drawing.Size(788, 299);
            tpInvoiceList.TabIndex = 0;
            tpInvoiceList.Text = "Rēķinu saraksts";
            tpInvoiceList.UseVisualStyleBackColor = true;
            tpInvoiceList.Enter += tpInvoiceList_Enter;
            // 
            // dgvInvoiceList
            // 
            dgvInvoiceList.AllowUserToAddRows = false;
            dgvInvoiceList.AllowUserToDeleteRows = false;
            dgvInvoiceList.AllowUserToResizeRows = false;
            dgvInvoiceList.AutoGenerateColumns = false;
            dgvInvoiceList.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcInvoiceChecked, dgcInvoiceFileName, dgcInvoiceDocumentExtension, dgcInvoiceValidationMessage, dgcInviceIssueDate, dgcInveiceID, dgcInveiceSupplierName, dgcInvoiceCustomerName, dgcInvoiceTotalAmount, dgcInvoiceEmail });
            dgvInvoiceList.DataSource = bsInvoiceList;
            dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvInvoiceList.Location = new System.Drawing.Point(3, 32);
            dgvInvoiceList.Name = "dgvInvoiceList";
            dgvInvoiceList.RowHeadersWidth = 30;
            dgvInvoiceList.RowTemplate.Height = 25;
            dgvInvoiceList.Size = new System.Drawing.Size(782, 233);
            dgvInvoiceList.TabIndex = 1;
            // 
            // dgcInvoiceChecked
            // 
            dgcInvoiceChecked.DataPropertyName = "Checked";
            dgcInvoiceChecked.FalseValue = "false";
            dgcInvoiceChecked.HeaderText = " x";
            dgcInvoiceChecked.Name = "dgcInvoiceChecked";
            dgcInvoiceChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcInvoiceChecked.TrueValue = "true";
            dgcInvoiceChecked.Width = 30;
            // 
            // dgcInvoiceFileName
            // 
            dgcInvoiceFileName.DataPropertyName = "FileName";
            dgcInvoiceFileName.HeaderText = "fails";
            dgcInvoiceFileName.Name = "dgcInvoiceFileName";
            dgcInvoiceFileName.ReadOnly = true;
            dgcInvoiceFileName.Width = 150;
            // 
            // dgcInvoiceDocumentExtension
            // 
            dgcInvoiceDocumentExtension.DataPropertyName = "InvoiceDocumentExtension";
            dgcInvoiceDocumentExtension.HeaderText = "pilns rēķins";
            dgcInvoiceDocumentExtension.Name = "dgcInvoiceDocumentExtension";
            dgcInvoiceDocumentExtension.ReadOnly = true;
            dgcInvoiceDocumentExtension.ToolTipText = "pilnā rēķina faila paplašinājums";
            dgcInvoiceDocumentExtension.Width = 50;
            // 
            // dgcInvoiceValidationMessage
            // 
            dgcInvoiceValidationMessage.DataPropertyName = "ValidationMessage";
            dgcInvoiceValidationMessage.HeaderText = "pārbaude";
            dgcInvoiceValidationMessage.Name = "dgcInvoiceValidationMessage";
            dgcInvoiceValidationMessage.ReadOnly = true;
            dgcInvoiceValidationMessage.Width = 200;
            // 
            // dgcInviceIssueDate
            // 
            dgcInviceIssueDate.DataPropertyName = "IssueDate";
            dgcInviceIssueDate.HeaderText = "datums";
            dgcInviceIssueDate.Name = "dgcInviceIssueDate";
            dgcInviceIssueDate.ReadOnly = true;
            dgcInviceIssueDate.Width = 80;
            // 
            // dgcInveiceID
            // 
            dgcInveiceID.DataPropertyName = "ID";
            dgcInveiceID.HeaderText = "numurs";
            dgcInveiceID.Name = "dgcInveiceID";
            dgcInveiceID.ReadOnly = true;
            dgcInveiceID.Width = 101;
            // 
            // dgcInveiceSupplierName
            // 
            dgcInveiceSupplierName.DataPropertyName = "SupplierName";
            dgcInveiceSupplierName.HeaderText = "piegādātajs";
            dgcInveiceSupplierName.Name = "dgcInveiceSupplierName";
            dgcInveiceSupplierName.ReadOnly = true;
            dgcInveiceSupplierName.Width = 150;
            // 
            // dgcInvoiceCustomerName
            // 
            dgcInvoiceCustomerName.DataPropertyName = "CustomerName";
            dgcInvoiceCustomerName.HeaderText = "saņēmējs";
            dgcInvoiceCustomerName.Name = "dgcInvoiceCustomerName";
            dgcInvoiceCustomerName.ReadOnly = true;
            dgcInvoiceCustomerName.Width = 150;
            // 
            // dgcInvoiceTotalAmount
            // 
            dgcInvoiceTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dgcInvoiceTotalAmount.DefaultCellStyle = dataGridViewCellStyle9;
            dgcInvoiceTotalAmount.HeaderText = "summa";
            dgcInvoiceTotalAmount.Name = "dgcInvoiceTotalAmount";
            dgcInvoiceTotalAmount.ReadOnly = true;
            dgcInvoiceTotalAmount.Width = 90;
            // 
            // dgcInvoiceEmail
            // 
            dgcInvoiceEmail.DataPropertyName = "Email";
            dgcInvoiceEmail.HeaderText = "e-pasts";
            dgcInvoiceEmail.Name = "dgcInvoiceEmail";
            dgcInvoiceEmail.Width = 200;
            // 
            // bsInvoiceList
            // 
            bsInvoiceList.DataSource = typeof(DataObjectsEI.InvoiceView);
            bsInvoiceList.CurrentChanged += bsInvoiceList_CurrentChanged;
            // 
            // tspInvoiceList
            // 
            tspInvoiceList.Dock = System.Windows.Forms.DockStyle.Bottom;
            tspInvoiceList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbShowInvoice, tsdSelectInveoices, tsdValidateInveoices, tsbMoveSelectedInvices, tsbShowRealInvoice });
            tspInvoiceList.Location = new System.Drawing.Point(3, 265);
            tspInvoiceList.Name = "tspInvoiceList";
            tspInvoiceList.Padding = new System.Windows.Forms.Padding(0, 3, 1, 2);
            tspInvoiceList.Size = new System.Drawing.Size(782, 31);
            tspInvoiceList.TabIndex = 2;
            tspInvoiceList.Text = "toolStrip1";
            // 
            // tsbShowInvoice
            // 
            tsbShowInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbShowInvoice.Image = (System.Drawing.Image)resources.GetObject("tsbShowInvoice.Image");
            tsbShowInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbShowInvoice.Name = "tsbShowInvoice";
            tsbShowInvoice.Size = new System.Drawing.Size(51, 23);
            tsbShowInvoice.Text = "Atvērt";
            tsbShowInvoice.Click += tsbShowInvoice_Click;
            // 
            // tsdSelectInveoices
            // 
            tsdSelectInveoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsdSelectInveoices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbSelectNoneInvoice, tsbSelectAllInvoices });
            tsdSelectInveoices.Image = (System.Drawing.Image)resources.GetObject("tsdSelectInveoices.Image");
            tsdSelectInveoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsdSelectInveoices.Name = "tsdSelectInveoices";
            tsdSelectInveoices.Size = new System.Drawing.Size(69, 23);
            tsdSelectInveoices.Text = "Ātzīmēt";
            // 
            // tsbSelectNoneInvoice
            // 
            tsbSelectNoneInvoice.Name = "tsbSelectNoneInvoice";
            tsbSelectNoneInvoice.Size = new System.Drawing.Size(128, 24);
            tsbSelectNoneInvoice.Text = "Nevienu";
            tsbSelectNoneInvoice.Click += tsbSelectNoneInvoice_Click;
            // 
            // tsbSelectAllInvoices
            // 
            tsbSelectAllInvoices.Name = "tsbSelectAllInvoices";
            tsbSelectAllInvoices.Size = new System.Drawing.Size(128, 24);
            tsbSelectAllInvoices.Text = "Visus";
            tsbSelectAllInvoices.Click += tsbSelectAllInvoices_Click;
            // 
            // tsdValidateInveoices
            // 
            tsdValidateInveoices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsdValidateInveoices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbValidateCurrent, tsbValidateSelected, tsbValidateAll });
            tsdValidateInveoices.Image = (System.Drawing.Image)resources.GetObject("tsdValidateInveoices.Image");
            tsdValidateInveoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsdValidateInveoices.Name = "tsdValidateInveoices";
            tsdValidateInveoices.Size = new System.Drawing.Size(81, 23);
            tsdValidateInveoices.Text = "Pārbaudīt";
            // 
            // tsbValidateCurrent
            // 
            tsbValidateCurrent.Name = "tsbValidateCurrent";
            tsbValidateCurrent.Size = new System.Drawing.Size(139, 24);
            tsbValidateCurrent.Text = "Norādīto";
            tsbValidateCurrent.Click += tsbValidateCurrent_Click;
            // 
            // tsbValidateSelected
            // 
            tsbValidateSelected.Name = "tsbValidateSelected";
            tsbValidateSelected.Size = new System.Drawing.Size(139, 24);
            tsbValidateSelected.Text = "Atzīmētos";
            tsbValidateSelected.Click += tsbValidateSelected_Click;
            // 
            // tsbValidateAll
            // 
            tsbValidateAll.Name = "tsbValidateAll";
            tsbValidateAll.Size = new System.Drawing.Size(139, 24);
            tsbValidateAll.Text = "Visus";
            tsbValidateAll.Click += tsbValidateAll_Click;
            // 
            // tsbMoveSelectedInvices
            // 
            tsbMoveSelectedInvices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbMoveSelectedInvices.Image = (System.Drawing.Image)resources.GetObject("tsbMoveSelectedInvices.Image");
            tsbMoveSelectedInvices.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbMoveSelectedInvices.Name = "tsbMoveSelectedInvices";
            tsbMoveSelectedInvices.Size = new System.Drawing.Size(131, 23);
            tsbMoveSelectedInvices.Text = "Pārvietot atzīmētos";
            tsbMoveSelectedInvices.Click += tsbMoveSelectedInvices_Click;
            // 
            // tsbShowRealInvoice
            // 
            tsbShowRealInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbShowRealInvoice.Image = (System.Drawing.Image)resources.GetObject("tsbShowRealInvoice.Image");
            tsbShowRealInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbShowRealInvoice.Name = "tsbShowRealInvoice";
            tsbShowRealInvoice.Size = new System.Drawing.Size(120, 23);
            tsbShowRealInvoice.Text = "Rādīt pilno rēķinu";
            tsbShowRealInvoice.Click += tsbShowRealInvoice_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbFilterInvoices);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btShowFolder);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbInvoiceFolder);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(782, 29);
            panel1.TabIndex = 0;
            // 
            // tbFilterInvoices
            // 
            tbFilterInvoices.Location = new System.Drawing.Point(488, 3);
            tbFilterInvoices.Name = "tbFilterInvoices";
            tbFilterInvoices.Size = new System.Drawing.Size(115, 23);
            tbFilterInvoices.TabIndex = 4;
            tbFilterInvoices.KeyDown += tbFilterInvoices_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(432, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 17);
            label3.TabIndex = 3;
            label3.Text = "Atlasīt:";
            // 
            // btShowFolder
            // 
            btShowFolder.Location = new System.Drawing.Point(300, 1);
            btShowFolder.Name = "btShowFolder";
            btShowFolder.Size = new System.Drawing.Size(92, 26);
            btShowFolder.TabIndex = 2;
            btShowFolder.Text = "Atvērt mapi";
            btShowFolder.UseVisualStyleBackColor = true;
            btShowFolder.Click += btShowFolder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 17);
            label2.TabIndex = 1;
            label2.Text = "Rēķinu mape:";
            // 
            // cbInvoiceFolder
            // 
            cbInvoiceFolder.BorderColor = System.Drawing.SystemColors.ControlText;
            cbInvoiceFolder.DrawBorder = false;
            cbInvoiceFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbInvoiceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbInvoiceFolder.FormattingEnabled = true;
            cbInvoiceFolder.Location = new System.Drawing.Point(100, 3);
            cbInvoiceFolder.MaxDropDownItems = 15;
            cbInvoiceFolder.Name = "cbInvoiceFolder";
            cbInvoiceFolder.Size = new System.Drawing.Size(178, 24);
            cbInvoiceFolder.TabIndex = 0;
            cbInvoiceFolder.SelectedIndexChanged += cbInvoiceFolder_SelectedIndexChanged;
            // 
            // tpInvoice
            // 
            tpInvoice.Controls.Add(mySplitContainer1);
            tpInvoice.Location = new System.Drawing.Point(4, 25);
            tpInvoice.Name = "tpInvoice";
            tpInvoice.Padding = new System.Windows.Forms.Padding(3);
            tpInvoice.Size = new System.Drawing.Size(788, 299);
            tpInvoice.TabIndex = 1;
            tpInvoice.Text = "Rēķins";
            tpInvoice.UseVisualStyleBackColor = true;
            // 
            // mySplitContainer1
            // 
            mySplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            mySplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            mySplitContainer1.IsSplitterFixed = true;
            mySplitContainer1.Location = new System.Drawing.Point(3, 3);
            mySplitContainer1.Name = "mySplitContainer1";
            mySplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mySplitContainer1.Panel1
            // 
            mySplitContainer1.Panel1.Controls.Add(sgrInvoice);
            mySplitContainer1.Panel1MinSize = 21;
            // 
            // mySplitContainer1.Panel2
            // 
            mySplitContainer1.Panel2.Controls.Add(dgvLines);
            mySplitContainer1.Panel2MinSize = 21;
            mySplitContainer1.Size = new System.Drawing.Size(782, 293);
            mySplitContainer1.SplitterDistance = 126;
            mySplitContainer1.SplitterWidth = 3;
            mySplitContainer1.TabIndex = 1;
            // 
            // sgrInvoice
            // 
            sgrInvoice.AllowEdit = false;
            sgrInvoice.BackColor2 = System.Drawing.SystemColors.Window;
            sgrInvoice.ColumnWidth1 = 10;
            sgrInvoice.ColumnWidth2 = 140;
            sgrInvoice.ColumnWidth3 = 100;
            sgrInvoice.DefaultHeight = 17;
            sgrInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            sgrInvoice.EnableSort = true;
            sgrInvoice.Location = new System.Drawing.Point(0, 0);
            sgrInvoice.MyDataBC = invoiceView1;
            sgrInvoice.Name = "sgrInvoice";
            sgrInvoice.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            sgrInvoice.RowList.Add(grInvoiceTitleDoc);
            sgrInvoice.RowList.Add(grInvoiceId);
            sgrInvoice.RowList.Add(grInvoiceDate);
            sgrInvoice.RowList.Add(grInvoiceDateDue);
            sgrInvoice.RowList.Add(grInvoiceTitleTotals);
            sgrInvoice.RowList.Add(grInvoiceTotalBeforeTaxes);
            sgrInvoice.RowList.Add(grInvoiceTotalVAT);
            sgrInvoice.RowList.Add(grInvoiceTotalToPay);
            sgrInvoice.RowList.Add(grInvoiceNewColumn1);
            sgrInvoice.RowList.Add(grInvoiceTitleSupplier);
            sgrInvoice.RowList.Add(grInvoiceSupplierName);
            sgrInvoice.RowList.Add(grInvoiceSupplierRenNr);
            sgrInvoice.RowList.Add(grInvoiceSupplierPVNRegNr);
            sgrInvoice.RowList.Add(grInvoiceSupplierAddress);
            sgrInvoice.RowList.Add(grInvoicePaeeAccount);
            sgrInvoice.RowList.Add(grInvoiceNewColumn2);
            sgrInvoice.RowList.Add(grInvoiceTitleCustomer);
            sgrInvoice.RowList.Add(grInvoiceCustomerName);
            sgrInvoice.RowList.Add(grInvoiceCustomerRegNr);
            sgrInvoice.RowList.Add(grInvoiceCustomerVATRegNr);
            sgrInvoice.RowList.Add(grInvoiceCustomerAddress);
            sgrInvoice.RowList.Add(gdInvoicePayerAccount);
            sgrInvoice.RowTemplateList.Add(grtLineTextBox);
            sgrInvoice.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            sgrInvoice.Size = new System.Drawing.Size(782, 126);
            sgrInvoice.TabIndex = 0;
            sgrInvoice.TabStop = true;
            sgrInvoice.ToolTipText = "";
            // 
            // invoiceView1
            // 
            invoiceView1.Checked = false;
            invoiceView1.CurrencyCode = "EUR";
            invoiceView1.CustomerAddress = null;
            invoiceView1.CustomerAddressCountry = "LV";
            invoiceView1.CustomerEndpointID = null;
            invoiceView1.CustomerID = null;
            invoiceView1.CustomerName = null;
            invoiceView1.DueDate = new System.DateTime(0L);
            invoiceView1.Email = null;
            invoiceView1.FullFileName = null;
            invoiceView1.ID = null;
            invoiceView1.InvoiceDocumentExtension = null;
            invoiceView1.IssueDate = new System.DateTime(0L);
            invoiceView1.Note = "";
            invoiceView1.PayeeFinancialAccountID = null;
            invoiceView1.PayerFinancialAccountID = null;
            invoiceView1.SubFolderName = null;
            invoiceView1.SupplierAddress = null;
            invoiceView1.SupplierAddressCountry = "LV";
            invoiceView1.SupplierEndpointID = null;
            invoiceView1.SupplierID = null;
            invoiceView1.SupplierName = null;
            invoiceView1.TotalAmount = new decimal(new int[] { 0, 0, 0, 0 });
            invoiceView1.TotalAmountBeforeTax = new decimal(new int[] { 0, 0, 0, 0 });
            invoiceView1.TotalAmountPayable = new decimal(new int[] { 0, 0, 0, 0 });
            invoiceView1.TotalAmountTax = new decimal(new int[] { 0, 0, 0, 0 });
            invoiceView1.ValidationMessage = null;
            // 
            // grInvoiceTitleDoc
            // 
            grInvoiceTitleDoc.Name = "grInvoiceTitleDoc";
            grInvoiceTitleDoc.RowTitle = "Rēķins";
            // 
            // grInvoiceId
            // 
            grInvoiceId.AllowNull = true;
            grInvoiceId.DataMember = "ID";
            grInvoiceId.DataSource = bsInvoiceList;
            grInvoiceId.GridPropertyName = "ID";
            grInvoiceId.Name = "grInvoiceId";
            grInvoiceId.RowTitle = "Numurs";
            grInvoiceId.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.IntegerN;
            // 
            // grInvoiceDate
            // 
            grInvoiceDate.AllowNull = true;
            grInvoiceDate.DataMember = "IssueDate";
            grInvoiceDate.DataSource = bsInvoiceList;
            grInvoiceDate.GridPropertyName = "IssueDate";
            grInvoiceDate.Name = "grInvoiceDate";
            grInvoiceDate.RowTitle = "Datums";
            grInvoiceDate.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // grInvoiceDateDue
            // 
            grInvoiceDateDue.AllowNull = true;
            grInvoiceDateDue.DataMember = "DueDate";
            grInvoiceDateDue.DataSource = bsInvoiceList;
            grInvoiceDateDue.GridPropertyName = "DueDate";
            grInvoiceDateDue.Name = "grInvoiceDateDue";
            grInvoiceDateDue.RowTitle = "Apmaksas termiņš";
            grInvoiceDateDue.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DateN;
            // 
            // grInvoiceTitleTotals
            // 
            grInvoiceTitleTotals.Name = "grInvoiceTitleTotals";
            grInvoiceTitleTotals.RowTitle = "Kopsummas";
            // 
            // grInvoiceTotalBeforeTaxes
            // 
            grInvoiceTotalBeforeTaxes.AllowNull = true;
            grInvoiceTotalBeforeTaxes.DataMember = "TotalAmountBeforeTax";
            grInvoiceTotalBeforeTaxes.DataSource = bsInvoiceList;
            grInvoiceTotalBeforeTaxes.GridPropertyName = "TotalAmountBeforeTax";
            grInvoiceTotalBeforeTaxes.Name = "grInvoiceTotalBeforeTaxes";
            grInvoiceTotalBeforeTaxes.RowTitle = "Bez PVN";
            grInvoiceTotalBeforeTaxes.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DecimalN;
            grInvoiceTotalBeforeTaxes.TextAllign = KlonsLIB.MySourceGrid.GridRows.ECellTextAllign.Right;
            // 
            // grInvoiceTotalVAT
            // 
            grInvoiceTotalVAT.AllowNull = true;
            grInvoiceTotalVAT.DataMember = "TotalAmountTax";
            grInvoiceTotalVAT.DataSource = bsInvoiceList;
            grInvoiceTotalVAT.GridPropertyName = "TotalAmountTax";
            grInvoiceTotalVAT.Name = "grInvoiceTotalVAT";
            grInvoiceTotalVAT.RowTitle = "PVN";
            grInvoiceTotalVAT.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DecimalN;
            grInvoiceTotalVAT.TextAllign = KlonsLIB.MySourceGrid.GridRows.ECellTextAllign.Right;
            // 
            // grInvoiceTotalToPay
            // 
            grInvoiceTotalToPay.AllowNull = true;
            grInvoiceTotalToPay.DataMember = "TotalAmountPayable";
            grInvoiceTotalToPay.DataSource = bsInvoiceList;
            grInvoiceTotalToPay.GridPropertyName = "TotalAmountPayable";
            grInvoiceTotalToPay.Name = "grInvoiceTotalToPay";
            grInvoiceTotalToPay.RowTitle = "Kopā";
            grInvoiceTotalToPay.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.DecimalN;
            grInvoiceTotalToPay.TextAllign = KlonsLIB.MySourceGrid.GridRows.ECellTextAllign.Right;
            // 
            // grInvoiceNewColumn1
            // 
            grInvoiceNewColumn1.CaptionColumnWidth = 100;
            grInvoiceNewColumn1.Command = KlonsLIB.MySourceGrid.GridRows.EMyGridRowCommands.StartNewColumn;
            grInvoiceNewColumn1.DataColumnWidth = 200;
            grInvoiceNewColumn1.Name = "grInvoiceNewColumn1";
            grInvoiceNewColumn1.RowTitle = null;
            grInvoiceNewColumn1.SetColumnWidth = true;
            // 
            // grInvoiceTitleSupplier
            // 
            grInvoiceTitleSupplier.Name = "grInvoiceTitleSupplier";
            grInvoiceTitleSupplier.RowTitle = "Piegādātajs";
            // 
            // grInvoiceSupplierName
            // 
            grInvoiceSupplierName.DataMember = "SupplierName";
            grInvoiceSupplierName.DataSource = bsInvoiceList;
            grInvoiceSupplierName.EditorTemplateName = "grtLineTextBox";
            grInvoiceSupplierName.GridPropertyName = "SupplierName";
            grInvoiceSupplierName.Name = "grInvoiceSupplierName";
            grInvoiceSupplierName.RowTitle = "Nosaukums";
            grInvoiceSupplierName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceSupplierRenNr
            // 
            grInvoiceSupplierRenNr.DataMember = "SupplierID";
            grInvoiceSupplierRenNr.DataSource = bsInvoiceList;
            grInvoiceSupplierRenNr.EditorTemplateName = "grtLineTextBox";
            grInvoiceSupplierRenNr.GridPropertyName = "SupplierID";
            grInvoiceSupplierRenNr.Name = "grInvoiceSupplierRenNr";
            grInvoiceSupplierRenNr.RowTitle = "Reģ.nr.";
            grInvoiceSupplierRenNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceSupplierPVNRegNr
            // 
            grInvoiceSupplierPVNRegNr.DataMember = "SupplierEndpointID";
            grInvoiceSupplierPVNRegNr.DataSource = bsInvoiceList;
            grInvoiceSupplierPVNRegNr.EditorTemplateName = "grtLineTextBox";
            grInvoiceSupplierPVNRegNr.GridPropertyName = "SupplierEndpointID";
            grInvoiceSupplierPVNRegNr.Name = "grInvoiceSupplierPVNRegNr";
            grInvoiceSupplierPVNRegNr.RowTitle = "PVN reģ.nr.";
            grInvoiceSupplierPVNRegNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceSupplierAddress
            // 
            grInvoiceSupplierAddress.DataMember = "SupplierAddress";
            grInvoiceSupplierAddress.DataSource = bsInvoiceList;
            grInvoiceSupplierAddress.EditorTemplateName = "grtLineTextBox";
            grInvoiceSupplierAddress.GridPropertyName = "SupplierAddress";
            grInvoiceSupplierAddress.Name = "grInvoiceSupplierAddress";
            grInvoiceSupplierAddress.RowTitle = "Adrese";
            grInvoiceSupplierAddress.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoicePaeeAccount
            // 
            grInvoicePaeeAccount.AllowNull = true;
            grInvoicePaeeAccount.DataMember = "PayeeFinancialAccountID";
            grInvoicePaeeAccount.DataSource = bsInvoiceList;
            grInvoicePaeeAccount.GridPropertyName = "PayeeFinancialAccountID";
            grInvoicePaeeAccount.Name = "grInvoicePaeeAccount";
            grInvoicePaeeAccount.RowTitle = "Bankas konts";
            grInvoicePaeeAccount.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceNewColumn2
            // 
            grInvoiceNewColumn2.Command = KlonsLIB.MySourceGrid.GridRows.EMyGridRowCommands.StartNewColumn;
            grInvoiceNewColumn2.Name = "grInvoiceNewColumn2";
            grInvoiceNewColumn2.RowTitle = null;
            // 
            // grInvoiceTitleCustomer
            // 
            grInvoiceTitleCustomer.Name = "grInvoiceTitleCustomer";
            grInvoiceTitleCustomer.RowTitle = "Saņēmējs";
            // 
            // grInvoiceCustomerName
            // 
            grInvoiceCustomerName.DataMember = "CustomerName";
            grInvoiceCustomerName.DataSource = bsInvoiceList;
            grInvoiceCustomerName.GridPropertyName = "CustomerName";
            grInvoiceCustomerName.Name = "grInvoiceCustomerName";
            grInvoiceCustomerName.RowTitle = "Nosaukums";
            grInvoiceCustomerName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceCustomerRegNr
            // 
            grInvoiceCustomerRegNr.DataMember = "CustomerID";
            grInvoiceCustomerRegNr.DataSource = bsInvoiceList;
            grInvoiceCustomerRegNr.GridPropertyName = "CustomerID";
            grInvoiceCustomerRegNr.Name = "grInvoiceCustomerRegNr";
            grInvoiceCustomerRegNr.RowTitle = "Reģ.nr.";
            grInvoiceCustomerRegNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceCustomerVATRegNr
            // 
            grInvoiceCustomerVATRegNr.DataMember = "CustomerEndpointID";
            grInvoiceCustomerVATRegNr.DataSource = bsInvoiceList;
            grInvoiceCustomerVATRegNr.GridPropertyName = "CustomerEndpointID";
            grInvoiceCustomerVATRegNr.Name = "grInvoiceCustomerVATRegNr";
            grInvoiceCustomerVATRegNr.RowTitle = "PVN reģ.nr.";
            grInvoiceCustomerVATRegNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grInvoiceCustomerAddress
            // 
            grInvoiceCustomerAddress.DataMember = "CustomerAddress";
            grInvoiceCustomerAddress.DataSource = bsInvoiceList;
            grInvoiceCustomerAddress.GridPropertyName = "CustomerAddress";
            grInvoiceCustomerAddress.Name = "grInvoiceCustomerAddress";
            grInvoiceCustomerAddress.RowTitle = "Adrese";
            grInvoiceCustomerAddress.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // gdInvoicePayerAccount
            // 
            gdInvoicePayerAccount.AllowNull = true;
            gdInvoicePayerAccount.DataMember = "PayerFinancialAccountID";
            gdInvoicePayerAccount.DataSource = bsInvoiceList;
            gdInvoicePayerAccount.GridPropertyName = "PayerFinancialAccountID";
            gdInvoicePayerAccount.Name = "gdInvoicePayerAccount";
            gdInvoicePayerAccount.RowTitle = "Bankas konts";
            gdInvoicePayerAccount.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grtLineTextBox
            // 
            grtLineTextBox.Name = "grtLineTextBox";
            grtLineTextBox.RowTitle = null;
            grtLineTextBox.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // dgvLines
            // 
            dgvLines.AllowUserToAddRows = false;
            dgvLines.AllowUserToDeleteRows = false;
            dgvLines.AllowUserToResizeRows = false;
            dgvLines.AutoGenerateColumns = false;
            dgvLines.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcLineId, dgcLineItemName, dgcLineQuantity, dgcLineUnit, dgcLinePrice, dgcLineAllowanceCharge, dgcLineTotalAmountBeforeTax, dgcLineVatRate, dgcLineVatType, dgcLineTotalAmount });
            dgvLines.DataSource = bsInvoiceLines;
            dgvLines.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvLines.Location = new System.Drawing.Point(0, 0);
            dgvLines.Name = "dgvLines";
            dgvLines.ReadOnly = true;
            dgvLines.RowHeadersWidth = 30;
            dgvLines.RowTemplate.Height = 25;
            dgvLines.Size = new System.Drawing.Size(782, 164);
            dgvLines.TabIndex = 0;
            // 
            // dgcLineId
            // 
            dgcLineId.DataPropertyName = "ID";
            dgcLineId.HeaderText = "ID";
            dgcLineId.Name = "dgcLineId";
            dgcLineId.ReadOnly = true;
            dgcLineId.Width = 90;
            // 
            // dgcLineItemName
            // 
            dgcLineItemName.DataPropertyName = "ItemName";
            dgcLineItemName.HeaderText = "nosaukums";
            dgcLineItemName.Name = "dgcLineItemName";
            dgcLineItemName.ReadOnly = true;
            dgcLineItemName.Width = 200;
            // 
            // dgcLineQuantity
            // 
            dgcLineQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dgcLineQuantity.DefaultCellStyle = dataGridViewCellStyle10;
            dgcLineQuantity.HeaderText = "daudzums";
            dgcLineQuantity.Name = "dgcLineQuantity";
            dgcLineQuantity.ReadOnly = true;
            dgcLineQuantity.Width = 80;
            // 
            // dgcLineUnit
            // 
            dgcLineUnit.DataPropertyName = "Unit";
            dgcLineUnit.HeaderText = "mērv.";
            dgcLineUnit.Name = "dgcLineUnit";
            dgcLineUnit.ReadOnly = true;
            dgcLineUnit.ToolTipText = "mērvienība";
            dgcLineUnit.Width = 60;
            // 
            // dgcLinePrice
            // 
            dgcLinePrice.DataPropertyName = "Price";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "0.######";
            dgcLinePrice.DefaultCellStyle = dataGridViewCellStyle11;
            dgcLinePrice.HeaderText = "cena";
            dgcLinePrice.Name = "dgcLinePrice";
            dgcLinePrice.ReadOnly = true;
            dgcLinePrice.Width = 80;
            // 
            // dgcLineAllowanceCharge
            // 
            dgcLineAllowanceCharge.DataPropertyName = "AllowanceCharge";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dgcLineAllowanceCharge.DefaultCellStyle = dataGridViewCellStyle12;
            dgcLineAllowanceCharge.HeaderText = "atlaide";
            dgcLineAllowanceCharge.Name = "dgcLineAllowanceCharge";
            dgcLineAllowanceCharge.ReadOnly = true;
            dgcLineAllowanceCharge.Width = 80;
            // 
            // dgcLineTotalAmountBeforeTax
            // 
            dgcLineTotalAmountBeforeTax.DataPropertyName = "TotalAmountBeforeTax";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dgcLineTotalAmountBeforeTax.DefaultCellStyle = dataGridViewCellStyle13;
            dgcLineTotalAmountBeforeTax.HeaderText = "suma";
            dgcLineTotalAmountBeforeTax.Name = "dgcLineTotalAmountBeforeTax";
            dgcLineTotalAmountBeforeTax.ReadOnly = true;
            dgcLineTotalAmountBeforeTax.Width = 90;
            // 
            // dgcLineVatRate
            // 
            dgcLineVatRate.DataPropertyName = "VatRate";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcLineVatRate.DefaultCellStyle = dataGridViewCellStyle14;
            dgcLineVatRate.HeaderText = "PVN likme";
            dgcLineVatRate.Name = "dgcLineVatRate";
            dgcLineVatRate.ReadOnly = true;
            dgcLineVatRate.Width = 60;
            // 
            // dgcLineVatType
            // 
            dgcLineVatType.DataPropertyName = "VatType";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcLineVatType.DefaultCellStyle = dataGridViewCellStyle15;
            dgcLineVatType.HeaderText = "PVN vaids";
            dgcLineVatType.Name = "dgcLineVatType";
            dgcLineVatType.ReadOnly = true;
            dgcLineVatType.Width = 60;
            // 
            // dgcLineTotalAmount
            // 
            dgcLineTotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dgcLineTotalAmount.DefaultCellStyle = dataGridViewCellStyle16;
            dgcLineTotalAmount.HeaderText = "kopā ar PVN";
            dgcLineTotalAmount.Name = "dgcLineTotalAmount";
            dgcLineTotalAmount.ReadOnly = true;
            dgcLineTotalAmount.Width = 90;
            // 
            // bsInvoiceLines
            // 
            bsInvoiceLines.DataSource = typeof(DataObjectsEI.InvoiceLine);
            // 
            // tpErrors
            // 
            tpErrors.Controls.Add(tbErrors);
            tpErrors.Location = new System.Drawing.Point(4, 25);
            tpErrors.Name = "tpErrors";
            tpErrors.Padding = new System.Windows.Forms.Padding(3);
            tpErrors.Size = new System.Drawing.Size(788, 299);
            tpErrors.TabIndex = 3;
            tpErrors.Text = "Kļūdas";
            tpErrors.UseVisualStyleBackColor = true;
            // 
            // tbErrors
            // 
            tbErrors.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            tbErrors.Location = new System.Drawing.Point(3, 3);
            tbErrors.Name = "tbErrors";
            tbErrors.Size = new System.Drawing.Size(782, 293);
            tbErrors.TabIndex = 0;
            tbErrors.Text = "";
            // 
            // tpSendPerEmail
            // 
            tpSendPerEmail.Controls.Add(toolStrip1);
            tpSendPerEmail.Controls.Add(lbSendEmailInfo);
            tpSendPerEmail.Controls.Add(cmSendEmail);
            tpSendPerEmail.Controls.Add(tbSenderEmailBody);
            tpSendPerEmail.Controls.Add(tbSenderEmailPassword);
            tpSendPerEmail.Controls.Add(label10);
            tpSendPerEmail.Controls.Add(label9);
            tpSendPerEmail.Controls.Add(label8);
            tpSendPerEmail.Controls.Add(label7);
            tpSendPerEmail.Controls.Add(label6);
            tpSendPerEmail.Controls.Add(tbSenderEmailSubject);
            tpSendPerEmail.Controls.Add(cbSenderEmailTemplates);
            tpSendPerEmail.Controls.Add(tbSenderEmail);
            tpSendPerEmail.Location = new System.Drawing.Point(4, 25);
            tpSendPerEmail.Name = "tpSendPerEmail";
            tpSendPerEmail.Padding = new System.Windows.Forms.Padding(3);
            tpSendPerEmail.Size = new System.Drawing.Size(788, 299);
            tpSendPerEmail.TabIndex = 4;
            tpSendPerEmail.Text = "Sūtīt pa e-pastu";
            tpSendPerEmail.UseVisualStyleBackColor = true;
            tpSendPerEmail.Enter += tpSendPerEmail_Enter;
            tpSendPerEmail.Leave += tpSendPerEmail_Leave;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbNewEmailTemplate, tsbSenderEditTemplateName, tsbDeleteEmailTemplate, toolStripDropDownButton1 });
            toolStrip1.Location = new System.Drawing.Point(571, 61);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(137, 26);
            toolStrip1.TabIndex = 13;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewEmailTemplate
            // 
            tsbNewEmailTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbNewEmailTemplate.Image = (System.Drawing.Image)resources.GetObject("tsbNewEmailTemplate.Image");
            tsbNewEmailTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbNewEmailTemplate.Name = "tsbNewEmailTemplate";
            tsbNewEmailTemplate.Size = new System.Drawing.Size(23, 23);
            tsbNewEmailTemplate.Text = "Pievienot";
            tsbNewEmailTemplate.Click += tsbNewEmailTemplate_Click;
            // 
            // tsbSenderEditTemplateName
            // 
            tsbSenderEditTemplateName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSenderEditTemplateName.Image = (System.Drawing.Image)resources.GetObject("tsbSenderEditTemplateName.Image");
            tsbSenderEditTemplateName.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSenderEditTemplateName.Name = "tsbSenderEditTemplateName";
            tsbSenderEditTemplateName.Size = new System.Drawing.Size(23, 23);
            tsbSenderEditTemplateName.Text = "Mainīt nosaukumu";
            tsbSenderEditTemplateName.Click += tsbSenderEditTemplateName_Click;
            // 
            // tsbDeleteEmailTemplate
            // 
            tsbDeleteEmailTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbDeleteEmailTemplate.Image = (System.Drawing.Image)resources.GetObject("tsbDeleteEmailTemplate.Image");
            tsbDeleteEmailTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDeleteEmailTemplate.Name = "tsbDeleteEmailTemplate";
            tsbDeleteEmailTemplate.Size = new System.Drawing.Size(23, 23);
            tsbDeleteEmailTemplate.Text = "Dzēst";
            tsbDeleteEmailTemplate.Click += tsbDeleteEmailTemplate_Click;
            // 
            // lbSendEmailInfo
            // 
            lbSendEmailInfo.AutoSize = true;
            lbSendEmailInfo.Location = new System.Drawing.Point(8, 3);
            lbSendEmailInfo.Name = "lbSendEmailInfo";
            lbSendEmailInfo.Size = new System.Drawing.Size(16, 17);
            lbSendEmailInfo.TabIndex = 12;
            lbSendEmailInfo.Text = "..";
            // 
            // cmSendEmail
            // 
            cmSendEmail.Location = new System.Drawing.Point(581, 15);
            cmSendEmail.Name = "cmSendEmail";
            cmSendEmail.Size = new System.Drawing.Size(93, 29);
            cmSendEmail.TabIndex = 11;
            cmSendEmail.Text = "Sūtīt";
            cmSendEmail.UseVisualStyleBackColor = true;
            cmSendEmail.Click += cmSendEmail_Click;
            // 
            // tbSenderEmailBody
            // 
            tbSenderEmailBody.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSenderEmailBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbSenderEmailBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsSenderEmailTemplates, "Body", true));
            tbSenderEmailBody.Location = new System.Drawing.Point(130, 124);
            tbSenderEmailBody.Name = "tbSenderEmailBody";
            tbSenderEmailBody.Size = new System.Drawing.Size(544, 139);
            tbSenderEmailBody.TabIndex = 10;
            tbSenderEmailBody.Text = "";
            // 
            // bsSenderEmailTemplates
            // 
            bsSenderEmailTemplates.DataSource = typeof(Classes.EInvoiceManagerConfig_EMailTemplate);
            // 
            // tbSenderEmailPassword
            // 
            tbSenderEmailPassword.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSenderEmailPassword.Location = new System.Drawing.Point(336, 30);
            tbSenderEmailPassword.Name = "tbSenderEmailPassword";
            tbSenderEmailPassword.Size = new System.Drawing.Size(161, 23);
            tbSenderEmailPassword.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(280, 32);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 17);
            label10.TabIndex = 8;
            label10.Text = "parole:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(107, 17);
            label9.TabIndex = 7;
            label9.Text = "Vēstules teksts:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(8, 92);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 17);
            label8.TabIndex = 6;
            label8.Text = "Vēstules temats:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(8, 62);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 17);
            label7.TabIndex = 5;
            label7.Text = "E-pasta sagatave:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 17);
            label6.TabIndex = 4;
            label6.Text = "E-pasts:";
            // 
            // tbSenderEmailSubject
            // 
            tbSenderEmailSubject.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSenderEmailSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", bsSenderEmailTemplates, "Subject", true));
            tbSenderEmailSubject.Location = new System.Drawing.Point(130, 92);
            tbSenderEmailSubject.Name = "tbSenderEmailSubject";
            tbSenderEmailSubject.Size = new System.Drawing.Size(543, 23);
            tbSenderEmailSubject.TabIndex = 2;
            // 
            // cbSenderEmailTemplates
            // 
            cbSenderEmailTemplates.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbSenderEmailTemplates.DataSource = bsSenderEmailTemplates;
            cbSenderEmailTemplates.DisplayMember = "Name";
            cbSenderEmailTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSenderEmailTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbSenderEmailTemplates.FormattingEnabled = true;
            cbSenderEmailTemplates.Location = new System.Drawing.Point(130, 60);
            cbSenderEmailTemplates.Name = "cbSenderEmailTemplates";
            cbSenderEmailTemplates.Size = new System.Drawing.Size(426, 24);
            cbSenderEmailTemplates.TabIndex = 1;
            cbSenderEmailTemplates.ValueMember = "Name";
            // 
            // tbSenderEmail
            // 
            tbSenderEmail.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSenderEmail.Location = new System.Drawing.Point(71, 30);
            tbSenderEmail.Name = "tbSenderEmail";
            tbSenderEmail.ReadOnly = true;
            tbSenderEmail.Size = new System.Drawing.Size(188, 23);
            tbSenderEmail.TabIndex = 0;
            // 
            // tpSettings
            // 
            tpSettings.Controls.Add(tbSettingsEmailServerPort);
            tpSettings.Controls.Add(tbSettingsEmailServer);
            tpSettings.Controls.Add(label14);
            tpSettings.Controls.Add(label13);
            tpSettings.Controls.Add(label12);
            tpSettings.Controls.Add(label11);
            tpSettings.Controls.Add(cmSetEmailPassword);
            tpSettings.Controls.Add(lbEmailPasswordStatuss);
            tpSettings.Controls.Add(tbSettingsEmail);
            tpSettings.Controls.Add(label5);
            tpSettings.Controls.Add(label4);
            tpSettings.Controls.Add(label1);
            tpSettings.Controls.Add(tbSettingsFileFolder);
            tpSettings.Location = new System.Drawing.Point(4, 25);
            tpSettings.Name = "tpSettings";
            tpSettings.Padding = new System.Windows.Forms.Padding(3);
            tpSettings.Size = new System.Drawing.Size(788, 299);
            tpSettings.TabIndex = 2;
            tpSettings.Text = "Iestatijumi";
            tpSettings.UseVisualStyleBackColor = true;
            tpSettings.Enter += tpSettings_Enter;
            tpSettings.Leave += tpSettings_Leave;
            // 
            // tbSettingsEmailServerPort
            // 
            tbSettingsEmailServerPort.Location = new System.Drawing.Point(409, 79);
            tbSettingsEmailServerPort.Name = "tbSettingsEmailServerPort";
            tbSettingsEmailServerPort.Size = new System.Drawing.Size(66, 23);
            tbSettingsEmailServerPort.TabIndex = 3;
            // 
            // tbSettingsEmailServer
            // 
            tbSettingsEmailServer.Location = new System.Drawing.Point(144, 79);
            tbSettingsEmailServer.Name = "tbSettingsEmailServer";
            tbSettingsEmailServer.Size = new System.Drawing.Size(164, 23);
            tbSettingsEmailServer.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(314, 82);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(96, 17);
            label14.TabIndex = 11;
            label14.Text = "servera ports:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(18, 82);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(108, 17);
            label13.TabIndex = 8;
            label13.Text = "servera adrese:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(18, 55);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(108, 17);
            label12.TabIndex = 7;
            label12.Text = "e-pasta adrese:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(18, 159);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(430, 51);
            label11.TabIndex = 12;
            label11.Text = "Daudzi e-pasta pakalpojumu sniedzēji neatļauj web paroli izmantot \r\ncitās aplikācijās, kurām ir nepieciešams izveidot speciālu paroli.\r\nTo var izdarī šo e-pasta pakalpojumu sniedzēju web lapās.";
            // 
            // cmSetEmailPassword
            // 
            cmSetEmailPassword.Location = new System.Drawing.Point(18, 127);
            cmSetEmailPassword.Name = "cmSetEmailPassword";
            cmSetEmailPassword.Size = new System.Drawing.Size(137, 29);
            cmSetEmailPassword.TabIndex = 4;
            cmSetEmailPassword.Text = "Nomainīt paroli";
            cmSetEmailPassword.UseVisualStyleBackColor = true;
            cmSetEmailPassword.Click += cmSetEmailPassword_Click;
            // 
            // lbEmailPasswordStatuss
            // 
            lbEmailPasswordStatuss.AutoSize = true;
            lbEmailPasswordStatuss.ForeColor = System.Drawing.Color.Red;
            lbEmailPasswordStatuss.Location = new System.Drawing.Point(124, 109);
            lbEmailPasswordStatuss.Name = "lbEmailPasswordStatuss";
            lbEmailPasswordStatuss.Size = new System.Drawing.Size(16, 17);
            lbEmailPasswordStatuss.TabIndex = 10;
            lbEmailPasswordStatuss.Text = "..";
            // 
            // tbSettingsEmail
            // 
            tbSettingsEmail.Location = new System.Drawing.Point(144, 52);
            tbSettingsEmail.Name = "tbSettingsEmail";
            tbSettingsEmail.Size = new System.Drawing.Size(226, 23);
            tbSettingsEmail.TabIndex = 1;
            tbSettingsEmail.Leave += tbSettingsEmail_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 109);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 17);
            label5.TabIndex = 9;
            label5.Text = "E-pasta parole:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(260, 17);
            label4.TabIndex = 6;
            label4.Text = "Uzņēmuma e-pasts e-rēķinu izsūtīsanai:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 17);
            label1.TabIndex = 5;
            label1.Text = "E-rēķinu failu mape:";
            // 
            // tbSettingsFileFolder
            // 
            tbSettingsFileFolder.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSettingsFileFolder.Location = new System.Drawing.Point(144, 7);
            tbSettingsFileFolder.Name = "tbSettingsFileFolder";
            tbSettingsFileFolder.ShowButton = true;
            tbSettingsFileFolder.Size = new System.Drawing.Size(357, 23);
            tbSettingsFileFolder.TabIndex = 0;
            tbSettingsFileFolder.ButtonClicked += tbSettingsFileFolder_ButtonClicked;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbTemplateCodeSenderName, tsbTemplateCodeReceiverName, tsbTemplateCodeInvoiceId });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(34, 23);
            toolStripDropDownButton1.Text = "▼";
            toolStripDropDownButton1.ToolTipText = "Ielikt sagatavē lauka kodu";
            // 
            // tsbTemplateCodeSenderName
            // 
            tsbTemplateCodeSenderName.Name = "tsbTemplateCodeSenderName";
            tsbTemplateCodeSenderName.Size = new System.Drawing.Size(210, 24);
            tsbTemplateCodeSenderName.Text = "Sūtītāja nosaukums";
            tsbTemplateCodeSenderName.Click += tsbTemplateCodeSenderName_Click;
            // 
            // tsbTemplateCodeReceiverName
            // 
            tsbTemplateCodeReceiverName.Name = "tsbTemplateCodeReceiverName";
            tsbTemplateCodeReceiverName.Size = new System.Drawing.Size(210, 24);
            tsbTemplateCodeReceiverName.Text = "Saņēmēja nosaukums";
            tsbTemplateCodeReceiverName.Click += tsbTemplateCodeReceiverName_Click;
            // 
            // tsbTemplateCodeInvoiceId
            // 
            tsbTemplateCodeInvoiceId.Name = "tsbTemplateCodeInvoiceId";
            tsbTemplateCodeInvoiceId.Size = new System.Drawing.Size(210, 24);
            tsbTemplateCodeInvoiceId.Text = "Rēķina numurs";
            tsbTemplateCodeInvoiceId.Click += tsbTemplateCodeInvoiceId_Click;
            // 
            // Form_EInvoiceManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(796, 328);
            Controls.Add(tcTabs);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form_EInvoiceManager";
            Text = "e-Rēķinu pārlūks";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Shown += Form1_Shown;
            tcTabs.ResumeLayout(false);
            tpInvoiceList.ResumeLayout(false);
            tpInvoiceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsInvoiceList).EndInit();
            tspInvoiceList.ResumeLayout(false);
            tspInvoiceList.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpInvoice.ResumeLayout(false);
            mySplitContainer1.Panel1.ResumeLayout(false);
            mySplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mySplitContainer1).EndInit();
            mySplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsInvoiceLines).EndInit();
            tpErrors.ResumeLayout(false);
            tpSendPerEmail.ResumeLayout(false);
            tpSendPerEmail.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsSenderEmailTemplates).EndInit();
            tpSettings.ResumeLayout(false);
            tpSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private KlonsLIB.Components.ExTabControl tcTabs;
        private System.Windows.Forms.TabPage tpInvoiceList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpInvoice;
        private System.Windows.Forms.TabPage tpSettings;
        private KlonsLIB.Components.MyDataGridView dgvInvoiceList;
        private System.Windows.Forms.BindingSource bsInvoiceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.TextBoxWithButton tbSettingsFileFolder;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.FlatComboBox cbInvoiceFolder;
        private System.Windows.Forms.TabPage tpErrors;
        private KlonsLIB.Components.FlatRichTextBox tbErrors;
        private System.Windows.Forms.ToolStrip tspInvoiceList;
        private System.Windows.Forms.ToolStripButton tsbShowInvoice;
        private System.Windows.Forms.ToolStripDropDownButton tsdSelectInveoices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsbSelectAllInvoices;
        private System.Windows.Forms.ToolStripMenuItem tsbSelectNoneInvoice;
        private System.Windows.Forms.ToolStripDropDownButton tsdValidateInveoices;
        private System.Windows.Forms.ToolStripMenuItem tsbValidateCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsbValidateSelected;
        private System.Windows.Forms.ToolStripMenuItem tsbValidateAll;
        private System.Windows.Forms.ToolStripButton tsbMoveSelectedInvices;
        private System.Windows.Forms.Button btShowFolder;
        private DataObjectsEI.InvoiceView invoiceView1;
        private System.Windows.Forms.BindingSource bsInvoiceLines;
        private KlonsLIB.MySourceGrid.MyGrid sgrInvoice;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grInvoiceTitleSupplier;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceSupplierName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceSupplierRenNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grtLineTextBox;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceSupplierPVNRegNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceSupplierAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grInvoiceTitleDoc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceId;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceDate;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceDateDue;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand grInvoiceNewColumn1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grInvoiceTitleTotals;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceTotalBeforeTaxes;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceTotalVAT;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceTotalToPay;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grInvoiceTitleCustomer;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceCustomerName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceCustomerRegNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceCustomerVATRegNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoiceCustomerAddress;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowCommand grInvoiceNewColumn2;
        private KlonsLIB.Components.MySplitContainer mySplitContainer1;
        private KlonsLIB.Components.MyDataGridView dgvLines;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grInvoicePaeeAccount;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA gdInvoicePayerAccount;
        private System.Windows.Forms.TextBox tbFilterInvoices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsbShowRealInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineAllowanceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineTotalAmountBeforeTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineVatRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineVatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLineTotalAmount;
        private System.Windows.Forms.Label lbEmailPasswordStatuss;
        private System.Windows.Forms.TextBox tbSettingsEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmSetEmailPassword;
        private System.Windows.Forms.TabPage tpSendPerEmail;
        private KlonsLIB.Components.MyTextBox tbSenderEmailSubject;
        private KlonsLIB.Components.FlatComboBox cbSenderEmailTemplates;
        private KlonsLIB.Components.MyTextBox tbSenderEmail;
        private KlonsLIB.Components.MyTextBox tbSenderEmailPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmSendEmail;
        private KlonsLIB.Components.FlatRichTextBox tbSenderEmailBody;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewEmailTemplate;
        private System.Windows.Forms.ToolStripButton tsbDeleteEmailTemplate;
        private System.Windows.Forms.Label lbSendEmailInfo;
        private System.Windows.Forms.BindingSource bsSenderEmailTemplates;
        private System.Windows.Forms.ToolStripButton tsbSenderEditTemplateName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSettingsEmailServerPort;
        private System.Windows.Forms.TextBox tbSettingsEmailServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private KlonsLIB.Components.MyDgvCheckBoxColumn dgcInvoiceChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceDocumentExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceValidationMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInviceIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInveiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInveiceSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceEmail;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsbTemplateCodeSenderName;
        private System.Windows.Forms.ToolStripMenuItem tsbTemplateCodeReceiverName;
        private System.Windows.Forms.ToolStripMenuItem tsbTemplateCodeInvoiceId;
    }
}
