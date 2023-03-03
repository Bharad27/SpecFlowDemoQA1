using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class ToolTip
    {
        public IWebDriver webDriver { get; }
        public static IWebDriver Driver { get; }
        Actions action = new Actions(Driver);
        public ToolTip(IWebDriver webDriver)
        {
            webDriver = webDriver;
        }

        public IWebElement tooltip => webDriver.FindElement(By.XPath("//span[text()='Tool Tips']"));
        public IWebElement hoverButton => webDriver.FindElement(By.Id("toolTipButton"));
        public IWebElement hoverTextField => webDriver.FindElement(By.Id("toolTipTextField"));
        public IWebElement links => webDriver.FindElement(By.XPath("//*[@href='javascript:void(0)']"));

        public void clickToolTip() => tooltip.Click();
        public void hoverMeToSeeButton()
        {
            action.MoveToElement(hoverButton).Perform();
        }

        public void hoverMeToSeeTextField()
        {
            action.MoveToElement(hoverTextField).Perform();
        }

        public void hoverTheChosenLink(String linkName)
        {
            action.MoveToElement(links);

        }
        public String assertionHoverButtonText()
        {
            return hoverButton.Text;
        }
        public String assertionHoverLink(int index)
        {
            return links.Text;
        }
    }
}
