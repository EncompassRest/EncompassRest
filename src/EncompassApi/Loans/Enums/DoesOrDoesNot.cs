using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// DoesOrDoesNot
    /// </summary>
    public enum DoesOrDoesNot
    {
        /// <summary>
        /// Does not
        /// </summary>
        [EnumMember(Value = "Does not")]
        DoesNot = 0,
        /// <summary>
        /// Does
        /// </summary>
        Does = 1
    }
}