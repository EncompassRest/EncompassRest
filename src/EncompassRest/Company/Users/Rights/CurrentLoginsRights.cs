namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CurrentLoginsRights
    /// </summary>
    public sealed class CurrentLoginsRights : ParentAccessRights
    {
        private DirtyValue<bool?> _disableLogins;
        private DirtyValue<bool?> _logUsersOut;

        /// <summary>
        /// CurrentLoginsRights DisableLogins
        /// </summary>
        public bool? DisableLogins { get => _disableLogins; set => SetField(ref _disableLogins, value); }

        /// <summary>
        /// CurrentLoginsRights LogUsersOut
        /// </summary>
        public bool? LogUsersOut { get => _logUsersOut; set => SetField(ref _logUsersOut, value); }
    }
}