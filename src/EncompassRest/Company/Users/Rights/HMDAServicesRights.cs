namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// HMDAServicesRights
    /// </summary>
    public sealed class HMDAServicesRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _generateHMDALAR;
        private DirtyValue<bool?>? _orderHMDAServices;

        /// <summary>
        /// HMDAServicesRights GenerateHMDALAR
        /// </summary>
        public bool? GenerateHMDALAR { get => _generateHMDALAR; set => SetField(ref _generateHMDALAR, value); }

        /// <summary>
        /// HMDAServicesRights OrderHMDAServices
        /// </summary>
        public bool? OrderHMDAServices { get => _orderHMDAServices; set => SetField(ref _orderHMDAServices, value); }
    }
}