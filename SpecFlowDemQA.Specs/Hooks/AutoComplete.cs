using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class AutoComplete
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public AutoComplete(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement Widgets => WebDriver.FindElement(By.XPath("//div[text()='Widgets']"));
        public IWebElement autocomplete => WebDriver.FindElement(By.XPath("//span[text()='Auto Complete"));
        public IWebElement autoMultiple => WebDriver.FindElement(By.Id("autoCompleteMultipleInput"));
        public IWebElement autoSingle => WebDriver.FindElement(By.Id("autoCompleteSingleInput"));
        public void clickWidgets() => Widgets.Click();
        public void clickAutoComplete() => autocomplete.Click();
        public void enterAutoMultipleColors(String color)
        {
            autoMultiple.SendKeys(color);
        }

        public void enterSingleColor(String color)
        {
            autoSingle.SendKeys(color);
        }
    }
}
