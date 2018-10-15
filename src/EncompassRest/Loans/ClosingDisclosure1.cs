using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure1
    /// </summary>
    public sealed partial class ClosingDisclosure1 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _cDDateIssued;
        private DirtyValue<string> _changedCircumstance;
        private DirtyValue<bool?> _changedCircumstanceFlag;
        private DirtyValue<DateTime?> _changesReceivedDate;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _disclosureBy;
        private DirtyValue<string> _disclosureComments;
        private DirtyValue<DateTime?> _disclosureLastSentDate;
        private DirtyValue<DateTime?> _disclosureReceivedDate;
        private DirtyValue<string> _disclosureSentMethod;
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofAlternateCD;
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofSellerCD;
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofStandardCD;
        private DirtyValue<decimal?> _estimatedTaxesInsuranceAssessments;
        private DirtyValue<string> _id;
        private DirtyValue<string> _inEscrowHomeownerInsurance;
        private DirtyValue<string> _inEscrowOther;
        private DirtyValue<string> _inEscrowPropertyTaxes;
        private DirtyValue<DateTime?> _initialCDReceivedDate;
        private DirtyValue<string> _mICReference;
        private DirtyValue<bool?> _notNaturalPersonFlag;
        private DirtyValue<decimal?> _pPC1EstimatedEscrowAmount;
        private DirtyValue<string> _pPC1EstimatedEscrowAmountUI;
        private DirtyValue<bool?> _pPC1InterestOnly;
        private DirtyValue<decimal?> _pPC1MaximumMonthlyPayment;
        private DirtyValue<string> _pPC1MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC1MaximumPIPayment;
        private DirtyValue<string> _pPC1MaximumPIPaymentUI;
        private DirtyValue<decimal?> _pPC1MIAmount;
        private DirtyValue<string> _pPC1MIAmountUI;
        private DirtyValue<decimal?> _pPC1MinimumMonthlyPayment;
        private DirtyValue<string> _pPC1MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC1MinimumPIPayment;
        private DirtyValue<string> _pPC1MinimumPIPaymentUI;
        private DirtyValue<int?> _pPC1Year;
        private DirtyValue<decimal?> _pPC2EstimatedEscrowAmount;
        private DirtyValue<string> _pPC2EstimatedEscrowAmountUI;
        private DirtyValue<bool?> _pPC2InterestOnly;
        private DirtyValue<decimal?> _pPC2MaximumMonthlyPayment;
        private DirtyValue<string> _pPC2MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC2MaximumPIPayment;
        private DirtyValue<string> _pPC2MaximumPIPaymentUI;
        private DirtyValue<decimal?> _pPC2MIAmount;
        private DirtyValue<string> _pPC2MIAmountUI;
        private DirtyValue<decimal?> _pPC2MinimumMonthlyPayment;
        private DirtyValue<string> _pPC2MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC2MinimumPIPayment;
        private DirtyValue<string> _pPC2MinimumPIPaymentUI;
        private DirtyValue<int?> _pPC2YearFrom;
        private DirtyValue<int?> _pPC2YearTo;
        private DirtyValue<decimal?> _pPC3EstimatedEscrowAmount;
        private DirtyValue<string> _pPC3EstimatedEscrowAmountUI;
        private DirtyValue<bool?> _pPC3InterestOnly;
        private DirtyValue<decimal?> _pPC3MaximumMonthlyPayment;
        private DirtyValue<string> _pPC3MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC3MaximumPIPayment;
        private DirtyValue<string> _pPC3MaximumPIPaymentUI;
        private DirtyValue<decimal?> _pPC3MIAmount;
        private DirtyValue<string> _pPC3MIAmountUI;
        private DirtyValue<decimal?> _pPC3MinimumMonthlyPayment;
        private DirtyValue<string> _pPC3MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC3MinimumPIPayment;
        private DirtyValue<string> _pPC3MinimumPIPaymentUI;
        private DirtyValue<int?> _pPC3YearFrom;
        private DirtyValue<int?> _pPC3YearTo;
        private DirtyValue<decimal?> _pPC4EstimatedEscrowAmount;
        private DirtyValue<string> _pPC4EstimatedEscrowAmountUI;
        private DirtyValue<bool?> _pPC4InterestOnly;
        private DirtyValue<decimal?> _pPC4MaximumMonthlyPayment;
        private DirtyValue<string> _pPC4MaximumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC4MaximumPIPayment;
        private DirtyValue<string> _pPC4MaximumPIPaymentUI;
        private DirtyValue<decimal?> _pPC4MIAmount;
        private DirtyValue<string> _pPC4MIAmountUI;
        private DirtyValue<decimal?> _pPC4MinimumMonthlyPayment;
        private DirtyValue<string> _pPC4MinimumMonthlyPaymentUI;
        private DirtyValue<decimal?> _pPC4MinimumPIPayment;
        private DirtyValue<string> _pPC4MinimumPIPaymentUI;
        private DirtyValue<int?> _pPC4YearFrom;
        private DirtyValue<int?> _pPC4YearTo;
        private DirtyValue<bool?> _pPCEstimatedEscrowIndicator;
        private DirtyValue<bool?> _pPCMortgageInsuranceIndicator;
        private DirtyValue<bool?> _rangePaymentIndicatorC1;
        private DirtyValue<bool?> _rangePaymentIndicatorC2;
        private DirtyValue<bool?> _rangePaymentIndicatorC3;
        private DirtyValue<bool?> _rangePaymentIndicatorC4;
        private DirtyValue<bool?> _reasonAdvancedReview;
        private DirtyValue<bool?> _reasonChangedCircumstanceElg;
        private DirtyValue<string> _reasonChangedCircumstanceFlags;
        private DirtyValue<bool?> _reasonChangeInAPR;
        private DirtyValue<bool?> _reasonChangeInLoanProduct;
        private DirtyValue<bool?> _reasonChangeSettlementCharges;
        private DirtyValue<bool?> _reasonClericalErrorCorrection;
        private DirtyValue<bool?> _reasonInterestRatecharges;
        private DirtyValue<bool?> _reasonOther;
        private DirtyValue<string> _reasonOtherDescription;
        private DirtyValue<bool?> _reasonPrepaymentPenalty;
        private DirtyValue<bool?> _reasonRevisionsReqConsumer;
        private DirtyValue<bool?> _reasonToleranceCure;
        private DirtyValue<DateTime?> _revisedCDDueDate;
        private DirtyValue<DateTime?> _revisedCDReceivedDate;
        private DirtyValue<string> _sellerNames;
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofAlternateCD;
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofSellerCD;
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofStandardCD;
        private DirtyValue<decimal?> _totalCashToClose;

        /// <summary>
        /// Closing Disclosure - CD Date Issued [CD1.X1]
        /// </summary>
        public DateTime? CDDateIssued { get => _cDDateIssued; set => SetField(ref _cDDateIssued, value); }

        /// <summary>
        /// Closing Disclosure - Changed Circumstance [CD1.X64]
        /// </summary>
        public string ChangedCircumstance { get => _changedCircumstance; set => SetField(ref _changedCircumstance, value); }

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
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Closing Disclosure - Disclosure By [CD1.X48]
        /// </summary>
        public string DisclosureBy { get => _disclosureBy; set => SetField(ref _disclosureBy, value); }

        /// <summary>
        /// Closing Disclosure - Disclosure Comments [CD1.X50]
        /// </summary>
        public string DisclosureComments { get => _disclosureComments; set => SetField(ref _disclosureComments, value); }

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
        public string DisclosureSentMethod { get => _disclosureSentMethod; set => SetField(ref _disclosureSentMethod, value); }

        /// <summary>
        /// Document GUID of the final executed copy of the alternate CD [UCD.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DocumentGUIDFinalExecutedCopyofAlternateCD { get => _documentGUIDFinalExecutedCopyofAlternateCD; set => SetField(ref _documentGUIDFinalExecutedCopyofAlternateCD, value); }

        /// <summary>
        /// Document GUID of the final executed copy of the seller CD [UCD.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DocumentGUIDFinalExecutedCopyofSellerCD { get => _documentGUIDFinalExecutedCopyofSellerCD; set => SetField(ref _documentGUIDFinalExecutedCopyofSellerCD, value); }

        /// <summary>
        /// Document GUID of the final executed copy of the standard CD [UCD.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DocumentGUIDFinalExecutedCopyofStandardCD { get => _documentGUIDFinalExecutedCopyofStandardCD; set => SetField(ref _documentGUIDFinalExecutedCopyofStandardCD, value); }

        /// <summary>
        /// Closing Disclosure - Estimated Taxes, Insurance and Assessments [CD1.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => SetField(ref _estimatedTaxesInsuranceAssessments, value); }

        /// <summary>
        /// ClosingDisclosure1 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Closing Disclosure - In Escrow Homeowner Insurance [CD1.X5]
        /// </summary>
        public string InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => SetField(ref _inEscrowHomeownerInsurance, value); }

        /// <summary>
        /// Closing Disclosure - In Escrow Other [CD1.X6]
        /// </summary>
        public string InEscrowOther { get => _inEscrowOther; set => SetField(ref _inEscrowOther, value); }

        /// <summary>
        /// Closing Disclosure - In Escrow Property Taxes [CD1.X4]
        /// </summary>
        public string InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => SetField(ref _inEscrowPropertyTaxes, value); }

        /// <summary>
        /// Closing Disclosure - Initial CD Received Date [CD1.X73]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? InitialCDReceivedDate { get => _initialCDReceivedDate; set => SetField(ref _initialCDReceivedDate, value); }

        /// <summary>
        /// Closing Disclosure - MIC Reference [CD1.X71]
        /// </summary>
        public string MICReference { get => _mICReference; set => SetField(ref _mICReference, value); }

        /// <summary>
        /// Closing Disclosure - Not a Natural Person (legal entity) Flag [CD1.X72]
        /// </summary>
        public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => SetField(ref _notNaturalPersonFlag, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount [CD1.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1EstimatedEscrowAmount { get => _pPC1EstimatedEscrowAmount; set => SetField(ref _pPC1EstimatedEscrowAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [CD1.XD12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1EstimatedEscrowAmountUI { get => _pPC1EstimatedEscrowAmountUI; set => SetField(ref _pPC1EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Interest Only [CD1.X10]
        /// </summary>
        public bool? PPC1InterestOnly { get => _pPC1InterestOnly; set => SetField(ref _pPC1InterestOnly, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Monthly Payment [CD1.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1MaximumMonthlyPayment { get => _pPC1MaximumMonthlyPayment; set => SetField(ref _pPC1MaximumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Maximum Monthly Payment UI Value [CD1.XD14]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1MaximumMonthlyPaymentUI { get => _pPC1MaximumMonthlyPaymentUI; set => SetField(ref _pPC1MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [CD1.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1MaximumPIPayment { get => _pPC1MaximumPIPayment; set => SetField(ref _pPC1MaximumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Maximum Principal and Interest Payment UI Value [CD1.XD9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1MaximumPIPaymentUI { get => _pPC1MaximumPIPaymentUI; set => SetField(ref _pPC1MaximumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount [CD1.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1MIAmount { get => _pPC1MIAmount; set => SetField(ref _pPC1MIAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [CD1.XD11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1MIAmountUI { get => _pPC1MIAmountUI; set => SetField(ref _pPC1MIAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Monthly Payment [CD1.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1MinimumMonthlyPayment { get => _pPC1MinimumMonthlyPayment; set => SetField(ref _pPC1MinimumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Minimum Monthly Payment UI Value [CD1.XD13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1MinimumMonthlyPaymentUI { get => _pPC1MinimumMonthlyPaymentUI; set => SetField(ref _pPC1MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [CD1.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC1MinimumPIPayment { get => _pPC1MinimumPIPayment; set => SetField(ref _pPC1MinimumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Minimum Principal and Interest Payment UI Value [CD1.XD8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC1MinimumPIPaymentUI { get => _pPC1MinimumPIPaymentUI; set => SetField(ref _pPC1MinimumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Year [CD1.X7]
        /// </summary>
        public int? PPC1Year { get => _pPC1Year; set => SetField(ref _pPC1Year, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount [CD1.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2EstimatedEscrowAmount { get => _pPC2EstimatedEscrowAmount; set => SetField(ref _pPC2EstimatedEscrowAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [CD1.XD21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2EstimatedEscrowAmountUI { get => _pPC2EstimatedEscrowAmountUI; set => SetField(ref _pPC2EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Interest Only [CD1.X19]
        /// </summary>
        public bool? PPC2InterestOnly { get => _pPC2InterestOnly; set => SetField(ref _pPC2InterestOnly, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Monthly Payment [CD1.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2MaximumMonthlyPayment { get => _pPC2MaximumMonthlyPayment; set => SetField(ref _pPC2MaximumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Maximum Monthly Payment UI Value [CD1.XD23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2MaximumMonthlyPaymentUI { get => _pPC2MaximumMonthlyPaymentUI; set => SetField(ref _pPC2MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [CD1.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2MaximumPIPayment { get => _pPC2MaximumPIPayment; set => SetField(ref _pPC2MaximumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Maximum Principal and Interest Payment UI Value [CD1.XD18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2MaximumPIPaymentUI { get => _pPC2MaximumPIPaymentUI; set => SetField(ref _pPC2MaximumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount [CD1.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2MIAmount { get => _pPC2MIAmount; set => SetField(ref _pPC2MIAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [CD1.XD20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2MIAmountUI { get => _pPC2MIAmountUI; set => SetField(ref _pPC2MIAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Monthly Payment [CD1.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2MinimumMonthlyPayment { get => _pPC2MinimumMonthlyPayment; set => SetField(ref _pPC2MinimumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Minimum Monthly Payment UI Value [CD1.XD22]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2MinimumMonthlyPaymentUI { get => _pPC2MinimumMonthlyPaymentUI; set => SetField(ref _pPC2MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [CD1.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC2MinimumPIPayment { get => _pPC2MinimumPIPayment; set => SetField(ref _pPC2MinimumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Minimum Principal and Interest Payment UI Value [CD1.XD17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC2MinimumPIPaymentUI { get => _pPC2MinimumPIPaymentUI; set => SetField(ref _pPC2MinimumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Year From [CD1.X15]
        /// </summary>
        public int? PPC2YearFrom { get => _pPC2YearFrom; set => SetField(ref _pPC2YearFrom, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Year To [CD1.X16]
        /// </summary>
        public int? PPC2YearTo { get => _pPC2YearTo; set => SetField(ref _pPC2YearTo, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount [CD1.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3EstimatedEscrowAmount { get => _pPC3EstimatedEscrowAmount; set => SetField(ref _pPC3EstimatedEscrowAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [CD1.XD30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3EstimatedEscrowAmountUI { get => _pPC3EstimatedEscrowAmountUI; set => SetField(ref _pPC3EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Interest Only [CD1.X28]
        /// </summary>
        public bool? PPC3InterestOnly { get => _pPC3InterestOnly; set => SetField(ref _pPC3InterestOnly, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Monthly Payment [CD1.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3MaximumMonthlyPayment { get => _pPC3MaximumMonthlyPayment; set => SetField(ref _pPC3MaximumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Maximum Monthly Payment UI Value [CD1.XD32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3MaximumMonthlyPaymentUI { get => _pPC3MaximumMonthlyPaymentUI; set => SetField(ref _pPC3MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [CD1.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3MaximumPIPayment { get => _pPC3MaximumPIPayment; set => SetField(ref _pPC3MaximumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Maximum Principal and Interest Payment UI Value [CD1.XD27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3MaximumPIPaymentUI { get => _pPC3MaximumPIPaymentUI; set => SetField(ref _pPC3MaximumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount [CD1.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3MIAmount { get => _pPC3MIAmount; set => SetField(ref _pPC3MIAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [CD1.XD29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3MIAmountUI { get => _pPC3MIAmountUI; set => SetField(ref _pPC3MIAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Monthly Payment [CD1.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3MinimumMonthlyPayment { get => _pPC3MinimumMonthlyPayment; set => SetField(ref _pPC3MinimumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Minimum Monthly Payment UI Value [CD1.XD31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3MinimumMonthlyPaymentUI { get => _pPC3MinimumMonthlyPaymentUI; set => SetField(ref _pPC3MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [CD1.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC3MinimumPIPayment { get => _pPC3MinimumPIPayment; set => SetField(ref _pPC3MinimumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Minimum Principal and Interest Payment UI Value [CD1.XD26]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC3MinimumPIPaymentUI { get => _pPC3MinimumPIPaymentUI; set => SetField(ref _pPC3MinimumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Year From [CD1.X24]
        /// </summary>
        public int? PPC3YearFrom { get => _pPC3YearFrom; set => SetField(ref _pPC3YearFrom, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Year To [CD1.X25]
        /// </summary>
        public int? PPC3YearTo { get => _pPC3YearTo; set => SetField(ref _pPC3YearTo, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount [CD1.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4EstimatedEscrowAmount { get => _pPC4EstimatedEscrowAmount; set => SetField(ref _pPC4EstimatedEscrowAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [CD1.XD39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4EstimatedEscrowAmountUI { get => _pPC4EstimatedEscrowAmountUI; set => SetField(ref _pPC4EstimatedEscrowAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Interest Only [CD1.X37]
        /// </summary>
        public bool? PPC4InterestOnly { get => _pPC4InterestOnly; set => SetField(ref _pPC4InterestOnly, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Monthly Payment [CD1.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4MaximumMonthlyPayment { get => _pPC4MaximumMonthlyPayment; set => SetField(ref _pPC4MaximumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Maximum Monthly Payment UI Vavlue [CD1.XD41]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4MaximumMonthlyPaymentUI { get => _pPC4MaximumMonthlyPaymentUI; set => SetField(ref _pPC4MaximumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [CD1.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4MaximumPIPayment { get => _pPC4MaximumPIPayment; set => SetField(ref _pPC4MaximumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Maximum Principal and Interest Payment UI Value [CD1.XD36]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4MaximumPIPaymentUI { get => _pPC4MaximumPIPaymentUI; set => SetField(ref _pPC4MaximumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount [CD1.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4MIAmount { get => _pPC4MIAmount; set => SetField(ref _pPC4MIAmount, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [CD1.XD38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4MIAmountUI { get => _pPC4MIAmountUI; set => SetField(ref _pPC4MIAmountUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Monthly Payment [CD1.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4MinimumMonthlyPayment { get => _pPC4MinimumMonthlyPayment; set => SetField(ref _pPC4MinimumMonthlyPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Minimum Monthly Payment UI Value [CD1.XD40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4MinimumMonthlyPaymentUI { get => _pPC4MinimumMonthlyPaymentUI; set => SetField(ref _pPC4MinimumMonthlyPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [CD1.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PPC4MinimumPIPayment { get => _pPC4MinimumPIPayment; set => SetField(ref _pPC4MinimumPIPayment, value); }

        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Minimum Principal and Interest Payment UI Value [CD1.XD35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PPC4MinimumPIPaymentUI { get => _pPC4MinimumPIPaymentUI; set => SetField(ref _pPC4MinimumPIPaymentUI, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Year From [CD1.X33]
        /// </summary>
        public int? PPC4YearFrom { get => _pPC4YearFrom; set => SetField(ref _pPC4YearFrom, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Year To [CD1.X34]
        /// </summary>
        public int? PPC4YearTo { get => _pPC4YearTo; set => SetField(ref _pPC4YearTo, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Estimated Escrow Indicator [CD1.X43]
        /// </summary>
        public bool? PPCEstimatedEscrowIndicator { get => _pPCEstimatedEscrowIndicator; set => SetField(ref _pPCEstimatedEscrowIndicator, value); }

        /// <summary>
        /// Closing Disclosure - Projected Calculation - Mortgage Insurance Indicator [CD1.X42]
        /// </summary>
        public bool? PPCMortgageInsuranceIndicator { get => _pPCMortgageInsuranceIndicator; set => SetField(ref _pPCMortgageInsuranceIndicator, value); }

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
        public string ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => SetField(ref _reasonChangedCircumstanceFlags, value); }

        /// <summary>
        /// Closing Disclosure - Change in APR [CD1.X52]
        /// </summary>
        public bool? ReasonChangeInAPR { get => _reasonChangeInAPR; set => SetField(ref _reasonChangeInAPR, value); }

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
        public string ReasonOtherDescription { get => _reasonOtherDescription; set => SetField(ref _reasonOtherDescription, value); }

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
        public DateTime? RevisedCDDueDate { get => _revisedCDDueDate; set => SetField(ref _revisedCDDueDate, value); }

        /// <summary>
        /// Closing Disclosure - Revised CD Received Date [CD1.X74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? RevisedCDReceivedDate { get => _revisedCDReceivedDate; set => SetField(ref _revisedCDReceivedDate, value); }

        /// <summary>
        /// Closing Disclosure - Seller Names [CD1.X2]
        /// </summary>
        public string SellerNames { get => _sellerNames; set => SetField(ref _sellerNames, value); }

        /// <summary>
        /// Signature Type of final executed copy of the alternate CD [UCD.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofAlternateCD { get => _signatureTypeFinalExecutedCopyofAlternateCD; set => SetField(ref _signatureTypeFinalExecutedCopyofAlternateCD, value); }

        /// <summary>
        ///  Signature Type of final executed copy of the seller CD [UCD.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofSellerCD { get => _signatureTypeFinalExecutedCopyofSellerCD; set => SetField(ref _signatureTypeFinalExecutedCopyofSellerCD, value); }

        /// <summary>
        ///  Signature Type of final executed copy of the standard CD [UCD.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofStandardCD { get => _signatureTypeFinalExecutedCopyofStandardCD; set => SetField(ref _signatureTypeFinalExecutedCopyofStandardCD, value); }

        /// <summary>
        /// Closing Disclosure - Total Cash To Close [CD1.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalCashToClose { get => _totalCashToClose; set => SetField(ref _totalCashToClose, value); }
    }
}