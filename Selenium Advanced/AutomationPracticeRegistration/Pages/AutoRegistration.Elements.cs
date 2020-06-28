using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeRegistration.Pages
{
    public partial class AutoRegistration
    {
        public IWebElement FindAndClickSignIn => Driver.FindElement(By.PartialLinkText(@"Sign in"));

        public IWebElement CustomerEmail => Driver.FindElement(By.Id("email"));


    }
}
