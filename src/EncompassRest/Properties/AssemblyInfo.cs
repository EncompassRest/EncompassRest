using System;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]

// Release assemblies should be signed
[assembly: InternalsVisibleTo("EncompassRest.Tests")]