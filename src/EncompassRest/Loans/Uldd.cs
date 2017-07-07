using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Uldd : IClean
    {
        private Value<string> _aCHABARoutingAndTransitIdentifier;
        public string ACHABARoutingAndTransitIdentifier { get { return _aCHABARoutingAndTransitIdentifier; } set { _aCHABARoutingAndTransitIdentifier = value; } }
        private Value<string> _aCHABARoutingAndTransitNumber;
        public string ACHABARoutingAndTransitNumber { get { return _aCHABARoutingAndTransitNumber; } set { _aCHABARoutingAndTransitNumber = value; } }
        private Value<string> _aCHBankAccountDescription;
        public string ACHBankAccountDescription { get { return _aCHBankAccountDescription; } set { _aCHBankAccountDescription = value; } }
        private Value<string> _aCHBankAccountIdentifier;
        public string ACHBankAccountIdentifier { get { return _aCHBankAccountIdentifier; } set { _aCHBankAccountIdentifier = value; } }
        private Value<string> _aCHBankAccountPurposeTransitIdentifier;
        public string ACHBankAccountPurposeTransitIdentifier { get { return _aCHBankAccountPurposeTransitIdentifier; } set { _aCHBankAccountPurposeTransitIdentifier = value; } }
        private Value<string> _aCHBankAccountPurposeType;
        public string ACHBankAccountPurposeType { get { return _aCHBankAccountPurposeType; } set { _aCHBankAccountPurposeType = value; } }
        private Value<string> _aCHInstitutionTelegraphicAbbreviationName;
        public string ACHInstitutionTelegraphicAbbreviationName { get { return _aCHInstitutionTelegraphicAbbreviationName; } set { _aCHInstitutionTelegraphicAbbreviationName = value; } }
        private Value<string> _aCHReceiverSubaccountName;
        public string ACHReceiverSubaccountName { get { return _aCHReceiverSubaccountName; } set { _aCHReceiverSubaccountName = value; } }
        private Value<bool?> _additionalPrincipalAmountIndicator;
        public bool? AdditionalPrincipalAmountIndicator { get { return _additionalPrincipalAmountIndicator; } set { _additionalPrincipalAmountIndicator = value; } }
        private Value<decimal?> _aggregateLoanCurtailmentAmount;
        public decimal? AggregateLoanCurtailmentAmount { get { return _aggregateLoanCurtailmentAmount; } set { _aggregateLoanCurtailmentAmount = value; } }
        private Value<string> _appraisalIdentifier;
        public string AppraisalIdentifier { get { return _appraisalIdentifier; } set { _appraisalIdentifier = value; } }
        private Value<string> _attachmentType;
        public string AttachmentType { get { return _attachmentType; } set { _attachmentType = value; } }
        private Value<string> _aVMModelNameType;
        public string AVMModelNameType { get { return _aVMModelNameType; } set { _aVMModelNameType = value; } }
        private Value<bool?> _balloonResetIndicator;
        public bool? BalloonResetIndicator { get { return _balloonResetIndicator; } set { _balloonResetIndicator = value; } }
        private Value<decimal?> _baseGuarantyFeePercent;
        public decimal? BaseGuarantyFeePercent { get { return _baseGuarantyFeePercent; } set { _baseGuarantyFeePercent = value; } }
        private Value<string> _bondFinancePool;
        public string BondFinancePool { get { return _bondFinancePool; } set { _bondFinancePool = value; } }
        private Value<string> _bondFinanceProgramName;
        public string BondFinanceProgramName { get { return _bondFinanceProgramName; } set { _bondFinanceProgramName = value; } }
        private Value<string> _bondFinanceProgramType;
        public string BondFinanceProgramType { get { return _bondFinanceProgramType; } set { _bondFinanceProgramType = value; } }
        private Value<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get { return _borrowerMailToAddressSameasPropertyIndicator; } set { _borrowerMailToAddressSameasPropertyIndicator = value; } }
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        private Value<bool?> _capitalizedLoanIndicator;
        public bool? CapitalizedLoanIndicator { get { return _capitalizedLoanIndicator; } set { _capitalizedLoanIndicator = value; } }
        private Value<string> _certificateIdentifier;
        public string CertificateIdentifier { get { return _certificateIdentifier; } set { _certificateIdentifier = value; } }
        private Value<DateTime?> _certificateMaturityDate;
        public DateTime? CertificateMaturityDate { get { return _certificateMaturityDate; } set { _certificateMaturityDate = value; } }
        private Value<decimal?> _certificatePrincipalBalanceAmount;
        public decimal? CertificatePrincipalBalanceAmount { get { return _certificatePrincipalBalanceAmount; } set { _certificatePrincipalBalanceAmount = value; } }
        private Value<string> _certificateType;
        public string CertificateType { get { return _certificateType; } set { _certificateType = value; } }
        private Value<decimal?> _closingCost2ContributionAmount;
        public decimal? ClosingCost2ContributionAmount { get { return _closingCost2ContributionAmount; } set { _closingCost2ContributionAmount = value; } }
        private Value<string> _closingCost2FundsType;
        public string ClosingCost2FundsType { get { return _closingCost2FundsType; } set { _closingCost2FundsType = value; } }
        private Value<string> _closingCost2FundsTypeOtherDescription;
        public string ClosingCost2FundsTypeOtherDescription { get { return _closingCost2FundsTypeOtherDescription; } set { _closingCost2FundsTypeOtherDescription = value; } }
        private Value<string> _closingCost2SourceType;
        public string ClosingCost2SourceType { get { return _closingCost2SourceType; } set { _closingCost2SourceType = value; } }
        private Value<string> _closingCost2SourceTypeOtherDescription;
        public string ClosingCost2SourceTypeOtherDescription { get { return _closingCost2SourceTypeOtherDescription; } set { _closingCost2SourceTypeOtherDescription = value; } }
        private Value<decimal?> _closingCost3ContributionAmount;
        public decimal? ClosingCost3ContributionAmount { get { return _closingCost3ContributionAmount; } set { _closingCost3ContributionAmount = value; } }
        private Value<string> _closingCost3FundsType;
        public string ClosingCost3FundsType { get { return _closingCost3FundsType; } set { _closingCost3FundsType = value; } }
        private Value<string> _closingCost3FundsTypeOtherDescription;
        public string ClosingCost3FundsTypeOtherDescription { get { return _closingCost3FundsTypeOtherDescription; } set { _closingCost3FundsTypeOtherDescription = value; } }
        private Value<string> _closingCost3SourceType;
        public string ClosingCost3SourceType { get { return _closingCost3SourceType; } set { _closingCost3SourceType = value; } }
        private Value<string> _closingCost3SourceTypeOtherDescription;
        public string ClosingCost3SourceTypeOtherDescription { get { return _closingCost3SourceTypeOtherDescription; } set { _closingCost3SourceTypeOtherDescription = value; } }
        private Value<decimal?> _closingCost4ContributionAmount;
        public decimal? ClosingCost4ContributionAmount { get { return _closingCost4ContributionAmount; } set { _closingCost4ContributionAmount = value; } }
        private Value<string> _closingCost4FundsType;
        public string ClosingCost4FundsType { get { return _closingCost4FundsType; } set { _closingCost4FundsType = value; } }
        private Value<string> _closingCost4FundsTypeOtherDescription;
        public string ClosingCost4FundsTypeOtherDescription { get { return _closingCost4FundsTypeOtherDescription; } set { _closingCost4FundsTypeOtherDescription = value; } }
        private Value<string> _closingCost4SourceType;
        public string ClosingCost4SourceType { get { return _closingCost4SourceType; } set { _closingCost4SourceType = value; } }
        private Value<string> _closingCost4SourceTypeOtherDescription;
        public string ClosingCost4SourceTypeOtherDescription { get { return _closingCost4SourceTypeOtherDescription; } set { _closingCost4SourceTypeOtherDescription = value; } }
        private Value<decimal?> _closingCostContributionAmount;
        public decimal? ClosingCostContributionAmount { get { return _closingCostContributionAmount; } set { _closingCostContributionAmount = value; } }
        private Value<string> _closingCostFundsType;
        public string ClosingCostFundsType { get { return _closingCostFundsType; } set { _closingCostFundsType = value; } }
        private Value<string> _closingCostFundsTypeOtherDescription;
        public string ClosingCostFundsTypeOtherDescription { get { return _closingCostFundsTypeOtherDescription; } set { _closingCostFundsTypeOtherDescription = value; } }
        private Value<string> _closingCostSourceType;
        public string ClosingCostSourceType { get { return _closingCostSourceType; } set { _closingCostSourceType = value; } }
        private Value<string> _closingCostSourceTypeOtherDescription;
        public string ClosingCostSourceTypeOtherDescription { get { return _closingCostSourceTypeOtherDescription; } set { _closingCostSourceTypeOtherDescription = value; } }
        private Value<string> _coBorrowerCountryCode;
        public string CoBorrowerCountryCode { get { return _coBorrowerCountryCode; } set { _coBorrowerCountryCode = value; } }
        private Value<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get { return _coBorrowerMailToAddressSameasPropertyIndicator; } set { _coBorrowerMailToAddressSameasPropertyIndicator = value; } }
        private Value<string> _coBorrowerType;
        public string CoBorrowerType { get { return _coBorrowerType; } set { _coBorrowerType = value; } }
        private Value<string> _condominiumProjectStatusType;
        public string CondominiumProjectStatusType { get { return _condominiumProjectStatusType; } set { _condominiumProjectStatusType = value; } }
        private Value<string> _constructionMethodType;
        public string ConstructionMethodType { get { return _constructionMethodType; } set { _constructionMethodType = value; } }
        private Value<string> _constructionMethodTypeOtherDescription;
        public string ConstructionMethodTypeOtherDescription { get { return _constructionMethodTypeOtherDescription; } set { _constructionMethodTypeOtherDescription = value; } }
        private Value<string> _constructionToPermanentClosingFeatureType;
        public string ConstructionToPermanentClosingFeatureType { get { return _constructionToPermanentClosingFeatureType; } set { _constructionToPermanentClosingFeatureType = value; } }
        private Value<string> _constructionToPermanentClosingType;
        public string ConstructionToPermanentClosingType { get { return _constructionToPermanentClosingType; } set { _constructionToPermanentClosingType = value; } }
        private Value<string> _convertibleStatusType;
        public string ConvertibleStatusType { get { return _convertibleStatusType; } set { _convertibleStatusType = value; } }
        private Value<string> _counselingFormatType;
        public string CounselingFormatType { get { return _counselingFormatType; } set { _counselingFormatType = value; } }
        private Value<string> _counselingFormatTypeOtherDescription;
        public string CounselingFormatTypeOtherDescription { get { return _counselingFormatTypeOtherDescription; } set { _counselingFormatTypeOtherDescription = value; } }
        private Value<string> _counselTypeOther;
        public string CounselTypeOther { get { return _counselTypeOther; } set { _counselTypeOther = value; } }
        private Value<string> _countryCode;
        public string CountryCode { get { return _countryCode; } set { _countryCode = value; } }
        private Value<string> _creditScoreImpairmentType;
        public string CreditScoreImpairmentType { get { return _creditScoreImpairmentType; } set { _creditScoreImpairmentType = value; } }
        private Value<decimal?> _currentAccruedInterestAmount;
        public decimal? CurrentAccruedInterestAmount { get { return _currentAccruedInterestAmount; } set { _currentAccruedInterestAmount = value; } }
        private Value<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get { return _delinquentPaymentsOverPastTwelveMonthsCount; } set { _delinquentPaymentsOverPastTwelveMonthsCount = value; } }
        private Value<string> _documentCustodianID;
        public string DocumentCustodianID { get { return _documentCustodianID; } set { _documentCustodianID = value; } }
        private Value<string> _documentRequiredIndicator;
        public string DocumentRequiredIndicator { get { return _documentRequiredIndicator; } set { _documentRequiredIndicator = value; } }
        private Value<string> _documentSubmissionIndicator;
        public string DocumentSubmissionIndicator { get { return _documentSubmissionIndicator; } set { _documentSubmissionIndicator = value; } }
        private Value<string> _downPaymentFundsType;
        public string DownPaymentFundsType { get { return _downPaymentFundsType; } set { _downPaymentFundsType = value; } }
        private Value<string> _downPaymentOtherTypeDescription;
        public string DownPaymentOtherTypeDescription { get { return _downPaymentOtherTypeDescription; } set { _downPaymentOtherTypeDescription = value; } }
        private Value<string> _downPaymentSourceType;
        public string DownPaymentSourceType { get { return _downPaymentSourceType; } set { _downPaymentSourceType = value; } }
        private Value<string> _downPaymentSourceTypeOtherDescription;
        public string DownPaymentSourceTypeOtherDescription { get { return _downPaymentSourceTypeOtherDescription; } set { _downPaymentSourceTypeOtherDescription = value; } }
        private Value<string> _fannieARMIndexType;
        public string FannieARMIndexType { get { return _fannieARMIndexType; } set { _fannieARMIndexType = value; } }
        private Value<string> _fannieAutoUWDec;
        public string FannieAutoUWDec { get { return _fannieAutoUWDec; } set { _fannieAutoUWDec = value; } }
        private Value<int?> _fannieBLTV;
        public int? FannieBLTV { get { return _fannieBLTV; } set { _fannieBLTV = value; } }
        private Value<string> _fannieBorrowerFirstName;
        public string FannieBorrowerFirstName { get { return _fannieBorrowerFirstName; } set { _fannieBorrowerFirstName = value; } }
        private Value<string> _fannieBorrowerMiddleName;
        public string FannieBorrowerMiddleName { get { return _fannieBorrowerMiddleName; } set { _fannieBorrowerMiddleName = value; } }
        private Value<string> _fannieBuydownContributer;
        public string FannieBuydownContributer { get { return _fannieBuydownContributer; } set { _fannieBuydownContributer = value; } }
        private Value<int?> _fannieCLTV;
        public int? FannieCLTV { get { return _fannieCLTV; } set { _fannieCLTV = value; } }
        private Value<string> _fannieCoBorrowerFirstName;
        public string FannieCoBorrowerFirstName { get { return _fannieCoBorrowerFirstName; } set { _fannieCoBorrowerFirstName = value; } }
        private Value<string> _fannieCoBorrowerMiddleName;
        public string FannieCoBorrowerMiddleName { get { return _fannieCoBorrowerMiddleName; } set { _fannieCoBorrowerMiddleName = value; } }
        private Value<string> _fannieCreditScoreProviderName;
        public string FannieCreditScoreProviderName { get { return _fannieCreditScoreProviderName; } set { _fannieCreditScoreProviderName = value; } }
        private Value<string> _fannieFloodSpecialFeatureCode;
        public string FannieFloodSpecialFeatureCode { get { return _fannieFloodSpecialFeatureCode; } set { _fannieFloodSpecialFeatureCode = value; } }
        private Value<int?> _fannieHCLTV;
        public int? FannieHCLTV { get { return _fannieHCLTV; } set { _fannieHCLTV = value; } }
        private Value<int?> _fannieInvestorOwnershipPercent;
        public int? FannieInvestorOwnershipPercent { get { return _fannieInvestorOwnershipPercent; } set { _fannieInvestorOwnershipPercent = value; } }
        private Value<string> _fannieLegalEntityType;
        public string FannieLegalEntityType { get { return _fannieLegalEntityType; } set { _fannieLegalEntityType = value; } }
        private Value<string> _fannieLegalEntityTypeOther;
        public string FannieLegalEntityTypeOther { get { return _fannieLegalEntityTypeOther; } set { _fannieLegalEntityTypeOther = value; } }
        private Value<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get { return _fannieLenderPaidMIInterestRateAdjustmentPercent; } set { _fannieLenderPaidMIInterestRateAdjustmentPercent = value; } }
        private Value<string> _fannieLoanProgramIdentifier;
        public string FannieLoanProgramIdentifier { get { return _fannieLoanProgramIdentifier; } set { _fannieLoanProgramIdentifier = value; } }
        private Value<int?> _fannieLTV;
        public int? FannieLTV { get { return _fannieLTV; } set { _fannieLTV = value; } }
        private Value<string> _fannieMICompanyNameTypeOther;
        public string FannieMICompanyNameTypeOther { get { return _fannieMICompanyNameTypeOther; } set { _fannieMICompanyNameTypeOther = value; } }
        private Value<int?> _fannieMICoveragePercent;
        public int? FannieMICoveragePercent { get { return _fannieMICoveragePercent; } set { _fannieMICoveragePercent = value; } }
        private Value<int?> _fanniePoolOwnershipPercent;
        public int? FanniePoolOwnershipPercent { get { return _fanniePoolOwnershipPercent; } set { _fanniePoolOwnershipPercent = value; } }
        private Value<string> _fannieProjectClassificationType;
        public string FannieProjectClassificationType { get { return _fannieProjectClassificationType; } set { _fannieProjectClassificationType = value; } }
        private Value<string> _fanniePropertyFormType;
        public string FanniePropertyFormType { get { return _fanniePropertyFormType; } set { _fanniePropertyFormType = value; } }
        private Value<decimal?> _fannieRateSpread;
        public decimal? FannieRateSpread { get { return _fannieRateSpread; } set { _fannieRateSpread = value; } }
        private Value<string> _fannieRefinanceType;
        public string FannieRefinanceType { get { return _fannieRefinanceType; } set { _fannieRefinanceType = value; } }
        private Value<string> _fannieRelatedInvestorLoanID;
        public string FannieRelatedInvestorLoanID { get { return _fannieRelatedInvestorLoanID; } set { _fannieRelatedInvestorLoanID = value; } }
        private Value<string> _fannieRelatedLoanAmortizationType;
        public string FannieRelatedLoanAmortizationType { get { return _fannieRelatedLoanAmortizationType; } set { _fannieRelatedLoanAmortizationType = value; } }
        private Value<string> _fannieRelatedLoanLienPosition;
        public string FannieRelatedLoanLienPosition { get { return _fannieRelatedLoanLienPosition; } set { _fannieRelatedLoanLienPosition = value; } }
        private Value<string> _fannieRelatedLoanType;
        public string FannieRelatedLoanType { get { return _fannieRelatedLoanType; } set { _fannieRelatedLoanType = value; } }
        private Value<string> _fannieSectionOfAct;
        public string FannieSectionOfAct { get { return _fannieSectionOfAct; } set { _fannieSectionOfAct = value; } }
        private Value<int?> _fannieTLTV;
        public int? FannieTLTV { get { return _fannieTLTV; } set { _fannieTLTV = value; } }
        private Value<string> _fannieTrustName;
        public string FannieTrustName { get { return _fannieTrustName; } set { _fannieTrustName = value; } }
        private Value<string> _fannnieMortgageType;
        public string FannnieMortgageType { get { return _fannnieMortgageType; } set { _fannnieMortgageType = value; } }
        private Value<int?> _financedUnitCount;
        public int? FinancedUnitCount { get { return _financedUnitCount; } set { _financedUnitCount = value; } }
        private Value<DateTime?> _firstRateChangePaymentEffectiveDate;
        public DateTime? FirstRateChangePaymentEffectiveDate { get { return _firstRateChangePaymentEffectiveDate; } set { _firstRateChangePaymentEffectiveDate = value; } }
        private Value<string> _fNMHomeImprovementProductType;
        public string FNMHomeImprovementProductType { get { return _fNMHomeImprovementProductType; } set { _fNMHomeImprovementProductType = value; } }
        private Value<string> _freddieARMIndexType;
        public string FreddieARMIndexType { get { return _freddieARMIndexType; } set { _freddieARMIndexType = value; } }
        private Value<string> _freddieAutoUWDec;
        public string FreddieAutoUWDec { get { return _freddieAutoUWDec; } set { _freddieAutoUWDec = value; } }
        private Value<string> _freddieAVMModelNameTypeExpl;
        public string FreddieAVMModelNameTypeExpl { get { return _freddieAVMModelNameTypeExpl; } set { _freddieAVMModelNameTypeExpl = value; } }
        private Value<string> _freddieBorrowerAlienStatus;
        public string FreddieBorrowerAlienStatus { get { return _freddieBorrowerAlienStatus; } set { _freddieBorrowerAlienStatus = value; } }
        private Value<string> _freddieCoBorrowerAlienStatus;
        public string FreddieCoBorrowerAlienStatus { get { return _freddieCoBorrowerAlienStatus; } set { _freddieCoBorrowerAlienStatus = value; } }
        private Value<string> _freddieCreditScoreProviderName;
        public string FreddieCreditScoreProviderName { get { return _freddieCreditScoreProviderName; } set { _freddieCreditScoreProviderName = value; } }
        private Value<string> _freddieDownPaymentType;
        public string FreddieDownPaymentType { get { return _freddieDownPaymentType; } set { _freddieDownPaymentType = value; } }
        private Value<string> _freddieDownPmt2SourceType;
        public string FreddieDownPmt2SourceType { get { return _freddieDownPmt2SourceType; } set { _freddieDownPmt2SourceType = value; } }
        private Value<string> _freddieDownPmt2SourceTypeExpl;
        public string FreddieDownPmt2SourceTypeExpl { get { return _freddieDownPmt2SourceTypeExpl; } set { _freddieDownPmt2SourceTypeExpl = value; } }
        private Value<string> _freddieDownPmt2Type;
        public string FreddieDownPmt2Type { get { return _freddieDownPmt2Type; } set { _freddieDownPmt2Type = value; } }
        private Value<string> _freddieDownPmt2TypeExpl;
        public string FreddieDownPmt2TypeExpl { get { return _freddieDownPmt2TypeExpl; } set { _freddieDownPmt2TypeExpl = value; } }
        private Value<decimal?> _freddieDownPmt3Amt;
        public decimal? FreddieDownPmt3Amt { get { return _freddieDownPmt3Amt; } set { _freddieDownPmt3Amt = value; } }
        private Value<string> _freddieDownPmt3SourceType;
        public string FreddieDownPmt3SourceType { get { return _freddieDownPmt3SourceType; } set { _freddieDownPmt3SourceType = value; } }
        private Value<string> _freddieDownPmt3SourceTypeExpl;
        public string FreddieDownPmt3SourceTypeExpl { get { return _freddieDownPmt3SourceTypeExpl; } set { _freddieDownPmt3SourceTypeExpl = value; } }
        private Value<string> _freddieDownPmt3Type;
        public string FreddieDownPmt3Type { get { return _freddieDownPmt3Type; } set { _freddieDownPmt3Type = value; } }
        private Value<string> _freddieDownPmt3TypeExpl;
        public string FreddieDownPmt3TypeExpl { get { return _freddieDownPmt3TypeExpl; } set { _freddieDownPmt3TypeExpl = value; } }
        private Value<decimal?> _freddieDownPmt4Amt;
        public decimal? FreddieDownPmt4Amt { get { return _freddieDownPmt4Amt; } set { _freddieDownPmt4Amt = value; } }
        private Value<string> _freddieDownPmt4SourceType;
        public string FreddieDownPmt4SourceType { get { return _freddieDownPmt4SourceType; } set { _freddieDownPmt4SourceType = value; } }
        private Value<string> _freddieDownPmt4SourceTypeExpl;
        public string FreddieDownPmt4SourceTypeExpl { get { return _freddieDownPmt4SourceTypeExpl; } set { _freddieDownPmt4SourceTypeExpl = value; } }
        private Value<string> _freddieDownPmt4Type;
        public string FreddieDownPmt4Type { get { return _freddieDownPmt4Type; } set { _freddieDownPmt4Type = value; } }
        private Value<string> _freddieDownPmt4TypeExpl;
        public string FreddieDownPmt4TypeExpl { get { return _freddieDownPmt4TypeExpl; } set { _freddieDownPmt4TypeExpl = value; } }
        private Value<string> _freddieExplanationOfDownPayment;
        public string FreddieExplanationOfDownPayment { get { return _freddieExplanationOfDownPayment; } set { _freddieExplanationOfDownPayment = value; } }
        private Value<string> _freddieInvestorCollateralProgramIdentifier;
        public string FreddieInvestorCollateralProgramIdentifier { get { return _freddieInvestorCollateralProgramIdentifier; } set { _freddieInvestorCollateralProgramIdentifier = value; } }
        private Value<string> _freddieInvestorFeatureIdentifier;
        public string FreddieInvestorFeatureIdentifier { get { return _freddieInvestorFeatureIdentifier; } set { _freddieInvestorFeatureIdentifier = value; } }
        private Value<string> _freddieLegalEntityType;
        public string FreddieLegalEntityType { get { return _freddieLegalEntityType; } set { _freddieLegalEntityType = value; } }
        private Value<string> _freddieLegalEntityTypeOther;
        public string FreddieLegalEntityTypeOther { get { return _freddieLegalEntityTypeOther; } set { _freddieLegalEntityTypeOther = value; } }
        private Value<string> _freddieLoanProgramIdentifier;
        public string FreddieLoanProgramIdentifier { get { return _freddieLoanProgramIdentifier; } set { _freddieLoanProgramIdentifier = value; } }
        private Value<string> _freddieLoanTypePublicAndIndianHousingIndicator;
        public string FreddieLoanTypePublicAndIndianHousingIndicator { get { return _freddieLoanTypePublicAndIndianHousingIndicator; } set { _freddieLoanTypePublicAndIndianHousingIndicator = value; } }
        private Value<string> _freddieMICompanyNameTypeOther;
        public string FreddieMICompanyNameTypeOther { get { return _freddieMICompanyNameTypeOther; } set { _freddieMICompanyNameTypeOther = value; } }
        private Value<string> _freddieMortgageType;
        public string FreddieMortgageType { get { return _freddieMortgageType; } set { _freddieMortgageType = value; } }
        private Value<string> _freddieProjectClassificationType;
        public string FreddieProjectClassificationType { get { return _freddieProjectClassificationType; } set { _freddieProjectClassificationType = value; } }
        private Value<string> _freddiePropertyFormType;
        public string FreddiePropertyFormType { get { return _freddiePropertyFormType; } set { _freddiePropertyFormType = value; } }
        private Value<string> _freddieRefinanceCashOutDeterminationType;
        public string FreddieRefinanceCashOutDeterminationType { get { return _freddieRefinanceCashOutDeterminationType; } set { _freddieRefinanceCashOutDeterminationType = value; } }
        private Value<string> _freddieRefinanceType;
        public string FreddieRefinanceType { get { return _freddieRefinanceType; } set { _freddieRefinanceType = value; } }
        private Value<bool?> _freddieRelatedClosedEndSecondIndicator;
        public bool? FreddieRelatedClosedEndSecondIndicator { get { return _freddieRelatedClosedEndSecondIndicator; } set { _freddieRelatedClosedEndSecondIndicator = value; } }
        private Value<string> _freddieRelatedInvestorLoanID;
        public string FreddieRelatedInvestorLoanID { get { return _freddieRelatedInvestorLoanID; } set { _freddieRelatedInvestorLoanID = value; } }
        private Value<string> _freddieRelatedLoanInvestorType;
        public string FreddieRelatedLoanInvestorType { get { return _freddieRelatedLoanInvestorType; } set { _freddieRelatedLoanInvestorType = value; } }
        private Value<string> _freddieRelatedLoanLienPosition;
        public string FreddieRelatedLoanLienPosition { get { return _freddieRelatedLoanLienPosition; } set { _freddieRelatedLoanLienPosition = value; } }
        private Value<string> _freddieRelatedLoanType;
        public string FreddieRelatedLoanType { get { return _freddieRelatedLoanType; } set { _freddieRelatedLoanType = value; } }
        private Value<string> _freddieSectionOfAct;
        public string FreddieSectionOfAct { get { return _freddieSectionOfAct; } set { _freddieSectionOfAct = value; } }
        private Value<string> _freddieUnderwritingTypeOther;
        public string FreddieUnderwritingTypeOther { get { return _freddieUnderwritingTypeOther; } set { _freddieUnderwritingTypeOther = value; } }
        private Value<string> _ginnieConstructionMethodType;
        public string GinnieConstructionMethodType { get { return _ginnieConstructionMethodType; } set { _ginnieConstructionMethodType = value; } }
        private Value<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        public decimal? GinnieGovernmentAnnualPremiumAmount { get { return _ginnieGovernmentAnnualPremiumAmount; } set { _ginnieGovernmentAnnualPremiumAmount = value; } }
        private Value<string> _ginnieMortgageType;
        public string GinnieMortgageType { get { return _ginnieMortgageType; } set { _ginnieMortgageType = value; } }
        private Value<string> _ginnieOtherConstructionMethodType;
        public string GinnieOtherConstructionMethodType { get { return _ginnieOtherConstructionMethodType; } set { _ginnieOtherConstructionMethodType = value; } }
        private Value<decimal?> _governmentAnnualPremiumPercent;
        public decimal? GovernmentAnnualPremiumPercent { get { return _governmentAnnualPremiumPercent; } set { _governmentAnnualPremiumPercent = value; } }
        private Value<string> _governmentRefinanceType;
        public string GovernmentRefinanceType { get { return _governmentRefinanceType; } set { _governmentRefinanceType = value; } }
        private Value<decimal?> _governmentUpfrontPremiumAmount;
        public decimal? GovernmentUpfrontPremiumAmount { get { return _governmentUpfrontPremiumAmount; } set { _governmentUpfrontPremiumAmount = value; } }
        private Value<decimal?> _governmentUpfrontPremiumPercent;
        public decimal? GovernmentUpfrontPremiumPercent { get { return _governmentUpfrontPremiumPercent; } set { _governmentUpfrontPremiumPercent = value; } }
        private Value<string> _gSEProjectType;
        public string GSEProjectType { get { return _gSEProjectType; } set { _gSEProjectType = value; } }
        private Value<bool?> _guaranteeFeeAddOnIndicator;
        public bool? GuaranteeFeeAddOnIndicator { get { return _guaranteeFeeAddOnIndicator; } set { _guaranteeFeeAddOnIndicator = value; } }
        private Value<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get { return _guarantyFeeAfterAlternatePaymentMethodPercent; } set { _guarantyFeeAfterAlternatePaymentMethodPercent = value; } }
        private Value<decimal?> _guarantyFeePercent;
        public decimal? GuarantyFeePercent { get { return _guarantyFeePercent; } set { _guarantyFeePercent = value; } }
        private Value<decimal?> _guarantyPercent;
        public decimal? GuarantyPercent { get { return _guarantyPercent; } set { _guarantyPercent = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _indexType;
        public string IndexType { get { return _indexType; } set { _indexType = value; } }
        private Value<int?> _initialFixedPeriodEffectiveMonthsCount;
        public int? InitialFixedPeriodEffectiveMonthsCount { get { return _initialFixedPeriodEffectiveMonthsCount; } set { _initialFixedPeriodEffectiveMonthsCount = value; } }
        private Value<string> _interestAccrualType;
        public string InterestAccrualType { get { return _interestAccrualType; } set { _interestAccrualType = value; } }
        private Value<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _interestAndPaymentAdjustmentIndexLeadDaysCount; } set { _interestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        private Value<string> _interestCalculationBasisType;
        public string InterestCalculationBasisType { get { return _interestCalculationBasisType; } set { _interestCalculationBasisType = value; } }
        private Value<int?> _interestCalculationEffectiveMonthsCount;
        public int? InterestCalculationEffectiveMonthsCount { get { return _interestCalculationEffectiveMonthsCount; } set { _interestCalculationEffectiveMonthsCount = value; } }
        private Value<string> _interestCalculationType;
        public string InterestCalculationType { get { return _interestCalculationType; } set { _interestCalculationType = value; } }
        private Value<string> _investorCollateralProgramIdentifier;
        public string InvestorCollateralProgramIdentifier { get { return _investorCollateralProgramIdentifier; } set { _investorCollateralProgramIdentifier = value; } }
        private Value<string> _investorCommitmentIdentifier;
        public string InvestorCommitmentIdentifier { get { return _investorCommitmentIdentifier; } set { _investorCommitmentIdentifier = value; } }
        private Value<string> _investorFeatureIdentifier;
        public string InvestorFeatureIdentifier { get { return _investorFeatureIdentifier; } set { _investorFeatureIdentifier = value; } }
        private Value<string> _investorFeatureIdPool;
        public string InvestorFeatureIdPool { get { return _investorFeatureIdPool; } set { _investorFeatureIdPool = value; } }
        private Value<decimal?> _investorOwnershipPercent;
        public decimal? InvestorOwnershipPercent { get { return _investorOwnershipPercent; } set { _investorOwnershipPercent = value; } }
        private Value<string> _investorProductPlanIdentifier;
        public string InvestorProductPlanIdentifier { get { return _investorProductPlanIdentifier; } set { _investorProductPlanIdentifier = value; } }
        private Value<int?> _investorRemittanceDay;
        public int? InvestorRemittanceDay { get { return _investorRemittanceDay; } set { _investorRemittanceDay = value; } }
        private Value<string> _investorRemittanceType;
        public string InvestorRemittanceType { get { return _investorRemittanceType; } set { _investorRemittanceType = value; } }
        private Value<string> _issuerIdentifier;
        public string IssuerIdentifier { get { return _issuerIdentifier; } set { _issuerIdentifier = value; } }
        private Value<DateTime?> _lastPaidInstallmentDueDate;
        public DateTime? LastPaidInstallmentDueDate { get { return _lastPaidInstallmentDueDate; } set { _lastPaidInstallmentDueDate = value; } }
        private Value<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get { return _lastPaymentReceivedDate; } set { _lastPaymentReceivedDate = value; } }
        private Value<DateTime?> _latestConversionEffectiveDate;
        public DateTime? LatestConversionEffectiveDate { get { return _latestConversionEffectiveDate; } set { _latestConversionEffectiveDate = value; } }
        private Value<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get { return _lenderPaidMIInterestRateAdjustmentPercent; } set { _lenderPaidMIInterestRateAdjustmentPercent = value; } }
        private Value<DateTime?> _lendersDeliveryDate;
        public DateTime? LendersDeliveryDate { get { return _lendersDeliveryDate; } set { _lendersDeliveryDate = value; } }
        private Value<decimal?> _loanAcquisitionScheduledUPBAmount;
        public decimal? LoanAcquisitionScheduledUPBAmount { get { return _loanAcquisitionScheduledUPBAmount; } set { _loanAcquisitionScheduledUPBAmount = value; } }
        private Value<int?> _loanAmortizationMaximumTermMonthsCount;
        public int? LoanAmortizationMaximumTermMonthsCount { get { return _loanAmortizationMaximumTermMonthsCount; } set { _loanAmortizationMaximumTermMonthsCount = value; } }
        private Value<int?> _loanBuyupBuydownBasisPointNumber;
        public int? LoanBuyupBuydownBasisPointNumber { get { return _loanBuyupBuydownBasisPointNumber; } set { _loanBuyupBuydownBasisPointNumber = value; } }
        private Value<string> _loanBuyupBuydownType;
        public string LoanBuyupBuydownType { get { return _loanBuyupBuydownType; } set { _loanBuyupBuydownType = value; } }
        private Value<string> _loanDefaultLossPartyType;
        public string LoanDefaultLossPartyType { get { return _loanDefaultLossPartyType; } set { _loanDefaultLossPartyType = value; } }
        private Value<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get { return _loanDeliveredThroughServicingReleasedProcessIndicator; } set { _loanDeliveredThroughServicingReleasedProcessIndicator = value; } }
        private Value<string> _loanIdentifierValueType;
        public string LoanIdentifierValueType { get { return _loanIdentifierValueType; } set { _loanIdentifierValueType = value; } }
        private Value<DateTime?> _loanInterestAccrualStartDate;
        public DateTime? LoanInterestAccrualStartDate { get { return _loanInterestAccrualStartDate; } set { _loanInterestAccrualStartDate = value; } }
        private Value<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get { return _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; } set { _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = value; } }
        private Value<string> _loanLevelCreditScoreSelectionMethodType;
        public string LoanLevelCreditScoreSelectionMethodType { get { return _loanLevelCreditScoreSelectionMethodType; } set { _loanLevelCreditScoreSelectionMethodType = value; } }
        private Value<int?> _loanLevelCreditScoreValue;
        public int? LoanLevelCreditScoreValue { get { return _loanLevelCreditScoreValue; } set { _loanLevelCreditScoreValue = value; } }
        private Value<DateTime?> _loanModificationEffectiveDate;
        public DateTime? LoanModificationEffectiveDate { get { return _loanModificationEffectiveDate; } set { _loanModificationEffectiveDate = value; } }
        private Value<DateTime?> _loanStateDate;
        public DateTime? LoanStateDate { get { return _loanStateDate; } set { _loanStateDate = value; } }
        private Value<string> _manufacturedHomeWidthType;
        public string ManufacturedHomeWidthType { get { return _manufacturedHomeWidthType; } set { _manufacturedHomeWidthType = value; } }
        private Value<bool?> _mBSWeightedMarginIndicator;
        public bool? MBSWeightedMarginIndicator { get { return _mBSWeightedMarginIndicator; } set { _mBSWeightedMarginIndicator = value; } }
        private Value<string> _mERSOriginalMortgageeOfRecordIndicator;
        public string MERSOriginalMortgageeOfRecordIndicator { get { return _mERSOriginalMortgageeOfRecordIndicator; } set { _mERSOriginalMortgageeOfRecordIndicator = value; } }
        private Value<string> _mICompanyNameType;
        public string MICompanyNameType { get { return _mICompanyNameType; } set { _mICompanyNameType = value; } }
        private Value<string> _mIPremiumSourceType;
        public string MIPremiumSourceType { get { return _mIPremiumSourceType; } set { _mIPremiumSourceType = value; } }
        private Value<DateTime?> _monetaryEventAppliedDate;
        public DateTime? MonetaryEventAppliedDate { get { return _monetaryEventAppliedDate; } set { _monetaryEventAppliedDate = value; } }
        private Value<decimal?> _monetaryEventGrossPrincipalAmount;
        public decimal? MonetaryEventGrossPrincipalAmount { get { return _monetaryEventGrossPrincipalAmount; } set { _monetaryEventGrossPrincipalAmount = value; } }
        private Value<string> _monetaryEventType;
        public string MonetaryEventType { get { return _monetaryEventType; } set { _monetaryEventType = value; } }
        private Value<bool?> _mortgageBackedSecurityIndicator;
        public bool? MortgageBackedSecurityIndicator { get { return _mortgageBackedSecurityIndicator; } set { _mortgageBackedSecurityIndicator = value; } }
        private Value<bool?> _mortgageModificationIndicator;
        public bool? MortgageModificationIndicator { get { return _mortgageModificationIndicator; } set { _mortgageModificationIndicator = value; } }
        private Value<string> _mortgageOriginator;
        public string MortgageOriginator { get { return _mortgageOriginator; } set { _mortgageOriginator = value; } }
        private Value<string> _mortgageProgramType;
        public string MortgageProgramType { get { return _mortgageProgramType; } set { _mortgageProgramType = value; } }
        private Value<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get { return _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; } set { _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = value; } }
        private Value<DateTime?> _nextRateAdjustmentEffectiveDate;
        public DateTime? NextRateAdjustmentEffectiveDate { get { return _nextRateAdjustmentEffectiveDate; } set { _nextRateAdjustmentEffectiveDate = value; } }
        private Value<string> _notePayToName;
        public string NotePayToName { get { return _notePayToName; } set { _notePayToName = value; } }
        private Value<int?> _numberOfUnitsSold;
        public int? NumberOfUnitsSold { get { return _numberOfUnitsSold; } set { _numberOfUnitsSold = value; } }
        private Value<string> _otherDownPaymentFundsType;
        public string OtherDownPaymentFundsType { get { return _otherDownPaymentFundsType; } set { _otherDownPaymentFundsType = value; } }
        private Value<decimal?> _otherFundsCollectedAtClosingAmount;
        public decimal? OtherFundsCollectedAtClosingAmount { get { return _otherFundsCollectedAtClosingAmount; } set { _otherFundsCollectedAtClosingAmount = value; } }
        private Value<string> _otherFundsCollectedAtClosingType;
        public string OtherFundsCollectedAtClosingType { get { return _otherFundsCollectedAtClosingType; } set { _otherFundsCollectedAtClosingType = value; } }
        private Value<string> _payeeID;
        public string PayeeID { get { return _payeeID; } set { _payeeID = value; } }
        private Value<int?> _paymentBillingStatementLeadDaysCount;
        public int? PaymentBillingStatementLeadDaysCount { get { return _paymentBillingStatementLeadDaysCount; } set { _paymentBillingStatementLeadDaysCount = value; } }
        private Value<decimal?> _perChangeMaximumDecreaseRatePercent;
        public decimal? PerChangeMaximumDecreaseRatePercent { get { return _perChangeMaximumDecreaseRatePercent; } set { _perChangeMaximumDecreaseRatePercent = value; } }
        private Value<decimal?> _perChangeMaximumIncreaseRatePercent;
        public decimal? PerChangeMaximumIncreaseRatePercent { get { return _perChangeMaximumIncreaseRatePercent; } set { _perChangeMaximumIncreaseRatePercent = value; } }
        private Value<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get { return _perChangePrincipalAndInterestPaymentAdjustmentPercent; } set { _perChangePrincipalAndInterestPaymentAdjustmentPercent = value; } }
        private Value<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get { return _perChangeRateAdjustmentEffectiveDate; } set { _perChangeRateAdjustmentEffectiveDate = value; } }
        private Value<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get { return _perChangeRateAdjustmentFrequencyMonthsCount; } set { _perChangeRateAdjustmentFrequencyMonthsCount = value; } }
        private Value<string> _poolAccrualRateStructureType;
        public string PoolAccrualRateStructureType { get { return _poolAccrualRateStructureType; } set { _poolAccrualRateStructureType = value; } }
        private Value<string> _poolAmortizationType;
        public string PoolAmortizationType { get { return _poolAmortizationType; } set { _poolAmortizationType = value; } }
        private Value<bool?> _poolAssumabilityIndicator;
        public bool? PoolAssumabilityIndicator { get { return _poolAssumabilityIndicator; } set { _poolAssumabilityIndicator = value; } }
        private Value<bool?> _poolBalloonIndicator;
        public bool? PoolBalloonIndicator { get { return _poolBalloonIndicator; } set { _poolBalloonIndicator = value; } }
        private Value<DateTime?> _poolCertificatePaymentDate;
        public DateTime? PoolCertificatePaymentDate { get { return _poolCertificatePaymentDate; } set { _poolCertificatePaymentDate = value; } }
        private Value<string> _poolClassType;
        public string PoolClassType { get { return _poolClassType; } set { _poolClassType = value; } }
        private Value<string> _poolConcurrentTransferIndicator;
        public string PoolConcurrentTransferIndicator { get { return _poolConcurrentTransferIndicator; } set { _poolConcurrentTransferIndicator = value; } }
        private Value<int?> _poolCurrentLoanCount;
        public int? PoolCurrentLoanCount { get { return _poolCurrentLoanCount; } set { _poolCurrentLoanCount = value; } }
        private Value<decimal?> _poolCurrentPrincipalBalanceAmount;
        public decimal? PoolCurrentPrincipalBalanceAmount { get { return _poolCurrentPrincipalBalanceAmount; } set { _poolCurrentPrincipalBalanceAmount = value; } }
        private Value<string> _poolDocumentCustodianID;
        public string PoolDocumentCustodianID { get { return _poolDocumentCustodianID; } set { _poolDocumentCustodianID = value; } }
        private Value<decimal?> _poolFixedServicingFeePercent;
        public decimal? PoolFixedServicingFeePercent { get { return _poolFixedServicingFeePercent; } set { _poolFixedServicingFeePercent = value; } }
        private Value<string> _poolIdentifier;
        public string PoolIdentifier { get { return _poolIdentifier; } set { _poolIdentifier = value; } }
        private Value<string> _poolingMethodType;
        public string PoolingMethodType { get { return _poolingMethodType; } set { _poolingMethodType = value; } }
        private Value<DateTime?> _poolInterestAdjustmentEffectiveDate;
        public DateTime? PoolInterestAdjustmentEffectiveDate { get { return _poolInterestAdjustmentEffectiveDate; } set { _poolInterestAdjustmentEffectiveDate = value; } }
        private Value<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get { return _poolInterestAdjustmentIndexLeadDaysCount; } set { _poolInterestAdjustmentIndexLeadDaysCount = value; } }
        private Value<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get { return _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; } set { _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = value; } }
        private Value<bool?> _poolInterestOnlyIndicator;
        public bool? PoolInterestOnlyIndicator { get { return _poolInterestOnlyIndicator; } set { _poolInterestOnlyIndicator = value; } }
        private Value<decimal?> _poolInterestRateRoundingPercent;
        public decimal? PoolInterestRateRoundingPercent { get { return _poolInterestRateRoundingPercent; } set { _poolInterestRateRoundingPercent = value; } }
        private Value<string> _poolInterestRateRoundingType;
        public string PoolInterestRateRoundingType { get { return _poolInterestRateRoundingType; } set { _poolInterestRateRoundingType = value; } }
        private Value<string> _poolInvestorProductPlanIdentifier;
        public string PoolInvestorProductPlanIdentifier { get { return _poolInvestorProductPlanIdentifier; } set { _poolInvestorProductPlanIdentifier = value; } }
        private Value<DateTime?> _poolIssueDate;
        public DateTime? PoolIssueDate { get { return _poolIssueDate; } set { _poolIssueDate = value; } }
        private Value<string> _poolIssuerTransferee;
        public string PoolIssuerTransferee { get { return _poolIssuerTransferee; } set { _poolIssuerTransferee = value; } }
        private Value<decimal?> _poolMarginRatePercent;
        public decimal? PoolMarginRatePercent { get { return _poolMarginRatePercent; } set { _poolMarginRatePercent = value; } }
        private Value<DateTime?> _poolMaturityDate;
        public DateTime? PoolMaturityDate { get { return _poolMaturityDate; } set { _poolMaturityDate = value; } }
        private Value<int?> _poolMaturityPeriodCount;
        public int? PoolMaturityPeriodCount { get { return _poolMaturityPeriodCount; } set { _poolMaturityPeriodCount = value; } }
        private Value<decimal?> _poolMaximumAccrualRatePercent;
        public decimal? PoolMaximumAccrualRatePercent { get { return _poolMaximumAccrualRatePercent; } set { _poolMaximumAccrualRatePercent = value; } }
        private Value<decimal?> _poolMinimumAccrualRatePercent;
        public decimal? PoolMinimumAccrualRatePercent { get { return _poolMinimumAccrualRatePercent; } set { _poolMinimumAccrualRatePercent = value; } }
        private Value<string> _poolMortgageType;
        public string PoolMortgageType { get { return _poolMortgageType; } set { _poolMortgageType = value; } }
        private Value<int?> _poolScheduledRemittancePaymentDay;
        public int? PoolScheduledRemittancePaymentDay { get { return _poolScheduledRemittancePaymentDay; } set { _poolScheduledRemittancePaymentDay = value; } }
        private Value<decimal?> _poolSecurityIssueDateInterestRatePercent;
        public decimal? PoolSecurityIssueDateInterestRatePercent { get { return _poolSecurityIssueDateInterestRatePercent; } set { _poolSecurityIssueDateInterestRatePercent = value; } }
        private Value<string> _poolSellerID;
        public string PoolSellerID { get { return _poolSellerID; } set { _poolSellerID = value; } }
        private Value<string> _poolServicerID;
        public string PoolServicerID { get { return _poolServicerID; } set { _poolServicerID = value; } }
        private Value<string> _poolStructureType;
        public string PoolStructureType { get { return _poolStructureType; } set { _poolStructureType = value; } }
        private Value<string> _poolSuffixIdentifier;
        public string PoolSuffixIdentifier { get { return _poolSuffixIdentifier; } set { _poolSuffixIdentifier = value; } }
        private Value<DateTime?> _priceLockDatetime;
        public DateTime? PriceLockDatetime { get { return _priceLockDatetime; } set { _priceLockDatetime = value; } }
        private Value<string> _primaryMIAbsenceReasonType;
        public string PrimaryMIAbsenceReasonType { get { return _primaryMIAbsenceReasonType; } set { _primaryMIAbsenceReasonType = value; } }
        private Value<string> _primaryMIAbsenceReasonTypeOtherDescription;
        public string PrimaryMIAbsenceReasonTypeOtherDescription { get { return _primaryMIAbsenceReasonTypeOtherDescription; } set { _primaryMIAbsenceReasonTypeOtherDescription = value; } }
        private Value<string> _projectAttachmentType;
        public string ProjectAttachmentType { get { return _projectAttachmentType; } set { _projectAttachmentType = value; } }
        private Value<string> _projectDesignType;
        public string ProjectDesignType { get { return _projectDesignType; } set { _projectDesignType = value; } }
        private Value<int?> _projectUnitCount;
        public int? ProjectUnitCount { get { return _projectUnitCount; } set { _projectUnitCount = value; } }
        private Value<DateTime?> _propertyValuationEffectiveDate;
        public DateTime? PropertyValuationEffectiveDate { get { return _propertyValuationEffectiveDate; } set { _propertyValuationEffectiveDate = value; } }
        private Value<string> _propertyValuationMethodType;
        public string PropertyValuationMethodType { get { return _propertyValuationMethodType; } set { _propertyValuationMethodType = value; } }
        private Value<decimal?> _refinanceCashOutAmount;
        public decimal? RefinanceCashOutAmount { get { return _refinanceCashOutAmount; } set { _refinanceCashOutAmount = value; } }
        private Value<string> _refinanceCashOutDeterminationType;
        public string RefinanceCashOutDeterminationType { get { return _refinanceCashOutDeterminationType; } set { _refinanceCashOutDeterminationType = value; } }
        private Value<bool?> _relatedLoanBalloonIndicator;
        public bool? RelatedLoanBalloonIndicator { get { return _relatedLoanBalloonIndicator; } set { _relatedLoanBalloonIndicator = value; } }
        private Value<bool?> _relatedLoanHELOCIndicator;
        public bool? RelatedLoanHELOCIndicator { get { return _relatedLoanHELOCIndicator; } set { _relatedLoanHELOCIndicator = value; } }
        private Value<bool?> _relatedLoanIndicator;
        public bool? RelatedLoanIndicator { get { return _relatedLoanIndicator; } set { _relatedLoanIndicator = value; } }
        private Value<string> _relatedLoanInvestorType;
        public string RelatedLoanInvestorType { get { return _relatedLoanInvestorType; } set { _relatedLoanInvestorType = value; } }
        private Value<int?> _relatedLoanMaturityPeriodCount;
        public int? RelatedLoanMaturityPeriodCount { get { return _relatedLoanMaturityPeriodCount; } set { _relatedLoanMaturityPeriodCount = value; } }
        private Value<DateTime?> _relatedLoanNoteDate;
        public DateTime? RelatedLoanNoteDate { get { return _relatedLoanNoteDate; } set { _relatedLoanNoteDate = value; } }
        private Value<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get { return _relatedLoanScheduledFirstPaymentDate; } set { _relatedLoanScheduledFirstPaymentDate = value; } }
        private Value<DateTime?> _relatedLoanStateDateAtClosing;
        public DateTime? RelatedLoanStateDateAtClosing { get { return _relatedLoanStateDateAtClosing; } set { _relatedLoanStateDateAtClosing = value; } }
        private Value<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get { return _relatedLoanUnpaidPrincipalBalanceAmount; } set { _relatedLoanUnpaidPrincipalBalanceAmount = value; } }
        private Value<bool?> _relocationLoanIndicator;
        public bool? RelocationLoanIndicator { get { return _relocationLoanIndicator; } set { _relocationLoanIndicator = value; } }
        private Value<string> _rEOMarketingPartyType;
        public string REOMarketingPartyType { get { return _rEOMarketingPartyType; } set { _rEOMarketingPartyType = value; } }
        private Value<bool?> _secondLienIsDeliveredIndicator;
        public bool? SecondLienIsDeliveredIndicator { get { return _secondLienIsDeliveredIndicator; } set { _secondLienIsDeliveredIndicator = value; } }
        private Value<decimal?> _securityOriginalSubscriptionAmount;
        public decimal? SecurityOriginalSubscriptionAmount { get { return _securityOriginalSubscriptionAmount; } set { _securityOriginalSubscriptionAmount = value; } }
        private Value<DateTime?> _securityTradeBookEntryDate;
        public DateTime? SecurityTradeBookEntryDate { get { return _securityTradeBookEntryDate; } set { _securityTradeBookEntryDate = value; } }
        private Value<string> _sellerID;
        public string SellerID { get { return _sellerID; } set { _sellerID = value; } }
        private Value<string> _sellerLoanIdentifier;
        public string SellerLoanIdentifier { get { return _sellerLoanIdentifier; } set { _sellerLoanIdentifier = value; } }
        private Value<string> _servicerID;
        public string ServicerID { get { return _servicerID; } set { _servicerID = value; } }
        private Value<string> _servicerLoanIdentifier;
        public string ServicerLoanIdentifier { get { return _servicerLoanIdentifier; } set { _servicerLoanIdentifier = value; } }
        private Value<bool?> _sharedEquityIndicator;
        public bool? SharedEquityIndicator { get { return _sharedEquityIndicator; } set { _sharedEquityIndicator = value; } }
        private Value<bool?> _siteBuiltIndicator;
        public bool? SiteBuiltIndicator { get { return _siteBuiltIndicator; } set { _siteBuiltIndicator = value; } }
        private Value<bool?> _specialFloodHazardAreaIndicator;
        public bool? SpecialFloodHazardAreaIndicator { get { return _specialFloodHazardAreaIndicator; } set { _specialFloodHazardAreaIndicator = value; } }
        private Value<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get { return _subsequentPerChangeMaximumDecreaseRatePercent; } set { _subsequentPerChangeMaximumDecreaseRatePercent = value; } }
        private Value<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get { return _subsequentPerChangeMaximumIncreaseRatePercent; } set { _subsequentPerChangeMaximumIncreaseRatePercent = value; } }
        private Value<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get { return _subsequentPerChangeRateAdjustmentEffectiveDate; } set { _subsequentPerChangeRateAdjustmentEffectiveDate = value; } }
        private Value<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get { return _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; } set { _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = value; } }
        private Value<bool?> _temporaryBuydownIndicator;
        public bool? TemporaryBuydownIndicator { get { return _temporaryBuydownIndicator; } set { _temporaryBuydownIndicator = value; } }
        private Value<int?> _totalMortgagedPropertiesCount;
        public int? TotalMortgagedPropertiesCount { get { return _totalMortgagedPropertiesCount; } set { _totalMortgagedPropertiesCount = value; } }
        private Value<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get { return _unit1SubjectPropertyGrossRentalIncome; } set { _unit1SubjectPropertyGrossRentalIncome = value; } }
        private Value<int?> _unit1TotalBedrooms;
        public int? Unit1TotalBedrooms { get { return _unit1TotalBedrooms; } set { _unit1TotalBedrooms = value; } }
        private Value<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get { return _unit2SubjectPropertyGrossRentalIncome; } set { _unit2SubjectPropertyGrossRentalIncome = value; } }
        private Value<int?> _unit2TotalBedrooms;
        public int? Unit2TotalBedrooms { get { return _unit2TotalBedrooms; } set { _unit2TotalBedrooms = value; } }
        private Value<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get { return _unit3SubjectPropertyGrossRentalIncome; } set { _unit3SubjectPropertyGrossRentalIncome = value; } }
        private Value<int?> _unit3TotalBedrooms;
        public int? Unit3TotalBedrooms { get { return _unit3TotalBedrooms; } set { _unit3TotalBedrooms = value; } }
        private Value<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get { return _unit4SubjectPropertyGrossRentalIncome; } set { _unit4SubjectPropertyGrossRentalIncome = value; } }
        private Value<int?> _unit4TotalBedrooms;
        public int? Unit4TotalBedrooms { get { return _unit4TotalBedrooms; } set { _unit4TotalBedrooms = value; } }
        private Value<decimal?> _uPBAmount;
        public decimal? UPBAmount { get { return _uPBAmount; } set { _uPBAmount = value; } }
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
                var aCHABARoutingAndTransitIdentifier = _aCHABARoutingAndTransitIdentifier; aCHABARoutingAndTransitIdentifier.Clean = value; _aCHABARoutingAndTransitIdentifier = aCHABARoutingAndTransitIdentifier;
                var aCHABARoutingAndTransitNumber = _aCHABARoutingAndTransitNumber; aCHABARoutingAndTransitNumber.Clean = value; _aCHABARoutingAndTransitNumber = aCHABARoutingAndTransitNumber;
                var aCHBankAccountDescription = _aCHBankAccountDescription; aCHBankAccountDescription.Clean = value; _aCHBankAccountDescription = aCHBankAccountDescription;
                var aCHBankAccountIdentifier = _aCHBankAccountIdentifier; aCHBankAccountIdentifier.Clean = value; _aCHBankAccountIdentifier = aCHBankAccountIdentifier;
                var aCHBankAccountPurposeTransitIdentifier = _aCHBankAccountPurposeTransitIdentifier; aCHBankAccountPurposeTransitIdentifier.Clean = value; _aCHBankAccountPurposeTransitIdentifier = aCHBankAccountPurposeTransitIdentifier;
                var aCHBankAccountPurposeType = _aCHBankAccountPurposeType; aCHBankAccountPurposeType.Clean = value; _aCHBankAccountPurposeType = aCHBankAccountPurposeType;
                var aCHInstitutionTelegraphicAbbreviationName = _aCHInstitutionTelegraphicAbbreviationName; aCHInstitutionTelegraphicAbbreviationName.Clean = value; _aCHInstitutionTelegraphicAbbreviationName = aCHInstitutionTelegraphicAbbreviationName;
                var aCHReceiverSubaccountName = _aCHReceiverSubaccountName; aCHReceiverSubaccountName.Clean = value; _aCHReceiverSubaccountName = aCHReceiverSubaccountName;
                var additionalPrincipalAmountIndicator = _additionalPrincipalAmountIndicator; additionalPrincipalAmountIndicator.Clean = value; _additionalPrincipalAmountIndicator = additionalPrincipalAmountIndicator;
                var aggregateLoanCurtailmentAmount = _aggregateLoanCurtailmentAmount; aggregateLoanCurtailmentAmount.Clean = value; _aggregateLoanCurtailmentAmount = aggregateLoanCurtailmentAmount;
                var appraisalIdentifier = _appraisalIdentifier; appraisalIdentifier.Clean = value; _appraisalIdentifier = appraisalIdentifier;
                var attachmentType = _attachmentType; attachmentType.Clean = value; _attachmentType = attachmentType;
                var aVMModelNameType = _aVMModelNameType; aVMModelNameType.Clean = value; _aVMModelNameType = aVMModelNameType;
                var balloonResetIndicator = _balloonResetIndicator; balloonResetIndicator.Clean = value; _balloonResetIndicator = balloonResetIndicator;
                var baseGuarantyFeePercent = _baseGuarantyFeePercent; baseGuarantyFeePercent.Clean = value; _baseGuarantyFeePercent = baseGuarantyFeePercent;
                var bondFinancePool = _bondFinancePool; bondFinancePool.Clean = value; _bondFinancePool = bondFinancePool;
                var bondFinanceProgramName = _bondFinanceProgramName; bondFinanceProgramName.Clean = value; _bondFinanceProgramName = bondFinanceProgramName;
                var bondFinanceProgramType = _bondFinanceProgramType; bondFinanceProgramType.Clean = value; _bondFinanceProgramType = bondFinanceProgramType;
                var borrowerMailToAddressSameasPropertyIndicator = _borrowerMailToAddressSameasPropertyIndicator; borrowerMailToAddressSameasPropertyIndicator.Clean = value; _borrowerMailToAddressSameasPropertyIndicator = borrowerMailToAddressSameasPropertyIndicator;
                var borrowerType = _borrowerType; borrowerType.Clean = value; _borrowerType = borrowerType;
                var capitalizedLoanIndicator = _capitalizedLoanIndicator; capitalizedLoanIndicator.Clean = value; _capitalizedLoanIndicator = capitalizedLoanIndicator;
                var certificateIdentifier = _certificateIdentifier; certificateIdentifier.Clean = value; _certificateIdentifier = certificateIdentifier;
                var certificateMaturityDate = _certificateMaturityDate; certificateMaturityDate.Clean = value; _certificateMaturityDate = certificateMaturityDate;
                var certificatePrincipalBalanceAmount = _certificatePrincipalBalanceAmount; certificatePrincipalBalanceAmount.Clean = value; _certificatePrincipalBalanceAmount = certificatePrincipalBalanceAmount;
                var certificateType = _certificateType; certificateType.Clean = value; _certificateType = certificateType;
                var closingCost2ContributionAmount = _closingCost2ContributionAmount; closingCost2ContributionAmount.Clean = value; _closingCost2ContributionAmount = closingCost2ContributionAmount;
                var closingCost2FundsType = _closingCost2FundsType; closingCost2FundsType.Clean = value; _closingCost2FundsType = closingCost2FundsType;
                var closingCost2FundsTypeOtherDescription = _closingCost2FundsTypeOtherDescription; closingCost2FundsTypeOtherDescription.Clean = value; _closingCost2FundsTypeOtherDescription = closingCost2FundsTypeOtherDescription;
                var closingCost2SourceType = _closingCost2SourceType; closingCost2SourceType.Clean = value; _closingCost2SourceType = closingCost2SourceType;
                var closingCost2SourceTypeOtherDescription = _closingCost2SourceTypeOtherDescription; closingCost2SourceTypeOtherDescription.Clean = value; _closingCost2SourceTypeOtherDescription = closingCost2SourceTypeOtherDescription;
                var closingCost3ContributionAmount = _closingCost3ContributionAmount; closingCost3ContributionAmount.Clean = value; _closingCost3ContributionAmount = closingCost3ContributionAmount;
                var closingCost3FundsType = _closingCost3FundsType; closingCost3FundsType.Clean = value; _closingCost3FundsType = closingCost3FundsType;
                var closingCost3FundsTypeOtherDescription = _closingCost3FundsTypeOtherDescription; closingCost3FundsTypeOtherDescription.Clean = value; _closingCost3FundsTypeOtherDescription = closingCost3FundsTypeOtherDescription;
                var closingCost3SourceType = _closingCost3SourceType; closingCost3SourceType.Clean = value; _closingCost3SourceType = closingCost3SourceType;
                var closingCost3SourceTypeOtherDescription = _closingCost3SourceTypeOtherDescription; closingCost3SourceTypeOtherDescription.Clean = value; _closingCost3SourceTypeOtherDescription = closingCost3SourceTypeOtherDescription;
                var closingCost4ContributionAmount = _closingCost4ContributionAmount; closingCost4ContributionAmount.Clean = value; _closingCost4ContributionAmount = closingCost4ContributionAmount;
                var closingCost4FundsType = _closingCost4FundsType; closingCost4FundsType.Clean = value; _closingCost4FundsType = closingCost4FundsType;
                var closingCost4FundsTypeOtherDescription = _closingCost4FundsTypeOtherDescription; closingCost4FundsTypeOtherDescription.Clean = value; _closingCost4FundsTypeOtherDescription = closingCost4FundsTypeOtherDescription;
                var closingCost4SourceType = _closingCost4SourceType; closingCost4SourceType.Clean = value; _closingCost4SourceType = closingCost4SourceType;
                var closingCost4SourceTypeOtherDescription = _closingCost4SourceTypeOtherDescription; closingCost4SourceTypeOtherDescription.Clean = value; _closingCost4SourceTypeOtherDescription = closingCost4SourceTypeOtherDescription;
                var closingCostContributionAmount = _closingCostContributionAmount; closingCostContributionAmount.Clean = value; _closingCostContributionAmount = closingCostContributionAmount;
                var closingCostFundsType = _closingCostFundsType; closingCostFundsType.Clean = value; _closingCostFundsType = closingCostFundsType;
                var closingCostFundsTypeOtherDescription = _closingCostFundsTypeOtherDescription; closingCostFundsTypeOtherDescription.Clean = value; _closingCostFundsTypeOtherDescription = closingCostFundsTypeOtherDescription;
                var closingCostSourceType = _closingCostSourceType; closingCostSourceType.Clean = value; _closingCostSourceType = closingCostSourceType;
                var closingCostSourceTypeOtherDescription = _closingCostSourceTypeOtherDescription; closingCostSourceTypeOtherDescription.Clean = value; _closingCostSourceTypeOtherDescription = closingCostSourceTypeOtherDescription;
                var coBorrowerCountryCode = _coBorrowerCountryCode; coBorrowerCountryCode.Clean = value; _coBorrowerCountryCode = coBorrowerCountryCode;
                var coBorrowerMailToAddressSameasPropertyIndicator = _coBorrowerMailToAddressSameasPropertyIndicator; coBorrowerMailToAddressSameasPropertyIndicator.Clean = value; _coBorrowerMailToAddressSameasPropertyIndicator = coBorrowerMailToAddressSameasPropertyIndicator;
                var coBorrowerType = _coBorrowerType; coBorrowerType.Clean = value; _coBorrowerType = coBorrowerType;
                var condominiumProjectStatusType = _condominiumProjectStatusType; condominiumProjectStatusType.Clean = value; _condominiumProjectStatusType = condominiumProjectStatusType;
                var constructionMethodType = _constructionMethodType; constructionMethodType.Clean = value; _constructionMethodType = constructionMethodType;
                var constructionMethodTypeOtherDescription = _constructionMethodTypeOtherDescription; constructionMethodTypeOtherDescription.Clean = value; _constructionMethodTypeOtherDescription = constructionMethodTypeOtherDescription;
                var constructionToPermanentClosingFeatureType = _constructionToPermanentClosingFeatureType; constructionToPermanentClosingFeatureType.Clean = value; _constructionToPermanentClosingFeatureType = constructionToPermanentClosingFeatureType;
                var constructionToPermanentClosingType = _constructionToPermanentClosingType; constructionToPermanentClosingType.Clean = value; _constructionToPermanentClosingType = constructionToPermanentClosingType;
                var convertibleStatusType = _convertibleStatusType; convertibleStatusType.Clean = value; _convertibleStatusType = convertibleStatusType;
                var counselingFormatType = _counselingFormatType; counselingFormatType.Clean = value; _counselingFormatType = counselingFormatType;
                var counselingFormatTypeOtherDescription = _counselingFormatTypeOtherDescription; counselingFormatTypeOtherDescription.Clean = value; _counselingFormatTypeOtherDescription = counselingFormatTypeOtherDescription;
                var counselTypeOther = _counselTypeOther; counselTypeOther.Clean = value; _counselTypeOther = counselTypeOther;
                var countryCode = _countryCode; countryCode.Clean = value; _countryCode = countryCode;
                var creditScoreImpairmentType = _creditScoreImpairmentType; creditScoreImpairmentType.Clean = value; _creditScoreImpairmentType = creditScoreImpairmentType;
                var currentAccruedInterestAmount = _currentAccruedInterestAmount; currentAccruedInterestAmount.Clean = value; _currentAccruedInterestAmount = currentAccruedInterestAmount;
                var delinquentPaymentsOverPastTwelveMonthsCount = _delinquentPaymentsOverPastTwelveMonthsCount; delinquentPaymentsOverPastTwelveMonthsCount.Clean = value; _delinquentPaymentsOverPastTwelveMonthsCount = delinquentPaymentsOverPastTwelveMonthsCount;
                var documentCustodianID = _documentCustodianID; documentCustodianID.Clean = value; _documentCustodianID = documentCustodianID;
                var documentRequiredIndicator = _documentRequiredIndicator; documentRequiredIndicator.Clean = value; _documentRequiredIndicator = documentRequiredIndicator;
                var documentSubmissionIndicator = _documentSubmissionIndicator; documentSubmissionIndicator.Clean = value; _documentSubmissionIndicator = documentSubmissionIndicator;
                var downPaymentFundsType = _downPaymentFundsType; downPaymentFundsType.Clean = value; _downPaymentFundsType = downPaymentFundsType;
                var downPaymentOtherTypeDescription = _downPaymentOtherTypeDescription; downPaymentOtherTypeDescription.Clean = value; _downPaymentOtherTypeDescription = downPaymentOtherTypeDescription;
                var downPaymentSourceType = _downPaymentSourceType; downPaymentSourceType.Clean = value; _downPaymentSourceType = downPaymentSourceType;
                var downPaymentSourceTypeOtherDescription = _downPaymentSourceTypeOtherDescription; downPaymentSourceTypeOtherDescription.Clean = value; _downPaymentSourceTypeOtherDescription = downPaymentSourceTypeOtherDescription;
                var fannieARMIndexType = _fannieARMIndexType; fannieARMIndexType.Clean = value; _fannieARMIndexType = fannieARMIndexType;
                var fannieAutoUWDec = _fannieAutoUWDec; fannieAutoUWDec.Clean = value; _fannieAutoUWDec = fannieAutoUWDec;
                var fannieBLTV = _fannieBLTV; fannieBLTV.Clean = value; _fannieBLTV = fannieBLTV;
                var fannieBorrowerFirstName = _fannieBorrowerFirstName; fannieBorrowerFirstName.Clean = value; _fannieBorrowerFirstName = fannieBorrowerFirstName;
                var fannieBorrowerMiddleName = _fannieBorrowerMiddleName; fannieBorrowerMiddleName.Clean = value; _fannieBorrowerMiddleName = fannieBorrowerMiddleName;
                var fannieBuydownContributer = _fannieBuydownContributer; fannieBuydownContributer.Clean = value; _fannieBuydownContributer = fannieBuydownContributer;
                var fannieCLTV = _fannieCLTV; fannieCLTV.Clean = value; _fannieCLTV = fannieCLTV;
                var fannieCoBorrowerFirstName = _fannieCoBorrowerFirstName; fannieCoBorrowerFirstName.Clean = value; _fannieCoBorrowerFirstName = fannieCoBorrowerFirstName;
                var fannieCoBorrowerMiddleName = _fannieCoBorrowerMiddleName; fannieCoBorrowerMiddleName.Clean = value; _fannieCoBorrowerMiddleName = fannieCoBorrowerMiddleName;
                var fannieCreditScoreProviderName = _fannieCreditScoreProviderName; fannieCreditScoreProviderName.Clean = value; _fannieCreditScoreProviderName = fannieCreditScoreProviderName;
                var fannieFloodSpecialFeatureCode = _fannieFloodSpecialFeatureCode; fannieFloodSpecialFeatureCode.Clean = value; _fannieFloodSpecialFeatureCode = fannieFloodSpecialFeatureCode;
                var fannieHCLTV = _fannieHCLTV; fannieHCLTV.Clean = value; _fannieHCLTV = fannieHCLTV;
                var fannieInvestorOwnershipPercent = _fannieInvestorOwnershipPercent; fannieInvestorOwnershipPercent.Clean = value; _fannieInvestorOwnershipPercent = fannieInvestorOwnershipPercent;
                var fannieLegalEntityType = _fannieLegalEntityType; fannieLegalEntityType.Clean = value; _fannieLegalEntityType = fannieLegalEntityType;
                var fannieLegalEntityTypeOther = _fannieLegalEntityTypeOther; fannieLegalEntityTypeOther.Clean = value; _fannieLegalEntityTypeOther = fannieLegalEntityTypeOther;
                var fannieLenderPaidMIInterestRateAdjustmentPercent = _fannieLenderPaidMIInterestRateAdjustmentPercent; fannieLenderPaidMIInterestRateAdjustmentPercent.Clean = value; _fannieLenderPaidMIInterestRateAdjustmentPercent = fannieLenderPaidMIInterestRateAdjustmentPercent;
                var fannieLoanProgramIdentifier = _fannieLoanProgramIdentifier; fannieLoanProgramIdentifier.Clean = value; _fannieLoanProgramIdentifier = fannieLoanProgramIdentifier;
                var fannieLTV = _fannieLTV; fannieLTV.Clean = value; _fannieLTV = fannieLTV;
                var fannieMICompanyNameTypeOther = _fannieMICompanyNameTypeOther; fannieMICompanyNameTypeOther.Clean = value; _fannieMICompanyNameTypeOther = fannieMICompanyNameTypeOther;
                var fannieMICoveragePercent = _fannieMICoveragePercent; fannieMICoveragePercent.Clean = value; _fannieMICoveragePercent = fannieMICoveragePercent;
                var fanniePoolOwnershipPercent = _fanniePoolOwnershipPercent; fanniePoolOwnershipPercent.Clean = value; _fanniePoolOwnershipPercent = fanniePoolOwnershipPercent;
                var fannieProjectClassificationType = _fannieProjectClassificationType; fannieProjectClassificationType.Clean = value; _fannieProjectClassificationType = fannieProjectClassificationType;
                var fanniePropertyFormType = _fanniePropertyFormType; fanniePropertyFormType.Clean = value; _fanniePropertyFormType = fanniePropertyFormType;
                var fannieRateSpread = _fannieRateSpread; fannieRateSpread.Clean = value; _fannieRateSpread = fannieRateSpread;
                var fannieRefinanceType = _fannieRefinanceType; fannieRefinanceType.Clean = value; _fannieRefinanceType = fannieRefinanceType;
                var fannieRelatedInvestorLoanID = _fannieRelatedInvestorLoanID; fannieRelatedInvestorLoanID.Clean = value; _fannieRelatedInvestorLoanID = fannieRelatedInvestorLoanID;
                var fannieRelatedLoanAmortizationType = _fannieRelatedLoanAmortizationType; fannieRelatedLoanAmortizationType.Clean = value; _fannieRelatedLoanAmortizationType = fannieRelatedLoanAmortizationType;
                var fannieRelatedLoanLienPosition = _fannieRelatedLoanLienPosition; fannieRelatedLoanLienPosition.Clean = value; _fannieRelatedLoanLienPosition = fannieRelatedLoanLienPosition;
                var fannieRelatedLoanType = _fannieRelatedLoanType; fannieRelatedLoanType.Clean = value; _fannieRelatedLoanType = fannieRelatedLoanType;
                var fannieSectionOfAct = _fannieSectionOfAct; fannieSectionOfAct.Clean = value; _fannieSectionOfAct = fannieSectionOfAct;
                var fannieTLTV = _fannieTLTV; fannieTLTV.Clean = value; _fannieTLTV = fannieTLTV;
                var fannieTrustName = _fannieTrustName; fannieTrustName.Clean = value; _fannieTrustName = fannieTrustName;
                var fannnieMortgageType = _fannnieMortgageType; fannnieMortgageType.Clean = value; _fannnieMortgageType = fannnieMortgageType;
                var financedUnitCount = _financedUnitCount; financedUnitCount.Clean = value; _financedUnitCount = financedUnitCount;
                var firstRateChangePaymentEffectiveDate = _firstRateChangePaymentEffectiveDate; firstRateChangePaymentEffectiveDate.Clean = value; _firstRateChangePaymentEffectiveDate = firstRateChangePaymentEffectiveDate;
                var fNMHomeImprovementProductType = _fNMHomeImprovementProductType; fNMHomeImprovementProductType.Clean = value; _fNMHomeImprovementProductType = fNMHomeImprovementProductType;
                var freddieARMIndexType = _freddieARMIndexType; freddieARMIndexType.Clean = value; _freddieARMIndexType = freddieARMIndexType;
                var freddieAutoUWDec = _freddieAutoUWDec; freddieAutoUWDec.Clean = value; _freddieAutoUWDec = freddieAutoUWDec;
                var freddieAVMModelNameTypeExpl = _freddieAVMModelNameTypeExpl; freddieAVMModelNameTypeExpl.Clean = value; _freddieAVMModelNameTypeExpl = freddieAVMModelNameTypeExpl;
                var freddieBorrowerAlienStatus = _freddieBorrowerAlienStatus; freddieBorrowerAlienStatus.Clean = value; _freddieBorrowerAlienStatus = freddieBorrowerAlienStatus;
                var freddieCoBorrowerAlienStatus = _freddieCoBorrowerAlienStatus; freddieCoBorrowerAlienStatus.Clean = value; _freddieCoBorrowerAlienStatus = freddieCoBorrowerAlienStatus;
                var freddieCreditScoreProviderName = _freddieCreditScoreProviderName; freddieCreditScoreProviderName.Clean = value; _freddieCreditScoreProviderName = freddieCreditScoreProviderName;
                var freddieDownPaymentType = _freddieDownPaymentType; freddieDownPaymentType.Clean = value; _freddieDownPaymentType = freddieDownPaymentType;
                var freddieDownPmt2SourceType = _freddieDownPmt2SourceType; freddieDownPmt2SourceType.Clean = value; _freddieDownPmt2SourceType = freddieDownPmt2SourceType;
                var freddieDownPmt2SourceTypeExpl = _freddieDownPmt2SourceTypeExpl; freddieDownPmt2SourceTypeExpl.Clean = value; _freddieDownPmt2SourceTypeExpl = freddieDownPmt2SourceTypeExpl;
                var freddieDownPmt2Type = _freddieDownPmt2Type; freddieDownPmt2Type.Clean = value; _freddieDownPmt2Type = freddieDownPmt2Type;
                var freddieDownPmt2TypeExpl = _freddieDownPmt2TypeExpl; freddieDownPmt2TypeExpl.Clean = value; _freddieDownPmt2TypeExpl = freddieDownPmt2TypeExpl;
                var freddieDownPmt3Amt = _freddieDownPmt3Amt; freddieDownPmt3Amt.Clean = value; _freddieDownPmt3Amt = freddieDownPmt3Amt;
                var freddieDownPmt3SourceType = _freddieDownPmt3SourceType; freddieDownPmt3SourceType.Clean = value; _freddieDownPmt3SourceType = freddieDownPmt3SourceType;
                var freddieDownPmt3SourceTypeExpl = _freddieDownPmt3SourceTypeExpl; freddieDownPmt3SourceTypeExpl.Clean = value; _freddieDownPmt3SourceTypeExpl = freddieDownPmt3SourceTypeExpl;
                var freddieDownPmt3Type = _freddieDownPmt3Type; freddieDownPmt3Type.Clean = value; _freddieDownPmt3Type = freddieDownPmt3Type;
                var freddieDownPmt3TypeExpl = _freddieDownPmt3TypeExpl; freddieDownPmt3TypeExpl.Clean = value; _freddieDownPmt3TypeExpl = freddieDownPmt3TypeExpl;
                var freddieDownPmt4Amt = _freddieDownPmt4Amt; freddieDownPmt4Amt.Clean = value; _freddieDownPmt4Amt = freddieDownPmt4Amt;
                var freddieDownPmt4SourceType = _freddieDownPmt4SourceType; freddieDownPmt4SourceType.Clean = value; _freddieDownPmt4SourceType = freddieDownPmt4SourceType;
                var freddieDownPmt4SourceTypeExpl = _freddieDownPmt4SourceTypeExpl; freddieDownPmt4SourceTypeExpl.Clean = value; _freddieDownPmt4SourceTypeExpl = freddieDownPmt4SourceTypeExpl;
                var freddieDownPmt4Type = _freddieDownPmt4Type; freddieDownPmt4Type.Clean = value; _freddieDownPmt4Type = freddieDownPmt4Type;
                var freddieDownPmt4TypeExpl = _freddieDownPmt4TypeExpl; freddieDownPmt4TypeExpl.Clean = value; _freddieDownPmt4TypeExpl = freddieDownPmt4TypeExpl;
                var freddieExplanationOfDownPayment = _freddieExplanationOfDownPayment; freddieExplanationOfDownPayment.Clean = value; _freddieExplanationOfDownPayment = freddieExplanationOfDownPayment;
                var freddieInvestorCollateralProgramIdentifier = _freddieInvestorCollateralProgramIdentifier; freddieInvestorCollateralProgramIdentifier.Clean = value; _freddieInvestorCollateralProgramIdentifier = freddieInvestorCollateralProgramIdentifier;
                var freddieInvestorFeatureIdentifier = _freddieInvestorFeatureIdentifier; freddieInvestorFeatureIdentifier.Clean = value; _freddieInvestorFeatureIdentifier = freddieInvestorFeatureIdentifier;
                var freddieLegalEntityType = _freddieLegalEntityType; freddieLegalEntityType.Clean = value; _freddieLegalEntityType = freddieLegalEntityType;
                var freddieLegalEntityTypeOther = _freddieLegalEntityTypeOther; freddieLegalEntityTypeOther.Clean = value; _freddieLegalEntityTypeOther = freddieLegalEntityTypeOther;
                var freddieLoanProgramIdentifier = _freddieLoanProgramIdentifier; freddieLoanProgramIdentifier.Clean = value; _freddieLoanProgramIdentifier = freddieLoanProgramIdentifier;
                var freddieLoanTypePublicAndIndianHousingIndicator = _freddieLoanTypePublicAndIndianHousingIndicator; freddieLoanTypePublicAndIndianHousingIndicator.Clean = value; _freddieLoanTypePublicAndIndianHousingIndicator = freddieLoanTypePublicAndIndianHousingIndicator;
                var freddieMICompanyNameTypeOther = _freddieMICompanyNameTypeOther; freddieMICompanyNameTypeOther.Clean = value; _freddieMICompanyNameTypeOther = freddieMICompanyNameTypeOther;
                var freddieMortgageType = _freddieMortgageType; freddieMortgageType.Clean = value; _freddieMortgageType = freddieMortgageType;
                var freddieProjectClassificationType = _freddieProjectClassificationType; freddieProjectClassificationType.Clean = value; _freddieProjectClassificationType = freddieProjectClassificationType;
                var freddiePropertyFormType = _freddiePropertyFormType; freddiePropertyFormType.Clean = value; _freddiePropertyFormType = freddiePropertyFormType;
                var freddieRefinanceCashOutDeterminationType = _freddieRefinanceCashOutDeterminationType; freddieRefinanceCashOutDeterminationType.Clean = value; _freddieRefinanceCashOutDeterminationType = freddieRefinanceCashOutDeterminationType;
                var freddieRefinanceType = _freddieRefinanceType; freddieRefinanceType.Clean = value; _freddieRefinanceType = freddieRefinanceType;
                var freddieRelatedClosedEndSecondIndicator = _freddieRelatedClosedEndSecondIndicator; freddieRelatedClosedEndSecondIndicator.Clean = value; _freddieRelatedClosedEndSecondIndicator = freddieRelatedClosedEndSecondIndicator;
                var freddieRelatedInvestorLoanID = _freddieRelatedInvestorLoanID; freddieRelatedInvestorLoanID.Clean = value; _freddieRelatedInvestorLoanID = freddieRelatedInvestorLoanID;
                var freddieRelatedLoanInvestorType = _freddieRelatedLoanInvestorType; freddieRelatedLoanInvestorType.Clean = value; _freddieRelatedLoanInvestorType = freddieRelatedLoanInvestorType;
                var freddieRelatedLoanLienPosition = _freddieRelatedLoanLienPosition; freddieRelatedLoanLienPosition.Clean = value; _freddieRelatedLoanLienPosition = freddieRelatedLoanLienPosition;
                var freddieRelatedLoanType = _freddieRelatedLoanType; freddieRelatedLoanType.Clean = value; _freddieRelatedLoanType = freddieRelatedLoanType;
                var freddieSectionOfAct = _freddieSectionOfAct; freddieSectionOfAct.Clean = value; _freddieSectionOfAct = freddieSectionOfAct;
                var freddieUnderwritingTypeOther = _freddieUnderwritingTypeOther; freddieUnderwritingTypeOther.Clean = value; _freddieUnderwritingTypeOther = freddieUnderwritingTypeOther;
                var ginnieConstructionMethodType = _ginnieConstructionMethodType; ginnieConstructionMethodType.Clean = value; _ginnieConstructionMethodType = ginnieConstructionMethodType;
                var ginnieGovernmentAnnualPremiumAmount = _ginnieGovernmentAnnualPremiumAmount; ginnieGovernmentAnnualPremiumAmount.Clean = value; _ginnieGovernmentAnnualPremiumAmount = ginnieGovernmentAnnualPremiumAmount;
                var ginnieMortgageType = _ginnieMortgageType; ginnieMortgageType.Clean = value; _ginnieMortgageType = ginnieMortgageType;
                var ginnieOtherConstructionMethodType = _ginnieOtherConstructionMethodType; ginnieOtherConstructionMethodType.Clean = value; _ginnieOtherConstructionMethodType = ginnieOtherConstructionMethodType;
                var governmentAnnualPremiumPercent = _governmentAnnualPremiumPercent; governmentAnnualPremiumPercent.Clean = value; _governmentAnnualPremiumPercent = governmentAnnualPremiumPercent;
                var governmentRefinanceType = _governmentRefinanceType; governmentRefinanceType.Clean = value; _governmentRefinanceType = governmentRefinanceType;
                var governmentUpfrontPremiumAmount = _governmentUpfrontPremiumAmount; governmentUpfrontPremiumAmount.Clean = value; _governmentUpfrontPremiumAmount = governmentUpfrontPremiumAmount;
                var governmentUpfrontPremiumPercent = _governmentUpfrontPremiumPercent; governmentUpfrontPremiumPercent.Clean = value; _governmentUpfrontPremiumPercent = governmentUpfrontPremiumPercent;
                var gSEProjectType = _gSEProjectType; gSEProjectType.Clean = value; _gSEProjectType = gSEProjectType;
                var guaranteeFeeAddOnIndicator = _guaranteeFeeAddOnIndicator; guaranteeFeeAddOnIndicator.Clean = value; _guaranteeFeeAddOnIndicator = guaranteeFeeAddOnIndicator;
                var guarantyFeeAfterAlternatePaymentMethodPercent = _guarantyFeeAfterAlternatePaymentMethodPercent; guarantyFeeAfterAlternatePaymentMethodPercent.Clean = value; _guarantyFeeAfterAlternatePaymentMethodPercent = guarantyFeeAfterAlternatePaymentMethodPercent;
                var guarantyFeePercent = _guarantyFeePercent; guarantyFeePercent.Clean = value; _guarantyFeePercent = guarantyFeePercent;
                var guarantyPercent = _guarantyPercent; guarantyPercent.Clean = value; _guarantyPercent = guarantyPercent;
                var id = _id; id.Clean = value; _id = id;
                var indexType = _indexType; indexType.Clean = value; _indexType = indexType;
                var initialFixedPeriodEffectiveMonthsCount = _initialFixedPeriodEffectiveMonthsCount; initialFixedPeriodEffectiveMonthsCount.Clean = value; _initialFixedPeriodEffectiveMonthsCount = initialFixedPeriodEffectiveMonthsCount;
                var interestAccrualType = _interestAccrualType; interestAccrualType.Clean = value; _interestAccrualType = interestAccrualType;
                var interestAndPaymentAdjustmentIndexLeadDaysCount = _interestAndPaymentAdjustmentIndexLeadDaysCount; interestAndPaymentAdjustmentIndexLeadDaysCount.Clean = value; _interestAndPaymentAdjustmentIndexLeadDaysCount = interestAndPaymentAdjustmentIndexLeadDaysCount;
                var interestCalculationBasisType = _interestCalculationBasisType; interestCalculationBasisType.Clean = value; _interestCalculationBasisType = interestCalculationBasisType;
                var interestCalculationEffectiveMonthsCount = _interestCalculationEffectiveMonthsCount; interestCalculationEffectiveMonthsCount.Clean = value; _interestCalculationEffectiveMonthsCount = interestCalculationEffectiveMonthsCount;
                var interestCalculationType = _interestCalculationType; interestCalculationType.Clean = value; _interestCalculationType = interestCalculationType;
                var investorCollateralProgramIdentifier = _investorCollateralProgramIdentifier; investorCollateralProgramIdentifier.Clean = value; _investorCollateralProgramIdentifier = investorCollateralProgramIdentifier;
                var investorCommitmentIdentifier = _investorCommitmentIdentifier; investorCommitmentIdentifier.Clean = value; _investorCommitmentIdentifier = investorCommitmentIdentifier;
                var investorFeatureIdentifier = _investorFeatureIdentifier; investorFeatureIdentifier.Clean = value; _investorFeatureIdentifier = investorFeatureIdentifier;
                var investorFeatureIdPool = _investorFeatureIdPool; investorFeatureIdPool.Clean = value; _investorFeatureIdPool = investorFeatureIdPool;
                var investorOwnershipPercent = _investorOwnershipPercent; investorOwnershipPercent.Clean = value; _investorOwnershipPercent = investorOwnershipPercent;
                var investorProductPlanIdentifier = _investorProductPlanIdentifier; investorProductPlanIdentifier.Clean = value; _investorProductPlanIdentifier = investorProductPlanIdentifier;
                var investorRemittanceDay = _investorRemittanceDay; investorRemittanceDay.Clean = value; _investorRemittanceDay = investorRemittanceDay;
                var investorRemittanceType = _investorRemittanceType; investorRemittanceType.Clean = value; _investorRemittanceType = investorRemittanceType;
                var issuerIdentifier = _issuerIdentifier; issuerIdentifier.Clean = value; _issuerIdentifier = issuerIdentifier;
                var lastPaidInstallmentDueDate = _lastPaidInstallmentDueDate; lastPaidInstallmentDueDate.Clean = value; _lastPaidInstallmentDueDate = lastPaidInstallmentDueDate;
                var lastPaymentReceivedDate = _lastPaymentReceivedDate; lastPaymentReceivedDate.Clean = value; _lastPaymentReceivedDate = lastPaymentReceivedDate;
                var latestConversionEffectiveDate = _latestConversionEffectiveDate; latestConversionEffectiveDate.Clean = value; _latestConversionEffectiveDate = latestConversionEffectiveDate;
                var lenderPaidMIInterestRateAdjustmentPercent = _lenderPaidMIInterestRateAdjustmentPercent; lenderPaidMIInterestRateAdjustmentPercent.Clean = value; _lenderPaidMIInterestRateAdjustmentPercent = lenderPaidMIInterestRateAdjustmentPercent;
                var lendersDeliveryDate = _lendersDeliveryDate; lendersDeliveryDate.Clean = value; _lendersDeliveryDate = lendersDeliveryDate;
                var loanAcquisitionScheduledUPBAmount = _loanAcquisitionScheduledUPBAmount; loanAcquisitionScheduledUPBAmount.Clean = value; _loanAcquisitionScheduledUPBAmount = loanAcquisitionScheduledUPBAmount;
                var loanAmortizationMaximumTermMonthsCount = _loanAmortizationMaximumTermMonthsCount; loanAmortizationMaximumTermMonthsCount.Clean = value; _loanAmortizationMaximumTermMonthsCount = loanAmortizationMaximumTermMonthsCount;
                var loanBuyupBuydownBasisPointNumber = _loanBuyupBuydownBasisPointNumber; loanBuyupBuydownBasisPointNumber.Clean = value; _loanBuyupBuydownBasisPointNumber = loanBuyupBuydownBasisPointNumber;
                var loanBuyupBuydownType = _loanBuyupBuydownType; loanBuyupBuydownType.Clean = value; _loanBuyupBuydownType = loanBuyupBuydownType;
                var loanDefaultLossPartyType = _loanDefaultLossPartyType; loanDefaultLossPartyType.Clean = value; _loanDefaultLossPartyType = loanDefaultLossPartyType;
                var loanDeliveredThroughServicingReleasedProcessIndicator = _loanDeliveredThroughServicingReleasedProcessIndicator; loanDeliveredThroughServicingReleasedProcessIndicator.Clean = value; _loanDeliveredThroughServicingReleasedProcessIndicator = loanDeliveredThroughServicingReleasedProcessIndicator;
                var loanIdentifierValueType = _loanIdentifierValueType; loanIdentifierValueType.Clean = value; _loanIdentifierValueType = loanIdentifierValueType;
                var loanInterestAccrualStartDate = _loanInterestAccrualStartDate; loanInterestAccrualStartDate.Clean = value; _loanInterestAccrualStartDate = loanInterestAccrualStartDate;
                var loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Clean = value; _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
                var loanLevelCreditScoreSelectionMethodType = _loanLevelCreditScoreSelectionMethodType; loanLevelCreditScoreSelectionMethodType.Clean = value; _loanLevelCreditScoreSelectionMethodType = loanLevelCreditScoreSelectionMethodType;
                var loanLevelCreditScoreValue = _loanLevelCreditScoreValue; loanLevelCreditScoreValue.Clean = value; _loanLevelCreditScoreValue = loanLevelCreditScoreValue;
                var loanModificationEffectiveDate = _loanModificationEffectiveDate; loanModificationEffectiveDate.Clean = value; _loanModificationEffectiveDate = loanModificationEffectiveDate;
                var loanStateDate = _loanStateDate; loanStateDate.Clean = value; _loanStateDate = loanStateDate;
                var manufacturedHomeWidthType = _manufacturedHomeWidthType; manufacturedHomeWidthType.Clean = value; _manufacturedHomeWidthType = manufacturedHomeWidthType;
                var mBSWeightedMarginIndicator = _mBSWeightedMarginIndicator; mBSWeightedMarginIndicator.Clean = value; _mBSWeightedMarginIndicator = mBSWeightedMarginIndicator;
                var mERSOriginalMortgageeOfRecordIndicator = _mERSOriginalMortgageeOfRecordIndicator; mERSOriginalMortgageeOfRecordIndicator.Clean = value; _mERSOriginalMortgageeOfRecordIndicator = mERSOriginalMortgageeOfRecordIndicator;
                var mICompanyNameType = _mICompanyNameType; mICompanyNameType.Clean = value; _mICompanyNameType = mICompanyNameType;
                var mIPremiumSourceType = _mIPremiumSourceType; mIPremiumSourceType.Clean = value; _mIPremiumSourceType = mIPremiumSourceType;
                var monetaryEventAppliedDate = _monetaryEventAppliedDate; monetaryEventAppliedDate.Clean = value; _monetaryEventAppliedDate = monetaryEventAppliedDate;
                var monetaryEventGrossPrincipalAmount = _monetaryEventGrossPrincipalAmount; monetaryEventGrossPrincipalAmount.Clean = value; _monetaryEventGrossPrincipalAmount = monetaryEventGrossPrincipalAmount;
                var monetaryEventType = _monetaryEventType; monetaryEventType.Clean = value; _monetaryEventType = monetaryEventType;
                var mortgageBackedSecurityIndicator = _mortgageBackedSecurityIndicator; mortgageBackedSecurityIndicator.Clean = value; _mortgageBackedSecurityIndicator = mortgageBackedSecurityIndicator;
                var mortgageModificationIndicator = _mortgageModificationIndicator; mortgageModificationIndicator.Clean = value; _mortgageModificationIndicator = mortgageModificationIndicator;
                var mortgageOriginator = _mortgageOriginator; mortgageOriginator.Clean = value; _mortgageOriginator = mortgageOriginator;
                var mortgageProgramType = _mortgageProgramType; mortgageProgramType.Clean = value; _mortgageProgramType = mortgageProgramType;
                var multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Clean = value; _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
                var nextRateAdjustmentEffectiveDate = _nextRateAdjustmentEffectiveDate; nextRateAdjustmentEffectiveDate.Clean = value; _nextRateAdjustmentEffectiveDate = nextRateAdjustmentEffectiveDate;
                var notePayToName = _notePayToName; notePayToName.Clean = value; _notePayToName = notePayToName;
                var numberOfUnitsSold = _numberOfUnitsSold; numberOfUnitsSold.Clean = value; _numberOfUnitsSold = numberOfUnitsSold;
                var otherDownPaymentFundsType = _otherDownPaymentFundsType; otherDownPaymentFundsType.Clean = value; _otherDownPaymentFundsType = otherDownPaymentFundsType;
                var otherFundsCollectedAtClosingAmount = _otherFundsCollectedAtClosingAmount; otherFundsCollectedAtClosingAmount.Clean = value; _otherFundsCollectedAtClosingAmount = otherFundsCollectedAtClosingAmount;
                var otherFundsCollectedAtClosingType = _otherFundsCollectedAtClosingType; otherFundsCollectedAtClosingType.Clean = value; _otherFundsCollectedAtClosingType = otherFundsCollectedAtClosingType;
                var payeeID = _payeeID; payeeID.Clean = value; _payeeID = payeeID;
                var paymentBillingStatementLeadDaysCount = _paymentBillingStatementLeadDaysCount; paymentBillingStatementLeadDaysCount.Clean = value; _paymentBillingStatementLeadDaysCount = paymentBillingStatementLeadDaysCount;
                var perChangeMaximumDecreaseRatePercent = _perChangeMaximumDecreaseRatePercent; perChangeMaximumDecreaseRatePercent.Clean = value; _perChangeMaximumDecreaseRatePercent = perChangeMaximumDecreaseRatePercent;
                var perChangeMaximumIncreaseRatePercent = _perChangeMaximumIncreaseRatePercent; perChangeMaximumIncreaseRatePercent.Clean = value; _perChangeMaximumIncreaseRatePercent = perChangeMaximumIncreaseRatePercent;
                var perChangePrincipalAndInterestPaymentAdjustmentPercent = _perChangePrincipalAndInterestPaymentAdjustmentPercent; perChangePrincipalAndInterestPaymentAdjustmentPercent.Clean = value; _perChangePrincipalAndInterestPaymentAdjustmentPercent = perChangePrincipalAndInterestPaymentAdjustmentPercent;
                var perChangeRateAdjustmentEffectiveDate = _perChangeRateAdjustmentEffectiveDate; perChangeRateAdjustmentEffectiveDate.Clean = value; _perChangeRateAdjustmentEffectiveDate = perChangeRateAdjustmentEffectiveDate;
                var perChangeRateAdjustmentFrequencyMonthsCount = _perChangeRateAdjustmentFrequencyMonthsCount; perChangeRateAdjustmentFrequencyMonthsCount.Clean = value; _perChangeRateAdjustmentFrequencyMonthsCount = perChangeRateAdjustmentFrequencyMonthsCount;
                var poolAccrualRateStructureType = _poolAccrualRateStructureType; poolAccrualRateStructureType.Clean = value; _poolAccrualRateStructureType = poolAccrualRateStructureType;
                var poolAmortizationType = _poolAmortizationType; poolAmortizationType.Clean = value; _poolAmortizationType = poolAmortizationType;
                var poolAssumabilityIndicator = _poolAssumabilityIndicator; poolAssumabilityIndicator.Clean = value; _poolAssumabilityIndicator = poolAssumabilityIndicator;
                var poolBalloonIndicator = _poolBalloonIndicator; poolBalloonIndicator.Clean = value; _poolBalloonIndicator = poolBalloonIndicator;
                var poolCertificatePaymentDate = _poolCertificatePaymentDate; poolCertificatePaymentDate.Clean = value; _poolCertificatePaymentDate = poolCertificatePaymentDate;
                var poolClassType = _poolClassType; poolClassType.Clean = value; _poolClassType = poolClassType;
                var poolConcurrentTransferIndicator = _poolConcurrentTransferIndicator; poolConcurrentTransferIndicator.Clean = value; _poolConcurrentTransferIndicator = poolConcurrentTransferIndicator;
                var poolCurrentLoanCount = _poolCurrentLoanCount; poolCurrentLoanCount.Clean = value; _poolCurrentLoanCount = poolCurrentLoanCount;
                var poolCurrentPrincipalBalanceAmount = _poolCurrentPrincipalBalanceAmount; poolCurrentPrincipalBalanceAmount.Clean = value; _poolCurrentPrincipalBalanceAmount = poolCurrentPrincipalBalanceAmount;
                var poolDocumentCustodianID = _poolDocumentCustodianID; poolDocumentCustodianID.Clean = value; _poolDocumentCustodianID = poolDocumentCustodianID;
                var poolFixedServicingFeePercent = _poolFixedServicingFeePercent; poolFixedServicingFeePercent.Clean = value; _poolFixedServicingFeePercent = poolFixedServicingFeePercent;
                var poolIdentifier = _poolIdentifier; poolIdentifier.Clean = value; _poolIdentifier = poolIdentifier;
                var poolingMethodType = _poolingMethodType; poolingMethodType.Clean = value; _poolingMethodType = poolingMethodType;
                var poolInterestAdjustmentEffectiveDate = _poolInterestAdjustmentEffectiveDate; poolInterestAdjustmentEffectiveDate.Clean = value; _poolInterestAdjustmentEffectiveDate = poolInterestAdjustmentEffectiveDate;
                var poolInterestAdjustmentIndexLeadDaysCount = _poolInterestAdjustmentIndexLeadDaysCount; poolInterestAdjustmentIndexLeadDaysCount.Clean = value; _poolInterestAdjustmentIndexLeadDaysCount = poolInterestAdjustmentIndexLeadDaysCount;
                var poolInterestAndPaymentAdjustmentIndexLeadDaysCount = _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Clean = value; _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
                var poolInterestOnlyIndicator = _poolInterestOnlyIndicator; poolInterestOnlyIndicator.Clean = value; _poolInterestOnlyIndicator = poolInterestOnlyIndicator;
                var poolInterestRateRoundingPercent = _poolInterestRateRoundingPercent; poolInterestRateRoundingPercent.Clean = value; _poolInterestRateRoundingPercent = poolInterestRateRoundingPercent;
                var poolInterestRateRoundingType = _poolInterestRateRoundingType; poolInterestRateRoundingType.Clean = value; _poolInterestRateRoundingType = poolInterestRateRoundingType;
                var poolInvestorProductPlanIdentifier = _poolInvestorProductPlanIdentifier; poolInvestorProductPlanIdentifier.Clean = value; _poolInvestorProductPlanIdentifier = poolInvestorProductPlanIdentifier;
                var poolIssueDate = _poolIssueDate; poolIssueDate.Clean = value; _poolIssueDate = poolIssueDate;
                var poolIssuerTransferee = _poolIssuerTransferee; poolIssuerTransferee.Clean = value; _poolIssuerTransferee = poolIssuerTransferee;
                var poolMarginRatePercent = _poolMarginRatePercent; poolMarginRatePercent.Clean = value; _poolMarginRatePercent = poolMarginRatePercent;
                var poolMaturityDate = _poolMaturityDate; poolMaturityDate.Clean = value; _poolMaturityDate = poolMaturityDate;
                var poolMaturityPeriodCount = _poolMaturityPeriodCount; poolMaturityPeriodCount.Clean = value; _poolMaturityPeriodCount = poolMaturityPeriodCount;
                var poolMaximumAccrualRatePercent = _poolMaximumAccrualRatePercent; poolMaximumAccrualRatePercent.Clean = value; _poolMaximumAccrualRatePercent = poolMaximumAccrualRatePercent;
                var poolMinimumAccrualRatePercent = _poolMinimumAccrualRatePercent; poolMinimumAccrualRatePercent.Clean = value; _poolMinimumAccrualRatePercent = poolMinimumAccrualRatePercent;
                var poolMortgageType = _poolMortgageType; poolMortgageType.Clean = value; _poolMortgageType = poolMortgageType;
                var poolScheduledRemittancePaymentDay = _poolScheduledRemittancePaymentDay; poolScheduledRemittancePaymentDay.Clean = value; _poolScheduledRemittancePaymentDay = poolScheduledRemittancePaymentDay;
                var poolSecurityIssueDateInterestRatePercent = _poolSecurityIssueDateInterestRatePercent; poolSecurityIssueDateInterestRatePercent.Clean = value; _poolSecurityIssueDateInterestRatePercent = poolSecurityIssueDateInterestRatePercent;
                var poolSellerID = _poolSellerID; poolSellerID.Clean = value; _poolSellerID = poolSellerID;
                var poolServicerID = _poolServicerID; poolServicerID.Clean = value; _poolServicerID = poolServicerID;
                var poolStructureType = _poolStructureType; poolStructureType.Clean = value; _poolStructureType = poolStructureType;
                var poolSuffixIdentifier = _poolSuffixIdentifier; poolSuffixIdentifier.Clean = value; _poolSuffixIdentifier = poolSuffixIdentifier;
                var priceLockDatetime = _priceLockDatetime; priceLockDatetime.Clean = value; _priceLockDatetime = priceLockDatetime;
                var primaryMIAbsenceReasonType = _primaryMIAbsenceReasonType; primaryMIAbsenceReasonType.Clean = value; _primaryMIAbsenceReasonType = primaryMIAbsenceReasonType;
                var primaryMIAbsenceReasonTypeOtherDescription = _primaryMIAbsenceReasonTypeOtherDescription; primaryMIAbsenceReasonTypeOtherDescription.Clean = value; _primaryMIAbsenceReasonTypeOtherDescription = primaryMIAbsenceReasonTypeOtherDescription;
                var projectAttachmentType = _projectAttachmentType; projectAttachmentType.Clean = value; _projectAttachmentType = projectAttachmentType;
                var projectDesignType = _projectDesignType; projectDesignType.Clean = value; _projectDesignType = projectDesignType;
                var projectUnitCount = _projectUnitCount; projectUnitCount.Clean = value; _projectUnitCount = projectUnitCount;
                var propertyValuationEffectiveDate = _propertyValuationEffectiveDate; propertyValuationEffectiveDate.Clean = value; _propertyValuationEffectiveDate = propertyValuationEffectiveDate;
                var propertyValuationMethodType = _propertyValuationMethodType; propertyValuationMethodType.Clean = value; _propertyValuationMethodType = propertyValuationMethodType;
                var refinanceCashOutAmount = _refinanceCashOutAmount; refinanceCashOutAmount.Clean = value; _refinanceCashOutAmount = refinanceCashOutAmount;
                var refinanceCashOutDeterminationType = _refinanceCashOutDeterminationType; refinanceCashOutDeterminationType.Clean = value; _refinanceCashOutDeterminationType = refinanceCashOutDeterminationType;
                var relatedLoanBalloonIndicator = _relatedLoanBalloonIndicator; relatedLoanBalloonIndicator.Clean = value; _relatedLoanBalloonIndicator = relatedLoanBalloonIndicator;
                var relatedLoanHELOCIndicator = _relatedLoanHELOCIndicator; relatedLoanHELOCIndicator.Clean = value; _relatedLoanHELOCIndicator = relatedLoanHELOCIndicator;
                var relatedLoanIndicator = _relatedLoanIndicator; relatedLoanIndicator.Clean = value; _relatedLoanIndicator = relatedLoanIndicator;
                var relatedLoanInvestorType = _relatedLoanInvestorType; relatedLoanInvestorType.Clean = value; _relatedLoanInvestorType = relatedLoanInvestorType;
                var relatedLoanMaturityPeriodCount = _relatedLoanMaturityPeriodCount; relatedLoanMaturityPeriodCount.Clean = value; _relatedLoanMaturityPeriodCount = relatedLoanMaturityPeriodCount;
                var relatedLoanNoteDate = _relatedLoanNoteDate; relatedLoanNoteDate.Clean = value; _relatedLoanNoteDate = relatedLoanNoteDate;
                var relatedLoanScheduledFirstPaymentDate = _relatedLoanScheduledFirstPaymentDate; relatedLoanScheduledFirstPaymentDate.Clean = value; _relatedLoanScheduledFirstPaymentDate = relatedLoanScheduledFirstPaymentDate;
                var relatedLoanStateDateAtClosing = _relatedLoanStateDateAtClosing; relatedLoanStateDateAtClosing.Clean = value; _relatedLoanStateDateAtClosing = relatedLoanStateDateAtClosing;
                var relatedLoanUnpaidPrincipalBalanceAmount = _relatedLoanUnpaidPrincipalBalanceAmount; relatedLoanUnpaidPrincipalBalanceAmount.Clean = value; _relatedLoanUnpaidPrincipalBalanceAmount = relatedLoanUnpaidPrincipalBalanceAmount;
                var relocationLoanIndicator = _relocationLoanIndicator; relocationLoanIndicator.Clean = value; _relocationLoanIndicator = relocationLoanIndicator;
                var rEOMarketingPartyType = _rEOMarketingPartyType; rEOMarketingPartyType.Clean = value; _rEOMarketingPartyType = rEOMarketingPartyType;
                var secondLienIsDeliveredIndicator = _secondLienIsDeliveredIndicator; secondLienIsDeliveredIndicator.Clean = value; _secondLienIsDeliveredIndicator = secondLienIsDeliveredIndicator;
                var securityOriginalSubscriptionAmount = _securityOriginalSubscriptionAmount; securityOriginalSubscriptionAmount.Clean = value; _securityOriginalSubscriptionAmount = securityOriginalSubscriptionAmount;
                var securityTradeBookEntryDate = _securityTradeBookEntryDate; securityTradeBookEntryDate.Clean = value; _securityTradeBookEntryDate = securityTradeBookEntryDate;
                var sellerID = _sellerID; sellerID.Clean = value; _sellerID = sellerID;
                var sellerLoanIdentifier = _sellerLoanIdentifier; sellerLoanIdentifier.Clean = value; _sellerLoanIdentifier = sellerLoanIdentifier;
                var servicerID = _servicerID; servicerID.Clean = value; _servicerID = servicerID;
                var servicerLoanIdentifier = _servicerLoanIdentifier; servicerLoanIdentifier.Clean = value; _servicerLoanIdentifier = servicerLoanIdentifier;
                var sharedEquityIndicator = _sharedEquityIndicator; sharedEquityIndicator.Clean = value; _sharedEquityIndicator = sharedEquityIndicator;
                var siteBuiltIndicator = _siteBuiltIndicator; siteBuiltIndicator.Clean = value; _siteBuiltIndicator = siteBuiltIndicator;
                var specialFloodHazardAreaIndicator = _specialFloodHazardAreaIndicator; specialFloodHazardAreaIndicator.Clean = value; _specialFloodHazardAreaIndicator = specialFloodHazardAreaIndicator;
                var subsequentPerChangeMaximumDecreaseRatePercent = _subsequentPerChangeMaximumDecreaseRatePercent; subsequentPerChangeMaximumDecreaseRatePercent.Clean = value; _subsequentPerChangeMaximumDecreaseRatePercent = subsequentPerChangeMaximumDecreaseRatePercent;
                var subsequentPerChangeMaximumIncreaseRatePercent = _subsequentPerChangeMaximumIncreaseRatePercent; subsequentPerChangeMaximumIncreaseRatePercent.Clean = value; _subsequentPerChangeMaximumIncreaseRatePercent = subsequentPerChangeMaximumIncreaseRatePercent;
                var subsequentPerChangeRateAdjustmentEffectiveDate = _subsequentPerChangeRateAdjustmentEffectiveDate; subsequentPerChangeRateAdjustmentEffectiveDate.Clean = value; _subsequentPerChangeRateAdjustmentEffectiveDate = subsequentPerChangeRateAdjustmentEffectiveDate;
                var subsequentPerChangeRateAdjustmentFrequencyMonthsCount = _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Clean = value; _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
                var temporaryBuydownIndicator = _temporaryBuydownIndicator; temporaryBuydownIndicator.Clean = value; _temporaryBuydownIndicator = temporaryBuydownIndicator;
                var totalMortgagedPropertiesCount = _totalMortgagedPropertiesCount; totalMortgagedPropertiesCount.Clean = value; _totalMortgagedPropertiesCount = totalMortgagedPropertiesCount;
                var unit1SubjectPropertyGrossRentalIncome = _unit1SubjectPropertyGrossRentalIncome; unit1SubjectPropertyGrossRentalIncome.Clean = value; _unit1SubjectPropertyGrossRentalIncome = unit1SubjectPropertyGrossRentalIncome;
                var unit1TotalBedrooms = _unit1TotalBedrooms; unit1TotalBedrooms.Clean = value; _unit1TotalBedrooms = unit1TotalBedrooms;
                var unit2SubjectPropertyGrossRentalIncome = _unit2SubjectPropertyGrossRentalIncome; unit2SubjectPropertyGrossRentalIncome.Clean = value; _unit2SubjectPropertyGrossRentalIncome = unit2SubjectPropertyGrossRentalIncome;
                var unit2TotalBedrooms = _unit2TotalBedrooms; unit2TotalBedrooms.Clean = value; _unit2TotalBedrooms = unit2TotalBedrooms;
                var unit3SubjectPropertyGrossRentalIncome = _unit3SubjectPropertyGrossRentalIncome; unit3SubjectPropertyGrossRentalIncome.Clean = value; _unit3SubjectPropertyGrossRentalIncome = unit3SubjectPropertyGrossRentalIncome;
                var unit3TotalBedrooms = _unit3TotalBedrooms; unit3TotalBedrooms.Clean = value; _unit3TotalBedrooms = unit3TotalBedrooms;
                var unit4SubjectPropertyGrossRentalIncome = _unit4SubjectPropertyGrossRentalIncome; unit4SubjectPropertyGrossRentalIncome.Clean = value; _unit4SubjectPropertyGrossRentalIncome = unit4SubjectPropertyGrossRentalIncome;
                var unit4TotalBedrooms = _unit4TotalBedrooms; unit4TotalBedrooms.Clean = value; _unit4TotalBedrooms = unit4TotalBedrooms;
                var uPBAmount = _uPBAmount; uPBAmount.Clean = value; _uPBAmount = uPBAmount;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Uldd()
        {
            Clean = true;
        }
    }
}