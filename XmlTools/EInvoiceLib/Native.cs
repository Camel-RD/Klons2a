using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EInvoiceLib
{
    public static class Native
    {
        public static string TransformXmlDocumentToFile(string xml, string xsl_filename, string result_filename)
        {
            var ptr_xml = Marshal.StringToCoTaskMemUni(xml);
            var ptr_xsl_filename = Marshal.StringToCoTaskMemUni(xsl_filename);
            var ptr_result_filename = Marshal.StringToCoTaskMemUni(result_filename);
            IntPtr ptr_ret = IntPtr.Zero;
            try
            {
                ptr_ret = TransformXmlDocumentToFile(ref ptr_xml, ref ptr_xsl_filename, ref ptr_result_filename);
                var man_ret = Marshal.PtrToStringUni(ptr_ret);
                return man_ret;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr_xml);
                Marshal.FreeCoTaskMem(ptr_xsl_filename);
                Marshal.FreeCoTaskMem(ptr_result_filename);
                FreeString(ref ptr_ret);
            }
        }

        public static string TransformXmlDocumentToString(string xml, string xsl_filename, ref string result)
        {
            var ptr_xml = Marshal.StringToCoTaskMemUni(xml);
            var ptr_xsl_filename = Marshal.StringToCoTaskMemUni(xsl_filename);
            IntPtr ptr_result = IntPtr.Zero;
            IntPtr ptr_ret = IntPtr.Zero;

            try
            {
                ptr_ret = TransformXmlDocumentToString(ref ptr_xml, ref ptr_xsl_filename, ref ptr_result);
                result = Marshal.PtrToStringUni(ptr_result);
                var man_ret = Marshal.PtrToStringUni(ptr_ret);
                return man_ret;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                Marshal.FreeCoTaskMem(ptr_xml);
                Marshal.FreeCoTaskMem(ptr_xsl_filename);
                FreeString(ref ptr_result);
                FreeString(ref ptr_ret);
            }
        }


        [DllImport("XmlValidatorDll.dll")]
        private static extern IntPtr TransformXmlDocumentToFile(ref IntPtr xml, ref IntPtr xsl_filename, ref IntPtr result_filename);

        [DllImport("XmlValidatorDll.dll")]
        private static extern IntPtr TransformXmlDocumentToString(ref IntPtr xml, ref IntPtr xsl_filename, ref IntPtr result);

        [DllImport("XmlValidatorDll.dll")]
        private static extern void FreeString(ref IntPtr ptr);

    }
}
