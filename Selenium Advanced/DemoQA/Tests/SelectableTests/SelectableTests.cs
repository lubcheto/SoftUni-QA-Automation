using DemoQA.Pages.SelectableTests;
using NUnit.Framework;

namespace DemoQA.Tests.Selectable

{
    [TestFixture]
    public class SelectableSectionTests : BaseTest
    {
        private SelectableTests _selectableTests;


        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/selectable");
            _selectableTests = new SelectableTests(Driver);


        }

        [Test]
        public void SelectableChangeColorWhenClickedList()

        {
            _selectableTests.ListTab.Click();

            var FirstItemColourBeforeClick = _selectableTests.SelectableListFirstElement.GetCssValue("background-color");

            _selectableTests.SelectableListFirstElement.Click();

            var FirstItemColourAfterClick = _selectableTests.SelectableListFirstElement.GetCssValue("background-color");

            _selectableTests.AssertColoursAreNotEqual(FirstItemColourBeforeClick, FirstItemColourAfterClick);

        }


        [Test]
        public void SelectableChangeColorWhenClickedGrid()
        {

            _selectableTests.GridTab.Click();

            var BAFirstElement = _selectableTests.ReturnColourBeforeAndAfterClick(_selectableTests.SelectableGridFirstElement);
            var BASecondElement =_selectableTests.ReturnColourBeforeAndAfterClick(_selectableTests.SelectableGridNinthElement);

            _selectableTests.AssertColoursAreNotEqual(BAFirstElement[0], BAFirstElement[1], 
                BASecondElement[0], BASecondElement[1]);
        }


        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }


    }
}
