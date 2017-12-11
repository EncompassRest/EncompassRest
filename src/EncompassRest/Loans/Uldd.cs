#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Uldd : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aCHABARoutingAndTransitIdentifier;
        public string ACHABARoutingAndTransitIdentifier { get => _aCHABARoutingAndTransitIdentifier; set => _aCHABARoutingAndTransitIdentifier = value; }
        private DirtyValue<string> _aCHABARoutingAndTransitNumber;
        public string ACHABARoutingAndTransitNumber { get => _aCHABARoutingAndTransitNumber; set => _aCHABARoutingAndTransitNumber = value; }
        private DirtyValue<string> _aCHBankAccountDescription;
        public string ACHBankAccountDescription { get => _aCHBankAccountDescription; set => _aCHBankAccountDescription = value; }
        private DirtyValue<string> _aCHBankAccountIdentifier;
        public string ACHBankAccountIdentifier { get => _aCHBankAccountIdentifier; set => _aCHBankAccountIdentifier = value; }
        private DirtyValue<string> _aCHBankAccountPurposeTransitIdentifier;
        public string ACHBankAccountPurposeTransitIdentifier { get => _aCHBankAccountPurposeTransitIdentifier; set => _aCHBankAccountPurposeTransitIdentifier = value; }
        private DirtyValue<StringEnumValue<ACHBankAccountPurposeType>> _aCHBankAccountPurposeType;
        public StringEnumValue<ACHBankAccountPurposeType> ACHBankAccountPurposeType { get => _aCHBankAccountPurposeType; set => _aCHBankAccountPurposeType = value; }
        private DirtyValue<string> _aCHInstitutionTelegraphicAbbreviationName;
        public string ACHInstitutionTelegraphicAbbreviationName { get => _aCHInstitutionTelegraphicAbbreviationName; set => _aCHInstitutionTelegraphicAbbreviationName = value; }
        private DirtyValue<string> _aCHReceiverSubaccountName;
        public string ACHReceiverSubaccountName { get => _aCHReceiverSubaccountName; set => _aCHReceiverSubaccountName = value; }
        private DirtyValue<bool?> _additionalPrincipalAmountIndicator;
        public bool? AdditionalPrincipalAmountIndicator { get => _additionalPrincipalAmountIndicator; set => _additionalPrincipalAmountIndicator = value; }
        private DirtyValue<decimal?> _aggregateLoanCurtailmentAmount;
        public decimal? AggregateLoanCurtailmentAmount { get => _aggregateLoanCurtailmentAmount; set => _aggregateLoanCurtailmentAmount = value; }
        private DirtyValue<string> _appraisalIdentifier;
        public string AppraisalIdentifier { get => _appraisalIdentifier; set => _appraisalIdentifier = value; }
        private DirtyValue<StringEnumValue<AttachmentType>> _attachmentType;
        public StringEnumValue<AttachmentType> AttachmentType { get => _attachmentType; set => _attachmentType = value; }
        private DirtyValue<StringEnumValue<AVMModelNameType>> _aVMModelNameType;
        public StringEnumValue<AVMModelNameType> AVMModelNameType { get => _aVMModelNameType; set => _aVMModelNameType = value; }
        private DirtyValue<bool?> _balloonResetIndicator;
        public bool? BalloonResetIndicator { get => _balloonResetIndicator; set => _balloonResetIndicator = value; }
        private DirtyValue<decimal?> _baseGuarantyFeePercent;
        public decimal? BaseGuarantyFeePercent { get => _baseGuarantyFeePercent; set => _baseGuarantyFeePercent = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _bondFinancePool;
        public StringEnumValue<TrueOrFalse> BondFinancePool { get => _bondFinancePool; set => _bondFinancePool = value; }
        private DirtyValue<string> _bondFinanceProgramName;
        public string BondFinanceProgramName { get => _bondFinanceProgramName; set => _bondFinanceProgramName = value; }
        private DirtyValue<StringEnumValue<BondFinanceProgramType>> _bondFinanceProgramType;
        public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get => _bondFinanceProgramType; set => _bondFinanceProgramType = value; }
        private DirtyValue<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get => _borrowerMailToAddressSameasPropertyIndicator; set => _borrowerMailToAddressSameasPropertyIndicator = value; }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _borrowerType;
        public StringEnumValue<UlddBorrowerType> BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<bool?> _capitalizedLoanIndicator;
        public bool? CapitalizedLoanIndicator { get => _capitalizedLoanIndicator; set => _capitalizedLoanIndicator = value; }
        private DirtyValue<string> _certificateIdentifier;
        public string CertificateIdentifier { get => _certificateIdentifier; set => _certificateIdentifier = value; }
        private DirtyValue<DateTime?> _certificateMaturityDate;
        public DateTime? CertificateMaturityDate { get => _certificateMaturityDate; set => _certificateMaturityDate = value; }
        private DirtyValue<decimal?> _certificatePrincipalBalanceAmount;
        public decimal? CertificatePrincipalBalanceAmount { get => _certificatePrincipalBalanceAmount; set => _certificatePrincipalBalanceAmount = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _certificateType;
        public StringEnumValue<TrueOrFalse> CertificateType { get => _certificateType; set => _certificateType = value; }
        private DirtyValue<decimal?> _closingCost2ContributionAmount;
        public decimal? ClosingCost2ContributionAmount { get => _closingCost2ContributionAmount; set => _closingCost2ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost2FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get => _closingCost2FundsType; set => _closingCost2FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost2FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get => _closingCost2FundsTypeOtherDescription; set => _closingCost2FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost2SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get => _closingCost2SourceType; set => _closingCost2SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost2SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get => _closingCost2SourceTypeOtherDescription; set => _closingCost2SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCost3ContributionAmount;
        public decimal? ClosingCost3ContributionAmount { get => _closingCost3ContributionAmount; set => _closingCost3ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost3FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get => _closingCost3FundsType; set => _closingCost3FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost3FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get => _closingCost3FundsTypeOtherDescription; set => _closingCost3FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost3SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get => _closingCost3SourceType; set => _closingCost3SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost3SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get => _closingCost3SourceTypeOtherDescription; set => _closingCost3SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCost4ContributionAmount;
        public decimal? ClosingCost4ContributionAmount { get => _closingCost4ContributionAmount; set => _closingCost4ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost4FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get => _closingCost4FundsType; set => _closingCost4FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost4FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get => _closingCost4FundsTypeOtherDescription; set => _closingCost4FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost4SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get => _closingCost4SourceType; set => _closingCost4SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost4SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get => _closingCost4SourceTypeOtherDescription; set => _closingCost4SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCostContributionAmount;
        public decimal? ClosingCostContributionAmount { get => _closingCostContributionAmount; set => _closingCostContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCostFundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get => _closingCostFundsType; set => _closingCostFundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCostFundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get => _closingCostFundsTypeOtherDescription; set => _closingCostFundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCostSourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get => _closingCostSourceType; set => _closingCostSourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCostSourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get => _closingCostSourceTypeOtherDescription; set => _closingCostSourceTypeOtherDescription = value; }
        private DirtyValue<string> _coBorrowerCountryCode;
        public string CoBorrowerCountryCode { get => _coBorrowerCountryCode; set => _coBorrowerCountryCode = value; }
        private DirtyValue<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get => _coBorrowerMailToAddressSameasPropertyIndicator; set => _coBorrowerMailToAddressSameasPropertyIndicator = value; }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _coBorrowerType;
        public StringEnumValue<UlddBorrowerType> CoBorrowerType { get => _coBorrowerType; set => _coBorrowerType = value; }
        private DirtyValue<StringEnumValue<CondominiumProjectStatusType>> _condominiumProjectStatusType;
        public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get => _condominiumProjectStatusType; set => _condominiumProjectStatusType = value; }
        private DirtyValue<StringEnumValue<ConstructionMethodType>> _constructionMethodType;
        public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get => _constructionMethodType; set => _constructionMethodType = value; }
        private DirtyValue<string> _constructionMethodTypeOtherDescription;
        public string ConstructionMethodTypeOtherDescription { get => _constructionMethodTypeOtherDescription; set => _constructionMethodTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingFeatureType>> _constructionToPermanentClosingFeatureType;
        public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get => _constructionToPermanentClosingFeatureType; set => _constructionToPermanentClosingFeatureType = value; }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingType>> _constructionToPermanentClosingType;
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => _constructionToPermanentClosingType; set => _constructionToPermanentClosingType = value; }
        private DirtyValue<StringEnumValue<ConvertibleStatusType>> _convertibleStatusType;
        public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get => _convertibleStatusType; set => _convertibleStatusType = value; }
        private DirtyValue<StringEnumValue<CounselingFormatType>> _counselingFormatType;
        public StringEnumValue<CounselingFormatType> CounselingFormatType { get => _counselingFormatType; set => _counselingFormatType = value; }
        private DirtyValue<StringEnumValue<CounselingFormatTypeOtherDescription>> _counselingFormatTypeOtherDescription;
        public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get => _counselingFormatTypeOtherDescription; set => _counselingFormatTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<CounselTypeOther>> _counselTypeOther;
        public StringEnumValue<CounselTypeOther> CounselTypeOther { get => _counselTypeOther; set => _counselTypeOther = value; }
        private DirtyValue<string> _countryCode;
        public string CountryCode { get => _countryCode; set => _countryCode = value; }
        private DirtyValue<StringEnumValue<CreditScoreImpairmentType>> _creditScoreImpairmentType;
        public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get => _creditScoreImpairmentType; set => _creditScoreImpairmentType = value; }
        private DirtyValue<decimal?> _currentAccruedInterestAmount;
        public decimal? CurrentAccruedInterestAmount { get => _currentAccruedInterestAmount; set => _currentAccruedInterestAmount = value; }
        private DirtyValue<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get => _delinquentPaymentsOverPastTwelveMonthsCount; set => _delinquentPaymentsOverPastTwelveMonthsCount = value; }
        private DirtyValue<string> _documentCustodianID;
        public string DocumentCustodianID { get => _documentCustodianID; set => _documentCustodianID = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentRequiredIndicator;
        public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get => _documentRequiredIndicator; set => _documentRequiredIndicator = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentSubmissionIndicator;
        public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get => _documentSubmissionIndicator; set => _documentSubmissionIndicator = value; }
        private DirtyValue<StringEnumValue<DownPaymentFundsType>> _downPaymentFundsType;
        public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get => _downPaymentFundsType; set => _downPaymentFundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _downPaymentOtherTypeDescription;
        public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get => _downPaymentOtherTypeDescription; set => _downPaymentOtherTypeDescription = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _downPaymentSourceType;
        public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get => _downPaymentSourceType; set => _downPaymentSourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _downPaymentSourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get => _downPaymentSourceTypeOtherDescription; set => _downPaymentSourceTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<FannieARMIndexType>> _fannieARMIndexType;
        public StringEnumValue<FannieARMIndexType> FannieARMIndexType { get => _fannieARMIndexType; set => _fannieARMIndexType = value; }
        private DirtyValue<StringEnumValue<FannieAutoUWDec>> _fannieAutoUWDec;
        public StringEnumValue<FannieAutoUWDec> FannieAutoUWDec { get => _fannieAutoUWDec; set => _fannieAutoUWDec = value; }
        private DirtyValue<int?> _fannieBLTV;
        public int? FannieBLTV { get => _fannieBLTV; set => _fannieBLTV = value; }
        private DirtyValue<string> _fannieBorrowerFirstName;
        public string FannieBorrowerFirstName { get => _fannieBorrowerFirstName; set => _fannieBorrowerFirstName = value; }
        private DirtyValue<string> _fannieBorrowerMiddleName;
        public string FannieBorrowerMiddleName { get => _fannieBorrowerMiddleName; set => _fannieBorrowerMiddleName = value; }
        private DirtyValue<StringEnumValue<FannieBuydownContributer>> _fannieBuydownContributer;
        public StringEnumValue<FannieBuydownContributer> FannieBuydownContributer { get => _fannieBuydownContributer; set => _fannieBuydownContributer = value; }
        private DirtyValue<int?> _fannieCLTV;
        public int? FannieCLTV { get => _fannieCLTV; set => _fannieCLTV = value; }
        private DirtyValue<string> _fannieCoBorrowerFirstName;
        public string FannieCoBorrowerFirstName { get => _fannieCoBorrowerFirstName; set => _fannieCoBorrowerFirstName = value; }
        private DirtyValue<string> _fannieCoBorrowerMiddleName;
        public string FannieCoBorrowerMiddleName { get => _fannieCoBorrowerMiddleName; set => _fannieCoBorrowerMiddleName = value; }
        private DirtyValue<string> _fannieCreditScoreProviderName;
        public string FannieCreditScoreProviderName { get => _fannieCreditScoreProviderName; set => _fannieCreditScoreProviderName = value; }
        private DirtyValue<StringEnumValue<FannieFloodSpecialFeatureCode>> _fannieFloodSpecialFeatureCode;
        public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get => _fannieFloodSpecialFeatureCode; set => _fannieFloodSpecialFeatureCode = value; }
        private DirtyValue<int?> _fannieHCLTV;
        public int? FannieHCLTV { get => _fannieHCLTV; set => _fannieHCLTV = value; }
        private DirtyValue<int?> _fannieInvestorOwnershipPercent;
        public int? FannieInvestorOwnershipPercent { get => _fannieInvestorOwnershipPercent; set => _fannieInvestorOwnershipPercent = value; }
        private DirtyValue<StringEnumValue<FannieLegalEntityType>> _fannieLegalEntityType;
        public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get => _fannieLegalEntityType; set => _fannieLegalEntityType = value; }
        private DirtyValue<StringEnumValue<FannieLegalEntityTypeOther>> _fannieLegalEntityTypeOther;
        public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get => _fannieLegalEntityTypeOther; set => _fannieLegalEntityTypeOther = value; }
        private DirtyValue<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get => _fannieLenderPaidMIInterestRateAdjustmentPercent; set => _fannieLenderPaidMIInterestRateAdjustmentPercent = value; }
        private DirtyValue<StringEnumValue<FannieLoanProgramIdentifier>> _fannieLoanProgramIdentifier;
        public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get => _fannieLoanProgramIdentifier; set => _fannieLoanProgramIdentifier = value; }
        private DirtyValue<int?> _fannieLTV;
        public int? FannieLTV { get => _fannieLTV; set => _fannieLTV = value; }
        private DirtyValue<StringEnumValue<FannieMICompanyNameTypeOther>> _fannieMICompanyNameTypeOther;
        public StringEnumValue<FannieMICompanyNameTypeOther> FannieMICompanyNameTypeOther { get => _fannieMICompanyNameTypeOther; set => _fannieMICompanyNameTypeOther = value; }
        private DirtyValue<int?> _fannieMICoveragePercent;
        public int? FannieMICoveragePercent { get => _fannieMICoveragePercent; set => _fannieMICoveragePercent = value; }
        private DirtyValue<int?> _fanniePoolOwnershipPercent;
        public int? FanniePoolOwnershipPercent { get => _fanniePoolOwnershipPercent; set => _fanniePoolOwnershipPercent = value; }
        private DirtyValue<StringEnumValue<FannieProjectClassificationType>> _fannieProjectClassificationType;
        public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get => _fannieProjectClassificationType; set => _fannieProjectClassificationType = value; }
        private DirtyValue<StringEnumValue<FanniePropertyFormType>> _fanniePropertyFormType;
        public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get => _fanniePropertyFormType; set => _fanniePropertyFormType = value; }
        private DirtyValue<decimal?> _fannieRateSpread;
        public decimal? FannieRateSpread { get => _fannieRateSpread; set => _fannieRateSpread = value; }
        private DirtyValue<StringEnumValue<FannieRefinanceType>> _fannieRefinanceType;
        public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get => _fannieRefinanceType; set => _fannieRefinanceType = value; }
        private DirtyValue<string> _fannieRelatedInvestorLoanID;
        public string FannieRelatedInvestorLoanID { get => _fannieRelatedInvestorLoanID; set => _fannieRelatedInvestorLoanID = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanAmortizationType>> _fannieRelatedLoanAmortizationType;
        public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get => _fannieRelatedLoanAmortizationType; set => _fannieRelatedLoanAmortizationType = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanLienPosition>> _fannieRelatedLoanLienPosition;
        public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get => _fannieRelatedLoanLienPosition; set => _fannieRelatedLoanLienPosition = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanType>> _fannieRelatedLoanType;
        public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get => _fannieRelatedLoanType; set => _fannieRelatedLoanType = value; }
        private DirtyValue<StringEnumValue<FannieSectionOfAct>> _fannieSectionOfAct;
        public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get => _fannieSectionOfAct; set => _fannieSectionOfAct = value; }
        private DirtyValue<int?> _fannieTLTV;
        public int? FannieTLTV { get => _fannieTLTV; set => _fannieTLTV = value; }
        private DirtyValue<string> _fannieTrustName;
        public string FannieTrustName { get => _fannieTrustName; set => _fannieTrustName = value; }
        private DirtyValue<StringEnumValue<FannnieMortgageType>> _fannnieMortgageType;
        public StringEnumValue<FannnieMortgageType> FannnieMortgageType { get => _fannnieMortgageType; set => _fannnieMortgageType = value; }
        private DirtyValue<int?> _financedUnitCount;
        public int? FinancedUnitCount { get => _financedUnitCount; set => _financedUnitCount = value; }
        private DirtyValue<DateTime?> _firstRateChangePaymentEffectiveDate;
        public DateTime? FirstRateChangePaymentEffectiveDate { get => _firstRateChangePaymentEffectiveDate; set => _firstRateChangePaymentEffectiveDate = value; }
        private DirtyValue<StringEnumValue<FNMHomeImprovementProductType>> _fNMHomeImprovementProductType;
        public StringEnumValue<FNMHomeImprovementProductType> FNMHomeImprovementProductType { get => _fNMHomeImprovementProductType; set => _fNMHomeImprovementProductType = value; }
        private DirtyValue<StringEnumValue<FreddieARMIndexType>> _freddieARMIndexType;
        public StringEnumValue<FreddieARMIndexType> FreddieARMIndexType { get => _freddieARMIndexType; set => _freddieARMIndexType = value; }
        private DirtyValue<StringEnumValue<FreddieAutoUWDec>> _freddieAutoUWDec;
        public StringEnumValue<FreddieAutoUWDec> FreddieAutoUWDec { get => _freddieAutoUWDec; set => _freddieAutoUWDec = value; }
        private DirtyValue<StringEnumValue<FreddieAVMModelNameTypeExpl>> _freddieAVMModelNameTypeExpl;
        public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAVMModelNameTypeExpl { get => _freddieAVMModelNameTypeExpl; set => _freddieAVMModelNameTypeExpl = value; }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieBorrowerAlienStatus;
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get => _freddieBorrowerAlienStatus; set => _freddieBorrowerAlienStatus = value; }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieCoBorrowerAlienStatus;
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get => _freddieCoBorrowerAlienStatus; set => _freddieCoBorrowerAlienStatus = value; }
        private DirtyValue<string> _freddieCreditScoreProviderName;
        public string FreddieCreditScoreProviderName { get => _freddieCreditScoreProviderName; set => _freddieCreditScoreProviderName = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPaymentType;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get => _freddieDownPaymentType; set => _freddieDownPaymentType = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt2SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get => _freddieDownPmt2SourceType; set => _freddieDownPmt2SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt2SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get => _freddieDownPmt2SourceTypeExpl; set => _freddieDownPmt2SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt2Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get => _freddieDownPmt2Type; set => _freddieDownPmt2Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt2TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get => _freddieDownPmt2TypeExpl; set => _freddieDownPmt2TypeExpl = value; }
        private DirtyValue<decimal?> _freddieDownPmt3Amt;
        public decimal? FreddieDownPmt3Amt { get => _freddieDownPmt3Amt; set => _freddieDownPmt3Amt = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt3SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get => _freddieDownPmt3SourceType; set => _freddieDownPmt3SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt3SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get => _freddieDownPmt3SourceTypeExpl; set => _freddieDownPmt3SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt3Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get => _freddieDownPmt3Type; set => _freddieDownPmt3Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt3TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get => _freddieDownPmt3TypeExpl; set => _freddieDownPmt3TypeExpl = value; }
        private DirtyValue<decimal?> _freddieDownPmt4Amt;
        public decimal? FreddieDownPmt4Amt { get => _freddieDownPmt4Amt; set => _freddieDownPmt4Amt = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt4SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get => _freddieDownPmt4SourceType; set => _freddieDownPmt4SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt4SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get => _freddieDownPmt4SourceTypeExpl; set => _freddieDownPmt4SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt4Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get => _freddieDownPmt4Type; set => _freddieDownPmt4Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt4TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get => _freddieDownPmt4TypeExpl; set => _freddieDownPmt4TypeExpl = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieExplanationOfDownPayment;
        public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get => _freddieExplanationOfDownPayment; set => _freddieExplanationOfDownPayment = value; }
        private DirtyValue<StringEnumValue<FreddieInvestorCollateralProgramIdentifier>> _freddieInvestorCollateralProgramIdentifier;
        public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get => _freddieInvestorCollateralProgramIdentifier; set => _freddieInvestorCollateralProgramIdentifier = value; }
        private DirtyValue<string> _freddieInvestorFeatureIdentifier;
        public string FreddieInvestorFeatureIdentifier { get => _freddieInvestorFeatureIdentifier; set => _freddieInvestorFeatureIdentifier = value; }
        private DirtyValue<StringEnumValue<FreddieLegalEntityType>> _freddieLegalEntityType;
        public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get => _freddieLegalEntityType; set => _freddieLegalEntityType = value; }
        private DirtyValue<StringEnumValue<FreddieLegalEntityTypeOther>> _freddieLegalEntityTypeOther;
        public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get => _freddieLegalEntityTypeOther; set => _freddieLegalEntityTypeOther = value; }
        private DirtyValue<StringEnumValue<FreddieLoanProgramIdentifier>> _freddieLoanProgramIdentifier;
        public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get => _freddieLoanProgramIdentifier; set => _freddieLoanProgramIdentifier = value; }
        private DirtyValue<StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator>> _freddieLoanTypePublicAndIndianHousingIndicator;
        public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get => _freddieLoanTypePublicAndIndianHousingIndicator; set => _freddieLoanTypePublicAndIndianHousingIndicator = value; }
        private DirtyValue<StringEnumValue<FreddieMICompanyNameTypeOther>> _freddieMICompanyNameTypeOther;
        public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMICompanyNameTypeOther { get => _freddieMICompanyNameTypeOther; set => _freddieMICompanyNameTypeOther = value; }
        private DirtyValue<StringEnumValue<FreddieMortgageType>> _freddieMortgageType;
        public StringEnumValue<FreddieMortgageType> FreddieMortgageType { get => _freddieMortgageType; set => _freddieMortgageType = value; }
        private DirtyValue<StringEnumValue<FreddieProjectClassificationType>> _freddieProjectClassificationType;
        public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get => _freddieProjectClassificationType; set => _freddieProjectClassificationType = value; }
        private DirtyValue<StringEnumValue<PropertyFormType>> _freddiePropertyFormType;
        public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get => _freddiePropertyFormType; set => _freddiePropertyFormType = value; }
        private DirtyValue<StringEnumValue<FreddieRefinanceCashOutDeterminationType>> _freddieRefinanceCashOutDeterminationType;
        public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get => _freddieRefinanceCashOutDeterminationType; set => _freddieRefinanceCashOutDeterminationType = value; }
        private DirtyValue<StringEnumValue<FreddieRefinanceType>> _freddieRefinanceType;
        public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get => _freddieRefinanceType; set => _freddieRefinanceType = value; }
        private DirtyValue<bool?> _freddieRelatedClosedEndSecondIndicator;
        public bool? FreddieRelatedClosedEndSecondIndicator { get => _freddieRelatedClosedEndSecondIndicator; set => _freddieRelatedClosedEndSecondIndicator = value; }
        private DirtyValue<string> _freddieRelatedInvestorLoanID;
        public string FreddieRelatedInvestorLoanID { get => _freddieRelatedInvestorLoanID; set => _freddieRelatedInvestorLoanID = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanInvestorType>> _freddieRelatedLoanInvestorType;
        public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get => _freddieRelatedLoanInvestorType; set => _freddieRelatedLoanInvestorType = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanLienPosition>> _freddieRelatedLoanLienPosition;
        public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get => _freddieRelatedLoanLienPosition; set => _freddieRelatedLoanLienPosition = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanType>> _freddieRelatedLoanType;
        public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get => _freddieRelatedLoanType; set => _freddieRelatedLoanType = value; }
        private DirtyValue<StringEnumValue<FreddieSectionOfAct>> _freddieSectionOfAct;
        public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get => _freddieSectionOfAct; set => _freddieSectionOfAct = value; }
        private DirtyValue<StringEnumValue<FreddieUnderwritingTypeOther>> _freddieUnderwritingTypeOther;
        public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get => _freddieUnderwritingTypeOther; set => _freddieUnderwritingTypeOther = value; }
        private DirtyValue<StringEnumValue<GinnieConstructionMethodType>> _ginnieConstructionMethodType;
        public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get => _ginnieConstructionMethodType; set => _ginnieConstructionMethodType = value; }
        private DirtyValue<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        public decimal? GinnieGovernmentAnnualPremiumAmount { get => _ginnieGovernmentAnnualPremiumAmount; set => _ginnieGovernmentAnnualPremiumAmount = value; }
        private DirtyValue<StringEnumValue<GinnieMortgageType>> _ginnieMortgageType;
        public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get => _ginnieMortgageType; set => _ginnieMortgageType = value; }
        private DirtyValue<string> _ginnieOtherConstructionMethodType;
        public string GinnieOtherConstructionMethodType { get => _ginnieOtherConstructionMethodType; set => _ginnieOtherConstructionMethodType = value; }
        private DirtyValue<decimal?> _governmentAnnualPremiumPercent;
        public decimal? GovernmentAnnualPremiumPercent { get => _governmentAnnualPremiumPercent; set => _governmentAnnualPremiumPercent = value; }
        private DirtyValue<StringEnumValue<GovernmentRefinanceType>> _governmentRefinanceType;
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => _governmentRefinanceType; set => _governmentRefinanceType = value; }
        private DirtyValue<decimal?> _governmentUpfrontPremiumAmount;
        public decimal? GovernmentUpfrontPremiumAmount { get => _governmentUpfrontPremiumAmount; set => _governmentUpfrontPremiumAmount = value; }
        private DirtyValue<decimal?> _governmentUpfrontPremiumPercent;
        public decimal? GovernmentUpfrontPremiumPercent { get => _governmentUpfrontPremiumPercent; set => _governmentUpfrontPremiumPercent = value; }
        private DirtyValue<StringEnumValue<GSEProjectType>> _gSEProjectType;
        public StringEnumValue<GSEProjectType> GSEProjectType { get => _gSEProjectType; set => _gSEProjectType = value; }
        private DirtyValue<bool?> _guaranteeFeeAddOnIndicator;
        public bool? GuaranteeFeeAddOnIndicator { get => _guaranteeFeeAddOnIndicator; set => _guaranteeFeeAddOnIndicator = value; }
        private DirtyValue<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get => _guarantyFeeAfterAlternatePaymentMethodPercent; set => _guarantyFeeAfterAlternatePaymentMethodPercent = value; }
        private DirtyValue<decimal?> _guarantyFeePercent;
        public decimal? GuarantyFeePercent { get => _guarantyFeePercent; set => _guarantyFeePercent = value; }
        private DirtyValue<decimal?> _guarantyPercent;
        public decimal? GuarantyPercent { get => _guarantyPercent; set => _guarantyPercent = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IndexType>> _indexType;
        public StringEnumValue<IndexType> IndexType { get => _indexType; set => _indexType = value; }
        private DirtyValue<int?> _initialFixedPeriodEffectiveMonthsCount;
        public int? InitialFixedPeriodEffectiveMonthsCount { get => _initialFixedPeriodEffectiveMonthsCount; set => _initialFixedPeriodEffectiveMonthsCount = value; }
        private DirtyValue<StringEnumValue<InterestAccrualType>> _interestAccrualType;
        public StringEnumValue<InterestAccrualType> InterestAccrualType { get => _interestAccrualType; set => _interestAccrualType = value; }
        private DirtyValue<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get => _interestAndPaymentAdjustmentIndexLeadDaysCount; set => _interestAndPaymentAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<StringEnumValue<InterestCalculationBasisType>> _interestCalculationBasisType;
        public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get => _interestCalculationBasisType; set => _interestCalculationBasisType = value; }
        private DirtyValue<int?> _interestCalculationEffectiveMonthsCount;
        public int? InterestCalculationEffectiveMonthsCount { get => _interestCalculationEffectiveMonthsCount; set => _interestCalculationEffectiveMonthsCount = value; }
        private DirtyValue<StringEnumValue<InterestCalculationType>> _interestCalculationType;
        public StringEnumValue<InterestCalculationType> InterestCalculationType { get => _interestCalculationType; set => _interestCalculationType = value; }
        private DirtyValue<StringEnumValue<InvestorCollateralProgramIdentifier>> _investorCollateralProgramIdentifier;
        public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get => _investorCollateralProgramIdentifier; set => _investorCollateralProgramIdentifier = value; }
        private DirtyValue<string> _investorCommitmentIdentifier;
        public string InvestorCommitmentIdentifier { get => _investorCommitmentIdentifier; set => _investorCommitmentIdentifier = value; }
        private DirtyValue<string> _investorFeatureIdentifier;
        public string InvestorFeatureIdentifier { get => _investorFeatureIdentifier; set => _investorFeatureIdentifier = value; }
        private DirtyValue<string> _investorFeatureIdPool;
        public string InvestorFeatureIdPool { get => _investorFeatureIdPool; set => _investorFeatureIdPool = value; }
        private DirtyValue<decimal?> _investorOwnershipPercent;
        public decimal? InvestorOwnershipPercent { get => _investorOwnershipPercent; set => _investorOwnershipPercent = value; }
        private DirtyValue<string> _investorProductPlanIdentifier;
        public string InvestorProductPlanIdentifier { get => _investorProductPlanIdentifier; set => _investorProductPlanIdentifier = value; }
        private DirtyValue<int?> _investorRemittanceDay;
        public int? InvestorRemittanceDay { get => _investorRemittanceDay; set => _investorRemittanceDay = value; }
        private DirtyValue<StringEnumValue<InvestorRemittanceType>> _investorRemittanceType;
        public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get => _investorRemittanceType; set => _investorRemittanceType = value; }
        private DirtyValue<string> _issuerIdentifier;
        public string IssuerIdentifier { get => _issuerIdentifier; set => _issuerIdentifier = value; }
        private DirtyValue<DateTime?> _lastPaidInstallmentDueDate;
        public DateTime? LastPaidInstallmentDueDate { get => _lastPaidInstallmentDueDate; set => _lastPaidInstallmentDueDate = value; }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => _lastPaymentReceivedDate = value; }
        private DirtyValue<DateTime?> _latestConversionEffectiveDate;
        public DateTime? LatestConversionEffectiveDate { get => _latestConversionEffectiveDate; set => _latestConversionEffectiveDate = value; }
        private DirtyValue<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get => _lenderPaidMIInterestRateAdjustmentPercent; set => _lenderPaidMIInterestRateAdjustmentPercent = value; }
        private DirtyValue<DateTime?> _lendersDeliveryDate;
        public DateTime? LendersDeliveryDate { get => _lendersDeliveryDate; set => _lendersDeliveryDate = value; }
        private DirtyValue<decimal?> _loanAcquisitionScheduledUPBAmount;
        public decimal? LoanAcquisitionScheduledUPBAmount { get => _loanAcquisitionScheduledUPBAmount; set => _loanAcquisitionScheduledUPBAmount = value; }
        private DirtyValue<int?> _loanAmortizationMaximumTermMonthsCount;
        public int? LoanAmortizationMaximumTermMonthsCount { get => _loanAmortizationMaximumTermMonthsCount; set => _loanAmortizationMaximumTermMonthsCount = value; }
        private DirtyValue<int?> _loanBuyupBuydownBasisPointNumber;
        public int? LoanBuyupBuydownBasisPointNumber { get => _loanBuyupBuydownBasisPointNumber; set => _loanBuyupBuydownBasisPointNumber = value; }
        private DirtyValue<StringEnumValue<LoanBuyupBuydownType>> _loanBuyupBuydownType;
        public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get => _loanBuyupBuydownType; set => _loanBuyupBuydownType = value; }
        private DirtyValue<StringEnumValue<LoanDefaultLossPartyType>> _loanDefaultLossPartyType;
        public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get => _loanDefaultLossPartyType; set => _loanDefaultLossPartyType = value; }
        private DirtyValue<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get => _loanDeliveredThroughServicingReleasedProcessIndicator; set => _loanDeliveredThroughServicingReleasedProcessIndicator = value; }
        private DirtyValue<StringEnumValue<LoanIdentifierValueType>> _loanIdentifierValueType;
        public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get => _loanIdentifierValueType; set => _loanIdentifierValueType = value; }
        private DirtyValue<DateTime?> _loanInterestAccrualStartDate;
        public DateTime? LoanInterestAccrualStartDate { get => _loanInterestAccrualStartDate; set => _loanInterestAccrualStartDate = value; }
        private DirtyValue<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; set => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = value; }
        private DirtyValue<StringEnumValue<LoanLevelCreditScoreSelectionMethodType>> _loanLevelCreditScoreSelectionMethodType;
        public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get => _loanLevelCreditScoreSelectionMethodType; set => _loanLevelCreditScoreSelectionMethodType = value; }
        private DirtyValue<int?> _loanLevelCreditScoreValue;
        public int? LoanLevelCreditScoreValue { get => _loanLevelCreditScoreValue; set => _loanLevelCreditScoreValue = value; }
        private DirtyValue<DateTime?> _loanModificationEffectiveDate;
        public DateTime? LoanModificationEffectiveDate { get => _loanModificationEffectiveDate; set => _loanModificationEffectiveDate = value; }
        private DirtyValue<DateTime?> _loanStateDate;
        public DateTime? LoanStateDate { get => _loanStateDate; set => _loanStateDate = value; }
        private DirtyValue<StringEnumValue<ManufacturedHomeWidthType>> _manufacturedHomeWidthType;
        public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get => _manufacturedHomeWidthType; set => _manufacturedHomeWidthType = value; }
        private DirtyValue<bool?> _mBSWeightedMarginIndicator;
        public bool? MBSWeightedMarginIndicator { get => _mBSWeightedMarginIndicator; set => _mBSWeightedMarginIndicator = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _mERSOriginalMortgageeOfRecordIndicator;
        public StringEnumValue<TrueOrFalse> MERSOriginalMortgageeOfRecordIndicator { get => _mERSOriginalMortgageeOfRecordIndicator; set => _mERSOriginalMortgageeOfRecordIndicator = value; }
        private DirtyValue<StringEnumValue<MICompanyNameType>> _mICompanyNameType;
        public StringEnumValue<MICompanyNameType> MICompanyNameType { get => _mICompanyNameType; set => _mICompanyNameType = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _mIPremiumSourceType;
        public StringEnumValue<ClosingCostSourceType> MIPremiumSourceType { get => _mIPremiumSourceType; set => _mIPremiumSourceType = value; }
        private DirtyValue<DateTime?> _monetaryEventAppliedDate;
        public DateTime? MonetaryEventAppliedDate { get => _monetaryEventAppliedDate; set => _monetaryEventAppliedDate = value; }
        private DirtyValue<decimal?> _monetaryEventGrossPrincipalAmount;
        public decimal? MonetaryEventGrossPrincipalAmount { get => _monetaryEventGrossPrincipalAmount; set => _monetaryEventGrossPrincipalAmount = value; }
        private DirtyValue<StringEnumValue<MonetaryEventType>> _monetaryEventType;
        public StringEnumValue<MonetaryEventType> MonetaryEventType { get => _monetaryEventType; set => _monetaryEventType = value; }
        private DirtyValue<bool?> _mortgageBackedSecurityIndicator;
        public bool? MortgageBackedSecurityIndicator { get => _mortgageBackedSecurityIndicator; set => _mortgageBackedSecurityIndicator = value; }
        private DirtyValue<bool?> _mortgageModificationIndicator;
        public bool? MortgageModificationIndicator { get => _mortgageModificationIndicator; set => _mortgageModificationIndicator = value; }
        private DirtyValue<StringEnumValue<UlddMortgageOriginator>> _mortgageOriginator;
        public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => _mortgageOriginator = value; }
        private DirtyValue<StringEnumValue<MortgageProgramType>> _mortgageProgramType;
        public StringEnumValue<MortgageProgramType> MortgageProgramType { get => _mortgageProgramType; set => _mortgageProgramType = value; }
        private DirtyValue<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; set => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = value; }
        private DirtyValue<DateTime?> _nextRateAdjustmentEffectiveDate;
        public DateTime? NextRateAdjustmentEffectiveDate { get => _nextRateAdjustmentEffectiveDate; set => _nextRateAdjustmentEffectiveDate = value; }
        private DirtyValue<string> _notePayToName;
        public string NotePayToName { get => _notePayToName; set => _notePayToName = value; }
        private DirtyValue<int?> _numberOfUnitsSold;
        public int? NumberOfUnitsSold { get => _numberOfUnitsSold; set => _numberOfUnitsSold = value; }
        private DirtyValue<string> _otherDownPaymentFundsType;
        public string OtherDownPaymentFundsType { get => _otherDownPaymentFundsType; set => _otherDownPaymentFundsType = value; }
        private DirtyValue<decimal?> _otherFundsCollectedAtClosingAmount;
        public decimal? OtherFundsCollectedAtClosingAmount { get => _otherFundsCollectedAtClosingAmount; set => _otherFundsCollectedAtClosingAmount = value; }
        private DirtyValue<StringEnumValue<OtherFundsCollectedAtClosingType>> _otherFundsCollectedAtClosingType;
        public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get => _otherFundsCollectedAtClosingType; set => _otherFundsCollectedAtClosingType = value; }
        private DirtyValue<string> _payeeID;
        public string PayeeID { get => _payeeID; set => _payeeID = value; }
        private DirtyValue<int?> _paymentBillingStatementLeadDaysCount;
        public int? PaymentBillingStatementLeadDaysCount { get => _paymentBillingStatementLeadDaysCount; set => _paymentBillingStatementLeadDaysCount = value; }
        private DirtyValue<decimal?> _perChangeMaximumDecreaseRatePercent;
        public decimal? PerChangeMaximumDecreaseRatePercent { get => _perChangeMaximumDecreaseRatePercent; set => _perChangeMaximumDecreaseRatePercent = value; }
        private DirtyValue<decimal?> _perChangeMaximumIncreaseRatePercent;
        public decimal? PerChangeMaximumIncreaseRatePercent { get => _perChangeMaximumIncreaseRatePercent; set => _perChangeMaximumIncreaseRatePercent = value; }
        private DirtyValue<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get => _perChangePrincipalAndInterestPaymentAdjustmentPercent; set => _perChangePrincipalAndInterestPaymentAdjustmentPercent = value; }
        private DirtyValue<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get => _perChangeRateAdjustmentEffectiveDate; set => _perChangeRateAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get => _perChangeRateAdjustmentFrequencyMonthsCount; set => _perChangeRateAdjustmentFrequencyMonthsCount = value; }
        private DirtyValue<StringEnumValue<PoolAccrualRateStructureType>> _poolAccrualRateStructureType;
        public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get => _poolAccrualRateStructureType; set => _poolAccrualRateStructureType = value; }
        private DirtyValue<StringEnumValue<PoolAmortizationType>> _poolAmortizationType;
        public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get => _poolAmortizationType; set => _poolAmortizationType = value; }
        private DirtyValue<bool?> _poolAssumabilityIndicator;
        public bool? PoolAssumabilityIndicator { get => _poolAssumabilityIndicator; set => _poolAssumabilityIndicator = value; }
        private DirtyValue<bool?> _poolBalloonIndicator;
        public bool? PoolBalloonIndicator { get => _poolBalloonIndicator; set => _poolBalloonIndicator = value; }
        private DirtyValue<DateTime?> _poolCertificatePaymentDate;
        public DateTime? PoolCertificatePaymentDate { get => _poolCertificatePaymentDate; set => _poolCertificatePaymentDate = value; }
        private DirtyValue<StringEnumValue<PoolClassType>> _poolClassType;
        public StringEnumValue<PoolClassType> PoolClassType { get => _poolClassType; set => _poolClassType = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _poolConcurrentTransferIndicator;
        public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get => _poolConcurrentTransferIndicator; set => _poolConcurrentTransferIndicator = value; }
        private DirtyValue<int?> _poolCurrentLoanCount;
        public int? PoolCurrentLoanCount { get => _poolCurrentLoanCount; set => _poolCurrentLoanCount = value; }
        private DirtyValue<decimal?> _poolCurrentPrincipalBalanceAmount;
        public decimal? PoolCurrentPrincipalBalanceAmount { get => _poolCurrentPrincipalBalanceAmount; set => _poolCurrentPrincipalBalanceAmount = value; }
        private DirtyValue<string> _poolDocumentCustodianID;
        public string PoolDocumentCustodianID { get => _poolDocumentCustodianID; set => _poolDocumentCustodianID = value; }
        private DirtyValue<decimal?> _poolFixedServicingFeePercent;
        public decimal? PoolFixedServicingFeePercent { get => _poolFixedServicingFeePercent; set => _poolFixedServicingFeePercent = value; }
        private DirtyValue<string> _poolIdentifier;
        public string PoolIdentifier { get => _poolIdentifier; set => _poolIdentifier = value; }
        private DirtyValue<StringEnumValue<PoolingMethodType>> _poolingMethodType;
        public StringEnumValue<PoolingMethodType> PoolingMethodType { get => _poolingMethodType; set => _poolingMethodType = value; }
        private DirtyValue<DateTime?> _poolInterestAdjustmentEffectiveDate;
        public DateTime? PoolInterestAdjustmentEffectiveDate { get => _poolInterestAdjustmentEffectiveDate; set => _poolInterestAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get => _poolInterestAdjustmentIndexLeadDaysCount; set => _poolInterestAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; set => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<bool?> _poolInterestOnlyIndicator;
        public bool? PoolInterestOnlyIndicator { get => _poolInterestOnlyIndicator; set => _poolInterestOnlyIndicator = value; }
        private DirtyValue<decimal?> _poolInterestRateRoundingPercent;
        public decimal? PoolInterestRateRoundingPercent { get => _poolInterestRateRoundingPercent; set => _poolInterestRateRoundingPercent = value; }
        private DirtyValue<StringEnumValue<PoolInterestRateRoundingType>> _poolInterestRateRoundingType;
        public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get => _poolInterestRateRoundingType; set => _poolInterestRateRoundingType = value; }
        private DirtyValue<string> _poolInvestorProductPlanIdentifier;
        public string PoolInvestorProductPlanIdentifier { get => _poolInvestorProductPlanIdentifier; set => _poolInvestorProductPlanIdentifier = value; }
        private DirtyValue<DateTime?> _poolIssueDate;
        public DateTime? PoolIssueDate { get => _poolIssueDate; set => _poolIssueDate = value; }
        private DirtyValue<string> _poolIssuerTransferee;
        public string PoolIssuerTransferee { get => _poolIssuerTransferee; set => _poolIssuerTransferee = value; }
        private DirtyValue<decimal?> _poolMarginRatePercent;
        public decimal? PoolMarginRatePercent { get => _poolMarginRatePercent; set => _poolMarginRatePercent = value; }
        private DirtyValue<DateTime?> _poolMaturityDate;
        public DateTime? PoolMaturityDate { get => _poolMaturityDate; set => _poolMaturityDate = value; }
        private DirtyValue<int?> _poolMaturityPeriodCount;
        public int? PoolMaturityPeriodCount { get => _poolMaturityPeriodCount; set => _poolMaturityPeriodCount = value; }
        private DirtyValue<decimal?> _poolMaximumAccrualRatePercent;
        public decimal? PoolMaximumAccrualRatePercent { get => _poolMaximumAccrualRatePercent; set => _poolMaximumAccrualRatePercent = value; }
        private DirtyValue<decimal?> _poolMinimumAccrualRatePercent;
        public decimal? PoolMinimumAccrualRatePercent { get => _poolMinimumAccrualRatePercent; set => _poolMinimumAccrualRatePercent = value; }
        private DirtyValue<StringEnumValue<PoolMortgageType>> _poolMortgageType;
        public StringEnumValue<PoolMortgageType> PoolMortgageType { get => _poolMortgageType; set => _poolMortgageType = value; }
        private DirtyValue<int?> _poolScheduledRemittancePaymentDay;
        public int? PoolScheduledRemittancePaymentDay { get => _poolScheduledRemittancePaymentDay; set => _poolScheduledRemittancePaymentDay = value; }
        private DirtyValue<decimal?> _poolSecurityIssueDateInterestRatePercent;
        public decimal? PoolSecurityIssueDateInterestRatePercent { get => _poolSecurityIssueDateInterestRatePercent; set => _poolSecurityIssueDateInterestRatePercent = value; }
        private DirtyValue<string> _poolSellerID;
        public string PoolSellerID { get => _poolSellerID; set => _poolSellerID = value; }
        private DirtyValue<string> _poolServicerID;
        public string PoolServicerID { get => _poolServicerID; set => _poolServicerID = value; }
        private DirtyValue<StringEnumValue<PoolStructureType>> _poolStructureType;
        public StringEnumValue<PoolStructureType> PoolStructureType { get => _poolStructureType; set => _poolStructureType = value; }
        private DirtyValue<string> _poolSuffixIdentifier;
        public string PoolSuffixIdentifier { get => _poolSuffixIdentifier; set => _poolSuffixIdentifier = value; }
        private DirtyValue<DateTime?> _priceLockDatetime;
        public DateTime? PriceLockDatetime { get => _priceLockDatetime; set => _priceLockDatetime = value; }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonType>> _primaryMIAbsenceReasonType;
        public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMIAbsenceReasonType { get => _primaryMIAbsenceReasonType; set => _primaryMIAbsenceReasonType = value; }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription>> _primaryMIAbsenceReasonTypeOtherDescription;
        public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMIAbsenceReasonTypeOtherDescription { get => _primaryMIAbsenceReasonTypeOtherDescription; set => _primaryMIAbsenceReasonTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ProjectAttachmentType>> _projectAttachmentType;
        public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get => _projectAttachmentType; set => _projectAttachmentType = value; }
        private DirtyValue<StringEnumValue<ProjectDesignType>> _projectDesignType;
        public StringEnumValue<ProjectDesignType> ProjectDesignType { get => _projectDesignType; set => _projectDesignType = value; }
        private DirtyValue<int?> _projectUnitCount;
        public int? ProjectUnitCount { get => _projectUnitCount; set => _projectUnitCount = value; }
        private DirtyValue<DateTime?> _propertyValuationEffectiveDate;
        public DateTime? PropertyValuationEffectiveDate { get => _propertyValuationEffectiveDate; set => _propertyValuationEffectiveDate = value; }
        private DirtyValue<StringEnumValue<PropertyValuationMethodType>> _propertyValuationMethodType;
        public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get => _propertyValuationMethodType; set => _propertyValuationMethodType = value; }
        private DirtyValue<decimal?> _refinanceCashOutAmount;
        public decimal? RefinanceCashOutAmount { get => _refinanceCashOutAmount; set => _refinanceCashOutAmount = value; }
        private DirtyValue<StringEnumValue<RefinanceCashOutDeterminationType>> _refinanceCashOutDeterminationType;
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => _refinanceCashOutDeterminationType; set => _refinanceCashOutDeterminationType = value; }
        private DirtyValue<bool?> _relatedLoanBalloonIndicator;
        public bool? RelatedLoanBalloonIndicator { get => _relatedLoanBalloonIndicator; set => _relatedLoanBalloonIndicator = value; }
        private DirtyValue<bool?> _relatedLoanHELOCIndicator;
        public bool? RelatedLoanHELOCIndicator { get => _relatedLoanHELOCIndicator; set => _relatedLoanHELOCIndicator = value; }
        private DirtyValue<bool?> _relatedLoanIndicator;
        public bool? RelatedLoanIndicator { get => _relatedLoanIndicator; set => _relatedLoanIndicator = value; }
        private DirtyValue<StringEnumValue<RelatedLoanInvestorType>> _relatedLoanInvestorType;
        public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get => _relatedLoanInvestorType; set => _relatedLoanInvestorType = value; }
        private DirtyValue<int?> _relatedLoanMaturityPeriodCount;
        public int? RelatedLoanMaturityPeriodCount { get => _relatedLoanMaturityPeriodCount; set => _relatedLoanMaturityPeriodCount = value; }
        private DirtyValue<DateTime?> _relatedLoanNoteDate;
        public DateTime? RelatedLoanNoteDate { get => _relatedLoanNoteDate; set => _relatedLoanNoteDate = value; }
        private DirtyValue<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get => _relatedLoanScheduledFirstPaymentDate; set => _relatedLoanScheduledFirstPaymentDate = value; }
        private DirtyValue<DateTime?> _relatedLoanStateDateAtClosing;
        public DateTime? RelatedLoanStateDateAtClosing { get => _relatedLoanStateDateAtClosing; set => _relatedLoanStateDateAtClosing = value; }
        private DirtyValue<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get => _relatedLoanUnpaidPrincipalBalanceAmount; set => _relatedLoanUnpaidPrincipalBalanceAmount = value; }
        private DirtyValue<bool?> _relocationLoanIndicator;
        public bool? RelocationLoanIndicator { get => _relocationLoanIndicator; set => _relocationLoanIndicator = value; }
        private DirtyValue<StringEnumValue<PartyType>> _rEOMarketingPartyType;
        public StringEnumValue<PartyType> REOMarketingPartyType { get => _rEOMarketingPartyType; set => _rEOMarketingPartyType = value; }
        private DirtyValue<bool?> _secondLienIsDeliveredIndicator;
        public bool? SecondLienIsDeliveredIndicator { get => _secondLienIsDeliveredIndicator; set => _secondLienIsDeliveredIndicator = value; }
        private DirtyValue<decimal?> _securityOriginalSubscriptionAmount;
        public decimal? SecurityOriginalSubscriptionAmount { get => _securityOriginalSubscriptionAmount; set => _securityOriginalSubscriptionAmount = value; }
        private DirtyValue<DateTime?> _securityTradeBookEntryDate;
        public DateTime? SecurityTradeBookEntryDate { get => _securityTradeBookEntryDate; set => _securityTradeBookEntryDate = value; }
        private DirtyValue<string> _sellerID;
        public string SellerID { get => _sellerID; set => _sellerID = value; }
        private DirtyValue<string> _sellerLoanIdentifier;
        public string SellerLoanIdentifier { get => _sellerLoanIdentifier; set => _sellerLoanIdentifier = value; }
        private DirtyValue<string> _servicerID;
        public string ServicerID { get => _servicerID; set => _servicerID = value; }
        private DirtyValue<string> _servicerLoanIdentifier;
        public string ServicerLoanIdentifier { get => _servicerLoanIdentifier; set => _servicerLoanIdentifier = value; }
        private DirtyValue<bool?> _sharedEquityIndicator;
        public bool? SharedEquityIndicator { get => _sharedEquityIndicator; set => _sharedEquityIndicator = value; }
        private DirtyValue<bool?> _siteBuiltIndicator;
        public bool? SiteBuiltIndicator { get => _siteBuiltIndicator; set => _siteBuiltIndicator = value; }
        private DirtyValue<bool?> _specialFloodHazardAreaIndicator;
        public bool? SpecialFloodHazardAreaIndicator { get => _specialFloodHazardAreaIndicator; set => _specialFloodHazardAreaIndicator = value; }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get => _subsequentPerChangeMaximumDecreaseRatePercent; set => _subsequentPerChangeMaximumDecreaseRatePercent = value; }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get => _subsequentPerChangeMaximumIncreaseRatePercent; set => _subsequentPerChangeMaximumIncreaseRatePercent = value; }
        private DirtyValue<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get => _subsequentPerChangeRateAdjustmentEffectiveDate; set => _subsequentPerChangeRateAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; set => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = value; }
        private DirtyValue<bool?> _temporaryBuydownIndicator;
        public bool? TemporaryBuydownIndicator { get => _temporaryBuydownIndicator; set => _temporaryBuydownIndicator = value; }
        private DirtyValue<int?> _totalMortgagedPropertiesCount;
        public int? TotalMortgagedPropertiesCount { get => _totalMortgagedPropertiesCount; set => _totalMortgagedPropertiesCount = value; }
        private DirtyValue<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get => _unit1SubjectPropertyGrossRentalIncome; set => _unit1SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit1TotalBedrooms;
        public int? Unit1TotalBedrooms { get => _unit1TotalBedrooms; set => _unit1TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get => _unit2SubjectPropertyGrossRentalIncome; set => _unit2SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit2TotalBedrooms;
        public int? Unit2TotalBedrooms { get => _unit2TotalBedrooms; set => _unit2TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get => _unit3SubjectPropertyGrossRentalIncome; set => _unit3SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit3TotalBedrooms;
        public int? Unit3TotalBedrooms { get => _unit3TotalBedrooms; set => _unit3TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get => _unit4SubjectPropertyGrossRentalIncome; set => _unit4SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit4TotalBedrooms;
        public int? Unit4TotalBedrooms { get => _unit4TotalBedrooms; set => _unit4TotalBedrooms = value; }
        private DirtyValue<decimal?> _uPBAmount;
        public decimal? UPBAmount { get => _uPBAmount; set => _uPBAmount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aCHABARoutingAndTransitIdentifier.Dirty
                    || _aCHABARoutingAndTransitNumber.Dirty
                    || _aCHBankAccountDescription.Dirty
                    || _aCHBankAccountIdentifier.Dirty
                    || _aCHBankAccountPurposeTransitIdentifier.Dirty
                    || _aCHBankAccountPurposeType.Dirty
                    || _aCHInstitutionTelegraphicAbbreviationName.Dirty
                    || _aCHReceiverSubaccountName.Dirty
                    || _additionalPrincipalAmountIndicator.Dirty
                    || _aggregateLoanCurtailmentAmount.Dirty
                    || _appraisalIdentifier.Dirty
                    || _attachmentType.Dirty
                    || _aVMModelNameType.Dirty
                    || _balloonResetIndicator.Dirty
                    || _baseGuarantyFeePercent.Dirty
                    || _bondFinancePool.Dirty
                    || _bondFinanceProgramName.Dirty
                    || _bondFinanceProgramType.Dirty
                    || _borrowerMailToAddressSameasPropertyIndicator.Dirty
                    || _borrowerType.Dirty
                    || _capitalizedLoanIndicator.Dirty
                    || _certificateIdentifier.Dirty
                    || _certificateMaturityDate.Dirty
                    || _certificatePrincipalBalanceAmount.Dirty
                    || _certificateType.Dirty
                    || _closingCost2ContributionAmount.Dirty
                    || _closingCost2FundsType.Dirty
                    || _closingCost2FundsTypeOtherDescription.Dirty
                    || _closingCost2SourceType.Dirty
                    || _closingCost2SourceTypeOtherDescription.Dirty
                    || _closingCost3ContributionAmount.Dirty
                    || _closingCost3FundsType.Dirty
                    || _closingCost3FundsTypeOtherDescription.Dirty
                    || _closingCost3SourceType.Dirty
                    || _closingCost3SourceTypeOtherDescription.Dirty
                    || _closingCost4ContributionAmount.Dirty
                    || _closingCost4FundsType.Dirty
                    || _closingCost4FundsTypeOtherDescription.Dirty
                    || _closingCost4SourceType.Dirty
                    || _closingCost4SourceTypeOtherDescription.Dirty
                    || _closingCostContributionAmount.Dirty
                    || _closingCostFundsType.Dirty
                    || _closingCostFundsTypeOtherDescription.Dirty
                    || _closingCostSourceType.Dirty
                    || _closingCostSourceTypeOtherDescription.Dirty
                    || _coBorrowerCountryCode.Dirty
                    || _coBorrowerMailToAddressSameasPropertyIndicator.Dirty
                    || _coBorrowerType.Dirty
                    || _condominiumProjectStatusType.Dirty
                    || _constructionMethodType.Dirty
                    || _constructionMethodTypeOtherDescription.Dirty
                    || _constructionToPermanentClosingFeatureType.Dirty
                    || _constructionToPermanentClosingType.Dirty
                    || _convertibleStatusType.Dirty
                    || _counselingFormatType.Dirty
                    || _counselingFormatTypeOtherDescription.Dirty
                    || _counselTypeOther.Dirty
                    || _countryCode.Dirty
                    || _creditScoreImpairmentType.Dirty
                    || _currentAccruedInterestAmount.Dirty
                    || _delinquentPaymentsOverPastTwelveMonthsCount.Dirty
                    || _documentCustodianID.Dirty
                    || _documentRequiredIndicator.Dirty
                    || _documentSubmissionIndicator.Dirty
                    || _downPaymentFundsType.Dirty
                    || _downPaymentOtherTypeDescription.Dirty
                    || _downPaymentSourceType.Dirty
                    || _downPaymentSourceTypeOtherDescription.Dirty
                    || _fannieARMIndexType.Dirty
                    || _fannieAutoUWDec.Dirty
                    || _fannieBLTV.Dirty
                    || _fannieBorrowerFirstName.Dirty
                    || _fannieBorrowerMiddleName.Dirty
                    || _fannieBuydownContributer.Dirty
                    || _fannieCLTV.Dirty
                    || _fannieCoBorrowerFirstName.Dirty
                    || _fannieCoBorrowerMiddleName.Dirty
                    || _fannieCreditScoreProviderName.Dirty
                    || _fannieFloodSpecialFeatureCode.Dirty
                    || _fannieHCLTV.Dirty
                    || _fannieInvestorOwnershipPercent.Dirty
                    || _fannieLegalEntityType.Dirty
                    || _fannieLegalEntityTypeOther.Dirty
                    || _fannieLenderPaidMIInterestRateAdjustmentPercent.Dirty
                    || _fannieLoanProgramIdentifier.Dirty
                    || _fannieLTV.Dirty
                    || _fannieMICompanyNameTypeOther.Dirty
                    || _fannieMICoveragePercent.Dirty
                    || _fanniePoolOwnershipPercent.Dirty
                    || _fannieProjectClassificationType.Dirty
                    || _fanniePropertyFormType.Dirty
                    || _fannieRateSpread.Dirty
                    || _fannieRefinanceType.Dirty
                    || _fannieRelatedInvestorLoanID.Dirty
                    || _fannieRelatedLoanAmortizationType.Dirty
                    || _fannieRelatedLoanLienPosition.Dirty
                    || _fannieRelatedLoanType.Dirty
                    || _fannieSectionOfAct.Dirty
                    || _fannieTLTV.Dirty
                    || _fannieTrustName.Dirty
                    || _fannnieMortgageType.Dirty
                    || _financedUnitCount.Dirty
                    || _firstRateChangePaymentEffectiveDate.Dirty
                    || _fNMHomeImprovementProductType.Dirty
                    || _freddieARMIndexType.Dirty
                    || _freddieAutoUWDec.Dirty
                    || _freddieAVMModelNameTypeExpl.Dirty
                    || _freddieBorrowerAlienStatus.Dirty
                    || _freddieCoBorrowerAlienStatus.Dirty
                    || _freddieCreditScoreProviderName.Dirty
                    || _freddieDownPaymentType.Dirty
                    || _freddieDownPmt2SourceType.Dirty
                    || _freddieDownPmt2SourceTypeExpl.Dirty
                    || _freddieDownPmt2Type.Dirty
                    || _freddieDownPmt2TypeExpl.Dirty
                    || _freddieDownPmt3Amt.Dirty
                    || _freddieDownPmt3SourceType.Dirty
                    || _freddieDownPmt3SourceTypeExpl.Dirty
                    || _freddieDownPmt3Type.Dirty
                    || _freddieDownPmt3TypeExpl.Dirty
                    || _freddieDownPmt4Amt.Dirty
                    || _freddieDownPmt4SourceType.Dirty
                    || _freddieDownPmt4SourceTypeExpl.Dirty
                    || _freddieDownPmt4Type.Dirty
                    || _freddieDownPmt4TypeExpl.Dirty
                    || _freddieExplanationOfDownPayment.Dirty
                    || _freddieInvestorCollateralProgramIdentifier.Dirty
                    || _freddieInvestorFeatureIdentifier.Dirty
                    || _freddieLegalEntityType.Dirty
                    || _freddieLegalEntityTypeOther.Dirty
                    || _freddieLoanProgramIdentifier.Dirty
                    || _freddieLoanTypePublicAndIndianHousingIndicator.Dirty
                    || _freddieMICompanyNameTypeOther.Dirty
                    || _freddieMortgageType.Dirty
                    || _freddieProjectClassificationType.Dirty
                    || _freddiePropertyFormType.Dirty
                    || _freddieRefinanceCashOutDeterminationType.Dirty
                    || _freddieRefinanceType.Dirty
                    || _freddieRelatedClosedEndSecondIndicator.Dirty
                    || _freddieRelatedInvestorLoanID.Dirty
                    || _freddieRelatedLoanInvestorType.Dirty
                    || _freddieRelatedLoanLienPosition.Dirty
                    || _freddieRelatedLoanType.Dirty
                    || _freddieSectionOfAct.Dirty
                    || _freddieUnderwritingTypeOther.Dirty
                    || _ginnieConstructionMethodType.Dirty
                    || _ginnieGovernmentAnnualPremiumAmount.Dirty
                    || _ginnieMortgageType.Dirty
                    || _ginnieOtherConstructionMethodType.Dirty
                    || _governmentAnnualPremiumPercent.Dirty
                    || _governmentRefinanceType.Dirty
                    || _governmentUpfrontPremiumAmount.Dirty
                    || _governmentUpfrontPremiumPercent.Dirty
                    || _gSEProjectType.Dirty
                    || _guaranteeFeeAddOnIndicator.Dirty
                    || _guarantyFeeAfterAlternatePaymentMethodPercent.Dirty
                    || _guarantyFeePercent.Dirty
                    || _guarantyPercent.Dirty
                    || _id.Dirty
                    || _indexType.Dirty
                    || _initialFixedPeriodEffectiveMonthsCount.Dirty
                    || _interestAccrualType.Dirty
                    || _interestAndPaymentAdjustmentIndexLeadDaysCount.Dirty
                    || _interestCalculationBasisType.Dirty
                    || _interestCalculationEffectiveMonthsCount.Dirty
                    || _interestCalculationType.Dirty
                    || _investorCollateralProgramIdentifier.Dirty
                    || _investorCommitmentIdentifier.Dirty
                    || _investorFeatureIdentifier.Dirty
                    || _investorFeatureIdPool.Dirty
                    || _investorOwnershipPercent.Dirty
                    || _investorProductPlanIdentifier.Dirty
                    || _investorRemittanceDay.Dirty
                    || _investorRemittanceType.Dirty
                    || _issuerIdentifier.Dirty
                    || _lastPaidInstallmentDueDate.Dirty
                    || _lastPaymentReceivedDate.Dirty
                    || _latestConversionEffectiveDate.Dirty
                    || _lenderPaidMIInterestRateAdjustmentPercent.Dirty
                    || _lendersDeliveryDate.Dirty
                    || _loanAcquisitionScheduledUPBAmount.Dirty
                    || _loanAmortizationMaximumTermMonthsCount.Dirty
                    || _loanBuyupBuydownBasisPointNumber.Dirty
                    || _loanBuyupBuydownType.Dirty
                    || _loanDefaultLossPartyType.Dirty
                    || _loanDeliveredThroughServicingReleasedProcessIndicator.Dirty
                    || _loanIdentifierValueType.Dirty
                    || _loanInterestAccrualStartDate.Dirty
                    || _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Dirty
                    || _loanLevelCreditScoreSelectionMethodType.Dirty
                    || _loanLevelCreditScoreValue.Dirty
                    || _loanModificationEffectiveDate.Dirty
                    || _loanStateDate.Dirty
                    || _manufacturedHomeWidthType.Dirty
                    || _mBSWeightedMarginIndicator.Dirty
                    || _mERSOriginalMortgageeOfRecordIndicator.Dirty
                    || _mICompanyNameType.Dirty
                    || _mIPremiumSourceType.Dirty
                    || _monetaryEventAppliedDate.Dirty
                    || _monetaryEventGrossPrincipalAmount.Dirty
                    || _monetaryEventType.Dirty
                    || _mortgageBackedSecurityIndicator.Dirty
                    || _mortgageModificationIndicator.Dirty
                    || _mortgageOriginator.Dirty
                    || _mortgageProgramType.Dirty
                    || _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Dirty
                    || _nextRateAdjustmentEffectiveDate.Dirty
                    || _notePayToName.Dirty
                    || _numberOfUnitsSold.Dirty
                    || _otherDownPaymentFundsType.Dirty
                    || _otherFundsCollectedAtClosingAmount.Dirty
                    || _otherFundsCollectedAtClosingType.Dirty
                    || _payeeID.Dirty
                    || _paymentBillingStatementLeadDaysCount.Dirty
                    || _perChangeMaximumDecreaseRatePercent.Dirty
                    || _perChangeMaximumIncreaseRatePercent.Dirty
                    || _perChangePrincipalAndInterestPaymentAdjustmentPercent.Dirty
                    || _perChangeRateAdjustmentEffectiveDate.Dirty
                    || _perChangeRateAdjustmentFrequencyMonthsCount.Dirty
                    || _poolAccrualRateStructureType.Dirty
                    || _poolAmortizationType.Dirty
                    || _poolAssumabilityIndicator.Dirty
                    || _poolBalloonIndicator.Dirty
                    || _poolCertificatePaymentDate.Dirty
                    || _poolClassType.Dirty
                    || _poolConcurrentTransferIndicator.Dirty
                    || _poolCurrentLoanCount.Dirty
                    || _poolCurrentPrincipalBalanceAmount.Dirty
                    || _poolDocumentCustodianID.Dirty
                    || _poolFixedServicingFeePercent.Dirty
                    || _poolIdentifier.Dirty
                    || _poolingMethodType.Dirty
                    || _poolInterestAdjustmentEffectiveDate.Dirty
                    || _poolInterestAdjustmentIndexLeadDaysCount.Dirty
                    || _poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Dirty
                    || _poolInterestOnlyIndicator.Dirty
                    || _poolInterestRateRoundingPercent.Dirty
                    || _poolInterestRateRoundingType.Dirty
                    || _poolInvestorProductPlanIdentifier.Dirty
                    || _poolIssueDate.Dirty
                    || _poolIssuerTransferee.Dirty
                    || _poolMarginRatePercent.Dirty
                    || _poolMaturityDate.Dirty
                    || _poolMaturityPeriodCount.Dirty
                    || _poolMaximumAccrualRatePercent.Dirty
                    || _poolMinimumAccrualRatePercent.Dirty
                    || _poolMortgageType.Dirty
                    || _poolScheduledRemittancePaymentDay.Dirty
                    || _poolSecurityIssueDateInterestRatePercent.Dirty
                    || _poolSellerID.Dirty
                    || _poolServicerID.Dirty
                    || _poolStructureType.Dirty
                    || _poolSuffixIdentifier.Dirty
                    || _priceLockDatetime.Dirty
                    || _primaryMIAbsenceReasonType.Dirty
                    || _primaryMIAbsenceReasonTypeOtherDescription.Dirty
                    || _projectAttachmentType.Dirty
                    || _projectDesignType.Dirty
                    || _projectUnitCount.Dirty
                    || _propertyValuationEffectiveDate.Dirty
                    || _propertyValuationMethodType.Dirty
                    || _refinanceCashOutAmount.Dirty
                    || _refinanceCashOutDeterminationType.Dirty
                    || _relatedLoanBalloonIndicator.Dirty
                    || _relatedLoanHELOCIndicator.Dirty
                    || _relatedLoanIndicator.Dirty
                    || _relatedLoanInvestorType.Dirty
                    || _relatedLoanMaturityPeriodCount.Dirty
                    || _relatedLoanNoteDate.Dirty
                    || _relatedLoanScheduledFirstPaymentDate.Dirty
                    || _relatedLoanStateDateAtClosing.Dirty
                    || _relatedLoanUnpaidPrincipalBalanceAmount.Dirty
                    || _relocationLoanIndicator.Dirty
                    || _rEOMarketingPartyType.Dirty
                    || _secondLienIsDeliveredIndicator.Dirty
                    || _securityOriginalSubscriptionAmount.Dirty
                    || _securityTradeBookEntryDate.Dirty
                    || _sellerID.Dirty
                    || _sellerLoanIdentifier.Dirty
                    || _servicerID.Dirty
                    || _servicerLoanIdentifier.Dirty
                    || _sharedEquityIndicator.Dirty
                    || _siteBuiltIndicator.Dirty
                    || _specialFloodHazardAreaIndicator.Dirty
                    || _subsequentPerChangeMaximumDecreaseRatePercent.Dirty
                    || _subsequentPerChangeMaximumIncreaseRatePercent.Dirty
                    || _subsequentPerChangeRateAdjustmentEffectiveDate.Dirty
                    || _subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Dirty
                    || _temporaryBuydownIndicator.Dirty
                    || _totalMortgagedPropertiesCount.Dirty
                    || _unit1SubjectPropertyGrossRentalIncome.Dirty
                    || _unit1TotalBedrooms.Dirty
                    || _unit2SubjectPropertyGrossRentalIncome.Dirty
                    || _unit2TotalBedrooms.Dirty
                    || _unit3SubjectPropertyGrossRentalIncome.Dirty
                    || _unit3TotalBedrooms.Dirty
                    || _unit4SubjectPropertyGrossRentalIncome.Dirty
                    || _unit4TotalBedrooms.Dirty
                    || _uPBAmount.Dirty;
            }
            set
            {
                _aCHABARoutingAndTransitIdentifier.Dirty = value;
                _aCHABARoutingAndTransitNumber.Dirty = value;
                _aCHBankAccountDescription.Dirty = value;
                _aCHBankAccountIdentifier.Dirty = value;
                _aCHBankAccountPurposeTransitIdentifier.Dirty = value;
                _aCHBankAccountPurposeType.Dirty = value;
                _aCHInstitutionTelegraphicAbbreviationName.Dirty = value;
                _aCHReceiverSubaccountName.Dirty = value;
                _additionalPrincipalAmountIndicator.Dirty = value;
                _aggregateLoanCurtailmentAmount.Dirty = value;
                _appraisalIdentifier.Dirty = value;
                _attachmentType.Dirty = value;
                _aVMModelNameType.Dirty = value;
                _balloonResetIndicator.Dirty = value;
                _baseGuarantyFeePercent.Dirty = value;
                _bondFinancePool.Dirty = value;
                _bondFinanceProgramName.Dirty = value;
                _bondFinanceProgramType.Dirty = value;
                _borrowerMailToAddressSameasPropertyIndicator.Dirty = value;
                _borrowerType.Dirty = value;
                _capitalizedLoanIndicator.Dirty = value;
                _certificateIdentifier.Dirty = value;
                _certificateMaturityDate.Dirty = value;
                _certificatePrincipalBalanceAmount.Dirty = value;
                _certificateType.Dirty = value;
                _closingCost2ContributionAmount.Dirty = value;
                _closingCost2FundsType.Dirty = value;
                _closingCost2FundsTypeOtherDescription.Dirty = value;
                _closingCost2SourceType.Dirty = value;
                _closingCost2SourceTypeOtherDescription.Dirty = value;
                _closingCost3ContributionAmount.Dirty = value;
                _closingCost3FundsType.Dirty = value;
                _closingCost3FundsTypeOtherDescription.Dirty = value;
                _closingCost3SourceType.Dirty = value;
                _closingCost3SourceTypeOtherDescription.Dirty = value;
                _closingCost4ContributionAmount.Dirty = value;
                _closingCost4FundsType.Dirty = value;
                _closingCost4FundsTypeOtherDescription.Dirty = value;
                _closingCost4SourceType.Dirty = value;
                _closingCost4SourceTypeOtherDescription.Dirty = value;
                _closingCostContributionAmount.Dirty = value;
                _closingCostFundsType.Dirty = value;
                _closingCostFundsTypeOtherDescription.Dirty = value;
                _closingCostSourceType.Dirty = value;
                _closingCostSourceTypeOtherDescription.Dirty = value;
                _coBorrowerCountryCode.Dirty = value;
                _coBorrowerMailToAddressSameasPropertyIndicator.Dirty = value;
                _coBorrowerType.Dirty = value;
                _condominiumProjectStatusType.Dirty = value;
                _constructionMethodType.Dirty = value;
                _constructionMethodTypeOtherDescription.Dirty = value;
                _constructionToPermanentClosingFeatureType.Dirty = value;
                _constructionToPermanentClosingType.Dirty = value;
                _convertibleStatusType.Dirty = value;
                _counselingFormatType.Dirty = value;
                _counselingFormatTypeOtherDescription.Dirty = value;
                _counselTypeOther.Dirty = value;
                _countryCode.Dirty = value;
                _creditScoreImpairmentType.Dirty = value;
                _currentAccruedInterestAmount.Dirty = value;
                _delinquentPaymentsOverPastTwelveMonthsCount.Dirty = value;
                _documentCustodianID.Dirty = value;
                _documentRequiredIndicator.Dirty = value;
                _documentSubmissionIndicator.Dirty = value;
                _downPaymentFundsType.Dirty = value;
                _downPaymentOtherTypeDescription.Dirty = value;
                _downPaymentSourceType.Dirty = value;
                _downPaymentSourceTypeOtherDescription.Dirty = value;
                _fannieARMIndexType.Dirty = value;
                _fannieAutoUWDec.Dirty = value;
                _fannieBLTV.Dirty = value;
                _fannieBorrowerFirstName.Dirty = value;
                _fannieBorrowerMiddleName.Dirty = value;
                _fannieBuydownContributer.Dirty = value;
                _fannieCLTV.Dirty = value;
                _fannieCoBorrowerFirstName.Dirty = value;
                _fannieCoBorrowerMiddleName.Dirty = value;
                _fannieCreditScoreProviderName.Dirty = value;
                _fannieFloodSpecialFeatureCode.Dirty = value;
                _fannieHCLTV.Dirty = value;
                _fannieInvestorOwnershipPercent.Dirty = value;
                _fannieLegalEntityType.Dirty = value;
                _fannieLegalEntityTypeOther.Dirty = value;
                _fannieLenderPaidMIInterestRateAdjustmentPercent.Dirty = value;
                _fannieLoanProgramIdentifier.Dirty = value;
                _fannieLTV.Dirty = value;
                _fannieMICompanyNameTypeOther.Dirty = value;
                _fannieMICoveragePercent.Dirty = value;
                _fanniePoolOwnershipPercent.Dirty = value;
                _fannieProjectClassificationType.Dirty = value;
                _fanniePropertyFormType.Dirty = value;
                _fannieRateSpread.Dirty = value;
                _fannieRefinanceType.Dirty = value;
                _fannieRelatedInvestorLoanID.Dirty = value;
                _fannieRelatedLoanAmortizationType.Dirty = value;
                _fannieRelatedLoanLienPosition.Dirty = value;
                _fannieRelatedLoanType.Dirty = value;
                _fannieSectionOfAct.Dirty = value;
                _fannieTLTV.Dirty = value;
                _fannieTrustName.Dirty = value;
                _fannnieMortgageType.Dirty = value;
                _financedUnitCount.Dirty = value;
                _firstRateChangePaymentEffectiveDate.Dirty = value;
                _fNMHomeImprovementProductType.Dirty = value;
                _freddieARMIndexType.Dirty = value;
                _freddieAutoUWDec.Dirty = value;
                _freddieAVMModelNameTypeExpl.Dirty = value;
                _freddieBorrowerAlienStatus.Dirty = value;
                _freddieCoBorrowerAlienStatus.Dirty = value;
                _freddieCreditScoreProviderName.Dirty = value;
                _freddieDownPaymentType.Dirty = value;
                _freddieDownPmt2SourceType.Dirty = value;
                _freddieDownPmt2SourceTypeExpl.Dirty = value;
                _freddieDownPmt2Type.Dirty = value;
                _freddieDownPmt2TypeExpl.Dirty = value;
                _freddieDownPmt3Amt.Dirty = value;
                _freddieDownPmt3SourceType.Dirty = value;
                _freddieDownPmt3SourceTypeExpl.Dirty = value;
                _freddieDownPmt3Type.Dirty = value;
                _freddieDownPmt3TypeExpl.Dirty = value;
                _freddieDownPmt4Amt.Dirty = value;
                _freddieDownPmt4SourceType.Dirty = value;
                _freddieDownPmt4SourceTypeExpl.Dirty = value;
                _freddieDownPmt4Type.Dirty = value;
                _freddieDownPmt4TypeExpl.Dirty = value;
                _freddieExplanationOfDownPayment.Dirty = value;
                _freddieInvestorCollateralProgramIdentifier.Dirty = value;
                _freddieInvestorFeatureIdentifier.Dirty = value;
                _freddieLegalEntityType.Dirty = value;
                _freddieLegalEntityTypeOther.Dirty = value;
                _freddieLoanProgramIdentifier.Dirty = value;
                _freddieLoanTypePublicAndIndianHousingIndicator.Dirty = value;
                _freddieMICompanyNameTypeOther.Dirty = value;
                _freddieMortgageType.Dirty = value;
                _freddieProjectClassificationType.Dirty = value;
                _freddiePropertyFormType.Dirty = value;
                _freddieRefinanceCashOutDeterminationType.Dirty = value;
                _freddieRefinanceType.Dirty = value;
                _freddieRelatedClosedEndSecondIndicator.Dirty = value;
                _freddieRelatedInvestorLoanID.Dirty = value;
                _freddieRelatedLoanInvestorType.Dirty = value;
                _freddieRelatedLoanLienPosition.Dirty = value;
                _freddieRelatedLoanType.Dirty = value;
                _freddieSectionOfAct.Dirty = value;
                _freddieUnderwritingTypeOther.Dirty = value;
                _ginnieConstructionMethodType.Dirty = value;
                _ginnieGovernmentAnnualPremiumAmount.Dirty = value;
                _ginnieMortgageType.Dirty = value;
                _ginnieOtherConstructionMethodType.Dirty = value;
                _governmentAnnualPremiumPercent.Dirty = value;
                _governmentRefinanceType.Dirty = value;
                _governmentUpfrontPremiumAmount.Dirty = value;
                _governmentUpfrontPremiumPercent.Dirty = value;
                _gSEProjectType.Dirty = value;
                _guaranteeFeeAddOnIndicator.Dirty = value;
                _guarantyFeeAfterAlternatePaymentMethodPercent.Dirty = value;
                _guarantyFeePercent.Dirty = value;
                _guarantyPercent.Dirty = value;
                _id.Dirty = value;
                _indexType.Dirty = value;
                _initialFixedPeriodEffectiveMonthsCount.Dirty = value;
                _interestAccrualType.Dirty = value;
                _interestAndPaymentAdjustmentIndexLeadDaysCount.Dirty = value;
                _interestCalculationBasisType.Dirty = value;
                _interestCalculationEffectiveMonthsCount.Dirty = value;
                _interestCalculationType.Dirty = value;
                _investorCollateralProgramIdentifier.Dirty = value;
                _investorCommitmentIdentifier.Dirty = value;
                _investorFeatureIdentifier.Dirty = value;
                _investorFeatureIdPool.Dirty = value;
                _investorOwnershipPercent.Dirty = value;
                _investorProductPlanIdentifier.Dirty = value;
                _investorRemittanceDay.Dirty = value;
                _investorRemittanceType.Dirty = value;
                _issuerIdentifier.Dirty = value;
                _lastPaidInstallmentDueDate.Dirty = value;
                _lastPaymentReceivedDate.Dirty = value;
                _latestConversionEffectiveDate.Dirty = value;
                _lenderPaidMIInterestRateAdjustmentPercent.Dirty = value;
                _lendersDeliveryDate.Dirty = value;
                _loanAcquisitionScheduledUPBAmount.Dirty = value;
                _loanAmortizationMaximumTermMonthsCount.Dirty = value;
                _loanBuyupBuydownBasisPointNumber.Dirty = value;
                _loanBuyupBuydownType.Dirty = value;
                _loanDefaultLossPartyType.Dirty = value;
                _loanDeliveredThroughServicingReleasedProcessIndicator.Dirty = value;
                _loanIdentifierValueType.Dirty = value;
                _loanInterestAccrualStartDate.Dirty = value;
                _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Dirty = value;
                _loanLevelCreditScoreSelectionMethodType.Dirty = value;
                _loanLevelCreditScoreValue.Dirty = value;
                _loanModificationEffectiveDate.Dirty = value;
                _loanStateDate.Dirty = value;
                _manufacturedHomeWidthType.Dirty = value;
                _mBSWeightedMarginIndicator.Dirty = value;
                _mERSOriginalMortgageeOfRecordIndicator.Dirty = value;
                _mICompanyNameType.Dirty = value;
                _mIPremiumSourceType.Dirty = value;
                _monetaryEventAppliedDate.Dirty = value;
                _monetaryEventGrossPrincipalAmount.Dirty = value;
                _monetaryEventType.Dirty = value;
                _mortgageBackedSecurityIndicator.Dirty = value;
                _mortgageModificationIndicator.Dirty = value;
                _mortgageOriginator.Dirty = value;
                _mortgageProgramType.Dirty = value;
                _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Dirty = value;
                _nextRateAdjustmentEffectiveDate.Dirty = value;
                _notePayToName.Dirty = value;
                _numberOfUnitsSold.Dirty = value;
                _otherDownPaymentFundsType.Dirty = value;
                _otherFundsCollectedAtClosingAmount.Dirty = value;
                _otherFundsCollectedAtClosingType.Dirty = value;
                _payeeID.Dirty = value;
                _paymentBillingStatementLeadDaysCount.Dirty = value;
                _perChangeMaximumDecreaseRatePercent.Dirty = value;
                _perChangeMaximumIncreaseRatePercent.Dirty = value;
                _perChangePrincipalAndInterestPaymentAdjustmentPercent.Dirty = value;
                _perChangeRateAdjustmentEffectiveDate.Dirty = value;
                _perChangeRateAdjustmentFrequencyMonthsCount.Dirty = value;
                _poolAccrualRateStructureType.Dirty = value;
                _poolAmortizationType.Dirty = value;
                _poolAssumabilityIndicator.Dirty = value;
                _poolBalloonIndicator.Dirty = value;
                _poolCertificatePaymentDate.Dirty = value;
                _poolClassType.Dirty = value;
                _poolConcurrentTransferIndicator.Dirty = value;
                _poolCurrentLoanCount.Dirty = value;
                _poolCurrentPrincipalBalanceAmount.Dirty = value;
                _poolDocumentCustodianID.Dirty = value;
                _poolFixedServicingFeePercent.Dirty = value;
                _poolIdentifier.Dirty = value;
                _poolingMethodType.Dirty = value;
                _poolInterestAdjustmentEffectiveDate.Dirty = value;
                _poolInterestAdjustmentIndexLeadDaysCount.Dirty = value;
                _poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Dirty = value;
                _poolInterestOnlyIndicator.Dirty = value;
                _poolInterestRateRoundingPercent.Dirty = value;
                _poolInterestRateRoundingType.Dirty = value;
                _poolInvestorProductPlanIdentifier.Dirty = value;
                _poolIssueDate.Dirty = value;
                _poolIssuerTransferee.Dirty = value;
                _poolMarginRatePercent.Dirty = value;
                _poolMaturityDate.Dirty = value;
                _poolMaturityPeriodCount.Dirty = value;
                _poolMaximumAccrualRatePercent.Dirty = value;
                _poolMinimumAccrualRatePercent.Dirty = value;
                _poolMortgageType.Dirty = value;
                _poolScheduledRemittancePaymentDay.Dirty = value;
                _poolSecurityIssueDateInterestRatePercent.Dirty = value;
                _poolSellerID.Dirty = value;
                _poolServicerID.Dirty = value;
                _poolStructureType.Dirty = value;
                _poolSuffixIdentifier.Dirty = value;
                _priceLockDatetime.Dirty = value;
                _primaryMIAbsenceReasonType.Dirty = value;
                _primaryMIAbsenceReasonTypeOtherDescription.Dirty = value;
                _projectAttachmentType.Dirty = value;
                _projectDesignType.Dirty = value;
                _projectUnitCount.Dirty = value;
                _propertyValuationEffectiveDate.Dirty = value;
                _propertyValuationMethodType.Dirty = value;
                _refinanceCashOutAmount.Dirty = value;
                _refinanceCashOutDeterminationType.Dirty = value;
                _relatedLoanBalloonIndicator.Dirty = value;
                _relatedLoanHELOCIndicator.Dirty = value;
                _relatedLoanIndicator.Dirty = value;
                _relatedLoanInvestorType.Dirty = value;
                _relatedLoanMaturityPeriodCount.Dirty = value;
                _relatedLoanNoteDate.Dirty = value;
                _relatedLoanScheduledFirstPaymentDate.Dirty = value;
                _relatedLoanStateDateAtClosing.Dirty = value;
                _relatedLoanUnpaidPrincipalBalanceAmount.Dirty = value;
                _relocationLoanIndicator.Dirty = value;
                _rEOMarketingPartyType.Dirty = value;
                _secondLienIsDeliveredIndicator.Dirty = value;
                _securityOriginalSubscriptionAmount.Dirty = value;
                _securityTradeBookEntryDate.Dirty = value;
                _sellerID.Dirty = value;
                _sellerLoanIdentifier.Dirty = value;
                _servicerID.Dirty = value;
                _servicerLoanIdentifier.Dirty = value;
                _sharedEquityIndicator.Dirty = value;
                _siteBuiltIndicator.Dirty = value;
                _specialFloodHazardAreaIndicator.Dirty = value;
                _subsequentPerChangeMaximumDecreaseRatePercent.Dirty = value;
                _subsequentPerChangeMaximumIncreaseRatePercent.Dirty = value;
                _subsequentPerChangeRateAdjustmentEffectiveDate.Dirty = value;
                _subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Dirty = value;
                _temporaryBuydownIndicator.Dirty = value;
                _totalMortgagedPropertiesCount.Dirty = value;
                _unit1SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit1TotalBedrooms.Dirty = value;
                _unit2SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit2TotalBedrooms.Dirty = value;
                _unit3SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit3TotalBedrooms.Dirty = value;
                _unit4SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit4TotalBedrooms.Dirty = value;
                _uPBAmount.Dirty = value;
            }
        }
    }
}