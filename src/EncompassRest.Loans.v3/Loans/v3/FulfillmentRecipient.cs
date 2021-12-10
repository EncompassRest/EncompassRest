using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FulfillmentRecipient
/// </summary>
public sealed partial class FulfillmentRecipient : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _actualDate;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _presumedDate;

    /// <summary>
    /// FulfillmentRecipientContract ActualDate
    /// </summary>
    public DateTime? ActualDate { get => _actualDate; set => SetField(ref _actualDate, value); }

    /// <summary>
    /// FulfillmentRecipientContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// FulfillmentRecipientContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// FulfillmentRecipientContract PresumedDate
    /// </summary>
    public DateTime? PresumedDate { get => _presumedDate; set => SetField(ref _presumedDate, value); }
}