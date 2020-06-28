using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.SortableTests
{
    public partial class SortableTests : BasePage
    {
        public SortableTests(IWebDriver driver)
       : base(driver)
        {

        }


        public string[] ReturnTextAfterMove(IWebElement element, IWebElement element2,int offset1, int offset2)
        {
            Builder
                .DragAndDropToOffset(element, offset1, offset2)
                .Perform();

            var OneTextAfter = element.Text;
            var TwotextAfter = element2.Text;
            string[] ReturnTexts = { OneTextAfter, TwotextAfter };

            return ReturnTexts;
        }

    }
}
