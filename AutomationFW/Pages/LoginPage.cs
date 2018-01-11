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
    class LoginPage : BasePage
    {
        

        //Elements
        [FindsBy(How = How.Id, Using = "employee_username")]
        public IWebElement Username { get; set; }
        [FindsBy(How = How.Id, Using = "employee_password")]
        public IWebElement Password { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
        public IWebElement Submit { get; set; }


        public LoginPage(IWebDriver driver) : base(driver) {}

        public void LoginToApp(String username, String password)
        {
            Username.SetText(username, "Username");
            Password.SetText(password, "Password");
            Submit.Click();
        }

        public Boolean IsLoginPageDisplayed()
        {
            return Username.WaitForVisible(5, "Username");
        }


    }
}
