using AutomationFW.Support.Elements;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFW.Pages
{
    class BasePage
    {
        protected IWebDriver driver;

        //Web Elements
        [FindsBy(How = How.CssSelector, Using = ".alert.alert-success.alert-dismissable")]
        public IWebElement SuccessMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".alert.alert-danger.alert-dismissable")]
        public IWebElement ErrorMessage { get; set; }

        public BasePage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        public Boolean IsSuccessMessageDisplayed()
        {
            return SuccessMessage.WaitForVisible(5, "SuccessMessage");
        }

        public Boolean IsErrorMessageDisplayed()
        {
            return ErrorMessage.WaitForVisible(5, "ErrorMessage");
        }

        public IWebElement FindDynamicElement(String xpathExpression)
        {
            try
            {
                IWebElement element = driver.FindElement(By.XPath(xpathExpression));
                return element;
            } catch (NoSuchElementException e)
            {
                return null;
            }

            
        }
    }
}
