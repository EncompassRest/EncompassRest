using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TPO
    /// </summary>
    public sealed partial class TPO : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _archived;
        /// <summary>
        /// TPO Archived [TPO.X8]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Archived")]
        public bool? Archived { get => _archived; set => _archived = value; }
        private DirtyValue<string> _branchAddress;
        /// <summary>
        /// TPO Branch Address [TPO.X42]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Address")]
        public string BranchAddress { get => _branchAddress; set => _branchAddress = value; }
        private DirtyValue<string> _branchAEName;
        /// <summary>
        /// TPO Branch AE Name [TPO.X54]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch AE Name")]
        public string BranchAEName { get => _branchAEName; set => _branchAEName = value; }
        private DirtyValue<string> _branchAEUserName;
        /// <summary>
        /// TPO Branch AE User Name [TPO.X55]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch AE User Name")]
        public string BranchAEUserName { get => _branchAEUserName; set => _branchAEUserName = value; }
        private DirtyValue<string> _branchCity;
        /// <summary>
        /// TPO Branch Address City [TPO.X43]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Address City")]
        public string BranchCity { get => _branchCity; set => _branchCity = value; }
        private DirtyValue<string> _branchDBAName;
        /// <summary>
        /// TPO Branch DBA Name [TPO.X48]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch DBA Name")]
        public string BranchDBAName { get => _branchDBAName; set => _branchDBAName = value; }
        private DirtyValue<string> _branchFax;
        /// <summary>
        /// TPO Branch Fax [TPO.X47]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Fax")]
        public string BranchFax { get => _branchFax; set => _branchFax = value; }
        private DirtyValue<string> _branchID;
        /// <summary>
        /// TPO Branch ID [TPO.X39]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch ID")]
        public string BranchID { get => _branchID; set => _branchID = value; }
        private DirtyValue<string> _branchLegalName;
        /// <summary>
        /// TPO Branch Legal Name [TPO.X41]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Legal Name")]
        public string BranchLegalName { get => _branchLegalName; set => _branchLegalName = value; }
        private DirtyValue<string> _branchManagerEmail;
        /// <summary>
        /// TPO Branch Manager Email [TPO.X53]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Manager Email")]
        public string BranchManagerEmail { get => _branchManagerEmail; set => _branchManagerEmail = value; }
        private DirtyValue<string> _branchManagerName;
        /// <summary>
        /// TPO Branch Manager Name [TPO.X52]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Manager Name")]
        public string BranchManagerName { get => _branchManagerName; set => _branchManagerName = value; }
        private DirtyValue<string> _branchName;
        /// <summary>
        /// TPO Branch Name [TPO.X38]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Name")]
        public string BranchName { get => _branchName; set => _branchName = value; }
        private DirtyValue<string> _branchOrganizationID;
        /// <summary>
        /// TPO Branch Organization ID [TPO.X40]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Organization ID")]
        public string BranchOrganizationID { get => _branchOrganizationID; set => _branchOrganizationID = value; }
        private DirtyValue<string> _branchPhone;
        /// <summary>
        /// TPO Branch Phone [TPO.X46]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Phone")]
        public string BranchPhone { get => _branchPhone; set => _branchPhone = value; }
        private DirtyValue<string> _branchRating;
        /// <summary>
        /// TPO Branch Rating [TPO.X51]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Branch Rating")]
        public string BranchRating { get => _branchRating; set => _branchRating = value; }
        private DirtyValue<string> _branchState;
        /// <summary>
        /// TPO Branch Address State [TPO.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "TPO Branch Address State")]
        public string BranchState { get => _branchState; set => _branchState = value; }
        private DirtyValue<string> _branchZip;
        /// <summary>
        /// TPO Branch Address Zipcode [TPO.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "TPO Branch Address Zipcode")]
        public string BranchZip { get => _branchZip; set => _branchZip = value; }
        private DirtyValue<string> _cFCAddress;
        /// <summary>
        /// TPO Correspondent File Contact Address [TPO.X102]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Address")]
        public string CFCAddress { get => _cFCAddress; set => _cFCAddress = value; }
        private DirtyValue<string> _cFCBusinessFax;
        /// <summary>
        /// TPO Correspondent File Contact Business Fax [TPO.X100]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Business Fax")]
        public string CFCBusinessFax { get => _cFCBusinessFax; set => _cFCBusinessFax = value; }
        private DirtyValue<string> _cFCBusinessPhone;
        /// <summary>
        /// TPO Correspondent File Contact Business Phone [TPO.X99]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Business Phone")]
        public string CFCBusinessPhone { get => _cFCBusinessPhone; set => _cFCBusinessPhone = value; }
        private DirtyValue<string> _cFCCellPhone;
        /// <summary>
        /// TPO Correspondent File Contact Cell Phone [TPO.X101]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Cell Phone")]
        public string CFCCellPhone { get => _cFCCellPhone; set => _cFCCellPhone = value; }
        private DirtyValue<string> _cFCCity;
        /// <summary>
        /// TPO Correspondent File Contact Address City [TPO.X103]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Address City")]
        public string CFCCity { get => _cFCCity; set => _cFCCity = value; }
        private DirtyValue<string> _cFCEmail;
        /// <summary>
        /// TPO Correspondent File Contact Email/User Name [TPO.X97]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Email/User Name")]
        public string CFCEmail { get => _cFCEmail; set => _cFCEmail = value; }
        private DirtyValue<string> _cFCName;
        /// <summary>
        /// TPO Correspondent File Contact Name [TPO.X95]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Name")]
        public string CFCName { get => _cFCName; set => _cFCName = value; }
        private DirtyValue<string> _cFCNotes;
        /// <summary>
        /// TPO Correspondent File Contact Notes [TPO.X106]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Notes")]
        public string CFCNotes { get => _cFCNotes; set => _cFCNotes = value; }
        private DirtyValue<string> _cFCRepAE;
        /// <summary>
        /// TPO Correspondent File Contact Rep/AE [TPO.X107]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Rep/AE")]
        public string CFCRepAE { get => _cFCRepAE; set => _cFCRepAE = value; }
        private DirtyValue<string> _cFCSRAEUserName;
        /// <summary>
        /// TPO Correspondent File Contact SR/AE User ID [TPO.X108]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact SR/AE User ID")]
        public string CFCSRAEUserName { get => _cFCSRAEUserName; set => _cFCSRAEUserName = value; }
        private DirtyValue<string> _cFCState;
        /// <summary>
        /// TPO Correspondent File Contact Address State [TPO.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "TPO Correspondent File Contact Address State")]
        public string CFCState { get => _cFCState; set => _cFCState = value; }
        private DirtyValue<string> _cFCStatus;
        /// <summary>
        /// TPO Correspondent File Contact Status [TPO.X98]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact Status")]
        public string CFCStatus { get => _cFCStatus; set => _cFCStatus = value; }
        private DirtyValue<string> _cFCUserID;
        /// <summary>
        /// TPO Correspondent File Contact User ID [TPO.X96]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Correspondent File Contact User ID")]
        public string CFCUserID { get => _cFCUserID; set => _cFCUserID = value; }
        private DirtyValue<string> _cFCZip;
        /// <summary>
        /// TPO Correspondent File Contact Address Zipcode [TPO.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "TPO Correspondent File Contact Address Zipcode")]
        public string CFCZip { get => _cFCZip; set => _cFCZip = value; }
        private DirtyValue<string> _companyAddress;
        /// <summary>
        /// TPO Company Address [TPO.X18]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Address")]
        public string CompanyAddress { get => _companyAddress; set => _companyAddress = value; }
        private DirtyValue<string> _companyAEName;
        /// <summary>
        /// TPO Company AE Name [TPO.X30]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company AE Name")]
        public string CompanyAEName { get => _companyAEName; set => _companyAEName = value; }
        private DirtyValue<string> _companyAEUserName;
        /// <summary>
        /// TPO Company AE User Name [TPO.X31]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company AE User Name")]
        public string CompanyAEUserName { get => _companyAEUserName; set => _companyAEUserName = value; }
        private DirtyValue<string> _companyCity;
        /// <summary>
        /// TPO Company Address City [TPO.X19]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Address City")]
        public string CompanyCity { get => _companyCity; set => _companyCity = value; }
        private DirtyValue<string> _companyDBAName;
        /// <summary>
        /// TPO Company DBA Name [TPO.X24]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company DBA Name")]
        public string CompanyDBAName { get => _companyDBAName; set => _companyDBAName = value; }
        private DirtyValue<string> _companyFax;
        /// <summary>
        /// TPO Company Fax [TPO.X23]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Fax")]
        public string CompanyFax { get => _companyFax; set => _companyFax = value; }
        private DirtyValue<string> _companyID;
        /// <summary>
        /// TPO Company ID [TPO.X15]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company ID")]
        public string CompanyID { get => _companyID; set => _companyID = value; }
        private DirtyValue<string> _companyLegalName;
        /// <summary>
        /// TPO Company Legal Name [TPO.X17]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Legal Name")]
        public string CompanyLegalName { get => _companyLegalName; set => _companyLegalName = value; }
        private DirtyValue<string> _companyManagerEmail;
        /// <summary>
        /// TPO Company Manager Email [TPO.X29]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Manager Email")]
        public string CompanyManagerEmail { get => _companyManagerEmail; set => _companyManagerEmail = value; }
        private DirtyValue<string> _companyManagerName;
        /// <summary>
        /// TPO Company Manager Name [TPO.X28]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Manager Name")]
        public string CompanyManagerName { get => _companyManagerName; set => _companyManagerName = value; }
        private DirtyValue<string> _companyName;
        /// <summary>
        /// TPO Company Name [TPO.X14]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Name")]
        public string CompanyName { get => _companyName; set => _companyName = value; }
        private DirtyValue<string> _companyOrganizationID;
        /// <summary>
        /// TPO Company Organization ID [TPO.X16]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Organization ID")]
        public string CompanyOrganizationID { get => _companyOrganizationID; set => _companyOrganizationID = value; }
        private DirtyValue<string> _companyPhone;
        /// <summary>
        /// TPO Company Phone [TPO.X22]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Phone")]
        public string CompanyPhone { get => _companyPhone; set => _companyPhone = value; }
        private DirtyValue<string> _companyRating;
        /// <summary>
        /// TPO Company Rating [TPO.X27]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Company Rating")]
        public string CompanyRating { get => _companyRating; set => _companyRating = value; }
        private DirtyValue<string> _companyState;
        /// <summary>
        /// TPO Company Address State [TPO.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "TPO Company Address State")]
        public string CompanyState { get => _companyState; set => _companyState = value; }
        private DirtyValue<string> _companyZip;
        /// <summary>
        /// TPO Company Address Zipcode [TPO.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "TPO Company Address Zipcode")]
        public string CompanyZip { get => _companyZip; set => _companyZip = value; }
        private DirtyValue<DateTime?> _documentsReadyDate;
        /// <summary>
        /// TPO Documents and Conditions are Ready for Underwriter Review Date [TPO.X10]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Documents and Conditions are Ready for Underwriter Review Date")]
        public DateTime? DocumentsReadyDate { get => _documentsReadyDate; set => _documentsReadyDate = value; }
        private DirtyValue<string> _feeReviewComments;
        /// <summary>
        /// TPO Fee Review Comments [TPO.X12]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Fee Review Comments")]
        public string FeeReviewComments { get => _feeReviewComments; set => _feeReviewComments = value; }
        private DirtyValue<string> _feeReviewStatus;
        /// <summary>
        /// TPO Fee Review Status [TPO.X6]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Fee Review Status")]
        public string FeeReviewStatus { get => _feeReviewStatus; set => _feeReviewStatus = value; }
        private DirtyValue<DateTime?> _feeReviewStatusDate;
        /// <summary>
        /// TPO Fee Review Status Date [TPO.X11]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Fee Review Status Date")]
        public DateTime? FeeReviewStatusDate { get => _feeReviewStatusDate; set => _feeReviewStatusDate = value; }
        private DirtyValue<string> _importSource;
        /// <summary>
        /// TPO Import Source [TPO.X9]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Import Source")]
        public string ImportSource { get => _importSource; set => _importSource = value; }
        private DirtyValue<DateTime?> _initialApplicationDate;
        /// <summary>
        /// Initial TPO Application Date [TPO.X89]
        /// </summary>
        [LoanFieldProperty(Description = "Initial TPO Application Date")]
        public DateTime? InitialApplicationDate { get => _initialApplicationDate; set => _initialApplicationDate = value; }
        private DirtyValue<DateTime?> _initialSubmitDate;
        /// <summary>
        /// Initial TPO Submittal Date [TPO.X90]
        /// </summary>
        [LoanFieldProperty(Description = "Initial TPO Submittal Date")]
        public DateTime? InitialSubmitDate { get => _initialSubmitDate; set => _initialSubmitDate = value; }
        private DirtyValue<string> _lOAddress;
        /// <summary>
        /// TPO Loan Officer Address [TPO.X68]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Address")]
        public string LOAddress { get => _lOAddress; set => _lOAddress = value; }
        private DirtyValue<string> _lOAEName;
        /// <summary>
        /// TPO Loan Officer Sales Rep/AE [TPO.X56]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Sales Rep/AE")]
        public string LOAEName { get => _lOAEName; set => _lOAEName = value; }
        private DirtyValue<string> _lOAEUserName;
        /// <summary>
        /// TPO Loan Officer Sales Rep/AE User ID [TPO.X57]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Sales Rep/AE User ID")]
        public string LOAEUserName { get => _lOAEUserName; set => _lOAEUserName = value; }
        private DirtyValue<string> _lOBusinessFax;
        /// <summary>
        /// TPO Loan Officer Business Fax [TPO.X66]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Business Fax")]
        public string LOBusinessFax { get => _lOBusinessFax; set => _lOBusinessFax = value; }
        private DirtyValue<string> _lOBusinessPhone;
        /// <summary>
        /// TPO Loan Officer Business Phone [TPO.X65]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Business Phone")]
        public string LOBusinessPhone { get => _lOBusinessPhone; set => _lOBusinessPhone = value; }
        private DirtyValue<string> _lOCellPhone;
        /// <summary>
        /// TPO Loan Officer Cell Phone [TPO.X67]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Cell Phone")]
        public string LOCellPhone { get => _lOCellPhone; set => _lOCellPhone = value; }
        private DirtyValue<string> _lOCity;
        /// <summary>
        /// TPO Loan Officer Address City [TPO.X69]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Address City")]
        public string LOCity { get => _lOCity; set => _lOCity = value; }
        private DirtyValue<string> _lOEmail;
        /// <summary>
        /// TPO Loan Officer Email/User Name [TPO.X63]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Email/User Name")]
        public string LOEmail { get => _lOEmail; set => _lOEmail = value; }
        private DirtyValue<string> _lOID;
        /// <summary>
        /// TPO Loan Officer ID [TPO.X62]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer ID")]
        public string LOID { get => _lOID; set => _lOID = value; }
        private DirtyValue<string> _lOName;
        /// <summary>
        /// TPO Loan Officer Name [TPO.X61]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Name")]
        public string LOName { get => _lOName; set => _lOName = value; }
        private DirtyValue<string> _lONotes;
        /// <summary>
        /// TPO Loan Officer Notes [TPO.X72]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Notes")]
        public string LONotes { get => _lONotes; set => _lONotes = value; }
        private DirtyValue<string> _lOState;
        /// <summary>
        /// TPO Loan Officer Address State [TPO.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "TPO Loan Officer Address State")]
        public string LOState { get => _lOState; set => _lOState = value; }
        private DirtyValue<string> _lOStatus;
        /// <summary>
        /// TPO Loan Officer Status [TPO.X64]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Officer Status")]
        public string LOStatus { get => _lOStatus; set => _lOStatus = value; }
        private DirtyValue<string> _lOZip;
        /// <summary>
        /// TPO Loan Officer Address Zipcode [TPO.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "TPO Loan Officer Address Zipcode")]
        public string LOZip { get => _lOZip; set => _lOZip = value; }
        private DirtyValue<string> _lPAddress;
        /// <summary>
        /// TPO Loan Processor Address [TPO.X81]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Address")]
        public string LPAddress { get => _lPAddress; set => _lPAddress = value; }
        private DirtyValue<string> _lPAEName;
        /// <summary>
        /// TPO Loan Processor Sales Rep/AE [TPO.X58]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Sales Rep/AE")]
        public string LPAEName { get => _lPAEName; set => _lPAEName = value; }
        private DirtyValue<string> _lPAEUserName;
        /// <summary>
        /// TPO Loan Processor Sales Rep/AE User ID [TPO.X59]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Sales Rep/AE User ID")]
        public string LPAEUserName { get => _lPAEUserName; set => _lPAEUserName = value; }
        private DirtyValue<string> _lPBusinessFax;
        /// <summary>
        /// TPO Loan Processor Business Fax [TPO.X79]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Business Fax")]
        public string LPBusinessFax { get => _lPBusinessFax; set => _lPBusinessFax = value; }
        private DirtyValue<string> _lPBusinessPhone;
        /// <summary>
        /// TPO Loan Processor Business Phone [TPO.X78]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Business Phone")]
        public string LPBusinessPhone { get => _lPBusinessPhone; set => _lPBusinessPhone = value; }
        private DirtyValue<string> _lPCellPhone;
        /// <summary>
        /// TPO Loan Processor Cell Phone [TPO.X80]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Cell Phone")]
        public string LPCellPhone { get => _lPCellPhone; set => _lPCellPhone = value; }
        private DirtyValue<string> _lPCity;
        /// <summary>
        /// TPO Loan Processor Address City [TPO.X82]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Address City")]
        public string LPCity { get => _lPCity; set => _lPCity = value; }
        private DirtyValue<string> _lPEmail;
        /// <summary>
        /// TPO Loan Processor Email/User Name [TPO.X76]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Email/User Name")]
        public string LPEmail { get => _lPEmail; set => _lPEmail = value; }
        private DirtyValue<string> _lPID;
        /// <summary>
        /// TPO Loan Processor ID [TPO.X75]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor ID")]
        public string LPID { get => _lPID; set => _lPID = value; }
        private DirtyValue<string> _lPName;
        /// <summary>
        /// TPO Loan Processor Name [TPO.X74]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Name")]
        public string LPName { get => _lPName; set => _lPName = value; }
        private DirtyValue<string> _lPNotes;
        /// <summary>
        /// TPO Loan Processor Notes [TPO.X85]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Notes")]
        public string LPNotes { get => _lPNotes; set => _lPNotes = value; }
        private DirtyValue<string> _lPState;
        /// <summary>
        /// TPO Loan Processor Address State [TPO.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "TPO Loan Processor Address State")]
        public string LPState { get => _lPState; set => _lPState = value; }
        private DirtyValue<string> _lPStatus;
        /// <summary>
        /// TPO Loan Processor Status [TPO.X77]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Loan Processor Status")]
        public string LPStatus { get => _lPStatus; set => _lPStatus = value; }
        private DirtyValue<string> _lPZip;
        /// <summary>
        /// TPO Loan Processor Address Zipcode [TPO.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "TPO Loan Processor Address Zipcode")]
        public string LPZip { get => _lPZip; set => _lPZip = value; }
        private DirtyValue<DateTime?> _purchaseStipsReadyDate;
        /// <summary>
        /// Purch Conds Ready Date [TPO.X94]
        /// </summary>
        [LoanFieldProperty(Description = "Purch Conds Ready Date")]
        public DateTime? PurchaseStipsReadyDate { get => _purchaseStipsReadyDate; set => _purchaseStipsReadyDate = value; }
        private DirtyValue<bool?> _purchaseStipsReviewed;
        /// <summary>
        /// Purch Conds Ready for Review [TPO.X93]
        /// </summary>
        [LoanFieldProperty(Description = "Purch Conds Ready for Review")]
        public bool? PurchaseStipsReviewed { get => _purchaseStipsReviewed; set => _purchaseStipsReviewed = value; }
        private DirtyValue<DateTime?> _readytoDiscloseDateUtc;
        /// <summary>
        /// TPO Ready to Disclose Date [TPO.X92]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Ready to Disclose Date")]
        public DateTime? ReadytoDiscloseDateUtc { get => _readytoDiscloseDateUtc; set => _readytoDiscloseDateUtc = value; }
        private DirtyValue<DateTime?> _registerDate;
        /// <summary>
        /// TPO Registeration Date [TPO.X3]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Registeration Date")]
        public DateTime? RegisterDate { get => _registerDate; set => _registerDate = value; }
        private DirtyValue<string> _sITEID;
        /// <summary>
        /// TPO Site ID [TPO.X1]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Site ID")]
        public string SITEID { get => _sITEID; set => _sITEID = value; }
        private DirtyValue<DateTime?> _submitDate;
        /// <summary>
        /// TPO Submittal Date [TPO.X4]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Submittal Date")]
        public DateTime? SubmitDate { get => _submitDate; set => _submitDate = value; }
        private DirtyValue<bool?> _testAccountField;
        /// <summary>
        /// Indicator that the user logged in using a TPO test account [TPO.X91]
        /// </summary>
        [LoanFieldProperty(Description = "Indicator that the user logged in using a TPO test account")]
        public bool? TestAccountField { get => _testAccountField; set => _testAccountField = value; }
        private DirtyValue<bool?> _underwriterReviewed;
        /// <summary>
        /// TPO Documents and Conditions are Ready for Underwriter Review [TPO.X5]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Documents and Conditions are Ready for Underwriter Review")]
        public bool? UnderwriterReviewed { get => _underwriterReviewed; set => _underwriterReviewed = value; }
        private DirtyValue<bool?> _underwritingDelegated;
        /// <summary>
        /// TPO Underwriting Delegated [TPO.X88]
        /// </summary>
        [LoanFieldProperty(Description = "TPO Underwriting Delegated")]
        public bool? UnderwritingDelegated { get => _underwritingDelegated; set => _underwritingDelegated = value; }
        private DirtyValue<bool?> _watchListFlag;
        /// <summary>
        /// TPO WatchList Flag [TPO.X86]
        /// </summary>
        [LoanFieldProperty(Description = "TPO WatchList Flag")]
        public bool? WatchListFlag { get => _watchListFlag; set => _watchListFlag = value; }
        private DirtyValue<StringEnumValue<WatchListReason>> _watchListReason;
        /// <summary>
        /// TPO WatchList Reason [TPO.X87]
        /// </summary>
        [LoanFieldProperty(Description = "TPO WatchList Reason")]
        public StringEnumValue<WatchListReason> WatchListReason { get => _watchListReason; set => _watchListReason = value; }
        internal override bool DirtyInternal
        {
            get => _archived.Dirty
                || _branchAddress.Dirty
                || _branchAEName.Dirty
                || _branchAEUserName.Dirty
                || _branchCity.Dirty
                || _branchDBAName.Dirty
                || _branchFax.Dirty
                || _branchID.Dirty
                || _branchLegalName.Dirty
                || _branchManagerEmail.Dirty
                || _branchManagerName.Dirty
                || _branchName.Dirty
                || _branchOrganizationID.Dirty
                || _branchPhone.Dirty
                || _branchRating.Dirty
                || _branchState.Dirty
                || _branchZip.Dirty
                || _cFCAddress.Dirty
                || _cFCBusinessFax.Dirty
                || _cFCBusinessPhone.Dirty
                || _cFCCellPhone.Dirty
                || _cFCCity.Dirty
                || _cFCEmail.Dirty
                || _cFCName.Dirty
                || _cFCNotes.Dirty
                || _cFCRepAE.Dirty
                || _cFCSRAEUserName.Dirty
                || _cFCState.Dirty
                || _cFCStatus.Dirty
                || _cFCUserID.Dirty
                || _cFCZip.Dirty
                || _companyAddress.Dirty
                || _companyAEName.Dirty
                || _companyAEUserName.Dirty
                || _companyCity.Dirty
                || _companyDBAName.Dirty
                || _companyFax.Dirty
                || _companyID.Dirty
                || _companyLegalName.Dirty
                || _companyManagerEmail.Dirty
                || _companyManagerName.Dirty
                || _companyName.Dirty
                || _companyOrganizationID.Dirty
                || _companyPhone.Dirty
                || _companyRating.Dirty
                || _companyState.Dirty
                || _companyZip.Dirty
                || _documentsReadyDate.Dirty
                || _feeReviewComments.Dirty
                || _feeReviewStatus.Dirty
                || _feeReviewStatusDate.Dirty
                || _importSource.Dirty
                || _initialApplicationDate.Dirty
                || _initialSubmitDate.Dirty
                || _lOAddress.Dirty
                || _lOAEName.Dirty
                || _lOAEUserName.Dirty
                || _lOBusinessFax.Dirty
                || _lOBusinessPhone.Dirty
                || _lOCellPhone.Dirty
                || _lOCity.Dirty
                || _lOEmail.Dirty
                || _lOID.Dirty
                || _lOName.Dirty
                || _lONotes.Dirty
                || _lOState.Dirty
                || _lOStatus.Dirty
                || _lOZip.Dirty
                || _lPAddress.Dirty
                || _lPAEName.Dirty
                || _lPAEUserName.Dirty
                || _lPBusinessFax.Dirty
                || _lPBusinessPhone.Dirty
                || _lPCellPhone.Dirty
                || _lPCity.Dirty
                || _lPEmail.Dirty
                || _lPID.Dirty
                || _lPName.Dirty
                || _lPNotes.Dirty
                || _lPState.Dirty
                || _lPStatus.Dirty
                || _lPZip.Dirty
                || _purchaseStipsReadyDate.Dirty
                || _purchaseStipsReviewed.Dirty
                || _readytoDiscloseDateUtc.Dirty
                || _registerDate.Dirty
                || _sITEID.Dirty
                || _submitDate.Dirty
                || _testAccountField.Dirty
                || _underwriterReviewed.Dirty
                || _underwritingDelegated.Dirty
                || _watchListFlag.Dirty
                || _watchListReason.Dirty;
            set
            {
                _archived.Dirty = value;
                _branchAddress.Dirty = value;
                _branchAEName.Dirty = value;
                _branchAEUserName.Dirty = value;
                _branchCity.Dirty = value;
                _branchDBAName.Dirty = value;
                _branchFax.Dirty = value;
                _branchID.Dirty = value;
                _branchLegalName.Dirty = value;
                _branchManagerEmail.Dirty = value;
                _branchManagerName.Dirty = value;
                _branchName.Dirty = value;
                _branchOrganizationID.Dirty = value;
                _branchPhone.Dirty = value;
                _branchRating.Dirty = value;
                _branchState.Dirty = value;
                _branchZip.Dirty = value;
                _cFCAddress.Dirty = value;
                _cFCBusinessFax.Dirty = value;
                _cFCBusinessPhone.Dirty = value;
                _cFCCellPhone.Dirty = value;
                _cFCCity.Dirty = value;
                _cFCEmail.Dirty = value;
                _cFCName.Dirty = value;
                _cFCNotes.Dirty = value;
                _cFCRepAE.Dirty = value;
                _cFCSRAEUserName.Dirty = value;
                _cFCState.Dirty = value;
                _cFCStatus.Dirty = value;
                _cFCUserID.Dirty = value;
                _cFCZip.Dirty = value;
                _companyAddress.Dirty = value;
                _companyAEName.Dirty = value;
                _companyAEUserName.Dirty = value;
                _companyCity.Dirty = value;
                _companyDBAName.Dirty = value;
                _companyFax.Dirty = value;
                _companyID.Dirty = value;
                _companyLegalName.Dirty = value;
                _companyManagerEmail.Dirty = value;
                _companyManagerName.Dirty = value;
                _companyName.Dirty = value;
                _companyOrganizationID.Dirty = value;
                _companyPhone.Dirty = value;
                _companyRating.Dirty = value;
                _companyState.Dirty = value;
                _companyZip.Dirty = value;
                _documentsReadyDate.Dirty = value;
                _feeReviewComments.Dirty = value;
                _feeReviewStatus.Dirty = value;
                _feeReviewStatusDate.Dirty = value;
                _importSource.Dirty = value;
                _initialApplicationDate.Dirty = value;
                _initialSubmitDate.Dirty = value;
                _lOAddress.Dirty = value;
                _lOAEName.Dirty = value;
                _lOAEUserName.Dirty = value;
                _lOBusinessFax.Dirty = value;
                _lOBusinessPhone.Dirty = value;
                _lOCellPhone.Dirty = value;
                _lOCity.Dirty = value;
                _lOEmail.Dirty = value;
                _lOID.Dirty = value;
                _lOName.Dirty = value;
                _lONotes.Dirty = value;
                _lOState.Dirty = value;
                _lOStatus.Dirty = value;
                _lOZip.Dirty = value;
                _lPAddress.Dirty = value;
                _lPAEName.Dirty = value;
                _lPAEUserName.Dirty = value;
                _lPBusinessFax.Dirty = value;
                _lPBusinessPhone.Dirty = value;
                _lPCellPhone.Dirty = value;
                _lPCity.Dirty = value;
                _lPEmail.Dirty = value;
                _lPID.Dirty = value;
                _lPName.Dirty = value;
                _lPNotes.Dirty = value;
                _lPState.Dirty = value;
                _lPStatus.Dirty = value;
                _lPZip.Dirty = value;
                _purchaseStipsReadyDate.Dirty = value;
                _purchaseStipsReviewed.Dirty = value;
                _readytoDiscloseDateUtc.Dirty = value;
                _registerDate.Dirty = value;
                _sITEID.Dirty = value;
                _submitDate.Dirty = value;
                _testAccountField.Dirty = value;
                _underwriterReviewed.Dirty = value;
                _underwritingDelegated.Dirty = value;
                _watchListFlag.Dirty = value;
                _watchListReason.Dirty = value;
            }
        }
    }
}