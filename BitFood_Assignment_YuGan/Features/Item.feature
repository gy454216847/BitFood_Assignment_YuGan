Feature: Item

Assert that the user can search for an item

@SearchItem
Scenario Outline: 1. Search for an item
	Given I am login bitfood web with <username> and <password>
	When I search an <keywords> in the search bar
	Then I should see the item in the search result
Examples:
	| username  | password   | keywords |
	| BID384964 | YuGanTest3 | cheese   |


@AddItem
Scenario Outline: 2. Add an item to the basket
	Given I am login bitfood web with <username> and <password>
	When I search an <keywords> in the search bar
	And I add item to basket
	Then I can see the item in my basket
Examples:
	| username  | password   | keywords |
	| BID384964 | YuGanTest3 | 160640   |
