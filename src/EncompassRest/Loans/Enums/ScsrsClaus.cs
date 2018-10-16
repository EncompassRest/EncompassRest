using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ScsrsClaus
    /// </summary>
    public enum ScsrsClaus
    {
        /// <summary>
        /// Its Successors And/Or Assigns
        /// </summary>
        [EnumMember(Value = "Its Successors And/Or Assigns")]
        ItsSuccessorsAndOrAssigns = 0,
        /// <summary>
        /// Its Successors And/Or Assigns, As Their Interest May Appear
        /// </summary>
        [EnumMember(Value = "Its Successors And/Or Assigns, As Their Interest May Appear")]
        ItsSuccessorsAndOrAssignsAsTheirInterestMayAppear = 1,
        /// <summary>
        /// Its Successors And/Or Assigns, A.T.I.M.A.
        /// </summary>
        [EnumMember(Value = "Its Successors And/Or Assigns, A.T.I.M.A.")]
        ItsSuccessorsAndOrAssignsATIMA = 2
    }
}