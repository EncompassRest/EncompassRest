# EncompassRest
Encompass API .NET Client Library

A MAJOR Redesign has been pushed out. The old source code is still available in the legacy branch. More documentation and a NuGet package forthcoming.

To get started create a client object within an async method
```c#
using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync("apiClientId", "apiSecret", "encompassInstance", "encompassUserId", "encompassPassword"))
{
    // use client
}
```

Compatible with .NET Framework 4.5+ and .NET Standard 1.1+.
