namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EllieMaeNetworkServiceCategoriesRights
    /// </summary>
    public sealed class EllieMaeNetworkServiceCategoriesRights : DirtyExtensibleObject
    {
        private EllieMaeNetworkServiceCategoriesClassRights _all;
        private EllieMaeNetworkServiceCategoriesClassRights _custom;
        private EllieMaeNetworkServiceCategoriesClassRights _none;

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights All
        /// </summary>
        public EllieMaeNetworkServiceCategoriesClassRights All { get => GetField(ref _all); set => SetField(ref _all, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights Custom
        /// </summary>
        public EllieMaeNetworkServiceCategoriesClassRights Custom { get => GetField(ref _custom); set => SetField(ref _custom, value); }

        /// <summary>
        /// EllieMaeNetworkServiceCategoriesRights None
        /// </summary>
        public EllieMaeNetworkServiceCategoriesClassRights None { get => GetField(ref _none); set => SetField(ref _none, value); }
    }
}