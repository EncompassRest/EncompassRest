using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfePayment
    /// </summary>
    public sealed partial class GfePayment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _fixedRate;
        /// <summary>
        /// GfePayment FixedRate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FixedRate { get => _fixedRate; set => _fixedRate = value; }
        private DirtyValue<int?> _gfePaymentIndex;
        /// <summary>
        /// GfePayment GfePaymentIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\"}")]
        public int? GfePaymentIndex { get => _gfePaymentIndex; set => _gfePaymentIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// GfePayment Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRate;
        /// <summary>
        /// MLDS Pymt S5 Index Rate [RE88395.X313]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS Pymt S5 Index Rate")]
        public decimal? IndexRate { get => _indexRate; set => _indexRate = value; }
        private DirtyValue<StringEnumValue<YesOrNo>> _isBalanceReduced;
        /// <summary>
        /// MLDS Pymt S6 Is Loan Balance Reduced [RE88395.X311]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Pymt S6 Is Loan Balance Reduced")]
        public StringEnumValue<YesOrNo> IsBalanceReduced { get => _isBalanceReduced; set => _isBalanceReduced = value; }
        private DirtyValue<string> _loanTypeExplanation;
        /// <summary>
        /// MLDS Pymt S6 Loan Type Explanation [RE88395.X306]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Pymt S6 Loan Type Explanation")]
        public string LoanTypeExplanation { get => _loanTypeExplanation; set => _loanTypeExplanation = value; }
        private DirtyValue<decimal?> _marginRate;
        /// <summary>
        /// MLDS Pymt S5 Margin Rate [RE88395.X314]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS Pymt S5 Margin Rate")]
        public decimal? MarginRate { get => _marginRate; set => _marginRate = value; }
        private DirtyValue<decimal?> _maximumDifference;
        /// <summary>
        /// GfePayment MaximumDifference
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MaximumDifference { get => _maximumDifference; set => _maximumDifference = value; }
        private DirtyValue<decimal?> _maximumRate;
        /// <summary>
        /// GfePayment MaximumRate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaximumRate { get => _maximumRate; set => _maximumRate = value; }
        private DirtyValue<decimal?> _minimumDifference;
        /// <summary>
        /// GfePayment MinimumDifference
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumDifference { get => _minimumDifference; set => _minimumDifference = value; }
        private DirtyValue<decimal?> _minimumMonthlyPayment;
        /// <summary>
        /// GfePayment MinimumMonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumMonthlyPayment { get => _minimumMonthlyPayment; set => _minimumMonthlyPayment = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear1;
        /// <summary>
        /// GfePayment MonthlyPaymentYear1
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPaymentYear1 { get => _monthlyPaymentYear1; set => _monthlyPaymentYear1 = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6;
        /// <summary>
        /// GfePayment MonthlyPaymentYear6
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPaymentYear6 { get => _monthlyPaymentYear6; set => _monthlyPaymentYear6 = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6Change;
        /// <summary>
        /// GfePayment MonthlyPaymentYear6Change
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPaymentYear6Change { get => _monthlyPaymentYear6Change; set => _monthlyPaymentYear6Change = value; }
        private DirtyValue<decimal?> _monthlyPaymentYear6MaxChange;
        /// <summary>
        /// GfePayment MonthlyPaymentYear6MaxChange
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPaymentYear6MaxChange { get => _monthlyPaymentYear6MaxChange; set => _monthlyPaymentYear6MaxChange = value; }
        private DirtyValue<bool?> _notOfferedIndicator;
        /// <summary>
        /// GfePayment NotOfferedIndicator
        /// </summary>
        public bool? NotOfferedIndicator { get => _notOfferedIndicator; set => _notOfferedIndicator = value; }
        private DirtyValue<decimal?> _owedAfter5Years;
        /// <summary>
        /// GfePayment OwedAfter5Years
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OwedAfter5Years { get => _owedAfter5Years; set => _owedAfter5Years = value; }
        private DirtyValue<decimal?> _rateInMonth2;
        /// <summary>
        /// MLDS Pymt S5 Rate Month 2 Thru Yr 5 [RE88395.X304]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS Pymt S5 Rate Month 2 Thru Yr 5")]
        public decimal? RateInMonth2 { get => _rateInMonth2; set => _rateInMonth2 = value; }
        private DirtyValue<decimal?> _reducedLoanBalance;
        /// <summary>
        /// GfePayment ReducedLoanBalance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ReducedLoanBalance { get => _reducedLoanBalance; set => _reducedLoanBalance = value; }
        private DirtyValue<StringEnumValue<ReducedStatus>> _reducedStatus;
        /// <summary>
        /// MLDS Pymt S6 Loan Balance Reduced Status [RE88395.X312]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Pymt S6 Loan Balance Reduced Status")]
        public StringEnumValue<ReducedStatus> ReducedStatus { get => _reducedStatus; set => _reducedStatus = value; }
    }
}