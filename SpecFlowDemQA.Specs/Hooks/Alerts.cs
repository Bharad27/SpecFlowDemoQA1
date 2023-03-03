using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class Alerts
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public Alerts(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement alerts => WebDriver.FindElement(By.XPath("//span[text()='Alerts"));
        public IWebElement alertButton => WebDriver.FindElement(By.Id("alertButton"));
        public IWebElement timerAlert => WebDriver.FindElement(By.Id("timerAlertButton"));
        public IWebElement confirmButton => WebDriver.FindElement(By.Id("confirmButton"));
        public IWebElement promptButton => WebDriver.FindElement(By.Id("promtButton"));
        public IWebElement confirmResult => WebDriver.FindElement(By.Id("confirmResult"));
        public IWebElement promptResult => WebDriver.FindElement(By.Id("promptResult"));

        public void clickAlerts() => alerts.Click();
        public void clickpromptbutton() => promptButton.Click();
        public void enterPromptData(String enterName)
        {
            webDriver.SwitchTo().Alert().SendKeys(enterName);
        }
        public String promptResultResponse()
        {
            return promptResult.Text;
        }
    }
}
