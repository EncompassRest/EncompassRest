using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingFields
/// </summary>
public sealed partial class TrackingFields : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TrackingFields DisclosurePackageTypes
    /// </summary>
    [AllowNull]
    public IList<string?> DisclosurePackageTypes { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// TrackingFields DocPackageId
    /// </summary>
    public string? DocPackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingFields PackageCreatedDate
    /// </summary>
    public DateTime? PackageCreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TrackingFields PackageId
    /// </summary>
    public string? PackageId { get => GetValue<string?>(); set => SetValue(value); }
}