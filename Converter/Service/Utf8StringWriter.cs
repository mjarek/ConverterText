using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Converter.Service
{
    public class Utf8StringWriter : StringWriter
    {

        public override Encoding Encoding
        {
            get { return new UTF8Encoding(false); }
        }
    }
}