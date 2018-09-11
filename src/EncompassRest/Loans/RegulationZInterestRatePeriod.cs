using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegulationZInterestRatePeriod
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(RegulationZInterestRatePeriodType))]
    public sealed partial class RegulationZInterestRatePeriod : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _adjustmentDate;
        /// <summary>
        /// RegulationZInterestRatePeriod AdjustmentDate
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? AdjustmentDate { get => _adjustmentDate; set => SetField(ref _adjustmentDate, value); }
        private DirtyValue<int?> _adjustmentMonths;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months [3289]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months")]
        public int? AdjustmentMonths { get => _adjustmentMonths; set => SetField(ref _adjustmentMonths, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// RegulationZInterestRatePeriod Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _interestPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InterestPayment { get => _interestPayment; set => SetField(ref _interestPayment, value); }
        private DirtyValue<decimal?> _interestPrincipalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestPrincipalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InterestPrincipalPayment { get => _interestPrincipalPayment; set => SetField(ref _interestPrincipalPayment, value); }
        private DirtyValue<decimal?> _interestRatePercent;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? InterestRatePercent { get => _interestRatePercent; set => SetField(ref _interestRatePercent, value); }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment [3290]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment")]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }
        private DirtyValue<decimal?> _principalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod PrincipalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PrincipalPayment { get => _principalPayment; set => SetField(ref _principalPayment, value); }
        private DirtyValue<StringEnumValue<RegulationZInterestRatePeriodType>> _regulationZInterestRatePeriodType;
        /// <summary>
        /// RegulationZInterestRatePeriod RegulationZInterestRatePeriodType
        /// </summary>
        public StringEnumValue<RegulationZInterestRatePeriodType> RegulationZInterestRatePeriodType { get => _regulationZInterestRatePeriodType; set => SetField(ref _regulationZInterestRatePeriodType, value); }
        private DirtyValue<decimal?> _taxInsuranceAmount;
        /// <summary>
        /// RegulationZInterestRatePeriod TaxInsuranceAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TaxInsuranceAmount { get => _taxInsuranceAmount; set => SetField(ref _taxInsuranceAmount, value); }
        private DirtyValue<decimal?> _totalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod TotalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPayment { get => _totalPayment; set => SetField(ref _totalPayment, value); }
    }
}