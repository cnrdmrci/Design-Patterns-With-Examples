using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using DesignPatterns.StructuralPatterns.Adapter.Abstract;
using DesignPatterns.StructuralPatterns.Adapter.Extensions;
using Newtonsoft.Json;

namespace DesignPatterns.StructuralPatterns.Adapter.Concrete
{
    public class XmlToJsonConverter : IXmlToJson
    {
        public string ConvertXmlToJson(string xml)
        {
            return xml.ConvertXmlToJsonExtension();
        }
    }
}
