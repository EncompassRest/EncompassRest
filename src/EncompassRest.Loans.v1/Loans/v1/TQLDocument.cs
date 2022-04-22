using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQLDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL Documents Delivered to Investor [TQLDOCDATENN01]
    /// </summary>
    public DateTime? TQLDocumentDeliveredDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}