using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UblSharp.CommonAggregateComponents;

namespace DataObjectsEI
{
    public class InvoiceLine : INotifyPropertyChanged
    {
        public InvoiceLine()
        {
            VatType = "S";
        }

        public InvoiceLine(InvoiceLineType line)
        {
            VatType = "S";
            ReadFrom(line);
        }

        public string ID { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal AllowanceCharge { get; set; }
        public decimal TotalAmountBeforeTax { get; set; }
        public decimal VatRate { get; set; }
        public string VatType { get; set; }
        public decimal TotalAmount { get; set; }

        public void ReadFrom(InvoiceLineType line)
        {
            ID = line.ID;
            ItemName = line.Item.Name;
            Quantity = line.InvoicedQuantity.Value;
            Unit = line.InvoicedQuantity.unitCode;
            Price = line.Price.PriceAmount.Value;
            AllowanceCharge = 0M;
            if (line.AllowanceCharge != null)
                AllowanceCharge = line.AllowanceCharge.Select(x => x?.Amount?.Value ?? 0M).Sum();
            TotalAmountBeforeTax = line.LineExtensionAmount.Value;
            VatRate = line.Item.ClassifiedTaxCategory.FirstOrDefault()?.Percent ?? 0M;
            VatType = line.Item.ClassifiedTaxCategory.FirstOrDefault()?.ID;
            decimal vat = Math.Round(TotalAmountBeforeTax * VatRate / 100M, 2);
            TotalAmount = TotalAmountBeforeTax + vat;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }
        public virtual void OnPropertyChanged(string propname)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propname));
        }

    }
}
