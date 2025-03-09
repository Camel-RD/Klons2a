using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("diagnostic-reference", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class diagnosticreference
	{
		public text text { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string diagnostic { get; set; }

		public diagnosticreference()
		{
		}
	}
}
