using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// DeliveryStatus
/// </summary>
public enum DeliveryStatus
{
    /// <summary>
    /// In Progress
    /// </summary>
    [EnumMember(Value = "In Progress")]
    InProgress = 0,
    /// <summary>
    /// Completed
    /// </summary>
    Completed = 1,
    /// <summary>
    /// Submitted
    /// </summary>
    Submitted = 2,
    /// <summary>
    /// Error
    /// </summary>
    Error = 3,
    /// <summary>
    /// Not Submitted
    /// </summary>
    [EnumMember(Value = "Not Submitted")]
    NotSubmitted = 4,
    /// <summary>
    /// Delivered
    /// </summary>
    Delivered = 5,
    /// <summary>
    /// In Review
    /// </summary>
    [EnumMember(Value = "In Review")]
    InReview = 6,
    /// <summary>
    /// Approved
    /// </summary>
    Approved = 7,
    /// <summary>
    /// Denied
    /// </summary>
    Denied = 8,
    /// <summary>
    /// Pending Conditions
    /// </summary>
    [EnumMember(Value = "Pending Conditions")]
    PendingConditions = 9,
    /// <summary>
    /// Purchased
    /// </summary>
    Purchased = 10,
    /// <summary>
    /// Funded
    /// </summary>
    Funded = 11,
    /// <summary>
    /// Customized
    /// </summary>
    Customized = 12
}