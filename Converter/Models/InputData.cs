using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static Converter.Models.TypeConverter;

namespace Converter.Models
{
    public class InputData
    {
       // public string Label = Converter.Properties.Resource.LabelForStartedForm;
        public TypeConverters ExpectedType { get; set; }

        [DataType(DataType.MultilineText)]
        public string MyText { get; set; }
    }
}