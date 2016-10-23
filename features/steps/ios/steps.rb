Given(/^I am on the main page$/) do
   main_page = "* marked:'Main Page'"
   wait_for_element_exists(main_page) 
   screenshot()
end

When(/^I enter "(.*?)" in the entry$/) do |text|
  entry = "* marked:'MyEntry'"
  wait_for_element_exists(entry)
  touch(entry)
  screenshot()
  clear_text(entry)
  wait_for_keyboard
  keyboard_enter_text(text)
  query "textField isFirstResponder:1", :resignFirstResponder
  screenshot()
end

Then(/^I see "(.*?)" in the label$/) do |text|
  label="* marked:'MyLabel'"
  wait_for_element_exists(label)
  labelText = query(label, :text).first
  screenshot_and_raise("Label Text Incorrect") if labelText != text
end