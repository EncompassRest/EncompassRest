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
                var cDDateIssued = _cDDateIssued; cDDateIssued.Clean = value; _cDDateIssued = cDDateIssued;
                var changedCircumstance = _changedCircumstance; changedCircumstance.Clean = value; _changedCircumstance = changedCircumstance;
                var changedCircumstanceFlag = _changedCircumstanceFlag; changedCircumstanceFlag.Clean = value; _changedCircumstanceFlag = changedCircumstanceFlag;
                var changesReceivedDate = _changesReceivedDate; changesReceivedDate.Clean = value; _changesReceivedDate = changesReceivedDate;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var disclosureBy = _disclosureBy; disclosureBy.Clean = value; _disclosureBy = disclosureBy;
                var disclosureComments = _disclosureComments; disclosureComments.Clean = value; _disclosureComments = disclosureComments;
                var disclosureLastSentDate = _disclosureLastSentDate; disclosureLastSentDate.Clean = value; _disclosureLastSentDate = disclosureLastSentDate;
                var disclosureReceivedDate = _disclosureReceivedDate; disclosureReceivedDate.Clean = value; _disclosureReceivedDate = disclosureReceivedDate;
                var disclosureSentMethod = _disclosureSentMethod; disclosureSentMethod.Clean = value; _disclosureSentMethod = disclosureSentMethod;
                var documentGUIDFinalExecutedCopyofAlternateCD = _documentGUIDFinalExecutedCopyofAlternateCD; documentGUIDFinalExecutedCopyofAlternateCD.Clean = value; _documentGUIDFinalExecutedCopyofAlternateCD = documentGUIDFinalExecutedCopyofAlternateCD;
                var documentGUIDFinalExecutedCopyofSellerCD = _documentGUIDFinalExecutedCopyofSellerCD; documentGUIDFinalExecutedCopyofSellerCD.Clean = value; _documentGUIDFinalExecutedCopyofSellerCD = documentGUIDFinalExecutedCopyofSellerCD;
                var documentGUIDFinalExecutedCopyofStandardCD = _documentGUIDFinalExecutedCopyofStandardCD; documentGUIDFinalExecutedCopyofStandardCD.Clean = value; _documentGUIDFinalExecutedCopyofStandardCD = documentGUIDFinalExecutedCopyofStandardCD;
                var estimatedTaxesInsuranceAssessments = _estimatedTaxesInsuranceAssessments; estimatedTaxesInsuranceAssessments.Clean = value; _estimatedTaxesInsuranceAssessments = estimatedTaxesInsuranceAssessments;
                var id = _id; id.Clean = value; _id = id;
                var inEscrowHomeownerInsurance = _inEscrowHomeownerInsurance; inEscrowHomeownerInsurance.Clean = value; _inEscrowHomeownerInsurance = inEscrowHomeownerInsurance;
                var inEscrowOther = _inEscrowOther; inEscrowOther.Clean = value; _inEscrowOther = inEscrowOther;
                var inEscrowPropertyTaxes = _inEscrowPropertyTaxes; inEscrowPropertyTaxes.Clean = value; _inEscrowPropertyTaxes = inEscrowPropertyTaxes;
                var initialCDReceivedDate = _initialCDReceivedDate; initialCDReceivedDate.Clean = value; _initialCDReceivedDate = initialCDReceivedDate;
                var mICReference = _mICReference; mICReference.Clean = value; _mICReference = mICReference;
                var notNaturalPersonFlag = _notNaturalPersonFlag; notNaturalPersonFlag.Clean = value; _notNaturalPersonFlag = notNaturalPersonFlag;
                var pPC1EstimatedEscrowAmount = _pPC1EstimatedEscrowAmount; pPC1EstimatedEscrowAmount.Clean = value; _pPC1EstimatedEscrowAmount = pPC1EstimatedEscrowAmount;
                var pPC1EstimatedEscrowAmountUI = _pPC1EstimatedEscrowAmountUI; pPC1EstimatedEscrowAmountUI.Clean = value; _pPC1EstimatedEscrowAmountUI = pPC1EstimatedEscrowAmountUI;
                var pPC1InterestOnly = _pPC1InterestOnly; pPC1InterestOnly.Clean = value; _pPC1InterestOnly = pPC1InterestOnly;
                var pPC1MaximumMonthlyPayment = _pPC1MaximumMonthlyPayment; pPC1MaximumMonthlyPayment.Clean = value; _pPC1MaximumMonthlyPayment = pPC1MaximumMonthlyPayment;
                var pPC1MaximumMonthlyPaymentUI = _pPC1MaximumMonthlyPaymentUI; pPC1MaximumMonthlyPaymentUI.Clean = value; _pPC1MaximumMonthlyPaymentUI = pPC1MaximumMonthlyPaymentUI;
                var pPC1MaximumPIPayment = _pPC1MaximumPIPayment; pPC1MaximumPIPayment.Clean = value; _pPC1MaximumPIPayment = pPC1MaximumPIPayment;
                var pPC1MaximumPIPaymentUI = _pPC1MaximumPIPaymentUI; pPC1MaximumPIPaymentUI.Clean = value; _pPC1MaximumPIPaymentUI = pPC1MaximumPIPaymentUI;
                var pPC1MIAmount = _pPC1MIAmount; pPC1MIAmount.Clean = value; _pPC1MIAmount = pPC1MIAmount;
                var pPC1MIAmountUI = _pPC1MIAmountUI; pPC1MIAmountUI.Clean = value; _pPC1MIAmountUI = pPC1MIAmountUI;
                var pPC1MinimumMonthlyPayment = _pPC1MinimumMonthlyPayment; pPC1MinimumMonthlyPayment.Clean = value; _pPC1MinimumMonthlyPayment = pPC1MinimumMonthlyPayment;
                var pPC1MinimumMonthlyPaymentUI = _pPC1MinimumMonthlyPaymentUI; pPC1MinimumMonthlyPaymentUI.Clean = value; _pPC1MinimumMonthlyPaymentUI = pPC1MinimumMonthlyPaymentUI;
                var pPC1MinimumPIPayment = _pPC1MinimumPIPayment; pPC1MinimumPIPayment.Clean = value; _pPC1MinimumPIPayment = pPC1MinimumPIPayment;
                var pPC1MinimumPIPaymentUI = _pPC1MinimumPIPaymentUI; pPC1MinimumPIPaymentUI.Clean = value; _pPC1MinimumPIPaymentUI = pPC1MinimumPIPaymentUI;
                var pPC1Year = _pPC1Year; pPC1Year.Clean = value; _pPC1Year = pPC1Year;
                var pPC2EstimatedEscrowAmount = _pPC2EstimatedEscrowAmount; pPC2EstimatedEscrowAmount.Clean = value; _pPC2EstimatedEscrowAmount = pPC2EstimatedEscrowAmount;
                var pPC2EstimatedEscrowAmountUI = _pPC2EstimatedEscrowAmountUI; pPC2EstimatedEscrowAmountUI.Clean = value; _pPC2EstimatedEscrowAmountUI = pPC2EstimatedEscrowAmountUI;
                var pPC2InterestOnly = _pPC2InterestOnly; pPC2InterestOnly.Clean = value; _pPC2InterestOnly = pPC2InterestOnly;
                var pPC2MaximumMonthlyPayment = _pPC2MaximumMonthlyPayment; pPC2MaximumMonthlyPayment.Clean = value; _pPC2MaximumMonthlyPayment = pPC2MaximumMonthlyPayment;
                var pPC2MaximumMonthlyPaymentUI = _pPC2MaximumMonthlyPaymentUI; pPC2MaximumMonthlyPaymentUI.Clean = value; _pPC2MaximumMonthlyPaymentUI = pPC2MaximumMonthlyPaymentUI;
                var pPC2MaximumPIPayment = _pPC2MaximumPIPayment; pPC2MaximumPIPayment.Clean = value; _pPC2MaximumPIPayment = pPC2MaximumPIPayment;
                var pPC2MaximumPIPaymentUI = _pPC2MaximumPIPaymentUI; pPC2MaximumPIPaymentUI.Clean = value; _pPC2MaximumPIPaymentUI = pPC2MaximumPIPaymentUI;
                var pPC2MIAmount = _pPC2MIAmount; pPC2MIAmount.Clean = value; _pPC2MIAmount = pPC2MIAmount;
                var pPC2MIAmountUI = _pPC2MIAmountUI; pPC2MIAmountUI.Clean = value; _pPC2MIAmountUI = pPC2MIAmountUI;
                var pPC2MinimumMonthlyPayment = _pPC2MinimumMonthlyPayment; pPC2MinimumMonthlyPayment.Clean = value; _pPC2MinimumMonthlyPayment = pPC2MinimumMonthlyPayment;
                var pPC2MinimumMonthlyPaymentUI = _pPC2MinimumMonthlyPaymentUI; pPC2MinimumMonthlyPaymentUI.Clean = value; _pPC2MinimumMonthlyPaymentUI = pPC2MinimumMonthlyPaymentUI;
                var pPC2MinimumPIPayment = _pPC2MinimumPIPayment; pPC2MinimumPIPayment.Clean = value; _pPC2MinimumPIPayment = pPC2MinimumPIPayment;
                var pPC2MinimumPIPaymentUI = _pPC2MinimumPIPaymentUI; pPC2MinimumPIPaymentUI.Clean = value; _pPC2MinimumPIPaymentUI = pPC2MinimumPIPaymentUI;
                var pPC2YearFrom = _pPC2YearFrom; pPC2YearFrom.Clean = value; _pPC2YearFrom = pPC2YearFrom;
                var pPC2YearTo = _pPC2YearTo; pPC2YearTo.Clean = value; _pPC2YearTo = pPC2YearTo;
                var pPC3EstimatedEscrowAmount = _pPC3EstimatedEscrowAmount; pPC3EstimatedEscrowAmount.Clean = value; _pPC3EstimatedEscrowAmount = pPC3EstimatedEscrowAmount;
                var pPC3EstimatedEscrowAmountUI = _pPC3EstimatedEscrowAmountUI; pPC3EstimatedEscrowAmountUI.Clean = value; _pPC3EstimatedEscrowAmountUI = pPC3EstimatedEscrowAmountUI;
                var pPC3InterestOnly = _pPC3InterestOnly; pPC3InterestOnly.Clean = value; _pPC3InterestOnly = pPC3InterestOnly;
                var pPC3MaximumMonthlyPayment = _pPC3MaximumMonthlyPayment; pPC3MaximumMonthlyPayment.Clean = value; _pPC3MaximumMonthlyPayment = pPC3MaximumMonthlyPayment;
                var pPC3MaximumMonthlyPaymentUI = _pPC3MaximumMonthlyPaymentUI; pPC3MaximumMonthlyPaymentUI.Clean = value; _pPC3MaximumMonthlyPaymentUI = pPC3MaximumMonthlyPaymentUI;
                var pPC3MaximumPIPayment = _pPC3MaximumPIPayment; pPC3MaximumPIPayment.Clean = value; _pPC3MaximumPIPayment = pPC3MaximumPIPayment;
                var pPC3MaximumPIPaymentUI = _pPC3MaximumPIPaymentUI; pPC3MaximumPIPaymentUI.Clean = value; _pPC3MaximumPIPaymentUI = pPC3MaximumPIPaymentUI;
                var pPC3MIAmount = _pPC3MIAmount; pPC3MIAmount.Clean = value; _pPC3MIAmount = pPC3MIAmount;
                var pPC3MIAmountUI = _pPC3MIAmountUI; pPC3MIAmountUI.Clean = value; _pPC3MIAmountUI = pPC3MIAmountUI;
                var pPC3MinimumMonthlyPayment = _pPC3MinimumMonthlyPayment; pPC3MinimumMonthlyPayment.Clean = value; _pPC3MinimumMonthlyPayment = pPC3MinimumMonthlyPayment;
                var pPC3MinimumMonthlyPaymentUI = _pPC3MinimumMonthlyPaymentUI; pPC3MinimumMonthlyPaymentUI.Clean = value; _pPC3MinimumMonthlyPaymentUI = pPC3MinimumMonthlyPaymentUI;
                var pPC3MinimumPIPayment = _pPC3MinimumPIPayment; pPC3MinimumPIPayment.Clean = value; _pPC3MinimumPIPayment = pPC3MinimumPIPayment;
                var pPC3MinimumPIPaymentUI = _pPC3MinimumPIPaymentUI; pPC3MinimumPIPaymentUI.Clean = value; _pPC3MinimumPIPaymentUI = pPC3MinimumPIPaymentUI;
                var pPC3YearFrom = _pPC3YearFrom; pPC3YearFrom.Clean = value; _pPC3YearFrom = pPC3YearFrom;
                var pPC3YearTo = _pPC3YearTo; pPC3YearTo.Clean = value; _pPC3YearTo = pPC3YearTo;
                var pPC4EstimatedEscrowAmount = _pPC4EstimatedEscrowAmount; pPC4EstimatedEscrowAmount.Clean = value; _pPC4EstimatedEscrowAmount = pPC4EstimatedEscrowAmount;
                var pPC4EstimatedEscrowAmountUI = _pPC4EstimatedEscrowAmountUI; pPC4EstimatedEscrowAmountUI.Clean = value; _pPC4EstimatedEscrowAmountUI = pPC4EstimatedEscrowAmountUI;
                var pPC4InterestOnly = _pPC4InterestOnly; pPC4InterestOnly.Clean = value; _pPC4InterestOnly = pPC4InterestOnly;
                var pPC4MaximumMonthlyPayment = _pPC4MaximumMonthlyPayment; pPC4MaximumMonthlyPayment.Clean = value; _pPC4MaximumMonthlyPayment = pPC4MaximumMonthlyPayment;
                var pPC4MaximumMonthlyPaymentUI = _pPC4MaximumMonthlyPaymentUI; pPC4MaximumMonthlyPaymentUI.Clean = value; _pPC4MaximumMonthlyPaymentUI = pPC4MaximumMonthlyPaymentUI;
                var pPC4MaximumPIPayment = _pPC4MaximumPIPayment; pPC4MaximumPIPayment.Clean = value; _pPC4MaximumPIPayment = pPC4MaximumPIPayment;
                var pPC4MaximumPIPaymentUI = _pPC4MaximumPIPaymentUI; pPC4MaximumPIPaymentUI.Clean = value; _pPC4MaximumPIPaymentUI = pPC4MaximumPIPaymentUI;
                var pPC4MIAmount = _pPC4MIAmount; pPC4MIAmount.Clean = value; _pPC4MIAmount = pPC4MIAmount;
                var pPC4MIAmountUI = _pPC4MIAmountUI; pPC4MIAmountUI.Clean = value; _pPC4MIAmountUI = pPC4MIAmountUI;
                var pPC4MinimumMonthlyPayment = _pPC4MinimumMonthlyPayment; pPC4MinimumMonthlyPayment.Clean = value; _pPC4MinimumMonthlyPayment = pPC4MinimumMonthlyPayment;
                var pPC4MinimumMonthlyPaymentUI = _pPC4MinimumMonthlyPaymentUI; pPC4MinimumMonthlyPaymentUI.Clean = value; _pPC4MinimumMonthlyPaymentUI = pPC4MinimumMonthlyPaymentUI;
                var pPC4MinimumPIPayment = _pPC4MinimumPIPayment; pPC4MinimumPIPayment.Clean = value; _pPC4MinimumPIPayment = pPC4MinimumPIPayment;
                var pPC4MinimumPIPaymentUI = _pPC4MinimumPIPaymentUI; pPC4MinimumPIPaymentUI.Clean = value; _pPC4MinimumPIPaymentUI = pPC4MinimumPIPaymentUI;
                var pPC4YearFrom = _pPC4YearFrom; pPC4YearFrom.Clean = value; _pPC4YearFrom = pPC4YearFrom;
                var pPC4YearTo = _pPC4YearTo; pPC4YearTo.Clean = value; _pPC4YearTo = pPC4YearTo;
                var pPCEstimatedEscrowIndicator = _pPCEstimatedEscrowIndicator; pPCEstimatedEscrowIndicator.Clean = value; _pPCEstimatedEscrowIndicator = pPCEstimatedEscrowIndicator;
                var pPCMortgageInsuranceIndicator = _pPCMortgageInsuranceIndicator; pPCMortgageInsuranceIndicator.Clean = value; _pPCMortgageInsuranceIndicator = pPCMortgageInsuranceIndicator;
                var rangePaymentIndicatorC1 = _rangePaymentIndicatorC1; rangePaymentIndicatorC1.Clean = value; _rangePaymentIndicatorC1 = rangePaymentIndicatorC1;
                var rangePaymentIndicatorC2 = _rangePaymentIndicatorC2; rangePaymentIndicatorC2.Clean = value; _rangePaymentIndicatorC2 = rangePaymentIndicatorC2;
                var rangePaymentIndicatorC3 = _rangePaymentIndicatorC3; rangePaymentIndicatorC3.Clean = value; _rangePaymentIndicatorC3 = rangePaymentIndicatorC3;
                var rangePaymentIndicatorC4 = _rangePaymentIndicatorC4; rangePaymentIndicatorC4.Clean = value; _rangePaymentIndicatorC4 = rangePaymentIndicatorC4;
                var reasonAdvancedReview = _reasonAdvancedReview; reasonAdvancedReview.Clean = value; _reasonAdvancedReview = reasonAdvancedReview;
                var reasonChangedCircumstanceElg = _reasonChangedCircumstanceElg; reasonChangedCircumstanceElg.Clean = value; _reasonChangedCircumstanceElg = reasonChangedCircumstanceElg;
                var reasonChangedCircumstanceFlags = _reasonChangedCircumstanceFlags; reasonChangedCircumstanceFlags.Clean = value; _reasonChangedCircumstanceFlags = reasonChangedCircumstanceFlags;
                var reasonChangeInAPR = _reasonChangeInAPR; reasonChangeInAPR.Clean = value; _reasonChangeInAPR = reasonChangeInAPR;
                var reasonChangeInLoanProduct = _reasonChangeInLoanProduct; reasonChangeInLoanProduct.Clean = value; _reasonChangeInLoanProduct = reasonChangeInLoanProduct;
                var reasonChangeSettlementCharges = _reasonChangeSettlementCharges; reasonChangeSettlementCharges.Clean = value; _reasonChangeSettlementCharges = reasonChangeSettlementCharges;
                var reasonClericalErrorCorrection = _reasonClericalErrorCorrection; reasonClericalErrorCorrection.Clean = value; _reasonClericalErrorCorrection = reasonClericalErrorCorrection;
                var reasonInterestRatecharges = _reasonInterestRatecharges; reasonInterestRatecharges.Clean = value; _reasonInterestRatecharges = reasonInterestRatecharges;
                var reasonOther = _reasonOther; reasonOther.Clean = value; _reasonOther = reasonOther;
                var reasonOtherDescription = _reasonOtherDescription; reasonOtherDescription.Clean = value; _reasonOtherDescription = reasonOtherDescription;
                var reasonPrepaymentPenalty = _reasonPrepaymentPenalty; reasonPrepaymentPenalty.Clean = value; _reasonPrepaymentPenalty = reasonPrepaymentPenalty;
                var reasonRevisionsReqConsumer = _reasonRevisionsReqConsumer; reasonRevisionsReqConsumer.Clean = value; _reasonRevisionsReqConsumer = reasonRevisionsReqConsumer;
                var reasonToleranceCure = _reasonToleranceCure; reasonToleranceCure.Clean = value; _reasonToleranceCure = reasonToleranceCure;
                var revisedCDDueDate = _revisedCDDueDate; revisedCDDueDate.Clean = value; _revisedCDDueDate = revisedCDDueDate;
                var revisedCDReceivedDate = _revisedCDReceivedDate; revisedCDReceivedDate.Clean = value; _revisedCDReceivedDate = revisedCDReceivedDate;
                var sellerNames = _sellerNames; sellerNames.Clean = value; _sellerNames = sellerNames;
                var signatureTypeFinalExecutedCopyofAlternateCD = _signatureTypeFinalExecutedCopyofAlternateCD; signatureTypeFinalExecutedCopyofAlternateCD.Clean = value; _signatureTypeFinalExecutedCopyofAlternateCD = signatureTypeFinalExecutedCopyofAlternateCD;
                var signatureTypeFinalExecutedCopyofSellerCD = _signatureTypeFinalExecutedCopyofSellerCD; signatureTypeFinalExecutedCopyofSellerCD.Clean = value; _signatureTypeFinalExecutedCopyofSellerCD = signatureTypeFinalExecutedCopyofSellerCD;
                var signatureTypeFinalExecutedCopyofStandardCD = _signatureTypeFinalExecutedCopyofStandardCD; signatureTypeFinalExecutedCopyofStandardCD.Clean = value; _signatureTypeFinalExecutedCopyofStandardCD = signatureTypeFinalExecutedCopyofStandardCD;
                var totalCashToClose = _totalCashToClose; totalCashToClose.Clean = value; _totalCashToClose = totalCashToClose;
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