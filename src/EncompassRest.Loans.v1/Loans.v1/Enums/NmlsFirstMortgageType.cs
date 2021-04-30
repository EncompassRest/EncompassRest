using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NmlsFirstMortgageType
    /// </summary>
    public enum NmlsFirstMortgageType
    {
        /// <summary>
        /// Government (FHA/VA/RHS) Fixed
        /// </summary>
        [Description("Government (FHA/VA/RHS) Fixed")]
        GovtFixed = 0,
        /// <summary>
        /// Government (FHA/VA/RHS) ARM
        /// </summary>
        [Description("Government (FHA/VA/RHS) ARM")]
        GovtARM = 1,
        /// <summary>
        /// Prime Conforming Fixed
        /// </summary>
        [Description("Prime Conforming Fixed")]
        PrimeConformingFixed = 2,
        /// <summary>
        /// Prime Conforming ARM
        /// </summary>
        [Description("Prime Conforming ARM")]
        PrimeConformingARM = 3,
        /// <summary>
        /// Prime Jumbo Fixed
        /// </summary>
        [Description("Prime Jumbo Fixed")]
        PrimeJumboFixed = 4,
        /// <summary>
        /// Prime Jumbo ARM
        /// </summary>
        [Description("Prime Jumbo ARM")]
        PrimeJumboARM = 5,
        /// <summary>
        /// Other Fixed
        /// </summary>
        [Description("Other Fixed")]
        OtherFixed = 6,
        /// <summary>
        /// Other ARM
        /// </summary>
        [Description("Other ARM")]
        OtherARM = 7
    }
}