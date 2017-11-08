using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CreditReportAuthorizationMethod
    {
        Phone = 0,
        [EnumMember(Value = "Face to Face")]
        FaceToFace = 1,
        Internet = 2,
        Mail = 3
    }
}