Feature: US0002 Edit my profile
	As a customer
	I want to edit my profile
	So that I can update my information

Scenario: Edit profile
	Given the user is in the Edit User view
	When enters the information to change <description>
	And the user clicks save
	Then the system update user information

	Examples: 
	| description |
	| e ir al cine con mis amigos |