using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanProgramDescription
    /// </summary>
    public enum LoanProgramDescription
    {
        /// <summary>
        /// Bridge Loan
        /// </summary>
        [EnumMember(Value = "Bridge Loan")]
        BridgeLoan = 0,
        /// <summary>
        /// Construction Only
        /// </summary>
        [EnumMember(Value = "Construction Only")]
        ConstructionOnly = 1,
        /// <summary>
        /// Construction To Permanent
        /// </summary>
        [EnumMember(Value = "Construction To Permanent")]
        ConstructionToPermanent = 2,
        /// <summary>
        /// Emergency Economic Stabilization Act
        /// </summary>
        [EnumMember(Value = "Emergency Economic Stabilization Act")]
        EmergencyEconomicStabilizationAct = 3,
        /// <summary>
        /// HELOC
        /// </summary>
        HELOC = 4,
        /// <summary>
        /// Housing Finance Agency Program
        /// </summary>
        [EnumMember(Value = "Housing Finance Agency Program")]
        HousingFinanceAgencyProgram = 5,
        /// <summary>
        /// Non Standard To Standard Refinance
        /// </summary>
        [EnumMember(Value = "Non Standard To Standard Refinance")]
        NonStandardToStandardRefinance = 6,
        /// <summary>
        /// Reverse Mortgage
        /// </summary>
        [EnumMember(Value = "Reverse Mortgage")]
        ReverseMortgage = 7,
        /// <summary>
        /// Time Share Plan
        /// </summary>
        [EnumMember(Value = "Time Share Plan")]
        TimeSharePlan = 8,
        /// <summary>
        /// Vacant Land
        /// </summary>
        [EnumMember(Value = "Vacant Land")]
        VacantLand = 9
    }
}