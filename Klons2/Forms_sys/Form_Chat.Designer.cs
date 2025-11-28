namespace KlonsF.Forms_sys
{
    partial class Form_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chat));
            panel1 = new System.Windows.Forms.Panel();
            tbUserId = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsiSend = new System.Windows.Forms.ToolStripButton();
            tsiCheck = new System.Windows.Forms.ToolStripButton();
            tsbClear = new System.Windows.Forms.ToolStripButton();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            cbAutoCheckConfig = new System.Windows.Forms.ToolStripComboBox();
            splitContainer1 = new KlonsLIB.Components.MySplitContainer();
            tbOut = new KlonsLIB.Components.FlatRichTextBox();
            tbIn = new KlonsLIB.Components.FlatRichTextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbUserId);
            panel1.Controls.Add(label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(719, 30);
            panel1.TabIndex = 1;
            // 
            // tbUserId
            // 
            tbUserId.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbUserId.Location = new System.Drawing.Point(159, 3);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new System.Drawing.Size(309, 23);
            tbUserId.TabIndex = 0;
            tbUserId.Leave += tbUserId_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 17);
            label2.TabIndex = 1;
            label2.Text = "Lietotāja identifikators:";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsiSend, tsiCheck, tsbClear, toolStripLabel1, cbAutoCheckConfig });
            toolStrip1.Location = new System.Drawing.Point(0, 330);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(719, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsiSend
            // 
            tsiSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsiSend.Image = (System.Drawing.Image)resources.GetObject("tsiSend.Image");
            tsiSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsiSend.Name = "tsiSend";
            tsiSend.Size = new System.Drawing.Size(123, 24);
            tsiSend.Text = "Nosūtīt jautājumu";
            tsiSend.Click += tsiSend_Click;
            // 
            // tsiCheck
            // 
            tsiCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsiCheck.Image = (System.Drawing.Image)resources.GetObject("tsiCheck.Image");
            tsiCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsiCheck.Name = "tsiCheck";
            tsiCheck.Size = new System.Drawing.Size(138, 24);
            tsiCheck.Text = "Pārbaudīt pastkastīti";
            tsiCheck.Click += tsiCheck_Click;
            // 
            // tsbClear
            // 
            tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsbClear.Image = (System.Drawing.Image)resources.GetObject("tsbClear.Image");
            tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbClear.Name = "tsbClear";
            tsbClear.Size = new System.Drawing.Size(105, 24);
            tsbClear.Text = "Izdzēst saraksti";
            tsbClear.Click += tsbClear_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(105, 24);
            toolStripLabel1.Text = "Auto pārbaudīt:";
            // 
            // cbAutoCheckConfig
            // 
            cbAutoCheckConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAutoCheckConfig.Items.AddRange(new object[] { "Nekad", "Atverot programmu", "Vienreiz stundā", "Vienraiz 5 stundās", "Vienreiz dienā" });
            cbAutoCheckConfig.Name = "cbAutoCheckConfig";
            cbAutoCheckConfig.Size = new System.Drawing.Size(160, 27);
            cbAutoCheckConfig.SelectedIndexChanged += cbAutoCheckConfig_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            splitContainer1.Location = new System.Drawing.Point(0, 30);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tbOut);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tbIn);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            splitContainer1.Size = new System.Drawing.Size(719, 300);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.TabIndex = 0;
            // 
            // tbOut
            // 
            tbOut.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            tbOut.Location = new System.Drawing.Point(5, 5);
            tbOut.Margin = new System.Windows.Forms.Padding(0);
            tbOut.Name = "tbOut";
            tbOut.ReadOnly = true;
            tbOut.Size = new System.Drawing.Size(709, 185);
            tbOut.TabIndex = 0;
            tbOut.Text = "";
            // 
            // tbIn
            // 
            tbIn.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            tbIn.Location = new System.Drawing.Point(5, 22);
            tbIn.Name = "tbIn";
            tbIn.Size = new System.Drawing.Size(709, 74);
            tbIn.TabIndex = 0;
            tbIn.Text = "";
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(5, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(709, 17);
            label1.TabIndex = 1;
            label1.Text = "Jautājums:";
            // 
            // Form_Chat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(719, 357);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Name = "Form_Chat";
            Text = "Atbalsts";
            Load += Form_Chat_Load;
            Shown += Form_Chat_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private KlonsLIB.Components.MySplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbUserId;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.FlatRichTextBox tbOut;
        private KlonsLIB.Components.FlatRichTextBox tbIn;
        private System.Windows.Forms.ToolStripButton tsiSend;
        private System.Windows.Forms.ToolStripButton tsiCheck;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbAutoCheckConfig;
        private System.Windows.Forms.ToolStripButton tsbClear;
    }
}