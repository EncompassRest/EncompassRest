using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlDocument
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlDocument : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _tqlDocumentDeliveredDate;

    /// <summary>
    /// TqlDocumentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL Documents Delivered to Investor [TQLDOCDATE0001]
    /// </summary>
    public DateTime? TqlDocumentDeliveredDate { get => _tqlDocumentDeliveredDate; set => SetField(ref _tqlDocumentDeliveredDate, value); }
}