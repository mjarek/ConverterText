﻿using Converter.Models;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Converter.Service.WorkWithText;

namespace Converter.Service
{
    public class Xml :IConverter
    {

        private InputData _data;
        private List<Phrase> _phrases;
        public Xml(InputData data)
        {
            _data = data;
           
            _phrases = Splitter(_data.MyText);
        }

        public string Parse()
        {
            return _data.MyText;
        }
    }
}