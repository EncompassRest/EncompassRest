using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TQLServicesRights
    /// </summary>
    public sealed class TQLServicesRights : ParentAccessRights
    {
        /// <summary>
        /// TQLServicesRights AddComments
        /// </summary>
        public bool? AddComments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TQLServicesRights AddComplianceReportComments
        /// </summary>
        public bool? AddComplianceReportComments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TQLServicesRights AddFraudReportComments
        /// </summary>
        public bool? AddFraudReportComments { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TQLServicesRights SelectInvestor
        /// </summary>
        public bool? SelectInvestor { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TQLServicesRights StartStopPublishing
        /// </summary>
        [JsonProperty("start/StopPublishing")]
        public bool? StartStopPublishing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}