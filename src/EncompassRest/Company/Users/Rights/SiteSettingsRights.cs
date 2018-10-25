namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SiteSettingsRights
    /// </summary>
    public sealed class SiteSettingsRights : DirtyExtensibleObject
    {
        private AccessToTPOTradeManagementRights _accessToTPOTradeManagement;
        private GeneralRights _general;
        private PipelineAndLoansRights _pipelineAndLoans;

        /// <summary>
        /// SiteSettingsRights AccessToTPOTradeManagement
        /// </summary>
        public AccessToTPOTradeManagementRights AccessToTPOTradeManagement { get => GetField(ref _accessToTPOTradeManagement); set => SetField(ref _accessToTPOTradeManagement, value); }

        /// <summary>
        /// SiteSettingsRights General
        /// </summary>
        public GeneralRights General { get => GetField(ref _general); set => SetField(ref _general, value); }

        /// <summary>
        /// SiteSettingsRights PipelineAndLoans
        /// </summary>
        public PipelineAndLoansRights PipelineAndLoans { get => GetField(ref _pipelineAndLoans); set => SetField(ref _pipelineAndLoans, value); }
    }
}