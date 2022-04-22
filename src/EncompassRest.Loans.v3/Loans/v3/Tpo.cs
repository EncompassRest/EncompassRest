using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tpo
/// </summary>
public sealed partial class Tpo : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Appraisal Ordered Date [TPO.X117]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Archived [TPO.X8]
    /// </summary>
    public bool? Archived { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AUS Ordered Date [TPO.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AusOrderedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Address [TPO.X42]
    /// </summary>
    public string? BranchAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch AE Name [TPO.X54]
    /// </summary>
    public string? BranchAeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch AE User Name [TPO.X55]
    /// </summary>
    public string? BranchAeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Address City [TPO.X43]
    /// </summary>
    public string? BranchCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch DBA Name [TPO.X48]
    /// </summary>
    public string? BranchDbaName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Fax [TPO.X47]
    /// </summary>
    public string? BranchFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch ID [TPO.X39]
    /// </summary>
    public string? BranchId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Legal Name [TPO.X41]
    /// </summary>
    public string? BranchLegalName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Manager Email [TPO.X53]
    /// </summary>
    public string? BranchManagerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Manager Name [TPO.X52]
    /// </summary>
    public string? BranchManagerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Name [TPO.X38]
    /// </summary>
    public string? BranchName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Organization ID [TPO.X40]
    /// </summary>
    public string? BranchOrganizationId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Phone [TPO.X46]
    /// </summary>
    public string? BranchPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Rating [TPO.X51]
    /// </summary>
    public string? BranchRating { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Address State [TPO.X44]
    /// </summary>
    public string? BranchState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Branch Address Zipcode [TPO.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BranchZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Address [TPO.X102]
    /// </summary>
    public string? CfcAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Business Fax [TPO.X100]
    /// </summary>
    public string? CfcBusinessFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Business Phone [TPO.X99]
    /// </summary>
    public string? CfcBusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Cell Phone [TPO.X101]
    /// </summary>
    public string? CfcCellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Address City [TPO.X103]
    /// </summary>
    public string? CfcCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Email/User Name [TPO.X97]
    /// </summary>
    public string? CfcEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Name [TPO.X95]
    /// </summary>
    public string? CfcName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Notes [TPO.X106]
    /// </summary>
    public string? CfcNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Rep/AE [TPO.X107]
    /// </summary>
    public string? CfcRepAe { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact SR/AE User ID [TPO.X108]
    /// </summary>
    public string? CfcSrAeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Address State [TPO.X104]
    /// </summary>
    public string? CfcState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Status [TPO.X98]
    /// </summary>
    public string? CfcStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact User ID [TPO.X96]
    /// </summary>
    public string? CfcUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Correspondent File Contact Address Zipcode [TPO.X105]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CfcZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Address [TPO.X18]
    /// </summary>
    public string? CompanyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company AE Name [TPO.X30]
    /// </summary>
    public string? CompanyAeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company AE User Name [TPO.X31]
    /// </summary>
    public string? CompanyAeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Address City [TPO.X19]
    /// </summary>
    public string? CompanyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company DBA Name [TPO.X24]
    /// </summary>
    public string? CompanyDbaName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Fax [TPO.X23]
    /// </summary>
    public string? CompanyFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company ID [TPO.X15]
    /// </summary>
    public string? CompanyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Legal Name [TPO.X17]
    /// </summary>
    public string? CompanyLegalName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Manager Email [TPO.X29]
    /// </summary>
    public string? CompanyManagerEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Manager Name [TPO.X28]
    /// </summary>
    public string? CompanyManagerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Name [TPO.X14]
    /// </summary>
    public string? CompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Organization ID [TPO.X16]
    /// </summary>
    public string? CompanyOrganizationId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Phone [TPO.X22]
    /// </summary>
    public string? CompanyPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Rating [TPO.X27]
    /// </summary>
    public string? CompanyRating { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Address State [TPO.X20]
    /// </summary>
    public string? CompanyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Company Address Zipcode [TPO.X21]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CompanyZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Complete Loan Package Submission Date [TPO.X114]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CompleteLoanPackageSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Documents and Conditions are Ready for Underwriter Review Date [TPO.X10]
    /// </summary>
    public DateTime? DocumentsReadyDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Eligibility Package Submission Date [TPO.X113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EligibilityPackageSubmissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Fee Review Comments [TPO.X12]
    /// </summary>
    public string? FeeReviewComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Fee Review Status [TPO.X6]
    /// </summary>
    public string? FeeReviewStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Fee Review Status Date [TPO.X11]
    /// </summary>
    public DateTime? FeeReviewStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Import Source [TPO.X9]
    /// </summary>
    public string? ImportSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Import Source Last Updated Date [TPO.X112]
    /// </summary>
    public DateTime? ImportSourceLastUpdatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Initial TPO Application Date [TPO.X89]
    /// </summary>
    public DateTime? InitialApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Initial TPO Submittal Date [TPO.X90]
    /// </summary>
    public DateTime? InitialSubmitDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate Issued By [TPO.X109]
    /// </summary>
    public StringEnumValue<LEIssuedBy> LeIssuedBy { get => GetValue<StringEnumValue<LEIssuedBy>>(); set => SetValue(value); }

    /// <summary>
    /// LE or Disclosures Generated Date [TPO.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LeOrDisclosuresGeneratedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Address [TPO.X68]
    /// </summary>
    public string? LoAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Sales Rep/AE [TPO.X56]
    /// </summary>
    public string? LoAeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Sales Rep/AE User ID [TPO.X57]
    /// </summary>
    public string? LoAeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate Request Comments [TPO.X120]
    /// </summary>
    public string? LoanEstimateRequestComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Estimate Requested Date [TPO.X111]
    /// </summary>
    public DateTime? LoanEstimateRequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Business Fax [TPO.X66]
    /// </summary>
    public string? LoBusinessFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Business Phone [TPO.X65]
    /// </summary>
    public string? LoBusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Cell Phone [TPO.X67]
    /// </summary>
    public string? LoCellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Address City [TPO.X69]
    /// </summary>
    public string? LoCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Email/User Name [TPO.X63]
    /// </summary>
    public string? LoEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer ID [TPO.X62]
    /// </summary>
    public string? LoId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Name [TPO.X61]
    /// </summary>
    public string? LoName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Notes [TPO.X72]
    /// </summary>
    public string? LoNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Address State [TPO.X70]
    /// </summary>
    public string? LoState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Status [TPO.X64]
    /// </summary>
    public string? LoStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Officer Address Zipcode [TPO.X71]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LoZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Address [TPO.X81]
    /// </summary>
    public string? LpAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Sales Rep/AE [TPO.X58]
    /// </summary>
    public string? LpAeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Sales Rep/AE User ID [TPO.X59]
    /// </summary>
    public string? LpAeUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Business Fax [TPO.X79]
    /// </summary>
    public string? LpBusinessFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Business Phone [TPO.X78]
    /// </summary>
    public string? LpBusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Cell Phone [TPO.X80]
    /// </summary>
    public string? LpCellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Address City [TPO.X82]
    /// </summary>
    public string? LpCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Email/User Name [TPO.X76]
    /// </summary>
    public string? LpEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor ID [TPO.X75]
    /// </summary>
    public string? LpId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Name [TPO.X74]
    /// </summary>
    public string? LpName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Notes [TPO.X85]
    /// </summary>
    public string? LpNotes { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Address State [TPO.X83]
    /// </summary>
    public string? LpState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Status [TPO.X77]
    /// </summary>
    public string? LpStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Loan Processor Address Zipcode [TPO.X84]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LpZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Preferred AUS [TPO.X119]
    /// </summary>
    public StringEnumValue<PreferredAus> PreferredAus { get => GetValue<StringEnumValue<PreferredAus>>(); set => SetValue(value); }

    /// <summary>
    /// Purch Conds Ready Date [TPO.X94]
    /// </summary>
    public DateTime? PurchaseStepsReadyDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Purch Conds Ready for Review [TPO.X93]
    /// </summary>
    public bool? PurchaseStepsReviewed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Ready to Disclose Date [TPO.X92]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ReadytoDiscloseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Registration Date [TPO.X3]
    /// </summary>
    public DateTime? RegisterDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Site ID [TPO.X1]
    /// </summary>
    public string? SiteId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Submittal Date [TPO.X4]
    /// </summary>
    public DateTime? SubmitDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Indicator that the user logged in using a TPO test account [TPO.X91]
    /// </summary>
    public bool? TestAccountField { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Title Fees Requested Date [TPO.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleFeesRequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Documents and Conditions are Ready for Underwriter Review [TPO.X5]
    /// </summary>
    public bool? UnderwriterReviewed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TPO Underwriting Delegated [TPO.X88]
    /// </summary>
    public bool? UnderwritingDelegated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TPO WatchList Flag [TPO.X86]
    /// </summary>
    public bool? WatchListFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TPO WatchList Reason [TPO.X87]
    /// </summary>
    public StringEnumValue<WatchListReason> WatchListReason { get => GetValue<StringEnumValue<WatchListReason>>(); set => SetValue(value); }

    /// <summary>
    /// Wholesale Withdrawal Requested Date [TPO.X110]
    /// </summary>
    public DateTime? WholesaleWithdrawalDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}