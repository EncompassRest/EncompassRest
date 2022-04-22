using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanSetupRights
    /// </summary>
    public sealed class LoanSetupRights : ParentAccessRights
    {
        /// <summary>
        /// LoanSetupRights 2009GFEPrint
        /// </summary>
        [JsonProperty("2009GFEPrint")]
        public bool? n2009GFEPrint { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights Alerts
        /// </summary>
        public bool? Alerts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights AutoLoanNumbering
        /// </summary>
        public bool? AutoLoanNumbering { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights AutoMERSMINNumbering
        /// </summary>
        public bool? AutoMERSMINNumbering { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights ChangedCircumstancesSetup
        /// </summary>
        public bool? ChangedCircumstancesSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights ChannelOptions
        /// </summary>
        public bool? ChannelOptions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights ComplianceCalendar
        /// </summary>
        public bool? ComplianceCalendar { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights ConditionForms
        /// </summary>
        public bool? ConditionForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights DefaultInputForms
        /// </summary>
        public bool? DefaultInputForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights DisclosureTrackingSettings
        /// </summary>
        public bool? DisclosureTrackingSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights HMDAProfiles
        /// </summary>
        [AllowNull]
        public HMDAProfilesRights HMDAProfiles { get => GetEntity<HMDAProfilesRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanSetupRights LoanCustomFields
        /// </summary>
        public bool? LoanCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights LoanDuplication
        /// </summary>
        public bool? LoanDuplication { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights LoanFolders
        /// </summary>
        public bool? LoanFolders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights Log
        /// </summary>
        public bool? Log { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights NMLSReportSetup
        /// </summary>
        public bool? NMLSReportSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights PiggybackLoanSynchronization
        /// </summary>
        public bool? PiggybackLoanSynchronization { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights PrivacyPolicy
        /// </summary>
        public bool? PrivacyPolicy { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights RESPA
        /// </summary>
        public bool? RESPA { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights SyncTemplates
        /// </summary>
        public bool? SyncTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights Tasks
        /// </summary>
        public bool? Tasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights TrusteeList
        /// </summary>
        public bool? TrusteeList { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights VerificationContactSetup
        /// </summary>
        public bool? VerificationContactSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanSetupRights ZipcodeSetup
        /// </summary>
        public bool? ZipcodeSetup { get => GetValue<bool?>(); set => SetValue(value); }
    }
}