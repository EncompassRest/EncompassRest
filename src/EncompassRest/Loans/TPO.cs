using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TPO
    {
        public Value<bool?> Archived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchived() => !Archived.Clean;
        public Value<string> BranchAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchAddress() => !BranchAddress.Clean;
        public Value<string> BranchAEName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchAEName() => !BranchAEName.Clean;
        public Value<string> BranchAEUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchAEUserName() => !BranchAEUserName.Clean;
        public Value<string> BranchCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchCity() => !BranchCity.Clean;
        public Value<string> BranchDBAName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchDBAName() => !BranchDBAName.Clean;
        public Value<string> BranchFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchFax() => !BranchFax.Clean;
        public Value<string> BranchID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchID() => !BranchID.Clean;
        public Value<string> BranchLegalName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchLegalName() => !BranchLegalName.Clean;
        public Value<string> BranchManagerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchManagerEmail() => !BranchManagerEmail.Clean;
        public Value<string> BranchManagerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchManagerName() => !BranchManagerName.Clean;
        public Value<string> BranchName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchName() => !BranchName.Clean;
        public Value<string> BranchOrganizationID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchOrganizationID() => !BranchOrganizationID.Clean;
        public Value<string> BranchPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchPhone() => !BranchPhone.Clean;
        public Value<string> BranchRating { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchRating() => !BranchRating.Clean;
        public Value<string> BranchState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchState() => !BranchState.Clean;
        public Value<string> BranchZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchZip() => !BranchZip.Clean;
        public Value<string> CFCAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCAddress() => !CFCAddress.Clean;
        public Value<string> CFCBusinessFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCBusinessFax() => !CFCBusinessFax.Clean;
        public Value<string> CFCBusinessPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCBusinessPhone() => !CFCBusinessPhone.Clean;
        public Value<string> CFCCellPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCCellPhone() => !CFCCellPhone.Clean;
        public Value<string> CFCCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCCity() => !CFCCity.Clean;
        public Value<string> CFCEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCEmail() => !CFCEmail.Clean;
        public Value<string> CFCName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCName() => !CFCName.Clean;
        public Value<string> CFCNotes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCNotes() => !CFCNotes.Clean;
        public Value<string> CFCRepAE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCRepAE() => !CFCRepAE.Clean;
        public Value<string> CFCSRAEUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCSRAEUserName() => !CFCSRAEUserName.Clean;
        public Value<string> CFCState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCState() => !CFCState.Clean;
        public Value<string> CFCStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCStatus() => !CFCStatus.Clean;
        public Value<string> CFCUserID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCUserID() => !CFCUserID.Clean;
        public Value<string> CFCZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCFCZip() => !CFCZip.Clean;
        public Value<string> CompanyAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyAddress() => !CompanyAddress.Clean;
        public Value<string> CompanyAEName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyAEName() => !CompanyAEName.Clean;
        public Value<string> CompanyAEUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyAEUserName() => !CompanyAEUserName.Clean;
        public Value<string> CompanyCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyCity() => !CompanyCity.Clean;
        public Value<string> CompanyDBAName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyDBAName() => !CompanyDBAName.Clean;
        public Value<string> CompanyFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyFax() => !CompanyFax.Clean;
        public Value<string> CompanyID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyID() => !CompanyID.Clean;
        public Value<string> CompanyLegalName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyLegalName() => !CompanyLegalName.Clean;
        public Value<string> CompanyManagerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyManagerEmail() => !CompanyManagerEmail.Clean;
        public Value<string> CompanyManagerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyManagerName() => !CompanyManagerName.Clean;
        public Value<string> CompanyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyName() => !CompanyName.Clean;
        public Value<string> CompanyOrganizationID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyOrganizationID() => !CompanyOrganizationID.Clean;
        public Value<string> CompanyPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyPhone() => !CompanyPhone.Clean;
        public Value<string> CompanyRating { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyRating() => !CompanyRating.Clean;
        public Value<string> CompanyState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyState() => !CompanyState.Clean;
        public Value<string> CompanyZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyZip() => !CompanyZip.Clean;
        public Value<DateTime?> DocumentsReadyDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentsReadyDate() => !DocumentsReadyDate.Clean;
        public Value<string> FeeReviewComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReviewComments() => !FeeReviewComments.Clean;
        public Value<string> FeeReviewStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReviewStatus() => !FeeReviewStatus.Clean;
        public Value<DateTime?> FeeReviewStatusDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReviewStatusDate() => !FeeReviewStatusDate.Clean;
        public Value<string> ImportSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImportSource() => !ImportSource.Clean;
        public Value<DateTime?> InitialApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialApplicationDate() => !InitialApplicationDate.Clean;
        public Value<DateTime?> InitialSubmitDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialSubmitDate() => !InitialSubmitDate.Clean;
        public Value<string> LOAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOAddress() => !LOAddress.Clean;
        public Value<string> LOAEName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOAEName() => !LOAEName.Clean;
        public Value<string> LOAEUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOAEUserName() => !LOAEUserName.Clean;
        public Value<string> LOBusinessFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOBusinessFax() => !LOBusinessFax.Clean;
        public Value<string> LOBusinessPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOBusinessPhone() => !LOBusinessPhone.Clean;
        public Value<string> LOCellPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOCellPhone() => !LOCellPhone.Clean;
        public Value<string> LOCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOCity() => !LOCity.Clean;
        public Value<string> LOEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOEmail() => !LOEmail.Clean;
        public Value<string> LOID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOID() => !LOID.Clean;
        public Value<string> LOName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOName() => !LOName.Clean;
        public Value<string> LONotes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLONotes() => !LONotes.Clean;
        public Value<string> LOState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOState() => !LOState.Clean;
        public Value<string> LOStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOStatus() => !LOStatus.Clean;
        public Value<string> LOZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOZip() => !LOZip.Clean;
        public Value<string> LPAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPAddress() => !LPAddress.Clean;
        public Value<string> LPAEName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPAEName() => !LPAEName.Clean;
        public Value<string> LPAEUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPAEUserName() => !LPAEUserName.Clean;
        public Value<string> LPBusinessFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPBusinessFax() => !LPBusinessFax.Clean;
        public Value<string> LPBusinessPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPBusinessPhone() => !LPBusinessPhone.Clean;
        public Value<string> LPCellPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPCellPhone() => !LPCellPhone.Clean;
        public Value<string> LPCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPCity() => !LPCity.Clean;
        public Value<string> LPEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPEmail() => !LPEmail.Clean;
        public Value<string> LPID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPID() => !LPID.Clean;
        public Value<string> LPName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPName() => !LPName.Clean;
        public Value<string> LPNotes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPNotes() => !LPNotes.Clean;
        public Value<string> LPState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPState() => !LPState.Clean;
        public Value<string> LPStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPStatus() => !LPStatus.Clean;
        public Value<string> LPZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLPZip() => !LPZip.Clean;
        public Value<DateTime?> PurchaseStipsReadyDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseStipsReadyDate() => !PurchaseStipsReadyDate.Clean;
        public Value<bool?> PurchaseStipsReviewed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseStipsReviewed() => !PurchaseStipsReviewed.Clean;
        public Value<DateTime?> ReadytoDiscloseDateUtc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReadytoDiscloseDateUtc() => !ReadytoDiscloseDateUtc.Clean;
        public Value<DateTime?> RegisterDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegisterDate() => !RegisterDate.Clean;
        public Value<string> SITEID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSITEID() => !SITEID.Clean;
        public Value<DateTime?> SubmitDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmitDate() => !SubmitDate.Clean;
        public Value<bool?> TestAccountField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTestAccountField() => !TestAccountField.Clean;
        public Value<bool?> UnderwriterReviewed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwriterReviewed() => !UnderwriterReviewed.Clean;
        public Value<bool?> UnderwritingDelegated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDelegated() => !UnderwritingDelegated.Clean;
        public Value<bool?> WatchListFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWatchListFlag() => !WatchListFlag.Clean;
        public Value<string> WatchListReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWatchListReason() => !WatchListReason.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Archived.Clean
                    && BranchAddress.Clean
                    && BranchAEName.Clean
                    && BranchAEUserName.Clean
                    && BranchCity.Clean
                    && BranchDBAName.Clean
                    && BranchFax.Clean
                    && BranchID.Clean
                    && BranchLegalName.Clean
                    && BranchManagerEmail.Clean
                    && BranchManagerName.Clean
                    && BranchName.Clean
                    && BranchOrganizationID.Clean
                    && BranchPhone.Clean
                    && BranchRating.Clean
                    && BranchState.Clean
                    && BranchZip.Clean
                    && CFCAddress.Clean
                    && CFCBusinessFax.Clean
                    && CFCBusinessPhone.Clean
                    && CFCCellPhone.Clean
                    && CFCCity.Clean
                    && CFCEmail.Clean
                    && CFCName.Clean
                    && CFCNotes.Clean
                    && CFCRepAE.Clean
                    && CFCSRAEUserName.Clean
                    && CFCState.Clean
                    && CFCStatus.Clean
                    && CFCUserID.Clean
                    && CFCZip.Clean
                    && CompanyAddress.Clean
                    && CompanyAEName.Clean
                    && CompanyAEUserName.Clean
                    && CompanyCity.Clean
                    && CompanyDBAName.Clean
                    && CompanyFax.Clean
                    && CompanyID.Clean
                    && CompanyLegalName.Clean
                    && CompanyManagerEmail.Clean
                    && CompanyManagerName.Clean
                    && CompanyName.Clean
                    && CompanyOrganizationID.Clean
                    && CompanyPhone.Clean
                    && CompanyRating.Clean
                    && CompanyState.Clean
                    && CompanyZip.Clean
                    && DocumentsReadyDate.Clean
                    && FeeReviewComments.Clean
                    && FeeReviewStatus.Clean
                    && FeeReviewStatusDate.Clean
                    && ImportSource.Clean
                    && InitialApplicationDate.Clean
                    && InitialSubmitDate.Clean
                    && LOAddress.Clean
                    && LOAEName.Clean
                    && LOAEUserName.Clean
                    && LOBusinessFax.Clean
                    && LOBusinessPhone.Clean
                    && LOCellPhone.Clean
                    && LOCity.Clean
                    && LOEmail.Clean
                    && LOID.Clean
                    && LOName.Clean
                    && LONotes.Clean
                    && LOState.Clean
                    && LOStatus.Clean
                    && LOZip.Clean
                    && LPAddress.Clean
                    && LPAEName.Clean
                    && LPAEUserName.Clean
                    && LPBusinessFax.Clean
                    && LPBusinessPhone.Clean
                    && LPCellPhone.Clean
                    && LPCity.Clean
                    && LPEmail.Clean
                    && LPID.Clean
                    && LPName.Clean
                    && LPNotes.Clean
                    && LPState.Clean
                    && LPStatus.Clean
                    && LPZip.Clean
                    && PurchaseStipsReadyDate.Clean
                    && PurchaseStipsReviewed.Clean
                    && ReadytoDiscloseDateUtc.Clean
                    && RegisterDate.Clean
                    && SITEID.Clean
                    && SubmitDate.Clean
                    && TestAccountField.Clean
                    && UnderwriterReviewed.Clean
                    && UnderwritingDelegated.Clean
                    && WatchListFlag.Clean
                    && WatchListReason.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Archived; v0.Clean = value; Archived = v0;
                var v1 = BranchAddress; v1.Clean = value; BranchAddress = v1;
                var v2 = BranchAEName; v2.Clean = value; BranchAEName = v2;
                var v3 = BranchAEUserName; v3.Clean = value; BranchAEUserName = v3;
                var v4 = BranchCity; v4.Clean = value; BranchCity = v4;
                var v5 = BranchDBAName; v5.Clean = value; BranchDBAName = v5;
                var v6 = BranchFax; v6.Clean = value; BranchFax = v6;
                var v7 = BranchID; v7.Clean = value; BranchID = v7;
                var v8 = BranchLegalName; v8.Clean = value; BranchLegalName = v8;
                var v9 = BranchManagerEmail; v9.Clean = value; BranchManagerEmail = v9;
                var v10 = BranchManagerName; v10.Clean = value; BranchManagerName = v10;
                var v11 = BranchName; v11.Clean = value; BranchName = v11;
                var v12 = BranchOrganizationID; v12.Clean = value; BranchOrganizationID = v12;
                var v13 = BranchPhone; v13.Clean = value; BranchPhone = v13;
                var v14 = BranchRating; v14.Clean = value; BranchRating = v14;
                var v15 = BranchState; v15.Clean = value; BranchState = v15;
                var v16 = BranchZip; v16.Clean = value; BranchZip = v16;
                var v17 = CFCAddress; v17.Clean = value; CFCAddress = v17;
                var v18 = CFCBusinessFax; v18.Clean = value; CFCBusinessFax = v18;
                var v19 = CFCBusinessPhone; v19.Clean = value; CFCBusinessPhone = v19;
                var v20 = CFCCellPhone; v20.Clean = value; CFCCellPhone = v20;
                var v21 = CFCCity; v21.Clean = value; CFCCity = v21;
                var v22 = CFCEmail; v22.Clean = value; CFCEmail = v22;
                var v23 = CFCName; v23.Clean = value; CFCName = v23;
                var v24 = CFCNotes; v24.Clean = value; CFCNotes = v24;
                var v25 = CFCRepAE; v25.Clean = value; CFCRepAE = v25;
                var v26 = CFCSRAEUserName; v26.Clean = value; CFCSRAEUserName = v26;
                var v27 = CFCState; v27.Clean = value; CFCState = v27;
                var v28 = CFCStatus; v28.Clean = value; CFCStatus = v28;
                var v29 = CFCUserID; v29.Clean = value; CFCUserID = v29;
                var v30 = CFCZip; v30.Clean = value; CFCZip = v30;
                var v31 = CompanyAddress; v31.Clean = value; CompanyAddress = v31;
                var v32 = CompanyAEName; v32.Clean = value; CompanyAEName = v32;
                var v33 = CompanyAEUserName; v33.Clean = value; CompanyAEUserName = v33;
                var v34 = CompanyCity; v34.Clean = value; CompanyCity = v34;
                var v35 = CompanyDBAName; v35.Clean = value; CompanyDBAName = v35;
                var v36 = CompanyFax; v36.Clean = value; CompanyFax = v36;
                var v37 = CompanyID; v37.Clean = value; CompanyID = v37;
                var v38 = CompanyLegalName; v38.Clean = value; CompanyLegalName = v38;
                var v39 = CompanyManagerEmail; v39.Clean = value; CompanyManagerEmail = v39;
                var v40 = CompanyManagerName; v40.Clean = value; CompanyManagerName = v40;
                var v41 = CompanyName; v41.Clean = value; CompanyName = v41;
                var v42 = CompanyOrganizationID; v42.Clean = value; CompanyOrganizationID = v42;
                var v43 = CompanyPhone; v43.Clean = value; CompanyPhone = v43;
                var v44 = CompanyRating; v44.Clean = value; CompanyRating = v44;
                var v45 = CompanyState; v45.Clean = value; CompanyState = v45;
                var v46 = CompanyZip; v46.Clean = value; CompanyZip = v46;
                var v47 = DocumentsReadyDate; v47.Clean = value; DocumentsReadyDate = v47;
                var v48 = FeeReviewComments; v48.Clean = value; FeeReviewComments = v48;
                var v49 = FeeReviewStatus; v49.Clean = value; FeeReviewStatus = v49;
                var v50 = FeeReviewStatusDate; v50.Clean = value; FeeReviewStatusDate = v50;
                var v51 = ImportSource; v51.Clean = value; ImportSource = v51;
                var v52 = InitialApplicationDate; v52.Clean = value; InitialApplicationDate = v52;
                var v53 = InitialSubmitDate; v53.Clean = value; InitialSubmitDate = v53;
                var v54 = LOAddress; v54.Clean = value; LOAddress = v54;
                var v55 = LOAEName; v55.Clean = value; LOAEName = v55;
                var v56 = LOAEUserName; v56.Clean = value; LOAEUserName = v56;
                var v57 = LOBusinessFax; v57.Clean = value; LOBusinessFax = v57;
                var v58 = LOBusinessPhone; v58.Clean = value; LOBusinessPhone = v58;
                var v59 = LOCellPhone; v59.Clean = value; LOCellPhone = v59;
                var v60 = LOCity; v60.Clean = value; LOCity = v60;
                var v61 = LOEmail; v61.Clean = value; LOEmail = v61;
                var v62 = LOID; v62.Clean = value; LOID = v62;
                var v63 = LOName; v63.Clean = value; LOName = v63;
                var v64 = LONotes; v64.Clean = value; LONotes = v64;
                var v65 = LOState; v65.Clean = value; LOState = v65;
                var v66 = LOStatus; v66.Clean = value; LOStatus = v66;
                var v67 = LOZip; v67.Clean = value; LOZip = v67;
                var v68 = LPAddress; v68.Clean = value; LPAddress = v68;
                var v69 = LPAEName; v69.Clean = value; LPAEName = v69;
                var v70 = LPAEUserName; v70.Clean = value; LPAEUserName = v70;
                var v71 = LPBusinessFax; v71.Clean = value; LPBusinessFax = v71;
                var v72 = LPBusinessPhone; v72.Clean = value; LPBusinessPhone = v72;
                var v73 = LPCellPhone; v73.Clean = value; LPCellPhone = v73;
                var v74 = LPCity; v74.Clean = value; LPCity = v74;
                var v75 = LPEmail; v75.Clean = value; LPEmail = v75;
                var v76 = LPID; v76.Clean = value; LPID = v76;
                var v77 = LPName; v77.Clean = value; LPName = v77;
                var v78 = LPNotes; v78.Clean = value; LPNotes = v78;
                var v79 = LPState; v79.Clean = value; LPState = v79;
                var v80 = LPStatus; v80.Clean = value; LPStatus = v80;
                var v81 = LPZip; v81.Clean = value; LPZip = v81;
                var v82 = PurchaseStipsReadyDate; v82.Clean = value; PurchaseStipsReadyDate = v82;
                var v83 = PurchaseStipsReviewed; v83.Clean = value; PurchaseStipsReviewed = v83;
                var v84 = ReadytoDiscloseDateUtc; v84.Clean = value; ReadytoDiscloseDateUtc = v84;
                var v85 = RegisterDate; v85.Clean = value; RegisterDate = v85;
                var v86 = SITEID; v86.Clean = value; SITEID = v86;
                var v87 = SubmitDate; v87.Clean = value; SubmitDate = v87;
                var v88 = TestAccountField; v88.Clean = value; TestAccountField = v88;
                var v89 = UnderwriterReviewed; v89.Clean = value; UnderwriterReviewed = v89;
                var v90 = UnderwritingDelegated; v90.Clean = value; UnderwritingDelegated = v90;
                var v91 = WatchListFlag; v91.Clean = value; WatchListFlag = v91;
                var v92 = WatchListReason; v92.Clean = value; WatchListReason = v92;
                _settingClean = 0;
            }
        }
    }
}