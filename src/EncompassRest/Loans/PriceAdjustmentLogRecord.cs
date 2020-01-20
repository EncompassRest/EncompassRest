namespace EncompassRest.Loans
{
    /// <summary>
    /// PriceAdjustmentLogRecord
    /// </summary>
    public sealed partial class PriceAdjustmentLogRecord : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _description;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _rate;

        /// <summary>
        /// PriceAdjustmentLogRecord Description
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// PriceAdjustmentLogRecord Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PriceAdjustmentLogRecord Rate
        /// </summary>
        public decimal? Rate { get => _rate; set => SetField(ref _rate, value); }
    }
}