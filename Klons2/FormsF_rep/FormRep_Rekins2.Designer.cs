using KlonsLIB.Components;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_Rekins2
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
            cmDoIt = new System.Windows.Forms.Button();
            tbSigner = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            cmCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            chDigitalDoc = new MyCheckBox();
            label3 = new System.Windows.Forms.Label();
            tbPayUntil = new MyTextBox();
            SuspendLayout();
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(219, 157);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(104, 55);
            cmDoIt.TabIndex = 3;
            cmDoIt.Text = "Sagatavot rēķinu";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // tbSigner
            // 
            tbSigner.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSigner.Location = new System.Drawing.Point(12, 37);
            tbSigner.Margin = new System.Windows.Forms.Padding(2);
            tbSigner.Name = "tbSigner";
            tbSigner.Size = new System.Drawing.Size(423, 23);
            tbSigner.TabIndex = 0;
            tbSigner.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 12);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 17);
            label2.TabIndex = 5;
            label2.Text = "Izrakstītājs:";
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(330, 157);
            cmCancel.Margin = new System.Windows.Forms.Padding(2);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(104, 55);
            cmCancel.TabIndex = 4;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            cmCancel.Click += cmCancel_Click;
            cmCancel.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(15, 230);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(426, 85);
            label1.TabIndex = 7;
            label1.Text = "  Lai rēķinā pie daudzumiem parādītos mērvienības, kontējuma parakstam jāsākas ar atbilstošās mērvienības apzīmējumu un simbolu ~.\r\n  Piemēram: kg~Kartupeļi";
            // 
            // chDigitalDoc
            // 
            chDigitalDoc.AutoSize = true;
            chDigitalDoc.Location = new System.Drawing.Point(15, 128);
            chDigitalDoc.Name = "chDigitalDoc";
            chDigitalDoc.Size = new System.Drawing.Size(301, 18);
            chDigitalDoc.TabIndex = 2;
            chDigitalDoc.Text = "Rēķins sagatavots un apstiprināts elektroniski ";
            chDigitalDoc.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 70);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 17);
            label3.TabIndex = 6;
            label3.Text = "Apmaksas termiņš";
            // 
            // tbPayUntil
            // 
            tbPayUntil.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPayUntil.Location = new System.Drawing.Point(14, 94);
            tbPayUntil.Margin = new System.Windows.Forms.Padding(2);
            tbPayUntil.Name = "tbPayUntil";
            tbPayUntil.Size = new System.Drawing.Size(423, 23);
            tbPayUntil.TabIndex = 1;
            // 
            // FormRep_Rekins2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(460, 322);
            CloseOnEscape = true;
            Controls.Add(chDigitalDoc);
            Controls.Add(label3);
            Controls.Add(tbPayUntil);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(tbSigner);
            Controls.Add(cmCancel);
            Controls.Add(cmDoIt);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRep_Rekins2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Izrakstam rēķinu";
            Load += FormRep_Rekins2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmDoIt;
        private MyTextBox tbSigner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Label label1;
        private MyCheckBox chDigitalDoc;
        private System.Windows.Forms.Label label3;
        private MyTextBox tbPayUntil;
    }
}