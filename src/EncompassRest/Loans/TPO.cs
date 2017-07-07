using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TPO : IClean
    {
        private Value<bool?> _archived;
        public bool? Archived { get { return _archived; } set { _archived = value; } }
        private Value<string> _branchAddress;
        public string BranchAddress { get { return _branchAddress; } set { _branchAddress = value; } }
        private Value<string> _branchAEName;
        public string BranchAEName { get { return _branchAEName; } set { _branchAEName = value; } }
        private Value<string> _branchAEUserName;
        public string BranchAEUserName { get { return _branchAEUserName; } set { _branchAEUserName = value; } }
        private Value<string> _branchCity;
        public string BranchCity { get { return _branchCity; } set { _branchCity = value; } }
        private Value<string> _branchDBAName;
        public string BranchDBAName { get { return _branchDBAName; } set { _branchDBAName = value; } }
        private Value<string> _branchFax;
        public string BranchFax { get { return _branchFax; } set { _branchFax = value; } }
        private Value<string> _branchID;
        public string BranchID { get { return _branchID; } set { _branchID = value; } }
        private Value<string> _branchLegalName;
        public string BranchLegalName { get { return _branchLegalName; } set { _branchLegalName = value; } }
        private Value<string> _branchManagerEmail;
        public string BranchManagerEmail { get { return _branchManagerEmail; } set { _branchManagerEmail = value; } }
        private Value<string> _branchManagerName;
        public string BranchManagerName { get { return _branchManagerName; } set { _branchManagerName = value; } }
        private Value<string> _branchName;
        public string BranchName { get { return _branchName; } set { _branchName = value; } }
        private Value<string> _branchOrganizationID;
        public string BranchOrganizationID { get { return _branchOrganizationID; } set { _branchOrganizationID = value; } }
        private Value<string> _branchPhone;
        public string BranchPhone { get { return _branchPhone; } set { _branchPhone = value; } }
        private Value<string> _branchRating;
        public string BranchRating { get { return _branchRating; } set { _branchRating = value; } }
        private Value<string> _branchState;
        public string BranchState { get { return _branchState; } set { _branchState = value; } }
        private Value<string> _branchZip;
        public string BranchZip { get { return _branchZip; } set { _branchZip = value; } }
        private Value<string> _cFCAddress;
        public string CFCAddress { get { return _cFCAddress; } set { _cFCAddress = value; } }
        private Value<string> _cFCBusinessFax;
        public string CFCBusinessFax { get { return _cFCBusinessFax; } set { _cFCBusinessFax = value; } }
        private Value<string> _cFCBusinessPhone;
        public string CFCBusinessPhone { get { return _cFCBusinessPhone; } set { _cFCBusinessPhone = value; } }
        private Value<string> _cFCCellPhone;
        public string CFCCellPhone { get { return _cFCCellPhone; } set { _cFCCellPhone = value; } }
        private Value<string> _cFCCity;
        public string CFCCity { get { return _cFCCity; } set { _cFCCity = value; } }
        private Value<string> _cFCEmail;
        public string CFCEmail { get { return _cFCEmail; } set { _cFCEmail = value; } }
        private Value<string> _cFCName;
        public string CFCName { get { return _cFCName; } set { _cFCName = value; } }
        private Value<string> _cFCNotes;
        public string CFCNotes { get { return _cFCNotes; } set { _cFCNotes = value; } }
        private Value<string> _cFCRepAE;
        public string CFCRepAE { get { return _cFCRepAE; } set { _cFCRepAE = value; } }
        private Value<string> _cFCSRAEUserName;
        public string CFCSRAEUserName { get { return _cFCSRAEUserName; } set { _cFCSRAEUserName = value; } }
        private Value<string> _cFCState;
        public string CFCState { get { return _cFCState; } set { _cFCState = value; } }
        private Value<string> _cFCStatus;
        public string CFCStatus { get { return _cFCStatus; } set { _cFCStatus = value; } }
        private Value<string> _cFCUserID;
        public string CFCUserID { get { return _cFCUserID; } set { _cFCUserID = value; } }
        private Value<string> _cFCZip;
        public string CFCZip { get { return _cFCZip; } set { _cFCZip = value; } }
        private Value<string> _companyAddress;
        public string CompanyAddress { get { return _companyAddress; } set { _companyAddress = value; } }
        private Value<string> _companyAEName;
        public string CompanyAEName { get { return _companyAEName; } set { _companyAEName = value; } }
        private Value<string> _companyAEUserName;
        public string CompanyAEUserName { get { return _companyAEUserName; } set { _companyAEUserName = value; } }
        private Value<string> _companyCity;
        public string CompanyCity { get { return _companyCity; } set { _companyCity = value; } }
        private Value<string> _companyDBAName;
        public string CompanyDBAName { get { return _companyDBAName; } set { _companyDBAName = value; } }
        private Value<string> _companyFax;
        public string CompanyFax { get { return _companyFax; } set { _companyFax = value; } }
        private Value<string> _companyID;
        public string CompanyID { get { return _companyID; } set { _companyID = value; } }
        private Value<string> _companyLegalName;
        public string CompanyLegalName { get { return _companyLegalName; } set { _companyLegalName = value; } }
        private Value<string> _companyManagerEmail;
        public string CompanyManagerEmail { get { return _companyManagerEmail; } set { _companyManagerEmail = value; } }
        private Value<string> _companyManagerName;
        public string CompanyManagerName { get { return _companyManagerName; } set { _companyManagerName = value; } }
        private Value<string> _companyName;
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }
        private Value<string> _companyOrganizationID;
        public string CompanyOrganizationID { get { return _companyOrganizationID; } set { _companyOrganizationID = value; } }
        private Value<string> _companyPhone;
        public string CompanyPhone { get { return _companyPhone; } set { _companyPhone = value; } }
        private Value<string> _companyRating;
        public string CompanyRating { get { return _companyRating; } set { _companyRating = value; } }
        private Value<string> _companyState;
        public string CompanyState { get { return _companyState; } set { _companyState = value; } }
        private Value<string> _companyZip;
        public string CompanyZip { get { return _companyZip; } set { _companyZip = value; } }
        private Value<DateTime?> _documentsReadyDate;
        public DateTime? DocumentsReadyDate { get { return _documentsReadyDate; } set { _documentsReadyDate = value; } }
        private Value<string> _feeReviewComments;
        public string FeeReviewComments { get { return _feeReviewComments; } set { _feeReviewComments = value; } }
        private Value<string> _feeReviewStatus;
        public string FeeReviewStatus { get { return _feeReviewStatus; } set { _feeReviewStatus = value; } }
        private Value<DateTime?> _feeReviewStatusDate;
        public DateTime? FeeReviewStatusDate { get { return _feeReviewStatusDate; } set { _feeReviewStatusDate = value; } }
        private Value<string> _importSource;
        public string ImportSource { get { return _importSource; } set { _importSource = value; } }
        private Value<DateTime?> _initialApplicationDate;
        public DateTime? InitialApplicationDate { get { return _initialApplicationDate; } set { _initialApplicationDate = value; } }
        private Value<DateTime?> _initialSubmitDate;
        public DateTime? InitialSubmitDate { get { return _initialSubmitDate; } set { _initialSubmitDate = value; } }
        private Value<string> _lOAddress;
        public string LOAddress { get { return _lOAddress; } set { _lOAddress = value; } }
        private Value<string> _lOAEName;
        public string LOAEName { get { return _lOAEName; } set { _lOAEName = value; } }
        private Value<string> _lOAEUserName;
        public string LOAEUserName { get { return _lOAEUserName; } set { _lOAEUserName = value; } }
        private Value<string> _lOBusinessFax;
        public string LOBusinessFax { get { return _lOBusinessFax; } set { _lOBusinessFax = value; } }
        private Value<string> _lOBusinessPhone;
        public string LOBusinessPhone { get { return _lOBusinessPhone; } set { _lOBusinessPhone = value; } }
        private Value<string> _lOCellPhone;
        public string LOCellPhone { get { return _lOCellPhone; } set { _lOCellPhone = value; } }
        private Value<string> _lOCity;
        public string LOCity { get { return _lOCity; } set { _lOCity = value; } }
        private Value<string> _lOEmail;
        public string LOEmail { get { return _lOEmail; } set { _lOEmail = value; } }
        private Value<string> _lOID;
        public string LOID { get { return _lOID; } set { _lOID = value; } }
        private Value<string> _lOName;
        public string LOName { get { return _lOName; } set { _lOName = value; } }
        private Value<string> _lONotes;
        public string LONotes { get { return _lONotes; } set { _lONotes = value; } }
        private Value<string> _lOState;
        public string LOState { get { return _lOState; } set { _lOState = value; } }
        private Value<string> _lOStatus;
        public string LOStatus { get { return _lOStatus; } set { _lOStatus = value; } }
        private Value<string> _lOZip;
        public string LOZip { get { return _lOZip; } set { _lOZip = value; } }
        private Value<string> _lPAddress;
        public string LPAddress { get { return _lPAddress; } set { _lPAddress = value; } }
        private Value<string> _lPAEName;
        public string LPAEName { get { return _lPAEName; } set { _lPAEName = value; } }
        private Value<string> _lPAEUserName;
        public string LPAEUserName { get { return _lPAEUserName; } set { _lPAEUserName = value; } }
        private Value<string> _lPBusinessFax;
        public string LPBusinessFax { get { return _lPBusinessFax; } set { _lPBusinessFax = value; } }
        private Value<string> _lPBusinessPhone;
        public string LPBusinessPhone { get { return _lPBusinessPhone; } set { _lPBusinessPhone = value; } }
        private Value<string> _lPCellPhone;
        public string LPCellPhone { get { return _lPCellPhone; } set { _lPCellPhone = value; } }
        private Value<string> _lPCity;
        public string LPCity { get { return _lPCity; } set { _lPCity = value; } }
        private Value<string> _lPEmail;
        public string LPEmail { get { return _lPEmail; } set { _lPEmail = value; } }
        private Value<string> _lPID;
        public string LPID { get { return _lPID; } set { _lPID = value; } }
        private Value<string> _lPName;
        public string LPName { get { return _lPName; } set { _lPName = value; } }
        private Value<string> _lPNotes;
        public string LPNotes { get { return _lPNotes; } set { _lPNotes = value; } }
        private Value<string> _lPState;
        public string LPState { get { return _lPState; } set { _lPState = value; } }
        private Value<string> _lPStatus;
        public string LPStatus { get { return _lPStatus; } set { _lPStatus = value; } }
        private Value<string> _lPZip;
        public string LPZip { get { return _lPZip; } set { _lPZip = value; } }
        private Value<DateTime?> _purchaseStipsReadyDate;
        public DateTime? PurchaseStipsReadyDate { get { return _purchaseStipsReadyDate; } set { _purchaseStipsReadyDate = value; } }
        private Value<bool?> _purchaseStipsReviewed;
        public bool? PurchaseStipsReviewed { get { return _purchaseStipsReviewed; } set { _purchaseStipsReviewed = value; } }
        private Value<DateTime?> _readytoDiscloseDateUtc;
        public DateTime? ReadytoDiscloseDateUtc { get { return _readytoDiscloseDateUtc; } set { _readytoDiscloseDateUtc = value; } }
        private Value<DateTime?> _registerDate;
        public DateTime? RegisterDate { get { return _registerDate; } set { _registerDate = value; } }
        private Value<string> _sITEID;
        public string SITEID { get { return _sITEID; } set { _sITEID = value; } }
        private Value<DateTime?> _submitDate;
        public DateTime? SubmitDate { get { return _submitDate; } set { _submitDate = value; } }
        private Value<bool?> _testAccountField;
        public bool? TestAccountField { get { return _testAccountField; } set { _testAccountField = value; } }
        private Value<bool?> _underwriterReviewed;
        public bool? UnderwriterReviewed { get { return _underwriterReviewed; } set { _underwriterReviewed = value; } }
        private Value<bool?> _underwritingDelegated;
        public bool? UnderwritingDelegated { get { return _underwritingDelegated; } set { _underwritingDelegated = value; } }
        private Value<bool?> _watchListFlag;
        public bool? WatchListFlag { get { return _watchListFlag; } set { _watchListFlag = value; } }
        private Value<string> _watchListReason;
        public string WatchListReason { get { return _watchListReason; } set { _watchListReason = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _archived.Clean
                    && _branchAddress.Clean
                    && _branchAEName.Clean
                    && _branchAEUserName.Clean
                    && _branchCity.Clean
                    && _branchDBAName.Clean
                    && _branchFax.Clean
                    && _branchID.Clean
                    && _branchLegalName.Clean
                    && _branchManagerEmail.Clean
                    && _branchManagerName.Clean
                    && _branchName.Clean
                    && _branchOrganizationID.Clean
                    && _branchPhone.Clean
                    && _branchRating.Clean
                    && _branchState.Clean
                    && _branchZip.Clean
                    && _cFCAddress.Clean
                    && _cFCBusinessFax.Clean
                    && _cFCBusinessPhone.Clean
                    && _cFCCellPhone.Clean
                    && _cFCCity.Clean
                    && _cFCEmail.Clean
                    && _cFCName.Clean
                    && _cFCNotes.Clean
                    && _cFCRepAE.Clean
                    && _cFCSRAEUserName.Clean
                    && _cFCState.Clean
                    && _cFCStatus.Clean
                    && _cFCUserID.Clean
                    && _cFCZip.Clean
                    && _companyAddress.Clean
                    && _companyAEName.Clean
                    && _companyAEUserName.Clean
                    && _companyCity.Clean
                    && _companyDBAName.Clean
                    && _companyFax.Clean
                    && _companyID.Clean
                    && _companyLegalName.Clean
                    && _companyManagerEmail.Clean
                    && _companyManagerName.Clean
                    && _companyName.Clean
                    && _companyOrganizationID.Clean
                    && _companyPhone.Clean
                    && _companyRating.Clean
                    && _companyState.Clean
                    && _companyZip.Clean
                    && _documentsReadyDate.Clean
                    && _feeReviewComments.Clean
                    && _feeReviewStatus.Clean
                    && _feeReviewStatusDate.Clean
                    && _importSource.Clean
                    && _initialApplicationDate.Clean
                    && _initialSubmitDate.Clean
                    && _lOAddress.Clean
                    && _lOAEName.Clean
                    && _lOAEUserName.Clean
                    && _lOBusinessFax.Clean
                    && _lOBusinessPhone.Clean
                    && _lOCellPhone.Clean
                    && _lOCity.Clean
                    && _lOEmail.Clean
                    && _lOID.Clean
                    && _lOName.Clean
                    && _lONotes.Clean
                    && _lOState.Clean
                    && _lOStatus.Clean
                    && _lOZip.Clean
                    && _lPAddress.Clean
                    && _lPAEName.Clean
                    && _lPAEUserName.Clean
                    && _lPBusinessFax.Clean
                    && _lPBusinessPhone.Clean
                    && _lPCellPhone.Clean
                    && _lPCity.Clean
                    && _lPEmail.Clean
                    && _lPID.Clean
                    && _lPName.Clean
                    && _lPNotes.Clean
                    && _lPState.Clean
                    && _lPStatus.Clean
                    && _lPZip.Clean
                    && _purchaseStipsReadyDate.Clean
                    && _purchaseStipsReviewed.Clean
                    && _readytoDiscloseDateUtc.Clean
                    && _registerDate.Clean
                    && _sITEID.Clean
                    && _submitDate.Clean
                    && _testAccountField.Clean
                    && _underwriterReviewed.Clean
                    && _underwritingDelegated.Clean
                    && _watchListFlag.Clean
                    && _watchListReason.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var archived = _archived; archived.Clean = value; _archived = archived;
                var branchAddress = _branchAddress; branchAddress.Clean = value; _branchAddress = branchAddress;
                var branchAEName = _branchAEName; branchAEName.Clean = value; _branchAEName = branchAEName;
                var branchAEUserName = _branchAEUserName; branchAEUserName.Clean = value; _branchAEUserName = branchAEUserName;
                var branchCity = _branchCity; branchCity.Clean = value; _branchCity = branchCity;
                var branchDBAName = _branchDBAName; branchDBAName.Clean = value; _branchDBAName = branchDBAName;
                var branchFax = _branchFax; branchFax.Clean = value; _branchFax = branchFax;
                var branchID = _branchID; branchID.Clean = value; _branchID = branchID;
                var branchLegalName = _branchLegalName; branchLegalName.Clean = value; _branchLegalName = branchLegalName;
                var branchManagerEmail = _branchManagerEmail; branchManagerEmail.Clean = value; _branchManagerEmail = branchManagerEmail;
                var branchManagerName = _branchManagerName; branchManagerName.Clean = value; _branchManagerName = branchManagerName;
                var branchName = _branchName; branchName.Clean = value; _branchName = branchName;
                var branchOrganizationID = _branchOrganizationID; branchOrganizationID.Clean = value; _branchOrganizationID = branchOrganizationID;
                var branchPhone = _branchPhone; branchPhone.Clean = value; _branchPhone = branchPhone;
                var branchRating = _branchRating; branchRating.Clean = value; _branchRating = branchRating;
                var branchState = _branchState; branchState.Clean = value; _branchState = branchState;
                var branchZip = _branchZip; branchZip.Clean = value; _branchZip = branchZip;
                var cFCAddress = _cFCAddress; cFCAddress.Clean = value; _cFCAddress = cFCAddress;
                var cFCBusinessFax = _cFCBusinessFax; cFCBusinessFax.Clean = value; _cFCBusinessFax = cFCBusinessFax;
                var cFCBusinessPhone = _cFCBusinessPhone; cFCBusinessPhone.Clean = value; _cFCBusinessPhone = cFCBusinessPhone;
                var cFCCellPhone = _cFCCellPhone; cFCCellPhone.Clean = value; _cFCCellPhone = cFCCellPhone;
                var cFCCity = _cFCCity; cFCCity.Clean = value; _cFCCity = cFCCity;
                var cFCEmail = _cFCEmail; cFCEmail.Clean = value; _cFCEmail = cFCEmail;
                var cFCName = _cFCName; cFCName.Clean = value; _cFCName = cFCName;
                var cFCNotes = _cFCNotes; cFCNotes.Clean = value; _cFCNotes = cFCNotes;
                var cFCRepAE = _cFCRepAE; cFCRepAE.Clean = value; _cFCRepAE = cFCRepAE;
                var cFCSRAEUserName = _cFCSRAEUserName; cFCSRAEUserName.Clean = value; _cFCSRAEUserName = cFCSRAEUserName;
                var cFCState = _cFCState; cFCState.Clean = value; _cFCState = cFCState;
                var cFCStatus = _cFCStatus; cFCStatus.Clean = value; _cFCStatus = cFCStatus;
                var cFCUserID = _cFCUserID; cFCUserID.Clean = value; _cFCUserID = cFCUserID;
                var cFCZip = _cFCZip; cFCZip.Clean = value; _cFCZip = cFCZip;
                var companyAddress = _companyAddress; companyAddress.Clean = value; _companyAddress = companyAddress;
                var companyAEName = _companyAEName; companyAEName.Clean = value; _companyAEName = companyAEName;
                var companyAEUserName = _companyAEUserName; companyAEUserName.Clean = value; _companyAEUserName = companyAEUserName;
                var companyCity = _companyCity; companyCity.Clean = value; _companyCity = companyCity;
                var companyDBAName = _companyDBAName; companyDBAName.Clean = value; _companyDBAName = companyDBAName;
                var companyFax = _companyFax; companyFax.Clean = value; _companyFax = companyFax;
                var companyID = _companyID; companyID.Clean = value; _companyID = companyID;
                var companyLegalName = _companyLegalName; companyLegalName.Clean = value; _companyLegalName = companyLegalName;
                var companyManagerEmail = _companyManagerEmail; companyManagerEmail.Clean = value; _companyManagerEmail = companyManagerEmail;
                var companyManagerName = _companyManagerName; companyManagerName.Clean = value; _companyManagerName = companyManagerName;
                var companyName = _companyName; companyName.Clean = value; _companyName = companyName;
                var companyOrganizationID = _companyOrganizationID; companyOrganizationID.Clean = value; _companyOrganizationID = companyOrganizationID;
                var companyPhone = _companyPhone; companyPhone.Clean = value; _companyPhone = companyPhone;
                var companyRating = _companyRating; companyRating.Clean = value; _companyRating = companyRating;
                var companyState = _companyState; companyState.Clean = value; _companyState = companyState;
                var companyZip = _companyZip; companyZip.Clean = value; _companyZip = companyZip;
                var documentsReadyDate = _documentsReadyDate; documentsReadyDate.Clean = value; _documentsReadyDate = documentsReadyDate;
                var feeReviewComments = _feeReviewComments; feeReviewComments.Clean = value; _feeReviewComments = feeReviewComments;
                var feeReviewStatus = _feeReviewStatus; feeReviewStatus.Clean = value; _feeReviewStatus = feeReviewStatus;
                var feeReviewStatusDate = _feeReviewStatusDate; feeReviewStatusDate.Clean = value; _feeReviewStatusDate = feeReviewStatusDate;
                var importSource = _importSource; importSource.Clean = value; _importSource = importSource;
                var initialApplicationDate = _initialApplicationDate; initialApplicationDate.Clean = value; _initialApplicationDate = initialApplicationDate;
                var initialSubmitDate = _initialSubmitDate; initialSubmitDate.Clean = value; _initialSubmitDate = initialSubmitDate;
                var lOAddress = _lOAddress; lOAddress.Clean = value; _lOAddress = lOAddress;
                var lOAEName = _lOAEName; lOAEName.Clean = value; _lOAEName = lOAEName;
                var lOAEUserName = _lOAEUserName; lOAEUserName.Clean = value; _lOAEUserName = lOAEUserName;
                var lOBusinessFax = _lOBusinessFax; lOBusinessFax.Clean = value; _lOBusinessFax = lOBusinessFax;
                var lOBusinessPhone = _lOBusinessPhone; lOBusinessPhone.Clean = value; _lOBusinessPhone = lOBusinessPhone;
                var lOCellPhone = _lOCellPhone; lOCellPhone.Clean = value; _lOCellPhone = lOCellPhone;
                var lOCity = _lOCity; lOCity.Clean = value; _lOCity = lOCity;
                var lOEmail = _lOEmail; lOEmail.Clean = value; _lOEmail = lOEmail;
                var lOID = _lOID; lOID.Clean = value; _lOID = lOID;
                var lOName = _lOName; lOName.Clean = value; _lOName = lOName;
                var lONotes = _lONotes; lONotes.Clean = value; _lONotes = lONotes;
                var lOState = _lOState; lOState.Clean = value; _lOState = lOState;
                var lOStatus = _lOStatus; lOStatus.Clean = value; _lOStatus = lOStatus;
                var lOZip = _lOZip; lOZip.Clean = value; _lOZip = lOZip;
                var lPAddress = _lPAddress; lPAddress.Clean = value; _lPAddress = lPAddress;
                var lPAEName = _lPAEName; lPAEName.Clean = value; _lPAEName = lPAEName;
                var lPAEUserName = _lPAEUserName; lPAEUserName.Clean = value; _lPAEUserName = lPAEUserName;
                var lPBusinessFax = _lPBusinessFax; lPBusinessFax.Clean = value; _lPBusinessFax = lPBusinessFax;
                var lPBusinessPhone = _lPBusinessPhone; lPBusinessPhone.Clean = value; _lPBusinessPhone = lPBusinessPhone;
                var lPCellPhone = _lPCellPhone; lPCellPhone.Clean = value; _lPCellPhone = lPCellPhone;
                var lPCity = _lPCity; lPCity.Clean = value; _lPCity = lPCity;
                var lPEmail = _lPEmail; lPEmail.Clean = value; _lPEmail = lPEmail;
                var lPID = _lPID; lPID.Clean = value; _lPID = lPID;
                var lPName = _lPName; lPName.Clean = value; _lPName = lPName;
                var lPNotes = _lPNotes; lPNotes.Clean = value; _lPNotes = lPNotes;
                var lPState = _lPState; lPState.Clean = value; _lPState = lPState;
                var lPStatus = _lPStatus; lPStatus.Clean = value; _lPStatus = lPStatus;
                var lPZip = _lPZip; lPZip.Clean = value; _lPZip = lPZip;
                var purchaseStipsReadyDate = _purchaseStipsReadyDate; purchaseStipsReadyDate.Clean = value; _purchaseStipsReadyDate = purchaseStipsReadyDate;
                var purchaseStipsReviewed = _purchaseStipsReviewed; purchaseStipsReviewed.Clean = value; _purchaseStipsReviewed = purchaseStipsReviewed;
                var readytoDiscloseDateUtc = _readytoDiscloseDateUtc; readytoDiscloseDateUtc.Clean = value; _readytoDiscloseDateUtc = readytoDiscloseDateUtc;
                var registerDate = _registerDate; registerDate.Clean = value; _registerDate = registerDate;
                var sITEID = _sITEID; sITEID.Clean = value; _sITEID = sITEID;
                var submitDate = _submitDate; submitDate.Clean = value; _submitDate = submitDate;
                var testAccountField = _testAccountField; testAccountField.Clean = value; _testAccountField = testAccountField;
                var underwriterReviewed = _underwriterReviewed; underwriterReviewed.Clean = value; _underwriterReviewed = underwriterReviewed;
                var underwritingDelegated = _underwritingDelegated; underwritingDelegated.Clean = value; _underwritingDelegated = underwritingDelegated;
                var watchListFlag = _watchListFlag; watchListFlag.Clean = value; _watchListFlag = watchListFlag;
                var watchListReason = _watchListReason; watchListReason.Clean = value; _watchListReason = watchListReason;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public TPO()
        {
            Clean = true;
        }
    }
}