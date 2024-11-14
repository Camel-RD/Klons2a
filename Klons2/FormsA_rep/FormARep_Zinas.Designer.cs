namespace KlonsA.Forms
{
    partial class FormARep_Zinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormARep_Zinas));
            dgvRep = new KlonsLIB.Components.MyDataGridView();
            dgcPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOccCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bsRep = new System.Windows.Forms.BindingSource(components);
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            tbDate2 = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            cmTable = new System.Windows.Forms.Button();
            cmReport = new System.Windows.Forms.Button();
            tbName = new KlonsLIB.Components.MyTextBox();
            label3 = new System.Windows.Forms.Label();
            tbPosition = new KlonsLIB.Components.MyTextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            tbDate = new KlonsLIB.Components.MyTextBox();
            tbPhoneNr = new KlonsLIB.Components.MyTextBox();
            cmXML = new System.Windows.Forms.Button();
            bnRows = new KlonsLIB.Components.MyBindingNavigator();
            bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnRows).BeginInit();
            bnRows.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRep
            // 
            dgvRep.AutoGenerateColumns = false;
            dgvRep.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcPK, dgcName, dgcDate, dgcCode, dgcCountry, dgcOccCode, dgcNr });
            dgvRep.DataSource = bsRep;
            dgvRep.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvRep.Location = new System.Drawing.Point(0, 93);
            dgvRep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvRep.Name = "dgvRep";
            dgvRep.RowHeadersWidth = 62;
            dgvRep.ShowCellToolTips = false;
            dgvRep.Size = new System.Drawing.Size(681, 298);
            dgvRep.TabIndex = 8;
            dgvRep.CellParsing += dgvRep_CellParsing;
            // 
            // dgcPK
            // 
            dgcPK.DataPropertyName = "PK";
            dgcPK.HeaderText = "Personas kods";
            dgcPK.MinimumWidth = 7;
            dgcPK.Name = "dgcPK";
            dgcPK.Width = 106;
            // 
            // dgcName
            // 
            dgcName.DataPropertyName = "Name";
            dgcName.HeaderText = "Vārds, uzvārds";
            dgcName.MinimumWidth = 7;
            dgcName.Name = "dgcName";
            dgcName.Width = 136;
            // 
            // dgcDate
            // 
            dgcDate.DataPropertyName = "Date";
            dgcDate.HeaderText = "Datums";
            dgcDate.MinimumWidth = 7;
            dgcDate.Name = "dgcDate";
            dgcDate.Width = 87;
            // 
            // dgcCode
            // 
            dgcCode.DataPropertyName = "Code";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcCode.DefaultCellStyle = dataGridViewCellStyle2;
            dgcCode.HeaderText = "Ziņu kods";
            dgcCode.MinimumWidth = 7;
            dgcCode.Name = "dgcCode";
            dgcCode.Width = 57;
            // 
            // dgcCountry
            // 
            dgcCountry.DataPropertyName = "Country";
            dgcCountry.HeaderText = "Valsts";
            dgcCountry.MinimumWidth = 7;
            dgcCountry.Name = "dgcCountry";
            dgcCountry.Width = 57;
            // 
            // dgcOccCode
            // 
            dgcOccCode.DataPropertyName = "ProfessionCode";
            dgcOccCode.HeaderText = "Profesijas kods";
            dgcOccCode.MinimumWidth = 7;
            dgcOccCode.Name = "dgcOccCode";
            dgcOccCode.Width = 77;
            // 
            // dgcNr
            // 
            dgcNr.DataPropertyName = "Nr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dgcNr.DefaultCellStyle = dataGridViewCellStyle3;
            dgcNr.HeaderText = "Npk.";
            dgcNr.MinimumWidth = 7;
            dgcNr.Name = "dgcNr";
            dgcNr.Visible = false;
            dgcNr.Width = 49;
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(134, 8);
            tbDate1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(90, 23);
            tbDate1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(118, 17);
            label1.TabIndex = 9;
            label1.Text = "Datums, no - līdz:";
            // 
            // tbDate2
            // 
            tbDate2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate2.IsDate = true;
            tbDate2.Location = new System.Drawing.Point(238, 8);
            tbDate2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDate2.Name = "tbDate2";
            tbDate2.Size = new System.Drawing.Size(90, 23);
            tbDate2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(226, 10);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 17);
            label2.TabIndex = 10;
            label2.Text = "-";
            // 
            // cmTable
            // 
            cmTable.Location = new System.Drawing.Point(408, 3);
            cmTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmTable.Name = "cmTable";
            cmTable.Size = new System.Drawing.Size(66, 30);
            cmTable.TabIndex = 2;
            cmTable.Text = "Atlasīt";
            cmTable.UseVisualStyleBackColor = true;
            cmTable.Click += cmTable_Click;
            // 
            // cmReport
            // 
            cmReport.Location = new System.Drawing.Point(479, 3);
            cmReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmReport.Name = "cmReport";
            cmReport.Size = new System.Drawing.Size(66, 30);
            cmReport.TabIndex = 3;
            cmReport.Text = "Atskaite";
            cmReport.UseVisualStyleBackColor = true;
            cmReport.Click += cmReport_Click;
            // 
            // tbName
            // 
            tbName.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbName.Location = new System.Drawing.Point(134, 37);
            tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(124, 23);
            tbName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 38);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 17);
            label3.TabIndex = 11;
            label3.Text = "Vārds, uzvārds:";
            // 
            // tbPosition
            // 
            tbPosition.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPosition.Location = new System.Drawing.Point(330, 37);
            tbPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPosition.Name = "tbPosition";
            tbPosition.Size = new System.Drawing.Size(124, 23);
            tbPosition.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(265, 38);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 17);
            label4.TabIndex = 12;
            label4.Text = "Amats:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(265, 67);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 17);
            label5.TabIndex = 14;
            label5.Text = "Datums:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 67);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 17);
            label6.TabIndex = 13;
            label6.Text = "Tālruņa numurs:";
            // 
            // tbDate
            // 
            tbDate.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate.IsDate = true;
            tbDate.Location = new System.Drawing.Point(330, 65);
            tbDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(90, 23);
            tbDate.TabIndex = 7;
            // 
            // tbPhoneNr
            // 
            tbPhoneNr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbPhoneNr.Location = new System.Drawing.Point(134, 65);
            tbPhoneNr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbPhoneNr.Name = "tbPhoneNr";
            tbPhoneNr.Size = new System.Drawing.Size(104, 23);
            tbPhoneNr.TabIndex = 6;
            // 
            // cmXML
            // 
            cmXML.Location = new System.Drawing.Point(551, 3);
            cmXML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmXML.Name = "cmXML";
            cmXML.Size = new System.Drawing.Size(66, 30);
            cmXML.TabIndex = 3;
            cmXML.Text = "XML";
            cmXML.UseVisualStyleBackColor = true;
            cmXML.Click += cmXML_Click;
            // 
            // bnRows
            // 
            bnRows.AddNewItem = bindingNavigatorAddNewItem;
            bnRows.BindingSource = bsRep;
            bnRows.CountItem = bindingNavigatorCountItem;
            bnRows.CountItemFormat = " no {0}";
            bnRows.DataGrid = dgvRep;
            bnRows.DeleteItem = bindingNavigatorDeleteItem;
            bnRows.Dock = System.Windows.Forms.DockStyle.Bottom;
            bnRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bnRows.ImageScalingSize = new System.Drawing.Size(16, 16);
            bnRows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, bindingNavigatorAddNewItem, bindingNavigatorDeleteItem });
            bnRows.Location = new System.Drawing.Point(0, 391);
            bnRows.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bnRows.MoveLastItem = bindingNavigatorMoveLastItem;
            bnRows.MoveNextItem = bindingNavigatorMoveNextItem;
            bnRows.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bnRows.Name = "bnRows";
            bnRows.PositionItem = bindingNavigatorPositionItem;
            bnRows.SaveItem = null;
            bnRows.Size = new System.Drawing.Size(681, 30);
            bnRows.TabIndex = 15;
            bnRows.Text = "myBindingNavigator1";
            bnRows.ItemDeleting += bnRows_ItemDeleting;
            // 
            // bindingNavigatorAddNewItem
            // 
            bindingNavigatorAddNewItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorAddNewItem.Image");
            bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorAddNewItem.Size = new System.Drawing.Size(71, 27);
            bindingNavigatorAddNewItem.Text = "Jauns";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 27);
            bindingNavigatorCountItem.Text = " no {0}";
            bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bindingNavigatorDeleteItem
            // 
            bindingNavigatorDeleteItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorDeleteItem.Image");
            bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorDeleteItem.Size = new System.Drawing.Size(69, 27);
            bindingNavigatorDeleteItem.Text = "Dzēst";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 27);
            bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 27);
            bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 27);
            bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (System.Drawing.Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 27);
            bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbDate1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tbPosition);
            panel1.Controls.Add(tbDate);
            panel1.Controls.Add(tbDate2);
            panel1.Controls.Add(tbPhoneNr);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmXML);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmReport);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmTable);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(681, 93);
            panel1.TabIndex = 16;
            // 
            // FormARep_Zinas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(681, 421);
            Controls.Add(dgvRep);
            Controls.Add(panel1);
            Controls.Add(bnRows);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormARep_Zinas";
            Text = "Ziņas par darba ņēmējiem";
            Load += FormRep_Zinas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRep).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRep).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnRows).EndInit();
            bnRows.ResumeLayout(false);
            bnRows.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Components.MyDataGridView dgvRep;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbDate2;
        private System.Windows.Forms.BindingSource bsRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmTable;
        private System.Windows.Forms.Button cmReport;
        private KlonsLIB.Components.MyTextBox tbName;
        private System.Windows.Forms.Label label3;
        private KlonsLIB.Components.MyTextBox tbPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private KlonsLIB.Components.MyTextBox tbDate;
        private KlonsLIB.Components.MyTextBox tbPhoneNr;
        private System.Windows.Forms.Button cmXML;
        private KlonsLIB.Components.MyBindingNavigator bnRows;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOccCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNr;
    }
}