using OpenQA.Selenium;

namespace DemoQA.Pages.DraggableTests
{
    public partial class DraggableTests : BasePage
    {
        public DraggableTests(IWebDriver driver)
           : base(driver)
        {

        }


        public void MoveDragableBox()
        {

            SimpleTab.Click();

            Builder
               .MoveToElement(DragableBox)
               .ClickAndHold()
               .MoveByOffset(180, 180)
               .Release()
               .Perform();


        }

        public double[] ReturnCoordinates(IWebElement element)
        {
            var PositionX = element.Location.X;
            var PositionY = element.Location.Y;
            double[] Coordinates = { PositionX, PositionY };

            return Coordinates;

        }

        public void XAxisRestrictedMove()
        {
                       

            Builder
                .MoveToElement(RestrictedXBox)
                .ClickAndHold()
                .MoveByOffset(20, 20)
                .Release()
                .Perform();
        }

        public void YAxisRestrictedMove()
        {

                
             Builder
                 .MoveToElement(RestrictedYBox)
                 .ClickAndHold()
                 .MoveByOffset(20, 20)
                 .Release()
                 .Perform();
        }

        public void DraggableRestrictedBox()
        {


            Builder
              .MoveToElement(ContainedBox)
              .ClickAndHold()
              .MoveByOffset(1000, 500) // Move the Contrained Box to greated coordinates than Contrainer
              .Release()
              .Perform();
        }

        public void DraggableRestriction()
        {


            Builder.DragAndDropToOffset(ContainedBox, 0, Container.Size.Height - 100).Perform();
        }

        


    }
}
