using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure1 : IDirty
    {
        private DirtyValue<DateTime?> _cDDateIssued;
        public DateTime? CDDateIssued { get { return _cDDateIssued; } set { _cDDateIssued = value; } }
        private DirtyValue<string> _changedCircumstance;
        public string ChangedCircumstance { get { return _changedCircumstance; } set { _changedCircumstance = value; } }
        private DirtyValue<bool?> _changedCircumstanceFlag;
        public bool? ChangedCircumstanceFlag { get { return _changedCircumstanceFlag; } set { _changedCircumstanceFlag = value; } }
        private DirtyValue<DateTime?> _changesReceivedDate;
        public DateTime? ChangesReceivedDate { get { return _changesReceivedDate; } set { _changesReceivedDate = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _disclosureBy;
        public string DisclosureBy { get { return _disclosureBy; } set { _disclosureBy = value; } }
        private DirtyValue<string> _disclosureComments;
        public string DisclosureComments { get { return _disclosureComments; } set { _disclosureComments = value; } }
        private DirtyValue<DateTime?> _disclosureLastSentDate;
        public DateTime? DisclosureLastSentDate { get { return _disclosureLastSentDate; } set { _disclosureLastSentDate = value; } }
        private DirtyValue<DateTime?> _disclosureReceivedDate;
        public DateTime? DisclosureReceivedDate { get { return _disclosureReceivedDate; } set { _disclosureReceivedDate = value; } }
        private DirtyValue<string> _disclosureSentMethod;
        public string DisclosureSentMethod { get { return _disclosureSentMethod; } set { _disclosureSentMethod = value; } }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofAlternateCD;
        public string DocumentGUIDFinalExecutedCopyofAlternateCD { get { return _documentGUIDFinalExecutedCopyofAlternateCD; } set { _documentGUIDFinalExecutedCopyofAlternateCD = value; } }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofSellerCD;
        public string DocumentGUIDFinalExecutedCopyofSellerCD { get { return _documentGUIDFinalExecutedCopyofSellerCD; } set { _documentGUIDFinalExecutedCopyofSellerCD = value; } }
        private DirtyValue<string> _documentGUIDFinalExecutedCopyofStandardCD;
        public string DocumentGUIDFinalExecutedCopyofStandardCD { get { return _documentGUIDFinalExecutedCopyofStandardCD; } set { _documentGUIDFinalExecutedCopyofStandardCD = value; } }
        private DirtyValue<decimal?> _estimatedTaxesInsuranceAssessments;
        public decimal? EstimatedTaxesInsuranceAssessments { get { return _estimatedTaxesInsuranceAssessments; } set { _estimatedTaxesInsuranceAssessments = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _inEscrowHomeownerInsurance;
        public string InEscrowHomeownerInsurance { get { return _inEscrowHomeownerInsurance; } set { _inEscrowHomeownerInsurance = value; } }
        private DirtyValue<string> _inEscrowOther;
        public string InEscrowOther { get { return _inEscrowOther; } set { _inEscrowOther = value; } }
        private DirtyValue<string> _inEscrowPropertyTaxes;
        public string InEscrowPropertyTaxes { get { return _inEscrowPropertyTaxes; } set { _inEscrowPropertyTaxes = value; } }
        private DirtyValue<DateTime?> _initialCDReceivedDate;
        public DateTime? InitialCDReceivedDate { get { return _initialCDReceivedDate; } set { _initialCDReceivedDate = value; } }
        private DirtyValue<string> _mICReference;
        public string MICReference { get { return _mICReference; } set { _mICReference = value; } }
        private DirtyValue<bool?> _notNaturalPersonFlag;
        public bool? NotNaturalPersonFlag { get { return _notNaturalPersonFlag; } set { _notNaturalPersonFlag = value; } }
        private DirtyValue<decimal?> _pPC1EstimatedEscrowAmount;
        public decimal? PPC1EstimatedEscrowAmount { get { return _pPC1EstimatedEscrowAmount; } set { _pPC1EstimatedEscrowAmount = value; } }
        private DirtyValue<string> _pPC1EstimatedEscrowAmountUI;
        public string PPC1EstimatedEscrowAmountUI { get { return _pPC1EstimatedEscrowAmountUI; } set { _pPC1EstimatedEscrowAmountUI = value; } }
        private DirtyValue<bool?> _pPC1InterestOnly;
        public bool? PPC1InterestOnly { get { return _pPC1InterestOnly; } set { _pPC1InterestOnly = value; } }
        private DirtyValue<decimal?> _pPC1MaximumMonthlyPayment;
        public decimal? PPC1MaximumMonthlyPayment { get { return _pPC1MaximumMonthlyPayment; } set { _pPC1MaximumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC1MaximumMonthlyPaymentUI;
        public string PPC1MaximumMonthlyPaymentUI { get { return _pPC1MaximumMonthlyPaymentUI; } set { _pPC1MaximumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC1MaximumPIPayment;
        public decimal? PPC1MaximumPIPayment { get { return _pPC1MaximumPIPayment; } set { _pPC1MaximumPIPayment = value; } }
        private DirtyValue<string> _pPC1MaximumPIPaymentUI;
        public string PPC1MaximumPIPaymentUI { get { return _pPC1MaximumPIPaymentUI; } set { _pPC1MaximumPIPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC1MIAmount;
        public decimal? PPC1MIAmount { get { return _pPC1MIAmount; } set { _pPC1MIAmount = value; } }
        private DirtyValue<string> _pPC1MIAmountUI;
        public string PPC1MIAmountUI { get { return _pPC1MIAmountUI; } set { _pPC1MIAmountUI = value; } }
        private DirtyValue<decimal?> _pPC1MinimumMonthlyPayment;
        public decimal? PPC1MinimumMonthlyPayment { get { return _pPC1MinimumMonthlyPayment; } set { _pPC1MinimumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC1MinimumMonthlyPaymentUI;
        public string PPC1MinimumMonthlyPaymentUI { get { return _pPC1MinimumMonthlyPaymentUI; } set { _pPC1MinimumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC1MinimumPIPayment;
        public decimal? PPC1MinimumPIPayment { get { return _pPC1MinimumPIPayment; } set { _pPC1MinimumPIPayment = value; } }
        private DirtyValue<string> _pPC1MinimumPIPaymentUI;
        public string PPC1MinimumPIPaymentUI { get { return _pPC1MinimumPIPaymentUI; } set { _pPC1MinimumPIPaymentUI = value; } }
        private DirtyValue<int?> _pPC1Year;
        public int? PPC1Year { get { return _pPC1Year; } set { _pPC1Year = value; } }
        private DirtyValue<decimal?> _pPC2EstimatedEscrowAmount;
        public decimal? PPC2EstimatedEscrowAmount { get { return _pPC2EstimatedEscrowAmount; } set { _pPC2EstimatedEscrowAmount = value; } }
        private DirtyValue<string> _pPC2EstimatedEscrowAmountUI;
        public string PPC2EstimatedEscrowAmountUI { get { return _pPC2EstimatedEscrowAmountUI; } set { _pPC2EstimatedEscrowAmountUI = value; } }
        private DirtyValue<bool?> _pPC2InterestOnly;
        public bool? PPC2InterestOnly { get { return _pPC2InterestOnly; } set { _pPC2InterestOnly = value; } }
        private DirtyValue<decimal?> _pPC2MaximumMonthlyPayment;
        public decimal? PPC2MaximumMonthlyPayment { get { return _pPC2MaximumMonthlyPayment; } set { _pPC2MaximumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC2MaximumMonthlyPaymentUI;
        public string PPC2MaximumMonthlyPaymentUI { get { return _pPC2MaximumMonthlyPaymentUI; } set { _pPC2MaximumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC2MaximumPIPayment;
        public decimal? PPC2MaximumPIPayment { get { return _pPC2MaximumPIPayment; } set { _pPC2MaximumPIPayment = value; } }
        private DirtyValue<string> _pPC2MaximumPIPaymentUI;
        public string PPC2MaximumPIPaymentUI { get { return _pPC2MaximumPIPaymentUI; } set { _pPC2MaximumPIPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC2MIAmount;
        public decimal? PPC2MIAmount { get { return _pPC2MIAmount; } set { _pPC2MIAmount = value; } }
        private DirtyValue<string> _pPC2MIAmountUI;
        public string PPC2MIAmountUI { get { return _pPC2MIAmountUI; } set { _pPC2MIAmountUI = value; } }
        private DirtyValue<decimal?> _pPC2MinimumMonthlyPayment;
        public decimal? PPC2MinimumMonthlyPayment { get { return _pPC2MinimumMonthlyPayment; } set { _pPC2MinimumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC2MinimumMonthlyPaymentUI;
        public string PPC2MinimumMonthlyPaymentUI { get { return _pPC2MinimumMonthlyPaymentUI; } set { _pPC2MinimumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC2MinimumPIPayment;
        public decimal? PPC2MinimumPIPayment { get { return _pPC2MinimumPIPayment; } set { _pPC2MinimumPIPayment = value; } }
        private DirtyValue<string> _pPC2MinimumPIPaymentUI;
        public string PPC2MinimumPIPaymentUI { get { return _pPC2MinimumPIPaymentUI; } set { _pPC2MinimumPIPaymentUI = value; } }
        private DirtyValue<int?> _pPC2YearFrom;
        public int? PPC2YearFrom { get { return _pPC2YearFrom; } set { _pPC2YearFrom = value; } }
        private DirtyValue<int?> _pPC2YearTo;
        public int? PPC2YearTo { get { return _pPC2YearTo; } set { _pPC2YearTo = value; } }
        private DirtyValue<decimal?> _pPC3EstimatedEscrowAmount;
        public decimal? PPC3EstimatedEscrowAmount { get { return _pPC3EstimatedEscrowAmount; } set { _pPC3EstimatedEscrowAmount = value; } }
        private DirtyValue<string> _pPC3EstimatedEscrowAmountUI;
        public string PPC3EstimatedEscrowAmountUI { get { return _pPC3EstimatedEscrowAmountUI; } set { _pPC3EstimatedEscrowAmountUI = value; } }
        private DirtyValue<bool?> _pPC3InterestOnly;
        public bool? PPC3InterestOnly { get { return _pPC3InterestOnly; } set { _pPC3InterestOnly = value; } }
        private DirtyValue<decimal?> _pPC3MaximumMonthlyPayment;
        public decimal? PPC3MaximumMonthlyPayment { get { return _pPC3MaximumMonthlyPayment; } set { _pPC3MaximumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC3MaximumMonthlyPaymentUI;
        public string PPC3MaximumMonthlyPaymentUI { get { return _pPC3MaximumMonthlyPaymentUI; } set { _pPC3MaximumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC3MaximumPIPayment;
        public decimal? PPC3MaximumPIPayment { get { return _pPC3MaximumPIPayment; } set { _pPC3MaximumPIPayment = value; } }
        private DirtyValue<string> _pPC3MaximumPIPaymentUI;
        public string PPC3MaximumPIPaymentUI { get { return _pPC3MaximumPIPaymentUI; } set { _pPC3MaximumPIPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC3MIAmount;
        public decimal? PPC3MIAmount { get { return _pPC3MIAmount; } set { _pPC3MIAmount = value; } }
        private DirtyValue<string> _pPC3MIAmountUI;
        public string PPC3MIAmountUI { get { return _pPC3MIAmountUI; } set { _pPC3MIAmountUI = value; } }
        private DirtyValue<decimal?> _pPC3MinimumMonthlyPayment;
        public decimal? PPC3MinimumMonthlyPayment { get { return _pPC3MinimumMonthlyPayment; } set { _pPC3MinimumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC3MinimumMonthlyPaymentUI;
        public string PPC3MinimumMonthlyPaymentUI { get { return _pPC3MinimumMonthlyPaymentUI; } set { _pPC3MinimumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC3MinimumPIPayment;
        public decimal? PPC3MinimumPIPayment { get { return _pPC3MinimumPIPayment; } set { _pPC3MinimumPIPayment = value; } }
        private DirtyValue<string> _pPC3MinimumPIPaymentUI;
        public string PPC3MinimumPIPaymentUI { get { return _pPC3MinimumPIPaymentUI; } set { _pPC3MinimumPIPaymentUI = value; } }
        private DirtyValue<int?> _pPC3YearFrom;
        public int? PPC3YearFrom { get { return _pPC3YearFrom; } set { _pPC3YearFrom = value; } }
        private DirtyValue<int?> _pPC3YearTo;
        public int? PPC3YearTo { get { return _pPC3YearTo; } set { _pPC3YearTo = value; } }
        private DirtyValue<decimal?> _pPC4EstimatedEscrowAmount;
        public decimal? PPC4EstimatedEscrowAmount { get { return _pPC4EstimatedEscrowAmount; } set { _pPC4EstimatedEscrowAmount = value; } }
        private DirtyValue<string> _pPC4EstimatedEscrowAmountUI;
        public string PPC4EstimatedEscrowAmountUI { get { return _pPC4EstimatedEscrowAmountUI; } set { _pPC4EstimatedEscrowAmountUI = value; } }
        private DirtyValue<bool?> _pPC4InterestOnly;
        public bool? PPC4InterestOnly { get { return _pPC4InterestOnly; } set { _pPC4InterestOnly = value; } }
        private DirtyValue<decimal?> _pPC4MaximumMonthlyPayment;
        public decimal? PPC4MaximumMonthlyPayment { get { return _pPC4MaximumMonthlyPayment; } set { _pPC4MaximumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC4MaximumMonthlyPaymentUI;
        public string PPC4MaximumMonthlyPaymentUI { get { return _pPC4MaximumMonthlyPaymentUI; } set { _pPC4MaximumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC4MaximumPIPayment;
        public decimal? PPC4MaximumPIPayment { get { return _pPC4MaximumPIPayment; } set { _pPC4MaximumPIPayment = value; } }
        private DirtyValue<string> _pPC4MaximumPIPaymentUI;
        public string PPC4MaximumPIPaymentUI { get { return _pPC4MaximumPIPaymentUI; } set { _pPC4MaximumPIPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC4MIAmount;
        public decimal? PPC4MIAmount { get { return _pPC4MIAmount; } set { _pPC4MIAmount = value; } }
        private DirtyValue<string> _pPC4MIAmountUI;
        public string PPC4MIAmountUI { get { return _pPC4MIAmountUI; } set { _pPC4MIAmountUI = value; } }
        private DirtyValue<decimal?> _pPC4MinimumMonthlyPayment;
        public decimal? PPC4MinimumMonthlyPayment { get { return _pPC4MinimumMonthlyPayment; } set { _pPC4MinimumMonthlyPayment = value; } }
        private DirtyValue<string> _pPC4MinimumMonthlyPaymentUI;
        public string PPC4MinimumMonthlyPaymentUI { get { return _pPC4MinimumMonthlyPaymentUI; } set { _pPC4MinimumMonthlyPaymentUI = value; } }
        private DirtyValue<decimal?> _pPC4MinimumPIPayment;
        public decimal? PPC4MinimumPIPayment { get { return _pPC4MinimumPIPayment; } set { _pPC4MinimumPIPayment = value; } }
        private DirtyValue<string> _pPC4MinimumPIPaymentUI;
        public string PPC4MinimumPIPaymentUI { get { return _pPC4MinimumPIPaymentUI; } set { _pPC4MinimumPIPaymentUI = value; } }
        private DirtyValue<int?> _pPC4YearFrom;
        public int? PPC4YearFrom { get { return _pPC4YearFrom; } set { _pPC4YearFrom = value; } }
        private DirtyValue<int?> _pPC4YearTo;
        public int? PPC4YearTo { get { return _pPC4YearTo; } set { _pPC4YearTo = value; } }
        private DirtyValue<bool?> _pPCEstimatedEscrowIndicator;
        public bool? PPCEstimatedEscrowIndicator { get { return _pPCEstimatedEscrowIndicator; } set { _pPCEstimatedEscrowIndicator = value; } }
        private DirtyValue<bool?> _pPCMortgageInsuranceIndicator;
        public bool? PPCMortgageInsuranceIndicator { get { return _pPCMortgageInsuranceIndicator; } set { _pPCMortgageInsuranceIndicator = value; } }
        private DirtyValue<bool?> _rangePaymentIndicatorC1;
        public bool? RangePaymentIndicatorC1 { get { return _rangePaymentIndicatorC1; } set { _rangePaymentIndicatorC1 = value; } }
        private DirtyValue<bool?> _rangePaymentIndicatorC2;
        public bool? RangePaymentIndicatorC2 { get { return _rangePaymentIndicatorC2; } set { _rangePaymentIndicatorC2 = value; } }
        private DirtyValue<bool?> _rangePaymentIndicatorC3;
        public bool? RangePaymentIndicatorC3 { get { return _rangePaymentIndicatorC3; } set { _rangePaymentIndicatorC3 = value; } }
        private DirtyValue<bool?> _rangePaymentIndicatorC4;
        public bool? RangePaymentIndicatorC4 { get { return _rangePaymentIndicatorC4; } set { _rangePaymentIndicatorC4 = value; } }
        private DirtyValue<bool?> _reasonAdvancedReview;
        public bool? ReasonAdvancedReview { get { return _reasonAdvancedReview; } set { _reasonAdvancedReview = value; } }
        private DirtyValue<bool?> _reasonChangedCircumstanceElg;
        public bool? ReasonChangedCircumstanceElg { get { return _reasonChangedCircumstanceElg; } set { _reasonChangedCircumstanceElg = value; } }
        private DirtyValue<string> _reasonChangedCircumstanceFlags;
        public string ReasonChangedCircumstanceFlags { get { return _reasonChangedCircumstanceFlags; } set { _reasonChangedCircumstanceFlags = value; } }
        private DirtyValue<bool?> _reasonChangeInAPR;
        public bool? ReasonChangeInAPR { get { return _reasonChangeInAPR; } set { _reasonChangeInAPR = value; } }
        private DirtyValue<bool?> _reasonChangeInLoanProduct;
        public bool? ReasonChangeInLoanProduct { get { return _reasonChangeInLoanProduct; } set { _reasonChangeInLoanProduct = value; } }
        private DirtyValue<bool?> _reasonChangeSettlementCharges;
        public bool? ReasonChangeSettlementCharges { get { return _reasonChangeSettlementCharges; } set { _reasonChangeSettlementCharges = value; } }
        private DirtyValue<bool?> _reasonClericalErrorCorrection;
        public bool? ReasonClericalErrorCorrection { get { return _reasonClericalErrorCorrection; } set { _reasonClericalErrorCorrection = value; } }
        private DirtyValue<bool?> _reasonInterestRatecharges;
        public bool? ReasonInterestRatecharges { get { return _reasonInterestRatecharges; } set { _reasonInterestRatecharges = value; } }
        private DirtyValue<bool?> _reasonOther;
        public bool? ReasonOther { get { return _reasonOther; } set { _reasonOther = value; } }
        private DirtyValue<string> _reasonOtherDescription;
        public string ReasonOtherDescription { get { return _reasonOtherDescription; } set { _reasonOtherDescription = value; } }
        private DirtyValue<bool?> _reasonPrepaymentPenalty;
        public bool? ReasonPrepaymentPenalty { get { return _reasonPrepaymentPenalty; } set { _reasonPrepaymentPenalty = value; } }
        private DirtyValue<bool?> _reasonRevisionsReqConsumer;
        public bool? ReasonRevisionsReqConsumer { get { return _reasonRevisionsReqConsumer; } set { _reasonRevisionsReqConsumer = value; } }
        private DirtyValue<bool?> _reasonToleranceCure;
        public bool? ReasonToleranceCure { get { return _reasonToleranceCure; } set { _reasonToleranceCure = value; } }
        private DirtyValue<DateTime?> _revisedCDDueDate;
        public DateTime? RevisedCDDueDate { get { return _revisedCDDueDate; } set { _revisedCDDueDate = value; } }
        private DirtyValue<DateTime?> _revisedCDReceivedDate;
        public DateTime? RevisedCDReceivedDate { get { return _revisedCDReceivedDate; } set { _revisedCDReceivedDate = value; } }
        private DirtyValue<string> _sellerNames;
        public string SellerNames { get { return _sellerNames; } set { _sellerNames = value; } }
        private DirtyValue<string> _signatureTypeFinalExecutedCopyofAlternateCD;
        public string SignatureTypeFinalExecutedCopyofAlternateCD { get { return _signatureTypeFinalExecutedCopyofAlternateCD; } set { _signatureTypeFinalExecutedCopyofAlternateCD = value; } }
        private DirtyValue<string> _signatureTypeFinalExecutedCopyofSellerCD;
        public string SignatureTypeFinalExecutedCopyofSellerCD { get { return _signatureTypeFinalExecutedCopyofSellerCD; } set { _signatureTypeFinalExecutedCopyofSellerCD = value; } }
        private DirtyValue<string> _signatureTypeFinalExecutedCopyofStandardCD;
        public string SignatureTypeFinalExecutedCopyofStandardCD { get { return _signatureTypeFinalExecutedCopyofStandardCD; } set { _signatureTypeFinalExecutedCopyofStandardCD = value; } }
        private DirtyValue<decimal?> _totalCashToClose;
        public decimal? TotalCashToClose { get { return _totalCashToClose; } set { _totalCashToClose = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _cDDateIssued.Dirty
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
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}