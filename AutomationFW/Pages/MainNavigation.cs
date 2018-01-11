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
    class MainNavigation : BasePage
    {

        /**Page Elements**/
        [FindsBy(How = How.LinkText, Using = "Logout")]
        public IWebElement LogoutLink { get; set; }
        [FindsBy(How = How.PartialLinkText, Using = "Admin")]
        public IWebElement AdminLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Titles")]
        public IWebElement TitlesLink { get; set; }

        //Constructor
        public MainNavigation(IWebDriver driver) : base(driver) { }

        //Methods

        public Boolean IsLogoutDisplayed()
        {
            return LogoutLink.WaitForVisible(10, "LogoutLink");
        }

        public void NavigateToTilesPage()
        {
            AdminLink.Click();
            TitlesLink.Click();
        }

    }
}
