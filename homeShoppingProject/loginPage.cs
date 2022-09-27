using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeShoppingProject
{
    public class LoginPage
    {
        WebDriver driver;

        #region objects
        By loginForm = By.XPath("//a[@class='dpdn  signbtn nanp p0']");
        By email = By.Id("login_email");
        By pass = By.Id("login_pass");
        By loginButton = By.XPath("//input[@class='hsbtn']");

        
        #endregion
        #region constructor
        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
        }
        #endregion
        #region login
        public void login(String phoneUser, String passwd)
        {
            clickform();
            inputPhoneEmail(phoneUser);
            inputPassword(passwd);
            clickLogin();
            //Assert.AreEqual(url, driver.Url);
        }
        #endregion
        #region operation-methods
        void inputPhoneEmail(String emailInput)
        {
            type(email, emailInput);
        }
        void inputPassword(String passInput)
        {
            type(pass, passInput);
        }
        void clickLogin()
        {
            click(loginButton);
        }
        void clickform()
        {
            click(loginForm);
        }
        #endregion
        #region common-methods
        IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        void type(By locator, String text)
        {
            IWebElement element = findElement(locator);
            element.Clear();
            removeText(element);
            element.SendKeys(text);
        }
        void removeText(IWebElement element)
        {
            while (element.Text.Length > 0)
            {
                element.SendKeys(Keys.Backspace);
            }
        }
        void click(By locator)
        {
            findElement(locator).Click();
        }
        #endregion
    }
}
