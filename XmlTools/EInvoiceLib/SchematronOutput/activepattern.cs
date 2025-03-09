using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("active-pattern", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class activepattern
	{
		[XmlAttribute(DataType = "ID")]
		public string id { get; set; }

		[XmlAttribute]
		public string documents { get; set; }

		[XmlAttribute]
		public string name { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string role { get; set; }

		public activepattern()
		{
		}
	}
}
