#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Contact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aBA;
        public string ABA { get => _aBA; set => _aBA = value; }
        private DirtyValue<string> _accountName;
        public string AccountName { get => _accountName; set => _accountName = value; }
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _address2;
        public string Address2 { get => _address2; set => _address2 = value; }
        private DirtyValue<bool?> _addToCdContactInfo;
        public bool? AddToCdContactInfo { get => _addToCdContactInfo; set => _addToCdContactInfo = value; }
        private DirtyValue<StringEnumValue<AppraisalMade>> _appraisalMade;
        public StringEnumValue<AppraisalMade> AppraisalMade { get => _appraisalMade; set => _appraisalMade = value; }
        private DirtyValue<DateTime?> _bizLicenseAuthDate;
        public DateTime? BizLicenseAuthDate { get => _bizLicenseAuthDate; set => _bizLicenseAuthDate = value; }
        private DirtyValue<string> _bizLicenseAuthName;
        public string BizLicenseAuthName { get => _bizLicenseAuthName; set => _bizLicenseAuthName = value; }
        private DirtyValue<string> _bizLicenseAuthStateCode;
        public string BizLicenseAuthStateCode { get => _bizLicenseAuthStateCode; set => _bizLicenseAuthStateCode = value; }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _bizLicenseAuthType;
        public StringEnumValue<LicenseAuthType> BizLicenseAuthType { get => _bizLicenseAuthType; set => _bizLicenseAuthType = value; }
        private DirtyValue<string> _bizLicenseNumber;
        public string BizLicenseNumber { get => _bizLicenseNumber; set => _bizLicenseNumber = value; }
        private DirtyValue<bool?> _borrowerActingAsContractorIndicator;
        public bool? BorrowerActingAsContractorIndicator { get => _borrowerActingAsContractorIndicator; set => _borrowerActingAsContractorIndicator = value; }
        private DirtyValue<string> _brokerLenderType;
        public string BrokerLenderType { get => _brokerLenderType; set => _brokerLenderType = value; }
        private DirtyValue<bool?> _brokerLicenseExempt;
        public bool? BrokerLicenseExempt { get => _brokerLicenseExempt; set => _brokerLicenseExempt = value; }
        private DirtyValue<string> _brokerLicenseType;
        public string BrokerLicenseType { get => _brokerLicenseType; set => _brokerLicenseType = value; }
        private DirtyValue<string> _businessPhone;
        public string BusinessPhone { get => _businessPhone; set => _businessPhone = value; }
        private DirtyValue<string> _categoryName;
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        private DirtyValue<string> _cell;
        public string Cell { get => _cell; set => _cell = value; }
        private DirtyValue<DateTime?> _checkConfirmedDate;
        public DateTime? CheckConfirmedDate { get => _checkConfirmedDate; set => _checkConfirmedDate = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _clause;
        public string Clause { get => _clause; set => _clause = value; }
        private DirtyValue<string> _closingAgentWebURL;
        public string ClosingAgentWebURL { get => _closingAgentWebURL; set => _closingAgentWebURL = value; }
        private DirtyValue<string> _closingCompanyWebURL;
        public string ClosingCompanyWebURL { get => _closingCompanyWebURL; set => _closingCompanyWebURL = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _companyId;
        public string CompanyId { get => _companyId; set => _companyId = value; }
        private DirtyValue<decimal?> _completionAffidavitPunchListTotal;
        public decimal? CompletionAffidavitPunchListTotal { get => _completionAffidavitPunchListTotal; set => _completionAffidavitPunchListTotal = value; }
        private DirtyValue<int?> _contactIndex;
        public int? ContactIndex { get => _contactIndex; set => _contactIndex = value; }
        private DirtyValue<string> _contactName;
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _contactNMLSNo;
        public string ContactNMLSNo { get => _contactNMLSNo; set => _contactNMLSNo = value; }
        private DirtyValue<string> _contactTitle;
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        private DirtyValue<StringEnumValue<ContactType>> _contactType;
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => _contactType = value; }
        private DirtyValue<DateTime?> _designeeAcceptedDate;
        public DateTime? DesigneeAcceptedDate { get => _designeeAcceptedDate; set => _designeeAcceptedDate = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<decimal?> _employerLiabilityInsuranceMin;
        public decimal? EmployerLiabilityInsuranceMin { get => _employerLiabilityInsuranceMin; set => _employerLiabilityInsuranceMin = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _fax2;
        public string Fax2 { get => _fax2; set => _fax2 = value; }
        private DirtyValue<string> _fhaLenderId;
        public string FhaLenderId { get => _fhaLenderId; set => _fhaLenderId = value; }
        private DirtyValue<decimal?> _generalLiabilityInsuranceMin;
        public decimal? GeneralLiabilityInsuranceMin { get => _generalLiabilityInsuranceMin; set => _generalLiabilityInsuranceMin = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _insuranceCertNumber;
        public string InsuranceCertNumber { get => _insuranceCertNumber; set => _insuranceCertNumber = value; }
        private DirtyValue<decimal?> _insuranceCoverageAmount;
        public decimal? InsuranceCoverageAmount { get => _insuranceCoverageAmount; set => _insuranceCoverageAmount = value; }
        private DirtyValue<DateTime?> _insuranceDeterminationDate;
        public DateTime? InsuranceDeterminationDate { get => _insuranceDeterminationDate; set => _insuranceDeterminationDate = value; }
        private DirtyValue<string> _insuranceDeterminationNumber;
        public string InsuranceDeterminationNumber { get => _insuranceDeterminationNumber; set => _insuranceDeterminationNumber = value; }
        private DirtyValue<bool?> _insuranceFloodZone;
        public bool? InsuranceFloodZone { get => _insuranceFloodZone; set => _insuranceFloodZone = value; }
        private DirtyValue<string> _insuranceMap;
        public string InsuranceMap { get => _insuranceMap; set => _insuranceMap = value; }
        private DirtyValue<int?> _insuranceNoOfBedrooms;
        public int? InsuranceNoOfBedrooms { get => _insuranceNoOfBedrooms; set => _insuranceNoOfBedrooms = value; }
        private DirtyValue<decimal?> _insurancePremium;
        public decimal? InsurancePremium { get => _insurancePremium; set => _insurancePremium = value; }
        private DirtyValue<StringEnumValue<ProjectType>> _insuranceProjectType;
        public StringEnumValue<ProjectType> InsuranceProjectType { get => _insuranceProjectType; set => _insuranceProjectType = value; }
        private DirtyValue<DateTime?> _insuranceRenewalDate;
        public DateTime? InsuranceRenewalDate { get => _insuranceRenewalDate; set => _insuranceRenewalDate = value; }
        private DirtyValue<string> _investorGrade1;
        public string InvestorGrade1 { get => _investorGrade1; set => _investorGrade1 = value; }
        private DirtyValue<string> _investorGrade2;
        public string InvestorGrade2 { get => _investorGrade2; set => _investorGrade2 = value; }
        private DirtyValue<string> _investorGrade3;
        public string InvestorGrade3 { get => _investorGrade3; set => _investorGrade3 = value; }
        private DirtyValue<string> _investorLicense;
        public string InvestorLicense { get => _investorLicense; set => _investorLicense = value; }
        private DirtyValue<string> _investorLicenseType;
        public string InvestorLicenseType { get => _investorLicenseType; set => _investorLicenseType = value; }
        private DirtyValue<string> _investorName1;
        public string InvestorName1 { get => _investorName1; set => _investorName1 = value; }
        private DirtyValue<string> _investorName2;
        public string InvestorName2 { get => _investorName2; set => _investorName2 = value; }
        private DirtyValue<string> _investorName3;
        public string InvestorName3 { get => _investorName3; set => _investorName3 = value; }
        private DirtyValue<string> _investorScore1;
        public string InvestorScore1 { get => _investorScore1; set => _investorScore1 = value; }
        private DirtyValue<string> _investorScore2;
        public string InvestorScore2 { get => _investorScore2; set => _investorScore2 = value; }
        private DirtyValue<string> _investorScore3;
        public string InvestorScore3 { get => _investorScore3; set => _investorScore3 = value; }
        private DirtyValue<string> _lenderType;
        public string LenderType { get => _lenderType; set => _lenderType = value; }
        private DirtyValue<string> _license;
        public string License { get => _license; set => _license = value; }
        private DirtyValue<bool?> _licenseExempt;
        public bool? LicenseExempt { get => _licenseExempt; set => _licenseExempt = value; }
        private DirtyValue<string> _licenseHomeState;
        public string LicenseHomeState { get => _licenseHomeState; set => _licenseHomeState = value; }
        private DirtyValue<string> _licenseType;
        public string LicenseType { get => _licenseType; set => _licenseType = value; }
        private DirtyValue<string> _lineItemNumber;
        public string LineItemNumber { get => _lineItemNumber; set => _lineItemNumber = value; }
        private DirtyValue<string> _loginId;
        public string LoginId { get => _loginId; set => _loginId = value; }
        private DirtyValue<string> _mortgageBrokerCompanyWebURL;
        public string MortgageBrokerCompanyWebURL { get => _mortgageBrokerCompanyWebURL; set => _mortgageBrokerCompanyWebURL = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficerWebURL;
        public string MortgageBrokerLoanOfficerWebURL { get => _mortgageBrokerLoanOfficerWebURL; set => _mortgageBrokerLoanOfficerWebURL = value; }
        private DirtyValue<string> _mortgageLenderCompanyWebURL;
        public string MortgageLenderCompanyWebURL { get => _mortgageLenderCompanyWebURL; set => _mortgageLenderCompanyWebURL = value; }
        private DirtyValue<string> _mortgageLenderLoanOfficerWebURL;
        public string MortgageLenderLoanOfficerWebURL { get => _mortgageLenderLoanOfficerWebURL; set => _mortgageLenderLoanOfficerWebURL = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _nmlsLicense;
        public string NmlsLicense { get => _nmlsLicense; set => _nmlsLicense = value; }
        private DirtyValue<bool?> _notNaturalPersonFlag;
        public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => _notNaturalPersonFlag = value; }
        private DirtyValue<string> _organizationState;
        public string OrganizationState { get => _organizationState; set => _organizationState = value; }
        private DirtyValue<string> _organizationType;
        public string OrganizationType { get => _organizationType; set => _organizationType = value; }
        private DirtyValue<DateTime?> _personalLicenseAuthDate;
        public DateTime? PersonalLicenseAuthDate { get => _personalLicenseAuthDate; set => _personalLicenseAuthDate = value; }
        private DirtyValue<string> _personalLicenseAuthName;
        public string PersonalLicenseAuthName { get => _personalLicenseAuthName; set => _personalLicenseAuthName = value; }
        private DirtyValue<string> _personalLicenseAuthStateCode;
        public string PersonalLicenseAuthStateCode { get => _personalLicenseAuthStateCode; set => _personalLicenseAuthStateCode = value; }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _personalLicenseAuthType;
        public StringEnumValue<LicenseAuthType> PersonalLicenseAuthType { get => _personalLicenseAuthType; set => _personalLicenseAuthType = value; }
        private DirtyValue<string> _personalLicenseNumber;
        public string PersonalLicenseNumber { get => _personalLicenseNumber; set => _personalLicenseNumber = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _phone2;
        public string Phone2 { get => _phone2; set => _phone2 = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _realEstateAgencyWebURL;
        public string RealEstateAgencyWebURL { get => _realEstateAgencyWebURL; set => _realEstateAgencyWebURL = value; }
        private DirtyValue<string> _realEstateAgentWebURL;
        public string RealEstateAgentWebURL { get => _realEstateAgentWebURL; set => _realEstateAgentWebURL = value; }
        private DirtyValue<string> _recCity;
        public string RecCity { get => _recCity; set => _recCity = value; }
        private DirtyValue<string> _referenceNumber;
        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        private DirtyValue<string> _relationship;
        public string Relationship { get => _relationship; set => _relationship = value; }
        private DirtyValue<bool?> _settlementAgent;
        public bool? SettlementAgent { get => _settlementAgent; set => _settlementAgent = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _taxID;
        public string TaxID { get => _taxID; set => _taxID = value; }
        private DirtyValue<string> _tqlCommentHistory;
        public string TqlCommentHistory { get => _tqlCommentHistory; set => _tqlCommentHistory = value; }
        private DirtyValue<string> _tQLConsentSelection;
        public string TQLConsentSelection { get => _tQLConsentSelection; set => _tQLConsentSelection = value; }
        private DirtyValue<int?> _tqlId;
        public int? TqlId { get => _tqlId; set => _tqlId = value; }
        private DirtyValue<bool?> _tqlIsPublishingIndicator;
        public bool? TqlIsPublishingIndicator { get => _tqlIsPublishingIndicator; set => _tqlIsPublishingIndicator = value; }
        private DirtyValue<string> _tqlName;
        public string TqlName { get => _tqlName; set => _tqlName = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aBA.Dirty
                    || _accountName.Dirty
                    || _address.Dirty
                    || _address2.Dirty
                    || _addToCdContactInfo.Dirty
                    || _appraisalMade.Dirty
                    || _bizLicenseAuthDate.Dirty
                    || _bizLicenseAuthName.Dirty
                    || _bizLicenseAuthStateCode.Dirty
                    || _bizLicenseAuthType.Dirty
                    || _bizLicenseNumber.Dirty
                    || _borrowerActingAsContractorIndicator.Dirty
                    || _brokerLenderType.Dirty
                    || _brokerLicenseExempt.Dirty
                    || _brokerLicenseType.Dirty
                    || _businessPhone.Dirty
                    || _categoryName.Dirty
                    || _cell.Dirty
                    || _checkConfirmedDate.Dirty
                    || _city.Dirty
                    || _clause.Dirty
                    || _closingAgentWebURL.Dirty
                    || _closingCompanyWebURL.Dirty
                    || _comments.Dirty
                    || _companyId.Dirty
                    || _completionAffidavitPunchListTotal.Dirty
                    || _contactIndex.Dirty
                    || _contactName.Dirty
                    || _contactNMLSNo.Dirty
                    || _contactTitle.Dirty
                    || _contactType.Dirty
                    || _designeeAcceptedDate.Dirty
                    || _email.Dirty
                    || _employerLiabilityInsuranceMin.Dirty
                    || _fax.Dirty
                    || _fax2.Dirty
                    || _fhaLenderId.Dirty
                    || _generalLiabilityInsuranceMin.Dirty
                    || _id.Dirty
                    || _insuranceCertNumber.Dirty
                    || _insuranceCoverageAmount.Dirty
                    || _insuranceDeterminationDate.Dirty
                    || _insuranceDeterminationNumber.Dirty
                    || _insuranceFloodZone.Dirty
                    || _insuranceMap.Dirty
                    || _insuranceNoOfBedrooms.Dirty
                    || _insurancePremium.Dirty
                    || _insuranceProjectType.Dirty
                    || _insuranceRenewalDate.Dirty
                    || _investorGrade1.Dirty
                    || _investorGrade2.Dirty
                    || _investorGrade3.Dirty
                    || _investorLicense.Dirty
                    || _investorLicenseType.Dirty
                    || _investorName1.Dirty
                    || _investorName2.Dirty
                    || _investorName3.Dirty
                    || _investorScore1.Dirty
                    || _investorScore2.Dirty
                    || _investorScore3.Dirty
                    || _lenderType.Dirty
                    || _license.Dirty
                    || _licenseExempt.Dirty
                    || _licenseHomeState.Dirty
                    || _licenseType.Dirty
                    || _lineItemNumber.Dirty
                    || _loginId.Dirty
                    || _mortgageBrokerCompanyWebURL.Dirty
                    || _mortgageBrokerLoanOfficerWebURL.Dirty
                    || _mortgageLenderCompanyWebURL.Dirty
                    || _mortgageLenderLoanOfficerWebURL.Dirty
                    || _name.Dirty
                    || _nmlsLicense.Dirty
                    || _notNaturalPersonFlag.Dirty
                    || _organizationState.Dirty
                    || _organizationType.Dirty
                    || _personalLicenseAuthDate.Dirty
                    || _personalLicenseAuthName.Dirty
                    || _personalLicenseAuthStateCode.Dirty
                    || _personalLicenseAuthType.Dirty
                    || _personalLicenseNumber.Dirty
                    || _phone.Dirty
                    || _phone2.Dirty
                    || _postalCode.Dirty
                    || _realEstateAgencyWebURL.Dirty
                    || _realEstateAgentWebURL.Dirty
                    || _recCity.Dirty
                    || _referenceNumber.Dirty
                    || _relationship.Dirty
                    || _settlementAgent.Dirty
                    || _state.Dirty
                    || _taxID.Dirty
                    || _tqlCommentHistory.Dirty
                    || _tQLConsentSelection.Dirty
                    || _tqlId.Dirty
                    || _tqlIsPublishingIndicator.Dirty
                    || _tqlName.Dirty;
            }
            set
            {
                _aBA.Dirty = value;
                _accountName.Dirty = value;
                _address.Dirty = value;
                _address2.Dirty = value;
                _addToCdContactInfo.Dirty = value;
                _appraisalMade.Dirty = value;
                _bizLicenseAuthDate.Dirty = value;
                _bizLicenseAuthName.Dirty = value;
                _bizLicenseAuthStateCode.Dirty = value;
                _bizLicenseAuthType.Dirty = value;
                _bizLicenseNumber.Dirty = value;
                _borrowerActingAsContractorIndicator.Dirty = value;
                _brokerLenderType.Dirty = value;
                _brokerLicenseExempt.Dirty = value;
                _brokerLicenseType.Dirty = value;
                _businessPhone.Dirty = value;
                _categoryName.Dirty = value;
                _cell.Dirty = value;
                _checkConfirmedDate.Dirty = value;
                _city.Dirty = value;
                _clause.Dirty = value;
                _closingAgentWebURL.Dirty = value;
                _closingCompanyWebURL.Dirty = value;
                _comments.Dirty = value;
                _companyId.Dirty = value;
                _completionAffidavitPunchListTotal.Dirty = value;
                _contactIndex.Dirty = value;
                _contactName.Dirty = value;
                _contactNMLSNo.Dirty = value;
                _contactTitle.Dirty = value;
                _contactType.Dirty = value;
                _designeeAcceptedDate.Dirty = value;
                _email.Dirty = value;
                _employerLiabilityInsuranceMin.Dirty = value;
                _fax.Dirty = value;
                _fax2.Dirty = value;
                _fhaLenderId.Dirty = value;
                _generalLiabilityInsuranceMin.Dirty = value;
                _id.Dirty = value;
                _insuranceCertNumber.Dirty = value;
                _insuranceCoverageAmount.Dirty = value;
                _insuranceDeterminationDate.Dirty = value;
                _insuranceDeterminationNumber.Dirty = value;
                _insuranceFloodZone.Dirty = value;
                _insuranceMap.Dirty = value;
                _insuranceNoOfBedrooms.Dirty = value;
                _insurancePremium.Dirty = value;
                _insuranceProjectType.Dirty = value;
                _insuranceRenewalDate.Dirty = value;
                _investorGrade1.Dirty = value;
                _investorGrade2.Dirty = value;
                _investorGrade3.Dirty = value;
                _investorLicense.Dirty = value;
                _investorLicenseType.Dirty = value;
                _investorName1.Dirty = value;
                _investorName2.Dirty = value;
                _investorName3.Dirty = value;
                _investorScore1.Dirty = value;
                _investorScore2.Dirty = value;
                _investorScore3.Dirty = value;
                _lenderType.Dirty = value;
                _license.Dirty = value;
                _licenseExempt.Dirty = value;
                _licenseHomeState.Dirty = value;
                _licenseType.Dirty = value;
                _lineItemNumber.Dirty = value;
                _loginId.Dirty = value;
                _mortgageBrokerCompanyWebURL.Dirty = value;
                _mortgageBrokerLoanOfficerWebURL.Dirty = value;
                _mortgageLenderCompanyWebURL.Dirty = value;
                _mortgageLenderLoanOfficerWebURL.Dirty = value;
                _name.Dirty = value;
                _nmlsLicense.Dirty = value;
                _notNaturalPersonFlag.Dirty = value;
                _organizationState.Dirty = value;
                _organizationType.Dirty = value;
                _personalLicenseAuthDate.Dirty = value;
                _personalLicenseAuthName.Dirty = value;
                _personalLicenseAuthStateCode.Dirty = value;
                _personalLicenseAuthType.Dirty = value;
                _personalLicenseNumber.Dirty = value;
                _phone.Dirty = value;
                _phone2.Dirty = value;
                _postalCode.Dirty = value;
                _realEstateAgencyWebURL.Dirty = value;
                _realEstateAgentWebURL.Dirty = value;
                _recCity.Dirty = value;
                _referenceNumber.Dirty = value;
                _relationship.Dirty = value;
                _settlementAgent.Dirty = value;
                _state.Dirty = value;
                _taxID.Dirty = value;
                _tqlCommentHistory.Dirty = value;
                _tQLConsentSelection.Dirty = value;
                _tqlId.Dirty = value;
                _tqlIsPublishingIndicator.Dirty = value;
                _tqlName.Dirty = value;
            }
        }
    }
}