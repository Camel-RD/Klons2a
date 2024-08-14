using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsF.Forms;
using KlonsF.FormsReportParams;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using System.Diagnostics;

namespace KlonsF
{
    public partial class Form_Main : MyMainFormBase
    {

        public Form_Main()
        {
            MyMainForm = this;
            var st = KlonsData.St; //init klonsdata
            InitializeComponent();
            SetupMenuRenderer();
            CheckMyFontAndColors();
            Application.ThreadException += Application_ThreadException;
            KlonsLIB.MyData.InWine = MyData.Settings.InWine == "YES";
        }

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            if (e.Exception is ArgumentException &&
                e.Exception.Message == "Parameter is not valid." &&
                e.Exception.Source == "System.Drawing" &&
                e.Exception.StackTrace.Contains("Microsoft.Reporting.WinForms.AsyncWaitMessage.OnLoad"))
                return;

            Form_Error.ShowException(e.Exception,
                "Programmas kļūda!\n" +
                "Ieteicams programmu aizvērt un palaist no jauna.\n" +
                "Ja kļūda bieži atkārtojas, ieteicams par to informēt programmas izstrādātāju.");
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public KlonsData MyData { get { return KlonsData.St; } }

        public override MyColorTheme MyColorTheme
        {
            get { return MyData.Settings.ColorTheme; }
        }

        public void ChangeDB()
        {
            if (!CloseAllForms()) return;
            Form_StartUp fs = new Form_StartUp();
            if (fs.ShowDialog(this) != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MyData.LoadSettings();
            if (MyData.Settings.WindowPos == "max")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            tsWindowList.Visible = MyData.Settings.ShowWindowListToolStrip;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ChangeDB();
            DoVersionCheck();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
        }

        private int klonsverURLNr = -1;
        private void DoVersionCheck()
        {
            if (MyData.Settings.DoVersionCheck != "YES") return;
            string ld = MyData.Settings.LastVersionCheckDate;
            DateTime dt;
            if (Utils.StringToDate(ld, out dt))
            {
                if (dt.AddDays(2) > DateTime.Today) return;
            }
            StartNextKlonsVerURL();
        }

        private void StartNextKlonsVerURL()
        {
            var urls = KlonsF.Properties.Settings.Default.KlonsVerURLS;
            klonsverURLNr++;
            if (urls == null || urls.Count <= klonsverURLNr) return;
            aDownloader1.URL = urls[klonsverURLNr];
            if (aDownloader1.StartDownload()) return;
            StartNextKlonsVerURL();
        }

        private void CheckVersionNr(string ver)
        {
            MyData.Settings.LastVersionCheckDate = Utils.DateToString(DateTime.Today);
            string v = MyData.Version;
            if (string.Compare(v, ver) < 0)
            {
                ShowInfo("Ir pieejama jauna programmas versija.\n" +
                         "To var lejuplādēt interneta lapā www.klons.id.lv.");
            }
        }

        private void aDownloader1_DataReceived(object sender, EventArgs e)
        {
            string ver = aDownloader1.GetData();
            if (ver == null || ver.Length != 3) return;
            Invoke(new Action<string>(CheckVersionNr), ver);
        }

        private void aDownloader1_DownloadFailed(object sender, EventArgs e)
        {
            StartNextKlonsVerURL();
        }


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MyData.Dispose();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseAllForms())
            {
                e.Cancel = true;
                return;
            }
            try
            {
                MyData.Params.Save();
            }
            catch (Exception) { }

            try
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    MyData.Settings.WindowPos = "max";
                }
                else
                {
                    MyData.Settings.WindowPos = "normal";
                }
                MyData.SaveSettings();
                FirebirdSql.Data.FirebirdClient.FbConnection.ClearAllPools();
            }
            catch (Exception) { }
        }


        public void LoadDataA()
        {
            var fs = new KlonsA.Forms.FormA_DataLoad();
            fs.ShowDialog(this);
        }

        public bool CheckDataA()
        {
            if (KlonsA.Classes.DataLoader.HasDataA() && KlonsA.Classes.DataLoader.DataLoaded) return true;
            KlonsA.Classes.DataLoader.LoadSomeData();
            if (KlonsA.Classes.DataLoader.HasDataA() && KlonsA.Classes.DataLoader.DataLoaded) return true;
            LoadDataA();
            return KlonsA.Classes.DataLoader.HasDataA() && KlonsA.Classes.DataLoader.DataLoaded;
        }

        public bool CheckDataP()
        {
            KlonsP.Classes.DataLoader.CheckData();
            return KlonsP.Classes.DataLoader.HasData();
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
            miCloseMDIForm.Visible = ActiveMdiChild != null;
        }

        private void miCloseMDIForm_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            ActiveMdiChild.Close();
        }

        private void miSistēma_DropDownOpening(object sender, EventArgs e)
        {
            miShowWindowList.Checked = MyData.Settings.ShowWindowListToolStrip;
        }

        private void miShowWindowList_Click(object sender, EventArgs e)
        {
            bool b = !miShowWindowList.Checked;
            miShowWindowList.Checked = b;
            MyData.Settings.ShowWindowListToolStrip = b;
            tsWindowList.Visible = b;
        }


        #region ============== ShowForm___ ==============

        public void ShowFormSettings()
        {
            var fs = new Form_Settings();
            fs.ShowDialog(this);
        }
        public Form_OpsFilter ShowFormOPSFilter()
        {
            return ShowForm(typeof(Form_OpsFilter)) as Form_OpsFilter;
        }
        public Form_Docs ShowFormDocs()
        {
            return ShowForm(typeof(Form_Docs)) as Form_Docs;
        }
        public Form_Docs FindFormDocs()
        {
            return FindForm(typeof(Form_Docs)) as Form_Docs;
        }
        public void ShowFormPersons()
        {
            var f = ShowForm(typeof(Form_Persons)) as Form_Persons;
        }
        public void ShowFormPersonsDialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_Persons)) as Form_Persons;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormAcplan()
        {
            var f = ShowForm(typeof(Form_AcPlan)) as Form_AcPlan;
        }
        public void ShowFormAcplanDialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_AcPlan)) as Form_AcPlan;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormAcp3()
        {
            var f = ShowForm(typeof(Form_AcP3)) as Form_AcP3;
        }
        public void ShowFormAcp3Dialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_AcP3)) as Form_AcP3;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormAcp4()
        {
            var f = ShowForm(typeof(Form_AcP4)) as Form_AcP4;
        }
        public void ShowFormAcp4Dialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_AcP4)) as Form_AcP4;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormAcp5()
        {
            var f = ShowForm(typeof(Form_AcPVN)) as Form_AcPVN;
        }
        public void ShowFormAcp5Dialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_AcPVN)) as Form_AcPVN;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormDocTyp()
        {
            var f = ShowForm(typeof(Form_DocTyp)) as Form_DocTyp;
        }
        public void ShowFormDocTypDialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_DocTyp)) as Form_DocTyp;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormAcPVN()
        {
            var f = ShowForm(typeof(Form_AcPVN)) as Form_AcPVN;
        }
        public void ShowFormOpsRules()
        {
            var f = ShowForm(typeof(Form_OpsRules)) as Form_OpsRules;
        }
        public void ShowFormOpsRulesDialog(Action<string> onselectedvalue)
        {
            var f = ShowFormDialog(typeof(Form_OpsRules)) as Form_OpsRules;
            if (f == null) return;
            f.OnSelectedValue = onselectedvalue;
        }
        public void ShowFormBal0()
        {
            var f = ShowForm(typeof(Form_Bal0)) as Form_Bal0;
        }
        public void ShowFormDocs0()
        {
            var f = ShowForm(typeof(Form_Docs0)) as Form_Docs0;
        }
        public void ShowFormUsersDialog()
        {
            var f = new Form_Users();
            f.ShowDialog(this);
        }


        //  ShowFormM
        public T ShowFormM<T>() where T : MyFormBaseF
        {
            bool loaded = KlonsM.Classes.DataMLoader.CheckLoad();
            if (loaded && !MyData.Settings.DontShowBetaWarning)
            {
                ShowWarning("Darbs pie programmas noliktavas moduļa turpinās. " +
                    "Tas tiek piedāvāts testēšanas nolūkiem. " +
                    "Lietotjāji tiek aicināti izmēģināt noliktavas moduļa iespējas "+
                    "un sūtīt savus ieteikumus tā uzlabojumiem un papildinājumiem.");
            }
            var f = ShowForm(typeof(T)) as MyFormBaseF;
            return (T)f;
        }
        public T ShowFormMDialog<T>(Action<string> onselectedvalue) where T : MyFormBaseF
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            var f = ShowFormDialog(typeof(T)) as MyFormBaseF;
            if (f == null) return null;
            f.OnSelectedValue = onselectedvalue;
            return (T)f;
        }
        public T ShowFormMDialog<T>(Action<int> onselectedvalue) where T : MyFormBaseF
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            var f = ShowFormDialog(typeof(T)) as MyFormBaseF;
            if (f == null) return null;
            f.OnSelectedValueInt = onselectedvalue;
            return (T)f;
        }
        public T ShowFormA<T>() where T : MyFormBaseF
        {
            if (!CheckDataA()) return null;
            var f = ShowForm(typeof(T)) as MyFormBaseF;
            return (T)f;
        }
        public T ShowFormP<T>() where T : MyFormBaseF
        {
            if (!CheckDataP()) return null;
            var f = ShowForm(typeof(T)) as MyFormBaseF;
            return (T)f;
        }

        #endregion


        #region ============ Menu Clicks System ==============

        private void miNomainītSaimniecību_Click(object sender, EventArgs e)
        {
            ChangeDB();
        }
        private void miFDokumentuLabojumi_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_LOPSd));
        }
        private void miFKontējumuLabojumi_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_LOPS));
        }
        private void miFMeklētIzmaiņas_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_LogDiff));
        }
        private void miFDatuEksports_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            ShowFormDialog(typeof(Form_Export));
        }
        private void miFDatuImports_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            ShowFormDialog(typeof(Form_Import));
        }
        private void miDatuBāzesImports_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            var frm = new Form_DatasetImport();
            frm.ShowDialog(this);
        }
        private void miAtvērtProgrammasMapi_Click(object sender, EventArgs e)
        {
            var myfolder = KlonsData.GetBasePath();
            try { Process.Start(myfolder); } catch (Exception) { }
        }
        private void miAtvērtRezervesKopijuMapi_Click(object sender, EventArgs e)
        {
            var myfolder = MyData.GetBackUpFolder();
            try { Process.Start(myfolder); } catch (Exception) { }
        }
        private void miRejectChangesF_Click(object sender, EventArgs e)
        {
            MyData.DataSetKlonsF.RejectChanges();
        }
        private void miRejectChangesA_Click(object sender, EventArgs e)
        {
            MyData.DataSetKlonsA.RejectChanges();
        }
        private void miRejectChangesP_Click(object sender, EventArgs e)
        {
            MyData.DataSetKlonsP.RejectChanges();
        }
        private void miRejectChangesM_Click(object sender, EventArgs e)
        {
            MyData.DataSetKlonsM.RejectChanges();
        }
        private void miRejectChangesAll_Click(object sender, EventArgs e)
        {
            MyData.DataSetKlonsF.RejectChanges();
            MyData.DataSetKlonsA.RejectChanges();
            MyData.DataSetKlonsP.RejectChanges();
            MyData.DataSetKlonsM.RejectChanges();
        }
        private bool AskBeforeDataReload()
        {
            if (!CloseAllForms()) return false;
            var rt = MyMessageBox.Show("Esošie dati tiks izmesti un ielādēti no jauna.\n"
                + "Vai turpināt?", "Klons", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null, this);
            return rt == DialogResult.Yes;
        }
        private void miReloadDataF_Click(object sender, EventArgs e)
        {
            if (!AskBeforeDataReload()) return;
            KlonsF.ClassesF.DataLoader.LoadSomeData();
        }
        private void miReloadDataA_Click(object sender, EventArgs e)
        {
            if (!AskBeforeDataReload()) return;
            MyData.DataSetKlonsM.Clear();
            KlonsA.Classes.DataLoader.LoadSomeData();
        }
        private void miReloadDataM_Click(object sender, EventArgs e)
        {
            if (!AskBeforeDataReload()) return;
            MyData.DataSetKlonsA.Clear();
            KlonsM.Classes.DataMLoader.FillAll();
        }
        private void miAizvērt_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            Application.Exit();
        }


        #endregion


        #region ============ Menu Clicks F ==============

        private void miFIeraksti_Click(object sender, EventArgs e)
        {
            ShowFormOPSFilter();
        }
        private void miFDokumentim_Click(object sender, EventArgs e)
        {
            ShowFormDocs();
        }
        private void miFPersonas_Click(object sender, EventArgs e)
        {
            ShowFormPersons();
        }
        private void miFKontuPlāns_Click(object sender, EventArgs e)
        {
            ShowFormAcplan();
        }
        private void miFPVNPazīmes_Click(object sender, EventArgs e)
        {
            ShowFormAcPVN();
        }
        private void miFKontējumuKontrole_Click(object sender, EventArgs e)
        {
            ShowFormOpsRulesDialog(null);
        }
        private void miFSākumaAtlikumi_Click(object sender, EventArgs e)
        {
            ShowFormBal0();
        }
        private void miFNeapmaksātieRēķini_Click(object sender, EventArgs e)
        {
            ShowFormDocs0();
        }
        private void miFKontējumaPazīmes_Click(object sender, EventArgs e)
        {
            ShowFormAcp4();
        }
        private void miFBankuSaraksts_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_Bankas));
        }
        private void miFDokumentuVeidi_Click(object sender, EventArgs e)
        {
            ShowFormDocTyp();
        }
        private void miFValūtuKursi_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_Currency));
        }
        private void miZiņasParUzņemumu_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_CompanyData));
        }
        private void miFBilance_Click(object sender, EventArgs e)
        {
            ShowForm(typeof (FormRep_Apgr1));
        }
        private void miFKontuKorespondence_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_Koresp));
        }
        private void miFAvansaNorēķins_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_AvNor));
        }
        private void miFPaMēnešiem_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_ApgrMT));
        }
        private void miFNaudasPlūsma_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_ApgrNP));
        }
        private void miFDarijumuŽurnāls_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_ApgrDZ));
        }
        private void miFPilnais_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_ApgrFull));
        }
        private void miFValūtasKontuAtskaites_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_Currency));
        }
        private void miFDarijumuŽurnāls1_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_Darz1));
        }
        private void miFNaudasPlūsma1_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_NPMT));
        }
        private void miFKasesGrāmata_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_KasesGr));
        }
        private void miFPersonuPārskats_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_Persons));
        }
        private void miFBilaneAtskaite_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_Bilance));
        }
        private void miFSkaidrasNaudasDarijumi_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_SkaidraNauda));
        }
        private void miFBilanceFormulas_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Form_BilancesFormula));
        }
        private void miFPVNDeklarācija_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_PVNDekl));
        }
        private void miFŽurnāls_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_PVNZ1));
        }
        private void miFPVNKopsavilkums_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_PVNKops));
        }
        private void miFPVNSummuKontrole_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_PVNCheck));
        }
        private void miFEdsTp_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(FormRep_EdsTp));
        }

        private void miKāStrādāsim_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            ShowFormSettings();
        }
        private void miParProgrammu_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog(MyMainForm);
        }
        private void miFApraksts_Click(object sender, EventArgs e)
        {
            var myfolder = MyData.GetManualsPath();
            try { Process.Start(myfolder); } catch (Exception) { }
        }


        #endregion


        #region ============ Menu Clicks P ==============
        
        private void miPPamatlīdzekļi_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_Items>();
        }
        private void miPNotikumi_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_Events>();
        }
        private void miPTaxDeprecYR_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_TaxDeprecYR>();
        }
        private void miPPamatlīdzekļuKategorijas_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_Cat1>();
        }
        private void miPNolietojumaKategorijas_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_CatD>();
        }
        private void miPNolietojumaKategorijasNodokļuVajadzībām_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_CatT>();
        }
        private void miPStruktūrvienības_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_Departments>();
        }
        private void miPAtrašanāsVietas_Click(object sender, EventArgs e)
        {
            ShowFormP<KlonsP.Forms.FormP_Places>();
        }
        private void miPKustībasPārskats_Click(object sender, EventArgs e)
        {
            if (!CheckDataP()) return;
            ShowFormDialog(typeof(KlonsP.Forms.FormPRep_Movement));
        }
        private void nolietojumsNodokļaAprēķinamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckDataP()) return;
            ShowFormDialog(typeof(KlonsP.Forms.FormPRep_TaxDeprec));
        }
        private void miPNnolietojumsNodokļuVajadzībāmPaKategorijām_Click(object sender, EventArgs e)
        {
            if (!CheckDataP()) return;
            ShowFormDialog(typeof(KlonsP.Forms.FormP_TaxDeprecCat));
        }

        #endregion


        #region ============ Menu Clicks A ==============

        private void rādītPēdējāsKļūdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = ShowForm(typeof(KlonsA.Forms.Form_ErrorList)) as KlonsA.Forms.Form_ErrorList;
            f.SetMyDataErrorList();
        }

        private void miRepStats_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Stats>();
        }
        private void miAPapildusNotikumuKodi_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_EventTypes2>();
        }
        private void miALikmes_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Rates>();
        }
        private void miAIenākumuVeidi_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_IncomeCodes>();
        }
        private void miATeritoriālieKodi_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_TeritorialCodes>();
        }
        private void miAProfesijuKlasifikators_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Professions>();
        }
        private void miAStruktūrvienības_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Departments>();
        }
        private void miASvētkuDienas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Holidays>();
        }
        private void miABankas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Banks>();
        }
        private void miAKalendārs_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Calendar>();
        }
        private void miADarbaLaikaPlānuSaraksts_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PlanList>();
        }
        private void miADarbaLaikaPlāns_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Plan>();
        }
        private void miADarbaLaikaUzskaitesLapuŠabloni_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_TimeSheetTempl>();
        }
        private void miADarbaLaikaUzskaitesLapas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_TimeSheets>();
        }
        private void miADarbiniekaDarbaLaikaUzskaitesDati_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_TimeSheet_Person>();
        }
        private void miADarbaLaikaUzskaitesLapa_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_TimeSheet>();
        }
        private void miADarbinieki1_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Persons>();
        }
        private void miADarbiniekuDati_Click(object sender, EventArgs e)
        {
            if (!CheckDataA()) return;
            if (MyData.DataSetKlonsA.PERSONS.Count == 0)
            {
                ShowWarning("Darbinieku saraksts ir tukšs.");
                return;
            }
            ShowForm(typeof(KlonsA.Forms.FormA_PersonsR));
        }
        private void miAstrādājošoPārskats_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormARep_ActivePersons>();
        }
        private void miAIzmaiņasNodokļuMaksātājaGrāmatiņāsnoEDS_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Persons_Egr>();
        }
        private void miADarbaNespējasLapas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Persons_DN_lapas>();
        }
        private void miNeapliekamaisMinimums_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_UntaxedMinimum>();
        }
        private void miANotikumuIzklāsts_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_Events>();
        }
        private void miANeizmantotāsAtvaļinājumaDienas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormARep_VacDays>();
        }
        private void miAPersonuSaraksts_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_FizPersons>();
        }
        private void miAMaksājumi_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_FpPayLists>();
        }
        private void miADatiParPerioduPirmsUzskaitesSākšanas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PastData>();
        }
        private void miAZiņuKodi_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_ReportCodes>();
        }
        private void miAAlgasAprēķinaLapuŠabloni_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_SalarySheetTempl>();
        }
        private void miAAlgasAprēķinaLapuSaraksts_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_SalarySheets>();
        }
        private void miAAlgasAprēķinaLapas_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_SalarySheet>();
        }
        private void miADarbaUzskaite_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PieceWork>();
        }
        private void miAKkatalogs_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PieceWorkCatalog>();
        }
        private void miAKatalogaStruktūra_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PieceWorkCatStruct>();
        }
        private void miASarakstuŠabloni_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PayListsTempl>();
        }
        private void miAMakasājumuSaraksti1_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PayLists>();
        }
        private void miAPārskatsPaPersonām_Click(object sender, EventArgs e)
        {
            ShowFormA<KlonsA.Forms.FormA_PaymentsByPerson>();
        }
        private void miAAtlasītDatus_Click(object sender, EventArgs e)
        {
            if (!CloseAllForms()) return;
            LoadDataA();
        }
        private void miAZiņasParDarbaŅēmējiem_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperA.WarnIfHasChanges();
            ShowFormA<KlonsA.Forms.FormARep_Zinas>();
        }
        private void miAZiņojumsParVSAOI_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperA.WarnIfHasChanges();
            ShowFormA<KlonsA.Forms.FormARep_VSAOI>();
        }
        private void miAPaziņojumsParFiziskajāmPersonāmIzmaksātajāmSummāmkopsavilkums_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperA.WarnIfHasChanges();
            ShowFormA<KlonsA.Forms.FormARep_IINK>();
        }
        private void miAKopsavilkums_Click(object sender, EventArgs e)
        {
            MyData.ReportHelperA.WarnIfHasChanges();
            ShowFormA<KlonsA.Forms.FormARep_Aggregate>();
        }



        #endregion


        #region ============ Menu Clicks M ==============

        private void miMDokumenti_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_DocList>();
        }
        private void miMNoliktavasPartneri_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_Stores>();
        }
        private void miMArtikuluKategorijas_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_ItemsCat>();
        }
        private void miMArtikuli_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_Items>();
        }
        private void miInventarizācijasDokumenti_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_InvDocList>();
        }
        private void miParamsM_Click(object sender, EventArgs e)
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            var fm = new KlonsM.FormsM.FormM_Params();
            fm.ShowDialog();
        }
        private void miMKontuPlāns_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_Accounts>();
        }
        private void miPartneruKategorijas_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_StoresCat>();
        }
        private void miMBankas_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_Banks>();
        }
        private void miMDarijumuVeidi_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_TransactionType>();
        }
        private void miMNorēķinuVeidi_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_PaymentTypes>();
        }
        private void miMValstis_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_Countries>();
        }
        private void miMKontēšanasShēma_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_PvnRates2>();
        }
        private void miMPVNAprēķinaAtsauces_Click(object sender, EventArgs e)
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            var fm = new KlonsM.FormsM.FormM_PVNTexts();
            fm.ShowDialog();
        }
        private void miMPilnsPārrēķins_Click(object sender, EventArgs e)
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            KlonsM.Classes.DataTasks.FullRecalc();
        }
        private void miMAtlikumuPārrēķins_Click(object sender, EventArgs e)
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            KlonsM.Classes.DataTasks.RecalcAmounts();
        }
        private void miMIsGonePārrēķins_Click(object sender, EventArgs e)
        {
            KlonsM.Classes.DataMLoader.CheckLoad();
            KlonsM.Classes.DataTasks.RecalcIsGone(true);
        }
        private void miMIzlietojumaPārskats_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepItemLinks>();
        }
        private void miMArtikulaKustībasPārskats_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_ItemMovement>();
        }
        private void miKustībaPaArtikuliem_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepMovementPerItem>();
        }
        private void miMKustībaPaPiegādātājiem_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepMovementPerSupplier>();
        }
        private void miMKustībaPaArtikuluKategorijām_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepMovementPerItemsCat>();
        }
        private void miMRealizācijasPašizmaksa_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepAccCosts>();
        }
        private void miMRealizācijasPašizmaksaPaDokumentiem_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_RepAccCostsPerDoc>();
        }
        private void miAtlaižuLapuSaraksts_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_DiscountLists>();
        }
        private void miAtlaižuLapa_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_DiscountList>();
        }
        private void miCenuLapuSaraksts_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_PriceLists>();
        }
        private void miCenuLapa_Click(object sender, EventArgs e)
        {
            ShowFormM<KlonsM.FormsM.FormM_PriceList>();
        }



        #endregion

    }
}
