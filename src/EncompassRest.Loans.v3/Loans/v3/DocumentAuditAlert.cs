using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DocumentAuditAlert
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AlertType) + "," + nameof(Source))]
public sealed partial class DocumentAuditAlert : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<AlertType>>? _alertType;
    private DirtyValue<string?>? _details;
    private DirtyList<string?>? _fields;
    private DirtyValue<StringEnumValue<DocumentAuditAlertSource>>? _source;

    /// <summary>
    /// DocumentAuditAlertContract AlertType
    /// </summary>
    public StringEnumValue<AlertType> AlertType { get => _alertType; set => SetField(ref _alertType, value); }

    /// <summary>
    /// DocumentAuditAlertContract Details
    /// </summary>
    public string? Details { get => _details; set => SetField(ref _details, value); }

    /// <summary>
    /// DocumentAuditAlertContract Fields
    /// </summary>
    [AllowNull]
    public IList<string?> Fields { get => GetField(ref _fields); set => SetField(ref _fields, value); }

    /// <summary>
    /// DocumentAuditAlertContract Source
    /// </summary>
    public StringEnumValue<DocumentAuditAlertSource> Source { get => _source; set => SetField(ref _source, value); }
}