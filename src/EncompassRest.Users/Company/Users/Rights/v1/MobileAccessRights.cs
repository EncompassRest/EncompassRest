namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MobileAccessRights
    /// </summary>
    public sealed class MobileAccessRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MobileAccessRights EncompassWindowsClient
        /// </summary>
        public bool? EncompassWindowsClient { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// MobileAccessRights EncompassWindowsClientAndMobile
        /// </summary>
        public bool? EncompassWindowsClientAndMobile { get => GetValue<bool?>(); set => SetValue(value); }
    }
}