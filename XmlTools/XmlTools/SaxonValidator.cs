using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using net.sf.saxon.ma.trie;
using net.sf.saxon.pattern;
using Saxon.Api;

namespace XmlTools
{
    public static class SaxonValidator
    {
        static Processor Processor = new Processor();
        static Dictionary<string, XsltTransformer> CachedTransformers = new Dictionary<string, XsltTransformer>();

        static SaxonValidator()
        {
            Processor.SetProperty("http://saxon.sf.net/feature/preferJaxpParser", "true");
        }

        public static void TransformXmlDocumentToFile(string xml, string xsl_filename, string result_filename)
        {
            var result = TransformXmlDocumentToString(xml, xsl_filename);
            File.WriteAllText(result_filename, result);
        }

        public static string TransformXmlDocumentToString(string xml, string xsl_filename)
        {
            if (!CachedTransformers.TryGetValue(xsl_filename, out var xslttransformer))
            {
                xslttransformer = CreateTransformer(xsl_filename);
                CachedTransformers[xsl_filename] = xslttransformer;
            }
            string result;
            TransformToString(xslttransformer, xml, out result);
            return result;
        }

        public static XsltTransformer CreateTransformer(string xsl_filename)
        {
            XsltTransformer xsltTransformer;
            using (var sr1 = File.OpenRead(xsl_filename))
            {
                xsltTransformer = Processor.NewXsltCompiler().Compile(sr1).Load();
            }
            return xsltTransformer;
        }

        public static void TransformToString(XsltTransformer xslttransformer, string input, out string output)
        {
            XdmNode initialContextNode;
            using (StringReader stringReader = new StringReader(input))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(stringReader))
                {
                    initialContextNode = Processor.NewDocumentBuilder().Build(xmlTextReader);
                }
            }
            xslttransformer.InitialContextNode = initialContextNode;
            Serializer serializer = Processor.NewSerializer();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new StreamWriter(memoryStream))
                {
                    serializer.SetOutputWriter(streamWriter);
                    xslttransformer.Run(serializer);
                    output = Encoding.UTF8.GetString(memoryStream.ToArray());
                }
            }
        }


        public static void TransformToFile(XsltTransformer xslttransformer, string input, string output_filename)
        {
            XdmNode initialContextNode;
            using (StringReader stringReader = new StringReader(input))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(stringReader))
                {
                    initialContextNode = Processor.NewDocumentBuilder().Build(xmlTextReader);
                }
            }
            xslttransformer.InitialContextNode = initialContextNode;
            Serializer serializer = Processor.NewSerializer();
            
            using (var filestream = File.OpenWrite(output_filename))
            {
                using (StreamWriter streamWriter = new StreamWriter(filestream))
                {
                    serializer.SetOutputWriter(streamWriter);
                    xslttransformer.Run(serializer);
                }
            }
        }

    }
}
