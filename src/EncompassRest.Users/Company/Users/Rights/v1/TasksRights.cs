namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TasksRights
    /// </summary>
    public sealed class TasksRights : ParentAccessRights
    {
        /// <summary>
        /// TasksRights AddTasks
        /// </summary>
        public bool? AddTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TasksRights DeleteTasks
        /// </summary>
        public bool? DeleteTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TasksRights EditTasks
        /// </summary>
        public bool? EditTasks { get => GetValue<bool?>(); set => SetValue(value); }
    }
}