using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// CustomField
/// </summary>
public sealed partial class CustomField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CustomField DateValue
    /// </summary>
    public DateTime? DateValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CustomField FieldName
    /// </summary>
    public string? FieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CustomField Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CustomField NumericValue
    /// </summary>
    public decimal? NumericValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Custom Field Value [CUSTNNFV]
    /// </summary>
    public string? StringValue { get => GetValue<string?>(); set => SetValue(value); }
}