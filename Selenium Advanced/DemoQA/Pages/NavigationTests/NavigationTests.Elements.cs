using OpenQA.Selenium;

namespace DemoQA.Pages.NavigationTests
{
    public partial class NavigationTests:BasePage
    {

        public IWebElement InteractionsMenu => Driver.FindElement(By.XPath("//*[@class='card-body']/*[text()[normalize-space()='Interactions']]"));
                
        public IWebElement pageHeader => Driver.FindElement(By.ClassName("main-header"));



        public string URL => "http://www.demoqa.com";
    }
}
