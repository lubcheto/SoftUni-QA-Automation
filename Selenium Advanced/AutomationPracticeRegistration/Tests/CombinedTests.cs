using AutomationPracticeRegistration.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationPracticeRegistration.Tests
{
    [TestFixture]
    public class CombinedTests : BaseTest
    {
        private AutoRegistration _autoRegistration;



        [SetUp]

        public void Setup()
        {
            Initialize();
            _autoRegistration = new AutoRegistration(Driver);

        }

        [Test]

        public void EmailVerificationInCreateAccountForm()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");


            Assert.AreEqual(_autoRegistration.SignIn(), _autoRegistration.EmailOnPage());

        }

        [Test]
        public void GoogleSearch()
        {
            Driver.Navigate().GoToUrl("https://google.com");


            _autoRegistration.VerifyGoogleSearch();

        }

        [Test]

        public void QAAutomationInSoftuni()
        {

            Driver.Navigate().GoToUrl("https://www.softuni.bg");


            _autoRegistration.SoftuniNav();


        }



        [TearDown]
        public void Teardown()
        {
            
            Driver.Quit();

        }
    }
}
