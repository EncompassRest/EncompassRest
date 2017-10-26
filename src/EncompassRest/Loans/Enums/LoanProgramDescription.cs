using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum LoanProgramDescription
    {
        [EnumMember(Value = "Bridge Loan")]
        BridgeLoan = 0,
        [EnumMember(Value = "Construction Only")]
        ConstructionOnly = 1,
        [EnumMember(Value = "Construction To Permanent")]
        ConstructionToPermanent = 2,
        [EnumMember(Value = "Emergency Economic Stabilization Act")]
        EmergencyEconomicStabilizationAct = 3,
        HELOC = 4,
        [EnumMember(Value = "Housing Finance Agency Program")]
        HousingFinanceAgencyProgram = 5,
        [EnumMember(Value = "Non Standard To Standard Refinance")]
        NonStandardToStandardRefinance = 6,
        [EnumMember(Value = "Reverse Mortgage")]
        ReverseMortgage = 7,
        [EnumMember(Value = "Time Share Plan")]
        TimeSharePlan = 8,
        [EnumMember(Value = "Vacant Land")]
        VacantLand = 9
    }
}