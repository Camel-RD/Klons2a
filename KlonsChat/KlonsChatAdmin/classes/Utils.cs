using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KlonsChatAdmin.classes
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
            T data = LoadDataFromXML<T>(filename);
            if (data != null) return data;
            return new T();
        }

        public static T LoadDataFromXML<T>(string filename) where T : new()
        {
            T data = default;
            if (!File.Exists(filename)) return data;
            XmlSerializer xs = null;
            FileStream fs = null;
            try
            {
                xs = Utils.CreateDefaultXmlSerializer(typeof(T));
                fs = new FileStream(filename, FileMode.Open);
                data = (T)xs.Deserialize(fs);
                return data;
            }
            catch (Exception)
            {
                return default;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public static bool SaveDataToXML<T>(T data, string filename)
        {
            XmlSerializer xs = Utils.CreateDefaultXmlSerializer(typeof(T));
            TextWriter wr = null;
            try
            {
                wr = new StreamWriter(filename);
                xs.Serialize(wr, data);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (wr != null) wr.Close();
            }
            return true;
        }

    }
}
