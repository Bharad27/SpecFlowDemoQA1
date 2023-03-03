using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class Droppable
    {
        public IWebDriver webDriver { get; }
        public static IWebDriver Driver { get; }
        Actions action = new Actions(Driver);
        public Droppable(IWebDriver webDriver)
        {
            webDriver = webDriver;
        }

        public IWebElement droppable => webDriver.FindElement(By.XPath("//span[text()='Droppable']"));
        public IWebElement menuItems => webDriver.FindElement(By.XPath("//*[contains(@href,'#')]"));
        public IWebElement dragMe => webDriver.FindElement(By.Id("draggable"));
        public IWebElement dropHere => webDriver.FindElement(By.XPath("//*[@class='simple-drop-container']/*[contains(@id,'droppable')]"));
        public IWebElement acceptDrop => webDriver.FindElement(By.XPath("//*[@class='accept-drop-container']/*[contains(@id,'droppable')]"));
        public IWebElement revertDrop => webDriver.FindElement(By.XPath("//*[@class='revertable-drop-container']/*[contains(@id,'droppable')]"));
        public IWebElement acceptable => webDriver.FindElement(By.Id("acceptable"));
        public IWebElement notAcceptable => webDriver.FindElement(By.Id("notAcceptable"));
        public IWebElement dragBox => webDriver.FindElement(By.Id("dragBox"));
        public IWebElement chooseOuterDroppable => webDriver.FindElement(By.XPath("//*[text()='Outer droppable']"));
        public IWebElement chooseInnerDroppable => webDriver.FindElement(By.XPath("//*[contains(text(),'Inner droppable')]"));
        public IWebElement willRevert => webDriver.FindElement(By.Id("revertable"));
        public IWebElement notRevert => webDriver.FindElement(By.Id("notRevertable"));
        public IWebElement text => webDriver.FindElement(By.XPath("//*[text()='Dropped!']"));
        public void clickDroppable() => droppable.Click();
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public int arrayListToInt(String[] items, String list)
        {
            return Array.IndexOf(items, list);
        }
        public void clickActionsWithIndex(By locator, int i)
        {
            action.Click((IWebElement)elements(locator)).Build().Perform();
        }
        public void chooseDroppableMenu(String droppableMenuList)
        {
            int i = arrayListToInt(StaticVariables.DROPPABLE_MENU, droppableMenuList);
            clickActionsWithIndex((By)menuItems, i);
        }
        public WebElement element(By locator)
        {
            //return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
            return (WebElement)(IWebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
        public List<WebElement> elements(By locator)
        {
            return (List<WebElement>)(IWebElement)wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }
        public void dragAndDropWebElements(By locator1, By locator2, int i, int j)
        {
            action.DragAndDrop((IWebElement)elements(locator1), (IWebElement)elements(locator2)).Build().Perform();
        }
        public void dragAndDropElement(By locator1, By locator2)
        {
            action.DragAndDrop(element(locator1), element(locator2)).Build().Perform();
        }
        public void simple()
        {
            dragAndDropElement((By)dragMe, (By)dropHere);
        }
        public String getText()
        {
            return text.Text;
        }
        public void acceptableDragAndDrop()
        {
            dragAndDropElement((By)acceptable, (By)acceptDrop);
        }
        public void notAcceptableDragAndDrop()
        {
            dragAndDropElement((By)notAcceptable, (By)acceptDrop);
        }
        public void outerDroppable(int i)
        {
            dragAndDropWebElements((By)dragBox, (By)chooseOuterDroppable, 0, i);
        }
        public void innerDroppable(int i)
        {
            dragAndDropWebElements((By)chooseInnerDroppable, (By)dragBox, i, 0);
        }
        public void willRevertDraggable()
        {
            dragAndDropElement((By)willRevert, (By)revertDrop);
        }
        public void notRevertDraggable()
        {
            dragAndDropElement((By)notRevert, (By)revertDrop);
        }
    }
}
