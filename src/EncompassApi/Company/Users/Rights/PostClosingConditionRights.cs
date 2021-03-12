using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// PostClosingConditionRights
    /// </summary>
    public sealed class PostClosingConditionRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _importConditions;

        /// <summary>
        /// PostClosingConditionRights ImportConditions
        /// </summary>
        public bool? ImportConditions { get => _importConditions; set => SetField(ref _importConditions, value); }
    }
}