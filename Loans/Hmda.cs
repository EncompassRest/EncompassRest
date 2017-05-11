using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hmda
    {
        public string LoanPurpose { get; set; }
        public string MSANumber { get; set; }
        public string CensusTrack { get; set; }
        public string ActionTaken { get; set; }
        public string StateCode { get; set; }
        public string CountyCode { get; set; }
        public string TypeOfPurchaser { get; set; }
        public string PropertyType { get; set; }
        public string Preapprovals { get; set; }
        public string HOEPAStatus { get; set; }
        public string LienStatus { get; set; }
        public decimal? RateSpread { get; set; }
        public string DenialReason1 { get; set; }
        public string DenialReason2 { get; set; }
        public string DenialReason3 { get; set; }
        public bool? ExcludeLoanFromHMDAReportIndicator { get; set; }
        public bool? ReportPurposeOfLoanIndicator { get; set; }
        public string QMStatus { get; set; }
        public int? ReportingYear { get; set; }
        public string UniversalLoanId { get; set; }
        public string ApplicationDate { get; set; }
        public string LoanType { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? Income { get; set; }
        public string DenialReason4 { get; set; }
        public string OtherDenialReason { get; set; }
        public decimal? DiscountPoints { get; set; }
        public decimal? DebtToIncomeRatio { get; set; }
        public decimal? CLTV { get; set; }
        public string OtherNonAmortization { get; set; }
        public string ManufacturedSecuredProperyType { get; set; }
        public string ManufacturedHomeLandPropertyInterest { get; set; }
        public string MultifamilyNoUnits { get; set; }
        public string SubmissionOfApplication { get; set; }
        public string InitiallyPayableToYourInstitution { get; set; }
        public string AUS1 { get; set; }
        public string AUS2 { get; set; }
        public string AUS3 { get; set; }
        public string AUS4 { get; set; }
        public string AUS5 { get; set; }
        public string OtherAUS { get; set; }
        public string AUSRecommendation1 { get; set; }
        public string AUSRecommendation2 { get; set; }
        public string AUSRecommendation3 { get; set; }
        public string AUSRecommendation4 { get; set; }
        public string AUSRecommendation5 { get; set; }
        public string OtherAUSRecommendations { get; set; }
        public string ReverseMortgage { get; set; }
        public string OpenEndLineOfCredit { get; set; }
        public string BusinessOrCommercialPurpose { get; set; }
        public string FinancialInstitutionName { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactOfficeStreetAddress { get; set; }
        public string ContactOfficeCity { get; set; }
        public string ContactOfficeState { get; set; }
        public string ContactOfficeZIPCode { get; set; }
        public string ContactFaxNumber { get; set; }
        public string FederalAgency { get; set; }
        public string FederalTaxpayerIdNumber { get; set; }
        public string LegalEntityIdentifier { get; set; }
        public string RespondentID { get; set; }
        public string ParentName { get; set; }
        public string ParentAddress { get; set; }
        public string ParentCity { get; set; }
        public string ParentState { get; set; }
        public string ParentZip { get; set; }
        public decimal? TotalLoanCosts { get; set; }
        public decimal? TotalPointsAndFees { get; set; }
        public decimal? OriginationCharges { get; set; }
        public decimal? LenderCredits { get; set; }
        public decimal? InterestRate { get; set; }
        public string PrepaymentPenaltyPeriod { get; set; }
        public string LoanTerm { get; set; }
        public string IntroRatePeriod { get; set; }
        public decimal? PropertyValue { get; set; }
        public string NMLSLoanOriginatorID { get; set; }
        public string HmdaPropertyZipCode { get; set; }
        public string Id { get; set; }
    }
}