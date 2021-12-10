using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TrackingFields
/// </summary>
public sealed partial class TrackingFields : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<string?>? _disclosurePackageTypes;
    private DirtyValue<string?>? _docPackageId;
    private DirtyValue<DateTime?>? _packageCreatedDate;
    private DirtyValue<string?>? _packageId;

    /// <summary>
    /// TrackingFieldsContract DisclosurePackageTypes
    /// </summary>
    [AllowNull]
    public IList<string?> DisclosurePackageTypes { get => GetField(ref _disclosurePackageTypes); set => SetField(ref _disclosurePackageTypes, value); }

    /// <summary>
    /// TrackingFieldsContract DocPackageId
    /// </summary>
    public string? DocPackageId { get => _docPackageId; set => SetField(ref _docPackageId, value); }

    /// <summary>
    /// TrackingFieldsContract PackageCreatedDate
    /// </summary>
    public DateTime? PackageCreatedDate { get => _packageCreatedDate; set => SetField(ref _packageCreatedDate, value); }

    /// <summary>
    /// TrackingFieldsContract PackageId
    /// </summary>
    public string? PackageId { get => _packageId; set => SetField(ref _packageId, value); }
}