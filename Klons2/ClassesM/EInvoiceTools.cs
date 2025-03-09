using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.UnqualifiedDataTypes;
using KlonsF.Classes;
using KlonsF.DataSets;
using KlonsLIB.Misc;

namespace KlonsM.Classes;

public static class EInvoiceTools
{
    public static KlonsMDataSet.M_STORESRow GetPartnerType(KlonsMDataSet.M_DOCSRow dr_doc)
    {
        if (dr_doc.XStoreInType == KlonsM.Classes.EStoreType.Partneris)
            return dr_doc.M_STORESRowByFK_M_DOCS_IDSTOREIN1;
        else
            return dr_doc.M_STORESRowByFK_M_DOCS_IDSTOREOUT1;
    }

    public static InvoiceType ToEInvoice(KlonsMDataSet.M_DOCSRow dr_doc, bool includeallowance)
    {
        bool is_vat_payer = !string.IsNullOrWhiteSpace(MyCompanyData.CompRegNrPVN);
        var partner = GetPartnerType(dr_doc);

        InvoiceType topInvoice = new InvoiceType();
        topInvoice.Xmlns = new XmlSerializerNamespaces(new XmlQualifiedName[]
        {
            new XmlQualifiedName("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            new XmlQualifiedName("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")
        });

        topInvoice.ID = $"{dr_doc.SR} {dr_doc.NR}".Trim().Zn(); ;
        topInvoice.CustomizationID = "urn:cen.eu:en16931:2017#compliant#urn:fdc:peppol.eu:2017:poacc:billing:3.0";
        topInvoice.ProfileID = "urn:fdc:peppol.eu:2017:poacc:billing:01:1.0";
        topInvoice.IssueDate = new DateType()
        {
            Value = dr_doc.DT
        };
        topInvoice.DueDate = new DateType()
        {
            Value = dr_doc.IsDUEDATENull() ? DateTime.Today : dr_doc.DUEDATE
        };
        topInvoice.InvoiceTypeCode = new CodeType()
        {
            Value = "380"
        };
        topInvoice.BuyerReference = partner.REGNR;
        topInvoice.DocumentCurrencyCode = new CodeType()
        {
            Value = "EUR"
        };

        topInvoice.Note = null;

        topInvoice.AccountingSupplierParty = MakeSupplierParty();
        topInvoice.AccountingCustomerParty = MakeCustomerParty();
        topInvoice.PaymentMeans = MakePaymentMeans();
        topInvoice.PaymentTerms = MakePaymentTerms();
        List<VatCategory> vatCategories = new List<VatCategory>();
        topInvoice.InvoiceLine = MakeInvoiceLineList(includeallowance);
        topInvoice.TaxTotal = [MakeTaxTotal()];
        topInvoice.LegalMonetaryTotal = MakeMonetaryTotal();


        SupplierPartyType MakeSupplierParty()
        {
            SupplierPartyType supplierParty = new SupplierPartyType();
            PartyType party = new PartyType();
            party.EndpointID = new IdentifierType()
            {
                schemeID = "9939",
                Value =
                    MyCompanyData.CompRegNrPVN.Zn() ??
                    (MyCompanyData.CompRegNr.IsNOE() ? "" : "LV" + MyCompanyData.CompRegNr) ??
                    ""
            };

            party.PartyIdentification = new List<PartyIdentificationType>()
			{
				new PartyIdentificationType()
				{
					ID = MyCompanyData.CompRegNr
				}
			};

            AddressType postalAddress = null;
            if (!MyCompanyData.CompAddrStreet.IsNOE())
            {
                postalAddress = new AddressType()
                {
                    StreetName = MyCompanyData.CompAddrStreet,
                    CityName = MyCompanyData.CompAddrCity,
                    PostalZone = MyCompanyData.CompAddrInd,
                    CountrySubentity = MyCompanyData.CompAddrState,
                    Country = new CountryType
                    {
                        IdentificationCode = "LV"
                    }
                };
            }
            party.PostalAddress = postalAddress;

            party.PartyName = new List<PartyNameType>()
			{
				new PartyNameType()
				{
					Name = MyCompanyData.CompName
				}
			};
            party.PartyLegalEntity = new List<PartyLegalEntityType>()
			{
				new()
				{
					CompanyID = MyCompanyData.CompRegNr,
					RegistrationName = MyCompanyData.CompName
				}
			};
            List<PartyTaxSchemeType> partyTaxScheme = null;
            if (is_vat_payer)
            {
                partyTaxScheme = [
                    new PartyTaxSchemeType()
                {
                    CompanyID = MyCompanyData.CompRegNrPVN,
                    TaxScheme = new TaxSchemeType() { ID = "VAT" }
                }];
            }
            party.PartyTaxScheme = partyTaxScheme;
            supplierParty.Party = party;

            return supplierParty;
        }

        CustomerPartyType MakeCustomerParty()
        {
            CustomerPartyType customerParty = new CustomerPartyType();
            PartyType party = new PartyType();

            var partner_EndpointID = partner.PVNREGNR.Zn();
            partner_EndpointID ??= (partner.IsIDCOUNTRYNull() ? "" :
                partner.M_COUNTRIESRow.CODE2.Nz()) + partner.REGNR.Nz();
            partner_EndpointID = partner_EndpointID.Nz().Replace("-", "");

            party.EndpointID = new IdentifierType()
            {
                schemeID = "9939",
                Value = partner_EndpointID
            };
            party.PartyIdentification = new List<PartyIdentificationType>()
			{
				new PartyIdentificationType()
				{
					ID = partner.REGNR.Nz()
				}
			};

            AddressType postalAddress = null;
            if (!partner.STREET.IsNOE())
            {
                postalAddress = new()
                {
                    StreetName = partner.STREET,
                    CityName = partner.CITY,
                    PostalZone = partner.POSTALCODE,
                    CountrySubentity = partner.STATE,
                    Country = new CountryType()
                    {
                        IdentificationCode = partner.IsIDCOUNTRYNull() ? "" : partner.M_COUNTRIESRow.CODE2.Nz()
                    }
                };
            }

            party.PostalAddress = postalAddress;
            party.PartyName = [new() { Name = partner.NAME }];
            party.PartyLegalEntity = [new PartyLegalEntityType()
			{
				CompanyID = partner.REGNR,
				RegistrationName = partner.NAME
			}];
            List<PartyTaxSchemeType> partyTaxScheme = null;
            if (!partner.PVNREGNR.IsNOE())
            {
                partyTaxScheme = [new PartyTaxSchemeType
				{
					CompanyID = partner.PVNREGNR,
					TaxScheme = new TaxSchemeType { ID = "VAT" }
				}];
            }

            party.PartyTaxScheme = partyTaxScheme;
            customerParty.Party = party;
            return customerParty;
        }

        List<PaymentMeansType> MakePaymentMeans()
        {
            List<PaymentMeansType> listpaymentmeans = new List<PaymentMeansType>();
            PaymentMeansType paymentMeans = new PaymentMeansType();
            paymentMeans.PaymentMeansCode = new CodeType()
            {
                Value = "96"
            };
            FinancialAccountType payeeFinancialAccount = null;
            if (!MyCompanyData.BankAcc.IsNOE())
            {
                payeeFinancialAccount = new FinancialAccountType()
                {
                    ID = MyCompanyData.BankAcc
                };
            }
            paymentMeans.PayeeFinancialAccount = payeeFinancialAccount;
            FinancialAccountType payerFinancialAccount = null;
            var partner_bankacc = partner.GetM_BANKACCOUNTSRows().FirstOrDefault();
            if (partner_bankacc != null && !partner_bankacc.ACCOUNT.IsNOE())
            {
                payerFinancialAccount = new FinancialAccountType()
                {
                    ID = partner_bankacc.ACCOUNT
                };
            }
            paymentMeans.PayerFinancialAccount = payerFinancialAccount;
            listpaymentmeans.Add(paymentMeans);
            return listpaymentmeans;
        }

        List<PaymentTermsType> MakePaymentTerms()
        {
            List<PaymentTermsType> paymentTerms = null;
            if (!dr_doc.IsIDPAYMENTTYPENull())
            {
                paymentTerms = new List<PaymentTermsType>()
            {
                new PaymentTermsType
                {
                    Note = new List<TextType>
                    {
                        new TextType
                        {
                            Value = dr_doc.M_PAYMENTTYPERow.NAME
                        }
                    }
                }
            };
            }
            return paymentTerms;
        }

        List<InvoiceLineType> MakeInvoiceLineList(bool includeallowance)
        {
            List<InvoiceLineType> invoiceLineList = new List<InvoiceLineType>();

            foreach (var line in dr_doc.GetM_ROWSRows())
            {
                var dr_item = line.M_ITEMSRow;
                string currentVatCategory = GetVATCategeoryId(line, is_vat_payer);
                InvoiceLineType invoiceLine = new InvoiceLineType();

                invoiceLine.ID = line.ID.ToString();
                invoiceLine.Item = MakeItem();
                invoiceLine.Item.ClassifiedTaxCategory = [MakeItemTaxCategory()];
                invoiceLine.InvoicedQuantity = MakeQuantity();
                invoiceLine.Price = MakePrice();
                if (includeallowance)
                    invoiceLine.AllowanceCharge = MakeAllowanceCharge();
                invoiceLine.LineExtensionAmount = MakeAmount();
                MakeVatCategories();

                ItemType MakeItem()
                {
                    ItemType item = new ItemType();
                    item.Name = dr_item.NAME;
                    item.SellersItemIdentification = new ItemIdentificationType()
                    {
                        ID = dr_item.BARCODE,
                        //BarcodeSymbologyID = dr_item.BARCODE
                    };
                    return item;
                }

                TaxCategoryType MakeItemTaxCategory()
                {
                    TaxCategoryType taxCategory = new()
                    {
                        ID = currentVatCategory
                    };
                    PercentType percent = null;
                    if (!(currentVatCategory == "O"))
                    {
                        percent = new PercentType()
                        {
                            Value = line.M_PVNRATESRow.RATE
                        };
                    }
                    taxCategory.Percent = percent;
                    taxCategory.TaxScheme = new TaxSchemeType
                    {
                        ID = "VAT"
                    };
                    return taxCategory;
                }

                QuantityType MakeQuantity()
                {
                    var InvoicedQuantity = new QuantityType
                    {
                        unitCode = line.M_UNITSRow.CODE2,
                        Value = line.AMOUNT
                    };
                    return InvoicedQuantity;
                }

                PriceType MakePrice()
                {
                    var price = new PriceType
                    {
                        PriceAmount = new AmountType
                        {
                            currencyID = "EUR",
                            Value = includeallowance ? line.PRICE0 : line.PRICE
                        }
                    };
                    return price;
                }

                AmountType MakeAmount()
                {
                    var lineExtensionAmount = new AmountType()
                    {
                        currencyID = "EUR",
                        Value = Math.Round(line.TPRICE, 2)
                    };
                    return lineExtensionAmount;
                }

                List<AllowanceChargeType> MakeAllowanceCharge()
                {
                    if (line.DISCOUNT == 0f) return null;

                    var allowanceChargeList = new List<AllowanceChargeType>();
                    AllowanceChargeType allowanceCharge = new AllowanceChargeType();
                    allowanceCharge.AllowanceChargeReasonCode = new CodeType()
                    {
                        Value = "95"
                    };
                    allowanceCharge.ChargeIndicator = line.DISCOUNT > 0f;
                    allowanceCharge.BaseAmount = new AmountType()
                    {
                        currencyID = "EUR",
                        Value = Math.Round(line.AMOUNT * line.PRICE0, 2)
                    };
                    allowanceCharge.MultiplierFactorNumeric = (decimal)Math.Abs(line.DISCOUNT);
                    allowanceCharge.Amount = new AmountType
                    {
                        currencyID = "EUR",
                        Value = Math.Abs(Math.Round(line.TPRICE, 2) - Math.Round(line.AMOUNT * line.PRICE0, 2))
                    };
                    allowanceChargeList.Add(allowanceCharge);

                    return allowanceChargeList;
                }

                void MakeVatCategories()
                {
                    VatCategory vatItem = vatCategories.FirstOrDefault(x =>
                        x.Rate == line.M_PVNRATESRow.RATE && x.Category == currentVatCategory);
                    if (vatItem == null)
                    {
                        vatItem = new VatCategory
                        {
                            Rate = currentVatCategory == "S" ? line.M_PVNRATESRow.RATE : 0M,
                            Category = currentVatCategory
                        };
                        vatCategories.Add(vatItem);
                    }
                    vatItem.Base += line.TPRICE;
                }

                invoiceLineList.Add(invoiceLine);
            }
            return invoiceLineList;
        }

        TaxTotalType MakeTaxTotal()
        {
            TaxTotalType taxTotal = new TaxTotalType();
            taxTotal.TaxAmount = new AmountType()
            {
                currencyID = "EUR",
                Value = vatCategories.Sum(x => Math.Round(x.VAT, 2))
            };
            taxTotal.TaxSubtotal = vatCategories
                .Select(MakeTaxSubtotal)
                .ToList();

            return taxTotal;
        }

        TaxSubtotalType MakeTaxSubtotal(VatCategory vatitem)
        {
            TaxSubtotalType taxSubtotal = new TaxSubtotalType();
            taxSubtotal.TaxableAmount = new AmountType
            {
                currencyID = "EUR",
                Value = Math.Round(vatitem.Base, 2)
            };
            taxSubtotal.TaxAmount = new AmountType
            {
                currencyID = "EUR",
                Value = vatitem.VAT
            };
            TaxCategoryType taxCategory = new TaxCategoryType();
            List<TextType> taxExemptionReason = null;
            if (vatitem.Category == "E" || vatitem.Category == "O" || vatitem.Category == "AE")
            {
                taxExemptionReason = [new(){
                Value = ((vatitem.Category == "E" || vatitem.Category == "O") ? "Nav apliekams" : "Reverss")}];
            }
            taxCategory.TaxExemptionReason = taxExemptionReason;
            taxCategory.ID = vatitem.Category;
            taxCategory.Percent = null;
            if (vatitem.Category != "O")
            {
                (taxCategory.Percent = new PercentType()).Value = vatitem.Rate;
            }
            taxCategory.TaxScheme = new TaxSchemeType
            {
                ID = "VAT"
            };
            taxSubtotal.TaxCategory = taxCategory;
            return taxSubtotal;
        }

        MonetaryTotalType MakeMonetaryTotal()
        {
            MonetaryTotalType monetaryTotal = new MonetaryTotalType();

            decimal lineExtensionAmount = topInvoice.InvoiceLine.Sum(x =>
                x.LineExtensionAmount == null ? 0M : x.LineExtensionAmount.Value
            );

            monetaryTotal.LineExtensionAmount = new AmountType()
            {
                currencyID = "EUR",
                Value = lineExtensionAmount
            };
            decimal doctotalamount = dr_doc.SUMM;
            decimal totalvatamount = topInvoice?.TaxTotal?.FirstOrDefault()?.TaxAmount?.Value ?? 0M;
            decimal taxExclusiveAmount = Math.Round(doctotalamount - totalvatamount, 2);
            monetaryTotal.TaxExclusiveAmount = new AmountType()
            {
                currencyID = "EUR",
                Value = taxExclusiveAmount
            };
            monetaryTotal.TaxInclusiveAmount = new AmountType()
            {
                currencyID = "EUR",
                Value = Math.Round(dr_doc.SUMM, 2)
            };
            /*monetaryTotal.PrepaidAmount = new AmountType
            {
                currencyID = "EUR",
                Value = Math.Round(dr_doc.PREPAID.GetValueOrDefault(), 2)
            };*/
            monetaryTotal.PayableAmount = new AmountType
            {
                currencyID = "EUR",
                Value = Math.Round(dr_doc.SUMM, 2)
            };
            return monetaryTotal;
        }

        return topInvoice;
    }

    public static string GetXML(InvoiceType invoice)
    {
        return invoice.ToXDocument().ToString();
    }


    public static string GetVATCategeoryId(KlonsMDataSet.M_ROWSRow dr_row, bool isvatpayer)
    {
        if (!isvatpayer) return "O";
        var dr_pvnrate = dr_row.M_PVNRATESRow;
        if (dr_pvnrate.ISREVERSE == 1) return "AE";
        if (dr_pvnrate.RATE == 0m) return "Z";
        return "S";
    }


    public class VatCategory
    {
        public string Category { get; set; }
        public decimal Base { get; set; }
        public decimal Rate { get; set; }
        public decimal VAT => Math.Round(Base * Rate / 100M, 2);
        public decimal Total => Base + (Category == "S" ? VAT : 0M);

    }

}
