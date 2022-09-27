using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace homeShoppingProject

{
    internal class SingUpPage
    {
        WebDriver driver;

        #region objects
        By SingUpForm = By.XPath("//a[@class='dpdn newcusbtn nanp p0']");
        By email = By.Id("FormField_1");
        By pass = By.Id("FormField_2");
        By address = By.Id("FormField_8");
        By firstName = By.Id("FormField_4");
        By lastName = By.Id("FormField_5");
        By city = By.Id("FormField_12");
        By country = By.Id("FormField_11");
        By phoneNo = By.XPath("//input[@class='custom_mobile_number number_field']");
        By mobileCode = By.XPath("//select[@class='custom_mobile_code']");

        By createButton = By.XPath("//input[@value='CREATE ACCOUNT']");
        #endregion
        #region constructor
        public SingUpPage(WebDriver driver)
        {
            this.driver = driver;
        }
        #endregion
        #region login
        public void SingUp(String email, String passwd, string address, String firstName, String LastName, string city, string countery, string pnoneNo, string number)
        {
            clickForm();
            inputEmail(email);
            inputPassword(passwd);
            inputAddress(address);
            inputFirstName(firstName);
            inputLastName(LastName);
            inputCity(city);
            inputCountry(countery);
            inputPhoneNo(pnoneNo);
            inputNo(number);

            clickButton();
            //Assert.AreEqual(url, driver.Url);
        }
        #endregion
        #region operation-methods
        void clickForm()
        {
            click(SingUpForm);
        }
        void inputEmail(String emailInput)
        {
            type(email, emailInput);
        }
        void inputPassword(String passInput)
        {
            type(pass, passInput);
        }
        void inputAddress(String userAddress)
        {
            type(address, userAddress);
        }
        void inputFirstName(String userFirstName)
        {
            type(firstName, userFirstName);
        }
        void inputLastName(String userLastName)
        {
            type(lastName, userLastName);
        }
        void inputNo(string number)
        {
            IWebElement check = driver.FindElement(mobileCode);
            //check.Click();
            SelectElement check1 = new SelectElement(check);
            check1.SelectByValue(number);
        }
        void inputPhoneNo(String userPhoneNo)
        {
            type(phoneNo, userPhoneNo);
        }
        void inputCity(string selecetCity)
        {
            IWebElement check = driver.FindElement(city);
            SelectElement check1 = new SelectElement(check);
            check1.SelectByValue(selecetCity);
        }
        void inputCountry(string selecetCountery)
        {
            IWebElement check = driver.FindElement(country);
            SelectElement check1 = new SelectElement(check);
            check1.SelectByValue(selecetCountery);
        }
        void clickButton()
        {
            click(createButton);
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
