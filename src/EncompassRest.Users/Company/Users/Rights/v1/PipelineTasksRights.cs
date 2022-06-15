using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PipelineTasksRights
    /// </summary>
    public sealed class PipelineTasksRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PipelineTasksRights AutomaticRefreshConfiguration
        /// </summary>
        public bool? AutomaticRefreshConfiguration { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights BidTape
        /// </summary>
        public bool? BidTape { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights CreatePipelineViews
        /// </summary>
        public bool? CreatePipelineViews { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights DeleteLoans
        /// </summary>
        public bool? DeleteLoans { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights DueDiligence
        /// </summary>
        public bool? DueDiligence { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights DuplicateLoans
        /// </summary>
        [AllowNull]
        public DuplicateLoansRights DuplicateLoans { get => GetEntity<DuplicateLoansRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights DuplicateLoansforSecond
        /// </summary>
        public bool? DuplicateLoansforSecond { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights ExportDatatoExcel
        /// </summary>
        public bool? ExportDatatoExcel { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights GenerateNMLSReport
        /// </summary>
        public bool? GenerateNMLSReport { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights GSEServices
        /// </summary>
        [AllowNull]
        public GSEServicesRights GSEServices { get => GetEntity<GSEServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights HedgeAdvisory
        /// </summary>
        public bool? HedgeAdvisory { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights HMDAServices
        /// </summary>
        [AllowNull]
        public HMDAServicesRights HMDAServices { get => GetEntity<HMDAServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights ImportLoans
        /// </summary>
        [AllowNull]
        public ImportLoansRights ImportLoans { get => GetEntity<ImportLoansRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights IncludeArchiveFolders
        /// </summary>
        public bool? IncludeArchiveFolders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights InvestorServices
        /// </summary>
        public bool? InvestorServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights ManageAlerts
        /// </summary>
        public bool? ManageAlerts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights ManagePipelineServices
        /// </summary>
        [AllowNull]
        public ManagePipelineServicesRights ManagePipelineServices { get => GetEntity<ManagePipelineServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights MoveLoans
        /// </summary>
        [AllowNull]
        public MoveLoansRights MoveLoans { get => GetEntity<MoveLoansRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights NewLoans
        /// </summary>
        [AllowNull]
        public NewLoansRights NewLoans { get => GetEntity<NewLoansRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights QCAudit
        /// </summary>
        public bool? QCAudit { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights Subservicing
        /// </summary>
        public bool? Subservicing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights TransferLoans
        /// </summary>
        public bool? TransferLoans { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PipelineTasksRights TrashFolderTasks
        /// </summary>
        [AllowNull]
        public TrashFolderTasksRights TrashFolderTasks { get => GetEntity<TrashFolderTasksRights>(); set => SetEntity(value); }

        /// <summary>
        /// PipelineTasksRights WarehouseLenders
        /// </summary>
        public bool? WarehouseLenders { get => GetValue<bool?>(); set => SetValue(value); }
    }
}