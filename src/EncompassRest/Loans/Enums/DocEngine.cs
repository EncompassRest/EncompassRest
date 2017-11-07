using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DocEngine
    {
        [EnumMember(Value = "Old_ODI_Encompass_Docs")]
        OldODIEncompassDocs = 0,
        [EnumMember(Value = "New_Encompass_Docs_Solution")]
        NewEncompassDocsSolution = 1
    }
}