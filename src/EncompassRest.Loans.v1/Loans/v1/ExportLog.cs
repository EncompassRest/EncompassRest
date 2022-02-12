using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ExportLog
/// </summary>
public sealed partial class ExportLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _category;
    private DirtyValue<string?>? _exportedBy;
    private DirtyValue<string?>? _exportedByFullName;
    private DirtyValue<string?>? _id;
    private DirtyList<ExportLogServiceType>? _serviceTypes;

    /// <summary>
    /// ExportLog Category
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// ExportLog ExportedBy
    /// </summary>
    public string? ExportedBy { get => _exportedBy; set => SetField(ref _exportedBy, value); }

    /// <summary>
    /// ExportLog ExportedByFullName
    /// </summary>
    public string? ExportedByFullName { get => _exportedByFullName; set => SetField(ref _exportedByFullName, value); }

    /// <summary>
    /// ExportLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// ExportLog ServiceTypes
    /// </summary>
    [AllowNull]
    public IList<ExportLogServiceType> ServiceTypes { get => GetField(ref _serviceTypes); set => SetField(ref _serviceTypes, value); }
}