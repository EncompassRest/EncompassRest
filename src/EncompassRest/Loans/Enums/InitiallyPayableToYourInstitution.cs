using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// InitiallyPayableToYourInstitution
    /// </summary>
    public enum InitiallyPayableToYourInstitution
    {
        /// <summary>
        /// 1. Initially payable to your institution
        /// </summary>
        [Description("1. Initially payable to your institution")]
        [EnumMember(Value = "Initially payable to your institution")]
        InitiallyPayableToYourInstitution = 0,
        /// <summary>
        /// 2. Not initially payable to your institution
        /// </summary>
        [Description("2. Not initially payable to your institution")]
        [EnumMember(Value = "Not initially payable to your institution")]
        NotInitiallyPayableToYourInstitution = 1,
        /// <summary>
        /// 3. Not applicable
        /// </summary>
        [Description("3. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 3
    }
}