namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CreateEditBanksRights
    /// </summary>
    public sealed class CreateEditBanksRights : ParentAccessRights
    {
        /// <summary>
        /// CreateEditBanksRights DeleteBanks
        /// </summary>
        public bool? DeleteBanks { get => GetValue<bool?>(); set => SetValue(value); }
    }
}