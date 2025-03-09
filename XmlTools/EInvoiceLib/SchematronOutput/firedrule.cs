using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("fired-rule", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class firedrule
	{
		[XmlAttribute(DataType = "ID")]
		public string id { get; set; }

		[XmlAttribute]
		public string name { get; set; }

		[XmlAttribute]
		public string context { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string role { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string flag { get; set; }

		public firedrule()
		{
		}
	}
}
