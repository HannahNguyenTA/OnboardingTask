Feature: Language Tests

Scenario: 1 Verify user is able to add a new language
  Given user login Mars
  When user add a new language
  Then new language is added successfully

Scenario: 2 Verify user is able to cancel update language
  Given user login Mars
  When user cancel update language
  Then update language is cancelled successfully

Scenario: 3 Verify user is able to update language
   Given user login Mars
   When user update language
   Then language is updated successfully

Scenario: 4 Verify user is able to delete language
   Given user login Mars
   When user delete language
   Then language is deleted successfully


  

