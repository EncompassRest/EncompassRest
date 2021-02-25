using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ManageServiceProvidersListRights
    /// </summary>
    public sealed class ManageServiceProvidersListRights : ParentAccessRights
    {
        private EllieMaeNetworkServiceCategoriesRights? _ellieMaeNetworkServiceCategories;

        /// <summary>
        /// ManageServiceProvidersListRights EllieMaeNetworkServiceCategories
        /// </summary>
        [AllowNull]
        public EllieMaeNetworkServiceCategoriesRights EllieMaeNetworkServiceCategories { get => GetField(ref _ellieMaeNetworkServiceCategories); set => SetField(ref _ellieMaeNetworkServiceCategories, value); }
    }
}