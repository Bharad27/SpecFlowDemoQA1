Feature: DemoQA UI Automation Using SpecFlow

Background: Open DemoQA Website
	Given I am on the DemoQA homepage
	Then I click on "Elements"

@textbox
Scenario: Text Box - Verification of the details post submission
	Then I click on "TextBox"
	Then Enter the "FullName"
	Then Enter the "Email"
	Then Enter the "CurrentAddress"
	Then Enter the "PermanentAddress"
	Then I click on "Submit"
	Then Verify the below details

@checkbox
Scenario: Check Box - Verification of the selected items
	Then I click on "CheckBox"
	Then Verify the selected items

@webtable
Scenario: Web Tables - Edit the contents of the Web Table
	Then I click on "WebTable"
	Then Edit the contents of webtable
	Then Change the Table row
	Then Add the record
	Then Delete the record
	Then Jump to the next page

@buttons
Scenario: Buttons - Verify the button selected by the message displayed on button click
	Then I click on "Button"
	Then Perform the button actions

@uploadanddownload
Scenario: Upload and Download - Implement logic to perform the required actions
	Then I click on "UploadAndDownload"
	Then Verify the Upload Download Files

@BookStoreApplication
Scenario: Book Store Application Login
	Then I click on "BookStoreApplication"
	Then I click on "Login"
	Then Enter username and password and the submit

@BrowserWindows
Scenario: Handle Browser Windows
	Then I click on "AlertsFramesAndWindows"
	Then I click on "BrowserWindow"
	Then Verify the New Tab Window
	Then Verify the New Window
	Then Verify the New Window Message

@Alerts
Scenario: Verify Alerts
	Then I click on "Alerts"
	Then Verify the On button click prompt box will appear

@AutoComplete
Scenario: Implement Auto Complete
	Then I click on "Widgets"
	Then I click on "AutoComplete"
	Then Verify Multi colour names
	Then Verify Single colour names

@DatePicker
Scenario: Date Picker for selected date and Date & Time
	Then I click on "DatePicker"
	Then Verify for Select date
	Then Verify for Date and Time

@ToolTip
Scenario: Validate ToolTip
	Then I click on "ToolTip"
	Then Verify Mouse Hoverover

@sortable
Scenario: Sort the list in descending order
	Then I click on "Interactions"
	Then I click on "Sortable"
	Then Sort the list in descending order

@Dropable
Scenario: Drag and Drop action validation
	Then I click on "Droppable"
	Then Verify the simple drag and drop action
	Then Verify the Accept drag and drop action
	Then Verify the Prevent Propagation drag and drop action
	Then Verify the Revert Draggable drag and drop action