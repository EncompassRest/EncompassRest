using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ElliUCDDetail
/// </summary>
public sealed partial class ElliUCDDetail : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ElliUCDDetail CDFields
    /// </summary>
    [AllowNull]
    public IDictionary<string, string?> CDFields { get => GetDictionary<string, string?>(); set => SetDictionary(value); }

    /// <summary>
    /// ElliUCDDetail LEFields
    /// </summary>
    [AllowNull]
    public IDictionary<string, string?> LEFields { get => GetDictionary<string, string?>(); set => SetDictionary(value); }
}