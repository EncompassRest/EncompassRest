using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfeFee
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(GfeFeeIndex) + "," + nameof(GfeFeeType))]
    public sealed partial class GfeFee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _amountDescription;
        private DirtyValue<decimal?> _brokerAmount;
        private DirtyValue<string> _description;
        private DirtyValue<int?> _gfeFeeIndex;
        private DirtyValue<StringEnumValue<GfeFeeType>> _gfeFeeType;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _otherAmount;
        private DirtyValue<string> _rate;

        /// <summary>
        /// GfeFee AmountDescription
        /// </summary>
        public string AmountDescription { get => _amountDescription; set => SetField(ref _amountDescription, value); }

        /// <summary>
        /// GfeFee BrokerAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BrokerAmount { get => _brokerAmount; set => SetField(ref _brokerAmount, value); }

        /// <summary>
        /// GfeFee Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// GfeFee GfeFeeIndex
        /// </summary>
        public int? GfeFeeIndex { get => _gfeFeeIndex; set => SetField(ref _gfeFeeIndex, value); }

        /// <summary>
        /// GfeFee GfeFeeType
        /// </summary>
        public StringEnumValue<GfeFeeType> GfeFeeType { get => _gfeFeeType; set => SetField(ref _gfeFeeType, value); }

        /// <summary>
        /// GfeFee Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// GfeFee OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

        /// <summary>
        /// GfeFee Rate
        /// </summary>
        public string Rate { get => _rate; set => SetField(ref _rate, value); }
    }
}