using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Adapter.Abstract;

namespace DesignPatterns.StructuralPatterns.Adapter.AdapterAndAdaptee
{
    //Adapter
    public class ObjectToJsonConverterAdapter : IXmlToJson
    {
        private readonly ObjectToJsonConverter _converter;

        public ObjectToJsonConverterAdapter(ObjectToJsonConverter converter)
        {
            _converter = converter;
        }
        public string ConvertXmlToJson(string xml="")
        {
            return _converter.ConvertObjectToJson();
        }
    }
}
