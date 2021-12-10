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
    private DirtyValue<StringEnumValue<FulfillmentDisclosedMethod>>? _disclosedMethod;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isManual;
    private DirtyValue<string?>? _orderedBy;
    private DirtyValue<DateTime?>? _processedDate;
    private DirtyList<FulfillmentRecipient>? _recipients;

    /// <summary>
    /// FulfillmentContract DisclosedMethod
    /// </summary>
    public StringEnumValue<FulfillmentDisclosedMethod> DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

    /// <summary>
    /// FulfillmentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// FulfillmentContract IsManual
    /// </summary>
    public bool? IsManual { get => _isManual; set => SetField(ref _isManual, value); }

    /// <summary>
    /// FulfillmentContract OrderedBy
    /// </summary>
    public string? OrderedBy { get => _orderedBy; set => SetField(ref _orderedBy, value); }

    /// <summary>
    /// FulfillmentContract ProcessedDate
    /// </summary>
    public DateTime? ProcessedDate { get => _processedDate; set => SetField(ref _processedDate, value); }

    /// <summary>
    /// FulfillmentContract Recipients
    /// </summary>
    [AllowNull]
    public IList<FulfillmentRecipient> Recipients { get => GetField(ref _recipients); set => SetField(ref _recipients, value); }
}