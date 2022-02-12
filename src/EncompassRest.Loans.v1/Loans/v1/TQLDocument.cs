using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLDocument : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _tQLDocumentDeliveredDate;

    /// <summary>
    /// TQLDocument Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL Documents Delivered to Investor [TQLDOCDATENN01]
    /// </summary>
    public DateTime? TQLDocumentDeliveredDate { get => _tQLDocumentDeliveredDate; set => SetField(ref _tQLDocumentDeliveredDate, value); }
}