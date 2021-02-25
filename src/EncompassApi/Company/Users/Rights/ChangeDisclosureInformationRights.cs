namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ChangeDisclosureInformationRights
    /// </summary>
    public sealed class ChangeDisclosureInformationRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _changeReasons;

        /// <summary>
        /// ChangeDisclosureInformationRights ChangeReasons
        /// </summary>
        public bool? ChangeReasons { get => _changeReasons; set => SetField(ref _changeReasons, value); }
    }
}