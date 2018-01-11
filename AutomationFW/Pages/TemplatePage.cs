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
    class TemplatePage : BasePage
    {
        /**Page Elements**/
        [FindsBy(How = How.LinkText, Using = "New Title")]
        public IWebElement NewTitleLink { get; set; }

        /**Constructors**/
        public TemplatePage(IWebDriver driver) : base(driver) { }

        /**Methods**/
    }
}
