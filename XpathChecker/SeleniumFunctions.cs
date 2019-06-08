using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpathChecker
{
    public class SeleniumFunctions
    {
        public static IWebDriver Driver;

        public static void Launch(string URL)
        {
            InternetExplorerOptions opts = new InternetExplorerOptions();
            opts.IgnoreZoomLevel = true;
            opts.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            
            Driver = new InternetExplorerDriver(AppDomain.CurrentDomain.BaseDirectory, opts);
            Driver.Navigate().GoToUrl(URL);
        }

        public static List<IWebElement> FindElements(string xpath)
        {
            List<IWebElement> elements = new List<IWebElement>();
            try
            {
                elements = Driver.FindElements(By.XPath(xpath)).ToList();
                return elements;
            }
            catch
            {
                return elements;
            }
        }
    }
}
