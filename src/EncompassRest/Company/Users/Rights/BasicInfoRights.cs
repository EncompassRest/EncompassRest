namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// BasicInfoRights
    /// </summary>
    public sealed class BasicInfoRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editBasicInformation;

        /// <summary>
        /// BasicInfoRights EditBasicInformation
        /// </summary>
        public bool? EditBasicInformation { get => _editBasicInformation; set => SetField(ref _editBasicInformation, value); }
    }
}