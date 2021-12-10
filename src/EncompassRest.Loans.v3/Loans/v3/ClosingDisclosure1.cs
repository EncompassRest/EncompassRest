using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosure1
/// </summary>
public sealed partial class ClosingDisclosure1 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _cdDateIssued;
    private DirtyValue<string?>? _changedCircumstance;
    private DirtyValue<bool?>? _changedCircumstanceFlag;
    private DirtyValue<DateTime?>? _changesReceivedDate;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _disclosureBy;
    private DirtyValue<string?>? _disclosureComments;
    private DirtyValue<DateTime?>? _disclosureLastSentDate;
    private DirtyValue<DateTime?>? _disclosureReceivedDate;
    private DirtyValue<string?>? _disclosureSentMethod;
    private DirtyValue<string?>? _documentGuidFinalExecutedCopyofAlternateCd;
    private DirtyValue<string?>? _documentGuidFinalExecutedCopyofSellerCd;
    private DirtyValue<string?>? _documentGuidFinalExecutedCopyofStandardCd;
    private DirtyValue<decimal?>? _estimatedTaxesInsuranceAssessments;
    private DirtyValue<string?>? _inEscrowHomeownerInsurance;
    private DirtyValue<string?>? _inEscrowOther;
    private DirtyValue<string?>? _inEscrowPropertyTaxes;
    private DirtyValue<DateTime?>? _initialReceivedDate;
    private DirtyValue<string?>? _micReference;
    private DirtyValue<bool?>? _notNaturalPersonFlag;
    private DirtyValue<decimal?>? _ppc1EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc1EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc1InterestOnly;
    private DirtyValue<decimal?>? _ppc1MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc1MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc1MaximumPiPayment;
    private DirtyValue<string?>? _ppc1MaximumPiPaymentUi;
    private DirtyValue<decimal?>? _ppc1MiAmount;
    private DirtyValue<string?>? _ppc1MiAmountUi;
    private DirtyValue<decimal?>? _ppc1MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc1MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc1MinimumPiPayment;
    private DirtyValue<string?>? _ppc1MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc1Year;
    private DirtyValue<decimal?>? _ppc2EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc2EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc2InterestOnly;
    private DirtyValue<decimal?>? _ppc2MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc2MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc2MaximumPiPayment;
    private DirtyValue<string?>? _ppc2MaximumPiPaymentUi;
    private DirtyValue<decimal?>? _ppc2MiAmount;
    private DirtyValue<string?>? _ppc2MiAmountUi;
    private DirtyValue<decimal?>? _ppc2MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc2MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc2MinimumPiPayment;
    private DirtyValue<string?>? _ppc2MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc2YearFrom;
    private DirtyValue<int?>? _ppc2YearTo;
    private DirtyValue<decimal?>? _ppc3EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc3EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc3InterestOnly;
    private DirtyValue<decimal?>? _ppc3MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc3MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc3MaximumPiPayment;
    private DirtyValue<string?>? _ppc3MaximumPiPaymentUi;
    private DirtyValue<decimal?>? _ppc3MiAmount;
    private DirtyValue<string?>? _ppc3MiAmountUi;
    private DirtyValue<decimal?>? _ppc3MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc3MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc3MinimumPiPayment;
    private DirtyValue<string?>? _ppc3MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc3YearFrom;
    private DirtyValue<int?>? _ppc3YearTo;
    private DirtyValue<decimal?>? _ppc4EstimatedEscrowAmount;
    private DirtyValue<string?>? _ppc4EstimatedEscrowAmountUi;
    private DirtyValue<bool?>? _ppc4InterestOnly;
    private DirtyValue<decimal?>? _ppc4MaximumMonthlyPayment;
    private DirtyValue<string?>? _ppc4MaximumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc4MaximumPiPayment;
    private DirtyValue<string?>? _ppc4MaximumPiPaymentUi;
    private DirtyValue<decimal?>? _ppc4MiAmount;
    private DirtyValue<string?>? _ppc4MiAmountUi;
    private DirtyValue<decimal?>? _ppc4MinimumMonthlyPayment;
    private DirtyValue<string?>? _ppc4MinimumMonthlyPaymentUi;
    private DirtyValue<decimal?>? _ppc4MinimumPiPayment;
    private DirtyValue<string?>? _ppc4MinimumPiPaymentUi;
    private DirtyValue<int?>? _ppc4YearFrom;
    private DirtyValue<int?>? _ppc4YearTo;
    private DirtyValue<bool?>? _ppcEstimatedEscrowIndicator;
    private DirtyValue<bool?>? _ppcMortgageInsuranceIndicator;
    private DirtyValue<bool?>? _rangePaymentIndicatorC1;
    private DirtyValue<bool?>? _rangePaymentIndicatorC2;
    private DirtyValue<bool?>? _rangePaymentIndicatorC3;
    private DirtyValue<bool?>? _rangePaymentIndicatorC4;
    private DirtyValue<bool?>? _reasonAdvancedReview;
    private DirtyValue<bool?>? _reasonChangedCircumstanceElg;
    private DirtyValue<string?>? _reasonChangedCircumstanceFlags;
    private DirtyValue<bool?>? _reasonChangeInApr;
    private DirtyValue<bool?>? _reasonChangeInLoanProduct;
    private DirtyValue<bool?>? _reasonChangeSettlementCharges;
    private DirtyValue<bool?>? _reasonClericalErrorCorrection;
    private DirtyValue<bool?>? _reasonInterestRatecharges;
    private DirtyValue<bool?>? _reasonOther;
    private DirtyValue<string?>? _reasonOtherDescription;
    private DirtyValue<bool?>? _reasonPrepaymentPenalty;
    private DirtyValue<bool?>? _reasonRevisionsReqConsumer;
    private DirtyValue<bool?>? _reasonToleranceCure;
    private DirtyValue<DateTime?>? _revisedCdDueDate;
    private DirtyValue<DateTime?>? _revisedReceivedDate;
    private DirtyValue<string?>? _sellerNames;
    private DirtyValue<StringEnumValue<FinalSignatureType>>? _signatureTypeFinalExecutedCopyofAlternateCd;
    private DirtyValue<StringEnumValue<FinalSignatureType>>? _signatureTypeFinalExecutedCopyofSellerCd;
    private DirtyValue<StringEnumValue<FinalSignatureType>>? _signatureTypeFinalExecutedCopyofStandardCd;
    private DirtyValue<decimal?>? _totalCashToClose;

    /// <summary>
    /// Closing Disclosure - CD Date Issued [CD1.X1]
    /// </summary>
    public DateTime? CdDateIssued { get => _cdDateIssued; set => SetField(ref _cdDateIssued, value); }

    /// <summary>
    /// Closing Disclosure - Changed Circumstance [CD1.X64]
    /// </summary>
    public string? ChangedCircumstance { get => _changedCircumstance; set => SetField(ref _changedCircumstance, value); }

    /// <summary>
    /// CD Changed Circumstance Chkbx [CD1.X61]
    /// </summary>
    public bool? ChangedCircumstanceFlag { get => _changedCircumstanceFlag; set => SetField(ref _changedCircumstanceFlag, value); }

    /// <summary>
    /// CD Changed Circumstance Rcvd Date [CD1.X62]
    /// </summary>
    public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => SetField(ref _changesReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure - Comments [CD1.X65]
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// Closing Disclosure - Disclosure By [CD1.X48]
    /// </summary>
    public string? DisclosureBy { get => _disclosureBy; set => SetField(ref _disclosureBy, value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Comments [CD1.X50]
    /// </summary>
    public string? DisclosureComments { get => _disclosureComments; set => SetField(ref _disclosureComments, value); }

    /// <summary>
    /// Last CD Sent Date [CD1.X47]
    /// </summary>
    public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => SetField(ref _disclosureLastSentDate, value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Received Date [CD1.X51]
    /// </summary>
    public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => SetField(ref _disclosureReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure - Disclosure Sent Method [CD1.X49]
    /// </summary>
    public string? DisclosureSentMethod { get => _disclosureSentMethod; set => SetField(ref _disclosureSentMethod, value); }

    /// <summary>
    /// Document GUID of the final executed copy of the alternate CD [UCD.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofAlternateCd { get => _documentGuidFinalExecutedCopyofAlternateCd; set => SetField(ref _documentGuidFinalExecutedCopyofAlternateCd, value); }

    /// <summary>
    /// Document GUID of the final executed copy of the seller CD [UCD.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofSellerCd { get => _documentGuidFinalExecutedCopyofSellerCd; set => SetField(ref _documentGuidFinalExecutedCopyofSellerCd, value); }

    /// <summary>
    /// Document GUID of the final executed copy of the standard CD [UCD.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocumentGuidFinalExecutedCopyofStandardCd { get => _documentGuidFinalExecutedCopyofStandardCd; set => SetField(ref _documentGuidFinalExecutedCopyofStandardCd, value); }

    /// <summary>
    /// Closing Disclosure - Estimated Taxes, Insurance and Assessments [CD1.X3]
    /// </summary>
    public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => SetField(ref _estimatedTaxesInsuranceAssessments, value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Homeowner Insurance [CD1.X5]
    /// </summary>
    public string? InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => SetField(ref _inEscrowHomeownerInsurance, value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Other [CD1.X6]
    /// </summary>
    public string? InEscrowOther { get => _inEscrowOther; set => SetField(ref _inEscrowOther, value); }

    /// <summary>
    /// Closing Disclosure - In Escrow Property Taxes [CD1.X4]
    /// </summary>
    public string? InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => SetField(ref _inEscrowPropertyTaxes, value); }

    /// <summary>
    /// Closing Disclosure - Initial CD Received Date [CD1.X73]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialReceivedDate { get => _initialReceivedDate; set => SetField(ref _initialReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure - MIC Reference [CD1.X71]
    /// </summary>
    public string? MicReference { get => _micReference; set => SetField(ref _micReference, value); }

    /// <summary>
    /// Closing Disclosure - Not a Natural Person (legal entity) Flag [CD1.X72]
    /// </summary>
    public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => SetField(ref _notNaturalPersonFlag, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount [CD1.X12]
    /// </summary>
    public decimal? Ppc1EstimatedEscrowAmount { get => _ppc1EstimatedEscrowAmount; set => SetField(ref _ppc1EstimatedEscrowAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [CD1.XD12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1EstimatedEscrowAmountUi { get => _ppc1EstimatedEscrowAmountUi; set => SetField(ref _ppc1EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Interest Only [CD1.X10]
    /// </summary>
    public bool? Ppc1InterestOnly { get => _ppc1InterestOnly; set => SetField(ref _ppc1InterestOnly, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Monthly Payment [CD1.X14]
    /// </summary>
    public decimal? Ppc1MaximumMonthlyPayment { get => _ppc1MaximumMonthlyPayment; set => SetField(ref _ppc1MaximumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Maximum Monthly Payment UI Value [CD1.XD14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumMonthlyPaymentUi { get => _ppc1MaximumMonthlyPaymentUi; set => SetField(ref _ppc1MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [CD1.X9]
    /// </summary>
    public decimal? Ppc1MaximumPiPayment { get => _ppc1MaximumPiPayment; set => SetField(ref _ppc1MaximumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Maximum Principal and Interest Payment UI Value [CD1.XD9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MaximumPiPaymentUi { get => _ppc1MaximumPiPaymentUi; set => SetField(ref _ppc1MaximumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount [CD1.X11]
    /// </summary>
    public decimal? Ppc1MiAmount { get => _ppc1MiAmount; set => SetField(ref _ppc1MiAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [CD1.XD11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MiAmountUi { get => _ppc1MiAmountUi; set => SetField(ref _ppc1MiAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Monthly Payment [CD1.X13]
    /// </summary>
    public decimal? Ppc1MinimumMonthlyPayment { get => _ppc1MinimumMonthlyPayment; set => SetField(ref _ppc1MinimumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Minimum Monthly Payment UI Value [CD1.XD13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumMonthlyPaymentUi { get => _ppc1MinimumMonthlyPaymentUi; set => SetField(ref _ppc1MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [CD1.X8]
    /// </summary>
    public decimal? Ppc1MinimumPiPayment { get => _ppc1MinimumPiPayment; set => SetField(ref _ppc1MinimumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 1-Minimum Principal and Interest Payment UI Value [CD1.XD8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc1MinimumPiPaymentUi { get => _ppc1MinimumPiPaymentUi; set => SetField(ref _ppc1MinimumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Year [CD1.X7]
    /// </summary>
    public int? Ppc1Year { get => _ppc1Year; set => SetField(ref _ppc1Year, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount [CD1.X21]
    /// </summary>
    public decimal? Ppc2EstimatedEscrowAmount { get => _ppc2EstimatedEscrowAmount; set => SetField(ref _ppc2EstimatedEscrowAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [CD1.XD21]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2EstimatedEscrowAmountUi { get => _ppc2EstimatedEscrowAmountUi; set => SetField(ref _ppc2EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Interest Only [CD1.X19]
    /// </summary>
    public bool? Ppc2InterestOnly { get => _ppc2InterestOnly; set => SetField(ref _ppc2InterestOnly, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Monthly Payment [CD1.X23]
    /// </summary>
    public decimal? Ppc2MaximumMonthlyPayment { get => _ppc2MaximumMonthlyPayment; set => SetField(ref _ppc2MaximumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Maximum Monthly Payment UI Value [CD1.XD23]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumMonthlyPaymentUi { get => _ppc2MaximumMonthlyPaymentUi; set => SetField(ref _ppc2MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [CD1.X18]
    /// </summary>
    public decimal? Ppc2MaximumPiPayment { get => _ppc2MaximumPiPayment; set => SetField(ref _ppc2MaximumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Maximum Principal and Interest Payment UI Value [CD1.XD18]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MaximumPiPaymentUi { get => _ppc2MaximumPiPaymentUi; set => SetField(ref _ppc2MaximumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount [CD1.X20]
    /// </summary>
    public decimal? Ppc2MiAmount { get => _ppc2MiAmount; set => SetField(ref _ppc2MiAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [CD1.XD20]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MiAmountUi { get => _ppc2MiAmountUi; set => SetField(ref _ppc2MiAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Monthly Payment [CD1.X22]
    /// </summary>
    public decimal? Ppc2MinimumMonthlyPayment { get => _ppc2MinimumMonthlyPayment; set => SetField(ref _ppc2MinimumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Minimum Monthly Payment UI Value [CD1.XD22]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumMonthlyPaymentUi { get => _ppc2MinimumMonthlyPaymentUi; set => SetField(ref _ppc2MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [CD1.X17]
    /// </summary>
    public decimal? Ppc2MinimumPiPayment { get => _ppc2MinimumPiPayment; set => SetField(ref _ppc2MinimumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 2-Minimum Principal and Interest Payment UI Value [CD1.XD17]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc2MinimumPiPaymentUi { get => _ppc2MinimumPiPaymentUi; set => SetField(ref _ppc2MinimumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Year From [CD1.X15]
    /// </summary>
    public int? Ppc2YearFrom { get => _ppc2YearFrom; set => SetField(ref _ppc2YearFrom, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Year To [CD1.X16]
    /// </summary>
    public int? Ppc2YearTo { get => _ppc2YearTo; set => SetField(ref _ppc2YearTo, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount [CD1.X30]
    /// </summary>
    public decimal? Ppc3EstimatedEscrowAmount { get => _ppc3EstimatedEscrowAmount; set => SetField(ref _ppc3EstimatedEscrowAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [CD1.XD30]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3EstimatedEscrowAmountUi { get => _ppc3EstimatedEscrowAmountUi; set => SetField(ref _ppc3EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Interest Only [CD1.X28]
    /// </summary>
    public bool? Ppc3InterestOnly { get => _ppc3InterestOnly; set => SetField(ref _ppc3InterestOnly, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Monthly Payment [CD1.X32]
    /// </summary>
    public decimal? Ppc3MaximumMonthlyPayment { get => _ppc3MaximumMonthlyPayment; set => SetField(ref _ppc3MaximumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Maximum Monthly Payment UI Value [CD1.XD32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumMonthlyPaymentUi { get => _ppc3MaximumMonthlyPaymentUi; set => SetField(ref _ppc3MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [CD1.X27]
    /// </summary>
    public decimal? Ppc3MaximumPiPayment { get => _ppc3MaximumPiPayment; set => SetField(ref _ppc3MaximumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Maximum Principal and Interest Payment UI Value [CD1.XD27]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MaximumPiPaymentUi { get => _ppc3MaximumPiPaymentUi; set => SetField(ref _ppc3MaximumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount [CD1.X29]
    /// </summary>
    public decimal? Ppc3MiAmount { get => _ppc3MiAmount; set => SetField(ref _ppc3MiAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [CD1.XD29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MiAmountUi { get => _ppc3MiAmountUi; set => SetField(ref _ppc3MiAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Monthly Payment [CD1.X31]
    /// </summary>
    public decimal? Ppc3MinimumMonthlyPayment { get => _ppc3MinimumMonthlyPayment; set => SetField(ref _ppc3MinimumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Minimum Monthly Payment UI Value [CD1.XD31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumMonthlyPaymentUi { get => _ppc3MinimumMonthlyPaymentUi; set => SetField(ref _ppc3MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [CD1.X26]
    /// </summary>
    public decimal? Ppc3MinimumPiPayment { get => _ppc3MinimumPiPayment; set => SetField(ref _ppc3MinimumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 3-Minimum Principal and Interest Payment UI Value [CD1.XD26]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc3MinimumPiPaymentUi { get => _ppc3MinimumPiPaymentUi; set => SetField(ref _ppc3MinimumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Year From [CD1.X24]
    /// </summary>
    public int? Ppc3YearFrom { get => _ppc3YearFrom; set => SetField(ref _ppc3YearFrom, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Year To [CD1.X25]
    /// </summary>
    public int? Ppc3YearTo { get => _ppc3YearTo; set => SetField(ref _ppc3YearTo, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount [CD1.X39]
    /// </summary>
    public decimal? Ppc4EstimatedEscrowAmount { get => _ppc4EstimatedEscrowAmount; set => SetField(ref _ppc4EstimatedEscrowAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [CD1.XD39]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4EstimatedEscrowAmountUi { get => _ppc4EstimatedEscrowAmountUi; set => SetField(ref _ppc4EstimatedEscrowAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Interest Only [CD1.X37]
    /// </summary>
    public bool? Ppc4InterestOnly { get => _ppc4InterestOnly; set => SetField(ref _ppc4InterestOnly, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Monthly Payment [CD1.X41]
    /// </summary>
    public decimal? Ppc4MaximumMonthlyPayment { get => _ppc4MaximumMonthlyPayment; set => SetField(ref _ppc4MaximumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Maximum Monthly Payment UI Vavlue [CD1.XD41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumMonthlyPaymentUi { get => _ppc4MaximumMonthlyPaymentUi; set => SetField(ref _ppc4MaximumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [CD1.X36]
    /// </summary>
    public decimal? Ppc4MaximumPiPayment { get => _ppc4MaximumPiPayment; set => SetField(ref _ppc4MaximumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Maximum Principal and Interest Payment UI Value [CD1.XD36]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MaximumPiPaymentUi { get => _ppc4MaximumPiPaymentUi; set => SetField(ref _ppc4MaximumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount [CD1.X38]
    /// </summary>
    public decimal? Ppc4MiAmount { get => _ppc4MiAmount; set => SetField(ref _ppc4MiAmount, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [CD1.XD38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MiAmountUi { get => _ppc4MiAmountUi; set => SetField(ref _ppc4MiAmountUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Monthly Payment [CD1.X40]
    /// </summary>
    public decimal? Ppc4MinimumMonthlyPayment { get => _ppc4MinimumMonthlyPayment; set => SetField(ref _ppc4MinimumMonthlyPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Minimum Monthly Payment UI Value [CD1.XD40]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumMonthlyPaymentUi { get => _ppc4MinimumMonthlyPaymentUi; set => SetField(ref _ppc4MinimumMonthlyPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [CD1.X35]
    /// </summary>
    public decimal? Ppc4MinimumPiPayment { get => _ppc4MinimumPiPayment; set => SetField(ref _ppc4MinimumPiPayment, value); }

    /// <summary>
    /// Closing Disclosure-Projected Calculation-Column 4-Minimum Principal and Interest Payment UI Value [CD1.XD35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ppc4MinimumPiPaymentUi { get => _ppc4MinimumPiPaymentUi; set => SetField(ref _ppc4MinimumPiPaymentUi, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Year From [CD1.X33]
    /// </summary>
    public int? Ppc4YearFrom { get => _ppc4YearFrom; set => SetField(ref _ppc4YearFrom, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Year To [CD1.X34]
    /// </summary>
    public int? Ppc4YearTo { get => _ppc4YearTo; set => SetField(ref _ppc4YearTo, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Estimated Escrow Indicator [CD1.X43]
    /// </summary>
    public bool? PpcEstimatedEscrowIndicator { get => _ppcEstimatedEscrowIndicator; set => SetField(ref _ppcEstimatedEscrowIndicator, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Mortgage Insurance Indicator [CD1.X42]
    /// </summary>
    public bool? PpcMortgageInsuranceIndicator { get => _ppcMortgageInsuranceIndicator; set => SetField(ref _ppcMortgageInsuranceIndicator, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 1 - Range Payment Indicator [CD1.XD1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC1 { get => _rangePaymentIndicatorC1; set => SetField(ref _rangePaymentIndicatorC1, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 2 - Range Payment Indicator [CD1.XD2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC2 { get => _rangePaymentIndicatorC2; set => SetField(ref _rangePaymentIndicatorC2, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 3 - Range Payment Indicator [CD1.XD3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC3 { get => _rangePaymentIndicatorC3; set => SetField(ref _rangePaymentIndicatorC3, value); }

    /// <summary>
    /// Closing Disclosure - Projected Calculation - Column 4 - Range Payment Indicator [CD1.XD4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RangePaymentIndicatorC4 { get => _rangePaymentIndicatorC4; set => SetField(ref _rangePaymentIndicatorC4, value); }

    /// <summary>
    /// Closing Disclosure - 24-hour Advanced Preview [CD1.X56]
    /// </summary>
    public bool? ReasonAdvancedReview { get => _reasonAdvancedReview; set => SetField(ref _reasonAdvancedReview, value); }

    /// <summary>
    /// Closing Disclosure - Changed Circumstance - Eligibility [CD1.X68]
    /// </summary>
    public bool? ReasonChangedCircumstanceElg { get => _reasonChangedCircumstanceElg; set => SetField(ref _reasonChangedCircumstanceElg, value); }

    /// <summary>
    /// Closing Disclosure - Reason Changed Circumstance Flags [CD1.X70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => SetField(ref _reasonChangedCircumstanceFlags, value); }

    /// <summary>
    /// Closing Disclosure - Change in APR [CD1.X52]
    /// </summary>
    public bool? ReasonChangeInApr { get => _reasonChangeInApr; set => SetField(ref _reasonChangeInApr, value); }

    /// <summary>
    /// Closing Disclosure - Change in Loan Product [CD1.X53]
    /// </summary>
    public bool? ReasonChangeInLoanProduct { get => _reasonChangeInLoanProduct; set => SetField(ref _reasonChangeInLoanProduct, value); }

    /// <summary>
    /// Closing Disclosure - Change in Settlement Charges [CD1.X55]
    /// </summary>
    public bool? ReasonChangeSettlementCharges { get => _reasonChangeSettlementCharges; set => SetField(ref _reasonChangeSettlementCharges, value); }

    /// <summary>
    /// Closing Disclosure - Clerical Error Correction [CD1.X58]
    /// </summary>
    public bool? ReasonClericalErrorCorrection { get => _reasonClericalErrorCorrection; set => SetField(ref _reasonClericalErrorCorrection, value); }

    /// <summary>
    /// Closing Disclosure - Interest Rate dependent charges (Rate Lock) [CD1.X67]
    /// </summary>
    public bool? ReasonInterestRatecharges { get => _reasonInterestRatecharges; set => SetField(ref _reasonInterestRatecharges, value); }

    /// <summary>
    /// Closing Disclosure - Other [CD1.X59]
    /// </summary>
    public bool? ReasonOther { get => _reasonOther; set => SetField(ref _reasonOther, value); }

    /// <summary>
    /// Closing Disclosure - Other Description [CD1.X60]
    /// </summary>
    public string? ReasonOtherDescription { get => _reasonOtherDescription; set => SetField(ref _reasonOtherDescription, value); }

    /// <summary>
    /// Closing Disclosure - Prepayment Penalty Added [CD1.X54]
    /// </summary>
    public bool? ReasonPrepaymentPenalty { get => _reasonPrepaymentPenalty; set => SetField(ref _reasonPrepaymentPenalty, value); }

    /// <summary>
    /// Closing Disclosure - Revisions requested by the Consumer [CD1.X66]
    /// </summary>
    public bool? ReasonRevisionsReqConsumer { get => _reasonRevisionsReqConsumer; set => SetField(ref _reasonRevisionsReqConsumer, value); }

    /// <summary>
    /// Closing Disclosure - Tolerance Cure [CD1.X57]
    /// </summary>
    public bool? ReasonToleranceCure { get => _reasonToleranceCure; set => SetField(ref _reasonToleranceCure, value); }

    /// <summary>
    /// Closing Disclosure - Revised CD Due Date [CD1.X63]
    /// </summary>
    public DateTime? RevisedCdDueDate { get => _revisedCdDueDate; set => SetField(ref _revisedCdDueDate, value); }

    /// <summary>
    /// Closing Disclosure - Revised CD Received Date [CD1.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedReceivedDate { get => _revisedReceivedDate; set => SetField(ref _revisedReceivedDate, value); }

    /// <summary>
    /// Closing Disclosure - Seller Names [CD1.X2]
    /// </summary>
    public string? SellerNames { get => _sellerNames; set => SetField(ref _sellerNames, value); }

    /// <summary>
    /// Signature Type of final executed copy of the alternate CD [UCD.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofAlternateCd { get => _signatureTypeFinalExecutedCopyofAlternateCd; set => SetField(ref _signatureTypeFinalExecutedCopyofAlternateCd, value); }

    /// <summary>
    ///  Signature Type of final executed copy of the seller CD [UCD.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofSellerCd { get => _signatureTypeFinalExecutedCopyofSellerCd; set => SetField(ref _signatureTypeFinalExecutedCopyofSellerCd, value); }

    /// <summary>
    ///  Signature Type of final executed copy of the standard CD [UCD.X2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofStandardCd { get => _signatureTypeFinalExecutedCopyofStandardCd; set => SetField(ref _signatureTypeFinalExecutedCopyofStandardCd, value); }

    /// <summary>
    /// Closing Disclosure - Total Cash To Close [CD1.X69]
    /// </summary>
    public decimal? TotalCashToClose { get => _totalCashToClose; set => SetField(ref _totalCashToClose, value); }
}