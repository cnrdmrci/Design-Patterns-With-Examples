using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace DesignPatterns.StructuralPatterns.Adapter.Extensions
{
    public static class SerializerExtensions
    {
        public static string ConvertObjectToXmlExtension<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value,ns);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public static string ConvertXmlToJsonExtension(this string xml)
        {
            if (xml == null)
                return string.Empty;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                doc.RemoveChild(doc.FirstChild);
                string jsonText = JsonConvert.SerializeXmlNode(doc,Formatting.None,true);
                return jsonText;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public static string ConvertObjectToJsonExtension(this object obj)
        {
            if (obj == null)
                return string.Empty;
            try
            {
                string jsonValue = JsonConvert.SerializeObject(obj);

                jsonValue = Regex.Replace(jsonValue, "((:)(?!\"))", ":\"");
                jsonValue = Regex.Replace(jsonValue, "(?<!\")(,)", "\",");

                return jsonValue;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
