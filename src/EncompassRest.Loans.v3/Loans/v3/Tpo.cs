using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tpo
/// </summary>
public sealed partial class Tpo : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _appraisalOrderedDate;
    private DirtyValue<bool?>? _archived;
    private DirtyValue<DateTime?>? _ausOrderedDate;
    private DirtyValue<string?>? _branchAddress;
    private DirtyValue<string?>? _branchAeName;
    private DirtyValue<string?>? _branchAeUserName;
    private DirtyValue<string?>? _branchCity;
    private DirtyValue<string?>? _branchDbaName;
    private DirtyValue<string?>? _branchFax;
    private DirtyValue<string?>? _branchId;
    private DirtyValue<string?>? _branchLegalName;
    private DirtyValue<string?>? _branchManagerEmail;
    private DirtyValue<string?>? _branchManagerName;
    private DirtyValue<string?>? _branchName;
    private DirtyValue<string?>? _branchOrganizationId;
    private DirtyValue<string?>? _branchPhone;
    private DirtyValue<string?>? _branchRating;
    private DirtyValue<string?>? _branchState;
    private DirtyValue<string?>? _branchZip;
    private DirtyValue<string?>? _cfcAddress;
    private DirtyValue<string?>? _cfcBusinessFax;
    private DirtyValue<string?>? _cfcBusinessPhone;
    private DirtyValue<string?>? _cfcCellPhone;
    private DirtyValue<string?>? _cfcCity;
    private DirtyValue<string?>? _cfcEmail;
    private DirtyValue<string?>? _cfcName;
    private DirtyValue<string?>? _cfcNotes;
    private DirtyValue<string?>? _cfcRepAe;
    private DirtyValue<string?>? _cfcSrAeUserName;
    private DirtyValue<string?>? _cfcState;
    private DirtyValue<string?>? _cfcStatus;
    private DirtyValue<string?>? _cfcUserId;
    private DirtyValue<string?>? _cfcZip;
    private DirtyValue<string?>? _companyAddress;
    private DirtyValue<string?>? _companyAeName;
    private DirtyValue<string?>? _companyAeUserName;
    private DirtyValue<string?>? _companyCity;
    private DirtyValue<string?>? _companyDbaName;
    private DirtyValue<string?>? _companyFax;
    private DirtyValue<string?>? _companyId;
    private DirtyValue<string?>? _companyLegalName;
    private DirtyValue<string?>? _companyManagerEmail;
    private DirtyValue<string?>? _companyManagerName;
    private DirtyValue<string?>? _companyName;
    private DirtyValue<string?>? _companyOrganizationId;
    private DirtyValue<string?>? _companyPhone;
    private DirtyValue<string?>? _companyRating;
    private DirtyValue<string?>? _companyState;
    private DirtyValue<string?>? _companyZip;
    private DirtyValue<DateTime?>? _completeLoanPackageSubmissionDate;
    private DirtyValue<DateTime?>? _documentsReadyDate;
    private DirtyValue<DateTime?>? _eligibilityPackageSubmissionDate;
    private DirtyValue<string?>? _feeReviewComments;
    private DirtyValue<string?>? _feeReviewStatus;
    private DirtyValue<DateTime?>? _feeReviewStatusDate;
    private DirtyValue<string?>? _importSource;
    private DirtyValue<DateTime?>? _importSourceLastUpdatedDate;
    private DirtyValue<DateTime?>? _initialApplicationDate;
    private DirtyValue<DateTime?>? _initialSubmitDate;
    private DirtyValue<StringEnumValue<LEIssuedBy>>? _leIssuedBy;
    private DirtyValue<DateTime?>? _leOrDisclosuresGeneratedDate;
    private DirtyValue<string?>? _loAddress;
    private DirtyValue<string?>? _loAeName;
    private DirtyValue<string?>? _loAeUserName;
    private DirtyValue<string?>? _loanEstimateRequestComments;
    private DirtyValue<DateTime?>? _loanEstimateRequestedDate;
    private DirtyValue<string?>? _loBusinessFax;
    private DirtyValue<string?>? _loBusinessPhone;
    private DirtyValue<string?>? _loCellPhone;
    private DirtyValue<string?>? _loCity;
    private DirtyValue<string?>? _loEmail;
    private DirtyValue<string?>? _loId;
    private DirtyValue<string?>? _loName;
    private DirtyValue<string?>? _loNotes;
    private DirtyValue<string?>? _loState;
    private DirtyValue<string?>? _loStatus;
    private DirtyValue<string?>? _loZip;
    private DirtyValue<string?>? _lpAddress;
    private DirtyValue<string?>? _lpAeName;
    private DirtyValue<string?>? _lpAeUserName;
    private DirtyValue<string?>? _lpBusinessFax;
    private DirtyValue<string?>? _lpBusinessPhone;
    private DirtyValue<string?>? _lpCellPhone;
    private DirtyValue<string?>? _lpCity;
    private DirtyValue<string?>? _lpEmail;
    private DirtyValue<string?>? _lpId;
    private DirtyValue<string?>? _lpName;
    private DirtyValue<string?>? _lpNotes;
    private DirtyValue<string?>? _lpState;
    private DirtyValue<string?>? _lpStatus;
    private DirtyValue<string?>? _lpZip;
    private DirtyValue<StringEnumValue<PreferredAus>>? _preferredAus;
    private DirtyValue<DateTime?>? _purchaseStepsReadyDate;
    private DirtyValue<bool?>? _purchaseStepsReviewed;
    private DirtyValue<DateTime?>? _readytoDiscloseDate;
    private DirtyValue<DateTime?>? _registerDate;
    private DirtyValue<string?>? _siteId;
    private DirtyValue<DateTime?>? _submitDate;
    private DirtyValue<bool?>? _testAccountField;
    private DirtyValue<DateTime?>? _titleFeesRequestedDate;
    private DirtyValue<bool?>? _underwriterReviewed;
    private DirtyValue<bool?>? _underwritingDelegated;
    private DirtyValue<bool?>? _watchListFlag;
    private DirtyValue<StringEnumValue<WatchListReason>>? _watchListReason;
    private DirtyValue<DateTime?>? _wholesaleWithdrawalDate;

    /// <summary>
    /// Appraisal Ordered Date [TPO.X117]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderedDate { get => _appraisalOrderedDate; set => SetField(ref _appraisalOrderedDate, value); }

    /// <summary>
    /// TPO Archived [TPO.X8]
    /// </summary>
    public bool? Archived { get => _archived; set => SetField(ref _archived, value); }

    /// <summary>
    /// AUS Ordered Date [TPO.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AusOrderedDate { get => _ausOrderedDate; set => SetField(ref _ausOrderedDate, value); }

    /// <summary>
    /// TPO Branch Address [TPO.X42]
    /// </summary>
    public string? BranchAddress { get => _branchAddress; set => SetField(ref _branchAddress, value); }

    /// <summary>
    /// TPO Branch AE Name [TPO.X54]
    /// </summary>
    public string? BranchAeName { get => _branchAeName; set => SetField(ref _branchAeName, value); }

    /// <summary>
    /// TPO Branch AE User Name [TPO.X55]
    /// </summary>
    public string? BranchAeUserName { get => _branchAeUserName; set => SetField(ref _branchAeUserName, value); }

    /// <summary>
    /// TPO Branch Address City [TPO.X43]
    /// </summary>
    public string? BranchCity { get => _branchCity; set => SetField(ref _branchCity, value); }

    /// <summary>
    /// TPO Branch DBA Name [TPO.X48]
    /// </summary>
    public string? BranchDbaName { get => _branchDbaName; set => SetField(ref _branchDbaName, value); }

    /// <summary>
    /// TPO Branch Fax [TPO.X47]
    /// </summary>
    public string? BranchFax { get => _branchFax; set => SetField(ref _branchFax, value); }

    /// <summary>
    /// TPO Branch ID [TPO.X39]
    /// </summary>
    public string? BranchId { get => _branchId; set => SetField(ref _branchId, value); }

    /// <summary>
    /// TPO Branch Legal Name [TPO.X41]
    /// </summary>
    public string? BranchLegalName { get => _branchLegalName; set => SetField(ref _branchLegalName, value); }

    /// <summary>
    /// TPO Branch Manager Email [TPO.X53]
    /// </summary>
    public string? BranchManagerEmail { get => _branchManagerEmail; set => SetField(ref _branchManagerEmail, value); }

    /// <summary>
    /// TPO Branch Manager Name [TPO.X52]
    /// </summary>
    public string? BranchManagerName { get => _branchManagerName; set => SetField(ref _branchManagerName, value); }

    /// <summary>
    /// TPO Branch Name [TPO.X38]
    /// </summary>
    public string? BranchName { get => _branchName; set => SetField(ref _branchName, value); }

    /// <summary>
    /// TPO Branch Organization ID [TPO.X40]
    /// </summary>
    public string? BranchOrganizationId { get => _branchOrganizationId; set => SetField(ref _branchOrganizationId, value); }

    /// <summary>
    /// TPO Branch Phone [TPO.X46]
    /// </summary>
    public string? BranchPhone { get => _branchPhone; set => SetField(ref _branchPhone, value); }

    /// <summary>
    /// TPO Branch Rating [TPO.X51]
    /// </summary>
    public string? BranchRating { get => _branchRating; set => SetField(ref _branchRating, value); }

    /// <summary>
    /// TPO Branch Address State [TPO.X44]
    /// </summary>
    public string? BranchState { get => _branchState; set => SetField(ref _branchState, value); }

    /// <summary>
    /// TPO Branch Address Zipcode [TPO.X45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BranchZip { get => _branchZip; set => SetField(ref _branchZip, value); }

    /// <summary>
    /// TPO Correspondent File Contact Address [TPO.X102]
    /// </summary>
    public string? CfcAddress { get => _cfcAddress; set => SetField(ref _cfcAddress, value); }

    /// <summary>
    /// TPO Correspondent File Contact Business Fax [TPO.X100]
    /// </summary>
    public string? CfcBusinessFax { get => _cfcBusinessFax; set => SetField(ref _cfcBusinessFax, value); }

    /// <summary>
    /// TPO Correspondent File Contact Business Phone [TPO.X99]
    /// </summary>
    public string? CfcBusinessPhone { get => _cfcBusinessPhone; set => SetField(ref _cfcBusinessPhone, value); }

    /// <summary>
    /// TPO Correspondent File Contact Cell Phone [TPO.X101]
    /// </summary>
    public string? CfcCellPhone { get => _cfcCellPhone; set => SetField(ref _cfcCellPhone, value); }

    /// <summary>
    /// TPO Correspondent File Contact Address City [TPO.X103]
    /// </summary>
    public string? CfcCity { get => _cfcCity; set => SetField(ref _cfcCity, value); }

    /// <summary>
    /// TPO Correspondent File Contact Email/User Name [TPO.X97]
    /// </summary>
    public string? CfcEmail { get => _cfcEmail; set => SetField(ref _cfcEmail, value); }

    /// <summary>
    /// TPO Correspondent File Contact Name [TPO.X95]
    /// </summary>
    public string? CfcName { get => _cfcName; set => SetField(ref _cfcName, value); }

    /// <summary>
    /// TPO Correspondent File Contact Notes [TPO.X106]
    /// </summary>
    public string? CfcNotes { get => _cfcNotes; set => SetField(ref _cfcNotes, value); }

    /// <summary>
    /// TPO Correspondent File Contact Rep/AE [TPO.X107]
    /// </summary>
    public string? CfcRepAe { get => _cfcRepAe; set => SetField(ref _cfcRepAe, value); }

    /// <summary>
    /// TPO Correspondent File Contact SR/AE User ID [TPO.X108]
    /// </summary>
    public string? CfcSrAeUserName { get => _cfcSrAeUserName; set => SetField(ref _cfcSrAeUserName, value); }

    /// <summary>
    /// TPO Correspondent File Contact Address State [TPO.X104]
    /// </summary>
    public string? CfcState { get => _cfcState; set => SetField(ref _cfcState, value); }

    /// <summary>
    /// TPO Correspondent File Contact Status [TPO.X98]
    /// </summary>
    public string? CfcStatus { get => _cfcStatus; set => SetField(ref _cfcStatus, value); }

    /// <summary>
    /// TPO Correspondent File Contact User ID [TPO.X96]
    /// </summary>
    public string? CfcUserId { get => _cfcUserId; set => SetField(ref _cfcUserId, value); }

    /// <summary>
    /// TPO Correspondent File Contact Address Zipcode [TPO.X105]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CfcZip { get => _cfcZip; set => SetField(ref _cfcZip, value); }

    /// <summary>
    /// TPO Company Address [TPO.X18]
    /// </summary>
    public string? CompanyAddress { get => _companyAddress; set => SetField(ref _companyAddress, value); }

    /// <summary>
    /// TPO Company AE Name [TPO.X30]
    /// </summary>
    public string? CompanyAeName { get => _companyAeName; set => SetField(ref _companyAeName, value); }

    /// <summary>
    /// TPO Company AE User Name [TPO.X31]
    /// </summary>
    public string? CompanyAeUserName { get => _companyAeUserName; set => SetField(ref _companyAeUserName, value); }

    /// <summary>
    /// TPO Company Address City [TPO.X19]
    /// </summary>
    public string? CompanyCity { get => _companyCity; set => SetField(ref _companyCity, value); }

    /// <summary>
    /// TPO Company DBA Name [TPO.X24]
    /// </summary>
    public string? CompanyDbaName { get => _companyDbaName; set => SetField(ref _companyDbaName, value); }

    /// <summary>
    /// TPO Company Fax [TPO.X23]
    /// </summary>
    public string? CompanyFax { get => _companyFax; set => SetField(ref _companyFax, value); }

    /// <summary>
    /// TPO Company ID [TPO.X15]
    /// </summary>
    public string? CompanyId { get => _companyId; set => SetField(ref _companyId, value); }

    /// <summary>
    /// TPO Company Legal Name [TPO.X17]
    /// </summary>
    public string? CompanyLegalName { get => _companyLegalName; set => SetField(ref _companyLegalName, value); }

    /// <summary>
    /// TPO Company Manager Email [TPO.X29]
    /// </summary>
    public string? CompanyManagerEmail { get => _companyManagerEmail; set => SetField(ref _companyManagerEmail, value); }

    /// <summary>
    /// TPO Company Manager Name [TPO.X28]
    /// </summary>
    public string? CompanyManagerName { get => _companyManagerName; set => SetField(ref _companyManagerName, value); }

    /// <summary>
    /// TPO Company Name [TPO.X14]
    /// </summary>
    public string? CompanyName { get => _companyName; set => SetField(ref _companyName, value); }

    /// <summary>
    /// TPO Company Organization ID [TPO.X16]
    /// </summary>
    public string? CompanyOrganizationId { get => _companyOrganizationId; set => SetField(ref _companyOrganizationId, value); }

    /// <summary>
    /// TPO Company Phone [TPO.X22]
    /// </summary>
    public string? CompanyPhone { get => _companyPhone; set => SetField(ref _companyPhone, value); }

    /// <summary>
    /// TPO Company Rating [TPO.X27]
    /// </summary>
    public string? CompanyRating { get => _companyRating; set => SetField(ref _companyRating, value); }

    /// <summary>
    /// TPO Company Address State [TPO.X20]
    /// </summary>
    public string? CompanyState { get => _companyState; set => SetField(ref _companyState, value); }

    /// <summary>
    /// TPO Company Address Zipcode [TPO.X21]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CompanyZip { get => _companyZip; set => SetField(ref _companyZip, value); }

    /// <summary>
    /// Complete Loan Package Submission Date [TPO.X114]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CompleteLoanPackageSubmissionDate { get => _completeLoanPackageSubmissionDate; set => SetField(ref _completeLoanPackageSubmissionDate, value); }

    /// <summary>
    /// TPO Documents and Conditions are Ready for Underwriter Review Date [TPO.X10]
    /// </summary>
    public DateTime? DocumentsReadyDate { get => _documentsReadyDate; set => SetField(ref _documentsReadyDate, value); }

    /// <summary>
    /// Eligibility Package Submission Date [TPO.X113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? EligibilityPackageSubmissionDate { get => _eligibilityPackageSubmissionDate; set => SetField(ref _eligibilityPackageSubmissionDate, value); }

    /// <summary>
    /// TPO Fee Review Comments [TPO.X12]
    /// </summary>
    public string? FeeReviewComments { get => _feeReviewComments; set => SetField(ref _feeReviewComments, value); }

    /// <summary>
    /// TPO Fee Review Status [TPO.X6]
    /// </summary>
    public string? FeeReviewStatus { get => _feeReviewStatus; set => SetField(ref _feeReviewStatus, value); }

    /// <summary>
    /// TPO Fee Review Status Date [TPO.X11]
    /// </summary>
    public DateTime? FeeReviewStatusDate { get => _feeReviewStatusDate; set => SetField(ref _feeReviewStatusDate, value); }

    /// <summary>
    /// TPO Import Source [TPO.X9]
    /// </summary>
    public string? ImportSource { get => _importSource; set => SetField(ref _importSource, value); }

    /// <summary>
    /// Import Source Last Updated Date [TPO.X112]
    /// </summary>
    public DateTime? ImportSourceLastUpdatedDate { get => _importSourceLastUpdatedDate; set => SetField(ref _importSourceLastUpdatedDate, value); }

    /// <summary>
    /// Initial TPO Application Date [TPO.X89]
    /// </summary>
    public DateTime? InitialApplicationDate { get => _initialApplicationDate; set => SetField(ref _initialApplicationDate, value); }

    /// <summary>
    /// Initial TPO Submittal Date [TPO.X90]
    /// </summary>
    public DateTime? InitialSubmitDate { get => _initialSubmitDate; set => SetField(ref _initialSubmitDate, value); }

    /// <summary>
    /// Loan Estimate Issued By [TPO.X109]
    /// </summary>
    public StringEnumValue<LEIssuedBy> LeIssuedBy { get => _leIssuedBy; set => SetField(ref _leIssuedBy, value); }

    /// <summary>
    /// LE or Disclosures Generated Date [TPO.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? LeOrDisclosuresGeneratedDate { get => _leOrDisclosuresGeneratedDate; set => SetField(ref _leOrDisclosuresGeneratedDate, value); }

    /// <summary>
    /// TPO Loan Officer Address [TPO.X68]
    /// </summary>
    public string? LoAddress { get => _loAddress; set => SetField(ref _loAddress, value); }

    /// <summary>
    /// TPO Loan Officer Sales Rep/AE [TPO.X56]
    /// </summary>
    public string? LoAeName { get => _loAeName; set => SetField(ref _loAeName, value); }

    /// <summary>
    /// TPO Loan Officer Sales Rep/AE User ID [TPO.X57]
    /// </summary>
    public string? LoAeUserName { get => _loAeUserName; set => SetField(ref _loAeUserName, value); }

    /// <summary>
    /// Loan Estimate Request Comments [TPO.X120]
    /// </summary>
    public string? LoanEstimateRequestComments { get => _loanEstimateRequestComments; set => SetField(ref _loanEstimateRequestComments, value); }

    /// <summary>
    /// Loan Estimate Requested Date [TPO.X111]
    /// </summary>
    public DateTime? LoanEstimateRequestedDate { get => _loanEstimateRequestedDate; set => SetField(ref _loanEstimateRequestedDate, value); }

    /// <summary>
    /// TPO Loan Officer Business Fax [TPO.X66]
    /// </summary>
    public string? LoBusinessFax { get => _loBusinessFax; set => SetField(ref _loBusinessFax, value); }

    /// <summary>
    /// TPO Loan Officer Business Phone [TPO.X65]
    /// </summary>
    public string? LoBusinessPhone { get => _loBusinessPhone; set => SetField(ref _loBusinessPhone, value); }

    /// <summary>
    /// TPO Loan Officer Cell Phone [TPO.X67]
    /// </summary>
    public string? LoCellPhone { get => _loCellPhone; set => SetField(ref _loCellPhone, value); }

    /// <summary>
    /// TPO Loan Officer Address City [TPO.X69]
    /// </summary>
    public string? LoCity { get => _loCity; set => SetField(ref _loCity, value); }

    /// <summary>
    /// TPO Loan Officer Email/User Name [TPO.X63]
    /// </summary>
    public string? LoEmail { get => _loEmail; set => SetField(ref _loEmail, value); }

    /// <summary>
    /// TPO Loan Officer ID [TPO.X62]
    /// </summary>
    public string? LoId { get => _loId; set => SetField(ref _loId, value); }

    /// <summary>
    /// TPO Loan Officer Name [TPO.X61]
    /// </summary>
    public string? LoName { get => _loName; set => SetField(ref _loName, value); }

    /// <summary>
    /// TPO Loan Officer Notes [TPO.X72]
    /// </summary>
    public string? LoNotes { get => _loNotes; set => SetField(ref _loNotes, value); }

    /// <summary>
    /// TPO Loan Officer Address State [TPO.X70]
    /// </summary>
    public string? LoState { get => _loState; set => SetField(ref _loState, value); }

    /// <summary>
    /// TPO Loan Officer Status [TPO.X64]
    /// </summary>
    public string? LoStatus { get => _loStatus; set => SetField(ref _loStatus, value); }

    /// <summary>
    /// TPO Loan Officer Address Zipcode [TPO.X71]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LoZip { get => _loZip; set => SetField(ref _loZip, value); }

    /// <summary>
    /// TPO Loan Processor Address [TPO.X81]
    /// </summary>
    public string? LpAddress { get => _lpAddress; set => SetField(ref _lpAddress, value); }

    /// <summary>
    /// TPO Loan Processor Sales Rep/AE [TPO.X58]
    /// </summary>
    public string? LpAeName { get => _lpAeName; set => SetField(ref _lpAeName, value); }

    /// <summary>
    /// TPO Loan Processor Sales Rep/AE User ID [TPO.X59]
    /// </summary>
    public string? LpAeUserName { get => _lpAeUserName; set => SetField(ref _lpAeUserName, value); }

    /// <summary>
    /// TPO Loan Processor Business Fax [TPO.X79]
    /// </summary>
    public string? LpBusinessFax { get => _lpBusinessFax; set => SetField(ref _lpBusinessFax, value); }

    /// <summary>
    /// TPO Loan Processor Business Phone [TPO.X78]
    /// </summary>
    public string? LpBusinessPhone { get => _lpBusinessPhone; set => SetField(ref _lpBusinessPhone, value); }

    /// <summary>
    /// TPO Loan Processor Cell Phone [TPO.X80]
    /// </summary>
    public string? LpCellPhone { get => _lpCellPhone; set => SetField(ref _lpCellPhone, value); }

    /// <summary>
    /// TPO Loan Processor Address City [TPO.X82]
    /// </summary>
    public string? LpCity { get => _lpCity; set => SetField(ref _lpCity, value); }

    /// <summary>
    /// TPO Loan Processor Email/User Name [TPO.X76]
    /// </summary>
    public string? LpEmail { get => _lpEmail; set => SetField(ref _lpEmail, value); }

    /// <summary>
    /// TPO Loan Processor ID [TPO.X75]
    /// </summary>
    public string? LpId { get => _lpId; set => SetField(ref _lpId, value); }

    /// <summary>
    /// TPO Loan Processor Name [TPO.X74]
    /// </summary>
    public string? LpName { get => _lpName; set => SetField(ref _lpName, value); }

    /// <summary>
    /// TPO Loan Processor Notes [TPO.X85]
    /// </summary>
    public string? LpNotes { get => _lpNotes; set => SetField(ref _lpNotes, value); }

    /// <summary>
    /// TPO Loan Processor Address State [TPO.X83]
    /// </summary>
    public string? LpState { get => _lpState; set => SetField(ref _lpState, value); }

    /// <summary>
    /// TPO Loan Processor Status [TPO.X77]
    /// </summary>
    public string? LpStatus { get => _lpStatus; set => SetField(ref _lpStatus, value); }

    /// <summary>
    /// TPO Loan Processor Address Zipcode [TPO.X84]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LpZip { get => _lpZip; set => SetField(ref _lpZip, value); }

    /// <summary>
    /// Preferred AUS [TPO.X119]
    /// </summary>
    public StringEnumValue<PreferredAus> PreferredAus { get => _preferredAus; set => SetField(ref _preferredAus, value); }

    /// <summary>
    /// Purch Conds Ready Date [TPO.X94]
    /// </summary>
    public DateTime? PurchaseStepsReadyDate { get => _purchaseStepsReadyDate; set => SetField(ref _purchaseStepsReadyDate, value); }

    /// <summary>
    /// Purch Conds Ready for Review [TPO.X93]
    /// </summary>
    public bool? PurchaseStepsReviewed { get => _purchaseStepsReviewed; set => SetField(ref _purchaseStepsReviewed, value); }

    /// <summary>
    /// TPO Ready to Disclose Date [TPO.X92]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ReadytoDiscloseDate { get => _readytoDiscloseDate; set => SetField(ref _readytoDiscloseDate, value); }

    /// <summary>
    /// TPO Registration Date [TPO.X3]
    /// </summary>
    public DateTime? RegisterDate { get => _registerDate; set => SetField(ref _registerDate, value); }

    /// <summary>
    /// TPO Site ID [TPO.X1]
    /// </summary>
    public string? SiteId { get => _siteId; set => SetField(ref _siteId, value); }

    /// <summary>
    /// TPO Submittal Date [TPO.X4]
    /// </summary>
    public DateTime? SubmitDate { get => _submitDate; set => SetField(ref _submitDate, value); }

    /// <summary>
    /// Indicator that the user logged in using a TPO test account [TPO.X91]
    /// </summary>
    public bool? TestAccountField { get => _testAccountField; set => SetField(ref _testAccountField, value); }

    /// <summary>
    /// Title Fees Requested Date [TPO.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleFeesRequestedDate { get => _titleFeesRequestedDate; set => SetField(ref _titleFeesRequestedDate, value); }

    /// <summary>
    /// TPO Documents and Conditions are Ready for Underwriter Review [TPO.X5]
    /// </summary>
    public bool? UnderwriterReviewed { get => _underwriterReviewed; set => SetField(ref _underwriterReviewed, value); }

    /// <summary>
    /// TPO Underwriting Delegated [TPO.X88]
    /// </summary>
    public bool? UnderwritingDelegated { get => _underwritingDelegated; set => SetField(ref _underwritingDelegated, value); }

    /// <summary>
    /// TPO WatchList Flag [TPO.X86]
    /// </summary>
    public bool? WatchListFlag { get => _watchListFlag; set => SetField(ref _watchListFlag, value); }

    /// <summary>
    /// TPO WatchList Reason [TPO.X87]
    /// </summary>
    public StringEnumValue<WatchListReason> WatchListReason { get => _watchListReason; set => SetField(ref _watchListReason, value); }

    /// <summary>
    /// Wholesale Withdrawal Requested Date [TPO.X110]
    /// </summary>
    public DateTime? WholesaleWithdrawalDate { get => _wholesaleWithdrawalDate; set => SetField(ref _wholesaleWithdrawalDate, value); }
}