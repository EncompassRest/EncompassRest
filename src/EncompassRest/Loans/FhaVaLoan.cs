#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FhaVaLoan : ExtensibleObject
    {
        private DirtyValue<StringEnumValue<AddendumType>> _addendumType;
        public StringEnumValue<AddendumType> AddendumType { get => _addendumType; set => _addendumType = value; }
        private DirtyValue<bool?> _additionalCondition1;
        public bool? AdditionalCondition1 { get => _additionalCondition1; set => _additionalCondition1 = value; }
        private DirtyValue<bool?> _additionalCondition2;
        public bool? AdditionalCondition2 { get => _additionalCondition2; set => _additionalCondition2 = value; }
        private DirtyValue<bool?> _additionalCondition3;
        public bool? AdditionalCondition3 { get => _additionalCondition3; set => _additionalCondition3 = value; }
        private DirtyValue<bool?> _additionalCondition4;
        public bool? AdditionalCondition4 { get => _additionalCondition4; set => _additionalCondition4 = value; }
        private DirtyValue<bool?> _additionalCondition5;
        public bool? AdditionalCondition5 { get => _additionalCondition5; set => _additionalCondition5 = value; }
        private DirtyValue<bool?> _additionalCondition6;
        public bool? AdditionalCondition6 { get => _additionalCondition6; set => _additionalCondition6 = value; }
        private DirtyValue<bool?> _additionalCondition7;
        public bool? AdditionalCondition7 { get => _additionalCondition7; set => _additionalCondition7 = value; }
        private DirtyValue<bool?> _additionalCondition8;
        public bool? AdditionalCondition8 { get => _additionalCondition8; set => _additionalCondition8 = value; }
        private DirtyValue<bool?> _additionalCondition9;
        public bool? AdditionalCondition9 { get => _additionalCondition9; set => _additionalCondition9 = value; }
        private DirtyValue<string> _addressValidatedBy;
        public string AddressValidatedBy { get => _addressValidatedBy; set => _addressValidatedBy = value; }
        private DirtyValue<string> _addressValidationMessage;
        public string AddressValidationMessage { get => _addressValidationMessage; set => _addressValidationMessage = value; }
        private DirtyValue<bool?> _allConditionsSatisfied;
        public bool? AllConditionsSatisfied { get => _allConditionsSatisfied; set => _allConditionsSatisfied = value; }
        private DirtyValue<DateTime?> _appraisalLoggedDate;
        public DateTime? AppraisalLoggedDate { get => _appraisalLoggedDate; set => _appraisalLoggedDate = value; }
        private DirtyValue<string> _appraisalLookupBy;
        public string AppraisalLookupBy { get => _appraisalLookupBy; set => _appraisalLookupBy = value; }
        private DirtyValue<StringEnumValue<BeenInformed>> _beenInformed;
        public StringEnumValue<BeenInformed> BeenInformed { get => _beenInformed; set => _beenInformed = value; }
        private DirtyValue<string> _borrowerCertificationAddress;
        public string BorrowerCertificationAddress { get => _borrowerCertificationAddress; set => _borrowerCertificationAddress = value; }
        private DirtyValue<string> _borrowerCertificationCity;
        public string BorrowerCertificationCity { get => _borrowerCertificationCity; set => _borrowerCertificationCity = value; }
        private DirtyValue<string> _borrowerCertificationPostalCode;
        public string BorrowerCertificationPostalCode { get => _borrowerCertificationPostalCode; set => _borrowerCertificationPostalCode = value; }
        private DirtyValue<string> _borrowerCertificationState;
        public string BorrowerCertificationState { get => _borrowerCertificationState; set => _borrowerCertificationState = value; }
        private DirtyValue<string> _cAIVRSObtainedBy;
        public string CAIVRSObtainedBy { get => _cAIVRSObtainedBy; set => _cAIVRSObtainedBy = value; }
        private DirtyValue<string> _caseBinderShippedBy;
        public string CaseBinderShippedBy { get => _caseBinderShippedBy; set => _caseBinderShippedBy = value; }
        private DirtyValue<DateTime?> _caseBinderShippedDate;
        public DateTime? CaseBinderShippedDate { get => _caseBinderShippedDate; set => _caseBinderShippedDate = value; }
        private DirtyValue<DateTime?> _closingDate;
        public DateTime? ClosingDate { get => _closingDate; set => _closingDate = value; }
        private DirtyValue<string> _condoPudID;
        public string CondoPudID { get => _condoPudID; set => _condoPudID = value; }
        private DirtyValue<string> _condoPudLookupBy;
        public string CondoPudLookupBy { get => _condoPudLookupBy; set => _condoPudLookupBy = value; }
        private DirtyValue<DateTime?> _condoPudLookupDate;
        public DateTime? CondoPudLookupDate { get => _condoPudLookupDate; set => _condoPudLookupDate = value; }
        private DirtyValue<DateTime?> _dateApprovalExpires;
        public DateTime? DateApprovalExpires { get => _dateApprovalExpires; set => _dateApprovalExpires = value; }
        private DirtyValue<DateTime?> _dateMortgageApproved;
        public DateTime? DateMortgageApproved { get => _dateMortgageApproved; set => _dateMortgageApproved = value; }
        private DirtyValue<string> _detailForOther;
        public string DetailForOther { get => _detailForOther; set => _detailForOther = value; }
        private DirtyValue<decimal?> _discountPoints;
        public decimal? DiscountPoints { get => _discountPoints; set => _discountPoints = value; }
        private DirtyValue<string> _dulyAgentAddress;
        public string DulyAgentAddress { get => _dulyAgentAddress; set => _dulyAgentAddress = value; }
        private DirtyValue<string> _dulyAgentCity;
        public string DulyAgentCity { get => _dulyAgentCity; set => _dulyAgentCity = value; }
        private DirtyValue<string> _dulyAgentFunction1;
        public string DulyAgentFunction1 { get => _dulyAgentFunction1; set => _dulyAgentFunction1 = value; }
        private DirtyValue<string> _dulyAgentFunction2;
        public string DulyAgentFunction2 { get => _dulyAgentFunction2; set => _dulyAgentFunction2 = value; }
        private DirtyValue<string> _dulyAgentName;
        public string DulyAgentName { get => _dulyAgentName; set => _dulyAgentName = value; }
        private DirtyValue<string> _dulyAgentState;
        public string DulyAgentState { get => _dulyAgentState; set => _dulyAgentState = value; }
        private DirtyValue<bool?> _dwellingCoveredBy;
        public bool? DwellingCoveredBy { get => _dwellingCoveredBy; set => _dwellingCoveredBy = value; }
        private EnergyEfficientMortgage _eem;
        public EnergyEfficientMortgage Eem { get => _eem ?? (_eem = new EnergyEfficientMortgage()); set => _eem = value; }
        private DirtyValue<StringEnumValue<EligibilityAssessment>> _eligibilityAssessment;
        public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => _eligibilityAssessment; set => _eligibilityAssessment = value; }
        private DirtyValue<decimal?> _energyEfficientMortgageAmount;
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => _energyEfficientMortgageAmount = value; }
        private DirtyList<EnergyEfficientMortgageItem> _energyEfficientMortgageItems;
        public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => _energyEfficientMortgageItems ?? (_energyEfficientMortgageItems = new DirtyList<EnergyEfficientMortgageItem>()); set => _energyEfficientMortgageItems = new DirtyList<EnergyEfficientMortgageItem>(value); }
        private DirtyValue<bool?> _everHadVAHomeLoan;
        public bool? EverHadVAHomeLoan { get => _everHadVAHomeLoan; set => _everHadVAHomeLoan = value; }
        private DirtyValue<decimal?> _excessContributionAmount;
        public decimal? ExcessContributionAmount { get => _excessContributionAmount; set => _excessContributionAmount = value; }
        private DirtyValue<decimal?> _existingDebtAmount;
        public decimal? ExistingDebtAmount { get => _existingDebtAmount; set => _existingDebtAmount = value; }
        private DirtyValue<string> _fHACaseOrderedBy;
        public string FHACaseOrderedBy { get => _fHACaseOrderedBy; set => _fHACaseOrderedBy = value; }
        private DirtyValue<StringEnumValue<FHAManagementCounselType>> _fHAManagementCounselType;
        public StringEnumValue<FHAManagementCounselType> FHAManagementCounselType { get => _fHAManagementCounselType; set => _fHAManagementCounselType = value; }
        private DirtyValue<decimal?> _fHAMaxLoanAmount;
        public decimal? FHAMaxLoanAmount { get => _fHAMaxLoanAmount; set => _fHAMaxLoanAmount = value; }
        private DirtyValue<bool?> _foreclosedProperty;
        public bool? ForeclosedProperty { get => _foreclosedProperty; set => _foreclosedProperty = value; }
        private DirtyValue<StringEnumValue<FreddieMacCounselType>> _freddieMacCounselType;
        public StringEnumValue<FreddieMacCounselType> FreddieMacCounselType { get => _freddieMacCounselType; set => _freddieMacCounselType = value; }
        private DirtyValue<decimal?> _fundingFeePaidInCash;
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => _fundingFeePaidInCash = value; }
        private DirtyValue<decimal?> _giftFundsAmount;
        public decimal? GiftFundsAmount { get => _giftFundsAmount; set => _giftFundsAmount = value; }
        private DirtyValue<bool?> _haveReceivedLeadPaintPoisoningInfo;
        public bool? HaveReceivedLeadPaintPoisoningInfo { get => _haveReceivedLeadPaintPoisoningInfo; set => _haveReceivedLeadPaintPoisoningInfo = value; }
        private DirtyValue<StringEnumValue<HUD1003AddendumApproved>> _hUD1003AddendumApproved;
        public StringEnumValue<HUD1003AddendumApproved> HUD1003AddendumApproved { get => _hUD1003AddendumApproved; set => _hUD1003AddendumApproved = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _lastRefiDate;
        public DateTime? LastRefiDate { get => _lastRefiDate; set => _lastRefiDate = value; }
        private DirtyValue<DateTime?> _lDPGSASearchDate;
        public DateTime? LDPGSASearchDate { get => _lDPGSASearchDate; set => _lDPGSASearchDate = value; }
        private DirtyValue<string> _lDPGSASearchedBy;
        public string LDPGSASearchedBy { get => _lDPGSASearchedBy; set => _lDPGSASearchedBy = value; }
        private DirtyValue<string> _lenderAddress;
        public string LenderAddress { get => _lenderAddress; set => _lenderAddress = value; }
        private DirtyValue<string> _lenderCity;
        public string LenderCity { get => _lenderCity; set => _lenderCity = value; }
        private DirtyValue<string> _lenderName;
        public string LenderName { get => _lenderName; set => _lenderName = value; }
        private DirtyValue<string> _lenderNMLS;
        public string LenderNMLS { get => _lenderNMLS; set => _lenderNMLS = value; }
        private DirtyValue<string> _lenderPostalCode;
        public string LenderPostalCode { get => _lenderPostalCode; set => _lenderPostalCode = value; }
        private DirtyValue<string> _lenderRepresentativeName;
        public string LenderRepresentativeName { get => _lenderRepresentativeName; set => _lenderRepresentativeName = value; }
        private DirtyValue<string> _lenderRepresentativePhone;
        public string LenderRepresentativePhone { get => _lenderRepresentativePhone; set => _lenderRepresentativePhone = value; }
        private DirtyValue<string> _lenderRepresentativeTitle;
        public string LenderRepresentativeTitle { get => _lenderRepresentativeTitle; set => _lenderRepresentativeTitle = value; }
        private DirtyValue<string> _lenderState;
        public string LenderState { get => _lenderState; set => _lenderState = value; }
        private DirtyValue<string> _lenderTaxID;
        public string LenderTaxID { get => _lenderTaxID; set => _lenderTaxID = value; }
        private DirtyValue<string> _loanScoreID;
        public string LoanScoreID { get => _loanScoreID; set => _loanScoreID = value; }
        private DirtyValue<string> _mIAppliedBy;
        public string MIAppliedBy { get => _mIAppliedBy; set => _mIAppliedBy = value; }
        private DirtyValue<DateTime?> _mIAppliedDate;
        public DateTime? MIAppliedDate { get => _mIAppliedDate; set => _mIAppliedDate = value; }
        private DirtyValue<DateTime?> _mICRetrivedDate;
        public DateTime? MICRetrivedDate { get => _mICRetrivedDate; set => _mICRetrivedDate = value; }
        private DirtyValue<decimal?> _minimumDownPayment;
        public decimal? MinimumDownPayment { get => _minimumDownPayment; set => _minimumDownPayment = value; }
        private DirtyValue<DateTime?> _mIP1stDueDate;
        public DateTime? MIP1stDueDate { get => _mIP1stDueDate; set => _mIP1stDueDate = value; }
        private DirtyValue<DateTime?> _mIP1stToInvestor;
        public DateTime? MIP1stToInvestor { get => _mIP1stToInvestor; set => _mIP1stToInvestor = value; }
        private DirtyValue<DateTime?> _mIPRemittedDate;
        public DateTime? MIPRemittedDate { get => _mIPRemittedDate; set => _mIPRemittedDate = value; }
        private DirtyValue<DateTime?> _mIRejectedDate;
        public DateTime? MIRejectedDate { get => _mIRejectedDate; set => _mIRejectedDate = value; }
        private DirtyValue<decimal?> _modifiedInterestRate;
        public decimal? ModifiedInterestRate { get => _modifiedInterestRate; set => _modifiedInterestRate = value; }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => _modifiedLoanAmount = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => _modifiedMonthlyPayment = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPremium;
        public decimal? ModifiedMonthlyPremium { get => _modifiedMonthlyPremium; set => _modifiedMonthlyPremium = value; }
        private DirtyValue<int?> _modifiedProposedMaturityMonth;
        public int? ModifiedProposedMaturityMonth { get => _modifiedProposedMaturityMonth; set => _modifiedProposedMaturityMonth = value; }
        private DirtyValue<int?> _modifiedProposedMaturityYear;
        public int? ModifiedProposedMaturityYear { get => _modifiedProposedMaturityYear; set => _modifiedProposedMaturityYear = value; }
        private DirtyValue<int?> _modifiedTermAnnualPremium;
        public int? ModifiedTermAnnualPremium { get => _modifiedTermAnnualPremium; set => _modifiedTermAnnualPremium = value; }
        private DirtyValue<decimal?> _modifiedUpfrontPremium;
        public decimal? ModifiedUpfrontPremium { get => _modifiedUpfrontPremium; set => _modifiedUpfrontPremium = value; }
        private DirtyValue<string> _mortgageeRepresentative;
        public string MortgageeRepresentative { get => _mortgageeRepresentative; set => _mortgageeRepresentative = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot>> _mortgageFinancialInterest;
        public StringEnumValue<DoesOrDoesNot> MortgageFinancialInterest { get => _mortgageFinancialInterest; set => _mortgageFinancialInterest = value; }
        private DirtyValue<decimal?> _nonRealtyAndOtherItems;
        public decimal? NonRealtyAndOtherItems { get => _nonRealtyAndOtherItems; set => _nonRealtyAndOtherItems = value; }
        private DirtyValue<DateTime?> _obtainCAIVRSDate;
        public DateTime? ObtainCAIVRSDate { get => _obtainCAIVRSDate; set => _obtainCAIVRSDate = value; }
        private DirtyValue<StringEnumValue<Occupancy>> _occupancy;
        public StringEnumValue<Occupancy> Occupancy { get => _occupancy; set => _occupancy = value; }
        private DirtyValue<string> _oldAgencyCaseIdentifier;
        public string OldAgencyCaseIdentifier { get => _oldAgencyCaseIdentifier; set => _oldAgencyCaseIdentifier = value; }
        private DirtyValue<decimal?> _originalMortgageAmount;
        public decimal? OriginalMortgageAmount { get => _originalMortgageAmount; set => _originalMortgageAmount = value; }
        private DirtyValue<decimal?> _otherLiabilitiesMonthlyPayment;
        public decimal? OtherLiabilitiesMonthlyPayment { get => _otherLiabilitiesMonthlyPayment; set => _otherLiabilitiesMonthlyPayment = value; }
        private DirtyValue<decimal?> _otherLiabilitiesUnpaidBalance;
        public decimal? OtherLiabilitiesUnpaidBalance { get => _otherLiabilitiesUnpaidBalance; set => _otherLiabilitiesUnpaidBalance = value; }
        private DirtyValue<decimal?> _otherMonthlyShelterExpense;
        public decimal? OtherMonthlyShelterExpense { get => _otherMonthlyShelterExpense; set => _otherMonthlyShelterExpense = value; }
        private DirtyValue<string> _otherTitleDescription;
        public string OtherTitleDescription { get => _otherTitleDescription; set => _otherTitleDescription = value; }
        private DirtyValue<bool?> _ownMoreThanFourDwellings;
        public bool? OwnMoreThanFourDwellings { get => _ownMoreThanFourDwellings; set => _ownMoreThanFourDwellings = value; }
        private DirtyValue<bool?> _ownOrSoldOtherRealEstate;
        public bool? OwnOrSoldOtherRealEstate { get => _ownOrSoldOtherRealEstate; set => _ownOrSoldOtherRealEstate = value; }
        private DirtyValue<decimal?> _paidAmount;
        public decimal? PaidAmount { get => _paidAmount; set => _paidAmount = value; }
        private DirtyValue<int?> _premiumMonths;
        public int? PremiumMonths { get => _premiumMonths; set => _premiumMonths = value; }
        private DirtyValue<decimal?> _prepaidExpenses;
        public decimal? PrepaidExpenses { get => _prepaidExpenses; set => _prepaidExpenses = value; }
        private DirtyValue<DateTime?> _previousPurchaseDate;
        public DateTime? PreviousPurchaseDate { get => _previousPurchaseDate; set => _previousPurchaseDate = value; }
        private DirtyValue<DateTime?> _priorEndorsementDate;
        public DateTime? PriorEndorsementDate { get => _priorEndorsementDate; set => _priorEndorsementDate = value; }
        private DirtyValue<int?> _proposedMaturityMonths;
        public int? ProposedMaturityMonths { get => _proposedMaturityMonths; set => _proposedMaturityMonths = value; }
        private DirtyValue<int?> _proposedMaturityYears;
        public int? ProposedMaturityYears { get => _proposedMaturityYears; set => _proposedMaturityYears = value; }
        private DirtyValue<StringEnumValue<FhaVaLoanPurposeOfLoan>> _purposeOfLoan;
        public StringEnumValue<FhaVaLoanPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => _purposeOfLoan = value; }
        private DirtyValue<string> _refiAuthorizationBy;
        public string RefiAuthorizationBy { get => _refiAuthorizationBy; set => _refiAuthorizationBy = value; }
        private DirtyValue<DateTime?> _refiAuthorizationDate;
        public DateTime? RefiAuthorizationDate { get => _refiAuthorizationDate; set => _refiAuthorizationDate = value; }
        private DirtyValue<decimal?> _salesPrice;
        public decimal? SalesPrice { get => _salesPrice; set => _salesPrice = value; }
        private DirtyValue<decimal?> _secondMortgageAmount;
        public decimal? SecondMortgageAmount { get => _secondMortgageAmount; set => _secondMortgageAmount = value; }
        private DirtyValue<decimal?> _sellerPaidClosingCost;
        public decimal? SellerPaidClosingCost { get => _sellerPaidClosingCost; set => _sellerPaidClosingCost = value; }
        private DirtyValue<DateTime?> _servingTransferedDate;
        public DateTime? ServingTransferedDate { get => _servingTransferedDate; set => _servingTransferedDate = value; }
        private DirtyValue<decimal?> _specialAssessments;
        public decimal? SpecialAssessments { get => _specialAssessments; set => _specialAssessments = value; }
        private DirtyValue<string> _sponsorAgentAddress;
        public string SponsorAgentAddress { get => _sponsorAgentAddress; set => _sponsorAgentAddress = value; }
        private DirtyValue<string> _sponsorAgentCity;
        public string SponsorAgentCity { get => _sponsorAgentCity; set => _sponsorAgentCity = value; }
        private DirtyValue<string> _sponsorAgentName;
        public string SponsorAgentName { get => _sponsorAgentName; set => _sponsorAgentName = value; }
        private DirtyValue<string> _sponsorAgentNMLS;
        public string SponsorAgentNMLS { get => _sponsorAgentNMLS; set => _sponsorAgentNMLS = value; }
        private DirtyValue<string> _sponsorAgentPostalCode;
        public string SponsorAgentPostalCode { get => _sponsorAgentPostalCode; set => _sponsorAgentPostalCode = value; }
        private DirtyValue<string> _sponsorAgentState;
        public string SponsorAgentState { get => _sponsorAgentState; set => _sponsorAgentState = value; }
        private DirtyValue<string> _sponsorAgentTaxID;
        public string SponsorAgentTaxID { get => _sponsorAgentTaxID; set => _sponsorAgentTaxID = value; }
        private DirtyValue<string> _sponsoredOriginationsName;
        public string SponsoredOriginationsName { get => _sponsoredOriginationsName; set => _sponsoredOriginationsName = value; }
        private DirtyValue<string> _sponsoredOriginationsNMLS;
        public string SponsoredOriginationsNMLS { get => _sponsoredOriginationsNMLS; set => _sponsoredOriginationsNMLS = value; }
        private DirtyValue<string> _sponsoredOriginationsTaxID;
        public string SponsoredOriginationsTaxID { get => _sponsoredOriginationsTaxID; set => _sponsoredOriginationsTaxID = value; }
        private DirtyValue<string> _sponsorID;
        public string SponsorID { get => _sponsorID; set => _sponsorID = value; }
        private DirtyValue<StringEnumValue<TitleVestedIn>> _titleVestedIn;
        public StringEnumValue<TitleVestedIn> TitleVestedIn { get => _titleVestedIn; set => _titleVestedIn = value; }
        private DirtyValue<bool?> _toBeSold;
        public bool? ToBeSold { get => _toBeSold; set => _toBeSold = value; }
        private DirtyValue<decimal?> _totalClosingCost;
        public decimal? TotalClosingCost { get => _totalClosingCost; set => _totalClosingCost = value; }
        private DirtyValue<string> _totalScorecardBy;
        public string TotalScorecardBy { get => _totalScorecardBy; set => _totalScorecardBy = value; }
        private DirtyValue<DateTime?> _totalScorecardDate;
        public DateTime? TotalScorecardDate { get => _totalScorecardDate; set => _totalScorecardDate = value; }
        private DirtyValue<DateTime?> _uFMIPRemittanceDueDate;
        public DateTime? UFMIPRemittanceDueDate { get => _uFMIPRemittanceDueDate; set => _uFMIPRemittanceDueDate = value; }
        private DirtyValue<decimal?> _uFMIPRemittedAmount;
        public decimal? UFMIPRemittedAmount { get => _uFMIPRemittedAmount; set => _uFMIPRemittedAmount = value; }
        private DirtyValue<string> _uFMIPRemittedBy;
        public string UFMIPRemittedBy { get => _uFMIPRemittedBy; set => _uFMIPRemittedBy = value; }
        private DirtyValue<DateTime?> _uFMIPRemittedDate;
        public DateTime? UFMIPRemittedDate { get => _uFMIPRemittedDate; set => _uFMIPRemittedDate = value; }
        private DirtyValue<string> _uFMIPVerificationCode;
        public string UFMIPVerificationCode { get => _uFMIPVerificationCode; set => _uFMIPVerificationCode = value; }
        private DirtyValue<bool?> _useDefaultLenderInfo;
        public bool? UseDefaultLenderInfo { get => _useDefaultLenderInfo; set => _useDefaultLenderInfo = value; }
        private DirtyValue<bool?> _utilityIncluded;
        public bool? UtilityIncluded { get => _utilityIncluded; set => _utilityIncluded = value; }
        private DirtyValue<DateTime?> _validateAddressDate;
        public DateTime? ValidateAddressDate { get => _validateAddressDate; set => _validateAddressDate = value; }
        private DirtyValue<StringEnumValue<Valuation>> _valuation;
        public StringEnumValue<Valuation> Valuation { get => _valuation; set => _valuation = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _addendumType.Dirty
                    || _additionalCondition1.Dirty
                    || _additionalCondition2.Dirty
                    || _additionalCondition3.Dirty
                    || _additionalCondition4.Dirty
                    || _additionalCondition5.Dirty
                    || _additionalCondition6.Dirty
                    || _additionalCondition7.Dirty
                    || _additionalCondition8.Dirty
                    || _additionalCondition9.Dirty
                    || _addressValidatedBy.Dirty
                    || _addressValidationMessage.Dirty
                    || _allConditionsSatisfied.Dirty
                    || _appraisalLoggedDate.Dirty
                    || _appraisalLookupBy.Dirty
                    || _beenInformed.Dirty
                    || _borrowerCertificationAddress.Dirty
                    || _borrowerCertificationCity.Dirty
                    || _borrowerCertificationPostalCode.Dirty
                    || _borrowerCertificationState.Dirty
                    || _cAIVRSObtainedBy.Dirty
                    || _caseBinderShippedBy.Dirty
                    || _caseBinderShippedDate.Dirty
                    || _closingDate.Dirty
                    || _condoPudID.Dirty
                    || _condoPudLookupBy.Dirty
                    || _condoPudLookupDate.Dirty
                    || _dateApprovalExpires.Dirty
                    || _dateMortgageApproved.Dirty
                    || _detailForOther.Dirty
                    || _discountPoints.Dirty
                    || _dulyAgentAddress.Dirty
                    || _dulyAgentCity.Dirty
                    || _dulyAgentFunction1.Dirty
                    || _dulyAgentFunction2.Dirty
                    || _dulyAgentName.Dirty
                    || _dulyAgentState.Dirty
                    || _dwellingCoveredBy.Dirty
                    || _eligibilityAssessment.Dirty
                    || _energyEfficientMortgageAmount.Dirty
                    || _everHadVAHomeLoan.Dirty
                    || _excessContributionAmount.Dirty
                    || _existingDebtAmount.Dirty
                    || _fHACaseOrderedBy.Dirty
                    || _fHAManagementCounselType.Dirty
                    || _fHAMaxLoanAmount.Dirty
                    || _foreclosedProperty.Dirty
                    || _freddieMacCounselType.Dirty
                    || _fundingFeePaidInCash.Dirty
                    || _giftFundsAmount.Dirty
                    || _haveReceivedLeadPaintPoisoningInfo.Dirty
                    || _hUD1003AddendumApproved.Dirty
                    || _id.Dirty
                    || _lastRefiDate.Dirty
                    || _lDPGSASearchDate.Dirty
                    || _lDPGSASearchedBy.Dirty
                    || _lenderAddress.Dirty
                    || _lenderCity.Dirty
                    || _lenderName.Dirty
                    || _lenderNMLS.Dirty
                    || _lenderPostalCode.Dirty
                    || _lenderRepresentativeName.Dirty
                    || _lenderRepresentativePhone.Dirty
                    || _lenderRepresentativeTitle.Dirty
                    || _lenderState.Dirty
                    || _lenderTaxID.Dirty
                    || _loanScoreID.Dirty
                    || _mIAppliedBy.Dirty
                    || _mIAppliedDate.Dirty
                    || _mICRetrivedDate.Dirty
                    || _minimumDownPayment.Dirty
                    || _mIP1stDueDate.Dirty
                    || _mIP1stToInvestor.Dirty
                    || _mIPRemittedDate.Dirty
                    || _mIRejectedDate.Dirty
                    || _modifiedInterestRate.Dirty
                    || _modifiedLoanAmount.Dirty
                    || _modifiedMonthlyPayment.Dirty
                    || _modifiedMonthlyPremium.Dirty
                    || _modifiedProposedMaturityMonth.Dirty
                    || _modifiedProposedMaturityYear.Dirty
                    || _modifiedTermAnnualPremium.Dirty
                    || _modifiedUpfrontPremium.Dirty
                    || _mortgageeRepresentative.Dirty
                    || _mortgageFinancialInterest.Dirty
                    || _nonRealtyAndOtherItems.Dirty
                    || _obtainCAIVRSDate.Dirty
                    || _occupancy.Dirty
                    || _oldAgencyCaseIdentifier.Dirty
                    || _originalMortgageAmount.Dirty
                    || _otherLiabilitiesMonthlyPayment.Dirty
                    || _otherLiabilitiesUnpaidBalance.Dirty
                    || _otherMonthlyShelterExpense.Dirty
                    || _otherTitleDescription.Dirty
                    || _ownMoreThanFourDwellings.Dirty
                    || _ownOrSoldOtherRealEstate.Dirty
                    || _paidAmount.Dirty
                    || _premiumMonths.Dirty
                    || _prepaidExpenses.Dirty
                    || _previousPurchaseDate.Dirty
                    || _priorEndorsementDate.Dirty
                    || _proposedMaturityMonths.Dirty
                    || _proposedMaturityYears.Dirty
                    || _purposeOfLoan.Dirty
                    || _refiAuthorizationBy.Dirty
                    || _refiAuthorizationDate.Dirty
                    || _salesPrice.Dirty
                    || _secondMortgageAmount.Dirty
                    || _sellerPaidClosingCost.Dirty
                    || _servingTransferedDate.Dirty
                    || _specialAssessments.Dirty
                    || _sponsorAgentAddress.Dirty
                    || _sponsorAgentCity.Dirty
                    || _sponsorAgentName.Dirty
                    || _sponsorAgentNMLS.Dirty
                    || _sponsorAgentPostalCode.Dirty
                    || _sponsorAgentState.Dirty
                    || _sponsorAgentTaxID.Dirty
                    || _sponsoredOriginationsName.Dirty
                    || _sponsoredOriginationsNMLS.Dirty
                    || _sponsoredOriginationsTaxID.Dirty
                    || _sponsorID.Dirty
                    || _titleVestedIn.Dirty
                    || _toBeSold.Dirty
                    || _totalClosingCost.Dirty
                    || _totalScorecardBy.Dirty
                    || _totalScorecardDate.Dirty
                    || _uFMIPRemittanceDueDate.Dirty
                    || _uFMIPRemittedAmount.Dirty
                    || _uFMIPRemittedBy.Dirty
                    || _uFMIPRemittedDate.Dirty
                    || _uFMIPVerificationCode.Dirty
                    || _useDefaultLenderInfo.Dirty
                    || _utilityIncluded.Dirty
                    || _validateAddressDate.Dirty
                    || _valuation.Dirty
                    || _eem?.Dirty == true
                    || _energyEfficientMortgageItems?.Dirty == true;
            }
            set
            {
                _addendumType.Dirty = value;
                _additionalCondition1.Dirty = value;
                _additionalCondition2.Dirty = value;
                _additionalCondition3.Dirty = value;
                _additionalCondition4.Dirty = value;
                _additionalCondition5.Dirty = value;
                _additionalCondition6.Dirty = value;
                _additionalCondition7.Dirty = value;
                _additionalCondition8.Dirty = value;
                _additionalCondition9.Dirty = value;
                _addressValidatedBy.Dirty = value;
                _addressValidationMessage.Dirty = value;
                _allConditionsSatisfied.Dirty = value;
                _appraisalLoggedDate.Dirty = value;
                _appraisalLookupBy.Dirty = value;
                _beenInformed.Dirty = value;
                _borrowerCertificationAddress.Dirty = value;
                _borrowerCertificationCity.Dirty = value;
                _borrowerCertificationPostalCode.Dirty = value;
                _borrowerCertificationState.Dirty = value;
                _cAIVRSObtainedBy.Dirty = value;
                _caseBinderShippedBy.Dirty = value;
                _caseBinderShippedDate.Dirty = value;
                _closingDate.Dirty = value;
                _condoPudID.Dirty = value;
                _condoPudLookupBy.Dirty = value;
                _condoPudLookupDate.Dirty = value;
                _dateApprovalExpires.Dirty = value;
                _dateMortgageApproved.Dirty = value;
                _detailForOther.Dirty = value;
                _discountPoints.Dirty = value;
                _dulyAgentAddress.Dirty = value;
                _dulyAgentCity.Dirty = value;
                _dulyAgentFunction1.Dirty = value;
                _dulyAgentFunction2.Dirty = value;
                _dulyAgentName.Dirty = value;
                _dulyAgentState.Dirty = value;
                _dwellingCoveredBy.Dirty = value;
                _eligibilityAssessment.Dirty = value;
                _energyEfficientMortgageAmount.Dirty = value;
                _everHadVAHomeLoan.Dirty = value;
                _excessContributionAmount.Dirty = value;
                _existingDebtAmount.Dirty = value;
                _fHACaseOrderedBy.Dirty = value;
                _fHAManagementCounselType.Dirty = value;
                _fHAMaxLoanAmount.Dirty = value;
                _foreclosedProperty.Dirty = value;
                _freddieMacCounselType.Dirty = value;
                _fundingFeePaidInCash.Dirty = value;
                _giftFundsAmount.Dirty = value;
                _haveReceivedLeadPaintPoisoningInfo.Dirty = value;
                _hUD1003AddendumApproved.Dirty = value;
                _id.Dirty = value;
                _lastRefiDate.Dirty = value;
                _lDPGSASearchDate.Dirty = value;
                _lDPGSASearchedBy.Dirty = value;
                _lenderAddress.Dirty = value;
                _lenderCity.Dirty = value;
                _lenderName.Dirty = value;
                _lenderNMLS.Dirty = value;
                _lenderPostalCode.Dirty = value;
                _lenderRepresentativeName.Dirty = value;
                _lenderRepresentativePhone.Dirty = value;
                _lenderRepresentativeTitle.Dirty = value;
                _lenderState.Dirty = value;
                _lenderTaxID.Dirty = value;
                _loanScoreID.Dirty = value;
                _mIAppliedBy.Dirty = value;
                _mIAppliedDate.Dirty = value;
                _mICRetrivedDate.Dirty = value;
                _minimumDownPayment.Dirty = value;
                _mIP1stDueDate.Dirty = value;
                _mIP1stToInvestor.Dirty = value;
                _mIPRemittedDate.Dirty = value;
                _mIRejectedDate.Dirty = value;
                _modifiedInterestRate.Dirty = value;
                _modifiedLoanAmount.Dirty = value;
                _modifiedMonthlyPayment.Dirty = value;
                _modifiedMonthlyPremium.Dirty = value;
                _modifiedProposedMaturityMonth.Dirty = value;
                _modifiedProposedMaturityYear.Dirty = value;
                _modifiedTermAnnualPremium.Dirty = value;
                _modifiedUpfrontPremium.Dirty = value;
                _mortgageeRepresentative.Dirty = value;
                _mortgageFinancialInterest.Dirty = value;
                _nonRealtyAndOtherItems.Dirty = value;
                _obtainCAIVRSDate.Dirty = value;
                _occupancy.Dirty = value;
                _oldAgencyCaseIdentifier.Dirty = value;
                _originalMortgageAmount.Dirty = value;
                _otherLiabilitiesMonthlyPayment.Dirty = value;
                _otherLiabilitiesUnpaidBalance.Dirty = value;
                _otherMonthlyShelterExpense.Dirty = value;
                _otherTitleDescription.Dirty = value;
                _ownMoreThanFourDwellings.Dirty = value;
                _ownOrSoldOtherRealEstate.Dirty = value;
                _paidAmount.Dirty = value;
                _premiumMonths.Dirty = value;
                _prepaidExpenses.Dirty = value;
                _previousPurchaseDate.Dirty = value;
                _priorEndorsementDate.Dirty = value;
                _proposedMaturityMonths.Dirty = value;
                _proposedMaturityYears.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _refiAuthorizationBy.Dirty = value;
                _refiAuthorizationDate.Dirty = value;
                _salesPrice.Dirty = value;
                _secondMortgageAmount.Dirty = value;
                _sellerPaidClosingCost.Dirty = value;
                _servingTransferedDate.Dirty = value;
                _specialAssessments.Dirty = value;
                _sponsorAgentAddress.Dirty = value;
                _sponsorAgentCity.Dirty = value;
                _sponsorAgentName.Dirty = value;
                _sponsorAgentNMLS.Dirty = value;
                _sponsorAgentPostalCode.Dirty = value;
                _sponsorAgentState.Dirty = value;
                _sponsorAgentTaxID.Dirty = value;
                _sponsoredOriginationsName.Dirty = value;
                _sponsoredOriginationsNMLS.Dirty = value;
                _sponsoredOriginationsTaxID.Dirty = value;
                _sponsorID.Dirty = value;
                _titleVestedIn.Dirty = value;
                _toBeSold.Dirty = value;
                _totalClosingCost.Dirty = value;
                _totalScorecardBy.Dirty = value;
                _totalScorecardDate.Dirty = value;
                _uFMIPRemittanceDueDate.Dirty = value;
                _uFMIPRemittedAmount.Dirty = value;
                _uFMIPRemittedBy.Dirty = value;
                _uFMIPRemittedDate.Dirty = value;
                _uFMIPVerificationCode.Dirty = value;
                _useDefaultLenderInfo.Dirty = value;
                _utilityIncluded.Dirty = value;
                _validateAddressDate.Dirty = value;
                _valuation.Dirty = value;
                if (_eem != null) _eem.Dirty = value;
                if (_energyEfficientMortgageItems != null) _energyEfficientMortgageItems.Dirty = value;
            }
        }
    }
}