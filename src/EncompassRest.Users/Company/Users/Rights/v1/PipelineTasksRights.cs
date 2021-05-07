using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PipelineTasksRights
    /// </summary>
    public sealed class PipelineTasksRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _automaticRefreshConfiguration;
        private DirtyValue<bool?>? _bidTape;
        private DirtyValue<bool?>? _deleteLoans;
        private DirtyValue<bool?>? _dueDiligence;
        private DuplicateLoansRights? _duplicateLoans;
        private DirtyValue<bool?>? _duplicateLoansforSecond;
        private DirtyValue<bool?>? _exportDatatoExcel;
        private DirtyValue<bool?>? _generateNMLSReport;
        private GSEServicesRights? _gSEServices;
        private DirtyValue<bool?>? _hedgeAdvisory;
        private HMDAServicesRights? _hMDAServices;
        private ImportLoansRights? _importLoans;
        private DirtyValue<bool?>? _includeArchiveFolders;
        private DirtyValue<bool?>? _investorServices;
        private DirtyValue<bool?>? _manageAlerts;
        private ManagePipelineServicesRights? _managePipelineServices;
        private MoveLoansRights? _moveLoans;
        private NewLoansRights? _newLoans;
        private DirtyValue<bool?>? _subservicing;
        private DirtyValue<bool?>? _transferLoans;
        private TrashFolderTasksRights? _trashFolderTasks;
        private DirtyValue<bool?>? _warehouseLenders;

        /// <summary>
        /// PipelineTasksRights AutomaticRefreshConfiguration
        /// </summary>
        public bool? AutomaticRefreshConfiguration { get => _automaticRefreshConfiguration; set => SetField(ref _automaticRefreshConfiguration, value); }

        /// <summary>
        /// PipelineTasksRights BidTape
        /// </summary>
        public bool? BidTape { get => _bidTape; set => SetField(ref _bidTape, value); }

        /// <summary>
        /// PipelineTasksRights DeleteLoans
        /// </summary>
        public bool? DeleteLoans { get => _deleteLoans; set => SetField(ref _deleteLoans, value); }

        /// <summary>
        /// PipelineTasksRights DueDiligence
        /// </summary>
        public bool? DueDiligence { get => _dueDiligence; set => SetField(ref _dueDiligence, value); }

        /// <summary>
        /// PipelineTasksRights DuplicateLoans
        /// </summary>
        [AllowNull]
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
        [AllowNull]
        public GSEServicesRights GSEServices { get => GetField(ref _gSEServices); set => SetField(ref _gSEServices, value); }

        /// <summary>
        /// PipelineTasksRights HedgeAdvisory
        /// </summary>
        public bool? HedgeAdvisory { get => _hedgeAdvisory; set => SetField(ref _hedgeAdvisory, value); }

        /// <summary>
        /// PipelineTasksRights HMDAServices
        /// </summary>
        [AllowNull]
        public HMDAServicesRights HMDAServices { get => GetField(ref _hMDAServices); set => SetField(ref _hMDAServices, value); }

        /// <summary>
        /// PipelineTasksRights ImportLoans
        /// </summary>
        [AllowNull]
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
        [AllowNull]
        public ManagePipelineServicesRights ManagePipelineServices { get => GetField(ref _managePipelineServices); set => SetField(ref _managePipelineServices, value); }

        /// <summary>
        /// PipelineTasksRights MoveLoans
        /// </summary>
        [AllowNull]
        public MoveLoansRights MoveLoans { get => GetField(ref _moveLoans); set => SetField(ref _moveLoans, value); }

        /// <summary>
        /// PipelineTasksRights NewLoans
        /// </summary>
        [AllowNull]
        public NewLoansRights NewLoans { get => GetField(ref _newLoans); set => SetField(ref _newLoans, value); }

        /// <summary>
        /// PipelineTasksRights Subservicing
        /// </summary>
        public bool? Subservicing { get => _subservicing; set => SetField(ref _subservicing, value); }

        /// <summary>
        /// PipelineTasksRights TransferLoans
        /// </summary>
        public bool? TransferLoans { get => _transferLoans; set => SetField(ref _transferLoans, value); }

        /// <summary>
        /// PipelineTasksRights TrashFolderTasks
        /// </summary>
        [AllowNull]
        public TrashFolderTasksRights TrashFolderTasks { get => GetField(ref _trashFolderTasks); set => SetField(ref _trashFolderTasks, value); }

        /// <summary>
        /// PipelineTasksRights WarehouseLenders
        /// </summary>
        public bool? WarehouseLenders { get => _warehouseLenders; set => SetField(ref _warehouseLenders, value); }
    }
}