using Converter.Models;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace Converter.Service
{
    public class ManagerParsing
    {
        private InputData _text;
        private Dictionary<string,Type> _converters;
        public ManagerParsing(InputData text)
        {
            _text = text;
            LoadConverters();
        }

        private void LoadConverters()
        {
            _converters = new Dictionary<string, Type>();
            Type[] typesAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var item in typesAssembly)
            {
                if (item.GetInterface(typeof(IConverter).ToString()) != null)
                {
                    _converters.Add(item.Name, item);
                }
            }
        }

        public IConverter CreateConverter(string name, InputData data)
        {
            Type type = _converters.Where(x => x.Key.ToString() == name).Select(x => x.Value).FirstOrDefault();

            if (type != null)
            {
                return Activator.CreateInstance(type, data) as IConverter;
            }

            throw new ArgumentException();
        }

        
    }
}