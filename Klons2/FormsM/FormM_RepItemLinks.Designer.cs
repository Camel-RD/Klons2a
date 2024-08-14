
namespace KlonsM.FormsM
{
    partial class FormM_RepItemLinks
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
            panel1 = new System.Windows.Forms.Panel();
            cmGetData = new System.Windows.Forms.Button();
            tbCode = new KlonsLIB.Components.MyPickRowTextBox2();
            bsItems = new KlonsLIB.Data.MyBindingSource(components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbDT2 = new KlonsLIB.Components.MyTextBox();
            tbDT1 = new KlonsLIB.Components.MyTextBox();
            bsRows = new KlonsLIB.Data.MyBindingSource(components);
            dgvRows = new KlonsLIB.Components.MyDataGridView();
            dgcADT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcASr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcANr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcATp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAIdStoreOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAIdStoreIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcABouPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBTp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBIdStoreOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBIdStoreIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAmountLinked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcAIDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcBIDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmGetData);
            panel1.Controls.Add(tbCode);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbDT2);
            panel1.Controls.Add(tbDT1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1221, 35);
            panel1.TabIndex = 1;
            // 
            // cmGetData
            // 
            cmGetData.Location = new System.Drawing.Point(592, 2);
            cmGetData.Name = "cmGetData";
            cmGetData.Size = new System.Drawing.Size(106, 29);
            cmGetData.TabIndex = 3;
            cmGetData.Text = "Atlasīt";
            cmGetData.UseVisualStyleBackColor = true;
            cmGetData.Click += cmGetData_Click;
            // 
            // tbCode
            // 
            tbCode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbCode.DataMember = null;
            tbCode.DataSource = bsItems;
            tbCode.DisplayMember = "BARCODE";
            tbCode.Location = new System.Drawing.Point(411, 6);
            tbCode.Name = "tbCode";
            tbCode.SelectedIndex = -1;
            tbCode.ShowButton = true;
            tbCode.Size = new System.Drawing.Size(158, 23);
            tbCode.SyncPosition = false;
            tbCode.TabIndex = 2;
            tbCode.ValueMember = "ID";
            tbCode.ButtonClicked += tbCode_ButtonClicked;
            tbCode.KeyDown += tbCode_KeyDown;
            // 
            // bsItems
            // 
            bsItems.DataMember = "M_ITEMS";
            bsItems.MyDataSource = "KlonsMData";
            bsItems.Sort = "BARCODE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(348, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 17);
            label2.TabIndex = 5;
            label2.Text = "artikuls:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 17);
            label1.TabIndex = 4;
            label1.Text = "Datums no - līdz:";
            // 
            // tbDT2
            // 
            tbDT2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT2.IsDate = true;
            tbDT2.Location = new System.Drawing.Point(236, 6);
            tbDT2.Name = "tbDT2";
            tbDT2.Size = new System.Drawing.Size(90, 23);
            tbDT2.TabIndex = 1;
            // 
            // tbDT1
            // 
            tbDT1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT1.IsDate = true;
            tbDT1.Location = new System.Drawing.Point(136, 6);
            tbDT1.Name = "tbDT1";
            tbDT1.Size = new System.Drawing.Size(90, 23);
            tbDT1.TabIndex = 0;
            // 
            // bsRows
            // 
            bsRows.DataMember = "SP_M_REP_ITEMLINKS_1";
            bsRows.MyDataSource = "KlonsMRep";
            // 
            // dgvRows
            // 
            dgvRows.AllowUserToAddRows = false;
            dgvRows.AllowUserToDeleteRows = false;
            dgvRows.AutoGenerateColumns = false;
            dgvRows.AutoSave = false;
            dgvRows.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcADT, dgcASr, dgcANr, dgcATp, dgcAIdStoreOut, dgcAIdStoreIn, dgcAAmount, dgcABouPrice, dgcBDt, dgcBSr, dgcBNr, dgcBTp, dgcBIdStoreOut, dgcBIdStoreIn, dgcBAmount, dgcBBuyPrice, dgcAmountLinked, dgcAIDD, dgcAIDR, dgcBIDD, dgcBIDR });
            dgvRows.DataSource = bsRows;
            dgvRows.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRows.Location = new System.Drawing.Point(0, 35);
            dgvRows.Name = "dgvRows";
            dgvRows.ReadOnly = true;
            dgvRows.RowHeadersWidth = 30;
            dgvRows.ShowCellToolTips = false;
            dgvRows.Size = new System.Drawing.Size(1221, 415);
            dgvRows.TabIndex = 2;
            dgvRows.CellFormatting += dgvRows_CellFormatting;
            // 
            // dgcADT
            // 
            dgcADT.DataPropertyName = "ADT";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy";
            dgcADT.DefaultCellStyle = dataGridViewCellStyle1;
            dgcADT.HeaderText = "datums";
            dgcADT.MinimumWidth = 8;
            dgcADT.Name = "dgcADT";
            dgcADT.ReadOnly = true;
            dgcADT.Width = 85;
            // 
            // dgcASr
            // 
            dgcASr.DataPropertyName = "ASR";
            dgcASr.HeaderText = "sr";
            dgcASr.MinimumWidth = 8;
            dgcASr.Name = "dgcASr";
            dgcASr.ReadOnly = true;
            dgcASr.Width = 50;
            // 
            // dgcANr
            // 
            dgcANr.DataPropertyName = "ANR";
            dgcANr.HeaderText = "numurs";
            dgcANr.MinimumWidth = 8;
            dgcANr.Name = "dgcANr";
            dgcANr.ReadOnly = true;
            dgcANr.Width = 95;
            // 
            // dgcATp
            // 
            dgcATp.DataPropertyName = "ATP";
            dgcATp.HeaderText = "veids";
            dgcATp.MinimumWidth = 8;
            dgcATp.Name = "dgcATp";
            dgcATp.ReadOnly = true;
            dgcATp.Width = 120;
            // 
            // dgcAIdStoreOut
            // 
            dgcAIdStoreOut.DataPropertyName = "AIDSTOREOUT";
            dgcAIdStoreOut.HeaderText = "izsniedzējs";
            dgcAIdStoreOut.MinimumWidth = 8;
            dgcAIdStoreOut.Name = "dgcAIdStoreOut";
            dgcAIdStoreOut.ReadOnly = true;
            dgcAIdStoreOut.Width = 160;
            // 
            // dgcAIdStoreIn
            // 
            dgcAIdStoreIn.DataPropertyName = "AIDSTOREIN";
            dgcAIdStoreIn.HeaderText = "saņēmējs";
            dgcAIdStoreIn.MinimumWidth = 8;
            dgcAIdStoreIn.Name = "dgcAIdStoreIn";
            dgcAIdStoreIn.ReadOnly = true;
            dgcAIdStoreIn.Width = 160;
            // 
            // dgcAAmount
            // 
            dgcAAmount.DataPropertyName = "AAMOUNT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcAAmount.DefaultCellStyle = dataGridViewCellStyle2;
            dgcAAmount.HeaderText = "daudzums";
            dgcAAmount.MinimumWidth = 8;
            dgcAAmount.Name = "dgcAAmount";
            dgcAAmount.ReadOnly = true;
            dgcAAmount.Width = 90;
            // 
            // dgcABouPrice
            // 
            dgcABouPrice.DataPropertyName = "ABUYPRICE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcABouPrice.DefaultCellStyle = dataGridViewCellStyle3;
            dgcABouPrice.HeaderText = "cena";
            dgcABouPrice.MinimumWidth = 8;
            dgcABouPrice.Name = "dgcABouPrice";
            dgcABouPrice.ReadOnly = true;
            dgcABouPrice.Width = 90;
            // 
            // dgcBDt
            // 
            dgcBDt.DataPropertyName = "BDT";
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dgcBDt.DefaultCellStyle = dataGridViewCellStyle4;
            dgcBDt.HeaderText = "datums";
            dgcBDt.MinimumWidth = 8;
            dgcBDt.Name = "dgcBDt";
            dgcBDt.ReadOnly = true;
            dgcBDt.Width = 85;
            // 
            // dgcBSr
            // 
            dgcBSr.DataPropertyName = "BSR";
            dgcBSr.HeaderText = "sr";
            dgcBSr.MinimumWidth = 8;
            dgcBSr.Name = "dgcBSr";
            dgcBSr.ReadOnly = true;
            dgcBSr.Width = 50;
            // 
            // dgcBNr
            // 
            dgcBNr.DataPropertyName = "BNR";
            dgcBNr.HeaderText = "numurs";
            dgcBNr.MinimumWidth = 8;
            dgcBNr.Name = "dgcBNr";
            dgcBNr.ReadOnly = true;
            dgcBNr.Width = 90;
            // 
            // dgcBTp
            // 
            dgcBTp.DataPropertyName = "BTP";
            dgcBTp.HeaderText = "veids";
            dgcBTp.MinimumWidth = 8;
            dgcBTp.Name = "dgcBTp";
            dgcBTp.ReadOnly = true;
            dgcBTp.Width = 120;
            // 
            // dgcBIdStoreOut
            // 
            dgcBIdStoreOut.DataPropertyName = "BIDSTOREOUT";
            dgcBIdStoreOut.HeaderText = "izsniedzējs";
            dgcBIdStoreOut.MinimumWidth = 8;
            dgcBIdStoreOut.Name = "dgcBIdStoreOut";
            dgcBIdStoreOut.ReadOnly = true;
            dgcBIdStoreOut.Width = 160;
            // 
            // dgcBIdStoreIn
            // 
            dgcBIdStoreIn.DataPropertyName = "BIDSTOREIN";
            dgcBIdStoreIn.HeaderText = "saņēmējs";
            dgcBIdStoreIn.MinimumWidth = 8;
            dgcBIdStoreIn.Name = "dgcBIdStoreIn";
            dgcBIdStoreIn.ReadOnly = true;
            dgcBIdStoreIn.Width = 160;
            // 
            // dgcBAmount
            // 
            dgcBAmount.DataPropertyName = "BAMOUNT";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBAmount.DefaultCellStyle = dataGridViewCellStyle5;
            dgcBAmount.HeaderText = "daudzums";
            dgcBAmount.MinimumWidth = 8;
            dgcBAmount.Name = "dgcBAmount";
            dgcBAmount.ReadOnly = true;
            dgcBAmount.Width = 90;
            // 
            // dgcBBuyPrice
            // 
            dgcBBuyPrice.DataPropertyName = "BBUYPRICE";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcBBuyPrice.DefaultCellStyle = dataGridViewCellStyle6;
            dgcBBuyPrice.HeaderText = "cena";
            dgcBBuyPrice.MinimumWidth = 8;
            dgcBBuyPrice.Name = "dgcBBuyPrice";
            dgcBBuyPrice.ReadOnly = true;
            dgcBBuyPrice.Width = 90;
            // 
            // dgcAmountLinked
            // 
            dgcAmountLinked.DataPropertyName = "AMOUNTLINKED";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcAmountLinked.DefaultCellStyle = dataGridViewCellStyle7;
            dgcAmountLinked.HeaderText = "izmantots";
            dgcAmountLinked.MinimumWidth = 8;
            dgcAmountLinked.Name = "dgcAmountLinked";
            dgcAmountLinked.ReadOnly = true;
            dgcAmountLinked.Width = 95;
            // 
            // dgcAIDD
            // 
            dgcAIDD.DataPropertyName = "AIDD";
            dgcAIDD.HeaderText = "AIDD";
            dgcAIDD.MinimumWidth = 8;
            dgcAIDD.Name = "dgcAIDD";
            dgcAIDD.ReadOnly = true;
            dgcAIDD.Visible = false;
            dgcAIDD.Width = 150;
            // 
            // dgcAIDR
            // 
            dgcAIDR.DataPropertyName = "AIDR";
            dgcAIDR.HeaderText = "AIDR";
            dgcAIDR.MinimumWidth = 8;
            dgcAIDR.Name = "dgcAIDR";
            dgcAIDR.ReadOnly = true;
            dgcAIDR.Visible = false;
            dgcAIDR.Width = 150;
            // 
            // dgcBIDD
            // 
            dgcBIDD.DataPropertyName = "BIDD";
            dgcBIDD.HeaderText = "BIDD";
            dgcBIDD.MinimumWidth = 8;
            dgcBIDD.Name = "dgcBIDD";
            dgcBIDD.ReadOnly = true;
            dgcBIDD.Visible = false;
            dgcBIDD.Width = 150;
            // 
            // dgcBIDR
            // 
            dgcBIDR.DataPropertyName = "BIDR";
            dgcBIDR.HeaderText = "BIDR";
            dgcBIDR.MinimumWidth = 8;
            dgcBIDR.Name = "dgcBIDR";
            dgcBIDR.ReadOnly = true;
            dgcBIDR.Visible = false;
            dgcBIDR.Width = 150;
            // 
            // FormM_RepItemLinks
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1221, 450);
            Controls.Add(dgvRows);
            Controls.Add(panel1);
            Name = "FormM_RepItemLinks";
            Text = "Izmantojuma pārskats";
            Load += FormM_RepItemLinks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmGetData;
        private KlonsLIB.Components.MyPickRowTextBox2 tbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbDT2;
        private KlonsLIB.Components.MyTextBox tbDT1;
        private KlonsLIB.Data.MyBindingSource bsRows;
        private KlonsLIB.Components.MyDataGridView dgvRows;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcADT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcASr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcANr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcATp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAIdStoreOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAIdStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcABouPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBTp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBIdStoreOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBIdStoreIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAmountLinked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAIDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcBIDR;
    }
}