using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ServicingPrintLog
/// </summary>
public sealed partial class ServicingPrintLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ServicingPrintLog FieldLists
    /// </summary>
    [AllowNull]
    public IList<ServicingPrintLogFieldList> FieldLists { get => GetList<ServicingPrintLogFieldList>(); set => SetList(value); }

    /// <summary>
    /// ServicingPrintLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}