Feature: SpecFlowFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Create a New SWP
	Given User Navigates to the PMSearchPage from Receviers Modal
	And User enters a <PMNumber>
	When  no results are retrived user clicks on MyPermitisNotListed
	When User Submits the Task Details
	Then A permit is created with status New Permit




	Examples:

	| PMNumber |
	| 831 |