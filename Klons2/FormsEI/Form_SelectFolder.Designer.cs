namespace KlonsM.FormsEI
{
    partial class Form_SelectFolder
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
            label2 = new System.Windows.Forms.Label();
            cbInvoiceFolder = new KlonsLIB.Components.FlatComboBox();
            cmOk = new System.Windows.Forms.Button();
            cmCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(239, 17);
            label2.TabIndex = 3;
            label2.Text = "Izvēlies uz kuru mapi pārvietot failus:";
            // 
            // cbInvoiceFolder
            // 
            cbInvoiceFolder.BorderColor = System.Drawing.SystemColors.ControlText;
            cbInvoiceFolder.DrawBorder = false;
            cbInvoiceFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbInvoiceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbInvoiceFolder.FormattingEnabled = true;
            cbInvoiceFolder.Location = new System.Drawing.Point(12, 26);
            cbInvoiceFolder.Name = "cbInvoiceFolder";
            cbInvoiceFolder.Size = new System.Drawing.Size(269, 24);
            cbInvoiceFolder.TabIndex = 0;
            // 
            // cmOk
            // 
            cmOk.Location = new System.Drawing.Point(225, 80);
            cmOk.Name = "cmOk";
            cmOk.Size = new System.Drawing.Size(86, 29);
            cmOk.TabIndex = 1;
            cmOk.Text = "Pārvietot";
            cmOk.UseVisualStyleBackColor = true;
            cmOk.Click += cmOk_Click;
            // 
            // cmCancel
            // 
            cmCancel.Location = new System.Drawing.Point(317, 80);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(86, 29);
            cmCancel.TabIndex = 2;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            cmCancel.Click += cmCancel_Click;
            // 
            // Form_SelectFolder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(415, 119);
            Controls.Add(cmCancel);
            Controls.Add(cmOk);
            Controls.Add(label2);
            Controls.Add(cbInvoiceFolder);
            Name = "Form_SelectFolder";
            Text = "Izvēlies mapi";
            Load += Form_SelectFolder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.FlatComboBox cbInvoiceFolder;
        private System.Windows.Forms.Button cmOk;
        private System.Windows.Forms.Button cmCancel;
    }
}