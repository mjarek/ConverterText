﻿using Converter.Models;
using Converter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace Converter.Service
{
    public static class WorkWithText
    {
        public static SortedList<int,string>SplitTextToSentence(string text)
        {
            var result = new SortedList<int, string>();
            var counter = 0;

            if (!string.IsNullOrEmpty(text))
            {
                foreach (var item in text.Split(Phrase.DelimeterPhrase).ToList())
                {
                    if (!string.IsNullOrWhiteSpace(item)) result.Add(counter++, item);
                }
            }
            return result;

        }

        public static SortedList<string, string> SplitSentenceToWord(string text)
        {
            var result = new SortedList<string, string>();
           
                foreach (var item in text.Split(Phrase.DelimeterWord).ToList())
                {
                    var cleanWord = Regex.Replace(item, Resource.RegexPattern, string.Empty);
                    if (!string.IsNullOrWhiteSpace(cleanWord))result.Add(cleanWord, cleanWord);
                 }
            return result;

        }

        public static List<Phrase> Splitter(string text)
        {
            var result = new List<Phrase>();
            
            foreach (var item in SplitTextToSentence(text))
            {
                var phrase = new Phrase() { ComponentOfPhrase = SplitSentenceToWord(item.Value)};
                result.Add(phrase);
            }

            return result;
        }
    }
}