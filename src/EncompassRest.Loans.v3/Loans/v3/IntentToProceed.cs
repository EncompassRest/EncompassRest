using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// IntentToProceed
/// </summary>
public sealed partial class IntentToProceed : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<bool?>? _intent;
    private LockableStringField? _receivedBy;
    private DirtyValue<StringEnumValue<DisclosedOrReceivedMethod>>? _receivedMethod;
    private DirtyValue<string?>? _receivedMethodOther;

    /// <summary>
    /// IntentToProceedContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// IntentToProceedContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// IntentToProceedContract Intent
    /// </summary>
    public bool? Intent { get => _intent; set => SetField(ref _intent, value); }

    /// <summary>
    /// IntentToProceedContract ReceivedBy
    /// </summary>
    [AllowNull]
    public LockableStringField ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// IntentToProceedContract ReceivedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> ReceivedMethod { get => _receivedMethod; set => SetField(ref _receivedMethod, value); }

    /// <summary>
    /// IntentToProceedContract ReceivedMethodOther
    /// </summary>
    public string? ReceivedMethodOther { get => _receivedMethodOther; set => SetField(ref _receivedMethodOther, value); }
}