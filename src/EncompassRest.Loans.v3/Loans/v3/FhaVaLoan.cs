using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

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
    private DirtyValue<DateTime?>? _approvalExpirationDate;
    private DirtyValue<StringEnumValue<BeenInformed>>? _beenInformed;
    private DirtyValue<string?>? _borrowerCertificationAddress;
    private DirtyValue<string?>? _borrowerCertificationCity;
    private DirtyValue<string?>? _borrowerCertificationPostalCode;
    private DirtyValue<string?>? _borrowerCertificationState;
    private DirtyValue<string?>? _caivrsObtainedBy;
    private DirtyValue<string?>? _caseBinderShippedBy;
    private DirtyValue<DateTime?>? _caseBinderShippedDate;
    private DirtyValue<DateTime?>? _closingDate;
    private DirtyValue<string?>? _condoPudId;
    private DirtyValue<string?>? _condoPudLookupBy;
    private DirtyValue<DateTime?>? _condoPudLookupDate;
    private DirtyValue<decimal?>? _conventionalClosingCost;
    private DirtyValue<decimal?>? _conventionalDownPayment;
    private DirtyValue<decimal?>? _conventionalInterestRate;
    private DirtyValue<int?>? _conventionalLoanTerm;
    private DirtyValue<decimal?>? _conventionalLtv;
    private DirtyValue<int?>? _conventionalMaxYearsMi;
    private DirtyValue<decimal?>? _conventionalMmi;
    private DirtyValue<decimal?>? _conventionalMonthlyPayment;
    private DirtyValue<decimal?>? _conventionalMortgageAmount;
    private DirtyValue<decimal?>? _conventionalSalesPrice;
    private DirtyValue<decimal?>? _conventionalUmip;
    private DirtyValue<string?>? _detailForOther;
    private DirtyValue<decimal?>? _discountPoints;
    private DirtyValue<string?>? _dulyAgentAddress;
    private DirtyValue<string?>? _dulyAgentCity;
    private DirtyValue<string?>? _dulyAgentFunction1;
    private DirtyValue<string?>? _dulyAgentFunction2;
    private DirtyValue<string?>? _dulyAgentName;
    private DirtyValue<string?>? _dulyAgentState;
    private DirtyValue<string?>? _dulyAuthAgentAddress2;
    private DirtyValue<string?>? _dulyAuthAgentAddress3;
    private DirtyValue<string?>? _dulyAuthAgentAddress4;
    private DirtyValue<string?>? _dulyAuthAgentAddress5;
    private DirtyValue<string?>? _dulyAuthAgentCity2;
    private DirtyValue<string?>? _dulyAuthAgentCity3;
    private DirtyValue<string?>? _dulyAuthAgentCity4;
    private DirtyValue<string?>? _dulyAuthAgentCity5;
    private DirtyValue<string?>? _dulyAuthAgentFunction3;
    private DirtyValue<string?>? _dulyAuthAgentFunction4;
    private DirtyValue<string?>? _dulyAuthAgentFunction5;
    private DirtyValue<string?>? _dulyAuthAgentName2;
    private DirtyValue<string?>? _dulyAuthAgentName3;
    private DirtyValue<string?>? _dulyAuthAgentName4;
    private DirtyValue<string?>? _dulyAuthAgentName5;
    private DirtyValue<string?>? _dulyAuthAgentState2;
    private DirtyValue<string?>? _dulyAuthAgentState3;
    private DirtyValue<string?>? _dulyAuthAgentState4;
    private DirtyValue<string?>? _dulyAuthAgentState5;
    private DirtyValue<bool?>? _dwellingCoveredBy;
    private DirtyValue<StringEnumValue<EligibilityAssessment>>? _eligibilityAssessment;
    private EnergyEfficientMortgage? _energyEfficientMortgage;
    private DirtyValue<decimal?>? _energyEfficientMortgageAmount;
    private DirtyList<EnergyEfficientMortgageItem>? _energyEfficientMortgageItems;
    private DirtyValue<bool?>? _everHadVaHomeLoan;
    private DirtyValue<decimal?>? _excessContributionAmount;
    private DirtyValue<decimal?>? _existingDebtAmount;
    private DirtyValue<string?>? _fhaCaseOrderedBy;
    private DirtyValue<decimal?>? _fhaClosingCost;
    private DirtyValue<decimal?>? _fhaDownPayment;
    private DirtyValue<decimal?>? _fhaInterestRate;
    private DirtyValue<int?>? _fhaLoanTerm;
    private DirtyValue<decimal?>? _fhaLtv;
    private DirtyValue<StringEnumValue<FHAManagementCounselType>>? _fhaManagementCounselType;
    private DirtyValue<decimal?>? _fhaMaxLoanAmount;
    private DirtyValue<decimal?>? _fhaMmi;
    private DirtyValue<decimal?>? _fhaMonthlyPayment;
    private DirtyValue<decimal?>? _fhaMortgageAmount;
    private DirtyValue<decimal?>? _fhaMortgageAmountUmip;
    private DirtyValue<decimal?>? _fhaSalesPrice;
    private DirtyValue<decimal?>? _fhaUmip;
    private DirtyValue<int?>? _fhaYearsMonthlyInsurance;
    private DirtyValue<bool?>? _foreclosedProperty;
    private DirtyValue<StringEnumValue<FreddieMacCounselType>>? _freddieMacCounselType;
    private DirtyValue<decimal?>? _fundingFeePaidInCash;
    private DirtyValue<decimal?>? _giftFundsAmount;
    private DirtyValue<bool?>? _haveReceivedLeadPaintPoisoningInfo;
    private DirtyValue<StringEnumValue<HUD1003AddendumApproved>>? _hud1003AddendumApproved;
    private DirtyValue<bool?>? _isEntityActingAsAgent;
    private DirtyValue<DateTime?>? _lastRefiDate;
    private DirtyValue<DateTime?>? _ldpgsaSearchDate;
    private DirtyValue<string?>? _ldpgsaSearchedBy;
    private DirtyValue<string?>? _lenderAddress;
    private DirtyValue<string?>? _lenderCity;
    private DirtyValue<string?>? _lenderName;
    private DirtyValue<string?>? _lenderNmls;
    private DirtyValue<string?>? _lenderPostalCode;
    private DirtyValue<string?>? _lenderRepresentativeName;
    private DirtyValue<string?>? _lenderRepresentativePhone;
    private DirtyValue<string?>? _lenderRepresentativeTitle;
    private DirtyValue<string?>? _lenderState;
    private DirtyValue<string?>? _lenderTaxId;
    private DirtyValue<string?>? _loanScoreId;
    private DirtyValue<string?>? _miAppliedBy;
    private DirtyValue<DateTime?>? _miAppliedDate;
    private DirtyValue<DateTime?>? _micRetrivedDate;
    private DirtyValue<decimal?>? _minimumDownPayment;
    private DirtyValue<DateTime?>? _mip1stDueDate;
    private DirtyValue<DateTime?>? _mip1stToInvestor;
    private DirtyValue<DateTime?>? _mipRemittedDate;
    private DirtyValue<DateTime?>? _miRejectedDate;
    private DirtyValue<decimal?>? _modifiedInterestRate;
    private DirtyValue<decimal?>? _modifiedLoanAmount;
    private DirtyValue<decimal?>? _modifiedMonthlyPayment;
    private DirtyValue<decimal?>? _modifiedMonthlyPremium;
    private DirtyValue<int?>? _modifiedProposedMaturityMonth;
    private DirtyValue<int?>? _modifiedProposedMaturityYear;
    private DirtyValue<int?>? _modifiedTermAnnualPremium;
    private DirtyValue<decimal?>? _modifiedUpfrontPremium;
    private DirtyValue<DateTime?>? _mortgageApprovedDate;
    private DirtyValue<string?>? _mortgageeRepresentative;
    private DirtyValue<StringEnumValue<DoesOrDoesNot>>? _mortgageFinancialInterest;
    private DirtyValue<decimal?>? _nonRealtyAndOtherItems;
    private DirtyValue<DateTime?>? _obtainCaivrsDate;
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
    private DirtyValue<DateTime?>? _servingTransferredDate;
    private DirtyValue<decimal?>? _specialAssessments;
    private DirtyValue<string?>? _sponsorAgentAddress;
    private DirtyValue<string?>? _sponsorAgentCity;
    private DirtyValue<string?>? _sponsorAgentName;
    private DirtyValue<string?>? _sponsorAgentNmls;
    private DirtyValue<string?>? _sponsorAgentPostalCode;
    private DirtyValue<string?>? _sponsorAgentState;
    private DirtyValue<string?>? _sponsorAgentTaxId;
    private DirtyValue<string?>? _sponsoredOriginationsName;
    private DirtyValue<string?>? _sponsoredOriginationsNmls;
    private DirtyValue<string?>? _sponsoredOriginationsTaxId;
    private DirtyValue<string?>? _sponsorId;
    private DirtyValue<StringEnumValue<TitleVestedIn>>? _titleVestedIn;
    private DirtyValue<bool?>? _toBeSold;
    private DirtyValue<decimal?>? _totalClosingCost;
    private DirtyValue<string?>? _totalScorecardBy;
    private DirtyValue<DateTime?>? _totalScorecardDate;
    private DirtyValue<DateTime?>? _ufmipRemittanceDueDate;
    private DirtyValue<decimal?>? _ufmipRemittedAmount;
    private DirtyValue<string?>? _ufmipRemittedBy;
    private DirtyValue<DateTime?>? _ufmipRemittedDate;
    private DirtyValue<string?>? _ufmipVerificationCode;
    private DirtyValue<bool?>? _useDefaultLenderInfo;
    private DirtyValue<bool?>? _utilityIncluded;
    private DirtyValue<DateTime?>? _validateAddressDate;
    private DirtyValue<StringEnumValue<ValuationAwareness>>? _valuation;

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
    /// HUD 1003 Addendum Date Approval Expires [3177]
    /// </summary>
    public DateTime? ApprovalExpirationDate { get => _approvalExpirationDate; set => SetField(ref _approvalExpirationDate, value); }

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
    public string? BorrowerCertificationState { get => _borrowerCertificationState; set => SetField(ref _borrowerCertificationState, value); }

    /// <summary>
    /// FHA Management CAIVRS Obtained By [3068]
    /// </summary>
    public string? CaivrsObtainedBy { get => _caivrsObtainedBy; set => SetField(ref _caivrsObtainedBy, value); }

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
    public string? CondoPudId { get => _condoPudId; set => SetField(ref _condoPudId, value); }

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
    public decimal? ConventionalClosingCost { get => _conventionalClosingCost; set => SetField(ref _conventionalClosingCost, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Down Payment [FICC.X16]
    /// </summary>
    public decimal? ConventionalDownPayment { get => _conventionalDownPayment; set => SetField(ref _conventionalDownPayment, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Interest Rate [FICC.X17]
    /// </summary>
    public decimal? ConventionalInterestRate { get => _conventionalInterestRate; set => SetField(ref _conventionalInterestRate, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Loan Term [FICC.X18]
    /// </summary>
    public int? ConventionalLoanTerm { get => _conventionalLoanTerm; set => SetField(ref _conventionalLoanTerm, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional LTV [FICC.X20]
    /// </summary>
    public decimal? ConventionalLtv { get => _conventionalLtv; set => SetField(ref _conventionalLtv, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments [FICC.X22]
    /// </summary>
    public int? ConventionalMaxYearsMi { get => _conventionalMaxYearsMi; set => SetField(ref _conventionalMaxYearsMi, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Monthly Mortgage Income [FICC.X21]
    /// </summary>
    public decimal? ConventionalMmi { get => _conventionalMmi; set => SetField(ref _conventionalMmi, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Monthly Payment [FICC.X19]
    /// </summary>
    public decimal? ConventionalMonthlyPayment { get => _conventionalMonthlyPayment; set => SetField(ref _conventionalMonthlyPayment, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Mortgage Amount [FICC.X14]
    /// </summary>
    public decimal? ConventionalMortgageAmount { get => _conventionalMortgageAmount; set => SetField(ref _conventionalMortgageAmount, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Sales Price [FICC.X13]
    /// </summary>
    public decimal? ConventionalSalesPrice { get => _conventionalSalesPrice; set => SetField(ref _conventionalSalesPrice, value); }

    /// <summary>
    /// Informed Consumer Choice Conventional UMIP [FICC.X23]
    /// </summary>
    public decimal? ConventionalUmip { get => _conventionalUmip; set => SetField(ref _conventionalUmip, value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 7 Detail [3192]
    /// </summary>
    public string? DetailForOther { get => _detailForOther; set => SetField(ref _detailForOther, value); }

    /// <summary>
    /// FHA MCAW Discounts [1046]
    /// </summary>
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
    /// HUD Duly Auth Agent Addr 2 [4691]
    /// </summary>
    public string? DulyAuthAgentAddress2 { get => _dulyAuthAgentAddress2; set => SetField(ref _dulyAuthAgentAddress2, value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 3 [4695]
    /// </summary>
    public string? DulyAuthAgentAddress3 { get => _dulyAuthAgentAddress3; set => SetField(ref _dulyAuthAgentAddress3, value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 4 [4700]
    /// </summary>
    public string? DulyAuthAgentAddress4 { get => _dulyAuthAgentAddress4; set => SetField(ref _dulyAuthAgentAddress4, value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 5 [4705]
    /// </summary>
    public string? DulyAuthAgentAddress5 { get => _dulyAuthAgentAddress5; set => SetField(ref _dulyAuthAgentAddress5, value); }

    /// <summary>
    /// HUD Lender Cert Author Agent City 2 [4692]
    /// </summary>
    public string? DulyAuthAgentCity2 { get => _dulyAuthAgentCity2; set => SetField(ref _dulyAuthAgentCity2, value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 3 [4696]
    /// </summary>
    public string? DulyAuthAgentCity3 { get => _dulyAuthAgentCity3; set => SetField(ref _dulyAuthAgentCity3, value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 4 [4701]
    /// </summary>
    public string? DulyAuthAgentCity4 { get => _dulyAuthAgentCity4; set => SetField(ref _dulyAuthAgentCity4, value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 5 [4706]
    /// </summary>
    public string? DulyAuthAgentCity5 { get => _dulyAuthAgentCity5; set => SetField(ref _dulyAuthAgentCity5, value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 3 [4698]
    /// </summary>
    public string? DulyAuthAgentFunction3 { get => _dulyAuthAgentFunction3; set => SetField(ref _dulyAuthAgentFunction3, value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 4 [4703]
    /// </summary>
    public string? DulyAuthAgentFunction4 { get => _dulyAuthAgentFunction4; set => SetField(ref _dulyAuthAgentFunction4, value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 5 [4708]
    /// </summary>
    public string? DulyAuthAgentFunction5 { get => _dulyAuthAgentFunction5; set => SetField(ref _dulyAuthAgentFunction5, value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 2 [4690]
    /// </summary>
    public string? DulyAuthAgentName2 { get => _dulyAuthAgentName2; set => SetField(ref _dulyAuthAgentName2, value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 3 [4694]
    /// </summary>
    public string? DulyAuthAgentName3 { get => _dulyAuthAgentName3; set => SetField(ref _dulyAuthAgentName3, value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 4 [4699]
    /// </summary>
    public string? DulyAuthAgentName4 { get => _dulyAuthAgentName4; set => SetField(ref _dulyAuthAgentName4, value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 5 [4704]
    /// </summary>
    public string? DulyAuthAgentName5 { get => _dulyAuthAgentName5; set => SetField(ref _dulyAuthAgentName5, value); }

    /// <summary>
    /// HUD Duly Auth Agent State 2 [4693]
    /// </summary>
    public string? DulyAuthAgentState2 { get => _dulyAuthAgentState2; set => SetField(ref _dulyAuthAgentState2, value); }

    /// <summary>
    /// HUD Duly Auth Agent State 3 [4697]
    /// </summary>
    public string? DulyAuthAgentState3 { get => _dulyAuthAgentState3; set => SetField(ref _dulyAuthAgentState3, value); }

    /// <summary>
    /// HUD Duly Auth Agent State 4 [4702]
    /// </summary>
    public string? DulyAuthAgentState4 { get => _dulyAuthAgentState4; set => SetField(ref _dulyAuthAgentState4, value); }

    /// <summary>
    /// HUD Duly Auth Agent State 5 [4707]
    /// </summary>
    public string? DulyAuthAgentState5 { get => _dulyAuthAgentState5; set => SetField(ref _dulyAuthAgentState5, value); }

    /// <summary>
    /// Borr Cert Dwelling To Be Covered By Yes/No [1016]
    /// </summary>
    public bool? DwellingCoveredBy { get => _dwellingCoveredBy; set => SetField(ref _dwellingCoveredBy, value); }

    /// <summary>
    /// FHA Management Eligibility Assessment [3631]
    /// </summary>
    public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => _eligibilityAssessment; set => SetField(ref _eligibilityAssessment, value); }

    /// <summary>
    /// FhaVaLoanContract EnergyEfficientMortgage
    /// </summary>
    [AllowNull]
    public EnergyEfficientMortgage EnergyEfficientMortgage { get => GetField(ref _energyEfficientMortgage); set => SetField(ref _energyEfficientMortgage, value); }

    /// <summary>
    /// FHA MCAW Energy Eff Improvements Amt [1721]
    /// </summary>
    public decimal? EnergyEfficientMortgageAmount { get => _energyEfficientMortgageAmount; set => SetField(ref _energyEfficientMortgageAmount, value); }

    /// <summary>
    /// FhaVaLoanContract EnergyEfficientMortgageItems
    /// </summary>
    [AllowNull]
    public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => GetField(ref _energyEfficientMortgageItems); set => SetField(ref _energyEfficientMortgageItems, value); }

    /// <summary>
    /// Borr Cert Prior VA Home Loan [1398]
    /// </summary>
    public bool? EverHadVaHomeLoan { get => _everHadVaHomeLoan; set => SetField(ref _everHadVaHomeLoan, value); }

    /// <summary>
    /// Excess Seller Contribution [3053]
    /// </summary>
    public decimal? ExcessContributionAmount { get => _excessContributionAmount; set => SetField(ref _excessContributionAmount, value); }

    /// <summary>
    /// Existing Debt for Refi Loan [3052]
    /// </summary>
    public decimal? ExistingDebtAmount { get => _existingDebtAmount; set => SetField(ref _existingDebtAmount, value); }

    /// <summary>
    /// FHA Management FHA Case Ordered By [3059]
    /// </summary>
    public string? FhaCaseOrderedBy { get => _fhaCaseOrderedBy; set => SetField(ref _fhaCaseOrderedBy, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Closing Cost [FICC.X4]
    /// </summary>
    public decimal? FhaClosingCost { get => _fhaClosingCost; set => SetField(ref _fhaClosingCost, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Down Payment [FICC.X5]
    /// </summary>
    public decimal? FhaDownPayment { get => _fhaDownPayment; set => SetField(ref _fhaDownPayment, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Interest Rate [FICC.X6]
    /// </summary>
    public decimal? FhaInterestRate { get => _fhaInterestRate; set => SetField(ref _fhaInterestRate, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Loan Term [FICC.X7]
    /// </summary>
    public int? FhaLoanTerm { get => _fhaLoanTerm; set => SetField(ref _fhaLoanTerm, value); }

    /// <summary>
    /// Informed Consumer Choice FHA LTV [FICC.X9]
    /// </summary>
    public decimal? FhaLtv { get => _fhaLtv; set => SetField(ref _fhaLtv, value); }

    /// <summary>
    /// FHA Management Counsel Type [3062]
    /// </summary>
    public StringEnumValue<FHAManagementCounselType> FhaManagementCounselType { get => _fhaManagementCounselType; set => SetField(ref _fhaManagementCounselType, value); }

    /// <summary>
    /// FHA MCAW Max Loan Amt [1720]
    /// </summary>
    public decimal? FhaMaxLoanAmount { get => _fhaMaxLoanAmount; set => SetField(ref _fhaMaxLoanAmount, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Monthly Mortgage Income [FICC.X10]
    /// </summary>
    public decimal? FhaMmi { get => _fhaMmi; set => SetField(ref _fhaMmi, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Monthly Payment [FICC.X8]
    /// </summary>
    public decimal? FhaMonthlyPayment { get => _fhaMonthlyPayment; set => SetField(ref _fhaMonthlyPayment, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Mortgage Amount [FICC.X2]
    /// </summary>
    public decimal? FhaMortgageAmount { get => _fhaMortgageAmount; set => SetField(ref _fhaMortgageAmount, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Mortgage Amount with UMIP [FICC.X3]
    /// </summary>
    public decimal? FhaMortgageAmountUmip { get => _fhaMortgageAmountUmip; set => SetField(ref _fhaMortgageAmountUmip, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Sales Price [FICC.X1]
    /// </summary>
    public decimal? FhaSalesPrice { get => _fhaSalesPrice; set => SetField(ref _fhaSalesPrice, value); }

    /// <summary>
    /// Informed Consumer Choice FHA UMIP [FICC.X12]
    /// </summary>
    public decimal? FhaUmip { get => _fhaUmip; set => SetField(ref _fhaUmip, value); }

    /// <summary>
    /// Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments [FICC.X11]
    /// </summary>
    public int? FhaYearsMonthlyInsurance { get => _fhaYearsMonthlyInsurance; set => SetField(ref _fhaYearsMonthlyInsurance, value); }

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
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundingFeePaidInCash { get => _fundingFeePaidInCash; set => SetField(ref _fundingFeePaidInCash, value); }

    /// <summary>
    /// Trans Details Total Gift Funds Amt [220]
    /// </summary>
    public decimal? GiftFundsAmount { get => _giftFundsAmount; set => SetField(ref _giftFundsAmount, value); }

    /// <summary>
    /// HUD Rec Lead Paint Poisoning Info [1400]
    /// </summary>
    public bool? HaveReceivedLeadPaintPoisoningInfo { get => _haveReceivedLeadPaintPoisoningInfo; set => SetField(ref _haveReceivedLeadPaintPoisoningInfo, value); }

    /// <summary>
    /// HUD 1003 Addendum Approved or Modified [3175]
    /// </summary>
    public StringEnumValue<HUD1003AddendumApproved> Hud1003AddendumApproved { get => _hud1003AddendumApproved; set => SetField(ref _hud1003AddendumApproved, value); }

    /// <summary>
    /// Entity Acting As Agent [4688]
    /// </summary>
    public bool? IsEntityActingAsAgent { get => _isEntityActingAsAgent; set => SetField(ref _isEntityActingAsAgent, value); }

    /// <summary>
    /// FHA Management Last Refi Date [3057]
    /// </summary>
    public DateTime? LastRefiDate { get => _lastRefiDate; set => SetField(ref _lastRefiDate, value); }

    /// <summary>
    /// FHA Management LDP/GSA Search Date [3069]
    /// </summary>
    public DateTime? LdpgsaSearchDate { get => _ldpgsaSearchDate; set => SetField(ref _ldpgsaSearchDate, value); }

    /// <summary>
    /// FHA Management LDP/GSA Searched By [3070]
    /// </summary>
    public string? LdpgsaSearchedBy { get => _ldpgsaSearchedBy; set => SetField(ref _ldpgsaSearchedBy, value); }

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
    public string? LenderNmls { get => _lenderNmls; set => SetField(ref _lenderNmls, value); }

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
    public string? LenderState { get => _lenderState; set => SetField(ref _lenderState, value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3638]
    /// </summary>
    public string? LenderTaxId { get => _lenderTaxId; set => SetField(ref _lenderTaxId, value); }

    /// <summary>
    /// FHA Management Loan Score ID [3630]
    /// </summary>
    public string? LoanScoreId { get => _loanScoreId; set => SetField(ref _loanScoreId, value); }

    /// <summary>
    /// FHA Management MI Applied By [3087]
    /// </summary>
    public string? MiAppliedBy { get => _miAppliedBy; set => SetField(ref _miAppliedBy, value); }

    /// <summary>
    /// FHA Management MI Applied Date [3086]
    /// </summary>
    public DateTime? MiAppliedDate { get => _miAppliedDate; set => SetField(ref _miAppliedDate, value); }

    /// <summary>
    /// FHA Management MIC Retrived Date [3089]
    /// </summary>
    public DateTime? MicRetrivedDate { get => _micRetrivedDate; set => SetField(ref _micRetrivedDate, value); }

    /// <summary>
    /// FHA MCAW Min Down Pymt [1117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumDownPayment { get => _minimumDownPayment; set => SetField(ref _minimumDownPayment, value); }

    /// <summary>
    /// FHA Management MIP 1st Due Date [3083]
    /// </summary>
    public DateTime? Mip1stDueDate { get => _mip1stDueDate; set => SetField(ref _mip1stDueDate, value); }

    /// <summary>
    /// FHA Management MIP 1st To Investor [3085]
    /// </summary>
    public DateTime? Mip1stToInvestor { get => _mip1stToInvestor; set => SetField(ref _mip1stToInvestor, value); }

    /// <summary>
    /// FHA Management MIP Periodic Remitted Date [3084]
    /// </summary>
    public DateTime? MipRemittedDate { get => _mipRemittedDate; set => SetField(ref _mipRemittedDate, value); }

    /// <summary>
    /// FHA Management MI Rejected Date [3088]
    /// </summary>
    public DateTime? MiRejectedDate { get => _miRejectedDate; set => SetField(ref _miRejectedDate, value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Interest Rate [3179]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ModifiedInterestRate { get => _modifiedInterestRate; set => SetField(ref _modifiedInterestRate, value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Loan Amount [3178]
    /// </summary>
    public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => SetField(ref _modifiedLoanAmount, value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Mthly Pymt [3182]
    /// </summary>
    public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => SetField(ref _modifiedMonthlyPayment, value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Amt Mthly Premium [3184]
    /// </summary>
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
    public decimal? ModifiedUpfrontPremium { get => _modifiedUpfrontPremium; set => SetField(ref _modifiedUpfrontPremium, value); }

    /// <summary>
    /// HUD 1003 Addendum Date Mtg Approved [3176]
    /// </summary>
    public DateTime? MortgageApprovedDate { get => _mortgageApprovedDate; set => SetField(ref _mortgageApprovedDate, value); }

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
    public decimal? NonRealtyAndOtherItems { get => _nonRealtyAndOtherItems; set => SetField(ref _nonRealtyAndOtherItems, value); }

    /// <summary>
    /// FHA Management Obtain CAIVRS Date [3067]
    /// </summary>
    public DateTime? ObtainCaivrsDate { get => _obtainCaivrsDate; set => SetField(ref _obtainCaivrsDate, value); }

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
    public decimal? OriginalMortgageAmount { get => _originalMortgageAmount; set => SetField(ref _originalMortgageAmount, value); }

    /// <summary>
    /// Liabilities Other Mo Pymt [1648]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherLiabilitiesMonthlyPayment { get => _otherLiabilitiesMonthlyPayment; set => SetField(ref _otherLiabilitiesMonthlyPayment, value); }

    /// <summary>
    /// Liabilities Other Unpaid Bal [1649]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherLiabilitiesUnpaidBalance { get => _otherLiabilitiesUnpaidBalance; set => SetField(ref _otherLiabilitiesUnpaidBalance, value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Other [1348]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
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
    public decimal? PaidAmount { get => _paidAmount; set => SetField(ref _paidAmount, value); }

    /// <summary>
    /// HUD Premium # Mos [409]
    /// </summary>
    public int? PremiumMonths { get => _premiumMonths; set => SetField(ref _premiumMonths, value); }

    /// <summary>
    /// FHA MCAW Prepaid Expenses [61]
    /// </summary>
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
    public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }

    /// <summary>
    /// FHA MCAW 2nd Mtg Amt [1140]
    /// </summary>
    public decimal? SecondMortgageAmount { get => _secondMortgageAmount; set => SetField(ref _secondMortgageAmount, value); }

    /// <summary>
    /// Fees Total FHA Closing Costs Seller [1131]
    /// </summary>
    public decimal? SellerPaidClosingCost { get => _sellerPaidClosingCost; set => SetField(ref _sellerPaidClosingCost, value); }

    /// <summary>
    /// FHA Management Serving Transfered Date [3092]
    /// </summary>
    public DateTime? ServingTransferredDate { get => _servingTransferredDate; set => SetField(ref _servingTransferredDate, value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Special Asmts [1346]
    /// </summary>
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
    public string? SponsorAgentNmls { get => _sponsorAgentNmls; set => SetField(ref _sponsorAgentNmls, value); }

    /// <summary>
    /// File Contacts Sponsor/Agent Zip [1744]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SponsorAgentPostalCode { get => _sponsorAgentPostalCode; set => SetField(ref _sponsorAgentPostalCode, value); }

    /// <summary>
    /// File Contacts Sponsor/Agent State [1743]
    /// </summary>
    public string? SponsorAgentState { get => _sponsorAgentState; set => SetField(ref _sponsorAgentState, value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3641]
    /// </summary>
    public string? SponsorAgentTaxId { get => _sponsorAgentTaxId; set => SetField(ref _sponsorAgentTaxId, value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations Name [3656]
    /// </summary>
    public string? SponsoredOriginationsName { get => _sponsoredOriginationsName; set => SetField(ref _sponsoredOriginationsName, value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations NMLS ID [3657]
    /// </summary>
    public string? SponsoredOriginationsNmls { get => _sponsoredOriginationsNmls; set => SetField(ref _sponsoredOriginationsNmls, value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations Tax ID [3658]
    /// </summary>
    public string? SponsoredOriginationsTaxId { get => _sponsoredOriginationsTaxId; set => SetField(ref _sponsoredOriginationsTaxId, value); }

    /// <summary>
    /// FHA Sponsor ID [1060]
    /// </summary>
    public string? SponsorId { get => _sponsorId; set => SetField(ref _sponsorId, value); }

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
    public DateTime? UfmipRemittanceDueDate { get => _ufmipRemittanceDueDate; set => SetField(ref _ufmipRemittanceDueDate, value); }

    /// <summary>
    /// FHA Management UFMIP Remitted Amount [3081]
    /// </summary>
    public decimal? UfmipRemittedAmount { get => _ufmipRemittedAmount; set => SetField(ref _ufmipRemittedAmount, value); }

    /// <summary>
    /// FHA Management UFMIP Remitted By [3080]
    /// </summary>
    public string? UfmipRemittedBy { get => _ufmipRemittedBy; set => SetField(ref _ufmipRemittedBy, value); }

    /// <summary>
    /// FHA Management UFMIP Remitted Date [3079]
    /// </summary>
    public DateTime? UfmipRemittedDate { get => _ufmipRemittedDate; set => SetField(ref _ufmipRemittedDate, value); }

    /// <summary>
    /// FHA Management UFMIP Verification Code [3082]
    /// </summary>
    public string? UfmipVerificationCode { get => _ufmipVerificationCode; set => SetField(ref _ufmipVerificationCode, value); }

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
    public StringEnumValue<ValuationAwareness> Valuation { get => _valuation; set => SetField(ref _valuation, value); }
}