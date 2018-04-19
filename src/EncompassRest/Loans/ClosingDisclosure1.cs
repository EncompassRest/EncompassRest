using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure1
    /// </summary>
    public sealed partial class ClosingDisclosure1 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _cDDateIssued;
        /// <summary>
        /// Closing Disclosure - CD Date Issued [CD1.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - CD Date Issued")]
        public DateTime? CDDateIssued { get => _cDDateIssued; set => _cDDateIssued = value; }
        private DirtyValue<string> _changedCircumstance;
        /// <summary>
        /// Closing Disclosure - Changed Circumstance [CD1.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Changed Circumstance")]
        public string ChangedCircumstance { get => _changedCircumstance; set => _changedCircumstance = value; }
        private DirtyValue<bool?> _changedCircumstanceFlag;
        /// <summary>
        /// CD Changed Circumstance Chkbx [CD1.X61]
        /// </summary>
        [LoanFieldProperty(Description = "CD Changed Circumstance Chkbx")]
        public bool? ChangedCircumstanceFlag { get => _changedCircumstanceFlag; set => _changedCircumstanceFlag = value; }
        private DirtyValue<DateTime?> _changesReceivedDate;
        /// <summary>
        /// CD Changed Circumstance Rcvd Date [CD1.X62]
        /// </summary>
        [LoanFieldProperty(Description = "CD Changed Circumstance Rcvd Date")]
        public DateTime? ChangesReceivedDate { get => _changesReceivedDate; set => _changesReceivedDate = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Closing Disclosure - Comments [CD1.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Comments")]
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _disclosureBy;
        /// <summary>
        /// Closing Disclosure - Disclosure By [CD1.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Disclosure By")]
        public string DisclosureBy { get => _disclosureBy; set => _disclosureBy = value; }
        private DirtyValue<string> _disclosureComments;
        /// <summary>
        /// Closing Disclosure - Disclosure Comments [CD1.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Disclosure Comments")]
        public string DisclosureComments { get => _disclosureComments; set => _disclosureComments = value; }
        private DirtyValue<DateTime?> _disclosureLastSentDate;
        /// <summary>
        /// Last CD Sent Date [CD1.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Last CD Sent Date")]
        public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => _disclosureLastSentDate = value; }
        private DirtyValue<DateTime?> _disclosureReceivedDate;
        /// <summary>
        /// Closing Disclosure - Disclosure Received Date [CD1.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Disclosure Received Date")]
        public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => _disclosureReceivedDate = value; }
        private DirtyValue<string> _disclosureSentMethod;
        /// <summary>
        /// Closing Disclosure - Disclosure Sent Method [CD1.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Disclosure Sent Method")]
        public string DisclosureSentMethod { get => _disclosureSentMethod; set => _disclosureSentMethod = value; }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofAlternateCD;
        /// <summary>
        /// Document GUID of the final executed copy of the alternate CD [UCD.X3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Document GUID of the final executed copy of the alternate CD")]
        public string DocumentGUIDFinalExecutedCopyofAlternateCD { get => _documentGUIDFinalExecutedCopyofAlternateCD; set => _documentGUIDFinalExecutedCopyofAlternateCD = value; }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofSellerCD;
        /// <summary>
        /// Document GUID of the final executed copy of the seller CD [UCD.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Document GUID of the final executed copy of the seller CD")]
        public string DocumentGUIDFinalExecutedCopyofSellerCD { get => _documentGUIDFinalExecutedCopyofSellerCD; set => _documentGUIDFinalExecutedCopyofSellerCD = value; }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofStandardCD;
        /// <summary>
        /// Document GUID of the final executed copy of the standard CD [UCD.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Document GUID of the final executed copy of the standard CD")]
        public string DocumentGUIDFinalExecutedCopyofStandardCD { get => _documentGUIDFinalExecutedCopyofStandardCD; set => _documentGUIDFinalExecutedCopyofStandardCD = value; }
        private DirtyValue<decimal?> _estimatedTaxesInsuranceAssessments;
        /// <summary>
        /// Closing Disclosure - Estimated Taxes, Insurance and Assessments [CD1.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Estimated Taxes, Insurance and Assessments")]
        public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => _estimatedTaxesInsuranceAssessments = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure1 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _inEscrowHomeownerInsurance;
        /// <summary>
        /// Closing Disclosure - In Escrow Homeowner Insurance [CD1.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - In Escrow Homeowner Insurance")]
        public string InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => _inEscrowHomeownerInsurance = value; }
        private DirtyValue<string> _inEscrowOther;
        /// <summary>
        /// Closing Disclosure - In Escrow Other [CD1.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - In Escrow Other")]
        public string InEscrowOther { get => _inEscrowOther; set => _inEscrowOther = value; }
        private DirtyValue<string> _inEscrowPropertyTaxes;
        /// <summary>
        /// Closing Disclosure - In Escrow Property Taxes [CD1.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - In Escrow Property Taxes")]
        public string InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => _inEscrowPropertyTaxes = value; }
        private DirtyValue<DateTime?> _initialCDReceivedDate;
        /// <summary>
        /// Closing Disclosure - Initial CD Received Date [CD1.X73]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Initial CD Received Date")]
        public DateTime? InitialCDReceivedDate { get => _initialCDReceivedDate; set => _initialCDReceivedDate = value; }
        private DirtyValue<string> _mICReference;
        /// <summary>
        /// Closing Disclosure - MIC Reference [CD1.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - MIC Reference")]
        public string MICReference { get => _mICReference; set => _mICReference = value; }
        private DirtyValue<bool?> _notNaturalPersonFlag;
        /// <summary>
        /// Closing Disclosure - Not a Natural Person (legal entity) Flag [CD1.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Not a Natural Person (legal entity) Flag")]
        public bool? NotNaturalPersonFlag { get => _notNaturalPersonFlag; set => _notNaturalPersonFlag = value; }
        private DirtyValue<decimal?> _pPC1EstimatedEscrowAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount [CD1.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount")]
        public decimal? PPC1EstimatedEscrowAmount { get => _pPC1EstimatedEscrowAmount; set => _pPC1EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC1EstimatedEscrowAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value [CD1.XD12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 1 - Estimated Escrow Amount UI Value")]
        public string PPC1EstimatedEscrowAmountUI { get => _pPC1EstimatedEscrowAmountUI; set => _pPC1EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC1InterestOnly;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Interest Only [CD1.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 1 - Interest Only")]
        public bool? PPC1InterestOnly { get => _pPC1InterestOnly; set => _pPC1InterestOnly = value; }
        private DirtyValue<decimal?> _pPC1MaximumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Monthly Payment [CD1.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Maximum Monthly Payment")]
        public decimal? PPC1MaximumMonthlyPayment { get => _pPC1MaximumMonthlyPayment; set => _pPC1MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MaximumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Maximum Monthly Payment UI Value [CD1.XD14]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 1-Maximum Monthly Payment UI Value")]
        public string PPC1MaximumMonthlyPaymentUI { get => _pPC1MaximumMonthlyPaymentUI; set => _pPC1MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MaximumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Maximum Principal and Interest Payment [CD1.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Maximum Principal and Interest Payment")]
        public decimal? PPC1MaximumPIPayment { get => _pPC1MaximumPIPayment; set => _pPC1MaximumPIPayment = value; }
        private DirtyValue<string> _pPC1MaximumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Maximum Principal and Interest Payment UI Value [CD1.XD9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 1-Maximum Principal and Interest Payment UI Value")]
        public string PPC1MaximumPIPaymentUI { get => _pPC1MaximumPIPaymentUI; set => _pPC1MaximumPIPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MIAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount [CD1.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount")]
        public decimal? PPC1MIAmount { get => _pPC1MIAmount; set => _pPC1MIAmount = value; }
        private DirtyValue<string> _pPC1MIAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value [CD1.XD11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 1 - Mortgage Insurance Amount UI Value")]
        public string PPC1MIAmountUI { get => _pPC1MIAmountUI; set => _pPC1MIAmountUI = value; }
        private DirtyValue<decimal?> _pPC1MinimumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Monthly Payment [CD1.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Minimum Monthly Payment")]
        public decimal? PPC1MinimumMonthlyPayment { get => _pPC1MinimumMonthlyPayment; set => _pPC1MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MinimumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Minimum Monthly Payment UI Value [CD1.XD13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 1-Minimum Monthly Payment UI Value")]
        public string PPC1MinimumMonthlyPaymentUI { get => _pPC1MinimumMonthlyPaymentUI; set => _pPC1MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MinimumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Minimum Principal and Interest Payment [CD1.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 1 - Minimum Principal and Interest Payment")]
        public decimal? PPC1MinimumPIPayment { get => _pPC1MinimumPIPayment; set => _pPC1MinimumPIPayment = value; }
        private DirtyValue<string> _pPC1MinimumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 1-Minimum Principal and Interest Payment UI Value [CD1.XD8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 1-Minimum Principal and Interest Payment UI Value")]
        public string PPC1MinimumPIPaymentUI { get => _pPC1MinimumPIPaymentUI; set => _pPC1MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC1Year;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Year [CD1.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 1 - Year")]
        public int? PPC1Year { get => _pPC1Year; set => _pPC1Year = value; }
        private DirtyValue<decimal?> _pPC2EstimatedEscrowAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount [CD1.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount")]
        public decimal? PPC2EstimatedEscrowAmount { get => _pPC2EstimatedEscrowAmount; set => _pPC2EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC2EstimatedEscrowAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value [CD1.XD21]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 2 - Estimated Escrow Amount UI Value")]
        public string PPC2EstimatedEscrowAmountUI { get => _pPC2EstimatedEscrowAmountUI; set => _pPC2EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC2InterestOnly;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Interest Only [CD1.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 2 - Interest Only")]
        public bool? PPC2InterestOnly { get => _pPC2InterestOnly; set => _pPC2InterestOnly = value; }
        private DirtyValue<decimal?> _pPC2MaximumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Monthly Payment [CD1.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Maximum Monthly Payment")]
        public decimal? PPC2MaximumMonthlyPayment { get => _pPC2MaximumMonthlyPayment; set => _pPC2MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MaximumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Maximum Monthly Payment UI Value [CD1.XD23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 2-Maximum Monthly Payment UI Value")]
        public string PPC2MaximumMonthlyPaymentUI { get => _pPC2MaximumMonthlyPaymentUI; set => _pPC2MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MaximumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Maximum Principal and Interest Payment [CD1.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Maximum Principal and Interest Payment")]
        public decimal? PPC2MaximumPIPayment { get => _pPC2MaximumPIPayment; set => _pPC2MaximumPIPayment = value; }
        private DirtyValue<string> _pPC2MaximumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Maximum Principal and Interest Payment UI Value [CD1.XD18]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 2-Maximum Principal and Interest Payment UI Value")]
        public string PPC2MaximumPIPaymentUI { get => _pPC2MaximumPIPaymentUI; set => _pPC2MaximumPIPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MIAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount [CD1.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount")]
        public decimal? PPC2MIAmount { get => _pPC2MIAmount; set => _pPC2MIAmount = value; }
        private DirtyValue<string> _pPC2MIAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value [CD1.XD20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 2 - Mortgage Insurance Amount UI Value")]
        public string PPC2MIAmountUI { get => _pPC2MIAmountUI; set => _pPC2MIAmountUI = value; }
        private DirtyValue<decimal?> _pPC2MinimumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Monthly Payment [CD1.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Minimum Monthly Payment")]
        public decimal? PPC2MinimumMonthlyPayment { get => _pPC2MinimumMonthlyPayment; set => _pPC2MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MinimumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Minimum Monthly Payment UI Value [CD1.XD22]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 2-Minimum Monthly Payment UI Value")]
        public string PPC2MinimumMonthlyPaymentUI { get => _pPC2MinimumMonthlyPaymentUI; set => _pPC2MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MinimumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Minimum Principal and Interest Payment [CD1.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 2 - Minimum Principal and Interest Payment")]
        public decimal? PPC2MinimumPIPayment { get => _pPC2MinimumPIPayment; set => _pPC2MinimumPIPayment = value; }
        private DirtyValue<string> _pPC2MinimumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 2-Minimum Principal and Interest Payment UI Value [CD1.XD17]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 2-Minimum Principal and Interest Payment UI Value")]
        public string PPC2MinimumPIPaymentUI { get => _pPC2MinimumPIPaymentUI; set => _pPC2MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC2YearFrom;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Year From [CD1.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 2 - Year From")]
        public int? PPC2YearFrom { get => _pPC2YearFrom; set => _pPC2YearFrom = value; }
        private DirtyValue<int?> _pPC2YearTo;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Year To [CD1.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 2 - Year To")]
        public int? PPC2YearTo { get => _pPC2YearTo; set => _pPC2YearTo = value; }
        private DirtyValue<decimal?> _pPC3EstimatedEscrowAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount [CD1.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount")]
        public decimal? PPC3EstimatedEscrowAmount { get => _pPC3EstimatedEscrowAmount; set => _pPC3EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC3EstimatedEscrowAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value [CD1.XD30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 3 - Estimated Escrow Amount UI Value")]
        public string PPC3EstimatedEscrowAmountUI { get => _pPC3EstimatedEscrowAmountUI; set => _pPC3EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC3InterestOnly;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Interest Only [CD1.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 3 - Interest Only")]
        public bool? PPC3InterestOnly { get => _pPC3InterestOnly; set => _pPC3InterestOnly = value; }
        private DirtyValue<decimal?> _pPC3MaximumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Monthly Payment [CD1.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Maximum Monthly Payment")]
        public decimal? PPC3MaximumMonthlyPayment { get => _pPC3MaximumMonthlyPayment; set => _pPC3MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MaximumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Maximum Monthly Payment UI Value [CD1.XD32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 3-Maximum Monthly Payment UI Value")]
        public string PPC3MaximumMonthlyPaymentUI { get => _pPC3MaximumMonthlyPaymentUI; set => _pPC3MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MaximumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Maximum Principal and Interest Payment [CD1.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Maximum Principal and Interest Payment")]
        public decimal? PPC3MaximumPIPayment { get => _pPC3MaximumPIPayment; set => _pPC3MaximumPIPayment = value; }
        private DirtyValue<string> _pPC3MaximumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Maximum Principal and Interest Payment UI Value [CD1.XD27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 3-Maximum Principal and Interest Payment UI Value")]
        public string PPC3MaximumPIPaymentUI { get => _pPC3MaximumPIPaymentUI; set => _pPC3MaximumPIPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MIAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount [CD1.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount")]
        public decimal? PPC3MIAmount { get => _pPC3MIAmount; set => _pPC3MIAmount = value; }
        private DirtyValue<string> _pPC3MIAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value [CD1.XD29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 3 - Mortgage Insurance Amount UI Value")]
        public string PPC3MIAmountUI { get => _pPC3MIAmountUI; set => _pPC3MIAmountUI = value; }
        private DirtyValue<decimal?> _pPC3MinimumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Monthly Payment [CD1.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Minimum Monthly Payment")]
        public decimal? PPC3MinimumMonthlyPayment { get => _pPC3MinimumMonthlyPayment; set => _pPC3MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MinimumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Minimum Monthly Payment UI Value [CD1.XD31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 3-Minimum Monthly Payment UI Value")]
        public string PPC3MinimumMonthlyPaymentUI { get => _pPC3MinimumMonthlyPaymentUI; set => _pPC3MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MinimumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Minimum Principal and Interest Payment [CD1.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 3 - Minimum Principal and Interest Payment")]
        public decimal? PPC3MinimumPIPayment { get => _pPC3MinimumPIPayment; set => _pPC3MinimumPIPayment = value; }
        private DirtyValue<string> _pPC3MinimumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 3-Minimum Principal and Interest Payment UI Value [CD1.XD26]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 3-Minimum Principal and Interest Payment UI Value")]
        public string PPC3MinimumPIPaymentUI { get => _pPC3MinimumPIPaymentUI; set => _pPC3MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC3YearFrom;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Year From [CD1.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 3 - Year From")]
        public int? PPC3YearFrom { get => _pPC3YearFrom; set => _pPC3YearFrom = value; }
        private DirtyValue<int?> _pPC3YearTo;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Year To [CD1.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 3 - Year To")]
        public int? PPC3YearTo { get => _pPC3YearTo; set => _pPC3YearTo = value; }
        private DirtyValue<decimal?> _pPC4EstimatedEscrowAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount [CD1.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount")]
        public decimal? PPC4EstimatedEscrowAmount { get => _pPC4EstimatedEscrowAmount; set => _pPC4EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC4EstimatedEscrowAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value [CD1.XD39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 4 - Estimated Escrow Amount UI Value")]
        public string PPC4EstimatedEscrowAmountUI { get => _pPC4EstimatedEscrowAmountUI; set => _pPC4EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC4InterestOnly;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Interest Only [CD1.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 4 - Interest Only")]
        public bool? PPC4InterestOnly { get => _pPC4InterestOnly; set => _pPC4InterestOnly = value; }
        private DirtyValue<decimal?> _pPC4MaximumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Monthly Payment [CD1.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Maximum Monthly Payment")]
        public decimal? PPC4MaximumMonthlyPayment { get => _pPC4MaximumMonthlyPayment; set => _pPC4MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MaximumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Maximum Monthly Payment UI Vavlue [CD1.XD41]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 4-Maximum Monthly Payment UI Vavlue")]
        public string PPC4MaximumMonthlyPaymentUI { get => _pPC4MaximumMonthlyPaymentUI; set => _pPC4MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MaximumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Maximum Principal and Interest Payment [CD1.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Maximum Principal and Interest Payment")]
        public decimal? PPC4MaximumPIPayment { get => _pPC4MaximumPIPayment; set => _pPC4MaximumPIPayment = value; }
        private DirtyValue<string> _pPC4MaximumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Maximum Principal and Interest Payment UI Value [CD1.XD36]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 4-Maximum Principal and Interest Payment UI Value")]
        public string PPC4MaximumPIPaymentUI { get => _pPC4MaximumPIPaymentUI; set => _pPC4MaximumPIPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MIAmount;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount [CD1.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount")]
        public decimal? PPC4MIAmount { get => _pPC4MIAmount; set => _pPC4MIAmount = value; }
        private DirtyValue<string> _pPC4MIAmountUI;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value [CD1.XD38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 4 - Mortgage Insurance Amount UI Value")]
        public string PPC4MIAmountUI { get => _pPC4MIAmountUI; set => _pPC4MIAmountUI = value; }
        private DirtyValue<decimal?> _pPC4MinimumMonthlyPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Monthly Payment [CD1.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Minimum Monthly Payment")]
        public decimal? PPC4MinimumMonthlyPayment { get => _pPC4MinimumMonthlyPayment; set => _pPC4MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MinimumMonthlyPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Minimum Monthly Payment UI Value [CD1.XD40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 4-Minimum Monthly Payment UI Value")]
        public string PPC4MinimumMonthlyPaymentUI { get => _pPC4MinimumMonthlyPaymentUI; set => _pPC4MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MinimumPIPayment;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Minimum Principal and Interest Payment [CD1.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Projected Calculation - Column 4 - Minimum Principal and Interest Payment")]
        public decimal? PPC4MinimumPIPayment { get => _pPC4MinimumPIPayment; set => _pPC4MinimumPIPayment = value; }
        private DirtyValue<string> _pPC4MinimumPIPaymentUI;
        /// <summary>
        /// Closing Disclosure-Projected Calculation-Column 4-Minimum Principal and Interest Payment UI Value [CD1.XD35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure-Projected Calculation-Column 4-Minimum Principal and Interest Payment UI Value")]
        public string PPC4MinimumPIPaymentUI { get => _pPC4MinimumPIPaymentUI; set => _pPC4MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC4YearFrom;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Year From [CD1.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 4 - Year From")]
        public int? PPC4YearFrom { get => _pPC4YearFrom; set => _pPC4YearFrom = value; }
        private DirtyValue<int?> _pPC4YearTo;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Year To [CD1.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Column 4 - Year To")]
        public int? PPC4YearTo { get => _pPC4YearTo; set => _pPC4YearTo = value; }
        private DirtyValue<bool?> _pPCEstimatedEscrowIndicator;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Estimated Escrow Indicator [CD1.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Estimated Escrow Indicator")]
        public bool? PPCEstimatedEscrowIndicator { get => _pPCEstimatedEscrowIndicator; set => _pPCEstimatedEscrowIndicator = value; }
        private DirtyValue<bool?> _pPCMortgageInsuranceIndicator;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Mortgage Insurance Indicator [CD1.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Projected Calculation - Mortgage Insurance Indicator")]
        public bool? PPCMortgageInsuranceIndicator { get => _pPCMortgageInsuranceIndicator; set => _pPCMortgageInsuranceIndicator = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC1;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 1 - Range Payment Indicator [CD1.XD1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 1 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC1 { get => _rangePaymentIndicatorC1; set => _rangePaymentIndicatorC1 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC2;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 2 - Range Payment Indicator [CD1.XD2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 2 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC2 { get => _rangePaymentIndicatorC2; set => _rangePaymentIndicatorC2 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC3;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 3 - Range Payment Indicator [CD1.XD3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 3 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC3 { get => _rangePaymentIndicatorC3; set => _rangePaymentIndicatorC3 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC4;
        /// <summary>
        /// Closing Disclosure - Projected Calculation - Column 4 - Range Payment Indicator [CD1.XD4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Projected Calculation - Column 4 - Range Payment Indicator")]
        public bool? RangePaymentIndicatorC4 { get => _rangePaymentIndicatorC4; set => _rangePaymentIndicatorC4 = value; }
        private DirtyValue<bool?> _reasonAdvancedReview;
        /// <summary>
        /// Closing Disclosure - 24-hour Advanced Preview [CD1.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - 24-hour Advanced Preview")]
        public bool? ReasonAdvancedReview { get => _reasonAdvancedReview; set => _reasonAdvancedReview = value; }
        private DirtyValue<bool?> _reasonChangedCircumstanceElg;
        /// <summary>
        /// Closing Disclosure - Changed Circumstance - Eligibility [CD1.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Changed Circumstance - Eligibility")]
        public bool? ReasonChangedCircumstanceElg { get => _reasonChangedCircumstanceElg; set => _reasonChangedCircumstanceElg = value; }
        private DirtyValue<string> _reasonChangedCircumstanceFlags;
        /// <summary>
        /// Closing Disclosure - Reason Changed Circumstance Flags [CD1.X70]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Reason Changed Circumstance Flags")]
        public string ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => _reasonChangedCircumstanceFlags = value; }
        private DirtyValue<bool?> _reasonChangeInAPR;
        /// <summary>
        /// Closing Disclosure - Change in APR [CD1.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Change in APR")]
        public bool? ReasonChangeInAPR { get => _reasonChangeInAPR; set => _reasonChangeInAPR = value; }
        private DirtyValue<bool?> _reasonChangeInLoanProduct;
        /// <summary>
        /// Closing Disclosure - Change in Loan Product [CD1.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Change in Loan Product")]
        public bool? ReasonChangeInLoanProduct { get => _reasonChangeInLoanProduct; set => _reasonChangeInLoanProduct = value; }
        private DirtyValue<bool?> _reasonChangeSettlementCharges;
        /// <summary>
        /// Closing Disclosure - Change in Settlement Charges [CD1.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Change in Settlement Charges")]
        public bool? ReasonChangeSettlementCharges { get => _reasonChangeSettlementCharges; set => _reasonChangeSettlementCharges = value; }
        private DirtyValue<bool?> _reasonClericalErrorCorrection;
        /// <summary>
        /// Closing Disclosure - Clerical Error Correction [CD1.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Clerical Error Correction")]
        public bool? ReasonClericalErrorCorrection { get => _reasonClericalErrorCorrection; set => _reasonClericalErrorCorrection = value; }
        private DirtyValue<bool?> _reasonInterestRatecharges;
        /// <summary>
        /// Closing Disclosure - Interest Rate dependent charges (Rate Lock) [CD1.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Interest Rate dependent charges (Rate Lock)")]
        public bool? ReasonInterestRatecharges { get => _reasonInterestRatecharges; set => _reasonInterestRatecharges = value; }
        private DirtyValue<bool?> _reasonOther;
        /// <summary>
        /// Closing Disclosure - Other [CD1.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Other")]
        public bool? ReasonOther { get => _reasonOther; set => _reasonOther = value; }
        private DirtyValue<string> _reasonOtherDescription;
        /// <summary>
        /// Closing Disclosure - Other Description [CD1.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Other Description")]
        public string ReasonOtherDescription { get => _reasonOtherDescription; set => _reasonOtherDescription = value; }
        private DirtyValue<bool?> _reasonPrepaymentPenalty;
        /// <summary>
        /// Closing Disclosure - Prepayment Penalty Added [CD1.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Prepayment Penalty Added")]
        public bool? ReasonPrepaymentPenalty { get => _reasonPrepaymentPenalty; set => _reasonPrepaymentPenalty = value; }
        private DirtyValue<bool?> _reasonRevisionsReqConsumer;
        /// <summary>
        /// Closing Disclosure - Revisions requested by the Consumer [CD1.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Revisions requested by the Consumer")]
        public bool? ReasonRevisionsReqConsumer { get => _reasonRevisionsReqConsumer; set => _reasonRevisionsReqConsumer = value; }
        private DirtyValue<bool?> _reasonToleranceCure;
        /// <summary>
        /// Closing Disclosure - Tolerance Cure [CD1.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Tolerance Cure")]
        public bool? ReasonToleranceCure { get => _reasonToleranceCure; set => _reasonToleranceCure = value; }
        private DirtyValue<DateTime?> _revisedCDDueDate;
        /// <summary>
        /// Closing Disclosure - Revised CD Due Date [CD1.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Revised CD Due Date")]
        public DateTime? RevisedCDDueDate { get => _revisedCDDueDate; set => _revisedCDDueDate = value; }
        private DirtyValue<DateTime?> _revisedCDReceivedDate;
        /// <summary>
        /// Closing Disclosure - Revised CD Received Date [CD1.X74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure - Revised CD Received Date")]
        public DateTime? RevisedCDReceivedDate { get => _revisedCDReceivedDate; set => _revisedCDReceivedDate = value; }
        private DirtyValue<string> _sellerNames;
        /// <summary>
        /// Closing Disclosure - Seller Names [CD1.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure - Seller Names")]
        public string SellerNames { get => _sellerNames; set => _sellerNames = value; }
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofAlternateCD;
        /// <summary>
        /// Signature Type of final executed copy of the alternate CD [UCD.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Signature Type of final executed copy of the alternate CD")]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofAlternateCD { get => _signatureTypeFinalExecutedCopyofAlternateCD; set => _signatureTypeFinalExecutedCopyofAlternateCD = value; }
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofSellerCD;
        /// <summary>
        ///  Signature Type of final executed copy of the seller CD [UCD.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = " Signature Type of final executed copy of the seller CD")]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofSellerCD { get => _signatureTypeFinalExecutedCopyofSellerCD; set => _signatureTypeFinalExecutedCopyofSellerCD = value; }
        private DirtyValue<StringEnumValue<FinalSignatureType>> _signatureTypeFinalExecutedCopyofStandardCD;
        /// <summary>
        ///  Signature Type of final executed copy of the standard CD [UCD.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = " Signature Type of final executed copy of the standard CD")]
        public StringEnumValue<FinalSignatureType> SignatureTypeFinalExecutedCopyofStandardCD { get => _signatureTypeFinalExecutedCopyofStandardCD; set => _signatureTypeFinalExecutedCopyofStandardCD = value; }
        private DirtyValue<decimal?> _totalCashToClose;
        /// <summary>
        /// Closing Disclosure - Total Cash To Close [CD1.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure - Total Cash To Close")]
        public decimal? TotalCashToClose { get => _totalCashToClose; set => _totalCashToClose = value; }
        internal override bool DirtyInternal
        {
            get => _cDDateIssued.Dirty
                || _changedCircumstance.Dirty
                || _changedCircumstanceFlag.Dirty
                || _changesReceivedDate.Dirty
                || _comments.Dirty
                || _disclosureBy.Dirty
                || _disclosureComments.Dirty
                || _disclosureLastSentDate.Dirty
                || _disclosureReceivedDate.Dirty
                || _disclosureSentMethod.Dirty
                || _documentGUIDFinalExecutedCopyofAlternateCD.Dirty
                || _documentGUIDFinalExecutedCopyofSellerCD.Dirty
                || _documentGUIDFinalExecutedCopyofStandardCD.Dirty
                || _estimatedTaxesInsuranceAssessments.Dirty
                || _id.Dirty
                || _inEscrowHomeownerInsurance.Dirty
                || _inEscrowOther.Dirty
                || _inEscrowPropertyTaxes.Dirty
                || _initialCDReceivedDate.Dirty
                || _mICReference.Dirty
                || _notNaturalPersonFlag.Dirty
                || _pPC1EstimatedEscrowAmount.Dirty
                || _pPC1EstimatedEscrowAmountUI.Dirty
                || _pPC1InterestOnly.Dirty
                || _pPC1MaximumMonthlyPayment.Dirty
                || _pPC1MaximumMonthlyPaymentUI.Dirty
                || _pPC1MaximumPIPayment.Dirty
                || _pPC1MaximumPIPaymentUI.Dirty
                || _pPC1MIAmount.Dirty
                || _pPC1MIAmountUI.Dirty
                || _pPC1MinimumMonthlyPayment.Dirty
                || _pPC1MinimumMonthlyPaymentUI.Dirty
                || _pPC1MinimumPIPayment.Dirty
                || _pPC1MinimumPIPaymentUI.Dirty
                || _pPC1Year.Dirty
                || _pPC2EstimatedEscrowAmount.Dirty
                || _pPC2EstimatedEscrowAmountUI.Dirty
                || _pPC2InterestOnly.Dirty
                || _pPC2MaximumMonthlyPayment.Dirty
                || _pPC2MaximumMonthlyPaymentUI.Dirty
                || _pPC2MaximumPIPayment.Dirty
                || _pPC2MaximumPIPaymentUI.Dirty
                || _pPC2MIAmount.Dirty
                || _pPC2MIAmountUI.Dirty
                || _pPC2MinimumMonthlyPayment.Dirty
                || _pPC2MinimumMonthlyPaymentUI.Dirty
                || _pPC2MinimumPIPayment.Dirty
                || _pPC2MinimumPIPaymentUI.Dirty
                || _pPC2YearFrom.Dirty
                || _pPC2YearTo.Dirty
                || _pPC3EstimatedEscrowAmount.Dirty
                || _pPC3EstimatedEscrowAmountUI.Dirty
                || _pPC3InterestOnly.Dirty
                || _pPC3MaximumMonthlyPayment.Dirty
                || _pPC3MaximumMonthlyPaymentUI.Dirty
                || _pPC3MaximumPIPayment.Dirty
                || _pPC3MaximumPIPaymentUI.Dirty
                || _pPC3MIAmount.Dirty
                || _pPC3MIAmountUI.Dirty
                || _pPC3MinimumMonthlyPayment.Dirty
                || _pPC3MinimumMonthlyPaymentUI.Dirty
                || _pPC3MinimumPIPayment.Dirty
                || _pPC3MinimumPIPaymentUI.Dirty
                || _pPC3YearFrom.Dirty
                || _pPC3YearTo.Dirty
                || _pPC4EstimatedEscrowAmount.Dirty
                || _pPC4EstimatedEscrowAmountUI.Dirty
                || _pPC4InterestOnly.Dirty
                || _pPC4MaximumMonthlyPayment.Dirty
                || _pPC4MaximumMonthlyPaymentUI.Dirty
                || _pPC4MaximumPIPayment.Dirty
                || _pPC4MaximumPIPaymentUI.Dirty
                || _pPC4MIAmount.Dirty
                || _pPC4MIAmountUI.Dirty
                || _pPC4MinimumMonthlyPayment.Dirty
                || _pPC4MinimumMonthlyPaymentUI.Dirty
                || _pPC4MinimumPIPayment.Dirty
                || _pPC4MinimumPIPaymentUI.Dirty
                || _pPC4YearFrom.Dirty
                || _pPC4YearTo.Dirty
                || _pPCEstimatedEscrowIndicator.Dirty
                || _pPCMortgageInsuranceIndicator.Dirty
                || _rangePaymentIndicatorC1.Dirty
                || _rangePaymentIndicatorC2.Dirty
                || _rangePaymentIndicatorC3.Dirty
                || _rangePaymentIndicatorC4.Dirty
                || _reasonAdvancedReview.Dirty
                || _reasonChangedCircumstanceElg.Dirty
                || _reasonChangedCircumstanceFlags.Dirty
                || _reasonChangeInAPR.Dirty
                || _reasonChangeInLoanProduct.Dirty
                || _reasonChangeSettlementCharges.Dirty
                || _reasonClericalErrorCorrection.Dirty
                || _reasonInterestRatecharges.Dirty
                || _reasonOther.Dirty
                || _reasonOtherDescription.Dirty
                || _reasonPrepaymentPenalty.Dirty
                || _reasonRevisionsReqConsumer.Dirty
                || _reasonToleranceCure.Dirty
                || _revisedCDDueDate.Dirty
                || _revisedCDReceivedDate.Dirty
                || _sellerNames.Dirty
                || _signatureTypeFinalExecutedCopyofAlternateCD.Dirty
                || _signatureTypeFinalExecutedCopyofSellerCD.Dirty
                || _signatureTypeFinalExecutedCopyofStandardCD.Dirty
                || _totalCashToClose.Dirty;
            set
            {
                _cDDateIssued.Dirty = value;
                _changedCircumstance.Dirty = value;
                _changedCircumstanceFlag.Dirty = value;
                _changesReceivedDate.Dirty = value;
                _comments.Dirty = value;
                _disclosureBy.Dirty = value;
                _disclosureComments.Dirty = value;
                _disclosureLastSentDate.Dirty = value;
                _disclosureReceivedDate.Dirty = value;
                _disclosureSentMethod.Dirty = value;
                _documentGUIDFinalExecutedCopyofAlternateCD.Dirty = value;
                _documentGUIDFinalExecutedCopyofSellerCD.Dirty = value;
                _documentGUIDFinalExecutedCopyofStandardCD.Dirty = value;
                _estimatedTaxesInsuranceAssessments.Dirty = value;
                _id.Dirty = value;
                _inEscrowHomeownerInsurance.Dirty = value;
                _inEscrowOther.Dirty = value;
                _inEscrowPropertyTaxes.Dirty = value;
                _initialCDReceivedDate.Dirty = value;
                _mICReference.Dirty = value;
                _notNaturalPersonFlag.Dirty = value;
                _pPC1EstimatedEscrowAmount.Dirty = value;
                _pPC1EstimatedEscrowAmountUI.Dirty = value;
                _pPC1InterestOnly.Dirty = value;
                _pPC1MaximumMonthlyPayment.Dirty = value;
                _pPC1MaximumMonthlyPaymentUI.Dirty = value;
                _pPC1MaximumPIPayment.Dirty = value;
                _pPC1MaximumPIPaymentUI.Dirty = value;
                _pPC1MIAmount.Dirty = value;
                _pPC1MIAmountUI.Dirty = value;
                _pPC1MinimumMonthlyPayment.Dirty = value;
                _pPC1MinimumMonthlyPaymentUI.Dirty = value;
                _pPC1MinimumPIPayment.Dirty = value;
                _pPC1MinimumPIPaymentUI.Dirty = value;
                _pPC1Year.Dirty = value;
                _pPC2EstimatedEscrowAmount.Dirty = value;
                _pPC2EstimatedEscrowAmountUI.Dirty = value;
                _pPC2InterestOnly.Dirty = value;
                _pPC2MaximumMonthlyPayment.Dirty = value;
                _pPC2MaximumMonthlyPaymentUI.Dirty = value;
                _pPC2MaximumPIPayment.Dirty = value;
                _pPC2MaximumPIPaymentUI.Dirty = value;
                _pPC2MIAmount.Dirty = value;
                _pPC2MIAmountUI.Dirty = value;
                _pPC2MinimumMonthlyPayment.Dirty = value;
                _pPC2MinimumMonthlyPaymentUI.Dirty = value;
                _pPC2MinimumPIPayment.Dirty = value;
                _pPC2MinimumPIPaymentUI.Dirty = value;
                _pPC2YearFrom.Dirty = value;
                _pPC2YearTo.Dirty = value;
                _pPC3EstimatedEscrowAmount.Dirty = value;
                _pPC3EstimatedEscrowAmountUI.Dirty = value;
                _pPC3InterestOnly.Dirty = value;
                _pPC3MaximumMonthlyPayment.Dirty = value;
                _pPC3MaximumMonthlyPaymentUI.Dirty = value;
                _pPC3MaximumPIPayment.Dirty = value;
                _pPC3MaximumPIPaymentUI.Dirty = value;
                _pPC3MIAmount.Dirty = value;
                _pPC3MIAmountUI.Dirty = value;
                _pPC3MinimumMonthlyPayment.Dirty = value;
                _pPC3MinimumMonthlyPaymentUI.Dirty = value;
                _pPC3MinimumPIPayment.Dirty = value;
                _pPC3MinimumPIPaymentUI.Dirty = value;
                _pPC3YearFrom.Dirty = value;
                _pPC3YearTo.Dirty = value;
                _pPC4EstimatedEscrowAmount.Dirty = value;
                _pPC4EstimatedEscrowAmountUI.Dirty = value;
                _pPC4InterestOnly.Dirty = value;
                _pPC4MaximumMonthlyPayment.Dirty = value;
                _pPC4MaximumMonthlyPaymentUI.Dirty = value;
                _pPC4MaximumPIPayment.Dirty = value;
                _pPC4MaximumPIPaymentUI.Dirty = value;
                _pPC4MIAmount.Dirty = value;
                _pPC4MIAmountUI.Dirty = value;
                _pPC4MinimumMonthlyPayment.Dirty = value;
                _pPC4MinimumMonthlyPaymentUI.Dirty = value;
                _pPC4MinimumPIPayment.Dirty = value;
                _pPC4MinimumPIPaymentUI.Dirty = value;
                _pPC4YearFrom.Dirty = value;
                _pPC4YearTo.Dirty = value;
                _pPCEstimatedEscrowIndicator.Dirty = value;
                _pPCMortgageInsuranceIndicator.Dirty = value;
                _rangePaymentIndicatorC1.Dirty = value;
                _rangePaymentIndicatorC2.Dirty = value;
                _rangePaymentIndicatorC3.Dirty = value;
                _rangePaymentIndicatorC4.Dirty = value;
                _reasonAdvancedReview.Dirty = value;
                _reasonChangedCircumstanceElg.Dirty = value;
                _reasonChangedCircumstanceFlags.Dirty = value;
                _reasonChangeInAPR.Dirty = value;
                _reasonChangeInLoanProduct.Dirty = value;
                _reasonChangeSettlementCharges.Dirty = value;
                _reasonClericalErrorCorrection.Dirty = value;
                _reasonInterestRatecharges.Dirty = value;
                _reasonOther.Dirty = value;
                _reasonOtherDescription.Dirty = value;
                _reasonPrepaymentPenalty.Dirty = value;
                _reasonRevisionsReqConsumer.Dirty = value;
                _reasonToleranceCure.Dirty = value;
                _revisedCDDueDate.Dirty = value;
                _revisedCDReceivedDate.Dirty = value;
                _sellerNames.Dirty = value;
                _signatureTypeFinalExecutedCopyofAlternateCD.Dirty = value;
                _signatureTypeFinalExecutedCopyofSellerCD.Dirty = value;
                _signatureTypeFinalExecutedCopyofStandardCD.Dirty = value;
                _totalCashToClose.Dirty = value;
            }
        }
    }
}