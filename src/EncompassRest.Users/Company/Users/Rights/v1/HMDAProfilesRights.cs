namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// HMDAProfilesRights
    /// </summary>
    public sealed class HMDAProfilesRights : ParentAccessRights
    {
        /// <summary>
        /// HMDAProfilesRights AddHMDAProfile
        /// </summary>
        public bool? AddHMDAProfile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// HMDAProfilesRights DeleteHMDAProfile
        /// </summary>
        public bool? DeleteHMDAProfile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// HMDAProfilesRights EditHMDAProfile
        /// </summary>
        public bool? EditHMDAProfile { get => GetValue<bool?>(); set => SetValue(value); }
    }
}