using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Uldd
/// </summary>
public sealed partial class Uldd : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// ACH ABA Routing And Transit Identifier [ULDD.GNM.ACHABARoutingAndTransitIdentifier]
    /// </summary>
    public string? AchAbaRoutingAndTransitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH ABARouting And Transit # [ULDD.GNM.ACHABARtngAndTrnstNmbr]
    /// </summary>
    public string? AchAbaRoutingAndTransitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH Bank Account Description [ULDD.GNM.ACHBnkAccntDscr]
    /// </summary>
    public string? AchBankAccountDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH Bank Account Identifier [ULDD.GNM.ACHBnkAccntIdentfr]
    /// </summary>
    public string? AchBankAccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH Bank Account Purpose Transit Identifier [ULDD.GNM.ACHBnkAccntPrpsTrnstIdntfr]
    /// </summary>
    public string? AchBankAccountPurposeTransitIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH Bank Account Purpose Type [ULDD.GNM.ACHBnkAccntPrpsTyp]
    /// </summary>
    public StringEnumValue<ACHBankAccountPurposeType> AchBankAccountPurposeType { get => GetValue<StringEnumValue<ACHBankAccountPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// ACH Institution Telegraphic Name [ULDD.GNM.ACHInstttnTlgrphcAbbrName]
    /// </summary>
    public string? AchInstitutionTelegraphicAbbreviationName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ACH Receiver Subaccount Name [ULDD.GNM.ACHRcvrSbccntName]
    /// </summary>
    public string? AchReceiverSubaccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Additional Principal Amount has been Paid from Origination to Date [ULDD.X2]
    /// </summary>
    public bool? AdditionalPrincipalAmountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Aggregate Loan Curtailment Amount [ULDD.X3]
    /// </summary>
    public decimal? AggregateLoanCurtailmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Appraisal ID [ULDD.X31]
    /// </summary>
    public string? AppraisalIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Attachment Type [ULDD.X177]
    /// </summary>
    public StringEnumValue<AttachmentType> AttachmentType { get => GetValue<StringEnumValue<AttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - AVM Model Name Type [ULDD.X32]
    /// </summary>
    public StringEnumValue<AVMModelNameType> AvmModelNameType { get => GetValue<StringEnumValue<AVMModelNameType>>(); set => SetValue(value); }

    /// <summary>
    /// Balloon Reset [ULDD.X159]
    /// </summary>
    public bool? BalloonResetIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Base Guaranty Fee [ULDD.X40]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BaseGuarantyFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Bond Finance Pool Indicator [ULDD.GNM.BondFinPoolIndic]
    /// </summary>
    public StringEnumValue<TrueOrFalse> BondFinancePool { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Bond Finance Program Name [ULDD.GNM.BondFinProgName]
    /// </summary>
    public string? BondFinanceProgramName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Bond Finance Program Type [ULDD.GNM.BondFinProgType]
    /// </summary>
    public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get => GetValue<StringEnumValue<BondFinanceProgramType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Borrower Mailing Address is same as the Property Address [ULDD.X26]
    /// </summary>
    public bool? BorrowerMailToAddressSameasPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Type [ULDD.X150]
    /// </summary>
    public StringEnumValue<UlddBorrowerType> BorrowerType { get => GetValue<StringEnumValue<UlddBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Capitalized Loan [ULDD.X7]
    /// </summary>
    public bool? CapitalizedLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Certificate Identifier [ULDD.GNM.CertId]
    /// </summary>
    public string? CertificateIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Certificate Maturity Date [ULDD.GNM.CertMaturityDate]
    /// </summary>
    public DateTime? CertificateMaturityDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Certificate Principal Balance Amount [ULDD.GNM.CertPrinBalAmt]
    /// </summary>
    public decimal? CertificatePrincipalBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Certificate Type [ULDD.GNM.CertType]
    /// </summary>
    public StringEnumValue<TrueOrFalse> CertificateType { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST2CONTRIBUTIONAMOUNT]
    /// </summary>
    public decimal? ClosingCost2ContributionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST2FUNDSTYPE]
    /// </summary>
    public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get => GetValue<StringEnumValue<ClosingCostFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST2FUNDSTYPEOTHERDESC]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
    public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST2SOURCETYPE]
    /// </summary>
    public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get => GetValue<StringEnumValue<ClosingCostSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST2SOURCETYPEOTHERDESC]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST3CONTRIBUTIONAMOUNT]
    /// </summary>
    public decimal? ClosingCost3ContributionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST3FUNDSTYPE]
    /// </summary>
    public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get => GetValue<StringEnumValue<ClosingCostFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST3FUNDSTYPEOTHERDESC]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
    public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST3SOURCETYPE]
    /// </summary>
    public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get => GetValue<StringEnumValue<ClosingCostSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST3SOURCETYPEOTHERDESC]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST4CONTRIBUTIONAMOUNT]
    /// </summary>
    public decimal? ClosingCost4ContributionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST4FUNDSTYPE]
    /// </summary>
    public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get => GetValue<StringEnumValue<ClosingCostFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST4FUNDSTYPEOTHERDESC]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
    public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST4SOURCETYPE]
    /// </summary>
    public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get => GetValue<StringEnumValue<ClosingCostSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST4SOURCETYPEOTHERDESC]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.X105]
    /// </summary>
    public decimal? ClosingCostContributionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.X106]
    /// </summary>
    public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get => GetValue<StringEnumValue<ClosingCostFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.X107]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
    public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.X108]
    /// </summary>
    public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get => GetValue<StringEnumValue<ClosingCostSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.X109]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Co-Borrower Country Code [ULDD.X155]
    /// </summary>
    public string? CoBorrowerCountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Co-Borrower Mailing Address is same as the Property Address [ULDD.X154]
    /// </summary>
    public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// co Borrower Type [ULDD.X151]
    /// </summary>
    public StringEnumValue<UlddBorrowerType> CoBorrowerType { get => GetValue<StringEnumValue<UlddBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Project Status Type [ULDD.X28]
    /// </summary>
    public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get => GetValue<StringEnumValue<CondominiumProjectStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Construction Method Type [ULDD.X172]
    /// </summary>
    public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get => GetValue<StringEnumValue<ConstructionMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// Construction Method Type [ULDD.GNM.CnstrctnMthdTypOthrDscr]
    /// </summary>
    public string? ConstructionMethodTypeOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Construction - Perm Closing Feature [ULDD.X63]
    /// </summary>
    public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get => GetValue<StringEnumValue<ConstructionToPermanentClosingFeatureType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Construction - Perm Closing Type [ULDD.X64]
    /// </summary>
    public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => GetValue<StringEnumValue<ConstructionToPermanentClosingType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Convertible Status Type [ULDD.X91]
    /// </summary>
    public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get => GetValue<StringEnumValue<ConvertibleStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Counseling Format [ULDD.X24]
    /// </summary>
    public StringEnumValue<CounselingFormatType> CounselingFormatType { get => GetValue<StringEnumValue<CounselingFormatType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Counseling Format Type Other Description [ULDD.X25]
    /// </summary>
    public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get => GetValue<StringEnumValue<CounselingFormatTypeOtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Counsel Type Other [ULDD.X152]
    /// </summary>
    public StringEnumValue<CounselTypeOther> CounselTypeOther { get => GetValue<StringEnumValue<CounselTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Country Code [ULDD.X27]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Credit Repository Source Type [ULDD.X198]
    /// </summary>
    public StringEnumValue<CreditRepositorySourceType> CreditRepositorySourceType { get => GetValue<StringEnumValue<CreditRepositorySourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Credit Score Impairment Type [ULDD.X104]
    /// </summary>
    public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get => GetValue<StringEnumValue<CreditScoreImpairmentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Current Accrued Interest [ULDD.X15]
    /// </summary>
    public decimal? CurrentAccruedInterestAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Number of Delinquent Payments Over Past 12 Months [ULDD.X56]
    /// </summary>
    public int? DelinquentPaymentsOverPastTwelveMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Document Custodian ID [ULDD.X114]
    /// </summary>
    public string? DocumentCustodianId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Document Required Indicator [ULDD.GNM.DocReqIndic]
    /// </summary>
    public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Document Submission Indicator [ULDD.GNM.DocSubmissionIndic]
    /// </summary>
    public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// Down Payment Funds Type [ULDD.GNM.DwnPymntFndsType]
    /// </summary>
    public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get => GetValue<StringEnumValue<DownPaymentFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Down Payment Other Type Description [ULDD.X113]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Grant\"]")]
    public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment Source Type [ULDD.X89]
    /// </summary>
    public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get => GetValue<StringEnumValue<DownPaymentSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment SourceType Other Description [ULDD.X90]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - eNote Indicator [ULDD.X196]
    /// </summary>
    public bool? ENoteIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie ARM Index Type [ULDD.FNM.ARMIndexType]
    /// </summary>
    public StringEnumValue<FannieARMIndexType> FannieArmIndexType { get => GetValue<StringEnumValue<FannieARMIndexType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Automatic Underwriting Decision [ULDD.FNM.AutoUWDec]
    /// </summary>
    public StringEnumValue<FannieAutoUWDec> FannieAutoUwDec { get => GetValue<StringEnumValue<FannieAutoUWDec>>(); set => SetValue(value); }

    /// <summary>
    /// Base LTV Ratio Percent [ULDD.X186]
    /// </summary>
    public int? FannieBltv { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Uldd FannieBorrowerFirstName
    /// </summary>
    public string? FannieBorrowerFirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Uldd FannieBorrowerMiddleName
    /// </summary>
    public string? FannieBorrowerMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Buy down Contributer [ULDD.X137]
    /// </summary>
    public StringEnumValue<FannieBuydownContributer> FannieBuydownContributor { get => GetValue<StringEnumValue<FannieBuydownContributer>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Mae MORNETPlus CLTV [ULDD.FNM.MORNET.X76]
    /// </summary>
    public int? FannieCltv { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Uldd FannieCoBorrowerFirstName
    /// </summary>
    public string? FannieCoBorrowerFirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Uldd FannieCoBorrowerMiddleName
    /// </summary>
    public string? FannieCoBorrowerMiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Credit Score Provider Name [ULDD.FNM.CreditScoreProviderName]
    /// </summary>
    public string? FannieCreditScoreProviderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Flood Special Feature Code [ULDD.FNM.FloodSpecialFeatureCode]
    /// </summary>
    public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get => GetValue<StringEnumValue<FannieFloodSpecialFeatureCode>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Mae MORNETPlus HCLTV and HTLTV [ULDD.FNM.MORNET.X77]
    /// </summary>
    public int? FannieHclTv { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie - Investor Ownership of the Loan [ULDD.FNM.X43]
    /// </summary>
    public int? FannieInvestorOwnershipPercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fannie Legal Entity Type [ULDD.X120]
    /// </summary>
    public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get => GetValue<StringEnumValue<FannieLegalEntityType>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fannie Legal Entity Type Other [ULDD.X122]
    /// </summary>
    public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get => GetValue<StringEnumValue<FannieLegalEntityTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.FNM.X50]
    /// </summary>
    public decimal? FannieLenderPaidMiInterestRateAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Mae Loan Program Identifier [ULDD.FNM.LoanProgramIdentifier]
    /// </summary>
    public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get => GetValue<StringEnumValue<FannieLoanProgramIdentifier>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Mae MORNETPlus LTV [ULDD.FNM.MORNET.X75]
    /// </summary>
    public int? FannieLtv { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie MI Company Name Type Other [ULDD.X136]
    /// </summary>
    public StringEnumValue<FannieMICompanyNameTypeOther> FannieMiCompanyNameTypeOther { get => GetValue<StringEnumValue<FannieMICompanyNameTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Insurance Mtg Ins Coverage Factor [ULDD.FNM.430]
    /// </summary>
    public int? FannieMiCoveragePercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type [ULDD.FNM.X1172]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Other\"]")]
    public StringEnumValue<LoanType> FannieMortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie - Pool Ownership [ULDD.FNM.X70]
    /// </summary>
    public int? FanniePoolOwnershipPercent { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Project Classification Type [ULDD.X142]
    /// </summary>
    public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get => GetValue<StringEnumValue<FannieProjectClassificationType>>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Form Type [ULDD.FNM.PropertyFormType]
    /// </summary>
    public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get => GetValue<StringEnumValue<FanniePropertyFormType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Trans Details Rate Spread [ULDD.FNM.HMDA.X15]
    /// </summary>
    public decimal? FannieRateSpread { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Refinance Type [ULDD.X129]
    /// </summary>
    public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get => GetValue<StringEnumValue<FannieRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Related Investor Loan ID [ULDD.FNM.RelatedInvestorLoanID]
    /// </summary>
    public string? FannieRelatedInvestorLoanId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Related Loan Amortization Type [ULDD.X131]
    /// </summary>
    public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get => GetValue<StringEnumValue<FannieRelatedLoanAmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Related Loan Lien Position [ULDD.X147]
    /// </summary>
    public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get => GetValue<StringEnumValue<FannieRelatedLoanLienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Related Loan Type [ULDD.X128]
    /// </summary>
    public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get => GetValue<StringEnumValue<FannieRelatedLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Fannie Section of the Act [ULDD.FNM.SectionOfAct]
    /// </summary>
    public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get => GetValue<StringEnumValue<FannieSectionOfAct>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Trans Details Total Loan to Value (TLTV) [ULDD.FNM.975]
    /// </summary>
    public int? FannieTlTv { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fannie Borrower Vesting Borr 1 Corp/Trust Name [ULDD.FNM.1859]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FannieTrustName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Financed Unit Count [ULDD.X139]
    /// </summary>
    public int? FinancedUnitCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// First Rate Change Payment Effective Date [ULDD.X185]
    /// </summary>
    public DateTime? FirstRateChangePaymentEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae Home Impovement Product [ULDD.X23]
    /// </summary>
    public StringEnumValue<FNMHomeImprovementProductType> FnmHomeImprovementProductType { get => GetValue<StringEnumValue<FNMHomeImprovementProductType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie ARM Index Type [ULDD.FRE.ARMIndexType]
    /// </summary>
    public StringEnumValue<FreddieARMIndexType> FreddieArmIndexType { get => GetValue<StringEnumValue<FreddieARMIndexType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Automatic Underwriting Decision [ULDD.FRE.AutoUWDec]
    /// </summary>
    public StringEnumValue<FreddieAutoUWDec> FreddieAutoUwDec { get => GetValue<StringEnumValue<FreddieAutoUWDec>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie - AVM Model Name Type Other Description [ULDD.FRE.AVMModelNameExpl]
    /// </summary>
    public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAvmModelNameTypeExpl { get => GetValue<StringEnumValue<FreddieAVMModelNameTypeExpl>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Borr Declarations Alien Status [ULDD.X123]
    /// </summary>
    public StringEnumValue<FreddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get => GetValue<StringEnumValue<FreddieBorrowerAlienStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Co Borr Declarations Alien Status [ULDD.X148]
    /// </summary>
    public StringEnumValue<FreddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get => GetValue<StringEnumValue<FreddieBorrowerAlienStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Credit Score Provider Name [ULDD.FRE.CreditScoreProviderName]
    /// </summary>
    public string? FreddieCreditScoreProviderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment Type [ULDD.FRE.DownPaymentType]
    /// </summary>
    public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get => GetValue<StringEnumValue<FreddieDownPaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 2 Source Type [ULDD.FRE.DownPmt2SourceType]
    /// </summary>
    public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get => GetValue<StringEnumValue<DownPaymentSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 2 SourceType Other Description [ULDD.FRE.DownPmt2SourceTypeExpl]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 2 Type [ULDD.FRE.DownPmt2Type]
    /// </summary>
    public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get => GetValue<StringEnumValue<FreddieDownPaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 2 Type Explanation [ULDD.FRE.DownPmt2TypeExpl]
    /// </summary>
    public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Down Payment 3 Amount [ULDD.FRE.DownPmt3Amt]
    /// </summary>
    public string? FreddieDownPmt3Amt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 3 Source Type [ULDD.FRE.DownPmt3SourceType]
    /// </summary>
    public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get => GetValue<StringEnumValue<DownPaymentSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 3 SourceType Other Description [ULDD.FRE.DownPmt3SourceTypeExpl]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 3 Type [ULDD.FRE.DownPmt3Type]
    /// </summary>
    public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get => GetValue<StringEnumValue<FreddieDownPaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 3 Type Explanation [ULDD.FRE.DownPmt3TypeExpl]
    /// </summary>
    public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Down Payment 4 Amount [ULDD.FRE.DownPmt4Amt]
    /// </summary>
    public string? FreddieDownPmt4Amt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 4 Source Type [ULDD.FRE.DownPmt4SourceType]
    /// </summary>
    public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get => GetValue<StringEnumValue<DownPaymentSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Down Payment 4 SourceType Other Description [ULDD.FRE.DownPmt4SourceTypeExpl]
    /// </summary>
    public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get => GetValue<StringEnumValue<SourceTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 4 Type [ULDD.FRE.DownPmt4Type]
    /// </summary>
    public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get => GetValue<StringEnumValue<FreddieDownPaymentType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Down Payment 4 Type Explanation [ULDD.FRE.DownPmt4TypeExpl]
    /// </summary>
    public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Explanation of Down Payment [ULDD.FRE.ExplanationOfDownPayment]
    /// </summary>
    public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get => GetValue<StringEnumValue<FundsTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Collateral Program ID [ULDD.X95]
    /// </summary>
    public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get => GetValue<StringEnumValue<FreddieInvestorCollateralProgramIdentifier>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Investor Feature ID [ULDD.X179]
    /// </summary>
    public string? FreddieInvestorFeatureIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Freddie Legal Entity Type [ULDD.X119]
    /// </summary>
    public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get => GetValue<StringEnumValue<FreddieLegalEntityType>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Freddie Legal Entity Type Other [ULDD.X121]
    /// </summary>
    public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get => GetValue<StringEnumValue<FreddieLegalEntityTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Loan Program Identifier [ULDD.FRE.LoanProgramIdentifier]
    /// </summary>
    public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get => GetValue<StringEnumValue<FreddieLoanProgramIdentifier>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Loan Type Other [ULDD.X153]
    /// </summary>
    public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get => GetValue<StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie MI Company Name Type Other [ULDD.X135]
    /// </summary>
    public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMiCompanyNameTypeOther { get => GetValue<StringEnumValue<FreddieMICompanyNameTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type [ULDD.FRE.X1172]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"HELOC\"]")]
    public StringEnumValue<LoanType> FreddieMortgageType { get => GetValue<StringEnumValue<LoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Project Classification Type [ULDD.X141]
    /// </summary>
    public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get => GetValue<StringEnumValue<FreddieProjectClassificationType>>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Form Type [ULDD.FRE.PropertyFormType]
    /// </summary>
    public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get => GetValue<StringEnumValue<PropertyFormType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Refinance Cash Out Type [ULDD.X180]
    /// </summary>
    public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get => GetValue<StringEnumValue<FreddieRefinanceCashOutDeterminationType>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Refinance Type [ULDD.X130]
    /// </summary>
    public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get => GetValue<StringEnumValue<FreddieRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Related Closed End Second Indicator [ULDD.FRE.RelatedClosedEndSecondIndicator]
    /// </summary>
    public bool? FreddieRelatedClosedEndSecondIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Related Investor Loan ID [ULDD.FRE.RelatedInvestorLoanID]
    /// </summary>
    public string? FreddieRelatedInvestorLoanId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Related Loan Investor Type [ULDD.X99]
    /// </summary>
    public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get => GetValue<StringEnumValue<FreddieRelatedLoanInvestorType>>(); set => SetValue(value); }

    /// <summary>
    /// Uldd FreddieRelatedLoanLienPosition [ULDD.X145], [ULDD.X146]
    /// </summary>
    public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get => GetValue<StringEnumValue<FreddieRelatedLoanLienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Related Loan Type [ULDD.X127]
    /// </summary>
    public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get => GetValue<StringEnumValue<FreddieRelatedLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Freddie Section of the Act [ULDD.FRE.SectionOfAct]
    /// </summary>
    public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get => GetValue<StringEnumValue<FreddieSectionOfAct>>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Underwriting Type Other [ULDD.X149]
    /// </summary>
    public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get => GetValue<StringEnumValue<FreddieUnderwritingTypeOther>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Construction Method Type [ULDD.X187]
    /// </summary>
    public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get => GetValue<StringEnumValue<GinnieConstructionMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Government Annual Premium Amount [ULDD.GNM.GovAnnlPrmAmt]
    /// </summary>
    public decimal? GinnieGovernmentAnnualPremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Type [ULDD.GNM.X1172]
    /// </summary>
    public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get => GetValue<StringEnumValue<GinnieMortgageType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Other Construction Method Type [ULDD.X188]
    /// </summary>
    public string? GinnieOtherConstructionMethodType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Government Annual Premium Percent [ULDD.GNM.GovAnnlPrmPrcnt]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GovernmentAnnualPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Government Refinance Type [ULDD.GNM.GovRefType]
    /// </summary>
    public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => GetValue<StringEnumValue<GovernmentRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// Government Upfront Premium Amount [ULDD.GNM.GovUpFrontPrmAmt]
    /// </summary>
    public decimal? GovernmentUpfrontPremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Government Upfront Premium Percent [ULDD.GNM.GovUpFrontPrmPrcnt]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GovernmentUpfrontPremiumPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Project Classification [ULDD.X182]
    /// </summary>
    public StringEnumValue<ProjectLegalStructureType> GseProjectType { get => GetValue<StringEnumValue<ProjectLegalStructureType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Guaranty Fee Add On [ULDD.X96]
    /// </summary>
    public bool? GuaranteeFeeAddOnIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Guaranty Fee After Alternate Payment Method [ULDD.X41]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Guaranty Fee [ULDD.X39]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GuarantyFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Guaranty Percent [ULDD.GNM.GrntyPrcnt]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GuarantyPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Home Owner Association EIN [ULDD.X192]
    /// </summary>
    public string? HomeOwnerAssociationEin { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Index Type [ULDD.GNM.IndxType]
    /// </summary>
    public StringEnumValue<IndexType> IndexType { get => GetValue<StringEnumValue<IndexType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Initial Fixed Period [ULDD.X6]
    /// </summary>
    public int? InitialFixedPeriodEffectiveMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Interest Accrual Type [ULDD.X12]
    /// </summary>
    public StringEnumValue<InterestAccrualType> InterestAccrualType { get => GetValue<StringEnumValue<InterestAccrualType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Interest and Payment Adjustment Index Lead Days [ULDD.X10]
    /// </summary>
    public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Interest Calculation Basis Type [ULDD.X13]
    /// </summary>
    public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get => GetValue<StringEnumValue<InterestCalculationBasisType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Interest Calculation Effective Months [ULDD.X14]
    /// </summary>
    public int? InterestCalculationEffectiveMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Interest Calculation Type [ULDD.X11]
    /// </summary>
    public StringEnumValue<InterestCalculationType> InterestCalculationType { get => GetValue<StringEnumValue<InterestCalculationType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Collateral Program ID [ULDD.X38]
    /// </summary>
    public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get => GetValue<StringEnumValue<InvestorCollateralProgramIdentifier>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Commitment ID [ULDD.X37]
    /// </summary>
    public string? InvestorCommitmentIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Feature ID [ULDD.X36]
    /// </summary>
    public string? InvestorFeatureIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Investor Feature ID Pool [ULDD.X115]
    /// </summary>
    public string? InvestorFeatureIdPool { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Ownership of the Loan [ULDD.X43]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InvestorOwnershipPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Product Plan ID [ULDD.X35]
    /// </summary>
    public string? InvestorProductPlanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Remittance Day [ULDD.X45]
    /// </summary>
    public int? InvestorRemittanceDay { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Investor Remittance Type [ULDD.X44]
    /// </summary>
    public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get => GetValue<StringEnumValue<InvestorRemittanceType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Issuer Identifier [ULDD.GNM.IssuerId]
    /// </summary>
    public string? IssuerIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Last Paid Installment Due Date [ULDD.X54]
    /// </summary>
    public DateTime? LastPaidInstallmentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Last Payment Received Date [ULDD.X53]
    /// </summary>
    public DateTime? LastPaymentReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Latest Conversion Effective Date [ULDD.X92]
    /// </summary>
    public DateTime? LatestConversionEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.X50]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LenderPaidMiInterestRateAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lender's Delivery Date [ULDD.X133]
    /// </summary>
    public DateTime? LendersDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Acquisition UPB [ULDD.X42]
    /// </summary>
    public decimal? LoanAcquisitionScheduledUpbAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Maximum Amortization Term [ULDD.X19]
    /// </summary>
    public int? LoanAmortizationMaximumTermMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Level Basis Points [ULDD.X98]
    /// </summary>
    public int? LoanBuyupBuydownBasisPointNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Feature [ULDD.X97]
    /// </summary>
    public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get => GetValue<StringEnumValue<LoanBuyupBuydownType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Default Loss Party [ULDD.X47]
    /// </summary>
    public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get => GetValue<StringEnumValue<LoanDefaultLossPartyType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Loan delivered through the servicing released process [ULDD.X100]
    /// </summary>
    public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Loan Identifier Value Type [ULDD.LoanIdentifierValueType]
    /// </summary>
    public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get => GetValue<StringEnumValue<LoanIdentifierValueType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Interest Accrual Start Date [ULDD.X16]
    /// </summary>
    public DateTime? LoanInterestAccrualStartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description [ULDD.X103]
    /// </summary>
    public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Loan Level Credit Score  Method [ULDD.X102]
    /// </summary>
    public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get => GetValue<StringEnumValue<LoanLevelCreditScoreSelectionMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Loan Level Credit Score Value [ULDD.X101]
    /// </summary>
    public int? LoanLevelCreditScoreValue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan Modification Effective Date [ULDD.X5]
    /// </summary>
    public DateTime? LoanModificationEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Loan State Date [ULDD.X88]
    /// </summary>
    public DateTime? LoanStateDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Manufactured Home Width Type [ULDD.ManufacturedHomeWidthType]
    /// </summary>
    public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get => GetValue<StringEnumValue<ManufacturedHomeWidthType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - MBS has weighted Margin [ULDD.X34]
    /// </summary>
    public bool? MbsWeightedMarginIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MERS Original Mortgagee of Record Indicator [ULDD.GNM.MERSOrgnalMrtggeeOfRcrdIndctr]
    /// </summary>
    public StringEnumValue<TrueOrFalse> MersOriginalMortgageeOfRecordIndicator { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// MI Company Name Type [ULDD.X134]
    /// </summary>
    public StringEnumValue<MICompanyNameType> MiCompanyNameType { get => GetValue<StringEnumValue<MICompanyNameType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Mortgage Insurance Premium Source Type [ULDD.X49]
    /// </summary>
    public StringEnumValue<MIPremiumSourceType> MiPremiumSourceType { get => GetValue<StringEnumValue<MIPremiumSourceType>>(); set => SetValue(value); }

    /// <summary>
    /// Monetary Event Applied Date [ULDD.GNM.MntryEvntAppldDt]
    /// </summary>
    public DateTime? MonetaryEventAppliedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Monetary Event Gross Principal Amount [ULDD.GNM.MntryEvntGrssPrncpalAmnt]
    /// </summary>
    public decimal? MonetaryEventGrossPrincipalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Monetary Event Type [ULDD.GNM.MntryEvntTyp]
    /// </summary>
    public StringEnumValue<MonetaryEventType> MonetaryEventType { get => GetValue<StringEnumValue<MonetaryEventType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Mortgage-Backed Security [ULDD.X33]
    /// </summary>
    public bool? MortgageBackedSecurityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Mortgage Modification [ULDD.X4]
    /// </summary>
    public bool? MortgageModificationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Mtg Originator [ULDD.GNM.MortgageOriginator]
    /// </summary>
    public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get => GetValue<StringEnumValue<UlddMortgageOriginator>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Program Type [ULDD.GNM.MrtggPrgrmType]
    /// </summary>
    public StringEnumValue<MortgageProgramType> MortgageProgramType { get => GetValue<StringEnumValue<MortgageProgramType>>(); set => SetValue(value); }

    /// <summary>
    /// More than one concurrently closing lien on the subject property [ULDD.X124]
    /// </summary>
    public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Next Rate Adjustment Effective Date [ULDD.X62]
    /// </summary>
    public DateTime? NextRateAdjustmentEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Note Pay To Name [ULDD.X184]
    /// </summary>
    public string? NotePayToName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Number of Units Sold [ULDD.X138]
    /// </summary>
    public int? NumberOfUnitsSold { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Other Down Payment Funds Type [ULDD.GNM.OtherDwnPymntFndsType]
    /// </summary>
    public string? OtherDownPaymentFundsType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Other Funds Collected at Closing [ULDD.X110]
    /// </summary>
    public decimal? OtherFundsCollectedAtClosingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Freddie Mac - Other Funds collected at Closing for [ULDD.X111]
    /// </summary>
    public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get => GetValue<StringEnumValue<OtherFundsCollectedAtClosingType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Payee ID [ULDD.X117]
    /// </summary>
    public string? PayeeId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Billing Statement and Payment Lead Days [ULDD.X55]
    /// </summary>
    public int? PaymentBillingStatementLeadDaysCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Maximum Decrease Rate [ULDD.X60]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PerChangeMaximumDecreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Maximum Increase Rate [ULDD.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PerChangeMaximumIncreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Payment Adjustment [ULDD.X57]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Rate Adjustment Effective Date [ULDD.X58]
    /// </summary>
    public DateTime? PerChangeRateAdjustmentEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Rate Adjustment Frequency [ULDD.X59]
    /// </summary>
    public int? PerChangeRateAdjustmentFrequencyMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Accrual Rate Structure Type [ULDD.X73]
    /// </summary>
    public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get => GetValue<StringEnumValue<PoolAccrualRateStructureType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Amortization Type [ULDD.X66]
    /// </summary>
    public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get => GetValue<StringEnumValue<PoolAmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Assumability Indicator [ULDD.X83]
    /// </summary>
    public bool? PoolAssumabilityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Balloon Indicator [ULDD.X84]
    /// </summary>
    public bool? PoolBalloonIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Certificate Payment Date [ULDD.GNM.PoolCertPaymtDate]
    /// </summary>
    public DateTime? PoolCertificatePaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Class Type [ULDD.GNM.PoolClassType]
    /// </summary>
    public StringEnumValue<PoolClassType> PoolClassType { get => GetValue<StringEnumValue<PoolClassType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Concurrent Transfer Indicator [ULDD.GNM.PoolConcurTrnsfrIndic]
    /// </summary>
    public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get => GetValue<StringEnumValue<TrueOrFalse>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Current Loan Count [ULDD.GNM.PoolCurLoanCount]
    /// </summary>
    public int? PoolCurrentLoanCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Current Princial Balance Amount [ULDD.GNM.PoolCurPrinBalAmt]
    /// </summary>
    public decimal? PoolCurrentPrincipalBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Pool Document Custodian ID [ULDD.X156]
    /// </summary>
    public string? PoolDocumentCustodianId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Fixed Servicing Fee Percent [ULDD.X85]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolFixedServicingFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool ID [ULDD.X65]
    /// </summary>
    public string? PoolIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pooling Method Type [ULDD.GNM.PoolingMethodType]
    /// </summary>
    public StringEnumValue<PoolingMethodType> PoolingMethodType { get => GetValue<StringEnumValue<PoolingMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Interest Adjustment Effective Date [ULDD.GNM.PoolIntAdjEffDate]
    /// </summary>
    public DateTime? PoolInterestAdjustmentEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Interest Adjustment Index Lead Days [ULDD.X82]
    /// </summary>
    public int? PoolInterestAdjustmentIndexLeadDaysCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Interest and Payment Adjustment Index Lead Days [ULDD.X81]
    /// </summary>
    public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Interest Only [ULDD.X80]
    /// </summary>
    public bool? PoolInterestOnlyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Interest Rate Rounding [ULDD.X79]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolInterestRateRoundingPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Interest Rate Rounding Type [ULDD.X78]
    /// </summary>
    public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get => GetValue<StringEnumValue<PoolInterestRateRoundingType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Investor Product Plan ID [ULDD.X67]
    /// </summary>
    public string? PoolInvestorProductPlanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Issue Date [ULDD.X68]
    /// </summary>
    public DateTime? PoolIssueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Issuer Transferee [ULDD.GNM.PoolIssuerTransferee]
    /// </summary>
    public string? PoolIssuerTransferee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Margin Rate [ULDD.X77]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolMarginRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Maturity Date [ULDD.GNM.PoolMaturityDate]
    /// </summary>
    public DateTime? PoolMaturityDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Pool Maturity Period Count [ULDD.GNM.PoolMaturityPeriodCount]
    /// </summary>
    public int? PoolMaturityPeriodCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Maximum Accrual Rate [ULDD.X76]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolMaximumAccrualRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Minimum Accrual Rate [ULDD.X75]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolMinimumAccrualRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Mortgage Type [ULDD.X69]
    /// </summary>
    public StringEnumValue<PoolMortgageType> PoolMortgageType { get => GetValue<StringEnumValue<PoolMortgageType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Scheduled Remittance Payment Day [ULDD.X86]
    /// </summary>
    public int? PoolScheduledRemittancePaymentDay { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Security Issue Date Interest Rate [ULDD.X74]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PoolSecurityIssueDateInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Pool Seller ID [ULDD.X157]
    /// </summary>
    public string? PoolSellerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Pool Servicer ID [ULDD.X158]
    /// </summary>
    public string? PoolServicerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Structure Type [ULDD.X71]
    /// </summary>
    public StringEnumValue<PoolStructureType> PoolStructureType { get => GetValue<StringEnumValue<PoolStructureType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Pool Suffix ID [ULDD.X72]
    /// </summary>
    public string? PoolSuffixIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Price Lock Date Time [ULDD.X17]
    /// </summary>
    public DateTime? PriceLockDatetime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Primary Mortgage Insurance Absence Reason [ULDD.X51]
    /// </summary>
    public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMiAbsenceReasonType { get => GetValue<StringEnumValue<PrimaryMIAbsenceReasonType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Primary MI Absence Reason Type Other Description [ULDD.X52]
    /// </summary>
    public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMiAbsenceReasonTypeOtherDescription { get => GetValue<StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Project Attachment Type [ULDD.X143]
    /// </summary>
    public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get => GetValue<StringEnumValue<ProjectAttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Project Design Type [ULDD.X140]
    /// </summary>
    public StringEnumValue<ProjectDesignType> ProjectDesignType { get => GetValue<StringEnumValue<ProjectDesignType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Project Unit Count [ULDD.X176]
    /// </summary>
    public int? ProjectUnitCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Property Estate Type [ULDD.X197]
    /// </summary>
    public StringEnumValue<PropertyRightsType> PropertyEstateType { get => GetValue<StringEnumValue<PropertyRightsType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Property Valuation Effective Date [ULDD.X30]
    /// </summary>
    public DateTime? PropertyValuationEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Property Valuation Method Type [ULDD.X29]
    /// </summary>
    public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get => GetValue<StringEnumValue<PropertyValuationMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Property Valuation Method Type "Other" [ULDD.X190]
    /// </summary>
    public StringEnumValue<PropertyValuationOther> PropertyValuationOther { get => GetValue<StringEnumValue<PropertyValuationOther>>(); set => SetValue(value); }

    /// <summary>
    /// Refinance Cash Out Amount [ULDD.RefinanceCashOutAmount]
    /// </summary>
    public decimal? RefinanceCashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Refinance Cash Out Type [ULDD.X18]
    /// </summary>
    public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => GetValue<StringEnumValue<RefinanceCashOutDeterminationType>>(); set => SetValue(value); }

    /// <summary>
    /// Related Loan Affordable Indicator [ULDD.X194]
    /// </summary>
    public bool? RelatedLoanAffordableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Related Loan Balloon Indicator [ULDD.X175]
    /// </summary>
    public bool? RelatedLoanBalloonIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Related Loan HELOC Indicator [ULDD.X132]
    /// </summary>
    public bool? RelatedLoanHelocIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Related Loan [ULDD.X126]
    /// </summary>
    public bool? RelatedLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Related Loan Investor Type [ULDD.X46]
    /// </summary>
    public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get => GetValue<StringEnumValue<RelatedLoanInvestorType>>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Related Loan Maturity Period Count [ULDD.X173]
    /// </summary>
    public int? RelatedLoanMaturityPeriodCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Related Loan Note Date [ULDD.X183]
    /// </summary>
    public DateTime? RelatedLoanNoteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Related Loan Scheduled First Payment Date [ULDD.X174]
    /// </summary>
    public DateTime? RelatedLoanScheduledFirstPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Related Loan State Date At Closing [ULDD.X112]
    /// </summary>
    public DateTime? RelatedLoanStateDateAtClosing { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Related Loan Unpaid Principal Balance Amount [ULDD.X118]
    /// </summary>
    public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Relocation Loan [ULDD.X8]
    /// </summary>
    public bool? RelocationLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - REO Marketing Party [ULDD.X48]
    /// </summary>
    public StringEnumValue<PartyType> ReoMarketingPartyType { get => GetValue<StringEnumValue<PartyType>>(); set => SetValue(value); }

    /// <summary>
    /// Second lien is being delivered with this loan [ULDD.X125]
    /// </summary>
    public bool? SecondLienIsDeliveredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Ginnie Security Original Subscription Amount [ULDD.GNM.SecurityOrigSubscrAmt]
    /// </summary>
    public decimal? SecurityOriginalSubscriptionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Security Trade Book Entry Date [ULDD.X87]
    /// </summary>
    public DateTime? SecurityTradeBookEntryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Uldd SellerId
    /// </summary>
    public string? SellerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Seller Loan ID [ULDD.X21]
    /// </summary>
    public string? SellerLoanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fannie Mae - Servicer ID [ULDD.X116]
    /// </summary>
    public string? ServicerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Servicer Loan ID [ULDD.X94]
    /// </summary>
    public string? ServicerLoanIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Shared Equity [ULDD.X9]
    /// </summary>
    public bool? SharedEquityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Site Built [ULDD.X144]
    /// </summary>
    public bool? SiteBuiltIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD Special Flood Hazard Area [ULDD.X178]
    /// </summary>
    public bool? SpecialFloodHazardAreaIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Subsequent Maximum Decrease Rate [ULDD.X168]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Subsequent Maximum Increase Rate [ULDD.X169]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Subsequent Rate Adjustment Effective Date [ULDD.X166]
    /// </summary>
    public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Subsequent Rate Adjustment Frequency [ULDD.X167]
    /// </summary>
    public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Temporary Buydown [ULDD.X181]
    /// </summary>
    public bool? TemporaryBuydownIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Total Mortgaged Properties Count [ULDD.TotalMortgagedPropertiesCount]
    /// </summary>
    public int? TotalMortgagedPropertiesCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - First Unit Subject Property Gross Rent [ULDD.X171]
    /// </summary>
    public decimal? Unit1SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - First Unit Bedrooms [ULDD.X170]
    /// </summary>
    public int? Unit1TotalBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Second Unit Subject Property Gross Rent [ULDD.X161]
    /// </summary>
    public decimal? Unit2SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Second Unit Bedrooms [ULDD.X160]
    /// </summary>
    public int? Unit2TotalBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Third Unit Subject Property Gross Rent [ULDD.X163]
    /// </summary>
    public decimal? Unit3SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Third Unit Bedrooms [ULDD.X162]
    /// </summary>
    public int? Unit3TotalBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fourth Unit Subject Property Gross Rent [ULDD.X165]
    /// </summary>
    public decimal? Unit4SubjectPropertyGrossRentalIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Fourth Unit Bedrooms [ULDD.X164]
    /// </summary>
    public int? Unit4TotalBedrooms { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD - Unpaid Principal Balance Amount [ULDD.X1]
    /// </summary>
    public decimal? UpbAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ULDD WareHouse Lender ID [ULDD.X191]
    /// </summary>
    public string? WareHouseLenderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// WareHouse Lender Indicator [ULDD.X193]
    /// </summary>
    public bool? WareHouseLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}