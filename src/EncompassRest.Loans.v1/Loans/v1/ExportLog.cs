using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ExportLog
/// </summary>
public sealed partial class ExportLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ExportLog Category
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExportLog ExportedBy
    /// </summary>
    public string? ExportedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExportLog ExportedByFullName
    /// </summary>
    public string? ExportedByFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExportLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ExportLog ServiceTypes
    /// </summary>
    [AllowNull]
    public IList<ExportLogServiceType> ServiceTypes { get => GetList<ExportLogServiceType>(); set => SetList(value); }
}