using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace homeShoppingProject
{
    public class SignUpPage : BasePage
    {
        By SignUpForm = By.XPath("//a[@class='dpdn newcusbtn nanp p0']");
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
        public void signUp(string email1, string password, string address1, string fname, string lname, string city1, string country1, string phnNUM, string code)
        {
            Click(SignUpForm);
            Write(email ,email1);
            Write(pass, password);
            Write(address, address1);
            Write(firstName, fname);
            Write(lastName, lname);
            dropDown(city, city1);
            dropDown(country, country1);
            Write(phoneNo, phnNUM);
            dropDown(mobileCode, code);
            Click(createButton);
        }
    }
}
