using System.Runtime.Serialization;

namespace EncompassApi.Loans.Conditions
{
    /// <summary>
    /// ConditionSource
    /// </summary>
    public enum ConditionSource
    {
        /// <summary>
        /// Escrow
        /// </summary>
        Escrow = 0,
        /// <summary>
        /// Investor
        /// </summary>
        Investor = 1,
        /// <summary>
        /// Recorder's Office
        /// </summary>
        [EnumMember(Value = "Recorder's Office")]
        RecordersOffice = 2,
        /// <summary>
        /// Borrowers
        /// </summary>
        Borrowers = 3,
        /// <summary>
        /// FHA
        /// </summary>
        FHA = 4,
        /// <summary>
        /// VA
        /// </summary>
        VA = 5,
        /// <summary>
        /// MI
        /// </summary>
        MI = 6,
        /// <summary>
        /// Company
        /// </summary>
        Company = 7,
        /// <summary>
        /// Other
        /// </summary>
        Other = 8,
        /// <summary>
        /// Manual
        /// </summary>
        Manual = 9,
        /// <summary>
        /// Condition Set
        /// </summary>
        [EnumMember(Value = "Condition Set")]
        ConditionSet = 10,
        /// <summary>
        /// Automated Conditions
        /// </summary>
        [EnumMember(Value = "Automated Conditions")]
        AutomatedConditions = 11
    }
}