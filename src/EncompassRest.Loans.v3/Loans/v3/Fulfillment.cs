using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Fulfillment
/// </summary>
public sealed partial class Fulfillment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Fulfillment DisclosedMethod
    /// </summary>
    public StringEnumValue<FulfillmentDisclosedMethod> DisclosedMethod { get => GetValue<StringEnumValue<FulfillmentDisclosedMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Fulfillment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fulfillment IsManual
    /// </summary>
    public bool? IsManual { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fulfillment OrderedBy
    /// </summary>
    public string? OrderedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fulfillment ProcessedDate
    /// </summary>
    public DateTime? ProcessedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fulfillment Recipients
    /// </summary>
    [AllowNull]
    public IList<FulfillmentRecipient> Recipients { get => GetList<FulfillmentRecipient>(); set => SetList(value); }
}