using DemoQA.Models;
using DemoQA.Pages.DemoQAInteractionPage;
using DemoQA.Pages.NavigationTests;
using DemoQA.Tests;
using DemoQA;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.Tests.Navigation
{

    [TestFixture]
    public class NavigateToSectionTests:BaseTest
    {
        private NavigationTests _navigationTests;
        private NavigationTestsModel _menu;
        private DQAInteractionPage _DQApage;


        [SetUp]
        public void Setup()
        {
            Initialize();
            _navigationTests = new NavigationTests(Driver);
            _DQApage = new DQAInteractionPage(Driver);
            Driver.Navigate().GoToUrl(_navigationTests.URL);

        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void SuccessfullyLoadPageWhenNavigated(string sectionName)
        {

            _navigationTests.CustomClick(_menu);

                      
            Driver.ScrollTo(_DQApage.SectionName(sectionName));
            _DQApage.SectionName(sectionName).Click();


            Assert.AreEqual(sectionName, _navigationTests.pageHeader.Text);

        }

        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
