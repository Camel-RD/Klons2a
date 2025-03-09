using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace EInvoiceLib
{
    public class XmlDocumentValidationError
    {
        public string Message { get; private set; }
        public string Code { get; private set; }
        public XmlSeverityType Severity { get; private set; }

        public XmlDocumentValidationError(string Message, XmlSeverityType Severity, string Code)
        {
            this.Message = Message;
            this.Severity = Severity;
            this.Code = Code;
        }

        public string FormatError()
        {
            var severity = Severity == XmlSeverityType.Error ? "Kļūda" : "Brīdinājums";
            return $"{severity}\r\n{Message}";
        }
    }

}
