# EncompassAPI
Encompass API Client and Service Library for .Net Standard 2.0 and .Net Standard 2.1.

## Why does this exist?
This is a fork of the EncompassRest Library found here [Encompass Rest](https://github.com/EncompassRest/EncompassRest).

This fork is intended to centralize HttpClient management using the new features available to .Net Core 2.1+ while providing the same feature set as the original library.

New features in the upstream branch will be evaluated for inclusion but due to the altered dependency structure further changes are expected.

### EncompassApiService
Encompass Api Service is a new class that has the same functionality as the now deprecated EncompassRestClient (EncompassApiClient after rename in this fork), but built to use the IOptions pattern and MS ServiceCollection Dependency injection to manage the HttpClient, TokenHander, and various configurations for logging and content encoding.

### Get Started
Create an `EncompassTokenClientOptions` object. and populate all values. This has been built to follow the IOptions pattern if you so choose.

Pass your `EncompassTokenClientOptions` object into the `AddEncompassTokenHandlerWithRetry` extension method (Note: this method name will be changed in an upcoming release).

```cs
builder.Services.AddEncompassTokenHandlerWithRetry(encompassTokenClientOptions);
```

This will add your `IOptions EncompassTokenClientOptons` dependency, a `TokenHandler` for direct calls to Encompass, as well as a default retry and timeout policy for the embedded `HttpClient`.

### Advanced Configuration
Additional `HttpClientBuilderExtensions`, and `ServiceCollectionExtensions` have been included for more granular configuration of `EncompassApiService` dependencies.

```cs
 builder.Services
    .AddEncompassHttpClient(
    options =>
    {
        options.CompressionOptions = new HttpClientCompressionHandlerOptions()
        {
            DecompressionMethods = new DecompressionMethods[] { DecompressionMethods.GZiDecompressionMethods.Deflate },
            EnableAutoDecompression = true
        };
        options.ClientParameters = clientParameters;
        options.TokenClientOptions = encompassTokenClientOptions;
    },
    config =>
    {
        config.BaseAddress = new Uri(encompassTokenClientOptions.BaseUrl);
    })
    .AddEncompassTokenMessageHandler()
    .AddEncompassHttpResponseHeaderLoggingHandler()
    .AddEncompassRetryPolicyHandler()
    .AddEncompassTimeoutPolicyHandler()
    .Build(builder.Services);
```

### Upcoming features
* Refactored unit tests using Mocked message handlers for Mock results
* Separation of client managed dependencies into a client package to remove added dependencies on Polly to separate
* Documentation for usage of EncompassApiService
* Concurrency and Rate Limit throttling via HttpMessageHandlers

## Resources
* [Developer Connect](https://docs.developer.elliemae.com/reference) - Encompass API's reference location.

