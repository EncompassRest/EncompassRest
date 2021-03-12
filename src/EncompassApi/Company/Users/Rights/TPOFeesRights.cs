using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// TPOFeesRights
    /// </summary>
    public sealed class TPOFeesRights : ParentAccessRights
    {
        private AddEditTPOFeesRights? _addEditTPOFees;

        /// <summary>
        /// TPOFeesRights AddEditTPOFees
        /// </summary>
        [JsonProperty("add/EditTPOFees")]
        [AllowNull]
        public AddEditTPOFeesRights AddEditTPOFees { get => GetField(ref _addEditTPOFees); set => SetField(ref _addEditTPOFees, value); }
    }
}