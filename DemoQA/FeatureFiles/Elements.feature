Feature: Elements

Validating elements

@Home
Scenario: Verify that all the elements are present in the Menu inside Elements Page
	Given I am in the Home Page 
	When I click on the Elements Link
	And I see elements Page 
	Then I see all the elements are present in the Elements menu 


@textbox
Scenario Outline: Verify the submited details in text-box Page
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	And I click on text Box from the list
	And I enter the username as "<username>" email as "<email>" address as "<address>" permanentAddress as "<permAddress>"
	When I click on submit button 
	Then I see the submitted details as "<username>" email as "<email>" address as "<address>" permanentAddress as "<permAddress>"
	


	Examples: 
	| username | email           | address            | permAddress        |
	| user1    | user1@gmail.com | 123,street,city-07 | 123,street,city-07 |
	
	

@checkBox
 Scenario Outline: Verify the checkBox 
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	And I click on checkBox from the list 
    When I click on the values as "<value>" checkBox 
	Then I check that the result is value as "<value>"

	Examples: 
	| value |
	| Veu   |
	| Home  |


@webTables1
 Scenario Outline: Add record to the Table
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	And I click on webtables from the list
	And I see webTables page
	And I click on add new records button 
	And I enter the firstname as "<firstname>" lastname as "<lastname>" age as "<age>" email as "<email>" salary as "<salary>" department as "<dept>"
	When I click on submit 
	Then I see the record added as "<firstname>" lastname as "<lastname>" age as "<age>" email as "<email>" salary as "<salary>" department as "<dept>"


	Examples: 
	| firstname | lastname | age | email           | salary | dept  |  
	| user1     | last     | 23  | user1@gmail.com | 100000 | IT    |



 
@webTables2
 Scenario Outline: Edit a existing record in the table 
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	And I click on webtables from the list
	And I see webTables page
	And I click on edit record for the name as "<targetName>"
	And I enter the firstname as "<firstname>" lastname as "<lastname>" age as "<age>" email as "<email>" salary as "<salary>" department as "<dept>"
	When I click on submit 
	Then I see the record added as "<firstname>" lastname as "<lastname>" age as "<age>" email as "<email>" salary as "<salary>" department as "<dept>"

	Examples: 
	| firstname | lastname | age | email           | salary | dept | targetName |
	| user1     | last     | 23  | user1@gmail.com | 100000 | IT   | Alden      |


@Buttons
Scenario: Validate the buttons
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	When I click on buttons page
	Then I see all the available buttons
	And I validate all the buttons


@Download
Scenario: Validate download functionality
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	When I click on upload and download page
	Then I download the file

@Upload
Scenario: Validate upload functionality
    Given I am in the Home Page
	When I click on the Elements Link
	And I see elements Page
	When I click on upload and download page
	Then I upload the file


	




	




    
