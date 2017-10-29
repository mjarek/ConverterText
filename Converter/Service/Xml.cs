using Converter.Models;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Service
{
    public class Xml :IConverter
    {

        private InputData _data;
        public Xml(InputData data)
        {
            _data = data;
        }

        public string Parse()
        {
            return _data.MyText;
        }
    }
}