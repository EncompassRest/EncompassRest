using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ImportLoansRights
    /// </summary>
    public sealed class ImportLoansRights : ParentAccessRights
    {
        /// <summary>
        /// ImportLoansRights CalyxPoint
        /// </summary>
        [JsonProperty("calyx Point")]
        public bool? CalyxPoint { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ImportLoansRights FannieMae3x
        /// </summary>
        [JsonProperty("fannie Mae 3.x")]
        public bool? FannieMae3x { get => GetValue<bool?>(); set => SetValue(value); }
    }
}