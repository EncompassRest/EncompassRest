using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Uldd : IDirty
    {
        private DirtyValue<string> _aCHABARoutingAndTransitIdentifier;
        public string ACHABARoutingAndTransitIdentifier { get { return _aCHABARoutingAndTransitIdentifier; } set { _aCHABARoutingAndTransitIdentifier = value; } }
        private DirtyValue<string> _aCHABARoutingAndTransitNumber;
        public string ACHABARoutingAndTransitNumber { get { return _aCHABARoutingAndTransitNumber; } set { _aCHABARoutingAndTransitNumber = value; } }
        private DirtyValue<string> _aCHBankAccountDescription;
        public string ACHBankAccountDescription { get { return _aCHBankAccountDescription; } set { _aCHBankAccountDescription = value; } }
        private DirtyValue<string> _aCHBankAccountIdentifier;
        public string ACHBankAccountIdentifier { get { return _aCHBankAccountIdentifier; } set { _aCHBankAccountIdentifier = value; } }
        private DirtyValue<string> _aCHBankAccountPurposeTransitIdentifier;
        public string ACHBankAccountPurposeTransitIdentifier { get { return _aCHBankAccountPurposeTransitIdentifier; } set { _aCHBankAccountPurposeTransitIdentifier = value; } }
        private StringEnumValue<ACHBankAccountPurposeType> _aCHBankAccountPurposeType;
        public StringEnumValue<ACHBankAccountPurposeType> ACHBankAccountPurposeType { get { return _aCHBankAccountPurposeType; } set { _aCHBankAccountPurposeType = value; } }
        private DirtyValue<string> _aCHInstitutionTelegraphicAbbreviationName;
        public string ACHInstitutionTelegraphicAbbreviationName { get { return _aCHInstitutionTelegraphicAbbreviationName; } set { _aCHInstitutionTelegraphicAbbreviationName = value; } }
        private DirtyValue<string> _aCHReceiverSubaccountName;
        public string ACHReceiverSubaccountName { get { return _aCHReceiverSubaccountName; } set { _aCHReceiverSubaccountName = value; } }
        private DirtyValue<bool?> _additionalPrincipalAmountIndicator;
        public bool? AdditionalPrincipalAmountIndicator { get { return _additionalPrincipalAmountIndicator; } set { _additionalPrincipalAmountIndicator = value; } }
        private DirtyValue<decimal?> _aggregateLoanCurtailmentAmount;
        public decimal? AggregateLoanCurtailmentAmount { get { return _aggregateLoanCurtailmentAmount; } set { _aggregateLoanCurtailmentAmount = value; } }
        private DirtyValue<string> _appraisalIdentifier;
        public string AppraisalIdentifier { get { return _appraisalIdentifier; } set { _appraisalIdentifier = value; } }
        private StringEnumValue<AttachmentType> _attachmentType;
        public StringEnumValue<AttachmentType> AttachmentType { get { return _attachmentType; } set { _attachmentType = value; } }
        private StringEnumValue<AVMModelNameType> _aVMModelNameType;
        public StringEnumValue<AVMModelNameType> AVMModelNameType { get { return _aVMModelNameType; } set { _aVMModelNameType = value; } }
        private DirtyValue<bool?> _balloonResetIndicator;
        public bool? BalloonResetIndicator { get { return _balloonResetIndicator; } set { _balloonResetIndicator = value; } }
        private DirtyValue<decimal?> _baseGuarantyFeePercent;
        public decimal? BaseGuarantyFeePercent { get { return _baseGuarantyFeePercent; } set { _baseGuarantyFeePercent = value; } }
        private StringEnumValue<TrueOrFalse> _bondFinancePool;
        public StringEnumValue<TrueOrFalse> BondFinancePool { get { return _bondFinancePool; } set { _bondFinancePool = value; } }
        private DirtyValue<string> _bondFinanceProgramName;
        public string BondFinanceProgramName { get { return _bondFinanceProgramName; } set { _bondFinanceProgramName = value; } }
        private StringEnumValue<BondFinanceProgramType> _bondFinanceProgramType;
        public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get { return _bondFinanceProgramType; } set { _bondFinanceProgramType = value; } }
        private DirtyValue<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get { return _borrowerMailToAddressSameasPropertyIndicator; } set { _borrowerMailToAddressSameasPropertyIndicator = value; } }
        private StringEnumValue<UlddBorrowerType> _borrowerType;
        public StringEnumValue<UlddBorrowerType> BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        private DirtyValue<bool?> _capitalizedLoanIndicator;
        public bool? CapitalizedLoanIndicator { get { return _capitalizedLoanIndicator; } set { _capitalizedLoanIndicator = value; } }
        private DirtyValue<string> _certificateIdentifier;
        public string CertificateIdentifier { get { return _certificateIdentifier; } set { _certificateIdentifier = value; } }
        private DirtyValue<DateTime?> _certificateMaturityDate;
        public DateTime? CertificateMaturityDate { get { return _certificateMaturityDate; } set { _certificateMaturityDate = value; } }
        private DirtyValue<decimal?> _certificatePrincipalBalanceAmount;
        public decimal? CertificatePrincipalBalanceAmount { get { return _certificatePrincipalBalanceAmount; } set { _certificatePrincipalBalanceAmount = value; } }
        private StringEnumValue<TrueOrFalse> _certificateType;
        public StringEnumValue<TrueOrFalse> CertificateType { get { return _certificateType; } set { _certificateType = value; } }
        private DirtyValue<decimal?> _closingCost2ContributionAmount;
        public decimal? ClosingCost2ContributionAmount { get { return _closingCost2ContributionAmount; } set { _closingCost2ContributionAmount = value; } }
        private StringEnumValue<ClosingCostFundsType> _closingCost2FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get { return _closingCost2FundsType; } set { _closingCost2FundsType = value; } }
        private StringEnumValue<FundsTypeDescription> _closingCost2FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get { return _closingCost2FundsTypeOtherDescription; } set { _closingCost2FundsTypeOtherDescription = value; } }
        private StringEnumValue<ClosingCostSourceType> _closingCost2SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get { return _closingCost2SourceType; } set { _closingCost2SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _closingCost2SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get { return _closingCost2SourceTypeOtherDescription; } set { _closingCost2SourceTypeOtherDescription = value; } }
        private DirtyValue<decimal?> _closingCost3ContributionAmount;
        public decimal? ClosingCost3ContributionAmount { get { return _closingCost3ContributionAmount; } set { _closingCost3ContributionAmount = value; } }
        private StringEnumValue<ClosingCostFundsType> _closingCost3FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get { return _closingCost3FundsType; } set { _closingCost3FundsType = value; } }
        private StringEnumValue<FundsTypeDescription> _closingCost3FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get { return _closingCost3FundsTypeOtherDescription; } set { _closingCost3FundsTypeOtherDescription = value; } }
        private StringEnumValue<ClosingCostSourceType> _closingCost3SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get { return _closingCost3SourceType; } set { _closingCost3SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _closingCost3SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get { return _closingCost3SourceTypeOtherDescription; } set { _closingCost3SourceTypeOtherDescription = value; } }
        private DirtyValue<decimal?> _closingCost4ContributionAmount;
        public decimal? ClosingCost4ContributionAmount { get { return _closingCost4ContributionAmount; } set { _closingCost4ContributionAmount = value; } }
        private StringEnumValue<ClosingCostFundsType> _closingCost4FundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get { return _closingCost4FundsType; } set { _closingCost4FundsType = value; } }
        private StringEnumValue<FundsTypeDescription> _closingCost4FundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get { return _closingCost4FundsTypeOtherDescription; } set { _closingCost4FundsTypeOtherDescription = value; } }
        private StringEnumValue<ClosingCostSourceType> _closingCost4SourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get { return _closingCost4SourceType; } set { _closingCost4SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _closingCost4SourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get { return _closingCost4SourceTypeOtherDescription; } set { _closingCost4SourceTypeOtherDescription = value; } }
        private DirtyValue<decimal?> _closingCostContributionAmount;
        public decimal? ClosingCostContributionAmount { get { return _closingCostContributionAmount; } set { _closingCostContributionAmount = value; } }
        private StringEnumValue<ClosingCostFundsType> _closingCostFundsType;
        public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get { return _closingCostFundsType; } set { _closingCostFundsType = value; } }
        private StringEnumValue<FundsTypeDescription> _closingCostFundsTypeOtherDescription;
        public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get { return _closingCostFundsTypeOtherDescription; } set { _closingCostFundsTypeOtherDescription = value; } }
        private StringEnumValue<ClosingCostSourceType> _closingCostSourceType;
        public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get { return _closingCostSourceType; } set { _closingCostSourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _closingCostSourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get { return _closingCostSourceTypeOtherDescription; } set { _closingCostSourceTypeOtherDescription = value; } }
        private DirtyValue<string> _coBorrowerCountryCode;
        public string CoBorrowerCountryCode { get { return _coBorrowerCountryCode; } set { _coBorrowerCountryCode = value; } }
        private DirtyValue<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get { return _coBorrowerMailToAddressSameasPropertyIndicator; } set { _coBorrowerMailToAddressSameasPropertyIndicator = value; } }
        private StringEnumValue<UlddBorrowerType> _coBorrowerType;
        public StringEnumValue<UlddBorrowerType> CoBorrowerType { get { return _coBorrowerType; } set { _coBorrowerType = value; } }
        private StringEnumValue<CondominiumProjectStatusType> _condominiumProjectStatusType;
        public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get { return _condominiumProjectStatusType; } set { _condominiumProjectStatusType = value; } }
        private StringEnumValue<ConstructionMethodType> _constructionMethodType;
        public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get { return _constructionMethodType; } set { _constructionMethodType = value; } }
        private DirtyValue<string> _constructionMethodTypeOtherDescription;
        public string ConstructionMethodTypeOtherDescription { get { return _constructionMethodTypeOtherDescription; } set { _constructionMethodTypeOtherDescription = value; } }
        private StringEnumValue<ConstructionToPermanentClosingFeatureType> _constructionToPermanentClosingFeatureType;
        public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get { return _constructionToPermanentClosingFeatureType; } set { _constructionToPermanentClosingFeatureType = value; } }
        private StringEnumValue<ConstructionToPermanentClosingType> _constructionToPermanentClosingType;
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get { return _constructionToPermanentClosingType; } set { _constructionToPermanentClosingType = value; } }
        private StringEnumValue<ConvertibleStatusType> _convertibleStatusType;
        public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get { return _convertibleStatusType; } set { _convertibleStatusType = value; } }
        private StringEnumValue<CounselingFormatType> _counselingFormatType;
        public StringEnumValue<CounselingFormatType> CounselingFormatType { get { return _counselingFormatType; } set { _counselingFormatType = value; } }
        private StringEnumValue<CounselingFormatTypeOtherDescription> _counselingFormatTypeOtherDescription;
        public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get { return _counselingFormatTypeOtherDescription; } set { _counselingFormatTypeOtherDescription = value; } }
        private StringEnumValue<CounselTypeOther> _counselTypeOther;
        public StringEnumValue<CounselTypeOther> CounselTypeOther { get { return _counselTypeOther; } set { _counselTypeOther = value; } }
        private DirtyValue<string> _countryCode;
        public string CountryCode { get { return _countryCode; } set { _countryCode = value; } }
        private StringEnumValue<CreditScoreImpairmentType> _creditScoreImpairmentType;
        public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get { return _creditScoreImpairmentType; } set { _creditScoreImpairmentType = value; } }
        private DirtyValue<decimal?> _currentAccruedInterestAmount;
        public decimal? CurrentAccruedInterestAmount { get { return _currentAccruedInterestAmount; } set { _currentAccruedInterestAmount = value; } }
        private DirtyValue<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get { return _delinquentPaymentsOverPastTwelveMonthsCount; } set { _delinquentPaymentsOverPastTwelveMonthsCount = value; } }
        private DirtyValue<string> _documentCustodianID;
        public string DocumentCustodianID { get { return _documentCustodianID; } set { _documentCustodianID = value; } }
        private StringEnumValue<TrueOrFalse> _documentRequiredIndicator;
        public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get { return _documentRequiredIndicator; } set { _documentRequiredIndicator = value; } }
        private StringEnumValue<TrueOrFalse> _documentSubmissionIndicator;
        public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get { return _documentSubmissionIndicator; } set { _documentSubmissionIndicator = value; } }
        private StringEnumValue<DownPaymentFundsType> _downPaymentFundsType;
        public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get { return _downPaymentFundsType; } set { _downPaymentFundsType = value; } }
        private StringEnumValue<FundsTypeDescription> _downPaymentOtherTypeDescription;
        public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get { return _downPaymentOtherTypeDescription; } set { _downPaymentOtherTypeDescription = value; } }
        private StringEnumValue<DownPaymentSourceType> _downPaymentSourceType;
        public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get { return _downPaymentSourceType; } set { _downPaymentSourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _downPaymentSourceTypeOtherDescription;
        public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get { return _downPaymentSourceTypeOtherDescription; } set { _downPaymentSourceTypeOtherDescription = value; } }
        private StringEnumValue<FannieARMIndexType> _fannieARMIndexType;
        public StringEnumValue<FannieARMIndexType> FannieARMIndexType { get { return _fannieARMIndexType; } set { _fannieARMIndexType = value; } }
        private StringEnumValue<FannieAutoUWDec> _fannieAutoUWDec;
        public StringEnumValue<FannieAutoUWDec> FannieAutoUWDec { get { return _fannieAutoUWDec; } set { _fannieAutoUWDec = value; } }
        private DirtyValue<int?> _fannieBLTV;
        public int? FannieBLTV { get { return _fannieBLTV; } set { _fannieBLTV = value; } }
        private DirtyValue<string> _fannieBorrowerFirstName;
        public string FannieBorrowerFirstName { get { return _fannieBorrowerFirstName; } set { _fannieBorrowerFirstName = value; } }
        private DirtyValue<string> _fannieBorrowerMiddleName;
        public string FannieBorrowerMiddleName { get { return _fannieBorrowerMiddleName; } set { _fannieBorrowerMiddleName = value; } }
        private StringEnumValue<FannieBuydownContributer> _fannieBuydownContributer;
        public StringEnumValue<FannieBuydownContributer> FannieBuydownContributer { get { return _fannieBuydownContributer; } set { _fannieBuydownContributer = value; } }
        private DirtyValue<int?> _fannieCLTV;
        public int? FannieCLTV { get { return _fannieCLTV; } set { _fannieCLTV = value; } }
        private DirtyValue<string> _fannieCoBorrowerFirstName;
        public string FannieCoBorrowerFirstName { get { return _fannieCoBorrowerFirstName; } set { _fannieCoBorrowerFirstName = value; } }
        private DirtyValue<string> _fannieCoBorrowerMiddleName;
        public string FannieCoBorrowerMiddleName { get { return _fannieCoBorrowerMiddleName; } set { _fannieCoBorrowerMiddleName = value; } }
        private DirtyValue<string> _fannieCreditScoreProviderName;
        public string FannieCreditScoreProviderName { get { return _fannieCreditScoreProviderName; } set { _fannieCreditScoreProviderName = value; } }
        private StringEnumValue<FannieFloodSpecialFeatureCode> _fannieFloodSpecialFeatureCode;
        public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get { return _fannieFloodSpecialFeatureCode; } set { _fannieFloodSpecialFeatureCode = value; } }
        private DirtyValue<int?> _fannieHCLTV;
        public int? FannieHCLTV { get { return _fannieHCLTV; } set { _fannieHCLTV = value; } }
        private DirtyValue<int?> _fannieInvestorOwnershipPercent;
        public int? FannieInvestorOwnershipPercent { get { return _fannieInvestorOwnershipPercent; } set { _fannieInvestorOwnershipPercent = value; } }
        private StringEnumValue<FannieLegalEntityType> _fannieLegalEntityType;
        public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get { return _fannieLegalEntityType; } set { _fannieLegalEntityType = value; } }
        private StringEnumValue<FannieLegalEntityTypeOther> _fannieLegalEntityTypeOther;
        public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get { return _fannieLegalEntityTypeOther; } set { _fannieLegalEntityTypeOther = value; } }
        private DirtyValue<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get { return _fannieLenderPaidMIInterestRateAdjustmentPercent; } set { _fannieLenderPaidMIInterestRateAdjustmentPercent = value; } }
        private StringEnumValue<FannieLoanProgramIdentifier> _fannieLoanProgramIdentifier;
        public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get { return _fannieLoanProgramIdentifier; } set { _fannieLoanProgramIdentifier = value; } }
        private DirtyValue<int?> _fannieLTV;
        public int? FannieLTV { get { return _fannieLTV; } set { _fannieLTV = value; } }
        private StringEnumValue<FannieMICompanyNameTypeOther> _fannieMICompanyNameTypeOther;
        public StringEnumValue<FannieMICompanyNameTypeOther> FannieMICompanyNameTypeOther { get { return _fannieMICompanyNameTypeOther; } set { _fannieMICompanyNameTypeOther = value; } }
        private DirtyValue<int?> _fannieMICoveragePercent;
        public int? FannieMICoveragePercent { get { return _fannieMICoveragePercent; } set { _fannieMICoveragePercent = value; } }
        private DirtyValue<int?> _fanniePoolOwnershipPercent;
        public int? FanniePoolOwnershipPercent { get { return _fanniePoolOwnershipPercent; } set { _fanniePoolOwnershipPercent = value; } }
        private StringEnumValue<FannieProjectClassificationType> _fannieProjectClassificationType;
        public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get { return _fannieProjectClassificationType; } set { _fannieProjectClassificationType = value; } }
        private StringEnumValue<FanniePropertyFormType> _fanniePropertyFormType;
        public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get { return _fanniePropertyFormType; } set { _fanniePropertyFormType = value; } }
        private DirtyValue<decimal?> _fannieRateSpread;
        public decimal? FannieRateSpread { get { return _fannieRateSpread; } set { _fannieRateSpread = value; } }
        private StringEnumValue<FannieRefinanceType> _fannieRefinanceType;
        public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get { return _fannieRefinanceType; } set { _fannieRefinanceType = value; } }
        private DirtyValue<string> _fannieRelatedInvestorLoanID;
        public string FannieRelatedInvestorLoanID { get { return _fannieRelatedInvestorLoanID; } set { _fannieRelatedInvestorLoanID = value; } }
        private StringEnumValue<FannieRelatedLoanAmortizationType> _fannieRelatedLoanAmortizationType;
        public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get { return _fannieRelatedLoanAmortizationType; } set { _fannieRelatedLoanAmortizationType = value; } }
        private StringEnumValue<FannieRelatedLoanLienPosition> _fannieRelatedLoanLienPosition;
        public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get { return _fannieRelatedLoanLienPosition; } set { _fannieRelatedLoanLienPosition = value; } }
        private StringEnumValue<FannieRelatedLoanType> _fannieRelatedLoanType;
        public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get { return _fannieRelatedLoanType; } set { _fannieRelatedLoanType = value; } }
        private StringEnumValue<FannieSectionOfAct> _fannieSectionOfAct;
        public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get { return _fannieSectionOfAct; } set { _fannieSectionOfAct = value; } }
        private DirtyValue<int?> _fannieTLTV;
        public int? FannieTLTV { get { return _fannieTLTV; } set { _fannieTLTV = value; } }
        private DirtyValue<string> _fannieTrustName;
        public string FannieTrustName { get { return _fannieTrustName; } set { _fannieTrustName = value; } }
        private StringEnumValue<FannnieMortgageType> _fannnieMortgageType;
        public StringEnumValue<FannnieMortgageType> FannnieMortgageType { get { return _fannnieMortgageType; } set { _fannnieMortgageType = value; } }
        private DirtyValue<int?> _financedUnitCount;
        public int? FinancedUnitCount { get { return _financedUnitCount; } set { _financedUnitCount = value; } }
        private DirtyValue<DateTime?> _firstRateChangePaymentEffectiveDate;
        public DateTime? FirstRateChangePaymentEffectiveDate { get { return _firstRateChangePaymentEffectiveDate; } set { _firstRateChangePaymentEffectiveDate = value; } }
        private StringEnumValue<FNMHomeImprovementProductType> _fNMHomeImprovementProductType;
        public StringEnumValue<FNMHomeImprovementProductType> FNMHomeImprovementProductType { get { return _fNMHomeImprovementProductType; } set { _fNMHomeImprovementProductType = value; } }
        private StringEnumValue<FreddieARMIndexType> _freddieARMIndexType;
        public StringEnumValue<FreddieARMIndexType> FreddieARMIndexType { get { return _freddieARMIndexType; } set { _freddieARMIndexType = value; } }
        private StringEnumValue<FreddieAutoUWDec> _freddieAutoUWDec;
        public StringEnumValue<FreddieAutoUWDec> FreddieAutoUWDec { get { return _freddieAutoUWDec; } set { _freddieAutoUWDec = value; } }
        private StringEnumValue<FreddieAVMModelNameTypeExpl> _freddieAVMModelNameTypeExpl;
        public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAVMModelNameTypeExpl { get { return _freddieAVMModelNameTypeExpl; } set { _freddieAVMModelNameTypeExpl = value; } }
        private StringEnumValue<FeddieBorrowerAlienStatus> _freddieBorrowerAlienStatus;
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get { return _freddieBorrowerAlienStatus; } set { _freddieBorrowerAlienStatus = value; } }
        private StringEnumValue<FeddieBorrowerAlienStatus> _freddieCoBorrowerAlienStatus;
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get { return _freddieCoBorrowerAlienStatus; } set { _freddieCoBorrowerAlienStatus = value; } }
        private DirtyValue<string> _freddieCreditScoreProviderName;
        public string FreddieCreditScoreProviderName { get { return _freddieCreditScoreProviderName; } set { _freddieCreditScoreProviderName = value; } }
        private StringEnumValue<FreddieDownPaymentType> _freddieDownPaymentType;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get { return _freddieDownPaymentType; } set { _freddieDownPaymentType = value; } }
        private StringEnumValue<DownPaymentSourceType> _freddieDownPmt2SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get { return _freddieDownPmt2SourceType; } set { _freddieDownPmt2SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _freddieDownPmt2SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get { return _freddieDownPmt2SourceTypeExpl; } set { _freddieDownPmt2SourceTypeExpl = value; } }
        private StringEnumValue<FreddieDownPaymentType> _freddieDownPmt2Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get { return _freddieDownPmt2Type; } set { _freddieDownPmt2Type = value; } }
        private StringEnumValue<FundsTypeDescription> _freddieDownPmt2TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get { return _freddieDownPmt2TypeExpl; } set { _freddieDownPmt2TypeExpl = value; } }
        private DirtyValue<decimal?> _freddieDownPmt3Amt;
        public decimal? FreddieDownPmt3Amt { get { return _freddieDownPmt3Amt; } set { _freddieDownPmt3Amt = value; } }
        private StringEnumValue<DownPaymentSourceType> _freddieDownPmt3SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get { return _freddieDownPmt3SourceType; } set { _freddieDownPmt3SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _freddieDownPmt3SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get { return _freddieDownPmt3SourceTypeExpl; } set { _freddieDownPmt3SourceTypeExpl = value; } }
        private StringEnumValue<FreddieDownPaymentType> _freddieDownPmt3Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get { return _freddieDownPmt3Type; } set { _freddieDownPmt3Type = value; } }
        private StringEnumValue<FundsTypeDescription> _freddieDownPmt3TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get { return _freddieDownPmt3TypeExpl; } set { _freddieDownPmt3TypeExpl = value; } }
        private DirtyValue<decimal?> _freddieDownPmt4Amt;
        public decimal? FreddieDownPmt4Amt { get { return _freddieDownPmt4Amt; } set { _freddieDownPmt4Amt = value; } }
        private StringEnumValue<DownPaymentSourceType> _freddieDownPmt4SourceType;
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get { return _freddieDownPmt4SourceType; } set { _freddieDownPmt4SourceType = value; } }
        private StringEnumValue<SourceTypeDescription> _freddieDownPmt4SourceTypeExpl;
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get { return _freddieDownPmt4SourceTypeExpl; } set { _freddieDownPmt4SourceTypeExpl = value; } }
        private StringEnumValue<FreddieDownPaymentType> _freddieDownPmt4Type;
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get { return _freddieDownPmt4Type; } set { _freddieDownPmt4Type = value; } }
        private StringEnumValue<FundsTypeDescription> _freddieDownPmt4TypeExpl;
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get { return _freddieDownPmt4TypeExpl; } set { _freddieDownPmt4TypeExpl = value; } }
        private StringEnumValue<FundsTypeDescription> _freddieExplanationOfDownPayment;
        public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get { return _freddieExplanationOfDownPayment; } set { _freddieExplanationOfDownPayment = value; } }
        private StringEnumValue<FreddieInvestorCollateralProgramIdentifier> _freddieInvestorCollateralProgramIdentifier;
        public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get { return _freddieInvestorCollateralProgramIdentifier; } set { _freddieInvestorCollateralProgramIdentifier = value; } }
        private DirtyValue<string> _freddieInvestorFeatureIdentifier;
        public string FreddieInvestorFeatureIdentifier { get { return _freddieInvestorFeatureIdentifier; } set { _freddieInvestorFeatureIdentifier = value; } }
        private StringEnumValue<FreddieLegalEntityType> _freddieLegalEntityType;
        public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get { return _freddieLegalEntityType; } set { _freddieLegalEntityType = value; } }
        private StringEnumValue<FreddieLegalEntityTypeOther> _freddieLegalEntityTypeOther;
        public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get { return _freddieLegalEntityTypeOther; } set { _freddieLegalEntityTypeOther = value; } }
        private StringEnumValue<FreddieLoanProgramIdentifier> _freddieLoanProgramIdentifier;
        public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get { return _freddieLoanProgramIdentifier; } set { _freddieLoanProgramIdentifier = value; } }
        private StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> _freddieLoanTypePublicAndIndianHousingIndicator;
        public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get { return _freddieLoanTypePublicAndIndianHousingIndicator; } set { _freddieLoanTypePublicAndIndianHousingIndicator = value; } }
        private StringEnumValue<FreddieMICompanyNameTypeOther> _freddieMICompanyNameTypeOther;
        public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMICompanyNameTypeOther { get { return _freddieMICompanyNameTypeOther; } set { _freddieMICompanyNameTypeOther = value; } }
        private StringEnumValue<FreddieMortgageType> _freddieMortgageType;
        public StringEnumValue<FreddieMortgageType> FreddieMortgageType { get { return _freddieMortgageType; } set { _freddieMortgageType = value; } }
        private StringEnumValue<FreddieProjectClassificationType> _freddieProjectClassificationType;
        public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get { return _freddieProjectClassificationType; } set { _freddieProjectClassificationType = value; } }
        private StringEnumValue<PropertyFormType> _freddiePropertyFormType;
        public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get { return _freddiePropertyFormType; } set { _freddiePropertyFormType = value; } }
        private StringEnumValue<FreddieRefinanceCashOutDeterminationType> _freddieRefinanceCashOutDeterminationType;
        public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get { return _freddieRefinanceCashOutDeterminationType; } set { _freddieRefinanceCashOutDeterminationType = value; } }
        private StringEnumValue<FreddieRefinanceType> _freddieRefinanceType;
        public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get { return _freddieRefinanceType; } set { _freddieRefinanceType = value; } }
        private DirtyValue<bool?> _freddieRelatedClosedEndSecondIndicator;
        public bool? FreddieRelatedClosedEndSecondIndicator { get { return _freddieRelatedClosedEndSecondIndicator; } set { _freddieRelatedClosedEndSecondIndicator = value; } }
        private DirtyValue<string> _freddieRelatedInvestorLoanID;
        public string FreddieRelatedInvestorLoanID { get { return _freddieRelatedInvestorLoanID; } set { _freddieRelatedInvestorLoanID = value; } }
        private StringEnumValue<FreddieRelatedLoanInvestorType> _freddieRelatedLoanInvestorType;
        public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get { return _freddieRelatedLoanInvestorType; } set { _freddieRelatedLoanInvestorType = value; } }
        private StringEnumValue<FreddieRelatedLoanLienPosition> _freddieRelatedLoanLienPosition;
        public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get { return _freddieRelatedLoanLienPosition; } set { _freddieRelatedLoanLienPosition = value; } }
        private StringEnumValue<FreddieRelatedLoanType> _freddieRelatedLoanType;
        public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get { return _freddieRelatedLoanType; } set { _freddieRelatedLoanType = value; } }
        private StringEnumValue<FreddieSectionOfAct> _freddieSectionOfAct;
        public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get { return _freddieSectionOfAct; } set { _freddieSectionOfAct = value; } }
        private StringEnumValue<FreddieUnderwritingTypeOther> _freddieUnderwritingTypeOther;
        public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get { return _freddieUnderwritingTypeOther; } set { _freddieUnderwritingTypeOther = value; } }
        private StringEnumValue<GinnieConstructionMethodType> _ginnieConstructionMethodType;
        public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get { return _ginnieConstructionMethodType; } set { _ginnieConstructionMethodType = value; } }
        private DirtyValue<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        public decimal? GinnieGovernmentAnnualPremiumAmount { get { return _ginnieGovernmentAnnualPremiumAmount; } set { _ginnieGovernmentAnnualPremiumAmount = value; } }
        private StringEnumValue<GinnieMortgageType> _ginnieMortgageType;
        public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get { return _ginnieMortgageType; } set { _ginnieMortgageType = value; } }
        private DirtyValue<string> _ginnieOtherConstructionMethodType;
        public string GinnieOtherConstructionMethodType { get { return _ginnieOtherConstructionMethodType; } set { _ginnieOtherConstructionMethodType = value; } }
        private DirtyValue<decimal?> _governmentAnnualPremiumPercent;
        public decimal? GovernmentAnnualPremiumPercent { get { return _governmentAnnualPremiumPercent; } set { _governmentAnnualPremiumPercent = value; } }
        private StringEnumValue<GovernmentRefinanceType> _governmentRefinanceType;
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get { return _governmentRefinanceType; } set { _governmentRefinanceType = value; } }
        private DirtyValue<decimal?> _governmentUpfrontPremiumAmount;
        public decimal? GovernmentUpfrontPremiumAmount { get { return _governmentUpfrontPremiumAmount; } set { _governmentUpfrontPremiumAmount = value; } }
        private DirtyValue<decimal?> _governmentUpfrontPremiumPercent;
        public decimal? GovernmentUpfrontPremiumPercent { get { return _governmentUpfrontPremiumPercent; } set { _governmentUpfrontPremiumPercent = value; } }
        private StringEnumValue<GSEProjectType> _gSEProjectType;
        public StringEnumValue<GSEProjectType> GSEProjectType { get { return _gSEProjectType; } set { _gSEProjectType = value; } }
        private DirtyValue<bool?> _guaranteeFeeAddOnIndicator;
        public bool? GuaranteeFeeAddOnIndicator { get { return _guaranteeFeeAddOnIndicator; } set { _guaranteeFeeAddOnIndicator = value; } }
        private DirtyValue<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get { return _guarantyFeeAfterAlternatePaymentMethodPercent; } set { _guarantyFeeAfterAlternatePaymentMethodPercent = value; } }
        private DirtyValue<decimal?> _guarantyFeePercent;
        public decimal? GuarantyFeePercent { get { return _guarantyFeePercent; } set { _guarantyFeePercent = value; } }
        private DirtyValue<decimal?> _guarantyPercent;
        public decimal? GuarantyPercent { get { return _guarantyPercent; } set { _guarantyPercent = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private StringEnumValue<IndexType> _indexType;
        public StringEnumValue<IndexType> IndexType { get { return _indexType; } set { _indexType = value; } }
        private DirtyValue<int?> _initialFixedPeriodEffectiveMonthsCount;
        public int? InitialFixedPeriodEffectiveMonthsCount { get { return _initialFixedPeriodEffectiveMonthsCount; } set { _initialFixedPeriodEffectiveMonthsCount = value; } }
        private StringEnumValue<InterestAccrualType> _interestAccrualType;
        public StringEnumValue<InterestAccrualType> InterestAccrualType { get { return _interestAccrualType; } set { _interestAccrualType = value; } }
        private DirtyValue<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _interestAndPaymentAdjustmentIndexLeadDaysCount; } set { _interestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        private StringEnumValue<InterestCalculationBasisType> _interestCalculationBasisType;
        public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get { return _interestCalculationBasisType; } set { _interestCalculationBasisType = value; } }
        private DirtyValue<int?> _interestCalculationEffectiveMonthsCount;
        public int? InterestCalculationEffectiveMonthsCount { get { return _interestCalculationEffectiveMonthsCount; } set { _interestCalculationEffectiveMonthsCount = value; } }
        private StringEnumValue<InterestCalculationType> _interestCalculationType;
        public StringEnumValue<InterestCalculationType> InterestCalculationType { get { return _interestCalculationType; } set { _interestCalculationType = value; } }
        private StringEnumValue<InvestorCollateralProgramIdentifier> _investorCollateralProgramIdentifier;
        public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get { return _investorCollateralProgramIdentifier; } set { _investorCollateralProgramIdentifier = value; } }
        private DirtyValue<string> _investorCommitmentIdentifier;
        public string InvestorCommitmentIdentifier { get { return _investorCommitmentIdentifier; } set { _investorCommitmentIdentifier = value; } }
        private DirtyValue<string> _investorFeatureIdentifier;
        public string InvestorFeatureIdentifier { get { return _investorFeatureIdentifier; } set { _investorFeatureIdentifier = value; } }
        private DirtyValue<string> _investorFeatureIdPool;
        public string InvestorFeatureIdPool { get { return _investorFeatureIdPool; } set { _investorFeatureIdPool = value; } }
        private DirtyValue<decimal?> _investorOwnershipPercent;
        public decimal? InvestorOwnershipPercent { get { return _investorOwnershipPercent; } set { _investorOwnershipPercent = value; } }
        private DirtyValue<string> _investorProductPlanIdentifier;
        public string InvestorProductPlanIdentifier { get { return _investorProductPlanIdentifier; } set { _investorProductPlanIdentifier = value; } }
        private DirtyValue<int?> _investorRemittanceDay;
        public int? InvestorRemittanceDay { get { return _investorRemittanceDay; } set { _investorRemittanceDay = value; } }
        private StringEnumValue<InvestorRemittanceType> _investorRemittanceType;
        public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get { return _investorRemittanceType; } set { _investorRemittanceType = value; } }
        private DirtyValue<string> _issuerIdentifier;
        public string IssuerIdentifier { get { return _issuerIdentifier; } set { _issuerIdentifier = value; } }
        private DirtyValue<DateTime?> _lastPaidInstallmentDueDate;
        public DateTime? LastPaidInstallmentDueDate { get { return _lastPaidInstallmentDueDate; } set { _lastPaidInstallmentDueDate = value; } }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get { return _lastPaymentReceivedDate; } set { _lastPaymentReceivedDate = value; } }
        private DirtyValue<DateTime?> _latestConversionEffectiveDate;
        public DateTime? LatestConversionEffectiveDate { get { return _latestConversionEffectiveDate; } set { _latestConversionEffectiveDate = value; } }
        private DirtyValue<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get { return _lenderPaidMIInterestRateAdjustmentPercent; } set { _lenderPaidMIInterestRateAdjustmentPercent = value; } }
        private DirtyValue<DateTime?> _lendersDeliveryDate;
        public DateTime? LendersDeliveryDate { get { return _lendersDeliveryDate; } set { _lendersDeliveryDate = value; } }
        private DirtyValue<decimal?> _loanAcquisitionScheduledUPBAmount;
        public decimal? LoanAcquisitionScheduledUPBAmount { get { return _loanAcquisitionScheduledUPBAmount; } set { _loanAcquisitionScheduledUPBAmount = value; } }
        private DirtyValue<int?> _loanAmortizationMaximumTermMonthsCount;
        public int? LoanAmortizationMaximumTermMonthsCount { get { return _loanAmortizationMaximumTermMonthsCount; } set { _loanAmortizationMaximumTermMonthsCount = value; } }
        private DirtyValue<int?> _loanBuyupBuydownBasisPointNumber;
        public int? LoanBuyupBuydownBasisPointNumber { get { return _loanBuyupBuydownBasisPointNumber; } set { _loanBuyupBuydownBasisPointNumber = value; } }
        private StringEnumValue<LoanBuyupBuydownType> _loanBuyupBuydownType;
        public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get { return _loanBuyupBuydownType; } set { _loanBuyupBuydownType = value; } }
        private StringEnumValue<LoanDefaultLossPartyType> _loanDefaultLossPartyType;
        public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get { return _loanDefaultLossPartyType; } set { _loanDefaultLossPartyType = value; } }
        private DirtyValue<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get { return _loanDeliveredThroughServicingReleasedProcessIndicator; } set { _loanDeliveredThroughServicingReleasedProcessIndicator = value; } }
        private StringEnumValue<LoanIdentifierValueType> _loanIdentifierValueType;
        public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get { return _loanIdentifierValueType; } set { _loanIdentifierValueType = value; } }
        private DirtyValue<DateTime?> _loanInterestAccrualStartDate;
        public DateTime? LoanInterestAccrualStartDate { get { return _loanInterestAccrualStartDate; } set { _loanInterestAccrualStartDate = value; } }
        private DirtyValue<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get { return _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; } set { _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = value; } }
        private StringEnumValue<LoanLevelCreditScoreSelectionMethodType> _loanLevelCreditScoreSelectionMethodType;
        public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get { return _loanLevelCreditScoreSelectionMethodType; } set { _loanLevelCreditScoreSelectionMethodType = value; } }
        private DirtyValue<int?> _loanLevelCreditScoreValue;
        public int? LoanLevelCreditScoreValue { get { return _loanLevelCreditScoreValue; } set { _loanLevelCreditScoreValue = value; } }
        private DirtyValue<DateTime?> _loanModificationEffectiveDate;
        public DateTime? LoanModificationEffectiveDate { get { return _loanModificationEffectiveDate; } set { _loanModificationEffectiveDate = value; } }
        private DirtyValue<DateTime?> _loanStateDate;
        public DateTime? LoanStateDate { get { return _loanStateDate; } set { _loanStateDate = value; } }
        private StringEnumValue<ManufacturedHomeWidthType> _manufacturedHomeWidthType;
        public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get { return _manufacturedHomeWidthType; } set { _manufacturedHomeWidthType = value; } }
        private DirtyValue<bool?> _mBSWeightedMarginIndicator;
        public bool? MBSWeightedMarginIndicator { get { return _mBSWeightedMarginIndicator; } set { _mBSWeightedMarginIndicator = value; } }
        private StringEnumValue<TrueOrFalse> _mERSOriginalMortgageeOfRecordIndicator;
        public StringEnumValue<TrueOrFalse> MERSOriginalMortgageeOfRecordIndicator { get { return _mERSOriginalMortgageeOfRecordIndicator; } set { _mERSOriginalMortgageeOfRecordIndicator = value; } }
        private StringEnumValue<MICompanyNameType> _mICompanyNameType;
        public StringEnumValue<MICompanyNameType> MICompanyNameType { get { return _mICompanyNameType; } set { _mICompanyNameType = value; } }
        private StringEnumValue<ClosingCostSourceType> _mIPremiumSourceType;
        public StringEnumValue<ClosingCostSourceType> MIPremiumSourceType { get { return _mIPremiumSourceType; } set { _mIPremiumSourceType = value; } }
        private DirtyValue<DateTime?> _monetaryEventAppliedDate;
        public DateTime? MonetaryEventAppliedDate { get { return _monetaryEventAppliedDate; } set { _monetaryEventAppliedDate = value; } }
        private DirtyValue<decimal?> _monetaryEventGrossPrincipalAmount;
        public decimal? MonetaryEventGrossPrincipalAmount { get { return _monetaryEventGrossPrincipalAmount; } set { _monetaryEventGrossPrincipalAmount = value; } }
        private StringEnumValue<MonetaryEventType> _monetaryEventType;
        public StringEnumValue<MonetaryEventType> MonetaryEventType { get { return _monetaryEventType; } set { _monetaryEventType = value; } }
        private DirtyValue<bool?> _mortgageBackedSecurityIndicator;
        public bool? MortgageBackedSecurityIndicator { get { return _mortgageBackedSecurityIndicator; } set { _mortgageBackedSecurityIndicator = value; } }
        private DirtyValue<bool?> _mortgageModificationIndicator;
        public bool? MortgageModificationIndicator { get { return _mortgageModificationIndicator; } set { _mortgageModificationIndicator = value; } }
        private StringEnumValue<UlddMortgageOriginator> _mortgageOriginator;
        public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get { return _mortgageOriginator; } set { _mortgageOriginator = value; } }
        private StringEnumValue<MortgageProgramType> _mortgageProgramType;
        public StringEnumValue<MortgageProgramType> MortgageProgramType { get { return _mortgageProgramType; } set { _mortgageProgramType = value; } }
        private DirtyValue<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get { return _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; } set { _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = value; } }
        private DirtyValue<DateTime?> _nextRateAdjustmentEffectiveDate;
        public DateTime? NextRateAdjustmentEffectiveDate { get { return _nextRateAdjustmentEffectiveDate; } set { _nextRateAdjustmentEffectiveDate = value; } }
        private DirtyValue<string> _notePayToName;
        public string NotePayToName { get { return _notePayToName; } set { _notePayToName = value; } }
        private DirtyValue<int?> _numberOfUnitsSold;
        public int? NumberOfUnitsSold { get { return _numberOfUnitsSold; } set { _numberOfUnitsSold = value; } }
        private DirtyValue<string> _otherDownPaymentFundsType;
        public string OtherDownPaymentFundsType { get { return _otherDownPaymentFundsType; } set { _otherDownPaymentFundsType = value; } }
        private DirtyValue<decimal?> _otherFundsCollectedAtClosingAmount;
        public decimal? OtherFundsCollectedAtClosingAmount { get { return _otherFundsCollectedAtClosingAmount; } set { _otherFundsCollectedAtClosingAmount = value; } }
        private StringEnumValue<OtherFundsCollectedAtClosingType> _otherFundsCollectedAtClosingType;
        public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get { return _otherFundsCollectedAtClosingType; } set { _otherFundsCollectedAtClosingType = value; } }
        private DirtyValue<string> _payeeID;
        public string PayeeID { get { return _payeeID; } set { _payeeID = value; } }
        private DirtyValue<int?> _paymentBillingStatementLeadDaysCount;
        public int? PaymentBillingStatementLeadDaysCount { get { return _paymentBillingStatementLeadDaysCount; } set { _paymentBillingStatementLeadDaysCount = value; } }
        private DirtyValue<decimal?> _perChangeMaximumDecreaseRatePercent;
        public decimal? PerChangeMaximumDecreaseRatePercent { get { return _perChangeMaximumDecreaseRatePercent; } set { _perChangeMaximumDecreaseRatePercent = value; } }
        private DirtyValue<decimal?> _perChangeMaximumIncreaseRatePercent;
        public decimal? PerChangeMaximumIncreaseRatePercent { get { return _perChangeMaximumIncreaseRatePercent; } set { _perChangeMaximumIncreaseRatePercent = value; } }
        private DirtyValue<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get { return _perChangePrincipalAndInterestPaymentAdjustmentPercent; } set { _perChangePrincipalAndInterestPaymentAdjustmentPercent = value; } }
        private DirtyValue<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get { return _perChangeRateAdjustmentEffectiveDate; } set { _perChangeRateAdjustmentEffectiveDate = value; } }
        private DirtyValue<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get { return _perChangeRateAdjustmentFrequencyMonthsCount; } set { _perChangeRateAdjustmentFrequencyMonthsCount = value; } }
        private StringEnumValue<PoolAccrualRateStructureType> _poolAccrualRateStructureType;
        public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get { return _poolAccrualRateStructureType; } set { _poolAccrualRateStructureType = value; } }
        private StringEnumValue<PoolAmortizationType> _poolAmortizationType;
        public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get { return _poolAmortizationType; } set { _poolAmortizationType = value; } }
        private DirtyValue<bool?> _poolAssumabilityIndicator;
        public bool? PoolAssumabilityIndicator { get { return _poolAssumabilityIndicator; } set { _poolAssumabilityIndicator = value; } }
        private DirtyValue<bool?> _poolBalloonIndicator;
        public bool? PoolBalloonIndicator { get { return _poolBalloonIndicator; } set { _poolBalloonIndicator = value; } }
        private DirtyValue<DateTime?> _poolCertificatePaymentDate;
        public DateTime? PoolCertificatePaymentDate { get { return _poolCertificatePaymentDate; } set { _poolCertificatePaymentDate = value; } }
        private StringEnumValue<PoolClassType> _poolClassType;
        public StringEnumValue<PoolClassType> PoolClassType { get { return _poolClassType; } set { _poolClassType = value; } }
        private StringEnumValue<TrueOrFalse> _poolConcurrentTransferIndicator;
        public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get { return _poolConcurrentTransferIndicator; } set { _poolConcurrentTransferIndicator = value; } }
        private DirtyValue<int?> _poolCurrentLoanCount;
        public int? PoolCurrentLoanCount { get { return _poolCurrentLoanCount; } set { _poolCurrentLoanCount = value; } }
        private DirtyValue<decimal?> _poolCurrentPrincipalBalanceAmount;
        public decimal? PoolCurrentPrincipalBalanceAmount { get { return _poolCurrentPrincipalBalanceAmount; } set { _poolCurrentPrincipalBalanceAmount = value; } }
        private DirtyValue<string> _poolDocumentCustodianID;
        public string PoolDocumentCustodianID { get { return _poolDocumentCustodianID; } set { _poolDocumentCustodianID = value; } }
        private DirtyValue<decimal?> _poolFixedServicingFeePercent;
        public decimal? PoolFixedServicingFeePercent { get { return _poolFixedServicingFeePercent; } set { _poolFixedServicingFeePercent = value; } }
        private DirtyValue<string> _poolIdentifier;
        public string PoolIdentifier { get { return _poolIdentifier; } set { _poolIdentifier = value; } }
        private StringEnumValue<PoolingMethodType> _poolingMethodType;
        public StringEnumValue<PoolingMethodType> PoolingMethodType { get { return _poolingMethodType; } set { _poolingMethodType = value; } }
        private DirtyValue<DateTime?> _poolInterestAdjustmentEffectiveDate;
        public DateTime? PoolInterestAdjustmentEffectiveDate { get { return _poolInterestAdjustmentEffectiveDate; } set { _poolInterestAdjustmentEffectiveDate = value; } }
        private DirtyValue<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get { return _poolInterestAdjustmentIndexLeadDaysCount; } set { _poolInterestAdjustmentIndexLeadDaysCount = value; } }
        private DirtyValue<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; } set { _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        private DirtyValue<bool?> _poolInterestOnlyIndicator;
        public bool? PoolInterestOnlyIndicator { get { return _poolInterestOnlyIndicator; } set { _poolInterestOnlyIndicator = value; } }
        private DirtyValue<decimal?> _poolInterestRateRoundingPercent;
        public decimal? PoolInterestRateRoundingPercent { get { return _poolInterestRateRoundingPercent; } set { _poolInterestRateRoundingPercent = value; } }
        private StringEnumValue<PoolInterestRateRoundingType> _poolInterestRateRoundingType;
        public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get { return _poolInterestRateRoundingType; } set { _poolInterestRateRoundingType = value; } }
        private DirtyValue<string> _poolInvestorProductPlanIdentifier;
        public string PoolInvestorProductPlanIdentifier { get { return _poolInvestorProductPlanIdentifier; } set { _poolInvestorProductPlanIdentifier = value; } }
        private DirtyValue<DateTime?> _poolIssueDate;
        public DateTime? PoolIssueDate { get { return _poolIssueDate; } set { _poolIssueDate = value; } }
        private DirtyValue<string> _poolIssuerTransferee;
        public string PoolIssuerTransferee { get { return _poolIssuerTransferee; } set { _poolIssuerTransferee = value; } }
        private DirtyValue<decimal?> _poolMarginRatePercent;
        public decimal? PoolMarginRatePercent { get { return _poolMarginRatePercent; } set { _poolMarginRatePercent = value; } }
        private DirtyValue<DateTime?> _poolMaturityDate;
        public DateTime? PoolMaturityDate { get { return _poolMaturityDate; } set { _poolMaturityDate = value; } }
        private DirtyValue<int?> _poolMaturityPeriodCount;
        public int? PoolMaturityPeriodCount { get { return _poolMaturityPeriodCount; } set { _poolMaturityPeriodCount = value; } }
        private DirtyValue<decimal?> _poolMaximumAccrualRatePercent;
        public decimal? PoolMaximumAccrualRatePercent { get { return _poolMaximumAccrualRatePercent; } set { _poolMaximumAccrualRatePercent = value; } }
        private DirtyValue<decimal?> _poolMinimumAccrualRatePercent;
        public decimal? PoolMinimumAccrualRatePercent { get { return _poolMinimumAccrualRatePercent; } set { _poolMinimumAccrualRatePercent = value; } }
        private StringEnumValue<PoolMortgageType> _poolMortgageType;
        public StringEnumValue<PoolMortgageType> PoolMortgageType { get { return _poolMortgageType; } set { _poolMortgageType = value; } }
        private DirtyValue<int?> _poolScheduledRemittancePaymentDay;
        public int? PoolScheduledRemittancePaymentDay { get { return _poolScheduledRemittancePaymentDay; } set { _poolScheduledRemittancePaymentDay = value; } }
        private DirtyValue<decimal?> _poolSecurityIssueDateInterestRatePercent;
        public decimal? PoolSecurityIssueDateInterestRatePercent { get { return _poolSecurityIssueDateInterestRatePercent; } set { _poolSecurityIssueDateInterestRatePercent = value; } }
        private DirtyValue<string> _poolSellerID;
        public string PoolSellerID { get { return _poolSellerID; } set { _poolSellerID = value; } }
        private DirtyValue<string> _poolServicerID;
        public string PoolServicerID { get { return _poolServicerID; } set { _poolServicerID = value; } }
        private StringEnumValue<PoolStructureType> _poolStructureType;
        public StringEnumValue<PoolStructureType> PoolStructureType { get { return _poolStructureType; } set { _poolStructureType = value; } }
        private DirtyValue<string> _poolSuffixIdentifier;
        public string PoolSuffixIdentifier { get { return _poolSuffixIdentifier; } set { _poolSuffixIdentifier = value; } }
        private DirtyValue<DateTime?> _priceLockDatetime;
        public DateTime? PriceLockDatetime { get { return _priceLockDatetime; } set { _priceLockDatetime = value; } }
        private StringEnumValue<PrimaryMIAbsenceReasonType> _primaryMIAbsenceReasonType;
        public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMIAbsenceReasonType { get { return _primaryMIAbsenceReasonType; } set { _primaryMIAbsenceReasonType = value; } }
        private StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> _primaryMIAbsenceReasonTypeOtherDescription;
        public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMIAbsenceReasonTypeOtherDescription { get { return _primaryMIAbsenceReasonTypeOtherDescription; } set { _primaryMIAbsenceReasonTypeOtherDescription = value; } }
        private StringEnumValue<ProjectAttachmentType> _projectAttachmentType;
        public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get { return _projectAttachmentType; } set { _projectAttachmentType = value; } }
        private StringEnumValue<ProjectDesignType> _projectDesignType;
        public StringEnumValue<ProjectDesignType> ProjectDesignType { get { return _projectDesignType; } set { _projectDesignType = value; } }
        private DirtyValue<int?> _projectUnitCount;
        public int? ProjectUnitCount { get { return _projectUnitCount; } set { _projectUnitCount = value; } }
        private DirtyValue<DateTime?> _propertyValuationEffectiveDate;
        public DateTime? PropertyValuationEffectiveDate { get { return _propertyValuationEffectiveDate; } set { _propertyValuationEffectiveDate = value; } }
        private StringEnumValue<PropertyValuationMethodType> _propertyValuationMethodType;
        public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get { return _propertyValuationMethodType; } set { _propertyValuationMethodType = value; } }
        private DirtyValue<decimal?> _refinanceCashOutAmount;
        public decimal? RefinanceCashOutAmount { get { return _refinanceCashOutAmount; } set { _refinanceCashOutAmount = value; } }
        private StringEnumValue<RefinanceCashOutDeterminationType> _refinanceCashOutDeterminationType;
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get { return _refinanceCashOutDeterminationType; } set { _refinanceCashOutDeterminationType = value; } }
        private DirtyValue<bool?> _relatedLoanBalloonIndicator;
        public bool? RelatedLoanBalloonIndicator { get { return _relatedLoanBalloonIndicator; } set { _relatedLoanBalloonIndicator = value; } }
        private DirtyValue<bool?> _relatedLoanHELOCIndicator;
        public bool? RelatedLoanHELOCIndicator { get { return _relatedLoanHELOCIndicator; } set { _relatedLoanHELOCIndicator = value; } }
        private DirtyValue<bool?> _relatedLoanIndicator;
        public bool? RelatedLoanIndicator { get { return _relatedLoanIndicator; } set { _relatedLoanIndicator = value; } }
        private StringEnumValue<RelatedLoanInvestorType> _relatedLoanInvestorType;
        public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get { return _relatedLoanInvestorType; } set { _relatedLoanInvestorType = value; } }
        private DirtyValue<int?> _relatedLoanMaturityPeriodCount;
        public int? RelatedLoanMaturityPeriodCount { get { return _relatedLoanMaturityPeriodCount; } set { _relatedLoanMaturityPeriodCount = value; } }
        private DirtyValue<DateTime?> _relatedLoanNoteDate;
        public DateTime? RelatedLoanNoteDate { get { return _relatedLoanNoteDate; } set { _relatedLoanNoteDate = value; } }
        private DirtyValue<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get { return _relatedLoanScheduledFirstPaymentDate; } set { _relatedLoanScheduledFirstPaymentDate = value; } }
        private DirtyValue<DateTime?> _relatedLoanStateDateAtClosing;
        public DateTime? RelatedLoanStateDateAtClosing { get { return _relatedLoanStateDateAtClosing; } set { _relatedLoanStateDateAtClosing = value; } }
        private DirtyValue<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get { return _relatedLoanUnpaidPrincipalBalanceAmount; } set { _relatedLoanUnpaidPrincipalBalanceAmount = value; } }
        private DirtyValue<bool?> _relocationLoanIndicator;
        public bool? RelocationLoanIndicator { get { return _relocationLoanIndicator; } set { _relocationLoanIndicator = value; } }
        private StringEnumValue<PartyType> _rEOMarketingPartyType;
        public StringEnumValue<PartyType> REOMarketingPartyType { get { return _rEOMarketingPartyType; } set { _rEOMarketingPartyType = value; } }
        private DirtyValue<bool?> _secondLienIsDeliveredIndicator;
        public bool? SecondLienIsDeliveredIndicator { get { return _secondLienIsDeliveredIndicator; } set { _secondLienIsDeliveredIndicator = value; } }
        private DirtyValue<decimal?> _securityOriginalSubscriptionAmount;
        public decimal? SecurityOriginalSubscriptionAmount { get { return _securityOriginalSubscriptionAmount; } set { _securityOriginalSubscriptionAmount = value; } }
        private DirtyValue<DateTime?> _securityTradeBookEntryDate;
        public DateTime? SecurityTradeBookEntryDate { get { return _securityTradeBookEntryDate; } set { _securityTradeBookEntryDate = value; } }
        private DirtyValue<string> _sellerID;
        public string SellerID { get { return _sellerID; } set { _sellerID = value; } }
        private DirtyValue<string> _sellerLoanIdentifier;
        public string SellerLoanIdentifier { get { return _sellerLoanIdentifier; } set { _sellerLoanIdentifier = value; } }
        private DirtyValue<string> _servicerID;
        public string ServicerID { get { return _servicerID; } set { _servicerID = value; } }
        private DirtyValue<string> _servicerLoanIdentifier;
        public string ServicerLoanIdentifier { get { return _servicerLoanIdentifier; } set { _servicerLoanIdentifier = value; } }
        private DirtyValue<bool?> _sharedEquityIndicator;
        public bool? SharedEquityIndicator { get { return _sharedEquityIndicator; } set { _sharedEquityIndicator = value; } }
        private DirtyValue<bool?> _siteBuiltIndicator;
        public bool? SiteBuiltIndicator { get { return _siteBuiltIndicator; } set { _siteBuiltIndicator = value; } }
        private DirtyValue<bool?> _specialFloodHazardAreaIndicator;
        public bool? SpecialFloodHazardAreaIndicator { get { return _specialFloodHazardAreaIndicator; } set { _specialFloodHazardAreaIndicator = value; } }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get { return _subsequentPerChangeMaximumDecreaseRatePercent; } set { _subsequentPerChangeMaximumDecreaseRatePercent = value; } }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get { return _subsequentPerChangeMaximumIncreaseRatePercent; } set { _subsequentPerChangeMaximumIncreaseRatePercent = value; } }
        private DirtyValue<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get { return _subsequentPerChangeRateAdjustmentEffectiveDate; } set { _subsequentPerChangeRateAdjustmentEffectiveDate = value; } }
        private DirtyValue<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get { return _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; } set { _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = value; } }
        private DirtyValue<bool?> _temporaryBuydownIndicator;
        public bool? TemporaryBuydownIndicator { get { return _temporaryBuydownIndicator; } set { _temporaryBuydownIndicator = value; } }
        private DirtyValue<int?> _totalMortgagedPropertiesCount;
        public int? TotalMortgagedPropertiesCount { get { return _totalMortgagedPropertiesCount; } set { _totalMortgagedPropertiesCount = value; } }
        private DirtyValue<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get { return _unit1SubjectPropertyGrossRentalIncome; } set { _unit1SubjectPropertyGrossRentalIncome = value; } }
        private DirtyValue<int?> _unit1TotalBedrooms;
        public int? Unit1TotalBedrooms { get { return _unit1TotalBedrooms; } set { _unit1TotalBedrooms = value; } }
        private DirtyValue<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get { return _unit2SubjectPropertyGrossRentalIncome; } set { _unit2SubjectPropertyGrossRentalIncome = value; } }
        private DirtyValue<int?> _unit2TotalBedrooms;
        public int? Unit2TotalBedrooms { get { return _unit2TotalBedrooms; } set { _unit2TotalBedrooms = value; } }
        private DirtyValue<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get { return _unit3SubjectPropertyGrossRentalIncome; } set { _unit3SubjectPropertyGrossRentalIncome = value; } }
        private DirtyValue<int?> _unit3TotalBedrooms;
        public int? Unit3TotalBedrooms { get { return _unit3TotalBedrooms; } set { _unit3TotalBedrooms = value; } }
        private DirtyValue<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get { return _unit4SubjectPropertyGrossRentalIncome; } set { _unit4SubjectPropertyGrossRentalIncome = value; } }
        private DirtyValue<int?> _unit4TotalBedrooms;
        public int? Unit4TotalBedrooms { get { return _unit4TotalBedrooms; } set { _unit4TotalBedrooms = value; } }
        private DirtyValue<decimal?> _uPBAmount;
        public decimal? UPBAmount { get { return _uPBAmount; } set { _uPBAmount = value; } }
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
                var dirty = _aCHABARoutingAndTransitIdentifier.Dirty
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
                    || _uPBAmount.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}