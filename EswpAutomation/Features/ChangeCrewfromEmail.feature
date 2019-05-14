Feature: Changing Crew from Email
	

@mytag
Scenario: Changing Crew for the existing permit from Receivers Portal

    Given User Navigates to dow Email Portal 
	And Selects the Email of the issued Permit having permitNumber 
	And Clicks on the link 
	And click on the ChangeCrew Icon
	And Make the changes to the crew
	And Verify the Message.