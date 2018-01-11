using AutomationFW.Support;
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
    class NewTitlePage : BasePage
    {
        /**Page Elements**/
        [FindsBy(How = How.Id, Using = "title_name")]
        public IWebElement TitleTextbox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
        public IWebElement SubmitButton { get; set; }

        /**Constructors**/
        public NewTitlePage(IWebDriver driver) : base(driver) { }

        /**Methods**/

        /// <summary>
        /// Creates a title with a random name.  Returns the title name
        /// </summary>
        public String AddNewTitle()
        {
            String name = Randomizer.CreateRandomString(7);
            TitleTextbox.SetText(name, "TitlesTextbox");
            SubmitButton.Click();
            return name;

        }

        public void EditTitle(String titleName)
        {
            TitleTextbox.SetText(titleName, "TitlesTextbox");
            SubmitButton.Click();
        }
    }
}
