namespace EncompassApi.Loans
{
    /// <summary>
    /// SettlementServiceCharge
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class SettlementServiceCharge : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _amount;
        private DirtyValue<string?>? _description;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// SettlementServiceCharge Amount
        /// </summary>
        public string? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// SettlementServiceCharge Description
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// SettlementServiceCharge Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}