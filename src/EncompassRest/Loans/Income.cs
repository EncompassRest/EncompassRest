using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Income
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(IncomeType) + "," + nameof(OtherIncomeIndex) + "," + nameof(Owner))]
    public sealed partial class Income : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// Income Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<bool?> _currentIndicator;
        /// <summary>
        /// Income CurrentIndicator
        /// </summary>
        public bool? CurrentIndicator { get => _currentIndicator; set => SetField(ref _currentIndicator, value); }
        private DirtyValue<StringEnumValue<Description>> _description;
        /// <summary>
        /// Income Description
        /// </summary>
        public StringEnumValue<Description> Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Income Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<IncomeType>> _incomeType;
        /// <summary>
        /// Income IncomeType
        /// </summary>
        public StringEnumValue<IncomeType> IncomeType { get => _incomeType; set => SetField(ref _incomeType, value); }
        private DirtyValue<int?> _otherIncomeIndex;
        /// <summary>
        /// Income OtherIncomeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? OtherIncomeIndex { get => _otherIncomeIndex; set => SetField(ref _otherIncomeIndex, value); }
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _owner;
        /// <summary>
        /// Income Owner
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }
    }
}