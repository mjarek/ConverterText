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
using System.Xml.Linq;

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
            return Resource.ContentRichtext;
        }

        public string Parse()
        {
           string result= CreateXml();
            return result;
        }

        private string CreateXml()
        {
            StringWriter stringWriter = new Utf8StringWriter();
            XmlTextWriter xmltextWriter = new XmlTextWriter(stringWriter) { Formatting = Formatting.Indented };


            xmltextWriter.WriteStartDocument(true);
            xmltextWriter.WriteStartElement(Resource.StartXmlElement);

            foreach (var item in _phrases) { 
            
               xmltextWriter.WriteStartElement(Resource.TagSentence.ToLower());
                foreach (var word in item.ComponentOfPhrase)
                {
                   xmltextWriter.WriteElementString(Resource.TagWord.ToLower(), word.Value);
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