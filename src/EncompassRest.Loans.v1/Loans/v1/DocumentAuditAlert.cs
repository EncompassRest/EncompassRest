using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentAuditAlert
/// </summary>
public sealed partial class DocumentAuditAlert : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<string>? _fields;
    private DirtyValue<StringEnumValue<DocumentAuditAlertSource>>? _source;
    private DirtyValue<string?>? _text;
    private DirtyValue<StringEnumValue<AlertType>>? _type;

    /// <summary>
    /// DocumentAuditAlert Fields
    /// </summary>
    [AllowNull]
    public IList<string> Fields { get => GetField(ref _fields); set => SetField(ref _fields, value); }

    /// <summary>
    /// DocumentAuditAlert Source
    /// </summary>
    public StringEnumValue<DocumentAuditAlertSource> Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// DocumentAuditAlert Text
    /// </summary>
    public string? Text { get => _text; set => SetField(ref _text, value); }

    /// <summary>
    /// DocumentAuditAlert Type
    /// </summary>
    public StringEnumValue<AlertType> Type { get => _type; set => SetField(ref _type, value); }
}