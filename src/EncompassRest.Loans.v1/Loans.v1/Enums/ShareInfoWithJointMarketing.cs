using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ShareInfoWithJointMarketing
    /// </summary>
    public enum ShareInfoWithJointMarketing
    {
        /// <summary>
        /// Your choices will apply to everyone on your account
        /// </summary>
        [EnumMember(Value = "Your choices will apply to everyone on your account")]
        YourChoicesWillApplyToEveryoneOnYourAccount = 0,
        /// <summary>
        /// Your choices will apply to everyone on your account - unless you tell us otherwise
        /// </summary>
        [EnumMember(Value = "Your choices will apply to everyone on your account - unless you tell us otherwise")]
        YourChoicesWillApplyToEveryoneOnYourAccountUnlessYouTellUsOtherwise = 1
    }
}