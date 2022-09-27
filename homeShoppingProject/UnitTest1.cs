using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace homeShoppingProject
{
    [TestClass]
    public class LoginAutomation
    {
        [TestMethod]
        public void Login()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://homeshopping.pk/";

            LoginPage loginPage = new LoginPage(driver);
            loginPage.login("kamranasifawan@gmail.com", "65xCaXUwEi2XCE@");

        }
        [TestMethod]
        public void SingUp()
        {
            WebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.Url = "https://homeshopping.pk/";

            SingUpPage singUpPage = new SingUpPage(driver);
            singUpPage.SingUp("kamranasifawan@gmail.com", "65xCaXUwEi2XCE@", "Township Lahore", "Kamran", "Asif", "Lahore", "Pakistan", "4447163", "0342");
        }
    }
}
