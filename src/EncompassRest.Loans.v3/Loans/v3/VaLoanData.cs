using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// VaLoanData
/// </summary>
public sealed partial class VaLoanData : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _acquiredLandDate;
    private DirtyValue<decimal?>? _acres;
    private DirtyValue<string?>? _additionalSecurityDescription;
    private DirtyValue<string?>? _administratorAddress;
    private DirtyValue<string?>? _administratorCity;
    private DirtyValue<string?>? _administratorContact;
    private DirtyValue<string?>? _administratorName;
    private DirtyValue<string?>? _administratorPostalCode;
    private DirtyValue<string?>? _administratorState;
    private DirtyValue<int?>? _ageOfProperty;
    private DirtyValue<decimal?>? _amountOfProposedLiens;
    private DirtyValue<decimal?>? _amountSpentOnEnergyImprovements;
    private DirtyValue<StringEnumValue<AmountTypeWithheld>>? _amountTypeWithheld;
    private DirtyValue<decimal?>? _amountWithheld;
    private DirtyValue<decimal?>? _annualGroundRent;
    private DirtyValue<decimal?>? _annualMaintenanceAssessment;
    private DirtyValue<decimal?>? _annualRealEstateTaxes;
    private DirtyValue<decimal?>? _annualSpecialAssessment;
    private DirtyValue<string?>? _applicantAddressCity;
    private DirtyValue<string?>? _applicantAddressPostalCode;
    private DirtyValue<string?>? _applicantAddressState;
    private DirtyValue<string?>? _applicantAddressStreetLine1;
    private DirtyValue<DateTime?>? _applicantBirthDate;
    private DirtyValue<string?>? _applicantEmailAddressText;
    private DirtyValue<string?>? _applicantFirstNameWithMiddleName;
    private DirtyValue<string?>? _applicantHmdaGenderType;
    private DirtyValue<string?>? _applicantHomePhoneNumber;
    private DirtyValue<string?>? _applicantLastNameWithSuffix;
    private DirtyValue<string?>? _applicantTaxIdentificationIdentifier;
    private DirtyValue<string?>? _applicantWorkPhoneNumber;
    private DirtyValue<StringEnumValue<AppraisalPropertyType>>? _appraisalType;
    private DirtyValue<DateTime?>? _assignmentDate;
    private DirtyValue<bool?>? _automaticProcedure;
    private DirtyValue<bool?>? _availableForInspectionAmIndicator;
    private DirtyValue<DateTime?>? _availableForInspectionDateAndTime;
    private DirtyValue<decimal?>? _borrowerPaidDiscountPointsTotalAmount;
    private DirtyValue<StringEnumValue<BuildingType>>? _buildingType;
    private DirtyValue<bool?>? _buyerPurchasingLotSeparately;
    private DirtyValue<decimal?>? _cashDisbursedToBorrowerAmount;
    private DirtyValue<decimal?>? _cashPaymentFromVeteran;
    private DirtyValue<decimal?>? _cdNonShoppableLessFundingFee;
    private DirtyValue<StringEnumValue<ClaimDisabilityBenefits>>? _claimDisabilityBenefits;
    private DirtyValue<bool?>? _clothesWasherIndicator;
    private DirtyValue<DateTime?>? _constructionCompletedDate;
    private DirtyValue<StringEnumValue<ConstructionPlan>>? _constructionPlan;
    private DirtyValue<bool?>? _constructionWarrantyIncluded;
    private DirtyValue<string?>? _contractNoApprovedBy;
    private DirtyValue<int?>? _creditScore;
    private DirtyValue<bool?>? _currentlyOnMilitaryDuty;
    private DirtyValue<decimal?>? _disabilityAmountCollected;
    private DirtyValue<decimal?>? _disbursementsLessPayoffAmount;
    private DirtyValue<decimal?>? _discountPercentage;
    private DirtyValue<decimal?>? _discountPoint;
    private DirtyValue<bool?>? _dishwasherIndicator;
    private DirtyValue<bool?>? _dryerIndicator;
    private DirtyValue<string?>? _emailToBeNotifiedWhenUploaded;
    private DirtyValue<bool?>? _energyImprovementsAdditionOfFeature;
    private DirtyValue<string?>? _entitlementCode;
    private DirtyValue<string?>? _equipmentOtherDescription;
    private DirtyValue<decimal?>? _estimatedImpactofHomeEquityRemainingAmount;
    private DirtyValue<decimal?>? _estimatedImpactofInterestRate;
    private DirtyValue<decimal?>? _estimatedImpactofLoanBalanceAmount;
    private DirtyValue<decimal?>? _estimatedImpactofLtv;
    private DirtyValue<int?>? _estimatedImpactofRemainingTermMonths;
    private DirtyValue<decimal?>? _estimatedImpactofTotalRemainingPaymentAmount;
    private DirtyValue<bool?>? _excludeTaxesInsuranceIndicator;
    private DirtyValue<decimal?>? _existingHomeEquityRemainingAmount;
    private DirtyValue<decimal?>? _existingLoanBalance;
    private DirtyValue<DateTime?>? _existingLoanFirstPaymentDate;
    private DirtyValue<decimal?>? _existingReasonableAppraisedValue;
    private DirtyValue<decimal?>? _existingTotalRemainingPaymentAmount;
    private DirtyValue<string?>? _existingVaLoanNumber;
    private DirtyValue<decimal?>? _finalDiscountAmount;
    private DirtyValue<decimal?>? _finalFundingFeeAmount;
    private DirtyValue<DateTime?>? _finalRecoupmentFormProvidedDate;
    private DirtyValue<bool?>? _firstChattelLoanType;
    private DirtyValue<bool?>? _firstTimeUse;
    private DirtyValue<bool?>? _fundingFeeExempt;
    private DirtyValue<bool?>? _garbageDisposalIndicator;
    private DirtyValue<bool?>? _includeLenderCreditIndicator;
    private DirtyValue<bool?>? _includeSectionAIndicator;
    private DirtyValue<bool?>? _includeSectionBOtherIndicator;
    private DirtyValue<bool?>? _includeSectionBVaFundingFeeIndicator;
    private DirtyValue<bool?>? _includeSectionCIndicator;
    private DirtyValue<bool?>? _includeSectionEIndicator;
    private DirtyValue<bool?>? _includeSectionFIndicator;
    private DirtyValue<bool?>? _includeSectionGIndicator;
    private DirtyValue<bool?>? _includeSectionHIndicator;
    private DirtyValue<DateTime?>? _initialRecoupmentFormProvidedDate;
    private DirtyValue<decimal?>? _initialTotal;
    private DirtyValue<StringEnumValue<InspectionWillBeMadeBy>>? _inspectionWillBeMadeBy;
    private DirtyValue<bool?>? _insulation;
    private DirtyValue<StringEnumValue<InsuranceType>>? _insuranceType;
    private DirtyValue<int?>? _irregularLotSizeInSquareFeet;
    private DirtyValue<bool?>? _isDelinquent30Days;
    private DirtyValue<string?>? _keysAtAddress;
    private DirtyValue<decimal?>? _landPurchasePrice;
    private DirtyValue<StringEnumValue<LeaseholdType>>? _leaseholdType;
    private DirtyValue<string?>? _lenderSar;
    private DirtyValue<int?>? _leRecoupmentMonths;
    private DirtyValue<decimal?>? _leTotalClosingCosts;
    private DirtyValue<string?>? _loanAnalysisRemarks1;
    private DirtyValue<string?>? _loanAnalysisRemarks2;
    private DirtyValue<string?>? _loanAnalysisRemarks3;
    private DirtyValue<string?>? _loanAnalysisRemarks4;
    private DirtyValue<string?>? _loanAnalysisRemarks5;
    private DirtyValue<string?>? _loanAnalysisRemarks6;
    private DirtyValue<string?>? _loanAnalysisRemarks7;
    private DirtyValue<string?>? _loanAnalysisRemarks8;
    private DirtyValue<string?>? _loanAnalysisRemarks9;
    private DirtyValue<StringEnumValue<LoanCode>>? _loanCode;
    private DirtyValue<StringEnumValue<LoanProcedure>>? _loanProcedure;
    private DirtyValue<bool?>? _loanProcessedUnderAu;
    private DirtyValue<string?>? _loanSummaryRemarks1;
    private DirtyValue<string?>? _loanSummaryRemarks2;
    private DirtyValue<string?>? _loanSummaryRemarks3;
    private DirtyValue<string?>? _loanSummaryRemarks4;
    private DirtyValue<string?>? _loanSummaryRemarks5;
    private DirtyValue<string?>? _loanSummaryRemarks6;
    private DirtyValue<string?>? _loanSummaryRemarks7;
    private DirtyValue<string?>? _loanSummaryRemarks8;
    private DirtyValue<string?>? _lotDimensions;
    private DirtyValue<string?>? _mailingAddress;
    private DirtyValue<string?>? _mailingCity;
    private DirtyValue<string?>? _mailingPostalCode;
    private DirtyValue<string?>? _mailingState;
    private DirtyValue<StringEnumValue<ManufacturedHome>>? _manufacturedHome;
    private DirtyValue<string?>? _mcrvNumber;
    private DirtyValue<StringEnumValue<MilitaryBranchOfService>>? _militaryBranchOfService;
    private DirtyList<MilitaryService>? _militaryServices;
    private DirtyValue<string?>? _mineralRightsReserved;
    private DirtyValue<string?>? _nameOfOccupant;
    private DirtyValue<string?>? _nameOfOwner;
    private DirtyValue<string?>? _nameOfWarrantyProgram;
    private DirtyValue<decimal?>? _negativeRents;
    private DirtyValue<bool?>? _noEnergyImprovements;
    private DirtyValue<string?>? _nonRealtyDescription;
    private DirtyValue<string?>? _numberOfBuildings;
    private DirtyValue<string?>? _occupantTelephone;
    private DirtyValue<bool?>? _onMilitaryDutyFollowingSeparation;
    private DirtyValue<decimal?>? _originalInterestRate;
    private DirtyValue<decimal?>? _originalLoanAmount;
    private DirtyValue<int?>? _originalTerm;
    private DirtyValue<bool?>? _originalValueEstimateChanged;
    private DirtyValue<decimal?>? _originationFeeAmount;
    private DirtyValue<decimal?>? _otherClosingCosts;
    private DirtyValue<string?>? _otherDescriptionEstateProperty;
    private DirtyValue<string?>? _otherDescriptionLoanType;
    private DirtyValue<bool?>? _otherEstateProperty;
    private DirtyValue<bool?>? _otherImprovements;
    private DirtyValue<bool?>? _otherLoanType;
    private DirtyValue<string?>? _paidInFullVaLoanNumber;
    private DirtyValue<bool?>? _payoffIndicator1;
    private DirtyValue<bool?>? _payoffIndicator2;
    private DirtyValue<bool?>? _payoffIndicator3;
    private DirtyValue<bool?>? _payoffIndicator4;
    private DirtyValue<bool?>? _payoffIndicator5;
    private DirtyValue<bool?>? _payoffIndicator6;
    private DirtyValue<bool?>? _payoffIndicator7;
    private DirtyValue<bool?>? _payoffIndicator8;
    private DirtyValue<bool?>? _payoffIndicator9;
    private DirtyValue<decimal?>? _pestReportFee;
    private DirtyValue<string?>? _plansSubmitted;
    private DirtyValue<string?>? _pocAddress;
    private DirtyValue<string?>? _pocCity;
    private DirtyValue<string?>? _pocName;
    private DirtyValue<string?>? _pocPhone;
    private DirtyValue<string?>? _pocState;
    private DirtyValue<string?>? _pocZipCode;
    private DirtyValue<decimal?>? _preliminaryDiscountAmount;
    private DirtyValue<decimal?>? _preliminaryFundingFeeAmount;
    private DirtyValue<decimal?>? _preliminaryTotal;
    private DirtyValue<bool?>? _previousVaLoanIndicator;
    private DirtyList<PreviousVaLoan>? _previousVaLoans;
    private DirtyValue<bool?>? _priorApprovalProcedure;
    private DirtyValue<StringEnumValue<PriorLoanType>>? _priorLoanType;
    private DirtyValue<StringEnumValue<PropertyDesignation>>? _propertyDesignation;
    private DirtyValue<int?>? _propertyGrossLivingArea;
    private DirtyValue<string?>? _propertyLegalDescription1;
    private DirtyValue<string?>? _propertyLegalDescription2;
    private DirtyValue<string?>? _propertyLegalDescription3;
    private DirtyValue<string?>? _propertyLegalDescription4;
    private DirtyValue<StringEnumValue<PropertyOccupancyType>>? _propertyOccupancyType;
    private DirtyValue<decimal?>? _proposedHomeEquityRemainingAmount;
    private DirtyValue<bool?>? _proposedSaleContractAttached;
    private DirtyValue<decimal?>? _proposedTotalRemainingPaymentAmount;
    private DirtyValue<bool?>? _purpleHeartRecipientIndicator;
    private DirtyValue<StringEnumValue<VaLoanDataPurposeOfLoan>>? _purposeOfLoan;
    private DirtyValue<bool?>? _rangeOvenIndicator;
    private DirtyValue<bool?>? _reasonableValueCompleted;
    private DirtyValue<decimal?>? _refinancePropertyExistingLienAmount;
    private DirtyValue<bool?>? _refrigeratorIndicator;
    private DirtyValue<string?>? _rent;
    private DirtyValue<bool?>? _replacementOfSystem;
    private DirtyValue<StringEnumValue<RiskClassification>>? _riskClassification;
    private DirtyValue<DateTime?>? _sarDate;
    private DirtyValue<string?>? _serviceNumber;
    private DirtyValue<bool?>? _solarHeatingOrCooling;
    private DirtyValue<string?>? _specialAssessmentComments1;
    private DirtyValue<string?>? _specialAssessmentComments2;
    private DirtyValue<string?>? _specialAssessmentComments3;
    private DirtyValue<StringEnumValue<PublicOrPrivate>>? _streetAccess;
    private DirtyValue<StringEnumValue<PublicOrPrivate>>? _streetMaintenance;
    private DirtyValue<StringEnumValue<SystemUsed>>? _systemUsed;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleLimitations1;
    private DirtyValue<string?>? _titleLimitations2;
    private DirtyValue<string?>? _titleLimitations3;
    private DirtyValue<decimal?>? _totalBaths;
    private DirtyValue<int?>? _totalBedrooms;
    private DirtyValue<decimal?>? _totalClosingCostLessGuaranteeFee;
    private DirtyValue<decimal?>? _totalDebtMonthlyPayment;
    private DirtyValue<decimal?>? _totalDiscountPointCharged;
    private DirtyValue<decimal?>? _totalDiscountPointsCharged;
    private DirtyValue<decimal?>? _totalForMaxLoanAmount;
    private DirtyValue<decimal?>? _totalMonthlyPayment;
    private DirtyValue<decimal?>? _totalPaidOverLifeIncreasedAmount;
    private DirtyValue<decimal?>? _totalProposedMonthlyPayment;
    private DirtyValue<int?>? _totalRooms;
    private DirtyValue<decimal?>? _totalUnpaidSpecialAssessments;
    private DirtyValue<StringEnumValue<TypeOfHybridARM>>? _typeOfHybridArm;
    private DirtyValue<StringEnumValue<TypeOfMortgage>>? _typeOfMortgage;
    private DirtyValue<StringEnumValue<TypeOfOwnsership>>? _typeOfOwnership;
    private DirtyValue<StringEnumValue<TypeOfStructure>>? _typeOfStructure;
    private DirtyValue<StringEnumValue<TypeOfVeteran>>? _typeOfVeteran;
    private DirtyValue<bool?>? _unsecuredLoanType;
    private DirtyValue<StringEnumValue<UtilitiesDescription>>? _utilitiesElectricDescription;
    private DirtyValue<StringEnumValue<UtilitiesDescription>>? _utilitiesGasDescription;
    private DirtyValue<StringEnumValue<UtilitiesDescription>>? _utilitiesSewerDescription;
    private DirtyValue<StringEnumValue<UtilitiesDescription>>? _utilitiesWaterDescription;
    private DirtyValue<DateTime?>? _vaAppraisalSentDate;
    private DirtyValue<StringEnumValue<VABenefitRelatedIndebtedness>>? _vaBenefitRelatedIndebtedness;
    private DirtyValue<string?>? _vaBuilderDescription;
    private DirtyValue<string?>? _vaBuilderIdNo;
    private DirtyValue<StringEnumValue<VACashOutRefinanceType>>? _vaCashOutRefinanceType;
    private DirtyValue<string?>? _vaClaimFolderNumber;
    private DirtyValue<string?>? _vaClaimNumber;
    private DirtyValue<DateTime?>? _vaDateNovAppraisalMailedToBorrower;
    private DirtyValue<bool?>? _vaEemIncludedinBaseLoanAmountIndicator;
    private DirtyValue<decimal?>? _vaEnergyEfficientImprovementsFinancedAmount;
    private DirtyValue<decimal?>? _vaFinancedClosingCostsToExcludeAmount;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactInterestRateIndicator;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactLoanBalanceIndicator;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactLtvIndicator;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactRemainingEquityIndicator;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactRemainingTermIndicator;
    private DirtyValue<StringEnumValue<IncreaseOrDecrease>>? _vaImpactScheduledPaymentsIndicator;
    private DirtyValue<bool?>? _vaIsDelinquent30Days;
    private DirtyValue<bool?>? _vaLatePaymentIn6Months;
    private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _vaLoanSummaryApplicantType;
    private DirtyValue<DateTime?>? _vaNovDateReceived;
    private DirtyValue<DateTime?>? _vaNovDateReviewed;
    private DirtyValue<DateTime?>? _vaNovIssuedDate;
    private DirtyValue<StringEnumValue<AmortizationType>>? _vaOriginalAmortizationType;
    private DirtyValue<decimal?>? _vaOriginalMonthlyPayment;
    private DirtyValue<string?>? _vaQualification2ndTierEntitlement;
    private DirtyValue<StringEnumValue<VAQualificationCountryRegion>>? _vaQualificationCountryRegion;
    private DirtyValue<decimal?>? _vaQualificationCountyLimits;
    private DirtyValue<bool?>? _vaRateReducedSolelybyDiscountPointsIndicator;
    private DirtyValue<int?>? _vaRecoupmentClosingCosts;
    private DirtyValue<bool?>? _vaRecoupmentExcludePrepaids;
    private DirtyValue<decimal?>? _vaRecoupmentMonthlyDecreaseInPayment;
    private DirtyValue<int?>? _vaRecoupmentMonths;
    private DirtyValue<decimal?>? _vaRecoupmentTotalClosingCosts;
    private DirtyValue<int?>? _vaRecoupmentYears;
    private DirtyValue<decimal?>? _vaStatutoryClosingCosts;
    private DirtyValue<decimal?>? _vaStatutoryMonthlyPayment;
    private DirtyValue<decimal?>? _vaStatutoryMonthlyReduction;
    private DirtyValue<int?>? _vaStatutoryRecoupmentMonths;
    private DirtyValue<DateTime?>? _vaTrackingCertOfCommitmentIssued;
    private DirtyValue<DateTime?>? _vaTrackingCoeIssueDate;
    private DirtyValue<string?>? _vaTrackingCoeIssueHistory;
    private DirtyValue<DateTime?>? _vaTrackingFinalApprovalCommitmentDate;
    private DirtyValue<bool?>? _vaTrackingGsaExclusionaryListChecked;
    private DirtyValue<bool?>? _vaTrackingInsuranceFloodPolicy;
    private DirtyValue<bool?>? _vaTrackingInsuranceHazardPolicy;
    private DirtyValue<bool?>? _vaTrackingInsuranceWindOrHailPolicy;
    private DirtyValue<bool?>? _vaTrackingInsuranceWoodDestroyingPolicy;
    private DirtyValue<bool?>? _vaTrackingIsSarLappCertified;
    private DirtyValue<DateTime?>? _vaTrackingLoanGuaranteeCertReceipt;
    private DirtyValue<DateTime?>? _vaTrackingMasterCommitmentLockExpired;
    private DirtyValue<DateTime?>? _vaTrackingOrderedDate;
    private DirtyValue<DateTime?>? _vaTrackingPaidDate;
    private DirtyValue<DateTime?>? _vaTrackingPurchaseContractDate;
    private DirtyValue<bool?>? _vaTrackingReceiptReceived;
    private DirtyValue<string?>? _vaTrackingSarId;
    private DirtyValue<string?>? _vaTrackingSarName;
    private DirtyValue<bool?>? _ventFanIndicator;
    private DirtyValue<bool?>? _veteranDischargedIndicator;
    private DirtyValue<StringEnumValue<VeteranServiceType>>? _veteranServiceType;
    private DirtyValue<string?>? _warrantorAddress;
    private DirtyValue<string?>? _warrantorCity;
    private DirtyValue<string?>? _warrantorName;
    private DirtyValue<string?>? _warrantorPhone;
    private DirtyValue<string?>? _warrantorPostalCode;
    private DirtyValue<string?>? _warrantorState;
    private DirtyValue<DateTime?>? _warrantyProgramExpirationDate;
    private DirtyValue<bool?>? _wwCarpetIndicator;

    /// <summary>
    /// VA Loan Disbursement - Date Aquired - If land aquired by separate transaction [VASUMM.X63]
    /// </summary>
    public DateTime? AcquiredLandDate { get => _acquiredLandDate; set => SetField(ref _acquiredLandDate, value); }

    /// <summary>
    /// Subject Property Legal DescAcres [600]
    /// </summary>
    public decimal? Acres { get => _acres; set => SetField(ref _acres, value); }

    /// <summary>
    /// VA Loan Disbursement - Describe additional security taken and list of others (including spouse) [VASUMM.X62]
    /// </summary>
    public string? AdditionalSecurityDescription { get => _additionalSecurityDescription; set => SetField(ref _additionalSecurityDescription, value); }

    /// <summary>
    /// VA To Admin of Benefits Street [VAVOB.X3]
    /// </summary>
    public string? AdministratorAddress { get => _administratorAddress; set => SetField(ref _administratorAddress, value); }

    /// <summary>
    /// VA To Admin of Benefits City [VAVOB.X4]
    /// </summary>
    public string? AdministratorCity { get => _administratorCity; set => SetField(ref _administratorCity, value); }

    /// <summary>
    /// VA To Admin of Benefits Attn [VAVOB.X2]
    /// </summary>
    public string? AdministratorContact { get => _administratorContact; set => SetField(ref _administratorContact, value); }

    /// <summary>
    /// VA To Admin of Benefits Name [VAVOB.X1]
    /// </summary>
    public string? AdministratorName { get => _administratorName; set => SetField(ref _administratorName, value); }

    /// <summary>
    /// VA To Admin of Benefits Zip [VAVOB.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AdministratorPostalCode { get => _administratorPostalCode; set => SetField(ref _administratorPostalCode, value); }

    /// <summary>
    /// VA To Admin of Benefits State [VAVOB.X5]
    /// </summary>
    public string? AdministratorState { get => _administratorState; set => SetField(ref _administratorState, value); }

    /// <summary>
    /// VA Loan Summ Property Age [VASUMM.X8]
    /// </summary>
    public int? AgeOfProperty { get => _ageOfProperty; set => SetField(ref _ageOfProperty, value); }

    /// <summary>
    /// VA Loan Amount of Proposed Liens [VASUMM.X126]
    /// </summary>
    public decimal? AmountOfProposedLiens { get => _amountOfProposedLiens; set => SetField(ref _amountOfProposedLiens, value); }

    /// <summary>
    /// Subject Property Energy Improve Amt [961]
    /// </summary>
    public decimal? AmountSpentOnEnergyImprovements { get => _amountSpentOnEnergyImprovements; set => SetField(ref _amountSpentOnEnergyImprovements, value); }

    /// <summary>
    /// VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in [VASUMM.X65]
    /// </summary>
    public StringEnumValue<AmountTypeWithheld> AmountTypeWithheld { get => _amountTypeWithheld; set => SetField(ref _amountTypeWithheld, value); }

    /// <summary>
    /// VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in [VASUMM.X66]
    /// </summary>
    public decimal? AmountWithheld { get => _amountWithheld; set => SetField(ref _amountWithheld, value); }

    /// <summary>
    /// VA Annual Ground Rent Amt [1035]
    /// </summary>
    public decimal? AnnualGroundRent { get => _annualGroundRent; set => SetField(ref _annualGroundRent, value); }

    /// <summary>
    /// Annual Maintenance Assessment [3643]
    /// </summary>
    public decimal? AnnualMaintenanceAssessment { get => _annualMaintenanceAssessment; set => SetField(ref _annualMaintenanceAssessment, value); }

    /// <summary>
    /// VA Annual RE Taxes [1031]
    /// </summary>
    public decimal? AnnualRealEstateTaxes { get => _annualRealEstateTaxes; set => SetField(ref _annualRealEstateTaxes, value); }

    /// <summary>
    /// VA Loan Disbursement - Annual Special Assessment [VASUMM.X59]
    /// </summary>
    public decimal? AnnualSpecialAssessment { get => _annualSpecialAssessment; set => SetField(ref _annualSpecialAssessment, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantAddressCity [VAELIG.X76], [VAVOB.X45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressCity { get => _applicantAddressCity; set => SetField(ref _applicantAddressCity, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantAddressPostalCode [VAELIG.X78], [VAVOB.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
    public string? ApplicantAddressPostalCode { get => _applicantAddressPostalCode; set => SetField(ref _applicantAddressPostalCode, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantAddressState [VAELIG.X77], [VAVOB.X46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressState { get => _applicantAddressState; set => SetField(ref _applicantAddressState, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantAddressStreetLine1 [VAELIG.X75], [VAVOB.X44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantAddressStreetLine1 { get => _applicantAddressStreetLine1; set => SetField(ref _applicantAddressStreetLine1, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantBirthDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ApplicantBirthDate { get => _applicantBirthDate; set => SetField(ref _applicantBirthDate, value); }

    /// <summary>
    /// VA Veteran Email Address [VAELIG.X97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantEmailAddressText { get => _applicantEmailAddressText; set => SetField(ref _applicantEmailAddressText, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantFirstNameWithMiddleName
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantFirstNameWithMiddleName { get => _applicantFirstNameWithMiddleName; set => SetField(ref _applicantFirstNameWithMiddleName, value); }

    /// <summary>
    /// VA Loan Summ Veteran Sex [VASUMM.X35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantHmdaGenderType { get => _applicantHmdaGenderType; set => SetField(ref _applicantHmdaGenderType, value); }

    /// <summary>
    /// VA Veteran Daytime Phone [VAELIG.X74]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? ApplicantHomePhoneNumber { get => _applicantHomePhoneNumber; set => SetField(ref _applicantHomePhoneNumber, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantLastNameWithSuffix
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ApplicantLastNameWithSuffix { get => _applicantLastNameWithSuffix; set => SetField(ref _applicantLastNameWithSuffix, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantTaxIdentificationIdentifier
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
    public string? ApplicantTaxIdentificationIdentifier { get => _applicantTaxIdentificationIdentifier; set => SetField(ref _applicantTaxIdentificationIdentifier, value); }

    /// <summary>
    /// VaLoanDataContract ApplicantWorkPhoneNumber
    /// </summary>
    public string? ApplicantWorkPhoneNumber { get => _applicantWorkPhoneNumber; set => SetField(ref _applicantWorkPhoneNumber, value); }

    /// <summary>
    /// Subject Property Appraisal Type [962]
    /// </summary>
    public StringEnumValue<AppraisalPropertyType> AppraisalType { get => _appraisalType; set => SetField(ref _appraisalType, value); }

    /// <summary>
    /// VA Date of Assignment [415]
    /// </summary>
    public DateTime? AssignmentDate { get => _assignmentDate; set => SetField(ref _assignmentDate, value); }

    /// <summary>
    /// VA Loan Disbursement - Automatic Procedure [VASUMM.X51]
    /// </summary>
    public bool? AutomaticProcedure { get => _automaticProcedure; set => SetField(ref _automaticProcedure, value); }

    /// <summary>
    /// Subject Property Time Avail AM [686]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? AvailableForInspectionAmIndicator { get => _availableForInspectionAmIndicator; set => SetField(ref _availableForInspectionAmIndicator, value); }

    /// <summary>
    /// Subject Property Date/Time Avail for Inspec [681]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? AvailableForInspectionDateAndTime { get => _availableForInspectionDateAndTime; set => SetField(ref _availableForInspectionDateAndTime, value); }

    /// <summary>
    /// VA Loan Summ Disc Points Paid by Veteran Amt [VASUMM.X46]
    /// </summary>
    public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => SetField(ref _borrowerPaidDiscountPointsTotalAmount, value); }

    /// <summary>
    /// Subject Property Building Type [602]
    /// </summary>
    public StringEnumValue<BuildingType> BuildingType { get => _buildingType; set => SetField(ref _buildingType, value); }

    /// <summary>
    /// VA Buyer Purch Lot Separately [1344]
    /// </summary>
    public bool? BuyerPurchasingLotSeparately { get => _buyerPurchasingLotSeparately; set => SetField(ref _buyerPurchasingLotSeparately, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Amount of Cash Directly Disbursed to Borrower(s) [VASUMM.X114]
    /// </summary>
    public decimal? CashDisbursedToBorrowerAmount { get => _cashDisbursedToBorrowerAmount; set => SetField(ref _cashDisbursedToBorrowerAmount, value); }

    /// <summary>
    /// VA Subtract Any Cash Payment from Veteran [VARRRWS.X1]
    /// </summary>
    public decimal? CashPaymentFromVeteran { get => _cashPaymentFromVeteran; set => SetField(ref _cashPaymentFromVeteran, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - CD Non Shoppable Less Funding Fee [VASUMM.X137]
    /// </summary>
    public decimal? CdNonShoppableLessFundingFee { get => _cdNonShoppableLessFundingFee; set => SetField(ref _cdNonShoppableLessFundingFee, value); }

    /// <summary>
    /// VA Certifcation Filed Claim Prior to Discharge [VAVOB.X71]
    /// </summary>
    public StringEnumValue<ClaimDisabilityBenefits> ClaimDisabilityBenefits { get => _claimDisabilityBenefits; set => SetField(ref _claimDisabilityBenefits, value); }

    /// <summary>
    /// VA Equipment Clothes Washer [302]
    /// </summary>
    public bool? ClothesWasherIndicator { get => _clothesWasherIndicator; set => SetField(ref _clothesWasherIndicator, value); }

    /// <summary>
    /// Subject Property Constr Completed [726]
    /// </summary>
    public DateTime? ConstructionCompletedDate { get => _constructionCompletedDate; set => SetField(ref _constructionCompletedDate, value); }

    /// <summary>
    /// VA New/Prop Constr Plan [1021]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<ConstructionPlan> ConstructionPlan { get => _constructionPlan; set => SetField(ref _constructionPlan, value); }

    /// <summary>
    /// Subject Property Constr Warranty Incl [722]
    /// </summary>
    public bool? ConstructionWarrantyIncluded { get => _constructionWarrantyIncluded; set => SetField(ref _constructionWarrantyIncluded, value); }

    /// <summary>
    /// VA Contract # Approved By VA [1037]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ContractNoApprovedBy { get => _contractNoApprovedBy; set => SetField(ref _contractNoApprovedBy, value); }

    /// <summary>
    /// VA Loan Summ Credit Score [VASUMM.X23]
    /// </summary>
    public int? CreditScore { get => _creditScore; set => SetField(ref _creditScore, value); }

    /// <summary>
    /// VA Currently on Military Duty [VAVOB.X68]
    /// </summary>
    public bool? CurrentlyOnMilitaryDuty { get => _currentlyOnMilitaryDuty; set => SetField(ref _currentlyOnMilitaryDuty, value); }

    /// <summary>
    /// VA Management Tool - Disability Amount Collected [VASUMM.X68]
    /// </summary>
    public decimal? DisabilityAmountCollected { get => _disabilityAmountCollected; set => SetField(ref _disabilityAmountCollected, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Amount of Disbursements less Mortgage Payoffs [VASUMM.X115]
    /// </summary>
    public decimal? DisbursementsLessPayoffAmount { get => _disbursementsLessPayoffAmount; set => SetField(ref _disbursementsLessPayoffAmount, value); }

    /// <summary>
    /// VA Loan Discount Fee % [VARRRWS.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPercentage { get => _discountPercentage; set => SetField(ref _discountPercentage, value); }

    /// <summary>
    /// VA Loan Summ Disc Points Paid by Veteran % [VASUMM.X48]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPoint { get => _discountPoint; set => SetField(ref _discountPoint, value); }

    /// <summary>
    /// VA Equipment Dishwasher [301]
    /// </summary>
    public bool? DishwasherIndicator { get => _dishwasherIndicator; set => SetField(ref _dishwasherIndicator, value); }

    /// <summary>
    /// VA Equipment Dryer [308]
    /// </summary>
    public bool? DryerIndicator { get => _dryerIndicator; set => SetField(ref _dryerIndicator, value); }

    /// <summary>
    /// VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded) [3347]
    /// </summary>
    public string? EmailToBeNotifiedWhenUploaded { get => _emailToBeNotifiedWhenUploaded; set => SetField(ref _emailToBeNotifiedWhenUploaded, value); }

    /// <summary>
    /// VA Energy Improvements Addition of Feature [379]
    /// </summary>
    public bool? EnergyImprovementsAdditionOfFeature { get => _energyImprovementsAdditionOfFeature; set => SetField(ref _energyImprovementsAdditionOfFeature, value); }

    /// <summary>
    /// VA Loan Summ Entitlement Code [VASUMM.X2]
    /// </summary>
    public string? EntitlementCode { get => _entitlementCode; set => SetField(ref _entitlementCode, value); }

    /// <summary>
    /// VA Equipment Other [320]
    /// </summary>
    public string? EquipmentOtherDescription { get => _equipmentOtherDescription; set => SetField(ref _equipmentOtherDescription, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Home Equity Remaining Amount [VASUMM.X113]
    /// </summary>
    public decimal? EstimatedImpactofHomeEquityRemainingAmount { get => _estimatedImpactofHomeEquityRemainingAmount; set => SetField(ref _estimatedImpactofHomeEquityRemainingAmount, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Interest Rate [VASUMM.X105]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? EstimatedImpactofInterestRate { get => _estimatedImpactofInterestRate; set => SetField(ref _estimatedImpactofInterestRate, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Loan Balance Amount [VASUMM.X103]
    /// </summary>
    public decimal? EstimatedImpactofLoanBalanceAmount { get => _estimatedImpactofLoanBalanceAmount; set => SetField(ref _estimatedImpactofLoanBalanceAmount, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Loan-to-Value Percentage [VASUMM.X109]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? EstimatedImpactofLtv { get => _estimatedImpactofLtv; set => SetField(ref _estimatedImpactofLtv, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Remaining Term Months [VASUMM.X104]
    /// </summary>
    public int? EstimatedImpactofRemainingTermMonths { get => _estimatedImpactofRemainingTermMonths; set => SetField(ref _estimatedImpactofRemainingTermMonths, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Estimated Impact of Total Remaining Scheduled Payments [VASUMM.X108]
    /// </summary>
    public decimal? EstimatedImpactofTotalRemainingPaymentAmount { get => _estimatedImpactofTotalRemainingPaymentAmount; set => SetField(ref _estimatedImpactofTotalRemainingPaymentAmount, value); }

    /// <summary>
    /// VA Management Tool - Exclude Taxes and Insurance [VASUMM.X100]
    /// </summary>
    public bool? ExcludeTaxesInsuranceIndicator { get => _excludeTaxesInsuranceIndicator; set => SetField(ref _excludeTaxesInsuranceIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Home Equity Remaining Amount [VASUMM.X111]
    /// </summary>
    public decimal? ExistingHomeEquityRemainingAmount { get => _existingHomeEquityRemainingAmount; set => SetField(ref _existingHomeEquityRemainingAmount, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Loan Balance [VASUMM.X102]
    /// </summary>
    public decimal? ExistingLoanBalance { get => _existingLoanBalance; set => SetField(ref _existingLoanBalance, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Loan First Payment Date [VASUMM.X123]
    /// </summary>
    public DateTime? ExistingLoanFirstPaymentDate { get => _existingLoanFirstPaymentDate; set => SetField(ref _existingLoanFirstPaymentDate, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Reasonable (Appraised) Value [VASUMM.X110]
    /// </summary>
    public decimal? ExistingReasonableAppraisedValue { get => _existingReasonableAppraisedValue; set => SetField(ref _existingReasonableAppraisedValue, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing Total of the Remaining Scheduled Payments [VASUMM.X106]
    /// </summary>
    public decimal? ExistingTotalRemainingPaymentAmount { get => _existingTotalRemainingPaymentAmount; set => SetField(ref _existingTotalRemainingPaymentAmount, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Existing VA Loan Number [VASUMM.X101]
    /// </summary>
    public string? ExistingVaLoanNumber { get => _existingVaLoanNumber; set => SetField(ref _existingVaLoanNumber, value); }

    /// <summary>
    /// VA Discount (Based from line 9) [VARRRWS.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FinalDiscountAmount { get => _finalDiscountAmount; set => SetField(ref _finalDiscountAmount, value); }

    /// <summary>
    /// VA Funding Fee (Round to Nearest Dollar) [VARRRWS.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FinalFundingFeeAmount { get => _finalFundingFeeAmount; set => SetField(ref _finalFundingFeeAmount, value); }

    /// <summary>
    /// Final Recoupment Form Provided Date [VASUMM.X136]
    /// </summary>
    public DateTime? FinalRecoupmentFormProvidedDate { get => _finalRecoupmentFormProvidedDate; set => SetField(ref _finalRecoupmentFormProvidedDate, value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - First Chattel  [VASUMM.X53]
    /// </summary>
    public bool? FirstChattelLoanType { get => _firstChattelLoanType; set => SetField(ref _firstChattelLoanType, value); }

    /// <summary>
    /// VA Loan Summ 1st Time Use VA Loan Program [VASUMM.X49]
    /// </summary>
    public bool? FirstTimeUse { get => _firstTimeUse; set => SetField(ref _firstTimeUse, value); }

    /// <summary>
    /// VA Loan Summ Discount Info [990]
    /// </summary>
    public bool? FundingFeeExempt { get => _fundingFeeExempt; set => SetField(ref _fundingFeeExempt, value); }

    /// <summary>
    /// VA Equipment Garbage Disposal [309]
    /// </summary>
    public bool? GarbageDisposalIndicator { get => _garbageDisposalIndicator; set => SetField(ref _garbageDisposalIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Lender Credit In Recoupment Test [VASUMM.X148]
    /// </summary>
    public bool? IncludeLenderCreditIndicator { get => _includeLenderCreditIndicator; set => SetField(ref _includeLenderCreditIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section A In Recoupment Test [VASUMM.X140]
    /// </summary>
    public bool? IncludeSectionAIndicator { get => _includeSectionAIndicator; set => SetField(ref _includeSectionAIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section B Other In Recoupment Test [VASUMM.X142]
    /// </summary>
    public bool? IncludeSectionBOtherIndicator { get => _includeSectionBOtherIndicator; set => SetField(ref _includeSectionBOtherIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section B VA Funding Fee In Recoupment Test [VASUMM.X141]
    /// </summary>
    public bool? IncludeSectionBVaFundingFeeIndicator { get => _includeSectionBVaFundingFeeIndicator; set => SetField(ref _includeSectionBVaFundingFeeIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section C In Recoupment Test [VASUMM.X143]
    /// </summary>
    public bool? IncludeSectionCIndicator { get => _includeSectionCIndicator; set => SetField(ref _includeSectionCIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section E In Recoupment Test [VASUMM.X144]
    /// </summary>
    public bool? IncludeSectionEIndicator { get => _includeSectionEIndicator; set => SetField(ref _includeSectionEIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section F In Recoupment Test [VASUMM.X145]
    /// </summary>
    public bool? IncludeSectionFIndicator { get => _includeSectionFIndicator; set => SetField(ref _includeSectionFIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section G In Recoupment Test [VASUMM.X146]
    /// </summary>
    public bool? IncludeSectionGIndicator { get => _includeSectionGIndicator; set => SetField(ref _includeSectionGIndicator, value); }

    /// <summary>
    /// VA Management Tool - Include Section H In Recoupment Test [VASUMM.X147]
    /// </summary>
    public bool? IncludeSectionHIndicator { get => _includeSectionHIndicator; set => SetField(ref _includeSectionHIndicator, value); }

    /// <summary>
    /// Initial Recoupment Form Provided Date [VASUMM.X135]
    /// </summary>
    public DateTime? InitialRecoupmentFormProvidedDate { get => _initialRecoupmentFormProvidedDate; set => SetField(ref _initialRecoupmentFormProvidedDate, value); }

    /// <summary>
    /// VA Initial Computation Total [VARRRWS.X2]
    /// </summary>
    public decimal? InitialTotal { get => _initialTotal; set => SetField(ref _initialTotal, value); }

    /// <summary>
    /// VA New/Prop Constr Inspec By [1020]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<InspectionWillBeMadeBy> InspectionWillBeMadeBy { get => _inspectionWillBeMadeBy; set => SetField(ref _inspectionWillBeMadeBy, value); }

    /// <summary>
    /// VA Energy Improvements Insulation [380]
    /// </summary>
    public bool? Insulation { get => _insulation; set => SetField(ref _insulation, value); }

    /// <summary>
    /// Insurance Type [3642]
    /// </summary>
    public StringEnumValue<InsuranceType> InsuranceType { get => _insuranceType; set => SetField(ref _insuranceType, value); }

    /// <summary>
    /// Subject Property Irreg Sq Ft [1043]
    /// </summary>
    public int? IrregularLotSizeInSquareFeet { get => _irregularLotSizeInSquareFeet; set => SetField(ref _irregularLotSizeInSquareFeet, value); }

    /// <summary>
    /// VaLoanDataContract IsDelinquent30Days
    /// </summary>
    public bool? IsDelinquent30Days { get => _isDelinquent30Days; set => SetField(ref _isDelinquent30Days, value); }

    /// <summary>
    /// Subject Property Keys At [683]
    /// </summary>
    public string? KeysAtAddress { get => _keysAtAddress; set => SetField(ref _keysAtAddress, value); }

    /// <summary>
    /// VA Loan Disbursement - Land Purchase Price [VASUMM.X64]
    /// </summary>
    public decimal? LandPurchasePrice { get => _landPurchasePrice; set => SetField(ref _landPurchasePrice, value); }

    /// <summary>
    /// VA Lease Is [1033]
    /// </summary>
    public StringEnumValue<LeaseholdType> LeaseholdType { get => _leaseholdType; set => SetField(ref _leaseholdType, value); }

    /// <summary>
    /// VA Loan Summ Lender SAR ID [VASUMM.X6]
    /// </summary>
    public string? LenderSar { get => _lenderSar; set => SetField(ref _lenderSar, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Opening Recoupment Months [VASUMM.X139]
    /// </summary>
    public int? LeRecoupmentMonths { get => _leRecoupmentMonths; set => SetField(ref _leRecoupmentMonths, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Total Opening Closing Costs [VASUMM.X138]
    /// </summary>
    public decimal? LeTotalClosingCosts { get => _leTotalClosingCosts; set => SetField(ref _leTotalClosingCosts, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 1 [VALA.X10]
    /// </summary>
    public string? LoanAnalysisRemarks1 { get => _loanAnalysisRemarks1; set => SetField(ref _loanAnalysisRemarks1, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 2 [VALA.X11]
    /// </summary>
    public string? LoanAnalysisRemarks2 { get => _loanAnalysisRemarks2; set => SetField(ref _loanAnalysisRemarks2, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 3 [VALA.X12]
    /// </summary>
    public string? LoanAnalysisRemarks3 { get => _loanAnalysisRemarks3; set => SetField(ref _loanAnalysisRemarks3, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 4 [VALA.X13]
    /// </summary>
    public string? LoanAnalysisRemarks4 { get => _loanAnalysisRemarks4; set => SetField(ref _loanAnalysisRemarks4, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 5 [VALA.X14]
    /// </summary>
    public string? LoanAnalysisRemarks5 { get => _loanAnalysisRemarks5; set => SetField(ref _loanAnalysisRemarks5, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 6 [VALA.X15]
    /// </summary>
    public string? LoanAnalysisRemarks6 { get => _loanAnalysisRemarks6; set => SetField(ref _loanAnalysisRemarks6, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 7 [VALA.X16]
    /// </summary>
    public string? LoanAnalysisRemarks7 { get => _loanAnalysisRemarks7; set => SetField(ref _loanAnalysisRemarks7, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 8 [VALA.X17]
    /// </summary>
    public string? LoanAnalysisRemarks8 { get => _loanAnalysisRemarks8; set => SetField(ref _loanAnalysisRemarks8, value); }

    /// <summary>
    /// VA Loan Analysis Remarks 9 [VALA.X18]
    /// </summary>
    public string? LoanAnalysisRemarks9 { get => _loanAnalysisRemarks9; set => SetField(ref _loanAnalysisRemarks9, value); }

    /// <summary>
    /// VA Veteran Loan Code [958]
    /// </summary>
    public StringEnumValue<LoanCode> LoanCode { get => _loanCode; set => SetField(ref _loanCode, value); }

    /// <summary>
    /// VA Veteran Loan Procedure [953]
    /// </summary>
    public StringEnumValue<LoanProcedure> LoanProcedure { get => _loanProcedure; set => SetField(ref _loanProcedure, value); }

    /// <summary>
    /// VA Loan Summ VA Recognized Auto Underwriting Sys [VASUMM.X4]
    /// </summary>
    public bool? LoanProcessedUnderAu { get => _loanProcessedUnderAu; set => SetField(ref _loanProcessedUnderAu, value); }

    /// <summary>
    /// VA Loan Summ Remarks 1 [VASUMM.X37]
    /// </summary>
    public string? LoanSummaryRemarks1 { get => _loanSummaryRemarks1; set => SetField(ref _loanSummaryRemarks1, value); }

    /// <summary>
    /// VA Loan Summ Remarks 2 [VASUMM.X38]
    /// </summary>
    public string? LoanSummaryRemarks2 { get => _loanSummaryRemarks2; set => SetField(ref _loanSummaryRemarks2, value); }

    /// <summary>
    /// VA Loan Summ Remarks 3 [VASUMM.X39]
    /// </summary>
    public string? LoanSummaryRemarks3 { get => _loanSummaryRemarks3; set => SetField(ref _loanSummaryRemarks3, value); }

    /// <summary>
    /// VA Loan Summ Remarks 4 [VASUMM.X40]
    /// </summary>
    public string? LoanSummaryRemarks4 { get => _loanSummaryRemarks4; set => SetField(ref _loanSummaryRemarks4, value); }

    /// <summary>
    /// VA Loan Summ Remarks 5 [VASUMM.X41]
    /// </summary>
    public string? LoanSummaryRemarks5 { get => _loanSummaryRemarks5; set => SetField(ref _loanSummaryRemarks5, value); }

    /// <summary>
    /// VA Loan Summ Remarks 6 [VASUMM.X42]
    /// </summary>
    public string? LoanSummaryRemarks6 { get => _loanSummaryRemarks6; set => SetField(ref _loanSummaryRemarks6, value); }

    /// <summary>
    /// VA Loan Summ Remarks 7 [VASUMM.X43]
    /// </summary>
    public string? LoanSummaryRemarks7 { get => _loanSummaryRemarks7; set => SetField(ref _loanSummaryRemarks7, value); }

    /// <summary>
    /// VA Loan Summ Remarks 8 [VASUMM.X44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LoanSummaryRemarks8 { get => _loanSummaryRemarks8; set => SetField(ref _loanSummaryRemarks8, value); }

    /// <summary>
    /// Subject Property Lot Dimensions [1042]
    /// </summary>
    public string? LotDimensions { get => _lotDimensions; set => SetField(ref _lotDimensions, value); }

    /// <summary>
    /// VA Veteran Mailing Addr Street [VAELIG.X51]
    /// </summary>
    public string? MailingAddress { get => _mailingAddress; set => SetField(ref _mailingAddress, value); }

    /// <summary>
    /// VA Veteran Mailing Addr City [VAELIG.X54]
    /// </summary>
    public string? MailingCity { get => _mailingCity; set => SetField(ref _mailingCity, value); }

    /// <summary>
    /// VA Veteran Mailing Addr Zip [VAELIG.X56]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MailingPostalCode { get => _mailingPostalCode; set => SetField(ref _mailingPostalCode, value); }

    /// <summary>
    /// VA Veteran Mailing Addr State [VAELIG.X55]
    /// </summary>
    public string? MailingState { get => _mailingState; set => SetField(ref _mailingState, value); }

    /// <summary>
    /// Subject Property Manufactured Home [963]
    /// </summary>
    public StringEnumValue<ManufacturedHome> ManufacturedHome { get => _manufacturedHome; set => SetField(ref _manufacturedHome, value); }

    /// <summary>
    /// Subject Property Energy Improve MCRV # [989]
    /// </summary>
    public string? McrvNumber { get => _mcrvNumber; set => SetField(ref _mcrvNumber, value); }

    /// <summary>
    /// VA Veteran Branch of Service [954]
    /// </summary>
    public StringEnumValue<MilitaryBranchOfService> MilitaryBranchOfService { get => _militaryBranchOfService; set => SetField(ref _militaryBranchOfService, value); }

    /// <summary>
    /// VaLoanDataContract MilitaryServices
    /// </summary>
    [AllowNull]
    public IList<MilitaryService> MilitaryServices { get => GetField(ref _militaryServices); set => SetField(ref _militaryServices, value); }

    /// <summary>
    /// VA Mineral Rights Reserved [1032]
    /// </summary>
    public string? MineralRightsReserved { get => _mineralRightsReserved; set => SetField(ref _mineralRightsReserved, value); }

    /// <summary>
    /// Subject Property Occupant Name [730]
    /// </summary>
    public string? NameOfOccupant { get => _nameOfOccupant; set => SetField(ref _nameOfOccupant, value); }

    /// <summary>
    /// Subject Property Owner Name [727]
    /// </summary>
    public string? NameOfOwner { get => _nameOfOwner; set => SetField(ref _nameOfOwner, value); }

    /// <summary>
    /// Subject Property Warranty Program Name [724]
    /// </summary>
    public string? NameOfWarrantyProgram { get => _nameOfWarrantyProgram; set => SetField(ref _nameOfWarrantyProgram, value); }

    /// <summary>
    /// VA Loan Analysis Negative Rents [VALA.X30]
    /// </summary>
    public decimal? NegativeRents { get => _negativeRents; set => SetField(ref _negativeRents, value); }

    /// <summary>
    /// VA Energy Improvements None [376]
    /// </summary>
    public bool? NoEnergyImprovements { get => _noEnergyImprovements; set => SetField(ref _noEnergyImprovements, value); }

    /// <summary>
    /// VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan [VASUMM.X61]
    /// </summary>
    public string? NonRealtyDescription { get => _nonRealtyDescription; set => SetField(ref _nonRealtyDescription, value); }

    /// <summary>
    /// Subject Property # Buildings [604]
    /// </summary>
    public string? NumberOfBuildings { get => _numberOfBuildings; set => SetField(ref _numberOfBuildings, value); }

    /// <summary>
    /// Subject Property Occupant Phone [731]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? OccupantTelephone { get => _occupantTelephone; set => SetField(ref _occupantTelephone, value); }

    /// <summary>
    /// VA On Military Duty Day Following Separation [VAVOB.X69]
    /// </summary>
    public bool? OnMilitaryDutyFollowingSeparation { get => _onMilitaryDutyFollowingSeparation; set => SetField(ref _onMilitaryDutyFollowingSeparation, value); }

    /// <summary>
    /// VA Loan Summ Orig Int Rate [VASUMM.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginalInterestRate { get => _originalInterestRate; set => SetField(ref _originalInterestRate, value); }

    /// <summary>
    /// VA Loan Summ Orig Loan Amt [VASUMM.X15]
    /// </summary>
    public decimal? OriginalLoanAmount { get => _originalLoanAmount; set => SetField(ref _originalLoanAmount, value); }

    /// <summary>
    /// VA Loan Summ Orig Term [VASUMM.X18]
    /// </summary>
    public int? OriginalTerm { get => _originalTerm; set => SetField(ref _originalTerm, value); }

    /// <summary>
    /// VA Loan Summ Y/N Appraisers Orig Value Est Changed [VASUMM.X13]
    /// </summary>
    public bool? OriginalValueEstimateChanged { get => _originalValueEstimateChanged; set => SetField(ref _originalValueEstimateChanged, value); }

    /// <summary>
    /// VA Origination Fee [VARRRWS.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OriginationFeeAmount { get => _originationFeeAmount; set => SetField(ref _originationFeeAmount, value); }

    /// <summary>
    /// VA Add Other Allowable Closing Costs/Prepaids [VARRRWS.X6]
    /// </summary>
    public decimal? OtherClosingCosts { get => _otherClosingCosts; set => SetField(ref _otherClosingCosts, value); }

    /// <summary>
    /// VA Loan Disbursement - Estate in Property - Other Description [VASUMM.X58]
    /// </summary>
    public string? OtherDescriptionEstateProperty { get => _otherDescriptionEstateProperty; set => SetField(ref _otherDescriptionEstateProperty, value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Other Description [VASUMM.X56]
    /// </summary>
    public string? OtherDescriptionLoanType { get => _otherDescriptionLoanType; set => SetField(ref _otherDescriptionLoanType, value); }

    /// <summary>
    /// VA Loan Disbursement - Estate in Property - Other [VASUMM.X57]
    /// </summary>
    public bool? OtherEstateProperty { get => _otherEstateProperty; set => SetField(ref _otherEstateProperty, value); }

    /// <summary>
    /// VA Other Improvements [381]
    /// </summary>
    public bool? OtherImprovements { get => _otherImprovements; set => SetField(ref _otherImprovements, value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Other [VASUMM.X55]
    /// </summary>
    public bool? OtherLoanType { get => _otherLoanType; set => SetField(ref _otherLoanType, value); }

    /// <summary>
    /// VA Loan Summ Paid In Full Loan # [VASUMM.X14]
    /// </summary>
    public string? PaidInFullVaLoanNumber { get => _paidInFullVaLoanNumber; set => SetField(ref _paidInFullVaLoanNumber, value); }

    /// <summary>
    /// VA Loan Analysis Liability 1 Incl on Line 41 [VALA.X20]
    /// </summary>
    public bool? PayoffIndicator1 { get => _payoffIndicator1; set => SetField(ref _payoffIndicator1, value); }

    /// <summary>
    /// VA Loan Analysis Liability 2 Incl on Line 41 [VALA.X21]
    /// </summary>
    public bool? PayoffIndicator2 { get => _payoffIndicator2; set => SetField(ref _payoffIndicator2, value); }

    /// <summary>
    /// VA Loan Analysis Liability 3 Incl on Line 41 [VALA.X22]
    /// </summary>
    public bool? PayoffIndicator3 { get => _payoffIndicator3; set => SetField(ref _payoffIndicator3, value); }

    /// <summary>
    /// VA Loan Analysis Liability 4 Incl on Line 41 [VALA.X23]
    /// </summary>
    public bool? PayoffIndicator4 { get => _payoffIndicator4; set => SetField(ref _payoffIndicator4, value); }

    /// <summary>
    /// VA Loan Analysis Liability 5 Incl on Line 41 [VALA.X24]
    /// </summary>
    public bool? PayoffIndicator5 { get => _payoffIndicator5; set => SetField(ref _payoffIndicator5, value); }

    /// <summary>
    /// VA Loan Analysis Liability 6 Incl on Line 41 [VALA.X25]
    /// </summary>
    public bool? PayoffIndicator6 { get => _payoffIndicator6; set => SetField(ref _payoffIndicator6, value); }

    /// <summary>
    /// VA Loan Analysis Liability 7 Incl on Line 41 [VALA.X26]
    /// </summary>
    public bool? PayoffIndicator7 { get => _payoffIndicator7; set => SetField(ref _payoffIndicator7, value); }

    /// <summary>
    /// VA Loan Analysis Alimony/Child Supp Incl on Line 41 [VALA.X27]
    /// </summary>
    public bool? PayoffIndicator8 { get => _payoffIndicator8; set => SetField(ref _payoffIndicator8, value); }

    /// <summary>
    /// VA Loan Analysis Other Liabilities Incl on Line 41 [VALA.X28]
    /// </summary>
    public bool? PayoffIndicator9 { get => _payoffIndicator9; set => SetField(ref _payoffIndicator9, value); }

    /// <summary>
    /// VA Management Tool - Pest Report Fee [VASUMM.X69]
    /// </summary>
    public decimal? PestReportFee { get => _pestReportFee; set => SetField(ref _pestReportFee, value); }

    /// <summary>
    /// VA New/Prop Constr Plan Prev Case # [1022]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PlansSubmitted { get => _plansSubmitted; set => SetField(ref _plansSubmitted, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Address [3350]
    /// </summary>
    public string? PocAddress { get => _pocAddress; set => SetField(ref _pocAddress, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information City [3351]
    /// </summary>
    public string? PocCity { get => _pocCity; set => SetField(ref _pocCity, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Name [3349]
    /// </summary>
    public string? PocName { get => _pocName; set => SetField(ref _pocName, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Phone [3354]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PocPhone { get => _pocPhone; set => SetField(ref _pocPhone, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information State [3352]
    /// </summary>
    public string? PocState { get => _pocState; set => SetField(ref _pocState, value); }

    /// <summary>
    /// VA 261805 Applicable Point of Contact (POC) Information Zipcode [3353]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PocZipCode { get => _pocZipCode; set => SetField(ref _pocZipCode, value); }

    /// <summary>
    /// VA Discount Amt [VARRRWS.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryDiscountAmount { get => _preliminaryDiscountAmount; set => SetField(ref _preliminaryDiscountAmount, value); }

    /// <summary>
    /// VA Funding Fee [VARRRWS.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryFundingFeeAmount { get => _preliminaryFundingFeeAmount; set => SetField(ref _preliminaryFundingFeeAmount, value); }

    /// <summary>
    /// VA Preliminary Loan Amt Total [VARRRWS.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PreliminaryTotal { get => _preliminaryTotal; set => SetField(ref _preliminaryTotal, value); }

    /// <summary>
    /// VA Military Previous VA Loan Not Applicable (NA) [VAELIG.X113]
    /// </summary>
    public bool? PreviousVaLoanIndicator { get => _previousVaLoanIndicator; set => SetField(ref _previousVaLoanIndicator, value); }

    /// <summary>
    /// VaLoanDataContract PreviousVaLoans
    /// </summary>
    [AllowNull]
    public IList<PreviousVaLoan> PreviousVaLoans { get => GetField(ref _previousVaLoans); set => SetField(ref _previousVaLoans, value); }

    /// <summary>
    /// VA Loan Disbursement - Prior Approval Procedure [VASUMM.X52]
    /// </summary>
    public bool? PriorApprovalProcedure { get => _priorApprovalProcedure; set => SetField(ref _priorApprovalProcedure, value); }

    /// <summary>
    /// VA Loan Summ Prior Loan Type [VASUMM.X50]
    /// </summary>
    public StringEnumValue<PriorLoanType> PriorLoanType { get => _priorLoanType; set => SetField(ref _priorLoanType, value); }

    /// <summary>
    /// Subject Property Energy Improve Property Desig [988]
    /// </summary>
    public StringEnumValue<PropertyDesignation> PropertyDesignation { get => _propertyDesignation; set => SetField(ref _propertyDesignation, value); }

    /// <summary>
    /// VA Loan Summ Property Gross Living Area [VASUMM.X7]
    /// </summary>
    public int? PropertyGrossLivingArea { get => _propertyGrossLivingArea; set => SetField(ref _propertyGrossLivingArea, value); }

    /// <summary>
    /// Subject Property Legal Descr 1 [765]
    /// </summary>
    public string? PropertyLegalDescription1 { get => _propertyLegalDescription1; set => SetField(ref _propertyLegalDescription1, value); }

    /// <summary>
    /// Subject Property Legal Descr 2 [766]
    /// </summary>
    public string? PropertyLegalDescription2 { get => _propertyLegalDescription2; set => SetField(ref _propertyLegalDescription2, value); }

    /// <summary>
    /// Subject Property Legal Descr 3 [797]
    /// </summary>
    public string? PropertyLegalDescription3 { get => _propertyLegalDescription3; set => SetField(ref _propertyLegalDescription3, value); }

    /// <summary>
    /// Subject Property Legal Descr 4 [798]
    /// </summary>
    public string? PropertyLegalDescription4 { get => _propertyLegalDescription4; set => SetField(ref _propertyLegalDescription4, value); }

    /// <summary>
    /// Subject Property Type [728]
    /// </summary>
    public StringEnumValue<PropertyOccupancyType> PropertyOccupancyType { get => _propertyOccupancyType; set => SetField(ref _propertyOccupancyType, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Proposed Home Equity Remaining Amount [VASUMM.X112]
    /// </summary>
    public decimal? ProposedHomeEquityRemainingAmount { get => _proposedHomeEquityRemainingAmount; set => SetField(ref _proposedHomeEquityRemainingAmount, value); }

    /// <summary>
    /// VA Proposed Sale Contract Attached [1036]
    /// </summary>
    public bool? ProposedSaleContractAttached { get => _proposedSaleContractAttached; set => SetField(ref _proposedSaleContractAttached, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Proposed Total of the Remaining Scheduled Payments [VASUMM.X107]
    /// </summary>
    public decimal? ProposedTotalRemainingPaymentAmount { get => _proposedTotalRemainingPaymentAmount; set => SetField(ref _proposedTotalRemainingPaymentAmount, value); }

    /// <summary>
    /// VA Military Purple Heart Recipient Indicator [VAELIG.X114]
    /// </summary>
    public bool? PurpleHeartRecipientIndicator { get => _purpleHeartRecipientIndicator; set => SetField(ref _purpleHeartRecipientIndicator, value); }

    /// <summary>
    /// VA Veteran Loan Purpose [956]
    /// </summary>
    public StringEnumValue<VaLoanDataPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => SetField(ref _purposeOfLoan, value); }

    /// <summary>
    /// VA Equipment Range Oven [204]
    /// </summary>
    public bool? RangeOvenIndicator { get => _rangeOvenIndicator; set => SetField(ref _rangeOvenIndicator, value); }

    /// <summary>
    /// VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value [VASUMM.X67]
    /// </summary>
    public bool? ReasonableValueCompleted { get => _reasonableValueCompleted; set => SetField(ref _reasonableValueCompleted, value); }

    /// <summary>
    /// VA Management Tool - Loan Info Refi Existing Lien [VASUMM.X149]
    /// </summary>
    public decimal? RefinancePropertyExistingLienAmount { get => _refinancePropertyExistingLienAmount; set => SetField(ref _refinancePropertyExistingLienAmount, value); }

    /// <summary>
    /// VA Equipment Refrigerator [209]
    /// </summary>
    public bool? RefrigeratorIndicator { get => _refrigeratorIndicator; set => SetField(ref _refrigeratorIndicator, value); }

    /// <summary>
    /// Subject Property Rent [729]
    /// </summary>
    public string? Rent { get => _rent; set => SetField(ref _rent, value); }

    /// <summary>
    /// VA Energy Improvements Replacement of System [378]
    /// </summary>
    public bool? ReplacementOfSystem { get => _replacementOfSystem; set => SetField(ref _replacementOfSystem, value); }

    /// <summary>
    /// VA Loan Summ Risk Classification [VASUMM.X21]
    /// </summary>
    public StringEnumValue<RiskClassification> RiskClassification { get => _riskClassification; set => SetField(ref _riskClassification, value); }

    /// <summary>
    /// VA Loan Summ Date SAR Issued Value [VASUMM.X9]
    /// </summary>
    public DateTime? SarDate { get => _sarDate; set => SetField(ref _sarDate, value); }

    /// <summary>
    /// VA Svc # [VAVOB.X67]
    /// </summary>
    public string? ServiceNumber { get => _serviceNumber; set => SetField(ref _serviceNumber, value); }

    /// <summary>
    /// Fees Survey to Seller [377]
    /// </summary>
    public bool? SolarHeatingOrCooling { get => _solarHeatingOrCooling; set => SetField(ref _solarHeatingOrCooling, value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 1 [1028]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments1 { get => _specialAssessmentComments1; set => SetField(ref _specialAssessmentComments1, value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 2 [1029]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments2 { get => _specialAssessmentComments2; set => SetField(ref _specialAssessmentComments2, value); }

    /// <summary>
    /// VA Special Assess/HOA Charges Comments 3 [1030]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialAssessmentComments3 { get => _specialAssessmentComments3; set => SetField(ref _specialAssessmentComments3, value); }

    /// <summary>
    /// Subject Property Street Access [720]
    /// </summary>
    public StringEnumValue<PublicOrPrivate> StreetAccess { get => _streetAccess; set => SetField(ref _streetAccess, value); }

    /// <summary>
    /// Subject Property Street Maint [721]
    /// </summary>
    public StringEnumValue<PublicOrPrivate> StreetMaintenance { get => _streetMaintenance; set => SetField(ref _streetMaintenance, value); }

    /// <summary>
    /// VA Loan Summ Underwriting System Used [VASUMM.X17]
    /// </summary>
    public StringEnumValue<SystemUsed> SystemUsed { get => _systemUsed; set => SetField(ref _systemUsed, value); }

    /// <summary>
    /// VA New/Prop Constr Title [GAPPR.X5]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Subject Property Title Limitations 1 [926]
    /// </summary>
    public string? TitleLimitations1 { get => _titleLimitations1; set => SetField(ref _titleLimitations1, value); }

    /// <summary>
    /// Subject Property Title Limitations 2 [927]
    /// </summary>
    public string? TitleLimitations2 { get => _titleLimitations2; set => SetField(ref _titleLimitations2, value); }

    /// <summary>
    /// Subject Property Title Limitations 3 [928]
    /// </summary>
    public string? TitleLimitations3 { get => _titleLimitations3; set => SetField(ref _titleLimitations3, value); }

    /// <summary>
    /// VA Loan Summ Baths [VASUMM.X11]
    /// </summary>
    public decimal? TotalBaths { get => _totalBaths; set => SetField(ref _totalBaths, value); }

    /// <summary>
    /// VA Loan Summ Bedrooms [VASUMM.X12]
    /// </summary>
    public int? TotalBedrooms { get => _totalBedrooms; set => SetField(ref _totalBedrooms, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Total CLosing Cost Less Guarantee Fee [VASUMM.X124]
    /// </summary>
    public decimal? TotalClosingCostLessGuaranteeFee { get => _totalClosingCostLessGuaranteeFee; set => SetField(ref _totalClosingCostLessGuaranteeFee, value); }

    /// <summary>
    /// VA Loan Analysis Total Debt Mo Pymt [VALA.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDebtMonthlyPayment { get => _totalDebtMonthlyPayment; set => SetField(ref _totalDebtMonthlyPayment, value); }

    /// <summary>
    /// VA Loan Summ Total Disc Points Chrgd Amt [VASUMM.X45]
    /// </summary>
    public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => SetField(ref _totalDiscountPointCharged, value); }

    /// <summary>
    /// VA Loan Summ Total Disc Points Chrgd % [VASUMM.X47]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalDiscountPointsCharged { get => _totalDiscountPointsCharged; set => SetField(ref _totalDiscountPointsCharged, value); }

    /// <summary>
    /// VA Total - Max Loan Amt [VARRRWS.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForMaxLoanAmount { get => _totalForMaxLoanAmount; set => SetField(ref _totalForMaxLoanAmount, value); }

    /// <summary>
    /// VA Management Tool - Total Monthly Payment [VASUMM.X98]
    /// </summary>
    public decimal? TotalMonthlyPayment { get => _totalMonthlyPayment; set => SetField(ref _totalMonthlyPayment, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Increase in Total Paid Over Life of Loan [VASUMM.X122]
    /// </summary>
    public decimal? TotalPaidOverLifeIncreasedAmount { get => _totalPaidOverLifeIncreasedAmount; set => SetField(ref _totalPaidOverLifeIncreasedAmount, value); }

    /// <summary>
    /// VA Management Tool - Total Proposed Monthly Payment [VASUMM.X99]
    /// </summary>
    public decimal? TotalProposedMonthlyPayment { get => _totalProposedMonthlyPayment; set => SetField(ref _totalProposedMonthlyPayment, value); }

    /// <summary>
    /// VA Loan Summ Total Rooms [VASUMM.X10]
    /// </summary>
    public int? TotalRooms { get => _totalRooms; set => SetField(ref _totalRooms, value); }

    /// <summary>
    /// VA Loan Disbursement - Total Unpaid Special Assessments [VASUMM.X60]
    /// </summary>
    public decimal? TotalUnpaidSpecialAssessments { get => _totalUnpaidSpecialAssessments; set => SetField(ref _totalUnpaidSpecialAssessments, value); }

    /// <summary>
    /// VA Loan Summ HYBRID-ARM Type [VASUMM.X24]
    /// </summary>
    public StringEnumValue<TypeOfHybridARM> TypeOfHybridArm { get => _typeOfHybridArm; set => SetField(ref _typeOfHybridArm, value); }

    /// <summary>
    /// VA Veteran Mtg Type [959]
    /// </summary>
    public StringEnumValue<TypeOfMortgage> TypeOfMortgage { get => _typeOfMortgage; set => SetField(ref _typeOfMortgage, value); }

    /// <summary>
    /// VA Veteran Ownership Type [957]
    /// </summary>
    public StringEnumValue<TypeOfOwnsership> TypeOfOwnership { get => _typeOfOwnership; set => SetField(ref _typeOfOwnership, value); }

    /// <summary>
    /// Subject Property Energy Improve Structure Type [986]
    /// </summary>
    public StringEnumValue<TypeOfStructure> TypeOfStructure { get => _typeOfStructure; set => SetField(ref _typeOfStructure, value); }

    /// <summary>
    /// VA Veteran Type [VAVOB.X72]
    /// </summary>
    public StringEnumValue<TypeOfVeteran> TypeOfVeteran { get => _typeOfVeteran; set => SetField(ref _typeOfVeteran, value); }

    /// <summary>
    /// VA Loan Disbursement - Type of Loan - Unsecured  [VASUMM.X54]
    /// </summary>
    public bool? UnsecuredLoanType { get => _unsecuredLoanType; set => SetField(ref _unsecuredLoanType, value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Elec [1096]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesElectricDescription { get => _utilitiesElectricDescription; set => SetField(ref _utilitiesElectricDescription, value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Gas [1097]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesGasDescription { get => _utilitiesGasDescription; set => SetField(ref _utilitiesGasDescription, value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Sewer [1099]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesSewerDescription { get => _utilitiesSewerDescription; set => SetField(ref _utilitiesSewerDescription, value); }

    /// <summary>
    /// Subject Property Legal Descr Utilities Water [1098]
    /// </summary>
    public StringEnumValue<UtilitiesDescription> UtilitiesWaterDescription { get => _utilitiesWaterDescription; set => SetField(ref _utilitiesWaterDescription, value); }

    /// <summary>
    /// VA Management Tool - Appraisal Sent Date [VASUMM.X73]
    /// </summary>
    public DateTime? VaAppraisalSentDate { get => _vaAppraisalSentDate; set => SetField(ref _vaAppraisalSentDate, value); }

    /// <summary>
    /// VA Do/Do Not Have VA Benefit-Related Indebtedness [VAVOB.X70]
    /// </summary>
    public StringEnumValue<VABenefitRelatedIndebtedness> VaBenefitRelatedIndebtedness { get => _vaBenefitRelatedIndebtedness; set => SetField(ref _vaBenefitRelatedIndebtedness, value); }

    /// <summary>
    /// VA Management Builder Description [3851]
    /// </summary>
    public string? VaBuilderDescription { get => _vaBuilderDescription; set => SetField(ref _vaBuilderDescription, value); }

    /// <summary>
    /// VA 261805 Builder ID Number [3348]
    /// </summary>
    public string? VaBuilderIdNo { get => _vaBuilderIdNo; set => SetField(ref _vaBuilderIdNo, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Cash-Out Refinance Type [VASUMM.X125]
    /// </summary>
    public StringEnumValue<VACashOutRefinanceType> VaCashOutRefinanceType { get => _vaCashOutRefinanceType; set => SetField(ref _vaCashOutRefinanceType, value); }

    /// <summary>
    /// VA Claim Folder # [VAVOB.X66]
    /// </summary>
    public string? VaClaimFolderNumber { get => _vaClaimFolderNumber; set => SetField(ref _vaClaimFolderNumber, value); }

    /// <summary>
    /// VA Claim # [VAELIG.X23]
    /// </summary>
    public string? VaClaimNumber { get => _vaClaimNumber; set => SetField(ref _vaClaimNumber, value); }

    /// <summary>
    /// VA Management Tool - Date NOV and Appraisal Mailed to Borrower [VASUMM.X77]
    /// </summary>
    public DateTime? VaDateNovAppraisalMailedToBorrower { get => _vaDateNovAppraisalMailedToBorrower; set => SetField(ref _vaDateNovAppraisalMailedToBorrower, value); }

    /// <summary>
    /// VA EEM Included in Base Loan Amount Indicator [VASUMM.X133]
    /// </summary>
    public bool? VaEemIncludedinBaseLoanAmountIndicator { get => _vaEemIncludedinBaseLoanAmountIndicator; set => SetField(ref _vaEemIncludedinBaseLoanAmountIndicator, value); }

    /// <summary>
    /// VA Energy Efficient Improvements Financed Amount [VASUMM.X132]
    /// </summary>
    public decimal? VaEnergyEfficientImprovementsFinancedAmount { get => _vaEnergyEfficientImprovementsFinancedAmount; set => SetField(ref _vaEnergyEfficientImprovementsFinancedAmount, value); }

    /// <summary>
    /// VA Financed Closing Costs to Exclude [VASUMM.X134]
    /// </summary>
    public decimal? VaFinancedClosingCostsToExcludeAmount { get => _vaFinancedClosingCostsToExcludeAmount; set => SetField(ref _vaFinancedClosingCostsToExcludeAmount, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Interest Rate Indicator [VASUMM.X118]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactInterestRateIndicator { get => _vaImpactInterestRateIndicator; set => SetField(ref _vaImpactInterestRateIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Loan Balance Indicator [VASUMM.X116]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactLoanBalanceIndicator { get => _vaImpactLoanBalanceIndicator; set => SetField(ref _vaImpactLoanBalanceIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact LTV Indicator [VASUMM.X120]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactLtvIndicator { get => _vaImpactLtvIndicator; set => SetField(ref _vaImpactLtvIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Remaining Equity Indicator [VASUMM.X121]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactRemainingEquityIndicator { get => _vaImpactRemainingEquityIndicator; set => SetField(ref _vaImpactRemainingEquityIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Remaining Term Indicator [VASUMM.X117]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactRemainingTermIndicator { get => _vaImpactRemainingTermIndicator; set => SetField(ref _vaImpactRemainingTermIndicator, value); }

    /// <summary>
    /// VA Management Tool - Cash-Out Refinance - Impact Scheduled Payments Indicator [VASUMM.X119]
    /// </summary>
    public StringEnumValue<IncreaseOrDecrease> VaImpactScheduledPaymentsIndicator { get => _vaImpactScheduledPaymentsIndicator; set => SetField(ref _vaImpactScheduledPaymentsIndicator, value); }

    /// <summary>
    /// VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan? [VASUMM.X36]
    /// </summary>
    public bool? VaIsDelinquent30Days { get => _vaIsDelinquent30Days; set => SetField(ref _vaIsDelinquent30Days, value); }

    /// <summary>
    /// VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months? [VASUMM.X30]
    /// </summary>
    public bool? VaLatePaymentIn6Months { get => _vaLatePaymentIn6Months; set => SetField(ref _vaLatePaymentIn6Months, value); }

    /// <summary>
    /// VaLoanDataContract VaLoanSummaryApplicantType
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> VaLoanSummaryApplicantType { get => _vaLoanSummaryApplicantType; set => SetField(ref _vaLoanSummaryApplicantType, value); }

    /// <summary>
    /// VA Management Tool - NOV Date Received [VASUMM.X74]
    /// </summary>
    public DateTime? VaNovDateReceived { get => _vaNovDateReceived; set => SetField(ref _vaNovDateReceived, value); }

    /// <summary>
    /// VA Management Tool - NOV Date Reviewed [VASUMM.X75]
    /// </summary>
    public DateTime? VaNovDateReviewed { get => _vaNovDateReviewed; set => SetField(ref _vaNovDateReviewed, value); }

    /// <summary>
    /// VA Management Tool - NOV Issued Date [VASUMM.X76]
    /// </summary>
    public DateTime? VaNovIssuedDate { get => _vaNovIssuedDate; set => SetField(ref _vaNovIssuedDate, value); }

    /// <summary>
    /// VA Management - Qualification - Original Amortization Type [VASUMM.X20]
    /// </summary>
    public StringEnumValue<AmortizationType> VaOriginalAmortizationType { get => _vaOriginalAmortizationType; set => SetField(ref _vaOriginalAmortizationType, value); }

    /// <summary>
    /// VA Management - Qualification - Original Monthly Payment [VASUMM.X19]
    /// </summary>
    public decimal? VaOriginalMonthlyPayment { get => _vaOriginalMonthlyPayment; set => SetField(ref _vaOriginalMonthlyPayment, value); }

    /// <summary>
    /// VA Management Tool - 2nd Tier Entitlement [VASUMM.X96]
    /// </summary>
    public string? VaQualification2ndTierEntitlement { get => _vaQualification2ndTierEntitlement; set => SetField(ref _vaQualification2ndTierEntitlement, value); }

    /// <summary>
    /// VA Management Tool - Country Region [VASUMM.X95]
    /// </summary>
    public StringEnumValue<VAQualificationCountryRegion> VaQualificationCountryRegion { get => _vaQualificationCountryRegion; set => SetField(ref _vaQualificationCountryRegion, value); }

    /// <summary>
    /// VA Management Tool - VA County Limits [VASUMM.X97]
    /// </summary>
    public decimal? VaQualificationCountyLimits { get => _vaQualificationCountyLimits; set => SetField(ref _vaQualificationCountyLimits, value); }

    /// <summary>
    /// VA Rate Reduced Solely by Discount Points Indicator [VASUMM.X131]
    /// </summary>
    public bool? VaRateReducedSolelybyDiscountPointsIndicator { get => _vaRateReducedSolelybyDiscountPointsIndicator; set => SetField(ref _vaRateReducedSolelybyDiscountPointsIndicator, value); }

    /// <summary>
    /// VA Management - Qualification - Recoup Closing Costs [VASUMM.X27]
    /// </summary>
    public int? VaRecoupmentClosingCosts { get => _vaRecoupmentClosingCosts; set => SetField(ref _vaRecoupmentClosingCosts, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids [VASUMM.X26]
    /// </summary>
    public bool? VaRecoupmentExcludePrepaids { get => _vaRecoupmentExcludePrepaids; set => SetField(ref _vaRecoupmentExcludePrepaids, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment [VASUMM.X22]
    /// </summary>
    public decimal? VaRecoupmentMonthlyDecreaseInPayment { get => _vaRecoupmentMonthlyDecreaseInPayment; set => SetField(ref _vaRecoupmentMonthlyDecreaseInPayment, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Months [VASUMM.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? VaRecoupmentMonths { get => _vaRecoupmentMonths; set => SetField(ref _vaRecoupmentMonths, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs [VASUMM.X25]
    /// </summary>
    public decimal? VaRecoupmentTotalClosingCosts { get => _vaRecoupmentTotalClosingCosts; set => SetField(ref _vaRecoupmentTotalClosingCosts, value); }

    /// <summary>
    /// VA Management - Qualification - Closing Cost Recoupment - Years [VASUMM.X28]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? VaRecoupmentYears { get => _vaRecoupmentYears; set => SetField(ref _vaRecoupmentYears, value); }

    /// <summary>
    /// VA Statutory Closing Costs [VASUMM.X127]
    /// </summary>
    public decimal? VaStatutoryClosingCosts { get => _vaStatutoryClosingCosts; set => SetField(ref _vaStatutoryClosingCosts, value); }

    /// <summary>
    /// VA Statutory P&amp;I Payment [VASUMM.X128]
    /// </summary>
    public decimal? VaStatutoryMonthlyPayment { get => _vaStatutoryMonthlyPayment; set => SetField(ref _vaStatutoryMonthlyPayment, value); }

    /// <summary>
    /// VA Statutory P&amp;I Reduction [VASUMM.X129]
    /// </summary>
    public decimal? VaStatutoryMonthlyReduction { get => _vaStatutoryMonthlyReduction; set => SetField(ref _vaStatutoryMonthlyReduction, value); }

    /// <summary>
    /// VA Statutory Recoupment Months [VASUMM.X130]
    /// </summary>
    public int? VaStatutoryRecoupmentMonths { get => _vaStatutoryRecoupmentMonths; set => SetField(ref _vaStatutoryRecoupmentMonths, value); }

    /// <summary>
    /// VA Management Tool - Cert. of Commitment Issued by VA [VASUMM.X86]
    /// </summary>
    public DateTime? VaTrackingCertOfCommitmentIssued { get => _vaTrackingCertOfCommitmentIssued; set => SetField(ref _vaTrackingCertOfCommitmentIssued, value); }

    /// <summary>
    /// VA Management Tool - COE Issue Date [VASUMM.X80]
    /// </summary>
    public DateTime? VaTrackingCoeIssueDate { get => _vaTrackingCoeIssueDate; set => SetField(ref _vaTrackingCoeIssueDate, value); }

    /// <summary>
    /// VA Management Tool - COE Issue History [VASUMM.X81]
    /// </summary>
    public string? VaTrackingCoeIssueHistory { get => _vaTrackingCoeIssueHistory; set => SetField(ref _vaTrackingCoeIssueHistory, value); }

    /// <summary>
    /// VA Management Tool - Final Approval Commitment Date [VASUMM.X88]
    /// </summary>
    public DateTime? VaTrackingFinalApprovalCommitmentDate { get => _vaTrackingFinalApprovalCommitmentDate; set => SetField(ref _vaTrackingFinalApprovalCommitmentDate, value); }

    /// <summary>
    /// VA Management Tool - GSA Exclusionary List Checked [VASUMM.X85]
    /// </summary>
    public bool? VaTrackingGsaExclusionaryListChecked { get => _vaTrackingGsaExclusionaryListChecked; set => SetField(ref _vaTrackingGsaExclusionaryListChecked, value); }

    /// <summary>
    /// VA Management Tool - Flood Policy [VASUMM.X91]
    /// </summary>
    public bool? VaTrackingInsuranceFloodPolicy { get => _vaTrackingInsuranceFloodPolicy; set => SetField(ref _vaTrackingInsuranceFloodPolicy, value); }

    /// <summary>
    /// VA Management Tool - Hazard Policy [VASUMM.X92]
    /// </summary>
    public bool? VaTrackingInsuranceHazardPolicy { get => _vaTrackingInsuranceHazardPolicy; set => SetField(ref _vaTrackingInsuranceHazardPolicy, value); }

    /// <summary>
    /// VA Management Tool - Wind/Hail Policy [VASUMM.X94]
    /// </summary>
    public bool? VaTrackingInsuranceWindOrHailPolicy { get => _vaTrackingInsuranceWindOrHailPolicy; set => SetField(ref _vaTrackingInsuranceWindOrHailPolicy, value); }

    /// <summary>
    /// VA Management Tool - Wood Destroying Policy [VASUMM.X93]
    /// </summary>
    public bool? VaTrackingInsuranceWoodDestroyingPolicy { get => _vaTrackingInsuranceWoodDestroyingPolicy; set => SetField(ref _vaTrackingInsuranceWoodDestroyingPolicy, value); }

    /// <summary>
    /// VA Management Tool - Is SAR LAPP Certified [VASUMM.X72]
    /// </summary>
    public bool? VaTrackingIsSarLappCertified { get => _vaTrackingIsSarLappCertified; set => SetField(ref _vaTrackingIsSarLappCertified, value); }

    /// <summary>
    /// VA Management Tool - Loan Guarantee Cert. (LGC) Receipt [VASUMM.X84]
    /// </summary>
    public DateTime? VaTrackingLoanGuaranteeCertReceipt { get => _vaTrackingLoanGuaranteeCertReceipt; set => SetField(ref _vaTrackingLoanGuaranteeCertReceipt, value); }

    /// <summary>
    /// VA Management Tool - VA Master Commitment Lock Expired [VASUMM.X87]
    /// </summary>
    public DateTime? VaTrackingMasterCommitmentLockExpired { get => _vaTrackingMasterCommitmentLockExpired; set => SetField(ref _vaTrackingMasterCommitmentLockExpired, value); }

    /// <summary>
    /// VA Management Tool - Ordered Date [VASUMM.X79]
    /// </summary>
    public DateTime? VaTrackingOrderedDate { get => _vaTrackingOrderedDate; set => SetField(ref _vaTrackingOrderedDate, value); }

    /// <summary>
    /// VA Management Tool - Paid Date [VASUMM.X82]
    /// </summary>
    public DateTime? VaTrackingPaidDate { get => _vaTrackingPaidDate; set => SetField(ref _vaTrackingPaidDate, value); }

    /// <summary>
    /// VA Management Tool - Purchase Contract Date [VASUMM.X89]
    /// </summary>
    public DateTime? VaTrackingPurchaseContractDate { get => _vaTrackingPurchaseContractDate; set => SetField(ref _vaTrackingPurchaseContractDate, value); }

    /// <summary>
    /// VA Management Tool - Receipt Received [VASUMM.X83]
    /// </summary>
    public bool? VaTrackingReceiptReceived { get => _vaTrackingReceiptReceived; set => SetField(ref _vaTrackingReceiptReceived, value); }

    /// <summary>
    /// VA Management Tool - SAR ID [VASUMM.X71]
    /// </summary>
    public string? VaTrackingSarId { get => _vaTrackingSarId; set => SetField(ref _vaTrackingSarId, value); }

    /// <summary>
    /// VA Management Tool - SAR Name [VASUMM.X70]
    /// </summary>
    public string? VaTrackingSarName { get => _vaTrackingSarName; set => SetField(ref _vaTrackingSarName, value); }

    /// <summary>
    /// VA Equipment Vent Fan [316]
    /// </summary>
    public bool? VentFanIndicator { get => _ventFanIndicator; set => SetField(ref _ventFanIndicator, value); }

    /// <summary>
    /// VA Discharged/Have Svc-Connected Disabilities [VAELIG.X22]
    /// </summary>
    public bool? VeteranDischargedIndicator { get => _veteranDischargedIndicator; set => SetField(ref _veteranDischargedIndicator, value); }

    /// <summary>
    /// VA Veteran Service Status [955]
    /// </summary>
    public StringEnumValue<VeteranServiceType> VeteranServiceType { get => _veteranServiceType; set => SetField(ref _veteranServiceType, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Addr [1026]
    /// </summary>
    public string? WarrantorAddress { get => _warrantorAddress; set => SetField(ref _warrantorAddress, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor City [GAPPR.X11]
    /// </summary>
    public string? WarrantorCity { get => _warrantorCity; set => SetField(ref _warrantorCity, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Name [1025]
    /// </summary>
    public string? WarrantorName { get => _warrantorName; set => SetField(ref _warrantorName, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Phone [1027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? WarrantorPhone { get => _warrantorPhone; set => SetField(ref _warrantorPhone, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor Zip [GAPPR.X13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? WarrantorPostalCode { get => _warrantorPostalCode; set => SetField(ref _warrantorPostalCode, value); }

    /// <summary>
    /// VA New/Prop Constr Warrantor State [GAPPR.X12]
    /// </summary>
    public string? WarrantorState { get => _warrantorState; set => SetField(ref _warrantorState, value); }

    /// <summary>
    /// Subject Property Warranty Program Expiration Date [725]
    /// </summary>
    public DateTime? WarrantyProgramExpirationDate { get => _warrantyProgramExpirationDate; set => SetField(ref _warrantyProgramExpirationDate, value); }

    /// <summary>
    /// VA Equipment W/W Carpet [318]
    /// </summary>
    public bool? WwCarpetIndicator { get => _wwCarpetIndicator; set => SetField(ref _wwCarpetIndicator, value); }
}