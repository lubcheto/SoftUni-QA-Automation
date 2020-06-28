using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait Wait { get; set; }
        protected Actions Builder { get; set; }

        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("-headless"); // for headless driver
            // tova e za puskane na remote driver  
            var Uri = new Uri("http://192.168.1.5:4444/wd/hub");
            Driver = new RemoteWebDriver(Uri, options); //Variant 1 подаваме опциите към remote web driver
            //

            //DesiredCapabilities capabilities = new DesiredCapabilities(); // older version of ChromeOprions - do not use
            //Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Builder = new Actions(Driver);
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }
    }
}
