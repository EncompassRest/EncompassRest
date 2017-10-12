# EncompassRest .NET Library Guidelines
* [.NET API](#net-api)
* [Source Code Style](#source-code-style)
* [Pull Requests](#pull-requests)

## .NET API
### General
* Only publically expose types and methods that clients need access to.
* Default classes as sealed.
* Exposed Encompass API's should support both .NET object and raw json methods.
* Exposed Encompass API's should support a `CancellationToken` in a method overload.
* Consider making the .NET API similar to the SDK when applicable.
* Consider thread-safety.
* Never create public fields.

### Naming
* Namespace naming should follow the Encompass API Paths.
* Method names should follow the naming in Encompass Developer Connect.
* Interface names should begin with I and follow pascal casing after that.
* Type and non-field member names should follow pascal casing.
* Any `Task` returning methods' names should end with `Async`.
* Static field names should begin with s_ and follow camel casing after that.
* Instance field names should begin with _ and follow camel casing after that.
* Parameter names and local variables should follow camel casing.

## Source Code Style
### General
* Never qualify member access with `this.` except when necessary.
* Always use `C#` type aliases, e.g. `string` instead of `String`.
* Always prefer to use `var` when possible.
* Always include code block braces.
* Always prefer object and collection initializers.
* Always prefer expression bodied members when reasonable.
* Always prefer auto properties when possible.
* Always use using directives when possible to reduce specifying full type names.
* Always use using statements to automatically dispose of `IDisposable` objects.
* Code should be async throughout, no uses of blocking code such as `Task.Result` or `Task.Wait` as they can cause deadlocks in consumer code.
* All uses of the `await` keyword should have a trailing `.ConfigureAwait(false)` applied to the `Task` for better performance.
* Only apply the `async` keyword to methods when necessary. If you're just return awaiting a `Task` of the same type as the return type from another method then the `async` keyword is unnecessary.

### Formatting
* Always use 4 spaces for indentation.
* Never include 2 consecutive empty lines.
* Never start or end a type or method's body with an empty line.
* Always separate single line argument or parameter list items with just a comma and space.
* Never start or end an argument or parameter list with a space. i.e. there should be no space between the parentheses and the list.
* Always include a single blank line between type members except for fields.

## Pull Requests
* Every code change pull request needs to have at least one review by a core member prior to being merged.
* Every code change pull request should include unit tests to ensure they work properly.
