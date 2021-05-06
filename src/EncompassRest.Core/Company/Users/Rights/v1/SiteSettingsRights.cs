using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SiteSettingsRights
    /// </summary>
    public sealed class SiteSettingsRights : DirtyExtensibleObject
    {
        private AccessToTPOTradeManagementRights? _accessToTPOTradeManagement;
        private GeneralRights? _general;
        private PipelineAndLoansRights? _pipelineAndLoans;

        /// <summary>
        /// SiteSettingsRights AccessToTPOTradeManagement
        /// </summary>
        [AllowNull]
        public AccessToTPOTradeManagementRights AccessToTPOTradeManagement { get => GetField(ref _accessToTPOTradeManagement); set => SetField(ref _accessToTPOTradeManagement, value); }

        /// <summary>
        /// SiteSettingsRights General
        /// </summary>
        [AllowNull]
        public GeneralRights General { get => GetField(ref _general); set => SetField(ref _general, value); }

        /// <summary>
        /// SiteSettingsRights PipelineAndLoans
        /// </summary>
        [AllowNull]
        public PipelineAndLoansRights PipelineAndLoans { get => GetField(ref _pipelineAndLoans); set => SetField(ref _pipelineAndLoans, value); }
    }
}