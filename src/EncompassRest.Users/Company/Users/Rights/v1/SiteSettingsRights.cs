using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SiteSettingsRights
    /// </summary>
    public sealed class SiteSettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// SiteSettingsRights AccessToTPOTradeManagement
        /// </summary>
        [AllowNull]
        public AccessToTPOTradeManagementRights AccessToTPOTradeManagement { get => GetEntity<AccessToTPOTradeManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// SiteSettingsRights General
        /// </summary>
        [AllowNull]
        public GeneralRights General { get => GetEntity<GeneralRights>(); set => SetEntity(value); }

        /// <summary>
        /// SiteSettingsRights PipelineAndLoans
        /// </summary>
        [AllowNull]
        public PipelineAndLoansRights PipelineAndLoans { get => GetEntity<PipelineAndLoansRights>(); set => SetEntity(value); }
    }
}