namespace KlonsA.Forms
{
    partial class FormA_PayListsNew
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
            bsPayListSH = new KlonsLIB.Data.MyBindingSource(components);
            cbSh = new KlonsLIB.Components.MyMcFlatComboBox();
            label1 = new System.Windows.Forms.Label();
            tbDate = new KlonsLIB.Components.MyTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            bsDep = new KlonsLIB.Data.MyBindingSource(components);
            tbDescr = new KlonsLIB.Components.MyTextBox();
            cbDep = new KlonsLIB.Components.MyMcFlatComboBox();
            lbCM = new System.Windows.Forms.ListBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmOK = new System.Windows.Forms.Button();
            tbYR = new KlonsLIB.Components.MyTextBox();
            tbMT = new KlonsLIB.Components.MyTextBox();
            cmCancel = new System.Windows.Forms.Button();
            cmGetTempl = new System.Windows.Forms.Button();
            cmGetDep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsPayListSH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsDep).BeginInit();
            SuspendLayout();
            // 
            // bsPayListSH
            // 
            bsPayListSH.DataMember = "PAYLIST_TEMPL";
            bsPayListSH.MyDataSource = "KlonsAData";
            // 
            // cbSh
            // 
            cbSh.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbSh.ColumnNames = new string[]
    {
    "ID",
    "DESCR",
    "DEP"
    };
            cbSh.ColumnWidths = "0;250;150";
            cbSh.DataSource = bsPayListSH;
            cbSh.DisplayMember = "DESCR";
            cbSh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbSh.DropDownHeight = 270;
            cbSh.DropDownWidth = 419;
            cbSh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbSh.FormattingEnabled = true;
            cbSh.GridLineColor = System.Drawing.Color.LightGray;
            cbSh.GridLineHorizontal = false;
            cbSh.GridLineVertical = false;
            cbSh.IntegralHeight = false;
            cbSh.Location = new System.Drawing.Point(11, 80);
            cbSh.MaxDropDownItems = 15;
            cbSh.Name = "cbSh";
            cbSh.Size = new System.Drawing.Size(263, 24);
            cbSh.TabIndex = 1;
            cbSh.ValueMember = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(203, 17);
            label1.TabIndex = 11;
            label1.Text = "Maksajumu saraksta sagatave:";
            // 
            // tbDate
            // 
            tbDate.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate.Location = new System.Drawing.Point(11, 27);
            tbDate.Name = "tbDate";
            tbDate.Size = new System.Drawing.Size(109, 23);
            tbDate.TabIndex = 0;
            tbDate.Leave += tbDate_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 17);
            label2.TabIndex = 8;
            label2.Text = "Izmaksas datums:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(123, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 17);
            label3.TabIndex = 9;
            label3.Text = "Par gadu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(190, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 17);
            label4.TabIndex = 10;
            label4.Text = "mēnesi:";
            // 
            // bsDep
            // 
            bsDep.DataMember = "DEPARTMENTS";
            bsDep.MyDataSource = "KlonsAData";
            bsDep.Sort = "ID";
            // 
            // tbDescr
            // 
            tbDescr.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDescr.Location = new System.Drawing.Point(11, 187);
            tbDescr.Name = "tbDescr";
            tbDescr.Size = new System.Drawing.Size(263, 23);
            tbDescr.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbDep.ColumnNames = new string[]
    {
    "ID",
    "DESCR"
    };
            cbDep.ColumnWidths = "100;300";
            cbDep.DataSource = bsDep;
            cbDep.DisplayMember = "DESCR";
            cbDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbDep.DropDownHeight = 270;
            cbDep.DropDownWidth = 419;
            cbDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbDep.FormattingEnabled = true;
            cbDep.GridLineColor = System.Drawing.Color.LightGray;
            cbDep.GridLineHorizontal = false;
            cbDep.GridLineVertical = false;
            cbDep.IntegralHeight = false;
            cbDep.Location = new System.Drawing.Point(11, 134);
            cbDep.MaxDropDownItems = 15;
            cbDep.Name = "cbDep";
            cbDep.Size = new System.Drawing.Size(263, 24);
            cbDep.TabIndex = 2;
            cbDep.ValueMember = "ID";
            // 
            // lbCM
            // 
            lbCM.BackColor = System.Drawing.SystemColors.Control;
            lbCM.FormattingEnabled = true;
            lbCM.ItemHeight = 16;
            lbCM.Items.AddRange(new object[] { "Visām sagatavēm", "Norādītajai sagatavei", "Tukšu sarakstu" });
            lbCM.Location = new System.Drawing.Point(11, 226);
            lbCM.Name = "lbCM";
            lbCM.Size = new System.Drawing.Size(147, 52);
            lbCM.TabIndex = 4;
            lbCM.DoubleClick += lbCM_DoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 169);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 17);
            label6.TabIndex = 13;
            label6.Text = "Apraksts:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 116);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(107, 17);
            label5.TabIndex = 12;
            label5.Text = "Struktūrvienība:";
            // 
            // cmOK
            // 
            cmOK.Location = new System.Drawing.Point(175, 231);
            cmOK.Name = "cmOK";
            cmOK.Size = new System.Drawing.Size(74, 47);
            cmOK.TabIndex = 5;
            cmOK.Text = "Izveidot";
            cmOK.UseVisualStyleBackColor = true;
            cmOK.Click += cmOK_Click;
            // 
            // tbYR
            // 
            tbYR.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbYR.Location = new System.Drawing.Point(126, 27);
            tbYR.Name = "tbYR";
            tbYR.ReadOnly = true;
            tbYR.Size = new System.Drawing.Size(60, 23);
            tbYR.TabIndex = 6;
            // 
            // tbMT
            // 
            tbMT.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbMT.Location = new System.Drawing.Point(192, 27);
            tbMT.Name = "tbMT";
            tbMT.ReadOnly = true;
            tbMT.Size = new System.Drawing.Size(36, 23);
            tbMT.TabIndex = 7;
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(257, 230);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(74, 48);
            cmCancel.TabIndex = 5;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            cmCancel.Click += cmCancel_Click;
            // 
            // cmGetTempl
            // 
            cmGetTempl.Location = new System.Drawing.Point(279, 80);
            cmGetTempl.Name = "cmGetTempl";
            cmGetTempl.Size = new System.Drawing.Size(33, 22);
            cmGetTempl.TabIndex = 14;
            cmGetTempl.Text = "?";
            cmGetTempl.UseVisualStyleBackColor = true;
            cmGetTempl.Click += cmGetTempl_Click;
            // 
            // cmGetDep
            // 
            cmGetDep.Location = new System.Drawing.Point(279, 134);
            cmGetDep.Name = "cmGetDep";
            cmGetDep.Size = new System.Drawing.Size(33, 22);
            cmGetDep.TabIndex = 14;
            cmGetDep.Text = "?";
            cmGetDep.UseVisualStyleBackColor = true;
            cmGetDep.Click += cmGetDep_Click;
            // 
            // FormA_PayListsNew
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cmCancel;
            ClientSize = new System.Drawing.Size(345, 300);
            Controls.Add(cmGetDep);
            Controls.Add(cmGetTempl);
            Controls.Add(tbMT);
            Controls.Add(tbYR);
            Controls.Add(cmCancel);
            Controls.Add(cmOK);
            Controls.Add(tbDescr);
            Controls.Add(cbDep);
            Controls.Add(lbCM);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSh);
            Name = "FormA_PayListsNew";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Jauns maksājumu saraksts";
            Load += Form_PayListsNew_Load;
            ((System.ComponentModel.ISupportInitialize)bsPayListSH).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsDep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsPayListSH;
        private KlonsLIB.Components.MyMcFlatComboBox cbSh;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyTextBox tbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private KlonsLIB.Data.MyBindingSource bsDep;
        private KlonsLIB.Components.MyTextBox tbDescr;
        private KlonsLIB.Components.MyMcFlatComboBox cbDep;
        private System.Windows.Forms.ListBox lbCM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmOK;
        private KlonsLIB.Components.MyTextBox tbYR;
        private KlonsLIB.Components.MyTextBox tbMT;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Button cmGetTempl;
        private System.Windows.Forms.Button cmGetDep;
    }
}