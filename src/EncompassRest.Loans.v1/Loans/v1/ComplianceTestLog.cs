using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ComplianceTestLog
/// </summary>
public sealed partial class ComplianceTestLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _details;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _result;
    private DirtyValue<bool?>? _showAlert;
    private DirtyValue<DateTime?>? _updatedDateUtc;

    /// <summary>
    /// ComplianceTestLog Details
    /// </summary>
    public string? Details { get => _details; set => SetField(ref _details, value); }

    /// <summary>
    /// ComplianceTestLog Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// ComplianceTestLog Result
    /// </summary>
    public string? Result { get => _result; set => SetField(ref _result, value); }

    /// <summary>
    /// ComplianceTestLog ShowAlert
    /// </summary>
    public bool? ShowAlert { get => _showAlert; set => SetField(ref _showAlert, value); }

    /// <summary>
    /// ComplianceTestLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
}