namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOWebCenterSetupRights
    /// </summary>
    public sealed class TPOWebCenterSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTPOWebCenterSetup;

        /// <summary>
        /// TPOWebCenterSetupRights EditTPOWebCenterSetup
        /// </summary>
        public bool? EditTPOWebCenterSetup { get => _editTPOWebCenterSetup; set => SetField(ref _editTPOWebCenterSetup, value); }
    }
}