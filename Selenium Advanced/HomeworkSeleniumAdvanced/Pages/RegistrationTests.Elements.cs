using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationForm.Pages
{
    public partial class RegistrationTests : BasePage
    {
        public IWebElement FindAndClickSignIn => Driver.FindElement(By.PartialLinkText(@"Sign in"));

        public IWebElement CustomerFirstName => Wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id='customer_firstname']")));

        public IWebElement CustomerLastName => Driver.FindElement(By.XPath("//*[@id='customer_lastname']"));

        public IWebElement CustomerPassword => Driver.FindElement(By.XPath("//*[@id='passwd']"));

        public IWebElement CustomerAddress => Driver.FindElement(By.XPath("//*[@id='address1']"));

        public IWebElement CustomerCity => Driver.FindElement(By.XPath("//*[@id='city']"));

        public IWebElement CustomerState => Driver.FindElement(By.XPath("//*[@id='id_state']"));

        public IWebElement CustomerPostCode => Driver.FindElement(By.XPath("//*[@id='postcode']"));

        public IWebElement CustomerPhoneMobile => Driver.FindElement(By.XPath("//*[@id='phone_mobile']"));

        public IWebElement YearDD => Driver.FindElement(By.Id("years"));

        public IWebElement MonthsDD => Driver.FindElement(By.Id("months"));

        public IWebElement DaysDD => Driver.FindElement(By.Id("days"));
    /*    public IWebElement CustomerGender(string labelText) =>
           Driver.FindElement(By.XPath($"//*[@id='genterWrapper']//label[text()='{labelText}']"));
*/
        public IWebElement CustomerGender =>
           Driver.FindElement(By.XPath("//*[@class='radio-inline']//*[@id='id_gender1']"));
        public IWebElement CustomerEmail => Driver.FindElement(By.Id("email"));

        public IWebElement FindSubmitField => Driver.FindElement(By.XPath("//*[@id='submitAccount']"));

        public IWebElement ErrorBox => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li"));

    }
}
