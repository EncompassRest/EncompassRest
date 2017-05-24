using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class VaLoanData
    {
        private Value<decimal?> _acres;
        public decimal? Acres { get { return _acres; } set { _acres = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcres() => !_acres.Clean;
        private Value<string> _additionalSecurityDescription;
        public string AdditionalSecurityDescription { get { return _additionalSecurityDescription; } set { _additionalSecurityDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalSecurityDescription() => !_additionalSecurityDescription.Clean;
        private Value<string> _administratorAddress;
        public string AdministratorAddress { get { return _administratorAddress; } set { _administratorAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorAddress() => !_administratorAddress.Clean;
        private Value<string> _administratorCity;
        public string AdministratorCity { get { return _administratorCity; } set { _administratorCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorCity() => !_administratorCity.Clean;
        private Value<string> _administratorContact;
        public string AdministratorContact { get { return _administratorContact; } set { _administratorContact = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorContact() => !_administratorContact.Clean;
        private Value<string> _administratorName;
        public string AdministratorName { get { return _administratorName; } set { _administratorName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorName() => !_administratorName.Clean;
        private Value<string> _administratorPostalCode;
        public string AdministratorPostalCode { get { return _administratorPostalCode; } set { _administratorPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorPostalCode() => !_administratorPostalCode.Clean;
        private Value<string> _administratorState;
        public string AdministratorState { get { return _administratorState; } set { _administratorState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorState() => !_administratorState.Clean;
        private Value<int?> _ageOfProperty;
        public int? AgeOfProperty { get { return _ageOfProperty; } set { _ageOfProperty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgeOfProperty() => !_ageOfProperty.Clean;
        private Value<decimal?> _amountSpentOnEnergyImprovements;
        public decimal? AmountSpentOnEnergyImprovements { get { return _amountSpentOnEnergyImprovements; } set { _amountSpentOnEnergyImprovements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountSpentOnEnergyImprovements() => !_amountSpentOnEnergyImprovements.Clean;
        private Value<string> _amountTypeWithheld;
        public string AmountTypeWithheld { get { return _amountTypeWithheld; } set { _amountTypeWithheld = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountTypeWithheld() => !_amountTypeWithheld.Clean;
        private Value<decimal?> _amountWithheld;
        public decimal? AmountWithheld { get { return _amountWithheld; } set { _amountWithheld = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountWithheld() => !_amountWithheld.Clean;
        private Value<decimal?> _annualGroundRent;
        public decimal? AnnualGroundRent { get { return _annualGroundRent; } set { _annualGroundRent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualGroundRent() => !_annualGroundRent.Clean;
        private Value<decimal?> _annualMaintenanceAssessment;
        public decimal? AnnualMaintenanceAssessment { get { return _annualMaintenanceAssessment; } set { _annualMaintenanceAssessment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualMaintenanceAssessment() => !_annualMaintenanceAssessment.Clean;
        private Value<decimal?> _annualRealEstateTaxes;
        public decimal? AnnualRealEstateTaxes { get { return _annualRealEstateTaxes; } set { _annualRealEstateTaxes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualRealEstateTaxes() => !_annualRealEstateTaxes.Clean;
        private Value<decimal?> _annualSpecialAssessment;
        public decimal? AnnualSpecialAssessment { get { return _annualSpecialAssessment; } set { _annualSpecialAssessment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualSpecialAssessment() => !_annualSpecialAssessment.Clean;
        private Value<string> _applicantAddressCity;
        public string ApplicantAddressCity { get { return _applicantAddressCity; } set { _applicantAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressCity() => !_applicantAddressCity.Clean;
        private Value<string> _applicantAddressPostalCode;
        public string ApplicantAddressPostalCode { get { return _applicantAddressPostalCode; } set { _applicantAddressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressPostalCode() => !_applicantAddressPostalCode.Clean;
        private Value<string> _applicantAddressState;
        public string ApplicantAddressState { get { return _applicantAddressState; } set { _applicantAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressState() => !_applicantAddressState.Clean;
        private Value<string> _applicantAddressStreetLine1;
        public string ApplicantAddressStreetLine1 { get { return _applicantAddressStreetLine1; } set { _applicantAddressStreetLine1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressStreetLine1() => !_applicantAddressStreetLine1.Clean;
        private Value<DateTime?> _applicantBirthDate;
        public DateTime? ApplicantBirthDate { get { return _applicantBirthDate; } set { _applicantBirthDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantBirthDate() => !_applicantBirthDate.Clean;
        private Value<string> _applicantEmailAddressText;
        public string ApplicantEmailAddressText { get { return _applicantEmailAddressText; } set { _applicantEmailAddressText = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantEmailAddressText() => !_applicantEmailAddressText.Clean;
        private Value<string> _applicantFirstNameWithMiddleName;
        public string ApplicantFirstNameWithMiddleName { get { return _applicantFirstNameWithMiddleName; } set { _applicantFirstNameWithMiddleName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantFirstNameWithMiddleName() => !_applicantFirstNameWithMiddleName.Clean;
        private Value<string> _applicantHmdaGenderType;
        public string ApplicantHmdaGenderType { get { return _applicantHmdaGenderType; } set { _applicantHmdaGenderType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantHmdaGenderType() => !_applicantHmdaGenderType.Clean;
        private Value<string> _applicantHomePhoneNumber;
        public string ApplicantHomePhoneNumber { get { return _applicantHomePhoneNumber; } set { _applicantHomePhoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantHomePhoneNumber() => !_applicantHomePhoneNumber.Clean;
        private Value<string> _applicantLastNameWithSuffix;
        public string ApplicantLastNameWithSuffix { get { return _applicantLastNameWithSuffix; } set { _applicantLastNameWithSuffix = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantLastNameWithSuffix() => !_applicantLastNameWithSuffix.Clean;
        private Value<string> _applicantTaxIdentificationIdentifier;
        public string ApplicantTaxIdentificationIdentifier { get { return _applicantTaxIdentificationIdentifier; } set { _applicantTaxIdentificationIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantTaxIdentificationIdentifier() => !_applicantTaxIdentificationIdentifier.Clean;
        private Value<string> _appraisalType;
        public string AppraisalType { get { return _appraisalType; } set { _appraisalType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalType() => !_appraisalType.Clean;
        private Value<bool?> _automaticProcedure;
        public bool? AutomaticProcedure { get { return _automaticProcedure; } set { _automaticProcedure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAutomaticProcedure() => !_automaticProcedure.Clean;
        private Value<bool?> _availableForInspectionAMIndicator;
        public bool? AvailableForInspectionAMIndicator { get { return _availableForInspectionAMIndicator; } set { _availableForInspectionAMIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvailableForInspectionAMIndicator() => !_availableForInspectionAMIndicator.Clean;
        private Value<string> _availableForInspectionDateAndTime;
        public string AvailableForInspectionDateAndTime { get { return _availableForInspectionDateAndTime; } set { _availableForInspectionDateAndTime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvailableForInspectionDateAndTime() => !_availableForInspectionDateAndTime.Clean;
        private Value<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get { return _borrowerPaidDiscountPointsTotalAmount; } set { _borrowerPaidDiscountPointsTotalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidDiscountPointsTotalAmount() => !_borrowerPaidDiscountPointsTotalAmount.Clean;
        private Value<string> _buildingType;
        public string BuildingType { get { return _buildingType; } set { _buildingType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingType() => !_buildingType.Clean;
        private Value<bool?> _buyerPurchasingLotSeparately;
        public bool? BuyerPurchasingLotSeparately { get { return _buyerPurchasingLotSeparately; } set { _buyerPurchasingLotSeparately = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuyerPurchasingLotSeparately() => !_buyerPurchasingLotSeparately.Clean;
        private Value<decimal?> _cashPaymentFromVeteran;
        public decimal? CashPaymentFromVeteran { get { return _cashPaymentFromVeteran; } set { _cashPaymentFromVeteran = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashPaymentFromVeteran() => !_cashPaymentFromVeteran.Clean;
        private Value<string> _claimDisabilityBenefits;
        public string ClaimDisabilityBenefits { get { return _claimDisabilityBenefits; } set { _claimDisabilityBenefits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClaimDisabilityBenefits() => !_claimDisabilityBenefits.Clean;
        private Value<bool?> _clothesWasherIndicator;
        public bool? ClothesWasherIndicator { get { return _clothesWasherIndicator; } set { _clothesWasherIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClothesWasherIndicator() => !_clothesWasherIndicator.Clean;
        private Value<DateTime?> _constructionCompletedDate;
        public DateTime? ConstructionCompletedDate { get { return _constructionCompletedDate; } set { _constructionCompletedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionCompletedDate() => !_constructionCompletedDate.Clean;
        private Value<string> _constructionPlan;
        public string ConstructionPlan { get { return _constructionPlan; } set { _constructionPlan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionPlan() => !_constructionPlan.Clean;
        private Value<bool?> _constructionWarrantyIncluded;
        public bool? ConstructionWarrantyIncluded { get { return _constructionWarrantyIncluded; } set { _constructionWarrantyIncluded = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionWarrantyIncluded() => !_constructionWarrantyIncluded.Clean;
        private Value<string> _contractNoApprovedByVA;
        public string ContractNoApprovedByVA { get { return _contractNoApprovedByVA; } set { _contractNoApprovedByVA = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractNoApprovedByVA() => !_contractNoApprovedByVA.Clean;
        private Value<int?> _creditScore;
        public int? CreditScore { get { return _creditScore; } set { _creditScore = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScore() => !_creditScore.Clean;
        private Value<bool?> _currentlyOnMilitaryDuty;
        public bool? CurrentlyOnMilitaryDuty { get { return _currentlyOnMilitaryDuty; } set { _currentlyOnMilitaryDuty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentlyOnMilitaryDuty() => !_currentlyOnMilitaryDuty.Clean;
        private Value<DateTime?> _dateAquiredLand;
        public DateTime? DateAquiredLand { get { return _dateAquiredLand; } set { _dateAquiredLand = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAquiredLand() => !_dateAquiredLand.Clean;
        private Value<DateTime?> _dateOfAssignment;
        public DateTime? DateOfAssignment { get { return _dateOfAssignment; } set { _dateOfAssignment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfAssignment() => !_dateOfAssignment.Clean;
        private Value<DateTime?> _dateSAR;
        public DateTime? DateSAR { get { return _dateSAR; } set { _dateSAR = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateSAR() => !_dateSAR.Clean;
        private Value<decimal?> _disabilityAmountCollected;
        public decimal? DisabilityAmountCollected { get { return _disabilityAmountCollected; } set { _disabilityAmountCollected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabilityAmountCollected() => !_disabilityAmountCollected.Clean;
        private Value<decimal?> _discountPercentage;
        public decimal? DiscountPercentage { get { return _discountPercentage; } set { _discountPercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPercentage() => !_discountPercentage.Clean;
        private Value<decimal?> _discountPoint;
        public decimal? DiscountPoint { get { return _discountPoint; } set { _discountPoint = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoint() => !_discountPoint.Clean;
        private Value<bool?> _dishwasherIndicator;
        public bool? DishwasherIndicator { get { return _dishwasherIndicator; } set { _dishwasherIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDishwasherIndicator() => !_dishwasherIndicator.Clean;
        private Value<bool?> _dryerIndicator;
        public bool? DryerIndicator { get { return _dryerIndicator; } set { _dryerIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDryerIndicator() => !_dryerIndicator.Clean;
        private Value<string> _emailToBeNotifiedWhenUploaded;
        public string EmailToBeNotifiedWhenUploaded { get { return _emailToBeNotifiedWhenUploaded; } set { _emailToBeNotifiedWhenUploaded = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmailToBeNotifiedWhenUploaded() => !_emailToBeNotifiedWhenUploaded.Clean;
        private Value<bool?> _energyImprovementsAdditionOfFeature;
        public bool? EnergyImprovementsAdditionOfFeature { get { return _energyImprovementsAdditionOfFeature; } set { _energyImprovementsAdditionOfFeature = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyImprovementsAdditionOfFeature() => !_energyImprovementsAdditionOfFeature.Clean;
        private Value<string> _entitlementCode;
        public string EntitlementCode { get { return _entitlementCode; } set { _entitlementCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntitlementCode() => !_entitlementCode.Clean;
        private Value<string> _equipmentOtherDescription;
        public string EquipmentOtherDescription { get { return _equipmentOtherDescription; } set { _equipmentOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquipmentOtherDescription() => !_equipmentOtherDescription.Clean;
        private Value<bool?> _excludeTaxesInsuranceIndicator;
        public bool? ExcludeTaxesInsuranceIndicator { get { return _excludeTaxesInsuranceIndicator; } set { _excludeTaxesInsuranceIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcludeTaxesInsuranceIndicator() => !_excludeTaxesInsuranceIndicator.Clean;
        private Value<decimal?> _finalDiscountAmount;
        public decimal? FinalDiscountAmount { get { return _finalDiscountAmount; } set { _finalDiscountAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalDiscountAmount() => !_finalDiscountAmount.Clean;
        private Value<decimal?> _finalFundingFeeAmount;
        public decimal? FinalFundingFeeAmount { get { return _finalFundingFeeAmount; } set { _finalFundingFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalFundingFeeAmount() => !_finalFundingFeeAmount.Clean;
        private Value<bool?> _firstChattelLoanType;
        public bool? FirstChattelLoanType { get { return _firstChattelLoanType; } set { _firstChattelLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChattelLoanType() => !_firstChattelLoanType.Clean;
        private Value<bool?> _firstTimeUse;
        public bool? FirstTimeUse { get { return _firstTimeUse; } set { _firstTimeUse = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTimeUse() => !_firstTimeUse.Clean;
        private Value<bool?> _fundingFeeExempt;
        public bool? FundingFeeExempt { get { return _fundingFeeExempt; } set { _fundingFeeExempt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFeeExempt() => !_fundingFeeExempt.Clean;
        private Value<bool?> _garbageDisposalIndicator;
        public bool? GarbageDisposalIndicator { get { return _garbageDisposalIndicator; } set { _garbageDisposalIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGarbageDisposalIndicator() => !_garbageDisposalIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _initialTotal;
        public decimal? InitialTotal { get { return _initialTotal; } set { _initialTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialTotal() => !_initialTotal.Clean;
        private Value<string> _inspectionWillBeMadeBy;
        public string InspectionWillBeMadeBy { get { return _inspectionWillBeMadeBy; } set { _inspectionWillBeMadeBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionWillBeMadeBy() => !_inspectionWillBeMadeBy.Clean;
        private Value<bool?> _insulation;
        public bool? Insulation { get { return _insulation; } set { _insulation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsulation() => !_insulation.Clean;
        private Value<string> _insuranceType;
        public string InsuranceType { get { return _insuranceType; } set { _insuranceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceType() => !_insuranceType.Clean;
        private Value<int?> _irregularLotSizeInSquareFeet;
        public int? IrregularLotSizeInSquareFeet { get { return _irregularLotSizeInSquareFeet; } set { _irregularLotSizeInSquareFeet = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIrregularLotSizeInSquareFeet() => !_irregularLotSizeInSquareFeet.Clean;
        private Value<bool?> _isDelinquent30Days;
        public bool? IsDelinquent30Days { get { return _isDelinquent30Days; } set { _isDelinquent30Days = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDelinquent30Days() => !_isDelinquent30Days.Clean;
        private Value<string> _keysAtAddress;
        public string KeysAtAddress { get { return _keysAtAddress; } set { _keysAtAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKeysAtAddress() => !_keysAtAddress.Clean;
        private Value<decimal?> _landPurchasePrice;
        public decimal? LandPurchasePrice { get { return _landPurchasePrice; } set { _landPurchasePrice = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandPurchasePrice() => !_landPurchasePrice.Clean;
        private Value<string> _leaseholdType;
        public string LeaseholdType { get { return _leaseholdType; } set { _leaseholdType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseholdType() => !_leaseholdType.Clean;
        private Value<string> _lenderSAR;
        public string LenderSAR { get { return _lenderSAR; } set { _lenderSAR = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderSAR() => !_lenderSAR.Clean;
        private Value<string> _loanAnalysisRemarks1;
        public string LoanAnalysisRemarks1 { get { return _loanAnalysisRemarks1; } set { _loanAnalysisRemarks1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks1() => !_loanAnalysisRemarks1.Clean;
        private Value<string> _loanAnalysisRemarks2;
        public string LoanAnalysisRemarks2 { get { return _loanAnalysisRemarks2; } set { _loanAnalysisRemarks2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks2() => !_loanAnalysisRemarks2.Clean;
        private Value<string> _loanAnalysisRemarks3;
        public string LoanAnalysisRemarks3 { get { return _loanAnalysisRemarks3; } set { _loanAnalysisRemarks3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks3() => !_loanAnalysisRemarks3.Clean;
        private Value<string> _loanAnalysisRemarks4;
        public string LoanAnalysisRemarks4 { get { return _loanAnalysisRemarks4; } set { _loanAnalysisRemarks4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks4() => !_loanAnalysisRemarks4.Clean;
        private Value<string> _loanAnalysisRemarks5;
        public string LoanAnalysisRemarks5 { get { return _loanAnalysisRemarks5; } set { _loanAnalysisRemarks5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks5() => !_loanAnalysisRemarks5.Clean;
        private Value<string> _loanAnalysisRemarks6;
        public string LoanAnalysisRemarks6 { get { return _loanAnalysisRemarks6; } set { _loanAnalysisRemarks6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks6() => !_loanAnalysisRemarks6.Clean;
        private Value<string> _loanAnalysisRemarks7;
        public string LoanAnalysisRemarks7 { get { return _loanAnalysisRemarks7; } set { _loanAnalysisRemarks7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks7() => !_loanAnalysisRemarks7.Clean;
        private Value<string> _loanAnalysisRemarks8;
        public string LoanAnalysisRemarks8 { get { return _loanAnalysisRemarks8; } set { _loanAnalysisRemarks8 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks8() => !_loanAnalysisRemarks8.Clean;
        private Value<string> _loanAnalysisRemarks9;
        public string LoanAnalysisRemarks9 { get { return _loanAnalysisRemarks9; } set { _loanAnalysisRemarks9 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks9() => !_loanAnalysisRemarks9.Clean;
        private Value<string> _loanCode;
        public string LoanCode { get { return _loanCode; } set { _loanCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanCode() => !_loanCode.Clean;
        private Value<string> _loanProcedure;
        public string LoanProcedure { get { return _loanProcedure; } set { _loanProcedure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProcedure() => !_loanProcedure.Clean;
        private Value<bool?> _loanProcessedUnderAU;
        public bool? LoanProcessedUnderAU { get { return _loanProcessedUnderAU; } set { _loanProcessedUnderAU = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProcessedUnderAU() => !_loanProcessedUnderAU.Clean;
        private Value<string> _loanSummaryRemarks1;
        public string LoanSummaryRemarks1 { get { return _loanSummaryRemarks1; } set { _loanSummaryRemarks1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks1() => !_loanSummaryRemarks1.Clean;
        private Value<string> _loanSummaryRemarks2;
        public string LoanSummaryRemarks2 { get { return _loanSummaryRemarks2; } set { _loanSummaryRemarks2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks2() => !_loanSummaryRemarks2.Clean;
        private Value<string> _loanSummaryRemarks3;
        public string LoanSummaryRemarks3 { get { return _loanSummaryRemarks3; } set { _loanSummaryRemarks3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks3() => !_loanSummaryRemarks3.Clean;
        private Value<string> _loanSummaryRemarks4;
        public string LoanSummaryRemarks4 { get { return _loanSummaryRemarks4; } set { _loanSummaryRemarks4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks4() => !_loanSummaryRemarks4.Clean;
        private Value<string> _loanSummaryRemarks5;
        public string LoanSummaryRemarks5 { get { return _loanSummaryRemarks5; } set { _loanSummaryRemarks5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks5() => !_loanSummaryRemarks5.Clean;
        private Value<string> _loanSummaryRemarks6;
        public string LoanSummaryRemarks6 { get { return _loanSummaryRemarks6; } set { _loanSummaryRemarks6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks6() => !_loanSummaryRemarks6.Clean;
        private Value<string> _loanSummaryRemarks7;
        public string LoanSummaryRemarks7 { get { return _loanSummaryRemarks7; } set { _loanSummaryRemarks7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks7() => !_loanSummaryRemarks7.Clean;
        private Value<string> _loanSummaryRemarks8;
        public string LoanSummaryRemarks8 { get { return _loanSummaryRemarks8; } set { _loanSummaryRemarks8 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks8() => !_loanSummaryRemarks8.Clean;
        private Value<string> _lotDimensions;
        public string LotDimensions { get { return _lotDimensions; } set { _lotDimensions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotDimensions() => !_lotDimensions.Clean;
        private Value<string> _mailingAddress;
        public string MailingAddress { get { return _mailingAddress; } set { _mailingAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingAddress() => !_mailingAddress.Clean;
        private Value<string> _mailingCity;
        public string MailingCity { get { return _mailingCity; } set { _mailingCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingCity() => !_mailingCity.Clean;
        private Value<string> _mailingPostalCode;
        public string MailingPostalCode { get { return _mailingPostalCode; } set { _mailingPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingPostalCode() => !_mailingPostalCode.Clean;
        private Value<string> _mailingState;
        public string MailingState { get { return _mailingState; } set { _mailingState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingState() => !_mailingState.Clean;
        private Value<string> _manufacturedHome;
        public string ManufacturedHome { get { return _manufacturedHome; } set { _manufacturedHome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHome() => !_manufacturedHome.Clean;
        private Value<string> _mCRVNumber;
        public string MCRVNumber { get { return _mCRVNumber; } set { _mCRVNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMCRVNumber() => !_mCRVNumber.Clean;
        private Value<string> _militaryBranchOfService;
        public string MilitaryBranchOfService { get { return _militaryBranchOfService; } set { _militaryBranchOfService = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryBranchOfService() => !_militaryBranchOfService.Clean;
        private Value<List<MilitaryService>> _militaryServices;
        public List<MilitaryService> MilitaryServices { get { return _militaryServices; } set { _militaryServices = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryServices() => !_militaryServices.Clean;
        private Value<string> _mineralRightsReserved;
        public string MineralRightsReserved { get { return _mineralRightsReserved; } set { _mineralRightsReserved = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMineralRightsReserved() => !_mineralRightsReserved.Clean;
        private Value<string> _nameOfOccupant;
        public string NameOfOccupant { get { return _nameOfOccupant; } set { _nameOfOccupant = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfOccupant() => !_nameOfOccupant.Clean;
        private Value<string> _nameOfOwner;
        public string NameOfOwner { get { return _nameOfOwner; } set { _nameOfOwner = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfOwner() => !_nameOfOwner.Clean;
        private Value<string> _nameOfWarrantyProgram;
        public string NameOfWarrantyProgram { get { return _nameOfWarrantyProgram; } set { _nameOfWarrantyProgram = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfWarrantyProgram() => !_nameOfWarrantyProgram.Clean;
        private Value<decimal?> _negativeRents;
        public decimal? NegativeRents { get { return _negativeRents; } set { _negativeRents = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegativeRents() => !_negativeRents.Clean;
        private Value<bool?> _noEnergyImprovements;
        public bool? NoEnergyImprovements { get { return _noEnergyImprovements; } set { _noEnergyImprovements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoEnergyImprovements() => !_noEnergyImprovements.Clean;
        private Value<string> _nonrealtyDescription;
        public string NonrealtyDescription { get { return _nonrealtyDescription; } set { _nonrealtyDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonrealtyDescription() => !_nonrealtyDescription.Clean;
        private Value<string> _numberOfBuildings;
        public string NumberOfBuildings { get { return _numberOfBuildings; } set { _numberOfBuildings = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfBuildings() => !_numberOfBuildings.Clean;
        private Value<string> _occupantTelephone;
        public string OccupantTelephone { get { return _occupantTelephone; } set { _occupantTelephone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupantTelephone() => !_occupantTelephone.Clean;
        private Value<bool?> _onMilitaryDutyFollowingSeparation;
        public bool? OnMilitaryDutyFollowingSeparation { get { return _onMilitaryDutyFollowingSeparation; } set { _onMilitaryDutyFollowingSeparation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOnMilitaryDutyFollowingSeparation() => !_onMilitaryDutyFollowingSeparation.Clean;
        private Value<decimal?> _originalInterestRate;
        public decimal? OriginalInterestRate { get { return _originalInterestRate; } set { _originalInterestRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalInterestRate() => !_originalInterestRate.Clean;
        private Value<decimal?> _originalLoanAmount;
        public decimal? OriginalLoanAmount { get { return _originalLoanAmount; } set { _originalLoanAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalLoanAmount() => !_originalLoanAmount.Clean;
        private Value<int?> _originalTerm;
        public int? OriginalTerm { get { return _originalTerm; } set { _originalTerm = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalTerm() => !_originalTerm.Clean;
        private Value<bool?> _originalValueEstimateChanged;
        public bool? OriginalValueEstimateChanged { get { return _originalValueEstimateChanged; } set { _originalValueEstimateChanged = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalValueEstimateChanged() => !_originalValueEstimateChanged.Clean;
        private Value<decimal?> _originationFeeAmount;
        public decimal? OriginationFeeAmount { get { return _originationFeeAmount; } set { _originationFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeAmount() => !_originationFeeAmount.Clean;
        private Value<decimal?> _otherClosingCosts;
        public decimal? OtherClosingCosts { get { return _otherClosingCosts; } set { _otherClosingCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherClosingCosts() => !_otherClosingCosts.Clean;
        private Value<string> _otherDescriptionEstateProperty;
        public string OtherDescriptionEstateProperty { get { return _otherDescriptionEstateProperty; } set { _otherDescriptionEstateProperty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescriptionEstateProperty() => !_otherDescriptionEstateProperty.Clean;
        private Value<string> _otherDescriptionLoanType;
        public string OtherDescriptionLoanType { get { return _otherDescriptionLoanType; } set { _otherDescriptionLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescriptionLoanType() => !_otherDescriptionLoanType.Clean;
        private Value<bool?> _otherEstateProperty;
        public bool? OtherEstateProperty { get { return _otherEstateProperty; } set { _otherEstateProperty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherEstateProperty() => !_otherEstateProperty.Clean;
        private Value<bool?> _otherImprovements;
        public bool? OtherImprovements { get { return _otherImprovements; } set { _otherImprovements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherImprovements() => !_otherImprovements.Clean;
        private Value<bool?> _otherLoanType;
        public bool? OtherLoanType { get { return _otherLoanType; } set { _otherLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLoanType() => !_otherLoanType.Clean;
        private Value<string> _paidInFullVALoanNumber;
        public string PaidInFullVALoanNumber { get { return _paidInFullVALoanNumber; } set { _paidInFullVALoanNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidInFullVALoanNumber() => !_paidInFullVALoanNumber.Clean;
        private Value<bool?> _payoffIndicator1;
        public bool? PayoffIndicator1 { get { return _payoffIndicator1; } set { _payoffIndicator1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator1() => !_payoffIndicator1.Clean;
        private Value<bool?> _payoffIndicator2;
        public bool? PayoffIndicator2 { get { return _payoffIndicator2; } set { _payoffIndicator2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator2() => !_payoffIndicator2.Clean;
        private Value<bool?> _payoffIndicator3;
        public bool? PayoffIndicator3 { get { return _payoffIndicator3; } set { _payoffIndicator3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator3() => !_payoffIndicator3.Clean;
        private Value<bool?> _payoffIndicator4;
        public bool? PayoffIndicator4 { get { return _payoffIndicator4; } set { _payoffIndicator4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator4() => !_payoffIndicator4.Clean;
        private Value<bool?> _payoffIndicator5;
        public bool? PayoffIndicator5 { get { return _payoffIndicator5; } set { _payoffIndicator5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator5() => !_payoffIndicator5.Clean;
        private Value<bool?> _payoffIndicator6;
        public bool? PayoffIndicator6 { get { return _payoffIndicator6; } set { _payoffIndicator6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator6() => !_payoffIndicator6.Clean;
        private Value<bool?> _payoffIndicator7;
        public bool? PayoffIndicator7 { get { return _payoffIndicator7; } set { _payoffIndicator7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator7() => !_payoffIndicator7.Clean;
        private Value<bool?> _payoffIndicator8;
        public bool? PayoffIndicator8 { get { return _payoffIndicator8; } set { _payoffIndicator8 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator8() => !_payoffIndicator8.Clean;
        private Value<bool?> _payoffIndicator9;
        public bool? PayoffIndicator9 { get { return _payoffIndicator9; } set { _payoffIndicator9 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator9() => !_payoffIndicator9.Clean;
        private Value<decimal?> _pestReportFee;
        public decimal? PestReportFee { get { return _pestReportFee; } set { _pestReportFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePestReportFee() => !_pestReportFee.Clean;
        private Value<string> _plansSubmitted;
        public string PlansSubmitted { get { return _plansSubmitted; } set { _plansSubmitted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlansSubmitted() => !_plansSubmitted.Clean;
        private Value<string> _pOCAddress;
        public string POCAddress { get { return _pOCAddress; } set { _pOCAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCAddress() => !_pOCAddress.Clean;
        private Value<string> _pOCCity;
        public string POCCity { get { return _pOCCity; } set { _pOCCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCCity() => !_pOCCity.Clean;
        private Value<string> _pOCName;
        public string POCName { get { return _pOCName; } set { _pOCName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCName() => !_pOCName.Clean;
        private Value<string> _pOCPhone;
        public string POCPhone { get { return _pOCPhone; } set { _pOCPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCPhone() => !_pOCPhone.Clean;
        private Value<string> _pOCState;
        public string POCState { get { return _pOCState; } set { _pOCState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCState() => !_pOCState.Clean;
        private Value<string> _pOCZipCode;
        public string POCZipCode { get { return _pOCZipCode; } set { _pOCZipCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCZipCode() => !_pOCZipCode.Clean;
        private Value<decimal?> _preliminaryDiscountAmount;
        public decimal? PreliminaryDiscountAmount { get { return _preliminaryDiscountAmount; } set { _preliminaryDiscountAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryDiscountAmount() => !_preliminaryDiscountAmount.Clean;
        private Value<decimal?> _preliminaryFundingFeeAmount;
        public decimal? PreliminaryFundingFeeAmount { get { return _preliminaryFundingFeeAmount; } set { _preliminaryFundingFeeAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryFundingFeeAmount() => !_preliminaryFundingFeeAmount.Clean;
        private Value<decimal?> _preliminaryTotal;
        public decimal? PreliminaryTotal { get { return _preliminaryTotal; } set { _preliminaryTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryTotal() => !_preliminaryTotal.Clean;
        private Value<bool?> _previousVALoanIndicator;
        public bool? PreviousVALoanIndicator { get { return _previousVALoanIndicator; } set { _previousVALoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousVALoanIndicator() => !_previousVALoanIndicator.Clean;
        private Value<List<PreviousVaLoan>> _previousVaLoans;
        public List<PreviousVaLoan> PreviousVaLoans { get { return _previousVaLoans; } set { _previousVaLoans = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousVaLoans() => !_previousVaLoans.Clean;
        private Value<bool?> _priorApprovalProcedure;
        public bool? PriorApprovalProcedure { get { return _priorApprovalProcedure; } set { _priorApprovalProcedure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorApprovalProcedure() => !_priorApprovalProcedure.Clean;
        private Value<string> _priorLoanType;
        public string PriorLoanType { get { return _priorLoanType; } set { _priorLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanType() => !_priorLoanType.Clean;
        private Value<string> _propertyDesignation;
        public string PropertyDesignation { get { return _propertyDesignation; } set { _propertyDesignation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyDesignation() => !_propertyDesignation.Clean;
        private Value<int?> _propertyGrossLivingArea;
        public int? PropertyGrossLivingArea { get { return _propertyGrossLivingArea; } set { _propertyGrossLivingArea = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyGrossLivingArea() => !_propertyGrossLivingArea.Clean;
        private Value<string> _propertyLegalDescription1;
        public string PropertyLegalDescription1 { get { return _propertyLegalDescription1; } set { _propertyLegalDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription1() => !_propertyLegalDescription1.Clean;
        private Value<string> _propertyLegalDescription2;
        public string PropertyLegalDescription2 { get { return _propertyLegalDescription2; } set { _propertyLegalDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription2() => !_propertyLegalDescription2.Clean;
        private Value<string> _propertyLegalDescription3;
        public string PropertyLegalDescription3 { get { return _propertyLegalDescription3; } set { _propertyLegalDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription3() => !_propertyLegalDescription3.Clean;
        private Value<string> _propertyLegalDescription4;
        public string PropertyLegalDescription4 { get { return _propertyLegalDescription4; } set { _propertyLegalDescription4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription4() => !_propertyLegalDescription4.Clean;
        private Value<string> _propertyOccupancyType;
        public string PropertyOccupancyType { get { return _propertyOccupancyType; } set { _propertyOccupancyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOccupancyType() => !_propertyOccupancyType.Clean;
        private Value<bool?> _proposedSaleContractAttached;
        public bool? ProposedSaleContractAttached { get { return _proposedSaleContractAttached; } set { _proposedSaleContractAttached = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedSaleContractAttached() => !_proposedSaleContractAttached.Clean;
        private Value<string> _purposeOfLoan;
        public string PurposeOfLoan { get { return _purposeOfLoan; } set { _purposeOfLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurposeOfLoan() => !_purposeOfLoan.Clean;
        private Value<bool?> _rangeOvenIndicator;
        public bool? RangeOvenIndicator { get { return _rangeOvenIndicator; } set { _rangeOvenIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangeOvenIndicator() => !_rangeOvenIndicator.Clean;
        private Value<bool?> _reasonableValueCompleted;
        public bool? ReasonableValueCompleted { get { return _reasonableValueCompleted; } set { _reasonableValueCompleted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonableValueCompleted() => !_reasonableValueCompleted.Clean;
        private Value<bool?> _refrigeratorIndicator;
        public bool? RefrigeratorIndicator { get { return _refrigeratorIndicator; } set { _refrigeratorIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefrigeratorIndicator() => !_refrigeratorIndicator.Clean;
        private Value<string> _rent;
        public string Rent { get { return _rent; } set { _rent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRent() => !_rent.Clean;
        private Value<bool?> _replacementOfSystem;
        public bool? ReplacementOfSystem { get { return _replacementOfSystem; } set { _replacementOfSystem = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReplacementOfSystem() => !_replacementOfSystem.Clean;
        private Value<string> _riskClasification;
        public string RiskClasification { get { return _riskClasification; } set { _riskClasification = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskClasification() => !_riskClasification.Clean;
        private Value<string> _serviceNumber;
        public string ServiceNumber { get { return _serviceNumber; } set { _serviceNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceNumber() => !_serviceNumber.Clean;
        private Value<bool?> _solarHeatingOrCooling;
        public bool? SolarHeatingOrCooling { get { return _solarHeatingOrCooling; } set { _solarHeatingOrCooling = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSolarHeatingOrCooling() => !_solarHeatingOrCooling.Clean;
        private Value<string> _specialAssessmentComments1;
        public string SpecialAssessmentComments1 { get { return _specialAssessmentComments1; } set { _specialAssessmentComments1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments1() => !_specialAssessmentComments1.Clean;
        private Value<string> _specialAssessmentComments2;
        public string SpecialAssessmentComments2 { get { return _specialAssessmentComments2; } set { _specialAssessmentComments2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments2() => !_specialAssessmentComments2.Clean;
        private Value<string> _specialAssessmentComments3;
        public string SpecialAssessmentComments3 { get { return _specialAssessmentComments3; } set { _specialAssessmentComments3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments3() => !_specialAssessmentComments3.Clean;
        private Value<string> _streetAccess;
        public string StreetAccess { get { return _streetAccess; } set { _streetAccess = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAccess() => !_streetAccess.Clean;
        private Value<string> _streetMaintenance;
        public string StreetMaintenance { get { return _streetMaintenance; } set { _streetMaintenance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetMaintenance() => !_streetMaintenance.Clean;
        private Value<string> _systemUsed;
        public string SystemUsed { get { return _systemUsed; } set { _systemUsed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemUsed() => !_systemUsed.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<string> _titleLimitations1;
        public string TitleLimitations1 { get { return _titleLimitations1; } set { _titleLimitations1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations1() => !_titleLimitations1.Clean;
        private Value<string> _titleLimitations2;
        public string TitleLimitations2 { get { return _titleLimitations2; } set { _titleLimitations2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations2() => !_titleLimitations2.Clean;
        private Value<string> _titleLimitations3;
        public string TitleLimitations3 { get { return _titleLimitations3; } set { _titleLimitations3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations3() => !_titleLimitations3.Clean;
        private Value<decimal?> _totalBaths;
        public decimal? TotalBaths { get { return _totalBaths; } set { _totalBaths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBaths() => !_totalBaths.Clean;
        private Value<int?> _totalBedrooms;
        public int? TotalBedrooms { get { return _totalBedrooms; } set { _totalBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBedrooms() => !_totalBedrooms.Clean;
        private Value<decimal?> _totalDebtMonthlyPayment;
        public decimal? TotalDebtMonthlyPayment { get { return _totalDebtMonthlyPayment; } set { _totalDebtMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDebtMonthlyPayment() => !_totalDebtMonthlyPayment.Clean;
        private Value<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointCharged() => !_totalDiscountPointCharged.Clean;
        private Value<decimal?> _totalDiscountPointsCharged;
        public decimal? TotalDiscountPointsCharged { get { return _totalDiscountPointsCharged; } set { _totalDiscountPointsCharged = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointsCharged() => !_totalDiscountPointsCharged.Clean;
        private Value<decimal?> _totalForMaxLoanAmount;
        public decimal? TotalForMaxLoanAmount { get { return _totalForMaxLoanAmount; } set { _totalForMaxLoanAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForMaxLoanAmount() => !_totalForMaxLoanAmount.Clean;
        private Value<decimal?> _totalMonthlyPayment;
        public decimal? TotalMonthlyPayment { get { return _totalMonthlyPayment; } set { _totalMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyPayment() => !_totalMonthlyPayment.Clean;
        private Value<decimal?> _totalProposedMonthlyPayment;
        public decimal? TotalProposedMonthlyPayment { get { return _totalProposedMonthlyPayment; } set { _totalProposedMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalProposedMonthlyPayment() => !_totalProposedMonthlyPayment.Clean;
        private Value<int?> _totalRooms;
        public int? TotalRooms { get { return _totalRooms; } set { _totalRooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRooms() => !_totalRooms.Clean;
        private Value<decimal?> _totalUnpaidSpecialAssessments;
        public decimal? TotalUnpaidSpecialAssessments { get { return _totalUnpaidSpecialAssessments; } set { _totalUnpaidSpecialAssessments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalUnpaidSpecialAssessments() => !_totalUnpaidSpecialAssessments.Clean;
        private Value<string> _typeOfHybridARM;
        public string TypeOfHybridARM { get { return _typeOfHybridARM; } set { _typeOfHybridARM = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfHybridARM() => !_typeOfHybridARM.Clean;
        private Value<string> _typeOfMortgage;
        public string TypeOfMortgage { get { return _typeOfMortgage; } set { _typeOfMortgage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfMortgage() => !_typeOfMortgage.Clean;
        private Value<string> _typeOfOwnsership;
        public string TypeOfOwnsership { get { return _typeOfOwnsership; } set { _typeOfOwnsership = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfOwnsership() => !_typeOfOwnsership.Clean;
        private Value<string> _typeOfStructure;
        public string TypeOfStructure { get { return _typeOfStructure; } set { _typeOfStructure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfStructure() => !_typeOfStructure.Clean;
        private Value<string> _typeOfVeteran;
        public string TypeOfVeteran { get { return _typeOfVeteran; } set { _typeOfVeteran = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfVeteran() => !_typeOfVeteran.Clean;
        private Value<bool?> _unsecuredLoanType;
        public bool? UnsecuredLoanType { get { return _unsecuredLoanType; } set { _unsecuredLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnsecuredLoanType() => !_unsecuredLoanType.Clean;
        private Value<string> _utilitiesElectricDescription;
        public string UtilitiesElectricDescription { get { return _utilitiesElectricDescription; } set { _utilitiesElectricDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesElectricDescription() => !_utilitiesElectricDescription.Clean;
        private Value<string> _utilitiesGasDescription;
        public string UtilitiesGasDescription { get { return _utilitiesGasDescription; } set { _utilitiesGasDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesGasDescription() => !_utilitiesGasDescription.Clean;
        private Value<string> _utilitiesSewerDescription;
        public string UtilitiesSewerDescription { get { return _utilitiesSewerDescription; } set { _utilitiesSewerDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesSewerDescription() => !_utilitiesSewerDescription.Clean;
        private Value<string> _utilitiesWaterDescription;
        public string UtilitiesWaterDescription { get { return _utilitiesWaterDescription; } set { _utilitiesWaterDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesWaterDescription() => !_utilitiesWaterDescription.Clean;
        private Value<DateTime?> _vAAppraisalSentDate;
        public DateTime? VAAppraisalSentDate { get { return _vAAppraisalSentDate; } set { _vAAppraisalSentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAAppraisalSentDate() => !_vAAppraisalSentDate.Clean;
        private Value<string> _vABenefitRelatedIndebtedness;
        public string VABenefitRelatedIndebtedness { get { return _vABenefitRelatedIndebtedness; } set { _vABenefitRelatedIndebtedness = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABenefitRelatedIndebtedness() => !_vABenefitRelatedIndebtedness.Clean;
        private Value<string> _vABuilderDescription;
        public string VABuilderDescription { get { return _vABuilderDescription; } set { _vABuilderDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABuilderDescription() => !_vABuilderDescription.Clean;
        private Value<string> _vABuilderIDNo;
        public string VABuilderIDNo { get { return _vABuilderIDNo; } set { _vABuilderIDNo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABuilderIDNo() => !_vABuilderIDNo.Clean;
        private Value<string> _vAClaimFolderNumber;
        public string VAClaimFolderNumber { get { return _vAClaimFolderNumber; } set { _vAClaimFolderNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAClaimFolderNumber() => !_vAClaimFolderNumber.Clean;
        private Value<string> _vAClaimNumber;
        public string VAClaimNumber { get { return _vAClaimNumber; } set { _vAClaimNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAClaimNumber() => !_vAClaimNumber.Clean;
        private Value<DateTime?> _vADateNOVAppraisalMailedToBorrower;
        public DateTime? VADateNOVAppraisalMailedToBorrower { get { return _vADateNOVAppraisalMailedToBorrower; } set { _vADateNOVAppraisalMailedToBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVADateNOVAppraisalMailedToBorrower() => !_vADateNOVAppraisalMailedToBorrower.Clean;
        private Value<bool?> _vAIsDelinquent30Days;
        public bool? VAIsDelinquent30Days { get { return _vAIsDelinquent30Days; } set { _vAIsDelinquent30Days = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAIsDelinquent30Days() => !_vAIsDelinquent30Days.Clean;
        private Value<bool?> _vALatePaymentIn6Months;
        public bool? VALatePaymentIn6Months { get { return _vALatePaymentIn6Months; } set { _vALatePaymentIn6Months = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVALatePaymentIn6Months() => !_vALatePaymentIn6Months.Clean;
        private Value<string> _vaLoanSummaryApplicantType;
        public string VaLoanSummaryApplicantType { get { return _vaLoanSummaryApplicantType; } set { _vaLoanSummaryApplicantType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaLoanSummaryApplicantType() => !_vaLoanSummaryApplicantType.Clean;
        private Value<DateTime?> _vANOVDateReceived;
        public DateTime? VANOVDateReceived { get { return _vANOVDateReceived; } set { _vANOVDateReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVDateReceived() => !_vANOVDateReceived.Clean;
        private Value<DateTime?> _vANOVDateReviewed;
        public DateTime? VANOVDateReviewed { get { return _vANOVDateReviewed; } set { _vANOVDateReviewed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVDateReviewed() => !_vANOVDateReviewed.Clean;
        private Value<DateTime?> _vANOVIssuedDate;
        public DateTime? VANOVIssuedDate { get { return _vANOVIssuedDate; } set { _vANOVIssuedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVIssuedDate() => !_vANOVIssuedDate.Clean;
        private Value<string> _vAOriginalAmortizationType;
        public string VAOriginalAmortizationType { get { return _vAOriginalAmortizationType; } set { _vAOriginalAmortizationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAOriginalAmortizationType() => !_vAOriginalAmortizationType.Clean;
        private Value<decimal?> _vAOriginalMonthlyPayment;
        public decimal? VAOriginalMonthlyPayment { get { return _vAOriginalMonthlyPayment; } set { _vAOriginalMonthlyPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAOriginalMonthlyPayment() => !_vAOriginalMonthlyPayment.Clean;
        private Value<string> _vAQualification2ndTierEntitlement;
        public string VAQualification2ndTierEntitlement { get { return _vAQualification2ndTierEntitlement; } set { _vAQualification2ndTierEntitlement = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualification2ndTierEntitlement() => !_vAQualification2ndTierEntitlement.Clean;
        private Value<string> _vAQualificationCountryRegion;
        public string VAQualificationCountryRegion { get { return _vAQualificationCountryRegion; } set { _vAQualificationCountryRegion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualificationCountryRegion() => !_vAQualificationCountryRegion.Clean;
        private Value<decimal?> _vAQualificationCountyLimits;
        public decimal? VAQualificationCountyLimits { get { return _vAQualificationCountyLimits; } set { _vAQualificationCountyLimits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualificationCountyLimits() => !_vAQualificationCountyLimits.Clean;
        private Value<int?> _vARecoupmentClosingCosts;
        public int? VARecoupmentClosingCosts { get { return _vARecoupmentClosingCosts; } set { _vARecoupmentClosingCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentClosingCosts() => !_vARecoupmentClosingCosts.Clean;
        private Value<bool?> _vARecoupmentExcludePrepaids;
        public bool? VARecoupmentExcludePrepaids { get { return _vARecoupmentExcludePrepaids; } set { _vARecoupmentExcludePrepaids = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentExcludePrepaids() => !_vARecoupmentExcludePrepaids.Clean;
        private Value<decimal?> _vARecoupmentMonthlyDecreaseInPayment;
        public decimal? VARecoupmentMonthlyDecreaseInPayment { get { return _vARecoupmentMonthlyDecreaseInPayment; } set { _vARecoupmentMonthlyDecreaseInPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentMonthlyDecreaseInPayment() => !_vARecoupmentMonthlyDecreaseInPayment.Clean;
        private Value<int?> _vARecoupmentMonths;
        public int? VARecoupmentMonths { get { return _vARecoupmentMonths; } set { _vARecoupmentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentMonths() => !_vARecoupmentMonths.Clean;
        private Value<decimal?> _vARecoupmentTotalClosingCosts;
        public decimal? VARecoupmentTotalClosingCosts { get { return _vARecoupmentTotalClosingCosts; } set { _vARecoupmentTotalClosingCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentTotalClosingCosts() => !_vARecoupmentTotalClosingCosts.Clean;
        private Value<int?> _vARecoupmentYears;
        public int? VARecoupmentYears { get { return _vARecoupmentYears; } set { _vARecoupmentYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentYears() => !_vARecoupmentYears.Clean;
        private Value<DateTime?> _vATrackingCertOfCommitmentIssued;
        public DateTime? VATrackingCertOfCommitmentIssued { get { return _vATrackingCertOfCommitmentIssued; } set { _vATrackingCertOfCommitmentIssued = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCertOfCommitmentIssued() => !_vATrackingCertOfCommitmentIssued.Clean;
        private Value<DateTime?> _vATrackingCOEIssueDate;
        public DateTime? VATrackingCOEIssueDate { get { return _vATrackingCOEIssueDate; } set { _vATrackingCOEIssueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCOEIssueDate() => !_vATrackingCOEIssueDate.Clean;
        private Value<string> _vATrackingCOEIssueHistory;
        public string VATrackingCOEIssueHistory { get { return _vATrackingCOEIssueHistory; } set { _vATrackingCOEIssueHistory = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCOEIssueHistory() => !_vATrackingCOEIssueHistory.Clean;
        private Value<DateTime?> _vATrackingFinalApprovalCommitmentDate;
        public DateTime? VATrackingFinalApprovalCommitmentDate { get { return _vATrackingFinalApprovalCommitmentDate; } set { _vATrackingFinalApprovalCommitmentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingFinalApprovalCommitmentDate() => !_vATrackingFinalApprovalCommitmentDate.Clean;
        private Value<bool?> _vATrackingGSAExclusionaryListChecked;
        public bool? VATrackingGSAExclusionaryListChecked { get { return _vATrackingGSAExclusionaryListChecked; } set { _vATrackingGSAExclusionaryListChecked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingGSAExclusionaryListChecked() => !_vATrackingGSAExclusionaryListChecked.Clean;
        private Value<bool?> _vATrackingInuranceFloodPolicy;
        public bool? VATrackingInuranceFloodPolicy { get { return _vATrackingInuranceFloodPolicy; } set { _vATrackingInuranceFloodPolicy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceFloodPolicy() => !_vATrackingInuranceFloodPolicy.Clean;
        private Value<bool?> _vATrackingInuranceHazardPolicy;
        public bool? VATrackingInuranceHazardPolicy { get { return _vATrackingInuranceHazardPolicy; } set { _vATrackingInuranceHazardPolicy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceHazardPolicy() => !_vATrackingInuranceHazardPolicy.Clean;
        private Value<bool?> _vATrackingInuranceWindOrHailPolicy;
        public bool? VATrackingInuranceWindOrHailPolicy { get { return _vATrackingInuranceWindOrHailPolicy; } set { _vATrackingInuranceWindOrHailPolicy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceWindOrHailPolicy() => !_vATrackingInuranceWindOrHailPolicy.Clean;
        private Value<bool?> _vATrackingInuranceWoodDestroyingPolicy;
        public bool? VATrackingInuranceWoodDestroyingPolicy { get { return _vATrackingInuranceWoodDestroyingPolicy; } set { _vATrackingInuranceWoodDestroyingPolicy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceWoodDestroyingPolicy() => !_vATrackingInuranceWoodDestroyingPolicy.Clean;
        private Value<bool?> _vATrackingIsSARLAPPCertified;
        public bool? VATrackingIsSARLAPPCertified { get { return _vATrackingIsSARLAPPCertified; } set { _vATrackingIsSARLAPPCertified = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingIsSARLAPPCertified() => !_vATrackingIsSARLAPPCertified.Clean;
        private Value<DateTime?> _vATrackingLoanGuaranteeCertReceipt;
        public DateTime? VATrackingLoanGuaranteeCertReceipt { get { return _vATrackingLoanGuaranteeCertReceipt; } set { _vATrackingLoanGuaranteeCertReceipt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingLoanGuaranteeCertReceipt() => !_vATrackingLoanGuaranteeCertReceipt.Clean;
        private Value<DateTime?> _vATrackingMasterCommitmentLockExpired;
        public DateTime? VATrackingMasterCommitmentLockExpired { get { return _vATrackingMasterCommitmentLockExpired; } set { _vATrackingMasterCommitmentLockExpired = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingMasterCommitmentLockExpired() => !_vATrackingMasterCommitmentLockExpired.Clean;
        private Value<DateTime?> _vATrackingOrderedDate;
        public DateTime? VATrackingOrderedDate { get { return _vATrackingOrderedDate; } set { _vATrackingOrderedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingOrderedDate() => !_vATrackingOrderedDate.Clean;
        private Value<DateTime?> _vATrackingPaidDate;
        public DateTime? VATrackingPaidDate { get { return _vATrackingPaidDate; } set { _vATrackingPaidDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingPaidDate() => !_vATrackingPaidDate.Clean;
        private Value<DateTime?> _vATrackingPurchaseContractDate;
        public DateTime? VATrackingPurchaseContractDate { get { return _vATrackingPurchaseContractDate; } set { _vATrackingPurchaseContractDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingPurchaseContractDate() => !_vATrackingPurchaseContractDate.Clean;
        private Value<bool?> _vATrackingReceiptReceived;
        public bool? VATrackingReceiptReceived { get { return _vATrackingReceiptReceived; } set { _vATrackingReceiptReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingReceiptReceived() => !_vATrackingReceiptReceived.Clean;
        private Value<string> _vATrackingSARID;
        public string VATrackingSARID { get { return _vATrackingSARID; } set { _vATrackingSARID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingSARID() => !_vATrackingSARID.Clean;
        private Value<string> _vATrackingSARName;
        public string VATrackingSARName { get { return _vATrackingSARName; } set { _vATrackingSARName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingSARName() => !_vATrackingSARName.Clean;
        private Value<bool?> _ventFanIndicator;
        public bool? VentFanIndicator { get { return _ventFanIndicator; } set { _ventFanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVentFanIndicator() => !_ventFanIndicator.Clean;
        private Value<bool?> _veteranDischargedIndicator;
        public bool? VeteranDischargedIndicator { get { return _veteranDischargedIndicator; } set { _veteranDischargedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVeteranDischargedIndicator() => !_veteranDischargedIndicator.Clean;
        private Value<string> _veteranServiceType;
        public string VeteranServiceType { get { return _veteranServiceType; } set { _veteranServiceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVeteranServiceType() => !_veteranServiceType.Clean;
        private Value<string> _warrantorAddress;
        public string WarrantorAddress { get { return _warrantorAddress; } set { _warrantorAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorAddress() => !_warrantorAddress.Clean;
        private Value<string> _warrantorCity;
        public string WarrantorCity { get { return _warrantorCity; } set { _warrantorCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorCity() => !_warrantorCity.Clean;
        private Value<string> _warrantorName;
        public string WarrantorName { get { return _warrantorName; } set { _warrantorName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorName() => !_warrantorName.Clean;
        private Value<string> _warrantorPhone;
        public string WarrantorPhone { get { return _warrantorPhone; } set { _warrantorPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorPhone() => !_warrantorPhone.Clean;
        private Value<string> _warrantorPostalCode;
        public string WarrantorPostalCode { get { return _warrantorPostalCode; } set { _warrantorPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorPostalCode() => !_warrantorPostalCode.Clean;
        private Value<string> _warrantorState;
        public string WarrantorState { get { return _warrantorState; } set { _warrantorState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorState() => !_warrantorState.Clean;
        private Value<DateTime?> _warrantyProgramExpirationDate;
        public DateTime? WarrantyProgramExpirationDate { get { return _warrantyProgramExpirationDate; } set { _warrantyProgramExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantyProgramExpirationDate() => !_warrantyProgramExpirationDate.Clean;
        private Value<bool?> _wWCarpetIndicator;
        public bool? WWCarpetIndicator { get { return _wWCarpetIndicator; } set { _wWCarpetIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWWCarpetIndicator() => !_wWCarpetIndicator.Clean;
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
                var v0 = _acres; v0.Clean = value; _acres = v0;
                var v1 = _additionalSecurityDescription; v1.Clean = value; _additionalSecurityDescription = v1;
                var v2 = _administratorAddress; v2.Clean = value; _administratorAddress = v2;
                var v3 = _administratorCity; v3.Clean = value; _administratorCity = v3;
                var v4 = _administratorContact; v4.Clean = value; _administratorContact = v4;
                var v5 = _administratorName; v5.Clean = value; _administratorName = v5;
                var v6 = _administratorPostalCode; v6.Clean = value; _administratorPostalCode = v6;
                var v7 = _administratorState; v7.Clean = value; _administratorState = v7;
                var v8 = _ageOfProperty; v8.Clean = value; _ageOfProperty = v8;
                var v9 = _amountSpentOnEnergyImprovements; v9.Clean = value; _amountSpentOnEnergyImprovements = v9;
                var v10 = _amountTypeWithheld; v10.Clean = value; _amountTypeWithheld = v10;
                var v11 = _amountWithheld; v11.Clean = value; _amountWithheld = v11;
                var v12 = _annualGroundRent; v12.Clean = value; _annualGroundRent = v12;
                var v13 = _annualMaintenanceAssessment; v13.Clean = value; _annualMaintenanceAssessment = v13;
                var v14 = _annualRealEstateTaxes; v14.Clean = value; _annualRealEstateTaxes = v14;
                var v15 = _annualSpecialAssessment; v15.Clean = value; _annualSpecialAssessment = v15;
                var v16 = _applicantAddressCity; v16.Clean = value; _applicantAddressCity = v16;
                var v17 = _applicantAddressPostalCode; v17.Clean = value; _applicantAddressPostalCode = v17;
                var v18 = _applicantAddressState; v18.Clean = value; _applicantAddressState = v18;
                var v19 = _applicantAddressStreetLine1; v19.Clean = value; _applicantAddressStreetLine1 = v19;
                var v20 = _applicantBirthDate; v20.Clean = value; _applicantBirthDate = v20;
                var v21 = _applicantEmailAddressText; v21.Clean = value; _applicantEmailAddressText = v21;
                var v22 = _applicantFirstNameWithMiddleName; v22.Clean = value; _applicantFirstNameWithMiddleName = v22;
                var v23 = _applicantHmdaGenderType; v23.Clean = value; _applicantHmdaGenderType = v23;
                var v24 = _applicantHomePhoneNumber; v24.Clean = value; _applicantHomePhoneNumber = v24;
                var v25 = _applicantLastNameWithSuffix; v25.Clean = value; _applicantLastNameWithSuffix = v25;
                var v26 = _applicantTaxIdentificationIdentifier; v26.Clean = value; _applicantTaxIdentificationIdentifier = v26;
                var v27 = _appraisalType; v27.Clean = value; _appraisalType = v27;
                var v28 = _automaticProcedure; v28.Clean = value; _automaticProcedure = v28;
                var v29 = _availableForInspectionAMIndicator; v29.Clean = value; _availableForInspectionAMIndicator = v29;
                var v30 = _availableForInspectionDateAndTime; v30.Clean = value; _availableForInspectionDateAndTime = v30;
                var v31 = _borrowerPaidDiscountPointsTotalAmount; v31.Clean = value; _borrowerPaidDiscountPointsTotalAmount = v31;
                var v32 = _buildingType; v32.Clean = value; _buildingType = v32;
                var v33 = _buyerPurchasingLotSeparately; v33.Clean = value; _buyerPurchasingLotSeparately = v33;
                var v34 = _cashPaymentFromVeteran; v34.Clean = value; _cashPaymentFromVeteran = v34;
                var v35 = _claimDisabilityBenefits; v35.Clean = value; _claimDisabilityBenefits = v35;
                var v36 = _clothesWasherIndicator; v36.Clean = value; _clothesWasherIndicator = v36;
                var v37 = _constructionCompletedDate; v37.Clean = value; _constructionCompletedDate = v37;
                var v38 = _constructionPlan; v38.Clean = value; _constructionPlan = v38;
                var v39 = _constructionWarrantyIncluded; v39.Clean = value; _constructionWarrantyIncluded = v39;
                var v40 = _contractNoApprovedByVA; v40.Clean = value; _contractNoApprovedByVA = v40;
                var v41 = _creditScore; v41.Clean = value; _creditScore = v41;
                var v42 = _currentlyOnMilitaryDuty; v42.Clean = value; _currentlyOnMilitaryDuty = v42;
                var v43 = _dateAquiredLand; v43.Clean = value; _dateAquiredLand = v43;
                var v44 = _dateOfAssignment; v44.Clean = value; _dateOfAssignment = v44;
                var v45 = _dateSAR; v45.Clean = value; _dateSAR = v45;
                var v46 = _disabilityAmountCollected; v46.Clean = value; _disabilityAmountCollected = v46;
                var v47 = _discountPercentage; v47.Clean = value; _discountPercentage = v47;
                var v48 = _discountPoint; v48.Clean = value; _discountPoint = v48;
                var v49 = _dishwasherIndicator; v49.Clean = value; _dishwasherIndicator = v49;
                var v50 = _dryerIndicator; v50.Clean = value; _dryerIndicator = v50;
                var v51 = _emailToBeNotifiedWhenUploaded; v51.Clean = value; _emailToBeNotifiedWhenUploaded = v51;
                var v52 = _energyImprovementsAdditionOfFeature; v52.Clean = value; _energyImprovementsAdditionOfFeature = v52;
                var v53 = _entitlementCode; v53.Clean = value; _entitlementCode = v53;
                var v54 = _equipmentOtherDescription; v54.Clean = value; _equipmentOtherDescription = v54;
                var v55 = _excludeTaxesInsuranceIndicator; v55.Clean = value; _excludeTaxesInsuranceIndicator = v55;
                var v56 = _finalDiscountAmount; v56.Clean = value; _finalDiscountAmount = v56;
                var v57 = _finalFundingFeeAmount; v57.Clean = value; _finalFundingFeeAmount = v57;
                var v58 = _firstChattelLoanType; v58.Clean = value; _firstChattelLoanType = v58;
                var v59 = _firstTimeUse; v59.Clean = value; _firstTimeUse = v59;
                var v60 = _fundingFeeExempt; v60.Clean = value; _fundingFeeExempt = v60;
                var v61 = _garbageDisposalIndicator; v61.Clean = value; _garbageDisposalIndicator = v61;
                var v62 = _id; v62.Clean = value; _id = v62;
                var v63 = _initialTotal; v63.Clean = value; _initialTotal = v63;
                var v64 = _inspectionWillBeMadeBy; v64.Clean = value; _inspectionWillBeMadeBy = v64;
                var v65 = _insulation; v65.Clean = value; _insulation = v65;
                var v66 = _insuranceType; v66.Clean = value; _insuranceType = v66;
                var v67 = _irregularLotSizeInSquareFeet; v67.Clean = value; _irregularLotSizeInSquareFeet = v67;
                var v68 = _isDelinquent30Days; v68.Clean = value; _isDelinquent30Days = v68;
                var v69 = _keysAtAddress; v69.Clean = value; _keysAtAddress = v69;
                var v70 = _landPurchasePrice; v70.Clean = value; _landPurchasePrice = v70;
                var v71 = _leaseholdType; v71.Clean = value; _leaseholdType = v71;
                var v72 = _lenderSAR; v72.Clean = value; _lenderSAR = v72;
                var v73 = _loanAnalysisRemarks1; v73.Clean = value; _loanAnalysisRemarks1 = v73;
                var v74 = _loanAnalysisRemarks2; v74.Clean = value; _loanAnalysisRemarks2 = v74;
                var v75 = _loanAnalysisRemarks3; v75.Clean = value; _loanAnalysisRemarks3 = v75;
                var v76 = _loanAnalysisRemarks4; v76.Clean = value; _loanAnalysisRemarks4 = v76;
                var v77 = _loanAnalysisRemarks5; v77.Clean = value; _loanAnalysisRemarks5 = v77;
                var v78 = _loanAnalysisRemarks6; v78.Clean = value; _loanAnalysisRemarks6 = v78;
                var v79 = _loanAnalysisRemarks7; v79.Clean = value; _loanAnalysisRemarks7 = v79;
                var v80 = _loanAnalysisRemarks8; v80.Clean = value; _loanAnalysisRemarks8 = v80;
                var v81 = _loanAnalysisRemarks9; v81.Clean = value; _loanAnalysisRemarks9 = v81;
                var v82 = _loanCode; v82.Clean = value; _loanCode = v82;
                var v83 = _loanProcedure; v83.Clean = value; _loanProcedure = v83;
                var v84 = _loanProcessedUnderAU; v84.Clean = value; _loanProcessedUnderAU = v84;
                var v85 = _loanSummaryRemarks1; v85.Clean = value; _loanSummaryRemarks1 = v85;
                var v86 = _loanSummaryRemarks2; v86.Clean = value; _loanSummaryRemarks2 = v86;
                var v87 = _loanSummaryRemarks3; v87.Clean = value; _loanSummaryRemarks3 = v87;
                var v88 = _loanSummaryRemarks4; v88.Clean = value; _loanSummaryRemarks4 = v88;
                var v89 = _loanSummaryRemarks5; v89.Clean = value; _loanSummaryRemarks5 = v89;
                var v90 = _loanSummaryRemarks6; v90.Clean = value; _loanSummaryRemarks6 = v90;
                var v91 = _loanSummaryRemarks7; v91.Clean = value; _loanSummaryRemarks7 = v91;
                var v92 = _loanSummaryRemarks8; v92.Clean = value; _loanSummaryRemarks8 = v92;
                var v93 = _lotDimensions; v93.Clean = value; _lotDimensions = v93;
                var v94 = _mailingAddress; v94.Clean = value; _mailingAddress = v94;
                var v95 = _mailingCity; v95.Clean = value; _mailingCity = v95;
                var v96 = _mailingPostalCode; v96.Clean = value; _mailingPostalCode = v96;
                var v97 = _mailingState; v97.Clean = value; _mailingState = v97;
                var v98 = _manufacturedHome; v98.Clean = value; _manufacturedHome = v98;
                var v99 = _mCRVNumber; v99.Clean = value; _mCRVNumber = v99;
                var v100 = _militaryBranchOfService; v100.Clean = value; _militaryBranchOfService = v100;
                var v101 = _militaryServices; v101.Clean = value; _militaryServices = v101;
                var v102 = _mineralRightsReserved; v102.Clean = value; _mineralRightsReserved = v102;
                var v103 = _nameOfOccupant; v103.Clean = value; _nameOfOccupant = v103;
                var v104 = _nameOfOwner; v104.Clean = value; _nameOfOwner = v104;
                var v105 = _nameOfWarrantyProgram; v105.Clean = value; _nameOfWarrantyProgram = v105;
                var v106 = _negativeRents; v106.Clean = value; _negativeRents = v106;
                var v107 = _noEnergyImprovements; v107.Clean = value; _noEnergyImprovements = v107;
                var v108 = _nonrealtyDescription; v108.Clean = value; _nonrealtyDescription = v108;
                var v109 = _numberOfBuildings; v109.Clean = value; _numberOfBuildings = v109;
                var v110 = _occupantTelephone; v110.Clean = value; _occupantTelephone = v110;
                var v111 = _onMilitaryDutyFollowingSeparation; v111.Clean = value; _onMilitaryDutyFollowingSeparation = v111;
                var v112 = _originalInterestRate; v112.Clean = value; _originalInterestRate = v112;
                var v113 = _originalLoanAmount; v113.Clean = value; _originalLoanAmount = v113;
                var v114 = _originalTerm; v114.Clean = value; _originalTerm = v114;
                var v115 = _originalValueEstimateChanged; v115.Clean = value; _originalValueEstimateChanged = v115;
                var v116 = _originationFeeAmount; v116.Clean = value; _originationFeeAmount = v116;
                var v117 = _otherClosingCosts; v117.Clean = value; _otherClosingCosts = v117;
                var v118 = _otherDescriptionEstateProperty; v118.Clean = value; _otherDescriptionEstateProperty = v118;
                var v119 = _otherDescriptionLoanType; v119.Clean = value; _otherDescriptionLoanType = v119;
                var v120 = _otherEstateProperty; v120.Clean = value; _otherEstateProperty = v120;
                var v121 = _otherImprovements; v121.Clean = value; _otherImprovements = v121;
                var v122 = _otherLoanType; v122.Clean = value; _otherLoanType = v122;
                var v123 = _paidInFullVALoanNumber; v123.Clean = value; _paidInFullVALoanNumber = v123;
                var v124 = _payoffIndicator1; v124.Clean = value; _payoffIndicator1 = v124;
                var v125 = _payoffIndicator2; v125.Clean = value; _payoffIndicator2 = v125;
                var v126 = _payoffIndicator3; v126.Clean = value; _payoffIndicator3 = v126;
                var v127 = _payoffIndicator4; v127.Clean = value; _payoffIndicator4 = v127;
                var v128 = _payoffIndicator5; v128.Clean = value; _payoffIndicator5 = v128;
                var v129 = _payoffIndicator6; v129.Clean = value; _payoffIndicator6 = v129;
                var v130 = _payoffIndicator7; v130.Clean = value; _payoffIndicator7 = v130;
                var v131 = _payoffIndicator8; v131.Clean = value; _payoffIndicator8 = v131;
                var v132 = _payoffIndicator9; v132.Clean = value; _payoffIndicator9 = v132;
                var v133 = _pestReportFee; v133.Clean = value; _pestReportFee = v133;
                var v134 = _plansSubmitted; v134.Clean = value; _plansSubmitted = v134;
                var v135 = _pOCAddress; v135.Clean = value; _pOCAddress = v135;
                var v136 = _pOCCity; v136.Clean = value; _pOCCity = v136;
                var v137 = _pOCName; v137.Clean = value; _pOCName = v137;
                var v138 = _pOCPhone; v138.Clean = value; _pOCPhone = v138;
                var v139 = _pOCState; v139.Clean = value; _pOCState = v139;
                var v140 = _pOCZipCode; v140.Clean = value; _pOCZipCode = v140;
                var v141 = _preliminaryDiscountAmount; v141.Clean = value; _preliminaryDiscountAmount = v141;
                var v142 = _preliminaryFundingFeeAmount; v142.Clean = value; _preliminaryFundingFeeAmount = v142;
                var v143 = _preliminaryTotal; v143.Clean = value; _preliminaryTotal = v143;
                var v144 = _previousVALoanIndicator; v144.Clean = value; _previousVALoanIndicator = v144;
                var v145 = _previousVaLoans; v145.Clean = value; _previousVaLoans = v145;
                var v146 = _priorApprovalProcedure; v146.Clean = value; _priorApprovalProcedure = v146;
                var v147 = _priorLoanType; v147.Clean = value; _priorLoanType = v147;
                var v148 = _propertyDesignation; v148.Clean = value; _propertyDesignation = v148;
                var v149 = _propertyGrossLivingArea; v149.Clean = value; _propertyGrossLivingArea = v149;
                var v150 = _propertyLegalDescription1; v150.Clean = value; _propertyLegalDescription1 = v150;
                var v151 = _propertyLegalDescription2; v151.Clean = value; _propertyLegalDescription2 = v151;
                var v152 = _propertyLegalDescription3; v152.Clean = value; _propertyLegalDescription3 = v152;
                var v153 = _propertyLegalDescription4; v153.Clean = value; _propertyLegalDescription4 = v153;
                var v154 = _propertyOccupancyType; v154.Clean = value; _propertyOccupancyType = v154;
                var v155 = _proposedSaleContractAttached; v155.Clean = value; _proposedSaleContractAttached = v155;
                var v156 = _purposeOfLoan; v156.Clean = value; _purposeOfLoan = v156;
                var v157 = _rangeOvenIndicator; v157.Clean = value; _rangeOvenIndicator = v157;
                var v158 = _reasonableValueCompleted; v158.Clean = value; _reasonableValueCompleted = v158;
                var v159 = _refrigeratorIndicator; v159.Clean = value; _refrigeratorIndicator = v159;
                var v160 = _rent; v160.Clean = value; _rent = v160;
                var v161 = _replacementOfSystem; v161.Clean = value; _replacementOfSystem = v161;
                var v162 = _riskClasification; v162.Clean = value; _riskClasification = v162;
                var v163 = _serviceNumber; v163.Clean = value; _serviceNumber = v163;
                var v164 = _solarHeatingOrCooling; v164.Clean = value; _solarHeatingOrCooling = v164;
                var v165 = _specialAssessmentComments1; v165.Clean = value; _specialAssessmentComments1 = v165;
                var v166 = _specialAssessmentComments2; v166.Clean = value; _specialAssessmentComments2 = v166;
                var v167 = _specialAssessmentComments3; v167.Clean = value; _specialAssessmentComments3 = v167;
                var v168 = _streetAccess; v168.Clean = value; _streetAccess = v168;
                var v169 = _streetMaintenance; v169.Clean = value; _streetMaintenance = v169;
                var v170 = _systemUsed; v170.Clean = value; _systemUsed = v170;
                var v171 = _title; v171.Clean = value; _title = v171;
                var v172 = _titleLimitations1; v172.Clean = value; _titleLimitations1 = v172;
                var v173 = _titleLimitations2; v173.Clean = value; _titleLimitations2 = v173;
                var v174 = _titleLimitations3; v174.Clean = value; _titleLimitations3 = v174;
                var v175 = _totalBaths; v175.Clean = value; _totalBaths = v175;
                var v176 = _totalBedrooms; v176.Clean = value; _totalBedrooms = v176;
                var v177 = _totalDebtMonthlyPayment; v177.Clean = value; _totalDebtMonthlyPayment = v177;
                var v178 = _totalDiscountPointCharged; v178.Clean = value; _totalDiscountPointCharged = v178;
                var v179 = _totalDiscountPointsCharged; v179.Clean = value; _totalDiscountPointsCharged = v179;
                var v180 = _totalForMaxLoanAmount; v180.Clean = value; _totalForMaxLoanAmount = v180;
                var v181 = _totalMonthlyPayment; v181.Clean = value; _totalMonthlyPayment = v181;
                var v182 = _totalProposedMonthlyPayment; v182.Clean = value; _totalProposedMonthlyPayment = v182;
                var v183 = _totalRooms; v183.Clean = value; _totalRooms = v183;
                var v184 = _totalUnpaidSpecialAssessments; v184.Clean = value; _totalUnpaidSpecialAssessments = v184;
                var v185 = _typeOfHybridARM; v185.Clean = value; _typeOfHybridARM = v185;
                var v186 = _typeOfMortgage; v186.Clean = value; _typeOfMortgage = v186;
                var v187 = _typeOfOwnsership; v187.Clean = value; _typeOfOwnsership = v187;
                var v188 = _typeOfStructure; v188.Clean = value; _typeOfStructure = v188;
                var v189 = _typeOfVeteran; v189.Clean = value; _typeOfVeteran = v189;
                var v190 = _unsecuredLoanType; v190.Clean = value; _unsecuredLoanType = v190;
                var v191 = _utilitiesElectricDescription; v191.Clean = value; _utilitiesElectricDescription = v191;
                var v192 = _utilitiesGasDescription; v192.Clean = value; _utilitiesGasDescription = v192;
                var v193 = _utilitiesSewerDescription; v193.Clean = value; _utilitiesSewerDescription = v193;
                var v194 = _utilitiesWaterDescription; v194.Clean = value; _utilitiesWaterDescription = v194;
                var v195 = _vAAppraisalSentDate; v195.Clean = value; _vAAppraisalSentDate = v195;
                var v196 = _vABenefitRelatedIndebtedness; v196.Clean = value; _vABenefitRelatedIndebtedness = v196;
                var v197 = _vABuilderDescription; v197.Clean = value; _vABuilderDescription = v197;
                var v198 = _vABuilderIDNo; v198.Clean = value; _vABuilderIDNo = v198;
                var v199 = _vAClaimFolderNumber; v199.Clean = value; _vAClaimFolderNumber = v199;
                var v200 = _vAClaimNumber; v200.Clean = value; _vAClaimNumber = v200;
                var v201 = _vADateNOVAppraisalMailedToBorrower; v201.Clean = value; _vADateNOVAppraisalMailedToBorrower = v201;
                var v202 = _vAIsDelinquent30Days; v202.Clean = value; _vAIsDelinquent30Days = v202;
                var v203 = _vALatePaymentIn6Months; v203.Clean = value; _vALatePaymentIn6Months = v203;
                var v204 = _vaLoanSummaryApplicantType; v204.Clean = value; _vaLoanSummaryApplicantType = v204;
                var v205 = _vANOVDateReceived; v205.Clean = value; _vANOVDateReceived = v205;
                var v206 = _vANOVDateReviewed; v206.Clean = value; _vANOVDateReviewed = v206;
                var v207 = _vANOVIssuedDate; v207.Clean = value; _vANOVIssuedDate = v207;
                var v208 = _vAOriginalAmortizationType; v208.Clean = value; _vAOriginalAmortizationType = v208;
                var v209 = _vAOriginalMonthlyPayment; v209.Clean = value; _vAOriginalMonthlyPayment = v209;
                var v210 = _vAQualification2ndTierEntitlement; v210.Clean = value; _vAQualification2ndTierEntitlement = v210;
                var v211 = _vAQualificationCountryRegion; v211.Clean = value; _vAQualificationCountryRegion = v211;
                var v212 = _vAQualificationCountyLimits; v212.Clean = value; _vAQualificationCountyLimits = v212;
                var v213 = _vARecoupmentClosingCosts; v213.Clean = value; _vARecoupmentClosingCosts = v213;
                var v214 = _vARecoupmentExcludePrepaids; v214.Clean = value; _vARecoupmentExcludePrepaids = v214;
                var v215 = _vARecoupmentMonthlyDecreaseInPayment; v215.Clean = value; _vARecoupmentMonthlyDecreaseInPayment = v215;
                var v216 = _vARecoupmentMonths; v216.Clean = value; _vARecoupmentMonths = v216;
                var v217 = _vARecoupmentTotalClosingCosts; v217.Clean = value; _vARecoupmentTotalClosingCosts = v217;
                var v218 = _vARecoupmentYears; v218.Clean = value; _vARecoupmentYears = v218;
                var v219 = _vATrackingCertOfCommitmentIssued; v219.Clean = value; _vATrackingCertOfCommitmentIssued = v219;
                var v220 = _vATrackingCOEIssueDate; v220.Clean = value; _vATrackingCOEIssueDate = v220;
                var v221 = _vATrackingCOEIssueHistory; v221.Clean = value; _vATrackingCOEIssueHistory = v221;
                var v222 = _vATrackingFinalApprovalCommitmentDate; v222.Clean = value; _vATrackingFinalApprovalCommitmentDate = v222;
                var v223 = _vATrackingGSAExclusionaryListChecked; v223.Clean = value; _vATrackingGSAExclusionaryListChecked = v223;
                var v224 = _vATrackingInuranceFloodPolicy; v224.Clean = value; _vATrackingInuranceFloodPolicy = v224;
                var v225 = _vATrackingInuranceHazardPolicy; v225.Clean = value; _vATrackingInuranceHazardPolicy = v225;
                var v226 = _vATrackingInuranceWindOrHailPolicy; v226.Clean = value; _vATrackingInuranceWindOrHailPolicy = v226;
                var v227 = _vATrackingInuranceWoodDestroyingPolicy; v227.Clean = value; _vATrackingInuranceWoodDestroyingPolicy = v227;
                var v228 = _vATrackingIsSARLAPPCertified; v228.Clean = value; _vATrackingIsSARLAPPCertified = v228;
                var v229 = _vATrackingLoanGuaranteeCertReceipt; v229.Clean = value; _vATrackingLoanGuaranteeCertReceipt = v229;
                var v230 = _vATrackingMasterCommitmentLockExpired; v230.Clean = value; _vATrackingMasterCommitmentLockExpired = v230;
                var v231 = _vATrackingOrderedDate; v231.Clean = value; _vATrackingOrderedDate = v231;
                var v232 = _vATrackingPaidDate; v232.Clean = value; _vATrackingPaidDate = v232;
                var v233 = _vATrackingPurchaseContractDate; v233.Clean = value; _vATrackingPurchaseContractDate = v233;
                var v234 = _vATrackingReceiptReceived; v234.Clean = value; _vATrackingReceiptReceived = v234;
                var v235 = _vATrackingSARID; v235.Clean = value; _vATrackingSARID = v235;
                var v236 = _vATrackingSARName; v236.Clean = value; _vATrackingSARName = v236;
                var v237 = _ventFanIndicator; v237.Clean = value; _ventFanIndicator = v237;
                var v238 = _veteranDischargedIndicator; v238.Clean = value; _veteranDischargedIndicator = v238;
                var v239 = _veteranServiceType; v239.Clean = value; _veteranServiceType = v239;
                var v240 = _warrantorAddress; v240.Clean = value; _warrantorAddress = v240;
                var v241 = _warrantorCity; v241.Clean = value; _warrantorCity = v241;
                var v242 = _warrantorName; v242.Clean = value; _warrantorName = v242;
                var v243 = _warrantorPhone; v243.Clean = value; _warrantorPhone = v243;
                var v244 = _warrantorPostalCode; v244.Clean = value; _warrantorPostalCode = v244;
                var v245 = _warrantorState; v245.Clean = value; _warrantorState = v245;
                var v246 = _warrantyProgramExpirationDate; v246.Clean = value; _warrantyProgramExpirationDate = v246;
                var v247 = _wWCarpetIndicator; v247.Clean = value; _wWCarpetIndicator = v247;
                _settingClean = 0;
            }
        }
    }
}