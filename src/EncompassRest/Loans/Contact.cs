using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Contact : IClean
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
                var aBA = _aBA; aBA.Clean = value; _aBA = aBA;
                var accountName = _accountName; accountName.Clean = value; _accountName = accountName;
                var address = _address; address.Clean = value; _address = address;
                var address2 = _address2; address2.Clean = value; _address2 = address2;
                var addToCdContactInfo = _addToCdContactInfo; addToCdContactInfo.Clean = value; _addToCdContactInfo = addToCdContactInfo;
                var appraisalMade = _appraisalMade; appraisalMade.Clean = value; _appraisalMade = appraisalMade;
                var bizLicenseAuthDate = _bizLicenseAuthDate; bizLicenseAuthDate.Clean = value; _bizLicenseAuthDate = bizLicenseAuthDate;
                var bizLicenseAuthName = _bizLicenseAuthName; bizLicenseAuthName.Clean = value; _bizLicenseAuthName = bizLicenseAuthName;
                var bizLicenseAuthStateCode = _bizLicenseAuthStateCode; bizLicenseAuthStateCode.Clean = value; _bizLicenseAuthStateCode = bizLicenseAuthStateCode;
                var bizLicenseAuthType = _bizLicenseAuthType; bizLicenseAuthType.Clean = value; _bizLicenseAuthType = bizLicenseAuthType;
                var bizLicenseNumber = _bizLicenseNumber; bizLicenseNumber.Clean = value; _bizLicenseNumber = bizLicenseNumber;
                var borrowerActingAsContractorIndicator = _borrowerActingAsContractorIndicator; borrowerActingAsContractorIndicator.Clean = value; _borrowerActingAsContractorIndicator = borrowerActingAsContractorIndicator;
                var brokerLenderType = _brokerLenderType; brokerLenderType.Clean = value; _brokerLenderType = brokerLenderType;
                var brokerLicenseExempt = _brokerLicenseExempt; brokerLicenseExempt.Clean = value; _brokerLicenseExempt = brokerLicenseExempt;
                var brokerLicenseType = _brokerLicenseType; brokerLicenseType.Clean = value; _brokerLicenseType = brokerLicenseType;
                var businessPhone = _businessPhone; businessPhone.Clean = value; _businessPhone = businessPhone;
                var categoryName = _categoryName; categoryName.Clean = value; _categoryName = categoryName;
                var cell = _cell; cell.Clean = value; _cell = cell;
                var checkConfirmedDate = _checkConfirmedDate; checkConfirmedDate.Clean = value; _checkConfirmedDate = checkConfirmedDate;
                var city = _city; city.Clean = value; _city = city;
                var clause = _clause; clause.Clean = value; _clause = clause;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var companyId = _companyId; companyId.Clean = value; _companyId = companyId;
                var completionAffidavitPunchListTotal = _completionAffidavitPunchListTotal; completionAffidavitPunchListTotal.Clean = value; _completionAffidavitPunchListTotal = completionAffidavitPunchListTotal;
                var contactIndex = _contactIndex; contactIndex.Clean = value; _contactIndex = contactIndex;
                var contactName = _contactName; contactName.Clean = value; _contactName = contactName;
                var contactNMLSNo = _contactNMLSNo; contactNMLSNo.Clean = value; _contactNMLSNo = contactNMLSNo;
                var contactTitle = _contactTitle; contactTitle.Clean = value; _contactTitle = contactTitle;
                var contactType = _contactType; contactType.Clean = value; _contactType = contactType;
                var designeeAcceptedDate = _designeeAcceptedDate; designeeAcceptedDate.Clean = value; _designeeAcceptedDate = designeeAcceptedDate;
                var email = _email; email.Clean = value; _email = email;
                var employerLiabilityInsuranceMin = _employerLiabilityInsuranceMin; employerLiabilityInsuranceMin.Clean = value; _employerLiabilityInsuranceMin = employerLiabilityInsuranceMin;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var fax2 = _fax2; fax2.Clean = value; _fax2 = fax2;
                var fhaLenderId = _fhaLenderId; fhaLenderId.Clean = value; _fhaLenderId = fhaLenderId;
                var generalLiabilityInsuranceMin = _generalLiabilityInsuranceMin; generalLiabilityInsuranceMin.Clean = value; _generalLiabilityInsuranceMin = generalLiabilityInsuranceMin;
                var id = _id; id.Clean = value; _id = id;
                var insuranceCertNumber = _insuranceCertNumber; insuranceCertNumber.Clean = value; _insuranceCertNumber = insuranceCertNumber;
                var insuranceCoverageAmount = _insuranceCoverageAmount; insuranceCoverageAmount.Clean = value; _insuranceCoverageAmount = insuranceCoverageAmount;
                var insuranceDeterminationDate = _insuranceDeterminationDate; insuranceDeterminationDate.Clean = value; _insuranceDeterminationDate = insuranceDeterminationDate;
                var insuranceDeterminationNumber = _insuranceDeterminationNumber; insuranceDeterminationNumber.Clean = value; _insuranceDeterminationNumber = insuranceDeterminationNumber;
                var insuranceFloodZone = _insuranceFloodZone; insuranceFloodZone.Clean = value; _insuranceFloodZone = insuranceFloodZone;
                var insuranceMap = _insuranceMap; insuranceMap.Clean = value; _insuranceMap = insuranceMap;
                var insuranceNoOfBedrooms = _insuranceNoOfBedrooms; insuranceNoOfBedrooms.Clean = value; _insuranceNoOfBedrooms = insuranceNoOfBedrooms;
                var insurancePremium = _insurancePremium; insurancePremium.Clean = value; _insurancePremium = insurancePremium;
                var insuranceProjectType = _insuranceProjectType; insuranceProjectType.Clean = value; _insuranceProjectType = insuranceProjectType;
                var insuranceRenewalDate = _insuranceRenewalDate; insuranceRenewalDate.Clean = value; _insuranceRenewalDate = insuranceRenewalDate;
                var investorGrade1 = _investorGrade1; investorGrade1.Clean = value; _investorGrade1 = investorGrade1;
                var investorGrade2 = _investorGrade2; investorGrade2.Clean = value; _investorGrade2 = investorGrade2;
                var investorGrade3 = _investorGrade3; investorGrade3.Clean = value; _investorGrade3 = investorGrade3;
                var investorLicense = _investorLicense; investorLicense.Clean = value; _investorLicense = investorLicense;
                var investorLicenseType = _investorLicenseType; investorLicenseType.Clean = value; _investorLicenseType = investorLicenseType;
                var investorName1 = _investorName1; investorName1.Clean = value; _investorName1 = investorName1;
                var investorName2 = _investorName2; investorName2.Clean = value; _investorName2 = investorName2;
                var investorName3 = _investorName3; investorName3.Clean = value; _investorName3 = investorName3;
                var investorScore1 = _investorScore1; investorScore1.Clean = value; _investorScore1 = investorScore1;
                var investorScore2 = _investorScore2; investorScore2.Clean = value; _investorScore2 = investorScore2;
                var investorScore3 = _investorScore3; investorScore3.Clean = value; _investorScore3 = investorScore3;
                var lenderType = _lenderType; lenderType.Clean = value; _lenderType = lenderType;
                var license = _license; license.Clean = value; _license = license;
                var licenseExempt = _licenseExempt; licenseExempt.Clean = value; _licenseExempt = licenseExempt;
                var licenseHomeState = _licenseHomeState; licenseHomeState.Clean = value; _licenseHomeState = licenseHomeState;
                var licenseType = _licenseType; licenseType.Clean = value; _licenseType = licenseType;
                var lineItemNumber = _lineItemNumber; lineItemNumber.Clean = value; _lineItemNumber = lineItemNumber;
                var loginId = _loginId; loginId.Clean = value; _loginId = loginId;
                var name = _name; name.Clean = value; _name = name;
                var nmlsLicense = _nmlsLicense; nmlsLicense.Clean = value; _nmlsLicense = nmlsLicense;
                var notNaturalPersonFlag = _notNaturalPersonFlag; notNaturalPersonFlag.Clean = value; _notNaturalPersonFlag = notNaturalPersonFlag;
                var organizationState = _organizationState; organizationState.Clean = value; _organizationState = organizationState;
                var organizationType = _organizationType; organizationType.Clean = value; _organizationType = organizationType;
                var personalLicenseAuthDate = _personalLicenseAuthDate; personalLicenseAuthDate.Clean = value; _personalLicenseAuthDate = personalLicenseAuthDate;
                var personalLicenseAuthName = _personalLicenseAuthName; personalLicenseAuthName.Clean = value; _personalLicenseAuthName = personalLicenseAuthName;
                var personalLicenseAuthStateCode = _personalLicenseAuthStateCode; personalLicenseAuthStateCode.Clean = value; _personalLicenseAuthStateCode = personalLicenseAuthStateCode;
                var personalLicenseAuthType = _personalLicenseAuthType; personalLicenseAuthType.Clean = value; _personalLicenseAuthType = personalLicenseAuthType;
                var personalLicenseNumber = _personalLicenseNumber; personalLicenseNumber.Clean = value; _personalLicenseNumber = personalLicenseNumber;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var phone2 = _phone2; phone2.Clean = value; _phone2 = phone2;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var recCity = _recCity; recCity.Clean = value; _recCity = recCity;
                var referenceNumber = _referenceNumber; referenceNumber.Clean = value; _referenceNumber = referenceNumber;
                var relationship = _relationship; relationship.Clean = value; _relationship = relationship;
                var settlementAgent = _settlementAgent; settlementAgent.Clean = value; _settlementAgent = settlementAgent;
                var state = _state; state.Clean = value; _state = state;
                var taxID = _taxID; taxID.Clean = value; _taxID = taxID;
                var tqlCommentHistory = _tqlCommentHistory; tqlCommentHistory.Clean = value; _tqlCommentHistory = tqlCommentHistory;
                var tQLConsentSelection = _tQLConsentSelection; tQLConsentSelection.Clean = value; _tQLConsentSelection = tQLConsentSelection;
                var tqlId = _tqlId; tqlId.Clean = value; _tqlId = tqlId;
                var tqlIsPublishingIndicator = _tqlIsPublishingIndicator; tqlIsPublishingIndicator.Clean = value; _tqlIsPublishingIndicator = tqlIsPublishingIndicator;
                var tqlName = _tqlName; tqlName.Clean = value; _tqlName = tqlName;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Contact()
        {
            Clean = true;
        }
    }
}