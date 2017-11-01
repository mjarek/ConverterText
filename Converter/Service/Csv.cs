using Converter.Models;
using Converter.Properties;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using static Converter.Service.WorkWithText;

namespace Converter.Service
{
    public class Csv :IConverter
    {
        private InputData _data;
        private List<Phrase> _phrases;
        public Csv(InputData data)
        {
            _data = data;

            _phrases = Splitter(_data.MyText);
        }

       

        public string Parse()
        {
            var result = new StringBuilder();
            result.Append(GetColumnName());
            result.Append(GetRows());

            return result.ToString();
        }

        private string GetColumnName()
        {
            var result = new StringBuilder(Resource.DelimeterComma);
            var longestPhrase = _phrases.OrderByDescending(x => x.ComponentOfPhrase.Count()).FirstOrDefault();
            int counter = 1;
            foreach (var item in longestPhrase.ComponentOfPhrase)
            {
                result.Append(Resource.TagWord+" ");
                result.Append(counter++.ToString());
                result.Append(Resource.DelimeterComma);
            }
                result.Append(Environment.NewLine);
            return result.ToString();
        }

        private string GetRows()
        {
            var result = new StringBuilder();
            int counter = 1;
                
            foreach (var item in _phrases)
            {
                result.Append(Resource.TagSentence+" ");
                result.Append(counter++.ToString());

               var enumer= item.ComponentOfPhrase.GetEnumerator();
                while (enumer.MoveNext())
                {
                    result.Append(Resource.DelimeterComma);
                    result.Append(" ");
                    result.Append(enumer.Current.Value);
                       
                }
                result.Append(Environment.NewLine);

            }
            return result.ToString();
        }

        public string GetContentType()
        {
            return Resource.ContentRichtext;
        }
    }
}