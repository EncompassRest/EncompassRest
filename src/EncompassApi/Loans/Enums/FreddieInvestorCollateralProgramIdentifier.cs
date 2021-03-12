using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// FreddieInvestorCollateralProgramIdentifier
    /// </summary>
    public enum FreddieInvestorCollateralProgramIdentifier
    {
        /// <summary>
        /// Property Inspection Alternative
        /// </summary>
        [EnumMember(Value = "Property Inspection Alternative")]
        PropertyInspectionAlternative = 0,
        /// <summary>
        /// Property Inspection Waiver
        /// </summary>
        [EnumMember(Value = "Property Inspection Waiver")]
        PropertyInspectionWaiver = 1,
        /// <summary>
        /// Form2070
        /// </summary>
        Form2070 = 2,
        /// <summary>
        /// Form2075
        /// </summary>
        Form2075 = 3
    }
}