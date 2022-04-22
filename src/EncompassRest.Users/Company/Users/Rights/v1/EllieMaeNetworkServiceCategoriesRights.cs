using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EllieMaeNetworkServiceCategoriesRights
    /// </summary>
    public sealed class EllieMaeNetworkServiceCategoriesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights All
        /// </summary>
        [AllowNull]
        public EllieMaeNetworkServiceCategoriesClassRights All { get => GetEntity<EllieMaeNetworkServiceCategoriesClassRights>(); set => SetEntity(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights Custom
        /// </summary>
        [AllowNull]
        public EllieMaeNetworkServiceCategoriesClassRights Custom { get => GetEntity<EllieMaeNetworkServiceCategoriesClassRights>(); set => SetEntity(value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights None
        /// </summary>
        [AllowNull]
        public EllieMaeNetworkServiceCategoriesClassRights None { get => GetEntity<EllieMaeNetworkServiceCategoriesClassRights>(); set => SetEntity(value); }
    }
}