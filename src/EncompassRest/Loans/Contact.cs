using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Contact : IDirty
    {
        private Value<string> _aBA;
        public string ABA { get { return _aBA; } set { _aBA = value; } }
        private Value<string> _accountName;
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _address2;
        public string Address2 { get { return _address2; } set { _address2 = value; } }
        private Value<bool?> _addToCdContactInfo;
        public bool? AddToCdContactInfo { get { return _addToCdContactInfo; } set { _addToCdContactInfo = value; } }
        private Value<string> _appraisalMade;
        public string AppraisalMade { get { return _appraisalMade; } set { _appraisalMade = value; } }
        private Value<DateTime?> _bizLicenseAuthDate;
        public DateTime? BizLicenseAuthDate { get { return _bizLicenseAuthDate; } set { _bizLicenseAuthDate = value; } }
        private Value<string> _bizLicenseAuthName;
        public string BizLicenseAuthName { get { return _bizLicenseAuthName; } set { _bizLicenseAuthName = value; } }
        private Value<string> _bizLicenseAuthStateCode;
        public string BizLicenseAuthStateCode { get { return _bizLicenseAuthStateCode; } set { _bizLicenseAuthStateCode = value; } }
        private Value<string> _bizLicenseAuthType;
        public string BizLicenseAuthType { get { return _bizLicenseAuthType; } set { _bizLicenseAuthType = value; } }
        private Value<string> _bizLicenseNumber;
        public string BizLicenseNumber { get { return _bizLicenseNumber; } set { _bizLicenseNumber = value; } }
        private Value<bool?> _borrowerActingAsContractorIndicator;
        public bool? BorrowerActingAsContractorIndicator { get { return _borrowerActingAsContractorIndicator; } set { _borrowerActingAsContractorIndicator = value; } }
        private Value<string> _brokerLenderType;
        public string BrokerLenderType { get { return _brokerLenderType; } set { _brokerLenderType = value; } }
        private Value<bool?> _brokerLicenseExempt;
        public bool? BrokerLicenseExempt { get { return _brokerLicenseExempt; } set { _brokerLicenseExempt = value; } }
        private Value<string> _brokerLicenseType;
        public string BrokerLicenseType { get { return _brokerLicenseType; } set { _brokerLicenseType = value; } }
        private Value<string> _businessPhone;
        public string BusinessPhone { get { return _businessPhone; } set { _businessPhone = value; } }
        private Value<string> _categoryName;
        public string CategoryName { get { return _categoryName; } set { _categoryName = value; } }
        private Value<string> _cell;
        public string Cell { get { return _cell; } set { _cell = value; } }
        private Value<DateTime?> _checkConfirmedDate;
        public DateTime? CheckConfirmedDate { get { return _checkConfirmedDate; } set { _checkConfirmedDate = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _clause;
        public string Clause { get { return _clause; } set { _clause = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _companyId;
        public string CompanyId { get { return _companyId; } set { _companyId = value; } }
        private Value<decimal?> _completionAffidavitPunchListTotal;
        public decimal? CompletionAffidavitPunchListTotal { get { return _completionAffidavitPunchListTotal; } set { _completionAffidavitPunchListTotal = value; } }
        private Value<int?> _contactIndex;
        public int? ContactIndex { get { return _contactIndex; } set { _contactIndex = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<string> _contactNMLSNo;
        public string ContactNMLSNo { get { return _contactNMLSNo; } set { _contactNMLSNo = value; } }
        private Value<string> _contactTitle;
        public string ContactTitle { get { return _contactTitle; } set { _contactTitle = value; } }
        private Value<string> _contactType;
        public string ContactType { get { return _contactType; } set { _contactType = value; } }
        private Value<DateTime?> _designeeAcceptedDate;
        public DateTime? DesigneeAcceptedDate { get { return _designeeAcceptedDate; } set { _designeeAcceptedDate = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<decimal?> _employerLiabilityInsuranceMin;
        public decimal? EmployerLiabilityInsuranceMin { get { return _employerLiabilityInsuranceMin; } set { _employerLiabilityInsuranceMin = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _fax2;
        public string Fax2 { get { return _fax2; } set { _fax2 = value; } }
        private Value<string> _fhaLenderId;
        public string FhaLenderId { get { return _fhaLenderId; } set { _fhaLenderId = value; } }
        private Value<decimal?> _generalLiabilityInsuranceMin;
        public decimal? GeneralLiabilityInsuranceMin { get { return _generalLiabilityInsuranceMin; } set { _generalLiabilityInsuranceMin = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _insuranceCertNumber;
        public string InsuranceCertNumber { get { return _insuranceCertNumber; } set { _insuranceCertNumber = value; } }
        private Value<decimal?> _insuranceCoverageAmount;
        public decimal? InsuranceCoverageAmount { get { return _insuranceCoverageAmount; } set { _insuranceCoverageAmount = value; } }
        private Value<DateTime?> _insuranceDeterminationDate;
        public DateTime? InsuranceDeterminationDate { get { return _insuranceDeterminationDate; } set { _insuranceDeterminationDate = value; } }
        private Value<string> _insuranceDeterminationNumber;
        public string InsuranceDeterminationNumber { get { return _insuranceDeterminationNumber; } set { _insuranceDeterminationNumber = value; } }
        private Value<bool?> _insuranceFloodZone;
        public bool? InsuranceFloodZone { get { return _insuranceFloodZone; } set { _insuranceFloodZone = value; } }
        private Value<string> _insuranceMap;
        public string InsuranceMap { get { return _insuranceMap; } set { _insuranceMap = value; } }
        private Value<int?> _insuranceNoOfBedrooms;
        public int? InsuranceNoOfBedrooms { get { return _insuranceNoOfBedrooms; } set { _insuranceNoOfBedrooms = value; } }
        private Value<decimal?> _insurancePremium;
        public decimal? InsurancePremium { get { return _insurancePremium; } set { _insurancePremium = value; } }
        private Value<string> _insuranceProjectType;
        public string InsuranceProjectType { get { return _insuranceProjectType; } set { _insuranceProjectType = value; } }
        private Value<DateTime?> _insuranceRenewalDate;
        public DateTime? InsuranceRenewalDate { get { return _insuranceRenewalDate; } set { _insuranceRenewalDate = value; } }
        private Value<string> _investorGrade1;
        public string InvestorGrade1 { get { return _investorGrade1; } set { _investorGrade1 = value; } }
        private Value<string> _investorGrade2;
        public string InvestorGrade2 { get { return _investorGrade2; } set { _investorGrade2 = value; } }
        private Value<string> _investorGrade3;
        public string InvestorGrade3 { get { return _investorGrade3; } set { _investorGrade3 = value; } }
        private Value<string> _investorLicense;
        public string InvestorLicense { get { return _investorLicense; } set { _investorLicense = value; } }
        private Value<string> _investorLicenseType;
        public string InvestorLicenseType { get { return _investorLicenseType; } set { _investorLicenseType = value; } }
        private Value<string> _investorName1;
        public string InvestorName1 { get { return _investorName1; } set { _investorName1 = value; } }
        private Value<string> _investorName2;
        public string InvestorName2 { get { return _investorName2; } set { _investorName2 = value; } }
        private Value<string> _investorName3;
        public string InvestorName3 { get { return _investorName3; } set { _investorName3 = value; } }
        private Value<string> _investorScore1;
        public string InvestorScore1 { get { return _investorScore1; } set { _investorScore1 = value; } }
        private Value<string> _investorScore2;
        public string InvestorScore2 { get { return _investorScore2; } set { _investorScore2 = value; } }
        private Value<string> _investorScore3;
        public string InvestorScore3 { get { return _investorScore3; } set { _investorScore3 = value; } }
        private Value<string> _lenderType;
        public string LenderType { get { return _lenderType; } set { _lenderType = value; } }
        private Value<string> _license;
        public string License { get { return _license; } set { _license = value; } }
        private Value<bool?> _licenseExempt;
        public bool? LicenseExempt { get { return _licenseExempt; } set { _licenseExempt = value; } }
        private Value<string> _licenseHomeState;
        public string LicenseHomeState { get { return _licenseHomeState; } set { _licenseHomeState = value; } }
        private Value<string> _licenseType;
        public string LicenseType { get { return _licenseType; } set { _licenseType = value; } }
        private Value<string> _lineItemNumber;
        public string LineItemNumber { get { return _lineItemNumber; } set { _lineItemNumber = value; } }
        private Value<string> _loginId;
        public string LoginId { get { return _loginId; } set { _loginId = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _nmlsLicense;
        public string NmlsLicense { get { return _nmlsLicense; } set { _nmlsLicense = value; } }
        private Value<bool?> _notNaturalPersonFlag;
        public bool? NotNaturalPersonFlag { get { return _notNaturalPersonFlag; } set { _notNaturalPersonFlag = value; } }
        private Value<string> _organizationState;
        public string OrganizationState { get { return _organizationState; } set { _organizationState = value; } }
        private Value<string> _organizationType;
        public string OrganizationType { get { return _organizationType; } set { _organizationType = value; } }
        private Value<DateTime?> _personalLicenseAuthDate;
        public DateTime? PersonalLicenseAuthDate { get { return _personalLicenseAuthDate; } set { _personalLicenseAuthDate = value; } }
        private Value<string> _personalLicenseAuthName;
        public string PersonalLicenseAuthName { get { return _personalLicenseAuthName; } set { _personalLicenseAuthName = value; } }
        private Value<string> _personalLicenseAuthStateCode;
        public string PersonalLicenseAuthStateCode { get { return _personalLicenseAuthStateCode; } set { _personalLicenseAuthStateCode = value; } }
        private Value<string> _personalLicenseAuthType;
        public string PersonalLicenseAuthType { get { return _personalLicenseAuthType; } set { _personalLicenseAuthType = value; } }
        private Value<string> _personalLicenseNumber;
        public string PersonalLicenseNumber { get { return _personalLicenseNumber; } set { _personalLicenseNumber = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _phone2;
        public string Phone2 { get { return _phone2; } set { _phone2 = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _recCity;
        public string RecCity { get { return _recCity; } set { _recCity = value; } }
        private Value<string> _referenceNumber;
        public string ReferenceNumber { get { return _referenceNumber; } set { _referenceNumber = value; } }
        private Value<string> _relationship;
        public string Relationship { get { return _relationship; } set { _relationship = value; } }
        private Value<bool?> _settlementAgent;
        public bool? SettlementAgent { get { return _settlementAgent; } set { _settlementAgent = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _taxID;
        public string TaxID { get { return _taxID; } set { _taxID = value; } }
        private Value<string> _tqlCommentHistory;
        public string TqlCommentHistory { get { return _tqlCommentHistory; } set { _tqlCommentHistory = value; } }
        private Value<string> _tQLConsentSelection;
        public string TQLConsentSelection { get { return _tQLConsentSelection; } set { _tQLConsentSelection = value; } }
        private Value<int?> _tqlId;
        public int? TqlId { get { return _tqlId; } set { _tqlId = value; } }
        private Value<bool?> _tqlIsPublishingIndicator;
        public bool? TqlIsPublishingIndicator { get { return _tqlIsPublishingIndicator; } set { _tqlIsPublishingIndicator = value; } }
        private Value<string> _tqlName;
        public string TqlName { get { return _tqlName; } set { _tqlName = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _aBA.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}