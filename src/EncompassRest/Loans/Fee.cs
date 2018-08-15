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
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<decimal?> _amountPerDay;
        /// <summary>
        /// Fees Interest Per Day [333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true, Description = "Fees Interest Per Day")]
        public decimal? AmountPerDay { get => _amountPerDay; set => SetField(ref _amountPerDay, value); }
        private DirtyValue<decimal?> _borPaidAmount;
        /// <summary>
        /// Fee BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorPaidAmount { get => _borPaidAmount; set => SetField(ref _borPaidAmount, value); }
        private DirtyValue<DateTime?> _dateFrom;
        /// <summary>
        /// Fees Interest From [L244]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest From")]
        public DateTime? DateFrom { get => _dateFrom; set => SetField(ref _dateFrom, value); }
        private DirtyValue<DateTime?> _dateTo;
        /// <summary>
        /// Fees Interest To [L245]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest To")]
        public DateTime? DateTo { get => _dateTo; set => SetField(ref _dateTo, value); }
        private DirtyValue<int?> _days;
        /// <summary>
        /// Fees Interest # of Days [332]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest # of Days")]
        public int? Days { get => _days; set => SetField(ref _days, value); }
        private DirtyValue<decimal?> _deedAmount;
        /// <summary>
        /// Fee DeedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DeedAmount { get => _deedAmount; set => SetField(ref _deedAmount, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// Fee Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<StringEnumValue<FeeFeeType>> _feeType;
        /// <summary>
        /// Fee FeeType
        /// </summary>
        public StringEnumValue<FeeFeeType> FeeType { get => _feeType; set => SetField(ref _feeType, value); }
        private DirtyValue<bool?> _fHA;
        /// <summary>
        /// Fee FHA
        /// </summary>
        public bool? FHA { get => _fHA; set => SetField(ref _fHA, value); }
        private DirtyValue<string> _fWBC;
        /// <summary>
        /// Fee FWBC
        /// </summary>
        public string FWBC { get => _fWBC; set => SetField(ref _fWBC, value); }
        private DirtyValue<string> _fWSC;
        /// <summary>
        /// Fee FWSC
        /// </summary>
        public string FWSC { get => _fWSC; set => SetField(ref _fWSC, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Fee Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _includeAboveNumber;
        /// <summary>
        /// Fee IncludeAboveNumber
        /// </summary>
        public string IncludeAboveNumber { get => _includeAboveNumber; set => SetField(ref _includeAboveNumber, value); }
        private DirtyValue<decimal?> _lenderCoverage;
        /// <summary>
        /// Fees Line 1109 Lender's Coverage Amount [2409]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1109 Lender's Coverage Amount")]
        public decimal? LenderCoverage { get => _lenderCoverage; set => SetField(ref _lenderCoverage, value); }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// Fee MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }
        private DirtyValue<decimal?> _mortgageAmount;
        /// <summary>
        /// Fee MortgageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MortgageAmount { get => _mortgageAmount; set => SetField(ref _mortgageAmount, value); }
        private DirtyValue<NA<decimal>> _newHUDBorPaidAmount;
        /// <summary>
        /// Fee NewHUDBorPaidAmount
        /// </summary>
        public NA<decimal> NewHUDBorPaidAmount { get => _newHUDBorPaidAmount; set => SetField(ref _newHUDBorPaidAmount, value); }
        private DirtyValue<int?> _numberOfMonths;
        /// <summary>
        /// Fee NumberOfMonths
        /// </summary>
        public int? NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }
        private DirtyValue<decimal?> _ownerCoverage;
        /// <summary>
        /// Fees Line 1110 Owner's Coverage Amount [2410]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1110 Owner's Coverage Amount")]
        public decimal? OwnerCoverage { get => _ownerCoverage; set => SetField(ref _ownerCoverage, value); }
        private DirtyValue<StringEnumValue<PaidBy>> _paidBy;
        /// <summary>
        /// Fee PaidBy
        /// </summary>
        public StringEnumValue<PaidBy> PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }
        private DirtyValue<decimal?> _paidInAdvance;
        /// <summary>
        /// Fee PaidInAdvance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidInAdvance { get => _paidInAdvance; set => SetField(ref _paidInAdvance, value); }
        private DirtyValue<decimal?> _paidToBroker;
        /// <summary>
        /// Fee PaidToBroker
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToBroker { get => _paidToBroker; set => SetField(ref _paidToBroker, value); }
        private DirtyValue<string> _paidToName;
        /// <summary>
        /// Fee PaidToName
        /// </summary>
        public string PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }
        private DirtyValue<decimal?> _paidToOthers;
        /// <summary>
        /// Fee PaidToOthers
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToOthers { get => _paidToOthers; set => SetField(ref _paidToOthers, value); }
        private DirtyValue<decimal?> _percentage;
        /// <summary>
        /// Fee Percentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Percentage { get => _percentage; set => SetField(ref _percentage, value); }
        private DirtyValue<bool?> _pFC;
        /// <summary>
        /// Fee PFC
        /// </summary>
        public bool? PFC { get => _pFC; set => SetField(ref _pFC, value); }
        private DirtyValue<bool?> _pOC;
        /// <summary>
        /// Fee POC
        /// </summary>
        public bool? POC { get => _pOC; set => SetField(ref _pOC, value); }
        private DirtyValue<StringEnumValue<PTB>> _pTB;
        /// <summary>
        /// Fee PTB
        /// </summary>
        public StringEnumValue<PTB> PTB { get => _pTB; set => SetField(ref _pTB, value); }
        private DirtyValue<decimal?> _releasesAmount;
        /// <summary>
        /// Fees Recording Fee Releases Amount [2404]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Recording Fee Releases Amount")]
        public decimal? ReleasesAmount { get => _releasesAmount; set => SetField(ref _releasesAmount, value); }
        private DirtyValue<decimal?> _sellerPaidAmount;
        /// <summary>
        /// Fee SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerPaidAmount { get => _sellerPaidAmount; set => SetField(ref _sellerPaidAmount, value); }
        private DirtyValue<decimal?> _truncatedAmountPerDay;
        /// <summary>
        /// Unrounded and Truncated Fees Interest Per Day [335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Unrounded and Truncated Fees Interest Per Day")]
        public decimal? TruncatedAmountPerDay { get => _truncatedAmountPerDay; set => SetField(ref _truncatedAmountPerDay, value); }
        private DirtyValue<bool?> _use4Decimals;
        /// <summary>
        /// Number of Decimals for Fees Interest # of Days [SYS.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Number of Decimals for Fees Interest # of Days")]
        public bool? Use4Decimals { get => _use4Decimals; set => SetField(ref _use4Decimals, value); }
    }
}