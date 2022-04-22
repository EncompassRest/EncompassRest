using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// IntentToProceed
/// </summary>
public sealed partial class IntentToProceed : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// IntentToProceed Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// IntentToProceed Date
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// IntentToProceed Intent
    /// </summary>
    public bool? Intent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// IntentToProceed ReceivedBy
    /// </summary>
    [AllowNull]
    public LockableStringField ReceivedBy { get => GetEntity<LockableStringField>(); set => SetEntity(value); }

    /// <summary>
    /// IntentToProceed ReceivedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> ReceivedMethod { get => GetValue<StringEnumValue<DisclosedOrReceivedMethod>>(); set => SetValue(value); }

    /// <summary>
    /// IntentToProceed ReceivedMethodOther
    /// </summary>
    public string? ReceivedMethodOther { get => GetValue<string?>(); set => SetValue(value); }
}