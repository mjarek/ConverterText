using Converter.Models;
using Converter.Service;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Converter.Controllers
{
    public class ConvertController : Controller
    {
       private  IManagerParsing _managerParsing;

        
        public ConvertController(IManagerParsing managerParsing)
        {
            _managerParsing = managerParsing;
        }
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TryConvert(InputData data)
        {
            var myConverter = _managerParsing.CreateConverter(data);
            return Content(myConverter.Parse(), myConverter.GetContentType());
        }

    }
}