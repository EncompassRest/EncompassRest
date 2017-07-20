using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FhaVaLoan : IClean
    {
        private Value<string> _addendumType;
        public string AddendumType { get { return _addendumType; } set { _addendumType = value; } }
        private Value<bool?> _additionalCondition1;
        public bool? AdditionalCondition1 { get { return _additionalCondition1; } set { _additionalCondition1 = value; } }
        private Value<bool?> _additionalCondition2;
        public bool? AdditionalCondition2 { get { return _additionalCondition2; } set { _additionalCondition2 = value; } }
        private Value<bool?> _additionalCondition3;
        public bool? AdditionalCondition3 { get { return _additionalCondition3; } set { _additionalCondition3 = value; } }
        private Value<bool?> _additionalCondition4;
        public bool? AdditionalCondition4 { get { return _additionalCondition4; } set { _additionalCondition4 = value; } }
        private Value<bool?> _additionalCondition5;
        public bool? AdditionalCondition5 { get { return _additionalCondition5; } set { _additionalCondition5 = value; } }
        private Value<bool?> _additionalCondition6;
        public bool? AdditionalCondition6 { get { return _additionalCondition6; } set { _additionalCondition6 = value; } }
        private Value<bool?> _additionalCondition7;
        public bool? AdditionalCondition7 { get { return _additionalCondition7; } set { _additionalCondition7 = value; } }
        private Value<bool?> _additionalCondition8;
        public bool? AdditionalCondition8 { get { return _additionalCondition8; } set { _additionalCondition8 = value; } }
        private Value<bool?> _additionalCondition9;
        public bool? AdditionalCondition9 { get { return _additionalCondition9; } set { _additionalCondition9 = value; } }
        private Value<string> _addressValidatedBy;
        public string AddressValidatedBy { get { return _addressValidatedBy; } set { _addressValidatedBy = value; } }
        private Value<string> _addressValidationMessage;
        public string AddressValidationMessage { get { return _addressValidationMessage; } set { _addressValidationMessage = value; } }
        private Value<bool?> _allConditionsSatisfied;
        public bool? AllConditionsSatisfied { get { return _allConditionsSatisfied; } set { _allConditionsSatisfied = value; } }
        private Value<DateTime?> _appraisalLoggedDate;
        public DateTime? AppraisalLoggedDate { get { return _appraisalLoggedDate; } set { _appraisalLoggedDate = value; } }
        private Value<string> _appraisalLookupBy;
        public string AppraisalLookupBy { get { return _appraisalLookupBy; } set { _appraisalLookupBy = value; } }
        private Value<string> _beenInformed;
        public string BeenInformed { get { return _beenInformed; } set { _beenInformed = value; } }
        private Value<string> _borrowerCertificationAddress;
        public string BorrowerCertificationAddress { get { return _borrowerCertificationAddress; } set { _borrowerCertificationAddress = value; } }
        private Value<string> _borrowerCertificationCity;
        public string BorrowerCertificationCity { get { return _borrowerCertificationCity; } set { _borrowerCertificationCity = value; } }
        private Value<string> _borrowerCertificationPostalCode;
        public string BorrowerCertificationPostalCode { get { return _borrowerCertificationPostalCode; } set { _borrowerCertificationPostalCode = value; } }
        private Value<string> _borrowerCertificationState;
        public string BorrowerCertificationState { get { return _borrowerCertificationState; } set { _borrowerCertificationState = value; } }
        private Value<string> _cAIVRSObtainedBy;
        public string CAIVRSObtainedBy { get { return _cAIVRSObtainedBy; } set { _cAIVRSObtainedBy = value; } }
        private Value<string> _caseBinderShippedBy;
        public string CaseBinderShippedBy { get { return _caseBinderShippedBy; } set { _caseBinderShippedBy = value; } }
        private Value<DateTime?> _caseBinderShippedDate;
        public DateTime? CaseBinderShippedDate { get { return _caseBinderShippedDate; } set { _caseBinderShippedDate = value; } }
        private Value<DateTime?> _closingDate;
        public DateTime? ClosingDate { get { return _closingDate; } set { _closingDate = value; } }
        private Value<string> _condoPudID;
        public string CondoPudID { get { return _condoPudID; } set { _condoPudID = value; } }
        private Value<string> _condoPudLookupBy;
        public string CondoPudLookupBy { get { return _condoPudLookupBy; } set { _condoPudLookupBy = value; } }
        private Value<DateTime?> _condoPudLookupDate;
        public DateTime? CondoPudLookupDate { get { return _condoPudLookupDate; } set { _condoPudLookupDate = value; } }
        private Value<DateTime?> _dateApprovalExpires;
        public DateTime? DateApprovalExpires { get { return _dateApprovalExpires; } set { _dateApprovalExpires = value; } }
        private Value<DateTime?> _dateMortgageApproved;
        public DateTime? DateMortgageApproved { get { return _dateMortgageApproved; } set { _dateMortgageApproved = value; } }
        private Value<string> _detailForOther;
        public string DetailForOther { get { return _detailForOther; } set { _detailForOther = value; } }
        private Value<decimal?> _discountPoints;
        public decimal? DiscountPoints { get { return _discountPoints; } set { _discountPoints = value; } }
        private Value<string> _dulyAgentAddress;
        public string DulyAgentAddress { get { return _dulyAgentAddress; } set { _dulyAgentAddress = value; } }
        private Value<string> _dulyAgentCity;
        public string DulyAgentCity { get { return _dulyAgentCity; } set { _dulyAgentCity = value; } }
        private Value<string> _dulyAgentFunction1;
        public string DulyAgentFunction1 { get { return _dulyAgentFunction1; } set { _dulyAgentFunction1 = value; } }
        private Value<string> _dulyAgentFunction2;
        public string DulyAgentFunction2 { get { return _dulyAgentFunction2; } set { _dulyAgentFunction2 = value; } }
        private Value<string> _dulyAgentName;
        public string DulyAgentName { get { return _dulyAgentName; } set { _dulyAgentName = value; } }
        private Value<string> _dulyAgentState;
        public string DulyAgentState { get { return _dulyAgentState; } set { _dulyAgentState = value; } }
        private Value<bool?> _dwellingCoveredBy;
        public bool? DwellingCoveredBy { get { return _dwellingCoveredBy; } set { _dwellingCoveredBy = value; } }
        public EnergyEfficientMortgage Eem { get; set; }
        private Value<string> _eligibilityAssessment;
        public string EligibilityAssessment { get { return _eligibilityAssessment; } set { _eligibilityAssessment = value; } }
        private Value<decimal?> _energyEfficientMortgageAmount;
        public decimal? EnergyEfficientMortgageAmount { get { return _energyEfficientMortgageAmount; } set { _energyEfficientMortgageAmount = value; } }
        private Value<List<EnergyEfficientMortgageItem>> _energyEfficientMortgageItems;
        public List<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get { return _energyEfficientMortgageItems; } set { _energyEfficientMortgageItems = value; } }
        private Value<bool?> _everHadVAHomeLoan;
        public bool? EverHadVAHomeLoan { get { return _everHadVAHomeLoan; } set { _everHadVAHomeLoan = value; } }
        private Value<decimal?> _excessContributionAmount;
        public decimal? ExcessContributionAmount { get { return _excessContributionAmount; } set { _excessContributionAmount = value; } }
        private Value<decimal?> _existingDebtAmount;
        public decimal? ExistingDebtAmount { get { return _existingDebtAmount; } set { _existingDebtAmount = value; } }
        private Value<string> _fHACaseOrderedBy;
        public string FHACaseOrderedBy { get { return _fHACaseOrderedBy; } set { _fHACaseOrderedBy = value; } }
        private Value<string> _fHAManagementCounselType;
        public string FHAManagementCounselType { get { return _fHAManagementCounselType; } set { _fHAManagementCounselType = value; } }
        private Value<decimal?> _fHAMaxLoanAmount;
        public decimal? FHAMaxLoanAmount { get { return _fHAMaxLoanAmount; } set { _fHAMaxLoanAmount = value; } }
        private Value<bool?> _foreclosedProperty;
        public bool? ForeclosedProperty { get { return _foreclosedProperty; } set { _foreclosedProperty = value; } }
        private Value<string> _freddieMacCounselType;
        public string FreddieMacCounselType { get { return _freddieMacCounselType; } set { _freddieMacCounselType = value; } }
        private Value<decimal?> _fundingFeePaidInCash;
        public decimal? FundingFeePaidInCash { get { return _fundingFeePaidInCash; } set { _fundingFeePaidInCash = value; } }
        private Value<decimal?> _giftFundsAmount;
        public decimal? GiftFundsAmount { get { return _giftFundsAmount; } set { _giftFundsAmount = value; } }
        private Value<bool?> _haveReceivedLeadPaintPoisoningInfo;
        public bool? HaveReceivedLeadPaintPoisoningInfo { get { return _haveReceivedLeadPaintPoisoningInfo; } set { _haveReceivedLeadPaintPoisoningInfo = value; } }
        private Value<string> _hUD1003AddendumApproved;
        public string HUD1003AddendumApproved { get { return _hUD1003AddendumApproved; } set { _hUD1003AddendumApproved = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _lastRefiDate;
        public DateTime? LastRefiDate { get { return _lastRefiDate; } set { _lastRefiDate = value; } }
        private Value<DateTime?> _lDPGSASearchDate;
        public DateTime? LDPGSASearchDate { get { return _lDPGSASearchDate; } set { _lDPGSASearchDate = value; } }
        private Value<string> _lDPGSASearchedBy;
        public string LDPGSASearchedBy { get { return _lDPGSASearchedBy; } set { _lDPGSASearchedBy = value; } }
        private Value<string> _lenderAddress;
        public string LenderAddress { get { return _lenderAddress; } set { _lenderAddress = value; } }
        private Value<string> _lenderCity;
        public string LenderCity { get { return _lenderCity; } set { _lenderCity = value; } }
        private Value<string> _lenderName;
        public string LenderName { get { return _lenderName; } set { _lenderName = value; } }
        private Value<string> _lenderNMLS;
        public string LenderNMLS { get { return _lenderNMLS; } set { _lenderNMLS = value; } }
        private Value<string> _lenderPostalCode;
        public string LenderPostalCode { get { return _lenderPostalCode; } set { _lenderPostalCode = value; } }
        private Value<string> _lenderRepresentativeName;
        public string LenderRepresentativeName { get { return _lenderRepresentativeName; } set { _lenderRepresentativeName = value; } }
        private Value<string> _lenderRepresentativePhone;
        public string LenderRepresentativePhone { get { return _lenderRepresentativePhone; } set { _lenderRepresentativePhone = value; } }
        private Value<string> _lenderRepresentativeTitle;
        public string LenderRepresentativeTitle { get { return _lenderRepresentativeTitle; } set { _lenderRepresentativeTitle = value; } }
        private Value<string> _lenderState;
        public string LenderState { get { return _lenderState; } set { _lenderState = value; } }
        private Value<string> _lenderTaxID;
        public string LenderTaxID { get { return _lenderTaxID; } set { _lenderTaxID = value; } }
        private Value<string> _loanScoreID;
        public string LoanScoreID { get { return _loanScoreID; } set { _loanScoreID = value; } }
        private Value<string> _mIAppliedBy;
        public string MIAppliedBy { get { return _mIAppliedBy; } set { _mIAppliedBy = value; } }
        private Value<DateTime?> _mIAppliedDate;
        public DateTime? MIAppliedDate { get { return _mIAppliedDate; } set { _mIAppliedDate = value; } }
        private Value<DateTime?> _mICRetrivedDate;
        public DateTime? MICRetrivedDate { get { return _mICRetrivedDate; } set { _mICRetrivedDate = value; } }
        private Value<decimal?> _minimumDownPayment;
        public decimal? MinimumDownPayment { get { return _minimumDownPayment; } set { _minimumDownPayment = value; } }
        private Value<DateTime?> _mIP1stDueDate;
        public DateTime? MIP1stDueDate { get { return _mIP1stDueDate; } set { _mIP1stDueDate = value; } }
        private Value<DateTime?> _mIP1stToInvestor;
        public DateTime? MIP1stToInvestor { get { return _mIP1stToInvestor; } set { _mIP1stToInvestor = value; } }
        private Value<DateTime?> _mIPRemittedDate;
        public DateTime? MIPRemittedDate { get { return _mIPRemittedDate; } set { _mIPRemittedDate = value; } }
        private Value<DateTime?> _mIRejectedDate;
        public DateTime? MIRejectedDate { get { return _mIRejectedDate; } set { _mIRejectedDate = value; } }
        private Value<decimal?> _modifiedInterestRate;
        public decimal? ModifiedInterestRate { get { return _modifiedInterestRate; } set { _modifiedInterestRate = value; } }
        private Value<decimal?> _modifiedLoanAmount;
        public decimal? ModifiedLoanAmount { get { return _modifiedLoanAmount; } set { _modifiedLoanAmount = value; } }
        private Value<decimal?> _modifiedMonthlyPayment;
        public decimal? ModifiedMonthlyPayment { get { return _modifiedMonthlyPayment; } set { _modifiedMonthlyPayment = value; } }
        private Value<decimal?> _modifiedMonthlyPremium;
        public decimal? ModifiedMonthlyPremium { get { return _modifiedMonthlyPremium; } set { _modifiedMonthlyPremium = value; } }
        private Value<int?> _modifiedProposedMaturityMonth;
        public int? ModifiedProposedMaturityMonth { get { return _modifiedProposedMaturityMonth; } set { _modifiedProposedMaturityMonth = value; } }
        private Value<int?> _modifiedProposedMaturityYear;
        public int? ModifiedProposedMaturityYear { get { return _modifiedProposedMaturityYear; } set { _modifiedProposedMaturityYear = value; } }
        private Value<int?> _modifiedTermAnnualPremium;
        public int? ModifiedTermAnnualPremium { get { return _modifiedTermAnnualPremium; } set { _modifiedTermAnnualPremium = value; } }
        private Value<decimal?> _modifiedUpfrontPremium;
        public decimal? ModifiedUpfrontPremium { get { return _modifiedUpfrontPremium; } set { _modifiedUpfrontPremium = value; } }
        private Value<string> _mortgageeRepresentative;
        public string MortgageeRepresentative { get { return _mortgageeRepresentative; } set { _mortgageeRepresentative = value; } }
        private Value<string> _mortgageFinancialInterest;
        public string MortgageFinancialInterest { get { return _mortgageFinancialInterest; } set { _mortgageFinancialInterest = value; } }
        private Value<decimal?> _nonRealtyAndOtherItems;
        public decimal? NonRealtyAndOtherItems { get { return _nonRealtyAndOtherItems; } set { _nonRealtyAndOtherItems = value; } }
        private Value<DateTime?> _obtainCAIVRSDate;
        public DateTime? ObtainCAIVRSDate { get { return _obtainCAIVRSDate; } set { _obtainCAIVRSDate = value; } }
        private Value<string> _occupancy;
        public string Occupancy { get { return _occupancy; } set { _occupancy = value; } }
        private Value<string> _oldAgencyCaseIdentifier;
        public string OldAgencyCaseIdentifier { get { return _oldAgencyCaseIdentifier; } set { _oldAgencyCaseIdentifier = value; } }
        private Value<decimal?> _originalMortgageAmount;
        public decimal? OriginalMortgageAmount { get { return _originalMortgageAmount; } set { _originalMortgageAmount = value; } }
        private Value<decimal?> _otherLiabilitiesMonthlyPayment;
        public decimal? OtherLiabilitiesMonthlyPayment { get { return _otherLiabilitiesMonthlyPayment; } set { _otherLiabilitiesMonthlyPayment = value; } }
        private Value<decimal?> _otherLiabilitiesUnpaidBalance;
        public decimal? OtherLiabilitiesUnpaidBalance { get { return _otherLiabilitiesUnpaidBalance; } set { _otherLiabilitiesUnpaidBalance = value; } }
        private Value<decimal?> _otherMonthlyShelterExpense;
        public decimal? OtherMonthlyShelterExpense { get { return _otherMonthlyShelterExpense; } set { _otherMonthlyShelterExpense = value; } }
        private Value<string> _otherTitleDescription;
        public string OtherTitleDescription { get { return _otherTitleDescription; } set { _otherTitleDescription = value; } }
        private Value<bool?> _ownMoreThanFourDwellings;
        public bool? OwnMoreThanFourDwellings { get { return _ownMoreThanFourDwellings; } set { _ownMoreThanFourDwellings = value; } }
        private Value<bool?> _ownOrSoldOtherRealEstate;
        public bool? OwnOrSoldOtherRealEstate { get { return _ownOrSoldOtherRealEstate; } set { _ownOrSoldOtherRealEstate = value; } }
        private Value<decimal?> _paidAmount;
        public decimal? PaidAmount { get { return _paidAmount; } set { _paidAmount = value; } }
        private Value<int?> _premiumMonths;
        public int? PremiumMonths { get { return _premiumMonths; } set { _premiumMonths = value; } }
        private Value<decimal?> _prepaidExpenses;
        public decimal? PrepaidExpenses { get { return _prepaidExpenses; } set { _prepaidExpenses = value; } }
        private Value<DateTime?> _previousPurchaseDate;
        public DateTime? PreviousPurchaseDate { get { return _previousPurchaseDate; } set { _previousPurchaseDate = value; } }
        private Value<DateTime?> _priorEndorsementDate;
        public DateTime? PriorEndorsementDate { get { return _priorEndorsementDate; } set { _priorEndorsementDate = value; } }
        private Value<int?> _proposedMaturityMonths;
        public int? ProposedMaturityMonths { get { return _proposedMaturityMonths; } set { _proposedMaturityMonths = value; } }
        private Value<int?> _proposedMaturityYears;
        public int? ProposedMaturityYears { get { return _proposedMaturityYears; } set { _proposedMaturityYears = value; } }
        private Value<string> _purposeOfLoan;
        public string PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        private Value<string> _refiAuthorizationBy;
        public string RefiAuthorizationBy { get { return _refiAuthorizationBy; } set { _refiAuthorizationBy = value; } }
        private Value<DateTime?> _refiAuthorizationDate;
        public DateTime? RefiAuthorizationDate { get { return _refiAuthorizationDate; } set { _refiAuthorizationDate = value; } }
        private Value<decimal?> _salesPrice;
        public decimal? SalesPrice { get { return _salesPrice; } set { _salesPrice = value; } }
        private Value<decimal?> _secondMortgageAmount;
        public decimal? SecondMortgageAmount { get { return _secondMortgageAmount; } set { _secondMortgageAmount = value; } }
        private Value<decimal?> _sellerPaidClosingCost;
        public decimal? SellerPaidClosingCost { get { return _sellerPaidClosingCost; } set { _sellerPaidClosingCost = value; } }
        private Value<DateTime?> _servingTransferedDate;
        public DateTime? ServingTransferedDate { get { return _servingTransferedDate; } set { _servingTransferedDate = value; } }
        private Value<decimal?> _specialAssessments;
        public decimal? SpecialAssessments { get { return _specialAssessments; } set { _specialAssessments = value; } }
        private Value<string> _sponsorAgentAddress;
        public string SponsorAgentAddress { get { return _sponsorAgentAddress; } set { _sponsorAgentAddress = value; } }
        private Value<string> _sponsorAgentCity;
        public string SponsorAgentCity { get { return _sponsorAgentCity; } set { _sponsorAgentCity = value; } }
        private Value<string> _sponsorAgentName;
        public string SponsorAgentName { get { return _sponsorAgentName; } set { _sponsorAgentName = value; } }
        private Value<string> _sponsorAgentNMLS;
        public string SponsorAgentNMLS { get { return _sponsorAgentNMLS; } set { _sponsorAgentNMLS = value; } }
        private Value<string> _sponsorAgentPostalCode;
        public string SponsorAgentPostalCode { get { return _sponsorAgentPostalCode; } set { _sponsorAgentPostalCode = value; } }
        private Value<string> _sponsorAgentState;
        public string SponsorAgentState { get { return _sponsorAgentState; } set { _sponsorAgentState = value; } }
        private Value<string> _sponsorAgentTaxID;
        public string SponsorAgentTaxID { get { return _sponsorAgentTaxID; } set { _sponsorAgentTaxID = value; } }
        private Value<string> _sponsoredOriginationsName;
        public string SponsoredOriginationsName { get { return _sponsoredOriginationsName; } set { _sponsoredOriginationsName = value; } }
        private Value<string> _sponsoredOriginationsNMLS;
        public string SponsoredOriginationsNMLS { get { return _sponsoredOriginationsNMLS; } set { _sponsoredOriginationsNMLS = value; } }
        private Value<string> _sponsoredOriginationsTaxID;
        public string SponsoredOriginationsTaxID { get { return _sponsoredOriginationsTaxID; } set { _sponsoredOriginationsTaxID = value; } }
        private Value<string> _sponsorID;
        public string SponsorID { get { return _sponsorID; } set { _sponsorID = value; } }
        private Value<string> _titleVestedIn;
        public string TitleVestedIn { get { return _titleVestedIn; } set { _titleVestedIn = value; } }
        private Value<bool?> _toBeSold;
        public bool? ToBeSold { get { return _toBeSold; } set { _toBeSold = value; } }
        private Value<decimal?> _totalClosingCost;
        public decimal? TotalClosingCost { get { return _totalClosingCost; } set { _totalClosingCost = value; } }
        private Value<string> _totalScorecardBy;
        public string TotalScorecardBy { get { return _totalScorecardBy; } set { _totalScorecardBy = value; } }
        private Value<DateTime?> _totalScorecardDate;
        public DateTime? TotalScorecardDate { get { return _totalScorecardDate; } set { _totalScorecardDate = value; } }
        private Value<DateTime?> _uFMIPRemittanceDueDate;
        public DateTime? UFMIPRemittanceDueDate { get { return _uFMIPRemittanceDueDate; } set { _uFMIPRemittanceDueDate = value; } }
        private Value<decimal?> _uFMIPRemittedAmount;
        public decimal? UFMIPRemittedAmount { get { return _uFMIPRemittedAmount; } set { _uFMIPRemittedAmount = value; } }
        private Value<string> _uFMIPRemittedBy;
        public string UFMIPRemittedBy { get { return _uFMIPRemittedBy; } set { _uFMIPRemittedBy = value; } }
        private Value<DateTime?> _uFMIPRemittedDate;
        public DateTime? UFMIPRemittedDate { get { return _uFMIPRemittedDate; } set { _uFMIPRemittedDate = value; } }
        private Value<string> _uFMIPVerificationCode;
        public string UFMIPVerificationCode { get { return _uFMIPVerificationCode; } set { _uFMIPVerificationCode = value; } }
        private Value<bool?> _useDefaultLenderInfo;
        public bool? UseDefaultLenderInfo { get { return _useDefaultLenderInfo; } set { _useDefaultLenderInfo = value; } }
        private Value<bool?> _utilityIncluded;
        public bool? UtilityIncluded { get { return _utilityIncluded; } set { _utilityIncluded = value; } }
        private Value<DateTime?> _validateAddressDate;
        public DateTime? ValidateAddressDate { get { return _validateAddressDate; } set { _validateAddressDate = value; } }
        private Value<string> _valuation;
        public string Valuation { get { return _valuation; } set { _valuation = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addendumType.Clean
                    && _additionalCondition1.Clean
                    && _additionalCondition2.Clean
                    && _additionalCondition3.Clean
                    && _additionalCondition4.Clean
                    && _additionalCondition5.Clean
                    && _additionalCondition6.Clean
                    && _additionalCondition7.Clean
                    && _additionalCondition8.Clean
                    && _additionalCondition9.Clean
                    && _addressValidatedBy.Clean
                    && _addressValidationMessage.Clean
                    && _allConditionsSatisfied.Clean
                    && _appraisalLoggedDate.Clean
                    && _appraisalLookupBy.Clean
                    && _beenInformed.Clean
                    && _borrowerCertificationAddress.Clean
                    && _borrowerCertificationCity.Clean
                    && _borrowerCertificationPostalCode.Clean
                    && _borrowerCertificationState.Clean
                    && _cAIVRSObtainedBy.Clean
                    && _caseBinderShippedBy.Clean
                    && _caseBinderShippedDate.Clean
                    && _closingDate.Clean
                    && _condoPudID.Clean
                    && _condoPudLookupBy.Clean
                    && _condoPudLookupDate.Clean
                    && _dateApprovalExpires.Clean
                    && _dateMortgageApproved.Clean
                    && _detailForOther.Clean
                    && _discountPoints.Clean
                    && _dulyAgentAddress.Clean
                    && _dulyAgentCity.Clean
                    && _dulyAgentFunction1.Clean
                    && _dulyAgentFunction2.Clean
                    && _dulyAgentName.Clean
                    && _dulyAgentState.Clean
                    && _dwellingCoveredBy.Clean
                    && _eligibilityAssessment.Clean
                    && _energyEfficientMortgageAmount.Clean
                    && _energyEfficientMortgageItems.Clean
                    && _everHadVAHomeLoan.Clean
                    && _excessContributionAmount.Clean
                    && _existingDebtAmount.Clean
                    && _fHACaseOrderedBy.Clean
                    && _fHAManagementCounselType.Clean
                    && _fHAMaxLoanAmount.Clean
                    && _foreclosedProperty.Clean
                    && _freddieMacCounselType.Clean
                    && _fundingFeePaidInCash.Clean
                    && _giftFundsAmount.Clean
                    && _haveReceivedLeadPaintPoisoningInfo.Clean
                    && _hUD1003AddendumApproved.Clean
                    && _id.Clean
                    && _lastRefiDate.Clean
                    && _lDPGSASearchDate.Clean
                    && _lDPGSASearchedBy.Clean
                    && _lenderAddress.Clean
                    && _lenderCity.Clean
                    && _lenderName.Clean
                    && _lenderNMLS.Clean
                    && _lenderPostalCode.Clean
                    && _lenderRepresentativeName.Clean
                    && _lenderRepresentativePhone.Clean
                    && _lenderRepresentativeTitle.Clean
                    && _lenderState.Clean
                    && _lenderTaxID.Clean
                    && _loanScoreID.Clean
                    && _mIAppliedBy.Clean
                    && _mIAppliedDate.Clean
                    && _mICRetrivedDate.Clean
                    && _minimumDownPayment.Clean
                    && _mIP1stDueDate.Clean
                    && _mIP1stToInvestor.Clean
                    && _mIPRemittedDate.Clean
                    && _mIRejectedDate.Clean
                    && _modifiedInterestRate.Clean
                    && _modifiedLoanAmount.Clean
                    && _modifiedMonthlyPayment.Clean
                    && _modifiedMonthlyPremium.Clean
                    && _modifiedProposedMaturityMonth.Clean
                    && _modifiedProposedMaturityYear.Clean
                    && _modifiedTermAnnualPremium.Clean
                    && _modifiedUpfrontPremium.Clean
                    && _mortgageeRepresentative.Clean
                    && _mortgageFinancialInterest.Clean
                    && _nonRealtyAndOtherItems.Clean
                    && _obtainCAIVRSDate.Clean
                    && _occupancy.Clean
                    && _oldAgencyCaseIdentifier.Clean
                    && _originalMortgageAmount.Clean
                    && _otherLiabilitiesMonthlyPayment.Clean
                    && _otherLiabilitiesUnpaidBalance.Clean
                    && _otherMonthlyShelterExpense.Clean
                    && _otherTitleDescription.Clean
                    && _ownMoreThanFourDwellings.Clean
                    && _ownOrSoldOtherRealEstate.Clean
                    && _paidAmount.Clean
                    && _premiumMonths.Clean
                    && _prepaidExpenses.Clean
                    && _previousPurchaseDate.Clean
                    && _priorEndorsementDate.Clean
                    && _proposedMaturityMonths.Clean
                    && _proposedMaturityYears.Clean
                    && _purposeOfLoan.Clean
                    && _refiAuthorizationBy.Clean
                    && _refiAuthorizationDate.Clean
                    && _salesPrice.Clean
                    && _secondMortgageAmount.Clean
                    && _sellerPaidClosingCost.Clean
                    && _servingTransferedDate.Clean
                    && _specialAssessments.Clean
                    && _sponsorAgentAddress.Clean
                    && _sponsorAgentCity.Clean
                    && _sponsorAgentName.Clean
                    && _sponsorAgentNMLS.Clean
                    && _sponsorAgentPostalCode.Clean
                    && _sponsorAgentState.Clean
                    && _sponsorAgentTaxID.Clean
                    && _sponsoredOriginationsName.Clean
                    && _sponsoredOriginationsNMLS.Clean
                    && _sponsoredOriginationsTaxID.Clean
                    && _sponsorID.Clean
                    && _titleVestedIn.Clean
                    && _toBeSold.Clean
                    && _totalClosingCost.Clean
                    && _totalScorecardBy.Clean
                    && _totalScorecardDate.Clean
                    && _uFMIPRemittanceDueDate.Clean
                    && _uFMIPRemittedAmount.Clean
                    && _uFMIPRemittedBy.Clean
                    && _uFMIPRemittedDate.Clean
                    && _uFMIPVerificationCode.Clean
                    && _useDefaultLenderInfo.Clean
                    && _utilityIncluded.Clean
                    && _validateAddressDate.Clean
                    && _valuation.Clean
                    && Eem?.Clean != false;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var addendumType = _addendumType; addendumType.Clean = value; _addendumType = addendumType;
                var additionalCondition1 = _additionalCondition1; additionalCondition1.Clean = value; _additionalCondition1 = additionalCondition1;
                var additionalCondition2 = _additionalCondition2; additionalCondition2.Clean = value; _additionalCondition2 = additionalCondition2;
                var additionalCondition3 = _additionalCondition3; additionalCondition3.Clean = value; _additionalCondition3 = additionalCondition3;
                var additionalCondition4 = _additionalCondition4; additionalCondition4.Clean = value; _additionalCondition4 = additionalCondition4;
                var additionalCondition5 = _additionalCondition5; additionalCondition5.Clean = value; _additionalCondition5 = additionalCondition5;
                var additionalCondition6 = _additionalCondition6; additionalCondition6.Clean = value; _additionalCondition6 = additionalCondition6;
                var additionalCondition7 = _additionalCondition7; additionalCondition7.Clean = value; _additionalCondition7 = additionalCondition7;
                var additionalCondition8 = _additionalCondition8; additionalCondition8.Clean = value; _additionalCondition8 = additionalCondition8;
                var additionalCondition9 = _additionalCondition9; additionalCondition9.Clean = value; _additionalCondition9 = additionalCondition9;
                var addressValidatedBy = _addressValidatedBy; addressValidatedBy.Clean = value; _addressValidatedBy = addressValidatedBy;
                var addressValidationMessage = _addressValidationMessage; addressValidationMessage.Clean = value; _addressValidationMessage = addressValidationMessage;
                var allConditionsSatisfied = _allConditionsSatisfied; allConditionsSatisfied.Clean = value; _allConditionsSatisfied = allConditionsSatisfied;
                var appraisalLoggedDate = _appraisalLoggedDate; appraisalLoggedDate.Clean = value; _appraisalLoggedDate = appraisalLoggedDate;
                var appraisalLookupBy = _appraisalLookupBy; appraisalLookupBy.Clean = value; _appraisalLookupBy = appraisalLookupBy;
                var beenInformed = _beenInformed; beenInformed.Clean = value; _beenInformed = beenInformed;
                var borrowerCertificationAddress = _borrowerCertificationAddress; borrowerCertificationAddress.Clean = value; _borrowerCertificationAddress = borrowerCertificationAddress;
                var borrowerCertificationCity = _borrowerCertificationCity; borrowerCertificationCity.Clean = value; _borrowerCertificationCity = borrowerCertificationCity;
                var borrowerCertificationPostalCode = _borrowerCertificationPostalCode; borrowerCertificationPostalCode.Clean = value; _borrowerCertificationPostalCode = borrowerCertificationPostalCode;
                var borrowerCertificationState = _borrowerCertificationState; borrowerCertificationState.Clean = value; _borrowerCertificationState = borrowerCertificationState;
                var cAIVRSObtainedBy = _cAIVRSObtainedBy; cAIVRSObtainedBy.Clean = value; _cAIVRSObtainedBy = cAIVRSObtainedBy;
                var caseBinderShippedBy = _caseBinderShippedBy; caseBinderShippedBy.Clean = value; _caseBinderShippedBy = caseBinderShippedBy;
                var caseBinderShippedDate = _caseBinderShippedDate; caseBinderShippedDate.Clean = value; _caseBinderShippedDate = caseBinderShippedDate;
                var closingDate = _closingDate; closingDate.Clean = value; _closingDate = closingDate;
                var condoPudID = _condoPudID; condoPudID.Clean = value; _condoPudID = condoPudID;
                var condoPudLookupBy = _condoPudLookupBy; condoPudLookupBy.Clean = value; _condoPudLookupBy = condoPudLookupBy;
                var condoPudLookupDate = _condoPudLookupDate; condoPudLookupDate.Clean = value; _condoPudLookupDate = condoPudLookupDate;
                var dateApprovalExpires = _dateApprovalExpires; dateApprovalExpires.Clean = value; _dateApprovalExpires = dateApprovalExpires;
                var dateMortgageApproved = _dateMortgageApproved; dateMortgageApproved.Clean = value; _dateMortgageApproved = dateMortgageApproved;
                var detailForOther = _detailForOther; detailForOther.Clean = value; _detailForOther = detailForOther;
                var discountPoints = _discountPoints; discountPoints.Clean = value; _discountPoints = discountPoints;
                var dulyAgentAddress = _dulyAgentAddress; dulyAgentAddress.Clean = value; _dulyAgentAddress = dulyAgentAddress;
                var dulyAgentCity = _dulyAgentCity; dulyAgentCity.Clean = value; _dulyAgentCity = dulyAgentCity;
                var dulyAgentFunction1 = _dulyAgentFunction1; dulyAgentFunction1.Clean = value; _dulyAgentFunction1 = dulyAgentFunction1;
                var dulyAgentFunction2 = _dulyAgentFunction2; dulyAgentFunction2.Clean = value; _dulyAgentFunction2 = dulyAgentFunction2;
                var dulyAgentName = _dulyAgentName; dulyAgentName.Clean = value; _dulyAgentName = dulyAgentName;
                var dulyAgentState = _dulyAgentState; dulyAgentState.Clean = value; _dulyAgentState = dulyAgentState;
                var dwellingCoveredBy = _dwellingCoveredBy; dwellingCoveredBy.Clean = value; _dwellingCoveredBy = dwellingCoveredBy;
                var eligibilityAssessment = _eligibilityAssessment; eligibilityAssessment.Clean = value; _eligibilityAssessment = eligibilityAssessment;
                var energyEfficientMortgageAmount = _energyEfficientMortgageAmount; energyEfficientMortgageAmount.Clean = value; _energyEfficientMortgageAmount = energyEfficientMortgageAmount;
                var energyEfficientMortgageItems = _energyEfficientMortgageItems; energyEfficientMortgageItems.Clean = value; _energyEfficientMortgageItems = energyEfficientMortgageItems;
                var everHadVAHomeLoan = _everHadVAHomeLoan; everHadVAHomeLoan.Clean = value; _everHadVAHomeLoan = everHadVAHomeLoan;
                var excessContributionAmount = _excessContributionAmount; excessContributionAmount.Clean = value; _excessContributionAmount = excessContributionAmount;
                var existingDebtAmount = _existingDebtAmount; existingDebtAmount.Clean = value; _existingDebtAmount = existingDebtAmount;
                var fHACaseOrderedBy = _fHACaseOrderedBy; fHACaseOrderedBy.Clean = value; _fHACaseOrderedBy = fHACaseOrderedBy;
                var fHAManagementCounselType = _fHAManagementCounselType; fHAManagementCounselType.Clean = value; _fHAManagementCounselType = fHAManagementCounselType;
                var fHAMaxLoanAmount = _fHAMaxLoanAmount; fHAMaxLoanAmount.Clean = value; _fHAMaxLoanAmount = fHAMaxLoanAmount;
                var foreclosedProperty = _foreclosedProperty; foreclosedProperty.Clean = value; _foreclosedProperty = foreclosedProperty;
                var freddieMacCounselType = _freddieMacCounselType; freddieMacCounselType.Clean = value; _freddieMacCounselType = freddieMacCounselType;
                var fundingFeePaidInCash = _fundingFeePaidInCash; fundingFeePaidInCash.Clean = value; _fundingFeePaidInCash = fundingFeePaidInCash;
                var giftFundsAmount = _giftFundsAmount; giftFundsAmount.Clean = value; _giftFundsAmount = giftFundsAmount;
                var haveReceivedLeadPaintPoisoningInfo = _haveReceivedLeadPaintPoisoningInfo; haveReceivedLeadPaintPoisoningInfo.Clean = value; _haveReceivedLeadPaintPoisoningInfo = haveReceivedLeadPaintPoisoningInfo;
                var hUD1003AddendumApproved = _hUD1003AddendumApproved; hUD1003AddendumApproved.Clean = value; _hUD1003AddendumApproved = hUD1003AddendumApproved;
                var id = _id; id.Clean = value; _id = id;
                var lastRefiDate = _lastRefiDate; lastRefiDate.Clean = value; _lastRefiDate = lastRefiDate;
                var lDPGSASearchDate = _lDPGSASearchDate; lDPGSASearchDate.Clean = value; _lDPGSASearchDate = lDPGSASearchDate;
                var lDPGSASearchedBy = _lDPGSASearchedBy; lDPGSASearchedBy.Clean = value; _lDPGSASearchedBy = lDPGSASearchedBy;
                var lenderAddress = _lenderAddress; lenderAddress.Clean = value; _lenderAddress = lenderAddress;
                var lenderCity = _lenderCity; lenderCity.Clean = value; _lenderCity = lenderCity;
                var lenderName = _lenderName; lenderName.Clean = value; _lenderName = lenderName;
                var lenderNMLS = _lenderNMLS; lenderNMLS.Clean = value; _lenderNMLS = lenderNMLS;
                var lenderPostalCode = _lenderPostalCode; lenderPostalCode.Clean = value; _lenderPostalCode = lenderPostalCode;
                var lenderRepresentativeName = _lenderRepresentativeName; lenderRepresentativeName.Clean = value; _lenderRepresentativeName = lenderRepresentativeName;
                var lenderRepresentativePhone = _lenderRepresentativePhone; lenderRepresentativePhone.Clean = value; _lenderRepresentativePhone = lenderRepresentativePhone;
                var lenderRepresentativeTitle = _lenderRepresentativeTitle; lenderRepresentativeTitle.Clean = value; _lenderRepresentativeTitle = lenderRepresentativeTitle;
                var lenderState = _lenderState; lenderState.Clean = value; _lenderState = lenderState;
                var lenderTaxID = _lenderTaxID; lenderTaxID.Clean = value; _lenderTaxID = lenderTaxID;
                var loanScoreID = _loanScoreID; loanScoreID.Clean = value; _loanScoreID = loanScoreID;
                var mIAppliedBy = _mIAppliedBy; mIAppliedBy.Clean = value; _mIAppliedBy = mIAppliedBy;
                var mIAppliedDate = _mIAppliedDate; mIAppliedDate.Clean = value; _mIAppliedDate = mIAppliedDate;
                var mICRetrivedDate = _mICRetrivedDate; mICRetrivedDate.Clean = value; _mICRetrivedDate = mICRetrivedDate;
                var minimumDownPayment = _minimumDownPayment; minimumDownPayment.Clean = value; _minimumDownPayment = minimumDownPayment;
                var mIP1stDueDate = _mIP1stDueDate; mIP1stDueDate.Clean = value; _mIP1stDueDate = mIP1stDueDate;
                var mIP1stToInvestor = _mIP1stToInvestor; mIP1stToInvestor.Clean = value; _mIP1stToInvestor = mIP1stToInvestor;
                var mIPRemittedDate = _mIPRemittedDate; mIPRemittedDate.Clean = value; _mIPRemittedDate = mIPRemittedDate;
                var mIRejectedDate = _mIRejectedDate; mIRejectedDate.Clean = value; _mIRejectedDate = mIRejectedDate;
                var modifiedInterestRate = _modifiedInterestRate; modifiedInterestRate.Clean = value; _modifiedInterestRate = modifiedInterestRate;
                var modifiedLoanAmount = _modifiedLoanAmount; modifiedLoanAmount.Clean = value; _modifiedLoanAmount = modifiedLoanAmount;
                var modifiedMonthlyPayment = _modifiedMonthlyPayment; modifiedMonthlyPayment.Clean = value; _modifiedMonthlyPayment = modifiedMonthlyPayment;
                var modifiedMonthlyPremium = _modifiedMonthlyPremium; modifiedMonthlyPremium.Clean = value; _modifiedMonthlyPremium = modifiedMonthlyPremium;
                var modifiedProposedMaturityMonth = _modifiedProposedMaturityMonth; modifiedProposedMaturityMonth.Clean = value; _modifiedProposedMaturityMonth = modifiedProposedMaturityMonth;
                var modifiedProposedMaturityYear = _modifiedProposedMaturityYear; modifiedProposedMaturityYear.Clean = value; _modifiedProposedMaturityYear = modifiedProposedMaturityYear;
                var modifiedTermAnnualPremium = _modifiedTermAnnualPremium; modifiedTermAnnualPremium.Clean = value; _modifiedTermAnnualPremium = modifiedTermAnnualPremium;
                var modifiedUpfrontPremium = _modifiedUpfrontPremium; modifiedUpfrontPremium.Clean = value; _modifiedUpfrontPremium = modifiedUpfrontPremium;
                var mortgageeRepresentative = _mortgageeRepresentative; mortgageeRepresentative.Clean = value; _mortgageeRepresentative = mortgageeRepresentative;
                var mortgageFinancialInterest = _mortgageFinancialInterest; mortgageFinancialInterest.Clean = value; _mortgageFinancialInterest = mortgageFinancialInterest;
                var nonRealtyAndOtherItems = _nonRealtyAndOtherItems; nonRealtyAndOtherItems.Clean = value; _nonRealtyAndOtherItems = nonRealtyAndOtherItems;
                var obtainCAIVRSDate = _obtainCAIVRSDate; obtainCAIVRSDate.Clean = value; _obtainCAIVRSDate = obtainCAIVRSDate;
                var occupancy = _occupancy; occupancy.Clean = value; _occupancy = occupancy;
                var oldAgencyCaseIdentifier = _oldAgencyCaseIdentifier; oldAgencyCaseIdentifier.Clean = value; _oldAgencyCaseIdentifier = oldAgencyCaseIdentifier;
                var originalMortgageAmount = _originalMortgageAmount; originalMortgageAmount.Clean = value; _originalMortgageAmount = originalMortgageAmount;
                var otherLiabilitiesMonthlyPayment = _otherLiabilitiesMonthlyPayment; otherLiabilitiesMonthlyPayment.Clean = value; _otherLiabilitiesMonthlyPayment = otherLiabilitiesMonthlyPayment;
                var otherLiabilitiesUnpaidBalance = _otherLiabilitiesUnpaidBalance; otherLiabilitiesUnpaidBalance.Clean = value; _otherLiabilitiesUnpaidBalance = otherLiabilitiesUnpaidBalance;
                var otherMonthlyShelterExpense = _otherMonthlyShelterExpense; otherMonthlyShelterExpense.Clean = value; _otherMonthlyShelterExpense = otherMonthlyShelterExpense;
                var otherTitleDescription = _otherTitleDescription; otherTitleDescription.Clean = value; _otherTitleDescription = otherTitleDescription;
                var ownMoreThanFourDwellings = _ownMoreThanFourDwellings; ownMoreThanFourDwellings.Clean = value; _ownMoreThanFourDwellings = ownMoreThanFourDwellings;
                var ownOrSoldOtherRealEstate = _ownOrSoldOtherRealEstate; ownOrSoldOtherRealEstate.Clean = value; _ownOrSoldOtherRealEstate = ownOrSoldOtherRealEstate;
                var paidAmount = _paidAmount; paidAmount.Clean = value; _paidAmount = paidAmount;
                var premiumMonths = _premiumMonths; premiumMonths.Clean = value; _premiumMonths = premiumMonths;
                var prepaidExpenses = _prepaidExpenses; prepaidExpenses.Clean = value; _prepaidExpenses = prepaidExpenses;
                var previousPurchaseDate = _previousPurchaseDate; previousPurchaseDate.Clean = value; _previousPurchaseDate = previousPurchaseDate;
                var priorEndorsementDate = _priorEndorsementDate; priorEndorsementDate.Clean = value; _priorEndorsementDate = priorEndorsementDate;
                var proposedMaturityMonths = _proposedMaturityMonths; proposedMaturityMonths.Clean = value; _proposedMaturityMonths = proposedMaturityMonths;
                var proposedMaturityYears = _proposedMaturityYears; proposedMaturityYears.Clean = value; _proposedMaturityYears = proposedMaturityYears;
                var purposeOfLoan = _purposeOfLoan; purposeOfLoan.Clean = value; _purposeOfLoan = purposeOfLoan;
                var refiAuthorizationBy = _refiAuthorizationBy; refiAuthorizationBy.Clean = value; _refiAuthorizationBy = refiAuthorizationBy;
                var refiAuthorizationDate = _refiAuthorizationDate; refiAuthorizationDate.Clean = value; _refiAuthorizationDate = refiAuthorizationDate;
                var salesPrice = _salesPrice; salesPrice.Clean = value; _salesPrice = salesPrice;
                var secondMortgageAmount = _secondMortgageAmount; secondMortgageAmount.Clean = value; _secondMortgageAmount = secondMortgageAmount;
                var sellerPaidClosingCost = _sellerPaidClosingCost; sellerPaidClosingCost.Clean = value; _sellerPaidClosingCost = sellerPaidClosingCost;
                var servingTransferedDate = _servingTransferedDate; servingTransferedDate.Clean = value; _servingTransferedDate = servingTransferedDate;
                var specialAssessments = _specialAssessments; specialAssessments.Clean = value; _specialAssessments = specialAssessments;
                var sponsorAgentAddress = _sponsorAgentAddress; sponsorAgentAddress.Clean = value; _sponsorAgentAddress = sponsorAgentAddress;
                var sponsorAgentCity = _sponsorAgentCity; sponsorAgentCity.Clean = value; _sponsorAgentCity = sponsorAgentCity;
                var sponsorAgentName = _sponsorAgentName; sponsorAgentName.Clean = value; _sponsorAgentName = sponsorAgentName;
                var sponsorAgentNMLS = _sponsorAgentNMLS; sponsorAgentNMLS.Clean = value; _sponsorAgentNMLS = sponsorAgentNMLS;
                var sponsorAgentPostalCode = _sponsorAgentPostalCode; sponsorAgentPostalCode.Clean = value; _sponsorAgentPostalCode = sponsorAgentPostalCode;
                var sponsorAgentState = _sponsorAgentState; sponsorAgentState.Clean = value; _sponsorAgentState = sponsorAgentState;
                var sponsorAgentTaxID = _sponsorAgentTaxID; sponsorAgentTaxID.Clean = value; _sponsorAgentTaxID = sponsorAgentTaxID;
                var sponsoredOriginationsName = _sponsoredOriginationsName; sponsoredOriginationsName.Clean = value; _sponsoredOriginationsName = sponsoredOriginationsName;
                var sponsoredOriginationsNMLS = _sponsoredOriginationsNMLS; sponsoredOriginationsNMLS.Clean = value; _sponsoredOriginationsNMLS = sponsoredOriginationsNMLS;
                var sponsoredOriginationsTaxID = _sponsoredOriginationsTaxID; sponsoredOriginationsTaxID.Clean = value; _sponsoredOriginationsTaxID = sponsoredOriginationsTaxID;
                var sponsorID = _sponsorID; sponsorID.Clean = value; _sponsorID = sponsorID;
                var titleVestedIn = _titleVestedIn; titleVestedIn.Clean = value; _titleVestedIn = titleVestedIn;
                var toBeSold = _toBeSold; toBeSold.Clean = value; _toBeSold = toBeSold;
                var totalClosingCost = _totalClosingCost; totalClosingCost.Clean = value; _totalClosingCost = totalClosingCost;
                var totalScorecardBy = _totalScorecardBy; totalScorecardBy.Clean = value; _totalScorecardBy = totalScorecardBy;
                var totalScorecardDate = _totalScorecardDate; totalScorecardDate.Clean = value; _totalScorecardDate = totalScorecardDate;
                var uFMIPRemittanceDueDate = _uFMIPRemittanceDueDate; uFMIPRemittanceDueDate.Clean = value; _uFMIPRemittanceDueDate = uFMIPRemittanceDueDate;
                var uFMIPRemittedAmount = _uFMIPRemittedAmount; uFMIPRemittedAmount.Clean = value; _uFMIPRemittedAmount = uFMIPRemittedAmount;
                var uFMIPRemittedBy = _uFMIPRemittedBy; uFMIPRemittedBy.Clean = value; _uFMIPRemittedBy = uFMIPRemittedBy;
                var uFMIPRemittedDate = _uFMIPRemittedDate; uFMIPRemittedDate.Clean = value; _uFMIPRemittedDate = uFMIPRemittedDate;
                var uFMIPVerificationCode = _uFMIPVerificationCode; uFMIPVerificationCode.Clean = value; _uFMIPVerificationCode = uFMIPVerificationCode;
                var useDefaultLenderInfo = _useDefaultLenderInfo; useDefaultLenderInfo.Clean = value; _useDefaultLenderInfo = useDefaultLenderInfo;
                var utilityIncluded = _utilityIncluded; utilityIncluded.Clean = value; _utilityIncluded = utilityIncluded;
                var validateAddressDate = _validateAddressDate; validateAddressDate.Clean = value; _validateAddressDate = validateAddressDate;
                var valuation = _valuation; valuation.Clean = value; _valuation = valuation;
                if (Eem != null) Eem.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FhaVaLoan()
        {
            Clean = true;
        }
    }
}