using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FhaVaLoan
    /// </summary>
    public sealed partial class FhaVaLoan : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AddendumType>>? _addendumType;
        private DirtyValue<bool?>? _additionalCondition1;
        private DirtyValue<bool?>? _additionalCondition2;
        private DirtyValue<bool?>? _additionalCondition3;
        private DirtyValue<bool?>? _additionalCondition4;
        private DirtyValue<bool?>? _additionalCondition5;
        private DirtyValue<bool?>? _additionalCondition6;
        private DirtyValue<bool?>? _additionalCondition7;
        private DirtyValue<bool?>? _additionalCondition8;
        private DirtyValue<bool?>? _additionalCondition9;
        private DirtyValue<string?>? _addressValidatedBy;
        private DirtyValue<string?>? _addressValidationMessage;
        private DirtyValue<bool?>? _allConditionsSatisfied;
        private DirtyValue<DateTime?>? _appraisalLoggedDate;
        private DirtyValue<string?>? _appraisalLookupBy;
        private DirtyValue<StringEnumValue<BeenInformed>>? _beenInformed;
        private DirtyValue<string?>? _borrowerCertificationAddress;
        private DirtyValue<string?>? _borrowerCertificationCity;
        private DirtyValue<string?>? _borrowerCertificationPostalCode;
        private DirtyValue<StringEnumValue<State>>? _borrowerCertificationState;
        private DirtyValue<string?>? _cAIVRSObtainedBy;
        private DirtyValue<string?>? _caseBinderShippedBy;
        private DirtyValue<DateTime?>? _caseBinderShippedDate;
        private DirtyValue<DateTime?>? _closingDate;
        private DirtyValue<string?>? _condoPudID;
        private DirtyValue<string?>? _condoPudLookupBy;
        private DirtyValue<DateTime?>? _condoPudLookupDate;
        private DirtyValue<decimal?>? _conventionalClosingCost;
        private DirtyValue<decimal?>? _conventionalDownPayment;
        private DirtyValue<decimal?>? _conventionalInterestRate;
        private DirtyValue<int?>? _conventionalLoanTerm;
        private DirtyValue<decimal?>? _conventionalLTV;
        private DirtyValue<int?>? _conventionalMaxYearsMI;
        private DirtyValue<decimal?>? _conventionalMMI;
        private DirtyValue<decimal?>? _conventionalMonthlyPayment;
        private DirtyValue<decimal?>? _conventionalMortgageAmount;
        private DirtyValue<decimal?>? _conventionalSalesPrice;
        private DirtyValue<decimal?>? _conventionalUMIP;
        private DirtyValue<DateTime?>? _dateApprovalExpires;
        private DirtyValue<DateTime?>? _dateMortgageApproved;
        private DirtyValue<string?>? _detailForOther;
        private DirtyValue<decimal?>? _discountPoints;
        private DirtyValue<string?>? _dulyAgentAddress;
        private DirtyValue<string?>? _dulyAgentCity;
        private DirtyValue<string?>? _dulyAgentFunction1;
        private DirtyValue<string?>? _dulyAgentFunction2;
        private DirtyValue<string?>? _dulyAgentName;
        private DirtyValue<string?>? _dulyAgentState;
        private DirtyValue<bool?>? _dwellingCoveredBy;
        private EnergyEfficientMortgage? _eem;
        private DirtyValue<StringEnumValue<EligibilityAssessment>>? _eligibilityAssessment;
        private DirtyValue<decimal?>? _energyEfficientMortgageAmount;
        private DirtyList<EnergyEfficientMortgageItem>? _energyEfficientMortgageItems;
        private DirtyValue<bool?>? _everHadVAHomeLoan;
        private DirtyValue<decimal?>? _excessContributionAmount;
        private DirtyValue<decimal?>? _existingDebtAmount;
        private DirtyValue<string?>? _fHACaseOrderedBy;
        private DirtyValue<decimal?>? _fHAClosingCost;
        private DirtyValue<decimal?>? _fHADownPayment;
        private DirtyValue<decimal?>? _fHAInterestRate;
        private DirtyValue<int?>? _fHALoanTerm;
        private DirtyValue<decimal?>? _fHALTV;
        private DirtyValue<StringEnumValue<FHAManagementCounselType>>? _fHAManagementCounselType;
        private DirtyValue<decimal?>? _fHAMaxLoanAmount;
        private DirtyValue<decimal?>? _fHAMMI;
        private DirtyValue<decimal?>? _fHAMonthlyPayment;
        private DirtyValue<decimal?>? _fHAMortgageAmount;
        private DirtyValue<decimal?>? _fHAMortgageAmountUMIP;
        private DirtyValue<decimal?>? _fHASalesPrice;
        private DirtyValue<decimal?>? _fHAUMIP;
        private DirtyValue<int?>? _fHAYearsMonthlyInsurance;
        private DirtyValue<bool?>? _foreclosedProperty;
        private DirtyValue<StringEnumValue<FreddieMacCounselType>>? _freddieMacCounselType;
        private DirtyValue<decimal?>? _fundingFeePaidInCash;
        private DirtyValue<decimal?>? _giftFundsAmount;
        private DirtyValue<bool?>? _haveReceivedLeadPaintPoisoningInfo;
        private DirtyValue<StringEnumValue<HUD1003AddendumApproved>>? _hUD1003AddendumApproved;
        private DirtyValue<string?>? _id;
        private DirtyValue<DateTime?>? _lastRefiDate;
        private DirtyValue<DateTime?>? _lDPGSASearchDate;
        private DirtyValue<string?>? _lDPGSASearchedBy;
        private DirtyValue<string?>? _lenderAddress;
        private DirtyValue<string?>? _lenderCity;
        private DirtyValue<string?>? _lenderName;
        private DirtyValue<string?>? _lenderNMLS;
        private DirtyValue<string?>? _lenderPostalCode;
        private DirtyValue<string?>? _lenderRepresentativeName;
        private DirtyValue<string?>? _lenderRepresentativePhone;
        private DirtyValue<string?>? _lenderRepresentativeTitle;
        private DirtyValue<StringEnumValue<State>>? _lenderState;
        private DirtyValue<string?>? _lenderTaxID;
        private DirtyValue<string?>? _loanScoreID;
        private DirtyValue<string?>? _mIAppliedBy;
        private DirtyValue<DateTime?>? _mIAppliedDate;
        private DirtyValue<DateTime?>? _mICRetrivedDate;
        private DirtyValue<decimal?>? _minimumDownPayment;
        private DirtyValue<DateTime?>? _mIP1stDueDate;
        private DirtyValue<DateTime?>? _mIP1stToInvestor;
        private DirtyValue<DateTime?>? _mIPRemittedDate;
        private DirtyValue<DateTime?>? _mIRejectedDate;
        private DirtyValue<decimal?>? _modifiedInterestRate;
        private DirtyValue<decimal?>? _modifiedLoanAmount;
        private DirtyValue<decimal?>? _modifiedMonthlyPayment;
        private DirtyValue<decimal?>? _modifiedMonthlyPremium;
        private DirtyValue<int?>? _modifiedProposedMaturityMonth;
        private DirtyValue<int?>? _modifiedProposedMaturityYear;
        private DirtyValue<int?>? _modifiedTermAnnualPremium;
        private DirtyValue<decimal?>? _modifiedUpfrontPremium;
        private DirtyValue<string?>? _mortgageeRepresentative;
        private DirtyValue<StringEnumValue<DoesOrDoesNot>>? _mortgageFinancialInterest;
        private DirtyValue<decimal?>? _nonRealtyAndOtherItems;
        private DirtyValue<DateTime?>? _obtainCAIVRSDate;
        private DirtyValue<StringEnumValue<Occupancy>>? _occupancy;
        private DirtyValue<string?>? _oldAgencyCaseIdentifier;
        private DirtyValue<decimal?>? _originalMortgageAmount;
        private DirtyValue<decimal?>? _otherLiabilitiesMonthlyPayment;
        private DirtyValue<decimal?>? _otherLiabilitiesUnpaidBalance;
        private DirtyValue<decimal?>? _otherMonthlyShelterExpense;
        private DirtyValue<string?>? _otherTitleDescription;
        private DirtyValue<bool?>? _ownMoreThanFourDwellings;
        private DirtyValue<bool?>? _ownOrSoldOtherRealEstate;
        private DirtyValue<decimal?>? _paidAmount;
        private DirtyValue<int?>? _premiumMonths;
        private DirtyValue<decimal?>? _prepaidExpenses;
        private DirtyValue<DateTime?>? _previousPurchaseDate;
        private DirtyValue<DateTime?>? _priorEndorsementDate;
        private DirtyValue<int?>? _proposedMaturityMonths;
        private DirtyValue<int?>? _proposedMaturityYears;
        private DirtyValue<StringEnumValue<FhaVaLoanPurposeOfLoan>>? _purposeOfLoan;
        private DirtyValue<string?>? _refiAuthorizationBy;
        private DirtyValue<DateTime?>? _refiAuthorizationDate;
        private DirtyValue<decimal?>? _salesPrice;
        private DirtyValue<decimal?>? _secondMortgageAmount;
        private DirtyValue<decimal?>? _sellerPaidClosingCost;
        private DirtyValue<DateTime?>? _servingTransferedDate;
        private DirtyValue<decimal?>? _specialAssessments;
        private DirtyValue<string?>? _sponsorAgentAddress;
        private DirtyValue<string?>? _sponsorAgentCity;
        private DirtyValue<string?>? _sponsorAgentName;
        private DirtyValue<string?>? _sponsorAgentNMLS;
        private DirtyValue<string?>? _sponsorAgentPostalCode;
        private DirtyValue<StringEnumValue<State>>? _sponsorAgentState;
        private DirtyValue<string?>? _sponsorAgentTaxID;
        private DirtyValue<string?>? _sponsoredOriginationsName;
        private DirtyValue<string?>? _sponsoredOriginationsNMLS;
        private DirtyValue<string?>? _sponsoredOriginationsTaxID;
        private DirtyValue<string?>? _sponsorID;
        private DirtyValue<StringEnumValue<TitleVestedIn>>? _titleVestedIn;
        private DirtyValue<bool?>? _toBeSold;
        private DirtyValue<decimal?>? _totalClosingCost;
        private DirtyValue<string?>? _totalScorecardBy;
        private DirtyValue<DateTime?>? _totalScorecardDate;
        private DirtyValue<DateTime?>? _uFMIPRemittanceDueDate;
        private DirtyValue<decimal?>? _uFMIPRemittedAmount;
        private DirtyValue<string?>? _uFMIPRemittedBy;
        private DirtyValue<DateTime?>? _uFMIPRemittedDate;
        private DirtyValue<string?>? _uFMIPVerificationCode;
        private DirtyValue<bool?>? _useDefaultLenderInfo;
        private DirtyValue<bool?>? _utilityIncluded;
        private DirtyValue<DateTime?>? _validateAddressDate;
        private DirtyValue<StringEnumValue<Valuation>>? _valuation;

        /// <summary>
        /// HUD Addendum Type [1711]
        /// </summary>
        public StringEnumValue<AddendumType> AddendumType { get => _addendumType; set => SetField(ref _addendumType, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 1 [3185]
        /// </summary>
        public bool? AdditionalCondition1 { get => _additionalCondition1; set => SetField(ref _additionalCondition1, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 2 [3186]
        /// </summary>
        public bool? AdditionalCondition2 { get => _additionalCondition2; set => SetField(ref _additionalCondition2, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 3 [3187]
        /// </summary>
        public bool? AdditionalCondition3 { get => _additionalCondition3; set => SetField(ref _additionalCondition3, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 4 [3188]
        /// </summary>
        public bool? AdditionalCondition4 { get => _additionalCondition4; set => SetField(ref _additionalCondition4, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 5 [3189]
        /// </summary>
        public bool? AdditionalCondition5 { get => _additionalCondition5; set => SetField(ref _additionalCondition5, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 6 [3190]
        /// </summary>
        public bool? AdditionalCondition6 { get => _additionalCondition6; set => SetField(ref _additionalCondition6, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 [3191]
        /// </summary>
        public bool? AdditionalCondition7 { get => _additionalCondition7; set => SetField(ref _additionalCondition7, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 8 [3193]
        /// </summary>
        public bool? AdditionalCondition8 { get => _additionalCondition8; set => SetField(ref _additionalCondition8, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 9 [3195]
        /// </summary>
        public bool? AdditionalCondition9 { get => _additionalCondition9; set => SetField(ref _additionalCondition9, value); }

        /// <summary>
        /// FHA Management Address Validated By [3061]
        /// </summary>
        public string? AddressValidatedBy { get => _addressValidatedBy; set => SetField(ref _addressValidatedBy, value); }

        /// <summary>
        /// FHA Management Address Validation Message [3063]
        /// </summary>
        public string? AddressValidationMessage { get => _addressValidationMessage; set => SetField(ref _addressValidationMessage, value); }

        /// <summary>
        /// HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator [4092]
        /// </summary>
        public bool? AllConditionsSatisfied { get => _allConditionsSatisfied; set => SetField(ref _allConditionsSatisfied, value); }

        /// <summary>
        /// FHA Management Appraisal Logged Date [3076]
        /// </summary>
        public DateTime? AppraisalLoggedDate { get => _appraisalLoggedDate; set => SetField(ref _appraisalLoggedDate, value); }

        /// <summary>
        /// FHA Management Appraisal Lookup By [3077]
        /// </summary>
        public string? AppraisalLookupBy { get => _appraisalLookupBy; set => SetField(ref _appraisalLookupBy, value); }

        /// <summary>
        /// Borr Cert Property Value [1639]
        /// </summary>
        public StringEnumValue<BeenInformed> BeenInformed { get => _beenInformed; set => SetField(ref _beenInformed, value); }

        /// <summary>
        /// Borr Other Ownd RE Addr [461]
        /// </summary>
        public string? BorrowerCertificationAddress { get => _borrowerCertificationAddress; set => SetField(ref _borrowerCertificationAddress, value); }

        /// <summary>
        /// Borr Cert Other RE City [1738]
        /// </summary>
        public string? BorrowerCertificationCity { get => _borrowerCertificationCity; set => SetField(ref _borrowerCertificationCity, value); }

        /// <summary>
        /// Borr Cert Other RE Zip [1740]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? BorrowerCertificationPostalCode { get => _borrowerCertificationPostalCode; set => SetField(ref _borrowerCertificationPostalCode, value); }

        /// <summary>
        /// Borr Cert Other RE State [1739]
        /// </summary>
        public StringEnumValue<State> BorrowerCertificationState { get => _borrowerCertificationState; set => SetField(ref _borrowerCertificationState, value); }

        /// <summary>
        /// FHA Management CAIVRS Obtained By [3068]
        /// </summary>
        public string? CAIVRSObtainedBy { get => _cAIVRSObtainedBy; set => SetField(ref _cAIVRSObtainedBy, value); }

        /// <summary>
        /// FHA Management Case Binder Shipped By [3091]
        /// </summary>
        public string? CaseBinderShippedBy { get => _caseBinderShippedBy; set => SetField(ref _caseBinderShippedBy, value); }

        /// <summary>
        /// FHA Management Case Binder Shipped Date [3090]
        /// </summary>
        public DateTime? CaseBinderShippedDate { get => _caseBinderShippedDate; set => SetField(ref _caseBinderShippedDate, value); }

        /// <summary>
        /// Trans Details Closed Date [748]
        /// </summary>
        public DateTime? ClosingDate { get => _closingDate; set => SetField(ref _closingDate, value); }

        /// <summary>
        /// FHA Management CondoPud ID [3075]
        /// </summary>
        public string? CondoPudID { get => _condoPudID; set => SetField(ref _condoPudID, value); }

        /// <summary>
        /// FHA Management Condo Pud Lookup By [3074]
        /// </summary>
        public string? CondoPudLookupBy { get => _condoPudLookupBy; set => SetField(ref _condoPudLookupBy, value); }

        /// <summary>
        /// FHA Management Condo Pud Lookup Date [3073]
        /// </summary>
        public DateTime? CondoPudLookupDate { get => _condoPudLookupDate; set => SetField(ref _condoPudLookupDate, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Closing Cost [FICC.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalClosingCost { get => _conventionalClosingCost; set => SetField(ref _conventionalClosingCost, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Down Payment [FICC.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalDownPayment { get => _conventionalDownPayment; set => SetField(ref _conventionalDownPayment, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Interest Rate [FICC.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalInterestRate { get => _conventionalInterestRate; set => SetField(ref _conventionalInterestRate, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Loan Term [FICC.X18]
        /// </summary>
        public int? ConventionalLoanTerm { get => _conventionalLoanTerm; set => SetField(ref _conventionalLoanTerm, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional LTV [FICC.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalLTV { get => _conventionalLTV; set => SetField(ref _conventionalLTV, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments [FICC.X22]
        /// </summary>
        public int? ConventionalMaxYearsMI { get => _conventionalMaxYearsMI; set => SetField(ref _conventionalMaxYearsMI, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Mortgage Income [FICC.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalMMI { get => _conventionalMMI; set => SetField(ref _conventionalMMI, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Monthly Payment [FICC.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalMonthlyPayment { get => _conventionalMonthlyPayment; set => SetField(ref _conventionalMonthlyPayment, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Mortgage Amount [FICC.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalMortgageAmount { get => _conventionalMortgageAmount; set => SetField(ref _conventionalMortgageAmount, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional Sales Price [FICC.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalSalesPrice { get => _conventionalSalesPrice; set => SetField(ref _conventionalSalesPrice, value); }

        /// <summary>
        /// Informed Consumer Choice Conventional UMIP [FICC.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ConventionalUMIP { get => _conventionalUMIP; set => SetField(ref _conventionalUMIP, value); }

        /// <summary>
        /// HUD 1003 Addendum Date Approval Expires [3177]
        /// </summary>
        public DateTime? DateApprovalExpires { get => _dateApprovalExpires; set => SetField(ref _dateApprovalExpires, value); }

        /// <summary>
        /// HUD 1003 Addendum Date Mtg Approved [3176]
        /// </summary>
        public DateTime? DateMortgageApproved { get => _dateMortgageApproved; set => SetField(ref _dateMortgageApproved, value); }

        /// <summary>
        /// HUD 1003 Addendum Addl Condition Check 7 Detail [3192]
        /// </summary>
        public string? DetailForOther { get => _detailForOther; set => SetField(ref _detailForOther, value); }

        /// <summary>
        /// FHA MCAW Discounts [1046]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountPoints { get => _discountPoints; set => SetField(ref _discountPoints, value); }

        /// <summary>
        /// HUD Duly Auth Agent Addr 1 [1795]
        /// </summary>
        public string? DulyAgentAddress { get => _dulyAgentAddress; set => SetField(ref _dulyAgentAddress, value); }

        /// <summary>
        /// HUD Lender Cert Author Agent Addr 2 [684]
        /// </summary>
        public string? DulyAgentCity { get => _dulyAgentCity; set => SetField(ref _dulyAgentCity, value); }

        /// <summary>
        /// HUD Duly Auth Agent Function 1 [1796]
        /// </summary>
        public string? DulyAgentFunction1 { get => _dulyAgentFunction1; set => SetField(ref _dulyAgentFunction1, value); }

        /// <summary>
        /// HUD Duly Auth Agent Function 2 [1798]
        /// </summary>
        public string? DulyAgentFunction2 { get => _dulyAgentFunction2; set => SetField(ref _dulyAgentFunction2, value); }

        /// <summary>
        /// HUD Duly Auth Agent Name [322]
        /// </summary>
        public string? DulyAgentName { get => _dulyAgentName; set => SetField(ref _dulyAgentName, value); }

        /// <summary>
        /// HUD Duly Auth Agent Addr 3 [1797]
        /// </summary>
        public string? DulyAgentState { get => _dulyAgentState; set => SetField(ref _dulyAgentState, value); }

        /// <summary>
        /// Borr Cert Dwelling To Be Covered By Yes/No [1016]
        /// </summary>
        public bool? DwellingCoveredBy { get => _dwellingCoveredBy; set => SetField(ref _dwellingCoveredBy, value); }

        /// <summary>
        /// FhaVaLoan Eem
        /// </summary>
        [AllowNull]
        public EnergyEfficientMortgage Eem { get => GetField(ref _eem); set => SetField(ref _eem, value); }

        /// <summary>
        /// FHA Management Eligibility Assessment [3631]
        /// </summary>
        public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => _eligibilityAssessment; set => SetField(ref _eligibilityAssessment, value); }

        /// <summary>
        /// FHA MCAW Energy Eff Improvements Amt [1721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => SetField(ref _energyEfficientMortgageAmount, value); }

        /// <summary>
        /// FhaVaLoan EnergyEfficientMortgageItems
        /// </summary>
        [AllowNull]
        public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => GetField(ref _energyEfficientMortgageItems); set => SetField(ref _energyEfficientMortgageItems, value); }

        /// <summary>
        /// Borr Cert Prior VA Home Loan [1398]
        /// </summary>
        public bool? EverHadVAHomeLoan { get => _everHadVAHomeLoan; set => SetField(ref _everHadVAHomeLoan, value); }

        /// <summary>
        /// Excess Seller Contribution [3053]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExcessContributionAmount { get => _excessContributionAmount; set => SetField(ref _excessContributionAmount, value); }

        /// <summary>
        /// Existing Debt for Refi Loan [3052]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingDebtAmount { get => _existingDebtAmount; set => SetField(ref _existingDebtAmount, value); }

        /// <summary>
        /// FHA Management FHA Case Ordered By [3059]
        /// </summary>
        public string? FHACaseOrderedBy { get => _fHACaseOrderedBy; set => SetField(ref _fHACaseOrderedBy, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Closing Cost [FICC.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAClosingCost { get => _fHAClosingCost; set => SetField(ref _fHAClosingCost, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Down Payment [FICC.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHADownPayment { get => _fHADownPayment; set => SetField(ref _fHADownPayment, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Interest Rate [FICC.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAInterestRate { get => _fHAInterestRate; set => SetField(ref _fHAInterestRate, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Loan Term [FICC.X7]
        /// </summary>
        public int? FHALoanTerm { get => _fHALoanTerm; set => SetField(ref _fHALoanTerm, value); }

        /// <summary>
        /// Informed Consumer Choice FHA LTV [FICC.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHALTV { get => _fHALTV; set => SetField(ref _fHALTV, value); }

        /// <summary>
        /// FHA Management Counsel Type [3062]
        /// </summary>
        public StringEnumValue<FHAManagementCounselType> FHAManagementCounselType { get => _fHAManagementCounselType; set => SetField(ref _fHAManagementCounselType, value); }

        /// <summary>
        /// FHA MCAW Max Loan Amt [1720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAMaxLoanAmount { get => _fHAMaxLoanAmount; set => SetField(ref _fHAMaxLoanAmount, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Monthly Mortgage Income [FICC.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAMMI { get => _fHAMMI; set => SetField(ref _fHAMMI, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Monthly Payment [FICC.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAMonthlyPayment { get => _fHAMonthlyPayment; set => SetField(ref _fHAMonthlyPayment, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount [FICC.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAMortgageAmount { get => _fHAMortgageAmount; set => SetField(ref _fHAMortgageAmount, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Mortgage Amount with UMIP [FICC.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAMortgageAmountUMIP { get => _fHAMortgageAmountUMIP; set => SetField(ref _fHAMortgageAmountUMIP, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Sales Price [FICC.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHASalesPrice { get => _fHASalesPrice; set => SetField(ref _fHASalesPrice, value); }

        /// <summary>
        /// Informed Consumer Choice FHA UMIP [FICC.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FHAUMIP { get => _fHAUMIP; set => SetField(ref _fHAUMIP, value); }

        /// <summary>
        /// Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments [FICC.X11]
        /// </summary>
        public int? FHAYearsMonthlyInsurance { get => _fHAYearsMonthlyInsurance; set => SetField(ref _fHAYearsMonthlyInsurance, value); }

        /// <summary>
        /// FHA Process Mgmt Foreclosed Property [3093]
        /// </summary>
        public bool? ForeclosedProperty { get => _foreclosedProperty; set => SetField(ref _foreclosedProperty, value); }

        /// <summary>
        /// Freddie Mac Counsel Type [2847]
        /// </summary>
        public StringEnumValue<FreddieMacCounselType> FreddieMacCounselType { get => _freddieMacCounselType; set => SetField(ref _freddieMacCounselType, value); }

        /// <summary>
        /// FHA Funding Fee Paid in Cash [1160]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => SetField(ref _fundingFeePaidInCash, value); }

        /// <summary>
        /// Trans Details Total Gift Funds Amt [220]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? GiftFundsAmount { get => _giftFundsAmount; set => SetField(ref _giftFundsAmount, value); }

        /// <summary>
        /// HUD Rec Lead Paint Poisoning Info [1400]
        /// </summary>
        public bool? HaveReceivedLeadPaintPoisoningInfo { get => _haveReceivedLeadPaintPoisoningInfo; set => SetField(ref _haveReceivedLeadPaintPoisoningInfo, value); }

        /// <summary>
        /// HUD 1003 Addendum Approved or Modified [3175]
        /// </summary>
        public StringEnumValue<HUD1003AddendumApproved> HUD1003AddendumApproved { get => _hUD1003AddendumApproved; set => SetField(ref _hUD1003AddendumApproved, value); }

        /// <summary>
        /// FhaVaLoan Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// FHA Management Last Refi Date [3057]
        /// </summary>
        public DateTime? LastRefiDate { get => _lastRefiDate; set => SetField(ref _lastRefiDate, value); }

        /// <summary>
        /// FHA Management LDP/GSA Search Date [3069]
        /// </summary>
        public DateTime? LDPGSASearchDate { get => _lDPGSASearchDate; set => SetField(ref _lDPGSASearchDate, value); }

        /// <summary>
        /// FHA Management LDP/GSA Searched By [3070]
        /// </summary>
        public string? LDPGSASearchedBy { get => _lDPGSASearchedBy; set => SetField(ref _lDPGSASearchedBy, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender Addr [3633]
        /// </summary>
        public string? LenderAddress { get => _lenderAddress; set => SetField(ref _lenderAddress, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender City [3634]
        /// </summary>
        public string? LenderCity { get => _lenderCity; set => SetField(ref _lenderCity, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender Co Name [3632]
        /// </summary>
        public string? LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender Info NMLS [3637]
        /// </summary>
        public string? LenderNMLS { get => _lenderNMLS; set => SetField(ref _lenderNMLS, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender Zip [3636]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? LenderPostalCode { get => _lenderPostalCode; set => SetField(ref _lenderPostalCode, value); }

        /// <summary>
        /// HUD Lenders Rep Name [1754]
        /// </summary>
        public string? LenderRepresentativeName { get => _lenderRepresentativeName; set => SetField(ref _lenderRepresentativeName, value); }

        /// <summary>
        /// HUD Lenders Rep Phone [1756]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? LenderRepresentativePhone { get => _lenderRepresentativePhone; set => SetField(ref _lenderRepresentativePhone, value); }

        /// <summary>
        /// HUD Lenders Rep Title [1755]
        /// </summary>
        public string? LenderRepresentativeTitle { get => _lenderRepresentativeTitle; set => SetField(ref _lenderRepresentativeTitle, value); }

        /// <summary>
        /// HUD 1003 Addendum Lender State [3635]
        /// </summary>
        public StringEnumValue<State> LenderState { get => _lenderState; set => SetField(ref _lenderState, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3638]
        /// </summary>
        public string? LenderTaxID { get => _lenderTaxID; set => SetField(ref _lenderTaxID, value); }

        /// <summary>
        /// FHA Management Loan Score ID [3630]
        /// </summary>
        public string? LoanScoreID { get => _loanScoreID; set => SetField(ref _loanScoreID, value); }

        /// <summary>
        /// FHA Management MI Applied By [3087]
        /// </summary>
        public string? MIAppliedBy { get => _mIAppliedBy; set => SetField(ref _mIAppliedBy, value); }

        /// <summary>
        /// FHA Management MI Applied Date [3086]
        /// </summary>
        public DateTime? MIAppliedDate { get => _mIAppliedDate; set => SetField(ref _mIAppliedDate, value); }

        /// <summary>
        /// FHA Management MIC Retrived Date [3089]
        /// </summary>
        public DateTime? MICRetrivedDate { get => _mICRetrivedDate; set => SetField(ref _mICRetrivedDate, value); }

        /// <summary>
        /// FHA MCAW Min Down Pymt [1117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumDownPayment { get => _minimumDownPayment; set => SetField(ref _minimumDownPayment, value); }

        /// <summary>
        /// FHA Management MIP 1st Due Date [3083]
        /// </summary>
        public DateTime? MIP1stDueDate { get => _mIP1stDueDate; set => SetField(ref _mIP1stDueDate, value); }

        /// <summary>
        /// FHA Management MIP 1st To Investor [3085]
        /// </summary>
        public DateTime? MIP1stToInvestor { get => _mIP1stToInvestor; set => SetField(ref _mIP1stToInvestor, value); }

        /// <summary>
        /// FHA Management MIP Periodic Remitted Date [3084]
        /// </summary>
        public DateTime? MIPRemittedDate { get => _mIPRemittedDate; set => SetField(ref _mIPRemittedDate, value); }

        /// <summary>
        /// FHA Management MI Rejected Date [3088]
        /// </summary>
        public DateTime? MIRejectedDate { get => _mIRejectedDate; set => SetField(ref _mIRejectedDate, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Interest Rate [3179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ModifiedInterestRate { get => _modifiedInterestRate; set => SetField(ref _modifiedInterestRate, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Loan Amount [3178]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => SetField(ref _modifiedLoanAmount, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Mthly Pymt [3182]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => SetField(ref _modifiedMonthlyPayment, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Amt Mthly Premium [3184]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ModifiedMonthlyPremium { get => _modifiedMonthlyPremium; set => SetField(ref _modifiedMonthlyPremium, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Mth [3181]
        /// </summary>
        public int? ModifiedProposedMaturityMonth { get => _modifiedProposedMaturityMonth; set => SetField(ref _modifiedProposedMaturityMonth, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Proposed Maturity Yr [3180]
        /// </summary>
        public int? ModifiedProposedMaturityYear { get => _modifiedProposedMaturityYear; set => SetField(ref _modifiedProposedMaturityYear, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Term Annual Premium [3196]
        /// </summary>
        public int? ModifiedTermAnnualPremium { get => _modifiedTermAnnualPremium; set => SetField(ref _modifiedTermAnnualPremium, value); }

        /// <summary>
        /// HUD 1003 Addendum Mod Amt Up Front Premium [3183]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ModifiedUpfrontPremium { get => _modifiedUpfrontPremium; set => SetField(ref _modifiedUpfrontPremium, value); }

        /// <summary>
        /// HUD 1003 Addendum Mortgagee Representative [3194]
        /// </summary>
        public string? MortgageeRepresentative { get => _mortgageeRepresentative; set => SetField(ref _mortgageeRepresentative, value); }

        /// <summary>
        /// HUD Mtg Financial Interest Does/Does Not [153]
        /// </summary>
        public StringEnumValue<DoesOrDoesNot> MortgageFinancialInterest { get => _mortgageFinancialInterest; set => SetField(ref _mortgageFinancialInterest, value); }

        /// <summary>
        /// FHA MCAW Non-Realty/Other Items [1137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NonRealtyAndOtherItems { get => _nonRealtyAndOtherItems; set => SetField(ref _nonRealtyAndOtherItems, value); }

        /// <summary>
        /// FHA Management Obtain CAIVRS Date [3067]
        /// </summary>
        public DateTime? ObtainCAIVRSDate { get => _obtainCAIVRSDate; set => SetField(ref _obtainCAIVRSDate, value); }

        /// <summary>
        /// Borr Cert Occupancy [1065]
        /// </summary>
        public StringEnumValue<Occupancy> Occupancy { get => _occupancy; set => SetField(ref _occupancy, value); }

        /// <summary>
        /// FHA Management Old Agency Case Identifier [3066]
        /// </summary>
        public string? OldAgencyCaseIdentifier { get => _oldAgencyCaseIdentifier; set => SetField(ref _oldAgencyCaseIdentifier, value); }

        /// <summary>
        /// HUD Original Mtg Amt [744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginalMortgageAmount { get => _originalMortgageAmount; set => SetField(ref _originalMortgageAmount, value); }

        /// <summary>
        /// Liabilities Other Mo Pymt [1648]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherLiabilitiesMonthlyPayment { get => _otherLiabilitiesMonthlyPayment; set => SetField(ref _otherLiabilitiesMonthlyPayment, value); }

        /// <summary>
        /// Liabilities Other Unpaid Bal [1649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherLiabilitiesUnpaidBalance { get => _otherLiabilitiesUnpaidBalance; set => SetField(ref _otherLiabilitiesUnpaidBalance, value); }

        /// <summary>
        /// VA Mo Shelter Exp Est Other [1348]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherMonthlyShelterExpense { get => _otherMonthlyShelterExpense; set => SetField(ref _otherMonthlyShelterExpense, value); }

        /// <summary>
        /// VA Title Other Descr [1064]
        /// </summary>
        public string? OtherTitleDescription { get => _otherTitleDescription; set => SetField(ref _otherTitleDescription, value); }

        /// <summary>
        /// Borr Cert Own More than 4 [1017]
        /// </summary>
        public bool? OwnMoreThanFourDwellings { get => _ownMoreThanFourDwellings; set => SetField(ref _ownMoreThanFourDwellings, value); }

        /// <summary>
        /// Borr Cert Own/Sold Other than RE [900]
        /// </summary>
        public bool? OwnOrSoldOtherRealEstate { get => _ownOrSoldOtherRealEstate; set => SetField(ref _ownOrSoldOtherRealEstate, value); }

        /// <summary>
        /// FHA MCAW Paid Amt [201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidAmount { get => _paidAmount; set => SetField(ref _paidAmount, value); }

        /// <summary>
        /// HUD Premium # Mos [409]
        /// </summary>
        public int? PremiumMonths { get => _premiumMonths; set => SetField(ref _premiumMonths, value); }

        /// <summary>
        /// FHA MCAW Prepaid Expenses [61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PrepaidExpenses { get => _prepaidExpenses; set => SetField(ref _prepaidExpenses, value); }

        /// <summary>
        /// FHA Management Previous Purchase Date [3058]
        /// </summary>
        public DateTime? PreviousPurchaseDate { get => _previousPurchaseDate; set => SetField(ref _previousPurchaseDate, value); }

        /// <summary>
        /// FHA Management Refi Authorization Prior Endorsement Date [3432]
        /// </summary>
        public DateTime? PriorEndorsementDate { get => _priorEndorsementDate; set => SetField(ref _priorEndorsementDate, value); }

        /// <summary>
        /// HUD Maturity Mos [1392]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? ProposedMaturityMonths { get => _proposedMaturityMonths; set => SetField(ref _proposedMaturityMonths, value); }

        /// <summary>
        /// Trans Details Loan Term [1347]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? ProposedMaturityYears { get => _proposedMaturityYears; set => SetField(ref _proposedMaturityYears, value); }

        /// <summary>
        /// Trans Details Loan Purpose VA [28]
        /// </summary>
        public StringEnumValue<FhaVaLoanPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => SetField(ref _purposeOfLoan, value); }

        /// <summary>
        /// FHA Management Refi Authorization By [3065]
        /// </summary>
        public string? RefiAuthorizationBy { get => _refiAuthorizationBy; set => SetField(ref _refiAuthorizationBy, value); }

        /// <summary>
        /// FHA Management Refi Authorization Date [3064]
        /// </summary>
        public DateTime? RefiAuthorizationDate { get => _refiAuthorizationDate; set => SetField(ref _refiAuthorizationDate, value); }

        /// <summary>
        /// Borr Cert Other RE Sales Price [687]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }

        /// <summary>
        /// FHA MCAW 2nd Mtg Amt [1140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SecondMortgageAmount { get => _secondMortgageAmount; set => SetField(ref _secondMortgageAmount, value); }

        /// <summary>
        /// Fees Total FHA Closing Costs Seller [1131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerPaidClosingCost { get => _sellerPaidClosingCost; set => SetField(ref _sellerPaidClosingCost, value); }

        /// <summary>
        /// FHA Management Serving Transfered Date [3092]
        /// </summary>
        public DateTime? ServingTransferedDate { get => _servingTransferedDate; set => SetField(ref _servingTransferedDate, value); }

        /// <summary>
        /// VA Mo Shelter Exp Est Special Asmts [1346]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SpecialAssessments { get => _specialAssessments; set => SetField(ref _specialAssessments, value); }

        /// <summary>
        /// File Contacts Sponsor/Agent Street [1113]
        /// </summary>
        public string? SponsorAgentAddress { get => _sponsorAgentAddress; set => SetField(ref _sponsorAgentAddress, value); }

        /// <summary>
        /// File Contacts Sponsor/Agent City [1114]
        /// </summary>
        public string? SponsorAgentCity { get => _sponsorAgentCity; set => SetField(ref _sponsorAgentCity, value); }

        /// <summary>
        /// File Contacts Sponsor/Agent Name [1111]
        /// </summary>
        public string? SponsorAgentName { get => _sponsorAgentName; set => SetField(ref _sponsorAgentName, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info NMLS [3640]
        /// </summary>
        public string? SponsorAgentNMLS { get => _sponsorAgentNMLS; set => SetField(ref _sponsorAgentNMLS, value); }

        /// <summary>
        /// File Contacts Sponsor/Agent Zip [1744]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? SponsorAgentPostalCode { get => _sponsorAgentPostalCode; set => SetField(ref _sponsorAgentPostalCode, value); }

        /// <summary>
        /// File Contacts Sponsor/Agent State [1743]
        /// </summary>
        public StringEnumValue<State> SponsorAgentState { get => _sponsorAgentState; set => SetField(ref _sponsorAgentState, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3641]
        /// </summary>
        public string? SponsorAgentTaxID { get => _sponsorAgentTaxID; set => SetField(ref _sponsorAgentTaxID, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Name [3656]
        /// </summary>
        public string? SponsoredOriginationsName { get => _sponsoredOriginationsName; set => SetField(ref _sponsoredOriginationsName, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations NMLS ID [3657]
        /// </summary>
        public string? SponsoredOriginationsNMLS { get => _sponsoredOriginationsNMLS; set => SetField(ref _sponsoredOriginationsNMLS, value); }

        /// <summary>
        /// HUD 1003 Addendum Sponsored Originations Tax ID [3658]
        /// </summary>
        public string? SponsoredOriginationsTaxID { get => _sponsoredOriginationsTaxID; set => SetField(ref _sponsoredOriginationsTaxID, value); }

        /// <summary>
        /// FHA Sponsor ID [1060]
        /// </summary>
        public string? SponsorID { get => _sponsorID; set => SetField(ref _sponsorID, value); }

        /// <summary>
        /// VA Title Vested In [1497]
        /// </summary>
        public StringEnumValue<TitleVestedIn> TitleVestedIn { get => _titleVestedIn; set => SetField(ref _titleVestedIn, value); }

        /// <summary>
        /// Borr Cert Other RE To Be Sold [933]
        /// </summary>
        public bool? ToBeSold { get => _toBeSold; set => SetField(ref _toBeSold, value); }

        /// <summary>
        /// FHA MCAW Total Closing Cost [386]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalClosingCost { get => _totalClosingCost; set => SetField(ref _totalClosingCost, value); }

        /// <summary>
        /// FHA Management Total Scorecard By [3072]
        /// </summary>
        public string? TotalScorecardBy { get => _totalScorecardBy; set => SetField(ref _totalScorecardBy, value); }

        /// <summary>
        /// FHA Management Total Scorecard Date [3071]
        /// </summary>
        public DateTime? TotalScorecardDate { get => _totalScorecardDate; set => SetField(ref _totalScorecardDate, value); }

        /// <summary>
        /// FHA Management UFMIP Remittance Due Date [3078]
        /// </summary>
        public DateTime? UFMIPRemittanceDueDate { get => _uFMIPRemittanceDueDate; set => SetField(ref _uFMIPRemittanceDueDate, value); }

        /// <summary>
        /// FHA Management UFMIP Remitted Amount [3081]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UFMIPRemittedAmount { get => _uFMIPRemittedAmount; set => SetField(ref _uFMIPRemittedAmount, value); }

        /// <summary>
        /// FHA Management UFMIP Remitted By [3080]
        /// </summary>
        public string? UFMIPRemittedBy { get => _uFMIPRemittedBy; set => SetField(ref _uFMIPRemittedBy, value); }

        /// <summary>
        /// FHA Management UFMIP Remitted Date [3079]
        /// </summary>
        public DateTime? UFMIPRemittedDate { get => _uFMIPRemittedDate; set => SetField(ref _uFMIPRemittedDate, value); }

        /// <summary>
        /// FHA Management UFMIP Verification Code [3082]
        /// </summary>
        public string? UFMIPVerificationCode { get => _uFMIPVerificationCode; set => SetField(ref _uFMIPVerificationCode, value); }

        /// <summary>
        /// HUD 1003 Addendum Use Default Lender [3639]
        /// </summary>
        public bool? UseDefaultLenderInfo { get => _useDefaultLenderInfo; set => SetField(ref _useDefaultLenderInfo, value); }

        /// <summary>
        /// Expenses Borr Mo Housing Exp Utiliy Incl [1087]
        /// </summary>
        public bool? UtilityIncluded { get => _utilityIncluded; set => SetField(ref _utilityIncluded, value); }

        /// <summary>
        /// FHA Management Address Validation Date [3060]
        /// </summary>
        public DateTime? ValidateAddressDate { get => _validateAddressDate; set => SetField(ref _validateAddressDate, value); }

        /// <summary>
        /// Borr Cert Aware/Unaware of Valuation [1399]
        /// </summary>
        public StringEnumValue<Valuation> Valuation { get => _valuation; set => SetField(ref _valuation, value); }
    }
}