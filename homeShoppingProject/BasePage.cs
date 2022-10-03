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
using OpenQA.Selenium.Interactions;

namespace homeShoppingProject
{
    public class BasePage
    {
        public static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
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
            log.Info("text write successfuly");
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
         public void checkBox(By by)
        {
            IWebElement element = driver.FindElement(by);
            Actions action = new Actions(driver);
            action.Click(element).Build().Perform();
        }
    }
}
