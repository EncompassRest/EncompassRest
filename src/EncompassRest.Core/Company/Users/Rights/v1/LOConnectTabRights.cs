namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOConnectTabRights
    /// </summary>
    public sealed class LOConnectTabRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _modifyQueue;
        private DirtyValue<bool?>? _taskPipeline;

        /// <summary>
        /// LOConnectTabRights ModifyQueue
        /// </summary>
        public bool? ModifyQueue { get => _modifyQueue; set => SetField(ref _modifyQueue, value); }

        /// <summary>
        /// LOConnectTabRights TaskPipeline
        /// </summary>
        public bool? TaskPipeline { get => _taskPipeline; set => SetField(ref _taskPipeline, value); }
    }
}