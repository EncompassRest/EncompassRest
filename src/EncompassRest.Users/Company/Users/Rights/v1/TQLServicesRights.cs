using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TQLServicesRights
    /// </summary>
    public sealed class TQLServicesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addComments;
        private DirtyValue<bool?>? _addComplianceReportComments;
        private DirtyValue<bool?>? _addFraudReportComments;
        private DirtyValue<bool?>? _selectInvestor;
        private DirtyValue<bool?>? _startStopPublishing;

        /// <summary>
        /// TQLServicesRights AddComments
        /// </summary>
        public bool? AddComments { get => _addComments; set => SetField(ref _addComments, value); }

        /// <summary>
        /// TQLServicesRights AddComplianceReportComments
        /// </summary>
        public bool? AddComplianceReportComments { get => _addComplianceReportComments; set => SetField(ref _addComplianceReportComments, value); }

        /// <summary>
        /// TQLServicesRights AddFraudReportComments
        /// </summary>
        public bool? AddFraudReportComments { get => _addFraudReportComments; set => SetField(ref _addFraudReportComments, value); }

        /// <summary>
        /// TQLServicesRights SelectInvestor
        /// </summary>
        public bool? SelectInvestor { get => _selectInvestor; set => SetField(ref _selectInvestor, value); }

        /// <summary>
        /// TQLServicesRights StartStopPublishing
        /// </summary>
        [JsonProperty("start/StopPublishing")]
        public bool? StartStopPublishing { get => _startStopPublishing; set => SetField(ref _startStopPublishing, value); }
    }
}