using DemoQA.Pages.DraggableTests;
using NUnit.Framework;

namespace DemoQA.Tests.Draggable
{
    [TestFixture]
    public class DraggableSectionTests : BaseTest 
    {
        private DraggableTests _draggableTests;
         

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com/dragabble");
            _draggableTests = new DraggableTests(Driver);
            

        }

        [Test]
        public void DraggableSimpleAssertXYChange()
        {
            
            var before = _draggableTests.ReturnCoordinates(_draggableTests.DragableBox);

            _draggableTests.MoveDragableBox();

            var after = _draggableTests.ReturnCoordinates(_draggableTests.DragableBox);
                      
            _draggableTests.AssertAreNotEqualXandY(before[0], after[0], before[1], after[1]);

        }

        [Test]
        public void DraggableRestrictedXBoxMovesOnlyOnXaxis()

        {
            
            _draggableTests.AxisrestrictionTab.Click();
            
            var before = _draggableTests.ReturnCoordinates(_draggableTests.RestrictedXBox);
            
            _draggableTests.XAxisRestrictedMove();
            
            var after = _draggableTests.ReturnCoordinates(_draggableTests.RestrictedXBox);
            
            _draggableTests.AssertRestrictedXBoxMovesOnlyOnXaxis(before[1], after[1],before[0],after[0]);
        }


        [Test]
        public void DraggableRestrictedYBoxMovesOnlyOnYaxis()

        {
              
            _draggableTests.AxisrestrictionTab.Click();

            var before = _draggableTests.ReturnCoordinates(_draggableTests.RestrictedYBox);

            _draggableTests.YAxisRestrictedMove();

            var after = _draggableTests.ReturnCoordinates(_draggableTests.RestrictedYBox);

            _draggableTests.AssertRestrictedXBoxMovesOnlyOnYaxis(before[0], after[0], before[1], after[1]);
        }

        [Test]
        public void DraggableContainerRestrictedBox()
        {

            _draggableTests.ContainerRestrTab.Click();
                        
            _draggableTests.DraggableRestriction();
                        
            _draggableTests.AssertRestrictedBoxIsInContainer(_draggableTests.Container);
        }

                

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
