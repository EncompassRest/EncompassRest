using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Flood
{
    /// <summary>
    /// FloodProductNameAlt
    /// </summary>
    public enum FloodProductNameAlt
    {
        /// <summary>
        /// Basic Flood Certification
        /// </summary>
        [EnumMember(Value = "Basic Flood Certification")]
        [Description("F")]
        BasicFloodCertification = 0,
        /// <summary>
        /// Basic with Census Data
        /// </summary>
        [EnumMember(Value = "Basic with Census Data")]
        [Description("FC")]
        BasicWithCensusData = 1,
        /// <summary>
        /// Life of Loan Flood Determination
        /// </summary>
        [EnumMember(Value = "Life of Loan Flood Determination")]
        [Description("FL")]
        LifeOfLoanFloodDetermination = 2,
        /// <summary>
        /// Life of Loan with Census Tract
        /// </summary>
        [EnumMember(Value = "Life of Loan with Census Tract")]
        [Description("FLC")]
        LifeOfLoanWithCensusTract = 3,
        /// <summary>
        /// Life of Loan Related Loan
        /// </summary>
        [EnumMember(Value = "Life of Loan Related Loan")]
        [Description("FLR")]
        LifeOfLoanRelatedLoan = 4,
        /// <summary>
        /// Life of Loan Related Loan with Census Data
        /// </summary>
        [EnumMember(Value = "Life of Loan Related Loan with Census Data")]
        [Description("FLCR")]
        LifeOfLoanRelatedLoanWithCensusData = 5,
        /// <summary>
        /// Life of Loan Special Property
        /// </summary>
        [EnumMember(Value = "Life of Loan Special Property")]
        [Description("FLO")]
        LifeOfLoanSpecialProperty = 6,
        /// <summary>
        /// Life of Loan Special Property with Census
        /// </summary>
        [EnumMember(Value = "Life of Loan Special Property with Census")]
        [Description("FLCO")]
        LifeOfLoanSpecialPropertyWithCensus = 7
    }
}