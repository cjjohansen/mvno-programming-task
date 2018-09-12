Feature: Rate CallConsumption
	In order to rate total monthly fee for a subsciption
	As a rating System
	I want to rate the price for a single Call CallConsumption

@Rating
Scenario: Rate CallConsumption
	Given I have a CallConsumption with a duration of 600 seconds
	And I have a CallRating with a unitSize of 60 seconds and a unitprice of 0.25 kr pr minute
	When The rating is triggered
	Then the rating result should be 2.5 kr
