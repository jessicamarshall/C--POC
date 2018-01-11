using AutomationFW.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationFW.Steps
{
    [Binding]
    public class TitlesSteps
    {
        IWebDriver driver;
        TitlesPage titlesPage;
        MainNavigation mainNavigation;
        NewTitlePage newTitlePage;
        private String titleName;

        public TitlesSteps(IWebDriver driver)
        {
            this.driver = driver;
            mainNavigation = new MainNavigation(driver);
            titlesPage = new TitlesPage(driver);
            newTitlePage = new NewTitlePage(driver);
        }

        [Given(@"I have nagivated to Titles page")]
        public void GivenIHaveNagivatedToTitlesPage()
        {
            
            mainNavigation.NavigateToTilesPage();      
            Assert.True(titlesPage.IsTitlePageDisplayed());
            titlesPage.ClickNewTitle();
        }
        
        [When(@"When I add a new title")]
        public void WhenWhenIAddANewTitle()
        {
            titleName = newTitlePage.AddNewTitle();
        }

        [Given(@"I have an existing title")]
        public void GivenIHaveAnExistingTitle()
        {
            titleName = newTitlePage.AddNewTitle();
        }


        [When(@"I edit the title name")]
        public void WhenIEditTheTitleName()
        {
            Assert.True(titlesPage.ClickEditIconForTitle(titleName), "Verify the title was listed in the existing titles to be edited: " + titleName);
            newTitlePage.EditTitle(titleName);
        }

    }
}
