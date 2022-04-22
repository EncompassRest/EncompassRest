namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToManageAccountPageRights
    /// </summary>
    public sealed class AccessToManageAccountPageRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToManageAccountPageRights AccessBranchesTab
        /// </summary>
        public bool? AccessBranchesTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessCompanyInfoTab
        /// </summary>
        public bool? AccessCompanyInfoTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyInformationTab
        /// </summary>
        public bool? AccessPersonalEditMyInformationTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyLicenseTab
        /// </summary>
        public bool? AccessPersonalEditMyLicenseTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyNotificationTab
        /// </summary>
        public bool? AccessPersonalEditMyNotificationTab { get => GetValue<bool?>(); set => SetValue(value); }
    }
}