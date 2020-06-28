using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SortableTests
{
    public partial class SortableTests : BasePage
    {
        public IWebElement ListTab => Driver.FindElement(By.XPath("//*[@id='demo-tab-list']"));

        public IWebElement SortableListOne => Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']/*[1]"));

        public IWebElement SortableListTwo => Driver.FindElement(By.XPath("//*[@class='vertical-list-container mt-4']/*[2]"));

        public IWebElement GridTab => Driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));

        public IWebElement SortableGridOne => Driver.FindElement(By.XPath("//*[@class='create-grid']/*[1]"));
 
        public IWebElement SortableGridNine => Driver.FindElement(By.XPath("//*[@class='create-grid']/*[9]"));
    }
}
