using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjectsEI
{
    public class EmailSenderItem : INotifyPropertyChanged
    {
        public string CustomerName { get; set; }
        public string InvoiceID { get; set; }
        public string CustomerEmail { get; set; }
        public string Status { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
