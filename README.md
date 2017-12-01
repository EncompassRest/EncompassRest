# EncompassRest
Encompass API Client Library for .NET Framework 4.5+ and .NET Standard 1.1+ and 2.0.

(https://github.com/EncompassRest/EncompassRest/tree/legacy). More documentation forthcoming.

NUGET:[Package](https://www.nuget.org/packages/EncompassRest)

## Getting Started
1. Download the source code from this repository and add the `EncompassRest` project file to your Visual Studio 2017 solution. This will be much simpler when the NuGet package gets published and will support older Visual Studio versions.
2. [Create an async method](#create-an-async-method) in your consuming code.
3. [Create an `EncompassRestClient` object](#create-an-encompassrestclient-object).
4. [Use `EncompassRestClient` object](#use-encompassrestclient-object) to make API calls.

### Create an async method
EncompassRest is a fully asynchronous library meaning all of it's Encompass API calls are made asynchronously to allow great performance for maximum throughput. To get started using the library you need to write an `async` method. To avoid deadlocks with async code it is recommended you **_DO NOT_** use `Task.Result` or the `Task.Wait` methods and instead implement `async` all the way from the top, e.g. `Main` or your `Controller`s actions.

#### Web apps:
```c#
public async Task<IActionResult> GetAsync()
{
    // Your async code goes here
}
```

#### Console apps:
For C#7.1 and up you should use an async `Main` method like so.

```c#
public async Task Main()
{
    // Your async code goes here
}
```

For C#7 and below you should use `Task.Run` inside of `Main` to use async methods.

```c#
public void Main()
{
    Task.Run(async () => {
        // Your async code goes here
    }).GetAwaiter().GetResult();
}
```

### Create an `EncompassRestClient` object
The `EncompassRestClient` class implements `IDisposable` so it is recommended to use `using` statements to automatically dispose of the object.

#### From User Credentials
```c#
using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync("apiClientId", "apiSecret", "encompassInstance", "encompassUserId", "encompassPassword"))
{
    // use client
}
```

#### From Authorization Code
```c#
using (var client = await EncompassRestClient.CreateFromAuthorizationCodeAsync("apiClientId", "apiSecret", "redirectUri", "authorizationCode"))
{
    // use client
}
```

#### From Access Token
```c#
using (var client = EncompassRestClient.CreateFromAccessToken("apiClientId", "apiSecret", "accessToken"))
{
    // use client
}
```

### Use `EncompassRestClient` object
Use the various properties on `EncompassRestClient` such as `Loans`, `Schema`, `Webhook`, `Pipeline`, and `BatchUpdate` to make Encompass API calls.

---

If you're interested in contributing please look over the [Guidelines Doc](Guidelines.md).
