using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.ResizableTests
{
    public partial class ResizableTests: BasePage
    {
        public void AssertMaxSizeOfResizableBox(IWebElement element1, IWebElement element2)
        {
            this.WaitForLoad();
            Assert.AreEqual(element1.Size.Height, element2.Size.Height);
            Assert.AreEqual(element1.Size.Width, element2.Size.Width);
        }

        public void AssertMinSizeOfResizableBox(IWebElement element1)
        {
            this.WaitForLoad();
            Assert.AreEqual(150, element1.Size.Height);
            Assert.AreEqual(150, element1.Size.Width);
        }
    }


   
}





    
