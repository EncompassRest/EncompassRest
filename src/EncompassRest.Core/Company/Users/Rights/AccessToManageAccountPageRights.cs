namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToManageAccountPageRights
    /// </summary>
    public sealed class AccessToManageAccountPageRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _accessBranchesTab;
        private DirtyValue<bool?>? _accessCompanyInfoTab;
        private DirtyValue<bool?>? _accessPersonalEditMyInformationTab;
        private DirtyValue<bool?>? _accessPersonalEditMyLicenseTab;
        private DirtyValue<bool?>? _accessPersonalEditMyNotificationTab;

        /// <summary>
        /// AccessToManageAccountPageRights AccessBranchesTab
        /// </summary>
        public bool? AccessBranchesTab { get => _accessBranchesTab; set => SetField(ref _accessBranchesTab, value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessCompanyInfoTab
        /// </summary>
        public bool? AccessCompanyInfoTab { get => _accessCompanyInfoTab; set => SetField(ref _accessCompanyInfoTab, value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyInformationTab
        /// </summary>
        public bool? AccessPersonalEditMyInformationTab { get => _accessPersonalEditMyInformationTab; set => SetField(ref _accessPersonalEditMyInformationTab, value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyLicenseTab
        /// </summary>
        public bool? AccessPersonalEditMyLicenseTab { get => _accessPersonalEditMyLicenseTab; set => SetField(ref _accessPersonalEditMyLicenseTab, value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessPersonalEditMyNotificationTab
        /// </summary>
        public bool? AccessPersonalEditMyNotificationTab { get => _accessPersonalEditMyNotificationTab; set => SetField(ref _accessPersonalEditMyNotificationTab, value); }
    }
}