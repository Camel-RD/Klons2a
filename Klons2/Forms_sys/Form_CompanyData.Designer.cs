namespace KlonsF.Forms
{
    partial class Form_CompanyData
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
            companyData1 = new Classes.CompanyData();
            myGrid1 = new KlonsLIB.MySourceGrid.MyGrid();
            grCompanyTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grCompanyName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompRegNr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompRegNrPVN = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompVID = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grAdreseTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grCompAddr = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddr1 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddr2 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddr3 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddr4 = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddrInd = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAddrG = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompEMail = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grManTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grCompMName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompMpk = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompPhone = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grAccTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grCompAccName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grCompAccPh = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grBankTitle = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle();
            grBankId = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grBankName = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grBankAcc = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            grtString = new KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA();
            SuspendLayout();
            // 
            // companyData1
            // 
            companyData1._BankAcc = null;
            companyData1._BankId = null;
            companyData1._BankName = null;
            companyData1._CompAccName = null;
            companyData1._CompAccPh = null;
            companyData1._CompAddr = null;
            companyData1._CompAddr1 = null;
            companyData1._CompAddr2 = null;
            companyData1._CompAddr3 = null;
            companyData1._CompAddr4 = null;
            companyData1._CompAddrG = null;
            companyData1._CompAddrInd = null;
            companyData1._CompEMail = null;
            companyData1._CompMName = null;
            companyData1._CompMpk = null;
            companyData1._CompName = null;
            companyData1._CompPhone = null;
            companyData1._CompRegNr = null;
            companyData1._CompRegNrPVN = null;
            companyData1._CompVID = null;
            // 
            // myGrid1
            // 
            myGrid1.BackColor2 = System.Drawing.SystemColors.Window;
            myGrid1.ColumnWidth1 = 15;
            myGrid1.ColumnWidth2 = 200;
            myGrid1.ColumnWidth3 = 400;
            myGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            myGrid1.EnableSort = true;
            myGrid1.Location = new System.Drawing.Point(0, 0);
            myGrid1.Margin = new System.Windows.Forms.Padding(2);
            myGrid1.MyDataBC = companyData1;
            myGrid1.Name = "myGrid1";
            myGrid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            myGrid1.RowList.Add(grCompanyTitle);
            myGrid1.RowList.Add(grCompanyName);
            myGrid1.RowList.Add(grCompRegNr);
            myGrid1.RowList.Add(grCompRegNrPVN);
            myGrid1.RowList.Add(grCompVID);
            myGrid1.RowList.Add(grAdreseTitle);
            myGrid1.RowList.Add(grCompAddr);
            myGrid1.RowList.Add(grCompAddr1);
            myGrid1.RowList.Add(grCompAddr2);
            myGrid1.RowList.Add(grCompAddr3);
            myGrid1.RowList.Add(grCompAddr4);
            myGrid1.RowList.Add(grCompAddrInd);
            myGrid1.RowList.Add(grCompAddrG);
            myGrid1.RowList.Add(grCompEMail);
            myGrid1.RowList.Add(grManTitle);
            myGrid1.RowList.Add(grCompMName);
            myGrid1.RowList.Add(grCompMpk);
            myGrid1.RowList.Add(grCompPhone);
            myGrid1.RowList.Add(grAccTitle);
            myGrid1.RowList.Add(grCompAccName);
            myGrid1.RowList.Add(grCompAccPh);
            myGrid1.RowList.Add(grBankTitle);
            myGrid1.RowList.Add(grBankId);
            myGrid1.RowList.Add(grBankName);
            myGrid1.RowList.Add(grBankAcc);
            myGrid1.RowTemplateList.Add(grtString);
            myGrid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            myGrid1.Size = new System.Drawing.Size(574, 347);
            myGrid1.TabIndex = 0;
            myGrid1.TabStop = true;
            myGrid1.ToolTipText = "";
            // 
            // grCompanyTitle
            // 
            grCompanyTitle.Name = "grCompanyTitle";
            grCompanyTitle.RowTitle = "Par uzņēmumu";
            // 
            // grCompanyName
            // 
            grCompanyName.DataMember = null;
            grCompanyName.EditorTemplateName = "grtString";
            grCompanyName.GridPropertyName = "_CompName";
            grCompanyName.Name = "grCompanyName";
            grCompanyName.RowTitle = "Uzņēmuma nosaukums";
            grCompanyName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompRegNr
            // 
            grCompRegNr.DataMember = null;
            grCompRegNr.EditorTemplateName = "grtString";
            grCompRegNr.GridPropertyName = "_CompRegNr";
            grCompRegNr.Name = "grCompRegNr";
            grCompRegNr.RowTitle = "Reģ.nr. UR";
            grCompRegNr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompRegNrPVN
            // 
            grCompRegNrPVN.DataMember = null;
            grCompRegNrPVN.EditorTemplateName = "grtString";
            grCompRegNrPVN.GridPropertyName = "_CompRegNrPVN";
            grCompRegNrPVN.Name = "grCompRegNrPVN";
            grCompRegNrPVN.RowTitle = "PVN Reģ.nr.";
            grCompRegNrPVN.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompVID
            // 
            grCompVID.DataMember = null;
            grCompVID.EditorTemplateName = "grtString";
            grCompVID.GridPropertyName = "_CompVID";
            grCompVID.Name = "grCompVID";
            grCompVID.RowTitle = "VID nodaļa";
            grCompVID.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grAdreseTitle
            // 
            grAdreseTitle.Name = "grAdreseTitle";
            grAdreseTitle.RowTitle = "Adrese";
            // 
            // grCompAddr
            // 
            grCompAddr.DataMember = null;
            grCompAddr.EditorTemplateName = "grtString";
            grCompAddr.GridPropertyName = "_CompAddr";
            grCompAddr.Name = "grCompAddr";
            grCompAddr.RowTitle = "Pilna adrese";
            grCompAddr.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddr1
            // 
            grCompAddr1.DataMember = null;
            grCompAddr1.EditorTemplateName = "grtString";
            grCompAddr1.GridPropertyName = "_CompAddr1";
            grCompAddr1.Name = "grCompAddr1";
            grCompAddr1.RowTitle = "Iela, nr.";
            grCompAddr1.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddr2
            // 
            grCompAddr2.DataMember = null;
            grCompAddr2.EditorTemplateName = "grtString";
            grCompAddr2.GridPropertyName = "_CompAddr2";
            grCompAddr2.Name = "grCompAddr2";
            grCompAddr2.RowTitle = "Pilsēta";
            grCompAddr2.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddr3
            // 
            grCompAddr3.DataMember = null;
            grCompAddr3.EditorTemplateName = "grtString";
            grCompAddr3.GridPropertyName = "_CompAddr3";
            grCompAddr3.Name = "grCompAddr3";
            grCompAddr3.RowTitle = "Novads";
            grCompAddr3.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddr4
            // 
            grCompAddr4.DataMember = null;
            grCompAddr4.EditorTemplateName = "grtString";
            grCompAddr4.GridPropertyName = "_CompAddr4";
            grCompAddr4.Name = "grCompAddr4";
            grCompAddr4.RowTitle = "Pagasts";
            grCompAddr4.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddrInd
            // 
            grCompAddrInd.DataMember = null;
            grCompAddrInd.EditorTemplateName = "grtString";
            grCompAddrInd.GridPropertyName = "_CompAddrInd";
            grCompAddrInd.Name = "grCompAddrInd";
            grCompAddrInd.RowTitle = "Pasta indeks";
            grCompAddrInd.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAddrG
            // 
            grCompAddrG.DataMember = null;
            grCompAddrG.EditorTemplateName = "grtString";
            grCompAddrG.GridPropertyName = "_CompAddrG";
            grCompAddrG.Name = "grCompAddrG";
            grCompAddrG.RowTitle = "Preču izsn. adrese";
            grCompAddrG.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompEMail
            // 
            grCompEMail.EditorTemplateName = "grtString";
            grCompEMail.GridPropertyName = "_CompEMail";
            grCompEMail.Name = "grCompEMail";
            grCompEMail.RowTitle = "E-pasts";
            grCompEMail.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grManTitle
            // 
            grManTitle.Name = "grManTitle";
            grManTitle.RowTitle = "Vadītājs";
            // 
            // grCompMName
            // 
            grCompMName.DataMember = null;
            grCompMName.EditorTemplateName = "grtString";
            grCompMName.GridPropertyName = "_CompMName";
            grCompMName.Name = "grCompMName";
            grCompMName.RowTitle = "Vārds, uzvārds";
            grCompMName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompMpk
            // 
            grCompMpk.DataMember = null;
            grCompMpk.EditorTemplateName = "grtString";
            grCompMpk.GridPropertyName = "_CompMpk";
            grCompMpk.Name = "grCompMpk";
            grCompMpk.RowTitle = "Personas kods";
            grCompMpk.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompPhone
            // 
            grCompPhone.DataMember = null;
            grCompPhone.EditorTemplateName = "grtString";
            grCompPhone.GridPropertyName = "_CompPhone";
            grCompPhone.Name = "grCompPhone";
            grCompPhone.RowTitle = "Telefona nr.";
            grCompPhone.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grAccTitle
            // 
            grAccTitle.Name = "grAccTitle";
            grAccTitle.RowTitle = "Grāmatvedis";
            // 
            // grCompAccName
            // 
            grCompAccName.DataMember = null;
            grCompAccName.EditorTemplateName = "grtString";
            grCompAccName.GridPropertyName = "_CompAccName";
            grCompAccName.Name = "grCompAccName";
            grCompAccName.RowTitle = "Vārds, uzvārds";
            grCompAccName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grCompAccPh
            // 
            grCompAccPh.DataMember = null;
            grCompAccPh.EditorTemplateName = "grtString";
            grCompAccPh.GridPropertyName = "_CompAccPh";
            grCompAccPh.Name = "grCompAccPh";
            grCompAccPh.RowTitle = "Telefona nr.";
            grCompAccPh.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grBankTitle
            // 
            grBankTitle.Name = "grBankTitle";
            grBankTitle.RowTitle = "Bankas dati";
            // 
            // grBankId
            // 
            grBankId.DataMember = null;
            grBankId.EditorTemplateName = "grtString";
            grBankId.GridPropertyName = "_BankId";
            grBankId.Name = "grBankId";
            grBankId.RowTitle = "Kods";
            grBankId.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grBankName
            // 
            grBankName.DataMember = null;
            grBankName.EditorTemplateName = "grtString";
            grBankName.GridPropertyName = "_BankName";
            grBankName.Name = "grBankName";
            grBankName.RowTitle = "Nosaukums";
            grBankName.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grBankAcc
            // 
            grBankAcc.DataMember = null;
            grBankAcc.EditorTemplateName = "grtString";
            grBankAcc.GridPropertyName = "_BankAcc";
            grBankAcc.Name = "grBankAcc";
            grBankAcc.RowTitle = "Konts";
            grBankAcc.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // grtString
            // 
            grtString.AllowNull = true;
            grtString.DataMember = null;
            grtString.Name = "grtString";
            grtString.RowTitle = null;
            grtString.RowValueType = KlonsLIB.MySourceGrid.GridRows.EMyGridRowValueType.String;
            // 
            // Form_CompanyData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(574, 347);
            CloseOnEscape = true;
            Controls.Add(myGrid1);
            Name = "Form_CompanyData";
            Text = "Ziņas par uzņēmumu";
            FormClosing += FormCompanyData_FormClosing;
            Load += FormCompanyData_Load;
            ResumeLayout(false);
        }

        #endregion

        private Classes.CompanyData companyData1;
        private KlonsLIB.MySourceGrid.MyGrid myGrid1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grCompanyTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompanyName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompRegNr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompRegNrPVN;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompVID;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grAdreseTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddr;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddrInd;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddr1;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddr2;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddr3;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddr4;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAddrG;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grManTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompMName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompMpk;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompPhone;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grAccTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAccName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompAccPh;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTitle grBankTitle;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grBankId;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grBankName;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grBankAcc;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grtString;
        private KlonsLIB.MySourceGrid.GridRows.MyGridRowTextBoxA grCompEMail;
    }
}