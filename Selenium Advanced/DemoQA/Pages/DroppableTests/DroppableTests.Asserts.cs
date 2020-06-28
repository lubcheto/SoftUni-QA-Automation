using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppableTests
{
    public partial class DroppableTests : BasePage
    {
        public void AssertColourChange(string colourBefore, string colourAfter,IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsTrue(colourBefore != colourAfter);
            Assert.AreEqual(element.Text, "Dropped!");
        }


        public void AssertColourDoesNotChange(string colourBefore, string colourAfter, IWebElement element)
        {
            this.WaitForLoad();
            Assert.IsTrue(colourBefore == colourAfter);
            Assert.AreEqual(element.Text, "Drop here");
        }


        public void AssertDifferentCoordinates(int coordinatesBefore, int coordinatesAfter, IWebElement element)
        {
            this.WaitForLoad();

            Assert.IsTrue(coordinatesBefore != coordinatesAfter);
            Assert.AreEqual(element.Text, "Dropped!");
        }




   
    }




}
