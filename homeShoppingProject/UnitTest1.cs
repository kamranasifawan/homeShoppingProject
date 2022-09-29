using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace homeShoppingProject
{
    [TestClass]
    public class LoginAutomation:BasePage
    {
        SignUpPage signUpObj = new SignUpPage();
        LoginPage loginObj = new LoginPage();
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
        }
        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {
        }
        [TestInitialize()]
        public void TestInit()
        {
            BasePage browser = new BasePage();
            IWebDriver driver1 = browser.openBrowser("Chrome");           
            driver = driver1;
            OpenUrl("https://homeshopping.pk/");
        }
        [TestCleanup()]
        public void TestCleanUp()
        {
            Thread.Sleep(5000);
            BasePage.CloseDriver();
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\asiffkam\\source\\repos\\homeShoppingProject\\homeShoppingProject\\XMLFile2.xml",
            "LoginWithValidUserValidPassword", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Login()
        {
            
            string email1, password;
            email1 = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            loginObj.login(email1, password);           
        }
        public TestContext GetTestContext()
        {
            return TestContext;
        }        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\asiffkam\\source\\repos\\homeShoppingProject\\homeShoppingProject\\XMLFile1.xml",
            "LoginWithValidUserValidPassword", DataAccessMethod.Sequential)]
        [TestMethod]
        public void signUp()
        {
            string email1, password, address1,  fname, lname, city1, country1,phnNUM, code;
            email1 = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            address1 = TestContext.DataRow[2].ToString();
            fname = TestContext.DataRow[3].ToString();
            lname = TestContext.DataRow[4].ToString();
            city1 = TestContext.DataRow[5].ToString();
            country1 = TestContext.DataRow[6].ToString();
            phnNUM = TestContext.DataRow[7].ToString();
            code = TestContext.DataRow[8].ToString();
            signUpObj.signUp(email1, password, address1, fname, lname, city1, country1, phnNUM, code);           
        }
    }
}
