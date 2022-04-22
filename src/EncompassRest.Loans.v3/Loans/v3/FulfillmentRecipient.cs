using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FulfillmentRecipient
/// </summary>
public sealed partial class FulfillmentRecipient : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FulfillmentRecipient ActualDate
    /// </summary>
    public DateTime? ActualDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FulfillmentRecipient Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FulfillmentRecipient Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FulfillmentRecipient PresumedDate
    /// </summary>
    public DateTime? PresumedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}