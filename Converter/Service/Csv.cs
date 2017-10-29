using Converter.Models;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Service
{
    public class Csv :IConverter
    {
        private InputData _data;
        public Csv(InputData data)
        {
            _data = data;
        }

        public string Parse()
        {
            return _data.MyText;
        }
    }
}