using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Converter.Models
{
    public class Phrase
    {
         public SortedList<string,string> ComponentOfPhrase { get; set; }
         public static readonly  char[] DelimeterPhrase = new char[] { '?', '.','!' };
         public static readonly char[] DelimeterWord = new char[] { ' ' };
        
    }
}