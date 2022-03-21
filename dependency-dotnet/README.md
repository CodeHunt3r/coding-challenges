# Backend Coding Challenge: Module Dependency Challenge

### ProjectStructure
This ASP.NET Core solution consists of three projects (the main application, `Notification` and `Inquiry`).
The `Notification`-project depends on the `Inquiry`-project. The application depends on both and serves the main ASP.NET entry point.

The `InquiryTest` calls `InquiryService#create(Inquiry)` and checks wether the methods `EmailHandler#sendEmail(Inquiry)`
and `PushNotificationHandler#sendNotification` have been called with the same parameters.

### Acceptance Criteria: 
- After an Inquiry has been created, `EmailHandler#sendEmail(Inquiry)` and `PushNotificationHandler#sendNotification` have to be executed
- the `InquiryTest` has to be successful
 
### general conditions:
- the classes `Inquiry` shall not be modified
- the existing classes shall not be moved between the modules
- the dependencies between the modules shall not be customized
- Any other NuGet dependencies can be added
- In case there are neccessary modifications to the test, these require explanation