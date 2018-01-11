using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFW.Support.Drivers
{
    class ChromeDriverSetup : WebDriver
    {
        private static ChromeDriverService service;

        public override void CreateService()
        {
            //service = new ChromeDriverService();
        }

        public override void StartDriverSession()
        {
            throw new NotImplementedException();
        }

        public override void StopService()
        {
            throw new NotImplementedException();
        }

        public IWebDriver CreateDriver()
        {
            return new ChromeDriver();
        }

        
    }
}
