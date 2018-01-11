using AutomationFW.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text;
using TechTalk.SpecFlow;


namespace AutomationFW.Steps
{
    [Binding]
    class CommonSteps
    {
        BasePage basePage;
        LoginPage loginPage;
        IWebDriver driver;
        MainNavigation mainNavigation;

        public CommonSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
            mainNavigation = new MainNavigation(driver);
            basePage = new BasePage(driver);
        }

        [Given(@"That I am logged in as admin")]
        public void GivenThatIAmLoggedInAsAdmin()
        {
            
            loginPage.LoginToApp("company.admin", "test");        
            Assert.True(mainNavigation.IsLogoutDisplayed(), "Verify user is logged in successfully");
        }


        [Then(@"I should see a success message")]
        public void ThenIShouldSeeASuccessMessage()
        {
            Assert.True(basePage.IsSuccessMessageDisplayed(), "Verify user is successfully logged in");
        }

        [Then(@"I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            Assert.True(basePage.IsErrorMessageDisplayed(), "Verify error message displays with invalid login");
        }
    }
}
