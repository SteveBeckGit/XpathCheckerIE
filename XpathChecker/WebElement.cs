using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpathChecker
{
    public class WebElement
    {
        public Dictionary<string, object> Attributes;
        public string Name;
        public WebElement(IWebElement element)
        {
            this.Attributes = GetAllAttributes(element);
            this.Name = element.ToString();
        }

        public Dictionary<string, object> GetAllAttributes(IWebElement element)
        {
            try
            {
                IJavaScriptExecutor javascriptDriver = (IJavaScriptExecutor)SeleniumFunctions.Driver;
                Dictionary<string, object> attributes = javascriptDriver
                    .ExecuteScript("var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;",
                    element) as Dictionary<string, object>;

                return attributes;
            } catch
            {
                return new Dictionary<string, object>();
            }
           
        }
    }
}
