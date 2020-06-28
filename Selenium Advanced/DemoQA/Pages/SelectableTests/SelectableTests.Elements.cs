using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SelectableTests
{
    public partial class SelectableTests : BasePage
    {

        public IWebElement ListTab => Driver.FindElement(By.XPath("//*[@id='demo-tab-list']"));

        public IWebElement SelectableListFirstElement => Driver.FindElement(By.XPath("//*[@id='verticalListContainer']/*[1]"));

        public IWebElement GridTab => Driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));
        
        public IWebElement SelectableGridFirstElement => Driver.FindElement(By.XPath("//*[@id='row1']/*[1]"));
               
        public IWebElement SelectableGridNinthElement => Driver.FindElement(By.XPath("//*[@id='row3']/*[3]"));
        
        



    }

}
