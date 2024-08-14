namespace KlonsA.Forms
{
    partial class FormA_PayListsRecalcParams
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
            bsPersons = new KlonsLIB.Data.MyBindingSource(components);
            cbPerson = new KlonsLIB.Components.MyMcFlatComboBox();
            tbDate1 = new KlonsLIB.Components.MyTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmRecalc = new System.Windows.Forms.Button();
            cmCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)bsPersons).BeginInit();
            SuspendLayout();
            // 
            // bsPersons
            // 
            bsPersons.DataMember = "PERSONS";
            bsPersons.Filter = "USED=1";
            bsPersons.MyDataSource = "KlonsAData";
            bsPersons.Sort = "YNAME";
            // 
            // cbPerson
            // 
            cbPerson.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbPerson.ColumnNames = new string[]
    {
    "FNAME",
    "LNAME",
    "PK"
    };
            cbPerson.ColumnWidths = "100;100;100";
            cbPerson.DataSource = bsPersons;
            cbPerson.DisplayMember = "YNAME";
            cbPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbPerson.DropDownHeight = 270;
            cbPerson.DropDownWidth = 319;
            cbPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbPerson.FormattingEnabled = true;
            cbPerson.GridLineColor = System.Drawing.Color.LightGray;
            cbPerson.GridLineHorizontal = false;
            cbPerson.GridLineVertical = false;
            cbPerson.IntegralHeight = false;
            cbPerson.Location = new System.Drawing.Point(22, 124);
            cbPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cbPerson.MaxDropDownItems = 15;
            cbPerson.Name = "cbPerson";
            cbPerson.Size = new System.Drawing.Size(218, 24);
            cbPerson.TabIndex = 1;
            cbPerson.ValueMember = "ID";
            // 
            // tbDate1
            // 
            tbDate1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbDate1.IsDate = true;
            tbDate1.Location = new System.Drawing.Point(22, 37);
            tbDate1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tbDate1.Name = "tbDate1";
            tbDate1.Size = new System.Drawing.Size(88, 23);
            tbDate1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 18);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 17);
            label1.TabIndex = 4;
            label1.Text = "Pārrēķināt sākot ar datumu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 89);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(192, 34);
            label2.TabIndex = 5;
            label2.Text = "Darbinieks:\r\n(tukšs, lai pārrēķinātu visiem)";
            // 
            // cmRecalc
            // 
            cmRecalc.Location = new System.Drawing.Point(115, 184);
            cmRecalc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cmRecalc.Name = "cmRecalc";
            cmRecalc.Size = new System.Drawing.Size(116, 37);
            cmRecalc.TabIndex = 2;
            cmRecalc.Text = "Pārrēķināt";
            cmRecalc.UseVisualStyleBackColor = true;
            cmRecalc.Click += cmRecalc_Click;
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(252, 184);
            cmCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(96, 37);
            cmCancel.TabIndex = 3;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            // 
            // FormA_PayListsRecalcParams
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = cmCancel;
            ClientSize = new System.Drawing.Size(364, 236);
            Controls.Add(cmCancel);
            Controls.Add(cmRecalc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDate1);
            Controls.Add(cbPerson);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormA_PayListsRecalcParams";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Maksājuma sarakstu pārrēķina parametri";
            Load += Form_PayListsRecalcParams_Load;
            ((System.ComponentModel.ISupportInitialize)bsPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsPersons;
        private KlonsLIB.Components.MyMcFlatComboBox cbPerson;
        private KlonsLIB.Components.MyTextBox tbDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmRecalc;
        private System.Windows.Forms.Button cmCancel;
    }
}