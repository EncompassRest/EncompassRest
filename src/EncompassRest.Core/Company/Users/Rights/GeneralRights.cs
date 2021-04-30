using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// GeneralRights
    /// </summary>
    public sealed class GeneralRights : ParentAccessRights
    {
        private AccessCorrespondentRights? _accessCorrespondent;
        private AccessToManageAccountPageRights? _accessToManageAccountPage;
        private DirtyValue<bool?>? _accessToScenarios;
        private AccessWholesaleRights? _accessWholesale;

        /// <summary>
        /// GeneralRights AccessCorrespondent
        /// </summary>
        [AllowNull]
        public AccessCorrespondentRights AccessCorrespondent { get => GetField(ref _accessCorrespondent); set => SetField(ref _accessCorrespondent, value); }

        /// <summary>
        /// GeneralRights AccessToManageAccountPage
        /// </summary>
        [AllowNull]
        public AccessToManageAccountPageRights AccessToManageAccountPage { get => GetField(ref _accessToManageAccountPage); set => SetField(ref _accessToManageAccountPage, value); }

        /// <summary>
        /// GeneralRights AccessToScenarios
        /// </summary>
        public bool? AccessToScenarios { get => _accessToScenarios; set => SetField(ref _accessToScenarios, value); }

        /// <summary>
        /// GeneralRights AccessWholesale
        /// </summary>
        [AllowNull]
        public AccessWholesaleRights AccessWholesale { get => GetField(ref _accessWholesale); set => SetField(ref _accessWholesale, value); }
    }
}