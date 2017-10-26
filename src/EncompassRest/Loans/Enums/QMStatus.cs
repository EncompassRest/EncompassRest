using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum QMStatus
    {
        QM = 0,
        [EnumMember(Value = "Non-QM")]
        NonQM = 1,
        Exempt = 2
    }
}