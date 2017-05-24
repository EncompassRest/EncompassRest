using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class FhaVaLoan
    {
        public Value<string> AddendumType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddendumType() => !AddendumType.Clean;
        public Value<bool?> AdditionalCondition1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition1() => !AdditionalCondition1.Clean;
        public Value<bool?> AdditionalCondition2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition2() => !AdditionalCondition2.Clean;
        public Value<bool?> AdditionalCondition3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition3() => !AdditionalCondition3.Clean;
        public Value<bool?> AdditionalCondition4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition4() => !AdditionalCondition4.Clean;
        public Value<bool?> AdditionalCondition5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition5() => !AdditionalCondition5.Clean;
        public Value<bool?> AdditionalCondition6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition6() => !AdditionalCondition6.Clean;
        public Value<bool?> AdditionalCondition7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition7() => !AdditionalCondition7.Clean;
        public Value<bool?> AdditionalCondition8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition8() => !AdditionalCondition8.Clean;
        public Value<bool?> AdditionalCondition9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalCondition9() => !AdditionalCondition9.Clean;
        public Value<string> AddressValidatedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressValidatedBy() => !AddressValidatedBy.Clean;
        public Value<string> AddressValidationMessage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddressValidationMessage() => !AddressValidationMessage.Clean;
        public Value<bool?> AllConditionsSatisfied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllConditionsSatisfied() => !AllConditionsSatisfied.Clean;
        public Value<DateTime?> AppraisalLoggedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalLoggedDate() => !AppraisalLoggedDate.Clean;
        public Value<string> AppraisalLookupBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalLookupBy() => !AppraisalLookupBy.Clean;
        public Value<string> BeenInformed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeenInformed() => !BeenInformed.Clean;
        public Value<string> BorrowerCertificationAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCertificationAddress() => !BorrowerCertificationAddress.Clean;
        public Value<string> BorrowerCertificationCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCertificationCity() => !BorrowerCertificationCity.Clean;
        public Value<string> BorrowerCertificationPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCertificationPostalCode() => !BorrowerCertificationPostalCode.Clean;
        public Value<string> BorrowerCertificationState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCertificationState() => !BorrowerCertificationState.Clean;
        public Value<string> CAIVRSObtainedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCAIVRSObtainedBy() => !CAIVRSObtainedBy.Clean;
        public Value<string> CaseBinderShippedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseBinderShippedBy() => !CaseBinderShippedBy.Clean;
        public Value<DateTime?> CaseBinderShippedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseBinderShippedDate() => !CaseBinderShippedDate.Clean;
        public Value<DateTime?> ClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDate() => !ClosingDate.Clean;
        public Value<string> CondoPudID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondoPudID() => !CondoPudID.Clean;
        public Value<string> CondoPudLookupBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondoPudLookupBy() => !CondoPudLookupBy.Clean;
        public Value<DateTime?> CondoPudLookupDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondoPudLookupDate() => !CondoPudLookupDate.Clean;
        public Value<DateTime?> DateApprovalExpires { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateApprovalExpires() => !DateApprovalExpires.Clean;
        public Value<DateTime?> DateMortgageApproved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateMortgageApproved() => !DateMortgageApproved.Clean;
        public Value<string> DetailForOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDetailForOther() => !DetailForOther.Clean;
        public Value<decimal?> DiscountPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoints() => !DiscountPoints.Clean;
        public Value<string> DulyAgentAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentAddress() => !DulyAgentAddress.Clean;
        public Value<string> DulyAgentCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentCity() => !DulyAgentCity.Clean;
        public Value<string> DulyAgentFunction1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentFunction1() => !DulyAgentFunction1.Clean;
        public Value<string> DulyAgentFunction2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentFunction2() => !DulyAgentFunction2.Clean;
        public Value<string> DulyAgentName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentName() => !DulyAgentName.Clean;
        public Value<string> DulyAgentState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDulyAgentState() => !DulyAgentState.Clean;
        public Value<bool?> DwellingCoveredBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDwellingCoveredBy() => !DwellingCoveredBy.Clean;
        public EnergyEfficientMortgage Eem { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEem() => Eem?.Clean == false;
        public Value<string> EligibilityAssessment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEligibilityAssessment() => !EligibilityAssessment.Clean;
        public Value<decimal?> EnergyEfficientMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageAmount() => !EnergyEfficientMortgageAmount.Clean;
        public Value<List<EnergyEfficientMortgageItem>> EnergyEfficientMortgageItems { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyEfficientMortgageItems() => !EnergyEfficientMortgageItems.Clean;
        public Value<bool?> EverHadVAHomeLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEverHadVAHomeLoan() => !EverHadVAHomeLoan.Clean;
        public Value<decimal?> ExcessContributionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcessContributionAmount() => !ExcessContributionAmount.Clean;
        public Value<decimal?> ExistingDebtAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingDebtAmount() => !ExistingDebtAmount.Clean;
        public Value<string> FHACaseOrderedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHACaseOrderedBy() => !FHACaseOrderedBy.Clean;
        public Value<string> FHAManagementCounselType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAManagementCounselType() => !FHAManagementCounselType.Clean;
        public Value<decimal?> FHAMaxLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFHAMaxLoanAmount() => !FHAMaxLoanAmount.Clean;
        public Value<bool?> ForeclosedProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForeclosedProperty() => !ForeclosedProperty.Clean;
        public Value<string> FreddieMacCounselType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacCounselType() => !FreddieMacCounselType.Clean;
        public Value<decimal?> FundingFeePaidInCash { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFeePaidInCash() => !FundingFeePaidInCash.Clean;
        public Value<decimal?> GiftFundsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGiftFundsAmount() => !GiftFundsAmount.Clean;
        public Value<bool?> HaveReceivedLeadPaintPoisoningInfo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHaveReceivedLeadPaintPoisoningInfo() => !HaveReceivedLeadPaintPoisoningInfo.Clean;
        public Value<string> HUD1003AddendumApproved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1003AddendumApproved() => !HUD1003AddendumApproved.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> LastRefiDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastRefiDate() => !LastRefiDate.Clean;
        public Value<DateTime?> LDPGSASearchDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSASearchDate() => !LDPGSASearchDate.Clean;
        public Value<string> LDPGSASearchedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLDPGSASearchedBy() => !LDPGSASearchedBy.Clean;
        public Value<string> LenderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAddress() => !LenderAddress.Clean;
        public Value<string> LenderCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCity() => !LenderCity.Clean;
        public Value<string> LenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderName() => !LenderName.Clean;
        public Value<string> LenderNMLS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNMLS() => !LenderNMLS.Clean;
        public Value<string> LenderPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPostalCode() => !LenderPostalCode.Clean;
        public Value<string> LenderRepresentativeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderRepresentativeName() => !LenderRepresentativeName.Clean;
        public Value<string> LenderRepresentativePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderRepresentativePhone() => !LenderRepresentativePhone.Clean;
        public Value<string> LenderRepresentativeTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderRepresentativeTitle() => !LenderRepresentativeTitle.Clean;
        public Value<string> LenderState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderState() => !LenderState.Clean;
        public Value<string> LenderTaxID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderTaxID() => !LenderTaxID.Clean;
        public Value<string> LoanScoreID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanScoreID() => !LoanScoreID.Clean;
        public Value<string> MIAppliedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIAppliedBy() => !MIAppliedBy.Clean;
        public Value<DateTime?> MIAppliedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIAppliedDate() => !MIAppliedDate.Clean;
        public Value<DateTime?> MICRetrivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMICRetrivedDate() => !MICRetrivedDate.Clean;
        public Value<decimal?> MinimumDownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumDownPayment() => !MinimumDownPayment.Clean;
        public Value<DateTime?> MIP1stDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIP1stDueDate() => !MIP1stDueDate.Clean;
        public Value<DateTime?> MIP1stToInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIP1stToInvestor() => !MIP1stToInvestor.Clean;
        public Value<DateTime?> MIPRemittedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPRemittedDate() => !MIPRemittedDate.Clean;
        public Value<DateTime?> MIRejectedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIRejectedDate() => !MIRejectedDate.Clean;
        public Value<decimal?> ModifiedInterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedInterestRate() => !ModifiedInterestRate.Clean;
        public Value<decimal?> ModifiedLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedLoanAmount() => !ModifiedLoanAmount.Clean;
        public Value<decimal?> ModifiedMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedMonthlyPayment() => !ModifiedMonthlyPayment.Clean;
        public Value<decimal?> ModifiedMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedMonthlyPremium() => !ModifiedMonthlyPremium.Clean;
        public Value<int?> ModifiedProposedMaturityMonth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedProposedMaturityMonth() => !ModifiedProposedMaturityMonth.Clean;
        public Value<int?> ModifiedProposedMaturityYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedProposedMaturityYear() => !ModifiedProposedMaturityYear.Clean;
        public Value<int?> ModifiedTermAnnualPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedTermAnnualPremium() => !ModifiedTermAnnualPremium.Clean;
        public Value<decimal?> ModifiedUpfrontPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModifiedUpfrontPremium() => !ModifiedUpfrontPremium.Clean;
        public Value<string> MortgageeRepresentative { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageeRepresentative() => !MortgageeRepresentative.Clean;
        public Value<string> MortgageFinancialInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageFinancialInterest() => !MortgageFinancialInterest.Clean;
        public Value<decimal?> NonRealtyAndOtherItems { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonRealtyAndOtherItems() => !NonRealtyAndOtherItems.Clean;
        public Value<DateTime?> ObtainCAIVRSDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObtainCAIVRSDate() => !ObtainCAIVRSDate.Clean;
        public Value<string> Occupancy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancy() => !Occupancy.Clean;
        public Value<string> OldAgencyCaseIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOldAgencyCaseIdentifier() => !OldAgencyCaseIdentifier.Clean;
        public Value<decimal?> OriginalMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalMortgageAmount() => !OriginalMortgageAmount.Clean;
        public Value<decimal?> OtherLiabilitiesMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLiabilitiesMonthlyPayment() => !OtherLiabilitiesMonthlyPayment.Clean;
        public Value<decimal?> OtherLiabilitiesUnpaidBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLiabilitiesUnpaidBalance() => !OtherLiabilitiesUnpaidBalance.Clean;
        public Value<decimal?> OtherMonthlyShelterExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMonthlyShelterExpense() => !OtherMonthlyShelterExpense.Clean;
        public Value<string> OtherTitleDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherTitleDescription() => !OtherTitleDescription.Clean;
        public Value<bool?> OwnMoreThanFourDwellings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnMoreThanFourDwellings() => !OwnMoreThanFourDwellings.Clean;
        public Value<bool?> OwnOrSoldOtherRealEstate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOwnOrSoldOtherRealEstate() => !OwnOrSoldOtherRealEstate.Clean;
        public Value<decimal?> PaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidAmount() => !PaidAmount.Clean;
        public Value<int?> PremiumMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePremiumMonths() => !PremiumMonths.Clean;
        public Value<decimal?> PrepaidExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidExpenses() => !PrepaidExpenses.Clean;
        public Value<DateTime?> PreviousPurchaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousPurchaseDate() => !PreviousPurchaseDate.Clean;
        public Value<DateTime?> PriorEndorsementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorEndorsementDate() => !PriorEndorsementDate.Clean;
        public Value<int?> ProposedMaturityMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMaturityMonths() => !ProposedMaturityMonths.Clean;
        public Value<int?> ProposedMaturityYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMaturityYears() => !ProposedMaturityYears.Clean;
        public Value<string> PurposeOfLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurposeOfLoan() => !PurposeOfLoan.Clean;
        public Value<string> RefiAuthorizationBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefiAuthorizationBy() => !RefiAuthorizationBy.Clean;
        public Value<DateTime?> RefiAuthorizationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefiAuthorizationDate() => !RefiAuthorizationDate.Clean;
        public Value<decimal?> SalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSalesPrice() => !SalesPrice.Clean;
        public Value<decimal?> SecondMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondMortgageAmount() => !SecondMortgageAmount.Clean;
        public Value<decimal?> SellerPaidClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPaidClosingCost() => !SellerPaidClosingCost.Clean;
        public Value<DateTime?> ServingTransferedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServingTransferedDate() => !ServingTransferedDate.Clean;
        public Value<decimal?> SpecialAssessments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialAssessments() => !SpecialAssessments.Clean;
        public Value<string> SponsorAgentAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentAddress() => !SponsorAgentAddress.Clean;
        public Value<string> SponsorAgentCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentCity() => !SponsorAgentCity.Clean;
        public Value<string> SponsorAgentName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentName() => !SponsorAgentName.Clean;
        public Value<string> SponsorAgentNMLS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentNMLS() => !SponsorAgentNMLS.Clean;
        public Value<string> SponsorAgentPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentPostalCode() => !SponsorAgentPostalCode.Clean;
        public Value<string> SponsorAgentState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentState() => !SponsorAgentState.Clean;
        public Value<string> SponsorAgentTaxID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorAgentTaxID() => !SponsorAgentTaxID.Clean;
        public Value<string> SponsoredOriginationsName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsoredOriginationsName() => !SponsoredOriginationsName.Clean;
        public Value<string> SponsoredOriginationsNMLS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsoredOriginationsNMLS() => !SponsoredOriginationsNMLS.Clean;
        public Value<string> SponsoredOriginationsTaxID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsoredOriginationsTaxID() => !SponsoredOriginationsTaxID.Clean;
        public Value<string> SponsorID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSponsorID() => !SponsorID.Clean;
        public Value<string> TitleVestedIn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleVestedIn() => !TitleVestedIn.Clean;
        public Value<bool?> ToBeSold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeToBeSold() => !ToBeSold.Clean;
        public Value<decimal?> TotalClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCost() => !TotalClosingCost.Clean;
        public Value<string> TotalScorecardBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalScorecardBy() => !TotalScorecardBy.Clean;
        public Value<DateTime?> TotalScorecardDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalScorecardDate() => !TotalScorecardDate.Clean;
        public Value<DateTime?> UFMIPRemittanceDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUFMIPRemittanceDueDate() => !UFMIPRemittanceDueDate.Clean;
        public Value<decimal?> UFMIPRemittedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUFMIPRemittedAmount() => !UFMIPRemittedAmount.Clean;
        public Value<string> UFMIPRemittedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUFMIPRemittedBy() => !UFMIPRemittedBy.Clean;
        public Value<DateTime?> UFMIPRemittedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUFMIPRemittedDate() => !UFMIPRemittedDate.Clean;
        public Value<string> UFMIPVerificationCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUFMIPVerificationCode() => !UFMIPVerificationCode.Clean;
        public Value<bool?> UseDefaultLenderInfo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseDefaultLenderInfo() => !UseDefaultLenderInfo.Clean;
        public Value<bool?> UtilityIncluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilityIncluded() => !UtilityIncluded.Clean;
        public Value<DateTime?> ValidateAddressDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValidateAddressDate() => !ValidateAddressDate.Clean;
        public Value<string> Valuation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValuation() => !Valuation.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AddendumType.Clean
                    && AdditionalCondition1.Clean
                    && AdditionalCondition2.Clean
                    && AdditionalCondition3.Clean
                    && AdditionalCondition4.Clean
                    && AdditionalCondition5.Clean
                    && AdditionalCondition6.Clean
                    && AdditionalCondition7.Clean
                    && AdditionalCondition8.Clean
                    && AdditionalCondition9.Clean
                    && AddressValidatedBy.Clean
                    && AddressValidationMessage.Clean
                    && AllConditionsSatisfied.Clean
                    && AppraisalLoggedDate.Clean
                    && AppraisalLookupBy.Clean
                    && BeenInformed.Clean
                    && BorrowerCertificationAddress.Clean
                    && BorrowerCertificationCity.Clean
                    && BorrowerCertificationPostalCode.Clean
                    && BorrowerCertificationState.Clean
                    && CAIVRSObtainedBy.Clean
                    && CaseBinderShippedBy.Clean
                    && CaseBinderShippedDate.Clean
                    && ClosingDate.Clean
                    && CondoPudID.Clean
                    && CondoPudLookupBy.Clean
                    && CondoPudLookupDate.Clean
                    && DateApprovalExpires.Clean
                    && DateMortgageApproved.Clean
                    && DetailForOther.Clean
                    && DiscountPoints.Clean
                    && DulyAgentAddress.Clean
                    && DulyAgentCity.Clean
                    && DulyAgentFunction1.Clean
                    && DulyAgentFunction2.Clean
                    && DulyAgentName.Clean
                    && DulyAgentState.Clean
                    && DwellingCoveredBy.Clean
                    && EligibilityAssessment.Clean
                    && EnergyEfficientMortgageAmount.Clean
                    && EnergyEfficientMortgageItems.Clean
                    && EverHadVAHomeLoan.Clean
                    && ExcessContributionAmount.Clean
                    && ExistingDebtAmount.Clean
                    && FHACaseOrderedBy.Clean
                    && FHAManagementCounselType.Clean
                    && FHAMaxLoanAmount.Clean
                    && ForeclosedProperty.Clean
                    && FreddieMacCounselType.Clean
                    && FundingFeePaidInCash.Clean
                    && GiftFundsAmount.Clean
                    && HaveReceivedLeadPaintPoisoningInfo.Clean
                    && HUD1003AddendumApproved.Clean
                    && Id.Clean
                    && LastRefiDate.Clean
                    && LDPGSASearchDate.Clean
                    && LDPGSASearchedBy.Clean
                    && LenderAddress.Clean
                    && LenderCity.Clean
                    && LenderName.Clean
                    && LenderNMLS.Clean
                    && LenderPostalCode.Clean
                    && LenderRepresentativeName.Clean
                    && LenderRepresentativePhone.Clean
                    && LenderRepresentativeTitle.Clean
                    && LenderState.Clean
                    && LenderTaxID.Clean
                    && LoanScoreID.Clean
                    && MIAppliedBy.Clean
                    && MIAppliedDate.Clean
                    && MICRetrivedDate.Clean
                    && MinimumDownPayment.Clean
                    && MIP1stDueDate.Clean
                    && MIP1stToInvestor.Clean
                    && MIPRemittedDate.Clean
                    && MIRejectedDate.Clean
                    && ModifiedInterestRate.Clean
                    && ModifiedLoanAmount.Clean
                    && ModifiedMonthlyPayment.Clean
                    && ModifiedMonthlyPremium.Clean
                    && ModifiedProposedMaturityMonth.Clean
                    && ModifiedProposedMaturityYear.Clean
                    && ModifiedTermAnnualPremium.Clean
                    && ModifiedUpfrontPremium.Clean
                    && MortgageeRepresentative.Clean
                    && MortgageFinancialInterest.Clean
                    && NonRealtyAndOtherItems.Clean
                    && ObtainCAIVRSDate.Clean
                    && Occupancy.Clean
                    && OldAgencyCaseIdentifier.Clean
                    && OriginalMortgageAmount.Clean
                    && OtherLiabilitiesMonthlyPayment.Clean
                    && OtherLiabilitiesUnpaidBalance.Clean
                    && OtherMonthlyShelterExpense.Clean
                    && OtherTitleDescription.Clean
                    && OwnMoreThanFourDwellings.Clean
                    && OwnOrSoldOtherRealEstate.Clean
                    && PaidAmount.Clean
                    && PremiumMonths.Clean
                    && PrepaidExpenses.Clean
                    && PreviousPurchaseDate.Clean
                    && PriorEndorsementDate.Clean
                    && ProposedMaturityMonths.Clean
                    && ProposedMaturityYears.Clean
                    && PurposeOfLoan.Clean
                    && RefiAuthorizationBy.Clean
                    && RefiAuthorizationDate.Clean
                    && SalesPrice.Clean
                    && SecondMortgageAmount.Clean
                    && SellerPaidClosingCost.Clean
                    && ServingTransferedDate.Clean
                    && SpecialAssessments.Clean
                    && SponsorAgentAddress.Clean
                    && SponsorAgentCity.Clean
                    && SponsorAgentName.Clean
                    && SponsorAgentNMLS.Clean
                    && SponsorAgentPostalCode.Clean
                    && SponsorAgentState.Clean
                    && SponsorAgentTaxID.Clean
                    && SponsoredOriginationsName.Clean
                    && SponsoredOriginationsNMLS.Clean
                    && SponsoredOriginationsTaxID.Clean
                    && SponsorID.Clean
                    && TitleVestedIn.Clean
                    && ToBeSold.Clean
                    && TotalClosingCost.Clean
                    && TotalScorecardBy.Clean
                    && TotalScorecardDate.Clean
                    && UFMIPRemittanceDueDate.Clean
                    && UFMIPRemittedAmount.Clean
                    && UFMIPRemittedBy.Clean
                    && UFMIPRemittedDate.Clean
                    && UFMIPVerificationCode.Clean
                    && UseDefaultLenderInfo.Clean
                    && UtilityIncluded.Clean
                    && ValidateAddressDate.Clean
                    && Valuation.Clean
                    && Eem.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AddendumType; v0.Clean = value; AddendumType = v0;
                var v1 = AdditionalCondition1; v1.Clean = value; AdditionalCondition1 = v1;
                var v2 = AdditionalCondition2; v2.Clean = value; AdditionalCondition2 = v2;
                var v3 = AdditionalCondition3; v3.Clean = value; AdditionalCondition3 = v3;
                var v4 = AdditionalCondition4; v4.Clean = value; AdditionalCondition4 = v4;
                var v5 = AdditionalCondition5; v5.Clean = value; AdditionalCondition5 = v5;
                var v6 = AdditionalCondition6; v6.Clean = value; AdditionalCondition6 = v6;
                var v7 = AdditionalCondition7; v7.Clean = value; AdditionalCondition7 = v7;
                var v8 = AdditionalCondition8; v8.Clean = value; AdditionalCondition8 = v8;
                var v9 = AdditionalCondition9; v9.Clean = value; AdditionalCondition9 = v9;
                var v10 = AddressValidatedBy; v10.Clean = value; AddressValidatedBy = v10;
                var v11 = AddressValidationMessage; v11.Clean = value; AddressValidationMessage = v11;
                var v12 = AllConditionsSatisfied; v12.Clean = value; AllConditionsSatisfied = v12;
                var v13 = AppraisalLoggedDate; v13.Clean = value; AppraisalLoggedDate = v13;
                var v14 = AppraisalLookupBy; v14.Clean = value; AppraisalLookupBy = v14;
                var v15 = BeenInformed; v15.Clean = value; BeenInformed = v15;
                var v16 = BorrowerCertificationAddress; v16.Clean = value; BorrowerCertificationAddress = v16;
                var v17 = BorrowerCertificationCity; v17.Clean = value; BorrowerCertificationCity = v17;
                var v18 = BorrowerCertificationPostalCode; v18.Clean = value; BorrowerCertificationPostalCode = v18;
                var v19 = BorrowerCertificationState; v19.Clean = value; BorrowerCertificationState = v19;
                var v20 = CAIVRSObtainedBy; v20.Clean = value; CAIVRSObtainedBy = v20;
                var v21 = CaseBinderShippedBy; v21.Clean = value; CaseBinderShippedBy = v21;
                var v22 = CaseBinderShippedDate; v22.Clean = value; CaseBinderShippedDate = v22;
                var v23 = ClosingDate; v23.Clean = value; ClosingDate = v23;
                var v24 = CondoPudID; v24.Clean = value; CondoPudID = v24;
                var v25 = CondoPudLookupBy; v25.Clean = value; CondoPudLookupBy = v25;
                var v26 = CondoPudLookupDate; v26.Clean = value; CondoPudLookupDate = v26;
                var v27 = DateApprovalExpires; v27.Clean = value; DateApprovalExpires = v27;
                var v28 = DateMortgageApproved; v28.Clean = value; DateMortgageApproved = v28;
                var v29 = DetailForOther; v29.Clean = value; DetailForOther = v29;
                var v30 = DiscountPoints; v30.Clean = value; DiscountPoints = v30;
                var v31 = DulyAgentAddress; v31.Clean = value; DulyAgentAddress = v31;
                var v32 = DulyAgentCity; v32.Clean = value; DulyAgentCity = v32;
                var v33 = DulyAgentFunction1; v33.Clean = value; DulyAgentFunction1 = v33;
                var v34 = DulyAgentFunction2; v34.Clean = value; DulyAgentFunction2 = v34;
                var v35 = DulyAgentName; v35.Clean = value; DulyAgentName = v35;
                var v36 = DulyAgentState; v36.Clean = value; DulyAgentState = v36;
                var v37 = DwellingCoveredBy; v37.Clean = value; DwellingCoveredBy = v37;
                var v38 = EligibilityAssessment; v38.Clean = value; EligibilityAssessment = v38;
                var v39 = EnergyEfficientMortgageAmount; v39.Clean = value; EnergyEfficientMortgageAmount = v39;
                var v40 = EnergyEfficientMortgageItems; v40.Clean = value; EnergyEfficientMortgageItems = v40;
                var v41 = EverHadVAHomeLoan; v41.Clean = value; EverHadVAHomeLoan = v41;
                var v42 = ExcessContributionAmount; v42.Clean = value; ExcessContributionAmount = v42;
                var v43 = ExistingDebtAmount; v43.Clean = value; ExistingDebtAmount = v43;
                var v44 = FHACaseOrderedBy; v44.Clean = value; FHACaseOrderedBy = v44;
                var v45 = FHAManagementCounselType; v45.Clean = value; FHAManagementCounselType = v45;
                var v46 = FHAMaxLoanAmount; v46.Clean = value; FHAMaxLoanAmount = v46;
                var v47 = ForeclosedProperty; v47.Clean = value; ForeclosedProperty = v47;
                var v48 = FreddieMacCounselType; v48.Clean = value; FreddieMacCounselType = v48;
                var v49 = FundingFeePaidInCash; v49.Clean = value; FundingFeePaidInCash = v49;
                var v50 = GiftFundsAmount; v50.Clean = value; GiftFundsAmount = v50;
                var v51 = HaveReceivedLeadPaintPoisoningInfo; v51.Clean = value; HaveReceivedLeadPaintPoisoningInfo = v51;
                var v52 = HUD1003AddendumApproved; v52.Clean = value; HUD1003AddendumApproved = v52;
                var v53 = Id; v53.Clean = value; Id = v53;
                var v54 = LastRefiDate; v54.Clean = value; LastRefiDate = v54;
                var v55 = LDPGSASearchDate; v55.Clean = value; LDPGSASearchDate = v55;
                var v56 = LDPGSASearchedBy; v56.Clean = value; LDPGSASearchedBy = v56;
                var v57 = LenderAddress; v57.Clean = value; LenderAddress = v57;
                var v58 = LenderCity; v58.Clean = value; LenderCity = v58;
                var v59 = LenderName; v59.Clean = value; LenderName = v59;
                var v60 = LenderNMLS; v60.Clean = value; LenderNMLS = v60;
                var v61 = LenderPostalCode; v61.Clean = value; LenderPostalCode = v61;
                var v62 = LenderRepresentativeName; v62.Clean = value; LenderRepresentativeName = v62;
                var v63 = LenderRepresentativePhone; v63.Clean = value; LenderRepresentativePhone = v63;
                var v64 = LenderRepresentativeTitle; v64.Clean = value; LenderRepresentativeTitle = v64;
                var v65 = LenderState; v65.Clean = value; LenderState = v65;
                var v66 = LenderTaxID; v66.Clean = value; LenderTaxID = v66;
                var v67 = LoanScoreID; v67.Clean = value; LoanScoreID = v67;
                var v68 = MIAppliedBy; v68.Clean = value; MIAppliedBy = v68;
                var v69 = MIAppliedDate; v69.Clean = value; MIAppliedDate = v69;
                var v70 = MICRetrivedDate; v70.Clean = value; MICRetrivedDate = v70;
                var v71 = MinimumDownPayment; v71.Clean = value; MinimumDownPayment = v71;
                var v72 = MIP1stDueDate; v72.Clean = value; MIP1stDueDate = v72;
                var v73 = MIP1stToInvestor; v73.Clean = value; MIP1stToInvestor = v73;
                var v74 = MIPRemittedDate; v74.Clean = value; MIPRemittedDate = v74;
                var v75 = MIRejectedDate; v75.Clean = value; MIRejectedDate = v75;
                var v76 = ModifiedInterestRate; v76.Clean = value; ModifiedInterestRate = v76;
                var v77 = ModifiedLoanAmount; v77.Clean = value; ModifiedLoanAmount = v77;
                var v78 = ModifiedMonthlyPayment; v78.Clean = value; ModifiedMonthlyPayment = v78;
                var v79 = ModifiedMonthlyPremium; v79.Clean = value; ModifiedMonthlyPremium = v79;
                var v80 = ModifiedProposedMaturityMonth; v80.Clean = value; ModifiedProposedMaturityMonth = v80;
                var v81 = ModifiedProposedMaturityYear; v81.Clean = value; ModifiedProposedMaturityYear = v81;
                var v82 = ModifiedTermAnnualPremium; v82.Clean = value; ModifiedTermAnnualPremium = v82;
                var v83 = ModifiedUpfrontPremium; v83.Clean = value; ModifiedUpfrontPremium = v83;
                var v84 = MortgageeRepresentative; v84.Clean = value; MortgageeRepresentative = v84;
                var v85 = MortgageFinancialInterest; v85.Clean = value; MortgageFinancialInterest = v85;
                var v86 = NonRealtyAndOtherItems; v86.Clean = value; NonRealtyAndOtherItems = v86;
                var v87 = ObtainCAIVRSDate; v87.Clean = value; ObtainCAIVRSDate = v87;
                var v88 = Occupancy; v88.Clean = value; Occupancy = v88;
                var v89 = OldAgencyCaseIdentifier; v89.Clean = value; OldAgencyCaseIdentifier = v89;
                var v90 = OriginalMortgageAmount; v90.Clean = value; OriginalMortgageAmount = v90;
                var v91 = OtherLiabilitiesMonthlyPayment; v91.Clean = value; OtherLiabilitiesMonthlyPayment = v91;
                var v92 = OtherLiabilitiesUnpaidBalance; v92.Clean = value; OtherLiabilitiesUnpaidBalance = v92;
                var v93 = OtherMonthlyShelterExpense; v93.Clean = value; OtherMonthlyShelterExpense = v93;
                var v94 = OtherTitleDescription; v94.Clean = value; OtherTitleDescription = v94;
                var v95 = OwnMoreThanFourDwellings; v95.Clean = value; OwnMoreThanFourDwellings = v95;
                var v96 = OwnOrSoldOtherRealEstate; v96.Clean = value; OwnOrSoldOtherRealEstate = v96;
                var v97 = PaidAmount; v97.Clean = value; PaidAmount = v97;
                var v98 = PremiumMonths; v98.Clean = value; PremiumMonths = v98;
                var v99 = PrepaidExpenses; v99.Clean = value; PrepaidExpenses = v99;
                var v100 = PreviousPurchaseDate; v100.Clean = value; PreviousPurchaseDate = v100;
                var v101 = PriorEndorsementDate; v101.Clean = value; PriorEndorsementDate = v101;
                var v102 = ProposedMaturityMonths; v102.Clean = value; ProposedMaturityMonths = v102;
                var v103 = ProposedMaturityYears; v103.Clean = value; ProposedMaturityYears = v103;
                var v104 = PurposeOfLoan; v104.Clean = value; PurposeOfLoan = v104;
                var v105 = RefiAuthorizationBy; v105.Clean = value; RefiAuthorizationBy = v105;
                var v106 = RefiAuthorizationDate; v106.Clean = value; RefiAuthorizationDate = v106;
                var v107 = SalesPrice; v107.Clean = value; SalesPrice = v107;
                var v108 = SecondMortgageAmount; v108.Clean = value; SecondMortgageAmount = v108;
                var v109 = SellerPaidClosingCost; v109.Clean = value; SellerPaidClosingCost = v109;
                var v110 = ServingTransferedDate; v110.Clean = value; ServingTransferedDate = v110;
                var v111 = SpecialAssessments; v111.Clean = value; SpecialAssessments = v111;
                var v112 = SponsorAgentAddress; v112.Clean = value; SponsorAgentAddress = v112;
                var v113 = SponsorAgentCity; v113.Clean = value; SponsorAgentCity = v113;
                var v114 = SponsorAgentName; v114.Clean = value; SponsorAgentName = v114;
                var v115 = SponsorAgentNMLS; v115.Clean = value; SponsorAgentNMLS = v115;
                var v116 = SponsorAgentPostalCode; v116.Clean = value; SponsorAgentPostalCode = v116;
                var v117 = SponsorAgentState; v117.Clean = value; SponsorAgentState = v117;
                var v118 = SponsorAgentTaxID; v118.Clean = value; SponsorAgentTaxID = v118;
                var v119 = SponsoredOriginationsName; v119.Clean = value; SponsoredOriginationsName = v119;
                var v120 = SponsoredOriginationsNMLS; v120.Clean = value; SponsoredOriginationsNMLS = v120;
                var v121 = SponsoredOriginationsTaxID; v121.Clean = value; SponsoredOriginationsTaxID = v121;
                var v122 = SponsorID; v122.Clean = value; SponsorID = v122;
                var v123 = TitleVestedIn; v123.Clean = value; TitleVestedIn = v123;
                var v124 = ToBeSold; v124.Clean = value; ToBeSold = v124;
                var v125 = TotalClosingCost; v125.Clean = value; TotalClosingCost = v125;
                var v126 = TotalScorecardBy; v126.Clean = value; TotalScorecardBy = v126;
                var v127 = TotalScorecardDate; v127.Clean = value; TotalScorecardDate = v127;
                var v128 = UFMIPRemittanceDueDate; v128.Clean = value; UFMIPRemittanceDueDate = v128;
                var v129 = UFMIPRemittedAmount; v129.Clean = value; UFMIPRemittedAmount = v129;
                var v130 = UFMIPRemittedBy; v130.Clean = value; UFMIPRemittedBy = v130;
                var v131 = UFMIPRemittedDate; v131.Clean = value; UFMIPRemittedDate = v131;
                var v132 = UFMIPVerificationCode; v132.Clean = value; UFMIPVerificationCode = v132;
                var v133 = UseDefaultLenderInfo; v133.Clean = value; UseDefaultLenderInfo = v133;
                var v134 = UtilityIncluded; v134.Clean = value; UtilityIncluded = v134;
                var v135 = ValidateAddressDate; v135.Clean = value; ValidateAddressDate = v135;
                var v136 = Valuation; v136.Clean = value; Valuation = v136;
                if (Eem != null) Eem.Clean = value;
                _settingClean = 0;
            }
        }
    }
}