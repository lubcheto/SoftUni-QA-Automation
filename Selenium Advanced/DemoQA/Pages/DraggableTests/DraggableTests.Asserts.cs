using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DraggableTests
{
    public partial class DraggableTests : BasePage
    {

        public void AssertAreNotEqualXandY(double element1, double element2, double element3, double element4)
        {
            this.WaitForLoad();
            Assert.AreNotEqual(element1, element3);
            Assert.AreNotEqual(element2, element4);
        }
        


        public void AssertRestrictedXBoxMovesOnlyOnXaxis(double YAxisBefore, double YAxisAfter, double XAxisBefore, double XAxisAfter)
        {
            this.WaitForLoad();
            Assert.IsTrue(YAxisBefore == YAxisAfter); 
            Assert.AreEqual(XAxisBefore + 20, XAxisAfter, 4);
        }


        public void AssertRestrictedXBoxMovesOnlyOnYaxis(double XAxisBefore, double XAxisAfter, double YAxisBefore, double YAxisAfter)
        {
            this.WaitForLoad();
            Assert.IsTrue(XAxisBefore == XAxisAfter); 
            Assert.AreEqual(YAxisBefore + 20, YAxisAfter, 4);
        }


        public void AssertRestrictedBoxIsInContainer(IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsNotNull(element.FindElement(By.TagName("div"))); ;
        }


    }
}
