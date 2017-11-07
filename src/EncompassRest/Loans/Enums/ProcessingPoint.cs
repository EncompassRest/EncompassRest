using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ProcessingPoint
    {
        [EnumMember(Value = "Prequal (No URLA)")]
        PrequalNoURLA = 0,
        [EnumMember(Value = "Application/Processing")]
        ApplicationProcessing = 1,
        Underwriting = 2,
        [EnumMember(Value = "Final Disposition")]
        FinalDisposition = 3,
        [EnumMember(Value = "Post-Closing QC")]
        PostClosingQC = 4
    }
}