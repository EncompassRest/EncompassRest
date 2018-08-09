using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfeFee
    /// </summary>
    public sealed partial class GfeFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _amountDescription;
        /// <summary>
        /// GfeFee AmountDescription
        /// </summary>
        public string AmountDescription { get => _amountDescription; set => _amountDescription = value; }
        private DirtyValue<decimal?> _brokerAmount;
        /// <summary>
        /// GfeFee BrokerAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BrokerAmount { get => _brokerAmount; set => _brokerAmount = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// GfeFee Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfeFeeIndex;
        /// <summary>
        /// GfeFee GfeFeeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"824\":\"824\",\"825\":\"825\",\"1\":\"1\",\"2\":\"2\",\"0\":\"0\"}")]
        public int? GfeFeeIndex { get => _gfeFeeIndex; set => _gfeFeeIndex = value; }
        private DirtyValue<StringEnumValue<GfeFeeType>> _gfeFeeType;
        /// <summary>
        /// GfeFee GfeFeeType
        /// </summary>
        public StringEnumValue<GfeFeeType> GfeFeeType { get => _gfeFeeType; set => _gfeFeeType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// GfeFee Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _otherAmount;
        /// <summary>
        /// GfeFee OtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherAmount { get => _otherAmount; set => _otherAmount = value; }
        private DirtyValue<string> _rate;
        /// <summary>
        /// GfeFee Rate
        /// </summary>
        public string Rate { get => _rate; set => _rate = value; }
    }
}