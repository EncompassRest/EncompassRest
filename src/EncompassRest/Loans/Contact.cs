using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Contact
    {
        public string ABA { get; set; }
        public string AccountName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public JsonNullable<bool?> AddToCdContactInfo { get; set; }
        public string AppraisalMade { get; set; }
        public JsonNullable<DateTime?> BizLicenseAuthDate { get; set; }
        public string BizLicenseAuthName { get; set; }
        public string BizLicenseAuthStateCode { get; set; }
        public string BizLicenseAuthType { get; set; }
        public string BizLicenseNumber { get; set; }
        public JsonNullable<bool?> BorrowerActingAsContractorIndicator { get; set; }
        public string BrokerLenderType { get; set; }
        public JsonNullable<bool?> BrokerLicenseExempt { get; set; }
        public string BrokerLicenseType { get; set; }
        public string BusinessPhone { get; set; }
        public string CategoryName { get; set; }
        public string Cell { get; set; }
        public JsonNullable<DateTime?> CheckConfirmedDate { get; set; }
        public string City { get; set; }
        public string Clause { get; set; }
        public string Comments { get; set; }
        public string CompanyId { get; set; }
        public JsonNullable<decimal?> CompletionAffidavitPunchListTotal { get; set; }
        public int? ContactIndex { get; set; }
        public string ContactName { get; set; }
        public string ContactNMLSNo { get; set; }
        public string ContactTitle { get; set; }
        public string ContactType { get; set; }
        public JsonNullable<DateTime?> DesigneeAcceptedDate { get; set; }
        public string Email { get; set; }
        public JsonNullable<decimal?> EmployerLiabilityInsuranceMin { get; set; }
        public string Fax { get; set; }
        public string Fax2 { get; set; }
        public string FhaLenderId { get; set; }
        public JsonNullable<decimal?> GeneralLiabilityInsuranceMin { get; set; }
        public string Id { get; set; }
        public string InsuranceCertNumber { get; set; }
        public JsonNullable<decimal?> InsuranceCoverageAmount { get; set; }
        public JsonNullable<DateTime?> InsuranceDeterminationDate { get; set; }
        public string InsuranceDeterminationNumber { get; set; }
        public JsonNullable<bool?> InsuranceFloodZone { get; set; }
        public string InsuranceMap { get; set; }
        public JsonNullable<int?> InsuranceNoOfBedrooms { get; set; }
        public JsonNullable<decimal?> InsurancePremium { get; set; }
        public string InsuranceProjectType { get; set; }
        public JsonNullable<DateTime?> InsuranceRenewalDate { get; set; }
        public string InvestorGrade1 { get; set; }
        public string InvestorGrade2 { get; set; }
        public string InvestorGrade3 { get; set; }
        public string InvestorLicense { get; set; }
        public string InvestorLicenseType { get; set; }
        public string InvestorName1 { get; set; }
        public string InvestorName2 { get; set; }
        public string InvestorName3 { get; set; }
        public string InvestorScore1 { get; set; }
        public string InvestorScore2 { get; set; }
        public string InvestorScore3 { get; set; }
        public string LenderType { get; set; }
        public string License { get; set; }
        public JsonNullable<bool?> LicenseExempt { get; set; }
        public string LicenseHomeState { get; set; }
        public string LicenseType { get; set; }
        public string LineItemNumber { get; set; }
        public string LoginId { get; set; }
        public string Name { get; set; }
        public string NmlsLicense { get; set; }
        public JsonNullable<bool?> NotNaturalPersonFlag { get; set; }
        public string OrganizationState { get; set; }
        public string OrganizationType { get; set; }
        public JsonNullable<DateTime?> PersonalLicenseAuthDate { get; set; }
        public string PersonalLicenseAuthName { get; set; }
        public string PersonalLicenseAuthStateCode { get; set; }
        public string PersonalLicenseAuthType { get; set; }
        public string PersonalLicenseNumber { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string PostalCode { get; set; }
        public string RecCity { get; set; }
        public string ReferenceNumber { get; set; }
        public string Relationship { get; set; }
        public JsonNullable<bool?> SettlementAgent { get; set; }
        public string State { get; set; }
        public string TaxID { get; set; }
        public string TqlCommentHistory { get; set; }
        public string TQLConsentSelection { get; set; }
        public JsonNullable<int?> TqlId { get; set; }
        public JsonNullable<bool?> TqlIsPublishingIndicator { get; set; }
        public string TqlName { get; set; }
    }
}