using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Fee
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(FeeType))]
    public sealed partial class Fee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        private DirtyValue<decimal?> _amountPerDay;
        private DirtyValue<decimal?> _borPaidAmount;
        private DirtyValue<DateTime?> _dateFrom;
        private DirtyValue<DateTime?> _dateTo;
        private DirtyValue<int?> _days;
        private DirtyValue<decimal?> _deedAmount;
        private DirtyValue<string> _description;
        private DirtyValue<StringEnumValue<FeeFeeType>> _feeType;
        private DirtyValue<bool?> _fHA;
        private DirtyValue<string> _fWBC;
        private DirtyValue<string> _fWSC;
        private DirtyValue<string> _id;
        private DirtyValue<string> _includeAboveNumber;
        private DirtyValue<decimal?> _lenderCoverage;
        private DirtyValue<decimal?> _monthlyPayment;
        private DirtyValue<decimal?> _mortgageAmount;
        private DirtyValue<NA<decimal>> _newHUDBorPaidAmount;
        private DirtyValue<int?> _numberOfMonths;
        private DirtyValue<decimal?> _ownerCoverage;
        private DirtyValue<StringEnumValue<PaidBy>> _paidBy;
        private DirtyValue<decimal?> _paidInAdvance;
        private DirtyValue<decimal?> _paidToBroker;
        private DirtyValue<string> _paidToName;
        private DirtyValue<decimal?> _paidToOthers;
        private DirtyValue<decimal?> _percentage;
        private DirtyValue<bool?> _pFC;
        private DirtyValue<bool?> _pOC;
        private DirtyValue<StringEnumValue<PTB>> _pTB;
        private DirtyValue<decimal?> _releasesAmount;
        private DirtyValue<decimal?> _sellerPaidAmount;
        private DirtyValue<decimal?> _truncatedAmountPerDay;
        private DirtyValue<bool?> _use4Decimals;

        /// <summary>
        /// Fee Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// Fees Interest Per Day [333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true, Description = "Fees Interest Per Day")]
        public decimal? AmountPerDay { get => _amountPerDay; set => SetField(ref _amountPerDay, value); }

        /// <summary>
        /// Fee BorPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BorPaidAmount { get => _borPaidAmount; set => SetField(ref _borPaidAmount, value); }

        /// <summary>
        /// Fees Interest From [L244]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest From")]
        public DateTime? DateFrom { get => _dateFrom; set => SetField(ref _dateFrom, value); }

        /// <summary>
        /// Fees Interest To [L245]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest To")]
        public DateTime? DateTo { get => _dateTo; set => SetField(ref _dateTo, value); }

        /// <summary>
        /// Fees Interest # of Days [332]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Interest # of Days")]
        public int? Days { get => _days; set => SetField(ref _days, value); }

        /// <summary>
        /// Fee DeedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DeedAmount { get => _deedAmount; set => SetField(ref _deedAmount, value); }

        /// <summary>
        /// Fee Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Fee FeeType
        /// </summary>
        public StringEnumValue<FeeFeeType> FeeType { get => _feeType; set => SetField(ref _feeType, value); }

        /// <summary>
        /// Fee FHA
        /// </summary>
        public bool? FHA { get => _fHA; set => SetField(ref _fHA, value); }

        /// <summary>
        /// Fee FWBC
        /// </summary>
        public string FWBC { get => _fWBC; set => SetField(ref _fWBC, value); }

        /// <summary>
        /// Fee FWSC
        /// </summary>
        public string FWSC { get => _fWSC; set => SetField(ref _fWSC, value); }

        /// <summary>
        /// Fee Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Fee IncludeAboveNumber
        /// </summary>
        public string IncludeAboveNumber { get => _includeAboveNumber; set => SetField(ref _includeAboveNumber, value); }

        /// <summary>
        /// Fees Line 1109 Lender's Coverage Amount [2409]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1109 Lender's Coverage Amount")]
        public decimal? LenderCoverage { get => _lenderCoverage; set => SetField(ref _lenderCoverage, value); }

        /// <summary>
        /// Fee MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

        /// <summary>
        /// Fee MortgageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MortgageAmount { get => _mortgageAmount; set => SetField(ref _mortgageAmount, value); }

        /// <summary>
        /// Fee NewHUDBorPaidAmount
        /// </summary>
        public NA<decimal> NewHUDBorPaidAmount { get => _newHUDBorPaidAmount; set => SetField(ref _newHUDBorPaidAmount, value); }

        /// <summary>
        /// Fee NumberOfMonths
        /// </summary>
        public int? NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }

        /// <summary>
        /// Fees Line 1110 Owner's Coverage Amount [2410]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1110 Owner's Coverage Amount")]
        public decimal? OwnerCoverage { get => _ownerCoverage; set => SetField(ref _ownerCoverage, value); }

        /// <summary>
        /// Fee PaidBy
        /// </summary>
        public StringEnumValue<PaidBy> PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

        /// <summary>
        /// Fee PaidInAdvance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidInAdvance { get => _paidInAdvance; set => SetField(ref _paidInAdvance, value); }

        /// <summary>
        /// Fee PaidToBroker
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToBroker { get => _paidToBroker; set => SetField(ref _paidToBroker, value); }

        /// <summary>
        /// Fee PaidToName
        /// </summary>
        public string PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }

        /// <summary>
        /// Fee PaidToOthers
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PaidToOthers { get => _paidToOthers; set => SetField(ref _paidToOthers, value); }

        /// <summary>
        /// Fee Percentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Percentage { get => _percentage; set => SetField(ref _percentage, value); }

        /// <summary>
        /// Fee PFC
        /// </summary>
        public bool? PFC { get => _pFC; set => SetField(ref _pFC, value); }

        /// <summary>
        /// Fee POC
        /// </summary>
        public bool? POC { get => _pOC; set => SetField(ref _pOC, value); }

        /// <summary>
        /// Fee PTB
        /// </summary>
        public StringEnumValue<PTB> PTB { get => _pTB; set => SetField(ref _pTB, value); }

        /// <summary>
        /// Fees Recording Fee Releases Amount [2404]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Recording Fee Releases Amount")]
        public decimal? ReleasesAmount { get => _releasesAmount; set => SetField(ref _releasesAmount, value); }

        /// <summary>
        /// Fee SellerPaidAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SellerPaidAmount { get => _sellerPaidAmount; set => SetField(ref _sellerPaidAmount, value); }

        /// <summary>
        /// Unrounded and Truncated Fees Interest Per Day [335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Unrounded and Truncated Fees Interest Per Day")]
        public decimal? TruncatedAmountPerDay { get => _truncatedAmountPerDay; set => SetField(ref _truncatedAmountPerDay, value); }

        /// <summary>
        /// Number of Decimals for Fees Interest # of Days [SYS.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Number of Decimals for Fees Interest # of Days")]
        public bool? Use4Decimals { get => _use4Decimals; set => SetField(ref _use4Decimals, value); }
    }
}