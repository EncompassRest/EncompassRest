using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hmda : IClean
    {
        private Value<string> _actionTaken;
        public string ActionTaken { get { return _actionTaken; } set { _actionTaken = value; } }
        private Value<string> _applicationDate;
        public string ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _aUS1;
        public string AUS1 { get { return _aUS1; } set { _aUS1 = value; } }
        private Value<string> _aUS2;
        public string AUS2 { get { return _aUS2; } set { _aUS2 = value; } }
        private Value<string> _aUS3;
        public string AUS3 { get { return _aUS3; } set { _aUS3 = value; } }
        private Value<string> _aUS4;
        public string AUS4 { get { return _aUS4; } set { _aUS4 = value; } }
        private Value<string> _aUS5;
        public string AUS5 { get { return _aUS5; } set { _aUS5 = value; } }
        private Value<string> _aUSRecommendation1;
        public string AUSRecommendation1 { get { return _aUSRecommendation1; } set { _aUSRecommendation1 = value; } }
        private Value<string> _aUSRecommendation2;
        public string AUSRecommendation2 { get { return _aUSRecommendation2; } set { _aUSRecommendation2 = value; } }
        private Value<string> _aUSRecommendation3;
        public string AUSRecommendation3 { get { return _aUSRecommendation3; } set { _aUSRecommendation3 = value; } }
        private Value<string> _aUSRecommendation4;
        public string AUSRecommendation4 { get { return _aUSRecommendation4; } set { _aUSRecommendation4 = value; } }
        private Value<string> _aUSRecommendation5;
        public string AUSRecommendation5 { get { return _aUSRecommendation5; } set { _aUSRecommendation5 = value; } }
        private Value<string> _businessOrCommercialPurpose;
        public string BusinessOrCommercialPurpose { get { return _businessOrCommercialPurpose; } set { _businessOrCommercialPurpose = value; } }
        private Value<string> _censusTrack;
        public string CensusTrack { get { return _censusTrack; } set { _censusTrack = value; } }
        private Value<NA<decimal>?> _cLTV;
        public NA<decimal>? CLTV { get { return _cLTV; } set { _cLTV = value; } }
        private Value<string> _contactEmailAddress;
        public string ContactEmailAddress { get { return _contactEmailAddress; } set { _contactEmailAddress = value; } }
        private Value<string> _contactFaxNumber;
        public string ContactFaxNumber { get { return _contactFaxNumber; } set { _contactFaxNumber = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<string> _contactOfficeCity;
        public string ContactOfficeCity { get { return _contactOfficeCity; } set { _contactOfficeCity = value; } }
        private Value<string> _contactOfficeState;
        public string ContactOfficeState { get { return _contactOfficeState; } set { _contactOfficeState = value; } }
        private Value<string> _contactOfficeStreetAddress;
        public string ContactOfficeStreetAddress { get { return _contactOfficeStreetAddress; } set { _contactOfficeStreetAddress = value; } }
        private Value<string> _contactOfficeZIPCode;
        public string ContactOfficeZIPCode { get { return _contactOfficeZIPCode; } set { _contactOfficeZIPCode = value; } }
        private Value<string> _contactPhoneNumber;
        public string ContactPhoneNumber { get { return _contactPhoneNumber; } set { _contactPhoneNumber = value; } }
        private Value<string> _countyCode;
        public string CountyCode { get { return _countyCode; } set { _countyCode = value; } }
        private Value<NA<decimal>?> _debtToIncomeRatio;
        public NA<decimal>? DebtToIncomeRatio { get { return _debtToIncomeRatio; } set { _debtToIncomeRatio = value; } }
        private Value<string> _denialReason1;
        public string DenialReason1 { get { return _denialReason1; } set { _denialReason1 = value; } }
        private Value<string> _denialReason2;
        public string DenialReason2 { get { return _denialReason2; } set { _denialReason2 = value; } }
        private Value<string> _denialReason3;
        public string DenialReason3 { get { return _denialReason3; } set { _denialReason3 = value; } }
        private Value<string> _denialReason4;
        public string DenialReason4 { get { return _denialReason4; } set { _denialReason4 = value; } }
        private Value<NA<decimal>?> _discountPoints;
        public NA<decimal>? DiscountPoints { get { return _discountPoints; } set { _discountPoints = value; } }
        private Value<bool?> _excludeLoanFromHMDAReportIndicator;
        public bool? ExcludeLoanFromHMDAReportIndicator { get { return _excludeLoanFromHMDAReportIndicator; } set { _excludeLoanFromHMDAReportIndicator = value; } }
        private Value<string> _federalAgency;
        public string FederalAgency { get { return _federalAgency; } set { _federalAgency = value; } }
        private Value<string> _federalTaxpayerIdNumber;
        public string FederalTaxpayerIdNumber { get { return _federalTaxpayerIdNumber; } set { _federalTaxpayerIdNumber = value; } }
        private Value<string> _financialInstitutionName;
        public string FinancialInstitutionName { get { return _financialInstitutionName; } set { _financialInstitutionName = value; } }
        private Value<string> _hmdaPropertyAddress;
        public string HmdaPropertyAddress { get { return _hmdaPropertyAddress; } set { _hmdaPropertyAddress = value; } }
        private Value<string> _hmdaPropertyCity;
        public string HmdaPropertyCity { get { return _hmdaPropertyCity; } set { _hmdaPropertyCity = value; } }
        private Value<string> _hmdaPropertyState;
        public string HmdaPropertyState { get { return _hmdaPropertyState; } set { _hmdaPropertyState = value; } }
        private Value<string> _hmdaPropertyZipCode;
        public string HmdaPropertyZipCode { get { return _hmdaPropertyZipCode; } set { _hmdaPropertyZipCode = value; } }
        private Value<bool?> _hmdaSyncAddressIndicator;
        public bool? HmdaSyncAddressIndicator { get { return _hmdaSyncAddressIndicator; } set { _hmdaSyncAddressIndicator = value; } }
        private Value<string> _hOEPAStatus;
        public string HOEPAStatus { get { return _hOEPAStatus; } set { _hOEPAStatus = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<NA<decimal>?> _income;
        public NA<decimal>? Income { get { return _income; } set { _income = value; } }
        private Value<string> _initiallyPayableToYourInstitution;
        public string InitiallyPayableToYourInstitution { get { return _initiallyPayableToYourInstitution; } set { _initiallyPayableToYourInstitution = value; } }
        private Value<NA<decimal>?> _interestRate;
        public NA<decimal>? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private Value<string> _introRatePeriod;
        public string IntroRatePeriod { get { return _introRatePeriod; } set { _introRatePeriod = value; } }
        private Value<string> _legalEntityIdentifier;
        public string LegalEntityIdentifier { get { return _legalEntityIdentifier; } set { _legalEntityIdentifier = value; } }
        private Value<NA<decimal>?> _lenderCredits;
        public NA<decimal>? LenderCredits { get { return _lenderCredits; } set { _lenderCredits = value; } }
        private Value<string> _lienStatus;
        public string LienStatus { get { return _lienStatus; } set { _lienStatus = value; } }
        private Value<decimal?> _loanAmount;
        public decimal? LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        private Value<string> _loanTerm;
        public string LoanTerm { get { return _loanTerm; } set { _loanTerm = value; } }
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        private Value<string> _manufacturedHomeLandPropertyInterest;
        public string ManufacturedHomeLandPropertyInterest { get { return _manufacturedHomeLandPropertyInterest; } set { _manufacturedHomeLandPropertyInterest = value; } }
        private Value<string> _manufacturedSecuredProperyType;
        public string ManufacturedSecuredProperyType { get { return _manufacturedSecuredProperyType; } set { _manufacturedSecuredProperyType = value; } }
        private Value<string> _mSANumber;
        public string MSANumber { get { return _mSANumber; } set { _mSANumber = value; } }
        private Value<string> _multifamilyNoUnits;
        public string MultifamilyNoUnits { get { return _multifamilyNoUnits; } set { _multifamilyNoUnits = value; } }
        private Value<string> _nMLSLoanOriginatorID;
        public string NMLSLoanOriginatorID { get { return _nMLSLoanOriginatorID; } set { _nMLSLoanOriginatorID = value; } }
        private Value<string> _openEndLineOfCredit;
        public string OpenEndLineOfCredit { get { return _openEndLineOfCredit; } set { _openEndLineOfCredit = value; } }
        private Value<string> _originationCharges;
        public string OriginationCharges { get { return _originationCharges; } set { _originationCharges = value; } }
        private Value<string> _otherAUS;
        public string OtherAUS { get { return _otherAUS; } set { _otherAUS = value; } }
        private Value<string> _otherAUSRecommendations;
        public string OtherAUSRecommendations { get { return _otherAUSRecommendations; } set { _otherAUSRecommendations = value; } }
        private Value<string> _otherDenialReason;
        public string OtherDenialReason { get { return _otherDenialReason; } set { _otherDenialReason = value; } }
        private Value<string> _otherNonAmortization;
        public string OtherNonAmortization { get { return _otherNonAmortization; } set { _otherNonAmortization = value; } }
        private Value<string> _parentAddress;
        public string ParentAddress { get { return _parentAddress; } set { _parentAddress = value; } }
        private Value<string> _parentCity;
        public string ParentCity { get { return _parentCity; } set { _parentCity = value; } }
        private Value<string> _parentName;
        public string ParentName { get { return _parentName; } set { _parentName = value; } }
        private Value<string> _parentState;
        public string ParentState { get { return _parentState; } set { _parentState = value; } }
        private Value<string> _parentZip;
        public string ParentZip { get { return _parentZip; } set { _parentZip = value; } }
        private Value<string> _preapprovals;
        public string Preapprovals { get { return _preapprovals; } set { _preapprovals = value; } }
        private Value<string> _prepaymentPenaltyPeriod;
        public string PrepaymentPenaltyPeriod { get { return _prepaymentPenaltyPeriod; } set { _prepaymentPenaltyPeriod = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<NA<decimal>?> _propertyValue;
        public NA<decimal>? PropertyValue { get { return _propertyValue; } set { _propertyValue = value; } }
        private Value<string> _qMStatus;
        public string QMStatus { get { return _qMStatus; } set { _qMStatus = value; } }
        private Value<NA<decimal>?> _rateSpread;
        public NA<decimal>? RateSpread { get { return _rateSpread; } set { _rateSpread = value; } }
        private Value<int?> _reportingYear;
        public int? ReportingYear { get { return _reportingYear; } set { _reportingYear = value; } }
        private Value<bool?> _reportPurposeOfLoanIndicator;
        public bool? ReportPurposeOfLoanIndicator { get { return _reportPurposeOfLoanIndicator; } set { _reportPurposeOfLoanIndicator = value; } }
        private Value<string> _repurchasedActionDate;
        public string RepurchasedActionDate { get { return _repurchasedActionDate; } set { _repurchasedActionDate = value; } }
        private Value<string> _repurchasedActionTaken;
        public string RepurchasedActionTaken { get { return _repurchasedActionTaken; } set { _repurchasedActionTaken = value; } }
        private Value<decimal?> _repurchasedLoanAmount;
        public decimal? RepurchasedLoanAmount { get { return _repurchasedLoanAmount; } set { _repurchasedLoanAmount = value; } }
        private Value<int?> _repurchasedReportingYear;
        public int? RepurchasedReportingYear { get { return _repurchasedReportingYear; } set { _repurchasedReportingYear = value; } }
        private Value<string> _repurchasedTypeOfPurchaser;
        public string RepurchasedTypeOfPurchaser { get { return _repurchasedTypeOfPurchaser; } set { _repurchasedTypeOfPurchaser = value; } }
        private Value<string> _respondentID;
        public string RespondentID { get { return _respondentID; } set { _respondentID = value; } }
        private Value<string> _reverseMortgage;
        public string ReverseMortgage { get { return _reverseMortgage; } set { _reverseMortgage = value; } }
        private Value<string> _stateCode;
        public string StateCode { get { return _stateCode; } set { _stateCode = value; } }
        private Value<string> _submissionOfApplication;
        public string SubmissionOfApplication { get { return _submissionOfApplication; } set { _submissionOfApplication = value; } }
        private Value<string> _totalLoanCosts;
        public string TotalLoanCosts { get { return _totalLoanCosts; } set { _totalLoanCosts = value; } }
        private Value<string> _totalPointsAndFees;
        public string TotalPointsAndFees { get { return _totalPointsAndFees; } set { _totalPointsAndFees = value; } }
        private Value<string> _typeOfPurchaser;
        public string TypeOfPurchaser { get { return _typeOfPurchaser; } set { _typeOfPurchaser = value; } }
        private Value<string> _universalLoanId;
        public string UniversalLoanId { get { return _universalLoanId; } set { _universalLoanId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actionTaken.Clean
                    && _applicationDate.Clean
                    && _aUS1.Clean
                    && _aUS2.Clean
                    && _aUS3.Clean
                    && _aUS4.Clean
                    && _aUS5.Clean
                    && _aUSRecommendation1.Clean
                    && _aUSRecommendation2.Clean
                    && _aUSRecommendation3.Clean
                    && _aUSRecommendation4.Clean
                    && _aUSRecommendation5.Clean
                    && _businessOrCommercialPurpose.Clean
                    && _censusTrack.Clean
                    && _cLTV.Clean
                    && _contactEmailAddress.Clean
                    && _contactFaxNumber.Clean
                    && _contactName.Clean
                    && _contactOfficeCity.Clean
                    && _contactOfficeState.Clean
                    && _contactOfficeStreetAddress.Clean
                    && _contactOfficeZIPCode.Clean
                    && _contactPhoneNumber.Clean
                    && _countyCode.Clean
                    && _debtToIncomeRatio.Clean
                    && _denialReason1.Clean
                    && _denialReason2.Clean
                    && _denialReason3.Clean
                    && _denialReason4.Clean
                    && _discountPoints.Clean
                    && _excludeLoanFromHMDAReportIndicator.Clean
                    && _federalAgency.Clean
                    && _federalTaxpayerIdNumber.Clean
                    && _financialInstitutionName.Clean
                    && _hmdaPropertyAddress.Clean
                    && _hmdaPropertyCity.Clean
                    && _hmdaPropertyState.Clean
                    && _hmdaPropertyZipCode.Clean
                    && _hmdaSyncAddressIndicator.Clean
                    && _hOEPAStatus.Clean
                    && _id.Clean
                    && _income.Clean
                    && _initiallyPayableToYourInstitution.Clean
                    && _interestRate.Clean
                    && _introRatePeriod.Clean
                    && _legalEntityIdentifier.Clean
                    && _lenderCredits.Clean
                    && _lienStatus.Clean
                    && _loanAmount.Clean
                    && _loanPurpose.Clean
                    && _loanTerm.Clean
                    && _loanType.Clean
                    && _manufacturedHomeLandPropertyInterest.Clean
                    && _manufacturedSecuredProperyType.Clean
                    && _mSANumber.Clean
                    && _multifamilyNoUnits.Clean
                    && _nMLSLoanOriginatorID.Clean
                    && _openEndLineOfCredit.Clean
                    && _originationCharges.Clean
                    && _otherAUS.Clean
                    && _otherAUSRecommendations.Clean
                    && _otherDenialReason.Clean
                    && _otherNonAmortization.Clean
                    && _parentAddress.Clean
                    && _parentCity.Clean
                    && _parentName.Clean
                    && _parentState.Clean
                    && _parentZip.Clean
                    && _preapprovals.Clean
                    && _prepaymentPenaltyPeriod.Clean
                    && _propertyType.Clean
                    && _propertyValue.Clean
                    && _qMStatus.Clean
                    && _rateSpread.Clean
                    && _reportingYear.Clean
                    && _reportPurposeOfLoanIndicator.Clean
                    && _repurchasedActionDate.Clean
                    && _repurchasedActionTaken.Clean
                    && _repurchasedLoanAmount.Clean
                    && _repurchasedReportingYear.Clean
                    && _repurchasedTypeOfPurchaser.Clean
                    && _respondentID.Clean
                    && _reverseMortgage.Clean
                    && _stateCode.Clean
                    && _submissionOfApplication.Clean
                    && _totalLoanCosts.Clean
                    && _totalPointsAndFees.Clean
                    && _typeOfPurchaser.Clean
                    && _universalLoanId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var actionTaken = _actionTaken; actionTaken.Clean = value; _actionTaken = actionTaken;
                var applicationDate = _applicationDate; applicationDate.Clean = value; _applicationDate = applicationDate;
                var aUS1 = _aUS1; aUS1.Clean = value; _aUS1 = aUS1;
                var aUS2 = _aUS2; aUS2.Clean = value; _aUS2 = aUS2;
                var aUS3 = _aUS3; aUS3.Clean = value; _aUS3 = aUS3;
                var aUS4 = _aUS4; aUS4.Clean = value; _aUS4 = aUS4;
                var aUS5 = _aUS5; aUS5.Clean = value; _aUS5 = aUS5;
                var aUSRecommendation1 = _aUSRecommendation1; aUSRecommendation1.Clean = value; _aUSRecommendation1 = aUSRecommendation1;
                var aUSRecommendation2 = _aUSRecommendation2; aUSRecommendation2.Clean = value; _aUSRecommendation2 = aUSRecommendation2;
                var aUSRecommendation3 = _aUSRecommendation3; aUSRecommendation3.Clean = value; _aUSRecommendation3 = aUSRecommendation3;
                var aUSRecommendation4 = _aUSRecommendation4; aUSRecommendation4.Clean = value; _aUSRecommendation4 = aUSRecommendation4;
                var aUSRecommendation5 = _aUSRecommendation5; aUSRecommendation5.Clean = value; _aUSRecommendation5 = aUSRecommendation5;
                var businessOrCommercialPurpose = _businessOrCommercialPurpose; businessOrCommercialPurpose.Clean = value; _businessOrCommercialPurpose = businessOrCommercialPurpose;
                var censusTrack = _censusTrack; censusTrack.Clean = value; _censusTrack = censusTrack;
                var cLTV = _cLTV; cLTV.Clean = value; _cLTV = cLTV;
                var contactEmailAddress = _contactEmailAddress; contactEmailAddress.Clean = value; _contactEmailAddress = contactEmailAddress;
                var contactFaxNumber = _contactFaxNumber; contactFaxNumber.Clean = value; _contactFaxNumber = contactFaxNumber;
                var contactName = _contactName; contactName.Clean = value; _contactName = contactName;
                var contactOfficeCity = _contactOfficeCity; contactOfficeCity.Clean = value; _contactOfficeCity = contactOfficeCity;
                var contactOfficeState = _contactOfficeState; contactOfficeState.Clean = value; _contactOfficeState = contactOfficeState;
                var contactOfficeStreetAddress = _contactOfficeStreetAddress; contactOfficeStreetAddress.Clean = value; _contactOfficeStreetAddress = contactOfficeStreetAddress;
                var contactOfficeZIPCode = _contactOfficeZIPCode; contactOfficeZIPCode.Clean = value; _contactOfficeZIPCode = contactOfficeZIPCode;
                var contactPhoneNumber = _contactPhoneNumber; contactPhoneNumber.Clean = value; _contactPhoneNumber = contactPhoneNumber;
                var countyCode = _countyCode; countyCode.Clean = value; _countyCode = countyCode;
                var debtToIncomeRatio = _debtToIncomeRatio; debtToIncomeRatio.Clean = value; _debtToIncomeRatio = debtToIncomeRatio;
                var denialReason1 = _denialReason1; denialReason1.Clean = value; _denialReason1 = denialReason1;
                var denialReason2 = _denialReason2; denialReason2.Clean = value; _denialReason2 = denialReason2;
                var denialReason3 = _denialReason3; denialReason3.Clean = value; _denialReason3 = denialReason3;
                var denialReason4 = _denialReason4; denialReason4.Clean = value; _denialReason4 = denialReason4;
                var discountPoints = _discountPoints; discountPoints.Clean = value; _discountPoints = discountPoints;
                var excludeLoanFromHMDAReportIndicator = _excludeLoanFromHMDAReportIndicator; excludeLoanFromHMDAReportIndicator.Clean = value; _excludeLoanFromHMDAReportIndicator = excludeLoanFromHMDAReportIndicator;
                var federalAgency = _federalAgency; federalAgency.Clean = value; _federalAgency = federalAgency;
                var federalTaxpayerIdNumber = _federalTaxpayerIdNumber; federalTaxpayerIdNumber.Clean = value; _federalTaxpayerIdNumber = federalTaxpayerIdNumber;
                var financialInstitutionName = _financialInstitutionName; financialInstitutionName.Clean = value; _financialInstitutionName = financialInstitutionName;
                var hmdaPropertyAddress = _hmdaPropertyAddress; hmdaPropertyAddress.Clean = value; _hmdaPropertyAddress = hmdaPropertyAddress;
                var hmdaPropertyCity = _hmdaPropertyCity; hmdaPropertyCity.Clean = value; _hmdaPropertyCity = hmdaPropertyCity;
                var hmdaPropertyState = _hmdaPropertyState; hmdaPropertyState.Clean = value; _hmdaPropertyState = hmdaPropertyState;
                var hmdaPropertyZipCode = _hmdaPropertyZipCode; hmdaPropertyZipCode.Clean = value; _hmdaPropertyZipCode = hmdaPropertyZipCode;
                var hmdaSyncAddressIndicator = _hmdaSyncAddressIndicator; hmdaSyncAddressIndicator.Clean = value; _hmdaSyncAddressIndicator = hmdaSyncAddressIndicator;
                var hOEPAStatus = _hOEPAStatus; hOEPAStatus.Clean = value; _hOEPAStatus = hOEPAStatus;
                var id = _id; id.Clean = value; _id = id;
                var income = _income; income.Clean = value; _income = income;
                var initiallyPayableToYourInstitution = _initiallyPayableToYourInstitution; initiallyPayableToYourInstitution.Clean = value; _initiallyPayableToYourInstitution = initiallyPayableToYourInstitution;
                var interestRate = _interestRate; interestRate.Clean = value; _interestRate = interestRate;
                var introRatePeriod = _introRatePeriod; introRatePeriod.Clean = value; _introRatePeriod = introRatePeriod;
                var legalEntityIdentifier = _legalEntityIdentifier; legalEntityIdentifier.Clean = value; _legalEntityIdentifier = legalEntityIdentifier;
                var lenderCredits = _lenderCredits; lenderCredits.Clean = value; _lenderCredits = lenderCredits;
                var lienStatus = _lienStatus; lienStatus.Clean = value; _lienStatus = lienStatus;
                var loanAmount = _loanAmount; loanAmount.Clean = value; _loanAmount = loanAmount;
                var loanPurpose = _loanPurpose; loanPurpose.Clean = value; _loanPurpose = loanPurpose;
                var loanTerm = _loanTerm; loanTerm.Clean = value; _loanTerm = loanTerm;
                var loanType = _loanType; loanType.Clean = value; _loanType = loanType;
                var manufacturedHomeLandPropertyInterest = _manufacturedHomeLandPropertyInterest; manufacturedHomeLandPropertyInterest.Clean = value; _manufacturedHomeLandPropertyInterest = manufacturedHomeLandPropertyInterest;
                var manufacturedSecuredProperyType = _manufacturedSecuredProperyType; manufacturedSecuredProperyType.Clean = value; _manufacturedSecuredProperyType = manufacturedSecuredProperyType;
                var mSANumber = _mSANumber; mSANumber.Clean = value; _mSANumber = mSANumber;
                var multifamilyNoUnits = _multifamilyNoUnits; multifamilyNoUnits.Clean = value; _multifamilyNoUnits = multifamilyNoUnits;
                var nMLSLoanOriginatorID = _nMLSLoanOriginatorID; nMLSLoanOriginatorID.Clean = value; _nMLSLoanOriginatorID = nMLSLoanOriginatorID;
                var openEndLineOfCredit = _openEndLineOfCredit; openEndLineOfCredit.Clean = value; _openEndLineOfCredit = openEndLineOfCredit;
                var originationCharges = _originationCharges; originationCharges.Clean = value; _originationCharges = originationCharges;
                var otherAUS = _otherAUS; otherAUS.Clean = value; _otherAUS = otherAUS;
                var otherAUSRecommendations = _otherAUSRecommendations; otherAUSRecommendations.Clean = value; _otherAUSRecommendations = otherAUSRecommendations;
                var otherDenialReason = _otherDenialReason; otherDenialReason.Clean = value; _otherDenialReason = otherDenialReason;
                var otherNonAmortization = _otherNonAmortization; otherNonAmortization.Clean = value; _otherNonAmortization = otherNonAmortization;
                var parentAddress = _parentAddress; parentAddress.Clean = value; _parentAddress = parentAddress;
                var parentCity = _parentCity; parentCity.Clean = value; _parentCity = parentCity;
                var parentName = _parentName; parentName.Clean = value; _parentName = parentName;
                var parentState = _parentState; parentState.Clean = value; _parentState = parentState;
                var parentZip = _parentZip; parentZip.Clean = value; _parentZip = parentZip;
                var preapprovals = _preapprovals; preapprovals.Clean = value; _preapprovals = preapprovals;
                var prepaymentPenaltyPeriod = _prepaymentPenaltyPeriod; prepaymentPenaltyPeriod.Clean = value; _prepaymentPenaltyPeriod = prepaymentPenaltyPeriod;
                var propertyType = _propertyType; propertyType.Clean = value; _propertyType = propertyType;
                var propertyValue = _propertyValue; propertyValue.Clean = value; _propertyValue = propertyValue;
                var qMStatus = _qMStatus; qMStatus.Clean = value; _qMStatus = qMStatus;
                var rateSpread = _rateSpread; rateSpread.Clean = value; _rateSpread = rateSpread;
                var reportingYear = _reportingYear; reportingYear.Clean = value; _reportingYear = reportingYear;
                var reportPurposeOfLoanIndicator = _reportPurposeOfLoanIndicator; reportPurposeOfLoanIndicator.Clean = value; _reportPurposeOfLoanIndicator = reportPurposeOfLoanIndicator;
                var repurchasedActionDate = _repurchasedActionDate; repurchasedActionDate.Clean = value; _repurchasedActionDate = repurchasedActionDate;
                var repurchasedActionTaken = _repurchasedActionTaken; repurchasedActionTaken.Clean = value; _repurchasedActionTaken = repurchasedActionTaken;
                var repurchasedLoanAmount = _repurchasedLoanAmount; repurchasedLoanAmount.Clean = value; _repurchasedLoanAmount = repurchasedLoanAmount;
                var repurchasedReportingYear = _repurchasedReportingYear; repurchasedReportingYear.Clean = value; _repurchasedReportingYear = repurchasedReportingYear;
                var repurchasedTypeOfPurchaser = _repurchasedTypeOfPurchaser; repurchasedTypeOfPurchaser.Clean = value; _repurchasedTypeOfPurchaser = repurchasedTypeOfPurchaser;
                var respondentID = _respondentID; respondentID.Clean = value; _respondentID = respondentID;
                var reverseMortgage = _reverseMortgage; reverseMortgage.Clean = value; _reverseMortgage = reverseMortgage;
                var stateCode = _stateCode; stateCode.Clean = value; _stateCode = stateCode;
                var submissionOfApplication = _submissionOfApplication; submissionOfApplication.Clean = value; _submissionOfApplication = submissionOfApplication;
                var totalLoanCosts = _totalLoanCosts; totalLoanCosts.Clean = value; _totalLoanCosts = totalLoanCosts;
                var totalPointsAndFees = _totalPointsAndFees; totalPointsAndFees.Clean = value; _totalPointsAndFees = totalPointsAndFees;
                var typeOfPurchaser = _typeOfPurchaser; typeOfPurchaser.Clean = value; _typeOfPurchaser = typeOfPurchaser;
                var universalLoanId = _universalLoanId; universalLoanId.Clean = value; _universalLoanId = universalLoanId;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hmda()
        {
            Clean = true;
        }
    }
}