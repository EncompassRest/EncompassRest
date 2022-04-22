namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CurrentLoginsRights
    /// </summary>
    public sealed class CurrentLoginsRights : ParentAccessRights
    {
        /// <summary>
        /// CurrentLoginsRights DisableLogins
        /// </summary>
        public bool? DisableLogins { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CurrentLoginsRights LogUsersOut
        /// </summary>
        public bool? LogUsersOut { get => GetValue<bool?>(); set => SetValue(value); }
    }
}