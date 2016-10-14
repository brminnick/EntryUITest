Given(/^I am on the main page$/) do
   main_page = "* marked:'Main Page'"
   wait_for_element_exists(main_page) 
   screenshot()
end

When(/^I enter "Hello World" in the entry$/) do
  entry = "* marked:'MyEntry'"
  wait_for_element_exists(entry)
  touch(entry)
  screenshot()
  clear_text(entry)
  wait_for_keyboard
  keyboard_enter_text("Hello World")
  query "textField isFirstResponder:1", :resignFirstResponder
  screenshot()
end

Then(/^I see "Hello World" in the label$/) do
  label="* marked:'MyLabel'"
  wait_for_element_exists(label)
  labelText = query(label, :text).first
  screenshot_and_raise("Label Text Incorrect") if labelText != "Hello World"
end