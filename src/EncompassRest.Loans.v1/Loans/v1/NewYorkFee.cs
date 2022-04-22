using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// NewYorkFee
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NewYorkFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// NY Fees Company Address [NYFEESNN02]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Amount [NYFEESNN08]
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company City [NYFEESNN03]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Comments [NYFEESNN06]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Date [NYFEESNN07]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Descr [NYFEESNN09]
    /// </summary>
    public string? FeeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkFee Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company Name [NYFEESNN01]
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkFee NewYorkFeeIndex
    /// </summary>
    public int? NewYorkFeeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company Zip [NYFEESNN05]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company State [NYFEESNN04]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }
}