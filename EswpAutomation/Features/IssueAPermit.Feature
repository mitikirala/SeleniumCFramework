Feature: Issuing a Permit---change to push to git
	

@mytag
Scenario Outline: Issuing a permit
    Given User Navigates SWP Modal
	And Select the New permit Task with <PermitNumber>
	And enters the details for work, harardeous materials and permit 
	And Issues the permit.


	Examples:

	| PermitNumber |
	| 937|


	





