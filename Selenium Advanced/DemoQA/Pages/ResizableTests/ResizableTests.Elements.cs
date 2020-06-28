using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ResizableTests
{
    public partial class ResizableTests : BasePage
    {

        public IWebElement container => Driver.FindElement(By.ClassName("constraint-area"));
        public IWebElement resizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public IWebElement resizeArrow => Driver.FindElement(By.XPath("//span[contains(@class, 'react-resizable-handle')]"));
                
    }
}
