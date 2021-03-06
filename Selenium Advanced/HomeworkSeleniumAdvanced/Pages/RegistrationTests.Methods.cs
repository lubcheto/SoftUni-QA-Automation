﻿using AutoFixture;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RegistrationForm.Models;
using System.Threading;

namespace RegistrationForm.Pages
{
    public partial class RegistrationTests : BasePage
    {
        public RegistrationTests(IWebDriver driver) 
            : base(driver)
        {

        }

        public void SignIn()
        {
            var fixture = new Fixture();
            IWebElement FindAndClickSignIn = Wait.Until<IWebElement>(d => d.FindElement(By.PartialLinkText(@"Sign in")));
            FindAndClickSignIn.Click();

            var mail = fixture.Create<string>().Substring(0, 5) + "@gmail.com"; // limits the autogenerated string to 5 characters

            var FindInputField = Wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='email_create']")));
            FindInputField.SendKeys(mail);

            IWebElement FindAndClickSubmitCreate = Driver.FindElement(By.Id("SubmitCreate"));
            FindAndClickSubmitCreate.Click();
        }

        public void FillForm(RegistrationFormModels user)
        {
           /* this.WaitForLoad();
            Thread.Sleep(1000);*/
            CustomerFirstName.SendKeys(user.CustomerFirstName);
            CustomerLastName.SendKeys(user.CustomerLastName);
            CustomerPassword.SendKeys(user.CustomerPassword);
            CustomerAddress.SendKeys(user.CustomerAddress);
            SelectElement years = new SelectElement(YearDD);
            years.SelectByValue(user.Year);
            SelectElement months = new SelectElement(MonthsDD);
            months.SelectByValue(user.Month);
            SelectElement days = new SelectElement(DaysDD);
            days.SelectByValue(user.Day);
            CustomerAddress.SendKeys(user.CustomerAddress);
            CustomerCity.SendKeys(user.CustomerCity);
            CustomerState.SendKeys(user.CustomerState);
            CustomerPostCode.SendKeys(user.CustomerPostCode);
            CustomerPhoneMobile.SendKeys(user.CustomerPhoneMobile);
            CustomerGender.Click();
            FindSubmitField.Click();

        }
    }
}
