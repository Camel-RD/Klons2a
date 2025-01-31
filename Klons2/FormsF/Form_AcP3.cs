﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Components;
using KlonsLIB.Data;
using KlonsLIB.Misc;

namespace KlonsF.Forms
{
    public partial class Form_AcP3 : MyFormBaseF
    {
        public Form_AcP3()
        {
            InitializeComponent();
            CheckMyFontAndColors();
        }
        public Form_AcP3(string tablename)
            : this()
        {
            tableName = tablename;
        }

        private string tableName = null;

        private void FormAcP3_Load(object sender, EventArgs e)
        {
            if (tableName != null)
                bsAcP3.DataMember = tableName;
            if (bsAcP3.DataMember == MyData.DataSetKlonsF.Acp25.TableName)
            {
                this.Text = "PVN pazīmes";
            }
            bsAcP3.Fill();
            CheckSave();
        }

        public static string GetAcP3(string acp3)
        {
            var fm = new Form_AcP3();
            fm.SelectedValue = acp3;
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.FindAcP3(acp3);
            var ret = fm.ShowMyDialogModal();
            if (ret != DialogResult.OK) return null;
            return fm.SelectedValue;
        }

        public void FindAcP3(string acp3)
        {
            if (bsAcP3.Count == 0) return;
            if (acp3.IsNOE()) return;
            for (int i = 0; i < bsAcP3.Count; i++)
            {
                var dr = (bsAcP3[i] as DataRowView).Row as klonsDataSet.Acp23Row;
                if (dr.idx == acp3)
                {
                    bsAcP3.Position = i;
                    return;
                }
            }
        }

        private void SelectCurrent()
        {
            if (!this.IsMyDialog) return;
            if (dgvAcP3.CurrentRow == null || dgvAcP3.CurrentRow.IsNewRow) return;
            if (!dgvAcP3.EndEdit()) return;
            string ac = dgvAcP3.CurrentRow.Cells[0].Value.AsString();
            if (!SaveData()) return;
            SetSelectedValue(ac);
        }

        private void dgvAcP3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCurrent();
        }

        private void tbIdx_RowSelectedEvent(object sender, RowSelectedEventArgs e)
        {
            SetSelectedValue(e.Value);
        }

        private void dgvAcP3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Return)
            {
                SelectCurrent();
                e.Handled = true;
            }
        }

        private void tbIdx_Enter(object sender, EventArgs e)
        {
            tbIdx.SelectAll();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            tbSearch.SelectAll();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string s = tbSearch.Text;
                if (s == "")
                {
                    bsAcP3.RemoveFilter();
                }
                else
                {
                    bsAcP3.Filter = string.Format("Name LIKE '*{0}*'", s);
                }
            }
        }

        private void FormAcP3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                SetSelectedValue(null);
            }
        }

        private void dgvAcP3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                SetSelectedValue(null);
            }
        }

        private void dgvAcP3_MyKeyDown(object sender, KeyEventArgs e)
        {
        }
        
        private void bsAcP3_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (IsLoading) return;
            SetSaveButton(bsAcP3.HasChanges());
        }

        private void SetSaveButton(bool red)
        {
            bnavAcp3.SetSaveButton(tsbSave, red);
        }

        public override bool SaveData()
        {
            if (!dgvAcP3.EndEditX()) return false;
            var ret = bsAcP3.SaveTable();
            return ret != EBsSaveResult.Error;
        }

        private void CheckSave()
        {
            SetSaveButton(bsAcP3.HasChanges());
        }

        private void dgvAcP3_MyCheckForChanges(object sender, EventArgs e)
        {
            if (IsLoading) return;
            CheckSave();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData();
            SetSaveButton(bsAcP3.HasChanges());
        }

    }
}
