using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// UnderwriterSummary
/// </summary>
public sealed partial class UnderwriterSummary : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Underwriting Appraisal Comments [2322]
    /// </summary>
    public string? Appraisal { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Completed Date [2353]
    /// </summary>
    public DateTime? AppraisalCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Expired Date [2354]
    /// </summary>
    public DateTime? AppraisalExpiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Ordered Date [2352]
    /// </summary>
    public DateTime? AppraisalOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Type [2356]
    /// </summary>
    public StringEnumValue<UnderwriterSummaryAppraisalType> AppraisalType { get => GetValue<StringEnumValue<UnderwriterSummaryAppraisalType>>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Approval Expired Date [2302]
    /// </summary>
    public DateTime? ApprovalExpiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Approved By [2984]
    /// </summary>
    public string? ApprovedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Approval Date [2301]
    /// </summary>
    public DateTime? ApprovedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting AUS Number [2316]
    /// </summary>
    public string? AusNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting AUS Run [2313]
    /// </summary>
    public DateTime? AusRunDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting AUS Source [2312]
    /// </summary>
    public string? AusSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Net Tangible Benefit Required [2983]
    /// </summary>
    public bool? BenefitRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Clear to Close Date [2305]
    /// </summary>
    public DateTime? ClearToCloseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Concerns [2320]
    /// </summary>
    public string? Concerns { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Conditions [2362]
    /// </summary>
    public string? Conditions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Counter Offer Date [4457]
    /// </summary>
    public DateTime? CounterOfferDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Counteroffer Status [4458]
    /// </summary>
    public StringEnumValue<CounterOfferStatus> CounterOfferStatus { get => GetValue<StringEnumValue<CounterOfferStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Credit Comments [2321]
    /// </summary>
    public string? Credit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Credit Approval Date [2300]
    /// </summary>
    public DateTime? CreditApprovalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Denied By [2986]
    /// </summary>
    public string? DeniedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Denied Date [2987]
    /// </summary>
    public DateTime? DeniedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Different Approval Expired Date [2990]
    /// </summary>
    public DateTime? DifferentApprovalExpiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Different Approved By [2988]
    /// </summary>
    public string? DifferentApprovedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Different Approved Date [2989]
    /// </summary>
    public DateTime? DifferentApprovedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Exceptions Comments [2323]
    /// </summary>
    public string? Exceptions { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Exception Sign Off By [2318]
    /// </summary>
    public string? ExceptionSignOffBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Exception Sign Off Date [2317]
    /// </summary>
    public DateTime? ExceptionSignOffDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwriterSummary Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Manually Underwritten according to Agency/GSE Guidelines [3880]
    /// </summary>
    public bool? IsAgencyManually { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Received Waiver for Agency/GSE Guidelines [3879]
    /// </summary>
    public bool? IsAgencyWaiver { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwritten According to Contractual Agreement with Agency/GSE [3878]
    /// </summary>
    public bool? IsAgencyWithAgreement { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Max Rate [2310]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? MaxRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting MI Ordered Date [2308]
    /// </summary>
    public DateTime? MiOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting MI Received Date [2309]
    /// </summary>
    public DateTime? MiReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Modified Terms Loan Amount [2991]
    /// </summary>
    public decimal? ModifiedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Modified Terms Interest Rate [2992]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ModifiedLoanRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Modified Terms Loan Term [2993]
    /// </summary>
    public int? ModifiedLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Modified Terms Loan to Value [2995]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ModifiedLtv { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Modified Terms Principal and Interest [2994]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ModifiedMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Original Appraiser [2351]
    /// </summary>
    public string? OriginalAppraiser { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Original Appraisers Value [2355]
    /// </summary>
    public decimal? OriginalAppraisersValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Resubmitted Date [2299]
    /// </summary>
    public DateTime? ResubmittedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Review Appraiser [2357]
    /// </summary>
    public string? ReviewAppraiser { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Review Completed Date [2360]
    /// </summary>
    public DateTime? ReviewCompletedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Review Requested Date [2359]
    /// </summary>
    public DateTime? ReviewRequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Review Type [2358]
    /// </summary>
    public StringEnumValue<ReviewType> ReviewType { get => GetValue<StringEnumValue<ReviewType>>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Appraisal Review Value [2361]
    /// </summary>
    public decimal? ReviewValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Date Sent to [2981]
    /// </summary>
    public DateTime? SentToDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting AUS Sign Off By [2315]
    /// </summary>
    public string? SignOffBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UnderwriterSummary SignOffDate [2304]
    /// </summary>
    public DateTime? SignOffDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Strengths [2319]
    /// </summary>
    public string? Strengths { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Submitted Date [2298]
    /// </summary>
    public DateTime? SubmittedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Supervisory Appraisal Co License # [3243]
    /// </summary>
    public string? SupervisoryAppraiserLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Suspended By [2985]
    /// </summary>
    public string? SuspendedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Suspended Date [2303]
    /// </summary>
    public DateTime? SuspendedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Suspended Reasons [2311]
    /// </summary>
    public string? SuspendedReasons { get => GetValue<string?>(); set => SetValue(value); }
}