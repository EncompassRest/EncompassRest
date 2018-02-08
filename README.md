# EncompassRest
Encompass API Client Library for .NET Framework 4.5+ and .NET Standard 1.1+.

## Why does this exist?
You may wonder why this library exists when Ellie Mae has provided their own [Encompass API .NET Language Bindings](https://github.com/EllieMae/developerconnect-dotnet-bindings).

First, the Encompass API .NET Language Bindings were released long after the API's became available so API users needed a common .NET library for consuming the Encompass API's, hence this library was born.

Secondly, the swagger generated Encompass API .NET Language Bindings are far inferior to the custom crafted and well thought-out EncompassRest library.

### More features
* Dirty checking serialization to only send back the updated data
* Option to auto retrieve new token and resend the request when using an expired token
* Option to auto resend the request on server timeouts
* Raw API calls support
* Ability to assign and retrieve string properties as enum values to reduce the need of magic strings
* .NET Standard support
* Extension data support, for when Ellie Mae adds properties to the returned json objects but the library isn't updated yet
* `CancellationToken` support
* Properties are lazily created upon gets so you don't need to new them up first to use them

### Better API
* More convenient interface with a single defined entry point, the `EncompassRestClient` object which is the equivalent of the `Session` object in the SDK
* Better named Types, e.g. `Loan` instead of `LoanContract`
* Publicly exposes only relevant .NET API
* Uses `decimal` instead of `double` to prevent precision loss

### Performs better
* Serializes directly to output `Stream` meaning no string allocation
* Reuses one `JsonSerializer` instance so it's cache isn't needed to be repopulated on each request
* `HttpClient` is in general more performant over `RestSharp`

## Getting Started
1. Install the [EncompassRest](https://www.nuget.org/packages/EncompassRest) Nuget package.
2. [Create an async method](#create-an-async-method) in your consuming code.
3. [Create an `EncompassRestClient` object](#create-an-encompassrestclient-object).
4. [Use `EncompassRestClient` object](#use-encompassrestclient-object) to make API calls.

### Create an async method
EncompassRest is a fully asynchronous library meaning all of it's Encompass API calls are made asynchronously to allow great performance for maximum throughput. To get started using the library you need to create an `async` method. To avoid deadlocks with async code it is recommended you **_DO NOT_** use `Task.Result` or the `Task.Wait` methods and instead implement `async` all the way from the top, e.g. `Main` or your `Controller`s actions.

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
The `EncompassRestClient` class implements `IDisposable` so it is recommended to use a `using` statement to automatically dispose of the object.

#### From User Credentials
```c#
using (var client = await EncompassRestClient.CreateFromUserCredentialsAsync(
    new ClientParameters("apiClientId", "apiClientSecret"),
    "encompassInstanceId", "encompassUserId", "encompassPassword"))
{
    // use client
}
```

#### From Authorization Code
```c#
using (var client = await EncompassRestClient.CreateFromAuthorizationCodeAsync(
    new ClientParameters("apiClientId", "apiClientSecret"), "redirectUri", "authorizationCode"))
{
    // use client
}
```

#### From Access Token
```c#
using (var client = EncompassRestClient.CreateFromAccessToken(
    new ClientParameters("apiClientId", "apiClientSecret"), "accessToken"))
{
    // use client
}
```

#### Auto-retrieve new token when expired
```c#
using (var client = await EncompassRestClient.CreateAsync(
    new ClientParameters("apiClientId", "apiClientSecret"),
    tokenCreator => tokenCreator.FromUserCredentialsAsync("encompassInstanceId", "encompassUserId", "encompassPassword")))
{
    // use client
}
```

### Use `EncompassRestClient` object
Use the various properties on `EncompassRestClient` such as `Loans`, `Schema`, `Webhook`, `Pipeline`, and `BatchUpdate` to make Encompass API calls.

---

## Resources
* [Developer Connect](https://docs.developer.elliemae.com/reference) - Encompass API's reference location.

If you're interested in contributing please look over the [Guidelines Doc](Guidelines.md).
