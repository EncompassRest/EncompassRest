using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BuydownContributor
    {
        Seller = 0,
        Builder = 1,
        Borrower = 2,
        Unassigned = 3,
        Parent = 4,
        [EnumMember(Value = "Non-Parent Relative")]
        NonParentRelative = 5,
        [EnumMember(Value = "Unrelated Friend")]
        UnrelatedFriend = 6,
        Employer = 7
    }
}