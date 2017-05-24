using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Uldd
    {
        private Value<string> _aCHABARoutingAndTransitIdentifier;
        public string ACHABARoutingAndTransitIdentifier { get { return _aCHABARoutingAndTransitIdentifier; } set { _aCHABARoutingAndTransitIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHABARoutingAndTransitIdentifier() => !_aCHABARoutingAndTransitIdentifier.Clean;
        private Value<string> _aCHABARoutingAndTransitNumber;
        public string ACHABARoutingAndTransitNumber { get { return _aCHABARoutingAndTransitNumber; } set { _aCHABARoutingAndTransitNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHABARoutingAndTransitNumber() => !_aCHABARoutingAndTransitNumber.Clean;
        private Value<string> _aCHBankAccountDescription;
        public string ACHBankAccountDescription { get { return _aCHBankAccountDescription; } set { _aCHBankAccountDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountDescription() => !_aCHBankAccountDescription.Clean;
        private Value<string> _aCHBankAccountIdentifier;
        public string ACHBankAccountIdentifier { get { return _aCHBankAccountIdentifier; } set { _aCHBankAccountIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountIdentifier() => !_aCHBankAccountIdentifier.Clean;
        private Value<string> _aCHBankAccountPurposeTransitIdentifier;
        public string ACHBankAccountPurposeTransitIdentifier { get { return _aCHBankAccountPurposeTransitIdentifier; } set { _aCHBankAccountPurposeTransitIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountPurposeTransitIdentifier() => !_aCHBankAccountPurposeTransitIdentifier.Clean;
        private Value<string> _aCHBankAccountPurposeType;
        public string ACHBankAccountPurposeType { get { return _aCHBankAccountPurposeType; } set { _aCHBankAccountPurposeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHBankAccountPurposeType() => !_aCHBankAccountPurposeType.Clean;
        private Value<string> _aCHInstitutionTelegraphicAbbreviationName;
        public string ACHInstitutionTelegraphicAbbreviationName { get { return _aCHInstitutionTelegraphicAbbreviationName; } set { _aCHInstitutionTelegraphicAbbreviationName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHInstitutionTelegraphicAbbreviationName() => !_aCHInstitutionTelegraphicAbbreviationName.Clean;
        private Value<string> _aCHReceiverSubaccountName;
        public string ACHReceiverSubaccountName { get { return _aCHReceiverSubaccountName; } set { _aCHReceiverSubaccountName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeACHReceiverSubaccountName() => !_aCHReceiverSubaccountName.Clean;
        private Value<bool?> _additionalPrincipalAmountIndicator;
        public bool? AdditionalPrincipalAmountIndicator { get { return _additionalPrincipalAmountIndicator; } set { _additionalPrincipalAmountIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalPrincipalAmountIndicator() => !_additionalPrincipalAmountIndicator.Clean;
        private Value<decimal?> _aggregateLoanCurtailmentAmount;
        public decimal? AggregateLoanCurtailmentAmount { get { return _aggregateLoanCurtailmentAmount; } set { _aggregateLoanCurtailmentAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAggregateLoanCurtailmentAmount() => !_aggregateLoanCurtailmentAmount.Clean;
        private Value<string> _appraisalIdentifier;
        public string AppraisalIdentifier { get { return _appraisalIdentifier; } set { _appraisalIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalIdentifier() => !_appraisalIdentifier.Clean;
        private Value<string> _attachmentType;
        public string AttachmentType { get { return _attachmentType; } set { _attachmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttachmentType() => !_attachmentType.Clean;
        private Value<string> _aVMModelNameType;
        public string AVMModelNameType { get { return _aVMModelNameType; } set { _aVMModelNameType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAVMModelNameType() => !_aVMModelNameType.Clean;
        private Value<bool?> _balloonResetIndicator;
        public bool? BalloonResetIndicator { get { return _balloonResetIndicator; } set { _balloonResetIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonResetIndicator() => !_balloonResetIndicator.Clean;
        private Value<decimal?> _baseGuarantyFeePercent;
        public decimal? BaseGuarantyFeePercent { get { return _baseGuarantyFeePercent; } set { _baseGuarantyFeePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseGuarantyFeePercent() => !_baseGuarantyFeePercent.Clean;
        private Value<string> _bondFinancePool;
        public string BondFinancePool { get { return _bondFinancePool; } set { _bondFinancePool = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinancePool() => !_bondFinancePool.Clean;
        private Value<string> _bondFinanceProgramName;
        public string BondFinanceProgramName { get { return _bondFinanceProgramName; } set { _bondFinanceProgramName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinanceProgramName() => !_bondFinanceProgramName.Clean;
        private Value<string> _bondFinanceProgramType;
        public string BondFinanceProgramType { get { return _bondFinanceProgramType; } set { _bondFinanceProgramType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBondFinanceProgramType() => !_bondFinanceProgramType.Clean;
        private Value<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get { return _borrowerMailToAddressSameasPropertyIndicator; } set { _borrowerMailToAddressSameasPropertyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerMailToAddressSameasPropertyIndicator() => !_borrowerMailToAddressSameasPropertyIndicator.Clean;
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerType() => !_borrowerType.Clean;
        private Value<bool?> _capitalizedLoanIndicator;
        public bool? CapitalizedLoanIndicator { get { return _capitalizedLoanIndicator; } set { _capitalizedLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCapitalizedLoanIndicator() => !_capitalizedLoanIndicator.Clean;
        private Value<string> _certificateIdentifier;
        public string CertificateIdentifier { get { return _certificateIdentifier; } set { _certificateIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateIdentifier() => !_certificateIdentifier.Clean;
        private Value<DateTime?> _certificateMaturityDate;
        public DateTime? CertificateMaturityDate { get { return _certificateMaturityDate; } set { _certificateMaturityDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateMaturityDate() => !_certificateMaturityDate.Clean;
        private Value<decimal?> _certificatePrincipalBalanceAmount;
        public decimal? CertificatePrincipalBalanceAmount { get { return _certificatePrincipalBalanceAmount; } set { _certificatePrincipalBalanceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificatePrincipalBalanceAmount() => !_certificatePrincipalBalanceAmount.Clean;
        private Value<string> _certificateType;
        public string CertificateType { get { return _certificateType; } set { _certificateType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateType() => !_certificateType.Clean;
        private Value<decimal?> _closingCost2ContributionAmount;
        public decimal? ClosingCost2ContributionAmount { get { return _closingCost2ContributionAmount; } set { _closingCost2ContributionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2ContributionAmount() => !_closingCost2ContributionAmount.Clean;
        private Value<string> _closingCost2FundsType;
        public string ClosingCost2FundsType { get { return _closingCost2FundsType; } set { _closingCost2FundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2FundsType() => !_closingCost2FundsType.Clean;
        private Value<string> _closingCost2FundsTypeOtherDescription;
        public string ClosingCost2FundsTypeOtherDescription { get { return _closingCost2FundsTypeOtherDescription; } set { _closingCost2FundsTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2FundsTypeOtherDescription() => !_closingCost2FundsTypeOtherDescription.Clean;
        private Value<string> _closingCost2SourceType;
        public string ClosingCost2SourceType { get { return _closingCost2SourceType; } set { _closingCost2SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2SourceType() => !_closingCost2SourceType.Clean;
        private Value<string> _closingCost2SourceTypeOtherDescription;
        public string ClosingCost2SourceTypeOtherDescription { get { return _closingCost2SourceTypeOtherDescription; } set { _closingCost2SourceTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost2SourceTypeOtherDescription() => !_closingCost2SourceTypeOtherDescription.Clean;
        private Value<decimal?> _closingCost3ContributionAmount;
        public decimal? ClosingCost3ContributionAmount { get { return _closingCost3ContributionAmount; } set { _closingCost3ContributionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3ContributionAmount() => !_closingCost3ContributionAmount.Clean;
        private Value<string> _closingCost3FundsType;
        public string ClosingCost3FundsType { get { return _closingCost3FundsType; } set { _closingCost3FundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3FundsType() => !_closingCost3FundsType.Clean;
        private Value<string> _closingCost3FundsTypeOtherDescription;
        public string ClosingCost3FundsTypeOtherDescription { get { return _closingCost3FundsTypeOtherDescription; } set { _closingCost3FundsTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3FundsTypeOtherDescription() => !_closingCost3FundsTypeOtherDescription.Clean;
        private Value<string> _closingCost3SourceType;
        public string ClosingCost3SourceType { get { return _closingCost3SourceType; } set { _closingCost3SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3SourceType() => !_closingCost3SourceType.Clean;
        private Value<string> _closingCost3SourceTypeOtherDescription;
        public string ClosingCost3SourceTypeOtherDescription { get { return _closingCost3SourceTypeOtherDescription; } set { _closingCost3SourceTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost3SourceTypeOtherDescription() => !_closingCost3SourceTypeOtherDescription.Clean;
        private Value<decimal?> _closingCost4ContributionAmount;
        public decimal? ClosingCost4ContributionAmount { get { return _closingCost4ContributionAmount; } set { _closingCost4ContributionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4ContributionAmount() => !_closingCost4ContributionAmount.Clean;
        private Value<string> _closingCost4FundsType;
        public string ClosingCost4FundsType { get { return _closingCost4FundsType; } set { _closingCost4FundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4FundsType() => !_closingCost4FundsType.Clean;
        private Value<string> _closingCost4FundsTypeOtherDescription;
        public string ClosingCost4FundsTypeOtherDescription { get { return _closingCost4FundsTypeOtherDescription; } set { _closingCost4FundsTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4FundsTypeOtherDescription() => !_closingCost4FundsTypeOtherDescription.Clean;
        private Value<string> _closingCost4SourceType;
        public string ClosingCost4SourceType { get { return _closingCost4SourceType; } set { _closingCost4SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4SourceType() => !_closingCost4SourceType.Clean;
        private Value<string> _closingCost4SourceTypeOtherDescription;
        public string ClosingCost4SourceTypeOtherDescription { get { return _closingCost4SourceTypeOtherDescription; } set { _closingCost4SourceTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost4SourceTypeOtherDescription() => !_closingCost4SourceTypeOtherDescription.Clean;
        private Value<decimal?> _closingCostContributionAmount;
        public decimal? ClosingCostContributionAmount { get { return _closingCostContributionAmount; } set { _closingCostContributionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostContributionAmount() => !_closingCostContributionAmount.Clean;
        private Value<string> _closingCostFundsType;
        public string ClosingCostFundsType { get { return _closingCostFundsType; } set { _closingCostFundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostFundsType() => !_closingCostFundsType.Clean;
        private Value<string> _closingCostFundsTypeOtherDescription;
        public string ClosingCostFundsTypeOtherDescription { get { return _closingCostFundsTypeOtherDescription; } set { _closingCostFundsTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostFundsTypeOtherDescription() => !_closingCostFundsTypeOtherDescription.Clean;
        private Value<string> _closingCostSourceType;
        public string ClosingCostSourceType { get { return _closingCostSourceType; } set { _closingCostSourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostSourceType() => !_closingCostSourceType.Clean;
        private Value<string> _closingCostSourceTypeOtherDescription;
        public string ClosingCostSourceTypeOtherDescription { get { return _closingCostSourceTypeOtherDescription; } set { _closingCostSourceTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostSourceTypeOtherDescription() => !_closingCostSourceTypeOtherDescription.Clean;
        private Value<string> _coBorrowerCountryCode;
        public string CoBorrowerCountryCode { get { return _coBorrowerCountryCode; } set { _coBorrowerCountryCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerCountryCode() => !_coBorrowerCountryCode.Clean;
        private Value<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get { return _coBorrowerMailToAddressSameasPropertyIndicator; } set { _coBorrowerMailToAddressSameasPropertyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerMailToAddressSameasPropertyIndicator() => !_coBorrowerMailToAddressSameasPropertyIndicator.Clean;
        private Value<string> _coBorrowerType;
        public string CoBorrowerType { get { return _coBorrowerType; } set { _coBorrowerType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerType() => !_coBorrowerType.Clean;
        private Value<string> _condominiumProjectStatusType;
        public string CondominiumProjectStatusType { get { return _condominiumProjectStatusType; } set { _condominiumProjectStatusType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCondominiumProjectStatusType() => !_condominiumProjectStatusType.Clean;
        private Value<string> _constructionMethodType;
        public string ConstructionMethodType { get { return _constructionMethodType; } set { _constructionMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionMethodType() => !_constructionMethodType.Clean;
        private Value<string> _constructionMethodTypeOtherDescription;
        public string ConstructionMethodTypeOtherDescription { get { return _constructionMethodTypeOtherDescription; } set { _constructionMethodTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionMethodTypeOtherDescription() => !_constructionMethodTypeOtherDescription.Clean;
        private Value<string> _constructionToPermanentClosingFeatureType;
        public string ConstructionToPermanentClosingFeatureType { get { return _constructionToPermanentClosingFeatureType; } set { _constructionToPermanentClosingFeatureType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionToPermanentClosingFeatureType() => !_constructionToPermanentClosingFeatureType.Clean;
        private Value<string> _constructionToPermanentClosingType;
        public string ConstructionToPermanentClosingType { get { return _constructionToPermanentClosingType; } set { _constructionToPermanentClosingType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionToPermanentClosingType() => !_constructionToPermanentClosingType.Clean;
        private Value<string> _convertibleStatusType;
        public string ConvertibleStatusType { get { return _convertibleStatusType; } set { _convertibleStatusType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleStatusType() => !_convertibleStatusType.Clean;
        private Value<string> _counselingFormatType;
        public string CounselingFormatType { get { return _counselingFormatType; } set { _counselingFormatType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingFormatType() => !_counselingFormatType.Clean;
        private Value<string> _counselingFormatTypeOtherDescription;
        public string CounselingFormatTypeOtherDescription { get { return _counselingFormatTypeOtherDescription; } set { _counselingFormatTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingFormatTypeOtherDescription() => !_counselingFormatTypeOtherDescription.Clean;
        private Value<string> _counselTypeOther;
        public string CounselTypeOther { get { return _counselTypeOther; } set { _counselTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselTypeOther() => !_counselTypeOther.Clean;
        private Value<string> _countryCode;
        public string CountryCode { get { return _countryCode; } set { _countryCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCountryCode() => !_countryCode.Clean;
        private Value<string> _creditScoreImpairmentType;
        public string CreditScoreImpairmentType { get { return _creditScoreImpairmentType; } set { _creditScoreImpairmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScoreImpairmentType() => !_creditScoreImpairmentType.Clean;
        private Value<decimal?> _currentAccruedInterestAmount;
        public decimal? CurrentAccruedInterestAmount { get { return _currentAccruedInterestAmount; } set { _currentAccruedInterestAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentAccruedInterestAmount() => !_currentAccruedInterestAmount.Clean;
        private Value<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get { return _delinquentPaymentsOverPastTwelveMonthsCount; } set { _delinquentPaymentsOverPastTwelveMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDelinquentPaymentsOverPastTwelveMonthsCount() => !_delinquentPaymentsOverPastTwelveMonthsCount.Clean;
        private Value<string> _documentCustodianID;
        public string DocumentCustodianID { get { return _documentCustodianID; } set { _documentCustodianID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentCustodianID() => !_documentCustodianID.Clean;
        private Value<string> _documentRequiredIndicator;
        public string DocumentRequiredIndicator { get { return _documentRequiredIndicator; } set { _documentRequiredIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentRequiredIndicator() => !_documentRequiredIndicator.Clean;
        private Value<string> _documentSubmissionIndicator;
        public string DocumentSubmissionIndicator { get { return _documentSubmissionIndicator; } set { _documentSubmissionIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentSubmissionIndicator() => !_documentSubmissionIndicator.Clean;
        private Value<string> _downPaymentFundsType;
        public string DownPaymentFundsType { get { return _downPaymentFundsType; } set { _downPaymentFundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentFundsType() => !_downPaymentFundsType.Clean;
        private Value<string> _downPaymentOtherTypeDescription;
        public string DownPaymentOtherTypeDescription { get { return _downPaymentOtherTypeDescription; } set { _downPaymentOtherTypeDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentOtherTypeDescription() => !_downPaymentOtherTypeDescription.Clean;
        private Value<string> _downPaymentSourceType;
        public string DownPaymentSourceType { get { return _downPaymentSourceType; } set { _downPaymentSourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentSourceType() => !_downPaymentSourceType.Clean;
        private Value<string> _downPaymentSourceTypeOtherDescription;
        public string DownPaymentSourceTypeOtherDescription { get { return _downPaymentSourceTypeOtherDescription; } set { _downPaymentSourceTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentSourceTypeOtherDescription() => !_downPaymentSourceTypeOtherDescription.Clean;
        private Value<string> _fannieARMIndexType;
        public string FannieARMIndexType { get { return _fannieARMIndexType; } set { _fannieARMIndexType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieARMIndexType() => !_fannieARMIndexType.Clean;
        private Value<string> _fannieAutoUWDec;
        public string FannieAutoUWDec { get { return _fannieAutoUWDec; } set { _fannieAutoUWDec = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieAutoUWDec() => !_fannieAutoUWDec.Clean;
        private Value<int?> _fannieBLTV;
        public int? FannieBLTV { get { return _fannieBLTV; } set { _fannieBLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBLTV() => !_fannieBLTV.Clean;
        private Value<string> _fannieBorrowerFirstName;
        public string FannieBorrowerFirstName { get { return _fannieBorrowerFirstName; } set { _fannieBorrowerFirstName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBorrowerFirstName() => !_fannieBorrowerFirstName.Clean;
        private Value<string> _fannieBorrowerMiddleName;
        public string FannieBorrowerMiddleName { get { return _fannieBorrowerMiddleName; } set { _fannieBorrowerMiddleName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBorrowerMiddleName() => !_fannieBorrowerMiddleName.Clean;
        private Value<string> _fannieBuydownContributer;
        public string FannieBuydownContributer { get { return _fannieBuydownContributer; } set { _fannieBuydownContributer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieBuydownContributer() => !_fannieBuydownContributer.Clean;
        private Value<int?> _fannieCLTV;
        public int? FannieCLTV { get { return _fannieCLTV; } set { _fannieCLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCLTV() => !_fannieCLTV.Clean;
        private Value<string> _fannieCoBorrowerFirstName;
        public string FannieCoBorrowerFirstName { get { return _fannieCoBorrowerFirstName; } set { _fannieCoBorrowerFirstName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCoBorrowerFirstName() => !_fannieCoBorrowerFirstName.Clean;
        private Value<string> _fannieCoBorrowerMiddleName;
        public string FannieCoBorrowerMiddleName { get { return _fannieCoBorrowerMiddleName; } set { _fannieCoBorrowerMiddleName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCoBorrowerMiddleName() => !_fannieCoBorrowerMiddleName.Clean;
        private Value<string> _fannieCreditScoreProviderName;
        public string FannieCreditScoreProviderName { get { return _fannieCreditScoreProviderName; } set { _fannieCreditScoreProviderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieCreditScoreProviderName() => !_fannieCreditScoreProviderName.Clean;
        private Value<string> _fannieFloodSpecialFeatureCode;
        public string FannieFloodSpecialFeatureCode { get { return _fannieFloodSpecialFeatureCode; } set { _fannieFloodSpecialFeatureCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieFloodSpecialFeatureCode() => !_fannieFloodSpecialFeatureCode.Clean;
        private Value<int?> _fannieHCLTV;
        public int? FannieHCLTV { get { return _fannieHCLTV; } set { _fannieHCLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieHCLTV() => !_fannieHCLTV.Clean;
        private Value<int?> _fannieInvestorOwnershipPercent;
        public int? FannieInvestorOwnershipPercent { get { return _fannieInvestorOwnershipPercent; } set { _fannieInvestorOwnershipPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieInvestorOwnershipPercent() => !_fannieInvestorOwnershipPercent.Clean;
        private Value<string> _fannieLegalEntityType;
        public string FannieLegalEntityType { get { return _fannieLegalEntityType; } set { _fannieLegalEntityType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLegalEntityType() => !_fannieLegalEntityType.Clean;
        private Value<string> _fannieLegalEntityTypeOther;
        public string FannieLegalEntityTypeOther { get { return _fannieLegalEntityTypeOther; } set { _fannieLegalEntityTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLegalEntityTypeOther() => !_fannieLegalEntityTypeOther.Clean;
        private Value<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get { return _fannieLenderPaidMIInterestRateAdjustmentPercent; } set { _fannieLenderPaidMIInterestRateAdjustmentPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLenderPaidMIInterestRateAdjustmentPercent() => !_fannieLenderPaidMIInterestRateAdjustmentPercent.Clean;
        private Value<string> _fannieLoanProgramIdentifier;
        public string FannieLoanProgramIdentifier { get { return _fannieLoanProgramIdentifier; } set { _fannieLoanProgramIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLoanProgramIdentifier() => !_fannieLoanProgramIdentifier.Clean;
        private Value<int?> _fannieLTV;
        public int? FannieLTV { get { return _fannieLTV; } set { _fannieLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieLTV() => !_fannieLTV.Clean;
        private Value<string> _fannieMICompanyNameTypeOther;
        public string FannieMICompanyNameTypeOther { get { return _fannieMICompanyNameTypeOther; } set { _fannieMICompanyNameTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieMICompanyNameTypeOther() => !_fannieMICompanyNameTypeOther.Clean;
        private Value<int?> _fannieMICoveragePercent;
        public int? FannieMICoveragePercent { get { return _fannieMICoveragePercent; } set { _fannieMICoveragePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieMICoveragePercent() => !_fannieMICoveragePercent.Clean;
        private Value<int?> _fanniePoolOwnershipPercent;
        public int? FanniePoolOwnershipPercent { get { return _fanniePoolOwnershipPercent; } set { _fanniePoolOwnershipPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFanniePoolOwnershipPercent() => !_fanniePoolOwnershipPercent.Clean;
        private Value<string> _fannieProjectClassificationType;
        public string FannieProjectClassificationType { get { return _fannieProjectClassificationType; } set { _fannieProjectClassificationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieProjectClassificationType() => !_fannieProjectClassificationType.Clean;
        private Value<string> _fanniePropertyFormType;
        public string FanniePropertyFormType { get { return _fanniePropertyFormType; } set { _fanniePropertyFormType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFanniePropertyFormType() => !_fanniePropertyFormType.Clean;
        private Value<decimal?> _fannieRateSpread;
        public decimal? FannieRateSpread { get { return _fannieRateSpread; } set { _fannieRateSpread = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRateSpread() => !_fannieRateSpread.Clean;
        private Value<string> _fannieRefinanceType;
        public string FannieRefinanceType { get { return _fannieRefinanceType; } set { _fannieRefinanceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRefinanceType() => !_fannieRefinanceType.Clean;
        private Value<string> _fannieRelatedInvestorLoanID;
        public string FannieRelatedInvestorLoanID { get { return _fannieRelatedInvestorLoanID; } set { _fannieRelatedInvestorLoanID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedInvestorLoanID() => !_fannieRelatedInvestorLoanID.Clean;
        private Value<string> _fannieRelatedLoanAmortizationType;
        public string FannieRelatedLoanAmortizationType { get { return _fannieRelatedLoanAmortizationType; } set { _fannieRelatedLoanAmortizationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanAmortizationType() => !_fannieRelatedLoanAmortizationType.Clean;
        private Value<string> _fannieRelatedLoanLienPosition;
        public string FannieRelatedLoanLienPosition { get { return _fannieRelatedLoanLienPosition; } set { _fannieRelatedLoanLienPosition = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanLienPosition() => !_fannieRelatedLoanLienPosition.Clean;
        private Value<string> _fannieRelatedLoanType;
        public string FannieRelatedLoanType { get { return _fannieRelatedLoanType; } set { _fannieRelatedLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieRelatedLoanType() => !_fannieRelatedLoanType.Clean;
        private Value<string> _fannieSectionOfAct;
        public string FannieSectionOfAct { get { return _fannieSectionOfAct; } set { _fannieSectionOfAct = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieSectionOfAct() => !_fannieSectionOfAct.Clean;
        private Value<int?> _fannieTLTV;
        public int? FannieTLTV { get { return _fannieTLTV; } set { _fannieTLTV = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieTLTV() => !_fannieTLTV.Clean;
        private Value<string> _fannieTrustName;
        public string FannieTrustName { get { return _fannieTrustName; } set { _fannieTrustName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieTrustName() => !_fannieTrustName.Clean;
        private Value<string> _fannnieMortgageType;
        public string FannnieMortgageType { get { return _fannnieMortgageType; } set { _fannnieMortgageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannnieMortgageType() => !_fannnieMortgageType.Clean;
        private Value<int?> _financedUnitCount;
        public int? FinancedUnitCount { get { return _financedUnitCount; } set { _financedUnitCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedUnitCount() => !_financedUnitCount.Clean;
        private Value<DateTime?> _firstRateChangePaymentEffectiveDate;
        public DateTime? FirstRateChangePaymentEffectiveDate { get { return _firstRateChangePaymentEffectiveDate; } set { _firstRateChangePaymentEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstRateChangePaymentEffectiveDate() => !_firstRateChangePaymentEffectiveDate.Clean;
        private Value<string> _fNMHomeImprovementProductType;
        public string FNMHomeImprovementProductType { get { return _fNMHomeImprovementProductType; } set { _fNMHomeImprovementProductType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFNMHomeImprovementProductType() => !_fNMHomeImprovementProductType.Clean;
        private Value<string> _freddieARMIndexType;
        public string FreddieARMIndexType { get { return _freddieARMIndexType; } set { _freddieARMIndexType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieARMIndexType() => !_freddieARMIndexType.Clean;
        private Value<string> _freddieAutoUWDec;
        public string FreddieAutoUWDec { get { return _freddieAutoUWDec; } set { _freddieAutoUWDec = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieAutoUWDec() => !_freddieAutoUWDec.Clean;
        private Value<string> _freddieAVMModelNameTypeExpl;
        public string FreddieAVMModelNameTypeExpl { get { return _freddieAVMModelNameTypeExpl; } set { _freddieAVMModelNameTypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieAVMModelNameTypeExpl() => !_freddieAVMModelNameTypeExpl.Clean;
        private Value<string> _freddieBorrowerAlienStatus;
        public string FreddieBorrowerAlienStatus { get { return _freddieBorrowerAlienStatus; } set { _freddieBorrowerAlienStatus = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieBorrowerAlienStatus() => !_freddieBorrowerAlienStatus.Clean;
        private Value<string> _freddieCoBorrowerAlienStatus;
        public string FreddieCoBorrowerAlienStatus { get { return _freddieCoBorrowerAlienStatus; } set { _freddieCoBorrowerAlienStatus = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieCoBorrowerAlienStatus() => !_freddieCoBorrowerAlienStatus.Clean;
        private Value<string> _freddieCreditScoreProviderName;
        public string FreddieCreditScoreProviderName { get { return _freddieCreditScoreProviderName; } set { _freddieCreditScoreProviderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieCreditScoreProviderName() => !_freddieCreditScoreProviderName.Clean;
        private Value<string> _freddieDownPaymentType;
        public string FreddieDownPaymentType { get { return _freddieDownPaymentType; } set { _freddieDownPaymentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPaymentType() => !_freddieDownPaymentType.Clean;
        private Value<string> _freddieDownPmt2SourceType;
        public string FreddieDownPmt2SourceType { get { return _freddieDownPmt2SourceType; } set { _freddieDownPmt2SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2SourceType() => !_freddieDownPmt2SourceType.Clean;
        private Value<string> _freddieDownPmt2SourceTypeExpl;
        public string FreddieDownPmt2SourceTypeExpl { get { return _freddieDownPmt2SourceTypeExpl; } set { _freddieDownPmt2SourceTypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2SourceTypeExpl() => !_freddieDownPmt2SourceTypeExpl.Clean;
        private Value<string> _freddieDownPmt2Type;
        public string FreddieDownPmt2Type { get { return _freddieDownPmt2Type; } set { _freddieDownPmt2Type = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2Type() => !_freddieDownPmt2Type.Clean;
        private Value<string> _freddieDownPmt2TypeExpl;
        public string FreddieDownPmt2TypeExpl { get { return _freddieDownPmt2TypeExpl; } set { _freddieDownPmt2TypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt2TypeExpl() => !_freddieDownPmt2TypeExpl.Clean;
        private Value<decimal?> _freddieDownPmt3Amt;
        public decimal? FreddieDownPmt3Amt { get { return _freddieDownPmt3Amt; } set { _freddieDownPmt3Amt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3Amt() => !_freddieDownPmt3Amt.Clean;
        private Value<string> _freddieDownPmt3SourceType;
        public string FreddieDownPmt3SourceType { get { return _freddieDownPmt3SourceType; } set { _freddieDownPmt3SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3SourceType() => !_freddieDownPmt3SourceType.Clean;
        private Value<string> _freddieDownPmt3SourceTypeExpl;
        public string FreddieDownPmt3SourceTypeExpl { get { return _freddieDownPmt3SourceTypeExpl; } set { _freddieDownPmt3SourceTypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3SourceTypeExpl() => !_freddieDownPmt3SourceTypeExpl.Clean;
        private Value<string> _freddieDownPmt3Type;
        public string FreddieDownPmt3Type { get { return _freddieDownPmt3Type; } set { _freddieDownPmt3Type = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3Type() => !_freddieDownPmt3Type.Clean;
        private Value<string> _freddieDownPmt3TypeExpl;
        public string FreddieDownPmt3TypeExpl { get { return _freddieDownPmt3TypeExpl; } set { _freddieDownPmt3TypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt3TypeExpl() => !_freddieDownPmt3TypeExpl.Clean;
        private Value<decimal?> _freddieDownPmt4Amt;
        public decimal? FreddieDownPmt4Amt { get { return _freddieDownPmt4Amt; } set { _freddieDownPmt4Amt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4Amt() => !_freddieDownPmt4Amt.Clean;
        private Value<string> _freddieDownPmt4SourceType;
        public string FreddieDownPmt4SourceType { get { return _freddieDownPmt4SourceType; } set { _freddieDownPmt4SourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4SourceType() => !_freddieDownPmt4SourceType.Clean;
        private Value<string> _freddieDownPmt4SourceTypeExpl;
        public string FreddieDownPmt4SourceTypeExpl { get { return _freddieDownPmt4SourceTypeExpl; } set { _freddieDownPmt4SourceTypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4SourceTypeExpl() => !_freddieDownPmt4SourceTypeExpl.Clean;
        private Value<string> _freddieDownPmt4Type;
        public string FreddieDownPmt4Type { get { return _freddieDownPmt4Type; } set { _freddieDownPmt4Type = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4Type() => !_freddieDownPmt4Type.Clean;
        private Value<string> _freddieDownPmt4TypeExpl;
        public string FreddieDownPmt4TypeExpl { get { return _freddieDownPmt4TypeExpl; } set { _freddieDownPmt4TypeExpl = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieDownPmt4TypeExpl() => !_freddieDownPmt4TypeExpl.Clean;
        private Value<string> _freddieExplanationOfDownPayment;
        public string FreddieExplanationOfDownPayment { get { return _freddieExplanationOfDownPayment; } set { _freddieExplanationOfDownPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieExplanationOfDownPayment() => !_freddieExplanationOfDownPayment.Clean;
        private Value<string> _freddieInvestorCollateralProgramIdentifier;
        public string FreddieInvestorCollateralProgramIdentifier { get { return _freddieInvestorCollateralProgramIdentifier; } set { _freddieInvestorCollateralProgramIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieInvestorCollateralProgramIdentifier() => !_freddieInvestorCollateralProgramIdentifier.Clean;
        private Value<string> _freddieInvestorFeatureIdentifier;
        public string FreddieInvestorFeatureIdentifier { get { return _freddieInvestorFeatureIdentifier; } set { _freddieInvestorFeatureIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieInvestorFeatureIdentifier() => !_freddieInvestorFeatureIdentifier.Clean;
        private Value<string> _freddieLegalEntityType;
        public string FreddieLegalEntityType { get { return _freddieLegalEntityType; } set { _freddieLegalEntityType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLegalEntityType() => !_freddieLegalEntityType.Clean;
        private Value<string> _freddieLegalEntityTypeOther;
        public string FreddieLegalEntityTypeOther { get { return _freddieLegalEntityTypeOther; } set { _freddieLegalEntityTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLegalEntityTypeOther() => !_freddieLegalEntityTypeOther.Clean;
        private Value<string> _freddieLoanProgramIdentifier;
        public string FreddieLoanProgramIdentifier { get { return _freddieLoanProgramIdentifier; } set { _freddieLoanProgramIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLoanProgramIdentifier() => !_freddieLoanProgramIdentifier.Clean;
        private Value<string> _freddieLoanTypePublicAndIndianHousingIndicator;
        public string FreddieLoanTypePublicAndIndianHousingIndicator { get { return _freddieLoanTypePublicAndIndianHousingIndicator; } set { _freddieLoanTypePublicAndIndianHousingIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLoanTypePublicAndIndianHousingIndicator() => !_freddieLoanTypePublicAndIndianHousingIndicator.Clean;
        private Value<string> _freddieMICompanyNameTypeOther;
        public string FreddieMICompanyNameTypeOther { get { return _freddieMICompanyNameTypeOther; } set { _freddieMICompanyNameTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMICompanyNameTypeOther() => !_freddieMICompanyNameTypeOther.Clean;
        private Value<string> _freddieMortgageType;
        public string FreddieMortgageType { get { return _freddieMortgageType; } set { _freddieMortgageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMortgageType() => !_freddieMortgageType.Clean;
        private Value<string> _freddieProjectClassificationType;
        public string FreddieProjectClassificationType { get { return _freddieProjectClassificationType; } set { _freddieProjectClassificationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieProjectClassificationType() => !_freddieProjectClassificationType.Clean;
        private Value<string> _freddiePropertyFormType;
        public string FreddiePropertyFormType { get { return _freddiePropertyFormType; } set { _freddiePropertyFormType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddiePropertyFormType() => !_freddiePropertyFormType.Clean;
        private Value<string> _freddieRefinanceCashOutDeterminationType;
        public string FreddieRefinanceCashOutDeterminationType { get { return _freddieRefinanceCashOutDeterminationType; } set { _freddieRefinanceCashOutDeterminationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRefinanceCashOutDeterminationType() => !_freddieRefinanceCashOutDeterminationType.Clean;
        private Value<string> _freddieRefinanceType;
        public string FreddieRefinanceType { get { return _freddieRefinanceType; } set { _freddieRefinanceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRefinanceType() => !_freddieRefinanceType.Clean;
        private Value<bool?> _freddieRelatedClosedEndSecondIndicator;
        public bool? FreddieRelatedClosedEndSecondIndicator { get { return _freddieRelatedClosedEndSecondIndicator; } set { _freddieRelatedClosedEndSecondIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedClosedEndSecondIndicator() => !_freddieRelatedClosedEndSecondIndicator.Clean;
        private Value<string> _freddieRelatedInvestorLoanID;
        public string FreddieRelatedInvestorLoanID { get { return _freddieRelatedInvestorLoanID; } set { _freddieRelatedInvestorLoanID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedInvestorLoanID() => !_freddieRelatedInvestorLoanID.Clean;
        private Value<string> _freddieRelatedLoanInvestorType;
        public string FreddieRelatedLoanInvestorType { get { return _freddieRelatedLoanInvestorType; } set { _freddieRelatedLoanInvestorType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanInvestorType() => !_freddieRelatedLoanInvestorType.Clean;
        private Value<string> _freddieRelatedLoanLienPosition;
        public string FreddieRelatedLoanLienPosition { get { return _freddieRelatedLoanLienPosition; } set { _freddieRelatedLoanLienPosition = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanLienPosition() => !_freddieRelatedLoanLienPosition.Clean;
        private Value<string> _freddieRelatedLoanType;
        public string FreddieRelatedLoanType { get { return _freddieRelatedLoanType; } set { _freddieRelatedLoanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieRelatedLoanType() => !_freddieRelatedLoanType.Clean;
        private Value<string> _freddieSectionOfAct;
        public string FreddieSectionOfAct { get { return _freddieSectionOfAct; } set { _freddieSectionOfAct = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieSectionOfAct() => !_freddieSectionOfAct.Clean;
        private Value<string> _freddieUnderwritingTypeOther;
        public string FreddieUnderwritingTypeOther { get { return _freddieUnderwritingTypeOther; } set { _freddieUnderwritingTypeOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieUnderwritingTypeOther() => !_freddieUnderwritingTypeOther.Clean;
        private Value<string> _ginnieConstructionMethodType;
        public string GinnieConstructionMethodType { get { return _ginnieConstructionMethodType; } set { _ginnieConstructionMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieConstructionMethodType() => !_ginnieConstructionMethodType.Clean;
        private Value<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        public decimal? GinnieGovernmentAnnualPremiumAmount { get { return _ginnieGovernmentAnnualPremiumAmount; } set { _ginnieGovernmentAnnualPremiumAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieGovernmentAnnualPremiumAmount() => !_ginnieGovernmentAnnualPremiumAmount.Clean;
        private Value<string> _ginnieMortgageType;
        public string GinnieMortgageType { get { return _ginnieMortgageType; } set { _ginnieMortgageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieMortgageType() => !_ginnieMortgageType.Clean;
        private Value<string> _ginnieOtherConstructionMethodType;
        public string GinnieOtherConstructionMethodType { get { return _ginnieOtherConstructionMethodType; } set { _ginnieOtherConstructionMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGinnieOtherConstructionMethodType() => !_ginnieOtherConstructionMethodType.Clean;
        private Value<decimal?> _governmentAnnualPremiumPercent;
        public decimal? GovernmentAnnualPremiumPercent { get { return _governmentAnnualPremiumPercent; } set { _governmentAnnualPremiumPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentAnnualPremiumPercent() => !_governmentAnnualPremiumPercent.Clean;
        private Value<string> _governmentRefinanceType;
        public string GovernmentRefinanceType { get { return _governmentRefinanceType; } set { _governmentRefinanceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentRefinanceType() => !_governmentRefinanceType.Clean;
        private Value<decimal?> _governmentUpfrontPremiumAmount;
        public decimal? GovernmentUpfrontPremiumAmount { get { return _governmentUpfrontPremiumAmount; } set { _governmentUpfrontPremiumAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentUpfrontPremiumAmount() => !_governmentUpfrontPremiumAmount.Clean;
        private Value<decimal?> _governmentUpfrontPremiumPercent;
        public decimal? GovernmentUpfrontPremiumPercent { get { return _governmentUpfrontPremiumPercent; } set { _governmentUpfrontPremiumPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGovernmentUpfrontPremiumPercent() => !_governmentUpfrontPremiumPercent.Clean;
        private Value<string> _gSEProjectType;
        public string GSEProjectType { get { return _gSEProjectType; } set { _gSEProjectType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEProjectType() => !_gSEProjectType.Clean;
        private Value<bool?> _guaranteeFeeAddOnIndicator;
        public bool? GuaranteeFeeAddOnIndicator { get { return _guaranteeFeeAddOnIndicator; } set { _guaranteeFeeAddOnIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeAddOnIndicator() => !_guaranteeFeeAddOnIndicator.Clean;
        private Value<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get { return _guarantyFeeAfterAlternatePaymentMethodPercent; } set { _guarantyFeeAfterAlternatePaymentMethodPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyFeeAfterAlternatePaymentMethodPercent() => !_guarantyFeeAfterAlternatePaymentMethodPercent.Clean;
        private Value<decimal?> _guarantyFeePercent;
        public decimal? GuarantyFeePercent { get { return _guarantyFeePercent; } set { _guarantyFeePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyFeePercent() => !_guarantyFeePercent.Clean;
        private Value<decimal?> _guarantyPercent;
        public decimal? GuarantyPercent { get { return _guarantyPercent; } set { _guarantyPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuarantyPercent() => !_guarantyPercent.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _indexType;
        public string IndexType { get { return _indexType; } set { _indexType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexType() => !_indexType.Clean;
        private Value<int?> _initialFixedPeriodEffectiveMonthsCount;
        public int? InitialFixedPeriodEffectiveMonthsCount { get { return _initialFixedPeriodEffectiveMonthsCount; } set { _initialFixedPeriodEffectiveMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialFixedPeriodEffectiveMonthsCount() => !_initialFixedPeriodEffectiveMonthsCount.Clean;
        private Value<string> _interestAccrualType;
        public string InterestAccrualType { get { return _interestAccrualType; } set { _interestAccrualType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAccrualType() => !_interestAccrualType.Clean;
        private Value<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _interestAndPaymentAdjustmentIndexLeadDaysCount; } set { _interestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAndPaymentAdjustmentIndexLeadDaysCount() => !_interestAndPaymentAdjustmentIndexLeadDaysCount.Clean;
        private Value<string> _interestCalculationBasisType;
        public string InterestCalculationBasisType { get { return _interestCalculationBasisType; } set { _interestCalculationBasisType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationBasisType() => !_interestCalculationBasisType.Clean;
        private Value<int?> _interestCalculationEffectiveMonthsCount;
        public int? InterestCalculationEffectiveMonthsCount { get { return _interestCalculationEffectiveMonthsCount; } set { _interestCalculationEffectiveMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationEffectiveMonthsCount() => !_interestCalculationEffectiveMonthsCount.Clean;
        private Value<string> _interestCalculationType;
        public string InterestCalculationType { get { return _interestCalculationType; } set { _interestCalculationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestCalculationType() => !_interestCalculationType.Clean;
        private Value<string> _investorCollateralProgramIdentifier;
        public string InvestorCollateralProgramIdentifier { get { return _investorCollateralProgramIdentifier; } set { _investorCollateralProgramIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCollateralProgramIdentifier() => !_investorCollateralProgramIdentifier.Clean;
        private Value<string> _investorCommitmentIdentifier;
        public string InvestorCommitmentIdentifier { get { return _investorCommitmentIdentifier; } set { _investorCommitmentIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCommitmentIdentifier() => !_investorCommitmentIdentifier.Clean;
        private Value<string> _investorFeatureIdentifier;
        public string InvestorFeatureIdentifier { get { return _investorFeatureIdentifier; } set { _investorFeatureIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorFeatureIdentifier() => !_investorFeatureIdentifier.Clean;
        private Value<string> _investorFeatureIdPool;
        public string InvestorFeatureIdPool { get { return _investorFeatureIdPool; } set { _investorFeatureIdPool = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorFeatureIdPool() => !_investorFeatureIdPool.Clean;
        private Value<decimal?> _investorOwnershipPercent;
        public decimal? InvestorOwnershipPercent { get { return _investorOwnershipPercent; } set { _investorOwnershipPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorOwnershipPercent() => !_investorOwnershipPercent.Clean;
        private Value<string> _investorProductPlanIdentifier;
        public string InvestorProductPlanIdentifier { get { return _investorProductPlanIdentifier; } set { _investorProductPlanIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorProductPlanIdentifier() => !_investorProductPlanIdentifier.Clean;
        private Value<int?> _investorRemittanceDay;
        public int? InvestorRemittanceDay { get { return _investorRemittanceDay; } set { _investorRemittanceDay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorRemittanceDay() => !_investorRemittanceDay.Clean;
        private Value<string> _investorRemittanceType;
        public string InvestorRemittanceType { get { return _investorRemittanceType; } set { _investorRemittanceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorRemittanceType() => !_investorRemittanceType.Clean;
        private Value<string> _issuerIdentifier;
        public string IssuerIdentifier { get { return _issuerIdentifier; } set { _issuerIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIssuerIdentifier() => !_issuerIdentifier.Clean;
        private Value<DateTime?> _lastPaidInstallmentDueDate;
        public DateTime? LastPaidInstallmentDueDate { get { return _lastPaidInstallmentDueDate; } set { _lastPaidInstallmentDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaidInstallmentDueDate() => !_lastPaidInstallmentDueDate.Clean;
        private Value<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get { return _lastPaymentReceivedDate; } set { _lastPaymentReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentReceivedDate() => !_lastPaymentReceivedDate.Clean;
        private Value<DateTime?> _latestConversionEffectiveDate;
        public DateTime? LatestConversionEffectiveDate { get { return _latestConversionEffectiveDate; } set { _latestConversionEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLatestConversionEffectiveDate() => !_latestConversionEffectiveDate.Clean;
        private Value<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get { return _lenderPaidMIInterestRateAdjustmentPercent; } set { _lenderPaidMIInterestRateAdjustmentPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaidMIInterestRateAdjustmentPercent() => !_lenderPaidMIInterestRateAdjustmentPercent.Clean;
        private Value<DateTime?> _lendersDeliveryDate;
        public DateTime? LendersDeliveryDate { get { return _lendersDeliveryDate; } set { _lendersDeliveryDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLendersDeliveryDate() => !_lendersDeliveryDate.Clean;
        private Value<decimal?> _loanAcquisitionScheduledUPBAmount;
        public decimal? LoanAcquisitionScheduledUPBAmount { get { return _loanAcquisitionScheduledUPBAmount; } set { _loanAcquisitionScheduledUPBAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAcquisitionScheduledUPBAmount() => !_loanAcquisitionScheduledUPBAmount.Clean;
        private Value<int?> _loanAmortizationMaximumTermMonthsCount;
        public int? LoanAmortizationMaximumTermMonthsCount { get { return _loanAmortizationMaximumTermMonthsCount; } set { _loanAmortizationMaximumTermMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationMaximumTermMonthsCount() => !_loanAmortizationMaximumTermMonthsCount.Clean;
        private Value<int?> _loanBuyupBuydownBasisPointNumber;
        public int? LoanBuyupBuydownBasisPointNumber { get { return _loanBuyupBuydownBasisPointNumber; } set { _loanBuyupBuydownBasisPointNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanBuyupBuydownBasisPointNumber() => !_loanBuyupBuydownBasisPointNumber.Clean;
        private Value<string> _loanBuyupBuydownType;
        public string LoanBuyupBuydownType { get { return _loanBuyupBuydownType; } set { _loanBuyupBuydownType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanBuyupBuydownType() => !_loanBuyupBuydownType.Clean;
        private Value<string> _loanDefaultLossPartyType;
        public string LoanDefaultLossPartyType { get { return _loanDefaultLossPartyType; } set { _loanDefaultLossPartyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDefaultLossPartyType() => !_loanDefaultLossPartyType.Clean;
        private Value<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get { return _loanDeliveredThroughServicingReleasedProcessIndicator; } set { _loanDeliveredThroughServicingReleasedProcessIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDeliveredThroughServicingReleasedProcessIndicator() => !_loanDeliveredThroughServicingReleasedProcessIndicator.Clean;
        private Value<string> _loanIdentifierValueType;
        public string LoanIdentifierValueType { get { return _loanIdentifierValueType; } set { _loanIdentifierValueType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanIdentifierValueType() => !_loanIdentifierValueType.Clean;
        private Value<DateTime?> _loanInterestAccrualStartDate;
        public DateTime? LoanInterestAccrualStartDate { get { return _loanInterestAccrualStartDate; } set { _loanInterestAccrualStartDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanInterestAccrualStartDate() => !_loanInterestAccrualStartDate.Clean;
        private Value<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get { return _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; } set { _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreSelectionMethodSellerSpecificIndicator() => !_loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Clean;
        private Value<string> _loanLevelCreditScoreSelectionMethodType;
        public string LoanLevelCreditScoreSelectionMethodType { get { return _loanLevelCreditScoreSelectionMethodType; } set { _loanLevelCreditScoreSelectionMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreSelectionMethodType() => !_loanLevelCreditScoreSelectionMethodType.Clean;
        private Value<int?> _loanLevelCreditScoreValue;
        public int? LoanLevelCreditScoreValue { get { return _loanLevelCreditScoreValue; } set { _loanLevelCreditScoreValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLevelCreditScoreValue() => !_loanLevelCreditScoreValue.Clean;
        private Value<DateTime?> _loanModificationEffectiveDate;
        public DateTime? LoanModificationEffectiveDate { get { return _loanModificationEffectiveDate; } set { _loanModificationEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanModificationEffectiveDate() => !_loanModificationEffectiveDate.Clean;
        private Value<DateTime?> _loanStateDate;
        public DateTime? LoanStateDate { get { return _loanStateDate; } set { _loanStateDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanStateDate() => !_loanStateDate.Clean;
        private Value<string> _manufacturedHomeWidthType;
        public string ManufacturedHomeWidthType { get { return _manufacturedHomeWidthType; } set { _manufacturedHomeWidthType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHomeWidthType() => !_manufacturedHomeWidthType.Clean;
        private Value<bool?> _mBSWeightedMarginIndicator;
        public bool? MBSWeightedMarginIndicator { get { return _mBSWeightedMarginIndicator; } set { _mBSWeightedMarginIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMBSWeightedMarginIndicator() => !_mBSWeightedMarginIndicator.Clean;
        private Value<string> _mERSOriginalMortgageeOfRecordIndicator;
        public string MERSOriginalMortgageeOfRecordIndicator { get { return _mERSOriginalMortgageeOfRecordIndicator; } set { _mERSOriginalMortgageeOfRecordIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMERSOriginalMortgageeOfRecordIndicator() => !_mERSOriginalMortgageeOfRecordIndicator.Clean;
        private Value<string> _mICompanyNameType;
        public string MICompanyNameType { get { return _mICompanyNameType; } set { _mICompanyNameType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMICompanyNameType() => !_mICompanyNameType.Clean;
        private Value<string> _mIPremiumSourceType;
        public string MIPremiumSourceType { get { return _mIPremiumSourceType; } set { _mIPremiumSourceType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPremiumSourceType() => !_mIPremiumSourceType.Clean;
        private Value<DateTime?> _monetaryEventAppliedDate;
        public DateTime? MonetaryEventAppliedDate { get { return _monetaryEventAppliedDate; } set { _monetaryEventAppliedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventAppliedDate() => !_monetaryEventAppliedDate.Clean;
        private Value<decimal?> _monetaryEventGrossPrincipalAmount;
        public decimal? MonetaryEventGrossPrincipalAmount { get { return _monetaryEventGrossPrincipalAmount; } set { _monetaryEventGrossPrincipalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventGrossPrincipalAmount() => !_monetaryEventGrossPrincipalAmount.Clean;
        private Value<string> _monetaryEventType;
        public string MonetaryEventType { get { return _monetaryEventType; } set { _monetaryEventType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonetaryEventType() => !_monetaryEventType.Clean;
        private Value<bool?> _mortgageBackedSecurityIndicator;
        public bool? MortgageBackedSecurityIndicator { get { return _mortgageBackedSecurityIndicator; } set { _mortgageBackedSecurityIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBackedSecurityIndicator() => !_mortgageBackedSecurityIndicator.Clean;
        private Value<bool?> _mortgageModificationIndicator;
        public bool? MortgageModificationIndicator { get { return _mortgageModificationIndicator; } set { _mortgageModificationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageModificationIndicator() => !_mortgageModificationIndicator.Clean;
        private Value<string> _mortgageOriginator;
        public string MortgageOriginator { get { return _mortgageOriginator; } set { _mortgageOriginator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageOriginator() => !_mortgageOriginator.Clean;
        private Value<string> _mortgageProgramType;
        public string MortgageProgramType { get { return _mortgageProgramType; } set { _mortgageProgramType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageProgramType() => !_mortgageProgramType.Clean;
        private Value<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get { return _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; } set { _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMultipleConcurrentlyClosingLienOnSubjectPropertyIndicator() => !_multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Clean;
        private Value<DateTime?> _nextRateAdjustmentEffectiveDate;
        public DateTime? NextRateAdjustmentEffectiveDate { get { return _nextRateAdjustmentEffectiveDate; } set { _nextRateAdjustmentEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextRateAdjustmentEffectiveDate() => !_nextRateAdjustmentEffectiveDate.Clean;
        private Value<string> _notePayToName;
        public string NotePayToName { get { return _notePayToName; } set { _notePayToName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotePayToName() => !_notePayToName.Clean;
        private Value<int?> _numberOfUnitsSold;
        public int? NumberOfUnitsSold { get { return _numberOfUnitsSold; } set { _numberOfUnitsSold = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfUnitsSold() => !_numberOfUnitsSold.Clean;
        private Value<string> _otherDownPaymentFundsType;
        public string OtherDownPaymentFundsType { get { return _otherDownPaymentFundsType; } set { _otherDownPaymentFundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDownPaymentFundsType() => !_otherDownPaymentFundsType.Clean;
        private Value<decimal?> _otherFundsCollectedAtClosingAmount;
        public decimal? OtherFundsCollectedAtClosingAmount { get { return _otherFundsCollectedAtClosingAmount; } set { _otherFundsCollectedAtClosingAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherFundsCollectedAtClosingAmount() => !_otherFundsCollectedAtClosingAmount.Clean;
        private Value<string> _otherFundsCollectedAtClosingType;
        public string OtherFundsCollectedAtClosingType { get { return _otherFundsCollectedAtClosingType; } set { _otherFundsCollectedAtClosingType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherFundsCollectedAtClosingType() => !_otherFundsCollectedAtClosingType.Clean;
        private Value<string> _payeeID;
        public string PayeeID { get { return _payeeID; } set { _payeeID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayeeID() => !_payeeID.Clean;
        private Value<int?> _paymentBillingStatementLeadDaysCount;
        public int? PaymentBillingStatementLeadDaysCount { get { return _paymentBillingStatementLeadDaysCount; } set { _paymentBillingStatementLeadDaysCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentBillingStatementLeadDaysCount() => !_paymentBillingStatementLeadDaysCount.Clean;
        private Value<decimal?> _perChangeMaximumDecreaseRatePercent;
        public decimal? PerChangeMaximumDecreaseRatePercent { get { return _perChangeMaximumDecreaseRatePercent; } set { _perChangeMaximumDecreaseRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeMaximumDecreaseRatePercent() => !_perChangeMaximumDecreaseRatePercent.Clean;
        private Value<decimal?> _perChangeMaximumIncreaseRatePercent;
        public decimal? PerChangeMaximumIncreaseRatePercent { get { return _perChangeMaximumIncreaseRatePercent; } set { _perChangeMaximumIncreaseRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeMaximumIncreaseRatePercent() => !_perChangeMaximumIncreaseRatePercent.Clean;
        private Value<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get { return _perChangePrincipalAndInterestPaymentAdjustmentPercent; } set { _perChangePrincipalAndInterestPaymentAdjustmentPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangePrincipalAndInterestPaymentAdjustmentPercent() => !_perChangePrincipalAndInterestPaymentAdjustmentPercent.Clean;
        private Value<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get { return _perChangeRateAdjustmentEffectiveDate; } set { _perChangeRateAdjustmentEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeRateAdjustmentEffectiveDate() => !_perChangeRateAdjustmentEffectiveDate.Clean;
        private Value<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get { return _perChangeRateAdjustmentFrequencyMonthsCount; } set { _perChangeRateAdjustmentFrequencyMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerChangeRateAdjustmentFrequencyMonthsCount() => !_perChangeRateAdjustmentFrequencyMonthsCount.Clean;
        private Value<string> _poolAccrualRateStructureType;
        public string PoolAccrualRateStructureType { get { return _poolAccrualRateStructureType; } set { _poolAccrualRateStructureType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAccrualRateStructureType() => !_poolAccrualRateStructureType.Clean;
        private Value<string> _poolAmortizationType;
        public string PoolAmortizationType { get { return _poolAmortizationType; } set { _poolAmortizationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAmortizationType() => !_poolAmortizationType.Clean;
        private Value<bool?> _poolAssumabilityIndicator;
        public bool? PoolAssumabilityIndicator { get { return _poolAssumabilityIndicator; } set { _poolAssumabilityIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolAssumabilityIndicator() => !_poolAssumabilityIndicator.Clean;
        private Value<bool?> _poolBalloonIndicator;
        public bool? PoolBalloonIndicator { get { return _poolBalloonIndicator; } set { _poolBalloonIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolBalloonIndicator() => !_poolBalloonIndicator.Clean;
        private Value<DateTime?> _poolCertificatePaymentDate;
        public DateTime? PoolCertificatePaymentDate { get { return _poolCertificatePaymentDate; } set { _poolCertificatePaymentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCertificatePaymentDate() => !_poolCertificatePaymentDate.Clean;
        private Value<string> _poolClassType;
        public string PoolClassType { get { return _poolClassType; } set { _poolClassType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolClassType() => !_poolClassType.Clean;
        private Value<string> _poolConcurrentTransferIndicator;
        public string PoolConcurrentTransferIndicator { get { return _poolConcurrentTransferIndicator; } set { _poolConcurrentTransferIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolConcurrentTransferIndicator() => !_poolConcurrentTransferIndicator.Clean;
        private Value<int?> _poolCurrentLoanCount;
        public int? PoolCurrentLoanCount { get { return _poolCurrentLoanCount; } set { _poolCurrentLoanCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCurrentLoanCount() => !_poolCurrentLoanCount.Clean;
        private Value<decimal?> _poolCurrentPrincipalBalanceAmount;
        public decimal? PoolCurrentPrincipalBalanceAmount { get { return _poolCurrentPrincipalBalanceAmount; } set { _poolCurrentPrincipalBalanceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolCurrentPrincipalBalanceAmount() => !_poolCurrentPrincipalBalanceAmount.Clean;
        private Value<string> _poolDocumentCustodianID;
        public string PoolDocumentCustodianID { get { return _poolDocumentCustodianID; } set { _poolDocumentCustodianID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolDocumentCustodianID() => !_poolDocumentCustodianID.Clean;
        private Value<decimal?> _poolFixedServicingFeePercent;
        public decimal? PoolFixedServicingFeePercent { get { return _poolFixedServicingFeePercent; } set { _poolFixedServicingFeePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolFixedServicingFeePercent() => !_poolFixedServicingFeePercent.Clean;
        private Value<string> _poolIdentifier;
        public string PoolIdentifier { get { return _poolIdentifier; } set { _poolIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIdentifier() => !_poolIdentifier.Clean;
        private Value<string> _poolingMethodType;
        public string PoolingMethodType { get { return _poolingMethodType; } set { _poolingMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolingMethodType() => !_poolingMethodType.Clean;
        private Value<DateTime?> _poolInterestAdjustmentEffectiveDate;
        public DateTime? PoolInterestAdjustmentEffectiveDate { get { return _poolInterestAdjustmentEffectiveDate; } set { _poolInterestAdjustmentEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAdjustmentEffectiveDate() => !_poolInterestAdjustmentEffectiveDate.Clean;
        private Value<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get { return _poolInterestAdjustmentIndexLeadDaysCount; } set { _poolInterestAdjustmentIndexLeadDaysCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAdjustmentIndexLeadDaysCount() => !_poolInterestAdjustmentIndexLeadDaysCount.Clean;
        private Value<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; } set { _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestAndPaymentAdjustmentIndexLeadDaysCount() => !_poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Clean;
        private Value<bool?> _poolInterestOnlyIndicator;
        public bool? PoolInterestOnlyIndicator { get { return _poolInterestOnlyIndicator; } set { _poolInterestOnlyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestOnlyIndicator() => !_poolInterestOnlyIndicator.Clean;
        private Value<decimal?> _poolInterestRateRoundingPercent;
        public decimal? PoolInterestRateRoundingPercent { get { return _poolInterestRateRoundingPercent; } set { _poolInterestRateRoundingPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestRateRoundingPercent() => !_poolInterestRateRoundingPercent.Clean;
        private Value<string> _poolInterestRateRoundingType;
        public string PoolInterestRateRoundingType { get { return _poolInterestRateRoundingType; } set { _poolInterestRateRoundingType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInterestRateRoundingType() => !_poolInterestRateRoundingType.Clean;
        private Value<string> _poolInvestorProductPlanIdentifier;
        public string PoolInvestorProductPlanIdentifier { get { return _poolInvestorProductPlanIdentifier; } set { _poolInvestorProductPlanIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolInvestorProductPlanIdentifier() => !_poolInvestorProductPlanIdentifier.Clean;
        private Value<DateTime?> _poolIssueDate;
        public DateTime? PoolIssueDate { get { return _poolIssueDate; } set { _poolIssueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIssueDate() => !_poolIssueDate.Clean;
        private Value<string> _poolIssuerTransferee;
        public string PoolIssuerTransferee { get { return _poolIssuerTransferee; } set { _poolIssuerTransferee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolIssuerTransferee() => !_poolIssuerTransferee.Clean;
        private Value<decimal?> _poolMarginRatePercent;
        public decimal? PoolMarginRatePercent { get { return _poolMarginRatePercent; } set { _poolMarginRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMarginRatePercent() => !_poolMarginRatePercent.Clean;
        private Value<DateTime?> _poolMaturityDate;
        public DateTime? PoolMaturityDate { get { return _poolMaturityDate; } set { _poolMaturityDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaturityDate() => !_poolMaturityDate.Clean;
        private Value<int?> _poolMaturityPeriodCount;
        public int? PoolMaturityPeriodCount { get { return _poolMaturityPeriodCount; } set { _poolMaturityPeriodCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaturityPeriodCount() => !_poolMaturityPeriodCount.Clean;
        private Value<decimal?> _poolMaximumAccrualRatePercent;
        public decimal? PoolMaximumAccrualRatePercent { get { return _poolMaximumAccrualRatePercent; } set { _poolMaximumAccrualRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMaximumAccrualRatePercent() => !_poolMaximumAccrualRatePercent.Clean;
        private Value<decimal?> _poolMinimumAccrualRatePercent;
        public decimal? PoolMinimumAccrualRatePercent { get { return _poolMinimumAccrualRatePercent; } set { _poolMinimumAccrualRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMinimumAccrualRatePercent() => !_poolMinimumAccrualRatePercent.Clean;
        private Value<string> _poolMortgageType;
        public string PoolMortgageType { get { return _poolMortgageType; } set { _poolMortgageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolMortgageType() => !_poolMortgageType.Clean;
        private Value<int?> _poolScheduledRemittancePaymentDay;
        public int? PoolScheduledRemittancePaymentDay { get { return _poolScheduledRemittancePaymentDay; } set { _poolScheduledRemittancePaymentDay = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolScheduledRemittancePaymentDay() => !_poolScheduledRemittancePaymentDay.Clean;
        private Value<decimal?> _poolSecurityIssueDateInterestRatePercent;
        public decimal? PoolSecurityIssueDateInterestRatePercent { get { return _poolSecurityIssueDateInterestRatePercent; } set { _poolSecurityIssueDateInterestRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSecurityIssueDateInterestRatePercent() => !_poolSecurityIssueDateInterestRatePercent.Clean;
        private Value<string> _poolSellerID;
        public string PoolSellerID { get { return _poolSellerID; } set { _poolSellerID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSellerID() => !_poolSellerID.Clean;
        private Value<string> _poolServicerID;
        public string PoolServicerID { get { return _poolServicerID; } set { _poolServicerID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolServicerID() => !_poolServicerID.Clean;
        private Value<string> _poolStructureType;
        public string PoolStructureType { get { return _poolStructureType; } set { _poolStructureType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolStructureType() => !_poolStructureType.Clean;
        private Value<string> _poolSuffixIdentifier;
        public string PoolSuffixIdentifier { get { return _poolSuffixIdentifier; } set { _poolSuffixIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoolSuffixIdentifier() => !_poolSuffixIdentifier.Clean;
        private Value<DateTime?> _priceLockDatetime;
        public DateTime? PriceLockDatetime { get { return _priceLockDatetime; } set { _priceLockDatetime = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriceLockDatetime() => !_priceLockDatetime.Clean;
        private Value<string> _primaryMIAbsenceReasonType;
        public string PrimaryMIAbsenceReasonType { get { return _primaryMIAbsenceReasonType; } set { _primaryMIAbsenceReasonType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrimaryMIAbsenceReasonType() => !_primaryMIAbsenceReasonType.Clean;
        private Value<string> _primaryMIAbsenceReasonTypeOtherDescription;
        public string PrimaryMIAbsenceReasonTypeOtherDescription { get { return _primaryMIAbsenceReasonTypeOtherDescription; } set { _primaryMIAbsenceReasonTypeOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrimaryMIAbsenceReasonTypeOtherDescription() => !_primaryMIAbsenceReasonTypeOtherDescription.Clean;
        private Value<string> _projectAttachmentType;
        public string ProjectAttachmentType { get { return _projectAttachmentType; } set { _projectAttachmentType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectAttachmentType() => !_projectAttachmentType.Clean;
        private Value<string> _projectDesignType;
        public string ProjectDesignType { get { return _projectDesignType; } set { _projectDesignType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectDesignType() => !_projectDesignType.Clean;
        private Value<int?> _projectUnitCount;
        public int? ProjectUnitCount { get { return _projectUnitCount; } set { _projectUnitCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectUnitCount() => !_projectUnitCount.Clean;
        private Value<DateTime?> _propertyValuationEffectiveDate;
        public DateTime? PropertyValuationEffectiveDate { get { return _propertyValuationEffectiveDate; } set { _propertyValuationEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyValuationEffectiveDate() => !_propertyValuationEffectiveDate.Clean;
        private Value<string> _propertyValuationMethodType;
        public string PropertyValuationMethodType { get { return _propertyValuationMethodType; } set { _propertyValuationMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyValuationMethodType() => !_propertyValuationMethodType.Clean;
        private Value<decimal?> _refinanceCashOutAmount;
        public decimal? RefinanceCashOutAmount { get { return _refinanceCashOutAmount; } set { _refinanceCashOutAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceCashOutAmount() => !_refinanceCashOutAmount.Clean;
        private Value<string> _refinanceCashOutDeterminationType;
        public string RefinanceCashOutDeterminationType { get { return _refinanceCashOutDeterminationType; } set { _refinanceCashOutDeterminationType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceCashOutDeterminationType() => !_refinanceCashOutDeterminationType.Clean;
        private Value<bool?> _relatedLoanBalloonIndicator;
        public bool? RelatedLoanBalloonIndicator { get { return _relatedLoanBalloonIndicator; } set { _relatedLoanBalloonIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanBalloonIndicator() => !_relatedLoanBalloonIndicator.Clean;
        private Value<bool?> _relatedLoanHELOCIndicator;
        public bool? RelatedLoanHELOCIndicator { get { return _relatedLoanHELOCIndicator; } set { _relatedLoanHELOCIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanHELOCIndicator() => !_relatedLoanHELOCIndicator.Clean;
        private Value<bool?> _relatedLoanIndicator;
        public bool? RelatedLoanIndicator { get { return _relatedLoanIndicator; } set { _relatedLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanIndicator() => !_relatedLoanIndicator.Clean;
        private Value<string> _relatedLoanInvestorType;
        public string RelatedLoanInvestorType { get { return _relatedLoanInvestorType; } set { _relatedLoanInvestorType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanInvestorType() => !_relatedLoanInvestorType.Clean;
        private Value<int?> _relatedLoanMaturityPeriodCount;
        public int? RelatedLoanMaturityPeriodCount { get { return _relatedLoanMaturityPeriodCount; } set { _relatedLoanMaturityPeriodCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanMaturityPeriodCount() => !_relatedLoanMaturityPeriodCount.Clean;
        private Value<DateTime?> _relatedLoanNoteDate;
        public DateTime? RelatedLoanNoteDate { get { return _relatedLoanNoteDate; } set { _relatedLoanNoteDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanNoteDate() => !_relatedLoanNoteDate.Clean;
        private Value<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get { return _relatedLoanScheduledFirstPaymentDate; } set { _relatedLoanScheduledFirstPaymentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanScheduledFirstPaymentDate() => !_relatedLoanScheduledFirstPaymentDate.Clean;
        private Value<DateTime?> _relatedLoanStateDateAtClosing;
        public DateTime? RelatedLoanStateDateAtClosing { get { return _relatedLoanStateDateAtClosing; } set { _relatedLoanStateDateAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanStateDateAtClosing() => !_relatedLoanStateDateAtClosing.Clean;
        private Value<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get { return _relatedLoanUnpaidPrincipalBalanceAmount; } set { _relatedLoanUnpaidPrincipalBalanceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelatedLoanUnpaidPrincipalBalanceAmount() => !_relatedLoanUnpaidPrincipalBalanceAmount.Clean;
        private Value<bool?> _relocationLoanIndicator;
        public bool? RelocationLoanIndicator { get { return _relocationLoanIndicator; } set { _relocationLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelocationLoanIndicator() => !_relocationLoanIndicator.Clean;
        private Value<string> _rEOMarketingPartyType;
        public string REOMarketingPartyType { get { return _rEOMarketingPartyType; } set { _rEOMarketingPartyType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeREOMarketingPartyType() => !_rEOMarketingPartyType.Clean;
        private Value<bool?> _secondLienIsDeliveredIndicator;
        public bool? SecondLienIsDeliveredIndicator { get { return _secondLienIsDeliveredIndicator; } set { _secondLienIsDeliveredIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondLienIsDeliveredIndicator() => !_secondLienIsDeliveredIndicator.Clean;
        private Value<decimal?> _securityOriginalSubscriptionAmount;
        public decimal? SecurityOriginalSubscriptionAmount { get { return _securityOriginalSubscriptionAmount; } set { _securityOriginalSubscriptionAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityOriginalSubscriptionAmount() => !_securityOriginalSubscriptionAmount.Clean;
        private Value<DateTime?> _securityTradeBookEntryDate;
        public DateTime? SecurityTradeBookEntryDate { get { return _securityTradeBookEntryDate; } set { _securityTradeBookEntryDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityTradeBookEntryDate() => !_securityTradeBookEntryDate.Clean;
        private Value<string> _sellerID;
        public string SellerID { get { return _sellerID; } set { _sellerID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerID() => !_sellerID.Clean;
        private Value<string> _sellerLoanIdentifier;
        public string SellerLoanIdentifier { get { return _sellerLoanIdentifier; } set { _sellerLoanIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerLoanIdentifier() => !_sellerLoanIdentifier.Clean;
        private Value<string> _servicerID;
        public string ServicerID { get { return _servicerID; } set { _servicerID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerID() => !_servicerID.Clean;
        private Value<string> _servicerLoanIdentifier;
        public string ServicerLoanIdentifier { get { return _servicerLoanIdentifier; } set { _servicerLoanIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerLoanIdentifier() => !_servicerLoanIdentifier.Clean;
        private Value<bool?> _sharedEquityIndicator;
        public bool? SharedEquityIndicator { get { return _sharedEquityIndicator; } set { _sharedEquityIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSharedEquityIndicator() => !_sharedEquityIndicator.Clean;
        private Value<bool?> _siteBuiltIndicator;
        public bool? SiteBuiltIndicator { get { return _siteBuiltIndicator; } set { _siteBuiltIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSiteBuiltIndicator() => !_siteBuiltIndicator.Clean;
        private Value<bool?> _specialFloodHazardAreaIndicator;
        public bool? SpecialFloodHazardAreaIndicator { get { return _specialFloodHazardAreaIndicator; } set { _specialFloodHazardAreaIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFloodHazardAreaIndicator() => !_specialFloodHazardAreaIndicator.Clean;
        private Value<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get { return _subsequentPerChangeMaximumDecreaseRatePercent; } set { _subsequentPerChangeMaximumDecreaseRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeMaximumDecreaseRatePercent() => !_subsequentPerChangeMaximumDecreaseRatePercent.Clean;
        private Value<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get { return _subsequentPerChangeMaximumIncreaseRatePercent; } set { _subsequentPerChangeMaximumIncreaseRatePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeMaximumIncreaseRatePercent() => !_subsequentPerChangeMaximumIncreaseRatePercent.Clean;
        private Value<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get { return _subsequentPerChangeRateAdjustmentEffectiveDate; } set { _subsequentPerChangeRateAdjustmentEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeRateAdjustmentEffectiveDate() => !_subsequentPerChangeRateAdjustmentEffectiveDate.Clean;
        private Value<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get { return _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; } set { _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentPerChangeRateAdjustmentFrequencyMonthsCount() => !_subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Clean;
        private Value<bool?> _temporaryBuydownIndicator;
        public bool? TemporaryBuydownIndicator { get { return _temporaryBuydownIndicator; } set { _temporaryBuydownIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTemporaryBuydownIndicator() => !_temporaryBuydownIndicator.Clean;
        private Value<int?> _totalMortgagedPropertiesCount;
        public int? TotalMortgagedPropertiesCount { get { return _totalMortgagedPropertiesCount; } set { _totalMortgagedPropertiesCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgagedPropertiesCount() => !_totalMortgagedPropertiesCount.Clean;
        private Value<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get { return _unit1SubjectPropertyGrossRentalIncome; } set { _unit1SubjectPropertyGrossRentalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit1SubjectPropertyGrossRentalIncome() => !_unit1SubjectPropertyGrossRentalIncome.Clean;
        private Value<int?> _unit1TotalBedrooms;
        public int? Unit1TotalBedrooms { get { return _unit1TotalBedrooms; } set { _unit1TotalBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit1TotalBedrooms() => !_unit1TotalBedrooms.Clean;
        private Value<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get { return _unit2SubjectPropertyGrossRentalIncome; } set { _unit2SubjectPropertyGrossRentalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit2SubjectPropertyGrossRentalIncome() => !_unit2SubjectPropertyGrossRentalIncome.Clean;
        private Value<int?> _unit2TotalBedrooms;
        public int? Unit2TotalBedrooms { get { return _unit2TotalBedrooms; } set { _unit2TotalBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit2TotalBedrooms() => !_unit2TotalBedrooms.Clean;
        private Value<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get { return _unit3SubjectPropertyGrossRentalIncome; } set { _unit3SubjectPropertyGrossRentalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit3SubjectPropertyGrossRentalIncome() => !_unit3SubjectPropertyGrossRentalIncome.Clean;
        private Value<int?> _unit3TotalBedrooms;
        public int? Unit3TotalBedrooms { get { return _unit3TotalBedrooms; } set { _unit3TotalBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit3TotalBedrooms() => !_unit3TotalBedrooms.Clean;
        private Value<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get { return _unit4SubjectPropertyGrossRentalIncome; } set { _unit4SubjectPropertyGrossRentalIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit4SubjectPropertyGrossRentalIncome() => !_unit4SubjectPropertyGrossRentalIncome.Clean;
        private Value<int?> _unit4TotalBedrooms;
        public int? Unit4TotalBedrooms { get { return _unit4TotalBedrooms; } set { _unit4TotalBedrooms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnit4TotalBedrooms() => !_unit4TotalBedrooms.Clean;
        private Value<decimal?> _uPBAmount;
        public decimal? UPBAmount { get { return _uPBAmount; } set { _uPBAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUPBAmount() => !_uPBAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aCHABARoutingAndTransitIdentifier.Clean
                    && _aCHABARoutingAndTransitNumber.Clean
                    && _aCHBankAccountDescription.Clean
                    && _aCHBankAccountIdentifier.Clean
                    && _aCHBankAccountPurposeTransitIdentifier.Clean
                    && _aCHBankAccountPurposeType.Clean
                    && _aCHInstitutionTelegraphicAbbreviationName.Clean
                    && _aCHReceiverSubaccountName.Clean
                    && _additionalPrincipalAmountIndicator.Clean
                    && _aggregateLoanCurtailmentAmount.Clean
                    && _appraisalIdentifier.Clean
                    && _attachmentType.Clean
                    && _aVMModelNameType.Clean
                    && _balloonResetIndicator.Clean
                    && _baseGuarantyFeePercent.Clean
                    && _bondFinancePool.Clean
                    && _bondFinanceProgramName.Clean
                    && _bondFinanceProgramType.Clean
                    && _borrowerMailToAddressSameasPropertyIndicator.Clean
                    && _borrowerType.Clean
                    && _capitalizedLoanIndicator.Clean
                    && _certificateIdentifier.Clean
                    && _certificateMaturityDate.Clean
                    && _certificatePrincipalBalanceAmount.Clean
                    && _certificateType.Clean
                    && _closingCost2ContributionAmount.Clean
                    && _closingCost2FundsType.Clean
                    && _closingCost2FundsTypeOtherDescription.Clean
                    && _closingCost2SourceType.Clean
                    && _closingCost2SourceTypeOtherDescription.Clean
                    && _closingCost3ContributionAmount.Clean
                    && _closingCost3FundsType.Clean
                    && _closingCost3FundsTypeOtherDescription.Clean
                    && _closingCost3SourceType.Clean
                    && _closingCost3SourceTypeOtherDescription.Clean
                    && _closingCost4ContributionAmount.Clean
                    && _closingCost4FundsType.Clean
                    && _closingCost4FundsTypeOtherDescription.Clean
                    && _closingCost4SourceType.Clean
                    && _closingCost4SourceTypeOtherDescription.Clean
                    && _closingCostContributionAmount.Clean
                    && _closingCostFundsType.Clean
                    && _closingCostFundsTypeOtherDescription.Clean
                    && _closingCostSourceType.Clean
                    && _closingCostSourceTypeOtherDescription.Clean
                    && _coBorrowerCountryCode.Clean
                    && _coBorrowerMailToAddressSameasPropertyIndicator.Clean
                    && _coBorrowerType.Clean
                    && _condominiumProjectStatusType.Clean
                    && _constructionMethodType.Clean
                    && _constructionMethodTypeOtherDescription.Clean
                    && _constructionToPermanentClosingFeatureType.Clean
                    && _constructionToPermanentClosingType.Clean
                    && _convertibleStatusType.Clean
                    && _counselingFormatType.Clean
                    && _counselingFormatTypeOtherDescription.Clean
                    && _counselTypeOther.Clean
                    && _countryCode.Clean
                    && _creditScoreImpairmentType.Clean
                    && _currentAccruedInterestAmount.Clean
                    && _delinquentPaymentsOverPastTwelveMonthsCount.Clean
                    && _documentCustodianID.Clean
                    && _documentRequiredIndicator.Clean
                    && _documentSubmissionIndicator.Clean
                    && _downPaymentFundsType.Clean
                    && _downPaymentOtherTypeDescription.Clean
                    && _downPaymentSourceType.Clean
                    && _downPaymentSourceTypeOtherDescription.Clean
                    && _fannieARMIndexType.Clean
                    && _fannieAutoUWDec.Clean
                    && _fannieBLTV.Clean
                    && _fannieBorrowerFirstName.Clean
                    && _fannieBorrowerMiddleName.Clean
                    && _fannieBuydownContributer.Clean
                    && _fannieCLTV.Clean
                    && _fannieCoBorrowerFirstName.Clean
                    && _fannieCoBorrowerMiddleName.Clean
                    && _fannieCreditScoreProviderName.Clean
                    && _fannieFloodSpecialFeatureCode.Clean
                    && _fannieHCLTV.Clean
                    && _fannieInvestorOwnershipPercent.Clean
                    && _fannieLegalEntityType.Clean
                    && _fannieLegalEntityTypeOther.Clean
                    && _fannieLenderPaidMIInterestRateAdjustmentPercent.Clean
                    && _fannieLoanProgramIdentifier.Clean
                    && _fannieLTV.Clean
                    && _fannieMICompanyNameTypeOther.Clean
                    && _fannieMICoveragePercent.Clean
                    && _fanniePoolOwnershipPercent.Clean
                    && _fannieProjectClassificationType.Clean
                    && _fanniePropertyFormType.Clean
                    && _fannieRateSpread.Clean
                    && _fannieRefinanceType.Clean
                    && _fannieRelatedInvestorLoanID.Clean
                    && _fannieRelatedLoanAmortizationType.Clean
                    && _fannieRelatedLoanLienPosition.Clean
                    && _fannieRelatedLoanType.Clean
                    && _fannieSectionOfAct.Clean
                    && _fannieTLTV.Clean
                    && _fannieTrustName.Clean
                    && _fannnieMortgageType.Clean
                    && _financedUnitCount.Clean
                    && _firstRateChangePaymentEffectiveDate.Clean
                    && _fNMHomeImprovementProductType.Clean
                    && _freddieARMIndexType.Clean
                    && _freddieAutoUWDec.Clean
                    && _freddieAVMModelNameTypeExpl.Clean
                    && _freddieBorrowerAlienStatus.Clean
                    && _freddieCoBorrowerAlienStatus.Clean
                    && _freddieCreditScoreProviderName.Clean
                    && _freddieDownPaymentType.Clean
                    && _freddieDownPmt2SourceType.Clean
                    && _freddieDownPmt2SourceTypeExpl.Clean
                    && _freddieDownPmt2Type.Clean
                    && _freddieDownPmt2TypeExpl.Clean
                    && _freddieDownPmt3Amt.Clean
                    && _freddieDownPmt3SourceType.Clean
                    && _freddieDownPmt3SourceTypeExpl.Clean
                    && _freddieDownPmt3Type.Clean
                    && _freddieDownPmt3TypeExpl.Clean
                    && _freddieDownPmt4Amt.Clean
                    && _freddieDownPmt4SourceType.Clean
                    && _freddieDownPmt4SourceTypeExpl.Clean
                    && _freddieDownPmt4Type.Clean
                    && _freddieDownPmt4TypeExpl.Clean
                    && _freddieExplanationOfDownPayment.Clean
                    && _freddieInvestorCollateralProgramIdentifier.Clean
                    && _freddieInvestorFeatureIdentifier.Clean
                    && _freddieLegalEntityType.Clean
                    && _freddieLegalEntityTypeOther.Clean
                    && _freddieLoanProgramIdentifier.Clean
                    && _freddieLoanTypePublicAndIndianHousingIndicator.Clean
                    && _freddieMICompanyNameTypeOther.Clean
                    && _freddieMortgageType.Clean
                    && _freddieProjectClassificationType.Clean
                    && _freddiePropertyFormType.Clean
                    && _freddieRefinanceCashOutDeterminationType.Clean
                    && _freddieRefinanceType.Clean
                    && _freddieRelatedClosedEndSecondIndicator.Clean
                    && _freddieRelatedInvestorLoanID.Clean
                    && _freddieRelatedLoanInvestorType.Clean
                    && _freddieRelatedLoanLienPosition.Clean
                    && _freddieRelatedLoanType.Clean
                    && _freddieSectionOfAct.Clean
                    && _freddieUnderwritingTypeOther.Clean
                    && _ginnieConstructionMethodType.Clean
                    && _ginnieGovernmentAnnualPremiumAmount.Clean
                    && _ginnieMortgageType.Clean
                    && _ginnieOtherConstructionMethodType.Clean
                    && _governmentAnnualPremiumPercent.Clean
                    && _governmentRefinanceType.Clean
                    && _governmentUpfrontPremiumAmount.Clean
                    && _governmentUpfrontPremiumPercent.Clean
                    && _gSEProjectType.Clean
                    && _guaranteeFeeAddOnIndicator.Clean
                    && _guarantyFeeAfterAlternatePaymentMethodPercent.Clean
                    && _guarantyFeePercent.Clean
                    && _guarantyPercent.Clean
                    && _id.Clean
                    && _indexType.Clean
                    && _initialFixedPeriodEffectiveMonthsCount.Clean
                    && _interestAccrualType.Clean
                    && _interestAndPaymentAdjustmentIndexLeadDaysCount.Clean
                    && _interestCalculationBasisType.Clean
                    && _interestCalculationEffectiveMonthsCount.Clean
                    && _interestCalculationType.Clean
                    && _investorCollateralProgramIdentifier.Clean
                    && _investorCommitmentIdentifier.Clean
                    && _investorFeatureIdentifier.Clean
                    && _investorFeatureIdPool.Clean
                    && _investorOwnershipPercent.Clean
                    && _investorProductPlanIdentifier.Clean
                    && _investorRemittanceDay.Clean
                    && _investorRemittanceType.Clean
                    && _issuerIdentifier.Clean
                    && _lastPaidInstallmentDueDate.Clean
                    && _lastPaymentReceivedDate.Clean
                    && _latestConversionEffectiveDate.Clean
                    && _lenderPaidMIInterestRateAdjustmentPercent.Clean
                    && _lendersDeliveryDate.Clean
                    && _loanAcquisitionScheduledUPBAmount.Clean
                    && _loanAmortizationMaximumTermMonthsCount.Clean
                    && _loanBuyupBuydownBasisPointNumber.Clean
                    && _loanBuyupBuydownType.Clean
                    && _loanDefaultLossPartyType.Clean
                    && _loanDeliveredThroughServicingReleasedProcessIndicator.Clean
                    && _loanIdentifierValueType.Clean
                    && _loanInterestAccrualStartDate.Clean
                    && _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Clean
                    && _loanLevelCreditScoreSelectionMethodType.Clean
                    && _loanLevelCreditScoreValue.Clean
                    && _loanModificationEffectiveDate.Clean
                    && _loanStateDate.Clean
                    && _manufacturedHomeWidthType.Clean
                    && _mBSWeightedMarginIndicator.Clean
                    && _mERSOriginalMortgageeOfRecordIndicator.Clean
                    && _mICompanyNameType.Clean
                    && _mIPremiumSourceType.Clean
                    && _monetaryEventAppliedDate.Clean
                    && _monetaryEventGrossPrincipalAmount.Clean
                    && _monetaryEventType.Clean
                    && _mortgageBackedSecurityIndicator.Clean
                    && _mortgageModificationIndicator.Clean
                    && _mortgageOriginator.Clean
                    && _mortgageProgramType.Clean
                    && _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Clean
                    && _nextRateAdjustmentEffectiveDate.Clean
                    && _notePayToName.Clean
                    && _numberOfUnitsSold.Clean
                    && _otherDownPaymentFundsType.Clean
                    && _otherFundsCollectedAtClosingAmount.Clean
                    && _otherFundsCollectedAtClosingType.Clean
                    && _payeeID.Clean
                    && _paymentBillingStatementLeadDaysCount.Clean
                    && _perChangeMaximumDecreaseRatePercent.Clean
                    && _perChangeMaximumIncreaseRatePercent.Clean
                    && _perChangePrincipalAndInterestPaymentAdjustmentPercent.Clean
                    && _perChangeRateAdjustmentEffectiveDate.Clean
                    && _perChangeRateAdjustmentFrequencyMonthsCount.Clean
                    && _poolAccrualRateStructureType.Clean
                    && _poolAmortizationType.Clean
                    && _poolAssumabilityIndicator.Clean
                    && _poolBalloonIndicator.Clean
                    && _poolCertificatePaymentDate.Clean
                    && _poolClassType.Clean
                    && _poolConcurrentTransferIndicator.Clean
                    && _poolCurrentLoanCount.Clean
                    && _poolCurrentPrincipalBalanceAmount.Clean
                    && _poolDocumentCustodianID.Clean
                    && _poolFixedServicingFeePercent.Clean
                    && _poolIdentifier.Clean
                    && _poolingMethodType.Clean
                    && _poolInterestAdjustmentEffectiveDate.Clean
                    && _poolInterestAdjustmentIndexLeadDaysCount.Clean
                    && _poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Clean
                    && _poolInterestOnlyIndicator.Clean
                    && _poolInterestRateRoundingPercent.Clean
                    && _poolInterestRateRoundingType.Clean
                    && _poolInvestorProductPlanIdentifier.Clean
                    && _poolIssueDate.Clean
                    && _poolIssuerTransferee.Clean
                    && _poolMarginRatePercent.Clean
                    && _poolMaturityDate.Clean
                    && _poolMaturityPeriodCount.Clean
                    && _poolMaximumAccrualRatePercent.Clean
                    && _poolMinimumAccrualRatePercent.Clean
                    && _poolMortgageType.Clean
                    && _poolScheduledRemittancePaymentDay.Clean
                    && _poolSecurityIssueDateInterestRatePercent.Clean
                    && _poolSellerID.Clean
                    && _poolServicerID.Clean
                    && _poolStructureType.Clean
                    && _poolSuffixIdentifier.Clean
                    && _priceLockDatetime.Clean
                    && _primaryMIAbsenceReasonType.Clean
                    && _primaryMIAbsenceReasonTypeOtherDescription.Clean
                    && _projectAttachmentType.Clean
                    && _projectDesignType.Clean
                    && _projectUnitCount.Clean
                    && _propertyValuationEffectiveDate.Clean
                    && _propertyValuationMethodType.Clean
                    && _refinanceCashOutAmount.Clean
                    && _refinanceCashOutDeterminationType.Clean
                    && _relatedLoanBalloonIndicator.Clean
                    && _relatedLoanHELOCIndicator.Clean
                    && _relatedLoanIndicator.Clean
                    && _relatedLoanInvestorType.Clean
                    && _relatedLoanMaturityPeriodCount.Clean
                    && _relatedLoanNoteDate.Clean
                    && _relatedLoanScheduledFirstPaymentDate.Clean
                    && _relatedLoanStateDateAtClosing.Clean
                    && _relatedLoanUnpaidPrincipalBalanceAmount.Clean
                    && _relocationLoanIndicator.Clean
                    && _rEOMarketingPartyType.Clean
                    && _secondLienIsDeliveredIndicator.Clean
                    && _securityOriginalSubscriptionAmount.Clean
                    && _securityTradeBookEntryDate.Clean
                    && _sellerID.Clean
                    && _sellerLoanIdentifier.Clean
                    && _servicerID.Clean
                    && _servicerLoanIdentifier.Clean
                    && _sharedEquityIndicator.Clean
                    && _siteBuiltIndicator.Clean
                    && _specialFloodHazardAreaIndicator.Clean
                    && _subsequentPerChangeMaximumDecreaseRatePercent.Clean
                    && _subsequentPerChangeMaximumIncreaseRatePercent.Clean
                    && _subsequentPerChangeRateAdjustmentEffectiveDate.Clean
                    && _subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Clean
                    && _temporaryBuydownIndicator.Clean
                    && _totalMortgagedPropertiesCount.Clean
                    && _unit1SubjectPropertyGrossRentalIncome.Clean
                    && _unit1TotalBedrooms.Clean
                    && _unit2SubjectPropertyGrossRentalIncome.Clean
                    && _unit2TotalBedrooms.Clean
                    && _unit3SubjectPropertyGrossRentalIncome.Clean
                    && _unit3TotalBedrooms.Clean
                    && _unit4SubjectPropertyGrossRentalIncome.Clean
                    && _unit4TotalBedrooms.Clean
                    && _uPBAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _aCHABARoutingAndTransitIdentifier; v0.Clean = value; _aCHABARoutingAndTransitIdentifier = v0;
                var v1 = _aCHABARoutingAndTransitNumber; v1.Clean = value; _aCHABARoutingAndTransitNumber = v1;
                var v2 = _aCHBankAccountDescription; v2.Clean = value; _aCHBankAccountDescription = v2;
                var v3 = _aCHBankAccountIdentifier; v3.Clean = value; _aCHBankAccountIdentifier = v3;
                var v4 = _aCHBankAccountPurposeTransitIdentifier; v4.Clean = value; _aCHBankAccountPurposeTransitIdentifier = v4;
                var v5 = _aCHBankAccountPurposeType; v5.Clean = value; _aCHBankAccountPurposeType = v5;
                var v6 = _aCHInstitutionTelegraphicAbbreviationName; v6.Clean = value; _aCHInstitutionTelegraphicAbbreviationName = v6;
                var v7 = _aCHReceiverSubaccountName; v7.Clean = value; _aCHReceiverSubaccountName = v7;
                var v8 = _additionalPrincipalAmountIndicator; v8.Clean = value; _additionalPrincipalAmountIndicator = v8;
                var v9 = _aggregateLoanCurtailmentAmount; v9.Clean = value; _aggregateLoanCurtailmentAmount = v9;
                var v10 = _appraisalIdentifier; v10.Clean = value; _appraisalIdentifier = v10;
                var v11 = _attachmentType; v11.Clean = value; _attachmentType = v11;
                var v12 = _aVMModelNameType; v12.Clean = value; _aVMModelNameType = v12;
                var v13 = _balloonResetIndicator; v13.Clean = value; _balloonResetIndicator = v13;
                var v14 = _baseGuarantyFeePercent; v14.Clean = value; _baseGuarantyFeePercent = v14;
                var v15 = _bondFinancePool; v15.Clean = value; _bondFinancePool = v15;
                var v16 = _bondFinanceProgramName; v16.Clean = value; _bondFinanceProgramName = v16;
                var v17 = _bondFinanceProgramType; v17.Clean = value; _bondFinanceProgramType = v17;
                var v18 = _borrowerMailToAddressSameasPropertyIndicator; v18.Clean = value; _borrowerMailToAddressSameasPropertyIndicator = v18;
                var v19 = _borrowerType; v19.Clean = value; _borrowerType = v19;
                var v20 = _capitalizedLoanIndicator; v20.Clean = value; _capitalizedLoanIndicator = v20;
                var v21 = _certificateIdentifier; v21.Clean = value; _certificateIdentifier = v21;
                var v22 = _certificateMaturityDate; v22.Clean = value; _certificateMaturityDate = v22;
                var v23 = _certificatePrincipalBalanceAmount; v23.Clean = value; _certificatePrincipalBalanceAmount = v23;
                var v24 = _certificateType; v24.Clean = value; _certificateType = v24;
                var v25 = _closingCost2ContributionAmount; v25.Clean = value; _closingCost2ContributionAmount = v25;
                var v26 = _closingCost2FundsType; v26.Clean = value; _closingCost2FundsType = v26;
                var v27 = _closingCost2FundsTypeOtherDescription; v27.Clean = value; _closingCost2FundsTypeOtherDescription = v27;
                var v28 = _closingCost2SourceType; v28.Clean = value; _closingCost2SourceType = v28;
                var v29 = _closingCost2SourceTypeOtherDescription; v29.Clean = value; _closingCost2SourceTypeOtherDescription = v29;
                var v30 = _closingCost3ContributionAmount; v30.Clean = value; _closingCost3ContributionAmount = v30;
                var v31 = _closingCost3FundsType; v31.Clean = value; _closingCost3FundsType = v31;
                var v32 = _closingCost3FundsTypeOtherDescription; v32.Clean = value; _closingCost3FundsTypeOtherDescription = v32;
                var v33 = _closingCost3SourceType; v33.Clean = value; _closingCost3SourceType = v33;
                var v34 = _closingCost3SourceTypeOtherDescription; v34.Clean = value; _closingCost3SourceTypeOtherDescription = v34;
                var v35 = _closingCost4ContributionAmount; v35.Clean = value; _closingCost4ContributionAmount = v35;
                var v36 = _closingCost4FundsType; v36.Clean = value; _closingCost4FundsType = v36;
                var v37 = _closingCost4FundsTypeOtherDescription; v37.Clean = value; _closingCost4FundsTypeOtherDescription = v37;
                var v38 = _closingCost4SourceType; v38.Clean = value; _closingCost4SourceType = v38;
                var v39 = _closingCost4SourceTypeOtherDescription; v39.Clean = value; _closingCost4SourceTypeOtherDescription = v39;
                var v40 = _closingCostContributionAmount; v40.Clean = value; _closingCostContributionAmount = v40;
                var v41 = _closingCostFundsType; v41.Clean = value; _closingCostFundsType = v41;
                var v42 = _closingCostFundsTypeOtherDescription; v42.Clean = value; _closingCostFundsTypeOtherDescription = v42;
                var v43 = _closingCostSourceType; v43.Clean = value; _closingCostSourceType = v43;
                var v44 = _closingCostSourceTypeOtherDescription; v44.Clean = value; _closingCostSourceTypeOtherDescription = v44;
                var v45 = _coBorrowerCountryCode; v45.Clean = value; _coBorrowerCountryCode = v45;
                var v46 = _coBorrowerMailToAddressSameasPropertyIndicator; v46.Clean = value; _coBorrowerMailToAddressSameasPropertyIndicator = v46;
                var v47 = _coBorrowerType; v47.Clean = value; _coBorrowerType = v47;
                var v48 = _condominiumProjectStatusType; v48.Clean = value; _condominiumProjectStatusType = v48;
                var v49 = _constructionMethodType; v49.Clean = value; _constructionMethodType = v49;
                var v50 = _constructionMethodTypeOtherDescription; v50.Clean = value; _constructionMethodTypeOtherDescription = v50;
                var v51 = _constructionToPermanentClosingFeatureType; v51.Clean = value; _constructionToPermanentClosingFeatureType = v51;
                var v52 = _constructionToPermanentClosingType; v52.Clean = value; _constructionToPermanentClosingType = v52;
                var v53 = _convertibleStatusType; v53.Clean = value; _convertibleStatusType = v53;
                var v54 = _counselingFormatType; v54.Clean = value; _counselingFormatType = v54;
                var v55 = _counselingFormatTypeOtherDescription; v55.Clean = value; _counselingFormatTypeOtherDescription = v55;
                var v56 = _counselTypeOther; v56.Clean = value; _counselTypeOther = v56;
                var v57 = _countryCode; v57.Clean = value; _countryCode = v57;
                var v58 = _creditScoreImpairmentType; v58.Clean = value; _creditScoreImpairmentType = v58;
                var v59 = _currentAccruedInterestAmount; v59.Clean = value; _currentAccruedInterestAmount = v59;
                var v60 = _delinquentPaymentsOverPastTwelveMonthsCount; v60.Clean = value; _delinquentPaymentsOverPastTwelveMonthsCount = v60;
                var v61 = _documentCustodianID; v61.Clean = value; _documentCustodianID = v61;
                var v62 = _documentRequiredIndicator; v62.Clean = value; _documentRequiredIndicator = v62;
                var v63 = _documentSubmissionIndicator; v63.Clean = value; _documentSubmissionIndicator = v63;
                var v64 = _downPaymentFundsType; v64.Clean = value; _downPaymentFundsType = v64;
                var v65 = _downPaymentOtherTypeDescription; v65.Clean = value; _downPaymentOtherTypeDescription = v65;
                var v66 = _downPaymentSourceType; v66.Clean = value; _downPaymentSourceType = v66;
                var v67 = _downPaymentSourceTypeOtherDescription; v67.Clean = value; _downPaymentSourceTypeOtherDescription = v67;
                var v68 = _fannieARMIndexType; v68.Clean = value; _fannieARMIndexType = v68;
                var v69 = _fannieAutoUWDec; v69.Clean = value; _fannieAutoUWDec = v69;
                var v70 = _fannieBLTV; v70.Clean = value; _fannieBLTV = v70;
                var v71 = _fannieBorrowerFirstName; v71.Clean = value; _fannieBorrowerFirstName = v71;
                var v72 = _fannieBorrowerMiddleName; v72.Clean = value; _fannieBorrowerMiddleName = v72;
                var v73 = _fannieBuydownContributer; v73.Clean = value; _fannieBuydownContributer = v73;
                var v74 = _fannieCLTV; v74.Clean = value; _fannieCLTV = v74;
                var v75 = _fannieCoBorrowerFirstName; v75.Clean = value; _fannieCoBorrowerFirstName = v75;
                var v76 = _fannieCoBorrowerMiddleName; v76.Clean = value; _fannieCoBorrowerMiddleName = v76;
                var v77 = _fannieCreditScoreProviderName; v77.Clean = value; _fannieCreditScoreProviderName = v77;
                var v78 = _fannieFloodSpecialFeatureCode; v78.Clean = value; _fannieFloodSpecialFeatureCode = v78;
                var v79 = _fannieHCLTV; v79.Clean = value; _fannieHCLTV = v79;
                var v80 = _fannieInvestorOwnershipPercent; v80.Clean = value; _fannieInvestorOwnershipPercent = v80;
                var v81 = _fannieLegalEntityType; v81.Clean = value; _fannieLegalEntityType = v81;
                var v82 = _fannieLegalEntityTypeOther; v82.Clean = value; _fannieLegalEntityTypeOther = v82;
                var v83 = _fannieLenderPaidMIInterestRateAdjustmentPercent; v83.Clean = value; _fannieLenderPaidMIInterestRateAdjustmentPercent = v83;
                var v84 = _fannieLoanProgramIdentifier; v84.Clean = value; _fannieLoanProgramIdentifier = v84;
                var v85 = _fannieLTV; v85.Clean = value; _fannieLTV = v85;
                var v86 = _fannieMICompanyNameTypeOther; v86.Clean = value; _fannieMICompanyNameTypeOther = v86;
                var v87 = _fannieMICoveragePercent; v87.Clean = value; _fannieMICoveragePercent = v87;
                var v88 = _fanniePoolOwnershipPercent; v88.Clean = value; _fanniePoolOwnershipPercent = v88;
                var v89 = _fannieProjectClassificationType; v89.Clean = value; _fannieProjectClassificationType = v89;
                var v90 = _fanniePropertyFormType; v90.Clean = value; _fanniePropertyFormType = v90;
                var v91 = _fannieRateSpread; v91.Clean = value; _fannieRateSpread = v91;
                var v92 = _fannieRefinanceType; v92.Clean = value; _fannieRefinanceType = v92;
                var v93 = _fannieRelatedInvestorLoanID; v93.Clean = value; _fannieRelatedInvestorLoanID = v93;
                var v94 = _fannieRelatedLoanAmortizationType; v94.Clean = value; _fannieRelatedLoanAmortizationType = v94;
                var v95 = _fannieRelatedLoanLienPosition; v95.Clean = value; _fannieRelatedLoanLienPosition = v95;
                var v96 = _fannieRelatedLoanType; v96.Clean = value; _fannieRelatedLoanType = v96;
                var v97 = _fannieSectionOfAct; v97.Clean = value; _fannieSectionOfAct = v97;
                var v98 = _fannieTLTV; v98.Clean = value; _fannieTLTV = v98;
                var v99 = _fannieTrustName; v99.Clean = value; _fannieTrustName = v99;
                var v100 = _fannnieMortgageType; v100.Clean = value; _fannnieMortgageType = v100;
                var v101 = _financedUnitCount; v101.Clean = value; _financedUnitCount = v101;
                var v102 = _firstRateChangePaymentEffectiveDate; v102.Clean = value; _firstRateChangePaymentEffectiveDate = v102;
                var v103 = _fNMHomeImprovementProductType; v103.Clean = value; _fNMHomeImprovementProductType = v103;
                var v104 = _freddieARMIndexType; v104.Clean = value; _freddieARMIndexType = v104;
                var v105 = _freddieAutoUWDec; v105.Clean = value; _freddieAutoUWDec = v105;
                var v106 = _freddieAVMModelNameTypeExpl; v106.Clean = value; _freddieAVMModelNameTypeExpl = v106;
                var v107 = _freddieBorrowerAlienStatus; v107.Clean = value; _freddieBorrowerAlienStatus = v107;
                var v108 = _freddieCoBorrowerAlienStatus; v108.Clean = value; _freddieCoBorrowerAlienStatus = v108;
                var v109 = _freddieCreditScoreProviderName; v109.Clean = value; _freddieCreditScoreProviderName = v109;
                var v110 = _freddieDownPaymentType; v110.Clean = value; _freddieDownPaymentType = v110;
                var v111 = _freddieDownPmt2SourceType; v111.Clean = value; _freddieDownPmt2SourceType = v111;
                var v112 = _freddieDownPmt2SourceTypeExpl; v112.Clean = value; _freddieDownPmt2SourceTypeExpl = v112;
                var v113 = _freddieDownPmt2Type; v113.Clean = value; _freddieDownPmt2Type = v113;
                var v114 = _freddieDownPmt2TypeExpl; v114.Clean = value; _freddieDownPmt2TypeExpl = v114;
                var v115 = _freddieDownPmt3Amt; v115.Clean = value; _freddieDownPmt3Amt = v115;
                var v116 = _freddieDownPmt3SourceType; v116.Clean = value; _freddieDownPmt3SourceType = v116;
                var v117 = _freddieDownPmt3SourceTypeExpl; v117.Clean = value; _freddieDownPmt3SourceTypeExpl = v117;
                var v118 = _freddieDownPmt3Type; v118.Clean = value; _freddieDownPmt3Type = v118;
                var v119 = _freddieDownPmt3TypeExpl; v119.Clean = value; _freddieDownPmt3TypeExpl = v119;
                var v120 = _freddieDownPmt4Amt; v120.Clean = value; _freddieDownPmt4Amt = v120;
                var v121 = _freddieDownPmt4SourceType; v121.Clean = value; _freddieDownPmt4SourceType = v121;
                var v122 = _freddieDownPmt4SourceTypeExpl; v122.Clean = value; _freddieDownPmt4SourceTypeExpl = v122;
                var v123 = _freddieDownPmt4Type; v123.Clean = value; _freddieDownPmt4Type = v123;
                var v124 = _freddieDownPmt4TypeExpl; v124.Clean = value; _freddieDownPmt4TypeExpl = v124;
                var v125 = _freddieExplanationOfDownPayment; v125.Clean = value; _freddieExplanationOfDownPayment = v125;
                var v126 = _freddieInvestorCollateralProgramIdentifier; v126.Clean = value; _freddieInvestorCollateralProgramIdentifier = v126;
                var v127 = _freddieInvestorFeatureIdentifier; v127.Clean = value; _freddieInvestorFeatureIdentifier = v127;
                var v128 = _freddieLegalEntityType; v128.Clean = value; _freddieLegalEntityType = v128;
                var v129 = _freddieLegalEntityTypeOther; v129.Clean = value; _freddieLegalEntityTypeOther = v129;
                var v130 = _freddieLoanProgramIdentifier; v130.Clean = value; _freddieLoanProgramIdentifier = v130;
                var v131 = _freddieLoanTypePublicAndIndianHousingIndicator; v131.Clean = value; _freddieLoanTypePublicAndIndianHousingIndicator = v131;
                var v132 = _freddieMICompanyNameTypeOther; v132.Clean = value; _freddieMICompanyNameTypeOther = v132;
                var v133 = _freddieMortgageType; v133.Clean = value; _freddieMortgageType = v133;
                var v134 = _freddieProjectClassificationType; v134.Clean = value; _freddieProjectClassificationType = v134;
                var v135 = _freddiePropertyFormType; v135.Clean = value; _freddiePropertyFormType = v135;
                var v136 = _freddieRefinanceCashOutDeterminationType; v136.Clean = value; _freddieRefinanceCashOutDeterminationType = v136;
                var v137 = _freddieRefinanceType; v137.Clean = value; _freddieRefinanceType = v137;
                var v138 = _freddieRelatedClosedEndSecondIndicator; v138.Clean = value; _freddieRelatedClosedEndSecondIndicator = v138;
                var v139 = _freddieRelatedInvestorLoanID; v139.Clean = value; _freddieRelatedInvestorLoanID = v139;
                var v140 = _freddieRelatedLoanInvestorType; v140.Clean = value; _freddieRelatedLoanInvestorType = v140;
                var v141 = _freddieRelatedLoanLienPosition; v141.Clean = value; _freddieRelatedLoanLienPosition = v141;
                var v142 = _freddieRelatedLoanType; v142.Clean = value; _freddieRelatedLoanType = v142;
                var v143 = _freddieSectionOfAct; v143.Clean = value; _freddieSectionOfAct = v143;
                var v144 = _freddieUnderwritingTypeOther; v144.Clean = value; _freddieUnderwritingTypeOther = v144;
                var v145 = _ginnieConstructionMethodType; v145.Clean = value; _ginnieConstructionMethodType = v145;
                var v146 = _ginnieGovernmentAnnualPremiumAmount; v146.Clean = value; _ginnieGovernmentAnnualPremiumAmount = v146;
                var v147 = _ginnieMortgageType; v147.Clean = value; _ginnieMortgageType = v147;
                var v148 = _ginnieOtherConstructionMethodType; v148.Clean = value; _ginnieOtherConstructionMethodType = v148;
                var v149 = _governmentAnnualPremiumPercent; v149.Clean = value; _governmentAnnualPremiumPercent = v149;
                var v150 = _governmentRefinanceType; v150.Clean = value; _governmentRefinanceType = v150;
                var v151 = _governmentUpfrontPremiumAmount; v151.Clean = value; _governmentUpfrontPremiumAmount = v151;
                var v152 = _governmentUpfrontPremiumPercent; v152.Clean = value; _governmentUpfrontPremiumPercent = v152;
                var v153 = _gSEProjectType; v153.Clean = value; _gSEProjectType = v153;
                var v154 = _guaranteeFeeAddOnIndicator; v154.Clean = value; _guaranteeFeeAddOnIndicator = v154;
                var v155 = _guarantyFeeAfterAlternatePaymentMethodPercent; v155.Clean = value; _guarantyFeeAfterAlternatePaymentMethodPercent = v155;
                var v156 = _guarantyFeePercent; v156.Clean = value; _guarantyFeePercent = v156;
                var v157 = _guarantyPercent; v157.Clean = value; _guarantyPercent = v157;
                var v158 = _id; v158.Clean = value; _id = v158;
                var v159 = _indexType; v159.Clean = value; _indexType = v159;
                var v160 = _initialFixedPeriodEffectiveMonthsCount; v160.Clean = value; _initialFixedPeriodEffectiveMonthsCount = v160;
                var v161 = _interestAccrualType; v161.Clean = value; _interestAccrualType = v161;
                var v162 = _interestAndPaymentAdjustmentIndexLeadDaysCount; v162.Clean = value; _interestAndPaymentAdjustmentIndexLeadDaysCount = v162;
                var v163 = _interestCalculationBasisType; v163.Clean = value; _interestCalculationBasisType = v163;
                var v164 = _interestCalculationEffectiveMonthsCount; v164.Clean = value; _interestCalculationEffectiveMonthsCount = v164;
                var v165 = _interestCalculationType; v165.Clean = value; _interestCalculationType = v165;
                var v166 = _investorCollateralProgramIdentifier; v166.Clean = value; _investorCollateralProgramIdentifier = v166;
                var v167 = _investorCommitmentIdentifier; v167.Clean = value; _investorCommitmentIdentifier = v167;
                var v168 = _investorFeatureIdentifier; v168.Clean = value; _investorFeatureIdentifier = v168;
                var v169 = _investorFeatureIdPool; v169.Clean = value; _investorFeatureIdPool = v169;
                var v170 = _investorOwnershipPercent; v170.Clean = value; _investorOwnershipPercent = v170;
                var v171 = _investorProductPlanIdentifier; v171.Clean = value; _investorProductPlanIdentifier = v171;
                var v172 = _investorRemittanceDay; v172.Clean = value; _investorRemittanceDay = v172;
                var v173 = _investorRemittanceType; v173.Clean = value; _investorRemittanceType = v173;
                var v174 = _issuerIdentifier; v174.Clean = value; _issuerIdentifier = v174;
                var v175 = _lastPaidInstallmentDueDate; v175.Clean = value; _lastPaidInstallmentDueDate = v175;
                var v176 = _lastPaymentReceivedDate; v176.Clean = value; _lastPaymentReceivedDate = v176;
                var v177 = _latestConversionEffectiveDate; v177.Clean = value; _latestConversionEffectiveDate = v177;
                var v178 = _lenderPaidMIInterestRateAdjustmentPercent; v178.Clean = value; _lenderPaidMIInterestRateAdjustmentPercent = v178;
                var v179 = _lendersDeliveryDate; v179.Clean = value; _lendersDeliveryDate = v179;
                var v180 = _loanAcquisitionScheduledUPBAmount; v180.Clean = value; _loanAcquisitionScheduledUPBAmount = v180;
                var v181 = _loanAmortizationMaximumTermMonthsCount; v181.Clean = value; _loanAmortizationMaximumTermMonthsCount = v181;
                var v182 = _loanBuyupBuydownBasisPointNumber; v182.Clean = value; _loanBuyupBuydownBasisPointNumber = v182;
                var v183 = _loanBuyupBuydownType; v183.Clean = value; _loanBuyupBuydownType = v183;
                var v184 = _loanDefaultLossPartyType; v184.Clean = value; _loanDefaultLossPartyType = v184;
                var v185 = _loanDeliveredThroughServicingReleasedProcessIndicator; v185.Clean = value; _loanDeliveredThroughServicingReleasedProcessIndicator = v185;
                var v186 = _loanIdentifierValueType; v186.Clean = value; _loanIdentifierValueType = v186;
                var v187 = _loanInterestAccrualStartDate; v187.Clean = value; _loanInterestAccrualStartDate = v187;
                var v188 = _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; v188.Clean = value; _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = v188;
                var v189 = _loanLevelCreditScoreSelectionMethodType; v189.Clean = value; _loanLevelCreditScoreSelectionMethodType = v189;
                var v190 = _loanLevelCreditScoreValue; v190.Clean = value; _loanLevelCreditScoreValue = v190;
                var v191 = _loanModificationEffectiveDate; v191.Clean = value; _loanModificationEffectiveDate = v191;
                var v192 = _loanStateDate; v192.Clean = value; _loanStateDate = v192;
                var v193 = _manufacturedHomeWidthType; v193.Clean = value; _manufacturedHomeWidthType = v193;
                var v194 = _mBSWeightedMarginIndicator; v194.Clean = value; _mBSWeightedMarginIndicator = v194;
                var v195 = _mERSOriginalMortgageeOfRecordIndicator; v195.Clean = value; _mERSOriginalMortgageeOfRecordIndicator = v195;
                var v196 = _mICompanyNameType; v196.Clean = value; _mICompanyNameType = v196;
                var v197 = _mIPremiumSourceType; v197.Clean = value; _mIPremiumSourceType = v197;
                var v198 = _monetaryEventAppliedDate; v198.Clean = value; _monetaryEventAppliedDate = v198;
                var v199 = _monetaryEventGrossPrincipalAmount; v199.Clean = value; _monetaryEventGrossPrincipalAmount = v199;
                var v200 = _monetaryEventType; v200.Clean = value; _monetaryEventType = v200;
                var v201 = _mortgageBackedSecurityIndicator; v201.Clean = value; _mortgageBackedSecurityIndicator = v201;
                var v202 = _mortgageModificationIndicator; v202.Clean = value; _mortgageModificationIndicator = v202;
                var v203 = _mortgageOriginator; v203.Clean = value; _mortgageOriginator = v203;
                var v204 = _mortgageProgramType; v204.Clean = value; _mortgageProgramType = v204;
                var v205 = _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; v205.Clean = value; _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = v205;
                var v206 = _nextRateAdjustmentEffectiveDate; v206.Clean = value; _nextRateAdjustmentEffectiveDate = v206;
                var v207 = _notePayToName; v207.Clean = value; _notePayToName = v207;
                var v208 = _numberOfUnitsSold; v208.Clean = value; _numberOfUnitsSold = v208;
                var v209 = _otherDownPaymentFundsType; v209.Clean = value; _otherDownPaymentFundsType = v209;
                var v210 = _otherFundsCollectedAtClosingAmount; v210.Clean = value; _otherFundsCollectedAtClosingAmount = v210;
                var v211 = _otherFundsCollectedAtClosingType; v211.Clean = value; _otherFundsCollectedAtClosingType = v211;
                var v212 = _payeeID; v212.Clean = value; _payeeID = v212;
                var v213 = _paymentBillingStatementLeadDaysCount; v213.Clean = value; _paymentBillingStatementLeadDaysCount = v213;
                var v214 = _perChangeMaximumDecreaseRatePercent; v214.Clean = value; _perChangeMaximumDecreaseRatePercent = v214;
                var v215 = _perChangeMaximumIncreaseRatePercent; v215.Clean = value; _perChangeMaximumIncreaseRatePercent = v215;
                var v216 = _perChangePrincipalAndInterestPaymentAdjustmentPercent; v216.Clean = value; _perChangePrincipalAndInterestPaymentAdjustmentPercent = v216;
                var v217 = _perChangeRateAdjustmentEffectiveDate; v217.Clean = value; _perChangeRateAdjustmentEffectiveDate = v217;
                var v218 = _perChangeRateAdjustmentFrequencyMonthsCount; v218.Clean = value; _perChangeRateAdjustmentFrequencyMonthsCount = v218;
                var v219 = _poolAccrualRateStructureType; v219.Clean = value; _poolAccrualRateStructureType = v219;
                var v220 = _poolAmortizationType; v220.Clean = value; _poolAmortizationType = v220;
                var v221 = _poolAssumabilityIndicator; v221.Clean = value; _poolAssumabilityIndicator = v221;
                var v222 = _poolBalloonIndicator; v222.Clean = value; _poolBalloonIndicator = v222;
                var v223 = _poolCertificatePaymentDate; v223.Clean = value; _poolCertificatePaymentDate = v223;
                var v224 = _poolClassType; v224.Clean = value; _poolClassType = v224;
                var v225 = _poolConcurrentTransferIndicator; v225.Clean = value; _poolConcurrentTransferIndicator = v225;
                var v226 = _poolCurrentLoanCount; v226.Clean = value; _poolCurrentLoanCount = v226;
                var v227 = _poolCurrentPrincipalBalanceAmount; v227.Clean = value; _poolCurrentPrincipalBalanceAmount = v227;
                var v228 = _poolDocumentCustodianID; v228.Clean = value; _poolDocumentCustodianID = v228;
                var v229 = _poolFixedServicingFeePercent; v229.Clean = value; _poolFixedServicingFeePercent = v229;
                var v230 = _poolIdentifier; v230.Clean = value; _poolIdentifier = v230;
                var v231 = _poolingMethodType; v231.Clean = value; _poolingMethodType = v231;
                var v232 = _poolInterestAdjustmentEffectiveDate; v232.Clean = value; _poolInterestAdjustmentEffectiveDate = v232;
                var v233 = _poolInterestAdjustmentIndexLeadDaysCount; v233.Clean = value; _poolInterestAdjustmentIndexLeadDaysCount = v233;
                var v234 = _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; v234.Clean = value; _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = v234;
                var v235 = _poolInterestOnlyIndicator; v235.Clean = value; _poolInterestOnlyIndicator = v235;
                var v236 = _poolInterestRateRoundingPercent; v236.Clean = value; _poolInterestRateRoundingPercent = v236;
                var v237 = _poolInterestRateRoundingType; v237.Clean = value; _poolInterestRateRoundingType = v237;
                var v238 = _poolInvestorProductPlanIdentifier; v238.Clean = value; _poolInvestorProductPlanIdentifier = v238;
                var v239 = _poolIssueDate; v239.Clean = value; _poolIssueDate = v239;
                var v240 = _poolIssuerTransferee; v240.Clean = value; _poolIssuerTransferee = v240;
                var v241 = _poolMarginRatePercent; v241.Clean = value; _poolMarginRatePercent = v241;
                var v242 = _poolMaturityDate; v242.Clean = value; _poolMaturityDate = v242;
                var v243 = _poolMaturityPeriodCount; v243.Clean = value; _poolMaturityPeriodCount = v243;
                var v244 = _poolMaximumAccrualRatePercent; v244.Clean = value; _poolMaximumAccrualRatePercent = v244;
                var v245 = _poolMinimumAccrualRatePercent; v245.Clean = value; _poolMinimumAccrualRatePercent = v245;
                var v246 = _poolMortgageType; v246.Clean = value; _poolMortgageType = v246;
                var v247 = _poolScheduledRemittancePaymentDay; v247.Clean = value; _poolScheduledRemittancePaymentDay = v247;
                var v248 = _poolSecurityIssueDateInterestRatePercent; v248.Clean = value; _poolSecurityIssueDateInterestRatePercent = v248;
                var v249 = _poolSellerID; v249.Clean = value; _poolSellerID = v249;
                var v250 = _poolServicerID; v250.Clean = value; _poolServicerID = v250;
                var v251 = _poolStructureType; v251.Clean = value; _poolStructureType = v251;
                var v252 = _poolSuffixIdentifier; v252.Clean = value; _poolSuffixIdentifier = v252;
                var v253 = _priceLockDatetime; v253.Clean = value; _priceLockDatetime = v253;
                var v254 = _primaryMIAbsenceReasonType; v254.Clean = value; _primaryMIAbsenceReasonType = v254;
                var v255 = _primaryMIAbsenceReasonTypeOtherDescription; v255.Clean = value; _primaryMIAbsenceReasonTypeOtherDescription = v255;
                var v256 = _projectAttachmentType; v256.Clean = value; _projectAttachmentType = v256;
                var v257 = _projectDesignType; v257.Clean = value; _projectDesignType = v257;
                var v258 = _projectUnitCount; v258.Clean = value; _projectUnitCount = v258;
                var v259 = _propertyValuationEffectiveDate; v259.Clean = value; _propertyValuationEffectiveDate = v259;
                var v260 = _propertyValuationMethodType; v260.Clean = value; _propertyValuationMethodType = v260;
                var v261 = _refinanceCashOutAmount; v261.Clean = value; _refinanceCashOutAmount = v261;
                var v262 = _refinanceCashOutDeterminationType; v262.Clean = value; _refinanceCashOutDeterminationType = v262;
                var v263 = _relatedLoanBalloonIndicator; v263.Clean = value; _relatedLoanBalloonIndicator = v263;
                var v264 = _relatedLoanHELOCIndicator; v264.Clean = value; _relatedLoanHELOCIndicator = v264;
                var v265 = _relatedLoanIndicator; v265.Clean = value; _relatedLoanIndicator = v265;
                var v266 = _relatedLoanInvestorType; v266.Clean = value; _relatedLoanInvestorType = v266;
                var v267 = _relatedLoanMaturityPeriodCount; v267.Clean = value; _relatedLoanMaturityPeriodCount = v267;
                var v268 = _relatedLoanNoteDate; v268.Clean = value; _relatedLoanNoteDate = v268;
                var v269 = _relatedLoanScheduledFirstPaymentDate; v269.Clean = value; _relatedLoanScheduledFirstPaymentDate = v269;
                var v270 = _relatedLoanStateDateAtClosing; v270.Clean = value; _relatedLoanStateDateAtClosing = v270;
                var v271 = _relatedLoanUnpaidPrincipalBalanceAmount; v271.Clean = value; _relatedLoanUnpaidPrincipalBalanceAmount = v271;
                var v272 = _relocationLoanIndicator; v272.Clean = value; _relocationLoanIndicator = v272;
                var v273 = _rEOMarketingPartyType; v273.Clean = value; _rEOMarketingPartyType = v273;
                var v274 = _secondLienIsDeliveredIndicator; v274.Clean = value; _secondLienIsDeliveredIndicator = v274;
                var v275 = _securityOriginalSubscriptionAmount; v275.Clean = value; _securityOriginalSubscriptionAmount = v275;
                var v276 = _securityTradeBookEntryDate; v276.Clean = value; _securityTradeBookEntryDate = v276;
                var v277 = _sellerID; v277.Clean = value; _sellerID = v277;
                var v278 = _sellerLoanIdentifier; v278.Clean = value; _sellerLoanIdentifier = v278;
                var v279 = _servicerID; v279.Clean = value; _servicerID = v279;
                var v280 = _servicerLoanIdentifier; v280.Clean = value; _servicerLoanIdentifier = v280;
                var v281 = _sharedEquityIndicator; v281.Clean = value; _sharedEquityIndicator = v281;
                var v282 = _siteBuiltIndicator; v282.Clean = value; _siteBuiltIndicator = v282;
                var v283 = _specialFloodHazardAreaIndicator; v283.Clean = value; _specialFloodHazardAreaIndicator = v283;
                var v284 = _subsequentPerChangeMaximumDecreaseRatePercent; v284.Clean = value; _subsequentPerChangeMaximumDecreaseRatePercent = v284;
                var v285 = _subsequentPerChangeMaximumIncreaseRatePercent; v285.Clean = value; _subsequentPerChangeMaximumIncreaseRatePercent = v285;
                var v286 = _subsequentPerChangeRateAdjustmentEffectiveDate; v286.Clean = value; _subsequentPerChangeRateAdjustmentEffectiveDate = v286;
                var v287 = _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; v287.Clean = value; _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = v287;
                var v288 = _temporaryBuydownIndicator; v288.Clean = value; _temporaryBuydownIndicator = v288;
                var v289 = _totalMortgagedPropertiesCount; v289.Clean = value; _totalMortgagedPropertiesCount = v289;
                var v290 = _unit1SubjectPropertyGrossRentalIncome; v290.Clean = value; _unit1SubjectPropertyGrossRentalIncome = v290;
                var v291 = _unit1TotalBedrooms; v291.Clean = value; _unit1TotalBedrooms = v291;
                var v292 = _unit2SubjectPropertyGrossRentalIncome; v292.Clean = value; _unit2SubjectPropertyGrossRentalIncome = v292;
                var v293 = _unit2TotalBedrooms; v293.Clean = value; _unit2TotalBedrooms = v293;
                var v294 = _unit3SubjectPropertyGrossRentalIncome; v294.Clean = value; _unit3SubjectPropertyGrossRentalIncome = v294;
                var v295 = _unit3TotalBedrooms; v295.Clean = value; _unit3TotalBedrooms = v295;
                var v296 = _unit4SubjectPropertyGrossRentalIncome; v296.Clean = value; _unit4SubjectPropertyGrossRentalIncome = v296;
                var v297 = _unit4TotalBedrooms; v297.Clean = value; _unit4TotalBedrooms = v297;
                var v298 = _uPBAmount; v298.Clean = value; _uPBAmount = v298;
                _settingClean = 0;
            }
        }
    }
}