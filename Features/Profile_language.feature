Feature: Profile_Language
	Seller can add language and delete

@mytag
Scenario: Add language
	Given click to the language button and new add
	When filled the data
	Then validation

	@mytag
Scenario: Edit language
	Given click to the Edit language button 
	When filled the data to the edit
	Then validation to the edit
	@mytag

Scenario: Delete language
	Given click to the language button
	When Click the delete button
	Then validation to the delete