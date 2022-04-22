using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PostClosingConditionsTabRights
    /// </summary>
    public sealed class PostClosingConditionsTabRights : ParentAccessRights
    {
        /// <summary>
        /// PostClosingConditionsTabRights AddEditDeleteConditions
        /// </summary>
        [JsonProperty("add/Edit/DeleteConditions")]
        public bool? AddEditDeleteConditions { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PostClosingConditionsTabRights AddAutomatedConditions
        /// </summary>
        public bool? AddAutomatedConditions { get => GetValue<bool?>(); set => SetValue(value); }
    }
}