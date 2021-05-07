namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CreateEditBanksRights
    /// </summary>
    public sealed class CreateEditBanksRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteBanks;

        /// <summary>
        /// CreateEditBanksRights DeleteBanks
        /// </summary>
        public bool? DeleteBanks { get => _deleteBanks; set => SetField(ref _deleteBanks, value); }
    }
}