# scopic-task

## Task 1 & 2
You could find task 1 & 2 in this repo, there are 2 classes under Test folder

## Task 3
### a) Test cases




### b) Bugs
Bug 1:
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
Expected: should be able to sign up as input meets AMZ requirements
```


## Task 4
I'm using C# to develop a solution that can automate both browser and api (by using Nunit + WebDriver and Restsharp libs).
The benefit of this approach is that we have all in one solution:
- 1 solution can perform test on different application types
- share test report engine
- integrate with CI/CD easily

I'd follow this priority to apply AT: unit test > api test > ui test (automation testing pyramid)
