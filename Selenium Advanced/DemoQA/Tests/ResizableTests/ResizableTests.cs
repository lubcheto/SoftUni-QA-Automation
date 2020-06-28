
using DemoQA.Pages.ResizableTests;
using NUnit.Framework;

namespace DemoQA.Tests.Resizable

{
    [TestFixture]
    public class ResizableSectionTests : BaseTest
    {
        private ResizableTests _resizableTests;
      

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/resizable");
            _resizableTests = new ResizableTests(Driver);


        }


        [Test]
        public void ResizableScroll_Is_Limited_To_MaxMargin()
        {
            
            Builder.DragAndDropToOffset(_resizableTests.resizeArrow, 300, 100).Perform();

            _resizableTests.AssertMaxSizeOfResizableBox(_resizableTests.container,_resizableTests.resizableBox);
        }

        [Test]
        public void ResizableScroll_Is_Limited_To_MinMargin()
        {
            
            Builder.DragAndDropToOffset(_resizableTests.resizeArrow, -50, -50).Perform();

            _resizableTests.AssertMinSizeOfResizableBox(_resizableTests.resizableBox);
            
        }


        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
