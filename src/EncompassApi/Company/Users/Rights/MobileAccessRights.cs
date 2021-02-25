namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// MobileAccessRights
    /// </summary>
    public sealed class MobileAccessRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _encompassWindowsClient;
        private DirtyValue<bool?>? _encompassWindowsClientAndMobile;

        /// <summary>
        /// MobileAccessRights EncompassWindowsClient
        /// </summary>
        public bool? EncompassWindowsClient { get => _encompassWindowsClient; set => SetField(ref _encompassWindowsClient, value); }

        /// <summary>
        /// MobileAccessRights EncompassWindowsClientAndMobile
        /// </summary>
        public bool? EncompassWindowsClientAndMobile { get => _encompassWindowsClientAndMobile; set => SetField(ref _encompassWindowsClientAndMobile, value); }
    }
}