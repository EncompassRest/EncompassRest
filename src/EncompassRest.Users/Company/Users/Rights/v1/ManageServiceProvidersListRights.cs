using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ManageServiceProvidersListRights
    /// </summary>
    public sealed class ManageServiceProvidersListRights : ParentAccessRights
    {
        /// <summary>
        /// ManageServiceProvidersListRights EllieMaeNetworkServiceCategories
        /// </summary>
        [AllowNull]
        public EllieMaeNetworkServiceCategoriesRights EllieMaeNetworkServiceCategories { get => GetEntity<EllieMaeNetworkServiceCategoriesRights>(); set => SetEntity(value); }
    }
}