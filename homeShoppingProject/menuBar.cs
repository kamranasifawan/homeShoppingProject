using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeShoppingProject
{
    internal class menuBar : BasePage
    {
        By menuhBar = By.XPath("//i[@class='icon-menu hamburger-fontsize']");
        By mobileAndTablets = By.XPath("//*[@id=\"main\"]/ul/li[3]/a");
        By mobilePhones = By.XPath("//*[@id=\"mobntablets\"]/ul/li[1]/span/a");
        public void menu()
        {            
            Click(menuhBar);
            Click(mobileAndTablets);
            Click(mobilePhones);
        }
    }
}
