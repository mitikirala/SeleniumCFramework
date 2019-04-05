Feature: Creating A New Work Permit
	

@mytag
Scenario Outline: Create a New SWP

    Given User Navigates to the PMSearchPage from Receviers Modal
	And User enters a <PMNumber>
	When  no results are retrived user clicks on MyPermitisNotListed
	When User Submits the Task Details
	Then A permit is created with status New Permit


	Examples:

	| PMNumber |


	| 884|



