using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GeneralRights
    /// </summary>
    public sealed class GeneralRights : ParentAccessRights
    {
        /// <summary>
        /// GeneralRights AccessCorrespondent
        /// </summary>
        [AllowNull]
        public AccessCorrespondentRights AccessCorrespondent { get => GetEntity<AccessCorrespondentRights>(); set => SetEntity(value); }

        /// <summary>
        /// GeneralRights AccessToManageAccountPage
        /// </summary>
        [AllowNull]
        public AccessToManageAccountPageRights AccessToManageAccountPage { get => GetEntity<AccessToManageAccountPageRights>(); set => SetEntity(value); }

        /// <summary>
        /// GeneralRights AccessToScenarios
        /// </summary>
        public bool? AccessToScenarios { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GeneralRights AccessWholesale
        /// </summary>
        [AllowNull]
        public AccessWholesaleRights AccessWholesale { get => GetEntity<AccessWholesaleRights>(); set => SetEntity(value); }
    }
}