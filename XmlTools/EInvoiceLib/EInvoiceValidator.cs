using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using EInvoiceLib.SchematronOutput;

namespace EInvoiceLib
{
    public class EInvoiceValidator
    {
        public static List<XmlDocumentValidationError> ValidateUbiDocument(string xml_filename,
            string peppol_xsl_filename, string cen_xsl_filename, string result_filename)
        {
            var ret1 = ValidateXmlDocument(xml_filename, peppol_xsl_filename, result_filename);
            var ret2 = ValidateXmlDocument(xml_filename, cen_xsl_filename, result_filename);
            var ret = ret1.Concat(ret2)
                .Where(x => x.Severity == XmlSeverityType.Error)
                .ToList();
            return ret;
        }

        public static List<XmlDocumentValidationError> ValidateUbiDocument2(string xml_filename,
            string peppol_xsl_filename, string cen_xsl_filename)
        {
            var ret1 = ValidateXmlDocument2(xml_filename, peppol_xsl_filename);
            var ret2 = ValidateXmlDocument2(xml_filename, cen_xsl_filename);
            var ret = ret1.Concat(ret2)
                .Where(x => x.Severity == XmlSeverityType.Error)
                .ToList();
            return ret;
        }

        public static List<XmlDocumentValidationError> ValidateXmlDocument(string xml_filename, 
            string xsl_filename, string result_filename)
        {
            var ret = new List<XmlDocumentValidationError>();

            if (!File.Exists(xml_filename))
            {
                ret.Add(new XmlDocumentValidationError($"Fails {xml_filename} nav atrasts.",
                    XmlSeverityType.Error, ""));
                return ret;
            }

            if (!File.Exists(xsl_filename))
            {
                ret.Add(new XmlDocumentValidationError($"Fails {xsl_filename} nav atrasts.", 
                    XmlSeverityType.Error, ""));
                return ret;
            }

            try
            {
                if (File.Exists(result_filename))
                    File.Delete(result_filename);
            }
            catch (Exception)
            {
                ret.Add(new XmlDocumentValidationError($"Neizdevās izdzēst failu {xsl_filename}.",
                    XmlSeverityType.Error, ""));
                return ret;
            }
            
            ret = ValidateXmlDocumentWithDllToFile(xml_filename, xsl_filename, result_filename);
            //ret = ValidateXmlDocumentWithCli(xml_filename, xsl_filename, result_filename);
            return ret;
        }

        public static List<XmlDocumentValidationError> ValidateXmlDocument2(string xml_filename,
            string xsl_filename)
        {
            var ret = new List<XmlDocumentValidationError>();

            if (!File.Exists(xml_filename))
            {
                ret.Add(new XmlDocumentValidationError($"Fails {xml_filename} nav atrasts.",
                    XmlSeverityType.Error, ""));
                return ret;
            }

            if (!File.Exists(xsl_filename))
            {
                ret.Add(new XmlDocumentValidationError($"Fails {xsl_filename} nav atrasts.",
                    XmlSeverityType.Error, ""));
                return ret;
            }

            ret = ValidateXmlDocumentWithDllToString(xml_filename, xsl_filename);
            return ret;
        }

        public static List<XmlDocumentValidationError> ValidateXmlDocumentWithCli(string xml_filename,
            string xsl_filename, string result_filename)
        {
            var ret = new List<XmlDocumentValidationError>();

            var processStartInfo = new ProcessStartInfo()
            {
                Arguments = $"\"{xml_filename}\" \"{xsl_filename}\" \"{result_filename}\"",
                FileName = "XmlValidatorCli.exe",
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            try
            {
                var process = Process.Start(processStartInfo);
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    string err = "Neizdevās veikt e-rēīna pārbaudi.";
                    if (process.ExitCode == 3)
                    {
                        try
                        {
                            var err2 = File.ReadAllText(result_filename);
                            err += "\r\n Kļūda: " + err2;
                        }
                        catch (Exception) { }
                    }
                    ret.Add(new XmlDocumentValidationError(err, XmlSeverityType.Error, ""));
                    return ret;
                }

                var errors = ReadErrorsFromFile(result_filename);
                return errors;

            }
            catch (Exception ex)
            {
                ret.Add(new XmlDocumentValidationError("Pārbaude neizdevās.\r\nKļūda: " +
                    ex.Message, XmlSeverityType.Error, ""));
                return ret;
            }
        }

        public static List<XmlDocumentValidationError> ValidateXmlDocumentWithDllToFile(string xml_filename,
            string xsl_filename, string result_filename)
        {
            var xml = File.ReadAllText(xml_filename);
            var call_ret = Native.TransformXmlDocumentToFile(xml, xsl_filename, result_filename);
            if (call_ret != "Ok")
            {
                var ret = new List<XmlDocumentValidationError>();
                ret.Add(new XmlDocumentValidationError("Pārbaude neizdevās.\r\nKļūda: " +
                    call_ret, XmlSeverityType.Error, ""));
                return ret;
            }

            var errors = ReadErrorsFromFile(result_filename);
            return errors;
        }

        public static List<XmlDocumentValidationError> ValidateXmlDocumentWithDllToString(string xml_filename,
            string xsl_filename)
        {
            string result = null;
            var xml = File.ReadAllText(xml_filename);
            var call_ret = Native.TransformXmlDocumentToString(xml, xsl_filename, ref result);
            if (call_ret != "Ok")
            {
                var ret = new List<XmlDocumentValidationError>();
                ret.Add(new XmlDocumentValidationError("Pārbaude neizdevās.\r\nKļūda: " +
                    call_ret, XmlSeverityType.Error, ""));
                return ret;
            }

            var errors = ReadErrorsFromString(result);
            return errors;
        }

        public static List<XmlDocumentValidationError> ReadErrorsFromFile(string filename)
        {
            try
            {
                var ret = ReadErrorsFromFileA(filename);
                return ret;
            }
            catch(Exception ex)
            {
                var err = new XmlDocumentValidationError($"Neizdevās nolasīt pārbaudes rezultātu failu: {filename}.\r\nKļūda: " +
                    ex.Message, XmlSeverityType.Error, "");
                return new List<XmlDocumentValidationError>() { err };

            }
        }

        public static List<XmlDocumentValidationError> ReadErrorsFromString(string text)
        {
            try
            {
                var ret = ReadErrorsFromStringA(text);
                return ret;
            }
            catch (Exception ex)
            {
                var err = new XmlDocumentValidationError($"Neizdevās nolasīt pārbaudes rezultātus.\r\nKļūda: " +
                    ex.Message, XmlSeverityType.Error, "");
                return new List<XmlDocumentValidationError>() { err };
            }
        }

        public static List<XmlDocumentValidationError> ReadErrorsFromFileA(string filename)
        {
            var schematronoutput = Utils.LoadDataFromXMLFile<schematronoutput>(filename);
            var assertresults = schematronoutput.Items ?? new assertresult[0];
            var ret = assertresults
                .OfType<failedassert>()
                .Select(x => FormatError(x))
                .ToList();
            return ret;
        }

        public static List<XmlDocumentValidationError> ReadErrorsFromStringA(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new List<XmlDocumentValidationError>();
            var schematronoutput = Utils.LoadDataFromXMLText<schematronoutput>(text);
            var assertresults = schematronoutput.Items ?? new assertresult[0];
            var ret = assertresults
                .OfType<failedassert>()
                .Select(x => FormatError(x))
                .ToList();
            return ret;
        }

        static XmlDocumentValidationError FormatError(failedassert fart)
        {
            var texts = fart.text?.Text ?? new string[0];
            var text = string.Join("\r\n", texts);
            var msg = $"{fart.id}; {text}";
            var severity = fart.flag == "fatal" ? XmlSeverityType.Error : XmlSeverityType.Warning;
            var ubierror = new XmlDocumentValidationError(msg, severity, fart.id);
            return ubierror;
        }

    }
}
