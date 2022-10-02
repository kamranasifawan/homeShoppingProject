using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeShoppingProject
{
    public class searchBar : BasePage
    {
        By searchBox = By.Id("search_query");
        By searchButton = By.XPath("//button[@class='btn btn-default btn-success searhicon searchbtv']");
        public void search(string search1)
        {
            Write(searchBox, search1);
            Click(searchButton);
        }
    }    
}
