Feature: Login

@mytag
Scenario: Sign in
	Given I am in HomePage for Login
	When I select Signin button
	And I fill the login form
	Then I verify the success message for Login
