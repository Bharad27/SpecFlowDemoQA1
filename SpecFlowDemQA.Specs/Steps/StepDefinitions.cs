using DocuSign.eSign.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemQA.Specs.Hooks;
using System;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using Xunit;
using SpecFlowDemoQA;
using System.Threading;
using System.Collections;
using iRely.Common;

namespace SpecFlowDemQA.Specs.Steps
{
    [Binding]
    public sealed class StepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        
        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        TextBox TextBox;
        CheckBox CheckBox;
        WebTable WebTable;
        Buttons Buttons;
        Login Login;
        BrowserWindow BrowserWindow;
        UploadAndDownload UploadAndDownload;
        Alerts Alerts;
        AutoComplete AutoComplete;
        DatePicker DatePicker;
        ToolTip ToolTip;
        Sortable Sortable;
        Droppable Droppable;
        IWebDriver webDriver = new ChromeDriver();
        
        [Given("I am on the DemoQA homepage")]
        public void GivenIAmOnTheDemoQAHomepage()
        {
            
            webDriver.Navigate().GoToUrl("https://demoqa.com/");
            TextBox = new TextBox(webDriver);
        }

        [Then("I click on (.*)")]
        public void ThenIClickOn(string value)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            switch (value)
            {
                case "Elements":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(TextBox.Elements));
                    TextBox.ClickElements();
                    break;
                case "TextBox":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(TextBox.Textbox));
                    TextBox.ClickTextBox();
                    break;
                case "CheckBox":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(CheckBox.Checkbox));
                    CheckBox.CLickChecbox();
                    break;
                case "WebTable":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(WebTable.webtable));
                    WebTable.CLickWebtable();
                    break;
                case "Button":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Buttons.button));
                    Buttons.CLickButton();
                    break;
                case "UploadAndDownload":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadAndDownload.uploadAndDownload));
                    UploadAndDownload.CLickUploadAndDownload();
                    break;
                case "BookStoreApplication":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Login.BookStoreApplication));
                    Login.clickBookStoreApplication();
                    break;
                case "Login":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Login.login));
                    Login.ClickLogin();
                    break;
                case "AlertsFramesAndWindows":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BrowserWindow.AlertFrameAndWindow));
                    BrowserWindow.clickAlertFrameAndWindow();
                    break;
                case "BrowserWindow":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BrowserWindow.browserWindow));
                    BrowserWindow.clickBrowserWindow();
                    break;
                case "Alerts":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Alerts.alerts));
                    Alerts.clickAlerts();
                    break;
                case "Widgets":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AutoComplete.Widgets));
                    AutoComplete.clickWidgets();
                    break;
                case "AutoComplete":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AutoComplete.autocomplete));
                    AutoComplete.clickAutoComplete();
                    break;
                case "DatePicker":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DatePicker.datepicker));
                    DatePicker.clickDatePicker();
                    break;
                case "ToolTip":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ToolTip.tooltip));
                    ToolTip.clickToolTip();
                    break;
                case "Interactions":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Sortable.interactions));
                    Sortable.clickInteractions();
                    break;
                case "Sortable":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Sortable.sortable));
                    Sortable.clickSortable();
                    break;
                case "Droppable":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Droppable.droppable));
                    Droppable.clickDroppable();
                    break;
                case "Submit":
                    TextBox.ClickSubmit();
                    break;
                default:
                    break;
            }
            
        }

        [Then("Enter the (.*)")]
        public void ThenEnterThe(string Value)
        {
            switch (Value)
            {
                case "FullName":
                    TextBox.FullName.SendKeys("Bharadwaj Murki");
                    break;
                case "Email":
                    TextBox.FullName.SendKeys("abc@gmail.com");
                    break;
                case "CurrentAddress":
                    TextBox.FullName.SendKeys("HYD, Telangana");
                    break;
                case "PermanentAddress":
                    TextBox.FullName.SendKeys("HYD, Telangana - 500001");
                    break;
                default:
                    break;

            }
        }

        [Then("Verify the below details")]
        public void VerifyTheBelowDetails()
        {
            NUnit.Framework.Assert.That(TextBox.isOutputExist(), Is.True);
        }

        [Then("Verify the selected items")]
        public void VerifyTheSelectedItems()
        {
            CheckBox.expandHome();
            CheckBox.expandUnderHome();
            Thread.Sleep(2000);
            CheckBox.expandUnderDocuments();
            CheckBox.expandUnderDownloads();
            CheckBox.checkBoxClick();
            Thread.Sleep(2000);
            foreach (IWebElement web in CheckBox.getAllResults())
            {
                if (!CheckBox.resultText().Contains(web.Text))
                {
                    Console.WriteLine("Fail");
                }
            }
        }

        [Then("Edit the contents of webtable")]
        public void EditTheContents()
        {
            ArrayList allFields = new ArrayList(webDriver.FindElements((By)WebTable.webTablesField));
            WebTable.webTablesEditRecordOne();
            WebTable.getWebTablesUsername().Clear();
            WebTable.webTablesFillUserName("Anne");
            WebTable.webTablesSubmitForm();
            NUnit.Framework.Assert.AreEqual(allFields[0], "Anne");
        }

        [Then("Change the Table row")]
         public void TestTableRowsChange()
        {
            ArrayList allFields = new ArrayList(webDriver.FindElements((By)WebTable.webTablesField));
            WebTable.webTablesDropdownMenu(4);
            Xunit.Assert.Equal(350, allFields.Count);
        }

        [Then("Jump to the next page")]
        public void testJumpTables()
        {
            WebTable.WebTablesJumpPage("3");
        }

        [Then("Delete the record")]
        public void testDeleteRecord()
        {
            ArrayList allFields = new ArrayList(webDriver.FindElements((By)WebTable.webTablesField));
            String firstNameInTheTable = (string)allFields[0];
            WebTable.webTablesDeleteRecordOne();
            NUnit.Framework.Assert.AreEqual(allFields[0], firstNameInTheTable);
        }

        [Then("Add the record")]
        public void testAddRecord()
        {
            ArrayList allFields = new ArrayList(webDriver.FindElements((By)WebTable.webTablesField));
            WebTable.webTablesAddRecordFill();
            WebTable.webTablesFillUserName("Name");
            WebTable.webTablesFillLastName("Lastname");
            WebTable.webTablesFillEmail("email@email.com");
            WebTable.webTablesFillAge("32");
            WebTable.webTablesFillSalary("1200");
            WebTable.webTablesFillDepartment("Department");
            WebTable.webTablesSubmitForm();
            WebTable.webTablesSearch("Name");
            NUnit.Framework.Assert.AreEqual(allFields[0], "Name");
        }

        [Then("Perform the button actions")]
        public void PerformTheButtonActions()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            Buttons.buttonsDoubleClickAction();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("doubleClickMessage")));
            NUnit.Framework.Assert.That(webDriver.FindElement(By.Id("doubleClickMessage")).Displayed);
            Buttons.CLickButton();
            Buttons.buttonsRightClickAction();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("rightClickMessage")));
            NUnit.Framework.Assert.That(webDriver.FindElement(By.Id("rightClickMessage")).Displayed);
            Buttons.CLickButton();
            Buttons.buttonsClickMeAction();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("dynamicClickMessage")));
            NUnit.Framework.Assert.That(webDriver.FindElement(By.Id("dynamicClickMessage")).Displayed);
        }

        [Then("Verify the Upload Download Files")]
        public void VerifyUpladAndDownload()
        {
            UploadAndDownload.uploadAndDownloadDownloadClick();
            UploadAndDownload.uploadFile("C:\\Users\\Bharadwaj.Murki\\Downloads\\sampleFile.jpeg");
            NUnit.Framework.Assert.That(UploadAndDownload.uploadedFileGetTxt() != null);
        }

        [Then("Enter username and password and the submit")]
        public void testLogin()
        {
            Login.bookStoreUserNameFill("ImePrezimenkovic");
            Login.bookStorePasswordFill("Sifra12345!");
            Login.bookStoreSubmitButtonClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            NUnit.Framework.Assert.AreEqual(webDriver.Url, "https://demoqa.com/profile");
        }

        [Then("Verify the New Tab Window")]
        public void newTabWindowTest()
        {
            BrowserWindow.click_new_tab();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            BrowserWindow.click_new_tab();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
        }

        [Then("Verify the New Window")]
        public void newWindowTest()
        {
            BrowserWindow.click_new_window();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
            webDriver.Manage().Window.Maximize();
            NUnit.Framework.Assert.Equals(BrowserWindow.returnNewWindowTitle(), "This is a sample page");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            BrowserWindow.click_new_window();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[2]);
        }

        [Then("Verify the New Window Message")]
        public void newMessageTest()
        {
            BrowserWindow.clickNewMessage();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);
        }

        [Then("Verify the On button click prompt box will appear")]
        public void alertButtonsTests()
        {
            Alerts.clickpromptbutton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Alerts.enterPromptData("Bharadwaj");
            webDriver.SwitchTo().Alert().Accept();
            NUnit.Framework.Assert.Equals(Alerts.promptResultResponse(), "You entered Natasha");
        }

        [Then("Verify Multi colour names")]
        public void autocompleteMultipleColorTest()
        {
            AutoComplete.enterAutoMultipleColors("Red");
            AutoComplete.enterAutoMultipleColors("Blue");
            AutoComplete.enterAutoMultipleColors("Green");
        }

        [Then("Verify Single colour names")]
        public void autocompleteSingleColorTest()
        {
            AutoComplete.enterSingleColor("Black");
        }

        [Then("Verify for Select date")]
        public void selectDateTest()
        {
            DatePicker.selectDate("10/01/2021");
        }

        [Then("Verify for Date and Time")]
        public void dateAndTime()
        {
            DatePicker.enterDateAndTime("September 1,2021 8:35 AM");
        }

        [Then("Verify Mouse Hoverover")]
        public void toolTipsPageTest()
        {
            ToolTip.hoverMeToSeeButton();
            NUnit.Framework.Assert.Equals(ToolTip.assertionHoverButtonText(), "Hover me to see");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ToolTip.hoverMeToSeeTextField();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ToolTip.hoverTheChosenLink("Contrary");
            NUnit.Framework.Assert.Equals(ToolTip.assertionHoverLink(0), "Contrary");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ToolTip.hoverTheChosenLink("1.10.32");
            NUnit.Framework.Assert.Equals(ToolTip.assertionHoverLink(1), "1.10.32");
        }

        [Then("Sort the list in descending order")]
        public void sortDesc()
        {
            Sortable.dragAndDropASCAndDESC(0);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Sortable.dragAndDropASCAndDESC(5);
        }

        [Then("Verify the simple drag and drop action")]
        public void droppablePageSimpleMenu()
        {
            Droppable.simple();
            NUnit.Framework.Assert.Equals(Droppable.getText(), "Dropped!");
        }

        [Then("Verify the Accept drag and drop action")]
        public void acceptMenuAcceptable()
        {
            Droppable.chooseDroppableMenu("Accept");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Droppable.acceptableDragAndDrop();
            NUnit.Framework.Assert.Equals(Droppable.getText(), "Dropped!");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Droppable.notAcceptableDragAndDrop();
        }

        [Then("Verify the Prevent Propagation drag and drop action")]
        public void preventPropogationMenu()
        {
            Droppable.chooseDroppableMenu("Prevent Propogation");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Droppable.outerDroppable(1);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Droppable.innerDroppable(1);
        }

        [Then("Verify the Revert Draggable drag and drop action")]
        public void revertDraggableMenu()
        {
            Droppable.chooseDroppableMenu("Revert Draggable");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Droppable.willRevertDraggable();
            NUnit.Framework.Assert.Equals(Droppable.getText(), "Dropped!");
            Droppable.notRevertDraggable();
            NUnit.Framework.Assert.Equals(Droppable.getText(), "Dropped!");
        }
    }
}
