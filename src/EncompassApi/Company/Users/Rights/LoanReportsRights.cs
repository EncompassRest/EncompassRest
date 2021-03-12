using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// LoanReportsRights
    /// </summary>
    public sealed class LoanReportsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _allowLoanFilesToBeOpenForData;

        /// <summary>
        /// LoanReportsRights AllowLoanFilesToBeOpenForData
        /// </summary>
        [JsonProperty("allowLoanFilesToBeOpenForData(slowerperformance)")]
        public bool? AllowLoanFilesToBeOpenForData { get => _allowLoanFilesToBeOpenForData; set => SetField(ref _allowLoanFilesToBeOpenForData, value); }
    }
}