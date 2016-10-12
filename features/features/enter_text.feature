Feature: Enter Text
  The text should be entered in the Entry and the entered text should appear as a Label

  Scenario: Entering text should make it appear on the screen
    Given I am on the main page
    When I enter "Hello World" in the entry
    Then I see "Hello World" in the label
