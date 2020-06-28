using DemoQA.Pages.DroppableTests;
using NUnit.Framework;

namespace DemoQA.Tests.Droppable
{
    [TestFixture]
    public class DroppableSectionTests : BaseTest
    {
        private DroppableTests _droppableTests;
        //private DraggableTestsModel model;


        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/droppable");
            _droppableTests = new DroppableTests(Driver);


        }


        [Test]
        public void DroppableColourChange()
        {
                        
            var ColorBefore = _droppableTests.DraggableBox.GetCssValue("background-color");

            Builder.DragAndDrop(_droppableTests.DraggableBox, _droppableTests.TargetBox).Perform();

            var ColorAfter = _droppableTests.TargetBox.GetCssValue("background-color");

            _droppableTests.AssertColourChange(ColorBefore, ColorAfter, _droppableTests.TargetBox);

        }


        [Test]
        public void DroppableAcceptTabNoTAcceptableBoxDoesNotChangeColourOfTargetBox()
        {

            _droppableTests.AcceptTab.Click();

            var ColorBefore = _droppableTests.NotAcceptableeBox.GetCssValue("background-color");

            Builder.DragAndDrop(_droppableTests.NotAcceptableeBox, _droppableTests.TargetBox1).Perform();

            var ColorAfter = _droppableTests.NotAcceptableeBox.GetCssValue("background-color");

            _droppableTests.AssertColourDoesNotChange(ColorBefore, ColorAfter, _droppableTests.TargetBox1);
                        
        }


        [Test]
        public void DroppableNotRevertableBoxDiffCoordinates()
        {

            _droppableTests.RevertableTab.Click();

            var before = _droppableTests.ReturnCoordinates(_droppableTests.notRevertableBox);
                       

            Builder.DragAndDrop(_droppableTests.notRevertableBox, _droppableTests.TargetBox2).Perform();

            var after = _droppableTests.ReturnCoordinates(_droppableTests.notRevertableBox);

            _droppableTests.AssertDifferentCoordinates(before[0],after[0],_droppableTests.TargetBox2);
            _droppableTests.AssertDifferentCoordinates(before[1],after[1],_droppableTests.TargetBox2);

        }


        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }

    }
}