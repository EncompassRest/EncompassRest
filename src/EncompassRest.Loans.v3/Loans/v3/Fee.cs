using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Fee
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(FeeType))]
public sealed partial class Fee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Fee Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Interest Per Day [333]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? AmountPerDay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee BorPaidAmount
    /// </summary>
    public decimal? BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Interest # of Days [332]
    /// </summary>
    public int? Days { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fee DeedAmount
    /// </summary>
    public decimal? DeedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee FeeType
    /// </summary>
    public StringEnumValue<FeeFeeType> FeeType { get => GetValue<StringEnumValue<FeeFeeType>>(); set => SetValue(value); }

    /// <summary>
    /// Fee Fha
    /// </summary>
    public bool? Fha { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Interest From [L244]
    /// </summary>
    public DateTime? FromDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Fwbc
    /// </summary>
    public string? Fwbc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Fwsc
    /// </summary>
    public string? Fwsc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee IncludeAboveNumber [1879], [1880]
    /// </summary>
    public string? IncludeAboveNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1109 Lender's Coverage Amount [2409]
    /// </summary>
    public decimal? LenderCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee MortgageAmount
    /// </summary>
    public decimal? MortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee NewHudBorPaidAmount [NEWHUD.X571], [NEWHUD.X572]
    /// </summary>
    public string? NewHudBorPaidAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee NumberOfMonths
    /// </summary>
    public int? NumberOfMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1110 Owner's Coverage Amount [2410]
    /// </summary>
    public decimal? OwnerCoverage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee PaidBy
    /// </summary>
    public StringEnumValue<PaidBy> PaidBy { get => GetValue<StringEnumValue<PaidBy>>(); set => SetValue(value); }

    /// <summary>
    /// Fee PaidInAdvance
    /// </summary>
    public decimal? PaidInAdvance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee PaidToBroker
    /// </summary>
    public decimal? PaidToBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee PaidToName
    /// </summary>
    public string? PaidToName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee PaidToOthers
    /// </summary>
    public decimal? PaidToOthers { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Percentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Percentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Pfc
    /// </summary>
    public bool? Pfc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Poc
    /// </summary>
    public bool? Poc { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Ptb
    /// </summary>
    public StringEnumValue<PTB> Ptb { get => GetValue<StringEnumValue<PTB>>(); set => SetValue(value); }

    /// <summary>
    /// Fees Recording Fee Releases Amount [2404]
    /// </summary>
    public decimal? ReleasesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee SellerPaidAmount
    /// </summary>
    public decimal? SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Interest To [L245]
    /// </summary>
    public DateTime? ToDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Unrounded and Truncated Fees Interest Per Day [335]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TruncatedAmountPerDay { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Number of Decimals for Fees Interest # of Days [SYS.X8]
    /// </summary>
    public bool? Use4Decimals { get => GetValue<bool?>(); set => SetValue(value); }
}