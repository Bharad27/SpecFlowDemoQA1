using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class Buttons
    {
        public IWebDriver webDriver { get; }
        public static IWebDriver Driver { get; }
        Actions action = new Actions(Driver);
        public Buttons(IWebDriver webDriver)
        {
            webDriver = webDriver;
            
        }

        public IWebElement button => webDriver.FindElement(By.XPath("//span[text()='Buttons']"));
        public IWebElement buttonsDoubleClick => webDriver.FindElement(By.Id("doubleClickBtn"));
        public IWebElement buttonsRightClick => webDriver.FindElement(By.Id("rightClickBtn"));
        public IWebElement buttonsClickMe => webDriver.FindElement(By.CssSelector("#PlLUl"));

        public void CLickButton() => button.Click();
        public void buttonsDoubleClickAction()
        {
            action.DoubleClick(webDriver.FindElement((By)buttonsDoubleClick)).Build().Perform();
        }

        public void buttonsRightClickAction()
        {
            action.ContextClick(webDriver.FindElement((By)buttonsRightClick)).Build().Perform();
        }

        public void buttonsClickMeAction()
        {
            webDriver.FindElement((By)buttonsClickMe).Click();
        }

    }
}
