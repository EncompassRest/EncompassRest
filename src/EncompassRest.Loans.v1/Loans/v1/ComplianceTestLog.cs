using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ComplianceTestLog
/// </summary>
public sealed partial class ComplianceTestLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ComplianceTestLog Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog Result
    /// </summary>
    public string? Result { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog ShowAlert
    /// </summary>
    public bool? ShowAlert { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ComplianceTestLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}