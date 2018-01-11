using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFW.Support.Drivers
{
    abstract class WebDriver
    {
        protected IWebDriver driver;

        public abstract void CreateService();

        public abstract void StopService();

        public abstract void StartDriverSession();

        public void StopDriverSession()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        public void SetElementTimeout(int timeout)
        {
            
        }

        public int GetElementTimeout()
        {
            return 0;
        }

        public void SetPageLoadStrategy()
        {

        }


    }
}
