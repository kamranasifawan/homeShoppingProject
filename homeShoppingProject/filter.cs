using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeShoppingProject
{
    internal class filterPage : BasePage
    {
        By sortBy = By.Id("sort");
        By brand = By.Id("sidecatbrand_1");
        By operatingSystem = By.XPath("//a[contains(text(),'Android')]");
        By cpu = By.XPath("//a[contains(text(),'2Ghz to 2.5Ghz')]");
        By displaySize = By.XPath("/html/body/div/div[9]/div[2]/div[1]/div/div[4]/div/ul/li[2]/a");
        By ram = By.XPath("//a[contains(text(),'8 GB')]");
        By rom = By.XPath("//a[contains(text(),'128 GB')]");
        public void filter(string sortBya1)
        {
           
            checkBox(brand);
            checkBox(operatingSystem);
            checkBox(cpu);
            //checkBox(displaySize);
            checkBox(ram);
            checkBox(rom);

            dropDown(sortBy, sortBya1);

        } 

    }
}
