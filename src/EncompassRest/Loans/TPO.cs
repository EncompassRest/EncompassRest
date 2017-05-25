using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _archived; v0.Clean = value; _archived = v0;
                var v1 = _branchAddress; v1.Clean = value; _branchAddress = v1;
                var v2 = _branchAEName; v2.Clean = value; _branchAEName = v2;
                var v3 = _branchAEUserName; v3.Clean = value; _branchAEUserName = v3;
                var v4 = _branchCity; v4.Clean = value; _branchCity = v4;
                var v5 = _branchDBAName; v5.Clean = value; _branchDBAName = v5;
                var v6 = _branchFax; v6.Clean = value; _branchFax = v6;
                var v7 = _branchID; v7.Clean = value; _branchID = v7;
                var v8 = _branchLegalName; v8.Clean = value; _branchLegalName = v8;
                var v9 = _branchManagerEmail; v9.Clean = value; _branchManagerEmail = v9;
                var v10 = _branchManagerName; v10.Clean = value; _branchManagerName = v10;
                var v11 = _branchName; v11.Clean = value; _branchName = v11;
                var v12 = _branchOrganizationID; v12.Clean = value; _branchOrganizationID = v12;
                var v13 = _branchPhone; v13.Clean = value; _branchPhone = v13;
                var v14 = _branchRating; v14.Clean = value; _branchRating = v14;
                var v15 = _branchState; v15.Clean = value; _branchState = v15;
                var v16 = _branchZip; v16.Clean = value; _branchZip = v16;
                var v17 = _cFCAddress; v17.Clean = value; _cFCAddress = v17;
                var v18 = _cFCBusinessFax; v18.Clean = value; _cFCBusinessFax = v18;
                var v19 = _cFCBusinessPhone; v19.Clean = value; _cFCBusinessPhone = v19;
                var v20 = _cFCCellPhone; v20.Clean = value; _cFCCellPhone = v20;
                var v21 = _cFCCity; v21.Clean = value; _cFCCity = v21;
                var v22 = _cFCEmail; v22.Clean = value; _cFCEmail = v22;
                var v23 = _cFCName; v23.Clean = value; _cFCName = v23;
                var v24 = _cFCNotes; v24.Clean = value; _cFCNotes = v24;
                var v25 = _cFCRepAE; v25.Clean = value; _cFCRepAE = v25;
                var v26 = _cFCSRAEUserName; v26.Clean = value; _cFCSRAEUserName = v26;
                var v27 = _cFCState; v27.Clean = value; _cFCState = v27;
                var v28 = _cFCStatus; v28.Clean = value; _cFCStatus = v28;
                var v29 = _cFCUserID; v29.Clean = value; _cFCUserID = v29;
                var v30 = _cFCZip; v30.Clean = value; _cFCZip = v30;
                var v31 = _companyAddress; v31.Clean = value; _companyAddress = v31;
                var v32 = _companyAEName; v32.Clean = value; _companyAEName = v32;
                var v33 = _companyAEUserName; v33.Clean = value; _companyAEUserName = v33;
                var v34 = _companyCity; v34.Clean = value; _companyCity = v34;
                var v35 = _companyDBAName; v35.Clean = value; _companyDBAName = v35;
                var v36 = _companyFax; v36.Clean = value; _companyFax = v36;
                var v37 = _companyID; v37.Clean = value; _companyID = v37;
                var v38 = _companyLegalName; v38.Clean = value; _companyLegalName = v38;
                var v39 = _companyManagerEmail; v39.Clean = value; _companyManagerEmail = v39;
                var v40 = _companyManagerName; v40.Clean = value; _companyManagerName = v40;
                var v41 = _companyName; v41.Clean = value; _companyName = v41;
                var v42 = _companyOrganizationID; v42.Clean = value; _companyOrganizationID = v42;
                var v43 = _companyPhone; v43.Clean = value; _companyPhone = v43;
                var v44 = _companyRating; v44.Clean = value; _companyRating = v44;
                var v45 = _companyState; v45.Clean = value; _companyState = v45;
                var v46 = _companyZip; v46.Clean = value; _companyZip = v46;
                var v47 = _documentsReadyDate; v47.Clean = value; _documentsReadyDate = v47;
                var v48 = _feeReviewComments; v48.Clean = value; _feeReviewComments = v48;
                var v49 = _feeReviewStatus; v49.Clean = value; _feeReviewStatus = v49;
                var v50 = _feeReviewStatusDate; v50.Clean = value; _feeReviewStatusDate = v50;
                var v51 = _importSource; v51.Clean = value; _importSource = v51;
                var v52 = _initialApplicationDate; v52.Clean = value; _initialApplicationDate = v52;
                var v53 = _initialSubmitDate; v53.Clean = value; _initialSubmitDate = v53;
                var v54 = _lOAddress; v54.Clean = value; _lOAddress = v54;
                var v55 = _lOAEName; v55.Clean = value; _lOAEName = v55;
                var v56 = _lOAEUserName; v56.Clean = value; _lOAEUserName = v56;
                var v57 = _lOBusinessFax; v57.Clean = value; _lOBusinessFax = v57;
                var v58 = _lOBusinessPhone; v58.Clean = value; _lOBusinessPhone = v58;
                var v59 = _lOCellPhone; v59.Clean = value; _lOCellPhone = v59;
                var v60 = _lOCity; v60.Clean = value; _lOCity = v60;
                var v61 = _lOEmail; v61.Clean = value; _lOEmail = v61;
                var v62 = _lOID; v62.Clean = value; _lOID = v62;
                var v63 = _lOName; v63.Clean = value; _lOName = v63;
                var v64 = _lONotes; v64.Clean = value; _lONotes = v64;
                var v65 = _lOState; v65.Clean = value; _lOState = v65;
                var v66 = _lOStatus; v66.Clean = value; _lOStatus = v66;
                var v67 = _lOZip; v67.Clean = value; _lOZip = v67;
                var v68 = _lPAddress; v68.Clean = value; _lPAddress = v68;
                var v69 = _lPAEName; v69.Clean = value; _lPAEName = v69;
                var v70 = _lPAEUserName; v70.Clean = value; _lPAEUserName = v70;
                var v71 = _lPBusinessFax; v71.Clean = value; _lPBusinessFax = v71;
                var v72 = _lPBusinessPhone; v72.Clean = value; _lPBusinessPhone = v72;
                var v73 = _lPCellPhone; v73.Clean = value; _lPCellPhone = v73;
                var v74 = _lPCity; v74.Clean = value; _lPCity = v74;
                var v75 = _lPEmail; v75.Clean = value; _lPEmail = v75;
                var v76 = _lPID; v76.Clean = value; _lPID = v76;
                var v77 = _lPName; v77.Clean = value; _lPName = v77;
                var v78 = _lPNotes; v78.Clean = value; _lPNotes = v78;
                var v79 = _lPState; v79.Clean = value; _lPState = v79;
                var v80 = _lPStatus; v80.Clean = value; _lPStatus = v80;
                var v81 = _lPZip; v81.Clean = value; _lPZip = v81;
                var v82 = _purchaseStipsReadyDate; v82.Clean = value; _purchaseStipsReadyDate = v82;
                var v83 = _purchaseStipsReviewed; v83.Clean = value; _purchaseStipsReviewed = v83;
                var v84 = _readytoDiscloseDateUtc; v84.Clean = value; _readytoDiscloseDateUtc = v84;
                var v85 = _registerDate; v85.Clean = value; _registerDate = v85;
                var v86 = _sITEID; v86.Clean = value; _sITEID = v86;
                var v87 = _submitDate; v87.Clean = value; _submitDate = v87;
                var v88 = _testAccountField; v88.Clean = value; _testAccountField = v88;
                var v89 = _underwriterReviewed; v89.Clean = value; _underwriterReviewed = v89;
                var v90 = _underwritingDelegated; v90.Clean = value; _underwritingDelegated = v90;
                var v91 = _watchListFlag; v91.Clean = value; _watchListFlag = v91;
                var v92 = _watchListReason; v92.Clean = value; _watchListReason = v92;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}