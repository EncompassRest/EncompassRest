using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NewYorkFee
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NewYorkFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _comments;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _feeType;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<string?>? _state;

    /// <summary>
    /// NY Fees Company Address [NYFEES0002]
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// NY Fees Amount [NYFEES0008]
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// NY Fees Company City [NYFEES0003]
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// NY Fees Comments [NYFEES0006]
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// NY Fees Date [NYFEES0007]
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// NY Fees Descr [NYFEES0009]
    /// </summary>
    public string? FeeType { get => _feeType; set => SetField(ref _feeType, value); }

    /// <summary>
    /// NewYorkFeeContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// NY Fees Company Name [NYFEES0001]
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// NY Fees Company Zip [NYFEES0005]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// NY Fees Company State [NYFEES0004]
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }
}