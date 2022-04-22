namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOConnectTabRights
    /// </summary>
    public sealed class LOConnectTabRights : DirtyExtensibleObject
    {
        /// <summary>
        /// LOConnectTabRights ModifyQueue
        /// </summary>
        public bool? ModifyQueue { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTabRights TaskPipeline
        /// </summary>
        public bool? TaskPipeline { get => GetValue<bool?>(); set => SetValue(value); }
    }
}