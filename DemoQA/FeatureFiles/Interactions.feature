Feature: Interactions

A short summary of the feature

@ListSort
Scenario: Validate the sortable functionality
    Given I am in the Home Page
	When I click on Interactions page
	Then I see Sortable page in the menu
	When I click on the Sortable page
	Then I see list of sortable items
	And I sort them all in descending order

@GridSort
Scenario: Validate the grid sortable functionality
    Given I am in the Home Page
	When I click on Interactions page
	Then I see Sortable page in the menu
	When I click on the Sortable page
	Then I click on grid
	And I sort the grid in desc order


@dragDrop
Scenario: Validate a simple drag and drop
    Given I am in the Home Page
	When I click on Interactions page
	Then I see droppable Page in the Menu
	When I click on the droppable page
	Then I validate the drag and drop functionality



