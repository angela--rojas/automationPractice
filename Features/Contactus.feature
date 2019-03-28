Feature: Contactus
	

@mytag
Scenario: Fill contact Us Form and Send a message
	Given I am in HomePage
	When I select Contactus
	And I fill the form
	Then I verify the success message