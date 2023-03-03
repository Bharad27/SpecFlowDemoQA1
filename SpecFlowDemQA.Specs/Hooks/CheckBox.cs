using OpenQA.Selenium;
using System;
using System.Collections;

namespace SpecFlowDemoQA
{
    public class CheckBox
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public CheckBox(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement Checkbox => WebDriver.FindElement(By.XPath("//span[text()='Check Box']"));
        public IWebElement home => WebDriver.FindElement(By.XPath("//*[@class='rct-text']/button"));
        public IWebElement underHome => WebDriver.FindElement(By.XPath("//*[@id='tree-node']/ol/li/ol/li/span/button"));
        public IWebElement underDocuments => WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[3]/span/button"));
        public IWebElement underDownloads => WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[2]/span/button"));
        public IWebElement checkbox => WebDriver.FindElement(By.ClassName("rct-checkbox"));
        public IWebElement response => WebDriver.FindElement(By.ClassName("text-success"));
        public IWebElement message => WebDriver.FindElement(By.Id("result"));
        public IWebElement title => WebDriver.FindElement(By.ClassName("rct-title"));

        public ArrayList GetAllNames()
        {
            ArrayList names = new ArrayList(WebDriver.FindElements((By)title));
            return names;
        }

        public String resultText()
        {
            return webDriver.FindElement((By)message).Text;
        }

        public ArrayList getAllResults()
        {
            ArrayList results = new ArrayList(WebDriver.FindElements((By)response));
            return results;
        }

        public void expandHome() => home.Click();

        public void expandUnderHome() => underHome.Click();

        public void expandUnderDocuments() => underDocuments.Click();

        public void expandUnderDownloads() => underDownloads.Click();

        public void checkBoxClick() => checkbox.Click();

        public void CLickChecbox() => Checkbox.Click();

    }
}
