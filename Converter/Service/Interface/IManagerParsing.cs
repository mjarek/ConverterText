using Converter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Service.Interface
{
   public interface IManagerParsing
    {
        IConverter CreateConverter(InputData data);
     

    }
}
