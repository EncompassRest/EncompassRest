using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SystemAdministrationRights
    /// </summary>
    public sealed class SystemAdministrationRights : ParentAccessRights
    {
        /// <summary>
        /// SystemAdministrationRights AllUserInformation
        /// </summary>
        public bool? AllUserInformation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SystemAdministrationRights AnalysisTools
        /// </summary>
        public bool? AnalysisTools { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SystemAdministrationRights CurrentLogins
        /// </summary>
        [AllowNull]
        public CurrentLoginsRights CurrentLogins { get => GetEntity<CurrentLoginsRights>(); set => SetEntity(value); }

        /// <summary>
        /// SystemAdministrationRights LoanReassignment
        /// </summary>
        public bool? LoanReassignment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SystemAdministrationRights SettingsReport
        /// </summary>
        [AllowNull]
        public SettingsReportRights SettingsReport { get => GetEntity<SettingsReportRights>(); set => SetEntity(value); }

        /// <summary>
        /// SystemAdministrationRights SystemAuditTrail
        /// </summary>
        public bool? SystemAuditTrail { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SystemAdministrationRights UnlockLoanFile
        /// </summary>
        public bool? UnlockLoanFile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SystemAdministrationRights UnlockTrade
        /// </summary>
        public bool? UnlockTrade { get => GetValue<bool?>(); set => SetValue(value); }
    }
}