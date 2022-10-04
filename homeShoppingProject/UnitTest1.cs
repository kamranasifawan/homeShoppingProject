using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace homeShoppingProject
{
    [TestClass]
    public class LoginAutomation:BasePage
    {
        SignUpPage signUpObj = new SignUpPage();
        LoginPage loginObj = new LoginPage();
        searchBar searchObj= new searchBar();
        menuBar menuObj= new menuBar();
        filterPage filterObj= new filterPage();
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
            
            //LogReport("TestReport");
        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {
           // extentReports.Flush();
        }
        [TestInitialize()]
        public void TestInit()
        {
            BasePage browser = new BasePage();
            IWebDriver driver1 = browser.openBrowser("Chrome");           
            driver = driver1;
            log.Info("enter url");
            OpenUrl("https://homeshopping.pk/");
            log.Info("URL is :"+driver.Url);
        }
        [TestCleanup()]
        public void TestCleanUp()
        {
            //Thread.Sleep(5000);
            //BasePage.CloseDriver();
        }
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\asiffkam\\source\\repos\\homeShoppingProject\\homeShoppingProject\\XMLFile2.xml",
        //    "LoginWithValidUserValidPassword", DataAccessMethod.Sequential)]
        [TestMethod]
        public void Login()
        {
            //string email1, password;
            //email1 = TestContext.DataRow[0].ToString();
            //password = TestContext.DataRow[1].ToString();
            //loginObj.login(email1, password);           
            loginObj.login("kamranasifawan@gmail.com", "65xCaXUwEi2XCE@");
            ExtentStart();
            test = null;
            test = extent.CreateTest("T001").Info("Login Test");
        }
        [TestMethod]
        public void finde()
        {
            searchObj.search("Samsung Galaxy S22");
        }
        [TestMethod]
        public void menu()
        {
            menuObj.menu();
        }
        [TestMethod]
        public void filter()
        {
            menuObj.menu();
            filterObj.filter("pricedesc");
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
