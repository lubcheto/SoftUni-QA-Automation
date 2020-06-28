using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DraggableTests
{
    public partial class DraggableTests : BasePage
    {

        public IWebElement SimpleTab => Driver.FindElement(By.XPath("//*[@id='draggableExample-tab-simple']"));

        public IWebElement DragableBox => Driver.FindElement(By.Id("dragBox"));

        public IWebElement AxisrestrictionTab => Driver.FindElement(By.XPath("//*[@id='draggableExample-tab-axisRestriction']"));

        public IWebElement RestrictedXBox => Driver.FindElement(By.Id("restrictedX"));
               
        public IWebElement RestrictedYBox => Driver.FindElement(By.Id("restrictedY"));

        public IWebElement ContainerRestrTab => Driver.FindElement(By.XPath("//*[@id='draggableExample-tab-containerRestriction']"));

        public IWebElement Container => Driver.FindElement(By.Id("containmentWrapper")); //Find X,Y and size of contrainer

        public IWebElement ContainedBox => Driver.FindElement(By.XPath("//*[contains(text(),\"I'm contained within the box\")]"));


    }
}