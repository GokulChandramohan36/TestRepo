Feature: AlertsAndWindows



@broserWindow
Scenario: Validate new tab
	Given I am in the Home Page
	When I click on AlertFramesWindows Page
	And I see list of elements in the AlertFramesWindows Menu
	When I click on browser windows 
	And I see all the available browser action buttons
	When I click on new tab button
	Then I see new tab open 

@Alerts
Scenario: Validate Alerts
	Given I am in the Home Page
	When I click on AlertFramesWindows Page
	And I see list of elements in the AlertFramesWindows Menu
	When I click on Alerts 
	Then I validate the Alert dialogs



	
