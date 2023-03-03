using IdeaBlade.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class Sortable
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public static IWebDriver Driver { get; }
        Actions action = new Actions(Driver);
        public Sortable(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement interactions => WebDriver.FindElement(By.XPath("//div[text()='Interactions']"));
        public IWebElement sortable => WebDriver.FindElement(By.XPath("//span[text()='Sortable']"));
        public IWebElement listOrGrid => WebDriver.FindElement(By.XPath("//*[@href='#']"));
        public IWebElement list => WebDriver.FindElement(By.XPath("//*[contains(@class,'vertical-list-container')]/div"));
        public IWebElement grid => WebDriver.FindElement(By.XPath("//*[contains(@class,'create-grid')]/div"));

        public void clickInteractions() => interactions.Click();
        public void clickSortable() => sortable.Click();
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public List<WebElement> elements(By locator)
        {
            return (List<WebElement>)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }
        public void dragAndDropWebElements(By locator1, By locator2, int i, int j)
        {
            action.DragAndDrop((IWebElement)elements(locator1), (IWebElement)elements(locator2)).Build().Perform();
        }
        public void dragAndDropASCAndDESC(int index)
        {
            if (index == 0)
            {
                for (int j = 5; j >= 0; j--)
                {
                    dragAndDropWebElements((By)list, (By)list, index, j);
                }
            }
            else if (index == 5)
            {
                for (int j = 0; j < 5; j++)
                {
                    dragAndDropWebElements((By)list, (By)list, index, j);
                }
            }
        }
    }
}
