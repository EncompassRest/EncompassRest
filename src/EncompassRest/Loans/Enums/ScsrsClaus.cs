using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ScsrsClaus
    {
        [EnumMember(Value = "Its Successors And/Or Assigns")]
        ItsSuccessorsAndOrAssigns = 0,
        [EnumMember(Value = "Its Successors And/Or Assigns, As Their Interest May Appear")]
        ItsSuccessorsAndOrAssignsAsTheirInterestMayAppear = 1,
        [EnumMember(Value = "Its Successors And/Or Assigns, A.T.I.M.A.")]
        ItsSuccessorsAndOrAssignsATIMA = 2
    }
}