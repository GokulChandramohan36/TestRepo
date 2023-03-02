Feature: Widgets

A short summary of the feature

@AutoComplete
Scenario Outline: Validate new tab
	Given I am in the Home Page
	When I click on the widgets link
	Then I see the list of elements in widget menu
	When I click on Auto Complete Page
	Then I see auto complete search boxes 
	And I verify the Multiple search boxes using "<Value1>" and "<Value2>"
	And I verify the single search Box using "<Value3>"


	Examples: 

	| Value1 | Value2 | Value3 |
	| White  | Black  | Violet |




@datePicker
Scenario Outline: Validate date picker
    Given I am in the Home Page
	When I click on the widgets link
	Then I see the list of elements in widget menu
	When I click on datePicker page
	Then I set the date in the datepicker using "<Month>" "<Year>" "<Date>"


	Examples: 
    | Month   | Year | Date |
    | January | 2050 | 3   |





	
