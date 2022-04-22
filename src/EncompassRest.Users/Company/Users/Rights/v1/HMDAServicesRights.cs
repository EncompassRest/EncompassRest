namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// HMDAServicesRights
    /// </summary>
    public sealed class HMDAServicesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// HMDAServicesRights GenerateHMDALAR
        /// </summary>
        public bool? GenerateHMDALAR { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// HMDAServicesRights OrderHMDAServices
        /// </summary>
        public bool? OrderHMDAServices { get => GetValue<bool?>(); set => SetValue(value); }
    }
}