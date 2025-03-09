using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot("schematron-output", Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class schematronoutput
	{
		[XmlElement("text")]
		public text[] text { get; set; }

		[XmlElement("ns-prefix-in-attribute-values")]
		public nsprefixinattributevalues[] nsprefixinattributevalues { get; set; }

		[XmlElement("active-pattern")]
		public activepattern[] activepattern { get; set; }

		[XmlElement("fired-rule")]
		public firedrule[] firedrule { get; set; }

		[XmlElement("failed-assert", typeof(failedassert))]
		[XmlElement("successful-report", typeof(successfulreport))]
		public assertresult[] Items { get; set; }

		[XmlAttribute]
		public string title { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string phase { get; set; }

		[XmlAttribute]
		public string schemaVersion { get; set; }

		public schematronoutput()
		{
		}
	}
}
