using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationPracticeRegistration.Pages
{
    public partial class AutoRegistration
    {
     public IWebElement searhKeyword => Wait.Until<IWebElement>(d => d.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")));
     public IWebElement openFirstResutl => Wait.Until<IWebElement>(d => d.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div.r > a > h3")));
    }
}
