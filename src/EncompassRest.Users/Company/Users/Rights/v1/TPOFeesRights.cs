using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOFeesRights
    /// </summary>
    public sealed class TPOFeesRights : ParentAccessRights
    {
        /// <summary>
        /// TPOFeesRights AddEditTPOFees
        /// </summary>
        [JsonProperty("add/EditTPOFees")]
        [AllowNull]
        public AddEditTPOFeesRights AddEditTPOFees { get => GetEntity<AddEditTPOFeesRights>(); set => SetEntity(value); }
    }
}