using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EncompassWebServicesRights
    /// </summary>
    public sealed class EncompassWebServicesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _allServices;
        private UnderwritingCenterRights? _underwritingCenter;

        /// <summary>
        /// EncompassWebServicesRights AllServices
        /// </summary>
        public bool? AllServices { get => _allServices; set => SetField(ref _allServices, value); }

        /// <summary>
        /// EncompassWebServicesRights UnderwritingCenter
        /// </summary>
        [AllowNull]
        public UnderwritingCenterRights UnderwritingCenter { get => GetField(ref _underwritingCenter); set => SetField(ref _underwritingCenter, value); }
    }
}