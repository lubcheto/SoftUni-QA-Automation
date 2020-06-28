using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPracticeRegistration
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait Wait { get; set; }
        protected Actions Builder { get; set; }

        public void Initialize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Builder = new Actions(Driver);
            

        }
    }
}
