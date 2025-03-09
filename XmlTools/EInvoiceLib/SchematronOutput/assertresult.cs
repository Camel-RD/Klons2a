using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	public class assertresult
	{
		[XmlElement("diagnostic-reference")]
		public diagnosticreference[] diagnosticreference { get; set; }

		[XmlElement("property-reference")]
		public propertyreference[] propertyreference { get; set; }

		public text text { get; set; }

		[XmlAttribute(DataType = "ID")]
		public string id { get; set; }

		[XmlAttribute]
		public string location { get; set; }

		[XmlAttribute]
		public string test { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string role { get; set; }

		[XmlAttribute(DataType = "NMTOKEN")]
		public string flag { get; set; }

		public assertresult()
		{
		}

	}
}
