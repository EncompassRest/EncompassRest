using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// LEReceivedMethod
    /// </summary>
    public enum LEReceivedMethod
    {
        /// <summary>
        /// In Person
        /// </summary>
        [Description("In Person")]
        InPerson = 0,
        /// <summary>
        /// Phone
        /// </summary>
        Phone = 1,
        /// <summary>
        /// Email
        /// </summary>
        Email = 2,
        /// <summary>
        /// Signature
        /// </summary>
        Signature = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}