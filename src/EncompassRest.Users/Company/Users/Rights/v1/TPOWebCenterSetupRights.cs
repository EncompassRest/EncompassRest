namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOWebCenterSetupRights
    /// </summary>
    public sealed class TPOWebCenterSetupRights : ParentAccessRights
    {
        /// <summary>
        /// TPOWebCenterSetupRights EditTPOWebCenterSetup
        /// </summary>
        public bool? EditTPOWebCenterSetup { get => GetValue<bool?>(); set => SetValue(value); }
    }
}