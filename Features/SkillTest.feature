Feature: Skill Tests

Scenario: 1 Verify user is able to add a new skill
  Given user login Mars 1
  When user add a new skill
  Then new skill is added successfully

Scenario: 2 Verify user is able to cancel update skill
  Given user login Mars 1
  When user cancel update skill
  Then update skill is cancelled successfully

Scenario: 3 Verify user is able to update skill
   Given user login Mars 1
   When user update skill
   Then skill is updated successfully

Scenario: 4 Verify user is able to delete skill
   Given user login Mars 1
   When user delete skill
   Then skill is deleted successfully


  

