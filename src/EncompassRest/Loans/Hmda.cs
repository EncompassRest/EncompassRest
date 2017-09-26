using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hmda : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _actionTaken.Dirty
                    || _applicationDate.Dirty
                    || _aUS1.Dirty
                    || _aUS2.Dirty
                    || _aUS3.Dirty
                    || _aUS4.Dirty
                    || _aUS5.Dirty
                    || _aUSRecommendation1.Dirty
                    || _aUSRecommendation2.Dirty
                    || _aUSRecommendation3.Dirty
                    || _aUSRecommendation4.Dirty
                    || _aUSRecommendation5.Dirty
                    || _businessOrCommercialPurpose.Dirty
                    || _censusTrack.Dirty
                    || _cLTV.Dirty
                    || _contactEmailAddress.Dirty
                    || _contactFaxNumber.Dirty
                    || _contactName.Dirty
                    || _contactOfficeCity.Dirty
                    || _contactOfficeState.Dirty
                    || _contactOfficeStreetAddress.Dirty
                    || _contactOfficeZIPCode.Dirty
                    || _contactPhoneNumber.Dirty
                    || _countyCode.Dirty
                    || _debtToIncomeRatio.Dirty
                    || _denialReason1.Dirty
                    || _denialReason2.Dirty
                    || _denialReason3.Dirty
                    || _denialReason4.Dirty
                    || _discountPoints.Dirty
                    || _excludeLoanFromHMDAReportIndicator.Dirty
                    || _federalAgency.Dirty
                    || _federalTaxpayerIdNumber.Dirty
                    || _financialInstitutionName.Dirty
                    || _hmdaPropertyAddress.Dirty
                    || _hmdaPropertyCity.Dirty
                    || _hmdaPropertyState.Dirty
                    || _hmdaPropertyZipCode.Dirty
                    || _hmdaSyncAddressIndicator.Dirty
                    || _hOEPAStatus.Dirty
                    || _id.Dirty
                    || _income.Dirty
                    || _initiallyPayableToYourInstitution.Dirty
                    || _interestRate.Dirty
                    || _introRatePeriod.Dirty
                    || _legalEntityIdentifier.Dirty
                    || _lenderCredits.Dirty
                    || _lienStatus.Dirty
                    || _loanAmount.Dirty
                    || _loanPurpose.Dirty
                    || _loanTerm.Dirty
                    || _loanType.Dirty
                    || _manufacturedHomeLandPropertyInterest.Dirty
                    || _manufacturedSecuredProperyType.Dirty
                    || _mSANumber.Dirty
                    || _multifamilyNoUnits.Dirty
                    || _nMLSLoanOriginatorID.Dirty
                    || _openEndLineOfCredit.Dirty
                    || _originationCharges.Dirty
                    || _otherAUS.Dirty
                    || _otherAUSRecommendations.Dirty
                    || _otherDenialReason.Dirty
                    || _otherNonAmortization.Dirty
                    || _parentAddress.Dirty
                    || _parentCity.Dirty
                    || _parentName.Dirty
                    || _parentState.Dirty
                    || _parentZip.Dirty
                    || _preapprovals.Dirty
                    || _prepaymentPenaltyPeriod.Dirty
                    || _propertyType.Dirty
                    || _propertyValue.Dirty
                    || _qMStatus.Dirty
                    || _rateSpread.Dirty
                    || _reportingYear.Dirty
                    || _reportPurposeOfLoanIndicator.Dirty
                    || _repurchasedActionDate.Dirty
                    || _repurchasedActionTaken.Dirty
                    || _repurchasedLoanAmount.Dirty
                    || _repurchasedReportingYear.Dirty
                    || _repurchasedTypeOfPurchaser.Dirty
                    || _respondentID.Dirty
                    || _reverseMortgage.Dirty
                    || _stateCode.Dirty
                    || _submissionOfApplication.Dirty
                    || _totalLoanCosts.Dirty
                    || _totalPointsAndFees.Dirty
                    || _typeOfPurchaser.Dirty
                    || _universalLoanId.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _actionTaken.Dirty = value;
                _applicationDate.Dirty = value;
                _aUS1.Dirty = value;
                _aUS2.Dirty = value;
                _aUS3.Dirty = value;
                _aUS4.Dirty = value;
                _aUS5.Dirty = value;
                _aUSRecommendation1.Dirty = value;
                _aUSRecommendation2.Dirty = value;
                _aUSRecommendation3.Dirty = value;
                _aUSRecommendation4.Dirty = value;
                _aUSRecommendation5.Dirty = value;
                _businessOrCommercialPurpose.Dirty = value;
                _censusTrack.Dirty = value;
                _cLTV.Dirty = value;
                _contactEmailAddress.Dirty = value;
                _contactFaxNumber.Dirty = value;
                _contactName.Dirty = value;
                _contactOfficeCity.Dirty = value;
                _contactOfficeState.Dirty = value;
                _contactOfficeStreetAddress.Dirty = value;
                _contactOfficeZIPCode.Dirty = value;
                _contactPhoneNumber.Dirty = value;
                _countyCode.Dirty = value;
                _debtToIncomeRatio.Dirty = value;
                _denialReason1.Dirty = value;
                _denialReason2.Dirty = value;
                _denialReason3.Dirty = value;
                _denialReason4.Dirty = value;
                _discountPoints.Dirty = value;
                _excludeLoanFromHMDAReportIndicator.Dirty = value;
                _federalAgency.Dirty = value;
                _federalTaxpayerIdNumber.Dirty = value;
                _financialInstitutionName.Dirty = value;
                _hmdaPropertyAddress.Dirty = value;
                _hmdaPropertyCity.Dirty = value;
                _hmdaPropertyState.Dirty = value;
                _hmdaPropertyZipCode.Dirty = value;
                _hmdaSyncAddressIndicator.Dirty = value;
                _hOEPAStatus.Dirty = value;
                _id.Dirty = value;
                _income.Dirty = value;
                _initiallyPayableToYourInstitution.Dirty = value;
                _interestRate.Dirty = value;
                _introRatePeriod.Dirty = value;
                _legalEntityIdentifier.Dirty = value;
                _lenderCredits.Dirty = value;
                _lienStatus.Dirty = value;
                _loanAmount.Dirty = value;
                _loanPurpose.Dirty = value;
                _loanTerm.Dirty = value;
                _loanType.Dirty = value;
                _manufacturedHomeLandPropertyInterest.Dirty = value;
                _manufacturedSecuredProperyType.Dirty = value;
                _mSANumber.Dirty = value;
                _multifamilyNoUnits.Dirty = value;
                _nMLSLoanOriginatorID.Dirty = value;
                _openEndLineOfCredit.Dirty = value;
                _originationCharges.Dirty = value;
                _otherAUS.Dirty = value;
                _otherAUSRecommendations.Dirty = value;
                _otherDenialReason.Dirty = value;
                _otherNonAmortization.Dirty = value;
                _parentAddress.Dirty = value;
                _parentCity.Dirty = value;
                _parentName.Dirty = value;
                _parentState.Dirty = value;
                _parentZip.Dirty = value;
                _preapprovals.Dirty = value;
                _prepaymentPenaltyPeriod.Dirty = value;
                _propertyType.Dirty = value;
                _propertyValue.Dirty = value;
                _qMStatus.Dirty = value;
                _rateSpread.Dirty = value;
                _reportingYear.Dirty = value;
                _reportPurposeOfLoanIndicator.Dirty = value;
                _repurchasedActionDate.Dirty = value;
                _repurchasedActionTaken.Dirty = value;
                _repurchasedLoanAmount.Dirty = value;
                _repurchasedReportingYear.Dirty = value;
                _repurchasedTypeOfPurchaser.Dirty = value;
                _respondentID.Dirty = value;
                _reverseMortgage.Dirty = value;
                _stateCode.Dirty = value;
                _submissionOfApplication.Dirty = value;
                _totalLoanCosts.Dirty = value;
                _totalPointsAndFees.Dirty = value;
                _typeOfPurchaser.Dirty = value;
                _universalLoanId.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}