Feature: Newaccount

@mytag
Scenario: Create a new account
	Given I am in HomePage for NewAccount
	When I select Signin
	And I enter an email address
	And I fill the new account form
	Then I verify the success message for a new account