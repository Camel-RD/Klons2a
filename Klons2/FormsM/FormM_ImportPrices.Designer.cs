
namespace KlonsM.FormsM
{
    partial class FormM_ImportPrices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_ImportPrices));
            this.tbData = new KlonsLIB.Components.FlatRichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.miTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.iekopētTekstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miImportCheckNames = new System.Windows.Forms.ToolStripMenuItem();
            this.miImport1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miCancel = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.miImport21 = new System.Windows.Forms.ToolStripMenuItem();
            this.miImport22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.BorderColor = System.Drawing.SystemColors.ControlText;
            this.tbData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(10, 10);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(780, 391);
            this.tbData.TabIndex = 0;
            this.tbData.Text = "";
            this.tbData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbData_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTools,
            this.miCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 411);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // miTools
            // 
            this.miTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iekopētTekstuToolStripMenuItem,
            this.toolStripSeparator2,
            this.miImportCheckNames,
            this.miImport1,
            this.miImport21,
            this.miImport22});
            this.miTools.Image = ((System.Drawing.Image)(resources.GetObject("miTools.Image")));
            this.miTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miTools.Name = "miTools";
            this.miTools.Size = new System.Drawing.Size(65, 34);
            this.miTools.Text = "Rīki";
            // 
            // iekopētTekstuToolStripMenuItem
            // 
            this.iekopētTekstuToolStripMenuItem.Name = "iekopētTekstuToolStripMenuItem";
            this.iekopētTekstuToolStripMenuItem.Size = new System.Drawing.Size(706, 38);
            this.iekopētTekstuToolStripMenuItem.Text = "Iekopēt tekstu";
            this.iekopētTekstuToolStripMenuItem.Click += new System.EventHandler(this.iekopētTekstuToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(703, 6);
            // 
            // miImportCheckNames
            // 
            this.miImportCheckNames.Name = "miImportCheckNames";
            this.miImportCheckNames.Size = new System.Drawing.Size(706, 38);
            this.miImportCheckNames.Text = "Importēt datus (artikuls - nosaukums - cenas vai pašizmaksa))";
            this.miImportCheckNames.Click += new System.EventHandler(this.miImportCheckNames_Click);
            // 
            // miImport1
            // 
            this.miImport1.Name = "miImport1";
            this.miImport1.Size = new System.Drawing.Size(706, 38);
            this.miImport1.Text = "Impertēt datus (artikuls - cena vai pašizmaksa)";
            this.miImport1.Click += new System.EventHandler(this.miImport1_Click);
            // 
            // miCancel
            // 
            this.miCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miCancel.Image = ((System.Drawing.Image)(resources.GetObject("miCancel.Image")));
            this.miCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miCancel.Name = "miCancel";
            this.miCancel.Size = new System.Drawing.Size(72, 34);
            this.miCancel.Text = "Atcelt";
            this.miCancel.Click += new System.EventHandler(this.miCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(800, 411);
            this.panel1.TabIndex = 2;
            // 
            // miImport21
            // 
            this.miImport21.Name = "miImport21";
            this.miImport21.Size = new System.Drawing.Size(706, 38);
            this.miImport21.Text = "Importēt datus (artikuls - daudzums)";
            this.miImport21.Click += new System.EventHandler(this.miImport21_Click);
            // 
            // miImport22
            // 
            this.miImport22.Name = "miImport22";
            this.miImport22.Size = new System.Drawing.Size(706, 38);
            this.miImport22.Text = "Importēt datus (artikuls - daudzums - cena)";
            this.miImport22.Click += new System.EventHandler(this.miImport22_Click);
            // 
            // FormM_ImportPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormM_ImportPrices";
            this.Text = "Datu imports";
            this.Load += new System.EventHandler(this.FormM_ImportPrices_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlonsLIB.Components.FlatRichTextBox tbData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton miTools;
        private System.Windows.Forms.ToolStripMenuItem miImport1;
        private System.Windows.Forms.ToolStripMenuItem miImportCheckNames;
        private System.Windows.Forms.ToolStripButton miCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem iekopētTekstuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miImport21;
        private System.Windows.Forms.ToolStripMenuItem miImport22;
    }
}