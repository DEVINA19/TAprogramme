Feature: Feature1

As a Turnup Portal admin user
I would like to  create,edit and delete time and material records
so that i can manage employees time and materials successfully

@regression
Scenario: Create time record with valid data
	Given I logged into Turnup Portal successfully
	When I navigate to Time and Material Page]
	When I create a Time Record
	Then the record should be created successfully

