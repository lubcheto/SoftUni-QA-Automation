using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppableTests
{
    public partial class DroppableTests : BasePage
    {

        public IWebElement DraggableBox => Driver.FindElement(By.Id("draggable"));
        public IWebElement TargetBox => Driver.FindElement(By.Id("droppable"));

        public IWebElement AcceptTab => Driver.FindElement(By.XPath("//*[@class='nav nav-tabs']/*[text()='Accept']"));

        public IWebElement AcceptableBox => Driver.FindElement(By.Id("acceptable"));

        public IWebElement NotAcceptableeBox => Driver.FindElement(By.Id("notAcceptable"));

        public IWebElement TargetBox1 => Driver.FindElement(By.XPath("//*[@class='accept-drop-container']/*[@class='drop-box ui-droppable']"));

        public IWebElement RevertableTab => Driver.FindElement(By.XPath("//*[@id='droppableExample-tab-revertable']"));

        public IWebElement notRevertableBox => Driver.FindElement(By.Id("notRevertable"));

        public IWebElement TargetBox2 => Driver.FindElement(By.XPath("//*[@class='revertable-drop-container']/*[@id='droppable']"));
    }
}
