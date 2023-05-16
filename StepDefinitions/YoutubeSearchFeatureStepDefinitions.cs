using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(7000);
        }

        [Then(@"Search for the Testers Talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);

            Thread.Sleep(7000);

            driver.Quit();
        }
    }
}
