using System;
using System.Linq;
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
    public class DatasetImporter
    {
        // "PROFESSIONS", "TERITORIAL_CODES"
        string[] TableNamesA =
        {
            "BANKS",
            "DEPARTMENTS",
            "EVENT_TYPES",
            "EVENT_TYPES2",
            "HOLIDAYS",
            "INCOME_CODES",
            "RATES",
            "REPORT_CODES",
            "PLUSMINUS_TYPES",
            "PERSONS_FIZ",
            "PERSONS",
            "POSITIONS",
            "POSITIONS_R",
            "PLUSMINUS_FROM",
            "POSITIONS_PLUSMINUS",
            "PERSONS_R",
            "EVENTS",
            "UNTAXED_MIN",
            "FP_PAYLISTS",
            "FP_PAYLISTS_R",
            "PASTDATA",
            "PAYLIST_TEMPL",
            "PAYLIST_TEMPL_R",
            "PAYLISTS",
            "PAYLISTS_R",
            "PIECEWORK_CATSTRUCT",
            "PIECEWORK_CATALOG",
            "PIECEWORK",
            "SALARY_SHEET_TEMPL",
            "SALARY_SHEET_TEMPL_R",
            "SALARY_SHEETS",
            "SALARY_SHEETS_R",
            "SALARY_SHEETS_R_HIST",
            "SALARY_PLUSMINUS",
            "TIMEPLAN_LIST",
            "TIMESHEET_TEMPL",
            "TIMESHEET_TEMPL_R",
            "TIMESHEET_LISTS",
            "TIMESHEET_LISTS_R",
            "TIMESHEET",
        };

        string[] TableNamesF =
        {
            "ACP21",
            "ACP23",
            "ACP24",
            "ACPVN",
            "ACP25",
            "ACP25A",
            "ACP6",
            "BALA1",
            "BALA2",
            "BALA3",
            "BANKS",
            "CURRENCY",
            "PERSONTYP",
            "PERSONS",
            "DOCTYP",
            "DOCTYPA",
            "DOCTYPB",
            "BAL0",
            "DOCS0",
            "OPSD",
            "OPS",
            "LOPSD",
            "LOPS"
        };

        string[] TableNamesP =
        {
            "CATD",
            "CATT",
            "CAT1",
            "PLACES",
            "DEPARTMENTS",
            "EVENTS",
            "ITEMS",
            "ITEMS_EVENTS",
            "TAXDEPRECYEAR"
        };

        public enum ESelectedDBType { None, Bad, A, F, P }

        public static string MakeConnectionString(string dbfilename)
        {
            var csb = new FbConnectionStringBuilder();
            csb.Charset = "UTF8";
            csb.ClientLibrary = "fbembed.dll";
            csb.ServerType = FbServerType.Embedded;
            csb.Database = dbfilename;
            csb.UserID = "SYSDBA";
            csb.Password = "parole";
            var con_str = csb.ConnectionString;
            con_str = KlonsData.St.CheckConnectionString(con_str);
            return con_str;
        }

        public static string[] GetDBTableNames(string dbfilename)
        {
            var con_str = MakeConnectionString(dbfilename);
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var tables_names = con.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
                var ret = new string[tables_names.Rows.Count];
                for (int i = 0; i < tables_names.Rows.Count; i++)
                {
                    var row = tables_names.Rows[i];
                    ret[i] = (string)row["TABLE_NAME"];
                }
                con.Close();
                return ret;
            }
        }


        bool StrigArrayContains(string[] ss1, string[] ss2)
        {
            ss1 = ss1.Select(x => x.ToUpper()).ToArray();
            ss2 = ss2.Select(x => x.ToUpper()).ToArray();
            return !ss2.Where(x => !ss1.Contains(x)).Any();
        }

        public ESelectedDBType GetDBType(string[] table_names)
        {
            if (StrigArrayContains(table_names, TableNamesF)) return ESelectedDBType.F;
            if (StrigArrayContains(table_names, TableNamesA)) return ESelectedDBType.A;
            if (StrigArrayContains(table_names, TableNamesP)) return ESelectedDBType.P;
            return ESelectedDBType.Bad;
        }

        public ErrorList CheckTablesAreEmpty(DataSetHelper dst_dataset_helper, string[] tablenames)
        {
            var ret = new ErrorList();
            using (var con = new FbConnection(dst_dataset_helper.ConnectionString))
            {
                con.Open();
                var cm = new FbCommand();
                cm.Connection = con;
                var bad_names = new List<string>();

                foreach (var tablename in tablenames)
                {
                    cm.CommandText = $"select count(RDB$DB_KEY) from {tablename}";
                    var rct = cm.ExecuteScalar();
                    int ct = (int)(long)rct;
                    if (ct > 0)
                        bad_names.Add(tablename);
                }
                cm.Dispose();
                con.Close();
                if (bad_names.Count > 0)
                {
                    //var msg = "Šīs tabulas nav tukšas: " + string.Join(", ", bad_names);
                    var msg = "Nevar importēt datus datu bāzes tabulās, kuras nav tukšas.";
                    ret.AddError("", msg);
                }
                return ret;
            }
        }

        public ErrorList LoadTables(DataSetHelper dst_dataset_helper, string[] tablenames)
        {
            var ret = new ErrorList();
            dst_dataset_helper.SetClearBeforeFillFor(true, tablenames);
            dst_dataset_helper.DataSet.EnforceConstraints = false;
            dst_dataset_helper.FillTables(tablenames);
            dst_dataset_helper.DataSet.EnforceConstraints = true;
            return ret;
        }

        string[] GetDataTableColumnNames(DataTable table)
        {
            var ret = new string[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
                ret[i] = table.Columns[i].ColumnName;
            return ret;
        }

        public void CopyDataTableRows(DataTable table_from, DataTable table_to)
        {
            var col_names_from = GetDataTableColumnNames(table_from);
            var col_names_to = GetDataTableColumnNames(table_to);
            var col_unames_to = col_names_to.Select(x => x.ToUpper()).ToArray();
            var col_names_x = col_names_from.Where(x => col_unames_to.Contains(x.ToUpper())).ToArray();
            foreach (var odr in table_from.Rows)
            {
                var dr = odr as DataRow;
                var dr_new = table_to.NewRow();
                foreach (var nm in col_names_x)
                {
                    var col = table_to.Columns[nm];
                    if (col.ReadOnly || !col.Expression.IsNOE()) continue;
                    dr_new[nm] = dr[nm];
                }
                table_to.Rows.Add(dr_new);
            }
        }

        public ErrorList ReadDataSet(
            DataSetHelper src_dataset_helper, 
            DataSetHelper dst_dataset_helper, 
            string[] tablenames,
            string table_prefix)
        {
            var ret = new ErrorList();
            var src_dataset = src_dataset_helper.DataSet;
            var dst_dataset = dst_dataset_helper.DataSet;

            var src_tablenames = src_dataset_helper.GetTableList();
            var src_tablenames_u = src_tablenames.Select(x => x.ToUpper()).ToArray();

            var bad_names1 = tablenames
                .Where(x => !src_tablenames_u.Contains(x))
                .ToList();

            var dst_tablenames = dst_dataset_helper.GetTableList();
            var dst_tablenames_u = dst_tablenames.Select(x => x.ToUpper()).ToArray();

            var bad_names2 = tablenames
                .Where(x => !dst_tablenames_u.Contains(x))
                .ToList();

            if (bad_names1.Any())
            {
                var msg = "Datubāze nesatur vajadzīgās tabulas: " + string.Join(", ", bad_names1);
                ret.AddError("db1", msg);
            }
            if (bad_names2.Any())
            {
                var msg = "Datubāze nesatur vajadzīgās tabulas: " + string.Join(", ", bad_names2);
                ret.AddError("db2", msg);
            }
            
            if (ret.HasErrors)
                return ret;

            var src_tablenames_r = tablenames.Select(x =>
                    src_tablenames.Where(y => string.Compare(x, y, true) == 0).First()).ToArray();

            var dst_tablenames_r = tablenames.Select(x =>
                    dst_tablenames.Where(y => string.Compare(x, y, true) == 0).First()).ToArray();

            var dst_tablenames2 = dst_tablenames_r.Select(x => table_prefix + x).ToArray();
            ret += CheckTablesAreEmpty(dst_dataset_helper, dst_tablenames2);

            if (ret.HasErrors)
                return ret;

            LoadTables(src_dataset_helper, src_tablenames_r);

            dst_dataset.Clear();

            for (int i = 0; i < tablenames.Length; i++)
            {
                var src_tablename = src_tablenames_r[i];
                var dst_tablename = dst_tablenames_r[i];
                var src_table = src_dataset.Tables[src_tablename];
                var dst_table = dst_dataset.Tables[dst_tablename];
                CopyDataTableRows(src_table, dst_table);
            }

            Utils.CallMethod(dst_dataset_helper.TableAdapterManager, "UpdateAll", dst_dataset);

            return ret;
        }

        public ErrorList ReadDataSetF(
            DataSetHelper src_dataset_helper,
            DataSetHelper dst_dataset_helper)
        {
            var err = ReadDataSet(src_dataset_helper, dst_dataset_helper, TableNamesF, "F_");
            if (err.HasErrors) return err;
            ResetIdGenF(dst_dataset_helper);
            UpdateZdtF(src_dataset_helper, dst_dataset_helper);
            KlonsData.St.SetUpTableManagerForUsersTable();
            KlonsData.St.FillParamsForUser(KlonsData.St.Settings.LastUserName);
            return err;
        }

        public ErrorList ReadDataSetA(
            DataSetHelper src_dataset_helper,
            DataSetHelper dst_dataset_helper)
        {
            var err = ReadDataSet(src_dataset_helper, dst_dataset_helper, TableNamesA, "A_");
            if (err.HasErrors) return err;
            ResetIdGenA(dst_dataset_helper);
            return err;
        }

        public ErrorList ReadDataSetP(
            DataSetHelper src_dataset_helper,
            DataSetHelper dst_dataset_helper)
        {
            var err = ReadDataSet(src_dataset_helper, dst_dataset_helper, TableNamesP, "P_");
            if (err.HasErrors) return err;
            ResetIdGenP(dst_dataset_helper);
            return err;
        }

        public void ClearF(DataSetHelper dst_dataset_helper)
        {
            dst_dataset_helper.DataSet.Clear();
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_clear_f;", con);
                cm.ExecuteNonQuery();
            }
        }

        public void ClearA(DataSetHelper dst_dataset_helper)
        {
            dst_dataset_helper.DataSet.Clear();
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_clear_a;", con);
                cm.ExecuteNonQuery();
            }
        }

        public void ClearP(DataSetHelper dst_dataset_helper)
        {
            dst_dataset_helper.DataSet.Clear();
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_clear_p;", con);
                cm.ExecuteNonQuery();
            }
        }


        public void ResetIdGenF(DataSetHelper dst_dataset_helper)
        {
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_genids_f;", con);
                cm.ExecuteNonQuery();
            }
        }

        public void ResetIdGenA(DataSetHelper dst_dataset_helper)
        {
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_genids_a;", con);
                cm.ExecuteNonQuery();
            }
        }

        public void ResetIdGenP(DataSetHelper dst_dataset_helper)
        {
            var con_str = dst_dataset_helper.ConnectionString;
            using (var con = new FbConnection(con_str))
            {
                con.Open();
                var cm = new FbCommand("execute procedure sp_x_genids_p;", con);
                cm.ExecuteNonQuery();
            }
        }

        public void UpdateZdtF(
            DataSetHelper src_dataset_helper,
            DataSetHelper dst_dataset_helper)
        {
            FbConnection con_src = null;
            FbCommand cm1 = null;
            var con_str_src = src_dataset_helper.ConnectionString;
            var qads = dst_dataset_helper.QueriesTableAdapter as KlonsF.DataSets.klonsDataSetTableAdapters.QueriesTableAdapter;

            try
            {
                con_src = new FbConnection(con_str_src);
                con_src.Open();
                cm1 = new FbCommand("select id, zdt from opsd;", con_src);
                var ad = new FbDataAdapter(cm1);
                var table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (var row in table.Rows)
                    {
                        var drow = row as DataRow;
                        int id = (int)drow[0];
                        DateTime zdt = (DateTime)drow[1];
                        qads.SP_F_ZDT_OPSD_SET(id, zdt);
                    }
                }
                cm1.Dispose();
                cm1 = new FbCommand("select id, zdt from ops;", con_src);
                ad = new FbDataAdapter(cm1);
                table = new DataTable();
                ad.Fill(table);
                if (table.Rows.Count > 0)
                {
                    foreach (var row in table.Rows)
                    {
                        var drow = row as DataRow;
                        int id = (int)drow[0];
                        DateTime zdt = (DateTime)drow[1];
                        qads.SP_F_ZDT_OPS_SET(id, zdt);
                    }
                }
            }
            finally
            {
                cm1?.Dispose();
                con_src?.Close();
                con_src?.Dispose();
            }

        }


        public DataSetHelper MakeDatasetHelperF(string connstr)
        {
            var dsh = new DataSetHelper(
                typeof(Klons1.DataSets.klonsDataSet),
                typeof(Klons1.DataSets.klonsDataSetTableAdapters.TableAdapterManager),
                null,
                "ConnectionStringF",
                Klons1.GetSettings.Settings);

            dsh.ConnectTo(connstr);

            return dsh;
        }

        public DataSetHelper MakeDatasetHelperA(string connstr)
        {
            var dsh = new DataSetHelper(
                typeof(Klons1.DataSets.KlonsADataSet),
                typeof(Klons1.DataSets.KlonsADataSetTableAdapters.TableAdapterManager),
                null,
                "ConnectionStringA",
                Klons1.GetSettings.Settings);

            dsh.ConnectTo(connstr);

            return dsh;
        }

        public DataSetHelper MakeDatasetHelperP(string connstr)
        {
            var dsh = new DataSetHelper(
                typeof(Klons1.DataSets.KlonsPDataSet),
                typeof(Klons1.DataSets.KlonsPDataSetTableAdapters.TableAdapterManager),
                null,
                "ConnectionStringP",
                Klons1.GetSettings.Settings);

            dsh.ConnectTo(connstr);

            return dsh;
        }

    }

}
