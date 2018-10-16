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
        private DirtyValue<bool?> _currentIndicator;
        private DirtyValue<StringEnumValue<Description>> _description;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<IncomeType>> _incomeType;
        private DirtyValue<int?> _otherIncomeIndex;
        private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>> _owner;

        /// <summary>
        /// Income Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// Income CurrentIndicator
        /// </summary>
        public bool? CurrentIndicator { get => _currentIndicator; set => SetField(ref _currentIndicator, value); }

        /// <summary>
        /// Income Description
        /// </summary>
        public StringEnumValue<Description> Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Income Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Income IncomeType
        /// </summary>
        public StringEnumValue<IncomeType> IncomeType { get => _incomeType; set => SetField(ref _incomeType, value); }

        /// <summary>
        /// Income OtherIncomeIndex
        /// </summary>
        public int? OtherIncomeIndex { get => _otherIncomeIndex; set => SetField(ref _otherIncomeIndex, value); }

        /// <summary>
        /// Income Owner
        /// </summary>
        public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }
    }
}