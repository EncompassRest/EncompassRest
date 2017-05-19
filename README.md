# EncompassRest
Encompass API Client Library for .NET

To get started create a client object
```c#
var client = await EncompassRestClient.CreateFromUserCredentialsAsync([API_ClientID], [API_Secret], [Encompass_Instance], [Encompass_UserID], [Encompass_Password]);
```