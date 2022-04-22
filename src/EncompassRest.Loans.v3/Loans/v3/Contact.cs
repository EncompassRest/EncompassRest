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
    /// <summary>
    /// Contact Aba
    /// </summary>
    public string? Aba { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact AccountName
    /// </summary>
    public string? AccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Address
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker Lender Address 2 [1954]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Address2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact AddToCdContactInfo
    /// </summary>
    public bool? AddToCdContactInfo { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Appraisal Co Appraisal Made (As Is or As Improved) [4091]
    /// </summary>
    public StringEnumValue<AppraisalMade> AppraisalMade { get => GetValue<StringEnumValue<AppraisalMade>>(); set => SetValue(value); }

    /// <summary>
    /// Contact BizLicenseAuthDate
    /// </summary>
    public DateTime? BizLicenseAuthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BizLicenseAuthName
    /// </summary>
    public string? BizLicenseAuthName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BizLicenseAuthStateCode
    /// </summary>
    public string? BizLicenseAuthStateCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BizLicenseAuthType
    /// </summary>
    public StringEnumValue<LicenseAuthType> BizLicenseAuthType { get => GetValue<StringEnumValue<LicenseAuthType>>(); set => SetValue(value); }

    /// <summary>
    /// Contact BizLicenseNumber
    /// </summary>
    public string? BizLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts General Contractor BorrowerActingAsContractorIndicator [VEND.X1009]
    /// </summary>
    public bool? BorrowerActingAsContractorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BrokerLenderType
    /// </summary>
    public string? BrokerLenderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BrokerLicenseExempt
    /// </summary>
    public bool? BrokerLicenseExempt { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BrokerLicenseType
    /// </summary>
    public string? BrokerLicenseType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact BusinessPhone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact CategoryName
    /// </summary>
    public string? CategoryName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Cell
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Cell { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker Check Confirmed Date [VEND.X368]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? CheckConfirmedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Contact City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Mortgagee Clause [VEND.X496]
    /// </summary>
    public string? Clause { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Settlement Agent - Closing Agent Web URL [VEND.X1041]
    /// </summary>
    public string? ClosingAgentWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Settlement Agent - Closing Company Web URL [VEND.X1040]
    /// </summary>
    public string? ClosingCompanyWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker Lender Company ID [3237]
    /// </summary>
    public string? CompanyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts General Contractor Completion Affidavit Punch List Total [VEND.X1024]
    /// </summary>
    public decimal? CompletionAffidavitPunchListTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Contact ContactName
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Settlement Agent Contact NMLS Number [VEND.X675]
    /// </summary>
    public string? ContactNmlsNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact ContactRef
    /// </summary>
    [AllowNull]
    public EntityReference ContactRef { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Contact ContactTitle
    /// </summary>
    public string? ContactTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact ContactType
    /// </summary>
    public StringEnumValue<ContactType> ContactType { get => GetValue<StringEnumValue<ContactType>>(); set => SetValue(value); }

    /// <summary>
    /// Contact Country
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact CustomContactIndex
    /// </summary>
    public int? CustomContactIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Appointment Of Designee DesigneeAcceptedDate [VEND.X1026]
    /// </summary>
    public DateTime? DesigneeAcceptedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts General Contractor Employer Liability Insurance Min [VEND.X1018]
    /// </summary>
    public decimal? EmployerLiabilityInsuranceMin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Fax
    /// </summary>
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Submitting Broker - Lender Fax [2844]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Warehouse Fed Reference # [VEND.X1046]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FedReferenceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Lender ID [1059]
    /// </summary>
    public string? FhaLenderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact ForeignAddressIndicator
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Warehouse Funds to Title Date [VEND.X1045]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? FundsToTitleDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts General Contractor General Liability Insurance Min [VEND.X1017]
    /// </summary>
    public decimal? GeneralLiabilityInsuranceMin { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Flood Info Cert Number [2363]
    /// </summary>
    public string? InsuranceCertNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact InsuranceCoverageAmount [VEND.X445], [VEND.X446]
    /// </summary>
    public decimal? InsuranceCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Flood Info Determination Date [2365]
    /// </summary>
    public DateTime? InsuranceDeterminationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Flood Info Determination Number [2364]
    /// </summary>
    public string? InsuranceDeterminationNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Flood Info Flood Zone [2366]
    /// </summary>
    public bool? InsuranceFloodZone { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Property Info Map ID [2368]
    /// </summary>
    public string? InsuranceMap { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Property Info Number of Bedrooms [2369]
    /// </summary>
    public int? InsuranceNoOfBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Contact InsurancePremium [VEND.X443], [VEND.X447]
    /// </summary>
    public decimal? InsurancePremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Property Info Project Type [2367]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"V_NoReviewSiteCondo\",\"ExemptFromReview\",\"FullReviewCoopProject\",\"FannieMaeReviewPERSCoopProject\"]")]
    public StringEnumValue<ProjectType> InsuranceProjectType { get => GetValue<StringEnumValue<ProjectType>>(); set => SetValue(value); }

    /// <summary>
    /// Contact InsuranceRenewalDate [VEND.X444], [VEND.X448]
    /// </summary>
    public DateTime? InsuranceRenewalDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Grade 1 [2343]
    /// </summary>
    public string? InvestorGrade1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Grade 2 [2346]
    /// </summary>
    public string? InvestorGrade2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Grade 3 [2349]
    /// </summary>
    public string? InvestorGrade3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Investor License # [VEND.X650]
    /// </summary>
    public string? InvestorLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact InvestorLicenseType
    /// </summary>
    public string? InvestorLicenseType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Name 1 [2342]
    /// </summary>
    public string? InvestorName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Name 2 [2345]
    /// </summary>
    public string? InvestorName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Name 3 [2348]
    /// </summary>
    public string? InvestorName3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Score 1 [2344]
    /// </summary>
    public string? InvestorScore1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Score 2 [2347]
    /// </summary>
    public string? InvestorScore2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Investor Info Score 3 [2350]
    /// </summary>
    public string? InvestorScore3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact JobTitle
    /// </summary>
    public string? JobTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact LenderType [3895], [VEND.X651]
    /// </summary>
    public string? LenderType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact License
    /// </summary>
    public string? License { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact LicenseExempt [3898], [VEND.X653]
    /// </summary>
    public bool? LicenseExempt { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts-Lender License Home State [3896]
    /// </summary>
    public string? LicenseHomeState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact LicenseType
    /// </summary>
    public string? LicenseType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact LineItemNumber
    /// </summary>
    public string? LineItemNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact LoginId
    /// </summary>
    public string? LoginId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker - Mortgage Broker Company Web URL [VEND.X1036]
    /// </summary>
    public string? MortgageBrokerCompanyWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker - Mortgage Broker Loan Officer Web URL [VEND.X1037]
    /// </summary>
    public string? MortgageBrokerLoanOfficerWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Lender - Mortgage Lender Company Web URL [VEND.X1034]
    /// </summary>
    public string? MortgageLenderCompanyWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Lender - Mortgage Lender Loan Officer Web URL [VEND.X1035]
    /// </summary>
    public string? MortgageLenderLoanOfficerWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact NmlsLicense
    /// </summary>
    public string? NmlsLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact NotNaturalPersonFlag
    /// </summary>
    public bool? NotNaturalPersonFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Contact OrganizationState
    /// </summary>
    public string? OrganizationState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact OrganizationType
    /// </summary>
    public string? OrganizationType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact PersonalLicenseAuthDate
    /// </summary>
    public DateTime? PersonalLicenseAuthDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Contact PersonalLicenseAuthName
    /// </summary>
    public string? PersonalLicenseAuthName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact PersonalLicenseAuthStateCode
    /// </summary>
    public string? PersonalLicenseAuthStateCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact PersonalLicenseAuthType
    /// </summary>
    public StringEnumValue<LicenseAuthType> PersonalLicenseAuthType { get => GetValue<StringEnumValue<LicenseAuthType>>(); set => SetValue(value); }

    /// <summary>
    /// Contact PersonalLicenseNumber
    /// </summary>
    public string? PersonalLicenseNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Phone
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Phone2 [2843], [VEND.X304]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker - Real Estate Agency Web URL [VEND.X1038]
    /// </summary>
    public string? RealEstateAgencyWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker - Real Estate Agent Web URL [VEND.X1039]
    /// </summary>
    public string? RealEstateAgentWebUrl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker Rec City [VEND.X308]
    /// </summary>
    public string? RecCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact ReferenceNumber
    /// </summary>
    public string? ReferenceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact Relationship
    /// </summary>
    public string? Relationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact SettlementAgent
    /// </summary>
    public bool? SettlementAgent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Contact State
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Contact TaxId
    /// </summary>
    public string? TaxId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL Comment History [3355]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlCommentHistory { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Consent Selection in TQL Portal [CCVP.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlConsentSelection { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL InvestorID [3318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TqlId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Is Published to Investor [3333]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? TqlIsPublishingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// TQL Investor Name [3317]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TqlName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Warehouse ID [VEND.X1043]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Warehouse Lender [VEND.X1042]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseLender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Warehouse URL [VEND.X1044]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WarehouseUrl { get => GetValue<string?>(); set => SetValue(value); }
}