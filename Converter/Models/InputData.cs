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
        [Required(ErrorMessage = "Type is required")]
        public TypeConverters ExpectedType { get; set; }
        [ Required(ErrorMessage = "Text is required")]
        [RegularExpression(@"^[ a-zA-Z]+[ a-zA-Z-_?!., \n|\r|\r\n]*$", ErrorMessage = @"There are some incorect character (e.g. quotation marks)")]

        [DataType(DataType.MultilineText)]
        public string MyText { get; set; }
        
    }
}