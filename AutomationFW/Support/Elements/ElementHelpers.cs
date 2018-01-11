using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFW.Support.Elements
{
    public static class ElementHelpers
    {
        public static void Click(this IWebElement element, string elementName)
        {
            element.Click();
        }

        public static void SetText(this IWebElement element, string text, string elementName)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static Boolean WaitForVisible(this IWebElement element, int secondsToWait, string elementName)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element);
            wait.Timeout = TimeSpan.FromSeconds(secondsToWait);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);

            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                Boolean found = false;
                try
                {
                    found = element.Displayed;
                } catch (NoSuchElementException e)
                {
                    return found;
                }
                return found;
            });
            return wait.Until(waiter);
        }

    }
}
