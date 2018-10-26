namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ManageServiceProvidersListRights
    /// </summary>
    public sealed class ManageServiceProvidersListRights : ParentAccessRights
    {
        private EllieMaeNetworkServiceCategoriesRights _ellieMaeNetworkServiceCategories;

        /// <summary>
        /// ManageServiceProvidersListRights EllieMaeNetworkServiceCategories
        /// </summary>
        public EllieMaeNetworkServiceCategoriesRights EllieMaeNetworkServiceCategories { get => GetField(ref _ellieMaeNetworkServiceCategories); set => SetField(ref _ellieMaeNetworkServiceCategories, value); }
    }
}