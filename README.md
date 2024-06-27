# scopic-task

## Task 1 & 2
You could find task 1 & 2 in this repo, there are 2 classes under Test folder

## Task 3
### a) Test cases
| TestNo  | Component / Functionality |  Test Summary                             | Pre-conditions                     | Steps                                          |  Expected    | Post-conditions |
| ------- | ----------------------- |   --------------------------------------- | --------------                     | ---------------------------------------------- | -----------  | --------------- |
| 1       | Sign Up                 |   Sign up with invalid inputs             |                                    |  <ol><li>Access sign up page</li><li>Proceed without providing any input</li><li>Proceed with inputs that dont meet the requirements. Repeat this step to each input (Name, Phone/Email, Password, Confirm Password)</li></ol>       |   <ul><li>At step 2, not allow to proceed and show waring on required fields</li><li>At step 3, not allow to proceed and show warning on the field that does not meet requirements</li></ul>             |               |                  
| 2       | Sign Up                 |   Sign up with email existing in system   | Sign up successfully an account    |    <ol><li>Access sign up page</li><li>Enter valid name</li><li>Enter email that used in Pre-conditions</li><li>Enter valid Password and Confirm Password</li><li>Click continue</li></ol>        |      Not allow to proceed and inform user that email is being used         |      Remove account (if possible)           |



### b) Bugs
Bug 1 (real bug):
```
Description: [SignUp] Internal Error when signing up new user from AP
Priority: High
Environment: https://www.amazon.com/ap/register
Steps to reproduce:
1. Access Amazon website from AP region
2. Sign up new user
3. Input as below:
Name = A
Email = dfjhglksjdfhjkg54867034876@yopmail.com
Password = 123456
Re-enter password = 123456
4. Click verify email button

Issue: There is Internal Error message shown
<provide images of evidence>

Expected: should be able to sign up as input meets AMZ requirements
```
Bug 2 (hypothetical bug):
```
Description: [Login] Unable to login after sign up successfully
Priority: Critical
Environment: https://www.amazon.com/ap/signin

Preconditions: Successfully sign up new account
Steps to reproduce:
1. Access Amazon website
2. Click Sign In button
3. Input credential (email/phone) as prepared in Preconditions
4. Click Continue

Issue: Error: "We cannot find an account with that email address"
<provide images of evidence>

Expected: should be able to login as user signed up successfully

```

## Task 4
I'm using C# to develop a solution that can automate both browser and api (by using Nunit + WebDriver and Restsharp libs).
The benefit of this approach is that we have all in one solution:
- 1 solution can perform test on different application types
- share test report engine
- integrate with CI/CD easily

I'd follow this priority to apply AT to application: unit test > api test > ui test
