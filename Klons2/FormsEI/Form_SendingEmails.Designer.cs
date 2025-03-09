namespace KlonsM.FormsEI
{
    partial class Form_SendingEmails
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsbSendingCancel = new System.Windows.Forms.ToolStripMenuItem();
            tsbSendingClose = new System.Windows.Forms.ToolStripMenuItem();
            tcSendingEmails = new KlonsLIB.Components.ExTabControl();
            tpSendingEmailsList = new System.Windows.Forms.TabPage();
            dgvSendingEmailsList = new KlonsLIB.Components.MyDataGridView();
            dgcCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcStatus = new KlonsLIB.Components.DataGridViewColorMarkColumn();
            bsSendingEmailsList = new System.Windows.Forms.BindingSource(components);
            tpSendingEmailsErrors = new System.Windows.Forms.TabPage();
            tbSendingEmailsErrors = new KlonsLIB.Components.FlatRichTextBox();
            menuStrip1.SuspendLayout();
            tcSendingEmails.SuspendLayout();
            tpSendingEmailsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSendingEmailsList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsSendingEmailsList).BeginInit();
            tpSendingEmailsErrors.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbSendingCancel, tsbSendingClose });
            menuStrip1.Location = new System.Drawing.Point(0, 249);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            menuStrip1.Size = new System.Drawing.Size(679, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsbSendingCancel
            // 
            tsbSendingCancel.Name = "tsbSendingCancel";
            tsbSendingCancel.Padding = new System.Windows.Forms.Padding(4);
            tsbSendingCancel.Size = new System.Drawing.Size(56, 31);
            tsbSendingCancel.Text = "Atcelt";
            tsbSendingCancel.Click += tsbSendingCancel_Click;
            // 
            // tsbSendingClose
            // 
            tsbSendingClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            tsbSendingClose.Name = "tsbSendingClose";
            tsbSendingClose.Padding = new System.Windows.Forms.Padding(4);
            tsbSendingClose.Size = new System.Drawing.Size(57, 31);
            tsbSendingClose.Text = "Aivērt";
            tsbSendingClose.Click += tsbSendingClose_Click;
            // 
            // tcSendingEmails
            // 
            tcSendingEmails.Controls.Add(tpSendingEmailsList);
            tcSendingEmails.Controls.Add(tpSendingEmailsErrors);
            tcSendingEmails.DefaultStyle = false;
            tcSendingEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            tcSendingEmails.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            tcSendingEmails.HeaderBackColor = System.Drawing.SystemColors.Control;
            tcSendingEmails.HighlightBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tcSendingEmails.Location = new System.Drawing.Point(0, 0);
            tcSendingEmails.Name = "tcSendingEmails";
            tcSendingEmails.SelectedIndex = 0;
            tcSendingEmails.Size = new System.Drawing.Size(679, 249);
            tcSendingEmails.TabIndex = 1;
            // 
            // tpSendingEmailsList
            // 
            tpSendingEmailsList.Controls.Add(dgvSendingEmailsList);
            tpSendingEmailsList.Location = new System.Drawing.Point(4, 25);
            tpSendingEmailsList.Name = "tpSendingEmailsList";
            tpSendingEmailsList.Padding = new System.Windows.Forms.Padding(3);
            tpSendingEmailsList.Size = new System.Drawing.Size(671, 220);
            tpSendingEmailsList.TabIndex = 0;
            tpSendingEmailsList.Text = "Rēķini";
            tpSendingEmailsList.UseVisualStyleBackColor = true;
            // 
            // dgvSendingEmailsList
            // 
            dgvSendingEmailsList.AllowUserToAddRows = false;
            dgvSendingEmailsList.AllowUserToDeleteRows = false;
            dgvSendingEmailsList.AllowUserToResizeRows = false;
            dgvSendingEmailsList.AutoGenerateColumns = false;
            dgvSendingEmailsList.BackgroundColor = System.Drawing.SystemColors.Control;
            dgvSendingEmailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSendingEmailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcCustomerName, dgcInvoiceID, dgcCustomerEmail, dgcStatus });
            dgvSendingEmailsList.DataSource = bsSendingEmailsList;
            dgvSendingEmailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvSendingEmailsList.Location = new System.Drawing.Point(3, 3);
            dgvSendingEmailsList.Name = "dgvSendingEmailsList";
            dgvSendingEmailsList.ReadOnly = true;
            dgvSendingEmailsList.RowHeadersVisible = false;
            dgvSendingEmailsList.RowTemplate.Height = 25;
            dgvSendingEmailsList.Size = new System.Drawing.Size(665, 214);
            dgvSendingEmailsList.TabIndex = 0;
            // 
            // dgcCustomerName
            // 
            dgcCustomerName.DataPropertyName = "CustomerName";
            dgcCustomerName.HeaderText = "saņēmējs";
            dgcCustomerName.Name = "dgcCustomerName";
            dgcCustomerName.ReadOnly = true;
            dgcCustomerName.Width = 200;
            // 
            // dgcInvoiceID
            // 
            dgcInvoiceID.DataPropertyName = "InvoiceID";
            dgcInvoiceID.HeaderText = "rēķina nr.";
            dgcInvoiceID.Name = "dgcInvoiceID";
            dgcInvoiceID.ReadOnly = true;
            dgcInvoiceID.Width = 105;
            // 
            // dgcCustomerEmail
            // 
            dgcCustomerEmail.DataPropertyName = "CustomerEmail";
            dgcCustomerEmail.HeaderText = "e-pasts";
            dgcCustomerEmail.Name = "dgcCustomerEmail";
            dgcCustomerEmail.ReadOnly = true;
            dgcCustomerEmail.Width = 200;
            // 
            // dgcStatus
            // 
            dgcStatus.DataPropertyName = "Status";
            dgcStatus.HeaderText = "status";
            dgcStatus.Name = "dgcStatus";
            dgcStatus.ReadOnly = true;
            dgcStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            dgcStatus.Width = 120;
            // 
            // bsSendingEmailsList
            // 
            bsSendingEmailsList.DataSource = typeof(DataObjectsEI.EmailSenderItem);
            // 
            // tpSendingEmailsErrors
            // 
            tpSendingEmailsErrors.Controls.Add(tbSendingEmailsErrors);
            tpSendingEmailsErrors.Location = new System.Drawing.Point(4, 25);
            tpSendingEmailsErrors.Name = "tpSendingEmailsErrors";
            tpSendingEmailsErrors.Padding = new System.Windows.Forms.Padding(3);
            tpSendingEmailsErrors.Size = new System.Drawing.Size(671, 229);
            tpSendingEmailsErrors.TabIndex = 1;
            tpSendingEmailsErrors.Text = "Kļūdas";
            tpSendingEmailsErrors.UseVisualStyleBackColor = true;
            // 
            // tbSendingEmailsErrors
            // 
            tbSendingEmailsErrors.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSendingEmailsErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbSendingEmailsErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            tbSendingEmailsErrors.Location = new System.Drawing.Point(3, 3);
            tbSendingEmailsErrors.Name = "tbSendingEmailsErrors";
            tbSendingEmailsErrors.Size = new System.Drawing.Size(665, 223);
            tbSendingEmailsErrors.TabIndex = 0;
            tbSendingEmailsErrors.Text = "";
            // 
            // Form_SendingEmails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(679, 280);
            Controls.Add(tcSendingEmails);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_SendingEmails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Notiek e-pastu sūtīšana";
            Load += Form_SendingEmails_Load;
            Shown += Form_SendingEmails_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcSendingEmails.ResumeLayout(false);
            tpSendingEmailsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSendingEmailsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsSendingEmailsList).EndInit();
            tpSendingEmailsErrors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbSendingCancel;
        private System.Windows.Forms.ToolStripMenuItem tsbSendingClose;
        private KlonsLIB.Components.ExTabControl tcSendingEmails;
        private System.Windows.Forms.TabPage tpSendingEmailsList;
        private System.Windows.Forms.TabPage tpSendingEmailsErrors;
        private System.Windows.Forms.BindingSource bsSendingEmailsList;
        private KlonsLIB.Components.MyDataGridView dgvSendingEmailsList;
        private KlonsLIB.Components.FlatRichTextBox tbSendingEmailsErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCustomerEmail;
        private KlonsLIB.Components.DataGridViewColorMarkColumn dgcStatus;
    }
}