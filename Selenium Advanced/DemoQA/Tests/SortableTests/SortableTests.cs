using DemoQA.Pages.SortableTests;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace DemoQA.Tests.Sortable
{
    [TestFixture]
    public class SortableSectionTests : BaseTest
    {
        private SortableTests _sortableTests;


        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/sortable");
            _sortableTests = new SortableTests(Driver);


        }


        [Test]
        public void SortableListCheckCorrectExchangeOfPlaces()
        {

            _sortableTests.ListTab.Click();

            var ReturnedText = _sortableTests.ReturnTextAfterMove(_sortableTests.SortableListOne,_sortableTests.SortableListTwo,50,50);

            _sortableTests.AssertChangeOfPlaces(ReturnedText[0],ReturnedText[1]);
        }

        [Test]
        //We move Block 1 to the position of Block 9 and evaluate that on Block 9 we have text "One and on Block One we have text "Two"
        public void SortableGridCorrectExchangeOfPlaces()
        {
            //_sortableTests.GridTab.Click();

            var ReturnedText = _sortableTests.ReturnTextAfterMove(_sortableTests.SortableGridOne, _sortableTests.SortableGridNine, 200, 200);

            _sortableTests.AssertChangeOfPlaces(ReturnedText[0], ReturnedText[2]);

        }

        [TearDown]
        public void Teardown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)  //returns result state
            {
                var dirPath = Path.GetFullPath(@"..\..\..\",Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($@"{dirPath}\\Screenshots\\{TestContext.CurrentContext.Test.FullName}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit(); 
        }






    }
}
