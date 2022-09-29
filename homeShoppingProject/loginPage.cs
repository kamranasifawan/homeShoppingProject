﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeShoppingProject
{
    public class LoginPage : BasePage
    {
        By loginForm = By.XPath("//a[@class='dpdn  signbtn nanp p0']");
        By email = By.Id("login_email");
        By pass = By.Id("login_pass");
        By loginButton = By.XPath("//input[@class='hsbtn']");
        public void login(string email1, string password)
        {
            Click(loginForm);
            Write(email, email1);
            Write(pass, password);
            Click(loginButton);
        }
    }
}