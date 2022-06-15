using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// RateLock
/// </summary>
public sealed partial class RateLock : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Purchase Advice Actual Sell Amount [3424]
    /// </summary>
    public decimal? ActualSellAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Actual Sell Price [3422]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? ActualSellPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Actual Sell Side SRP [3426]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? ActualSellSideSRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Actual SRP Amount [3428]
    /// </summary>
    public decimal? ActualSRPAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amt Due To [2631]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? AmountDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amt Due to Lender/Investor [2627]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<PartyType> AmountDueTo { get => GetValue<StringEnumValue<PartyType>>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amt Paid To [2632]
    /// </summary>
    public decimal? AmountPaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amt Paid to Lender/Investor [2628]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<PartyType> AmountPaidTo { get => GetValue<StringEnumValue<PartyType>>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amount Received [2214]
    /// </summary>
    public decimal? AmountReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Term Due In [2960]
    /// </summary>
    public int? BalloonLoanMaturityTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan Amnt Excluding MIP/PMI [3043]
    /// </summary>
    public decimal? BaseLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Borrower/Lender Paid [4463]
    /// </summary>
    public StringEnumValue<BorrLenderPaid> BorrLenderPaid { get => GetValue<StringEnumValue<BorrLenderPaid>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan Amount [2965]
    /// </summary>
    public decimal? BorrowerRequestedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approval Date [3376]
    /// </summary>
    public DateTime? BranchApprovalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approval Date 2 [4770]
    /// </summary>
    public DateTime? BranchApprovalDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approval Date 3 [4774]
    /// </summary>
    public DateTime? BranchApprovalDate3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approval Date 4 [4778]
    /// </summary>
    public DateTime? BranchApprovalDate4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approval Date 5 [4782]
    /// </summary>
    public DateTime? BranchApprovalDate5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approved by [3377]
    /// </summary>
    public string? BranchApprovedby { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approved by 2 [4771]
    /// </summary>
    public string? BranchApprovedBy2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approved by 3 [4775]
    /// </summary>
    public string? BranchApprovedBy3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approved by 4 [4779]
    /// </summary>
    public string? BranchApprovedBy4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Concession Approved by 5 [4783]
    /// </summary>
    public string? BranchApprovedBy5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Price Concession [3375]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BranchPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Price Concession 2 [4769]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BranchPrice2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Price Concession 3 [4773]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BranchPrice3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Price Concession 4 [4777]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BranchPrice4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Branch Price Concession 5 [4781]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BranchPrice5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Buydown Contributor [4631]
    /// </summary>
    public StringEnumValue<BuydownContributor> BuydownContributor { get => GetValue<StringEnumValue<BuydownContributor>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Buydown Type [4632]
    /// </summary>
    public string? BuydownType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock BuySideAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> BuySideAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Buy Side Comments [2204]
    /// </summary>
    public string? BuySideComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Commitment Date [3909]
    /// </summary>
    public DateTime? BuySideCommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Commitment Number [3902]
    /// </summary>
    public string? BuySideCommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Commitment Type [3910]
    /// </summary>
    public string? BuySideCommitmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Last Rate Set Date [3256]
    /// </summary>
    public DateTime? BuySideCurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Days to Extend [3363]
    /// </summary>
    public int? BuySideDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Delivery Expiration Date [3913]
    /// </summary>
    public DateTime? BuySideDeliveryExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Delivery Type [3911]
    /// </summary>
    public string? BuySideDeliveryType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Expiration Date [3912]
    /// </summary>
    public DateTime? BuySideExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Extended Lock Expires Date [3364]
    /// </summary>
    public DateTime? BuySideExtendedLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Investor  [4751]
    /// </summary>
    public string? BuySideInvestor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Lock Date [2149]
    /// </summary>
    public DateTime? BuySideLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Lock Expires Date [2151]
    /// </summary>
    public DateTime? BuySideLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Lock Extension Price Adjustment [3365]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideLockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Net Buy ARM Margin [2775]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideMarginNetBuyRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Margin [2733]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Rate Total Adjust [2774]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideMarginTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Master Commitment Number [3903]
    /// </summary>
    public string? BuySideMasterCommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Number of Days [2150]
    /// </summary>
    public int? BuySideNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side ONRP Eligible Flag [4059]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? BuySideOnrpEligible { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side ONRP Lock Date [4070]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? BuySideOnrpLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side ONRP Lock Time [4058]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BuySideOnrpLockTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Org ID [3906]
    /// </summary>
    public string? BuySideOrgID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Lock Expires Date [3358]
    /// </summary>
    public DateTime? BuySideOriginalLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Price Rate Net Buy Price [2203]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BuySidePriceNetBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Price Rate [2161]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BuySidePriceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Price Tot Adjustment [2202]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? BuySidePriceTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Rate [2152]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Net Buy Rate [2160]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideRateNetBuyRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Rate Sheet ID [2148]
    /// </summary>
    public string? BuySideRateSheetID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Base Rate Tot Adjustment [2159]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideRateTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Requested By [2029]
    /// </summary>
    public string? BuySideRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side SRP Paid Out [2205]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideSRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Starting Adjust Point [3875]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideStartingAdjPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock BuySideStartingAdjPrice
    /// </summary>
    public decimal? BuySideStartingAdjPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide Starting Adjust Rate [3873]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideStartingAdjRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide TPOID [3905]
    /// </summary>
    public string? BuySideTPOID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide TPO Name [3904]
    /// </summary>
    public string? BuySideTPOName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Assigned Trade Unique Identifier [3914]
    /// </summary>
    public string? BuySideTradeGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Assigned Trade Number [3915]
    /// </summary>
    public string? BuySideTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock BuySide UnDiscounted Rate [3848]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuySideUnDiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CancellationRequestPending
    /// </summary>
    public string? CancellationRequestPending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock RequestCOmbined Loan to Value (CLTV) [3242]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CombinedLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Reconciliation Comments [2840]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Investor Commitment [2215]
    /// </summary>
    public string? Commitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Commitment Type [4187]
    /// </summary>
    public string? CommitmentType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Gain Loss Percent [3836]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CompGainLossPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Gain Loss Price [3837]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompGainLossPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompGainLossTotalBuyPrice
    /// </summary>
    public decimal? CompGainLossTotalBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Total Comparison Price [3835]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CompGainLossTotalCompPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Address [3826]
    /// </summary>
    public string? CompInvestorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor City [3827]
    /// </summary>
    public string? CompInvestorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompInvestorCommitment
    /// </summary>
    public string? CompInvestorCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Contact [3823]
    /// </summary>
    public string? CompInvestorContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Email [3825]
    /// </summary>
    public string? CompInvestorEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Investor Lock Type [3832]
    /// </summary>
    public string? CompInvestorLockType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Investor Name [3822]
    /// </summary>
    public string? CompInvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Phone [3824]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CompInvestorPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Zipcode [3829]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CompInvestorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Investor Program Code [3833]
    /// </summary>
    public string? CompInvestorProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor State [3828]
    /// </summary>
    public StringEnumValue<State> CompInvestorState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Investor Template Name [3838]
    /// </summary>
    public string? CompInvestorTemplateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Side Investor Website [3830]
    /// </summary>
    public string? CompInvestorWebsite { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> CompSideAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Comparison Comments [3834]
    /// </summary>
    public string? CompSideComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Comparisoned By [3661]
    /// </summary>
    public string? CompSideComparisonedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Last Rate Set Date [3663]
    /// </summary>
    public DateTime? CompSideCurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideDaystoExtend
    /// </summary>
    public int? CompSideDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Discount YSP [3821]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideDiscountYSP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideExtendedLockExpires
    /// </summary>
    public DateTime? CompSideExtendedLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideInvestorStatus
    /// </summary>
    public string? CompSideInvestorStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideInvestorStatusDate
    /// </summary>
    public DateTime? CompSideInvestorStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideInvestorTradeNumber
    /// </summary>
    public string? CompSideInvestorTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Loan Program [3660]
    /// </summary>
    public string? CompSideLoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Lock Date [3664]
    /// </summary>
    public DateTime? CompSideLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Lock Expires Date [3666]
    /// </summary>
    public DateTime? CompSideLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideLockExtendPriceAdjustment
    /// </summary>
    public decimal? CompSideLockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Net Comparison ARM Margin [3819]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideMarginNetCompRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Margin [3777]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Rate Total Adjust [3818]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideMarginTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideMasterContractNumber
    /// </summary>
    public string? CompSideMasterContractNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Price Rate Net Comparison Price [3776]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CompSideNetCompPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Net Comparison Rate [3713]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideNetCompRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Number of Days [3665]
    /// </summary>
    public int? CompSideNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideOriginalLockExpires
    /// </summary>
    public DateTime? CompSideOriginalLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Price Rate [3714]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CompSidePriceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Price Tot Adjustment [3775]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CompSidePriceTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Rate [3671]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Rate Sheet ID [3662]
    /// </summary>
    public string? CompSideRateSheetID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Base Rate Tot Adjustment [3712]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideRateTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideRequestedBy
    /// </summary>
    public string? CompSideRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison Servicing Type [3831]
    /// </summary>
    public StringEnumValue<ServicingType> CompSideServicingType { get => GetValue<StringEnumValue<ServicingType>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Comparison SRP Paid Out [3820]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompSideSRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideTradeGuid
    /// </summary>
    public string? CompSideTradeGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CompSideTradeNumber
    /// </summary>
    public string? CompSideTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Condominium Project Type Indicator [4711]
    /// </summary>
    public bool? CondominiumIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Confirm Advice Indicator [4666]
    /// </summary>
    public bool? ConfirmAdviceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Confirmed By [2396]
    /// </summary>
    public string? ConfirmedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Confirmed Date [2630]
    /// </summary>
    public DateTime? ConfirmedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Cooperative Project Type Indicator [4712]
    /// </summary>
    public bool? CooperativeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approval Date [3372]
    /// </summary>
    public DateTime? CorporateApprovalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approval Date 2 [4754]
    /// </summary>
    public DateTime? CorporateApprovalDate2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approval Date 3 [4758]
    /// </summary>
    public DateTime? CorporateApprovalDate3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approval Date 4 [4762]
    /// </summary>
    public DateTime? CorporateApprovalDate4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approval Date 5 [4766]
    /// </summary>
    public DateTime? CorporateApprovalDate5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approved by [3373]
    /// </summary>
    public string? CorporateApprovedby { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approved by 2 [4755]
    /// </summary>
    public string? CorporateApprovedBy2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approved by 3 [4759]
    /// </summary>
    public string? CorporateApprovedBy3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approved by 4 [4763]
    /// </summary>
    public string? CorporateApprovedBy4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Concession Approved by 5 [4767]
    /// </summary>
    public string? CorporateApprovedBy5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Price Concession [3371]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CorporatePrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Price Concession 2 [4753]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorporatePrice2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Price Concession 3 [4757]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorporatePrice3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Price Concession 4 [4761]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorporatePrice4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Corporate Price Concession 5 [4765]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorporatePrice5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Additional Escrow [CPA.ADDLESCROW.AdditionalEscrow]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1007 Amount [CPA.ADDLESCROW.1007Amount]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowAmount1007 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1008 Amount [CPA.ADDLESCROW.1008Amount]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowAmount1008 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1009 Amount [CPA.ADDLESCROW.1009Amount]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowAmount1009 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - City Property Tax [CPA.ADDLESCROW.CityPropertyTax]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1007 Description [CPA.ADDLESCROW.1007Description]
    /// </summary>
    public string? CorrespondentAdditionalEscrowDescription1007 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1008 Description [CPA.ADDLESCROW.1008Description]
    /// </summary>
    public string? CorrespondentAdditionalEscrowDescription1008 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Line 1009 Description [CPA.ADDLESCROW.1009Description]
    /// </summary>
    public string? CorrespondentAdditionalEscrowDescription1009 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Flood Insurance [CPA.ADDLESCROW.FloodInsurance]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Homeowners Insurance [CPA.ADDLESCROW.HomeInsurance]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowHomeInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - MI/MIP [CPA.ADDLESCROW.MIMIP]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowMIMIP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Number of Payments [CPA.ADDLESCROW.NumOfPayments]
    /// </summary>
    public int? CorrespondentAdditionalEscrowNumOfPayments { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Additional Amount Value 1 [CPA.ADDLESCROW.Option1Amount]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowOption1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Additional Amount Description 1 [CPA.ADDLESCROW.Option1Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption1Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Additional Amount Value 2 [CPA.ADDLESCROW.Option2Amount]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowOption2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Additional Amount Description 2 [CPA.ADDLESCROW.Option2Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentAdditionalEscrowOption2Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Property Tax [CPA.ADDLESCROW.PropertyTax]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - Sum of Payments [CPA.ADDLESCROW.SumOfPayments]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowSumOfPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Escrow Payment Collection - USDA Annual Fee [CPA.ADDLESCROW.USDAAnnualFee]
    /// </summary>
    public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 1 [3588]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 10 [3606]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 11 [3608]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount11 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 12 [3610]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount12 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3970]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount13 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 14 [CORRESPONDENT.X64]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount14 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 15 [CORRESPONDENT.X66]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount15 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 2 [3590]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 3 [3592]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 4 [3594]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 5 [3596]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 6 [3598]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 7 [3600]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount7 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 8 [3602]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount8 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Amount 9 [3604]
    /// </summary>
    public decimal? CorrespondentAdditionalLineAmount9 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 1 [3587]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 10 [3605]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription10 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 11 [3607]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription11 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 12 [3609]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription12 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 14 [CORRESPONDENT.X63]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription14 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 15 [CORRESPONDENT.X65]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription15 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 2 [3589]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 3 [3591]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 4 [3593]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 5 [3595]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 6 [3597]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 7 [3599]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 8 [3601]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Description 9 [3603]
    /// </summary>
    public string? CorrespondentAdditionalLineDescription9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Additional Total Amount [3611]
    /// </summary>
    public decimal? CorrespondentAdditionalLineTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 1 Amount [3573]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorrespondentAdjusterAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 2 Amount [3575]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorrespondentAdjusterAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 3 Amount [3577]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorrespondentAdjusterAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 1 Description [3572]
    /// </summary>
    public string? CorrespondentAdjusterDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 2 Description [3574]
    /// </summary>
    public string? CorrespondentAdjusterDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters 3 Description [3576]
    /// </summary>
    public string? CorrespondentAdjusterDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Confirmed By [3612]
    /// </summary>
    public string? CorrespondentConfirmedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Confirmed Date [3613]
    /// </summary>
    public DateTime? CorrespondentConfirmedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Current Impounds [3568]
    /// </summary>
    public decimal? CorrespondentCurrentImpounds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Current Principal [3571]
    /// </summary>
    public decimal? CorrespondentCurrentPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Date [3567]
    /// </summary>
    public DateTime? CorrespondentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1007 Amount [CPA.ESCROWDISBURSE.1007Amount]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsAmount1007 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1008 Amount [CPA.ESCROWDISBURSE.1008Amount]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsAmount1008 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1009 Amount [CPA.ESCROWDISBURSE.1009Amount]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsAmount1009 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - City Property Tax [CPA.ESCROWDISBURSE.CityPropertyTax]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1007 Description [CPA.ESCROWDISBURSE.1007Description]
    /// </summary>
    public string? CorrespondentEscrowDisbursementsDescription1007 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1008 Description [CPA.ESCROWDISBURSE.1008Description]
    /// </summary>
    public string? CorrespondentEscrowDisbursementsDescription1008 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Line 1009 Description [CPA.ESCROWDISBURSE.1009Description]
    /// </summary>
    public string? CorrespondentEscrowDisbursementsDescription1009 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Escrows to be paid by Seller [CPA.ESCROWDISBURSE.EscrowsToBePaidBySeller]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Total Escrow Net Funded by Investor [CPA.ESCROWDISBURSE.EsrowFundedByInvestor]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Flood Insurance [CPA.ESCROWDISBURSE.FloodInsurance]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Homeowners Insurance [CPA.ESCROWDISBURSE.HomeInsurance]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Mortgage Insurance [CPA.ESCROWDISBURSE.MortgageInsurance]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Additional Amount Value 1 [CPA.ESCROWDISBURSE.Option1Amount]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsOption1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Additional Amount Description 1 [CPA.ESCROWDISBURSE.Option1Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption1Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Additional Amount Value 2 [CPA.ESCROWDISBURSE.Option2Amount]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsOption2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Additional Amount Description 2 [CPA.ESCROWDISBURSE.Option2Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentEscrowDisbursementsOption2Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - Property Tax [CPA.ESCROWDISBURSE.PropertyTax]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Disbursements - USDA Annual Fee [CPA.ESCROWDISBURSE.USDAAnnualFee]
    /// </summary>
    public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Escrow Holdback [CORRESPONDENT.X405]
    /// </summary>
    public decimal? CorrespondentEscrowHoldback { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Final Buy Amount [3583]
    /// </summary>
    public decimal? CorrespondentFinalBuyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters Final Buy Price [3578]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorrespondentFinalBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Aggregate Adjustment Amount [CPA.FCD.AggAdjAmount]
    /// </summary>
    public decimal? CorrespondentFinalCDAggAdjAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1007 Amount [CPA.FCD.1007Amount]
    /// </summary>
    public decimal? CorrespondentFinalCDAmount1007 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1008 Amount [CPA.FCD.1008Amount]
    /// </summary>
    public decimal? CorrespondentFinalCDAmount1008 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1009 Amount [CPA.FCD.1009Amount]
    /// </summary>
    public decimal? CorrespondentFinalCDAmount1009 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - City Property Tax [CPA.FCD.CityPropertyTax]
    /// </summary>
    public decimal? CorrespondentFinalCDCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1007 Description [CPA.FCD.1007Description]
    /// </summary>
    public string? CorrespondentFinalCDDescription1007 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1008 Description [CPA.FCD.1008Description]
    /// </summary>
    public string? CorrespondentFinalCDDescription1008 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Line 1009 Description [CPA.FCD.1009Description]
    /// </summary>
    public string? CorrespondentFinalCDDescription1009 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Flood Insurance [CPA.FCD.FloodInsurance]
    /// </summary>
    public decimal? CorrespondentFinalCDFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Homeowners Insurance [CPA.FCD.HomeInsurance]
    /// </summary>
    public decimal? CorrespondentFinalCDHomeInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Mortgage Insurance [CPA.FCD.MortgageInsurance]
    /// </summary>
    public decimal? CorrespondentFinalCDMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Additional Amount Value 1 [CPA.FCD.Option1Amount]
    /// </summary>
    public decimal? CorrespondentFinalCDOption1Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Additional Amount Description 1 [CPA.FCD.Option1Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption1Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Additional Amount Value 2 [CPA.FCD.Option2Amount]
    /// </summary>
    public decimal? CorrespondentFinalCDOption2Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Additional Amount Description 2 [CPA.FCD.Option2Desc]
    /// </summary>
    public StringEnumValue<CorrespondentOptionDesc> CorrespondentFinalCDOption2Desc { get => GetValue<StringEnumValue<CorrespondentOptionDesc>>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Property Tax [CPA.FCD.PropertyTax]
    /// </summary>
    public decimal? CorrespondentFinalCDPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - Reservces Collected at Closing [CPA.FCD.ReservesCollectedAtClosing]
    /// </summary>
    public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Final CD - USDA Annual Fee [CPA.FCD.USDAAnnualFee]
    /// </summary>
    public decimal? CorrespondentFinalCDUSDAAnnualFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice First Payment Date [3570]
    /// </summary>
    public DateTime? CorrespondentFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Impounds [3582]
    /// </summary>
    public decimal? CorrespondentImpounds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Interest [3580]
    /// </summary>
    public decimal? CorrespondentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Interest Days [3581]
    /// </summary>
    public int? CorrespondentInterestDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Late Fee [3939]
    /// </summary>
    public decimal? CorrespondentLateFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Adjusters Late Fee Price Adjustment [3938]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? CorrespondentLateFeePriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Paid to Date [3569]
    /// </summary>
    public DateTime? CorrespondentPaidToDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator Anticipated Purchase Date [CPA.PaymentHistory.AnticipatedPurchaseDate]
    /// </summary>
    public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator Calculated Purchased Principal [CPA.PaymentHistory.CalculatedPurchasedPrincipal]
    /// </summary>
    public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator 1st Payment Due from Borrower  [CPA.PaymentHistory.FirstBorrowerPaymentDueDate]
    /// </summary>
    public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator ◦1st Payment Due to Investor [CPA.PaymentHistory.FirstInvestorPaymentDate]
    /// </summary>
    public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator Note Date [CPA.PaymentHistory.NoteDate]
    /// </summary>
    public DateTime? CorrespondentPaymentHistoryNoteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Payment History Calculator principal reduction prior to 1st payment date [CPA.PaymentHistory.PricipalReduction]
    /// </summary>
    public decimal? CorrespondentPaymentHistoryPricipalReduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Purchased Principal [3579]
    /// </summary>
    public decimal? CorrespondentPurchasedPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Reconcilation Comments [3586]
    /// </summary>
    public string? CorrespondentReconcilationComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Remaining Buydown Amount [3585]
    /// </summary>
    public decimal? CorrespondentRemainingBuydownAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CPA Escrow Details - Retain User Inputs [CPA.RetainUserInputs]
    /// </summary>
    public bool? CorrespondentRetainUserInputs { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details SRP Amount [3584]
    /// </summary>
    public decimal? CorrespondentSRPAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Total Buy Amount [4191]
    /// </summary>
    public decimal? CorrespondentTotalBuyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Additional Purchase Details Total Fees  [4192]
    /// </summary>
    public decimal? CorrespondentTotalFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank ABA Number [3945]
    /// </summary>
    public string? CorrespondentWarehouseBankABANum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Account Name [4202]
    /// </summary>
    public string? CorrespondentWarehouseBankAcctName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Account Number [3944]
    /// </summary>
    public string? CorrespondentWarehouseBankAcctNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Address [3948]
    /// </summary>
    public string? CorrespondentWarehouseBankAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Address1 [3949]
    /// </summary>
    public string? CorrespondentWarehouseBankAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Bailee Expiration Date [3956]
    /// </summary>
    public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Received Indicator [3947]
    /// </summary>
    public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Bailee Letter Required Indicator [3955]
    /// </summary>
    public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank City [3950]
    /// </summary>
    public string? CorrespondentWarehouseBankCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Contact Email [3959]
    /// </summary>
    public string? CorrespondentWarehouseBankContactEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Contact Fax Number [3961]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CorrespondentWarehouseBankContactFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Contact Name [3958]
    /// </summary>
    public string? CorrespondentWarehouseBankContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Contact Phone Number [3960]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CorrespondentWarehouseBankContactPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Description [3953]
    /// </summary>
    public string? CorrespondentWarehouseBankDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Further Credit Account Name [4204]
    /// </summary>
    public string? CorrespondentWarehouseBankFurtherCreditAcctName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Further Credit Account Number [4203]
    /// </summary>
    public string? CorrespondentWarehouseBankFurtherCreditAcctNum { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank ID  [3964]
    /// </summary>
    public int? CorrespondentWarehouseBankId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Name  [3943]
    /// </summary>
    public string? CorrespondentWarehouseBankName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Note [3962]
    /// </summary>
    public string? CorrespondentWarehouseBankNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Self - Funder Indicator [3954]
    /// </summary>
    public bool? CorrespondentWarehouseBankSelfFunderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank State [3951]
    /// </summary>
    public StringEnumValue<State> CorrespondentWarehouseBankState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Tri - Party Contract Indicator [3957]
    /// </summary>
    public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Use Default Contact Indicator [3963]
    /// </summary>
    public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Wire Confirmation # [4190]
    /// </summary>
    public string? CorrespondentWarehouseBankWireConfirmationNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Wire Instructions Received Indicator [3946]
    /// </summary>
    public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent Purchase Advice Warehouse Bank Zip Code [3952]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CorrespondentWarehouseBankZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CreditScoreToUse
    /// </summary>
    public string? CreditScoreToUse { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Cumulated Days to Extend [3431]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? CumulatedDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Acquisition of Land [4254]
    /// </summary>
    public bool? CurrentAcquisition { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock CurrentAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> CurrentAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Current Comments [2035]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CurrentComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Refinance Indicator [4255]
    /// </summary>
    public bool? CurrentConstructionRefi { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Lock Date [2145]
    /// </summary>
    public DateTime? CurrentLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Lock Expires Date [2147]
    /// </summary>
    public DateTime? CurrentLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Margin Rate [2690]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Margin Rate Requested [2732]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentMarginRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Margin Total Adjustment [2731]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentMarginTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Number of Days [2146]
    /// </summary>
    public int? CurrentNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Price Rate [2045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true)]
    public decimal? CurrentPriceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Price Rate Requested [2087]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true)]
    public decimal? CurrentPriceRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Price Tot Adjustment [2086]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10, ReadOnly = true)]
    public decimal? CurrentPriceTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Rate [2036]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Rate Requested [2044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Lock Last Rate Set Date [3255]
    /// </summary>
    public DateTime? CurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Rate Sheet ID [2034]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CurrentRateSheetID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Current Base Rate Tot Adjustment [2043]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CurrentRateTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Date [2370]
    /// </summary>
    public DateTime? Date { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Date First Payment to Investor [3514]
    /// </summary>
    public DateTime? DateFirstPaymentToInvestor { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Date Locked with Investor [2291]
    /// </summary>
    public DateTime? DateLockedWithInvestor { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Date Sold to Third Party [3337]
    /// </summary>
    public DateTime? DateSold { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Date Warehoused [3341]
    /// </summary>
    public DateTime? DateWarehoused { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock DaysToExtend
    /// </summary>
    public int? DaysToExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Delivery Type [3965]
    /// </summary>
    public string? DeliveryType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Amt Rcvd Dif [2624]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffAmountReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Impounds Difference [2839]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffImpounds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Interest Difference [2838]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Premium Dif [2610]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Principal Dif [2609]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffPrinciple { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purch Adv Remaining Buydown Funds Dif. [3132]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffRemainingBuydownFunds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Diff Sell Amount [3425]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffSellAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Diff Sell Price [3423]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true)]
    public decimal? DiffSellPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Diff Sell Side SRP [3427]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, ReadOnly = true)]
    public decimal? DiffSellSideSRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice SRP Received Dif [2611]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffSRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Diff SRP Amount [3429]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiffSRPAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Loan Info ARM Disclosure Type [4512]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"UST1YW\":\"1 Year UST CM (weekly)\",\"UST3YW\":\"3 Year UST CM (weekly)\",\"UST5YW\":\"5 Year UST CM (weekly)\",\"UST7YW\":\"7 Year UST CM (weekly)\",\"UST10YW\":\"10 Year UST CM (weekly)\",\"UST20YW\":\"20 Year UST CM (weekly)\",\"UST30YW\":\"30 Year UST CM (weekly)\",\"UST1Y\":\"1 Year US Treasury CM (daily)\",\"UST3Y\":\"3 Year US Treasury CM (daily)\",\"UST5Y\":\"5 Year US Treasury CM (daily)\",\"UST7Y\":\"7 Year US Treasury CM (daily)\",\"UST10Y\":\"10 Year US Treasury CM (daily)\",\"UST20Y\":\"20 Year US Treasury CM (daily)\",\"UST30Y\":\"30 Year US Treasury CM (daily)\",\"3MoCD(12MoAvg)\":\"3-MonthCD (12-Month Avg)\",\"6MCDW\":\"6 Month CD (Secondary Market) weekly\",\"UST6M\":\"6 Month US Treasury CM (daily)\",\"FRBCommercial3M\":\"90 Day AA Commercial Paper Rates (Nonfinancial)\",\"WSJPrime\":\"WSJ Prime Rate (daily)\",\"WSJPrimeWkly\":\"WSJ Prime Rate (weekly)\"}")]
    public StringEnumValue<IndexMargin> DisclosureType { get => GetValue<StringEnumValue<IndexMargin>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Borr Self Employed [3516]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort8 Self Employed [3525]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort9 Self Employed [3526]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator11 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort10 Self Employed [3527]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator12 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Borr Self Employed [3517]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort1 Self Employed [3518]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort2 Self Employed [3519]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort3 Self Employed [3520]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort4 Self Employed [3521]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort5 Self Employed [3522]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort6 Self Employed [3523]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Mort7 Self Employed [3524]
    /// </summary>
    public bool? EmploymentBorrowerSelfEmployedIndicator9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Expctd Amt Rcvd [2608]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ExpectedAmountReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Expected Impounds Transfer [2837]
    /// </summary>
    public decimal? ExpectedImpounds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Expected Int Pymt from Investor [2836]
    /// </summary>
    public decimal? ExpectedInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Expctd Premium [2594]
    /// </summary>
    public decimal? ExpectedPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Expctd Principal [2593]
    /// </summary>
    public decimal? ExpectedPrinciple { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purch Adv Expctd Remaining Buydown Funds [3130]
    /// </summary>
    public decimal? ExpectedRemainingBuydownFunds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Expctd SRP Received [2595]
    /// </summary>
    public decimal? ExpectedSRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Extension Indicator [4790]
    /// </summary>
    public bool? ExtensionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock ExtensionRequestPending
    /// </summary>
    public string? ExtensionRequestPending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Extension Sequence Number [3433]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ExtensionSequenceNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock ExtraPayments
    /// </summary>
    [AllowNull]
    public IList<ExtraPayment> ExtraPayments { get => GetList<ExtraPayment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Request - FHA Secondary Residence [4515]
    /// </summary>
    public bool? FHASecondaryResidence { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request MI Premium/Funding Fee % [3044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? FHAUpfrontMIPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property # Units [3529]
    /// </summary>
    public int? FinancedNumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice First Payment To [2371]
    /// </summary>
    public StringEnumValue<PartyType> FirstPaymenTo { get => GetValue<StringEnumValue<PartyType>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request First Subordinate Amount [3035]
    /// </summary>
    public decimal? FirstSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Borr First Time Homebuyer [3528]
    /// </summary>
    public bool? FirstTimeHomebuyersIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Amort Type ARM Descr [2956]
    /// </summary>
    public string? FNMProductPlanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request MI Premium/Funding Amnt [3045]
    /// </summary>
    public decimal? FundingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Gain Loss Percent [2296]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? GainLossPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Gain Loss Price [2028]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GainLossPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Total Sell Price [2295]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? GainLossTotalBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Amort Type GPM Rate [2954]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GPMRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Amort Type GPM Years [2955]
    /// </summary>
    public int? GPMYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Type [2947]
    /// </summary>
    public StringEnumValue<PropertyType> GSEPropertyType { get => GetValue<StringEnumValue<PropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Trans Details HCLTV/HTLTV [4514]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HCLTVHTLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Hedging [2401]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public StringEnumValue<YOrN> Hedging { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Freddie Mac HELOC Actual Bal [3846]
    /// </summary>
    public string? HELOCActualBalance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Freddie Mac HELOC Credit Limit [4519]
    /// </summary>
    public decimal? HELOCCreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Actual Impounds Transfer [2835]
    /// </summary>
    public decimal? Impounds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Impound Types [2294]
    /// </summary>
    public StringEnumValue<ImpoundType> ImpoundType { get => GetValue<StringEnumValue<ImpoundType>>(); set => SetValue(value); }

    /// <summary>
    /// RateLock ImpoundWaived
    /// </summary>
    public string? ImpoundWaived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Impounds Waived [2293]
    /// </summary>
    public StringEnumValue<ImpoundWaived> ImpoundWavied { get => GetValue<StringEnumValue<ImpoundWaived>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Loan Info ARM Index [4513]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? IndexCurrentValuePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - HELOC Initial Advance [4510]
    /// </summary>
    public decimal? InitialAdvanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Actual Interest Payment from Investor [2834]
    /// </summary>
    public decimal? Interest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Address [2281]
    /// </summary>
    public string? InvestorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor City [2282]
    /// </summary>
    public string? InvestorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Commitment [2286]
    /// </summary>
    public string? InvestorCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Contact [2279]
    /// </summary>
    public string? InvestorContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Delivery Date [2297]
    /// </summary>
    public DateTime? InvestorDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Email [3055]
    /// </summary>
    public string? InvestorEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Loan Number [2288]
    /// </summary>
    public string? InvestorLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Lock Type [2287]
    /// </summary>
    public string? InvestorLockType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor MERS Number [2290]
    /// </summary>
    public string? InvestorMERSNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Investor Name [2278]
    /// </summary>
    public string? InvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Phone [2280]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? InvestorPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Zipcode [2284]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? InvestorPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Program Code [2289]
    /// </summary>
    public string? InvestorProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor State [2283]
    /// </summary>
    public StringEnumValue<State> InvestorState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Target Delivery Date [2206]
    /// </summary>
    public DateTime? InvestorTargetDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Investor Template Name [3263]
    /// </summary>
    public string? InvestorTemplateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Website [2285]
    /// </summary>
    public string? InvestorWebsite { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock IsCancelled
    /// </summary>
    public string? IsCancelled { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Delivery Type is Visible [3966]
    /// </summary>
    public bool? IsDeliveryType { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lender Fee Waiver Option [4459]
    /// </summary>
    public bool? LenderFeeWaiverOption { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Lender Paid Mortgage Insurance [3628]
    /// </summary>
    public bool? LenderPaidMortgageInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Lein Position [2958]
    /// </summary>
    public StringEnumValue<LienType> LienPriorityType { get => GetValue<StringEnumValue<LienType>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Term Months [2959]
    /// </summary>
    public int? LoanAmortizationTermMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Amort Type [2953]
    /// </summary>
    public StringEnumValue<AmortizationType> LoanAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Doc Type [2867]
    /// </summary>
    public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => GetValue<StringEnumValue<LoanDocumentationType>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request HUD 92900 LT Loan for 203K [3844]
    /// </summary>
    public bool? LoanFor203K { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan Program [2866]
    /// </summary>
    public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan Program File [2967]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanProgramFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Est Closing Date [2966]
    /// </summary>
    public DateTime? LoanScheduledClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request MI Premium/Funding Lock [3046]
    /// </summary>
    public bool? LockField { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock LockRequestAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> LockRequestAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// RateLock LockRequestBorrowers
    /// </summary>
    [AllowNull]
    public IList<LockRequestBorrower> LockRequestBorrowers { get => GetList<LockRequestBorrower>(); set => SetList(value); }

    /// <summary>
    /// Lock Request Loan Purpose [2951]
    /// </summary>
    public StringEnumValue<LockRequestLoanPurposeType> LockRequestLoanPurposeType { get => GetValue<StringEnumValue<LockRequestLoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Validation Status [4788]
    /// </summary>
    public StringEnumValue<LockValidationStatus> LockValidationStatus { get => GetValue<StringEnumValue<LockValidationStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan to Value (LTV) [3241]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? LTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Borr Minimum FICO Score [2940]
    /// </summary>
    public string? MinFICO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Co-Borr Minimum FICO Score [2941]
    /// </summary>
    public string? MinFICO2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Upfont MI Premium/Funding Amt Paid in Cash [3047]
    /// </summary>
    public decimal? MIPPaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Loan Type [2952]
    /// </summary>
    public StringEnumValue<LoanType> MortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Sell Amount [2208]
    /// </summary>
    public decimal? NetSellAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Net Sell Price [2207]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? NetSellPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Next Payment Date [2397]
    /// </summary>
    public DateTime? NextPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request No Closing Cost Option [3892]
    /// </summary>
    public bool? NoClosingCostOption { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Property is not located in a project Indicator [4714]
    /// </summary>
    public bool? NotInProjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Locked during ONRP Window [4057]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public StringEnumValue<YOrN> ONRPLock { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Amort Type Other Descr [2957]
    /// </summary>
    public string? OtherAmortizationTypeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Other Subordinate Amount [3037]
    /// </summary>
    public decimal? OtherSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Penalty Term [2217]
    /// </summary>
    public StringEnumValue<PenaltyTerm> PenaltyTerm { get => GetValue<StringEnumValue<PenaltyTerm>>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Interest Calcuation - Per Diem Interest Rounding [3550]
    /// </summary>
    public StringEnumValue<PerDiemInterestRoundingType> PerDiemInterestRoundingType { get => GetValue<StringEnumValue<PerDiemInterestRoundingType>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Plan Code [3041]
    /// </summary>
    public string? PlanCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Premium [2212]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Premium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Prepay Penalty [2216]
    /// </summary>
    public StringEnumValue<YOrN> PrepayPenalty { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// RateLock PriceAdjustment
    /// </summary>
    public decimal? PriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock PriceAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> PriceAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Price Concession Indicator [4789]
    /// </summary>
    public bool? PriceConcessionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Price Concession Request Status [4791]
    /// </summary>
    public StringEnumValue<ApprovalStatus> PriceConcessionRequestStatus { get => GetValue<StringEnumValue<ApprovalStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Pricing Concession Requested [4787]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? PricingConcessionRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock PricingHistoryData
    /// </summary>
    public string? PricingHistoryData { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Field For Pricing Updated [3039]
    /// </summary>
    public string? PricingUpdated { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Principal [2211]
    /// </summary>
    public decimal? Principle { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Adjusted Buy Price [3420]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? ProfitMarginAdjustedBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Appraised Value [2949]
    /// </summary>
    public int? PropertyAppraisedValueAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Est Value [2948]
    /// </summary>
    public int? PropertyEstimatedValueAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Occupancy Status [2950]
    /// </summary>
    public StringEnumValue<PropertyUsageType> PropertyUsageType { get => GetValue<StringEnumValue<PropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Planned Unit Development Project Type Indicator [4713]
    /// </summary>
    public bool? PudIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Adv Interest Calcuation - Number of Days [3549]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"360\":\"360\",\"364\":\"364\",\"365\":\"365\"}")]
    public int? PurchaseAdviceNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock PurchaseAdvicePayouts
    /// </summary>
    [AllowNull]
    public IList<PurchaseAdvicePayout> PurchaseAdvicePayouts { get => GetList<PurchaseAdvicePayout>(); set => SetList(value); }

    /// <summary>
    /// Lock Request Purchase Price Amount [3038]
    /// </summary>
    public decimal? PurchasePriceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock RateLockBuydowns
    /// </summary>
    [AllowNull]
    public IList<RateLockBuydown> RateLockBuydowns { get => GetList<RateLockBuydown>(); set => SetList(value); }

    /// <summary>
    /// RateLock RateRequestStatus
    /// </summary>
    public string? RateRequestStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock RateStatus
    /// </summary>
    public string? RateStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Branch Concession Approval [3378]
    /// </summary>
    public string? ReasonforBranchApproval { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Branch Concession Approval 2 [4772]
    /// </summary>
    public string? ReasonForBranchApproval2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Branch Concession Approval 3 [4776]
    /// </summary>
    public string? ReasonForBranchApproval3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Branch Concession Approval 4 [4780]
    /// </summary>
    public string? ReasonForBranchApproval4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Branch Concession Approval 5 [4784]
    /// </summary>
    public string? ReasonForBranchApproval5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Corporate  Concession Approval [3374]
    /// </summary>
    public string? ReasonforCorporateApproval { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Corporate Concession Approval 2 [4756]
    /// </summary>
    public string? ReasonForCorporateApproval2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Corporate Concession Approval 3 [4760]
    /// </summary>
    public string? ReasonForCorporateApproval3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Corporate Concession Approval 4 [4764]
    /// </summary>
    public string? ReasonForCorporateApproval4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Reason for Corporate Concession Approval 5 [4768]
    /// </summary>
    public string? ReasonForCorporateApproval5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Reconciled Differences [2629]
    /// </summary>
    public decimal? ReconciledDiff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock ReLockRequestPending
    /// </summary>
    public string? ReLockRequestPending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Purch Adv Remaining Buydown Funds [3131]
    /// </summary>
    public decimal? RemainingBuydownFunds { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Comments [2144]
    /// </summary>
    public string? RequestComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Last Rate Set Date [3254]
    /// </summary>
    public DateTime? RequestCurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Days to Extend [3360]
    /// </summary>
    public int? RequestDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Extended Lock Expires Date [3361]
    /// </summary>
    public DateTime? RequestExtendedLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Fulfilled Date Time [2592]
    /// </summary>
    public string? RequestFullfilledDateTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Impound Types [2962]
    /// </summary>
    public StringEnumValue<ImpoundType> RequestImpoundType { get => GetValue<StringEnumValue<ImpoundType>>(); set => SetValue(value); }

    /// <summary>
    /// RateLock RequestImpoundWaived
    /// </summary>
    public string? RequestImpoundWaived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Impounds Waived [2961]
    /// </summary>
    public StringEnumValue<ImpoundWaived> RequestImpoundWavied { get => GetValue<StringEnumValue<ImpoundWaived>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Cancellation Comment [3623]
    /// </summary>
    public string? RequestLockCancellationComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Cancellation Date [3622]
    /// </summary>
    public DateTime? RequestLockCancellationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Date [2089]
    /// </summary>
    public DateTime? RequestLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Expires Date [2091]
    /// </summary>
    public DateTime? RequestLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Extension Comment [3370]
    /// </summary>
    public string? RequestLockExtendComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Extension Price Adjustment [3362]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestLockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Lock Status [4209]
    /// </summary>
    public string? RequestLockStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Type [3841]
    /// </summary>
    public string? RequestLockType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Void Lock Comment [4686]
    /// </summary>
    public string? RequestLockVoidComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Void Lock Date [4687]
    /// </summary>
    public DateTime? RequestLockVoidDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Margin Rate [2647]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Margin Rate Requested [2689]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestMarginRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request SRP Paid Out [2848]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestMarginSRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Margin Total Adjust [2688]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestMarginTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Number of Days [2090]
    /// </summary>
    public int? RequestNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request ONRP Eligible Flag [4061]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? RequestOnrpEligible { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request ONRP Lock Date [4069]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RequestOnrpLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request ONRP Lock Time [4060]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RequestOnrpLockTime { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Original Lock Expires Date [3369]
    /// </summary>
    public DateTime? RequestOriginalLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Penelaty Term [2964]
    /// </summary>
    public StringEnumValue<PenaltyTerm> RequestPenaltyTerm { get => GetValue<StringEnumValue<PenaltyTerm>>(); set => SetValue(value); }

    /// <summary>
    /// RateLock RequestPending
    /// </summary>
    public string? RequestPending { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Prepay Penalty [2963]
    /// </summary>
    public StringEnumValue<YOrN> RequestPrepayPenalty { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Price Rate [2101]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? RequestPriceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Price Rate Requested [2143]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? RequestPriceRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Price Tot Adjustment [2142]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? RequestPriceTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Program Notes [4456]
    /// </summary>
    public string? RequestProgramNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Rate [2092]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Rate Requested [2100]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestRateRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Rate Sheet ID [2088]
    /// </summary>
    public string? RequestRateSheetID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request Base Rate Tot Adjustment [2099]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestRateTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Starting Adjust Point [3874]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestStartingAdjPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Starting Adjust Rate [3872]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestStartingAdjRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock RequestType
    /// </summary>
    public string? RequestType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request UnDiscounted Rate [3847]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RequestUnDiscountedRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Field For Rounding to Nearest $50 [3056]
    /// </summary>
    public bool? RoundToNearest50 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Second Subordinate Amount [3036]
    /// </summary>
    public decimal? SecondSubordinateAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Seller Paid MI Premium [3049]
    /// </summary>
    public decimal? SellerPaidMIPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock SellSideAdjustments
    /// </summary>
    [AllowNull]
    public IList<PriceAdjustment> SellSideAdjustments { get => GetList<PriceAdjustment>(); set => SetList(value); }

    /// <summary>
    /// Rate Lock Sell Side Comments [2275]
    /// </summary>
    public string? SellSideComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Commitment Contract Number [4093]
    /// </summary>
    public string? SellSideCommitmentContractNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Commitment Date [4016]
    /// </summary>
    public DateTime? SellSideCommitmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Last Rate Set Date [3257]
    /// </summary>
    public DateTime? SellSideCurrentRateSetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Days to Extend [3366]
    /// </summary>
    public int? SellSideDaystoExtend { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Discount YSP [2277]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideDiscountYSP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Extended Lock Expires Date [3367]
    /// </summary>
    public DateTime? SellSideExtendedLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Guarantee Fee [3889]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? SellSideGuaranteeFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Guaranty Fee [4182]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? SellSideGuarantyBaseFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Status [2031]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<SellSideInvestorStatus> SellSideInvestorStatus { get => GetValue<StringEnumValue<SellSideInvestorStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Investor Status Modification Date [2033]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SellSideInvestorStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Trade Number [2842]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SellSideInvestorTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Loan Program [3123]
    /// </summary>
    public string? SellSideLoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Lock Date [2220]
    /// </summary>
    public DateTime? SellSideLockDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Lock Expires Date [2222]
    /// </summary>
    public DateTime? SellSideLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Lock Extension Price Adjustment [3368]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideLockExtendPriceAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Net Buy Rate [2818]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideMarginNetSellRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Rate [2776]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideMarginRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Rate Total Adjustment [2817]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideMarginTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Master Contract Number [2841]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SellSideMasterContractNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side MSR Value [4118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? SellSideMSRValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Net Sell Price [2274]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? SellSideNetSellPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Net Buy Rate [2231]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideNetSellRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Number of Days [2221]
    /// </summary>
    public int? SellSideNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Lock Expires Date [3359]
    /// </summary>
    public DateTime? SellSideOriginalLockExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Pool ID [4019]
    /// </summary>
    public string? SellSidePoolID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Pool Number [3890]
    /// </summary>
    public string? SellSidePoolNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Price Rate [2232]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? SellSidePriceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Price Total Adjust [2273]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? SellSidePriceTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Product Name [4094]
    /// </summary>
    public string? SellSideProductName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Rate [2223]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Rate Sheet ID [2219]
    /// </summary>
    public string? SellSideRateSheetID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Base Rate Tot Adjustment [2230]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideRateTotalAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Requested By [2030]
    /// </summary>
    public string? SellSideRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Servicer [3535]
    /// </summary>
    public string? SellSideServicer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Servicing Fee [3888]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? SellSideServicingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Servicing Type [3534]
    /// </summary>
    public StringEnumValue<ServicingType> SellSideServicingType { get => GetValue<StringEnumValue<ServicingType>>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice Sell Side SRP [2209]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? SellSideSRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side SRP Paid Out [2276]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SellSideSRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Assigned Trade Unique Identifier [2819]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SellSideTradeGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Identifier Trade Mgmt Prev Confirmed Lock [3839]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SellSideTradeMgmtPrevConfirmedLockGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Assigned Trade Number [2032]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SellSideTradeNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Servicing Release Indicator [3338]
    /// </summary>
    public bool? ServicingReleaseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice SRP Received [2213]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SRP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Purchase Advice SRP Amount [2210]
    /// </summary>
    public decimal? SRPAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request SRP Paid Out [4201]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SRPPaidOut { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property City [2943]
    /// </summary>
    public string? SubjectPropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property is a Condotel [4115]
    /// </summary>
    public bool? SubjectPropertyCondotelIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property County [2944]
    /// </summary>
    public string? SubjectPropertyCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property is a Non-Warrantable Project [4116]
    /// </summary>
    public bool? SubjectPropertyNonWarrantableProjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Zip [2946]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SubjectPropertyPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Street Address [4516]
    /// </summary>
    public string? SubjectPropertyPropertyStreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property State [2945]
    /// </summary>
    public StringEnumValue<State> SubjectPropertyState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Address [2942]
    /// </summary>
    public string? SubjectPropertyStreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Unit Number [4518]
    /// </summary>
    public string? SubjectPropertyUnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Subject Property Unit Type [4517]
    /// </summary>
    public StringEnumValue<UnitType> SubjectPropertyUnitType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Request - Teaser Rate [4511]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TeaserRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Sell Side Time Locked with Investor [2292]
    /// </summary>
    public string? TimeLockedWithInvestor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Total Buy Price [2218]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? TotalBuyPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request FHA 203k D2 Lesser of Sum(A2+B14)/A4 [3845]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForLesserOfSumAsIs { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock Buy Side Total Price Concessions [3379]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Subordinate Financing [2398]
    /// </summary>
    public decimal? TotalSubordinateFinancing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lock Request Borrower Can Demonstrate 12-Month Mortgage/Rental History [3530]
    /// </summary>
    public bool? TwelveMonthMortgageRentalHistoryIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RateLock Type
    /// </summary>
    public string? Type { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Use Point for Calculation SRP and Price Balancing [3430]
    /// </summary>
    public bool? UsePoint { get => GetValue<bool?>(); set => SetValue(value); }
}