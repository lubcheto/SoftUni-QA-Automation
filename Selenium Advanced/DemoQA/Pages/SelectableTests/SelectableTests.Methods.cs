using OpenQA.Selenium;


namespace DemoQA.Pages.SelectableTests
{
    public partial class SelectableTests : BasePage
    {

        public SelectableTests(IWebDriver driver)
          : base(driver)
        {

        }

        public string [] ReturnColourBeforeAndAfterClick(IWebElement element)
        {
            string ColourBefore = element.GetCssValue("background-color");

            element.Click();

            string ColourAfter = element.GetCssValue("background-color");
            string[] ColoursBeforeAndAfter = { ColourBefore, ColourAfter };

          
            return ColoursBeforeAndAfter;

        }

   

    }
}