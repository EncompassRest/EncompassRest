using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// InterimServicingRights
    /// </summary>
    public sealed class InterimServicingRights : ParentAccessRights
    {
        /// <summary>
        /// InterimServicingRights EditDeleteTransaction
        /// </summary>
        [JsonProperty("edit/DeleteTransaction")]
        public bool? EditDeleteTransaction { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// InterimServicingRights EnterTransaction
        /// </summary>
        public bool? EnterTransaction { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// InterimServicingRights StartServicing
        /// </summary>
        [AllowNull]
        public StartServicingRights StartServicing { get => GetEntity<StartServicingRights>(); set => SetEntity(value); }
    }
}