using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CreditReportAuthorizationMethod
    /// </summary>
    public enum CreditReportAuthorizationMethod
    {
        /// <summary>
        /// Phone
        /// </summary>
        Phone = 0,
        /// <summary>
        /// Face to Face
        /// </summary>
        [EnumMember(Value = "Face to Face")]
        FaceToFace = 1,
        /// <summary>
        /// Internet
        /// </summary>
        Internet = 2,
        /// <summary>
        /// Mail
        /// </summary>
        Mail = 3
    }
}