namespace KlonsF.Forms
{
    partial class Form_About
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
            button1 = new System.Windows.Forms.Button();
            lbTitle = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbVersionStr = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Location = new System.Drawing.Point(92, 222);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 38);
            button1.TabIndex = 0;
            button1.Text = "Aizvērt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyDown += button1_KeyDown;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            lbTitle.Location = new System.Drawing.Point(23, 7);
            lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(57, 17);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Klons2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 93);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(189, 26);
            label2.TabIndex = 2;
            label2.Text = "Maza grāmatvedības programma\r\n                             mazam uzņēmumam";
            // 
            // lbVersionStr
            // 
            lbVersionStr.AutoSize = true;
            lbVersionStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            lbVersionStr.Location = new System.Drawing.Point(134, 65);
            lbVersionStr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbVersionStr.Name = "lbVersionStr";
            lbVersionStr.Size = new System.Drawing.Size(125, 17);
            lbVersionStr.TabIndex = 3;
            lbVersionStr.Text = "versija 2021.07.#1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 167);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(144, 26);
            label4.TabIndex = 4;
            label4.Text = "Autors: Aivars Ikaunieks\r\ne-pasts: aivars.ik@gmail.com";
            // 
            // Form_About
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 271);
            CloseOnEscape = true;
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(lbVersionStr);
            Controls.Add(label2);
            Controls.Add(lbTitle);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_About";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            KeyDown += Form_About_KeyDown;
            PreviewKeyDown += Form_About_PreviewKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbVersionStr;
        private System.Windows.Forms.Label label4;
    }
}