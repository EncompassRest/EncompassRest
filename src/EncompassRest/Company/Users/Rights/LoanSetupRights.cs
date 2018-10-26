using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// LoanSetupRights
    /// </summary>
    public sealed class LoanSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?> _n2009GFEPrint;
        private DirtyValue<bool?> _alerts;
        private DirtyValue<bool?> _autoLoanNumbering;
        private DirtyValue<bool?> _autoMERSMINNumbering;
        private DirtyValue<bool?> _changedCircumstancesSetup;
        private DirtyValue<bool?> _channelOptions;
        private DirtyValue<bool?> _complianceCalendar;
        private DirtyValue<bool?> _conditionForms;
        private DirtyValue<bool?> _defaultInputForms;
        private DirtyValue<bool?> _disclosureTrackingSettings;
        private HMDAProfilesRights _hMDAProfiles;
        private DirtyValue<bool?> _loanCustomFields;
        private DirtyValue<bool?> _loanDuplication;
        private DirtyValue<bool?> _loanFolders;
        private DirtyValue<bool?> _log;
        private DirtyValue<bool?> _nMLSReportSetup;
        private DirtyValue<bool?> _piggybackLoanSynchronization;
        private DirtyValue<bool?> _privacyPolicy;
        private DirtyValue<bool?> _rESPA;
        private DirtyValue<bool?> _syncTemplates;
        private DirtyValue<bool?> _tasks;
        private DirtyValue<bool?> _trusteeList;
        private DirtyValue<bool?> _verificationContactSetup;
        private DirtyValue<bool?> _zipcodeSetup;

        /// <summary>
        /// LoanSetupRights 2009GFEPrint
        /// </summary>
        [JsonProperty("2009GFEPrint")]
        public bool? n2009GFEPrint { get => _n2009GFEPrint; set => SetField(ref _n2009GFEPrint, value); }

        /// <summary>
        /// LoanSetupRights Alerts
        /// </summary>
        public bool? Alerts { get => _alerts; set => SetField(ref _alerts, value); }

        /// <summary>
        /// LoanSetupRights AutoLoanNumbering
        /// </summary>
        public bool? AutoLoanNumbering { get => _autoLoanNumbering; set => SetField(ref _autoLoanNumbering, value); }

        /// <summary>
        /// LoanSetupRights AutoMERSMINNumbering
        /// </summary>
        public bool? AutoMERSMINNumbering { get => _autoMERSMINNumbering; set => SetField(ref _autoMERSMINNumbering, value); }

        /// <summary>
        /// LoanSetupRights ChangedCircumstancesSetup
        /// </summary>
        public bool? ChangedCircumstancesSetup { get => _changedCircumstancesSetup; set => SetField(ref _changedCircumstancesSetup, value); }

        /// <summary>
        /// LoanSetupRights ChannelOptions
        /// </summary>
        public bool? ChannelOptions { get => _channelOptions; set => SetField(ref _channelOptions, value); }

        /// <summary>
        /// LoanSetupRights ComplianceCalendar
        /// </summary>
        public bool? ComplianceCalendar { get => _complianceCalendar; set => SetField(ref _complianceCalendar, value); }

        /// <summary>
        /// LoanSetupRights ConditionForms
        /// </summary>
        public bool? ConditionForms { get => _conditionForms; set => SetField(ref _conditionForms, value); }

        /// <summary>
        /// LoanSetupRights DefaultInputForms
        /// </summary>
        public bool? DefaultInputForms { get => _defaultInputForms; set => SetField(ref _defaultInputForms, value); }

        /// <summary>
        /// LoanSetupRights DisclosureTrackingSettings
        /// </summary>
        public bool? DisclosureTrackingSettings { get => _disclosureTrackingSettings; set => SetField(ref _disclosureTrackingSettings, value); }

        /// <summary>
        /// LoanSetupRights HMDAProfiles
        /// </summary>
        public HMDAProfilesRights HMDAProfiles { get => GetField(ref _hMDAProfiles); set => SetField(ref _hMDAProfiles, value); }

        /// <summary>
        /// LoanSetupRights LoanCustomFields
        /// </summary>
        public bool? LoanCustomFields { get => _loanCustomFields; set => SetField(ref _loanCustomFields, value); }

        /// <summary>
        /// LoanSetupRights LoanDuplication
        /// </summary>
        public bool? LoanDuplication { get => _loanDuplication; set => SetField(ref _loanDuplication, value); }

        /// <summary>
        /// LoanSetupRights LoanFolders
        /// </summary>
        public bool? LoanFolders { get => _loanFolders; set => SetField(ref _loanFolders, value); }

        /// <summary>
        /// LoanSetupRights Log
        /// </summary>
        public bool? Log { get => _log; set => SetField(ref _log, value); }

        /// <summary>
        /// LoanSetupRights NMLSReportSetup
        /// </summary>
        public bool? NMLSReportSetup { get => _nMLSReportSetup; set => SetField(ref _nMLSReportSetup, value); }

        /// <summary>
        /// LoanSetupRights PiggybackLoanSynchronization
        /// </summary>
        public bool? PiggybackLoanSynchronization { get => _piggybackLoanSynchronization; set => SetField(ref _piggybackLoanSynchronization, value); }

        /// <summary>
        /// LoanSetupRights PrivacyPolicy
        /// </summary>
        public bool? PrivacyPolicy { get => _privacyPolicy; set => SetField(ref _privacyPolicy, value); }

        /// <summary>
        /// LoanSetupRights RESPA
        /// </summary>
        public bool? RESPA { get => _rESPA; set => SetField(ref _rESPA, value); }

        /// <summary>
        /// LoanSetupRights SyncTemplates
        /// </summary>
        public bool? SyncTemplates { get => _syncTemplates; set => SetField(ref _syncTemplates, value); }

        /// <summary>
        /// LoanSetupRights Tasks
        /// </summary>
        public bool? Tasks { get => _tasks; set => SetField(ref _tasks, value); }

        /// <summary>
        /// LoanSetupRights TrusteeList
        /// </summary>
        public bool? TrusteeList { get => _trusteeList; set => SetField(ref _trusteeList, value); }

        /// <summary>
        /// LoanSetupRights VerificationContactSetup
        /// </summary>
        public bool? VerificationContactSetup { get => _verificationContactSetup; set => SetField(ref _verificationContactSetup, value); }

        /// <summary>
        /// LoanSetupRights ZipcodeSetup
        /// </summary>
        public bool? ZipcodeSetup { get => _zipcodeSetup; set => SetField(ref _zipcodeSetup, value); }
    }
}