using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// VaLoanData
    /// </summary>
    public sealed partial class VaLoanData : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _acres;
        private DirtyValue<string> _additionalSecurityDescription;
        private DirtyValue<string> _administratorAddress;
        private DirtyValue<string> _administratorCity;
        private DirtyValue<string> _administratorContact;
        private DirtyValue<string> _administratorName;
        private DirtyValue<string> _administratorPostalCode;
        private DirtyValue<StringEnumValue<State>> _administratorState;
        private DirtyValue<int?> _ageOfProperty;
        private DirtyValue<decimal?> _amountSpentOnEnergyImprovements;
        private DirtyValue<StringEnumValue<AmountTypeWithheld>> _amountTypeWithheld;
        private DirtyValue<decimal?> _amountWithheld;
        private DirtyValue<decimal?> _annualGroundRent;
        private DirtyValue<decimal?> _annualMaintenanceAssessment;
        private DirtyValue<decimal?> _annualRealEstateTaxes;
        private DirtyValue<decimal?> _annualSpecialAssessment;
        private DirtyValue<string> _applicantAddressCity;
        private DirtyValue<string> _applicantAddressPostalCode;
        private DirtyValue<StringEnumValue<State>> _applicantAddressState;
        private DirtyValue<string> _applicantAddressStreetLine1;
        private DirtyValue<DateTime?> _applicantBirthDate;
        private DirtyValue<string> _applicantEmailAddressText;
        private DirtyValue<string> _applicantFirstNameWithMiddleName;
        private DirtyValue<string> _applicantHmdaGenderType;
        private DirtyValue<string> _applicantHomePhoneNumber;
        private DirtyValue<string> _applicantLastNameWithSuffix;
        private DirtyValue<string> _applicantTaxIdentificationIdentifier;
        private DirtyValue<StringEnumValue<VaLoanDataAppraisalType>> _appraisalType;
        private DirtyValue<bool?> _automaticProcedure;
        private DirtyValue<bool?> _availableForInspectionAMIndicator;
        private DirtyValue<string> _availableForInspectionDateAndTime;
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        private DirtyValue<StringEnumValue<BuildingType>> _buildingType;
        private DirtyValue<bool?> _buyerPurchasingLotSeparately;
        private DirtyValue<decimal?> _cashPaymentFromVeteran;
        private DirtyValue<StringEnumValue<ClaimDisabilityBenefits>> _claimDisabilityBenefits;
        private DirtyValue<bool?> _clothesWasherIndicator;
        private DirtyValue<DateTime?> _constructionCompletedDate;
        private DirtyValue<StringEnumValue<ConstructionPlan>> _constructionPlan;
        private DirtyValue<bool?> _constructionWarrantyIncluded;
        private DirtyValue<string> _contractNoApprovedByVA;
        private DirtyValue<int?> _creditScore;
        private DirtyValue<bool?> _currentlyOnMilitaryDuty;
        private DirtyValue<DateTime?> _dateAquiredLand;
        private DirtyValue<DateTime?> _dateOfAssignment;
        private DirtyValue<DateTime?> _dateSAR;
        private DirtyValue<decimal?> _disabilityAmountCollected;
        private DirtyValue<decimal?> _discountPercentage;
        private DirtyValue<decimal?> _discountPoint;
        private DirtyValue<bool?> _dishwasherIndicator;
        private DirtyValue<bool?> _dryerIndicator;
        private DirtyValue<string> _emailToBeNotifiedWhenUploaded;
        private DirtyValue<bool?> _energyImprovementsAdditionOfFeature;
        private DirtyValue<string> _entitlementCode;
        private DirtyValue<string> _equipmentOtherDescription;
        private DirtyValue<bool?> _excludeTaxesInsuranceIndicator;
        private DirtyValue<decimal?> _finalDiscountAmount;
        private DirtyValue<decimal?> _finalFundingFeeAmount;
        private DirtyValue<bool?> _firstChattelLoanType;
        private DirtyValue<bool?> _firstTimeUse;
        private DirtyValue<bool?> _fundingFeeExempt;
        private DirtyValue<bool?> _garbageDisposalIndicator;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _initialTotal;
        private DirtyValue<StringEnumValue<InspectionWillBeMadeBy>> _inspectionWillBeMadeBy;
        private DirtyValue<bool?> _insulation;
        private DirtyValue<StringEnumValue<InsuranceType>> _insuranceType;
        private DirtyValue<int?> _irregularLotSizeInSquareFeet;
        private DirtyValue<bool?> _isDelinquent30Days;
        private DirtyValue<string> _keysAtAddress;
        private DirtyValue<decimal?> _landPurchasePrice;
        private DirtyValue<StringEnumValue<LeaseholdType>> _leaseholdType;
        private DirtyValue<string> _lenderSAR;
        private DirtyValue<string> _loanAnalysisRemarks1;
        private DirtyValue<string> _loanAnalysisRemarks2;
        private DirtyValue<string> _loanAnalysisRemarks3;
        private DirtyValue<string> _loanAnalysisRemarks4;
        private DirtyValue<string> _loanAnalysisRemarks5;
        private DirtyValue<string> _loanAnalysisRemarks6;
        private DirtyValue<string> _loanAnalysisRemarks7;
        private DirtyValue<string> _loanAnalysisRemarks8;
        private DirtyValue<string> _loanAnalysisRemarks9;
        private DirtyValue<StringEnumValue<LoanCode>> _loanCode;
        private DirtyValue<StringEnumValue<LoanProcedure>> _loanProcedure;
        private DirtyValue<bool?> _loanProcessedUnderAU;
        private DirtyValue<string> _loanSummaryRemarks1;
        private DirtyValue<string> _loanSummaryRemarks2;
        private DirtyValue<string> _loanSummaryRemarks3;
        private DirtyValue<string> _loanSummaryRemarks4;
        private DirtyValue<string> _loanSummaryRemarks5;
        private DirtyValue<string> _loanSummaryRemarks6;
        private DirtyValue<string> _loanSummaryRemarks7;
        private DirtyValue<string> _loanSummaryRemarks8;
        private DirtyValue<string> _lotDimensions;
        private DirtyValue<string> _mailingAddress;
        private DirtyValue<string> _mailingCity;
        private DirtyValue<string> _mailingPostalCode;
        private DirtyValue<StringEnumValue<State>> _mailingState;
        private DirtyValue<StringEnumValue<ManufacturedHome>> _manufacturedHome;
        private DirtyValue<string> _mCRVNumber;
        private DirtyValue<StringEnumValue<MilitaryBranchOfService>> _militaryBranchOfService;
        private DirtyList<MilitaryService> _militaryServices;
        private DirtyValue<string> _mineralRightsReserved;
        private DirtyValue<string> _nameOfOccupant;
        private DirtyValue<string> _nameOfOwner;
        private DirtyValue<string> _nameOfWarrantyProgram;
        private DirtyValue<decimal?> _negativeRents;
        private DirtyValue<bool?> _noEnergyImprovements;
        private DirtyValue<string> _nonrealtyDescription;
        private DirtyValue<string> _numberOfBuildings;
        private DirtyValue<string> _occupantTelephone;
        private DirtyValue<bool?> _onMilitaryDutyFollowingSeparation;
        private DirtyValue<decimal?> _originalInterestRate;
        private DirtyValue<decimal?> _originalLoanAmount;
        private DirtyValue<int?> _originalTerm;
        private DirtyValue<bool?> _originalValueEstimateChanged;
        private DirtyValue<decimal?> _originationFeeAmount;
        private DirtyValue<decimal?> _otherClosingCosts;
        private DirtyValue<string> _otherDescriptionEstateProperty;
        private DirtyValue<string> _otherDescriptionLoanType;
        private DirtyValue<bool?> _otherEstateProperty;
        private DirtyValue<bool?> _otherImprovements;
        private DirtyValue<bool?> _otherLoanType;
        private DirtyValue<string> _paidInFullVALoanNumber;
        private DirtyValue<bool?> _payoffIndicator1;
        private DirtyValue<bool?> _payoffIndicator2;
        private DirtyValue<bool?> _payoffIndicator3;
        private DirtyValue<bool?> _payoffIndicator4;
        private DirtyValue<bool?> _payoffIndicator5;
        private DirtyValue<bool?> _payoffIndicator6;
        private DirtyValue<bool?> _payoffIndicator7;
        private DirtyValue<bool?> _payoffIndicator8;
        private DirtyValue<bool?> _payoffIndicator9;
        private DirtyValue<decimal?> _pestReportFee;
        private DirtyValue<string> _plansSubmitted;
        private DirtyValue<string> _pOCAddress;
        private DirtyValue<string> _pOCCity;
        private DirtyValue<string> _pOCName;
        private DirtyValue<string> _pOCPhone;
        private DirtyValue<StringEnumValue<State>> _pOCState;
        private DirtyValue<string> _pOCZipCode;
        private DirtyValue<decimal?> _preliminaryDiscountAmount;
        private DirtyValue<decimal?> _preliminaryFundingFeeAmount;
        private DirtyValue<decimal?> _preliminaryTotal;
        private DirtyValue<bool?> _previousVALoanIndicator;
        private DirtyList<PreviousVaLoan> _previousVaLoans;
        private DirtyValue<bool?> _priorApprovalProcedure;
        private DirtyValue<StringEnumValue<PriorLoanType>> _priorLoanType;
        private DirtyValue<StringEnumValue<PropertyDesignation>> _propertyDesignation;
        private DirtyValue<int?> _propertyGrossLivingArea;
        private DirtyValue<string> _propertyLegalDescription1;
        private DirtyValue<string> _propertyLegalDescription2;
        private DirtyValue<string> _propertyLegalDescription3;
        private DirtyValue<string> _propertyLegalDescription4;
        private DirtyValue<StringEnumValue<PropertyOccupancyType>> _propertyOccupancyType;
        private DirtyValue<bool?> _proposedSaleContractAttached;
        private DirtyValue<StringEnumValue<VaLoanDataPurposeOfLoan>> _purposeOfLoan;
        private DirtyValue<bool?> _rangeOvenIndicator;
        private DirtyValue<bool?> _reasonableValueCompleted;
        private DirtyValue<bool?> _refrigeratorIndicator;
        private DirtyValue<string> _rent;
        private DirtyValue<bool?> _replacementOfSystem;
        private DirtyValue<StringEnumValue<RiskClassification>> _riskClasification;
        private DirtyValue<string> _serviceNumber;
        private DirtyValue<bool?> _solarHeatingOrCooling;
        private DirtyValue<string> _specialAssessmentComments1;
        private DirtyValue<string> _specialAssessmentComments2;
        private DirtyValue<string> _specialAssessmentComments3;
        private DirtyValue<StringEnumValue<StreetAccess>> _streetAccess;
        private DirtyValue<StringEnumValue<StreetMaintenance>> _streetMaintenance;
        private DirtyValue<StringEnumValue<SystemUsed>> _systemUsed;
        private DirtyValue<string> _title;
        private DirtyValue<string> _titleLimitations1;
        private DirtyValue<string> _titleLimitations2;
        private DirtyValue<string> _titleLimitations3;
        private DirtyValue<decimal?> _totalBaths;
        private DirtyValue<int?> _totalBedrooms;
        private DirtyValue<decimal?> _totalDebtMonthlyPayment;
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        private DirtyValue<decimal?> _totalDiscountPointsCharged;
        private DirtyValue<decimal?> _totalForMaxLoanAmount;
        private DirtyValue<decimal?> _totalMonthlyPayment;
        private DirtyValue<decimal?> _totalProposedMonthlyPayment;
        private DirtyValue<int?> _totalRooms;
        private DirtyValue<decimal?> _totalUnpaidSpecialAssessments;
        private DirtyValue<StringEnumValue<TypeOfHybridARM>> _typeOfHybridARM;
        private DirtyValue<StringEnumValue<TypeOfMortgage>> _typeOfMortgage;
        private DirtyValue<StringEnumValue<TypeOfOwnsership>> _typeOfOwnsership;
        private DirtyValue<StringEnumValue<TypeOfStructure>> _typeOfStructure;
        private DirtyValue<StringEnumValue<TypeOfVeteran>> _typeOfVeteran;
        private DirtyValue<bool?> _unsecuredLoanType;
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesElectricDescription;
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesGasDescription;
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesSewerDescription;
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesWaterDescription;
        private DirtyValue<DateTime?> _vAAppraisalSentDate;
        private DirtyValue<StringEnumValue<VABenefitRelatedIndebtedness>> _vABenefitRelatedIndebtedness;
        private DirtyValue<string> _vABuilderDescription;
        private DirtyValue<string> _vABuilderIDNo;
        private DirtyValue<string> _vAClaimFolderNumber;
        private DirtyValue<string> _vAClaimNumber;
        private DirtyValue<DateTime?> _vADateNOVAppraisalMailedToBorrower;
        private DirtyValue<bool?> _vAIsDelinquent30Days;
        private DirtyValue<bool?> _vALatePaymentIn6Months;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _vaLoanSummaryApplicantType;
        private DirtyValue<DateTime?> _vANOVDateReceived;
        private DirtyValue<DateTime?> _vANOVDateReviewed;
        private DirtyValue<DateTime?> _vANOVIssuedDate;
        private DirtyValue<StringEnumValue<AmortizationType>> _vAOriginalAmortizationType;
        private DirtyValue<decimal?> _vAOriginalMonthlyPayment;
        private DirtyValue<string> _vAQualification2ndTierEntitlement;
        private DirtyValue<StringEnumValue<VAQualificationCountryRegion>> _vAQualificationCountryRegion;
        private DirtyValue<decimal?> _vAQualificationCountyLimits;
        private DirtyValue<int?> _vARecoupmentClosingCosts;
        private DirtyValue<bool?> _vARecoupmentExcludePrepaids;
        private DirtyValue<decimal?> _vARecoupmentMonthlyDecreaseInPayment;
        private DirtyValue<int?> _vARecoupmentMonths;
        private DirtyValue<decimal?> _vARecoupmentTotalClosingCosts;
        private DirtyValue<int?> _vARecoupmentYears;
        private DirtyValue<DateTime?> _vATrackingCertOfCommitmentIssued;
        private DirtyValue<DateTime?> _vATrackingCOEIssueDate;
        private DirtyValue<string> _vATrackingCOEIssueHistory;
        private DirtyValue<DateTime?> _vATrackingFinalApprovalCommitmentDate;
        private DirtyValue<bool?> _vATrackingGSAExclusionaryListChecked;
        private DirtyValue<bool?> _vATrackingInuranceFloodPolicy;
        private DirtyValue<bool?> _vATrackingInuranceHazardPolicy;
        private DirtyValue<bool?> _vATrackingInuranceWindOrHailPolicy;
        private DirtyValue<bool?> _vATrackingInuranceWoodDestroyingPolicy;
        private DirtyValue<bool?> _vATrackingIsSARLAPPCertified;
        private DirtyValue<DateTime?> _vATrackingLoanGuaranteeCertReceipt;
        private DirtyValue<DateTime?> _vATrackingMasterCommitmentLockExpired;
        private DirtyValue<DateTime?> _vATrackingOrderedDate;
        private DirtyValue<DateTime?> _vATrackingPaidDate;
        private DirtyValue<DateTime?> _vATrackingPurchaseContractDate;
        private DirtyValue<bool?> _vATrackingReceiptReceived;
        private DirtyValue<string> _vATrackingSARID;
        private DirtyValue<string> _vATrackingSARName;
        private DirtyValue<bool?> _ventFanIndicator;
        private DirtyValue<bool?> _veteranDischargedIndicator;
        private DirtyValue<StringEnumValue<VeteranServiceType>> _veteranServiceType;
        private DirtyValue<string> _warrantorAddress;
        private DirtyValue<string> _warrantorCity;
        private DirtyValue<string> _warrantorName;
        private DirtyValue<string> _warrantorPhone;
        private DirtyValue<string> _warrantorPostalCode;
        private DirtyValue<StringEnumValue<State>> _warrantorState;
        private DirtyValue<DateTime?> _warrantyProgramExpirationDate;
        private DirtyValue<bool?> _wWCarpetIndicator;

        /// <summary>
        /// Subject Property Legal DescAcres [600]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Legal DescAcres")]
        public decimal? Acres { get => _acres; set => SetField(ref _acres, value); }

        /// <summary>
        /// VA Loan Disbursement - Describe additional security taken and list of others (including spouse) [VASUMM.X62]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Describe additional security taken and list of others (including spouse)")]
        public string AdditionalSecurityDescription { get => _additionalSecurityDescription; set => SetField(ref _additionalSecurityDescription, value); }

        /// <summary>
        /// VA To Admin of Benefits Street [VAVOB.X3]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Street")]
        public string AdministratorAddress { get => _administratorAddress; set => SetField(ref _administratorAddress, value); }

        /// <summary>
        /// VA To Admin of Benefits City [VAVOB.X4]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits City")]
        public string AdministratorCity { get => _administratorCity; set => SetField(ref _administratorCity, value); }

        /// <summary>
        /// VA To Admin of Benefits Attn [VAVOB.X2]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Attn")]
        public string AdministratorContact { get => _administratorContact; set => SetField(ref _administratorContact, value); }

        /// <summary>
        /// VA To Admin of Benefits Name [VAVOB.X1]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Name")]
        public string AdministratorName { get => _administratorName; set => SetField(ref _administratorName, value); }

        /// <summary>
        /// VA To Admin of Benefits Zip [VAVOB.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA To Admin of Benefits Zip")]
        public string AdministratorPostalCode { get => _administratorPostalCode; set => SetField(ref _administratorPostalCode, value); }

        /// <summary>
        /// VA To Admin of Benefits State [VAVOB.X5]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits State")]
        public StringEnumValue<State> AdministratorState { get => _administratorState; set => SetField(ref _administratorState, value); }

        /// <summary>
        /// VA Loan Summ Property Age [VASUMM.X8]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Property Age")]
        public int? AgeOfProperty { get => _ageOfProperty; set => SetField(ref _ageOfProperty, value); }

        /// <summary>
        /// Subject Property Energy Improve Amt [961]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Energy Improve Amt")]
        public decimal? AmountSpentOnEnergyImprovements { get => _amountSpentOnEnergyImprovements; set => SetField(ref _amountSpentOnEnergyImprovements, value); }

        /// <summary>
        /// VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in [VASUMM.X65]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in")]
        public StringEnumValue<AmountTypeWithheld> AmountTypeWithheld { get => _amountTypeWithheld; set => SetField(ref _amountTypeWithheld, value); }

        /// <summary>
        /// VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in [VASUMM.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in")]
        public decimal? AmountWithheld { get => _amountWithheld; set => SetField(ref _amountWithheld, value); }

        /// <summary>
        /// VA Annual Ground Rent Amt [1035]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Annual Ground Rent Amt")]
        public decimal? AnnualGroundRent { get => _annualGroundRent; set => SetField(ref _annualGroundRent, value); }

        /// <summary>
        /// Annual Maintenance Assessment [3643]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Annual Maintenance Assessment")]
        public decimal? AnnualMaintenanceAssessment { get => _annualMaintenanceAssessment; set => SetField(ref _annualMaintenanceAssessment, value); }

        /// <summary>
        /// VA Annual RE Taxes [1031]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Annual RE Taxes")]
        public decimal? AnnualRealEstateTaxes { get => _annualRealEstateTaxes; set => SetField(ref _annualRealEstateTaxes, value); }

        /// <summary>
        /// VA Loan Disbursement - Annual Special Assessment [VASUMM.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Annual Special Assessment")]
        public decimal? AnnualSpecialAssessment { get => _annualSpecialAssessment; set => SetField(ref _annualSpecialAssessment, value); }

        /// <summary>
        /// VaLoanData ApplicantAddressCity [VAELIG.X76]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantAddressCity { get => _applicantAddressCity; set => SetField(ref _applicantAddressCity, value); }

        /// <summary>
        /// VaLoanData ApplicantAddressPostalCode [VAELIG.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
        public string ApplicantAddressPostalCode { get => _applicantAddressPostalCode; set => SetField(ref _applicantAddressPostalCode, value); }

        /// <summary>
        /// VaLoanData ApplicantAddressState [VAELIG.X77]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<State> ApplicantAddressState { get => _applicantAddressState; set => SetField(ref _applicantAddressState, value); }

        /// <summary>
        /// VaLoanData ApplicantAddressStreetLine1 [VAELIG.X75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantAddressStreetLine1 { get => _applicantAddressStreetLine1; set => SetField(ref _applicantAddressStreetLine1, value); }

        /// <summary>
        /// VaLoanData ApplicantBirthDate [VAELIG.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? ApplicantBirthDate { get => _applicantBirthDate; set => SetField(ref _applicantBirthDate, value); }

        /// <summary>
        /// VA Veteran Email Address [VAELIG.X97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Veteran Email Address")]
        public string ApplicantEmailAddressText { get => _applicantEmailAddressText; set => SetField(ref _applicantEmailAddressText, value); }

        /// <summary>
        /// VaLoanData ApplicantFirstNameWithMiddleName [VAELIG.X71]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantFirstNameWithMiddleName { get => _applicantFirstNameWithMiddleName; set => SetField(ref _applicantFirstNameWithMiddleName, value); }

        /// <summary>
        /// VA Loan Summ Veteran Sex [VASUMM.X35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Loan Summ Veteran Sex")]
        public string ApplicantHmdaGenderType { get => _applicantHmdaGenderType; set => SetField(ref _applicantHmdaGenderType, value); }

        /// <summary>
        /// VaLoanData ApplicantHomePhoneNumber
        /// </summary>
        public string ApplicantHomePhoneNumber { get => _applicantHomePhoneNumber; set => SetField(ref _applicantHomePhoneNumber, value); }

        /// <summary>
        /// VaLoanData ApplicantLastNameWithSuffix [VAELIG.X72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantLastNameWithSuffix { get => _applicantLastNameWithSuffix; set => SetField(ref _applicantLastNameWithSuffix, value); }

        /// <summary>
        /// VaLoanData ApplicantTaxIdentificationIdentifier [VAELIG.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
        public string ApplicantTaxIdentificationIdentifier { get => _applicantTaxIdentificationIdentifier; set => SetField(ref _applicantTaxIdentificationIdentifier, value); }

        /// <summary>
        /// Subject Property Appraisal Type [962]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Appraisal Type")]
        public StringEnumValue<VaLoanDataAppraisalType> AppraisalType { get => _appraisalType; set => SetField(ref _appraisalType, value); }

        /// <summary>
        /// VA Loan Disbursement - Automatic Procedure [VASUMM.X51]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Automatic Procedure")]
        public bool? AutomaticProcedure { get => _automaticProcedure; set => SetField(ref _automaticProcedure, value); }

        /// <summary>
        /// Subject Property Time Avail AM [686]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Time Avail AM")]
        public bool? AvailableForInspectionAMIndicator { get => _availableForInspectionAMIndicator; set => SetField(ref _availableForInspectionAMIndicator, value); }

        /// <summary>
        /// Subject Property Date/Time Avail for Inspec [681]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Date/Time Avail for Inspec")]
        public string AvailableForInspectionDateAndTime { get => _availableForInspectionDateAndTime; set => SetField(ref _availableForInspectionDateAndTime, value); }

        /// <summary>
        /// VA Loan Summ Disc Points Paid by Veteran Amt [VASUMM.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Disc Points Paid by Veteran Amt")]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => SetField(ref _borrowerPaidDiscountPointsTotalAmount, value); }

        /// <summary>
        /// Subject Property Building Type [602]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Building Type")]
        public StringEnumValue<BuildingType> BuildingType { get => _buildingType; set => SetField(ref _buildingType, value); }

        /// <summary>
        /// VA Buyer Purch Lot Separately [1344]
        /// </summary>
        [LoanFieldProperty(Description = "VA Buyer Purch Lot Separately", OptionsJson = "{\"true\":\"Buyer is purchasing lot separately\"}")]
        public bool? BuyerPurchasingLotSeparately { get => _buyerPurchasingLotSeparately; set => SetField(ref _buyerPurchasingLotSeparately, value); }

        /// <summary>
        /// VA Subtract Any Cash Payment from Veteran [VARRRWS.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Subtract Any Cash Payment from Veteran")]
        public decimal? CashPaymentFromVeteran { get => _cashPaymentFromVeteran; set => SetField(ref _cashPaymentFromVeteran, value); }

        /// <summary>
        /// VA Certifcation Filed Claim Prior to Discharge [VAVOB.X71]
        /// </summary>
        [LoanFieldProperty(Description = "VA Certifcation Filed Claim Prior to Discharge")]
        public StringEnumValue<ClaimDisabilityBenefits> ClaimDisabilityBenefits { get => _claimDisabilityBenefits; set => SetField(ref _claimDisabilityBenefits, value); }

        /// <summary>
        /// VA Equipment Clothes Washer [302]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Clothes Washer", OptionsJson = "{\"true\":\"Clothes / Washer\"}")]
        public bool? ClothesWasherIndicator { get => _clothesWasherIndicator; set => SetField(ref _clothesWasherIndicator, value); }

        /// <summary>
        /// Subject Property Constr Completed [726]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Constr Completed")]
        public DateTime? ConstructionCompletedDate { get => _constructionCompletedDate; set => SetField(ref _constructionCompletedDate, value); }

        /// <summary>
        /// VA New/Prop Constr Plan [1021]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Plan")]
        public StringEnumValue<ConstructionPlan> ConstructionPlan { get => _constructionPlan; set => SetField(ref _constructionPlan, value); }

        /// <summary>
        /// Subject Property Constr Warranty Incl [722]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Constr Warranty Incl", OptionsJson = "{\"true\":\"Construction Warranty Included\"}")]
        public bool? ConstructionWarrantyIncluded { get => _constructionWarrantyIncluded; set => SetField(ref _constructionWarrantyIncluded, value); }

        /// <summary>
        /// VA Contract # Approved By VA [1037]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Contract # Approved By VA")]
        public string ContractNoApprovedByVA { get => _contractNoApprovedByVA; set => SetField(ref _contractNoApprovedByVA, value); }

        /// <summary>
        /// VA Loan Summ Credit Score [VASUMM.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Credit Score")]
        public int? CreditScore { get => _creditScore; set => SetField(ref _creditScore, value); }

        /// <summary>
        /// VA Currently on Military Duty [VAVOB.X68]
        /// </summary>
        [LoanFieldProperty(Description = "VA Currently on Military Duty", OptionsJson = "{\"true\":\"Currently on military duty\"}")]
        public bool? CurrentlyOnMilitaryDuty { get => _currentlyOnMilitaryDuty; set => SetField(ref _currentlyOnMilitaryDuty, value); }

        /// <summary>
        /// VA Loan Disbursement - Date Aquired - If land aquired by separate transaction [VASUMM.X63]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Date Aquired - If land aquired by separate transaction")]
        public DateTime? DateAquiredLand { get => _dateAquiredLand; set => SetField(ref _dateAquiredLand, value); }

        /// <summary>
        /// VA Date of Assignment [415]
        /// </summary>
        [LoanFieldProperty(Description = "VA Date of Assignment")]
        public DateTime? DateOfAssignment { get => _dateOfAssignment; set => SetField(ref _dateOfAssignment, value); }

        /// <summary>
        /// VA Loan Summ Date SAR Issued Value [VASUMM.X9]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Date SAR Issued Value")]
        public DateTime? DateSAR { get => _dateSAR; set => SetField(ref _dateSAR, value); }

        /// <summary>
        /// VA Management Tool - Disability Amount Collected [VASUMM.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Disability Amount Collected")]
        public decimal? DisabilityAmountCollected { get => _disabilityAmountCollected; set => SetField(ref _disabilityAmountCollected, value); }

        /// <summary>
        /// VA Loan Discount Fee % [VARRRWS.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Discount Fee %")]
        public decimal? DiscountPercentage { get => _discountPercentage; set => SetField(ref _discountPercentage, value); }

        /// <summary>
        /// VA Loan Summ Disc Points Paid by Veteran % [VASUMM.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Disc Points Paid by Veteran %")]
        public decimal? DiscountPoint { get => _discountPoint; set => SetField(ref _discountPoint, value); }

        /// <summary>
        /// VA Equipment Dishwasher [301]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Dishwasher", OptionsJson = "{\"true\":\"Dish Washer\"}")]
        public bool? DishwasherIndicator { get => _dishwasherIndicator; set => SetField(ref _dishwasherIndicator, value); }

        /// <summary>
        /// VA Equipment Dryer [308]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Dryer", OptionsJson = "{\"true\":\"Dryer\"}")]
        public bool? DryerIndicator { get => _dryerIndicator; set => SetField(ref _dryerIndicator, value); }

        /// <summary>
        /// VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded) [3347]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded)")]
        public string EmailToBeNotifiedWhenUploaded { get => _emailToBeNotifiedWhenUploaded; set => SetField(ref _emailToBeNotifiedWhenUploaded, value); }

        /// <summary>
        /// VA Energy Improvements Addition of Feature [379]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Addition of Feature", OptionsJson = "{\"true\":\"Addition of Feature\"}")]
        public bool? EnergyImprovementsAdditionOfFeature { get => _energyImprovementsAdditionOfFeature; set => SetField(ref _energyImprovementsAdditionOfFeature, value); }

        /// <summary>
        /// VA Loan Summ Entitlement Code [VASUMM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Entitlement Code")]
        public string EntitlementCode { get => _entitlementCode; set => SetField(ref _entitlementCode, value); }

        /// <summary>
        /// VA Equipment Other [320]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Other")]
        public string EquipmentOtherDescription { get => _equipmentOtherDescription; set => SetField(ref _equipmentOtherDescription, value); }

        /// <summary>
        /// VA Management Tool - Exclude Taxes and Insurance [VASUMM.X100]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Exclude Taxes and Insurance")]
        public bool? ExcludeTaxesInsuranceIndicator { get => _excludeTaxesInsuranceIndicator; set => SetField(ref _excludeTaxesInsuranceIndicator, value); }

        /// <summary>
        /// VA Discount (Based from line 9) [VARRRWS.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Discount (Based from line 9)")]
        public decimal? FinalDiscountAmount { get => _finalDiscountAmount; set => SetField(ref _finalDiscountAmount, value); }

        /// <summary>
        /// VA Funding Fee (Round to Nearest Dollar) [VARRRWS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Funding Fee (Round to Nearest Dollar)")]
        public decimal? FinalFundingFeeAmount { get => _finalFundingFeeAmount; set => SetField(ref _finalFundingFeeAmount, value); }

        /// <summary>
        /// VA Loan Disbursement - Type of Loan - First Chattel  [VASUMM.X53]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - First Chattel ")]
        public bool? FirstChattelLoanType { get => _firstChattelLoanType; set => SetField(ref _firstChattelLoanType, value); }

        /// <summary>
        /// VA Loan Summ 1st Time Use VA Loan Program [VASUMM.X49]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ 1st Time Use VA Loan Program")]
        public bool? FirstTimeUse { get => _firstTimeUse; set => SetField(ref _firstTimeUse, value); }

        /// <summary>
        /// VA Loan Summ Discount Info [990]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Discount Info", OptionsJson = "{\"true\":\"Exempt\",\"false\":\"Not Exempt\"}")]
        public bool? FundingFeeExempt { get => _fundingFeeExempt; set => SetField(ref _fundingFeeExempt, value); }

        /// <summary>
        /// VA Equipment Garbage Disposal [309]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Garbage Disposal", OptionsJson = "{\"true\":\"Garbage Disposal\"}")]
        public bool? GarbageDisposalIndicator { get => _garbageDisposalIndicator; set => SetField(ref _garbageDisposalIndicator, value); }

        /// <summary>
        /// VaLoanData Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// VA Initial Computation Total [VARRRWS.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Initial Computation Total")]
        public decimal? InitialTotal { get => _initialTotal; set => SetField(ref _initialTotal, value); }

        /// <summary>
        /// VA New/Prop Constr Inspec By [1020]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Inspec By")]
        public StringEnumValue<InspectionWillBeMadeBy> InspectionWillBeMadeBy { get => _inspectionWillBeMadeBy; set => SetField(ref _inspectionWillBeMadeBy, value); }

        /// <summary>
        /// VA Energy Improvements Insulation [380]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Insulation", OptionsJson = "{\"true\":\"Insulation, Caulking\"}")]
        public bool? Insulation { get => _insulation; set => SetField(ref _insulation, value); }

        /// <summary>
        /// Insurance Type [3642]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Type")]
        public StringEnumValue<InsuranceType> InsuranceType { get => _insuranceType; set => SetField(ref _insuranceType, value); }

        /// <summary>
        /// Subject Property Irreg Sq Ft [1043]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Irreg Sq Ft")]
        public int? IrregularLotSizeInSquareFeet { get => _irregularLotSizeInSquareFeet; set => SetField(ref _irregularLotSizeInSquareFeet, value); }

        /// <summary>
        /// VaLoanData IsDelinquent30Days
        /// </summary>
        public bool? IsDelinquent30Days { get => _isDelinquent30Days; set => SetField(ref _isDelinquent30Days, value); }

        /// <summary>
        /// Subject Property Keys At [683]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Keys At")]
        public string KeysAtAddress { get => _keysAtAddress; set => SetField(ref _keysAtAddress, value); }

        /// <summary>
        /// VA Loan Disbursement - Land Purchase Price [VASUMM.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Land Purchase Price")]
        public decimal? LandPurchasePrice { get => _landPurchasePrice; set => SetField(ref _landPurchasePrice, value); }

        /// <summary>
        /// VA Lease Is [1033]
        /// </summary>
        [LoanFieldProperty(Description = "VA Lease Is")]
        public StringEnumValue<LeaseholdType> LeaseholdType { get => _leaseholdType; set => SetField(ref _leaseholdType, value); }

        /// <summary>
        /// VA Loan Summ Lender SAR ID [VASUMM.X6]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Lender SAR ID")]
        public string LenderSAR { get => _lenderSAR; set => SetField(ref _lenderSAR, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 1 [VALA.X10]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 1")]
        public string LoanAnalysisRemarks1 { get => _loanAnalysisRemarks1; set => SetField(ref _loanAnalysisRemarks1, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 2 [VALA.X11]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 2")]
        public string LoanAnalysisRemarks2 { get => _loanAnalysisRemarks2; set => SetField(ref _loanAnalysisRemarks2, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 3 [VALA.X12]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 3")]
        public string LoanAnalysisRemarks3 { get => _loanAnalysisRemarks3; set => SetField(ref _loanAnalysisRemarks3, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 4 [VALA.X13]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 4")]
        public string LoanAnalysisRemarks4 { get => _loanAnalysisRemarks4; set => SetField(ref _loanAnalysisRemarks4, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 5 [VALA.X14]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 5")]
        public string LoanAnalysisRemarks5 { get => _loanAnalysisRemarks5; set => SetField(ref _loanAnalysisRemarks5, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 6 [VALA.X15]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 6")]
        public string LoanAnalysisRemarks6 { get => _loanAnalysisRemarks6; set => SetField(ref _loanAnalysisRemarks6, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 7 [VALA.X16]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 7")]
        public string LoanAnalysisRemarks7 { get => _loanAnalysisRemarks7; set => SetField(ref _loanAnalysisRemarks7, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 8 [VALA.X17]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 8")]
        public string LoanAnalysisRemarks8 { get => _loanAnalysisRemarks8; set => SetField(ref _loanAnalysisRemarks8, value); }

        /// <summary>
        /// VA Loan Analysis Remarks 9 [VALA.X18]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 9")]
        public string LoanAnalysisRemarks9 { get => _loanAnalysisRemarks9; set => SetField(ref _loanAnalysisRemarks9, value); }

        /// <summary>
        /// VA Veteran Loan Code [958]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Code")]
        public StringEnumValue<LoanCode> LoanCode { get => _loanCode; set => SetField(ref _loanCode, value); }

        /// <summary>
        /// VA Veteran Loan Procedure [953]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Procedure")]
        public StringEnumValue<LoanProcedure> LoanProcedure { get => _loanProcedure; set => SetField(ref _loanProcedure, value); }

        /// <summary>
        /// VA Loan Summ VA Recognized Auto Underwriting Sys [VASUMM.X4]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ VA Recognized Auto Underwriting Sys")]
        public bool? LoanProcessedUnderAU { get => _loanProcessedUnderAU; set => SetField(ref _loanProcessedUnderAU, value); }

        /// <summary>
        /// VA Loan Summ Remarks 1 [VASUMM.X37]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 1")]
        public string LoanSummaryRemarks1 { get => _loanSummaryRemarks1; set => SetField(ref _loanSummaryRemarks1, value); }

        /// <summary>
        /// VA Loan Summ Remarks 2 [VASUMM.X38]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 2")]
        public string LoanSummaryRemarks2 { get => _loanSummaryRemarks2; set => SetField(ref _loanSummaryRemarks2, value); }

        /// <summary>
        /// VA Loan Summ Remarks 3 [VASUMM.X39]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 3")]
        public string LoanSummaryRemarks3 { get => _loanSummaryRemarks3; set => SetField(ref _loanSummaryRemarks3, value); }

        /// <summary>
        /// VA Loan Summ Remarks 4 [VASUMM.X40]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 4")]
        public string LoanSummaryRemarks4 { get => _loanSummaryRemarks4; set => SetField(ref _loanSummaryRemarks4, value); }

        /// <summary>
        /// VA Loan Summ Remarks 5 [VASUMM.X41]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 5")]
        public string LoanSummaryRemarks5 { get => _loanSummaryRemarks5; set => SetField(ref _loanSummaryRemarks5, value); }

        /// <summary>
        /// VA Loan Summ Remarks 6 [VASUMM.X42]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 6")]
        public string LoanSummaryRemarks6 { get => _loanSummaryRemarks6; set => SetField(ref _loanSummaryRemarks6, value); }

        /// <summary>
        /// VA Loan Summ Remarks 7 [VASUMM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 7")]
        public string LoanSummaryRemarks7 { get => _loanSummaryRemarks7; set => SetField(ref _loanSummaryRemarks7, value); }

        /// <summary>
        /// VA Loan Summ Remarks 8 [VASUMM.X44]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Loan Summ Remarks 8")]
        public string LoanSummaryRemarks8 { get => _loanSummaryRemarks8; set => SetField(ref _loanSummaryRemarks8, value); }

        /// <summary>
        /// Subject Property Lot Dimensions [1042]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Lot Dimensions")]
        public string LotDimensions { get => _lotDimensions; set => SetField(ref _lotDimensions, value); }

        /// <summary>
        /// VA Veteran Mailing Addr Street [VAELIG.X51]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mailing Addr Street")]
        public string MailingAddress { get => _mailingAddress; set => SetField(ref _mailingAddress, value); }

        /// <summary>
        /// VA Veteran Mailing Addr City [VAELIG.X54]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mailing Addr City")]
        public string MailingCity { get => _mailingCity; set => SetField(ref _mailingCity, value); }

        /// <summary>
        /// VA Veteran Mailing Addr Zip [VAELIG.X56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA Veteran Mailing Addr Zip")]
        public string MailingPostalCode { get => _mailingPostalCode; set => SetField(ref _mailingPostalCode, value); }

        /// <summary>
        /// VA Veteran Mailing Addr State [VAELIG.X55]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mailing Addr State")]
        public StringEnumValue<State> MailingState { get => _mailingState; set => SetField(ref _mailingState, value); }

        /// <summary>
        /// Subject Property Manufactured Home [963]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Manufactured Home")]
        public StringEnumValue<ManufacturedHome> ManufacturedHome { get => _manufacturedHome; set => SetField(ref _manufacturedHome, value); }

        /// <summary>
        /// Subject Property Energy Improve MCRV # [989]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve MCRV #")]
        public string MCRVNumber { get => _mCRVNumber; set => SetField(ref _mCRVNumber, value); }

        /// <summary>
        /// VA Veteran Branch of Service [954]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Branch of Service")]
        public StringEnumValue<MilitaryBranchOfService> MilitaryBranchOfService { get => _militaryBranchOfService; set => SetField(ref _militaryBranchOfService, value); }

        /// <summary>
        /// VaLoanData MilitaryServices
        /// </summary>
        public IList<MilitaryService> MilitaryServices { get => GetField(ref _militaryServices); set => SetField(ref _militaryServices, value); }

        /// <summary>
        /// VA Mineral Rights Reserved [1032]
        /// </summary>
        [LoanFieldProperty(Description = "VA Mineral Rights Reserved")]
        public string MineralRightsReserved { get => _mineralRightsReserved; set => SetField(ref _mineralRightsReserved, value); }

        /// <summary>
        /// Subject Property Occupant Name [730]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Occupant Name")]
        public string NameOfOccupant { get => _nameOfOccupant; set => SetField(ref _nameOfOccupant, value); }

        /// <summary>
        /// Subject Property Owner Name [727]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Owner Name")]
        public string NameOfOwner { get => _nameOfOwner; set => SetField(ref _nameOfOwner, value); }

        /// <summary>
        /// Subject Property Warranty Program Name [724]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Warranty Program Name")]
        public string NameOfWarrantyProgram { get => _nameOfWarrantyProgram; set => SetField(ref _nameOfWarrantyProgram, value); }

        /// <summary>
        /// VA Loan Analysis Negative Rents [VALA.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Analysis Negative Rents")]
        public decimal? NegativeRents { get => _negativeRents; set => SetField(ref _negativeRents, value); }

        /// <summary>
        /// VA Energy Improvements None [376]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements None", OptionsJson = "{\"true\":\"None\"}")]
        public bool? NoEnergyImprovements { get => _noEnergyImprovements; set => SetField(ref _noEnergyImprovements, value); }

        /// <summary>
        /// VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan [VASUMM.X61]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan")]
        public string NonrealtyDescription { get => _nonrealtyDescription; set => SetField(ref _nonrealtyDescription, value); }

        /// <summary>
        /// Subject Property # Buildings [604]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property # Buildings")]
        public string NumberOfBuildings { get => _numberOfBuildings; set => SetField(ref _numberOfBuildings, value); }

        /// <summary>
        /// Subject Property Occupant Phone [731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Subject Property Occupant Phone")]
        public string OccupantTelephone { get => _occupantTelephone; set => SetField(ref _occupantTelephone, value); }

        /// <summary>
        /// VA On Military Duty Day Following Separation [VAVOB.X69]
        /// </summary>
        [LoanFieldProperty(Description = "VA On Military Duty Day Following Separation", OptionsJson = "{\"true\":\"On military duty on the day following separation\"}")]
        public bool? OnMilitaryDutyFollowingSeparation { get => _onMilitaryDutyFollowingSeparation; set => SetField(ref _onMilitaryDutyFollowingSeparation, value); }

        /// <summary>
        /// VA Loan Summ Orig Int Rate [VASUMM.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Orig Int Rate")]
        public decimal? OriginalInterestRate { get => _originalInterestRate; set => SetField(ref _originalInterestRate, value); }

        /// <summary>
        /// VA Loan Summ Orig Loan Amt [VASUMM.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Orig Loan Amt")]
        public decimal? OriginalLoanAmount { get => _originalLoanAmount; set => SetField(ref _originalLoanAmount, value); }

        /// <summary>
        /// VA Loan Summ Orig Term [VASUMM.X18]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Orig Term")]
        public int? OriginalTerm { get => _originalTerm; set => SetField(ref _originalTerm, value); }

        /// <summary>
        /// VA Loan Summ Y/N Appraisers Orig Value Est Changed [VASUMM.X13]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Y/N Appraisers Orig Value Est Changed")]
        public bool? OriginalValueEstimateChanged { get => _originalValueEstimateChanged; set => SetField(ref _originalValueEstimateChanged, value); }

        /// <summary>
        /// VA Origination Fee [VARRRWS.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Origination Fee")]
        public decimal? OriginationFeeAmount { get => _originationFeeAmount; set => SetField(ref _originationFeeAmount, value); }

        /// <summary>
        /// VA Add Other Allowable Closing Costs/Prepaids [VARRRWS.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Add Other Allowable Closing Costs/Prepaids")]
        public decimal? OtherClosingCosts { get => _otherClosingCosts; set => SetField(ref _otherClosingCosts, value); }

        /// <summary>
        /// VA Loan Disbursement - Estate in Property - Other Description [VASUMM.X58]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Estate in Property - Other Description")]
        public string OtherDescriptionEstateProperty { get => _otherDescriptionEstateProperty; set => SetField(ref _otherDescriptionEstateProperty, value); }

        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Other Description [VASUMM.X56]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Other Description")]
        public string OtherDescriptionLoanType { get => _otherDescriptionLoanType; set => SetField(ref _otherDescriptionLoanType, value); }

        /// <summary>
        /// VA Loan Disbursement - Estate in Property - Other [VASUMM.X57]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Estate in Property - Other")]
        public bool? OtherEstateProperty { get => _otherEstateProperty; set => SetField(ref _otherEstateProperty, value); }

        /// <summary>
        /// VA Other Improvements [381]
        /// </summary>
        [LoanFieldProperty(Description = "VA Other Improvements", OptionsJson = "{\"true\":\"Other Improvements\"}")]
        public bool? OtherImprovements { get => _otherImprovements; set => SetField(ref _otherImprovements, value); }

        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Other [VASUMM.X55]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Other")]
        public bool? OtherLoanType { get => _otherLoanType; set => SetField(ref _otherLoanType, value); }

        /// <summary>
        /// VA Loan Summ Paid In Full Loan # [VASUMM.X14]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Paid In Full Loan #")]
        public string PaidInFullVALoanNumber { get => _paidInFullVALoanNumber; set => SetField(ref _paidInFullVALoanNumber, value); }

        /// <summary>
        /// VA Loan Analysis Liability 1 Incl on Line 41 [VALA.X20]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 1 Incl on Line 41")]
        public bool? PayoffIndicator1 { get => _payoffIndicator1; set => SetField(ref _payoffIndicator1, value); }

        /// <summary>
        /// VA Loan Analysis Liability 2 Incl on Line 41 [VALA.X21]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 2 Incl on Line 41")]
        public bool? PayoffIndicator2 { get => _payoffIndicator2; set => SetField(ref _payoffIndicator2, value); }

        /// <summary>
        /// VA Loan Analysis Liability 3 Incl on Line 41 [VALA.X22]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 3 Incl on Line 41")]
        public bool? PayoffIndicator3 { get => _payoffIndicator3; set => SetField(ref _payoffIndicator3, value); }

        /// <summary>
        /// VA Loan Analysis Liability 4 Incl on Line 41 [VALA.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 4 Incl on Line 41")]
        public bool? PayoffIndicator4 { get => _payoffIndicator4; set => SetField(ref _payoffIndicator4, value); }

        /// <summary>
        /// VA Loan Analysis Liability 5 Incl on Line 41 [VALA.X24]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 5 Incl on Line 41")]
        public bool? PayoffIndicator5 { get => _payoffIndicator5; set => SetField(ref _payoffIndicator5, value); }

        /// <summary>
        /// VA Loan Analysis Liability 6 Incl on Line 41 [VALA.X25]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 6 Incl on Line 41")]
        public bool? PayoffIndicator6 { get => _payoffIndicator6; set => SetField(ref _payoffIndicator6, value); }

        /// <summary>
        /// VA Loan Analysis Liability 7 Incl on Line 41 [VALA.X26]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 7 Incl on Line 41")]
        public bool? PayoffIndicator7 { get => _payoffIndicator7; set => SetField(ref _payoffIndicator7, value); }

        /// <summary>
        /// VA Loan Analysis Alimony/Child Supp Incl on Line 41 [VALA.X27]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Alimony/Child Supp Incl on Line 41")]
        public bool? PayoffIndicator8 { get => _payoffIndicator8; set => SetField(ref _payoffIndicator8, value); }

        /// <summary>
        /// VA Loan Analysis Other Liabilities Incl on Line 41 [VALA.X28]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Other Liabilities Incl on Line 41")]
        public bool? PayoffIndicator9 { get => _payoffIndicator9; set => SetField(ref _payoffIndicator9, value); }

        /// <summary>
        /// VA Management Tool - Pest Report Fee [VASUMM.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Pest Report Fee")]
        public decimal? PestReportFee { get => _pestReportFee; set => SetField(ref _pestReportFee, value); }

        /// <summary>
        /// VA New/Prop Constr Plan Prev Case # [1022]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Plan Prev Case #")]
        public string PlansSubmitted { get => _plansSubmitted; set => SetField(ref _plansSubmitted, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Address [3350]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information Address")]
        public string POCAddress { get => _pOCAddress; set => SetField(ref _pOCAddress, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information City [3351]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information City")]
        public string POCCity { get => _pOCCity; set => SetField(ref _pOCCity, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Name [3349]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information Name")]
        public string POCName { get => _pOCName; set => SetField(ref _pOCName, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Phone [3354]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "VA 261805 Applicable Point of Contact (POC) Information Phone")]
        public string POCPhone { get => _pOCPhone; set => SetField(ref _pOCPhone, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information State [3352]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information State")]
        public StringEnumValue<State> POCState { get => _pOCState; set => SetField(ref _pOCState, value); }

        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Zipcode [3353]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA 261805 Applicable Point of Contact (POC) Information Zipcode")]
        public string POCZipCode { get => _pOCZipCode; set => SetField(ref _pOCZipCode, value); }

        /// <summary>
        /// VA Discount Amt [VARRRWS.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Discount Amt")]
        public decimal? PreliminaryDiscountAmount { get => _preliminaryDiscountAmount; set => SetField(ref _preliminaryDiscountAmount, value); }

        /// <summary>
        /// VA Funding Fee [VARRRWS.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Funding Fee")]
        public decimal? PreliminaryFundingFeeAmount { get => _preliminaryFundingFeeAmount; set => SetField(ref _preliminaryFundingFeeAmount, value); }

        /// <summary>
        /// VA Preliminary Loan Amt Total [VARRRWS.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Preliminary Loan Amt Total")]
        public decimal? PreliminaryTotal { get => _preliminaryTotal; set => SetField(ref _preliminaryTotal, value); }

        /// <summary>
        /// VA Military Previous VA Loan Not Applicable (NA) [VAELIG.X113]
        /// </summary>
        [LoanFieldProperty(Description = "VA Military Previous VA Loan Not Applicable (NA)")]
        public bool? PreviousVALoanIndicator { get => _previousVALoanIndicator; set => SetField(ref _previousVALoanIndicator, value); }

        /// <summary>
        /// VaLoanData PreviousVaLoans
        /// </summary>
        public IList<PreviousVaLoan> PreviousVaLoans { get => GetField(ref _previousVaLoans); set => SetField(ref _previousVaLoans, value); }

        /// <summary>
        /// VA Loan Disbursement - Prior Approval Procedure [VASUMM.X52]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Prior Approval Procedure")]
        public bool? PriorApprovalProcedure { get => _priorApprovalProcedure; set => SetField(ref _priorApprovalProcedure, value); }

        /// <summary>
        /// VA Loan Summ Prior Loan Type [VASUMM.X50]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Prior Loan Type")]
        public StringEnumValue<PriorLoanType> PriorLoanType { get => _priorLoanType; set => SetField(ref _priorLoanType, value); }

        /// <summary>
        /// Subject Property Energy Improve Property Desig [988]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve Property Desig")]
        public StringEnumValue<PropertyDesignation> PropertyDesignation { get => _propertyDesignation; set => SetField(ref _propertyDesignation, value); }

        /// <summary>
        /// VA Loan Summ Property Gross Living Area [VASUMM.X7]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Property Gross Living Area")]
        public int? PropertyGrossLivingArea { get => _propertyGrossLivingArea; set => SetField(ref _propertyGrossLivingArea, value); }

        /// <summary>
        /// Subject Property Legal Descr 1 [765]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 1")]
        public string PropertyLegalDescription1 { get => _propertyLegalDescription1; set => SetField(ref _propertyLegalDescription1, value); }

        /// <summary>
        /// Subject Property Legal Descr 2 [766]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 2")]
        public string PropertyLegalDescription2 { get => _propertyLegalDescription2; set => SetField(ref _propertyLegalDescription2, value); }

        /// <summary>
        /// Subject Property Legal Descr 3 [797]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 3")]
        public string PropertyLegalDescription3 { get => _propertyLegalDescription3; set => SetField(ref _propertyLegalDescription3, value); }

        /// <summary>
        /// Subject Property Legal Descr 4 [798]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 4")]
        public string PropertyLegalDescription4 { get => _propertyLegalDescription4; set => SetField(ref _propertyLegalDescription4, value); }

        /// <summary>
        /// Subject Property Type [728]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Type")]
        public StringEnumValue<PropertyOccupancyType> PropertyOccupancyType { get => _propertyOccupancyType; set => SetField(ref _propertyOccupancyType, value); }

        /// <summary>
        /// VA Proposed Sale Contract Attached [1036]
        /// </summary>
        [LoanFieldProperty(Description = "VA Proposed Sale Contract Attached", OptionsJson = "{\"true\":\"Proposed sale contract attached\"}")]
        public bool? ProposedSaleContractAttached { get => _proposedSaleContractAttached; set => SetField(ref _proposedSaleContractAttached, value); }

        /// <summary>
        /// VA Veteran Loan Purpose [956]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Purpose")]
        public StringEnumValue<VaLoanDataPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => SetField(ref _purposeOfLoan, value); }

        /// <summary>
        /// VA Equipment Range Oven [204]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Range Oven", OptionsJson = "{\"true\":\"Range / Oven\"}")]
        public bool? RangeOvenIndicator { get => _rangeOvenIndicator; set => SetField(ref _rangeOvenIndicator, value); }

        /// <summary>
        /// VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value [VASUMM.X67]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value")]
        public bool? ReasonableValueCompleted { get => _reasonableValueCompleted; set => SetField(ref _reasonableValueCompleted, value); }

        /// <summary>
        /// VA Equipment Refrigerator [209]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Refrigerator", OptionsJson = "{\"true\":\"Refrigerator\"}")]
        public bool? RefrigeratorIndicator { get => _refrigeratorIndicator; set => SetField(ref _refrigeratorIndicator, value); }

        /// <summary>
        /// Subject Property Rent [729]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Rent")]
        public string Rent { get => _rent; set => SetField(ref _rent, value); }

        /// <summary>
        /// VA Energy Improvements Replacement of System [378]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Replacement of System", OptionsJson = "{\"true\":\"Replacement of System\"}")]
        public bool? ReplacementOfSystem { get => _replacementOfSystem; set => SetField(ref _replacementOfSystem, value); }

        /// <summary>
        /// VA Loan Summ Risk Classification [VASUMM.X21]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Risk Classification")]
        public StringEnumValue<RiskClassification> RiskClasification { get => _riskClasification; set => SetField(ref _riskClasification, value); }

        /// <summary>
        /// VA Svc # [VAVOB.X67]
        /// </summary>
        [LoanFieldProperty(Description = "VA Svc #")]
        public string ServiceNumber { get => _serviceNumber; set => SetField(ref _serviceNumber, value); }

        /// <summary>
        /// Fees Survey to Seller [377]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Survey to Seller", OptionsJson = "{\"true\":\"Solar Heating / Cooling\"}")]
        public bool? SolarHeatingOrCooling { get => _solarHeatingOrCooling; set => SetField(ref _solarHeatingOrCooling, value); }

        /// <summary>
        /// VA Special Assess/HOA Charges Comments 1 [1028]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 1")]
        public string SpecialAssessmentComments1 { get => _specialAssessmentComments1; set => SetField(ref _specialAssessmentComments1, value); }

        /// <summary>
        /// VA Special Assess/HOA Charges Comments 2 [1029]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 2")]
        public string SpecialAssessmentComments2 { get => _specialAssessmentComments2; set => SetField(ref _specialAssessmentComments2, value); }

        /// <summary>
        /// VA Special Assess/HOA Charges Comments 3 [1030]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 3")]
        public string SpecialAssessmentComments3 { get => _specialAssessmentComments3; set => SetField(ref _specialAssessmentComments3, value); }

        /// <summary>
        /// Subject Property Street Access [720]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street Access")]
        public StringEnumValue<StreetAccess> StreetAccess { get => _streetAccess; set => SetField(ref _streetAccess, value); }

        /// <summary>
        /// Subject Property Street Maint [721]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street Maint")]
        public StringEnumValue<StreetMaintenance> StreetMaintenance { get => _streetMaintenance; set => SetField(ref _streetMaintenance, value); }

        /// <summary>
        /// VA Loan Summ Underwriting System Used [VASUMM.X17]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Underwriting System Used")]
        public StringEnumValue<SystemUsed> SystemUsed { get => _systemUsed; set => SetField(ref _systemUsed, value); }

        /// <summary>
        /// VA New/Prop Constr Title [GAPPR.X5]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Title")]
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// Subject Property Title Limitations 1 [926]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 1")]
        public string TitleLimitations1 { get => _titleLimitations1; set => SetField(ref _titleLimitations1, value); }

        /// <summary>
        /// Subject Property Title Limitations 2 [927]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 2")]
        public string TitleLimitations2 { get => _titleLimitations2; set => SetField(ref _titleLimitations2, value); }

        /// <summary>
        /// Subject Property Title Limitations 3 [928]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 3")]
        public string TitleLimitations3 { get => _titleLimitations3; set => SetField(ref _titleLimitations3, value); }

        /// <summary>
        /// VA Loan Summ Baths [VASUMM.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Baths")]
        public decimal? TotalBaths { get => _totalBaths; set => SetField(ref _totalBaths, value); }

        /// <summary>
        /// VA Loan Summ Bedrooms [VASUMM.X12]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Bedrooms")]
        public int? TotalBedrooms { get => _totalBedrooms; set => SetField(ref _totalBedrooms, value); }

        /// <summary>
        /// VA Loan Analysis Total Debt Mo Pymt [VALA.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Loan Analysis Total Debt Mo Pymt")]
        public decimal? TotalDebtMonthlyPayment { get => _totalDebtMonthlyPayment; set => SetField(ref _totalDebtMonthlyPayment, value); }

        /// <summary>
        /// VA Loan Summ Total Disc Points Chrgd Amt [VASUMM.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Total Disc Points Chrgd Amt")]
        public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => SetField(ref _totalDiscountPointCharged, value); }

        /// <summary>
        /// VA Loan Summ Total Disc Points Chrgd % [VASUMM.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Total Disc Points Chrgd %")]
        public decimal? TotalDiscountPointsCharged { get => _totalDiscountPointsCharged; set => SetField(ref _totalDiscountPointsCharged, value); }

        /// <summary>
        /// VA Total - Max Loan Amt [VARRRWS.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Total - Max Loan Amt")]
        public decimal? TotalForMaxLoanAmount { get => _totalForMaxLoanAmount; set => SetField(ref _totalForMaxLoanAmount, value); }

        /// <summary>
        /// VA Management Tool - Total Monthly Payment [VASUMM.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Total Monthly Payment")]
        public decimal? TotalMonthlyPayment { get => _totalMonthlyPayment; set => SetField(ref _totalMonthlyPayment, value); }

        /// <summary>
        /// VA Management Tool - Total Proposed Monthly Payment [VASUMM.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Total Proposed Monthly Payment")]
        public decimal? TotalProposedMonthlyPayment { get => _totalProposedMonthlyPayment; set => SetField(ref _totalProposedMonthlyPayment, value); }

        /// <summary>
        /// VA Loan Summ Total Rooms [VASUMM.X10]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Total Rooms")]
        public int? TotalRooms { get => _totalRooms; set => SetField(ref _totalRooms, value); }

        /// <summary>
        /// VA Loan Disbursement - Total Unpaid Special Assessments [VASUMM.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Total Unpaid Special Assessments")]
        public decimal? TotalUnpaidSpecialAssessments { get => _totalUnpaidSpecialAssessments; set => SetField(ref _totalUnpaidSpecialAssessments, value); }

        /// <summary>
        /// VA Loan Summ HYBRID-ARM Type [VASUMM.X24]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ HYBRID-ARM Type")]
        public StringEnumValue<TypeOfHybridARM> TypeOfHybridARM { get => _typeOfHybridARM; set => SetField(ref _typeOfHybridARM, value); }

        /// <summary>
        /// VA Veteran Mtg Type [959]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mtg Type")]
        public StringEnumValue<TypeOfMortgage> TypeOfMortgage { get => _typeOfMortgage; set => SetField(ref _typeOfMortgage, value); }

        /// <summary>
        /// VA Veteran Ownership Type [957]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Ownership Type")]
        public StringEnumValue<TypeOfOwnsership> TypeOfOwnsership { get => _typeOfOwnsership; set => SetField(ref _typeOfOwnsership, value); }

        /// <summary>
        /// Subject Property Energy Improve Structure Type [986]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve Structure Type")]
        public StringEnumValue<TypeOfStructure> TypeOfStructure { get => _typeOfStructure; set => SetField(ref _typeOfStructure, value); }

        /// <summary>
        /// VA Veteran Type [VAVOB.X72]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Type")]
        public StringEnumValue<TypeOfVeteran> TypeOfVeteran { get => _typeOfVeteran; set => SetField(ref _typeOfVeteran, value); }

        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Unsecured  [VASUMM.X54]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Unsecured ")]
        public bool? UnsecuredLoanType { get => _unsecuredLoanType; set => SetField(ref _unsecuredLoanType, value); }

        /// <summary>
        /// Subject Property Legal Descr Utilities Elec [1096]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Elec")]
        public StringEnumValue<UtilitiesDescription> UtilitiesElectricDescription { get => _utilitiesElectricDescription; set => SetField(ref _utilitiesElectricDescription, value); }

        /// <summary>
        /// Subject Property Legal Descr Utilities Gas [1097]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Gas")]
        public StringEnumValue<UtilitiesDescription> UtilitiesGasDescription { get => _utilitiesGasDescription; set => SetField(ref _utilitiesGasDescription, value); }

        /// <summary>
        /// Subject Property Legal Descr Utilities Sewer [1099]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Sewer")]
        public StringEnumValue<UtilitiesDescription> UtilitiesSewerDescription { get => _utilitiesSewerDescription; set => SetField(ref _utilitiesSewerDescription, value); }

        /// <summary>
        /// Subject Property Legal Descr Utilities Water [1098]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Water")]
        public StringEnumValue<UtilitiesDescription> UtilitiesWaterDescription { get => _utilitiesWaterDescription; set => SetField(ref _utilitiesWaterDescription, value); }

        /// <summary>
        /// VA Management Tool - Appraisal Sent Date [VASUMM.X73]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Appraisal Sent Date")]
        public DateTime? VAAppraisalSentDate { get => _vAAppraisalSentDate; set => SetField(ref _vAAppraisalSentDate, value); }

        /// <summary>
        /// VA Do/Do Not Have VA Benefit-Related Indebtedness [VAVOB.X70]
        /// </summary>
        [LoanFieldProperty(Description = "VA Do/Do Not Have VA Benefit-Related Indebtedness")]
        public StringEnumValue<VABenefitRelatedIndebtedness> VABenefitRelatedIndebtedness { get => _vABenefitRelatedIndebtedness; set => SetField(ref _vABenefitRelatedIndebtedness, value); }

        /// <summary>
        /// VA Management Builder Description [3851]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Builder Description")]
        public string VABuilderDescription { get => _vABuilderDescription; set => SetField(ref _vABuilderDescription, value); }

        /// <summary>
        /// VA 261805 Builder ID Number [3348]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Builder ID Number")]
        public string VABuilderIDNo { get => _vABuilderIDNo; set => SetField(ref _vABuilderIDNo, value); }

        /// <summary>
        /// VA Claim Folder # [VAVOB.X66]
        /// </summary>
        [LoanFieldProperty(Description = "VA Claim Folder #")]
        public string VAClaimFolderNumber { get => _vAClaimFolderNumber; set => SetField(ref _vAClaimFolderNumber, value); }

        /// <summary>
        /// VA Claim # [VAELIG.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Claim #")]
        public string VAClaimNumber { get => _vAClaimNumber; set => SetField(ref _vAClaimNumber, value); }

        /// <summary>
        /// VA Management Tool - Date NOV and Appraisal Mailed to Borrower [VASUMM.X77]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Date NOV and Appraisal Mailed to Borrower")]
        public DateTime? VADateNOVAppraisalMailedToBorrower { get => _vADateNOVAppraisalMailedToBorrower; set => SetField(ref _vADateNOVAppraisalMailedToBorrower, value); }

        /// <summary>
        /// VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan? [VASUMM.X36]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan?")]
        public bool? VAIsDelinquent30Days { get => _vAIsDelinquent30Days; set => SetField(ref _vAIsDelinquent30Days, value); }

        /// <summary>
        /// VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months? [VASUMM.X30]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months?")]
        public bool? VALatePaymentIn6Months { get => _vALatePaymentIn6Months; set => SetField(ref _vALatePaymentIn6Months, value); }

        /// <summary>
        /// VaLoanData VaLoanSummaryApplicantType [VAELIG.X66]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"CoBorrower\":\"Co-Borrower\"}")]
        public StringEnumValue<BorrowerOrCoBorrower> VaLoanSummaryApplicantType { get => _vaLoanSummaryApplicantType; set => SetField(ref _vaLoanSummaryApplicantType, value); }

        /// <summary>
        /// VA Management Tool - NOV Date Received [VASUMM.X74]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Date Received")]
        public DateTime? VANOVDateReceived { get => _vANOVDateReceived; set => SetField(ref _vANOVDateReceived, value); }

        /// <summary>
        /// VA Management Tool - NOV Date Reviewed [VASUMM.X75]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Date Reviewed")]
        public DateTime? VANOVDateReviewed { get => _vANOVDateReviewed; set => SetField(ref _vANOVDateReviewed, value); }

        /// <summary>
        /// VA Management Tool - NOV Issued Date [VASUMM.X76]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Issued Date")]
        public DateTime? VANOVIssuedDate { get => _vANOVIssuedDate; set => SetField(ref _vANOVIssuedDate, value); }

        /// <summary>
        /// VA Management - Qualification - Original Amortization Type [VASUMM.X20]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Qualification - Original Amortization Type")]
        public StringEnumValue<AmortizationType> VAOriginalAmortizationType { get => _vAOriginalAmortizationType; set => SetField(ref _vAOriginalAmortizationType, value); }

        /// <summary>
        /// VA Management - Qualification - Original Monthly Payment [VASUMM.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management - Qualification - Original Monthly Payment")]
        public decimal? VAOriginalMonthlyPayment { get => _vAOriginalMonthlyPayment; set => SetField(ref _vAOriginalMonthlyPayment, value); }

        /// <summary>
        /// VA Management Tool - 2nd Tier Entitlement [VASUMM.X96]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - 2nd Tier Entitlement")]
        public string VAQualification2ndTierEntitlement { get => _vAQualification2ndTierEntitlement; set => SetField(ref _vAQualification2ndTierEntitlement, value); }

        /// <summary>
        /// VA Management Tool - Country Region [VASUMM.X95]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Country Region")]
        public StringEnumValue<VAQualificationCountryRegion> VAQualificationCountryRegion { get => _vAQualificationCountryRegion; set => SetField(ref _vAQualificationCountryRegion, value); }

        /// <summary>
        /// VA Management Tool - VA County Limits [VASUMM.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - VA County Limits")]
        public decimal? VAQualificationCountyLimits { get => _vAQualificationCountyLimits; set => SetField(ref _vAQualificationCountyLimits, value); }

        /// <summary>
        /// VA Management - Qualification - Recoup Closing Costs [VASUMM.X27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Recoup Closing Costs")]
        public int? VARecoupmentClosingCosts { get => _vARecoupmentClosingCosts; set => SetField(ref _vARecoupmentClosingCosts, value); }

        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids [VASUMM.X26]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids")]
        public bool? VARecoupmentExcludePrepaids { get => _vARecoupmentExcludePrepaids; set => SetField(ref _vARecoupmentExcludePrepaids, value); }

        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment [VASUMM.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment")]
        public decimal? VARecoupmentMonthlyDecreaseInPayment { get => _vARecoupmentMonthlyDecreaseInPayment; set => SetField(ref _vARecoupmentMonthlyDecreaseInPayment, value); }

        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Months [VASUMM.X29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Months")]
        public int? VARecoupmentMonths { get => _vARecoupmentMonths; set => SetField(ref _vARecoupmentMonths, value); }

        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs [VASUMM.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs")]
        public decimal? VARecoupmentTotalClosingCosts { get => _vARecoupmentTotalClosingCosts; set => SetField(ref _vARecoupmentTotalClosingCosts, value); }

        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Years [VASUMM.X28]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Years")]
        public int? VARecoupmentYears { get => _vARecoupmentYears; set => SetField(ref _vARecoupmentYears, value); }

        /// <summary>
        /// VA Management Tool - Cert. of Commitment Issued by VA [VASUMM.X86]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Cert. of Commitment Issued by VA")]
        public DateTime? VATrackingCertOfCommitmentIssued { get => _vATrackingCertOfCommitmentIssued; set => SetField(ref _vATrackingCertOfCommitmentIssued, value); }

        /// <summary>
        /// VA Management Tool - COE Issue Date [VASUMM.X80]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - COE Issue Date")]
        public DateTime? VATrackingCOEIssueDate { get => _vATrackingCOEIssueDate; set => SetField(ref _vATrackingCOEIssueDate, value); }

        /// <summary>
        /// VA Management Tool - COE Issue History [VASUMM.X81]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - COE Issue History")]
        public string VATrackingCOEIssueHistory { get => _vATrackingCOEIssueHistory; set => SetField(ref _vATrackingCOEIssueHistory, value); }

        /// <summary>
        /// VA Management Tool - Final Approval Commitment Date [VASUMM.X88]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Final Approval Commitment Date")]
        public DateTime? VATrackingFinalApprovalCommitmentDate { get => _vATrackingFinalApprovalCommitmentDate; set => SetField(ref _vATrackingFinalApprovalCommitmentDate, value); }

        /// <summary>
        /// VA Management Tool - GSA Exclusionary List Checked [VASUMM.X85]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - GSA Exclusionary List Checked")]
        public bool? VATrackingGSAExclusionaryListChecked { get => _vATrackingGSAExclusionaryListChecked; set => SetField(ref _vATrackingGSAExclusionaryListChecked, value); }

        /// <summary>
        /// VA Management Tool - Flood Policy [VASUMM.X91]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Flood Policy")]
        public bool? VATrackingInuranceFloodPolicy { get => _vATrackingInuranceFloodPolicy; set => SetField(ref _vATrackingInuranceFloodPolicy, value); }

        /// <summary>
        /// VA Management Tool - Hazard Policy [VASUMM.X92]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Hazard Policy")]
        public bool? VATrackingInuranceHazardPolicy { get => _vATrackingInuranceHazardPolicy; set => SetField(ref _vATrackingInuranceHazardPolicy, value); }

        /// <summary>
        /// VA Management Tool - Wind/Hail Policy [VASUMM.X94]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Wind/Hail Policy")]
        public bool? VATrackingInuranceWindOrHailPolicy { get => _vATrackingInuranceWindOrHailPolicy; set => SetField(ref _vATrackingInuranceWindOrHailPolicy, value); }

        /// <summary>
        /// VA Management Tool - Wood Destroying Policy [VASUMM.X93]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Wood Destroying Policy")]
        public bool? VATrackingInuranceWoodDestroyingPolicy { get => _vATrackingInuranceWoodDestroyingPolicy; set => SetField(ref _vATrackingInuranceWoodDestroyingPolicy, value); }

        /// <summary>
        /// VA Management Tool - Is SAR LAPP Certified [VASUMM.X72]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Is SAR LAPP Certified")]
        public bool? VATrackingIsSARLAPPCertified { get => _vATrackingIsSARLAPPCertified; set => SetField(ref _vATrackingIsSARLAPPCertified, value); }

        /// <summary>
        /// VA Management Tool - Loan Guarantee Cert. (LGC) Receipt [VASUMM.X84]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Loan Guarantee Cert. (LGC) Receipt")]
        public DateTime? VATrackingLoanGuaranteeCertReceipt { get => _vATrackingLoanGuaranteeCertReceipt; set => SetField(ref _vATrackingLoanGuaranteeCertReceipt, value); }

        /// <summary>
        /// VA Management Tool - VA Master Commitment Lock Expired [VASUMM.X87]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - VA Master Commitment Lock Expired")]
        public DateTime? VATrackingMasterCommitmentLockExpired { get => _vATrackingMasterCommitmentLockExpired; set => SetField(ref _vATrackingMasterCommitmentLockExpired, value); }

        /// <summary>
        /// VA Management Tool - Ordered Date [VASUMM.X79]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Ordered Date")]
        public DateTime? VATrackingOrderedDate { get => _vATrackingOrderedDate; set => SetField(ref _vATrackingOrderedDate, value); }

        /// <summary>
        /// VA Management Tool - Paid Date [VASUMM.X82]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Paid Date")]
        public DateTime? VATrackingPaidDate { get => _vATrackingPaidDate; set => SetField(ref _vATrackingPaidDate, value); }

        /// <summary>
        /// VA Management Tool - Purchase Contract Date [VASUMM.X89]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Purchase Contract Date")]
        public DateTime? VATrackingPurchaseContractDate { get => _vATrackingPurchaseContractDate; set => SetField(ref _vATrackingPurchaseContractDate, value); }

        /// <summary>
        /// VA Management Tool - Receipt Received [VASUMM.X83]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Receipt Received")]
        public bool? VATrackingReceiptReceived { get => _vATrackingReceiptReceived; set => SetField(ref _vATrackingReceiptReceived, value); }

        /// <summary>
        /// VA Management Tool - SAR ID [VASUMM.X71]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - SAR ID")]
        public string VATrackingSARID { get => _vATrackingSARID; set => SetField(ref _vATrackingSARID, value); }

        /// <summary>
        /// VA Management Tool - SAR Name [VASUMM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - SAR Name")]
        public string VATrackingSARName { get => _vATrackingSARName; set => SetField(ref _vATrackingSARName, value); }

        /// <summary>
        /// VA Equipment Vent Fan [316]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Vent Fan", OptionsJson = "{\"true\":\"Vent / Fan\"}")]
        public bool? VentFanIndicator { get => _ventFanIndicator; set => SetField(ref _ventFanIndicator, value); }

        /// <summary>
        /// VA Discharged/Have Svc-Connected Disabilities [VAELIG.X22]
        /// </summary>
        [LoanFieldProperty(Description = "VA Discharged/Have Svc-Connected Disabilities", OptionsJson = "{\"true\":\"Discharged / have any service-connected disabilities\"}")]
        public bool? VeteranDischargedIndicator { get => _veteranDischargedIndicator; set => SetField(ref _veteranDischargedIndicator, value); }

        /// <summary>
        /// VA Veteran Service Status [955]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Service Status")]
        public StringEnumValue<VeteranServiceType> VeteranServiceType { get => _veteranServiceType; set => SetField(ref _veteranServiceType, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor Addr [1026]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor Addr")]
        public string WarrantorAddress { get => _warrantorAddress; set => SetField(ref _warrantorAddress, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor City [GAPPR.X11]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor City")]
        public string WarrantorCity { get => _warrantorCity; set => SetField(ref _warrantorCity, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor Name [1025]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor Name")]
        public string WarrantorName { get => _warrantorName; set => SetField(ref _warrantorName, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor Phone [1027]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "VA New/Prop Constr Warrantor Phone")]
        public string WarrantorPhone { get => _warrantorPhone; set => SetField(ref _warrantorPhone, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor Zip [GAPPR.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA New/Prop Constr Warrantor Zip")]
        public string WarrantorPostalCode { get => _warrantorPostalCode; set => SetField(ref _warrantorPostalCode, value); }

        /// <summary>
        /// VA New/Prop Constr Warrantor State [GAPPR.X12]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor State")]
        public StringEnumValue<State> WarrantorState { get => _warrantorState; set => SetField(ref _warrantorState, value); }

        /// <summary>
        /// Subject Property Warranty Program Expiration Date [725]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Warranty Program Expiration Date")]
        public DateTime? WarrantyProgramExpirationDate { get => _warrantyProgramExpirationDate; set => SetField(ref _warrantyProgramExpirationDate, value); }

        /// <summary>
        /// VA Equipment W/W Carpet [318]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment W/W Carpet", OptionsJson = "{\"true\":\"W / W Carpet\"}")]
        public bool? WWCarpetIndicator { get => _wWCarpetIndicator; set => SetField(ref _wWCarpetIndicator, value); }
    }
}