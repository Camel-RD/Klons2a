using System;
using System.Data;
using System.Data.Common;
using System.IO;
using KlonsF.DataSets;
using KlonsFAdapters = KlonsF.DataSets.klonsDataSetTableAdapters;
using KlonsFRepAdapters = KlonsF.DataSets.klonsRepDataSetTableAdapters;
using KlonsMAdapters = KlonsF.DataSets.KlonsMDataSetTableAdapters;
using KlonsMRepAdapters = KlonsF.DataSets.KlonsMRepDataSetTableAdapters;
using KlonsPAdapters = KlonsF.DataSets.KlonsPDataSetTableAdapters;
using KlonsPRepAdapters = KlonsF.DataSets.KlonsPRepDataSetTableAdapters;
using KlonsAAdapters = KlonsF.DataSets.KlonsADataSetTableAdapters;
using KlonsARepAdapters = KlonsF.DataSets.KlonsARepDataSetTableAdapters;
using KlonsLIB.Data;
using KlonsLIB.Forms;
using KlonsLIB.Misc;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;

namespace KlonsF.Classes
{
    public class KlonsData: KlonsDataModule, IDisposable
    {
        private static KlonsData _KlonsData = null;

        private DataSetHelper _klonsFDataSetHelper = null;
        private DataSetHelper _klonsFRepDataSetHelper = null;
        private DataSetHelper _klonsMDataSetHelper = null;
        private DataSetHelper _klonsMRepDataSetHelper = null;
        private DataSetHelper _klonsPDataSetHelper = null;
        private DataSetHelper _klonsPRepDataSetHelper = null;
        private DataSetHelper _klonsADataSetHelper = null;
        private DataSetHelper _klonsARepDataSetHelper = null;

        public string Version = "016";
        public string VersionStr = "2024.07.#1";

        public string SettingsFileName = GetBasePath() + "\\Config\\Settings.xml";
        public string MasterListFileName = GetBasePath() + "\\Config\\MasterList.xml";
        public string FolderForXMLReports = GetBasePath() + "\\XMLReports";
        private string FolderForDBBackUp = GetBasePath() + "\\DB-backup";
        public string FolderForFbEmbed25 = GetBasePath() + "\\FbEmbed25" + (Environment.Is64BitProcess ? "x64" : "");
        public string FolderForFbEmbed4 = GetBasePath() + "\\FbEmbed4" + (Environment.Is64BitProcess ? "x64" : "");

        public KlonsSettings Settings = new KlonsSettings();
        public MasterList MasterList { get; private set; }
        public MasterEntry CurrentDBTag { get; private set;}

        private KlonsParams _Params = null;
        public ReportHelperF ReportHelperF { get; private set; }
        public ReportHelperA ReportHelperA { get; private set; }

        private string _currentUserName = "";
        public Form_Main MyMainForm { get { return Form_Main.MyInstance as Form_Main; } }

        public KlonsParams Params => _Params;
        public static int VersionRef(int ver) => ver;
        public float SalaryCalcHistoryInterval = 1.0f;

        public ErrorList ErrorInfoList { get; } = new ErrorList();

        private KlonsData()
        {
            _KlonsData = this;
            CurrentDBTag = null;

            LoadSettings();
            LoadMasterList();

            if (Settings.MasterEntry.Name != "")
            {
                var me = MasterList.GetMasterEntryByName(Settings.MasterEntry.Name);
                if (me != null)
                {
                    Settings.MasterEntry.CopyFrom(me);
                }
            }

            _Params = new KlonsParams();
            
            ReportHelperF = new ReportHelperF();
            ReportHelperA = new ReportHelperA();

            MakeDataSetHelpwers();
        }

        private void MakeDataSetHelpwers()
        {
            var setting = Klons2.GetSettings.Settings;

            _klonsFDataSetHelper = new DataSetHelper(
                typeof(klonsDataSet),
                typeof(KlonsFAdapters.TableAdapterManager),
                typeof(KlonsFAdapters.QueriesTableAdapter),
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsData"] = _klonsFDataSetHelper;

            _klonsFRepDataSetHelper = new DataSetHelper(
                typeof(klonsRepDataSet),
                typeof(KlonsFRepAdapters.TableAdapterManager),
                null,
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsRep"] = _klonsFRepDataSetHelper;


            _klonsMDataSetHelper = new DataSetHelper(
                typeof(KlonsMDataSet),
                typeof(KlonsMAdapters.TableAdapterManager),
                typeof(KlonsMAdapters.QueriesTableAdapter),
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsMData"] = _klonsMDataSetHelper;

            _klonsMRepDataSetHelper = new DataSetHelper(
                typeof(KlonsMRepDataSet),
                typeof(KlonsMRepAdapters.TableAdapterManager),
                typeof(KlonsMRepAdapters.QueriesTableAdapter),
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsMRep"] = _klonsMRepDataSetHelper;


            _klonsPDataSetHelper = new DataSetHelper(
                typeof(KlonsPDataSet),
                typeof(KlonsPAdapters.TableAdapterManager),
                typeof(KlonsPAdapters.QueriesTableAdapter),
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsPData"] = _klonsPDataSetHelper;

            _klonsPRepDataSetHelper = new DataSetHelper(
                typeof(KlonsPRepDataSet),
                typeof(KlonsPRepAdapters.TableAdapterManager),
                null,
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsPRep"] = _klonsPRepDataSetHelper;


            _klonsADataSetHelper = new DataSetHelper(
                typeof(KlonsADataSet),
                typeof(KlonsAAdapters.TableAdapterManager),
                typeof(KlonsAAdapters.QueriesTableAdapter),
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsAData"] = _klonsADataSetHelper;

            _klonsARepDataSetHelper = new DataSetHelper(
                typeof(KlonsARepDataSet),
                typeof(KlonsARepAdapters.TableAdapterManager),
                null,
                "ConnectionString1",
                setting);

            _dataSetHelpers["KlonsARep"] = _klonsARepDataSetHelper;
        }

        public bool ConnectTo(MasterEntry me, string username, string userpsw)
        {
            string filename = GetFileName(me);

            if (!File.Exists(filename))
            {
                throw new Exception($"Nav faila: [{filename}]");
            }

            if (CurrentDBTag != null)
            {
                try
                {
                    Params.Save();
                    if (KlonsFTableAdapterManager?.TUsersTableAdapter?.Connection != null)
                        KlonsFTableAdapterManager.TUsersTableAdapter.Connection.StateChange -= Connection_StateChange;
                }
                catch (Exception) { }
            }

            MakeDataSetHelpwers();

            string newconnstr = MasterList.GetTemplateByName(me.ConnStr);
            if (string.IsNullOrEmpty(newconnstr))
            {
                newconnstr = "character set=UTF8;" +
                    "data source=localhost;" +
                    @"initial catalog={0};" +
                    "user id=aivars;" +
                    "password=parole";
            }

            if (userpsw.IsNOE()) userpsw = "null";
            newconnstr = string.Format(newconnstr, filename, username, userpsw);
            var s1 = CheckConnectionString(newconnstr);
            if (s1 == null)
                throw new Exception($"Nekorekti pieslēguma dati:\n{newconnstr}");
            newconnstr = s1;

            _currentUserName = username;

            _klonsFDataSetHelper.ConnectTo(newconnstr);
            _klonsFRepDataSetHelper.ConnectTo(newconnstr);
            _klonsMDataSetHelper.ConnectTo(newconnstr);
            _klonsMRepDataSetHelper.ConnectTo(newconnstr);
            _klonsPDataSetHelper.ConnectTo(newconnstr);
            _klonsPRepDataSetHelper.ConnectTo(newconnstr);
            _klonsADataSetHelper.ConnectTo(newconnstr);
            _klonsARepDataSetHelper.ConnectTo(newconnstr);

            KlonsFTableAdapterManager.TUsersTableAdapter.Connection.StateChange += Connection_StateChange;
            KlonsFTableAdapterManager.TUsersTableAdapter.Connection.Open();

            CurrentDBTag = new MasterEntry(me);

            KlonsA.Classes.DataLoader.ResetState();

            return true;
        }

        public string GetConnectionString(MasterEntry me, string username, string userpsw)
        {
            if (username.IsNOE())
                throw new Exception($"Nav norādīts lietotāja vārds.");
            string filename = GetFileName(me);

            if (!File.Exists(filename))
            {
                throw new Exception($"Nav faila: [{filename}]");
            }

            string newconnstr = MasterList.GetTemplateByName(me.ConnStr);
            if (string.IsNullOrEmpty(newconnstr))
            {
                throw new Exception($"Nav atrasti pieslēguma parametri: [{me.ConnStr}]");
            }

            if (userpsw.IsNOE()) userpsw = "null";
            newconnstr = string.Format(newconnstr, filename, username, userpsw);
            var s1 = CheckConnectionString(newconnstr);
            if (s1 == null)
                throw new Exception($"Nekorekti pieslēguma dati:\n{newconnstr}");
            newconnstr = s1;

            return newconnstr;
        }

        public void GectSomeDbSysData(MasterEntry me, string username, string userpsw,
            out string usertp, out string dbver)
        {
            var constr = GetConnectionString(me, username, userpsw);
            var csb = new FbConnectionStringBuilder(constr);
            csb.Pooling = false;
            constr = csb.ToString();
            userpsw = userpsw.IsNOE() ? "null" : $"'{userpsw}'";
            using (var con = new FbConnection(constr))
            {
                con.Open();
                using (var cm = new FbCommand())
                {
                    cm.Connection = con;
                    cm.CommandText = $"execute procedure SP_SYS_CHECK_USER '{username}', {userpsw}";
                    var ret = cm.ExecuteScalar();
                    usertp = ret == DBNull.Value ? null : (string)ret;
                    cm.CommandText = $"select pvalue from params where pname = 'version' and usr = 'SYSTEM'";
                    ret = cm.ExecuteScalar();
                    dbver = ret == DBNull.Value ? null : (string)ret;
                }
                con.Close();
            }
        }

        public string GetFileName(MasterEntry me)
        {
            string filename;
            if (string.IsNullOrEmpty(me.Path))
            {
                filename = GetBaseDBPath();
            }
            else
            {
                filename = me.Path;
                filename = filename.Replace("@", GetBaseDBPath());
            }
            filename += "\\" + me.FileName;
            return filename;
        }

        public string CheckConnectionString(string constr)
        {
            try
            {
                var csb = new FbConnectionStringBuilder(constr);
                if (csb.ClientLibrary == "fbembed.dll")
                {
                    csb.ClientLibrary = $"{FolderForFbEmbed25}\\fbembed.dll";
                }
                else if(csb.ClientLibrary == "fbclient.dll")
                {
                    csb.ClientLibrary = $"{FolderForFbEmbed4}\\fbclient.dll";
                }
                return csb.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            //Debug.Print("Connection_StateChange to:" + e.CurrentState);
            if (e.CurrentState == ConnectionState.Open)
            {
                if (KlonsFQueriesTableAdapter != null)
                    KlonsFQueriesTableAdapter.SP_SET_USERNAME(CurrentUserName);
            }
        }

        public new static KlonsData St
        {
            get
            {
                if (_KlonsData == null)
                {
                    _KlonsData = new KlonsData();
                    _KlonsDataModule = _KlonsData;
                }
                return _KlonsData;
            }
        }

        public static void ResetInstance()
        {
            if (_KlonsData == null)
            {
                _KlonsData.Dispose();
                _KlonsData = null;
            }
            _KlonsData = new KlonsData();
            _KlonsDataModule = _KlonsData;
        }


        public klonsDataSet DataSetKlonsF => _klonsFDataSetHelper.DataSet as klonsDataSet;
        public klonsRepDataSet DataSetKlonsFRep => _klonsFRepDataSetHelper.DataSet as klonsRepDataSet;
        public KlonsMDataSet DataSetKlonsM => _klonsMDataSetHelper.DataSet as KlonsMDataSet;
        public KlonsMRepDataSet DataSetKlonsMRep => _klonsMRepDataSetHelper.DataSet as KlonsMRepDataSet;
        public KlonsPDataSet DataSetKlonsP => _klonsPDataSetHelper.DataSet as KlonsPDataSet;
        public KlonsPRepDataSet DataSetKlonsPRep => _klonsPRepDataSetHelper.DataSet as KlonsPRepDataSet;
        public KlonsADataSet DataSetKlonsA => _klonsADataSetHelper.DataSet as KlonsADataSet;
        public KlonsARepDataSet DataSetKlonsARep => _klonsARepDataSetHelper.DataSet as KlonsARepDataSet;

        public KlonsFAdapters.TableAdapterManager KlonsFTableAdapterManager
            => _klonsFDataSetHelper.TableAdapterManager as KlonsFAdapters.TableAdapterManager;
        public KlonsFAdapters.QueriesTableAdapter KlonsFQueriesTableAdapter
            => _klonsFDataSetHelper.QueriesTableAdapter as KlonsFAdapters.QueriesTableAdapter; 
        public KlonsFRepAdapters.TableAdapterManager KlonsFRepTableAdapterManager
            => _klonsFRepDataSetHelper.TableAdapterManager as KlonsFRepAdapters.TableAdapterManager; 
        
        public KlonsMAdapters.TableAdapterManager KlonsMTableAdapterManager
            => _klonsMDataSetHelper.TableAdapterManager as KlonsMAdapters.TableAdapterManager; 
        public KlonsMAdapters.QueriesTableAdapter KlonsMQueriesTableAdapter
            => _klonsMDataSetHelper.QueriesTableAdapter as KlonsMAdapters.QueriesTableAdapter;
        public KlonsMRepAdapters.TableAdapterManager KlonsMRepTableAdapterManager
            => _klonsMRepDataSetHelper.TableAdapterManager as KlonsMRepAdapters.TableAdapterManager; 
        public KlonsMRepAdapters.QueriesTableAdapter KlonsMRepQueriesTableAdapter
            => _klonsMRepDataSetHelper.QueriesTableAdapter as KlonsMRepAdapters.QueriesTableAdapter;

        public KlonsPAdapters.TableAdapterManager KlonsPTableAdapterManager
            => _klonsPDataSetHelper.TableAdapterManager as KlonsPAdapters.TableAdapterManager;
        public KlonsPAdapters.QueriesTableAdapter KlonsPQueriesTableAdapter
            => _klonsPDataSetHelper.QueriesTableAdapter as KlonsPAdapters.QueriesTableAdapter;

        public KlonsAAdapters.TableAdapterManager KlonsATableAdapterManager
            => _klonsADataSetHelper.TableAdapterManager as KlonsAAdapters.TableAdapterManager;
        public KlonsAAdapters.QueriesTableAdapter KlonsAQueriesTableAdapter
            => _klonsADataSetHelper.QueriesTableAdapter as KlonsAAdapters.QueriesTableAdapter;
        public KlonsARepAdapters.TableAdapterManager KlonsARepTableAdapterManager
            => _klonsARepDataSetHelper.TableAdapterManager as KlonsARepAdapters.TableAdapterManager;

        public string CurrentUserName => _currentUserName;

        public void SetCurrentUserName(string username)
        {
            _currentUserName = username;
        }

        public bool TestUserPassword(string username, string password)
        {
            klonsDataSet.TUsersRow r = DataSetKlonsF.TUsers.FindBynm(username);
            if (r == null) return false;
            if (string.IsNullOrEmpty(r.psw)) return true;
            if (password == null) return false;
            return r.psw == password;
        }
        public bool ChangeUserPassword(string username, string password)
        {
            klonsDataSet.TUsersRow r = DataSetKlonsF.TUsers.FindBynm(username);
            if (r == null) return false;
            r.psw = password;
            KlonsFTableAdapterManager.TUsersTableAdapter.Update(r);
            return true;
        }
        public string GetUserGroup(string username)
        {
            klonsDataSet.TUsersRow r = DataSetKlonsF.TUsers.FindBynm(username);
            if (r == null) return null;
            if (string.IsNullOrEmpty(r.tp)) return null;
            return r.tp;
        }

        public DbDataAdapter GetKlonsFSqlDataAdapter(string tablename)
        {
            return _klonsFDataSetHelper.GetSqlDataAdapter(tablename);
        }

        public object GetKlonsFAdapter(string tablename)
        {
            return _klonsFDataSetHelper.GetDataAdapter(tablename);
        }

        public object GetKlonsFRepAdapter(string tablename)
        {
            return _klonsFRepDataSetHelper.GetDataAdapter(tablename);
        }

        public object GetKlonsMAdapter(string tablename)
        {
            return _klonsMDataSetHelper.GetDataAdapter(tablename);
        }
        public object GetKlonsMRepAdapter(string tablename)
        {
            return _klonsMRepDataSetHelper.GetDataAdapter(tablename);
        }


        public object GetKlonsAAdapter(string tablename)
        {
            return _klonsADataSetHelper.GetDataAdapter(tablename);
        }
        public object GetKlonsAAdapter(DataTable table)
        {
            return _klonsADataSetHelper.GetDataAdapter(table.TableName);
        }

        public object GetKlonsARepAdapter(string tablename)
        {
            return _klonsARepDataSetHelper.GetDataAdapter(tablename);
        }
        public object GetKlonsARepAdapter(DataTable table)
        {
            return _klonsARepDataSetHelper.GetDataAdapter(table.TableName);
        }

        public void SetUpTableManagerForUsersTable()
        {
            _klonsFDataSetHelper.CreateAdapterForTable("TUsers");
            KlonsFTableAdapterManager.TUsersTableAdapter.Fill(DataSetKlonsF.TUsers);
        }

        public void SetUpTableManager()
        {
            _klonsFDataSetHelper.SetUpTableManager();
            _klonsFDataSetHelper.SetClearBeforeFillForAll(false);
            _klonsFRepDataSetHelper.SetClearBeforeFillForAll(true);

            _klonsMDataSetHelper.SetUpTableManager();
            _klonsMDataSetHelper.SetClearBeforeFillForAll(false);
            _klonsMRepDataSetHelper.SetClearBeforeFillForAll(true);

            _klonsPDataSetHelper.SetUpTableManager();
            _klonsPDataSetHelper.SetClearBeforeFillForAll(false);
            _klonsPRepDataSetHelper.SetClearBeforeFillForAll(true);

            _klonsADataSetHelper.SetUpTableManager();
            _klonsADataSetHelper.SetClearBeforeFillForAll(false);
            _klonsARepDataSetHelper.SetClearBeforeFillForAll(true);

            KlonsFTableAdapterManager.OPSTableAdapter.ClearBeforeFill = true;
            KlonsFTableAdapterManager.OPSdTableAdapter.ClearBeforeFill = true;
        }

        public void FillParamsForUser(string username)
        {
            Params.FillForUser(username);
        }

        public void FillBaseTables()
        {
            ClassesF.DataLoader.LoadSomeData();
        }

        public int FillKlonsFTable(string tablename)
        {
            return _klonsFDataSetHelper.FillTable(tablename);
        }

        public static string GetBasePath()
        {
            var s = Utils.GetMyFolderX();
            return s;
        }

        public string GetBaseDBPath()
        {
            return Path.Combine(GetBasePath(), Settings.BaseDBPathX);
        }

        public string GetBackUpFolder()
        {
            string backupfolder = Settings.BackUpFolder;
            if (backupfolder.IsNOE() || backupfolder == "DB-backup")
                backupfolder = FolderForDBBackUp;
            return backupfolder;
        }

        public string GetManualsPath()
        {
            return Path.Combine(GetBasePath(), "Apraksts");
        }

        public void CreateNewDB(string name, string descr)
        {
            MasterEntry me = new MasterEntry();
            me.Name = name;
            me.Descr = descr;
            me.ConnStr = Settings.BaseConnStr;
            string path = GetBaseDBPath();
            me.FileName = Utils.GetNextFile(path, "klons_", "fdb");
            me.FileName = Utils.GetFileNameFromURL(me.FileName);
            CreateNewDB(me);
        }
        public void CreateNewDB(MasterEntry me)
        {
            MasterList.ConnectionList.Add(me);
            string path = GetBaseDBPath();
            string fnmbase = path + "\\base\\Klons_00.fdb";
            string fnmnew = path + "\\" + me.FileName;
            if (!File.Exists(fnmbase))
            {
                throw new Exception("Fails [" + fnmbase + "] netika atrasts.");
            }
            File.Copy(fnmbase, fnmnew);
            return;
        }

        public string GetAcName(string ac)
        {
            var dr = DataSetKlonsF.AcP21.FindByAC(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetAc3Name(string ac)
        {
            var dr = DataSetKlonsF.Acp23.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetAc4Name(string ac)
        {
            var dr = DataSetKlonsF.AcP24.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetAc5Name(string ac)
        {
            var dr = DataSetKlonsF.Acp25.FindByidx(ac);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetClName(string cl)
        {
            var dr = DataSetKlonsF.Persons.FindByClId(cl);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetDocTypName(string dt)
        {
            var dr = DataSetKlonsF.DocTyp.FindByid(dt);
            if (dr == null) return null;
            return dr.Name;
        }
        public string GetBankName(string bankid)
        {
            var dr = DataSetKlonsF.Banks.FindById(bankid);
            if (dr == null) return null;
            return dr.Name;
        }

        public klonsDataSet.AcP24Row GetAcP24Row(string ac4)
        {
            if (string.IsNullOrEmpty(ac4)) return null;
            return DataSetKlonsF.AcP24.FindByidx(ac4);
        }

        public string RemoveUnitFromDescr(string descr)
        {
            if (string.IsNullOrEmpty(descr))
                return descr;
            int k = descr.IndexOf('~');
            if (k == -1) return descr;
            if (k == descr.Length - 1) return null;
            return descr.Substring(k + 1);
        }
        public string SetUnitInDescr(string descr, string unit)
        {
            descr = RemoveUnitFromDescr(descr);
            if (string.IsNullOrEmpty(unit)) return descr;
            if (string.IsNullOrEmpty(descr))
            {
                return unit + "~";
            }
            return unit + "~" + descr;
        }

        #region **************  PVN ****************

        public klonsDataSet.AcPVNRow GetPVNrow(string ac5)
        {
            if (string.IsNullOrEmpty(ac5)) return null;
            return DataSetKlonsF.AcPVN.FindByid(ac5);
        }

        public int AcPVNPz3(string id)
        {
            klonsDataSet.AcPVNRow dr = DataSetKlonsF.AcPVN.FindByid(id);
            if (dr == null) return -1;
            return dr.pz3;
        }

        public int GetPVNTyp(string ac5)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return -1;
            if (dr.Ispz5Null()) return 0;
            return dr.pz5;
        }

        public int GetPVNRate(string ac5)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return -1;
            if (dr.Ispz5Null()) return 0;
            return (int)dr.t;
        }

        public bool IsPVN(string ac5)
        {
            int k = GetPVNTyp(ac5);
            return k > 0;
        }

        public bool IsGoodPVN(string ac5)
        {
            int k = GetPVNTyp(ac5);
            return k == 1 || k == 3;
        }

        public bool IsIenemumiA(int ac5paz3)
        {
            return ac5paz3 == 1 || ac5paz3 == 71 ||
                   ac5paz3 == 72 || ac5paz3 == 8;
        }

        public bool IsIenemumi(string ac5)
        {
            int k = AcPVNPz3(ac5);
            return IsIenemumiA(k);
        }
        public int GetPVNRateA(string ac5, DateTime date)
        {
            klonsDataSet.AcPVNRow dr = GetPVNrow(ac5);
            if (dr == null) return 0;
            int k = dr.Ispz5Null() ? -1 : dr.pz5;
            if (k < 1) return 0;
            if (k > 3 || k == 1) return dr.IstNull() ? 0 : (int)dr.t;
            if (k == 2 || k == 3)
            {
                if (date < new DateTime(2011, 1, 1))
                {
                    return 21;
                }
                else if (date < new DateTime(2012, 8, 1))
                {
                    return 22;
                }
                else
                {
                    return 21;
                }
            }
            return 0;
        }
        #endregion

        public bool AddDocsRowToTRepOPSd(int docid)
        {
            var row = DataSetKlonsF.OPSd.FindByid(docid);
            if (row == null) return false;
            var row2 = DataSetKlonsFRep.TRepOPSd.NewTRepOPSdRow();
            row2.id = row.id;
            row2.ZNR = row.ZNR;
            row2.NrX = row.NrX;
            row2.Dete = row.Dete;
            row2.DocTyp = row.DocTyp;
            row2.DocSt = row.DocSt;
            row2.DocNr = row.DocNr;
            row2.ClId = row.ClId;
            row2.ClId2 = row.ClId2;
            row2.Descr = row.Descr;
            row2.Summ = row.Summ;
            row2.PVN = row.PVN;
            row2["DT2"] = row["DT2"];
            DataSetKlonsFRep.TRepOPSd.Rows.Add(row2);
            return true;
        }

        public bool KlonsDataHasChangesA()
        {
            var ds = DataSetKlonsA;
            return DataSetHelper.HasChanges(new DataTable[] {
                ds.SALARY_SHEETS,
                ds.SALARY_SHEETS_R,
                ds.TIMESHEET,
                ds.TIMESHEET_LISTS,
                ds.TIMESHEET_LISTS_R,
                ds.PERSONS,
                ds.PERSONS_R,
                ds.PERSONS_FIZ,
                ds.PAYLISTS,
                ds.PAYLISTS_R,
                ds.FP_PAYLISTS,
                ds.FP_PAYLISTS_R,
                ds.EVENTS,
                ds.POSITIONS,
                ds.POSITIONS_R});
        }

        public static double RoundA(double d, int k)
        {
            return Math.Round(d, k, MidpointRounding.AwayFromZero);
        }

        public static decimal RoundA(decimal d, int k)
        {
            return Math.Round(d, k, MidpointRounding.AwayFromZero);
            /*
                if (KlonsData.St.Params.RoundUp)
                    return Math.Round(d, k, MidpointRounding.AwayFromZero);
                else
                    return Math.Round(d, k);
            */
        }

        public void LoadSettings()
        {
            Settings = KlonsSettings.LoadSettings(SettingsFileName);
            KlonsLIB.MyData.Settings = Settings;
            ColorThemeHelper.MyToolStripRenderer.SetColorTheme(Settings.ColorTheme);
        }

        public void SaveSettings()
        {
            Settings.SaveSettings(SettingsFileName);
        }

        public void LoadMasterList()
        {
            MasterList = Classes.MasterList.LoadList(MasterListFileName);
        }

        public void SaveMasterList()
        {
            MasterList.SaveList(MasterListFileName);
        }

        private bool IsDisposed = false; // To detect redundant calls

        public void Dispose()
        {
            if (KlonsFTableAdapterManager?.TUsersTableAdapter?.Connection != null)
                KlonsFTableAdapterManager.TUsersTableAdapter.Connection.StateChange -= Connection_StateChange;
            _KlonsData = null;
            IsDisposed = true;
        }
    }

}
