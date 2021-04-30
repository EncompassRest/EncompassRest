namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TasksRights
    /// </summary>
    public sealed class TasksRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addTasks;
        private DirtyValue<bool?>? _deleteTasks;
        private DirtyValue<bool?>? _editTasks;

        /// <summary>
        /// TasksRights AddTasks
        /// </summary>
        public bool? AddTasks { get => _addTasks; set => SetField(ref _addTasks, value); }

        /// <summary>
        /// TasksRights DeleteTasks
        /// </summary>
        public bool? DeleteTasks { get => _deleteTasks; set => SetField(ref _deleteTasks, value); }

        /// <summary>
        /// TasksRights EditTasks
        /// </summary>
        public bool? EditTasks { get => _editTasks; set => SetField(ref _editTasks, value); }
    }
}