using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot(Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class text : richtext
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string space { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang { get; set; }

		[XmlAttribute]
		public string see { get; set; }

		[XmlAttribute]
		public string icon { get; set; }
		[XmlAttribute]
		public string fpi { get; set; }

		public text()
		{
		}
	}
}
