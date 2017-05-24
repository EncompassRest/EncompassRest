using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class VaLoanData
    {
        public Value<decimal?> Acres { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcres() => !Acres.Clean;
        public Value<string> AdditionalSecurityDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalSecurityDescription() => !AdditionalSecurityDescription.Clean;
        public Value<string> AdministratorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorAddress() => !AdministratorAddress.Clean;
        public Value<string> AdministratorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorCity() => !AdministratorCity.Clean;
        public Value<string> AdministratorContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorContact() => !AdministratorContact.Clean;
        public Value<string> AdministratorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorName() => !AdministratorName.Clean;
        public Value<string> AdministratorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorPostalCode() => !AdministratorPostalCode.Clean;
        public Value<string> AdministratorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdministratorState() => !AdministratorState.Clean;
        public Value<int?> AgeOfProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgeOfProperty() => !AgeOfProperty.Clean;
        public Value<decimal?> AmountSpentOnEnergyImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountSpentOnEnergyImprovements() => !AmountSpentOnEnergyImprovements.Clean;
        public Value<string> AmountTypeWithheld { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountTypeWithheld() => !AmountTypeWithheld.Clean;
        public Value<decimal?> AmountWithheld { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountWithheld() => !AmountWithheld.Clean;
        public Value<decimal?> AnnualGroundRent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualGroundRent() => !AnnualGroundRent.Clean;
        public Value<decimal?> AnnualMaintenanceAssessment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualMaintenanceAssessment() => !AnnualMaintenanceAssessment.Clean;
        public Value<decimal?> AnnualRealEstateTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualRealEstateTaxes() => !AnnualRealEstateTaxes.Clean;
        public Value<decimal?> AnnualSpecialAssessment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualSpecialAssessment() => !AnnualSpecialAssessment.Clean;
        public Value<string> ApplicantAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressCity() => !ApplicantAddressCity.Clean;
        public Value<string> ApplicantAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressPostalCode() => !ApplicantAddressPostalCode.Clean;
        public Value<string> ApplicantAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressState() => !ApplicantAddressState.Clean;
        public Value<string> ApplicantAddressStreetLine1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantAddressStreetLine1() => !ApplicantAddressStreetLine1.Clean;
        public Value<DateTime?> ApplicantBirthDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantBirthDate() => !ApplicantBirthDate.Clean;
        public Value<string> ApplicantEmailAddressText { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantEmailAddressText() => !ApplicantEmailAddressText.Clean;
        public Value<string> ApplicantFirstNameWithMiddleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantFirstNameWithMiddleName() => !ApplicantFirstNameWithMiddleName.Clean;
        public Value<string> ApplicantHmdaGenderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantHmdaGenderType() => !ApplicantHmdaGenderType.Clean;
        public Value<string> ApplicantHomePhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantHomePhoneNumber() => !ApplicantHomePhoneNumber.Clean;
        public Value<string> ApplicantLastNameWithSuffix { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantLastNameWithSuffix() => !ApplicantLastNameWithSuffix.Clean;
        public Value<string> ApplicantTaxIdentificationIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantTaxIdentificationIdentifier() => !ApplicantTaxIdentificationIdentifier.Clean;
        public Value<string> AppraisalType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalType() => !AppraisalType.Clean;
        public Value<bool?> AutomaticProcedure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAutomaticProcedure() => !AutomaticProcedure.Clean;
        public Value<bool?> AvailableForInspectionAMIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvailableForInspectionAMIndicator() => !AvailableForInspectionAMIndicator.Clean;
        public Value<string> AvailableForInspectionDateAndTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvailableForInspectionDateAndTime() => !AvailableForInspectionDateAndTime.Clean;
        public Value<decimal?> BorrowerPaidDiscountPointsTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidDiscountPointsTotalAmount() => !BorrowerPaidDiscountPointsTotalAmount.Clean;
        public Value<string> BuildingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuildingType() => !BuildingType.Clean;
        public Value<bool?> BuyerPurchasingLotSeparately { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuyerPurchasingLotSeparately() => !BuyerPurchasingLotSeparately.Clean;
        public Value<decimal?> CashPaymentFromVeteran { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashPaymentFromVeteran() => !CashPaymentFromVeteran.Clean;
        public Value<string> ClaimDisabilityBenefits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClaimDisabilityBenefits() => !ClaimDisabilityBenefits.Clean;
        public Value<bool?> ClothesWasherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClothesWasherIndicator() => !ClothesWasherIndicator.Clean;
        public Value<DateTime?> ConstructionCompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionCompletedDate() => !ConstructionCompletedDate.Clean;
        public Value<string> ConstructionPlan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionPlan() => !ConstructionPlan.Clean;
        public Value<bool?> ConstructionWarrantyIncluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionWarrantyIncluded() => !ConstructionWarrantyIncluded.Clean;
        public Value<string> ContractNoApprovedByVA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractNoApprovedByVA() => !ContractNoApprovedByVA.Clean;
        public Value<int?> CreditScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScore() => !CreditScore.Clean;
        public Value<bool?> CurrentlyOnMilitaryDuty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentlyOnMilitaryDuty() => !CurrentlyOnMilitaryDuty.Clean;
        public Value<DateTime?> DateAquiredLand { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAquiredLand() => !DateAquiredLand.Clean;
        public Value<DateTime?> DateOfAssignment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfAssignment() => !DateOfAssignment.Clean;
        public Value<DateTime?> DateSAR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateSAR() => !DateSAR.Clean;
        public Value<decimal?> DisabilityAmountCollected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabilityAmountCollected() => !DisabilityAmountCollected.Clean;
        public Value<decimal?> DiscountPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPercentage() => !DiscountPercentage.Clean;
        public Value<decimal?> DiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoint() => !DiscountPoint.Clean;
        public Value<bool?> DishwasherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDishwasherIndicator() => !DishwasherIndicator.Clean;
        public Value<bool?> DryerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDryerIndicator() => !DryerIndicator.Clean;
        public Value<string> EmailToBeNotifiedWhenUploaded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmailToBeNotifiedWhenUploaded() => !EmailToBeNotifiedWhenUploaded.Clean;
        public Value<bool?> EnergyImprovementsAdditionOfFeature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyImprovementsAdditionOfFeature() => !EnergyImprovementsAdditionOfFeature.Clean;
        public Value<string> EntitlementCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEntitlementCode() => !EntitlementCode.Clean;
        public Value<string> EquipmentOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquipmentOtherDescription() => !EquipmentOtherDescription.Clean;
        public Value<bool?> ExcludeTaxesInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcludeTaxesInsuranceIndicator() => !ExcludeTaxesInsuranceIndicator.Clean;
        public Value<decimal?> FinalDiscountAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalDiscountAmount() => !FinalDiscountAmount.Clean;
        public Value<decimal?> FinalFundingFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalFundingFeeAmount() => !FinalFundingFeeAmount.Clean;
        public Value<bool?> FirstChattelLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChattelLoanType() => !FirstChattelLoanType.Clean;
        public Value<bool?> FirstTimeUse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTimeUse() => !FirstTimeUse.Clean;
        public Value<bool?> FundingFeeExempt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFeeExempt() => !FundingFeeExempt.Clean;
        public Value<bool?> GarbageDisposalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGarbageDisposalIndicator() => !GarbageDisposalIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InitialTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialTotal() => !InitialTotal.Clean;
        public Value<string> InspectionWillBeMadeBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionWillBeMadeBy() => !InspectionWillBeMadeBy.Clean;
        public Value<bool?> Insulation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsulation() => !Insulation.Clean;
        public Value<string> InsuranceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceType() => !InsuranceType.Clean;
        public Value<int?> IrregularLotSizeInSquareFeet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIrregularLotSizeInSquareFeet() => !IrregularLotSizeInSquareFeet.Clean;
        public Value<bool?> IsDelinquent30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDelinquent30Days() => !IsDelinquent30Days.Clean;
        public Value<string> KeysAtAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKeysAtAddress() => !KeysAtAddress.Clean;
        public Value<decimal?> LandPurchasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLandPurchasePrice() => !LandPurchasePrice.Clean;
        public Value<string> LeaseholdType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseholdType() => !LeaseholdType.Clean;
        public Value<string> LenderSAR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderSAR() => !LenderSAR.Clean;
        public Value<string> LoanAnalysisRemarks1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks1() => !LoanAnalysisRemarks1.Clean;
        public Value<string> LoanAnalysisRemarks2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks2() => !LoanAnalysisRemarks2.Clean;
        public Value<string> LoanAnalysisRemarks3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks3() => !LoanAnalysisRemarks3.Clean;
        public Value<string> LoanAnalysisRemarks4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks4() => !LoanAnalysisRemarks4.Clean;
        public Value<string> LoanAnalysisRemarks5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks5() => !LoanAnalysisRemarks5.Clean;
        public Value<string> LoanAnalysisRemarks6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks6() => !LoanAnalysisRemarks6.Clean;
        public Value<string> LoanAnalysisRemarks7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks7() => !LoanAnalysisRemarks7.Clean;
        public Value<string> LoanAnalysisRemarks8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks8() => !LoanAnalysisRemarks8.Clean;
        public Value<string> LoanAnalysisRemarks9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAnalysisRemarks9() => !LoanAnalysisRemarks9.Clean;
        public Value<string> LoanCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanCode() => !LoanCode.Clean;
        public Value<string> LoanProcedure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProcedure() => !LoanProcedure.Clean;
        public Value<bool?> LoanProcessedUnderAU { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProcessedUnderAU() => !LoanProcessedUnderAU.Clean;
        public Value<string> LoanSummaryRemarks1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks1() => !LoanSummaryRemarks1.Clean;
        public Value<string> LoanSummaryRemarks2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks2() => !LoanSummaryRemarks2.Clean;
        public Value<string> LoanSummaryRemarks3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks3() => !LoanSummaryRemarks3.Clean;
        public Value<string> LoanSummaryRemarks4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks4() => !LoanSummaryRemarks4.Clean;
        public Value<string> LoanSummaryRemarks5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks5() => !LoanSummaryRemarks5.Clean;
        public Value<string> LoanSummaryRemarks6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks6() => !LoanSummaryRemarks6.Clean;
        public Value<string> LoanSummaryRemarks7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks7() => !LoanSummaryRemarks7.Clean;
        public Value<string> LoanSummaryRemarks8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSummaryRemarks8() => !LoanSummaryRemarks8.Clean;
        public Value<string> LotDimensions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLotDimensions() => !LotDimensions.Clean;
        public Value<string> MailingAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingAddress() => !MailingAddress.Clean;
        public Value<string> MailingCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingCity() => !MailingCity.Clean;
        public Value<string> MailingPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingPostalCode() => !MailingPostalCode.Clean;
        public Value<string> MailingState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingState() => !MailingState.Clean;
        public Value<string> ManufacturedHome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHome() => !ManufacturedHome.Clean;
        public Value<string> MCRVNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMCRVNumber() => !MCRVNumber.Clean;
        public Value<string> MilitaryBranchOfService { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryBranchOfService() => !MilitaryBranchOfService.Clean;
        public Value<List<MilitaryService>> MilitaryServices { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryServices() => !MilitaryServices.Clean;
        public Value<string> MineralRightsReserved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMineralRightsReserved() => !MineralRightsReserved.Clean;
        public Value<string> NameOfOccupant { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfOccupant() => !NameOfOccupant.Clean;
        public Value<string> NameOfOwner { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfOwner() => !NameOfOwner.Clean;
        public Value<string> NameOfWarrantyProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfWarrantyProgram() => !NameOfWarrantyProgram.Clean;
        public Value<decimal?> NegativeRents { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegativeRents() => !NegativeRents.Clean;
        public Value<bool?> NoEnergyImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoEnergyImprovements() => !NoEnergyImprovements.Clean;
        public Value<string> NonrealtyDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonrealtyDescription() => !NonrealtyDescription.Clean;
        public Value<string> NumberOfBuildings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfBuildings() => !NumberOfBuildings.Clean;
        public Value<string> OccupantTelephone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupantTelephone() => !OccupantTelephone.Clean;
        public Value<bool?> OnMilitaryDutyFollowingSeparation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOnMilitaryDutyFollowingSeparation() => !OnMilitaryDutyFollowingSeparation.Clean;
        public Value<decimal?> OriginalInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalInterestRate() => !OriginalInterestRate.Clean;
        public Value<decimal?> OriginalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalLoanAmount() => !OriginalLoanAmount.Clean;
        public Value<int?> OriginalTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalTerm() => !OriginalTerm.Clean;
        public Value<bool?> OriginalValueEstimateChanged { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalValueEstimateChanged() => !OriginalValueEstimateChanged.Clean;
        public Value<decimal?> OriginationFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeAmount() => !OriginationFeeAmount.Clean;
        public Value<decimal?> OtherClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherClosingCosts() => !OtherClosingCosts.Clean;
        public Value<string> OtherDescriptionEstateProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescriptionEstateProperty() => !OtherDescriptionEstateProperty.Clean;
        public Value<string> OtherDescriptionLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescriptionLoanType() => !OtherDescriptionLoanType.Clean;
        public Value<bool?> OtherEstateProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherEstateProperty() => !OtherEstateProperty.Clean;
        public Value<bool?> OtherImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherImprovements() => !OtherImprovements.Clean;
        public Value<bool?> OtherLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLoanType() => !OtherLoanType.Clean;
        public Value<string> PaidInFullVALoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidInFullVALoanNumber() => !PaidInFullVALoanNumber.Clean;
        public Value<bool?> PayoffIndicator1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator1() => !PayoffIndicator1.Clean;
        public Value<bool?> PayoffIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator2() => !PayoffIndicator2.Clean;
        public Value<bool?> PayoffIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator3() => !PayoffIndicator3.Clean;
        public Value<bool?> PayoffIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator4() => !PayoffIndicator4.Clean;
        public Value<bool?> PayoffIndicator5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator5() => !PayoffIndicator5.Clean;
        public Value<bool?> PayoffIndicator6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator6() => !PayoffIndicator6.Clean;
        public Value<bool?> PayoffIndicator7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator7() => !PayoffIndicator7.Clean;
        public Value<bool?> PayoffIndicator8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator8() => !PayoffIndicator8.Clean;
        public Value<bool?> PayoffIndicator9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayoffIndicator9() => !PayoffIndicator9.Clean;
        public Value<decimal?> PestReportFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePestReportFee() => !PestReportFee.Clean;
        public Value<string> PlansSubmitted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlansSubmitted() => !PlansSubmitted.Clean;
        public Value<string> POCAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCAddress() => !POCAddress.Clean;
        public Value<string> POCCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCCity() => !POCCity.Clean;
        public Value<string> POCName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCName() => !POCName.Clean;
        public Value<string> POCPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCPhone() => !POCPhone.Clean;
        public Value<string> POCState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCState() => !POCState.Clean;
        public Value<string> POCZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePOCZipCode() => !POCZipCode.Clean;
        public Value<decimal?> PreliminaryDiscountAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryDiscountAmount() => !PreliminaryDiscountAmount.Clean;
        public Value<decimal?> PreliminaryFundingFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryFundingFeeAmount() => !PreliminaryFundingFeeAmount.Clean;
        public Value<decimal?> PreliminaryTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryTotal() => !PreliminaryTotal.Clean;
        public Value<bool?> PreviousVALoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousVALoanIndicator() => !PreviousVALoanIndicator.Clean;
        public Value<List<PreviousVaLoan>> PreviousVaLoans { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousVaLoans() => !PreviousVaLoans.Clean;
        public Value<bool?> PriorApprovalProcedure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorApprovalProcedure() => !PriorApprovalProcedure.Clean;
        public Value<string> PriorLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorLoanType() => !PriorLoanType.Clean;
        public Value<string> PropertyDesignation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyDesignation() => !PropertyDesignation.Clean;
        public Value<int?> PropertyGrossLivingArea { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyGrossLivingArea() => !PropertyGrossLivingArea.Clean;
        public Value<string> PropertyLegalDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription1() => !PropertyLegalDescription1.Clean;
        public Value<string> PropertyLegalDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription2() => !PropertyLegalDescription2.Clean;
        public Value<string> PropertyLegalDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription3() => !PropertyLegalDescription3.Clean;
        public Value<string> PropertyLegalDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyLegalDescription4() => !PropertyLegalDescription4.Clean;
        public Value<string> PropertyOccupancyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyOccupancyType() => !PropertyOccupancyType.Clean;
        public Value<bool?> ProposedSaleContractAttached { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedSaleContractAttached() => !ProposedSaleContractAttached.Clean;
        public Value<string> PurposeOfLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurposeOfLoan() => !PurposeOfLoan.Clean;
        public Value<bool?> RangeOvenIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRangeOvenIndicator() => !RangeOvenIndicator.Clean;
        public Value<bool?> ReasonableValueCompleted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReasonableValueCompleted() => !ReasonableValueCompleted.Clean;
        public Value<bool?> RefrigeratorIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefrigeratorIndicator() => !RefrigeratorIndicator.Clean;
        public Value<string> Rent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRent() => !Rent.Clean;
        public Value<bool?> ReplacementOfSystem { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReplacementOfSystem() => !ReplacementOfSystem.Clean;
        public Value<string> RiskClasification { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskClasification() => !RiskClasification.Clean;
        public Value<string> ServiceNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceNumber() => !ServiceNumber.Clean;
        public Value<bool?> SolarHeatingOrCooling { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSolarHeatingOrCooling() => !SolarHeatingOrCooling.Clean;
        public Value<string> SpecialAssessmentComments1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments1() => !SpecialAssessmentComments1.Clean;
        public Value<string> SpecialAssessmentComments2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments2() => !SpecialAssessmentComments2.Clean;
        public Value<string> SpecialAssessmentComments3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessmentComments3() => !SpecialAssessmentComments3.Clean;
        public Value<string> StreetAccess { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetAccess() => !StreetAccess.Clean;
        public Value<string> StreetMaintenance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStreetMaintenance() => !StreetMaintenance.Clean;
        public Value<string> SystemUsed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemUsed() => !SystemUsed.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<string> TitleLimitations1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations1() => !TitleLimitations1.Clean;
        public Value<string> TitleLimitations2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations2() => !TitleLimitations2.Clean;
        public Value<string> TitleLimitations3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleLimitations3() => !TitleLimitations3.Clean;
        public Value<decimal?> TotalBaths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBaths() => !TotalBaths.Clean;
        public Value<int?> TotalBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBedrooms() => !TotalBedrooms.Clean;
        public Value<decimal?> TotalDebtMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDebtMonthlyPayment() => !TotalDebtMonthlyPayment.Clean;
        public Value<decimal?> TotalDiscountPointCharged { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointCharged() => !TotalDiscountPointCharged.Clean;
        public Value<decimal?> TotalDiscountPointsCharged { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointsCharged() => !TotalDiscountPointsCharged.Clean;
        public Value<decimal?> TotalForMaxLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForMaxLoanAmount() => !TotalForMaxLoanAmount.Clean;
        public Value<decimal?> TotalMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyPayment() => !TotalMonthlyPayment.Clean;
        public Value<decimal?> TotalProposedMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalProposedMonthlyPayment() => !TotalProposedMonthlyPayment.Clean;
        public Value<int?> TotalRooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRooms() => !TotalRooms.Clean;
        public Value<decimal?> TotalUnpaidSpecialAssessments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalUnpaidSpecialAssessments() => !TotalUnpaidSpecialAssessments.Clean;
        public Value<string> TypeOfHybridARM { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfHybridARM() => !TypeOfHybridARM.Clean;
        public Value<string> TypeOfMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfMortgage() => !TypeOfMortgage.Clean;
        public Value<string> TypeOfOwnsership { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfOwnsership() => !TypeOfOwnsership.Clean;
        public Value<string> TypeOfStructure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfStructure() => !TypeOfStructure.Clean;
        public Value<string> TypeOfVeteran { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfVeteran() => !TypeOfVeteran.Clean;
        public Value<bool?> UnsecuredLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnsecuredLoanType() => !UnsecuredLoanType.Clean;
        public Value<string> UtilitiesElectricDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesElectricDescription() => !UtilitiesElectricDescription.Clean;
        public Value<string> UtilitiesGasDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesGasDescription() => !UtilitiesGasDescription.Clean;
        public Value<string> UtilitiesSewerDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesSewerDescription() => !UtilitiesSewerDescription.Clean;
        public Value<string> UtilitiesWaterDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilitiesWaterDescription() => !UtilitiesWaterDescription.Clean;
        public Value<DateTime?> VAAppraisalSentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAAppraisalSentDate() => !VAAppraisalSentDate.Clean;
        public Value<string> VABenefitRelatedIndebtedness { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABenefitRelatedIndebtedness() => !VABenefitRelatedIndebtedness.Clean;
        public Value<string> VABuilderDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABuilderDescription() => !VABuilderDescription.Clean;
        public Value<string> VABuilderIDNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVABuilderIDNo() => !VABuilderIDNo.Clean;
        public Value<string> VAClaimFolderNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAClaimFolderNumber() => !VAClaimFolderNumber.Clean;
        public Value<string> VAClaimNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAClaimNumber() => !VAClaimNumber.Clean;
        public Value<DateTime?> VADateNOVAppraisalMailedToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVADateNOVAppraisalMailedToBorrower() => !VADateNOVAppraisalMailedToBorrower.Clean;
        public Value<bool?> VAIsDelinquent30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAIsDelinquent30Days() => !VAIsDelinquent30Days.Clean;
        public Value<bool?> VALatePaymentIn6Months { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVALatePaymentIn6Months() => !VALatePaymentIn6Months.Clean;
        public Value<string> VaLoanSummaryApplicantType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaLoanSummaryApplicantType() => !VaLoanSummaryApplicantType.Clean;
        public Value<DateTime?> VANOVDateReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVDateReceived() => !VANOVDateReceived.Clean;
        public Value<DateTime?> VANOVDateReviewed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVDateReviewed() => !VANOVDateReviewed.Clean;
        public Value<DateTime?> VANOVIssuedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVANOVIssuedDate() => !VANOVIssuedDate.Clean;
        public Value<string> VAOriginalAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAOriginalAmortizationType() => !VAOriginalAmortizationType.Clean;
        public Value<decimal?> VAOriginalMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAOriginalMonthlyPayment() => !VAOriginalMonthlyPayment.Clean;
        public Value<string> VAQualification2ndTierEntitlement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualification2ndTierEntitlement() => !VAQualification2ndTierEntitlement.Clean;
        public Value<string> VAQualificationCountryRegion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualificationCountryRegion() => !VAQualificationCountryRegion.Clean;
        public Value<decimal?> VAQualificationCountyLimits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVAQualificationCountyLimits() => !VAQualificationCountyLimits.Clean;
        public Value<int?> VARecoupmentClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentClosingCosts() => !VARecoupmentClosingCosts.Clean;
        public Value<bool?> VARecoupmentExcludePrepaids { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentExcludePrepaids() => !VARecoupmentExcludePrepaids.Clean;
        public Value<decimal?> VARecoupmentMonthlyDecreaseInPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentMonthlyDecreaseInPayment() => !VARecoupmentMonthlyDecreaseInPayment.Clean;
        public Value<int?> VARecoupmentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentMonths() => !VARecoupmentMonths.Clean;
        public Value<decimal?> VARecoupmentTotalClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentTotalClosingCosts() => !VARecoupmentTotalClosingCosts.Clean;
        public Value<int?> VARecoupmentYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVARecoupmentYears() => !VARecoupmentYears.Clean;
        public Value<DateTime?> VATrackingCertOfCommitmentIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCertOfCommitmentIssued() => !VATrackingCertOfCommitmentIssued.Clean;
        public Value<DateTime?> VATrackingCOEIssueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCOEIssueDate() => !VATrackingCOEIssueDate.Clean;
        public Value<string> VATrackingCOEIssueHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingCOEIssueHistory() => !VATrackingCOEIssueHistory.Clean;
        public Value<DateTime?> VATrackingFinalApprovalCommitmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingFinalApprovalCommitmentDate() => !VATrackingFinalApprovalCommitmentDate.Clean;
        public Value<bool?> VATrackingGSAExclusionaryListChecked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingGSAExclusionaryListChecked() => !VATrackingGSAExclusionaryListChecked.Clean;
        public Value<bool?> VATrackingInuranceFloodPolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceFloodPolicy() => !VATrackingInuranceFloodPolicy.Clean;
        public Value<bool?> VATrackingInuranceHazardPolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceHazardPolicy() => !VATrackingInuranceHazardPolicy.Clean;
        public Value<bool?> VATrackingInuranceWindOrHailPolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceWindOrHailPolicy() => !VATrackingInuranceWindOrHailPolicy.Clean;
        public Value<bool?> VATrackingInuranceWoodDestroyingPolicy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingInuranceWoodDestroyingPolicy() => !VATrackingInuranceWoodDestroyingPolicy.Clean;
        public Value<bool?> VATrackingIsSARLAPPCertified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingIsSARLAPPCertified() => !VATrackingIsSARLAPPCertified.Clean;
        public Value<DateTime?> VATrackingLoanGuaranteeCertReceipt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingLoanGuaranteeCertReceipt() => !VATrackingLoanGuaranteeCertReceipt.Clean;
        public Value<DateTime?> VATrackingMasterCommitmentLockExpired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingMasterCommitmentLockExpired() => !VATrackingMasterCommitmentLockExpired.Clean;
        public Value<DateTime?> VATrackingOrderedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingOrderedDate() => !VATrackingOrderedDate.Clean;
        public Value<DateTime?> VATrackingPaidDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingPaidDate() => !VATrackingPaidDate.Clean;
        public Value<DateTime?> VATrackingPurchaseContractDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingPurchaseContractDate() => !VATrackingPurchaseContractDate.Clean;
        public Value<bool?> VATrackingReceiptReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingReceiptReceived() => !VATrackingReceiptReceived.Clean;
        public Value<string> VATrackingSARID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingSARID() => !VATrackingSARID.Clean;
        public Value<string> VATrackingSARName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVATrackingSARName() => !VATrackingSARName.Clean;
        public Value<bool?> VentFanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVentFanIndicator() => !VentFanIndicator.Clean;
        public Value<bool?> VeteranDischargedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVeteranDischargedIndicator() => !VeteranDischargedIndicator.Clean;
        public Value<string> VeteranServiceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVeteranServiceType() => !VeteranServiceType.Clean;
        public Value<string> WarrantorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorAddress() => !WarrantorAddress.Clean;
        public Value<string> WarrantorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorCity() => !WarrantorCity.Clean;
        public Value<string> WarrantorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorName() => !WarrantorName.Clean;
        public Value<string> WarrantorPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorPhone() => !WarrantorPhone.Clean;
        public Value<string> WarrantorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorPostalCode() => !WarrantorPostalCode.Clean;
        public Value<string> WarrantorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantorState() => !WarrantorState.Clean;
        public Value<DateTime?> WarrantyProgramExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWarrantyProgramExpirationDate() => !WarrantyProgramExpirationDate.Clean;
        public Value<bool?> WWCarpetIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWWCarpetIndicator() => !WWCarpetIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Acres.Clean
                    && AdditionalSecurityDescription.Clean
                    && AdministratorAddress.Clean
                    && AdministratorCity.Clean
                    && AdministratorContact.Clean
                    && AdministratorName.Clean
                    && AdministratorPostalCode.Clean
                    && AdministratorState.Clean
                    && AgeOfProperty.Clean
                    && AmountSpentOnEnergyImprovements.Clean
                    && AmountTypeWithheld.Clean
                    && AmountWithheld.Clean
                    && AnnualGroundRent.Clean
                    && AnnualMaintenanceAssessment.Clean
                    && AnnualRealEstateTaxes.Clean
                    && AnnualSpecialAssessment.Clean
                    && ApplicantAddressCity.Clean
                    && ApplicantAddressPostalCode.Clean
                    && ApplicantAddressState.Clean
                    && ApplicantAddressStreetLine1.Clean
                    && ApplicantBirthDate.Clean
                    && ApplicantEmailAddressText.Clean
                    && ApplicantFirstNameWithMiddleName.Clean
                    && ApplicantHmdaGenderType.Clean
                    && ApplicantHomePhoneNumber.Clean
                    && ApplicantLastNameWithSuffix.Clean
                    && ApplicantTaxIdentificationIdentifier.Clean
                    && AppraisalType.Clean
                    && AutomaticProcedure.Clean
                    && AvailableForInspectionAMIndicator.Clean
                    && AvailableForInspectionDateAndTime.Clean
                    && BorrowerPaidDiscountPointsTotalAmount.Clean
                    && BuildingType.Clean
                    && BuyerPurchasingLotSeparately.Clean
                    && CashPaymentFromVeteran.Clean
                    && ClaimDisabilityBenefits.Clean
                    && ClothesWasherIndicator.Clean
                    && ConstructionCompletedDate.Clean
                    && ConstructionPlan.Clean
                    && ConstructionWarrantyIncluded.Clean
                    && ContractNoApprovedByVA.Clean
                    && CreditScore.Clean
                    && CurrentlyOnMilitaryDuty.Clean
                    && DateAquiredLand.Clean
                    && DateOfAssignment.Clean
                    && DateSAR.Clean
                    && DisabilityAmountCollected.Clean
                    && DiscountPercentage.Clean
                    && DiscountPoint.Clean
                    && DishwasherIndicator.Clean
                    && DryerIndicator.Clean
                    && EmailToBeNotifiedWhenUploaded.Clean
                    && EnergyImprovementsAdditionOfFeature.Clean
                    && EntitlementCode.Clean
                    && EquipmentOtherDescription.Clean
                    && ExcludeTaxesInsuranceIndicator.Clean
                    && FinalDiscountAmount.Clean
                    && FinalFundingFeeAmount.Clean
                    && FirstChattelLoanType.Clean
                    && FirstTimeUse.Clean
                    && FundingFeeExempt.Clean
                    && GarbageDisposalIndicator.Clean
                    && Id.Clean
                    && InitialTotal.Clean
                    && InspectionWillBeMadeBy.Clean
                    && Insulation.Clean
                    && InsuranceType.Clean
                    && IrregularLotSizeInSquareFeet.Clean
                    && IsDelinquent30Days.Clean
                    && KeysAtAddress.Clean
                    && LandPurchasePrice.Clean
                    && LeaseholdType.Clean
                    && LenderSAR.Clean
                    && LoanAnalysisRemarks1.Clean
                    && LoanAnalysisRemarks2.Clean
                    && LoanAnalysisRemarks3.Clean
                    && LoanAnalysisRemarks4.Clean
                    && LoanAnalysisRemarks5.Clean
                    && LoanAnalysisRemarks6.Clean
                    && LoanAnalysisRemarks7.Clean
                    && LoanAnalysisRemarks8.Clean
                    && LoanAnalysisRemarks9.Clean
                    && LoanCode.Clean
                    && LoanProcedure.Clean
                    && LoanProcessedUnderAU.Clean
                    && LoanSummaryRemarks1.Clean
                    && LoanSummaryRemarks2.Clean
                    && LoanSummaryRemarks3.Clean
                    && LoanSummaryRemarks4.Clean
                    && LoanSummaryRemarks5.Clean
                    && LoanSummaryRemarks6.Clean
                    && LoanSummaryRemarks7.Clean
                    && LoanSummaryRemarks8.Clean
                    && LotDimensions.Clean
                    && MailingAddress.Clean
                    && MailingCity.Clean
                    && MailingPostalCode.Clean
                    && MailingState.Clean
                    && ManufacturedHome.Clean
                    && MCRVNumber.Clean
                    && MilitaryBranchOfService.Clean
                    && MilitaryServices.Clean
                    && MineralRightsReserved.Clean
                    && NameOfOccupant.Clean
                    && NameOfOwner.Clean
                    && NameOfWarrantyProgram.Clean
                    && NegativeRents.Clean
                    && NoEnergyImprovements.Clean
                    && NonrealtyDescription.Clean
                    && NumberOfBuildings.Clean
                    && OccupantTelephone.Clean
                    && OnMilitaryDutyFollowingSeparation.Clean
                    && OriginalInterestRate.Clean
                    && OriginalLoanAmount.Clean
                    && OriginalTerm.Clean
                    && OriginalValueEstimateChanged.Clean
                    && OriginationFeeAmount.Clean
                    && OtherClosingCosts.Clean
                    && OtherDescriptionEstateProperty.Clean
                    && OtherDescriptionLoanType.Clean
                    && OtherEstateProperty.Clean
                    && OtherImprovements.Clean
                    && OtherLoanType.Clean
                    && PaidInFullVALoanNumber.Clean
                    && PayoffIndicator1.Clean
                    && PayoffIndicator2.Clean
                    && PayoffIndicator3.Clean
                    && PayoffIndicator4.Clean
                    && PayoffIndicator5.Clean
                    && PayoffIndicator6.Clean
                    && PayoffIndicator7.Clean
                    && PayoffIndicator8.Clean
                    && PayoffIndicator9.Clean
                    && PestReportFee.Clean
                    && PlansSubmitted.Clean
                    && POCAddress.Clean
                    && POCCity.Clean
                    && POCName.Clean
                    && POCPhone.Clean
                    && POCState.Clean
                    && POCZipCode.Clean
                    && PreliminaryDiscountAmount.Clean
                    && PreliminaryFundingFeeAmount.Clean
                    && PreliminaryTotal.Clean
                    && PreviousVALoanIndicator.Clean
                    && PreviousVaLoans.Clean
                    && PriorApprovalProcedure.Clean
                    && PriorLoanType.Clean
                    && PropertyDesignation.Clean
                    && PropertyGrossLivingArea.Clean
                    && PropertyLegalDescription1.Clean
                    && PropertyLegalDescription2.Clean
                    && PropertyLegalDescription3.Clean
                    && PropertyLegalDescription4.Clean
                    && PropertyOccupancyType.Clean
                    && ProposedSaleContractAttached.Clean
                    && PurposeOfLoan.Clean
                    && RangeOvenIndicator.Clean
                    && ReasonableValueCompleted.Clean
                    && RefrigeratorIndicator.Clean
                    && Rent.Clean
                    && ReplacementOfSystem.Clean
                    && RiskClasification.Clean
                    && ServiceNumber.Clean
                    && SolarHeatingOrCooling.Clean
                    && SpecialAssessmentComments1.Clean
                    && SpecialAssessmentComments2.Clean
                    && SpecialAssessmentComments3.Clean
                    && StreetAccess.Clean
                    && StreetMaintenance.Clean
                    && SystemUsed.Clean
                    && Title.Clean
                    && TitleLimitations1.Clean
                    && TitleLimitations2.Clean
                    && TitleLimitations3.Clean
                    && TotalBaths.Clean
                    && TotalBedrooms.Clean
                    && TotalDebtMonthlyPayment.Clean
                    && TotalDiscountPointCharged.Clean
                    && TotalDiscountPointsCharged.Clean
                    && TotalForMaxLoanAmount.Clean
                    && TotalMonthlyPayment.Clean
                    && TotalProposedMonthlyPayment.Clean
                    && TotalRooms.Clean
                    && TotalUnpaidSpecialAssessments.Clean
                    && TypeOfHybridARM.Clean
                    && TypeOfMortgage.Clean
                    && TypeOfOwnsership.Clean
                    && TypeOfStructure.Clean
                    && TypeOfVeteran.Clean
                    && UnsecuredLoanType.Clean
                    && UtilitiesElectricDescription.Clean
                    && UtilitiesGasDescription.Clean
                    && UtilitiesSewerDescription.Clean
                    && UtilitiesWaterDescription.Clean
                    && VAAppraisalSentDate.Clean
                    && VABenefitRelatedIndebtedness.Clean
                    && VABuilderDescription.Clean
                    && VABuilderIDNo.Clean
                    && VAClaimFolderNumber.Clean
                    && VAClaimNumber.Clean
                    && VADateNOVAppraisalMailedToBorrower.Clean
                    && VAIsDelinquent30Days.Clean
                    && VALatePaymentIn6Months.Clean
                    && VaLoanSummaryApplicantType.Clean
                    && VANOVDateReceived.Clean
                    && VANOVDateReviewed.Clean
                    && VANOVIssuedDate.Clean
                    && VAOriginalAmortizationType.Clean
                    && VAOriginalMonthlyPayment.Clean
                    && VAQualification2ndTierEntitlement.Clean
                    && VAQualificationCountryRegion.Clean
                    && VAQualificationCountyLimits.Clean
                    && VARecoupmentClosingCosts.Clean
                    && VARecoupmentExcludePrepaids.Clean
                    && VARecoupmentMonthlyDecreaseInPayment.Clean
                    && VARecoupmentMonths.Clean
                    && VARecoupmentTotalClosingCosts.Clean
                    && VARecoupmentYears.Clean
                    && VATrackingCertOfCommitmentIssued.Clean
                    && VATrackingCOEIssueDate.Clean
                    && VATrackingCOEIssueHistory.Clean
                    && VATrackingFinalApprovalCommitmentDate.Clean
                    && VATrackingGSAExclusionaryListChecked.Clean
                    && VATrackingInuranceFloodPolicy.Clean
                    && VATrackingInuranceHazardPolicy.Clean
                    && VATrackingInuranceWindOrHailPolicy.Clean
                    && VATrackingInuranceWoodDestroyingPolicy.Clean
                    && VATrackingIsSARLAPPCertified.Clean
                    && VATrackingLoanGuaranteeCertReceipt.Clean
                    && VATrackingMasterCommitmentLockExpired.Clean
                    && VATrackingOrderedDate.Clean
                    && VATrackingPaidDate.Clean
                    && VATrackingPurchaseContractDate.Clean
                    && VATrackingReceiptReceived.Clean
                    && VATrackingSARID.Clean
                    && VATrackingSARName.Clean
                    && VentFanIndicator.Clean
                    && VeteranDischargedIndicator.Clean
                    && VeteranServiceType.Clean
                    && WarrantorAddress.Clean
                    && WarrantorCity.Clean
                    && WarrantorName.Clean
                    && WarrantorPhone.Clean
                    && WarrantorPostalCode.Clean
                    && WarrantorState.Clean
                    && WarrantyProgramExpirationDate.Clean
                    && WWCarpetIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Acres; v0.Clean = value; Acres = v0;
                var v1 = AdditionalSecurityDescription; v1.Clean = value; AdditionalSecurityDescription = v1;
                var v2 = AdministratorAddress; v2.Clean = value; AdministratorAddress = v2;
                var v3 = AdministratorCity; v3.Clean = value; AdministratorCity = v3;
                var v4 = AdministratorContact; v4.Clean = value; AdministratorContact = v4;
                var v5 = AdministratorName; v5.Clean = value; AdministratorName = v5;
                var v6 = AdministratorPostalCode; v6.Clean = value; AdministratorPostalCode = v6;
                var v7 = AdministratorState; v7.Clean = value; AdministratorState = v7;
                var v8 = AgeOfProperty; v8.Clean = value; AgeOfProperty = v8;
                var v9 = AmountSpentOnEnergyImprovements; v9.Clean = value; AmountSpentOnEnergyImprovements = v9;
                var v10 = AmountTypeWithheld; v10.Clean = value; AmountTypeWithheld = v10;
                var v11 = AmountWithheld; v11.Clean = value; AmountWithheld = v11;
                var v12 = AnnualGroundRent; v12.Clean = value; AnnualGroundRent = v12;
                var v13 = AnnualMaintenanceAssessment; v13.Clean = value; AnnualMaintenanceAssessment = v13;
                var v14 = AnnualRealEstateTaxes; v14.Clean = value; AnnualRealEstateTaxes = v14;
                var v15 = AnnualSpecialAssessment; v15.Clean = value; AnnualSpecialAssessment = v15;
                var v16 = ApplicantAddressCity; v16.Clean = value; ApplicantAddressCity = v16;
                var v17 = ApplicantAddressPostalCode; v17.Clean = value; ApplicantAddressPostalCode = v17;
                var v18 = ApplicantAddressState; v18.Clean = value; ApplicantAddressState = v18;
                var v19 = ApplicantAddressStreetLine1; v19.Clean = value; ApplicantAddressStreetLine1 = v19;
                var v20 = ApplicantBirthDate; v20.Clean = value; ApplicantBirthDate = v20;
                var v21 = ApplicantEmailAddressText; v21.Clean = value; ApplicantEmailAddressText = v21;
                var v22 = ApplicantFirstNameWithMiddleName; v22.Clean = value; ApplicantFirstNameWithMiddleName = v22;
                var v23 = ApplicantHmdaGenderType; v23.Clean = value; ApplicantHmdaGenderType = v23;
                var v24 = ApplicantHomePhoneNumber; v24.Clean = value; ApplicantHomePhoneNumber = v24;
                var v25 = ApplicantLastNameWithSuffix; v25.Clean = value; ApplicantLastNameWithSuffix = v25;
                var v26 = ApplicantTaxIdentificationIdentifier; v26.Clean = value; ApplicantTaxIdentificationIdentifier = v26;
                var v27 = AppraisalType; v27.Clean = value; AppraisalType = v27;
                var v28 = AutomaticProcedure; v28.Clean = value; AutomaticProcedure = v28;
                var v29 = AvailableForInspectionAMIndicator; v29.Clean = value; AvailableForInspectionAMIndicator = v29;
                var v30 = AvailableForInspectionDateAndTime; v30.Clean = value; AvailableForInspectionDateAndTime = v30;
                var v31 = BorrowerPaidDiscountPointsTotalAmount; v31.Clean = value; BorrowerPaidDiscountPointsTotalAmount = v31;
                var v32 = BuildingType; v32.Clean = value; BuildingType = v32;
                var v33 = BuyerPurchasingLotSeparately; v33.Clean = value; BuyerPurchasingLotSeparately = v33;
                var v34 = CashPaymentFromVeteran; v34.Clean = value; CashPaymentFromVeteran = v34;
                var v35 = ClaimDisabilityBenefits; v35.Clean = value; ClaimDisabilityBenefits = v35;
                var v36 = ClothesWasherIndicator; v36.Clean = value; ClothesWasherIndicator = v36;
                var v37 = ConstructionCompletedDate; v37.Clean = value; ConstructionCompletedDate = v37;
                var v38 = ConstructionPlan; v38.Clean = value; ConstructionPlan = v38;
                var v39 = ConstructionWarrantyIncluded; v39.Clean = value; ConstructionWarrantyIncluded = v39;
                var v40 = ContractNoApprovedByVA; v40.Clean = value; ContractNoApprovedByVA = v40;
                var v41 = CreditScore; v41.Clean = value; CreditScore = v41;
                var v42 = CurrentlyOnMilitaryDuty; v42.Clean = value; CurrentlyOnMilitaryDuty = v42;
                var v43 = DateAquiredLand; v43.Clean = value; DateAquiredLand = v43;
                var v44 = DateOfAssignment; v44.Clean = value; DateOfAssignment = v44;
                var v45 = DateSAR; v45.Clean = value; DateSAR = v45;
                var v46 = DisabilityAmountCollected; v46.Clean = value; DisabilityAmountCollected = v46;
                var v47 = DiscountPercentage; v47.Clean = value; DiscountPercentage = v47;
                var v48 = DiscountPoint; v48.Clean = value; DiscountPoint = v48;
                var v49 = DishwasherIndicator; v49.Clean = value; DishwasherIndicator = v49;
                var v50 = DryerIndicator; v50.Clean = value; DryerIndicator = v50;
                var v51 = EmailToBeNotifiedWhenUploaded; v51.Clean = value; EmailToBeNotifiedWhenUploaded = v51;
                var v52 = EnergyImprovementsAdditionOfFeature; v52.Clean = value; EnergyImprovementsAdditionOfFeature = v52;
                var v53 = EntitlementCode; v53.Clean = value; EntitlementCode = v53;
                var v54 = EquipmentOtherDescription; v54.Clean = value; EquipmentOtherDescription = v54;
                var v55 = ExcludeTaxesInsuranceIndicator; v55.Clean = value; ExcludeTaxesInsuranceIndicator = v55;
                var v56 = FinalDiscountAmount; v56.Clean = value; FinalDiscountAmount = v56;
                var v57 = FinalFundingFeeAmount; v57.Clean = value; FinalFundingFeeAmount = v57;
                var v58 = FirstChattelLoanType; v58.Clean = value; FirstChattelLoanType = v58;
                var v59 = FirstTimeUse; v59.Clean = value; FirstTimeUse = v59;
                var v60 = FundingFeeExempt; v60.Clean = value; FundingFeeExempt = v60;
                var v61 = GarbageDisposalIndicator; v61.Clean = value; GarbageDisposalIndicator = v61;
                var v62 = Id; v62.Clean = value; Id = v62;
                var v63 = InitialTotal; v63.Clean = value; InitialTotal = v63;
                var v64 = InspectionWillBeMadeBy; v64.Clean = value; InspectionWillBeMadeBy = v64;
                var v65 = Insulation; v65.Clean = value; Insulation = v65;
                var v66 = InsuranceType; v66.Clean = value; InsuranceType = v66;
                var v67 = IrregularLotSizeInSquareFeet; v67.Clean = value; IrregularLotSizeInSquareFeet = v67;
                var v68 = IsDelinquent30Days; v68.Clean = value; IsDelinquent30Days = v68;
                var v69 = KeysAtAddress; v69.Clean = value; KeysAtAddress = v69;
                var v70 = LandPurchasePrice; v70.Clean = value; LandPurchasePrice = v70;
                var v71 = LeaseholdType; v71.Clean = value; LeaseholdType = v71;
                var v72 = LenderSAR; v72.Clean = value; LenderSAR = v72;
                var v73 = LoanAnalysisRemarks1; v73.Clean = value; LoanAnalysisRemarks1 = v73;
                var v74 = LoanAnalysisRemarks2; v74.Clean = value; LoanAnalysisRemarks2 = v74;
                var v75 = LoanAnalysisRemarks3; v75.Clean = value; LoanAnalysisRemarks3 = v75;
                var v76 = LoanAnalysisRemarks4; v76.Clean = value; LoanAnalysisRemarks4 = v76;
                var v77 = LoanAnalysisRemarks5; v77.Clean = value; LoanAnalysisRemarks5 = v77;
                var v78 = LoanAnalysisRemarks6; v78.Clean = value; LoanAnalysisRemarks6 = v78;
                var v79 = LoanAnalysisRemarks7; v79.Clean = value; LoanAnalysisRemarks7 = v79;
                var v80 = LoanAnalysisRemarks8; v80.Clean = value; LoanAnalysisRemarks8 = v80;
                var v81 = LoanAnalysisRemarks9; v81.Clean = value; LoanAnalysisRemarks9 = v81;
                var v82 = LoanCode; v82.Clean = value; LoanCode = v82;
                var v83 = LoanProcedure; v83.Clean = value; LoanProcedure = v83;
                var v84 = LoanProcessedUnderAU; v84.Clean = value; LoanProcessedUnderAU = v84;
                var v85 = LoanSummaryRemarks1; v85.Clean = value; LoanSummaryRemarks1 = v85;
                var v86 = LoanSummaryRemarks2; v86.Clean = value; LoanSummaryRemarks2 = v86;
                var v87 = LoanSummaryRemarks3; v87.Clean = value; LoanSummaryRemarks3 = v87;
                var v88 = LoanSummaryRemarks4; v88.Clean = value; LoanSummaryRemarks4 = v88;
                var v89 = LoanSummaryRemarks5; v89.Clean = value; LoanSummaryRemarks5 = v89;
                var v90 = LoanSummaryRemarks6; v90.Clean = value; LoanSummaryRemarks6 = v90;
                var v91 = LoanSummaryRemarks7; v91.Clean = value; LoanSummaryRemarks7 = v91;
                var v92 = LoanSummaryRemarks8; v92.Clean = value; LoanSummaryRemarks8 = v92;
                var v93 = LotDimensions; v93.Clean = value; LotDimensions = v93;
                var v94 = MailingAddress; v94.Clean = value; MailingAddress = v94;
                var v95 = MailingCity; v95.Clean = value; MailingCity = v95;
                var v96 = MailingPostalCode; v96.Clean = value; MailingPostalCode = v96;
                var v97 = MailingState; v97.Clean = value; MailingState = v97;
                var v98 = ManufacturedHome; v98.Clean = value; ManufacturedHome = v98;
                var v99 = MCRVNumber; v99.Clean = value; MCRVNumber = v99;
                var v100 = MilitaryBranchOfService; v100.Clean = value; MilitaryBranchOfService = v100;
                var v101 = MilitaryServices; v101.Clean = value; MilitaryServices = v101;
                var v102 = MineralRightsReserved; v102.Clean = value; MineralRightsReserved = v102;
                var v103 = NameOfOccupant; v103.Clean = value; NameOfOccupant = v103;
                var v104 = NameOfOwner; v104.Clean = value; NameOfOwner = v104;
                var v105 = NameOfWarrantyProgram; v105.Clean = value; NameOfWarrantyProgram = v105;
                var v106 = NegativeRents; v106.Clean = value; NegativeRents = v106;
                var v107 = NoEnergyImprovements; v107.Clean = value; NoEnergyImprovements = v107;
                var v108 = NonrealtyDescription; v108.Clean = value; NonrealtyDescription = v108;
                var v109 = NumberOfBuildings; v109.Clean = value; NumberOfBuildings = v109;
                var v110 = OccupantTelephone; v110.Clean = value; OccupantTelephone = v110;
                var v111 = OnMilitaryDutyFollowingSeparation; v111.Clean = value; OnMilitaryDutyFollowingSeparation = v111;
                var v112 = OriginalInterestRate; v112.Clean = value; OriginalInterestRate = v112;
                var v113 = OriginalLoanAmount; v113.Clean = value; OriginalLoanAmount = v113;
                var v114 = OriginalTerm; v114.Clean = value; OriginalTerm = v114;
                var v115 = OriginalValueEstimateChanged; v115.Clean = value; OriginalValueEstimateChanged = v115;
                var v116 = OriginationFeeAmount; v116.Clean = value; OriginationFeeAmount = v116;
                var v117 = OtherClosingCosts; v117.Clean = value; OtherClosingCosts = v117;
                var v118 = OtherDescriptionEstateProperty; v118.Clean = value; OtherDescriptionEstateProperty = v118;
                var v119 = OtherDescriptionLoanType; v119.Clean = value; OtherDescriptionLoanType = v119;
                var v120 = OtherEstateProperty; v120.Clean = value; OtherEstateProperty = v120;
                var v121 = OtherImprovements; v121.Clean = value; OtherImprovements = v121;
                var v122 = OtherLoanType; v122.Clean = value; OtherLoanType = v122;
                var v123 = PaidInFullVALoanNumber; v123.Clean = value; PaidInFullVALoanNumber = v123;
                var v124 = PayoffIndicator1; v124.Clean = value; PayoffIndicator1 = v124;
                var v125 = PayoffIndicator2; v125.Clean = value; PayoffIndicator2 = v125;
                var v126 = PayoffIndicator3; v126.Clean = value; PayoffIndicator3 = v126;
                var v127 = PayoffIndicator4; v127.Clean = value; PayoffIndicator4 = v127;
                var v128 = PayoffIndicator5; v128.Clean = value; PayoffIndicator5 = v128;
                var v129 = PayoffIndicator6; v129.Clean = value; PayoffIndicator6 = v129;
                var v130 = PayoffIndicator7; v130.Clean = value; PayoffIndicator7 = v130;
                var v131 = PayoffIndicator8; v131.Clean = value; PayoffIndicator8 = v131;
                var v132 = PayoffIndicator9; v132.Clean = value; PayoffIndicator9 = v132;
                var v133 = PestReportFee; v133.Clean = value; PestReportFee = v133;
                var v134 = PlansSubmitted; v134.Clean = value; PlansSubmitted = v134;
                var v135 = POCAddress; v135.Clean = value; POCAddress = v135;
                var v136 = POCCity; v136.Clean = value; POCCity = v136;
                var v137 = POCName; v137.Clean = value; POCName = v137;
                var v138 = POCPhone; v138.Clean = value; POCPhone = v138;
                var v139 = POCState; v139.Clean = value; POCState = v139;
                var v140 = POCZipCode; v140.Clean = value; POCZipCode = v140;
                var v141 = PreliminaryDiscountAmount; v141.Clean = value; PreliminaryDiscountAmount = v141;
                var v142 = PreliminaryFundingFeeAmount; v142.Clean = value; PreliminaryFundingFeeAmount = v142;
                var v143 = PreliminaryTotal; v143.Clean = value; PreliminaryTotal = v143;
                var v144 = PreviousVALoanIndicator; v144.Clean = value; PreviousVALoanIndicator = v144;
                var v145 = PreviousVaLoans; v145.Clean = value; PreviousVaLoans = v145;
                var v146 = PriorApprovalProcedure; v146.Clean = value; PriorApprovalProcedure = v146;
                var v147 = PriorLoanType; v147.Clean = value; PriorLoanType = v147;
                var v148 = PropertyDesignation; v148.Clean = value; PropertyDesignation = v148;
                var v149 = PropertyGrossLivingArea; v149.Clean = value; PropertyGrossLivingArea = v149;
                var v150 = PropertyLegalDescription1; v150.Clean = value; PropertyLegalDescription1 = v150;
                var v151 = PropertyLegalDescription2; v151.Clean = value; PropertyLegalDescription2 = v151;
                var v152 = PropertyLegalDescription3; v152.Clean = value; PropertyLegalDescription3 = v152;
                var v153 = PropertyLegalDescription4; v153.Clean = value; PropertyLegalDescription4 = v153;
                var v154 = PropertyOccupancyType; v154.Clean = value; PropertyOccupancyType = v154;
                var v155 = ProposedSaleContractAttached; v155.Clean = value; ProposedSaleContractAttached = v155;
                var v156 = PurposeOfLoan; v156.Clean = value; PurposeOfLoan = v156;
                var v157 = RangeOvenIndicator; v157.Clean = value; RangeOvenIndicator = v157;
                var v158 = ReasonableValueCompleted; v158.Clean = value; ReasonableValueCompleted = v158;
                var v159 = RefrigeratorIndicator; v159.Clean = value; RefrigeratorIndicator = v159;
                var v160 = Rent; v160.Clean = value; Rent = v160;
                var v161 = ReplacementOfSystem; v161.Clean = value; ReplacementOfSystem = v161;
                var v162 = RiskClasification; v162.Clean = value; RiskClasification = v162;
                var v163 = ServiceNumber; v163.Clean = value; ServiceNumber = v163;
                var v164 = SolarHeatingOrCooling; v164.Clean = value; SolarHeatingOrCooling = v164;
                var v165 = SpecialAssessmentComments1; v165.Clean = value; SpecialAssessmentComments1 = v165;
                var v166 = SpecialAssessmentComments2; v166.Clean = value; SpecialAssessmentComments2 = v166;
                var v167 = SpecialAssessmentComments3; v167.Clean = value; SpecialAssessmentComments3 = v167;
                var v168 = StreetAccess; v168.Clean = value; StreetAccess = v168;
                var v169 = StreetMaintenance; v169.Clean = value; StreetMaintenance = v169;
                var v170 = SystemUsed; v170.Clean = value; SystemUsed = v170;
                var v171 = Title; v171.Clean = value; Title = v171;
                var v172 = TitleLimitations1; v172.Clean = value; TitleLimitations1 = v172;
                var v173 = TitleLimitations2; v173.Clean = value; TitleLimitations2 = v173;
                var v174 = TitleLimitations3; v174.Clean = value; TitleLimitations3 = v174;
                var v175 = TotalBaths; v175.Clean = value; TotalBaths = v175;
                var v176 = TotalBedrooms; v176.Clean = value; TotalBedrooms = v176;
                var v177 = TotalDebtMonthlyPayment; v177.Clean = value; TotalDebtMonthlyPayment = v177;
                var v178 = TotalDiscountPointCharged; v178.Clean = value; TotalDiscountPointCharged = v178;
                var v179 = TotalDiscountPointsCharged; v179.Clean = value; TotalDiscountPointsCharged = v179;
                var v180 = TotalForMaxLoanAmount; v180.Clean = value; TotalForMaxLoanAmount = v180;
                var v181 = TotalMonthlyPayment; v181.Clean = value; TotalMonthlyPayment = v181;
                var v182 = TotalProposedMonthlyPayment; v182.Clean = value; TotalProposedMonthlyPayment = v182;
                var v183 = TotalRooms; v183.Clean = value; TotalRooms = v183;
                var v184 = TotalUnpaidSpecialAssessments; v184.Clean = value; TotalUnpaidSpecialAssessments = v184;
                var v185 = TypeOfHybridARM; v185.Clean = value; TypeOfHybridARM = v185;
                var v186 = TypeOfMortgage; v186.Clean = value; TypeOfMortgage = v186;
                var v187 = TypeOfOwnsership; v187.Clean = value; TypeOfOwnsership = v187;
                var v188 = TypeOfStructure; v188.Clean = value; TypeOfStructure = v188;
                var v189 = TypeOfVeteran; v189.Clean = value; TypeOfVeteran = v189;
                var v190 = UnsecuredLoanType; v190.Clean = value; UnsecuredLoanType = v190;
                var v191 = UtilitiesElectricDescription; v191.Clean = value; UtilitiesElectricDescription = v191;
                var v192 = UtilitiesGasDescription; v192.Clean = value; UtilitiesGasDescription = v192;
                var v193 = UtilitiesSewerDescription; v193.Clean = value; UtilitiesSewerDescription = v193;
                var v194 = UtilitiesWaterDescription; v194.Clean = value; UtilitiesWaterDescription = v194;
                var v195 = VAAppraisalSentDate; v195.Clean = value; VAAppraisalSentDate = v195;
                var v196 = VABenefitRelatedIndebtedness; v196.Clean = value; VABenefitRelatedIndebtedness = v196;
                var v197 = VABuilderDescription; v197.Clean = value; VABuilderDescription = v197;
                var v198 = VABuilderIDNo; v198.Clean = value; VABuilderIDNo = v198;
                var v199 = VAClaimFolderNumber; v199.Clean = value; VAClaimFolderNumber = v199;
                var v200 = VAClaimNumber; v200.Clean = value; VAClaimNumber = v200;
                var v201 = VADateNOVAppraisalMailedToBorrower; v201.Clean = value; VADateNOVAppraisalMailedToBorrower = v201;
                var v202 = VAIsDelinquent30Days; v202.Clean = value; VAIsDelinquent30Days = v202;
                var v203 = VALatePaymentIn6Months; v203.Clean = value; VALatePaymentIn6Months = v203;
                var v204 = VaLoanSummaryApplicantType; v204.Clean = value; VaLoanSummaryApplicantType = v204;
                var v205 = VANOVDateReceived; v205.Clean = value; VANOVDateReceived = v205;
                var v206 = VANOVDateReviewed; v206.Clean = value; VANOVDateReviewed = v206;
                var v207 = VANOVIssuedDate; v207.Clean = value; VANOVIssuedDate = v207;
                var v208 = VAOriginalAmortizationType; v208.Clean = value; VAOriginalAmortizationType = v208;
                var v209 = VAOriginalMonthlyPayment; v209.Clean = value; VAOriginalMonthlyPayment = v209;
                var v210 = VAQualification2ndTierEntitlement; v210.Clean = value; VAQualification2ndTierEntitlement = v210;
                var v211 = VAQualificationCountryRegion; v211.Clean = value; VAQualificationCountryRegion = v211;
                var v212 = VAQualificationCountyLimits; v212.Clean = value; VAQualificationCountyLimits = v212;
                var v213 = VARecoupmentClosingCosts; v213.Clean = value; VARecoupmentClosingCosts = v213;
                var v214 = VARecoupmentExcludePrepaids; v214.Clean = value; VARecoupmentExcludePrepaids = v214;
                var v215 = VARecoupmentMonthlyDecreaseInPayment; v215.Clean = value; VARecoupmentMonthlyDecreaseInPayment = v215;
                var v216 = VARecoupmentMonths; v216.Clean = value; VARecoupmentMonths = v216;
                var v217 = VARecoupmentTotalClosingCosts; v217.Clean = value; VARecoupmentTotalClosingCosts = v217;
                var v218 = VARecoupmentYears; v218.Clean = value; VARecoupmentYears = v218;
                var v219 = VATrackingCertOfCommitmentIssued; v219.Clean = value; VATrackingCertOfCommitmentIssued = v219;
                var v220 = VATrackingCOEIssueDate; v220.Clean = value; VATrackingCOEIssueDate = v220;
                var v221 = VATrackingCOEIssueHistory; v221.Clean = value; VATrackingCOEIssueHistory = v221;
                var v222 = VATrackingFinalApprovalCommitmentDate; v222.Clean = value; VATrackingFinalApprovalCommitmentDate = v222;
                var v223 = VATrackingGSAExclusionaryListChecked; v223.Clean = value; VATrackingGSAExclusionaryListChecked = v223;
                var v224 = VATrackingInuranceFloodPolicy; v224.Clean = value; VATrackingInuranceFloodPolicy = v224;
                var v225 = VATrackingInuranceHazardPolicy; v225.Clean = value; VATrackingInuranceHazardPolicy = v225;
                var v226 = VATrackingInuranceWindOrHailPolicy; v226.Clean = value; VATrackingInuranceWindOrHailPolicy = v226;
                var v227 = VATrackingInuranceWoodDestroyingPolicy; v227.Clean = value; VATrackingInuranceWoodDestroyingPolicy = v227;
                var v228 = VATrackingIsSARLAPPCertified; v228.Clean = value; VATrackingIsSARLAPPCertified = v228;
                var v229 = VATrackingLoanGuaranteeCertReceipt; v229.Clean = value; VATrackingLoanGuaranteeCertReceipt = v229;
                var v230 = VATrackingMasterCommitmentLockExpired; v230.Clean = value; VATrackingMasterCommitmentLockExpired = v230;
                var v231 = VATrackingOrderedDate; v231.Clean = value; VATrackingOrderedDate = v231;
                var v232 = VATrackingPaidDate; v232.Clean = value; VATrackingPaidDate = v232;
                var v233 = VATrackingPurchaseContractDate; v233.Clean = value; VATrackingPurchaseContractDate = v233;
                var v234 = VATrackingReceiptReceived; v234.Clean = value; VATrackingReceiptReceived = v234;
                var v235 = VATrackingSARID; v235.Clean = value; VATrackingSARID = v235;
                var v236 = VATrackingSARName; v236.Clean = value; VATrackingSARName = v236;
                var v237 = VentFanIndicator; v237.Clean = value; VentFanIndicator = v237;
                var v238 = VeteranDischargedIndicator; v238.Clean = value; VeteranDischargedIndicator = v238;
                var v239 = VeteranServiceType; v239.Clean = value; VeteranServiceType = v239;
                var v240 = WarrantorAddress; v240.Clean = value; WarrantorAddress = v240;
                var v241 = WarrantorCity; v241.Clean = value; WarrantorCity = v241;
                var v242 = WarrantorName; v242.Clean = value; WarrantorName = v242;
                var v243 = WarrantorPhone; v243.Clean = value; WarrantorPhone = v243;
                var v244 = WarrantorPostalCode; v244.Clean = value; WarrantorPostalCode = v244;
                var v245 = WarrantorState; v245.Clean = value; WarrantorState = v245;
                var v246 = WarrantyProgramExpirationDate; v246.Clean = value; WarrantyProgramExpirationDate = v246;
                var v247 = WWCarpetIndicator; v247.Clean = value; WWCarpetIndicator = v247;
                _settingClean = 0;
            }
        }
    }
}