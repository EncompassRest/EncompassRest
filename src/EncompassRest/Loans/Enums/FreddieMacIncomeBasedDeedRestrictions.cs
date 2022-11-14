using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMacIncomeBasedDeedRestrictions
    /// </summary>
    public enum FreddieMacIncomeBasedDeedRestrictions
    {
        /// <summary>
        /// Income Based Deed Restriction Terminate
        /// </summary>
        [EnumMember(Value = "Income Based Deed Restriction Terminate")]
        IncomeBasedDeedRestrictionTerminate = 0,
        /// <summary>
        /// Income Based Deed Restrictions Survive
        /// </summary>
        [EnumMember(Value = "Income Based Deed Restrictions Survive")]
        IncomeBasedDeedRestrictionsSurvive = 1
    }
}