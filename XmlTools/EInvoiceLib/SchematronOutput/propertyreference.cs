using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("property-reference", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class propertyreference
	{
		public text text { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string property { get; set; }

		[XmlAttribute]
		public string role { get; set; }

		[XmlAttribute]
		public string scheme { get; set; }

		public propertyreference()
		{
		}
	}
}
