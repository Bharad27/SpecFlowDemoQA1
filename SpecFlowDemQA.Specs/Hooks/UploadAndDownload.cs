using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class UploadAndDownload
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public UploadAndDownload(IWebDriver webDriver)
        {
            webDriver = webDriver;
        }

        public IWebElement uploadAndDownload => webDriver.FindElement(By.XPath("//span[text()='Upload and Download']"));
        public IWebElement uploadAndDownloadDownload => webDriver.FindElement(By.Id("downloadButton"));
        public IWebElement uploadAndDownloadUpload => webDriver.FindElement(By.Id("uploadFile"));
        public IWebElement fileUploadedTxt => webDriver.FindElement(By.Id("uploadedFilePath"));

        public void CLickUploadAndDownload() => uploadAndDownload.Click();

        public WebElement getUploadAndDownloadDownload()
        {
            return (WebElement)webDriver.FindElement((By)uploadAndDownloadDownload);
        }

        public WebElement getUploadAndDownloadUpload()
        {
            return (WebElement)webDriver.FindElement((By)uploadAndDownloadUpload);
        }

        public void uploadAndDownloadDownloadClick()
        {
            getUploadAndDownloadDownload().Click();
        }

        public void uploadAndDownloadUploadCLick()
        {
            getUploadAndDownloadUpload().Click();
        }

        public void uploadFile(String path)
        {
            getUploadAndDownloadUpload().SendKeys(path);
        }

        public String uploadedFileGetTxt()
        {
            return webDriver.FindElement((By)fileUploadedTxt).Text;
        }
    }
}
