using Converter.Models;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using static Converter.Service.WorkWithText;
using Converter.Properties;
using System.Xml;
using System.IO;

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

        public string GetContentType()
        {
            return "text/xml";
        }

        public string Parse()
        {
           string result= CreateXml();
            return result;
        }

        private string CreateXml()
        {
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmltextWriter = new XmlTextWriter(stringWriter) { Formatting = Formatting.Indented };

           
            xmltextWriter.WriteStartDocument();
            xmltextWriter.WriteStartElement("text");

            foreach (var item in _phrases) { 
            
               xmltextWriter.WriteStartElement("sentence");
                foreach (var word in item.ComponentOfPhrase)
                {
                   xmltextWriter.WriteElementString("word", word.Value);
                }
              
                xmltextWriter.WriteEndElement();
            }


          
            xmltextWriter.WriteEndElement();
            var result = stringWriter.ToString();
            xmltextWriter.Flush();
            xmltextWriter.Close();
            stringWriter.Flush();
            return result;

        }
    }
}