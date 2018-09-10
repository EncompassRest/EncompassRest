using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Contact
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ContactType), SerializeWholeListWhenDirty = true)]
    public sealed partial class Contact : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aBA;
        /// <summary>
        /// Contact ABA
        /// </summary>
        public string ABA { get => _aBA; set => SetField(ref _aBA, value); }
        private DirtyValue<string> _accountName;
        /// <summary>
        /// Contact AccountName
        /// </summary>
        public string AccountName { get => _accountName; set => SetField(ref _accountName, value); }
        private DirtyValue<string> _address;
        /// <summary>
        /// Contact Address
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<string> _address2;
        /// <summary>
        /// File Contacts Broker Lender Address 2 [1954]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "File Contacts Broker Lender Address 2")]
        public string Address2 { get => _address2; set => SetField(ref _address2, value); }
        private DirtyValue<bool?> _addToCdContactInfo;
        /// <summary>
        /// Contact AddToCdContactInfo
        /// </summary>
        public bool? AddToCdContactInfo { get => _addToCdContactInfo; set => SetField(ref _addToCdContactInfo, value); }
        private DirtyValue<StringEnumValue<AppraisalMade>> _appraisalMade;
        /// <summary>
        /// File Contacts Appraisal Co Appraisal Made (As Is or As Improved) [4091]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Appraisal Co Appraisal Made (As Is or As Improved)")]
        public StringEnumValue<AppraisalMade> AppraisalMade { get => _appraisalMade; set => SetField(ref _appraisalMade, value); }
        private DirtyValue<DateTime?> _bizLicenseAuthDate;
        /// <summary>
        /// Contact BizLicenseAuthDate
        /// </summary>
        public DateTime? BizLicenseAuthDate { get => _bizLicenseAuthDate; set => SetField(ref _bizLicenseAuthDate, value); }
        private DirtyValue<string> _bizLicenseAuthName;
        /// <summary>
        /// Contact BizLicenseAuthName
        /// </summary>
        public string BizLicenseAuthName { get => _bizLicenseAuthName; set => SetField(ref _bizLicenseAuthName, value); }
        private DirtyValue<StringEnumValue<State>> _bizLicenseAuthStateCode;
        /// <summary>
        /// Contact BizLicenseAuthStateCode
        /// </summary>
        public StringEnumValue<State> BizLicenseAuthStateCode { get => _bizLicenseAuthStateCode; set => SetField(ref _bizLicenseAuthStateCode, value); }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _bizLicenseAuthType;
        /// <summary>
        /// Contact BizLicenseAuthType
        /// </summary>
        public StringEnumValue<LicenseAuthType> BizLicenseAuthType { get => _bizLicenseAuthType; set => SetField(ref _bizLicenseAuthType, value); }
        private DirtyValue<string> _bizLicenseNumber;
        /// <summary>
        /// Contact BizLicenseNumber
        /// </summary>
        public string BizLicenseNumber { get => _bizLicenseNumber; set => SetField(ref _bizLicenseNumber, value); }
        private DirtyValue<bool?> _borrowerActingAsContractorIndicator;
        /// <summary>
        /// File Contacts General Contractor BorrowerActingAsContractorIndicator [VEND.X1009]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts General Contractor BorrowerActingAsContractorIndicator")]
        public bool? BorrowerActingAsContractorIndicator { get => _borrowerActingAsContractorIndicator; set => SetField(ref _borrowerActingAsContractorIndicator, value); }
        private DirtyValue<string> _brokerLenderType;
        /// <summary>
        /// Contact BrokerLenderType
        /// </summary>
        public string BrokerLenderType { get => _brokerLenderType; set => SetField(ref _brokerLenderType, value); }
        private DirtyValue<bool?> _brokerLicenseExempt;
        /// <summary>
        /// Contact BrokerLicenseExempt
        /// </summary>
        public bool? BrokerLicenseExempt { get => _brokerLicenseExempt; set => SetField(ref _brokerLicenseExempt, value); }
        private DirtyValue<string> _brokerLicenseType;
        /// <summary>
        /// Contact BrokerLicenseType
        /// </summary>
        public string BrokerLicenseType { get => _brokerLicenseType; set => SetField(ref _brokerLicenseType, value); }
        private DirtyValue<string> _businessPhone;
        /// <summary>
        /// Contact BusinessPhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }
        private DirtyValue<string> _categoryName;
        /// <summary>
        /// Contact CategoryName
        /// </summary>
        public string CategoryName { get => _categoryName; set => SetField(ref _categoryName, value); }
        private DirtyValue<string> _cell;
        /// <summary>
        /// Contact Cell
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Cell { get => _cell; set => SetField(ref _cell, value); }
        private DirtyValue<DateTime?> _checkConfirmedDate;
        /// <summary>
        /// File Contacts Broker Check Confirmed Date [VEND.X368]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "File Contacts Broker Check Confirmed Date")]
        public DateTime? CheckConfirmedDate { get => _checkConfirmedDate; set => SetField(ref _checkConfirmedDate, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// Contact City
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _clause;
        /// <summary>
        /// File Contacts Mortgagee Clause [VEND.X496]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Mortgagee Clause")]
        public string Clause { get => _clause; set => SetField(ref _clause, value); }
        private DirtyValue<string> _closingAgentWebURL;
        /// <summary>
        /// File Contacts Settlement Agent - Closing Agent Web URL [VEND.X1041]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent - Closing Agent Web URL")]
        public string ClosingAgentWebURL { get => _closingAgentWebURL; set => SetField(ref _closingAgentWebURL, value); }
        private DirtyValue<string> _closingCompanyWebURL;
        /// <summary>
        /// File Contacts Settlement Agent - Closing Company Web URL [VEND.X1040]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent - Closing Company Web URL")]
        public string ClosingCompanyWebURL { get => _closingCompanyWebURL; set => SetField(ref _closingCompanyWebURL, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Contact Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _companyId;
        /// <summary>
        /// File Contacts Broker Lender Company ID [3237]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Lender Company ID")]
        public string CompanyId { get => _companyId; set => SetField(ref _companyId, value); }
        private DirtyValue<decimal?> _completionAffidavitPunchListTotal;
        /// <summary>
        /// File Contacts General Contractor Completion Affidavit Punch List Total [VEND.X1024]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor Completion Affidavit Punch List Total")]
        public decimal? CompletionAffidavitPunchListTotal { get => _completionAffidavitPunchListTotal; set => SetField(ref _completionAffidavitPunchListTotal, value); }
        private DirtyValue<int?> _contactIndex;
        /// <summary>
        /// Contact ContactIndex
        /// </summary>
        public int? ContactIndex { get => _contactIndex; set => SetField(ref _contactIndex, value); }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// Contact ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }
        private DirtyValue<string> _contactNMLSNo;
        /// <summary>
        /// File Contacts Settlement Agent Contact NMLS Number [VEND.X675]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Settlement Agent Contact NMLS Number")]
        public string ContactNMLSNo { get => _contactNMLSNo; set => SetField(ref _contactNMLSNo, value); }
        private DirtyValue<string> _contactTitle;
        /// <summary>
        /// Contact ContactTitle
        /// </summary>
        public string ContactTitle { get => _contactTitle; set => SetField(ref _contactTitle, value); }
        private DirtyValue<StringEnumValue<ContactType>> _contactType;
        /// <summary>
        /// Contact ContactType
        /// </summary>
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => SetField(ref _contactType, value); }
        private DirtyValue<DateTime?> _designeeAcceptedDate;
        /// <summary>
        /// Appointment Of Designee DesigneeAcceptedDate [VEND.X1026]
        /// </summary>
        [LoanFieldProperty(Description = "Appointment Of Designee DesigneeAcceptedDate")]
        public DateTime? DesigneeAcceptedDate { get => _designeeAcceptedDate; set => SetField(ref _designeeAcceptedDate, value); }
        private DirtyValue<string> _email;
        /// <summary>
        /// Contact Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }
        private DirtyValue<decimal?> _employerLiabilityInsuranceMin;
        /// <summary>
        /// File Contacts General Contractor Employer Liability Insurance Min [VEND.X1018]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor Employer Liability Insurance Min")]
        public decimal? EmployerLiabilityInsuranceMin { get => _employerLiabilityInsuranceMin; set => SetField(ref _employerLiabilityInsuranceMin, value); }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Contact Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }
        private DirtyValue<string> _fax2;
        /// <summary>
        /// File Contacts Submitting Broker - Lender Fax [2844]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "File Contacts Submitting Broker - Lender Fax")]
        public string Fax2 { get => _fax2; set => SetField(ref _fax2, value); }
        private DirtyValue<string> _fhaLenderId;
        /// <summary>
        /// FHA Lender ID [1059]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Lender ID")]
        public string FhaLenderId { get => _fhaLenderId; set => SetField(ref _fhaLenderId, value); }
        private DirtyValue<decimal?> _generalLiabilityInsuranceMin;
        /// <summary>
        /// File Contacts General Contractor General Liability Insurance Min [VEND.X1017]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "File Contacts General Contractor General Liability Insurance Min")]
        public decimal? GeneralLiabilityInsuranceMin { get => _generalLiabilityInsuranceMin; set => SetField(ref _generalLiabilityInsuranceMin, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Contact Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _insuranceCertNumber;
        /// <summary>
        /// Underwriting Flood Info Cert Number [2363]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Cert Number")]
        public string InsuranceCertNumber { get => _insuranceCertNumber; set => SetField(ref _insuranceCertNumber, value); }
        private DirtyValue<decimal?> _insuranceCoverageAmount;
        /// <summary>
        /// Contact InsuranceCoverageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InsuranceCoverageAmount { get => _insuranceCoverageAmount; set => SetField(ref _insuranceCoverageAmount, value); }
        private DirtyValue<DateTime?> _insuranceDeterminationDate;
        /// <summary>
        /// Underwriting Flood Info Determination Date [2365]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Determination Date")]
        public DateTime? InsuranceDeterminationDate { get => _insuranceDeterminationDate; set => SetField(ref _insuranceDeterminationDate, value); }
        private DirtyValue<string> _insuranceDeterminationNumber;
        /// <summary>
        /// Underwriting Flood Info Determination Number [2364]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Determination Number")]
        public string InsuranceDeterminationNumber { get => _insuranceDeterminationNumber; set => SetField(ref _insuranceDeterminationNumber, value); }
        private DirtyValue<bool?> _insuranceFloodZone;
        /// <summary>
        /// Underwriting Flood Info Flood Zone [2366]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Flood Info Flood Zone")]
        public bool? InsuranceFloodZone { get => _insuranceFloodZone; set => SetField(ref _insuranceFloodZone, value); }
        private DirtyValue<string> _insuranceMap;
        /// <summary>
        /// Underwriting Property Info Map ID [2368]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Map ID")]
        public string InsuranceMap { get => _insuranceMap; set => SetField(ref _insuranceMap, value); }
        private DirtyValue<int?> _insuranceNoOfBedrooms;
        /// <summary>
        /// Underwriting Property Info Number of Bedrooms [2369]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Number of Bedrooms")]
        public int? InsuranceNoOfBedrooms { get => _insuranceNoOfBedrooms; set => SetField(ref _insuranceNoOfBedrooms, value); }
        private DirtyValue<decimal?> _insurancePremium;
        /// <summary>
        /// Contact InsurancePremium
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InsurancePremium { get => _insurancePremium; set => SetField(ref _insurancePremium, value); }
        private DirtyValue<StringEnumValue<ProjectType>> _insuranceProjectType;
        /// <summary>
        /// Underwriting Property Info Project Type [2367]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Property Info Project Type")]
        public StringEnumValue<ProjectType> InsuranceProjectType { get => _insuranceProjectType; set => SetField(ref _insuranceProjectType, value); }
        private DirtyValue<DateTime?> _insuranceRenewalDate;
        /// <summary>
        /// Contact InsuranceRenewalDate
        /// </summary>
        public DateTime? InsuranceRenewalDate { get => _insuranceRenewalDate; set => SetField(ref _insuranceRenewalDate, value); }
        private DirtyValue<string> _investorGrade1;
        /// <summary>
        /// Underwriting Investor Info Grade 1 [2343]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 1")]
        public string InvestorGrade1 { get => _investorGrade1; set => SetField(ref _investorGrade1, value); }
        private DirtyValue<string> _investorGrade2;
        /// <summary>
        /// Underwriting Investor Info Grade 2 [2346]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 2")]
        public string InvestorGrade2 { get => _investorGrade2; set => SetField(ref _investorGrade2, value); }
        private DirtyValue<string> _investorGrade3;
        /// <summary>
        /// Underwriting Investor Info Grade 3 [2349]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Grade 3")]
        public string InvestorGrade3 { get => _investorGrade3; set => SetField(ref _investorGrade3, value); }
        private DirtyValue<string> _investorLicense;
        /// <summary>
        /// File Contacts Investor License # [VEND.X650]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Investor License #")]
        public string InvestorLicense { get => _investorLicense; set => SetField(ref _investorLicense, value); }
        private DirtyValue<string> _investorLicenseType;
        /// <summary>
        /// Contact InvestorLicenseType
        /// </summary>
        public string InvestorLicenseType { get => _investorLicenseType; set => SetField(ref _investorLicenseType, value); }
        private DirtyValue<string> _investorName1;
        /// <summary>
        /// Underwriting Investor Info Name 1 [2342]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 1")]
        public string InvestorName1 { get => _investorName1; set => SetField(ref _investorName1, value); }
        private DirtyValue<string> _investorName2;
        /// <summary>
        /// Underwriting Investor Info Name 2 [2345]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 2")]
        public string InvestorName2 { get => _investorName2; set => SetField(ref _investorName2, value); }
        private DirtyValue<string> _investorName3;
        /// <summary>
        /// Underwriting Investor Info Name 3 [2348]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Name 3")]
        public string InvestorName3 { get => _investorName3; set => SetField(ref _investorName3, value); }
        private DirtyValue<string> _investorScore1;
        /// <summary>
        /// Underwriting Investor Info Score 1 [2344]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 1")]
        public string InvestorScore1 { get => _investorScore1; set => SetField(ref _investorScore1, value); }
        private DirtyValue<string> _investorScore2;
        /// <summary>
        /// Underwriting Investor Info Score 2 [2347]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 2")]
        public string InvestorScore2 { get => _investorScore2; set => SetField(ref _investorScore2, value); }
        private DirtyValue<string> _investorScore3;
        /// <summary>
        /// Underwriting Investor Info Score 3 [2350]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Investor Info Score 3")]
        public string InvestorScore3 { get => _investorScore3; set => SetField(ref _investorScore3, value); }
        private DirtyValue<string> _lenderType;
        /// <summary>
        /// Contact LenderType
        /// </summary>
        public string LenderType { get => _lenderType; set => SetField(ref _lenderType, value); }
        private DirtyValue<string> _license;
        /// <summary>
        /// Contact License
        /// </summary>
        public string License { get => _license; set => SetField(ref _license, value); }
        private DirtyValue<bool?> _licenseExempt;
        /// <summary>
        /// Contact LicenseExempt
        /// </summary>
        public bool? LicenseExempt { get => _licenseExempt; set => SetField(ref _licenseExempt, value); }
        private DirtyValue<StringEnumValue<State>> _licenseHomeState;
        /// <summary>
        /// File Contacts-Lender License Home State [3896]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts-Lender License Home State")]
        public StringEnumValue<State> LicenseHomeState { get => _licenseHomeState; set => SetField(ref _licenseHomeState, value); }
        private DirtyValue<string> _licenseType;
        /// <summary>
        /// Contact LicenseType
        /// </summary>
        public string LicenseType { get => _licenseType; set => SetField(ref _licenseType, value); }
        private DirtyValue<string> _lineItemNumber;
        /// <summary>
        /// Contact LineItemNumber
        /// </summary>
        public string LineItemNumber { get => _lineItemNumber; set => SetField(ref _lineItemNumber, value); }
        private DirtyValue<string> _loginId;
        /// <summary>
        /// Contact LoginId
        /// </summary>
        public string LoginId { get => _loginId; set => SetField(ref _loginId, value); }
        private DirtyValue<string> _mortgageBrokerCompanyWebURL;
        /// <summary>
        /// File Contacts Broker - Mortgage Broker Company Web URL [VEND.X1036]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Mortgage Broker Company Web URL")]
        public string MortgageBrokerCompanyWebURL { get => _mortgageBrokerCompanyWebURL; set => SetField(ref _mortgageBrokerCompanyWebURL, value); }
        private DirtyValue<string> _mortgageBrokerLoanOfficerWebURL;
        /// <summary>
        /// File Contacts Broker - Mortgage Broker Loan Officer Web URL [VEND.X1037]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Mortgage Broker Loan Officer Web URL")]
        public string MortgageBrokerLoanOfficerWebURL { get => _mortgageBrokerLoanOfficerWebURL; set => SetField(ref _mortgageBrokerLoanOfficerWebURL, value); }
        private DirtyValue<string> _mortgageLenderCompanyWebURL;
        /// <summary>
        /// File Contacts Lender - Mortgage Lender Company Web URL [VEND.X1034]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender - Mortgage Lender Company Web URL")]
        public string MortgageLenderCompanyWebURL { get => _mortgageLenderCompanyWebURL; set => SetField(ref _mortgageLenderCompanyWebURL, value); }
        private DirtyValue<string> _mortgageLenderLoanOfficerWebURL;
        /// <summary>
        /// File Contacts Lender - Mortgage Lender Loan Officer Web URL [VEND.X1035]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Lender - Mortgage Lender Loan Officer Web URL")]
        public string MortgageLenderLoanOfficerWebURL { get => _mortgageLenderLoanOfficerWebURL; set => SetField(ref _mortgageLenderLoanOfficerWebURL, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// Contact Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<string> _nmlsLicense;
        /// <summary>
        /// Contact NmlsLicense
        /// </summary>
        public string NmlsLicense { get => _nmlsLicense; set => SetField(ref _nmlsLicense, value); }
        private DirtyValue<bool?> _notNaturalPersonFlag;
        /// <summary>
        /// Contact NotNaturalPersonFlag
        /// </summary>
        public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => SetField(ref _notNaturalPersonFlag, value); }
        private DirtyValue<string> _organizationState;
        /// <summary>
        /// Contact OrganizationState
        /// </summary>
        public string OrganizationState { get => _organizationState; set => SetField(ref _organizationState, value); }
        private DirtyValue<string> _organizationType;
        /// <summary>
        /// Contact OrganizationType
        /// </summary>
        public string OrganizationType { get => _organizationType; set => SetField(ref _organizationType, value); }
        private DirtyValue<DateTime?> _personalLicenseAuthDate;
        /// <summary>
        /// Contact PersonalLicenseAuthDate
        /// </summary>
        public DateTime? PersonalLicenseAuthDate { get => _personalLicenseAuthDate; set => SetField(ref _personalLicenseAuthDate, value); }
        private DirtyValue<string> _personalLicenseAuthName;
        /// <summary>
        /// Contact PersonalLicenseAuthName
        /// </summary>
        public string PersonalLicenseAuthName { get => _personalLicenseAuthName; set => SetField(ref _personalLicenseAuthName, value); }
        private DirtyValue<StringEnumValue<State>> _personalLicenseAuthStateCode;
        /// <summary>
        /// Contact PersonalLicenseAuthStateCode
        /// </summary>
        public StringEnumValue<State> PersonalLicenseAuthStateCode { get => _personalLicenseAuthStateCode; set => SetField(ref _personalLicenseAuthStateCode, value); }
        private DirtyValue<StringEnumValue<LicenseAuthType>> _personalLicenseAuthType;
        /// <summary>
        /// Contact PersonalLicenseAuthType
        /// </summary>
        public StringEnumValue<LicenseAuthType> PersonalLicenseAuthType { get => _personalLicenseAuthType; set => SetField(ref _personalLicenseAuthType, value); }
        private DirtyValue<string> _personalLicenseNumber;
        /// <summary>
        /// Contact PersonalLicenseNumber
        /// </summary>
        public string PersonalLicenseNumber { get => _personalLicenseNumber; set => SetField(ref _personalLicenseNumber, value); }
        private DirtyValue<string> _phone;
        /// <summary>
        /// Contact Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => SetField(ref _phone, value); }
        private DirtyValue<string> _phone2;
        /// <summary>
        /// Contact Phone2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone2 { get => _phone2; set => SetField(ref _phone2, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Contact PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<string> _realEstateAgencyWebURL;
        /// <summary>
        /// File Contacts Broker - Real Estate Agency Web URL [VEND.X1038]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Real Estate Agency Web URL")]
        public string RealEstateAgencyWebURL { get => _realEstateAgencyWebURL; set => SetField(ref _realEstateAgencyWebURL, value); }
        private DirtyValue<string> _realEstateAgentWebURL;
        /// <summary>
        /// File Contacts Broker - Real Estate Agent Web URL [VEND.X1039]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker - Real Estate Agent Web URL")]
        public string RealEstateAgentWebURL { get => _realEstateAgentWebURL; set => SetField(ref _realEstateAgentWebURL, value); }
        private DirtyValue<string> _recCity;
        /// <summary>
        /// File Contacts Broker Rec City [VEND.X308]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Rec City")]
        public string RecCity { get => _recCity; set => SetField(ref _recCity, value); }
        private DirtyValue<string> _referenceNumber;
        /// <summary>
        /// Contact ReferenceNumber
        /// </summary>
        public string ReferenceNumber { get => _referenceNumber; set => SetField(ref _referenceNumber, value); }
        private DirtyValue<string> _relationship;
        /// <summary>
        /// Contact Relationship
        /// </summary>
        public string Relationship { get => _relationship; set => SetField(ref _relationship, value); }
        private DirtyValue<bool?> _settlementAgent;
        /// <summary>
        /// Contact SettlementAgent
        /// </summary>
        public bool? SettlementAgent { get => _settlementAgent; set => SetField(ref _settlementAgent, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Contact State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<string> _taxID;
        /// <summary>
        /// Contact TaxID
        /// </summary>
        public string TaxID { get => _taxID; set => SetField(ref _taxID, value); }
        private DirtyValue<string> _tqlCommentHistory;
        /// <summary>
        /// TQL Comment History [3355]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL Comment History")]
        public string TqlCommentHistory { get => _tqlCommentHistory; set => SetField(ref _tqlCommentHistory, value); }
        private DirtyValue<string> _tQLConsentSelection;
        /// <summary>
        /// Consent Selection in TQL Portal [CCVP.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Consent Selection in TQL Portal")]
        public string TQLConsentSelection { get => _tQLConsentSelection; set => SetField(ref _tQLConsentSelection, value); }
        private DirtyValue<int?> _tqlId;
        /// <summary>
        /// TQL InvestorID [3318]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL InvestorID")]
        public int? TqlId { get => _tqlId; set => SetField(ref _tqlId, value); }
        private DirtyValue<bool?> _tqlIsPublishingIndicator;
        /// <summary>
        /// Is Published to Investor [3333]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Is Published to Investor")]
        public bool? TqlIsPublishingIndicator { get => _tqlIsPublishingIndicator; set => SetField(ref _tqlIsPublishingIndicator, value); }
        private DirtyValue<string> _tqlName;
        /// <summary>
        /// TQL Investor Name [3317]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TQL Investor Name")]
        public string TqlName { get => _tqlName; set => SetField(ref _tqlName, value); }
    }
}