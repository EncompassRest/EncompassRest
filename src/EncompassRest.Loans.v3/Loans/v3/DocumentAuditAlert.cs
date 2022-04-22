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
    /// <summary>
    /// DocumentAuditAlert AlertType
    /// </summary>
    public StringEnumValue<AlertType> AlertType { get => GetValue<StringEnumValue<AlertType>>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAuditAlert Details
    /// </summary>
    public string? Details { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAuditAlert Fields
    /// </summary>
    [AllowNull]
    public IList<string?> Fields { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// DocumentAuditAlert Source
    /// </summary>
    public StringEnumValue<DocumentAuditAlertSource> Source { get => GetValue<StringEnumValue<DocumentAuditAlertSource>>(); set => SetValue(value); }
}