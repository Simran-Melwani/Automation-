Feature: Feature1

Appointment Making
@Functional
Scenario: Make a appointment

	Given the url open
	When Make Apointment button is clicked
	Then validate the login message
	Given the username
	And the password
	When Click on login button
	Then validate the login assertion
	Given the Faculty
	When readmission clicked
	And Radio button for healtyCare
	And visit date
	And comment added
	And bookapointment button clicked
	Then verifiaction final
