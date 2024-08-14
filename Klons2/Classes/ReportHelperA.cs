using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsF.DataSets.klonsRepDataSetTableAdapters;
using KlonsLIB.Misc;
using KlonsLIB.Forms;
using Microsoft.Reporting.WinForms;

namespace KlonsF.Classes
{
    public class ReportHelperA : KlonsLIB.Forms.ReportHelper
    {
        public void WarnIfHasChanges()
        {
            if (KlonsData.St.KlonsDataHasChangesA())
            {
                KlonsData.St.MyMainForm.ShowWarning("Iespējams, ka datu tabulās ir nesaglabātas izmaiņas.");
            }
        }

        public override bool CheckForErrors(Action act)
        {
            WarnIfHasChanges();
            try
            {
                act();
                return true;
            }
            catch (Exception e)
            {
                MyException e1 = new MyException(
                    "Neizdevās sagatavot atskaiti!\n" +
                    "(iespējams, ka kļūda programmā).", e);
                Form_Error.ShowException(e1);
            }

            return false;
        }
    }
}
