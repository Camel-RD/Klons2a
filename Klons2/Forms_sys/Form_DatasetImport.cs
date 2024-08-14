using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.DataSets;
using KlonsF.Classes;
using KlonsLIB.Forms;
using KlonsLIB.Data;

namespace KlonsF.Forms
{
    public partial class Form_DatasetImport : MyFormBaseF
    {
        public Form_DatasetImport()
        {
            InitializeComponent();
            CheckMyFontAndColors();
            lbDBType.Text = "";
        }

        private void Form_DatasetImport_Load(object sender, EventArgs e)
        {

        }

        string DBFileName = null;
        DataSetHelper SrcDatasetHelper;
        DataSetHelper DstDatasetHelper;
        DatasetImporter.ESelectedDBType SelectedDBType = DatasetImporter.ESelectedDBType.None;

        DatasetImporter DatasetImporter = new DatasetImporter();

        public string GetDBFileName()
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Norādīt datu bāzes failu.";
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "Firebird DB (*.fdb)|*.fdb";
            var rt = ofd.ShowDialog(this);
            if (rt != DialogResult.OK) return null;
            return ofd.FileName;
        }

        public bool GetDBTableNames(string dbfilename, out string[] table_names)
        {
            try
            {
                table_names = DatasetImporter.GetDBTableNames(dbfilename);
                return true;
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās atvērt datu bāzes failu");
                table_names = null;
                return false;
            }
        }

        public void SetDBType(DatasetImporter.ESelectedDBType tp)
        {
            var msg = "";
            if (tp == DatasetImporter.ESelectedDBType.A) msg = "Datu bāze: algas";
            else if (tp == DatasetImporter.ESelectedDBType.F) msg = "Datu bāze: finanses";
            else if (tp == DatasetImporter.ESelectedDBType.P) msg = "Datu bāze: pamatlīdzekļi";
            else if (tp == DatasetImporter.ESelectedDBType.Bad) msg = "Datu bāze: nenoteikts";
            lbDBType.Text = msg;
            if (tp == DatasetImporter.ESelectedDBType.Bad)
            {
                lbDBType.ForeColor = Color.OrangeRed;
            }
            else
            {
                lbDBType.ForeColor = ForeColor;
            }
            SelectedDBType = tp;
        }

        public void DoClearF()
        {
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsF);
            DatasetImporter.ClearF(DstDatasetHelper);
        }

        public void DoClearA()
        {
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsA);
            DatasetImporter.ClearA(DstDatasetHelper);
        }

        public void DoClearP()
        {
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsP);
            DatasetImporter.ClearP(DstDatasetHelper);
        }

        public bool CheckGoodDBSelected()
        {
            if (SelectedDBType == DatasetImporter.ESelectedDBType.None)
            {
                MyMainForm.ShowWarning("Nav norādīta importējamā datu bāze.", "", this);
                return false;
            }
            if (SelectedDBType == DatasetImporter.ESelectedDBType.Bad)
            {
                MyMainForm.ShowWarning("Jānorāda korekta importējamā datu bāze.", "", this);
                return false;
            }
            return true;
        }

        public void DoClear()
        {
            if (!CheckGoodDBSelected()) return;

            try
            {
                if (SelectedDBType == DatasetImporter.ESelectedDBType.F)
                {
                    DoClearF();
                }
                else if (SelectedDBType == DatasetImporter.ESelectedDBType.A)
                {
                    DoClearA();
                }
                else if (SelectedDBType == DatasetImporter.ESelectedDBType.P)
                {
                    DoClearP();
                }
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās izdzēst datus.");
                return;
            }

            MyMainForm.ShowInfo("Datu izdzēšāna pabeigta.", "", this);
        }

        public ErrorList DoImportF()
        {
            var con_str = DatasetImporter.MakeConnectionString(DBFileName);
            SrcDatasetHelper = DatasetImporter.MakeDatasetHelperF(con_str);
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsF);
            var err = DatasetImporter.ReadDataSetF(SrcDatasetHelper, DstDatasetHelper);
            return err;
        }

        public ErrorList DoImportA()
        {
            var con_str = DatasetImporter.MakeConnectionString(DBFileName);
            SrcDatasetHelper = DatasetImporter.MakeDatasetHelperA(con_str);
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsA);
            var err = DatasetImporter.ReadDataSetA(SrcDatasetHelper, DstDatasetHelper);

            /*
            var adm = SrcDatasetHelper.TableAdapterManager as Klons1.DataSets.KlonsADataSetTableAdapters.TableAdapterManager;
            var ad1 = adm.EVENT_TYPESTableAdapter;
            var conn = DataSetHelper.GetFbConnection(ad1);
            if (conn != null)
                conn.Close();
            */

            return err;
        }

        public ErrorList DoImportP()
        {
            var con_str = DatasetImporter.MakeConnectionString(DBFileName);
            SrcDatasetHelper = DatasetImporter.MakeDatasetHelperP(con_str);
            DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsP);
            var err = DatasetImporter.ReadDataSetP(SrcDatasetHelper, DstDatasetHelper);
            return err;
        }

        void InvokeA(Action act)
        {
            Invoke(act);
        }

        public void DoImport(Form owner)
        {
            ErrorList err = null;
            try
            {
                if (SelectedDBType == DatasetImporter.ESelectedDBType.F)
                {
                    err = DoImportF();
                }
                else if (SelectedDBType == DatasetImporter.ESelectedDBType.A)
                {
                    err = DoImportA();
                }
                else if (SelectedDBType == DatasetImporter.ESelectedDBType.P)
                {
                    err = DoImportP();
                }
            }
            catch (Exception ex)
            {
                InvokeA((() => { Form_Error.ShowException(ex, "Neizdevās importēt datus."); }));
                return;
            }

            if (err != null && err.HasErrors)
            {
                InvokeA((() => { KlonsM.FormsM.FormM_ErrorList.ShowErrorList(owner, err); }));
                
                return;
            }

            InvokeA((() => { MyMainForm.ShowInfo("Datu imports pabeigts.", "", owner); }));
            
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            var fnm = GetDBFileName();
            if (fnm == null) return;
            DBFileName = fnm;
            tbFileName.Text = fnm;
            var rt = GetDBTableNames(fnm, out var table_names);
            if (!rt)
            {
                SetDBType(DatasetImporter.ESelectedDBType.Bad);
                return;
            }
            var tp = DatasetImporter.GetDBType(table_names);
            SetDBType(tp);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            if (!CheckGoodDBSelected()) return;

            lbWait.Visible = true;
            Enabled = false;

            var fm_wait = new KlonsM.FormsM.FormM_SPRunner()
            {
                TaskText = "Datu bāzes imports.",
                TextDoneText = "Datu bāzes imports pabeigts.\n"
                    + "Ieteicams pārbaudīt programmas darba iestatijumus un ziņas par uzņēmumu.",
                CloseOnDone = true
            };
            
            fm_wait.TaskFunc = () =>
            {
                DoImport(fm_wait);
                return null;
            };

            var rt = fm_wait.ShowDialog();

            lbWait.Visible = false;
            Enabled = true;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            DoClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckGoodDBSelected()) return;

            try
            {
                if (SelectedDBType == DatasetImporter.ESelectedDBType.F)
                {
                    var con_str = DatasetImporter.MakeConnectionString(DBFileName);
                    SrcDatasetHelper = DatasetImporter.MakeDatasetHelperF(con_str);
                    DstDatasetHelper = MyData.GetDataSetHelper(MyData.DataSetKlonsF);
                    DatasetImporter.UpdateZdtF(SrcDatasetHelper, DstDatasetHelper);
                }
                else 
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                Form_Error.ShowException(ex, "Neizdevās izdzēst datus.");
                return;
            }

            MyMainForm.ShowInfo("Datumu labošana pabeigta.", "", this);
        }
    }
}
