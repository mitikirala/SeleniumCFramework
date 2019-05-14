Feature: Changing Crew
	

@mytag
Scenario Outline: Changing Crew for the existing permit from Receivers Portal

    Given User Navigates to the ReceiverOptionsPage from Receviers Modal
	And Select Change an Active or Exempt Permit option
	And Search <PermitNumber> and Highlight your permit
	And click on the ChangeCrew Icon
	And Make the changes to the crew
	And Verify the Message.


	Examples:

	| PermitNumber |
	| MI thirty Seven   |

	

#Scenario: Changing Crew for the existing permit f Email