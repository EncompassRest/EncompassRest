# EncompassRest
Encompass API Client Library for .NET

To get started create a client object within an async method
```c#
using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync("apiClientId", "apiSecret", "encompassInstance", "encompassUserId", "encompassPassword"))
{
    // use client
}
```