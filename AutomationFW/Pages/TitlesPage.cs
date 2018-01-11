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
    class TitlesPage : BasePage
    {
        //Web Elements
        [FindsBy(How = How.LinkText, Using = "New Title")]
        public IWebElement NewTitleLink { get; set; }

        public TitlesPage(IWebDriver driver) : base(driver) { }

        public Boolean IsTitlePageDisplayed()
        {
            return NewTitleLink.WaitForVisible(5, "NewTitleLink");
        }

        public void ClickNewTitle()
        {
            NewTitleLink.Click();
        }

        public Boolean ClickEditIconForTitle(String titleName)
        {
            IWebElement tableElement = FindDynamicElement("//td[contains(text(), '" + titleName + "')]");
            if (tableElement != null)
            {
                tableElement.FindElement(By.CssSelector(".glyphicon.glyphicon-pencil")).Click();
                return true;
            } else
            {
                return false;
            }
        }

    }
}
