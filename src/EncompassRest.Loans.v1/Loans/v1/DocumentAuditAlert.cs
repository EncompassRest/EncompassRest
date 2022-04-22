using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentAuditAlert
/// </summary>
public sealed partial class DocumentAuditAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DocumentAuditAlert Fields
    /// </summary>
    [AllowNull]
    public IList<string> Fields { get => GetList<string>(); set => SetList(value); }

    /// <summary>
    /// DocumentAuditAlert Source
    /// </summary>
    public StringEnumValue<DocumentAuditAlertSource> Source { get => GetValue<StringEnumValue<DocumentAuditAlertSource>>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAuditAlert Text
    /// </summary>
    public string? Text { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentAuditAlert Type
    /// </summary>
    public StringEnumValue<AlertType> Type { get => GetValue<StringEnumValue<AlertType>>(); set => SetValue(value); }
}