﻿using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOConnectTasksRights
    /// </summary>
    public sealed class LOConnectTasksRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _addAdhocSubTasks;
        private DirtyValue<bool?>? _addAllTasks;
        private DirtyValue<bool?>? _addCommentsForAllTasks;
        private DirtyValue<bool?>? _addMyTasks;
        private DirtyValue<bool?>? _addSubTasks;
        private DirtyValue<bool?>? _addTasks;
        private DirtyValue<bool?>? _assignAllTasks;
        private DirtyValue<bool?>? _changeDueDate;
        private DirtyValue<bool?>? _changeDueDateForAllTasks;
        private DirtyValue<bool?>? _changeDueDateForMyTasks;
        private DirtyValue<bool?>? _deleteAllTasks;
        private DirtyValue<bool?>? _deleteMyTasks;
        private DirtyValue<bool?>? _deleteTasks;
        private EncompassWebServicesRights? _encompassWebServices;
        private DirtyValue<bool?>? _manageTasks;
        private DirtyValue<bool?>? _modifyAllTasks;
        private DirtyValue<bool?>? _updatePriority;
        private DirtyValue<bool?>? _updateTaskPriority;
        private DirtyValue<bool?>? _viewAllTasks;
        private WorkflowTasksToolRights? _workflowTasksTool;

        /// <summary>
        /// LOConnectTasksRights AddAdhocSubTasks
        /// </summary>
        public bool? AddAdhocSubTasks { get => _addAdhocSubTasks; set => SetField(ref _addAdhocSubTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AddAllTasks
        /// </summary>
        public bool? AddAllTasks { get => _addAllTasks; set => SetField(ref _addAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AddCommentsForAllTasks
        /// </summary>
        public bool? AddCommentsForAllTasks { get => _addCommentsForAllTasks; set => SetField(ref _addCommentsForAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AddMyTasks
        /// </summary>
        public bool? AddMyTasks { get => _addMyTasks; set => SetField(ref _addMyTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AddSubTasks
        /// </summary>
        public bool? AddSubTasks { get => _addSubTasks; set => SetField(ref _addSubTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AddTasks
        /// </summary>
        public bool? AddTasks { get => _addTasks; set => SetField(ref _addTasks, value); }

        /// <summary>
        /// LOConnectTasksRights AssignAllTasks
        /// </summary>
        public bool? AssignAllTasks { get => _assignAllTasks; set => SetField(ref _assignAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDate
        /// </summary>
        public bool? ChangeDueDate { get => _changeDueDate; set => SetField(ref _changeDueDate, value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDateForMyTasks
        /// </summary>
        public bool? ChangeDueDateForMyTasks { get => _changeDueDateForMyTasks; set => SetField(ref _changeDueDateForMyTasks, value); }

        /// <summary>
        /// LOConnectTasksRights ChangeDueDateForAllTasks
        /// </summary>
        public bool? ChangeDueDateForAllTasks { get => _changeDueDateForAllTasks; set => SetField(ref _changeDueDateForAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights DeleteAllTasks
        /// </summary>
        public bool? DeleteAllTasks { get => _deleteAllTasks; set => SetField(ref _deleteAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights DeleteMyTasks
        /// </summary>
        public bool? DeleteMyTasks { get => _deleteMyTasks; set => SetField(ref _deleteMyTasks, value); }

        /// <summary>
        /// LOConnectTasksRights DeleteTasks
        /// </summary>
        public bool? DeleteTasks { get => _deleteTasks; set => SetField(ref _deleteTasks, value); }

        /// <summary>
        /// LOConnectTasksRights EncompassWebServices
        /// </summary>
        [AllowNull]
        public EncompassWebServicesRights EncompassWebServices { get => GetField(ref _encompassWebServices); set => SetField(ref _encompassWebServices, value); }

        /// <summary>
        /// LOConnectTasksRights ManageTasks
        /// </summary>
        public bool? ManageTasks { get => _manageTasks; set => SetField(ref _manageTasks, value); }

        /// <summary>
        /// LOConnectTasksRights ModifyAllTasks
        /// </summary>
        public bool? ModifyAllTasks { get => _modifyAllTasks; set => SetField(ref _modifyAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights UpdatePriority
        /// </summary>
        public bool? UpdatePriority { get => _updatePriority; set => SetField(ref _updatePriority, value); }

        /// <summary>
        /// LOConnectTasksRights UpdateTaskPriority
        /// </summary>
        public bool? UpdateTaskPriority { get => _updateTaskPriority; set => SetField(ref _updateTaskPriority, value); }

        /// <summary>
        /// LOConnectTasksRights ViewAllTasks
        /// </summary>
        public bool? ViewAllTasks { get => _viewAllTasks; set => SetField(ref _viewAllTasks, value); }

        /// <summary>
        /// LOConnectTasksRights WorkflowTasksTool
        /// </summary>
        [AllowNull]
        public WorkflowTasksToolRights WorkflowTasksTool { get => GetField(ref _workflowTasksTool); set => SetField(ref _workflowTasksTool, value); }
    }
}