using KlonsLIB.Components;
using KlonsLIB.Data;

namespace KlonsF.FormsReportParams
{
    partial class FormRep_PVNCheck
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
            bsAC = new MyBindingSource(components);
            tbSD = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbED = new MyTextBox();
            cmDoIt = new System.Windows.Forms.Button();
            tbLikme = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tbSlieksnis = new MyTextBox();
            label4 = new System.Windows.Forms.Label();
            cmDoIt2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsAC).BeginInit();
            SuspendLayout();
            // 
            // bsAC
            // 
            bsAC.DataMember = "AcP21";
            bsAC.MyDataSource = "KlonsData";
            bsAC.Name2 = "bsAC";
            // 
            // tbSD
            // 
            tbSD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSD.IsDate = true;
            tbSD.Location = new System.Drawing.Point(156, 22);
            tbSD.Margin = new System.Windows.Forms.Padding(2);
            tbSD.Name = "tbSD";
            tbSD.Size = new System.Drawing.Size(80, 23);
            tbSD.TabIndex = 0;
            tbSD.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 22);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 5;
            label1.Text = "Datums (no - līdz):";
            // 
            // tbED
            // 
            tbED.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbED.IsDate = true;
            tbED.Location = new System.Drawing.Point(242, 22);
            tbED.Margin = new System.Windows.Forms.Padding(2);
            tbED.Name = "tbED";
            tbED.Size = new System.Drawing.Size(80, 23);
            tbED.TabIndex = 1;
            tbED.KeyDown += Control_KeyDown;
            // 
            // cmDoIt
            // 
            cmDoIt.Location = new System.Drawing.Point(305, 98);
            cmDoIt.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt.Name = "cmDoIt";
            cmDoIt.Size = new System.Drawing.Size(127, 50);
            cmDoIt.TabIndex = 4;
            cmDoIt.Text = "Pārbaudīt ieņēmumus";
            cmDoIt.UseVisualStyleBackColor = true;
            cmDoIt.Click += cmDoIt_Click;
            cmDoIt.KeyDown += Control_KeyDown;
            // 
            // tbLikme
            // 
            tbLikme.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbLikme.Location = new System.Drawing.Point(156, 61);
            tbLikme.Margin = new System.Windows.Forms.Padding(2);
            tbLikme.Name = "tbLikme";
            tbLikme.Size = new System.Drawing.Size(64, 23);
            tbLikme.TabIndex = 0;
            tbLikme.Text = "21";
            tbLikme.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 61);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 17);
            label2.TabIndex = 5;
            label2.Text = "PVN likme:";
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(22, 146);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(257, 66);
            label3.TabIndex = 6;
            label3.Text = "  Pārbaudam vai dokuemtā norādītā PVN summa atšķiras no matemātiski aprēķinātās ar norādīto PVN likmi.";
            // 
            // tbSlieksnis
            // 
            tbSlieksnis.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbSlieksnis.Location = new System.Drawing.Point(156, 98);
            tbSlieksnis.Margin = new System.Windows.Forms.Padding(2);
            tbSlieksnis.Name = "tbSlieksnis";
            tbSlieksnis.Size = new System.Drawing.Size(64, 23);
            tbSlieksnis.TabIndex = 0;
            tbSlieksnis.Text = "0.03";
            tbSlieksnis.KeyDown += Control_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 98);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 17);
            label4.TabIndex = 5;
            label4.Text = "Kļūdas robeža:";
            // 
            // cmDoIt2
            // 
            cmDoIt2.Location = new System.Drawing.Point(305, 162);
            cmDoIt2.Margin = new System.Windows.Forms.Padding(2);
            cmDoIt2.Name = "cmDoIt2";
            cmDoIt2.Size = new System.Drawing.Size(127, 50);
            cmDoIt2.TabIndex = 4;
            cmDoIt2.Text = "Pārbaudīt izmaksas";
            cmDoIt2.UseVisualStyleBackColor = true;
            cmDoIt2.Click += cmDoIt2_Click;
            cmDoIt2.KeyDown += Control_KeyDown;
            // 
            // FormRep_PVNCheck
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 232);
            CloseOnEscape = true;
            Controls.Add(label3);
            Controls.Add(cmDoIt2);
            Controls.Add(cmDoIt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbED);
            Controls.Add(tbSlieksnis);
            Controls.Add(tbLikme);
            Controls.Add(tbSD);
            Name = "FormRep_PVNCheck";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PVN summu kontrole";
            Load += FormRepApgr1_Load;
            ((System.ComponentModel.ISupportInitialize)bsAC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyBindingSource bsAC;
        private MyTextBox tbSD;
        private System.Windows.Forms.Label label1;
        private MyTextBox tbED;
        private System.Windows.Forms.Button cmDoIt;
        private MyTextBox tbLikme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MyTextBox tbSlieksnis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmDoIt2;
    }
}