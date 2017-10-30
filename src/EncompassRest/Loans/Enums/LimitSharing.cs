using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LimitSharing
    {
        No = 0,
        Yes = 1,
        [EnumMember(Value = "We Don't Share")]
        WeDontShare = 2
    }
}