using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("failed-assert", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class failedassert : assertresult
    {
		public failedassert()
		{
		}
	}
}
