#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TPO : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _archived;
        public bool? Archived { get => _archived; set => _archived = value; }
        private DirtyValue<string> _branchAddress;
        public string BranchAddress { get => _branchAddress; set => _branchAddress = value; }
        private DirtyValue<string> _branchAEName;
        public string BranchAEName { get => _branchAEName; set => _branchAEName = value; }
        private DirtyValue<string> _branchAEUserName;
        public string BranchAEUserName { get => _branchAEUserName; set => _branchAEUserName = value; }
        private DirtyValue<string> _branchCity;
        public string BranchCity { get => _branchCity; set => _branchCity = value; }
        private DirtyValue<string> _branchDBAName;
        public string BranchDBAName { get => _branchDBAName; set => _branchDBAName = value; }
        private DirtyValue<string> _branchFax;
        public string BranchFax { get => _branchFax; set => _branchFax = value; }
        private DirtyValue<string> _branchID;
        public string BranchID { get => _branchID; set => _branchID = value; }
        private DirtyValue<string> _branchLegalName;
        public string BranchLegalName { get => _branchLegalName; set => _branchLegalName = value; }
        private DirtyValue<string> _branchManagerEmail;
        public string BranchManagerEmail { get => _branchManagerEmail; set => _branchManagerEmail = value; }
        private DirtyValue<string> _branchManagerName;
        public string BranchManagerName { get => _branchManagerName; set => _branchManagerName = value; }
        private DirtyValue<string> _branchName;
        public string BranchName { get => _branchName; set => _branchName = value; }
        private DirtyValue<string> _branchOrganizationID;
        public string BranchOrganizationID { get => _branchOrganizationID; set => _branchOrganizationID = value; }
        private DirtyValue<string> _branchPhone;
        public string BranchPhone { get => _branchPhone; set => _branchPhone = value; }
        private DirtyValue<string> _branchRating;
        public string BranchRating { get => _branchRating; set => _branchRating = value; }
        private DirtyValue<string> _branchState;
        public string BranchState { get => _branchState; set => _branchState = value; }
        private DirtyValue<string> _branchZip;
        public string BranchZip { get => _branchZip; set => _branchZip = value; }
        private DirtyValue<string> _cFCAddress;
        public string CFCAddress { get => _cFCAddress; set => _cFCAddress = value; }
        private DirtyValue<string> _cFCBusinessFax;
        public string CFCBusinessFax { get => _cFCBusinessFax; set => _cFCBusinessFax = value; }
        private DirtyValue<string> _cFCBusinessPhone;
        public string CFCBusinessPhone { get => _cFCBusinessPhone; set => _cFCBusinessPhone = value; }
        private DirtyValue<string> _cFCCellPhone;
        public string CFCCellPhone { get => _cFCCellPhone; set => _cFCCellPhone = value; }
        private DirtyValue<string> _cFCCity;
        public string CFCCity { get => _cFCCity; set => _cFCCity = value; }
        private DirtyValue<string> _cFCEmail;
        public string CFCEmail { get => _cFCEmail; set => _cFCEmail = value; }
        private DirtyValue<string> _cFCName;
        public string CFCName { get => _cFCName; set => _cFCName = value; }
        private DirtyValue<string> _cFCNotes;
        public string CFCNotes { get => _cFCNotes; set => _cFCNotes = value; }
        private DirtyValue<string> _cFCRepAE;
        public string CFCRepAE { get => _cFCRepAE; set => _cFCRepAE = value; }
        private DirtyValue<string> _cFCSRAEUserName;
        public string CFCSRAEUserName { get => _cFCSRAEUserName; set => _cFCSRAEUserName = value; }
        private DirtyValue<string> _cFCState;
        public string CFCState { get => _cFCState; set => _cFCState = value; }
        private DirtyValue<string> _cFCStatus;
        public string CFCStatus { get => _cFCStatus; set => _cFCStatus = value; }
        private DirtyValue<string> _cFCUserID;
        public string CFCUserID { get => _cFCUserID; set => _cFCUserID = value; }
        private DirtyValue<string> _cFCZip;
        public string CFCZip { get => _cFCZip; set => _cFCZip = value; }
        private DirtyValue<string> _companyAddress;
        public string CompanyAddress { get => _companyAddress; set => _companyAddress = value; }
        private DirtyValue<string> _companyAEName;
        public string CompanyAEName { get => _companyAEName; set => _companyAEName = value; }
        private DirtyValue<string> _companyAEUserName;
        public string CompanyAEUserName { get => _companyAEUserName; set => _companyAEUserName = value; }
        private DirtyValue<string> _companyCity;
        public string CompanyCity { get => _companyCity; set => _companyCity = value; }
        private DirtyValue<string> _companyDBAName;
        public string CompanyDBAName { get => _companyDBAName; set => _companyDBAName = value; }
        private DirtyValue<string> _companyFax;
        public string CompanyFax { get => _companyFax; set => _companyFax = value; }
        private DirtyValue<string> _companyID;
        public string CompanyID { get => _companyID; set => _companyID = value; }
        private DirtyValue<string> _companyLegalName;
        public string CompanyLegalName { get => _companyLegalName; set => _companyLegalName = value; }
        private DirtyValue<string> _companyManagerEmail;
        public string CompanyManagerEmail { get => _companyManagerEmail; set => _companyManagerEmail = value; }
        private DirtyValue<string> _companyManagerName;
        public string CompanyManagerName { get => _companyManagerName; set => _companyManagerName = value; }
        private DirtyValue<string> _companyName;
        public string CompanyName { get => _companyName; set => _companyName = value; }
        private DirtyValue<string> _companyOrganizationID;
        public string CompanyOrganizationID { get => _companyOrganizationID; set => _companyOrganizationID = value; }
        private DirtyValue<string> _companyPhone;
        public string CompanyPhone { get => _companyPhone; set => _companyPhone = value; }
        private DirtyValue<string> _companyRating;
        public string CompanyRating { get => _companyRating; set => _companyRating = value; }
        private DirtyValue<string> _companyState;
        public string CompanyState { get => _companyState; set => _companyState = value; }
        private DirtyValue<string> _companyZip;
        public string CompanyZip { get => _companyZip; set => _companyZip = value; }
        private DirtyValue<DateTime?> _documentsReadyDate;
        public DateTime? DocumentsReadyDate { get => _documentsReadyDate; set => _documentsReadyDate = value; }
        private DirtyValue<string> _feeReviewComments;
        public string FeeReviewComments { get => _feeReviewComments; set => _feeReviewComments = value; }
        private DirtyValue<string> _feeReviewStatus;
        public string FeeReviewStatus { get => _feeReviewStatus; set => _feeReviewStatus = value; }
        private DirtyValue<DateTime?> _feeReviewStatusDate;
        public DateTime? FeeReviewStatusDate { get => _feeReviewStatusDate; set => _feeReviewStatusDate = value; }
        private DirtyValue<string> _importSource;
        public string ImportSource { get => _importSource; set => _importSource = value; }
        private DirtyValue<DateTime?> _initialApplicationDate;
        public DateTime? InitialApplicationDate { get => _initialApplicationDate; set => _initialApplicationDate = value; }
        private DirtyValue<DateTime?> _initialSubmitDate;
        public DateTime? InitialSubmitDate { get => _initialSubmitDate; set => _initialSubmitDate = value; }
        private DirtyValue<string> _lOAddress;
        public string LOAddress { get => _lOAddress; set => _lOAddress = value; }
        private DirtyValue<string> _lOAEName;
        public string LOAEName { get => _lOAEName; set => _lOAEName = value; }
        private DirtyValue<string> _lOAEUserName;
        public string LOAEUserName { get => _lOAEUserName; set => _lOAEUserName = value; }
        private DirtyValue<string> _lOBusinessFax;
        public string LOBusinessFax { get => _lOBusinessFax; set => _lOBusinessFax = value; }
        private DirtyValue<string> _lOBusinessPhone;
        public string LOBusinessPhone { get => _lOBusinessPhone; set => _lOBusinessPhone = value; }
        private DirtyValue<string> _lOCellPhone;
        public string LOCellPhone { get => _lOCellPhone; set => _lOCellPhone = value; }
        private DirtyValue<string> _lOCity;
        public string LOCity { get => _lOCity; set => _lOCity = value; }
        private DirtyValue<string> _lOEmail;
        public string LOEmail { get => _lOEmail; set => _lOEmail = value; }
        private DirtyValue<string> _lOID;
        public string LOID { get => _lOID; set => _lOID = value; }
        private DirtyValue<string> _lOName;
        public string LOName { get => _lOName; set => _lOName = value; }
        private DirtyValue<string> _lONotes;
        public string LONotes { get => _lONotes; set => _lONotes = value; }
        private DirtyValue<string> _lOState;
        public string LOState { get => _lOState; set => _lOState = value; }
        private DirtyValue<string> _lOStatus;
        public string LOStatus { get => _lOStatus; set => _lOStatus = value; }
        private DirtyValue<string> _lOZip;
        public string LOZip { get => _lOZip; set => _lOZip = value; }
        private DirtyValue<string> _lPAddress;
        public string LPAddress { get => _lPAddress; set => _lPAddress = value; }
        private DirtyValue<string> _lPAEName;
        public string LPAEName { get => _lPAEName; set => _lPAEName = value; }
        private DirtyValue<string> _lPAEUserName;
        public string LPAEUserName { get => _lPAEUserName; set => _lPAEUserName = value; }
        private DirtyValue<string> _lPBusinessFax;
        public string LPBusinessFax { get => _lPBusinessFax; set => _lPBusinessFax = value; }
        private DirtyValue<string> _lPBusinessPhone;
        public string LPBusinessPhone { get => _lPBusinessPhone; set => _lPBusinessPhone = value; }
        private DirtyValue<string> _lPCellPhone;
        public string LPCellPhone { get => _lPCellPhone; set => _lPCellPhone = value; }
        private DirtyValue<string> _lPCity;
        public string LPCity { get => _lPCity; set => _lPCity = value; }
        private DirtyValue<string> _lPEmail;
        public string LPEmail { get => _lPEmail; set => _lPEmail = value; }
        private DirtyValue<string> _lPID;
        public string LPID { get => _lPID; set => _lPID = value; }
        private DirtyValue<string> _lPName;
        public string LPName { get => _lPName; set => _lPName = value; }
        private DirtyValue<string> _lPNotes;
        public string LPNotes { get => _lPNotes; set => _lPNotes = value; }
        private DirtyValue<string> _lPState;
        public string LPState { get => _lPState; set => _lPState = value; }
        private DirtyValue<string> _lPStatus;
        public string LPStatus { get => _lPStatus; set => _lPStatus = value; }
        private DirtyValue<string> _lPZip;
        public string LPZip { get => _lPZip; set => _lPZip = value; }
        private DirtyValue<DateTime?> _purchaseStipsReadyDate;
        public DateTime? PurchaseStipsReadyDate { get => _purchaseStipsReadyDate; set => _purchaseStipsReadyDate = value; }
        private DirtyValue<bool?> _purchaseStipsReviewed;
        public bool? PurchaseStipsReviewed { get => _purchaseStipsReviewed; set => _purchaseStipsReviewed = value; }
        private DirtyValue<DateTime?> _readytoDiscloseDateUtc;
        public DateTime? ReadytoDiscloseDateUtc { get => _readytoDiscloseDateUtc; set => _readytoDiscloseDateUtc = value; }
        private DirtyValue<DateTime?> _registerDate;
        public DateTime? RegisterDate { get => _registerDate; set => _registerDate = value; }
        private DirtyValue<string> _sITEID;
        public string SITEID { get => _sITEID; set => _sITEID = value; }
        private DirtyValue<DateTime?> _submitDate;
        public DateTime? SubmitDate { get => _submitDate; set => _submitDate = value; }
        private DirtyValue<bool?> _testAccountField;
        public bool? TestAccountField { get => _testAccountField; set => _testAccountField = value; }
        private DirtyValue<bool?> _underwriterReviewed;
        public bool? UnderwriterReviewed { get => _underwriterReviewed; set => _underwriterReviewed = value; }
        private DirtyValue<bool?> _underwritingDelegated;
        public bool? UnderwritingDelegated { get => _underwritingDelegated; set => _underwritingDelegated = value; }
        private DirtyValue<bool?> _watchListFlag;
        public bool? WatchListFlag { get => _watchListFlag; set => _watchListFlag = value; }
        private DirtyValue<StringEnumValue<WatchListReason>> _watchListReason;
        public StringEnumValue<WatchListReason> WatchListReason { get => _watchListReason; set => _watchListReason = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _archived.Dirty
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
            }
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