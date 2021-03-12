# EncompassAPI
Encompass API Client and Service Library for .Net Standard 2.0 and .Net Standard 2.1.

## Why does this exist?
This is a fork of the EncompassRest Library found here [Encompass Rest](https://github.com/EncompassRest/EncompassRest).

This fork is intended to centralize HttpClient management using the new features available to .Net Core 2.1+ while providing the same feature set as the original library.

New features in the upstream branch will be evaluated for inclusion but due to the altered dependency structure further changes are expected.

### Upcoming features
* Extension methods for easy inclusion of EncompassApiService in ServiceCollection DI container on application startup.
* Refactored unit tests using Mocked message handlers for Mock results
* Token HttpMessageHandlers for authentication using all authentication mechanisms available to Encompass integrations. (Current Token Handler is custom and internal to Fairway Mortgage)
* Separation of client managed dependencies into a client package to remove added dependencies on Polly to separate
* Documentation for usage of EncompassApiService
* Concurrency and Rate Limit throttling via HttpMessageHandlers

### EncompassApiService

In your startup.cs add EncompassApiService for IEncompassRestClient dependency. Currently you will need to inject a custom HttpMessageHandler for Encompass token management. For retry you can also provide Polly policy/messageHandler for management of retry.

EncompassApiService can then be injected into needed classes.

## Resources
* [Developer Connect](https://docs.developer.elliemae.com/reference) - Encompass API's reference location.

