using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// BuydownContributor
/// </summary>
public enum BuydownContributor
{
    /// <summary>
    /// Seller
    /// </summary>
    Seller = 0,
    /// <summary>
    /// Builder
    /// </summary>
    Builder = 1,
    /// <summary>
    /// Borrower
    /// </summary>
    Borrower = 2,
    /// <summary>
    /// Unassigned
    /// </summary>
    Unassigned = 3,
    /// <summary>
    /// Parent
    /// </summary>
    Parent = 4,
    /// <summary>
    /// Non-Parent Relative
    /// </summary>
    [EnumMember(Value = "Non-Parent Relative")]
    NonParentRelative = 5,
    /// <summary>
    /// Unrelated Friend
    /// </summary>
    [EnumMember(Value = "Unrelated Friend")]
    UnrelatedFriend = 6,
    /// <summary>
    /// Employer
    /// </summary>
    Employer = 7,
    /// <summary>
    /// Lender
    /// </summary>
    Lender = 8
}