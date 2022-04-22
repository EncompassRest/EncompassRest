using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TqlDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL Documents Delivered to Investor [TQLDOCDATE0001]
    /// </summary>
    public DateTime? TqlDocumentDeliveredDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}