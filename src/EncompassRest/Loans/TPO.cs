using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TPO
    /// </summary>
    public sealed partial class TPO : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _archived;
        private DirtyValue<string> _branchAddress;
        private DirtyValue<string> _branchAEName;
        private DirtyValue<string> _branchAEUserName;
        private DirtyValue<string> _branchCity;
        private DirtyValue<string> _branchDBAName;
        private DirtyValue<string> _branchFax;
        private DirtyValue<string> _branchID;
        private DirtyValue<string> _branchLegalName;
        private DirtyValue<string> _branchManagerEmail;
        private DirtyValue<string> _branchManagerName;
        private DirtyValue<string> _branchName;
        private DirtyValue<string> _branchOrganizationID;
        private DirtyValue<string> _branchPhone;
        private DirtyValue<string> _branchRating;
        private DirtyValue<StringEnumValue<State>> _branchState;
        private DirtyValue<string> _branchZip;
        private DirtyValue<string> _cFCAddress;
        private DirtyValue<string> _cFCBusinessFax;
        private DirtyValue<string> _cFCBusinessPhone;
        private DirtyValue<string> _cFCCellPhone;
        private DirtyValue<string> _cFCCity;
        private DirtyValue<string> _cFCEmail;
        private DirtyValue<string> _cFCName;
        private DirtyValue<string> _cFCNotes;
        private DirtyValue<string> _cFCRepAE;
        private DirtyValue<string> _cFCSRAEUserName;
        private DirtyValue<StringEnumValue<State>> _cFCState;
        private DirtyValue<string> _cFCStatus;
        private DirtyValue<string> _cFCUserID;
        private DirtyValue<string> _cFCZip;
        private DirtyValue<string> _companyAddress;
        private DirtyValue<string> _companyAEName;
        private DirtyValue<string> _companyAEUserName;
        private DirtyValue<string> _companyCity;
        private DirtyValue<string> _companyDBAName;
        private DirtyValue<string> _companyFax;
        private DirtyValue<string> _companyID;
        private DirtyValue<string> _companyLegalName;
        private DirtyValue<string> _companyManagerEmail;
        private DirtyValue<string> _companyManagerName;
        private DirtyValue<string> _companyName;
        private DirtyValue<string> _companyOrganizationID;
        private DirtyValue<string> _companyPhone;
        private DirtyValue<string> _companyRating;
        private DirtyValue<StringEnumValue<State>> _companyState;
        private DirtyValue<string> _companyZip;
        private DirtyValue<DateTime?> _documentsReadyDate;
        private DirtyValue<string> _feeReviewComments;
        private DirtyValue<string> _feeReviewStatus;
        private DirtyValue<DateTime?> _feeReviewStatusDate;
        private DirtyValue<string> _importSource;
        private DirtyValue<DateTime?> _initialApplicationDate;
        private DirtyValue<DateTime?> _initialSubmitDate;
        private DirtyValue<StringEnumValue<LEIssuedBy>> _lEIssuedBy;
        private DirtyValue<string> _lOAddress;
        private DirtyValue<string> _lOAEName;
        private DirtyValue<string> _lOAEUserName;
        private DirtyValue<DateTime?> _loanEstimateRequestedDate;
        private DirtyValue<string> _lOBusinessFax;
        private DirtyValue<string> _lOBusinessPhone;
        private DirtyValue<string> _lOCellPhone;
        private DirtyValue<string> _lOCity;
        private DirtyValue<string> _lOEmail;
        private DirtyValue<string> _lOID;
        private DirtyValue<string> _lOName;
        private DirtyValue<string> _lONotes;
        private DirtyValue<StringEnumValue<State>> _lOState;
        private DirtyValue<string> _lOStatus;
        private DirtyValue<string> _lOZip;
        private DirtyValue<string> _lPAddress;
        private DirtyValue<string> _lPAEName;
        private DirtyValue<string> _lPAEUserName;
        private DirtyValue<string> _lPBusinessFax;
        private DirtyValue<string> _lPBusinessPhone;
        private DirtyValue<string> _lPCellPhone;
        private DirtyValue<string> _lPCity;
        private DirtyValue<string> _lPEmail;
        private DirtyValue<string> _lPID;
        private DirtyValue<string> _lPName;
        private DirtyValue<string> _lPNotes;
        private DirtyValue<StringEnumValue<State>> _lPState;
        private DirtyValue<string> _lPStatus;
        private DirtyValue<string> _lPZip;
        private DirtyValue<DateTime?> _purchaseStipsReadyDate;
        private DirtyValue<bool?> _purchaseStipsReviewed;
        private DirtyValue<DateTime?> _readytoDiscloseDateUtc;
        private DirtyValue<DateTime?> _registerDate;
        private DirtyValue<string> _sITEID;
        private DirtyValue<DateTime?> _submitDate;
        private DirtyValue<bool?> _testAccountField;
        private DirtyValue<bool?> _underwriterReviewed;
        private DirtyValue<bool?> _underwritingDelegated;
        private DirtyValue<bool?> _watchListFlag;
        private DirtyValue<StringEnumValue<WatchListReason>> _watchListReason;
        private DirtyValue<DateTime?> _wholesaleWithdrawalDate;

        /// <summary>
        /// TPO Archived [TPO.X8]
        /// </summary>
        public bool? Archived { get => _archived; set => SetField(ref _archived, value); }

        /// <summary>
        /// TPO Branch Address [TPO.X42]
        /// </summary>
        public string BranchAddress { get => _branchAddress; set => SetField(ref _branchAddress, value); }

        /// <summary>
        /// TPO Branch AE Name [TPO.X54]
        /// </summary>
        public string BranchAEName { get => _branchAEName; set => SetField(ref _branchAEName, value); }

        /// <summary>
        /// TPO Branch AE User Name [TPO.X55]
        /// </summary>
        public string BranchAEUserName { get => _branchAEUserName; set => SetField(ref _branchAEUserName, value); }

        /// <summary>
        /// TPO Branch Address City [TPO.X43]
        /// </summary>
        public string BranchCity { get => _branchCity; set => SetField(ref _branchCity, value); }

        /// <summary>
        /// TPO Branch DBA Name [TPO.X48]
        /// </summary>
        public string BranchDBAName { get => _branchDBAName; set => SetField(ref _branchDBAName, value); }

        /// <summary>
        /// TPO Branch Fax [TPO.X47]
        /// </summary>
        public string BranchFax { get => _branchFax; set => SetField(ref _branchFax, value); }

        /// <summary>
        /// TPO Branch ID [TPO.X39]
        /// </summary>
        public string BranchID { get => _branchID; set => SetField(ref _branchID, value); }

        /// <summary>
        /// TPO Branch Legal Name [TPO.X41]
        /// </summary>
        public string BranchLegalName { get => _branchLegalName; set => SetField(ref _branchLegalName, value); }

        /// <summary>
        /// TPO Branch Manager Email [TPO.X53]
        /// </summary>
        public string BranchManagerEmail { get => _branchManagerEmail; set => SetField(ref _branchManagerEmail, value); }

        /// <summary>
        /// TPO Branch Manager Name [TPO.X52]
        /// </summary>
        public string BranchManagerName { get => _branchManagerName; set => SetField(ref _branchManagerName, value); }

        /// <summary>
        /// TPO Branch Name [TPO.X38]
        /// </summary>
        public string BranchName { get => _branchName; set => SetField(ref _branchName, value); }

        /// <summary>
        /// TPO Branch Organization ID [TPO.X40]
        /// </summary>
        public string BranchOrganizationID { get => _branchOrganizationID; set => SetField(ref _branchOrganizationID, value); }

        /// <summary>
        /// TPO Branch Phone [TPO.X46]
        /// </summary>
        public string BranchPhone { get => _branchPhone; set => SetField(ref _branchPhone, value); }

        /// <summary>
        /// TPO Branch Rating [TPO.X51]
        /// </summary>
        public string BranchRating { get => _branchRating; set => SetField(ref _branchRating, value); }

        /// <summary>
        /// TPO Branch Address State [TPO.X44]
        /// </summary>
        public StringEnumValue<State> BranchState { get => _branchState; set => SetField(ref _branchState, value); }

        /// <summary>
        /// TPO Branch Address Zipcode [TPO.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string BranchZip { get => _branchZip; set => SetField(ref _branchZip, value); }

        /// <summary>
        /// TPO Correspondent File Contact Address [TPO.X102]
        /// </summary>
        public string CFCAddress { get => _cFCAddress; set => SetField(ref _cFCAddress, value); }

        /// <summary>
        /// TPO Correspondent File Contact Business Fax [TPO.X100]
        /// </summary>
        public string CFCBusinessFax { get => _cFCBusinessFax; set => SetField(ref _cFCBusinessFax, value); }

        /// <summary>
        /// TPO Correspondent File Contact Business Phone [TPO.X99]
        /// </summary>
        public string CFCBusinessPhone { get => _cFCBusinessPhone; set => SetField(ref _cFCBusinessPhone, value); }

        /// <summary>
        /// TPO Correspondent File Contact Cell Phone [TPO.X101]
        /// </summary>
        public string CFCCellPhone { get => _cFCCellPhone; set => SetField(ref _cFCCellPhone, value); }

        /// <summary>
        /// TPO Correspondent File Contact Address City [TPO.X103]
        /// </summary>
        public string CFCCity { get => _cFCCity; set => SetField(ref _cFCCity, value); }

        /// <summary>
        /// TPO Correspondent File Contact Email/User Name [TPO.X97]
        /// </summary>
        public string CFCEmail { get => _cFCEmail; set => SetField(ref _cFCEmail, value); }

        /// <summary>
        /// TPO Correspondent File Contact Name [TPO.X95]
        /// </summary>
        public string CFCName { get => _cFCName; set => SetField(ref _cFCName, value); }

        /// <summary>
        /// TPO Correspondent File Contact Notes [TPO.X106]
        /// </summary>
        public string CFCNotes { get => _cFCNotes; set => SetField(ref _cFCNotes, value); }

        /// <summary>
        /// TPO Correspondent File Contact Rep/AE [TPO.X107]
        /// </summary>
        public string CFCRepAE { get => _cFCRepAE; set => SetField(ref _cFCRepAE, value); }

        /// <summary>
        /// TPO Correspondent File Contact SR/AE User ID [TPO.X108]
        /// </summary>
        public string CFCSRAEUserName { get => _cFCSRAEUserName; set => SetField(ref _cFCSRAEUserName, value); }

        /// <summary>
        /// TPO Correspondent File Contact Address State [TPO.X104]
        /// </summary>
        public StringEnumValue<State> CFCState { get => _cFCState; set => SetField(ref _cFCState, value); }

        /// <summary>
        /// TPO Correspondent File Contact Status [TPO.X98]
        /// </summary>
        public string CFCStatus { get => _cFCStatus; set => SetField(ref _cFCStatus, value); }

        /// <summary>
        /// TPO Correspondent File Contact User ID [TPO.X96]
        /// </summary>
        public string CFCUserID { get => _cFCUserID; set => SetField(ref _cFCUserID, value); }

        /// <summary>
        /// TPO Correspondent File Contact Address Zipcode [TPO.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string CFCZip { get => _cFCZip; set => SetField(ref _cFCZip, value); }

        /// <summary>
        /// TPO Company Address [TPO.X18]
        /// </summary>
        public string CompanyAddress { get => _companyAddress; set => SetField(ref _companyAddress, value); }

        /// <summary>
        /// TPO Company AE Name [TPO.X30]
        /// </summary>
        public string CompanyAEName { get => _companyAEName; set => SetField(ref _companyAEName, value); }

        /// <summary>
        /// TPO Company AE User Name [TPO.X31]
        /// </summary>
        public string CompanyAEUserName { get => _companyAEUserName; set => SetField(ref _companyAEUserName, value); }

        /// <summary>
        /// TPO Company Address City [TPO.X19]
        /// </summary>
        public string CompanyCity { get => _companyCity; set => SetField(ref _companyCity, value); }

        /// <summary>
        /// TPO Company DBA Name [TPO.X24]
        /// </summary>
        public string CompanyDBAName { get => _companyDBAName; set => SetField(ref _companyDBAName, value); }

        /// <summary>
        /// TPO Company Fax [TPO.X23]
        /// </summary>
        public string CompanyFax { get => _companyFax; set => SetField(ref _companyFax, value); }

        /// <summary>
        /// TPO Company ID [TPO.X15]
        /// </summary>
        public string CompanyID { get => _companyID; set => SetField(ref _companyID, value); }

        /// <summary>
        /// TPO Company Legal Name [TPO.X17]
        /// </summary>
        public string CompanyLegalName { get => _companyLegalName; set => SetField(ref _companyLegalName, value); }

        /// <summary>
        /// TPO Company Manager Email [TPO.X29]
        /// </summary>
        public string CompanyManagerEmail { get => _companyManagerEmail; set => SetField(ref _companyManagerEmail, value); }

        /// <summary>
        /// TPO Company Manager Name [TPO.X28]
        /// </summary>
        public string CompanyManagerName { get => _companyManagerName; set => SetField(ref _companyManagerName, value); }

        /// <summary>
        /// TPO Company Name [TPO.X14]
        /// </summary>
        public string CompanyName { get => _companyName; set => SetField(ref _companyName, value); }

        /// <summary>
        /// TPO Company Organization ID [TPO.X16]
        /// </summary>
        public string CompanyOrganizationID { get => _companyOrganizationID; set => SetField(ref _companyOrganizationID, value); }

        /// <summary>
        /// TPO Company Phone [TPO.X22]
        /// </summary>
        public string CompanyPhone { get => _companyPhone; set => SetField(ref _companyPhone, value); }

        /// <summary>
        /// TPO Company Rating [TPO.X27]
        /// </summary>
        public string CompanyRating { get => _companyRating; set => SetField(ref _companyRating, value); }

        /// <summary>
        /// TPO Company Address State [TPO.X20]
        /// </summary>
        public StringEnumValue<State> CompanyState { get => _companyState; set => SetField(ref _companyState, value); }

        /// <summary>
        /// TPO Company Address Zipcode [TPO.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string CompanyZip { get => _companyZip; set => SetField(ref _companyZip, value); }

        /// <summary>
        /// TPO Documents and Conditions are Ready for Underwriter Review Date [TPO.X10]
        /// </summary>
        public DateTime? DocumentsReadyDate { get => _documentsReadyDate; set => SetField(ref _documentsReadyDate, value); }

        /// <summary>
        /// TPO Fee Review Comments [TPO.X12]
        /// </summary>
        public string FeeReviewComments { get => _feeReviewComments; set => SetField(ref _feeReviewComments, value); }

        /// <summary>
        /// TPO Fee Review Status [TPO.X6]
        /// </summary>
        public string FeeReviewStatus { get => _feeReviewStatus; set => SetField(ref _feeReviewStatus, value); }

        /// <summary>
        /// TPO Fee Review Status Date [TPO.X11]
        /// </summary>
        public DateTime? FeeReviewStatusDate { get => _feeReviewStatusDate; set => SetField(ref _feeReviewStatusDate, value); }

        /// <summary>
        /// TPO Import Source [TPO.X9]
        /// </summary>
        public string ImportSource { get => _importSource; set => SetField(ref _importSource, value); }

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
        public StringEnumValue<LEIssuedBy> LEIssuedBy { get => _lEIssuedBy; set => SetField(ref _lEIssuedBy, value); }

        /// <summary>
        /// TPO Loan Officer Address [TPO.X68]
        /// </summary>
        public string LOAddress { get => _lOAddress; set => SetField(ref _lOAddress, value); }

        /// <summary>
        /// TPO Loan Officer Sales Rep/AE [TPO.X56]
        /// </summary>
        public string LOAEName { get => _lOAEName; set => SetField(ref _lOAEName, value); }

        /// <summary>
        /// TPO Loan Officer Sales Rep/AE User ID [TPO.X57]
        /// </summary>
        public string LOAEUserName { get => _lOAEUserName; set => SetField(ref _lOAEUserName, value); }

        /// <summary>
        /// Loan Estimate Requested Date [TPO.X111]
        /// </summary>
        public DateTime? LoanEstimateRequestedDate { get => _loanEstimateRequestedDate; set => SetField(ref _loanEstimateRequestedDate, value); }

        /// <summary>
        /// TPO Loan Officer Business Fax [TPO.X66]
        /// </summary>
        public string LOBusinessFax { get => _lOBusinessFax; set => SetField(ref _lOBusinessFax, value); }

        /// <summary>
        /// TPO Loan Officer Business Phone [TPO.X65]
        /// </summary>
        public string LOBusinessPhone { get => _lOBusinessPhone; set => SetField(ref _lOBusinessPhone, value); }

        /// <summary>
        /// TPO Loan Officer Cell Phone [TPO.X67]
        /// </summary>
        public string LOCellPhone { get => _lOCellPhone; set => SetField(ref _lOCellPhone, value); }

        /// <summary>
        /// TPO Loan Officer Address City [TPO.X69]
        /// </summary>
        public string LOCity { get => _lOCity; set => SetField(ref _lOCity, value); }

        /// <summary>
        /// TPO Loan Officer Email/User Name [TPO.X63]
        /// </summary>
        public string LOEmail { get => _lOEmail; set => SetField(ref _lOEmail, value); }

        /// <summary>
        /// TPO Loan Officer ID [TPO.X62]
        /// </summary>
        public string LOID { get => _lOID; set => SetField(ref _lOID, value); }

        /// <summary>
        /// TPO Loan Officer Name [TPO.X61]
        /// </summary>
        public string LOName { get => _lOName; set => SetField(ref _lOName, value); }

        /// <summary>
        /// TPO Loan Officer Notes [TPO.X72]
        /// </summary>
        public string LONotes { get => _lONotes; set => SetField(ref _lONotes, value); }

        /// <summary>
        /// TPO Loan Officer Address State [TPO.X70]
        /// </summary>
        public StringEnumValue<State> LOState { get => _lOState; set => SetField(ref _lOState, value); }

        /// <summary>
        /// TPO Loan Officer Status [TPO.X64]
        /// </summary>
        public string LOStatus { get => _lOStatus; set => SetField(ref _lOStatus, value); }

        /// <summary>
        /// TPO Loan Officer Address Zipcode [TPO.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LOZip { get => _lOZip; set => SetField(ref _lOZip, value); }

        /// <summary>
        /// TPO Loan Processor Address [TPO.X81]
        /// </summary>
        public string LPAddress { get => _lPAddress; set => SetField(ref _lPAddress, value); }

        /// <summary>
        /// TPO Loan Processor Sales Rep/AE [TPO.X58]
        /// </summary>
        public string LPAEName { get => _lPAEName; set => SetField(ref _lPAEName, value); }

        /// <summary>
        /// TPO Loan Processor Sales Rep/AE User ID [TPO.X59]
        /// </summary>
        public string LPAEUserName { get => _lPAEUserName; set => SetField(ref _lPAEUserName, value); }

        /// <summary>
        /// TPO Loan Processor Business Fax [TPO.X79]
        /// </summary>
        public string LPBusinessFax { get => _lPBusinessFax; set => SetField(ref _lPBusinessFax, value); }

        /// <summary>
        /// TPO Loan Processor Business Phone [TPO.X78]
        /// </summary>
        public string LPBusinessPhone { get => _lPBusinessPhone; set => SetField(ref _lPBusinessPhone, value); }

        /// <summary>
        /// TPO Loan Processor Cell Phone [TPO.X80]
        /// </summary>
        public string LPCellPhone { get => _lPCellPhone; set => SetField(ref _lPCellPhone, value); }

        /// <summary>
        /// TPO Loan Processor Address City [TPO.X82]
        /// </summary>
        public string LPCity { get => _lPCity; set => SetField(ref _lPCity, value); }

        /// <summary>
        /// TPO Loan Processor Email/User Name [TPO.X76]
        /// </summary>
        public string LPEmail { get => _lPEmail; set => SetField(ref _lPEmail, value); }

        /// <summary>
        /// TPO Loan Processor ID [TPO.X75]
        /// </summary>
        public string LPID { get => _lPID; set => SetField(ref _lPID, value); }

        /// <summary>
        /// TPO Loan Processor Name [TPO.X74]
        /// </summary>
        public string LPName { get => _lPName; set => SetField(ref _lPName, value); }

        /// <summary>
        /// TPO Loan Processor Notes [TPO.X85]
        /// </summary>
        public string LPNotes { get => _lPNotes; set => SetField(ref _lPNotes, value); }

        /// <summary>
        /// TPO Loan Processor Address State [TPO.X83]
        /// </summary>
        public StringEnumValue<State> LPState { get => _lPState; set => SetField(ref _lPState, value); }

        /// <summary>
        /// TPO Loan Processor Status [TPO.X77]
        /// </summary>
        public string LPStatus { get => _lPStatus; set => SetField(ref _lPStatus, value); }

        /// <summary>
        /// TPO Loan Processor Address Zipcode [TPO.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string LPZip { get => _lPZip; set => SetField(ref _lPZip, value); }

        /// <summary>
        /// Purch Conds Ready Date [TPO.X94]
        /// </summary>
        public DateTime? PurchaseStipsReadyDate { get => _purchaseStipsReadyDate; set => SetField(ref _purchaseStipsReadyDate, value); }

        /// <summary>
        /// Purch Conds Ready for Review [TPO.X93]
        /// </summary>
        public bool? PurchaseStipsReviewed { get => _purchaseStipsReviewed; set => SetField(ref _purchaseStipsReviewed, value); }

        /// <summary>
        /// TPO Ready to Disclose Date [TPO.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ReadytoDiscloseDateUtc { get => _readytoDiscloseDateUtc; set => SetField(ref _readytoDiscloseDateUtc, value); }

        /// <summary>
        /// TPO Registration Date [TPO.X3]
        /// </summary>
        public DateTime? RegisterDate { get => _registerDate; set => SetField(ref _registerDate, value); }

        /// <summary>
        /// TPO Site ID [TPO.X1]
        /// </summary>
        public string SITEID { get => _sITEID; set => SetField(ref _sITEID, value); }

        /// <summary>
        /// TPO Submittal Date [TPO.X4]
        /// </summary>
        public DateTime? SubmitDate { get => _submitDate; set => SetField(ref _submitDate, value); }

        /// <summary>
        /// Indicator that the user logged in using a TPO test account [TPO.X91]
        /// </summary>
        public bool? TestAccountField { get => _testAccountField; set => SetField(ref _testAccountField, value); }

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
}