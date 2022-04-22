using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ServicingPrintLogFieldList
/// </summary>
public sealed partial class ServicingPrintLogFieldList : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ServicingPrintLogFieldList FieldList
    /// </summary>
    [AllowNull]
    public IList<string> FieldList { get => GetList<string>(); set => SetList(value); }

    /// <summary>
    /// ServicingPrintLogFieldList Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}