namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// HMDAProfilesRights
    /// </summary>
    public sealed class HMDAProfilesRights : ParentAccessRights
    {
        private DirtyValue<bool?> _addHMDAProfile;
        private DirtyValue<bool?> _deleteHMDAProfile;
        private DirtyValue<bool?> _editHMDAProfile;

        /// <summary>
        /// HMDAProfilesRights AddHMDAProfile
        /// </summary>
        public bool? AddHMDAProfile { get => _addHMDAProfile; set => SetField(ref _addHMDAProfile, value); }

        /// <summary>
        /// HMDAProfilesRights DeleteHMDAProfile
        /// </summary>
        public bool? DeleteHMDAProfile { get => _deleteHMDAProfile; set => SetField(ref _deleteHMDAProfile, value); }

        /// <summary>
        /// HMDAProfilesRights EditHMDAProfile
        /// </summary>
        public bool? EditHMDAProfile { get => _editHMDAProfile; set => SetField(ref _editHMDAProfile, value); }
    }
}