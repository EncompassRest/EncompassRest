using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// EcUpdatesAllowed
    /// </summary>
    public enum EcUpdatesAllowed
    {
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 0,
        /// <summary>
        /// No
        /// </summary>
        No = 1,
        /// <summary>
        /// Documents Only
        /// </summary>
        [EnumMember(Value = "Documents Only")]
        DocumentsOnly = 2
    }
}