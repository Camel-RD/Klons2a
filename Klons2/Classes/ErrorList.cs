using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlonsLIB.Misc;

namespace KlonsF.Classes
{
    public class ErrorInfo
    {
        public string Source { get; set; } = null;
        public string Message { get; set; } = null;
    }

    public class ErrorList : List<ErrorInfo>
    {
        public bool HasErrors { get { return Count > 0; } }

        public ErrorList()
        {
        }

        public ErrorList(string source, string msg)
        {
            AddError(source, msg);
        }

        public void AddError(string source, string msg)
        {
            var ei = new ErrorInfo()
            {
                Source = source,
                Message = msg
            };
            Add(ei);
        }

        public void AddPersonError(int idp, string msg)
        {
            var ei = new ErrorInfo();
            var table_persons = KlonsF.Classes.KlonsData.St.DataSetKlonsA.PERSONS;
            if (table_persons != null)
            {
                var dr = table_persons.FindByID(idp);
                if (dr != null)
                    ei.Source = string.Format("{0}", dr.ZNAME);
            }
            ei.Message = msg;
            Add(ei);
        }

        public void AddItemError(int iditem, string msg)
        {
            var ei = new ErrorInfo();

            var table_items = KlonsData.St.DataSetKlonsM.M_ITEMS;
            if (table_items != null)
            {
                var dr = table_items.FindByID(iditem);
                if (dr != null)
                    ei.Source = $"artikuls: {dr.BARCODE} {dr.NAME}";
            }
            ei.Message = msg;

            Add(ei);
        }

        public void AddDocError(int iddoc, string msg)
        {
            var ei = new ErrorInfo();
            var table_docs = KlonsData.St.DataSetKlonsM.M_DOCS;
            if (table_docs != null)
            {
                var dr = table_docs.FindByID(iddoc);
                if (dr != null)
                    ei.Source = $"dokuments: {Utils.DateToString(dr.DT)} {dr.DocSrNr}";
            }
            ei.Message = msg;
            Add(ei);
        }

        public void SetErrorList(ErrorList newlist)
        {
            Clear();
            AddRange(newlist);
        }

        public bool HasSourceData => this.Where(x => !x.Source.IsNOE()).Any();

        public static ErrorList operator +(ErrorList e1, ErrorList e2)
        {
            if (e1 == null || e2 == null) return e1;
            e1.AddRange(e2);
            return e1;
        }

    }

}
