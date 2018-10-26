namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// PipelineTasksRights
    /// </summary>
    public sealed class PipelineTasksRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _automaticRefreshConfiguration;
        private DirtyValue<bool?> _deleteLoans;
        private DuplicateLoansRights _duplicateLoans;
        private DirtyValue<bool?> _duplicateLoansforSecond;
        private DirtyValue<bool?> _exportDatatoExcel;
        private DirtyValue<bool?> _generateNMLSReport;
        private GSEServicesRights _gSEServices;
        private HMDAServicesRights _hMDAServices;
        private ImportLoansRights _importLoans;
        private DirtyValue<bool?> _includeArchiveFolders;
        private DirtyValue<bool?> _investorServices;
        private DirtyValue<bool?> _manageAlerts;
        private ManagePipelineServicesRights _managePipelineServices;
        private MoveLoansRights _moveLoans;
        private NewLoansRights _newLoans;
        private DirtyValue<bool?> _transferLoans;
        private TrashFolderTasksRights _trashFolderTasks;

        /// <summary>
        /// PipelineTasksRights AutomaticRefreshConfiguration
        /// </summary>
        public bool? AutomaticRefreshConfiguration { get => _automaticRefreshConfiguration; set => SetField(ref _automaticRefreshConfiguration, value); }

        /// <summary>
        /// PipelineTasksRights DeleteLoans
        /// </summary>
        public bool? DeleteLoans { get => _deleteLoans; set => SetField(ref _deleteLoans, value); }

        /// <summary>
        /// PipelineTasksRights DuplicateLoans
        /// </summary>
        public DuplicateLoansRights DuplicateLoans { get => GetField(ref _duplicateLoans); set => SetField(ref _duplicateLoans, value); }

        /// <summary>
        /// PipelineTasksRights DuplicateLoansforSecond
        /// </summary>
        public bool? DuplicateLoansforSecond { get => _duplicateLoansforSecond; set => SetField(ref _duplicateLoansforSecond, value); }

        /// <summary>
        /// PipelineTasksRights ExportDatatoExcel
        /// </summary>
        public bool? ExportDatatoExcel { get => _exportDatatoExcel; set => SetField(ref _exportDatatoExcel, value); }

        /// <summary>
        /// PipelineTasksRights GenerateNMLSReport
        /// </summary>
        public bool? GenerateNMLSReport { get => _generateNMLSReport; set => SetField(ref _generateNMLSReport, value); }

        /// <summary>
        /// PipelineTasksRights GSEServices
        /// </summary>
        public GSEServicesRights GSEServices { get => GetField(ref _gSEServices); set => SetField(ref _gSEServices, value); }

        /// <summary>
        /// PipelineTasksRights HMDAServices
        /// </summary>
        public HMDAServicesRights HMDAServices { get => GetField(ref _hMDAServices); set => SetField(ref _hMDAServices, value); }

        /// <summary>
        /// PipelineTasksRights ImportLoans
        /// </summary>
        public ImportLoansRights ImportLoans { get => GetField(ref _importLoans); set => SetField(ref _importLoans, value); }

        /// <summary>
        /// PipelineTasksRights IncludeArchiveFolders
        /// </summary>
        public bool? IncludeArchiveFolders { get => _includeArchiveFolders; set => SetField(ref _includeArchiveFolders, value); }

        /// <summary>
        /// PipelineTasksRights InvestorServices
        /// </summary>
        public bool? InvestorServices { get => _investorServices; set => SetField(ref _investorServices, value); }

        /// <summary>
        /// PipelineTasksRights ManageAlerts
        /// </summary>
        public bool? ManageAlerts { get => _manageAlerts; set => SetField(ref _manageAlerts, value); }

        /// <summary>
        /// PipelineTasksRights ManagePipelineServices
        /// </summary>
        public ManagePipelineServicesRights ManagePipelineServices { get => GetField(ref _managePipelineServices); set => SetField(ref _managePipelineServices, value); }

        /// <summary>
        /// PipelineTasksRights MoveLoans
        /// </summary>
        public MoveLoansRights MoveLoans { get => GetField(ref _moveLoans); set => SetField(ref _moveLoans, value); }

        /// <summary>
        /// PipelineTasksRights NewLoans
        /// </summary>
        public NewLoansRights NewLoans { get => GetField(ref _newLoans); set => SetField(ref _newLoans, value); }

        /// <summary>
        /// PipelineTasksRights TransferLoans
        /// </summary>
        public bool? TransferLoans { get => _transferLoans; set => SetField(ref _transferLoans, value); }

        /// <summary>
        /// PipelineTasksRights TrashFolderTasks
        /// </summary>
        public TrashFolderTasksRights TrashFolderTasks { get => GetField(ref _trashFolderTasks); set => SetField(ref _trashFolderTasks, value); }
    }
}