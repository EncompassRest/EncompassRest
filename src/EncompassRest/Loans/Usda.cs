using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Usda
    {
        public Value<decimal?> AdditionalIncomeFromPrimaryEmployment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalIncomeFromPrimaryEmployment() => !AdditionalIncomeFromPrimaryEmployment.Clean;
        public Value<decimal?> AdditionalMemberBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalMemberBaseIncome() => !AdditionalMemberBaseIncome.Clean;
        public Value<decimal?> AdjustedAnnualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedAnnualIncome() => !AdjustedAnnualIncome.Clean;
        public Value<string> AdjustedIncomeCalculationDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription1() => !AdjustedIncomeCalculationDescription1.Clean;
        public Value<string> AdjustedIncomeCalculationDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription2() => !AdjustedIncomeCalculationDescription2.Clean;
        public Value<string> AdjustedIncomeCalculationDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription3() => !AdjustedIncomeCalculationDescription3.Clean;
        public Value<decimal?> AdvanceAmountToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvanceAmountToDate() => !AdvanceAmountToDate.Clean;
        public Value<decimal?> AmountLoanlineCredit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountLoanlineCredit() => !AmountLoanlineCredit.Clean;
        public Value<decimal?> AnnualChildCareExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualChildCareExpenses() => !AnnualChildCareExpenses.Clean;
        public Value<decimal?> AnnualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncome() => !AnnualIncome.Clean;
        public Value<string> AnnualIncomeCalculationDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription1() => !AnnualIncomeCalculationDescription1.Clean;
        public Value<string> AnnualIncomeCalculationDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription2() => !AnnualIncomeCalculationDescription2.Clean;
        public Value<string> AnnualIncomeCalculationDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription3() => !AnnualIncomeCalculationDescription3.Clean;
        public Value<string> AnnualIncomeCalculationDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription4() => !AnnualIncomeCalculationDescription4.Clean;
        public Value<string> AnnualIncomeCalculationDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription5() => !AnnualIncomeCalculationDescription5.Clean;
        public Value<DateTime?> AnnualReviewDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualReviewDate() => !AnnualReviewDate.Clean;
        public Value<string> ApplicationNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationNumber() => !ApplicationNumber.Clean;
        public Value<string> ApprovedLenderTaxId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovedLenderTaxId() => !ApprovedLenderTaxId.Clean;
        public Value<decimal?> AssetIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssetIncome() => !AssetIncome.Clean;
        public Value<decimal?> BalanceOwedOnLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalanceOwedOnLoan() => !BalanceOwedOnLoan.Clean;
        public Value<decimal?> BorrowerBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerBaseIncome() => !BorrowerBaseIncome.Clean;
        public Value<decimal?> BorrowerTotalStableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTotalStableIncome() => !BorrowerTotalStableIncome.Clean;
        public Value<string> BorrowerTypeCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTypeCode() => !BorrowerTypeCode.Clean;
        public Value<decimal?> BuydownInterestAssistanceRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownInterestAssistanceRate() => !BuydownInterestAssistanceRate.Clean;
        public Value<string> CaseNumberBorrowerId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberBorrowerId() => !CaseNumberBorrowerId.Clean;
        public Value<string> CaseNumberCo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberCo() => !CaseNumberCo.Clean;
        public Value<string> CaseNumberSt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberSt() => !CaseNumberSt.Clean;
        public Value<DateTime?> CertificationEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationEffectiveDate() => !CertificationEffectiveDate.Clean;
        public Value<DateTime?> CertificationExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationExpirationDate() => !CertificationExpirationDate.Clean;
        public Value<bool?> CertifiedLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertifiedLoanIndicator() => !CertifiedLoanIndicator.Clean;
        public Value<string> ChildCareProviderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderAddress() => !ChildCareProviderAddress.Clean;
        public Value<string> ChildCareProviderCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderCity() => !ChildCareProviderCity.Clean;
        public Value<string> ChildCareProviderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderPhone() => !ChildCareProviderPhone.Clean;
        public Value<string> ChildCareProviderProviderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderProviderName() => !ChildCareProviderProviderName.Clean;
        public Value<string> ChildCareProviderState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderState() => !ChildCareProviderState.Clean;
        public Value<string> ChildCareProviderZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderZip() => !ChildCareProviderZip.Clean;
        public Value<decimal?> ChildCostPerMonth { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCostPerMonth() => !ChildCostPerMonth.Clean;
        public Value<decimal?> ChildCostPerWeek { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCostPerWeek() => !ChildCostPerWeek.Clean;
        public Value<decimal?> CoborrowerBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerBaseIncome() => !CoborrowerBaseIncome.Clean;
        public Value<decimal?> CoborrowerStableBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableBaseIncome() => !CoborrowerStableBaseIncome.Clean;
        public Value<string> CoborrowerStableBaseIncomeDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableBaseIncomeDesc() => !CoborrowerStableBaseIncomeDesc.Clean;
        public Value<decimal?> CoborrowerStableOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableOtherIncome() => !CoborrowerStableOtherIncome.Clean;
        public Value<string> CoborrowerStableOtherIncomeDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableOtherIncomeDesc() => !CoborrowerStableOtherIncomeDesc.Clean;
        public Value<decimal?> CoBorrowerTotalStableIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerTotalStableIncome() => !CoBorrowerTotalStableIncome.Clean;
        public Value<DateTime?> DateConfirmedObligationProcessed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateConfirmedObligationProcessed() => !DateConfirmedObligationProcessed.Clean;
        public Value<DateTime?> DateLoanNoteGuaranteeIssued { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLoanNoteGuaranteeIssued() => !DateLoanNoteGuaranteeIssued.Clean;
        public Value<DateTime?> DateLoanNoteGuaranteeRequestReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLoanNoteGuaranteeRequestReceived() => !DateLoanNoteGuaranteeRequestReceived.Clean;
        public Value<DateTime?> DateObligationInGls { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateObligationInGls() => !DateObligationInGls.Clean;
        public Value<DateTime?> DateVerifiedInUnifi { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateVerifiedInUnifi() => !DateVerifiedInUnifi.Clean;
        public Value<decimal?> DependentDeduction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDependentDeduction() => !DependentDeduction.Clean;
        public Value<decimal?> DisabilityDeduction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabilityDeduction() => !DisabilityDeduction.Clean;
        public Value<decimal?> ElderlyHouseholdDeduction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeElderlyHouseholdDeduction() => !ElderlyHouseholdDeduction.Clean;
        public Value<decimal?> FeeRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeRate() => !FeeRate.Clean;
        public Value<string> FinancedLoanClosingCostDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedLoanClosingCostDescription() => !FinancedLoanClosingCostDescription.Clean;
        public Value<decimal?> GuaranteeFeeCollected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeCollected() => !GuaranteeFeeCollected.Clean;
        public Value<decimal?> GuaranteeFeeOnCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeOnCommitment() => !GuaranteeFeeOnCommitment.Clean;
        public Value<string> GuaranteeFeePurposeCodeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeePurposeCodeType() => !GuaranteeFeePurposeCodeType.Clean;
        public Value<DateTime?> GuaranteePeriodBeginsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteePeriodBeginsDate() => !GuaranteePeriodBeginsDate.Clean;
        public Value<DateTime?> GuaranteePeriodEndsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteePeriodEndsDate() => !GuaranteePeriodEndsDate.Clean;
        public Value<string> GuaranteeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeType() => !GuaranteeType.Clean;
        public Value<int?> HouseholdSize { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHouseholdSize() => !HouseholdSize.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InterestAssistanceCodeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAssistanceCodeType() => !InterestAssistanceCodeType.Clean;
        public Value<bool?> InterestRateBasedonFannieIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateBasedonFannieIndicator() => !InterestRateBasedonFannieIndicator.Clean;
        public Value<string> InterestRateCodeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateCodeType() => !InterestRateCodeType.Clean;
        public Value<bool?> InterestRateFloatToLoanClosingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateFloatToLoanClosingIndicator() => !InterestRateFloatToLoanClosingIndicator.Clean;
        public Value<bool?> LackAdequateHeatIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLackAdequateHeatIndicator() => !LackAdequateHeatIndicator.Clean;
        public Value<string> LenderAuthorizedRepCompany { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepCompany() => !LenderAuthorizedRepCompany.Clean;
        public Value<string> LenderAuthorizedRepName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepName() => !LenderAuthorizedRepName.Clean;
        public Value<string> LenderAuthorizedRepTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepTitle() => !LenderAuthorizedRepTitle.Clean;
        public Value<string> LenderIdNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderIdNo() => !LenderIdNo.Clean;
        public Value<decimal?> LenderNoteRateOnGuaranteedPortion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNoteRateOnGuaranteedPortion() => !LenderNoteRateOnGuaranteedPortion.Clean;
        public Value<decimal?> LenderNoteRateOnNonGuaranteedPortion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNoteRateOnNonGuaranteedPortion() => !LenderNoteRateOnNonGuaranteedPortion.Clean;
        public Value<string> LenderStatusCodeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderStatusCodeType() => !LenderStatusCodeType.Clean;
        public Value<string> LenderTypeCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderTypeCode() => !LenderTypeCode.Clean;
        public Value<string> LoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !LoanType.Clean;
        public Value<bool?> LockCompletePlumbingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockCompletePlumbingIndicator() => !LockCompletePlumbingIndicator.Clean;
        public Value<decimal?> MedicalExpenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMedicalExpenses() => !MedicalExpenses.Clean;
        public Value<decimal?> ModerateIncomeLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModerateIncomeLimit() => !ModerateIncomeLimit.Clean;
        public Value<decimal?> MonthlyRepaymentIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyRepaymentIncome() => !MonthlyRepaymentIncome.Clean;
        public Value<int?> NumberofDependents { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberofDependents() => !NumberofDependents.Clean;
        public Value<int?> NumberofPeopleInHousehold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberofPeopleInHousehold() => !NumberofPeopleInHousehold.Clean;
        public Value<bool?> ObligationMatchesCommitmentLenderRequestIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObligationMatchesCommitmentLenderRequestIndicator() => !ObligationMatchesCommitmentLenderRequestIndicator.Clean;
        public Value<string> OfficialWhoConfirmedGlsUpdated { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficialWhoConfirmedGlsUpdated() => !OfficialWhoConfirmedGlsUpdated.Clean;
        public Value<decimal?> OtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIncome() => !OtherIncome.Clean;
        public Value<decimal?> OtherStableDependableMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherStableDependableMonthlyIncome() => !OtherStableDependableMonthlyIncome.Clean;
        public Value<bool?> OvercrowdedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOvercrowdedIndicator() => !OvercrowdedIndicator.Clean;
        public Value<decimal?> PercentofLoanGuaranteed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentofLoanGuaranteed() => !PercentofLoanGuaranteed.Clean;
        public Value<string> PeriodOperatingLineCreditYearsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePeriodOperatingLineCreditYearsType() => !PeriodOperatingLineCreditYearsType.Clean;
        public Value<bool?> PhysicallyDeterioratedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhysicallyDeterioratedIndicator() => !PhysicallyDeterioratedIndicator.Clean;
        public Value<string> PreparedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreparedByName() => !PreparedByName.Clean;
        public Value<string> PreparedByTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreparedByTitle() => !PreparedByTitle.Clean;
        public Value<string> PresentLandloardAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardAddress() => !PresentLandloardAddress.Clean;
        public Value<string> PresentLandloardCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardCity() => !PresentLandloardCity.Clean;
        public Value<string> PresentLandloardName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardName() => !PresentLandloardName.Clean;
        public Value<string> PresentLandloardPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardPhone() => !PresentLandloardPhone.Clean;
        public Value<string> PresentLandloardState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardState() => !PresentLandloardState.Clean;
        public Value<string> PresentLandloardZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardZip() => !PresentLandloardZip.Clean;
        public Value<string> PreviousLandloardAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardAddress() => !PreviousLandloardAddress.Clean;
        public Value<string> PreviousLandloardCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardCity() => !PreviousLandloardCity.Clean;
        public Value<string> PreviousLandloardName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardName() => !PreviousLandloardName.Clean;
        public Value<string> PreviousLandloardPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardPhone() => !PreviousLandloardPhone.Clean;
        public Value<string> PreviousLandloardState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardState() => !PreviousLandloardState.Clean;
        public Value<string> PreviousLandloardZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardZip() => !PreviousLandloardZip.Clean;
        public Value<decimal?> PurchaseOrRefinancedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseOrRefinancedAmount() => !PurchaseOrRefinancedAmount.Clean;
        public Value<string> PurchaseOrRefinanceDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseOrRefinanceDescription() => !PurchaseOrRefinanceDescription.Clean;
        public Value<string> RdsfhRefinancedLoanIndicatorType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRdsfhRefinancedLoanIndicatorType() => !RdsfhRefinancedLoanIndicatorType.Clean;
        public Value<bool?> RefinanceLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceLoanIndicator() => !RefinanceLoanIndicator.Clean;
        public Value<decimal?> RepairOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairOtherAmount() => !RepairOtherAmount.Clean;
        public Value<string> RepairOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairOtherDescription() => !RepairOtherDescription.Clean;
        public Value<decimal?> ReservationAmountRequested { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReservationAmountRequested() => !ReservationAmountRequested.Clean;
        public Value<string> Reserved { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReserved() => !Reserved.Clean;
        public Value<string> ServicingOfficeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingOfficeName() => !ServicingOfficeName.Clean;
        public Value<bool?> SfhglpIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSfhglpIndicator() => !SfhglpIndicator.Clean;
        public Value<string> SourceOfFundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceOfFundsType() => !SourceOfFundsType.Clean;
        public Value<decimal?> StableDependableMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStableDependableMonthlyIncome() => !StableDependableMonthlyIncome.Clean;
        public Value<string> StableOtherIncomeDesc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStableOtherIncomeDesc() => !StableOtherIncomeDesc.Clean;
        public Value<string> SubmittingLenderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderAddress() => !SubmittingLenderAddress.Clean;
        public Value<string> SubmittingLenderCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderCity() => !SubmittingLenderCity.Clean;
        public Value<string> SubmittingLenderContactFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactFax() => !SubmittingLenderContactFax.Clean;
        public Value<string> SubmittingLenderContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactName() => !SubmittingLenderContactName.Clean;
        public Value<string> SubmittingLenderContactPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactPhone() => !SubmittingLenderContactPhone.Clean;
        public Value<string> SubmittingLenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderName() => !SubmittingLenderName.Clean;
        public Value<string> SubmittingLenderState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderState() => !SubmittingLenderState.Clean;
        public Value<string> SubmittingLenderTaxId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderTaxId() => !SubmittingLenderTaxId.Clean;
        public Value<string> SubmittingLenderZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderZip() => !SubmittingLenderZip.Clean;
        public Value<int?> TermOfBuydown { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermOfBuydown() => !TermOfBuydown.Clean;
        public Value<string> ThirdPartyOriginator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyOriginator() => !ThirdPartyOriginator.Clean;
        public Value<string> Title { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !Title.Clean;
        public Value<decimal?> TotalBorrowerStableBaseIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerStableBaseIncome() => !TotalBorrowerStableBaseIncome.Clean;
        public Value<decimal?> TotalBorrowerStableOtherIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerStableOtherIncome() => !TotalBorrowerStableOtherIncome.Clean;
        public Value<decimal?> TotalHouseholdDeduction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHouseholdDeduction() => !TotalHouseholdDeduction.Clean;
        public Value<decimal?> TotalRequestAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRequestAmount() => !TotalRequestAmount.Clean;
        public Value<string> TpoTaxId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTpoTaxId() => !TpoTaxId.Clean;
        public Value<string> UnderwritingDecisionBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionBy() => !UnderwritingDecisionBy.Clean;
        public Value<DateTime?> UnderwritingDecisionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionDate() => !UnderwritingDecisionDate.Clean;
        public Value<string> UnderwritingDecisionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionType() => !UnderwritingDecisionType.Clean;
        public Value<List<UsdaHouseholdIncome>> UsdaHouseholdIncomes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaHouseholdIncomes() => !UsdaHouseholdIncomes.Clean;
        public Value<string> VerificationCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationCode() => !VerificationCode.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalIncomeFromPrimaryEmployment.Clean
                    && AdditionalMemberBaseIncome.Clean
                    && AdjustedAnnualIncome.Clean
                    && AdjustedIncomeCalculationDescription1.Clean
                    && AdjustedIncomeCalculationDescription2.Clean
                    && AdjustedIncomeCalculationDescription3.Clean
                    && AdvanceAmountToDate.Clean
                    && AmountLoanlineCredit.Clean
                    && AnnualChildCareExpenses.Clean
                    && AnnualIncome.Clean
                    && AnnualIncomeCalculationDescription1.Clean
                    && AnnualIncomeCalculationDescription2.Clean
                    && AnnualIncomeCalculationDescription3.Clean
                    && AnnualIncomeCalculationDescription4.Clean
                    && AnnualIncomeCalculationDescription5.Clean
                    && AnnualReviewDate.Clean
                    && ApplicationNumber.Clean
                    && ApprovedLenderTaxId.Clean
                    && AssetIncome.Clean
                    && BalanceOwedOnLoan.Clean
                    && BorrowerBaseIncome.Clean
                    && BorrowerTotalStableIncome.Clean
                    && BorrowerTypeCode.Clean
                    && BuydownInterestAssistanceRate.Clean
                    && CaseNumberBorrowerId.Clean
                    && CaseNumberCo.Clean
                    && CaseNumberSt.Clean
                    && CertificationEffectiveDate.Clean
                    && CertificationExpirationDate.Clean
                    && CertifiedLoanIndicator.Clean
                    && ChildCareProviderAddress.Clean
                    && ChildCareProviderCity.Clean
                    && ChildCareProviderPhone.Clean
                    && ChildCareProviderProviderName.Clean
                    && ChildCareProviderState.Clean
                    && ChildCareProviderZip.Clean
                    && ChildCostPerMonth.Clean
                    && ChildCostPerWeek.Clean
                    && CoborrowerBaseIncome.Clean
                    && CoborrowerStableBaseIncome.Clean
                    && CoborrowerStableBaseIncomeDesc.Clean
                    && CoborrowerStableOtherIncome.Clean
                    && CoborrowerStableOtherIncomeDesc.Clean
                    && CoBorrowerTotalStableIncome.Clean
                    && DateConfirmedObligationProcessed.Clean
                    && DateLoanNoteGuaranteeIssued.Clean
                    && DateLoanNoteGuaranteeRequestReceived.Clean
                    && DateObligationInGls.Clean
                    && DateVerifiedInUnifi.Clean
                    && DependentDeduction.Clean
                    && DisabilityDeduction.Clean
                    && ElderlyHouseholdDeduction.Clean
                    && FeeRate.Clean
                    && FinancedLoanClosingCostDescription.Clean
                    && GuaranteeFeeCollected.Clean
                    && GuaranteeFeeOnCommitment.Clean
                    && GuaranteeFeePurposeCodeType.Clean
                    && GuaranteePeriodBeginsDate.Clean
                    && GuaranteePeriodEndsDate.Clean
                    && GuaranteeType.Clean
                    && HouseholdSize.Clean
                    && Id.Clean
                    && InterestAssistanceCodeType.Clean
                    && InterestRateBasedonFannieIndicator.Clean
                    && InterestRateCodeType.Clean
                    && InterestRateFloatToLoanClosingIndicator.Clean
                    && LackAdequateHeatIndicator.Clean
                    && LenderAuthorizedRepCompany.Clean
                    && LenderAuthorizedRepName.Clean
                    && LenderAuthorizedRepTitle.Clean
                    && LenderIdNo.Clean
                    && LenderNoteRateOnGuaranteedPortion.Clean
                    && LenderNoteRateOnNonGuaranteedPortion.Clean
                    && LenderStatusCodeType.Clean
                    && LenderTypeCode.Clean
                    && LoanType.Clean
                    && LockCompletePlumbingIndicator.Clean
                    && MedicalExpenses.Clean
                    && ModerateIncomeLimit.Clean
                    && MonthlyRepaymentIncome.Clean
                    && NumberofDependents.Clean
                    && NumberofPeopleInHousehold.Clean
                    && ObligationMatchesCommitmentLenderRequestIndicator.Clean
                    && OfficialWhoConfirmedGlsUpdated.Clean
                    && OtherIncome.Clean
                    && OtherStableDependableMonthlyIncome.Clean
                    && OvercrowdedIndicator.Clean
                    && PercentofLoanGuaranteed.Clean
                    && PeriodOperatingLineCreditYearsType.Clean
                    && PhysicallyDeterioratedIndicator.Clean
                    && PreparedByName.Clean
                    && PreparedByTitle.Clean
                    && PresentLandloardAddress.Clean
                    && PresentLandloardCity.Clean
                    && PresentLandloardName.Clean
                    && PresentLandloardPhone.Clean
                    && PresentLandloardState.Clean
                    && PresentLandloardZip.Clean
                    && PreviousLandloardAddress.Clean
                    && PreviousLandloardCity.Clean
                    && PreviousLandloardName.Clean
                    && PreviousLandloardPhone.Clean
                    && PreviousLandloardState.Clean
                    && PreviousLandloardZip.Clean
                    && PurchaseOrRefinancedAmount.Clean
                    && PurchaseOrRefinanceDescription.Clean
                    && RdsfhRefinancedLoanIndicatorType.Clean
                    && RefinanceLoanIndicator.Clean
                    && RepairOtherAmount.Clean
                    && RepairOtherDescription.Clean
                    && ReservationAmountRequested.Clean
                    && Reserved.Clean
                    && ServicingOfficeName.Clean
                    && SfhglpIndicator.Clean
                    && SourceOfFundsType.Clean
                    && StableDependableMonthlyIncome.Clean
                    && StableOtherIncomeDesc.Clean
                    && SubmittingLenderAddress.Clean
                    && SubmittingLenderCity.Clean
                    && SubmittingLenderContactFax.Clean
                    && SubmittingLenderContactName.Clean
                    && SubmittingLenderContactPhone.Clean
                    && SubmittingLenderName.Clean
                    && SubmittingLenderState.Clean
                    && SubmittingLenderTaxId.Clean
                    && SubmittingLenderZip.Clean
                    && TermOfBuydown.Clean
                    && ThirdPartyOriginator.Clean
                    && Title.Clean
                    && TotalBorrowerStableBaseIncome.Clean
                    && TotalBorrowerStableOtherIncome.Clean
                    && TotalHouseholdDeduction.Clean
                    && TotalRequestAmount.Clean
                    && TpoTaxId.Clean
                    && UnderwritingDecisionBy.Clean
                    && UnderwritingDecisionDate.Clean
                    && UnderwritingDecisionType.Clean
                    && UsdaHouseholdIncomes.Clean
                    && VerificationCode.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalIncomeFromPrimaryEmployment; v0.Clean = value; AdditionalIncomeFromPrimaryEmployment = v0;
                var v1 = AdditionalMemberBaseIncome; v1.Clean = value; AdditionalMemberBaseIncome = v1;
                var v2 = AdjustedAnnualIncome; v2.Clean = value; AdjustedAnnualIncome = v2;
                var v3 = AdjustedIncomeCalculationDescription1; v3.Clean = value; AdjustedIncomeCalculationDescription1 = v3;
                var v4 = AdjustedIncomeCalculationDescription2; v4.Clean = value; AdjustedIncomeCalculationDescription2 = v4;
                var v5 = AdjustedIncomeCalculationDescription3; v5.Clean = value; AdjustedIncomeCalculationDescription3 = v5;
                var v6 = AdvanceAmountToDate; v6.Clean = value; AdvanceAmountToDate = v6;
                var v7 = AmountLoanlineCredit; v7.Clean = value; AmountLoanlineCredit = v7;
                var v8 = AnnualChildCareExpenses; v8.Clean = value; AnnualChildCareExpenses = v8;
                var v9 = AnnualIncome; v9.Clean = value; AnnualIncome = v9;
                var v10 = AnnualIncomeCalculationDescription1; v10.Clean = value; AnnualIncomeCalculationDescription1 = v10;
                var v11 = AnnualIncomeCalculationDescription2; v11.Clean = value; AnnualIncomeCalculationDescription2 = v11;
                var v12 = AnnualIncomeCalculationDescription3; v12.Clean = value; AnnualIncomeCalculationDescription3 = v12;
                var v13 = AnnualIncomeCalculationDescription4; v13.Clean = value; AnnualIncomeCalculationDescription4 = v13;
                var v14 = AnnualIncomeCalculationDescription5; v14.Clean = value; AnnualIncomeCalculationDescription5 = v14;
                var v15 = AnnualReviewDate; v15.Clean = value; AnnualReviewDate = v15;
                var v16 = ApplicationNumber; v16.Clean = value; ApplicationNumber = v16;
                var v17 = ApprovedLenderTaxId; v17.Clean = value; ApprovedLenderTaxId = v17;
                var v18 = AssetIncome; v18.Clean = value; AssetIncome = v18;
                var v19 = BalanceOwedOnLoan; v19.Clean = value; BalanceOwedOnLoan = v19;
                var v20 = BorrowerBaseIncome; v20.Clean = value; BorrowerBaseIncome = v20;
                var v21 = BorrowerTotalStableIncome; v21.Clean = value; BorrowerTotalStableIncome = v21;
                var v22 = BorrowerTypeCode; v22.Clean = value; BorrowerTypeCode = v22;
                var v23 = BuydownInterestAssistanceRate; v23.Clean = value; BuydownInterestAssistanceRate = v23;
                var v24 = CaseNumberBorrowerId; v24.Clean = value; CaseNumberBorrowerId = v24;
                var v25 = CaseNumberCo; v25.Clean = value; CaseNumberCo = v25;
                var v26 = CaseNumberSt; v26.Clean = value; CaseNumberSt = v26;
                var v27 = CertificationEffectiveDate; v27.Clean = value; CertificationEffectiveDate = v27;
                var v28 = CertificationExpirationDate; v28.Clean = value; CertificationExpirationDate = v28;
                var v29 = CertifiedLoanIndicator; v29.Clean = value; CertifiedLoanIndicator = v29;
                var v30 = ChildCareProviderAddress; v30.Clean = value; ChildCareProviderAddress = v30;
                var v31 = ChildCareProviderCity; v31.Clean = value; ChildCareProviderCity = v31;
                var v32 = ChildCareProviderPhone; v32.Clean = value; ChildCareProviderPhone = v32;
                var v33 = ChildCareProviderProviderName; v33.Clean = value; ChildCareProviderProviderName = v33;
                var v34 = ChildCareProviderState; v34.Clean = value; ChildCareProviderState = v34;
                var v35 = ChildCareProviderZip; v35.Clean = value; ChildCareProviderZip = v35;
                var v36 = ChildCostPerMonth; v36.Clean = value; ChildCostPerMonth = v36;
                var v37 = ChildCostPerWeek; v37.Clean = value; ChildCostPerWeek = v37;
                var v38 = CoborrowerBaseIncome; v38.Clean = value; CoborrowerBaseIncome = v38;
                var v39 = CoborrowerStableBaseIncome; v39.Clean = value; CoborrowerStableBaseIncome = v39;
                var v40 = CoborrowerStableBaseIncomeDesc; v40.Clean = value; CoborrowerStableBaseIncomeDesc = v40;
                var v41 = CoborrowerStableOtherIncome; v41.Clean = value; CoborrowerStableOtherIncome = v41;
                var v42 = CoborrowerStableOtherIncomeDesc; v42.Clean = value; CoborrowerStableOtherIncomeDesc = v42;
                var v43 = CoBorrowerTotalStableIncome; v43.Clean = value; CoBorrowerTotalStableIncome = v43;
                var v44 = DateConfirmedObligationProcessed; v44.Clean = value; DateConfirmedObligationProcessed = v44;
                var v45 = DateLoanNoteGuaranteeIssued; v45.Clean = value; DateLoanNoteGuaranteeIssued = v45;
                var v46 = DateLoanNoteGuaranteeRequestReceived; v46.Clean = value; DateLoanNoteGuaranteeRequestReceived = v46;
                var v47 = DateObligationInGls; v47.Clean = value; DateObligationInGls = v47;
                var v48 = DateVerifiedInUnifi; v48.Clean = value; DateVerifiedInUnifi = v48;
                var v49 = DependentDeduction; v49.Clean = value; DependentDeduction = v49;
                var v50 = DisabilityDeduction; v50.Clean = value; DisabilityDeduction = v50;
                var v51 = ElderlyHouseholdDeduction; v51.Clean = value; ElderlyHouseholdDeduction = v51;
                var v52 = FeeRate; v52.Clean = value; FeeRate = v52;
                var v53 = FinancedLoanClosingCostDescription; v53.Clean = value; FinancedLoanClosingCostDescription = v53;
                var v54 = GuaranteeFeeCollected; v54.Clean = value; GuaranteeFeeCollected = v54;
                var v55 = GuaranteeFeeOnCommitment; v55.Clean = value; GuaranteeFeeOnCommitment = v55;
                var v56 = GuaranteeFeePurposeCodeType; v56.Clean = value; GuaranteeFeePurposeCodeType = v56;
                var v57 = GuaranteePeriodBeginsDate; v57.Clean = value; GuaranteePeriodBeginsDate = v57;
                var v58 = GuaranteePeriodEndsDate; v58.Clean = value; GuaranteePeriodEndsDate = v58;
                var v59 = GuaranteeType; v59.Clean = value; GuaranteeType = v59;
                var v60 = HouseholdSize; v60.Clean = value; HouseholdSize = v60;
                var v61 = Id; v61.Clean = value; Id = v61;
                var v62 = InterestAssistanceCodeType; v62.Clean = value; InterestAssistanceCodeType = v62;
                var v63 = InterestRateBasedonFannieIndicator; v63.Clean = value; InterestRateBasedonFannieIndicator = v63;
                var v64 = InterestRateCodeType; v64.Clean = value; InterestRateCodeType = v64;
                var v65 = InterestRateFloatToLoanClosingIndicator; v65.Clean = value; InterestRateFloatToLoanClosingIndicator = v65;
                var v66 = LackAdequateHeatIndicator; v66.Clean = value; LackAdequateHeatIndicator = v66;
                var v67 = LenderAuthorizedRepCompany; v67.Clean = value; LenderAuthorizedRepCompany = v67;
                var v68 = LenderAuthorizedRepName; v68.Clean = value; LenderAuthorizedRepName = v68;
                var v69 = LenderAuthorizedRepTitle; v69.Clean = value; LenderAuthorizedRepTitle = v69;
                var v70 = LenderIdNo; v70.Clean = value; LenderIdNo = v70;
                var v71 = LenderNoteRateOnGuaranteedPortion; v71.Clean = value; LenderNoteRateOnGuaranteedPortion = v71;
                var v72 = LenderNoteRateOnNonGuaranteedPortion; v72.Clean = value; LenderNoteRateOnNonGuaranteedPortion = v72;
                var v73 = LenderStatusCodeType; v73.Clean = value; LenderStatusCodeType = v73;
                var v74 = LenderTypeCode; v74.Clean = value; LenderTypeCode = v74;
                var v75 = LoanType; v75.Clean = value; LoanType = v75;
                var v76 = LockCompletePlumbingIndicator; v76.Clean = value; LockCompletePlumbingIndicator = v76;
                var v77 = MedicalExpenses; v77.Clean = value; MedicalExpenses = v77;
                var v78 = ModerateIncomeLimit; v78.Clean = value; ModerateIncomeLimit = v78;
                var v79 = MonthlyRepaymentIncome; v79.Clean = value; MonthlyRepaymentIncome = v79;
                var v80 = NumberofDependents; v80.Clean = value; NumberofDependents = v80;
                var v81 = NumberofPeopleInHousehold; v81.Clean = value; NumberofPeopleInHousehold = v81;
                var v82 = ObligationMatchesCommitmentLenderRequestIndicator; v82.Clean = value; ObligationMatchesCommitmentLenderRequestIndicator = v82;
                var v83 = OfficialWhoConfirmedGlsUpdated; v83.Clean = value; OfficialWhoConfirmedGlsUpdated = v83;
                var v84 = OtherIncome; v84.Clean = value; OtherIncome = v84;
                var v85 = OtherStableDependableMonthlyIncome; v85.Clean = value; OtherStableDependableMonthlyIncome = v85;
                var v86 = OvercrowdedIndicator; v86.Clean = value; OvercrowdedIndicator = v86;
                var v87 = PercentofLoanGuaranteed; v87.Clean = value; PercentofLoanGuaranteed = v87;
                var v88 = PeriodOperatingLineCreditYearsType; v88.Clean = value; PeriodOperatingLineCreditYearsType = v88;
                var v89 = PhysicallyDeterioratedIndicator; v89.Clean = value; PhysicallyDeterioratedIndicator = v89;
                var v90 = PreparedByName; v90.Clean = value; PreparedByName = v90;
                var v91 = PreparedByTitle; v91.Clean = value; PreparedByTitle = v91;
                var v92 = PresentLandloardAddress; v92.Clean = value; PresentLandloardAddress = v92;
                var v93 = PresentLandloardCity; v93.Clean = value; PresentLandloardCity = v93;
                var v94 = PresentLandloardName; v94.Clean = value; PresentLandloardName = v94;
                var v95 = PresentLandloardPhone; v95.Clean = value; PresentLandloardPhone = v95;
                var v96 = PresentLandloardState; v96.Clean = value; PresentLandloardState = v96;
                var v97 = PresentLandloardZip; v97.Clean = value; PresentLandloardZip = v97;
                var v98 = PreviousLandloardAddress; v98.Clean = value; PreviousLandloardAddress = v98;
                var v99 = PreviousLandloardCity; v99.Clean = value; PreviousLandloardCity = v99;
                var v100 = PreviousLandloardName; v100.Clean = value; PreviousLandloardName = v100;
                var v101 = PreviousLandloardPhone; v101.Clean = value; PreviousLandloardPhone = v101;
                var v102 = PreviousLandloardState; v102.Clean = value; PreviousLandloardState = v102;
                var v103 = PreviousLandloardZip; v103.Clean = value; PreviousLandloardZip = v103;
                var v104 = PurchaseOrRefinancedAmount; v104.Clean = value; PurchaseOrRefinancedAmount = v104;
                var v105 = PurchaseOrRefinanceDescription; v105.Clean = value; PurchaseOrRefinanceDescription = v105;
                var v106 = RdsfhRefinancedLoanIndicatorType; v106.Clean = value; RdsfhRefinancedLoanIndicatorType = v106;
                var v107 = RefinanceLoanIndicator; v107.Clean = value; RefinanceLoanIndicator = v107;
                var v108 = RepairOtherAmount; v108.Clean = value; RepairOtherAmount = v108;
                var v109 = RepairOtherDescription; v109.Clean = value; RepairOtherDescription = v109;
                var v110 = ReservationAmountRequested; v110.Clean = value; ReservationAmountRequested = v110;
                var v111 = Reserved; v111.Clean = value; Reserved = v111;
                var v112 = ServicingOfficeName; v112.Clean = value; ServicingOfficeName = v112;
                var v113 = SfhglpIndicator; v113.Clean = value; SfhglpIndicator = v113;
                var v114 = SourceOfFundsType; v114.Clean = value; SourceOfFundsType = v114;
                var v115 = StableDependableMonthlyIncome; v115.Clean = value; StableDependableMonthlyIncome = v115;
                var v116 = StableOtherIncomeDesc; v116.Clean = value; StableOtherIncomeDesc = v116;
                var v117 = SubmittingLenderAddress; v117.Clean = value; SubmittingLenderAddress = v117;
                var v118 = SubmittingLenderCity; v118.Clean = value; SubmittingLenderCity = v118;
                var v119 = SubmittingLenderContactFax; v119.Clean = value; SubmittingLenderContactFax = v119;
                var v120 = SubmittingLenderContactName; v120.Clean = value; SubmittingLenderContactName = v120;
                var v121 = SubmittingLenderContactPhone; v121.Clean = value; SubmittingLenderContactPhone = v121;
                var v122 = SubmittingLenderName; v122.Clean = value; SubmittingLenderName = v122;
                var v123 = SubmittingLenderState; v123.Clean = value; SubmittingLenderState = v123;
                var v124 = SubmittingLenderTaxId; v124.Clean = value; SubmittingLenderTaxId = v124;
                var v125 = SubmittingLenderZip; v125.Clean = value; SubmittingLenderZip = v125;
                var v126 = TermOfBuydown; v126.Clean = value; TermOfBuydown = v126;
                var v127 = ThirdPartyOriginator; v127.Clean = value; ThirdPartyOriginator = v127;
                var v128 = Title; v128.Clean = value; Title = v128;
                var v129 = TotalBorrowerStableBaseIncome; v129.Clean = value; TotalBorrowerStableBaseIncome = v129;
                var v130 = TotalBorrowerStableOtherIncome; v130.Clean = value; TotalBorrowerStableOtherIncome = v130;
                var v131 = TotalHouseholdDeduction; v131.Clean = value; TotalHouseholdDeduction = v131;
                var v132 = TotalRequestAmount; v132.Clean = value; TotalRequestAmount = v132;
                var v133 = TpoTaxId; v133.Clean = value; TpoTaxId = v133;
                var v134 = UnderwritingDecisionBy; v134.Clean = value; UnderwritingDecisionBy = v134;
                var v135 = UnderwritingDecisionDate; v135.Clean = value; UnderwritingDecisionDate = v135;
                var v136 = UnderwritingDecisionType; v136.Clean = value; UnderwritingDecisionType = v136;
                var v137 = UsdaHouseholdIncomes; v137.Clean = value; UsdaHouseholdIncomes = v137;
                var v138 = VerificationCode; v138.Clean = value; VerificationCode = v138;
                _settingClean = 0;
            }
        }
    }
}