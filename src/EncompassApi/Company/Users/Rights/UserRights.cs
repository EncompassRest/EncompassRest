using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// UserRights
    /// </summary>
    public sealed class UserRights : DirtyExtensibleObject
    {
        private AccessRights? _access;
        private ConsumerConnectRights? _consumerConnect;
        private ContactsRights? _contacts;
        private DashboardRights? _dashboard;
        private EFolderRights? _eFolder;
        private ExternalSettingsRights? _externalSettings;
        private FormsRights? _forms;
        private HomeRights? _home;
        private LoanRights? _loan;
        private LOConnectTabRights? _lOConnectTab;
        private LOConnectTasksRights? _lOConnectTasks;
        private MiscellaneousRights? _miscellaneous;
        private PipelineRights? _pipeline;
        private ReportsRights? _reports;
        private SettingsRights? _settings;
        private ToolsRights? _tools;
        private TPOConnectRights? _tPOConnect;
        private TradesRights? _trades;

        /// <summary>
        /// UserRights Access
        /// </summary>
        [AllowNull]
        public AccessRights Access { get => GetField(ref _access); set => SetField(ref _access, value); }

        /// <summary>
        /// UserRights ConsumerConnect
        /// </summary>
        [AllowNull]
        public ConsumerConnectRights ConsumerConnect { get => GetField(ref _consumerConnect); set => SetField(ref _consumerConnect, value); }

        /// <summary>
        /// UserRights Contacts
        /// </summary>
        [AllowNull]
        public ContactsRights Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }

        /// <summary>
        /// UserRights Dashboard
        /// </summary>
        [AllowNull]
        public DashboardRights Dashboard { get => GetField(ref _dashboard); set => SetField(ref _dashboard, value); }

        /// <summary>
        /// UserRights EFolder
        /// </summary>
        [AllowNull]
        public EFolderRights EFolder { get => GetField(ref _eFolder); set => SetField(ref _eFolder, value); }

        /// <summary>
        /// UserRights ExternalSettings
        /// </summary>
        [AllowNull]
        public ExternalSettingsRights ExternalSettings { get => GetField(ref _externalSettings); set => SetField(ref _externalSettings, value); }

        /// <summary>
        /// UserRights Forms
        /// </summary>
        [AllowNull]
        public FormsRights Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

        /// <summary>
        /// UserRights Home
        /// </summary>
        [AllowNull]
        public HomeRights Home { get => GetField(ref _home); set => SetField(ref _home, value); }

        /// <summary>
        /// UserRights Loan
        /// </summary>
        [AllowNull]
        public LoanRights Loan { get => GetField(ref _loan); set => SetField(ref _loan, value); }

        /// <summary>
        /// UserRights LOConnectTab
        /// </summary>
        [AllowNull]
        public LOConnectTabRights LOConnectTab { get => GetField(ref _lOConnectTab); set => SetField(ref _lOConnectTab, value); }

        /// <summary>
        /// UserRights LOConnectTasks
        /// </summary>
        [AllowNull]
        public LOConnectTasksRights LOConnectTasks { get => GetField(ref _lOConnectTasks); set => SetField(ref _lOConnectTasks, value); }

        /// <summary>
        /// UserRights Miscellaneous
        /// </summary>
        [AllowNull]
        public MiscellaneousRights Miscellaneous { get => GetField(ref _miscellaneous); set => SetField(ref _miscellaneous, value); }

        /// <summary>
        /// UserRights Pipeline
        /// </summary>
        [AllowNull]
        public PipelineRights Pipeline { get => GetField(ref _pipeline); set => SetField(ref _pipeline, value); }

        /// <summary>
        /// UserRights Reports
        /// </summary>
        [AllowNull]
        public ReportsRights Reports { get => GetField(ref _reports); set => SetField(ref _reports, value); }

        /// <summary>
        /// UserRights Settings
        /// </summary>
        [AllowNull]
        public SettingsRights Settings { get => GetField(ref _settings); set => SetField(ref _settings, value); }

        /// <summary>
        /// UserRights Tools
        /// </summary>
        [AllowNull]
        public ToolsRights Tools { get => GetField(ref _tools); set => SetField(ref _tools, value); }

        /// <summary>
        /// UserRights TPOConnect
        /// </summary>
        [AllowNull]
        public TPOConnectRights TPOConnect { get => GetField(ref _tPOConnect); set => SetField(ref _tPOConnect, value); }

        /// <summary>
        /// UserRights Trades
        /// </summary>
        [AllowNull]
        public TradesRights Trades { get => GetField(ref _trades); set => SetField(ref _trades, value); }
    }
}