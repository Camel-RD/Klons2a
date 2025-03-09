using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(TypeName = "rich-text", Namespace = "http://purl.oclc.org/dsdl/svrl")]
	public class richtext
	{
		[XmlAnyElement]
		[XmlElement("dir", typeof(dir))]
		[XmlElement("emph", typeof(emph))]
		[XmlElement("span", typeof(span))]
		public object[] Items { get; set; }

		[XmlText]
		public string[] Text { get; set; }

		public richtext()
		{
		}
	}
}
