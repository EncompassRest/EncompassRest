using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LimitSharing
    {
        Yes = 0,
        No = 1,
        [EnumMember(Value = "We Don't Share")]
        WeDontShare = 2
    }
}