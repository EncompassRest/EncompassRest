using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DisclosureType
    /// </summary>
    public enum DisclosureType
    {
        /// <summary>
        /// Initial disclosure estimated at time of application
        /// </summary>
        [Description("Initial disclosure estimated at time of application")]
        Initial = 0,
        /// <summary>
        /// Final disclosure based on contract terms
        /// </summary>
        [Description("Final disclosure based on contract terms")]
        Final = 1
    }
}