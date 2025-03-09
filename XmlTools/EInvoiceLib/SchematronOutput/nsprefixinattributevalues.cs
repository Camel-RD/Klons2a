using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("ns-prefix-in-attribute-values", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class nsprefixinattributevalues
	{
		[XmlAttribute(DataType = "NMTOKEN")]
		public string prefix { get; set; }

		[XmlAttribute]
		public string uri { get; set; }

		public nsprefixinattributevalues()
		{
		}
	}
}
