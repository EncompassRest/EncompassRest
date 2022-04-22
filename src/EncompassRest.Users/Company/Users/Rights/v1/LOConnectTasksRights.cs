using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOConnectTasksRights
    /// </summary>
    public sealed class LOConnectTasksRights : DirtyExtensibleObject
    {
        /// <summary>
        /// LOConnectTasksRights AddAdhocSubTasks
        /// </summary>
        public bool? AddAdhocSubTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AddAllTasks
        /// </summary>
        public bool? AddAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AddCommentsForAllTasks
        /// </summary>
        public bool? AddCommentsForAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AddMyTasks
        /// </summary>
        public bool? AddMyTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AddSubTasks
        /// </summary>
        public bool? AddSubTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AddTasks
        /// </summary>
        public bool? AddTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights AssignAllTasks
        /// </summary>
        public bool? AssignAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDate
        /// </summary>
        public bool? ChangeDueDate { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDateForMyTasks
        /// </summary>
        public bool? ChangeDueDateForMyTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDateForAllTasks
        /// </summary>
        public bool? ChangeDueDateForAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights DeleteAllTasks
        /// </summary>
        public bool? DeleteAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights DeleteMyTasks
        /// </summary>
        public bool? DeleteMyTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights DeleteTasks
        /// </summary>
        public bool? DeleteTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights EncompassWebServices
        /// </summary>
        [AllowNull]
        public EncompassWebServicesRights EncompassWebServices { get => GetEntity<EncompassWebServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// LOConnectTasksRights ManageTasks
        /// </summary>
        public bool? ManageTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights ModifyAllTasks
        /// </summary>
        public bool? ModifyAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights UpdatePriority
        /// </summary>
        public bool? UpdatePriority { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights UpdateTaskPriority
        /// </summary>
        public bool? UpdateTaskPriority { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights ViewAllTasks
        /// </summary>
        public bool? ViewAllTasks { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOConnectTasksRights WorkflowTasksTool
        /// </summary>
        [AllowNull]
        public WorkflowTasksToolRights WorkflowTasksTool { get => GetEntity<WorkflowTasksToolRights>(); set => SetEntity(value); }
    }
}