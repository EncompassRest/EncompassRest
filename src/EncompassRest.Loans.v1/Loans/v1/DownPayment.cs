using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DownPayment
/// </summary>
public sealed partial class DownPayment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trans Details Down Pymt Amt [1335]
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Down Pymt Source [34]
    /// </summary>
    public StringEnumValue<DownPaymentType> DownPaymentType { get => GetValue<StringEnumValue<DownPaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// DownPayment Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Down Pymt Source Descr [191]
    /// </summary>
    public string? SourceDescription { get => GetValue<string?>(); set => SetValue(value); }
}