using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.Verification
{
    public enum EV4506TTranscriptType
    {
        [EnumMember(Value = "Return Transcript")]
        ReturnTranscript = 0,
        [EnumMember(Value = "Account Transcript")]
        AccountTranscript = 1,
        [EnumMember(Value = "Record Of Account")]
        RecordOfAccount = 2
    }
}