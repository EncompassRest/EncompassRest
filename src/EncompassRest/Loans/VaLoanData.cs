using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class VaLoanData : IClean
    {
        private Value<decimal?> _acres;
        public decimal? Acres { get { return _acres; } set { _acres = value; } }
        private Value<string> _additionalSecurityDescription;
        public string AdditionalSecurityDescription { get { return _additionalSecurityDescription; } set { _additionalSecurityDescription = value; } }
        private Value<string> _administratorAddress;
        public string AdministratorAddress { get { return _administratorAddress; } set { _administratorAddress = value; } }
        private Value<string> _administratorCity;
        public string AdministratorCity { get { return _administratorCity; } set { _administratorCity = value; } }
        private Value<string> _administratorContact;
        public string AdministratorContact { get { return _administratorContact; } set { _administratorContact = value; } }
        private Value<string> _administratorName;
        public string AdministratorName { get { return _administratorName; } set { _administratorName = value; } }
        private Value<string> _administratorPostalCode;
        public string AdministratorPostalCode { get { return _administratorPostalCode; } set { _administratorPostalCode = value; } }
        private Value<string> _administratorState;
        public string AdministratorState { get { return _administratorState; } set { _administratorState = value; } }
        private Value<int?> _ageOfProperty;
        public int? AgeOfProperty { get { return _ageOfProperty; } set { _ageOfProperty = value; } }
        private Value<decimal?> _amountSpentOnEnergyImprovements;
        public decimal? AmountSpentOnEnergyImprovements { get { return _amountSpentOnEnergyImprovements; } set { _amountSpentOnEnergyImprovements = value; } }
        private Value<string> _amountTypeWithheld;
        public string AmountTypeWithheld { get { return _amountTypeWithheld; } set { _amountTypeWithheld = value; } }
        private Value<decimal?> _amountWithheld;
        public decimal? AmountWithheld { get { return _amountWithheld; } set { _amountWithheld = value; } }
        private Value<decimal?> _annualGroundRent;
        public decimal? AnnualGroundRent { get { return _annualGroundRent; } set { _annualGroundRent = value; } }
        private Value<decimal?> _annualMaintenanceAssessment;
        public decimal? AnnualMaintenanceAssessment { get { return _annualMaintenanceAssessment; } set { _annualMaintenanceAssessment = value; } }
        private Value<decimal?> _annualRealEstateTaxes;
        public decimal? AnnualRealEstateTaxes { get { return _annualRealEstateTaxes; } set { _annualRealEstateTaxes = value; } }
        private Value<decimal?> _annualSpecialAssessment;
        public decimal? AnnualSpecialAssessment { get { return _annualSpecialAssessment; } set { _annualSpecialAssessment = value; } }
        private Value<string> _applicantAddressCity;
        public string ApplicantAddressCity { get { return _applicantAddressCity; } set { _applicantAddressCity = value; } }
        private Value<string> _applicantAddressPostalCode;
        public string ApplicantAddressPostalCode { get { return _applicantAddressPostalCode; } set { _applicantAddressPostalCode = value; } }
        private Value<string> _applicantAddressState;
        public string ApplicantAddressState { get { return _applicantAddressState; } set { _applicantAddressState = value; } }
        private Value<string> _applicantAddressStreetLine1;
        public string ApplicantAddressStreetLine1 { get { return _applicantAddressStreetLine1; } set { _applicantAddressStreetLine1 = value; } }
        private Value<DateTime?> _applicantBirthDate;
        public DateTime? ApplicantBirthDate { get { return _applicantBirthDate; } set { _applicantBirthDate = value; } }
        private Value<string> _applicantEmailAddressText;
        public string ApplicantEmailAddressText { get { return _applicantEmailAddressText; } set { _applicantEmailAddressText = value; } }
        private Value<string> _applicantFirstNameWithMiddleName;
        public string ApplicantFirstNameWithMiddleName { get { return _applicantFirstNameWithMiddleName; } set { _applicantFirstNameWithMiddleName = value; } }
        private Value<string> _applicantHmdaGenderType;
        public string ApplicantHmdaGenderType { get { return _applicantHmdaGenderType; } set { _applicantHmdaGenderType = value; } }
        private Value<string> _applicantHomePhoneNumber;
        public string ApplicantHomePhoneNumber { get { return _applicantHomePhoneNumber; } set { _applicantHomePhoneNumber = value; } }
        private Value<string> _applicantLastNameWithSuffix;
        public string ApplicantLastNameWithSuffix { get { return _applicantLastNameWithSuffix; } set { _applicantLastNameWithSuffix = value; } }
        private Value<string> _applicantTaxIdentificationIdentifier;
        public string ApplicantTaxIdentificationIdentifier { get { return _applicantTaxIdentificationIdentifier; } set { _applicantTaxIdentificationIdentifier = value; } }
        private Value<string> _appraisalType;
        public string AppraisalType { get { return _appraisalType; } set { _appraisalType = value; } }
        private Value<bool?> _automaticProcedure;
        public bool? AutomaticProcedure { get { return _automaticProcedure; } set { _automaticProcedure = value; } }
        private Value<bool?> _availableForInspectionAMIndicator;
        public bool? AvailableForInspectionAMIndicator { get { return _availableForInspectionAMIndicator; } set { _availableForInspectionAMIndicator = value; } }
        private Value<string> _availableForInspectionDateAndTime;
        public string AvailableForInspectionDateAndTime { get { return _availableForInspectionDateAndTime; } set { _availableForInspectionDateAndTime = value; } }
        private Value<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get { return _borrowerPaidDiscountPointsTotalAmount; } set { _borrowerPaidDiscountPointsTotalAmount = value; } }
        private Value<string> _buildingType;
        public string BuildingType { get { return _buildingType; } set { _buildingType = value; } }
        private Value<bool?> _buyerPurchasingLotSeparately;
        public bool? BuyerPurchasingLotSeparately { get { return _buyerPurchasingLotSeparately; } set { _buyerPurchasingLotSeparately = value; } }
        private Value<decimal?> _cashPaymentFromVeteran;
        public decimal? CashPaymentFromVeteran { get { return _cashPaymentFromVeteran; } set { _cashPaymentFromVeteran = value; } }
        private Value<string> _claimDisabilityBenefits;
        public string ClaimDisabilityBenefits { get { return _claimDisabilityBenefits; } set { _claimDisabilityBenefits = value; } }
        private Value<bool?> _clothesWasherIndicator;
        public bool? ClothesWasherIndicator { get { return _clothesWasherIndicator; } set { _clothesWasherIndicator = value; } }
        private Value<DateTime?> _constructionCompletedDate;
        public DateTime? ConstructionCompletedDate { get { return _constructionCompletedDate; } set { _constructionCompletedDate = value; } }
        private Value<string> _constructionPlan;
        public string ConstructionPlan { get { return _constructionPlan; } set { _constructionPlan = value; } }
        private Value<bool?> _constructionWarrantyIncluded;
        public bool? ConstructionWarrantyIncluded { get { return _constructionWarrantyIncluded; } set { _constructionWarrantyIncluded = value; } }
        private Value<string> _contractNoApprovedByVA;
        public string ContractNoApprovedByVA { get { return _contractNoApprovedByVA; } set { _contractNoApprovedByVA = value; } }
        private Value<int?> _creditScore;
        public int? CreditScore { get { return _creditScore; } set { _creditScore = value; } }
        private Value<bool?> _currentlyOnMilitaryDuty;
        public bool? CurrentlyOnMilitaryDuty { get { return _currentlyOnMilitaryDuty; } set { _currentlyOnMilitaryDuty = value; } }
        private Value<DateTime?> _dateAquiredLand;
        public DateTime? DateAquiredLand { get { return _dateAquiredLand; } set { _dateAquiredLand = value; } }
        private Value<DateTime?> _dateOfAssignment;
        public DateTime? DateOfAssignment { get { return _dateOfAssignment; } set { _dateOfAssignment = value; } }
        private Value<DateTime?> _dateSAR;
        public DateTime? DateSAR { get { return _dateSAR; } set { _dateSAR = value; } }
        private Value<decimal?> _disabilityAmountCollected;
        public decimal? DisabilityAmountCollected { get { return _disabilityAmountCollected; } set { _disabilityAmountCollected = value; } }
        private Value<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        private Value<decimal?> _discountPoint;
        public decimal? DiscountPoint { get { return _discountPoint; } set { _discountPoint = value; } }
        private Value<bool?> _dishwasherIndicator;
        public bool? DishwasherIndicator { get { return _dishwasherIndicator; } set { _dishwasherIndicator = value; } }
        private Value<bool?> _dryerIndicator;
        public bool? DryerIndicator { get { return _dryerIndicator; } set { _dryerIndicator = value; } }
        private Value<string> _emailToBeNotifiedWhenUploaded;
        public string EmailToBeNotifiedWhenUploaded { get { return _emailToBeNotifiedWhenUploaded; } set { _emailToBeNotifiedWhenUploaded = value; } }
        private Value<bool?> _energyImprovementsAdditionOfFeature;
        public bool? EnergyImprovementsAdditionOfFeature { get { return _energyImprovementsAdditionOfFeature; } set { _energyImprovementsAdditionOfFeature = value; } }
        private Value<string> _entitlementCode;
        public string EntitlementCode { get { return _entitlementCode; } set { _entitlementCode = value; } }
        private Value<string> _equipmentOtherDescription;
        public string EquipmentOtherDescription { get { return _equipmentOtherDescription; } set { _equipmentOtherDescription = value; } }
        private Value<bool?> _excludeTaxesInsuranceIndicator;
        public bool? ExcludeTaxesInsuranceIndicator { get { return _excludeTaxesInsuranceIndicator; } set { _excludeTaxesInsuranceIndicator = value; } }
        private Value<decimal?> _finalDiscountAmount;
        public decimal? FinalDiscountAmount { get { return _finalDiscountAmount; } set { _finalDiscountAmount = value; } }
        private Value<decimal?> _finalFundingFeeAmount;
        public decimal? FinalFundingFeeAmount { get { return _finalFundingFeeAmount; } set { _finalFundingFeeAmount = value; } }
        private Value<bool?> _firstChattelLoanType;
        public bool? FirstChattelLoanType { get { return _firstChattelLoanType; } set { _firstChattelLoanType = value; } }
        private Value<bool?> _firstTimeUse;
        public bool? FirstTimeUse { get { return _firstTimeUse; } set { _firstTimeUse = value; } }
        private Value<bool?> _fundingFeeExempt;
        public bool? FundingFeeExempt { get { return _fundingFeeExempt; } set { _fundingFeeExempt = value; } }
        private Value<bool?> _garbageDisposalIndicator;
        public bool? GarbageDisposalIndicator { get { return _garbageDisposalIndicator; } set { _garbageDisposalIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _initialTotal;
        public decimal? InitialTotal { get { return _initialTotal; } set { _initialTotal = value; } }
        private Value<string> _inspectionWillBeMadeBy;
        public string InspectionWillBeMadeBy { get { return _inspectionWillBeMadeBy; } set { _inspectionWillBeMadeBy = value; } }
        private Value<bool?> _insulation;
        public bool? Insulation { get { return _insulation; } set { _insulation = value; } }
        private Value<string> _insuranceType;
        public string InsuranceType { get { return _insuranceType; } set { _insuranceType = value; } }
        private Value<int?> _irregularLotSizeInSquareFeet;
        public int? IrregularLotSizeInSquareFeet { get { return _irregularLotSizeInSquareFeet; } set { _irregularLotSizeInSquareFeet = value; } }
        private Value<bool?> _isDelinquent30Days;
        public bool? IsDelinquent30Days { get { return _isDelinquent30Days; } set { _isDelinquent30Days = value; } }
        private Value<string> _keysAtAddress;
        public string KeysAtAddress { get { return _keysAtAddress; } set { _keysAtAddress = value; } }
        private Value<decimal?> _landPurchasePrice;
        public decimal? LandPurchasePrice { get { return _landPurchasePrice; } set { _landPurchasePrice = value; } }
        private Value<string> _leaseholdType;
        public string LeaseholdType { get { return _leaseholdType; } set { _leaseholdType = value; } }
        private Value<string> _lenderSAR;
        public string LenderSAR { get { return _lenderSAR; } set { _lenderSAR = value; } }
        private Value<string> _loanAnalysisRemarks1;
        public string LoanAnalysisRemarks1 { get { return _loanAnalysisRemarks1; } set { _loanAnalysisRemarks1 = value; } }
        private Value<string> _loanAnalysisRemarks2;
        public string LoanAnalysisRemarks2 { get { return _loanAnalysisRemarks2; } set { _loanAnalysisRemarks2 = value; } }
        private Value<string> _loanAnalysisRemarks3;
        public string LoanAnalysisRemarks3 { get { return _loanAnalysisRemarks3; } set { _loanAnalysisRemarks3 = value; } }
        private Value<string> _loanAnalysisRemarks4;
        public string LoanAnalysisRemarks4 { get { return _loanAnalysisRemarks4; } set { _loanAnalysisRemarks4 = value; } }
        private Value<string> _loanAnalysisRemarks5;
        public string LoanAnalysisRemarks5 { get { return _loanAnalysisRemarks5; } set { _loanAnalysisRemarks5 = value; } }
        private Value<string> _loanAnalysisRemarks6;
        public string LoanAnalysisRemarks6 { get { return _loanAnalysisRemarks6; } set { _loanAnalysisRemarks6 = value; } }
        private Value<string> _loanAnalysisRemarks7;
        public string LoanAnalysisRemarks7 { get { return _loanAnalysisRemarks7; } set { _loanAnalysisRemarks7 = value; } }
        private Value<string> _loanAnalysisRemarks8;
        public string LoanAnalysisRemarks8 { get { return _loanAnalysisRemarks8; } set { _loanAnalysisRemarks8 = value; } }
        private Value<string> _loanAnalysisRemarks9;
        public string LoanAnalysisRemarks9 { get { return _loanAnalysisRemarks9; } set { _loanAnalysisRemarks9 = value; } }
        private Value<string> _loanCode;
        public string LoanCode { get { return _loanCode; } set { _loanCode = value; } }
        private Value<string> _loanProcedure;
        public string LoanProcedure { get { return _loanProcedure; } set { _loanProcedure = value; } }
        private Value<bool?> _loanProcessedUnderAU;
        public bool? LoanProcessedUnderAU { get { return _loanProcessedUnderAU; } set { _loanProcessedUnderAU = value; } }
        private Value<string> _loanSummaryRemarks1;
        public string LoanSummaryRemarks1 { get { return _loanSummaryRemarks1; } set { _loanSummaryRemarks1 = value; } }
        private Value<string> _loanSummaryRemarks2;
        public string LoanSummaryRemarks2 { get { return _loanSummaryRemarks2; } set { _loanSummaryRemarks2 = value; } }
        private Value<string> _loanSummaryRemarks3;
        public string LoanSummaryRemarks3 { get { return _loanSummaryRemarks3; } set { _loanSummaryRemarks3 = value; } }
        private Value<string> _loanSummaryRemarks4;
        public string LoanSummaryRemarks4 { get { return _loanSummaryRemarks4; } set { _loanSummaryRemarks4 = value; } }
        private Value<string> _loanSummaryRemarks5;
        public string LoanSummaryRemarks5 { get { return _loanSummaryRemarks5; } set { _loanSummaryRemarks5 = value; } }
        private Value<string> _loanSummaryRemarks6;
        public string LoanSummaryRemarks6 { get { return _loanSummaryRemarks6; } set { _loanSummaryRemarks6 = value; } }
        private Value<string> _loanSummaryRemarks7;
        public string LoanSummaryRemarks7 { get { return _loanSummaryRemarks7; } set { _loanSummaryRemarks7 = value; } }
        private Value<string> _loanSummaryRemarks8;
        public string LoanSummaryRemarks8 { get { return _loanSummaryRemarks8; } set { _loanSummaryRemarks8 = value; } }
        private Value<string> _lotDimensions;
        public string LotDimensions { get { return _lotDimensions; } set { _lotDimensions = value; } }
        private Value<string> _mailingAddress;
        public string MailingAddress { get { return _mailingAddress; } set { _mailingAddress = value; } }
        private Value<string> _mailingCity;
        public string MailingCity { get { return _mailingCity; } set { _mailingCity = value; } }
        private Value<string> _mailingPostalCode;
        public string MailingPostalCode { get { return _mailingPostalCode; } set { _mailingPostalCode = value; } }
        private Value<string> _mailingState;
        public string MailingState { get { return _mailingState; } set { _mailingState = value; } }
        private Value<string> _manufacturedHome;
        public string ManufacturedHome { get { return _manufacturedHome; } set { _manufacturedHome = value; } }
        private Value<string> _mCRVNumber;
        public string MCRVNumber { get { return _mCRVNumber; } set { _mCRVNumber = value; } }
        private Value<string> _militaryBranchOfService;
        public string MilitaryBranchOfService { get { return _militaryBranchOfService; } set { _militaryBranchOfService = value; } }
        private Value<List<MilitaryService>> _militaryServices;
        public List<MilitaryService> MilitaryServices { get { return _militaryServices; } set { _militaryServices = value; } }
        private Value<string> _mineralRightsReserved;
        public string MineralRightsReserved { get { return _mineralRightsReserved; } set { _mineralRightsReserved = value; } }
        private Value<string> _nameOfOccupant;
        public string NameOfOccupant { get { return _nameOfOccupant; } set { _nameOfOccupant = value; } }
        private Value<string> _nameOfOwner;
        public string NameOfOwner { get { return _nameOfOwner; } set { _nameOfOwner = value; } }
        private Value<string> _nameOfWarrantyProgram;
        public string NameOfWarrantyProgram { get { return _nameOfWarrantyProgram; } set { _nameOfWarrantyProgram = value; } }
        private Value<decimal?> _negativeRents;
        public decimal? NegativeRents { get { return _negativeRents; } set { _negativeRents = value; } }
        private Value<bool?> _noEnergyImprovements;
        public bool? NoEnergyImprovements { get { return _noEnergyImprovements; } set { _noEnergyImprovements = value; } }
        private Value<string> _nonrealtyDescription;
        public string NonrealtyDescription { get { return _nonrealtyDescription; } set { _nonrealtyDescription = value; } }
        private Value<string> _numberOfBuildings;
        public string NumberOfBuildings { get { return _numberOfBuildings; } set { _numberOfBuildings = value; } }
        private Value<string> _occupantTelephone;
        public string OccupantTelephone { get { return _occupantTelephone; } set { _occupantTelephone = value; } }
        private Value<bool?> _onMilitaryDutyFollowingSeparation;
        public bool? OnMilitaryDutyFollowingSeparation { get { return _onMilitaryDutyFollowingSeparation; } set { _onMilitaryDutyFollowingSeparation = value; } }
        private Value<decimal?> _originalInterestRate;
        public decimal? OriginalInterestRate { get { return _originalInterestRate; } set { _originalInterestRate = value; } }
        private Value<decimal?> _originalLoanAmount;
        public decimal? OriginalLoanAmount { get { return _originalLoanAmount; } set { _originalLoanAmount = value; } }
        private Value<int?> _originalTerm;
        public int? OriginalTerm { get { return _originalTerm; } set { _originalTerm = value; } }
        private Value<bool?> _originalValueEstimateChanged;
        public bool? OriginalValueEstimateChanged { get { return _originalValueEstimateChanged; } set { _originalValueEstimateChanged = value; } }
        private Value<decimal?> _originationFeeAmount;
        public decimal? OriginationFeeAmount { get { return _originationFeeAmount; } set { _originationFeeAmount = value; } }
        private Value<decimal?> _otherClosingCosts;
        public decimal? OtherClosingCosts { get { return _otherClosingCosts; } set { _otherClosingCosts = value; } }
        private Value<string> _otherDescriptionEstateProperty;
        public string OtherDescriptionEstateProperty { get { return _otherDescriptionEstateProperty; } set { _otherDescriptionEstateProperty = value; } }
        private Value<string> _otherDescriptionLoanType;
        public string OtherDescriptionLoanType { get { return _otherDescriptionLoanType; } set { _otherDescriptionLoanType = value; } }
        private Value<bool?> _otherEstateProperty;
        public bool? OtherEstateProperty { get { return _otherEstateProperty; } set { _otherEstateProperty = value; } }
        private Value<bool?> _otherImprovements;
        public bool? OtherImprovements { get { return _otherImprovements; } set { _otherImprovements = value; } }
        private Value<bool?> _otherLoanType;
        public bool? OtherLoanType { get { return _otherLoanType; } set { _otherLoanType = value; } }
        private Value<string> _paidInFullVALoanNumber;
        public string PaidInFullVALoanNumber { get { return _paidInFullVALoanNumber; } set { _paidInFullVALoanNumber = value; } }
        private Value<bool?> _payoffIndicator1;
        public bool? PayoffIndicator1 { get { return _payoffIndicator1; } set { _payoffIndicator1 = value; } }
        private Value<bool?> _payoffIndicator2;
        public bool? PayoffIndicator2 { get { return _payoffIndicator2; } set { _payoffIndicator2 = value; } }
        private Value<bool?> _payoffIndicator3;
        public bool? PayoffIndicator3 { get { return _payoffIndicator3; } set { _payoffIndicator3 = value; } }
        private Value<bool?> _payoffIndicator4;
        public bool? PayoffIndicator4 { get { return _payoffIndicator4; } set { _payoffIndicator4 = value; } }
        private Value<bool?> _payoffIndicator5;
        public bool? PayoffIndicator5 { get { return _payoffIndicator5; } set { _payoffIndicator5 = value; } }
        private Value<bool?> _payoffIndicator6;
        public bool? PayoffIndicator6 { get { return _payoffIndicator6; } set { _payoffIndicator6 = value; } }
        private Value<bool?> _payoffIndicator7;
        public bool? PayoffIndicator7 { get { return _payoffIndicator7; } set { _payoffIndicator7 = value; } }
        private Value<bool?> _payoffIndicator8;
        public bool? PayoffIndicator8 { get { return _payoffIndicator8; } set { _payoffIndicator8 = value; } }
        private Value<bool?> _payoffIndicator9;
        public bool? PayoffIndicator9 { get { return _payoffIndicator9; } set { _payoffIndicator9 = value; } }
        private Value<decimal?> _pestReportFee;
        public decimal? PestReportFee { get { return _pestReportFee; } set { _pestReportFee = value; } }
        private Value<string> _plansSubmitted;
        public string PlansSubmitted { get { return _plansSubmitted; } set { _plansSubmitted = value; } }
        private Value<string> _pOCAddress;
        public string POCAddress { get { return _pOCAddress; } set { _pOCAddress = value; } }
        private Value<string> _pOCCity;
        public string POCCity { get { return _pOCCity; } set { _pOCCity = value; } }
        private Value<string> _pOCName;
        public string POCName { get { return _pOCName; } set { _pOCName = value; } }
        private Value<string> _pOCPhone;
        public string POCPhone { get { return _pOCPhone; } set { _pOCPhone = value; } }
        private Value<string> _pOCState;
        public string POCState { get { return _pOCState; } set { _pOCState = value; } }
        private Value<string> _pOCZipCode;
        public string POCZipCode { get { return _pOCZipCode; } set { _pOCZipCode = value; } }
        private Value<decimal?> _preliminaryDiscountAmount;
        public decimal? PreliminaryDiscountAmount { get { return _preliminaryDiscountAmount; } set { _preliminaryDiscountAmount = value; } }
        private Value<decimal?> _preliminaryFundingFeeAmount;
        public decimal? PreliminaryFundingFeeAmount { get { return _preliminaryFundingFeeAmount; } set { _preliminaryFundingFeeAmount = value; } }
        private Value<decimal?> _preliminaryTotal;
        public decimal? PreliminaryTotal { get { return _preliminaryTotal; } set { _preliminaryTotal = value; } }
        private Value<bool?> _previousVALoanIndicator;
        public bool? PreviousVALoanIndicator { get { return _previousVALoanIndicator; } set { _previousVALoanIndicator = value; } }
        private Value<List<PreviousVaLoan>> _previousVaLoans;
        public List<PreviousVaLoan> PreviousVaLoans { get { return _previousVaLoans; } set { _previousVaLoans = value; } }
        private Value<bool?> _priorApprovalProcedure;
        public bool? PriorApprovalProcedure { get { return _priorApprovalProcedure; } set { _priorApprovalProcedure = value; } }
        private Value<string> _priorLoanType;
        public string PriorLoanType { get { return _priorLoanType; } set { _priorLoanType = value; } }
        private Value<string> _propertyDesignation;
        public string PropertyDesignation { get { return _propertyDesignation; } set { _propertyDesignation = value; } }
        private Value<int?> _propertyGrossLivingArea;
        public int? PropertyGrossLivingArea { get { return _propertyGrossLivingArea; } set { _propertyGrossLivingArea = value; } }
        private Value<string> _propertyLegalDescription1;
        public string PropertyLegalDescription1 { get { return _propertyLegalDescription1; } set { _propertyLegalDescription1 = value; } }
        private Value<string> _propertyLegalDescription2;
        public string PropertyLegalDescription2 { get { return _propertyLegalDescription2; } set { _propertyLegalDescription2 = value; } }
        private Value<string> _propertyLegalDescription3;
        public string PropertyLegalDescription3 { get { return _propertyLegalDescription3; } set { _propertyLegalDescription3 = value; } }
        private Value<string> _propertyLegalDescription4;
        public string PropertyLegalDescription4 { get { return _propertyLegalDescription4; } set { _propertyLegalDescription4 = value; } }
        private Value<string> _propertyOccupancyType;
        public string PropertyOccupancyType { get { return _propertyOccupancyType; } set { _propertyOccupancyType = value; } }
        private Value<bool?> _proposedSaleContractAttached;
        public bool? ProposedSaleContractAttached { get { return _proposedSaleContractAttached; } set { _proposedSaleContractAttached = value; } }
        private Value<string> _purposeOfLoan;
        public string PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        private Value<bool?> _rangeOvenIndicator;
        public bool? RangeOvenIndicator { get { return _rangeOvenIndicator; } set { _rangeOvenIndicator = value; } }
        private Value<bool?> _reasonableValueCompleted;
        public bool? ReasonableValueCompleted { get { return _reasonableValueCompleted; } set { _reasonableValueCompleted = value; } }
        private Value<bool?> _refrigeratorIndicator;
        public bool? RefrigeratorIndicator { get { return _refrigeratorIndicator; } set { _refrigeratorIndicator = value; } }
        private Value<string> _rent;
        public string Rent { get { return _rent; } set { _rent = value; } }
        private Value<bool?> _replacementOfSystem;
        public bool? ReplacementOfSystem { get { return _replacementOfSystem; } set { _replacementOfSystem = value; } }
        private Value<string> _riskClasification;
        public string RiskClasification { get { return _riskClasification; } set { _riskClasification = value; } }
        private Value<string> _serviceNumber;
        public string ServiceNumber { get { return _serviceNumber; } set { _serviceNumber = value; } }
        private Value<bool?> _solarHeatingOrCooling;
        public bool? SolarHeatingOrCooling { get { return _solarHeatingOrCooling; } set { _solarHeatingOrCooling = value; } }
        private Value<string> _specialAssessmentComments1;
        public string SpecialAssessmentComments1 { get { return _specialAssessmentComments1; } set { _specialAssessmentComments1 = value; } }
        private Value<string> _specialAssessmentComments2;
        public string SpecialAssessmentComments2 { get { return _specialAssessmentComments2; } set { _specialAssessmentComments2 = value; } }
        private Value<string> _specialAssessmentComments3;
        public string SpecialAssessmentComments3 { get { return _specialAssessmentComments3; } set { _specialAssessmentComments3 = value; } }
        private Value<string> _streetAccess;
        public string StreetAccess { get { return _streetAccess; } set { _streetAccess = value; } }
        private Value<string> _streetMaintenance;
        public string StreetMaintenance { get { return _streetMaintenance; } set { _streetMaintenance = value; } }
        private Value<string> _systemUsed;
        public string SystemUsed { get { return _systemUsed; } set { _systemUsed = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private Value<string> _titleLimitations1;
        public string TitleLimitations1 { get { return _titleLimitations1; } set { _titleLimitations1 = value; } }
        private Value<string> _titleLimitations2;
        public string TitleLimitations2 { get { return _titleLimitations2; } set { _titleLimitations2 = value; } }
        private Value<string> _titleLimitations3;
        public string TitleLimitations3 { get { return _titleLimitations3; } set { _titleLimitations3 = value; } }
        private Value<decimal?> _totalBaths;
        public decimal? TotalBaths { get { return _totalBaths; } set { _totalBaths = value; } }
        private Value<int?> _totalBedrooms;
        public int? TotalBedrooms { get { return _totalBedrooms; } set { _totalBedrooms = value; } }
        private Value<decimal?> _totalDebtMonthlyPayment;
        public decimal? TotalDebtMonthlyPayment { get { return _totalDebtMonthlyPayment; } set { _totalDebtMonthlyPayment = value; } }
        private Value<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        private Value<decimal?> _totalDiscountPointsCharged;
        public decimal? TotalDiscountPointsCharged { get { return _totalDiscountPointsCharged; } set { _totalDiscountPointsCharged = value; } }
        private Value<decimal?> _totalForMaxLoanAmount;
        public decimal? TotalForMaxLoanAmount { get { return _totalForMaxLoanAmount; } set { _totalForMaxLoanAmount = value; } }
        private Value<decimal?> _totalMonthlyPayment;
        public decimal? TotalMonthlyPayment { get { return _totalMonthlyPayment; } set { _totalMonthlyPayment = value; } }
        private Value<decimal?> _totalProposedMonthlyPayment;
        public decimal? TotalProposedMonthlyPayment { get { return _totalProposedMonthlyPayment; } set { _totalProposedMonthlyPayment = value; } }
        private Value<int?> _totalRooms;
        public int? TotalRooms { get { return _totalRooms; } set { _totalRooms = value; } }
        private Value<decimal?> _totalUnpaidSpecialAssessments;
        public decimal? TotalUnpaidSpecialAssessments { get { return _totalUnpaidSpecialAssessments; } set { _totalUnpaidSpecialAssessments = value; } }
        private Value<string> _typeOfHybridARM;
        public string TypeOfHybridARM { get { return _typeOfHybridARM; } set { _typeOfHybridARM = value; } }
        private Value<string> _typeOfMortgage;
        public string TypeOfMortgage { get { return _typeOfMortgage; } set { _typeOfMortgage = value; } }
        private Value<string> _typeOfOwnsership;
        public string TypeOfOwnsership { get { return _typeOfOwnsership; } set { _typeOfOwnsership = value; } }
        private Value<string> _typeOfStructure;
        public string TypeOfStructure { get { return _typeOfStructure; } set { _typeOfStructure = value; } }
        private Value<string> _typeOfVeteran;
        public string TypeOfVeteran { get { return _typeOfVeteran; } set { _typeOfVeteran = value; } }
        private Value<bool?> _unsecuredLoanType;
        public bool? UnsecuredLoanType { get { return _unsecuredLoanType; } set { _unsecuredLoanType = value; } }
        private Value<string> _utilitiesElectricDescription;
        public string UtilitiesElectricDescription { get { return _utilitiesElectricDescription; } set { _utilitiesElectricDescription = value; } }
        private Value<string> _utilitiesGasDescription;
        public string UtilitiesGasDescription { get { return _utilitiesGasDescription; } set { _utilitiesGasDescription = value; } }
        private Value<string> _utilitiesSewerDescription;
        public string UtilitiesSewerDescription { get { return _utilitiesSewerDescription; } set { _utilitiesSewerDescription = value; } }
        private Value<string> _utilitiesWaterDescription;
        public string UtilitiesWaterDescription { get { return _utilitiesWaterDescription; } set { _utilitiesWaterDescription = value; } }
        private Value<DateTime?> _vAAppraisalSentDate;
        public DateTime? VAAppraisalSentDate { get { return _vAAppraisalSentDate; } set { _vAAppraisalSentDate = value; } }
        private Value<string> _vABenefitRelatedIndebtedness;
        public string VABenefitRelatedIndebtedness { get { return _vABenefitRelatedIndebtedness; } set { _vABenefitRelatedIndebtedness = value; } }
        private Value<string> _vABuilderDescription;
        public string VABuilderDescription { get { return _vABuilderDescription; } set { _vABuilderDescription = value; } }
        private Value<string> _vABuilderIDNo;
        public string VABuilderIDNo { get { return _vABuilderIDNo; } set { _vABuilderIDNo = value; } }
        private Value<string> _vAClaimFolderNumber;
        public string VAClaimFolderNumber { get { return _vAClaimFolderNumber; } set { _vAClaimFolderNumber = value; } }
        private Value<string> _vAClaimNumber;
        public string VAClaimNumber { get { return _vAClaimNumber; } set { _vAClaimNumber = value; } }
        private Value<DateTime?> _vADateNOVAppraisalMailedToBorrower;
        public DateTime? VADateNOVAppraisalMailedToBorrower { get { return _vADateNOVAppraisalMailedToBorrower; } set { _vADateNOVAppraisalMailedToBorrower = value; } }
        private Value<bool?> _vAIsDelinquent30Days;
        public bool? VAIsDelinquent30Days { get { return _vAIsDelinquent30Days; } set { _vAIsDelinquent30Days = value; } }
        private Value<bool?> _vALatePaymentIn6Months;
        public bool? VALatePaymentIn6Months { get { return _vALatePaymentIn6Months; } set { _vALatePaymentIn6Months = value; } }
        private Value<string> _vaLoanSummaryApplicantType;
        public string VaLoanSummaryApplicantType { get { return _vaLoanSummaryApplicantType; } set { _vaLoanSummaryApplicantType = value; } }
        private Value<DateTime?> _vANOVDateReceived;
        public DateTime? VANOVDateReceived { get { return _vANOVDateReceived; } set { _vANOVDateReceived = value; } }
        private Value<DateTime?> _vANOVDateReviewed;
        public DateTime? VANOVDateReviewed { get { return _vANOVDateReviewed; } set { _vANOVDateReviewed = value; } }
        private Value<DateTime?> _vANOVIssuedDate;
        public DateTime? VANOVIssuedDate { get { return _vANOVIssuedDate; } set { _vANOVIssuedDate = value; } }
        private Value<string> _vAOriginalAmortizationType;
        public string VAOriginalAmortizationType { get { return _vAOriginalAmortizationType; } set { _vAOriginalAmortizationType = value; } }
        private Value<decimal?> _vAOriginalMonthlyPayment;
        public decimal? VAOriginalMonthlyPayment { get { return _vAOriginalMonthlyPayment; } set { _vAOriginalMonthlyPayment = value; } }
        private Value<string> _vAQualification2ndTierEntitlement;
        public string VAQualification2ndTierEntitlement { get { return _vAQualification2ndTierEntitlement; } set { _vAQualification2ndTierEntitlement = value; } }
        private Value<string> _vAQualificationCountryRegion;
        public string VAQualificationCountryRegion { get { return _vAQualificationCountryRegion; } set { _vAQualificationCountryRegion = value; } }
        private Value<decimal?> _vAQualificationCountyLimits;
        public decimal? VAQualificationCountyLimits { get { return _vAQualificationCountyLimits; } set { _vAQualificationCountyLimits = value; } }
        private Value<int?> _vARecoupmentClosingCosts;
        public int? VARecoupmentClosingCosts { get { return _vARecoupmentClosingCosts; } set { _vARecoupmentClosingCosts = value; } }
        private Value<bool?> _vARecoupmentExcludePrepaids;
        public bool? VARecoupmentExcludePrepaids { get { return _vARecoupmentExcludePrepaids; } set { _vARecoupmentExcludePrepaids = value; } }
        private Value<decimal?> _vARecoupmentMonthlyDecreaseInPayment;
        public decimal? VARecoupmentMonthlyDecreaseInPayment { get { return _vARecoupmentMonthlyDecreaseInPayment; } set { _vARecoupmentMonthlyDecreaseInPayment = value; } }
        private Value<int?> _vARecoupmentMonths;
        public int? VARecoupmentMonths { get { return _vARecoupmentMonths; } set { _vARecoupmentMonths = value; } }
        private Value<decimal?> _vARecoupmentTotalClosingCosts;
        public decimal? VARecoupmentTotalClosingCosts { get { return _vARecoupmentTotalClosingCosts; } set { _vARecoupmentTotalClosingCosts = value; } }
        private Value<int?> _vARecoupmentYears;
        public int? VARecoupmentYears { get { return _vARecoupmentYears; } set { _vARecoupmentYears = value; } }
        private Value<DateTime?> _vATrackingCertOfCommitmentIssued;
        public DateTime? VATrackingCertOfCommitmentIssued { get { return _vATrackingCertOfCommitmentIssued; } set { _vATrackingCertOfCommitmentIssued = value; } }
        private Value<DateTime?> _vATrackingCOEIssueDate;
        public DateTime? VATrackingCOEIssueDate { get { return _vATrackingCOEIssueDate; } set { _vATrackingCOEIssueDate = value; } }
        private Value<string> _vATrackingCOEIssueHistory;
        public string VATrackingCOEIssueHistory { get { return _vATrackingCOEIssueHistory; } set { _vATrackingCOEIssueHistory = value; } }
        private Value<DateTime?> _vATrackingFinalApprovalCommitmentDate;
        public DateTime? VATrackingFinalApprovalCommitmentDate { get { return _vATrackingFinalApprovalCommitmentDate; } set { _vATrackingFinalApprovalCommitmentDate = value; } }
        private Value<bool?> _vATrackingGSAExclusionaryListChecked;
        public bool? VATrackingGSAExclusionaryListChecked { get { return _vATrackingGSAExclusionaryListChecked; } set { _vATrackingGSAExclusionaryListChecked = value; } }
        private Value<bool?> _vATrackingInuranceFloodPolicy;
        public bool? VATrackingInuranceFloodPolicy { get { return _vATrackingInuranceFloodPolicy; } set { _vATrackingInuranceFloodPolicy = value; } }
        private Value<bool?> _vATrackingInuranceHazardPolicy;
        public bool? VATrackingInuranceHazardPolicy { get { return _vATrackingInuranceHazardPolicy; } set { _vATrackingInuranceHazardPolicy = value; } }
        private Value<bool?> _vATrackingInuranceWindOrHailPolicy;
        public bool? VATrackingInuranceWindOrHailPolicy { get { return _vATrackingInuranceWindOrHailPolicy; } set { _vATrackingInuranceWindOrHailPolicy = value; } }
        private Value<bool?> _vATrackingInuranceWoodDestroyingPolicy;
        public bool? VATrackingInuranceWoodDestroyingPolicy { get { return _vATrackingInuranceWoodDestroyingPolicy; } set { _vATrackingInuranceWoodDestroyingPolicy = value; } }
        private Value<bool?> _vATrackingIsSARLAPPCertified;
        public bool? VATrackingIsSARLAPPCertified { get { return _vATrackingIsSARLAPPCertified; } set { _vATrackingIsSARLAPPCertified = value; } }
        private Value<DateTime?> _vATrackingLoanGuaranteeCertReceipt;
        public DateTime? VATrackingLoanGuaranteeCertReceipt { get { return _vATrackingLoanGuaranteeCertReceipt; } set { _vATrackingLoanGuaranteeCertReceipt = value; } }
        private Value<DateTime?> _vATrackingMasterCommitmentLockExpired;
        public DateTime? VATrackingMasterCommitmentLockExpired { get { return _vATrackingMasterCommitmentLockExpired; } set { _vATrackingMasterCommitmentLockExpired = value; } }
        private Value<DateTime?> _vATrackingOrderedDate;
        public DateTime? VATrackingOrderedDate { get { return _vATrackingOrderedDate; } set { _vATrackingOrderedDate = value; } }
        private Value<DateTime?> _vATrackingPaidDate;
        public DateTime? VATrackingPaidDate { get { return _vATrackingPaidDate; } set { _vATrackingPaidDate = value; } }
        private Value<DateTime?> _vATrackingPurchaseContractDate;
        public DateTime? VATrackingPurchaseContractDate { get { return _vATrackingPurchaseContractDate; } set { _vATrackingPurchaseContractDate = value; } }
        private Value<bool?> _vATrackingReceiptReceived;
        public bool? VATrackingReceiptReceived { get { return _vATrackingReceiptReceived; } set { _vATrackingReceiptReceived = value; } }
        private Value<string> _vATrackingSARID;
        public string VATrackingSARID { get { return _vATrackingSARID; } set { _vATrackingSARID = value; } }
        private Value<string> _vATrackingSARName;
        public string VATrackingSARName { get { return _vATrackingSARName; } set { _vATrackingSARName = value; } }
        private Value<bool?> _ventFanIndicator;
        public bool? VentFanIndicator { get { return _ventFanIndicator; } set { _ventFanIndicator = value; } }
        private Value<bool?> _veteranDischargedIndicator;
        public bool? VeteranDischargedIndicator { get { return _veteranDischargedIndicator; } set { _veteranDischargedIndicator = value; } }
        private Value<string> _veteranServiceType;
        public string VeteranServiceType { get { return _veteranServiceType; } set { _veteranServiceType = value; } }
        private Value<string> _warrantorAddress;
        public string WarrantorAddress { get { return _warrantorAddress; } set { _warrantorAddress = value; } }
        private Value<string> _warrantorCity;
        public string WarrantorCity { get { return _warrantorCity; } set { _warrantorCity = value; } }
        private Value<string> _warrantorName;
        public string WarrantorName { get { return _warrantorName; } set { _warrantorName = value; } }
        private Value<string> _warrantorPhone;
        public string WarrantorPhone { get { return _warrantorPhone; } set { _warrantorPhone = value; } }
        private Value<string> _warrantorPostalCode;
        public string WarrantorPostalCode { get { return _warrantorPostalCode; } set { _warrantorPostalCode = value; } }
        private Value<string> _warrantorState;
        public string WarrantorState { get { return _warrantorState; } set { _warrantorState = value; } }
        private Value<DateTime?> _warrantyProgramExpirationDate;
        public DateTime? WarrantyProgramExpirationDate { get { return _warrantyProgramExpirationDate; } set { _warrantyProgramExpirationDate = value; } }
        private Value<bool?> _wWCarpetIndicator;
        public bool? WWCarpetIndicator { get { return _wWCarpetIndicator; } set { _wWCarpetIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acres.Clean
                    && _additionalSecurityDescription.Clean
                    && _administratorAddress.Clean
                    && _administratorCity.Clean
                    && _administratorContact.Clean
                    && _administratorName.Clean
                    && _administratorPostalCode.Clean
                    && _administratorState.Clean
                    && _ageOfProperty.Clean
                    && _amountSpentOnEnergyImprovements.Clean
                    && _amountTypeWithheld.Clean
                    && _amountWithheld.Clean
                    && _annualGroundRent.Clean
                    && _annualMaintenanceAssessment.Clean
                    && _annualRealEstateTaxes.Clean
                    && _annualSpecialAssessment.Clean
                    && _applicantAddressCity.Clean
                    && _applicantAddressPostalCode.Clean
                    && _applicantAddressState.Clean
                    && _applicantAddressStreetLine1.Clean
                    && _applicantBirthDate.Clean
                    && _applicantEmailAddressText.Clean
                    && _applicantFirstNameWithMiddleName.Clean
                    && _applicantHmdaGenderType.Clean
                    && _applicantHomePhoneNumber.Clean
                    && _applicantLastNameWithSuffix.Clean
                    && _applicantTaxIdentificationIdentifier.Clean
                    && _appraisalType.Clean
                    && _automaticProcedure.Clean
                    && _availableForInspectionAMIndicator.Clean
                    && _availableForInspectionDateAndTime.Clean
                    && _borrowerPaidDiscountPointsTotalAmount.Clean
                    && _buildingType.Clean
                    && _buyerPurchasingLotSeparately.Clean
                    && _cashPaymentFromVeteran.Clean
                    && _claimDisabilityBenefits.Clean
                    && _clothesWasherIndicator.Clean
                    && _constructionCompletedDate.Clean
                    && _constructionPlan.Clean
                    && _constructionWarrantyIncluded.Clean
                    && _contractNoApprovedByVA.Clean
                    && _creditScore.Clean
                    && _currentlyOnMilitaryDuty.Clean
                    && _dateAquiredLand.Clean
                    && _dateOfAssignment.Clean
                    && _dateSAR.Clean
                    && _disabilityAmountCollected.Clean
                    && _discountPercentage.Clean
                    && _discountPoint.Clean
                    && _dishwasherIndicator.Clean
                    && _dryerIndicator.Clean
                    && _emailToBeNotifiedWhenUploaded.Clean
                    && _energyImprovementsAdditionOfFeature.Clean
                    && _entitlementCode.Clean
                    && _equipmentOtherDescription.Clean
                    && _excludeTaxesInsuranceIndicator.Clean
                    && _finalDiscountAmount.Clean
                    && _finalFundingFeeAmount.Clean
                    && _firstChattelLoanType.Clean
                    && _firstTimeUse.Clean
                    && _fundingFeeExempt.Clean
                    && _garbageDisposalIndicator.Clean
                    && _id.Clean
                    && _initialTotal.Clean
                    && _inspectionWillBeMadeBy.Clean
                    && _insulation.Clean
                    && _insuranceType.Clean
                    && _irregularLotSizeInSquareFeet.Clean
                    && _isDelinquent30Days.Clean
                    && _keysAtAddress.Clean
                    && _landPurchasePrice.Clean
                    && _leaseholdType.Clean
                    && _lenderSAR.Clean
                    && _loanAnalysisRemarks1.Clean
                    && _loanAnalysisRemarks2.Clean
                    && _loanAnalysisRemarks3.Clean
                    && _loanAnalysisRemarks4.Clean
                    && _loanAnalysisRemarks5.Clean
                    && _loanAnalysisRemarks6.Clean
                    && _loanAnalysisRemarks7.Clean
                    && _loanAnalysisRemarks8.Clean
                    && _loanAnalysisRemarks9.Clean
                    && _loanCode.Clean
                    && _loanProcedure.Clean
                    && _loanProcessedUnderAU.Clean
                    && _loanSummaryRemarks1.Clean
                    && _loanSummaryRemarks2.Clean
                    && _loanSummaryRemarks3.Clean
                    && _loanSummaryRemarks4.Clean
                    && _loanSummaryRemarks5.Clean
                    && _loanSummaryRemarks6.Clean
                    && _loanSummaryRemarks7.Clean
                    && _loanSummaryRemarks8.Clean
                    && _lotDimensions.Clean
                    && _mailingAddress.Clean
                    && _mailingCity.Clean
                    && _mailingPostalCode.Clean
                    && _mailingState.Clean
                    && _manufacturedHome.Clean
                    && _mCRVNumber.Clean
                    && _militaryBranchOfService.Clean
                    && _militaryServices.Clean
                    && _mineralRightsReserved.Clean
                    && _nameOfOccupant.Clean
                    && _nameOfOwner.Clean
                    && _nameOfWarrantyProgram.Clean
                    && _negativeRents.Clean
                    && _noEnergyImprovements.Clean
                    && _nonrealtyDescription.Clean
                    && _numberOfBuildings.Clean
                    && _occupantTelephone.Clean
                    && _onMilitaryDutyFollowingSeparation.Clean
                    && _originalInterestRate.Clean
                    && _originalLoanAmount.Clean
                    && _originalTerm.Clean
                    && _originalValueEstimateChanged.Clean
                    && _originationFeeAmount.Clean
                    && _otherClosingCosts.Clean
                    && _otherDescriptionEstateProperty.Clean
                    && _otherDescriptionLoanType.Clean
                    && _otherEstateProperty.Clean
                    && _otherImprovements.Clean
                    && _otherLoanType.Clean
                    && _paidInFullVALoanNumber.Clean
                    && _payoffIndicator1.Clean
                    && _payoffIndicator2.Clean
                    && _payoffIndicator3.Clean
                    && _payoffIndicator4.Clean
                    && _payoffIndicator5.Clean
                    && _payoffIndicator6.Clean
                    && _payoffIndicator7.Clean
                    && _payoffIndicator8.Clean
                    && _payoffIndicator9.Clean
                    && _pestReportFee.Clean
                    && _plansSubmitted.Clean
                    && _pOCAddress.Clean
                    && _pOCCity.Clean
                    && _pOCName.Clean
                    && _pOCPhone.Clean
                    && _pOCState.Clean
                    && _pOCZipCode.Clean
                    && _preliminaryDiscountAmount.Clean
                    && _preliminaryFundingFeeAmount.Clean
                    && _preliminaryTotal.Clean
                    && _previousVALoanIndicator.Clean
                    && _previousVaLoans.Clean
                    && _priorApprovalProcedure.Clean
                    && _priorLoanType.Clean
                    && _propertyDesignation.Clean
                    && _propertyGrossLivingArea.Clean
                    && _propertyLegalDescription1.Clean
                    && _propertyLegalDescription2.Clean
                    && _propertyLegalDescription3.Clean
                    && _propertyLegalDescription4.Clean
                    && _propertyOccupancyType.Clean
                    && _proposedSaleContractAttached.Clean
                    && _purposeOfLoan.Clean
                    && _rangeOvenIndicator.Clean
                    && _reasonableValueCompleted.Clean
                    && _refrigeratorIndicator.Clean
                    && _rent.Clean
                    && _replacementOfSystem.Clean
                    && _riskClasification.Clean
                    && _serviceNumber.Clean
                    && _solarHeatingOrCooling.Clean
                    && _specialAssessmentComments1.Clean
                    && _specialAssessmentComments2.Clean
                    && _specialAssessmentComments3.Clean
                    && _streetAccess.Clean
                    && _streetMaintenance.Clean
                    && _systemUsed.Clean
                    && _title.Clean
                    && _titleLimitations1.Clean
                    && _titleLimitations2.Clean
                    && _titleLimitations3.Clean
                    && _totalBaths.Clean
                    && _totalBedrooms.Clean
                    && _totalDebtMonthlyPayment.Clean
                    && _totalDiscountPointCharged.Clean
                    && _totalDiscountPointsCharged.Clean
                    && _totalForMaxLoanAmount.Clean
                    && _totalMonthlyPayment.Clean
                    && _totalProposedMonthlyPayment.Clean
                    && _totalRooms.Clean
                    && _totalUnpaidSpecialAssessments.Clean
                    && _typeOfHybridARM.Clean
                    && _typeOfMortgage.Clean
                    && _typeOfOwnsership.Clean
                    && _typeOfStructure.Clean
                    && _typeOfVeteran.Clean
                    && _unsecuredLoanType.Clean
                    && _utilitiesElectricDescription.Clean
                    && _utilitiesGasDescription.Clean
                    && _utilitiesSewerDescription.Clean
                    && _utilitiesWaterDescription.Clean
                    && _vAAppraisalSentDate.Clean
                    && _vABenefitRelatedIndebtedness.Clean
                    && _vABuilderDescription.Clean
                    && _vABuilderIDNo.Clean
                    && _vAClaimFolderNumber.Clean
                    && _vAClaimNumber.Clean
                    && _vADateNOVAppraisalMailedToBorrower.Clean
                    && _vAIsDelinquent30Days.Clean
                    && _vALatePaymentIn6Months.Clean
                    && _vaLoanSummaryApplicantType.Clean
                    && _vANOVDateReceived.Clean
                    && _vANOVDateReviewed.Clean
                    && _vANOVIssuedDate.Clean
                    && _vAOriginalAmortizationType.Clean
                    && _vAOriginalMonthlyPayment.Clean
                    && _vAQualification2ndTierEntitlement.Clean
                    && _vAQualificationCountryRegion.Clean
                    && _vAQualificationCountyLimits.Clean
                    && _vARecoupmentClosingCosts.Clean
                    && _vARecoupmentExcludePrepaids.Clean
                    && _vARecoupmentMonthlyDecreaseInPayment.Clean
                    && _vARecoupmentMonths.Clean
                    && _vARecoupmentTotalClosingCosts.Clean
                    && _vARecoupmentYears.Clean
                    && _vATrackingCertOfCommitmentIssued.Clean
                    && _vATrackingCOEIssueDate.Clean
                    && _vATrackingCOEIssueHistory.Clean
                    && _vATrackingFinalApprovalCommitmentDate.Clean
                    && _vATrackingGSAExclusionaryListChecked.Clean
                    && _vATrackingInuranceFloodPolicy.Clean
                    && _vATrackingInuranceHazardPolicy.Clean
                    && _vATrackingInuranceWindOrHailPolicy.Clean
                    && _vATrackingInuranceWoodDestroyingPolicy.Clean
                    && _vATrackingIsSARLAPPCertified.Clean
                    && _vATrackingLoanGuaranteeCertReceipt.Clean
                    && _vATrackingMasterCommitmentLockExpired.Clean
                    && _vATrackingOrderedDate.Clean
                    && _vATrackingPaidDate.Clean
                    && _vATrackingPurchaseContractDate.Clean
                    && _vATrackingReceiptReceived.Clean
                    && _vATrackingSARID.Clean
                    && _vATrackingSARName.Clean
                    && _ventFanIndicator.Clean
                    && _veteranDischargedIndicator.Clean
                    && _veteranServiceType.Clean
                    && _warrantorAddress.Clean
                    && _warrantorCity.Clean
                    && _warrantorName.Clean
                    && _warrantorPhone.Clean
                    && _warrantorPostalCode.Clean
                    && _warrantorState.Clean
                    && _warrantyProgramExpirationDate.Clean
                    && _wWCarpetIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var acres = _acres; acres.Clean = value; _acres = acres;
                var additionalSecurityDescription = _additionalSecurityDescription; additionalSecurityDescription.Clean = value; _additionalSecurityDescription = additionalSecurityDescription;
                var administratorAddress = _administratorAddress; administratorAddress.Clean = value; _administratorAddress = administratorAddress;
                var administratorCity = _administratorCity; administratorCity.Clean = value; _administratorCity = administratorCity;
                var administratorContact = _administratorContact; administratorContact.Clean = value; _administratorContact = administratorContact;
                var administratorName = _administratorName; administratorName.Clean = value; _administratorName = administratorName;
                var administratorPostalCode = _administratorPostalCode; administratorPostalCode.Clean = value; _administratorPostalCode = administratorPostalCode;
                var administratorState = _administratorState; administratorState.Clean = value; _administratorState = administratorState;
                var ageOfProperty = _ageOfProperty; ageOfProperty.Clean = value; _ageOfProperty = ageOfProperty;
                var amountSpentOnEnergyImprovements = _amountSpentOnEnergyImprovements; amountSpentOnEnergyImprovements.Clean = value; _amountSpentOnEnergyImprovements = amountSpentOnEnergyImprovements;
                var amountTypeWithheld = _amountTypeWithheld; amountTypeWithheld.Clean = value; _amountTypeWithheld = amountTypeWithheld;
                var amountWithheld = _amountWithheld; amountWithheld.Clean = value; _amountWithheld = amountWithheld;
                var annualGroundRent = _annualGroundRent; annualGroundRent.Clean = value; _annualGroundRent = annualGroundRent;
                var annualMaintenanceAssessment = _annualMaintenanceAssessment; annualMaintenanceAssessment.Clean = value; _annualMaintenanceAssessment = annualMaintenanceAssessment;
                var annualRealEstateTaxes = _annualRealEstateTaxes; annualRealEstateTaxes.Clean = value; _annualRealEstateTaxes = annualRealEstateTaxes;
                var annualSpecialAssessment = _annualSpecialAssessment; annualSpecialAssessment.Clean = value; _annualSpecialAssessment = annualSpecialAssessment;
                var applicantAddressCity = _applicantAddressCity; applicantAddressCity.Clean = value; _applicantAddressCity = applicantAddressCity;
                var applicantAddressPostalCode = _applicantAddressPostalCode; applicantAddressPostalCode.Clean = value; _applicantAddressPostalCode = applicantAddressPostalCode;
                var applicantAddressState = _applicantAddressState; applicantAddressState.Clean = value; _applicantAddressState = applicantAddressState;
                var applicantAddressStreetLine1 = _applicantAddressStreetLine1; applicantAddressStreetLine1.Clean = value; _applicantAddressStreetLine1 = applicantAddressStreetLine1;
                var applicantBirthDate = _applicantBirthDate; applicantBirthDate.Clean = value; _applicantBirthDate = applicantBirthDate;
                var applicantEmailAddressText = _applicantEmailAddressText; applicantEmailAddressText.Clean = value; _applicantEmailAddressText = applicantEmailAddressText;
                var applicantFirstNameWithMiddleName = _applicantFirstNameWithMiddleName; applicantFirstNameWithMiddleName.Clean = value; _applicantFirstNameWithMiddleName = applicantFirstNameWithMiddleName;
                var applicantHmdaGenderType = _applicantHmdaGenderType; applicantHmdaGenderType.Clean = value; _applicantHmdaGenderType = applicantHmdaGenderType;
                var applicantHomePhoneNumber = _applicantHomePhoneNumber; applicantHomePhoneNumber.Clean = value; _applicantHomePhoneNumber = applicantHomePhoneNumber;
                var applicantLastNameWithSuffix = _applicantLastNameWithSuffix; applicantLastNameWithSuffix.Clean = value; _applicantLastNameWithSuffix = applicantLastNameWithSuffix;
                var applicantTaxIdentificationIdentifier = _applicantTaxIdentificationIdentifier; applicantTaxIdentificationIdentifier.Clean = value; _applicantTaxIdentificationIdentifier = applicantTaxIdentificationIdentifier;
                var appraisalType = _appraisalType; appraisalType.Clean = value; _appraisalType = appraisalType;
                var automaticProcedure = _automaticProcedure; automaticProcedure.Clean = value; _automaticProcedure = automaticProcedure;
                var availableForInspectionAMIndicator = _availableForInspectionAMIndicator; availableForInspectionAMIndicator.Clean = value; _availableForInspectionAMIndicator = availableForInspectionAMIndicator;
                var availableForInspectionDateAndTime = _availableForInspectionDateAndTime; availableForInspectionDateAndTime.Clean = value; _availableForInspectionDateAndTime = availableForInspectionDateAndTime;
                var borrowerPaidDiscountPointsTotalAmount = _borrowerPaidDiscountPointsTotalAmount; borrowerPaidDiscountPointsTotalAmount.Clean = value; _borrowerPaidDiscountPointsTotalAmount = borrowerPaidDiscountPointsTotalAmount;
                var buildingType = _buildingType; buildingType.Clean = value; _buildingType = buildingType;
                var buyerPurchasingLotSeparately = _buyerPurchasingLotSeparately; buyerPurchasingLotSeparately.Clean = value; _buyerPurchasingLotSeparately = buyerPurchasingLotSeparately;
                var cashPaymentFromVeteran = _cashPaymentFromVeteran; cashPaymentFromVeteran.Clean = value; _cashPaymentFromVeteran = cashPaymentFromVeteran;
                var claimDisabilityBenefits = _claimDisabilityBenefits; claimDisabilityBenefits.Clean = value; _claimDisabilityBenefits = claimDisabilityBenefits;
                var clothesWasherIndicator = _clothesWasherIndicator; clothesWasherIndicator.Clean = value; _clothesWasherIndicator = clothesWasherIndicator;
                var constructionCompletedDate = _constructionCompletedDate; constructionCompletedDate.Clean = value; _constructionCompletedDate = constructionCompletedDate;
                var constructionPlan = _constructionPlan; constructionPlan.Clean = value; _constructionPlan = constructionPlan;
                var constructionWarrantyIncluded = _constructionWarrantyIncluded; constructionWarrantyIncluded.Clean = value; _constructionWarrantyIncluded = constructionWarrantyIncluded;
                var contractNoApprovedByVA = _contractNoApprovedByVA; contractNoApprovedByVA.Clean = value; _contractNoApprovedByVA = contractNoApprovedByVA;
                var creditScore = _creditScore; creditScore.Clean = value; _creditScore = creditScore;
                var currentlyOnMilitaryDuty = _currentlyOnMilitaryDuty; currentlyOnMilitaryDuty.Clean = value; _currentlyOnMilitaryDuty = currentlyOnMilitaryDuty;
                var dateAquiredLand = _dateAquiredLand; dateAquiredLand.Clean = value; _dateAquiredLand = dateAquiredLand;
                var dateOfAssignment = _dateOfAssignment; dateOfAssignment.Clean = value; _dateOfAssignment = dateOfAssignment;
                var dateSAR = _dateSAR; dateSAR.Clean = value; _dateSAR = dateSAR;
                var disabilityAmountCollected = _disabilityAmountCollected; disabilityAmountCollected.Clean = value; _disabilityAmountCollected = disabilityAmountCollected;
                var discountPercentage = _discountPercentage; discountPercentage.Clean = value; _discountPercentage = discountPercentage;
                var discountPoint = _discountPoint; discountPoint.Clean = value; _discountPoint = discountPoint;
                var dishwasherIndicator = _dishwasherIndicator; dishwasherIndicator.Clean = value; _dishwasherIndicator = dishwasherIndicator;
                var dryerIndicator = _dryerIndicator; dryerIndicator.Clean = value; _dryerIndicator = dryerIndicator;
                var emailToBeNotifiedWhenUploaded = _emailToBeNotifiedWhenUploaded; emailToBeNotifiedWhenUploaded.Clean = value; _emailToBeNotifiedWhenUploaded = emailToBeNotifiedWhenUploaded;
                var energyImprovementsAdditionOfFeature = _energyImprovementsAdditionOfFeature; energyImprovementsAdditionOfFeature.Clean = value; _energyImprovementsAdditionOfFeature = energyImprovementsAdditionOfFeature;
                var entitlementCode = _entitlementCode; entitlementCode.Clean = value; _entitlementCode = entitlementCode;
                var equipmentOtherDescription = _equipmentOtherDescription; equipmentOtherDescription.Clean = value; _equipmentOtherDescription = equipmentOtherDescription;
                var excludeTaxesInsuranceIndicator = _excludeTaxesInsuranceIndicator; excludeTaxesInsuranceIndicator.Clean = value; _excludeTaxesInsuranceIndicator = excludeTaxesInsuranceIndicator;
                var finalDiscountAmount = _finalDiscountAmount; finalDiscountAmount.Clean = value; _finalDiscountAmount = finalDiscountAmount;
                var finalFundingFeeAmount = _finalFundingFeeAmount; finalFundingFeeAmount.Clean = value; _finalFundingFeeAmount = finalFundingFeeAmount;
                var firstChattelLoanType = _firstChattelLoanType; firstChattelLoanType.Clean = value; _firstChattelLoanType = firstChattelLoanType;
                var firstTimeUse = _firstTimeUse; firstTimeUse.Clean = value; _firstTimeUse = firstTimeUse;
                var fundingFeeExempt = _fundingFeeExempt; fundingFeeExempt.Clean = value; _fundingFeeExempt = fundingFeeExempt;
                var garbageDisposalIndicator = _garbageDisposalIndicator; garbageDisposalIndicator.Clean = value; _garbageDisposalIndicator = garbageDisposalIndicator;
                var id = _id; id.Clean = value; _id = id;
                var initialTotal = _initialTotal; initialTotal.Clean = value; _initialTotal = initialTotal;
                var inspectionWillBeMadeBy = _inspectionWillBeMadeBy; inspectionWillBeMadeBy.Clean = value; _inspectionWillBeMadeBy = inspectionWillBeMadeBy;
                var insulation = _insulation; insulation.Clean = value; _insulation = insulation;
                var insuranceType = _insuranceType; insuranceType.Clean = value; _insuranceType = insuranceType;
                var irregularLotSizeInSquareFeet = _irregularLotSizeInSquareFeet; irregularLotSizeInSquareFeet.Clean = value; _irregularLotSizeInSquareFeet = irregularLotSizeInSquareFeet;
                var isDelinquent30Days = _isDelinquent30Days; isDelinquent30Days.Clean = value; _isDelinquent30Days = isDelinquent30Days;
                var keysAtAddress = _keysAtAddress; keysAtAddress.Clean = value; _keysAtAddress = keysAtAddress;
                var landPurchasePrice = _landPurchasePrice; landPurchasePrice.Clean = value; _landPurchasePrice = landPurchasePrice;
                var leaseholdType = _leaseholdType; leaseholdType.Clean = value; _leaseholdType = leaseholdType;
                var lenderSAR = _lenderSAR; lenderSAR.Clean = value; _lenderSAR = lenderSAR;
                var loanAnalysisRemarks1 = _loanAnalysisRemarks1; loanAnalysisRemarks1.Clean = value; _loanAnalysisRemarks1 = loanAnalysisRemarks1;
                var loanAnalysisRemarks2 = _loanAnalysisRemarks2; loanAnalysisRemarks2.Clean = value; _loanAnalysisRemarks2 = loanAnalysisRemarks2;
                var loanAnalysisRemarks3 = _loanAnalysisRemarks3; loanAnalysisRemarks3.Clean = value; _loanAnalysisRemarks3 = loanAnalysisRemarks3;
                var loanAnalysisRemarks4 = _loanAnalysisRemarks4; loanAnalysisRemarks4.Clean = value; _loanAnalysisRemarks4 = loanAnalysisRemarks4;
                var loanAnalysisRemarks5 = _loanAnalysisRemarks5; loanAnalysisRemarks5.Clean = value; _loanAnalysisRemarks5 = loanAnalysisRemarks5;
                var loanAnalysisRemarks6 = _loanAnalysisRemarks6; loanAnalysisRemarks6.Clean = value; _loanAnalysisRemarks6 = loanAnalysisRemarks6;
                var loanAnalysisRemarks7 = _loanAnalysisRemarks7; loanAnalysisRemarks7.Clean = value; _loanAnalysisRemarks7 = loanAnalysisRemarks7;
                var loanAnalysisRemarks8 = _loanAnalysisRemarks8; loanAnalysisRemarks8.Clean = value; _loanAnalysisRemarks8 = loanAnalysisRemarks8;
                var loanAnalysisRemarks9 = _loanAnalysisRemarks9; loanAnalysisRemarks9.Clean = value; _loanAnalysisRemarks9 = loanAnalysisRemarks9;
                var loanCode = _loanCode; loanCode.Clean = value; _loanCode = loanCode;
                var loanProcedure = _loanProcedure; loanProcedure.Clean = value; _loanProcedure = loanProcedure;
                var loanProcessedUnderAU = _loanProcessedUnderAU; loanProcessedUnderAU.Clean = value; _loanProcessedUnderAU = loanProcessedUnderAU;
                var loanSummaryRemarks1 = _loanSummaryRemarks1; loanSummaryRemarks1.Clean = value; _loanSummaryRemarks1 = loanSummaryRemarks1;
                var loanSummaryRemarks2 = _loanSummaryRemarks2; loanSummaryRemarks2.Clean = value; _loanSummaryRemarks2 = loanSummaryRemarks2;
                var loanSummaryRemarks3 = _loanSummaryRemarks3; loanSummaryRemarks3.Clean = value; _loanSummaryRemarks3 = loanSummaryRemarks3;
                var loanSummaryRemarks4 = _loanSummaryRemarks4; loanSummaryRemarks4.Clean = value; _loanSummaryRemarks4 = loanSummaryRemarks4;
                var loanSummaryRemarks5 = _loanSummaryRemarks5; loanSummaryRemarks5.Clean = value; _loanSummaryRemarks5 = loanSummaryRemarks5;
                var loanSummaryRemarks6 = _loanSummaryRemarks6; loanSummaryRemarks6.Clean = value; _loanSummaryRemarks6 = loanSummaryRemarks6;
                var loanSummaryRemarks7 = _loanSummaryRemarks7; loanSummaryRemarks7.Clean = value; _loanSummaryRemarks7 = loanSummaryRemarks7;
                var loanSummaryRemarks8 = _loanSummaryRemarks8; loanSummaryRemarks8.Clean = value; _loanSummaryRemarks8 = loanSummaryRemarks8;
                var lotDimensions = _lotDimensions; lotDimensions.Clean = value; _lotDimensions = lotDimensions;
                var mailingAddress = _mailingAddress; mailingAddress.Clean = value; _mailingAddress = mailingAddress;
                var mailingCity = _mailingCity; mailingCity.Clean = value; _mailingCity = mailingCity;
                var mailingPostalCode = _mailingPostalCode; mailingPostalCode.Clean = value; _mailingPostalCode = mailingPostalCode;
                var mailingState = _mailingState; mailingState.Clean = value; _mailingState = mailingState;
                var manufacturedHome = _manufacturedHome; manufacturedHome.Clean = value; _manufacturedHome = manufacturedHome;
                var mCRVNumber = _mCRVNumber; mCRVNumber.Clean = value; _mCRVNumber = mCRVNumber;
                var militaryBranchOfService = _militaryBranchOfService; militaryBranchOfService.Clean = value; _militaryBranchOfService = militaryBranchOfService;
                var militaryServices = _militaryServices; militaryServices.Clean = value; _militaryServices = militaryServices;
                var mineralRightsReserved = _mineralRightsReserved; mineralRightsReserved.Clean = value; _mineralRightsReserved = mineralRightsReserved;
                var nameOfOccupant = _nameOfOccupant; nameOfOccupant.Clean = value; _nameOfOccupant = nameOfOccupant;
                var nameOfOwner = _nameOfOwner; nameOfOwner.Clean = value; _nameOfOwner = nameOfOwner;
                var nameOfWarrantyProgram = _nameOfWarrantyProgram; nameOfWarrantyProgram.Clean = value; _nameOfWarrantyProgram = nameOfWarrantyProgram;
                var negativeRents = _negativeRents; negativeRents.Clean = value; _negativeRents = negativeRents;
                var noEnergyImprovements = _noEnergyImprovements; noEnergyImprovements.Clean = value; _noEnergyImprovements = noEnergyImprovements;
                var nonrealtyDescription = _nonrealtyDescription; nonrealtyDescription.Clean = value; _nonrealtyDescription = nonrealtyDescription;
                var numberOfBuildings = _numberOfBuildings; numberOfBuildings.Clean = value; _numberOfBuildings = numberOfBuildings;
                var occupantTelephone = _occupantTelephone; occupantTelephone.Clean = value; _occupantTelephone = occupantTelephone;
                var onMilitaryDutyFollowingSeparation = _onMilitaryDutyFollowingSeparation; onMilitaryDutyFollowingSeparation.Clean = value; _onMilitaryDutyFollowingSeparation = onMilitaryDutyFollowingSeparation;
                var originalInterestRate = _originalInterestRate; originalInterestRate.Clean = value; _originalInterestRate = originalInterestRate;
                var originalLoanAmount = _originalLoanAmount; originalLoanAmount.Clean = value; _originalLoanAmount = originalLoanAmount;
                var originalTerm = _originalTerm; originalTerm.Clean = value; _originalTerm = originalTerm;
                var originalValueEstimateChanged = _originalValueEstimateChanged; originalValueEstimateChanged.Clean = value; _originalValueEstimateChanged = originalValueEstimateChanged;
                var originationFeeAmount = _originationFeeAmount; originationFeeAmount.Clean = value; _originationFeeAmount = originationFeeAmount;
                var otherClosingCosts = _otherClosingCosts; otherClosingCosts.Clean = value; _otherClosingCosts = otherClosingCosts;
                var otherDescriptionEstateProperty = _otherDescriptionEstateProperty; otherDescriptionEstateProperty.Clean = value; _otherDescriptionEstateProperty = otherDescriptionEstateProperty;
                var otherDescriptionLoanType = _otherDescriptionLoanType; otherDescriptionLoanType.Clean = value; _otherDescriptionLoanType = otherDescriptionLoanType;
                var otherEstateProperty = _otherEstateProperty; otherEstateProperty.Clean = value; _otherEstateProperty = otherEstateProperty;
                var otherImprovements = _otherImprovements; otherImprovements.Clean = value; _otherImprovements = otherImprovements;
                var otherLoanType = _otherLoanType; otherLoanType.Clean = value; _otherLoanType = otherLoanType;
                var paidInFullVALoanNumber = _paidInFullVALoanNumber; paidInFullVALoanNumber.Clean = value; _paidInFullVALoanNumber = paidInFullVALoanNumber;
                var payoffIndicator1 = _payoffIndicator1; payoffIndicator1.Clean = value; _payoffIndicator1 = payoffIndicator1;
                var payoffIndicator2 = _payoffIndicator2; payoffIndicator2.Clean = value; _payoffIndicator2 = payoffIndicator2;
                var payoffIndicator3 = _payoffIndicator3; payoffIndicator3.Clean = value; _payoffIndicator3 = payoffIndicator3;
                var payoffIndicator4 = _payoffIndicator4; payoffIndicator4.Clean = value; _payoffIndicator4 = payoffIndicator4;
                var payoffIndicator5 = _payoffIndicator5; payoffIndicator5.Clean = value; _payoffIndicator5 = payoffIndicator5;
                var payoffIndicator6 = _payoffIndicator6; payoffIndicator6.Clean = value; _payoffIndicator6 = payoffIndicator6;
                var payoffIndicator7 = _payoffIndicator7; payoffIndicator7.Clean = value; _payoffIndicator7 = payoffIndicator7;
                var payoffIndicator8 = _payoffIndicator8; payoffIndicator8.Clean = value; _payoffIndicator8 = payoffIndicator8;
                var payoffIndicator9 = _payoffIndicator9; payoffIndicator9.Clean = value; _payoffIndicator9 = payoffIndicator9;
                var pestReportFee = _pestReportFee; pestReportFee.Clean = value; _pestReportFee = pestReportFee;
                var plansSubmitted = _plansSubmitted; plansSubmitted.Clean = value; _plansSubmitted = plansSubmitted;
                var pOCAddress = _pOCAddress; pOCAddress.Clean = value; _pOCAddress = pOCAddress;
                var pOCCity = _pOCCity; pOCCity.Clean = value; _pOCCity = pOCCity;
                var pOCName = _pOCName; pOCName.Clean = value; _pOCName = pOCName;
                var pOCPhone = _pOCPhone; pOCPhone.Clean = value; _pOCPhone = pOCPhone;
                var pOCState = _pOCState; pOCState.Clean = value; _pOCState = pOCState;
                var pOCZipCode = _pOCZipCode; pOCZipCode.Clean = value; _pOCZipCode = pOCZipCode;
                var preliminaryDiscountAmount = _preliminaryDiscountAmount; preliminaryDiscountAmount.Clean = value; _preliminaryDiscountAmount = preliminaryDiscountAmount;
                var preliminaryFundingFeeAmount = _preliminaryFundingFeeAmount; preliminaryFundingFeeAmount.Clean = value; _preliminaryFundingFeeAmount = preliminaryFundingFeeAmount;
                var preliminaryTotal = _preliminaryTotal; preliminaryTotal.Clean = value; _preliminaryTotal = preliminaryTotal;
                var previousVALoanIndicator = _previousVALoanIndicator; previousVALoanIndicator.Clean = value; _previousVALoanIndicator = previousVALoanIndicator;
                var previousVaLoans = _previousVaLoans; previousVaLoans.Clean = value; _previousVaLoans = previousVaLoans;
                var priorApprovalProcedure = _priorApprovalProcedure; priorApprovalProcedure.Clean = value; _priorApprovalProcedure = priorApprovalProcedure;
                var priorLoanType = _priorLoanType; priorLoanType.Clean = value; _priorLoanType = priorLoanType;
                var propertyDesignation = _propertyDesignation; propertyDesignation.Clean = value; _propertyDesignation = propertyDesignation;
                var propertyGrossLivingArea = _propertyGrossLivingArea; propertyGrossLivingArea.Clean = value; _propertyGrossLivingArea = propertyGrossLivingArea;
                var propertyLegalDescription1 = _propertyLegalDescription1; propertyLegalDescription1.Clean = value; _propertyLegalDescription1 = propertyLegalDescription1;
                var propertyLegalDescription2 = _propertyLegalDescription2; propertyLegalDescription2.Clean = value; _propertyLegalDescription2 = propertyLegalDescription2;
                var propertyLegalDescription3 = _propertyLegalDescription3; propertyLegalDescription3.Clean = value; _propertyLegalDescription3 = propertyLegalDescription3;
                var propertyLegalDescription4 = _propertyLegalDescription4; propertyLegalDescription4.Clean = value; _propertyLegalDescription4 = propertyLegalDescription4;
                var propertyOccupancyType = _propertyOccupancyType; propertyOccupancyType.Clean = value; _propertyOccupancyType = propertyOccupancyType;
                var proposedSaleContractAttached = _proposedSaleContractAttached; proposedSaleContractAttached.Clean = value; _proposedSaleContractAttached = proposedSaleContractAttached;
                var purposeOfLoan = _purposeOfLoan; purposeOfLoan.Clean = value; _purposeOfLoan = purposeOfLoan;
                var rangeOvenIndicator = _rangeOvenIndicator; rangeOvenIndicator.Clean = value; _rangeOvenIndicator = rangeOvenIndicator;
                var reasonableValueCompleted = _reasonableValueCompleted; reasonableValueCompleted.Clean = value; _reasonableValueCompleted = reasonableValueCompleted;
                var refrigeratorIndicator = _refrigeratorIndicator; refrigeratorIndicator.Clean = value; _refrigeratorIndicator = refrigeratorIndicator;
                var rent = _rent; rent.Clean = value; _rent = rent;
                var replacementOfSystem = _replacementOfSystem; replacementOfSystem.Clean = value; _replacementOfSystem = replacementOfSystem;
                var riskClasification = _riskClasification; riskClasification.Clean = value; _riskClasification = riskClasification;
                var serviceNumber = _serviceNumber; serviceNumber.Clean = value; _serviceNumber = serviceNumber;
                var solarHeatingOrCooling = _solarHeatingOrCooling; solarHeatingOrCooling.Clean = value; _solarHeatingOrCooling = solarHeatingOrCooling;
                var specialAssessmentComments1 = _specialAssessmentComments1; specialAssessmentComments1.Clean = value; _specialAssessmentComments1 = specialAssessmentComments1;
                var specialAssessmentComments2 = _specialAssessmentComments2; specialAssessmentComments2.Clean = value; _specialAssessmentComments2 = specialAssessmentComments2;
                var specialAssessmentComments3 = _specialAssessmentComments3; specialAssessmentComments3.Clean = value; _specialAssessmentComments3 = specialAssessmentComments3;
                var streetAccess = _streetAccess; streetAccess.Clean = value; _streetAccess = streetAccess;
                var streetMaintenance = _streetMaintenance; streetMaintenance.Clean = value; _streetMaintenance = streetMaintenance;
                var systemUsed = _systemUsed; systemUsed.Clean = value; _systemUsed = systemUsed;
                var title = _title; title.Clean = value; _title = title;
                var titleLimitations1 = _titleLimitations1; titleLimitations1.Clean = value; _titleLimitations1 = titleLimitations1;
                var titleLimitations2 = _titleLimitations2; titleLimitations2.Clean = value; _titleLimitations2 = titleLimitations2;
                var titleLimitations3 = _titleLimitations3; titleLimitations3.Clean = value; _titleLimitations3 = titleLimitations3;
                var totalBaths = _totalBaths; totalBaths.Clean = value; _totalBaths = totalBaths;
                var totalBedrooms = _totalBedrooms; totalBedrooms.Clean = value; _totalBedrooms = totalBedrooms;
                var totalDebtMonthlyPayment = _totalDebtMonthlyPayment; totalDebtMonthlyPayment.Clean = value; _totalDebtMonthlyPayment = totalDebtMonthlyPayment;
                var totalDiscountPointCharged = _totalDiscountPointCharged; totalDiscountPointCharged.Clean = value; _totalDiscountPointCharged = totalDiscountPointCharged;
                var totalDiscountPointsCharged = _totalDiscountPointsCharged; totalDiscountPointsCharged.Clean = value; _totalDiscountPointsCharged = totalDiscountPointsCharged;
                var totalForMaxLoanAmount = _totalForMaxLoanAmount; totalForMaxLoanAmount.Clean = value; _totalForMaxLoanAmount = totalForMaxLoanAmount;
                var totalMonthlyPayment = _totalMonthlyPayment; totalMonthlyPayment.Clean = value; _totalMonthlyPayment = totalMonthlyPayment;
                var totalProposedMonthlyPayment = _totalProposedMonthlyPayment; totalProposedMonthlyPayment.Clean = value; _totalProposedMonthlyPayment = totalProposedMonthlyPayment;
                var totalRooms = _totalRooms; totalRooms.Clean = value; _totalRooms = totalRooms;
                var totalUnpaidSpecialAssessments = _totalUnpaidSpecialAssessments; totalUnpaidSpecialAssessments.Clean = value; _totalUnpaidSpecialAssessments = totalUnpaidSpecialAssessments;
                var typeOfHybridARM = _typeOfHybridARM; typeOfHybridARM.Clean = value; _typeOfHybridARM = typeOfHybridARM;
                var typeOfMortgage = _typeOfMortgage; typeOfMortgage.Clean = value; _typeOfMortgage = typeOfMortgage;
                var typeOfOwnsership = _typeOfOwnsership; typeOfOwnsership.Clean = value; _typeOfOwnsership = typeOfOwnsership;
                var typeOfStructure = _typeOfStructure; typeOfStructure.Clean = value; _typeOfStructure = typeOfStructure;
                var typeOfVeteran = _typeOfVeteran; typeOfVeteran.Clean = value; _typeOfVeteran = typeOfVeteran;
                var unsecuredLoanType = _unsecuredLoanType; unsecuredLoanType.Clean = value; _unsecuredLoanType = unsecuredLoanType;
                var utilitiesElectricDescription = _utilitiesElectricDescription; utilitiesElectricDescription.Clean = value; _utilitiesElectricDescription = utilitiesElectricDescription;
                var utilitiesGasDescription = _utilitiesGasDescription; utilitiesGasDescription.Clean = value; _utilitiesGasDescription = utilitiesGasDescription;
                var utilitiesSewerDescription = _utilitiesSewerDescription; utilitiesSewerDescription.Clean = value; _utilitiesSewerDescription = utilitiesSewerDescription;
                var utilitiesWaterDescription = _utilitiesWaterDescription; utilitiesWaterDescription.Clean = value; _utilitiesWaterDescription = utilitiesWaterDescription;
                var vAAppraisalSentDate = _vAAppraisalSentDate; vAAppraisalSentDate.Clean = value; _vAAppraisalSentDate = vAAppraisalSentDate;
                var vABenefitRelatedIndebtedness = _vABenefitRelatedIndebtedness; vABenefitRelatedIndebtedness.Clean = value; _vABenefitRelatedIndebtedness = vABenefitRelatedIndebtedness;
                var vABuilderDescription = _vABuilderDescription; vABuilderDescription.Clean = value; _vABuilderDescription = vABuilderDescription;
                var vABuilderIDNo = _vABuilderIDNo; vABuilderIDNo.Clean = value; _vABuilderIDNo = vABuilderIDNo;
                var vAClaimFolderNumber = _vAClaimFolderNumber; vAClaimFolderNumber.Clean = value; _vAClaimFolderNumber = vAClaimFolderNumber;
                var vAClaimNumber = _vAClaimNumber; vAClaimNumber.Clean = value; _vAClaimNumber = vAClaimNumber;
                var vADateNOVAppraisalMailedToBorrower = _vADateNOVAppraisalMailedToBorrower; vADateNOVAppraisalMailedToBorrower.Clean = value; _vADateNOVAppraisalMailedToBorrower = vADateNOVAppraisalMailedToBorrower;
                var vAIsDelinquent30Days = _vAIsDelinquent30Days; vAIsDelinquent30Days.Clean = value; _vAIsDelinquent30Days = vAIsDelinquent30Days;
                var vALatePaymentIn6Months = _vALatePaymentIn6Months; vALatePaymentIn6Months.Clean = value; _vALatePaymentIn6Months = vALatePaymentIn6Months;
                var vaLoanSummaryApplicantType = _vaLoanSummaryApplicantType; vaLoanSummaryApplicantType.Clean = value; _vaLoanSummaryApplicantType = vaLoanSummaryApplicantType;
                var vANOVDateReceived = _vANOVDateReceived; vANOVDateReceived.Clean = value; _vANOVDateReceived = vANOVDateReceived;
                var vANOVDateReviewed = _vANOVDateReviewed; vANOVDateReviewed.Clean = value; _vANOVDateReviewed = vANOVDateReviewed;
                var vANOVIssuedDate = _vANOVIssuedDate; vANOVIssuedDate.Clean = value; _vANOVIssuedDate = vANOVIssuedDate;
                var vAOriginalAmortizationType = _vAOriginalAmortizationType; vAOriginalAmortizationType.Clean = value; _vAOriginalAmortizationType = vAOriginalAmortizationType;
                var vAOriginalMonthlyPayment = _vAOriginalMonthlyPayment; vAOriginalMonthlyPayment.Clean = value; _vAOriginalMonthlyPayment = vAOriginalMonthlyPayment;
                var vAQualification2ndTierEntitlement = _vAQualification2ndTierEntitlement; vAQualification2ndTierEntitlement.Clean = value; _vAQualification2ndTierEntitlement = vAQualification2ndTierEntitlement;
                var vAQualificationCountryRegion = _vAQualificationCountryRegion; vAQualificationCountryRegion.Clean = value; _vAQualificationCountryRegion = vAQualificationCountryRegion;
                var vAQualificationCountyLimits = _vAQualificationCountyLimits; vAQualificationCountyLimits.Clean = value; _vAQualificationCountyLimits = vAQualificationCountyLimits;
                var vARecoupmentClosingCosts = _vARecoupmentClosingCosts; vARecoupmentClosingCosts.Clean = value; _vARecoupmentClosingCosts = vARecoupmentClosingCosts;
                var vARecoupmentExcludePrepaids = _vARecoupmentExcludePrepaids; vARecoupmentExcludePrepaids.Clean = value; _vARecoupmentExcludePrepaids = vARecoupmentExcludePrepaids;
                var vARecoupmentMonthlyDecreaseInPayment = _vARecoupmentMonthlyDecreaseInPayment; vARecoupmentMonthlyDecreaseInPayment.Clean = value; _vARecoupmentMonthlyDecreaseInPayment = vARecoupmentMonthlyDecreaseInPayment;
                var vARecoupmentMonths = _vARecoupmentMonths; vARecoupmentMonths.Clean = value; _vARecoupmentMonths = vARecoupmentMonths;
                var vARecoupmentTotalClosingCosts = _vARecoupmentTotalClosingCosts; vARecoupmentTotalClosingCosts.Clean = value; _vARecoupmentTotalClosingCosts = vARecoupmentTotalClosingCosts;
                var vARecoupmentYears = _vARecoupmentYears; vARecoupmentYears.Clean = value; _vARecoupmentYears = vARecoupmentYears;
                var vATrackingCertOfCommitmentIssued = _vATrackingCertOfCommitmentIssued; vATrackingCertOfCommitmentIssued.Clean = value; _vATrackingCertOfCommitmentIssued = vATrackingCertOfCommitmentIssued;
                var vATrackingCOEIssueDate = _vATrackingCOEIssueDate; vATrackingCOEIssueDate.Clean = value; _vATrackingCOEIssueDate = vATrackingCOEIssueDate;
                var vATrackingCOEIssueHistory = _vATrackingCOEIssueHistory; vATrackingCOEIssueHistory.Clean = value; _vATrackingCOEIssueHistory = vATrackingCOEIssueHistory;
                var vATrackingFinalApprovalCommitmentDate = _vATrackingFinalApprovalCommitmentDate; vATrackingFinalApprovalCommitmentDate.Clean = value; _vATrackingFinalApprovalCommitmentDate = vATrackingFinalApprovalCommitmentDate;
                var vATrackingGSAExclusionaryListChecked = _vATrackingGSAExclusionaryListChecked; vATrackingGSAExclusionaryListChecked.Clean = value; _vATrackingGSAExclusionaryListChecked = vATrackingGSAExclusionaryListChecked;
                var vATrackingInuranceFloodPolicy = _vATrackingInuranceFloodPolicy; vATrackingInuranceFloodPolicy.Clean = value; _vATrackingInuranceFloodPolicy = vATrackingInuranceFloodPolicy;
                var vATrackingInuranceHazardPolicy = _vATrackingInuranceHazardPolicy; vATrackingInuranceHazardPolicy.Clean = value; _vATrackingInuranceHazardPolicy = vATrackingInuranceHazardPolicy;
                var vATrackingInuranceWindOrHailPolicy = _vATrackingInuranceWindOrHailPolicy; vATrackingInuranceWindOrHailPolicy.Clean = value; _vATrackingInuranceWindOrHailPolicy = vATrackingInuranceWindOrHailPolicy;
                var vATrackingInuranceWoodDestroyingPolicy = _vATrackingInuranceWoodDestroyingPolicy; vATrackingInuranceWoodDestroyingPolicy.Clean = value; _vATrackingInuranceWoodDestroyingPolicy = vATrackingInuranceWoodDestroyingPolicy;
                var vATrackingIsSARLAPPCertified = _vATrackingIsSARLAPPCertified; vATrackingIsSARLAPPCertified.Clean = value; _vATrackingIsSARLAPPCertified = vATrackingIsSARLAPPCertified;
                var vATrackingLoanGuaranteeCertReceipt = _vATrackingLoanGuaranteeCertReceipt; vATrackingLoanGuaranteeCertReceipt.Clean = value; _vATrackingLoanGuaranteeCertReceipt = vATrackingLoanGuaranteeCertReceipt;
                var vATrackingMasterCommitmentLockExpired = _vATrackingMasterCommitmentLockExpired; vATrackingMasterCommitmentLockExpired.Clean = value; _vATrackingMasterCommitmentLockExpired = vATrackingMasterCommitmentLockExpired;
                var vATrackingOrderedDate = _vATrackingOrderedDate; vATrackingOrderedDate.Clean = value; _vATrackingOrderedDate = vATrackingOrderedDate;
                var vATrackingPaidDate = _vATrackingPaidDate; vATrackingPaidDate.Clean = value; _vATrackingPaidDate = vATrackingPaidDate;
                var vATrackingPurchaseContractDate = _vATrackingPurchaseContractDate; vATrackingPurchaseContractDate.Clean = value; _vATrackingPurchaseContractDate = vATrackingPurchaseContractDate;
                var vATrackingReceiptReceived = _vATrackingReceiptReceived; vATrackingReceiptReceived.Clean = value; _vATrackingReceiptReceived = vATrackingReceiptReceived;
                var vATrackingSARID = _vATrackingSARID; vATrackingSARID.Clean = value; _vATrackingSARID = vATrackingSARID;
                var vATrackingSARName = _vATrackingSARName; vATrackingSARName.Clean = value; _vATrackingSARName = vATrackingSARName;
                var ventFanIndicator = _ventFanIndicator; ventFanIndicator.Clean = value; _ventFanIndicator = ventFanIndicator;
                var veteranDischargedIndicator = _veteranDischargedIndicator; veteranDischargedIndicator.Clean = value; _veteranDischargedIndicator = veteranDischargedIndicator;
                var veteranServiceType = _veteranServiceType; veteranServiceType.Clean = value; _veteranServiceType = veteranServiceType;
                var warrantorAddress = _warrantorAddress; warrantorAddress.Clean = value; _warrantorAddress = warrantorAddress;
                var warrantorCity = _warrantorCity; warrantorCity.Clean = value; _warrantorCity = warrantorCity;
                var warrantorName = _warrantorName; warrantorName.Clean = value; _warrantorName = warrantorName;
                var warrantorPhone = _warrantorPhone; warrantorPhone.Clean = value; _warrantorPhone = warrantorPhone;
                var warrantorPostalCode = _warrantorPostalCode; warrantorPostalCode.Clean = value; _warrantorPostalCode = warrantorPostalCode;
                var warrantorState = _warrantorState; warrantorState.Clean = value; _warrantorState = warrantorState;
                var warrantyProgramExpirationDate = _warrantyProgramExpirationDate; warrantyProgramExpirationDate.Clean = value; _warrantyProgramExpirationDate = warrantyProgramExpirationDate;
                var wWCarpetIndicator = _wWCarpetIndicator; wWCarpetIndicator.Clean = value; _wWCarpetIndicator = wWCarpetIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public VaLoanData()
        {
            Clean = true;
        }
    }
}