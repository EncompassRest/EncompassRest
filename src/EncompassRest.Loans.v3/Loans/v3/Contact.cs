using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Contact
/// </summary>
public sealed partial class Contact : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _aba;
    private DirtyValue<string?>? _accountName;
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _address2;
    private DirtyValue<bool?>? _addToCdContactInfo;
    private DirtyValue<StringEnumValue<AppraisalMade>>? _appraisalMade;
    private DirtyValue<DateTime?>? _bizLicenseAuthDate;
    private DirtyValue<string?>? _bizLicenseAuthName;
    private DirtyValue<string?>? _bizLicenseAuthStateCode;
    private DirtyValue<StringEnumValue<LicenseAuthType>>? _bizLicenseAuthType;
    private DirtyValue<string?>? _bizLicenseNumber;
    private DirtyValue<bool?>? _borrowerActingAsContractorIndicator;
    private DirtyValue<string?>? _brokerLenderType;
    private DirtyValue<bool?>? _brokerLicenseExempt;
    private DirtyValue<string?>? _brokerLicenseType;
    private DirtyValue<string?>? _businessPhone;
    private DirtyValue<string?>? _categoryName;
    private DirtyValue<string?>? _cell;
    private DirtyValue<DateTime?>? _checkConfirmedDate;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _clause;
    private DirtyValue<string?>? _closingAgentWebUrl;
    private DirtyValue<string?>? _closingCompanyWebUrl;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _companyId;
    private DirtyValue<decimal?>? _completionAffidavitPunchListTotal;
    private DirtyValue<string?>? _contactName;
    private DirtyValue<string?>? _contactNmlsNo;
    private EntityReference? _contactRef;
    private DirtyValue<string?>? _contactTitle;
    private DirtyValue<StringEnumValue<ContactType>>? _contactType;
    private DirtyValue<string?>? _country;
    private DirtyValue<int?>? _customContactIndex;
    private DirtyValue<DateTime?>? _designeeAcceptedDate;
    private DirtyValue<string?>? _email;
    private DirtyValue<decimal?>? _employerLiabilityInsuranceMin;
    private DirtyValue<string?>? _fax;
    private DirtyValue<string?>? _fax2;
    private DirtyValue<string?>? _fedReferenceNumber;
    private DirtyValue<string?>? _fhaLenderId;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<DateTime?>? _fundsToTitleDate;
    private DirtyValue<decimal?>? _generalLiabilityInsuranceMin;
    private DirtyValue<string?>? _insuranceCertNumber;
    private DirtyValue<decimal?>? _insuranceCoverageAmount;
    private DirtyValue<DateTime?>? _insuranceDeterminationDate;
    private DirtyValue<string?>? _insuranceDeterminationNumber;
    private DirtyValue<bool?>? _insuranceFloodZone;
    private DirtyValue<string?>? _insuranceMap;
    private DirtyValue<int?>? _insuranceNoOfBedrooms;
    private DirtyValue<decimal?>? _insurancePremium;
    private DirtyValue<StringEnumValue<ProjectType>>? _insuranceProjectType;
    private DirtyValue<DateTime?>? _insuranceRenewalDate;
    private DirtyValue<string?>? _investorGrade1;
    private DirtyValue<string?>? _investorGrade2;
    private DirtyValue<string?>? _investorGrade3;
    private DirtyValue<string?>? _investorLicense;
    private DirtyValue<string?>? _investorLicenseType;
    private DirtyValue<string?>? _investorName1;
    private DirtyValue<string?>? _investorName2;
    private DirtyValue<string?>? _investorName3;
    private DirtyValue<string?>? _investorScore1;
    private DirtyValue<string?>? _investorScore2;
    private DirtyValue<string?>? _investorScore3;
    private DirtyValue<string?>? _jobTitle;
    private DirtyValue<string?>? _lenderType;
    private DirtyValue<string?>? _license;
    private DirtyValue<bool?>? _licenseExempt;
    private DirtyValue<string?>? _licenseHomeState;
    private DirtyValue<string?>? _licenseType;
    private DirtyValue<string?>? _lineItemNumber;
    private DirtyValue<string?>? _loginId;
    private DirtyValue<string?>? _mortgageBrokerCompanyWebUrl;
    private DirtyValue<string?>? _mortgageBrokerLoanOfficerWebUrl;
    private DirtyValue<string?>? _mortgageLenderCompanyWebUrl;
    private DirtyValue<string?>? _mortgageLenderLoanOfficerWebUrl;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _nmlsLicense;
    private DirtyValue<bool?>? _notNaturalPersonFlag;
    private DirtyValue<string?>? _organizationState;
    private DirtyValue<string?>? _organizationType;
    private DirtyValue<DateTime?>? _personalLicenseAuthDate;
    private DirtyValue<string?>? _personalLicenseAuthName;
    private DirtyValue<string?>? _personalLicenseAuthStateCode;
    private DirtyValue<StringEnumValue<LicenseAuthType>>? _personalLicenseAuthType;
    private DirtyValue<string?>? _personalLicenseNumber;
    private DirtyValue<string?>? _phone;
    private DirtyValue<string?>? _phone2;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<string?>? _realEstateAgencyWebUrl;
    private DirtyValue<string?>? _realEstateAgentWebUrl;
    private DirtyValue<string?>? _recCity;
    private DirtyValue<string?>? _referenceNumber;
    private DirtyValue<string?>? _relationship;
    private DirtyValue<bool?>? _settlementAgent;
    private DirtyValue<string?>? _state;
    private DirtyValue<string?>? _taxId;
    private DirtyValue<string?>? _tqlCommentHistory;
    private DirtyValue<string?>? _tqlConsentSelection;
    private DirtyValue<int?>? _tqlId;
    private DirtyValue<bool?>? _tqlIsPublishingIndicator;
    private DirtyValue<string?>? _tqlName;
    private DirtyValue<string?>? _warehouseId;
    private DirtyValue<string?>? _warehouseLender;
    private DirtyValue<string?>? _warehouseUrl;

    /// <summary>
    /// ContactContract Aba
    /// </summary>
    public string? Aba { get => _aba; set => SetField(ref _aba, value); }

    /// <summary>
    /// ContactContract AccountName
    /// </summary>
    public string? AccountName { get => _accountName; set => SetField(ref _accountName, value); }

    /// <summary>
    /// ContactContract Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// File Contacts Broker Lender Address 2 [1954]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Address2 { get => _address2; set => SetField(ref _address2, value); }

    /// <summary>
    /// ContactContract AddToCdContactInfo
    /// </summary>
    public bool? AddToCdContactInfo { get => _addToCdContactInfo; set => SetField(ref _addToCdContactInfo, value); }

    /// <summary>
    /// File Contacts Appraisal Co Appraisal Made (As Is or As Improved) [4091]
    /// </summary>
    public StringEnumValue<AppraisalMade> AppraisalMade { get => _appraisalMade; set => SetField(ref _appraisalMade, value); }

    /// <summary>
    /// ContactContract BizLicenseAuthDate
    /// </summary>
    public DateTime? BizLicenseAuthDate { get => _bizLicenseAuthDate; set => SetField(ref _bizLicenseAuthDate, value); }

    /// <summary>
    /// ContactContract BizLicenseAuthName
    /// </summary>
    public string? BizLicenseAuthName { get => _bizLicenseAuthName; set => SetField(ref _bizLicenseAuthName, value); }

    /// <summary>
    /// ContactContract BizLicenseAuthStateCode
    /// </summary>
    public string? BizLicenseAuthStateCode { get => _bizLicenseAuthStateCode; set => SetField(ref _bizLicenseAuthStateCode, value); }

    /// <summary>
    /// ContactContract BizLicenseAuthType
    /// </summary>
    public StringEnumValue<LicenseAuthType> BizLicenseAuthType { get => _bizLicenseAuthType; set => SetField(ref _bizLicenseAuthType, value); }

    /// <summary>
    /// ContactContract BizLicenseNumber
    /// </summary>
    public string? BizLicenseNumber { get => _bizLicenseNumber; set => SetField(ref _bizLicenseNumber, value); }

    /// <summary>
    /// File Contacts General Contractor BorrowerActingAsContractorIndicator [VEND.X1009]
    /// </summary>
    public bool? BorrowerActingAsContractorIndicator { get => _borrowerActingAsContractorIndicator; set => SetField(ref _borrowerActingAsContractorIndicator, value); }

    /// <summary>
    /// ContactContract BrokerLenderType
    /// </summary>
    public string? BrokerLenderType { get => _brokerLenderType; set => SetField(ref _brokerLenderType, value); }

    /// <summary>
    /// ContactContract BrokerLicenseExempt
    /// </summary>
    public bool? BrokerLicenseExempt { get => _brokerLicenseExempt; set => SetField(ref _brokerLicenseExempt, value); }

    /// <summary>
    /// ContactContract BrokerLicenseType
    /// </summary>
    public string? BrokerLicenseType { get => _brokerLicenseType; set => SetField(ref _brokerLicenseType, value); }

    /// <summary>
    /// ContactContract BusinessPhone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhone { get => _businessPhone; set => SetField(ref _businessPhone, value); }

    /// <summary>
    /// ContactContract CategoryName
    /// </summary>
    public string? CategoryName { get => _categoryName; set => SetField(ref _categoryName, value); }

    /// <summary>
    /// ContactContract Cell
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Cell { get => _cell; set => SetField(ref _cell, value); }

    /// <summary>
    /// File Contacts Broker Check Confirmed Date [VEND.X368]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? CheckConfirmedDate { get => _checkConfirmedDate; set => SetField(ref _checkConfirmedDate, value); }

    /// <summary>
    /// ContactContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// File Contacts Mortgagee Clause [VEND.X496]
    /// </summary>
    public string? Clause { get => _clause; set => SetField(ref _clause, value); }

    /// <summary>
    /// File Contacts Settlement Agent - Closing Agent Web URL [VEND.X1041]
    /// </summary>
    public string? ClosingAgentWebUrl { get => _closingAgentWebUrl; set => SetField(ref _closingAgentWebUrl, value); }

    /// <summary>
    /// File Contacts Settlement Agent - Closing Company Web URL [VEND.X1040]
    /// </summary>
    public string? ClosingCompanyWebUrl { get => _closingCompanyWebUrl; set => SetField(ref _closingCompanyWebUrl, value); }

    /// <summary>
    /// ContactContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// File Contacts Broker Lender Company ID [3237]
    /// </summary>
    public string? CompanyId { get => _companyId; set => SetField(ref _companyId, value); }

    /// <summary>
    /// File Contacts General Contractor Completion Affidavit Punch List Total [VEND.X1024]
    /// </summary>
    public decimal? CompletionAffidavitPunchListTotal { get => _completionAffidavitPunchListTotal; set => SetField(ref _completionAffidavitPunchListTotal, value); }

    /// <summary>
    /// ContactContract ContactName
    /// </summary>
    public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

    /// <summary>
    /// File Contacts Settlement Agent Contact NMLS Number [VEND.X675]
    /// </summary>
    public string? ContactNmlsNo { get => _contactNmlsNo; set => SetField(ref _contactNmlsNo, value); }

    /// <summary>
    /// ContactContract ContactRef
    /// </summary>
    [AllowNull]
    public EntityReference ContactRef { get => GetField(ref _contactRef); set => SetField(ref _contactRef, value); }

    /// <summary>
    /// ContactContract ContactTitle
    /// </summary>
    public string? ContactTitle { get => _contactTitle; set => SetField(ref _contactTitle, value); }

    /// <summary>
    /// ContactContract ContactType
    /// </summary>
    public StringEnumValue<ContactType> ContactType { get => _contactType; set => SetField(ref _contactType, value); }

    /// <summary>
    /// ContactContract Country
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// ContactContract CustomContactIndex
    /// </summary>
    public int? CustomContactIndex { get => _customContactIndex; set => SetField(ref _customContactIndex, value); }

    /// <summary>
    /// Appointment Of Designee DesigneeAcceptedDate [VEND.X1026]
    /// </summary>
    public DateTime? DesigneeAcceptedDate { get => _designeeAcceptedDate; set => SetField(ref _designeeAcceptedDate, value); }

    /// <summary>
    /// ContactContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// File Contacts General Contractor Employer Liability Insurance Min [VEND.X1018]
    /// </summary>
    public decimal? EmployerLiabilityInsuranceMin { get => _employerLiabilityInsuranceMin; set => SetField(ref _employerLiabilityInsuranceMin, value); }

    /// <summary>
    /// ContactContract Fax
    /// </summary>
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// File Contacts Submitting Broker - Lender Fax [2844]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax2 { get => _fax2; set => SetField(ref _fax2, value); }

    /// <summary>
    /// File Contacts Warehouse Fed Reference # [VEND.X1046]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FedReferenceNumber { get => _fedReferenceNumber; set => SetField(ref _fedReferenceNumber, value); }

    /// <summary>
    /// FHA Lender ID [1059]
    /// </summary>
    public string? FhaLenderId { get => _fhaLenderId; set => SetField(ref _fhaLenderId, value); }

    /// <summary>
    /// ContactContract ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// File Contacts Warehouse Funds to Title Date [VEND.X1045]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? FundsToTitleDate { get => _fundsToTitleDate; set => SetField(ref _fundsToTitleDate, value); }

    /// <summary>
    /// File Contacts General Contractor General Liability Insurance Min [VEND.X1017]
    /// </summary>
    public decimal? GeneralLiabilityInsuranceMin { get => _generalLiabilityInsuranceMin; set => SetField(ref _generalLiabilityInsuranceMin, value); }

    /// <summary>
    /// Underwriting Flood Info Cert Number [2363]
    /// </summary>
    public string? InsuranceCertNumber { get => _insuranceCertNumber; set => SetField(ref _insuranceCertNumber, value); }

    /// <summary>
    /// ContactContract InsuranceCoverageAmount [VEND.X445], [VEND.X446]
    /// </summary>
    public decimal? InsuranceCoverageAmount { get => _insuranceCoverageAmount; set => SetField(ref _insuranceCoverageAmount, value); }

    /// <summary>
    /// Underwriting Flood Info Determination Date [2365]
    /// </summary>
    public DateTime? InsuranceDeterminationDate { get => _insuranceDeterminationDate; set => SetField(ref _insuranceDeterminationDate, value); }

    /// <summary>
    /// Underwriting Flood Info Determination Number [2364]
    /// </summary>
    public string? InsuranceDeterminationNumber { get => _insuranceDeterminationNumber; set => SetField(ref _insuranceDeterminationNumber, value); }

    /// <summary>
    /// Underwriting Flood Info Flood Zone [2366]
    /// </summary>
    public bool? InsuranceFloodZone { get => _insuranceFloodZone; set => SetField(ref _insuranceFloodZone, value); }

    /// <summary>
    /// Underwriting Property Info Map ID [2368]
    /// </summary>
    public string? InsuranceMap { get => _insuranceMap; set => SetField(ref _insuranceMap, value); }

    /// <summary>
    /// Underwriting Property Info Number of Bedrooms [2369]
    /// </summary>
    public int? InsuranceNoOfBedrooms { get => _insuranceNoOfBedrooms; set => SetField(ref _insuranceNoOfBedrooms, value); }

    /// <summary>
    /// ContactContract InsurancePremium [VEND.X443], [VEND.X447]
    /// </summary>
    public decimal? InsurancePremium { get => _insurancePremium; set => SetField(ref _insurancePremium, value); }

    /// <summary>
    /// Underwriting Property Info Project Type [2367]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"V_NoReviewSiteCondo\",\"ExemptFromReview\",\"FullReviewCoopProject\",\"FannieMaeReviewPERSCoopProject\"]")]
    public StringEnumValue<ProjectType> InsuranceProjectType { get => _insuranceProjectType; set => SetField(ref _insuranceProjectType, value); }

    /// <summary>
    /// ContactContract InsuranceRenewalDate [VEND.X444], [VEND.X448]
    /// </summary>
    public DateTime? InsuranceRenewalDate { get => _insuranceRenewalDate; set => SetField(ref _insuranceRenewalDate, value); }

    /// <summary>
    /// Underwriting Investor Info Grade 1 [2343]
    /// </summary>
    public string? InvestorGrade1 { get => _investorGrade1; set => SetField(ref _investorGrade1, value); }

    /// <summary>
    /// Underwriting Investor Info Grade 2 [2346]
    /// </summary>
    public string? InvestorGrade2 { get => _investorGrade2; set => SetField(ref _investorGrade2, value); }

    /// <summary>
    /// Underwriting Investor Info Grade 3 [2349]
    /// </summary>
    public string? InvestorGrade3 { get => _investorGrade3; set => SetField(ref _investorGrade3, value); }

    /// <summary>
    /// File Contacts Investor License # [VEND.X650]
    /// </summary>
    public string? InvestorLicense { get => _investorLicense; set => SetField(ref _investorLicense, value); }

    /// <summary>
    /// ContactContract InvestorLicenseType
    /// </summary>
    public string? InvestorLicenseType { get => _investorLicenseType; set => SetField(ref _investorLicenseType, value); }

    /// <summary>
    /// Underwriting Investor Info Name 1 [2342]
    /// </summary>
    public string? InvestorName1 { get => _investorName1; set => SetField(ref _investorName1, value); }

    /// <summary>
    /// Underwriting Investor Info Name 2 [2345]
    /// </summary>
    public string? InvestorName2 { get => _investorName2; set => SetField(ref _investorName2, value); }

    /// <summary>
    /// Underwriting Investor Info Name 3 [2348]
    /// </summary>
    public string? InvestorName3 { get => _investorName3; set => SetField(ref _investorName3, value); }

    /// <summary>
    /// Underwriting Investor Info Score 1 [2344]
    /// </summary>
    public string? InvestorScore1 { get => _investorScore1; set => SetField(ref _investorScore1, value); }

    /// <summary>
    /// Underwriting Investor Info Score 2 [2347]
    /// </summary>
    public string? InvestorScore2 { get => _investorScore2; set => SetField(ref _investorScore2, value); }

    /// <summary>
    /// Underwriting Investor Info Score 3 [2350]
    /// </summary>
    public string? InvestorScore3 { get => _investorScore3; set => SetField(ref _investorScore3, value); }

    /// <summary>
    /// ContactContract JobTitle
    /// </summary>
    public string? JobTitle { get => _jobTitle; set => SetField(ref _jobTitle, value); }

    /// <summary>
    /// ContactContract LenderType [3895], [VEND.X651]
    /// </summary>
    public string? LenderType { get => _lenderType; set => SetField(ref _lenderType, value); }

    /// <summary>
    /// ContactContract License
    /// </summary>
    public string? License { get => _license; set => SetField(ref _license, value); }

    /// <summary>
    /// ContactContract LicenseExempt [3898], [VEND.X653]
    /// </summary>
    public bool? LicenseExempt { get => _licenseExempt; set => SetField(ref _licenseExempt, value); }

    /// <summary>
    /// File Contacts-Lender License Home State [3896]
    /// </summary>
    public string? LicenseHomeState { get => _licenseHomeState; set => SetField(ref _licenseHomeState, value); }

    /// <summary>
    /// ContactContract LicenseType
    /// </summary>
    public string? LicenseType { get => _licenseType; set => SetField(ref _licenseType, value); }

    /// <summary>
    /// ContactContract LineItemNumber
    /// </summary>
    public string? LineItemNumber { get => _lineItemNumber; set => SetField(ref _lineItemNumber, value); }

    /// <summary>
    /// ContactContract LoginId
    /// </summary>
    public string? LoginId { get => _loginId; set => SetField(ref _loginId, value); }

    /// <summary>
    /// File Contacts Broker - Mortgage Broker Company Web URL [VEND.X1036]
    /// </summary>
    public string? MortgageBrokerCompanyWebUrl { get => _mortgageBrokerCompanyWebUrl; set => SetField(ref _mortgageBrokerCompanyWebUrl, value); }

    /// <summary>
    /// File Contacts Broker - Mortgage Broker Loan Officer Web URL [VEND.X1037]
    /// </summary>
    public string? MortgageBrokerLoanOfficerWebUrl { get => _mortgageBrokerLoanOfficerWebUrl; set => SetField(ref _mortgageBrokerLoanOfficerWebUrl, value); }

    /// <summary>
    /// File Contacts Lender - Mortgage Lender Company Web URL [VEND.X1034]
    /// </summary>
    public string? MortgageLenderCompanyWebUrl { get => _mortgageLenderCompanyWebUrl; set => SetField(ref _mortgageLenderCompanyWebUrl, value); }

    /// <summary>
    /// File Contacts Lender - Mortgage Lender Loan Officer Web URL [VEND.X1035]
    /// </summary>
    public string? MortgageLenderLoanOfficerWebUrl { get => _mortgageLenderLoanOfficerWebUrl; set => SetField(ref _mortgageLenderLoanOfficerWebUrl, value); }

    /// <summary>
    /// ContactContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// ContactContract NmlsLicense
    /// </summary>
    public string? NmlsLicense { get => _nmlsLicense; set => SetField(ref _nmlsLicense, value); }

    /// <summary>
    /// ContactContract NotNaturalPersonFlag
    /// </summary>
    public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => SetField(ref _notNaturalPersonFlag, value); }

    /// <summary>
    /// ContactContract OrganizationState
    /// </summary>
    public string? OrganizationState { get => _organizationState; set => SetField(ref _organizationState, value); }

    /// <summary>
    /// ContactContract OrganizationType
    /// </summary>
    public string? OrganizationType { get => _organizationType; set => SetField(ref _organizationType, value); }

    /// <summary>
    /// ContactContract PersonalLicenseAuthDate
    /// </summary>
    public DateTime? PersonalLicenseAuthDate { get => _personalLicenseAuthDate; set => SetField(ref _personalLicenseAuthDate, value); }

    /// <summary>
    /// ContactContract PersonalLicenseAuthName
    /// </summary>
    public string? PersonalLicenseAuthName { get => _personalLicenseAuthName; set => SetField(ref _personalLicenseAuthName, value); }

    /// <summary>
    /// ContactContract PersonalLicenseAuthStateCode
    /// </summary>
    public string? PersonalLicenseAuthStateCode { get => _personalLicenseAuthStateCode; set => SetField(ref _personalLicenseAuthStateCode, value); }

    /// <summary>
    /// ContactContract PersonalLicenseAuthType
    /// </summary>
    public StringEnumValue<LicenseAuthType> PersonalLicenseAuthType { get => _personalLicenseAuthType; set => SetField(ref _personalLicenseAuthType, value); }

    /// <summary>
    /// ContactContract PersonalLicenseNumber
    /// </summary>
    public string? PersonalLicenseNumber { get => _personalLicenseNumber; set => SetField(ref _personalLicenseNumber, value); }

    /// <summary>
    /// ContactContract Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// ContactContract Phone2 [2843], [VEND.X304]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone2 { get => _phone2; set => SetField(ref _phone2, value); }

    /// <summary>
    /// ContactContract PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// File Contacts Broker - Real Estate Agency Web URL [VEND.X1038]
    /// </summary>
    public string? RealEstateAgencyWebUrl { get => _realEstateAgencyWebUrl; set => SetField(ref _realEstateAgencyWebUrl, value); }

    /// <summary>
    /// File Contacts Broker - Real Estate Agent Web URL [VEND.X1039]
    /// </summary>
    public string? RealEstateAgentWebUrl { get => _realEstateAgentWebUrl; set => SetField(ref _realEstateAgentWebUrl, value); }

    /// <summary>
    /// File Contacts Broker Rec City [VEND.X308]
    /// </summary>
    public string? RecCity { get => _recCity; set => SetField(ref _recCity, value); }

    /// <summary>
    /// ContactContract ReferenceNumber
    /// </summary>
    public string? ReferenceNumber { get => _referenceNumber; set => SetField(ref _referenceNumber, value); }

    /// <summary>
    /// ContactContract Relationship
    /// </summary>
    public string? Relationship { get => _relationship; set => SetField(ref _relationship, value); }

    /// <summary>
    /// ContactContract SettlementAgent
    /// </summary>
    public bool? SettlementAgent { get => _settlementAgent; set => SetField(ref _settlementAgent, value); }

    /// <summary>
    /// ContactContract State
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// ContactContract TaxId
    /// </summary>
    public string? TaxId { get => _taxId; set => SetField(ref _taxId, value); }

    /// <summary>
    /// TQL Comment History [3355]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlCommentHistory { get => _tqlCommentHistory; set => SetField(ref _tqlCommentHistory, value); }

    /// <summary>
    /// Consent Selection in TQL Portal [CCVP.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlConsentSelection { get => _tqlConsentSelection; set => SetField(ref _tqlConsentSelection, value); }

    /// <summary>
    /// TQL InvestorID [3318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TqlId { get => _tqlId; set => SetField(ref _tqlId, value); }

    /// <summary>
    /// Is Published to Investor [3333]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? TqlIsPublishingIndicator { get => _tqlIsPublishingIndicator; set => SetField(ref _tqlIsPublishingIndicator, value); }

    /// <summary>
    /// TQL Investor Name [3317]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlName { get => _tqlName; set => SetField(ref _tqlName, value); }

    /// <summary>
    /// File Contacts Warehouse ID [VEND.X1043]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseId { get => _warehouseId; set => SetField(ref _warehouseId, value); }

    /// <summary>
    /// File Contacts Warehouse Lender [VEND.X1042]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseLender { get => _warehouseLender; set => SetField(ref _warehouseLender, value); }

    /// <summary>
    /// File Contacts Warehouse URL [VEND.X1044]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseUrl { get => _warehouseUrl; set => SetField(ref _warehouseUrl, value); }
}