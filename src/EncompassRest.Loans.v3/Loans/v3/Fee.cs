using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Fee
/// </summary>
public sealed partial class Fee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<decimal?>? _amountPerDay;
    private DirtyValue<decimal?>? _borPaidAmount;
    private DirtyValue<int?>? _days;
    private DirtyValue<decimal?>? _deedAmount;
    private DirtyValue<string?>? _description;
    private DirtyValue<StringEnumValue<FeeFeeType>>? _feeType;
    private DirtyValue<bool?>? _fha;
    private DirtyValue<DateTime?>? _fromDate;
    private DirtyValue<string?>? _fwbc;
    private DirtyValue<string?>? _fwsc;
    private DirtyValue<string?>? _includeAboveNumber;
    private DirtyValue<decimal?>? _lenderCoverage;
    private DirtyValue<decimal?>? _monthlyPayment;
    private DirtyValue<decimal?>? _mortgageAmount;
    private DirtyValue<string?>? _newHudBorPaidAmount;
    private DirtyValue<int?>? _numberOfMonths;
    private DirtyValue<decimal?>? _ownerCoverage;
    private DirtyValue<StringEnumValue<PaidBy>>? _paidBy;
    private DirtyValue<decimal?>? _paidInAdvance;
    private DirtyValue<decimal?>? _paidToBroker;
    private DirtyValue<string?>? _paidToName;
    private DirtyValue<decimal?>? _paidToOthers;
    private DirtyValue<decimal?>? _percentage;
    private DirtyValue<bool?>? _pfc;
    private DirtyValue<bool?>? _poc;
    private DirtyValue<StringEnumValue<PTB>>? _ptb;
    private DirtyValue<decimal?>? _releasesAmount;
    private DirtyValue<decimal?>? _sellerPaidAmount;
    private DirtyValue<DateTime?>? _toDate;
    private DirtyValue<decimal?>? _truncatedAmountPerDay;
    private DirtyValue<bool?>? _use4Decimals;

    /// <summary>
    /// FeeContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// Fees Interest Per Day [333]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? AmountPerDay { get => _amountPerDay; set => SetField(ref _amountPerDay, value); }

    /// <summary>
    /// FeeContract BorPaidAmount
    /// </summary>
    public decimal? BorPaidAmount { get => _borPaidAmount; set => SetField(ref _borPaidAmount, value); }

    /// <summary>
    /// Fees Interest # of Days [332]
    /// </summary>
    public int? Days { get => _days; set => SetField(ref _days, value); }

    /// <summary>
    /// FeeContract DeedAmount
    /// </summary>
    public decimal? DeedAmount { get => _deedAmount; set => SetField(ref _deedAmount, value); }

    /// <summary>
    /// FeeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// FeeContract FeeType
    /// </summary>
    public StringEnumValue<FeeFeeType> FeeType { get => _feeType; set => SetField(ref _feeType, value); }

    /// <summary>
    /// FeeContract Fha
    /// </summary>
    public bool? Fha { get => _fha; set => SetField(ref _fha, value); }

    /// <summary>
    /// Fees Interest From [L244]
    /// </summary>
    public DateTime? FromDate { get => _fromDate; set => SetField(ref _fromDate, value); }

    /// <summary>
    /// FeeContract Fwbc
    /// </summary>
    public string? Fwbc { get => _fwbc; set => SetField(ref _fwbc, value); }

    /// <summary>
    /// FeeContract Fwsc
    /// </summary>
    public string? Fwsc { get => _fwsc; set => SetField(ref _fwsc, value); }

    /// <summary>
    /// FeeContract IncludeAboveNumber [1879], [1880]
    /// </summary>
    public string? IncludeAboveNumber { get => _includeAboveNumber; set => SetField(ref _includeAboveNumber, value); }

    /// <summary>
    /// Fees Line 1109 Lender's Coverage Amount [2409]
    /// </summary>
    public decimal? LenderCoverage { get => _lenderCoverage; set => SetField(ref _lenderCoverage, value); }

    /// <summary>
    /// FeeContract MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

    /// <summary>
    /// FeeContract MortgageAmount
    /// </summary>
    public decimal? MortgageAmount { get => _mortgageAmount; set => SetField(ref _mortgageAmount, value); }

    /// <summary>
    /// FeeContract NewHudBorPaidAmount [NEWHUD.X571], [NEWHUD.X572]
    /// </summary>
    public string? NewHudBorPaidAmount { get => _newHudBorPaidAmount; set => SetField(ref _newHudBorPaidAmount, value); }

    /// <summary>
    /// FeeContract NumberOfMonths
    /// </summary>
    public int? NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }

    /// <summary>
    /// Fees Line 1110 Owner's Coverage Amount [2410]
    /// </summary>
    public decimal? OwnerCoverage { get => _ownerCoverage; set => SetField(ref _ownerCoverage, value); }

    /// <summary>
    /// FeeContract PaidBy
    /// </summary>
    public StringEnumValue<PaidBy> PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

    /// <summary>
    /// FeeContract PaidInAdvance
    /// </summary>
    public decimal? PaidInAdvance { get => _paidInAdvance; set => SetField(ref _paidInAdvance, value); }

    /// <summary>
    /// FeeContract PaidToBroker
    /// </summary>
    public decimal? PaidToBroker { get => _paidToBroker; set => SetField(ref _paidToBroker, value); }

    /// <summary>
    /// FeeContract PaidToName
    /// </summary>
    public string? PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }

    /// <summary>
    /// FeeContract PaidToOthers
    /// </summary>
    public decimal? PaidToOthers { get => _paidToOthers; set => SetField(ref _paidToOthers, value); }

    /// <summary>
    /// FeeContract Percentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Percentage { get => _percentage; set => SetField(ref _percentage, value); }

    /// <summary>
    /// FeeContract Pfc
    /// </summary>
    public bool? Pfc { get => _pfc; set => SetField(ref _pfc, value); }

    /// <summary>
    /// FeeContract Poc
    /// </summary>
    public bool? Poc { get => _poc; set => SetField(ref _poc, value); }

    /// <summary>
    /// FeeContract Ptb
    /// </summary>
    public StringEnumValue<PTB> Ptb { get => _ptb; set => SetField(ref _ptb, value); }

    /// <summary>
    /// Fees Recording Fee Releases Amount [2404]
    /// </summary>
    public decimal? ReleasesAmount { get => _releasesAmount; set => SetField(ref _releasesAmount, value); }

    /// <summary>
    /// FeeContract SellerPaidAmount
    /// </summary>
    public decimal? SellerPaidAmount { get => _sellerPaidAmount; set => SetField(ref _sellerPaidAmount, value); }

    /// <summary>
    /// Fees Interest To [L245]
    /// </summary>
    public DateTime? ToDate { get => _toDate; set => SetField(ref _toDate, value); }

    /// <summary>
    /// Unrounded and Truncated Fees Interest Per Day [335]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TruncatedAmountPerDay { get => _truncatedAmountPerDay; set => SetField(ref _truncatedAmountPerDay, value); }

    /// <summary>
    /// Number of Decimals for Fees Interest # of Days [SYS.X8]
    /// </summary>
    public bool? Use4Decimals { get => _use4Decimals; set => SetField(ref _use4Decimals, value); }
}