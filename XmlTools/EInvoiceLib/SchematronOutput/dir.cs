﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoiceLib.SchematronOutput
{
	[XmlType(AnonymousType = true, Namespace = "http://purl.oclc.org/dsdl/svrl")]
	[XmlRoot(Namespace = "http://purl.oclc.org/dsdl/svrl", IsNullable = false)]
	public class dir
	{
		[XmlAttribute]
		public string @class { get; set; }

		[XmlAttribute("dir")]
		public string dir1 { get; set; }

		[XmlText]
		public string[] Text { get; set; }

		public dir()
		{
		}

	}
}
