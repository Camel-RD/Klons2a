using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsEI
{
    public class InvoiceView : Invoice
    {
        public InvoiceView()
        {

        }

        public bool Checked { get; set; }
        public string FullFileName { get; set; }
        public string InvoiceDocumentExtension { get; set; }
        public string InvoiceDocumentFullFilename
        {
            get
            {
                if (string.IsNullOrEmpty(InvoiceDocumentExtension) ||
                    string.IsNullOrEmpty(FullFileName)) return null;
                var basedir = Path.GetDirectoryName(FullFileName);
                var fnm = Path.GetFileNameWithoutExtension(FullFileName) + InvoiceDocumentExtension;
                var ret = Path.Combine(basedir, fnm);
                return ret;
            }
        }
        public string FileName => Path.GetFileName(FullFileName);
        public string SubFolderName { get; set; }
        public string ValidationMessage { get; set; }
        public string Email { get; set; }

    }
}
