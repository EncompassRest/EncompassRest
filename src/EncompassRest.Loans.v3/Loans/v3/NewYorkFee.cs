using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NewYorkFee
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NewYorkFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// NY Fees Company Address [NYFEES0002]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Amount [NYFEES0008]
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company City [NYFEES0003]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Comments [NYFEES0006]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Date [NYFEES0007]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Descr [NYFEES0009]
    /// </summary>
    public string? FeeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkFee Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company Name [NYFEES0001]
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company Zip [NYFEES0005]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NY Fees Company State [NYFEES0004]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }
}