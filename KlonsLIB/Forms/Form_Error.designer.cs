using KlonsLIB.Components;

namespace KlonsLIB.Forms
{
    partial class Form_Error
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
            tbMsg = new MyTextBox();
            tbDescr = new MyTextBox();
            cmClose = new Button();
            pictureBox1 = new PictureBox();
            cmDetails = new Button();
            cmRollBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbMsg
            // 
            tbMsg.BackColor = SystemColors.Control;
            tbMsg.BorderColor = SystemColors.Control;
            tbMsg.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 186);
            tbMsg.Location = new Point(45, 8);
            tbMsg.Margin = new Padding(2, 2, 2, 2);
            tbMsg.Multiline = true;
            tbMsg.Name = "tbMsg";
            tbMsg.ReadOnly = true;
            tbMsg.Size = new Size(262, 93);
            tbMsg.TabIndex = 3;
            // 
            // tbDescr
            // 
            tbDescr.BackColor = SystemColors.Control;
            tbDescr.BorderColor = SystemColors.ControlDarkDark;
            tbDescr.Dock = DockStyle.Bottom;
            tbDescr.Location = new Point(0, 110);
            tbDescr.Margin = new Padding(2, 2, 2, 2);
            tbDescr.Multiline = true;
            tbDescr.Name = "tbDescr";
            tbDescr.ReadOnly = true;
            tbDescr.ScrollBars = ScrollBars.Both;
            tbDescr.Size = new Size(386, 159);
            tbDescr.TabIndex = 4;
            tbDescr.WordWrap = false;
            // 
            // cmClose
            // 
            cmClose.DialogResult = DialogResult.Cancel;
            cmClose.Location = new Point(316, 1);
            cmClose.Margin = new Padding(2, 2, 2, 2);
            cmClose.Name = "cmClose";
            cmClose.Size = new Size(65, 28);
            cmClose.TabIndex = 0;
            cmClose.Text = "Aizvērt";
            cmClose.UseVisualStyleBackColor = true;
            cmClose.Click += cmClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.error3;
            pictureBox1.Location = new Point(4, 8);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cmDetails
            // 
            cmDetails.Location = new Point(316, 30);
            cmDetails.Margin = new Padding(2, 2, 2, 2);
            cmDetails.Name = "cmDetails";
            cmDetails.Size = new Size(65, 28);
            cmDetails.TabIndex = 1;
            cmDetails.Text = "Detaļas";
            cmDetails.UseVisualStyleBackColor = true;
            cmDetails.Click += cmDetails_Click;
            // 
            // cmRollBack
            // 
            cmRollBack.Location = new Point(316, 59);
            cmRollBack.Margin = new Padding(2);
            cmRollBack.Name = "cmRollBack";
            cmRollBack.Size = new Size(65, 37);
            cmRollBack.TabIndex = 2;
            cmRollBack.Text = "Atcel izmaiņas";
            cmRollBack.UseVisualStyleBackColor = true;
            cmRollBack.Click += cmRollBack_Click;
            // 
            // Form_Error
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cmClose;
            ClientSize = new Size(386, 269);
            Controls.Add(pictureBox1);
            Controls.Add(cmRollBack);
            Controls.Add(cmDetails);
            Controls.Add(cmClose);
            Controls.Add(tbDescr);
            Controls.Add(tbMsg);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Error";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kļūda!";
            Load += FormError_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MyTextBox tbMsg;
        private MyTextBox tbDescr;
        private System.Windows.Forms.Button cmClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmDetails;
        private Button cmRollBack;
    }
}