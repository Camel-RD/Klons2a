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

        public string DocType { get; set; }
        public string ID { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string PayerFinancialAccountID { get; set; }
        public string PayeeFinancialAccountID { get; set; }
        public string Note { get; set; }
        public string BillingReferenceId { get; set; }
        public DateTime? BillingReferenceIssueDate { get; set; }

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

        public void ReadFrom(InvoiceType invoice)
        {
            DocType = "Rēķins";
            ID = invoice.ID;
            IssueDate = invoice.IssueDate;
            DueDate = invoice.DueDate;
            Note = invoice.Note.Any() ?
                invoice.Note.Select(x => x.Value).Aggregate((x1, x2) => x1 + "; " + x2) :
                null;
            CurrencyCode = invoice.DocumentCurrencyCode.Value;

            BillingReferenceId = invoice.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.ID;
            BillingReferenceIssueDate = invoice.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.IssueDate;
            if (!string.IsNullOrEmpty(BillingReferenceId))
                DocType = "Koriģējošs rēķins";

            PayerFinancialAccountID = invoice.PaymentMeans?.FirstOrDefault()?.PayerFinancialAccount?.ID;
            PayeeFinancialAccountID = invoice.PaymentMeans?.FirstOrDefault()?.PayeeFinancialAccount?.ID;

            SupplierName = invoice.AccountingSupplierParty.Party.PartyName.FirstOrDefault()?.Name;
            SupplierID = invoice.AccountingSupplierParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            SupplierEndpointID = invoice.AccountingSupplierParty.Party.EndpointID.Value;
            var address = invoice.AccountingSupplierParty.Party.PostalAddress;
            SupplierAddress = FormatAddress(address);
            SupplierAddressCountry = address.Country.IdentificationCode;

            CustomerName = invoice.AccountingCustomerParty.Party.PartyName.FirstOrDefault()?.Name;
            CustomerID = invoice.AccountingCustomerParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            CustomerEndpointID = invoice.AccountingCustomerParty.Party.EndpointID.Value;
            address = invoice.AccountingCustomerParty.Party.PostalAddress;
            CustomerAddress = FormatAddress(address);
            CustomerAddressCountry = address.Country.IdentificationCode;

            TotalAmount = invoice.LegalMonetaryTotal.TaxInclusiveAmount.Value;
            TotalAmountBeforeTax = invoice.LegalMonetaryTotal.TaxExclusiveAmount.Value;
            TotalAmountTax = TotalAmount - TotalAmountBeforeTax;
            TotalAmountPayable = invoice.LegalMonetaryTotal.PayableAmount.Value;

            var lines = invoice.InvoiceLine.Select(x => new InvoiceLine(x)).ToList();
            InvoiceLines.Clear();
            foreach (var line in lines)
                InvoiceLines.Add(line);
        }


        public void ReadFrom(CreditNoteType creditnote)
        {
            DocType = "Kredīteēķins";
            ID = creditnote.ID;
            IssueDate = creditnote.IssueDate;
            Note = creditnote.Note.Any() ?
                creditnote.Note.Select(x => x.Value).Aggregate((x1, x2) => x1 + "; " + x2) :
                null;
            CurrencyCode = creditnote.DocumentCurrencyCode.Value;

            BillingReferenceId = creditnote.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.ID;
            BillingReferenceIssueDate = creditnote.BillingReference?.FirstOrDefault()?.InvoiceDocumentReference?.IssueDate;

            PayerFinancialAccountID = creditnote.PaymentMeans?.FirstOrDefault()?.PayerFinancialAccount?.ID;
            PayeeFinancialAccountID = creditnote.PaymentMeans?.FirstOrDefault()?.PayeeFinancialAccount?.ID;

            SupplierName = creditnote.AccountingSupplierParty.Party.PartyName.FirstOrDefault()?.Name;
            SupplierID = creditnote.AccountingSupplierParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            SupplierEndpointID = creditnote.AccountingSupplierParty.Party.EndpointID.Value;
            var address = creditnote.AccountingSupplierParty.Party.PostalAddress;
            SupplierAddress = FormatAddress(address);
            SupplierAddressCountry = address.Country.IdentificationCode;

            CustomerName = creditnote.AccountingCustomerParty.Party.PartyName.FirstOrDefault()?.Name;
            CustomerID = creditnote.AccountingCustomerParty.Party.PartyIdentification.FirstOrDefault()?.ID;
            CustomerEndpointID = creditnote.AccountingCustomerParty.Party.EndpointID.Value;
            address = creditnote.AccountingCustomerParty.Party.PostalAddress;
            CustomerAddress = FormatAddress(address);
            CustomerAddressCountry = address.Country.IdentificationCode;

            TotalAmount = creditnote.LegalMonetaryTotal.TaxInclusiveAmount.Value;
            TotalAmountBeforeTax = creditnote.LegalMonetaryTotal.TaxExclusiveAmount.Value;
            TotalAmountTax = TotalAmount - TotalAmountBeforeTax;
            TotalAmountPayable = creditnote.LegalMonetaryTotal.PayableAmount.Value;

            var lines = creditnote.CreditNoteLine.Select(x => new InvoiceLine(x)).ToList();
            InvoiceLines.Clear();
            foreach (var line in lines)
                InvoiceLines.Add(line);
        }

        public void ReadFrom(InvoiceView invoice)
        {
            DocType = invoice.DocType;
            ID = invoice.ID;
            IssueDate = invoice.IssueDate;
            DueDate = invoice.DueDate;
            Note = invoice.Note;
            CurrencyCode = invoice.CurrencyCode;

            BillingReferenceId = invoice.BillingReferenceId;
            BillingReferenceIssueDate = invoice.BillingReferenceIssueDate;

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
