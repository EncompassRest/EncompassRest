using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ShareInfoWithJointMarketing
    {
        [EnumMember(Value = "Your choices will apply to everyone on your account")]
        YourChoicesWillApplyToEveryoneOnYourAccount = 0,
        [EnumMember(Value = "Your choices will apply to everyone on your account - unless you tell us otherwise")]
        YourChoicesWillApplyToEveryoneOnYourAccountUnlessYouTellUsOtherwise = 1
    }
}