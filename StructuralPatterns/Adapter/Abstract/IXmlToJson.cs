using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter.Abstract
{
    public interface IXmlToJson
    {
        string ConvertXmlToJson(string xml);
    }
}
