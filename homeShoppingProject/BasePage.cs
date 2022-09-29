using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace homeShoppingProject
{

    public class BasePage
    {
        public static IWebDriver driver;
        public IWebDriver openBrowser(string Browser)
        {
            IWebDriver driver = null;
            if (Browser == "Chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                driver = new ChromeDriver(options);

            }
            else if (Browser == "Firefox")
            {

                driver = new FirefoxDriver();
            }
            else
                if (Browser == "Edge")
            {
                driver = new EdgeDriver();
            }
            return driver;
        }
        public static void CloseDriver()
        {

            driver.Quit();

        }
        public void Write(By by, string value)
        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)
        {

            driver.FindElement(by).Click();

        }
        public void Clear(By by)
        {

            driver.FindElement(by).Clear();

        }
        public void OpenUrl(string url)
        {

            driver.Url = url;

        }
        public void dropDown(By by, string value)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByValue(value);
        }
    }
}
