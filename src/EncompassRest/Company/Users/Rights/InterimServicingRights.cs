using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// InterimServicingRights
    /// </summary>
    public sealed class InterimServicingRights : ParentAccessRights
    {
        private DirtyValue<bool?> _editDeleteTransaction;
        private DirtyValue<bool?> _enterTransaction;
        private StartServicingRights _startServicing;

        /// <summary>
        /// InterimServicingRights EditDeleteTransaction
        /// </summary>
        [JsonProperty("edit/DeleteTransaction")]
        public bool? EditDeleteTransaction { get => _editDeleteTransaction; set => SetField(ref _editDeleteTransaction, value); }

        /// <summary>
        /// InterimServicingRights EnterTransaction
        /// </summary>
        public bool? EnterTransaction { get => _enterTransaction; set => SetField(ref _enterTransaction, value); }

        /// <summary>
        /// InterimServicingRights StartServicing
        /// </summary>
        public StartServicingRights StartServicing { get => GetField(ref _startServicing); set => SetField(ref _startServicing, value); }
    }
}