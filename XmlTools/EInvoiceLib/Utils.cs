using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace EInvoiceLib
{
    public static class Utils
    {
        private static readonly Dictionary<Type, XmlSerializer> _xmlSerializerCache = new Dictionary<Type, XmlSerializer>();

        public static XmlSerializer CreateDefaultXmlSerializer(Type type)
        {
            XmlSerializer serializer;
            if (_xmlSerializerCache.TryGetValue(type, out serializer))
            {
                return serializer;
            }
            else
            {
                var importer = new XmlReflectionImporter();
                var mapping = importer.ImportTypeMapping(type, null, null);
                serializer = new XmlSerializer(mapping);
                return _xmlSerializerCache[type] = serializer;
            }
        }

        public static T LoadDataFromXMLOrCreateEmpty<T>(string filename) where T : new()
        {
            T data = LoadDataFromXMLFile<T>(filename);
            if (data != null) return data;
            return new T();
        }

        public static T LoadDataFromXMLFile<T>(string filename) where T : new()
        {
            T data = default;
            if (!File.Exists(filename)) return data;
            XmlSerializer xs = null;
            using (var fs = new FileStream(filename, FileMode.Open))
            {
                try
                {
                    xs = Utils.CreateDefaultXmlSerializer(typeof(T));
                    data = (T)xs.Deserialize(fs);
                    return data;
                }
                catch (Exception)
                {
                    return default;
                }
                finally
                {
                    fs?.Close();
                }
            }
        }

        public static T LoadDataFromXMLText<T>(string text) where T : new()
        {
            T data = default;
            byte[] byteArray = Encoding.UTF8.GetBytes(text);
            using (var sr = new StringReader(text))
            {
                XmlSerializer xs = null;
                try
                {

                    xs = Utils.CreateDefaultXmlSerializer(typeof(T));
                    data = (T)xs.Deserialize(sr);
                    return data;
                }
                catch (Exception)
                {
                    return default;
                }
                finally
                {
                }
            }
        }


    }
}
