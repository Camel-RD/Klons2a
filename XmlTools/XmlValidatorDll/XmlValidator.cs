using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XmlValidatorDll
{
    public class XmlValidator
    {
        [DllExport]
        public static IntPtr TransformXmlDocumentToFile(ref IntPtr xml, ref IntPtr xsl_filename, ref IntPtr result_filename)
        {
            var man_xml = Marshal.PtrToStringUni(xml);
            var man_xsl_filename = Marshal.PtrToStringUni(xsl_filename);
            var man_result_filename = Marshal.PtrToStringUni(result_filename);
            var ret = TransformXmlDocumentToFileA(man_xml, man_xsl_filename, man_result_filename);
            var ptr_ret = Marshal.StringToCoTaskMemUni(ret);
            return ptr_ret;
        }

        [DllExport]
        public static IntPtr TransformXmlDocumentToString(ref IntPtr xml, ref IntPtr xsl_filename, ref IntPtr result)
        {
            var man_xml = Marshal.PtrToStringUni(xml);
            var man_xsl_filename = Marshal.PtrToStringUni(xsl_filename);
            string man_result = "";
            var ret = TransformXmlDocumentToStringA(man_xml, man_xsl_filename, ref man_result);
            var ptr_ret = Marshal.StringToCoTaskMemUni(ret);
            result = Marshal.StringToCoTaskMemUni(man_result);
            return ptr_ret;
        }

        [DllExport]
        public static void FreeString(ref IntPtr ptr)
        {
            Marshal.FreeCoTaskMem(ptr);
            return;
        }

        public static string TransformXmlDocumentToFileA(string xml, string xsl_filename, string result_filename)
        {
            try
            {
                XmlTools.SaxonValidator.TransformXmlDocumentToFile(xml, xsl_filename, result_filename);
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string TransformXmlDocumentToStringA(string xml, string xsl_filename, ref string result)
        {
            try
            {
                result = XmlTools.SaxonValidator.TransformXmlDocumentToString(xml, xsl_filename);
                return "Ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
