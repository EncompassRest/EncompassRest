using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EVVOEOptions
    /// </summary>
    public sealed class EVVOEOptions : ServiceOptions
    {
        /// <summary>
        /// Indicates the type of request you are submitting.
        /// </summary>
        public new StringEnumValue<EVVOERequestType> RequestType => base.RequestType;

        /// <summary>
        /// Indicates whose employment to verify.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEReportOn> ReportOn { get; set; }

        /// <summary>
        /// Type of employment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEEmployment> Employment { get; set; }

        /// <summary>
        /// Employer status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<EVVOEEmployer> Employer { get; set; }

        /// <summary>
        /// Determines how to authenticate to The Work Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? DigiCert { get; set; }

        /// <summary>
        /// Internal identifier used by The Work Number to track a previously ordered verification report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? VerificationReportIdentifier { get; set; }

        /// <summary>
        /// Six-digit number that allows one-time access to salary information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? SalaryKey { get; set; }

        /// <summary>
        /// Name of the borrower's employer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EmployerName { get; set; }

        /// <summary>
        /// Internal code used by The Work Number to refer to an employer in their employer database.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EmployerCode { get; set; }

        /// <summary>
        /// Alternate ID used if the employee is a government employee.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AlternateId { get; set; }

        /// <summary>
        /// EVVOEOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the type of request you are submitting.</param>
        public EVVOEOptions(EVVOERequestType requestType)
            : this(requestType.Validate(nameof(requestType)).GetValue())
        {
        }

        /// <summary>
        /// EVVOEOptions constructor.
        /// </summary>
        /// <param name="requestType">Indicates the type of request you are submitting.</param>
        public EVVOEOptions(string requestType)
            : base(requestType)
        {
        }
    }
}