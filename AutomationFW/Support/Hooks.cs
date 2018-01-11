using AutomationFW.Support.Drivers;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomationFW.Support
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;
        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {
            ChromeDriverSetup driverSetup = new ChromeDriverSetup();
            driver = driverSetup.CreateDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            driver.Navigate().GoToUrl("http://bluesourcestaging.herokuapp.com");
        }

        [AfterScenario]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
