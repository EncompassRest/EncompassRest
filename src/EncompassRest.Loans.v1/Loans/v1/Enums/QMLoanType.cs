using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// QMLoanType
    /// </summary>
    public enum QMLoanType
    {
        /// <summary>
        /// General QM
        /// </summary>
        [EnumMember(Value = "General QM")]
        GeneralQM = 0,
        /// <summary>
        /// Agency/GSE QM
        /// </summary>
        [EnumMember(Value = "Agency/GSE QM")]
        AgencyGSEQM = 1,
        /// <summary>
        /// FHA QM
        /// </summary>
        [EnumMember(Value = "FHA QM")]
        FHAQM = 2,
        /// <summary>
        /// Small Creditor QM
        /// </summary>
        [EnumMember(Value = "Small Creditor QM")]
        SmallCreditorQM = 3,
        /// <summary>
        /// Small Creditor Rural QM
        /// </summary>
        [EnumMember(Value = "Small Creditor Rural QM")]
        SmallCreditorRuralQM = 4,
        /// <summary>
        /// VA QM
        /// </summary>
        [EnumMember(Value = "VA QM")]
        VAQM = 5
    }
}