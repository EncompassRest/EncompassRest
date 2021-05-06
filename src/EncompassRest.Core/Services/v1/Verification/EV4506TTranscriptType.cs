using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EV4506TTranscriptType
    /// </summary>
    public enum EV4506TTranscriptType
    {
        /// <summary>
        /// Return Transcript
        /// </summary>
        [EnumMember(Value = "Return Transcript")]
        ReturnTranscript = 0,
        /// <summary>
        /// Account Transcript
        /// </summary>
        [EnumMember(Value = "Account Transcript")]
        AccountTranscript = 1,
        /// <summary>
        /// Record Of Account
        /// </summary>
        [EnumMember(Value = "Record Of Account")]
        RecordOfAccount = 2
    }
}