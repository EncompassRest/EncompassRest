using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum NmlsLienStatus
    {
        [EnumMember(Value = "Secured by a first lien")]
        SecuredByAFirstLien = 0,
        [EnumMember(Value = "Secured by a subordinate lien")]
        SecuredByASubordinateLien = 1,
        [EnumMember(Value = "Not secured by a lien")]
        NotSecuredByALien = 2
    }
}