using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Models
{
    public abstract class ConverterData
    {
        protected InputData _data;
        protected List<Phrase> _phrases;
    }
}