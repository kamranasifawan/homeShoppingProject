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


        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


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
            driver1.Url = "https://homeshopping.pk/";
            driver = driver1;
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
            //BasePage browser = new BasePage();
            //IWebDriver driver = browser.openBrowser("Chrome");
            //browser Chrome = new browser();
            //IWebDriver driver = Chrome.SeleniumInit("Chrome");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //LoginPage loginPage = new LoginPage(driver);
            //loginPage.login("kamranasifawan@gmail.com", "65xCaXUwEi2XCE@");

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
            ////driver.Manage().Window.Maximize();
            ////driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //driver.Url = "https://homeshopping.pk/";

            //SingUpPage singUpPage = new SingUpPage(driver);
           //obj.signUp("kamranasifawan@gmail.com", "65xCaXUwEi2XCE@", "Township Lahore", "Kamran", "Asif", "Lahore", "Pakistan", "4447163", "0342");
        }
    }
}
