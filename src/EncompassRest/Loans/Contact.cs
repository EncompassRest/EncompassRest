using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Contact
    {
        private Value<string> _aBA;
        public string ABA { get { return _aBA; } set { _aBA = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeABA() => !_aBA.Clean;
        private Value<string> _accountName;
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountName() => !_accountName.Clean;
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !_address.Clean;
        private Value<string> _address2;
        public string Address2 { get { return _address2; } set { _address2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress2() => !_address2.Clean;
        private Value<bool?> _addToCdContactInfo;
        public bool? AddToCdContactInfo { get { return _addToCdContactInfo; } set { _addToCdContactInfo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddToCdContactInfo() => !_addToCdContactInfo.Clean;
        private Value<string> _appraisalMade;
        public string AppraisalMade { get { return _appraisalMade; } set { _appraisalMade = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalMade() => !_appraisalMade.Clean;
        private Value<DateTime?> _bizLicenseAuthDate;
        public DateTime? BizLicenseAuthDate { get { return _bizLicenseAuthDate; } set { _bizLicenseAuthDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthDate() => !_bizLicenseAuthDate.Clean;
        private Value<string> _bizLicenseAuthName;
        public string BizLicenseAuthName { get { return _bizLicenseAuthName; } set { _bizLicenseAuthName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthName() => !_bizLicenseAuthName.Clean;
        private Value<string> _bizLicenseAuthStateCode;
        public string BizLicenseAuthStateCode { get { return _bizLicenseAuthStateCode; } set { _bizLicenseAuthStateCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthStateCode() => !_bizLicenseAuthStateCode.Clean;
        private Value<string> _bizLicenseAuthType;
        public string BizLicenseAuthType { get { return _bizLicenseAuthType; } set { _bizLicenseAuthType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseAuthType() => !_bizLicenseAuthType.Clean;
        private Value<string> _bizLicenseNumber;
        public string BizLicenseNumber { get { return _bizLicenseNumber; } set { _bizLicenseNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBizLicenseNumber() => !_bizLicenseNumber.Clean;
        private Value<bool?> _borrowerActingAsContractorIndicator;
        public bool? BorrowerActingAsContractorIndicator { get { return _borrowerActingAsContractorIndicator; } set { _borrowerActingAsContractorIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerActingAsContractorIndicator() => !_borrowerActingAsContractorIndicator.Clean;
        private Value<string> _brokerLenderType;
        public string BrokerLenderType { get { return _brokerLenderType; } set { _brokerLenderType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLenderType() => !_brokerLenderType.Clean;
        private Value<bool?> _brokerLicenseExempt;
        public bool? BrokerLicenseExempt { get { return _brokerLicenseExempt; } set { _brokerLicenseExempt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseExempt() => !_brokerLicenseExempt.Clean;
        private Value<string> _brokerLicenseType;
        public string BrokerLicenseType { get { return _brokerLicenseType; } set { _brokerLicenseType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseType() => !_brokerLicenseType.Clean;
        private Value<string> _businessPhone;
        public string BusinessPhone { get { return _businessPhone; } set { _businessPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessPhone() => !_businessPhone.Clean;
        private Value<string> _categoryName;
        public string CategoryName { get { return _categoryName; } set { _categoryName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCategoryName() => !_categoryName.Clean;
        private Value<string> _cell;
        public string Cell { get { return _cell; } set { _cell = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCell() => !_cell.Clean;
        private Value<DateTime?> _checkConfirmedDate;
        public DateTime? CheckConfirmedDate { get { return _checkConfirmedDate; } set { _checkConfirmedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCheckConfirmedDate() => !_checkConfirmedDate.Clean;
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !_city.Clean;
        private Value<string> _clause;
        public string Clause { get { return _clause; } set { _clause = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClause() => !_clause.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _companyId;
        public string CompanyId { get { return _companyId; } set { _companyId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompanyId() => !_companyId.Clean;
        private Value<decimal?> _completionAffidavitPunchListTotal;
        public decimal? CompletionAffidavitPunchListTotal { get { return _completionAffidavitPunchListTotal; } set { _completionAffidavitPunchListTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletionAffidavitPunchListTotal() => !_completionAffidavitPunchListTotal.Clean;
        private Value<int?> _contactIndex;
        public int? ContactIndex { get { return _contactIndex; } set { _contactIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactIndex() => !_contactIndex.Clean;
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !_contactName.Clean;
        private Value<string> _contactNMLSNo;
        public string ContactNMLSNo { get { return _contactNMLSNo; } set { _contactNMLSNo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactNMLSNo() => !_contactNMLSNo.Clean;
        private Value<string> _contactTitle;
        public string ContactTitle { get { return _contactTitle; } set { _contactTitle = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactTitle() => !_contactTitle.Clean;
        private Value<string> _contactType;
        public string ContactType { get { return _contactType; } set { _contactType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactType() => !_contactType.Clean;
        private Value<DateTime?> _designeeAcceptedDate;
        public DateTime? DesigneeAcceptedDate { get { return _designeeAcceptedDate; } set { _designeeAcceptedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDesigneeAcceptedDate() => !_designeeAcceptedDate.Clean;
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmail() => !_email.Clean;
        private Value<decimal?> _employerLiabilityInsuranceMin;
        public decimal? EmployerLiabilityInsuranceMin { get { return _employerLiabilityInsuranceMin; } set { _employerLiabilityInsuranceMin = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployerLiabilityInsuranceMin() => !_employerLiabilityInsuranceMin.Clean;
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax() => !_fax.Clean;
        private Value<string> _fax2;
        public string Fax2 { get { return _fax2; } set { _fax2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFax2() => !_fax2.Clean;
        private Value<string> _fhaLenderId;
        public string FhaLenderId { get { return _fhaLenderId; } set { _fhaLenderId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaLenderId() => !_fhaLenderId.Clean;
        private Value<decimal?> _generalLiabilityInsuranceMin;
        public decimal? GeneralLiabilityInsuranceMin { get { return _generalLiabilityInsuranceMin; } set { _generalLiabilityInsuranceMin = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralLiabilityInsuranceMin() => !_generalLiabilityInsuranceMin.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _insuranceCertNumber;
        public string InsuranceCertNumber { get { return _insuranceCertNumber; } set { _insuranceCertNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceCertNumber() => !_insuranceCertNumber.Clean;
        private Value<decimal?> _insuranceCoverageAmount;
        public decimal? InsuranceCoverageAmount { get { return _insuranceCoverageAmount; } set { _insuranceCoverageAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceCoverageAmount() => !_insuranceCoverageAmount.Clean;
        private Value<DateTime?> _insuranceDeterminationDate;
        public DateTime? InsuranceDeterminationDate { get { return _insuranceDeterminationDate; } set { _insuranceDeterminationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceDeterminationDate() => !_insuranceDeterminationDate.Clean;
        private Value<string> _insuranceDeterminationNumber;
        public string InsuranceDeterminationNumber { get { return _insuranceDeterminationNumber; } set { _insuranceDeterminationNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceDeterminationNumber() => !_insuranceDeterminationNumber.Clean;
        private Value<bool?> _insuranceFloodZone;
        public bool? InsuranceFloodZone { get { return _insuranceFloodZone; } set { _insuranceFloodZone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceFloodZone() => !_insuranceFloodZone.Clean;
        private Value<string> _insuranceMap;
        public string InsuranceMap { get { return _insuranceMap; } set { _insuranceMap = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceMap() => !_insuranceMap.Clean;
        private Value<int?> _insuranceNoOfBedrooms;
        public int? InsuranceNoOfBedrooms { get { return _insuranceNoOfBedrooms; } set { _insuranceNoOfBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceNoOfBedrooms() => !_insuranceNoOfBedrooms.Clean;
        private Value<decimal?> _insurancePremium;
        public decimal? InsurancePremium { get { return _insurancePremium; } set { _insurancePremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsurancePremium() => !_insurancePremium.Clean;
        private Value<string> _insuranceProjectType;
        public string InsuranceProjectType { get { return _insuranceProjectType; } set { _insuranceProjectType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceProjectType() => !_insuranceProjectType.Clean;
        private Value<DateTime?> _insuranceRenewalDate;
        public DateTime? InsuranceRenewalDate { get { return _insuranceRenewalDate; } set { _insuranceRenewalDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceRenewalDate() => !_insuranceRenewalDate.Clean;
        private Value<string> _investorGrade1;
        public string InvestorGrade1 { get { return _investorGrade1; } set { _investorGrade1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade1() => !_investorGrade1.Clean;
        private Value<string> _investorGrade2;
        public string InvestorGrade2 { get { return _investorGrade2; } set { _investorGrade2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade2() => !_investorGrade2.Clean;
        private Value<string> _investorGrade3;
        public string InvestorGrade3 { get { return _investorGrade3; } set { _investorGrade3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorGrade3() => !_investorGrade3.Clean;
        private Value<string> _investorLicense;
        public string InvestorLicense { get { return _investorLicense; } set { _investorLicense = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLicense() => !_investorLicense.Clean;
        private Value<string> _investorLicenseType;
        public string InvestorLicenseType { get { return _investorLicenseType; } set { _investorLicenseType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLicenseType() => !_investorLicenseType.Clean;
        private Value<string> _investorName1;
        public string InvestorName1 { get { return _investorName1; } set { _investorName1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName1() => !_investorName1.Clean;
        private Value<string> _investorName2;
        public string InvestorName2 { get { return _investorName2; } set { _investorName2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName2() => !_investorName2.Clean;
        private Value<string> _investorName3;
        public string InvestorName3 { get { return _investorName3; } set { _investorName3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorName3() => !_investorName3.Clean;
        private Value<string> _investorScore1;
        public string InvestorScore1 { get { return _investorScore1; } set { _investorScore1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore1() => !_investorScore1.Clean;
        private Value<string> _investorScore2;
        public string InvestorScore2 { get { return _investorScore2; } set { _investorScore2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore2() => !_investorScore2.Clean;
        private Value<string> _investorScore3;
        public string InvestorScore3 { get { return _investorScore3; } set { _investorScore3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorScore3() => !_investorScore3.Clean;
        private Value<string> _lenderType;
        public string LenderType { get { return _lenderType; } set { _lenderType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderType() => !_lenderType.Clean;
        private Value<string> _license;
        public string License { get { return _license; } set { _license = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicense() => !_license.Clean;
        private Value<bool?> _licenseExempt;
        public bool? LicenseExempt { get { return _licenseExempt; } set { _licenseExempt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseExempt() => !_licenseExempt.Clean;
        private Value<string> _licenseHomeState;
        public string LicenseHomeState { get { return _licenseHomeState; } set { _licenseHomeState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseHomeState() => !_licenseHomeState.Clean;
        private Value<string> _licenseType;
        public string LicenseType { get { return _licenseType; } set { _licenseType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicenseType() => !_licenseType.Clean;
        private Value<string> _lineItemNumber;
        public string LineItemNumber { get { return _lineItemNumber; } set { _lineItemNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineItemNumber() => !_lineItemNumber.Clean;
        private Value<string> _loginId;
        public string LoginId { get { return _loginId; } set { _loginId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoginId() => !_loginId.Clean;
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !_name.Clean;
        private Value<string> _nmlsLicense;
        public string NmlsLicense { get { return _nmlsLicense; } set { _nmlsLicense = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsLicense() => !_nmlsLicense.Clean;
        private Value<bool?> _notNaturalPersonFlag;
        public bool? NotNaturalPersonFlag { get { return _notNaturalPersonFlag; } set { _notNaturalPersonFlag = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotNaturalPersonFlag() => !_notNaturalPersonFlag.Clean;
        private Value<string> _organizationState;
        public string OrganizationState { get { return _organizationState; } set { _organizationState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationState() => !_organizationState.Clean;
        private Value<string> _organizationType;
        public string OrganizationType { get { return _organizationType; } set { _organizationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrganizationType() => !_organizationType.Clean;
        private Value<DateTime?> _personalLicenseAuthDate;
        public DateTime? PersonalLicenseAuthDate { get { return _personalLicenseAuthDate; } set { _personalLicenseAuthDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthDate() => !_personalLicenseAuthDate.Clean;
        private Value<string> _personalLicenseAuthName;
        public string PersonalLicenseAuthName { get { return _personalLicenseAuthName; } set { _personalLicenseAuthName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthName() => !_personalLicenseAuthName.Clean;
        private Value<string> _personalLicenseAuthStateCode;
        public string PersonalLicenseAuthStateCode { get { return _personalLicenseAuthStateCode; } set { _personalLicenseAuthStateCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthStateCode() => !_personalLicenseAuthStateCode.Clean;
        private Value<string> _personalLicenseAuthType;
        public string PersonalLicenseAuthType { get { return _personalLicenseAuthType; } set { _personalLicenseAuthType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseAuthType() => !_personalLicenseAuthType.Clean;
        private Value<string> _personalLicenseNumber;
        public string PersonalLicenseNumber { get { return _personalLicenseNumber; } set { _personalLicenseNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonalLicenseNumber() => !_personalLicenseNumber.Clean;
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone() => !_phone.Clean;
        private Value<string> _phone2;
        public string Phone2 { get { return _phone2; } set { _phone2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhone2() => !_phone2.Clean;
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !_postalCode.Clean;
        private Value<string> _recCity;
        public string RecCity { get { return _recCity; } set { _recCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecCity() => !_recCity.Clean;
        private Value<string> _referenceNumber;
        public string ReferenceNumber { get { return _referenceNumber; } set { _referenceNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReferenceNumber() => !_referenceNumber.Clean;
        private Value<string> _relationship;
        public string Relationship { get { return _relationship; } set { _relationship = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationship() => !_relationship.Clean;
        private Value<bool?> _settlementAgent;
        public bool? SettlementAgent { get { return _settlementAgent; } set { _settlementAgent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementAgent() => !_settlementAgent.Clean;
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !_state.Clean;
        private Value<string> _taxID;
        public string TaxID { get { return _taxID; } set { _taxID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxID() => !_taxID.Clean;
        private Value<string> _tqlCommentHistory;
        public string TqlCommentHistory { get { return _tqlCommentHistory; } set { _tqlCommentHistory = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlCommentHistory() => !_tqlCommentHistory.Clean;
        private Value<string> _tQLConsentSelection;
        public string TQLConsentSelection { get { return _tQLConsentSelection; } set { _tQLConsentSelection = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTQLConsentSelection() => !_tQLConsentSelection.Clean;
        private Value<int?> _tqlId;
        public int? TqlId { get { return _tqlId; } set { _tqlId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlId() => !_tqlId.Clean;
        private Value<bool?> _tqlIsPublishingIndicator;
        public bool? TqlIsPublishingIndicator { get { return _tqlIsPublishingIndicator; } set { _tqlIsPublishingIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlIsPublishingIndicator() => !_tqlIsPublishingIndicator.Clean;
        private Value<string> _tqlName;
        public string TqlName { get { return _tqlName; } set { _tqlName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTqlName() => !_tqlName.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aBA.Clean
                    && _accountName.Clean
                    && _address.Clean
                    && _address2.Clean
                    && _addToCdContactInfo.Clean
                    && _appraisalMade.Clean
                    && _bizLicenseAuthDate.Clean
                    && _bizLicenseAuthName.Clean
                    && _bizLicenseAuthStateCode.Clean
                    && _bizLicenseAuthType.Clean
                    && _bizLicenseNumber.Clean
                    && _borrowerActingAsContractorIndicator.Clean
                    && _brokerLenderType.Clean
                    && _brokerLicenseExempt.Clean
                    && _brokerLicenseType.Clean
                    && _businessPhone.Clean
                    && _categoryName.Clean
                    && _cell.Clean
                    && _checkConfirmedDate.Clean
                    && _city.Clean
                    && _clause.Clean
                    && _comments.Clean
                    && _companyId.Clean
                    && _completionAffidavitPunchListTotal.Clean
                    && _contactIndex.Clean
                    && _contactName.Clean
                    && _contactNMLSNo.Clean
                    && _contactTitle.Clean
                    && _contactType.Clean
                    && _designeeAcceptedDate.Clean
                    && _email.Clean
                    && _employerLiabilityInsuranceMin.Clean
                    && _fax.Clean
                    && _fax2.Clean
                    && _fhaLenderId.Clean
                    && _generalLiabilityInsuranceMin.Clean
                    && _id.Clean
                    && _insuranceCertNumber.Clean
                    && _insuranceCoverageAmount.Clean
                    && _insuranceDeterminationDate.Clean
                    && _insuranceDeterminationNumber.Clean
                    && _insuranceFloodZone.Clean
                    && _insuranceMap.Clean
                    && _insuranceNoOfBedrooms.Clean
                    && _insurancePremium.Clean
                    && _insuranceProjectType.Clean
                    && _insuranceRenewalDate.Clean
                    && _investorGrade1.Clean
                    && _investorGrade2.Clean
                    && _investorGrade3.Clean
                    && _investorLicense.Clean
                    && _investorLicenseType.Clean
                    && _investorName1.Clean
                    && _investorName2.Clean
                    && _investorName3.Clean
                    && _investorScore1.Clean
                    && _investorScore2.Clean
                    && _investorScore3.Clean
                    && _lenderType.Clean
                    && _license.Clean
                    && _licenseExempt.Clean
                    && _licenseHomeState.Clean
                    && _licenseType.Clean
                    && _lineItemNumber.Clean
                    && _loginId.Clean
                    && _name.Clean
                    && _nmlsLicense.Clean
                    && _notNaturalPersonFlag.Clean
                    && _organizationState.Clean
                    && _organizationType.Clean
                    && _personalLicenseAuthDate.Clean
                    && _personalLicenseAuthName.Clean
                    && _personalLicenseAuthStateCode.Clean
                    && _personalLicenseAuthType.Clean
                    && _personalLicenseNumber.Clean
                    && _phone.Clean
                    && _phone2.Clean
                    && _postalCode.Clean
                    && _recCity.Clean
                    && _referenceNumber.Clean
                    && _relationship.Clean
                    && _settlementAgent.Clean
                    && _state.Clean
                    && _taxID.Clean
                    && _tqlCommentHistory.Clean
                    && _tQLConsentSelection.Clean
                    && _tqlId.Clean
                    && _tqlIsPublishingIndicator.Clean
                    && _tqlName.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _aBA; v0.Clean = value; _aBA = v0;
                var v1 = _accountName; v1.Clean = value; _accountName = v1;
                var v2 = _address; v2.Clean = value; _address = v2;
                var v3 = _address2; v3.Clean = value; _address2 = v3;
                var v4 = _addToCdContactInfo; v4.Clean = value; _addToCdContactInfo = v4;
                var v5 = _appraisalMade; v5.Clean = value; _appraisalMade = v5;
                var v6 = _bizLicenseAuthDate; v6.Clean = value; _bizLicenseAuthDate = v6;
                var v7 = _bizLicenseAuthName; v7.Clean = value; _bizLicenseAuthName = v7;
                var v8 = _bizLicenseAuthStateCode; v8.Clean = value; _bizLicenseAuthStateCode = v8;
                var v9 = _bizLicenseAuthType; v9.Clean = value; _bizLicenseAuthType = v9;
                var v10 = _bizLicenseNumber; v10.Clean = value; _bizLicenseNumber = v10;
                var v11 = _borrowerActingAsContractorIndicator; v11.Clean = value; _borrowerActingAsContractorIndicator = v11;
                var v12 = _brokerLenderType; v12.Clean = value; _brokerLenderType = v12;
                var v13 = _brokerLicenseExempt; v13.Clean = value; _brokerLicenseExempt = v13;
                var v14 = _brokerLicenseType; v14.Clean = value; _brokerLicenseType = v14;
                var v15 = _businessPhone; v15.Clean = value; _businessPhone = v15;
                var v16 = _categoryName; v16.Clean = value; _categoryName = v16;
                var v17 = _cell; v17.Clean = value; _cell = v17;
                var v18 = _checkConfirmedDate; v18.Clean = value; _checkConfirmedDate = v18;
                var v19 = _city; v19.Clean = value; _city = v19;
                var v20 = _clause; v20.Clean = value; _clause = v20;
                var v21 = _comments; v21.Clean = value; _comments = v21;
                var v22 = _companyId; v22.Clean = value; _companyId = v22;
                var v23 = _completionAffidavitPunchListTotal; v23.Clean = value; _completionAffidavitPunchListTotal = v23;
                var v24 = _contactIndex; v24.Clean = value; _contactIndex = v24;
                var v25 = _contactName; v25.Clean = value; _contactName = v25;
                var v26 = _contactNMLSNo; v26.Clean = value; _contactNMLSNo = v26;
                var v27 = _contactTitle; v27.Clean = value; _contactTitle = v27;
                var v28 = _contactType; v28.Clean = value; _contactType = v28;
                var v29 = _designeeAcceptedDate; v29.Clean = value; _designeeAcceptedDate = v29;
                var v30 = _email; v30.Clean = value; _email = v30;
                var v31 = _employerLiabilityInsuranceMin; v31.Clean = value; _employerLiabilityInsuranceMin = v31;
                var v32 = _fax; v32.Clean = value; _fax = v32;
                var v33 = _fax2; v33.Clean = value; _fax2 = v33;
                var v34 = _fhaLenderId; v34.Clean = value; _fhaLenderId = v34;
                var v35 = _generalLiabilityInsuranceMin; v35.Clean = value; _generalLiabilityInsuranceMin = v35;
                var v36 = _id; v36.Clean = value; _id = v36;
                var v37 = _insuranceCertNumber; v37.Clean = value; _insuranceCertNumber = v37;
                var v38 = _insuranceCoverageAmount; v38.Clean = value; _insuranceCoverageAmount = v38;
                var v39 = _insuranceDeterminationDate; v39.Clean = value; _insuranceDeterminationDate = v39;
                var v40 = _insuranceDeterminationNumber; v40.Clean = value; _insuranceDeterminationNumber = v40;
                var v41 = _insuranceFloodZone; v41.Clean = value; _insuranceFloodZone = v41;
                var v42 = _insuranceMap; v42.Clean = value; _insuranceMap = v42;
                var v43 = _insuranceNoOfBedrooms; v43.Clean = value; _insuranceNoOfBedrooms = v43;
                var v44 = _insurancePremium; v44.Clean = value; _insurancePremium = v44;
                var v45 = _insuranceProjectType; v45.Clean = value; _insuranceProjectType = v45;
                var v46 = _insuranceRenewalDate; v46.Clean = value; _insuranceRenewalDate = v46;
                var v47 = _investorGrade1; v47.Clean = value; _investorGrade1 = v47;
                var v48 = _investorGrade2; v48.Clean = value; _investorGrade2 = v48;
                var v49 = _investorGrade3; v49.Clean = value; _investorGrade3 = v49;
                var v50 = _investorLicense; v50.Clean = value; _investorLicense = v50;
                var v51 = _investorLicenseType; v51.Clean = value; _investorLicenseType = v51;
                var v52 = _investorName1; v52.Clean = value; _investorName1 = v52;
                var v53 = _investorName2; v53.Clean = value; _investorName2 = v53;
                var v54 = _investorName3; v54.Clean = value; _investorName3 = v54;
                var v55 = _investorScore1; v55.Clean = value; _investorScore1 = v55;
                var v56 = _investorScore2; v56.Clean = value; _investorScore2 = v56;
                var v57 = _investorScore3; v57.Clean = value; _investorScore3 = v57;
                var v58 = _lenderType; v58.Clean = value; _lenderType = v58;
                var v59 = _license; v59.Clean = value; _license = v59;
                var v60 = _licenseExempt; v60.Clean = value; _licenseExempt = v60;
                var v61 = _licenseHomeState; v61.Clean = value; _licenseHomeState = v61;
                var v62 = _licenseType; v62.Clean = value; _licenseType = v62;
                var v63 = _lineItemNumber; v63.Clean = value; _lineItemNumber = v63;
                var v64 = _loginId; v64.Clean = value; _loginId = v64;
                var v65 = _name; v65.Clean = value; _name = v65;
                var v66 = _nmlsLicense; v66.Clean = value; _nmlsLicense = v66;
                var v67 = _notNaturalPersonFlag; v67.Clean = value; _notNaturalPersonFlag = v67;
                var v68 = _organizationState; v68.Clean = value; _organizationState = v68;
                var v69 = _organizationType; v69.Clean = value; _organizationType = v69;
                var v70 = _personalLicenseAuthDate; v70.Clean = value; _personalLicenseAuthDate = v70;
                var v71 = _personalLicenseAuthName; v71.Clean = value; _personalLicenseAuthName = v71;
                var v72 = _personalLicenseAuthStateCode; v72.Clean = value; _personalLicenseAuthStateCode = v72;
                var v73 = _personalLicenseAuthType; v73.Clean = value; _personalLicenseAuthType = v73;
                var v74 = _personalLicenseNumber; v74.Clean = value; _personalLicenseNumber = v74;
                var v75 = _phone; v75.Clean = value; _phone = v75;
                var v76 = _phone2; v76.Clean = value; _phone2 = v76;
                var v77 = _postalCode; v77.Clean = value; _postalCode = v77;
                var v78 = _recCity; v78.Clean = value; _recCity = v78;
                var v79 = _referenceNumber; v79.Clean = value; _referenceNumber = v79;
                var v80 = _relationship; v80.Clean = value; _relationship = v80;
                var v81 = _settlementAgent; v81.Clean = value; _settlementAgent = v81;
                var v82 = _state; v82.Clean = value; _state = v82;
                var v83 = _taxID; v83.Clean = value; _taxID = v83;
                var v84 = _tqlCommentHistory; v84.Clean = value; _tqlCommentHistory = v84;
                var v85 = _tQLConsentSelection; v85.Clean = value; _tQLConsentSelection = v85;
                var v86 = _tqlId; v86.Clean = value; _tqlId = v86;
                var v87 = _tqlIsPublishingIndicator; v87.Clean = value; _tqlIsPublishingIndicator = v87;
                var v88 = _tqlName; v88.Clean = value; _tqlName = v88;
                _settingClean = 0;
            }
        }
    }
}