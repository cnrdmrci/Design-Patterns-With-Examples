using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Adapter.Extensions;
using Newtonsoft.Json;

namespace DesignPatterns.StructuralPatterns.Adapter.AdapterAndAdaptee
{
    //Adaptee
    public class ObjectToJsonConverter
    {
        private readonly object _object;
        public ObjectToJsonConverter(object obj)
        {
            _object = obj;
        }
        public string ConvertObjectToJson()
        {
            return _object.ConvertObjectToJsonExtension();
        }
    }
}
