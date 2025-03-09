namespace KlonsM.FormsEI
{
    partial class Form_SetEmailPassword
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
            tbRealPassword = new System.Windows.Forms.TextBox();
            tbWeakPassword = new System.Windows.Forms.TextBox();
            cmOk = new System.Windows.Forms.Button();
            cmCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // tbRealPassword
            // 
            tbRealPassword.Location = new System.Drawing.Point(178, 7);
            tbRealPassword.Name = "tbRealPassword";
            tbRealPassword.Size = new System.Drawing.Size(176, 23);
            tbRealPassword.TabIndex = 0;
            // 
            // tbWeakPassword
            // 
            tbWeakPassword.Location = new System.Drawing.Point(178, 45);
            tbWeakPassword.Name = "tbWeakPassword";
            tbWeakPassword.Size = new System.Drawing.Size(176, 23);
            tbWeakPassword.TabIndex = 1;
            // 
            // cmOk
            // 
            cmOk.Location = new System.Drawing.Point(371, 8);
            cmOk.Name = "cmOk";
            cmOk.Size = new System.Drawing.Size(75, 31);
            cmOk.TabIndex = 2;
            cmOk.Text = "Ok";
            cmOk.UseVisualStyleBackColor = true;
            cmOk.Click += cmOk_Click;
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(371, 46);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(75, 31);
            cmCancel.TabIndex = 3;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 17);
            label1.TabIndex = 4;
            label1.Text = "Faktiskā e-pasta parole:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(119, 17);
            label2.TabIndex = 5;
            label2.Text = "Vinekāršā parole:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 88);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(373, 68);
            label3.TabIndex = 6;
            label3.Text = "Faktiskā e-pasta adrese programmā netiks saglabāta.\r\nTā tiks saglabāta šifrētā veidā izmantojot vienkāršo paroli.\r\nLai sūtītu e-pastus programma prasīs ievadīt\r\nnorādīto vienkāršo paroli.";
            // 
            // Form_SetEmailPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(454, 168);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmCancel);
            Controls.Add(cmOk);
            Controls.Add(tbWeakPassword);
            Controls.Add(tbRealPassword);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_SetEmailPassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Norādi e-pasta paroli";
            Load += FormSetEmailPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbRealPassword;
        private System.Windows.Forms.TextBox tbWeakPassword;
        private System.Windows.Forms.Button cmOk;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}