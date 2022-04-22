using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureFeeChange
/// </summary>
public sealed partial class DisclosureFeeChange : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureFeeChange Amount
    /// </summary>
    public string? Amount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange ChangedCircumstance
    /// </summary>
    public string? ChangedCircumstance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange ChangesReceivedDate
    /// </summary>
    public DateTime? ChangesReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange FeeDescription
    /// </summary>
    public string? FeeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange FieldId
    /// </summary>
    public string? FieldId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureFeeChange Reason
    /// </summary>
    public string? Reason { get => GetValue<string?>(); set => SetValue(value); }
}