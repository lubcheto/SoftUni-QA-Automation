using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.DroppableTests
{
    public partial class DroppableTests : BasePage
    {

        public DroppableTests(IWebDriver driver)
          : base(driver)
        {

        }


        public int[] ReturnCoordinates(IWebElement element)
        {
            var PositionX = element.Location.X;
            var PositionY = element.Location.Y;
            int[] Coordinates = { PositionX, PositionY };

            return Coordinates;

        }



    }
}
