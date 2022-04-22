namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ChangeDisclosureInformationRights
    /// </summary>
    public sealed class ChangeDisclosureInformationRights : ParentAccessRights
    {
        /// <summary>
        /// ChangeDisclosureInformationRights ChangeReasons
        /// </summary>
        public bool? ChangeReasons { get => GetValue<bool?>(); set => SetValue(value); }
    }
}