using Converter.Models;
using Converter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Converter.Controllers
{
    public class ConvertController : Controller
    {
        // GET: Convert
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TryConvert(InputData text)
        {
            var manager = new ManagerParsing(text);

           var a =  manager.CreateConverter(text.ExpectedType.ToString(), text);


            var words = a.Parse();
           

            ViewBag.Message = words.ToString();
            return View();
        }


    }
}