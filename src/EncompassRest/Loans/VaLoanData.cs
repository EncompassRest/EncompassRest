using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class VaLoanData : IDirty
    {
        private DirtyValue<decimal?> _acres;
        public decimal? Acres { get { return _acres; } set { _acres = value; } }
        private DirtyValue<string> _additionalSecurityDescription;
        public string AdditionalSecurityDescription { get { return _additionalSecurityDescription; } set { _additionalSecurityDescription = value; } }
        private DirtyValue<string> _administratorAddress;
        public string AdministratorAddress { get { return _administratorAddress; } set { _administratorAddress = value; } }
        private DirtyValue<string> _administratorCity;
        public string AdministratorCity { get { return _administratorCity; } set { _administratorCity = value; } }
        private DirtyValue<string> _administratorContact;
        public string AdministratorContact { get { return _administratorContact; } set { _administratorContact = value; } }
        private DirtyValue<string> _administratorName;
        public string AdministratorName { get { return _administratorName; } set { _administratorName = value; } }
        private DirtyValue<string> _administratorPostalCode;
        public string AdministratorPostalCode { get { return _administratorPostalCode; } set { _administratorPostalCode = value; } }
        private DirtyValue<string> _administratorState;
        public string AdministratorState { get { return _administratorState; } set { _administratorState = value; } }
        private DirtyValue<int?> _ageOfProperty;
        public int? AgeOfProperty { get { return _ageOfProperty; } set { _ageOfProperty = value; } }
        private DirtyValue<decimal?> _amountSpentOnEnergyImprovements;
        public decimal? AmountSpentOnEnergyImprovements { get { return _amountSpentOnEnergyImprovements; } set { _amountSpentOnEnergyImprovements = value; } }
        private StringEnumValue<AmountTypeWithheld> _amountTypeWithheld;
        public StringEnumValue<AmountTypeWithheld> AmountTypeWithheld { get { return _amountTypeWithheld; } set { _amountTypeWithheld = value; } }
        private DirtyValue<decimal?> _amountWithheld;
        public decimal? AmountWithheld { get { return _amountWithheld; } set { _amountWithheld = value; } }
        private DirtyValue<decimal?> _annualGroundRent;
        public decimal? AnnualGroundRent { get { return _annualGroundRent; } set { _annualGroundRent = value; } }
        private DirtyValue<decimal?> _annualMaintenanceAssessment;
        public decimal? AnnualMaintenanceAssessment { get { return _annualMaintenanceAssessment; } set { _annualMaintenanceAssessment = value; } }
        private DirtyValue<decimal?> _annualRealEstateTaxes;
        public decimal? AnnualRealEstateTaxes { get { return _annualRealEstateTaxes; } set { _annualRealEstateTaxes = value; } }
        private DirtyValue<decimal?> _annualSpecialAssessment;
        public decimal? AnnualSpecialAssessment { get { return _annualSpecialAssessment; } set { _annualSpecialAssessment = value; } }
        private DirtyValue<string> _applicantAddressCity;
        public string ApplicantAddressCity { get { return _applicantAddressCity; } set { _applicantAddressCity = value; } }
        private DirtyValue<string> _applicantAddressPostalCode;
        public string ApplicantAddressPostalCode { get { return _applicantAddressPostalCode; } set { _applicantAddressPostalCode = value; } }
        private DirtyValue<string> _applicantAddressState;
        public string ApplicantAddressState { get { return _applicantAddressState; } set { _applicantAddressState = value; } }
        private DirtyValue<string> _applicantAddressStreetLine1;
        public string ApplicantAddressStreetLine1 { get { return _applicantAddressStreetLine1; } set { _applicantAddressStreetLine1 = value; } }
        private DirtyValue<DateTime?> _applicantBirthDate;
        public DateTime? ApplicantBirthDate { get { return _applicantBirthDate; } set { _applicantBirthDate = value; } }
        private DirtyValue<string> _applicantEmailAddressText;
        public string ApplicantEmailAddressText { get { return _applicantEmailAddressText; } set { _applicantEmailAddressText = value; } }
        private DirtyValue<string> _applicantFirstNameWithMiddleName;
        public string ApplicantFirstNameWithMiddleName { get { return _applicantFirstNameWithMiddleName; } set { _applicantFirstNameWithMiddleName = value; } }
        private DirtyValue<string> _applicantHmdaGenderType;
        public string ApplicantHmdaGenderType { get { return _applicantHmdaGenderType; } set { _applicantHmdaGenderType = value; } }
        private DirtyValue<string> _applicantHomePhoneNumber;
        public string ApplicantHomePhoneNumber { get { return _applicantHomePhoneNumber; } set { _applicantHomePhoneNumber = value; } }
        private DirtyValue<string> _applicantLastNameWithSuffix;
        public string ApplicantLastNameWithSuffix { get { return _applicantLastNameWithSuffix; } set { _applicantLastNameWithSuffix = value; } }
        private DirtyValue<string> _applicantTaxIdentificationIdentifier;
        public string ApplicantTaxIdentificationIdentifier { get { return _applicantTaxIdentificationIdentifier; } set { _applicantTaxIdentificationIdentifier = value; } }
        private StringEnumValue<VaLoanDataAppraisalType> _appraisalType;
        public StringEnumValue<VaLoanDataAppraisalType> AppraisalType { get { return _appraisalType; } set { _appraisalType = value; } }
        private DirtyValue<bool?> _automaticProcedure;
        public bool? AutomaticProcedure { get { return _automaticProcedure; } set { _automaticProcedure = value; } }
        private DirtyValue<bool?> _availableForInspectionAMIndicator;
        public bool? AvailableForInspectionAMIndicator { get { return _availableForInspectionAMIndicator; } set { _availableForInspectionAMIndicator = value; } }
        private DirtyValue<string> _availableForInspectionDateAndTime;
        public string AvailableForInspectionDateAndTime { get { return _availableForInspectionDateAndTime; } set { _availableForInspectionDateAndTime = value; } }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get { return _borrowerPaidDiscountPointsTotalAmount; } set { _borrowerPaidDiscountPointsTotalAmount = value; } }
        private StringEnumValue<BuildingType> _buildingType;
        public StringEnumValue<BuildingType> BuildingType { get { return _buildingType; } set { _buildingType = value; } }
        private DirtyValue<bool?> _buyerPurchasingLotSeparately;
        public bool? BuyerPurchasingLotSeparately { get { return _buyerPurchasingLotSeparately; } set { _buyerPurchasingLotSeparately = value; } }
        private DirtyValue<decimal?> _cashPaymentFromVeteran;
        public decimal? CashPaymentFromVeteran { get { return _cashPaymentFromVeteran; } set { _cashPaymentFromVeteran = value; } }
        private StringEnumValue<ClaimDisabilityBenefits> _claimDisabilityBenefits;
        public StringEnumValue<ClaimDisabilityBenefits> ClaimDisabilityBenefits { get { return _claimDisabilityBenefits; } set { _claimDisabilityBenefits = value; } }
        private DirtyValue<bool?> _clothesWasherIndicator;
        public bool? ClothesWasherIndicator { get { return _clothesWasherIndicator; } set { _clothesWasherIndicator = value; } }
        private DirtyValue<DateTime?> _constructionCompletedDate;
        public DateTime? ConstructionCompletedDate { get { return _constructionCompletedDate; } set { _constructionCompletedDate = value; } }
        private StringEnumValue<ConstructionPlan> _constructionPlan;
        public StringEnumValue<ConstructionPlan> ConstructionPlan { get { return _constructionPlan; } set { _constructionPlan = value; } }
        private DirtyValue<bool?> _constructionWarrantyIncluded;
        public bool? ConstructionWarrantyIncluded { get { return _constructionWarrantyIncluded; } set { _constructionWarrantyIncluded = value; } }
        private DirtyValue<string> _contractNoApprovedByVA;
        public string ContractNoApprovedByVA { get { return _contractNoApprovedByVA; } set { _contractNoApprovedByVA = value; } }
        private DirtyValue<int?> _creditScore;
        public int? CreditScore { get { return _creditScore; } set { _creditScore = value; } }
        private DirtyValue<bool?> _currentlyOnMilitaryDuty;
        public bool? CurrentlyOnMilitaryDuty { get { return _currentlyOnMilitaryDuty; } set { _currentlyOnMilitaryDuty = value; } }
        private DirtyValue<DateTime?> _dateAquiredLand;
        public DateTime? DateAquiredLand { get { return _dateAquiredLand; } set { _dateAquiredLand = value; } }
        private DirtyValue<DateTime?> _dateOfAssignment;
        public DateTime? DateOfAssignment { get { return _dateOfAssignment; } set { _dateOfAssignment = value; } }
        private DirtyValue<DateTime?> _dateSAR;
        public DateTime? DateSAR { get { return _dateSAR; } set { _dateSAR = value; } }
        private DirtyValue<decimal?> _disabilityAmountCollected;
        public decimal? DisabilityAmountCollected { get { return _disabilityAmountCollected; } set { _disabilityAmountCollected = value; } }
        private DirtyValue<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        private DirtyValue<decimal?> _discountPoint;
        public decimal? DiscountPoint { get { return _discountPoint; } set { _discountPoint = value; } }
        private DirtyValue<bool?> _dishwasherIndicator;
        public bool? DishwasherIndicator { get { return _dishwasherIndicator; } set { _dishwasherIndicator = value; } }
        private DirtyValue<bool?> _dryerIndicator;
        public bool? DryerIndicator { get { return _dryerIndicator; } set { _dryerIndicator = value; } }
        private DirtyValue<string> _emailToBeNotifiedWhenUploaded;
        public string EmailToBeNotifiedWhenUploaded { get { return _emailToBeNotifiedWhenUploaded; } set { _emailToBeNotifiedWhenUploaded = value; } }
        private DirtyValue<bool?> _energyImprovementsAdditionOfFeature;
        public bool? EnergyImprovementsAdditionOfFeature { get { return _energyImprovementsAdditionOfFeature; } set { _energyImprovementsAdditionOfFeature = value; } }
        private DirtyValue<string> _entitlementCode;
        public string EntitlementCode { get { return _entitlementCode; } set { _entitlementCode = value; } }
        private DirtyValue<string> _equipmentOtherDescription;
        public string EquipmentOtherDescription { get { return _equipmentOtherDescription; } set { _equipmentOtherDescription = value; } }
        private DirtyValue<bool?> _excludeTaxesInsuranceIndicator;
        public bool? ExcludeTaxesInsuranceIndicator { get { return _excludeTaxesInsuranceIndicator; } set { _excludeTaxesInsuranceIndicator = value; } }
        private DirtyValue<decimal?> _finalDiscountAmount;
        public decimal? FinalDiscountAmount { get { return _finalDiscountAmount; } set { _finalDiscountAmount = value; } }
        private DirtyValue<decimal?> _finalFundingFeeAmount;
        public decimal? FinalFundingFeeAmount { get { return _finalFundingFeeAmount; } set { _finalFundingFeeAmount = value; } }
        private DirtyValue<bool?> _firstChattelLoanType;
        public bool? FirstChattelLoanType { get { return _firstChattelLoanType; } set { _firstChattelLoanType = value; } }
        private DirtyValue<bool?> _firstTimeUse;
        public bool? FirstTimeUse { get { return _firstTimeUse; } set { _firstTimeUse = value; } }
        private DirtyValue<bool?> _fundingFeeExempt;
        public bool? FundingFeeExempt { get { return _fundingFeeExempt; } set { _fundingFeeExempt = value; } }
        private DirtyValue<bool?> _garbageDisposalIndicator;
        public bool? GarbageDisposalIndicator { get { return _garbageDisposalIndicator; } set { _garbageDisposalIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _initialTotal;
        public decimal? InitialTotal { get { return _initialTotal; } set { _initialTotal = value; } }
        private StringEnumValue<InspectionWillBeMadeBy> _inspectionWillBeMadeBy;
        public StringEnumValue<InspectionWillBeMadeBy> InspectionWillBeMadeBy { get { return _inspectionWillBeMadeBy; } set { _inspectionWillBeMadeBy = value; } }
        private DirtyValue<bool?> _insulation;
        public bool? Insulation { get { return _insulation; } set { _insulation = value; } }
        private StringEnumValue<InsuranceType> _insuranceType;
        public StringEnumValue<InsuranceType> InsuranceType { get { return _insuranceType; } set { _insuranceType = value; } }
        private DirtyValue<int?> _irregularLotSizeInSquareFeet;
        public int? IrregularLotSizeInSquareFeet { get { return _irregularLotSizeInSquareFeet; } set { _irregularLotSizeInSquareFeet = value; } }
        private DirtyValue<bool?> _isDelinquent30Days;
        public bool? IsDelinquent30Days { get { return _isDelinquent30Days; } set { _isDelinquent30Days = value; } }
        private DirtyValue<string> _keysAtAddress;
        public string KeysAtAddress { get { return _keysAtAddress; } set { _keysAtAddress = value; } }
        private DirtyValue<decimal?> _landPurchasePrice;
        public decimal? LandPurchasePrice { get { return _landPurchasePrice; } set { _landPurchasePrice = value; } }
        private StringEnumValue<LeaseholdType> _leaseholdType;
        public StringEnumValue<LeaseholdType> LeaseholdType { get { return _leaseholdType; } set { _leaseholdType = value; } }
        private DirtyValue<string> _lenderSAR;
        public string LenderSAR { get { return _lenderSAR; } set { _lenderSAR = value; } }
        private DirtyValue<string> _loanAnalysisRemarks1;
        public string LoanAnalysisRemarks1 { get { return _loanAnalysisRemarks1; } set { _loanAnalysisRemarks1 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks2;
        public string LoanAnalysisRemarks2 { get { return _loanAnalysisRemarks2; } set { _loanAnalysisRemarks2 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks3;
        public string LoanAnalysisRemarks3 { get { return _loanAnalysisRemarks3; } set { _loanAnalysisRemarks3 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks4;
        public string LoanAnalysisRemarks4 { get { return _loanAnalysisRemarks4; } set { _loanAnalysisRemarks4 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks5;
        public string LoanAnalysisRemarks5 { get { return _loanAnalysisRemarks5; } set { _loanAnalysisRemarks5 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks6;
        public string LoanAnalysisRemarks6 { get { return _loanAnalysisRemarks6; } set { _loanAnalysisRemarks6 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks7;
        public string LoanAnalysisRemarks7 { get { return _loanAnalysisRemarks7; } set { _loanAnalysisRemarks7 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks8;
        public string LoanAnalysisRemarks8 { get { return _loanAnalysisRemarks8; } set { _loanAnalysisRemarks8 = value; } }
        private DirtyValue<string> _loanAnalysisRemarks9;
        public string LoanAnalysisRemarks9 { get { return _loanAnalysisRemarks9; } set { _loanAnalysisRemarks9 = value; } }
        private StringEnumValue<LoanCode> _loanCode;
        public StringEnumValue<LoanCode> LoanCode { get { return _loanCode; } set { _loanCode = value; } }
        private StringEnumValue<LoanProcedure> _loanProcedure;
        public StringEnumValue<LoanProcedure> LoanProcedure { get { return _loanProcedure; } set { _loanProcedure = value; } }
        private DirtyValue<bool?> _loanProcessedUnderAU;
        public bool? LoanProcessedUnderAU { get { return _loanProcessedUnderAU; } set { _loanProcessedUnderAU = value; } }
        private DirtyValue<string> _loanSummaryRemarks1;
        public string LoanSummaryRemarks1 { get { return _loanSummaryRemarks1; } set { _loanSummaryRemarks1 = value; } }
        private DirtyValue<string> _loanSummaryRemarks2;
        public string LoanSummaryRemarks2 { get { return _loanSummaryRemarks2; } set { _loanSummaryRemarks2 = value; } }
        private DirtyValue<string> _loanSummaryRemarks3;
        public string LoanSummaryRemarks3 { get { return _loanSummaryRemarks3; } set { _loanSummaryRemarks3 = value; } }
        private DirtyValue<string> _loanSummaryRemarks4;
        public string LoanSummaryRemarks4 { get { return _loanSummaryRemarks4; } set { _loanSummaryRemarks4 = value; } }
        private DirtyValue<string> _loanSummaryRemarks5;
        public string LoanSummaryRemarks5 { get { return _loanSummaryRemarks5; } set { _loanSummaryRemarks5 = value; } }
        private DirtyValue<string> _loanSummaryRemarks6;
        public string LoanSummaryRemarks6 { get { return _loanSummaryRemarks6; } set { _loanSummaryRemarks6 = value; } }
        private DirtyValue<string> _loanSummaryRemarks7;
        public string LoanSummaryRemarks7 { get { return _loanSummaryRemarks7; } set { _loanSummaryRemarks7 = value; } }
        private DirtyValue<string> _loanSummaryRemarks8;
        public string LoanSummaryRemarks8 { get { return _loanSummaryRemarks8; } set { _loanSummaryRemarks8 = value; } }
        private DirtyValue<string> _lotDimensions;
        public string LotDimensions { get { return _lotDimensions; } set { _lotDimensions = value; } }
        private DirtyValue<string> _mailingAddress;
        public string MailingAddress { get { return _mailingAddress; } set { _mailingAddress = value; } }
        private DirtyValue<string> _mailingCity;
        public string MailingCity { get { return _mailingCity; } set { _mailingCity = value; } }
        private DirtyValue<string> _mailingPostalCode;
        public string MailingPostalCode { get { return _mailingPostalCode; } set { _mailingPostalCode = value; } }
        private DirtyValue<string> _mailingState;
        public string MailingState { get { return _mailingState; } set { _mailingState = value; } }
        private StringEnumValue<ManufacturedHome> _manufacturedHome;
        public StringEnumValue<ManufacturedHome> ManufacturedHome { get { return _manufacturedHome; } set { _manufacturedHome = value; } }
        private DirtyValue<string> _mCRVNumber;
        public string MCRVNumber { get { return _mCRVNumber; } set { _mCRVNumber = value; } }
        private StringEnumValue<MilitaryBranchOfService> _militaryBranchOfService;
        public StringEnumValue<MilitaryBranchOfService> MilitaryBranchOfService { get { return _militaryBranchOfService; } set { _militaryBranchOfService = value; } }
        private DirtyList<MilitaryService> _militaryServices;
        public IList<MilitaryService> MilitaryServices { get { return _militaryServices ?? (_militaryServices = new DirtyList<MilitaryService>()); } set { _militaryServices = new DirtyList<MilitaryService>(value); } }
        private DirtyValue<string> _mineralRightsReserved;
        public string MineralRightsReserved { get { return _mineralRightsReserved; } set { _mineralRightsReserved = value; } }
        private DirtyValue<string> _nameOfOccupant;
        public string NameOfOccupant { get { return _nameOfOccupant; } set { _nameOfOccupant = value; } }
        private DirtyValue<string> _nameOfOwner;
        public string NameOfOwner { get { return _nameOfOwner; } set { _nameOfOwner = value; } }
        private DirtyValue<string> _nameOfWarrantyProgram;
        public string NameOfWarrantyProgram { get { return _nameOfWarrantyProgram; } set { _nameOfWarrantyProgram = value; } }
        private DirtyValue<decimal?> _negativeRents;
        public decimal? NegativeRents { get { return _negativeRents; } set { _negativeRents = value; } }
        private DirtyValue<bool?> _noEnergyImprovements;
        public bool? NoEnergyImprovements { get { return _noEnergyImprovements; } set { _noEnergyImprovements = value; } }
        private DirtyValue<string> _nonrealtyDescription;
        public string NonrealtyDescription { get { return _nonrealtyDescription; } set { _nonrealtyDescription = value; } }
        private DirtyValue<string> _numberOfBuildings;
        public string NumberOfBuildings { get { return _numberOfBuildings; } set { _numberOfBuildings = value; } }
        private DirtyValue<string> _occupantTelephone;
        public string OccupantTelephone { get { return _occupantTelephone; } set { _occupantTelephone = value; } }
        private DirtyValue<bool?> _onMilitaryDutyFollowingSeparation;
        public bool? OnMilitaryDutyFollowingSeparation { get { return _onMilitaryDutyFollowingSeparation; } set { _onMilitaryDutyFollowingSeparation = value; } }
        private DirtyValue<decimal?> _originalInterestRate;
        public decimal? OriginalInterestRate { get { return _originalInterestRate; } set { _originalInterestRate = value; } }
        private DirtyValue<decimal?> _originalLoanAmount;
        public decimal? OriginalLoanAmount { get { return _originalLoanAmount; } set { _originalLoanAmount = value; } }
        private DirtyValue<int?> _originalTerm;
        public int? OriginalTerm { get { return _originalTerm; } set { _originalTerm = value; } }
        private DirtyValue<bool?> _originalValueEstimateChanged;
        public bool? OriginalValueEstimateChanged { get { return _originalValueEstimateChanged; } set { _originalValueEstimateChanged = value; } }
        private DirtyValue<decimal?> _originationFeeAmount;
        public decimal? OriginationFeeAmount { get { return _originationFeeAmount; } set { _originationFeeAmount = value; } }
        private DirtyValue<decimal?> _otherClosingCosts;
        public decimal? OtherClosingCosts { get { return _otherClosingCosts; } set { _otherClosingCosts = value; } }
        private DirtyValue<string> _otherDescriptionEstateProperty;
        public string OtherDescriptionEstateProperty { get { return _otherDescriptionEstateProperty; } set { _otherDescriptionEstateProperty = value; } }
        private DirtyValue<string> _otherDescriptionLoanType;
        public string OtherDescriptionLoanType { get { return _otherDescriptionLoanType; } set { _otherDescriptionLoanType = value; } }
        private DirtyValue<bool?> _otherEstateProperty;
        public bool? OtherEstateProperty { get { return _otherEstateProperty; } set { _otherEstateProperty = value; } }
        private DirtyValue<bool?> _otherImprovements;
        public bool? OtherImprovements { get { return _otherImprovements; } set { _otherImprovements = value; } }
        private DirtyValue<bool?> _otherLoanType;
        public bool? OtherLoanType { get { return _otherLoanType; } set { _otherLoanType = value; } }
        private DirtyValue<string> _paidInFullVALoanNumber;
        public string PaidInFullVALoanNumber { get { return _paidInFullVALoanNumber; } set { _paidInFullVALoanNumber = value; } }
        private DirtyValue<bool?> _payoffIndicator1;
        public bool? PayoffIndicator1 { get { return _payoffIndicator1; } set { _payoffIndicator1 = value; } }
        private DirtyValue<bool?> _payoffIndicator2;
        public bool? PayoffIndicator2 { get { return _payoffIndicator2; } set { _payoffIndicator2 = value; } }
        private DirtyValue<bool?> _payoffIndicator3;
        public bool? PayoffIndicator3 { get { return _payoffIndicator3; } set { _payoffIndicator3 = value; } }
        private DirtyValue<bool?> _payoffIndicator4;
        public bool? PayoffIndicator4 { get { return _payoffIndicator4; } set { _payoffIndicator4 = value; } }
        private DirtyValue<bool?> _payoffIndicator5;
        public bool? PayoffIndicator5 { get { return _payoffIndicator5; } set { _payoffIndicator5 = value; } }
        private DirtyValue<bool?> _payoffIndicator6;
        public bool? PayoffIndicator6 { get { return _payoffIndicator6; } set { _payoffIndicator6 = value; } }
        private DirtyValue<bool?> _payoffIndicator7;
        public bool? PayoffIndicator7 { get { return _payoffIndicator7; } set { _payoffIndicator7 = value; } }
        private DirtyValue<bool?> _payoffIndicator8;
        public bool? PayoffIndicator8 { get { return _payoffIndicator8; } set { _payoffIndicator8 = value; } }
        private DirtyValue<bool?> _payoffIndicator9;
        public bool? PayoffIndicator9 { get { return _payoffIndicator9; } set { _payoffIndicator9 = value; } }
        private DirtyValue<decimal?> _pestReportFee;
        public decimal? PestReportFee { get { return _pestReportFee; } set { _pestReportFee = value; } }
        private DirtyValue<string> _plansSubmitted;
        public string PlansSubmitted { get { return _plansSubmitted; } set { _plansSubmitted = value; } }
        private DirtyValue<string> _pOCAddress;
        public string POCAddress { get { return _pOCAddress; } set { _pOCAddress = value; } }
        private DirtyValue<string> _pOCCity;
        public string POCCity { get { return _pOCCity; } set { _pOCCity = value; } }
        private DirtyValue<string> _pOCName;
        public string POCName { get { return _pOCName; } set { _pOCName = value; } }
        private DirtyValue<string> _pOCPhone;
        public string POCPhone { get { return _pOCPhone; } set { _pOCPhone = value; } }
        private DirtyValue<string> _pOCState;
        public string POCState { get { return _pOCState; } set { _pOCState = value; } }
        private DirtyValue<string> _pOCZipCode;
        public string POCZipCode { get { return _pOCZipCode; } set { _pOCZipCode = value; } }
        private DirtyValue<decimal?> _preliminaryDiscountAmount;
        public decimal? PreliminaryDiscountAmount { get { return _preliminaryDiscountAmount; } set { _preliminaryDiscountAmount = value; } }
        private DirtyValue<decimal?> _preliminaryFundingFeeAmount;
        public decimal? PreliminaryFundingFeeAmount { get { return _preliminaryFundingFeeAmount; } set { _preliminaryFundingFeeAmount = value; } }
        private DirtyValue<decimal?> _preliminaryTotal;
        public decimal? PreliminaryTotal { get { return _preliminaryTotal; } set { _preliminaryTotal = value; } }
        private DirtyValue<bool?> _previousVALoanIndicator;
        public bool? PreviousVALoanIndicator { get { return _previousVALoanIndicator; } set { _previousVALoanIndicator = value; } }
        private DirtyList<PreviousVaLoan> _previousVaLoans;
        public IList<PreviousVaLoan> PreviousVaLoans { get { return _previousVaLoans ?? (_previousVaLoans = new DirtyList<PreviousVaLoan>()); } set { _previousVaLoans = new DirtyList<PreviousVaLoan>(value); } }
        private DirtyValue<bool?> _priorApprovalProcedure;
        public bool? PriorApprovalProcedure { get { return _priorApprovalProcedure; } set { _priorApprovalProcedure = value; } }
        private StringEnumValue<PriorLoanType> _priorLoanType;
        public StringEnumValue<PriorLoanType> PriorLoanType { get { return _priorLoanType; } set { _priorLoanType = value; } }
        private StringEnumValue<PropertyDesignation> _propertyDesignation;
        public StringEnumValue<PropertyDesignation> PropertyDesignation { get { return _propertyDesignation; } set { _propertyDesignation = value; } }
        private DirtyValue<int?> _propertyGrossLivingArea;
        public int? PropertyGrossLivingArea { get { return _propertyGrossLivingArea; } set { _propertyGrossLivingArea = value; } }
        private DirtyValue<string> _propertyLegalDescription1;
        public string PropertyLegalDescription1 { get { return _propertyLegalDescription1; } set { _propertyLegalDescription1 = value; } }
        private DirtyValue<string> _propertyLegalDescription2;
        public string PropertyLegalDescription2 { get { return _propertyLegalDescription2; } set { _propertyLegalDescription2 = value; } }
        private DirtyValue<string> _propertyLegalDescription3;
        public string PropertyLegalDescription3 { get { return _propertyLegalDescription3; } set { _propertyLegalDescription3 = value; } }
        private DirtyValue<string> _propertyLegalDescription4;
        public string PropertyLegalDescription4 { get { return _propertyLegalDescription4; } set { _propertyLegalDescription4 = value; } }
        private StringEnumValue<PropertyOccupancyType> _propertyOccupancyType;
        public StringEnumValue<PropertyOccupancyType> PropertyOccupancyType { get { return _propertyOccupancyType; } set { _propertyOccupancyType = value; } }
        private DirtyValue<bool?> _proposedSaleContractAttached;
        public bool? ProposedSaleContractAttached { get { return _proposedSaleContractAttached; } set { _proposedSaleContractAttached = value; } }
        private StringEnumValue<VaLoanDataPurposeOfLoan> _purposeOfLoan;
        public StringEnumValue<VaLoanDataPurposeOfLoan> PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        private DirtyValue<bool?> _rangeOvenIndicator;
        public bool? RangeOvenIndicator { get { return _rangeOvenIndicator; } set { _rangeOvenIndicator = value; } }
        private DirtyValue<bool?> _reasonableValueCompleted;
        public bool? ReasonableValueCompleted { get { return _reasonableValueCompleted; } set { _reasonableValueCompleted = value; } }
        private DirtyValue<bool?> _refrigeratorIndicator;
        public bool? RefrigeratorIndicator { get { return _refrigeratorIndicator; } set { _refrigeratorIndicator = value; } }
        private DirtyValue<string> _rent;
        public string Rent { get { return _rent; } set { _rent = value; } }
        private DirtyValue<bool?> _replacementOfSystem;
        public bool? ReplacementOfSystem { get { return _replacementOfSystem; } set { _replacementOfSystem = value; } }
        private StringEnumValue<RiskClassification> _riskClasification;
        public StringEnumValue<RiskClassification> RiskClasification { get { return _riskClasification; } set { _riskClasification = value; } }
        private DirtyValue<string> _serviceNumber;
        public string ServiceNumber { get { return _serviceNumber; } set { _serviceNumber = value; } }
        private DirtyValue<bool?> _solarHeatingOrCooling;
        public bool? SolarHeatingOrCooling { get { return _solarHeatingOrCooling; } set { _solarHeatingOrCooling = value; } }
        private DirtyValue<string> _specialAssessmentComments1;
        public string SpecialAssessmentComments1 { get { return _specialAssessmentComments1; } set { _specialAssessmentComments1 = value; } }
        private DirtyValue<string> _specialAssessmentComments2;
        public string SpecialAssessmentComments2 { get { return _specialAssessmentComments2; } set { _specialAssessmentComments2 = value; } }
        private DirtyValue<string> _specialAssessmentComments3;
        public string SpecialAssessmentComments3 { get { return _specialAssessmentComments3; } set { _specialAssessmentComments3 = value; } }
        private StringEnumValue<StreetAccess> _streetAccess;
        public StringEnumValue<StreetAccess> StreetAccess { get { return _streetAccess; } set { _streetAccess = value; } }
        private StringEnumValue<StreetMaintenance> _streetMaintenance;
        public StringEnumValue<StreetMaintenance> StreetMaintenance { get { return _streetMaintenance; } set { _streetMaintenance = value; } }
        private StringEnumValue<SystemUsed> _systemUsed;
        public StringEnumValue<SystemUsed> SystemUsed { get { return _systemUsed; } set { _systemUsed = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private DirtyValue<string> _titleLimitations1;
        public string TitleLimitations1 { get { return _titleLimitations1; } set { _titleLimitations1 = value; } }
        private DirtyValue<string> _titleLimitations2;
        public string TitleLimitations2 { get { return _titleLimitations2; } set { _titleLimitations2 = value; } }
        private DirtyValue<string> _titleLimitations3;
        public string TitleLimitations3 { get { return _titleLimitations3; } set { _titleLimitations3 = value; } }
        private DirtyValue<decimal?> _totalBaths;
        public decimal? TotalBaths { get { return _totalBaths; } set { _totalBaths = value; } }
        private DirtyValue<int?> _totalBedrooms;
        public int? TotalBedrooms { get { return _totalBedrooms; } set { _totalBedrooms = value; } }
        private DirtyValue<decimal?> _totalDebtMonthlyPayment;
        public decimal? TotalDebtMonthlyPayment { get { return _totalDebtMonthlyPayment; } set { _totalDebtMonthlyPayment = value; } }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        private DirtyValue<decimal?> _totalDiscountPointsCharged;
        public decimal? TotalDiscountPointsCharged { get { return _totalDiscountPointsCharged; } set { _totalDiscountPointsCharged = value; } }
        private DirtyValue<decimal?> _totalForMaxLoanAmount;
        public decimal? TotalForMaxLoanAmount { get { return _totalForMaxLoanAmount; } set { _totalForMaxLoanAmount = value; } }
        private DirtyValue<decimal?> _totalMonthlyPayment;
        public decimal? TotalMonthlyPayment { get { return _totalMonthlyPayment; } set { _totalMonthlyPayment = value; } }
        private DirtyValue<decimal?> _totalProposedMonthlyPayment;
        public decimal? TotalProposedMonthlyPayment { get { return _totalProposedMonthlyPayment; } set { _totalProposedMonthlyPayment = value; } }
        private DirtyValue<int?> _totalRooms;
        public int? TotalRooms { get { return _totalRooms; } set { _totalRooms = value; } }
        private DirtyValue<decimal?> _totalUnpaidSpecialAssessments;
        public decimal? TotalUnpaidSpecialAssessments { get { return _totalUnpaidSpecialAssessments; } set { _totalUnpaidSpecialAssessments = value; } }
        private StringEnumValue<TypeOfHybridARM> _typeOfHybridARM;
        public StringEnumValue<TypeOfHybridARM> TypeOfHybridARM { get { return _typeOfHybridARM; } set { _typeOfHybridARM = value; } }
        private StringEnumValue<TypeOfMortgage> _typeOfMortgage;
        public StringEnumValue<TypeOfMortgage> TypeOfMortgage { get { return _typeOfMortgage; } set { _typeOfMortgage = value; } }
        private StringEnumValue<TypeOfOwnsership> _typeOfOwnsership;
        public StringEnumValue<TypeOfOwnsership> TypeOfOwnsership { get { return _typeOfOwnsership; } set { _typeOfOwnsership = value; } }
        private StringEnumValue<TypeOfStructure> _typeOfStructure;
        public StringEnumValue<TypeOfStructure> TypeOfStructure { get { return _typeOfStructure; } set { _typeOfStructure = value; } }
        private StringEnumValue<TypeOfVeteran> _typeOfVeteran;
        public StringEnumValue<TypeOfVeteran> TypeOfVeteran { get { return _typeOfVeteran; } set { _typeOfVeteran = value; } }
        private DirtyValue<bool?> _unsecuredLoanType;
        public bool? UnsecuredLoanType { get { return _unsecuredLoanType; } set { _unsecuredLoanType = value; } }
        private StringEnumValue<UtilitiesDescription> _utilitiesElectricDescription;
        public StringEnumValue<UtilitiesDescription> UtilitiesElectricDescription { get { return _utilitiesElectricDescription; } set { _utilitiesElectricDescription = value; } }
        private StringEnumValue<UtilitiesDescription> _utilitiesGasDescription;
        public StringEnumValue<UtilitiesDescription> UtilitiesGasDescription { get { return _utilitiesGasDescription; } set { _utilitiesGasDescription = value; } }
        private StringEnumValue<UtilitiesDescription> _utilitiesSewerDescription;
        public StringEnumValue<UtilitiesDescription> UtilitiesSewerDescription { get { return _utilitiesSewerDescription; } set { _utilitiesSewerDescription = value; } }
        private StringEnumValue<UtilitiesDescription> _utilitiesWaterDescription;
        public StringEnumValue<UtilitiesDescription> UtilitiesWaterDescription { get { return _utilitiesWaterDescription; } set { _utilitiesWaterDescription = value; } }
        private DirtyValue<DateTime?> _vAAppraisalSentDate;
        public DateTime? VAAppraisalSentDate { get { return _vAAppraisalSentDate; } set { _vAAppraisalSentDate = value; } }
        private StringEnumValue<VABenefitRelatedIndebtedness> _vABenefitRelatedIndebtedness;
        public StringEnumValue<VABenefitRelatedIndebtedness> VABenefitRelatedIndebtedness { get { return _vABenefitRelatedIndebtedness; } set { _vABenefitRelatedIndebtedness = value; } }
        private DirtyValue<string> _vABuilderDescription;
        public string VABuilderDescription { get { return _vABuilderDescription; } set { _vABuilderDescription = value; } }
        private DirtyValue<string> _vABuilderIDNo;
        public string VABuilderIDNo { get { return _vABuilderIDNo; } set { _vABuilderIDNo = value; } }
        private DirtyValue<string> _vAClaimFolderNumber;
        public string VAClaimFolderNumber { get { return _vAClaimFolderNumber; } set { _vAClaimFolderNumber = value; } }
        private DirtyValue<string> _vAClaimNumber;
        public string VAClaimNumber { get { return _vAClaimNumber; } set { _vAClaimNumber = value; } }
        private DirtyValue<DateTime?> _vADateNOVAppraisalMailedToBorrower;
        public DateTime? VADateNOVAppraisalMailedToBorrower { get { return _vADateNOVAppraisalMailedToBorrower; } set { _vADateNOVAppraisalMailedToBorrower = value; } }
        private DirtyValue<bool?> _vAIsDelinquent30Days;
        public bool? VAIsDelinquent30Days { get { return _vAIsDelinquent30Days; } set { _vAIsDelinquent30Days = value; } }
        private DirtyValue<bool?> _vALatePaymentIn6Months;
        public bool? VALatePaymentIn6Months { get { return _vALatePaymentIn6Months; } set { _vALatePaymentIn6Months = value; } }
        private StringEnumValue<VaLoanSummaryApplicantType> _vaLoanSummaryApplicantType;
        public StringEnumValue<VaLoanSummaryApplicantType> VaLoanSummaryApplicantType { get { return _vaLoanSummaryApplicantType; } set { _vaLoanSummaryApplicantType = value; } }
        private DirtyValue<DateTime?> _vANOVDateReceived;
        public DateTime? VANOVDateReceived { get { return _vANOVDateReceived; } set { _vANOVDateReceived = value; } }
        private DirtyValue<DateTime?> _vANOVDateReviewed;
        public DateTime? VANOVDateReviewed { get { return _vANOVDateReviewed; } set { _vANOVDateReviewed = value; } }
        private DirtyValue<DateTime?> _vANOVIssuedDate;
        public DateTime? VANOVIssuedDate { get { return _vANOVIssuedDate; } set { _vANOVIssuedDate = value; } }
        private StringEnumValue<AmortizationType> _vAOriginalAmortizationType;
        public StringEnumValue<AmortizationType> VAOriginalAmortizationType { get { return _vAOriginalAmortizationType; } set { _vAOriginalAmortizationType = value; } }
        private DirtyValue<decimal?> _vAOriginalMonthlyPayment;
        public decimal? VAOriginalMonthlyPayment { get { return _vAOriginalMonthlyPayment; } set { _vAOriginalMonthlyPayment = value; } }
        private DirtyValue<string> _vAQualification2ndTierEntitlement;
        public string VAQualification2ndTierEntitlement { get { return _vAQualification2ndTierEntitlement; } set { _vAQualification2ndTierEntitlement = value; } }
        private StringEnumValue<VAQualificationCountryRegion> _vAQualificationCountryRegion;
        public StringEnumValue<VAQualificationCountryRegion> VAQualificationCountryRegion { get { return _vAQualificationCountryRegion; } set { _vAQualificationCountryRegion = value; } }
        private DirtyValue<decimal?> _vAQualificationCountyLimits;
        public decimal? VAQualificationCountyLimits { get { return _vAQualificationCountyLimits; } set { _vAQualificationCountyLimits = value; } }
        private DirtyValue<int?> _vARecoupmentClosingCosts;
        public int? VARecoupmentClosingCosts { get { return _vARecoupmentClosingCosts; } set { _vARecoupmentClosingCosts = value; } }
        private DirtyValue<bool?> _vARecoupmentExcludePrepaids;
        public bool? VARecoupmentExcludePrepaids { get { return _vARecoupmentExcludePrepaids; } set { _vARecoupmentExcludePrepaids = value; } }
        private DirtyValue<decimal?> _vARecoupmentMonthlyDecreaseInPayment;
        public decimal? VARecoupmentMonthlyDecreaseInPayment { get { return _vARecoupmentMonthlyDecreaseInPayment; } set { _vARecoupmentMonthlyDecreaseInPayment = value; } }
        private DirtyValue<int?> _vARecoupmentMonths;
        public int? VARecoupmentMonths { get { return _vARecoupmentMonths; } set { _vARecoupmentMonths = value; } }
        private DirtyValue<decimal?> _vARecoupmentTotalClosingCosts;
        public decimal? VARecoupmentTotalClosingCosts { get { return _vARecoupmentTotalClosingCosts; } set { _vARecoupmentTotalClosingCosts = value; } }
        private DirtyValue<int?> _vARecoupmentYears;
        public int? VARecoupmentYears { get { return _vARecoupmentYears; } set { _vARecoupmentYears = value; } }
        private DirtyValue<DateTime?> _vATrackingCertOfCommitmentIssued;
        public DateTime? VATrackingCertOfCommitmentIssued { get { return _vATrackingCertOfCommitmentIssued; } set { _vATrackingCertOfCommitmentIssued = value; } }
        private DirtyValue<DateTime?> _vATrackingCOEIssueDate;
        public DateTime? VATrackingCOEIssueDate { get { return _vATrackingCOEIssueDate; } set { _vATrackingCOEIssueDate = value; } }
        private DirtyValue<string> _vATrackingCOEIssueHistory;
        public string VATrackingCOEIssueHistory { get { return _vATrackingCOEIssueHistory; } set { _vATrackingCOEIssueHistory = value; } }
        private DirtyValue<DateTime?> _vATrackingFinalApprovalCommitmentDate;
        public DateTime? VATrackingFinalApprovalCommitmentDate { get { return _vATrackingFinalApprovalCommitmentDate; } set { _vATrackingFinalApprovalCommitmentDate = value; } }
        private DirtyValue<bool?> _vATrackingGSAExclusionaryListChecked;
        public bool? VATrackingGSAExclusionaryListChecked { get { return _vATrackingGSAExclusionaryListChecked; } set { _vATrackingGSAExclusionaryListChecked = value; } }
        private DirtyValue<bool?> _vATrackingInuranceFloodPolicy;
        public bool? VATrackingInuranceFloodPolicy { get { return _vATrackingInuranceFloodPolicy; } set { _vATrackingInuranceFloodPolicy = value; } }
        private DirtyValue<bool?> _vATrackingInuranceHazardPolicy;
        public bool? VATrackingInuranceHazardPolicy { get { return _vATrackingInuranceHazardPolicy; } set { _vATrackingInuranceHazardPolicy = value; } }
        private DirtyValue<bool?> _vATrackingInuranceWindOrHailPolicy;
        public bool? VATrackingInuranceWindOrHailPolicy { get { return _vATrackingInuranceWindOrHailPolicy; } set { _vATrackingInuranceWindOrHailPolicy = value; } }
        private DirtyValue<bool?> _vATrackingInuranceWoodDestroyingPolicy;
        public bool? VATrackingInuranceWoodDestroyingPolicy { get { return _vATrackingInuranceWoodDestroyingPolicy; } set { _vATrackingInuranceWoodDestroyingPolicy = value; } }
        private DirtyValue<bool?> _vATrackingIsSARLAPPCertified;
        public bool? VATrackingIsSARLAPPCertified { get { return _vATrackingIsSARLAPPCertified; } set { _vATrackingIsSARLAPPCertified = value; } }
        private DirtyValue<DateTime?> _vATrackingLoanGuaranteeCertReceipt;
        public DateTime? VATrackingLoanGuaranteeCertReceipt { get { return _vATrackingLoanGuaranteeCertReceipt; } set { _vATrackingLoanGuaranteeCertReceipt = value; } }
        private DirtyValue<DateTime?> _vATrackingMasterCommitmentLockExpired;
        public DateTime? VATrackingMasterCommitmentLockExpired { get { return _vATrackingMasterCommitmentLockExpired; } set { _vATrackingMasterCommitmentLockExpired = value; } }
        private DirtyValue<DateTime?> _vATrackingOrderedDate;
        public DateTime? VATrackingOrderedDate { get { return _vATrackingOrderedDate; } set { _vATrackingOrderedDate = value; } }
        private DirtyValue<DateTime?> _vATrackingPaidDate;
        public DateTime? VATrackingPaidDate { get { return _vATrackingPaidDate; } set { _vATrackingPaidDate = value; } }
        private DirtyValue<DateTime?> _vATrackingPurchaseContractDate;
        public DateTime? VATrackingPurchaseContractDate { get { return _vATrackingPurchaseContractDate; } set { _vATrackingPurchaseContractDate = value; } }
        private DirtyValue<bool?> _vATrackingReceiptReceived;
        public bool? VATrackingReceiptReceived { get { return _vATrackingReceiptReceived; } set { _vATrackingReceiptReceived = value; } }
        private DirtyValue<string> _vATrackingSARID;
        public string VATrackingSARID { get { return _vATrackingSARID; } set { _vATrackingSARID = value; } }
        private DirtyValue<string> _vATrackingSARName;
        public string VATrackingSARName { get { return _vATrackingSARName; } set { _vATrackingSARName = value; } }
        private DirtyValue<bool?> _ventFanIndicator;
        public bool? VentFanIndicator { get { return _ventFanIndicator; } set { _ventFanIndicator = value; } }
        private DirtyValue<bool?> _veteranDischargedIndicator;
        public bool? VeteranDischargedIndicator { get { return _veteranDischargedIndicator; } set { _veteranDischargedIndicator = value; } }
        private StringEnumValue<VeteranServiceType> _veteranServiceType;
        public StringEnumValue<VeteranServiceType> VeteranServiceType { get { return _veteranServiceType; } set { _veteranServiceType = value; } }
        private DirtyValue<string> _warrantorAddress;
        public string WarrantorAddress { get { return _warrantorAddress; } set { _warrantorAddress = value; } }
        private DirtyValue<string> _warrantorCity;
        public string WarrantorCity { get { return _warrantorCity; } set { _warrantorCity = value; } }
        private DirtyValue<string> _warrantorName;
        public string WarrantorName { get { return _warrantorName; } set { _warrantorName = value; } }
        private DirtyValue<string> _warrantorPhone;
        public string WarrantorPhone { get { return _warrantorPhone; } set { _warrantorPhone = value; } }
        private DirtyValue<string> _warrantorPostalCode;
        public string WarrantorPostalCode { get { return _warrantorPostalCode; } set { _warrantorPostalCode = value; } }
        private DirtyValue<string> _warrantorState;
        public string WarrantorState { get { return _warrantorState; } set { _warrantorState = value; } }
        private DirtyValue<DateTime?> _warrantyProgramExpirationDate;
        public DateTime? WarrantyProgramExpirationDate { get { return _warrantyProgramExpirationDate; } set { _warrantyProgramExpirationDate = value; } }
        private DirtyValue<bool?> _wWCarpetIndicator;
        public bool? WWCarpetIndicator { get { return _wWCarpetIndicator; } set { _wWCarpetIndicator = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _acres.Dirty
                    || _additionalSecurityDescription.Dirty
                    || _administratorAddress.Dirty
                    || _administratorCity.Dirty
                    || _administratorContact.Dirty
                    || _administratorName.Dirty
                    || _administratorPostalCode.Dirty
                    || _administratorState.Dirty
                    || _ageOfProperty.Dirty
                    || _amountSpentOnEnergyImprovements.Dirty
                    || _amountTypeWithheld.Dirty
                    || _amountWithheld.Dirty
                    || _annualGroundRent.Dirty
                    || _annualMaintenanceAssessment.Dirty
                    || _annualRealEstateTaxes.Dirty
                    || _annualSpecialAssessment.Dirty
                    || _applicantAddressCity.Dirty
                    || _applicantAddressPostalCode.Dirty
                    || _applicantAddressState.Dirty
                    || _applicantAddressStreetLine1.Dirty
                    || _applicantBirthDate.Dirty
                    || _applicantEmailAddressText.Dirty
                    || _applicantFirstNameWithMiddleName.Dirty
                    || _applicantHmdaGenderType.Dirty
                    || _applicantHomePhoneNumber.Dirty
                    || _applicantLastNameWithSuffix.Dirty
                    || _applicantTaxIdentificationIdentifier.Dirty
                    || _appraisalType.Dirty
                    || _automaticProcedure.Dirty
                    || _availableForInspectionAMIndicator.Dirty
                    || _availableForInspectionDateAndTime.Dirty
                    || _borrowerPaidDiscountPointsTotalAmount.Dirty
                    || _buildingType.Dirty
                    || _buyerPurchasingLotSeparately.Dirty
                    || _cashPaymentFromVeteran.Dirty
                    || _claimDisabilityBenefits.Dirty
                    || _clothesWasherIndicator.Dirty
                    || _constructionCompletedDate.Dirty
                    || _constructionPlan.Dirty
                    || _constructionWarrantyIncluded.Dirty
                    || _contractNoApprovedByVA.Dirty
                    || _creditScore.Dirty
                    || _currentlyOnMilitaryDuty.Dirty
                    || _dateAquiredLand.Dirty
                    || _dateOfAssignment.Dirty
                    || _dateSAR.Dirty
                    || _disabilityAmountCollected.Dirty
                    || _discountPercentage.Dirty
                    || _discountPoint.Dirty
                    || _dishwasherIndicator.Dirty
                    || _dryerIndicator.Dirty
                    || _emailToBeNotifiedWhenUploaded.Dirty
                    || _energyImprovementsAdditionOfFeature.Dirty
                    || _entitlementCode.Dirty
                    || _equipmentOtherDescription.Dirty
                    || _excludeTaxesInsuranceIndicator.Dirty
                    || _finalDiscountAmount.Dirty
                    || _finalFundingFeeAmount.Dirty
                    || _firstChattelLoanType.Dirty
                    || _firstTimeUse.Dirty
                    || _fundingFeeExempt.Dirty
                    || _garbageDisposalIndicator.Dirty
                    || _id.Dirty
                    || _initialTotal.Dirty
                    || _inspectionWillBeMadeBy.Dirty
                    || _insulation.Dirty
                    || _insuranceType.Dirty
                    || _irregularLotSizeInSquareFeet.Dirty
                    || _isDelinquent30Days.Dirty
                    || _keysAtAddress.Dirty
                    || _landPurchasePrice.Dirty
                    || _leaseholdType.Dirty
                    || _lenderSAR.Dirty
                    || _loanAnalysisRemarks1.Dirty
                    || _loanAnalysisRemarks2.Dirty
                    || _loanAnalysisRemarks3.Dirty
                    || _loanAnalysisRemarks4.Dirty
                    || _loanAnalysisRemarks5.Dirty
                    || _loanAnalysisRemarks6.Dirty
                    || _loanAnalysisRemarks7.Dirty
                    || _loanAnalysisRemarks8.Dirty
                    || _loanAnalysisRemarks9.Dirty
                    || _loanCode.Dirty
                    || _loanProcedure.Dirty
                    || _loanProcessedUnderAU.Dirty
                    || _loanSummaryRemarks1.Dirty
                    || _loanSummaryRemarks2.Dirty
                    || _loanSummaryRemarks3.Dirty
                    || _loanSummaryRemarks4.Dirty
                    || _loanSummaryRemarks5.Dirty
                    || _loanSummaryRemarks6.Dirty
                    || _loanSummaryRemarks7.Dirty
                    || _loanSummaryRemarks8.Dirty
                    || _lotDimensions.Dirty
                    || _mailingAddress.Dirty
                    || _mailingCity.Dirty
                    || _mailingPostalCode.Dirty
                    || _mailingState.Dirty
                    || _manufacturedHome.Dirty
                    || _mCRVNumber.Dirty
                    || _militaryBranchOfService.Dirty
                    || _mineralRightsReserved.Dirty
                    || _nameOfOccupant.Dirty
                    || _nameOfOwner.Dirty
                    || _nameOfWarrantyProgram.Dirty
                    || _negativeRents.Dirty
                    || _noEnergyImprovements.Dirty
                    || _nonrealtyDescription.Dirty
                    || _numberOfBuildings.Dirty
                    || _occupantTelephone.Dirty
                    || _onMilitaryDutyFollowingSeparation.Dirty
                    || _originalInterestRate.Dirty
                    || _originalLoanAmount.Dirty
                    || _originalTerm.Dirty
                    || _originalValueEstimateChanged.Dirty
                    || _originationFeeAmount.Dirty
                    || _otherClosingCosts.Dirty
                    || _otherDescriptionEstateProperty.Dirty
                    || _otherDescriptionLoanType.Dirty
                    || _otherEstateProperty.Dirty
                    || _otherImprovements.Dirty
                    || _otherLoanType.Dirty
                    || _paidInFullVALoanNumber.Dirty
                    || _payoffIndicator1.Dirty
                    || _payoffIndicator2.Dirty
                    || _payoffIndicator3.Dirty
                    || _payoffIndicator4.Dirty
                    || _payoffIndicator5.Dirty
                    || _payoffIndicator6.Dirty
                    || _payoffIndicator7.Dirty
                    || _payoffIndicator8.Dirty
                    || _payoffIndicator9.Dirty
                    || _pestReportFee.Dirty
                    || _plansSubmitted.Dirty
                    || _pOCAddress.Dirty
                    || _pOCCity.Dirty
                    || _pOCName.Dirty
                    || _pOCPhone.Dirty
                    || _pOCState.Dirty
                    || _pOCZipCode.Dirty
                    || _preliminaryDiscountAmount.Dirty
                    || _preliminaryFundingFeeAmount.Dirty
                    || _preliminaryTotal.Dirty
                    || _previousVALoanIndicator.Dirty
                    || _priorApprovalProcedure.Dirty
                    || _priorLoanType.Dirty
                    || _propertyDesignation.Dirty
                    || _propertyGrossLivingArea.Dirty
                    || _propertyLegalDescription1.Dirty
                    || _propertyLegalDescription2.Dirty
                    || _propertyLegalDescription3.Dirty
                    || _propertyLegalDescription4.Dirty
                    || _propertyOccupancyType.Dirty
                    || _proposedSaleContractAttached.Dirty
                    || _purposeOfLoan.Dirty
                    || _rangeOvenIndicator.Dirty
                    || _reasonableValueCompleted.Dirty
                    || _refrigeratorIndicator.Dirty
                    || _rent.Dirty
                    || _replacementOfSystem.Dirty
                    || _riskClasification.Dirty
                    || _serviceNumber.Dirty
                    || _solarHeatingOrCooling.Dirty
                    || _specialAssessmentComments1.Dirty
                    || _specialAssessmentComments2.Dirty
                    || _specialAssessmentComments3.Dirty
                    || _streetAccess.Dirty
                    || _streetMaintenance.Dirty
                    || _systemUsed.Dirty
                    || _title.Dirty
                    || _titleLimitations1.Dirty
                    || _titleLimitations2.Dirty
                    || _titleLimitations3.Dirty
                    || _totalBaths.Dirty
                    || _totalBedrooms.Dirty
                    || _totalDebtMonthlyPayment.Dirty
                    || _totalDiscountPointCharged.Dirty
                    || _totalDiscountPointsCharged.Dirty
                    || _totalForMaxLoanAmount.Dirty
                    || _totalMonthlyPayment.Dirty
                    || _totalProposedMonthlyPayment.Dirty
                    || _totalRooms.Dirty
                    || _totalUnpaidSpecialAssessments.Dirty
                    || _typeOfHybridARM.Dirty
                    || _typeOfMortgage.Dirty
                    || _typeOfOwnsership.Dirty
                    || _typeOfStructure.Dirty
                    || _typeOfVeteran.Dirty
                    || _unsecuredLoanType.Dirty
                    || _utilitiesElectricDescription.Dirty
                    || _utilitiesGasDescription.Dirty
                    || _utilitiesSewerDescription.Dirty
                    || _utilitiesWaterDescription.Dirty
                    || _vAAppraisalSentDate.Dirty
                    || _vABenefitRelatedIndebtedness.Dirty
                    || _vABuilderDescription.Dirty
                    || _vABuilderIDNo.Dirty
                    || _vAClaimFolderNumber.Dirty
                    || _vAClaimNumber.Dirty
                    || _vADateNOVAppraisalMailedToBorrower.Dirty
                    || _vAIsDelinquent30Days.Dirty
                    || _vALatePaymentIn6Months.Dirty
                    || _vaLoanSummaryApplicantType.Dirty
                    || _vANOVDateReceived.Dirty
                    || _vANOVDateReviewed.Dirty
                    || _vANOVIssuedDate.Dirty
                    || _vAOriginalAmortizationType.Dirty
                    || _vAOriginalMonthlyPayment.Dirty
                    || _vAQualification2ndTierEntitlement.Dirty
                    || _vAQualificationCountryRegion.Dirty
                    || _vAQualificationCountyLimits.Dirty
                    || _vARecoupmentClosingCosts.Dirty
                    || _vARecoupmentExcludePrepaids.Dirty
                    || _vARecoupmentMonthlyDecreaseInPayment.Dirty
                    || _vARecoupmentMonths.Dirty
                    || _vARecoupmentTotalClosingCosts.Dirty
                    || _vARecoupmentYears.Dirty
                    || _vATrackingCertOfCommitmentIssued.Dirty
                    || _vATrackingCOEIssueDate.Dirty
                    || _vATrackingCOEIssueHistory.Dirty
                    || _vATrackingFinalApprovalCommitmentDate.Dirty
                    || _vATrackingGSAExclusionaryListChecked.Dirty
                    || _vATrackingInuranceFloodPolicy.Dirty
                    || _vATrackingInuranceHazardPolicy.Dirty
                    || _vATrackingInuranceWindOrHailPolicy.Dirty
                    || _vATrackingInuranceWoodDestroyingPolicy.Dirty
                    || _vATrackingIsSARLAPPCertified.Dirty
                    || _vATrackingLoanGuaranteeCertReceipt.Dirty
                    || _vATrackingMasterCommitmentLockExpired.Dirty
                    || _vATrackingOrderedDate.Dirty
                    || _vATrackingPaidDate.Dirty
                    || _vATrackingPurchaseContractDate.Dirty
                    || _vATrackingReceiptReceived.Dirty
                    || _vATrackingSARID.Dirty
                    || _vATrackingSARName.Dirty
                    || _ventFanIndicator.Dirty
                    || _veteranDischargedIndicator.Dirty
                    || _veteranServiceType.Dirty
                    || _warrantorAddress.Dirty
                    || _warrantorCity.Dirty
                    || _warrantorName.Dirty
                    || _warrantorPhone.Dirty
                    || _warrantorPostalCode.Dirty
                    || _warrantorState.Dirty
                    || _warrantyProgramExpirationDate.Dirty
                    || _wWCarpetIndicator.Dirty
                    || _militaryServices?.Dirty == true
                    || _previousVaLoans?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _acres.Dirty = value;
                _additionalSecurityDescription.Dirty = value;
                _administratorAddress.Dirty = value;
                _administratorCity.Dirty = value;
                _administratorContact.Dirty = value;
                _administratorName.Dirty = value;
                _administratorPostalCode.Dirty = value;
                _administratorState.Dirty = value;
                _ageOfProperty.Dirty = value;
                _amountSpentOnEnergyImprovements.Dirty = value;
                _amountTypeWithheld.Dirty = value;
                _amountWithheld.Dirty = value;
                _annualGroundRent.Dirty = value;
                _annualMaintenanceAssessment.Dirty = value;
                _annualRealEstateTaxes.Dirty = value;
                _annualSpecialAssessment.Dirty = value;
                _applicantAddressCity.Dirty = value;
                _applicantAddressPostalCode.Dirty = value;
                _applicantAddressState.Dirty = value;
                _applicantAddressStreetLine1.Dirty = value;
                _applicantBirthDate.Dirty = value;
                _applicantEmailAddressText.Dirty = value;
                _applicantFirstNameWithMiddleName.Dirty = value;
                _applicantHmdaGenderType.Dirty = value;
                _applicantHomePhoneNumber.Dirty = value;
                _applicantLastNameWithSuffix.Dirty = value;
                _applicantTaxIdentificationIdentifier.Dirty = value;
                _appraisalType.Dirty = value;
                _automaticProcedure.Dirty = value;
                _availableForInspectionAMIndicator.Dirty = value;
                _availableForInspectionDateAndTime.Dirty = value;
                _borrowerPaidDiscountPointsTotalAmount.Dirty = value;
                _buildingType.Dirty = value;
                _buyerPurchasingLotSeparately.Dirty = value;
                _cashPaymentFromVeteran.Dirty = value;
                _claimDisabilityBenefits.Dirty = value;
                _clothesWasherIndicator.Dirty = value;
                _constructionCompletedDate.Dirty = value;
                _constructionPlan.Dirty = value;
                _constructionWarrantyIncluded.Dirty = value;
                _contractNoApprovedByVA.Dirty = value;
                _creditScore.Dirty = value;
                _currentlyOnMilitaryDuty.Dirty = value;
                _dateAquiredLand.Dirty = value;
                _dateOfAssignment.Dirty = value;
                _dateSAR.Dirty = value;
                _disabilityAmountCollected.Dirty = value;
                _discountPercentage.Dirty = value;
                _discountPoint.Dirty = value;
                _dishwasherIndicator.Dirty = value;
                _dryerIndicator.Dirty = value;
                _emailToBeNotifiedWhenUploaded.Dirty = value;
                _energyImprovementsAdditionOfFeature.Dirty = value;
                _entitlementCode.Dirty = value;
                _equipmentOtherDescription.Dirty = value;
                _excludeTaxesInsuranceIndicator.Dirty = value;
                _finalDiscountAmount.Dirty = value;
                _finalFundingFeeAmount.Dirty = value;
                _firstChattelLoanType.Dirty = value;
                _firstTimeUse.Dirty = value;
                _fundingFeeExempt.Dirty = value;
                _garbageDisposalIndicator.Dirty = value;
                _id.Dirty = value;
                _initialTotal.Dirty = value;
                _inspectionWillBeMadeBy.Dirty = value;
                _insulation.Dirty = value;
                _insuranceType.Dirty = value;
                _irregularLotSizeInSquareFeet.Dirty = value;
                _isDelinquent30Days.Dirty = value;
                _keysAtAddress.Dirty = value;
                _landPurchasePrice.Dirty = value;
                _leaseholdType.Dirty = value;
                _lenderSAR.Dirty = value;
                _loanAnalysisRemarks1.Dirty = value;
                _loanAnalysisRemarks2.Dirty = value;
                _loanAnalysisRemarks3.Dirty = value;
                _loanAnalysisRemarks4.Dirty = value;
                _loanAnalysisRemarks5.Dirty = value;
                _loanAnalysisRemarks6.Dirty = value;
                _loanAnalysisRemarks7.Dirty = value;
                _loanAnalysisRemarks8.Dirty = value;
                _loanAnalysisRemarks9.Dirty = value;
                _loanCode.Dirty = value;
                _loanProcedure.Dirty = value;
                _loanProcessedUnderAU.Dirty = value;
                _loanSummaryRemarks1.Dirty = value;
                _loanSummaryRemarks2.Dirty = value;
                _loanSummaryRemarks3.Dirty = value;
                _loanSummaryRemarks4.Dirty = value;
                _loanSummaryRemarks5.Dirty = value;
                _loanSummaryRemarks6.Dirty = value;
                _loanSummaryRemarks7.Dirty = value;
                _loanSummaryRemarks8.Dirty = value;
                _lotDimensions.Dirty = value;
                _mailingAddress.Dirty = value;
                _mailingCity.Dirty = value;
                _mailingPostalCode.Dirty = value;
                _mailingState.Dirty = value;
                _manufacturedHome.Dirty = value;
                _mCRVNumber.Dirty = value;
                _militaryBranchOfService.Dirty = value;
                _mineralRightsReserved.Dirty = value;
                _nameOfOccupant.Dirty = value;
                _nameOfOwner.Dirty = value;
                _nameOfWarrantyProgram.Dirty = value;
                _negativeRents.Dirty = value;
                _noEnergyImprovements.Dirty = value;
                _nonrealtyDescription.Dirty = value;
                _numberOfBuildings.Dirty = value;
                _occupantTelephone.Dirty = value;
                _onMilitaryDutyFollowingSeparation.Dirty = value;
                _originalInterestRate.Dirty = value;
                _originalLoanAmount.Dirty = value;
                _originalTerm.Dirty = value;
                _originalValueEstimateChanged.Dirty = value;
                _originationFeeAmount.Dirty = value;
                _otherClosingCosts.Dirty = value;
                _otherDescriptionEstateProperty.Dirty = value;
                _otherDescriptionLoanType.Dirty = value;
                _otherEstateProperty.Dirty = value;
                _otherImprovements.Dirty = value;
                _otherLoanType.Dirty = value;
                _paidInFullVALoanNumber.Dirty = value;
                _payoffIndicator1.Dirty = value;
                _payoffIndicator2.Dirty = value;
                _payoffIndicator3.Dirty = value;
                _payoffIndicator4.Dirty = value;
                _payoffIndicator5.Dirty = value;
                _payoffIndicator6.Dirty = value;
                _payoffIndicator7.Dirty = value;
                _payoffIndicator8.Dirty = value;
                _payoffIndicator9.Dirty = value;
                _pestReportFee.Dirty = value;
                _plansSubmitted.Dirty = value;
                _pOCAddress.Dirty = value;
                _pOCCity.Dirty = value;
                _pOCName.Dirty = value;
                _pOCPhone.Dirty = value;
                _pOCState.Dirty = value;
                _pOCZipCode.Dirty = value;
                _preliminaryDiscountAmount.Dirty = value;
                _preliminaryFundingFeeAmount.Dirty = value;
                _preliminaryTotal.Dirty = value;
                _previousVALoanIndicator.Dirty = value;
                _priorApprovalProcedure.Dirty = value;
                _priorLoanType.Dirty = value;
                _propertyDesignation.Dirty = value;
                _propertyGrossLivingArea.Dirty = value;
                _propertyLegalDescription1.Dirty = value;
                _propertyLegalDescription2.Dirty = value;
                _propertyLegalDescription3.Dirty = value;
                _propertyLegalDescription4.Dirty = value;
                _propertyOccupancyType.Dirty = value;
                _proposedSaleContractAttached.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _rangeOvenIndicator.Dirty = value;
                _reasonableValueCompleted.Dirty = value;
                _refrigeratorIndicator.Dirty = value;
                _rent.Dirty = value;
                _replacementOfSystem.Dirty = value;
                _riskClasification.Dirty = value;
                _serviceNumber.Dirty = value;
                _solarHeatingOrCooling.Dirty = value;
                _specialAssessmentComments1.Dirty = value;
                _specialAssessmentComments2.Dirty = value;
                _specialAssessmentComments3.Dirty = value;
                _streetAccess.Dirty = value;
                _streetMaintenance.Dirty = value;
                _systemUsed.Dirty = value;
                _title.Dirty = value;
                _titleLimitations1.Dirty = value;
                _titleLimitations2.Dirty = value;
                _titleLimitations3.Dirty = value;
                _totalBaths.Dirty = value;
                _totalBedrooms.Dirty = value;
                _totalDebtMonthlyPayment.Dirty = value;
                _totalDiscountPointCharged.Dirty = value;
                _totalDiscountPointsCharged.Dirty = value;
                _totalForMaxLoanAmount.Dirty = value;
                _totalMonthlyPayment.Dirty = value;
                _totalProposedMonthlyPayment.Dirty = value;
                _totalRooms.Dirty = value;
                _totalUnpaidSpecialAssessments.Dirty = value;
                _typeOfHybridARM.Dirty = value;
                _typeOfMortgage.Dirty = value;
                _typeOfOwnsership.Dirty = value;
                _typeOfStructure.Dirty = value;
                _typeOfVeteran.Dirty = value;
                _unsecuredLoanType.Dirty = value;
                _utilitiesElectricDescription.Dirty = value;
                _utilitiesGasDescription.Dirty = value;
                _utilitiesSewerDescription.Dirty = value;
                _utilitiesWaterDescription.Dirty = value;
                _vAAppraisalSentDate.Dirty = value;
                _vABenefitRelatedIndebtedness.Dirty = value;
                _vABuilderDescription.Dirty = value;
                _vABuilderIDNo.Dirty = value;
                _vAClaimFolderNumber.Dirty = value;
                _vAClaimNumber.Dirty = value;
                _vADateNOVAppraisalMailedToBorrower.Dirty = value;
                _vAIsDelinquent30Days.Dirty = value;
                _vALatePaymentIn6Months.Dirty = value;
                _vaLoanSummaryApplicantType.Dirty = value;
                _vANOVDateReceived.Dirty = value;
                _vANOVDateReviewed.Dirty = value;
                _vANOVIssuedDate.Dirty = value;
                _vAOriginalAmortizationType.Dirty = value;
                _vAOriginalMonthlyPayment.Dirty = value;
                _vAQualification2ndTierEntitlement.Dirty = value;
                _vAQualificationCountryRegion.Dirty = value;
                _vAQualificationCountyLimits.Dirty = value;
                _vARecoupmentClosingCosts.Dirty = value;
                _vARecoupmentExcludePrepaids.Dirty = value;
                _vARecoupmentMonthlyDecreaseInPayment.Dirty = value;
                _vARecoupmentMonths.Dirty = value;
                _vARecoupmentTotalClosingCosts.Dirty = value;
                _vARecoupmentYears.Dirty = value;
                _vATrackingCertOfCommitmentIssued.Dirty = value;
                _vATrackingCOEIssueDate.Dirty = value;
                _vATrackingCOEIssueHistory.Dirty = value;
                _vATrackingFinalApprovalCommitmentDate.Dirty = value;
                _vATrackingGSAExclusionaryListChecked.Dirty = value;
                _vATrackingInuranceFloodPolicy.Dirty = value;
                _vATrackingInuranceHazardPolicy.Dirty = value;
                _vATrackingInuranceWindOrHailPolicy.Dirty = value;
                _vATrackingInuranceWoodDestroyingPolicy.Dirty = value;
                _vATrackingIsSARLAPPCertified.Dirty = value;
                _vATrackingLoanGuaranteeCertReceipt.Dirty = value;
                _vATrackingMasterCommitmentLockExpired.Dirty = value;
                _vATrackingOrderedDate.Dirty = value;
                _vATrackingPaidDate.Dirty = value;
                _vATrackingPurchaseContractDate.Dirty = value;
                _vATrackingReceiptReceived.Dirty = value;
                _vATrackingSARID.Dirty = value;
                _vATrackingSARName.Dirty = value;
                _ventFanIndicator.Dirty = value;
                _veteranDischargedIndicator.Dirty = value;
                _veteranServiceType.Dirty = value;
                _warrantorAddress.Dirty = value;
                _warrantorCity.Dirty = value;
                _warrantorName.Dirty = value;
                _warrantorPhone.Dirty = value;
                _warrantorPostalCode.Dirty = value;
                _warrantorState.Dirty = value;
                _warrantyProgramExpirationDate.Dirty = value;
                _wWCarpetIndicator.Dirty = value;
                if (_militaryServices != null) _militaryServices.Dirty = value;
                if (_previousVaLoans != null) _previousVaLoans.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}