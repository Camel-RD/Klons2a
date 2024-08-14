
namespace KlonsF.Forms
{
    partial class Form_DatasetImport
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
            this.tbFileName = new KlonsLIB.Components.MyTextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDBType = new System.Windows.Forms.Label();
            this.btImport = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFileName
            // 
            this.tbFileName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbFileName.Location = new System.Drawing.Point(16, 32);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(388, 26);
            this.tbFileName.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowse.Location = new System.Drawing.Point(277, 64);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(127, 42);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Norādīt failu";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datu bāzes fails:";
            // 
            // lbDBType
            // 
            this.lbDBType.AutoSize = true;
            this.lbDBType.Location = new System.Drawing.Point(12, 64);
            this.lbDBType.Name = "lbDBType";
            this.lbDBType.Size = new System.Drawing.Size(21, 20);
            this.lbDBType.TabIndex = 3;
            this.lbDBType.Text = "...";
            // 
            // btImport
            // 
            this.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImport.Location = new System.Drawing.Point(153, 138);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(127, 59);
            this.btImport.TabIndex = 1;
            this.btImport.Text = "Importēt";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btClear
            // 
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Location = new System.Drawing.Point(12, 138);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(127, 59);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Izdzēst esošos datus";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.ForeColor = System.Drawing.Color.IndianRed;
            this.lbWait.Location = new System.Drawing.Point(12, 212);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(209, 20);
            this.lbWait.TabIndex = 3;
            this.lbWait.Text = "Uzgaidi, notiek datu imports!";
            this.lbWait.Visible = false;
            // 
            // Form_DatasetImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 241);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.lbDBType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DatasetImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datu bāzes imports";
            this.Load += new System.EventHandler(this.Form_DatasetImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlonsLIB.Components.MyTextBox tbFileName;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDBType;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbWait;
    }
}