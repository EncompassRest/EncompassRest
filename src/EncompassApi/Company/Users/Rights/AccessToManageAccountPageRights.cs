namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// AccessToManageAccountPageRights
    /// </summary>
    public sealed class AccessToManageAccountPageRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _accessBranchesTab;
        private DirtyValue<bool?>? _accessCompanyInfoTab;

        /// <summary>
        /// AccessToManageAccountPageRights AccessBranchesTab
        /// </summary>
        public bool? AccessBranchesTab { get => _accessBranchesTab; set => SetField(ref _accessBranchesTab, value); }

        /// <summary>
        /// AccessToManageAccountPageRights AccessCompanyInfoTab
        /// </summary>
        public bool? AccessCompanyInfoTab { get => _accessCompanyInfoTab; set => SetField(ref _accessCompanyInfoTab, value); }
    }
}