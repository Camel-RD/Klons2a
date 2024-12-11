
namespace KlonsF.Forms
{
    partial class Form_Settings
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
            KlonsLIB.Components.MyMcComboBox.MyItem myItem1 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem2 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem3 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem4 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem5 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem6 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem7 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            KlonsLIB.Components.MyMcComboBox.MyItem myItem8 = new KlonsLIB.Components.MyMcComboBox.MyItem();
            tabList1 = new Cyotek.Windows.Forms.TabList();
            tlpAppAppearance = new Cyotek.Windows.Forms.TabListPage();
            chInWine = new KlonsLIB.Components.MyCheckBox();
            chDontShowBetaWarning = new KlonsLIB.Components.MyCheckBox();
            cmUseSysFont = new System.Windows.Forms.Button();
            cmFont = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            cbColors = new KlonsLIB.Components.MyMcFlatComboBox();
            cbFontSize = new KlonsLIB.Components.MyMcFlatComboBox();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tlpKlonsF = new Cyotek.Windows.Forms.TabListPage();
            chCheckVersion = new KlonsLIB.Components.MyCheckBox();
            chUseCurrency = new KlonsLIB.Components.MyCheckBox();
            chC4 = new KlonsLIB.Components.MyCheckBox();
            chC3 = new KlonsLIB.Components.MyCheckBox();
            chC2 = new KlonsLIB.Components.MyCheckBox();
            chC1 = new KlonsLIB.Components.MyCheckBox();
            label1 = new System.Windows.Forms.Label();
            tlpKlonsA = new Cyotek.Windows.Forms.TabListPage();
            chIIN = new KlonsLIB.Components.MyCheckBox();
            chHideTotalSheet = new KlonsLIB.Components.MyCheckBox();
            label2 = new System.Windows.Forms.Label();
            tbMt = new KlonsLIB.Components.MyTextBox();
            tlpBackup = new Cyotek.Windows.Forms.TabListPage();
            cmBrowseForBackUpFolder = new System.Windows.Forms.Button();
            tbBackUpFolder = new KlonsLIB.Components.MyTextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cbBackUpPlan = new KlonsLIB.Components.MyMcFlatComboBox();
            cmCancel = new System.Windows.Forms.Button();
            cmOK = new System.Windows.Forms.Button();
            tabList1.SuspendLayout();
            tlpAppAppearance.SuspendLayout();
            tlpKlonsF.SuspendLayout();
            tlpKlonsA.SuspendLayout();
            tlpBackup.SuspendLayout();
            SuspendLayout();
            // 
            // tabList1
            // 
            tabList1.Controls.Add(tlpAppAppearance);
            tabList1.Controls.Add(tlpKlonsF);
            tabList1.Controls.Add(tlpKlonsA);
            tabList1.Controls.Add(tlpBackup);
            tabList1.HeaderSize = new System.Drawing.Size(155, 45);
            tabList1.HotBackColor = System.Drawing.SystemColors.ControlLight;
            tabList1.Location = new System.Drawing.Point(4, 5);
            tabList1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabList1.Name = "tabList1";
            tabList1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tabList1.Size = new System.Drawing.Size(592, 277);
            tabList1.TabIndex = 0;
            // 
            // tlpAppAppearance
            // 
            tlpAppAppearance.Controls.Add(chInWine);
            tlpAppAppearance.Controls.Add(chDontShowBetaWarning);
            tlpAppAppearance.Controls.Add(cmUseSysFont);
            tlpAppAppearance.Controls.Add(cmFont);
            tlpAppAppearance.Controls.Add(label4);
            tlpAppAppearance.Controls.Add(cbColors);
            tlpAppAppearance.Controls.Add(cbFontSize);
            tlpAppAppearance.Controls.Add(label5);
            tlpAppAppearance.Controls.Add(label3);
            tlpAppAppearance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpAppAppearance.Name = "tlpAppAppearance";
            tlpAppAppearance.Size = new System.Drawing.Size(429, 271);
            tlpAppAppearance.Text = "Programmas izskats";
            // 
            // chInWine
            // 
            chInWine.AutoSize = true;
            chInWine.Location = new System.Drawing.Point(27, 235);
            chInWine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chInWine.Name = "chInWine";
            chInWine.Size = new System.Drawing.Size(120, 18);
            chInWine.TabIndex = 29;
            chInWine.Text = "Linux Wine vide";
            chInWine.UseVisualStyleBackColor = true;
            // 
            // chDontShowBetaWarning
            // 
            chDontShowBetaWarning.AutoSize = true;
            chDontShowBetaWarning.Location = new System.Drawing.Point(27, 144);
            chDontShowBetaWarning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chDontShowBetaWarning.Name = "chDontShowBetaWarning";
            chDontShowBetaWarning.Size = new System.Drawing.Size(226, 18);
            chDontShowBetaWarning.TabIndex = 28;
            chDontShowBetaWarning.Text = "Nerādīt testa versijas brīdinājumu";
            chDontShowBetaWarning.UseVisualStyleBackColor = false;
            // 
            // cmUseSysFont
            // 
            cmUseSysFont.AutoSize = true;
            cmUseSysFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmUseSysFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmUseSysFont.Location = new System.Drawing.Point(206, 13);
            cmUseSysFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmUseSysFont.Name = "cmUseSysFont";
            cmUseSysFont.Size = new System.Drawing.Size(148, 29);
            cmUseSysFont.TabIndex = 21;
            cmUseSysFont.Text = "Ņemt sistēmas fontu";
            cmUseSysFont.UseVisualStyleBackColor = true;
            cmUseSysFont.Click += cmUseSysFont_Click;
            // 
            // cmFont
            // 
            cmFont.AutoSize = true;
            cmFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            cmFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmFont.Location = new System.Drawing.Point(123, 50);
            cmFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmFont.Name = "cmFont";
            cmFont.Size = new System.Drawing.Size(55, 29);
            cmFont.TabIndex = 22;
            cmFont.Text = "Fonts";
            cmFont.UseVisualStyleBackColor = true;
            cmFont.Click += cmFont_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 89);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 17);
            label4.TabIndex = 27;
            label4.Text = "Krāsu palete:";
            // 
            // cbColors
            // 
            cbColors.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbColors.ColumnNames = new string[]
    {
    "col1"
    };
            cbColors.ColumnWidths = "200";
            cbColors.DisplayMember = "col1";
            cbColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbColors.DropDownHeight = 168;
            cbColors.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbColors.DropDownWidth = 219;
            cbColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbColors.FormattingEnabled = true;
            cbColors.GridLineColor = System.Drawing.Color.LightGray;
            cbColors.GridLineHorizontal = false;
            cbColors.GridLineVertical = false;
            cbColors.IntegralHeight = false;
            myItem1.Col1 = "Sistēmas krāsas";
            myItem2.Col1 = "Tumšā tēma 1";
            myItem3.Col1 = "Zaļš uz melna";
            myItem4.Col1 = "Melns uz balta";
            cbColors.Items.AddRange(new object[] { myItem1, myItem2, myItem3, myItem4 });
            cbColors.ItemStrings = new string[]
    {
    "Sistēmas krāsas",
    "Tumšā tēma 1",
    "Zaļš uz melna",
    "Melns uz balta"
    };
            cbColors.Location = new System.Drawing.Point(123, 88);
            cbColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbColors.Name = "cbColors";
            cbColors.Size = new System.Drawing.Size(203, 24);
            cbColors.TabIndex = 23;
            cbColors.ValueMember = "col1";
            cbColors.SelectedIndexChanged += cbColors_SelectedIndexChanged;
            // 
            // cbFontSize
            // 
            cbFontSize.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbFontSize.ColumnNames = new string[]
    {
    "col1"
    };
            cbFontSize.ColumnWidths = "54";
            cbFontSize.DisplayMember = "col1";
            cbFontSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbFontSize.DropDownHeight = 420;
            cbFontSize.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbFontSize.DropDownWidth = 73;
            cbFontSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbFontSize.FormattingEnabled = true;
            cbFontSize.GridLineColor = System.Drawing.Color.LightGray;
            cbFontSize.GridLineHorizontal = false;
            cbFontSize.GridLineVertical = false;
            cbFontSize.IntegralHeight = false;
            cbFontSize.Items.AddRange(new object[] { "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "18", "20", "22", "24" });
            cbFontSize.ItemStrings = new string[]
    {
    "08",
    "09",
    "10",
    "11",
    "12",
    "13",
    "14",
    "15",
    "16",
    "18",
    "20",
    "22",
    "24"
    };
            cbFontSize.Location = new System.Drawing.Point(123, 17);
            cbFontSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbFontSize.MaxDropDownItems = 20;
            cbFontSize.Name = "cbFontSize";
            cbFontSize.Size = new System.Drawing.Size(71, 24);
            cbFontSize.TabIndex = 20;
            cbFontSize.ValueMember = "col1";
            cbFontSize.SelectedIndexChanged += cbFontSize_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(18, 56);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 17);
            label5.TabIndex = 26;
            label5.Text = "Fonts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 17);
            label3.TabIndex = 25;
            label3.Text = "Fonta izmērs:";
            // 
            // tlpKlonsF
            // 
            tlpKlonsF.Controls.Add(chCheckVersion);
            tlpKlonsF.Controls.Add(chUseCurrency);
            tlpKlonsF.Controls.Add(chC4);
            tlpKlonsF.Controls.Add(chC3);
            tlpKlonsF.Controls.Add(chC2);
            tlpKlonsF.Controls.Add(chC1);
            tlpKlonsF.Controls.Add(label1);
            tlpKlonsF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpKlonsF.Name = "tlpKlonsF";
            tlpKlonsF.Size = new System.Drawing.Size(427, 269);
            tlpKlonsF.Text = "Finanses";
            // 
            // chCheckVersion
            // 
            chCheckVersion.AutoSize = true;
            chCheckVersion.Location = new System.Drawing.Point(22, 197);
            chCheckVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chCheckVersion.Name = "chCheckVersion";
            chCheckVersion.Size = new System.Drawing.Size(354, 18);
            chCheckVersion.TabIndex = 26;
            chCheckVersion.Text = "Pārbaudīt, vai ir pieejama jaunāka programmas versija";
            chCheckVersion.UseVisualStyleBackColor = true;
            // 
            // chUseCurrency
            // 
            chUseCurrency.AutoSize = true;
            chUseCurrency.Location = new System.Drawing.Point(45, 163);
            chUseCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chUseCurrency.Name = "chUseCurrency";
            chUseCurrency.Size = new System.Drawing.Size(154, 18);
            chUseCurrency.TabIndex = 25;
            chUseCurrency.Text = "Rādīt valūtas kolonnu";
            chUseCurrency.UseVisualStyleBackColor = true;
            // 
            // chC4
            // 
            chC4.AutoSize = true;
            chC4.Location = new System.Drawing.Point(45, 133);
            chC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chC4.Name = "chC4";
            chC4.Size = new System.Drawing.Size(84, 18);
            chC4.TabIndex = 24;
            chC4.Text = "PVN kods";
            chC4.UseVisualStyleBackColor = true;
            // 
            // chC3
            // 
            chC3.AutoSize = true;
            chC3.Location = new System.Drawing.Point(45, 103);
            chC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chC3.Name = "chC3";
            chC3.Size = new System.Drawing.Size(167, 18);
            chC3.TabIndex = 23;
            chC3.Text = "Produkta, nozares kods";
            chC3.UseVisualStyleBackColor = true;
            // 
            // chC2
            // 
            chC2.AutoSize = true;
            chC2.Location = new System.Drawing.Point(45, 73);
            chC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chC2.Name = "chC2";
            chC2.Size = new System.Drawing.Size(207, 18);
            chC2.TabIndex = 22;
            chC2.Text = "IIN ieņēmumu, izdevumu kods";
            chC2.UseVisualStyleBackColor = true;
            // 
            // chC1
            // 
            chC1.AutoSize = true;
            chC1.Location = new System.Drawing.Point(45, 43);
            chC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chC1.Name = "chC1";
            chC1.Size = new System.Drawing.Size(158, 18);
            chC1.TabIndex = 21;
            chC1.Text = "Naudas plūsmas kods";
            chC1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(277, 17);
            label1.TabIndex = 28;
            label1.Text = "Izvēlamies kādas kolonnas tiks izmantotas:";
            // 
            // tlpKlonsA
            // 
            tlpKlonsA.Controls.Add(chIIN);
            tlpKlonsA.Controls.Add(chHideTotalSheet);
            tlpKlonsA.Controls.Add(label2);
            tlpKlonsA.Controls.Add(tbMt);
            tlpKlonsA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpKlonsA.Name = "tlpKlonsA";
            tlpKlonsA.Size = new System.Drawing.Size(452, 300);
            tlpKlonsA.Text = "Algas";
            // 
            // chIIN
            // 
            chIIN.AutoSize = true;
            chIIN.Location = new System.Drawing.Point(18, 84);
            chIIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chIIN.Name = "chIIN";
            chIIN.Size = new System.Drawing.Size(256, 18);
            chIIN.TabIndex = 20;
            chIIN.Text = "Ieturētais IIN tāds pats kā aprēķinātais";
            chIIN.UseVisualStyleBackColor = true;
            // 
            // chHideTotalSheet
            // 
            chHideTotalSheet.AutoSize = true;
            chHideTotalSheet.Location = new System.Drawing.Point(18, 53);
            chHideTotalSheet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chHideTotalSheet.Name = "chHideTotalSheet";
            chHideTotalSheet.Size = new System.Drawing.Size(219, 18);
            chHideTotalSheet.TabIndex = 19;
            chHideTotalSheet.Text = "Nerādīt algas aprēķina koplapas";
            chHideTotalSheet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(56, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(257, 17);
            label2.TabIndex = 21;
            label2.Text = "Cik mēnešu ielādēt, atverot saimniecību";
            // 
            // tbMt
            // 
            tbMt.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbMt.Location = new System.Drawing.Point(18, 16);
            tbMt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbMt.Name = "tbMt";
            tbMt.Size = new System.Drawing.Size(33, 23);
            tbMt.TabIndex = 18;
            tbMt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpBackup
            // 
            tlpBackup.Controls.Add(cmBrowseForBackUpFolder);
            tlpBackup.Controls.Add(tbBackUpFolder);
            tlpBackup.Controls.Add(label7);
            tlpBackup.Controls.Add(label6);
            tlpBackup.Controls.Add(cbBackUpPlan);
            tlpBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tlpBackup.Name = "tlpBackup";
            tlpBackup.Size = new System.Drawing.Size(452, 300);
            tlpBackup.Text = "Rezerves kopēšana";
            // 
            // cmBrowseForBackUpFolder
            // 
            cmBrowseForBackUpFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmBrowseForBackUpFolder.Location = new System.Drawing.Point(27, 143);
            cmBrowseForBackUpFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmBrowseForBackUpFolder.Name = "cmBrowseForBackUpFolder";
            cmBrowseForBackUpFolder.Size = new System.Drawing.Size(92, 29);
            cmBrowseForBackUpFolder.TabIndex = 25;
            cmBrowseForBackUpFolder.Text = "Noradīt";
            cmBrowseForBackUpFolder.UseVisualStyleBackColor = true;
            cmBrowseForBackUpFolder.Click += cmBrowseForBackUpFolder_Click;
            // 
            // tbBackUpFolder
            // 
            tbBackUpFolder.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            tbBackUpFolder.Location = new System.Drawing.Point(27, 113);
            tbBackUpFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tbBackUpFolder.Name = "tbBackUpFolder";
            tbBackUpFolder.Size = new System.Drawing.Size(290, 23);
            tbBackUpFolder.TabIndex = 24;
            tbBackUpFolder.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(152, 17);
            label7.TabIndex = 27;
            label7.Text = "Rezerves kopiju mape:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 22);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(183, 17);
            label6.TabIndex = 26;
            label6.Text = "Rezerves kopēšanas plāns:";
            // 
            // cbBackUpPlan
            // 
            cbBackUpPlan.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            cbBackUpPlan.ColumnNames = new string[]
    {
    "col1"
    };
            cbBackUpPlan.ColumnWidths = "190";
            cbBackUpPlan.DisplayMember = "col1";
            cbBackUpPlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbBackUpPlan.DropDownHeight = 168;
            cbBackUpPlan.DropDownStyle = KlonsLIB.Components.MyMcComboBox.CustomDropDownStyle.DropDownListSimple;
            cbBackUpPlan.DropDownWidth = 209;
            cbBackUpPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbBackUpPlan.FormattingEnabled = true;
            cbBackUpPlan.GridLineColor = System.Drawing.Color.LightGray;
            cbBackUpPlan.GridLineHorizontal = false;
            cbBackUpPlan.GridLineVertical = false;
            cbBackUpPlan.IntegralHeight = false;
            myItem5.Col1 = "Nekad";
            myItem6.Col1 = "Pirms aktualizēšanas";
            myItem7.Col1 = "Vienreiz dienā";
            myItem8.Col1 = "Pirms katras atvēršanas";
            cbBackUpPlan.Items.AddRange(new object[] { myItem5, myItem6, myItem7, myItem8 });
            cbBackUpPlan.ItemStrings = new string[]
    {
    "Nekad",
    "Pirms aktualizēšanas",
    "Vienreiz dienā",
    "Pirms katras atvēršanas"
    };
            cbBackUpPlan.Location = new System.Drawing.Point(27, 43);
            cbBackUpPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbBackUpPlan.Name = "cbBackUpPlan";
            cbBackUpPlan.Size = new System.Drawing.Size(190, 24);
            cbBackUpPlan.TabIndex = 23;
            cbBackUpPlan.ValueMember = "col1";
            // 
            // cmCancel
            // 
            cmCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cmCancel.Location = new System.Drawing.Point(504, 286);
            cmCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmCancel.Name = "cmCancel";
            cmCancel.Size = new System.Drawing.Size(88, 45);
            cmCancel.TabIndex = 17;
            cmCancel.Text = "Atcelt";
            cmCancel.UseVisualStyleBackColor = true;
            // 
            // cmOK
            // 
            cmOK.Location = new System.Drawing.Point(405, 286);
            cmOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmOK.Name = "cmOK";
            cmOK.Size = new System.Drawing.Size(88, 45);
            cmOK.TabIndex = 16;
            cmOK.Text = "OK";
            cmOK.UseVisualStyleBackColor = true;
            cmOK.Click += cmOK_Click;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(602, 335);
            Controls.Add(cmCancel);
            Controls.Add(cmOK);
            Controls.Add(tabList1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Settings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Kā strādāsim?";
            Load += Form_Settings2_Load;
            tabList1.ResumeLayout(false);
            tlpAppAppearance.ResumeLayout(false);
            tlpAppAppearance.PerformLayout();
            tlpKlonsF.ResumeLayout(false);
            tlpKlonsF.PerformLayout();
            tlpKlonsA.ResumeLayout(false);
            tlpKlonsA.PerformLayout();
            tlpBackup.ResumeLayout(false);
            tlpBackup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Cyotek.Windows.Forms.TabList tabList1;
        private Cyotek.Windows.Forms.TabListPage tlpAppAppearance;
        private Cyotek.Windows.Forms.TabListPage tlpKlonsF;
        private Cyotek.Windows.Forms.TabListPage tlpKlonsA;
        private Cyotek.Windows.Forms.TabListPage tlpBackup;
        private System.Windows.Forms.Button cmUseSysFont;
        private System.Windows.Forms.Button cmFont;
        private System.Windows.Forms.Label label4;
        private KlonsLIB.Components.MyMcFlatComboBox cbColors;
        private KlonsLIB.Components.MyMcFlatComboBox cbFontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmBrowseForBackUpFolder;
        private KlonsLIB.Components.MyTextBox tbBackUpFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private KlonsLIB.Components.MyMcFlatComboBox cbBackUpPlan;
        private KlonsLIB.Components.MyCheckBox chCheckVersion;
        private KlonsLIB.Components.MyCheckBox chUseCurrency;
        private KlonsLIB.Components.MyCheckBox chC4;
        private KlonsLIB.Components.MyCheckBox chC3;
        private KlonsLIB.Components.MyCheckBox chC2;
        private KlonsLIB.Components.MyCheckBox chC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmCancel;
        private System.Windows.Forms.Button cmOK;
        private KlonsLIB.Components.MyCheckBox chIIN;
        private KlonsLIB.Components.MyCheckBox chHideTotalSheet;
        private System.Windows.Forms.Label label2;
        private KlonsLIB.Components.MyTextBox tbMt;
        private KlonsLIB.Components.MyCheckBox chDontShowBetaWarning;
        private KlonsLIB.Components.MyCheckBox chInWine;
    }
}