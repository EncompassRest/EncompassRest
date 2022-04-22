namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// WarehouseTabRights
    /// </summary>
    public sealed class WarehouseTabRights : ParentAccessRights
    {
        /// <summary>
        /// WarehouseTabRights EditWarehouseBanks
        /// </summary>
        public bool? EditWarehouseBanks { get => GetValue<bool?>(); set => SetValue(value); }
    }
}