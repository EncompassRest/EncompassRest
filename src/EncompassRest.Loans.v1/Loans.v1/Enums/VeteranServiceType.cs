using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// VeteranServiceType
    /// </summary>
    public enum VeteranServiceType
    {
        /// <summary>
        /// Separated from Service
        /// </summary>
        [Description("Separated from Service")]
        SeparatedFromService = 0,
        /// <summary>
        /// In Service
        /// </summary>
        [Description("In Service")]
        InService = 1
    }
}