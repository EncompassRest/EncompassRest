using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Contact
    {
        public Value<string> ABA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeABA() => !ABA.Clean;
        public Value<string> AccountName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountName() => !AccountName.Clean;
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> Address2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress2() => !Address2.Clean;
        public Value<bool?> AddToCdContactInfo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddToCdContactInfo() => !AddToCdContactInfo.Clean;
        public Value<string> AppraisalMade { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalMade() => !AppraisalMade.Clean;
        public Value<DateTime?> BizLicenseAuthDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthDate() => !BizLicenseAuthDate.Clean;
        public Value<string> BizLicenseAuthName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthName() => !BizLicenseAuthName.Clean;
        public Value<string> BizLicenseAuthStateCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthStateCode() => !BizLicenseAuthStateCode.Clean;
        public Value<string> BizLicenseAuthType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthType() => !BizLicenseAuthType.Clean;
        public Value<string> BizLicenseNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseNumber() => !BizLicenseNumber.Clean;
        public Value<bool?> BorrowerActingAsContractorIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerActingAsContractorIndicator() => !BorrowerActingAsContractorIndicator.Clean;
        public Value<string> BrokerLenderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLenderType() => !BrokerLenderType.Clean;
        public Value<bool?> BrokerLicenseExempt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseExempt() => !BrokerLicenseExempt.Clean;
        public Value<string> BrokerLicenseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseType() => !BrokerLicenseType.Clean;
        public Value<string> BusinessPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessPhone() => !BusinessPhone.Clean;
        public Value<string> CategoryName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCategoryName() => !CategoryName.Clean;
        public Value<string> Cell { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCell() => !Cell.Clean;
        public Value<DateTime?> CheckConfirmedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCheckConfirmedDate() => !CheckConfirmedDate.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> Clause { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClause() => !Clause.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> CompanyId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyId() => !CompanyId.Clean;
        public Value<decimal?> CompletionAffidavitPunchListTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletionAffidavitPunchListTotal() => !CompletionAffidavitPunchListTotal.Clean;
        public Value<int?> ContactIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactIndex() => !ContactIndex.Clean;
        public Value<string> ContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !ContactName.Clean;
        public Value<string> ContactNMLSNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactNMLSNo() => !ContactNMLSNo.Clean;
        public Value<string> ContactTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactTitle() => !ContactTitle.Clean;
        public Value<string> ContactType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactType() => !ContactType.Clean;
        public Value<DateTime?> DesigneeAcceptedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDesigneeAcceptedDate() => !DesigneeAcceptedDate.Clean;
        public Value<string> Email { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !Email.Clean;
        public Value<decimal?> EmployerLiabilityInsuranceMin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerLiabilityInsuranceMin() => !EmployerLiabilityInsuranceMin.Clean;
        public Value<string> Fax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !Fax.Clean;
        public Value<string> Fax2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax2() => !Fax2.Clean;
        public Value<string> FhaLenderId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaLenderId() => !FhaLenderId.Clean;
        public Value<decimal?> GeneralLiabilityInsuranceMin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralLiabilityInsuranceMin() => !GeneralLiabilityInsuranceMin.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InsuranceCertNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceCertNumber() => !InsuranceCertNumber.Clean;
        public Value<decimal?> InsuranceCoverageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceCoverageAmount() => !InsuranceCoverageAmount.Clean;
        public Value<DateTime?> InsuranceDeterminationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceDeterminationDate() => !InsuranceDeterminationDate.Clean;
        public Value<string> InsuranceDeterminationNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceDeterminationNumber() => !InsuranceDeterminationNumber.Clean;
        public Value<bool?> InsuranceFloodZone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceFloodZone() => !InsuranceFloodZone.Clean;
        public Value<string> InsuranceMap { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceMap() => !InsuranceMap.Clean;
        public Value<int?> InsuranceNoOfBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceNoOfBedrooms() => !InsuranceNoOfBedrooms.Clean;
        public Value<decimal?> InsurancePremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsurancePremium() => !InsurancePremium.Clean;
        public Value<string> InsuranceProjectType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceProjectType() => !InsuranceProjectType.Clean;
        public Value<DateTime?> InsuranceRenewalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceRenewalDate() => !InsuranceRenewalDate.Clean;
        public Value<string> InvestorGrade1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade1() => !InvestorGrade1.Clean;
        public Value<string> InvestorGrade2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade2() => !InvestorGrade2.Clean;
        public Value<string> InvestorGrade3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade3() => !InvestorGrade3.Clean;
        public Value<string> InvestorLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLicense() => !InvestorLicense.Clean;
        public Value<string> InvestorLicenseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLicenseType() => !InvestorLicenseType.Clean;
        public Value<string> InvestorName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName1() => !InvestorName1.Clean;
        public Value<string> InvestorName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName2() => !InvestorName2.Clean;
        public Value<string> InvestorName3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName3() => !InvestorName3.Clean;
        public Value<string> InvestorScore1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore1() => !InvestorScore1.Clean;
        public Value<string> InvestorScore2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore2() => !InvestorScore2.Clean;
        public Value<string> InvestorScore3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore3() => !InvestorScore3.Clean;
        public Value<string> LenderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderType() => !LenderType.Clean;
        public Value<string> License { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicense() => !License.Clean;
        public Value<bool?> LicenseExempt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseExempt() => !LicenseExempt.Clean;
        public Value<string> LicenseHomeState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseHomeState() => !LicenseHomeState.Clean;
        public Value<string> LicenseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseType() => !LicenseType.Clean;
        public Value<string> LineItemNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemNumber() => !LineItemNumber.Clean;
        public Value<string> LoginId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoginId() => !LoginId.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> NmlsLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsLicense() => !NmlsLicense.Clean;
        public Value<bool?> NotNaturalPersonFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotNaturalPersonFlag() => !NotNaturalPersonFlag.Clean;
        public Value<string> OrganizationState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationState() => !OrganizationState.Clean;
        public Value<string> OrganizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationType() => !OrganizationType.Clean;
        public Value<DateTime?> PersonalLicenseAuthDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthDate() => !PersonalLicenseAuthDate.Clean;
        public Value<string> PersonalLicenseAuthName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthName() => !PersonalLicenseAuthName.Clean;
        public Value<string> PersonalLicenseAuthStateCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthStateCode() => !PersonalLicenseAuthStateCode.Clean;
        public Value<string> PersonalLicenseAuthType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthType() => !PersonalLicenseAuthType.Clean;
        public Value<string> PersonalLicenseNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseNumber() => !PersonalLicenseNumber.Clean;
        public Value<string> Phone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !Phone.Clean;
        public Value<string> Phone2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone2() => !Phone2.Clean;
        public Value<string> PostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !PostalCode.Clean;
        public Value<string> RecCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecCity() => !RecCity.Clean;
        public Value<string> ReferenceNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferenceNumber() => !ReferenceNumber.Clean;
        public Value<string> Relationship { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationship() => !Relationship.Clean;
        public Value<bool?> SettlementAgent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgent() => !SettlementAgent.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> TaxID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxID() => !TaxID.Clean;
        public Value<string> TqlCommentHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlCommentHistory() => !TqlCommentHistory.Clean;
        public Value<string> TQLConsentSelection { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLConsentSelection() => !TQLConsentSelection.Clean;
        public Value<int?> TqlId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlId() => !TqlId.Clean;
        public Value<bool?> TqlIsPublishingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlIsPublishingIndicator() => !TqlIsPublishingIndicator.Clean;
        public Value<string> TqlName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlName() => !TqlName.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ABA.Clean
                    && AccountName.Clean
                    && Address.Clean
                    && Address2.Clean
                    && AddToCdContactInfo.Clean
                    && AppraisalMade.Clean
                    && BizLicenseAuthDate.Clean
                    && BizLicenseAuthName.Clean
                    && BizLicenseAuthStateCode.Clean
                    && BizLicenseAuthType.Clean
                    && BizLicenseNumber.Clean
                    && BorrowerActingAsContractorIndicator.Clean
                    && BrokerLenderType.Clean
                    && BrokerLicenseExempt.Clean
                    && BrokerLicenseType.Clean
                    && BusinessPhone.Clean
                    && CategoryName.Clean
                    && Cell.Clean
                    && CheckConfirmedDate.Clean
                    && City.Clean
                    && Clause.Clean
                    && Comments.Clean
                    && CompanyId.Clean
                    && CompletionAffidavitPunchListTotal.Clean
                    && ContactIndex.Clean
                    && ContactName.Clean
                    && ContactNMLSNo.Clean
                    && ContactTitle.Clean
                    && ContactType.Clean
                    && DesigneeAcceptedDate.Clean
                    && Email.Clean
                    && EmployerLiabilityInsuranceMin.Clean
                    && Fax.Clean
                    && Fax2.Clean
                    && FhaLenderId.Clean
                    && GeneralLiabilityInsuranceMin.Clean
                    && Id.Clean
                    && InsuranceCertNumber.Clean
                    && InsuranceCoverageAmount.Clean
                    && InsuranceDeterminationDate.Clean
                    && InsuranceDeterminationNumber.Clean
                    && InsuranceFloodZone.Clean
                    && InsuranceMap.Clean
                    && InsuranceNoOfBedrooms.Clean
                    && InsurancePremium.Clean
                    && InsuranceProjectType.Clean
                    && InsuranceRenewalDate.Clean
                    && InvestorGrade1.Clean
                    && InvestorGrade2.Clean
                    && InvestorGrade3.Clean
                    && InvestorLicense.Clean
                    && InvestorLicenseType.Clean
                    && InvestorName1.Clean
                    && InvestorName2.Clean
                    && InvestorName3.Clean
                    && InvestorScore1.Clean
                    && InvestorScore2.Clean
                    && InvestorScore3.Clean
                    && LenderType.Clean
                    && License.Clean
                    && LicenseExempt.Clean
                    && LicenseHomeState.Clean
                    && LicenseType.Clean
                    && LineItemNumber.Clean
                    && LoginId.Clean
                    && Name.Clean
                    && NmlsLicense.Clean
                    && NotNaturalPersonFlag.Clean
                    && OrganizationState.Clean
                    && OrganizationType.Clean
                    && PersonalLicenseAuthDate.Clean
                    && PersonalLicenseAuthName.Clean
                    && PersonalLicenseAuthStateCode.Clean
                    && PersonalLicenseAuthType.Clean
                    && PersonalLicenseNumber.Clean
                    && Phone.Clean
                    && Phone2.Clean
                    && PostalCode.Clean
                    && RecCity.Clean
                    && ReferenceNumber.Clean
                    && Relationship.Clean
                    && SettlementAgent.Clean
                    && State.Clean
                    && TaxID.Clean
                    && TqlCommentHistory.Clean
                    && TQLConsentSelection.Clean
                    && TqlId.Clean
                    && TqlIsPublishingIndicator.Clean
                    && TqlName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ABA; v0.Clean = value; ABA = v0;
                var v1 = AccountName; v1.Clean = value; AccountName = v1;
                var v2 = Address; v2.Clean = value; Address = v2;
                var v3 = Address2; v3.Clean = value; Address2 = v3;
                var v4 = AddToCdContactInfo; v4.Clean = value; AddToCdContactInfo = v4;
                var v5 = AppraisalMade; v5.Clean = value; AppraisalMade = v5;
                var v6 = BizLicenseAuthDate; v6.Clean = value; BizLicenseAuthDate = v6;
                var v7 = BizLicenseAuthName; v7.Clean = value; BizLicenseAuthName = v7;
                var v8 = BizLicenseAuthStateCode; v8.Clean = value; BizLicenseAuthStateCode = v8;
                var v9 = BizLicenseAuthType; v9.Clean = value; BizLicenseAuthType = v9;
                var v10 = BizLicenseNumber; v10.Clean = value; BizLicenseNumber = v10;
                var v11 = BorrowerActingAsContractorIndicator; v11.Clean = value; BorrowerActingAsContractorIndicator = v11;
                var v12 = BrokerLenderType; v12.Clean = value; BrokerLenderType = v12;
                var v13 = BrokerLicenseExempt; v13.Clean = value; BrokerLicenseExempt = v13;
                var v14 = BrokerLicenseType; v14.Clean = value; BrokerLicenseType = v14;
                var v15 = BusinessPhone; v15.Clean = value; BusinessPhone = v15;
                var v16 = CategoryName; v16.Clean = value; CategoryName = v16;
                var v17 = Cell; v17.Clean = value; Cell = v17;
                var v18 = CheckConfirmedDate; v18.Clean = value; CheckConfirmedDate = v18;
                var v19 = City; v19.Clean = value; City = v19;
                var v20 = Clause; v20.Clean = value; Clause = v20;
                var v21 = Comments; v21.Clean = value; Comments = v21;
                var v22 = CompanyId; v22.Clean = value; CompanyId = v22;
                var v23 = CompletionAffidavitPunchListTotal; v23.Clean = value; CompletionAffidavitPunchListTotal = v23;
                var v24 = ContactIndex; v24.Clean = value; ContactIndex = v24;
                var v25 = ContactName; v25.Clean = value; ContactName = v25;
                var v26 = ContactNMLSNo; v26.Clean = value; ContactNMLSNo = v26;
                var v27 = ContactTitle; v27.Clean = value; ContactTitle = v27;
                var v28 = ContactType; v28.Clean = value; ContactType = v28;
                var v29 = DesigneeAcceptedDate; v29.Clean = value; DesigneeAcceptedDate = v29;
                var v30 = Email; v30.Clean = value; Email = v30;
                var v31 = EmployerLiabilityInsuranceMin; v31.Clean = value; EmployerLiabilityInsuranceMin = v31;
                var v32 = Fax; v32.Clean = value; Fax = v32;
                var v33 = Fax2; v33.Clean = value; Fax2 = v33;
                var v34 = FhaLenderId; v34.Clean = value; FhaLenderId = v34;
                var v35 = GeneralLiabilityInsuranceMin; v35.Clean = value; GeneralLiabilityInsuranceMin = v35;
                var v36 = Id; v36.Clean = value; Id = v36;
                var v37 = InsuranceCertNumber; v37.Clean = value; InsuranceCertNumber = v37;
                var v38 = InsuranceCoverageAmount; v38.Clean = value; InsuranceCoverageAmount = v38;
                var v39 = InsuranceDeterminationDate; v39.Clean = value; InsuranceDeterminationDate = v39;
                var v40 = InsuranceDeterminationNumber; v40.Clean = value; InsuranceDeterminationNumber = v40;
                var v41 = InsuranceFloodZone; v41.Clean = value; InsuranceFloodZone = v41;
                var v42 = InsuranceMap; v42.Clean = value; InsuranceMap = v42;
                var v43 = InsuranceNoOfBedrooms; v43.Clean = value; InsuranceNoOfBedrooms = v43;
                var v44 = InsurancePremium; v44.Clean = value; InsurancePremium = v44;
                var v45 = InsuranceProjectType; v45.Clean = value; InsuranceProjectType = v45;
                var v46 = InsuranceRenewalDate; v46.Clean = value; InsuranceRenewalDate = v46;
                var v47 = InvestorGrade1; v47.Clean = value; InvestorGrade1 = v47;
                var v48 = InvestorGrade2; v48.Clean = value; InvestorGrade2 = v48;
                var v49 = InvestorGrade3; v49.Clean = value; InvestorGrade3 = v49;
                var v50 = InvestorLicense; v50.Clean = value; InvestorLicense = v50;
                var v51 = InvestorLicenseType; v51.Clean = value; InvestorLicenseType = v51;
                var v52 = InvestorName1; v52.Clean = value; InvestorName1 = v52;
                var v53 = InvestorName2; v53.Clean = value; InvestorName2 = v53;
                var v54 = InvestorName3; v54.Clean = value; InvestorName3 = v54;
                var v55 = InvestorScore1; v55.Clean = value; InvestorScore1 = v55;
                var v56 = InvestorScore2; v56.Clean = value; InvestorScore2 = v56;
                var v57 = InvestorScore3; v57.Clean = value; InvestorScore3 = v57;
                var v58 = LenderType; v58.Clean = value; LenderType = v58;
                var v59 = License; v59.Clean = value; License = v59;
                var v60 = LicenseExempt; v60.Clean = value; LicenseExempt = v60;
                var v61 = LicenseHomeState; v61.Clean = value; LicenseHomeState = v61;
                var v62 = LicenseType; v62.Clean = value; LicenseType = v62;
                var v63 = LineItemNumber; v63.Clean = value; LineItemNumber = v63;
                var v64 = LoginId; v64.Clean = value; LoginId = v64;
                var v65 = Name; v65.Clean = value; Name = v65;
                var v66 = NmlsLicense; v66.Clean = value; NmlsLicense = v66;
                var v67 = NotNaturalPersonFlag; v67.Clean = value; NotNaturalPersonFlag = v67;
                var v68 = OrganizationState; v68.Clean = value; OrganizationState = v68;
                var v69 = OrganizationType; v69.Clean = value; OrganizationType = v69;
                var v70 = PersonalLicenseAuthDate; v70.Clean = value; PersonalLicenseAuthDate = v70;
                var v71 = PersonalLicenseAuthName; v71.Clean = value; PersonalLicenseAuthName = v71;
                var v72 = PersonalLicenseAuthStateCode; v72.Clean = value; PersonalLicenseAuthStateCode = v72;
                var v73 = PersonalLicenseAuthType; v73.Clean = value; PersonalLicenseAuthType = v73;
                var v74 = PersonalLicenseNumber; v74.Clean = value; PersonalLicenseNumber = v74;
                var v75 = Phone; v75.Clean = value; Phone = v75;
                var v76 = Phone2; v76.Clean = value; Phone2 = v76;
                var v77 = PostalCode; v77.Clean = value; PostalCode = v77;
                var v78 = RecCity; v78.Clean = value; RecCity = v78;
                var v79 = ReferenceNumber; v79.Clean = value; ReferenceNumber = v79;
                var v80 = Relationship; v80.Clean = value; Relationship = v80;
                var v81 = SettlementAgent; v81.Clean = value; SettlementAgent = v81;
                var v82 = State; v82.Clean = value; State = v82;
                var v83 = TaxID; v83.Clean = value; TaxID = v83;
                var v84 = TqlCommentHistory; v84.Clean = value; TqlCommentHistory = v84;
                var v85 = TQLConsentSelection; v85.Clean = value; TQLConsentSelection = v85;
                var v86 = TqlId; v86.Clean = value; TqlId = v86;
                var v87 = TqlIsPublishingIndicator; v87.Clean = value; TqlIsPublishingIndicator = v87;
                var v88 = TqlName; v88.Clean = value; TqlName = v88;
                _settingClean = 0;
            }
        }
    }
}