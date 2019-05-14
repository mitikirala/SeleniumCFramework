Feature: Extend Permit
	

@mytag
Scenario: Extending the time for the  existing permit 

    Given User Navigates to the ReceiverOptionsPage from Receviers Modal
	And Select Change an Active or Exempt Permit option
	And Search PermitNumber and Highlight your permit
	And click on the ExtendPermit Icon
	And Saves the Permit 
	And Verify the Message that the permit is extended.

	

