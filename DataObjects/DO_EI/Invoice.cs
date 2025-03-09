using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using NotyfyProp;

namespace DataObjectsEI
{
    public class Invoice : BindableComponent
    {
        public Invoice()
        {
            this.Note = string.Empty;
            this.CurrencyCode = "EUR";
            this.SupplierAddressCountry = "LV";
            this.CustomerAddressCountry = "LV";
        }

        public string ID { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string PayerFinancialAccountID { get; set; }
        public string PayeeFinancialAccountID { get; set; }
        public string Note { get; set; }
        public string CurrencyCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierAddressCountry { get; set; }
        public string SupplierEndpointID { get; set; }
        public string SupplierID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddressCountry { get; set; }
        public string CustomerEndpointID { get; set; }
        public string CustomerID { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountBeforeTax { get; set; }
        public decimal TotalAmountTax { get; set; }
        public decimal TotalAmountPayable { get; set; }
        public BindingList<InvoiceLine> InvoiceLines { get; private set; } = new();

        public void ReadFrom(InvoiceType invoicetype)
        {
            ID = invoicetype.ID;
            IssueDate = invoicetype.IssueDate;
            DueDate = invoicetype.DueDate;
            Note = invoicetype.Note.Any() ?
                invoicetype.Note.Select(x => x.Value).Aggregate((x1, x2) => x1 + "; " + x2) :
                null;
            CurrencyCode = invoicetype.DocumentCurrencyCode.Value;

            PayerFinancialAccountID = invoicetype.PaymentMeans?.FirstOrDefault()?.PayerFinancialAccount?.ID;
            PayeeFinancialAccountID = invoicetype.PaymentMeans?.FirstOrDefault()?.PayeeFinancialAccount?.ID;

            SupplierName = invoicetype.AccountingSupplierParty.Party.PartyName.FirstOrDefault()?.Name;
            SupplierID = invoicetype.AccountingSupplierParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            SupplierEndpointID = invoicetype.AccountingSupplierParty.Party.EndpointID.Value;
            var address = invoicetype.AccountingSupplierParty.Party.PostalAddress;
            SupplierAddress = FormatAddress(address);
            SupplierAddressCountry = address.Country.IdentificationCode;

            CustomerName = invoicetype.AccountingCustomerParty.Party.PartyName.FirstOrDefault()?.Name;
            CustomerID = invoicetype.AccountingCustomerParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            CustomerEndpointID = invoicetype.AccountingCustomerParty.Party.EndpointID.Value;
            address = invoicetype.AccountingCustomerParty.Party.PostalAddress;
            CustomerAddress = FormatAddress(address);
            CustomerAddressCountry = address.Country.IdentificationCode;

            TotalAmount = invoicetype.LegalMonetaryTotal.TaxInclusiveAmount.Value;
            TotalAmountBeforeTax = invoicetype.LegalMonetaryTotal.TaxExclusiveAmount.Value;
            TotalAmountTax = TotalAmount - TotalAmountBeforeTax;
            TotalAmountPayable = invoicetype.LegalMonetaryTotal.PayableAmount.Value;

            var lines = invoicetype.InvoiceLine.Select(x => new InvoiceLine(x)).ToList();
            InvoiceLines.Clear();
            foreach (var line in lines)
                InvoiceLines.Add(line);
        }


        public void ReadFrom(InvoiceView invoice)
        {
            ID = invoice.ID;
            IssueDate = invoice.IssueDate;
            DueDate = invoice.DueDate;
            Note = invoice.Note;
            CurrencyCode = invoice.CurrencyCode;

            PayerFinancialAccountID = invoice.PayerFinancialAccountID;
            PayeeFinancialAccountID = invoice.PayeeFinancialAccountID;

            SupplierName = invoice.SupplierName;
            SupplierID = invoice.SupplierID;
            SupplierEndpointID = invoice.SupplierEndpointID;
            SupplierAddress = invoice.SupplierAddress;
            SupplierAddressCountry = invoice.SupplierAddressCountry;

            CustomerName = invoice.CustomerName;
            CustomerID = invoice.CustomerID;
            CustomerEndpointID = invoice.CustomerEndpointID;
            CustomerAddress = invoice.CustomerAddress;
            CustomerAddressCountry = invoice.CustomerEndpointID;

            TotalAmount = invoice.TotalAmount;
            TotalAmountBeforeTax = invoice.TotalAmountBeforeTax;
            TotalAmountTax = invoice.TotalAmountTax;
            TotalAmountPayable = invoice.TotalAmountPayable;

            InvoiceLines.Clear();
            foreach (var line in invoice.InvoiceLines)
                InvoiceLines.Add(line);
        }

        string FormatAddress(AddressType address)
        {
            string[] parts = [address.StreetName, address.CityName, address.CountrySubentity, address.PostalZone];
            parts = parts
                .Where(x => !string.IsNullOrEmpty(x))
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();
            var ret = string.Join(", ", parts);
            return ret;
        }
    }
}
