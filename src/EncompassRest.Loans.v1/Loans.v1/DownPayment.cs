using EncompassRest.Loans.v1.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// DownPayment
    /// </summary>
    public sealed partial class DownPayment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _amount;
        private DirtyValue<StringEnumValue<DownPaymentType>>? _downPaymentType;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _sourceDescription;

        /// <summary>
        /// Trans Details Down Pymt Amt [1335]
        /// </summary>
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// Borr Funds to Close - Down Pymt Source [34]
        /// </summary>
        public StringEnumValue<DownPaymentType> DownPaymentType { get => _downPaymentType; set => SetField(ref _downPaymentType, value); }

        /// <summary>
        /// DownPayment Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Borr Funds to Close - Down Pymt Source Descr [191]
        /// </summary>
        public string? SourceDescription { get => _sourceDescription; set => SetField(ref _sourceDescription, value); }
    }
}