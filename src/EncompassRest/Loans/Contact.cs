using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Contact
    /// </summary>
    public sealed partial class Contact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aBA;
        /// <summary>
        /// Contact ABA
        /// </summary>
        public string ABA { get => _aBA; set => _aBA = value; }
        private DirtyValue<string> _accountName;
        /// <summary>
        /// Contact AccountName
        /// </summary>
        public string AccountName { get => _accountName; set => _accountName = value; }
        private DirtyValue<string> _address;
        /// <summary>
        /// Contact Address
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _address2;
        /// <summary>
        /// File Contacts Broker Lender Address 2 [1954]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "File Contacts Broker Lender Address 2")]
        public string Address2 { get => _address2; set => _address2 = value; }
        private DirtyValue<bool?> _addToCdContactInfo;
        /// <summary>
        /// Contact AddToCdContactInfo
        /// </summary>
        public bool? AddToCdContactInfo { get => _addToCdContactInfo; set => _addToCdContactInfo = value; }
        private DirtyValue<StringEnumValue<AppraisalMade>> _appraisalMade;
        /// <summary>
        /// File Contacts Appraisal Co Appraisal Made (As Is or As Improved) [4091]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Appraisal Co Appraisal Made (As Is or As Improved)")]
        public StringEnumValue<AppraisalMade> AppraisalMade { get => _appraisalMade; set => _appraisalMade = value; }
        private DirtyValue<DateTime?> _bizLicenseAuthDate;
        /// <summary>
        /// Contact BizLicenseAuthDate
        /// </summary>
        public DateTime? BizLicenseAuthDate { get => _bizLicenseAuthDate; set => _bizLicenseAuthDate = value; }
        private DirtyValue<string> _bizLicenseAuthName;
        /// <summary>
        /// Contact BizLicenseAuthName
        /// </summary>
        public string BizLicenseAuthName { get => _bizLicenseAuthName; set => _bizLicenseAuthName = value; }
        private DirtyValue<StringEnumValue<State>> _bizLicenseAuthStateCode;
        /// <summary>
        /// Contact BizLicenseAuthStateCode
        /// </summary>
        public StringEnumValue<State> BizLicenseAuthStateCode { get => _bizLicenseAuthStateCode; set => _bizLicenseAuthStateCode = value; }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _bizLicenseAuthType;
        /// <summary>
        /// Contact BizLicenseAuthType
        /// </summary>
        public StringEnumValue<LicenseAuthType> BizLicenseAuthType { get => _bizLicenseAuthType; set => _bizLicenseAuthType = value; }
        private DirtyValue<string> _bizLicenseNumber;
        /// <summary>
        /// Contact BizLicenseNumber
        /// </summary>
        public string BizLicenseNumber { get => _bizLicenseNumber; set => _bizLicenseNumber = value; }
        private DirtyValue<bool?> _borrowerActingAsContractorIndicator;
        /// <summary>
        /// File Contacts General Contractor BorrowerActingAsContractorIndicator [VEND.X1009]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts General Contractor BorrowerActingAsContractorIndicator")]
        public bool? BorrowerActingAsContractorIndicator { get => _borrowerActingAsContractorIndicator; set => _borrowerActingAsContractorIndicator = value; }
        private DirtyValue<string> _brokerLenderType;
        /// <summary>
        /// Contact BrokerLenderType
        /// </summary>
        public string BrokerLenderType { get => _brokerLenderType; set => _brokerLenderType = value; }
        private DirtyValue<bool?> _brokerLicenseExempt;
        /// <summary>
        /// Contact BrokerLicenseExempt
        /// </summary>
        public bool? BrokerLicenseExempt { get => _brokerLicenseExempt; set => _brokerLicenseExempt = value; }
        private DirtyValue<string> _brokerLicenseType;
        /// <summary>
        /// Contact BrokerLicenseType
        /// </summary>
        public string BrokerLicenseType { get => _brokerLicenseType; set => _brokerLicenseType = value; }
        private DirtyValue<string> _businessPhone;
        /// <summary>
        /// Contact BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string BusinessPhone { get => _businessPhone; set => _businessPhone = value; }
        private DirtyValue<string> _categoryName;
        /// <summary>
        /// Contact CategoryName
        /// </summary>
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        private DirtyValue<string> _cell;
        /// <summary>
        /// Contact Cell
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Cell { get => _cell; set => _cell = value; }
        private DirtyValue<DateTime?> _checkConfirmedDate;
        /// <summary>
        /// File Contacts Broker Check Confirmed Date [VEND.X368]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "File Contacts Broker Check Confirmed Date")]
        public DateTime? CheckConfirmedDate { get => _checkConfirmedDate; set => _checkConfirmedDate = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Contact City
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _clause;
        /// <summary>
        /// File Contacts Mortgagee Clause [VEND.X496]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Mortgagee Clause")]
        public string Clause { get => _clause; set => _clause = value; }
        private DirtyValue<string> _closingAgentWebURL;
        /// <summary>
        /// File Contacts Settlement Agent - Closing Agent Web URL [VEND.X1041]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent - Closing Agent Web URL")]
        public string ClosingAgentWebURL { get => _closingAgentWebURL; set => _closingAgentWebURL = value; }
        private DirtyValue<string> _closingCompanyWebURL;
        /// <summary>
        /// File Contacts Settlement Agent - Closing Company Web URL [VEND.X1040]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent - Closing Company Web URL")]
        public string ClosingCompanyWebURL { get => _closingCompanyWebURL; set => _closingCompanyWebURL = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Contact Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _companyId;
        /// <summary>
        /// File Contacts Broker Lender Company ID [3237]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Lender Company ID")]
        public string CompanyId { get => _companyId; set => _companyId = value; }
        private DirtyValue<decimal?> _completionAffidavitPunchListTotal;
        /// <summary>
        /// File Contacts General Contractor Completion Affidavit Punch List Total [VEND.X1024]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor Completion Affidavit Punch List Total")]
        public decimal? CompletionAffidavitPunchListTotal { get => _completionAffidavitPunchListTotal; set => _completionAffidavitPunchListTotal = value; }
        private DirtyValue<int?> _contactIndex;
        /// <summary>
        /// Contact ContactIndex
        /// </summary>
        public int? ContactIndex { get => _contactIndex; set => _contactIndex = value; }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// Contact ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _contactNMLSNo;
        /// <summary>
        /// File Contacts Settlement Agent Contact NMLS Number [VEND.X675]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent Contact NMLS Number")]
        public string ContactNMLSNo { get => _contactNMLSNo; set => _contactNMLSNo = value; }
        private DirtyValue<string> _contactTitle;
        /// <summary>
        /// Contact ContactTitle
        /// </summary>
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        private DirtyValue<StringEnumValue<ContactType>> _contactType;
        /// <summary>
        /// Contact ContactType
        /// </summary>
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => _contactType = value; }
        private DirtyValue<DateTime?> _designeeAcceptedDate;
        /// <summary>
        /// Appointment Of Designee DesigneeAcceptedDate [VEND.X1026]
        /// </summary>
        [LoanFieldProperty(Description = "Appointment Of Designee DesigneeAcceptedDate")]
        public DateTime? DesigneeAcceptedDate { get => _designeeAcceptedDate; set => _designeeAcceptedDate = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// Contact Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<decimal?> _employerLiabilityInsuranceMin;
        /// <summary>
        /// File Contacts General Contractor Employer Liability Insurance Min [VEND.X1018]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor Employer Liability Insurance Min")]
        public decimal? EmployerLiabilityInsuranceMin { get => _employerLiabilityInsuranceMin; set => _employerLiabilityInsuranceMin = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Contact Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _fax2;
        /// <summary>
        /// File Contacts Submitting Broker - Lender Fax [2844]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "File Contacts Submitting Broker - Lender Fax")]
        public string Fax2 { get => _fax2; set => _fax2 = value; }
        private DirtyValue<string> _fhaLenderId;
        /// <summary>
        /// FHA Lender ID [1059]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Lender ID")]
        public string FhaLenderId { get => _fhaLenderId; set => _fhaLenderId = value; }
        private DirtyValue<decimal?> _generalLiabilityInsuranceMin;
        /// <summary>
        /// File Contacts General Contractor General Liability Insurance Min [VEND.X1017]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor General Liability Insurance Min")]
        public decimal? GeneralLiabilityInsuranceMin { get => _generalLiabilityInsuranceMin; set => _generalLiabilityInsuranceMin = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Contact Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _insuranceCertNumber;
        /// <summary>
        /// Underwriting Flood Info Cert Number [2363]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Cert Number")]
        public string InsuranceCertNumber { get => _insuranceCertNumber; set => _insuranceCertNumber = value; }
        private DirtyValue<decimal?> _insuranceCoverageAmount;
        /// <summary>
        /// Contact InsuranceCoverageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InsuranceCoverageAmount { get => _insuranceCoverageAmount; set => _insuranceCoverageAmount = value; }
        private DirtyValue<DateTime?> _insuranceDeterminationDate;
        /// <summary>
        /// Underwriting Flood Info Determination Date [2365]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Determination Date")]
        public DateTime? InsuranceDeterminationDate { get => _insuranceDeterminationDate; set => _insuranceDeterminationDate = value; }
        private DirtyValue<string> _insuranceDeterminationNumber;
        /// <summary>
        /// Underwriting Flood Info Determination Number [2364]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Determination Number")]
        public string InsuranceDeterminationNumber { get => _insuranceDeterminationNumber; set => _insuranceDeterminationNumber = value; }
        private DirtyValue<bool?> _insuranceFloodZone;
        /// <summary>
        /// Underwriting Flood Info Flood Zone [2366]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Flood Zone")]
        public bool? InsuranceFloodZone { get => _insuranceFloodZone; set => _insuranceFloodZone = value; }
        private DirtyValue<string> _insuranceMap;
        /// <summary>
        /// Underwriting Property Info Map ID [2368]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Map ID")]
        public string InsuranceMap { get => _insuranceMap; set => _insuranceMap = value; }
        private DirtyValue<int?> _insuranceNoOfBedrooms;
        /// <summary>
        /// Underwriting Property Info Number of Bedrooms [2369]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Number of Bedrooms")]
        public int? InsuranceNoOfBedrooms { get => _insuranceNoOfBedrooms; set => _insuranceNoOfBedrooms = value; }
        private DirtyValue<decimal?> _insurancePremium;
        /// <summary>
        /// Contact InsurancePremium
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InsurancePremium { get => _insurancePremium; set => _insurancePremium = value; }
        private DirtyValue<StringEnumValue<ProjectType>> _insuranceProjectType;
        /// <summary>
        /// Underwriting Property Info Project Type [2367]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Project Type")]
        public StringEnumValue<ProjectType> InsuranceProjectType { get => _insuranceProjectType; set => _insuranceProjectType = value; }
        private DirtyValue<DateTime?> _insuranceRenewalDate;
        /// <summary>
        /// Contact InsuranceRenewalDate
        /// </summary>
        public DateTime? InsuranceRenewalDate { get => _insuranceRenewalDate; set => _insuranceRenewalDate = value; }
        private DirtyValue<string> _investorGrade1;
        /// <summary>
        /// Underwriting Investor Info Grade 1 [2343]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 1")]
        public string InvestorGrade1 { get => _investorGrade1; set => _investorGrade1 = value; }
        private DirtyValue<string> _investorGrade2;
        /// <summary>
        /// Underwriting Investor Info Grade 2 [2346]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 2")]
        public string InvestorGrade2 { get => _investorGrade2; set => _investorGrade2 = value; }
        private DirtyValue<string> _investorGrade3;
        /// <summary>
        /// Underwriting Investor Info Grade 3 [2349]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 3")]
        public string InvestorGrade3 { get => _investorGrade3; set => _investorGrade3 = value; }
        private DirtyValue<string> _investorLicense;
        /// <summary>
        /// File Contacts Investor License # [VEND.X650]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Investor License #")]
        public string InvestorLicense { get => _investorLicense; set => _investorLicense = value; }
        private DirtyValue<string> _investorLicenseType;
        /// <summary>
        /// Contact InvestorLicenseType
        /// </summary>
        public string InvestorLicenseType { get => _investorLicenseType; set => _investorLicenseType = value; }
        private DirtyValue<string> _investorName1;
        /// <summary>
        /// Underwriting Investor Info Name 1 [2342]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 1")]
        public string InvestorName1 { get => _investorName1; set => _investorName1 = value; }
        private DirtyValue<string> _investorName2;
        /// <summary>
        /// Underwriting Investor Info Name 2 [2345]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 2")]
        public string InvestorName2 { get => _investorName2; set => _investorName2 = value; }
        private DirtyValue<string> _investorName3;
        /// <summary>
        /// Underwriting Investor Info Name 3 [2348]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 3")]
        public string InvestorName3 { get => _investorName3; set => _investorName3 = value; }
        private DirtyValue<string> _investorScore1;
        /// <summary>
        /// Underwriting Investor Info Score 1 [2344]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 1")]
        public string InvestorScore1 { get => _investorScore1; set => _investorScore1 = value; }
        private DirtyValue<string> _investorScore2;
        /// <summary>
        /// Underwriting Investor Info Score 2 [2347]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 2")]
        public string InvestorScore2 { get => _investorScore2; set => _investorScore2 = value; }
        private DirtyValue<string> _investorScore3;
        /// <summary>
        /// Underwriting Investor Info Score 3 [2350]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 3")]
        public string InvestorScore3 { get => _investorScore3; set => _investorScore3 = value; }
        private DirtyValue<string> _lenderType;
        /// <summary>
        /// Contact LenderType
        /// </summary>
        public string LenderType { get => _lenderType; set => _lenderType = value; }
        private DirtyValue<string> _license;
        /// <summary>
        /// Contact License
        /// </summary>
        public string License { get => _license; set => _license = value; }
        private DirtyValue<bool?> _licenseExempt;
        /// <summary>
        /// Contact LicenseExempt
        /// </summary>
        public bool? LicenseExempt { get => _licenseExempt; set => _licenseExempt = value; }
        private DirtyValue<StringEnumValue<State>> _licenseHomeState;
        /// <summary>
        /// File Contacts-Lender License Home State [3896]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts-Lender License Home State")]
        public StringEnumValue<State> LicenseHomeState { get => _licenseHomeState; set => _licenseHomeState = value; }
        private DirtyValue<string> _licenseType;
        /// <summary>
        /// Contact LicenseType
        /// </summary>
        public string LicenseType { get => _licenseType; set => _licenseType = value; }
        private DirtyValue<string> _lineItemNumber;
        /// <summary>
        /// Contact LineItemNumber
        /// </summary>
        public string LineItemNumber { get => _lineItemNumber; set => _lineItemNumber = value; }
        private DirtyValue<string> _loginId;
        /// <summary>
        /// Contact LoginId
        /// </summary>
        public string LoginId { get => _loginId; set => _loginId = value; }
        private DirtyValue<string> _mortgageBrokerCompanyWebURL;
        /// <summary>
        /// File Contacts Broker - Mortgage Broker Company Web URL [VEND.X1036]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Mortgage Broker Company Web URL")]
        public string MortgageBrokerCompanyWebURL { get => _mortgageBrokerCompanyWebURL; set => _mortgageBrokerCompanyWebURL = value; }
        private DirtyValue<string> _mortgageBrokerLoanOfficerWebURL;
        /// <summary>
        /// File Contacts Broker - Mortgage Broker Loan Officer Web URL [VEND.X1037]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Mortgage Broker Loan Officer Web URL")]
        public string MortgageBrokerLoanOfficerWebURL { get => _mortgageBrokerLoanOfficerWebURL; set => _mortgageBrokerLoanOfficerWebURL = value; }
        private DirtyValue<string> _mortgageLenderCompanyWebURL;
        /// <summary>
        /// File Contacts Lender - Mortgage Lender Company Web URL [VEND.X1034]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender - Mortgage Lender Company Web URL")]
        public string MortgageLenderCompanyWebURL { get => _mortgageLenderCompanyWebURL; set => _mortgageLenderCompanyWebURL = value; }
        private DirtyValue<string> _mortgageLenderLoanOfficerWebURL;
        /// <summary>
        /// File Contacts Lender - Mortgage Lender Loan Officer Web URL [VEND.X1035]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender - Mortgage Lender Loan Officer Web URL")]
        public string MortgageLenderLoanOfficerWebURL { get => _mortgageLenderLoanOfficerWebURL; set => _mortgageLenderLoanOfficerWebURL = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// Contact Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _nmlsLicense;
        /// <summary>
        /// Contact NmlsLicense
        /// </summary>
        public string NmlsLicense { get => _nmlsLicense; set => _nmlsLicense = value; }
        private DirtyValue<bool?> _notNaturalPersonFlag;
        /// <summary>
        /// Contact NotNaturalPersonFlag
        /// </summary>
        public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => _notNaturalPersonFlag = value; }
        private DirtyValue<string> _organizationState;
        /// <summary>
        /// Contact OrganizationState
        /// </summary>
        public string OrganizationState { get => _organizationState; set => _organizationState = value; }
        private DirtyValue<string> _organizationType;
        /// <summary>
        /// Contact OrganizationType
        /// </summary>
        public string OrganizationType { get => _organizationType; set => _organizationType = value; }
        private DirtyValue<DateTime?> _personalLicenseAuthDate;
        /// <summary>
        /// Contact PersonalLicenseAuthDate
        /// </summary>
        public DateTime? PersonalLicenseAuthDate { get => _personalLicenseAuthDate; set => _personalLicenseAuthDate = value; }
        private DirtyValue<string> _personalLicenseAuthName;
        /// <summary>
        /// Contact PersonalLicenseAuthName
        /// </summary>
        public string PersonalLicenseAuthName { get => _personalLicenseAuthName; set => _personalLicenseAuthName = value; }
        private DirtyValue<StringEnumValue<State>> _personalLicenseAuthStateCode;
        /// <summary>
        /// Contact PersonalLicenseAuthStateCode
        /// </summary>
        public StringEnumValue<State> PersonalLicenseAuthStateCode { get => _personalLicenseAuthStateCode; set => _personalLicenseAuthStateCode = value; }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _personalLicenseAuthType;
        /// <summary>
        /// Contact PersonalLicenseAuthType
        /// </summary>
        public StringEnumValue<LicenseAuthType> PersonalLicenseAuthType { get => _personalLicenseAuthType; set => _personalLicenseAuthType = value; }
        private DirtyValue<string> _personalLicenseNumber;
        /// <summary>
        /// Contact PersonalLicenseNumber
        /// </summary>
        public string PersonalLicenseNumber { get => _personalLicenseNumber; set => _personalLicenseNumber = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// Contact Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _phone2;
        /// <summary>
        /// Contact Phone2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone2 { get => _phone2; set => _phone2 = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Contact PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _realEstateAgencyWebURL;
        /// <summary>
        /// File Contacts Broker - Real Estate Agency Web URL [VEND.X1038]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Real Estate Agency Web URL")]
        public string RealEstateAgencyWebURL { get => _realEstateAgencyWebURL; set => _realEstateAgencyWebURL = value; }
        private DirtyValue<string> _realEstateAgentWebURL;
        /// <summary>
        /// File Contacts Broker - Real Estate Agent Web URL [VEND.X1039]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Real Estate Agent Web URL")]
        public string RealEstateAgentWebURL { get => _realEstateAgentWebURL; set => _realEstateAgentWebURL = value; }
        private DirtyValue<string> _recCity;
        /// <summary>
        /// File Contacts Broker Rec City [VEND.X308]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Rec City")]
        public string RecCity { get => _recCity; set => _recCity = value; }
        private DirtyValue<string> _referenceNumber;
        /// <summary>
        /// Contact ReferenceNumber
        /// </summary>
        public string ReferenceNumber { get => _referenceNumber; set => _referenceNumber = value; }
        private DirtyValue<string> _relationship;
        /// <summary>
        /// Contact Relationship
        /// </summary>
        public string Relationship { get => _relationship; set => _relationship = value; }
        private DirtyValue<bool?> _settlementAgent;
        /// <summary>
        /// Contact SettlementAgent
        /// </summary>
        public bool? SettlementAgent { get => _settlementAgent; set => _settlementAgent = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Contact State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        private DirtyValue<string> _taxID;
        /// <summary>
        /// Contact TaxID
        /// </summary>
        public string TaxID { get => _taxID; set => _taxID = value; }
        private DirtyValue<string> _tqlCommentHistory;
        /// <summary>
        /// TQL Comment History [3355]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL Comment History")]
        public string TqlCommentHistory { get => _tqlCommentHistory; set => _tqlCommentHistory = value; }
        private DirtyValue<string> _tQLConsentSelection;
        /// <summary>
        /// Consent Selection in TQL Portal [CCVP.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Consent Selection in TQL Portal")]
        public string TQLConsentSelection { get => _tQLConsentSelection; set => _tQLConsentSelection = value; }
        private DirtyValue<int?> _tqlId;
        /// <summary>
        /// TQL InvestorID [3318]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL InvestorID")]
        public int? TqlId { get => _tqlId; set => _tqlId = value; }
        private DirtyValue<bool?> _tqlIsPublishingIndicator;
        /// <summary>
        /// Is Published to Investor [3333]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Is Published to Investor")]
        public bool? TqlIsPublishingIndicator { get => _tqlIsPublishingIndicator; set => _tqlIsPublishingIndicator = value; }
        private DirtyValue<string> _tqlName;
        /// <summary>
        /// TQL Investor Name [3317]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL Investor Name")]
        public string TqlName { get => _tqlName; set => _tqlName = value; }
    }
}