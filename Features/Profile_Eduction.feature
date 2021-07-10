Feature: Profile_Eduction
	Simple calculator for adding two numbers

@mytag
Scenario: Add Education
	Given click to the Education button and new add
	When filled the data to the Education
	Then validation to the Education

	@mytag
Scenario: Edit Education
	Given click to the Edit Education button 
	When filled the data to the edit to the Education
	Then validation to the edit Education
	@mytag

Scenario: Delete Education
	Given click to the language Education button
	When Click the delete Education button 
	Then validation to the delete Education