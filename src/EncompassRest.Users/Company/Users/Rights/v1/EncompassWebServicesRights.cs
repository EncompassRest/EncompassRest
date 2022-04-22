using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EncompassWebServicesRights
    /// </summary>
    public sealed class EncompassWebServicesRights : ParentAccessRights
    {
        /// <summary>
        /// EncompassWebServicesRights AllServices
        /// </summary>
        public bool? AllServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EncompassWebServicesRights UnderwritingCenter
        /// </summary>
        [AllowNull]
        public UnderwritingCenterRights UnderwritingCenter { get => GetEntity<UnderwritingCenterRights>(); set => SetEntity(value); }
    }
}