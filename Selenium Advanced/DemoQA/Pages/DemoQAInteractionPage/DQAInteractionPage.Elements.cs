using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DemoQAInteractionPage
{
    public partial class DQAInteractionPage
    {
        protected IWebElement LeftPanel => Driver.FindElement(By.XPath("//*[@class='left-pannel']"));

        public IWebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));
        //when we use element ot find anothe element the XPath should start with "."

        public IWebElement SectionName(string sectionName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{sectionName}']"));
    }
}
