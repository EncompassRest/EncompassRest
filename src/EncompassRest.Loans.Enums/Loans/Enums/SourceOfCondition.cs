namespace EncompassRest.Loans.Enums;

/// <summary>
/// SourceOfCondition
/// </summary>
public enum SourceOfCondition
{
    /// <summary>
    /// User
    /// </summary>
    User = 0,
    /// <summary>
    /// Manual
    /// </summary>
    Manual = 1,
    /// <summary>
    /// InvestorDelivery
    /// </summary>
    InvestorDelivery = 2,
    /// <summary>
    /// ConditionList
    /// </summary>
    ConditionList = 3,
    /// <summary>
    /// AutomatedByRule
    /// </summary>
    AutomatedByRule = 4,
    /// <summary>
    /// AutomatedByUser
    /// </summary>
    AutomatedByUser = 5,
    /// <summary>
    /// Duplicate
    /// </summary>
    Duplicate = 6
}