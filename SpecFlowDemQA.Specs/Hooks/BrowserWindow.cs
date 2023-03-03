using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class BrowserWindow
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public BrowserWindow(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement AlertFrameAndWindow => WebDriver.FindElement(By.XPath("//div[text()='Alerts, Frame & Windows']"));
        public IWebElement browserWindow => WebDriver.FindElement(By.XPath("//span[text()='Browser Windows"));
        public IWebElement alerts => WebDriver.FindElement(By.XPath("//*[@class=\"element-list collapse show\"]/ul/li"));
        public IWebElement newTab => WebDriver.FindElement(By.Id("tabButton"));
        public IWebElement newWindow => WebDriver.FindElement(By.Id("windowButton"));
        public IWebElement newWindowMessage => WebDriver.FindElement(By.Id("messageWindowButton"));
        public IWebElement title => WebDriver.FindElement(By.Id("sampleHeading"));

        public void clickAlertFrameAndWindow() => AlertFrameAndWindow.Click();
        public void clickBrowserWindow() => browserWindow.Click();

        public void click_new_tab()
        {
            newTab.Click();
        }

        public void click_new_window()
        {
            newWindow.Click();
        }
        public String returnNewWindowTitle()
        {
            return title.Text;
        }

        public void clickNewMessage()
        {
            newWindowMessage.Click();
        }

        public ArrayList get_all_tabs()
        {
            return new ArrayList(webDriver.());
        }
    }
}
