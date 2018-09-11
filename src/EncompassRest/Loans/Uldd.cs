using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Uldd
    /// </summary>
    public sealed partial class Uldd : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aCHABARoutingAndTransitIdentifier;
        /// <summary>
        /// ACH ABA Routing And Transit Identifier [ULDD.GNM.ACHABARoutingAndTransitIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ACH ABA Routing And Transit Identifier")]
        public string ACHABARoutingAndTransitIdentifier { get => _aCHABARoutingAndTransitIdentifier; set => SetField(ref _aCHABARoutingAndTransitIdentifier, value); }
        private DirtyValue<string> _aCHABARoutingAndTransitNumber;
        /// <summary>
        /// ACH ABARouting And Transit # [ULDD.GNM.ACHABARtngAndTrnstNmbr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH ABARouting And Transit #")]
        public string ACHABARoutingAndTransitNumber { get => _aCHABARoutingAndTransitNumber; set => SetField(ref _aCHABARoutingAndTransitNumber, value); }
        private DirtyValue<string> _aCHBankAccountDescription;
        /// <summary>
        /// ACH Bank Account Description [ULDD.GNM.ACHBnkAccntDscr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Description")]
        public string ACHBankAccountDescription { get => _aCHBankAccountDescription; set => SetField(ref _aCHBankAccountDescription, value); }
        private DirtyValue<string> _aCHBankAccountIdentifier;
        /// <summary>
        /// ACH Bank Account Identifier [ULDD.GNM.ACHBnkAccntIdentfr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Identifier")]
        public string ACHBankAccountIdentifier { get => _aCHBankAccountIdentifier; set => SetField(ref _aCHBankAccountIdentifier, value); }
        private DirtyValue<string> _aCHBankAccountPurposeTransitIdentifier;
        /// <summary>
        /// ACH Bank Account Purpose Transit Identifier [ULDD.GNM.ACHBnkAccntPrpsTrnstIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Purpose Transit Identifier")]
        public string ACHBankAccountPurposeTransitIdentifier { get => _aCHBankAccountPurposeTransitIdentifier; set => SetField(ref _aCHBankAccountPurposeTransitIdentifier, value); }
        private DirtyValue<StringEnumValue<ACHBankAccountPurposeType>> _aCHBankAccountPurposeType;
        /// <summary>
        /// ACH Bank Account Purpose Type [ULDD.GNM.ACHBnkAccntPrpsTyp]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Purpose Type")]
        public StringEnumValue<ACHBankAccountPurposeType> ACHBankAccountPurposeType { get => _aCHBankAccountPurposeType; set => SetField(ref _aCHBankAccountPurposeType, value); }
        private DirtyValue<string> _aCHInstitutionTelegraphicAbbreviationName;
        /// <summary>
        /// ACH Institution Telegraphic Name [ULDD.GNM.ACHInstttnTlgrphcAbbrName]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Institution Telegraphic Name")]
        public string ACHInstitutionTelegraphicAbbreviationName { get => _aCHInstitutionTelegraphicAbbreviationName; set => SetField(ref _aCHInstitutionTelegraphicAbbreviationName, value); }
        private DirtyValue<string> _aCHReceiverSubaccountName;
        /// <summary>
        /// ACH Receiver Subaccount Name [ULDD.GNM.ACHRcvrSbccntName]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Receiver Subaccount Name")]
        public string ACHReceiverSubaccountName { get => _aCHReceiverSubaccountName; set => SetField(ref _aCHReceiverSubaccountName, value); }
        private DirtyValue<bool?> _additionalPrincipalAmountIndicator;
        /// <summary>
        /// ULDD - Additional Principal Amount has been Paid from Origination to Date [ULDD.X2]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Additional Principal Amount has been Paid from Origination to Date")]
        public bool? AdditionalPrincipalAmountIndicator { get => _additionalPrincipalAmountIndicator; set => SetField(ref _additionalPrincipalAmountIndicator, value); }
        private DirtyValue<decimal?> _aggregateLoanCurtailmentAmount;
        /// <summary>
        /// ULDD - Aggregate Loan Curtailment Amount [ULDD.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Aggregate Loan Curtailment Amount")]
        public decimal? AggregateLoanCurtailmentAmount { get => _aggregateLoanCurtailmentAmount; set => SetField(ref _aggregateLoanCurtailmentAmount, value); }
        private DirtyValue<string> _appraisalIdentifier;
        /// <summary>
        /// ULDD - Appraisal ID [ULDD.X31]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Appraisal ID")]
        public string AppraisalIdentifier { get => _appraisalIdentifier; set => SetField(ref _appraisalIdentifier, value); }
        private DirtyValue<StringEnumValue<AttachmentType>> _attachmentType;
        /// <summary>
        /// ULDD Attachment Type [ULDD.X177]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Attachment Type")]
        public StringEnumValue<AttachmentType> AttachmentType { get => _attachmentType; set => SetField(ref _attachmentType, value); }
        private DirtyValue<StringEnumValue<AVMModelNameType>> _aVMModelNameType;
        /// <summary>
        /// ULDD - AVM Model Name Type [ULDD.X32]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - AVM Model Name Type")]
        public StringEnumValue<AVMModelNameType> AVMModelNameType { get => _aVMModelNameType; set => SetField(ref _aVMModelNameType, value); }
        private DirtyValue<bool?> _balloonResetIndicator;
        /// <summary>
        /// Balloon Reset [ULDD.X159]
        /// </summary>
        [LoanFieldProperty(Description = "Balloon Reset")]
        public bool? BalloonResetIndicator { get => _balloonResetIndicator; set => SetField(ref _balloonResetIndicator, value); }
        private DirtyValue<decimal?> _baseGuarantyFeePercent;
        /// <summary>
        /// ULDD - Base Guaranty Fee [ULDD.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Base Guaranty Fee")]
        public decimal? BaseGuarantyFeePercent { get => _baseGuarantyFeePercent; set => SetField(ref _baseGuarantyFeePercent, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _bondFinancePool;
        /// <summary>
        /// ULDD Ginnie Bond Finance Pool Indicator [ULDD.GNM.BondFinPoolIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Pool Indicator")]
        public StringEnumValue<TrueOrFalse> BondFinancePool { get => _bondFinancePool; set => SetField(ref _bondFinancePool, value); }
        private DirtyValue<string> _bondFinanceProgramName;
        /// <summary>
        /// ULDD Ginnie Bond Finance Program Name [ULDD.GNM.BondFinProgName]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Program Name")]
        public string BondFinanceProgramName { get => _bondFinanceProgramName; set => SetField(ref _bondFinanceProgramName, value); }
        private DirtyValue<StringEnumValue<BondFinanceProgramType>> _bondFinanceProgramType;
        /// <summary>
        /// ULDD Ginnie Bond Finance Program Type [ULDD.GNM.BondFinProgType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Program Type")]
        public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get => _bondFinanceProgramType; set => SetField(ref _bondFinanceProgramType, value); }
        private DirtyValue<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        /// <summary>
        /// ULDD - Borrower Mailing Address is same as the Property Address [ULDD.X26]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Borrower Mailing Address is same as the Property Address")]
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get => _borrowerMailToAddressSameasPropertyIndicator; set => SetField(ref _borrowerMailToAddressSameasPropertyIndicator, value); }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _borrowerType;
        /// <summary>
        /// Borrower Type [ULDD.X150]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Type")]
        public StringEnumValue<UlddBorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }
        private DirtyValue<bool?> _capitalizedLoanIndicator;
        /// <summary>
        /// ULDD - Capitalized Loan [ULDD.X7]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Capitalized Loan")]
        public bool? CapitalizedLoanIndicator { get => _capitalizedLoanIndicator; set => SetField(ref _capitalizedLoanIndicator, value); }
        private DirtyValue<string> _certificateIdentifier;
        /// <summary>
        /// ULDD Ginnie Certificate Identifier [ULDD.GNM.CertId]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Identifier")]
        public string CertificateIdentifier { get => _certificateIdentifier; set => SetField(ref _certificateIdentifier, value); }
        private DirtyValue<DateTime?> _certificateMaturityDate;
        /// <summary>
        /// ULDD Ginnie Certificate Maturity Date [ULDD.GNM.CertMaturityDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Maturity Date")]
        public DateTime? CertificateMaturityDate { get => _certificateMaturityDate; set => SetField(ref _certificateMaturityDate, value); }
        private DirtyValue<decimal?> _certificatePrincipalBalanceAmount;
        /// <summary>
        /// ULDD Ginnie Certificate Principal Balance Amount [ULDD.GNM.CertPrinBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Certificate Principal Balance Amount")]
        public decimal? CertificatePrincipalBalanceAmount { get => _certificatePrincipalBalanceAmount; set => SetField(ref _certificatePrincipalBalanceAmount, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _certificateType;
        /// <summary>
        /// ULDD Ginnie Certificate Type [ULDD.GNM.CertType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Type")]
        public StringEnumValue<TrueOrFalse> CertificateType { get => _certificateType; set => SetField(ref _certificateType, value); }
        private DirtyValue<decimal?> _closingCost2ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST2CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost2ContributionAmount { get => _closingCost2ContributionAmount; set => SetField(ref _closingCost2ContributionAmount, value); }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost2FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST2FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get => _closingCost2FundsType; set => SetField(ref _closingCost2FundsType, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost2FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST2FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get => _closingCost2FundsTypeOtherDescription; set => SetField(ref _closingCost2FundsTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost2SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST2SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get => _closingCost2SourceType; set => SetField(ref _closingCost2SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost2SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST2SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get => _closingCost2SourceTypeOtherDescription; set => SetField(ref _closingCost2SourceTypeOtherDescription, value); }
        private DirtyValue<decimal?> _closingCost3ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST3CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost3ContributionAmount { get => _closingCost3ContributionAmount; set => SetField(ref _closingCost3ContributionAmount, value); }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost3FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST3FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get => _closingCost3FundsType; set => SetField(ref _closingCost3FundsType, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost3FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST3FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get => _closingCost3FundsTypeOtherDescription; set => SetField(ref _closingCost3FundsTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost3SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST3SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get => _closingCost3SourceType; set => SetField(ref _closingCost3SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost3SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST3SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get => _closingCost3SourceTypeOtherDescription; set => SetField(ref _closingCost3SourceTypeOtherDescription, value); }
        private DirtyValue<decimal?> _closingCost4ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST4CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost4ContributionAmount { get => _closingCost4ContributionAmount; set => SetField(ref _closingCost4ContributionAmount, value); }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost4FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST4FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get => _closingCost4FundsType; set => SetField(ref _closingCost4FundsType, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost4FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST4FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get => _closingCost4FundsTypeOtherDescription; set => SetField(ref _closingCost4FundsTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost4SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST4SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get => _closingCost4SourceType; set => SetField(ref _closingCost4SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost4SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST4SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get => _closingCost4SourceTypeOtherDescription; set => SetField(ref _closingCost4SourceTypeOtherDescription, value); }
        private DirtyValue<decimal?> _closingCostContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCostContributionAmount { get => _closingCostContributionAmount; set => SetField(ref _closingCostContributionAmount, value); }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCostFundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.X106]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get => _closingCostFundsType; set => SetField(ref _closingCostFundsType, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCostFundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.X107]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get => _closingCostFundsTypeOtherDescription; set => SetField(ref _closingCostFundsTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCostSourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.X108]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get => _closingCostSourceType; set => SetField(ref _closingCostSourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCostSourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.X109]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get => _closingCostSourceTypeOtherDescription; set => SetField(ref _closingCostSourceTypeOtherDescription, value); }
        private DirtyValue<string> _coBorrowerCountryCode;
        /// <summary>
        /// ULDD - Co-Borrower Country Code [ULDD.X155]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Co-Borrower Country Code")]
        public string CoBorrowerCountryCode { get => _coBorrowerCountryCode; set => SetField(ref _coBorrowerCountryCode, value); }
        private DirtyValue<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        /// <summary>
        /// ULDD - Co-Borrower Mailing Address is same as the Property Address [ULDD.X154]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Co-Borrower Mailing Address is same as the Property Address")]
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get => _coBorrowerMailToAddressSameasPropertyIndicator; set => SetField(ref _coBorrowerMailToAddressSameasPropertyIndicator, value); }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _coBorrowerType;
        /// <summary>
        /// co Borrower Type [ULDD.X151]
        /// </summary>
        [LoanFieldProperty(Description = "co Borrower Type")]
        public StringEnumValue<UlddBorrowerType> CoBorrowerType { get => _coBorrowerType; set => SetField(ref _coBorrowerType, value); }
        private DirtyValue<StringEnumValue<CondominiumProjectStatusType>> _condominiumProjectStatusType;
        /// <summary>
        /// ULDD - Project Status Type [ULDD.X28]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Project Status Type")]
        public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get => _condominiumProjectStatusType; set => SetField(ref _condominiumProjectStatusType, value); }
        private DirtyValue<StringEnumValue<ConstructionMethodType>> _constructionMethodType;
        /// <summary>
        /// ULDD Construction Method Type [ULDD.X172]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Construction Method Type")]
        public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get => _constructionMethodType; set => SetField(ref _constructionMethodType, value); }
        private DirtyValue<string> _constructionMethodTypeOtherDescription;
        /// <summary>
        /// Construction Method Type [ULDD.GNM.CnstrctnMthdTypOthrDscr]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Method Type")]
        public string ConstructionMethodTypeOtherDescription { get => _constructionMethodTypeOtherDescription; set => SetField(ref _constructionMethodTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingFeatureType>> _constructionToPermanentClosingFeatureType;
        /// <summary>
        /// ULDD - Construction - Perm Closing Feature [ULDD.X63]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Construction - Perm Closing Feature")]
        public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get => _constructionToPermanentClosingFeatureType; set => SetField(ref _constructionToPermanentClosingFeatureType, value); }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingType>> _constructionToPermanentClosingType;
        /// <summary>
        /// ULDD - Construction - Perm Closing Type [ULDD.X64]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Construction - Perm Closing Type")]
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => _constructionToPermanentClosingType; set => SetField(ref _constructionToPermanentClosingType, value); }
        private DirtyValue<StringEnumValue<ConvertibleStatusType>> _convertibleStatusType;
        /// <summary>
        /// ULDD - Convertible Status Type [ULDD.X91]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Convertible Status Type")]
        public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get => _convertibleStatusType; set => SetField(ref _convertibleStatusType, value); }
        private DirtyValue<StringEnumValue<CounselingFormatType>> _counselingFormatType;
        /// <summary>
        /// ULDD - Counseling Format [ULDD.X24]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Counseling Format")]
        public StringEnumValue<CounselingFormatType> CounselingFormatType { get => _counselingFormatType; set => SetField(ref _counselingFormatType, value); }
        private DirtyValue<StringEnumValue<CounselingFormatTypeOtherDescription>> _counselingFormatTypeOtherDescription;
        /// <summary>
        /// ULDD - Counseling Format Type Other Description [ULDD.X25]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Counseling Format Type Other Description")]
        public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get => _counselingFormatTypeOtherDescription; set => SetField(ref _counselingFormatTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<CounselTypeOther>> _counselTypeOther;
        /// <summary>
        /// Counsel Type Other [ULDD.X152]
        /// </summary>
        [LoanFieldProperty(Description = "Counsel Type Other")]
        public StringEnumValue<CounselTypeOther> CounselTypeOther { get => _counselTypeOther; set => SetField(ref _counselTypeOther, value); }
        private DirtyValue<string> _countryCode;
        /// <summary>
        /// ULDD - Country Code [ULDD.X27]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Country Code")]
        public string CountryCode { get => _countryCode; set => SetField(ref _countryCode, value); }
        private DirtyValue<StringEnumValue<CreditScoreImpairmentType>> _creditScoreImpairmentType;
        /// <summary>
        /// ULDD - Freddie Mac - Credit Score Impairment Type [ULDD.X104]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Credit Score Impairment Type")]
        public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get => _creditScoreImpairmentType; set => SetField(ref _creditScoreImpairmentType, value); }
        private DirtyValue<decimal?> _currentAccruedInterestAmount;
        /// <summary>
        /// ULDD - Current Accrued Interest [ULDD.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Current Accrued Interest")]
        public decimal? CurrentAccruedInterestAmount { get => _currentAccruedInterestAmount; set => SetField(ref _currentAccruedInterestAmount, value); }
        private DirtyValue<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        /// <summary>
        /// ULDD - Number of Delinquent Payments Over Past 12 Months [ULDD.X56]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Number of Delinquent Payments Over Past 12 Months")]
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get => _delinquentPaymentsOverPastTwelveMonthsCount; set => SetField(ref _delinquentPaymentsOverPastTwelveMonthsCount, value); }
        private DirtyValue<string> _documentCustodianID;
        /// <summary>
        /// ULDD - Fannie Mae - Document Custodian ID [ULDD.X114]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Document Custodian ID")]
        public string DocumentCustodianID { get => _documentCustodianID; set => SetField(ref _documentCustodianID, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentRequiredIndicator;
        /// <summary>
        /// ULDD Ginnie Document Required Indicator [ULDD.GNM.DocReqIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Document Required Indicator")]
        public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get => _documentRequiredIndicator; set => SetField(ref _documentRequiredIndicator, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentSubmissionIndicator;
        /// <summary>
        /// ULDD Ginnie Document Submission Indicator [ULDD.GNM.DocSubmissionIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Document Submission Indicator")]
        public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get => _documentSubmissionIndicator; set => SetField(ref _documentSubmissionIndicator, value); }
        private DirtyValue<StringEnumValue<DownPaymentFundsType>> _downPaymentFundsType;
        /// <summary>
        /// Down Payment Funds Type [ULDD.GNM.DwnPymntFndsType]
        /// </summary>
        [LoanFieldProperty(Description = "Down Payment Funds Type")]
        public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get => _downPaymentFundsType; set => SetField(ref _downPaymentFundsType, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _downPaymentOtherTypeDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Down Payment Other Type Description [ULDD.X113]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Down Payment Other Type Description")]
        public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get => _downPaymentOtherTypeDescription; set => SetField(ref _downPaymentOtherTypeDescription, value); }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _downPaymentSourceType;
        /// <summary>
        /// ULDD - Down Payment Source Type [ULDD.X89]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment Source Type")]
        public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get => _downPaymentSourceType; set => SetField(ref _downPaymentSourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _downPaymentSourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Down Payment SourceType Other Description [ULDD.X90]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get => _downPaymentSourceTypeOtherDescription; set => SetField(ref _downPaymentSourceTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<FannieARMIndexType>> _fannieARMIndexType;
        /// <summary>
        /// ULDD Fannie ARM Index Type [ULDD.FNM.ARMIndexType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie ARM Index Type")]
        public StringEnumValue<FannieARMIndexType> FannieARMIndexType { get => _fannieARMIndexType; set => SetField(ref _fannieARMIndexType, value); }
        private DirtyValue<StringEnumValue<FannieAutoUWDec>> _fannieAutoUWDec;
        /// <summary>
        /// Fannie Automatic Underwriting Decision [ULDD.FNM.AutoUWDec]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Automatic Underwriting Decision")]
        public StringEnumValue<FannieAutoUWDec> FannieAutoUWDec { get => _fannieAutoUWDec; set => SetField(ref _fannieAutoUWDec, value); }
        private DirtyValue<int?> _fannieBLTV;
        /// <summary>
        /// Base LTV Ratio Percent [ULDD.X186]
        /// </summary>
        [LoanFieldProperty(Description = "Base LTV Ratio Percent")]
        public int? FannieBLTV { get => _fannieBLTV; set => SetField(ref _fannieBLTV, value); }
        private DirtyValue<string> _fannieBorrowerFirstName;
        /// <summary>
        /// Uldd FannieBorrowerFirstName
        /// </summary>
        public string FannieBorrowerFirstName { get => _fannieBorrowerFirstName; set => SetField(ref _fannieBorrowerFirstName, value); }
        private DirtyValue<string> _fannieBorrowerMiddleName;
        /// <summary>
        /// Uldd FannieBorrowerMiddleName
        /// </summary>
        public string FannieBorrowerMiddleName { get => _fannieBorrowerMiddleName; set => SetField(ref _fannieBorrowerMiddleName, value); }
        private DirtyValue<StringEnumValue<FannieBuydownContributer>> _fannieBuydownContributer;
        /// <summary>
        /// Fannie Buy down Contributer [ULDD.X137]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Buy down Contributer")]
        public StringEnumValue<FannieBuydownContributer> FannieBuydownContributer { get => _fannieBuydownContributer; set => SetField(ref _fannieBuydownContributer, value); }
        private DirtyValue<int?> _fannieCLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus CLTV [ULDD.FNM.MORNET.X76]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus CLTV")]
        public int? FannieCLTV { get => _fannieCLTV; set => SetField(ref _fannieCLTV, value); }
        private DirtyValue<string> _fannieCoBorrowerFirstName;
        /// <summary>
        /// Uldd FannieCoBorrowerFirstName
        /// </summary>
        public string FannieCoBorrowerFirstName { get => _fannieCoBorrowerFirstName; set => SetField(ref _fannieCoBorrowerFirstName, value); }
        private DirtyValue<string> _fannieCoBorrowerMiddleName;
        /// <summary>
        /// Uldd FannieCoBorrowerMiddleName
        /// </summary>
        public string FannieCoBorrowerMiddleName { get => _fannieCoBorrowerMiddleName; set => SetField(ref _fannieCoBorrowerMiddleName, value); }
        private DirtyValue<string> _fannieCreditScoreProviderName;
        /// <summary>
        /// Credit Score Provider Name [ULDD.FNM.CreditScoreProviderName]
        /// </summary>
        [LoanFieldProperty(Description = "Credit Score Provider Name")]
        public string FannieCreditScoreProviderName { get => _fannieCreditScoreProviderName; set => SetField(ref _fannieCreditScoreProviderName, value); }
        private DirtyValue<StringEnumValue<FannieFloodSpecialFeatureCode>> _fannieFloodSpecialFeatureCode;
        /// <summary>
        /// ULDD Fannie Flood Special Feature Code [ULDD.FNM.FloodSpecialFeatureCode]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Flood Special Feature Code")]
        public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get => _fannieFloodSpecialFeatureCode; set => SetField(ref _fannieFloodSpecialFeatureCode, value); }
        private DirtyValue<int?> _fannieHCLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus HCLTV and HTLTV [ULDD.FNM.MORNET.X77]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus HCLTV and HTLTV")]
        public int? FannieHCLTV { get => _fannieHCLTV; set => SetField(ref _fannieHCLTV, value); }
        private DirtyValue<int?> _fannieInvestorOwnershipPercent;
        /// <summary>
        /// ULDD Fannie - Investor Ownership of the Loan [ULDD.FNM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie - Investor Ownership of the Loan")]
        public int? FannieInvestorOwnershipPercent { get => _fannieInvestorOwnershipPercent; set => SetField(ref _fannieInvestorOwnershipPercent, value); }
        private DirtyValue<StringEnumValue<FannieLegalEntityType>> _fannieLegalEntityType;
        /// <summary>
        /// Borr Fannie Legal Entity Type [ULDD.X120]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Fannie Legal Entity Type")]
        public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get => _fannieLegalEntityType; set => SetField(ref _fannieLegalEntityType, value); }
        private DirtyValue<StringEnumValue<FannieLegalEntityTypeOther>> _fannieLegalEntityTypeOther;
        /// <summary>
        /// Borr Fannie Legal Entity Type Other [ULDD.X122]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Fannie Legal Entity Type Other")]
        public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get => _fannieLegalEntityTypeOther; set => SetField(ref _fannieLegalEntityTypeOther, value); }
        private DirtyValue<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        /// <summary>
        /// ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.FNM.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment")]
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get => _fannieLenderPaidMIInterestRateAdjustmentPercent; set => SetField(ref _fannieLenderPaidMIInterestRateAdjustmentPercent, value); }
        private DirtyValue<StringEnumValue<FannieLoanProgramIdentifier>> _fannieLoanProgramIdentifier;
        /// <summary>
        /// ULDD Fannie Mae Loan Program Identifier [ULDD.FNM.LoanProgramIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae Loan Program Identifier")]
        public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get => _fannieLoanProgramIdentifier; set => SetField(ref _fannieLoanProgramIdentifier, value); }
        private DirtyValue<int?> _fannieLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus LTV [ULDD.FNM.MORNET.X75]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus LTV")]
        public int? FannieLTV { get => _fannieLTV; set => SetField(ref _fannieLTV, value); }
        private DirtyValue<StringEnumValue<FannieMICompanyNameTypeOther>> _fannieMICompanyNameTypeOther;
        /// <summary>
        /// Fannie MI Company Name Type Other [ULDD.X136]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie MI Company Name Type Other")]
        public StringEnumValue<FannieMICompanyNameTypeOther> FannieMICompanyNameTypeOther { get => _fannieMICompanyNameTypeOther; set => SetField(ref _fannieMICompanyNameTypeOther, value); }
        private DirtyValue<int?> _fannieMICoveragePercent;
        /// <summary>
        /// Fannie Insurance Mtg Ins Coverage Factor [ULDD.FNM.430]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Insurance Mtg Ins Coverage Factor")]
        public int? FannieMICoveragePercent { get => _fannieMICoveragePercent; set => SetField(ref _fannieMICoveragePercent, value); }
        private DirtyValue<int?> _fanniePoolOwnershipPercent;
        /// <summary>
        /// ULDD Fannie - Pool Ownership [ULDD.FNM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie - Pool Ownership")]
        public int? FanniePoolOwnershipPercent { get => _fanniePoolOwnershipPercent; set => SetField(ref _fanniePoolOwnershipPercent, value); }
        private DirtyValue<StringEnumValue<FannieProjectClassificationType>> _fannieProjectClassificationType;
        /// <summary>
        /// Fannie Project Classification Type [ULDD.X142]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Project Classification Type")]
        public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get => _fannieProjectClassificationType; set => SetField(ref _fannieProjectClassificationType, value); }
        private DirtyValue<StringEnumValue<FanniePropertyFormType>> _fanniePropertyFormType;
        /// <summary>
        /// Property Valuation Form Type [ULDD.FNM.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(Description = "Property Valuation Form Type")]
        public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get => _fanniePropertyFormType; set => SetField(ref _fanniePropertyFormType, value); }
        private DirtyValue<decimal?> _fannieRateSpread;
        /// <summary>
        /// ULDD Trans Details Rate Spread [ULDD.FNM.HMDA.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Trans Details Rate Spread")]
        public decimal? FannieRateSpread { get => _fannieRateSpread; set => SetField(ref _fannieRateSpread, value); }
        private DirtyValue<StringEnumValue<FannieRefinanceType>> _fannieRefinanceType;
        /// <summary>
        /// Fannie Refinance Type [ULDD.X129]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Refinance Type")]
        public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get => _fannieRefinanceType; set => SetField(ref _fannieRefinanceType, value); }
        private DirtyValue<string> _fannieRelatedInvestorLoanID;
        /// <summary>
        /// ULDD Fannie Related Investor Loan ID [ULDD.FNM.RelatedInvestorLoanID]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Related Investor Loan ID")]
        public string FannieRelatedInvestorLoanID { get => _fannieRelatedInvestorLoanID; set => SetField(ref _fannieRelatedInvestorLoanID, value); }
        private DirtyValue<StringEnumValue<FannieRelatedLoanAmortizationType>> _fannieRelatedLoanAmortizationType;
        /// <summary>
        /// Fannie Related Loan Amortization Type [ULDD.X131]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Amortization Type")]
        public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get => _fannieRelatedLoanAmortizationType; set => SetField(ref _fannieRelatedLoanAmortizationType, value); }
        private DirtyValue<StringEnumValue<FannieRelatedLoanLienPosition>> _fannieRelatedLoanLienPosition;
        /// <summary>
        /// Fannie Related Loan Lien Position [ULDD.X147]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Lien Position")]
        public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get => _fannieRelatedLoanLienPosition; set => SetField(ref _fannieRelatedLoanLienPosition, value); }
        private DirtyValue<StringEnumValue<FannieRelatedLoanType>> _fannieRelatedLoanType;
        /// <summary>
        /// Fannie Related Loan Type [ULDD.X128]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Type")]
        public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get => _fannieRelatedLoanType; set => SetField(ref _fannieRelatedLoanType, value); }
        private DirtyValue<StringEnumValue<FannieSectionOfAct>> _fannieSectionOfAct;
        /// <summary>
        /// ULDD Fannie Section of the Act [ULDD.FNM.SectionOfAct]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Section of the Act")]
        public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get => _fannieSectionOfAct; set => SetField(ref _fannieSectionOfAct, value); }
        private DirtyValue<int?> _fannieTLTV;
        /// <summary>
        /// ULDD Trans Details Total Loan to Value (TLTV) [ULDD.FNM.975]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Trans Details Total Loan to Value (TLTV)")]
        public int? FannieTLTV { get => _fannieTLTV; set => SetField(ref _fannieTLTV, value); }
        private DirtyValue<string> _fannieTrustName;
        /// <summary>
        /// Fannie Borrower Vesting Borr 1 Corp/Trust Name [ULDD.FNM.1859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fannie Borrower Vesting Borr 1 Corp/Trust Name")]
        public string FannieTrustName { get => _fannieTrustName; set => SetField(ref _fannieTrustName, value); }
        private DirtyValue<StringEnumValue<FannnieMortgageType>> _fannnieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.FNM.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<FannnieMortgageType> FannnieMortgageType { get => _fannnieMortgageType; set => SetField(ref _fannnieMortgageType, value); }
        private DirtyValue<int?> _financedUnitCount;
        /// <summary>
        /// Financed Unit Count [ULDD.X139]
        /// </summary>
        [LoanFieldProperty(Description = "Financed Unit Count")]
        public int? FinancedUnitCount { get => _financedUnitCount; set => SetField(ref _financedUnitCount, value); }
        private DirtyValue<DateTime?> _firstRateChangePaymentEffectiveDate;
        /// <summary>
        /// First Rate Change Payment Effective Date [ULDD.X185]
        /// </summary>
        [LoanFieldProperty(Description = "First Rate Change Payment Effective Date")]
        public DateTime? FirstRateChangePaymentEffectiveDate { get => _firstRateChangePaymentEffectiveDate; set => SetField(ref _firstRateChangePaymentEffectiveDate, value); }
        private DirtyValue<StringEnumValue<FNMHomeImprovementProductType>> _fNMHomeImprovementProductType;
        /// <summary>
        /// ULDD - Fannie Mae Home Impovement Product [ULDD.X23]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae Home Impovement Product")]
        public StringEnumValue<FNMHomeImprovementProductType> FNMHomeImprovementProductType { get => _fNMHomeImprovementProductType; set => SetField(ref _fNMHomeImprovementProductType, value); }
        private DirtyValue<StringEnumValue<FreddieARMIndexType>> _freddieARMIndexType;
        /// <summary>
        /// ULDD Freddie ARM Index Type [ULDD.FRE.ARMIndexType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie ARM Index Type")]
        public StringEnumValue<FreddieARMIndexType> FreddieARMIndexType { get => _freddieARMIndexType; set => SetField(ref _freddieARMIndexType, value); }
        private DirtyValue<StringEnumValue<FreddieAutoUWDec>> _freddieAutoUWDec;
        /// <summary>
        /// Freddie Automatic Underwriting Decision [ULDD.FRE.AutoUWDec]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Automatic Underwriting Decision")]
        public StringEnumValue<FreddieAutoUWDec> FreddieAutoUWDec { get => _freddieAutoUWDec; set => SetField(ref _freddieAutoUWDec, value); }
        private DirtyValue<StringEnumValue<FreddieAVMModelNameTypeExpl>> _freddieAVMModelNameTypeExpl;
        /// <summary>
        /// ULDD Freddie - AVM Model Name Type Other Description [ULDD.FRE.AVMModelNameExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie - AVM Model Name Type Other Description")]
        public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAVMModelNameTypeExpl { get => _freddieAVMModelNameTypeExpl; set => SetField(ref _freddieAVMModelNameTypeExpl, value); }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieBorrowerAlienStatus;
        /// <summary>
        /// Freddie Borr Declarations Alien Status [ULDD.X123]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Borr Declarations Alien Status")]
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get => _freddieBorrowerAlienStatus; set => SetField(ref _freddieBorrowerAlienStatus, value); }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieCoBorrowerAlienStatus;
        /// <summary>
        /// Freddie Co Borr Declarations Alien Status [ULDD.X148]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Co Borr Declarations Alien Status")]
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get => _freddieCoBorrowerAlienStatus; set => SetField(ref _freddieCoBorrowerAlienStatus, value); }
        private DirtyValue<string> _freddieCreditScoreProviderName;
        /// <summary>
        /// Credit Score Provider Name [ULDD.FRE.CreditScoreProviderName]
        /// </summary>
        [LoanFieldProperty(Description = "Credit Score Provider Name")]
        public string FreddieCreditScoreProviderName { get => _freddieCreditScoreProviderName; set => SetField(ref _freddieCreditScoreProviderName, value); }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPaymentType;
        /// <summary>
        /// ULDD Freddie Down Payment Type [ULDD.FRE.DownPaymentType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get => _freddieDownPaymentType; set => SetField(ref _freddieDownPaymentType, value); }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt2SourceType;
        /// <summary>
        /// ULDD - Down Payment 2 Source Type [ULDD.FRE.DownPmt2SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 2 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get => _freddieDownPmt2SourceType; set => SetField(ref _freddieDownPmt2SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt2SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 2 SourceType Other Description [ULDD.FRE.DownPmt2SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 2 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get => _freddieDownPmt2SourceTypeExpl; set => SetField(ref _freddieDownPmt2SourceTypeExpl, value); }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt2Type;
        /// <summary>
        /// ULDD Freddie Down Payment 2 Type [ULDD.FRE.DownPmt2Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 2 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get => _freddieDownPmt2Type; set => SetField(ref _freddieDownPmt2Type, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt2TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 2 Type Explanation [ULDD.FRE.DownPmt2TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 2 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get => _freddieDownPmt2TypeExpl; set => SetField(ref _freddieDownPmt2TypeExpl, value); }
        private DirtyValue<decimal?> _freddieDownPmt3Amt;
        /// <summary>
        /// Freddie Down Payment 3 Amount [ULDD.FRE.DownPmt3Amt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Down Payment 3 Amount")]
        public decimal? FreddieDownPmt3Amt { get => _freddieDownPmt3Amt; set => SetField(ref _freddieDownPmt3Amt, value); }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt3SourceType;
        /// <summary>
        /// ULDD - Down Payment 3 Source Type [ULDD.FRE.DownPmt3SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 3 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get => _freddieDownPmt3SourceType; set => SetField(ref _freddieDownPmt3SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt3SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 3 SourceType Other Description [ULDD.FRE.DownPmt3SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 3 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get => _freddieDownPmt3SourceTypeExpl; set => SetField(ref _freddieDownPmt3SourceTypeExpl, value); }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt3Type;
        /// <summary>
        /// ULDD Freddie Down Payment 3 Type [ULDD.FRE.DownPmt3Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 3 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get => _freddieDownPmt3Type; set => SetField(ref _freddieDownPmt3Type, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt3TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 3 Type Explanation [ULDD.FRE.DownPmt3TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 3 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get => _freddieDownPmt3TypeExpl; set => SetField(ref _freddieDownPmt3TypeExpl, value); }
        private DirtyValue<decimal?> _freddieDownPmt4Amt;
        /// <summary>
        /// Freddie Down Payment 4 Amount [ULDD.FRE.DownPmt4Amt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Down Payment 4 Amount")]
        public decimal? FreddieDownPmt4Amt { get => _freddieDownPmt4Amt; set => SetField(ref _freddieDownPmt4Amt, value); }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt4SourceType;
        /// <summary>
        /// ULDD - Down Payment 4 Source Type [ULDD.FRE.DownPmt4SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 4 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get => _freddieDownPmt4SourceType; set => SetField(ref _freddieDownPmt4SourceType, value); }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt4SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 4 SourceType Other Description [ULDD.FRE.DownPmt4SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 4 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get => _freddieDownPmt4SourceTypeExpl; set => SetField(ref _freddieDownPmt4SourceTypeExpl, value); }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt4Type;
        /// <summary>
        /// ULDD Freddie Down Payment 4 Type [ULDD.FRE.DownPmt4Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 4 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get => _freddieDownPmt4Type; set => SetField(ref _freddieDownPmt4Type, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt4TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 4 Type Explanation [ULDD.FRE.DownPmt4TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 4 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get => _freddieDownPmt4TypeExpl; set => SetField(ref _freddieDownPmt4TypeExpl, value); }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieExplanationOfDownPayment;
        /// <summary>
        /// ULDD Freddie Explanation of Down Payment [ULDD.FRE.ExplanationOfDownPayment]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Explanation of Down Payment")]
        public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get => _freddieExplanationOfDownPayment; set => SetField(ref _freddieExplanationOfDownPayment, value); }
        private DirtyValue<StringEnumValue<FreddieInvestorCollateralProgramIdentifier>> _freddieInvestorCollateralProgramIdentifier;
        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X95]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Collateral Program ID")]
        public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get => _freddieInvestorCollateralProgramIdentifier; set => SetField(ref _freddieInvestorCollateralProgramIdentifier, value); }
        private DirtyValue<string> _freddieInvestorFeatureIdentifier;
        /// <summary>
        /// ULDD - Freddie Investor Feature ID [ULDD.X179]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Investor Feature ID")]
        public string FreddieInvestorFeatureIdentifier { get => _freddieInvestorFeatureIdentifier; set => SetField(ref _freddieInvestorFeatureIdentifier, value); }
        private DirtyValue<StringEnumValue<FreddieLegalEntityType>> _freddieLegalEntityType;
        /// <summary>
        /// Borr Freddie Legal Entity Type [ULDD.X119]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Freddie Legal Entity Type")]
        public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get => _freddieLegalEntityType; set => SetField(ref _freddieLegalEntityType, value); }
        private DirtyValue<StringEnumValue<FreddieLegalEntityTypeOther>> _freddieLegalEntityTypeOther;
        /// <summary>
        /// Borr Freddie Legal Entity Type Other [ULDD.X121]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Freddie Legal Entity Type Other")]
        public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get => _freddieLegalEntityTypeOther; set => SetField(ref _freddieLegalEntityTypeOther, value); }
        private DirtyValue<StringEnumValue<FreddieLoanProgramIdentifier>> _freddieLoanProgramIdentifier;
        /// <summary>
        /// ULDD Freddie Loan Program Identifier [ULDD.FRE.LoanProgramIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Loan Program Identifier")]
        public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get => _freddieLoanProgramIdentifier; set => SetField(ref _freddieLoanProgramIdentifier, value); }
        private DirtyValue<StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator>> _freddieLoanTypePublicAndIndianHousingIndicator;
        /// <summary>
        /// Freddie Loan Type Other [ULDD.X153]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Loan Type Other")]
        public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get => _freddieLoanTypePublicAndIndianHousingIndicator; set => SetField(ref _freddieLoanTypePublicAndIndianHousingIndicator, value); }
        private DirtyValue<StringEnumValue<FreddieMICompanyNameTypeOther>> _freddieMICompanyNameTypeOther;
        /// <summary>
        /// Freddie MI Company Name Type Other [ULDD.X135]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie MI Company Name Type Other")]
        public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMICompanyNameTypeOther { get => _freddieMICompanyNameTypeOther; set => SetField(ref _freddieMICompanyNameTypeOther, value); }
        private DirtyValue<StringEnumValue<FreddieMortgageType>> _freddieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.FRE.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<FreddieMortgageType> FreddieMortgageType { get => _freddieMortgageType; set => SetField(ref _freddieMortgageType, value); }
        private DirtyValue<StringEnumValue<FreddieProjectClassificationType>> _freddieProjectClassificationType;
        /// <summary>
        /// Freddie Project Classification Type [ULDD.X141]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Project Classification Type")]
        public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get => _freddieProjectClassificationType; set => SetField(ref _freddieProjectClassificationType, value); }
        private DirtyValue<StringEnumValue<PropertyFormType>> _freddiePropertyFormType;
        /// <summary>
        /// Property Valuation Form Type [ULDD.FRE.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(Description = "Property Valuation Form Type")]
        public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get => _freddiePropertyFormType; set => SetField(ref _freddiePropertyFormType, value); }
        private DirtyValue<StringEnumValue<FreddieRefinanceCashOutDeterminationType>> _freddieRefinanceCashOutDeterminationType;
        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X180]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Refinance Cash Out Type")]
        public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get => _freddieRefinanceCashOutDeterminationType; set => SetField(ref _freddieRefinanceCashOutDeterminationType, value); }
        private DirtyValue<StringEnumValue<FreddieRefinanceType>> _freddieRefinanceType;
        /// <summary>
        /// Freddie Refinance Type [ULDD.X130]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Refinance Type")]
        public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get => _freddieRefinanceType; set => SetField(ref _freddieRefinanceType, value); }
        private DirtyValue<bool?> _freddieRelatedClosedEndSecondIndicator;
        /// <summary>
        /// ULDD Freddie Related Closed End Second Indicator [ULDD.FRE.RelatedClosedEndSecondIndicator]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Related Closed End Second Indicator")]
        public bool? FreddieRelatedClosedEndSecondIndicator { get => _freddieRelatedClosedEndSecondIndicator; set => SetField(ref _freddieRelatedClosedEndSecondIndicator, value); }
        private DirtyValue<string> _freddieRelatedInvestorLoanID;
        /// <summary>
        /// ULDD Freddie Related Investor Loan ID [ULDD.FRE.RelatedInvestorLoanID]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Related Investor Loan ID")]
        public string FreddieRelatedInvestorLoanID { get => _freddieRelatedInvestorLoanID; set => SetField(ref _freddieRelatedInvestorLoanID, value); }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanInvestorType>> _freddieRelatedLoanInvestorType;
        /// <summary>
        /// ULDD - Freddie Mac - Related Loan Investor Type [ULDD.X99]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Related Loan Investor Type")]
        public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get => _freddieRelatedLoanInvestorType; set => SetField(ref _freddieRelatedLoanInvestorType, value); }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanLienPosition>> _freddieRelatedLoanLienPosition;
        /// <summary>
        /// Uldd FreddieRelatedLoanLienPosition [ULDD.X145]
        /// </summary>
        public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get => _freddieRelatedLoanLienPosition; set => SetField(ref _freddieRelatedLoanLienPosition, value); }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanType>> _freddieRelatedLoanType;
        /// <summary>
        /// Freddie Related Loan Type [ULDD.X127]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Related Loan Type")]
        public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get => _freddieRelatedLoanType; set => SetField(ref _freddieRelatedLoanType, value); }
        private DirtyValue<StringEnumValue<FreddieSectionOfAct>> _freddieSectionOfAct;
        /// <summary>
        /// ULDD Freddie Section of the Act [ULDD.FRE.SectionOfAct]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Section of the Act")]
        public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get => _freddieSectionOfAct; set => SetField(ref _freddieSectionOfAct, value); }
        private DirtyValue<StringEnumValue<FreddieUnderwritingTypeOther>> _freddieUnderwritingTypeOther;
        /// <summary>
        /// Freddie Underwriting Type Other [ULDD.X149]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Underwriting Type Other")]
        public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get => _freddieUnderwritingTypeOther; set => SetField(ref _freddieUnderwritingTypeOther, value); }
        private DirtyValue<StringEnumValue<GinnieConstructionMethodType>> _ginnieConstructionMethodType;
        /// <summary>
        /// ULDD Construction Method Type [ULDD.X187]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Construction Method Type")]
        public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get => _ginnieConstructionMethodType; set => SetField(ref _ginnieConstructionMethodType, value); }
        private DirtyValue<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        /// <summary>
        /// ULDD Ginnie Government Annual Premium Amount [ULDD.GNM.GovAnnlPrmAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Government Annual Premium Amount")]
        public decimal? GinnieGovernmentAnnualPremiumAmount { get => _ginnieGovernmentAnnualPremiumAmount; set => SetField(ref _ginnieGovernmentAnnualPremiumAmount, value); }
        private DirtyValue<StringEnumValue<GinnieMortgageType>> _ginnieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.GNM.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get => _ginnieMortgageType; set => SetField(ref _ginnieMortgageType, value); }
        private DirtyValue<string> _ginnieOtherConstructionMethodType;
        /// <summary>
        /// ULDD Other Construction Method Type [ULDD.X188]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Other Construction Method Type")]
        public string GinnieOtherConstructionMethodType { get => _ginnieOtherConstructionMethodType; set => SetField(ref _ginnieOtherConstructionMethodType, value); }
        private DirtyValue<decimal?> _governmentAnnualPremiumPercent;
        /// <summary>
        /// Government Annual Premium Percent [ULDD.GNM.GovAnnlPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Government Annual Premium Percent")]
        public decimal? GovernmentAnnualPremiumPercent { get => _governmentAnnualPremiumPercent; set => SetField(ref _governmentAnnualPremiumPercent, value); }
        private DirtyValue<StringEnumValue<GovernmentRefinanceType>> _governmentRefinanceType;
        /// <summary>
        /// Government Refinance Type [ULDD.GNM.GovRefType]
        /// </summary>
        [LoanFieldProperty(Description = "Government Refinance Type")]
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => _governmentRefinanceType; set => SetField(ref _governmentRefinanceType, value); }
        private DirtyValue<decimal?> _governmentUpfrontPremiumAmount;
        /// <summary>
        /// Government Upfront Premium Amount [ULDD.GNM.GovUpFrontPrmAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Government Upfront Premium Amount")]
        public decimal? GovernmentUpfrontPremiumAmount { get => _governmentUpfrontPremiumAmount; set => SetField(ref _governmentUpfrontPremiumAmount, value); }
        private DirtyValue<decimal?> _governmentUpfrontPremiumPercent;
        /// <summary>
        /// Government Upfront Premium Percent [ULDD.GNM.GovUpFrontPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Government Upfront Premium Percent")]
        public decimal? GovernmentUpfrontPremiumPercent { get => _governmentUpfrontPremiumPercent; set => SetField(ref _governmentUpfrontPremiumPercent, value); }
        private DirtyValue<StringEnumValue<GSEProjectType>> _gSEProjectType;
        /// <summary>
        /// Subject Property Project Classification [ULDD.X182]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Project Classification")]
        public StringEnumValue<GSEProjectType> GSEProjectType { get => _gSEProjectType; set => SetField(ref _gSEProjectType, value); }
        private DirtyValue<bool?> _guaranteeFeeAddOnIndicator;
        /// <summary>
        /// ULDD - Guaranty Fee Add On [ULDD.X96]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Guaranty Fee Add On")]
        public bool? GuaranteeFeeAddOnIndicator { get => _guaranteeFeeAddOnIndicator; set => SetField(ref _guaranteeFeeAddOnIndicator, value); }
        private DirtyValue<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        /// <summary>
        /// ULDD - Guaranty Fee After Alternate Payment Method [ULDD.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Guaranty Fee After Alternate Payment Method")]
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get => _guarantyFeeAfterAlternatePaymentMethodPercent; set => SetField(ref _guarantyFeeAfterAlternatePaymentMethodPercent, value); }
        private DirtyValue<decimal?> _guarantyFeePercent;
        /// <summary>
        /// ULDD - Guaranty Fee [ULDD.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Guaranty Fee")]
        public decimal? GuarantyFeePercent { get => _guarantyFeePercent; set => SetField(ref _guarantyFeePercent, value); }
        private DirtyValue<decimal?> _guarantyPercent;
        /// <summary>
        /// Guaranty Percent [ULDD.GNM.GrntyPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Guaranty Percent")]
        public decimal? GuarantyPercent { get => _guarantyPercent; set => SetField(ref _guarantyPercent, value); }
        private DirtyValue<string> _homeOwnerAssociationEin;
        /// <summary>
        /// ULDD Home Owner Association EIN [ULDD.X192]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Home Owner Association EIN")]
        public string HomeOwnerAssociationEin { get => _homeOwnerAssociationEin; set => SetField(ref _homeOwnerAssociationEin, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Uldd Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<IndexType>> _indexType;
        /// <summary>
        /// Index Type [ULDD.GNM.IndxType]
        /// </summary>
        [LoanFieldProperty(Description = "Index Type")]
        public StringEnumValue<IndexType> IndexType { get => _indexType; set => SetField(ref _indexType, value); }
        private DirtyValue<int?> _initialFixedPeriodEffectiveMonthsCount;
        /// <summary>
        /// ULDD - Initial Fixed Period [ULDD.X6]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Initial Fixed Period")]
        public int? InitialFixedPeriodEffectiveMonthsCount { get => _initialFixedPeriodEffectiveMonthsCount; set => SetField(ref _initialFixedPeriodEffectiveMonthsCount, value); }
        private DirtyValue<StringEnumValue<InterestAccrualType>> _interestAccrualType;
        /// <summary>
        /// ULDD - Interest Accrual Type [ULDD.X12]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Accrual Type")]
        public StringEnumValue<InterestAccrualType> InterestAccrualType { get => _interestAccrualType; set => SetField(ref _interestAccrualType, value); }
        private DirtyValue<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Interest and Payment Adjustment Index Lead Days [ULDD.X10]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest and Payment Adjustment Index Lead Days")]
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get => _interestAndPaymentAdjustmentIndexLeadDaysCount; set => SetField(ref _interestAndPaymentAdjustmentIndexLeadDaysCount, value); }
        private DirtyValue<StringEnumValue<InterestCalculationBasisType>> _interestCalculationBasisType;
        /// <summary>
        /// ULDD - Interest Calculation Basis Type [ULDD.X13]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Basis Type")]
        public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get => _interestCalculationBasisType; set => SetField(ref _interestCalculationBasisType, value); }
        private DirtyValue<int?> _interestCalculationEffectiveMonthsCount;
        /// <summary>
        /// ULDD - Interest Calculation Effective Months [ULDD.X14]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Effective Months")]
        public int? InterestCalculationEffectiveMonthsCount { get => _interestCalculationEffectiveMonthsCount; set => SetField(ref _interestCalculationEffectiveMonthsCount, value); }
        private DirtyValue<StringEnumValue<InterestCalculationType>> _interestCalculationType;
        /// <summary>
        /// ULDD - Interest Calculation Type [ULDD.X11]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Type")]
        public StringEnumValue<InterestCalculationType> InterestCalculationType { get => _interestCalculationType; set => SetField(ref _interestCalculationType, value); }
        private DirtyValue<StringEnumValue<InvestorCollateralProgramIdentifier>> _investorCollateralProgramIdentifier;
        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X38]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Collateral Program ID")]
        public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get => _investorCollateralProgramIdentifier; set => SetField(ref _investorCollateralProgramIdentifier, value); }
        private DirtyValue<string> _investorCommitmentIdentifier;
        /// <summary>
        /// ULDD - Investor Commitment ID [ULDD.X37]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Commitment ID")]
        public string InvestorCommitmentIdentifier { get => _investorCommitmentIdentifier; set => SetField(ref _investorCommitmentIdentifier, value); }
        private DirtyValue<string> _investorFeatureIdentifier;
        /// <summary>
        /// ULDD - Investor Feature ID [ULDD.X36]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Feature ID")]
        public string InvestorFeatureIdentifier { get => _investorFeatureIdentifier; set => SetField(ref _investorFeatureIdentifier, value); }
        private DirtyValue<string> _investorFeatureIdPool;
        /// <summary>
        /// ULDD - Fannie Mae - Investor Feature ID Pool [ULDD.X115]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Investor Feature ID Pool")]
        public string InvestorFeatureIdPool { get => _investorFeatureIdPool; set => SetField(ref _investorFeatureIdPool, value); }
        private DirtyValue<decimal?> _investorOwnershipPercent;
        /// <summary>
        /// ULDD - Investor Ownership of the Loan [ULDD.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Investor Ownership of the Loan")]
        public decimal? InvestorOwnershipPercent { get => _investorOwnershipPercent; set => SetField(ref _investorOwnershipPercent, value); }
        private DirtyValue<string> _investorProductPlanIdentifier;
        /// <summary>
        /// ULDD - Investor Product Plan ID [ULDD.X35]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Product Plan ID")]
        public string InvestorProductPlanIdentifier { get => _investorProductPlanIdentifier; set => SetField(ref _investorProductPlanIdentifier, value); }
        private DirtyValue<int?> _investorRemittanceDay;
        /// <summary>
        /// ULDD - Investor Remittance Day [ULDD.X45]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Remittance Day")]
        public int? InvestorRemittanceDay { get => _investorRemittanceDay; set => SetField(ref _investorRemittanceDay, value); }
        private DirtyValue<StringEnumValue<InvestorRemittanceType>> _investorRemittanceType;
        /// <summary>
        /// ULDD - Investor Remittance Type [ULDD.X44]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Remittance Type")]
        public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get => _investorRemittanceType; set => SetField(ref _investorRemittanceType, value); }
        private DirtyValue<string> _issuerIdentifier;
        /// <summary>
        /// ULDD Ginnie Issuer Identifier [ULDD.GNM.IssuerId]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Issuer Identifier")]
        public string IssuerIdentifier { get => _issuerIdentifier; set => SetField(ref _issuerIdentifier, value); }
        private DirtyValue<DateTime?> _lastPaidInstallmentDueDate;
        /// <summary>
        /// ULDD - Last Paid Installment Due Date [ULDD.X54]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Last Paid Installment Due Date")]
        public DateTime? LastPaidInstallmentDueDate { get => _lastPaidInstallmentDueDate; set => SetField(ref _lastPaidInstallmentDueDate, value); }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        /// <summary>
        /// ULDD - Last Payment Received Date [ULDD.X53]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Last Payment Received Date")]
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => SetField(ref _lastPaymentReceivedDate, value); }
        private DirtyValue<DateTime?> _latestConversionEffectiveDate;
        /// <summary>
        /// ULDD - Latest Conversion Effective Date [ULDD.X92]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Latest Conversion Effective Date")]
        public DateTime? LatestConversionEffectiveDate { get => _latestConversionEffectiveDate; set => SetField(ref _latestConversionEffectiveDate, value); }
        private DirtyValue<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        /// <summary>
        /// ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment")]
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get => _lenderPaidMIInterestRateAdjustmentPercent; set => SetField(ref _lenderPaidMIInterestRateAdjustmentPercent, value); }
        private DirtyValue<DateTime?> _lendersDeliveryDate;
        /// <summary>
        /// Lender's Delivery Date [ULDD.X133]
        /// </summary>
        [LoanFieldProperty(Description = "Lender's Delivery Date")]
        public DateTime? LendersDeliveryDate { get => _lendersDeliveryDate; set => SetField(ref _lendersDeliveryDate, value); }
        private DirtyValue<decimal?> _loanAcquisitionScheduledUPBAmount;
        /// <summary>
        /// ULDD - Loan Acquisition UPB [ULDD.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Loan Acquisition UPB")]
        public decimal? LoanAcquisitionScheduledUPBAmount { get => _loanAcquisitionScheduledUPBAmount; set => SetField(ref _loanAcquisitionScheduledUPBAmount, value); }
        private DirtyValue<int?> _loanAmortizationMaximumTermMonthsCount;
        /// <summary>
        /// ULDD - Maximum Amortization Term [ULDD.X19]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Maximum Amortization Term")]
        public int? LoanAmortizationMaximumTermMonthsCount { get => _loanAmortizationMaximumTermMonthsCount; set => SetField(ref _loanAmortizationMaximumTermMonthsCount, value); }
        private DirtyValue<int?> _loanBuyupBuydownBasisPointNumber;
        /// <summary>
        /// ULDD - Loan Level Basis Points [ULDD.X98]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Level Basis Points")]
        public int? LoanBuyupBuydownBasisPointNumber { get => _loanBuyupBuydownBasisPointNumber; set => SetField(ref _loanBuyupBuydownBasisPointNumber, value); }
        private DirtyValue<StringEnumValue<LoanBuyupBuydownType>> _loanBuyupBuydownType;
        /// <summary>
        /// ULDD - Loan Feature [ULDD.X97]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Feature")]
        public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get => _loanBuyupBuydownType; set => SetField(ref _loanBuyupBuydownType, value); }
        private DirtyValue<StringEnumValue<LoanDefaultLossPartyType>> _loanDefaultLossPartyType;
        /// <summary>
        /// ULDD - Loan Default Loss Party [ULDD.X47]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Default Loss Party")]
        public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get => _loanDefaultLossPartyType; set => SetField(ref _loanDefaultLossPartyType, value); }
        private DirtyValue<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        /// <summary>
        /// ULDD - Freddie Mac - Loan delivered through the servicing released process [ULDD.X100]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan delivered through the servicing released process")]
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get => _loanDeliveredThroughServicingReleasedProcessIndicator; set => SetField(ref _loanDeliveredThroughServicingReleasedProcessIndicator, value); }
        private DirtyValue<StringEnumValue<LoanIdentifierValueType>> _loanIdentifierValueType;
        /// <summary>
        /// ULDD Loan Identifier Value Type [ULDD.LoanIdentifierValueType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Loan Identifier Value Type")]
        public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get => _loanIdentifierValueType; set => SetField(ref _loanIdentifierValueType, value); }
        private DirtyValue<DateTime?> _loanInterestAccrualStartDate;
        /// <summary>
        /// ULDD - Loan Interest Accrual Start Date [ULDD.X16]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Interest Accrual Start Date")]
        public DateTime? LoanInterestAccrualStartDate { get => _loanInterestAccrualStartDate; set => SetField(ref _loanInterestAccrualStartDate, value); }
        private DirtyValue<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description [ULDD.X103]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description")]
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; set => SetField(ref _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator, value); }
        private DirtyValue<StringEnumValue<LoanLevelCreditScoreSelectionMethodType>> _loanLevelCreditScoreSelectionMethodType;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score  Method [ULDD.X102]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score  Method")]
        public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get => _loanLevelCreditScoreSelectionMethodType; set => SetField(ref _loanLevelCreditScoreSelectionMethodType, value); }
        private DirtyValue<int?> _loanLevelCreditScoreValue;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Value [ULDD.X101]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score Value")]
        public int? LoanLevelCreditScoreValue { get => _loanLevelCreditScoreValue; set => SetField(ref _loanLevelCreditScoreValue, value); }
        private DirtyValue<DateTime?> _loanModificationEffectiveDate;
        /// <summary>
        /// ULDD - Loan Modification Effective Date [ULDD.X5]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Modification Effective Date")]
        public DateTime? LoanModificationEffectiveDate { get => _loanModificationEffectiveDate; set => SetField(ref _loanModificationEffectiveDate, value); }
        private DirtyValue<DateTime?> _loanStateDate;
        /// <summary>
        /// ULDD - Loan State Date [ULDD.X88]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan State Date")]
        public DateTime? LoanStateDate { get => _loanStateDate; set => SetField(ref _loanStateDate, value); }
        private DirtyValue<StringEnumValue<ManufacturedHomeWidthType>> _manufacturedHomeWidthType;
        /// <summary>
        /// ULDD Manufactured Home Width Type [ULDD.ManufacturedHomeWidthType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Manufactured Home Width Type")]
        public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get => _manufacturedHomeWidthType; set => SetField(ref _manufacturedHomeWidthType, value); }
        private DirtyValue<bool?> _mBSWeightedMarginIndicator;
        /// <summary>
        /// ULDD - MBS has weighted Margin [ULDD.X34]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - MBS has weighted Margin")]
        public bool? MBSWeightedMarginIndicator { get => _mBSWeightedMarginIndicator; set => SetField(ref _mBSWeightedMarginIndicator, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _mERSOriginalMortgageeOfRecordIndicator;
        /// <summary>
        /// MERS Original Mortgagee of Record Indicator [ULDD.GNM.MERSOrgnalMrtggeeOfRcrdIndctr]
        /// </summary>
        [LoanFieldProperty(Description = "MERS Original Mortgagee of Record Indicator")]
        public StringEnumValue<TrueOrFalse> MERSOriginalMortgageeOfRecordIndicator { get => _mERSOriginalMortgageeOfRecordIndicator; set => SetField(ref _mERSOriginalMortgageeOfRecordIndicator, value); }
        private DirtyValue<StringEnumValue<MICompanyNameType>> _mICompanyNameType;
        /// <summary>
        /// MI Company Name Type [ULDD.X134]
        /// </summary>
        [LoanFieldProperty(Description = "MI Company Name Type")]
        public StringEnumValue<MICompanyNameType> MICompanyNameType { get => _mICompanyNameType; set => SetField(ref _mICompanyNameType, value); }
        private DirtyValue<StringEnumValue<MIPremiumSourceType>> _mIPremiumSourceType;
        /// <summary>
        /// ULDD - Mortgage Insurance Premium Source Type [ULDD.X49]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage Insurance Premium Source Type")]
        public StringEnumValue<MIPremiumSourceType> MIPremiumSourceType { get => _mIPremiumSourceType; set => SetField(ref _mIPremiumSourceType, value); }
        private DirtyValue<DateTime?> _monetaryEventAppliedDate;
        /// <summary>
        /// Monetary Event Applied Date [ULDD.GNM.MntryEvntAppldDt]
        /// </summary>
        [LoanFieldProperty(Description = "Monetary Event Applied Date")]
        public DateTime? MonetaryEventAppliedDate { get => _monetaryEventAppliedDate; set => SetField(ref _monetaryEventAppliedDate, value); }
        private DirtyValue<decimal?> _monetaryEventGrossPrincipalAmount;
        /// <summary>
        /// Monetary Event Gross Principal Amount [ULDD.GNM.MntryEvntGrssPrncpalAmnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Monetary Event Gross Principal Amount")]
        public decimal? MonetaryEventGrossPrincipalAmount { get => _monetaryEventGrossPrincipalAmount; set => SetField(ref _monetaryEventGrossPrincipalAmount, value); }
        private DirtyValue<StringEnumValue<MonetaryEventType>> _monetaryEventType;
        /// <summary>
        /// Monetary Event Type [ULDD.GNM.MntryEvntTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Monetary Event Type")]
        public StringEnumValue<MonetaryEventType> MonetaryEventType { get => _monetaryEventType; set => SetField(ref _monetaryEventType, value); }
        private DirtyValue<bool?> _mortgageBackedSecurityIndicator;
        /// <summary>
        /// ULDD - Mortgage-Backed Security [ULDD.X33]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage-Backed Security")]
        public bool? MortgageBackedSecurityIndicator { get => _mortgageBackedSecurityIndicator; set => SetField(ref _mortgageBackedSecurityIndicator, value); }
        private DirtyValue<bool?> _mortgageModificationIndicator;
        /// <summary>
        /// ULDD - Mortgage Modification [ULDD.X4]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage Modification")]
        public bool? MortgageModificationIndicator { get => _mortgageModificationIndicator; set => SetField(ref _mortgageModificationIndicator, value); }
        private DirtyValue<StringEnumValue<UlddMortgageOriginator>> _mortgageOriginator;
        /// <summary>
        /// Trans Details Mtg Originator [ULDD.GNM.MortgageOriginator]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Mtg Originator")]
        public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => SetField(ref _mortgageOriginator, value); }
        private DirtyValue<StringEnumValue<MortgageProgramType>> _mortgageProgramType;
        /// <summary>
        /// Mortgage Program Type [ULDD.GNM.MrtggPrgrmType]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Program Type")]
        public StringEnumValue<MortgageProgramType> MortgageProgramType { get => _mortgageProgramType; set => SetField(ref _mortgageProgramType, value); }
        private DirtyValue<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        /// <summary>
        /// More than one concurrently closing lien on the subject property [ULDD.X124]
        /// </summary>
        [LoanFieldProperty(Description = "More than one concurrently closing lien on the subject property")]
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; set => SetField(ref _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator, value); }
        private DirtyValue<DateTime?> _nextRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Next Rate Adjustment Effective Date [ULDD.X62]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Next Rate Adjustment Effective Date")]
        public DateTime? NextRateAdjustmentEffectiveDate { get => _nextRateAdjustmentEffectiveDate; set => SetField(ref _nextRateAdjustmentEffectiveDate, value); }
        private DirtyValue<string> _notePayToName;
        /// <summary>
        /// Note Pay To Name [ULDD.X184]
        /// </summary>
        [LoanFieldProperty(Description = "Note Pay To Name")]
        public string NotePayToName { get => _notePayToName; set => SetField(ref _notePayToName, value); }
        private DirtyValue<int?> _numberOfUnitsSold;
        /// <summary>
        /// Number of Units Sold [ULDD.X138]
        /// </summary>
        [LoanFieldProperty(Description = "Number of Units Sold")]
        public int? NumberOfUnitsSold { get => _numberOfUnitsSold; set => SetField(ref _numberOfUnitsSold, value); }
        private DirtyValue<string> _otherDownPaymentFundsType;
        /// <summary>
        /// Other Down Payment Funds Type [ULDD.GNM.OtherDwnPymntFndsType]
        /// </summary>
        [LoanFieldProperty(Description = "Other Down Payment Funds Type")]
        public string OtherDownPaymentFundsType { get => _otherDownPaymentFundsType; set => SetField(ref _otherDownPaymentFundsType, value); }
        private DirtyValue<decimal?> _otherFundsCollectedAtClosingAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Other Funds Collected at Closing [ULDD.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Other Funds Collected at Closing")]
        public decimal? OtherFundsCollectedAtClosingAmount { get => _otherFundsCollectedAtClosingAmount; set => SetField(ref _otherFundsCollectedAtClosingAmount, value); }
        private DirtyValue<StringEnumValue<OtherFundsCollectedAtClosingType>> _otherFundsCollectedAtClosingType;
        /// <summary>
        /// ULDD - Freddie Mac - Other Funds collected at Closing for [ULDD.X111]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Other Funds collected at Closing for")]
        public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get => _otherFundsCollectedAtClosingType; set => SetField(ref _otherFundsCollectedAtClosingType, value); }
        private DirtyValue<string> _payeeID;
        /// <summary>
        /// ULDD - Fannie Mae - Payee ID [ULDD.X117]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Payee ID")]
        public string PayeeID { get => _payeeID; set => SetField(ref _payeeID, value); }
        private DirtyValue<int?> _paymentBillingStatementLeadDaysCount;
        /// <summary>
        /// ULDD - Billing Statement and Payment Lead Days [ULDD.X55]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Billing Statement and Payment Lead Days")]
        public int? PaymentBillingStatementLeadDaysCount { get => _paymentBillingStatementLeadDaysCount; set => SetField(ref _paymentBillingStatementLeadDaysCount, value); }
        private DirtyValue<decimal?> _perChangeMaximumDecreaseRatePercent;
        /// <summary>
        /// ULDD - Maximum Decrease Rate [ULDD.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Maximum Decrease Rate")]
        public decimal? PerChangeMaximumDecreaseRatePercent { get => _perChangeMaximumDecreaseRatePercent; set => SetField(ref _perChangeMaximumDecreaseRatePercent, value); }
        private DirtyValue<decimal?> _perChangeMaximumIncreaseRatePercent;
        /// <summary>
        /// ULDD - Maximum Increase Rate [ULDD.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Maximum Increase Rate")]
        public decimal? PerChangeMaximumIncreaseRatePercent { get => _perChangeMaximumIncreaseRatePercent; set => SetField(ref _perChangeMaximumIncreaseRatePercent, value); }
        private DirtyValue<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        /// <summary>
        /// ULDD - Payment Adjustment [ULDD.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Payment Adjustment")]
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get => _perChangePrincipalAndInterestPaymentAdjustmentPercent; set => SetField(ref _perChangePrincipalAndInterestPaymentAdjustmentPercent, value); }
        private DirtyValue<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Rate Adjustment Effective Date [ULDD.X58]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Rate Adjustment Effective Date")]
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get => _perChangeRateAdjustmentEffectiveDate; set => SetField(ref _perChangeRateAdjustmentEffectiveDate, value); }
        private DirtyValue<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        /// <summary>
        /// ULDD - Rate Adjustment Frequency [ULDD.X59]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Rate Adjustment Frequency")]
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get => _perChangeRateAdjustmentFrequencyMonthsCount; set => SetField(ref _perChangeRateAdjustmentFrequencyMonthsCount, value); }
        private DirtyValue<StringEnumValue<PoolAccrualRateStructureType>> _poolAccrualRateStructureType;
        /// <summary>
        /// ULDD - Pool Accrual Rate Structure Type [ULDD.X73]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Accrual Rate Structure Type")]
        public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get => _poolAccrualRateStructureType; set => SetField(ref _poolAccrualRateStructureType, value); }
        private DirtyValue<StringEnumValue<PoolAmortizationType>> _poolAmortizationType;
        /// <summary>
        /// ULDD - Pool Amortization Type [ULDD.X66]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Amortization Type")]
        public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get => _poolAmortizationType; set => SetField(ref _poolAmortizationType, value); }
        private DirtyValue<bool?> _poolAssumabilityIndicator;
        /// <summary>
        /// ULDD - Pool Assumability Indicator [ULDD.X83]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Assumability Indicator")]
        public bool? PoolAssumabilityIndicator { get => _poolAssumabilityIndicator; set => SetField(ref _poolAssumabilityIndicator, value); }
        private DirtyValue<bool?> _poolBalloonIndicator;
        /// <summary>
        /// ULDD - Pool Balloon Indicator [ULDD.X84]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Balloon Indicator")]
        public bool? PoolBalloonIndicator { get => _poolBalloonIndicator; set => SetField(ref _poolBalloonIndicator, value); }
        private DirtyValue<DateTime?> _poolCertificatePaymentDate;
        /// <summary>
        /// ULDD Ginnie Pool Certificate Payment Date [ULDD.GNM.PoolCertPaymtDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Certificate Payment Date")]
        public DateTime? PoolCertificatePaymentDate { get => _poolCertificatePaymentDate; set => SetField(ref _poolCertificatePaymentDate, value); }
        private DirtyValue<StringEnumValue<PoolClassType>> _poolClassType;
        /// <summary>
        /// ULDD Ginnie Pool Class Type [ULDD.GNM.PoolClassType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Class Type")]
        public StringEnumValue<PoolClassType> PoolClassType { get => _poolClassType; set => SetField(ref _poolClassType, value); }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _poolConcurrentTransferIndicator;
        /// <summary>
        /// ULDD Ginnie Pool Concurrent Transfer Indicator [ULDD.GNM.PoolConcurTrnsfrIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Concurrent Transfer Indicator")]
        public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get => _poolConcurrentTransferIndicator; set => SetField(ref _poolConcurrentTransferIndicator, value); }
        private DirtyValue<int?> _poolCurrentLoanCount;
        /// <summary>
        /// ULDD Ginnie Pool Current Loan Count [ULDD.GNM.PoolCurLoanCount]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Current Loan Count")]
        public int? PoolCurrentLoanCount { get => _poolCurrentLoanCount; set => SetField(ref _poolCurrentLoanCount, value); }
        private DirtyValue<decimal?> _poolCurrentPrincipalBalanceAmount;
        /// <summary>
        /// ULDD Ginnie Pool Current Princial Balance Amount [ULDD.GNM.PoolCurPrinBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Pool Current Princial Balance Amount")]
        public decimal? PoolCurrentPrincipalBalanceAmount { get => _poolCurrentPrincipalBalanceAmount; set => SetField(ref _poolCurrentPrincipalBalanceAmount, value); }
        private DirtyValue<string> _poolDocumentCustodianID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Document Custodian ID [ULDD.X156]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Document Custodian ID")]
        public string PoolDocumentCustodianID { get => _poolDocumentCustodianID; set => SetField(ref _poolDocumentCustodianID, value); }
        private DirtyValue<decimal?> _poolFixedServicingFeePercent;
        /// <summary>
        /// ULDD - Pool Fixed Servicing Fee Percent [ULDD.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Fixed Servicing Fee Percent")]
        public decimal? PoolFixedServicingFeePercent { get => _poolFixedServicingFeePercent; set => SetField(ref _poolFixedServicingFeePercent, value); }
        private DirtyValue<string> _poolIdentifier;
        /// <summary>
        /// ULDD - Pool ID [ULDD.X65]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool ID")]
        public string PoolIdentifier { get => _poolIdentifier; set => SetField(ref _poolIdentifier, value); }
        private DirtyValue<StringEnumValue<PoolingMethodType>> _poolingMethodType;
        /// <summary>
        /// ULDD Ginnie Pooling Method Type [ULDD.GNM.PoolingMethodType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pooling Method Type")]
        public StringEnumValue<PoolingMethodType> PoolingMethodType { get => _poolingMethodType; set => SetField(ref _poolingMethodType, value); }
        private DirtyValue<DateTime?> _poolInterestAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD Ginnie Pool Interest Adjustment Effective Date [ULDD.GNM.PoolIntAdjEffDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Interest Adjustment Effective Date")]
        public DateTime? PoolInterestAdjustmentEffectiveDate { get => _poolInterestAdjustmentEffectiveDate; set => SetField(ref _poolInterestAdjustmentEffectiveDate, value); }
        private DirtyValue<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Pool Interest Adjustment Index Lead Days [ULDD.X82]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Adjustment Index Lead Days")]
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get => _poolInterestAdjustmentIndexLeadDaysCount; set => SetField(ref _poolInterestAdjustmentIndexLeadDaysCount, value); }
        private DirtyValue<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Pool Interest and Payment Adjustment Index Lead Days [ULDD.X81]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest and Payment Adjustment Index Lead Days")]
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; set => SetField(ref _poolInterestAndPaymentAdjustmentIndexLeadDaysCount, value); }
        private DirtyValue<bool?> _poolInterestOnlyIndicator;
        /// <summary>
        /// ULDD - Pool Interest Only [ULDD.X80]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Only")]
        public bool? PoolInterestOnlyIndicator { get => _poolInterestOnlyIndicator; set => SetField(ref _poolInterestOnlyIndicator, value); }
        private DirtyValue<decimal?> _poolInterestRateRoundingPercent;
        /// <summary>
        /// ULDD - Pool Interest Rate Rounding [ULDD.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Interest Rate Rounding")]
        public decimal? PoolInterestRateRoundingPercent { get => _poolInterestRateRoundingPercent; set => SetField(ref _poolInterestRateRoundingPercent, value); }
        private DirtyValue<StringEnumValue<PoolInterestRateRoundingType>> _poolInterestRateRoundingType;
        /// <summary>
        /// ULDD - Pool Interest Rate Rounding Type [ULDD.X78]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Rate Rounding Type")]
        public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get => _poolInterestRateRoundingType; set => SetField(ref _poolInterestRateRoundingType, value); }
        private DirtyValue<string> _poolInvestorProductPlanIdentifier;
        /// <summary>
        /// ULDD - Pool Investor Product Plan ID [ULDD.X67]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Investor Product Plan ID")]
        public string PoolInvestorProductPlanIdentifier { get => _poolInvestorProductPlanIdentifier; set => SetField(ref _poolInvestorProductPlanIdentifier, value); }
        private DirtyValue<DateTime?> _poolIssueDate;
        /// <summary>
        /// ULDD - Pool Issue Date [ULDD.X68]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Issue Date")]
        public DateTime? PoolIssueDate { get => _poolIssueDate; set => SetField(ref _poolIssueDate, value); }
        private DirtyValue<string> _poolIssuerTransferee;
        /// <summary>
        /// ULDD Ginnie Pool Issuer Transferee [ULDD.GNM.PoolIssuerTransferee]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Issuer Transferee")]
        public string PoolIssuerTransferee { get => _poolIssuerTransferee; set => SetField(ref _poolIssuerTransferee, value); }
        private DirtyValue<decimal?> _poolMarginRatePercent;
        /// <summary>
        /// ULDD - Pool Margin Rate [ULDD.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Margin Rate")]
        public decimal? PoolMarginRatePercent { get => _poolMarginRatePercent; set => SetField(ref _poolMarginRatePercent, value); }
        private DirtyValue<DateTime?> _poolMaturityDate;
        /// <summary>
        /// ULDD Ginnie Pool Maturity Date [ULDD.GNM.PoolMaturityDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Maturity Date")]
        public DateTime? PoolMaturityDate { get => _poolMaturityDate; set => SetField(ref _poolMaturityDate, value); }
        private DirtyValue<int?> _poolMaturityPeriodCount;
        /// <summary>
        /// ULDD Ginnie Pool Maturity Period Count [ULDD.GNM.PoolMaturityPeriodCount]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Maturity Period Count")]
        public int? PoolMaturityPeriodCount { get => _poolMaturityPeriodCount; set => SetField(ref _poolMaturityPeriodCount, value); }
        private DirtyValue<decimal?> _poolMaximumAccrualRatePercent;
        /// <summary>
        /// ULDD - Pool Maximum Accrual Rate [ULDD.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Maximum Accrual Rate")]
        public decimal? PoolMaximumAccrualRatePercent { get => _poolMaximumAccrualRatePercent; set => SetField(ref _poolMaximumAccrualRatePercent, value); }
        private DirtyValue<decimal?> _poolMinimumAccrualRatePercent;
        /// <summary>
        /// ULDD - Pool Minimum Accrual Rate [ULDD.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Minimum Accrual Rate")]
        public decimal? PoolMinimumAccrualRatePercent { get => _poolMinimumAccrualRatePercent; set => SetField(ref _poolMinimumAccrualRatePercent, value); }
        private DirtyValue<StringEnumValue<PoolMortgageType>> _poolMortgageType;
        /// <summary>
        /// ULDD - Pool Mortgage Type [ULDD.X69]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Mortgage Type")]
        public StringEnumValue<PoolMortgageType> PoolMortgageType { get => _poolMortgageType; set => SetField(ref _poolMortgageType, value); }
        private DirtyValue<int?> _poolScheduledRemittancePaymentDay;
        /// <summary>
        /// ULDD - Pool Scheduled Remittance Payment Day [ULDD.X86]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Scheduled Remittance Payment Day")]
        public int? PoolScheduledRemittancePaymentDay { get => _poolScheduledRemittancePaymentDay; set => SetField(ref _poolScheduledRemittancePaymentDay, value); }
        private DirtyValue<decimal?> _poolSecurityIssueDateInterestRatePercent;
        /// <summary>
        /// ULDD - Pool Security Issue Date Interest Rate [ULDD.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Security Issue Date Interest Rate")]
        public decimal? PoolSecurityIssueDateInterestRatePercent { get => _poolSecurityIssueDateInterestRatePercent; set => SetField(ref _poolSecurityIssueDateInterestRatePercent, value); }
        private DirtyValue<string> _poolSellerID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Seller ID [ULDD.X157]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Seller ID")]
        public string PoolSellerID { get => _poolSellerID; set => SetField(ref _poolSellerID, value); }
        private DirtyValue<string> _poolServicerID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Servicer ID [ULDD.X158]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Servicer ID")]
        public string PoolServicerID { get => _poolServicerID; set => SetField(ref _poolServicerID, value); }
        private DirtyValue<StringEnumValue<PoolStructureType>> _poolStructureType;
        /// <summary>
        /// ULDD - Pool Structure Type [ULDD.X71]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Structure Type")]
        public StringEnumValue<PoolStructureType> PoolStructureType { get => _poolStructureType; set => SetField(ref _poolStructureType, value); }
        private DirtyValue<string> _poolSuffixIdentifier;
        /// <summary>
        /// ULDD - Pool Suffix ID [ULDD.X72]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Suffix ID")]
        public string PoolSuffixIdentifier { get => _poolSuffixIdentifier; set => SetField(ref _poolSuffixIdentifier, value); }
        private DirtyValue<DateTime?> _priceLockDatetime;
        /// <summary>
        /// ULDD - Price Lock Date Time [ULDD.X17]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Price Lock Date Time")]
        public DateTime? PriceLockDatetime { get => _priceLockDatetime; set => SetField(ref _priceLockDatetime, value); }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonType>> _primaryMIAbsenceReasonType;
        /// <summary>
        /// ULDD - Primary Mortgage Insurance Absence Reason [ULDD.X51]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Primary Mortgage Insurance Absence Reason")]
        public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMIAbsenceReasonType { get => _primaryMIAbsenceReasonType; set => SetField(ref _primaryMIAbsenceReasonType, value); }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription>> _primaryMIAbsenceReasonTypeOtherDescription;
        /// <summary>
        /// ULDD - Primary MI Absence Reason Type Other Description [ULDD.X52]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Primary MI Absence Reason Type Other Description")]
        public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMIAbsenceReasonTypeOtherDescription { get => _primaryMIAbsenceReasonTypeOtherDescription; set => SetField(ref _primaryMIAbsenceReasonTypeOtherDescription, value); }
        private DirtyValue<StringEnumValue<ProjectAttachmentType>> _projectAttachmentType;
        /// <summary>
        /// Project Attachment Type [ULDD.X143]
        /// </summary>
        [LoanFieldProperty(Description = "Project Attachment Type")]
        public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get => _projectAttachmentType; set => SetField(ref _projectAttachmentType, value); }
        private DirtyValue<StringEnumValue<ProjectDesignType>> _projectDesignType;
        /// <summary>
        /// Project Design Type [ULDD.X140]
        /// </summary>
        [LoanFieldProperty(Description = "Project Design Type")]
        public StringEnumValue<ProjectDesignType> ProjectDesignType { get => _projectDesignType; set => SetField(ref _projectDesignType, value); }
        private DirtyValue<int?> _projectUnitCount;
        /// <summary>
        /// ULDD Project Unit Count [ULDD.X176]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Project Unit Count")]
        public int? ProjectUnitCount { get => _projectUnitCount; set => SetField(ref _projectUnitCount, value); }
        private DirtyValue<DateTime?> _propertyValuationEffectiveDate;
        /// <summary>
        /// ULDD - Property Valuation Effective Date [ULDD.X30]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Property Valuation Effective Date")]
        public DateTime? PropertyValuationEffectiveDate { get => _propertyValuationEffectiveDate; set => SetField(ref _propertyValuationEffectiveDate, value); }
        private DirtyValue<StringEnumValue<PropertyValuationMethodType>> _propertyValuationMethodType;
        /// <summary>
        /// ULDD - Property Valuation Method Type [ULDD.X29]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Property Valuation Method Type")]
        public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get => _propertyValuationMethodType; set => SetField(ref _propertyValuationMethodType, value); }
        private DirtyValue<StringEnumValue<PropertyValuationOther>> _propertyValuationOther;
        /// <summary>
        /// ULDD Property Valuation Method Type "Other" [ULDD.X190]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Property Valuation Method Type \"Other\"")]
        public StringEnumValue<PropertyValuationOther> PropertyValuationOther { get => _propertyValuationOther; set => SetField(ref _propertyValuationOther, value); }
        private DirtyValue<decimal?> _refinanceCashOutAmount;
        /// <summary>
        /// Refinance Cash Out Amount [ULDD.RefinanceCashOutAmount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Refinance Cash Out Amount")]
        public decimal? RefinanceCashOutAmount { get => _refinanceCashOutAmount; set => SetField(ref _refinanceCashOutAmount, value); }
        private DirtyValue<StringEnumValue<RefinanceCashOutDeterminationType>> _refinanceCashOutDeterminationType;
        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X18]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Refinance Cash Out Type")]
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => _refinanceCashOutDeterminationType; set => SetField(ref _refinanceCashOutDeterminationType, value); }
        private DirtyValue<bool?> _relatedLoanAffordableIndicator;
        /// <summary>
        /// Related Loan Affordable Loan Indicator [ULDD.X194]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan Affordable Loan Indicator")]
        public bool? RelatedLoanAffordableIndicator { get => _relatedLoanAffordableIndicator; set => SetField(ref _relatedLoanAffordableIndicator, value); }
        private DirtyValue<bool?> _relatedLoanBalloonIndicator;
        /// <summary>
        /// ULDD Related Loan Balloon Indicator [ULDD.X175]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Balloon Indicator")]
        public bool? RelatedLoanBalloonIndicator { get => _relatedLoanBalloonIndicator; set => SetField(ref _relatedLoanBalloonIndicator, value); }
        private DirtyValue<bool?> _relatedLoanHELOCIndicator;
        /// <summary>
        /// Related Loan HELOC Indicator [ULDD.X132]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan HELOC Indicator")]
        public bool? RelatedLoanHELOCIndicator { get => _relatedLoanHELOCIndicator; set => SetField(ref _relatedLoanHELOCIndicator, value); }
        private DirtyValue<bool?> _relatedLoanIndicator;
        /// <summary>
        /// Related Loan [ULDD.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan")]
        public bool? RelatedLoanIndicator { get => _relatedLoanIndicator; set => SetField(ref _relatedLoanIndicator, value); }
        private DirtyValue<StringEnumValue<RelatedLoanInvestorType>> _relatedLoanInvestorType;
        /// <summary>
        /// ULDD - Related Loan Investor Type [ULDD.X46]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Related Loan Investor Type")]
        public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get => _relatedLoanInvestorType; set => SetField(ref _relatedLoanInvestorType, value); }
        private DirtyValue<int?> _relatedLoanMaturityPeriodCount;
        /// <summary>
        /// ULDD Related Loan Maturity Period Count [ULDD.X173]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Maturity Period Count")]
        public int? RelatedLoanMaturityPeriodCount { get => _relatedLoanMaturityPeriodCount; set => SetField(ref _relatedLoanMaturityPeriodCount, value); }
        private DirtyValue<DateTime?> _relatedLoanNoteDate;
        /// <summary>
        /// Related Loan Note Date [ULDD.X183]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan Note Date")]
        public DateTime? RelatedLoanNoteDate { get => _relatedLoanNoteDate; set => SetField(ref _relatedLoanNoteDate, value); }
        private DirtyValue<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        /// <summary>
        /// ULDD Related Loan Scheduled First Payment Date [ULDD.X174]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Scheduled First Payment Date")]
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get => _relatedLoanScheduledFirstPaymentDate; set => SetField(ref _relatedLoanScheduledFirstPaymentDate, value); }
        private DirtyValue<DateTime?> _relatedLoanStateDateAtClosing;
        /// <summary>
        /// ULDD - Related Loan State Date At Closing [ULDD.X112]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Related Loan State Date At Closing")]
        public DateTime? RelatedLoanStateDateAtClosing { get => _relatedLoanStateDateAtClosing; set => SetField(ref _relatedLoanStateDateAtClosing, value); }
        private DirtyValue<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        /// <summary>
        /// ULDD - Related Loan Unpaid Principal Balance Amount [ULDD.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Related Loan Unpaid Principal Balance Amount")]
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get => _relatedLoanUnpaidPrincipalBalanceAmount; set => SetField(ref _relatedLoanUnpaidPrincipalBalanceAmount, value); }
        private DirtyValue<bool?> _relocationLoanIndicator;
        /// <summary>
        /// ULDD - Relocation Loan [ULDD.X8]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Relocation Loan")]
        public bool? RelocationLoanIndicator { get => _relocationLoanIndicator; set => SetField(ref _relocationLoanIndicator, value); }
        private DirtyValue<StringEnumValue<PartyType>> _rEOMarketingPartyType;
        /// <summary>
        /// ULDD - REO Marketing Party [ULDD.X48]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - REO Marketing Party")]
        public StringEnumValue<PartyType> REOMarketingPartyType { get => _rEOMarketingPartyType; set => SetField(ref _rEOMarketingPartyType, value); }
        private DirtyValue<bool?> _secondLienIsDeliveredIndicator;
        /// <summary>
        /// Second lien is being delivered with this loan [ULDD.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Second lien is being delivered with this loan")]
        public bool? SecondLienIsDeliveredIndicator { get => _secondLienIsDeliveredIndicator; set => SetField(ref _secondLienIsDeliveredIndicator, value); }
        private DirtyValue<decimal?> _securityOriginalSubscriptionAmount;
        /// <summary>
        /// ULDD Ginnie Security Original Subscription Amount [ULDD.GNM.SecurityOrigSubscrAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Security Original Subscription Amount")]
        public decimal? SecurityOriginalSubscriptionAmount { get => _securityOriginalSubscriptionAmount; set => SetField(ref _securityOriginalSubscriptionAmount, value); }
        private DirtyValue<DateTime?> _securityTradeBookEntryDate;
        /// <summary>
        /// ULDD - Security Trade Book Entry Date [ULDD.X87]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Security Trade Book Entry Date")]
        public DateTime? SecurityTradeBookEntryDate { get => _securityTradeBookEntryDate; set => SetField(ref _securityTradeBookEntryDate, value); }
        private DirtyValue<string> _sellerID;
        /// <summary>
        /// Uldd SellerID
        /// </summary>
        public string SellerID { get => _sellerID; set => SetField(ref _sellerID, value); }
        private DirtyValue<string> _sellerLoanIdentifier;
        /// <summary>
        /// ULDD - Seller Loan ID [ULDD.X21]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Seller Loan ID")]
        public string SellerLoanIdentifier { get => _sellerLoanIdentifier; set => SetField(ref _sellerLoanIdentifier, value); }
        private DirtyValue<string> _servicerID;
        /// <summary>
        /// ULDD - Fannie Mae - Servicer ID [ULDD.X116]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Servicer ID")]
        public string ServicerID { get => _servicerID; set => SetField(ref _servicerID, value); }
        private DirtyValue<string> _servicerLoanIdentifier;
        /// <summary>
        /// ULDD - Servicer Loan ID [ULDD.X94]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Servicer Loan ID")]
        public string ServicerLoanIdentifier { get => _servicerLoanIdentifier; set => SetField(ref _servicerLoanIdentifier, value); }
        private DirtyValue<bool?> _sharedEquityIndicator;
        /// <summary>
        /// ULDD - Shared Equity [ULDD.X9]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Shared Equity")]
        public bool? SharedEquityIndicator { get => _sharedEquityIndicator; set => SetField(ref _sharedEquityIndicator, value); }
        private DirtyValue<bool?> _siteBuiltIndicator;
        /// <summary>
        /// Site Built [ULDD.X144]
        /// </summary>
        [LoanFieldProperty(Description = "Site Built")]
        public bool? SiteBuiltIndicator { get => _siteBuiltIndicator; set => SetField(ref _siteBuiltIndicator, value); }
        private DirtyValue<bool?> _specialFloodHazardAreaIndicator;
        /// <summary>
        /// ULDD Special Flood Hazard Area [ULDD.X178]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Special Flood Hazard Area")]
        public bool? SpecialFloodHazardAreaIndicator { get => _specialFloodHazardAreaIndicator; set => SetField(ref _specialFloodHazardAreaIndicator, value); }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        /// <summary>
        /// ULDD - Subsequent Maximum Decrease Rate [ULDD.X168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Subsequent Maximum Decrease Rate")]
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get => _subsequentPerChangeMaximumDecreaseRatePercent; set => SetField(ref _subsequentPerChangeMaximumDecreaseRatePercent, value); }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        /// <summary>
        /// ULDD - Subsequent Maximum Increase Rate [ULDD.X169]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Subsequent Maximum Increase Rate")]
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get => _subsequentPerChangeMaximumIncreaseRatePercent; set => SetField(ref _subsequentPerChangeMaximumIncreaseRatePercent, value); }
        private DirtyValue<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Effective Date [ULDD.X166]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Subsequent Rate Adjustment Effective Date")]
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get => _subsequentPerChangeRateAdjustmentEffectiveDate; set => SetField(ref _subsequentPerChangeRateAdjustmentEffectiveDate, value); }
        private DirtyValue<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Frequency [ULDD.X167]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Subsequent Rate Adjustment Frequency")]
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; set => SetField(ref _subsequentPerChangeRateAdjustmentFrequencyMonthsCount, value); }
        private DirtyValue<bool?> _temporaryBuydownIndicator;
        /// <summary>
        /// ULDD - Temporary Buydown [ULDD.X181]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Temporary Buydown")]
        public bool? TemporaryBuydownIndicator { get => _temporaryBuydownIndicator; set => SetField(ref _temporaryBuydownIndicator, value); }
        private DirtyValue<int?> _totalMortgagedPropertiesCount;
        /// <summary>
        /// Total Mortgaged Properties Count [ULDD.TotalMortgagedPropertiesCount]
        /// </summary>
        [LoanFieldProperty(Description = "Total Mortgaged Properties Count")]
        public int? TotalMortgagedPropertiesCount { get => _totalMortgagedPropertiesCount; set => SetField(ref _totalMortgagedPropertiesCount, value); }
        private DirtyValue<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - First Unit Subject Property Gross Rent [ULDD.X171]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - First Unit Subject Property Gross Rent")]
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get => _unit1SubjectPropertyGrossRentalIncome; set => SetField(ref _unit1SubjectPropertyGrossRentalIncome, value); }
        private DirtyValue<int?> _unit1TotalBedrooms;
        /// <summary>
        /// ULDD - First Unit Bedrooms [ULDD.X170]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - First Unit Bedrooms")]
        public int? Unit1TotalBedrooms { get => _unit1TotalBedrooms; set => SetField(ref _unit1TotalBedrooms, value); }
        private DirtyValue<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Second Unit Subject Property Gross Rent [ULDD.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Second Unit Subject Property Gross Rent")]
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get => _unit2SubjectPropertyGrossRentalIncome; set => SetField(ref _unit2SubjectPropertyGrossRentalIncome, value); }
        private DirtyValue<int?> _unit2TotalBedrooms;
        /// <summary>
        /// ULDD - Second Unit Bedrooms [ULDD.X160]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Second Unit Bedrooms")]
        public int? Unit2TotalBedrooms { get => _unit2TotalBedrooms; set => SetField(ref _unit2TotalBedrooms, value); }
        private DirtyValue<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Third Unit Subject Property Gross Rent [ULDD.X163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Third Unit Subject Property Gross Rent")]
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get => _unit3SubjectPropertyGrossRentalIncome; set => SetField(ref _unit3SubjectPropertyGrossRentalIncome, value); }
        private DirtyValue<int?> _unit3TotalBedrooms;
        /// <summary>
        /// ULDD - Third Unit Bedrooms [ULDD.X162]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Third Unit Bedrooms")]
        public int? Unit3TotalBedrooms { get => _unit3TotalBedrooms; set => SetField(ref _unit3TotalBedrooms, value); }
        private DirtyValue<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Fourth Unit Subject Property Gross Rent [ULDD.X165]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Fourth Unit Subject Property Gross Rent")]
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get => _unit4SubjectPropertyGrossRentalIncome; set => SetField(ref _unit4SubjectPropertyGrossRentalIncome, value); }
        private DirtyValue<int?> _unit4TotalBedrooms;
        /// <summary>
        /// ULDD - Fourth Unit Bedrooms [ULDD.X164]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fourth Unit Bedrooms")]
        public int? Unit4TotalBedrooms { get => _unit4TotalBedrooms; set => SetField(ref _unit4TotalBedrooms, value); }
        private DirtyValue<decimal?> _uPBAmount;
        /// <summary>
        /// ULDD - Unpaid Principal Balance Amount [ULDD.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Unpaid Principal Balance Amount")]
        public decimal? UPBAmount { get => _uPBAmount; set => SetField(ref _uPBAmount, value); }
        private DirtyValue<string> _wareHouseLenderId;
        /// <summary>
        /// ULDD WareHouse Lender ID [ULDD.X191]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD WareHouse Lender ID")]
        public string WareHouseLenderId { get => _wareHouseLenderId; set => SetField(ref _wareHouseLenderId, value); }
        private DirtyValue<bool?> _wareHouseLenderIndicator;
        /// <summary>
        /// WareHouse Lender Indicator [ULDD.X193]
        /// </summary>
        [LoanFieldProperty(Description = "WareHouse Lender Indicator")]
        public bool? WareHouseLenderIndicator { get => _wareHouseLenderIndicator; set => SetField(ref _wareHouseLenderIndicator, value); }
    }
}