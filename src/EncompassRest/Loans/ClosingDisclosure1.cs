using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure1 : IClean
    {
        private Value<DateTime?> _cDDateIssued;
        public DateTime? CDDateIssued { get { return _cDDateIssued; } set { _cDDateIssued = value; } }
        private Value<string> _changedCircumstance;
        public string ChangedCircumstance { get { return _changedCircumstance; } set { _changedCircumstance = value; } }
        private Value<bool?> _changedCircumstanceFlag;
        public bool? ChangedCircumstanceFlag { get { return _changedCircumstanceFlag; } set { _changedCircumstanceFlag = value; } }
        private Value<DateTime?> _changesReceivedDate;
        public DateTime? ChangesReceivedDate { get { return _changesReceivedDate; } set { _changesReceivedDate = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _disclosureBy;
        public string DisclosureBy { get { return _disclosureBy; } set { _disclosureBy = value; } }
        private Value<string> _disclosureComments;
        public string DisclosureComments { get { return _disclosureComments; } set { _disclosureComments = value; } }
        private Value<DateTime?> _disclosureLastSentDate;
        public DateTime? DisclosureLastSentDate { get { return _disclosureLastSentDate; } set { _disclosureLastSentDate = value; } }
        private Value<DateTime?> _disclosureReceivedDate;
        public DateTime? DisclosureReceivedDate { get { return _disclosureReceivedDate; } set { _disclosureReceivedDate = value; } }
        private Value<string> _disclosureSentMethod;
        public string DisclosureSentMethod { get { return _disclosureSentMethod; } set { _disclosureSentMethod = value; } }
        private Value<string> _documentGUIDFinalExecutedCopyofAlternateCD;
        public string DocumentGUIDFinalExecutedCopyofAlternateCD { get { return _documentGUIDFinalExecutedCopyofAlternateCD; } set { _documentGUIDFinalExecutedCopyofAlternateCD = value; } }
        private Value<string> _documentGUIDFinalExecutedCopyofSellerCD;
        public string DocumentGUIDFinalExecutedCopyofSellerCD { get { return _documentGUIDFinalExecutedCopyofSellerCD; } set { _documentGUIDFinalExecutedCopyofSellerCD = value; } }
        private Value<string> _documentGUIDFinalExecutedCopyofStandardCD;
        public string DocumentGUIDFinalExecutedCopyofStandardCD { get { return _documentGUIDFinalExecutedCopyofStandardCD; } set { _documentGUIDFinalExecutedCopyofStandardCD = value; } }
        private Value<decimal?> _estimatedTaxesInsuranceAssessments;
        public decimal? EstimatedTaxesInsuranceAssessments { get { return _estimatedTaxesInsuranceAssessments; } set { _estimatedTaxesInsuranceAssessments = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _inEscrowHomeownerInsurance;
        public string InEscrowHomeownerInsurance { get { return _inEscrowHomeownerInsurance; } set { _inEscrowHomeownerInsurance = value; } }
        private Value<string> _inEscrowOther;
        public string InEscrowOther { get { return _inEscrowOther; } set { _inEscrowOther = value; } }
        private Value<string> _inEscrowPropertyTaxes;
        public string InEscrowPropertyTaxes { get { return _inEscrowPropertyTaxes; } set { _inEscrowPropertyTaxes = value; } }
        private Value<DateTime?> _initialCDReceivedDate;
        public DateTime? InitialCDReceivedDate { get { return _initialCDReceivedDate; } set { _initialCDReceivedDate = value; } }
        private Value<string> _mICReference;
        public string MICReference { get { return _mICReference; } set { _mICReference = value; } }
        private Value<bool?> _notNaturalPersonFlag;
        public bool? NotNaturalPersonFlag { get { return _notNaturalPersonFlag; } set { _notNaturalPersonFlag = value; } }
        private Value<decimal?> _pPC1EstimatedEscrowAmount;
        public decimal? PPC1EstimatedEscrowAmount { get { return _pPC1EstimatedEscrowAmount; } set { _pPC1EstimatedEscrowAmount = value; } }
        private Value<string> _pPC1EstimatedEscrowAmountUI;
        public string PPC1EstimatedEscrowAmountUI { get { return _pPC1EstimatedEscrowAmountUI; } set { _pPC1EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC1InterestOnly;
        public bool? PPC1InterestOnly { get { return _pPC1InterestOnly; } set { _pPC1InterestOnly = value; } }
        private Value<decimal?> _pPC1MaximumMonthlyPayment;
        public decimal? PPC1MaximumMonthlyPayment { get { return _pPC1MaximumMonthlyPayment; } set { _pPC1MaximumMonthlyPayment = value; } }
        private Value<string> _pPC1MaximumMonthlyPaymentUI;
        public string PPC1MaximumMonthlyPaymentUI { get { return _pPC1MaximumMonthlyPaymentUI; } set { _pPC1MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC1MaximumPIPayment;
        public decimal? PPC1MaximumPIPayment { get { return _pPC1MaximumPIPayment; } set { _pPC1MaximumPIPayment = value; } }
        private Value<string> _pPC1MaximumPIPaymentUI;
        public string PPC1MaximumPIPaymentUI { get { return _pPC1MaximumPIPaymentUI; } set { _pPC1MaximumPIPaymentUI = value; } }
        private Value<decimal?> _pPC1MIAmount;
        public decimal? PPC1MIAmount { get { return _pPC1MIAmount; } set { _pPC1MIAmount = value; } }
        private Value<string> _pPC1MIAmountUI;
        public string PPC1MIAmountUI { get { return _pPC1MIAmountUI; } set { _pPC1MIAmountUI = value; } }
        private Value<decimal?> _pPC1MinimumMonthlyPayment;
        public decimal? PPC1MinimumMonthlyPayment { get { return _pPC1MinimumMonthlyPayment; } set { _pPC1MinimumMonthlyPayment = value; } }
        private Value<string> _pPC1MinimumMonthlyPaymentUI;
        public string PPC1MinimumMonthlyPaymentUI { get { return _pPC1MinimumMonthlyPaymentUI; } set { _pPC1MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC1MinimumPIPayment;
        public decimal? PPC1MinimumPIPayment { get { return _pPC1MinimumPIPayment; } set { _pPC1MinimumPIPayment = value; } }
        private Value<string> _pPC1MinimumPIPaymentUI;
        public string PPC1MinimumPIPaymentUI { get { return _pPC1MinimumPIPaymentUI; } set { _pPC1MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC1Year;
        public int? PPC1Year { get { return _pPC1Year; } set { _pPC1Year = value; } }
        private Value<decimal?> _pPC2EstimatedEscrowAmount;
        public decimal? PPC2EstimatedEscrowAmount { get { return _pPC2EstimatedEscrowAmount; } set { _pPC2EstimatedEscrowAmount = value; } }
        private Value<string> _pPC2EstimatedEscrowAmountUI;
        public string PPC2EstimatedEscrowAmountUI { get { return _pPC2EstimatedEscrowAmountUI; } set { _pPC2EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC2InterestOnly;
        public bool? PPC2InterestOnly { get { return _pPC2InterestOnly; } set { _pPC2InterestOnly = value; } }
        private Value<decimal?> _pPC2MaximumMonthlyPayment;
        public decimal? PPC2MaximumMonthlyPayment { get { return _pPC2MaximumMonthlyPayment; } set { _pPC2MaximumMonthlyPayment = value; } }
        private Value<string> _pPC2MaximumMonthlyPaymentUI;
        public string PPC2MaximumMonthlyPaymentUI { get { return _pPC2MaximumMonthlyPaymentUI; } set { _pPC2MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC2MaximumPIPayment;
        public decimal? PPC2MaximumPIPayment { get { return _pPC2MaximumPIPayment; } set { _pPC2MaximumPIPayment = value; } }
        private Value<string> _pPC2MaximumPIPaymentUI;
        public string PPC2MaximumPIPaymentUI { get { return _pPC2MaximumPIPaymentUI; } set { _pPC2MaximumPIPaymentUI = value; } }
        private Value<decimal?> _pPC2MIAmount;
        public decimal? PPC2MIAmount { get { return _pPC2MIAmount; } set { _pPC2MIAmount = value; } }
        private Value<string> _pPC2MIAmountUI;
        public string PPC2MIAmountUI { get { return _pPC2MIAmountUI; } set { _pPC2MIAmountUI = value; } }
        private Value<decimal?> _pPC2MinimumMonthlyPayment;
        public decimal? PPC2MinimumMonthlyPayment { get { return _pPC2MinimumMonthlyPayment; } set { _pPC2MinimumMonthlyPayment = value; } }
        private Value<string> _pPC2MinimumMonthlyPaymentUI;
        public string PPC2MinimumMonthlyPaymentUI { get { return _pPC2MinimumMonthlyPaymentUI; } set { _pPC2MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC2MinimumPIPayment;
        public decimal? PPC2MinimumPIPayment { get { return _pPC2MinimumPIPayment; } set { _pPC2MinimumPIPayment = value; } }
        private Value<string> _pPC2MinimumPIPaymentUI;
        public string PPC2MinimumPIPaymentUI { get { return _pPC2MinimumPIPaymentUI; } set { _pPC2MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC2YearFrom;
        public int? PPC2YearFrom { get { return _pPC2YearFrom; } set { _pPC2YearFrom = value; } }
        private Value<int?> _pPC2YearTo;
        public int? PPC2YearTo { get { return _pPC2YearTo; } set { _pPC2YearTo = value; } }
        private Value<decimal?> _pPC3EstimatedEscrowAmount;
        public decimal? PPC3EstimatedEscrowAmount { get { return _pPC3EstimatedEscrowAmount; } set { _pPC3EstimatedEscrowAmount = value; } }
        private Value<string> _pPC3EstimatedEscrowAmountUI;
        public string PPC3EstimatedEscrowAmountUI { get { return _pPC3EstimatedEscrowAmountUI; } set { _pPC3EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC3InterestOnly;
        public bool? PPC3InterestOnly { get { return _pPC3InterestOnly; } set { _pPC3InterestOnly = value; } }
        private Value<decimal?> _pPC3MaximumMonthlyPayment;
        public decimal? PPC3MaximumMonthlyPayment { get { return _pPC3MaximumMonthlyPayment; } set { _pPC3MaximumMonthlyPayment = value; } }
        private Value<string> _pPC3MaximumMonthlyPaymentUI;
        public string PPC3MaximumMonthlyPaymentUI { get { return _pPC3MaximumMonthlyPaymentUI; } set { _pPC3MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC3MaximumPIPayment;
        public decimal? PPC3MaximumPIPayment { get { return _pPC3MaximumPIPayment; } set { _pPC3MaximumPIPayment = value; } }
        private Value<string> _pPC3MaximumPIPaymentUI;
        public string PPC3MaximumPIPaymentUI { get { return _pPC3MaximumPIPaymentUI; } set { _pPC3MaximumPIPaymentUI = value; } }
        private Value<decimal?> _pPC3MIAmount;
        public decimal? PPC3MIAmount { get { return _pPC3MIAmount; } set { _pPC3MIAmount = value; } }
        private Value<string> _pPC3MIAmountUI;
        public string PPC3MIAmountUI { get { return _pPC3MIAmountUI; } set { _pPC3MIAmountUI = value; } }
        private Value<decimal?> _pPC3MinimumMonthlyPayment;
        public decimal? PPC3MinimumMonthlyPayment { get { return _pPC3MinimumMonthlyPayment; } set { _pPC3MinimumMonthlyPayment = value; } }
        private Value<string> _pPC3MinimumMonthlyPaymentUI;
        public string PPC3MinimumMonthlyPaymentUI { get { return _pPC3MinimumMonthlyPaymentUI; } set { _pPC3MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC3MinimumPIPayment;
        public decimal? PPC3MinimumPIPayment { get { return _pPC3MinimumPIPayment; } set { _pPC3MinimumPIPayment = value; } }
        private Value<string> _pPC3MinimumPIPaymentUI;
        public string PPC3MinimumPIPaymentUI { get { return _pPC3MinimumPIPaymentUI; } set { _pPC3MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC3YearFrom;
        public int? PPC3YearFrom { get { return _pPC3YearFrom; } set { _pPC3YearFrom = value; } }
        private Value<int?> _pPC3YearTo;
        public int? PPC3YearTo { get { return _pPC3YearTo; } set { _pPC3YearTo = value; } }
        private Value<decimal?> _pPC4EstimatedEscrowAmount;
        public decimal? PPC4EstimatedEscrowAmount { get { return _pPC4EstimatedEscrowAmount; } set { _pPC4EstimatedEscrowAmount = value; } }
        private Value<string> _pPC4EstimatedEscrowAmountUI;
        public string PPC4EstimatedEscrowAmountUI { get { return _pPC4EstimatedEscrowAmountUI; } set { _pPC4EstimatedEscrowAmountUI = value; } }
        private Value<bool?> _pPC4InterestOnly;
        public bool? PPC4InterestOnly { get { return _pPC4InterestOnly; } set { _pPC4InterestOnly = value; } }
        private Value<decimal?> _pPC4MaximumMonthlyPayment;
        public decimal? PPC4MaximumMonthlyPayment { get { return _pPC4MaximumMonthlyPayment; } set { _pPC4MaximumMonthlyPayment = value; } }
        private Value<string> _pPC4MaximumMonthlyPaymentUI;
        public string PPC4MaximumMonthlyPaymentUI { get { return _pPC4MaximumMonthlyPaymentUI; } set { _pPC4MaximumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC4MaximumPIPayment;
        public decimal? PPC4MaximumPIPayment { get { return _pPC4MaximumPIPayment; } set { _pPC4MaximumPIPayment = value; } }
        private Value<string> _pPC4MaximumPIPaymentUI;
        public string PPC4MaximumPIPaymentUI { get { return _pPC4MaximumPIPaymentUI; } set { _pPC4MaximumPIPaymentUI = value; } }
        private Value<decimal?> _pPC4MIAmount;
        public decimal? PPC4MIAmount { get { return _pPC4MIAmount; } set { _pPC4MIAmount = value; } }
        private Value<string> _pPC4MIAmountUI;
        public string PPC4MIAmountUI { get { return _pPC4MIAmountUI; } set { _pPC4MIAmountUI = value; } }
        private Value<decimal?> _pPC4MinimumMonthlyPayment;
        public decimal? PPC4MinimumMonthlyPayment { get { return _pPC4MinimumMonthlyPayment; } set { _pPC4MinimumMonthlyPayment = value; } }
        private Value<string> _pPC4MinimumMonthlyPaymentUI;
        public string PPC4MinimumMonthlyPaymentUI { get { return _pPC4MinimumMonthlyPaymentUI; } set { _pPC4MinimumMonthlyPaymentUI = value; } }
        private Value<decimal?> _pPC4MinimumPIPayment;
        public decimal? PPC4MinimumPIPayment { get { return _pPC4MinimumPIPayment; } set { _pPC4MinimumPIPayment = value; } }
        private Value<string> _pPC4MinimumPIPaymentUI;
        public string PPC4MinimumPIPaymentUI { get { return _pPC4MinimumPIPaymentUI; } set { _pPC4MinimumPIPaymentUI = value; } }
        private Value<int?> _pPC4YearFrom;
        public int? PPC4YearFrom { get { return _pPC4YearFrom; } set { _pPC4YearFrom = value; } }
        private Value<int?> _pPC4YearTo;
        public int? PPC4YearTo { get { return _pPC4YearTo; } set { _pPC4YearTo = value; } }
        private Value<bool?> _pPCEstimatedEscrowIndicator;
        public bool? PPCEstimatedEscrowIndicator { get { return _pPCEstimatedEscrowIndicator; } set { _pPCEstimatedEscrowIndicator = value; } }
        private Value<bool?> _pPCMortgageInsuranceIndicator;
        public bool? PPCMortgageInsuranceIndicator { get { return _pPCMortgageInsuranceIndicator; } set { _pPCMortgageInsuranceIndicator = value; } }
        private Value<bool?> _rangePaymentIndicatorC1;
        public bool? RangePaymentIndicatorC1 { get { return _rangePaymentIndicatorC1; } set { _rangePaymentIndicatorC1 = value; } }
        private Value<bool?> _rangePaymentIndicatorC2;
        public bool? RangePaymentIndicatorC2 { get { return _rangePaymentIndicatorC2; } set { _rangePaymentIndicatorC2 = value; } }
        private Value<bool?> _rangePaymentIndicatorC3;
        public bool? RangePaymentIndicatorC3 { get { return _rangePaymentIndicatorC3; } set { _rangePaymentIndicatorC3 = value; } }
        private Value<bool?> _rangePaymentIndicatorC4;
        public bool? RangePaymentIndicatorC4 { get { return _rangePaymentIndicatorC4; } set { _rangePaymentIndicatorC4 = value; } }
        private Value<bool?> _reasonAdvancedReview;
        public bool? ReasonAdvancedReview { get { return _reasonAdvancedReview; } set { _reasonAdvancedReview = value; } }
        private Value<bool?> _reasonChangedCircumstanceElg;
        public bool? ReasonChangedCircumstanceElg { get { return _reasonChangedCircumstanceElg; } set { _reasonChangedCircumstanceElg = value; } }
        private Value<string> _reasonChangedCircumstanceFlags;
        public string ReasonChangedCircumstanceFlags { get { return _reasonChangedCircumstanceFlags; } set { _reasonChangedCircumstanceFlags = value; } }
        private Value<bool?> _reasonChangeInAPR;
        public bool? ReasonChangeInAPR { get { return _reasonChangeInAPR; } set { _reasonChangeInAPR = value; } }
        private Value<bool?> _reasonChangeInLoanProduct;
        public bool? ReasonChangeInLoanProduct { get { return _reasonChangeInLoanProduct; } set { _reasonChangeInLoanProduct = value; } }
        private Value<bool?> _reasonChangeSettlementCharges;
        public bool? ReasonChangeSettlementCharges { get { return _reasonChangeSettlementCharges; } set { _reasonChangeSettlementCharges = value; } }
        private Value<bool?> _reasonClericalErrorCorrection;
        public bool? ReasonClericalErrorCorrection { get { return _reasonClericalErrorCorrection; } set { _reasonClericalErrorCorrection = value; } }
        private Value<bool?> _reasonInterestRatecharges;
        public bool? ReasonInterestRatecharges { get { return _reasonInterestRatecharges; } set { _reasonInterestRatecharges = value; } }
        private Value<bool?> _reasonOther;
        public bool? ReasonOther { get { return _reasonOther; } set { _reasonOther = value; } }
        private Value<string> _reasonOtherDescription;
        public string ReasonOtherDescription { get { return _reasonOtherDescription; } set { _reasonOtherDescription = value; } }
        private Value<bool?> _reasonPrepaymentPenalty;
        public bool? ReasonPrepaymentPenalty { get { return _reasonPrepaymentPenalty; } set { _reasonPrepaymentPenalty = value; } }
        private Value<bool?> _reasonRevisionsReqConsumer;
        public bool? ReasonRevisionsReqConsumer { get { return _reasonRevisionsReqConsumer; } set { _reasonRevisionsReqConsumer = value; } }
        private Value<bool?> _reasonToleranceCure;
        public bool? ReasonToleranceCure { get { return _reasonToleranceCure; } set { _reasonToleranceCure = value; } }
        private Value<DateTime?> _revisedCDDueDate;
        public DateTime? RevisedCDDueDate { get { return _revisedCDDueDate; } set { _revisedCDDueDate = value; } }
        private Value<DateTime?> _revisedCDReceivedDate;
        public DateTime? RevisedCDReceivedDate { get { return _revisedCDReceivedDate; } set { _revisedCDReceivedDate = value; } }
        private Value<string> _sellerNames;
        public string SellerNames { get { return _sellerNames; } set { _sellerNames = value; } }
        private Value<string> _signatureTypeFinalExecutedCopyofAlternateCD;
        public string SignatureTypeFinalExecutedCopyofAlternateCD { get { return _signatureTypeFinalExecutedCopyofAlternateCD; } set { _signatureTypeFinalExecutedCopyofAlternateCD = value; } }
        private Value<string> _signatureTypeFinalExecutedCopyofSellerCD;
        public string SignatureTypeFinalExecutedCopyofSellerCD { get { return _signatureTypeFinalExecutedCopyofSellerCD; } set { _signatureTypeFinalExecutedCopyofSellerCD = value; } }
        private Value<string> _signatureTypeFinalExecutedCopyofStandardCD;
        public string SignatureTypeFinalExecutedCopyofStandardCD { get { return _signatureTypeFinalExecutedCopyofStandardCD; } set { _signatureTypeFinalExecutedCopyofStandardCD = value; } }
        private Value<decimal?> _totalCashToClose;
        public decimal? TotalCashToClose { get { return _totalCashToClose; } set { _totalCashToClose = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _cDDateIssued.Clean
                    && _changedCircumstance.Clean
                    && _changedCircumstanceFlag.Clean
                    && _changesReceivedDate.Clean
                    && _comments.Clean
                    && _disclosureBy.Clean
                    && _disclosureComments.Clean
                    && _disclosureLastSentDate.Clean
                    && _disclosureReceivedDate.Clean
                    && _disclosureSentMethod.Clean
                    && _documentGUIDFinalExecutedCopyofAlternateCD.Clean
                    && _documentGUIDFinalExecutedCopyofSellerCD.Clean
                    && _documentGUIDFinalExecutedCopyofStandardCD.Clean
                    && _estimatedTaxesInsuranceAssessments.Clean
                    && _id.Clean
                    && _inEscrowHomeownerInsurance.Clean
                    && _inEscrowOther.Clean
                    && _inEscrowPropertyTaxes.Clean
                    && _initialCDReceivedDate.Clean
                    && _mICReference.Clean
                    && _notNaturalPersonFlag.Clean
                    && _pPC1EstimatedEscrowAmount.Clean
                    && _pPC1EstimatedEscrowAmountUI.Clean
                    && _pPC1InterestOnly.Clean
                    && _pPC1MaximumMonthlyPayment.Clean
                    && _pPC1MaximumMonthlyPaymentUI.Clean
                    && _pPC1MaximumPIPayment.Clean
                    && _pPC1MaximumPIPaymentUI.Clean
                    && _pPC1MIAmount.Clean
                    && _pPC1MIAmountUI.Clean
                    && _pPC1MinimumMonthlyPayment.Clean
                    && _pPC1MinimumMonthlyPaymentUI.Clean
                    && _pPC1MinimumPIPayment.Clean
                    && _pPC1MinimumPIPaymentUI.Clean
                    && _pPC1Year.Clean
                    && _pPC2EstimatedEscrowAmount.Clean
                    && _pPC2EstimatedEscrowAmountUI.Clean
                    && _pPC2InterestOnly.Clean
                    && _pPC2MaximumMonthlyPayment.Clean
                    && _pPC2MaximumMonthlyPaymentUI.Clean
                    && _pPC2MaximumPIPayment.Clean
                    && _pPC2MaximumPIPaymentUI.Clean
                    && _pPC2MIAmount.Clean
                    && _pPC2MIAmountUI.Clean
                    && _pPC2MinimumMonthlyPayment.Clean
                    && _pPC2MinimumMonthlyPaymentUI.Clean
                    && _pPC2MinimumPIPayment.Clean
                    && _pPC2MinimumPIPaymentUI.Clean
                    && _pPC2YearFrom.Clean
                    && _pPC2YearTo.Clean
                    && _pPC3EstimatedEscrowAmount.Clean
                    && _pPC3EstimatedEscrowAmountUI.Clean
                    && _pPC3InterestOnly.Clean
                    && _pPC3MaximumMonthlyPayment.Clean
                    && _pPC3MaximumMonthlyPaymentUI.Clean
                    && _pPC3MaximumPIPayment.Clean
                    && _pPC3MaximumPIPaymentUI.Clean
                    && _pPC3MIAmount.Clean
                    && _pPC3MIAmountUI.Clean
                    && _pPC3MinimumMonthlyPayment.Clean
                    && _pPC3MinimumMonthlyPaymentUI.Clean
                    && _pPC3MinimumPIPayment.Clean
                    && _pPC3MinimumPIPaymentUI.Clean
                    && _pPC3YearFrom.Clean
                    && _pPC3YearTo.Clean
                    && _pPC4EstimatedEscrowAmount.Clean
                    && _pPC4EstimatedEscrowAmountUI.Clean
                    && _pPC4InterestOnly.Clean
                    && _pPC4MaximumMonthlyPayment.Clean
                    && _pPC4MaximumMonthlyPaymentUI.Clean
                    && _pPC4MaximumPIPayment.Clean
                    && _pPC4MaximumPIPaymentUI.Clean
                    && _pPC4MIAmount.Clean
                    && _pPC4MIAmountUI.Clean
                    && _pPC4MinimumMonthlyPayment.Clean
                    && _pPC4MinimumMonthlyPaymentUI.Clean
                    && _pPC4MinimumPIPayment.Clean
                    && _pPC4MinimumPIPaymentUI.Clean
                    && _pPC4YearFrom.Clean
                    && _pPC4YearTo.Clean
                    && _pPCEstimatedEscrowIndicator.Clean
                    && _pPCMortgageInsuranceIndicator.Clean
                    && _rangePaymentIndicatorC1.Clean
                    && _rangePaymentIndicatorC2.Clean
                    && _rangePaymentIndicatorC3.Clean
                    && _rangePaymentIndicatorC4.Clean
                    && _reasonAdvancedReview.Clean
                    && _reasonChangedCircumstanceElg.Clean
                    && _reasonChangedCircumstanceFlags.Clean
                    && _reasonChangeInAPR.Clean
                    && _reasonChangeInLoanProduct.Clean
                    && _reasonChangeSettlementCharges.Clean
                    && _reasonClericalErrorCorrection.Clean
                    && _reasonInterestRatecharges.Clean
                    && _reasonOther.Clean
                    && _reasonOtherDescription.Clean
                    && _reasonPrepaymentPenalty.Clean
                    && _reasonRevisionsReqConsumer.Clean
                    && _reasonToleranceCure.Clean
                    && _revisedCDDueDate.Clean
                    && _revisedCDReceivedDate.Clean
                    && _sellerNames.Clean
                    && _signatureTypeFinalExecutedCopyofAlternateCD.Clean
                    && _signatureTypeFinalExecutedCopyofSellerCD.Clean
                    && _signatureTypeFinalExecutedCopyofStandardCD.Clean
                    && _totalCashToClose.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _cDDateIssued; v0.Clean = value; _cDDateIssued = v0;
                var v1 = _changedCircumstance; v1.Clean = value; _changedCircumstance = v1;
                var v2 = _changedCircumstanceFlag; v2.Clean = value; _changedCircumstanceFlag = v2;
                var v3 = _changesReceivedDate; v3.Clean = value; _changesReceivedDate = v3;
                var v4 = _comments; v4.Clean = value; _comments = v4;
                var v5 = _disclosureBy; v5.Clean = value; _disclosureBy = v5;
                var v6 = _disclosureComments; v6.Clean = value; _disclosureComments = v6;
                var v7 = _disclosureLastSentDate; v7.Clean = value; _disclosureLastSentDate = v7;
                var v8 = _disclosureReceivedDate; v8.Clean = value; _disclosureReceivedDate = v8;
                var v9 = _disclosureSentMethod; v9.Clean = value; _disclosureSentMethod = v9;
                var v10 = _documentGUIDFinalExecutedCopyofAlternateCD; v10.Clean = value; _documentGUIDFinalExecutedCopyofAlternateCD = v10;
                var v11 = _documentGUIDFinalExecutedCopyofSellerCD; v11.Clean = value; _documentGUIDFinalExecutedCopyofSellerCD = v11;
                var v12 = _documentGUIDFinalExecutedCopyofStandardCD; v12.Clean = value; _documentGUIDFinalExecutedCopyofStandardCD = v12;
                var v13 = _estimatedTaxesInsuranceAssessments; v13.Clean = value; _estimatedTaxesInsuranceAssessments = v13;
                var v14 = _id; v14.Clean = value; _id = v14;
                var v15 = _inEscrowHomeownerInsurance; v15.Clean = value; _inEscrowHomeownerInsurance = v15;
                var v16 = _inEscrowOther; v16.Clean = value; _inEscrowOther = v16;
                var v17 = _inEscrowPropertyTaxes; v17.Clean = value; _inEscrowPropertyTaxes = v17;
                var v18 = _initialCDReceivedDate; v18.Clean = value; _initialCDReceivedDate = v18;
                var v19 = _mICReference; v19.Clean = value; _mICReference = v19;
                var v20 = _notNaturalPersonFlag; v20.Clean = value; _notNaturalPersonFlag = v20;
                var v21 = _pPC1EstimatedEscrowAmount; v21.Clean = value; _pPC1EstimatedEscrowAmount = v21;
                var v22 = _pPC1EstimatedEscrowAmountUI; v22.Clean = value; _pPC1EstimatedEscrowAmountUI = v22;
                var v23 = _pPC1InterestOnly; v23.Clean = value; _pPC1InterestOnly = v23;
                var v24 = _pPC1MaximumMonthlyPayment; v24.Clean = value; _pPC1MaximumMonthlyPayment = v24;
                var v25 = _pPC1MaximumMonthlyPaymentUI; v25.Clean = value; _pPC1MaximumMonthlyPaymentUI = v25;
                var v26 = _pPC1MaximumPIPayment; v26.Clean = value; _pPC1MaximumPIPayment = v26;
                var v27 = _pPC1MaximumPIPaymentUI; v27.Clean = value; _pPC1MaximumPIPaymentUI = v27;
                var v28 = _pPC1MIAmount; v28.Clean = value; _pPC1MIAmount = v28;
                var v29 = _pPC1MIAmountUI; v29.Clean = value; _pPC1MIAmountUI = v29;
                var v30 = _pPC1MinimumMonthlyPayment; v30.Clean = value; _pPC1MinimumMonthlyPayment = v30;
                var v31 = _pPC1MinimumMonthlyPaymentUI; v31.Clean = value; _pPC1MinimumMonthlyPaymentUI = v31;
                var v32 = _pPC1MinimumPIPayment; v32.Clean = value; _pPC1MinimumPIPayment = v32;
                var v33 = _pPC1MinimumPIPaymentUI; v33.Clean = value; _pPC1MinimumPIPaymentUI = v33;
                var v34 = _pPC1Year; v34.Clean = value; _pPC1Year = v34;
                var v35 = _pPC2EstimatedEscrowAmount; v35.Clean = value; _pPC2EstimatedEscrowAmount = v35;
                var v36 = _pPC2EstimatedEscrowAmountUI; v36.Clean = value; _pPC2EstimatedEscrowAmountUI = v36;
                var v37 = _pPC2InterestOnly; v37.Clean = value; _pPC2InterestOnly = v37;
                var v38 = _pPC2MaximumMonthlyPayment; v38.Clean = value; _pPC2MaximumMonthlyPayment = v38;
                var v39 = _pPC2MaximumMonthlyPaymentUI; v39.Clean = value; _pPC2MaximumMonthlyPaymentUI = v39;
                var v40 = _pPC2MaximumPIPayment; v40.Clean = value; _pPC2MaximumPIPayment = v40;
                var v41 = _pPC2MaximumPIPaymentUI; v41.Clean = value; _pPC2MaximumPIPaymentUI = v41;
                var v42 = _pPC2MIAmount; v42.Clean = value; _pPC2MIAmount = v42;
                var v43 = _pPC2MIAmountUI; v43.Clean = value; _pPC2MIAmountUI = v43;
                var v44 = _pPC2MinimumMonthlyPayment; v44.Clean = value; _pPC2MinimumMonthlyPayment = v44;
                var v45 = _pPC2MinimumMonthlyPaymentUI; v45.Clean = value; _pPC2MinimumMonthlyPaymentUI = v45;
                var v46 = _pPC2MinimumPIPayment; v46.Clean = value; _pPC2MinimumPIPayment = v46;
                var v47 = _pPC2MinimumPIPaymentUI; v47.Clean = value; _pPC2MinimumPIPaymentUI = v47;
                var v48 = _pPC2YearFrom; v48.Clean = value; _pPC2YearFrom = v48;
                var v49 = _pPC2YearTo; v49.Clean = value; _pPC2YearTo = v49;
                var v50 = _pPC3EstimatedEscrowAmount; v50.Clean = value; _pPC3EstimatedEscrowAmount = v50;
                var v51 = _pPC3EstimatedEscrowAmountUI; v51.Clean = value; _pPC3EstimatedEscrowAmountUI = v51;
                var v52 = _pPC3InterestOnly; v52.Clean = value; _pPC3InterestOnly = v52;
                var v53 = _pPC3MaximumMonthlyPayment; v53.Clean = value; _pPC3MaximumMonthlyPayment = v53;
                var v54 = _pPC3MaximumMonthlyPaymentUI; v54.Clean = value; _pPC3MaximumMonthlyPaymentUI = v54;
                var v55 = _pPC3MaximumPIPayment; v55.Clean = value; _pPC3MaximumPIPayment = v55;
                var v56 = _pPC3MaximumPIPaymentUI; v56.Clean = value; _pPC3MaximumPIPaymentUI = v56;
                var v57 = _pPC3MIAmount; v57.Clean = value; _pPC3MIAmount = v57;
                var v58 = _pPC3MIAmountUI; v58.Clean = value; _pPC3MIAmountUI = v58;
                var v59 = _pPC3MinimumMonthlyPayment; v59.Clean = value; _pPC3MinimumMonthlyPayment = v59;
                var v60 = _pPC3MinimumMonthlyPaymentUI; v60.Clean = value; _pPC3MinimumMonthlyPaymentUI = v60;
                var v61 = _pPC3MinimumPIPayment; v61.Clean = value; _pPC3MinimumPIPayment = v61;
                var v62 = _pPC3MinimumPIPaymentUI; v62.Clean = value; _pPC3MinimumPIPaymentUI = v62;
                var v63 = _pPC3YearFrom; v63.Clean = value; _pPC3YearFrom = v63;
                var v64 = _pPC3YearTo; v64.Clean = value; _pPC3YearTo = v64;
                var v65 = _pPC4EstimatedEscrowAmount; v65.Clean = value; _pPC4EstimatedEscrowAmount = v65;
                var v66 = _pPC4EstimatedEscrowAmountUI; v66.Clean = value; _pPC4EstimatedEscrowAmountUI = v66;
                var v67 = _pPC4InterestOnly; v67.Clean = value; _pPC4InterestOnly = v67;
                var v68 = _pPC4MaximumMonthlyPayment; v68.Clean = value; _pPC4MaximumMonthlyPayment = v68;
                var v69 = _pPC4MaximumMonthlyPaymentUI; v69.Clean = value; _pPC4MaximumMonthlyPaymentUI = v69;
                var v70 = _pPC4MaximumPIPayment; v70.Clean = value; _pPC4MaximumPIPayment = v70;
                var v71 = _pPC4MaximumPIPaymentUI; v71.Clean = value; _pPC4MaximumPIPaymentUI = v71;
                var v72 = _pPC4MIAmount; v72.Clean = value; _pPC4MIAmount = v72;
                var v73 = _pPC4MIAmountUI; v73.Clean = value; _pPC4MIAmountUI = v73;
                var v74 = _pPC4MinimumMonthlyPayment; v74.Clean = value; _pPC4MinimumMonthlyPayment = v74;
                var v75 = _pPC4MinimumMonthlyPaymentUI; v75.Clean = value; _pPC4MinimumMonthlyPaymentUI = v75;
                var v76 = _pPC4MinimumPIPayment; v76.Clean = value; _pPC4MinimumPIPayment = v76;
                var v77 = _pPC4MinimumPIPaymentUI; v77.Clean = value; _pPC4MinimumPIPaymentUI = v77;
                var v78 = _pPC4YearFrom; v78.Clean = value; _pPC4YearFrom = v78;
                var v79 = _pPC4YearTo; v79.Clean = value; _pPC4YearTo = v79;
                var v80 = _pPCEstimatedEscrowIndicator; v80.Clean = value; _pPCEstimatedEscrowIndicator = v80;
                var v81 = _pPCMortgageInsuranceIndicator; v81.Clean = value; _pPCMortgageInsuranceIndicator = v81;
                var v82 = _rangePaymentIndicatorC1; v82.Clean = value; _rangePaymentIndicatorC1 = v82;
                var v83 = _rangePaymentIndicatorC2; v83.Clean = value; _rangePaymentIndicatorC2 = v83;
                var v84 = _rangePaymentIndicatorC3; v84.Clean = value; _rangePaymentIndicatorC3 = v84;
                var v85 = _rangePaymentIndicatorC4; v85.Clean = value; _rangePaymentIndicatorC4 = v85;
                var v86 = _reasonAdvancedReview; v86.Clean = value; _reasonAdvancedReview = v86;
                var v87 = _reasonChangedCircumstanceElg; v87.Clean = value; _reasonChangedCircumstanceElg = v87;
                var v88 = _reasonChangedCircumstanceFlags; v88.Clean = value; _reasonChangedCircumstanceFlags = v88;
                var v89 = _reasonChangeInAPR; v89.Clean = value; _reasonChangeInAPR = v89;
                var v90 = _reasonChangeInLoanProduct; v90.Clean = value; _reasonChangeInLoanProduct = v90;
                var v91 = _reasonChangeSettlementCharges; v91.Clean = value; _reasonChangeSettlementCharges = v91;
                var v92 = _reasonClericalErrorCorrection; v92.Clean = value; _reasonClericalErrorCorrection = v92;
                var v93 = _reasonInterestRatecharges; v93.Clean = value; _reasonInterestRatecharges = v93;
                var v94 = _reasonOther; v94.Clean = value; _reasonOther = v94;
                var v95 = _reasonOtherDescription; v95.Clean = value; _reasonOtherDescription = v95;
                var v96 = _reasonPrepaymentPenalty; v96.Clean = value; _reasonPrepaymentPenalty = v96;
                var v97 = _reasonRevisionsReqConsumer; v97.Clean = value; _reasonRevisionsReqConsumer = v97;
                var v98 = _reasonToleranceCure; v98.Clean = value; _reasonToleranceCure = v98;
                var v99 = _revisedCDDueDate; v99.Clean = value; _revisedCDDueDate = v99;
                var v100 = _revisedCDReceivedDate; v100.Clean = value; _revisedCDReceivedDate = v100;
                var v101 = _sellerNames; v101.Clean = value; _sellerNames = v101;
                var v102 = _signatureTypeFinalExecutedCopyofAlternateCD; v102.Clean = value; _signatureTypeFinalExecutedCopyofAlternateCD = v102;
                var v103 = _signatureTypeFinalExecutedCopyofSellerCD; v103.Clean = value; _signatureTypeFinalExecutedCopyofSellerCD = v103;
                var v104 = _signatureTypeFinalExecutedCopyofStandardCD; v104.Clean = value; _signatureTypeFinalExecutedCopyofStandardCD = v104;
                var v105 = _totalCashToClose; v105.Clean = value; _totalCashToClose = v105;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDisclosure1()
        {
            Clean = true;
        }
    }
}