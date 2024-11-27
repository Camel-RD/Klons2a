
namespace KlonsM.FormsM
{
    partial class FormM_Invoice
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
            label1 = new System.Windows.Forms.Label();
            btDoIt = new System.Windows.Forms.Button();
            tbDate = new KlonsLIB.Components.MyTextBox();
            lbInvoiceForm = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            tbSigner = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            cbTitle = new KlonsLIB.Components.FlatComboBox();
            label4 = new System.Windows.Forms.Label();
            btCancel = new System.Windows.Forms.Button();
            chShowCarrier = new KlonsLIB.Components.MyCheckBox();
            chShowSignature = new KlonsLIB.Components.MyCheckBox();
            chShowBarcode = new KlonsLIB.Components.MyCheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 17);
            label1.TabIndex = 9;
            label1.Text = "Parakstīšanas datums:";
            // 
            // btDoIt
            // 
            btDoIt.Location = new System.Drawing.Point(437, 180);
            btDoIt.Name = "btDoIt";
            btDoIt.Size = new System.Drawing.Size(112, 62);
            btDoIt.TabIndex = 7;
            btDoIt.Text = "Sagatavot izdruku";
            btDoIt.UseVisualStyleBackColor = true;
            btDoIt.Click += btDoIt_Click;
            // 
            // tbDate
            // 
            tbDate.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate.IsDate = true;
            tbDate.Location = new System.Drawing.Point(188, 16);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(100, 23);
            tbDate.TabIndex = 0;
            // 
            // lbInvoiceForm
            // 
            lbInvoiceForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbInvoiceForm.FormattingEnabled = true;
            lbInvoiceForm.ItemHeight = 16;
            lbInvoiceForm.Items.AddRange(new object[] { "Veidlapa 1 - ar atlaidi un PVN kodu", "Veidlapa 1 - bez atlaides un PVN koda", "Veidlapa 2 - vienkāršāks rēķins" });
            lbInvoiceForm.Location = new System.Drawing.Point(12, 198);
            lbInvoiceForm.Name = "lbInvoiceForm";
            lbInvoiceForm.Size = new System.Drawing.Size(397, 98);
            lbInvoiceForm.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 17);
            label2.TabIndex = 10;
            label2.Text = "Parakstītājs:";
            // 
            // tbSigner
            // 
            tbSigner.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSigner.Location = new System.Drawing.Point(188, 56);
            tbSigner.Name = "tbSigner";
            tbSigner.Size = new System.Drawing.Size(175, 23);
            tbSigner.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 98);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 17);
            label3.TabIndex = 11;
            label3.Text = "Virsraksts:";
            // 
            // cbTitle
            // 
            cbTitle.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbTitle.FormattingEnabled = true;
            cbTitle.Items.AddRange(new object[] { "PREČU PAVADZĪME RĒĶINS", "PAVADZĪME", "RĒĶINS", "PRIEKŠAPMAKSAS RĒĶINS", "KREDĪTRĒĶINS", "PĀRVIETOŠANAS PAVADZĪME" });
            cbTitle.Location = new System.Drawing.Point(188, 95);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new System.Drawing.Size(359, 24);
            cbTitle.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 17);
            label4.TabIndex = 12;
            label4.Text = "Izdrukas veids:";
            // 
            // btCancel
            // 
            btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btCancel.Location = new System.Drawing.Point(437, 256);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(112, 40);
            btCancel.TabIndex = 8;
            btCancel.Text = "Atcelt";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // chShowCarrier
            // 
            chShowCarrier.AutoSize = true;
            chShowCarrier.Checked = true;
            chShowCarrier.CheckState = System.Windows.Forms.CheckState.Checked;
            chShowCarrier.Location = new System.Drawing.Point(16, 139);
            chShowCarrier.Name = "chShowCarrier";
            chShowCarrier.Size = new System.Drawing.Size(168, 18);
            chShowCarrier.TabIndex = 3;
            chShowCarrier.Text = "Rādīt pārvadātāja datus";
            chShowCarrier.UseVisualStyleBackColor = false;
            // 
            // chShowSignature
            // 
            chShowSignature.AutoSize = true;
            chShowSignature.Checked = true;
            chShowSignature.CheckState = System.Windows.Forms.CheckState.Checked;
            chShowSignature.Location = new System.Drawing.Point(195, 139);
            chShowSignature.Name = "chShowSignature";
            chShowSignature.Size = new System.Drawing.Size(155, 18);
            chShowSignature.TabIndex = 4;
            chShowSignature.Text = "Rādīt parakstu laukus";
            chShowSignature.UseVisualStyleBackColor = false;
            // 
            // chShowBarcode
            // 
            chShowBarcode.AutoSize = true;
            chShowBarcode.Checked = true;
            chShowBarcode.CheckState = System.Windows.Forms.CheckState.Checked;
            chShowBarcode.Location = new System.Drawing.Point(367, 139);
            chShowBarcode.Name = "chShowBarcode";
            chShowBarcode.Size = new System.Drawing.Size(143, 18);
            chShowBarcode.TabIndex = 5;
            chShowBarcode.Text = "Rādīt artikula kodus";
            chShowBarcode.UseVisualStyleBackColor = false;
            // 
            // FormM_Invoice
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(568, 337);
            Controls.Add(chShowBarcode);
            Controls.Add(chShowSignature);
            Controls.Add(chShowCarrier);
            Controls.Add(cbTitle);
            Controls.Add(lbInvoiceForm);
            Controls.Add(tbSigner);
            Controls.Add(tbDate);
            Controls.Add(btCancel);
            Controls.Add(btDoIt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormM_Invoice";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dokumenta izdruka";
            Load += FormM_Invoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDoIt;
        private KlonsLIB.Components.MyTextBox tbDate;
        private System.Windows.Forms.ListBox lbInvoiceForm;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyTextBox tbSigner;
        private System.Windows.Forms.Label label3;
        private KlonsLIB.Components.FlatComboBox cbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancel;
        private KlonsLIB.Components.MyCheckBox chShowCarrier;
        private KlonsLIB.Components.MyCheckBox chShowSignature;
        private KlonsLIB.Components.MyCheckBox chShowBarcode;
    }
}