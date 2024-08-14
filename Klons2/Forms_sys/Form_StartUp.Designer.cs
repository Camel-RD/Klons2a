using KlonsLIB.Components;
using KlonsF.Classes;

namespace KlonsF.Forms
{
    partial class Form_StartUp
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
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmConnect = new System.Windows.Forms.Button();
            cmChange = new System.Windows.Forms.Button();
            cmExit = new System.Windows.Forms.Button();
            cmUsers = new System.Windows.Forms.Button();
            tbPSW = new MyTextBox();
            tbUser = new MyTextBox();
            lbFile = new MyLabel();
            lbDescr = new MyLabel();
            lbNane = new MyLabel();
            cmFbAdmin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 10);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 17);
            label1.TabIndex = 2;
            label1.Text = "Datu bāze:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 43);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 17);
            label2.TabIndex = 4;
            label2.Text = "Apraksts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(5, 95);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 17);
            label3.TabIndex = 6;
            label3.Text = "Fials:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 155);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(105, 17);
            label4.TabIndex = 2;
            label4.Text = "Lietotāja vārds:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(5, 187);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 17);
            label5.TabIndex = 2;
            label5.Text = "Parole:";
            // 
            // cmConnect
            // 
            cmConnect.Location = new System.Drawing.Point(26, 226);
            cmConnect.Margin = new System.Windows.Forms.Padding(2);
            cmConnect.Name = "cmConnect";
            cmConnect.Size = new System.Drawing.Size(88, 57);
            cmConnect.TabIndex = 8;
            cmConnect.Text = "Pieslēgties";
            cmConnect.UseVisualStyleBackColor = false;
            cmConnect.Click += cmConnect_Click;
            // 
            // cmChange
            // 
            cmChange.Location = new System.Drawing.Point(132, 226);
            cmChange.Margin = new System.Windows.Forms.Padding(2);
            cmChange.Name = "cmChange";
            cmChange.Size = new System.Drawing.Size(88, 57);
            cmChange.TabIndex = 8;
            cmChange.Text = "Nomainīt datubāzi";
            cmChange.UseVisualStyleBackColor = false;
            cmChange.Click += cmChange_Click;
            // 
            // cmExit
            // 
            cmExit.Location = new System.Drawing.Point(237, 226);
            cmExit.Margin = new System.Windows.Forms.Padding(2);
            cmExit.Name = "cmExit";
            cmExit.Size = new System.Drawing.Size(88, 57);
            cmExit.TabIndex = 8;
            cmExit.Text = "Iziet";
            cmExit.UseVisualStyleBackColor = false;
            cmExit.Click += cmExit_Click;
            // 
            // cmUsers
            // 
            cmUsers.AutoSize = true;
            cmUsers.Location = new System.Drawing.Point(261, 149);
            cmUsers.Margin = new System.Windows.Forms.Padding(2);
            cmUsers.Name = "cmUsers";
            cmUsers.Size = new System.Drawing.Size(34, 30);
            cmUsers.TabIndex = 8;
            cmUsers.Text = ">>";
            cmUsers.UseVisualStyleBackColor = false;
            cmUsers.Click += cmUsers_Click;
            // 
            // tbPSW
            // 
            tbPSW.BorderColor = System.Drawing.SystemColors.ControlText;
            tbPSW.Location = new System.Drawing.Point(120, 185);
            tbPSW.Margin = new System.Windows.Forms.Padding(2);
            tbPSW.Name = "tbPSW";
            tbPSW.Size = new System.Drawing.Size(138, 23);
            tbPSW.TabIndex = 7;
            // 
            // tbUser
            // 
            tbUser.BorderColor = System.Drawing.SystemColors.ControlText;
            tbUser.Location = new System.Drawing.Point(120, 153);
            tbUser.Margin = new System.Windows.Forms.Padding(2);
            tbUser.Name = "tbUser";
            tbUser.Size = new System.Drawing.Size(138, 23);
            tbUser.TabIndex = 7;
            // 
            // lbFile
            // 
            lbFile.BorderColor = System.Drawing.SystemColors.ControlText;
            lbFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbFile.ForeColor = System.Drawing.SystemColors.ControlText;
            lbFile.Location = new System.Drawing.Point(90, 95);
            lbFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbFile.Name = "lbFile";
            lbFile.Padding = new System.Windows.Forms.Padding(2);
            lbFile.Size = new System.Drawing.Size(256, 42);
            lbFile.TabIndex = 5;
            lbFile.Text = "asdfdas fdas";
            // 
            // lbDescr
            // 
            lbDescr.BorderColor = System.Drawing.SystemColors.ControlText;
            lbDescr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbDescr.ForeColor = System.Drawing.SystemColors.ControlText;
            lbDescr.Location = new System.Drawing.Point(90, 43);
            lbDescr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbDescr.Name = "lbDescr";
            lbDescr.Padding = new System.Windows.Forms.Padding(2);
            lbDescr.Size = new System.Drawing.Size(256, 42);
            lbDescr.TabIndex = 3;
            lbDescr.Text = "asdfdas fdas\r\nf dsa";
            // 
            // lbNane
            // 
            lbNane.BorderColor = System.Drawing.SystemColors.ControlText;
            lbNane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbNane.ForeColor = System.Drawing.SystemColors.ControlText;
            lbNane.Location = new System.Drawing.Point(90, 10);
            lbNane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbNane.Name = "lbNane";
            lbNane.Padding = new System.Windows.Forms.Padding(2);
            lbNane.Size = new System.Drawing.Size(256, 23);
            lbNane.TabIndex = 1;
            lbNane.Text = "myLabel2";
            // 
            // cmFbAdmin
            // 
            cmFbAdmin.AutoSize = true;
            cmFbAdmin.Location = new System.Drawing.Point(261, 181);
            cmFbAdmin.Margin = new System.Windows.Forms.Padding(2);
            cmFbAdmin.Name = "cmFbAdmin";
            cmFbAdmin.Size = new System.Drawing.Size(77, 30);
            cmFbAdmin.TabIndex = 8;
            cmFbAdmin.Text = "Fb Admin";
            cmFbAdmin.UseVisualStyleBackColor = false;
            cmFbAdmin.Click += cmFbAdmin_Click;
            // 
            // Form_StartUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 292);
            Controls.Add(cmFbAdmin);
            Controls.Add(cmUsers);
            Controls.Add(cmExit);
            Controls.Add(cmChange);
            Controls.Add(cmConnect);
            Controls.Add(tbPSW);
            Controls.Add(tbUser);
            Controls.Add(label3);
            Controls.Add(lbFile);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(lbDescr);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lbNane);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_StartUp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Pieslēgties";
            Load += FormStartUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyLabel lbNane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyLabel lbDescr;
        private System.Windows.Forms.Label label3;
        private MyLabel lbFile;
        private System.Windows.Forms.Label label4;
        private MyTextBox tbUser;
        private System.Windows.Forms.Label label5;
        private MyTextBox tbPSW;
        private System.Windows.Forms.Button cmConnect;
        private System.Windows.Forms.Button cmChange;
        private System.Windows.Forms.Button cmExit;
        private System.Windows.Forms.Button cmUsers;
        private System.Windows.Forms.Button cmFbAdmin;
    }
}