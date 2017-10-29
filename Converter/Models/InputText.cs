using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Converter.Models.TypeFile;

namespace Converter.Models
{
    public class InputText
    {
       // public string Label = Converter.Properties.Resource.LabelForStartedForm;
        public TypeFiles ExpectedType { get; set; }
        public string MyText;
    }
}