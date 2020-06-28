using DemoQA.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.NavigationTests
{
    public partial class NavigationTests:BasePage
    {
        public NavigationTests(IWebDriver driver)
           : base(driver)
        {

        }

        public void CustomClick(NavigationTestsModel fields)
        {
            InteractionsMenu.Click();

        }
    }
}
