using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using DesignPatterns.StructuralPatterns.Adapter.Abstract;
using DesignPatterns.StructuralPatterns.Adapter.AdapterAndAdaptee;
using DesignPatterns.StructuralPatterns.Adapter.Concrete;
using DesignPatterns.StructuralPatterns.Adapter.Extensions;
using DesignPatterns.StructuralPatterns.Adapter.Product;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class UsageOfAdapter
    {
        public static void Run()
        {
            //Data
            PersonInfo _personInfo = new PersonInfo()
            {
                PersonId = 1,
                Name = "Caner",
                Gender = "E",
                Age = 99
            };
            string personInfoXml = _personInfo.ConvertObjectToXmlExtension();


            //Xml to json convert
            IXmlToJson xmlToJson = new XmlToJsonConverter();
            string personInfoJsonConverted = xmlToJson.ConvertXmlToJson(personInfoXml);

            //Object to json convert
            IXmlToJson xmlToJson_ObjectType = new ObjectToJsonConverterAdapter(new ObjectToJsonConverter(_personInfo));
            string personInfoJsonConverted_ObjectType = xmlToJson_ObjectType.ConvertXmlToJson(null);


        }

    }


}
