namespace KlonsA.Forms
{
    partial class FormA_Events
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormA_Events));
            KlonsLIB.Components.MyMcComboBox.MyItem myItem1 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem2 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            bsEvents = new KlonsLIB.Data.MyBindingSource(components);
            bsNV = new KlonsLIB.Data.MyBindingSource(components);
            dgvEvents = new KlonsLIB.Components.MyDataGridView();
            dgcDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcIDN2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDate3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDocNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcOccCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cbFilterEvent = new KlonsLIB.Components.MyMcFlatComboBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            tbDT1 = new KlonsLIB.Components.MyTextBox();
            tbDT2 = new KlonsLIB.Components.MyTextBox();
            bsNV2 = new KlonsLIB.Data.MyBindingSource(components);
            cbFilterEvent2 = new KlonsLIB.Components.MyMcFlatComboBox();
            cbFilterMode = new KlonsLIB.Components.MyMcFlatComboBox();
            ((System.ComponentModel.ISupportInitialize)bsEvents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsNV2).BeginInit();
            SuspendLayout();
            // 
            // bsEvents
            // 
            bsEvents.DataMember = "EVENTS";
            bsEvents.MyDataSource = "KlonsAData";
            bsEvents.Sort = "DATE1";
            // 
            // bsNV
            // 
            bsNV.DataMember = "EVENT_TYPES";
            bsNV.MyDataSource = "KlonsAData";
            bsNV.Sort = "ID";
            // 
            // dgvEvents
            // 
            dgvEvents.AllowUserToAddRows = false;
            dgvEvents.AllowUserToDeleteRows = false;
            dgvEvents.AutoGenerateColumns = false;
            dgvEvents.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dgcDate1, dgcDate2, dgcIDP, dgcIDA, dgcIDN, dgcIDN2, dgcDescr, dgcDate3, dgcDocNr, dgcSCode, dgcDays, dgcOccCode, dgcID });
            dgvEvents.DataSource = bsEvents;
            dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvEvents.Location = new System.Drawing.Point(0, 25);
            dgvEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.ReadOnly = true;
            dgvEvents.RowHeadersWidth = 30;
            dgvEvents.Size = new System.Drawing.Size(1188, 497);
            dgvEvents.TabIndex = 0;
            dgvEvents.CellFormatting += dgvEvents_CellFormatting;
            // 
            // dgcDate1
            // 
            dgcDate1.DataPropertyName = "DATE1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            dgcDate1.DefaultCellStyle = dataGridViewCellStyle2;
            dgcDate1.HeaderText = "datums no";
            dgcDate1.MinimumWidth = 9;
            dgcDate1.Name = "dgcDate1";
            dgcDate1.ReadOnly = true;
            dgcDate1.Width = 85;
            // 
            // dgcDate2
            // 
            dgcDate2.DataPropertyName = "DATE2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            dgcDate2.DefaultCellStyle = dataGridViewCellStyle3;
            dgcDate2.HeaderText = "datums līdz";
            dgcDate2.MinimumWidth = 9;
            dgcDate2.Name = "dgcDate2";
            dgcDate2.ReadOnly = true;
            dgcDate2.Width = 85;
            // 
            // dgcIDP
            // 
            dgcIDP.DataPropertyName = "YNAME";
            dgcIDP.HeaderText = "darbinieks";
            dgcIDP.MinimumWidth = 9;
            dgcIDP.Name = "dgcIDP";
            dgcIDP.ReadOnly = true;
            dgcIDP.Width = 180;
            // 
            // dgcIDA
            // 
            dgcIDA.DataPropertyName = "IDA";
            dgcIDA.HeaderText = "amats";
            dgcIDA.MinimumWidth = 9;
            dgcIDA.Name = "dgcIDA";
            dgcIDA.ReadOnly = true;
            dgcIDA.Width = 135;
            // 
            // dgcIDN
            // 
            dgcIDN.DataPropertyName = "IDN";
            dgcIDN.HeaderText = "notikums";
            dgcIDN.MinimumWidth = 9;
            dgcIDN.Name = "dgcIDN";
            dgcIDN.ReadOnly = true;
            dgcIDN.Width = 202;
            // 
            // dgcIDN2
            // 
            dgcIDN2.DataPropertyName = "IDN2";
            dgcIDN2.HeaderText = "cits notikums";
            dgcIDN2.MinimumWidth = 9;
            dgcIDN2.Name = "dgcIDN2";
            dgcIDN2.ReadOnly = true;
            dgcIDN2.Width = 168;
            // 
            // dgcDescr
            // 
            dgcDescr.DataPropertyName = "DESCR";
            dgcDescr.HeaderText = "apraksts";
            dgcDescr.MinimumWidth = 9;
            dgcDescr.Name = "dgcDescr";
            dgcDescr.ReadOnly = true;
            dgcDescr.Width = 168;
            // 
            // dgcDate3
            // 
            dgcDate3.DataPropertyName = "DATE3";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dgcDate3.DefaultCellStyle = dataGridViewCellStyle4;
            dgcDate3.HeaderText = "izmaksas datums";
            dgcDate3.MinimumWidth = 9;
            dgcDate3.Name = "dgcDate3";
            dgcDate3.ReadOnly = true;
            dgcDate3.Width = 85;
            // 
            // dgcDocNr
            // 
            dgcDocNr.DataPropertyName = "DOCNR";
            dgcDocNr.HeaderText = "dok.nr.";
            dgcDocNr.MinimumWidth = 9;
            dgcDocNr.Name = "dgcDocNr";
            dgcDocNr.ReadOnly = true;
            dgcDocNr.Width = 67;
            // 
            // dgcSCode
            // 
            dgcSCode.DataPropertyName = "SCODE";
            dgcSCode.HeaderText = "ziņu kods";
            dgcSCode.MinimumWidth = 9;
            dgcSCode.Name = "dgcSCode";
            dgcSCode.ReadOnly = true;
            dgcSCode.Width = 56;
            // 
            // dgcDays
            // 
            dgcDays.DataPropertyName = "DAYS";
            dgcDays.HeaderText = "dienas";
            dgcDays.MinimumWidth = 9;
            dgcDays.Name = "dgcDays";
            dgcDays.ReadOnly = true;
            dgcDays.ToolTipText = "atvaļinājums dienas";
            dgcDays.Width = 67;
            // 
            // dgcOccCode
            // 
            dgcOccCode.DataPropertyName = "OCCUPATION_CODE";
            dgcOccCode.HeaderText = "prof. kods";
            dgcOccCode.MinimumWidth = 9;
            dgcOccCode.Name = "dgcOccCode";
            dgcOccCode.ReadOnly = true;
            dgcOccCode.ToolTipText = "profesijas kods";
            dgcOccCode.Width = 90;
            // 
            // dgcID
            // 
            dgcID.DataPropertyName = "ID";
            dgcID.HeaderText = "ID";
            dgcID.MinimumWidth = 9;
            dgcID.Name = "dgcID";
            dgcID.ReadOnly = true;
            dgcID.Visible = false;
            dgcID.Width = 168;
            // 
            // cbFilterEvent
            // 
            cbFilterEvent.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbFilterEvent.ColumnNames = new string[]
    {
    "ID",
    "DESCR"
    };
            cbFilterEvent.ColumnWidths = "0;350";
            cbFilterEvent.DataSource = bsNV;
            cbFilterEvent.DisplayMember = "DESCR";
            cbFilterEvent.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbFilterEvent.DropDownHeight = 216;
            cbFilterEvent.DropDownWidth = 369;
            cbFilterEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFilterEvent.FormattingEnabled = true;
            cbFilterEvent.GridLineColor = System.Drawing.Color.LightGray;
            cbFilterEvent.GridLineHorizontal = false;
            cbFilterEvent.GridLineVertical = false;
            cbFilterEvent.IntegralHeight = false;
            cbFilterEvent.Location = new System.Drawing.Point(363, 8);
            cbFilterEvent.Margin = new System.Windows.Forms.Padding(1, 4, 3, 4);
            cbFilterEvent.MaxDropDownItems = 12;
            cbFilterEvent.Name = "cbFilterEvent";
            cbFilterEvent.Size = new System.Drawing.Size(200, 24);
            cbFilterEvent.TabIndex = 4;
            cbFilterEvent.ValueMember = "ID";
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new System.Drawing.Size(16, 16);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel2, toolStripLabel3, toolStripLabel4, toolStripButton1 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new System.Drawing.Size(1188, 25);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            toolStripLabel2.Text = "-";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new System.Drawing.Size(12, 22);
            toolStripLabel3.Text = " ";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new System.Drawing.Size(16, 22);
            toolStripLabel4.Text = "  ";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new System.Drawing.Size(50, 22);
            toolStripButton1.Text = "Atlasīt";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tbDT1
            // 
            tbDT1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT1.IsDate = true;
            tbDT1.Location = new System.Drawing.Point(165, 8);
            tbDT1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDT1.Name = "tbDT1";
            tbDT1.Size = new System.Drawing.Size(80, 23);
            tbDT1.TabIndex = 7;
            // 
            // tbDT2
            // 
            tbDT2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDT2.IsDate = true;
            tbDT2.Location = new System.Drawing.Point(262, 8);
            tbDT2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbDT2.Name = "tbDT2";
            tbDT2.Size = new System.Drawing.Size(80, 23);
            tbDT2.TabIndex = 7;
            // 
            // bsNV2
            // 
            bsNV2.DataMember = "EVENT_TYPES2";
            bsNV2.MyDataSource = "KlonsAData";
            bsNV2.Sort = "TAG";
            // 
            // cbFilterEvent2
            // 
            cbFilterEvent2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbFilterEvent2.ColumnNames = new string[]
    {
    "TAG",
    "DESCR"
    };
            cbFilterEvent2.ColumnWidths = "100;300";
            cbFilterEvent2.DataSource = bsNV2;
            cbFilterEvent2.DisplayMember = "DESCR";
            cbFilterEvent2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbFilterEvent2.DropDownHeight = 144;
            cbFilterEvent2.DropDownWidth = 419;
            cbFilterEvent2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFilterEvent2.FormattingEnabled = true;
            cbFilterEvent2.GridLineColor = System.Drawing.Color.LightGray;
            cbFilterEvent2.GridLineHorizontal = false;
            cbFilterEvent2.GridLineVertical = false;
            cbFilterEvent2.IntegralHeight = false;
            cbFilterEvent2.Location = new System.Drawing.Point(610, 8);
            cbFilterEvent2.Margin = new System.Windows.Forms.Padding(7, 4, 3, 4);
            cbFilterEvent2.Name = "cbFilterEvent2";
            cbFilterEvent2.Size = new System.Drawing.Size(220, 24);
            cbFilterEvent2.TabIndex = 15;
            cbFilterEvent2.ValueMember = "ID";
            // 
            // cbFilterMode
            // 
            cbFilterMode.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbFilterMode.ColumnNames = new string[]
    {
    "col1",
    "col2"
    };
            cbFilterMode.ColumnWidths = "0;152";
            cbFilterMode.DisplayMember = "col2";
            cbFilterMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbFilterMode.DropDownHeight = 144;
            cbFilterMode.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbFilterMode.DropDownWidth = 171;
            cbFilterMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFilterMode.FormattingEnabled = true;
            cbFilterMode.GridLineColor = System.Drawing.Color.LightGray;
            cbFilterMode.GridLineHorizontal = false;
            cbFilterMode.GridLineVertical = false;
            cbFilterMode.IntegralHeight = false;
            myItem1.Col1 = "0";
            myItem1.Col2 = "pēc sākuma datuma";
            myItem2.Col1 = "1";
            myItem2.Col2 = "pēc statusa";
            cbFilterMode.Items.AddRange(new object[] { myItem1, myItem2 });
            cbFilterMode.ItemStrings = new string[]
    {
    "0;pēc sākuma datuma",
    "1;pēc statusa"
    };
            cbFilterMode.Location = new System.Drawing.Point(870, 7);
            cbFilterMode.Margin = new System.Windows.Forms.Padding(7, 4, 3, 4);
            cbFilterMode.Name = "cbFilterMode";
            cbFilterMode.Size = new System.Drawing.Size(160, 24);
            cbFilterMode.TabIndex = 16;
            cbFilterMode.ValueMember = "col1";
            // 
            // FormA_Events
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1188, 522);
            Controls.Add(cbFilterMode);
            Controls.Add(cbFilterEvent2);
            Controls.Add(tbDT2);
            Controls.Add(tbDT1);
            Controls.Add(cbFilterEvent);
            Controls.Add(dgvEvents);
            Controls.Add(toolStrip1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MyToolStrip = toolStrip1;
            Name = "FormA_Events";
            Text = "Notikumu izklāsts";
            Load += Form_Events_Load;
            ((System.ComponentModel.ISupportInitialize)bsEvents).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsNV2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsEvents;
        private KlonsLIB.Data.MyBindingSource bsNV;
        private KlonsLIB.Components.MyDataGridView dgvEvents;
        private KlonsLIB.Components.MyMcFlatComboBox cbFilterEvent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private KlonsLIB.Components.MyTextBox tbDT1;
        private KlonsLIB.Components.MyTextBox tbDT2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private KlonsLIB.Data.MyBindingSource bsNV2;
        private KlonsLIB.Components.MyMcFlatComboBox cbFilterEvent2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDN2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDate3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcOccCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcID;
        private KlonsLIB.Components.MyMcFlatComboBox cbFilterMode;
    }
}