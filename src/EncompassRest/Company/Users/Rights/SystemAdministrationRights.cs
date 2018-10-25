namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SystemAdministrationRights
    /// </summary>
    public sealed class SystemAdministrationRights : ParentAccessRights
    {
        private DirtyValue<bool?> _allUserInformation;
        private DirtyValue<bool?> _analysisTools;
        private CurrentLoginsRights _currentLogins;
        private DirtyValue<bool?> _loanReassignment;
        private SettingsReportRights _settingsReport;
        private DirtyValue<bool?> _systemAuditTrail;
        private DirtyValue<bool?> _unlockLoanFile;

        /// <summary>
        /// SystemAdministrationRights AllUserInformation
        /// </summary>
        public bool? AllUserInformation { get => _allUserInformation; set => SetField(ref _allUserInformation, value); }

        /// <summary>
        /// SystemAdministrationRights AnalysisTools
        /// </summary>
        public bool? AnalysisTools { get => _analysisTools; set => SetField(ref _analysisTools, value); }

        /// <summary>
        /// SystemAdministrationRights CurrentLogins
        /// </summary>
        public CurrentLoginsRights CurrentLogins { get => GetField(ref _currentLogins); set => SetField(ref _currentLogins, value); }

        /// <summary>
        /// SystemAdministrationRights LoanReassignment
        /// </summary>
        public bool? LoanReassignment { get => _loanReassignment; set => SetField(ref _loanReassignment, value); }

        /// <summary>
        /// SystemAdministrationRights SettingsReport
        /// </summary>
        public SettingsReportRights SettingsReport { get => GetField(ref _settingsReport); set => SetField(ref _settingsReport, value); }

        /// <summary>
        /// SystemAdministrationRights SystemAuditTrail
        /// </summary>
        public bool? SystemAuditTrail { get => _systemAuditTrail; set => SetField(ref _systemAuditTrail, value); }

        /// <summary>
        /// SystemAdministrationRights UnlockLoanFile
        /// </summary>
        public bool? UnlockLoanFile { get => _unlockLoanFile; set => SetField(ref _unlockLoanFile, value); }
    }
}