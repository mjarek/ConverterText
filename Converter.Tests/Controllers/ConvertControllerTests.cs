using Converter.Controllers;
using Converter.Models;
using Converter.Service;
using Converter.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter.Properties;

namespace Converter.Tests.Controllers
{
    [TestClass]
    public class ConvertControllerTests
    {
      private Dictionary<string,string> GetDataToTestXml()
        {
            var result = new Dictionary<string, string>();
                result.Add(ResourceTest.OneSentenceInput, ResourceTest.OneSentenceOutputXml);
                result.Add(ResourceTest.LongTextInput, ResourceTest.LongTextOutputXml);

            return result;
        }

        private Dictionary<string, string> GetDataToTestCsv()
        {
            var result = new Dictionary<string, string>();
            result.Add(ResourceTest.OneSentenceInput, ResourceTest.OneSentenceOutputCsv);
            result.Add(ResourceTest.LongTextInput, ResourceTest.LongTextOutputCsv);

            return result;
        }

        [TestMethod]
        public void TryConvertCSV()
        {
            var testData = GetDataToTestCsv();

            foreach (var item in testData)
            {
                var expected = new ContentResult
                {
                    Content = item.Value,
                    ContentType = Resource.ContentRichtext
                };
                var data = new InputData
                {
                    ExpectedType = TypeConverter.TypeConverters.Csv,
                    MyText = item.Key
                };
                var manager = new ManagerParsing();
                var controller = new ConvertController(manager);
                var result = controller.TryConvert(data) as ContentResult;
                Assert.AreEqual(expected.Content, result.Content);
                Assert.AreEqual(expected.ContentType, result.ContentType);
            }
        }

        [TestMethod]
        public void TryConvertXML()
        {
            var testData = GetDataToTestXml();

            foreach (var item in testData)
            {
                var expected = new ContentResult
                    {
                        Content = item.Value,
                        ContentType = Resource.ContentRichtext
                    };
                    var input = new InputData
                    {
                        ExpectedType = TypeConverter.TypeConverters.Xml,
                        MyText = item.Key
                    };
                    var manager = new ManagerParsing();
                    var controller = new ConvertController(manager);
                    var result = controller.TryConvert(input) as ContentResult;
                    Assert.AreEqual(expected.Content, result.Content);
                    Assert.AreEqual(expected.ContentType, result.ContentType);
            }
        }

        [TestMethod]
        public void Index()
        {
            var manager = new ManagerParsing();
            var controller = new ConvertController(manager);
           
            ViewResult result = controller.Index() as ViewResult;

           
            Assert.IsNotNull(result);
        }
    }
}
