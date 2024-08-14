using KlonsLIB.Components;

namespace KlonsF.Forms
{
    partial class Form_FilesNew
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
            tbName = new MyTextBox();
            label1 = new System.Windows.Forms.Label();
            cmOK = new System.Windows.Forms.Button();
            tbDescr = new MyTextBox();
            label2 = new System.Windows.Forms.Label();
            cmCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbName.Location = new System.Drawing.Point(36, 38);
            tbName.Margin = new System.Windows.Forms.Padding(2);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(148, 23);
            tbName.TabIndex = 0;
            tbName.KeyDown += Control_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 18);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 17);
            label1.TabIndex = 4;
            label1.Text = "Nosaukums (kods):";
            // 
            // cmOK
            // 
            cmOK.Location = new System.Drawing.Point(36, 130);
            cmOK.Margin = new System.Windows.Forms.Padding(2);
            cmOK.Name = "cmOK";
            cmOK.Size = new System.Drawing.Size(90, 45);
            cmOK.TabIndex = 2;
            cmOK.Text = "Izveidot";
            cmOK.UseVisualStyleBackColor = true;
            cmOK.Click += cmOK_Click;
            cmOK.KeyDown += Control_KeyDown;
            // 
            // tbDescr
            // 
            tbDescr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDescr.Location = new System.Drawing.Point(36, 91);
            tbDescr.Margin = new System.Windows.Forms.Padding(2);
            tbDescr.Name = "tbDescr";
            tbDescr.Size = new System.Drawing.Size(259, 23);
            tbDescr.TabIndex = 1;
            tbDescr.KeyDown += Control_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 71);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 17);
            label2.TabIndex = 5;
            label2.Text = "Apraksts:";
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(149, 130);
            cmCancel.Margin = new System.Windows.Forms.Padding(2);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(90, 45);
            cmCancel.TabIndex = 3;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            cmCancel.Click += cmCancel_Click;
            cmCancel.KeyDown += Control_KeyDown;
            // 
            // Form_FilesNew
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(319, 195);
            Controls.Add(cmCancel);
            Controls.Add(cmOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDescr);
            Controls.Add(tbName);
            Name = "Form_FilesNew";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Jauna datu bāze";
            Load += Form_FilesNew_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyTextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmOK;
        private MyTextBox tbDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmCancel;
    }
}