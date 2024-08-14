
namespace KlonsM.FormsM
{
    partial class FormM_SPRunner
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbTaskText = new System.Windows.Forms.Label();
            this.lbWait = new System.Windows.Forms.Label();
            this.btDoIt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // lbTaskText
            // 
            this.lbTaskText.AutoSize = true;
            this.lbTaskText.Location = new System.Drawing.Point(20, 20);
            this.lbTaskText.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.lbTaskText.MaximumSize = new System.Drawing.Size(360, 500);
            this.lbTaskText.MinimumSize = new System.Drawing.Size(360, 0);
            this.lbTaskText.Name = "lbTaskText";
            this.lbTaskText.Size = new System.Drawing.Size(360, 20);
            this.lbTaskText.TabIndex = 1;
            this.lbTaskText.Text = "fdsfdsafsd dsfa sfdsfa";
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.Location = new System.Drawing.Point(29, 63);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(21, 20);
            this.lbWait.TabIndex = 2;
            this.lbWait.Text = "...";
            // 
            // btDoIt
            // 
            this.btDoIt.Location = new System.Drawing.Point(130, 49);
            this.btDoIt.Name = "btDoIt";
            this.btDoIt.Size = new System.Drawing.Size(116, 44);
            this.btDoIt.TabIndex = 3;
            this.btDoIt.Text = "Sākt";
            this.btDoIt.UseVisualStyleBackColor = true;
            this.btDoIt.Click += new System.EventHandler(this.btDoIt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lbTaskText);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 157);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDoIt);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 100);
            this.panel1.TabIndex = 2;
            // 
            // FormM_SPRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(403, 161);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbWait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormM_SPRunner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Darbību izpilde";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormM_SPRunner_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormM_SPRunner_FormClosed);
            this.Load += new System.EventHandler(this.FormM_SPRunner_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbTaskText;
        private System.Windows.Forms.Label lbWait;
        private System.Windows.Forms.Button btDoIt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}