using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ImportLoansRights
    /// </summary>
    public sealed class ImportLoansRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _calyxPoint;
        private DirtyValue<bool?>? _fannieMae3x;

        /// <summary>
        /// ImportLoansRights CalyxPoint
        /// </summary>
        [JsonProperty("calyx Point")]
        public bool? CalyxPoint { get => _calyxPoint; set => SetField(ref _calyxPoint, value); }

        /// <summary>
        /// ImportLoansRights FannieMae3x
        /// </summary>
        [JsonProperty("fannie Mae 3.x")]
        public bool? FannieMae3x { get => _fannieMae3x; set => SetField(ref _fannieMae3x, value); }
    }
}