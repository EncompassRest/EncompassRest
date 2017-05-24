using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Uldd
    {
        public Value<string> ACHABARoutingAndTransitIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHABARoutingAndTransitIdentifier() => !ACHABARoutingAndTransitIdentifier.Clean;
        public Value<string> ACHABARoutingAndTransitNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHABARoutingAndTransitNumber() => !ACHABARoutingAndTransitNumber.Clean;
        public Value<string> ACHBankAccountDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountDescription() => !ACHBankAccountDescription.Clean;
        public Value<string> ACHBankAccountIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountIdentifier() => !ACHBankAccountIdentifier.Clean;
        public Value<string> ACHBankAccountPurposeTransitIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountPurposeTransitIdentifier() => !ACHBankAccountPurposeTransitIdentifier.Clean;
        public Value<string> ACHBankAccountPurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountPurposeType() => !ACHBankAccountPurposeType.Clean;
        public Value<string> ACHInstitutionTelegraphicAbbreviationName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHInstitutionTelegraphicAbbreviationName() => !ACHInstitutionTelegraphicAbbreviationName.Clean;
        public Value<string> ACHReceiverSubaccountName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHReceiverSubaccountName() => !ACHReceiverSubaccountName.Clean;
        public Value<bool?> AdditionalPrincipalAmountIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalPrincipalAmountIndicator() => !AdditionalPrincipalAmountIndicator.Clean;
        public Value<decimal?> AggregateLoanCurtailmentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAggregateLoanCurtailmentAmount() => !AggregateLoanCurtailmentAmount.Clean;
        public Value<string> AppraisalIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalIdentifier() => !AppraisalIdentifier.Clean;
        public Value<string> AttachmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttachmentType() => !AttachmentType.Clean;
        public Value<string> AVMModelNameType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAVMModelNameType() => !AVMModelNameType.Clean;
        public Value<bool?> BalloonResetIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonResetIndicator() => !BalloonResetIndicator.Clean;
        public Value<decimal?> BaseGuarantyFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseGuarantyFeePercent() => !BaseGuarantyFeePercent.Clean;
        public Value<string> BondFinancePool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinancePool() => !BondFinancePool.Clean;
        public Value<string> BondFinanceProgramName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinanceProgramName() => !BondFinanceProgramName.Clean;
        public Value<string> BondFinanceProgramType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinanceProgramType() => !BondFinanceProgramType.Clean;
        public Value<bool?> BorrowerMailToAddressSameasPropertyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerMailToAddressSameasPropertyIndicator() => !BorrowerMailToAddressSameasPropertyIndicator.Clean;
        public Value<string> BorrowerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerType() => !BorrowerType.Clean;
        public Value<bool?> CapitalizedLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCapitalizedLoanIndicator() => !CapitalizedLoanIndicator.Clean;
        public Value<string> CertificateIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateIdentifier() => !CertificateIdentifier.Clean;
        public Value<DateTime?> CertificateMaturityDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateMaturityDate() => !CertificateMaturityDate.Clean;
        public Value<decimal?> CertificatePrincipalBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificatePrincipalBalanceAmount() => !CertificatePrincipalBalanceAmount.Clean;
        public Value<string> CertificateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateType() => !CertificateType.Clean;
        public Value<decimal?> ClosingCost2ContributionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2ContributionAmount() => !ClosingCost2ContributionAmount.Clean;
        public Value<string> ClosingCost2FundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2FundsType() => !ClosingCost2FundsType.Clean;
        public Value<string> ClosingCost2FundsTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2FundsTypeOtherDescription() => !ClosingCost2FundsTypeOtherDescription.Clean;
        public Value<string> ClosingCost2SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2SourceType() => !ClosingCost2SourceType.Clean;
        public Value<string> ClosingCost2SourceTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2SourceTypeOtherDescription() => !ClosingCost2SourceTypeOtherDescription.Clean;
        public Value<decimal?> ClosingCost3ContributionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3ContributionAmount() => !ClosingCost3ContributionAmount.Clean;
        public Value<string> ClosingCost3FundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3FundsType() => !ClosingCost3FundsType.Clean;
        public Value<string> ClosingCost3FundsTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3FundsTypeOtherDescription() => !ClosingCost3FundsTypeOtherDescription.Clean;
        public Value<string> ClosingCost3SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3SourceType() => !ClosingCost3SourceType.Clean;
        public Value<string> ClosingCost3SourceTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3SourceTypeOtherDescription() => !ClosingCost3SourceTypeOtherDescription.Clean;
        public Value<decimal?> ClosingCost4ContributionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4ContributionAmount() => !ClosingCost4ContributionAmount.Clean;
        public Value<string> ClosingCost4FundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4FundsType() => !ClosingCost4FundsType.Clean;
        public Value<string> ClosingCost4FundsTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4FundsTypeOtherDescription() => !ClosingCost4FundsTypeOtherDescription.Clean;
        public Value<string> ClosingCost4SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4SourceType() => !ClosingCost4SourceType.Clean;
        public Value<string> ClosingCost4SourceTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4SourceTypeOtherDescription() => !ClosingCost4SourceTypeOtherDescription.Clean;
        public Value<decimal?> ClosingCostContributionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostContributionAmount() => !ClosingCostContributionAmount.Clean;
        public Value<string> ClosingCostFundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostFundsType() => !ClosingCostFundsType.Clean;
        public Value<string> ClosingCostFundsTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostFundsTypeOtherDescription() => !ClosingCostFundsTypeOtherDescription.Clean;
        public Value<string> ClosingCostSourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostSourceType() => !ClosingCostSourceType.Clean;
        public Value<string> ClosingCostSourceTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostSourceTypeOtherDescription() => !ClosingCostSourceTypeOtherDescription.Clean;
        public Value<string> CoBorrowerCountryCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerCountryCode() => !CoBorrowerCountryCode.Clean;
        public Value<bool?> CoBorrowerMailToAddressSameasPropertyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerMailToAddressSameasPropertyIndicator() => !CoBorrowerMailToAddressSameasPropertyIndicator.Clean;
        public Value<string> CoBorrowerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerType() => !CoBorrowerType.Clean;
        public Value<string> CondominiumProjectStatusType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondominiumProjectStatusType() => !CondominiumProjectStatusType.Clean;
        public Value<string> ConstructionMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionMethodType() => !ConstructionMethodType.Clean;
        public Value<string> ConstructionMethodTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionMethodTypeOtherDescription() => !ConstructionMethodTypeOtherDescription.Clean;
        public Value<string> ConstructionToPermanentClosingFeatureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionToPermanentClosingFeatureType() => !ConstructionToPermanentClosingFeatureType.Clean;
        public Value<string> ConstructionToPermanentClosingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionToPermanentClosingType() => !ConstructionToPermanentClosingType.Clean;
        public Value<string> ConvertibleStatusType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleStatusType() => !ConvertibleStatusType.Clean;
        public Value<string> CounselingFormatType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingFormatType() => !CounselingFormatType.Clean;
        public Value<string> CounselingFormatTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingFormatTypeOtherDescription() => !CounselingFormatTypeOtherDescription.Clean;
        public Value<string> CounselTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselTypeOther() => !CounselTypeOther.Clean;
        public Value<string> CountryCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCountryCode() => !CountryCode.Clean;
        public Value<string> CreditScoreImpairmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScoreImpairmentType() => !CreditScoreImpairmentType.Clean;
        public Value<decimal?> CurrentAccruedInterestAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentAccruedInterestAmount() => !CurrentAccruedInterestAmount.Clean;
        public Value<int?> DelinquentPaymentsOverPastTwelveMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDelinquentPaymentsOverPastTwelveMonthsCount() => !DelinquentPaymentsOverPastTwelveMonthsCount.Clean;
        public Value<string> DocumentCustodianID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentCustodianID() => !DocumentCustodianID.Clean;
        public Value<string> DocumentRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentRequiredIndicator() => !DocumentRequiredIndicator.Clean;
        public Value<string> DocumentSubmissionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentSubmissionIndicator() => !DocumentSubmissionIndicator.Clean;
        public Value<string> DownPaymentFundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentFundsType() => !DownPaymentFundsType.Clean;
        public Value<string> DownPaymentOtherTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentOtherTypeDescription() => !DownPaymentOtherTypeDescription.Clean;
        public Value<string> DownPaymentSourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentSourceType() => !DownPaymentSourceType.Clean;
        public Value<string> DownPaymentSourceTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentSourceTypeOtherDescription() => !DownPaymentSourceTypeOtherDescription.Clean;
        public Value<string> FannieARMIndexType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieARMIndexType() => !FannieARMIndexType.Clean;
        public Value<string> FannieAutoUWDec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieAutoUWDec() => !FannieAutoUWDec.Clean;
        public Value<int?> FannieBLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBLTV() => !FannieBLTV.Clean;
        public Value<string> FannieBorrowerFirstName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBorrowerFirstName() => !FannieBorrowerFirstName.Clean;
        public Value<string> FannieBorrowerMiddleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBorrowerMiddleName() => !FannieBorrowerMiddleName.Clean;
        public Value<string> FannieBuydownContributer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBuydownContributer() => !FannieBuydownContributer.Clean;
        public Value<int?> FannieCLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCLTV() => !FannieCLTV.Clean;
        public Value<string> FannieCoBorrowerFirstName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCoBorrowerFirstName() => !FannieCoBorrowerFirstName.Clean;
        public Value<string> FannieCoBorrowerMiddleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCoBorrowerMiddleName() => !FannieCoBorrowerMiddleName.Clean;
        public Value<string> FannieCreditScoreProviderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCreditScoreProviderName() => !FannieCreditScoreProviderName.Clean;
        public Value<string> FannieFloodSpecialFeatureCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieFloodSpecialFeatureCode() => !FannieFloodSpecialFeatureCode.Clean;
        public Value<int?> FannieHCLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieHCLTV() => !FannieHCLTV.Clean;
        public Value<int?> FannieInvestorOwnershipPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieInvestorOwnershipPercent() => !FannieInvestorOwnershipPercent.Clean;
        public Value<string> FannieLegalEntityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLegalEntityType() => !FannieLegalEntityType.Clean;
        public Value<string> FannieLegalEntityTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLegalEntityTypeOther() => !FannieLegalEntityTypeOther.Clean;
        public Value<decimal?> FannieLenderPaidMIInterestRateAdjustmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLenderPaidMIInterestRateAdjustmentPercent() => !FannieLenderPaidMIInterestRateAdjustmentPercent.Clean;
        public Value<string> FannieLoanProgramIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLoanProgramIdentifier() => !FannieLoanProgramIdentifier.Clean;
        public Value<int?> FannieLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLTV() => !FannieLTV.Clean;
        public Value<string> FannieMICompanyNameTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieMICompanyNameTypeOther() => !FannieMICompanyNameTypeOther.Clean;
        public Value<int?> FannieMICoveragePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieMICoveragePercent() => !FannieMICoveragePercent.Clean;
        public Value<int?> FanniePoolOwnershipPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFanniePoolOwnershipPercent() => !FanniePoolOwnershipPercent.Clean;
        public Value<string> FannieProjectClassificationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieProjectClassificationType() => !FannieProjectClassificationType.Clean;
        public Value<string> FanniePropertyFormType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFanniePropertyFormType() => !FanniePropertyFormType.Clean;
        public Value<decimal?> FannieRateSpread { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRateSpread() => !FannieRateSpread.Clean;
        public Value<string> FannieRefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRefinanceType() => !FannieRefinanceType.Clean;
        public Value<string> FannieRelatedInvestorLoanID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedInvestorLoanID() => !FannieRelatedInvestorLoanID.Clean;
        public Value<string> FannieRelatedLoanAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanAmortizationType() => !FannieRelatedLoanAmortizationType.Clean;
        public Value<string> FannieRelatedLoanLienPosition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanLienPosition() => !FannieRelatedLoanLienPosition.Clean;
        public Value<string> FannieRelatedLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanType() => !FannieRelatedLoanType.Clean;
        public Value<string> FannieSectionOfAct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieSectionOfAct() => !FannieSectionOfAct.Clean;
        public Value<int?> FannieTLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieTLTV() => !FannieTLTV.Clean;
        public Value<string> FannieTrustName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieTrustName() => !FannieTrustName.Clean;
        public Value<string> FannnieMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannnieMortgageType() => !FannnieMortgageType.Clean;
        public Value<int?> FinancedUnitCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedUnitCount() => !FinancedUnitCount.Clean;
        public Value<DateTime?> FirstRateChangePaymentEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstRateChangePaymentEffectiveDate() => !FirstRateChangePaymentEffectiveDate.Clean;
        public Value<string> FNMHomeImprovementProductType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFNMHomeImprovementProductType() => !FNMHomeImprovementProductType.Clean;
        public Value<string> FreddieARMIndexType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieARMIndexType() => !FreddieARMIndexType.Clean;
        public Value<string> FreddieAutoUWDec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieAutoUWDec() => !FreddieAutoUWDec.Clean;
        public Value<string> FreddieAVMModelNameTypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieAVMModelNameTypeExpl() => !FreddieAVMModelNameTypeExpl.Clean;
        public Value<string> FreddieBorrowerAlienStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieBorrowerAlienStatus() => !FreddieBorrowerAlienStatus.Clean;
        public Value<string> FreddieCoBorrowerAlienStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieCoBorrowerAlienStatus() => !FreddieCoBorrowerAlienStatus.Clean;
        public Value<string> FreddieCreditScoreProviderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieCreditScoreProviderName() => !FreddieCreditScoreProviderName.Clean;
        public Value<string> FreddieDownPaymentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPaymentType() => !FreddieDownPaymentType.Clean;
        public Value<string> FreddieDownPmt2SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2SourceType() => !FreddieDownPmt2SourceType.Clean;
        public Value<string> FreddieDownPmt2SourceTypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2SourceTypeExpl() => !FreddieDownPmt2SourceTypeExpl.Clean;
        public Value<string> FreddieDownPmt2Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2Type() => !FreddieDownPmt2Type.Clean;
        public Value<string> FreddieDownPmt2TypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2TypeExpl() => !FreddieDownPmt2TypeExpl.Clean;
        public Value<decimal?> FreddieDownPmt3Amt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3Amt() => !FreddieDownPmt3Amt.Clean;
        public Value<string> FreddieDownPmt3SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3SourceType() => !FreddieDownPmt3SourceType.Clean;
        public Value<string> FreddieDownPmt3SourceTypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3SourceTypeExpl() => !FreddieDownPmt3SourceTypeExpl.Clean;
        public Value<string> FreddieDownPmt3Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3Type() => !FreddieDownPmt3Type.Clean;
        public Value<string> FreddieDownPmt3TypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3TypeExpl() => !FreddieDownPmt3TypeExpl.Clean;
        public Value<decimal?> FreddieDownPmt4Amt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4Amt() => !FreddieDownPmt4Amt.Clean;
        public Value<string> FreddieDownPmt4SourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4SourceType() => !FreddieDownPmt4SourceType.Clean;
        public Value<string> FreddieDownPmt4SourceTypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4SourceTypeExpl() => !FreddieDownPmt4SourceTypeExpl.Clean;
        public Value<string> FreddieDownPmt4Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4Type() => !FreddieDownPmt4Type.Clean;
        public Value<string> FreddieDownPmt4TypeExpl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4TypeExpl() => !FreddieDownPmt4TypeExpl.Clean;
        public Value<string> FreddieExplanationOfDownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieExplanationOfDownPayment() => !FreddieExplanationOfDownPayment.Clean;
        public Value<string> FreddieInvestorCollateralProgramIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieInvestorCollateralProgramIdentifier() => !FreddieInvestorCollateralProgramIdentifier.Clean;
        public Value<string> FreddieInvestorFeatureIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieInvestorFeatureIdentifier() => !FreddieInvestorFeatureIdentifier.Clean;
        public Value<string> FreddieLegalEntityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLegalEntityType() => !FreddieLegalEntityType.Clean;
        public Value<string> FreddieLegalEntityTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLegalEntityTypeOther() => !FreddieLegalEntityTypeOther.Clean;
        public Value<string> FreddieLoanProgramIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLoanProgramIdentifier() => !FreddieLoanProgramIdentifier.Clean;
        public Value<string> FreddieLoanTypePublicAndIndianHousingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLoanTypePublicAndIndianHousingIndicator() => !FreddieLoanTypePublicAndIndianHousingIndicator.Clean;
        public Value<string> FreddieMICompanyNameTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMICompanyNameTypeOther() => !FreddieMICompanyNameTypeOther.Clean;
        public Value<string> FreddieMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMortgageType() => !FreddieMortgageType.Clean;
        public Value<string> FreddieProjectClassificationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieProjectClassificationType() => !FreddieProjectClassificationType.Clean;
        public Value<string> FreddiePropertyFormType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddiePropertyFormType() => !FreddiePropertyFormType.Clean;
        public Value<string> FreddieRefinanceCashOutDeterminationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRefinanceCashOutDeterminationType() => !FreddieRefinanceCashOutDeterminationType.Clean;
        public Value<string> FreddieRefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRefinanceType() => !FreddieRefinanceType.Clean;
        public Value<bool?> FreddieRelatedClosedEndSecondIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedClosedEndSecondIndicator() => !FreddieRelatedClosedEndSecondIndicator.Clean;
        public Value<string> FreddieRelatedInvestorLoanID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedInvestorLoanID() => !FreddieRelatedInvestorLoanID.Clean;
        public Value<string> FreddieRelatedLoanInvestorType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanInvestorType() => !FreddieRelatedLoanInvestorType.Clean;
        public Value<string> FreddieRelatedLoanLienPosition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanLienPosition() => !FreddieRelatedLoanLienPosition.Clean;
        public Value<string> FreddieRelatedLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanType() => !FreddieRelatedLoanType.Clean;
        public Value<string> FreddieSectionOfAct { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieSectionOfAct() => !FreddieSectionOfAct.Clean;
        public Value<string> FreddieUnderwritingTypeOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieUnderwritingTypeOther() => !FreddieUnderwritingTypeOther.Clean;
        public Value<string> GinnieConstructionMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieConstructionMethodType() => !GinnieConstructionMethodType.Clean;
        public Value<decimal?> GinnieGovernmentAnnualPremiumAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieGovernmentAnnualPremiumAmount() => !GinnieGovernmentAnnualPremiumAmount.Clean;
        public Value<string> GinnieMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieMortgageType() => !GinnieMortgageType.Clean;
        public Value<string> GinnieOtherConstructionMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieOtherConstructionMethodType() => !GinnieOtherConstructionMethodType.Clean;
        public Value<decimal?> GovernmentAnnualPremiumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentAnnualPremiumPercent() => !GovernmentAnnualPremiumPercent.Clean;
        public Value<string> GovernmentRefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentRefinanceType() => !GovernmentRefinanceType.Clean;
        public Value<decimal?> GovernmentUpfrontPremiumAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentUpfrontPremiumAmount() => !GovernmentUpfrontPremiumAmount.Clean;
        public Value<decimal?> GovernmentUpfrontPremiumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentUpfrontPremiumPercent() => !GovernmentUpfrontPremiumPercent.Clean;
        public Value<string> GSEProjectType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEProjectType() => !GSEProjectType.Clean;
        public Value<bool?> GuaranteeFeeAddOnIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeAddOnIndicator() => !GuaranteeFeeAddOnIndicator.Clean;
        public Value<decimal?> GuarantyFeeAfterAlternatePaymentMethodPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyFeeAfterAlternatePaymentMethodPercent() => !GuarantyFeeAfterAlternatePaymentMethodPercent.Clean;
        public Value<decimal?> GuarantyFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyFeePercent() => !GuarantyFeePercent.Clean;
        public Value<decimal?> GuarantyPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyPercent() => !GuarantyPercent.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IndexType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexType() => !IndexType.Clean;
        public Value<int?> InitialFixedPeriodEffectiveMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialFixedPeriodEffectiveMonthsCount() => !InitialFixedPeriodEffectiveMonthsCount.Clean;
        public Value<string> InterestAccrualType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAccrualType() => !InterestAccrualType.Clean;
        public Value<int?> InterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAndPaymentAdjustmentIndexLeadDaysCount() => !InterestAndPaymentAdjustmentIndexLeadDaysCount.Clean;
        public Value<string> InterestCalculationBasisType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationBasisType() => !InterestCalculationBasisType.Clean;
        public Value<int?> InterestCalculationEffectiveMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationEffectiveMonthsCount() => !InterestCalculationEffectiveMonthsCount.Clean;
        public Value<string> InterestCalculationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationType() => !InterestCalculationType.Clean;
        public Value<string> InvestorCollateralProgramIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCollateralProgramIdentifier() => !InvestorCollateralProgramIdentifier.Clean;
        public Value<string> InvestorCommitmentIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCommitmentIdentifier() => !InvestorCommitmentIdentifier.Clean;
        public Value<string> InvestorFeatureIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorFeatureIdentifier() => !InvestorFeatureIdentifier.Clean;
        public Value<string> InvestorFeatureIdPool { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorFeatureIdPool() => !InvestorFeatureIdPool.Clean;
        public Value<decimal?> InvestorOwnershipPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorOwnershipPercent() => !InvestorOwnershipPercent.Clean;
        public Value<string> InvestorProductPlanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorProductPlanIdentifier() => !InvestorProductPlanIdentifier.Clean;
        public Value<int?> InvestorRemittanceDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorRemittanceDay() => !InvestorRemittanceDay.Clean;
        public Value<string> InvestorRemittanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorRemittanceType() => !InvestorRemittanceType.Clean;
        public Value<string> IssuerIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIssuerIdentifier() => !IssuerIdentifier.Clean;
        public Value<DateTime?> LastPaidInstallmentDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaidInstallmentDueDate() => !LastPaidInstallmentDueDate.Clean;
        public Value<DateTime?> LastPaymentReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentReceivedDate() => !LastPaymentReceivedDate.Clean;
        public Value<DateTime?> LatestConversionEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLatestConversionEffectiveDate() => !LatestConversionEffectiveDate.Clean;
        public Value<decimal?> LenderPaidMIInterestRateAdjustmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidMIInterestRateAdjustmentPercent() => !LenderPaidMIInterestRateAdjustmentPercent.Clean;
        public Value<DateTime?> LendersDeliveryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLendersDeliveryDate() => !LendersDeliveryDate.Clean;
        public Value<decimal?> LoanAcquisitionScheduledUPBAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAcquisitionScheduledUPBAmount() => !LoanAcquisitionScheduledUPBAmount.Clean;
        public Value<int?> LoanAmortizationMaximumTermMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationMaximumTermMonthsCount() => !LoanAmortizationMaximumTermMonthsCount.Clean;
        public Value<int?> LoanBuyupBuydownBasisPointNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanBuyupBuydownBasisPointNumber() => !LoanBuyupBuydownBasisPointNumber.Clean;
        public Value<string> LoanBuyupBuydownType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanBuyupBuydownType() => !LoanBuyupBuydownType.Clean;
        public Value<string> LoanDefaultLossPartyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDefaultLossPartyType() => !LoanDefaultLossPartyType.Clean;
        public Value<bool?> LoanDeliveredThroughServicingReleasedProcessIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDeliveredThroughServicingReleasedProcessIndicator() => !LoanDeliveredThroughServicingReleasedProcessIndicator.Clean;
        public Value<string> LoanIdentifierValueType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanIdentifierValueType() => !LoanIdentifierValueType.Clean;
        public Value<DateTime?> LoanInterestAccrualStartDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanInterestAccrualStartDate() => !LoanInterestAccrualStartDate.Clean;
        public Value<bool?> LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreSelectionMethodSellerSpecificIndicator() => !LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Clean;
        public Value<string> LoanLevelCreditScoreSelectionMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreSelectionMethodType() => !LoanLevelCreditScoreSelectionMethodType.Clean;
        public Value<int?> LoanLevelCreditScoreValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreValue() => !LoanLevelCreditScoreValue.Clean;
        public Value<DateTime?> LoanModificationEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanModificationEffectiveDate() => !LoanModificationEffectiveDate.Clean;
        public Value<DateTime?> LoanStateDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanStateDate() => !LoanStateDate.Clean;
        public Value<string> ManufacturedHomeWidthType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHomeWidthType() => !ManufacturedHomeWidthType.Clean;
        public Value<bool?> MBSWeightedMarginIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMBSWeightedMarginIndicator() => !MBSWeightedMarginIndicator.Clean;
        public Value<string> MERSOriginalMortgageeOfRecordIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMERSOriginalMortgageeOfRecordIndicator() => !MERSOriginalMortgageeOfRecordIndicator.Clean;
        public Value<string> MICompanyNameType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMICompanyNameType() => !MICompanyNameType.Clean;
        public Value<string> MIPremiumSourceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPremiumSourceType() => !MIPremiumSourceType.Clean;
        public Value<DateTime?> MonetaryEventAppliedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventAppliedDate() => !MonetaryEventAppliedDate.Clean;
        public Value<decimal?> MonetaryEventGrossPrincipalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventGrossPrincipalAmount() => !MonetaryEventGrossPrincipalAmount.Clean;
        public Value<string> MonetaryEventType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventType() => !MonetaryEventType.Clean;
        public Value<bool?> MortgageBackedSecurityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBackedSecurityIndicator() => !MortgageBackedSecurityIndicator.Clean;
        public Value<bool?> MortgageModificationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageModificationIndicator() => !MortgageModificationIndicator.Clean;
        public Value<string> MortgageOriginator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageOriginator() => !MortgageOriginator.Clean;
        public Value<string> MortgageProgramType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageProgramType() => !MortgageProgramType.Clean;
        public Value<bool?> MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMultipleConcurrentlyClosingLienOnSubjectPropertyIndicator() => !MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Clean;
        public Value<DateTime?> NextRateAdjustmentEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextRateAdjustmentEffectiveDate() => !NextRateAdjustmentEffectiveDate.Clean;
        public Value<string> NotePayToName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotePayToName() => !NotePayToName.Clean;
        public Value<int?> NumberOfUnitsSold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfUnitsSold() => !NumberOfUnitsSold.Clean;
        public Value<string> OtherDownPaymentFundsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDownPaymentFundsType() => !OtherDownPaymentFundsType.Clean;
        public Value<decimal?> OtherFundsCollectedAtClosingAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherFundsCollectedAtClosingAmount() => !OtherFundsCollectedAtClosingAmount.Clean;
        public Value<string> OtherFundsCollectedAtClosingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherFundsCollectedAtClosingType() => !OtherFundsCollectedAtClosingType.Clean;
        public Value<string> PayeeID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayeeID() => !PayeeID.Clean;
        public Value<int?> PaymentBillingStatementLeadDaysCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentBillingStatementLeadDaysCount() => !PaymentBillingStatementLeadDaysCount.Clean;
        public Value<decimal?> PerChangeMaximumDecreaseRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeMaximumDecreaseRatePercent() => !PerChangeMaximumDecreaseRatePercent.Clean;
        public Value<decimal?> PerChangeMaximumIncreaseRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeMaximumIncreaseRatePercent() => !PerChangeMaximumIncreaseRatePercent.Clean;
        public Value<decimal?> PerChangePrincipalAndInterestPaymentAdjustmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangePrincipalAndInterestPaymentAdjustmentPercent() => !PerChangePrincipalAndInterestPaymentAdjustmentPercent.Clean;
        public Value<DateTime?> PerChangeRateAdjustmentEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeRateAdjustmentEffectiveDate() => !PerChangeRateAdjustmentEffectiveDate.Clean;
        public Value<int?> PerChangeRateAdjustmentFrequencyMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeRateAdjustmentFrequencyMonthsCount() => !PerChangeRateAdjustmentFrequencyMonthsCount.Clean;
        public Value<string> PoolAccrualRateStructureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAccrualRateStructureType() => !PoolAccrualRateStructureType.Clean;
        public Value<string> PoolAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAmortizationType() => !PoolAmortizationType.Clean;
        public Value<bool?> PoolAssumabilityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAssumabilityIndicator() => !PoolAssumabilityIndicator.Clean;
        public Value<bool?> PoolBalloonIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolBalloonIndicator() => !PoolBalloonIndicator.Clean;
        public Value<DateTime?> PoolCertificatePaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCertificatePaymentDate() => !PoolCertificatePaymentDate.Clean;
        public Value<string> PoolClassType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolClassType() => !PoolClassType.Clean;
        public Value<string> PoolConcurrentTransferIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolConcurrentTransferIndicator() => !PoolConcurrentTransferIndicator.Clean;
        public Value<int?> PoolCurrentLoanCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCurrentLoanCount() => !PoolCurrentLoanCount.Clean;
        public Value<decimal?> PoolCurrentPrincipalBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCurrentPrincipalBalanceAmount() => !PoolCurrentPrincipalBalanceAmount.Clean;
        public Value<string> PoolDocumentCustodianID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolDocumentCustodianID() => !PoolDocumentCustodianID.Clean;
        public Value<decimal?> PoolFixedServicingFeePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolFixedServicingFeePercent() => !PoolFixedServicingFeePercent.Clean;
        public Value<string> PoolIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIdentifier() => !PoolIdentifier.Clean;
        public Value<string> PoolingMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolingMethodType() => !PoolingMethodType.Clean;
        public Value<DateTime?> PoolInterestAdjustmentEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAdjustmentEffectiveDate() => !PoolInterestAdjustmentEffectiveDate.Clean;
        public Value<int?> PoolInterestAdjustmentIndexLeadDaysCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAdjustmentIndexLeadDaysCount() => !PoolInterestAdjustmentIndexLeadDaysCount.Clean;
        public Value<int?> PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAndPaymentAdjustmentIndexLeadDaysCount() => !PoolInterestAndPaymentAdjustmentIndexLeadDaysCount.Clean;
        public Value<bool?> PoolInterestOnlyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestOnlyIndicator() => !PoolInterestOnlyIndicator.Clean;
        public Value<decimal?> PoolInterestRateRoundingPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestRateRoundingPercent() => !PoolInterestRateRoundingPercent.Clean;
        public Value<string> PoolInterestRateRoundingType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestRateRoundingType() => !PoolInterestRateRoundingType.Clean;
        public Value<string> PoolInvestorProductPlanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInvestorProductPlanIdentifier() => !PoolInvestorProductPlanIdentifier.Clean;
        public Value<DateTime?> PoolIssueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIssueDate() => !PoolIssueDate.Clean;
        public Value<string> PoolIssuerTransferee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIssuerTransferee() => !PoolIssuerTransferee.Clean;
        public Value<decimal?> PoolMarginRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMarginRatePercent() => !PoolMarginRatePercent.Clean;
        public Value<DateTime?> PoolMaturityDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaturityDate() => !PoolMaturityDate.Clean;
        public Value<int?> PoolMaturityPeriodCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaturityPeriodCount() => !PoolMaturityPeriodCount.Clean;
        public Value<decimal?> PoolMaximumAccrualRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaximumAccrualRatePercent() => !PoolMaximumAccrualRatePercent.Clean;
        public Value<decimal?> PoolMinimumAccrualRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMinimumAccrualRatePercent() => !PoolMinimumAccrualRatePercent.Clean;
        public Value<string> PoolMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMortgageType() => !PoolMortgageType.Clean;
        public Value<int?> PoolScheduledRemittancePaymentDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolScheduledRemittancePaymentDay() => !PoolScheduledRemittancePaymentDay.Clean;
        public Value<decimal?> PoolSecurityIssueDateInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSecurityIssueDateInterestRatePercent() => !PoolSecurityIssueDateInterestRatePercent.Clean;
        public Value<string> PoolSellerID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSellerID() => !PoolSellerID.Clean;
        public Value<string> PoolServicerID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolServicerID() => !PoolServicerID.Clean;
        public Value<string> PoolStructureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolStructureType() => !PoolStructureType.Clean;
        public Value<string> PoolSuffixIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSuffixIdentifier() => !PoolSuffixIdentifier.Clean;
        public Value<DateTime?> PriceLockDatetime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceLockDatetime() => !PriceLockDatetime.Clean;
        public Value<string> PrimaryMIAbsenceReasonType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrimaryMIAbsenceReasonType() => !PrimaryMIAbsenceReasonType.Clean;
        public Value<string> PrimaryMIAbsenceReasonTypeOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrimaryMIAbsenceReasonTypeOtherDescription() => !PrimaryMIAbsenceReasonTypeOtherDescription.Clean;
        public Value<string> ProjectAttachmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectAttachmentType() => !ProjectAttachmentType.Clean;
        public Value<string> ProjectDesignType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectDesignType() => !ProjectDesignType.Clean;
        public Value<int?> ProjectUnitCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectUnitCount() => !ProjectUnitCount.Clean;
        public Value<DateTime?> PropertyValuationEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyValuationEffectiveDate() => !PropertyValuationEffectiveDate.Clean;
        public Value<string> PropertyValuationMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyValuationMethodType() => !PropertyValuationMethodType.Clean;
        public Value<decimal?> RefinanceCashOutAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceCashOutAmount() => !RefinanceCashOutAmount.Clean;
        public Value<string> RefinanceCashOutDeterminationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceCashOutDeterminationType() => !RefinanceCashOutDeterminationType.Clean;
        public Value<bool?> RelatedLoanBalloonIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanBalloonIndicator() => !RelatedLoanBalloonIndicator.Clean;
        public Value<bool?> RelatedLoanHELOCIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanHELOCIndicator() => !RelatedLoanHELOCIndicator.Clean;
        public Value<bool?> RelatedLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanIndicator() => !RelatedLoanIndicator.Clean;
        public Value<string> RelatedLoanInvestorType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanInvestorType() => !RelatedLoanInvestorType.Clean;
        public Value<int?> RelatedLoanMaturityPeriodCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanMaturityPeriodCount() => !RelatedLoanMaturityPeriodCount.Clean;
        public Value<DateTime?> RelatedLoanNoteDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanNoteDate() => !RelatedLoanNoteDate.Clean;
        public Value<DateTime?> RelatedLoanScheduledFirstPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanScheduledFirstPaymentDate() => !RelatedLoanScheduledFirstPaymentDate.Clean;
        public Value<DateTime?> RelatedLoanStateDateAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanStateDateAtClosing() => !RelatedLoanStateDateAtClosing.Clean;
        public Value<decimal?> RelatedLoanUnpaidPrincipalBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanUnpaidPrincipalBalanceAmount() => !RelatedLoanUnpaidPrincipalBalanceAmount.Clean;
        public Value<bool?> RelocationLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelocationLoanIndicator() => !RelocationLoanIndicator.Clean;
        public Value<string> REOMarketingPartyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeREOMarketingPartyType() => !REOMarketingPartyType.Clean;
        public Value<bool?> SecondLienIsDeliveredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondLienIsDeliveredIndicator() => !SecondLienIsDeliveredIndicator.Clean;
        public Value<decimal?> SecurityOriginalSubscriptionAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityOriginalSubscriptionAmount() => !SecurityOriginalSubscriptionAmount.Clean;
        public Value<DateTime?> SecurityTradeBookEntryDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityTradeBookEntryDate() => !SecurityTradeBookEntryDate.Clean;
        public Value<string> SellerID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerID() => !SellerID.Clean;
        public Value<string> SellerLoanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerLoanIdentifier() => !SellerLoanIdentifier.Clean;
        public Value<string> ServicerID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerID() => !ServicerID.Clean;
        public Value<string> ServicerLoanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerLoanIdentifier() => !ServicerLoanIdentifier.Clean;
        public Value<bool?> SharedEquityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSharedEquityIndicator() => !SharedEquityIndicator.Clean;
        public Value<bool?> SiteBuiltIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSiteBuiltIndicator() => !SiteBuiltIndicator.Clean;
        public Value<bool?> SpecialFloodHazardAreaIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFloodHazardAreaIndicator() => !SpecialFloodHazardAreaIndicator.Clean;
        public Value<decimal?> SubsequentPerChangeMaximumDecreaseRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeMaximumDecreaseRatePercent() => !SubsequentPerChangeMaximumDecreaseRatePercent.Clean;
        public Value<decimal?> SubsequentPerChangeMaximumIncreaseRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeMaximumIncreaseRatePercent() => !SubsequentPerChangeMaximumIncreaseRatePercent.Clean;
        public Value<DateTime?> SubsequentPerChangeRateAdjustmentEffectiveDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeRateAdjustmentEffectiveDate() => !SubsequentPerChangeRateAdjustmentEffectiveDate.Clean;
        public Value<int?> SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeRateAdjustmentFrequencyMonthsCount() => !SubsequentPerChangeRateAdjustmentFrequencyMonthsCount.Clean;
        public Value<bool?> TemporaryBuydownIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTemporaryBuydownIndicator() => !TemporaryBuydownIndicator.Clean;
        public Value<int?> TotalMortgagedPropertiesCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgagedPropertiesCount() => !TotalMortgagedPropertiesCount.Clean;
        public Value<decimal?> Unit1SubjectPropertyGrossRentalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit1SubjectPropertyGrossRentalIncome() => !Unit1SubjectPropertyGrossRentalIncome.Clean;
        public Value<int?> Unit1TotalBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit1TotalBedrooms() => !Unit1TotalBedrooms.Clean;
        public Value<decimal?> Unit2SubjectPropertyGrossRentalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit2SubjectPropertyGrossRentalIncome() => !Unit2SubjectPropertyGrossRentalIncome.Clean;
        public Value<int?> Unit2TotalBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit2TotalBedrooms() => !Unit2TotalBedrooms.Clean;
        public Value<decimal?> Unit3SubjectPropertyGrossRentalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit3SubjectPropertyGrossRentalIncome() => !Unit3SubjectPropertyGrossRentalIncome.Clean;
        public Value<int?> Unit3TotalBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit3TotalBedrooms() => !Unit3TotalBedrooms.Clean;
        public Value<decimal?> Unit4SubjectPropertyGrossRentalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit4SubjectPropertyGrossRentalIncome() => !Unit4SubjectPropertyGrossRentalIncome.Clean;
        public Value<int?> Unit4TotalBedrooms { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit4TotalBedrooms() => !Unit4TotalBedrooms.Clean;
        public Value<decimal?> UPBAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUPBAmount() => !UPBAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ACHABARoutingAndTransitIdentifier.Clean
                    && ACHABARoutingAndTransitNumber.Clean
                    && ACHBankAccountDescription.Clean
                    && ACHBankAccountIdentifier.Clean
                    && ACHBankAccountPurposeTransitIdentifier.Clean
                    && ACHBankAccountPurposeType.Clean
                    && ACHInstitutionTelegraphicAbbreviationName.Clean
                    && ACHReceiverSubaccountName.Clean
                    && AdditionalPrincipalAmountIndicator.Clean
                    && AggregateLoanCurtailmentAmount.Clean
                    && AppraisalIdentifier.Clean
                    && AttachmentType.Clean
                    && AVMModelNameType.Clean
                    && BalloonResetIndicator.Clean
                    && BaseGuarantyFeePercent.Clean
                    && BondFinancePool.Clean
                    && BondFinanceProgramName.Clean
                    && BondFinanceProgramType.Clean
                    && BorrowerMailToAddressSameasPropertyIndicator.Clean
                    && BorrowerType.Clean
                    && CapitalizedLoanIndicator.Clean
                    && CertificateIdentifier.Clean
                    && CertificateMaturityDate.Clean
                    && CertificatePrincipalBalanceAmount.Clean
                    && CertificateType.Clean
                    && ClosingCost2ContributionAmount.Clean
                    && ClosingCost2FundsType.Clean
                    && ClosingCost2FundsTypeOtherDescription.Clean
                    && ClosingCost2SourceType.Clean
                    && ClosingCost2SourceTypeOtherDescription.Clean
                    && ClosingCost3ContributionAmount.Clean
                    && ClosingCost3FundsType.Clean
                    && ClosingCost3FundsTypeOtherDescription.Clean
                    && ClosingCost3SourceType.Clean
                    && ClosingCost3SourceTypeOtherDescription.Clean
                    && ClosingCost4ContributionAmount.Clean
                    && ClosingCost4FundsType.Clean
                    && ClosingCost4FundsTypeOtherDescription.Clean
                    && ClosingCost4SourceType.Clean
                    && ClosingCost4SourceTypeOtherDescription.Clean
                    && ClosingCostContributionAmount.Clean
                    && ClosingCostFundsType.Clean
                    && ClosingCostFundsTypeOtherDescription.Clean
                    && ClosingCostSourceType.Clean
                    && ClosingCostSourceTypeOtherDescription.Clean
                    && CoBorrowerCountryCode.Clean
                    && CoBorrowerMailToAddressSameasPropertyIndicator.Clean
                    && CoBorrowerType.Clean
                    && CondominiumProjectStatusType.Clean
                    && ConstructionMethodType.Clean
                    && ConstructionMethodTypeOtherDescription.Clean
                    && ConstructionToPermanentClosingFeatureType.Clean
                    && ConstructionToPermanentClosingType.Clean
                    && ConvertibleStatusType.Clean
                    && CounselingFormatType.Clean
                    && CounselingFormatTypeOtherDescription.Clean
                    && CounselTypeOther.Clean
                    && CountryCode.Clean
                    && CreditScoreImpairmentType.Clean
                    && CurrentAccruedInterestAmount.Clean
                    && DelinquentPaymentsOverPastTwelveMonthsCount.Clean
                    && DocumentCustodianID.Clean
                    && DocumentRequiredIndicator.Clean
                    && DocumentSubmissionIndicator.Clean
                    && DownPaymentFundsType.Clean
                    && DownPaymentOtherTypeDescription.Clean
                    && DownPaymentSourceType.Clean
                    && DownPaymentSourceTypeOtherDescription.Clean
                    && FannieARMIndexType.Clean
                    && FannieAutoUWDec.Clean
                    && FannieBLTV.Clean
                    && FannieBorrowerFirstName.Clean
                    && FannieBorrowerMiddleName.Clean
                    && FannieBuydownContributer.Clean
                    && FannieCLTV.Clean
                    && FannieCoBorrowerFirstName.Clean
                    && FannieCoBorrowerMiddleName.Clean
                    && FannieCreditScoreProviderName.Clean
                    && FannieFloodSpecialFeatureCode.Clean
                    && FannieHCLTV.Clean
                    && FannieInvestorOwnershipPercent.Clean
                    && FannieLegalEntityType.Clean
                    && FannieLegalEntityTypeOther.Clean
                    && FannieLenderPaidMIInterestRateAdjustmentPercent.Clean
                    && FannieLoanProgramIdentifier.Clean
                    && FannieLTV.Clean
                    && FannieMICompanyNameTypeOther.Clean
                    && FannieMICoveragePercent.Clean
                    && FanniePoolOwnershipPercent.Clean
                    && FannieProjectClassificationType.Clean
                    && FanniePropertyFormType.Clean
                    && FannieRateSpread.Clean
                    && FannieRefinanceType.Clean
                    && FannieRelatedInvestorLoanID.Clean
                    && FannieRelatedLoanAmortizationType.Clean
                    && FannieRelatedLoanLienPosition.Clean
                    && FannieRelatedLoanType.Clean
                    && FannieSectionOfAct.Clean
                    && FannieTLTV.Clean
                    && FannieTrustName.Clean
                    && FannnieMortgageType.Clean
                    && FinancedUnitCount.Clean
                    && FirstRateChangePaymentEffectiveDate.Clean
                    && FNMHomeImprovementProductType.Clean
                    && FreddieARMIndexType.Clean
                    && FreddieAutoUWDec.Clean
                    && FreddieAVMModelNameTypeExpl.Clean
                    && FreddieBorrowerAlienStatus.Clean
                    && FreddieCoBorrowerAlienStatus.Clean
                    && FreddieCreditScoreProviderName.Clean
                    && FreddieDownPaymentType.Clean
                    && FreddieDownPmt2SourceType.Clean
                    && FreddieDownPmt2SourceTypeExpl.Clean
                    && FreddieDownPmt2Type.Clean
                    && FreddieDownPmt2TypeExpl.Clean
                    && FreddieDownPmt3Amt.Clean
                    && FreddieDownPmt3SourceType.Clean
                    && FreddieDownPmt3SourceTypeExpl.Clean
                    && FreddieDownPmt3Type.Clean
                    && FreddieDownPmt3TypeExpl.Clean
                    && FreddieDownPmt4Amt.Clean
                    && FreddieDownPmt4SourceType.Clean
                    && FreddieDownPmt4SourceTypeExpl.Clean
                    && FreddieDownPmt4Type.Clean
                    && FreddieDownPmt4TypeExpl.Clean
                    && FreddieExplanationOfDownPayment.Clean
                    && FreddieInvestorCollateralProgramIdentifier.Clean
                    && FreddieInvestorFeatureIdentifier.Clean
                    && FreddieLegalEntityType.Clean
                    && FreddieLegalEntityTypeOther.Clean
                    && FreddieLoanProgramIdentifier.Clean
                    && FreddieLoanTypePublicAndIndianHousingIndicator.Clean
                    && FreddieMICompanyNameTypeOther.Clean
                    && FreddieMortgageType.Clean
                    && FreddieProjectClassificationType.Clean
                    && FreddiePropertyFormType.Clean
                    && FreddieRefinanceCashOutDeterminationType.Clean
                    && FreddieRefinanceType.Clean
                    && FreddieRelatedClosedEndSecondIndicator.Clean
                    && FreddieRelatedInvestorLoanID.Clean
                    && FreddieRelatedLoanInvestorType.Clean
                    && FreddieRelatedLoanLienPosition.Clean
                    && FreddieRelatedLoanType.Clean
                    && FreddieSectionOfAct.Clean
                    && FreddieUnderwritingTypeOther.Clean
                    && GinnieConstructionMethodType.Clean
                    && GinnieGovernmentAnnualPremiumAmount.Clean
                    && GinnieMortgageType.Clean
                    && GinnieOtherConstructionMethodType.Clean
                    && GovernmentAnnualPremiumPercent.Clean
                    && GovernmentRefinanceType.Clean
                    && GovernmentUpfrontPremiumAmount.Clean
                    && GovernmentUpfrontPremiumPercent.Clean
                    && GSEProjectType.Clean
                    && GuaranteeFeeAddOnIndicator.Clean
                    && GuarantyFeeAfterAlternatePaymentMethodPercent.Clean
                    && GuarantyFeePercent.Clean
                    && GuarantyPercent.Clean
                    && Id.Clean
                    && IndexType.Clean
                    && InitialFixedPeriodEffectiveMonthsCount.Clean
                    && InterestAccrualType.Clean
                    && InterestAndPaymentAdjustmentIndexLeadDaysCount.Clean
                    && InterestCalculationBasisType.Clean
                    && InterestCalculationEffectiveMonthsCount.Clean
                    && InterestCalculationType.Clean
                    && InvestorCollateralProgramIdentifier.Clean
                    && InvestorCommitmentIdentifier.Clean
                    && InvestorFeatureIdentifier.Clean
                    && InvestorFeatureIdPool.Clean
                    && InvestorOwnershipPercent.Clean
                    && InvestorProductPlanIdentifier.Clean
                    && InvestorRemittanceDay.Clean
                    && InvestorRemittanceType.Clean
                    && IssuerIdentifier.Clean
                    && LastPaidInstallmentDueDate.Clean
                    && LastPaymentReceivedDate.Clean
                    && LatestConversionEffectiveDate.Clean
                    && LenderPaidMIInterestRateAdjustmentPercent.Clean
                    && LendersDeliveryDate.Clean
                    && LoanAcquisitionScheduledUPBAmount.Clean
                    && LoanAmortizationMaximumTermMonthsCount.Clean
                    && LoanBuyupBuydownBasisPointNumber.Clean
                    && LoanBuyupBuydownType.Clean
                    && LoanDefaultLossPartyType.Clean
                    && LoanDeliveredThroughServicingReleasedProcessIndicator.Clean
                    && LoanIdentifierValueType.Clean
                    && LoanInterestAccrualStartDate.Clean
                    && LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Clean
                    && LoanLevelCreditScoreSelectionMethodType.Clean
                    && LoanLevelCreditScoreValue.Clean
                    && LoanModificationEffectiveDate.Clean
                    && LoanStateDate.Clean
                    && ManufacturedHomeWidthType.Clean
                    && MBSWeightedMarginIndicator.Clean
                    && MERSOriginalMortgageeOfRecordIndicator.Clean
                    && MICompanyNameType.Clean
                    && MIPremiumSourceType.Clean
                    && MonetaryEventAppliedDate.Clean
                    && MonetaryEventGrossPrincipalAmount.Clean
                    && MonetaryEventType.Clean
                    && MortgageBackedSecurityIndicator.Clean
                    && MortgageModificationIndicator.Clean
                    && MortgageOriginator.Clean
                    && MortgageProgramType.Clean
                    && MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Clean
                    && NextRateAdjustmentEffectiveDate.Clean
                    && NotePayToName.Clean
                    && NumberOfUnitsSold.Clean
                    && OtherDownPaymentFundsType.Clean
                    && OtherFundsCollectedAtClosingAmount.Clean
                    && OtherFundsCollectedAtClosingType.Clean
                    && PayeeID.Clean
                    && PaymentBillingStatementLeadDaysCount.Clean
                    && PerChangeMaximumDecreaseRatePercent.Clean
                    && PerChangeMaximumIncreaseRatePercent.Clean
                    && PerChangePrincipalAndInterestPaymentAdjustmentPercent.Clean
                    && PerChangeRateAdjustmentEffectiveDate.Clean
                    && PerChangeRateAdjustmentFrequencyMonthsCount.Clean
                    && PoolAccrualRateStructureType.Clean
                    && PoolAmortizationType.Clean
                    && PoolAssumabilityIndicator.Clean
                    && PoolBalloonIndicator.Clean
                    && PoolCertificatePaymentDate.Clean
                    && PoolClassType.Clean
                    && PoolConcurrentTransferIndicator.Clean
                    && PoolCurrentLoanCount.Clean
                    && PoolCurrentPrincipalBalanceAmount.Clean
                    && PoolDocumentCustodianID.Clean
                    && PoolFixedServicingFeePercent.Clean
                    && PoolIdentifier.Clean
                    && PoolingMethodType.Clean
                    && PoolInterestAdjustmentEffectiveDate.Clean
                    && PoolInterestAdjustmentIndexLeadDaysCount.Clean
                    && PoolInterestAndPaymentAdjustmentIndexLeadDaysCount.Clean
                    && PoolInterestOnlyIndicator.Clean
                    && PoolInterestRateRoundingPercent.Clean
                    && PoolInterestRateRoundingType.Clean
                    && PoolInvestorProductPlanIdentifier.Clean
                    && PoolIssueDate.Clean
                    && PoolIssuerTransferee.Clean
                    && PoolMarginRatePercent.Clean
                    && PoolMaturityDate.Clean
                    && PoolMaturityPeriodCount.Clean
                    && PoolMaximumAccrualRatePercent.Clean
                    && PoolMinimumAccrualRatePercent.Clean
                    && PoolMortgageType.Clean
                    && PoolScheduledRemittancePaymentDay.Clean
                    && PoolSecurityIssueDateInterestRatePercent.Clean
                    && PoolSellerID.Clean
                    && PoolServicerID.Clean
                    && PoolStructureType.Clean
                    && PoolSuffixIdentifier.Clean
                    && PriceLockDatetime.Clean
                    && PrimaryMIAbsenceReasonType.Clean
                    && PrimaryMIAbsenceReasonTypeOtherDescription.Clean
                    && ProjectAttachmentType.Clean
                    && ProjectDesignType.Clean
                    && ProjectUnitCount.Clean
                    && PropertyValuationEffectiveDate.Clean
                    && PropertyValuationMethodType.Clean
                    && RefinanceCashOutAmount.Clean
                    && RefinanceCashOutDeterminationType.Clean
                    && RelatedLoanBalloonIndicator.Clean
                    && RelatedLoanHELOCIndicator.Clean
                    && RelatedLoanIndicator.Clean
                    && RelatedLoanInvestorType.Clean
                    && RelatedLoanMaturityPeriodCount.Clean
                    && RelatedLoanNoteDate.Clean
                    && RelatedLoanScheduledFirstPaymentDate.Clean
                    && RelatedLoanStateDateAtClosing.Clean
                    && RelatedLoanUnpaidPrincipalBalanceAmount.Clean
                    && RelocationLoanIndicator.Clean
                    && REOMarketingPartyType.Clean
                    && SecondLienIsDeliveredIndicator.Clean
                    && SecurityOriginalSubscriptionAmount.Clean
                    && SecurityTradeBookEntryDate.Clean
                    && SellerID.Clean
                    && SellerLoanIdentifier.Clean
                    && ServicerID.Clean
                    && ServicerLoanIdentifier.Clean
                    && SharedEquityIndicator.Clean
                    && SiteBuiltIndicator.Clean
                    && SpecialFloodHazardAreaIndicator.Clean
                    && SubsequentPerChangeMaximumDecreaseRatePercent.Clean
                    && SubsequentPerChangeMaximumIncreaseRatePercent.Clean
                    && SubsequentPerChangeRateAdjustmentEffectiveDate.Clean
                    && SubsequentPerChangeRateAdjustmentFrequencyMonthsCount.Clean
                    && TemporaryBuydownIndicator.Clean
                    && TotalMortgagedPropertiesCount.Clean
                    && Unit1SubjectPropertyGrossRentalIncome.Clean
                    && Unit1TotalBedrooms.Clean
                    && Unit2SubjectPropertyGrossRentalIncome.Clean
                    && Unit2TotalBedrooms.Clean
                    && Unit3SubjectPropertyGrossRentalIncome.Clean
                    && Unit3TotalBedrooms.Clean
                    && Unit4SubjectPropertyGrossRentalIncome.Clean
                    && Unit4TotalBedrooms.Clean
                    && UPBAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ACHABARoutingAndTransitIdentifier; v0.Clean = value; ACHABARoutingAndTransitIdentifier = v0;
                var v1 = ACHABARoutingAndTransitNumber; v1.Clean = value; ACHABARoutingAndTransitNumber = v1;
                var v2 = ACHBankAccountDescription; v2.Clean = value; ACHBankAccountDescription = v2;
                var v3 = ACHBankAccountIdentifier; v3.Clean = value; ACHBankAccountIdentifier = v3;
                var v4 = ACHBankAccountPurposeTransitIdentifier; v4.Clean = value; ACHBankAccountPurposeTransitIdentifier = v4;
                var v5 = ACHBankAccountPurposeType; v5.Clean = value; ACHBankAccountPurposeType = v5;
                var v6 = ACHInstitutionTelegraphicAbbreviationName; v6.Clean = value; ACHInstitutionTelegraphicAbbreviationName = v6;
                var v7 = ACHReceiverSubaccountName; v7.Clean = value; ACHReceiverSubaccountName = v7;
                var v8 = AdditionalPrincipalAmountIndicator; v8.Clean = value; AdditionalPrincipalAmountIndicator = v8;
                var v9 = AggregateLoanCurtailmentAmount; v9.Clean = value; AggregateLoanCurtailmentAmount = v9;
                var v10 = AppraisalIdentifier; v10.Clean = value; AppraisalIdentifier = v10;
                var v11 = AttachmentType; v11.Clean = value; AttachmentType = v11;
                var v12 = AVMModelNameType; v12.Clean = value; AVMModelNameType = v12;
                var v13 = BalloonResetIndicator; v13.Clean = value; BalloonResetIndicator = v13;
                var v14 = BaseGuarantyFeePercent; v14.Clean = value; BaseGuarantyFeePercent = v14;
                var v15 = BondFinancePool; v15.Clean = value; BondFinancePool = v15;
                var v16 = BondFinanceProgramName; v16.Clean = value; BondFinanceProgramName = v16;
                var v17 = BondFinanceProgramType; v17.Clean = value; BondFinanceProgramType = v17;
                var v18 = BorrowerMailToAddressSameasPropertyIndicator; v18.Clean = value; BorrowerMailToAddressSameasPropertyIndicator = v18;
                var v19 = BorrowerType; v19.Clean = value; BorrowerType = v19;
                var v20 = CapitalizedLoanIndicator; v20.Clean = value; CapitalizedLoanIndicator = v20;
                var v21 = CertificateIdentifier; v21.Clean = value; CertificateIdentifier = v21;
                var v22 = CertificateMaturityDate; v22.Clean = value; CertificateMaturityDate = v22;
                var v23 = CertificatePrincipalBalanceAmount; v23.Clean = value; CertificatePrincipalBalanceAmount = v23;
                var v24 = CertificateType; v24.Clean = value; CertificateType = v24;
                var v25 = ClosingCost2ContributionAmount; v25.Clean = value; ClosingCost2ContributionAmount = v25;
                var v26 = ClosingCost2FundsType; v26.Clean = value; ClosingCost2FundsType = v26;
                var v27 = ClosingCost2FundsTypeOtherDescription; v27.Clean = value; ClosingCost2FundsTypeOtherDescription = v27;
                var v28 = ClosingCost2SourceType; v28.Clean = value; ClosingCost2SourceType = v28;
                var v29 = ClosingCost2SourceTypeOtherDescription; v29.Clean = value; ClosingCost2SourceTypeOtherDescription = v29;
                var v30 = ClosingCost3ContributionAmount; v30.Clean = value; ClosingCost3ContributionAmount = v30;
                var v31 = ClosingCost3FundsType; v31.Clean = value; ClosingCost3FundsType = v31;
                var v32 = ClosingCost3FundsTypeOtherDescription; v32.Clean = value; ClosingCost3FundsTypeOtherDescription = v32;
                var v33 = ClosingCost3SourceType; v33.Clean = value; ClosingCost3SourceType = v33;
                var v34 = ClosingCost3SourceTypeOtherDescription; v34.Clean = value; ClosingCost3SourceTypeOtherDescription = v34;
                var v35 = ClosingCost4ContributionAmount; v35.Clean = value; ClosingCost4ContributionAmount = v35;
                var v36 = ClosingCost4FundsType; v36.Clean = value; ClosingCost4FundsType = v36;
                var v37 = ClosingCost4FundsTypeOtherDescription; v37.Clean = value; ClosingCost4FundsTypeOtherDescription = v37;
                var v38 = ClosingCost4SourceType; v38.Clean = value; ClosingCost4SourceType = v38;
                var v39 = ClosingCost4SourceTypeOtherDescription; v39.Clean = value; ClosingCost4SourceTypeOtherDescription = v39;
                var v40 = ClosingCostContributionAmount; v40.Clean = value; ClosingCostContributionAmount = v40;
                var v41 = ClosingCostFundsType; v41.Clean = value; ClosingCostFundsType = v41;
                var v42 = ClosingCostFundsTypeOtherDescription; v42.Clean = value; ClosingCostFundsTypeOtherDescription = v42;
                var v43 = ClosingCostSourceType; v43.Clean = value; ClosingCostSourceType = v43;
                var v44 = ClosingCostSourceTypeOtherDescription; v44.Clean = value; ClosingCostSourceTypeOtherDescription = v44;
                var v45 = CoBorrowerCountryCode; v45.Clean = value; CoBorrowerCountryCode = v45;
                var v46 = CoBorrowerMailToAddressSameasPropertyIndicator; v46.Clean = value; CoBorrowerMailToAddressSameasPropertyIndicator = v46;
                var v47 = CoBorrowerType; v47.Clean = value; CoBorrowerType = v47;
                var v48 = CondominiumProjectStatusType; v48.Clean = value; CondominiumProjectStatusType = v48;
                var v49 = ConstructionMethodType; v49.Clean = value; ConstructionMethodType = v49;
                var v50 = ConstructionMethodTypeOtherDescription; v50.Clean = value; ConstructionMethodTypeOtherDescription = v50;
                var v51 = ConstructionToPermanentClosingFeatureType; v51.Clean = value; ConstructionToPermanentClosingFeatureType = v51;
                var v52 = ConstructionToPermanentClosingType; v52.Clean = value; ConstructionToPermanentClosingType = v52;
                var v53 = ConvertibleStatusType; v53.Clean = value; ConvertibleStatusType = v53;
                var v54 = CounselingFormatType; v54.Clean = value; CounselingFormatType = v54;
                var v55 = CounselingFormatTypeOtherDescription; v55.Clean = value; CounselingFormatTypeOtherDescription = v55;
                var v56 = CounselTypeOther; v56.Clean = value; CounselTypeOther = v56;
                var v57 = CountryCode; v57.Clean = value; CountryCode = v57;
                var v58 = CreditScoreImpairmentType; v58.Clean = value; CreditScoreImpairmentType = v58;
                var v59 = CurrentAccruedInterestAmount; v59.Clean = value; CurrentAccruedInterestAmount = v59;
                var v60 = DelinquentPaymentsOverPastTwelveMonthsCount; v60.Clean = value; DelinquentPaymentsOverPastTwelveMonthsCount = v60;
                var v61 = DocumentCustodianID; v61.Clean = value; DocumentCustodianID = v61;
                var v62 = DocumentRequiredIndicator; v62.Clean = value; DocumentRequiredIndicator = v62;
                var v63 = DocumentSubmissionIndicator; v63.Clean = value; DocumentSubmissionIndicator = v63;
                var v64 = DownPaymentFundsType; v64.Clean = value; DownPaymentFundsType = v64;
                var v65 = DownPaymentOtherTypeDescription; v65.Clean = value; DownPaymentOtherTypeDescription = v65;
                var v66 = DownPaymentSourceType; v66.Clean = value; DownPaymentSourceType = v66;
                var v67 = DownPaymentSourceTypeOtherDescription; v67.Clean = value; DownPaymentSourceTypeOtherDescription = v67;
                var v68 = FannieARMIndexType; v68.Clean = value; FannieARMIndexType = v68;
                var v69 = FannieAutoUWDec; v69.Clean = value; FannieAutoUWDec = v69;
                var v70 = FannieBLTV; v70.Clean = value; FannieBLTV = v70;
                var v71 = FannieBorrowerFirstName; v71.Clean = value; FannieBorrowerFirstName = v71;
                var v72 = FannieBorrowerMiddleName; v72.Clean = value; FannieBorrowerMiddleName = v72;
                var v73 = FannieBuydownContributer; v73.Clean = value; FannieBuydownContributer = v73;
                var v74 = FannieCLTV; v74.Clean = value; FannieCLTV = v74;
                var v75 = FannieCoBorrowerFirstName; v75.Clean = value; FannieCoBorrowerFirstName = v75;
                var v76 = FannieCoBorrowerMiddleName; v76.Clean = value; FannieCoBorrowerMiddleName = v76;
                var v77 = FannieCreditScoreProviderName; v77.Clean = value; FannieCreditScoreProviderName = v77;
                var v78 = FannieFloodSpecialFeatureCode; v78.Clean = value; FannieFloodSpecialFeatureCode = v78;
                var v79 = FannieHCLTV; v79.Clean = value; FannieHCLTV = v79;
                var v80 = FannieInvestorOwnershipPercent; v80.Clean = value; FannieInvestorOwnershipPercent = v80;
                var v81 = FannieLegalEntityType; v81.Clean = value; FannieLegalEntityType = v81;
                var v82 = FannieLegalEntityTypeOther; v82.Clean = value; FannieLegalEntityTypeOther = v82;
                var v83 = FannieLenderPaidMIInterestRateAdjustmentPercent; v83.Clean = value; FannieLenderPaidMIInterestRateAdjustmentPercent = v83;
                var v84 = FannieLoanProgramIdentifier; v84.Clean = value; FannieLoanProgramIdentifier = v84;
                var v85 = FannieLTV; v85.Clean = value; FannieLTV = v85;
                var v86 = FannieMICompanyNameTypeOther; v86.Clean = value; FannieMICompanyNameTypeOther = v86;
                var v87 = FannieMICoveragePercent; v87.Clean = value; FannieMICoveragePercent = v87;
                var v88 = FanniePoolOwnershipPercent; v88.Clean = value; FanniePoolOwnershipPercent = v88;
                var v89 = FannieProjectClassificationType; v89.Clean = value; FannieProjectClassificationType = v89;
                var v90 = FanniePropertyFormType; v90.Clean = value; FanniePropertyFormType = v90;
                var v91 = FannieRateSpread; v91.Clean = value; FannieRateSpread = v91;
                var v92 = FannieRefinanceType; v92.Clean = value; FannieRefinanceType = v92;
                var v93 = FannieRelatedInvestorLoanID; v93.Clean = value; FannieRelatedInvestorLoanID = v93;
                var v94 = FannieRelatedLoanAmortizationType; v94.Clean = value; FannieRelatedLoanAmortizationType = v94;
                var v95 = FannieRelatedLoanLienPosition; v95.Clean = value; FannieRelatedLoanLienPosition = v95;
                var v96 = FannieRelatedLoanType; v96.Clean = value; FannieRelatedLoanType = v96;
                var v97 = FannieSectionOfAct; v97.Clean = value; FannieSectionOfAct = v97;
                var v98 = FannieTLTV; v98.Clean = value; FannieTLTV = v98;
                var v99 = FannieTrustName; v99.Clean = value; FannieTrustName = v99;
                var v100 = FannnieMortgageType; v100.Clean = value; FannnieMortgageType = v100;
                var v101 = FinancedUnitCount; v101.Clean = value; FinancedUnitCount = v101;
                var v102 = FirstRateChangePaymentEffectiveDate; v102.Clean = value; FirstRateChangePaymentEffectiveDate = v102;
                var v103 = FNMHomeImprovementProductType; v103.Clean = value; FNMHomeImprovementProductType = v103;
                var v104 = FreddieARMIndexType; v104.Clean = value; FreddieARMIndexType = v104;
                var v105 = FreddieAutoUWDec; v105.Clean = value; FreddieAutoUWDec = v105;
                var v106 = FreddieAVMModelNameTypeExpl; v106.Clean = value; FreddieAVMModelNameTypeExpl = v106;
                var v107 = FreddieBorrowerAlienStatus; v107.Clean = value; FreddieBorrowerAlienStatus = v107;
                var v108 = FreddieCoBorrowerAlienStatus; v108.Clean = value; FreddieCoBorrowerAlienStatus = v108;
                var v109 = FreddieCreditScoreProviderName; v109.Clean = value; FreddieCreditScoreProviderName = v109;
                var v110 = FreddieDownPaymentType; v110.Clean = value; FreddieDownPaymentType = v110;
                var v111 = FreddieDownPmt2SourceType; v111.Clean = value; FreddieDownPmt2SourceType = v111;
                var v112 = FreddieDownPmt2SourceTypeExpl; v112.Clean = value; FreddieDownPmt2SourceTypeExpl = v112;
                var v113 = FreddieDownPmt2Type; v113.Clean = value; FreddieDownPmt2Type = v113;
                var v114 = FreddieDownPmt2TypeExpl; v114.Clean = value; FreddieDownPmt2TypeExpl = v114;
                var v115 = FreddieDownPmt3Amt; v115.Clean = value; FreddieDownPmt3Amt = v115;
                var v116 = FreddieDownPmt3SourceType; v116.Clean = value; FreddieDownPmt3SourceType = v116;
                var v117 = FreddieDownPmt3SourceTypeExpl; v117.Clean = value; FreddieDownPmt3SourceTypeExpl = v117;
                var v118 = FreddieDownPmt3Type; v118.Clean = value; FreddieDownPmt3Type = v118;
                var v119 = FreddieDownPmt3TypeExpl; v119.Clean = value; FreddieDownPmt3TypeExpl = v119;
                var v120 = FreddieDownPmt4Amt; v120.Clean = value; FreddieDownPmt4Amt = v120;
                var v121 = FreddieDownPmt4SourceType; v121.Clean = value; FreddieDownPmt4SourceType = v121;
                var v122 = FreddieDownPmt4SourceTypeExpl; v122.Clean = value; FreddieDownPmt4SourceTypeExpl = v122;
                var v123 = FreddieDownPmt4Type; v123.Clean = value; FreddieDownPmt4Type = v123;
                var v124 = FreddieDownPmt4TypeExpl; v124.Clean = value; FreddieDownPmt4TypeExpl = v124;
                var v125 = FreddieExplanationOfDownPayment; v125.Clean = value; FreddieExplanationOfDownPayment = v125;
                var v126 = FreddieInvestorCollateralProgramIdentifier; v126.Clean = value; FreddieInvestorCollateralProgramIdentifier = v126;
                var v127 = FreddieInvestorFeatureIdentifier; v127.Clean = value; FreddieInvestorFeatureIdentifier = v127;
                var v128 = FreddieLegalEntityType; v128.Clean = value; FreddieLegalEntityType = v128;
                var v129 = FreddieLegalEntityTypeOther; v129.Clean = value; FreddieLegalEntityTypeOther = v129;
                var v130 = FreddieLoanProgramIdentifier; v130.Clean = value; FreddieLoanProgramIdentifier = v130;
                var v131 = FreddieLoanTypePublicAndIndianHousingIndicator; v131.Clean = value; FreddieLoanTypePublicAndIndianHousingIndicator = v131;
                var v132 = FreddieMICompanyNameTypeOther; v132.Clean = value; FreddieMICompanyNameTypeOther = v132;
                var v133 = FreddieMortgageType; v133.Clean = value; FreddieMortgageType = v133;
                var v134 = FreddieProjectClassificationType; v134.Clean = value; FreddieProjectClassificationType = v134;
                var v135 = FreddiePropertyFormType; v135.Clean = value; FreddiePropertyFormType = v135;
                var v136 = FreddieRefinanceCashOutDeterminationType; v136.Clean = value; FreddieRefinanceCashOutDeterminationType = v136;
                var v137 = FreddieRefinanceType; v137.Clean = value; FreddieRefinanceType = v137;
                var v138 = FreddieRelatedClosedEndSecondIndicator; v138.Clean = value; FreddieRelatedClosedEndSecondIndicator = v138;
                var v139 = FreddieRelatedInvestorLoanID; v139.Clean = value; FreddieRelatedInvestorLoanID = v139;
                var v140 = FreddieRelatedLoanInvestorType; v140.Clean = value; FreddieRelatedLoanInvestorType = v140;
                var v141 = FreddieRelatedLoanLienPosition; v141.Clean = value; FreddieRelatedLoanLienPosition = v141;
                var v142 = FreddieRelatedLoanType; v142.Clean = value; FreddieRelatedLoanType = v142;
                var v143 = FreddieSectionOfAct; v143.Clean = value; FreddieSectionOfAct = v143;
                var v144 = FreddieUnderwritingTypeOther; v144.Clean = value; FreddieUnderwritingTypeOther = v144;
                var v145 = GinnieConstructionMethodType; v145.Clean = value; GinnieConstructionMethodType = v145;
                var v146 = GinnieGovernmentAnnualPremiumAmount; v146.Clean = value; GinnieGovernmentAnnualPremiumAmount = v146;
                var v147 = GinnieMortgageType; v147.Clean = value; GinnieMortgageType = v147;
                var v148 = GinnieOtherConstructionMethodType; v148.Clean = value; GinnieOtherConstructionMethodType = v148;
                var v149 = GovernmentAnnualPremiumPercent; v149.Clean = value; GovernmentAnnualPremiumPercent = v149;
                var v150 = GovernmentRefinanceType; v150.Clean = value; GovernmentRefinanceType = v150;
                var v151 = GovernmentUpfrontPremiumAmount; v151.Clean = value; GovernmentUpfrontPremiumAmount = v151;
                var v152 = GovernmentUpfrontPremiumPercent; v152.Clean = value; GovernmentUpfrontPremiumPercent = v152;
                var v153 = GSEProjectType; v153.Clean = value; GSEProjectType = v153;
                var v154 = GuaranteeFeeAddOnIndicator; v154.Clean = value; GuaranteeFeeAddOnIndicator = v154;
                var v155 = GuarantyFeeAfterAlternatePaymentMethodPercent; v155.Clean = value; GuarantyFeeAfterAlternatePaymentMethodPercent = v155;
                var v156 = GuarantyFeePercent; v156.Clean = value; GuarantyFeePercent = v156;
                var v157 = GuarantyPercent; v157.Clean = value; GuarantyPercent = v157;
                var v158 = Id; v158.Clean = value; Id = v158;
                var v159 = IndexType; v159.Clean = value; IndexType = v159;
                var v160 = InitialFixedPeriodEffectiveMonthsCount; v160.Clean = value; InitialFixedPeriodEffectiveMonthsCount = v160;
                var v161 = InterestAccrualType; v161.Clean = value; InterestAccrualType = v161;
                var v162 = InterestAndPaymentAdjustmentIndexLeadDaysCount; v162.Clean = value; InterestAndPaymentAdjustmentIndexLeadDaysCount = v162;
                var v163 = InterestCalculationBasisType; v163.Clean = value; InterestCalculationBasisType = v163;
                var v164 = InterestCalculationEffectiveMonthsCount; v164.Clean = value; InterestCalculationEffectiveMonthsCount = v164;
                var v165 = InterestCalculationType; v165.Clean = value; InterestCalculationType = v165;
                var v166 = InvestorCollateralProgramIdentifier; v166.Clean = value; InvestorCollateralProgramIdentifier = v166;
                var v167 = InvestorCommitmentIdentifier; v167.Clean = value; InvestorCommitmentIdentifier = v167;
                var v168 = InvestorFeatureIdentifier; v168.Clean = value; InvestorFeatureIdentifier = v168;
                var v169 = InvestorFeatureIdPool; v169.Clean = value; InvestorFeatureIdPool = v169;
                var v170 = InvestorOwnershipPercent; v170.Clean = value; InvestorOwnershipPercent = v170;
                var v171 = InvestorProductPlanIdentifier; v171.Clean = value; InvestorProductPlanIdentifier = v171;
                var v172 = InvestorRemittanceDay; v172.Clean = value; InvestorRemittanceDay = v172;
                var v173 = InvestorRemittanceType; v173.Clean = value; InvestorRemittanceType = v173;
                var v174 = IssuerIdentifier; v174.Clean = value; IssuerIdentifier = v174;
                var v175 = LastPaidInstallmentDueDate; v175.Clean = value; LastPaidInstallmentDueDate = v175;
                var v176 = LastPaymentReceivedDate; v176.Clean = value; LastPaymentReceivedDate = v176;
                var v177 = LatestConversionEffectiveDate; v177.Clean = value; LatestConversionEffectiveDate = v177;
                var v178 = LenderPaidMIInterestRateAdjustmentPercent; v178.Clean = value; LenderPaidMIInterestRateAdjustmentPercent = v178;
                var v179 = LendersDeliveryDate; v179.Clean = value; LendersDeliveryDate = v179;
                var v180 = LoanAcquisitionScheduledUPBAmount; v180.Clean = value; LoanAcquisitionScheduledUPBAmount = v180;
                var v181 = LoanAmortizationMaximumTermMonthsCount; v181.Clean = value; LoanAmortizationMaximumTermMonthsCount = v181;
                var v182 = LoanBuyupBuydownBasisPointNumber; v182.Clean = value; LoanBuyupBuydownBasisPointNumber = v182;
                var v183 = LoanBuyupBuydownType; v183.Clean = value; LoanBuyupBuydownType = v183;
                var v184 = LoanDefaultLossPartyType; v184.Clean = value; LoanDefaultLossPartyType = v184;
                var v185 = LoanDeliveredThroughServicingReleasedProcessIndicator; v185.Clean = value; LoanDeliveredThroughServicingReleasedProcessIndicator = v185;
                var v186 = LoanIdentifierValueType; v186.Clean = value; LoanIdentifierValueType = v186;
                var v187 = LoanInterestAccrualStartDate; v187.Clean = value; LoanInterestAccrualStartDate = v187;
                var v188 = LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator; v188.Clean = value; LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator = v188;
                var v189 = LoanLevelCreditScoreSelectionMethodType; v189.Clean = value; LoanLevelCreditScoreSelectionMethodType = v189;
                var v190 = LoanLevelCreditScoreValue; v190.Clean = value; LoanLevelCreditScoreValue = v190;
                var v191 = LoanModificationEffectiveDate; v191.Clean = value; LoanModificationEffectiveDate = v191;
                var v192 = LoanStateDate; v192.Clean = value; LoanStateDate = v192;
                var v193 = ManufacturedHomeWidthType; v193.Clean = value; ManufacturedHomeWidthType = v193;
                var v194 = MBSWeightedMarginIndicator; v194.Clean = value; MBSWeightedMarginIndicator = v194;
                var v195 = MERSOriginalMortgageeOfRecordIndicator; v195.Clean = value; MERSOriginalMortgageeOfRecordIndicator = v195;
                var v196 = MICompanyNameType; v196.Clean = value; MICompanyNameType = v196;
                var v197 = MIPremiumSourceType; v197.Clean = value; MIPremiumSourceType = v197;
                var v198 = MonetaryEventAppliedDate; v198.Clean = value; MonetaryEventAppliedDate = v198;
                var v199 = MonetaryEventGrossPrincipalAmount; v199.Clean = value; MonetaryEventGrossPrincipalAmount = v199;
                var v200 = MonetaryEventType; v200.Clean = value; MonetaryEventType = v200;
                var v201 = MortgageBackedSecurityIndicator; v201.Clean = value; MortgageBackedSecurityIndicator = v201;
                var v202 = MortgageModificationIndicator; v202.Clean = value; MortgageModificationIndicator = v202;
                var v203 = MortgageOriginator; v203.Clean = value; MortgageOriginator = v203;
                var v204 = MortgageProgramType; v204.Clean = value; MortgageProgramType = v204;
                var v205 = MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator; v205.Clean = value; MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator = v205;
                var v206 = NextRateAdjustmentEffectiveDate; v206.Clean = value; NextRateAdjustmentEffectiveDate = v206;
                var v207 = NotePayToName; v207.Clean = value; NotePayToName = v207;
                var v208 = NumberOfUnitsSold; v208.Clean = value; NumberOfUnitsSold = v208;
                var v209 = OtherDownPaymentFundsType; v209.Clean = value; OtherDownPaymentFundsType = v209;
                var v210 = OtherFundsCollectedAtClosingAmount; v210.Clean = value; OtherFundsCollectedAtClosingAmount = v210;
                var v211 = OtherFundsCollectedAtClosingType; v211.Clean = value; OtherFundsCollectedAtClosingType = v211;
                var v212 = PayeeID; v212.Clean = value; PayeeID = v212;
                var v213 = PaymentBillingStatementLeadDaysCount; v213.Clean = value; PaymentBillingStatementLeadDaysCount = v213;
                var v214 = PerChangeMaximumDecreaseRatePercent; v214.Clean = value; PerChangeMaximumDecreaseRatePercent = v214;
                var v215 = PerChangeMaximumIncreaseRatePercent; v215.Clean = value; PerChangeMaximumIncreaseRatePercent = v215;
                var v216 = PerChangePrincipalAndInterestPaymentAdjustmentPercent; v216.Clean = value; PerChangePrincipalAndInterestPaymentAdjustmentPercent = v216;
                var v217 = PerChangeRateAdjustmentEffectiveDate; v217.Clean = value; PerChangeRateAdjustmentEffectiveDate = v217;
                var v218 = PerChangeRateAdjustmentFrequencyMonthsCount; v218.Clean = value; PerChangeRateAdjustmentFrequencyMonthsCount = v218;
                var v219 = PoolAccrualRateStructureType; v219.Clean = value; PoolAccrualRateStructureType = v219;
                var v220 = PoolAmortizationType; v220.Clean = value; PoolAmortizationType = v220;
                var v221 = PoolAssumabilityIndicator; v221.Clean = value; PoolAssumabilityIndicator = v221;
                var v222 = PoolBalloonIndicator; v222.Clean = value; PoolBalloonIndicator = v222;
                var v223 = PoolCertificatePaymentDate; v223.Clean = value; PoolCertificatePaymentDate = v223;
                var v224 = PoolClassType; v224.Clean = value; PoolClassType = v224;
                var v225 = PoolConcurrentTransferIndicator; v225.Clean = value; PoolConcurrentTransferIndicator = v225;
                var v226 = PoolCurrentLoanCount; v226.Clean = value; PoolCurrentLoanCount = v226;
                var v227 = PoolCurrentPrincipalBalanceAmount; v227.Clean = value; PoolCurrentPrincipalBalanceAmount = v227;
                var v228 = PoolDocumentCustodianID; v228.Clean = value; PoolDocumentCustodianID = v228;
                var v229 = PoolFixedServicingFeePercent; v229.Clean = value; PoolFixedServicingFeePercent = v229;
                var v230 = PoolIdentifier; v230.Clean = value; PoolIdentifier = v230;
                var v231 = PoolingMethodType; v231.Clean = value; PoolingMethodType = v231;
                var v232 = PoolInterestAdjustmentEffectiveDate; v232.Clean = value; PoolInterestAdjustmentEffectiveDate = v232;
                var v233 = PoolInterestAdjustmentIndexLeadDaysCount; v233.Clean = value; PoolInterestAdjustmentIndexLeadDaysCount = v233;
                var v234 = PoolInterestAndPaymentAdjustmentIndexLeadDaysCount; v234.Clean = value; PoolInterestAndPaymentAdjustmentIndexLeadDaysCount = v234;
                var v235 = PoolInterestOnlyIndicator; v235.Clean = value; PoolInterestOnlyIndicator = v235;
                var v236 = PoolInterestRateRoundingPercent; v236.Clean = value; PoolInterestRateRoundingPercent = v236;
                var v237 = PoolInterestRateRoundingType; v237.Clean = value; PoolInterestRateRoundingType = v237;
                var v238 = PoolInvestorProductPlanIdentifier; v238.Clean = value; PoolInvestorProductPlanIdentifier = v238;
                var v239 = PoolIssueDate; v239.Clean = value; PoolIssueDate = v239;
                var v240 = PoolIssuerTransferee; v240.Clean = value; PoolIssuerTransferee = v240;
                var v241 = PoolMarginRatePercent; v241.Clean = value; PoolMarginRatePercent = v241;
                var v242 = PoolMaturityDate; v242.Clean = value; PoolMaturityDate = v242;
                var v243 = PoolMaturityPeriodCount; v243.Clean = value; PoolMaturityPeriodCount = v243;
                var v244 = PoolMaximumAccrualRatePercent; v244.Clean = value; PoolMaximumAccrualRatePercent = v244;
                var v245 = PoolMinimumAccrualRatePercent; v245.Clean = value; PoolMinimumAccrualRatePercent = v245;
                var v246 = PoolMortgageType; v246.Clean = value; PoolMortgageType = v246;
                var v247 = PoolScheduledRemittancePaymentDay; v247.Clean = value; PoolScheduledRemittancePaymentDay = v247;
                var v248 = PoolSecurityIssueDateInterestRatePercent; v248.Clean = value; PoolSecurityIssueDateInterestRatePercent = v248;
                var v249 = PoolSellerID; v249.Clean = value; PoolSellerID = v249;
                var v250 = PoolServicerID; v250.Clean = value; PoolServicerID = v250;
                var v251 = PoolStructureType; v251.Clean = value; PoolStructureType = v251;
                var v252 = PoolSuffixIdentifier; v252.Clean = value; PoolSuffixIdentifier = v252;
                var v253 = PriceLockDatetime; v253.Clean = value; PriceLockDatetime = v253;
                var v254 = PrimaryMIAbsenceReasonType; v254.Clean = value; PrimaryMIAbsenceReasonType = v254;
                var v255 = PrimaryMIAbsenceReasonTypeOtherDescription; v255.Clean = value; PrimaryMIAbsenceReasonTypeOtherDescription = v255;
                var v256 = ProjectAttachmentType; v256.Clean = value; ProjectAttachmentType = v256;
                var v257 = ProjectDesignType; v257.Clean = value; ProjectDesignType = v257;
                var v258 = ProjectUnitCount; v258.Clean = value; ProjectUnitCount = v258;
                var v259 = PropertyValuationEffectiveDate; v259.Clean = value; PropertyValuationEffectiveDate = v259;
                var v260 = PropertyValuationMethodType; v260.Clean = value; PropertyValuationMethodType = v260;
                var v261 = RefinanceCashOutAmount; v261.Clean = value; RefinanceCashOutAmount = v261;
                var v262 = RefinanceCashOutDeterminationType; v262.Clean = value; RefinanceCashOutDeterminationType = v262;
                var v263 = RelatedLoanBalloonIndicator; v263.Clean = value; RelatedLoanBalloonIndicator = v263;
                var v264 = RelatedLoanHELOCIndicator; v264.Clean = value; RelatedLoanHELOCIndicator = v264;
                var v265 = RelatedLoanIndicator; v265.Clean = value; RelatedLoanIndicator = v265;
                var v266 = RelatedLoanInvestorType; v266.Clean = value; RelatedLoanInvestorType = v266;
                var v267 = RelatedLoanMaturityPeriodCount; v267.Clean = value; RelatedLoanMaturityPeriodCount = v267;
                var v268 = RelatedLoanNoteDate; v268.Clean = value; RelatedLoanNoteDate = v268;
                var v269 = RelatedLoanScheduledFirstPaymentDate; v269.Clean = value; RelatedLoanScheduledFirstPaymentDate = v269;
                var v270 = RelatedLoanStateDateAtClosing; v270.Clean = value; RelatedLoanStateDateAtClosing = v270;
                var v271 = RelatedLoanUnpaidPrincipalBalanceAmount; v271.Clean = value; RelatedLoanUnpaidPrincipalBalanceAmount = v271;
                var v272 = RelocationLoanIndicator; v272.Clean = value; RelocationLoanIndicator = v272;
                var v273 = REOMarketingPartyType; v273.Clean = value; REOMarketingPartyType = v273;
                var v274 = SecondLienIsDeliveredIndicator; v274.Clean = value; SecondLienIsDeliveredIndicator = v274;
                var v275 = SecurityOriginalSubscriptionAmount; v275.Clean = value; SecurityOriginalSubscriptionAmount = v275;
                var v276 = SecurityTradeBookEntryDate; v276.Clean = value; SecurityTradeBookEntryDate = v276;
                var v277 = SellerID; v277.Clean = value; SellerID = v277;
                var v278 = SellerLoanIdentifier; v278.Clean = value; SellerLoanIdentifier = v278;
                var v279 = ServicerID; v279.Clean = value; ServicerID = v279;
                var v280 = ServicerLoanIdentifier; v280.Clean = value; ServicerLoanIdentifier = v280;
                var v281 = SharedEquityIndicator; v281.Clean = value; SharedEquityIndicator = v281;
                var v282 = SiteBuiltIndicator; v282.Clean = value; SiteBuiltIndicator = v282;
                var v283 = SpecialFloodHazardAreaIndicator; v283.Clean = value; SpecialFloodHazardAreaIndicator = v283;
                var v284 = SubsequentPerChangeMaximumDecreaseRatePercent; v284.Clean = value; SubsequentPerChangeMaximumDecreaseRatePercent = v284;
                var v285 = SubsequentPerChangeMaximumIncreaseRatePercent; v285.Clean = value; SubsequentPerChangeMaximumIncreaseRatePercent = v285;
                var v286 = SubsequentPerChangeRateAdjustmentEffectiveDate; v286.Clean = value; SubsequentPerChangeRateAdjustmentEffectiveDate = v286;
                var v287 = SubsequentPerChangeRateAdjustmentFrequencyMonthsCount; v287.Clean = value; SubsequentPerChangeRateAdjustmentFrequencyMonthsCount = v287;
                var v288 = TemporaryBuydownIndicator; v288.Clean = value; TemporaryBuydownIndicator = v288;
                var v289 = TotalMortgagedPropertiesCount; v289.Clean = value; TotalMortgagedPropertiesCount = v289;
                var v290 = Unit1SubjectPropertyGrossRentalIncome; v290.Clean = value; Unit1SubjectPropertyGrossRentalIncome = v290;
                var v291 = Unit1TotalBedrooms; v291.Clean = value; Unit1TotalBedrooms = v291;
                var v292 = Unit2SubjectPropertyGrossRentalIncome; v292.Clean = value; Unit2SubjectPropertyGrossRentalIncome = v292;
                var v293 = Unit2TotalBedrooms; v293.Clean = value; Unit2TotalBedrooms = v293;
                var v294 = Unit3SubjectPropertyGrossRentalIncome; v294.Clean = value; Unit3SubjectPropertyGrossRentalIncome = v294;
                var v295 = Unit3TotalBedrooms; v295.Clean = value; Unit3TotalBedrooms = v295;
                var v296 = Unit4SubjectPropertyGrossRentalIncome; v296.Clean = value; Unit4SubjectPropertyGrossRentalIncome = v296;
                var v297 = Unit4TotalBedrooms; v297.Clean = value; Unit4TotalBedrooms = v297;
                var v298 = UPBAmount; v298.Clean = value; UPBAmount = v298;
                _settingClean = 0;
            }
        }
    }
}