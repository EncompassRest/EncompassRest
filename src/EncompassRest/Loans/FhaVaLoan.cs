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
                    && Eem.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addendumType; v0.Clean = value; _addendumType = v0;
                var v1 = _additionalCondition1; v1.Clean = value; _additionalCondition1 = v1;
                var v2 = _additionalCondition2; v2.Clean = value; _additionalCondition2 = v2;
                var v3 = _additionalCondition3; v3.Clean = value; _additionalCondition3 = v3;
                var v4 = _additionalCondition4; v4.Clean = value; _additionalCondition4 = v4;
                var v5 = _additionalCondition5; v5.Clean = value; _additionalCondition5 = v5;
                var v6 = _additionalCondition6; v6.Clean = value; _additionalCondition6 = v6;
                var v7 = _additionalCondition7; v7.Clean = value; _additionalCondition7 = v7;
                var v8 = _additionalCondition8; v8.Clean = value; _additionalCondition8 = v8;
                var v9 = _additionalCondition9; v9.Clean = value; _additionalCondition9 = v9;
                var v10 = _addressValidatedBy; v10.Clean = value; _addressValidatedBy = v10;
                var v11 = _addressValidationMessage; v11.Clean = value; _addressValidationMessage = v11;
                var v12 = _allConditionsSatisfied; v12.Clean = value; _allConditionsSatisfied = v12;
                var v13 = _appraisalLoggedDate; v13.Clean = value; _appraisalLoggedDate = v13;
                var v14 = _appraisalLookupBy; v14.Clean = value; _appraisalLookupBy = v14;
                var v15 = _beenInformed; v15.Clean = value; _beenInformed = v15;
                var v16 = _borrowerCertificationAddress; v16.Clean = value; _borrowerCertificationAddress = v16;
                var v17 = _borrowerCertificationCity; v17.Clean = value; _borrowerCertificationCity = v17;
                var v18 = _borrowerCertificationPostalCode; v18.Clean = value; _borrowerCertificationPostalCode = v18;
                var v19 = _borrowerCertificationState; v19.Clean = value; _borrowerCertificationState = v19;
                var v20 = _cAIVRSObtainedBy; v20.Clean = value; _cAIVRSObtainedBy = v20;
                var v21 = _caseBinderShippedBy; v21.Clean = value; _caseBinderShippedBy = v21;
                var v22 = _caseBinderShippedDate; v22.Clean = value; _caseBinderShippedDate = v22;
                var v23 = _closingDate; v23.Clean = value; _closingDate = v23;
                var v24 = _condoPudID; v24.Clean = value; _condoPudID = v24;
                var v25 = _condoPudLookupBy; v25.Clean = value; _condoPudLookupBy = v25;
                var v26 = _condoPudLookupDate; v26.Clean = value; _condoPudLookupDate = v26;
                var v27 = _dateApprovalExpires; v27.Clean = value; _dateApprovalExpires = v27;
                var v28 = _dateMortgageApproved; v28.Clean = value; _dateMortgageApproved = v28;
                var v29 = _detailForOther; v29.Clean = value; _detailForOther = v29;
                var v30 = _discountPoints; v30.Clean = value; _discountPoints = v30;
                var v31 = _dulyAgentAddress; v31.Clean = value; _dulyAgentAddress = v31;
                var v32 = _dulyAgentCity; v32.Clean = value; _dulyAgentCity = v32;
                var v33 = _dulyAgentFunction1; v33.Clean = value; _dulyAgentFunction1 = v33;
                var v34 = _dulyAgentFunction2; v34.Clean = value; _dulyAgentFunction2 = v34;
                var v35 = _dulyAgentName; v35.Clean = value; _dulyAgentName = v35;
                var v36 = _dulyAgentState; v36.Clean = value; _dulyAgentState = v36;
                var v37 = _dwellingCoveredBy; v37.Clean = value; _dwellingCoveredBy = v37;
                var v38 = _eligibilityAssessment; v38.Clean = value; _eligibilityAssessment = v38;
                var v39 = _energyEfficientMortgageAmount; v39.Clean = value; _energyEfficientMortgageAmount = v39;
                var v40 = _energyEfficientMortgageItems; v40.Clean = value; _energyEfficientMortgageItems = v40;
                var v41 = _everHadVAHomeLoan; v41.Clean = value; _everHadVAHomeLoan = v41;
                var v42 = _excessContributionAmount; v42.Clean = value; _excessContributionAmount = v42;
                var v43 = _existingDebtAmount; v43.Clean = value; _existingDebtAmount = v43;
                var v44 = _fHACaseOrderedBy; v44.Clean = value; _fHACaseOrderedBy = v44;
                var v45 = _fHAManagementCounselType; v45.Clean = value; _fHAManagementCounselType = v45;
                var v46 = _fHAMaxLoanAmount; v46.Clean = value; _fHAMaxLoanAmount = v46;
                var v47 = _foreclosedProperty; v47.Clean = value; _foreclosedProperty = v47;
                var v48 = _freddieMacCounselType; v48.Clean = value; _freddieMacCounselType = v48;
                var v49 = _fundingFeePaidInCash; v49.Clean = value; _fundingFeePaidInCash = v49;
                var v50 = _giftFundsAmount; v50.Clean = value; _giftFundsAmount = v50;
                var v51 = _haveReceivedLeadPaintPoisoningInfo; v51.Clean = value; _haveReceivedLeadPaintPoisoningInfo = v51;
                var v52 = _hUD1003AddendumApproved; v52.Clean = value; _hUD1003AddendumApproved = v52;
                var v53 = _id; v53.Clean = value; _id = v53;
                var v54 = _lastRefiDate; v54.Clean = value; _lastRefiDate = v54;
                var v55 = _lDPGSASearchDate; v55.Clean = value; _lDPGSASearchDate = v55;
                var v56 = _lDPGSASearchedBy; v56.Clean = value; _lDPGSASearchedBy = v56;
                var v57 = _lenderAddress; v57.Clean = value; _lenderAddress = v57;
                var v58 = _lenderCity; v58.Clean = value; _lenderCity = v58;
                var v59 = _lenderName; v59.Clean = value; _lenderName = v59;
                var v60 = _lenderNMLS; v60.Clean = value; _lenderNMLS = v60;
                var v61 = _lenderPostalCode; v61.Clean = value; _lenderPostalCode = v61;
                var v62 = _lenderRepresentativeName; v62.Clean = value; _lenderRepresentativeName = v62;
                var v63 = _lenderRepresentativePhone; v63.Clean = value; _lenderRepresentativePhone = v63;
                var v64 = _lenderRepresentativeTitle; v64.Clean = value; _lenderRepresentativeTitle = v64;
                var v65 = _lenderState; v65.Clean = value; _lenderState = v65;
                var v66 = _lenderTaxID; v66.Clean = value; _lenderTaxID = v66;
                var v67 = _loanScoreID; v67.Clean = value; _loanScoreID = v67;
                var v68 = _mIAppliedBy; v68.Clean = value; _mIAppliedBy = v68;
                var v69 = _mIAppliedDate; v69.Clean = value; _mIAppliedDate = v69;
                var v70 = _mICRetrivedDate; v70.Clean = value; _mICRetrivedDate = v70;
                var v71 = _minimumDownPayment; v71.Clean = value; _minimumDownPayment = v71;
                var v72 = _mIP1stDueDate; v72.Clean = value; _mIP1stDueDate = v72;
                var v73 = _mIP1stToInvestor; v73.Clean = value; _mIP1stToInvestor = v73;
                var v74 = _mIPRemittedDate; v74.Clean = value; _mIPRemittedDate = v74;
                var v75 = _mIRejectedDate; v75.Clean = value; _mIRejectedDate = v75;
                var v76 = _modifiedInterestRate; v76.Clean = value; _modifiedInterestRate = v76;
                var v77 = _modifiedLoanAmount; v77.Clean = value; _modifiedLoanAmount = v77;
                var v78 = _modifiedMonthlyPayment; v78.Clean = value; _modifiedMonthlyPayment = v78;
                var v79 = _modifiedMonthlyPremium; v79.Clean = value; _modifiedMonthlyPremium = v79;
                var v80 = _modifiedProposedMaturityMonth; v80.Clean = value; _modifiedProposedMaturityMonth = v80;
                var v81 = _modifiedProposedMaturityYear; v81.Clean = value; _modifiedProposedMaturityYear = v81;
                var v82 = _modifiedTermAnnualPremium; v82.Clean = value; _modifiedTermAnnualPremium = v82;
                var v83 = _modifiedUpfrontPremium; v83.Clean = value; _modifiedUpfrontPremium = v83;
                var v84 = _mortgageeRepresentative; v84.Clean = value; _mortgageeRepresentative = v84;
                var v85 = _mortgageFinancialInterest; v85.Clean = value; _mortgageFinancialInterest = v85;
                var v86 = _nonRealtyAndOtherItems; v86.Clean = value; _nonRealtyAndOtherItems = v86;
                var v87 = _obtainCAIVRSDate; v87.Clean = value; _obtainCAIVRSDate = v87;
                var v88 = _occupancy; v88.Clean = value; _occupancy = v88;
                var v89 = _oldAgencyCaseIdentifier; v89.Clean = value; _oldAgencyCaseIdentifier = v89;
                var v90 = _originalMortgageAmount; v90.Clean = value; _originalMortgageAmount = v90;
                var v91 = _otherLiabilitiesMonthlyPayment; v91.Clean = value; _otherLiabilitiesMonthlyPayment = v91;
                var v92 = _otherLiabilitiesUnpaidBalance; v92.Clean = value; _otherLiabilitiesUnpaidBalance = v92;
                var v93 = _otherMonthlyShelterExpense; v93.Clean = value; _otherMonthlyShelterExpense = v93;
                var v94 = _otherTitleDescription; v94.Clean = value; _otherTitleDescription = v94;
                var v95 = _ownMoreThanFourDwellings; v95.Clean = value; _ownMoreThanFourDwellings = v95;
                var v96 = _ownOrSoldOtherRealEstate; v96.Clean = value; _ownOrSoldOtherRealEstate = v96;
                var v97 = _paidAmount; v97.Clean = value; _paidAmount = v97;
                var v98 = _premiumMonths; v98.Clean = value; _premiumMonths = v98;
                var v99 = _prepaidExpenses; v99.Clean = value; _prepaidExpenses = v99;
                var v100 = _previousPurchaseDate; v100.Clean = value; _previousPurchaseDate = v100;
                var v101 = _priorEndorsementDate; v101.Clean = value; _priorEndorsementDate = v101;
                var v102 = _proposedMaturityMonths; v102.Clean = value; _proposedMaturityMonths = v102;
                var v103 = _proposedMaturityYears; v103.Clean = value; _proposedMaturityYears = v103;
                var v104 = _purposeOfLoan; v104.Clean = value; _purposeOfLoan = v104;
                var v105 = _refiAuthorizationBy; v105.Clean = value; _refiAuthorizationBy = v105;
                var v106 = _refiAuthorizationDate; v106.Clean = value; _refiAuthorizationDate = v106;
                var v107 = _salesPrice; v107.Clean = value; _salesPrice = v107;
                var v108 = _secondMortgageAmount; v108.Clean = value; _secondMortgageAmount = v108;
                var v109 = _sellerPaidClosingCost; v109.Clean = value; _sellerPaidClosingCost = v109;
                var v110 = _servingTransferedDate; v110.Clean = value; _servingTransferedDate = v110;
                var v111 = _specialAssessments; v111.Clean = value; _specialAssessments = v111;
                var v112 = _sponsorAgentAddress; v112.Clean = value; _sponsorAgentAddress = v112;
                var v113 = _sponsorAgentCity; v113.Clean = value; _sponsorAgentCity = v113;
                var v114 = _sponsorAgentName; v114.Clean = value; _sponsorAgentName = v114;
                var v115 = _sponsorAgentNMLS; v115.Clean = value; _sponsorAgentNMLS = v115;
                var v116 = _sponsorAgentPostalCode; v116.Clean = value; _sponsorAgentPostalCode = v116;
                var v117 = _sponsorAgentState; v117.Clean = value; _sponsorAgentState = v117;
                var v118 = _sponsorAgentTaxID; v118.Clean = value; _sponsorAgentTaxID = v118;
                var v119 = _sponsoredOriginationsName; v119.Clean = value; _sponsoredOriginationsName = v119;
                var v120 = _sponsoredOriginationsNMLS; v120.Clean = value; _sponsoredOriginationsNMLS = v120;
                var v121 = _sponsoredOriginationsTaxID; v121.Clean = value; _sponsoredOriginationsTaxID = v121;
                var v122 = _sponsorID; v122.Clean = value; _sponsorID = v122;
                var v123 = _titleVestedIn; v123.Clean = value; _titleVestedIn = v123;
                var v124 = _toBeSold; v124.Clean = value; _toBeSold = v124;
                var v125 = _totalClosingCost; v125.Clean = value; _totalClosingCost = v125;
                var v126 = _totalScorecardBy; v126.Clean = value; _totalScorecardBy = v126;
                var v127 = _totalScorecardDate; v127.Clean = value; _totalScorecardDate = v127;
                var v128 = _uFMIPRemittanceDueDate; v128.Clean = value; _uFMIPRemittanceDueDate = v128;
                var v129 = _uFMIPRemittedAmount; v129.Clean = value; _uFMIPRemittedAmount = v129;
                var v130 = _uFMIPRemittedBy; v130.Clean = value; _uFMIPRemittedBy = v130;
                var v131 = _uFMIPRemittedDate; v131.Clean = value; _uFMIPRemittedDate = v131;
                var v132 = _uFMIPVerificationCode; v132.Clean = value; _uFMIPVerificationCode = v132;
                var v133 = _useDefaultLenderInfo; v133.Clean = value; _useDefaultLenderInfo = v133;
                var v134 = _utilityIncluded; v134.Clean = value; _utilityIncluded = v134;
                var v135 = _validateAddressDate; v135.Clean = value; _validateAddressDate = v135;
                var v136 = _valuation; v136.Clean = value; _valuation = v136;
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