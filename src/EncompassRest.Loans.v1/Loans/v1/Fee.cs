using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

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
    /// Fees Interest From [L244]
    /// </summary>
    public DateTime? DateFrom { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Interest To [L245]
    /// </summary>
    public DateTime? DateTo { get => GetValue<DateTime?>(); set => SetValue(value); }

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
    /// Fee FHA
    /// </summary>
    public bool? FHA { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fee FWBC
    /// </summary>
    public string? FWBC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee FWSC
    /// </summary>
    public string? FWSC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

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
    /// Fee NewHUDBorPaidAmount [NEWHUD.X571], [NEWHUD.X572]
    /// </summary>
    public NA<decimal> NewHUDBorPaidAmount { get => GetValue<NA<decimal>>(); set => SetValue(value); }

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
    /// Fee PFC
    /// </summary>
    public bool? PFC { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fee POC
    /// </summary>
    public bool? POC { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fee PTB
    /// </summary>
    public StringEnumValue<PTB> PTB { get => GetValue<StringEnumValue<PTB>>(); set => SetValue(value); }

    /// <summary>
    /// Fees Recording Fee Releases Amount [2404]
    /// </summary>
    public decimal? ReleasesAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee SellerPaidAmount
    /// </summary>
    public decimal? SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

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