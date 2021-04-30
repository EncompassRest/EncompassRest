using System.Runtime.Serialization;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// User Rights Category
    /// </summary>
    public enum UserRightsCategory
    {
        /// <summary>
        /// Pipeline
        /// </summary>
        [EnumMember(Value = "pipeline")]
        Pipeline = 0,
        /// <summary>
        /// Loan
        /// </summary>
        [EnumMember(Value = "loan")]
        Loan = 1,
        /// <summary>
        /// eFolder
        /// </summary>
        eFolder = 2,
        /// <summary>
        /// Access
        /// </summary>
        [EnumMember(Value = "access")]
        Access = 3,
        /// <summary>
        /// Miscellaneous
        /// </summary>
        [EnumMember(Value = "miscellaneous")]
        Miscellaneous = 4,
        /// <summary>
        /// Home
        /// </summary>
        [EnumMember(Value = "home")]
        Home = 5,
        /// <summary>
        /// Contacts
        /// </summary>
        [EnumMember(Value = "contacts")]
        Contacts = 6,
        /// <summary>
        /// Dashboard
        /// </summary>
        [EnumMember(Value = "dashboard")]
        Dashboard = 7,
        /// <summary>
        /// Trades
        /// </summary>
        [EnumMember(Value = "trades")]
        Trades = 8,
        /// <summary>
        /// Reports
        /// </summary>
        [EnumMember(Value = "reports")]
        Reports = 9,
        /// <summary>
        /// Tools
        /// </summary>
        [EnumMember(Value = "tools")]
        Tools = 10,
        /// <summary>
        /// Settings
        /// </summary>
        [EnumMember(Value = "settings")]
        Settings = 11,
        /// <summary>
        /// ExternalSettings
        /// </summary>
        [EnumMember(Value = "externalSettings")]
        ExternalSettings = 12,
        /// <summary>
        /// TPOConnect
        /// </summary>
        [EnumMember(Value = "tpoConnect")]
        TPOConnect = 13,
        /// <summary>
        /// ConsumerConnect
        /// </summary>
        [EnumMember(Value = "consumerConnect")]
        ConsumerConnect = 14,
        /// <summary>
        /// Forms
        /// </summary>
        [EnumMember(Value = "forms")]
        Forms = 15
    }
}