using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieInvestorCollateralProgramIdentifier
    {
        [EnumMember(Value = "Property Inspection Alternative")]
        PropertyInspectionAlternative = 0,
        [EnumMember(Value = "Property Inspection Waiver")]
        PropertyInspectionWaiver = 1,
        Form2070 = 2,
        Form2075 = 3
    }
}