using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Fee
    /// </summary>
    public sealed partial class Fee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// Fee Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<decimal?> _amountPerDay;
        /// <summary>
        /// Fees Interest Per Day [333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true, Description = "Fees Interest Per Day")]
        public decimal? AmountPerDay { get => _amountPerDay; set => _amountPerDay = value; }
        private DirtyValue<decimal?> _borPaidAmount;
        /// <summary>
        /// Fee BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorPaidAmount { get => _borPaidAmount; set => _borPaidAmount = value; }
        private DirtyValue<DateTime?> _dateFrom;
        /// <summary>
        /// Fees Interest From [L244]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest From")]
        public DateTime? DateFrom { get => _dateFrom; set => _dateFrom = value; }
        private DirtyValue<DateTime?> _dateTo;
        /// <summary>
        /// Fees Interest To [L245]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest To")]
        public DateTime? DateTo { get => _dateTo; set => _dateTo = value; }
        private DirtyValue<int?> _days;
        /// <summary>
        /// Fees Interest # of Days [332]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest # of Days")]
        public int? Days { get => _days; set => _days = value; }
        private DirtyValue<decimal?> _deedAmount;
        /// <summary>
        /// Fee DeedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DeedAmount { get => _deedAmount; set => _deedAmount = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// Fee Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<StringEnumValue<FeeFeeType>> _feeType;
        /// <summary>
        /// Fee FeeType
        /// </summary>
        public StringEnumValue<FeeFeeType> FeeType { get => _feeType; set => _feeType = value; }
        private DirtyValue<bool?> _fHA;
        /// <summary>
        /// Fee FHA
        /// </summary>
        public bool? FHA { get => _fHA; set => _fHA = value; }
        private DirtyValue<string> _fWBC;
        /// <summary>
        /// Fee FWBC
        /// </summary>
        public string FWBC { get => _fWBC; set => _fWBC = value; }
        private DirtyValue<string> _fWSC;
        /// <summary>
        /// Fee FWSC
        /// </summary>
        public string FWSC { get => _fWSC; set => _fWSC = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Fee Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _includeAboveNumber;
        /// <summary>
        /// Fee IncludeAboveNumber
        /// </summary>
        public string IncludeAboveNumber { get => _includeAboveNumber; set => _includeAboveNumber = value; }
        private DirtyValue<decimal?> _lenderCoverage;
        /// <summary>
        /// Fees Line 1109 Lender's Coverage Amount [2409]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1109 Lender's Coverage Amount")]
        public decimal? LenderCoverage { get => _lenderCoverage; set => _lenderCoverage = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// Fee MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<decimal?> _mortgageAmount;
        /// <summary>
        /// Fee MortgageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MortgageAmount { get => _mortgageAmount; set => _mortgageAmount = value; }
        private DirtyValue<NA<decimal>> _newHUDBorPaidAmount;
        /// <summary>
        /// Fee NewHUDBorPaidAmount
        /// </summary>
        public NA<decimal> NewHUDBorPaidAmount { get => _newHUDBorPaidAmount; set => _newHUDBorPaidAmount = value; }
        private DirtyValue<int?> _numberOfMonths;
        /// <summary>
        /// Fee NumberOfMonths
        /// </summary>
        public int? NumberOfMonths { get => _numberOfMonths; set => _numberOfMonths = value; }
        private DirtyValue<decimal?> _ownerCoverage;
        /// <summary>
        /// Fees Line 1110 Owner's Coverage Amount [2410]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1110 Owner's Coverage Amount")]
        public decimal? OwnerCoverage { get => _ownerCoverage; set => _ownerCoverage = value; }
        private DirtyValue<StringEnumValue<PaidBy>> _paidBy;
        /// <summary>
        /// Fee PaidBy
        /// </summary>
        public StringEnumValue<PaidBy> PaidBy { get => _paidBy; set => _paidBy = value; }
        private DirtyValue<decimal?> _paidInAdvance;
        /// <summary>
        /// Fee PaidInAdvance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidInAdvance { get => _paidInAdvance; set => _paidInAdvance = value; }
        private DirtyValue<decimal?> _paidToBroker;
        /// <summary>
        /// Fee PaidToBroker
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToBroker { get => _paidToBroker; set => _paidToBroker = value; }
        private DirtyValue<string> _paidToName;
        /// <summary>
        /// Fee PaidToName
        /// </summary>
        public string PaidToName { get => _paidToName; set => _paidToName = value; }
        private DirtyValue<decimal?> _paidToOthers;
        /// <summary>
        /// Fee PaidToOthers
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToOthers { get => _paidToOthers; set => _paidToOthers = value; }
        private DirtyValue<decimal?> _percentage;
        /// <summary>
        /// Fee Percentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Percentage { get => _percentage; set => _percentage = value; }
        private DirtyValue<bool?> _pFC;
        /// <summary>
        /// Fee PFC
        /// </summary>
        public bool? PFC { get => _pFC; set => _pFC = value; }
        private DirtyValue<bool?> _pOC;
        /// <summary>
        /// Fee POC
        /// </summary>
        public bool? POC { get => _pOC; set => _pOC = value; }
        private DirtyValue<StringEnumValue<PTB>> _pTB;
        /// <summary>
        /// Fee PTB
        /// </summary>
        public StringEnumValue<PTB> PTB { get => _pTB; set => _pTB = value; }
        private DirtyValue<decimal?> _releasesAmount;
        /// <summary>
        /// Fees Recording Fee Releases Amount [2404]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Recording Fee Releases Amount")]
        public decimal? ReleasesAmount { get => _releasesAmount; set => _releasesAmount = value; }
        private DirtyValue<decimal?> _sellerPaidAmount;
        /// <summary>
        /// Fee SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerPaidAmount { get => _sellerPaidAmount; set => _sellerPaidAmount = value; }
        private DirtyValue<decimal?> _truncatedAmountPerDay;
        /// <summary>
        /// Unrounded and Truncated Fees Interest Per Day [335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Unrounded and Truncated Fees Interest Per Day")]
        public decimal? TruncatedAmountPerDay { get => _truncatedAmountPerDay; set => _truncatedAmountPerDay = value; }
        private DirtyValue<bool?> _use4Decimals;
        /// <summary>
        /// Number of Decimals for Fees Interest # of Days [SYS.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Number of Decimals for Fees Interest # of Days")]
        public bool? Use4Decimals { get => _use4Decimals; set => _use4Decimals = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _amountPerDay.Dirty
                || _borPaidAmount.Dirty
                || _dateFrom.Dirty
                || _dateTo.Dirty
                || _days.Dirty
                || _deedAmount.Dirty
                || _description.Dirty
                || _feeType.Dirty
                || _fHA.Dirty
                || _fWBC.Dirty
                || _fWSC.Dirty
                || _id.Dirty
                || _includeAboveNumber.Dirty
                || _lenderCoverage.Dirty
                || _monthlyPayment.Dirty
                || _mortgageAmount.Dirty
                || _newHUDBorPaidAmount.Dirty
                || _numberOfMonths.Dirty
                || _ownerCoverage.Dirty
                || _paidBy.Dirty
                || _paidInAdvance.Dirty
                || _paidToBroker.Dirty
                || _paidToName.Dirty
                || _paidToOthers.Dirty
                || _percentage.Dirty
                || _pFC.Dirty
                || _pOC.Dirty
                || _pTB.Dirty
                || _releasesAmount.Dirty
                || _sellerPaidAmount.Dirty
                || _truncatedAmountPerDay.Dirty
                || _use4Decimals.Dirty;
            set
            {
                _amount.Dirty = value;
                _amountPerDay.Dirty = value;
                _borPaidAmount.Dirty = value;
                _dateFrom.Dirty = value;
                _dateTo.Dirty = value;
                _days.Dirty = value;
                _deedAmount.Dirty = value;
                _description.Dirty = value;
                _feeType.Dirty = value;
                _fHA.Dirty = value;
                _fWBC.Dirty = value;
                _fWSC.Dirty = value;
                _id.Dirty = value;
                _includeAboveNumber.Dirty = value;
                _lenderCoverage.Dirty = value;
                _monthlyPayment.Dirty = value;
                _mortgageAmount.Dirty = value;
                _newHUDBorPaidAmount.Dirty = value;
                _numberOfMonths.Dirty = value;
                _ownerCoverage.Dirty = value;
                _paidBy.Dirty = value;
                _paidInAdvance.Dirty = value;
                _paidToBroker.Dirty = value;
                _paidToName.Dirty = value;
                _paidToOthers.Dirty = value;
                _percentage.Dirty = value;
                _pFC.Dirty = value;
                _pOC.Dirty = value;
                _pTB.Dirty = value;
                _releasesAmount.Dirty = value;
                _sellerPaidAmount.Dirty = value;
                _truncatedAmountPerDay.Dirty = value;
                _use4Decimals.Dirty = value;
            }
        }
    }
}