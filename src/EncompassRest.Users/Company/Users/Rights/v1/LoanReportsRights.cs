using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanReportsRights
    /// </summary>
    public sealed class LoanReportsRights : ParentAccessRights
    {
        /// <summary>
        /// LoanReportsRights AllowLoanFilesToBeOpenForData
        /// </summary>
        [JsonProperty("allowLoanFilesToBeOpenForData(slowerperformance)")]
        public bool? AllowLoanFilesToBeOpenForData { get => GetValue<bool?>(); set => SetValue(value); }
    }
}