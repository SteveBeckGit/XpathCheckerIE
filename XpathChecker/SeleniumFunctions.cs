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
        public static List<IWebElement> elementsFound = new List<IWebElement>();

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

        public static IWebElement findElement(String xpath)
        {
            try
            {
                return Driver.FindElement(By.XPath(xpath));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string GetCurTitle()
        {
            try
            {
                string origHandle = Driver.CurrentWindowHandle;
                var title = Driver.SwitchTo().Window(origHandle).Title;
                return title;
            }
            catch
            {
                return "";
            }
        }

        public static List<string> GetWindowTitles()
        {
            List<string> Titles = new List<string>();
            try
            {
                string origHandle = Driver.CurrentWindowHandle;
                foreach (string handle in Driver.WindowHandles)
                {
                    var newWindow = Driver.SwitchTo().Window(handle);
                    Titles.Add(newWindow.Title);
                }
                Driver.SwitchTo().Window(origHandle);
                return Titles;
            }
            catch
            {
                return Titles;
            }

        }

        public static bool SwitchWindows(string title)
        {
            try
            {
                string origHandle = Driver.CurrentWindowHandle;
                foreach (string handle in Driver.WindowHandles)
                {
                    var newWindow = Driver.SwitchTo().Window(handle);
                    if (newWindow.Title.Equals(title))
                    {
                        return true;
                    }
                }
                Driver.SwitchTo().Window(origHandle);
                return false;
            }
            catch
            {
                return false;
            }

        }

        public static List<IWebElement> findElements(String xpath)
        {
            try
            {
                return Driver.FindElements(By.XPath(xpath)).ToList();
            }
            catch (Exception ex)
            {
                return new List<IWebElement>();
            }
        }



        public static IWebElement findElementInFrames(String xpath)
        {
            try
            {
                Driver.SwitchTo().DefaultContent();
                IWebElement element = findElement(xpath);
                if (element != null)
                    return element;

                List<IWebElement> frames = Driver.FindElements(By.XPath("//frame | //iframe")).ToList();

                foreach (IWebElement frame in frames)
                {
                    Driver.SwitchTo().Frame(frame);
                    element = findElementInFrames(frame, xpath);
                    if (element != null)
                    {
                        return element;
                    }
                    Driver.SwitchTo().ParentFrame();
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }



        public static IWebElement findElementInFrames(IWebElement frame, String xpath)
        {
            try
            {
                IWebElement element = findElement(xpath);
                if (element != null)
                {
                    return element;
                }

                List<IWebElement> frames = Driver.FindElements(By.XPath("//frame | //iframe")).ToList();
                foreach (IWebElement curFrame in frames)
                {
                    Driver.SwitchTo().Frame(curFrame);
                    element = findElement(xpath);
                    if (element != null)
                    {
                        return element;
                    }

                    findElementInFrames(curFrame, xpath);
                    Driver.SwitchTo().ParentFrame();
                }

            }
            catch (Exception ex)
            {
            }

            return null;

        }

        public static void  findElementsInFrames(String xpath)
        {
            elementsFound = new List<IWebElement>();
            try
            {
                Driver.SwitchTo().DefaultContent();
                elementsFound = elementsFound.Union(FindElements(xpath)).ToList();

                List<IWebElement> frames = Driver.FindElements(By.XPath("//frame | //iframe")).ToList();

                foreach (IWebElement frame in frames)
                {
                    Driver.SwitchTo().Frame(frame);
                    findElementInFrames(frame, xpath);
                    
                    Driver.SwitchTo().ParentFrame();
                }

            }
            catch (Exception ex)
            {
            }

        }

        public static void findElementsInFrames(IWebElement frame, String xpath)
        {
            try
            {

                elementsFound = elementsFound.Union(FindElements(xpath)).ToList();

                List<IWebElement> frames = Driver.FindElements(By.XPath("//frame | //iframe")).ToList();
                foreach (IWebElement curFrame in frames)
                {
                    Driver.SwitchTo().Frame(curFrame);
                    elementsFound = elementsFound.Union(FindElements(xpath)).ToList();
                    var ele = findElement(xpath);
                    if (ele != null)
                    {
                        string t = "";
                    }
                    findElementInFrames(curFrame, xpath);
                    Driver.SwitchTo().ParentFrame();
                }

            }
            catch (Exception ex)
            {
            }


        }
    }

        
}
