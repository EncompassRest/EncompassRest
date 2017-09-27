# EncompassRest .NET Library Guidelines
## Source Code Style
### General
* Never qualify member access with `this.` except when necessary.
* Always use `C#` type aliases, e.g. `string` instead of `String`.
* Always prefer to use `var` when possible.
* Always include code block braces.
* Always prefer object and collection initializers.
* Always prefer expression bodied members when practical.
* Never create public fields.
* Always prefer auto properties when possible.
* Always use using statements when possible to reduce specifying full type names.
* Code should be async throughout, no uses of blocking code such as `Task.Wait` as they can cause deadlocks in consumer code.
* All uses of the `await` keyword should have a trailing `.ConfigureAwait(false)` applied to the `Task` for better performance.
* Only apply the `async` keyword to methods when necessary. If you're just returning a `Task` of the same type as the return type from another method then the `async` keyword is unnecessary.

### Formatting
* Always use 4 spaces for indentation.
* Never include 2 consecutive blank lines.
* Always separate single line argument or parameter list items with just a comma and space.

### Naming
* Iterface names should begin with I and follow pascal casing after that.
* Type and non-field member names should follow pascal casing.
* Any `Task` returning methods' names should end with `Async`.
* Static field names should begin with s_ and follow camel casing after that.
* Instance field names should begin with _ and follow camel casing after that.
* Parameter names and local variables should follow camel casing.
