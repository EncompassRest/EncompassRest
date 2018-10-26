namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// WarehouseTabRights
    /// </summary>
    public sealed class WarehouseTabRights : ParentAccessRights
    {
        private DirtyValue<bool?> _editWarehouseBanks;

        /// <summary>
        /// WarehouseTabRights EditWarehouseBanks
        /// </summary>
        public bool? EditWarehouseBanks { get => _editWarehouseBanks; set => SetField(ref _editWarehouseBanks, value); }
    }
}