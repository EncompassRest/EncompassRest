using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UserRights
    /// </summary>
    public sealed class UserRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UserRights Access
        /// </summary>
        [AllowNull]
        public AccessRights Access { get => GetEntity<AccessRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights ConsumerConnect
        /// </summary>
        [AllowNull]
        public ConsumerConnectRights ConsumerConnect { get => GetEntity<ConsumerConnectRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Contacts
        /// </summary>
        [AllowNull]
        public ContactsRights Contacts { get => GetEntity<ContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Dashboard
        /// </summary>
        [AllowNull]
        public DashboardRights Dashboard { get => GetEntity<DashboardRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights EFolder
        /// </summary>
        [AllowNull]
        public EFolderRights EFolder { get => GetEntity<EFolderRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights EVault
        /// </summary>
        [AllowNull]
        public EVaultRights EVault { get => GetEntity<EVaultRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights ExternalSettings
        /// </summary>
        [AllowNull]
        public ExternalSettingsRights ExternalSettings { get => GetEntity<ExternalSettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Forms
        /// </summary>
        [AllowNull]
        public FormsRights Forms { get => GetEntity<FormsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Home
        /// </summary>
        [AllowNull]
        public HomeRights Home { get => GetEntity<HomeRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Loan
        /// </summary>
        [AllowNull]
        public LoanRights Loan { get => GetEntity<LoanRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights LOConnectTab
        /// </summary>
        [AllowNull]
        public LOConnectTabRights LOConnectTab { get => GetEntity<LOConnectTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights LOConnectTasks
        /// </summary>
        [AllowNull]
        public LOConnectTasksRights LOConnectTasks { get => GetEntity<LOConnectTasksRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Miscellaneous
        /// </summary>
        [AllowNull]
        public MiscellaneousRights Miscellaneous { get => GetEntity<MiscellaneousRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Pipeline
        /// </summary>
        [AllowNull]
        public PipelineRights Pipeline { get => GetEntity<PipelineRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Reports
        /// </summary>
        [AllowNull]
        public ReportsRights Reports { get => GetEntity<ReportsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Settings
        /// </summary>
        [AllowNull]
        public SettingsRights Settings { get => GetEntity<SettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Tools
        /// </summary>
        [AllowNull]
        public ToolsRights Tools { get => GetEntity<ToolsRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights TPOConnect
        /// </summary>
        [AllowNull]
        public TPOConnectRights TPOConnect { get => GetEntity<TPOConnectRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserRights Trades
        /// </summary>
        [AllowNull]
        public TradesRights Trades { get => GetEntity<TradesRights>(); set => SetEntity(value); }
    }
}